Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Drawing

Friend Class frmRoteiroV2
    Inherits System.Windows.Forms.Form
    Dim bPermissaoArtistico As Boolean
    Dim asmxBaixaVeiculacao As MSAClass.AsmxBaixaVeiculacao.asmxBaixaVeiculacao
    Dim dtsBaixaVeiculacao As MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao
    Dim dtsBaixaCritica As MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao
    Dim nLinhaOrigem As Short
    Dim nLinhadestino As Short
    Dim aOrigem(6) As String
    Dim bIndicaMudancaPosicao As Boolean
    Dim bolMostraDiferenciado As Boolean

    Dim DtsRoteiro As New MSAClass.AsmxRoteiro.dtsRoteiro
    Dim dtsRoteiroLog As New MSAClass.AsmxRoteiroLog.dtsRoteiroLog
    Dim dtsPorta As New MSAClass.AsmxPorta.dtsPorta
    Dim dtsParametro_Roteiro As New MSAClass.AsmxParametro_Roteiro.dtsParametro_Roteiro

    Dim asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro
    Dim AsmxRoteiroLog As MSAClass.AsmxRoteiroLog.asmxRoteiroLog
    Dim asmxPorta As MSAClass.AsmxPorta.asmxPorta
    Dim AsmxParametro_Roteiro As MSAClass.AsmxParametro_Roteiro.asmxParametro_Roteiro = NewParametro_Roteiro()

    Dim bGuia As Boolean
    Dim bAfterCheck As Boolean = False
    Dim bPermissaoComercial As Boolean
    Dim bPermissaoBreakDiferente As Boolean
    Dim bOrdenarNet As Boolean
    Dim bPermissaoComposicaoBreak As Boolean
    Dim bPermissaoSemTitulo As Boolean
    Dim nColunaPos As Short
    Dim MouseX As Short
    Dim MouseY As Short
    Dim bCarregaArtistico As Boolean
    Dim bMostraColunaPeso As Boolean
    Dim bDragDrop As Boolean
    Dim flexDrag As AxMSFlexGridLib.AxMSFlexGrid
    Dim nRowDrag As Integer
    Dim MaxBreakX As Integer
    Dim MaxBreakY As Integer
    Dim MaxComercialX As Integer
    Dim MaxComercialY As Integer
    Private Function CarregaGuia() As Boolean
        Dim bPermissaoArtistico As Boolean
        CarregaGuia = True

        On Error GoTo Erro
        Dim nRoot As Integer
        Me.DtsRoteiro = Me.AsmxRoteiro.spuCarregar_Guia(ucVeiculo.Text, UcData.DateTime, "")
        If DtsRoteiro.Tables("dtsroteiro_guia").Rows.Count = 0 Then
            Aviso("Não existe Programação/Breaks nesse dia")
            CarregaGuia = False
            Exit Function
        End If
        Dim nCont As Integer, nLin As Integer

        Dim sFaixaAnterior As Short
        sFaixaAnterior = -1
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        With treBreak
            .Nodes.Clear()
            .BeginUpdate()
            For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtsRoteiro_GuiaRow In Me.DtsRoteiro.dtsRoteiro_Guia.[Select]
                '================Quebra do Faixa Horaria, adiciona Root no treeview
                If sFaixaAnterior <> drw.Faixa_Horaria Then
                    .Nodes.Add(New TreeNode(drw.Nome_Faixa_Horaria.Trim))
                    sFaixaAnterior = drw.Faixa_Horaria
                    nRoot = .Nodes.Count - 1
                End If

                .Nodes(nRoot).Nodes.Add(drw.Cod_Programa).ToString().Trim()
                .Nodes.Item(.Nodes.Count - 1).Tag = 1

            Next

                For nCont = 0 To .Nodes.Count - 1
                    .Nodes(nCont).Expand()
                    .Nodes(nCont).ForeColor = Color.Blue
                    For nLin = 0 To .Nodes(nCont).Nodes.Count - 1
                        .Nodes(nCont).Nodes(nLin).ForeColor = Color.Blue
                    Next
                Next nCont

                .EndUpdate()
        End With
Saida:

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        treBreak.Visible = True
        Exit Function
Erro:
        CarregaGuia = False
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume

    End Function




    Private Sub MostrarGuia()
        On Error GoTo Erro
        Select Case bGuia
            Case True
                treBreak.Visible = False
                cmdCarregar.Visible = False
                cmdMarcarTodos.Visible = False
                tbGuia.Image = Me.ImageList1.Images(10)
                tbGuia.ToolTipText = "Mostrar Guia"
                bGuia = False
                flxBreak(0).Left = treBreak.Left
                Call frmRoteiroV2_Resize(Me, New System.EventArgs())
            Case False
                treBreak.Visible = True
                cmdCarregar.Visible = True
                cmdMarcarTodos.Visible = True
                'tbGuia.Text = "Ocultar Guia"
                tbGuia.ToolTipText = "Ocultar Guia"
                tbGuia.Image = Me.ImageList1.Images(11)
                flxBreak(0).Left = 117
                bGuia = True
                Call frmRoteiroV2_Resize(Me, New System.EventArgs())
        End Select
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub



    Private Sub Configura_GridCorte()
        On Error GoTo Erro
        With flxCorte
            .Clear()
            .RowHeightMin = 285
            .Rows = 1
            .Visible = False
            .FixedCols = 0
            .AllowBigSelection = False
            .ScrollTrack = True
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .FormatString = "Contrato|Comercial|Dur.|Fita|Programa|Break"
            .set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)
            .set_ColWidth(0, 1365)
            .set_ColWidth(1, 2790)
            .set_ColWidth(2, 525)
            .set_ColWidth(3, 945)
            .set_ColWidth(4, 945)
            .set_ColWidth(5, 675)
        End With
Saida:
        flxCorte.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub Configura_GridStatus()
        On Error GoTo Erro
        With flxStatus
            .Clear()
            .RowHeightMin = 285
            .Rows = 0
            .Rows = 2
            '.Cols = 5
            .Visible = False
            .FixedCols = 0
            .FixedRows = 1
            .WordWrap = True
            .AllowBigSelection = False
            .ScrollTrack = True
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .FormatString = "Programa|Break|Pos|Mensagem|"
            .HighLight = MSFlexGridLib.HighLightSettings.flexHighlightNever
            .FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusHeavy
            .SelectionMode = MSFlexGridLib.SelectionModeSettings.flexSelectionFree
            .set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)

            .set_ColWidth(fColuna(flxStatus, "Programa"), 1005)
            .set_ColWidth(fColuna(flxStatus, "Break"), 555)
            .set_ColWidth(fColuna(flxStatus, "Pos"), 555)
            .set_ColWidth(fColuna(flxStatus, "Mensagem"), 4860)
            .set_ColWidth(fColuna(flxStatus, ""), 420)

        End With
Saida:
        flxStatus.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub ConfiguraGridLog()
        'On Error GoTo Erro

        'With flxLog
        ' .Clear()
        ' .Rows = 1
        ' .Cols = 17
        ' .FormatString = "|Veiculo|data|programa|comerciao|break|tipo|fita|titulo|Empresa|Contrato|sequencia|ch.acesso|Usuario|Data|Hora|Operacao|Form"
        ' .AllowUserResizing =MSFlexGridLib.AllowUserResizeSettings.flexResizeBoth
        '	End With'

Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    'FIXIT: Declare 'Par_Veiculo_Origem' with an early-bound data type                         FixIT90210ae-R1672-R1B8ZE
    Private Function ExisteOrdenacao(ByRef Par_Veiculo_Origem As String, ByRef Par_Programa_Origem As String, ByRef Par_Chave_Acesso As Short) As Boolean

        On Error GoTo Erro

        Dim nRow As Short
        ExisteOrdenacao = False

        With flxBreak(0)
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Veiculo Origem")) = Par_Veiculo_Origem And .get_TextMatrix(nRow, fColuna(flxBreak(0), "Programa Origem")) = Par_Programa_Origem And Val(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Ch.Acesso"))) = Par_Chave_Acesso Then
                    ExisteOrdenacao = True
                    Exit For
                End If
            Next nRow
        End With

Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Function


    Private Function fConcorrente(ByVal Par_Linha As Short, ByVal Par_Produto As String) As Boolean
        On Error GoTo Erro

        Dim nPrimeiraLinha As Integer
        Dim nLoop As Short
        Dim nConcorrente As Short
        Dim nPosicao As Short
        Dim sMensagem As String = ""

        If Par_Produto = "" Then
            GoTo Saida
        End If

        If chkConcorrencia.CheckState = 1 Then
            GoTo Saida
        End If

        With flxBreak(0)

            For nLoop = Par_Linha To 1 Step -1
                If .get_TextMatrix(nLoop, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then ' Linha titulo do Break
                    nPrimeiraLinha = CStr(nLoop + 1)
                    Exit For
                End If
            Next nLoop

            For nLoop = nPrimeiraLinha To .Rows - 1
                If .get_TextMatrix(nLoop, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then '  chegou no proximo break
                    Exit For
                End If
                If .get_TextMatrix(nLoop, fColuna(flxBreak(0), "Indica Titulo Break")) <> "1" And .get_TextMatrix(nLoop, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) <> "1" Then
                    nPosicao = nPosicao + 1
                End If

                If .get_TextMatrix(nLoop, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) <> "1" Then '  Linha Titulo de Intervalo nao compara
                    'FIXIT: Replace 'Left' function with 'Left$' function                                      FixIT90210ae-R9757-R1B8ZE
                    'FIXIT: Replace 'Left' function with 'Left$' function                                      FixIT90210ae-R9757-R1B8ZE
                    If VB.Left(.get_TextMatrix(nLoop, fColuna(flxBreak(0), "Produto")), 6) = VB.Left(Par_Produto, 6) Then
                        nConcorrente = nConcorrente + 1
                        sMensagem = sMensagem & "Posição " & nPosicao & ") Titulo: " & .get_TextMatrix(nLoop, fColuna(flxBreak(0), "Comercial")) & vbCrLf
                    End If
                End If
            Next nLoop
        End With

        If nConcorrente > 0 Then
            If nConcorrente = 1 Then
                sMensagem = "Existe 1 comercial concorrente neste Break" & vbCrLf & sMensagem
            Else
                sMensagem = "Existem " & nConcorrente & " comerciais concorrentes neste Break" & vbCrLf & sMensagem
            End If
            sMensagem = sMensagem & vbCrLf & "Deseja ordenar mesmo assim ? "
            If MsgBox(sMensagem, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Atenção") = MsgBoxResult.No Then
                fConcorrente = True
            End If
        End If
Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Function

    'FIXIT: Declare 'nPasta' and 'Par_Linha_Origem' with an early-bound data type              FixIT90210ae-R1672-R1B8ZE
    Private Sub InsereGridDisponivel(ByRef nPasta As Object, ByRef Par_Linha_Origem As Object)
        On Error GoTo Erro
        Dim nCol As Short
        Dim nIndicaGrade As Short

        With flxDisponivel(nPasta)
            .Visible = False


            If nLinhadestino > .Rows - 1 Then
                nLinhadestino = .Rows - 1
            End If

            ' Se o comercial que esta devolvendo não pertencer ao Veiculo que está ordenandonao
            If flxBreak(0).get_TextMatrix(Par_Linha_Origem, fColuna(flxBreak(0), "Veiculo Origem")) <> ucVeiculo.text Then
                GoTo Saida
            End If

            For nCol = nLinhadestino To 0 Step -1
                If (.get_TextMatrix(nCol, fColuna(flxDisponivel(nPasta), "Comercial"))) <> "" Then
                    nLinhadestino = nCol
                    Exit For
                End If
            Next nCol
            nLinhadestino = nLinhadestino + 1
            .AddItem("", nLinhadestino)

            For nCol = 0 To .Cols - 1
                If .get_ColData(nCol) <> 0 Then
                    .set_TextMatrix(nLinhadestino, nCol, flxBreak(0).get_TextMatrix(nLinhaOrigem, .get_ColData(nCol)))
                End If
            Next nCol
            Call CalculaAlturaLinha(flxDisponivel(nPasta), nLinhadestino, fColuna(flxDisponivel(nPasta), "comercial"))
            '====================================> Cor da Linha

            If flxBreak(0).get_TextMatrix(Par_Linha_Origem, fColuna(flxBreak(0), "Indica Grade")) = "" Then GoTo Saida

            nIndicaGrade = CShort(flxBreak(0).get_TextMatrix(Par_Linha_Origem, fColuna(flxBreak(0), "Indica Grade")))
            Select Case nIndicaGrade
                Case 0 ' Net
                    Call CorGrid(flxDisponivel(nPasta), nLinhadestino, Color.Magenta, 1)
                Case 1, 2 ' Local, Programa
                    If flxBreak(0).get_TextMatrix(Par_Linha_Origem, fColuna(flxBreak(0), "Diferenciado")) = "1" And bolMostraDiferenciado Then
                        Call CorGrid(flxDisponivel(nPasta), nLinhadestino, Color.Purple, 1)
                    Else
                        Call CorGrid(flxDisponivel(nPasta), nLinhadestino, Color.Blue, 1)
                    End If
            End Select
        End With


Saida:
        flxDisponivel(nPasta).Visible = True
        Exit Sub

Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub MostraDisponiveisComercial()

        On Error GoTo Erro

        If Not bPermissaoComercial Then
            GoTo Saida
        End If


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Carregando Comerciais")

        Dim sProgramaAnterior As String = ""
        Dim nFlex As Short
        Dim nRoot As Short
        Dim nChild As Short
        Dim nReg As Short

        Call ConfiguraGridComercial(1)
        Call ConfiguraGridComercial(5)
        flxDisponivel(1).Rows = 1
        flxDisponivel(5).Rows = 1
        'flxDisponivel(1).Visible = False
        'flxDisponivel(5).Visible = False
        flxDisponivel(1).Redraw = False
        flxDisponivel(1).Redraw = False

        Me.DtsRoteiro = Me.AsmxRoteiro.spuCarregar_Comerciais(ucveiculo.text, ucdata.datetime, "")

        For Each DRW As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_ComerciaisRow In DtsRoteiro.dtbRoteiro_Comerciais.Rows
            nReg = nReg + 1
            Mensagem("Carregando Comerciais (" & nReg & ")")
            '===================Verifica se o comercial já está no grid de ordenacao
            If ExisteOrdenacao(ucVeiculo.Text, DRW.Cod_Programa, DRW.Chave_Acesso) Then
                GoTo Proximo_Registro
            End If
            '===================Verifica em qual pasta poe o comercial ( 1 ou 5)
            nFlex = 5
            With _flxBreak_0
                For nRoot = 0 To _flxBreak_0.Rows - 1
                    If .get_TextMatrix(nRoot, fColuna(flxBreak(0), "Indica_Titulo_Programa")) = "1" _
                        And DRW.Cod_Programa = .get_TextMatrix(nRoot, fColuna(flxBreak(0), "Codigo Programa")) Then
                        nFlex = 1
                        Exit For
                    End If
                Next
            End With

            'With treBreak
            '    For nRoot = 0 To .Nodes.Count - 1
            '        For nChild = 0 To .Nodes(nRoot).Nodes.Count - 1
            '            If DRW.Cod_Programa = treBreak.Nodes(nRoot).Nodes(nChild).Text And treBreak.Nodes(nRoot).Nodes(nChild).Checked Then
            '                nFlex = 1
            '                Exit For
            '            End If
            '        Next
            '        If nFlex = 1 Then Exit For
            '    Next
            'End With

            With flxDisponivel(nFlex)
                .Redraw = False
                .Rows = .Rows + 1
                nLin = .Rows - 1

                '===========================================Quebra do Programa, Adiciona linha de titulo do programa
                If sProgramaAnterior <> DRW.Cod_Programa Then
                    sProgramaAnterior = DRW.Cod_Programa
                    .AddItem("", nLin)
                    .Row = nLin
                    For nCont = 0 To .Cols - 1
                        .set_TextMatrix(nLin, nCont, Trim(DRW.Cod_Programa) & "-" & Trim(DRW.Titulo_Programa))
                        .Col = nCont
                        .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                        .CellFontBold = True
                        .CellBackColor = System.Drawing.Color.Yellow
                        .CellForeColor = System.Drawing.Color.Blue
                    Next nCont

                    .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Indica_Titulo_Programa"), "1")
                    .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree
                    .set_MergeRow(nLin, True)
                    Call CalculaAlturaLinha(flxDisponivel(nFlex), nLin, fColuna(flxDisponivel(nFlex), "Comercial"))
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Guia"), DRW.Cod_Programa)
                    nLin = nLin + 1
                End If

                '===========================================Adiciona Comercial
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Fita"), Vernulo(DRW.Numero_Fita, ""))

                If Trim(Vernulo(DRW.Descricao, "")) <> "" Then
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Comercial"), FirstCaps(Trim(DRW.Descricao)) & " / " & FirstCaps(Trim(DRW.Titulo_Comercial)))
                Else
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Comercial"), FirstCaps(Trim(DRW.Titulo_Comercial)))
                End If
                If Trim(ucVeiculo.Text) = "001" Or Trim(ucVeiculo.Text) = "004" Or Trim(ucVeiculo.Text) = "076" Then
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Comercial"), UCase(.get_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Comercial"))))
                End If

                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Dur."), DRW.Duracao)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Razao Social"), DRW.Razao_Social)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Empresa"), DRW.Cod_Empresa)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Contrato"), DRW.Numero_Mr)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Seq"), DRW.Sequencia_Mr)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Cod."), DRW.Cod_Comercial)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Ch.Acesso"), DRW.Chave_Acesso)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Cod Produto"), DRW.Cod_Produto)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Indica a Determinar"), DRW.Indica_Titulo_Determinar)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Obs Roteiro"), Vernulo(DRW.Obs_Roteiro, ""))
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "(VAGO)"), "")
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Indica Grade"), DRW.Indica_Grade)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Numero da Pasta"), nFlex) 'Primeira Pasta
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Horario de Restricao"), Vernulo(DRW.Horario_Restricao, ""))
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Codigo Programa"), DRW.Cod_Programa)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Veiculo Origem"), DRW.Cod_Veiculo)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Setor"), DRW.Setor)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Diferenciado"), DRW.Indica_Diferenciado)

                If DRW.Indica_Estouro = 1 Then
                    If Not DRW.IsPesoNull Then
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Peso"), Vernulo(DRW.Peso & "-", "") & "TQP")
                    Else
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Peso"), "TQP")
                    End If
                Else
                    If Not DRW.IsPesoNull Then
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(nFlex), "Peso"), Vernulo(DRW.Peso, ""))
                    End If
                End If
                '====================================> Cor da Linha
                Select Case DRW.Indica_Grade
                    Case 0 ' Net
                        Call CorGrid(flxDisponivel(nFlex), nLin, Color.Magenta, 1)
                    Case 1, 2 ' Local, Programa
                        If DRW.Indica_Diferenciado = 1 And bolMostraDiferenciado Then
                            Call CorGrid(flxDisponivel(nFlex), nLin, Color.Purple, 1)
                        Else
                            Call CorGrid(flxDisponivel(nFlex), nLin, Color.Blue, 1)
                        End If
                End Select
                Call CalculaAlturaLinha(flxDisponivel(nFlex), nLin, fColuna(flxDisponivel(nFlex), "Comercial"))
                .Row = nLin
                .Col = 0

            End With
