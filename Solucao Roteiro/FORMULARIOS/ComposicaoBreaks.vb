Option Strict Off
Option Explicit On
Friend Class frmComposicaoBreaks
    Inherits System.Windows.Forms.Form
    '---------------------------------------------------------------------------------
    '--[01] SCAC 920 - 25/08/2005 - Josely - Parametrização da Faixa Horária
    '---------------------------------------------------------------------------------
    Dim MouseX As Short
    Dim MouseY As Short
    Dim bCancelar As Boolean
    Dim asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro = NewRoteiro()
    Dim asmxBreak As MSAClass.AsmxBreak.asmxBreak = NewBreak()
    Dim asmxPorta As MSAClass.AsmxPorta.asmxPorta = NewPorta()
    Dim asmxGrade As MSAClass.AsmxGrade.asmxGrade = NewGrade()
    Dim asmxFaixaHoraria As MSAClass.AsmxFaixaHoraria.asmxFaixaHoraria = NewFaixaHoraria()
    Dim asmxParametro_Roteiro As MSAClass.AsmxParametro_Roteiro.asmxParametro_Roteiro = NewParametro_Roteiro()
    Dim dtsBreak As MSAClass.AsmxBreak.dtsBreak
    Public dtsParametro_Roteiro As New MSAClass.AsmxParametro_Roteiro.dtsParametro_Roteiro
    Dim dtsFaixaHoraria As New MSAClass.AsmxFaixaHoraria.dtsFaixaHoraria
    Dim dtsGrade As New MSAClass.AsmxGrade.dtsGrade
    Dim dtsPorta As New MSAClass.AsmxPorta.dtsPorta
    Dim strUltimoPrograma As String = ""
    Dim strUltimaData As DateTime = Date.MinValue
    Dim strUltimoVeiculo As String = ""


    Private Sub CarregaDadosAlteracao()
        On Error GoTo Erro

        Dim nContBreak As Integer
        Dim nLoop As Integer
        Dim nBreakAnter As Integer
        Dim nTotalBreakAnter As Single
        Dim Cor As Object
        Dim strUltimaData As String = ""

        UcDatade.Text = ucData.Text
        UcDataAte.Text = ucData.Text
        UcDatade.Tag = ucData.Text
        UcDataAte.Tag = ucData.Text

        lblDispoTotal.Text = ""
        lblDispoNet.Text = ""
        lblDispoLocal.Text = ""



        Me.Cursor = Cursors.WaitCursor


        For Each drw As MSAClass.AsmxGrade.dtsGrade.dtbGradeRow In Me.dtsGrade.dtbGrade.Rows

            txtInicio.Text = VB6.Format(drw.Horario_Inicial, "hh:mm")

            txtInicio.Tag = txtInicio.Text

            txtTermino.Text = VB6.Format(drw.Horario_Final, "hh:mm")

            txtTermino.Tag = txtTermino.Text


            txtDispoTotal.Text = drw.Dispo_Total
            lblDispoTotal.Text = drw.Dispo_Total
            txtDispoNet.Text = drw.Dispo_Net
            lblDispoNet.Text = drw.Dispo_Net
            txtDispoLocal.Text = drw.Dispo_Programa
            lblDispoLocal.Text = drw.Dispo_Programa

            txtPctTotal.Text = CStr(100)
            If Val(txtDispoLocal.Text) > 0 And Val(txtDispoTotal.Text) > 0 Then
                txtPctLocal.Text = CStr((Val(txtDispoLocal.Text) * 100) / Val(txtDispoTotal.Text))
            End If
            If (Val(txtDispoNet.Text)) > 0 And Val(txtDispoTotal.Text) Then
                txtPctNet.Text = CStr((Val(txtDispoNet.Text) * 100) / Val(txtDispoTotal.Text))
            End If


            With cboFaixaHoraria
                For nCont = 0 To .Items.Count - 1
                    If VB6.GetItemData(cboFaixaHoraria, nCont) = drw.Id_Faixa Then
                        cboFaixaHoraria.SelectedIndex = nCont
                    End If
                Next
            End With


            chkDiasSemana(Weekday(CDate(UcData.Text)) - 1).CheckState = System.Windows.Forms.CheckState.Checked

        Next

        nContBreak = -1


        DtsBreak = AsmxBreak.spuCarregar_Break(ucVeiculo.Text, UcData.Text, ucPrograma.Text)



        With flxComposicao

            .Visible = False
            nLin = 0
            nBreakAnter = 0
            nTotalBreakAnter = 0
            Cor = &H80000005

            For Each drw_Break As MSAClass.AsmxBreak.dtsBreak.dtbBreakRow In dtsBreak.dtbBreak.Rows

                nLin = nLin + 1
                If nLin >= .Rows - 1 Then
                    .Rows = .Rows + 1
                End If

                .Row = nLin

                .set_TextMatrix(nLin, fColuna(flxComposicao, ""), Space(50) & drw_Break.nBreak)
                .set_TextMatrix(nLin, fColuna(flxComposicao, "Flag"), 0)

                If Not drw_Break.IsSequencia_BreakNull Then
                    .Col = fColuna(flxComposicao, "Sequência")
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Sequência"), drw_Break.Sequencia_Break)
                Else
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Sequência"), "")
                    .Col = fColuna(flxComposicao, "Break")
                End If

                If drw_Break.nBreak.ToString.Length > 0 Then
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Break"), drw_Break.nBreak)
                End If

                .CellFontSize = 10
                .CellFontBold = True

                If drw_Break.Descricao.ToString.Length > 0 Then
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Tipo"), drw_Break.Descricao)
                End If

                If drw_Break.Duracao.ToString.Length > 0 Then
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Duração"), drw_Break.Duracao)
                End If

                '  If Not drw_Break.IsHora_InicioNull Then
                ' If drw_Break.Hora_Inicio.ToString.Length > 0 Then
                ' .set_TextMatrix(nLin, fColuna(flxComposicao, "Horário"), VB6.Format(drw_Break.Hora_Inicio, "hh:mm"))
                ' End If
                ' Else
                ' .set_TextMatrix(nLin, fColuna(flxComposicao, "Horário"), "")
                ' End If

                If drw_Break.Sequencia_Faixa.ToString.Length > 0 Then
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Faixa"), drw_Break.Sequencia_Faixa)
                End If

                If Not drw_Break.IsObservacaoNull() Then
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Rodape"), drw_Break.Observacao)
                End If

                If Not drw_Break.IsTitulo_BreakNull() Then
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "TituloOriginal"), drw_Break.Titulo_Break.Trim)
                End If

                If Not drw_Break.IsTipo_BreakNull() Then
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Cod."), drw_Break.Tipo_Break)
                End If

                .Col = fColuna(flxComposicao, "")
                .CellPicture = picDesmarcado.Image
                .CellPictureAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter

                ' Coloca a Cor
                If drw_Break.nBreak = nBreakAnter Then
                    .Row = nLin
                    For nCont = 0 To .Cols - 1
                        .Col = nCont
                        .CellBackColor = System.Drawing.ColorTranslator.FromOle(Cor)
                    Next
                End If

                If drw_Break.nBreak <> nBreakAnter Then
                    If nTotalBreakAnter > 0 Then
                        For nCont = nLin - 1 To 1 Step -1
                            If Val(.get_TextMatrix(nCont, fColuna(flxComposicao, "Break"))) <> nBreakAnter Then
                                Exit For
                            End If
                            .set_TextMatrix(nCont, fColuna(flxComposicao, "Total"), VB6.Format(StrZero(Int(nTotalBreakAnter / 60), 2) & StrZero(nTotalBreakAnter Mod 60, 2), "00:00") & " (" & Trim(Str(nBreakAnter)) & ")")
                            .Row = nCont
                            .Col = fColuna(flxComposicao, "")
                            .CellForeColor = System.Drawing.Color.Blue
                            .CellFontSize = 10
                        Next

                        nTotalBreakAnter = 0
                        If Cor = &H80000005 Then
                            Cor = &HE0E0E0
                        Else
                            Cor = &H80000005
                        End If

                        .Row = nLin
                        For nCont = 0 To .Cols - 1
                            .Col = nCont
                            .CellBackColor = System.Drawing.ColorTranslator.FromOle(Cor)
                        Next

                    End If

                    nBreakAnter = drw_Break.nBreak

                End If

                If drw_Break.IsTitulo_BreakNull Then
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Titulo"), Trim(ucPrograma.Descricao))
                Else
                    .set_TextMatrix(nLin, fColuna(flxComposicao, "Titulo"), drw_Break.Titulo_Break)
                End If

                nTotalBreakAnter = nTotalBreakAnter + CDec(.get_TextMatrix(nLin, fColuna(flxComposicao, "Duração")))

                ' nLin = nLin + 1
                If Not drw_Break.IsObservacaoNull Then
                    txtRodapeInter.Text = drw_Break.Observacao
                End If


            Next


            If nTotalBreakAnter > 0 Then
                For nCont = nLin To 1 Step -1
                    If Val(.get_TextMatrix(nCont, fColuna(flxComposicao, "Break"))) <> nBreakAnter Then
                        nTotalBreakAnter = 0
                        Exit For
                    End If
                    .set_TextMatrix(nCont, fColuna(flxComposicao, "Total"), VB6.Format(StrZero(Int(nTotalBreakAnter / 60), 2) & StrZero(nTotalBreakAnter Mod 60, 2), "00:00") & " (" & Trim(Str(nBreakAnter)) & ")")
                    .Row = nCont
                    .Col = fColuna(flxComposicao, "Total")
                    .CellForeColor = System.Drawing.Color.Blue
                    .CellFontSize = 10
                Next
            End If


            '==========================Coloca cores nos Intervalos
            For nCont = 1 To .Rows - 1
                .Row = nCont
                .Col = fColuna(flxComposicao, "Tipo")
                Select Case .get_TextMatrix(nCont, fColuna(flxComposicao, "Cod."))
                    Case CStr(0) ' Local ou PE
                        .CellForeColor = System.Drawing.Color.Blue
                    Case CStr(1) ' Net
                        .CellForeColor = System.Drawing.ColorTranslator.FromOle(&HFF00FF)
                    Case CStr(2)
                        .CellForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
                    Case CStr(3)
                        .CellForeColor = System.Drawing.Color.Red
                    Case Else
                        .CellForeColor = System.Drawing.Color.Black
                End Select

            Next nCont


            .Row = 1
            .Visible = True
            flxComposicao_RowColChange(flxComposicao, New System.EventArgs())


        End With

        strUltimaData = AsmxBreak.spuUltimaDataComposta(ucVeiculo.Text, ucPrograma.Text)

        If Not DateTime.Parse(strUltimaData) = "01/01/1900" Then
            lblUltimaData.Text = strUltimaData
        End If



        Call SomaComposicao()

