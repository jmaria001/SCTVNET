Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.IO

Friend Class frmOpcoesGrid

    Inherits System.Windows.Forms.Form
    Dim aExtensao() As String
    Private printFont As Font
    Private Shared filePath As String
    Private streamToPrint As StreamReader
    Dim nLinhaAtual As Integer
    Dim nPagina As String

    Private Sub GravaTxt()
        On Error GoTo Erro
        Dim nRow As Short
        Dim nCol As Short
        Dim aTamanhoColuna() As Object
        ReDim aTamanhoColuna(FlexOpcoes.Cols - 1)
        Dim sLinha As String
        Dim sTexto As String
        Dim nBuf As Short
        nBuf = FreeFile()

        FileOpen(nBuf, txtNomeArquivo.Text, OpenMode.Output)
        With FlexOpcoes
            .Redraw = False


            '=======================>Obtem o Maior tamanho de cada coluna
            For nRow = 0 To .Rows - 1
                For nCol = 0 To .Cols - 1
                    If Len(Trim(.get_TextMatrix(nRow, nCol))) > aTamanhoColuna(nCol) Then
                        aTamanhoColuna(nCol) = Len(Trim(.get_TextMatrix(nRow, nCol)))
                    End If
                Next nCol
            Next nRow
            '=======================>Formata linhas e grava Arquivo Text
            For nRow = 0 To .Rows - 1

                sLinha = ""
                For nCol = .FixedCols To .Cols - 1
                    sTexto = Trim(.get_TextMatrix(nRow, nCol))
                    'UPGRADE_WARNING: Couldn't resolve default property of object aTamanhoColuna(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTexto = sTexto & Space(aTamanhoColuna(nCol) - Len(sTexto))
                    sLinha = sLinha & sTexto & Space(4)
                Next nCol
                PrintLine(1, sLinha)
            Next nRow
            .Redraw = True
        End With

        Aviso("Fim da Exportação")
        CmdCancela_Click(cmdCancela.Item(0), New System.EventArgs())
Saida:
        FileClose(nBuf)
        FlexOpcoes.Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub GravaCsv()
        On Error GoTo Erro
        Dim nRow As Short
        Dim nCol As Short
        Dim nBuf As Short
        nBuf = FreeFile()

        FileOpen(nBuf, txtNomeArquivo.Text, OpenMode.Output)
        With FlexOpcoes
            .Redraw = False

            '=======================>Formata linhas e grava Arquivo CSV
            For nRow = 0 To .Rows - 1

                For nCol = .FixedCols To .Cols - 2
                    Write(1, .get_TextMatrix(nRow, nCol))
                Next nCol
                WriteLine(1, .get_TextMatrix(nRow, .Cols - 1))
            Next nRow
            .Redraw = True
        End With

        Aviso("Fim da Exportação")
        CmdCancela_Click(cmdCancela.Item(0), New System.EventArgs())
Saida:
        FileClose(nBuf)
        FlexOpcoes.Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub



    'UPGRADE_WARNING: Event cboFormato.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboFormato_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboFormato.SelectedIndexChanged
        txtNomeArquivo_Leave(txtNomeArquivo, New System.EventArgs())
    End Sub

    Private Sub CmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Dim Index As Short = cmdCancela.GetIndex(eventSender)
        Me.Dispose()
    End Sub

    Private Sub cmdConfigurarRelatorio_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConfigurarRelatorio.Click
        'fraConfiguracao.Top = VB6.TwipsToPixelsY(90)
        'fraConfiguracao.Left = VB6.TwipsToPixelsX(90)
        'fraConfiguracao.Width = VB6.TwipsToPixelsX(11130)
        'fraConfiguracao.Height = VB6.TwipsToPixelsY(2350)
        'fraImpressao.Visible = False
        'fraConfiguracao.Visible = True

        'txtTop.Text = CStr(VB6.PixelsToTwipsY(Me.Top))
        'txtHeight.Text = CStr(VB6.PixelsToTwipsY(Me.Height))
        'txtLeft.Text = CStr(VB6.PixelsToTwipsX(Me.Left))
        'txtWidth.Text = CStr(VB6.PixelsToTwipsX(Me.Width))

        'Me.Height = VB6.TwipsToPixelsY(3000)
        'Me.Width = VB6.TwipsToPixelsX(11600)
        'Me.Left = VB6.TwipsToPixelsX(200)
        With PageSetupDialog
            .Document = printDoc
            .PageSettings = printDoc.DefaultPageSettings
        End With

        If PageSetupDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            printDoc.DefaultPageSettings = PageSetupDialog.PageSettings
        End If

    End Sub



    Private Sub cmdImpressora_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImpressora.Click

        mdiPrincipal.prnPrincipal.ShowDialog()

    End Sub

    Private Sub cmdOkClassificacao_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOkClassificacao.Click

        On Error GoTo Erro
        Dim nRow As Short
        Dim nColunas As Short
        Dim bEmBranco As Boolean
        With FlexOpcoes
            .Row = 0
            .Redraw = False
            For nRow = .Rows - 1 To .FixedRows Step -1
                bEmBranco = True
                For nColunas = 1 To .Cols - 1
                    If Trim(.get_TextMatrix(nRow, nColunas)) <> "" Then
                        bEmBranco = False
                        Exit For
                    End If
                Next nColunas
                If bEmBranco And nRow > .FixedRows Then
                    .RemoveItem(nRow)
                Else
                    Exit For
                End If
            Next nRow

            For nColunas = 0 To .Cols - 1
                If Trim(.get_TextMatrix(.FixedRows - 1, nColunas)) = lstClassificacao.Text Then
                    .Col = nColunas
                    Exit For
                End If
            Next nColunas

            Select Case True
                Case optAscendente.Checked
                    .Sort = MSFlexGridLib.SortSettings.flexSortGenericAscending
                Case optDescendente.Checked
                    .Sort = MSFlexGridLib.SortSettings.flexSortGenericDescending
            End Select

            Do
                If .get_RowPos(.Rows - 1) >= VB6.PixelsToTwipsY(.Height) Then
                    Exit Do
                Else
                    .Rows = .Rows + 1
                End If
            Loop

            .Redraw = True
            .Row = 1
            .Col = 1
            .TopRow = .FixedRows
        End With

        CmdCancela_Click(cmdCancela.Item(0), New System.EventArgs())
Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub cmdOkExportar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOkExportar.Click
        Select Case cboFormato.SelectedIndex
            Case 0
                Call GravaTxt()
            Case 1
                Call GravaCsv()
            Case 2

        End Select
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        On Error GoTo Erro
        With FlexOpcoes
            nLinhaAtual = .FixedRows
        End With
        nPagina = 0
        CmdCancela_Click(cmdCancela.Item(0), New System.EventArgs())
        If optImpressora.Checked Then
            printDoc.Print()
        Else
            PrintPreviewDialog.Document = printDoc
            PrintPreviewDialog.ShowDialog()
        End If

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub cmdOkLocalizar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOkLocalizar.Click

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        On Error GoTo Erro
        Dim nLoop As Short
        Dim bValido As Boolean
        Dim bEncontrou As Boolean
        Dim aRows() As Object
        Dim nRow As Short
        Dim nSubstituidos As Short
        ReDim aRows(0)
        Dim nColuna As Short

        txtLocalizar.Text = Trim(txtLocalizar.Text)

        If txtLocalizar.Text = "" Then
            GoTo Saida
        End If




        bEncontrou = False
        nSubstituidos = 0
        With FlexOpcoes
            .Redraw = False

            For nColuna = 0 To .Cols - 1
                If Trim(.get_TextMatrix(.FixedRows - 1, nColuna)) = Trim(cboColuna.Text) Then
                    Exit For
                End If
            Next nColuna

            For nLoop = .FixedRows To .Rows - 1

                bValido = False
                Select Case cboTipoBusca.SelectedIndex
                    Case 0
                        If UCase(txtLocalizar.Text) = UCase(VB.Left(.get_TextMatrix(nLoop, nColuna), Len(txtLocalizar.Text))) Then
                            bValido = True
                        End If
                    Case 1
                        If InStr(UCase(.get_TextMatrix(nLoop, nColuna)), UCase(txtLocalizar.Text)) > 0 Then
                            bValido = True
                        End If
                    Case 1
                        If UCase(Trim(.get_TextMatrix(nLoop, nColuna))) = UCase(txtLocalizar.Text) Then
                            bValido = True
                        End If
                End Select

                If bValido Then
                    bEncontrou = True
                    If optApenasLocalizar.Checked Then
                        nRow = nLoop
                        Exit For
                    End If
                Else
                    If optLocalizarFiltrar.Checked Then
                        ReDim Preserve aRows(UBound(aRows) + 1)
                        'UPGRADE_WARNING: Couldn't resolve default property of object aRows(UBound()). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        aRows(UBound(aRows)) = nLoop
                    End If
                End If
            Next nLoop

            If bEncontrou Then
                For nLoop = UBound(aRows) To 1 Step -1
                    'UPGRADE_WARNING: Couldn't resolve default property of object aRows(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    .RemoveItem(aRows(nLoop))
                    If .get_RowPos(nLoop) < VB6.PixelsToTwipsY(.Height) Then
                        .Rows = .Rows + 1
                    End If
                Next nLoop
            Else
                .Redraw = True
                Aviso("Texto não Encontrado")
                txtLocalizar.Focus()
            End If
        End With
        If bEncontrou Then
            If optLocalizarFiltrar.Checked Then
                nRow = 1
            End If
            FlexOpcoes.Redraw = True
            FlexOpcoes.Row = 0
            FlexOpcoes.Row = nRow
            FlexOpcoes.TopRow = nRow
            CmdCancela_Click(cmdCancela.Item(0), New System.EventArgs())
        End If
Saida:
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        FlexOpcoes.Redraw = True

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub cmdSalvar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSalvar.Click
        On Error GoTo Erro
        mdiPrincipal.savPrincipal.Title = "Enviar Para"
        mdiPrincipal.savPrincipal.ShowDialog()
        'mdiPrincipal.savPrincipal.Filter = cboFormato.Text
        mdiPrincipal.savPrincipal.ShowDialog()
        txtNomeArquivo.Text = mdiPrincipal.savPrincipal.FileName
        txtNomeArquivo_Leave(txtNomeArquivo, New System.EventArgs())
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmOpcoesGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick

    End Sub

    Private Sub frmOpcoesGrid_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        chkClassificar.Checked = False
        chkExportar.Checked = False
        chkImprimir.Checked = False
        chkLocalizar.Checked = False
    End Sub


    Private Sub frmOpcoesGrid_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.CenterToParent()
        nLinhaAtual = 0
    End Sub

    Private Sub Imprimir()
        'On Error GoTo Erro
        'Dim nRow As Short
        'Dim nCol As Short
        'Dim aTamanhoColuna() As Short
        'Dim nTamanhoLinha As Short
        'Dim sLinha As String
        'Dim sTexto As String
        'Dim nBuf As Short
        'Dim nLinha As Short
        'Dim nPagina As Short

        'Dim aCabecalhoColunas(2) As String
        'Dim sArquivo As String
        'sArquivo = My.Application.Info.DirectoryPath & "\Printtext.txt"
        'nLinha = 9999
        'nBuf = FreeFile()
        'FileClose(nBuf)
        'FileOpen(nBuf, sArquivo, OpenMode.Output)

        'With FlexOpcoes
        '    ReDim aTamanhoColuna(.Cols - 1)
        '    .Redraw = False
        '    '=======================>Obtem o Maior tamanho de cada coluna
        '    For nRow = 0 To .Rows - 1
        '        For nCol = .FixedCols To .Cols - 1
        '            If Len(Trim(.get_TextMatrix(nRow, nCol))) > aTamanhoColuna(nCol) Then
        '                aTamanhoColuna(nCol) = Len(Trim(.get_TextMatrix(nRow, nCol)))
        '            End If
        '        Next nCol
        '    Next nRow
        '    '=======================>Formata Cabecalho das Colunas
        '    aCabecalhoColunas(0) = ""
        '    aCabecalhoColunas(1) = ""
        '    For nCol = .FixedCols To .Cols - 1
        '        If lstImpressaoColunas.GetItemChecked(nCol - .FixedCols) Then
        '            sTexto = Trim(.get_TextMatrix(.FixedRows - 1, nCol))
        '            sTexto = sTexto & Space(aTamanhoColuna(nCol) - Len(sTexto))
        '            aCabecalhoColunas(0) = aCabecalhoColunas(0) & sTexto & Space(1) & vbTab
        '            aCabecalhoColunas(1) = aCabecalhoColunas(1) & New String("-", aTamanhoColuna(nCol)) & Space(1) & vbTab
        '        End If
        '    Next nCol
        '    nTamanhoLinha = Len(aCabecalhoColunas(1))
        '    If nTamanhoLinha < Len(Trim(txtCabecalho.Text)) Then
        '        nTamanhoLinha = Len(Trim(txtCabecalho.Text))
        '    End If
        '    '=======================>Formata e Imprime Linhas
        '    For nRow = .FixedRows To .Rows - 1

        '        '======================================>Cabecalho
        '        If nLinha > Val(txtLinha.Text) Then
        '            If nPagina > 0 Then
        '                PrintLine(1, txtRodape.Text)
        '                PrintLine(1, Chr(12))
        '            End If
        '            nPagina = nPagina + 1
        '            nLinha = 0

        '            sLinha = ""

        '            If chkNumeroPagina.CheckState = 1 Then
        '                sLinha = "Pagina: " & nPagina
        '            End If

        '            If chkImprimirData.CheckState = 1 Then
        '                sLinha = "Emissão:" & VB6.Format(Today, "dd/mm/yyyy") & "-" & TimeOfDay & Space(4) & sLinha
        '            End If

        '            If Trim(txtCabecalho.Text) <> "" Then
        '                sLinha = Trim(txtCabecalho.Text) & Space(4) & sLinha
        '            End If
        '            PrintLine(1, sLinha)
        '            PrintLine(1, "")
        '            nLinha = nLinha + 2
        '            PrintLine(1, aCabecalhoColunas(0))
        '            PrintLine(1, aCabecalhoColunas(1))
        '            nLinha = nLinha + 2

        '        End If

        '        sLinha = ""

        '        For nCol = .FixedCols To .Cols - 1
        '            If lstImpressaoColunas.GetItemChecked(nCol - .FixedCols) Then
        '                sTexto = Trim(.get_TextMatrix(nRow, nCol))
        '                sTexto = sTexto & Space(aTamanhoColuna(nCol) - Len(sTexto))
        '                sLinha = sLinha & sTexto & Space(1) & vbTab
        '            End If
        '        Next nCol
        '        PrintLine(1, sLinha)
        '        nLinha = nLinha + 1
        '    Next nRow
        '    .Redraw = True
        'End With

        'If nLinha <> 9999 Then PrintLine(1, txtRodape.Text)
        CmdCancela_Click(cmdCancela.Item(0), New System.EventArgs())


        'FileClose(nBuf)
        'printDoc.DocumentName = sArquivo

        'With PageSetupDialog
        ' .Document = printDoc
        ' .PageSettings = printDoc.DefaultPageSettings
        ' End With

        PrintPreviewDialog.Document = printDoc
        PrintPreviewDialog.ShowDialog()
        'printDoc.DocumentName = "Imprimindoxxxxx"
        'printDoc.Print()
        'FileClose(nBuf)
        'Kill(sArquivo)
        Aviso("Fim da Impressao")

        'Dim sr As StreamReader = New StreamReader(sArquivo)
        'streamToPrint = New StreamReader(sArquivo)
        'printFont = New Font("Courier New", 8)
        'Dim pd As New Printing.PrintDocument
        'AddHandler printDoc.PrintPage, AddressOf Me.printDoc_PrintPage
        ''printDoc.Print()
        ''Kill(sArquivo)
        'PrintPreviewDialog.Document = printDoc
        'PrintPreviewDialog.ShowDialog()
        'PrintPreviewDialog.DISPOSE ()
        'pd = Nothing

        'sr = Nothing
        'streamToPrint.DISPOSE()
        'streamToPrint = Nothing


Saida:
        '  FileClose(nBuf)
        FlexOpcoes.Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub Classificar()
        On Error GoTo Erro
        Dim nLoop As Short
        Dim nColuna As Short

        Me.Size = New System.Drawing.Size(368, 238)
        Me.Location = New System.Drawing.Point(234, 238)
        Me.fraClassificacao.Location = New System.Drawing.Point(12, 1)
        Me.fraClassificacao.Size = New System.Drawing.Size(344, 196)

        fraClassificacao.Visible = True
        fraImpressao.Visible = False
        fraLocalizar.Visible = False
        fraExportar.Visible = False

        lstClassificacao.Items.Clear()
        With FlexOpcoes
            For nLoop = .FixedCols To .Cols - 1
                If Trim(.get_TextMatrix(.FixedRows - 1, nLoop)) <> "" And .get_ColWidth(nLoop) > 0 Then
                    lstClassificacao.Items.Add(.get_TextMatrix(.FixedRows - 1, nLoop))
                    If Trim(.get_TextMatrix(.FixedRows - 1, nLoop)) = Trim(.get_TextMatrix(.FixedRows - 1, Val(txtColunaAtual.Text))) Then
                        nColuna = lstClassificacao.Items.Count - 1
                    End If
                End If
            Next nLoop
        End With
        lstClassificacao.SelectedIndex = nColuna
        optAscendente.Checked = True
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume


    End Sub


    Private Sub Impressao()

        On Error GoTo Erro
        Dim nLoop As Short
        Dim nFont As Short


        fraClassificacao.Visible = False
        fraImpressao.Visible = True
        fraLocalizar.Visible = False
        fraExportar.Visible = False

        Me.fraImpressao.Location = New System.Drawing.Point(12, 1)
        Me.fraImpressao.Size = New System.Drawing.Size(430, 338)
        Me.Size = New System.Drawing.Size(464, 378)

        'lstImpressaoColunas.Top = VB6.TwipsToPixelsY(360)
        'lstImpressaoColunas.Left = VB6.TwipsToPixelsX(2475)
        'lstImpressaoColunas.Width = VB6.TwipsToPixelsX(3060)
        'lstImpressaoColunas.Height = VB6.TwipsToPixelsY(2350)

        fraImpressao.Visible = True

        lstImpressaoColunas.Items.Clear()


        With FlexOpcoes
            For nLoop = .FixedCols To .Cols - 1
                'If Trim(.get_TextMatrix(.FixedRows - 1, nLoop)) <> "" Then
                lstImpressaoColunas.Items.Add(.get_TextMatrix(.FixedRows - 1, nLoop))
                If .get_ColWidth(nLoop) > 0 Then
                    lstImpressaoColunas.SetItemChecked(lstImpressaoColunas.Items.Count - 1, True)
                End If
                'End If
            Next nLoop
        End With
        nFont = 0
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub Localizar()
        On Error GoTo Erro

        Me.Size = New System.Drawing.Point(412, 243)
        Me.fraLocalizar.Location = New System.Drawing.Point(12, 1)
        Me.fraLocalizar.Size = New System.Drawing.Size(384, 206)
        fraClassificacao.Visible = False
        fraImpressao.Visible = False
        fraLocalizar.Visible = True
        fraExportar.Visible = False

        Dim nLoop, nColuna As Short
        cboColuna.Items.Clear()
        With FlexOpcoes
            For nLoop = .FixedCols To .Cols - 1
                If Trim(.get_TextMatrix(.FixedRows - 1, nLoop)) <> "" Then
                    cboColuna.Items.Add(.get_TextMatrix(.FixedRows - 1, nLoop))
                    If Trim(.get_TextMatrix(.FixedRows - 1, nLoop)) = Trim(.get_TextMatrix(.FixedRows - 1, Val(txtColunaAtual.Text))) Then
                        nColuna = cboColuna.Items.Count - 1
                    End If
                End If
            Next nLoop
            cboColuna.SelectedIndex = nColuna
        End With
        cboTipoBusca.SelectedIndex = 1
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub txtLocalizar_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLocalizar.TextChanged
        cmdOkLocalizar.Enabled = Trim(txtLocalizar.Text) <> ""
    End Sub

    Private Sub txtNomeArquivo_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNomeArquivo.TextChanged
        cmdOkExportar.Enabled = Trim(txtNomeArquivo.Text) <> ""
    End Sub

    Private Sub txtNomeArquivo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNomeArquivo.Leave
        txtNomeArquivo.Text = Trim(txtNomeArquivo.Text)
        Dim nPosicao As Short
        If txtNomeArquivo.Text <> "" Then
            nPosicao = InStr(txtNomeArquivo.Text, ".")
            If nPosicao <> 0 Then
                txtNomeArquivo.Text = VB.Left(txtNomeArquivo.Text, nPosicao - 1)
            End If
            txtNomeArquivo.Text = txtNomeArquivo.Text & aExtensao(cboFormato.SelectedIndex)
        End If
    End Sub
    Private Sub fraLocalizar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraLocalizar.Enter
    End Sub

    Private Sub chkLocalizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLocalizar.CheckedChanged
        If chkLocalizar.Checked Then
            Call Localizar()
            Me.ShowDialog()
        End If
    End Sub

    Private Sub chkClassificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClassificar.CheckedChanged
        If chkClassificar.Checked Then
            Me.Classificar()
            Me.ShowDialog()
        End If
    End Sub

    Private Sub chkExportar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExportar.CheckedChanged
        If chkExportar.Checked Then
            On Error GoTo Erro
            ReDim aExtensao(2)
            aExtensao(0) = ".Txt"
            aExtensao(1) = ".Csv"
            fraClassificacao.Visible = False
            fraImpressao.Visible = False
            fraLocalizar.Visible = False
            fraExportar.Visible = True
            Me.fraExportar.Location = New System.Drawing.Point(12, 5)
            Me.fraExportar.Size = New System.Drawing.Size(334, 148)
            Me.Size = New System.Drawing.Size(363, 189)
            cboFormato.SelectedIndex = 0
            Me.ShowDialog()
        End If

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub

    Private Sub chkImprimir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImprimir.CheckedChanged
        If chkImprimir.Checked Then
            Me.Impressao()
            Me.ShowDialog()
        End If
    End Sub

    Private Sub printDoc_PrintPage(ByVal sender As Object, ByVal ev As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        On Error GoTo Erro
        Dim nRow As Short
        Dim nCol As Short
        Dim aTamanhoColuna() As Short
        Dim nTamanhoLinha As Short
        Dim sLinha As String
        Dim sTexto As String
        Dim nBuf As Short
        Dim nLinha As Short
        Dim LinesPerPage As Single

        printFont = New Font("Courier New", 10)
        LinesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        'LinesPerPage = 50

        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim line As String = Nothing

        Dim yPos As Single = 0
        Dim count As Integer = 0

        Dim aCabecalhoColunas(2) As String
        Dim sArquivo As String
        nLinha = 1

        With FlexOpcoes
            ReDim aTamanhoColuna(.Cols - 1)
            .Redraw = False
            '=======================>Obtem o Maior tamanho de cada coluna
            For nRow = 0 To .Rows - 1
                For nCol = .FixedCols To .Cols - 1
                    If Len(Trim(.get_TextMatrix(nRow, nCol))) > aTamanhoColuna(nCol) Then
                        aTamanhoColuna(nCol) = Len(Trim(.get_TextMatrix(nRow, nCol)))
                    End If
                Next nCol
            Next nRow
            '=======================>Formata Cabecalho das Colunas
            aCabecalhoColunas(0) = ""
            aCabecalhoColunas(1) = ""

            For nCol = .FixedCols To .Cols - 1

                If lstImpressaoColunas.GetItemChecked(nCol - .FixedCols) Then
                    sTexto = Trim(.get_TextMatrix(.FixedRows - 1, nCol))
                    sTexto = sTexto & Space(aTamanhoColuna(nCol) - Len(sTexto))
                    aCabecalhoColunas(0) = aCabecalhoColunas(0) & sTexto & Space(1) & vbTab
                    aCabecalhoColunas(1) = aCabecalhoColunas(1) & New String("-", aTamanhoColuna(nCol)) & Space(1) & vbTab
                End If


            Next nCol

            nTamanhoLinha = Len(aCabecalhoColunas(1))
            '=======================>Imprime Cabecalho
            nPagina = nPagina + 1
            sLinha = Me.Text & Space(10)

            If chkImprimirData.CheckState = 1 Then
                sLinha = sLinha & "Emissão:" & VB6.Format(Today, "dd/mm/yyyy") & "-" & TimeOfDay & Space(10)
            End If

            If chkNumeroPagina.CheckState = 1 Then
                sLinha = sLinha & "Pagina: " & nPagina
            End If
 

            yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(sLinha, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
            count = count + 2


            yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(aCabecalhoColunas(0), printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
            nLinha = nLinha + 1
            count = count + 1
            yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(aCabecalhoColunas(1), printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
            nLinha = nLinha + 1
            count = count + 1


            '=======================>Formata e Imprime Detalhe
            For nRow = nLinhaAtual To .Rows - 1
                '======================================>Cabecalho
                'If nLinha > Val(txtLinha.Text) Then
                If nLinha > LinesPerPage Then
                    ev.HasMorePages = True
                    Exit For
                End If
                sLinha = ""
                For nCol = .FixedCols To .Cols - 1
                    If lstImpressaoColunas.GetItemChecked(nCol - .FixedCols) Then
                        sTexto = Trim(.get_TextMatrix(nRow, nCol))
                        sTexto = sTexto & Space(aTamanhoColuna(nCol) - Len(sTexto))
                        sLinha = sLinha & sTexto & Space(1) & vbTab
                    End If
                Next nCol
                If sLinha.Trim <> "" Then
                    yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
                    ev.Graphics.DrawString(sLinha, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
                    count = count + 1
                    nLinha = nLinha + 1
                    nLinhaAtual = nRow + 1
                End If
            Next nRow
            .Redraw = True
        End With

        'Dim linesPerPage As Single = 0
        'Dim yPos As Single = 0
        'Dim count As Integer = 0
        'Dim leftMargin As Single = ev.MarginBounds.Left
        'Dim topMargin As Single = ev.MarginBounds.Top
        'Dim line As String = Nothing
        'leftMargin = 1
        'topMargin = 1

        'line = streamToPrint.ReadToEnd()
        'linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)
        'ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())


        '' Print each line of the file.
        ''While count < linesPerPage
        '' line = streamToPrint.ReadLine()
        '' If line Is Nothing Then
        '' Exit While
        '' End If

        ''yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
        ''ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
        ''count += 1
        ''End While

        '' If more lines exist, print another page.
        ''If Not (line Is Nothing) Then
        ''ev.HasMorePages = True
        ''Else
        ''ev.HasMorePages = False
        ''End If

Saida:
        FlexOpcoes.Redraw = True
        Exit Sub

Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

End Class