Proximo_Registro:

        Next

        With flxDisponivel(1)
            If .Rows < 30 Then .Rows = 30
            .Row = 1
            .TopRow = 1
            .LeftCol = 0

        End With

        With flxDisponivel(5)
            If .Rows < 30 Then .Rows = 30
            .Row = 1
            .TopRow = 1
            .LeftCol = 0
        End With


Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        flxDisponivel(1).Visible = tabDisponiveis.SelectedItem.Index = 1
        flxDisponivel(5).Visible = tabDisponiveis.SelectedItem.Index = 5
        flxDisponivel(1).Redraw = True
        flxDisponivel(5).Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub MostraRoteiroOrdenado(ByRef Par_Programa As String)

        On Error GoTo Erro
        Dim nForecolor As System.Drawing.Color
        Dim nCont As Integer
        Dim nLin As Integer
        Dim nRoot As Integer
        Dim nChild As Integer
        Dim sHorario_Break As String

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Carregando Roteiro")
        Dim nSequencia As Short = 0
        Dim sTipoIntervalo As String = ""
        Dim sMensagemcorte As String = ""
        Dim sCodPrograma_Anterior As String = ""

        Me.DtsRoteiro = Me.AsmxRoteiro.spuCarregar_Roteiro(ucveiculo.text, ucdata.datetime, Par_Programa, 0, 1)

        nLin = 0
        Call ConfiguraGridBreak()
        Call Configura_GridCorte()
        With flxBreak(0)
            .Redraw = False
            For Each DRW As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In DtsRoteiro.dtbRoteiro_Ordenado.Rows
                If Not DRW.IsIndica_CorteNull Then
                    If DRW.Indica_Corte = 1 Then
                        With flxCorte
                            .Rows = .Rows + 1
                            .set_TextMatrix(.Rows - 1, 0, DRW.Cod_Empresa & "-" & DRW.Numero_MR & "-" & DRW.Sequencia_Mr)
                            .set_TextMatrix(.Rows - 1, 1, DRW.Cod_Comercial & "-" & FirstCaps(DRW.Titulo_Comercial))
                            .set_TextMatrix(.Rows - 1, 2, DRW.Duracao)
                            .set_TextMatrix(.Rows - 1, 3, Vernulo(DRW.Numero_Fita, ""))
                            .set_TextMatrix(.Rows - 1, 4, Vernulo(DRW.Cod_Programa, ""))
                            .set_TextMatrix(.Rows - 1, 5, DRW.Breaks)
                        End With
                        picCorte.Tag = 1
                        GoTo Proximo
                    End If
                End If

                sHorario_Break = ""
                If Not DRW.IsHora_Inicio_BreakNull Then
                    sHorario_Break = "  (" & VB6.Format(DRW.Hora_Inicio_Break, "hh:mm") & ")"
                End If

                nLin = nLin + 1
                If nLin >= .Rows - 1 Then
                    .Rows = .Rows + 1
                End If
                nForecolor = Color.Black
                '================Dados que devem ser movidos para todas as linhas do grid
                .set_TextMatrix(nLin, fColuna(flxBreak(0), "Codigo Programa"), DRW.Cod_Programa)
                .set_TextMatrix(nLin, fColuna(flxBreak(0), "Horario Inicio"), DRW.Inicio_Programa)
                .set_TextMatrix(nLin, fColuna(flxBreak(0), "Horario Fim"), DRW.Fim_Programa)
                '================Quebra do Programa, adiciona Linha com titulo do programa
                If DRW.Cod_Programa <> sCodPrograma_Anterior Then
                    sCodPrograma_Anterior = DRW.Cod_Programa
                    With treBreak
                        .BeginUpdate()
                        For nRoot = 0 To .Nodes.Count - 1
                            For nChild = 0 To .Nodes(nRoot).Nodes.Count - 1
                                If .Nodes(nRoot).Nodes(nChild).Text = DRW.Cod_Programa Then
                                    .Nodes(nRoot).Nodes(nChild).ForeColor = Color.Blue
                                    Exit For
                                End If
                            Next (nChild)
                        Next nRoot
                        .EndUpdate()
                    End With


                    sCodPrograma_Anterior = DRW.Cod_Programa
                    .AddItem("", nLin)
                    .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree
                    .Row = nLin

                    For nCont = 0 To .Cols - 1
                        .set_TextMatrix(nLin, nCont, Trim(DRW.Cod_Programa) & "-" & Trim(DRW.Titulo_Programa) & "   " & VB6.Format(DRW.Inicio_Programa, "hh:mm") & " às " & VB6.Format(DRW.Fim_Programa, "hh:mm"))
                        .Col = nCont
                        .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                        .CellFontBold = True
                        .CellBackColor = System.Drawing.Color.Yellow
                        .CellForeColor = System.Drawing.Color.Blue
                    Next nCont
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica_Titulo_Programa"), "1")
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Guia"), DRW.Cod_Programa)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Codigo Programa"), DRW.Cod_Programa)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Horario Inicio"), DRW.Inicio_Programa)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Horario Fim"), DRW.Fim_Programa)
                    .set_MergeRow(nLin, True)
                    CalculaAlturaLinha(flxBreak(0), nLin, fColuna(flxBreak(0), "Comercial"))
                    nLin = nLin + 1
                End If
                '============================================Linha de Titulo de Break
                If Vernulo(DRW.Indica_Titulo_Break, "") = 1 Then ' Linha de Titulo do Break
                    If DRW.IsSequencia_BreakNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), "Break")
                    Else
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), "Break" & DRW.Sequencia_Break.ToString)
                    End If
                    Call CorGrid(flxBreak(0), nLin, Color.Silver, 0)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Dur."), DRW.Duracao)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Break"), DRW.Breaks)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Titulo Break"), Vernulo(DRW.Indica_Titulo_Break, CStr(0)))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica se Permite Ordenacao"), Vernulo(DRW.Indica_Ordenacao, CStr(0)))
                    nSequencia = 0

                    If DRW.Breaks = 0 Then
                        flxBreak(0).set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), Trim(DRW.Cod_Programa) & "------>Inter Programa")
                    Else

                        If Not DRW.IsSequencia_BreakNull Then
                            flxBreak(0).set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), Trim(DRW.Cod_Programa) & "------>Break" & Vernulo(DRW.Sequencia_Break, DRW.Breaks))
                        Else
                            flxBreak(0).set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), Trim(DRW.Cod_Programa) & "------>Break" & DRW.Breaks)
                        End If
                    End If

                    .Row = nLin

                    '.Col = fColuna(flxBreak(0), "Comercial") = fColuna(flxBreak(0), "Comercial") & sHorario_Break
                    'arrumar aqui
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), .get_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial")) & sHorario_Break)



                    .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                    '.CellAlignment = flexAlignLeftCenter
                    .CellFontBold = True
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Guia"), DRW.Cod_Programa)
                End If
                '============================================Linha de do intervalo 
                If DRW.Indica_Titulo_Intervalo = 1 Then  ' Titulo do Intervalo
                    'FIXIT: Replace 'Trim' function with 'Trim$' function                                      FixIT90210ae-R9757-R1B8ZE
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), Trim(Vernulo(DRW.Titulo_Intervalo, "")))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Dur."), DRW.Duracao)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Break"), DRW.Breaks)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Tipo Intervalo"), DRW.Tipo_Break)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Titulo do Intervalo"), Vernulo(DRW.Indica_Titulo_Intervalo, CStr(0)))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica se Permite Ordenacao"), Vernulo(DRW.Indica_Ordenacao, CStr(0)))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Sequencia Faixa"), DRW.Sequencia_Faixa)
                    sTipoIntervalo = DRW.Tipo_Break
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Tipo Int. do Comercial"), sTipoIntervalo)
                    .Row = nLin
                    .Col = 1
                    .CellFontBold = True
                End If

                '============================================Linha do Comercial 
                If DRW.Indica_Titulo_Intervalo = 0 And DRW.Indica_Titulo_Break = 0 Then
                    nSequencia = nSequencia + 1
                    If Not DRW.IsDescricao_ProdutoNull And DRW.Descricao_Produto.Trim <> "" Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), FirstCaps(Trim(DRW.Descricao_Produto)) & " / " & FirstCaps(Trim(DRW.Titulo_Comercial)))
                    Else
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), FirstCaps(Trim(DRW.Titulo_Comercial)))
                    End If
                    If Trim(ucVeiculo.Text) = "001" Or Trim(ucVeiculo.Text) = "004" Or Trim(ucVeiculo.Text) = "076" Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"), UCase(.get_TextMatrix(nLin, fColuna(flxBreak(0), "Comercial"))))
                    End If

                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Dur."), DRW.Duracao)
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Fita"), Vernulo(DRW.Numero_Fita, ""))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Empresa"), Vernulo(DRW.Cod_Empresa, ""))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Diferenciado"), Vernulo(DRW.Indica_Diferenciado, 0))
                    If Not DRW.IsSequencia_MrNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Contrato"), DRW.Numero_MR)
                    End If
                    If Not DRW.IsSequencia_MrNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Seq"), Vernulo(DRW.Sequencia_Mr, ""))
                    End If

                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Com."), Vernulo(DRW.Cod_Comercial, ""))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Razao Social"), Vernulo(DRW.Razao_Social, ""))

                    If Not DRW.IsCod_ProdutoNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Produto"), Vernulo(DRW.Cod_Produto, ""))
                    End If

                    If Not DRW.IsChave_AcessoNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Ch.Acesso"), Vernulo(DRW.Chave_Acesso, ""))
                    End If
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Veiculo Origem"), Vernulo(DRW.Cod_Veiculo_Origem, ""))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Programa Origem"), Vernulo(DRW.Cod_Programa_Origem, ""))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Obs. Roteiro"), Vernulo(DRW.Obs_Roteiro, ""))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "A Determinar"), Vernulo(DRW.Indica_Titulo_Determinar, ""))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Break"), Vernulo(DRW.Breaks, ""))
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Titulo Break"), "0")
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Titulo do Intervalo"), "0")
                    If Not DRW.IsSetorNull Then .set_TextMatrix(nLin, fColuna(flxBreak(0), "Setor"), DRW.Setor)

                    If DRW.Indica_Midia = 1 Then
                        If DRW.Indica_Rotativo = 1 Then
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"), "2")
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Horario Inicio Comercial Rotativo"), Vernulo(DRW.Inicio_Rotativo, ""))
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Horario Fim Comercial Rotativo"), Vernulo(DRW.Fim_Rotativo, ""))
                        Else
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"), "1")
                        End If
                    Else
                        If DRW.Indica_Avulso = 1 Then
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"), "3")
                        Else
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"), "4")
                        End If
                    End If

                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica se Permite Ordenacao"), Vernulo(DRW.Indica_Ordenacao, CStr(0)))
                    If Not DRW.IsIndica_GradeNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Grade"), Vernulo(DRW.Indica_Grade, ""))
                    End If
                    If Not DRW.IsHorario_RestricaoNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Horario Restricao"), Vernulo(DRW.Horario_Restricao, ""))
                    End If
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Salvo"), "1")
                    If Not DRW.IsSequencia_FaixaNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Sequencia Faixa"), Vernulo(DRW.Sequencia_Faixa, ""))
                    End If
                    If Not DRW.IsID_FitaNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Id Chave"), Vernulo(DRW.ID_Fita, ""))
                    End If
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Versao"), Vernulo(DRW.Versao, CStr(0)))
                    If Not DRW.IsTipo_IntervaloNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Tipo Intervalo"), sTipoIntervalo)
                    End If
                    If Not DRW.IsTipo_BreakNull Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Tipo Int. do Comercial"), Vernulo(DRW.Tipo_Break, CStr(0)))
                    End If

                    If DRW.Indica_Estouro = 1 Then
                        If Not DRW.IsPesoNull Then
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Peso"), Vernulo(DRW.Peso & "-", "") & "TQP")
                        Else
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Peso"), "TQP")
                        End If
                    Else
                        If Not DRW.IsPesoNull Then
                            .set_TextMatrix(nLin, fColuna(flxBreak(0), "Peso"), Vernulo(DRW.Peso, ""))
                        End If
                    End If

                    If CBool(Vernulo(DRW.Indica_Espaco_Cedido, CStr(False))) Then
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica_Espaco_Cedido"), "1")
                    Else
                        .set_TextMatrix(nLin, fColuna(flxBreak(0), "Indica_Espaco_Cedido"), "0")
                    End If

                    '  Origem da Ordenacao
                    .Row = nLin
                    .Col = 3
                    .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
                    .CellFontBold = True
                    .CellFontSize = 8

                    .set_TextMatrix(nLin, fColuna(flxBreak(0), "Enc."), aOrigem(Val(.get_TextMatrix(nLin, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")))))
                    ' Sequencia do Comercial dentro do Break
                    .set_TextMatrix(nLin, fColuna(flxBreak(0), ""), nSequencia)


                End If

                '============================Verifica o Tipo de Break para Colocar a Cor
                If .get_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Titulo Break")) <> "1" Then
                    Select Case .get_TextMatrix(nLin, fColuna(flxBreak(0), "Tipo Int. do Comercial"))
                        Case "0" ' Local ou PE
                            nForecolor = Color.Blue
                        Case "1" ' Net
                            nForecolor = Color.Magenta
                        Case "2"
                            nForecolor = Color.Green 'Color.GreenYellow '&H8000
                        Case "3"
                            nForecolor = Color.Red
                        Case Else
                            nForecolor = Color.Black
                    End Select
                    '==============================Se for PE, fica sempre em vermelho e não se fala mais nisso
                    If Not DRW.IsTipo_FitaNull Then
                        If DRW.Tipo_Fita = 1 Then
                            nForecolor = Color.Red
                        End If
                    End If

                    '==============================Se for Intervalo Net em uma Afialida , fica cor de rosa e tambem não se fala mais nisso
                    If sTipoIntervalo = "1" And Trim(ucVeiculo.Text) <> "004" And Trim(ucVeiculo.Text) <> "001" And Trim(ucVeiculo.Text) <> "076" Then
                        nForecolor = Color.Magenta
                    End If

                    '==============================Se for Diferenciado fica roxo
                    If DRW.Indica_Diferenciado = 1 And bolMostraDiferenciado Then
                        nForecolor = Color.Purple
                    End If

                    Call CorGrid(flxBreak(0), nLin, nForecolor, 1)
                End If


                '============================Cor do Status
                If .get_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Or .get_TextMatrix(nLin, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) = "1" Then
                    Call CorStatus(nLin)
                End If

                Call CalculaAlturaLinha(flxBreak(0), nLin, fColuna(flxBreak(0), "Comercial"))
Proximo:

            Next

            For nCont = 1 To .Rows - 1
                'FIXIT: Replace 'Trim' function with 'Trim$' function                                      FixIT90210ae-R9757-R1B8ZE
                If .get_TextMatrix(nCont, fColuna(flxBreak(0), "Indica Titulo Break")) <> "1" And .get_TextMatrix(nCont, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) <> "1" And Trim(.get_TextMatrix(nCont, fColuna(flxBreak(0), "Comercial"))) <> "" Then
                    Call SomaBreak(nCont, Val(.get_TextMatrix(nCont, fColuna(flxBreak(0), "Dur."))))
                End If
            Next nCont
            .Redraw = True
            .Row = 1
            .TopRow = 1
            .LeftCol = 0
            flxBreak_RowColChange(flxBreak.Item(0), New System.EventArgs())

        End With
Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        flxBreak(0).Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub MostraDisponiveisDepositorio(ByRef Index As Short)
        On Error GoTo Erro

        Dim nCor As System.Drawing.Color
        Dim nTipo As Byte



        If Index = 3 Then
            If Not bPermissaoComercial Then GoTo Saida
            Mensagem("Carregando Depositorio Avulso")
        Else
            If Not bPermissaoArtistico Then GoTo Saida
            If Not bCarregaArtistico Then GoTo Saida
            Mensagem("Carregando Depositorio Artistico")
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        nTipo = IIf(Index = 3, 0, 1)
        Me.DtsRoteiro = Me.AsmxRoteiro.spuCarregar_Depositorio(ucveiculo.text, ucdata.datetime, "", nTipo)

        nLin = 0
        Call ConfiguraGridDepositorio(Index)
        With flxDisponivel(Index)
            .Redraw = False
            For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_DepositorioRow In Me.DtsRoteiro.dtbRoteiro_Depositorio.Rows

                nLin = nLin + 1
                If nLin >= .Rows - 1 Then
                    .Rows = .Rows + 1
                End If

                If Index = 3 Then
                    Mensagem("Carregando Depositorio Avulso (" & nLin & ")")
                Else
                    Mensagem("Carregando Depositorio Artistico (" & nLin & ")")
                End If


                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Fita"), Vernulo(drw.Numero_Fita, ""))

                If drw.Descricao.Trim = "" Then
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Comercial"), FirstCaps(Trim(drw.Titulo_Comercial)))
                Else
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Comercial"), FirstCaps(Trim(drw.Descricao)) & " / " & FirstCaps(Trim(drw.Titulo_Comercial)))
                End If
                If Trim(ucVeiculo.Text) = "001" Or Trim(ucVeiculo.Text) = "004" Or Trim(ucVeiculo.Text) = "076" Then
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Comercial"), UCase(.get_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Comercial"))))
                End If

                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Dur."), Int(drw.Duracao))
                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Saldo"), drw.Saldo)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Qtde"), drw.Saldo)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Numero da Pasta"), Index) 'Numero da Pasta
                If Not drw.IsCod_ProdutoNull Then .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Produto"), drw.Cod_Produto)
                If Not drw.IsSetorNull Then .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Setor"), drw.Setor)

                If Not drw.IsHorario_RestricaoNull Then
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Horario Restricao"), Vernulo(drw.Horario_Restricao, ""))
                End If
                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Cod. Veiculo"), ucVeiculo.Text)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "IdChave"), drw.IdChave)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Codigo Programa"), Vernulo(drw.Cod_Programa, ""))
                If Index = 3 Then '  fitas avulsas then
                    If Not drw.IsTipo_BreakNull Then
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Tipo do Break"), drw.Tipo_Break)
                    End If
                End If
                ' ==================Subtrai as quantidades que ja estao  (para o caso de recarregar a pasta)
                .set_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Saldo"), Val(.get_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Saldo"))) - ContaFitaOrdenada(drw.Numero_Fita))

                '==================Cor do Tipo de Break da Fita Avulsa
                .Row = nLin
                If Index = 3 Then
                    Select Case .get_TextMatrix(nLin, fColuna(flxDisponivel(Index), "Tipo do Break"))
                        Case "0" ' Net
                            nCor = Color.Magenta
                        Case "1" ' Pe
                            nCor = Color.Red
                        Case "2" ' Local
                            nCor = Color.Blue
                        Case "3"
                            nCor = Color.Red
                        Case Else
                            nCor = Color.Red
                    End Select
                    Call CorGrid(flxDisponivel(3), nLin, nCor, 1)
                End If
                '==================Cor do Status do Saldo
                .Col = 3
                If drw.Saldo >= 0 Then
                    .CellForeColor = Color.Blue
                Else
                    .CellForeColor = Color.Red
                End If
                Call CalculaAlturaLinha(flxDisponivel(Index), nLin, fColuna(flxDisponivel(3), "Comercial"))
            Next
            .Row = 1
            .TopRow = 1
            .LeftCol = 0
            If Index = 4 Then bCarregaArtistico = False
        End With
Saida:

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        flxDisponivel(Index).Redraw = True
        flxDisponivel(Index).Visible = tabDisponiveis.SelectedItem.Index = Index
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub
    Private Sub MostraDisponiveisARNaoReplicado()
    End Sub
    Private Function ContaFitaOrdenada(ByRef Par_Fita As String) As Short
        On Error GoTo Erro
        Dim nRow As Short
        ContaFitaOrdenada = 0
        With flxBreak(0)
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")) = "3" Or .get_TextMatrix(nRow, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")) = "4" Then ' Avulso ou artistico

                    If Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Fita"))) = Trim(Par_Fita) Then ' é a fita que esta procurando
                        If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Salvo")) <> "1" Then ' Não esta salvao no roteiro
                            ContaFitaOrdenada = ContaFitaOrdenada + 1
                        End If
                    End If
                End If
            Next nRow
        End With

Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Function


    Private Sub MostraDisponiveisRotativo()
        On Error GoTo Erro
        Dim sProgramaAnterior As String = ""
        If Not bPermissaoComercial Then
            GoTo Saida
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Carregando Rotativos")

        Me.DtsRoteiro = Me.AsmxRoteiro.spuCarregar_Rotativo(ucveiculo.text, UcData.DateTime, "", 0)
        nLin = 0
        Call ConfiguraGridRotativo()
        With flxDisponivel(2)
            .Redraw = False
            For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_RotativoRow In DtsRoteiro.dtbRoteiro_Rotativo.Rows

                If Not ExisteOrdenacao(ucVeiculo.Text, drw.Cod_Programa, drw.Chave_Acesso) Then

                    Mensagem("Carregando Rotativos (" & nLin & ")")

                    nLin = nLin + 1
                    If nLin >= .Rows - 1 Then
                        .Rows = .Rows + 1
                    End If
                    'Mensagem "Carregando " & nLin

                    If sProgramaAnterior <> drw.Cod_Programa Then
                        sProgramaAnterior = drw.Cod_Programa
                        .AddItem("", nLin)
                        .Row = nLin
                        For nCont = 0 To .Cols - 1
                            .set_TextMatrix(nLin, nCont, Trim(drw.Cod_Programa) & "       " & VB6.Format(drw.Hora1, "hh:mm") & " às " & VB6.Format(drw.Hora2, "hh:mm"))
                            .Col = nCont
                            .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                            .CellFontBold = True
                            .CellBackColor = System.Drawing.Color.Yellow
                            .CellForeColor = System.Drawing.Color.Blue
                        Next nCont
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Indica_Titulo_Programa"), "1")
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Codigo Programa"), drw.Cod_Programa)
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "GUIA"), drw.Cod_Programa)
                        .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree
                        .set_MergeRow(nLin, True)
                        Call CalculaAlturaLinha(flxDisponivel(2), nLin, fColuna(flxDisponivel(2), "Comercial"))

                        nLin = nLin + 1
                    End If


                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Fita"), Vernulo(drw.Numero_Fita, ""))
                    If drw.Descricao.Trim <> "" Then
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Comercial"), FirstCaps(Trim(drw.Descricao)) & " / " & FirstCaps(Trim(drw.Titulo_Comercial)))
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Setor"), drw.Setor) ' Segunda pasta
                    Else
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Comercial"), FirstCaps(Trim(drw.Titulo_Comercial)))
                    End If
                    If Trim(ucVeiculo.Text) = "001" Or Trim(ucVeiculo.Text) = "004" Or Trim(ucVeiculo.Text) = "076" Then
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Comercial"), UCase(.get_TextMatrix(nLin, fColuna(flxDisponivel(2), "Comercial"))))
                    End If

                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Dur."), drw.Duracao)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Codigo Programa"), drw.Cod_Programa)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Razao Social"), drw.Razao_Social)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Empresa"), drw.Cod_Empresa)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Contrato"), drw.Numero_Mr)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Seq"), drw.Sequencia_Mr)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Cod."), drw.Cod_Comercial)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Ch.Acesso"), drw.Chave_Acesso)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Cod Produto"), drw.Cod_Produto)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Indica a Determinar"), drw.Indica_Titulo_Determinar)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Obs Roteiro"), Vernulo(drw.Obs_Roteiro, ""))
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Indica Grade"), drw.Indica_Grade)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Diferenciado "), drw.Indica_Diferenciado)
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Numero da Pasta"), 2) ' Segunda pasta
                    If Not drw.IsHorario_RestricaoNull Then
                        .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Horario de Restricao"), Vernulo(drw.Horario_Restricao, ""))
                    End If
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Veiculo"), Vernulo(drw.Cod_Veiculo, ""))

                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Horario Inicio"), Vernulo(drw.Hora1, ""))
                    .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Horario Fim"), Vernulo(drw.Hora2, ""))

                    If drw.Indica_Estouro = 1 Then
                        If Not drw.IsPesoNull Then
                            .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Peso"), Vernulo(drw.Peso & "-", "") & "TQP")
                        Else
                            .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Peso"), "TQP")
                        End If
                    Else
                        If Not drw.IsPesoNull Then
                            .set_TextMatrix(nLin, fColuna(flxDisponivel(2), "Peso"), Vernulo(drw.Peso, ""))
                        End If
                    End If


                    '====================================> Cor da Linha
                    Select Case drw.Indica_Grade
                        Case 0 ' Net
                            Call CorGrid(flxDisponivel(2), nLin, Color.Magenta, 1)
                        Case 1, 2 ' Local, Programa
                            If drw.Indica_Diferenciado = 1 And bolMostraDiferenciado Then
                                Call CorGrid(flxDisponivel(2), nLin, Color.Purple, 1)
                            Else
                                Call CorGrid(flxDisponivel(2), nLin, Color.Blue, 1)
                            End If
                    End Select
                    Call CalculaAlturaLinha(flxDisponivel(2), nLin, fColuna(flxDisponivel(2), "Comercial"))

                End If
            Next
            .Redraw = True
            .Row = 1
            .TopRow = 1
            .LeftCol = 0
        End With
