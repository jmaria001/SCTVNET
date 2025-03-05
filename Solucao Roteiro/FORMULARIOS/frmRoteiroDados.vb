Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmRoteiroDados
    Inherits System.Windows.Forms.Form
    Dim asmxControleFita As MSAClass.AsmxControleFita.asmxControleFita = NewControleFita()
    Dim dtsDadosFita As New MSAClass.AsmxControleFita.dtsDadosFita
    Dim dtsControleFita As New MSAClass.AsmxControleFita.dtsControleFita



	Private Sub chkArtistico_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkArtistico.CheckStateChanged
        Call MostraDadosDepositorioArtistico()
	End Sub
	
    Private Sub chkAvulso_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAvulso.CheckStateChanged
        Call MostraDadosDepositorioAvulso()
    End Sub

    Private Sub chkMidia_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMidia.CheckStateChanged
        Call MostraDadosMidia()
        If mdiPrincipal.DtsUsuario.dtbUsuario_Veiculo.Select("cod_veiculo = '" & txtVeiculo.Text & "'").Length > 0 And chkAlterarNumero.Checked Then
            txtNumeroFita.Enabled = True
            txtNumeroFita.ReadOnly = False
        Else
            txtNumeroFita.Enabled = False
            txtNumeroFita.ReadOnly = True
        End If
        txtNumeroFita.Text = Trim(txtNumeroFita.Text)
        txtNumeroFita.Tag = txtNumeroFita.Text
        cmdOk.Enabled = False
        chkMidia.Checked = True
    End Sub
	
	Private Sub MostraDadosMidia()
		
        On Error GoTo Erro
        Me.AsmxControleFita = Nothing
        Me.asmxControleFita = NewControleFita()
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaComercialRow
        DtsDadosFita = Me.AsmxControleFita.spuDadosComercial(txtVeiculo.Text, DateTime.Parse(txtData.Text), txtPrograma.Text, Short.Parse(txtChaveAcesso.Text))
        If DtsDadosFita.dtbDadosFitaComercial.Count > 0 Then
            drw = DtsDadosFita.dtbDadosFitaComercial.Rows(0)
            txtCliente.Text = drw.Cod_CLiente.ToString()
            txtAgencia.Text = drw.Cod_Agencia & " - " & drw.Nome_Agencia
            txtProduto.Text = drw.Cod_Red_Produto.ToString.Trim & " - " & drw.Descricao_Produto.Trim
            txtCodigoComercial.Text = drw.Cod_Comercial.Trim
            txtTitulo.Text = drw.Titulo_Comercial.Trim
            txtTipoComercial.Text = drw.Cod_Tipo_Comercial.Trim & " - " & drw.Descricao_Tipo_Comercial.Trim
            txtDuracao.Text = drw.Duracao.ToString.Trim
            txtEmpresa.Text = drw.Cod_Empresa.Trim
            txtContrato.Text = drw.Numero_Mr.ToString.Trim
            txtSequencia.Text = drw.Sequencia_Mr.ToString.Trim
            txtFormaPagamento.Text = drw.Forma_Pgto.ToString.Trim
            txtPatrocinio.Text = drw.Patrocinio.ToString.Trim
            txtCompensacao.Text = drw.Compensacao.ToString.Trim
            If Not drw.IsObs_RoteiroNull Then txtObservacao.Text = drw.Obs_Roteiro.Trim
            txtCliente.Tag = drw.Cod_CLiente
            txtAgencia.Tag = drw.Cod_Agencia
            txtProduto.Tag = drw.Cod_Red_Produto
            txtTitulo.Tag = drw.Titulo_Comercial
            txtTipoComercial.Tag = drw.Cod_Tipo_Comercial
        End If
Saida:
        System.Windows.Forms.Cursor.Current = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
    Private Sub MostraDadosDepositorioAvulso()
        On Error GoTo Erro
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaAvulsoRow
        DtsDadosFita = Me.AsmxControleFita.spuDadosComercialAvulso(txtVeiculo.Text, Integer.Parse(txtIdFita.Text))
        If DtsDadosFita.dtbDadosFitaAvulso.Count > 0 Then
            drw = DtsDadosFita.dtbDadosFitaAvulso.Rows(0)
            If Not drw.IsCod_Red_ProdutoNull Then txtProduto.Text = drw.Cod_Red_Produto.ToString.Trim & " - " & drw.Descricao_Produto
            txtTitulo.Text = drw.Titulo_Comercial
            txtTipoComercial.Text = drw.Cod_Tipo_Comercial & " - " & drw.Descricao_Tipo_Comercial
            txtNumeroFita.Text = drw.Numero_Fita
            txtDuracao.Text = drw.Duracao
            If Not drw.IsObservacaoNull Then txtObservacao.Text = drw.Observacao
        End If
