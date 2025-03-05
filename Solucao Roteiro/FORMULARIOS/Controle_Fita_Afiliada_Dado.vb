Option Strict Off
Option Explicit On
Friend Class frmControleFita_Afiliada_Dados
    Inherits System.Windows.Forms.Form
    Dim asmxControleFita As MSAClass.AsmxControleFita.asmxControleFita = NewControleFita()
    Dim dtsDadosFita As New MSAClass.AsmxControleFita.dtsDadosFita
	
	Dim MouseX As Single
	Dim MouseY As Single
	Private Sub ConfiguraGridMidia()
        With flxMidia
            .Visible = False
            .Clear()
            .Rows = 25
            .FixedRows = 2
            .FixedCols = 1
            .Cols = 9
            .AllowBigSelection = False
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .ScrollTrack = True
            .set_RowHeight(0, 280)
            .set_TextMatrix(0, 1, "Mídias Da Fita")
            .set_TextMatrix(0, 2, "Mídias Da Fita")
            .set_TextMatrix(0, 3, "Mídias Da Fita")
            .set_TextMatrix(0, 4, "Mídias Da Fita")
            .set_TextMatrix(0, 5, "Mídias Da Fita")

            .Row = 0
            For nCont = 0 To .Cols - 1
                .Col = nCont
                .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
            Next nCont

            .set_TextMatrix(1, 1, "Emp.")
            .set_TextMatrix(1, 2, "Contrato")
            .set_TextMatrix(1, 3, "Seq.")
            .set_TextMatrix(1, 4, "Com.")
            .set_TextMatrix(1, 5, "Veículo")
            .set_TextMatrix(1, 6, "Data_Desativacao")
            .set_TextMatrix(1, 7, "Inicio Progr.")
            .set_TextMatrix(1, 8, "Término Prog.")

            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree
            .set_MergeRow(0, True)

            .set_ColWidth(0, 315)
            .set_ColWidth(1, 495)
            .set_ColWidth(2, 880)
            .set_ColWidth(3, 405)
            .set_ColWidth(4, 410)
            .set_ColWidth(5, 705)
            .set_ColWidth(6, 0)
            .set_ColWidth(7, 0)
            .set_ColWidth(8, 0)
            .Tag = 0
            For nCont = 0 To .Rows - 1
                .Row = nCont
                .Col = 0
                .CellFontName = "WingDings"
                .CellFontSize = 14
                .CellForeColor = System.Drawing.Color.Blue
            Next nCont
        End With