Saida:

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        flxDisponivel(2).Redraw = True
        flxDisponivel(2).Visible = tabDisponiveis.SelectedItem.Index = 2
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub ConfiguraGridBreak()
        On Error GoTo Erro
        '================================Colunas do Grid de Roteiro Ordenado
        With flxBreak(0)
            .Clear()
            '.Visible = False
            .Redraw = False
            .FixedCols = 0
            .Rows = 1
            .Rows = 30
            .Cols = 43

            .AllowBigSelection = False
            .ScrollTrack = True
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            '.FormatString = "|Comercial|Dur."
            .set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)
            .WordWrap = True
            .RowHeightMin = 285
            .FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusNone

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
            .set_TextMatrix(0, 41, "Diferenciado")

            '  O valor do Coldata reprenta o Numero da Coluna do Grid de Break onde
            '   sera guardado quando efetuar o DragDrop
            For nCont = 0 To .Cols - 1
                .set_ColData(nCont, nCont)
            Next nCont

            .set_ColAlignment(fColuna(flxBreak(0), "comercial"), MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
            .Row = 1
            .Col = 0
            .TopRow = 1
            .LeftCol = 0
        End With

Saida:
        flxBreak(0).Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGridComercial(ByRef Index As Short)
        On Error GoTo Erro

        '================================Colunas do Grid de Comerciais
        With flxDisponivel(Index)

            .Clear()
            .Redraw = False
            .FixedCols = 0
            .Rows = 1
            .Rows = 30
            .Cols = 27

            If Index > 1 Then
                .Location = flxDisponivel(1).Location
                .Site = flxDisponivel(1).Site
                '.Top = VB6.TwipsToPixelsY(flxDisponivel(1).Top)
                '.Left = VB6.TwipsToPixelsX(flxDisponivel(1).Left)
                '.Width = VB6.TwipsToPixelsX(flxDisponivel(1).Width)
            End If

            .ForeColor = System.Drawing.Color.Blue
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollTrack = True
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictAll
            .WordWrap = True
            .FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusNone

            .set_TextMatrix(0, 0, "..")
            .set_TextMatrix(0, 1, "Fita")
            .set_TextMatrix(0, 2, "Comercial")
            .set_TextMatrix(0, 3, "Dur.")
            .set_TextMatrix(0, 4, "Peso")
            .set_TextMatrix(0, 5, "Cod.")
            .set_TextMatrix(0, 6, "Razao Social")
            .set_TextMatrix(0, 7, "Empresa")
            .set_TextMatrix(0, 8, "Contrato")
            .set_TextMatrix(0, 9, "Seq")
            .set_TextMatrix(0, 10, "Ch.Acesso")
            .set_TextMatrix(0, 11, "Cod Produto")
            .set_TextMatrix(0, 12, "Indica a Determinar")
            .set_TextMatrix(0, 13, "Obs Roteiro")
            .set_TextMatrix(0, 14, "(VAGO)")
            .set_TextMatrix(0, 15, "Indica Grade")
            .set_TextMatrix(0, 16, "Numero da Pasta")
            .set_TextMatrix(0, 17, "Horario de Restricao")
            .set_TextMatrix(0, 18, "Codigo Programa")
            .set_TextMatrix(0, 19, "Veiculo Origem")
            .set_TextMatrix(0, 20, "Indica_Titulo_Programa")
            .set_TextMatrix(0, 21, "GUIA")
            .set_TextMatrix(0, 22, "Horario Inicio")
            .set_TextMatrix(0, 23, "Horario Fim")
            .set_TextMatrix(0, 24, "Indica_Espaco_Cedido")
            .set_TextMatrix(0, 25, "Setor")
            .set_TextMatrix(0, 26, "Diferenciado")

            '======O valor do Coldata reprenta o Numero da Coluna do Grid de Break onde
            '      sera guardado quando efetuar o DragDrop

            .set_ColData(fColuna(flxDisponivel(Index), "Fita"), fColuna(flxBreak(0), "Fita"))
            .set_ColData(fColuna(flxDisponivel(Index), "Comercial"), fColuna(flxBreak(0), "Comercial"))
            .set_ColData(fColuna(flxDisponivel(Index), "Dur."), fColuna(flxBreak(0), "Dur."))
            .set_ColData(fColuna(flxDisponivel(Index), "Razao Social"), fColuna(flxBreak(0), "Razao Social"))
            .set_ColData(fColuna(flxDisponivel(Index), "Empresa"), fColuna(flxBreak(0), "Empresa"))
            .set_ColData(fColuna(flxDisponivel(Index), "Contrato"), fColuna(flxBreak(0), "Contrato"))
            .set_ColData(fColuna(flxDisponivel(Index), "Seq"), fColuna(flxBreak(0), "Seq"))
            .set_ColData(fColuna(flxDisponivel(Index), "Cod."), fColuna(flxBreak(0), "Com."))
            .set_ColData(fColuna(flxDisponivel(Index), "Ch.Acesso"), fColuna(flxBreak(0), "Ch.Acesso"))
            .set_ColData(fColuna(flxDisponivel(Index), "Cod Produto"), fColuna(flxBreak(0), "Produto"))
            .set_ColData(fColuna(flxDisponivel(Index), "Indica a Determinar"), fColuna(flxBreak(0), "A Determinar"))
            .set_ColData(fColuna(flxDisponivel(Index), "Obs Roteiro"), fColuna(flxBreak(0), "Obs. Roteiro"))
            .set_ColData(fColuna(flxDisponivel(Index), "(VAGO)"), 0)
            .set_ColData(fColuna(flxDisponivel(Index), "Indica Grade"), fColuna(flxBreak(0), "Indica Grade"))
            .set_ColData(fColuna(flxDisponivel(Index), "Numero da Pasta"), fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
            .set_ColData(fColuna(flxDisponivel(Index), "Horario de Restricao"), fColuna(flxBreak(0), "Horario Restricao"))
            .set_ColData(fColuna(flxDisponivel(Index), "Codigo Programa"), fColuna(flxBreak(0), "Programa Origem"))
            .set_ColData(fColuna(flxDisponivel(Index), "Veiculo Origem"), fColuna(flxBreak(0), "Veiculo Origem"))
            .set_ColData(fColuna(flxDisponivel(Index), "Peso"), fColuna(flxBreak(0), "Peso"))
            .set_ColData(fColuna(flxDisponivel(Index), "Horario Inicio"), fColuna(flxBreak(0), "Horario Inicio Comercial Rotativo"))
            .set_ColData(fColuna(flxDisponivel(Index), "Horario Fim"), fColuna(flxBreak(0), "Horario Fim Comercial Rotativo"))
            .set_ColData(fColuna(flxDisponivel(Index), "Indica_Espaco_Cedido"), fColuna(flxBreak(0), "Indica_Espaco_Cedido"))
            .set_ColData(fColuna(flxDisponivel(Index), "Setor"), fColuna(flxBreak(0), "Setor"))
            .set_ColData(fColuna(flxDisponivel(Index), "Diferenciado"), fColuna(flxBreak(0), "Diferenciado"))
            'If Not bMostraColunaPeso Then
            '   .ColWidth(fColuna(flxDisponivel(1), "Peso")) = 0
            'End If


            .Row = 1
            .Col = 0
            .TopRow = 1
            .LeftCol = 0
            .set_ColAlignment(fColuna(flxBreak(0), "comercial"), MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)


        End With
Saida:
        flxDisponivel(Index).Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGridDepositorio(ByRef Index As Short)
        On Error GoTo Erro
        With flxDisponivel(Index)
            .Clear()
            .Redraw = False
            .FixedCols = 0
            .Rows = 1
            .Rows = 30
            .Cols = 16
            .Location = flxDisponivel(1).Location
            .Site = flxDisponivel(1).Site
            .WordWrap = True
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            '.ScrollTrack = True
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusNone

            If Index = 3 Then ' Avulso
                .ForeColor = System.Drawing.ColorTranslator.FromOle(&HC0)
            Else ' Artistico
                .ForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
            End If
            .set_TextMatrix(0, 0, "Fita")
            .set_TextMatrix(0, 1, "Comercial")
            .set_TextMatrix(0, 2, "Dur.")
            .set_TextMatrix(0, 3, "Saldo")
            .set_TextMatrix(0, 4, "Qtde")
            .set_TextMatrix(0, 5, "Numero da Pasta")
            .set_TextMatrix(0, 6, "Produto")
            .set_TextMatrix(0, 7, "Horario Restricao")
            .set_TextMatrix(0, 8, "Cod. Veiculo")
            .set_TextMatrix(0, 9, "IdChave")
            .set_TextMatrix(0, 10, "Tipo do Break")
            .set_TextMatrix(0, 11, "Codigo Programa")
            .set_TextMatrix(0, 12, "Indica_Espaco_Cedido")
            .set_TextMatrix(0, 13, "Hora_Ar")
            .set_TextMatrix(0, 14, "Setor")
            .set_TextMatrix(0, 15, "Diferenciado")

            .set_ColData(fColuna(flxDisponivel(Index), "Fita"), fColuna(flxBreak(0), "Fita"))
            .set_ColData(fColuna(flxDisponivel(Index), "Comercial"), fColuna(flxBreak(0), "Comercial"))
            .set_ColData(fColuna(flxDisponivel(Index), "Dur."), fColuna(flxBreak(0), "Dur."))
            .set_ColData(fColuna(flxDisponivel(Index), "Saldo"), 0)
            .set_ColData(fColuna(flxDisponivel(Index), "Qtde"), 0)
            .set_ColData(fColuna(flxDisponivel(Index), "Numero da Pasta"), fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
            .set_ColData(fColuna(flxDisponivel(Index), "Produto"), fColuna(flxBreak(0), "Produto"))
            .set_ColData(fColuna(flxDisponivel(Index), "Horario Restricao"), fColuna(flxBreak(0), "Horario Restricao"))
            .set_ColData(fColuna(flxDisponivel(Index), "Cod. Veiculo"), fColuna(flxBreak(0), "Veiculo Origem"))
            .set_ColData(fColuna(flxDisponivel(Index), "IdChave"), fColuna(flxBreak(0), "Id Chave"))
            .set_ColData(fColuna(flxDisponivel(Index), "Tipo do Break"), fColuna(flxBreak(0), "Tipo do Break da Fita"))
            .set_ColData(fColuna(flxDisponivel(Index), "Codigo Programa"), fColuna(flxBreak(0), "Programa Origem"))
            .set_ColData(fColuna(flxDisponivel(Index), "Indica_Espaco_Cedido"), fColuna(flxBreak(0), "Indica_Espaco_Cedido"))
            .set_ColData(fColuna(flxDisponivel(Index), "Setor"), fColuna(flxBreak(0), "Setor"))
            .set_ColData(fColuna(flxDisponivel(Index), "Diferenciado"), fColuna(flxBreak(0), "Diferenciado"))

            .Row = 1
            .Col = 0
            .TopRow = 1
            .LeftCol = 0
            .set_ColAlignment(fColuna(flxBreak(0), "comercial"), MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)


        End With
Saida:
        flxDisponivel(Index).Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGridRotativo()
        On Error GoTo Erro

        With flxDisponivel(2)
            .Clear()
            .Redraw = False
            .FixedCols = 0
            .Rows = 1
            .Rows = 30
            .Cols = 26
            .Location = flxDisponivel(1).Location
            .Site = flxDisponivel(1).Site
            .ForeColor = System.Drawing.Color.Blue
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollTrack = True
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .WordWrap = True
            .set_TextMatrix(0, 0, "..")
            .set_TextMatrix(0, 1, "Fita")
            .set_TextMatrix(0, 2, "Comercial")
            .set_TextMatrix(0, 3, "Dur.")
            .set_TextMatrix(0, 4, "Peso")
            .set_TextMatrix(0, 5, "Cod.")
            .set_TextMatrix(0, 6, "Razao Social")
            .set_TextMatrix(0, 7, "Empresa")
            .set_TextMatrix(0, 8, "Contrato")
            .set_TextMatrix(0, 9, "Seq")
            .set_TextMatrix(0, 10, "Ch.Acesso")
            .set_TextMatrix(0, 11, "Cod Produto")
            .set_TextMatrix(0, 12, "Indica a Determinar")
            .set_TextMatrix(0, 13, "Obs Roteiro")
            .set_TextMatrix(0, 14, "Indica Grade")
            .set_TextMatrix(0, 15, "Numero da Pasta")
            .set_TextMatrix(0, 16, "Horario de Restricao")
            .set_TextMatrix(0, 17, "Veiculo")
            .set_TextMatrix(0, 18, "Indica_Titulo_Programa")
            .set_TextMatrix(0, 19, "Codigo Programa")
            .set_TextMatrix(0, 20, "Horario Inicio ")
            .set_TextMatrix(0, 21, "Horario Fim ")
            .set_TextMatrix(0, 22, "Indica_Espaco_Cedido")
            .set_TextMatrix(0, 23, "GUIA")
            .set_TextMatrix(0, 24, "Setor")
            .set_TextMatrix(0, 25, "Diferenciado")

            ' O valor do Coldata representa o Numero da Coluna do Grid de Break onde
            ' sera guardado quando efetuar o DragDrop
            .set_ColData(fColuna(flxDisponivel(2), "Fita"), fColuna(flxBreak(0), "Fita"))
            .set_ColData(fColuna(flxDisponivel(2), "Comercial"), fColuna(flxBreak(0), "Comercial"))
            .set_ColData(fColuna(flxDisponivel(2), "Dur."), fColuna(flxBreak(0), "Dur."))
            .set_ColData(fColuna(flxDisponivel(2), "Codigo Programa"), fColuna(flxBreak(0), "Programa Origem"))
            .set_ColData(fColuna(flxDisponivel(2), "Razao Social"), fColuna(flxBreak(0), "Razao Social"))
            .set_ColData(fColuna(flxDisponivel(2), "Empresa"), fColuna(flxBreak(0), "Empresa"))
            .set_ColData(fColuna(flxDisponivel(2), "Contrato"), fColuna(flxBreak(0), "Contrato"))
            .set_ColData(fColuna(flxDisponivel(2), "Seq"), fColuna(flxBreak(0), "Seq"))
            .set_ColData(fColuna(flxDisponivel(2), "Cod."), fColuna(flxBreak(0), "Com."))
            .set_ColData(fColuna(flxDisponivel(2), "Ch.Acesso"), fColuna(flxBreak(0), "Ch.Acesso"))
            .set_ColData(fColuna(flxDisponivel(2), "Cod Produto"), fColuna(flxBreak(0), "Produto"))
            .set_ColData(fColuna(flxDisponivel(2), "Indica a Determinar"), fColuna(flxBreak(0), "A Determinar"))
            .set_ColData(fColuna(flxDisponivel(2), "Obs Roteiro"), fColuna(flxBreak(0), "Obs. Roteiro"))
            .set_ColData(fColuna(flxDisponivel(2), "Indica Grade"), fColuna(flxBreak(0), "Indica Grade"))
            .set_ColData(fColuna(flxDisponivel(2), "Numero da Pasta"), fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
            .set_ColData(fColuna(flxDisponivel(2), "Horario de Restricao"), fColuna(flxBreak(0), "Horario Restricao"))
            .set_ColData(fColuna(flxDisponivel(2), "Veiculo"), fColuna(flxBreak(0), "Veiculo Origem"))
            .set_ColData(fColuna(flxDisponivel(2), "Peso"), fColuna(flxBreak(0), "Peso"))

            .set_ColData(fColuna(flxDisponivel(2), "Horario Inicio"), fColuna(flxBreak(0), "Horario Inicio Comercial Rotativo"))
            .set_ColData(fColuna(flxDisponivel(2), "Horario Fim"), fColuna(flxBreak(0), "Horario Fim Comercial Rotativo"))
            .set_ColData(fColuna(flxDisponivel(2), "Indica_Espaco_Cedido"), fColuna(flxBreak(0), "Indica_Espaco_Cedido"))
            .set_ColData(fColuna(flxDisponivel(2), "Setor"), fColuna(flxBreak(0), "Setor"))
            .set_ColData(fColuna(flxDisponivel(2), "Diferenciado"), fColuna(flxBreak(0), "Diferenciado"))

            .Row = 1
            .Col = 0
            .TopRow = 1
            .LeftCol = 0

            .set_ColAlignment(fColuna(flxBreak(0), "comercial"), MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        End With
Saida:
        flxDisponivel(2).Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub CorGrid(ByRef fGrid As AxMSFlexGridLib.AxMSFlexGrid, ByRef Par_Row As Short, ByRef Par_Cor As System.Drawing.Color, ByRef Par_Tipo As Byte)
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
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub NumeraLinha(ByRef Par_Programa As String, ByRef Par_Break As Short)
        On Error GoTo Erro
        Dim nPrimeiraLinha As Short
        Dim nUltimaLinha As Short
        Dim nRow As Short
        Dim nContador As Short
        nPrimeiraLinha = 0


        With flxBreak(0)

            For nRow = 1 To .Rows - 1

                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Codigo Programa")) = Par_Programa And Val(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Break"))) = Par_Break And .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then
                    nPrimeiraLinha = nRow
                End If

                'If Val(.TextMatrix(nRow, fColuna(flxBreak(0), "Break"))) > Par_Break Or _
                ''      (Trim(.TextMatrix(nRow, fColuna(flxBreak(0), "Comercial"))) = "" And _
                ''      Trim(.TextMatrix(nRow, fColuna(flxBreak(0), "dur."))) = "" And _
                ''      Trim(.TextMatrix(nRow, fColuna(flxBreak(0), "enc."))) = "") Then
                '   nUltimaLinha = nRow - 1
                '   Exit For
                'End If

                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Codigo Programa")) <> Par_Programa And nPrimeiraLinha <> 0 Then
                    nUltimaLinha = nRow - 1
                    Exit For
                End If
            Next nRow

            For nRow = nPrimeiraLinha To nUltimaLinha
                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Titulo Break")) <> "1" And .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) <> "1" Then
                    nContador = nContador + 1
                    .set_TextMatrix(nRow, fColuna(flxBreak(0), ""), nContador)
                End If
            Next
        End With



Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub RemoveLinha(ByVal Par_Flex As AxMSFlexGridLib.AxMSFlexGrid, ByVal Par_Linha As Short)

        On Error GoTo Erro
        Dim bRemove As Boolean
        Dim bSomaFita As Boolean
        Dim bSomaBreak As Boolean
        Dim sFita As String = ""
        Dim nSoma As Short
        Dim nPasta As Short
        Dim nBreak As Short
        Dim sPrograma As String = ""
        Dim sOperacao As String = ""
        bRemove = False
        bSomaFita = False

        With Par_Flex

            '==================Verifica se remove a Linha ou atualiza o saldo da fita

            Select Case Par_Flex.Name
                Case _flxBreak_0.Name
                    nPasta = Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")))
                    nBreak = Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Break")))
                    sPrograma = .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Codigo Programa"))
                    Select Case nPasta ' Pasta Origem
                        Case 1, 2, 5 ' Comercial, Rotativo ou InterPrograma
                            bRemove = True
                            bSomaFita = False
                            bSomaBreak = True
                        Case 3, 4, 6 ' Depositorio = Atualiza Saldo
                            sFita = .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Fita"))
                            bRemove = True
                            bSomaFita = True
                            bSomaBreak = True
                            nSoma = 1
                    End Select
                Case _flxDisponivel_1.Name
                    bRemove = True
                    nPasta = 1
                Case _flxDisponivel_2.Name
                    bRemove = True
                    nPasta = 2
                Case _flxDisponivel_3.Name
                    bSomaFita = True
                    nPasta = 3
                    sFita = .get_TextMatrix(Par_Linha, fColuna(Par_Flex, "Fita"))
                    nSoma = -1
                Case _flxDisponivel_4.Name
                    bSomaFita = True
                    sFita = .get_TextMatrix(Par_Linha, fColuna(Par_Flex, "Fita"))
                    nSoma = -1
                    nPasta = 4
                Case _flxDisponivel_5.Name
                    bRemove = True
                    nPasta = 5
                Case _flxDisponivel_6.Name
                    bRemove = True
                    nPasta = 6
            End Select



            If bSomaFita Then
                Call AtualizaSaldoFita(nPasta, sFita, nSoma)
            End If

            If bSomaBreak Then
                Call SomaBreak(Par_Linha, CDbl(.get_TextMatrix(Par_Linha, fColuna(Par_Flex, "Dur."))) * -1)
            End If


            '=================================================>Grava o Log
            If Not bIndicaMudancaPosicao Then
                sOperacao = ""

                If Par_Flex.Name = _flxBreak_0.Name Then
                    Select Case .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
                        Case "1"
                            sOperacao = "Exclusao de Comercial"
                        Case "2"
                            sOperacao = "Exclusao de Comercial Rotativo"
                        Case "3"
                            sOperacao = "Exclusao de Comercial Avulso"
                        Case "4"
                            sOperacao = "Exclusao de Comercial Artistico"
                        Case "5"
                            sOperacao = "Exclusao de Comercial de Outro Programa"
                    End Select

                    sOperacao = sOperacao & " (Break ." & .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Break")) & ")"


                    Me.AdicionaLog(ucveiculo.text, UcData.DateTime, .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Codigo Programa")), .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Com.")), Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Break"))), Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Tipo Intervalo"))), .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Fita")), .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Comercial")), .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Empresa")), Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Contrato"))), Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Seq"))), Val(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Ch.Acesso"))), sOperacao, Me.Name)
                End If
            End If
            '====================================> Remove a Linha
            If bRemove Then
                .RemoveItem(Par_Linha)

                If .Name = _flxBreak_0.Name Then
                    Call NumeraLinha(sPrograma, nBreak)
                End If
            End If

            '====================================> Corrige quantida de linhas
            If .Rows < 30 Then
                .Rows = 30
            End If



        End With

Saida:
        Exit Sub
