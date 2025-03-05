Public Class frmTerceiro_Cadastro
#Region "Declarações"
    Dim bConsistencia As Boolean = True
    Dim dtsTerceiro As New DataSet
    Dim strOperacao As eNumOperacao

    Public Enum eNumOperacao
        Incluir
        Editar
        Excluir
        Desativar
        Consultar
    End Enum
#End Region
#Region "Propriedades Customizadas"
    Public Property Operacao() As eNumOperacao
        Get
            Operacao = strOperacao
        End Get
        Set(ByVal value As eNumOperacao)
            strOperacao = value
            Select Case strOperacao
                Case eNumOperacao.Editar
                    txtCodTerceiro.Enabled = False
                    txtCNPF.Enabled = False
                    cboCNPF.Enabled = False
                Case eNumOperacao.Incluir
                    BdNavigator.Visible = False
                    btnDesativar.Visible = False
                Case eNumOperacao.Consultar
                    fraDados.Enabled = False
                    tabEndereco.Enabled = False
                    tabComplementar.Enabled = False
                    btnDesativar.Visible = False
                    btnTerceiro.BotaoOkVisible = False
            End Select
        End Set
    End Property
#End Region
#Region "Eventos do Form"
    Public Sub New()
        InitializeComponent()

        txtEmpresa.Usuario = gsUsuario
    End Sub
    Private Sub frmTerceiro_Cadastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            Me.CenterToScreen()
            LerPreferencia(Me)
            cboCNPF.SelectedIndex = 0
            txtCNPF.pFormatoSaida = WUC.UcText.FormatoSaida.CNPJ
            If Me.Operacao = eNumOperacao.Excluir Then
                txtCep_1.Text = ""
                txtCep_2.Text = ""
            End If

            If Me.Operacao = eNumOperacao.Editar Then
                If dtsEmpresaUsuario.Tables(0).Select("cod_empresa = '" & txtEmpresa.Text & "'").Length = 0 Then
                    Me.fraDados.Enabled = False
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub frmTerceiro_Cadastro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call SalvaPreferencia(Me)
    End Sub