Saida:
        flxComposicao.Visible = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub ConfiguraGrid()
        On Error GoTo Erro

        With flxComposicao
            .Clear()

            .Visible = False
            .FormatString = "|^Total|^Break|^Horário|^Sequência|<Titulo|^Tipo|^Duração|^Faixa|Rodape|TituloOriginal|Cod.|Flag"
            .FixedRows = 1
            .Rows = 14
            .Row = 0
            .RowHeightMin = 300
            .BackColorBkg = .BackColor

            For nCont = 0 To .Cols - 1
                .Col = nCont
                .CellFontBold = True
            Next

            '.ColWidth(0) = 300
            '.ColWidth(1) = 900
            '.ColWidth(2) = 900
            '.ColWidth(3) = 1100
            '.ColWidth(4) = 3570
            '.ColWidth(5) = 1735
            '.ColWidth(6) = 885
            '.ColWidth(7) = 885
            '.ColWidth(8) = 0
            '.ColWidth(9) = 0

            .set_ColWidth(fColuna(flxComposicao, ""), 300)
            .set_ColWidth(fColuna(flxComposicao, "Total"), 1110)
            .set_ColWidth(fColuna(flxComposicao, "Break"), 660)
            .set_ColWidth(fColuna(flxComposicao, "Horário"), 0)
            .set_ColWidth(fColuna(flxComposicao, "Sequência"), 1035)
            .set_ColWidth(fColuna(flxComposicao, "Titulo"), 3675)
            .set_ColWidth(fColuna(flxComposicao, "Tipo"), 1740)
            .set_ColWidth(fColuna(flxComposicao, "Duração"), 885)
            .set_ColWidth(fColuna(flxComposicao, "Faixa"), 0)
            .set_ColWidth(fColuna(flxComposicao, "Rodape"), 0)
            .set_ColWidth(fColuna(flxComposicao, "TituloOriginal"), 0)
            .set_ColWidth(fColuna(flxComposicao, "Cod."), 0)
            .set_ColWidth(fColuna(flxComposicao, "Flag"), 0)


            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeRestrictAll
            .set_MergeCol(fColuna(flxComposicao, ""), True)
            .set_MergeCol(fColuna(flxComposicao, "Total"), True)
            .set_MergeCol(fColuna(flxComposicao, "Break"), True)
            .set_MergeCol(fColuna(flxComposicao, "Sequência"), True)
            .set_MergeCol(fColuna(flxComposicao, "Titulo"), True)

            .Row = 0
            .Col = 0
            chkMarcarTodos.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + .CellTop + 45)
            chkMarcarTodos.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + .CellLeft + 45)
            chkMarcarTodos.CheckState = System.Windows.Forms.CheckState.Unchecked
        End With

