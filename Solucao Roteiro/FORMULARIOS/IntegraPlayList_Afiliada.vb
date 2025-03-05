Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmIntegraPlayList_Afiliada
	Inherits System.Windows.Forms.Form
	Dim bErroProcessamento As Boolean
	Dim MouseX As Short
    Dim MouseY As Short
    Dim asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro
    Dim dtsRoteiro As New MSAClass.AsmxRoteiro.dtsRoteiro
    Dim clsParametro As MSAClass.AsmxParametro.asmxParametro = NewParametro()

    Private Sub CarregaGridVeiculo()

        On Error GoTo Erro
        Dim stable As String
        Dim sFields As String
        Dim sSiglaVeiculo As String = ""
        Dim sPathTxt As String
        Dim sNomeArquivo As String

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Call ConfiguraGridVeiculo()
        nLin = 0
        With flxVeiculo
            .Visible = False

            For Each drw As MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow In mdiPrincipal.dtsUsuario.dtbUsuario_Veiculo.Rows

                nLin = nLin + 1
                If nLin >= .Rows Then
                    .Rows = .Rows + 1
                End If

                sSiglaVeiculo = ""

                If Not drw.IsSigla_RoteiroNull Then sSiglaVeiculo = drw.Sigla_Roteiro.Trim


                If sSiglaVeiculo = "" Then
                    If Not drw.IsSigla_VeiculoNull Then
                        sSiglaVeiculo = drw.Sigla_Veiculo.Trim
                    End If
                End If
                If sSiglaVeiculo = "" Then
                    sSiglaVeiculo = drw.Cod_Veiculo.Trim
                End If

                sPathTxt = fParametro(46, , , drw.Cod_Veiculo)

                sNomeArquivo = fParametro(67, , , drw.Cod_Veiculo).Trim
                If sNomeArquivo = "" Then
                    .set_TextMatrix(nLin, 7, 0)
                    sNomeArquivo = sPathTxt & sSiglaVeiculo & "ddmmyy.txt"
                Else
                    .set_TextMatrix(nLin, 7, 1)
                    sNomeArquivo = sPathTxt & sNomeArquivo
                End If


                .set_TextMatrix(nLin, 2, drw.Cod_Veiculo)
                .set_TextMatrix(nLin, 3, drw.Nome_Veiculo)
                .set_TextMatrix(nLin, 4, fParametro(68, , , drw.Cod_Veiculo))
                .set_TextMatrix(nLin, 5, sNomeArquivo)
                .set_TextMatrix(nLin, 8, sNomeArquivo)
                .set_TextMatrix(nLin, 9, sSiglaVeiculo)


                .Row = nLin
                .Col = 1
                .set_RowData(.Row, 0)
                .CellPicture = picDesmarcado.Image
                .CellPictureAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter


            Next

            For nCont = 1 To .Rows - 1
                .Row = nCont
                .Col = 0
                .CellFontName = "WingDings"
                .CellForeColor = System.Drawing.Color.Blue
                .CellFontSize = 14

                .Col = 6
                .CellFontName = "WingDings"
                .CellForeColor = System.Drawing.Color.Blue
                .CellFontSize = 14
            Next nCont

            If .Rows <= 20 Then
                .set_ColWidth(5, .get_ColWidth(5) + 260)
            End If

            .Row = 1
            flxVeiculo_RowColChange(flxVeiculo, New System.EventArgs())

            .Visible = True

        End With


Saida:
        flxVeiculo.Visible = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Function cHoracma(ByRef nNumber As Integer) As String

        Dim nMinuto, nHora, nSegundo As Short
        Dim sAux As String
        Dim nLoop As Short
        nHora = Int(nNumber / 3600)
        nMinuto = Int((nNumber Mod 3600) / 60)
        nSegundo = (nNumber Mod 3600) Mod 60
        sAux = Trim(StrZero(nHora, 2)) & ":" & StrZero(nMinuto, 2) & ":" & StrZero(nSegundo, 2)
        For nLoop = 1 To Len(sAux)
            If Mid(sAux, nLoop, 1) <> "0" And Mid(sAux, nLoop, 1) <> ":" Then
                sAux = Mid(sAux, nLoop)
                Exit For
            End If
        Next nLoop
        cHoracma = sAux

    End Function

    Private Function cHora(ByRef nNumber As Integer) As String
        Dim nMinuto, nHora, nSegundo As Short

        nHora = Int(nNumber / 3600)
        nMinuto = Int((nNumber Mod 3600) / 60)
        nSegundo = (nNumber Mod 3600) Mod 60
        cHora = Trim(StrZero(nHora, 2)) & ":" & StrZero(nMinuto, 2) & ":" & StrZero(nSegundo, 2)
    End Function


    Private Sub ConfiguraGridVeiculo()
        On Error GoTo Erro
        With flxVeiculo
            .Clear()
            .Rows = 20
            .FormatString = "||^Veículo|<Nome|<Sistema de Exibicao Digital|<Nome do Arquivo||Indica_Nome Arquivo|Nome do Arquivo Original|Sigla Veiculo"
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .FixedCols = 1
            .ScrollTrack = True
            .set_ColWidth(0, 330)
            .set_ColWidth(1, 270)
            .set_ColWidth(2, 645)
            .set_ColWidth(3, 0)
            .set_ColWidth(4, 3160)
            .set_ColWidth(5, 3345)
            .set_ColWidth(6, 420)
        End With
Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Function FormataDuracaoLouth(ByRef shhMmSs As String, ByRef sTipo As String) As Object
		
		On Error GoTo Trata_Erro
		
		Dim nSegundo, nHora, nMinuto, nNumeroFrame As Integer
		Dim sTemp As String
		
		sTemp = shhMmSs
		
		nHora = 0
		nMinuto = 0
		nSegundo = 0
		nNumeroFrame = 0
		
		If InStr(sTemp, ":") <> 0 Then
			nHora = Val(VB.Left(sTemp, InStr(sTemp, ":") + 1))
			sTemp = Mid(sTemp, InStr(sTemp, ":") + 1)
		End If
		
		If InStr(sTemp, ":") <> 0 Then
			nMinuto = Val(VB.Left(sTemp, InStr(sTemp, ":") + 1))
			sTemp = Mid(sTemp, InStr(sTemp, ":") + 1)
		End If
		
		If InStr(sTemp, ":") <> 0 Then
			nSegundo = Val(VB.Left(sTemp, InStr(sTemp, ":") + 1))
			nNumeroFrame = CInt(Mid(sTemp, InStr(sTemp, ":") + 1))
		Else
			nSegundo = Val(sTemp)
			nNumeroFrame = 0
		End If
		
		If sTipo = "H" Then
            FormataDuracaoLouth = (nHora * 3600) + (nMinuto * 60) + nSegundo
		Else
            FormataDuracaoLouth = nNumeroFrame
		End If
		
Saida: 
		Exit Function
		
