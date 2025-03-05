Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmRoteiroConsistencia
	Inherits System.Windows.Forms.Form
    Dim nColunas As Short
    Dim aPrograma() As String
    Dim aProduto() As String
    Dim aSetor() As String
    Dim aBreak() As Short
    Dim aPosicao() As String
    Dim aQtd() As Short
    Dim aVeiculo() As String
	Dim bPermissaoArtistico As Boolean
	Dim bPermissaoComercial As Boolean
	Dim bConsisteBreak As Boolean
    Dim bCOnsisteInterPrograma As Boolean
    Dim bRowColChange As Boolean
    Dim dtsRoteiro As New MSAClass.AsmxRoteiro.dtsRoteiro
    Public asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro = NewRoteiro()
    Public asmxVeiculo As MSAClass.AsmxVeiculo.asmxVeiculo = NewVeiculo()
    Dim dtsVeiculo As New MSAClass.AsmxVeiculo.dtsVeiculo


    Private Sub AdicionaGridOcupacao(ByRef Par_Programa As Object, ByRef Par_Break As Object, ByRef Par_Titulo As Object, ByRef Par_Duracao As Object, ByRef Par_Encaixe As Object, ByVal Par_Tipo_Intervalo As Byte)
        On Error GoTo Erro
        Dim bMostra As Boolean = True


        If chkMostrarInter.Checked = False And Par_Break = 0 Then bMostra = False
        If chkMostrarLocal.Checked = False And Par_Tipo_Intervalo = 0 Then bMostra = False
        If chkMostrarNet.Checked = False And Par_Tipo_Intervalo = 1 Then bMostra = False
        If chkMostrarArtistico.Checked = False And Par_Tipo_Intervalo = 2 Then bMostra = False
        If chkMostrarLocal.Checked = False And Par_Tipo_Intervalo = 3 Then bMostra = False
        If chkMostrarInter.Checked = True And Par_Break = 0 Then bMostra = True
        If Par_Break = 0 And Not bCOnsisteInterPrograma Then bMostra = False

        If bMostra Then
            With flxOcupacao
                .Rows = .Rows + 1
                nLin = .Rows - 1
                .set_TextMatrix(nLin, 0, Par_Programa)
                .set_TextMatrix(nLin, 1, Par_Break)
                .set_TextMatrix(nLin, 2, FirstCaps(Par_Titulo))
                .set_TextMatrix(nLin, 3, Par_Duracao)
                .set_TextMatrix(nLin, 4, Par_Encaixe)
            End With
        End If
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
    Private Sub AdicionaGridRestricao(ByVal Par_Programa As String, ByVal Par_Break As Short, ByVal Par_Posicao As Short, ByVal Par_Titulo As String, ByVal Par_Restricao As String, ByRef Par_Horario As String)

        On Error GoTo Erro
        Dim nHorarioVeiculo As Short
        Dim nHorarioprograma As Short
        Dim nHorarioRestricao As Short

        If Par_Restricao = "" Then
            GoTo Saida
        End If

        nHorarioVeiculo = Val(VB.Left(txtInicioProgramacao.Text, 2)) * 60 + Val(VB.Right(txtInicioProgramacao.Text, 2))

        nHorarioprograma = Val(VB.Left(Par_Horario, 2)) * 60 + Val(VB.Right(Par_Horario, 2))
        'UPGRADE_WARNING: Couldn't resolve default property of object Par_Restricao. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        nHorarioRestricao = Val(VB.Left(Par_Restricao, 2)) * 60 + Val(VB.Right(Par_Restricao, 2))

        If nHorarioprograma < nHorarioVeiculo Then nHorarioprograma = nHorarioprograma + 1440
        If nHorarioRestricao < nHorarioVeiculo Then nHorarioRestricao = nHorarioRestricao + 1440

        If nHorarioRestricao > nHorarioprograma Then
            With flxRestricao
                .Rows = .Rows + 1
                nLin = .Rows - 1
                'UPGRADE_WARNING: Couldn't resolve default property of object Par_Programa. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .set_TextMatrix(nLin, 0, Par_Programa)
                'UPGRADE_WARNING: Couldn't resolve default property of object Par_Break. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .set_TextMatrix(nLin, 1, Par_Break)
                'UPGRADE_WARNING: Couldn't resolve default property of object Par_Posicao. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .set_TextMatrix(nLin, 2, Par_Posicao)
                'UPGRADE_WARNING: Couldn't resolve default property of object Par_Titulo. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .set_TextMatrix(nLin, 3, Par_Titulo)
                'UPGRADE_WARNING: Couldn't resolve default property of object Par_Restricao. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .set_TextMatrix(nLin, 4, Par_Restricao)
                'UPGRADE_WARNING: Couldn't resolve default property of object Par_Horario. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .set_TextMatrix(nLin, 5, Par_Horario)
                tabConsistencia.Tabs(4).Image = 2
            End With
        End If

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub AdicionaGridFitaPendente(ByRef Par_Programa As Object, ByRef Par_Break As Object, ByRef Par_Posicao As Object, ByRef Par_Titulo As Object)
		On Error GoTo Erro
		
		With flxFitaPendente
			.Rows = .Rows + 1
			nLin = .Rows - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Par_Programa. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.set_TextMatrix(nLin, 0, Par_Programa)
			'UPGRADE_WARNING: Couldn't resolve default property of object Par_Break. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.set_TextMatrix(nLin, 1, Par_Break)
			'UPGRADE_WARNING: Couldn't resolve default property of object Par_Posicao. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.set_TextMatrix(nLin, 2, Par_Posicao)
			'UPGRADE_WARNING: Couldn't resolve default property of object Par_Titulo. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.set_TextMatrix(nLin, 3, Par_Titulo)
			tabConsistencia.Tabs(3).Image = 2
			
		End With
		