Saida:
        flxComposicao.Row = 1
        flxComposicao.Visible = True
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

    Private Sub ExcluiBreaK(ByRef Par_Linha As Object, ByRef Par_Coluna As Object)
        On Error GoTo Erro

        Dim nBreak As Integer
        Dim nSequencaFaixa As Short
        Dim bExisteRoteiro As Boolean
        Dim bExclui As Boolean
        Dim sMensagem As String



        With flxComposicao
            nBreak = Val(flxComposicao.get_TextMatrix(Par_Linha, fColuna(flxComposicao, "Break")))

            nSequencaFaixa = Val(flxComposicao.get_TextMatrix(Par_Linha, fColuna(flxComposicao, "Faixa")))

            Select Case Par_Coluna
                Case 0, 1, 2, 3
                    bExisteRoteiro = ExisteRoteiro(ucVeiculo.Text, UcData.Text, ucPrograma.Text, nBreak)
                    'sMensagem = "Confirma a Exclusão Total do Break " & nBreak & " ?"
                Case Else
                    bExisteRoteiro = ExisteRoteiro(ucVeiculo.Text, UcData.Text, ucPrograma.Text, nBreak, nSequencaFaixa)
                    'sMensagem = "Confirma a Exclusão do Intervalo " & flxComposicao.TextMatrix(Par_Linha, fColuna(flxComposicao, "Tipo")) & " do Break " & nBreak & " ?"
            End Select

            If bExisteRoteiro Then

                MsgBox("Existem Roteiro Ordenado Neste Intervalo.(Break " & nBreak & ") Exclusão Cancelada", MsgBoxStyle.OkOnly)
                bCancelar = True
                GoTo Saida
            End If

            .Visible = False
            For nCont = .Rows - 1 To 1 Step -1
                bExclui = False
                Select Case Par_Coluna
                    Case 0, 1, 2, 3
                        If nBreak = Val(.get_TextMatrix(nCont, fColuna(flxComposicao, "Break"))) Then
                            bExclui = True
                        End If
                    Case Else
                        If nBreak = Val(.get_TextMatrix(nCont, fColuna(flxComposicao, "Break"))) And nSequencaFaixa = Val(.get_TextMatrix(nCont, fColuna(flxComposicao, "Faixa"))) Then
                            bExclui = True
                        End If
                End Select
                If bExclui Then
                    .RemoveItem(nCont)
                    .Rows = .Rows + 1
                End If
            Next nCont

            Call Totaliza(nBreak)
            Call SomaComposicao()
            Call CordeFundo()

            flxComposicao_RowColChange(flxComposicao, New System.EventArgs())
        End With
