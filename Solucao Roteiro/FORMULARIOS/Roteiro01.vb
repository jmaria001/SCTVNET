Option Strict Off
Option Explicit On
Friend Class frmRoteiro_Consulta
    Inherits System.Windows.Forms.Form
    Dim DtsRoteiro_Consulta_Veiculacao As New MSAClass.AsmxRoteiro.dtsRoteiro_Consulta_Veiculacao
    Dim AsmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro
	
	
	Private Sub ConfiguraGrid()
		With flxConfirmacao
			.Visible = False
			.Clear()
			.FormatString = "Programa|Break|Tipo|Pos.|Ch.Acesso|Empresa|Contrato|Seq|Comercial|Produto|Dur.|T.Com|Qual.|Horario|Docto De|Docto Para|Programa Ordenado"
			.Rows = 20
			.Row = 0
			.ScrollTrack = True
			.FixedCols = 0
			.HighLight = MSFlexGridLib.HighLightSettings.flexHighlightAlways
			.SelectionMode = MSFlexGridLib.SelectionModeSettings.flexSelectionByRow
			.FocusRect = MSFlexGridLib.FocusRectSettings.flexFocusNone
			.AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
			.BackColorBkg = System.Drawing.Color.White
			
			.set_ColWidth(0, 765)
			.set_ColWidth(1, 510)
			.set_ColWidth(2, 585)
			.set_ColWidth(3, 375)
			.set_ColWidth(4, 855)
			.set_ColWidth(5, 705)
			.set_ColWidth(6, 825)
			.set_ColWidth(7, 435)
			.set_ColWidth(8, 2520)
			.set_ColWidth(9, 2445)
			.set_ColWidth(10, 435)
			.set_ColWidth(11, 660)
			.set_ColWidth(12, 630)
			.set_ColWidth(13, 780)
			.set_ColWidth(14, 1095)
			.set_ColWidth(15, 1140)
			.set_ColWidth(16, 1515)
			
			
			For nCont = 0 To .Cols - 1
				.set_ColAlignment(nCont, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
			Next nCont
			
			.Row = 1
			.Col = 0
			.set_RowHeight(0, 300)
			.WordWrap = False
			.Row = 1
			.Col = 0
			.ColSel = .Cols - 1
			.Visible = True
			
		End With
		
	End Sub
	
    Private Sub Carrega_Comerciais()
        Dim nBaixado As Short
        Dim nOrdenado As Short


        Dim aTipoGrade(2) As Object
        aTipoGrade(0) = "Net"
        aTipoGrade(1) = "Rede"
        aTipoGrade(2) = "Local"

        On Error GoTo Erro_Carrega_Comerciais

        If Trim(ucVeiculo.Text) = "" Then
            Aviso("Campo Veículo não pode ser em Branco !")
            ucVeiculo.Focus()
            Exit Sub
        End If

        If Trim(dteData.Text) = "" Then
            Aviso("Campo Data não pode ser em Branco !")
            dteData.Focus()
            Exit Sub
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Mensagem("Selecionando Comerciais...Aguarde !!! ")



        Select Case True
            Case optSim.Checked
        End Select

        Select Case True
            Case chkBaixados.Checked = True
                nBaixado = 0
            Case chkNBaixados.Checked = True
                nBaixado = 1
            Case Else
                nBaixado = -1
        End Select

        Select Case True
            Case chkOrdenados.Checked = True
                nOrdenado = 0
            Case chkNOrdenados.Checked = True
                nOrdenado = 1
            Case Else
                nOrdenado = -1
        End Select

        ConfiguraGrid()

        Me.DtsRoteiro_Consulta_Veiculacao = Me.AsmxRoteiro.spuCarregar_ConsultaVeiculacao(ucVeiculo.Text.Trim, dteData.Text, ucPrograma.Text.Trim, ucQualidade.Text, -1, nBaixado, nOrdenado)

        nLin = 1
        With flxConfirmacao
            .Visible = False
            For Each DRW As MSAClass.AsmxRoteiro.dtsRoteiro_Consulta_Veiculacao.dtbRoteiro_Consulta_VeiculacaoRow In DtsRoteiro_Consulta_Veiculacao.dtbRoteiro_Consulta_Veiculacao.Select()
                If nLin >= .Rows Then
                    flxConfirmacao.Rows = nLin + 1
                End If


                If Not DRW.IsCod_ProgramaNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "programa"), DRW.Cod_Programa.ToString())
                End If

                If Not DRW.IsBreaksNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Break"), DRW.Breaks.ToString())
                End If

                If Not DRW.Issequencia_intervaloNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Pos."), Vernulo(DRW.sequencia_intervalo, ""))
                End If

                If Not DRW.IsIndica_GradeNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Tipo"), aTipoGrade(DRW.Indica_Grade))
                End If

                If Not DRW.IsChave_AcessoNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Ch.Acesso"), DRW.Chave_Acesso)
                End If

                If Not DRW.IsCod_EmpresaNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Empresa"), DRW.Cod_Empresa)
                End If

                If Not DRW.IsNumero_MrNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Contrato"), DRW.Numero_Mr)
                End If

                If Not DRW.IsSequencia_MrNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Seq"), DRW.Sequencia_Mr)
                End If

                If Not DRW.IsTitulo_ComercialNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Comercial"), DRW.Cod_Comercial & "-" & FirstCaps(Trim(DRW.Titulo_Comercial)))
                End If

                If Not DRW.IsCod_ComercialNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Produto"), FirstCaps(Trim(DRW.Nome_Produto)))
                End If

                If Not DRW.IsDuracaoNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Dur."), DRW.Duracao)
                End If

                If Not DRW.IsCod_Tipo_ComercialNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "T.Com"), DRW.Cod_Tipo_Comercial)
                End If

                If Not DRW.IsCod_QualidadeNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Qual."), Vernulo(DRW.Cod_Qualidade, ""))
                End If

                If Not DRW.Ishorario_exibicaoNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Horario"), Mid(Vernulo(VB6.Format(DRW.horario_exibicao, "dd-mm-yyyy hh:mm:ss"), ""), 12, 8))
                End If

                If Not DRW.IsDocumento_DeNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Docto De"), Vernulo(DRW.Documento_De, ""))
                End If

                If Not DRW.IsDocumento_ParaNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Docto Para"), Vernulo(DRW.Documento_Para, ""))
                End If

                If Not DRW.IsCod_Programa_OrdenadoNull Then
                    .set_TextMatrix(nLin, fColuna(flxConfirmacao, "Programa Ordenado"), Vernulo(DRW.Cod_Programa_Ordenado, ""))
                End If

                nLin = nLin + 1

            Next
            .Visible = True
            .Row = 1
            .Col = 0
            .ColSel = .Cols - 1

        End With

        Call SeparaPrograma()