Saida: 
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
	End Sub
	
	
    Private Sub AdicionaMatrizProdutos(ByVal Par_Programa As String, ByVal Par_Produto As String, ByVal Par_Break As Short, ByVal Par_Posicao As Short, ByVal Par_Veiculo_Origem As String, ByVal Par_Setor As String)

        On Error GoTo Erro
        Dim nIndex As Short
        Dim nElemento As Short

        If Par_Produto = "" Then
            GoTo Saida
        End If

        nElemento = -1
        If Not aProduto Is Nothing Then
            For nIndex = 0 To UBound(aProduto)
                If Not aPrograma(nIndex) Is Nothing Then
                    If aPrograma(nIndex).ToString = Par_Programa And aProduto(nIndex).ToString = VB.Left(Par_Produto, 6) And aBreak(nIndex) = Par_Break Then
                        nElemento = nIndex
                        Exit For
                    End If
                End If
            Next nIndex
        End If

        If nElemento = -1 Then
            If aPrograma Is Nothing Then
                nElemento = 0
            Else
                nElemento = UBound(aPrograma) + 1
            End If
            ReDim Preserve aPrograma(nElemento)
            ReDim Preserve aProduto(nElemento)
            ReDim Preserve aBreak(nElemento)
            ReDim Preserve aPosicao(nElemento)
            ReDim Preserve aQtd(nElemento)
            ReDim Preserve aVeiculo(nElemento)
            ReDim Preserve aSetor(nElemento)
        End If

        aPrograma(nElemento) = Par_Programa
        aProduto(nElemento) = VB.Left(Par_Produto, 6)
        aBreak(nElemento) = Par_Break
        aPosicao(nElemento) = aPosicao(nElemento) & Par_Posicao & ","
        aQtd(nElemento) = aQtd(nElemento) + 1
        aVeiculo(nElemento) = aVeiculo(nElemento) & "#" & Par_Veiculo_Origem & "#"
        aSetor(nElemento) = Par_Setor
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub CarregaOrdenacao()
		On Error GoTo Erro
		Dim nRow As Short

		Dim nBreak As Short
		Dim nDuracao As Short
		Dim nEncaixe As Short
		Dim sProduto As String
		Dim sPrograma As String
		Dim nPosicao As Short
		Dim sTitulo As String
		Dim sHorario As String
        Dim sVeiculoOrigem As String
        Dim sSetor As String
        Dim nTipoBreak As Byte

		If UCase(fParametro(118,  ,  , txtVeiculo.Text)) = "SIM" Then
			bCOnsisteInterPrograma = True
		Else
			bCOnsisteInterPrograma = False
		End If
		
		
		flxOcupacao.Visible = False
		Call ConfiguraGridOcupacao()
		Call ConfiguraGridFitaPendente()
		Call ConfiguraGridConcorrencia()
		Call ConfiguraGridRestricao()

        Dim fFlex As AxMSFlexGridLib.AxMSFlexGrid
        fFlex = frmRoteiroV2.flxBreak(0)

        '=============Le o Grid de Roteiro Ordenado e carrega consistencias
        With fFlex
            For nRow = 1 To .Rows - 1
                nBreak = Val(.get_TextMatrix(nRow, fColuna(fFlex, "Break")))
                nPosicao = Val(.get_TextMatrix(nRow, fColuna(fFlex, "")))
                nDuracao = Val(.get_TextMatrix(nRow, fColuna(fFlex, "Dur.")))
                nEncaixe = Val(.get_TextMatrix(nRow, fColuna(fFlex, "Enc.")))
                sProduto = .get_TextMatrix(nRow, fColuna(fFlex, "Produto"))
                sTitulo = .get_TextMatrix(nRow, fColuna(fFlex, "Comercial"))
                sHorario = .get_TextMatrix(nRow, fColuna(fFlex, "Horario Restricao"))
                sVeiculoOrigem = .get_TextMatrix(nRow, fColuna(fFlex, "Veiculo Origem"))
                sPrograma = .get_TextMatrix(nRow, fColuna(fFlex, "codigo programa"))
                sSetor = .get_TextMatrix(nRow, fColuna(fFlex, "setor"))
                sSetor = .get_TextMatrix(nRow, fColuna(fFlex, "Tipo Intervalo"))

                nTipoBreak = Val(.get_TextMatrix(nRow, fColuna(fFlex, "Tipo Intervalo")))

                '----Se for uma linha titulo de Intervalo
                If .get_TextMatrix(nRow, fColuna(fFlex, "Indica Titulo do Intervalo")) = "1" Then
                    Call AdicionaGridOcupacao(sPrograma, nBreak, sTitulo, nDuracao, nEncaixe, nTipoBreak)
                End If

                '----Se For Linha de Comercial Ordenado

                If .get_TextMatrix(nRow, fColuna(fFlex, "Indica Titulo Break")) <> "1" And .get_TextMatrix(nRow, fColuna(fFlex, "Indica Titulo do Intervalo")) <> "1" And .get_TextMatrix(nRow, fColuna(fFlex, "Indica_Titulo_Programa")) <> "1" And .get_TextMatrix(nRow, fColuna(fFlex, "Comercial")) <> "" Then
                    Call AdicionaMatrizProdutos(sPrograma, sProduto, nBreak, nPosicao, sVeiculoOrigem, sSetor)
                    Call AdicionaGridRestricao(sPrograma, nBreak, nPosicao, sTitulo, sHorario, txtHorarioPrograma.Text)
                    If Trim(.get_TextMatrix(nRow, fColuna(fFlex, "Fita"))) = "" And sVeiculoOrigem = txtVeiculo.Text Then
                        Call AdicionaGridFitaPendente(sPrograma, nBreak, nPosicao, sTitulo)
                    End If
                End If
            Next nRow
        End With
        '========================Carrega o Grid de Comerciais Concorrentes
        If Not aProduto Is Nothing Then
            With flxConcorrencia
                For nRow = 0 To UBound(aProduto)
                    If aQtd(nRow) > 1 And InStr(aVeiculo(nRow), "#" & txtVeiculo.Text & "#") > 0 Then
                        .Rows = .Rows + 1
                        nLin = .Rows - 1
                        .set_TextMatrix(nLin, 0, aPrograma(nRow))
                        .set_TextMatrix(nLin, 1, aBreak(nRow))
                        .set_TextMatrix(nLin, 2, aSetor(nRow))
                        .set_TextMatrix(nLin, 3, VB.Left(aPosicao(nRow), Len(aPosicao(nRow)) - 1))
                        tabConsistencia.Tabs(2).Image = 2
                    End If
                Next nRow
            End With
        End If
