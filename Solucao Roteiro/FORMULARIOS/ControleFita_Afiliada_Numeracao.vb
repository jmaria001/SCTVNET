Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmControleFita_Afiliada_Determinacao
	Inherits System.Windows.Forms.Form

	Dim bUsuarioComercialCab, bUsuarioArtisticoCab As Boolean
	Dim bUsuarioComercialLin, bUsuarioArtisticoLin As Boolean
	Dim bExiste, bDataDevolucao As Boolean
	Dim sNumeroFitaAnterior As String
    Dim bAlterou As Boolean
	Dim bValidaLinha As Boolean
	Dim MouseX, MouseY As Short
    Dim bGravar As Boolean
    Dim asmxControleFita As MSAClass.AsmxControleFita.asmxControleFita = NewControleFita()
    Dim dtsControleFita As New MSAClass.AsmxControleFita.dtsControleFita
    Dim dtsDadosFita As New MSAClass.AsmxControleFita.dtsDadosFita


	Private Sub AdicionaGridExistente(ByRef Par_Fita As String, ByRef Par_Veiculo As String)
        On Error GoTo Erro

		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		Dim nAdiciona As Short
		
		'-----------Se ja existe nao adiciona
		With flxExistente
			For nAdiciona = 1 To .Rows - 1
				If Trim(.get_TextMatrix(nAdiciona, 14)) = Trim(Par_Fita) Then
					GoTo Saida
				End If
			Next nAdiciona
        End With

        DtsDadosFita = AsmxControleFita.spuDadosNumeracao(Par_Fita, Par_Veiculo, gsUsuario)

        With flxExistente
            For Each drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaNumeracaoRow In dtsDadosFita.dtbDadosFitaNumeracao.Rows
                .Rows = .Rows + 1
                If Not drw.IsCod_Red_ProdutoNull Then .set_TextMatrix(.Rows - 1, 0, drw.Cod_Red_Produto)
                If Not drw.IsNome_ProdutoNull Then .set_TextMatrix(.Rows - 1, 1, drw.Nome_Produto)
                If Not drw.IsCod_AgenciaNull Then .set_TextMatrix(.Rows - 1, 2, drw.Cod_Agencia)
                If Not drw.IsRazao_Social_AgenciaNull Then .set_TextMatrix(.Rows - 1, 3, drw.Razao_Social_Agencia)
                If Not drw.IsCod_ClienteNull Then .set_TextMatrix(.Rows - 1, 4, drw.Cod_Cliente)
                If Not drw.IsRazao_Social_ClienteNull Then .set_TextMatrix(.Rows - 1, 5, drw.Razao_Social_Cliente)
                If Not drw.IsCod_Tipo_ComercialNull Then .set_TextMatrix(.Rows - 1, 6, drw.Cod_Tipo_Comercial)
                If Not drw.IsDescricaoNull Then .set_TextMatrix(.Rows - 1, 7, drw.Descricao)
                If Not drw.IsCod_ComercialNull Then .set_TextMatrix(.Rows - 1, 8, drw.Cod_Comercial)
                If Not drw.IsTitulo_ComercialNull Then .set_TextMatrix(.Rows - 1, 9, drw.Titulo_Comercial)
                If Not drw.IsCod_EmpresaNull Then .set_TextMatrix(.Rows - 1, 10, drw.Cod_Empresa)
                If Not drw.IsNumero_MrNull Then .set_TextMatrix(.Rows - 1, 11, drw.Numero_Mr)
                If Not drw.IsSequencia_MrNull Then .set_TextMatrix(.Rows - 1, 12, drw.Sequencia_Mr)
                If Not drw.IsDuracaoNull Then .set_TextMatrix(.Rows - 1, 13, drw.Duracao)
                If Not drw.IsNumero_FitaNull Then .set_TextMatrix(.Rows - 1, 14, drw.Numero_Fita)
                If Not drw.IsCod_VeiculoNull Then .set_TextMatrix(.Rows - 1, 15, drw.Cod_Veiculo)
                If Not drw.IsStatusNull Then .set_TextMatrix(.Rows - 1, 16, drw.Status)
                If Not drw.IsOrigemNull Then .set_TextMatrix(.Rows - 1, 17, drw.Origem)
            Next
        End With
		
