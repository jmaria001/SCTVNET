Option Strict Off
Option Explicit On
Friend Class frmBreaksDesconsiderados
	Inherits System.Windows.Forms.Form
	Dim MouseX As Short
	Dim MouseY As Short
	Dim aVeiculos() As String
    Dim bMaisVeiculo As Boolean
    Dim asmxBreak As MSAClass.AsmxBreak.asmxBreak = NewBreak()
    Dim dtsBreak As New MSAClass.AsmxBreak.dtsBreak
	
	
	
    Private Sub ConfiguraGridBreak()
        On Error GoTo Erro


        With flxBreak
            .Visible = False
            .Clear()
            .FixedCols = 0
            .Rows = 15
            '.FormatString = "|Programa|Titulo|Break|Duração"
            .FormatString = "|^Break|Titulo|^Duração"
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollTrack = True
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .AllowBigSelection = False
            .FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusNone
            .HighLight = MSFlexGridLib.HighLightSettings.flexHighlightNever
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree

            .set_ColWidth(0, 345)
            .set_ColWidth(1, 705)
            .set_ColWidth(2, 5535)
            .set_ColWidth(3, 915)

        End With

Saida:
        flxBreak.Visible = True
        ' CloseRs(adors)
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub LimpaTela()
		
		For nCont = 1 To chkDiaSemana.Count - 1
			chkDiaSemana(nCont).CheckState = System.Windows.Forms.CheckState.Unchecked
		Next nCont
		

        ucPrograma1.text = ""
        UcPrograma1.Focus()

        lstVeiculo.Items.Clear()
        Dim aVeiculo(0) As Object
        cmdOk.Enabled = False
        cmdReplicar.Visible = False
        Call ConfiguraGridBreak()

    End Sub

    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Me.Dispose()
    End Sub

    Private Sub cmdCriticaFechar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCriticaFechar.Click
        Dim Index As Short = cmdCriticaFechar.GetIndex(eventSender)
        picCritica.Visible = False
    End Sub


    Private Sub cmdExecutarFiltro_Click()

    End Sub

    Private Sub cmdExibir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExibir.Click

        On Error GoTo Erro
        ' Dim aParam(2) As Object
        'Dim atipos(2) As Object

        If ucVeiculo.text.ToString = "" Or UcData.Text = "" Or ucPrograma1.text.ToString = "" Then
            MsgBox("Veículo/Data/Programa devem ser Preenchidos", MsgBoxStyle.OkOnly)
            GoTo Saida
        End If

        Me.Cursor = Cursors.WaitCursor
        DtsBreak = AsmxBreak.spuCarregar_BreakDesconsiderado(ucVeiculo.text, UcData.Text, ucPrograma1.text)

        nLin = 0
        With flxBreak

            For Each drw As MSAClass.AsmxBreak.dtsBreak.dtbBreak_DesconsideradoRow In dtsBreak.dtbBreak_Desconsiderado.Rows

                nLin = nLin + 1
                If nLin >= .Rows - 1 Then
                    .Rows = .Rows + 1
                End If

                .set_TextMatrix(nLin, 2, drw.Titulo_Break)
                .set_TextMatrix(nLin, 1, drw.Breaks)
                .set_TextMatrix(nLin, 3, drw.Duracao)

                .Row = nLin
                .Col = 0

                If drw.IsIndica_DesconsideradoNull Then
                    .set_RowData(nLin, 0)
                    .CellPicture = picDesmarcado.Image
                Else
                    drw.Indica_Desconsiderado = 0
                    .set_RowData(nLin, 1)
                    .CellPicture = picMarcado.Image
                End If
                .CellPictureAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter

            Next

        End With

        If nLin = 0 Then

            Me.Cursor = Cursors.Default
            Aviso("Não existe Composição de Breaks para o Veículo/Data/Programa solicitado")
            UcPrograma1.Focus()
            GoTo Saida
        End If

        cmdOk.Enabled = True


