Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmConsultaOrdenado
	Inherits System.Windows.Forms.Form
	Dim nlastRowPrograma, nLastRow, nContPrograma As Short
	Dim aRegistros() As Object
    Dim bValidaLinha As Boolean
    Dim asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro = NewRoteiro()
    Dim dtsRoteiro As New MSAClass.AsmxRoteiro.dtsRoteiro
    Dim dtbPrograma As DataTable = New DataTable

	Private Sub cmdExibir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExibir.Click
		
        On Error GoTo Erro
        dtbPrograma.Clear()
        Dim NewRow As DataRow

		Dim nQtd_Total As Integer
		Dim nTotal As Single
        Dim sSequenciaBreak As String = ""
        Dim sHorarioBreak As String = ""
		
		' Consiste os dados
        If Trim(ucVeiculo.Text) = "" Then
            Aviso("Campo Veículo não Pode ser em branco!")
            ucVeiculo.Focus()
            GoTo Saida
        End If

        If Trim(ucData.Text) = "" Then
            Aviso("Campo Data não Pode ser em branco!")
            ucData.Focus()
            GoTo Saida
        End If


        Call ConfiguraGrid()


        dtsRoteiro = asmxRoteiro.spuCarregar_Roteiro(ucVeiculo.Text, UcData.Text, "", 0, 0)
 
        If DtsRoteiro.dtbRoteiro_Ordenado.Count > 0 Then

            Me.Cursor = Cursors.WaitCursor

            With flxConsulta

                nLin = 0
                .Visible = False

                For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows

                    If drw.Indica_Titulo_Break = 1 Then
                        If drw.Encaixe > 0 Then
                            nLin = nLin + 1
                            If nLin >= .Rows - 1 Then
                                .Rows = .Rows + 1
                            End If

                            .Row = nLin
                            .set_MergeRow(.Row, True)

                            If Not drw.IsSequencia_BreakNull Then
                                sSequenciaBreak = drw.Sequencia_Break.ToString
                            Else
                                sSequenciaBreak = drw.Breaks.ToString
                            End If

                            If Not drw.IsCod_ProgramaNull Then
                                .set_TextMatrix(nLin, 1, drw.Cod_Programa)
                            Else
                                .set_TextMatrix(nLin, 1, "")
                            End If


                            For nCont = 2 To 11
                                If Not drw.IsTitulo_BreakNull Then
                                    .set_TextMatrix(nLin, nCont, drw.Titulo_Break.Trim & " - Break " & sSequenciaBreak.Trim)
                                End If

                                'End If
                                .Col = nCont
                                .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter


                            Next nCont

                            .set_RowData(nLin, 1)
                            If Not drw.IsBreaksNull Then
                                .set_TextMatrix(nLin, 12, drw.Breaks)
                            Else
                                drw.Breaks = ""
                            End If

                            For nCont = 1 To .Cols - 1
                                .Col = nCont
                                '.CellBackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                                .CellBackColor = Color.Yellow
                                .CellForeColor = Color.Blue

                            Next

                            '===============Adiciona no Grid de Programa
                            NewRow = dtbPrograma.NewRow
                            nContPrograma = nContPrograma + 1

                            If Not drw.IsCod_ProgramaNull Then
                                NewRow("Programa") = drw.Cod_Programa
                            End If
                            If Not drw.IsBreaksNull Then
                                NewRow("Break") = drw.Breaks
                            End If

                            If Vernulo(drw.Item("Horario_Exibicao").ToString, "") <> "" Then
                                sHorarioBreak = FormatDateTime(drw("Horario_Exibicao"), DateFormat.ShortTime)
                            Else
                                sHorarioBreak = ""
                            End If

                            nTotal = drw.Encaixe Mod 60
                            NewRow("Encaixe") = drw.Encaixe
                            NewRow("Inicio") = sHorarioBreak
                            NewRow("InicioPrograma") = Mid(drw.Inicio_Programa, 12, 5)
                            NewRow("FimPrograma") = Mid(drw.Fim_Programa, 12, 5)
                            NewRow("VeiculoOrigem") = drw.Cod_Veiculo_Origem


                            nQtd_Total = nQtd_Total + 1
                            If sHorarioBreak <> "" Then
                                NewRow.Item("RowData") = 1
                            End If
                            dtbPrograma.Rows.Add(NewRow)

                            If drw.Encaixe = 0 Then
                                nLin = nLin + 1
                                If nLin >= .Rows Then .Rows = .Rows + 1
                            End If
                        End If
                        ElseIf drw.Indica_Titulo_Intervalo = 0 Then
                            nLin = nLin + 1
                            If nLin >= .Rows - 1 Then
                                .Rows = .Rows + 1
                            End If

                            .set_TextMatrix(nLin, 1, drw.Numero_Fita)
                            .set_TextMatrix(nLin, 2, drw.Cod_Comercial)
                            .set_TextMatrix(nLin, 3, drw.Titulo_Comercial)
                            .set_TextMatrix(nLin, 4, drw.Descricao_Produto)
                            .set_TextMatrix(nLin, 5, drw.Duracao)
                            .set_TextMatrix(nLin, 6, drw.Cod_Tipo_Comercial)
                            .set_TextMatrix(nLin, 7, drw.Cod_Cliente)
                            .set_TextMatrix(nLin, 8, drw.Cod_Empresa)
                            If Not drw.IsNumero_MRNull Then
                                .set_TextMatrix(nLin, 9, drw.Numero_MR)
                            End If
                            If Not drw.IsSequencia_MrNull Then
                                .set_TextMatrix(nLin, 10, drw.Sequencia_Mr)
                            End If
                            .set_TextMatrix(nLin, 11, drw.Cod_Programa_Origem)
                            If Not drw.IsChave_AcessoNull Then
                                .set_TextMatrix(nLin, 13, drw.Chave_Acesso)
                            End If
                            If Not drw.IsBreaksNull Then
                                .set_TextMatrix(nLin, 14, drw.Breaks)
                            End If

                        If Not drw.IsHorario_ExibicaoNull Then
                            .set_TextMatrix(nLin, 15, Mid(Vernulo(drw.Horario_Exibicao, ""), 12, 8))
                        End If
                        If Not drw.IsCod_ProgramaNull Then
                            .set_TextMatrix(nLin, 16, drw.Cod_Programa)
                        End If

                        .set_TextMatrix(nLin, 17, drw.Indica_Corte)
                        .set_TextMatrix(nLin, 18, drw.Cod_Veiculo_Origem)

                        Select Case True
                            Case drw.Indica_Midia = 1
                                .set_TextMatrix(nLin, 19, "0")
                            Case drw.Indica_Avulso = 1
                                .set_TextMatrix(nLin, 19, "1")
                            Case drw.Indica_Artistico = 1
                                .set_TextMatrix(nLin, 19, "2")
                        End Select
                        If Not drw.IsID_FitaNull Then
                            .set_TextMatrix(nLin, 20, drw.ID_Fita)
                        End If
                        .Row = nLin
                        If drw.Indica_Corte = 1 Then
                            .Col = 3
                            .CellPicture = Me.imgDesativado.Image
                            .CellPictureAlignment = 8
                        End If

                        If drw.Tipo_Break = 1 Then
                            For nCont = 1 To .Cols - 1
                                .Col = nCont
                                .CellForeColor = System.Drawing.ColorTranslator.FromOle(&HFF00FF)
                            Next
                        End If

                        If drw.Tipo_Break = 0 Then
                            For nCont = 1 To .Cols - 1
                                .Col = nCont
                                .CellForeColor = System.Drawing.ColorTranslator.FromOle(&HFF0000)
                            Next
                        End If

                        If drw.Tipo_Break = 3 Then
                            For nCont = 1 To .Cols - 1
                                .Col = nCont
                                .CellForeColor = System.Drawing.Color.Red
                            Next
                        End If
                        End If
