Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmControleFita_Afiliada
	Inherits System.Windows.Forms.Form
    Dim MouseX As Single
	Dim MouseY As Single
    Dim sProduto As String
    Dim dtsControleFita As New MSAClass.AsmxControleFita.dtsControleFita
    Dim asmxControleFita As MSAClass.AsmxControleFita.asmxControleFita
	
    Private Sub CarregaGrid()

        On Error GoTo Erro

        Dim dtDataInicio As DateTime = DateTime.Parse("01/01/1900")
        Dim dtDataFim As DateTime = DateTime.Parse("01/01/2100")
        Dim btIndicaNumerada As Byte = 0
        Dim btIndicaPendente As Byte = 0
        Dim btIndicaAtiva As Byte = 0
        Dim btIndicaDesativada As Byte = 0
        Dim btIndicaAvulso As Byte = 0
        Dim btIndicaArtistico As Byte = 0
        Dim btIndicaRelatorio As Byte = 0


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If ucDataInicio.Ano <> 0 Then dtDataInicio = ucDataInicio.DateTime
        If ucDataFim.Ano <> 0 Then dtDataFim = ucDataFim.DateTime
        If chkFiltroMidia.Checked Then btIndicaNumerada = 1
        If chkFiltroPendentes.Checked Then btIndicaPendente = 1
        If chkAtivas.Checked Then btIndicaAtiva = 1
        If chkFiltroDesativadas.Checked Then btIndicaDesativada = 1
        If chkFiltroAvulsas.Checked Then btIndicaAvulso = 1
        If chkFiltroArtisticas.Checked Then btIndicaArtistico = 1
        If chkRelatorio.Checked Then btIndicaRelatorio = 1
        Mensagem("Selecionado Fitas....Aguarde ")
        Dim nCor As System.Drawing.Color
        Call ConfiguraGridFita()
        dtsControleFita.Clear()
        dtsControleFita = asmxControleFita.spuControleFitaConsulta(ucVeiculo.Text, _
                                ucPrograma.Text, _
                                dtDataInicio, _
                                dtDataFim, _
                                txtFiltroNumeroFitaInicio.Text, _
                                txtFiltroNumeroFitaFim.Text, _
                                ucEmpresa.Text, _
                                Val(txtFiltroContrato.Text), _
                                Val(txtFiltroSequencia.Text), _
                                txtFiltroLegenda.Text, _
                                ucTipoComercial.Text, _
                                ucAgencia.Text, _
                                ucCliente.Text, _
                                btIndicaNumerada, _
                                btIndicaPendente, _
                                btIndicaAtiva, _
                                btIndicaDesativada, _
                                btIndicaAvulso, _
                                btIndicaArtistico, _
                                btIndicaRelatorio, _
                                gsUsuario, _
                                txtProduto.Text)


        With flxFita
            .Redraw = False

            nLin = 0
            For Each drw As MSAClass.AsmxControleFita.dtsControleFita.dtbConsultaFitaRow In dtsControleFita.dtbConsultaFita.Rows
                Mensagem(Str(nLin))
                nLin = nLin + 1
                If nLin >= .Rows Then
                    .Rows = .Rows + 1
                    .Row = nLin
                    .Col = 0
                    .CellFontName = "WingDings"
                    .CellFontSize = 14
                End If

                If Not drw.IsCod_Tipo_ComercialNull Then .set_TextMatrix(nLin, 1, drw.Cod_Tipo_Comercial)

                If Not drw.IsIndica_Titulo_DeterminarNull Then
                    If drw.Indica_Titulo_Determinar = 1 Then
                        If Not drw.IsTitulo_ComercialNull Then .set_TextMatrix(nLin, 2, "*** " & FirstCaps(drw.Titulo_Comercial))
                    Else
                        If Not drw.IsTitulo_ComercialNull Then .set_TextMatrix(nLin, 2, FirstCaps(drw.Titulo_Comercial))
                    End If
                Else
                    If Not drw.IsTitulo_ComercialNull Then .set_TextMatrix(nLin, 2, FirstCaps(drw.Titulo_Comercial))
                End If


                If Not drw.IsNome_ProdutoNull Then .set_TextMatrix(nLin, 3, FirstCaps(drw.Nome_Produto))
                If Not drw.IsDuracaoNull Then .set_TextMatrix(nLin, 4, drw.Duracao.ToString("##"))
                If Not drw.IsCod_AgenciaNull Then .set_TextMatrix(nLin, 5, drw.Cod_Agencia)
                If Not drw.IsCod_ClienteNull Then .set_TextMatrix(nLin, 6, drw.Cod_Cliente)

                If Trim(drw.Origem) = "Midia" Then
                    .set_TextMatrix(nLin, 8, drw.Cod_Empresa & "-" & drw.Numero_MR & "-" & drw.Sequencia_MR & "-" & Trim(drw.Cod_Comercial))
                    If Not drw.IsCod_VeiculoNull Then .set_TextMatrix(nLin, 8, .get_TextMatrix(nLin, 8) & "-" & drw.Cod_Veiculo)
                Else
                    If Not drw.IsCod_VeiculoNull Then .set_TextMatrix(nLin, 8, Trim(drw.Origem) & " - Veic:" & drw.Cod_Veiculo)
                End If
                If Not drw.IsNumero_FitaNull Then .set_TextMatrix(nLin, 9, drw.Numero_Fita)
                If Not drw.IsCod_EmpresaNull Then .set_TextMatrix(nLin, 10, drw.Cod_Empresa)
                If Not drw.IsNumero_MRNull Then .set_TextMatrix(nLin, 11, drw.Numero_MR)
                If Not drw.IsSequencia_MRNull Then .set_TextMatrix(nLin, 12, drw.Sequencia_MR)
                If Not drw.IsCod_ComercialNull Then .set_TextMatrix(nLin, 13, drw.Cod_Comercial)
                If Not drw.IsCod_VeiculoNull Then .set_TextMatrix(nLin, 14, drw.Cod_Veiculo)
                If Not drw.IsOrigemNull Then .set_TextMatrix(nLin, 15, drw.Origem)
                If Not drw.IsId_ChaveNull Then .set_TextMatrix(nLin, 16, drw.Id_Chave)
                If Not drw.IsData_InicioNull Then .set_TextMatrix(nLin, 17, VB6.Format(drw.Data_Inicio, "dd/mm/yyyy"))
                If Not drw.IsData_FinalNull Then .set_TextMatrix(nLin, 18, VB6.Format(drw.Data_Final, "dd/mm/yyyy"))

                .Row = nLin
                .Col = 7
                If drw.IsNumero_FitaNull Then
                    .set_TextMatrix(nLin, 7, "Pendente")
                ElseIf Not drw.IsData_DesativacaoNull Then
                    If drw.Origem.Trim = "Midia" Then
                        .CellFontName = "WingDings"
                        .CellForeColor = Color.Red
                        .CellFontSize = 14
                        .set_TextMatrix(nLin, 7, Chr(251))
                        .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                    Else
                        .CellFontName = "WingDings"
                        .CellForeColor = Color.Red
                        .CellFontSize = 14
                        .set_TextMatrix(nLin, 7, Chr(251))
                        .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                    End If
                Else
                    .CellFontName = "WingDings"
                    .CellForeColor = Color.Blue
                    .CellFontSize = 14
                    .set_TextMatrix(nLin, 7, Chr(252))
                    .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
                End If

                .Row = nLin


                Select Case UCase(Trim(drw.Origem))
                    Case "MIDIA"

                        nCor = Color.Blue
                    Case "AVULSO"
                        nCor = Color.Red
                    Case "ARTISTICO"
                        nCor = Color.Green
                End Select
                .Col = 8
                .CellForeColor = nCor
            Next
            Mensagem("")
            .Row = 1
            .Col = 1
            .ColSel = .Cols - 1
            .Redraw = True
            flxFita_LeaveCell(flxFita, New System.EventArgs())
            flxFita_EnterCell(flxFita, New System.EventArgs())
            flxFita_RowColChange(flxFita, New System.EventArgs())
            .TopRow = 1
        End With
        txtTotalFitas.Text = CStr(nLin)
        Call cmdFiltroFechar_Click(cmdFiltroFechar.Item(0), New System.EventArgs())
        dtsControleFita.dtbConsultaFita.Clear()