Saida:
        System.Windows.Forms.Cursor.Current = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
    Private Sub MostraDadosDepositorioArtistico()
        On Error GoTo Erro
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaArtisticoRow
        DtsDadosFita = Me.AsmxControleFita.spuDadosComercialArtistico(txtVeiculo.Text, Integer.Parse(txtIdFita.Text))
        If DtsDadosFita.dtbDadosFitaArtistico.Count > 0 Then
            drw = DtsDadosFita.dtbDadosFitaArtistico.Rows(0)
            If Not drw.IsCod_Red_ProdutoNull Then txtProduto.Text = drw.Cod_Red_Produto.ToString.Trim & " - " & drw.Descricao_Produto
            txtTitulo.Text = drw.Titulo_Comercial
            txtTipoComercial.Text = drw.Cod_Tipo_Comercial & " - " & drw.Descricao_Tipo_Comercial
            txtNumeroFita.Text = drw.Numero_Fita
            txtDuracao.Text = drw.Duracao
            If Not drw.IsObservacaoNull Then txtObservacao.Text = drw.Observacao
        End If
Saida:
        System.Windows.Forms.Cursor.Current = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	Private Sub CmdFechar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdFechar.Click
		Me.Hide()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		
		On Error GoTo Erro

		'===========================Verifica se Houve alteracao do Numero da Fita
		If Trim(txtNumeroFita.Text) = Trim(txtNumeroFita.Tag) Then
			GoTo Saida
        End If

		'===========================Verifica se Houve Inclusao de Numero da Fita
        If Trim(txtNumeroFita.Text) <> Trim(txtNumeroFita.Tag) Then
            If Not ConsisteFita(txtNumeroFita.Text, txtVeiculo.Text) Then
                GoTo Saida
            End If

            If Aviso("Confirma a Inclusão da Fita ? ", MsgBoxStyle.YesNo, MsgBoxStyle.Question) Then
                DtsControleFita.dtbNumeracao.AdddtbNumeracaoRow(txtEmpresa.Text, Integer.Parse(txtContrato.Text), Short.Parse(txtSequencia.Text), txtCodigoComercial.Text, txtVeiculo.Text, Short.Parse(txtDuracao.Text), txtNumeroFita.Text, "", gsUsuario)
                AsmxControleFita.spuAtualizar(DtsControleFita)
                Aviso("Dados Gravado com Sucesso")
                chkOk.CheckState = System.Windows.Forms.CheckState.Checked
                CmdFechar_Click(cmdFechar, New System.EventArgs())
            End If
            GoTo Saida
        End If
Saida:
        Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
		
		
    End Sub

    Private Sub frmRoteiroDados_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.DtsDadosFita.Clear()
    End Sub
	
	Private Sub frmRoteiroDados_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			System.Windows.Forms.SendKeys.Send("{TAB}")
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmRoteiroDados_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        If bUsuario_Net Then
            txtNumeroFita.Enabled = False
        End If
		
	End Sub
	
	Private Function ConsisteFita(ByRef Par_Fita As String, ByRef Par_Veiculo As String) As Boolean
		
		On Error GoTo Erro
		Dim bCritica As Boolean
		Dim bAlerta As Boolean
		Dim sMensagem As String
		
		ConsisteFita = True
		sMensagem = ""
		bCritica = False
		
		Dim bAvulso As Boolean
		Dim bAgencia As Boolean
		Dim bCliente As Boolean
		Dim btitulo As Boolean
		Dim bProduto As Boolean
		Dim bDuracao As Boolean
		Dim bDevolvida As Boolean
		Dim bVinheta As Boolean

        DtsDadosFita = AsmxControleFita.spuDadosNumeracao(Par_Fita, Par_Veiculo, gsUsuario)

        For Each drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaNumeracaoRow In dtsDadosFita.dtbDadosFitaNumeracao.Rows
            bVinheta = False
            '---------------------------------------Nao Considere Critica quando compara Vinhetas, Somente alerta
            If (txtTipoComercial.Tag = "VA" Or txtTipoComercial.Tag = "VE") And (drw.Cod_Tipo_Comercial = "VE" Or drw.Cod_Tipo_Comercial = "VE") Then
                bVinheta = True
            End If

            '---------------------------------------Ja existe no Depositorio avulso
            If Trim(drw.Status) = "Ativa" And Trim(drw.Origem) = "Avulso" Then
                If Not bAvulso Then
                    sMensagem = sMensagem & "Já Existe no Depositório Avulso" & vbCrLf
                    sMensagem = sMensagem & "Titulo:" & drw.Titulo_Comercial & vbCrLf
                    sMensagem = sMensagem & "Duracao:" & drw.Duracao & vbCrLf
                    bAvulso = True
                End If
            End If

            '---------------------------------------Ja existe Para Outra Agencia
            If Not drw.IsCod_AgenciaNull Then
                If drw.Cod_Agencia <> txtAgencia.Tag And drw.Origem.Trim = "Midia" And drw.Status.Trim = "Ativa" Then
                    If Not bAgencia Then
                        sMensagem = sMensagem & "Já Existe no Controle de Fitas Para Outra Agencia." & vbCrLf
                        bAgencia = True
                        If Not bVinheta Then
                            'bCritica = True
                        End If
                    End If
                End If
            End If
            '---------------------------------------Ja existe Para Outro Cliente
            If Not drw.IsCod_ClienteNull Then
                If drw.Cod_Cliente.Trim <> txtCliente.Tag And drw.Origem.Trim = "Midia" And drw.Status.Trim = "Ativa" Then
                    If Not bCliente Then
                        sMensagem = sMensagem & "Já Existe no Controle de Fitas Para Outro Cliente." & vbCrLf
                        bCliente = True
                        If Not bVinheta Then
                            bCritica = True
                        End If
                    End If
                End If
            End If
            '---------------------------------------Titulos Diferentes
            If drw.Titulo_Comercial.Trim <> Trim(txtTitulo.Tag) And Trim(drw.Origem) = "Midia" And Trim(drw.Status) = "Ativa" Then
                If Not btitulo Then
                    sMensagem = sMensagem & "Já Existe no Controle de Fitas com Outro Titulo." & vbCrLf
                    'bCritica = True
                    btitulo = True
                End If
            End If

            '---------------------------------------Ja existe Para Outro Produto
            If Not drw.IsCod_Red_ProdutoNull Then
                If drw.Cod_Red_Produto <> Trim(txtProduto.Tag) And Trim(drw.Origem) = "Midia" And Trim(drw.Status) = "Ativa" Then
                    If Not bProduto Then
                        sMensagem = sMensagem & "Já Existe no Controle de Fitas Para Outro Produto." & vbCrLf
                        'bCritica = True
                        bProduto = True
                    End If
                End If
            End If

            '---------------------------------------Ja existe com Outra Duracao
            If drw.Duracao <> Val(Trim(txtDuracao.Text)) And Trim(drw.Origem) = "Midia" And Trim(drw.Status) = "Ativa" Then
                If Not bDuracao Then
                    sMensagem = sMensagem & "Já Existe no Controle com Outra Duração." & vbCrLf
                    'If Not bVinheta Then bCritica = True
                End If
                bDuracao = True
            End If
            '---------------------------------------Ja existe com Data de Devolucao
            If Trim(drw.Status) = "Devolvida" And Trim(drw.Origem) = "Midia" Then
                If Not bDevolvida Then
                    sMensagem = sMensagem & "Existe uma Fita Devolvida com este Numero." & vbCrLf
                    'If Not bVinheta Then bCritica = True
                    bDevolvida = True
                End If
            End If