Saida:
        flxComposicao.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub GravaBreak()

        On Error GoTo Erro
        Dim aParam(15) As Object
        Dim aTipos(15) As Object


        Me.Cursor = Cursors.WaitCursor

        Dim sBreak As String = ""
        Dim sSequencia_Faixa As String = ""
        Dim sDuracao As String = ""
        Dim sDiaSemana As String = ""
        Dim sTipo_Break As String = ""
        Dim sSequencia_Break As String = ""
        Dim sObservacao As String = ""
        Dim sTituloBreak As String = ""
        Dim sSequencia As String = ""
        Dim sRodape_Inter As String = ""
        Dim sId_Processo As String = ""
        Dim sHorario As String = ""

        sDiaSemana = ""

        For nCont = 0 To 6
            sDiaSemana = sDiaSemana & IIf(chkDiasSemana(nCont).CheckState = 1, "S", "N")
        Next nCont

        DtsBreak.dtbTBRSA_BREAK.Clear()

        sId_Processo = AsmxRoteiro.spuGetId()


        With flxComposicao
            For nLin = 1 To .Rows - 1

                sBreak = ""
                sSequencia_Faixa = ""
                sDuracao = ""
                sTipo_Break = ""
                sTituloBreak = ""
                sSequencia_Break = ""
                sObservacao = ""
                sSequencia = ""
                sHorario = ""

                If Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Break"))) <> "" Then
                    sBreak = Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Break")))
                    sSequencia_Faixa = Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Faixa")))
                    sDuracao = Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Duração")))
                    If Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Horário"))) <> "" Then
                        sHorario = VB6.Format(DateTime.Parse(UcData.DateTime), "yyyy-mm-dd") & " " & Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Horário")))
                        'Else
                        '    sHorario 
                    End If
                    sTipo_Break = Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Cod.")))
                    sTituloBreak = Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "TituloOriginal")))
                    sSequencia_Break = Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Sequência")))
                    sObservacao = Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Rodape")))
                    sSequencia = nLin


                    If sBreak = "" Then sBreak = "0"
                    If sSequencia_Faixa = "" Then sSequencia_Faixa = "0"
                    If sDuracao = "" Then sDuracao = "0"
                    'If sHorario = "" Then sHorario = "0"
                    If sTipo_Break = "" Then sTipo_Break = "0"
                    'If sTituloBreak = "" Then sTituloBreak = "0"
                    If sSequencia_Break = "" Then sSequencia_Break = "-1"
                    'If sObservacao = "" Then sObservacao = "0"
                    If sSequencia = "" Then sSequencia = "0"
                    If txtRodapeInter.Text = "" Then txtRodapeInter.Text = "0"
                    DtsBreak.dtbTBRSA_BREAK.AdddtbTBRSA_BREAKRow(sId_Processo, _
                                                                ucVeiculo.Text, _
                                                                DateTime.Parse(UcData.DateTime), _
                                                                ucPrograma.Text, _
                                                                sDiaSemana, _
                                                                sBreak, _
                                                                sSequencia_Faixa, _
                                                                sDuracao, _
                                                                sHorario, _
                                                                sTipo_Break, _
                                                                sTituloBreak, _
                                                                sSequencia_Break, _
                                                               sObservacao, _
                                                               sSequencia, _
                                                               txtRodapeInter.Text, _
                                                               DateTime.Parse(UcDatade.DateTime), _
                                                               DateTime.Parse(UcDataAte.DateTime), _
                                                               0)
                End If
            Next nLin
        End With


        Mensagem("Gravando Breaks para Veiculo " & ucVeiculo.TEXT)

        AsmxBreak.spuGravar_Break_Temp(DtsBreak)

        DtsBreak.dtbTBRSA_BREAK.Clear()

        Mensagem("")

        DtsBreak = AsmxBreak.spuSalvar_Break(ucVeiculo.TEXT, _
                                    UcData.Text, _
                                    UcPrograma.TEXT, _
                                    sDiaSemana, _
                                    sRodape_Inter, _
                                    UcDatade.Text, _
                                    UcDataAte.Text, _
                                    1, _
                                    sId_Processo.Trim())


        '----------------------Carrega o Grid de Critica
        Call ConfiguraGridCritica()
        nLin = 0
        With flxCritica
            For Each drw As MSAClass.AsmxBreak.dtsBreak.dtbCritica_BreakRow In dtsBreak.dtbCritica_Break.Rows
                If drw.Indica_Critica = 1 Then
                    nLin = nLin + 1
                    If nLin >= .Rows Then
                        .Rows = .Rows + 1
                    End If
                    If Not drw.IsData_ExibicaoNull Then
                        .set_TextMatrix(nLin, 0, drw.Data_Exibicao)
                    End If
                    If Not drw.IsCriticaNull Then
                        .set_TextMatrix(nLin, 1, drw.Critica)
                    End If

                End If
            Next
        End With

        '----------------------Finaliza

        If nLin > 0 Then
            Mensagem("")
            Me.Cursor = Cursors.Default
            Aviso("Houve critica na Composicao de Breaks")
            picCritica.Visible = True
        Else
            Mensagem("")
            Me.Cursor = Cursors.Default
            Aviso("Composição de Break atualizada com sucesso")
            LimpaInformacoes()
            'ucVeiculo.TEXT = ""
            ucPrograma.Text = ""

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

    Private Sub LimpaInformacoes()

        Dim nLoopLimpa As Short

        txtInicio.Text = ""
        txtTermino.Text = ""

        txtDispoTotal.Text = ""
        txtDispoNet.Text = ""
        txtDispoLocal.Text = ""

        txtPctTotal.Text = ""
        txtPctNet.Text = ""
        txtPctLocal.Text = ""

        UcDatade.Text = ""
        UcDataAte.Text = ""

        lblDispoLocal.Text = ""
        lblDispoNet.Text = ""
        lblDispoTotal.Text = ""

        lblComposicaoLocal.Text = ""
        lblComposicaoNet.Text = ""
        lblComposiçãoTotal.Text = ""

        lblUltimaData.Text = ""
        asmxPorta.spuLimpar(2, gsUsuario)
        txtRodapeInter.Text = ""

        ' Limpa os Dias da Semana
        For nLoopLimpa = 0 To chkDiasSemana.Count - 1
            chkDiasSemana(nLoopLimpa).CheckState = System.Windows.Forms.CheckState.Unchecked
        Next

        ' Limpa as Faixas Horarias
        '--[01] Inicio
        '   For nLoopLimpa = 0 To optFaixaHoraria.Count - 1
        '      optFaixaHoraria(nLoopLimpa).Value = False
        '   Next
        Call CarregaFaixaHoraria(cboFaixaHoraria)
        cboFaixaHoraria.SelectedIndex = -1
        '--[01] Termino

        ' Limpa o Flex Grid
        Call ConfiguraGrid()

    End Sub

    'UPGRADE_WARNING: Event ChkMarcarTodos.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub ChkMarcarTodos_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkMarcarTodos.CheckStateChanged
        On Error GoTo Erro
        Dim nBreakAnterior As Short
        Dim nLoop As Short


        nBreakAnterior = -1

        With flxComposicao
            If .Visible Then
                For nLoop = 1 To .Rows - 1
                    If Trim(.get_TextMatrix(nLoop, fColuna(flxComposicao, "Break"))) <> "" Then
                        If nBreakAnterior <> Val(.get_TextMatrix(nLoop, fColuna(flxComposicao, "Break"))) Then
                            nBreakAnterior = Val(.get_TextMatrix(nLoop, fColuna(flxComposicao, "Break")))
                            Call Marca_Desmarca(nBreakAnterior, (chkMarcarTodos.CheckState))
                        End If
                    End If
                Next nLoop
            End If
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub



    Private Sub cmdCriticaFechar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCriticaFechar.Click
        Dim Index As Short = cmdCriticaFechar.GetIndex(eventSender)
        picCritica.Visible = False
    End Sub


    Private Sub cmdDesce_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDesce.Click

        On Error GoTo Erro
        Dim aGuarda() As Object

        Dim nRow1, nRow2 As Short
        With flxComposicao
            ReDim aGuarda(.Cols - 1)
            nRow1 = .Row
            nRow2 = .Row + 1

            For nCont = 0 To .Cols - 1
                'UPGRADE_WARNING: Couldn't resolve default property of object aGuarda(nCont). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aGuarda(nCont) = .get_TextMatrix(nRow2, nCont)
            Next nCont

            For nCont = 0 To .Cols - 1
                .set_TextMatrix(nRow2, nCont, .get_TextMatrix(nRow1, nCont))
            Next nCont

            For nCont = 0 To .Cols - 1
                'UPGRADE_WARNING: Couldn't resolve default property of object aGuarda(nCont). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .set_TextMatrix(nRow1, nCont, aGuarda(nCont))
            Next nCont

            .Row = nRow1
            .Col = fColuna(flxComposicao, "tipo")
            Select Case .get_TextMatrix(nRow1, fColuna(flxComposicao, "Cod."))
                Case CStr(0) ' Local ou PE
                    .CellForeColor = System.Drawing.Color.Blue
                Case CStr(1) ' Net
                    .CellForeColor = System.Drawing.ColorTranslator.FromOle(&HFF00FF)
                Case CStr(2)
                    .CellForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
                Case CStr(3)
                    .CellForeColor = System.Drawing.Color.Red
                Case Else
                    .CellForeColor = System.Drawing.Color.Black
            End Select

            .Row = nRow2
            .Col = fColuna(flxComposicao, "tipo")
            Select Case .get_TextMatrix(nRow2, fColuna(flxComposicao, "Cod."))
                Case CStr(0) ' Local ou PE
                    .CellForeColor = System.Drawing.Color.Blue
                Case CStr(1) ' Net
                    .CellForeColor = System.Drawing.ColorTranslator.FromOle(&HFF00FF)
                Case CStr(2)
                    .CellForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
                Case CStr(3)
                    .CellForeColor = System.Drawing.Color.Red
                Case Else
                    .CellForeColor = System.Drawing.Color.Black
            End Select

            .Focus()
            flxComposicao_RowColChange(flxComposicao, New System.EventArgs())
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Public Sub cmdExecutar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExecutar.Click

        On Error GoTo Erro
        Dim nPorta As Integer

        If Trim(ucVeiculo.TEXT) = "" Then
            MsgBox("Campo Veículo não esta Preenchido!", MsgBoxStyle.OkOnly, "Aviso")
            If UcVeiculo.Visible = True Then
                UcVeiculo.Focus()
            End If
            Exit Sub
        End If

        'If Trim(UcData.Text) = "" Then
        If UcData.DateTime = DateTime.MinValue Then
            MsgBox("Campo Data não esta Preenchido!", MsgBoxStyle.OkOnly, "Aviso")
            UcData.Focus()
            Exit Sub
        End If

        If Trim(ucPrograma.Text) = "" Then
            MsgBox("Campo Programa não esta Preencido!", MsgBoxStyle.OkOnly, "Aviso")
            If ucPrograma.Visible And ucPrograma.Enabled Then
                ucPrograma.Focus()
            End If
            Exit Sub
        End If


        'Call FDeletaPorta(
        nPorta = FPorta(asmxPorta, dtsPorta, 2, ucVeiculo.Text, UcData.Text, ucPrograma.Text)

        Select Case nPorta
            Case 1, 4
                Aviso("Existe Outro Usuário Ordenando esta Programação")
                GoTo Saida
            Case 2
                Aviso("Existe Outro Usuário Compondo Breaks para esta Programação")
                GoTo Saida
            Case 3
                Aviso("Existe Outro Usuário Pre-Ordenando o Roteiro")
                GoTo Saida
        End Select
        Me.Cursor = Cursors.WaitCursor
        dtsGrade = asmxGrade.spuCarregar_Grade(ucVeiculo.Text.ToString, UcData.Text, ucPrograma.Text.ToString)



        If dtsGrade.dtbGrade.Count = 0 Then
            MsgBox("Não existe Grade para este Veículo / Data / Programa ", MsgBoxStyle.OkOnly, "Break")
            tabOpcoes.Buttons("BREAK").Enabled = False

            Exit Sub
        End If

        Call LimpaInformacoes()
        Call CarregaDadosAlteracao()
        Me.asmxPorta.spuAtualizar(Me.dtsPorta)
        Call FrameHabilitaDesabilita(True)
        tabOpcoes.Buttons("BREAK").Enabled = True
        If ucVeiculo.Text = "004" Or ucVeiculo.Text = "001" Or ucVeiculo.Text = "076" Then
            tabOpcoes.Buttons("RODAPE").Visible = False
        Else
            tabOpcoes.Buttons("RODAPE").Visible = True
        End If

        Me.Cursor = Cursors.Default

