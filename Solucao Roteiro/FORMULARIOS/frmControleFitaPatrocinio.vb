Public Class frmControleFitaPatrocinio
    Dim clsControleFita As MSAClass.asmxControleFita.asmxControleFita = NewControleFita()
    Dim strTipoFitaPatrocinio As String = ""
    Dim bolCellValidade As Boolean = True
    Dim dtbFita As New DataTable()
    Private Sub frmControleFitaPatrocinio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        clsControleFita.spuDeletarReserva(gsUsuario)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub frmControleFitaPatrocinio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        SetaUserControl(Me)
        strTipoFitaPatrocinio = fParametro(279) & ","

    End Sub

    Private Sub ucCompetencia_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucCompetencia.Validated
        Dim strCompenciaInt As String = ""
        If ucCompetencia.Text.Trim <> "" Then
            strCompenciaInt = ucCompetencia.Text.Substring(3, 4) & ucCompetencia.Text.Substring(0, 2)
            ucProgramaPatrocinado.Competencia = Int32.Parse(strCompenciaInt)
        Else
            ucProgramaPatrocinado.Competencia = 0
        End If
    End Sub

    Private Sub btnPendencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPendencia.Click
        Dim strSql As String
        Dim strCompenciaInt As String = ""

        If ucCompetencia.Text.Trim = "" Then
            Aviso("É Necessario Preencher uma competência para verificar as pendências")
            Exit Sub
        End If
        


        strCompenciaInt = ucCompetencia.Text.Substring(3, 4) & ucCompetencia.Text.Substring(0, 2)
        strSql = " Execute Pr_Fita_Patrocinio_Pendencia_Numeracao " & strCompenciaInt & "," + "'" + gsUsuario & "'"
        frmDadosLista.Width = 700
        frmDadosLista.Height = 500
        frmDadosLista.QueryDataSource = strSql

        frmDadosLista.ShowDialog()

    End Sub

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click

        dtbFita.Clear()
        Dim NewRow As DataRow
        gridFita.DataSource = Nothing

        Dim lngCompetencia As Long
        Try
            If ucCompetencia.Text.Trim = "" Then
                Aviso("Competência deve ser Informada")
                Exit Sub
            End If
            If ucProgramaPatrocinado.Text.Trim = "" Then
                Aviso("Programa Patrocinado deve ser Informado")
                Exit Sub
            End If
            If ucCodVeiculo.Text.Trim = "" Then
                Aviso("Veículo deve ser Informado")
                Exit Sub
            End If
            lngCompetencia = Long.Parse(ucCompetencia.Text.Substring(3, 4) & ucCompetencia.Text.Substring(0, 2))
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            dtbFita = clsControleFita.spuCarregarFitaPatrocinio(ucCodVeiculo.Text, ucProgramaPatrocinado.Text, lngCompetencia)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            '================Adiciona Linhas Vazias para melhor controle da digitacao no grid
            With dtbFita
                For row As Integer = 0 To 15
                    NewRow = .NewRow()
                    For col As Integer = 0 To .Columns.Count - 1
                        NewRow.Item(col) = DBNull.Value
                    Next col
                    .Rows.Add(NewRow)
                Next row
            End With

            '================Fim

            gridFita.DataSource = dtbFita
            Me.COnfiguraGrid()
            fraFiltro.Enabled = False
            gridFita.ReadOnly = False

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub COnfiguraGrid()


        Dim dc As New DataGridViewTextBoxColumn
        Try
            EstiloGrid(gridFita, 1)
            bolCellValidade = False
            '=============================Remove colunas para criar novamente customizadas
            With gridFita
                .CausesValidation = False
                .Columns.Remove("Cod_Tipo_Comercial")
                .Columns.Remove("Numero_Fita")
                .Columns.Remove("Dia_Inicio")
                .Columns.Remove("Dia_Fim")
                .Columns.Remove("Duracao_Cabeca")
                .Columns.Remove("Obs_Texto")
            End With
            '=============================Recria as colunas 
            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Cod_Tipo_Comercial"
                .MaxInputLength = 2
                .DataPropertyName = "Cod_Tipo_Comercial"
                .HeaderText = "Tipo"
                gridFita.Columns.Add(dc)
            End With


            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Dia_Inicio"
                .MaxInputLength = 2
                .DataPropertyName = "Dia_Inicio"
                .HeaderText = "Dia Inicio"
                gridFita.Columns.Add(dc)
            End With

            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Dia_Fim"
                .MaxInputLength = 2
                .DataPropertyName = "Dia_Fim"
                .HeaderText = "Dia Fim"
                gridFita.Columns.Add(dc)
            End With

            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Numero_Fita"
                .MaxInputLength = 6
                .DataPropertyName = "Numero_Fita"
                .HeaderText = "N.Fita"
                gridFita.Columns.Add(dc)
            End With


            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Duracao_Cabeca"
                .MaxInputLength = 3
                .DataPropertyName = "Duracao_Cabeca"
                .HeaderText = "Dur.Cabeça"
                gridFita.Columns.Add(dc)
            End With

            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Obs_Texto"
                .MaxInputLength = 50
                .DataPropertyName = "Obs_Texto"
                .HeaderText = "Observação"
                gridFita.Columns.Add(dc)
            End With


            With gridFita
                .EnableHeadersVisualStyles = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .AllowUserToOrderColumns = False

                .RowHeadersVisible = True
                .DefaultCellStyle.SelectionBackColor = Color.Yellow
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AllowUserToAddRows = True
                .AllowUserToResizeRows = False
                .SelectionMode = DataGridViewSelectionMode.CellSelect
                .RowHeadersWidth = 40
                .CausesValidation = True
                .ReadOnly = False


                .Columns("Cod_Veiculo").Visible = False
                .Columns("Cod_programa").Visible = False
                .Columns("Inicio_Validade").Visible = False
                .Columns("Fim_Validade").Visible = False
                .Columns("Descricao").Visible = False

                .Columns("Obs_Texto").Visible = True
                .Columns("Cod_Tipo_Comercial").Visible = True
                .Columns("Dia_Inicio").Visible = True
                .Columns("Dia_Fim").Visible = True
                .Columns("Numero_Fita").Visible = True
                .Columns("Duracao_Cabeca").Visible = True

                .Columns("Cod_Tipo_Comercial").Width = 40
                .Columns("Dia_Inicio").Width = 40
                .Columns("Dia_Fim").Width = 40
                .Columns("Numero_Fita").Width = 50
                .Columns("Duracao_Cabeca").Width = 80
                .Columns("Obs_Texto").Width = 300
                '.AutoResizeRows()


            End With
            For Each Column As DataGridViewColumn In gridFita.Columns
                Column.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            bolCellValidade = True
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

 

    Private Sub gridFita_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridFita.CellEndEdit
        Try
            gridFita.Rows(e.RowIndex).ErrorText = ""
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub



    Private Sub gridFita_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridFita.CellValidated
        Try
            With gridFita
                .CommitEdit(New DataGridViewDataErrorContexts)
                If .CausesValidation Then
                    Select Case e.ColumnIndex
                        Case .Columns("Cod_Tipo_Comercial").Index
                        Case .Columns("Dia_Inicio").Index
                        Case .Columns("Dia_Fim").Index
                        Case .Columns("Duracao_Cabeca").Index
                        Case .Columns("Obs_Texto").Index
                    End Select
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub


    Private Sub gridFita_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles gridFita.CellValidating
        Dim strDataTemp As String
        Dim strDiaInicio As String
        Dim strDiaFim As String
        Dim strDataInicio As String
        Dim strDataFim As String
        Dim strCodTipoComercial As String
        Dim strNumeroFita As String

        If Not bolCellValidade Then
            Exit Sub
        End If
        Try
            With gridFita
                If Not String.IsNullOrEmpty(.CurrentCell.EditedFormattedValue) Then
                    Select Case e.ColumnIndex
                        Case .Columns("Cod_Tipo_Comercial").Index
                            If strTipoFitaPatrocinio.IndexOf(.CurrentCell.EditedFormattedValue) = -1 Then
                                Aviso("Tipo de Comercial Inválido para Agrupamento de Fitas Patrocinio")
                                .Rows(e.RowIndex).ErrorText = "Tipo de Comercial Inválido para Agrupamento de Fitas Patrocinio"
                                e.Cancel = True
                            End If

                        Case .Columns("Dia_Inicio").Index
                            strDataTemp = .CurrentCell.EditedFormattedValue.ToString().PadLeft(2, "0") & "/" & ucCompetencia.Text
                            If Not isData(strDataTemp) Then
                                Aviso("Dia Inválido")
                                .Rows(e.RowIndex).ErrorText = "Dia Inválido"
                                e.Cancel = True
                            End If

                        Case .Columns("Dia_Fim").Index
                            strDataTemp = .CurrentCell.EditedFormattedValue.ToString().PadLeft(2, "0") & "/" & ucCompetencia.Text
                            If Not isData(strDataTemp) Then
                                Aviso("Dia Inválido")
                                .Rows(e.RowIndex).ErrorText = "Dia Inválido"
                                e.Cancel = True
                            End If

                        Case .Columns("Numero_Fita").Index
                            strNumeroFita = .CurrentCell.EditedFormattedValue.ToString.Trim
                            strCodTipoComercial = .Item("Cod_Tipo_Comercial", .CurrentRow.Index).EditedFormattedValue.ToString()
                            strDiaInicio = .Item("Dia_Inicio", .CurrentRow.Index).EditedFormattedValue.ToString().PadLeft(2, "0")
                            strDiaFim = .Item("Dia_Fim", .CurrentRow.Index).EditedFormattedValue.ToString().PadLeft(2, "0")
                            strDataFim = .Item("Dia_Fim", .CurrentRow.Index).EditedFormattedValue.ToString().PadLeft(2, "0") & "/" & ucCompetencia.Text
                            strDataInicio = strDiaInicio & "/" & ucCompetencia.Text
                            strDataFim = strDiaFim & "/" & ucCompetencia.Text

                            
                            If strCodTipoComercial = "" Then
                                Aviso("Tipo do Comercial deve ser ditigado antes de digitar o Número da Fita")
                                .Rows(e.RowIndex).ErrorText = "Tipo do Comercial deve ser ditigado antes de digitar o Número da Fita"""
                                e.Cancel = True
                                Exit Try
                            End If

                            If strDiaFim.Trim = "00" Or strDiaInicio.Trim = "00" Then
                                Aviso("Devem ser digitados os dias Inicio e Fim antes de  digitar o Número da Fita")
                                .Rows(e.RowIndex).ErrorText = "Devem ser digitados os dias Inicio e Fim antes de  digitar o Número da Fita"
                                e.Cancel = True
                            End If
                            If Not ConsisteFita(ucCodVeiculo.Text, strDataInicio, strDataFim, ucProgramaPatrocinado.Text, strNumeroFita, strCodTipoComercial) Then
                                .Rows(e.RowIndex).ErrorText = "Fita Inválida"
                                e.Cancel = True
                                Exit Try
                            End If
                    End Select
                End If

            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            If e.Cancel Then
                'gridFita.CurrentCell.Value = DBNull.Value
                gridFita.EndEdit()
            End If
        End Try

    End Sub

    Private Sub gridFita_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gridFita.EditingControlShowing
        Dim txtbox As TextBox = CType(e.Control, TextBox)
        AddHandler txtbox.KeyPress, AddressOf Grid_Fita_CellKeyPress
    End Sub

    Private Sub Grid_Fita_CellKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.KeyChar = e.KeyChar.ToString.ToUpper
            With gridFita
                Select Case gridFita.CurrentCell.ColumnIndex
                    Case .Columns("dia_Inicio").Index, .Columns("dia_fim").Index, .Columns("Duracao_Cabeca").Index
                        If Not IsNumeric(e.KeyChar) Then
                            e.KeyChar = Nothing
                        End If
                End Select
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

   
    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.Click
        gridFita.DataSource = Nothing
        fraFiltro.Enabled = True
        clsControleFita.spuDeletarReserva(gsUsuario)
    End Sub

    Private Sub btnContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContratos.Click

        Dim strSql As String
        Dim strCompenciaInt As String = ""
        If ucCompetencia.Text.Trim = "" Then
            Aviso("Competência deve ser informada")
            Exit Sub
        End If
        If ucProgramaPatrocinado.Text.Trim = "" Then
            Aviso("Programa Patrocinado deve ser Informado")
            Exit Sub
        End If
        If ucCodVeiculo.Text.Trim = "" Then
            Aviso("Veículo deve ser informado")
            Exit Sub
        End If
        If ucCodVeiculo.Text.Trim = "" Then
            Aviso("Veículo deve ser informado")
            Exit Sub
        End If

        strCompenciaInt = ucCompetencia.Text.Substring(3, 4) & ucCompetencia.Text.Substring(0, 2)
        strSql = " Execute prNet_Fita_Patrocinio_Contrato_S " & strCompenciaInt & ",'" & ucCodVeiculo.Text & "'" & ",'" & ucProgramaPatrocinado.Text & "'"
        frmDadosLista.Width = 700
        frmDadosLista.Height = 500
        frmDadosLista.QueryDataSource = strSql


        frmDadosLista.ShowDialog()
    End Sub

    Private Sub btnProximoNumero_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProximoNumero.Click
        Dim strNumeroFita As String
        Try
            If gridFita.CurrentRow Is Nothing Then
                Aviso("Posicione sobre uma linha do grid para determinar próximo numero")
                Exit Sub
            End If
            If ucCodVeiculo.Text.Trim = "" Then
                Aviso("Codigo de Veículo deve ser informado para determinar próximo número")
                Exit Sub
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            strNumeroFita = clsControleFita.spuFitaDisponivel(ucCodVeiculo.Text, -1, -1, 0, gsUsuario, 0)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            gridFita.Item("Numero_Fita", gridFita.CurrentRow.Index).Value = strNumeroFita

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnOkCancel_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles btnOkCancel.HelpRequested

    End Sub

   
    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Dim strTipoComercial1 As String
        Dim strNumeroFita1 As String
        Dim btDataInicio1 As Integer
        Dim btDataFim1 As Integer
        Dim strTipoComercial2 As String
        Dim strNumeroFita2 As String
        Dim btDataInicio2 As Integer
        Dim btDataFim2 As Integer
        Dim lngCompetencia As Long
        Dim strLinhasDuplicadas As String = ""
        Try
            '================================Consiste se todos os campos estao digitador
            With gridFita
                For nRow As Integer = 0 To .Rows.Count - 1
                    If .Item("Cod_Tipo_Comercial", nRow).FormattedValue.ToString().Trim <> "" Then
                        If Val(.Item("Dia_Inicio", nRow).FormattedValue) = 0 Or Val(.Item("Dia_Fim", nRow).FormattedValue) = 0 Then
                            Aviso(" Informações estão incompletas na linha " & nRow + 1)
                            Exit Sub
                        End If
                    End If
                Next

            End With
            '================================Consiste se existe conflito de dados para o Mesmo Tipo de Comercial
            With gridFita
                For nRow As Integer = 0 To .Rows.Count - 1
                    If .Item("Cod_Tipo_Comercial", nRow).FormattedValue <> "" Then

                        strTipoComercial1 = .Item("Cod_Tipo_Comercial", nRow).FormattedValue
                        btDataInicio1 = Val(.Item("Dia_Inicio", nRow).FormattedValue)
                        btDataFim1 = Val(.Item("Dia_Fim", nRow).FormattedValue)

                        For nLoop As Integer = 1 To .Rows.Count - 1
                            If .Item("Cod_Tipo_Comercial", nLoop).FormattedValue <> "" Then
                                strTipoComercial2 = .Item("Cod_Tipo_Comercial", nLoop).FormattedValue
                                btDataInicio2 = Val(.Item("Dia_Inicio", nLoop).FormattedValue.ToString())
                                btDataFim2 = Val(.Item("Dia_Fim", nLoop).FormattedValue.ToString())

                                If nRow <> nLoop Then
                                    If strTipoComercial1 = strTipoComercial2 Then
                                        If Between(btDataInicio1, btDataInicio2, btDataFim2) Or _
                                           Between(btDataFim1, btDataInicio2, btDataFim2) Or _
                                           Between(btDataInicio2, btDataInicio1, btDataFim1) Or _
                                           Between(btDataFim2, btDataInicio1, btDataFim1) Then
                                            Aviso("Linhas " & nRow + 1 & " e " & nLoop + 1 & " estão em conflito de data")
                                            Exit Sub
                                        End If
                                    End If
                                End If
                            End If
                        Next nLoop
                    End If
                Next nRow
            End With

            '================================Consiste se existe Duplicidades de Numero de Fitas 
            With gridFita
                For nRow As Integer = 0 To .Rows.Count - 1
                    If .Item("Cod_Tipo_Comercial", nRow).FormattedValue <> "" Then

                        strTipoComercial1 = .Item("Cod_Tipo_Comercial", nRow).FormattedValue
                        btDataInicio1 = Val(.Item("Dia_Inicio", nRow).FormattedValue)
                        btDataFim1 = Val(.Item("Dia_Fim", nRow).FormattedValue)
                        strNumeroFita1 = .Item("Numero_Fita", nRow).FormattedValue

                        For nLoop As Integer = 1 To .Rows.Count - 1
                            If InStr(strLinhasDuplicadas, nRow & ",") = 0 Or InStr(strLinhasDuplicadas, nLoop & ",") = 0 Then
                                If .Item("Cod_Tipo_Comercial", nLoop).FormattedValue <> "" Then
                                    strTipoComercial2 = .Item("Cod_Tipo_Comercial", nLoop).FormattedValue
                                    btDataInicio2 = Val(.Item("Dia_Inicio", nLoop).FormattedValue)
                                    btDataFim2 = Val(.Item("Dia_Fim", nLoop).FormattedValue)
                                    strNumeroFita2 = .Item("Numero_Fita", nLoop).FormattedValue
                                    If nRow <> nLoop Then
                                        'If Between(btDataInicio1, btDataInicio2, btDataFim2) Or _
                                        'Between(btDataFim1, btDataInicio2, btDataFim2) Or _
                                        'Between(btDataInicio2, btDataInicio1, btDataFim1) Or _
                                        'Between(btDataFim2, btDataInicio1, btDataFim1) Then
                                        If Trim(strNumeroFita1) = Trim(strNumeroFita2) Then
                                            strLinhasDuplicadas = strLinhasDuplicadas & nRow & "," & nLoop & ","
                                            If Aviso("Linhas " & nRow + 1 & " e " & nLoop + 1 & " estão com o mesmo numero de fitas. Confirma utilizar o mesmo Numero?", vbYesNo, vbQuestion, "Atenção") = False Then
                                                .Item("Numero_Fita", nLoop).Value = ""
                                                Exit Sub
                                            End If
                                        End If
                                        'End If
                                    End If
                                End If
                            End If
                        Next nLoop
                    End If
                Next nRow
            End With



            '=================================Grava Digitacao
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            lngCompetencia = Int32.Parse(ucCompetencia.Text.Substring(3, 4) & ucCompetencia.Text.Substring(0, 2))
            clsControleFita.spuGravarFitaPatrocinio(lngCompetencia, ucCodVeiculo.Text, ucProgramaPatrocinado.Text, dtbFita, gsUsuario)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Aviso("Dados Gravados com Sucesso")
        Catch ex As Exception
            ShowErro(ex)
        End Try
        btnCancela_Click(New Object, New EventArgs)
    End Sub

    Private Sub btnOkCancel_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Close()
    End Sub
    Private Function ConsisteFita(ByVal pCodVeiculo As String, ByVal pDataInicio As String, ByVal pDataFim As String, ByVal pCodPrograma As String, ByVal pNumeroFita As String, ByVal pCodTipoComercial As String) As Boolean
        ConsisteFita = True
        Try
            Dim strMensagem As String = ""
            strMensagem = clsControleFita.spuConsisteFitaPatrocinio(pCodVeiculo, DateTime.Parse(pDataInicio), DateTime.Parse(pDataFim), pCodPrograma, pNumeroFita, pCodTipoComercial)
            If strMensagem.Trim <> "" Then
                Aviso(strMensagem)
                ConsisteFita = False
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
        Return ConsisteFita
    End Function


End Class