Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmBaixa_Horario_Exibicao_Programa
	Inherits System.Windows.Forms.Form
    Dim bValidaLinha As Boolean
	Dim mousex, mousey As Short
	Dim aVeiculos() As String
    Dim bErroProcessamento As Boolean
    Dim asmxGrade As MSAClass.AsmxGrade.asmxGrade = NewGrade()
    Dim dtsGrade As New MSAClass.asmxGrade.dtsGrade
	
	Private Sub AjustaHorariosSub(ByRef Par_Linha As Short)
		On Error GoTo Erro
		Dim nRow As Short
		Dim nHorarioInicio As Integer
		Dim nHorarioFim As Integer
		Dim nDuracao As Integer
		
		If chkAjustarInicio.CheckState = 0 Then
			GoTo Saida
		End If
		
		Dim sHorario As String

		With flxPrograma
			sHorario = Trim(.get_TextMatrix(Par_Linha, 5))
			If sHorario = "" Then
				GoTo Saida
			End If
			
			For nRow = Par_Linha + 1 To .Rows - 1
				If .get_TextMatrix(nRow, 0) <> "" Then
					
					nHorarioInicio = (Val(VB.Left(sHorario, 2)) * 3600) + (Val(Mid(sHorario, 4, 2)) * 60) + (Val(VB.Right(sHorario, 2)))
					nHorarioInicio = nHorarioInicio + 1
					nDuracao = Val(.get_TextMatrix(nRow, 7)) * 60
					.set_TextMatrix(nRow, 4, fSegundosToHora(nHorarioInicio))
					
					
					
					nHorarioFim = nHorarioInicio + nDuracao
					.set_TextMatrix(nRow, 5, fSegundosToHora(nHorarioFim))
					sHorario = .get_TextMatrix(nRow, 5)
					
					
				End If
			Next nRow
			
		End With
		
Saida: 
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
	End Sub
	
	Private Function fSegundosToHora(ByRef Par_Segundos As Integer) As String
		
		On Error GoTo Erro
		Dim nHora As Short
		Dim nMinuto As Short
		Dim nSegundo As Short
		
		If Par_Segundos >= 86400 Then
			Par_Segundos = Par_Segundos - 86400
		End If
		
		nMinuto = Int(Par_Segundos / 60)
		nSegundo = Par_Segundos Mod 60
		
		nHora = Int(nMinuto / 60)
		nMinuto = nMinuto Mod 60
		
		
		
		fSegundosToHora = VB6.Format(nHora, "00") & ":" & VB6.Format(nMinuto, "00") & ":" & VB6.Format(nSegundo, "00")
		
Saida: 
		Exit Function
Erro: 
		Erro(Err.Number)
		Resume Saida
	End Function
	
	Private Sub Grava(ByRef Par_Veiculo As String)
        Dim nRow As Short
        Dim drw As MSAClass.AsmxGrade.dtsGrade.dtbGradeRow

        With flxPrograma
            For nRow = 1 To .Rows - 1

                If .get_TextMatrix(nRow, 0) <> "" Then
                    drw = DtsGrade.dtbGrade.FindByCod_VeiculoData_ExibicaoCod_Programa(Par_Veiculo, UcData.Text, .get_TextMatrix(nRow, 0))
                    If Not .get_TextMatrix(nRow, 4) = "" Then
                        If Not IsDate(.get_TextMatrix(nRow, 4)) Then
                            .set_TextMatrix(nRow, 4, "")
                            Aviso("Programa:" & .get_TextMatrix(nRow, 0) & " - Horário Inicial Inválido")
                            bErroProcessamento = True
                            Exit Sub
                        End If
                        drw.Horario_Inicio_Real = .get_TextMatrix(nRow, 4)
                        drw.Horario_Inicio_Real = DateTime.Parse("01/01/1900 " & drw.Horario_Inicio_Real)
                    End If
                    If Not .get_TextMatrix(nRow, 5) = "" Then
                        If Not IsDate(.get_TextMatrix(nRow, 5)) Then
                            .set_TextMatrix(nRow, 5, "")
                            Aviso("Programa:" & .get_TextMatrix(nRow, 0) & " - Horário Final Inválido")
                            bErroProcessamento = True
                            Exit Sub
                        End If
                        drw.Horario_Final_Real = .get_TextMatrix(nRow, 5)
                        drw.Horario_Final_Real = DateTime.Parse("01/01/1900 " & drw.Horario_Final_Real)
                    End If

                End If

            Next nRow
        End With