Saida:
        Me.Cursor = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub FrameHabilitaDesabilita(ByRef bOpcao As Boolean)

        fraPropagar.Enabled = bOpcao
        fraExibicao.Enabled = bOpcao
        fraBreaks.Enabled = bOpcao
        If bOpcao = True Then
            cmdExecutar.Enabled = False
        Else
            cmdExecutar.Enabled = True
        End If

    End Sub

    Private Sub CmdFechar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdFechar.Click
        Dim Index As Short = CmdFechar.GetIndex(eventSender)
        picRodape.Visible = False
    End Sub

    Private Sub btnOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Close()
    End Sub


    Private Sub cmdSobe_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSobe.Click

        On Error GoTo Erro
        Dim aGuarda() As Object

        Dim nRow1, nRow2 As Short
        With flxComposicao
            ReDim aGuarda(.Cols - 1)
            nRow1 = .Row
            nRow2 = .Row - 1

            For nCont = 0 To .Cols - 1
                'UPGRADE_WARNING: Couldn't resolve default property of object aGuarda(nCont). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aGuarda(nCont) = .get_TextMatrix(nRow2, nCont)
            Next nCont

            For nCont = 0 To .Cols - 1
                .set_TextMatrix(nRow2, nCont, .get_TextMatrix(nRow1, nCont))
            Next nCont

            For nCont = 0 To .Cols - 1
                'UPGRADE_WARNING: Couldn't resolve default property of object aGuarda(nCont). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .set_TextMatrix(nRow1, nCont, aGuarda(nCont))
            Next nCont


            .Row = nRow1
            .Col = fColuna(flxComposicao, "tipo")
            Select Case .get_TextMatrix(nRow1, fColuna(flxComposicao, "Cod."))
                Case CStr(0) ' Local ou PE
                    .CellForeColor = System.Drawing.Color.Blue
                Case CStr(1) ' Net
                    .CellForeColor = System.Drawing.ColorTranslator.FromOle(&HFF00FF)
                Case CStr(2)
                    .CellForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
                Case CStr(3)
                    .CellForeColor = System.Drawing.Color.Red
                Case Else
                    .CellForeColor = System.Drawing.Color.Black
            End Select

            .Row = nRow2
            .Col = fColuna(flxComposicao, "tipo")

            Select Case .get_TextMatrix(nRow2, fColuna(flxComposicao, "Cod."))
                Case CStr(0) ' Local ou PE
                    .CellForeColor = System.Drawing.Color.Blue
                Case CStr(1) ' Net
                    .CellForeColor = System.Drawing.ColorTranslator.FromOle(&HFF00FF)
                Case CStr(2)
                    .CellForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
                Case CStr(3)
                    .CellForeColor = System.Drawing.Color.Red
                Case Else
                    .CellForeColor = System.Drawing.Color.Black
            End Select

            .Row = nRow2
            .Col = fColuna(flxComposicao, "tipo")
            .Focus()
            flxComposicao_RowColChange(flxComposicao, New System.EventArgs())
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub cmdUltimaData_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUltimaData.Click

        On Error GoTo Erro
        UcDataAte.Text = lblUltimaData.Text
Saida:
        Exit Sub
Erro:
        Resume Saida
    End Sub

    Private Sub cmdUsuario_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUsuario.Click
        frmRoteiro_Usuario.Show()
        frmRoteiro_Usuario.BringToFront()
    End Sub


    Private Sub flxComposicao_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxComposicao.ClickEvent
        On Error GoTo Erro
        Dim nBreak As Short
        Dim nFlag As Short

        Dim nCol As Short
        With flxComposicao
            nCol = .MouseCol
            If nCol = 0 Then
                If .Row > 0 Then
                    If Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))) <> "" Then
                        nBreak = Val(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break")))
                        nFlag = IIf(Val(.get_TextMatrix(.Row, fColuna(flxComposicao, "flag"))) = 0, 1, 0)
                        Call Marca_Desmarca(nBreak, nFlag)
                    End If
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

    Private Sub Marca_Desmarca(ByRef Par_Break As Short, ByRef Flag As Short)

        On Error GoTo Erro
        Dim nRow As Short

        With flxComposicao
            .Visible = False
            For nRow = 1 To .Rows - 1
                If Trim(.get_TextMatrix(nRow, fColuna(flxComposicao, "break"))) = Trim(CStr(Par_Break)) Then
                    .Row = nRow
                    .Col = fColuna(flxComposicao, "")
                    Select Case Flag
                        Case 0
                            .CellPicture = picDesmarcado.Image
                            .set_TextMatrix(nRow, fColuna(flxComposicao, "flag"), 0)
                        Case 1
                            .CellPicture = picMarcado.Image
                            .set_TextMatrix(nRow, fColuna(flxComposicao, "flag"), 1)
                    End Select
                End If
            Next nRow
        End With

Saida:
        flxComposicao.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub flxComposicao_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxComposicao.DblClick
        With flxComposicao
            If .get_TextMatrix(.Row, fColuna(flxComposicao, "Break")) <> "" Then
            End If
        End With
    End Sub

    Private Sub flxComposicao_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxComposicao.RowColChange
        On Error GoTo Erro
        With flxComposicao

            If Not .Visible Then
                GoTo Saida
            End If

            tabOpcoes.Buttons("FAIXA").Enabled = Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))) <> ""
            tabOpcoes.Buttons("ALTERAR").Enabled = Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))) <> ""
            tabOpcoes.Buttons("EXCLUIR").Enabled = Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))) <> ""
            tabOpcoes.Buttons("RODAPE").Enabled = Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))) <> ""

            If .Col = fColuna(flxComposicao, "tipo") And .get_TextMatrix(.Row - 1, fColuna(flxComposicao, "Break")) = .get_TextMatrix(.Row, fColuna(flxComposicao, "Break")) And .Row > 1 Then
                cmdSobe.Enabled = True
            Else
                cmdSobe.Enabled = False
            End If

            If .Row = .Rows - 1 Then
                cmdDesce.Enabled = False
            Else
                If .Col = fColuna(flxComposicao, "tipo") And .get_TextMatrix(.Row + 1, fColuna(flxComposicao, "Break")) = .get_TextMatrix(.Row, fColuna(flxComposicao, "Break")) And .Row < .Rows - 1 And Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))) <> "" Then
                    cmdDesce.Enabled = True
                Else
                    cmdDesce.Enabled = False
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

    Private Sub frmComposicaoBreaks_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        UcVeiculo.Focus()
    End Sub

    Private Sub frmComposicaoBreaks_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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

    Private Sub CarregaFaixaHoraria(ByRef oObj As System.Windows.Forms.ComboBox, Optional ByRef sSql As String = "")
        DtsFaixaHoraria = AsmxFaixaHoraria.spuCarregar()
        oObj.Items.Clear()
        For Each drw As MSAClass.AsmxFaixaHoraria.dtsFaixaHoraria.dtbFaixa_HorariaRow In dtsFaixaHoraria.dtbFaixa_Horaria.Rows
            oObj.Items.Add(Trim(drw.Nome_Faixa))
            VB6.SetItemData(oObj, oObj.Items.Count - 1, drw.Id_Faixa)

        Next

        If oObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple Then
            oObj.SelectedIndex = oObj.Items.Count - 1
        End If
