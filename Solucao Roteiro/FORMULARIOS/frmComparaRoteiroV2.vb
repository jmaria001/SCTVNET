Option Strict Off
Option Explicit On
Friend Class frmComparaRoteiroV2
	Inherits System.Windows.Forms.Form
	Dim aOrigem(6) As Object
	Dim MouseX As Short
	Dim MouseY As Short
	Dim bGuia As Boolean
	Dim bPermissaoBaixa As Boolean
	
    Private Sub Configura_GridCorte()
        On Error GoTo Erro
        With flxCorte
            .Clear()
            .RowHeightMin = 285
            .Rows = 1
            .Redraw = False
            .FixedCols = 0
            .AllowBigSelection = False
            .ScrollTrack = True
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .FormatString = "Contrato|Comercial|Dur.|Fita|Prog|Br"
            .set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)
            .set_ColWidth(0, 1365)
            .set_ColWidth(1, 2505)
            .set_ColWidth(2, 390)
            .set_ColWidth(3, 750)
            .set_ColWidth(4, 750)
            .set_ColWidth(5, 315)
        End With
Saida:
        flxCorte.Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub MostrarGuia()
		On Error GoTo Erro
		
		'Select Case tbOpcoes.Buttons("GUIA").MixedState
		Select Case bGuia
			Case True
				treBreak.Visible = False
                tbGuia.ImageIndex = 6
                tbGuia.ToolTipText = "Mostrar Guia"
                bGuia = False
                flxBreak.Left = treBreak.Left
                Call frmComparaRoteiroV2_Resize(Me, New System.EventArgs())
            Case False
                treBreak.Visible = True
                tbGuia.ToolTipText = "Ocultar Guia"
                tbguia.ImageIndex = 5
                flxBreak.Left = VB6.TwipsToPixelsX(1890)
                bGuia = True
                Call frmComparaRoteiroV2_Resize(Me, New System.EventArgs())
        End Select
