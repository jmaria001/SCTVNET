Public Class frmGrade
    Dim dtbVeiculo As DataTable
    Dim dtbFaixaHoraria As DataTable
    Dim dtbCritica As DataTable
    Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
    Public FaixaHoraria As String = ""
    Public CodVeiculo As String = ""
    Public Atualizar As Boolean = False
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub frmGrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0
        Call CarregaListaVeiculo()
        Call CarregaListaFaixaHoraria()
    End Sub

    Private Sub CarregaListaVeiculo()
        Try
            Dim dtsVeiculo As DataSet = New DataSet
            EstiloGrid(gridVeiculo, 1)
            dtsVeiculo = clsGeneric.fnSqlExecute("Execute PrNet_Veiculo_L @Par_Cod_Usuario = '" & gsUsuario & "'")
            dtbVeiculo = dtsVeiculo.Tables(0)
            With gridVeiculo
                .ReadOnly = False
                dtbVeiculo = dtsVeiculo.Tables(0)
                dtbVeiculo.Columns.Add("Check", GetType(System.Boolean))

                For Each row As DataRow In dtbVeiculo.Rows
                    row.Item("Check") = False
                Next
                .DataSource = dtbVeiculo

                .Columns("Check").HeaderText = ""
                .Columns("Cod_Veiculo").HeaderText = "Código"
                .Columns("Nome_Veiculo").HeaderText = "Nome"

                .Columns("Check").DisplayIndex = 0
                .Columns("Cod_Veiculo").DisplayIndex = 1
                .Columns("Nome_Veiculo").DisplayIndex = 2



                '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                '.AutoResizeColumns()
                '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                '.AutoResizeRows()
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
                .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor

                .Columns("Check").ReadOnly = False
                .Columns("Cod_Veiculo").ReadOnly = True
                .Columns("Nome_Veiculo").ReadOnly = True

                .Columns("Check").Width = 20
                .Columns("Cod_Veiculo").Width = 50
                .Columns("Nome_Veiculo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .AutoResizeColumn(2)

                If Me.CodVeiculo <> "" Then
                    For Each row As DataGridViewRow In gridVeiculo.Rows
                        If gridVeiculo.Item(0, row.Index).Value = Me.CodVeiculo Then
                            .Item("Check", row.Index).Value = True
                            Exit For
                        End If
                    Next
                End If

            End With
        Catch ex As Exception'
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaListaFaixaHoraria()
        Try
            Dim dtsFaixa As DataSet = New DataSet
            dtsFaixa = clsGeneric.fnSqlExecute("Execute PrNet_FaixaHoraria_L")
            dtbFaixaHoraria = dtsFaixa.Tables(0)

            With cboFaixaHoraria
                .DisplayMember = "Nome_Faixa"
                .ValueMember = "Id_Faixa"
                .DataSource = dtbFaixaHoraria
                .SelectedIndex = -1

                If Me.FaixaHoraria <> "" Then
                    .SelectedIndex = .FindString(Me.FaixaHoraria, 0)
                End If

            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub chkTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodos.Click
        Try
            chkDom.Checked = chkTodos.Checked
            chkSeg.Checked = chkTodos.Checked
            chkTer.Checked = chkTodos.Checked
            chkQua.Checked = chkTodos.Checked
            chkQui.Checked = chkTodos.Checked
            chkSex.Checked = chkTodos.Checked
            chkSab.Checked = chkTodos.Checked
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnGrade_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrade.Cancel_Click
        Me.Hide()
    End Sub

    Private Sub btnGrade_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrade.Ok_Click
        Dim bolErro As Boolean = False
        Dim strDiaSemana As String
        Dim strVeiculo As String = ""
        Dim cls As MSAClass.AsmxGrade.asmxGrade = NewGrade()
        dtbcritica = New DataTable
        gridCritica.DataSource = Nothing
        gridCritica.Refresh()
        ucPropagarAte.MensagemErro = ""
        ucPropagarDE.MensagemErro = ""
        ucPropagarAte.Refresh()
        ucPropagarDE.Refresh()

        Try
            strVeiculo = fMontaStringVeiculo()
            If strVeiculo = "" Then
                Aviso("Nenhum Veiculo foi Selecionado")
                Exit Try
            End If
            

            '========================Campos Obrigatorias
            For Each obj As Object In groupProgramacao.Controls
                If TypeOf obj Is WUC.UcText Then
                    If obj.obrigatorio And obj.Text.Trim = "" Then
                        obj.MensagemErro = "Campo de preenchimento obrigatório"
                        bolErro = True
                    End If
                End If
            Next

            For Each obj As Object In GroupPropagar.Controls
                If TypeOf obj Is WUC.UcText Then
                    If obj.obrigatorio And obj.Text.Trim = "" Then
                        obj.MensagemErro = "Campo de preenchimento obrigatório"
                        bolErro = True
                    End If
                End If
            Next

            If ucPropagarDE.DataTextValue > ucPropagarAte.DataTextValue Then
                ucPropagarDE.MensagemErro = "Data Inicio deve ser maior ou igual a data final"
                ucPropagarAte.MensagemErro = "Data Inicio deve ser maior ou igual a data final"
                bolErro = True
            End If

            If bolErro Then
                Aviso("Houve inconsistências no preenchimento.Passe o mouse sobre o simbolo de erro para ver a descrição")
                Exit Try
            End If

            strDiaSemana = ""
            strDiaSemana += IIf(chkDom.Checked, "S", "N")
            strDiaSemana += IIf(chkSeg.Checked, "S", "N")
            strDiaSemana += IIf(chkTer.Checked, "S", "N")
            strDiaSemana += IIf(chkQua.Checked, "S", "N")
            strDiaSemana += IIf(chkQui.Checked, "S", "N")
            strDiaSemana += IIf(chkSex.Checked, "S", "N")
            strDiaSemana += IIf(chkSab.Checked, "S", "N")

            If strDiaSemana = "NNNNNNN" Then
                Aviso("Nenhum dia da Semana foi selecionado")
                Exit Try
            End If

            If cboFaixaHoraria.SelectedIndex < 0 Then
                Aviso("Faixa Horaria não foi Informada")
                Exit Try
            End If

            Me.Cursor = Cursors.WaitCursor
            '=====================Atualiza BD
            dtbCritica = cls.SalvarGrade(strVeiculo, _
                                ucPrograma.Text, _
                                ucPropagarDE.DataTextValue, _
                                ucPropagarAte.DataTextValue, _
                                ucHoraInicio.Text, _
                                ucHoraTermino.Text, _
                                strDiaSemana, _
                                cboFaixaHoraria.SelectedValue, _
                                0, _
                                ucDisponibilidade.DataNumberValue, _
                                0, _
                                ucDisponibilidade.DataNumberValue, _
                                gsUsuario)
            Me.Atualizar = True

            '=====================Mostra Ocorrencias
            EstiloGrid(gridCritica, 1)
            With gridCritica
                .DataSource = dtbCritica
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .Columns("Critica").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .AutoResizeColumn(.Columns("Critica").Index)
                .Columns("Data_Exibicao").DefaultCellStyle.Format = "dd/MM/yyyy"
            End With
            'LimpaCampos(groupProgramacao)
            'LimpaCampos(GroupPropagar)
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default 
        End Try
    End Sub

    Private Function fMontaStringVeiculo() As String
        Dim strVeiculo As String = ""
        gridVeiculo.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dtbVeiculo.AcceptChanges()

        Try
            With gridVeiculo
                For x As Integer = 0 To .Rows.Count - 1
                    If .Item("Check", x).Value Then
                        strVeiculo += .Item("Cod_Veiculo", x).Value
                    End If
                Next
            End With
            Return strVeiculo
        Catch ex As Exception
            ShowErro(ex)
            Return ""
        End Try
    End Function

    
    Private Sub btnPrograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrograma.Click
        Dim dtb As DataTable = New DataTable
        Dim cls As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
        Dim strVeiculo As String = ""
        Try
            strVeiculo = fMontaStringVeiculo()
            If strVeiculo = "" Then
                Aviso("Algum veículo deve ser selecionado antes de escolher o programa")
            End If
            dtb = clsGeneric.fnSqlExecute("PrNet_Programa_Veiculo_L '" & strVeiculo & "'").Tables(0)

            frmConsulta.Source = dtb
            frmConsulta.sqlQuery = Nothing
            frmConsulta.ShowDialog()
            If frmConsulta.OkClick Then
                ucPrograma.Text = frmConsulta.Codigo
                ucPrograma.Descricao = frmConsulta.Descricao
            End If
            frmConsulta.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub ucPrograma_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ucPrograma.Validating
        Dim dtb As DataTable = New DataTable
        Dim cls As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
        Dim strVeiculo As String = ""
        Try
            If ucPrograma.Text.Trim <> "" Then
                strVeiculo = fMontaStringVeiculo()
                If strVeiculo = "" Then
                    Aviso("Algum veículo deve ser selecionado antes de escolher o programa")
                    e.Cancel = True
                    ucPrograma.Text = ""
                    Exit Sub
                End If
                dtb = clsGeneric.fnSqlExecute("PrNet_Programa_Veiculo_L '" & strVeiculo & "'").Tables(0)
                If dtb.Select("Cod_programa = '" & ucPrograma.Text & "'").Length = 0 Then
                    Aviso("Esse programa nao existe ou não pertence aos veiculos selecionados")
                    e.Cancel = True
                    ucPrograma.Text = ""
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

End Class