Saida:
        Exit Sub
    End Sub
    Private Sub frmComposicaoBreaks_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)

        'AsmxPorta = New MSAClass.Porta.asmxPorta
        'AsmxBreak = New MSAClass.Break.asmxBreak
        'AsmxGrade = New MSAClass.Grade.asmxGrade
        'AsmxFaixaHoraria = New MSAClass.FaixaHoraria.asmxFaixaHoraria
        'AsmxPrograma = New MSAClass.Programa.asmxPrograma
        'AsmxRoteiro = New MSAClass.Roteiro.asmxRoteiro
        'AsmxParametro_Roteiro = New MSAClass.PARAMETRO_ROTEIRO.asmxParametro_Roteiro
        strUltimaData = DateTime.MinValue
        strUltimoVeiculo = ""
        strUltimoPrograma = ""

        On Error GoTo Erro
        Me.Top = 0
        Me.Left = 0

        ucVeiculo.Usuario = gsUsuario
        ucPrograma.Usuario = gsUsuario

        With fraBreaks
            .Width = VB6.TwipsToPixelsX(9915)
            .Height = VB6.TwipsToPixelsY(4300)
            .Top = VB6.TwipsToPixelsY(1900)
            .Left = VB6.TwipsToPixelsX(180)
            .Visible = False
            .Text = ""
        End With

        With fraProgramacao
            .Width = VB6.TwipsToPixelsX(9915)
            .Height = VB6.TwipsToPixelsY(4300)
            .Top = VB6.TwipsToPixelsY(1900)
            .Left = VB6.TwipsToPixelsX(180)
            .Visible = True
            .Text = ""
        End With

        With picRodape
            .Top = VB6.TwipsToPixelsY(2145)
            .Left = VB6.TwipsToPixelsX(2820)
            .Width = VB6.TwipsToPixelsX(5955)
            .Height = VB6.TwipsToPixelsY(1770)
        End With

        With picCritica
            .Top = VB6.TwipsToPixelsY(3060)
            .Left = VB6.TwipsToPixelsX(1755)
            .Width = VB6.TwipsToPixelsX(6900)
            .Height = VB6.TwipsToPixelsY(3885)
        End With

        Call ConfiguraGrid()
        Call CarregaFaixaHoraria(cboFaixaHoraria) '--01
        cboFaixaHoraria.SelectedIndex = -1 '--[01]

        If stipoAcesso = "C" Then
            TabOpcoes.Buttons("RODAPE").Visible = False
        End If

        fraProgramacao.Visible = True
        fraBreaks.Visible = False
        picBreaks.Visible = False
        fraProgramacao.BringToFront()


        UcVeiculo.Focus()
Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub

Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmComposicaoBreaks_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Call FDeletaPorta(2)
        Me.LimpaInformacoes()
        Me.Dispose()

    End Sub

    Private Sub lblComposicaoLocal_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs)
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        If Trim(lblComposicaoLocal.Text) <> "" Then
            ToolTip1.SetToolTip(lblComposicaoLocal, VB6.Format(StrZero(Int(CDbl(lblComposicaoLocal.Text) / 60), 2) & StrZero(CDbl(lblComposicaoLocal.Text) Mod 60, 2), "00:00"))
        End If
    End Sub

    Private Sub lblComposicaoNet_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs)
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        If Trim(lblComposicaoNet.Text) <> "" Then
            ToolTip1.SetToolTip(lblComposicaoNet, VB6.Format(StrZero(Int(CDbl(lblComposicaoNet.Text) / 60), 2) & StrZero(CDbl(lblComposicaoNet.Text) Mod 60, 2), "00:00"))
        End If
    End Sub

    Private Sub lblComposiçãoTotal_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs)
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        If Trim(lblComposiçãoTotal.Text) <> "" Then
            ToolTip1.SetToolTip(lblComposiçãoTotal, VB6.Format(StrZero(Int(CDbl(lblComposiçãoTotal.Text) / 60), 2) & StrZero(CDbl(lblComposiçãoTotal.Text) Mod 60, 2), "00:00"))
        End If
    End Sub

    Private Sub lblCritica_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs)
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = X
        MouseY = Y
    End Sub

    Private Sub lblCritica_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs)
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

    Private Sub lblDispoLocal_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs)
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        If Trim(lblDispoLocal.Text) <> "" Then
            ToolTip1.SetToolTip(lblDispoLocal, VB6.Format(StrZero(Int(CDbl(lblDispoLocal.Text) / 60), 2) & StrZero(CDbl(lblDispoLocal.Text) Mod 60, 2), "00:00"))
        End If
    End Sub

    Private Sub lblDispoNet_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs)
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        If Trim(lblDispoNet.Text) <> "" Then
            ToolTip1.SetToolTip(lblDispoNet, VB6.Format(StrZero(Int(CDbl(lblDispoNet.Text) / 60), 2) & StrZero(CDbl(lblDispoNet.Text) Mod 60, 2), "00:00"))
        End If
    End Sub


    Private Sub lblDispoTotal_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs)
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        If Trim(lblDispoTotal.Text) <> "" Then
            ToolTip1.SetToolTip(lblDispoTotal, VB6.Format(StrZero(Int(CDbl(lblDispoTotal.Text) / 60), 2) & StrZero(CDbl(lblDispoTotal.Text) Mod 60, 2), "00:00"))
        End If
    End Sub

    Private Sub lblRodape_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblRodape.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = X
        MouseY = Y
    End Sub

    Private Sub lblRodape_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblRodape.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        On Error GoTo Erro
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        Dim MaxTop As Short
        Dim MaxLeft As Short

        With picRodape
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

    Private Sub tabComposicao_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabComposicao.ClickEvent

        If tabComposicao.SelectedItem.Index = 1 Then
            fraProgramacao.Visible = True
            fraBreaks.Visible = False
            picBreaks.Visible = False
            fraProgramacao.BringToFront()
        Else
            fraProgramacao.Visible = False
            fraBreaks.Visible = True
            picBreaks.Visible = True
            flxComposicao_RowColChange(flxComposicao, New System.EventArgs())
            fraBreaks.BringToFront()
        End If
    End Sub

    Public Sub SomaComposicao()
        On Error GoTo Erro

        Dim nTotalNet As Long, nTotalLocal As Long

        lblComposicaoLocal.Text = ""
        lblComposicaoNet.Text = ""
        lblComposiçãoTotal.Text = ""

        With flxComposicao

            For nLin = 1 To .Rows - 1
                If Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Cod."))) = "1" Then
                    lblComposicaoNet.Text = CStr(Val(lblComposicaoNet.Text) + Val(.get_TextMatrix(nLin, fColuna(flxComposicao, "Duração"))))
                    lblComposiçãoTotal.Text = CStr(Val(lblComposiçãoTotal.Text) + Val(.get_TextMatrix(nLin, fColuna(flxComposicao, "Duração"))))
                ElseIf Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Cod."))) = "0" Then
                    lblComposicaoLocal.Text = CStr(Val(lblComposicaoLocal.Text) + Val(.get_TextMatrix(nLin, fColuna(flxComposicao, "Duração"))))
                    lblComposiçãoTotal.Text = CStr(Val(lblComposiçãoTotal.Text) + Val(.get_TextMatrix(nLin, fColuna(flxComposicao, "Duração"))))
                End If
            Next

            If Val(lblComposicaoLocal.Text) > Val(lblDispoLocal.Text) Then
                lblComposicaoLocal.ForeColor = System.Drawing.Color.Red
            Else
                lblComposicaoLocal.ForeColor = System.Drawing.SystemColors.Highlight
            End If

            If Val(lblComposicaoNet.Text) > Val(lblDispoNet.Text) Then
                lblComposicaoNet.ForeColor = System.Drawing.Color.Red
            Else
                lblComposicaoNet.ForeColor = System.Drawing.SystemColors.Highlight
            End If

            If Val(lblComposiçãoTotal.Text) > Val(lblDispoTotal.Text) Then
                lblComposiçãoTotal.ForeColor = System.Drawing.Color.Red
            Else
                lblComposiçãoTotal.ForeColor = System.Drawing.SystemColors.Highlight
            End If

        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Public Sub CordeFundo()
        Dim Cor, sBreakAnterior As String
        With flxComposicao
            sBreakAnterior = Trim(.get_TextMatrix(1, fColuna(flxComposicao, "Total")))
            Cor = CStr(&H80000005)
            .Visible = False

            For nLin = 1 To .Rows - 1
                If Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Break"))) = "" Then
                    Exit For
                End If
                If Trim(sBreakAnterior) <> Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Break"))) Then
                    If CDbl(Cor) = &H80000005 Then
                        Cor = CStr(&HE0E0E0)
                    Else
                        Cor = CStr(&H80000005)
                    End If
                    sBreakAnterior = Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Break")))
                End If

                .Row = nLin
                For nCont = 0 To .Cols - 1
                    .Col = nCont
                    .CellBackColor = System.Drawing.ColorTranslator.FromOle(CInt(Cor))
                Next
            Next
            .Visible = True
        End With
        Exit Sub
    End Sub

    Private Sub tabOpcoes_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.IToolbarEvents_ButtonClickEvent) Handles tabOpcoes.ButtonClick
        On Error GoTo Erro
        Dim nBreak As Short
        Dim bSelecionou As Boolean
        Dim nSequenciaFaixa As Short
        Dim sMens As String
        Dim bExcluir As Boolean
        Dim nLoop As Short
        Dim sMensagem As String
        bCancelar = False



        Select Case UCase(eventArgs.button.Key)

            Case "ALTERAR"
                With flxComposicao
                    nBreak = Val(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break")))
                    nSequenciaFaixa = Val(.get_TextMatrix(.Row, fColuna(flxComposicao, "Faixa")))
                    frmComposicao.Config()
                    frmComposicao.txtBreak.Text = CStr(nBreak)
                    frmComposicao.txtBreak.Enabled = False
                    frmComposicao.txtDuracao.Text = .get_TextMatrix(.Row, fColuna(flxComposicao, "Duração"))
                    frmComposicao.txtSequencia.Text = .get_TextMatrix(.Row, fColuna(flxComposicao, "Sequência"))
                    frmComposicao.txtHorario.Text = .get_TextMatrix(.Row, fColuna(flxComposicao, "Horário"))
                    frmComposicao.txtTitulo.Text = Trim(Mid(.get_TextMatrix(.Row, fColuna(flxComposicao, "Titulo")), 1, 20))
                    frmComposicao.txtRodape.Text = Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Rodape")))
                    frmComposicao.SelectedTipo = Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Tipo")))
                    frmComposicao.cmbTipo.Enabled = False
                    frmComposicao.SetaTipo()
                End With

                frmComposicao.chkAlteracao.CheckState = System.Windows.Forms.CheckState.Checked
                frmComposicao.ShowDialog()
                Call Totaliza(nBreak)
                Call SomaComposicao()
                Call CordeFundo()
                frmComposicao.Dispose()

            Case "EXCLUIR"
                With flxComposicao
                    '====================Exclusao do Intervalo
                    If .Col = fColuna(flxComposicao, "Tipo") Then
                        If Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))) <> "" Then
                            sMensagem = "Confirma a Exclusão do Intervalo " & flxComposicao.get_TextMatrix(.Row, fColuna(flxComposicao, "Tipo")).Trim & " do Break " & .get_TextMatrix(.Row, fColuna(flxComposicao, "Break")) & " ?"
                            If Not Aviso(sMensagem, MsgBoxStyle.YesNo, MsgBoxStyle.Question, "Atenção") Then
                                GoTo Saida
                            End If
                            Call ExcluiBreaK(.Row, fColuna(flxComposicao, "Tipo"))
                        End If
                    Else
                        '====================Exclusao do Break

                        bSelecionou = False
                        For nLoop = 1 To .Rows - 1
                            If Val(.get_TextMatrix(nLoop, fColuna(flxComposicao, "flag"))) = 1 Then
                                bSelecionou = True
                                Exit For
                            End If
                        Next nLoop
                        If Not bSelecionou Then
                            Aviso("Nenhum Break foi Selecionado para Exclusão")
                            GoTo Saida
                        End If
                        sMensagem = "Confirma a exclusão total dos Breaks Selecionados"
                        If Not Aviso(sMensagem, MsgBoxStyle.YesNo, MsgBoxStyle.Question, "Atenção") Then
                            GoTo Saida
                        End If
                        Do
                            bExcluir = False
                            For nLoop = 1 To .Rows - 1
                                sMensagem = "Confirma a Exclusão do Intervalo " & flxComposicao.get_TextMatrix(.Row, fColuna(flxComposicao, "Tipo")) & " do Break " & nBreak & " ?"
                                If Val(.get_TextMatrix(nLoop, fColuna(flxComposicao, "flag"))) = 1 Then
                                    Call ExcluiBreaK(nLoop, fColuna(flxComposicao, "Break"))
                                    If bCancelar Then
                                        Exit For
                                    Else
                                        bExcluir = True
                                    End If
                                End If
                            Next nLoop
                            If Not bExcluir Or bCancelar Then
                                Exit Do
                            End If
                        Loop
                    End If
                    chkMarcarTodos.CheckState = System.Windows.Forms.CheckState.Unchecked

                End With
            Case "BREAK"

                With flxComposicao
                    For nLin = .Rows - 1 To 0 Step -1
                        If Trim(.get_TextMatrix(nLin, fColuna(flxComposicao, "Break"))) <> "" Then
                            nBreak = Val(.get_TextMatrix(nLin, fColuna(flxComposicao, "Break"))) + 1
                            frmComposicao.txtBreak.Text = CStr(nBreak)
                            'frmComposicao.txtBreak.Enabled = False

                            If nLin = .Rows - 1 Then
                                .Rows = .Rows + 1
                            End If
                            .Row = nLin + 1
                            Exit For
                        End If
                    Next

                End With
                frmComposicao.Config()
                frmComposicao.SelectedTipo = Trim(flxComposicao.get_TextMatrix(nLin, fColuna(flxComposicao, "Tipo")))
                frmComposicao.cmbTipo.Enabled = True
                frmComposicao.chkNovoBreak.CheckState = System.Windows.Forms.CheckState.Checked
                frmComposicao.ShowDialog()
                With flxComposicao
                    For nLoop = 1 To .Rows - 1
                        If .get_TextMatrix(nLoop, fColuna(flxComposicao, "Break")) <> "" Then
                            Call Totaliza(CShort(.get_TextMatrix(nLoop, fColuna(flxComposicao, "Break"))))
                        End If
                    Next nLoop
                End With
                Call SomaComposicao()
                Call CordeFundo()
                frmComposicao.Dispose()
            Case "FAIXA"