Saida:
        Exit Sub
Erro:
        bErroProcessamento = True
        Erro(Err.Number)
        Resume Saida
    End Sub

    Sub Monta_Grade()

        On Error GoTo Erro
        With flxPrograma
            .Visible = False
            .Clear()
            .BackColorBkg = Color.White
            .SelectionMode = SelectionModeSettings.flexSelectionByRow
            .HighLight = HighLightSettings.flexHighlightNever
            .FocusRect = FocusRectSettings.flexFocusNone
            .FixedCols = 0
            .FormatString = "<Codigo|<Título|^Início Previsto|^Final Previsto|^Início Real|^Final Real|Ordem|Duracao|d_inicio|d_Fim"
            .set_ColWidth(0, 960)
            .set_ColWidth(1, 3330)
            .set_ColWidth(2, 1155)
            .set_ColWidth(3, 1125)
            .set_ColWidth(4, 1095)
            .set_ColWidth(5, 1065)
            .set_ColWidth(6, 0)
            .set_ColWidth(7, 0)
            .set_ColWidth(8, 0)
            .set_ColWidth(9, 0)

            .ScrollTrack = True
            .Rows = 20


            .AllowBigSelection = False
            .RowHeightMin = 285

            .Row = 1
            .Col = 4
            txtInicio_Real.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(.Left) + .CellLeft))
            txtInicio_Real.Width = VB6.TwipsToPixelsX(.CellWidth)

            .Col = 5
            txtFinal_Real.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(.Left) + .CellLeft))
            txtFinal_Real.Width = VB6.TwipsToPixelsX(.CellWidth)

            .Row = 1
            .Col = 0
            .ColSel = .Cols - 1


        End With

        txtInicio_Real.Text = ""
        txtFinal_Real.Text = ""
        txtInicio_Real.Visible = False
        txtFinal_Real.Visible = False


