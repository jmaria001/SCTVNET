Public Class frmGradeOperacoes
    Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric
    Dim dtbVeiculo As DataTable
    Dim dtsVeiculo As DataSet
    Dim dtbCritica As DataTable
    Public CodVeiculo As String = ""
    Dim _Operacao As enuOperacao
    Public Atualizar As Boolean = False
    Enum enuOperacao
        Excluir
        Desativar
        Reativar
    End Enum
    Public Property Operacao() As enuOperacao
        Get
            Operacao = _Operacao
        End Get
        Set(ByVal value As enuOperacao)
            _Operacao = value
            Select Case value
                Case enuOperacao.Desativar
                    Me.Text = "Desativação da Grade"
                    GroupPropagar.Text = "Período a ser Desativado"
                    groupOpcoes.Visible = False
                Case enuOperacao.Reativar
                    Me.Text = "Reativação da Grade"
                    GroupPropagar.Text = "Período a ser Reativado"
                    groupOpcoes.Visible = False
                Case enuOperacao.Excluir
                    Me.Text = "Exclusão da Grade"
                    GroupPropagar.Text = "Período a ser Excluido"
                    groupOpcoes.Enabled = True
            End Select
        End Set
    End Property


    Private Sub frmGradeOperacoes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
        Me.CarregaListaVeiculo()
    End Sub

    Private Sub CarregaListaVeiculo()
        Try
            dtsVeiculo = New DataSet
            dtbVeiculo = New DataTable
            EstiloGrid(gridVeiculo, 1)
            clsGeneric = NewGeneric()
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
        Catch ex As Exception '
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

            Me.Cursor = Cursors.WaitCursor
            '=====================Atualiza BD
            Select Case Me.Operacao
                Case enuOperacao.Excluir
                    dtbCritica = cls.ExcluirGrade(strVeiculo, _
                                                    ucPrograma.Text, _
                                                    ucPropagarDE.Text, _
                                                    ucPropagarAte.Text, _
                                                    strDiaSemana, _
                                                    chkApagarRoteiro.Checked, _
                                                    chkApagarBreak.Checked, _
                                                    gsUsuario)

                Case enuOperacao.Desativar
                    dtbCritica = cls.DesativarGrade(strVeiculo, _
                                                    ucPrograma.Text, _
                                                    ucPropagarDE.Text, _
                                                    ucPropagarAte.Text, _
                                                    strDiaSemana, _
                                                    0, _
                                                    gsUsuario)
                Case enuOperacao.Reativar
                    dtbCritica = cls.DesativarGrade(strVeiculo, _
                                ucPrograma.Text, _
                                ucPropagarDE.Text, _
                                ucPropagarAte.Text, _
                                strDiaSemana, _
                                1, _
                                gsUsuario)

            End Select
            '=====================Mostra Ocorrencias
            EstiloGrid(gridCritica, 1)
            With gridCritica
                .DataSource = dtbCritica
                .Columns("Data_Exibicao").DefaultCellStyle.Format = "dd/MM/yyyy"
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .Columns("Critica").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .AutoResizeColumn(.Columns("Critica").Index)
            End With
            Atualizar = True
            'Me.Dispose()
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
End Class