Saida:
        flxFita.Redraw = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub


    Private Sub ConfiguraGridFita()

        With flxFita
            .Redraw = False
            .Clear()
            .Rows = 26
            .FixedRows = 1
            .FixedCols = 1
            .RowHeightMin = 300
            '.Size = New System.Drawing.Point(749, 381)
            .AllowBigSelection = False
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarBoth
            .ScrollTrack = True
            .set_RowHeight(0, 280)
            '.FormatString = "|Cartucho|Titulo do Comercial|Duracao|Tipo Com.|Matriz|Posicao|Dt Gravação|Origem|Empresa|Contrato|Sequencia|Legenda"
            .FormatString = "|Tipo|Titulo do Comercial|Produto|Dur.|Agencia|Cliente|^Status|Emp-Mr-Seq.Com-Veic|N. Fita|Empresa|Contrato|Sequencia|Legenda|Veiculo|Origem|Id Chave|Inicio Prog.|Térm. Prog."

            .set_ColWidth(0, 330)
            .set_ColWidth(1, 500)
            .set_ColWidth(2, 2125)
            .set_ColWidth(3, 2220)
            .set_ColWidth(4, 405)
            .set_ColWidth(5, 855)
            .set_ColWidth(6, 855)
            .set_ColWidth(7, 945)
            .set_ColWidth(8, 1815)
            .set_ColWidth(9, 845)
            .set_ColWidth(10, 0)
            .set_ColWidth(11, 0)
            .set_ColWidth(12, 0)
            .set_ColWidth(13, 0)
            .set_ColWidth(14, 0)
            .set_ColWidth(15, 0)
            .set_ColWidth(16, 0)
            .set_ColWidth(17, 1290)
            .set_ColWidth(18, 1290)
            For nCont = 0 To .Rows - 1
                .Row = nCont
                .Col = 0
                .CellFontName = "WingDings"
                .CellFontSize = 14
                .CellForeColor = System.Drawing.Color.Blue
            Next nCont

            For nCont = 0 To .Cols - 1
                .set_ColAlignment(nCont, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
            Next nCont
            .set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)
            .set_ColAlignment(6, MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter)

            .Redraw = True
            .Row = 1
            .Col = 1
            .ColSel = .Cols - 1
            flxFita_LeaveCell(flxFita, New System.EventArgs())
            flxFita_EnterCell(flxFita, New System.EventArgs())
            flxFita_RowColChange(flxFita, New System.EventArgs())

        End With

        'lblTotal.Top = 6720
        'lblTotal.Left = 8490
        'txtTotalFitas.Top = 6660
        'txtTotalFitas.Left = 10530
        txtTotalFitas.ReadOnly = True
        ' txtTotalFitas.TabStop = False
        txtTotalFitas.Text = ""