Saida:
        flxPrograma.Visible = True
        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub



    Private Sub cmdExibir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExibir.Click

        On Error GoTo Erro

        Dim sTabelas As String
        Dim sCampos As String
        Dim nCont As Short

        Dim nHorarioEmissora As Short
        Dim nHorarioInicio As Short
        Dim nHorarioFinal As Short
        Dim sHorarioInicio As String
        Dim sHorarioFinal As String
        Dim nDuracao As Short

        Dim sDataInicio As String
        Dim sDataFim As String

        If Trim(ucVeiculo.Text) = "" Then
            Aviso("Veículo não pode ficar em branco.")
            txtVeiculo.Focus()
            GoTo Saida
        End If

        If Trim(UcData.Text) = "" Then
            Aviso("Data não pode ficar em branco.")
            UcData.Focus()
            GoTo Saida
        End If

        Call Monta_Grade()

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim drwHoraria As MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow()
        drwHoraria = mdiPrincipal.dtsUsuario.dtbUsuario_Veiculo.Select("Cod_Veiculo = " & ucVeiculo.Text)

        If Not drwHoraria(0).IsHora_Inicio_ProgramacaoNull Then
            txtHorarioEmissora.Text = drwHoraria(0).Hora_Inicio_Programacao
            txtHorarioEmissora.Tag = txtHorarioEmissora.Text
        Else
            txtHorarioEmissora.Text = ""
            txtHorarioEmissora.Tag = txtHorarioEmissora.Text
        End If

        txtDataInicio.Text = UcData.Text
        txtHoraInicio.Text = txtHorarioEmissora.Text & ":00"

        txtDataTermino.Text = DateAdd("d", 1, txtDataInicio.Text)
        txtHoraTermino.Text = AddTime("S", -1, txtHoraInicio.Text)

        dtsGrade = asmxGrade.spuCarregar_Grade(ucVeiculo.Text, UcData.Text, "")


        If DtsGrade.dtbGrade.Count = 0 Then
            Aviso("Não Foi encontrado nenhum registro.")
            GoTo Saida
        End If

        nCont = 0


        With flxPrograma
            .Rows = 1
            .Redraw = False
            nHorarioEmissora = (Val(VB.Left(txtHoraInicio.Text, 2)) * 60) + Val(VB.Right(txtHoraInicio.Text, 2))

            For Each drw As MSAClass.AsmxGrade.dtsGrade.dtbGradeRow In dtsGrade.dtbGrade.Select("Indica_Rotativo  = 0 and Data_Desativacao is null")
                nCont = nCont + 1
                If .Rows <= nCont Then
                    .Rows = .Rows + 1
                End If
                .set_TextMatrix(nCont, 0, Trim(drw.Cod_Programa))
                .set_TextMatrix(nCont, 1, FirstCaps(drw.Titulo))
                If Not drw.IsHorario_InicialNull Then
                    .set_TextMatrix(nCont, 2, drw.Horario_Inicial.ToLongTimeString)
                End If
                If Not drw.IsHorario_FinalNull Then
                    .set_TextMatrix(nCont, 3, drw.Horario_Final.ToLongTimeString)
                End If
                If Not drw.IsHorario_Inicio_RealNull Then
                    .set_TextMatrix(nCont, 4, drw.Horario_Inicio_Real.ToLongTimeString)
                End If
                If Not drw.IsHorario_Final_RealNull Then
                    .set_TextMatrix(nCont, 5, drw.Horario_Final_Real.ToLongTimeString)
                End If


                'verifica se o mudou de dia
                sHorarioInicio = drw.Horario_Inicial.ToLongTimeString
                sHorarioFinal = drw.Horario_Final.ToLongTimeString
                nHorarioInicio = (Val(VB.Left(sHorarioInicio, 2)) * 60) + Val(VB.Right(sHorarioInicio, 2))
                nHorarioFinal = (Val(VB.Left(sHorarioFinal, 2)) * 60) + Val(VB.Right(sHorarioFinal, 2))

                sDataInicio = UcData.Text
                sDataFim = UcData.Text

                If drw.Horario_Inicial.ToLongTimeString < txtHoraTermino.Text Then
                    sDataInicio = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, 1, CDate(UcData.Text)))
                    sDataFim = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, 1, CDate(UcData.Text)))
                ElseIf drw.Horario_Final.ToLongTimeString < txtHoraTermino.Text Then
                    sDataInicio = UcData.Text
                    sDataFim = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, 1, CDate(UcData.Text)))
                End If



                If VB6.Format(sDataInicio, "yyyy-mm-dd") > VB6.Format(UcData.Text, "yyyy-mm-dd") Then
                    nHorarioInicio = nHorarioInicio + 1440
                End If

                If VB6.Format(sDataFim, "yyyy-mm-dd") > VB6.Format(UcData.Text, "yyyy-mm-dd") Then
                    nHorarioFinal = nHorarioFinal + 1440
                End If

                nDuracao = nHorarioFinal - nHorarioInicio

                .set_TextMatrix(nCont, 6, VB6.Format(sDataInicio, "yyyy-mm-dd") & VB6.Format(nHorarioInicio, "000000"))
                .set_TextMatrix(nCont, 7, nDuracao)

            Next

            .Col = 6
            .Sort = 7

            If .Rows < 20 Then
                .Rows = 20
            End If

            .Redraw = True
            .Row = 1
            flxPrograma_RowColChange(flxPrograma, New System.EventArgs())

        End With

        txtVeiculo.Tag = ucVeiculo.Text
        UcData.Tag = UcData.Text
        cmdGravar.Enabled = True
        'cmdExibir.Enabled = False

Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub



    Private Sub cmdGravar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGravar.Click

        On Error GoTo Erro

        Dim sData, sMensagem, sHorarioAnterior As String
        Dim nRow1, nVei As Short

        '' Consiste se alterou veiculo ou data apos digitacao
        'If UcVeiculo.Tag <> UcVeiculo.Codigo Or UcData.Tag <> UcData.Text Then
        '    sMensagem = "Veículo ou Data foram trocados apos a exibiçao dos dados." & vbCrLf
        '    sMensagem = sMensagem & "Digite o Veiculo ou a data correta ou clique em 'Exibir' novamente"
        '    Aviso(sMensagem)
        '    GoTo Saida
        'End If

        ' Consiste Se digitou as duas colunas de horarios
        With flxPrograma
            For nRow1 = 1 To .Rows - 1
                If Trim(.get_TextMatrix(nRow1, 4)) <> "" And Trim(.get_TextMatrix(nRow1, 5)) = "" Then
                    Aviso("Programa:" & .get_TextMatrix(nRow1, 0) & " - Horário Final não foi Informado")
                    GoTo Saida
                End If
                If Trim(.get_TextMatrix(nRow1, 5)) <> "" And Trim(.get_TextMatrix(nRow1, 4)) = "" Then
                    Aviso("Programa:" & .get_TextMatrix(nRow1, 0) & " - Horário Inicial não foi Informado")
                    GoTo Saida
                End If

            Next nRow1
        End With



        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        bErroProcessamento = False
        Call Grava(ucVeiculo.Text)
        If bErroProcessamento Then GoTo Saida

        For nVei = 0 To lstVeiculo.Items.Count - 1
            If lstVeiculo.GetItemChecked(nVei) Then
                Call Grava(aVeiculos(nVei))
                If bErroProcessamento Then GoTo Saida
            End If
        Next nVei


        AsmxGrade.spuAtualizar_Grade(DtsGrade)




        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default


        Aviso("Baixa concluída com sucesso.")
        txtFinal_Real.Text = ""
        txtInicio_Real.Text = ""
        ucVeiculo.Text = ""
        UcData.Text = ""
        txtNome_Veiculo.Text = ""
        txtHorarioEmissora.Text = ""

        Call Monta_Grade()
        cmdGravar.Enabled = False