Saida:
        flxOcupacao.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	Private Sub CarregaRoteiroGravado()
		
		On Error GoTo Erro
		Dim nRow As Short
		
        Dim nBreak As Short
		Dim nDuracao As Short
		Dim nEncaixe As Short
        Dim sProduto As String = ""
        Dim sPrograma As String = ""
		Dim nPosicao As Short
        Dim sTitulo As String = ""
        Dim sVeiculoOrigem As String = ""
        Dim sHorarioProduto As String = ""
        Dim sHorarioPrograma As String = ""
        Dim sSetor As String = ""
        Dim nTipoBreak As Byte

		If UCase(fParametro(118,  ,  , txtVeiculo.Text)) = "SIM" Then
			bCOnsisteInterPrograma = True
		Else
			bCOnsisteInterPrograma = False
		End If
		
		flxOcupacao.Visible = False
		Call ConfiguraGridOcupacao()
		Call ConfiguraGridFitaPendente()
		Call ConfiguraGridConcorrencia()
        Call ConfiguraGridRestricao()


        DtsRoteiro = AsmxRoteiro.spuCarregar_Roteiro(txtVeiculo.Text, txtData.Text, txtPrograma.Text, 0, 0)
        Mensagem("Consistindo Roteiro....Aguarde !")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor


        For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_OrdenadoRow In dtsRoteiro.dtbRoteiro_Ordenado.Select()
            nBreak = drw.Breaks
            nDuracao = drw.Duracao
            nEncaixe = drw.Encaixe
            If Not drw.IsCod_ProdutoNull Then sProduto = drw.Cod_Produto
            If Not drw.IsTitulo_ComercialNull Then sTitulo = drw.Titulo_Comercial
            If Not drw.IsHorario_RestricaoNull Then sHorarioProduto = drw.Horario_Restricao
            If Not drw.IsCod_FaixaNull Then sHorarioPrograma = drw.Cod_Faixa
            If Not drw.IsCod_ProgramaNull Then sPrograma = drw.Cod_Programa
            If Not drw.IsCod_Veiculo_OrigemNull Then sVeiculoOrigem = drw.Cod_Veiculo_Origem
            If Not drw.IsSetorNull Then sSetor = drw.Setor
            nTipoBreak = Val(Vernulo(drw.Item("Tipo_Break"), ""))
            If drw.Indica_Titulo_Break = 1 Then
                nPosicao = 0
            End If

            '----Se for uma linha titulo de Intervalo - cria a linha no grid para

            If drw.Indica_Titulo_Intervalo = 1 Then
                Call AdicionaGridOcupacao(sPrograma, nBreak, drw.Titulo_Intervalo, nDuracao, nEncaixe, ntipoBreak)
            End If

            If drw.Indica_Titulo_Intervalo = 0 And drw.Indica_Titulo_Break = 0 Then
                nPosicao = nPosicao + 1
                Call AdicionaMatrizProdutos(sPrograma, sProduto, nBreak, nPosicao, sVeiculoOrigem, sSetor)
                Call AdicionaGridRestricao(sPrograma, nBreak, nPosicao, sTitulo, sHorarioProduto, sHorarioPrograma)

                If drw.Numero_Fita.Trim = "" Then
                    If sVeiculoOrigem = txtVeiculo.Text Then
                        Call AdicionaGridFitaPendente(sPrograma, nBreak, nPosicao, sTitulo)
                    End If
                End If
            End If

        Next


        '========================Carrega o Grid de Comerciais Concorrentes
        If Not aProduto Is Nothing Then
            With flxConcorrencia
                For nRow = 0 To UBound(aProduto)
                    If aQtd(nRow) > 1 And InStr(aVeiculo(nRow), "#" & txtVeiculo.Text & "#") > 0 Then
                        .Rows = .Rows + 1
                        nLin = .Rows - 1
                        .set_TextMatrix(nLin, 0, aPrograma(nRow))
                        .set_TextMatrix(nLin, 1, aBreak(nRow))

                        .set_TextMatrix(nLin, 2, aSetor(nRow))
                        .set_TextMatrix(nLin, 3, VB.Left(aPosicao(nRow), Len(aPosicao(nRow)) - 1))
                        tabConsistencia.Tabs(2).Image = 2
                    End If
                Next nRow
            End With
        End If