Saida:

        flxFita.Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub cmdFiltroExecutar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFiltroExecutar.Click

        Dim bInformarPeriodo As Boolean
        bInformarPeriodo = False

        If chkFiltroPendentes.CheckState = 1 Then
            bInformarPeriodo = True
        End If

        If ucPrograma.Text.Trim <> "" Then
            bInformarPeriodo = True
        End If

        If bInformarPeriodo Then
            If ucDataInicio.Ano = 1 Or ucDataFim.Ano = 1 Then
                Aviso("É Necessario Informar um Periodo")
                Exit Sub
            End If
        End If

        sProduto = ""
        If txtProduto.Text.Trim <> "" Then
            Select Case cboOpcoes.SelectedIndex
                Case 0 '  Qualquer parte do Campo
                    sProduto = "%" & Trim(txtProduto.Text) & "%"
                Case 1 '  Inicio do Campo
                    sProduto = Trim(txtProduto.Text) & "%"
                Case 2 '  Fim do Campo
                    sProduto = "%" & Trim(txtProduto.Text)
            End Select
        End If


        If chkTela.Checked Then
            Call CarregaGrid()
        End If

        If chkRelatorio.Checked Then
            'Call Relatorio()
        End If

    End Sub

    Private Sub cmdFiltroFechar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFiltroFechar.Click
        Dim Index As Short = cmdFiltroFechar.GetIndex(eventSender)
        picFiltro.Visible = False
        picFiltro.BringToFront()
        flxFita.Enabled = True
        tbOpcoes.Enabled = True
    End Sub

    Private Sub cmdFiltroLimpar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFiltroLimpar.Click

        ucVeiculo.Text = ""
        ucPrograma.Text = ""
        ucDataInicio.Text = ""
        ucDataFim.Text = ""

        chkFiltroPendentes.Checked = False
        chkAtivas.Checked = False
        chkFiltroMidia.Checked = False
        chkFiltroAvulsas.Checked = False
        chkFiltroArtisticas.Checked = False
        chkFiltroDesativadas.Checked = False
        ucEmpresa.Text = ""
        txtFiltroContrato.Text = ""
        txtFiltroSequencia.Text = ""
        txtFiltroLegenda.Text = ""
        ucTipoComercial.Text = ""
        ucAgencia.Text = ""
        ucCliente.Text = ""
        txtProduto.Text = ""
        txtFiltroNumeroFitaFim.Text = ""
        txtFiltroNumeroFitaInicio.Text = ""
        cboOpcoes.SelectedIndex = 0

    End Sub

    Private Sub cmdMarcarTodos_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMarcarTodos.Click

        On Error GoTo Erro
        Dim nCont As Integer
        With flxFita
            .Visible = False
            For nCont = 1 To .Rows - 1
                .Row = nCont
                .Col = 0
                If .get_TextMatrix(nCont, 9) <> "" Then
                    .set_TextMatrix(nCont, 0, Chr(252))
                    .CellForeColor = Color.Blue
                End If
            Next nCont
        End With