Erro:

        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub AtualizaSaldoFita(ByVal Par_Index As Short, ByVal Par_Fita As String, ByVal Par_Qtd As Short)
        On Error GoTo Erro
        Dim nRow As Short

        With flxDisponivel(Par_Index)
            For nRow = 1 To .Rows - 1
                If Trim(.get_TextMatrix(nRow, fColuna(flxDisponivel(Par_Index), "Fita"))) = Trim(Par_Fita) Then
                    .set_TextMatrix(nRow, fColuna(flxDisponivel(Par_Index), "Saldo"), Val(.get_TextMatrix(nRow, fColuna(flxDisponivel(Par_Index), "Saldo"))) + Par_Qtd)
                    .set_TextMatrix(nRow, fColuna(flxDisponivel(Par_Index), "Qtde"), CDbl(.get_TextMatrix(nRow, fColuna(flxDisponivel(Par_Index), "Qtde"))) + Par_Qtd)

                    .Row = nRow
                    .Col = 3
                    If Val(.get_TextMatrix(nRow, fColuna(flxDisponivel(Par_Index), "Saldo"))) >= 0 Then
                        .CellForeColor = System.Drawing.Color.Blue
                    Else
                        .CellForeColor = System.Drawing.Color.Red
                    End If
                    Exit For
                End If
            Next nRow
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub
    Private Function SalvaOrdenacao() As Boolean
        On Error GoTo Erro
        SalvaOrdenacao = True
        Dim nRow As Short
        Dim nCol As Short
        Dim sCritica As String = ""
        Dim sMensagem As String = ""
        Dim shTempo As Integer
        Dim shBreak As String = ""
        Dim shSequencia_Faixa As String = ""
        Dim shSequencia_Intervalo As String = ""
        Dim shTipo_Break As String = ""
        Dim intIDChave As String = ""
        Dim strNumero_Fita As String = ""
        Dim intChave_Acesso As String = ""
        Dim strCod_Empresa As String = ""
        Dim lngNumero_MR As String = ""
        Dim shSequencia_MR As String = ""
        Dim intDuracao As String = ""
        Dim strCod_Comercial As String = ""
        Dim strCod_Programa_Origem As String = ""
        Dim strCod_Veiculo_Origem As String = ""
        Dim shVersao As String = ""
        Dim shOrigem As String = ""
        Dim shPosicao As Short
        Dim strCod_Programa As String = ""
        Dim bEspacoCedido As Boolean
        Dim sId_Processo As String = ""
        Dim nCor As Drawing.Color


        Mensagem("Salvando Ordenacao.....Aguarde.")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If ExisteRoteiroEncerrado(ucveiculo.text, UcData.DateTime) Then
            sMensagem = "Roteiro para este Veiculo / Data Já foi Encerrado." & vbCrLf
            sMensagem = sMensagem & "Para continuar a Gravação é Necessario reabrir o Roteiro." & vbCrLf
            sMensagem = sMensagem & "Confirma Reabertura e Gravação"
            If Not Aviso(sMensagem, MsgBoxStyle.YesNo, MsgBoxStyle.Question) Then
                SalvaOrdenacao = False
                GoTo Saida
            Else
                Call ReabreRoteiro(ucveiculo.text, UcData.DateTime)
            End If
        End If

        Call Configura_GridStatus()

        lblMensagem.Text = "Roteiro salvo com sucesso"

        lblMensagem.ForeColor = System.Drawing.Color.Blue
        picMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None

        '======================================================limpa datatable e Obtem um Id unico
        DtsRoteiro.dtbTbRSA_Roteiro.Clear()
        DtsRoteiro.dtbRoteiro_Critica.Clear()
        sId_Processo = AsmxRoteiro.spuGetId()
        '======================================================Grava DTS Temporario para a Salva
        With flxBreak(0)
            For nRow = 1 To .Rows - 1
                shBreak = ""
                shSequencia_Faixa = ""
                shSequencia_Intervalo = ""
                shTipo_Break = ""
                intIDChave = ""
                strNumero_Fita = ""
                intChave_Acesso = ""
                strCod_Empresa = ""
                lngNumero_MR = ""
                shSequencia_MR = ""
                intDuracao = ""
                strCod_Comercial = ""
                strCod_Programa_Origem = ""
                strCod_Veiculo_Origem = ""
                shOrigem = ""
                shVersao = ""
                bEspacoCedido = False
                strCod_Programa = ""
                '==================Tranforma Fitas Artisticao em versao em 1 quando estiver salvando S.JOSE E SATELITE
                If bPermissaoArtistico And (ucveiculo.text = "001" Or ucveiculo.text = "076") Then
                    If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")) = "4" Then '  Fita Artistica
                        .set_TextMatrix(nRow, fColuna(flxBreak(0), "Versao"), "1")
                    End If
                End If
                ' Se For uma Linha de Titulo do Break, Zera o Contador de Posicoes
                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then
                    shPosicao = 0
                    shTempo = 0
                End If

                ' Se For uma Linha de Ordenacao e o Break nao Estiver em Branco
                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Titulo Break")) <> "1" And .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) <> "1" And Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Break"))) <> "" Then
                    strCod_Programa = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Codigo Programa")))

                    If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica_Titulo_Programa")) <> "1" Then
                        intDuracao = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Dur.")))
                        If InStr(intDuracao, ",") > 0 Then
                            intDuracao = VB.Left(intDuracao, InStr(intDuracao, ",") - 1)
                        End If

                        shPosicao = shPosicao + 1
                        shBreak = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Break")))
                        shSequencia_Faixa = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Sequencia Faixa")))
                        shSequencia_Intervalo = shPosicao
                        shTipo_Break = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Tipo Int. do Comercial")))
                        intIDChave = Trim(flxBreak(0).get_TextMatrix(nRow, fColuna(flxBreak(0), "Id Chave")))
                        strNumero_Fita = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Fita")))
                        intChave_Acesso = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Ch.Acesso")))
                        strCod_Empresa = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Empresa")))
                        lngNumero_MR = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Contrato")))
                        shSequencia_MR = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Seq")))
                        strCod_Comercial = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Com.")))
                        strCod_Programa_Origem = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Programa Origem")))
                        strCod_Veiculo_Origem = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Veiculo Origem")))
                        shVersao = Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Versao")))

                        Select Case Trim(.get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica_Espaco_Cedido")))
                            Case "", "0"
                                bEspacoCedido = False
                            Case "1"
                                bEspacoCedido = True
                            Case Else
                                bEspacoCedido = False
                        End Select

                        Select Case .get_TextMatrix(nRow, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
                            Case "1", "2", "5"
                                shOrigem = 0 'Midia
                            Case "3"
                                shOrigem = 1 ' Avulso
                            Case "4", "6"
                                shOrigem = 2 ' Artistico
                        End Select
                    End If


                    If shBreak = "" Then shBreak = "-1"
                    If shSequencia_Faixa = "" Then shSequencia_Faixa = "0"
                    If shSequencia_Intervalo = "" Then shSequencia_Intervalo = "0"
                    If shTipo_Break = "" Then shTipo_Break = "0"
                    If intIDChave = "" Then intIDChave = "-1"
                    If intChave_Acesso = "" Then intChave_Acesso = "-1"
                    If lngNumero_MR = "" Then lngNumero_MR = "-1"
                    If shSequencia_MR = "" Then shSequencia_MR = "-1"
                    If intDuracao = "" Then intDuracao = "0"
                    If shOrigem = "" Then shOrigem = "0"
                    If shVersao = "" Then shVersao = "0"

                    DtsRoteiro.dtbTbRSA_Roteiro.AdddtbTbRSA_RoteiroRow( _
                                sId_Processo, _
                                ucveiculo.text, _
                                DateTime.Parse(UcData.DateTime), _
                                strCod_Programa, _
                                Short.Parse(shBreak), _
                                Short.Parse(shSequencia_Faixa), _
                                Short.Parse(shSequencia_Intervalo), _
                                Short.Parse(shTipo_Break), _
                                Integer.Parse(intIDChave), _
                                strNumero_Fita, _
                                Integer.Parse(intChave_Acesso), _
                                strCod_Empresa, _
                                Long.Parse(lngNumero_MR), _
                                Short.Parse(shSequencia_MR), _
                                Integer.Parse(intDuracao), _
                                strCod_Comercial, _
                                strCod_Programa_Origem, _
                                strCod_Veiculo_Origem, _
                                Short.Parse(shOrigem), _
                                Short.Parse(shVersao), _
                                bEspacoCedido _
                            )

                    shTempo = shTempo + Integer.Parse(intDuracao)
                End If
            Next nRow
        End With
        AsmxRoteiro.spuGravar_Roteiro_Temp(DtsRoteiro)
        '================================================Chama o Metodo de Salva do Roteiro
        DtsRoteiro = AsmxRoteiro.spuSalvar_Roteiro(sId_Processo, gsUsuario)
        DtsRoteiro.dtbTbRSA_Roteiro.Clear()

        '================================================Carrega janela de Status
        nRow = 0
        lblMensagem.Tag = 0
        With flxStatus
            For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_CriticaRow In DtsRoteiro.dtbRoteiro_Critica.Select()
                nRow = nRow + 1
                If nRow > .Rows - 1 Then
                    .Rows = .Rows + 1
                End If
                '.FormatString = "Programa|Break|Pos|Mensagem|"
                .set_TextMatrix(nRow, 0, drw.Cod_Programa)
                If Not drw.IsBreaksNull Then .set_TextMatrix(nRow, 1, drw.Breaks)
                If Not drw.IsPosicaoNull Then .set_TextMatrix(nRow, 2, drw.Posicao)
                .Row = nRow
                If drw.Cod_Critica = 0 Then
                    .set_TextMatrix(nRow, 3, "Ordenação salva com sucesso")
                    .set_TextMatrix(nRow, 4, Chr(252))
                    nCor = Color.Blue
                    .Col = 4
                    .CellFontName = "WingDings"
                    .CellFontSize = 14
                    Me.AdicionaLog(drw.Cod_Veiculo, drw.Data_Exibicao, drw.Cod_Programa, , , , , , , , , , "Ordenação gravada com Sucesso")
                Else
                    .set_TextMatrix(nRow, 3, "Comercial não está mais disponivel para ordenação")
                    nCor = Color.Red
                    .set_TextMatrix(nRow, 4, Chr(251))
                    .Col = 4
                    .CellFontName = "WingDings"
                    .CellFontSize = 14

                    lblMensagem.Tag = 1
                    Me.AdicionaLog(drw.Cod_Veiculo, drw.Data_Exibicao, drw.Cod_Programa, , , , , , , , , , "Ordenação não gravada por inconsistências")
                End If
                For nCol = 0 To .Cols - 1
                    .Col = nCol
                    .ForeColor = nCor
                Next
            Next
            If .Rows < 12 Then .Rows = 12
        End With
        DtsRoteiro.dtbRoteiro_Critica.Clear()

        '================================================Grava o Log 
        AsmxRoteiroLog.spuGravar_Roteiro_Log(DtsRoteiroLog)
        DtsRoteiroLog.dtbRoteiroLog.Clear()
        '================================================Salva Baixa
        sMensagem = ""
        asmxBaixaVeiculacao.spuAtualizar(dtsBaixaVeiculacao)
        For Each drw As MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao.dtbBaixaRow In dtsBaixaVeiculacao.dtbBaixa.Rows
            sCritica = ""
            If drw.IsId_CriticaNull > -1 Then
                'X = dtsBaixaVeiculacao
                Dim drwCritica As MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao.dtbBaixa_CriticaRow()
                drwCritica = dtsBaixaCritica.dtbBaixa_Critica.Select("id_critica = " & drw.Id_Critica)
                sCritica = drwCritica(0).Critica_Descricao
                sMensagem = sMensagem & "Veiculo: " & drw.Cod_Veiculo.ToString & vbCrLf
                sMensagem = sMensagem & "Data: " & drw.Data_Exibicao.ToString & vbCrLf
                sMensagem = sMensagem & "Programa: " & drw.Cod_Programa.ToString & vbCrLf
                sMensagem = sMensagem & "Chave_Acesso: " & drw.Chave_Acesso.ToString & vbCrLf
                sMensagem = sMensagem & "Critica: " & sCritica & vbCrLf
                sMensagem = sMensagem & "Veiculação não foi Baixada" & vbCrLf & vbCrLf
            End If
        Next
        If sMensagem.Trim <> "" Then
            Aviso(sMensagem)
        End If
        dtsBaixaVeiculacao.Clear()

        If lblMensagem.Tag = 1 Then
            lblMensagem.Text = "As linhas em vermelho indicam  problemas durante a gravação. Favor Corrigir e salvar novamente."
        Else
            lblMensagem.Text = "Fim da Gravação do Roteiro"
        End If
        picStatus.Visible = True
        '================================================Finaliza
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        chkSalvar.Checked = False
Saida:
        Mensagem("")

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Exit Function
Erro:
        SalvaOrdenacao = False
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Function

    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Dim Index As Short = cmdCancela.GetIndex(eventSender)
        picCorte.Visible = False
    End Sub

    Private Sub cmdCarregar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCarregar.Click
        On Error GoTo Erro
        Dim nCont As Integer
        Dim nPorta As Integer
        Dim sStringPrograma As String
        'Call FDeletaPorta(AsmxPorta, 4)
        Dim nRoot As Integer
        Dim nChild As Integer
        '===============================Monta String com os Programas a serem ordenados
        sStringPrograma = ""
        With treBreak
            .BeginUpdate()
            For nRoot = 0 To .Nodes.Count - 1
                For nChild = 0 To .Nodes(nRoot).Nodes.Count - 1
                    If .Nodes(nRoot).Nodes(nChild).Checked Then
                        nPorta = FPorta(AsmxPorta, DtsPorta, 4, ucveiculo.text, UcData.DateTime, .Nodes(nRoot).Nodes(nChild).Text)
                        Select Case nPorta
                            Case 1, 4
                                Aviso("Não foi possivel carregar o programa " & .Nodes(nRoot).Nodes(nChild).Text & " porque existe outro usuário fazendo a ordenação")
                                .Nodes(nRoot).Nodes(nChild).Checked = False
                            Case 2
                                Aviso("Não foi possivel carregar o programa " & .Nodes(nRoot).Nodes(nChild).Text & " porque existe outro usuário fazendo composição de Breaks")
                                .Nodes(nRoot).Nodes(nChild).Checked = False
                            Case 3
                                Aviso("Não foi possivel carregar o programa " & .Nodes(nRoot).Nodes(nChild).Text & " porque existe outro usuário fazendo Pre-Ordenação")
                                .Nodes(nRoot).Nodes(nChild).Checked = False
                            Case Else
                                sStringPrograma = sStringPrograma & .Nodes(nRoot).Nodes(nChild).Text
                        End Select

                    End If
                    .Nodes(nRoot).Nodes(nChild).ForeColor = Color.Red
                Next
            Next
            Me.AsmxPorta.spuAtualizar(Me.DtsPorta)
            .EndUpdate()
        End With

        If sStringPrograma = "" Then
            Aviso("Nenhum Programa foi Selecionado")
            GoTo Saida
        End If
        '==========================================>Popula os Grid 
        picCorte.Tag = 0
        Call ConfiguraGridDepositorio(4)
        Call MostraRoteiroOrdenado(sStringPrograma)
        Call MostraDisponiveisComercial()
        Call MostraDisponiveisRotativo()
        Call MostraDisponiveisDepositorio(3)
        bCarregaArtistico = True
        Call MostraDisponiveisDepositorio(4)
        cmdRefresh.Visible = True
        cmdDadosComercial.Visible = True
        cmdDadosComercialOrdenado.Visible = True
        '=============================Mostra Comerciais cortados do Roteiro
        If CDbl(picCorte.Tag) = 1 Then
            If flxCorte.Rows < 11 Then flxCorte.Rows = 11
            picCorte.Visible = True
            picCorte.Tag = ""
        End If
        cmdCarregar.Enabled = False
        cmdMarcarTodos.Enabled = False
        treBreak.BeginUpdate()
        treBreak.CheckBoxes = False
        treBreak.ExpandAll()
        treBreak.EndUpdate()
Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub cmdDadosComercial_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDadosComercial.Click


        On Error GoTo Erro
        Dim nPasta As Short
        nPasta = tabDisponiveis.SelectedItem.Index

        With flxDisponivel(nPasta)
            If .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Comercial")) = "" Then
                GoTo Saida
            End If
            If .Row = 0 Then
                GoTo Saida
            End If

            Select Case nPasta
                Case 1 ' Comercial
                    If .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "guia")) <> "" Then GoTo Saida
                    frmRoteiroDados.txtVeiculo.Text = ucveiculo.text
                    frmRoteiroDados.txtData.Text = UcData.DateTime
                    frmRoteiroDados.txtPrograma.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Codigo Programa"))
                    frmRoteiroDados.txtChaveAcesso.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Ch.Acesso"))
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Fita"))
                    frmRoteiroDados.chkAlterarNumero.Checked = True
                    'If bUsuario_Net Then
                    frmRoteiroDados.chkAlterarNumero.Checked = False
                    'End If
                    frmRoteiroDados.chkMidia.Checked = True
                    frmRoteiroDados.ShowDialog()

                    If frmRoteiroDados.chkOk.Checked Then
                        .set_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Fita"), frmRoteiroDados.txtNumeroFita.Text)
                    End If

                Case 2, 5 ' Rotativo, Outros Programa
                    If .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "guia")) <> "" Then GoTo Saida
                    frmRoteiroDados.txtVeiculo.Text = ucveiculo.text
                    frmRoteiroDados.txtData.Text = UcData.DateTime
                    frmRoteiroDados.txtPrograma.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Codigo Programa"))
                    frmRoteiroDados.txtChaveAcesso.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Ch.Acesso"))
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Fita"))
                    frmRoteiroDados.chkAlterarNumero.Checked = True
                    frmRoteiroDados.chkMidia.Checked = True
                    frmRoteiroDados.ShowDialog()
                    If frmRoteiroDados.chkOk.Checked Then
                        .set_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Fita"), frmRoteiroDados.txtNumeroFita.Text)
                    End If
                Case 3 ' Depositorio Avulso
                    frmRoteiroDados.txtVeiculo.Text = ucveiculo.text
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Fita"))
                    frmRoteiroDados.txtIdFita.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "IdChave"))
                    frmRoteiroDados.chkAvulso.Checked = True
                    frmRoteiroDados.ShowDialog()
                Case 4 ' Depositorio Artistico
                    frmRoteiroDados.txtVeiculo.Text = ucveiculo.text
                    frmRoteiroDados.txtNumeroFita.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "Fita"))
                    frmRoteiroDados.txtIdFita.Text = .get_TextMatrix(.Row, fColuna(flxDisponivel(nPasta), "IdChave"))
                    frmRoteiroDados.chkArtistico.Checked = True
                    frmRoteiroDados.ShowDialog()
            End Select
            frmRoteiroDados.Dispose()
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub cmdDadosComercialOrdenado_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDadosComercialOrdenado.Click

        On Error GoTo Erro
        Dim nPasta As Short

        With flxBreak(0)
            nPasta = Val(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))) '  Indica de que pasta veio a ordenacao
            If nPasta = 0 Then
                GoTo Saida
            End If
            If Trim(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Veiculo Origem"))) <> "" Then
                frmRoteiroDados.txtVeiculo.Text = .get_TextMatrix(.Row, fColuna(flxBreak(0), "Veiculo Origem")) '  Veiculo Origem da Fita
            Else
                frmRoteiroDados.txtVeiculo.Text = ucveiculo.text
            End If

            Select Case nPasta
                Case 1, 2, 5 ' Comercial, Rotativo , Outros Programas
                    frmRoteiroDados.txtData.Text = UcData.DateTime
                    frmRoteiroDados.txtPrograma.Text = .get_TextMatrix(.Row, fColuna(flxBreak(0), "Programa Origem"))
                    frmRoteiroDados.txtChaveAcesso.Text = .get_TextMatrix(.Row, fColuna(flxBreak(0), "Ch.Acesso"))
                    frmRoteiroDados.txtNumeroFita.Text = Trim(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Fita")))
                    'If bUsuario_Net Then
                    'frmRoteiroDados.chkAlterarNumero.Checked = false 
                    'End If
                    frmRoteiroDados.chkMidia.Checked = True
                    frmRoteiroDados.ShowDialog()
                    If frmRoteiroDados.chkOk.Checked Then
                        .set_TextMatrix(.Row, fColuna(flxBreak(0), "Fita"), frmRoteiroDados.txtNumeroFita.Text)
                    End If
                Case 3 ' Depositorio Avulso

                    frmRoteiroDados.txtNumeroFita.Text = Trim(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Fita")))
                    frmRoteiroDados.txtIdFita.Text = Trim(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Id Chave")))
                    frmRoteiroDados.chkAvulso.Checked = True
                    frmRoteiroDados.cmdOk.Enabled = False
                    frmRoteiroDados.ShowDialog()
                Case 4 ' Depositorio Artistico
                    frmRoteiroDados.txtNumeroFita.Text = Trim(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Fita")))
                    frmRoteiroDados.txtIdFita.Text = Trim(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Id Chave")))
                    frmRoteiroDados.chkArtistico.Checked = True
                    frmRoteiroDados.cmdOk.Enabled = False
                    frmRoteiroDados.ShowDialog()
            End Select
            frmRoteiroDados.Dispose()
        End With
Saida:
        System.Windows.Forms.Cursor.Current = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub cmdMarcarTodos_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMarcarTodos.CheckStateChanged
    End Sub

    Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
        bCarregaArtistico = True
        Select Case tabDisponiveis.SelectedItem.Index
            Case 1
                Call MostraDisponiveisComercial()
            Case 2, 5
                Call MostraDisponiveisRotativo()
            Case 3
                Call MostraDisponiveisDepositorio(3)
            Case 4
                Call MostraDisponiveisDepositorio(4)
        End Select
    End Sub

    Private Sub cmdStatusOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStatusOk.Click
        Dim Index As Short = cmdStatusOk.GetIndex(eventSender)
        picStatus.Visible = False
    End Sub

    Private Sub flxBreak_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles flxBreak.ClickEvent
    End Sub

    Private Sub flxBreak_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxBreak.DblClick
        cmdDadosComercialOrdenado_Click(cmdDadosComercialOrdenado, New System.EventArgs())
    End Sub

    'UPGRADE_ISSUE: VBControlExtender event | was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
    Private Sub Break_DragDrop(ByRef Source As AxMSFlexGridLib.AxMSFlexGrid)
        On Error GoTo Erro
        Dim sProduto As String = ""
        Dim nIndica_Grade As Short
        Dim bTipoDiferente As Boolean
        Dim sMensagem As String = ""
        Dim sProgramaOrigem As String = ""
        Dim sProgramaDestino As String = ""

        Dim bRotativo As Boolean

        Dim sHorarioOrigemInicio As String
        Dim sHorarioOrigemFim As String
        Dim sHorarioDestinoInicio As String
        Dim sHorarioDestinoFim As String

        Dim iHorarioOrigemInicio As Integer = 0
        Dim iHorarioOrigemFim As Integer = 0
        Dim iHorarioDestinoInicio As Integer = 0
        Dim iHorarioDestinoFim As Integer = 0

        'Source.Drag(vbCancel)
        txtMensagem.Visible = False
        bIndicaMudancaPosicao = False

        '==============================================>Se Nao pode jogar o comercial nesta linha, sai
        'If Source.DragIcon = picDragNo.Image Then
        ' GoTo Saida
        ' End If
        '========================> Se esta arrastando dentro do grid de break e esta jogando na mesma linha, nao faz nada
        If Source.Name = _flxBreak_0.Name Then
            If nLinhadestino = nLinhaOrigem Or nLinhadestino = nLinhaOrigem - 1 Then
                GoTo Saida
            End If
            bIndicaMudancaPosicao = True
        End If
        '========================> Guarda dados necessários
        bRotativo = False
        sProgramaOrigem = ""
        sHorarioDestinoFim = ""
        sHorarioDestinoInicio = ""
        sHorarioOrigemFim = ""
        sHorarioOrigemInicio = ""


        iHorarioDestinoFim = 0
        iHorarioDestinoInicio = 0
        iHorarioOrigemFim = 0
        iHorarioOrigemInicio = 0

        With Source
            'Select Case Source.Index
            Select Case Source.Name
                Case _flxBreak_0.Name  ' Veio do Grid de Break
                    'Se esta apenas removendo dentro do proprio break deixa o produto em branco para nao dar o choque de concorrencia
                    If Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Break"))) = Val(.get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Break"))) Then

                        sProduto = ""
                        nIndica_Grade = -1
                    Else
                        sProduto = .get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Produto"))
                        nIndica_Grade = Val(.get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Indica Grade")))
                    End If
                    sProgramaOrigem = Trim(.get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Codigo Programa")))
                    If .get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")) = "2" Then
                        bRotativo = True
                        sHorarioOrigemInicio = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Horario Inicio Comercial Rotativo"))
                        sHorarioOrigemFim = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Horario Fim Comercial Rotativo"))

                    End If
                Case _flxDisponivel_1.Name, _flxDisponivel_5.Name ' 1, 5 ' Veio do Grid Comercial
                    sProduto = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Cod Produto"))
                    nIndica_Grade = Val(.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Indica Grade")))
                    sProgramaOrigem = Trim(.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Codigo Programa")))
                Case _flxDisponivel_2.Name   '2 '  Veio do Grid Rotativo,Outros Programa
                    sProduto = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Cod Produto"))
                    nIndica_Grade = Val(.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Indica Grade")))
                    sProgramaOrigem = Trim(.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Codigo Programa")))
                    sHorarioOrigemInicio = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Horario Inicio"))
                    sHorarioOrigemFim = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Horario Fim"))
                    bRotativo = True
                Case _flxDisponivel_3.Name ' 3 'Veio do Grid de Depositorio Avulso
                    sProduto = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Produto"))
                    sProgramaOrigem = Trim(.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Codigo Programa")))
                    Select Case .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Tipo do Break"))
                        Case "0" 'Comercial Avulso Net
                            nIndica_Grade = 0
                        Case "1" ' Comercial Avulso Pe
                            nIndica_Grade = 3
                        Case "2" 'Comercial Avulso Local
                            nIndica_Grade = 1
                        Case Else ' Nenhum
                            nIndica_Grade = -1
                    End Select
                Case _flxDisponivel_4.Name, _flxDisponivel_6.Name   '4, 6 ' Veio do Grid de Depositorio Artistico
                    sProgramaOrigem = Trim(.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Codigo Programa")))
                    sProduto = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Produto"))
                    nIndica_Grade = -1
            End Select
        End With


        '========================>Mensagem de choque de Concorrencia
        If fConcorrente(nLinhadestino, sProduto) Then
            GoTo Saida
        End If

        '========================> Mensagem de Rotativo Fora de Faixa
        If bRotativo Then
            sHorarioDestinoInicio = flxBreak(0).get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Horario Inicio"))
            sHorarioDestinoFim = flxBreak(0).get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Horario Fim"))



            sHorarioDestinoFim = VB6.Format(sHorarioDestinoFim, "yyyy-mm-dd hh:mm:ss")
            sHorarioDestinoInicio = VB6.Format(sHorarioDestinoInicio, "yyyy-mm-dd hh:mm:ss")
            sHorarioOrigemFim = VB6.Format(sHorarioOrigemFim, "yyyy-mm-dd hh:mm:ss")
            sHorarioOrigemInicio = VB6.Format(sHorarioOrigemInicio, "yyyy-mm-dd hh:mm:ss")

            iHorarioDestinoFim = 60 * (DatePart(DateInterval.Hour, DateTime.Parse(sHorarioDestinoFim))) + DatePart(DateInterval.Minute, DateTime.Parse(sHorarioDestinoFim))
            iHorarioDestinoInicio = 60 * (DatePart(DateInterval.Hour, DateTime.Parse(sHorarioDestinoInicio))) + DatePart(DateInterval.Minute, DateTime.Parse(sHorarioDestinoInicio))
            iHorarioOrigemFim = 60 * (DatePart(DateInterval.Hour, DateTime.Parse(sHorarioOrigemFim))) + DatePart(DateInterval.Minute, DateTime.Parse(sHorarioOrigemFim))
            iHorarioOrigemInicio = 60 * (DatePart(DateInterval.Hour, DateTime.Parse(sHorarioOrigemInicio))) + DatePart(DateInterval.Minute, DateTime.Parse(sHorarioOrigemInicio))

            If iHorarioOrigemFim < iHorarioOrigemInicio Then iHorarioOrigemFim += 1440
            If iHorarioDestinoFim < iHorarioDestinoInicio Then iHorarioDestinoFim += 1440

            If Not Between(iHorarioOrigemInicio, iHorarioDestinoInicio, iHorarioDestinoFim) And Not Between(iHorarioOrigemFim, iHorarioDestinoInicio, iHorarioDestinoFim) And Not Between(iHorarioDestinoInicio, iHorarioOrigemInicio, iHorarioOrigemFim) And Not Between(iHorarioDestinoFim, iHorarioOrigemInicio, iHorarioOrigemFim) Then

                sMensagem = "Comercial Rotativo não se enquadra no horário do Programa."
                sMensagem = sMensagem & vbCrLf & "Deseja ordenar mesmo assim?"
                If MsgBox(sMensagem, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Atenção") = MsgBoxResult.No Then
                    GoTo Saida
                End If
            End If
        End If

        '========================> Mensagem de Ordenacao em Programa Diferente
        sProgramaDestino = flxBreak(0).get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Codigo Programa"))
        If sProgramaOrigem <> "" And Not bRotativo And sProgramaOrigem <> sProgramaDestino Then
            sMensagem = "Comercial não pertence a este Programa."
            sMensagem = sMensagem & vbCrLf & "Deseja ordenar mesmo assim?"
            If MsgBox(sMensagem, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Atenção") = MsgBoxResult.No Then
                GoTo Saida
            End If
        End If
        '========================> Mensagem de Ordenacao em Tipo de Break Diferente (Comercial)
        If nIndica_Grade > -1 Then
            Select Case nIndica_Grade
                Case 0
                    If flxBreak(0).get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo")) <> "1" Then bTipoDiferente = True
                    sMensagem = "Comercial NET está sendo ordenado em Intervalo diferente de NET"
                Case 1, 2
                    If flxBreak(0).get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo")) <> "0" Then bTipoDiferente = True
                    sMensagem = "Comercial LOCAL está sendo ordenado em Intervalo diferente de Local"
                Case 3
                    If flxBreak(0).get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo")) <> "3" Then bTipoDiferente = True
                    sMensagem = "Comercial PE está sendo ordenado em Intervalo diferente de PE"
            End Select
        End If

        '========================> Mensagem de Ordenacao em Tipo de Break Diferente (Avulso)
        If bTipoDiferente Then
            'If flxBreak(0).TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Break")) > "0" Then '  nao consiste para interprograma
            sMensagem = sMensagem & vbCrLf & "Confirma a Ordenação ? "
            If MsgBox(sMensagem, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Atenção") = MsgBoxResult.No Then
                GoTo Saida
            End If
            'End If
        End If


        '========================> Conclui a Ordenacao
        chkSalvar.CheckState = System.Windows.Forms.CheckState.Checked
        flxBreak(0).Redraw = False
        nLinhadestino = nLinhadestino + 1 ' Joga na Linha de baixa da primeira linha preenchida

        Call InsereGridBreak(Source) ' Insere Ordenacao no Grid de Roteiro
        Call RemoveLinha(Source, nLinhaOrigem) ' Remove a Linha de onde foi arrastado
        'Call MostraTotal(nLinhadestino)        ' Atualiza os Totalizadores

Saida:
        flxBreak(0).Redraw = True
        'Source.Drag(vbCancel)
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub InsereGridBreak(ByRef Par_Flex As AxMSFlexGridLib.AxMSFlexGrid)

        On Error GoTo Erro
        Dim nCol As Short
        Dim nLinhaBreak As Short
        Dim NlinhaIntervalo As Short
        Dim nForecolor As System.Drawing.Color
        Dim sOperacao As String = ""
        Dim nColunaDestino As Short
        Dim nColunaOrigem As Short

        With flxBreak(0)

            .AddItem("", nLinhadestino)

            If Par_Flex.Name = _flxBreak_0.Name And nLinhadestino < nLinhaOrigem Then
                nLinhaOrigem = nLinhaOrigem + 1 ' Se adicionou uma linha vazia desloca a linha origem 1 posicao p/baixo
            End If

            For nCol = 0 To Par_Flex.Cols - 1
                If Par_Flex.get_ColData(nCol) <> 0 Then
                    .set_TextMatrix(nLinhadestino, Par_Flex.get_ColData(nCol), Par_Flex.get_TextMatrix(nLinhaOrigem, nCol))
                End If
            Next nCol
            Call CalculaAlturaLinha(flxBreak(0), nLinhadestino, fColuna(flxBreak(0), "Comercial"))

            '  Copia alguns dados da linha anterior
            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Break"), .get_TextMatrix(nLinhadestino - 1, fColuna(flxBreak(0), "Break"))) ' Numero do Break
            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo"), .get_TextMatrix(nLinhadestino - 1, fColuna(flxBreak(0), "Tipo Intervalo"))) ' Tipo de Intervalo do comercial
            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Indica se Permite Ordenacao"), .get_TextMatrix(nLinhadestino - 1, fColuna(flxBreak(0), "Indica se Permite Ordenacao"))) ' Indica de pode ordenar
            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Sequencia Faixa"), .get_TextMatrix(nLinhadestino - 1, fColuna(flxBreak(0), "Sequencia Faixa"))) ' Sequencia Faixa
            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Codigo Programa"), .get_TextMatrix(nLinhadestino - 1, fColuna(flxBreak(0), "Codigo Programa"))) ' Codigo do programa
            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Horario Inicio"), .get_TextMatrix(nLinhadestino - 1, fColuna(flxBreak(0), "Horario Inicio"))) ' Codigo do programa
            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Horario Fim"), .get_TextMatrix(nLinhadestino - 1, fColuna(flxBreak(0), "Horario Fim"))) ' Codigo do programa

            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Int. do Comercial"), .get_TextMatrix(nLinhadestino - 1, fColuna(flxBreak(0), "Tipo Intervalo"))) ' Tipo de Intervalo

            Select Case .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")) '  Verifica ordenado em tipos de breaks diferentes
                Case "1", "2", "5"
                    If .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Indica Grade")) = "0" Then
                        .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Int. do Comercial"), "1")
                    Else
                        .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Int. do Comercial"), "0")
                    End If
                Case CStr(3)
                    Select Case .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo do Break da Fita"))
                        Case CStr(0)
                            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Int. do Comercial"), "1")
                        Case CStr(2)
                            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Int. do Comercial"), "0")
                        Case Else
                            ' Nao Muda e herda o tipo do intervalo
                    End Select
            End Select

            '-------------Mostra a Origem da Ordenacao
            .Row = nLinhadestino
            .Col = 3
            .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            .CellFontBold = True
            .set_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Enc."), aOrigem(Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")))))

            ' Coloca cor no Comercial
            nForecolor = Color.Black

            Select Case .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Int. do Comercial"))
                Case "0" ' Local ou PE
                    nForecolor = Color.Blue
                Case "1" ' Net
                    nForecolor = Color.Magenta
                Case "2" ' Artistico
                    nForecolor = Color.Green
                Case "3"
                    nForecolor = Color.Red
            End Select


            '-------------Se for avulso PE, fica sempre em vermlho
            If Par_Flex.Name = _flxDisponivel_3.Name Then
                If Val(Par_Flex.get_TextMatrix(nLinhaOrigem, fColuna(Par_Flex, "Tipo do Break"))) = 1 Then 'o povo quer que PE fique vermelho,sem abertura para dialogo
                    nForecolor = Color.Red
                End If
            End If

            '-------------Se for Diferenciado fica roxo 

            If Val(Par_Flex.get_TextMatrix(nLinhaOrigem, fColuna(Par_Flex, "Diferenciado"))) = 1 And bolMostraDiferenciado Then
                nForecolor = Color.Purple
            End If

            '=================================================>Status
            Call CorGrid(flxBreak(0), nLinhadestino, nForecolor, 1)
            Call SomaBreak(nLinhadestino, Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Dur."))))
            Call NumeraLinha(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Codigo Programa")), CShort(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Break"))))
            '=================================================>Grava o Log

            If Par_Flex.Name = _flxBreak_0.Name Then
                sOperacao = "Mudança de Posicao: "
                sOperacao = sOperacao & "(Br." & .get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Break"))
                sOperacao = sOperacao & " Pos." & .get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "")) & "->"
                sOperacao = sOperacao & "Br." & .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Break"))
                sOperacao = sOperacao & " Pos." & .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "")) & ")"
            Else
                Select Case .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
                    Case "1"
                        sOperacao = "Inserção de Comercial"
                    Case "2"
                        sOperacao = "Inserção de Comercial Rotativo"
                    Case "3"
                        sOperacao = "Inserção de Comercial Avulso"
                    Case "4"
                        sOperacao = "Inserção de Comercial Artistico"
                    Case "5"
                        sOperacao = "Inserção de Comercial de Outro Programa"
                    Case "6"
                        sOperacao = "Inserção AR não replicado"
                End Select
                sOperacao = sOperacao & " (Break." & .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Break")) & ")"

            End If
            Me.AdicionaLog(ucVeiculo.Text, UcData.DateTime, .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Codigo Programa")), .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Com.")), Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Break"))), Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo"))), .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Fita")), .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Comercial")), .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Empresa")), Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Contrato"))), Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Seq"))), Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Ch.Acesso"))), sOperacao, Me.Name)
        End With