Saida: 
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
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

        Dim nRow As Short

        With flxExistente
            For nRow = 0 To .Rows - 1

                If Trim(.get_TextMatrix(nRow, 14)) <> Trim(Par_Fita) Then
                    GoTo Proximo
                End If

                bVinheta = False

                '---------------------------------------Nao Considere Critica quando compara Vinhetas, Somente alerta
                If (txtTipoComercial(0).Text = "VA" Or txtTipoComercial(0).Text = "VE") And (.get_TextMatrix(nRow, 6) = "VA" Or .get_TextMatrix(nRow, 6) = "VE") Then
                    bVinheta = True
                End If

                '---------------------------------------Ja existe no Depositorio avulso
                If Trim(.get_TextMatrix(nRow, 16)) = "Ativa" And Trim(.get_TextMatrix(nRow, 17)) = "Avulso" Then
                    If Not bAvulso Then
                        sMensagem = sMensagem & "Já Existe no Depositório Avulso" & vbCrLf
                        bAvulso = True
                    End If
                End If

                '---------------------------------------Ja existe Para Outra Agencia
                If Trim(.get_TextMatrix(nRow, 2)) <> Trim(txtAgencia(0).Text) And Trim(.get_TextMatrix(nRow, 17)) = "Midia" And Trim(.get_TextMatrix(nRow, 16)) = "Ativa" Then
                    If Not bAgencia Then
                        sMensagem = sMensagem & "Já Existe no Controle de Fitas Para Outra Agencia." & vbCrLf
                        bAgencia = True
                        If Not bVinheta Then
                            'bCritica = True
                        End If
                    End If
                End If

                '---------------------------------------Ja existe Para Outro Cliente
                If Trim(.get_TextMatrix(nRow, 4)) <> Trim(txtCliente(0).Text) And Trim(.get_TextMatrix(nRow, 17)) = "Midia" And Trim(.get_TextMatrix(nRow, 16)) = "Ativa" Then
                    If Not bCliente Then
                        sMensagem = sMensagem & "Já Existe no Controle de Fitas Para Outro Cliente." & vbCrLf
                        bCliente = True
                        If Not bVinheta Then
                            'bCritica = True
                        End If
                    End If
                End If

                '---------------------------------------Titulos Diferentes
                If Trim(.get_TextMatrix(nRow, 9)) <> Trim(txtTitulo(0).Text) And Trim(.get_TextMatrix(nRow, 17)) = "Midia" And Trim(.get_TextMatrix(nRow, 16)) = "Ativa" Then
                    If Not btitulo Then
                        sMensagem = sMensagem & "Já Existe no Controle de Fitas com Outro Titulo." & vbCrLf
                        'bCritica = True
                        btitulo = True
                    End If
                End If

                '---------------------------------------Ja existe Para Outro Produto
                If Trim(.get_TextMatrix(nRow, 0)) <> Trim(txtProduto(0).Text) And Trim(.get_TextMatrix(nRow, 17)) = "Midia" And Trim(.get_TextMatrix(nRow, 16)) = "Ativa" Then
                    If Not bProduto Then
                        sMensagem = sMensagem & "Já Existe no Controle de Fitas Para Outro Produto." & vbCrLf
                        'bCritica = True
                        bProduto = True
                    End If
                End If

                '---------------------------------------Ja existe com Outra Duracao
                If Trim(.get_TextMatrix(nRow, 13)) <> Trim(txtDuracao(0).Text) And Trim(.get_TextMatrix(nRow, 17)) = "Midia" And Trim(.get_TextMatrix(nRow, 16)) = "Ativa" Then
                    If Not bDuracao Then
                        sMensagem = sMensagem & "Já Existe no Controle com Outra Duração." & vbCrLf
                        'If Not bVinheta Then bCritica = True
                    End If
                    bDuracao = True
                End If
                '---------------------------------------Ja existe com Data de Devolucao
                If Trim(.get_TextMatrix(nRow, 16)) = "Devolvida" And Trim(.get_TextMatrix(nRow, 17)) = "Midia" Then
                    If Not bDevolvida Then
                        sMensagem = sMensagem & "Existe uma Fita Devolvida com este Numero." & vbCrLf
                        'If Not bVinheta Then bCritica = True
                        bDevolvida = True
                    End If
                End If
