Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmBaixaAutomatica
	Inherits System.Windows.Forms.Form
	Dim nIndica_Horario As Short
	Dim bActivate As Boolean
	Dim bValidaLinha As Boolean
	Dim bBaixado(1) As Boolean
	Dim nIndica_Baixa As Short
    Dim nRow As Short
    Dim asmxBaixaVeiculacao As MSAClass.AsmxBaixaVeiculacao.asmxBaixaVeiculacao
    Dim asmxretornoPlayList As MSAClass.AsmxRetornoPlayList.asmxRetornoPlayList
    Dim asmxQualidade As MSAClass.AsmxQualidade.asmxQualidade

    Dim DtsBaixaVeiculacao As MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao
    Dim DtsRetornoPlayList As MSAClass.AsmxRetornoPlayList.dtsRetornoPlayList
    Dim DtsQualidade As MSAClass.AsmxQualidade.dtsQualidade

    Private Sub ConfiguraGrid(ByVal Par_Index As Short)

        On Error GoTo Erro
        Dim fFlex As AxMSFlexGridLib.AxMSFlexGrid = Nothing
        Select Case Par_Index
            Case 0
                fFlex = _flxRetorno_0
            Case 1
                fFlex = _flxRetorno_1
            Case 2
                fFlex = _flxRetorno_2
        End Select

        With fFlex
            .Visible = False
            .FixedCols = 0
            .FormatString = "^Veículo|Data|<Programa|Ch.Acesso|<Fita|<Titulo|Dur.|Qual|Horario|Emp|Contrato|Seq|Comercial|Veiculo Origem|Programa Origem|Numero Ce|Qualidade Anterior|Indica_Horario|Baixado|C.E"
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .AllowBigSelection = False
            .Rows = 30
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .RowHeightMin = 345
            '.Top = VB6.TwipsToPixelsY(225)
            '.Left = VB6.TwipsToPixelsX(135)
            '.Height = VB6.TwipsToPixelsY(5515)

            .set_ColWidth(0, 645)
            .set_ColWidth(1, 990)
            .set_ColWidth(2, 795)
            .set_ColWidth(3, 855)
            .set_ColWidth(4, 885)
            .set_ColWidth(5, 3285)
            .set_ColWidth(6, 405)
            .set_ColWidth(7, 495)
            '.set_ColWidth(7, 1500)
            .set_ColWidth(8, 840)

            .set_ColWidth(9, 0)
            .set_ColWidth(10, 0)
            .set_ColWidth(11, 0)
            .set_ColWidth(12, 0)
            .set_ColWidth(13, 0)
            .set_ColWidth(14, 0)
            .set_ColWidth(15, 0)
            .set_ColWidth(16, 0)
            .set_ColWidth(17, 0)
            .set_ColWidth(18, 660)
            .set_ColWidth(19, 345)


            If Par_Index = 1 Then
                .Row = 1
                .Col = 7
                txtQualidade.Height = VB6.TwipsToPixelsY(.CellHeight)
                txtQualidade.Width = VB6.TwipsToPixelsX(.CellWidth)
                txtQualidade.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + .CellLeft)
                .Col = 8
                txtHorario.Height = VB6.TwipsToPixelsY(.CellHeight)
                txtHorario.Width = VB6.TwipsToPixelsX(.CellWidth)
                txtHorario.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + .CellLeft)
            End If
            .Visible = True
        End With