Saida:
        flxBreak.Visible = True

        Me.Cursor = Cursors.Default


        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        On Error GoTo Erro
        Dim aParam(6) As Object
        Dim atipos(6) As Object

        If Trim(ucVeiculo.Text.ToString) = "" Then
            MsgBox("Veículo não foi Informado", MsgBoxStyle.OkOnly)
            GoTo Saida
        End If

        If Trim(dtpInicio.Text) = "" Or Trim(dtpFim.Text) = "" Then
            Aviso("Periodo não foi Informado")
            GoTo Saida
        End If

        Me.Cursor = Cursors.WaitCursor


        Dim sBreak As String = ""
        Dim sDiaSemana As String
        Dim sTipo_Break As String
        Dim sVeiculo As String
        sDiaSemana = ""

        '----------------------------------> Dias da Semana
        For nCont = 1 To 7
            sDiaSemana = sDiaSemana & IIf(chkDiaSemana(nCont).CheckState = 1, "S", "N")
        Next nCont
        If sDiaSemana = "NNNNNNN" Then
            MsgBox("Dia da Semana não foi Informado", MsgBoxStyle.OkOnly)
            GoTo Saida
        End If

        '----------------------------------> Veiculos
        sVeiculo = ucVeiculo.Text & "^"

        For nCont = 0 To lstVeiculo.Items.Count - 1
            If lstVeiculo.GetItemChecked(nCont) Then
                sVeiculo = sVeiculo & aVeiculos(nCont)
            End If
        Next
        With flxBreak
            For nLin = 1 To .Rows - 1
                If .get_RowData(nLin) = 1 And .get_TextMatrix(nLin, 1) <> "" Then
                    sBreak = sBreak & Trim(.get_TextMatrix(nLin, 1)) & "^"
                End If
            Next nLin
        End With

        DtsBreak = AsmxBreak.spuGravar_BreakDesconsiderado(sVeiculo, _
                                                    UcData.Text, _
                                                    ucPrograma1.text, _
                                                    sDiaSemana, _
                                                    sBreak, _
                                                    dtpInicio.Text, _
                                                    dtpFim.Text)






        '----------------------Carrega o Grid de Critica
        Call ConfiguraGridCritica()
        nLin = 0
        With flxCritica
            For Each drw As MSAClass.AsmxBreak.dtsBreak.dtbCritica_BreakDesconsideradoRow In dtsBreak.dtbCritica_BreakDesconsiderado.Rows
                If drw.Indica_Critica = 1 Then
                    nLin = nLin + 1
                    If nLin >= .Rows Then
                        .Rows = .Rows + 1
                    End If
                    If Not drw.IsData_ExibicaoNull Then

                        .set_TextMatrix(nLin, 0, drw.Data_Exibicao)
                    End If
                    .set_TextMatrix(nLin, 1, drw.Critica)
                End If
            Next
        End With

        Mensagem("")


        Me.Cursor = Cursors.Default



        If nLin > 0 Then
            Aviso("Houve critica na Desconsideração de Break")
            picCritica.Visible = True
        Else
            Aviso("Dados Atualizados com Sucesso")
            Call LimpaTela()
            ucPrograma1.Text = ""


            ' Call FDeletaPorta(
        End If