Saida:
        Exit Sub
Erro:
        Me.FinalizaDrapDrop()
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub





    Private Sub SomaBreak(ByRef Par_Linha As Short, ByRef Par_Duracao As Short)

        On Error GoTo Erro
        Dim nLinhaBreak As Short
        Dim NlinhaIntervalo As Short
        Dim nLinhaArtistico As Short

        Dim nRow As Short
        Dim nCor As Integer

        With flxBreak(0)
            .Redraw = False

            ' Acha a Linha do Break
            nLinhaBreak = 0
            For nRow = Par_Linha To 1 Step -1
                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then
                    nLinhaBreak = nRow
                    Exit For
                End If
            Next nRow

            ' Acha a Linha do Intervalo
            NlinhaIntervalo = 0
            For nRow = Par_Linha To 1 Step -1
                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) = "1" Then
                    NlinhaIntervalo = nRow
                    Exit For
                End If
            Next nRow

            ' Se for comercial Artistico, Soma na Linha de Artistico
            ' e nao soma nos intervalo e Break
            nLinhaArtistico = 0
            If .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")) = "4" Then
                nLinhaArtistico = nLinhaBreak + 1
                NlinhaIntervalo = 0
            End If

            'Se For Inter Programa - Acumula somente na Linha de Break (Primeira Linha)
            'If .TextMatrix(Par_Linha, fColuna(flxBreak(0), "Break")) = "0" Then
            '   nLinhaBreak = 1
            '   nLinhaArtistico = 0
            'End If

            'Acumula no Intervalo
            If NlinhaIntervalo <> 0 Then
                .set_TextMatrix(NlinhaIntervalo, fColuna(flxBreak(0), "Enc."), Val(.get_TextMatrix(NlinhaIntervalo, fColuna(flxBreak(0), "Enc."))) + Par_Duracao)
            End If

            'Acumula no Break
            If nLinhaBreak <> 0 Then
                .set_TextMatrix(nLinhaBreak, fColuna(flxBreak(0), "Enc."), Val(.get_TextMatrix(nLinhaBreak, fColuna(flxBreak(0), "Enc."))) + Par_Duracao)
            End If

            If nLinhaArtistico <> 0 Then
                .set_TextMatrix(nLinhaArtistico, fColuna(flxBreak(0), "Enc."), Val(.get_TextMatrix(nLinhaArtistico, fColuna(flxBreak(0), "Enc."))) + Par_Duracao)
                Call CorStatus(nLinhaArtistico)
            End If

            Call CorStatus(nLinhaBreak)
            Call CorStatus(NlinhaIntervalo)
            Call CorStatus(nLinhaArtistico)

        End With
Saida:
        flxBreak(0).Redraw = True
        Exit Sub