Saida: 
		
		flxMidia.Visible = True
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
	End Sub
	
	
	Private Sub MostraDadosMidia()
        On Error GoTo Erro

        Dim sFields As String
        If Not chkLoad.Checked Then GoTo Saida
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Mensagem("Consutando dados da Fita")
        Call ConfiguraGridMidia()
        With frmControleFita_Afiliada.flxFita
            flxMidia.Visible = False
            If Trim(.get_TextMatrix(.Row, 9)) = "" Then
                flxMidia.set_TextMatrix(2, 1, .get_TextMatrix(.Row, 10))
                flxMidia.set_TextMatrix(2, 2, .get_TextMatrix(.Row, 11))
                flxMidia.set_TextMatrix(2, 3, .get_TextMatrix(.Row, 12))
                flxMidia.set_TextMatrix(2, 4, .get_TextMatrix(.Row, 13))
                flxMidia.set_TextMatrix(2, 5, "")
                flxMidia.set_TextMatrix(2, 7, .get_TextMatrix(.Row, 17))
                flxMidia.set_TextMatrix(2, 8, .get_TextMatrix(.Row, 18))
                lblNumeroFita.Text = "Pendente de Numeração"
                lblNumeroFita.Visible = True
            Else
                lblNumeroFita.Text = "Fita:" & .get_TextMatrix(.Row, 9)
                lblNumeroFita.Visible = True
                DtsDadosFita.Clear()
                DtsDadosFita = AsmxControleFita.spuDadosNumeracao(.get_TextMatrix(.Row, 9), "", gsUsuario)
                For Each drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaNumeracaoRow In dtsDadosFita.dtbDadosFitaNumeracao.Select("", "Data_Devolucao,Cod_Empresa,Numero_MR,Sequencia_MR")
                    nLin = 1
                    nLin = nLin + 1
                    If nLin >= flxMidia.Rows Then
                        flxMidia.Rows = flxMidia.Rows + 1
                        flxMidia.Row = nLin
                        flxMidia.Col = 0
                        flxMidia.CellFontName = "Wingdings"
                        flxMidia.CellForeColor = System.Drawing.Color.Blue
                        flxMidia.CellFontSize = 14
                    End If
                    If Not drw.IsCod_EmpresaNull Then
                        flxMidia.set_TextMatrix(nLin, 1, drw.Cod_Empresa)
                    End If

                    If Not drw.IsNumero_MrNull Then
                        flxMidia.set_TextMatrix(nLin, 2, drw.Numero_Mr)
                    End If

                    If Not drw.IsSequencia_MrNull Then
                        flxMidia.set_TextMatrix(nLin, 3, drw.Sequencia_Mr)
                    End If

                    If Not drw.IsCod_ComercialNull Then
                        flxMidia.set_TextMatrix(nLin, 4, drw.Cod_Comercial)
                    End If
                    If Not drw.IsCod_VeiculoNull Then
                        flxMidia.set_TextMatrix(nLin, 5, drw.Cod_Veiculo)
                    End If

                    ' If Not drw.isData_DevolucaoNull Then flxMidia.set_TextMatrix(nLin, 6, drw.Data_Devolucao)

                Next
            End If
        End With
		
		'===============================Mostra dados
		With flxMidia
			.Row = 2
			.Tag = 0
			.Visible = True
			Me.Refresh()
            flxMidia_EnterCell(flxMidia, New System.EventArgs())
			flxMidia_RowColChange(flxMidia, New System.EventArgs())
		End With
		
