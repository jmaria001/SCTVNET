Public Class frmGradeExibicao
    Dim dtsGrade As DataSet = New DataSet
    Dim clsGrade As MSAClass.AsmxGrade.asmxGrade = NewGrade()
    Dim dtbSaldo As New DataTable
    Dim bolCarregou As Boolean = False

    Private Sub frmGradeExibicao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmGradeOperacoes.Dispose()
    End Sub
    Private Sub frmGradeExibicao_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            Me.Top = 0
            Me.Left = 0
            btnNovo.Enabled = VePermissao(192)
            ucVeiculo.Usuario = gsUsuario
            dtbSaldo.Columns.Add("Tipo", GetType(String))
            dtbSaldo.Columns.Add("Dispo", GetType(Integer))
            dtbSaldo.Columns.Add("Absorvido", GetType(Integer))
            dtbSaldo.Columns.Add("Saldo", GetType(Integer))

        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub btnExibir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExibir.Click
        Me.Carrega()
        bolCarregou = True
    End Sub
    Private Sub Carrega()
        Dim btGrade As Byte
        Dim btOrdenacao As Byte
        Dim Dtr() As DataRow = Nothing
        Dim strQuery As String
        Try
            If ucCompetencia.Text.ToString.Trim = "" Then
                Aviso("Competência deve ser informada")
                Exit Try
            End If


            If ucVeiculo.Text.Trim = "" And ucCompetencia.Text = "" Then
                Aviso("Nenhum Filtro foi Informado")
                Exit Try
            End If

            Select Case True
                Case optNet.Checked
                    btGrade = 0
                Case optRede.Checked
                    btGrade = 1
                Case optLocal.Checked
                    btGrade = 2
            End Select

            Select Case True
                Case optSequencia.Checked
                    btOrdenacao = 0
                Case optCodigo.Checked
                    btOrdenacao = 1
            End Select


            Me.Cursor = Cursors.WaitCursor

            dtsGrade = Nothing
            dtsGrade = clsGrade.fnGrade_Exibicao(ucVeiculo.Text, fnCompetenciaStringtoInt(ucCompetencia.Text), btOrdenacao, btGrade)
            If dtsGrade.Tables(0).Rows.Count = 0 Then
                Aviso("Nenhum Registro foi Encontrado com esse filtro")
                Exit Try
            End If

            '=====Monta o Grid
            With gridGrade
                .DataSource = dtsGrade.Tables(0)
                .ReadOnly = True
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .SelectionMode = DataGridViewSelectionMode.CellSelect

                .Columns("Dia").Width = 30
                .Columns("Dia_Semana").Width = 30
                .Columns("Dia_Semana").HeaderText = ""

                For x As Integer = .Columns("01").Index To .ColumnCount - 1
                    .Columns(x).Width = 50
                    .Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Next
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoResizeColumns()
                '.DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
                .DefaultCellStyle.SelectionBackColor = Color.LightGreen

                '===================================Monta os Estilos
                For r As Integer = 0 To .Rows.Count - 1
                    For c As Integer = .Columns("01").Index To .ColumnCount - 1
                        strQuery = "Dia = " & .Item("Dia", r).Value
                        strQuery += " And Cod_Programa = '" & .Item(c, r).Value.ToString.Trim & "'"
                        Dtr = dtsGrade.Tables(1).Select(strQuery)
                        If Dtr.Length > 0 Then
                            If Dtr(0).Item("Indica_Desativado") = 1 Then
                                .Item(c, r).Style.ForeColor = picDesativado.BackColor
                            ElseIf (optNet.Checked And Dtr(0).Item("saldo_net") > 0) _
                            Or (optRede.Checked And Dtr(0).Item("saldo_Programa") > 0) _
                            Or (optLocal.Checked And Dtr(0).Item("saldo_Local") > 0) Then
                                .Item(c, r).Style.ForeColor = picPositivo.BackColor
                            ElseIf (optNet.Checked And Dtr(0).Item("saldo_net") = 0) _
                            Or (optRede.Checked And Dtr(0).Item("saldo_Programa") = 0) _
                            Or (optLocal.Checked And Dtr(0).Item("saldo_Local") = 0) Then
                                .Item(c, r).Style.ForeColor = picZerado.BackColor

                            ElseIf (optNet.Checked And Dtr(0).Item("saldo_net") < 0) _
                            Or (optRede.Checked And Dtr(0).Item("saldo_Programa") < 0) _
                            Or (optLocal.Checked And Dtr(0).Item("saldo_Local") < 0) Then
                                .Item(c, r).Style.ForeColor = picEstourado.BackColor
                            End If
                            '.Item(c, r).Style.SelectionBackColor = .Item(c, r).Style.BackColor
                            .Item(c, r).Style.SelectionForeColor = .Item(c, r).Style.ForeColor

                        End If
                    Next
                Next
                .CurrentCell = .Item(2, 0)
                MostraDados()
                .Focus()
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub MostraDados()
        Dim strQuery As String
        Dim Dtr() As DataRow
        Dim drwDispo As DataRow
        Try

            LimpaCampos(groupDados)
            gridDispo.ClearSelection()
            dtbSaldo.Clear()

            With gridGrade
                If gridGrade.CurrentCell Is Nothing Then
                    Exit Try
                End If

                If .CurrentCell.ColumnIndex >= .Columns("01").Index Then
                    strQuery = "Dia = " & .Item("Dia", .CurrentCell.RowIndex).Value
                    strQuery += " And Cod_Programa = '" & .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex).Value.ToString.Trim & "'"
                    Dtr = dtsGrade.Tables(1).Select(strQuery)
                    If Dtr.Length > 0 Then

                        ucCodigo.Text = Dtr(0).Item("Cod_Programa")
                        ucTitulo.Text = Dtr(0).Item("Titulo")
                        ucData.Text = FormataData(Dtr(0).Item("data_Exibicao"))
                        ucHora.Text = VB6.Format(Dtr(0).Item("Horario_Inicial"), "hh:mm")
                        ucHoraFim.Text = VB6.Format(Dtr(0).Item("Horario_Final"), "hh:mm")
                        chkRotativo.Checked = Vernulo(Dtr(0).Item("Indica_Rotativo"), 0) = 1
                        UcFaixaHoraria.Text = Vernulo(Dtr(0).Item("Nome_Faixa"), "")



                        drwDispo = dtbSaldo.NewRow
                        drwDispo("Tipo") = "Net"
                        drwDispo("Dispo") = Dtr(0).Item("Dispo_Net")
                        drwDispo("Absorvido") = Dtr(0).Item("Absorvido_Net")
                        drwDispo("Saldo") = Dtr(0).Item("Saldo_Net")
                        dtbSaldo.Rows.Add(drwDispo)

                        drwDispo = dtbSaldo.NewRow
                        drwDispo("Tipo") = "Local"
                        drwDispo("Dispo") = Dtr(0).Item("Dispo_Local")
                        drwDispo("Absorvido") = Dtr(0).Item("Absorvido_Local")
                        drwDispo("Saldo") = Dtr(0).Item("Saldo_Local")
                        dtbSaldo.Rows.Add(drwDispo)

                        drwDispo = dtbSaldo.NewRow
                        drwDispo("Tipo") = "Rede"
                        drwDispo("Dispo") = Dtr(0).Item("Dispo_Programa")
                        drwDispo("Absorvido") = Dtr(0).Item("Absorvido_Programa")
                        drwDispo("Saldo") = Dtr(0).Item("Saldo_Programa")
                        dtbSaldo.Rows.Add(drwDispo)

                        gridDispo.DataSource = dtbSaldo
                        gridDispo.ReadOnly = True
                        gridDispo.AllowUserToAddRows = False
                        gridDispo.AllowUserToResizeColumns = False
                        gridDispo.AllowUserToResizeRows = False
                        gridDispo.RowHeadersVisible = False
                        gridDispo.DefaultCellStyle.SelectionBackColor = gridDispo.DefaultCellStyle.BackColor
                        gridDispo.DefaultCellStyle.SelectionForeColor = gridDispo.DefaultCellStyle.ForeColor
                        gridDispo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        gridDispo.AutoResizeColumns()
                    End If
                End If

                For x As Integer = 0 To .Columns.Count - 1
                    .Columns(x).SortMode = DataGridViewColumnSortMode.NotSortable
                Next

            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    
    Public Sub New()
        InitializeComponent()
        Me.MdiParent = mdiPrincipal

    End Sub

    Private Sub gridGrade_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridGrade.CurrentCellChanged
        Call MostraDados()
    End Sub

    Private Sub optNet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bolCarregou Then btnExibir.PerformClick()
    End Sub

    Private Sub optRede_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bolCarregou Then btnExibir.PerformClick()
    End Sub

    Private Sub optLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bolCarregou Then btnExibir.PerformClick()
    End Sub

    Private Sub optCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bolCarregou Then btnExibir.PerformClick()
    End Sub

    Private Sub optSequencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bolCarregou Then btnExibir.PerformClick()
    End Sub

    Private Sub btnOpcoes_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles btnOpcoes.ItemClicked

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        frmGrade.ShowDialog()
        frmGrade.BringToFront()
        If frmGrade.Atualizar Then
            Me.Carrega()
        End If
        frmGrade.Dispose()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim drw() As DataRow = Nothing
        Dim strQuery As String = ""
        Try
            If Not isEmptyCell(gridGrade.CurrentCell) Then
                If Not ConsisteOperacao(gridGrade.CurrentCell.Value) Then
                    Exit Sub
                End If
            End If

            With gridGrade
                If .CurrentRow Is Nothing Then
                    Exit Try
                End If
                If .CurrentCell.ColumnIndex < .Columns("01").Index Then
                    Exit Try
                End If
                strQuery = "Dia = " & .Item("Dia", .CurrentRow.Index).Value
                strQuery += " And Cod_Programa = '" & .CurrentCell.Value.ToString.Trim & "'"
                drw = dtsGrade.Tables(1).Select(strQuery)
                If drw.Length > 0 Then
                    With frmGrade
                        .ucPrograma.Text = drw(0).Item("Cod_Programa")
                        .ucPrograma.Descricao = drw(0).Item("Titulo")
                        .ucHoraInicio.Text = VB6.Format(drw(0).Item("Horario_Inicial"), "hh:mm")
                        .ucHoraTermino.Text = VB6.Format(drw(0).Item("Horario_Final"), "hh:mm")
                        .FaixaHoraria = drw(0).Item("NOME_FAIXA").ToString
                        .CodVeiculo = ucVeiculo.Text

                        .ucDisponibilidade.Text = drw(0).Item("Dispo_Local")
                        .ucPropagarDE.Text = VB6.Format(drw(0).Item("Data_Exibicao").ToString, "dd/mm/yyyy")
                        .ucPropagarAte.Text = VB6.Format(drw(0).Item("Data_Exibicao").ToString, "dd/mm/yyyy")

                        .ucPropagarDE.DataTextValue = VB6.Format(.ucPropagarDE.Text, "yyyy/mm/dd")
                        .ucPropagarAte.DataTextValue = VB6.Format(.ucPropagarAte.Text, "yyyy/mm/dd")

                        Select Case DatePart(DateInterval.Weekday, drw(0).Item("Data_Exibicao"))
                            Case 1
                                .chkDom.Checked = True
                            Case 2
                                .chkSeg.Checked = True
                            Case 3
                                .chkTer.Checked = True
                            Case 4
                                .chkQua.Checked = True
                            Case 5
                                .chkQui.Checked = True
                            Case 6
                                .chkSex.Checked = True
                            Case 7
                                .chkSab.Checked = True
                        End Select
                        .ShowDialog()
                        If frmGrade.Atualizar Then
                            Me.Carrega()
                        End If
                        frmGrade.Dispose()
                    End With
                Else
                    Aviso("Grade não Encontrada")
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        'Me.Operacao(sender.Name.ToString)
        If Not isEmptyCell(gridGrade.CurrentCell) Then
            If ConsisteOperacao(gridGrade.CurrentCell.Value) Then
                Me.Operacao(sender.Name.ToString)
            End If
        End If

    End Sub

    Private Sub Operacao(ByVal pOperacao As String)
        Dim strQuery As String
        Dim drw As DataRow()
        Try
            With gridGrade
                If .CurrentCell Is Nothing Then
                    Exit Try
                End If
                If .CurrentCell.ColumnIndex < .Columns("01").Index Then
                    Exit Try
                End If

                strQuery = "Dia = " & .Item("Dia", .CurrentRow.Index).Value
                strQuery += " And Cod_Programa = '" & .CurrentCell.Value.ToString.Trim & "'"
                drw = dtsGrade.Tables(1).Select(strQuery)
                If drw.Length > 0 Then
                    With frmGradeOperacoes
                        Select Case pOperacao
                            Case btnExcluir.Name
                                .Operacao = frmGradeOperacoes.enuOperacao.Excluir
                            Case btnDesativar.Name
                                .Operacao = frmGradeOperacoes.enuOperacao.Desativar
                            Case btnReativar.Name
                                .Operacao = frmGradeOperacoes.enuOperacao.Reativar
                        End Select

                        .ucPrograma.Text = drw(0).Item("Cod_Programa")
                        .ucPrograma.Descricao = drw(0).Item("Titulo")
                        .ucHoraInicio.Text = VB6.Format(drw(0).Item("Horario_Inicial"), "hh:mm")
                        .ucHoraTermino.Text = VB6.Format(drw(0).Item("Horario_Final"), "hh:mm")
                        .UcFaixaHoraria.Text = drw(0).Item("NOME_FAIXA").ToString
                        .CodVeiculo = ucVeiculo.Text

                        .ucDisponibilidade.Text = drw(0).Item("Dispo_Local")
                        .ucPropagarDE.Text = VB6.Format(drw(0).Item("Data_Exibicao").ToString, "dd/mm/yyyy")
                        .ucPropagarAte.Text = VB6.Format(drw(0).Item("Data_Exibicao").ToString, "dd/mm/yyyy")

                        .ucPropagarDE.DataTextValue = VB6.Format(.ucPropagarDE.Text, "yyyy/mm/dd")
                        .ucPropagarAte.DataTextValue = VB6.Format(.ucPropagarAte.Text, "yyyy/mm/dd")

                        Select Case DatePart(DateInterval.Weekday, drw(0).Item("Data_Exibicao"))
                            Case 1
                                .chkDom.Checked = True
                            Case 2
                                .chkSeg.Checked = True
                            Case 3
                                .chkTer.Checked = True
                            Case 4
                                .chkQua.Checked = True
                            Case 5
                                .chkQui.Checked = True
                            Case 6
                                .chkSex.Checked = True
                            Case 7
                                .chkSab.Checked = True
                        End Select
                        .ShowDialog()
                        If .Atualizar Then
                            Me.Carrega()
                        End If
                        .Dispose()
                    End With

                Else
                    Aviso("Grade não Encontrada")
                End If

            End With


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnReativar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReativar.Click
        'Me.Operacao(sender.Name.ToString)
        If Not isEmptyCell(gridGrade.CurrentCell) Then
            If ConsisteOperacao(gridGrade.CurrentCell.Value) Then
                Me.Operacao(sender.Name.ToString)
            End If
        End If

    End Sub

    Private Sub btnDesativar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesativar.Click
        If Not isEmptyCell(gridGrade.CurrentCell) Then
            If ConsisteOperacao(gridGrade.CurrentCell.Value) Then
                Me.Operacao(sender.Name.ToString)
            End If
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    
    Private Sub gridGrade_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridGrade.DoubleClick
        'Try
        '    If Not gridGrade.CurrentCell Is Nothing Then
        '        If gridGrade.CurrentCell.ColumnIndex > gridGrade.Columns("01").Index Then
        '            With frmprogramacaoprevista
        '                .CodVeiculo = ucVeiculo.Text
        '                .CodPrograma = gridGrade.CurrentCell.Value.ToString.Trim
        '                .DataExibicao = ucData.Text
        '                Select Case True
        '                    Case optNet.Checked
        '                        .Indica_Grade = 0
        '                    Case optLocal.Checked
        '                        .Indica_Grade = 2
        '                    Case optRede.Checked
        '                        .Indica_Grade = 1
        '                End Select
        '                .NomePrograma = ucTitulo.Text
        '                .NomeVeiculo = ucVeiculo.Descricao
        '            End With
        '            frmprogramacaoprevista.ShowDialog()
        '            frmprogramacaoprevista.Dispose()
        '        End If
        '    End If
        'Catch ex As Exception
        '    ShowErro(ex)
        'Finally
        'End Try
    End Sub

    Private Sub gridGrade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gridGrade.KeyPress
        With gridGrade
            ProcuraPrograma(e.KeyChar.ToString.ToUpper)
        End With
    End Sub
    Private Sub ProcuraPrograma(ByVal pLetra As String)
        Dim intStart As Integer
        Dim bolEncontrou As Boolean
        Try
            With gridGrade
                If Not .CurrentRow Is Nothing Then
                    If .CurrentCell.ColumnIndex < .Columns("01").Index Then
                        intStart = .Columns("01").Index
                    Else
                        intStart = .CurrentCell.ColumnIndex + 1
                    End If
                End If
                '-------------------------------procura a partira da posicao atual
                For x As Integer = intStart To .Columns.Count - 1
                    If Not isEmptyCell(.Item(x, .CurrentRow.Index)) Then
                        If .Item(x, .CurrentRow.Index).Value.ToString.ToUpper.Substring(0, 1) = pLetra Then
                            .CurrentCell = .Item(x, .CurrentRow.Index)
                            bolEncontrou = True
                            Exit For
                        End If
                    End If
                Next
                If Not bolEncontrou Then
                    For x As Integer = .Columns("01").Index To .Columns.Count - 1
                        If Not isEmptyCell(.Item(x, .CurrentRow.Index)) Then
                            If .Item(x, .CurrentRow.Index).Value.ToString.ToUpper.Substring(0, 1) = pLetra Then
                                .CurrentCell = .Item(x, .CurrentRow.Index)
                                Exit For
                            End If
                        End If
                    Next
                End If
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Function ConsisteOperacao(ByVal Par_Programa As String) As Boolean
        Dim dtb As DataTable = New DataTable
        Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
        Dim strVeiculo As String = ""
        ConsisteOperacao = True
        Try
            If Par_Programa <> "" Then
                strVeiculo = strVeiculodoUsuario
                strVeiculo = strVeiculo.Replace(",", "")
                strVeiculo = strVeiculo.Replace("'", "")
                dtb = clsGeneric.fnSqlExecute("PrNet_Programa_Veiculo_L '" & strVeiculo & "'").Tables(0)
                If dtb.Select("Cod_programa = '" & Par_Programa & "'").Length = 0 Then
                    Aviso("Operação não Permitida para esse Programa")
                    ConsisteOperacao = False
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Function


End Class