Saida:
        flxFita.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub flxFita_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxFita.ClickEvent
        Dim nCol, nRow As Short
        With flxFita
            nCol = .MouseCol
            nRow = .MouseRow
            If nCol = 0 Then
                If .get_TextMatrix(.Row, nCol) = "" And Trim(.get_TextMatrix(nRow, 9)) <> "" Then
                    .set_TextMatrix(.Row, nCol, Chr(252))
                Else
                    .set_TextMatrix(.Row, nCol, "")
                End If

            End If
        End With
    End Sub

    Private Sub flxFita_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxFita.DblClick
        On Error GoTo Erro
        Dim nCol As Short
        nCol = flxFita.MouseCol
        With flxFita
            If Trim(.get_TextMatrix(.Row, 2)) = "" Then
                GoTo Saida
            End If

            If nCol = 9 Then
                If UCase(Trim(.get_TextMatrix(.Row, 15))) = "MIDIA" Then
                    tbNumerar_Click(flxFita, New System.EventArgs())
                Else
                    tbAlterar_Click(flxFita, New System.EventArgs())
                End If
            Else
                tbDados_Click(flxFita, New System.EventArgs())
            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub flxFita_EnterCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxFita.EnterCell
    End Sub

    Private Sub flxFita_LeaveCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxFita.LeaveCell
    End Sub


    Private Sub flxFita_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxFita.MouseDownEvent
        On Error GoTo Erro
        With flxFita
            If eventArgs.button = 2 And .MouseRow = 0 Then
                FlexOpcoes = flxFita
                .Col = .MouseCol
                frmOpcoesGrid.Text = Me.Text
                frmOpcoesGrid.txtColunaAtual.Text = .MouseCol.ToString
                mdiPrincipal.mnuOpcoesGrid.Show(Windows.Forms.Cursor.Position)

            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume


    End Sub

    Private Sub flxFita_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxFita.RowColChange

        With flxFita
            If .Visible And .Redraw Then
                tbAlterar.Enabled = Trim(.get_TextMatrix(.Row, 9)) <> ""
                tbNumerar.Enabled = Trim(.get_TextMatrix(.Row, 15)) = "Midia"
                tbDados.Enabled = .get_TextMatrix(.Row, 2) <> ""
            End If
        End With

    End Sub

    Private Sub flxFita_SelChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxFita.SelChange
        With flxFita
            txtLinha1.Text = CStr(.Row)
            txtLinha2.Text = CStr(.RowSel)
        End With
    End Sub

    'UPGRADE_WARNING: Form event frmControleFita_Afiliada.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmControleFita_Afiliada_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        flxFita_LeaveCell(flxFita, New System.EventArgs())
        flxFita_EnterCell(flxFita, New System.EventArgs())
        flxFita_RowColChange(flxFita, New System.EventArgs())
    End Sub

    Private Sub frmControleFita_Afiliada_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{tab}")
        Else
            KeyAscii = Asc(UCase(Chr(KeyAscii)))
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub frmControleFita_Afiliada_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub frmControleFita_Afiliada_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        On Error GoTo Erro
        Me.Top = 0
        Me.Left = 0
        SetaUserControl(Me)
        Me.asmxControleFita = NewControleFita()
        '================================> Configura Picture de Filtro
        With picFiltro
            .Top = 70
            .Left = 70
            .Width = 800
            .Height = 400
            .Visible = False
        End With
        '================================> Configura Grids
        ConfiguraGridFita()
        cboOpcoes.SelectedIndex = 0
        Me.Top = 0
        Me.Left = 0

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume saida
        Resume

    End Sub

    Private Sub lblFiltro_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblFiltro.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = X
        MouseY = Y
    End Sub

    Private Sub lblFiltro_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblFiltro.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        With picFiltro
            If Button = 1 Then
                VariacaoY = Y - MouseY
                VariacaoX = X - MouseX
                If VB6.PixelsToTwipsY(.Top) + VariacaoY > 0 And VB6.PixelsToTwipsY(.Top) + VariacaoY < 6915 Then
                    .Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + VariacaoY)
                End If
                If VB6.PixelsToTwipsX(.Left) + VariacaoX > 0 And VB6.PixelsToTwipsX(.Left) + VariacaoX < 3480 Then
                    .Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + VariacaoX)
                End If
            End If
        End With

    End Sub



    Private Sub ExcluirFita()
        On Error GoTo Erro

        Dim sTipo As String = ""
        Dim sFita As String = ""
        Dim sTabela As String = ""
        Dim sSql As String = ""

        Dim nRow As Short

        Dim sFita_Empresa As String = ""
        Dim sFita_MR As Integer
        Dim sFita_Sequencia_MR As Short
        Dim sFita_Cod_Comercial As String = ""
        Dim sFita_Veiculo As String = ""
        Dim sFita_IdChave As Integer

        Dim bSelecao As Boolean
        Dim sMensagem As String = ""

        '==================================>Verifica se tem alguma fita selecionada
        bSelecao = False
        With flxFita
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, 0) = Chr(252) And Trim(.get_TextMatrix(nRow, 9)) <> "" Then
                    bSelecao = True
                    Exit For
                End If
            Next nRow
        End With

        If Not bSelecao Then
            sMensagem = "Nenhuma Fita foi Selecionada." & vbCrLf
            sMensagem = sMensagem & "Para Marcar ou Desmarcar um Fita para Exclusão, Clique na Primeira coluna da Linha Correspondente"
            MsgBox(sMensagem, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Atenção")
            GoTo Saida
        Else
            sMensagem = "Confirma a Exclusão da(s) Fita(s) Selecionada(s)"
            If MsgBox(sMensagem, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção") = MsgBoxResult.No Then
                GoTo Saida
            End If
        End If

        DtsControleFita.dtbFitaTemp_Exclusao.Clear()
        With flxFita
            .Redraw = False
            For nRow = 1 To .Rows - 1
                sFita = Trim(.get_TextMatrix(nRow, 9))
                sFita_IdChave = Val(Trim(.get_TextMatrix(nRow, 16)))
                sFita_Veiculo = Trim(.get_TextMatrix(nRow, 14))
                sTipo = Trim(.get_TextMatrix(nRow, 15))
                sFita_Empresa = Trim(.get_TextMatrix(nRow, 10))
                sFita_MR = Val(Trim(.get_TextMatrix(nRow, 11)))
                sFita_Sequencia_MR = Val(Trim(.get_TextMatrix(nRow, 12)))
                sFita_Cod_Comercial = Trim(.get_TextMatrix(nRow, 13))
                If .get_TextMatrix(nRow, 0) = Chr(252) And sFita <> "" Then
                    DtsControleFita.dtbFitaTemp_Exclusao.AdddtbFitaTemp_ExclusaoRow(sTipo, sFita, sFita_Empresa, sFita_MR, sFita_Cod_Comercial, sFita_Sequencia_MR, sFita_Veiculo, sFita_IdChave, nRow, "", gsUsuario)
                End If
            Next nRow

            DtsControleFita = AsmxControleFita.spuAtualizar(DtsControleFita)

            '==================================>Mostra as criticas - Remove a Linha do Grid ou apaga colunas
            sMensagem = ""
            For Each drw As MSAClass.AsmxControleFita.dtsControleFita.dtbFitaTemp_ExclusaoRow In dtsControleFita.dtbFitaTemp_Exclusao.Select("", "grid_row desc")
                If drw.IsCriticaNull Then
                    If drw.Origem.ToString.ToUpper = "MIDIA" Then
                        .set_TextMatrix(drw.Grid_Row, 0, "")
                        .set_TextMatrix(drw.Grid_Row, 9, "")
                        .set_TextMatrix(drw.Grid_Row, 14, "")

                        .Row = drw.Grid_Row
                        .Col = 7
                        .CellFontName = .Font.Name
                        .CellForeColor = System.Drawing.Color.Black
                        .CellFontSize = 9
                        .set_TextMatrix(drw.Grid_Row, 7, "Pendente")
                        .set_TextMatrix(drw.Grid_Row, 8, .get_TextMatrix(drw.Grid_Row, 10) & "-" & .get_TextMatrix(drw.Grid_Row, 11) & "-" & .get_TextMatrix(drw.Grid_Row, 12) & "-" & .get_TextMatrix(drw.Grid_Row, 13))
                    Else
                        .RemoveItem(drw.Grid_Row)
                        .Rows = .Rows + 1
                        .Row = .Rows - 1
                        .Col = 0
                        .CellFontName = "WingDings"
                        .CellFontSize = 14
                        .CellForeColor = System.Drawing.Color.Blue
                        .Visible = True
                    End If
                Else
                    sMensagem = sMensagem & drw.Critica & vbCrLf
                End If
            Next
            .Redraw = True
        End With
        If sMensagem <> "" Then
            Aviso(sMensagem)
        End If
        DtsControleFita.dtbFitaTemp_Exclusao.Clear()

        flxFita_RowColChange(flxFita, New System.EventArgs())
Saida:
        flxFita.Redraw = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Private Sub DesativarFita()
        On Error GoTo Erro

        Dim sTipo As String = ""
        Dim sFita As String = ""
        Dim sTabela As String = ""
        Dim sLog As String = ""

        Dim nRow As Short
        Dim sStatus As String = ""
        Dim sFita_Empresa As String = ""
        Dim sFita_MR As Integer
        Dim sFita_Sequencia_MR As Short
        Dim sFita_Cod_Comercial As String = ""
        Dim sFita_Veiculo As String = ""
        Dim sFita_IdChave As Integer
        Dim bSelecao As Boolean
        Dim sMensagem As String = ""

        Dim bAtiva As Boolean
        Dim bInativa As Boolean
        Dim bAtualizar As Boolean


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        '==================================>Verifica se tem alguma fita selecionada
        bSelecao = False
        With flxFita
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, 0) = Chr(252) And Trim(.get_TextMatrix(nRow, 9)) <> "" Then
                    bSelecao = True
                    If .get_TextMatrix(nRow, 7) = Chr(252) Then bAtiva = True
                    If .get_TextMatrix(nRow, 7) = Chr(251) Then bInativa = True
                End If
            Next nRow
        End With

        If Not bSelecao Then
            sMensagem = "Nenhuma Fita foi Selecionada." & vbCrLf
            sMensagem = sMensagem & "Para Marcar ou Desmarcar um Fita para Desativação, Clique na Primeira coluna da Linha Correspondente"
            MsgBox(sMensagem, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            GoTo Saida
        End If

        If bAtiva And bInativa Then
            MsgBox("As Fitas Selecionadas devem ter um único Status ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atenção")
            GoTo Saida
        End If

        If bAtiva Then
            sMensagem = "Confirma a Desativação da(s) Fita(s) Selecionada(s)"
        Else
            sMensagem = "Confirma a Reativação da(s) Fita(s) Selecionada(s)"
        End If

        If MsgBox(sMensagem, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção") = MsgBoxResult.No Then
            GoTo Saida
        End If


        With flxFita
            .Redraw = False

            For nRow = 1 To .Rows - 1

                sFita = Trim(.get_TextMatrix(nRow, 9))
                sFita_IdChave = Val(Trim(.get_TextMatrix(nRow, 16)))
                sFita_Veiculo = Trim(.get_TextMatrix(nRow, 14))
                sTipo = Trim(.get_TextMatrix(nRow, 15))
                sFita_Empresa = Trim(.get_TextMatrix(nRow, 10))
                sFita_MR = Val(Trim(.get_TextMatrix(nRow, 11)))
                sFita_Sequencia_MR = Val(Trim(.get_TextMatrix(nRow, 12)))
                sFita_Cod_Comercial = Trim(.get_TextMatrix(nRow, 13))

                bAtualizar = True
                If .get_TextMatrix(nRow, 0) = Chr(252) And sFita <> "" Then
                    DtsControleFita.dtbFitaTemp_Desativacao.AdddtbFitaTemp_DesativacaoRow(sTipo, sFita, sFita_Empresa, sFita_MR, sFita_Cod_Comercial, sFita_Sequencia_MR, sFita_Veiculo, sFita_IdChave, nRow, 2, gsUsuario)
                End If
            Next nRow
            DtsControleFita = AsmxControleFita.spuDesativar(DtsControleFita)

            For Each drw As MSAClass.AsmxControleFita.dtsControleFita.dtbFitaTemp_DesativacaoRow In dtsControleFita.dtbFitaTemp_Desativacao.Rows

                If drw.Operacao <> 9 Then '--- 0 = Desativacao 1 = Reativacao 2- Não fez nada
                    .Row = drw.Grid_Row
                    .Col = 7
                    .CellFontName = "WingDings"
                    .CellFontSize = 14
                    If drw.Operacao = 0 Then
                        .CellForeColor = Color.Red
                        .set_TextMatrix(.Row, 7, Chr(251))
                    Else
                        .CellForeColor = Color.Blue
                        .set_TextMatrix(.Row, 7, Chr(252))
                    End If
                    .set_TextMatrix(.Row, 0, "")
                End If
            Next

        End With
        flxFita_RowColChange(flxFita, New System.EventArgs())
Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        flxFita.Redraw = True

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    'Private Sub tbOpções_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
    '    Select Case Trim(UCase(Button.Name))
    '        Case "SELECIONAR"

    '        Case "ALTERAR"

    '            Select Case Trim(UCase(flxFita.get_TextMatrix(flxFita.Row, 15)))
    '                Case "MIDIA"
    '                    UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
    '                    Load(frmControleFita_Afiliada_Alteracao)
    '                    frmControleFita_Afiliada_Alteracao.txtNumeroFita.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 9))
    '                    frmControleFita_Afiliada_Alteracao.txtEmpresa.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 10))
    '                    frmControleFita_Afiliada_Alteracao.txtContrato.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 11))
    '                    frmControleFita_Afiliada_Alteracao.txtSequencia.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 12))
    '                    frmControleFita_Afiliada_Alteracao.txtcomercial.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 13))
    '                    frmControleFita_Afiliada_Alteracao.txtveiculo.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 14))
    '                    frmControleFita_Afiliada_Alteracao.chkAlteracaoMidia.CheckState = System.Windows.Forms.CheckState.Checked
    '                    frmControleFita_Afiliada_Alteracao.Show()
    '                Case "ARTISTICO"
    '                    UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
    '                    Load(frmControle_Fita_Afiliada_Inclusao)
    '                    frmControle_Fita_Afiliada_Inclusao.txtNumero_Fita.Text = VB.Right(Trim(flxFita.get_TextMatrix(flxFita.Row, 9)), 4)
    '                    frmControle_Fita_Afiliada_Inclusao.txtId_chave.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 16))
    '                    frmControle_Fita_Afiliada_Inclusao.chkArtistico.CheckState = System.Windows.Forms.CheckState.Checked
    '                    frmControle_Fita_Afiliada_Inclusao.chkAlteracao.CheckState = System.Windows.Forms.CheckState.Checked
    '                    frmControle_Fita_Afiliada_Inclusao.txtNumero_Fita.Enabled = False
    '                    Me.Text = "Alteração de Fita Artística"
    '                    frmControle_Fita_Afiliada_Inclusao.ShowDialog()

    '                Case "AVULSO"
    '                    UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
    '                    Load(frmControle_Fita_Afiliada_Inclusao)
    '                    frmControle_Fita_Afiliada_Inclusao.txtNumero_Fita.Text = VB.Right(Trim(flxFita.get_TextMatrix(flxFita.Row, 9)), 4)
    '                    frmControle_Fita_Afiliada_Inclusao.txtId_chave.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 16))
    '                    frmControle_Fita_Afiliada_Inclusao.chkAvulso.CheckState = System.Windows.Forms.CheckState.Checked
    '                    frmControle_Fita_Afiliada_Inclusao.chkAlteracao.CheckState = System.Windows.Forms.CheckState.Checked
    '                    frmControle_Fita_Afiliada_Inclusao.txtNumero_Fita.Enabled = False
    '                    Me.Text = "Alteração de Fita Avulsa"
    '                    frmControle_Fita_Afiliada_Inclusao.ShowDialog()
    '            End Select

    '        Case "EXCLUIR"
    '            Call ExcluirFita()
    '        Case "DESATIVAR"
    '            Call DesativarFita()

    '        Case "NUMERAR"
    '            UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
    '            Load(frmControleFita_Afiliada_Determinacao)
    '            frmControleFita_Afiliada_Determinacao.txtEmpresa(0).Text = flxFita.get_TextMatrix(flxFita.Row, 10)
    '            frmControleFita_Afiliada_Determinacao.txtContrato(0).Text = flxFita.get_TextMatrix(flxFita.Row, 11)
    '            frmControleFita_Afiliada_Determinacao.txtSequencia(0).Text = flxFita.get_TextMatrix(flxFita.Row, 12)
    '            frmControleFita_Afiliada_Determinacao.txtComercial(0).Text = flxFita.get_TextMatrix(flxFita.Row, 13)
    '            Me.Hide()
    '            frmControleFita_Afiliada_Determinacao.Show()
    '            flxFita.Col = 1
    '            flxFita.ColSel = flxFita.Cols - 1
    '            flxFita_RowColChange(flxFita, New System.EventArgs())

    '        Case "DADOS"
    '            With flxFita
    '                UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
    '                Load(frmControleFita_Afiliada_Dados)
    '                Select Case UCase(Trim(.get_TextMatrix(.Row, 15)))
    '                    Case "MIDIA"
    '                        frmControleFita_Afiliada_Dados.chkMidia.CheckState = System.Windows.Forms.CheckState.Checked
    '                    Case "AVULSO"
    '                        frmControleFita_Afiliada_Dados.chkAvulso.CheckState = System.Windows.Forms.CheckState.Checked
    '                    Case "ARTISTICO"
    '                        frmControleFita_Afiliada_Dados.chkArtistico.CheckState = System.Windows.Forms.CheckState.Checked
    '                End Select
    '                frmControleFita_Afiliada_Dados.ShowDialog()
    '            End With

    '        Case "RELATORIO"
    '            picFiltro.Visible = True
    '            picFiltro.BringToFront()
    '            fraRelatorio.Visible = True
    '            fraClassificacao.Visible = True
    '            chkTela.CheckState = System.Windows.Forms.CheckState.Unchecked
    '            chkRelatorio.CheckState = System.Windows.Forms.CheckState.Checked
    '            flxFita.Enabled = False
    '            tbOpcoes.Enabled = False
    '            lblFiltro.Text = "Opções de Filtro (Relatório)"

    '        Case "SAIR"
    '            Me.Close()
    '    End Select
    'End Sub


	Private Sub txtFiltroContrato_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroContrato.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
			KeyAscii = 0
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
    Private Sub txtFiltroLegenda_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFiltroLegenda.Enter
        seleciona_no_foco(Me.ActiveControl)
    End Sub
    Private Sub txtFiltroNumeroFitaInicio_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFiltroNumeroFitaInicio.TextChanged
        lblFiltroNumeroFitaFim.Enabled = Trim(txtFiltroNumeroFitaInicio.Text) <> ""
        txtFiltroNumeroFitaFim.Enabled = Trim(txtFiltroNumeroFitaInicio.Text) <> ""
    End Sub
    Private Sub txtFiltroNumeroFitaInicio_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFiltroNumeroFitaInicio.Leave
        If Trim(txtFiltroNumeroFitaInicio.Text) = "" Then
            txtFiltroNumeroFitaFim.Text = ""
        End If
    End Sub

    Private Sub txtFiltroSequencia_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFiltroSequencia.Enter
        seleciona_no_foco(Me.ActiveControl)
    End Sub
	
	Private Sub txtFiltroSequencia_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroSequencia.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
			KeyAscii = 0
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub

    Private Sub tbFiltrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbFiltrar.Click
        picFiltro.Visible = True
        picFiltro.BringToFront()
        chkTela.CheckState = System.Windows.Forms.CheckState.Checked
        chkRelatorio.CheckState = System.Windows.Forms.CheckState.Unchecked
        flxFita.Enabled = False
        tbOpcoes.Enabled = False
        fraRelatorio.Visible = False
        fraClassificacao.Visible = False
        lblFiltro.Text = "Opções de Filtro (Consulta de Fitas)"
        ucVeiculo.Focus()
    End Sub
    Private Sub tbNumerar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbNumerar.Click
        frmControleFita_Afiliada_Determinacao.txtEmpresa(0).Text = flxFita.get_TextMatrix(flxFita.Row, 10)
        frmControleFita_Afiliada_Determinacao.txtContrato(0).Text = flxFita.get_TextMatrix(flxFita.Row, 11)
        frmControleFita_Afiliada_Determinacao.txtSequencia(0).Text = flxFita.get_TextMatrix(flxFita.Row, 12)
        frmControleFita_Afiliada_Determinacao.txtComercial(0).Text = flxFita.get_TextMatrix(flxFita.Row, 13)
        frmControleFita_Afiliada_Determinacao.ShowDialog()
        flxFita.Col = 1
        flxFita.ColSel = flxFita.Cols - 1
        flxFita_RowColChange(tbNumerar, New EventArgs)
        flxFita.Redraw = True
    End Sub
    Private Sub tbAlterar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbAlterar.Click
        Select Case Trim(UCase(flxFita.get_TextMatrix(flxFita.Row, 15)))
            Case "MIDIA"
                'frmControleFita_Afiliada_Alteracao.txtNumeroFita.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 9))
                'frmControleFita_Afiliada_Alteracao.txtEmpresa.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 10))
                'frmControleFita_Afiliada_Alteracao.txtContrato.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 11))
                'frmControleFita_Afiliada_Alteracao.txtSequencia.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 12))
                'frmControleFita_Afiliada_Alteracao.txtcomercial.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 13))
                'frmControleFita_Afiliada_Alteracao.txtveiculo.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 14))
                'frmControleFita_Afiliada_Alteracao.chkAlteracaoMidia.Checked = True
                'frmControleFita_Afiliada_Alteracao.ShowDialog()
            Case "ARTISTICO"
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                frmControle_Fita_Afiliada_Inclusao.chkLoad.Checked = False
                frmControle_Fita_Afiliada_Inclusao.txtNumero_Fita.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 9))
                frmControle_Fita_Afiliada_Inclusao.txtId_chave.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 16))
                frmControle_Fita_Afiliada_Inclusao.UcTipoComercial.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 2))
                frmControle_Fita_Afiliada_Inclusao.txtDuracao.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 4))
                frmControle_Fita_Afiliada_Inclusao.UcDataFinal.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 18))
                frmControle_Fita_Afiliada_Inclusao.UcDataInicio.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 17))

                frmControle_Fita_Afiliada_Inclusao.chkInclusao.Checked = False
                frmControle_Fita_Afiliada_Inclusao.chkAvulso.Checked = False

                frmControle_Fita_Afiliada_Inclusao.chkArtistico.Checked = True
                frmControle_Fita_Afiliada_Inclusao.chkAlteracao.Checked = True

                frmControle_Fita_Afiliada_Inclusao.txtNumero_Fita.Enabled = False
                frmControle_Fita_Afiliada_Inclusao.cmdDisponivel.Visible = False
                frmControle_Fita_Afiliada_Inclusao.Text = "Alteração de Fita Artística"
                frmControle_Fita_Afiliada_Inclusao.ShowDialog()
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Case "AVULSO"
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                frmControle_Fita_Afiliada_Inclusao.chkLoad.Checked = False
                frmControle_Fita_Afiliada_Inclusao.txtNumero_Fita.Text = VB.Right(Trim(flxFita.get_TextMatrix(flxFita.Row, 9)), 4)
                frmControle_Fita_Afiliada_Inclusao.txtId_chave.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 16))
                frmControle_Fita_Afiliada_Inclusao.UcTipoComercial.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 2))
                frmControle_Fita_Afiliada_Inclusao.txtDuracao.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 4))
                frmControle_Fita_Afiliada_Inclusao.UcDataFinal.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 18))
                frmControle_Fita_Afiliada_Inclusao.UcDataInicio.Text = Trim(flxFita.get_TextMatrix(flxFita.Row, 17))
                frmControle_Fita_Afiliada_Inclusao.chkArtistico.Checked = False
                frmControle_Fita_Afiliada_Inclusao.chkAvulso.Checked = True
                frmControle_Fita_Afiliada_Inclusao.chkInclusao.Checked = False
                frmControle_Fita_Afiliada_Inclusao.chkAlteracao.Checked = True
                frmControle_Fita_Afiliada_Inclusao.txtNumero_Fita.Enabled = False
                frmControle_Fita_Afiliada_Inclusao.cmdDisponivel.Visible = False
                frmControle_Fita_Afiliada_Inclusao.Text = "Alteração de Fita Avulsa"
                frmControle_Fita_Afiliada_Inclusao.ShowDialog()
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Select

    End Sub
    Private Sub tbDados_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbDados.Click
        With flxFita
            Dim frmControleFita_Afiliada_Dados As New frmControleFita_Afiliada_Dados()
            frmControleFita_Afiliada_Dados.chkMidia.Checked = False
            frmControleFita_Afiliada_Dados.chkAvulso.Checked = False
            frmControleFita_Afiliada_Dados.chkArtistico.Checked = False

            Select Case UCase(Trim(.get_TextMatrix(.Row, 15)))
                Case "MIDIA"
                    frmControleFita_Afiliada_Dados.chkMidia.Checked = True
                Case "AVULSO"
                    frmControleFita_Afiliada_Dados.chkAvulso.Checked = True
                Case "ARTISTICO"
                    frmControleFita_Afiliada_Dados.chkArtistico.Checked = True
            End Select
            frmControleFita_Afiliada_Dados.ShowDialog()
        End With
    End Sub

    Private Sub ucEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ucVeiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSair.Click
        Me.Close()
    End Sub

    Private Sub flxFita_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flxFita.Enter

    End Sub

    Private Sub tbExcluir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbExcluir.Click
        Call ExcluirFita()
    End Sub

    Private Sub tbDesativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDesativar.Click
        Me.DesativarFita()
    End Sub

    Private Sub tbOpcoes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbOpcoes.Click
    End Sub

    Private Sub tbAvulso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAvulso.Click

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        dim frmControle_Fita_Afiliada_Inclusao as New frmControle_Fita_Afiliada_Inclusao 

        frmControle_Fita_Afiliada_Inclusao.chkAlteracao.Checked = False
        frmControle_Fita_Afiliada_Inclusao.chkArtistico.Checked = False


        frmControle_Fita_Afiliada_Inclusao.chkAvulso.Checked = True
        frmControle_Fita_Afiliada_Inclusao.chkInclusao.Checked = True


        frmControle_Fita_Afiliada_Inclusao.ucPrograma.Text = ""
        frmControle_Fita_Afiliada_Inclusao.UcProduto.text = ""
        frmControle_Fita_Afiliada_Inclusao.UcDataInicio.Text = ""
        frmControle_Fita_Afiliada_Inclusao.UcDataFinal.Text = ""
        frmControle_Fita_Afiliada_Inclusao.UcTipoComercial.Text = ""
        frmControle_Fita_Afiliada_Inclusao.Text = "Inclusão de Fitas Avulsas"
        frmControle_Fita_Afiliada_Inclusao.ShowDialog()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub tbArtistico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbArtistico.Click

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim frmControle_Fita_Afiliada_Inclusao As New frmControle_Fita_Afiliada_Inclusao
        frmControle_Fita_Afiliada_Inclusao.chkAvulso.Checked = False
        frmControle_Fita_Afiliada_Inclusao.chkAlteracao.Checked = False

        frmControle_Fita_Afiliada_Inclusao.chkArtistico.Checked = True
        frmControle_Fita_Afiliada_Inclusao.chkInclusao.Checked = True

        frmControle_Fita_Afiliada_Inclusao.ucPrograma.Text = ""
        frmControle_Fita_Afiliada_Inclusao.ucProduto.Text = ""
        frmControle_Fita_Afiliada_Inclusao.UcDataInicio.Text = ""
        frmControle_Fita_Afiliada_Inclusao.UcDataFinal.Text = ""
        frmControle_Fita_Afiliada_Inclusao.UcTipoComercial.Text = ""
        frmControle_Fita_Afiliada_Inclusao.Text = "Inclusão de Fitas Artisticas"
        frmControle_Fita_Afiliada_Inclusao.ShowDialog()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub cmdDesmarcarTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDesmarcarTodos.Click
        On Error GoTo Erro
        With flxFita
            .Visible = False
            For nCont = 1 To .Rows - 1
                If .get_TextMatrix(nCont, 9) <> "" Then
                    .set_TextMatrix(nCont, 0, "")
                End If
            Next nCont
        End With

Saida:
        flxFita.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub flxFita_OLEDragDrop(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_OLEDragDropEvent) Handles flxFita.OLEDragDrop
    End Sub

    Private Sub tbNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNovo.Click
    End Sub

    Private Sub ucDataInicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucDataInicio.Validated
        ucPrograma.DataInicio = ucDataInicio.DateTime
    End Sub

    Private Sub ucDataFim_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucDataFim.Validated
        ucPrograma.DataFim = ucDataFim.DateTime
    End Sub


    Private Sub ucVeiculo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucVeiculo.Validated
        ucPrograma.Veiculo = ucVeiculo.Text
    End Sub
End Class