7:

                With flxComposicao
                    If Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))) = "" Then
                        GoTo Saida
                    End If
                    nBreak = CShort(.get_TextMatrix(.Row, fColuna(flxComposicao, "Break")))
                    frmComposicao.txtBreak.Text = .get_TextMatrix(.Row, fColuna(flxComposicao, "Break"))
                    frmComposicao.txtBreak.Enabled = False
                    frmComposicao.cmbTipo.Enabled = True
                    frmComposicao.SelectedTipo = Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "Tipo")))
                    frmComposicao.txtTitulo.Text = Trim(.get_TextMatrix(.Row, fColuna(flxComposicao, "TituloOriginal")))
                    frmComposicao.txtSequencia.Text = .get_TextMatrix(.Row, fColuna(flxComposicao, "Sequência"))
                    frmComposicao.txtRodape.Text = .get_TextMatrix(.Row, fColuna(flxComposicao, "Rodape"))
                    frmComposicao.Config()
                    frmComposicao.chkNovaFaixa.CheckState = System.Windows.Forms.CheckState.Checked
                End With

                frmComposicao.ShowDialog()
                Call Totaliza(nBreak)
                Call SomaComposicao()
                Call CordeFundo()
                frmComposicao.Dispose()

            Case "RODAPE"

                picRodape.Visible = True
                picRodape.BringToFront()

        End Select

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Function FormataDuracao(ByRef Par_Duracao As Object) As String
        On Error GoTo Erro
        Dim nMinuto, nHora, nResto, nSegundo As Object

        Par_Duracao = VerNulo(Par_Duracao, 0)
        nHora = Int(Par_Duracao / 3600)
        nResto = Par_Duracao Mod 3600
        nMinuto = Int(nResto / 60)
        nSegundo = nResto Mod 60
        If nHora > 0 Then
            FormataDuracao = StrZero(nHora, 2) & ":" & StrZero(nMinuto, 2) & ":" & StrZero(nSegundo, 2)
        Else
            FormataDuracao = StrZero(nMinuto, 2) & ":" & StrZero(nSegundo, 2)
        End If

Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Resume Saida

    End Function

    Private Sub Totaliza(ByRef Par_Break As Short)

        On Error GoTo Erro
        Dim nDuracao As Long
        With flxComposicao
            .Visible = False
            For nCont = 1 To .Rows - 1
                If Val(.get_TextMatrix(nCont, fColuna(flxComposicao, "Break"))) = Par_Break Then
                    nDuracao = nDuracao + Val(.get_TextMatrix(nCont, fColuna(flxComposicao, "Duração")))
                End If
            Next nCont
            For nCont = 1 To .Rows - 1
                If Val(.get_TextMatrix(nCont, fColuna(flxComposicao, "Break"))) = Par_Break And Trim(.get_TextMatrix(nCont, fColuna(flxComposicao, "Break"))) <> "" Then
                    .set_TextMatrix(nCont, fColuna(flxComposicao, "Total"), FormataDuracao(nDuracao) & " (" & Par_Break & ")")
                End If
            Next nCont
        End With