Erro:
        Me.FinalizaDrapDrop()
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub CorStatus(ByRef Par_Linha As Short)

        On Error GoTo Erro
        Dim nBackcolor As Drawing.Color
        Dim intDispo As Integer
        Dim intEncaixe As Integer

        With flxBreak(0)
            '.Redraw = False
            If Par_Linha = 0 Then
                GoTo Saida
            End If

            If .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Dur.")) <> "" Then
                intDispo = Integer.Parse(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Dur.")))
            End If
            If .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Enc.")) <> "" Then
                intEncaixe = Integer.Parse(.get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Enc.")))
            End If

            'If .TextMatrix(Par_Linha, fColuna(flxBreak(0), "Break")) = "0" Then ' Inter nao precisa Status
            ' GoTo Saida
            ' End If

            'If .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then ' Linha do Break
            'nBackcolor = Color.Gray
            'Else
            'nBackcolor = Color.White
            'End If
            '

            '  Verifica se preencheu todo o espaco
            .Row = Par_Linha
            .Col = fColuna(flxBreak(0), "")
            .CellFontName = "Wingdings"
            .CellFontSize = 14

            If intDispo = intEncaixe Then
                .CellBackColor = .CellForeColor
                If .get_TextMatrix(Par_Linha, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then
                    .CellBackColor = Color.White
                    .CellForeColor = Color.Blue
                    '.set_TextMatrix(Par_Linha, fColuna(flxBreak(0), ""), Chr(252))
                End If

            ElseIf intEncaixe > intDispo Then
                .CellBackColor = Color.Red
                .set_TextMatrix(Par_Linha, fColuna(flxBreak(0), ""), "")
            Else
                .CellBackColor = nBackcolor
                .set_TextMatrix(Par_Linha, fColuna(flxBreak(0), ""), "")
            End If

        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Function Break_ValidaDrag(ByRef Source As AxMSFlexGridLib.AxMSFlexGrid) As Boolean

        On Error GoTo Erro
        Dim bValido As Boolean = True
        Dim sCritica As String = ""

        Dim nIndica_Grade As Short
        Dim nIndicaArtistico As Short

        With flxBreak(0)
            nLinhadestino = .MouseRow
            ' Se for Linha 0 , nao pode

            If nLinhadestino = 0 Then
                bValido = False
                GoTo Saida
            End If

            If Source.Row = 0 Then
                bValido = False
                GoTo Saida
            End If

            ' Se for InterPrograma,  pode
            'If .TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Break")) = "0" Then
            '   bValido = True
            '   GoTo Saida
            'End If

            '  Nao pode jogar no grid vazio
            If Trim(.get_TextMatrix(1, 1)) = "" Then
                bValido = False
                GoTo Saida
            End If


            '  Nao pode jogar na Linha do Titulo de Break
            If .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then
                bValido = False
                GoTo Saida
            End If

            '  Nao pode jogar na Linha do Titulo de Programa
            If .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Indica_Titulo_Programa")) = "1" Then
                bValido = False
                GoTo Saida
            End If

            'Se a Linha estiver vazia, considera a primeira linha acima preenchida
            For nCont = nLinhadestino To 1 Step -1
                'FIXIT: Replace 'Trim' function with 'Trim$' function                                      FixIT90210ae-R9757-R1B8ZE
                If Trim(.get_TextMatrix(nCont, fColuna(flxBreak(0), "Comercial"))) <> "" Then
                    nLinhadestino = nCont
                    Exit For
                End If
            Next nCont

            'Se o Parametro do Roteiro Nao permite ordenacao, não pode
            If .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Indica se Permite Ordenacao")) = "0" Then
                bValido = False
                GoTo Saida
            End If


            '  Nao pode jogar na Linha do Titulo de Intervalo Artistico
            If .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) = "1" And .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo")) = "2" Then
                bValido = False
                GoTo Saida
            End If



            If Source.Name = _flxBreak_0.Name And nLinhadestino = nLinhaOrigem Then
                GoTo Saida
            End If

            '  Consiste o Tipo de Grade com o Tipo de Intervalo
            '  Se Veio da Pasta de Comerciai,Rotativo ou Inter Programa ou
            '  Arrastando dentro da Ordenacao
            '  Indica_grade 0 = somente pode em intervalo NET
            '  Indica grade 1 ou 2 ' Pode em Intervalo que nao seja net

            nIndica_Grade = -1
            nIndicaArtistico = 0

            If Source.Name = _flxBreak_0.Name Then
                Select Case .get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
                    Case "1", "2", "5" ' Comercial,Rotativo ou Outros Programas
                        nIndica_Grade = Val(Source.get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Indica Grade")))
                        nIndicaArtistico = 0
                    Case "4", "6" ' Artistico
                        nIndicaArtistico = 1
                        nIndica_Grade = -1
                    Case "3" ' Avulso
                        nIndicaArtistico = 0
                        nIndica_Grade = -1
                End Select
            End If


            If Source.Name = _flxDisponivel_1.Name Or _
                Source.Name = _flxDisponivel_2.Name Or _
                Source.Name = _flxDisponivel_3.Name Or _
                Source.Name = _flxDisponivel_4.Name Or _
                Source.Name = _flxDisponivel_5.Name Or _
                Source.Name = _flxDisponivel_6.Name Then

                If Source.Name = _flxDisponivel_1.Name Or _
                    Source.Name = _flxDisponivel_2.Name Or _
                    Source.Name = _flxDisponivel_5.Name Then

                    nIndica_Grade = Val(Source.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Indica Grade")))
                End If

                Select Case Source.Name
                    Case _flxDisponivel_1.Name, _flxDisponivel_2.Name, _flxDisponivel_5.Name 'Comercial,Rotativo ou Outros Programas
                        nIndica_Grade = Val(Source.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Indica Grade")))
                        nIndicaArtistico = 0
                    Case _flxDisponivel_3.Name, _flxDisponivel_4.Name, _flxDisponivel_6.Name 'Artistico ou avulso
                        nIndicaArtistico = 1
                        nIndica_Grade = -1 '  Avulso
                End Select
            End If


            'Select Case nIndica_Grade
            '   Case 0
            '      If Val(.TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo"))) <> 1 Then
            '         bValido = False
            '         GoTo Saida
            '      End If
            '   Case 1, 2
            '      If Val(.TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo"))) = 1 Then
            '         bValido = False
            '         GoTo Saida
            '      End If
            'End Select


            If Not bOrdenarNet Then
                If .get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Intervalo")) = "1" Then
                    If Not bPermissaoArtistico Then
                        bValido = False
                    End If
                End If
            End If

            If Not bPermissaoBreakDiferente Then
                Select Case nIndica_Grade
                    Case 0
                        If Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Int. do Comercial"))) <> 1 Then
                            bValido = False
                            GoTo Saida
                        End If
                    Case 1, 2
                        If Val(.get_TextMatrix(nLinhadestino, fColuna(flxBreak(0), "Tipo Int. do Comercial"))) = 1 Then
                            bValido = False
                            GoTo Saida
                        End If
                End Select
            End If

        End With

Saida:
        Break_ValidaDrag = bValido
        Exit Function
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Function


    Private Sub flxBreak_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxBreak.MouseDownEvent
        On Error GoTo Erro
        Dim Index As Short = flxBreak.GetIndex(eventSender)

        If bDragDrop Then
            GoTo saida
        End If

        bIndicaMudancaPosicao = False
        Dim nForecolor As System.Drawing.Color
        Dim nGuardaLinha As Short
        Dim bValido As Boolean
        Dim sMensagemConfirmacao As String
        Dim sDePara As String = ""
        Dim bAlteraBreak As Boolean
        Dim sPrograma As String = ""
        txtTipoIntervalo.Text = ""

        '=====================================Botao direito
        If eventArgs.button = 2 Then
            With flxBreak(0)
                .Row = .MouseRow
                nGuardaLinha = .Row
                If .Row = 0 Then
                    GoTo Saida
                End If

                '=======================================Alteracao do Tempo de Break
                If bPermissaoComposicaoBreak Then
                    If .get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Then
                        'Popupmenu(frmGeral.mnuRoteiroBreak)
                        'bAlteraBreak = frmGeral.chkAlteraBreakOk.Value = System.Windows.Forms.CheckState.Checked
                        'frmGeral.DISPOSE()
                        If bAlteraBreak Then

                            'frmRoteiro_Break.txtVeiculo.text = ucveiculo.text
                            'frmRoteiro_Break.txtData = UcData.DateTime
                            'sPrograma = flxBreak(0).get_TextMatrix(flxBreak(0).Row, fColuna(flxBreak(0), "codigo programa"))
                            'frmRoteiro_Break.txtPrograma = sPrograma
                            'frmRoteiro_Break.chkMostrar.Value = 1
                            'frmRoteiro_Break.txtForm = Me.Name
                            'frmRoteiro_Break.Show(1)

                            .Visible = False
                            For nCont = 0 To .Rows - 1
                                If .get_TextMatrix(nCont, fColuna(flxBreak(0), "Codigo programa")) = sPrograma And (.get_TextMatrix(nCont, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Or .get_TextMatrix(nCont, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) = "1") Then
                                    Call CorStatus(nCont)
                                End If
                            Next nCont
                            .Visible = True
                            .Row = nGuardaLinha
                        End If
                    End If

                End If
                '=======================================Alteracao do Tipo de Intervalo
                If .get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica Titulo Break")) <> "1" And .get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) <> "1" Then
                    bValido = True
                    '=======================================Verifica se o Usuario pode alterar o parametro do Comercial
                    Select Case .get_TextMatrix(.Row, fColuna(flxBreak(0), "Pasta Origem da Ordenacao")) '  pasta origem
                        Case "1", "2", "3", "5" ' comercial , rotativo, avulso e outros programas
                            If Not bPermissaoComercial Then bValido = False
                        Case "4", "6" ' Artistico e artistico nao replicado
                            If Not bPermissaoArtistico Then bValido = False
                    End Select

                    If Not bPermissaoBreakDiferente Then bValido = False

                    Select Case .get_TextMatrix(.Row, fColuna(flxBreak(0), "Tipo Int. do Comercial"))
                        Case "0"
                            sDePara = "Confirma a Mudança De Local Para Net"
                            'frmGeral.mnuALterarTipoBreak.Caption = "Tranformar em Net"
                        Case "1"
                            sDePara = "Confirma a Mudança De Net para Local"
                            'frmGeral.mnuALterarTipoBreak.Caption = "Tranformar em Local"
                    End Select

                    If Not bValido Then
                        GoTo Saida
                        'frmGeral.mnuALterarTipoBreak.Enabled = False
                    End If


                    'Popupmenu(frmGeral.mnuRoteiro)

                    'frmGeral.DISPOSE()

                    If txtTipoIntervalo.Text = "" Or Not bValido Then
                        txtTipoIntervalo.Text = ""
                        GoTo Saida
                    End If

                    sMensagemConfirmacao = "Comercial:" & .get_TextMatrix(.Row, fColuna(flxBreak(0), "Comercial")) & vbCrLf
                    sMensagemConfirmacao = sMensagemConfirmacao & "Fita:" & .get_TextMatrix(.Row, fColuna(flxBreak(0), "Fita")) & vbCrLf
                    sMensagemConfirmacao = sMensagemConfirmacao & "Duracao:" & .get_TextMatrix(.Row, fColuna(flxBreak(0), "Dur.")) & vbCrLf
                    sMensagemConfirmacao = sMensagemConfirmacao & sDePara

                    If MsgBox(sMensagemConfirmacao, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Atenção") = MsgBoxResult.No Then
                        GoTo Saida
                    End If

                    .set_TextMatrix(.Row, fColuna(flxBreak(0), "Tipo Int. do Comercial"), txtTipoIntervalo.Text)
                    Select Case txtTipoIntervalo.Text
                        Case "0", "3" ' Local ou PE
                            nForecolor = Color.Blue
                        Case "1" ' Net
                            nForecolor = Color.Magenta
                        Case "2" ' Artistico
                            nForecolor = Color.Green
                    End Select
                    .Visible = False
                    Call CorGrid(flxBreak(0), .Row, nForecolor, 1)
                    .Visible = True
                End If

            End With
            GoTo Saida
        End If

        '=================================botao esquerdo Inicia o DragDrop com Origem de Break
        With flxBreak(0)
            .Row = .MouseRow
            nLinhaOrigem = .Row
            If .Row = 0 Then
                GoTo Saida
            End If

            If .get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica Titulo Break")) = "1" Or .get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) = "1" Or .get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica_Titulo_Programa")) = "1" Then ' Linhas de titulo do Break , Intervalo ou programa
                GoTo Saida
            End If
            If Trim(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Dur."))) = "" Then
                GoTo Saida
            End If
            If Trim(.get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica se Permite Ordenacao"))) = "0" Then ' Nao Permite ordenacao
                GoTo Saida
            End If
            '---------------Verifica se usuario pode mexer em Comercial NET
            If Not bOrdenarNet Then
                Select Case .get_TextMatrix(.Row, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
                    Case "1", "2", "5"
                        If .get_TextMatrix(.Row, fColuna(flxBreak(0), "Tipo Int. do Comercial")) = "1" Then GoTo Saida
                    Case Else
                End Select
            End If

            '---------------Verifica a Origem do Comercial para saber se o Usuario pode ou Nao remover a linha
            Select Case .get_TextMatrix(.Row, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
                Case "1" '------Comercial Normal
                    If Not bPermissaoComercial Then GoTo Saida
                Case "2" '------Comercial Rotativo
                    If Not bPermissaoComercial Then GoTo Saida
                Case "3" '------Comercial Avulso
                    If Not bPermissaoComercial Then GoTo Saida
                Case "4", "6" '------Comercial Artistico
                    If Not bPermissaoArtistico Then GoTo Saida
                Case "5" '------Comercial Normal
                    If Not bPermissaoComercial Then GoTo Saida
            End Select
            flexDrag = flxBreak(0)
            Call IniciaDragDrop()
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub flxBreak_MouseMoveEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseMoveEvent) Handles flxBreak.MouseMoveEvent

        lblCoordenadas.Text = "X=" & System.Windows.Forms.Cursor.Position.X.ToString & "   Y=" & System.Windows.Forms.Cursor.Position.Y
        Dim Index As Short = flxBreak.GetIndex(eventSender)
        On Error GoTo Erro
        '===========================================Conclui o Dradrop de origem dos comerciais
        If bDragDrop Then
            If flexDrag.Name <> _flxBreak_0.Name Then
                If Break_ValidaDrag(flexDrag) Then
                    Call Break_DragDrop(flexDrag)
                End If
                FinalizaDrapDrop()
            End If
        End If
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub
    Private Sub flxBreak_MouseUpEvent(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_MouseUpEvent) Handles flxBreak.MouseUpEvent
        On Error GoTo Erro
        Dim nXmin As Integer = 0
        Dim nXmax As Integer = 0
        Dim nYmin As Integer
        Dim nYmax As Integer


        Dim WindowsX As Integer = 0
        Dim WindowsY As Integer = 0
        WindowsX = System.Windows.Forms.Cursor.Position.X
        WindowsY = System.Windows.Forms.Cursor.Position.Y




        nXmin = picBreak.Left + flxBreak(0).Left
        nXmax = picBreak.Left + flxBreak(0).Left + flxBreak(0).Width
        nYmin = picBreak.Top + flxBreak(0).Top
        'nYmax = picBreak.Top + picBreak.Height
        nYmax = 670

        '===========================================Conclui o Dradrop de origem da ordenacao
        If bDragDrop Then
            If flexDrag.Name = _flxBreak_0.Name Then
                If WindowsX > nXmin _
                    And WindowsX < nXmax _
                    And WindowsY > nYmin _
                    And WindowsY < nYmax Then
                    If Break_ValidaDrag(flexDrag) Then
                        Call Break_DragDrop(flexDrag)
                        FinalizaDrapDrop()
                    End If

                End If

            End If

        End If

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume

    End Sub

    Private Sub flxBreak_OLEDragDrop(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_OLEDragDropEvent) Handles flxBreak.OLEDragDrop
        Stop
    End Sub

    Private Sub flxBreak_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxBreak.RowColChange
        Dim Index As Short = flxBreak.GetIndex(eventSender)
        On Error GoTo Erro
        With flxBreak(0)
            cmdDadosComercialOrdenado.Enabled = .get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica Titulo Break")) <> "1" And .get_TextMatrix(.Row, fColuna(flxBreak(0), "Indica Titulo do Intervalo")) <> "1" And .get_TextMatrix(.Row, fColuna(flxBreak(0), "")) <> ""
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub flxDisponivel_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles flxDisponivel.ClickEvent
        Dim Index As Short = flxDisponivel.GetIndex(sender)
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume


    End Sub

    Private Sub flxDisponivel_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxDisponivel.DblClick
        Dim Index As Short = flxDisponivel.GetIndex(eventSender)
        If flxDisponivel(Index).Row > 0 Then
            cmdDadosComercial_Click(cmdDadosComercial, New System.EventArgs())
        End If
    End Sub


    Private Sub flxDisponivel_DragDrop(ByRef Source As AxMSFlexGridLib.AxMSFlexGrid)
        On Error GoTo Erro
        Dim nPasta As Short
        Dim sFita As String
        Dim sMsg As String
        Dim nCol As Short
        Dim nRow As Short
        Dim sProgramaOrigem As String
        Dim sProgramaDestino As String
        '================================================================================
        If Source.Name <> _flxBreak_0.Name Then
            txtMensagem.Visible = False
            GoTo Saida
        End If

        'nLinhadestino = flxDisponivel(Index).MouseRow
        chkSalvar.CheckState = System.Windows.Forms.CheckState.Checked
        With Source

            '==========================> Verifica qual é a pasta origem e posiciona nesta pasta
            nPasta = .get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
            '===================================Comerciais e Rotativos, acha as linhas do programa correto para devolver o comercial
            If nPasta = 1 Or nPasta = 2 Then
                sProgramaOrigem = .get_TextMatrix(nLinhaOrigem, fColuna(Source, "Programa Origem"))
                If nLinhadestino > flxDisponivel(nPasta).Rows - 1 Then
                    nLinhadestino = flxDisponivel(nPasta).Rows - 1
                End If
                sProgramaDestino = Trim(flxDisponivel(nPasta).get_TextMatrix(nLinhadestino, fColuna(flxDisponivel(nPasta), "Codigo Programa")))
                If sProgramaOrigem <> sProgramaDestino Then
                    nLinhadestino = 0
                    For nRow = 0 To flxDisponivel(nPasta).Rows - 1
                        If flxDisponivel(nPasta).get_TextMatrix(nRow, fColuna(flxDisponivel(nPasta), "Guia")) = sProgramaOrigem Then
                            nLinhadestino = nRow
                            Exit For
                        End If
                    Next nRow

                    If nLinhadestino = 0 Then
                        For nRow = 0 To flxDisponivel(nPasta).Rows - 1
                            'FIXIT: Replace 'Trim' function with 'Trim$' function                                      FixIT90210ae-R9757-R1B8ZE
                            If Trim(flxDisponivel(nPasta).get_TextMatrix(nRow, fColuna(flxDisponivel(nPasta), "Comercial"))) = "" Then
                                nLinhadestino = nRow
                                Exit For
                            End If
                        Next nRow

                        If nLinhadestino = 0 Then
                            nLinhadestino = flxDisponivel(nPasta).Rows - 1
                            flxDisponivel(nPasta).Rows = flxDisponivel(nPasta).Rows + 1
                        End If

                        flxDisponivel(nPasta).Row = nLinhadestino
                        flxDisponivel(nPasta).Visible = False
                        For nCol = 0 To flxDisponivel(nPasta).Cols - 1
                            If nPasta = 2 Then
                                flxDisponivel(nPasta).set_TextMatrix(nLinhadestino, nCol, sProgramaOrigem & "       " & VB6.Format(.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Horario Inicio Comercial Rotativo")), "hh:mm") & " às " & VB6.Format(.get_TextMatrix(nLinhaOrigem, fColuna(Source, "Horario Fim Comercial Rotativo")), "hh:mm"))
                            Else
                                flxDisponivel(nPasta).set_TextMatrix(nLinhadestino, nCol, sProgramaOrigem)
                            End If
                            'flxDisponivel(nPasta).TextMatrix(nLinhadestino, nCol) = sProgramaOrigem
                            flxDisponivel(nPasta).Col = nCol
                            flxDisponivel(nPasta).CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                            flxDisponivel(nPasta).CellFontBold = True
                            flxDisponivel(nPasta).CellBackColor = System.Drawing.Color.Yellow
                            flxDisponivel(nPasta).CellForeColor = System.Drawing.Color.Blue
                        Next nCol
                        flxDisponivel(nPasta).set_TextMatrix(nLinhadestino, fColuna(flxDisponivel(nPasta), "Indica_Titulo_Programa"), "1")
                        flxDisponivel(nPasta).MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree
                        flxDisponivel(nPasta).set_MergeRow(nLinhadestino, True)
                        Call CalculaAlturaLinha(flxDisponivel(1), nLinhadestino, fColuna(flxDisponivel(nPasta), "Comercial"))
                        nLinhadestino = nLinhadestino + 1
                        flxDisponivel(nPasta).Visible = True
                    End If

                End If
            End If

            '===================================Comerciais que não pertencem ao veiculo/comerciais por replicacao
            If .get_TextMatrix(.Row, fColuna(flxBreak(0), "Veiculo Origem")) = ucveiculo.text Then '  Comercial pertence ao veiculo
                tabDisponiveis.Tabs(nPasta).Selected = True
            Else '  Comercial ordenado por replicacao
                sMsg = "Fita: " & .get_TextMatrix(.Row, fColuna(flxBreak(0), "Fita")) & vbCrLf
                sMsg = sMsg & "Titulo: " & .get_TextMatrix(.Row, fColuna(flxBreak(0), "Comercial")) & vbCrLf
                sMsg = sMsg & "Comercial foi ordenado por replicação.Confirma a Exclusão?"
                If Not Aviso(sMsg, MsgBoxStyle.YesNo, MsgBoxStyle.Question) Then
                    GoTo Saida
                End If
            End If

            Select Case nPasta
                Case 1, 2, 5 ' Comerciais , Rotatitos ou Inter Programa
                    Call InsereGridDisponivel(nPasta, nLinhaOrigem)
                    Call RemoveLinha(flxBreak(0), nLinhaOrigem)
                Case 3, 4, 6 ' Depositorio avulso ou Artistico
                    sFita = .get_TextMatrix(nLinhaOrigem, fColuna(flxBreak(0), "Fita"))
                    Call RemoveLinha(flxBreak(0), nLinhaOrigem)
            End Select
            'Call MostraTotal(nLinhaOrigem)
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub flxDisponivel_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxDisponivel.MouseDownEvent
        Dim Index As Short = flxDisponivel.GetIndex(eventSender)
        On Error GoTo Erro
        Dim sMensagem As String = ""
        Dim nColunaDeterminar As Short
        Dim nColunaObs As Short
        Dim nColunaRestricao As Short
        Dim nAltura As Short
        Dim sObs_Roteiro As String
        Dim bValido As Boolean
        flxDisponivel(Index).Row = flxDisponivel(Index).MouseRow
        '=====================Clicou botao direito na Linha 0
        flxDisponivel(Index).Row = flxDisponivel(Index).MouseRow
        With flxDisponivel(Index)
            If eventArgs.button = 2 And .MouseRow = 0 Then
                FlexOpcoes = flxDisponivel(Index)
                .Col = .MouseCol
                frmOpcoesGrid.Text = Me.Text
                frmOpcoesGrid.txtColunaAtual.Text = .MouseCol.ToString
                If Index = 1 Or Index = 2 Or Index = 5 Then
                    mdiPrincipal.mnuClassificar.Enabled = False
                End If
                mdiPrincipal.mnuOpcoesGrid.Show(Windows.Forms.Cursor.Position)
                'mdiPrincipal.mnuClassificar.Enabled = True
            End If
        End With

        '=====================Clicou botao esquerdo-inicia o drag and drop 

        bIndicaMudancaPosicao = False
        bValido = True

        With flxDisponivel(Index)
            .Row = .MouseRow
            nLinhaOrigem = .Row
            '======================Se for linha 0, muda a ordem da coluna
            'If .Row = 0 Then
            '   .Col = .MouseCol
            '   nColunaPos = .Col
            '   .Drag 1
            '   .DragIcon = picMudaPosicao.Picture
            '   GoTo Saida
            'End If

            '==========================Verifica se Pode arrastar esta Linha
            If .Row = 0 Then
                GoTo Saida
            End If

            If Trim(.get_TextMatrix(.Row, fColuna(flxDisponivel(Index), "Comercial"))) = "" Then
                GoTo Saida
            End If

            Select Case Index
                Case 1, 2
                    If .get_TextMatrix(.Row, fColuna(flxDisponivel(Index), "indica_titulo_programa")) = "1" Then
                        GoTo Saida
                    End If
                Case 2, 5
                Case 3, 4, 6
            End Select
            '==========================Verifica se Pode Ordenar Comerciais Net
            If Not bOrdenarNet Then
                If Index = 1 Or Index = 2 Or Index = 5 Then
                    If .get_TextMatrix(.Row, fColuna(flxDisponivel(Index), "Indica Grade")) = "0" Then
                        GoTo Saida
                    End If
                End If
            End If
            '==========================> Mostra Textbox de Mensagem
            Select Case Index
                Case 1
                    nColunaDeterminar = fColuna(flxDisponivel(Index), "Indica a Determinar")
                    nColunaObs = fColuna(flxDisponivel(Index), "Obs Roteiro")
                    nColunaRestricao = fColuna(flxDisponivel(Index), "Horario de Restricao")
                Case 2, 5
                    nColunaDeterminar = fColuna(flxDisponivel(Index), "Indica a Determinar")
                    nColunaObs = fColuna(flxDisponivel(Index), "Obs Roteiro")
                    nColunaRestricao = fColuna(flxDisponivel(Index), "Horario de Restricao")
                Case 3, 4, 6
                    nColunaDeterminar = -1
                    nColunaObs = -1
                    nColunaRestricao = fColuna(flxDisponivel(Index), "Horario Restricao")
            End Select
            nAltura = 0
            If nColunaDeterminar > -1 Then
                If CDbl(.get_TextMatrix(.Row, nColunaDeterminar)) = 1 Then
                    sMensagem = "Comercial com Titulo a Determinar" & vbCrLf
                    nAltura = nAltura + 285
                    bValido = bPermissaoSemTitulo
                End If
            End If
            If Trim(.get_TextMatrix(.Row, fColuna(flxDisponivel(Index), "Fita"))) = "" Then
                sMensagem = sMensagem & "Comercial com Numeração de Fita Pendente" & vbCrLf
                nAltura = nAltura + 285
                bValido = bPermissaoSemTitulo
            End If
            If Trim(.get_TextMatrix(.Row, nColunaRestricao)) <> "" Then
                sMensagem = sMensagem & "Exibir após as " & (.get_TextMatrix(.Row, nColunaRestricao)) & vbCrLf
                nAltura = nAltura + 285
            End If
            If nColunaObs > -1 Then
                sObs_Roteiro = Trim(.get_TextMatrix(.Row, nColunaObs))
                sObs_Roteiro = Replace(sObs_Roteiro, Chr(13), "")
                sObs_Roteiro = Replace(sObs_Roteiro, Chr(10), "")

                If sObs_Roteiro <> "" Then
                    sMensagem = sMensagem & Trim(.get_TextMatrix(.Row, nColunaObs))
                    nAltura = nAltura + Int(Len(sMensagem) / 60) * 285
                End If
            End If

            If sMensagem <> "" Then

                If Not bValido Then
                    nAltura = nAltura + 285
                    sMensagem = sMensagem & "Ordenação não permitida "
                End If

                txtMensagem.Text = sMensagem
                txtMensagem.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + 100)
                txtMensagem.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Width) - 500)
                txtMensagem.Height = VB6.TwipsToPixelsY(nAltura)
                txtMensagem.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + .CellTop + .CellHeight)



                If VB6.PixelsToTwipsY(txtMensagem.Top) + VB6.PixelsToTwipsY(txtMensagem.Height) >= VB6.PixelsToTwipsY(.Height) Then
                    txtMensagem.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(.Top) + .CellTop) - VB6.PixelsToTwipsY(txtMensagem.Height))
                End If
                txtMensagem.Visible = True
                txtMensagem.BringToFront()
            End If
            '==========================Inicia o Drag
            If bValido Then
                flexDrag = flxDisponivel(Index)
                Me.IniciaDragDrop()
            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
    End Sub

    Private Sub flxDisponivel_MouseMoveEvent(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_MouseMoveEvent) Handles flxDisponivel.MouseMoveEvent
        'Dim Index As Short = flxBreak.GetIndex(sender)
        lblCoordenadas.Text = "X=" & System.Windows.Forms.Cursor.Position.X.ToString & "   Y=" & System.Windows.Forms.Cursor.Position.Y
        On Error GoTo Erro
        '===========================================Conclui o Dradrop de origem dos Breaks
        If bDragDrop Then
            If flexDrag.Name = _flxBreak_0.Name Then
                Call flxDisponivel_DragDrop(flexDrag)
                Me.FinalizaDrapDrop()
            End If

        End If
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume


    End Sub


    Private Sub flxDisponivel_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseUpEvent) Handles flxDisponivel.MouseUpEvent
        Dim Index As Short = flxDisponivel.GetIndex(eventSender)
        Dim nXmin As Integer = 0
        Dim nXmax As Integer = 0
        Dim nYmin As Integer
        Dim nYmax As Integer
        nXmin = picDisponivel.Left + flxDisponivel(Index).Left
        nXmax = picDisponivel.Left + flxDisponivel(Index).Left + flxDisponivel(Index).Width
        nYmin = picDisponivel.Top + flxDisponivel(Index).Top
        'nYmax = picDisponivel.Top + flxDisponivel(Index).Top + flxDisponivel(Index).Height
        nYmax = 680
        '===========================================Conclui o Dradrop de origem da ordenacao

        If bDragDrop Then
            If System.Windows.Forms.Cursor.Position.X > nXmin _
            And System.Windows.Forms.Cursor.Position.X < nXmax _
            And System.Windows.Forms.Cursor.Position.Y > nYmin _
            And System.Windows.Forms.Cursor.Position.Y < nYmax Then
                FinalizaDrapDrop()
            End If
        End If
    End Sub

    Private Sub flxDisponivel_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxDisponivel.RowColChange
        Dim Index As Short = flxDisponivel.GetIndex(eventSender)
        With flxDisponivel(Index)
            cmdDadosComercial.Enabled = .Row > 0 And .get_TextMatrix(.Row, fColuna(flxDisponivel(Index), "Comercial")) <> ""
        End With
    End Sub

    Private Sub frmRoteiroV2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    End Sub

    Private Sub frmRoteiroV2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error GoTo Erro
        Dim nOpcao As Short
        Dim sMensagem As String
        If chkSalvar.Checked Then
            sMensagem = "A Ordenacão deste Roteiro não foi salva." & vbCrLf
            sMensagem = sMensagem & "Deseja Salvar Antes de Sair ? "
            nOpcao = MsgBox(sMensagem, MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton3, "Atencao")
            Select Case nOpcao
                Case MsgBoxResult.Cancel
                    e.Cancel = True
                Case MsgBoxResult.Yes
                    If Not SalvaOrdenacao() Then
                        e.Cancel = True
                    End If
            End Select
        End If
Saida:
        Call FDeletaPorta(AsmxPorta, 4)
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume

    End Sub

    Private Sub frmRoteiroV2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{tab}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub Tamanhocoluna_1024()
        On Error GoTo Erro
        With flxBreak(0)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxBreak(0), ".."), 0)
            .set_ColWidth(fColuna(flxBreak(0), ""), 300)
            .set_ColWidth(fColuna(flxBreak(0), "Comercial"), 3495)
            .set_ColWidth(fColuna(flxBreak(0), "Dur."), 435)
            .set_ColWidth(fColuna(flxBreak(0), "Enc."), 435)
            .set_ColWidth(fColuna(flxBreak(0), "Fita"), 765)
            .set_ColWidth(fColuna(flxBreak(0), "Peso"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Com."), 435)
            .set_ColWidth(fColuna(flxBreak(0), "Empresa"), 705)
            .set_ColWidth(fColuna(flxBreak(0), "Contrato"), 1005)
            .set_ColWidth(fColuna(flxBreak(0), "Seq"), 495)
            .set_ColWidth(fColuna(flxBreak(0), "Razao Social"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Produto"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Veiculo Origem "), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Programa Origem"), 1320)
            .set_ColWidth(fColuna(flxBreak(0), "Obs. Roteiro"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "A Determinar"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Break "), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Tipo Intervalo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica Titulo Break"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica Titulo do Intervalo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Pasta Origem da Ordenacao"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica se Permite Ordenacao "), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica Salvo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Sequencia Faixa"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Id Chave"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Versao"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Tipo Int. do Comercial"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Tipo do Break da Fita"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Guia"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Inicio"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Fim"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Inicio Comercial Rotativo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Fim Comercial Rotativo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica_Espaco_Cedido"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Setor"), 0)




            If bMostraColunaPeso Then
                .set_ColWidth(fColuna(flxBreak(0), "Peso"), 720)
            End If
        End With

        With flxDisponivel(1)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(1), ".."), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Fita"), 1215)
            .set_ColWidth(fColuna(flxDisponivel(1), "Comercial"), 2745)
            .set_ColWidth(fColuna(flxDisponivel(1), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(1), "Peso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Cod."), 405)
            .set_ColWidth(fColuna(flxDisponivel(1), "Razao Social"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Empresa"), 720)
            .set_ColWidth(fColuna(flxDisponivel(1), "Contrato"), 975)
            .set_ColWidth(fColuna(flxDisponivel(1), "Seq"), 435)
            .set_ColWidth(fColuna(flxDisponivel(1), "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Cod Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Indica a Determinar"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Obs Roteiro"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "(VAGO)"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Horario de Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Veiculo Origem"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "GUIA"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Horario Inicio"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Horario Fim"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Indica_Espaco_Cedido"), 0)
            If bMostraColunaPeso Then
                .set_ColWidth(fColuna(flxDisponivel(1), "Peso"), 720)
            End If

        End With
        With flxDisponivel(2)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(2), ".."), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Fita"), 1215)
            .set_ColWidth(fColuna(flxDisponivel(2), "Comercial"), 2745)
            .set_ColWidth(fColuna(flxDisponivel(2), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(2), "Razao Social"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Empresa"), 720)
            .set_ColWidth(fColuna(flxDisponivel(2), "Contrato"), 975)
            .set_ColWidth(fColuna(flxDisponivel(2), "Seq"), 435)
            .set_ColWidth(fColuna(flxDisponivel(2), "Cod."), 405)
            .set_ColWidth(fColuna(flxDisponivel(2), "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Cod Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Indica a Determinar"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Obs Roteiro"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Horario de Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Veiculo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Peso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Horario Inicio "), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Horario Fim "), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Indica_Espaco_Cedido"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "GUIA"), 0)
            If bMostraColunaPeso Then
                .set_ColWidth(fColuna(flxDisponivel(2), "Peso"), 720)
            End If
        End With

        With flxDisponivel(3)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(3), "Fita"), 1215)
            .set_ColWidth(fColuna(flxDisponivel(3), "Comercial"), 3270)
            .set_ColWidth(fColuna(flxDisponivel(3), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(3), "Saldo"), 705)
            .set_ColWidth(fColuna(flxDisponivel(3), "Qtde"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Cod. Veiculo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "IdChave"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Tipo do Break"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Codigo Programa"), 1320)
            .set_ColWidth(fColuna(flxDisponivel(3), "Indica_Espaco_Cedido"), 0)
        End With

        With flxDisponivel(4)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(4), "Fita"), 1215)
            .set_ColWidth(fColuna(flxDisponivel(4), "Comercial"), 3270)
            .set_ColWidth(fColuna(flxDisponivel(4), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(4), "Saldo"), 705)
            .set_ColWidth(fColuna(flxDisponivel(4), "Qtde"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Cod. Veiculo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "IdChave"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Tipo do Break"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Codigo Programa"), 1320)
            .set_ColWidth(fColuna(flxDisponivel(4), "Indica_Espaco_Cedido"), 0)

        End With

        With flxDisponivel(5)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(5), ".."), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Fita"), 1215)
            .set_ColWidth(fColuna(flxDisponivel(5), "Comercial"), 2745)
            .set_ColWidth(fColuna(flxDisponivel(5), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(5), "Peso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Cod."), 405)
            .set_ColWidth(fColuna(flxDisponivel(5), "Razao Social"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Empresa"), 720)
            .set_ColWidth(fColuna(flxDisponivel(5), "Contrato"), 975)
            .set_ColWidth(fColuna(flxDisponivel(5), "Seq"), 435)
            .set_ColWidth(fColuna(flxDisponivel(5), "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Cod Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Indica a Determinar"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Obs Roteiro"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "(VAGO)"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Horario de Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Veiculo Origem"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "GUIA"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Horario Inicio"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Horario Fim"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Indica_Espaco_Cedido"), 0)
            If bMostraColunaPeso Then
                .set_ColWidth(fColuna(flxDisponivel(5), "Peso"), 720)
            End If

        End With

        With flxDisponivel(6)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(6), ".."), 915)
            .set_ColWidth(fColuna(flxDisponivel(6), "Fita"), 915)
            .set_ColWidth(fColuna(flxDisponivel(6), "Comercial"), 2925)
            .set_ColWidth(fColuna(flxDisponivel(6), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(6), "Saldo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Qtde"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Cod. Veiculo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "IdChave"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Tipo do Break"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Break"), 615)
            .set_ColWidth(fColuna(flxDisponivel(6), "Pos."), 435)
            .set_ColWidth(fColuna(flxDisponivel(6), "Codigo Programa"), 1320)
            .set_ColWidth(fColuna(flxDisponivel(6), "Indica_Espaco_Cedido"), 0)
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
    End Sub


    Private Sub Tamanhocoluna_800()

        On Error GoTo Erro
        With flxBreak(0)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxBreak(0), ".."), 0)
            .set_ColWidth(fColuna(flxBreak(0), ""), 335)
            .set_ColWidth(fColuna(flxBreak(0), "Comercial"), 2815)
            .set_ColWidth(fColuna(flxBreak(0), "Dur."), 435)
            .set_ColWidth(fColuna(flxBreak(0), "Enc."), 435)
            .set_ColWidth(fColuna(flxBreak(0), "Fita"), 765)
            .set_ColWidth(fColuna(flxBreak(0), "Peso"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Com."), 435)
            .set_ColWidth(fColuna(flxBreak(0), "Empresa"), 705)
            .set_ColWidth(fColuna(flxBreak(0), "Contrato"), 1005)
            .set_ColWidth(fColuna(flxBreak(0), "Seq"), 495)
            .set_ColWidth(fColuna(flxBreak(0), "Razao Social"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Produto"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Veiculo Origem "), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Programa Origem"), 1320)
            .set_ColWidth(fColuna(flxBreak(0), "Obs. Roteiro"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "A Determinar"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Break "), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Tipo Intervalo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica Titulo Break"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica Titulo do Intervalo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Pasta Origem da Ordenacao"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica se Permite Ordenacao "), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica Salvo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Sequencia Faixa"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Id Chave"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Versao"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Tipo Int. do Comercial"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Tipo do Break da Fita"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Guia"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Inicio"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Fim"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Inicio Comercial Rotativo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Horario Fim Comercial Rotativo"), 0)
            .set_ColWidth(fColuna(flxBreak(0), "Indica_Espaco_Cedido"), 0)
        End With

        With flxDisponivel(1)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(1), ".."), 915)
            .set_ColWidth(fColuna(flxDisponivel(1), "Fita"), 915)
            .set_ColWidth(fColuna(flxDisponivel(1), "Comercial"), 2475)
            .set_ColWidth(fColuna(flxDisponivel(1), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(1), "Peso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Cod."), 405)
            .set_ColWidth(fColuna(flxDisponivel(1), "Razao Social"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Empresa"), 720)
            .set_ColWidth(fColuna(flxDisponivel(1), "Contrato"), 975)
            .set_ColWidth(fColuna(flxDisponivel(1), "Seq"), 435)
            .set_ColWidth(fColuna(flxDisponivel(1), "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Cod Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Indica a Determinar"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Obs Roteiro"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "(VAGO)"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Horario de Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Veiculo Origem"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "GUIA"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Horario Inicio"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Horario Fim"), 0)
            .set_ColWidth(fColuna(flxDisponivel(1), "Indica_Espaco_Cedido"), 0)
        End With
        With flxDisponivel(2)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(2), ".."), 915)
            .set_ColWidth(fColuna(flxDisponivel(2), "Fita"), 915)
            .set_ColWidth(fColuna(flxDisponivel(2), "Comercial"), 2475)
            .set_ColWidth(fColuna(flxDisponivel(2), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(2), "Razao Social"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Empresa"), 720)
            .set_ColWidth(fColuna(flxDisponivel(2), "Contrato"), 975)
            .set_ColWidth(fColuna(flxDisponivel(2), "Seq"), 435)
            .set_ColWidth(fColuna(flxDisponivel(2), "Cod."), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Cod Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Indica a Determinar"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Obs Roteiro"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Horario de Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Veiculo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Peso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Horario Inicio "), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Horario Fim "), 0)
            .set_ColWidth(fColuna(flxDisponivel(2), "Indica_Espaco_Cedido"), 0)
        End With

        With flxDisponivel(3)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(3), ".."), 915)
            .set_ColWidth(fColuna(flxDisponivel(3), "Fita"), 915)
            .set_ColWidth(fColuna(flxDisponivel(3), "Comercial"), 2475)
            .set_ColWidth(fColuna(flxDisponivel(3), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(3), "Saldo"), 705)
            .set_ColWidth(fColuna(flxDisponivel(3), "Qtde"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Cod. Veiculo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "IdChave"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Tipo do Break"), 0)
            .set_ColWidth(fColuna(flxDisponivel(3), "Codigo Programa"), 1320)
            .set_ColWidth(fColuna(flxDisponivel(3), "Indica_Espaco_Cedido"), 0)
        End With

        With flxDisponivel(4)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(4), ".."), 915)
            .set_ColWidth(fColuna(flxDisponivel(4), "Fita"), 915)
            .set_ColWidth(fColuna(flxDisponivel(4), "Comercial"), 2475)
            .set_ColWidth(fColuna(flxDisponivel(4), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(4), "Saldo"), 705)
            .set_ColWidth(fColuna(flxDisponivel(4), "Qtde"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Cod. Veiculo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "IdChave"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Tipo do Break"), 0)
            .set_ColWidth(fColuna(flxDisponivel(4), "Codigo Programa"), 1320)
            .set_ColWidth(fColuna(flxDisponivel(4), "Indica_Espaco_Cedido"), 0)
        End With

        With flxDisponivel(5)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(5), ",,"), 915)
            .set_ColWidth(fColuna(flxDisponivel(5), "Fita"), 915)
            .set_ColWidth(fColuna(flxDisponivel(5), "Comercial"), 2475)
            .set_ColWidth(fColuna(flxDisponivel(5), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(5), "Peso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Cod."), 405)
            .set_ColWidth(fColuna(flxDisponivel(5), "Razao Social"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Empresa"), 720)
            .set_ColWidth(fColuna(flxDisponivel(5), "Contrato"), 975)
            .set_ColWidth(fColuna(flxDisponivel(5), "Seq"), 435)
            .set_ColWidth(fColuna(flxDisponivel(5), "Ch.Acesso"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Cod Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Indica a Determinar"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Obs Roteiro"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "(VAGO)"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Indica Grade"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Horario de Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Codigo Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Veiculo Origem"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Indica_Titulo_Programa"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "GUIA"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Horario Inicio"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Horario Fim"), 0)
            .set_ColWidth(fColuna(flxDisponivel(5), "Indica_Espaco_Cedido"), 0)
        End With

        With flxDisponivel(6)
            For x As Integer = 0 To .Cols - 1
                .set_ColWidth(x, 0)
            Next
            .set_ColWidth(fColuna(flxDisponivel(6), ".."), 915)
            .set_ColWidth(fColuna(flxDisponivel(6), "Fita"), 915)
            .set_ColWidth(fColuna(flxDisponivel(6), "Comercial"), 2475)
            .set_ColWidth(fColuna(flxDisponivel(6), "Dur."), 510)
            .set_ColWidth(fColuna(flxDisponivel(6), "Saldo"), 705)
            .set_ColWidth(fColuna(flxDisponivel(6), "Qtde"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Numero da Pasta"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Produto"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Horario Restricao"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Cod. Veiculo"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "IdChave"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Tipo do Break"), 0)
            .set_ColWidth(fColuna(flxDisponivel(6), "Codigo Programa"), 1320)
            .set_ColWidth(fColuna(flxDisponivel(6), "Indica_Espaco_Cedido"), 0)

        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
    End Sub

    Private Sub frmRoteiroV2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Try
            Me.ucVeiculo.Usuario = gsUsuario

            Me.asmxRoteiro = NewRoteiro()
            Me.AsmxRoteiroLog = NewRoteiroLog()
            Me.asmxPorta = NewPorta()
            Me.AsmxParametro_Roteiro = NewParametro_Roteiro()
            Me.asmxBaixaVeiculacao = NewBaixaVeiculacao()
            Me.dtsBaixaVeiculacao = New MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao
            Me.dtsBaixaCritica = New MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao
            Me.dtsBaixaCritica = asmxBaixaVeiculacao.spuCarregar()
            Call ConfiguraGridBreak()
            Call ConfiguraGridComercial(1)
            Call ConfiguraGridComercial(5)
            Call ConfiguraGridRotativo()
            Call ConfiguraGridDepositorio(3)
            Call ConfiguraGridDepositorio(4)
            Call ConfiguraGridArNaoReplicado()

            flxDisponivel(1).Visible = True
            flxDisponivel(2).Visible = False
            flxDisponivel(3).Visible = False
            flxDisponivel(4).Visible = False
            flxDisponivel(5).Visible = False
            flxDisponivel(6).Visible = False
            flxDisponivel(1).BringToFront()

            bGuia = True
            With Me
                .Top = 0
                .Left = 0
                If Resolucao_Monitor_1024() Then
                    Me.Height = VB6.TwipsToPixelsY(9810)
                    Me.Width = VB6.TwipsToPixelsX(14750)
                    Call Tamanhocoluna_1024()
                Else
                    .Width = VB6.TwipsToPixelsX(11925)
                    .Height = VB6.TwipsToPixelsY(7575)
                    Call Tamanhocoluna_800()
                End If

            End With

            With picCorte
                .Top = VB6.TwipsToPixelsY(1320)
                .Left = VB6.TwipsToPixelsX(1710)
                .Width = VB6.TwipsToPixelsX(7890)
                .Height = VB6.TwipsToPixelsY(4185)
            End With

            With picStatus
                .Top = VB6.TwipsToPixelsY(1320)
                .Left = VB6.TwipsToPixelsX(1710)
                .Width = VB6.TwipsToPixelsX(7890)
                .Height = VB6.TwipsToPixelsY(4455)
            End With

            aOrigem(1) = "Co" '  Comercial Normal
            aOrigem(2) = "Rt" '  Rotativo
            aOrigem(3) = "Av" '  Avulso
            aOrigem(4) = "Ar" '  Artistico
            aOrigem(5) = "Op" '  Outros Programa
            aOrigem(6) = "Ar" '  Artisticos não replicados

            bPermissaoComposicaoBreak = VePermissao(230)
            bDragDrop = False
            flexDrag = Nothing



            If sTipoAcesso <> "C" Then
                tabDisponiveis.Tabs.Remove((6))
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub ConfiguraGridArNaoReplicado()

        On Error GoTo Erro
        With flxDisponivel(6)
            .Clear()
            .Visible = False
            .FixedCols = 0
            .Rows = 30
            .Cols = 16
            .Top = flxDisponivel(1).Top
            .Left = flxDisponivel(1).Left
            .Width = flxDisponivel(1).Width
            .Height = flxDisponivel(1).Height
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollTrack = True
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .ForeColor = flxDisponivel(4).ForeColor
            .FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusNone

            .set_TextMatrix(0, 0, "..")
            .set_TextMatrix(0, 1, "Fita")
            .set_TextMatrix(0, 2, "Comercial")
            .set_TextMatrix(0, 3, "Dur.")
            .set_TextMatrix(0, 4, "Saldo")
            .set_TextMatrix(0, 5, "Qtde")
            .set_TextMatrix(0, 6, "Numero da Pasta")
            .set_TextMatrix(0, 7, "Produto")
            .set_TextMatrix(0, 8, "Horario Restricao")
            .set_TextMatrix(0, 9, "Cod. Veiculo")
            .set_TextMatrix(0, 10, "IdChave")
            .set_TextMatrix(0, 11, "Tipo do Break")
            .set_TextMatrix(0, 12, "Break")
            .set_TextMatrix(0, 13, "Pos.")
            .set_TextMatrix(0, 14, "Codigo Programa")
            .set_TextMatrix(0, 15, "Indica_Espaco_Cedido")

            '      .ColWidth(fColuna(flxDisponivel(6), "Fita")) = 795
            '      .ColWidth(fColuna(flxDisponivel(6), "Comercial")) = 3030
            '      .ColWidth(fColuna(flxDisponivel(6), "Dur.")) = 510
            '      .ColWidth(fColuna(flxDisponivel(6), "Saldo")) = 0
            '      .ColWidth(fColuna(flxDisponivel(6), "Qtde")) = 0
            '      .ColWidth(fColuna(flxDisponivel(6), "Numero da Pasta")) = 0
            '      .ColWidth(fColuna(flxDisponivel(6), "Produto")) = 0
            '      .ColWidth(fColuna(flxDisponivel(6), "Horario Restricao")) = 0
            '      .ColWidth(fColuna(flxDisponivel(6), "Cod. Veiculo")) = 0
            '      .ColWidth(fColuna(flxDisponivel(6), "IdChave")) = 0
            '      .ColWidth(fColuna(flxDisponivel(6), "Tipo do Break")) = 0
            '      .ColWidth(fColuna(flxDisponivel(6), "Break")) = 705
            '      .ColWidth(fColuna(flxDisponivel(6), "Pos.")) = 705
            '      .ColWidth(fColuna(flxDisponivel(6), "Codigo Programa")) = 1320


            .set_ColData(fColuna(flxDisponivel(6), "Fita"), fColuna(flxBreak(0), "Fita"))
            .set_ColData(fColuna(flxDisponivel(6), "Comercial"), fColuna(flxBreak(0), "Comercial"))
            .set_ColData(fColuna(flxDisponivel(6), "Dur."), fColuna(flxBreak(0), "Dur."))
            .set_ColData(fColuna(flxDisponivel(6), "Saldo"), 0)
            .set_ColData(fColuna(flxDisponivel(6), "Qtde"), 0)
            .set_ColData(fColuna(flxDisponivel(6), "Numero da Pasta"), fColuna(flxBreak(0), "Pasta Origem da Ordenacao"))
            .set_ColData(fColuna(flxDisponivel(6), "Produto"), fColuna(flxBreak(0), "Produto"))
            .set_ColData(fColuna(flxDisponivel(6), "Horario Restricao"), fColuna(flxBreak(0), "Produto"))
            .set_ColData(fColuna(flxDisponivel(6), "Cod. Veiculo"), fColuna(flxBreak(0), "Veiculo Origem"))
            .set_ColData(fColuna(flxDisponivel(6), "IdChave"), fColuna(flxBreak(0), "Id Chave"))
            .set_ColData(fColuna(flxDisponivel(6), "Tipo do Break"), fColuna(flxBreak(0), "Tipo do Break da Fita"))
            .set_ColData(fColuna(flxDisponivel(6), "Codigo Programa"), fColuna(flxBreak(0), "Programa Origem"))
            .set_ColData(fColuna(flxDisponivel(6), "Indica_Espaco_Cedido"), fColuna(flxBreak(0), "Indica_Espaco_Cedido"))

            .Row = 1
            .Col = 0
            .TopRow = 1
            .LeftCol = 0

            .set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)

        End With
Saida:
        flxDisponivel(6).Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub


    Private Sub frmRoteiroV2_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize

        If Me.WindowState <> System.Windows.Forms.FormWindowState.Minimized Then

            With picBreak
                .Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - 1300)
                cmdCarregar.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Height) - 550)
                cmdMarcarTodos.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Height) - 850)
            End With

            With flxBreak(0)
                .Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(picBreak.Width) - VB6.PixelsToTwipsX(.Left) - 15)
                .Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(picBreak.Height) - 350)
            End With

            With treBreak
                .Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(picBreak.Height) - 1270)
            End With

            With picDisponivel
                .Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) - VB6.PixelsToTwipsX(picDisponivel.Left) - 210)
                .Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - 1170)
            End With

            With tabDisponiveis
                .Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(picDisponivel.Width) - 50)
                .Height = picDisponivel.Height
            End With


            For nCont = 1 To flxDisponivel.Count
                With flxDisponivel(nCont)
                    .Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(picDisponivel.Height) - 660)
                    .Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(picDisponivel.Width) - 115)
                End With
            Next nCont

            With cmdRefresh
                .Top = 0
                .Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(picDisponivel.Width) - VB6.PixelsToTwipsX(.Width) - 45)
            End With

            With cmdDadosComercial
                .Top = 0
                .Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(cmdRefresh.Left) - VB6.PixelsToTwipsX(.Width) - 15)
            End With
            'fraProgramacao.Left = picDisponivel.Left - 50
            'fraProgramacao.Width = picDisponivel.Width + 50
        End If
    End Sub


    Private Sub frmRoteiroV2_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
        Me.FinalizaDrapDrop()
        Resume Saida


    End Sub


    Private Sub lblStatus_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblStatus.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = x
        MouseY = y
    End Sub


    Private Sub lblStatus_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblStatus.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

        On Error GoTo Erro
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        Dim MaxTop As Short
        Dim MaxLeft As Short

        With picStatus
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
            .BringToFront()
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida

    End Sub

    Private Sub CancelaOrdenacao()

        On Error GoTo Erro
        Dim sMensagem As String
        Dim nRoot As Integer
        Dim nChild As Integer
        Call ConfiguraGridBreak()
        Call ConfiguraGridComercial(1)
        Call ConfiguraGridComercial(5)
        Call ConfiguraGridRotativo()
        Call ConfiguraGridDepositorio(3)
        Call ConfiguraGridArNaoReplicado()
        Call ConfiguraGridLog()
        Call Configura_GridCorte()
        DtsRoteiro.Clear()
        dtsBaixaVeiculacao.Clear()

        DtsPorta.Clear()
        DtsRoteiroLog.Clear()
        chkSalvar.Checked = False
        cmdRefresh.Visible = False
        cmdDadosComercial.Visible = False
        cmdDadosComercialOrdenado.Visible = False
        Call FDeletaPorta(AsmxPorta, 4)
        With treBreak
            .BeginUpdate()
            For nRoot = 0 To .Nodes.Count - 1
                .Nodes(nRoot).ForeColor = Color.Blue
                For nChild = 0 To .Nodes(nRoot).Nodes.Count - 1
                    .Nodes(nRoot).Nodes(nChild).ForeColor = Color.Blue
                Next
            Next
            .CheckBoxes = True
            .EndUpdate()
        End With
        cmdCarregar.Enabled = True
        cmdMarcarTodos.Enabled = True
        cmdMarcarTodos.CheckState = System.Windows.Forms.CheckState.Unchecked
        fraProgramacao.Enabled = True
        cmdOkProgramacao.Visible = True
        bDragDrop = False
        flexDrag = Nothing
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub treBreak_AfterCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles treBreak.AfterCheck
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        On Error Resume Next
        Dim nNcont As Short
        If Not bAfterCheck Then
            bAfterCheck = True
            For nCont = 0 To Node.Nodes.Count - 1
                Node.Nodes(nCont).Checked = Node.Checked
            Next
            bAfterCheck = False
        End If
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub treBreak_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles treBreak.Click

    End Sub

    Private Sub treBreak_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treBreak.NodeMouseClick
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        On Error GoTo Erro
        Dim nRow As Short

        '==============================Posiciona grid de ordenacao
        With flxBreak(0)
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, fColuna(flxBreak(0), "guia")) = Node.Text Then
                    .Row = nRow
                    .Col = 1
                    .TopRow = nRow
                    Exit For
                End If
            Next nRow
        End With


        '==============================Posiciona grid de comerciais
        With flxDisponivel(1)
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, fColuna(flxDisponivel(1), "guia")) = Node.Text Then
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
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume

    End Sub
    Private Sub tbOpcoes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOpcoes.Click
    End Sub

    Private Sub tbOpcoes_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOpcoes.ClientSizeChanged
    End Sub

    Private Sub tbOpcoes_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tbOpcoes.ItemClicked
    End Sub

    Private Sub frmRoteiroV2_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RegionChanged
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub tbCalendario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub tbSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSalvar.Click
        Me.SalvaOrdenacao()
    End Sub
    Private Sub tbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCancelar.Click
        On Error GoTo Erro
        Dim sMensagem As String = ""
        Dim nOpcao As Integer
        If chkSalvar.Checked Then
            sMensagem = "A Ordenacão deste Roteiro não foi salva." & vbCrLf
            sMensagem = sMensagem & "Confirma o cancelamento sem salvar ?"
            nOpcao = MsgBox(sMensagem, vbYesNo + vbQuestion + vbDefaultButton2, "Atencao")
            If nOpcao = vbNo Then
                GoTo Saida
            End If
        End If
        Call CancelaOrdenacao()
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub tbSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSair.Click
        Me.Dispose()
    End Sub
    Private Sub tbConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConsistencia.Click
        On Error GoTo Erro
        If ucveiculo.text <> "" And UcData.DateTime.ToString <> "" Then
            frmRoteiroConsistencia.chkIniciar.Checked = True
            frmRoteiroConsistencia.txtVeiculo.Text = ucveiculo.text
            frmRoteiroConsistencia.txtData.Text = UcData.DateTime
            frmRoteiroConsistencia.txtPrograma.Text = ""
            frmRoteiroConsistencia.txtHorarioPrograma.Text = ""
            frmRoteiroConsistencia.txtForm.Text = Me.Name
            If cmdCarregar.Enabled Then ' é porque o roteiro não  esta carregado
                frmRoteiroConsistencia.chkRoteiroGravado.Checked = True
            Else
                frmRoteiroConsistencia.chkOrdenacao.Checked = True
            End If
            frmRoteiroConsistencia.ShowDialog()
            frmRoteiroConsistencia.BringToFront()
            frmRoteiroConsistencia.Dispose()
        End If