Saida:
        fFlex.Visible = True
        Exit Sub

Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	'UPGRADE_WARNING: Event chkCarregar.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkCarregar_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkCarregar.CheckStateChanged
        Call CarregaGrid()
    End Sub


    Private Sub cmdBaixar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBaixar.Click

        On Error GoTo Erro
        Dim nRow As Short = 0
        Dim bValido As Boolean = False
        Dim nBaixados As Short = 0
        Dim nNaoBaixados As Short = 0
        Dim strCod_Programa As String = ""
        Dim strCod_Qualidade As String = ""
        Dim dtHorario As DateTime
        Dim intChave_Acesso As Integer = 0
        Dim sMensagem As String = ""
        Dim sCritica As String = ""
        Dim dtbPatrocinio As DataTable = New DataTable()

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        DtsBaixaVeiculacao.dtbBaixa.Clear()
        '------------------Consiste Qualidade Sem Horario
        With _flxRetorno_1
            For nRow = 1 To .Rows - 1
                If .get_TextMatrix(nRow, 17) = "1" And Trim(.get_TextMatrix(nRow, 8)) = "" Then
                    Aviso("Linha:" & nRow & " - Horário não foi Informado")
                    GoTo Saida
                End If
            Next nRow
        End With
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        If MsgBox("Confirma a baixa destas veiculações ", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then GoTo Saida
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Dim fFlex As AxMSFlexGridLib.AxMSFlexGrid = Nothing

        Select Case True
            Case optPasta1.Checked
                fFlex = _flxRetorno_0
            Case optPasta2.Checked
                fFlex = _flxRetorno_1
        End Select



        With fFlex
            For nRow = 1 To .Rows - 1
                bValido = True

                If .get_TextMatrix(nRow, 7) = "" Then ' Qualidade Digitada
                    bValido = False
                End If

                If Trim(.get_TextMatrix(nRow, 10)) = "" Then 'Numero Mr
                    bValido = False
                End If

                If Trim(.get_TextMatrix(nRow, 15)) <> "" Then 'Numero Ce
                    bValido = False
                End If

                If Trim(.get_TextMatrix(nRow, 16)) <> "" Then ' Qualidade Anterior
                    bValido = False
                End If

                If .get_TextMatrix(nRow, 0) <> .get_TextMatrix(nRow, 13) Then ' Veiculação não pertence ao veiculo origem
                    bValido = False
                End If

                If bValido Then
                    Mensagem("Baixando Linha " & nRow)
                    strCod_Programa = .get_TextMatrix(nRow, 14)
                    strCod_Qualidade = .get_TextMatrix(nRow, 7)
                    intChave_Acesso = Val(.get_TextMatrix(nRow, 3))
                    dtHorario = DateTime.Parse(FormataData(txtData_Exibicao.Text) & " " & fFlex.get_TextMatrix(nRow, 8).Substring(0, 5))
                    DtsBaixaVeiculacao.dtbBaixa.AdddtbBaixaRow("", txtVeiculo.Text, DateTime.Parse(txtData_Exibicao.Text), strCod_Programa, intChave_Acesso, strCod_Qualidade, dtHorario, "", lngIdUsuario, Now, -1)
                    nBaixados = nBaixados + 1
                    .set_TextMatrix(nRow, 16, .get_TextMatrix(nRow, 3)) ' Qualidade Anterior
                    .set_TextMatrix(nRow, 18, Chr(252)) ' Indica Baixado
                    '==================Adiciona comercial patrocinio a ser propagado a baixa
                    dtbPatrocinio.Clear()
                    dtbPatrocinio = asmxBaixaVeiculacao.spuPropagaBaixaPatrocinio(txtVeiculo.Text, DateTime.Parse(FormataData(txtData_Exibicao.Text)), strCod_Programa, intChave_Acesso)
                    For Each DRW As DataRow In dtbPatrocinio.Rows
                        'DtsBaixaVeiculacao.dtbBaixa.AdddtbBaixaRow("", txtVeiculo.Text, DateTime.Parse(txtData_Exibicao.Text), strCod_Programa, intChave_Acesso, strCod_Qualidade, dtHorario, "", lngIdUsuario, Now, -1)
                        DtsBaixaVeiculacao.dtbBaixa.AdddtbBaixaRow("", txtVeiculo.Text, DRW.Item("Data_Exibicao"), DRW.Item("Cod_Programa"), DRW.Item("Chave_Acesso"), strCod_Qualidade, dtHorario, "", lngIdUsuario, Now, -1)
                        nBaixados = nBaixados + 1
                    Next
                End If
            Next nRow
        End With
        If nBaixados > 0 Then
            sMensagem = ""
            AsmxBaixaVeiculacao.spuAtualizar(DtsBaixaVeiculacao)
            For Each drw As MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao.dtbBaixaRow In DtsBaixaVeiculacao.dtbBaixa.Rows
                sCritica = ""
                If drw.IsId_CriticaNull > -1 Then
                    Dim drwCritica As MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao.dtbBaixa_CriticaRow()
                    drwCritica = DtsBaixaVeiculacao.dtbBaixa_Critica.Select("id_critica = " & drw.Id_Critica)
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
            DtsBaixaVeiculacao.dtbBaixa.Clear()
        End If

        If nBaixados > 0 Then
            Aviso("Baixa concluida com Sucesso.")
        Else
            Aviso("Fim da Baixa. Nenhuma Veiculação foi Baixada")
        End If



Saida:
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub

    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        'With _flxRetorno_1
        '    For X As Integer = 0 To .Cols - 1
        '        Debug.Print(.get_ColWidth(X))
        '    Next

        'End With


        'If MsgBox(UCase("deseja sair da baixa automática?"), vbYesNo + vbQuestion) = vbYes Then
        Me.Dispose()
        bBaixado(0) = False
        bBaixado(1) = False
        mdiPrincipal.mnuRetorno_PlayList.Enabled = True
        'End If

    End Sub


    Private Sub cmdExibir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        If Trim(txtData_Exibicao.Text) = "" Then
            Aviso("Data de Exibição não Pode Ficar em Branco.")
            txtData_Exibicao.Focus()
            Exit Sub
        End If

        If Trim(txtVeiculo.Text) = "" Then
            Aviso("Veículo não Pode Ficar em Branco.")
            txtVeiculo.Focus()
            Exit Sub
        End If

        Call CarregaGrid()

    End Sub

    Private Sub flxRetorno_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxRetorno.DblClick
        Dim Index As Short = flxRetorno.GetIndex(eventSender)
        On Error GoTo Erro

        If Index = 2 Then
            GoTo Saida
        End If

        With flxRetorno(Index)
            If .get_TextMatrix(.Row, 9) = "" Then
                GoTo Saida
            End If

            frmRoteiroDados.txtVeiculo.Text = .get_TextMatrix(.Row, 13)
            frmRoteiroDados.txtData.Text = .get_TextMatrix(.Row, 1)
            frmRoteiroDados.txtPrograma.Text = .get_TextMatrix(.Row, 14)
            frmRoteiroDados.txtChaveAcesso.Text = .get_TextMatrix(.Row, 3)
            frmRoteiroDados.chkMidia.Checked = True
            frmRoteiroDados.ShowDialog()
            frmRoteiroDados.Dispose()

        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    '
    Private Sub flxRetorno_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxRetorno.MouseDownEvent
        Dim Index As Short = flxRetorno.GetIndex(eventSender)

        If eventArgs.button = 2 Then
            With flxRetorno(Index)
                If .MouseRow = 0 Then
                    .Focus()
                    .Col = .MouseCol
                    'PopupMenu(frmGeral.mnuGrid)
                    'Call flxRetorno_RowColChange(flxRetorno.Item(Index), New System.EventArgs())
                End If
            End With
        End If



    End Sub

    Private Sub CarregaGrid()

        'Dim fFlex As AxMSFlexGridLib.AxMSFlexGrid
        On Error GoTo Erro
        Dim nIndex As Short
        Dim btIndicaAvulso As Byte = 0
        Dim btIndicaArtistico As Byte = 0
        Dim sHorarioExibicao As String
        Dim fFlex As AxMSFlexGridLib.AxMSFlexGrid = Nothing

        Me.AsmxRetornoPlayList = NewRetornoPlayList()
        Me.asmxBaixaVeiculacao = NewBaixaVeiculacao()
        Me.AsmxQualidade = NewQualidade()
        Me.DtsRetornoPlayList = New MSAClass.AsmxRetornoPlayList.dtsRetornoPlayList
        Me.DtsBaixaVeiculacao = New MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao
        Me.DtsQualidade = New MSAClass.AsmxQualidade.dtsQualidade


        Call ConfiguraGrid(0)
        Call ConfiguraGrid(1)
        Call ConfiguraGrid(2)

        _flxRetorno_1.Location = _flxRetorno_0.Location
        _flxRetorno_2.Location = _flxRetorno_0.Location


        Mensagem("Comparando Log X Roteiro........Aguarde! ")

        If chkArtistico.Checked Then btIndicaArtistico = 1
        If chkAvulso.Checked Then btIndicaAvulso = 1

        Me.DtsRetornoPlayList.Clear()
        Me.DtsRetornoPlayList = AsmxRetornoPlayList.spuCompararPlayList(txtVeiculo.Text, txtData_Exibicao.DateTime, btIndicaAvulso, btIndicaArtistico)
        'For nCont = 0 To flxRetorno.Count - 1
        ' flxRetorno(nCont).Rows = 1
        ' flxRetorno(nCont).Visible = False
        ' Next nCont

        _flxRetorno_0.Rows = 1
        _flxRetorno_1.Rows = 1
        _flxRetorno_2.Rows = 1

        nLin = 0
        

        For Each drw As MSAClass.asmxRetornoPlayList.dtsRetornoPlayList.dtbPlayListComparaRow In DtsRetornoPlayList.dtbPlayListCompara.Rows
            nLin = nLin + 1
            Mensagem("Carregando....." & nLin)
            nIndex = drw.Status
            Select Case nIndex
                Case 0
                    fFlex = _flxRetorno_0
                Case 1
                    fFlex = _flxRetorno_1
                Case 2
                    fFlex = _flxRetorno_2
            End Select

            With fFlex

                .Rows = .Rows + 1
                If Not drw.IsCod_VeiculoNull Then .set_TextMatrix(.Rows - 1, 0, drw.Cod_Veiculo)
                If Not drw.IsData_ExibicaoNull Then .set_TextMatrix(.Rows - 1, 1, VB6.Format(drw.Data_Exibicao, "dd/mm/yyyy"))
                If Not drw.IsCod_ProgramaNull Then .set_TextMatrix(.Rows - 1, 2, drw.Cod_Programa)
                If Not drw.IsChave_AcessoNull Then .set_TextMatrix(.Rows - 1, 3, drw.Chave_Acesso)
                If Not drw.IsNumero_FitaNull Then .set_TextMatrix(.Rows - 1, 4, drw.Numero_Fita)
                If Not drw.IsTitulo_ComercialNull Then .set_TextMatrix(.Rows - 1, 5, FirstCaps(drw.Titulo_Comercial))
                If Not drw.IsDuracaoNull Then .set_TextMatrix(.Rows - 1, 6, drw.Duracao)
                If Not drw.IsCod_Veiculo_OrigemNull Then .set_TextMatrix(.Rows - 1, 13, drw.Cod_Veiculo_Origem)
                If Not drw.IsCod_Programa_OrigemNull Then .set_TextMatrix(.Rows - 1, 14, drw.Cod_Programa_Origem)
                If Not drw.IsNumero_CeNull Then .set_TextMatrix(.Rows - 1, 15, drw.Numero_Ce)
                If Not drw.IsCod_QualidadeNull Then .set_TextMatrix(.Rows - 1, 16, drw.Cod_Qualidade)

                If nIndex = 0 Then
                    .set_TextMatrix(.Rows - 1, 7, "VEI")
                Else
                    If Not drw.IsCod_QualidadeNull Then .set_TextMatrix(.Rows - 1, 7, drw.Cod_Qualidade)
                End If

                If Not drw.IsHorario_ExibicaoNull Then
                    'sHorarioExibicao = Mid(VB6.Format(drw.Horario_Exibicao, "dd-mm-yyyy hh:mm:ss"), 12, 5)
                    sHorarioExibicao = Mid(VB6.Format(drw.Horario_Exibicao, "dd-mm-yyyy hh:mm:ss"), 12, 5)

                Else
                    sHorarioExibicao = ""
                End If

                .set_TextMatrix(.Rows - 1, 8, sHorarioExibicao)
                If Not drw.IsCod_EmpresaNull Then .set_TextMatrix(.Rows - 1, 9, drw.Cod_Empresa)
                If Not drw.IsNumero_MrNull Then .set_TextMatrix(.Rows - 1, 10, drw.Numero_Mr)
                If Not drw.IsSequencia_MrNull Then .set_TextMatrix(.Rows - 1, 11, drw.Sequencia_Mr)

                If nIndex = 0 Or nIndex = 1 Then
                    .Row = .Rows - 1
                    .Col = 18
                    .CellFontName = "WingDings"
                    .CellForeColor = System.Drawing.Color.Blue
                    .CellFontSize = 14
                    .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter

                    .Col = 19
                    .CellFontName = "WingDings"
                    .CellForeColor = System.Drawing.Color.Blue
                    .CellFontSize = 14
                    .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter

                    If Not drw.IsCod_QualidadeNull Then
                        .set_TextMatrix(.Rows - 1, 18, Chr(252))
                    End If
                    If Not drw.IsNumero_CeNull Then
                        .set_TextMatrix(.Rows - 1, 19, Chr(252))
                    End If

                End If
            End With
        Next

        If _flxRetorno_0.Rows < 30 Then _flxRetorno_0.Rows = 30
        If _flxRetorno_1.Rows < 30 Then _flxRetorno_1.Rows = 30
        If _flxRetorno_1.Rows < 30 Then _flxRetorno_1.Rows = 30

        _flxRetorno_0.Visible = True
        _flxRetorno_1.Visible = True
        _flxRetorno_2.Visible = True

Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmBaixaAutomatica_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
    End Sub

    Private Sub frmBaixaAutomatica_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000

        If KeyCode = 38 And (UCase(Me.ActiveControl.Name) = "TXTHORARIO" Or UCase(Me.ActiveControl.Name) = "TXTQUALIDADE") Then
            bValidaLinha = True
            If bValidaLinha = True Then
                With _flxRetorno_1
                    If .Row > 1 Then
                        .Row = .Row - 1
                    End If
                End With
            End If
        ElseIf KeyCode = 40 And (UCase(Me.ActiveControl.Name) = "TXTHORARIO" Or UCase(Me.ActiveControl.Name) = "TXTQUALIDADE") Then

            bValidaLinha = True
            If bValidaLinha = True Then
                With _flxRetorno_1
                    If .Row < .Rows - 1 Then
                        .Row = .Row + 1
                    End If
                End With
            End If
        End If

    End Sub

    Private Sub frmBaixaAutomatica_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        On Error GoTo Erro
        SetaUserControl(Me)
        Me.AutoSize = True
        Me.CenterToParent()


        Dim dtsBaixaCritica As New MSAClass.AsmxBaixaVeiculacao.dtsBaixaVeiculacao
        dtsBaixaCritica = AsmxBaixaVeiculacao.spuCarregar()

        DtsQualidade = AsmxQualidade.spuCarregar("")
        For nCont = 0 To fraPasta.Count - 1
            fraPasta(nCont).Location = New System.Drawing.Point(15, 33)
            fraPasta(nCont).Size = New System.Drawing.Size(725, 397)
            fraPasta(nCont).Text = ""
            fraPasta(nCont).Visible = False
        Next nCont
        Call ConfiguraGrid(0)
        Call ConfiguraGrid(1)
        Call ConfiguraGrid(2)
        optPasta1.Checked = True
        _flxRetorno_1.Tag = 1
        fraPasta(0).Visible = True
        _flxRetorno_0.Visible = True
        fraPasta(0).BringToFront()
        cmdBaixar.Visible = True


Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub



    Private Sub frmBaixaAutomatica_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        mdiPrincipal.mnuRetorno_PlayList.Enabled = True
    End Sub

    Private Sub tabBaixa_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        On Error GoTo Erro

        cmdBaixar.Visible = False
        '_flxRetorno_0.Visible = False
        '_flxRetorno_1.Visible = False
        '_flxRetorno_2.Visible = False

        txtQualidade.Visible = False
        txtHorario.Visible = False


        'Select Case tabBaixa.SelectedItem.Index
        Select Case True
            Case optPasta1.Checked
                fraPasta(0).Visible = True
                _flxRetorno_0.Visible = True
                fraPasta(0).BringToFront()
                cmdBaixar.Visible = True
            Case optPasta2.Checked
                fraPasta(1).Visible = True
                _flxRetorno_1.Visible = True
                fraPasta(1).BringToFront()
                cmdBaixar.Visible = True
            Case optPasta3.Checked
                fraPasta(2).Visible = True
                _flxRetorno_2.Visible = True
                fraPasta(2).BringToFront()

        End Select
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub txtHorario_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHorario.TextChanged
        If _flxRetorno_1.Tag = 1 Then
            With _flxRetorno_1
                If .Tag = 1 Then .set_TextMatrix(.Row, 8, txtHorario.Text)
            End With
        End If
    End Sub

    Private Sub txtHorario_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtHorario.Enter
        seleciona_no_foco(txtHorario)
    End Sub


    Private Sub txtHorario_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHorario.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        On Error GoTo Erro
        KeyAscii = Asc(UCase(Chr(KeyAscii)))


        If KeyAscii = 13 Then
            Call txtHorario_Validating(txtHorario, New System.ComponentModel.CancelEventArgs(False))
            If Not bValidaLinha Then
                GoTo Saida
            End If
            With _flxRetorno_1
                If .Row < .Rows - 1 Then
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

    Private Sub txtHorario_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHorario.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        If Trim(txtHorario.Text) = "" Then
            GoTo Saida
        End If

        If Not isTime(formataHora(txtHorario.Text)) Then
            Aviso("esse não é um horário válido.")
            Cancel = True
            GoTo Saida
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object formataHora(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtHorario.Text = formataHora(txtHorario.Text)



Saida:
        If Cancel Then
            txtHorario.Text = ""
        End If
        bValidaLinha = Not Cancel
        GoTo EventExitSub
Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub

    'UPGRADE_WARNING: Event txtQualidade.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtQualidade_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQualidade.TextChanged
        If _flxRetorno_1.Tag = 1 Then
            With _flxRetorno_1
                .set_TextMatrix(.Row, 7, txtQualidade.Text)
            End With
        End If
    End Sub

    Private Sub txtQualidade_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQualidade.Enter
        seleciona_no_foco(txtQualidade)
    End Sub

    Private Sub txtQualidade_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtQualidade.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        On Error GoTo Erro
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        If KeyAscii = 13 Then
            With _flxRetorno_1

                'If txtQualidade.Text = "" And .Row > 1 Then
                ' txtQualidade.Text = .get_TextMatrix(.Row - 1, 7)
                ' End If

                Call txtQualidade_Validating(txtQualidade, New System.ComponentModel.CancelEventArgs(False))
                If Not bValidaLinha Then
                    GoTo Saida
                End If
                If nIndica_Horario Then
                    txtHorario.Focus()
                Else
                    If .Row < .Rows - 1 Then
                        .Row = .Row + 1
                    End If
                End If

            End With
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

    Private Sub txtQualidade_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtQualidade.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        bValidaLinha = True
        nIndica_Horario = 0


        If txtQualidade.Text.Trim = "" Then
            'txtHorario.Text = ""
            With _flxRetorno_1
                If .Tag = 1 Then .set_TextMatrix(.Row, 7, "")
                '.set_TextMatrix(.Row, 8, "")
            End With
            GoTo Saida
        End If

        Dim Drw As MSAClass.AsmxQualidade.dtsQualidade.dtbQualidadeRow()
        sSql = "Cod_Qualidade = '" & txtQualidade.Text & "' and indica_parametro = 1 "
        Drw = DtsQualidade.dtbQualidade.Select(sSql)

        If Drw.Length = 0 Then
            Aviso("Qualidade Inválida")
            Cancel = True
            seleciona_no_foco(txtQualidade)
            GoTo Saida
        End If

        nIndica_Horario = Drw(0).Indica_Horario

        'If nIndica_Horario = 0 Then
        '    If tabBaixa.SelectedItem.Index = 1 Then
        '        Aviso("esta pasta só aceita qualidades que indiquem horário ou qualidade branca.")
        '        bValidaLinha = False
        '        seleciona_no_foco(txtQualidade)
        '        GoTo Saida
        '    End If
        '    txtHorario.Text = ""
        'End If
Saida:

        With _flxRetorno_1
            .set_TextMatrix(.Row, 17, nIndica_Horario)

        End With

        If Cancel Then
            txtQualidade.Text = ""
        End If

        bValidaLinha = Not Cancel

        GoTo EventExitSub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume


EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub


    Private Sub tabBaixa_BeforeClick(ByVal sender As System.Object, ByVal e As AxComctlLib.ITabStripEvents_BeforeClickEvent)
    End Sub

    Private Sub _flxRetorno_1_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _flxRetorno_1.RegionChanged
    End Sub

    Private Sub _flxRetorno_1_RowColChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles _flxRetorno_1.RowColChange
        On Error GoTo Erro
        Dim bValido As Boolean

        With _flxRetorno_1

            If Not .Visible Then
                GoTo Saida
            End If

            _flxRetorno_1.Tag = 0
            txtQualidade.Text = ""
            txtHorario.Text = ""
            txtQualidade.Visible = False
            txtHorario.Visible = False
            _flxRetorno_1.Tag = 1

            bValido = True
            If .Row < .FixedRows Or Not .get_RowIsVisible(.Row) Then
                bValido = False
            End If

            If Trim(.get_TextMatrix(.Row, 3)) = "" Then ' Chave acesso
                bValido = False
            End If

            If Trim(.get_TextMatrix(.Row, 15)) <> "" Then ' Numero Ce
                bValido = False
            End If

            If Trim(.get_TextMatrix(.Row, 16)) <> "" Then ' Qualidade Anterior
                bValido = False
            End If

            If bValido Then
                txtQualidade.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + .CellTop)
                txtHorario.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + .CellTop)

                txtQualidade.Text = .get_TextMatrix(.Row, 7)
                txtHorario.Text = .get_TextMatrix(.Row, 8)
                txtQualidade.Visible = True
                txtHorario.Visible = True
                If txtQualidade.Enabled Then txtQualidade.Focus()
            End If


        End With