Saida:

        flxOcupacao.Visible = True
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub CarregaTotalPrograma()

        On Error GoTo Erro
        Dim sProgramaAnterior As String
        Dim nTotalDuracao As Short
        Dim nTotalEncaixe As Short
        Dim nRow As Short
        Dim nCol As Short

        With flxOcupacao
            If .Rows = .FixedRows Then
                GoTo Saida
            End If
            sProgramaAnterior = .get_TextMatrix(1, 0)
            .Rows = .Rows + 1
            nRow = 0
            Do
                nRow = nRow + 1
                If nRow >= .Rows Then
                    Exit Do
                End If

                If sProgramaAnterior <> .get_TextMatrix(nRow, 0) Or .get_TextMatrix(nRow, 1) = "" Then
                    sProgramaAnterior = .get_TextMatrix(nRow, 0)
                    .AddItem("", nRow)
                    .set_TextMatrix(nRow, 0, "Total")
                    .set_TextMatrix(nRow, 1, "Total")
                    .set_TextMatrix(nRow, 2, "Total")
                    .set_TextMatrix(nRow, 3, nTotalDuracao & ".")
                    .set_TextMatrix(nRow, 4, nTotalEncaixe)
                    .Row = nRow
                    .Col = 0
                    .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter

                    For nCol = 0 To .Cols - 1
                        .Col = nCol
                        .CellForeColor = System.Drawing.Color.Blue
                        .CellFontBold = True
                        .CellFontSize = 12
                        '.CellFontItalic = True
                        '.CellFontBold = True
                        '.CellBackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                        .CellBackColor = System.Drawing.Color.Yellow
                    Next nCol
                    flxOcupacao.set_MergeRow(nRow, True)
                    nTotalDuracao = 0
                    nTotalEncaixe = 0
                    nRow = nRow + 1 '  avanca porque adicinou uma linha
                End If
                nTotalDuracao = nTotalDuracao + Val(.get_TextMatrix(nRow, 3))
                nTotalEncaixe = nTotalEncaixe + Val(.get_TextMatrix(nRow, 4))
            Loop
            .RemoveItem(.Rows - 1)
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGridConcorrencia()
        On Error GoTo Erro
        With flxConcorrencia
            .Visible = False
            .Clear()
            .Top = VB6.TwipsToPixelsY(180)
            .Left = VB6.TwipsToPixelsX(90)
            .Width = VB6.TwipsToPixelsX(10320)
            .Height = VB6.TwipsToPixelsY(5190)
            .ScrollTrack = 0
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .Rows = 1
            .FixedCols = 0
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictRows
            .set_MergeCol(0, True)
            .set_MergeCol(1, True)
            .RowHeightMin = 300

            .FormatString = "<Programa|^Break|<Sub Setor |<Posições"
            .set_ColWidth(0, 900)
            .set_ColWidth(1, 570)
            .set_ColWidth(2, 6885)
            .set_ColWidth(3, 1605)

        End With

Saida:
        flxConcorrencia.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGridOcupacao()
        On Error GoTo Erro
        With flxOcupacao
            .Visible = False
            .Clear()
            .Top = VB6.TwipsToPixelsY(180)
            .Left = VB6.TwipsToPixelsX(90)
            .Width = VB6.TwipsToPixelsX(10320)
            .Height = VB6.TwipsToPixelsY(5190)
            .ScrollTrack = 0
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .Rows = 1
            .FixedCols = 0
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictRows
            .set_MergeCol(0, True)
            .set_MergeCol(1, True)
            .RowHeightMin = 300

            .FormatString = "<Programa|^Break|<Intervalo|^Duração|^Encaixe|Ocorrencia|^Status"
            .set_ColWidth(0, 900)
            .set_ColWidth(1, 570)
            .set_ColWidth(2, 1440)
            .set_ColWidth(3, 735)
            .set_ColWidth(4, 735)
            .set_ColWidth(5, 4955)
            .set_ColWidth(6, 640)

        End With

Saida:
        flxOcupacao.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub ConfiguraGridFitaPendente()
        On Error GoTo Erro
        With flxFitaPendente
            .Visible = False
            .Clear()
            .Top = VB6.TwipsToPixelsY(180)
            .Left = VB6.TwipsToPixelsX(90)
            .Width = VB6.TwipsToPixelsX(10320)
            .Height = VB6.TwipsToPixelsY(5190)
            .ScrollTrack = 0
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .Rows = 1
            .FixedCols = 0
            .RowHeightMin = 300
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictRows
            .set_MergeCol(0, True)
            .set_MergeCol(1, True)


            .FormatString = "<Programa|^Break|^Posicao|<Titulo"
            .set_ColWidth(0, 900)
            .set_ColWidth(1, 570)
            .set_ColWidth(2, 735)
            .set_ColWidth(3, 7755)
        End With