Saida:
        Mensagem("")
        Me.Cursor = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGridCritica()
        On Error GoTo Erro

        With flxCritica
            .Clear()
            .Rows = 13
            .FormatString = "Data|Critica"
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .FixedCols = 0
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .set_ColWidth(0, 1155)
            .set_ColWidth(1, 5310)
            .TopRow = 1
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub




    Private Sub cmdReplicar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReplicar.Click
        Call CarregaVeiculosDoUsuario()
        picVeiculo.Visible = True
        picVeiculo.BringToFront()
    End Sub

    Private Sub cmdSelecaoVeiculo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelecaoVeiculo.Click
        Dim Index As Short = cmdSelecaoVeiculo.GetIndex(eventSender)
        picVeiculo.Visible = False
    End Sub

    Private Sub flxBreak_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxBreak.ClickEvent
        On Error GoTo Erro
        Dim nCol As Short
        With flxBreak
            nCol = .MouseCol
            If .Col = 0 Then
                If .get_TextMatrix(.Row, 2) = "" Then
                    GoTo Saida
                End If

                If .get_RowData(.Row) = 1 Then
                    .set_RowData(.Row, 0)
                    .CellPicture = picDesmarcado.Image
                Else
                    .set_RowData(.Row, 1)
                    .CellPicture = picMarcado.Image
                End If
            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmBreaksDesconsiderados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub frmBreaksDesconsiderados_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    End Sub

    Private Sub frmBreaksDesconsiderados_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{TAB}")
        Else
            KeyAscii = Asc(UCase(Chr(KeyAscii)))
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub frmBreaksDesconsiderados_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        ucVeiculo.Usuario = gsUsuario
        asmxBreak = NewBreak()
        Me.Top = 0
        Me.Left = 0

        ReDim aVeiculos(0)
        With picVeiculo
            .Top = VB6.TwipsToPixelsY(1020)
            .Left = VB6.TwipsToPixelsX(675)
            .Width = VB6.TwipsToPixelsX(6990)
            .Height = VB6.TwipsToPixelsY(3060)
            .Visible = False
        End With


        With picCritica
            .Top = VB6.TwipsToPixelsY(1545)
            .Left = VB6.TwipsToPixelsX(405)
            .Width = VB6.TwipsToPixelsX(6900)
            .Height = VB6.TwipsToPixelsY(3885)
        End With



        Call ConfiguraGridBreak()


    End Sub


    Private Sub CarregaVeiculosDoUsuario()

        On Error GoTo Erro
     
        Me.Cursor = Cursors.WaitCursor

        lstVeiculo.Items.Clear()

        For Each drw As MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow In mdiPrincipal.dtsUsuario.dtbUsuario_Veiculo.Rows
            lstVeiculo.Items.Add(drw.Cod_Veiculo & "-" & drw.Nome_Veiculo)
            ReDim Preserve aVeiculos(lstVeiculo.Items.Count - 1)
            aVeiculos(lstVeiculo.Items.Count - 1) = drw.Cod_Veiculo
        Next


Saida:
        Me.Cursor = Cursors.Default

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida


    End Sub


    Private Sub lblCritica_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblCritica.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = X
        MouseY = Y
    End Sub


    Private Sub lblCritica_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblCritica.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        On Error GoTo Erro
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        Dim MaxTop As Short
        Dim MaxLeft As Short

        With picCritica
            If Button = 1 Then
                MaxTop = VB6.PixelsToTwipsY(Me.Height) - 700
                MaxLeft = (VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width)) - VB6.PixelsToTwipsX(.Width)
                VariacaoY = Y - MouseY
                VariacaoX = X - MouseX
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


    Private Sub lblSelecaoVeiculo_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblSelecaoVeiculo.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = X
        MouseY = Y

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
                VariacaoY = Y - MouseY
                VariacaoX = X - MouseX
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




    Private Sub _lblCampos_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub _Frame2_0_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Frame2_0.Enter

    End Sub

    Private Sub Frame1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Frame1.Enter

    End Sub


    Private Sub UcData_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcData.Validated
        On Error GoTo erro
        Dim intDiaSemana As Integer
        dtpFim.Text = UcData.Text
        dtpFim.DateTime = UcData.DateTime
        ucPrograma1.DataInicio = UcData.DateTime
        ucPrograma1.DataFim = UcData.DateTime


        dtpInicio.Text = UcData.Text
        dtpInicio.DateTime = UcData.DateTime

        intDiaSemana = UcData.DateTime.DayOfWeek
        For i As Integer = 1 To chkDiaSemana.Count
            chkDiaSemana(i).Checked = False
        Next
        chkDiaSemana(intDiaSemana + 1).Checked = True


Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume saida
        Resume
    End Sub

    Private Sub ucVeiculo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucVeiculo.Validated
        ucPrograma1.Veiculo = ucVeiculo.Text
    End Sub
End Class