Saida: 
		flxMidia.Visible = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Mensagem("")

		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
	End Sub
    Private Sub MostraDadosAvulso()
        On Error GoTo Erro
        If Not chkLoad.Checked Then GoTo Saida
        Dim strCod_Veiculo As String
        Dim intIdFita As Long

        Me.ConfiguraGridMidia()

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Consutando dados da Fita")
        With frmControleFita_Afiliada.flxFita
            strCod_Veiculo = .get_TextMatrix(.Row, 14)
            intIdFita = Long.Parse(.get_TextMatrix(.Row, 16))
            lblNumeroFita.Text = "Fita:" & .get_TextMatrix(.Row, 9)
        End With
        Call ConfiguraGridMidia()
        DtsDadosFita.Clear()
        DtsDadosFita = AsmxControleFita.spuDadosComercialAvulso(strCod_Veiculo, intIdFita)
        If DtsDadosFita.dtbDadosFitaAvulso.Select().Length > 0 Then
            With DtsDadosFita.dtbDadosFitaAvulso(0)
                txtAgencia.Text = ""
                txtAgenciaDescricao.Text = ""
                txtCliente.Text = ""
                txtClienteDescricao.Text = ""
                txtTipoComercial.Text = .Cod_Tipo_Comercial
                txtTitulo.Text = .Titulo_Comercial
                txtTipoComercialDescricao.Text = .Descricao_Tipo_Comercial
                txtProduto.Text = ""
                txtProdutoDescricao.Text = ""
                If Not .IsDuracaoNull Then
                    txtDuracao.Text = .Duracao.ToString("##")
                End If
                If Not .IsObservacaoNull Then txtObservacoes.Text = .Observacao
                txtInicioProgramacao.Text = .Data_Inicio
                txtFimProgramacao.Text = .Data_Final

                If .Indica_Desativado = 1 Then
                    lblStatus.Text = "Fita Desativada"
                Else
                    lblStatus.Text = "Fita Em Uso"
                End If
            End With
        End If

Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Private Sub MostraDadosArtistico()
        On Error GoTo Erro
        Dim strCod_Veiculo As String
        Dim intIdFita As Long
        If Not chkLoad.Checked Then GoTo Saida
        Me.ConfiguraGridMidia()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Consutando dados da Fita")
        With frmControleFita_Afiliada.flxFita
            strCod_Veiculo = .get_TextMatrix(.Row, 14)
            intIdFita = Long.Parse(.get_TextMatrix(.Row, 16))
            lblNumeroFita.Text = "Fita:" & .get_TextMatrix(.Row, 9)
        End With
        Call ConfiguraGridMidia()
        DtsDadosFita.Clear()
        DtsDadosFita = AsmxControleFita.spuDadosComercialArtistico(strCod_Veiculo, intIdFita)
        If DtsDadosFita.dtbDadosFitaArtistico.Select().Length > 0 Then
            With DtsDadosFita.dtbDadosFitaArtistico(0)
                txtAgencia.Text = ""
                txtAgenciaDescricao.Text = ""
                txtCliente.Text = ""
                txtClienteDescricao.Text = ""
                txtTipoComercial.Text = .Cod_Tipo_Comercial
                txtTitulo.Text = .Titulo_Comercial
                txtTipoComercialDescricao.Text = .Descricao_Tipo_Comercial
                txtProduto.Text = ""
                txtProdutoDescricao.Text = ""
                txtDuracao.Text = .Duracao.ToString("##")
                If Not .IsObservacaoNull Then txtObservacoes.Text = .Observacao
                txtInicioProgramacao.Text = .Data_Inicio
                txtFimProgramacao.Text = .Data_Final

                If .Indica_Desativado = 1 Then
                    lblStatus.Text = "Fita Desativada"
                Else
                    lblStatus.Text = "Fita Em Uso"
                End If
            End With
        End If
Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    'UPGRADE_WARNING: Event chkArtistico.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkArtistico_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkArtistico.CheckStateChanged
        If chkArtistico.Checked Then Me.MostraDadosArtistico()
    End Sub

    'UPGRADE_WARNING: Event chkAvulso.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkAvulso_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAvulso.CheckStateChanged
        If chkAvulso.Checked Then Me.MostraDadosAvulso()
    End Sub


    'UPGRADE_WARNING: Event chkMidia.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkMidia_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkMidia.CheckStateChanged
        If chkMidia.Checked Then Me.MostraDadosMidia()
    End Sub

    Private Sub cmdDadosFitaCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDadosFitaCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub flxMidia_EnterCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxMidia.EnterCell
        With flxMidia
            If .Row >= .FixedRows Then
                .set_TextMatrix(.Row, 0, Chr(240))
            End If
        End With
    End Sub

    Private Sub flxMidia_LeaveCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxMidia.LeaveCell
        With flxMidia
            .set_TextMatrix(.Row, 0, "")
        End With
    End Sub

    Private Sub flxMidia_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxMidia.RowColChange

        On Error GoTo Erro
        Dim Var_Empresa As String

        Dim Var_Contrato As Integer
        Dim Var_Sequencia As Short
        Dim Var_Legenda As String
        Dim Var_Veiculo As String

        txtAgencia.Text = ""
        txtAgenciaDescricao.Text = ""
        txtCliente.Text = ""
        txtClienteDescricao.Text = ""
        txtTipoComercial.Text = ""
        txtTitulo.Text = ""
        txtTipoComercialDescricao.Text = ""
        txtProduto.Text = ""
        txtProdutoDescricao.Text = ""
        txtDuracao.Text = ""
        txtInicioProgramacao.Text = ""
        txtFimProgramacao.Text = ""
        txtDataRecepcao.Text = ""
        txtDataTranscricao.Text = ""
        txtDataDevolucao.Text = ""
        txtLocalizacao.Text = ""
        txtObservacoes.Text = ""

        With flxMidia
            If Not .Visible Or .Row = Val(.Tag) Then
                GoTo Saida
            End If
            If Trim(.get_TextMatrix(.Row, 1)) = "" Then
                GoTo Saida
            End If

            Var_Empresa = .get_TextMatrix(.Row, 1)
            Var_Contrato = CInt(.get_TextMatrix(.Row, 2))
            Var_Sequencia = CShort(.get_TextMatrix(.Row, 3))
            Var_Legenda = .get_TextMatrix(.Row, 4)
            Var_Veiculo = .get_TextMatrix(.Row, 5)

            txtInicioProgramacao.Text = .get_TextMatrix(.Row, 7)
            txtFimProgramacao.Text = .get_TextMatrix(.Row, 8)

            If Trim(.get_TextMatrix(.Row, 6)) <> "" Then
                lblStatus.Text = "Fita Devolvida"
            Else
                lblStatus.Text = "Fita Em Uso"
            End If

        End With

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Consutando dados da Fita")

        DtsDadosFita = AsmxControleFita.spuDadosMaterial(Var_Empresa, Var_Contrato, Var_Sequencia, Var_Legenda)

        If DtsDadosFita.dtbDadosFitaComercial.Select().Length > 0 Then
            With DtsDadosFita.dtbDadosFitaComercial(0)
                If Not .IsCod_AgenciaNull Then txtAgencia.Text = .Cod_Agencia
                If Not .IsNome_AgenciaNull Then txtAgenciaDescricao.Text = .Nome_Agencia
                If Not .IsCod_CLienteNull Then txtCliente.Text = .Cod_CLiente
                If Not .IsNome_ClienteNull Then txtClienteDescricao.Text = .Nome_Cliente
                If Not .IsCod_Tipo_ComercialNull Then txtTipoComercial.Text = .Cod_Tipo_Comercial
                If Not .IsTitulo_ComercialNull Then txtTitulo.Text = .Titulo_Comercial
                If Not .IsDescricao_Tipo_ComercialNull Then txtTipoComercialDescricao.Text = .Descricao_Tipo_Comercial
                If Not .IsCod_Red_ProdutoNull Then txtProduto.Text = .Cod_Red_Produto
                If Not .IsDescricao_ProdutoNull Then txtProdutoDescricao.Text = .Descricao_Produto
                If Not .IsInicio_ProgramacaoNull Then txtInicioProgramacao.Text = VB6.Format(.Inicio_Programacao, "dd/mm/yyyy")
                If Not .IsFim_ProgramacaoNull Then txtFimProgramacao.Text = VB6.Format(.Fim_Programacao, "dd/mm/yyyy")
                If Not .IsDuracaoNull Then txtDuracao.Text = .Duracao.ToString("##")
            End With
        End If
        '=====================Busca Dados da Fita
        sSql = "Where Cod_Empresa = '" & Var_Empresa & "'"
        sSql = sSql & " and Numero_mr = " & Var_Contrato
        sSql = sSql & " and Sequencia_mr = " & Var_Sequencia
        sSql = sSql & " and cod_comercial = '" & Var_Legenda & "'"
        sSql = sSql & " and Cod_veiculo = '" & Var_Veiculo & "'"


Saida:
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub
	
	
	'UPGRADE_WARNING: Form event frmControleFita_Afiliada_Dados.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmControleFita_Afiliada_Dados_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If chkMidia.CheckState = 1 Then
			flxMidia_LeaveCell(flxMidia, New System.EventArgs())
			flxMidia_EnterCell(flxMidia, New System.EventArgs())
			flxMidia_RowColChange(flxMidia, New System.EventArgs())
		End If
		
	End Sub
	
    Private Sub frmControleFita_Afiliada_Dados_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Top = VB6.TwipsToPixelsY(600)
        Me.Left = VB6.TwipsToPixelsX(900)
        asmxControleFita = NewControleFita()
        chkLoad.Checked = True
        If chkAvulso.Checked Then Call MostraDadosAvulso()
        If chkArtistico.Checked Then Call MostraDadosArtistico()
        If chkMidia.Checked Then Call MostraDadosMidia()
    End Sub
End Class