Saida:
        Exit Sub

Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub tbUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbUsuario.Click
        frmRoteiro_Usuario.Show()
        frmRoteiro_Usuario.BringToFront()
    End Sub

    Private Sub cboVeiculo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub cmdOkProgramacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOkProgramacao.Click
        On Error GoTo Erro

        If ucVeiculo.Text.Trim = "" Or UcData.Ano = 0 Then
            Aviso("Veiculo e Data da programação devem ser informados")
        Else
            bPermissaoSemTitulo = UCase(Vernulo(fParametro(81, , , ucVeiculo.Text), "SIM")) = "SIM"
            bolMostraDiferenciado = UCase(Vernulo(fParametro(260, , , ucVeiculo.Text), "NÃO")) = "SIM"
            Select Case ucVeiculo.Text
                Case "001"
                    bPermissaoArtistico = VePermissao(325)
                    bPermissaoComercial = VePermissao(326)
                    bOrdenarNet = VePermissao(327)
                    bPermissaoBreakDiferente = True
                    bMostraColunaPeso = True
                Case "004"
                    bPermissaoArtistico = VePermissao(218)
                    bPermissaoComercial = VePermissao(219)
                    bOrdenarNet = VePermissao(328)
                    bPermissaoBreakDiferente = True
                    bMostraColunaPeso = True
                Case "076"
                    bPermissaoArtistico = VePermissao(220)
                    bPermissaoComercial = VePermissao(221)
                    bOrdenarNet = VePermissao(329)
                    bPermissaoBreakDiferente = True
                    bMostraColunaPeso = True
                Case Else
                    bPermissaoArtistico = True
                    bPermissaoComercial = True
                    bPermissaoBreakDiferente = False
                    bMostraColunaPeso = UCase(Vernulo(fParametro(104, , , ucVeiculo.Text), "SIM")) = "SIM"
            End Select

            '===================================================Verfica se veiculo recebe ordenacao de outro veiculo 
            dtsParametro_Roteiro = AsmxParametro_Roteiro.spuCarregar(ucVeiculo.Text)
            chkRecebeOrdenacao.Checked = False
            sSql = "Cod_Veiculo = '" & ucVeiculo.Text & "'"
            sSql = sSql & " and indica_ordenacao = 1 and veiculo_origem_roteiro <> cod_veiculo"
            chkRecebeOrdenacao.Checked = dtsParametro_Roteiro.dtbParametro_Roteiro.Select(sSql).Length > 0
            '=========================================================Consiste Breaks Excluidos
            frmConsisteBreak.txtVeiculo.Text = ucVeiculo.Text
            frmConsisteBreak.txtData.Text = UcData.DateTime
            frmConsisteBreak.txtPrograma.Text = ""
            frmConsisteBreak.chkExibir.Checked = True
            If frmConsisteBreak.chkCritica.Checked Then
                frmConsisteBreak.Visible = False
                frmConsisteBreak.ShowDialog()
            End If
            frmConsisteBreak.Dispose()
            '=============================================================Consiste Guia da Programacao
            If Not CarregaGuia() Then GoTo saida
            fraProgramacao.Enabled = False
            cmdOkProgramacao.Visible = False

        End If
saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume saida
        Resume
    End Sub

    Private Sub cmdMarcarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMarcarTodos.CheckedChanged
        On Error GoTo Erro
        Dim nRoot As Integer
        Dim nChild As Integer
        With treBreak
            For nRoot = 0 To .Nodes.Count - 1
                .Nodes(nRoot).Checked = cmdMarcarTodos.Checked
                For nChild = 0 To .Nodes(nRoot).Nodes.Count - 1
                    .Nodes(nRoot).Nodes(nChild).Checked = cmdMarcarTodos.Checked
                Next nChild
            Next nRoot
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub treBreak_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treBreak.AfterSelect
    End Sub

    Private Sub tbGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGuia.Click
        Call MostrarGuia()
    End Sub

    Private Sub flxDisponivel_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles flxDisponivel.VisibleChanged
    End Sub

    Private Sub txtMensagem_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles txtMensagem.ControlRemoved

    End Sub

    Private Sub tabDisponiveis_BeforeClick(ByVal sender As System.Object, ByVal e As AxComctlLib.ITabStripEvents_BeforeClickEvent)
    End Sub
    Private Sub frmRoteiroV2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub frmRoteiroV2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        FinalizaDrapDrop()
    End Sub

    Private Sub txtData_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Stop
    End Sub

    Private Sub txtData_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
    End Sub

    Private Sub txtData_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub
    Private Sub IniciaDragDrop()
        On Error GoTo Erro
        With flexDrag
            nRowDrag = .Row
            bDragDrop = True

            If flexDrag.Name = _flxBreak_0.Name Then
                Me.Cursor = New Cursor(Me.GetType(), "mao02.cur")
            Else
                Me.Cursor = New Cursor(Me.GetType(), "mao01.cur")
            End If
            flexDrag.ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarHorizontal
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Me.FinalizaDrapDrop()
        Resume
    End Sub
    Private Sub FinalizaDrapDrop()
        On Error GoTo Erro
        txtMensagem.Visible = False
        If Not flexDrag Is Nothing Then
            flexDrag.ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
        End If


        If bDragDrop Then
            bDragDrop = False
            flexDrag = Nothing
        End If
        Me.Cursor = Cursors.Default

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub fraProgramacao_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles fraProgramacao.MouseMove
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub fraProgramacao_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles fraProgramacao.MouseUp
        FinalizaDrapDrop()
    End Sub
    Public Sub ReabreRoteiro(ByVal Par_Veiculo As String, ByVal Par_Data As String)
        On Error GoTo Erro
        asmxRoteiro.spuReabrirRoteiro(Par_Veiculo, Par_Data)
        Me.AdicionaLog(Par_Veiculo, Par_Data, , , , , , , , , , , "Reabertura do Roteiro")
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
    End Sub
    Public Sub AdicionaLog(Optional ByVal Par_Cod_Veiculo As String = "", _
                                Optional ByVal Par_Data_Exibicao As String = "", _
                                Optional ByVal Par_Cod_Programa As String = "", _
                                Optional ByVal Par_Cod_Comercial As String = "", _
                                Optional ByVal Par_Breaks As Short = 0, _
                                Optional ByVal Par_Tipo As Short = 0, _
                                Optional ByVal Par_Numero_Fita As String = "", _
                                Optional ByVal Par_Titulo As String = "", _
                                Optional ByVal Par_Cod_Empresa As String = "", _
                                Optional ByVal Par_Numero_MR As Integer = 0, _
                                Optional ByVal Par_sequencia_mr As Short = 0, _
                                Optional ByVal Par_Chave_Acesso As Short = 0, _
                                Optional ByVal Par_LogOPeracao As String = "", _
                                Optional ByVal Par_Formulario As String = "")

        On Error GoTo Erro

        dtsRoteiroLog.dtbRoteiroLog.AdddtbRoteiroLogRow(Par_Cod_Veiculo, _
                                                        Par_Data_Exibicao, _
                                                        Par_Cod_Programa, _
                                                        Par_Cod_Comercial, _
                                                        Par_Breaks, _
                                                        Par_Tipo, _
                                                        Par_Numero_Fita, _
                                                        Par_Titulo, _
                                                        Par_Cod_Empresa, _
                                                        Par_Numero_MR, _
                                                        Par_sequencia_mr, _
                                                        Par_Chave_Acesso, _
                                                        gsUsuario, _
                                                        Now, _
                                                        TimeOfDay.ToLongTimeString, _
                                                        Par_LogOPeracao, _
                                                        Me.Name _
                                                        )

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub tbExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbExcluir.Click
    End Sub

    Private Sub tbExcluir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbExcluir.MouseMove
        On Error GoTo Erro
        Dim sQualidade As String = ""
        Dim sEmpresa As String = ""
        Dim nContrato As Long
        Dim nSequencia As Short
        Dim sVeiculo As String = ""
        Dim sData As String = ""
        Dim sPrograma As String = ""
        Dim iChaveAcesso As Short

        txtMensagem.Visible = False
        If Not bDragDrop Then
            GoTo Saida
        End If

        '=======================================================================Acha o Contrato no grid origem
        With flexDrag
            If flexDrag.Name = _flxDisponivel_2.Name Then
                sVeiculo = .get_TextMatrix(.Row, fColuna(flexDrag, "Veiculo"))
            Else
                sVeiculo = .get_TextMatrix(.Row, fColuna(flexDrag, "Veiculo Origem"))
            End If

            iChaveAcesso = .get_TextMatrix(.Row, fColuna(flexDrag, "Ch.Acesso")) 'Chave acesso
            sEmpresa = .get_TextMatrix(.Row, fColuna(flexDrag, "Empresa"))
            nContrato = Integer.Parse(.get_TextMatrix(.Row, fColuna(flexDrag, "Contrato")))
            nSequencia = Short.Parse(.get_TextMatrix(.Row, fColuna(flexDrag, "Seq")))
            sPrograma = .get_TextMatrix(.Row, fColuna(flexDrag, "Codigo Programa"))
            If flexDrag.Name = _flxBreak_0.Name Then
                sPrograma = .get_TextMatrix(.Row, fColuna(flexDrag, "Programa Origem"))
            End If
        End With
        If nContrato.ToString.Trim = "" Then
            GoTo saida
        End If

        '================================================Obtem o Parametro da qualidade
        sQualidade = fParametro(28, , ucVeiculo.Text)
        If sQualidade.Trim = "" Then
            MsgBox("Parâmetro 28 (Qualidade para Baixa pelo Roteiro Não Cadastrado !", vbOKOnly + vbInformation, "Atenção")
            GoTo Saida
        End If
        '================================================Adiciona no Dataset de Baixa
        If MsgBox("Confirma a Exclusão com Baixa deste Comercial", vbYesNo + vbQuestion, "Atenção") = vbYes Then
            dtsBaixaVeiculacao.dtbBaixa.AdddtbBaixaRow("", sVeiculo, UcData.DateTime, sPrograma, iChaveAcesso, sQualidade, "1900-01-01 00:00:00", "", lngIdUsuario, Now, -1)
            With flexDrag
                .RemoveItem(.Row)
                .Rows = .Rows + 1 '
            End With
        End If


Saida:
        Me.FinalizaDrapDrop()
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume
    End Sub

    Private Sub frmRoteiroV2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub treBreak_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treBreak.MouseMove
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub picBreak_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBreak.MouseMove
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub tbSair_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbSair.MouseMove
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub tbCancelar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCancelar.MouseMove
        FinalizaDrapDrop()

    End Sub

    Private Sub tbConsistencia_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbConsistencia.MouseMove
        Me.FinalizaDrapDrop()
        nCont = 10
    End Sub

    Private Sub tbGuia_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbGuia.MouseMove
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub tbSalvar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSalvar.MouseEnter
    End Sub

    Private Sub tbSalvar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbSalvar.MouseMove
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub tbOpcoes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbOpcoes.MouseMove
        Me.FinalizaDrapDrop()
    End Sub

    Private Sub tbCancelar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCancelar.MouseUp
    End Sub

    Private Sub _flxBreak_0_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flxBreak_0.Enter

    End Sub

    Private Sub UcVeiculo_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub UcVeiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub _flxBreak_0_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles _flxBreak_0.Validated
    End Sub

    Private Sub _flxBreak_0_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _flxBreak_0.Validating
    End Sub


    Private Sub _flxDisponivel_1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flxDisponivel_1.Enter
    End Sub

    Private Sub _flxDisponivel_2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flxDisponivel_2.Enter
    End Sub

    Private Sub _flxDisponivel_3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flxDisponivel_3.Enter
    End Sub

    Private Sub _flxDisponivel_4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flxDisponivel_4.Enter
    End Sub

    Private Sub _flxDisponivel_5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _flxDisponivel_5.Enter
    End Sub

    Private Sub tabDisponiveis_BeforeClick_1(ByVal sender As System.Object, ByVal e As AxComctlLib.ITabStripEvents_BeforeClickEvent) Handles tabDisponiveis.BeforeClick
    End Sub

    Private Sub tabDisponiveis_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabDisponiveis.ClickEvent
        _flxDisponivel_1.Visible = False
        _flxDisponivel_2.Visible = False
        _flxDisponivel_3.Visible = False
        _flxDisponivel_4.Visible = False
        _flxDisponivel_5.Visible = False
        With tabDisponiveis
            Select Case .SelectedItem.Index
                Case 1
                    _flxDisponivel_1.Visible = True
                    _flxDisponivel_1.BringToFront()
                    _flxDisponivel_1.Refresh()
                Case 2
                    _flxDisponivel_2.Visible = True
                    _flxDisponivel_2.BringToFront()
                    _flxDisponivel_2.Refresh()
                Case 3
                    _flxDisponivel_3.Visible = True
                    _flxDisponivel_3.BringToFront()
                    _flxDisponivel_3.Refresh()
                Case 4
                    _flxDisponivel_4.Visible = True
                    _flxDisponivel_4.BringToFront()
                    _flxDisponivel_4.Refresh()
                Case 5
                    _flxDisponivel_5.Visible = True
                    _flxDisponivel_5.BringToFront()
                    _flxDisponivel_5.Refresh()
                Case 6
                    _flxDisponivel_6.Visible = True
                    _flxDisponivel_6.BringToFront()
                    _flxDisponivel_6.Refresh()
            End Select
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Me.FinalizaDrapDrop()
        Resume Saida
        Resume

    End Sub

    Private Sub ucVeiculo_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucVeiculo.Load

    End Sub
End Class