Saida:
        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub



    Private Sub frmBaixaAutomatica_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
    End Sub

    Private Sub frmBaixaAutomatica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Debug.Print(fraPasta(0).Location.ToString)
        Debug.Print(fraPasta(0).Size.ToString)


    End Sub

    Private Sub _flxRetorno_1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles _flxRetorno_1.Scroll
        _flxRetorno_1.Tag = 0
        txtQualidade.Text = ""
        txtHorario.Text = ""
        txtQualidade.Visible = False
        txtHorario.Visible = False
        _flxRetorno_1.Tag = 1
    End Sub

    Private Sub optPasta1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPasta1.Click
        On Error GoTo Erro
        cmdBaixar.Visible = False
        txtQualidade.Visible = False
        txtHorario.Visible = False
        fraPasta(0).Visible = True
        _flxRetorno_0.Visible = True
        fraPasta(0).BringToFront()
        cmdBaixar.Visible = True
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub

    Private Sub optPasta2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPasta2.Click
        On Error GoTo Erro
        cmdBaixar.Visible = False
        txtQualidade.Visible = False
        txtHorario.Visible = False
        fraPasta(1).Visible = True
        _flxRetorno_1.Visible = True
        fraPasta(1).BringToFront()
        cmdBaixar.Visible = True
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub optPasta3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPasta3.Click
        On Error GoTo Erro
        cmdBaixar.Visible = False
        txtQualidade.Visible = False
        txtHorario.Visible = False
        fraPasta(2).Visible = True
        _flxRetorno_2.Visible = True
        fraPasta(2).BringToFront()
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
End Class