Saida:

        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub

    Private Sub cmdReplicar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReplicar.Click

        picVeiculo.Visible = True
        picVeiculo.BringToFront()

    End Sub

    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Dispose()
    End Sub

    Private Sub cmdSelecaoVeiculo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelecaoVeiculo.Click
        Dim Index As Short = cmdSelecaoVeiculo.GetIndex(eventSender)
        picVeiculo.Visible = False
    End Sub

    Private Sub flxPrograma_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxPrograma.ClickEvent
        flxPrograma_RowColChange(flxPrograma, New System.EventArgs())
    End Sub

    Private Sub flxPrograma_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxPrograma.RowColChange

        On Error GoTo Erro

        With flxPrograma

            If Not .Visible Then
                GoTo Saida
            End If
            .Col = 0
            .ColSel = .Cols - 1

            If .Row = 0 Then
                GoTo Saida
            End If


            If .get_TextMatrix(.Row, 0) <> "" And .get_RowIsVisible(.Row) Then

                txtInicio_Real.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + .CellTop)
                txtInicio_Real.Text = .get_TextMatrix(.Row, 4)
                txtFinal_Real.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + .CellTop)
                txtFinal_Real.Text = .get_TextMatrix(.Row, 5)
                txtInicio_Real.Visible = True
                txtFinal_Real.Visible = True

                txtInicio_Real.Focus()
            Else
                txtInicio_Real.Visible = False
                txtFinal_Real.Visible = False
            End If



        End With

