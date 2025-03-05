Option Strict Off
Option Explicit On
Friend Class frmComposicao
	Inherits System.Windows.Forms.Form
	Dim bUsuarioArtisticoCabeca, bUsuarioComercialCabeca As Boolean
	Dim bUsuarioArtisticoLink, bUsuarioComercialLink As Boolean
	
    Dim nLinhaArtistico As Short
	Dim nLinhaLocal As Short
	Dim nLinhaPe As Short
    Dim nLinhaNet As Short
    Dim strSelectedTipo As String
    Dim asmxParametro_Roteiro As MSAClass.AsmxParametro_Roteiro.asmxParametro_Roteiro = NewParametro_Roteiro()
    Dim dtsParametro_Roteiro As New MSAClass.AsmxParametro_Roteiro.dtsParametro_Roteiro

    Private Sub chkNovaFaixa_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNovaFaixa.CheckStateChanged
        On Error GoTo Erro
        Dim nRow As Short
        Dim nPrimeiraLinha As Short
        Dim nUltimaLinha As Short

        optAcima.Visible = True
        optAbaixo.Visible = True
        optAbaixo.Checked = True

        Dim bExisteArtistico As Boolean
        Dim bExistePe As Boolean
        Dim bExisteLocal As Boolean
        Dim bExisteNet As Boolean



        With frmComposicaoBreaks.flxComposicao
            nPrimeiraLinha = .Row
            For nRow = .Row To 1 Step -1
                If .get_TextMatrix(nRow, fColuna((frmComposicaoBreaks.flxComposicao), "Break")) <> txtBreak.Text Then
                    Exit For
                End If
                nPrimeiraLinha = nRow
            Next nRow
            nUltimaLinha = .Row
            For nRow = .Row To .Rows - 1
                If .get_TextMatrix(nRow, fColuna((frmComposicaoBreaks.flxComposicao), "Break")) <> txtBreak.Text Then
                    Exit For
                End If
                nUltimaLinha = nRow
            Next nRow
            For nRow = nPrimeiraLinha To nUltimaLinha
                Select Case .get_TextMatrix(nRow, fColuna((frmComposicaoBreaks.flxComposicao), "Cod."))
                    Case "0"
                        bExisteLocal = True
                    Case "1"
                        bExisteNet = True
                    Case "2"
                        bExisteArtistico = 1
                    Case "3"
                        bExistePe = True
                End Select
            Next nRow
        End With

        Select Case False
            Case bExisteArtistico
                cmbTipo.SelectedIndex = nLinhaArtistico
            Case bExisteLocal
                cmbTipo.SelectedIndex = nLinhaLocal
            Case bExisteNet
                cmbTipo.SelectedIndex = nLinhaNet
            Case bExistePe
                cmbTipo.SelectedIndex = nLinhaPe
        End Select

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	


	Private Sub chkNovoBreak_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNovoBreak.CheckStateChanged
		
		If cmbTipo.Items.Count > 0 Then
			cmbTipo.SelectedIndex = 0
        Else
            Select Case frmComposicaoBreaks.ucVeiculo.Text.Trim()
                Case "004", "001", "076"
                    cmbTipo.SelectedIndex = nLinhaArtistico
                    cmbTipo.Enabled = False
                    txtDuracao.Text = CStr(5)
                Case Else
            End Select
        End If
    End Sub
	
	Private Sub cmdAplicar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAplicar.Click
		
		On Error GoTo Erro
		Dim nFaixa As Short
        Dim nDuracaoTotal As Long


        If stipoAcesso = "A" And cmbTipo.SelectedIndex = 1 Then
            Aviso("Intervalo Net somente é permitido para programas da cabeça de rêde")
            GoTo Saida
        End If
		
		If Trim(txtBreak.Text) = "" Then
			Aviso("Break não pode ser em branco")
            GoTo saida
		End If
		
		If Trim(txtDuracao.Text) = "" Then
			Aviso("Campo Duração não pode ser em Branco !")
            GoTo Saida
		End If
		
        If cmbTipo.Text = "" Then
            Aviso("Campo Tipo não pode ser em Branco !")
            GoTo saida
        End If
		
		
		With frmComposicaoBreaks.flxComposicao
			.Visible = False
            If chkNovoBreak.CheckState = CheckState.Checked Or chkNovaFaixa.CheckState = CheckState.Checked Then
                nFaixa = 0
                For nCont = 1 To .Rows - 1
                    If nFaixa <= Val(.get_TextMatrix(nCont, fColuna((frmComposicaoBreaks.flxComposicao), "Faixa"))) Then
                        nFaixa = Val(.get_TextMatrix(nCont, fColuna((frmComposicaoBreaks.flxComposicao), "Faixa")))
                    End If
                Next nCont
                nFaixa = nFaixa + 1
            Else
                nFaixa = CShort(.get_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Faixa")))
            End If
			
			'If chkNovoBreak.Value = 1 Or chkNovaFaixa.Value = 1 Then
			'   nFaixa = CalculaSequenciaFaixa(frmComposicaoBreaks.txtVeiculo, _
			''                                  frmComposicaoBreaks.txtData, _
			''                                  frmComposicaoBreaks.txtCodigoPrograma)
			
			
            If chkNovaFaixa.CheckState = CheckState.Checked Then
                If optAcima.Checked Then
                    .AddItem("", .Row)
                Else
                    .AddItem("", .Row + 1)
                    .Row = .Row + 1
                End If
            End If
			
			.Col = fColuna((frmComposicaoBreaks.flxComposicao), "Total")
			.CellForeColor = System.Drawing.Color.Blue
			.CellFontSize = 10
			
			.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), ""), Space(50) & txtBreak.Text)
			.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Break"), txtBreak.Text)
			.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Sequência"), IIf(Trim(txtSequencia.Text) <> "", txtSequencia.Text, " "))
			
			If txtTitulo.Text <> "" Then
				.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Titulo"), Trim(txtTitulo.Text))
			Else
                .set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Titulo"), Trim(frmComposicaoBreaks.UcPrograma.Descricao))
			End If
			.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Tipo"), cmbTipo.Text)
            .set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Duração"), txtDuracao.Text)
            .set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Horário"), txtHorario.Text)
			.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Faixa"), nFaixa)
			.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Rodape"), txtRodape.Text)
			.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "TituloOriginal"), txtTitulo.Text)
			.set_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Cod."), cmbTipo.SelectedIndex)
			
			.Col = fColuna((frmComposicaoBreaks.flxComposicao), "")
			.CellPicture = frmComposicaoBreaks.picDesmarcado.Image
			.CellPictureAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
			
			.Col = fColuna((frmComposicaoBreaks.flxComposicao), "Tipo")
			Select Case .get_TextMatrix(.Row, fColuna((frmComposicaoBreaks.flxComposicao), "Cod."))
				Case CStr(0) ' Local
					.CellForeColor = System.Drawing.Color.Blue
				Case CStr(1) ' Net
					.CellForeColor = System.Drawing.ColorTranslator.FromOle(&HFF00FF)
				Case CStr(2) ' Artistico
					.CellForeColor = System.Drawing.ColorTranslator.FromOle(&H8000)
				Case CStr(3) ' Pe
					.CellForeColor = System.Drawing.Color.Red
				Case Else
					.CellForeColor = System.Drawing.Color.Black
			End Select
			
			
			
			If chkAlteracao.CheckState = 1 Then
				For nCont = 1 To .Rows - 1
					If .get_TextMatrix(nCont, fColuna((frmComposicaoBreaks.flxComposicao), "Break")) = txtBreak.Text Then
						.set_TextMatrix(nCont, fColuna((frmComposicaoBreaks.flxComposicao), "Sequência"), IIf(Trim(txtSequencia.Text) <> "", txtSequencia.Text, " "))
						.set_TextMatrix(nCont, fColuna((frmComposicaoBreaks.flxComposicao), "Titulo"), Trim(txtTitulo.Text))
						.set_TextMatrix(nCont, fColuna((frmComposicaoBreaks.flxComposicao), "TituloOriginal"), Trim(txtTitulo.Text))
						.set_TextMatrix(nCont, fColuna((frmComposicaoBreaks.flxComposicao), "Rodape"), txtRodape.Text)
					End If
				Next nCont
			End If
			.Visible = True
        End With
        frmComposicaoBreaks.flxComposicao.Visible = True
        cmdSair_Click(cmdSair, New System.EventArgs())

		