Saida:
        flxFitaPendente.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGridRestricao()
        On Error GoTo Erro
        With flxRestricao
            .Visible = False
            .Clear()
            .Top = VB6.TwipsToPixelsY(180)
            .Left = VB6.TwipsToPixelsX(90)
            .Width = VB6.TwipsToPixelsX(10320)
            .Height = VB6.TwipsToPixelsY(5190)
            .ScrollTrack = 0
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .Rows = 1
            .FixedCols = 0
            .RowHeightMin = 300
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictRows
            .set_MergeCol(0, True)
            .set_MergeCol(1, True)

            .FormatString = "<Programa|^Break|^Posicao|<Titulo|^Restrição|^Hor. Prog."
            .set_ColWidth(0, 900)
            .set_ColWidth(1, 570)
            .set_ColWidth(2, 735)
            .set_ColWidth(3, 6095)
            .set_ColWidth(4, 865)
            .set_ColWidth(5, 810)
        End With


        '=================Busca o Horario de Inicio da Programacao do Veiculo
        Dim drw As MSAClass.AsmxVeiculo.dtsVeiculo.dtbVeiculoRow
        DtsVeiculo = AsmxVeiculo.spuCarregar(txtVeiculo.Text)
        txtInicioProgramacao.Text = "05:00" ' default 
        If DtsVeiculo.dtbVeiculo.Rows.Count > 0 Then
            drw = DtsVeiculo.dtbVeiculo.Rows(0)
            If Not drw.IsHora_Inicio_ProgramacaoNull Then
                txtInicioProgramacao.Text = drw.Hora_Inicio_Programacao
            End If
        End If
Saida:
        flxRestricao.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGridNaoOrdenados()
        On Error GoTo Erro
        With flxNaoOrdenados
            .Visible = False
            .Clear()
            .Top = VB6.TwipsToPixelsY(180)
            .Left = VB6.TwipsToPixelsX(90)
            .Width = VB6.TwipsToPixelsX(10320)
            .Height = VB6.TwipsToPixelsY(5190)
            .Rows = 20
            .ScrollTrack = 0
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .FixedCols = 0
            .RowHeightMin = 300
            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictRows
            .set_MergeCol(0, True)
            .FormatString = "Programa|Empresa|Contrato|Seq.|Comercial|Tipo Com|Duracao|Fita"
            .set_ColWidth(0, 900)
            .set_ColWidth(1, 765)
            .set_ColWidth(2, 750)
            .set_ColWidth(3, 450)
            .set_ColWidth(4, 4500)
            .set_ColWidth(5, 825)
            .set_ColWidth(6, 705)
            .set_ColWidth(7, 1080)
        End With

Saida:
        flxNaoOrdenados.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Function Encerramento(ByRef Par_Tipo As String) As Boolean

        On Error GoTo Erro
        Encerramento = True
        Dim aCampos(2) As Object
        Dim aValores(2) As Object
        Dim sMensagemLog As String

        'Select Case Par_Tipo
        '    Case "AR"
        '        aCampos(2) = "Indica_Fechamento_Artistico"
        '        sMensagemLog = "Encerramento do Roteiro Artistico"
        '    Case "CO"
        '        aCampos(2) = "Indica_Fechamento_Comercial"
        '        sMensagemLog = "Encerramento do Roteiro Comercial"
        'End Select

        DtsRoteiro = AsmxRoteiro.spuCarregaRoteiro_Fechamento(txtVeiculo.Text, txtData.Text)



        If DtsRoteiro.dtbRoteiro_Fechamento.Count = 0 Then
            DtsRoteiro.dtbRoteiro_Fechamento.AdddtbRoteiro_FechamentoRow(txtData.Text, _
                                                                         txtVeiculo.Text, _
                                                                         1, _
                                                                        1)

        Else
            Dim drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_FechamentoRow
            drw = DtsRoteiro.dtbRoteiro_Fechamento.Rows(0)
            drw.Indica_Fechamento_Artistico = 1
            drw.Indica_Fechamento_Comercial = 1

        End If


        AsmxRoteiro.spuAtualizaRoteiro_Fechamento(DtsRoteiro)


        ' GravaLog(txtVeiculo.Text, txtData.Text, , , , , , , , , , , "Encerramento do Roteiro")

        Me.Cursor = Cursors.Default



Saida:
        Me.Cursor = Cursors.Default
        Exit Function