Saida: 
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
    End Sub

	
    Private Sub MostraRoteiroOrdenado()


        On Error GoTo Erro
        Dim nForecolor As System.Drawing.Color
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Carregando Roteiro")
        Dim nSequencia As Short
        Dim sTipoIntervalo As String = ""
        Dim sMensagemcorte As String
        Dim sCodPrograma_Anterior As String
        Dim nRow As Short
        Dim nRoot As Integer


        Dim asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro = NewRoteiro()
        Dim dtsRoteiro As New MSAClass.AsmxRoteiro.dtsRoteiro
        dtsRoteiro = asmxRoteiro.spuCarregar_Roteiro(txtVeiculo.Text, DateTime.Parse(txtData.Text), txtPrograma.Text, 0, 0)

        nLin = 0
        sCodPrograma_Anterior = ""
        Call ConfiguraGridBreak()
        Call Configura_GridCorte()
        With flxBreak
            .Redraw = False
            For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Rows
                If drw.Indica_Corte = 1 Then
                    With flxCorte
                        .Rows = .Rows + 1
                        .set_TextMatrix(.Rows - 1, 0, drw.Cod_Empresa & "-" & drw.Numero_MR & "-" & drw.Sequencia_Mr)
                        .set_TextMatrix(.Rows - 1, 1, drw.Cod_Comercial.Trim & "-" & FirstCaps(drw.Titulo_Comercial))
                        .set_TextMatrix(.Rows - 1, 2, drw.Duracao)
                        .set_TextMatrix(.Rows - 1, 3, drw.Numero_Fita)
                        .set_TextMatrix(.Rows - 1, 4, drw.Cod_Programa)
                        .set_TextMatrix(.Rows - 1, 5, drw.Breaks)
                    End With
                    picCorte.Tag = 1
                    GoTo Proximo
                End If
                nLin = nLin + 1
                Mensagem("Carregando " & nLin)
                If nLin >= .Rows - 1 Then
                    .Rows = .Rows + 1
                End If
                nForecolor = System.Drawing.Color.Black

                .set_TextMatrix(nLin, fColuna(flxBreak, "Codigo Programa"), drw.Cod_Programa)

                '================Quebra do Programa, adiciona treeview
                If drw.Cod_Programa <> sCodPrograma_Anterior Then
                    sCodPrograma_Anterior = drw.Cod_Programa
                    With treBreak
                        .Nodes.Add(drw.Cod_Programa, drw.Cod_Programa)
                    End With
                    sCodPrograma_Anterior = drw.Cod_Programa
                    .AddItem("", nLin)
                    .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree
                    .Row = nLin

                    For nCont = 0 To .Cols - 1
                        .set_TextMatrix(nLin, nCont, Trim(drw.Cod_Programa) & "-" & Trim(drw.Titulo_Programa))
                        .Col = nCont
                        .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                        .CellFontBold = True
                        .CellBackColor = System.Drawing.Color.Yellow
                        .CellForeColor = System.Drawing.Color.Black
                    Next nCont
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Guia"), drw.Cod_Programa)
                    .set_MergeRow(nLin, True)


                    nLin = nLin + 1
                End If

                If drw.Indica_Titulo_Break = 1 Then ' Linha de Titulo do Break
                    If drw.IsSequencia_BreakNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), "Break")
                    Else
                        .set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), "Break" & drw.Sequencia_Break)
                    End If

                    Call CorGrid(flxBreak, nLin, Color.Silver, 0)

                    .set_TextMatrix(nLin, fColuna(flxBreak, "Dur."), drw.Duracao)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Break"), drw.Breaks)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica Titulo Break"), drw.Indica_Titulo_Break)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica se Permite Ordenacao"), drw.Indica_Ordenacao)
                    nSequencia = 0

                    With treBreak
                        If drw.Breaks = 0 Then
                            .Nodes(drw.Cod_Programa).Nodes.Add(drw.Cod_Programa + "Inter PGM", "Inter Pgm")
                            flxBreak.set_TextMatrix(nLin, fColuna(flxBreak, "Guia"), drw.Cod_Programa + "Inter PGM")
                            flxBreak.set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), Trim(drw.Cod_Programa) & "------>Inter Programa")
                        Else
                            If Not drw.IsSequencia_BreakNull Then
                                flxBreak.set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), drw.Cod_Programa.Trim & "------>Break" & drw.Sequencia_Break)
                            Else
                                flxBreak.set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), drw.Cod_Programa.Trim & "------>Break")
                            End If
                            .Nodes(drw.Cod_Programa).Nodes.Add(drw.Cod_Programa + StrZero(drw.Breaks, 2), "Break " & StrZero(drw.Breaks, 2))
                            'flxBreak.set_TextMatrix(nLin, fColuna(flxBreak, "Guia"), drw.Cod_Programa + "Break " & StrZero(drw.Breaks, 2))
                            flxBreak.set_TextMatrix(nLin, fColuna(flxBreak, "Guia"), drw.Cod_Programa & StrZero(drw.Breaks, 2))
                        End If
                    End With

                    .Row = nLin
                    .Col = fColuna(flxBreak, "Comercial")
                    .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter

                ElseIf drw.Indica_Titulo_Intervalo = 1 Then  ' Titulo do Intervalo
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), drw.Titulo_Intervalo.Trim)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Dur."), drw.Duracao)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Break"), drw.Breaks)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Tipo Intervalo"), drw.Tipo_Break)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica Titulo do Intervalo"), drw.Indica_Titulo_Intervalo)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica se Permite Ordenacao"), drw.Indica_Ordenacao)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Sequencia Faixa"), drw.Sequencia_Faixa)
                    sTipoIntervalo = drw.Tipo_Break
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Tipo Int. do Comercial"), sTipoIntervalo)
                    .Row = nLin
                    .Col = 1
                    .CellFontBold = True
                Else
                    nSequencia = nSequencia + 1
                    If drw.Descricao_Produto.Trim <> "" Then
                        .set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), FirstCaps(Trim(drw.Descricao_Produto)) & " / " & FirstCaps(Trim(drw.Titulo_Comercial)))
                    Else
                        .set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), FirstCaps(Trim(drw.Titulo_Comercial)))
                    End If

                    If Trim(txtVeiculo.Text) = "001" Or Trim(txtVeiculo.Text) = "004" Or Trim(txtVeiculo.Text) = "076" Then
                        .set_TextMatrix(nLin, fColuna(flxBreak, "Comercial"), UCase(.get_TextMatrix(nLin, fColuna(flxBreak, "Comercial"))))
                    End If

                    .set_TextMatrix(nLin, fColuna(flxBreak, "Dur."), drw.Duracao)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Fita"), drw.Numero_Fita)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Empresa"), drw.Cod_Empresa)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Contrato"), drw.Numero_MR)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Seq"), drw.Sequencia_Mr)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Com."), drw.Cod_Comercial)
                    If Not drw.IsRazao_SocialNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak, "Razao Social"), drw.Razao_Social)
                    End If
                    If Not drw.IsCod_ProdutoNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak, "Produto"), drw.Cod_Produto)
                    End If
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Ch.Acesso"), drw.Chave_Acesso)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Veiculo Origem"), drw.Cod_Veiculo_Origem)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Programa Origem"), drw.Cod_Programa_Origem)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Obs. Roteiro"), drw.Obs_Roteiro)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "A Determinar"), drw.Indica_Titulo_Determinar)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Break"), drw.Breaks)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica Titulo Break"), "0")
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica Titulo do Intervalo"), "0")

                    ' Pasta Origem
                    If drw.Indica_Midia = 1 Then
                        If drw.Indica_Rotativo = 1 Then
                            .set_TextMatrix(nLin, fColuna(flxBreak, "Pasta Origem da Ordenacao"), "2")
                        ElseIf Trim(drw.Cod_Programa_Origem) = drw.Cod_Programa Then
                            .set_TextMatrix(nLin, fColuna(flxBreak, "Pasta Origem da Ordenacao"), "1")
                        Else
                            .set_TextMatrix(nLin, fColuna(flxBreak, "Pasta Origem da Ordenacao"), "5")
                        End If
                    Else
                        If drw.Indica_Avulso = 1 Then
                            .set_TextMatrix(nLin, fColuna(flxBreak, "Pasta Origem da Ordenacao"), "3")
                        Else
                            .set_TextMatrix(nLin, fColuna(flxBreak, "Pasta Origem da Ordenacao"), "4")
                        End If
                    End If

                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica se Permite Ordenacao"), drw.Indica_Ordenacao)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica Grade"), drw.Indica_Grade)
                    If Not drw.IsHorario_RestricaoNull Then .set_TextMatrix(nLin, fColuna(flxBreak, "Horario Restricao"), drw.Horario_Restricao)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Indica Salvo"), "1")
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Sequencia Faixa"), drw.Sequencia_Faixa)
                    If Not drw.IsID_FitaNull Then .set_TextMatrix(nLin, fColuna(flxBreak, "Id Chave"), drw.ID_Fita)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Versao"), drw.Versao)

                    'If ADORs!Breaks = 0 Then
                    '   sTipoIntervalo = ADORs!tipo_break, 0)
                    'End If

                    .set_TextMatrix(nLin, fColuna(flxBreak, "Tipo Intervalo"), sTipoIntervalo)
                    .set_TextMatrix(nLin, fColuna(flxBreak, "Tipo Int. do Comercial"), drw.Tipo_Break)

                    If drw.Indica_Estouro = 1 Then
                        If Not drw.IsPesoNull Then .set_TextMatrix(nLin, fColuna(flxBreak, "Peso"), drw.Peso & "-" + "TQP")
                    Else
                        If Not drw.IsPesoNull Then .set_TextMatrix(nLin, fColuna(flxBreak, "Peso"), drw.Peso)
                    End If

                    'If Trim(sTipoIntervalo) <> "" Then
                    '   .TextMatrix(nLin, fColuna(flxbreak, "Tipo Int. do Comercial")) = sTipoIntervalo
                    'Else
                    '   .TextMatrix(nLin, fColuna(flxbreak, "Tipo Int. do Comercial")) = ADORs!tipo_break, "")
                    'End If

                    '  Origem da Ordenacao
                    .Row = nLin
                    .Col = 3
                    .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
                    .CellFontBold = True
                    .CellFontSize = 8



                    .set_TextMatrix(nLin, fColuna(flxBreak, "Enc."), aOrigem(Val(.get_TextMatrix(nLin, fColuna(flxBreak, "Pasta Origem da Ordenacao")))))
                    .set_TextMatrix(nLin, fColuna(flxBreak, ""), nSequencia)


                End If
                '============================Verifica o Tipo de Break para Colocar a Cor
                If .get_TextMatrix(nLin, fColuna(flxBreak, "Indica Titulo Break")) <> "1" Then
                    Select Case .get_TextMatrix(nLin, fColuna(flxBreak, "Tipo Int. do Comercial"))
                        Case "0" ' Local ou PE
                            nForecolor = Color.Blue
                        Case "1" ' Net
                            nForecolor = Color.Magenta
                        Case "2"
                            nForecolor = Color.Green
                        Case "3"
                            nForecolor = Color.Red
                        Case Else
                            nForecolor = Color.Black
                    End Select
                    '==============================Se for PE, fica sempre em vermelho e não se fala mais nisso
                    If Not drw.IsTipo_FitaNull Then
                        If drw.Tipo_Fita = 1 Then
                            nForecolor = Color.Red
                        End If
                    End If
                    '==============================Se for Intervalo Net em uma Afialida , fica cor de rosa e tambem não se fala mais nisso
                    If sTipoIntervalo = "1" And Trim(txtVeiculo.Text) <> "004" And Trim(txtVeiculo.Text) <> "001" And Trim(txtVeiculo.Text) <> "076" Then
                        nForecolor = Color.Magenta
                    End If
                    Call CorGrid(flxBreak, nLin, nForecolor, 1)
                End If
                '============================Cor do Status
                If .get_TextMatrix(nLin, fColuna(flxBreak, "Indica Titulo Break")) = "1" Or .get_TextMatrix(nLin, fColuna(flxBreak, "Indica Titulo do Intervalo")) = "1" Then
                    Call CorStatus(nLin)
                End If