#End Region
#Region "Evento dos Objetos "
    Private Sub optGrande_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optGrande.Click
        errTerceiro.Clear()
    End Sub
    Private Sub optMédio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optMédio.Click
        errTerceiro.Clear()
    End Sub
    Private Sub optPequeno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optPequeno.Click
        errTerceiro.Clear()
    End Sub
    Private Sub btnTerceiro_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTerceiro.Cancel_Click
        Me.Dispose()
    End Sub
    Private Sub btnTerceiro_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTerceiro.Ok_Click
        Dim clsTerceiro As MSAClass.AsmxTerceiro.asmxTerceiro = NewTerceiro()
        Dim bolErro As Boolean = False
        Dim bolAssociouEmpresa As Boolean = False
        Dim strEmpresa As String = ""
        Dim strRazaoSocial As String = ""
        Try
            bConsistencia = True
            '===========================Verifica se Contem Campos Obrigatorio Vazio
            Call ConsisteObrigatorio(Me)
            If Not bConsistencia Then
                bolErro = True
                Exit Sub
            End If
            '===========================Consiste Porte
            'If Not optGrande.Checked And Not optMédio.Checked And Not optPequeno.Checked Then
            ' errTerceiro.SetError(fraPorte, "Preencha uma das Opçoes do Porte da Agência")
            ' bolErro = True
            ' End If
            '===========================Consiste Campos
            If Me.Operacao = eNumOperacao.Incluir Then
                txtCodTerceiro.MensagemErro = clsTerceiro.fnConsisteCodigo(txtCodTerceiro.Text)
            End If
            txtCNPF.MensagemErro = clsTerceiro.fnConsisteCNPJ(txtCNPF.Text, txtCodTerceiro.Text, Me.Operacao.ToString)
            If txtCodTerceiro.MensagemErro.Trim <> "" Or txtCNPF.MensagemErro.Trim <> "" Or bolErro Then
                bolErro = True
                Exit Sub
            End If



            '===========================Acesso formulario de associaca empresas 
            bolAssociouEmpresa = False
            frmTerceiroEmpresa.ShowDialog()
            With frmTerceiroEmpresa
                If frmTerceiroEmpresa.OkClick Then
                    For Each Row As DataGridViewRow In .gridEmpresa.Rows
                        strEmpresa = .gridEmpresa.Item("Cod_Empresa", Row.Index).Value
                        strRazaoSocial = .gridEmpresa.Item("Razao_Social", Row.Index).Value

                        If .gridEmpresa.Item("Cod_Empresa", Row.Index).Value = txtEmpresa.Text Then
                            .gridEmpresa.Item("Check", Row.Index).Value = True
                        End If
                        If .gridEmpresa.Item("Check", Row.Index).Value Then
                            Call AtualizaEmpresa(strEmpresa, strRazaoSocial)
                            Call AtualizaTerceiroEndereco(strEmpresa)
                            Call AtualizaTerceiroComplementar(strEmpresa)
                            bolAssociouEmpresa = True
                        End If
                    Next
                End If
            End With
            frmTerceiroEmpresa.Dispose()
            '===========================Verifica se selecionou alguma Empresa
            If Not bolAssociouEmpresa Then
                Call AtualizaEmpresa(txtEmpresa.Text, txtEmpresa.Descricao)
                Aviso("Terceiro não foi validado para nenhuma empresa")
                Exit Sub
            End If
            '===========================Atualiza Dataset dados princiapl 
            Me.AtualizaTerceiroPrincipal()
            '========================Chama Funcao web para atualizacao
            If clsTerceiro.FnAtualizar(dtsTerceiro) Then
                Aviso("Dados Gravados com Sucesso")
                Select Case Me.Operacao
                    Case eNumOperacao.Incluir
                        Me.PreparaNovoCadastro()
                        dtsTerceiro.Clear()
                        Me.CarregaDataSet("")
                    Case eNumOperacao.Editar
                        Me.Dispose()
                End Select
            Else
                Aviso("Houve Erros na Gravação. Verifique !!")
                Exit Sub
            End If

        Catch ex As Exception
            ShowErro(ex)
        Finally
            If bolErro Then
                Aviso("Existem Campos Inconsistentes!" & vbCr & "Passe o Mouse sobre a marca  de erro para verificar")
            End If
        End Try
    End Sub

    Private Sub cboCNPF_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCNPF.SelectedIndexChanged
        Try
            txtCNPF.Text = ""
            Select Case cboCNPF.Text.ToUpper
                Case "CNPJ"
                    txtCNPF.pFormatoSaida = WUC.UcText.FormatoSaida.CNPJ
                Case "CPF"
                    txtCNPF.pFormatoSaida = WUC.UcText.FormatoSaida.CPF
            End Select
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub bdSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdSource.CurrentChanged
        Try
            If dtsTerceiro.Tables("Terceiro_Empresa").Rows.Count > 0 Then
                lblCod_Empresa.Text = bdSource.Current("Cod_Empresa")
                lblRazao_Social.Text = bdSource.Current("Razao_Social")
                Call CarregaDadosEndereco(lblCod_Empresa.Text)
                Call CarregaDadosComplementar(lblCod_Empresa.Text)
            Else
                lblCod_Empresa.Text = ""
                lblRazao_Social.Text = ""
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnDesativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesativar.Click
        Dim clsTerceiro As MSAClass.AsmxTerceiro.asmxTerceiro = NewTerceiro()
        Dim drw As DataRow() = Nothing
        Dim strQuery As String
        Try
            strQuery = "Cod_Empresa= '" & lblCod_Empresa.Text & "'"
            Select Case btnDesativar.Text.ToUpper
                Case "DESATIVAR"
                    frmTerceiroMotivoCancelamento.ShowDialog()
                    If frmTerceiroMotivoCancelamento.OkClick Then
                        drw = dtsTerceiro.Tables("Terceiro_Complementar").Select(strQuery)
                        If drw.Length > 0 Then
                            drw(0).Item("Data_Desativacao") = Now
                            drw(0).Item("Motivo_Desativacao") = frmTerceiroMotivoCancelamento.txtMotivoCancelamento.Text
                            drw(0).Item("indica_desativado") = 1
                            bdSource_CurrentChanged(Me.Handle, New EventArgs)
                            bdSource_CurrentChanged(Me.Handle, New EventArgs)
                            clsTerceiro.fnDesativarTerceiro(txtCodTerceiro.Text, lblCod_Empresa.Text, frmTerceiroMotivoCancelamento.txtMotivoCancelamento.Text, 0)
                        End If
                    End If
                Case "REATIVAR"
                    If Aviso("Confirma a Reativação do Terceiro", vbYesNo, vbQuestion, "Atenção") Then
                        drw = dtsTerceiro.Tables("Terceiro_Complementar").Select(strQuery)
                        drw(0).Item("Data_Desativacao") = DBNull.Value
                        drw(0).Item("Motivo_Desativacao") = DBNull.Value
                        drw(0).Item("indica_desativado") = 0
                        If drw.Length > 0 Then
                            drw(0).Item("Data_Desativacao") = DBNull.Value
                            bdSource_CurrentChanged(Me.Handle, New EventArgs)
                            clsTerceiro.fnDesativarTerceiro(txtCodTerceiro.Text, lblCod_Empresa.Text, "", 1)
                        End If
                    End If
            End Select
        Catch ex As Exception
            ShowErro(ex)
        Finally
            frmTerceiroMotivoCancelamento.Dispose()
        End Try
    End Sub