Erro:
        Encerramento = False
        Erro(Err.Number)
        Resume Saida
    End Function



    Private Sub MostraNaoOrdenadosRoteiro()

        On Error GoTo Erro
        Dim nRow As Short = 0
        Dim sPrograma As String = ""
        Dim bValido As Boolean = False
        Dim bCritica As Boolean = False
        bCritica = False


        nLin = 0

        '======================================>Em Programas
        'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        With frmRoteiroV2.flxDisponivel(1)
            'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
            For nRow = 1 To .Rows - 1
                bValido = True
                sPrograma = .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "codigo programa"))
                'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                If .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "Indica_Titulo_Programa")) = "1" Then
                    bValido = False
                End If


                'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                If Trim(.get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "Comercial"))) = "" Then
                    bValido = False
                End If

                If bValido Then
                    bCritica = True
                    nLin = nLin + 1
                    If nLin >= flxNaoOrdenados.Rows - 1 Then
                        flxNaoOrdenados.Rows = flxNaoOrdenados.Rows + 1
                    End If

                    flxNaoOrdenados.set_TextMatrix(nLin, 0, sPrograma)
                    flxNaoOrdenados.set_TextMatrix(nLin, 1, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "empresa")))
                    flxNaoOrdenados.set_TextMatrix(nLin, 2, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "contrato")))
                    flxNaoOrdenados.set_TextMatrix(nLin, 3, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "seq")))
                    flxNaoOrdenados.set_TextMatrix(nLin, 4, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "comercial")))
                    flxNaoOrdenados.set_TextMatrix(nLin, 5, "")
                    flxNaoOrdenados.set_TextMatrix(nLin, 6, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "dur.")))
                    flxNaoOrdenados.set_TextMatrix(nLin, 7, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "Fita")))
                End If
            Next nRow
        End With


        '======================================>Em Rotativos
        'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        With frmRoteiroV2.flxDisponivel(2)
            'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
            For nRow = 1 To .Rows - 1
                bValido = True

                Select Case UCase(txtForm.Text)
                    Case "FRMROTEIROV2"
                        'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                        If .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(2), "Indica_Titulo_Programa")) = "1" Then
                            bValido = False
                        End If
                        'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                        sPrograma = .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(2), "codigo programa"))
                    Case "FRMROTEIRO"
                        sPrograma = txtPrograma.Text
                End Select

                'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                If Trim(.get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(1), "Comercial"))) = "" Then
                    bValido = False
                End If


                If bValido Then
                    bCritica = True
                    nLin = nLin + 1
                    If nLin >= flxNaoOrdenados.Rows - 1 Then
                        flxNaoOrdenados.Rows = flxNaoOrdenados.Rows + 1
                    End If

                    '
                    flxNaoOrdenados.set_TextMatrix(nLin, 0, sPrograma)
                    'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    flxNaoOrdenados.set_TextMatrix(nLin, 1, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(2), "empresa")))
                    'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    flxNaoOrdenados.set_TextMatrix(nLin, 2, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(2), "contrato")))
                    'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    flxNaoOrdenados.set_TextMatrix(nLin, 3, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(2), "seq")))
                    'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    flxNaoOrdenados.set_TextMatrix(nLin, 4, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(2), "comercial")))
                    flxNaoOrdenados.set_TextMatrix(nLin, 5, "")
                    'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    flxNaoOrdenados.set_TextMatrix(nLin, 6, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(2), "dur.")))
                    'UPGRADE_ISSUE: Control flxDisponivel could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    flxNaoOrdenados.set_TextMatrix(nLin, 7, .get_TextMatrix(nRow, fColuna(frmRoteiroV2.flxDisponivel(2), "Fita")))
                End If
            Next nRow
        End With



        If bCritica Then
            tabConsistencia.Tabs(5).Image = 2
        End If

Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Private Sub MostraNaoOrdenados()
        On Error GoTo Erro



        DtsRoteiro = AsmxRoteiro.spuCarregar_Comerciais(txtVeiculo.Text, txtData.Text, txtPrograma.Text)
        nLin = 0
        With flxNaoOrdenados
            For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_ComerciaisRow In dtsRoteiro.dtbRoteiro_Comerciais.Select()
                nLin = nLin + 1
                If nLin >= .Rows Then
                    .Rows = .Rows + 1
                End If

                .set_TextMatrix(nLin, 0, drw.Cod_Programa)
                .set_TextMatrix(nLin, 1, drw.Cod_Empresa)
                .set_TextMatrix(nLin, 2, drw.Numero_Mr)
                .set_TextMatrix(nLin, 3, drw.Sequencia_Mr)
                .set_TextMatrix(nLin, 4, drw.Cod_Comercial & "-" & FirstCaps(drw.Titulo_Comercial))
                .set_TextMatrix(nLin, 5, drw.Cod_Tipo_Comercial)
                .set_TextMatrix(nLin, 6, drw.Duracao)
                .set_TextMatrix(nLin, 7, drw.Numero_Fita)
            Next
        End With

        DtsRoteiro.Clear()
        DtsRoteiro = AsmxRoteiro.spuCarregar_Rotativo(txtVeiculo.Text, txtData.Text, txtPrograma.Text, 1)

        With flxNaoOrdenados
            For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_RotativoRow In dtsRoteiro.dtbRoteiro_Rotativo.Select()
                nLin = nLin + 1
                If nLin >= .Rows Then
                    .Rows = .Rows + 1
                End If
                .set_TextMatrix(nLin, 0, drw.Cod_Programa)
                .set_TextMatrix(nLin, 1, drw.Cod_Empresa)
                .set_TextMatrix(nLin, 2, drw.Numero_Mr)
                .set_TextMatrix(nLin, 3, drw.Sequencia_Mr)
                .set_TextMatrix(nLin, 4, drw.Cod_Comercial & "-" & FirstCaps(drw.Titulo_Comercial))
                .set_TextMatrix(nLin, 5, drw.Cod_Tipo_Comercial)
                .set_TextMatrix(nLin, 6, drw.Duracao)
                .set_TextMatrix(nLin, 7, drw.Numero_Fita)
                ' ADORs.MoveNext()
            Next
        End With

        If nLin > 0 Then
            tabConsistencia.Tabs(5).Image = 2
        End If

Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub MostraStatusOcupacao()
        On Error GoTo Erro
        Dim nRow, nDiferenca As Short

        With flxOcupacao
            .Visible = False
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, 0) = "" Then
                    Exit For
                End If
                .Row = nRow
                .Col = 6
                .CellFontSize = 14
                .CellFontName = "Wingdings"
                nDiferenca = Val(.get_TextMatrix(nRow, 3)) - Val(.get_TextMatrix(nRow, 4))
                If nDiferenca > 0 Then
                    .set_TextMatrix(nRow, 5, "Falta Encaixar " & nDiferenca & Chr(34))
                    .set_TextMatrix(nRow, 6, Chr(251))
                    .CellForeColor = System.Drawing.Color.Red
                    tabConsistencia.Tabs(1).Image = 2
                ElseIf nDiferenca < 0 Then
                    .set_TextMatrix(nRow, 5, "Estouro de " & System.Math.Abs(nDiferenca) & Chr(34))
                    .set_TextMatrix(nRow, 6, Chr(251))
                    .CellForeColor = System.Drawing.Color.Red
                    tabConsistencia.Tabs(1).Image = 2
                Else
                    .set_TextMatrix(nRow, 5, "")
                    .set_TextMatrix(nRow, 6, Chr(252))
                    .CellForeColor = System.Drawing.Color.Blue
                End If
            Next nRow
        End With