Saida:
        flxComposicao.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
    End Sub

    Private Sub txtDispoLocal_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDispoLocal.Enter
        seleciona_no_foco(txtDispoLocal)
    End Sub

    Private Sub txtDispoLocal_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDispoLocal.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub txtDispoNet_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDispoNet.Enter
        seleciona_no_foco(txtDispoNet)
    End Sub

    Private Sub txtDispoNet_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDispoNet.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Function ExisteRoteiro(ByRef sVeiculo As String, ByRef sData As String, Optional ByRef sPrograma As String = "", Optional ByRef nBreak As Short = 0, Optional ByRef nSequenciaFaixa As Short = 0) As Boolean
        On Error GoTo Erro
        ExisteRoteiro = AsmxBreak.spuExisteRoteiro(ucVeiculo.Text, UcData.Text, ucPrograma.Text, nBreak, nSequenciaFaixa)
Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Function

    Private Sub UcPrograma_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If ucVeiculo.Text = "" Then
                Aviso("Código Veiculo não pode estar branco")
                ucVeiculo.Focus()
                Exit Sub
            End If
            If UcData.Text = "" Then
                Aviso("Data não pode estar branco")
                UcData.Focus()
                Exit Sub
            End If



        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        On Error GoTo Erro_ok
        Dim bSelect As Boolean

        bSelect = False
        For nCont = 0 To chkDiasSemana.Count - 1
            If chkDiasSemana(nCont).CheckState = CheckState.Checked Then
                bSelect = True
            End If
        Next nCont
        If Not bSelect Then
            Aviso("Nenhum Dia da Semana foi Selecionado")
            GoTo Saida
        End If
        If ucPrograma.Text.ToString.Trim = "" Then
            Aviso("Programa não pode ser vazio")
        End If

        ' Verifica Periodo
        If System.DateTime.FromOADate(CDate(UcDataAte.Text).ToOADate - CDate(UcDatade.Text).ToOADate) > System.DateTime.FromOADate(365) Then
            If Aviso("Periodo da Programação é muito longo. Confirma ? ", MsgBoxStyle.OkOnly, MsgBoxStyle.Question) = False Then
                GoTo Saida
            End If
        End If

        If Aviso("Confirma a atualização ? ", MsgBoxStyle.YesNo, MsgBoxStyle.Question) Then
            GravaBreak()
        End If

Saida:
        Me.Cursor = Cursors.Default
        Exit Sub
Erro_ok:

        Resume Saida
        Resume

    End Sub

    Private Sub UcVeiculo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucVeiculo.Validated
        Try
            If ucVeiculo.Text <> strUltimoVeiculo Then
                Me.LimpaInformacoes()
                FrameHabilitaDesabilita(False)
                strUltimoVeiculo = ucVeiculo.Text
            End If

            If ucVeiculo.Text.Trim <> "" Then
                dtsParametro_Roteiro = asmxParametro_Roteiro.spuCarregar(ucVeiculo.Text)
                frmComposicao.CarregaTipoIntervalo()
                FrameHabilitaDesabilita(False)
            End If


        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub ucPrograma_Enter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucPrograma.Enter
        Try
            ucPrograma.Veiculo = ucVeiculo.Text
            If UcData.Ano > 1 Then
                ucPrograma.DataInicio = UcData.DateTime
                ucPrograma.DataFim = UcData.DateTime
            Else
                ucPrograma.DataInicio = Nothing
                ucPrograma.DataFim = Nothing
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub UcData_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcData.Validated
        If UcData.DateTime <> strUltimaData Then
            LimpaInformacoes()
            FrameHabilitaDesabilita(False)
            strUltimaData = UcData.DateTime
        End If

    End Sub

    Private Sub ucPrograma_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucPrograma.Validated
        If ucPrograma.Text <> strUltimoPrograma Then
            Me.LimpaInformacoes()
            FrameHabilitaDesabilita(False)
            strUltimoPrograma = ucPrograma.Text
        End If
    End Sub

    Private Sub frmComposicaoBreaks_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        asmxPorta.spuLimpar(2, gsUsuario)
    End Sub
End Class