#End Region
#Region "Carrega Dados"
    Public Sub CarregaDataSet(ByVal pCod_Terceiro As String)
        Dim clsTerceiro As MSAClass.AsmxTerceiro.asmxTerceiro = NewTerceiro()
        Try
            dtsTerceiro = clsTerceiro.FnTerceiro_Carregar(pCod_Terceiro)
            Call CarregaDadosEmpresa(pCod_Terceiro)
            If Me.Operacao = eNumOperacao.Incluir Then
                dtsTerceiro.Clear()
            Else
                Call CarregaDadosPrincipais(pCod_Terceiro)
                Call CarregaDadosEmpresa(pCod_Terceiro)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaDadosPrincipais(ByVal pCod_Terceiro As String)
        Try
            '=========================================================================Dados Principais
            If dtsTerceiro.Tables("Terceiro").Rows.Count > 0 Then
                With dtsTerceiro.Tables("Terceiro").Rows(0)
                    txtCodTerceiro.Text = Vernulo(.Item("Cod_Terceiro"), "").ToString.Trim
                    txtRazaoSocial.Text = Vernulo(.Item("Razao_Social"), "").ToString.Trim
                    cboCNPF.SelectedIndex = Vernulo(.Item("Indica_Cic_Cgc"), "").ToString.Trim
                    If Vernulo(.Item("Indica_Cic_Cgc"), 0) = 0 Then
                        txtCNPF.Text = FormataCNPJ(.Item("CGC"))
                    Else
                        txtCNPF.Text = FormataCPF(.Item("CGC"))
                    End If
                    txtIE.Text = Vernulo(.Item("Inscricao_Estadual"), "").ToString.Trim
                    txtIM.Text = Vernulo(.Item("Inscricao_Municipal"), "").ToString.Trim
                    txtNomeFantasia.Text = Vernulo(.Item("Nome_Fantasia"), "").ToString.Trim
                    txtRamoAtividade.Text = Vernulo(.Item("Cod_Categoria"), "")
                    optGrande.Checked = Vernulo(.Item("Indica_Porte"), 0) = 1
                    optMédio.Checked = Vernulo(.Item("Indica_Porte"), 0) = 2
                    optPequeno.Checked = Vernulo(.Item("Indica_Porte"), 0) = 3
                    txtFuncao.Text = Vernulo(.Item("Funcao"), "")
                    txtEmpresa.Text = Vernulo(.Item("Cod_Empresa_Principal"), "")
                    chkEmissora.Checked = Vernulo(.Item("Indica_TV"), 0) = 1
                    chkRegional.Checked = Vernulo(.Item("indica_regional"), 0) = 1
                    chkAfiliada.Checked = Vernulo(.Item("indica_Afiliada"), 0) = 1
                    chkEstrangeiro.Checked = Vernulo(.Item("Indica_Estrangeiro"), 0) = 1
                    chkClienteDireto.Checked = Vernulo(.Item("Indica_Direto"), 0) = 1

                    txtRamoAtividade.Descricao = Vernulo(.Item("descricao_Categoria"), "").ToString.Trim
                    txtEmpresa.Descricao = Vernulo(.Item("Razao_Social_Empresa"), "").ToString.Trim
                    txtRamoAtividade.Descricao = Vernulo(.Item("Descricao_Categoria"), "").ToString.Trim
                    txtFuncao.Descricao = Vernulo(.Item("Descricao_funcao_Terceiro"), "").ToString.Trim
                End With


            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaDadosEndereco(ByVal pCod_Empresa As String)
        Dim RowEndereco() As DataRow = Nothing
        Dim strQuery As String
        strQuery = "Cod_Empresa='" & pCod_Empresa & "'"
        Try
            If Me.Operacao = eNumOperacao.Editar Then
                LimpaCampos(tabEndereco)
            End If
            RowEndereco = dtsTerceiro.Tables("Terceiro_Endereco").Select(strQuery)
            If RowEndereco.Length > 0 Then
                txtEndereco_1.Text = Vernulo(RowEndereco(0).Item("Endereco1"), "").ToString.Trim
                txtNumero_1.Text = Vernulo(RowEndereco(0).Item("Numero1"), "").ToString.Trim
                txtBairro_1.Text = Vernulo(RowEndereco(0).Item("Bairro1"), "").ToString.Trim
                txtMunicipio_1.Text = Vernulo(RowEndereco(0).Item("Municipio1"), "").ToString.Trim
                txtUf_1.Text = Vernulo(RowEndereco(0).Item("UF1"), "").ToString.Trim
                txtCep_1.Text = FormataCep(Vernulo(RowEndereco(0).Item("Cep1"), "")).ToString.Trim
                txtComplemento_1.Text = Vernulo(RowEndereco(0).Item("Complemento1"), "").ToString.Trim

                txtEndereco_2.Text = Vernulo(RowEndereco(0).Item("Endereco2"), "").ToString.Trim
                txtNumero_2.Text = Vernulo(RowEndereco(0).Item("Numero2"), "").ToString.Trim
                txtBairro_2.Text = Vernulo(RowEndereco(0).Item("Bairro2"), "").ToString.Trim
                txtMunicipio_2.Text = Vernulo(RowEndereco(0).Item("Municipio2"), "").ToString.Trim
                txtUf_2.Text = Vernulo(RowEndereco(0).Item("UF2"), "").ToString.Trim
                txtCep_2.Text = FormataCep(Vernulo(RowEndereco(0).Item("Cep2"), "")).ToString.Trim
                txtComplemento_2.Text = Vernulo(RowEndereco(0).Item("Complemento2"), "").ToString.Trim

                txtTelefone.Text = Vernulo(RowEndereco(0).Item("Telefone"), "").ToString.Trim
                txtFax.Text = Vernulo(RowEndereco(0).Item("Fax"), "").ToString.Trim
                txtEmail.Text = Vernulo(RowEndereco(0).Item("Email"), "").ToString.Trim
                txtPracaPagto.Text = Vernulo(RowEndereco(0).Item("Praca_Pgto"), "").ToString.Trim
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaDadosComplementar(ByVal pCod_Empresa As String)
        Dim RowComplementar() As DataRow = Nothing
        Dim strQuery As String
        Try
            If Me.Operacao = eNumOperacao.Editar Then
                LimpaCampos(tabComplementar)
            End If
            strQuery = "Cod_Empresa='" & pCod_Empresa & "'"
            RowComplementar = dtsTerceiro.Tables("Terceiro_Complementar").Select(strQuery)
            If RowComplementar.Length > 0 Then
                txtNomeContato.Text = Vernulo(RowComplementar(0).Item("Nome_Contato"), "").ToString.Trim
                txtEmail1.Text = Vernulo(RowComplementar(0).Item("Email_Contato"), "").ToString.Trim
                txtTelefone1.Text = Vernulo(RowComplementar(0).Item("Telefone_Contato_1"), "").ToString.Trim
                txtTelefone2.Text = Vernulo(RowComplementar(0).Item("Telefone_Contato_2"), "").ToString.Trim
                txtTelefone3.Text = Vernulo(RowComplementar(0).Item("Telefone_Contato_Compl_1"), "").ToString.Trim
                txtTelefone4.Text = Vernulo(RowComplementar(0).Item("Telefone_Contato_Compl_2"), "").ToString.Trim
                txtContato2.Text = Vernulo(RowComplementar(0).Item("Nome_Contato_Compl"), "").ToString.Trim
                txtEmail2.Text = Vernulo(RowComplementar(0).Item("Email_Contato_Compl"), "").ToString.Trim
                txtSubContaCSC.Text = Vernulo(RowComplementar(0).Item("Conta_Contabil"), "").ToString.Trim
                txtSubConta.Text = Vernulo(RowComplementar(0).Item("sub_conta"), "").ToString.Trim
                txtGrupoCLiente.Text = Vernulo(RowComplementar(0).Item("Grupo_Cliente"), "").ToString.Trim
                txtRepresentante.Text = Vernulo(RowComplementar(0).Item("Cod_Representante"), "").ToString.Trim
                txtBancoPreferencial.Text = Vernulo(RowComplementar(0).Item("Cod_Banco"), "").ToString.Trim

                chkMerchandising.Checked = Vernulo(RowComplementar(0).Item("Indica_Merchandising"), 0) = 1
                chkIn480.Checked = Vernulo(RowComplementar(0).Item("Indica_IN480"), 0) = 1

                If Not IsDBNull(RowComplementar(0).Item("Data_Desativacao")) Then
                    lblStatus.Text = "Status: Desativado em " & FormatDateTime(RowComplementar(0).Item("Data_Desativacao"), DateFormat.GeneralDate)
                    lblStatus.ForeColor = Color.Red
                    lblStatus.Font = New Font(lblCod_Empresa.Font, FontStyle.Bold)
                    btnDesativar.Text = "Reativar"
                Else
                    btnDesativar.Text = "Desativar"
                    lblStatus.Text = "Status: Ativo"
                    lblStatus.ForeColor = Color.Blue
                    lblStatus.Font = New Font(lblCod_Empresa.Font, FontStyle.Bold)
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaDadosEmpresa(ByVal pCod_Terceiro As String)
        Try
            If Not dtsTerceiro Is Nothing Then
                bdSource.DataSource = dtsTerceiro.Tables("Terceiro_Empresa")
                BdNavigator.BindingSource = bdSource
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
#End Region
#Region "Subs"
    Private Sub AtualizaEmpresa(ByVal pCod_Empresa As String, ByVal pRazaoSocial As String)
        Dim drw() As DataRow = Nothing
        Dim RowEmpresa As DataRow = Nothing
        Try
            '========================Terceiro Empresa
            drw = dtsTerceiro.Tables("Terceiro_Empresa").Select("Cod_Empresa = '" & pCod_Empresa & "'")
            If drw.Length = 0 Then
                RowEmpresa = dtsTerceiro.Tables("Terceiro_Empresa").NewRow
                RowEmpresa.Item("Cod_Empresa") = pCod_Empresa
                RowEmpresa.Item("Razao_Social") = pRazaoSocial
                dtsTerceiro.Tables("Terceiro_Empresa").Rows.Add(RowEmpresa)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub AtualizaTerceiroEndereco(ByVal pCod_Empresa As String)
        Dim drw() As DataRow
        Dim RowEndereco As DataRow = Nothing
        Try
            '==========================Terceiro Endereco
            drw = dtsTerceiro.Tables("Terceiro_Endereco").Select("Cod_Empresa = '" & pCod_Empresa & "'")
            If drw.Length = 0 Then
                RowEndereco = dtsTerceiro.Tables("Terceiro_Endereco").NewRow
                dtsTerceiro.Tables("Terceiro_Endereco").Rows.Add(RowEndereco)
            Else
                RowEndereco = drw(0)
            End If
            RowEndereco.Item("Cod_Terceiro") = txtCodTerceiro.Text
            RowEndereco.Item("Cod_Empresa") = pCod_Empresa
            RowEndereco.Item("Endereco1") = txtEndereco_1.Text
            RowEndereco.Item("Numero1") = txtNumero_1.Text
            RowEndereco.Item("Bairro1") = txtBairro_1.Text
            RowEndereco.Item("Municipio1") = txtMunicipio_1.Text
            RowEndereco.Item("UF1") = txtUf_1.Text
            RowEndereco.Item("Cep1") = txtCep_1.Text
            RowEndereco.Item("Complemento1") = txtComplemento_1.Text
            RowEndereco.Item("Endereco2") = txtEndereco_2.Text
            RowEndereco.Item("Numero2") = txtNumero_2.Text
            RowEndereco.Item("Bairro2") = txtBairro_2.Text
            RowEndereco.Item("Municipio2") = txtMunicipio_2.Text
            RowEndereco.Item("UF2") = txtUf_2.Text
            RowEndereco.Item("Cep2") = txtCep_2.Text
            RowEndereco.Item("Complemento2") = txtComplemento_2.Text
            RowEndereco.Item("Telefone") = txtTelefone.Text
            RowEndereco.Item("Fax") = txtFax.Text
            RowEndereco.Item("Email") = txtEmail.Text
            RowEndereco.Item("Praca_Pgto") = txtPracaPagto.Text

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub AtualizaTerceiroPrincipal()
        Dim drw As DataRow = Nothing
        Dim strCNPJ As String
        Try
            If dtsTerceiro.Tables("Terceiro").Rows.Count > 0 Then
                drw = dtsTerceiro.Tables("Terceiro").Rows(0)
            Else
                drw = dtsTerceiro.Tables("Terceiro").NewRow
                dtsTerceiro.Tables("Terceiro").Rows.Add(drw)
            End If

            strCNPJ = txtCNPF.Text
            strCNPJ = strCNPJ.Replace("/", "")
            strCNPJ = strCNPJ.Replace(".", "")
            strCNPJ = strCNPJ.Replace("-", "")

            drw.Item("Cod_Terceiro") = txtCodTerceiro.Text
            drw.Item("Razao_Social") = txtRazaoSocial.Text
            drw.Item("Funcao") = txtFuncao.Text
            drw.Item("CGC") = strCNPJ
            drw.Item("Inscricao_Estadual") = txtIE.Text
            drw.Item("Inscricao_Municipal") = txtIM.Text
            drw.Item("Indica_Cic_Cgc") = cboCNPF.SelectedIndex
            drw.Item("Indica_TV") = IIf(chkEmissora.Checked, 1, 0)
            drw.Item("Indica_Afiliada") = IIf(chkAfiliada.Checked, 1, 0)
            drw.Item("indica_regional") = IIf(chkRegional.Checked, 1, 0)
            drw.Item("Cod_Empresa_Principal") = txtEmpresa.Text
            drw.Item("Indica_Estrangeiro") = IIf(chkEstrangeiro.Checked, 1, 0)
            drw.Item("Nome_Fantasia") = txtNomeFantasia.Text

            If Me.Operacao = eNumOperacao.Incluir Then
                drw.Item("Data_Cadastramento") = Now
            End If
            If Me.Operacao = eNumOperacao.Editar Then
                drw.Item("Data_Alteracao") = Now
            End If
            drw.Item("Cod_Categoria") = txtRamoAtividade.Text
            Select Case True
                Case optPequeno.Checked
                    drw.Item("Indica_Porte") = 3
                Case optMédio.Checked
                    drw.Item("Indica_Porte") = 2
                Case optGrande.Checked
                    drw.Item("Indica_Porte") = 1
            End Select
            drw.Item("Indica_Direto") = IIf(chkClienteDireto.Checked, 1, 0)
            'drw.Item("Indica_Foi_Integrado") = ""
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub AtualizaTerceiroComplementar(ByVal pCod_Empresa As String)
        Dim drw() As DataRow
        Dim RowComplemento As DataRow = Nothing
        Try
            '==========================Terceiro Complementar
            drw = dtsTerceiro.Tables("Terceiro_Complementar").Select("Cod_Empresa = '" & pCod_Empresa & "'")
            If drw.Length = 0 Then
                RowComplemento = dtsTerceiro.Tables("Terceiro_Complementar").NewRow
                dtsTerceiro.Tables("Terceiro_Complementar").Rows.Add(RowComplemento)
            Else
                RowComplemento = drw(0)
            End If
            RowComplemento.Item("Cod_Terceiro") = txtCodTerceiro.Text
            RowComplemento.Item("Cod_Empresa") = pCod_Empresa
            RowComplemento.Item("Nome_Contato") = txtNomeContato.Text
            RowComplemento.Item("Email_Contato") = txtEmail1.Text
            RowComplemento.Item("Telefone_Contato_1") = txtTelefone1.Text
            RowComplemento.Item("Telefone_Contato_2") = txtTelefone2.Text
            RowComplemento.Item("Telefone_Contato_Compl_1") = txtTelefone3.Text
            RowComplemento.Item("Telefone_Contato_Compl_2") = txtTelefone4.Text
            RowComplemento.Item("Nome_Contato_Compl") = txtContato2.Text
            RowComplemento.Item("Email_Contato_Compl") = txtEmail2.Text
            If txtSubConta.Text <> "" Then
                RowComplemento.Item("Conta_Contabil") = txtSubContaCSC.Text
            End If
            If txtSubConta.Text <> "" Then
                RowComplemento.Item("sub_conta") = txtSubConta.Text
            End If
            If txtGrupoCLiente.Text <> "" Then
                RowComplemento.Item("Grupo_Cliente") = txtGrupoCLiente.Text
            End If
            If txtRepresentante.Text <> "" Then
                RowComplemento.Item("Cod_Representante") = txtRepresentante.Text
            End If
            RowComplemento.Item("Cod_Banco") = txtBancoPreferencial.Text
            RowComplemento.Item("Indica_Merchandising") = chkMerchandising.Checked
            RowComplemento.Item("Indica_IN480") = chkIn480.Checked

            Select Case Me.Operacao
                Case eNumOperacao.Incluir
                    RowComplemento.Item("Data_Inclusao") = Now
                Case eNumOperacao.Editar
                    RowComplemento.Item("Data_Alteracao") = Now
            End Select

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Function ConsisteObrigatorio(ByVal pControl As Control) As Boolean
        Dim ctrTxt As New WUC.UcText
        Try
            For Each Ctr As Control In pControl.Controls
                If TypeOf (Ctr) Is WUC.UcText Then
                    ctrTxt = Ctr
                    If ctrTxt.Obrigatorio And ctrTxt.Text.Trim = "" Then
                        ctrTxt.MensagemErro = "Campo de Preenchimento Obrigatório"
                        bConsistencia = False
                    End If
                End If
                If Ctr.HasChildren Then
                    Call ConsisteObrigatorio(Ctr)
                End If
            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Private Sub PreparaNovoCadastro()
        Try
            dtsTerceiro.Clear()
            Call LimpaCampos(Me)
            cboCNPF.SelectedIndex = 0

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
  
#End Region
 
 
End Class