Saida:
        flxOcupacao.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
    End Sub


    'UPGRADE_WARNING: Event chkOrdenacao.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkOrdenacao_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkOrdenacao.CheckStateChanged

        On Error GoTo Erro

        'If txtVeiculo = "" Or txtData = "" Or txtPrograma = "" Then
        If txtVeiculo.Text = "" Or txtData.Text = "" Then
            GoTo Saida
        End If


        Call CarregaOrdenacao()
        Call CarregaTotalPrograma()
        Call MostraStatusOcupacao()
        Call MostraNaoOrdenadosRoteiro()

        With flxOcupacao
            If .Rows < 18 Then .Rows = 18
        End With

        With flxFitaPendente
            If .Rows < 18 Then .Rows = 18
        End With

        With flxConcorrencia
            If .Rows < 18 Then .Rows = 18
        End With

        With flxRestricao
            If .Rows < 18 Then .Rows = 18
        End With

        tabConsistencia.Tabs(1).Selected = True
Saida:
        Exit Sub

Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub cmdOK_Click()

    End Sub

    'UPGRADE_WARNING: Event chkRoteiroGravado.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkRoteiroGravado_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkRoteiroGravado.CheckStateChanged
        On Error GoTo Erro

        If txtVeiculo.Text = "" Or txtData.Text = "" Then
            GoTo Saida
        End If


        Call CarregaRoteiroGravado()
        Call CarregaTotalPrograma()
        Call MostraStatusOcupacao()
        Call MostraNaoOrdenados()

        With flxOcupacao
            If .Rows < 18 Then .Rows = 18
        End With

        With flxFitaPendente
            If .Rows < 18 Then .Rows = 18
        End With

        With flxConcorrencia
            If .Rows < 18 Then .Rows = 18
        End With

        With flxRestricao
            If .Rows < 18 Then .Rows = 18
        End With

        tabConsistencia.Tabs(1).Selected = True

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume


    End Sub

    Private Sub cmdCancelaFechamento_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelaFechamento.Click
        Dim Index As Short = cmdCancelaFechamento.GetIndex(eventSender)
        picEncerramento.Visible = False
    End Sub

    Private Sub cmdEncerramento_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEncerramento.Click

        bPermissaoArtistico = True
        bPermissaoComercial = True

        If Not Encerramento("") Then
            Aviso("Houve erro no Encerramento.Processo Cancelado")
            GoTo Saida
        End If

        Aviso("Roteiro Encerrado com Sucesso")


        Me.Cursor = Cursors.WaitCursor

        If fParametro(27, , , txtVeiculo.Text) = "" Then
            Aviso("Parâmetro 27 não cadastrado !")
            GoTo Saida
        End If


Saida:

        Me.Cursor = Cursors.Default

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
    End Sub









    Private Sub cmdOkFechamento_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOkFechamento.Click

        On Error GoTo Erro

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If chkArtistico.CheckState = 1 Then
            If Not Encerramento("AR") Then
                Aviso("Houve erro no Encerramento.Processo Cancelado")
                GoTo Saida
            End If
        End If

        If chkComercial.CheckState = 1 Then
            If Not Encerramento("CO") Then
                Aviso("Houve erro no Encerramento.Processo Cancelado")
                GoTo Saida
            End If
        End If

        Aviso("Roteiro Encerrado com Sucesso")
        cmdSair_Click(cmdSair, New System.EventArgs())

Saida:

        Exit Sub