MOVE:
                        If nLin > nQtd_Total Then
                            nQtd_Total = nLin
                        End If

                        Mensagem("Registros " & Str(nLin))

                Next

                .Visible = True


            End With
            Me.Cursor = Cursors.Default

        Else
            GoTo Saida
        End If




Saida:
        With gridBreak
            .RowHeadersVisible = False
            gridBreak.DataSource = dtbPrograma
            .AllowUserToAddRows = False

            For x As Integer = 0 To .Columns.Count - 1
                .Columns(x).ReadOnly = True
                .Columns(x).Visible = False
                .Columns(x).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(x).DefaultCellStyle.SelectionBackColor = .Columns(x).DefaultCellStyle.BackColor
                .Columns(x).DefaultCellStyle.SelectionForeColor = .Columns(x).DefaultCellStyle.ForeColor
            Next
            .Columns("Inicio").ReadOnly = False
            .Columns("Inicio").DefaultCellStyle.SelectionBackColor = Color.Yellow
            .Columns("Inicio").DefaultCellStyle.SelectionForeColor = Color.Black



            .Columns("Programa").HeaderText = "Programa"
            .Columns("Break").HeaderText = "Break"
            .Columns("Encaixe").HeaderText = "Encaixado"
            .Columns("Inicio").HeaderText = "Hora Inicio"




            .Columns("Programa").Visible = True
            .Columns("Break").Visible = True
            .Columns("Encaixe").Visible = True
            .Columns("Inicio").Visible = True

            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False



            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()

        End With
        flxConsulta.Visible = True
        Me.Cursor = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub






    Private Sub cmdRoteiro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        frmConfirmacoes.ShowDialog()
    End Sub

    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub cmdUsuarios_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        frmRoteiro_Usuario.Show()
        frmRoteiro_Usuario.BringToFront()
    End Sub


    Private Sub flxConsulta_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxConsulta.ClickEvent

        With flxConsulta
            .set_TextMatrix(nLastRow, 0, "")
            nLastRow = .Row
            .Col = 0
            .CellFontName = "Wingdings"
            .CellFontSize = 14
            .CellForeColor = System.Drawing.Color.Blue
            .set_TextMatrix(.Row, 0, Chr(240))
        End With

    End Sub

    Private Sub flxConsulta_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxConsulta.DblClick

        On Error GoTo Erro

        With flxConsulta
            If .get_TextMatrix(.Row, 19) = "" Then
                GoTo Saida
            End If

            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
            'Load(frmRoteiroDados)

            Select Case Trim(.get_TextMatrix(.Row, 19))

                Case "0" ' Comerciais de Midia
                    frmRoteiroDados.txtVeiculo.Text = .get_TextMatrix(.Row, 18) ' Veiculo Origem
                    frmRoteiroDados.txtData.Text = UcData.Text ' Data
                    frmRoteiroDados.txtPrograma.Text = .get_TextMatrix(.Row, 11) ' Programa Origem
                    frmRoteiroDados.txtChaveAcesso.Text = .get_TextMatrix(.Row, 13) ' Chave Acesso
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, 1)
                    frmRoteiroDados.chkMidia.CheckState = System.Windows.Forms.CheckState.Checked ' Tipo
                    frmRoteiroDados.ShowDialog()
                Case "1" ' Depositorio Avulso
                    frmRoteiroDados.txtIdFita.Text = .get_TextMatrix(.Row, 20) ' idfita
                    frmRoteiroDados.txtVeiculo.Text = .get_TextMatrix(.Row, 18) ' Veiculo
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, 1) ' Fita
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, 1)
                    frmRoteiroDados.chkAvulso.CheckState = System.Windows.Forms.CheckState.Checked
                    frmRoteiroDados.ShowDialog()
                Case "2" ' Depositorio Artistico
                    frmRoteiroDados.txtIdFita.Text = .get_TextMatrix(.Row, 20) ' idfita
                    frmRoteiroDados.txtVeiculo.Text = .get_TextMatrix(.Row, 18)
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, 1)
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, 1)
                    frmRoteiroDados.chkArtistico.CheckState = System.Windows.Forms.CheckState.Checked
                    frmRoteiroDados.ShowDialog()
            End Select
            frmRoteiroDados.Dispose()
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmConsultaOrdenado_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        asmxRoteiro = NewRoteiro()
        Me.Cursor = Cursors.WaitCursor
        Me.Top = 0
        Me.Left = 0
        Call ConfiguraGrid()
        ucVeiculo.Focus()

        With dtbPrograma
            .Columns.Add("Programa", GetType(System.String))
            .Columns.Add("Break", GetType(System.Int16))
            .Columns.Add("Encaixe", GetType(System.Int16))
            .Columns.Add("Inicio", GetType(System.String))
            .Columns.Add("InicioPrograma", GetType(System.String))
            .Columns.Add("FimPrograma", GetType(System.String))
            .Columns.Add("VeiculoOrigem", GetType(System.String))
            .Columns.Add("RowData", GetType(System.Int16))
        End With

        Me.Cursor = Cursors.Default