Saida:

        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub


    Private Sub flxPrograma_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxPrograma.Scroll
        txtInicio_Real.Visible = False
        txtFinal_Real.Visible = False
        'flxPrograma_RowColChange

    End Sub

    Private Sub frmBaixa_Horario_Exibicao_Programa_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If KeyAscii = 13 And Me.ActiveControl.Name <> "txtInicio_Real" And Me.ActiveControl.Name <> "txtFinal_Real" Then
            System.Windows.Forms.SendKeys.Send("{tab}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub CarregaVeiculosDoUsuario()

        On Error GoTo Erro
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        lstVeiculo.Items.Clear()
        Dim aVeiculo(0) As Object
        For Each drw As MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow In mdiPrincipal.dtsUsuario.dtbUsuario_Veiculo.Rows
            lstVeiculo.Items.Add(drw.Cod_Veiculo & "-" & drw.Nome_Veiculo)
            ReDim Preserve aVeiculos(lstVeiculo.Items.Count - 1)
            aVeiculos(lstVeiculo.Items.Count - 1) = drw.Cod_Veiculo
        Next


Saida:

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida


    End Sub



    Private Sub frmBaixa_Horario_Exibicao_Programa_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        On Error GoTo Erro
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0

        With picVeiculo
            .Top = VB6.TwipsToPixelsY(1020)
            .Left = VB6.TwipsToPixelsX(675)
            .Width = VB6.TwipsToPixelsX(6990)
            .Height = VB6.TwipsToPixelsY(3060)
            .Visible = False
        End With
        ReDim aVeiculos(0)
        asmxGrade = NewGrade()
        Call CarregaVeiculosDoUsuario()
        Call Monta_Grade()
        ucVeiculo.Focus()



Saida:

        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub

    Private Sub lblSelecaoVeiculo_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblSelecaoVeiculo.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        mousex = X
        mousey = Y
    End Sub

    Private Sub lblSelecaoVeiculo_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblSelecaoVeiculo.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        On Error GoTo Erro
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        Dim MaxTop As Short
        Dim MaxLeft As Short

        With picVeiculo
            If Button = 1 Then
                MaxTop = VB6.PixelsToTwipsY(Me.Height) - 700
                MaxLeft = (VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width)) - VB6.PixelsToTwipsX(.Width)
                VariacaoY = Y - mousey
                VariacaoX = X - mousex
                If VB6.PixelsToTwipsY(.Top) + VariacaoY > 0 And VB6.PixelsToTwipsY(.Top) + VariacaoY < MaxTop Then
                    .Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + VariacaoY)
                End If
                If VB6.PixelsToTwipsX(.Left) + VariacaoX > 0 And VB6.PixelsToTwipsX(.Left) + VariacaoX < MaxLeft Then
                    .Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + VariacaoX)
                End If
            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida


    End Sub


    'UPGRADE_WARNING: Event UCData.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub UCData_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles UcData.TextChanged
        cmdExibir.Enabled = Trim(ucVeiculo.Text) <> "" And Trim(UcData.Text) <> ""
    End Sub




    'UPGRADE_WARNING: Event txtFinal_Real.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtFinal_Real_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFinal_Real.TextChanged
        With flxPrograma
            .set_TextMatrix(.Row, 5, txtFinal_Real.Text)
        End With
    End Sub

    Private Sub txtFinal_Real_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFinal_Real.Enter
        txtFinal_Real.Text = Replace(txtFinal_Real.Text, ":", "")
        seleciona_no_foco(txtFinal_Real)
    End Sub

    Private Sub txtFinal_Real_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtFinal_Real.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode <> System.Windows.Forms.Keys.Up And KeyCode <> System.Windows.Forms.Keys.Down Then
            GoTo Saida
        End If

        Call txtFinal_Real_Validating(txtFinal_Real, New System.ComponentModel.CancelEventArgs(False))
        If bValidaLinha Then
            Call txtInicio_Real_Validating(txtInicio_Real, New System.ComponentModel.CancelEventArgs(False))
        End If

        If Not bValidaLinha Then
            GoTo Saida
        End If

        With flxPrograma
            Select Case KeyCode
                Case System.Windows.Forms.Keys.Down
                    If .Row < .Rows - 1 Then
                        .Row = .Row + 1
                    End If
                Case System.Windows.Forms.Keys.Up
                    If .Row > 1 Then
                        .Row = .Row - 1
                    End If

            End Select
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
    End Sub

    Private Sub txtFinal_Real_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFinal_Real.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        On Error GoTo Erro

        If KeyAscii = 13 Then
            Call txtFinal_Real_Validating(txtFinal_Real, New System.ComponentModel.CancelEventArgs(False))

            If Not bValidaLinha Then
                GoTo Saida
            End If

            With flxPrograma
                If .Row < .Rows - 1 Then
                    Call AjustaHorariosSub((flxPrograma.Row))
                    .Row = .Row + 1
                End If
            End With

        ElseIf (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
            KeyAscii = 0
        End If

Saida:
        GoTo EventExitSub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub txtFinal_Real_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtFinal_Real.Validating
        Dim Cancel As Boolean = eventArgs.Cancel
        On Error GoTo Erro

        Dim sData As String

        txtFinal_Real.Text = Trim(txtFinal_Real.Text)
        If txtFinal_Real.Text = "" Then
            GoTo Saida
        End If

        If txtInicio_Real.Text = "" Then
            Aviso("Horário Inicial não foi Informado")
            Cancel = True
            GoTo Saida
        End If

        'If Not isTime(txtFinal_Real.Text) Then
        '    Aviso("Horário Inválido")
        '    Cancel = True
        '    GoTo Saida
        'End If

        'UPGRADE_WARNING: Couldn't resolve default property of object formataHoraHms(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtFinal_Real.Text = formataHoraHms(txtFinal_Real.Text)

        '----- Controla a Mudanca de Dia
        '   With flxPrograma
        '      For nCont = .Row - 1 To 1 Step -1
        '         If .TextMatrix(nCont, 9) <> "" Then
        '            sData = Mid(.TextMatrix(nCont, 9), 9, 2) & "/" & Mid(.TextMatrix(nCont, 9), 6, 2) & "/" & Left(.TextMatrix(nCont, 9), 4)
        '            Exit For
        '         End If
        '      Next nCont
        '
        '      If sData = "" Then
        '         sData = txtDataInicio
        '      End If
        '
        '      If txtFinal_Real < txtInicio_Real Then
        '         .TextMatrix(.Row, 8) = Format(sData, "yyyy-mm-dd ") & " " & txtInicio_Real
        '         .TextMatrix(.Row, 9) = Format(DateAdd("d", 1, sData), "yyyy-mm-dd ") & " " & txtFinal_Real
        '      Else
        '         .TextMatrix(.Row, 8) = Format(sData, "yyyy-mm-dd ") & " " & txtInicio_Real
        '         .TextMatrix(.Row, 9) = Format(sData, "yyyy-mm-dd ") & " " & txtFinal_Real
        '      End If
        '   End With


Saida:
        bValidaLinha = Not Cancel
        If Cancel Then
            txtFinal_Real.Text = ""
        End If
        GoTo EventExitSub
Erro:
        Cancel = True
        Erro(Err.Number)
        GoTo Saida
        Resume

EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub





    Private Sub txtHoraInicio_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoraInicio.Enter
        txtHoraInicio.Text = Replace(txtHoraInicio.Text, ":", "")
        seleciona_no_foco(txtHoraInicio)
    End Sub


    Private Sub txtHoraInicio_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHoraInicio.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        txtHoraInicio.Text = Trim(txtHoraInicio.Text)
        If txtHoraInicio.Text = "" Then
            GoTo Saida
        End If

        If Not isTime(txtHoraInicio.Text) Then
            Aviso("Horário Inválido")
            Cancel = True
            GoTo Saida
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object formataHoraHms(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtHoraInicio.Text = formataHoraHms(txtHoraInicio.Text)

Saida:
        bValidaLinha = Not Cancel
        If Cancel Then
            txtHoraInicio.Text = ""
        End If
        GoTo EventExitSub

Erro:
        Cancel = True
        Erro(Err.Number)
        GoTo Saida
        Resume
EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub


    Private Sub txtHorarioEmissora_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHorarioEmissora.Enter
        txtHorarioEmissora.Text = Replace(txtHorarioEmissora.Text, ":", "")
        seleciona_no_foco(txtHorarioEmissora)
    End Sub


    Private Sub txtHorarioEmissora_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHorarioEmissora.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub txtHorarioEmissora_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHorarioEmissora.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        txtHorarioEmissora.Text = Trim(txtHorarioEmissora.Text)
        If txtHorarioEmissora.Text = "" Then
            txtHorarioEmissora.Text = txtHorarioEmissora.Tag
        End If

        If Not isTime(txtHorarioEmissora.Text) Then
            Aviso("Horário Inválido")
            Cancel = True
            GoTo Saida
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object formataHora(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtHorarioEmissora.Text = formataHora(txtHorarioEmissora.Text)


Saida:
        bValidaLinha = Not Cancel
        If Cancel Then
            txtHorarioEmissora.Text = ""
        End If
        GoTo EventExitSub

Erro:
        Cancel = True
        Erro(Err.Number)
        GoTo Saida
        Resume


EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub


    Private Sub txtHoraTermino_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHoraTermino.Enter
        txtHoraTermino.Text = Replace(txtHoraTermino.Text, ":", "")
        seleciona_no_foco(txtHoraTermino)

    End Sub


    Private Sub txtHoraTermino_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHoraTermino.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        txtHoraTermino.Text = Trim(txtHoraTermino.Text)
        If txtHoraTermino.Text = "" Then
            GoTo Saida
        End If

        If Not isTime(txtHoraTermino.Text) Then
            Aviso("Horário Inválido")
            Cancel = True
            GoTo Saida
        End If

        txtHoraTermino.Text = formataHoraHms(txtHoraTermino.Text)

Saida:
        bValidaLinha = Not Cancel
        If Cancel Then
            txtHoraTermino.Text = ""
        End If
        GoTo EventExitSub

Erro:
        Cancel = True
        Erro(Err.Number)
        GoTo Saida
        Resume

EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub


    'UPGRADE_WARNING: Event txtInicio_Real.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtInicio_Real_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtInicio_Real.TextChanged
        With flxPrograma
            .set_TextMatrix(.Row, 4, txtInicio_Real.Text)
        End With
    End Sub

    Private Sub txtInicio_Real_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtInicio_Real.Enter
        txtInicio_Real.Text = Replace(txtInicio_Real.Text, ":", "")
        seleciona_no_foco(txtInicio_Real)
    End Sub


    Private Sub txtInicio_Real_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtInicio_Real.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode <> System.Windows.Forms.Keys.Up And KeyCode <> System.Windows.Forms.Keys.Down Then
            GoTo Saida
        End If

        Call txtInicio_Real_Validating(txtInicio_Real, New System.ComponentModel.CancelEventArgs(False))
        If bValidaLinha Then
            Call txtFinal_Real_Validating(txtFinal_Real, New System.ComponentModel.CancelEventArgs(False))
        End If

        If Not bValidaLinha Then
            GoTo Saida
        End If

        With flxPrograma
            Select Case KeyCode
                Case System.Windows.Forms.Keys.Down
                    If .Row < .Rows - 1 Then
                        .Row = .Row + 1
                    End If
                Case System.Windows.Forms.Keys.Up
                    If .Row > 1 Then
                        .Row = .Row - 1
                    End If

            End Select
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
    End Sub

    Private Sub txtInicio_Real_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtInicio_Real.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        On Error GoTo Erro

        If KeyAscii = 13 Then
            Call txtInicio_Real_Validating(txtInicio_Real, New System.ComponentModel.CancelEventArgs(False))
            If Not bValidaLinha Then
                GoTo Saida
            End If
            txtFinal_Real.Focus()
        ElseIf (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 32 And KeyAscii <> 8 Then
            KeyAscii = 0
        End If

Saida:
        GoTo EventExitSub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume


EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub txtInicio_Real_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtInicio_Real.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        txtInicio_Real.Text = Trim(txtInicio_Real.Text)
        If txtInicio_Real.Text = "" Then
            GoTo Saida
        End If

        'If Not isTime(txtInicio_Real.Text) Then
        '    Aviso("Horário Inválido")
        '    Cancel = True
        '    GoTo Saida
        'End If

        'UPGRADE_WARNING: Couldn't resolve default property of object formataHoraHms(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtInicio_Real.Text = formataHoraHms(txtInicio_Real.Text)




Saida:
        bValidaLinha = Not Cancel
        If Cancel Then
            txtInicio_Real.Text = ""
        End If
        GoTo EventExitSub

Erro:
        Cancel = True
        Erro(Err.Number)
        GoTo Saida
        Resume

EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub

    Public Function formataHoraHms(ByRef Par_Hora As String) As Object

        On Error GoTo Erro

        Dim sHora As String
        Dim nCont As Short
        sHora = Replace(Par_Hora, ":", "")
        If Len(sHora) < 6 Then
            sHora = sHora & New String("0", 6 - Len(sHora))
        End If
        '========================> Formata
        formataHoraHms = VB.Left(sHora, 2) & ":" & Mid(sHora, 3, 2) & ":" & VB.Right(sHora, 2)

Saida:

        Exit Function
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Function

    Public Function isTimeHms(ByRef Par_Hora As String) As Boolean
        On Error GoTo Erro
        Dim lRetorno As Boolean
        Dim nMinuto, nHora, nSegundo As Short
        lRetorno = True

        For nCont = 1 To Len(Par_Hora)
            If (Mid(Par_Hora, nCont, 1) < "0" Or Mid(Par_Hora, nCont, 1) > "9") And Mid(Par_Hora, nCont, 1) <> ":" Then
                lRetorno = False
                GoTo Saida
            End If
        Next nCont


        'UPGRADE_WARNING: Couldn't resolve default property of object Replace(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Par_Hora = Replace(Par_Hora, ":", "")

        If Len(Par_Hora) < 6 Then
            Par_Hora = Par_Hora & New String("0", 6 - Len(Par_Hora))
        End If

        nHora = Val(VB.Left(Par_Hora, 2))
        nMinuto = Val(Mid(Par_Hora, 3, 2))
        nSegundo = Val(VB.Right(Par_Hora, 2))

        If nHora > 23 Or nHora < 0 Then
            lRetorno = False
        End If

        If nMinuto > 59 Or nMinuto < 0 Then
            lRetorno = False
        End If

        If nSegundo > 59 Or nSegundo < 0 Then
            lRetorno = False
        End If

Saida:
        isTimeHms = lRetorno
        Exit Function
Erro:
        lRetorno = False
        Erro(Err.Number)
        Resume Saida
    End Function




    Private Sub UcData_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UcData.Validating

    End Sub

    Private Sub flxPrograma_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flxPrograma.Enter

    End Sub
End Class