Proximo:
            Next

            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo Break")) = "1" Then
                    Call SomaBreak(nRow, 0)
                End If
                If .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo do Intervalo")) = "1" Then
                    Call SomaIntervalo(nRow, 0)
                End If
            Next nRow


            .Redraw = True
            .Row = 1
            .TopRow = 1
            .LeftCol = 0
        End With

        If Val(picCorte.Tag) = 1 Then
            If flxCorte.Rows < 11 Then flxCorte.Rows = 11
            picCorte.Visible = True
        End If
        treBreak.ExpandAll()

Saida:


        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        treBreak.Visible = True
        flxBreak.Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub ConfiguraGridBreak()
        On Error GoTo Erro

        aOrigem(1) = "Co" '  Comercial Normal
        aOrigem(2) = "Rt" '  Rotativo
        aOrigem(3) = "Av" '  Avulso
        aOrigem(4) = "Ar" '  Artistico
        aOrigem(5) = "Op" '  Outros Programa
        aOrigem(6) = "Ar" '  Artisticos não replicados



        With flxBreak
            .Clear()
            .Redraw = False
            .Rows = 2
            .Cols = 41
            .FixedCols = 0
            .AllowBigSelection = False
            .ScrollTrack = True
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)
            .HighLight = MSFlexGridLib.HighLightSettings.flexHighlightNever
            .FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusHeavy

            .SelectionMode = MSFlexGridLib.SelectionModeSettings.flexSelectionFree
            .AllowBigSelection = False
            .WordWrap = True
            .RowHeightMin = 285
            .FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusHeavy
            .set_TextMatrix(0, 0, "")
            .set_TextMatrix(0, 1, "Comercial")
            .set_TextMatrix(0, 2, "Dur.")
            .set_TextMatrix(0, 3, "Enc.")
            .set_TextMatrix(0, 4, "Peso")
            .set_TextMatrix(0, 5, "Fita")
            .set_TextMatrix(0, 6, "Com.")
            .set_TextMatrix(0, 7, "Empresa")
            .set_TextMatrix(0, 8, "Contrato")
            .set_TextMatrix(0, 9, "Seq")
            .set_TextMatrix(0, 10, "Razao Social")
            .set_TextMatrix(0, 11, "Produto")
            .set_TextMatrix(0, 12, "Ch.Acesso")
            .set_TextMatrix(0, 13, "Veiculo Origem ")
            .set_TextMatrix(0, 14, "Programa Origem")
            .set_TextMatrix(0, 15, "Obs. Roteiro")
            .set_TextMatrix(0, 16, "A Determinar")
            .set_TextMatrix(0, 17, "Break ")
            .set_TextMatrix(0, 18, "Tipo Intervalo")
            .set_TextMatrix(0, 19, "Indica Titulo Break")
            .set_TextMatrix(0, 20, "Indica Titulo do Intervalo")
            .set_TextMatrix(0, 21, "Pasta Origem da Ordenacao")
            .set_TextMatrix(0, 22, "Indica se Permite Ordenacao ")
            .set_TextMatrix(0, 23, "Indica Grade")
            .set_TextMatrix(0, 24, "Horario Restricao")
            .set_TextMatrix(0, 25, "Indica Salvo") ' se for = 1 Indica que foi carregado do roteiro( nao foi arrastado nesta ordenacao)
            .set_TextMatrix(0, 26, "Sequencia Faixa")
            .set_TextMatrix(0, 27, "Id Chave") '
            .set_TextMatrix(0, 28, "Versao")
            .set_TextMatrix(0, 29, "Tipo Int. do Comercial")
            .set_TextMatrix(0, 30, "Tipo do Break da Fita")
            .set_TextMatrix(0, 31, "Guia")
            .set_TextMatrix(0, 32, "Cod.Programa")
            .set_TextMatrix(0, 0, "..")
            .set_TextMatrix(0, 1, "")
            .set_TextMatrix(0, 2, "Comercial")
            .set_TextMatrix(0, 3, "Dur.")
            .set_TextMatrix(0, 4, "Enc.")
            .set_TextMatrix(0, 5, "Fita")
            .set_TextMatrix(0, 6, "Peso")
            .set_TextMatrix(0, 7, "Com.")
            .set_TextMatrix(0, 8, "Empresa")
            .set_TextMatrix(0, 9, "Contrato")
            .set_TextMatrix(0, 10, "Seq")
            .set_TextMatrix(0, 11, "Razao Social")
            .set_TextMatrix(0, 12, "Produto")
            .set_TextMatrix(0, 13, "Ch.Acesso")
            .set_TextMatrix(0, 14, "Veiculo Origem ")
            .set_TextMatrix(0, 15, "Programa Origem")
            .set_TextMatrix(0, 16, "Obs. Roteiro")
            .set_TextMatrix(0, 17, "A Determinar")
            .set_TextMatrix(0, 18, "Break ")
            .set_TextMatrix(0, 19, "Tipo Intervalo")
            .set_TextMatrix(0, 20, "Indica Titulo Break")
            .set_TextMatrix(0, 21, "Indica Titulo do Intervalo")
            .set_TextMatrix(0, 22, "Pasta Origem da Ordenacao")
            .set_TextMatrix(0, 23, "Indica se Permite Ordenacao ")
            .set_TextMatrix(0, 24, "Indica Grade")
            .set_TextMatrix(0, 25, "Horario Restricao")
            .set_TextMatrix(0, 26, "Indica Salvo") ' se for = 1 Indica que foi carregado do roteiro( nao foi arrastado nesta ordenacao)
            .set_TextMatrix(0, 27, "Sequencia Faixa")
            .set_TextMatrix(0, 28, "Id Chave") '
            .set_TextMatrix(0, 29, "Versao")
            .set_TextMatrix(0, 30, "Tipo Int. do Comercial")
            .set_TextMatrix(0, 31, "Tipo do Break da Fita")
            .set_TextMatrix(0, 32, "Codigo Programa")
            .set_TextMatrix(0, 33, "Guia")
            .set_TextMatrix(0, 34, "Indica_Titulo_Programa")
            .set_TextMatrix(0, 35, "Horario Inicio")
            .set_TextMatrix(0, 36, "Horario Fim")
            .set_TextMatrix(0, 37, "Horario Inicio Comercial Rotativo")
            .set_TextMatrix(0, 38, "Horario Fim Comercial Rotativo")
            .set_TextMatrix(0, 39, "Indica_Espaco_Cedido")
            .set_TextMatrix(0, 40, "Hora_Programa")
            .set_TextMatrix(0, 40, "Setor")


            .set_ColWidth(fColuna(flxBreak, ".."), 0)
            .set_ColWidth(fColuna(flxBreak, ""), 300)
            .set_ColWidth(fColuna(flxBreak, "Comercial"), 3495)
            .set_ColWidth(fColuna(flxBreak, "Dur."), 435)
            .set_ColWidth(fColuna(flxBreak, "Enc."), 435)
            .set_ColWidth(fColuna(flxBreak, "Fita"), 765)
            .set_ColWidth(fColuna(flxBreak, "Peso"), 0)
            .set_ColWidth(fColuna(flxBreak, "Com."), 435)
            .set_ColWidth(fColuna(flxBreak, "Empresa"), 705)
            .set_ColWidth(fColuna(flxBreak, "Contrato"), 1005)
            .set_ColWidth(fColuna(flxBreak, "Seq"), 495)
            .set_ColWidth(fColuna(flxBreak, "Razao Social"), 0)
            .set_ColWidth(fColuna(flxBreak, "Produto"), 0)
            .set_ColWidth(fColuna(flxBreak, "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxBreak, "Veiculo Origem "), 0)
            .set_ColWidth(fColuna(flxBreak, "Programa Origem"), 1320)
            .set_ColWidth(fColuna(flxBreak, "Obs. Roteiro"), 0)
            .set_ColWidth(fColuna(flxBreak, "A Determinar"), 0)
            .set_ColWidth(fColuna(flxBreak, "Break "), 0)
            .set_ColWidth(fColuna(flxBreak, "Tipo Intervalo"), 0)
            .set_ColWidth(fColuna(flxBreak, "Indica Titulo Break"), 0)
            .set_ColWidth(fColuna(flxBreak, "Indica Titulo do Intervalo"), 0)
            .set_ColWidth(fColuna(flxBreak, "Pasta Origem da Ordenacao"), 0)
            .set_ColWidth(fColuna(flxBreak, "Indica se Permite Ordenacao "), 0)
            .set_ColWidth(fColuna(flxBreak, "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxBreak, "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxBreak, "Indica Salvo"), 0)
            .set_ColWidth(fColuna(flxBreak, "Sequencia Faixa"), 0)
            .set_ColWidth(fColuna(flxBreak, "Id Chave"), 0)
            .set_ColWidth(fColuna(flxBreak, "Versao"), 0)
            .set_ColWidth(fColuna(flxBreak, "Tipo Int. do Comercial"), 0)
            .set_ColWidth(fColuna(flxBreak, "Tipo do Break da Fita"), 0)
            .set_ColWidth(fColuna(flxBreak, "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxBreak, "Guia"), 0)
            .set_ColWidth(fColuna(flxBreak, "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxBreak, "Horario Inicio"), 0)
            .set_ColWidth(fColuna(flxBreak, "Horario Fim"), 0)
            .set_ColWidth(fColuna(flxBreak, "Horario Inicio Comercial Rotativo"), 0)
            .set_ColWidth(fColuna(flxBreak, "Horario Fim Comercial Rotativo"), 0)
            .set_ColWidth(fColuna(flxBreak, "Indica_Espaco_Cedido"), 0)
            .set_ColWidth(fColuna(flxBreak, "Setor"), 0)


            '  O valor do Coldata reprenta o Numero da Coluna do Grid de Break onde
            '   sera guardado quando efetuar o DragDrop

            .set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
            .Row = 1
            .Col = 0
            .TopRow = 1
            .LeftCol = 0
            .Redraw = True
        End With
        treBreak.Nodes.Clear()


Saida:
        flxBreak.Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub CorGrid(ByRef fGrid As AxMSFlexGridLib.AxMSFlexGrid, ByVal Par_Row As Short, ByVal Par_Cor As System.Drawing.Color, ByVal Par_Tipo As Byte)
        On Error GoTo Erro
        Dim nCol As Short
        With fGrid

            .Row = Par_Row
            For nCol = 0 To .Cols - 1
                .Col = nCol
                If Par_Tipo = 0 Then
                    .CellBackColor = Par_Cor
                Else
                    .CellForeColor = Par_Cor
                End If
            Next nCol
        End With

Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub Moverlinhas(ByRef Par_direcao As Short)

        On Error GoTo Erro
        Dim fForm As frmComparaRoteiroV2

        Select Case Par_direcao
            Case 2 ' Paracima
                For Each f As Form In mdiPrincipal.MdiChildren
                    If f.Name = Me.Name Then
                        fForm = f
                        With fForm.flxBreak
                            If .TopRow > 1 Then
                                .TopRow = .TopRow - 1
                            End If
                        End With
                    End If
                Next
            Case 1
                For Each f As Form In mdiPrincipal.MdiChildren
                    If f.Name = Me.Name Then
                        fForm = f

                        With fForm.flxBreak
                            If .TopRow < .Rows - 1 Then
                                .TopRow = .TopRow + 1
                            Else
                                .TopRow = .Rows - 1
                            End If
                        End With
                    End If
                Next

            Case 3
                For Each f As Form In mdiPrincipal.MdiChildren
                    If f.Name = Me.Name Then
                        fForm = f

                        With fForm.flxBreak
                            .TopRow = 1
                        End With
                    End If
                Next
            Case 4

                For Each f As Form In mdiPrincipal.MdiChildren
                    If f.Name = Me.Name Then
                        fForm = f

                        With fForm.flxBreak
                            .TopRow = .Rows - 1
                        End With
                    End If
                Next
        End Select

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub

    Private Sub NumeraLinha(ByRef Par_Break As Short)
        On Error GoTo Erro
        Dim nPrimeiraLinha As Short
        Dim nUltimaLinha As Short
        Dim nRow As Short
        Dim nContador As Short

        With flxBreak

            For nRow = 1 To .Rows - 1

                If Val(.get_TextMatrix(nRow, fColuna(flxBreak, "Break"))) = Par_Break And .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo Break")) = "1" Then
                    nPrimeiraLinha = nRow
                End If

                If Val(.get_TextMatrix(nRow, fColuna(flxBreak, "Break"))) > Par_Break Or (Trim(.get_TextMatrix(nRow, (fColuna(flxBreak, "Comercial"))) = "" And Trim(.get_TextMatrix(nRow, fColuna(flxBreak, "dur."))) = "" And Trim(.get_TextMatrix(nRow, fColuna(flxBreak, "enc."))) = "")) Then
                    nUltimaLinha = nRow - 1
                    Exit For
                End If
            Next nRow

            For nRow = nPrimeiraLinha To nUltimaLinha
                If .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo Break")) <> "1" And .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo do Intervalo")) <> "1" Then
                    nContador = nContador + 1
                    .set_TextMatrix(nRow, fColuna(flxBreak, ""), nContador)
                End If
            Next
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    'UPGRADE_WARNING: Event chkMostrarRoteiro.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkMostrarRoteiro_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMostrarRoteiro.CheckStateChanged
        Call MostraRoteiroOrdenado()
    End Sub

    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Dim Index As Short = cmdCancela.GetIndex(eventSender)
        picCorte.Visible = False
    End Sub

    Private Sub MostraDadosComercial()
        On Error GoTo Erro
        Dim nPasta As Short
        With flxBreak
            nPasta = Val(.get_TextMatrix(.Row, fColuna(flxBreak, "Pasta Origem da Ordenacao"))) '  Indica de que pasta veio a ordenacao
            If nPasta = 0 Then
                GoTo Saida
            End If


            If Trim(.get_TextMatrix(.Row, fColuna(flxBreak, "Veiculo Origem"))) <> "" Then
                frmRoteiroDados.txtVeiculo.Text = .get_TextMatrix(.Row, fColuna(flxBreak, "Veiculo Origem")) '  Veiculo Origem da Fita
            Else
                frmRoteiroDados.txtVeiculo.Text = txtVeiculo.Text
            End If

            Select Case nPasta
                Case 1, 2, 5 ' Comercial, Rotativo , Outros Programas
                    frmRoteiroDados.txtData.Text = txtData.Text
                    frmRoteiroDados.txtPrograma.Text = .get_TextMatrix(.Row, fColuna(flxBreak, "Programa Origem"))
                    frmRoteiroDados.txtChaveAcesso.Text = .get_TextMatrix(.Row, fColuna(flxBreak, "Ch.Acesso"))
                    frmRoteiroDados.txtNumeroFita.Text = Trim(.get_TextMatrix(.Row, fColuna(flxBreak, "Fita")))
                    If Not bUsuario_Net Then
                        'frmRoteiroDados.chkAlterarNumero.Value = 1
                    End If
                    frmRoteiroDados.chkMidia.Checked = True
                    frmRoteiroDados.ShowDialog()
                    If frmRoteiroDados.chkOk.Checked Then
                        .set_TextMatrix(.Row, fColuna(flxBreak, "Fita"), frmRoteiroDados.txtNumeroFita.Text)
                    End If
                Case 3 ' Depositorio Avulso
                    frmRoteiroDados.txtNumeroFita.Text = Trim(.get_TextMatrix(.Row, fColuna(flxBreak, "Fita")))
                    frmRoteiroDados.chkAvulso.Checked = True
                    frmRoteiroDados.cmdOk.Enabled = False
                    frmRoteiroDados.ShowDialog()
                Case 4 ' Depositorio Artistico
                    frmRoteiroDados.txtNumeroFita.Text = Trim(.get_TextMatrix(.Row, fColuna(flxBreak, "Fita")))
                    frmRoteiroDados.chkArtistico.Checked = True
                    frmRoteiroDados.cmdOk.Enabled = False
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


    Private Sub CorStatus(ByRef Par_Linha As Short)

        On Error GoTo Erro
        Dim nBackcolor As Drawing.Color

        With flxBreak

            If Par_Linha = 0 Then
                GoTo Saida
            End If

            'If .TextMatrix(Par_Linha, fColuna(flxBreak, "Break")) = "0" Then ' Inter nao precisa Status
            '   GoTo Saida
            'End If

            If .get_TextMatrix(Par_Linha, fColuna(flxBreak, "Indica Titulo Break")) = "1" Then ' Linha do Break
                nBackcolor = Color.Silver

            Else
                nBackcolor = Color.White
            End If

            .Redraw = False
            '  Verifica se preencheu todo o espaco
            .Row = Par_Linha
            .Col = 0
            .CellFontName = "Wingdings"
            .CellFontSize = 14

            If Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak, "Dur."))) = Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak, "Enc."))) Then
                '.CellBackColor = nBackcolor
                .CellBackColor = .CellForeColor
                If .get_TextMatrix(Par_Linha, fColuna(flxBreak, "Indica Titulo Break")) = "1" Then
                    .CellBackColor = System.Drawing.Color.White
                    .CellForeColor = System.Drawing.Color.Blue
                    .set_TextMatrix(Par_Linha, fColuna(flxBreak, ""), Chr(252))
                End If

            ElseIf Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak, "Enc."))) > Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak, "Dur."))) Then
                .CellBackColor = System.Drawing.Color.Red
                '.CellForeColor = vbBlack
                .set_TextMatrix(Par_Linha, fColuna(flxBreak, ""), "")
            Else
                .CellBackColor = nBackcolor
                '.CellForeColor = vbBlue
                '.TextMatrix(Par_Linha, fColuna(flxBreak, "")) = Chr(240)
                .set_TextMatrix(Par_Linha, fColuna(flxBreak, ""), "")
            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmComparaRoteiroV2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Dim fff As frmComparaRoteiroV2
        For Each f As Form In mdiPrincipal.MdiChildren
            If f.Name = Me.Name Then
                fff = f
                Debug.Print(f.Location.ToString)
                Debug.Print(f.Size.ToString)
            End If
        Next

    End Sub

    Private Sub frmComparaRoteiroV2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{tab}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub SomaBreak(ByRef Par_Linha As Short, ByRef Index As Short)
        On Error GoTo Erro
        Dim nRow As Short
        Dim nTotal As Short

        With flxBreak
            For nRow = Par_Linha + 1 To .Rows - 1
                If .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo Break")) = "1" Then
                    Exit For
                End If
                If .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo do Intervalo")) <> "1" Then
                    nTotal = nTotal + Val(.get_TextMatrix(nRow, fColuna(flxBreak, "Dur.")))
                End If
            Next nRow
            .set_TextMatrix(Par_Linha, fColuna(flxBreak, "Enc."), nTotal)
        End With
        Call CorStatus(Par_Linha)

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Private Sub ConfiguraGridTempoBreak()

        On Error GoTo Erro

        With frmTempoBreakV2.flxTempoBreak
            .Clear()
            .Rows = 30
            .Cols = 1
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeNone
            .FormatString = "<Programa|Break|Intervalo|Chave|Tipo Intervalo"
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .set_ColWidth(fColuna(frmTempoBreakV2.flxTempoBreak, "programa"), 915)
            .set_ColWidth(fColuna(frmTempoBreakV2.flxTempoBreak, "Break"), 510)
            .set_ColWidth(fColuna(frmTempoBreakV2.flxTempoBreak, "Intervalo"), 1590)
            .set_ColWidth(fColuna(frmTempoBreakV2.flxTempoBreak, "chave"), 0)
            .set_ColWidth(fColuna(frmTempoBreakV2.flxTempoBreak, "Tipo Intervalo"), 0)
        End With