Saida:
        Me.Cursor = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub
    Private Sub ConfiguraGrid()
        flxConsulta.Clear()
        With flxConsulta
            .Visible = False
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .BackColorBkg = .BackColor
            .set_RowHeight(0, 315)
            .RowHeightMin = 300
            .ScrollTrack = True
            .FormatString = "^|^Fita|^Com|<Titulo do Comercial|<Produto|^Dur.|^Tipo|^Cliente|^Empresa|^Contrato|^Seq|^Origem|^Break|Chave Acesso|Break do Comercial|Hor.Exibiçao|Programa|Indica Corte|Veiculo Origem|Tipo|Id_Chave"
            .WordWrap = True

            .Rows = 2
            .Font = VB6.FontChangeSize(.Font, 8)
            .set_ColWidth(0, 330)
            .set_ColWidth(1, 975) ' Fita
            .set_ColWidth(2, 500) ' Cod. Comercial
            .set_ColWidth(3, 3400) ' Titulo do Comercial
            .set_ColWidth(4, 2445) ' Produto
            .set_ColWidth(5, 630) ' Duracao
            .set_ColWidth(6, 1000) ' Tipo do Comercial
            .set_ColWidth(7, 0) ' Cliente
            .set_ColWidth(8, 1000) ' Empresa
            .set_ColWidth(9, 1000) ' Contrato
            .set_ColWidth(10, 500) ' Sequencia
            .set_ColWidth(11, 1000) ' Programa Origem
            .set_ColWidth(12, 1000) ' Break
            .set_ColWidth(13, 1300) ' Chave de Acesso
            .set_ColWidth(14, 0)    ' Break do Comercial
            .set_ColWidth(15, 1200) ' Horario de Exibicao
            .set_ColWidth(16, 0)    ' Cod. Programa
            .set_ColWidth(17, 0)    ' Indica Corte
            .set_ColWidth(18, 1500) ' Veiculo Origem
            .set_ColWidth(19, 0)    ' 0=Midia 1=Avulso 2=Artistivo
            .set_ColWidth(20, 0)    ' id_fita

            .Row = 0
            For nCont = 0 To .Cols - 1
                .Col = nCont
                .CellFontSize = 8
            Next


            nLastRow = 1
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictRows
            .set_TextMatrix(nLastRow, 0, "")
            .Row = 1
            .Col = 0
            .CellFontName = "Wingdings"
            .CellFontSize = 14
            .CellForeColor = System.Drawing.Color.Blue
            .set_TextMatrix(1, 0, Chr(240))
            .TopRow = 1
            .LeftCol = 1

        End With