Saida:
        flxConfirmacao.Visible = True
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro_Carrega_Comerciais:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub SeparaPrograma()
		On Error GoTo Erro
		Dim nRow As Short
		Dim nCol As Short
		Dim sProgramaAnterior As String
		sProgramaAnterior = ""
		With flxConfirmacao
			.Visible = False
			For nRow = .Rows - 1 To 1 Step -1
				If sProgramaAnterior <> Trim(.get_TextMatrix(nRow, fColuna(flxConfirmacao, "programa"))) Then
					sProgramaAnterior = Trim(.get_TextMatrix(nRow, fColuna(flxConfirmacao, "programa")))
					.AddItem("                         #", nRow + 1)
				End If
			Next nRow
			
			For nRow = 1 To .Rows - 1
				If Trim(.get_TextMatrix(nRow, fColuna(flxConfirmacao, "programa"))) = "#" Then
					.set_RowHeight(nRow, 30)
					.Row = nRow
					For nCol = 0 To .Cols - 1
						.Col = nCol
						.CellBackColor = .BackColorSel
					Next nCol
				Else
					.set_RowHeight(nRow, 300)
				End If
			Next nRow
			.Row = 1
			.Col = 0
			.ColSel = .Cols - 1
			
		End With
		
Saida: 
		flxConfirmacao.Visible = True
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
	End Sub
	
    Private Sub chkBaixados_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkBaixados.CheckStateChanged
        If chkBaixados.CheckState = 1 Then
            chkNBaixados.Enabled = False
        Else
            chkNBaixados.Enabled = True
        End If
    End Sub
	
    Private Sub chkNBaixados_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNBaixados.CheckStateChanged
        If chkNBaixados.CheckState = 1 Then
            chkBaixados.Enabled = False
        Else
            chkBaixados.Enabled = True
        End If
    End Sub
	
    Private Sub chkNOrdenados_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNOrdenados.CheckStateChanged
        If chkNOrdenados.CheckState = 1 Then
            chkOrdenados.Enabled = False
        Else
            chkOrdenados.Enabled = True
        End If
    End Sub
	
    Private Sub chkOrdenados_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkOrdenados.CheckStateChanged
        If chkOrdenados.CheckState = 1 Then
            chkNOrdenados.Enabled = False
        Else
            chkNOrdenados.Enabled = True
        End If
    End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
        Me.Dispose()
	End Sub
	
	Private Sub cmdExibir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExibir.Click

		Call Carrega_Comerciais()
	End Sub
	


    Private Sub flxConfirmacao_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxConfirmacao.DblClick

        With flxConfirmacao
            .Row = .MouseRow
            .Col = .MouseCol
            .ColSel = .Cols - 1
            If .Col = fColuna(flxConfirmacao, "Docto De") Or .Col = fColuna(flxConfirmacao, "Docto Para") Then
                If Trim(.get_TextMatrix(.Row, .Col)) <> "" Then

                    Me.Cursor = Cursors.WaitCursor
                    frmDadosAm.txtEmpresa.Text = .get_TextMatrix(.Row, fColuna(flxConfirmacao, "Empresa"))
                    frmDadosAm.txtContrato.Text = .get_TextMatrix(.Row, fColuna(flxConfirmacao, "Contrato"))
                    frmDadosAm.txtSequencia.Text = .get_TextMatrix(.Row, fColuna(flxConfirmacao, "Seq"))
                    frmDadosAm.txtNumeroAM.Text = .get_TextMatrix(.Row, .Col)

                    frmDadosAm.ShowDialog()
                    Me.Cursor = Cursors.Default
                End If
            End If
        End With
    End Sub
	
	Private Sub flxConfirmacao_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxConfirmacao.MouseDownEvent
		On Error GoTo Erro
		Dim nRow As Short
		Dim nGuardaColuna As Short
		If eventArgs.Button = 2 And flxConfirmacao.MouseRow = 0 Then
			With Me.flxConfirmacao
				.Col = .MouseCol
				nGuardaColuna = .Col
				.Focus()
				frmOpcoesGrid.txtColunaAtual.Text = CStr(.Col)
                frmOpcoesGrid.Dispose()

				'====================Se Coluna Ordenada for diferente de Programa, remove separadores de linha
				.Visible = False
				For nRow = .Rows - 1 To 1 Step -1
					If Trim(.get_TextMatrix(nRow, fColuna(flxConfirmacao, "programa"))) = "#" Then
						.RemoveItem(nRow)
					End If
				Next nRow
				
				
				If nGuardaColuna = fColuna(flxConfirmacao, "programa") Then
					Call SeparaPrograma()
				End If
				.Row = 1
				.Col = 0
				.ColSel = .Cols - 1
			End With
		End If
Saida: 
		flxConfirmacao.Visible = True
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
		
	End Sub
	
	
	Private Sub frmRoteiro_Consulta_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
	
    Private Sub frmRoteiro_Consulta_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.AsmxRoteiro = NewRoteiro()
        ConfiguraGrid()
Saída:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro_Load:
        Erro(Err.Number)
        Resume Saída
        Resume

    End Sub
	
    Private Sub txtQualidade_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    End Sub
    Private Sub Frame3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Frame3.Enter
    End Sub

    Private Sub _lblCampos_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _lblCampos_2.Click

    End Sub

    Private Sub UcPrograma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkOrdenados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOrdenados.CheckedChanged

    End Sub

    Private Sub chkNOrdenados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNOrdenados.CheckedChanged

    End Sub

    Private Sub flxConfirmacao_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flxConfirmacao.Enter

    End Sub

    Private Sub UcVeiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dteData_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dteData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteData.Load

    End Sub
End Class