Erro:
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Dispose()
    End Sub



    Private Sub flxConcorrencia_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles flxConcorrencia.ClickEvent

    End Sub

    Private Sub flxConcorrencia_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxConcorrencia.MouseDownEvent
        If eventArgs.button = 2 And flxConcorrencia.MouseRow = 0 Then
            With flxConcorrencia
                'FlexOpcoes = flxConcorrencia
                '.Col = .MouseCol
                'frmOpcoesGrid.Text = Me.Text
                'frmOpcoesGrid.txtColunaAtual.Text = .MouseCol.ToString
                'frmOpcoesGrid.mnuOpcoes.ShowDropDown()
            End With
        End If
    End Sub


    Private Sub flxFitaPendente_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxFitaPendente.MouseDownEvent
        If eventArgs.button = 2 And flxFitaPendente.MouseRow = 0 Then
            With flxFitaPendente
                .Focus()
                .Col = .MouseCol
                'UPGRADE_ISSUE: Form method frmRoteiroConsistencia.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'PopupMenu(frmGeral.mnuGrid)



            End With
        End If
    End Sub


    Private Sub flxNaoOrdenados_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxNaoOrdenados.MouseDownEvent
        If eventArgs.button = 2 And flxNaoOrdenados.MouseRow = 0 Then
            With flxNaoOrdenados
                .Focus()
                .Col = .MouseCol
                'UPGRADE_ISSUE: Form method frmRoteiroConsistencia.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                ''PopupMenu(frmGeral.mnuGrid)

            End With
        End If
    End Sub


    Private Sub flxOcupacao_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxOcupacao.MouseDownEvent
        If eventArgs.button = 2 And flxOcupacao.MouseRow = 0 Then
            With flxOcupacao
                'FlexOpcoes = flxOcupacao
                '.Col = .MouseCol
                'frmOpcoesGrid.Text = Me.Text
                'frmOpcoesGrid.txtColunaAtual.Text = .MouseCol.ToString
                'frmOpcoesGrid.mnuOpcoes.ShowDropDown()
            End With
        End If

    End Sub

    Private Sub flxRestricao_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxRestricao.MouseDownEvent
        If eventArgs.button = 2 And flxRestricao.MouseRow = 0 Then
            With flxRestricao
                .Focus()
                .Col = .MouseCol
                'UPGRADE_ISSUE: Form method frmRoteiroConsistencia.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                ''PopupMenu(frmGeral.mnuGrid)

            End With
        End If
    End Sub


    Private Sub frmRoteiroConsistencia_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'Me.CenterToParent()
        'If bConsisteBreak Then
        ' frmConsisteBreak.txtVeiculo.Text = txtVeiculo.Text
        ' frmConsisteBreak.txtData.Text = txtData.Text
        ' frmConsisteBreak.txtPrograma.Text = txtPrograma.Text
        ' frmConsisteBreak.chkExibir.CheckState = System.Windows.Forms.CheckState.Checked
        ' If frmConsisteBreak.chkCritica.CheckState = 1 Then
        ' frmConsisteBreak.ShowDialog()
        ' End If
        ' frmConsisteBreak.Dispose()
        ' bConsisteBreak = False
        ' End If

    End Sub

    Private Sub frmRoteiroConsistencia_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        On Error GoTo Erro
        bRowColChange = True

        ReDim aPrograma(0)
        ReDim aProduto(0)
        ReDim aBreak(0)
        ReDim aPosicao(0)
        ReDim aQtd(0)
        ReDim aVeiculo(0)
        Me.Top = VB6.TwipsToPixelsY(600)
        Me.Left = VB6.TwipsToPixelsX(500)
        With tabConsistencia
            .Top = VB6.TwipsToPixelsY(135)
            .Left = VB6.TwipsToPixelsX(90)
            .Width = VB6.TwipsToPixelsX(10725)
            .Height = VB6.TwipsToPixelsY(5955)
        End With

        For nCont = 1 To fraConsistencia.Count
            With fraConsistencia(nCont)
                .Top = VB6.TwipsToPixelsY(450)
                .Left = VB6.TwipsToPixelsX(180)
                .Width = VB6.TwipsToPixelsX(10500)
                .Height = VB6.TwipsToPixelsY(5505)
                .Text = ""
                .Visible = False
            End With
        Next nCont

        picEncerramento.Top = VB6.TwipsToPixelsY(3735)
        picEncerramento.Left = VB6.TwipsToPixelsX(90)

        fraConsistencia(1).Visible = True

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
    End Sub
	


    Private Sub tabConsistencia_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabConsistencia.ClickEvent
        With tabConsistencia
            For nCont = 1 To .Tabs.Count
                fraConsistencia(nCont).Visible = False
            Next nCont
            fraConsistencia(.SelectedItem.Index).Visible = True
        End With

    End Sub

    Private Sub tabConsistencia_BeforeClick(ByVal sender As System.Object, ByVal e As AxComctlLib.ITabStripEvents_BeforeClickEvent) Handles tabConsistencia.BeforeClick

    End Sub

    Private Sub chkIniciar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIniciar.CheckedChanged
        Call ConfiguraGridOcupacao()
        Call ConfiguraGridConcorrencia()
        Call ConfiguraGridFitaPendente()
        Call ConfiguraGridRestricao()
        Call ConfiguraGridNaoOrdenados()
        bConsisteBreak = True

    End Sub

 
    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        On Error GoTo Erro

        Me.Cursor = Cursors.WaitCursor

        ReDim aPrograma(0)
        ReDim aProduto(0)
        ReDim aBreak(0)
        ReDim aPosicao(0)
        ReDim aQtd(0)
        ReDim aVeiculo(0)
        Call ConfiguraGridOcupacao()
        Call ConfiguraGridConcorrencia()
        Call ConfiguraGridFitaPendente()
        Call ConfiguraGridRestricao()
        Call ConfiguraGridNaoOrdenados()
        If chkOrdenacao.Checked Then chkOrdenacao_CheckStateChanged(New Object, New EventArgs)
        If chkRoteiroGravado.Checked Then chkRoteiroGravado_CheckStateChanged(New Object, New EventArgs)
        Me.Cursor = Cursors.Default
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
End Class