Proximo:
            Next nRow


        End With

        If bCritica Then
            sMensagem = "Numero da Fita: " & Par_Fita & vbCrLf & sMensagem
            sMensagem = sMensagem & vbCrLf & "Utilização do Número Não Permitida"
            MsgBox(sMensagem, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Crítica na Numeração de Fita")
            ConsisteFita = False
            GoTo Saida
        End If

        If sMensagem <> "" Then
            sMensagem = "Numero da Fita: " & Par_Fita & vbCrLf & sMensagem
            sMensagem = sMensagem & vbCrLf & "Confirma a Utilizacao do Mesmo Número ? "
            If MsgBox(sMensagem, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Crítica na Numeração de Fita") = MsgBoxResult.No Then
                ConsisteFita = False
                GoTo Saida
                bGravar = False
            Else
                bGravar = True
            End If
        End If

Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Function


    Private Sub RemoveGridExistente(ByRef Par_Fita As String)

        On Error GoTo Erro
        If Trim(Par_Fita) = "" Then
            GoTo Saida
        End If

        '-----------Se existe Digitada nao remove
        With flxVeiculos
            For nCont = 1 To .Rows - 1
                If Trim(.get_TextMatrix(nCont, 1)) = Trim(Par_Fita) Then
                    GoTo Saida
                End If
            Next nCont
        End With

        With flxExistente
            For nCont = .Rows - 1 To 1 Step -1
                If Trim(.get_TextMatrix(.Row, 14)) = Trim(Par_Fita) Then
                    .RemoveItem(nCont)
                End If
            Next nCont
        End With

Saida:
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub cmdAnterior_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAnterior.Click
		With flxExistente
			If .Row > 1 Then
				.Row = .Row - 1
			End If
		End With
		
	End Sub
	
	Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Me.Dispose()
	End Sub
	
	Private Sub cmdDisponivel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDisponivel.Click
        On Error GoTo Erro
        Dim sVeiculo As String = ""
        Dim strNumeroFita As String = ""

        sVeiculo = flxVeiculos.get_TextMatrix(flxVeiculos.Row, 0)
        txtEdicao(1).Text = ""
		If sVeiculo = "" Then
			Aviso("Para utilizar numeração automática, primeiro selecione um veiculo")
			GoTo Saida
        End If


        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        strNumeroFita = AsmxControleFita.spuFitaDisponivel(sVeiculo, -1, -1, 0, gsUsuario, 0)

        If strNumeroFita = "" Then
            Aviso("Nenhum número disponivel foi encontrado")
            GoTo Saida
        End If
        txtEdicao(1).Text = strNumeroFita   
		If txtEdicao(1).Enabled Then
			txtEdicao(1).Focus()
			System.Windows.Forms.SendKeys.Send(vbTab)
		End If
		
Saida: 
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Dim bfita As Boolean
        Dim sMsg As String
		
        With flxVeiculos
            sMsg = ""
            nLin = 0

            bfita = False
            For nCont = 1 To .Rows - 1
                If Trim(.get_TextMatrix(nCont, 1)) <> "" Then
                    bfita = True
                End If

            Next nCont
        End With
        If Not bfita Then
            Aviso("Nenhum Numero de Fita foi Informado")
            GoTo Saida
        End If
		
		Call Gravar()
		
		
Saida: 
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
	End Sub
	Private Sub Gravar()
		
		On Error GoTo Erro
		
        Dim sTipoMaterial As String
        Dim sPrimeiraFita As String = ""
        Dim sPrimeiroVeiculo As String = ""
        Dim strVeiculo As String = ""
        Dim strFita As String = ""
        Dim strLocalizacao As String = ""

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        DtsControleFita.dtbNumeracao.Clear()

		With flxVeiculos
			nLin = 0
            For nCont = 1 To .Rows - 1
                strVeiculo = .get_TextMatrix(nCont, 0).Trim
                strFita = .get_TextMatrix(nCont, 1).Trim
                strLocalizacao = .get_TextMatrix(nCont, 2).Trim

                If strVeiculo <> "" And strFita <> "" Then

                    DtsControleFita.dtbNumeracao.AdddtbNumeracaoRow(txtEmpresa(0).Text, _
                                                                    Integer.Parse(txtContrato(0).Text), _
                                                                    Short.Parse(txtSequencia(0).Text), _
                                                                    txtComercial(0).Text, _
                                                                    strVeiculo, _
                                                                    Short.Parse(txtDuracao(0).Text), _
                                                                    strFita, _
                                                                    strLocalizacao, _
                                                                    gsUsuario)

                    nLin = nLin + 1
                End If
                If sPrimeiraFita = "" Then
                    sPrimeiraFita = strFita
                    sPrimeiroVeiculo = strVeiculo
                End If

            Next
        End With

		
		If nLin = 0 Then
			Aviso("Nenhuma Fita Foi Informada !")
            GoTo Saida
        Else
            AsmxControleFita.spuNumerar(DtsControleFita)
            DtsControleFita.dtbNumeracao.Clear()
        End If


        With frmControleFita_Afiliada.flxFita
            .Col = 7
            .CellFontName = "WingDings"
            .CellForeColor = System.Drawing.Color.Blue
            .CellFontSize = 14
            .CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignCenterCenter
            .set_TextMatrix(.Row, 7, Chr(252))
            .set_TextMatrix(.Row, 9, sPrimeiraFita)
            .set_TextMatrix(.Row, 10, txtEmpresa(0).Text)
            .set_TextMatrix(.Row, 11, txtContrato(0).Text)
            .set_TextMatrix(.Row, 12, txtSequencia(0).Text)
            .set_TextMatrix(.Row, 13, txtComercial(0).Text)
            .set_TextMatrix(.Row, 14, sPrimeiroVeiculo)
            .set_TextMatrix(.Row, 8, txtEmpresa(0).Text & "-" & txtContrato(0).Text & "-" & txtSequencia(0).Text & "-" & Trim(txtComercial(0).Text) & "-" & sPrimeiroVeiculo)
        End With
        cmdCancela_Click(cmdCancela, New System.EventArgs())
Saida:
        Dim cls As MSAClass.AsmxControleFita.asmxControleFita = NewControleFita()
        cls.spuDeletarReserva(gsUsuario)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub

    Private Sub cmdPrimeira_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrimeira.Click
        With flxExistente
            If .Rows >= 2 Then
                .Row = 1
            End If
        End With
    End Sub

    Private Sub cmdProximo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProximo.Click
        With flxExistente
            If .Row < .Rows - 1 Then
                .Row = .Row + 1
            End If
        End With
    End Sub

    Private Sub cmdUltimo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUltimo.Click
        With flxExistente
            .Row = .Rows - 1
        End With
    End Sub

    Private Sub flxExistente_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxExistente.RowColChange

        On Error GoTo Erro

        txtProduto(1).BackColor = System.Drawing.Color.White
        txtDescricaoProduto(1).BackColor = System.Drawing.Color.White
        txtAgencia(1).BackColor = System.Drawing.Color.White
        txtAgenciaDescricao(1).BackColor = System.Drawing.Color.White
        txtCliente(1).BackColor = System.Drawing.Color.White
        txtClienteDescricao(1).BackColor = System.Drawing.Color.White
        txtTipoComercial(1).BackColor = System.Drawing.Color.White
        txtTipoComercialDescricao(1).BackColor = System.Drawing.Color.White
        txtComercial(1).BackColor = System.Drawing.Color.White
        txtTitulo(1).BackColor = System.Drawing.Color.White
        txtEmpresa(1).BackColor = System.Drawing.Color.White
        txtContrato(1).BackColor = System.Drawing.Color.White
        txtSequencia(1).BackColor = System.Drawing.Color.White
        txtDuracao(1).BackColor = System.Drawing.Color.White
        txtNumero_Fita.BackColor = System.Drawing.Color.White
        txtVeiculo.BackColor = System.Drawing.Color.White
        txtStatus.BackColor = System.Drawing.Color.White

        txtProduto(1).Text = ""
        txtDescricaoProduto(1).Text = ""
        txtAgencia(1).Text = ""
        txtAgenciaDescricao(1).Text = ""
        txtCliente(1).Text = ""
        txtClienteDescricao(1).Text = ""
        txtTipoComercial(1).Text = ""
        txtTipoComercialDescricao(1).Text = ""
        txtComercial(1).Text = ""
        txtTitulo(1).Text = ""
        txtEmpresa(1).Text = ""
        txtContrato(1).Text = ""
        txtSequencia(1).Text = ""
        txtDuracao(1).Text = ""
        txtNumero_Fita.Text = ""
        txtVeiculo.Text = ""
        txtStatus.Text = ""

        fraFita.Text = "Comercial Existente com Mesmo Numero de Fita"

        With flxExistente
            If Trim(.get_TextMatrix(.Row, 14)) <> "" Then
                txtProduto(1).Text = .get_TextMatrix(.Row, 0)
                txtDescricaoProduto(1).Text = .get_TextMatrix(.Row, 1)
                txtAgencia(1).Text = .get_TextMatrix(.Row, 2)
                txtAgenciaDescricao(1).Text = .get_TextMatrix(.Row, 3)
                txtCliente(1).Text = .get_TextMatrix(.Row, 4)
                txtClienteDescricao(1).Text = .get_TextMatrix(.Row, 5)
                txtTipoComercial(1).Text = .get_TextMatrix(.Row, 6)
                txtTipoComercialDescricao(1).Text = .get_TextMatrix(.Row, 7)
                txtComercial(1).Text = .get_TextMatrix(.Row, 8)
                txtTitulo(1).Text = .get_TextMatrix(.Row, 9)
                txtEmpresa(1).Text = .get_TextMatrix(.Row, 10)
                txtContrato(1).Text = .get_TextMatrix(.Row, 11)
                txtSequencia(1).Text = .get_TextMatrix(.Row, 12)
                txtDuracao(1).Text = .get_TextMatrix(.Row, 13)
                txtNumero_Fita.Text = .get_TextMatrix(.Row, 14)
                txtVeiculo.Text = .get_TextMatrix(.Row, 15)
                txtStatus.Text = .get_TextMatrix(.Row, 16)

                txtProduto(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtProduto(1).Text) = Trim(txtProduto(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtDescricaoProduto(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtDescricaoProduto(1).Text) = Trim(txtDescricaoProduto(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtAgencia(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtAgencia(1).Text) = Trim(txtAgencia(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtAgenciaDescricao(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtAgenciaDescricao(1).Text) = Trim(txtAgenciaDescricao(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtCliente(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtCliente(1).Text) = Trim(txtCliente(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtClienteDescricao(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtClienteDescricao(1).Text) = Trim(txtClienteDescricao(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtTipoComercial(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtTipoComercial(1).Text) = Trim(txtTipoComercial(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtTipoComercialDescricao(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtTipoComercialDescricao(1).Text) = Trim(txtTipoComercialDescricao(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtComercial(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtComercial(1).Text) = Trim(txtComercial(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtTitulo(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtTitulo(1).Text) = Trim(txtTitulo(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtEmpresa(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtEmpresa(1).Text) = Trim(txtEmpresa(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtContrato(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtContrato(1).Text) = Trim(txtContrato(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtSequencia(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtSequencia(1).Text) = Trim(txtSequencia(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                txtDuracao(1).BackColor = System.Drawing.ColorTranslator.FromOle(IIf(Trim(txtDuracao(1).Text) = Trim(txtDuracao(0).Text), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)))
                fraFita.Text = "Comercial Existente com Mesmo Numero de Fita (" & Trim(.get_TextMatrix(.Row, 17)) & ")"

            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub flxVeiculos_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxVeiculos.RowColChange

        On Error GoTo Erro
        Dim nLoop As Short
        Dim nLoop2 As Short
        Dim bExiste As Boolean

        With flxVeiculos
            If Not .Visible Then
                GoTo Saida
            End If
            '==============================> Esconde todos os Text Box
            For nLoop = 0 To 2
                flxVeiculos.Tag = 1
                txtEdicao(nLoop).Visible = False
                flxVeiculos.Tag = 0
            Next nLoop
            cmdDisponivel.Visible = False
            '==============================> Mostra e move dados para os Text Box
            If .Row >= .FixedRows And .get_RowIsVisible(.Row) And .get_TextMatrix(.Row, 0).Trim <> "" Then

                For nLoop = 0 To 2
                    If .get_ColWidth(nLoop) > 0 Then
                        txtEdicao(nLoop).Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + .CellTop)
                        txtEdicao(nLoop).Text = .get_TextMatrix(.Row, nLoop)
                        txtEdicao(nLoop).Tag = .get_TextMatrix(.Row, nLoop)
                        flxVeiculos.Tag = 1
                        txtEdicao(nLoop).Visible = True
                        txtEdicao(nLoop).BringToFront()
                        flxVeiculos.Tag = 0
                    End If
                Next nLoop
                cmdDisponivel.Visible = True
                cmdDisponivel.Top = txtEdicao(1).Top

                If txtEdicao(0).Enabled Then
                    txtEdicao(0).Focus()
                    seleciona_no_foco(txtEdicao(0))
                Else
                    txtEdicao(1).Focus()
                    seleciona_no_foco(txtEdicao(1))
                End If

            End If
        End With

        '--------------Posiciona na Linha de Fita existente e Delete Inexistentes

        With flxExistente

            For nLoop = .Rows - 1 To 1 Step -1
                bExiste = False
                For nLoop2 = 1 To flxVeiculos.Rows - 1
                    If Trim(flxVeiculos.get_TextMatrix(nLoop2, 1)) = Trim(.get_TextMatrix(nLoop, 14)) Then
                        bExiste = True
                        Exit For
                    End If
                Next nLoop2

                If Not bExiste Then
                    .RemoveItem(nLoop)
                End If

            Next nLoop

            .Row = 0
            For nLoop = 1 To .Rows - 1
                If Trim(.get_TextMatrix(nLoop, 14)) = Trim(flxVeiculos.get_TextMatrix(flxVeiculos.Row, 1)) Then
                    .Row = nLoop
                    Exit For
                End If
            Next nLoop
            flxExistente_RowColChange(flxExistente, New System.EventArgs())
        End With

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub flxVeiculos_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxVeiculos.Scroll
        flxVeiculos_RowColChange(flxVeiculos, New System.EventArgs())
    End Sub

    Private Sub frmControleFita_Afiliada_Determinacao_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated

        If Trim(txtContrato(0).Text) <> "" Then
            Call CarregaVeiculosDoUsuario()
            Call Mostra()
            For nCont = 1 To flxVeiculos.Rows - 1
                If flxVeiculos.get_TextMatrix(nCont, 1) = "" Then
                    flxVeiculos.Row = nCont ' Regional, por esta linha
                    flxVeiculos.Col = 0 ' Regional, por esta linha
                    Exit For
                Else
                    AdicionaGridExistente(flxVeiculos.get_TextMatrix(nCont, 1), flxVeiculos.get_TextMatrix(nCont, 0))
                End If
            Next
            flxVeiculos_RowColChange(flxVeiculos, New System.EventArgs())
        End If
        bAlterou = False
Saida:
        Exit Sub
    End Sub
    Private Sub Mostra()

        Dim sCampos, sTabela As String
        Dim nRow As Short
        On Error GoTo Erro

        DtsDadosFita = AsmxControleFita.spuConsultaDadosMidia(txtEmpresa(0).Text, _
                                                                    Integer.Parse(txtContrato(0).Text), _
                                                                    Short.Parse(txtSequencia(0).Text), _
                                                                    txtComercial(0).Text, _
                                                                    gsUsuario)



        Dim drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosMidiaRow() = dtsDadosFita.dtbDadosMidia.Select()
        

        If drw.Length = 0 Then
            Aviso("Código não Cadastrado !")
        End If

        txtEmpresa(0).Text = drw(0).Cod_Empresa
        txtAgencia(0).Text = drw(0).Cod_Agencia
        txtAgenciaDescricao(0).Text = drw(0).Nome_Agencia

        txtCliente(0).Text = drw(0).Cod_Cliente
        txtClienteDescricao(0).Text = drw(0).Nome_Cliente

        txtTipoComercial(0).Text = drw(0).Cod_Tipo_Comercial
        txtTipoComercialDescricao(0).Text = drw(0).Descricao_Tipo_Comercial
        txtTitulo(0).Text = drw(0).Titulo_Comercial
        txtProduto(0).Text = drw(0).Cod_Red_Produto
        txtDescricaoProduto(0).Text = drw(0).Nome_Produto
        sNumeroFitaAnterior = ""
        txtDuracao(0).Text = drw(0).Duracao

        '------------------------Carrega os Veiculos com as Fitas
        DtsDadosFita = AsmxControleFita.spuCarregarVeiculosFita(txtEmpresa(0).Text, _
                                                                Integer.Parse(txtContrato(0).Text), _
                                                                Short.Parse(txtSequencia(0).Text), _
                                                                txtComercial(0).Text, _
                                                                gsUsuario)


        With flxVeiculos

            For Each drwVeiculo As MSAClass.AsmxControleFita.dtsDadosFita.dtbFitaVeiculoRow In dtsDadosFita.dtbFitaVeiculo.Rows

                nLin = 0
                For nRow = 1 To .Rows - 1
                    If .get_TextMatrix(nRow, 0) = drwVeiculo.Cod_Veiculo Then
                        nLin = nRow
                        Exit For
                    End If
                Next nRow

                If nLin > 0 Then
                    .set_TextMatrix(nLin, 1, drwVeiculo.Numero_Fita.Trim)
                    .set_TextMatrix(nLin, 2, drwVeiculo.Localizacao.Trim)
                    .set_TextMatrix(nLin, 3, drwVeiculo.Cod_Veiculo.Trim)
                    .set_TextMatrix(nLin, 4, drwVeiculo.Numero_Fita.Trim)
                    .set_TextMatrix(nLin, 5, drwVeiculo.Localizacao.Trim)
                End If
            Next
            .Row = 1


            For nCont = 1 To .Rows - 1
                If .get_TextMatrix(nCont, 0) = "" Then
                    Exit For
                End If
            Next nCont
            .Visible = True
        End With
Saida:
        flxVeiculos.Visible = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub MontaFlex()
		
		On Error GoTo Erro

		With flxVeiculos
			
			.Visible = False
			.Clear()
			.ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
			.AllowBigSelection = False
			.AllowUserResizing = False
			
			.Rows = 20
			.FixedCols = 0
			.RowHeightMin = VB6.PixelsToTwipsY(txtEdicao(0).Height)
			.FormatString = "Veículo|Fita nº|Localização|Veiculo Anterior|Fita Anterior|Localizacao Anterior|Indica_Bloqueado"
			.Row = 0
			.set_ColWidth(0, 795)
            .set_ColWidth(1, 1500)
            .set_ColWidth(2, 2400)
			.set_ColWidth(3, 0)
			.set_ColWidth(4, 0)
			.set_ColWidth(5, 0)
			.set_ColWidth(6, 0)
			.Row = 0
			For nCont = 0 To .Cols - 1
				.Col = nCont
				.CellFontBold = True
				.CellForeColor = System.Drawing.Color.Blue
				.set_ColAlignment(nCont, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
			Next 
			For nCont = 0 To 2
				.Col = nCont
				txtEdicao(nCont).Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + .CellLeft)
				txtEdicao(nCont).Width = VB6.TwipsToPixelsX(.CellWidth)
                txtEdicao(nCont).Height = VB6.TwipsToPixelsY(.CellHeight)
            Next nCont
			txtEdicao(1).Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(txtEdicao(1).Width) - VB6.PixelsToTwipsX(cmdDisponivel.Width))
			cmdDisponivel.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(txtEdicao(1).Height) - 30)
            cmdDisponivel.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(txtEdicao(1).Left) + VB6.PixelsToTwipsX(txtEdicao(1).Width))
            flxVeiculos.Tag = 0
			
			.Visible = True
		End With
		
		With flxExistente
			.Clear()
			.Rows = 1
			.Cols = 18
		End With
		
		
Saida: 
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
	End Sub
	
    Private Sub frmControleFita_Afiliada_Determinacao_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        asmxControleFita = NewControleFita()
        dtsDadosFita = New MSAClass.AsmxControleFita.dtsDadosFita
        dtsControleFita = New MSAClass.AsmxControleFita.dtsControleFita


        Call MontaFlex()
        txtEdicao(0).Enabled = False
    End Sub
	
	Private Sub CarregaVeiculosDoUsuario()
        On Error GoTo Erro

        DtsDadosFita = AsmxControleFita.spuCarregarVeiculosMidia(txtEmpresa(0).Text, Integer.Parse(txtContrato(0).Text), Short.Parse(txtSequencia(0).Text), txtComercial(0).Text, gsUsuario)
        nLin = 0
        With flxVeiculos
            For Each drwVeiculo As MSAClass.AsmxControleFita.dtsDadosFita.dtbMidiaVeiculoRow In dtsDadosFita.dtbMidiaVeiculo.Rows
                nLin = nLin + 1
                If nLin >= .Rows - 1 Then
                    .Rows = .Rows + 1
                End If
                .set_TextMatrix(nLin, 0, drwVeiculo.Cod_Veiculo)
            Next
        End With
		
		
		
Saida: 

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub



    Private Sub frmControleFita_Afiliada_Determinacao_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    End Sub
	

	Private Sub txtEdicao_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEdicao.TextChanged
		Dim Index As Short = txtEdicao.GetIndex(eventSender)
		Dim nLoop As Short
		On Error GoTo Erro
        '=====================================>Move para o Grid
        If flxVeiculos.Tag = 0 Then
            With flxVeiculos
                .set_TextMatrix(.Row, Index, txtEdicao(Index).Text)
            End With
        End If
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida

    End Sub
	
	
	Private Sub txtEdicao_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEdicao.Enter
		Dim Index As Short = txtEdicao.GetIndex(eventSender)
		seleciona_no_foco(txtEdicao(Index))
		bGravar = False
	End Sub
	
	
	Private Sub txtEdicao_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtEdicao.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
        Dim Index As Short = txtEdicao.GetIndex(eventSender)

		With flxVeiculos
			Select Case KeyCode
				Case 38 ' seta para cima
                    If .Row > 1 Then
                        Call txtEdicao_Validating(txtEdicao.Item(Index), New System.ComponentModel.CancelEventArgs(False))
                        If bValidaLinha Then
                            .Row = .Row - 1
                        End If
                    End If
				Case 40 ' seta para baixo
					If .Row < .Rows - 1 Then
                        Call txtEdicao_Validating(txtEdicao.Item(Index), New System.ComponentModel.CancelEventArgs(False))
						If bValidaLinha Then
							.Row = .Row + 1
						End If
					End If
			End Select
		End With
		
	End Sub
	
	
	Private Sub txtEdicao_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtEdicao.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = txtEdicao.GetIndex(eventSender)
		On Error GoTo Erro
		Dim nLoop As Short
		Dim bProximo As Boolean
		KeyAscii = Asc(UCase(Chr(KeyAscii)))
		'============================> Controle da Tecla Enter
		If KeyAscii = 13 Then
			With flxVeiculos
				bValidaLinha = False
                Call txtEdicao_Validating(txtEdicao.Item(Index), New System.ComponentModel.CancelEventArgs(False))
				If Not bValidaLinha Then
					GoTo Saida
				End If
				bProximo = False
				For nLoop = Index + 1 To txtEdicao.Count - 1
					If Not txtEdicao(nLoop).ReadOnly Then
						txtEdicao(nLoop).Focus()
						bProximo = True
						Exit For
					End If
				Next nLoop
				If Not bProximo Then
					If .Row = .Rows - 1 Then
						.Rows = .Rows + 1
						.Row = .Rows - 1
					Else
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
	
	
	Private Sub txtEdicao_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEdicao.Leave
		Dim Index As Short = txtEdicao.GetIndex(eventSender)
		
		Dim nRow As Short
		If bGravar Then
			If txtEdicao(Index).Text <> "" Then
				nCont = 0
				With flxVeiculos
					For nRow = 1 To .Rows - 1
						If Trim(.get_TextMatrix(nRow, 0)) <> "" Then
							nCont = nCont + 1
						End If
					Next nRow
				End With
				
				If nCont = 1 Then
					cmdOK_Click(cmdOK, New System.EventArgs())
				End If
			End If
		End If
	End Sub
	
	
	Private Sub txtEdicao_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtEdicao.Validating
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim Index As Short = txtEdicao.GetIndex(eventSender)
		
		On Error GoTo Erro
		bValidaLinha = True
		Dim nCol As Short
		Dim nRow As Short
		Dim sMens As String
		bGravar = False
		
		'=======================Se for Branco , nao consiste
		txtEdicao(Index).Text = Trim(txtEdicao(Index).Text)
		If txtEdicao(Index).Text = "" Then
			'If Index = 1 And txtEdicao(1).Tag <> "" Then
			'   RemoveGridExistente txtEdicao(1).Tag
			'   txtEdicao(1).Tag = ""
			'   flxExistente.Row = 0
			'   flxExistente_RowColChange
			'End If
			GoTo Saida
		End If
		
		If Index = 1 Then
			If VB.Left(txtEdicao(Index).Text, 2) <> "CO" Then
				txtEdicao(Index).Text = "CO" & VB6.Format(txtEdicao(Index).Text, "0000")
			End If
		End If
		
		'=======================Consiste conforme a coluna digitada e tipo de digitacao
		Select Case Index
			
			Case 0 ' Codigo do Veiculo
				
                'If Not TestaVeiculo(txtEdicao(0).Text) Then
                '	Cancel = True
                '	txtEdicao(Index).Text = ""
                '	GoTo Saida
                'End If
			Case 1 ' Numero da Fita
				If Trim(txtEdicao(0).Text) = "" Then
					Aviso("Código do Veiculo não foi Informado")
					txtEdicao(Index).Text = ""
					Cancel = True
					GoTo Saida
				End If
				
				If VB.Left(txtEdicao(Index).Text, 2) <> "CO" Then
					Aviso("Iniciais Inválida")
					Cancel = True
					txtEdicao(Index).Text = ""
					GoTo Saida
				End If
				
				
				'UPGRADE_WARNING: Couldn't resolve default property of object StrZero(Val(Mid(txtEdicao(Index), 3)), 4). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				txtEdicao(Index).Text = Mid(Trim(txtEdicao(Index).Text), 1, 2) & StrZero(Val(Mid(txtEdicao(Index).Text, 3)), 4)
				
				If txtEdicao(Index).Text <> txtEdicao(Index).Tag Then
					RemoveGridExistente(txtEdicao(1).Tag)
					AdicionaGridExistente(txtEdicao(1).Text, txtEdicao(0).Text)
				End If
				
				txtEdicao(Index).Tag = txtEdicao(Index).Text
				
				With flxExistente
					.Row = 0
					flxExistente_RowColChange(flxExistente, New System.EventArgs())
					For nRow = 1 To .Rows - 1
						If Trim(.get_TextMatrix(nRow, 14)) = txtEdicao(1).Text Then
							.Row = nRow
							Exit For
						End If
					Next nRow
				End With
				
				If Not ConsisteFita(txtEdicao(1).Text, txtEdicao(0).Text) Then
					Cancel = True
					txtEdicao(Index).Text = ""
					GoTo Saida
				End If
            Case 2 ' Localizacao
                If Trim(txtEdicao(1).Text) = "" Then
                    Aviso("Numero da Fita Não Foi Informado")
                    txtEdicao(Index).Text = ""
                    Cancel = True
                    GoTo Saida
                End If
        End Select
		
Saida: 
		If Cancel Then
            bValidaLinha = False
            txtEdicao(Index).Text = ""
			bGravar = True
		End If
		
		GoTo EventExitSub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
		
EventExitSub: 
		eventArgs.Cancel = Cancel
	End Sub

    Private Sub txtEdicao_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEdicao.Validated

    End Sub

    Private Sub _txtEdicao_0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _txtEdicao_0.TextChanged

    End Sub

    Private Sub cmdOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

    End Sub
End Class