Saida:

        Exit Sub

Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub SomaIntervalo(ByVal Par_Linha As Short, ByVal Index As Short)
        On Error GoTo Erro
        Dim nRow As Short
        Dim nTotal As Short

        '.TextMatrix(0, 0) = ""
        '.TextMatrix(0, 1) = "Comercial"
        '.TextMatrix(0, 2) = "Dur."
        '.TextMatrix(0, 3) = "Enc."
        '.TextMatrix(0, 4) = "Peso"
        '.TextMatrix(0, 5) = "Fita"
        '.TextMatrix(0, 6) = "Com."
        '.TextMatrix(0, 7) = "Empresa"
        '.TextMatrix(0, 8) = "Contrato"
        '.TextMatrix(0, 9) = "Seq"
        '.TextMatrix(0, 10) = "Razao Social"
        '.TextMatrix(0, 11) = "Produto"
        '.TextMatrix(0, 12) = "Ch.Acesso"
        '.TextMatrix(0, 13) = "Veiculo Origem "
        '.TextMatrix(0, 14) = "Programa Origem"
        '.TextMatrix(0, 15) = "Obs. Roteiro"
        '.TextMatrix(0, 16) = "A Determinar"
        '.TextMatrix(0, 17) = "Break "
        '.TextMatrix(0, 18) = "Tipo Intervalo"
        '.TextMatrix(0, 19) = "Indica Titulo Break"
        '.TextMatrix(0, 20) = "Indica Titulo do Intervalo"
        '.TextMatrix(0, 21) = "Pasta Origem da Ordenacao"
        '.TextMatrix(0, 22) = "Indica se Permite Ordenacao "
        '.TextMatrix(0, 23) = "Indica Grade"
        '.TextMatrix(0, 24) = "Horario Restricao"
        '.TextMatrix(0, 25) = "Indica Salvo"  ' se for = 1 Indica que foi carregado do roteiro( nao foi arrastado nesta ordenacao)
        '.TextMatrix(0, 26) = "Sequencia Faixa"
        '.TextMatrix(0, 27) = "Id Chave"  '
        '.TextMatrix(0, 28) = "Versao"
        '.TextMatrix(0, 29) = "Tipo Int. do Comercial"
        '.TextMatrix(0, 30) = "Tipo do Break da Fita"


        With flxBreak
            sSql = .get_TextMatrix(Par_Linha, fColuna(flxBreak, "Tipo Intervalo")).ToString
            If .get_TextMatrix(Par_Linha, fColuna(flxBreak, "Tipo Intervalo")) <> "2" Then '  Diferente de artisticos
                For nRow = Par_Linha + 1 To .Rows - 1
                    If .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo Break")) = "1" Or .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo do Intervalo")) = "1" Then
                        Exit For
                    End If
                    If .get_TextMatrix(nRow, fColuna(flxBreak, "Pasta Origem da Ordenacao")) <> "4" Then
                        nTotal = nTotal + Val(.get_TextMatrix(nRow, fColuna(flxBreak, "Dur.")))
                    End If
                Next nRow
                .set_TextMatrix(Par_Linha, fColuna(flxBreak, "Enc."), nTotal)

            Else
                For nRow = Par_Linha + 1 To .Rows - 1
                    sSql = .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo Break"))
                    If .get_TextMatrix(nRow, fColuna(flxBreak, "Indica Titulo Break")) = "1" Then
                        Exit For
                    End If
                    sSql = .get_TextMatrix(nRow, fColuna(flxBreak, "Pasta Origem da Ordenacao"))
                    If .get_TextMatrix(nRow, fColuna(flxBreak, "Pasta Origem da Ordenacao")) = "4" Then
                        nTotal = nTotal + Val(.get_TextMatrix(nRow, fColuna(flxBreak, "Dur.")))
                    End If
                Next nRow
                .set_TextMatrix(Par_Linha, fColuna(flxBreak, "Enc."), nTotal)
            End If
        End With

        Call CorStatus(Par_Linha)

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmComparaRoteiroV2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        On Error GoTo Erro
        With picCorte
            .Top = VB6.TwipsToPixelsY(180)
            .Left = VB6.TwipsToPixelsX(465)
            .Width = VB6.TwipsToPixelsX(6540)
            .Height = VB6.TwipsToPixelsY(3105)
        End With
        bGuia = True
        picCorte.Top = VB6.TwipsToPixelsY(840)
        picCorte.Left = VB6.TwipsToPixelsX(840)



saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume saida
        Resume
    End Sub

    Private Sub frmComparaRoteiroV2_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        On Error GoTo Erro
        If Me.WindowState <> System.Windows.Forms.FormWindowState.Minimized Then
            With flxBreak
                .Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - 1160)
                .Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) - VB6.PixelsToTwipsX(.Left) - 200)
            End With

            With treBreak
                .Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - 1160)
            End With
        End If
saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume saida
        Resume
    End Sub

    Private Sub frmComparaRoteiroV2_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    End Sub

    Private Sub lblCorte_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblCorte.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = x
        MouseY = y
    End Sub


    Private Sub lblCorte_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblCorte.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        On Error GoTo Erro
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        Dim MaxTop As Short
        Dim MaxLeft As Short

        With picCorte
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



    Private Sub Consistencia()

        On Error GoTo Erro

        Dim nRow As Short
        Dim sTitulo As String
        Dim sChave As String
        Dim nForm As Short
        Dim nCont As Short
        Dim sNomeForm As String
        Dim strVeiculo As String = ""
        Dim bDiferenca As Boolean
        sNomeForm = Me.Name
        Mensagem("Carregando dados......Aguarde!")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        '======================Pega todos os formularios que estão aberto
        'nForm = -1
        'For x As Integer = 1 To strListaVeiculos.Length Step 3
        ' ReDim Preserve aVeiculo(nForm)
        ' aVeiculo.SetValue(Mid(strListaVeiculos, x, 3), nForm)
        ' Next
        '======================Adiciona as colunas no grid de tempo para o veiculo de cada formulario
        Call ConfiguraGridTempoBreak()

        If strListaVeiculos.Trim <> "" Then
            With frmTempoBreakV2.flxTempoBreak
                For nCont = 1 To strListaVeiculos.Length Step 3
                    strVeiculo = Mid(strListaVeiculos, nCont, 3)
                    .Cols = .Cols + 1
                    .set_TextMatrix(0, .Cols - 1, strVeiculo)
                    .set_ColWidth(fColuna(frmTempoBreakV2.flxTempoBreak, strVeiculo), 795)
                Next nCont
                .Cols = .Cols + 1
                .set_TextMatrix(0, .Cols - 1, "Status")
                .set_ColWidth(fColuna(frmTempoBreakV2.flxTempoBreak, "Status"), 615)
                .set_ColAlignment(fColuna(frmTempoBreakV2.flxTempoBreak, "Status"), MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)
            End With
        End If

        '======================Adiciona os totais dos breaks / Intervalos

        frmTempoBreakV2.flxTempoBreak.Rows = 1
        nForm = -1

        Dim fForm As frmComparaRoteiroV2
        For Each f As Form In mdiPrincipal.MdiChildren
            If f.Name = Me.Name Then
                nForm = nForm + 1
                fForm = f
                sTitulo = ""
                With fForm.flxBreak
                    For nRow = 1 To .Rows - 1

                        If .get_TextMatrix(nRow, fColuna(fForm.flxBreak, "Indica Titulo Break")) = "1" Then
                            sTitulo = .get_TextMatrix(nRow, fColuna(fForm.flxBreak, "Codigo Programa"))
                        End If
                        If .get_TextMatrix(nRow, fColuna(fForm.flxBreak, "Indica Titulo do Intervalo")) = "1" Then
                            sChave = .get_TextMatrix(nRow, fColuna(fForm.flxBreak, "Codigo Programa")) & StrZero(Val(.get_TextMatrix(nRow, fColuna(fForm.flxBreak, "Break"))), 3) & StrZero(Val(.get_TextMatrix(nRow, fColuna(fForm.flxBreak, "Tipo Intervalo"))), 3)
                            Call AdicionaGridTempo(fForm.flxBreak, sTitulo, nRow, sChave, fColuna(frmTempoBreakV2.flxTempoBreak, strVeiculo))
                        End If
                    Next nRow
                End With
            End If
        Next
        '==================================================Marca o Status
        With frmTempoBreakV2.flxTempoBreak
            If .Rows < 19 Then .Rows = 19
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictAll
            .set_MergeCol(0, True)
            .set_MergeCol(1, True)
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, 0) = "" Then
                    Exit For
                End If
                bDiferenca = False

                .Row = nRow
                .Col = fColuna(frmTempoBreakV2.flxTempoBreak, "status")
                .CellFontName = "WingDings"
                .CellFontSize = 14


                For nCont = fColuna(frmTempoBreakV2.flxTempoBreak, strVeiculo) + 1 To fColuna(frmTempoBreakV2.flxTempoBreak, strVeiculo)
                    If .get_TextMatrix(nRow, nCont) <> .get_TextMatrix(nRow, nCont - 1) Then
                        bDiferenca = True
                    End If
                Next nCont
                If bDiferenca Then
                    .set_TextMatrix(nRow, fColuna(frmTempoBreakV2.flxTempoBreak, "status"), Chr(251))
                    .CellForeColor = Color.Red
                Else
                    .set_TextMatrix(nRow, fColuna(frmTempoBreakV2.flxTempoBreak, "status"), Chr(252))
                    .CellForeColor = Color.Blue
                End If
            Next nRow
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        frmTempoBreakV2.ShowDialog()