Saida: 

		Exit Sub
Erro: 
		Erro(Err.Number)
		GoTo Saida
		Resume 
	End Sub
	
	
	Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Close()
	End Sub
	
    Public Sub CarregaTipoIntervalo()
        On Error GoTo Erro

        cmbTipo.Items.Clear()


        For Each drw As MSAClass.AsmxParametro_Roteiro.dtsParametro_Roteiro.dtbParametro_RoteiroRow In frmComposicaoBreaks.dtsParametro_Roteiro.dtbParametro_Roteiro.Rows
            cmbTipo.Items.Add(drw.Descricao)
            Select Case drw.Cod_Tipo_Intervalo
                Case 0
                    nLinhaLocal = cmbTipo.Items.Count - 1
                Case 1
                    nLinhaNet = cmbTipo.Items.Count - 1
                Case 2
                    nLinhaArtistico = cmbTipo.Items.Count - 1
                Case 3
                    nLinhaPe = cmbTipo.Items.Count - 1
            End Select

        Next







Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub

    Private Sub frmComposicao_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated


    End Sub
	
	Private Sub frmComposicao_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		If KeyAscii = 13 Then
			System.Windows.Forms.SendKeys.Send("{tab}")
		ElseIf KeyAscii = 39 Then 
			KeyAscii = 0
		Else
			KeyAscii = Asc(UCase(Chr(KeyAscii)))
		End If
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
    Private Sub frmComposicao_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Config()
    End Sub
    Public Sub Config()

        Dim intLoop As Int32
        Try

            asmxParametro_Roteiro = NewParametro_Roteiro()
            Me.Top = VB6.TwipsToPixelsY(2505)
            Me.Left = VB6.TwipsToPixelsX(2175)
            nLinhaArtistico = -1
            nLinhaNet = -1
            nLinhaLocal = -1
            nLinhaPe = -1

            Call CarregaTipoIntervalo()

            For intLoop = 0 To cmbTipo.Items.Count - 1
                If Trim(cmbTipo.Items(intLoop)) = strSelectedTipo Then
                    cmbTipo.SelectedIndex = intLoop
                    cmbTipo.Refresh()
                    Exit For
                End If
            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Public Sub SetaTipo()
        Try
            With cmbTipo
                For x As Integer = 0 To .Items.Count - 1
                    If .Items(x).ToString.Trim.ToUpper = Me.SelectedTipo.Trim.ToUpper Then
                        .SelectedIndex = x
                    End If
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
	
	Private Sub txtBreak_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBreak.Enter
		seleciona_no_foco(txtBreak)
	End Sub
	
	Private Sub txtBreak_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtBreak.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtBreak_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtBreak.Validating
		Dim Cancel As Boolean = eventArgs.Cancel
		On Error GoTo Erro
		Dim nLoop As Short
		txtBreak.Text = Trim(txtBreak.Text)
		If txtBreak.Text = "" Then
			GoTo Saida
		End If
		
		
		With frmComposicaoBreaks.flxComposicao
			For nLoop = 0 To .Rows - 1
				If .get_TextMatrix(nLoop, fColuna((frmComposicaoBreaks.flxComposicao), "Break")) = txtBreak.Text Then
					Aviso("Break já Existente")
					Cancel = True
					GoTo Saida
				End If
			Next nLoop
			'If chkNovoBreak.Value = vbChecked And Trim(txtTitulo) = "" And txtBreak = "0" Then
			'txtTitulo = "Inter Programa"
			'End If
		End With
		
Saida: 
		GoTo EventExitSub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
EventExitSub: 
		eventArgs.Cancel = Cancel
	End Sub
	
	
	Private Sub txtDuracao_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDuracao.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtSequencia_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSequencia.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 32 Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
    End Sub

    Private Sub txtHorario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHorario.KeyPress
        If ((Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 58) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHorario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHorario.Validating
        Dim nLoop As Integer

        If txtHorario.Text.Trim = "" Then Exit Sub
        txtHorario.Text = formataHora(txtHorario.Text.Trim)
        If Not isTime(txtHorario.Text) Then
            Aviso("Horário do Break Inválido")
            e.Cancel = True
            Exit Sub
        End If

        With frmComposicaoBreaks.flxComposicao
            For nLoop = 0 To .Rows - 1
                If .get_TextMatrix(nLoop, fColuna(frmComposicaoBreaks.flxComposicao, "Horário")) = txtHorario.Text Then
                    Aviso("Horário do Break já Existente")
                    e.Cancel = True
                    Exit Sub
                End If
            Next nLoop
        End With

    End Sub

    Property SelectedTipo() As String
        Get
            Return strSelectedTipo
        End Get
        Set(ByVal value As String)
            strSelectedTipo = value
        End Set
    End Property

End Class