Trata_Erro: 
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		Erro(Err.Number)
		Resume Saida
		Resume 
		
	End Function
	
	
	Private Sub FormataNomeArquivo()
		On Error GoTo Erro
		Dim sArquivo As String
		With flxVeiculo
			For nCont = 1 To .Rows - 1
				sArquivo = .get_TextMatrix(nCont, 8)
                If Trim(UcData.Text) <> "" Then
                    sArquivo = Replace(UCase(sArquivo), "#DD#", VB6.Format(UcData.DateTime, "dd"))
                    sArquivo = Replace(UCase(sArquivo), "#MM#", VB6.Format(UcData.DateTime, "MM"))
                    sArquivo = Replace(UCase(sArquivo), "#YYYY#", VB6.Format(UcData.DateTime, "YYYY"))
                    sArquivo = Replace(UCase(sArquivo), "#YY#", VB6.Format(UcData.DateTime, "YY"))

                    sArquivo = Replace(UCase(sArquivo), "DDMMYY", VB6.Format(UcData.DateTime, "ddmmyy"))
                    sArquivo = Replace(UCase(sArquivo), "DDMMYYYY", VB6.Format(UcData.DateTime, "ddmmyyyy"))

                Else
                    sArquivo = Replace(UCase(sArquivo), "#DD#", "")
                    sArquivo = Replace(UCase(sArquivo), "#MM#", "")
                    sArquivo = Replace(UCase(sArquivo), "#YYYY#", "")
                    sArquivo = Replace(UCase(sArquivo), "#YY#", "")

                End If
                If cboPeriodo.SelectedIndex > 0 Then
                    sArquivo = Replace(UCase(sArquivo), "#PERIODO#", cboPeriodo.Text)
                Else
                    sArquivo = Replace(UCase(sArquivo), "#PERIODO#", "")
                End If

                .set_TextMatrix(nCont, 5, UCase(sArquivo))
            Next nCont

        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
        Call FormataNomeArquivo()
    End Sub
	
	Private Sub cmdAlterarParametro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAlterarParametro.Click
		
		flxVeiculo.Enabled = False
		cmdGerarArquivo.Enabled = False
		cmdSair.Enabled = False
		flxVeiculo.Enabled = False
		
		With cboSistemaExibicao
			For nCont = 0 To .Items.Count - 1
				If UCase(VB6.GetItemString(cboSistemaExibicao, nCont)) = UCase(flxVeiculo.get_TextMatrix(flxVeiculo.Row, 4)) Then
					.SelectedIndex = nCont
					Exit For
                End If
			Next nCont
		End With
		
		
		txtDiretorio.Text = fParametro(46,  ,  , flxVeiculo.get_TextMatrix(flxVeiculo.Row, 2))
        txtFitaPosicao.Text = VB.Left(fParametro(76, , , flxVeiculo.get_TextMatrix(flxVeiculo.Row, 2)), 2)
		txtFitaTamanho.Text = VB.Right(fParametro(76,  ,  , flxVeiculo.get_TextMatrix(flxVeiculo.Row, 2)), 2)
        txtArquivo.Text = flxVeiculo.get_TextMatrix(flxVeiculo.Row, 9) & VB6.Format(UcData.DateTime, "ddmmyy") & ".TXT"


        picParametro.Visible = True
        lblExemplo.Text = "Ex:  " & flxVeiculo.get_TextMatrix(flxVeiculo.Row, 9) & VB6.Format(Today, "ddmmyy") & ".TXT"
        picParametro.BringToFront()
        cboSistemaExibicao.Focus()
		
		
	End Sub
	
	Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
		Dim Index As Short = cmdCancela.GetIndex(eventSender)
		flxVeiculo.Enabled = True
		cmdGerarArquivo.Enabled = True
		cmdSair.Enabled = True
		flxVeiculo.Enabled = True
		picParametro.Visible = False
        UCDATA.Focus()
    End Sub

    Private Sub cmdDiretorio_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDiretorio.Click


        frmDiretorio.ShowDialog()
        If frmDiretorio.txtDiretorio.Text <> "" Then
            txtDiretorio.Text = frmDiretorio.txtDiretorio.Text & "\"
        End If
        frmDiretorio.Dispose()

    End Sub


    Private Sub cmdGerarArquivo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGerarArquivo.Click

        On Error GoTo Erro
        Dim nVei As Short
        Dim sVeiculo As String
        Dim sSistemaExibicao As String
        Dim sNomeArquivo As String
        Dim sMsg As String
        Dim bSelecaoVeiculo As Boolean

        Dim sDiretorioAnterior As String
        Call FormataNomeArquivo()
        '---------------------Consistencias
        If Trim(UcData.Text) = "" Or UcData.DateTime = Date.MinValue Then
            Aviso("Data da Programação deve ser Preenchido")
            Exit Sub
        End If

        bSelecaoVeiculo = False
        With flxVeiculo
            For nCont = 1 To .Rows - 1
                sVeiculo = .get_TextMatrix(nCont, 2)
                If .get_RowData(nCont) = 1 And sVeiculo <> "" Then
                    bSelecaoVeiculo = True


                    If Not ExisteRoteiro(sVeiculo, UcData.DateTime) Then
                        sMsg = "Não existe roteiro para o veiculo Veiculo " & sVeiculo & " (" & UcData.Text & ") "
                        Aviso(sMsg)
                        GoTo Saida
                    End If
                    If UCase(fParametro(119, , , sVeiculo)) <> "SIM" Then
                        If Not ExisteRoteiroEncerrado(sVeiculo, UcData.DateTime) Then
                            sMsg = "O roteiro para o Veiculo " & sVeiculo & " (" & UcData.Text & ") não está encerrado." & vbCrLf
                            sMsg = sMsg & "Favor Encerrar o Roteiro antes de processar a integração"
                            Aviso(sMsg)
                            GoTo Saida
                        End If

                    End If
                End If
            Next nCont
        End With
        If Not bSelecaoVeiculo Then
            Aviso("Nenhum Veiculo foi Selecionado")
            GoTo Saida
        End If


        '-----------------------Processa para Cada Veiculo
        With flxVeiculo
            For nVei = 0 To .Rows - 1

                sVeiculo = .get_TextMatrix(nVei, 2)

                If sVeiculo = "" Then
                    Exit For
                End If

                If .get_RowData(nVei) = 1 Then

                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                    DtsRoteiro = AsmxRoteiro.spuCarregar_Roteiro(sVeiculo, UcData.DateTime, "", 0, 0)
                    DtsRoteiro.Clear()
                    DtsRoteiro = AsmxRoteiro.spuCarregar_Roteiro(sVeiculo, UcData.DateTime, "", 0, 0)
                    If Not DtsRoteiro.dtbRoteiro_Ordenado.Select().Length > 0 Then
                        GoTo saida
                    End If

                    bErroProcessamento = False
                    sSistemaExibicao = .get_TextMatrix(nVei, 4)
                    sNomeArquivo = .get_TextMatrix(nVei, 5)

                    '---------------------Gera o Arquivo de Integracao
                    Select Case UCase(sSistemaExibicao)
                        Case "4SCV"
                            Call Gerar4sCV(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "4SIT"
                            Call Gerar4sIT(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "4SCAMP"
                            Call Gerar4sCamp(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "4S"
                            Call Gerar4s(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "VR"
                            'Call GerarVr(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "FLORIPA", "FLORIPAV2"
                            Call GerarFloripa(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "LOUTH"
                            Call GeraLouth(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "LEITCH"
                            sNomeArquivo = Replace(sNomeArquivo, ".MDB", ".mdb")
                            'Call GerarLeitch(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "4SVARG"
                            Call Gerar4SVARG(sVeiculo, UcData.Text, sNomeArquivo)
                        Case "4SARATU"
                            Call Gerar4SARATU(sVeiculo, UcData.Text, sNomeArquivo)


                    End Select

                    .Col = 6
                    .Row = nVei

                    If Not bErroProcessamento Then
                        .CellForeColor = System.Drawing.Color.Blue
                        .set_TextMatrix(nVei, 6, Chr(252))
                        ' Call GeraArquivoDiferenças
                    Else
                        .CellForeColor = System.Drawing.Color.Red
                        .set_TextMatrix(nVei, 6, Chr(251))
                    End If
                End If
Proximo:
            Next nVei

            sMsg = ""
            For nVei = 1 To .Rows - 1
                If .get_TextMatrix(nVei, 6) = Chr(251) Then
                    sMsg = sMsg & .get_TextMatrix(nVei, 2) & ","
                End If
            Next nVei
            If sMsg <> "" Then
                sMsg = "[" & VB.Left(sMsg, Len(sMsg) - 1) & "]"
                sMsg = "Fim do Processamento" & vbCrLf & "Houve erro no(s) veiculo(s) " & sMsg
            Else
                sMsg = "Integração concluida com Sucesso"
            End If
            Aviso(sMsg)

        End With

Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub GeraLouth(ByVal sVeiculo As String, ByVal sDiaProg As Date, ByVal sArquivo As String)

        On Error GoTo Trata_Erro

        Dim sFields As String = ""
        Dim nBuf As Short
        Dim sProgramaAnterior As String = ""
        Dim sTituloAnterior As String = ""
        Dim sCodProgramaAnterior As String = ""
        Dim sBreakAnterior As String = ""
        Dim bPrimeiro As Boolean
        Dim sLinha As String = ""
        Dim sTituloAtual As String = ""


        '---------------------------Executa Consulta do Roteiro
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        nBuf = FreeFile()
        Mensagem("Gravando Gerando Arquivo: " & sArquivo)

        FileOpen(nBuf, sArquivo, OpenMode.Output)

        '-----------------------------------------------------------Leitura na View
        sProgramaAnterior = ""
        sBreakAnterior = ""
        sTituloAnterior = ""
        sCodProgramaAnterior = ""
        bPrimeiro = True

        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Select()

            If drw.Indica_Titulo_Intervalo = 1 Then
                GoTo Proximo
            End If

            '-----------------------------------------------------Mudanca de Programa/Break
            If drw.Indica_Titulo_Break = 1 Then
                If sBreakAnterior <> "" Then
                    If Val(sBreakAnterior) > -1 Then
                        sLinha = Space(71)
                        Mid(sLinha, 1, 8) = "SWT     "
                        Mid(sLinha, 9, 8) = "BLACK-5"
                        Mid(sLinha, 19, 16) = "BLACK 5 SEGUNDOS"
                        Mid(sLinha, 40, 11) = "00:00:05.00"
                        Mid(sLinha, 51, 11) = "00:00:00.00"
                        Mid(sLinha, 62, 10) = VB6.Format(sDiaProg, "DD/MM/YYYY")
                        PrintLine(nBuf, sLinha)

                        sLinha = Space(71)
                        Mid(sLinha, 1, 8) = "PAUSA   "
                        'UPGRADE_WARNING: Couldn't resolve default property of object StrZero(sBreakAnterior, 2). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Mid(sLinha, 19, 16) = "FINAL " & sCodProgramaAnterior & " " & StrZero(sBreakAnterior, 2)
                        PrintLine(nBuf, sLinha)
                    End If
                End If

                If sProgramaAnterior <> drw.Cod_Programa & drw.Titulo_Break Then
                    sLinha = Space(71)
                    Mid(sLinha, 1, 8) = "REM     "
                    Mid(sLinha, 19, 16) = VB.Left(drw.Titulo_Comercial, 16)
                    PrintLine(nBuf, sLinha)
                    sLinha = Space(71)
                    Mid(sLinha, 1, 8) = "REM     "
                    Mid(sLinha, 19, 16) = "Horario : " & drw.Cod_Faixa
                    PrintLine(nBuf, sLinha)
                End If

                If drw.Breaks > -1 Then '    Programas que tem Composicao de Break
                    sLinha = Space(71)
                    Mid(sLinha, 1, 8) = "REM     "
                    'UPGRADE_WARNING: Couldn't resolve default property of object StrZero(ADORs!Breaks, 2). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Mid(sLinha, 19, 16) = "INICIO  " & drw.Cod_Programa & " " & StrZero(drw.Breaks, 2)
                    PrintLine(nBuf, sLinha)
                End If

                sTituloAtual = drw.Titulo_Break
                sProgramaAnterior = drw.Cod_Programa & drw.Titulo_Break
                sTituloAnterior = drw.Titulo_Break
                sCodProgramaAnterior = drw.Cod_Programa
                sBreakAnterior = drw.Breaks
            End If

            If drw.Breaks > -1 Then
                sLinha = Space(71)
                Mid(sLinha, 1, 8) = "INT     "
                Mid(sLinha, 9, 8) = drw.Numero_Fita
                Mid(sLinha, 19, 16) = drw.Titulo_Comercial
                Mid(sLinha, 40, 11) = cHora(drw.Duracao) & ".00"
                Mid(sLinha, 51, 11) = "00:00:00.00"
                Mid(sLinha, 62, 10) = VB6.Format(sDiaProg, "DD/MM/YYYY")
                PrintLine(nBuf, sLinha)
            End If

Proximo:

        Next

        If sBreakAnterior <> "" Then
            sLinha = Space(71)
            Mid(sLinha, 1, 8) = "SWT     "
            Mid(sLinha, 9, 8) = "BLACK-5"
            Mid(sLinha, 19, 16) = "BLACK 5 SEGUNDOS"
            Mid(sLinha, 40, 11) = "00:00:00.00"
            Mid(sLinha, 51, 11) = "00:00:00.00"
            Mid(sLinha, 62, 10) = VB6.Format(sDiaProg, "DD/MM/YYYY")
            PrintLine(nBuf, sLinha)

            sLinha = Space(71)
            Mid(sLinha, 1, 8) = "PAUSA   "
            Mid(sLinha, 19, 16) = "FINAL " & sCodProgramaAnterior & " " & StrZero(sBreakAnterior, 2)
            PrintLine(nBuf, sLinha)
        End If
Saida:

        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        FileClose(nBuf)
        Exit Sub

Trata_Erro:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Erro(Err.Number)
        bErroProcessamento = True
        Resume Saida
        Resume
    End Sub

    Private Sub cmdOkParametro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOkParametro.Click
        On Error GoTo Erro
        Dim sVeiculo As String = ""
        Dim sChave As String = ""
        Dim sSql As String = ""
        Dim sValor As String = ""

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        sVeiculo = flxVeiculo.get_TextMatrix(flxVeiculo.Row, 2)
        '==============================================================Grava o Nome do Sistema de Exibicao
        mdiPrincipal.DtsParametro.Clear()
        mdiPrincipal.dtsParametro = clsParametro.spuCarregar()

        If cboSistemaExibicao.SelectedIndex > -1 Then
            sChave = fParametro(68, , , sVeiculo)
            sSql = "Cod_Parametro = 68 and Cod_Veiculo = '" & sVeiculo & "'"
            If sChave.Trim.ToUpper <> cboSistemaExibicao.Text.Trim.ToUpper Then
                Dim drw As MSAClass.AsmxParametro.dtsParametro.dtbParametro_ValorRow()

                drw = mdiPrincipal.dtsParametro.dtbParametro_Valor.Select(sSql)
                If drw.Length = 0 Then
                    mdiPrincipal.DtsParametro.dtbParametro_Valor.AdddtbParametro_ValorRow(68, "", "", sVeiculo, cboSistemaExibicao.Text.Trim)
                Else
                    drw(0).Cod_Chave = cboSistemaExibicao.Text.Trim
                End If
                clsParametro.spuAtualizar(mdiPrincipal.dtsParametro)
            End If
        End If

        '==============================================================Grava o Diretorio
        If txtDiretorio.Text.Trim <> "" Then
            sChave = fParametro(46, , , sVeiculo)
            If txtDiretorio.Text.Trim.ToUpper <> sChave.Trim.ToUpper Then
                sSql = "Cod_Parametro = 46 and Cod_Veiculo = '" & sVeiculo & "'"
                Dim drw As MSAClass.AsmxParametro.dtsParametro.dtbParametro_ValorRow()
                drw = mdiPrincipal.DtsParametro.dtbParametro_Valor.Select(sSql)
                If drw.Length = 0 Then
                    mdiPrincipal.DtsParametro.dtbParametro_Valor.AdddtbParametro_ValorRow(46, "", "", sVeiculo, txtDiretorio.Text.Trim)
                Else
                    drw(0).Cod_Chave = txtDiretorio.Text.Trim
                End If
                clsParametro.spuAtualizar(mdiPrincipal.dtsParametro)
            End If
        End If

        '==============================================================Grava o Nome do Arquivo 
        If txtarquivo.Text.Trim <> "" Then
            sChave = fParametro(67, , sVeiculo)
            If txtarquivo.Text.Trim.ToUpper <> sChave.Trim.ToUpper Then
                sSql = "Cod_Parametro = 67 and Cod_Veiculo = '" & sVeiculo & "'"
                Dim drw As MSAClass.AsmxParametro.dtsParametro.dtbParametro_ValorRow()
                drw = mdiPrincipal.DtsParametro.dtbParametro_Valor.Select(sSql)
                If drw.Length = 0 Then
                    mdiPrincipal.DtsParametro.dtbParametro_Valor.AdddtbParametro_ValorRow(67, "", "", sVeiculo, txtArquivo.Text.Trim)
                Else
                    drw(0).Cod_Chave = txtArquivo.Text.Trim
                End If
                clsParametro.spuAtualizar(mdiPrincipal.dtsParametro)
            End If
        End If


        '==============================================================Grava o Parametro da Fita
        If txtArquivo.Text.Trim <> "" Then
            sChave = fParametro(76, , sVeiculo)
            If Val(txtFitaPosicao.Text) = 0 Then txtFitaPosicao.Text = "01"
            sValor = StrZero(Val(txtFitaPosicao.Text), 2) + "-" & StrZero(Val(txtFitaTamanho.Text), 2)

            If sValor.Trim.ToUpper <> sChave.Trim.ToUpper Then
                sSql = "Cod_Parametro = 76 and Cod_Veiculo = '" & sVeiculo & "'"
                Dim drw As MSAClass.AsmxParametro.dtsParametro.dtbParametro_ValorRow()
                drw = mdiPrincipal.DtsParametro.dtbParametro_Valor.Select(sSql)
                If drw.Length = 0 Then
                    mdiPrincipal.DtsParametro.dtbParametro_Valor.AdddtbParametro_ValorRow(76, "", "", sVeiculo, sValor)
                Else
                    drw(0).Cod_Chave = sValor
                End If
                clsParametro.spuAtualizar(mdiPrincipal.dtsParametro)
            End If
        End If

        Call CarregaGridVeiculo()
        cmdCancela_Click(cmdCancela.Item(0), New System.EventArgs())

Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Dispose()
    End Sub

    Private Sub flxVeiculo_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxVeiculo.ClickEvent
        On Error GoTo Erro
        Dim nCol As Short
        With flxVeiculo
            nCol = .MouseCol
            If .Col = 1 And .MouseCol = 1 Then
                If .get_TextMatrix(.Row, 2) = "" Then
                    GoTo Saida
                End If

                If .get_RowData(.Row) = 1 Then
                    .set_RowData(.Row, 0)
                    .CellPicture = picDesmarcado.Image
                    ucPrograma1.Enabled = False
                    ucPrograma2.Enabled = ucPrograma1.Enabled
                Else
                    .set_RowData(.Row, 1)
                    .CellPicture = picMarcado.Image
                    ucPrograma1.Enabled = Trim(UcData.Text) <> ""
                    ucPrograma2.Enabled = ucPrograma1.Enabled
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

    Private Sub flxVeiculo_EnterCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxVeiculo.EnterCell
        With flxVeiculo
            If .Row > 0 Then
                .set_TextMatrix(.Row, 0, Chr(240))
            End If

        End With
    End Sub

    Private Sub flxVeiculo_LeaveCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxVeiculo.LeaveCell
        With flxVeiculo
            .set_TextMatrix(.Row, 0, "")
        End With
    End Sub

    Private Sub flxVeiculo_MouseMoveEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseMoveEvent) Handles flxVeiculo.MouseMoveEvent

        With flxVeiculo
            ToolTip1.SetToolTip(flxVeiculo, "")
            If .MouseCol = 2 Then
                ToolTip1.SetToolTip(flxVeiculo, Trim(.get_TextMatrix(.MouseRow, 3)))
            End If
        End With


    End Sub

    Private Sub flxVeiculo_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxVeiculo.RowColChange
        With flxVeiculo
            cmdAlterarParametro.Enabled = .get_TextMatrix(.Row, 2) <> ""
        End With
    End Sub

    Private Sub frmIntegraPlayList_Afiliada_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{tab}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub




    Private Sub frmIntegraPlayList_Afiliada_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        ucPrograma1.DataInicio = Nothing
        ucPrograma2.DataInicio = Nothing
        ucPrograma1.DataInicio = Nothing
        ucPrograma2.DataFim = Nothing

        On Error GoTo Trata_Erro
        asmxRoteiro = NewRoteiro()
        Me.Size = New System.Drawing.Size(596, 425)
        Me.CenterToParent()
        With picParametro
            .Size = New System.Drawing.Size(469, 287)
            .Location = New System.Drawing.Point(68, 30)
        End With

        Call CarregaGridVeiculo()
        Call FormataNomeArquivo()

        With cboSistemaExibicao
            .Items.Add("Louth")
            .Items.Add("Floripa")
            .Items.Add("FloripaV2")
            .Items.Add("VR")
            .Items.Add("VR420")
            .Items.Add("4S")
            .Items.Add("4SCV")
            .Items.Add("4SIT")
            .Items.Add("4SCAMP")
            .Items.Add("4SVARG")
            .Items.Add("4SARATU")
            .Items.Add("Leitch")
        End With


Saida:

        Exit Sub

Trata_Erro:
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub

    Private Sub lblParametro_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblParametro.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = x
        MouseY = y
    End Sub


    Private Sub lblParametro_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblParametro.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        On Error GoTo Erro
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        Dim MaxTop As Short
        Dim MaxLeft As Short

        With picParametro
            If Button = 1 Then
                MaxTop = VB6.PixelsToTwipsY(Me.Height) - 700
                MaxLeft = (VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width)) - VB6.PixelsToTwipsX(.Width)
                VariacaoY = y - MouseY
                VariacaoX = x - MouseX
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


    Private Sub Gerar4s(ByRef sVeiculoPlayList As String, ByRef sDataPlayList As String, ByRef sArquivo As String)
        On Error GoTo Erro

        Dim nBuf As Short
        Dim sLinha As String
        Dim aParam(3) As Object
        Dim aTipos(3) As Object
        Dim sTitulo As String

        Dim sTituloAnterior As String
        Dim sBreak As String
        Dim nTipoPrograma As Short ' Tipo do Programa 0=Rede 1-Local 2-Local ao Vivo
        Dim aTipoPrograma(2) As Object
        Dim nTipoAnterior As Short
        Dim bPrimeiro As Boolean
        Dim sProgramaAnterior As String
        Dim nUltimoBreak As Short
        Dim nContComercial As Short
        Dim nTipoBreak As Short


        aTipoPrograma(0) = "SAT"
        aTipoPrograma(1) = "VT1"
        aTipoPrograma(2) = "PRD"


        Dim bIniciar As Boolean
        Dim bTerminar As Boolean
        bIniciar = False
        bTerminar = False
        bPrimeiro = True


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Gerando Arquivo de Integração do Roteiro! Veículo " & sVeiculoPlayList & " Aguarde...")


        sProgramaAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Cod_Programa
        If Not DtsRoteiro.dtbRoteiro_Ordenado(0).IsTitulo_BreakNull Then
            sTituloAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Titulo_Break
        Else
            sTituloAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Cod_Programa
        End If

        nBuf = FreeFile()
        FileOpen(nBuf, sArquivo, OpenMode.Output)


        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows


            If Not bIniciar Then
                'UPGRADE_WARNING: Couldn't resolve default property of object VerNulo(ADORs!Cod_Programa, ). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If drw.Cod_Programa = ucPrograma1.Text Or ucPrograma1.Text.Trim = "" Then
                    bIniciar = True
                    sProgramaAnterior = drw.Cod_Programa
                    If Not drw.IsTitulo_BreakNull Then
                        sTituloAnterior = drw.Titulo_Break
                    Else
                        sTituloAnterior = ""
                    End If
                End If
            End If


            If drw.Cod_Programa = ucPrograma2.Text And ucPrograma2.Text.Trim = "" Then
                bTerminar = True
            End If

            If Not bIniciar Then
                GoTo Proximo
            End If

            If bTerminar And drw.Cod_Programa <> ucPrograma2.Text Then
                GoTo Saida
            End If


            '===============Se For Titulo do Break
            If drw.Indica_Titulo_Break = 1 Then
                nTipoBreak = -1
            End If
            '===============Despreza Linhas Titulos de Intervalo
            'UPGRADE_WARNING: Couldn't resolve default property of object VerNulo(ADORs!Indica_Titulo_Intervalo, 0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If drw.Indica_Titulo_Intervalo = 1 Then
                nTipoBreak = drw.Tipo_Break
                GoTo Proximo
            End If


            '===============Não envia comerciais que usuario não pode ordenar
            If drw.Indica_Ordenacao = 0 And drw.Indica_Titulo_Break = 0 Then
                GoTo Proximo
            End If



            '===============Quebra do Programa / Linha do Ultimo Bloco de Programa
            If sProgramaAnterior <> drw.Cod_Programa Then

                If Not bPrimeiro Then

                    If nTipoAnterior = 0 And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade
                        sLinha = Space(68)
                        Mid(sLinha, 1) = "F"
                        Mid(sLinha, 11) = "FADE"
                        Mid(sLinha, 46) = "00:01:00"
                        Mid(sLinha, 54) = "VDR"
                        Mid(sLinha, 68) = CStr(1)
                        PrintLine(nBuf, sLinha)
                    End If

                    If nTipoAnterior <> 1 Then
                        sLinha = Space(68)
                        Mid(sLinha, 1) = "PGM"
                        Mid(sLinha, 11) = "===   P R O G R A M   ==="
                        Mid(sLinha, 46) = "00:00:01"
                        'UPGRADE_WARNING: Couldn't resolve default property of object aTipoPrograma(nTipoPrograma). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                        Mid(sLinha, 68) = "1"
                        PrintLine(nBuf, sLinha)
                    End If


                    sLinha = Space(68)
                    If nTipoAnterior <> 1 Then
                        Mid(sLinha, 1) = "PAUSE "
                    Else
                        Mid(sLinha, 1) = "PGM"
                        Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    End If
                    Mid(sLinha, 11) = Trim(VB.Left(sTituloAnterior, 20)) & " - " & nUltimoBreak + 1 & " BL"
                    Mid(sLinha, 46) = "00:00:00"
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                    sProgramaAnterior = drw.Cod_Programa


                    If Not drw.IsTitulo_BreakNull Then
                        sTituloAnterior = drw.Titulo_Break
                    Else
                        sTituloAnterior = drw.Cod_Programa
                    End If

                    nTipoPrograma = drw.Indica_AoVivo
                End If
            End If

            '===============Linha do Inter Programa
            If drw.Indica_Titulo_Break = 1 And drw.Breaks = 0 Then
                If Not bPrimeiro Then
                    sLinha = Space(68)
                    Mid(sLinha, 1) = "INTERPGM"
                    Mid(sLinha, 11) = "INTER PROGRAMA"
                    Mid(sLinha, 46) = "00:00:00"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                End If
                nContComercial = 0
                GoTo Proximo
            End If

            '===============Linha Titulo do Programa / Break
            If drw.Indica_Titulo_Break = 1 And drw.Breaks <> 0 Then
                If nTipoAnterior = 0 And Not bPrimeiro And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade
                    sLinha = Space(68)
                    Mid(sLinha, 1) = "F"
                    Mid(sLinha, 11) = "FADE"
                    Mid(sLinha, 46) = "00:01:00"
                    Mid(sLinha, 54) = "VDR"
                    Mid(sLinha, 68) = CStr(1)
                    PrintLine(nBuf, sLinha)
                End If

                If nTipoPrograma <> 1 Then
                    sLinha = Space(68)
                    Mid(sLinha, 1) = "PGM"
                    Mid(sLinha, 11) = "===   P R O G R A M   ==="
                    Mid(sLinha, 46) = "00:00:01"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                End If

                '====================Linha titulo do Bloco
                sLinha = Space(68)
                sTitulo = Trim(VB.Left(drw.Titulo_Break, 20))
                If drw.IsSequencia_BreakNull Then
                    sBreak = drw.Breaks
                Else
                    sBreak = drw.Sequencia_Break
                End If

                If nTipoPrograma <> 1 Then
                    Mid(sLinha, 1) = "PAUSE "
                Else
                    Mid(sLinha, 1) = "PGM"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                End If
                Mid(sLinha, 11) = sTitulo & " - " & sBreak & " BL"
                Mid(sLinha, 46) = "00:00:00"
                Mid(sLinha, 68) = "1"
                PrintLine(nBuf, sLinha)

                nTipoAnterior = nTipoPrograma
                nUltimoBreak = CShort(sBreak)
                nContComercial = 0

            Else '====2. Linha do Comercial
                sLinha = Space(68)
                Mid(sLinha, 1) = VB.Right(Trim(drw.Numero_Fita), 4)
                Mid(sLinha, 11) = VB.Left(drw.Titulo_Comercial, 30)
                Mid(sLinha, 46) = cHora(drw.Duracao)
                Mid(sLinha, 54) = "VDR"
                Mid(sLinha, 68) = CStr(0)
                PrintLine(nBuf, sLinha)
                bPrimeiro = False
                nContComercial = nContComercial + 1
            End If

Proximo:
        Next

        '================Grava o Ultimo Bloco do Ultimo programa
        If Not bPrimeiro Then
            If nTipoAnterior = 0 And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade
                sLinha = Space(68)
                Mid(sLinha, 1) = "F"
                Mid(sLinha, 11) = "FADE"
                Mid(sLinha, 46) = "00:01:00"
                Mid(sLinha, 54) = "VDR"
                Mid(sLinha, 68) = CStr(1)
                PrintLine(nBuf, sLinha)
            End If

            If nTipoAnterior <> 1 Then
                sLinha = Space(68)
                Mid(sLinha, 1) = "PGM"
                Mid(sLinha, 11) = "===   P R O G R A M   ==="
                Mid(sLinha, 46) = "00:00:01"
                Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                Mid(sLinha, 68) = "1"
                PrintLine(nBuf, sLinha)
            End If

            sLinha = Space(68)
            If nTipoAnterior <> 1 Then
                Mid(sLinha, 1) = "PAUSE "
            Else
                Mid(sLinha, 1) = "PGM"
            End If
            Mid(sLinha, 11) = Trim(VB.Left(sTituloAnterior, 20)) & " - " & nUltimoBreak + 1 & " BL"
            Mid(sLinha, 46) = "00:00:00"
            Mid(sLinha, 68) = "1"
            PrintLine(nBuf, sLinha)
        End If

Saida:

        FileClose(nBuf)
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        bErroProcessamento = True
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub Gerar4sCamp(ByRef sVeiculoPlayList As String, ByRef sDataPlayList As String, ByRef sArquivo As String)
        On Error GoTo Erro

        Dim nBuf As Short
        Dim sLinha As String
        Dim aParam(3) As Object
        Dim aTipos(3) As Object
        Dim sTitulo As String

        Dim sTituloAnterior As String
        Dim sBreak As String
        Dim nTipoPrograma As Short ' Tipo do Programa 0=Rede 1-Local 2-Local ao Vivo
        Dim aTipoPrograma(2) As Object
        Dim nTipoAnterior As Short
        Dim bPrimeiro As Boolean
        Dim sProgramaAnterior As String
        Dim nUltimoBreak As Short
        Dim nContComercial As Short
        Dim nTipoBreak As Short
        Dim nDuracao As Integer


        'UPGRADE_WARNING: Couldn't resolve default property of object aTipoPrograma(0). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aTipoPrograma(0) = "SAT"
        'UPGRADE_WARNING: Couldn't resolve default property of object aTipoPrograma(1). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aTipoPrograma(1) = "VT1"
        'UPGRADE_WARNING: Couldn't resolve default property of object aTipoPrograma(2). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aTipoPrograma(2) = "PRD"


        Dim bIniciar As Boolean
        Dim bTerminar As Boolean
        bIniciar = False
        bTerminar = False
        bPrimeiro = True


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Gerando Arquivo de Integração do Roteiro! Veículo " & sVeiculoPlayList & " Aguarde...")


        sProgramaAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Cod_Programa
        If Not DtsRoteiro.dtbRoteiro_Ordenado(0).IsTitulo_BreakNull Then
            sTituloAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Titulo_Break
        Else
            sTituloAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Cod_Programa
        End If

        nBuf = FreeFile()
        FileOpen(nBuf, sArquivo, OpenMode.Output)

        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows

            If Not bIniciar Then
                If drw.Cod_Programa = ucPrograma1.Text Or ucPrograma1.Text.Trim = "" Then
                    bIniciar = True
                    sProgramaAnterior = drw.Cod_Programa
                    sTituloAnterior = drw.Titulo_Break
                End If
            End If

            If drw.Cod_Programa = ucPrograma2.Text And ucPrograma2.Text.Trim <> "" Then
                bTerminar = True
            End If

            If Not bIniciar Then
                GoTo Proximo
            End If

            If bTerminar And drw.Cod_Programa <> ucPrograma2.Text Then
                GoTo Saida
            End If


            '===============Se For Titulo do Break
            If drw.Indica_Titulo_Break = 1 Then
                nTipoBreak = -1
            End If
            '===============Despreza Linhas Titulos de Intervalo
            If drw.Indica_Titulo_Intervalo = 1 Then
                nTipoBreak = drw.Tipo_Break
                GoTo Proximo
            End If


            '===============Não envia comerciais que usuario não pode ordenar
            If drw.Indica_Ordenacao = 0 And drw.Indica_Titulo_Break = 0 Then
                GoTo Proximo
            End If
            '===============Quebra do Programa / Linha do Ultimo Bloco de Programa
            If sProgramaAnterior <> drw.Cod_Programa Then

                If Not bPrimeiro Then

                    If nTipoAnterior = 0 And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade
                        'sLinha = Space(68)
                        'Mid(sLinha, 1) = "F"
                        'Mid(sLinha, 11) = "FADE"
                        'Mid(sLinha, 46) = "00:01:00"
                        'Mid(sLinha, 54) = "VDR"
                        'Mid(sLinha, 68) = 1
                        'Print #nBuf, sLinha

                        sLinha = Space(68)
                        Mid(sLinha, 1) = "PAUSE"
                        Mid(sLinha, 11) = "PAUSE"
                        Mid(sLinha, 46) = "00:00:00"
                        Mid(sLinha, 54) = "VDR"
                        Mid(sLinha, 68) = CStr(1)
                        PrintLine(nBuf, sLinha)

                    End If

                    'If nTipoAnterior <> 1 Then
                    '   sLinha = Space(68)
                    '   Mid(sLinha, 1) = "PGM"
                    '   Mid(sLinha, 11) = "===   P R O G R A M   ==="
                    '   Mid(sLinha, 46) = "00:00:01"
                    '   Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    '   Mid(sLinha, 68) = "1"
                    '   Print #nBuf, sLinha
                    'End If


                    sLinha = Space(68)
                    'Mid(sLinha, 1) = "PGM"
                    Mid(sLinha, 1) = sProgramaAnterior & VB6.Format(nUltimoBreak + 1, "00")
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    Mid(sLinha, 11) = Trim(VB.Left(sTituloAnterior, 20)) & " - " & nUltimoBreak + 1 & " BL"
                    Mid(sLinha, 46) = "02:00:00"
                    Mid(sLinha, 54) = "SAT"
                    Mid(sLinha, 68) = "1"

                    PrintLine(nBuf, sLinha)
                    sProgramaAnterior = drw.Cod_Programa

                    If Not drw.IsTitulo_BreakNull Then
                        sTituloAnterior = drw.Titulo_Break
                    Else
                        sTituloAnterior = drw.Cod_Programa
                    End If
                    nTipoPrograma = drw.Indica_AoVivo

                End If
            End If

            '===============Linha do Inter Programa
            If drw.Indica_Titulo_Break = 1 And drw.Breaks = 0 Then
                If Not bPrimeiro Then
                    'sLinha = Space(68)
                    'Mid(sLinha, 1) = "INTERPGM"
                    'Mid(sLinha, 11) = "INTER PROGRAMA"
                    'Mid(sLinha, 46) = "00:00:00"
                    'Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    'Mid(sLinha, 68) = "1"
                    'Print #nBuf, sLinha
                End If
                nContComercial = 0
                GoTo Proximo
            End If

            '===============Linha Titulo do Programa / Break
            If drw.Indica_Titulo_Break = 1 And drw.Breaks <> 0 Then
                If nTipoAnterior = 0 And Not bPrimeiro And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade

                    'sLinha = Space(68)
                    'Mid(sLinha, 1) = "F"
                    'Mid(sLinha, 11) = "FADE"
                    'Mid(sLinha, 46) = "00:01:00"
                    'Mid(sLinha, 54) = "VDR"
                    'Mid(sLinha, 68) = 1
                    'Print #nBuf, sLinha


                    sLinha = Space(68)
                    Mid(sLinha, 1) = "PAUSE"
                    Mid(sLinha, 11) = "PAUSE"
                    Mid(sLinha, 46) = "00:00:00"
                    Mid(sLinha, 54) = "VDR"
                    Mid(sLinha, 68) = CStr(1)
                    PrintLine(nBuf, sLinha)


                End If


                '====================Linha titulo do Bloco
                sLinha = Space(68)
                sTitulo = VB.Left(drw.Titulo_Break, 20).Trim
                If drw.IsSequencia_BreakNull Then
                    sBreak = drw.Breaks
                Else
                    sBreak = drw.Sequencia_Break
                End If

                'Mid(sLinha, 1) = "PGM"
                Mid(sLinha, 1) = drw.Cod_Programa & VB6.Format(sBreak, "00")
                Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)

                Mid(sLinha, 11) = sTitulo & " - " & sBreak & " BL"
                Mid(sLinha, 46) = "02:00:00"
                Mid(sLinha, 54) = "SAT"
                Mid(sLinha, 68) = "1"
                PrintLine(nBuf, sLinha)

                nTipoAnterior = nTipoPrograma
                nUltimoBreak = CShort(sBreak)
                nContComercial = 0

            Else '====2. Linha do Comercial
                'UPGRADE_WARNING: Couldn't resolve default property of object VerNulo(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                nDuracao = drw.Duracao

                If nDuracao = 7 Then
                    nDuracao = 8
                End If

                sLinha = Space(68)
                Mid(sLinha, 1) = VB.Right(drw.Numero_Fita, 4).Trim
                Mid(sLinha, 11) = VB.Left(drw.Titulo_Comercial, 30)
                Mid(sLinha, 46) = cHora(nDuracao)
                Mid(sLinha, 54) = "VDR"
                Mid(sLinha, 68) = CStr(0)
                PrintLine(nBuf, sLinha)
                bPrimeiro = False
                nContComercial = nContComercial + 1
            End If

Proximo:
        Next

        '================Grava o Ultimo Bloco do Ultimo programa
        If Not bPrimeiro Then
            If nTipoAnterior = 0 And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade
                'sLinha = Space(68)
                'Mid(sLinha, 1) = "F"
                'Mid(sLinha, 11) = "FADE"
                'Mid(sLinha, 46) = "00:01:00"
                'Mid(sLinha, 54) = "VDR"
                'Mid(sLinha, 68) = 1
                'Print #nBuf, sLinha

                sLinha = Space(68)
                Mid(sLinha, 1) = "PAUSE"
                Mid(sLinha, 11) = "PAUSE"
                Mid(sLinha, 46) = "00:00:00"
                Mid(sLinha, 54) = "VDR"
                Mid(sLinha, 68) = CStr(1)
                PrintLine(nBuf, sLinha)
            End If

            If nTipoAnterior <> 1 Then
                'sLinha = Space(68)
                'Mid(sLinha, 1) = "PGM"
                'Mid(sLinha, 11) = "===   P R O G R A M   ==="
                'Mid(sLinha, 46) = "00:00:01"
                'Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                'Mid(sLinha, 68) = "1"
                'Print #nBuf, sLinha
            End If

            sLinha = Space(68)

            Mid(sLinha, 1) = sProgramaAnterior & VB6.Format(nUltimoBreak, "00")
            Mid(sLinha, 11) = Trim(VB.Left(sTituloAnterior, 20)) & " - " & nUltimoBreak + 1 & " BL"
            Mid(sLinha, 46) = "02:00:00"
            Mid(sLinha, 54) = "SAT"
            Mid(sLinha, 68) = "1"
            PrintLine(nBuf, sLinha)
        End If

Saida:

        FileClose(nBuf)
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        bErroProcessamento = True
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub GerarLeitch(ByRef sVeiculoPlayList As String, ByRef sDataPlayList As String, ByRef sArquivo As String)



Saida:
        Exit Sub
Erro:
        bErroProcessamento = True
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub



    Private Sub Gerar4sIT(ByRef sVeiculoPlayList As String, ByRef sDataPlayList As String, ByRef sArquivo As String)

        On Error GoTo Erro

        Dim nBuf As Short
        Dim sLinha As String
        Dim aParam(3) As Object
        Dim aTipos(3) As Object
        Dim sTitulo As String

        Dim sTituloAnterior As String
        Dim sBreak As String
        Dim nTipoPrograma As Short ' Tipo do Programa 0=Rede 1-Local 2-Local ao Vivo
        Dim aTipoPrograma(2) As Object
        Dim nTipoAnterior As Short
        Dim bPrimeiro As Boolean
        Dim sProgramaAnterior As String
        Dim nUltimoBreak As Short
        Dim nContComercial As Short
        Dim nTipoBreak As Short



        aTipoPrograma(0) = "SAT"
        aTipoPrograma(1) = "VT1"
        aTipoPrograma(2) = "PRD"


        Dim bIniciar As Boolean
        Dim bTerminar As Boolean
        bIniciar = False
        bTerminar = False
        bPrimeiro = True


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Gerando Arquivo de Integração do Roteiro! Veículo " & sVeiculoPlayList & " Aguarde...")


        sProgramaAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Cod_Programa
        If Not DtsRoteiro.dtbRoteiro_Ordenado(0).IsTitulo_BreakNull Then
            sTituloAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Titulo_Break
        Else
            sTituloAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Cod_Programa
        End If

        nBuf = FreeFile()
        FileOpen(nBuf, sArquivo, OpenMode.Output)

        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows

            If Not bIniciar Then
                If drw.Cod_Programa = ucPrograma1.Text Or Trim(ucPrograma1.Text) = "" Then
                    bIniciar = True
                    sProgramaAnterior = drw.Cod_Programa
                    sTituloAnterior = drw.Titulo_Break
                End If
            End If

            If drw.Cod_Programa = ucPrograma2.Text And Trim(ucPrograma2.Text) <> "" Then
                bTerminar = True
            End If

            If Not bIniciar Then
                GoTo Proximo
            End If

            If bTerminar And drw.Cod_Programa <> ucPrograma2.Text Then
                GoTo Saida
            End If

            '===============Se For Titulo do Break
            If drw.Indica_Titulo_Break = 1 Then
                nTipoBreak = -1
            End If
            '===============Despreza Linhas Titulos de Intervalo
            If drw.Indica_Titulo_Intervalo = 1 Then
                nTipoBreak = drw.Tipo_Break
                GoTo Proximo
            End If


            '===============Não envia comerciais que usuario não pode ordenar
            If drw.Indica_Ordenacao = 0 And drw.Indica_Titulo_Break = 0 Then
                GoTo Proximo
            End If


            '===============Quebra do Programa / Linha do Ultimo Bloco de Programa
            If sProgramaAnterior <> drw.Cod_Programa Then

                If Not bPrimeiro Then

                    'If nTipoAnterior = 0 And nContComercial > 0 Then  '  quando termina um break da rede, Linha de Fade
                    '   sLinha = Space(68)
                    '   Mid(sLinha, 1) = "F"
                    '   Mid(sLinha, 11) = "FADE"
                    '   Mid(sLinha, 46) = "00:01:00"
                    '   Mid(sLinha, 54) = "VDR"
                    '   Mid(sLinha, 68) = 1
                    '   Print #nBuf, sLinha
                    'End If

                    If nTipoAnterior <> 1 Then
                        sLinha = Space(68)
                        Mid(sLinha, 1) = "PGM"
                        Mid(sLinha, 11) = "===   P R O G R A M   ==="
                        Mid(sLinha, 46) = "01:00:00"
                        'UPGRADE_WARNING: Couldn't resolve default property of object aTipoPrograma(nTipoPrograma). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                        Mid(sLinha, 68) = "1"
                        PrintLine(nBuf, sLinha)
                    End If


                    sLinha = Space(68)
                    If nTipoAnterior <> 1 Then
                        Mid(sLinha, 1) = "PAUSE"
                    Else
                        Mid(sLinha, 1) = "PGM"
                        'UPGRADE_WARNING: Couldn't resolve default property of object aTipoPrograma(nTipoPrograma). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    End If

                    Mid(sLinha, 11) = Trim(VB.Left(sTituloAnterior, 20)) & " - " & nUltimoBreak + 1 & " BL"
                    Mid(sLinha, 46) = "01:00:00"
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                    sProgramaAnterior = drw.Cod_Programa

                    If Not drw.IsTitulo_BreakNull Then
                        sTituloAnterior = drw.Titulo_Break
                    Else
                        sTituloAnterior = drw.Cod_Programa
                    End If

                    nTipoPrograma = drw.Indica_AoVivo

                End If
            End If

            '===============Linha do Inter Programa
            If drw.Indica_Titulo_Break = 1 And drw.Breaks = 0 Then
                If Not bPrimeiro Then
                    sLinha = Space(68)
                    Mid(sLinha, 1) = "INTERPGM"
                    Mid(sLinha, 11) = "INTER PROGRAMA"
                    Mid(sLinha, 46) = "00:00:00"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                End If
                nContComercial = 0
                GoTo Proximo
            End If

            '===============Linha Titulo do Programa / Break
            If drw.Indica_Titulo_Break = 1 And drw.Breaks <> 0 Then
                'If nTipoAnterior = 0 And Not bPrimeiro And nContComercial > 0 Then  '  quando termina um break da rede, Linha de Fade
                '   sLinha = Space(68)
                '   Mid(sLinha, 1) = "F"
                '   Mid(sLinha, 11) = "FADE"
                '   Mid(sLinha, 46) = "00:01:00"
                '   Mid(sLinha, 54) = "VDR"
                '   Mid(sLinha, 68) = 1
                '   Print #nBuf, sLinha
                'End If

                If nTipoPrograma <> 1 Then
                    sLinha = Space(68)
                    Mid(sLinha, 1) = "PGM"
                    Mid(sLinha, 11) = "===   P R O G R A M   ==="
                    Mid(sLinha, 46) = "01:00:00"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                End If

                '====================Linha titulo do Bloco
                sLinha = Space(68)
                sTitulo = Trim(VB.Left(drw.Titulo_Break, 20))
                If drw.IsSequencia_BreakNull Then
                    sBreak = drw.Breaks
                Else
                    sBreak = drw.Sequencia_Break
                End If

                If nTipoPrograma <> 1 Then
                    Mid(sLinha, 1) = "PAUSE "
                Else
                    Mid(sLinha, 1) = "PGM"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                End If
                Mid(sLinha, 11) = sTitulo & " - " & sBreak & " BL"
                Mid(sLinha, 46) = "01:00:00"
                Mid(sLinha, 68) = "1"
                PrintLine(nBuf, sLinha)

                nTipoAnterior = nTipoPrograma
                nUltimoBreak = CShort(sBreak)
                nContComercial = 0

            Else '====2. Linha do Comercial
                sLinha = Space(68)
                Mid(sLinha, 1) = VB.Right(drw.Numero_Fita, 4).Trim
                Mid(sLinha, 11) = VB.Left(drw.Titulo_Comercial, 30)
                Mid(sLinha, 46) = cHora(drw.Duracao)
                Mid(sLinha, 54) = "VDR"
                Mid(sLinha, 68) = CStr(0)
                PrintLine(nBuf, sLinha)
                bPrimeiro = False
                nContComercial = nContComercial + 1
            End If

Proximo:

        Next

        '================Grava o Ultimo Bloco do Ultimo programa
        If Not bPrimeiro Then
            'If nTipoAnterior = 0 And nContComercial > 0 Then  '  quando termina um break da rede, Linha de Fade
            'sLinha = Space(68)
            'Mid(sLinha, 1) = "F"
            'Mid(sLinha, 11) = "FADE"
            'Mid(sLinha, 46) = "00:01:00"
            'Mid(sLinha, 54) = "VDR"
            'Mid(sLinha, 68) = 1
            'Print #nBuf, sLinha
            'End If

            If nTipoAnterior <> 1 Then
                sLinha = Space(68)
                Mid(sLinha, 1) = "PGM"
                Mid(sLinha, 11) = "===   P R O G R A M   ==="
                Mid(sLinha, 46) = "01:00:00"
                'UPGRADE_WARNING: Couldn't resolve default property of object aTipoPrograma(nTipoPrograma). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                Mid(sLinha, 68) = "1"
                PrintLine(nBuf, sLinha)
            End If

            sLinha = Space(68)
            If nTipoAnterior <> 1 Then
                Mid(sLinha, 1) = "PAUSE "
            Else
                Mid(sLinha, 1) = "PGM"
            End If
            Mid(sLinha, 11) = Trim(VB.Left(sTituloAnterior, 20)) & " - " & nUltimoBreak + 1 & " BL"
            Mid(sLinha, 46) = "01:00:00"
            Mid(sLinha, 68) = "1"
            PrintLine(nBuf, sLinha)
        End If

Saida:

        FileClose(nBuf)
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        bErroProcessamento = True
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub Gerar4sCV(ByRef sVeiculoPlayList As String, ByRef sDataPlayList As String, ByRef sArquivo As String)

        On Error GoTo Erro

        Dim nBuf As Short
        Dim sLinha As String
        Dim sTitulo As String

        Dim sTituloAnterior As String
        Dim sBreak As String
        Dim nTipoPrograma As Short ' Tipo do Programa 0=Rede 1-Local 2-Local ao Vivo
        Dim aTipoPrograma(0 To 2) As String
        Dim nTipoAnterior As Short
        Dim bPrimeiro As Boolean
        Dim sProgramaAnterior As String
        Dim nUltimoBreak As Short
        Dim nContComercial As Short
        Dim nTipoBreak As Short


        aTipoPrograma(0) = "SAT"
        aTipoPrograma(1) = "VT1"
        aTipoPrograma(2) = "PRD"


        Dim bIniciar As Boolean
        Dim bTerminar As Boolean
        bIniciar = False
        bTerminar = False
        bPrimeiro = True

        Mensagem("Gerando Arquivo de Integração do Roteiro! Veículo " & sVeiculoPlayList & " Aguarde...")

        nBuf = FreeFile()
        FileOpen(nBuf, sArquivo, OpenMode.Output)

        sProgramaAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Cod_Programa
        If DtsRoteiro.dtbRoteiro_Ordenado(0).IsTitulo_BreakNull Then
            sTituloAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Titulo_Break
        Else
            sTituloAnterior = DtsRoteiro.dtbRoteiro_Ordenado(0).Cod_Programa
        End If


        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows


            If drw.Cod_Programa = ucPrograma1.Text Or ucPrograma1.Text.Trim = "" Then
                bIniciar = True
            End If

            If drw.Cod_Programa = ucPrograma2.Text And ucPrograma2.Text.Trim <> "" Then
                bTerminar = True
            End If

            If Not bIniciar Then
                GoTo Proximo
            End If

            If bTerminar And drw.Cod_Programa <> ucPrograma2.Text Then
                GoTo Saida
            End If

            '===============Se For Titulo do Break
            If drw.Indica_Titulo_Break = 1 Then
                nTipoBreak = -1
            End If

            '===============Despreza Linhas Titulos de Intervalo
            If drw.Indica_Titulo_Intervalo = 1 Then
                nTipoBreak = drw.Tipo_Break 'Guarda o Tipo de Intervalo
                GoTo Proximo
            End If
            If drw.Indica_Ordenacao = 0 And drw.Indica_Titulo_Break = 0 Then
                GoTo Proximo
            End If
            '===============Quebra do Programa / Linha do Ultimo Bloco de Programa
            If sProgramaAnterior <> drw.Cod_Programa Then

                If Not bPrimeiro Then

                    If nTipoAnterior = 0 And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade
                        sLinha = Space(68)
                        Mid(sLinha, 1) = "F"
                        Mid(sLinha, 11) = "FADE"
                        Mid(sLinha, 46) = "00:01:00"
                        Mid(sLinha, 54) = "VDR"
                        Mid(sLinha, 68) = CStr(1)
                        PrintLine(nBuf, sLinha)
                    End If

                    If nTipoAnterior <> 1 Then
                        sLinha = Space(68)
                        Mid(sLinha, 1) = "PGM"
                        Mid(sLinha, 11) = "===   P R O G R A M   ==="
                        Mid(sLinha, 46) = "00:00:01"
                        'UPGRADE_WARNING: Couldn't resolve default property of object aTipoPrograma(nTipoPrograma). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                        Mid(sLinha, 68) = "1"
                        PrintLine(nBuf, sLinha)
                    End If


                    sLinha = Space(68)
                    If nTipoAnterior <> 1 Then
                        Mid(sLinha, 1) = "PAUSE "
                    Else
                        Mid(sLinha, 1) = "PGM"
                        Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    End If

                    Mid(sLinha, 11) = Trim(VB.Left(sTituloAnterior, 20)) & " - " & nUltimoBreak + 1 & " BL"
                    Mid(sLinha, 46) = "00:00:00"
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                    sProgramaAnterior = drw.Cod_Programa

                    If Not drw.IsTitulo_BreakNull Then
                        sTituloAnterior = drw.Titulo_Break
                    Else
                        sTituloAnterior = drw.Cod_Programa
                    End If

                    nTipoPrograma = drw.Indica_AoVivo

                End If
            End If

            '===============Linha do Inter Programa
            If drw.Indica_Titulo_Break = 1 And drw.Breaks = 0 Then
                If Not bPrimeiro Then
                    sLinha = Space(68)
                    Mid(sLinha, 1) = "INTERPGM"
                    Mid(sLinha, 11) = "INTER PROGRAMA"
                    Mid(sLinha, 46) = "00:00:00"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                End If
                nContComercial = 0
                GoTo Proximo
            End If

            '===============Linha Titulo do Programa / Break
            If drw.Indica_Titulo_Break = 1 And drw.Breaks <> 0 Then
                If nTipoAnterior = 0 And Not bPrimeiro And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade
                    sLinha = Space(68)
                    Mid(sLinha, 1) = "F"
                    Mid(sLinha, 11) = "FADE"
                    Mid(sLinha, 46) = "00:01:00"
                    Mid(sLinha, 54) = "VDR"
                    Mid(sLinha, 68) = CStr(1)
                    PrintLine(nBuf, sLinha)
                End If
                If nTipoPrograma <> 1 Then
                    sLinha = Space(68)
                    Mid(sLinha, 1) = "PGM"
                    Mid(sLinha, 11) = "===   P R O G R A M   ==="
                    Mid(sLinha, 46) = "00:00:01"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                    Mid(sLinha, 68) = "1"
                    PrintLine(nBuf, sLinha)
                End If

                '====================Linha titulo do Bloco
                sLinha = Space(68)
                sTitulo = Trim(VB.Left(drw.Titulo_Break, 20))
                If drw.IsSequencia_BreakNull Then
                    sBreak = drw.Breaks
                Else
                    sBreak = drw.Sequencia_Break
                End If

                If nTipoPrograma <> 1 Then
                    Mid(sLinha, 1) = "PAUSE "
                Else
                    Mid(sLinha, 1) = "PGM"
                    Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                End If
                Mid(sLinha, 11) = sTitulo & " - " & sBreak & " BL"
                Mid(sLinha, 46) = "00:00:00"
                Mid(sLinha, 68) = "1"
                PrintLine(nBuf, sLinha)

                nTipoAnterior = nTipoPrograma
                nUltimoBreak = CShort(sBreak)
                nContComercial = 0

            Else '====2. Linha do Comercial
                sLinha = Space(68)
                Mid(sLinha, 1) = VB.Right(drw.Numero_Fita, 3).Trim
                Mid(sLinha, 11) = VB.Left(drw.Titulo_Comercial, 30)
                Mid(sLinha, 46) = cHora(drw.Duracao)
                Mid(sLinha, 54) = "VDR"
                Mid(sLinha, 68) = CStr(0)
                PrintLine(nBuf, sLinha)
                bPrimeiro = False
                nContComercial = nContComercial + 1
            End If

Proximo:

        Next

        '================Grava o Ultimo Bloco do Ultimo programa
        If Not bPrimeiro Then
            If nTipoAnterior = 0 And nContComercial > 0 Then '  quando termina um break da rede, Linha de Fade
                sLinha = Space(68)
                Mid(sLinha, 1) = "F"
                Mid(sLinha, 11) = "FADE"
                Mid(sLinha, 46) = "00:01:00"
                Mid(sLinha, 54) = "VDR"
                Mid(sLinha, 68) = CStr(1)
                PrintLine(nBuf, sLinha)
            End If

            If nTipoAnterior <> 1 Then
                sLinha = Space(68)
                Mid(sLinha, 1) = "PGM"
                Mid(sLinha, 11) = "===   P R O G R A M   ==="
                Mid(sLinha, 46) = "00:00:01"
                Mid(sLinha, 54) = aTipoPrograma(nTipoPrograma)
                Mid(sLinha, 68) = "1"
                PrintLine(nBuf, sLinha)
            End If

            sLinha = Space(68)
            If nTipoAnterior <> 1 Then
                Mid(sLinha, 1) = "PAUSE "
            Else
                Mid(sLinha, 1) = "PGM"
            End If
            Mid(sLinha, 11) = Trim(VB.Left(sTituloAnterior, 20)) & " - " & nUltimoBreak + 1 & " BL"
            Mid(sLinha, 46) = "00:00:00"
            Mid(sLinha, 68) = "1"
            PrintLine(nBuf, sLinha)
        End If

Saida:

        FileClose(nBuf)
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        bErroProcessamento = True
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub



    Private Sub Gerar4SVARG(ByRef sVeiculoPlayList As String, ByRef sDataPlayList As String, ByRef sArquivo As String)

        On Error GoTo Erro

        Dim nBuf As Short

        Dim sLinha As String
        Dim aParam(3) As Object
        Dim aTipos(3) As Object
        Dim bIniciar As Boolean
        Dim bTerminar As Boolean
        bIniciar = False
        bTerminar = False
        Dim sParametroFita As String
        Dim nPosicaoFita As Short
        Dim nTamanhaFita As Short
        Dim nTipoBreak As Short
        Dim aTipoPrograma(2) As Object
        Dim nTipoPrograma As Short
        Dim sBreaks As String


        aTipoPrograma(0) = "SAT"
        aTipoPrograma(1) = "VT1"
        aTipoPrograma(2) = "PRD"


        '---------------------------Le Parametro de Configruacao de Fitas
        nPosicaoFita = 1 '  default
        nTamanhaFita = 6 '  default
        sParametroFita = fParametro(76, , , sVeiculoPlayList)
        If Trim(sParametroFita) <> "" Then
            nPosicaoFita = Val(VB.Left(sParametroFita, 2))
            nTamanhaFita = Val(VB.Right(sParametroFita, 2))
        End If

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Gerando Arquivo de Integração do Roteiro! Veículo " & sVeiculoPlayList & " Aguarde...")

        nBuf = FreeFile()
        FileOpen(nBuf, sArquivo, OpenMode.Output)

        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows

            If drw.Cod_Programa = ucPrograma1.Text Or Trim(ucPrograma1.Text) = "" Then
                bIniciar = True
            End If

            If drw.Cod_Programa = ucPrograma2.Text And Trim(ucPrograma2.Text) <> "" Then
                bTerminar = True
            End If

            If Not bIniciar Then
                GoTo Proximo
            End If

            If bTerminar And drw.Cod_Programa <> ucPrograma2.Text Then
                GoTo Saida
            End If


            '===============Se For Titulo do Break
            If drw.Indica_Titulo_Break = 1 Then
                nTipoBreak = -1
            End If
            '===============Despreza Linhas Titulos de Intervalo
            If drw.Indica_Titulo_Intervalo = 1 Then
                nTipoBreak = drw.Tipo_Break
                GoTo Proximo
            End If
            '===============Não envia comerciais que usuario não pode ordenar
            If drw.Indica_Ordenacao = 0 And drw.Indica_Titulo_Break = 0 Then
                GoTo Proximo
            End If

            '---------------Despreza Linhas Titulos de Intervalo
            'If ADORs!Indica_Titulo_Intervalo = 1 Then
            '   GoTo Proximo
            'End If
            '---------------Despreza Registros que veiculacao pertence a outro veiculo
            '               Verificar se pode desconsiderar Net
            'If ADORs!Cod_Veiculo_Origem <> ADORs!cod_veiculo Then
            '   GoTo Proximo
            'End If
            If Not drw.IsTipo_BreakNull Then
                If drw.Tipo_Break = 1 Then
                    GoTo Proximo
                End If
            End If



            If drw.Indica_Titulo_Break = 1 Then '----1. Linha Titulo do Programa / Break

                If drw.IsSequencia_BreakNull Then
                    sBreaks = VB6.Format(drw.Breaks, "00")
                Else
                    sBreaks = VB6.Format(drw.Sequencia_Break, "00")
                End If
                nTipoPrograma = drw.Indica_AoVivo


                sLinha = Space(68)
                Mid(sLinha, 1, 10) = Trim(drw.Cod_Programa) & "" & sBreaks
                Mid(sLinha, 11, 30) = "Bl" & sBreaks & " - " & Vernulo(Trim(drw.Titulo_Break), "")
                Mid(sLinha, 41, 4) = Trim(drw.Cod_Programa)
                'Mid(sLinha, 46, 8) = cHora(VerNulo(ADORs!encaixe, 0))
                Mid(sLinha, 46, 8) = "00:00:00"

                If drw.Breaks = "00" Then
                    Mid(sLinha, 54, 10) = "INTE"
                Else
                    Mid(sLinha, 54, 10) = aTipoPrograma(nTipoPrograma)
                End If

                Mid(sLinha, 68, 1) = "1"
                PrintLine(nBuf, sLinha)

            Else '----2. Linha do Comercial
                sLinha = Space(68)
                Mid(sLinha, 1, 10) = Mid(drw.Numero_Fita + Space(10), nPosicaoFita, nTamanhaFita)
                Mid(sLinha, 11, 30) = drw.Titulo_Comercial.Trim
                Mid(sLinha, 46, 8) = cHora(drw.Duracao)
                Mid(sLinha, 54, 10) = "LOC"
                Mid(sLinha, 68, 1) = "0"
                PrintLine(nBuf, sLinha)
            End If
Proximo:

        Next

Saida:

        FileClose(nBuf)
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        bErroProcessamento = True
        If Err.Number = 76 Then
            Aviso("Veiculo:" & sVeiculoPlayList & " - O Caminho " & sArquivo & " Não Existe")
        Else
            Erro(Err.Number)
        End If
        Resume Saida
        Resume

    End Sub
    Private Sub Gerar4SARATU(ByRef sVeiculoPlayList As String, ByRef sDataPlayList As String, ByRef sArquivo As String)

        On Error GoTo Erro

        Dim nBuf As Short

        Dim sLinha As String
        Dim aParam(3) As Object
        Dim aTipos(3) As Object
        Dim bIniciar As Boolean
        Dim bTerminar As Boolean
        bIniciar = False
        bTerminar = False
        Dim sParametroFita As String
        Dim nPosicaoFita As Short
        Dim nTamanhaFita As Short
        Dim nTipoBreak As Short
        Dim aTipoPrograma(2) As Object
        Dim nTipoPrograma As Short
        Dim sBreaks As String


        aTipoPrograma(0) = "SAT"
        aTipoPrograma(1) = "SWJ"
        aTipoPrograma(2) = "SWJ"


        '---------------------------Le Parametro de Configruacao de Fitas
        nPosicaoFita = 1 '  default
        nTamanhaFita = 6 '  default
        sParametroFita = fParametro(76, , , sVeiculoPlayList)
        If Trim(sParametroFita) <> "" Then
            nPosicaoFita = Val(VB.Left(sParametroFita, 2))
            nTamanhaFita = Val(VB.Right(sParametroFita, 2))
        End If

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Gerando Arquivo de Integração do Roteiro! Veículo " & sVeiculoPlayList & " Aguarde...")

        nBuf = FreeFile()
        FileOpen(nBuf, sArquivo, OpenMode.Output)

        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows

            If drw.Cod_Programa = ucPrograma1.Text Or Trim(ucPrograma1.Text) = "" Then
                bIniciar = True
            End If

            If drw.Cod_Programa = ucPrograma2.Text And Trim(ucPrograma2.Text) <> "" Then
                bTerminar = True
            End If

            If Not bIniciar Then
                GoTo Proximo
            End If

            If bTerminar And drw.Cod_Programa <> ucPrograma2.Text Then
                GoTo Saida
            End If


            '===============Se For Titulo do Break
            If drw.Indica_Titulo_Break = 1 Then
                nTipoBreak = -1
            End If
            '===============Despreza Linhas Titulos de Intervalo
            If drw.Indica_Titulo_Intervalo = 1 Then
                nTipoBreak = drw.Tipo_Break
                GoTo Proximo
            End If
            '===============Não envia comerciais que usuario não pode ordenar
            If drw.Indica_Ordenacao = 0 And drw.Indica_Titulo_Break = 0 Then
                GoTo Proximo
            End If

            '---------------Despreza Linhas Titulos de Intervalo
            'If ADORs!Indica_Titulo_Intervalo = 1 Then
            '   GoTo Proximo
            'End If
            '---------------Despreza Registros que veiculacao pertence a outro veiculo
            '               Verificar se pode desconsiderar Net
            'If ADORs!Cod_Veiculo_Origem <> ADORs!cod_veiculo Then
            '   GoTo Proximo
            'End If
            If Not drw.IsTipo_BreakNull Then
                If drw.Tipo_Break = 1 Then
                    GoTo Proximo
                End If
            End If



            If drw.Indica_Titulo_Break = 1 Then '----1. Linha Titulo do Programa / Break

                If drw.IsSequencia_BreakNull Then
                    sBreaks = VB6.Format(drw.Breaks, "00")
                Else
                    sBreaks = VB6.Format(drw.Sequencia_Break, "00")
                End If
                nTipoPrograma = "1"


                sLinha = Space(53)
                'Mid(sLinha, 1) = ADORs!Cod_Programa & Format(sBreak, "00")
                'Mid(sLinha, 11) = sTitulo
                'Mid(sLinha, 41) = "02:00:00"
                'Mid(sLinha, 49) = aTipoPrograma(nTipoPrograma)
                'Mid(sLinha, 53) = "1"
                ' Print #nBuf, sLinha

                Mid(sLinha, 1) = Trim(drw.Cod_Programa) & "" & sBreaks
                Mid(sLinha, 11) = Vernulo(Trim(drw.Titulo_Break), "")
                Mid(sLinha, 41) = "02:00:00"
                Mid(sLinha, 49) = aTipoPrograma(nTipoPrograma)
                Mid(sLinha, 53) = "1"

                'If drw.Breaks = "00" Then
                ' Mid(sLinha, 54, 10) = "INTE"
                'Else
                ' Mid(sLinha, 54, 10) = aTipoPrograma(nTipoPrograma)
                'End If

                'Mid(sLinha, 68, 1) = "1"
                PrintLine(nBuf, sLinha)

            Else '----2. Linha do Comercial
                'sLinha = Space(53)
                'Mid(sLinha, 1) = "0"
                'Mid(sLinha, 2) = Right(Trim(VerNulo(ADORs!Numero_Fita, "")), 4)
                'Mid(sLinha, 11) = Left(ADORs!Titulo_Comercial, 30)
                'Mid(sLinha, 41) = cHora(VerNulo(ADORs!Duracao, 0))
                'Mid(sLinha, 53) = 0
                'Print #nBuf, sLinha
                'bPrimeiro = False
                'nContComercial = nContComercial + 1

                sLinha = Space(53)
                Mid(sLinha, 1) = "0"
                Mid(sLinha, 2) = Mid(drw.Numero_Fita + Space(10), nPosicaoFita, nTamanhaFita)
                Mid(sLinha, 11) = drw.Titulo_Comercial.Trim
                Mid(sLinha, 41) = cHora(drw.Duracao)
                Mid(sLinha, 53, 10) = "0"
                PrintLine(nBuf, sLinha)
            End If
Proximo:

        Next

Saida:

        FileClose(nBuf)
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        bErroProcessamento = True
        If Err.Number = 76 Then
            Aviso("Veiculo:" & sVeiculoPlayList & " - O Caminho " & sArquivo & " Não Existe")
        Else
            Erro(Err.Number)
        End If
        Resume Saida
        Resume

    End Sub

    Private Sub GerarFloripa(ByRef sVeiculoPlayList As String, ByRef sDataPlayList As String, ByRef sArquivo As String)

        On Error GoTo Erro

        Dim nBuf As Short

        Dim sLinha As String
        Dim aParam(3) As Object
        Dim aTipos(3) As Object
        Dim bIniciar As Boolean
        Dim bTerminar As Boolean
        bIniciar = False
        bTerminar = False
        Dim sParametroFita As String
        Dim nPosicaoFita As Short
        Dim nTamanhaFita As Short
        Dim nTipoBreak As Short


        '---------------------------Le Parametro de Configruacao de Fitas
        nPosicaoFita = 1 '  default
        nTamanhaFita = 6 '  default
        sParametroFita = fParametro(76, , , sVeiculoPlayList)
        If Trim(sParametroFita) <> "" Then
            nPosicaoFita = Val(VB.Left(sParametroFita, 2))
            nTamanhaFita = Val(VB.Right(sParametroFita, 2))
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Gerando Arquivo de Integração do Roteiro! Veículo " & sVeiculoPlayList & " Aguarde...")

        '---------------------------Executa Consulta do Roteiro

        nBuf = FreeFile()
        FileOpen(nBuf, sArquivo, OpenMode.Output)

        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows

            If drw.Cod_Programa = ucPrograma1.Text Or Trim(ucPrograma1.Text) = "" Then
                bIniciar = True
            End If

            If drw.Cod_Programa = ucPrograma2.Text And Trim(ucPrograma2.Text) <> "" Then
                bTerminar = True
            End If

            If Not bIniciar Then
                GoTo Proximo
            End If

            If bTerminar And drw.Cod_Programa <> ucPrograma2.Text Then
                GoTo Saida
            End If


            '===============Se For Titulo do Break
            If drw.Indica_Titulo_Break = 1 Then
                nTipoBreak = -1
            End If
            '===============Despreza Linhas Titulos de Intervalo
            If drw.Indica_Titulo_Intervalo = 1 Then
                nTipoBreak = drw.Tipo_Break
                GoTo Proximo
            End If


            '===============Não envia comerciais que usuario não pode ordenar
            If drw.Indica_Ordenacao = 0 And drw.Indica_Titulo_Break = 0 Then
                GoTo Proximo
            End If

            '---------------Despreza Linhas Titulos de Intervalo
            'If ADORs!Indica_Titulo_Intervalo = 1 Then
            '   GoTo Proximo
            'End If
            '---------------Despreza Registros que veiculacao pertence a outro veiculo
            '               Verificar se pode desconsiderar Net
            'If ADORs!Cod_Veiculo_Origem <> ADORs!cod_veiculo Then
            '   GoTo Proximo
            'End If
            If Not drw.IsTipo_BreakNull Then
                If drw.Tipo_Break = 1 Then
                    GoTo Proximo
                End If
            End If



            If drw.Indica_Titulo_Break = 1 Then '----1. Linha Titulo do Programa / Break

                sLinha = Space(44)
                Mid(sLinha, 1, 1) = "*"
                Mid(sLinha, 2, 4) = drw.Cod_Programa
                Mid(sLinha, 6, 1) = ""
                Mid(sLinha, 7, 9) = drw.Titulo_Break
                Mid(sLinha, 17, 6) = "BREAK:"


                If drw.IsSequencia_BreakNull Then
                    Mid(sLinha, 25, 2) = VB6.Format(drw.Breaks, "00")
                Else
                    Mid(sLinha, 25, 2) = VB6.Format(drw.Sequencia_Break, "00")
                End If
                Mid(sLinha, 29, 6) = ""
                Mid(sLinha, 34, 8) = "00:00:00"
                PrintLine(nBuf, sLinha)

            Else '----2. Linha do Comercial
                sLinha = Space(44)
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not drw.IsNumero_FitaNull Then
                    Mid(sLinha, 1, 6) = Mid(drw.Numero_Fita, nPosicaoFita, nTamanhaFita)
                    PrintLine(nBuf, sLinha)
                End If
            End If
Proximo:
        Next
Saida:

        FileClose(nBuf)
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        bErroProcessamento = True
        If Err.Number = 76 Then
            Aviso("Veiculo:" & sVeiculoPlayList & " - O Caminho " & sArquivo & " Não Existe")
        Else
            Erro(Err.Number)
        End If
        Resume Saida
        Resume

    End Sub

    Private Sub txtFitaPosicao_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFitaPosicao.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 32 And KeyAscii <> 8 Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub txtFitaTamanho_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFitaTamanho.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 32 And KeyAscii <> 8 Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    

    Private Sub _cmdPrograma_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UcData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcData.Load

    End Sub

    Private Sub UcData_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcData.RegionChanged

    End Sub

    Private Sub UcData_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcData.Validated

        On Error GoTo Erro
        Dim nPosicao As Short
        Dim sArquivo As String


        If Not IsDate(UcData.DateTime) Then
            GoTo Saida
        End If

        If UcData.DateTime = Date.MinValue Then
            GoTo saida
        End If
        ucPrograma1.DataInicio = UcData.DateTime
        ucPrograma1.DataFim = UcData.DateTime
        ucPrograma2.DataInicio = UcData.DateTime
        ucPrograma2.DataFim = UcData.DateTime

        UcPrograma1.Enabled = True
        ucPrograma2.Enabled = True




        '------------Formata nome dos arquivos que usam data
        With flxVeiculo
            For nCont = 1 To .Rows - 1
                If .get_TextMatrix(nCont, 7) <> "1" Then
                    sArquivo = .get_TextMatrix(nCont, 8)
                    nPosicao = InStr(sArquivo, "ddmmyy")
                    If nPosicao > 0 Then
                        Mid(sArquivo, nPosicao) = VB6.Format(UcData.DateTime, "ddmmyy")
                        .set_TextMatrix(nCont, 5, sArquivo)
                    End If
                End If
            Next nCont
        End With
Saida:
        Call FormataNomeArquivo()
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub UcPrograma1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo Erro
        Dim AsmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro = NewRoteiro()
        Dim DtsRoteiro As MSAClass.AsmxRoteiro.dtsRoteiro = New MSAClass.AsmxRoteiro.dtsRoteiro
        Dim strCod_Veiculo As String = ""
        With flxVeiculo
            For x As Integer = 0 To .Rows - 1
                If .get_RowData(x) = 1 Then
                    strCod_Veiculo = .get_TextMatrix(x, 2)
                    Exit For
                End If
            Next
        End With

        If strCod_Veiculo.Trim = "" Or UcData.Text.Trim = "" Then
            GoTo saida
        End If
        DtsRoteiro = AsmxRoteiro.spuCarregaRoteiro_Programa(strCod_Veiculo, UcData.DateTime, "")
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub UcPrograma2_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error GoTo Erro
        Dim AsmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro = NewRoteiro()
        Dim DtsRoteiro As MSAClass.AsmxRoteiro.dtsRoteiro = New MSAClass.AsmxRoteiro.dtsRoteiro
        Dim strCod_Veiculo As String = ""
        With flxVeiculo
            For x As Integer = 0 To .Rows - 1
                If .get_RowData(x) = 1 Then
                    strCod_Veiculo = .get_TextMatrix(x, 2)
                    Exit For
                End If
            Next
        End With

        If strCod_Veiculo.Trim = "" Or UcData.Text.Trim = "" Then
            GoTo saida
        End If

        DtsRoteiro = AsmxRoteiro.spuCarregaRoteiro_Programa(strCod_Veiculo, UcData.DateTime, "")
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub
End Class