Saida:
        flxConsulta.Visible = True

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub

    Private Sub gridBreak_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridBreak.CellClick
        Dim strPrograma As String = ""
        Dim intBreak As Int16 = -1
        Try
            With gridBreak
                If Not .CurrentCell Is Nothing Then
                    strPrograma = .Item("Programa", e.RowIndex).Value.ToString
                    intBreak = .Item("Break", e.RowIndex).Value
                End If
            End With



            With flxConsulta
                For nCont = 1 To .Rows - 1
                    If .get_TextMatrix(nCont, 1) = strPrograma And .get_TextMatrix(nCont, 12) = intBreak.ToString Then
                        .set_TextMatrix(nLastRow, 0, "")
                        nLastRow = nCont
                        .Row = nLastRow
                        'If .RowIsVisible(.Row) = False Then
                        .TopRow = .Row
                        'End If
                        .Col = 0
                        .CellFontName = "Wingdings"
                        .CellFontSize = 14
                        .CellForeColor = Color.Blue
                        .set_TextMatrix(.Row, 0, Chr(240))
                        Exit For
                    End If
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub gridBreak_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridBreak.CellValidated
        Try
            With gridBreak
                If e.ColumnIndex = .Columns("Inicio").Index Then
                    If .Item(e.ColumnIndex, e.RowIndex).FormattedValue.ToString.Trim <> "" Then
                        .Item(e.ColumnIndex, e.RowIndex).Value = formataHora(.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Trim)
                        .EndEdit()
                    End If
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub gridBreak_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles gridBreak.CellValidating
        Dim strMensagem As String
        Try
            With gridBreak
                .EndEdit()
                If .CurrentCell.ColumnIndex = .Columns("Inicio").Index Then
                    If e.FormattedValue.ToString.Trim <> "" Then

                        If Not isTime(.CurrentCell.EditedFormattedValue) Then
                            Aviso("Horário Inválido")
                            .Item(e.ColumnIndex, e.RowIndex).Value = ""
                            .EndEdit()
                            e.Cancel = True
                            Exit Try
                        End If

                        If Not EstaDentro(.CurrentCell.EditedFormattedValue, .CurrentCell.EditedFormattedValue, .Item("InicioPrograma", .CurrentCell.RowIndex).Value, .Item("FimPrograma", .CurrentCell.RowIndex).Value) Then
                            strMensagem = "Programa : " & .Item("Programa", .CurrentCell.RowIndex).Value
                            strMensagem += "      Inicio : " & .Item("InicioPrograma", .CurrentCell.RowIndex).Value
                            strMensagem += "      Fim : " & .Item("FimPrograma", .CurrentCell.RowIndex).Value & vbCrLf
                            strMensagem += "Horário do Break está fora do horário do Programa, Confirma ? "
                            If Not Aviso(strMensagem, vbYesNo) Then

                                .Item(e.ColumnIndex, e.RowIndex).Value = ""
                                .EndEdit()
                                e.Cancel = True
                                Exit Try
                            End If
                        End If

                    End If
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub gridBreak_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gridBreak.EditingControlShowing
        Dim tb As TextBox = CType(e.Control, TextBox)
        With gridBreak
            If .CurrentCell.ColumnIndex = .Columns("Inicio").Index Then
                If Not e.Control Is Nothing Then
                    tb.MaxLength = 5
                End If
                '---inclui um tratamento de evento para o controle TextBox---
                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If

        End With
    End Sub
    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            '==========================================================Tranforma em Maiscula
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = e.KeyChar.ToString.ToUpper
            End If
            '==========================================================tratamento da Hora
            If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
                e.KeyChar = ""
                Exit Sub
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
        End Try
    End Sub
    Private Function EstaDentro(ByVal sHora1 As String, ByVal sHora2 As String, ByVal sHora3 As String, ByVal sHora4 As String) As Boolean

        Dim nMinutos1 As Integer
        Dim nMinutos2 As Integer
        Dim nMinutos3 As Integer
        Dim nMinutos4 As Integer
        sHora1 = Replace(sHora1, ":", "")
        sHora2 = Replace(sHora2, ":", "")
        sHora3 = Replace(sHora3, ":", "")
        sHora4 = Replace(sHora4, ":", "")



        'nMinutos1 = (Val((sHora1, 2)) * 60) + Val(Right(sHora1, 2))
        nMinutos1 = Integer.Parse(sHora1.Substring(0, 2) * 60) + Integer.Parse(sHora1.Substring(2, 2))
        nMinutos2 = Integer.Parse(sHora2.Substring(0, 2) * 60) + Integer.Parse(sHora2.Substring(2, 2))
        nMinutos3 = Integer.Parse(sHora3.Substring(0, 2) * 60) + Integer.Parse(sHora3.Substring(2, 2))
        nMinutos4 = Integer.Parse(sHora4.Substring(0, 2) * 60) + Integer.Parse(sHora4.Substring(2, 2))

        
        EstaDentro = False
        Do
            If nMinutos1 = nMinutos3 Or nMinutos1 = nMinutos4 Then
                EstaDentro = True
                Exit Do
            End If
            nMinutos1 = nMinutos1 + 1
            If nMinutos1 = 2440 Then
                nMinutos1 = 0
            End If
            If nMinutos1 = nMinutos2 + 1 Or nMinutos1 = nMinutos4 + 1 Then
                Exit Do
            End If
        Loop

        If Not EstaDentro Then
            nMinutos1 = Integer.Parse(sHora1.Substring(0, 2) * 60) + Integer.Parse(sHora1.Substring(2, 2))
            nMinutos2 = Integer.Parse(sHora2.Substring(0, 2) * 60) + Integer.Parse(sHora2.Substring(2, 2))
            nMinutos3 = Integer.Parse(sHora3.Substring(0, 2) * 60) + Integer.Parse(sHora3.Substring(2, 2))
            nMinutos4 = Integer.Parse(sHora4.Substring(0, 2) * 60) + Integer.Parse(sHora4.Substring(2, 2))

            Do
                If nMinutos3 = nMinutos1 Then
                    EstaDentro = True
                    Exit Do
                End If
                nMinutos3 = nMinutos3 + 1
                If nMinutos3 = 2440 Then
                    nMinutos3 = 0
                End If
                If nMinutos3 = nMinutos4 + 1 Then
                    Exit Do
                End If
            Loop
        End If

    End Function

    Private Sub btnPropagar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click, Button1.Click
        Me.Cursor = Cursors.WaitCursor

        Try
            With gridBreak
                For nRowBreak As Integer = 0 To .Rows.Count - 1
                    If .Item("Inicio", nRowBreak).Value.ToString.Trim <> "" Then
                        Call PropagaHorario(.Item("Programa", nRowBreak).Value, .Item("Break", nRowBreak).Value, .Item("Inicio", nRowBreak).Value)
                    End If
                Next nRowBreak
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub PropagaHorario(ByVal Par_Programa As String, ByVal Par_Break As Int16, ByVal Par_Horario As String)



        Dim iHoraExibicao As Long
        Dim iHora As String
        Dim IMinuto As String
        Dim iSegundos As String
        Try
            Par_Horario = Par_Horario.Replace(":", "")
            iHoraExibicao = Integer.Parse(Par_Horario.Substring(0, 2) * 60) + Integer.Parse(Par_Horario.Substring(2, 2))
            If Par_Programa = "" Or Par_Horario = "" Then
                Exit Try
            End If

            With flxConsulta
                For nCont = 1 To .Rows - 1
                    If flxConsulta.get_TextMatrix(nCont, 16) = Par_Programa And Trim(flxConsulta.get_TextMatrix(nCont, 14)) = Par_Break.ToString.Trim And Val(flxConsulta.get_TextMatrix(nCont, 17)) = 0 Then
                        If .get_TextMatrix(nCont, 14) <> "" Then
                            iHora = Int(iHoraExibicao / 3600)
                            IMinuto = Int(iHoraExibicao / 60) Mod 60
                            iSegundos = iHoraExibicao Mod 60
                            .set_TextMatrix(nCont, 15, StrZero(iHora, 2) & ":" & StrZero(IMinuto, 2) & ":" & StrZero(iSegundos, 2))
                            iHoraExibicao = iHoraExibicao + .get_TextMatrix(nCont, 5)
                            If iHoraExibicao >= 86400 Then
                                iHoraExibicao = iHoraExibicao - 86400
                            End If
                        End If

                    End If
                Next nCont
            End With



        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub


    Private Sub cmdSalvarBaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvarBaixa.Click
        Dim sStringPrograma As String = ""
        Dim sStringBreak As String = ""
        Dim sStringHorario As String = ""

        Dim sStringProgramaVeiculacao As String = ""
        Dim sStringChaveAcesso As String = ""
        Dim sStringHorarioVeiculacao As String = ""

        Dim sPrograma As String = ""
        Dim sBreak As String = ""
        Dim sHorario As String = ""
        Dim sChaveAcesso As String = ""

        On Error GoTo Erro


        If ucVeiculo.Text.Trim = "" Or UcData.Text.Trim = "" Then
            Aviso("Veiculo e Data devem ser Informados")
            GoTo Saida
        End If

        If Not Aviso("Esse processo irá baixar as veiculaçoes e salvar horários informados no Break, Confirma ?", vbYesNo, vbQuestion, "Atenção") Then
            Exit Sub
        End If

        With gridBreak
            For nCont = 0 To .Rows.Count - 1

                If .Item("Programa", nCont).Value.ToString.Trim <> "" Then
                    sPrograma = .Item("Programa", nCont).Value
                    sBreak = .Item("Break", nCont).Value
                    sHorario = .Item("Inicio", nCont).Value
                    sPrograma = sPrograma & Space(5 - Len(sPrograma)) & "#"
                    sBreak = sBreak & Space(5 - Len(sBreak)) & "#"

                    If sHorario <> "" Then
                        sHorario = sHorario & Space(5 - Len(sHorario)) & "#"
                        sStringPrograma = sStringPrograma & sPrograma
                        sStringBreak = sStringBreak & sBreak
                        sStringHorario = sStringHorario & sHorario
                    End If
                End If
            Next nCont
        End With

        With flxConsulta
            For nCont = 1 To .Rows - 1
                '  Se tem Horario, chave de acesso e não esta com qualidade de falha
                If Trim(.get_TextMatrix(nCont, 15)) <> "" And .get_TextMatrix(nCont, 13) <> "" And Val(.get_TextMatrix(nCont, 17)) = 0 Then
                    ' Se a veiculacao pertence a este veiculo
                    If .get_TextMatrix(nCont, 18) = ucVeiculo.Text Then
                        sPrograma = Trim(.get_TextMatrix(nCont, 11))
                        sChaveAcesso = Trim(.get_TextMatrix(nCont, 13))
                        sHorario = Trim(.get_TextMatrix(nCont, 15))

                        sPrograma = sPrograma & Space(8 - Len(sPrograma)) & "#"
                        sChaveAcesso = sChaveAcesso & Space(8 - Len(sChaveAcesso)) & "#"
                        sHorario = sHorario & Space(8 - Len(sHorario)) & "#"

                        sStringProgramaVeiculacao = sStringProgramaVeiculacao & sPrograma
                        sStringChaveAcesso = sStringChaveAcesso & sChaveAcesso
                        sStringHorarioVeiculacao = sStringHorarioVeiculacao & sHorario
                    End If
                End If
            Next nCont
        End With

        If Trim(sStringPrograma) <> "" And Trim(sStringHorario) <> "" Then
            If asmxRoteiro.spuBaixaRoteiroOrdenado(ucVeiculo.Text, UcData.Text, sStringPrograma, sStringBreak, sStringHorario, sStringProgramaVeiculacao, sStringChaveAcesso, sStringHorarioVeiculacao) Then
                Aviso("Baixa Gravada com Sucesso")
            Else
                Aviso("Houve erro durante a gravação. Verifique se os horários foram salvo")
            End If
        End If
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
End Class