Saida:
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub AdicionaGridTempo(ByRef Par_Flex As AxMSFlexGridLib.AxMSFlexGrid, ByVal Par_Titulo As String, ByVal Par_Linha As Short, ByVal Par_Chave As String, ByVal Par_Coluna As Short)

        On Error GoTo Erro
        Dim nContLinha As Short
        Dim nLinhaBreak As Short
        Dim nColuna As Short
        Dim nForecolor As Drawing.Color
        'Call ConfiguraGridTempoBreak()
        With frmTempoBreakV2.flxTempoBreak
            nLinhaBreak = 0
            '-----------------> Verifica se ja Existe a Chave
            For nContLinha = 1 To .Rows - 1
                If Par_Chave = .get_TextMatrix(nContLinha, fColuna(frmTempoBreakV2.flxTempoBreak, "chave")) Then
                    nLinhaBreak = nContLinha
                    Exit For
                End If
            Next nContLinha

            If nLinhaBreak = 0 Then
                .Rows = .Rows + 1
                nLinhaBreak = .Rows - 1
            End If
            .set_TextMatrix(nLinhaBreak, fColuna(frmTempoBreakV2.flxTempoBreak, "Programa"), Par_Titulo.Trim)
            .set_TextMatrix(nLinhaBreak, fColuna(frmTempoBreakV2.flxTempoBreak, "Break"), Par_Flex.get_TextMatrix(Par_Linha, fColuna(Par_Flex, "BREAK")))
            .set_TextMatrix(nLinhaBreak, fColuna(frmTempoBreakV2.flxTempoBreak, "Intervalo"), FirstCaps(Par_Flex.get_TextMatrix(Par_Linha, fColuna(Par_Flex, "COMERCIAL"))))
            .set_TextMatrix(nLinhaBreak, Par_Coluna, Par_Flex.get_TextMatrix(Par_Linha, fColuna(Par_Flex, "Enc.")))
            .set_TextMatrix(nLinhaBreak, fColuna(frmTempoBreakV2.flxTempoBreak, "Chave"), Par_Chave)
            .set_TextMatrix(nLinhaBreak, fColuna(frmTempoBreakV2.flxTempoBreak, "Tipo Intervalo"), Par_Flex.get_TextMatrix(Par_Linha, fColuna(Par_Flex, "Tipo Intervalo")))

            Select Case Par_Flex.get_TextMatrix(Par_Linha, fColuna(Par_Flex, "Tipo Intervalo"))
                Case "0" ' Local ou PE
                    nForecolor = Color.Blue
                Case "1" ' Net
                    nForecolor = Color.Magenta
                Case "2"
                    nForecolor = Color.Green
                Case "3"
                    nForecolor = Color.Red
                Case Else
                    nForecolor = Color.Black
            End Select

            .Row = nLinhaBreak
            For nColuna = 2 To .Cols - 2
                .Col = nColuna
                .CellForeColor = nForecolor
                .CellFontBold = True
            Next nColuna
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub




    Private Sub treBreak_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treBreak.NodeMouseClick
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node

        On Error GoTo Erro
        Dim nRow As Short

        With flxBreak
            For nRow = 1 To .Rows - 1

                If .get_TextMatrix(nRow, fColuna(flxBreak, "guia")) = Node.Name Then
                    .Row = nRow
                    .Col = 1
                    .TopRow = nRow
                    Exit For
                End If
            Next nRow


        End With



Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Private Sub tbOpcoes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOpcoes.Click
    End Sub

    Private Sub tbOpcoes_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tbOpcoes.ItemClicked
    End Sub

    Private Sub flxBreak_DblClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles flxBreak.DblClick
        MostraDadosComercial()
    End Sub

    Private Sub tbConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConsistencia.Click
        Call Consistencia()
    End Sub

    Private Sub tbGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGuia.Click
        Call MostrarGuia()
    End Sub

    Private Sub tbAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAtualizar.Click
        Call MostraRoteiroOrdenado()
    End Sub

    Private Sub tbData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbData.Click
        For Each fForm As frmComparaRoteiroV2 In mdiPrincipal.MdiChildren
            fForm.Dispose()
        Next

    End Sub

    Private Sub tbPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPrevious.Click
        Call Moverlinhas(1)
    End Sub

    Private Sub tbNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNext.Click
        Call Moverlinhas(2)
    End Sub

    Private Sub tbFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFirst.Click
        Call Moverlinhas(3)
    End Sub

    Private Sub tbLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLast.Click
        Call Moverlinhas(4)
    End Sub

    Private Sub tbSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSair.Click
        For Each fForm As Form In mdiPrincipal.MdiChildren
            If fForm.Name = Me.Name Then
                fForm.Dispose()
            End If
        Next
    End Sub
End Class