Proximo:

        Next
		
		
		If bCritica Then
			sMensagem = "Numero da Fita: " & Par_Fita & vbCrLf & sMensagem
			sMensagem = sMensagem & vbCrLf & "Utilização do Número Não Permitida"
			MsgBox(sMensagem, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Crítica na Numeração de Fita")
			ConsisteFita = False
			GoTo Saida
		End If
		
		If sMensagem <> "" Then
			sMensagem = "Numero da Fita: " & Par_Fita & vbCrLf & sMensagem
			sMensagem = sMensagem & vbCrLf & vbCrLf & "Confirma a Utilizacao do Mesmo Número ? "
			If MsgBox(sMensagem, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Crítica na Numeração de Fita") = MsgBoxResult.No Then
				ConsisteFita = False
				GoTo Saida
			End If
		End If
		
Saida: 
        Exit Function
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
	End Function
	
	
	
	'UPGRADE_WARNING: Event txtNumeroFita.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtNumeroFita_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNumeroFita.TextChanged
		If chkMidia.CheckState = System.Windows.Forms.CheckState.Checked And chkAlterarNumero.CheckState = System.Windows.Forms.CheckState.Checked Then
			cmdOk.Enabled = True
		End If
	End Sub
	
	Private Sub txtNumeroFita_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNumeroFita.Enter
		seleciona_no_foco(txtNumeroFita)
	End Sub
	
	
	Private Sub txtNumeroFita_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroFita.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = Asc(UCase(Chr(KeyAscii)))
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtNumeroFita_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtNumeroFita.Validating
		Dim Cancel As Boolean = eventArgs.Cancel
		On Error GoTo Erro
		
		If Trim(txtNumeroFita.Text) = "" Then
			GoTo Saida
		End If
		
		If txtNumeroFita.Text = txtNumeroFita.Tag Then
			GoTo Saida
		End If
		
		If VB.Left(txtNumeroFita.Text, 2) <> "CO" Then
			txtNumeroFita.Text = "CO" & VB6.Format(txtNumeroFita.Text, "0000")
		End If
		
		'If Not ConsisteFita(txtNumeroFita, txtVeiculo) Then
		'   txtNumeroFita = ""
		'   Cancel = True
		'End If
		
Saida: 
		If Cancel Then
			txtNumeroFita.Text = txtNumeroFita.Tag
		End If
		GoTo EventExitSub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
		
EventExitSub: 
		eventArgs.Cancel = Cancel
	End Sub

    Private Sub _fratab_1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _fratab_1.Enter

    End Sub

    Private Sub cmdOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

    End Sub

    Private Sub chkIniciar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdFechar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFechar.Click

    End Sub
End Class