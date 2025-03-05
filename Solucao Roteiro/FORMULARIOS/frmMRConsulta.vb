Public Class frmMRConsulta
#Region "Declaracoes"
    Public txtNegociacaoFiltro As String = ""
    Public txtCompetenciaFiltroDe As String = ""
    Public txtCompetenciaFiltroAte As String = ""
    Public txtAgenciaFiltro As String = ""
    Public txtClienteFiltro As String = ""
    Public txtVeiculoFiltro As String = ""
    Public txtContatoFiltro As String = ""
    Public txtNucleoFiltro As String = ""
    Public txtTipoMidiaFiltro As String = ""
    Public txtProdutoFiltro As String = ""
    Public txtPiFiltro As String = ""
    Public txtDataInclusaoFiltro As String = ""
    Public txtEmpresaFiltro As String = ""
    Public txtContratoFiltro As String = ""
    Public txtSequenciaFiltro As String = ""
    Public txtProgramaFiltro As String = ""
    Public txtTipoComercialFiltro As String = ""
    Public txtAbrangenciaFiltro As String = ""

    Public nAutorizadoFiltro As Integer = 0
    Public nPendenteCe As Integer = 0
    Public nMostraProduto As Integer = 0
    Public nMostraVeiculo As Integer = 0
    Public nValoracaoNormalEventoFiltro As Integer = 0
    Public nRejeitadoFiltro As Integer = 0
    Public nPendenteAutorizacao As Integer = 0
    Dim DTS As DataSet
    Dim bolCarregandoVeiculo As Boolean = False

    Public nContrato As Integer
    Public nSequencia As Integer
    Public LoadFromManutencao As Boolean

    'Dim bolCarregaDadosContrato As Boolean = False
    'Dim bolCarregaDadosComercial As Boolean = False
    'Dim bolCarregaDadosDemanda As Boolean = False
    'Dim bolCarregaDadosRealizavel As Boolean = False
    'Dim bolCarregaDadosVeiculacoes As Boolean = False

    Dim strchaveContrato As String = ""
    Dim strChaveDemanda As String = ""
    Dim strChaveRealizavel As String = ""
    Dim strChaveVeiculacao As String = ""
    Dim strChaveComercial As String = ""
    Dim strChaveVeiculo As String
    Public sFlag As String = ""

#End Region
    Public Sub New()
        InitializeComponent()
        Me.MdiParent = mdiPrincipal
        Me.Top = 10
        Me.Left = 10
    End Sub
    Public Sub Consulta_Ativa()
        Dim clsContrato As MSAClass.AsmxHistoricoMr.asmxHistoricoMr = NewHistoricoMr()
        Dim nInicio As Integer
        Dim nFim As Integer
        Dim nProduto As Integer
        Dim nAbrangencia As Integer
        strChaveComercial = ""
        strchaveContrato = ""
        strChaveDemanda = ""
        strChaveRealizavel = ""
        strChaveVeiculacao = ""

        Try
            If Not LoadFromManutencao Then
                frmMRConsultaFiltro.ShowDialog()
                If Not frmMRConsultaFiltro.OkClick Then
                    Exit Sub
                End If
                If sFlag.Trim = "" Then
                    MsgBox("Escolha uma opção de Filtro para Visualizar as Informações !", MsgBoxStyle.Critical)
                    Exit Sub
                End If


                If (txtCompetenciaFiltroDe).Trim <> "" Or (txtCompetenciaFiltroAte).Trim <> "" Then
                    nInicio = Val(txtCompetenciaFiltroDe.Substring(3, 4) + txtCompetenciaFiltroDe.Substring(0, 2))
                    nFim = Val(txtCompetenciaFiltroAte.Substring(3, 4) + txtCompetenciaFiltroAte.Substring(0, 2))
                Else
                    nInicio = 0
                    nFim = 0
                End If

                nContrato = Val(txtContratoFiltro)
                nSequencia = Val(txtSequenciaFiltro)
            End If

            nProduto = Val(txtProdutoFiltro)
            nAbrangencia = Val(txtAbrangenciaFiltro)
            If dtsEmpresaUsuario.Tables(0).Rows.Count = 0 Then
                MsgBox("Nenhum Empresa esta associada ao Usuário.Favor Solicitar ao Administrador do Sistema", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            DTS = clsContrato.fnHC(sEmpresadoUsuario, nInicio, nFim, txtEmpresaFiltro, nContrato, nSequencia, txtVeiculoFiltro, txtNegociacaoFiltro, txtNucleoFiltro, txtContatoFiltro, txtClienteFiltro, txtAgenciaFiltro, nProduto, txtPiFiltro, txtTipoMidiaFiltro, txtDataInclusaoFiltro, nAutorizadoFiltro, nPendenteCe, nMostraProduto, nMostraVeiculo, gsUsuario, nValoracaoNormalEventoFiltro, txtProgramaFiltro, nRejeitadoFiltro, nPendenteAutorizacao, txtTipoComercialFiltro, nAbrangencia)
            Me.Cursor = Cursors.Default
            If DTS.Tables(0).Rows.Count <= 0 Then
                MsgBox("Não existem informações disponíveis para o Filtro solicitado !", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If DTS.Tables(0).Rows.Count >= 500 Then
                MsgBox("Sua Consulta Retornou 500 ou mais Registros " + vbCrLf + _
                "Somente as 500 Primeiras serão Mostradas" + vbCrLf + "Favor Refinar a Pesquisa", _
                MsgBoxStyle.OkOnly, "Aviso")

            End If

            DTS.Tables(0).Columns.Add("Check_Am", GetType(Boolean))
            DTS.Tables(0).Columns.Add("Check_Cancelamento", GetType(Boolean))
            DTS.Tables(0).Columns.Add("Check_Ce", GetType(Boolean))


            For Each DRW As DataRow In DTS.Tables(0).Rows
                DRW("Check_Am") = DRW("Indica_Am_Pendente") = 1
                DRW("Check_Ce") = DRW("Indica_Ce_Pendente") = 1
                DRW("Check_Cancelamento") = Not IsDBNull(DRW("Data_Cancelamento"))
            Next

            Call EstiloGrid(dgvPrincipalContrato, 1)
            With dgvPrincipalContrato
                bdsContrato.DataSource = DTS.Tables(0)
                bdnContrato.BindingSource = bdsContrato
                .DataSource = bdsContrato

                .AutoResizeColumns()
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = True
                .RowHeadersVisible = True
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""

                For X As Integer = 0 To .Columns.Count - 1
                    .Columns(X).Visible = False
                Next

                .Columns("Numero_Negociacao").Visible = True
                .Columns("Cod_Empresa").Visible = True
                .Columns("Numero_mr").Visible = True
                .Columns("Sequencia_MR").Visible = True
                .Columns("Nome_Produto").Visible = True
                .Columns("Cod_Veiculo").Visible = True
                .Columns("Competencia").Visible = True
                .Columns("Periodo_Campanha_Inicio").Visible = True
                .Columns("Periodo_Campanha_Termino").Visible = True
                .Columns("Cod_Cliente").Visible = True
                .Columns("Cod_Agencia").Visible = True
                .Columns("Numero_PI").Visible = True
                .Columns("Data_Cancelamento").Visible = True
                .Columns("Check_Am").Visible = True
                .Columns("Check_Ce").Visible = True
                .Columns("Check_Cancelamento").Visible = True



                .Columns("Numero_Negociacao").HeaderText = "Negociacao"
                .Columns("Cod_Empresa").HeaderText = "Emp."
                .Columns("Numero_mr").HeaderText = "Contrato"
                .Columns("Sequencia_MR").HeaderText = "Seq"
                .Columns("Nome_Produto").HeaderText = "Produto"
                .Columns("Cod_Veiculo").HeaderText = "Veic."
                .Columns("Competencia").HeaderText = "Comp."
                .Columns("Periodo_Campanha_Inicio").HeaderText = "Inic.Campanha"
                .Columns("Periodo_Campanha_Termino").HeaderText = "Fim Campanha"
                .Columns("Cod_Cliente").HeaderText = "Cliente"
                .Columns("Cod_Agencia").HeaderText = "Agencia"
                .Columns("Numero_PI").HeaderText = "Numero_PI"
                .Columns("Data_Cancelamento").HeaderText = "Can"
                .Columns("Indica_Am_Pendente").HeaderText = "Am"
                .Columns("Indica_CE_Pendente").HeaderText = "Ce"
                .Columns("Check_Am").HeaderText = "Am Pendente"
                .Columns("Check_Ce").HeaderText = "Ce Pendente"
                .Columns("Check_Cancelamento").HeaderText = "CAN"

                .Columns("Numero_Negociacao").DisplayIndex = 0
                .Columns("Cod_Empresa").DisplayIndex = 1
                .Columns("Numero_mr").DisplayIndex = 2
                .Columns("Sequencia_MR").DisplayIndex = 3
                .Columns("Nome_Produto").DisplayIndex = 4
                .Columns("Cod_Veiculo").DisplayIndex = 5
                .Columns("Competencia").DisplayIndex = 6
                .Columns("Periodo_Campanha_Inicio").DisplayIndex = 7
                .Columns("Periodo_Campanha_Termino").DisplayIndex = 8
                .Columns("Cod_Cliente").DisplayIndex = 9
                .Columns("Cod_Agencia").DisplayIndex = 10
                .Columns("Numero_PI").DisplayIndex = 11
                .Columns("Data_Cancelamento").DisplayIndex = 12
                .Columns("Indica_Am_Pendente").DisplayIndex = 13
                .Columns("Indica_CE_Pendente").DisplayIndex = 14
                .Columns("Check_Am").DisplayIndex = 15
                .Columns("Check_Ce").DisplayIndex = 16
                .Columns("Check_Cancelamento").DisplayIndex = 17

                .Columns("Periodo_Campanha_Inicio").DefaultCellStyle.Format = "dd/MM/yyyy"
                .Columns("Periodo_Campanha_Termino").DefaultCellStyle.Format = "dd/MM/yyyy"




                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoResizeColumns()
            End With

        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub frmMRConsulta_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.BackColorChanged

    End Sub
    Private Sub frmMRConsulta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        MsgBox(txtNegociacao.Enabled)
    End Sub

    Private Sub frmMRConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMRConsultaFiltro.Dispose()
        If Me.LoadFromManutencao Then
            frmMapaReserva.Show()
        End If
        Me.Dispose()
        Me.LoadFromManutencao = False

    End Sub
    Private Sub frmMRConsulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 10
        Me.Left = 10
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltro.Click
        Call Consulta_Ativa()
    End Sub
    Private Sub bdsContrato_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdsContrato.CurrentChanged
        Try
            With bdsContrato
                If .Current Is Nothing Then
                    Exit Sub
                End If
                Carrega_Dados_Veiculo(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_MR"))
                If tbcGeral.SelectedIndex = 1 Then
                    Carrega_Dados_Contrato(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_MR"))
                ElseIf tbcGeral.SelectedIndex = 2 Then
                    Carrega_Dados_Comercial(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_MR"))
                ElseIf tbcGeral.SelectedIndex = 3 Then
                    Carrega_Midia_Demandado(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_MR"), cmbVeiculoD.Text, .Current("Competencia"))
                ElseIf tbcGeral.SelectedIndex = 4 Then
                    Carrega_Grid_Realizavel(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_MR"), cmbVeiculoR.Text, .Current("Competencia"))
                ElseIf tbcGeral.SelectedIndex = 5 Then
                    Carrega_Veiculacoes(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_MR"), cmbVeiculoV.Text)
                End If
            End With
            txtlblDescricao.Text = " Emp: " + bdsContrato.Current("Cod_Empresa").ToString _
                                   + " Contrato: " + bdsContrato.Current("Numero_mr").ToString + "/" + bdsContrato.Current("Sequencia_MR").ToString

            lblCompetenciaD.Text = fnCompetenciaNumeroToExtenso(bdsContrato.Current("Competencia"))
            lblCompetenciaR.Text = fnCompetenciaNumeroToExtenso(bdsContrato.Current("Competencia"))

        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    
    Private Sub tbcGeral_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcGeral.SelectedIndexChanged
        Call bdsContrato_CurrentChanged(New Object, New System.EventArgs)
    End Sub
    Public Sub Carrega_Dados_Contrato(ByVal pEmpresa As String, ByVal pContrato As Int32, ByVal pSequencia As Int16)
        Dim clsContrato As MSAClass.AsmxHistoricoMr.asmxHistoricoMr = NewHistoricoMr()
        Dim dtsDadosContrato As DataSet
        Dim drDataRow As DataRow
        Try
            If pEmpresa & pContrato.ToString & pSequencia.ToString = strchaveContrato Then
                Exit Sub
            End If

            dtsDadosContrato = clsContrato.fnHistoricoDadosContratos(pEmpresa, pContrato, pSequencia)
            If dtsDadosContrato.Tables(0).Rows.Count <= 0 Then
                MsgBox("Não existem informações disponíveis para o Filtro solicitado !", MsgBoxStyle.Critical)
            End If

            For Each drDataRow In dtsDadosContrato.Tables(0).Rows

                txtNegociacao.Text = drDataRow("Numero_Negociacao")
                txtEmpVenda.Text = drDataRow("Cod_Empresa")
                txtEmpFat.Text = drDataRow("Cod_Empresa_Faturamento")
                If Not IsDBNull(drDataRow("Numero_PI")) Then
                    txtNumeroPI.Text = drDataRow("Numero_PI")
                End If

                txtContrato.Text = drDataRow("Numero_mr")
                If Not IsDBNull(drDataRow("Data_Recepcao_Reserva")) Then
                    'txtDataRecepcao.Text = String.Format(drDataRow("Data_Recepcao_Reserva"), "dd/MM/yyyy")
                    txtDataRecepcao.Text = FormataData(drDataRow("Data_Recepcao_Reserva"))
                End If
                txtCodCliente.Text = drDataRow("Cod_Cliente")
                txtDescCliente.Text = drDataRow("Nome_Cliente")
                txtCodAgencia.Text = drDataRow("Cod_Agencia")
                txtDescAgencia.Text = drDataRow("Nome_Agencia")
                txtNucleo.Text = drDataRow("Cod_Nucleo")
                txtDescNucleo.Text = drDataRow("Nome_Nucleo")
                txtContato.Text = drDataRow("Cod_Contato")
                txtDescContato.Text = drDataRow("Nome_Contato")
                txtInicio.Text = FormataData(drDataRow("Periodo_Campanha_Inicio"))
                txtFim.Text = FormataData(drDataRow("Periodo_Campanha_Termino"))

                If Not IsDBNull(drDataRow("Data_Cadastramento")) Then
                    'txtCadData.Text = FormataData(drDataRow("Data_Cadastramento"))
                    txtCadData.Text = Format(drDataRow("Data_Cadastramento"), "dd/MM/yyyy hh:mm:ss")
                End If
                If Not IsDBNull(drDataRow("Cod_Usuario")) Then
                    txtCadpor.Text = drDataRow("Cod_Usuario")
                End If
                If Not IsDBNull(drDataRow("Caracteristica_Contrato")) Then
                    txtCaracContrato.Text = drDataRow("Caracteristica_Contrato")
                End If
                If Not IsDBNull(drDataRow("Obs_Roteiro")) Then
                    txtObs.Text = drDataRow("Obs_Roteiro")
                End If
                If Not IsDBNull(drDataRow("Data_Cancelamento")) Then
                    txtCancelamento.Text = drDataRow("Data_Cancelamento")
                End If
                If Not IsDBNull(drDataRow("Motivo_Cancelamento")) Then
                    txtMotivo.Text = drDataRow("Motivo_Cancelamento")
                End If

                chkNet.Checked = IIf(drDataRow("Indica_Grade") = 0, 1, 0)
                chkRede.Checked = IIf(drDataRow("Indica_Grade") = 1, 1, 0)
                chkLocal.Checked = IIf(drDataRow("Indica_Grade") = 2, 1, 0)

                Exit For
            Next
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
            strchaveContrato = pEmpresa & pContrato.ToString & pSequencia.ToString
        End Try
    End Sub
    Public Sub Carrega_Veiculacoes(ByVal pCodEmpresa As String, ByVal pNumeroMr As Int32, ByVal pSequenciaMr As Int16, ByVal pCodVeiculo As String, Optional ByVal Forcar As Boolean = False)

        Dim clsContrato As MSAClass.AsmxHistoricoMr.asmxHistoricoMr = NewHistoricoMr()
        Dim dtsDadosVeiculacoes As DataSet

            Try
            If Not Forcar Then
                If strChaveVeiculacao = pCodEmpresa.ToString & pNumeroMr.ToString & pSequenciaMr.ToString & pCodVeiculo Then
                    Exit Sub
                End If
            End If


            dtsDadosVeiculacoes = clsContrato.fnHistoricoVeiculacoes(pCodEmpresa, pNumeroMr, pSequenciaMr, pCodVeiculo)
         

                If dtsDadosVeiculacoes.Tables(0).Rows.Count <= 0 Then
                    Exit Sub
                End If

                dgvVeiculacoes.DataSource = dtsDadosVeiculacoes.Tables(0)

                Call EstiloGrid(dgvVeiculacoes, 1)
                With dgvVeiculacoes

                    .AutoResizeColumns()
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToResizeRows = False
                    .RowHeadersVisible = True
                    .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""




                    .Columns("Documento_De").DisplayIndex = 0
                    .Columns("Data_Exibicao").DisplayIndex = 1
                    .Columns("Cod_Programa").DisplayIndex = 2
                    .Columns("Chave_Acesso").DisplayIndex = 3
                    .Columns("Cod_Caracteristica").DisplayIndex = 4
                    .Columns("cod_comercial").DisplayIndex = 5
                    .Columns("Indica_Valoracao").DisplayIndex = 6
                    .Columns("Cod_Qualidade").DisplayIndex = 7
                    .Columns("Horario_Exibicao").DisplayIndex = 8
                    .Columns("Documento_Para").DisplayIndex = 9
                    .Columns("valor").DisplayIndex = 10
                    .Columns("vlr_informado").DisplayIndex = 11
                    .Columns("Numero_Ce").DisplayIndex = 12
                    .Columns("Data_Emissao_Ce").DisplayIndex = 13
                    .Columns("data_cadastramento").DisplayIndex = 14
                    .Columns("Indica_Estouro").DisplayIndex = 15
                    .Columns("cod_usuario").DisplayIndex = 16
                    .Columns("Cod_Usuario_Baixa").DisplayIndex = 17
                    .Columns("Data_Baixa").DisplayIndex = 18
                    .Columns("vlr_Tabela").DisplayIndex = 19
                    .Columns("tabela_negociada").DisplayIndex = 20
                    .Columns("vlr_tabela_vigente").DisplayIndex = 21
                    .Columns("tabela_vigente").DisplayIndex = 22


                    .Columns("Documento_De").HeaderText = "Am Soluçao"
                    .Columns("Data_Exibicao").HeaderText = "Data"
                    .Columns("Cod_Programa").HeaderText = "Programa"
                    .Columns("Chave_Acesso").HeaderText = "Ch.Ac."
                    .Columns("Cod_Caracteristica").HeaderText = "Car."
                    .Columns("cod_comercial").HeaderText = "Com."
                    .Columns("Indica_Valoracao").HeaderText = "Aut."
                    .Columns("Cod_Qualidade").HeaderText = "Qual."
                    .Columns("Horario_Exibicao").HeaderText = "Horário Exibição"
                    .Columns("Documento_Para").HeaderText = "Am.Falha"
                    .Columns("valor").HeaderText = "ValorNegociação"
                    .Columns("vlr_informado").HeaderText = "Vlr.Inf."
                    .Columns("Numero_Ce").HeaderText = "C.E."
                    .Columns("Data_Emissao_Ce").HeaderText = "Dt.Emissão"
                    .Columns("data_cadastramento").HeaderText = "Dt.Cad"
                    .Columns("Indica_Estouro").HeaderText = "TQP"
                    .Columns("cod_usuario").HeaderText = "Cadastrado Por"
                    .Columns("Cod_Usuario_Baixa").HeaderText = "Baixado Por"
                    .Columns("Data_Baixa").HeaderText = "Data da Baixa"
                    .Columns("vlr_Tabela").HeaderText = "Vlr.Tabela Negociada"
                    .Columns("tabela_negociada").HeaderText = "Tabela Negociada"
                    .Columns("vlr_tabela_vigente").HeaderText = "Vlr.Tabela Vigente"
                    .Columns("tabela_vigente").HeaderText = "Tabela Vigente"

                    .Columns("Cod_Reserva").Visible = False
                    .Columns("Indica_Grade").Visible = False
                    .Columns("Sequencia_tabela_vigente").Visible = False
                    .Columns("sequencia_negociada").Visible = False


                    .Columns("valor").DefaultCellStyle.Format = "##,##0.00"
                    .Columns("vlr_informado").DefaultCellStyle.Format = "##,##0.00"
                    .Columns("vlr_Tabela").DefaultCellStyle.Format = "##,##0.00"
                    .Columns("vlr_tabela_vigente").DefaultCellStyle.Format = "##,##0.00"

                    .Columns("valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("vlr_informado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("vlr_Tabela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("vlr_tabela_vigente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("Horario_Exibicao").DefaultCellStyle.Format = "HH:mm"
                .Columns("Data_Exibicao").DefaultCellStyle.Format = "dd/MM/yyyy"
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    .AutoResizeColumns()


                End With

            Catch ex As Exception
                ShowErro(ex)
            Finally
                Me.Cursor = Cursors.Default
                strChaveVeiculacao = pCodEmpresa.ToString & pNumeroMr.ToString & pSequenciaMr.ToString & pCodVeiculo
            End Try
    End Sub
    Public Sub Carrega_Dados_Comercial(ByVal pEmpresa As String, ByVal pContrato As Int32, ByVal pSequencia As Int16)

        Dim clsContrato As MSAClass.AsmxHistoricoMr.asmxHistoricoMr = NewHistoricoMr()
        Dim dtsDemandado As DataSet = Nothing
        Try
            If strChaveComercial = pEmpresa & pContrato.ToString & pSequencia.ToString Then
                Exit Sub
            End If

         

            dtsDemandado = clsContrato.fnHistoricoComerciais(pEmpresa, pContrato, pSequencia)
            If dtsDemandado.Tables(0).Rows.Count <= 0 Then
                Exit Sub
            End If
            dtsDemandado.Tables(0).Columns.Add("Check_Determinar", GetType(Boolean))
            For Each row As DataRow In dtsDemandado.Tables(0).Rows
                row.Item("Check_Determinar") = row.Item("indica_titulo_determinar") = 1
            Next

            dgvDadosComerciais.DataSource = dtsDemandado.Tables(0)

            Call EstiloGrid(dgvDadosComerciais, 1)
            With dgvDadosComerciais

                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = True
                .RowHeadersVisible = True
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""

                .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
                .Columns("cod_comercial").HeaderText = "Cód."
                .Columns("titulo_comercial").HeaderText = "Título"
                .Columns("duracao").HeaderText = "Dur."
                .Columns("numero_fita").HeaderText = "Fita"
                .Columns("cod_material").HeaderText = "Material"
                .Columns("cod_tipo_comercial").HeaderText = "Tipo"
                .Columns("cod_red_produto").HeaderText = "Prod."
                .Columns("nome_produto").HeaderText = "Nome do Produto"
                .Columns("indica_titulo_determinar").HeaderText = "A Determinar"
                .Columns("indica_titulo_determinar").Visible = False
                .Columns("Check_Determinar").HeaderText = "A Determinar"

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoResizeColumns()

            End With

        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
            strChaveComercial = pEmpresa & pContrato.ToString & pSequencia.ToString
        End Try
    End Sub
    Public Sub Carrega_Midia_Geral(ByRef dgvGeral As DataGridView, ByVal pCodEmpresa As String, ByVal pNumeroMr As Int32, ByVal pSequenciaMr As Int16, ByVal pCodVeiculo As String, ByVal pCompetencia As Int32)
        Dim clsContrato As MSAClass.AsmxHistoricoMr.asmxHistoricoMr = NewHistoricoMr()
        Dim dtsGeral As DataSet = Nothing
        Dim dtsTemp As DataSet = New DataSet
        Dim strDia As String
        Dim strColuna As String
        Dim intCompetencia As Integer = 0
        Dim intDiaSemana As Integer = 0
        Dim nQtd As Integer = 0
        Dim strDiaSemana As String = ""
        Dim strDataLinha As String = ""
        Dim btLastDay As Byte
        Dim dc As New DataGridViewTextBoxColumn
        Dim estilo_celula As New DataGridViewCellStyle
        Dim nContador As Integer = 0
        Dim nQtd_Total As Integer = 0
        Dim nValor_Total As Integer = 0
        Dim nQtd_Falha As Integer = 0
        Dim nValor_Falha As Integer = 0
        Dim nQtd_Encaixe As Integer = 0
        Dim nValor_Encaixe As Integer = 0
        Dim nValor As Integer = 0

        Try



            If tbcGeral.SelectedIndex = 3 Then
                If strChaveDemanda = pCodEmpresa & pNumeroMr.ToString + pSequenciaMr.ToString + pCodVeiculo + pCodEmpresa.ToString Then
                    Exit Sub
                End If
                dtsTemp = clsContrato.fnConsultaMidiaDemandada(pCodEmpresa, pNumeroMr, pSequenciaMr, pCodVeiculo, pCompetencia)
                dtsGeral = CriaDtsMidiaDemandada(dtsTemp)
                'dtsGeral = clsContrato.fnConsultaMidiaDemandada(pCodEmpresa, pNumeroMr, pSequenciaMr, pCodVeiculo, pCompetencia)
            Else
                If strChaveRealizavel = pCodEmpresa & pNumeroMr.ToString + pSequenciaMr.ToString + pCodVeiculo + pCodEmpresa.ToString Then
                    Exit Sub
                End If
                dtsGeral = clsContrato.fnConsultaMidiaRealizavel(pCodEmpresa, pNumeroMr, pSequenciaMr, pCodVeiculo, pCompetencia)
            End If
            If dtsGeral.Tables(0).Rows.Count <= 0 Then
                Exit Sub
            End If

            dgvGeral.DataSource = dtsGeral.Tables(0)
            btLastDay = LastDay(pCompetencia)

            With dgvGeral
                .ReadOnly = True
                If tbcGeral.SelectedIndex = 3 Then
                    .Columns("Indica_horario").Visible = False
                End If

                .Columns("VALOR_TOTAL").HeaderText = "Valor"
                .Columns("VALOR_TOTAL").Width = 100
                .Columns("VALOR_TOTAL").DefaultCellStyle.Format = "##,##0.00"
                .Columns("VALOR_TOTAL").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("VALOR_TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Qtd_Total").HeaderText = "Qtd"
                .Columns("Qtd_Total").Width = 50
                .Columns("Qtd_Total").DefaultCellStyle.Format = "##,###"
                .Columns("Qtd_Total").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("Qtd_Total").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("Qtd_Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .AllowUserToResizeColumns = False
                .AllowUserToAddRows = False
                .AllowUserToResizeRows = False
                .AllowUserToOrderColumns = False
                .RowHeadersVisible = True
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = False

                .Columns("Cod_Programa").HeaderText = "Programa"
                .Columns("Cod_Comercial").HeaderText = "Com."
                .Columns("Cod_Caracteristica").HeaderText = "C.V."
                .Columns("Cod_Programa").Width = 60
                .Columns("Cod_Comercial").Width = 30
                .Columns("Cod_Caracteristica").Width = 30
                .Columns("Cod_Comercial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Cod_Caracteristica").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersVisible = False
                For I As Integer = 1 To 31
                    strDia = I.ToString.PadLeft(2, "0")
                    strColuna = "Dia" & strDia
                    If I <= btLastDay Then
                        intDiaSemana = Weekday(FormatDateTime(I.ToString.PadLeft(2, "0") & "/" & pCompetencia.ToString.Substring(4, 2) & "/" & pCompetencia.ToString.Substring(0, 4), DateFormat.GeneralDate))
                        strDiaSemana = WeekdayName(intDiaSemana).ToUpper
                        .Columns(strColuna).HeaderText = " " & strDiaSemana.Substring(0, 1) & vbCrLf & strDia
                        .Columns(strColuna).Width = 24
                        .Columns(strColuna).Visible = True
                        .Columns(strColuna).SortMode = DataGridViewColumnSortMode.NotSortable
                    Else
                        .Columns(strColuna).Width = 0
                        .Columns(strColuna).Visible = False
                        strDiaSemana = ""
                    End If
                    If intDiaSemana = 1 Then
                        .EnableHeadersVisualStyles = False
                        .Columns(strColuna).HeaderCell.Style.ForeColor = Color.Red
                    End If
                    .Columns(strColuna).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Next
                For r As Integer = 0 To .Rows.Count - 1
                    For c As Integer = .Columns("dia01").Index To .Columns("dia31").Index
                        If .Item(c, r).Value = 0 Then
                            .Item(c, r).Value = DBNull.Value
                        Else

                            If tbcGeral.SelectedIndex = 3 Then
                                If .Item("Indica_Horario", r).Value = 0 Then
                                    .Item(c, r).Style.BackColor = Color.Red
                                    .Item(c, r).Style.ForeColor = Color.White
                                    .Item(c, r).Style.SelectionBackColor = Color.Red
                                    .Item(c, r).Style.SelectionForeColor = Color.White
                                Else
                                    .Item(c, r).Style.ForeColor = Color.Blue
                                    .Item(c, r).Style.SelectionForeColor = Color.Blue
                                End If
                            End If
                        End If
                    Next
                Next


            End With

            'Verifica se é Demandado ou Realizavel e roda a respectiva Proc
            If tbcGeral.SelectedIndex = 3 Then
                txtQtdTotD.Text = FormataNumero(Vernulo(dtsGeral.Tables(0).Compute("Sum(Qtd_Total)", Nothing), 0), 0)
                txtValTotD.Text = FormataNumero(Vernulo(dtsGeral.Tables(0).Compute("Sum(Valor_Total)", Nothing), 0), 2)

                txtQtdEncaixe.Text = FormataNumero(Vernulo(dtsGeral.Tables(0).Compute("Sum(Qtd_Total)", "Indica_Horario=1"), 0), 0)
                txtValorEncaixe.Text = FormataNumero(Vernulo(dtsGeral.Tables(0).Compute("Sum(Valor_Total)", "Indica_Horario=1"), 0), 2)

                txtQtdFalha.Text = FormataNumero(Vernulo(dtsGeral.Tables(0).Compute("Sum(Qtd_Total)", "Indica_Horario=0"), 0), 0)
                txtValorFalha.Text = FormataNumero(Vernulo(dtsGeral.Tables(0).Compute("Sum(Valor_Total)", "Indica_Horario=0"), 0), 2)
            Else
                txtQtdTotR.Text = FormataNumero(Vernulo(dtsGeral.Tables(0).Compute("Sum(Qtd_Total)", Nothing), 0), 0)
                txtValTotR.Text = FormataNumero(Vernulo(dtsGeral.Tables(0).Compute("Sum(Valor_Total)", Nothing), 0), 2)
            End If

        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
            If tbcGeral.SelectedIndex = 3 Then
                strChaveDemanda = pCodEmpresa & pNumeroMr.ToString + pSequenciaMr.ToString + pCodVeiculo + pCodEmpresa.ToString
            Else
                strChaveRealizavel = pCodEmpresa & pNumeroMr.ToString + pSequenciaMr.ToString + pCodVeiculo + pCodEmpresa.ToString
            End If
        End Try
    End Sub
    Public Sub Carrega_Dados_Veiculo(ByVal pCodEmpresa As String, ByVal pNumeroMr As Int32, ByVal pSequenciaMr As Int16)

        Dim clsContrato As MSAClass.AsmxHistoricoMr.asmxHistoricoMr = NewHistoricoMr()
        Dim dtsDadosVeiculo As DataSet
        bolCarregandoVeiculo = True
        Try
            If strChaveVeiculo = pCodEmpresa & pNumeroMr.ToString & pSequenciaMr.ToString Then
                Exit Sub
            End If
            dtsDadosVeiculo = clsContrato.fnHistoricoVeiculo(pCodEmpresa, pNumeroMr, pSequenciaMr)
            If dtsDadosVeiculo.Tables(0).Rows.Count <= 0 Then
                Exit Sub
            End If
            With cmbVeiculoD
                .DataSource = dtsDadosVeiculo.Tables(0)
                .DisplayMember = "Cod_Veiculo"
                .ValueMember = "Cod_Veiculo"
            End With
            With cmbVeiculoV
                .DataSource = dtsDadosVeiculo.Tables(0)
                .DisplayMember = "Cod_Veiculo"
                .ValueMember = "Cod_Veiculo"
            End With
            With cmbVeiculoR
                .DataSource = dtsDadosVeiculo.Tables(0)
                .DisplayMember = "Cod_Veiculo"
                .ValueMember = "Cod_Veiculo"
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            strChaveVeiculo = pCodEmpresa & pNumeroMr.ToString & pSequenciaMr.ToString
            Me.Cursor = Cursors.Default
            bolCarregandoVeiculo = False
        End Try
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()

    End Sub

    Private Sub dgvVeiculacoes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVeiculacoes.CellDoubleClick
        Dim bolPermissaoBaixa As Boolean
        Try
            If e.RowIndex >= 0 Then
                With dgvVeiculacoes
                    If e.ColumnIndex = .Columns("Documento_Para").Index Then
                        If Vernulo((.Item("Documento_Para", e.RowIndex).Value), "") <> "" Then
                            Me.Cursor = Cursors.WaitCursor
                            frmDadosAm.txtEmpresa.Text = bdsContrato.Current("Cod_Empresa")
                            frmDadosAm.txtContrato.Text = bdsContrato.Current("Numero_Mr")
                            frmDadosAm.txtSequencia.Text = bdsContrato.Current("Sequencia_Mr")
                            frmDadosAm.txtNumeroAM.Text = .Item("Documento_Para", e.RowIndex).Value
                            frmDadosAm.ShowDialog()
                            Me.Cursor = Cursors.Default
                        End If
                    End If

                    If e.ColumnIndex = .Columns("Documento_De").Index Then
                        If Vernulo((.Item("Documento_De", e.RowIndex).Value), "") <> "" Then
                            Me.Cursor = Cursors.WaitCursor
                            frmDadosAm.txtEmpresa.Text = bdsContrato.Current("Cod_Empresa")
                            frmDadosAm.txtContrato.Text = bdsContrato.Current("Numero_Mr")
                            frmDadosAm.txtSequencia.Text = bdsContrato.Current("Sequencia_Mr")
                            frmDadosAm.txtNumeroAM.Text = .Item("Documento_De", e.RowIndex).Value
                            frmDadosAm.ShowDialog()
                            Me.Cursor = Cursors.Default
                        End If
                    End If

                    If e.ColumnIndex = .Columns("Cod_Qualidade").Index Then
                        If Vernulo(.Item("Cod_Qualidade", e.RowIndex).Value, "") = "" Then
                            bolPermissaoBaixa = VePermissao(70)
                        Else
                            bolPermissaoBaixa = VePermissao(71)
                        End If

                        frmBaixaVeiculacao.txtVeiculo.Text = cmbVeiculoV.Text
                        frmBaixaVeiculacao.TxtData.Text = .Item("Data_Exibicao", e.RowIndex).Value
                        frmBaixaVeiculacao.txtPrograma.Text = .Item("Cod_Programa", e.RowIndex).Value
                        frmBaixaVeiculacao.txtChaveAcesso.Text = .Item("Chave_acesso", e.RowIndex).Value
                        frmBaixaVeiculacao.txtEmpresa.Text = bdsContrato.Current("Cod_Empresa")
                        frmBaixaVeiculacao.txtContrato.Text = bdsContrato.Current("Numero_Mr")
                        frmBaixaVeiculacao.txtSeq.Text = bdsContrato.Current("Sequencia_Mr")
                        frmBaixaVeiculacao.FormOrigem = Me.Name
                        frmBaixaVeiculacao.pubProssegueBaixa = True
                        frmBaixaVeiculacao.btnExibir_Click(New Object, New System.EventArgs)
                        frmBaixaVeiculacao.GroupBox1.Enabled = False

                        If frmBaixaVeiculacao.pubProssegueBaixa Then
                            frmBaixaVeiculacao.Show()
                        Else
                            frmBaixaVeiculacao.Dispose()

                        End If
                    End If
                End With
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub


    Private Sub cmbVeiculoR_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVeiculoR.TextChanged
        Try
            If Not bolCarregandoVeiculo Then
                Call bdsContrato_CurrentChanged(New Object, New System.EventArgs)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub cmbVeiculoD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVeiculoD.TextChanged
        Try
            If Not bolCarregandoVeiculo Then
                Call bdsContrato_CurrentChanged(New Object, New System.EventArgs)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub cmbVeiculoV_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVeiculoV.TextChanged
        Try
            If Not bolCarregandoVeiculo Then
                Call bdsContrato_CurrentChanged(New Object, New System.EventArgs)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Function CriaDtsMidiaDemandada(ByVal dtsOrigem As DataSet) As DataSet
        Dim dtsRetorno As DataSet = New DataSet
        Dim RowDestino() As DataRow = Nothing
        Dim RowTemp As DataRow
        Dim strColunaDia As String = ""
        Dim strColunaTipo As String = ""
        Dim bolNovaLinha As Boolean

        Dim strProcuraLinha As String = ""
        Try
            '=========================Cria tabela de retorno
            dtsRetorno.Tables.Add()
            With dtsRetorno.Tables(0)
                .Columns.Add("Cod_Programa", GetType(String))
                .Columns.Add("cod_comercial", GetType(String))
                .Columns.Add("cod_Caracteristica", GetType(String))
                For x As Integer = 1 To 31
                    .Columns.Add("Dia" & x.ToString.PadLeft(2, "0"), GetType(Integer))
                Next x
                For x As Integer = 1 To 31
                    .Columns.Add("Tipo" & x.ToString.PadLeft(2, "0"), GetType(Integer))
                Next x
                .Columns.Add("Valor_Total", GetType(Decimal))
                .Columns.Add("Qtd_Total", GetType(Decimal))

            End With

            '=========================Popula o Dataset 
            For Each RowOrigem As DataRow In dtsOrigem.Tables(0).Rows
                bolNovaLinha = False
                '============================================================Procura se ja existe a linha
                strProcuraLinha = "Cod_Programa = '" & RowOrigem.Item("Cod_Programa") & "'"
                strProcuraLinha += " and Cod_Comercial = '" & RowOrigem.Item("Cod_Comercial") & "'"
                strProcuraLinha += " and Cod_Caracteristica = '" & RowOrigem.Item("cod_Caracteristica") & "'"
                RowDestino = dtsRetorno.Tables(0).Select(strProcuraLinha)

                If RowDestino.Length = 0 Then
                    RowTemp = dtsRetorno.Tables(0).NewRow
                    bolNovaLinha = True
                Else
                    RowTemp = RowDestino(0)
                End If

                '============================================================Verifica se celula ja esta ocupado por tipo diferente
                strColunaDia = "Dia" & DatePart(DateInterval.Day, RowOrigem.Item("Data_Exibicao")).ToString.PadLeft(2, "0")
                strColunaTipo = "Tipo" & DatePart(DateInterval.Day, RowOrigem.Item("Data_Exibicao")).ToString.PadLeft(2, "0")

                If Not IsDBNull(RowTemp.Item(strColunaDia)) Then
                    If RowTemp.Item(strColunaTipo) <> RowOrigem.Item("Indica_Horario") Then
                        RowTemp = dtsRetorno.Tables(0).NewRow
                        bolNovaLinha = True
                    End If
                End If
                '============================================================Preenche a Linha

                With RowTemp
                    If bolNovaLinha Then
                        .Item("Cod_Programa") = RowOrigem.Item("Cod_Programa")
                        .Item("Cod_Comercial") = RowOrigem.Item("Cod_Comercial")
                        .Item("Cod_Caracteristica") = RowOrigem.Item("Cod_Caracteristica")
                        .Item(strColunaDia) = RowOrigem.Item("Qtd_Total")
                        .Item(strColunaTipo) = RowOrigem.Item("Indica_Horario")
                        .Item("Valor_Total") = Vernulo(RowOrigem.Item("Valor_Total"), 0)
                        .Item("Qtd_Total") = Vernulo(RowOrigem.Item("Qtd_Total"), 0)
                        dtsRetorno.Tables(0).Rows.Add(RowTemp)
                    Else
                        .Item(strColunaDia) = Vernulo(.Item(strColunaDia), 0) + Vernulo(RowOrigem.Item("Qtd_Total"), 0)
                        .Item("Valor_Total") = Vernulo(.Item("Valor_Total"), 0) + Vernulo(RowOrigem.Item("Valor_Total"), 0)
                        .Item("Qtd_Total") = Vernulo(.Item("Qtd_Total"), 0) + Vernulo(RowOrigem.Item("Qtd_Total"), 0)
                        .Item(strColunaTipo) = RowOrigem.Item("Indica_Horario")
                        dtsRetorno.AcceptChanges()
                    End If
                End With
            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try
        Return dtsRetorno

    End Function
    Public Sub Carrega_Grid_Realizavel(ByVal pCodEmpresa As String, ByVal pNumeroMr As Int32, ByVal pSequenciaMr As Int16, ByVal pCodVeiculo As String, ByVal pCompetencia As Int32)
        Dim clsContrato As MSAClass.AsmxHistoricoMr.asmxHistoricoMr = NewHistoricoMr()
        Dim dtsRealizavel As DataSet = Nothing
        Dim strDia As String
        Dim strColuna As String
        Dim intDiaSemana As Integer = 0
        Dim strDiaSemana As String = ""
        Dim btLastDay As Byte
        Try
            If strChaveRealizavel = pCodEmpresa & pNumeroMr.ToString + pSequenciaMr.ToString + pCodVeiculo + pCodEmpresa.ToString Then
                Exit Try
            End If
            dtsRealizavel = clsContrato.fnConsultaMidiaRealizavel(pCodEmpresa, pNumeroMr, pSequenciaMr, pCodVeiculo, pCompetencia)
            If dtsRealizavel.Tables(0).Rows.Count <= 0 Then
                Exit Sub
            End If
            dgvRealizavel.DataSource = dtsRealizavel.Tables(0)
            btLastDay = LastDay(pCompetencia)

            With dgvRealizavel
                .ReadOnly = True
                .Columns("VALOR_TOTAL").HeaderText = "Valor"
                .Columns("VALOR_TOTAL").Width = 100
                .Columns("VALOR_TOTAL").DefaultCellStyle.Format = "##,##0.00"
                .Columns("VALOR_TOTAL").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("VALOR_TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Qtd_Total").HeaderText = "Qtd"
                .Columns("Qtd_Total").Width = 50
                .Columns("Qtd_Total").DefaultCellStyle.Format = "##,###"
                .Columns("Qtd_Total").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("Qtd_Total").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("Qtd_Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .AllowUserToResizeColumns = False
                .AllowUserToAddRows = False
                .AllowUserToResizeRows = False
                .AllowUserToOrderColumns = False
                .RowHeadersVisible = True
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = False

                .Columns("Cod_Programa").HeaderText = "Programa"
                .Columns("Cod_Comercial").HeaderText = "Com."
                .Columns("Cod_Caracteristica").HeaderText = "C.V."
                .Columns("Cod_Programa").Width = 60
                .Columns("Cod_Comercial").Width = 30
                .Columns("Cod_Caracteristica").Width = 30
                .Columns("Cod_Comercial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Cod_Caracteristica").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersVisible = False
                For I As Integer = 1 To 31
                    strDia = I.ToString.PadLeft(2, "0")
                    strColuna = "Dia" & strDia
                    If I <= btLastDay Then
                        intDiaSemana = Weekday(FormatDateTime(I.ToString.PadLeft(2, "0") & "/" & pCompetencia.ToString.Substring(4, 2) & "/" & pCompetencia.ToString.Substring(0, 4), DateFormat.GeneralDate))
                        strDiaSemana = WeekdayName(intDiaSemana).ToUpper
                        .Columns(strColuna).HeaderText = " " & strDiaSemana.Substring(0, 1) & vbCrLf & strDia
                        .Columns(strColuna).Width = 24
                        .Columns(strColuna).Visible = True
                        .Columns(strColuna).SortMode = DataGridViewColumnSortMode.NotSortable
                    Else
                        .Columns(strColuna).Width = 0
                        .Columns(strColuna).Visible = False
                        strDiaSemana = ""
                    End If
                    If intDiaSemana = 1 Then
                        .EnableHeadersVisualStyles = False
                        .Columns(strColuna).HeaderCell.Style.ForeColor = Color.Red
                    End If
                    .Columns(strColuna).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Next
                For r As Integer = 0 To .Rows.Count - 1
                    For c As Integer = .Columns("dia01").Index To .Columns("dia31").Index
                        If .Item(c, r).Value = 0 Then
                            .Item(c, r).Value = DBNull.Value
                        Else

                            If tbcGeral.SelectedIndex = 3 Then
                                If .Item("Indica_Horario", r).Value = 0 Then
                                    .Item(c, r).Style.BackColor = Color.Red
                                    .Item(c, r).Style.ForeColor = Color.White
                                    .Item(c, r).Style.SelectionBackColor = Color.Red
                                    .Item(c, r).Style.SelectionForeColor = Color.White
                                Else
                                    .Item(c, r).Style.ForeColor = Color.Blue
                                    .Item(c, r).Style.SelectionForeColor = Color.Blue
                                End If
                            End If
                        End If
                    Next
                Next


            End With
            txtQtdTotR.Text = FormataNumero(Vernulo(dtsRealizavel.Tables(0).Compute("Sum(Qtd_Total)", Nothing), 0), 0)
            txtValTotR.Text = FormataNumero(Vernulo(dtsRealizavel.Tables(0).Compute("Sum(Valor_Total)", Nothing), 0), 2)

        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
            strChaveRealizavel = pCodEmpresa & pNumeroMr.ToString + pSequenciaMr.ToString + pCodVeiculo + pCodEmpresa.ToString
        End Try
    End Sub
    Public Sub Carrega_Midia_Demandado(ByVal pCodEmpresa As String, ByVal pNumeroMr As Int32, ByVal pSequenciaMr As Int16, ByVal pCodVeiculo As String, ByVal pCompetencia As Int32)
        Dim clsContrato As MSAClass.AsmxHistoricoMr.asmxHistoricoMr = NewHistoricoMr()
        Dim dtsDemandado As DataSet = Nothing
        Dim dtsTemp As DataSet = New DataSet
        Dim strDia As String
        Dim strColunaDia As String
        Dim strColunaTipo As String
        Dim intCompetencia As Integer = 0
        Dim intDiaSemana As Integer = 0
        Dim nQtd As Integer = 0
        Dim strDiaSemana As String = ""
        Dim strDataLinha As String = ""
        Dim btLastDay As Byte
        Dim dc As New DataGridViewTextBoxColumn
        Dim estilo_celula As New DataGridViewCellStyle
        Dim nContador As Integer = 0

        Dim nQtd_Total As Integer = 0
        Dim nValor_Total As Integer = 0
        Dim nQtd_Falha As Integer = 0
        Dim nValor_Falha As Integer = 0
        Dim nQtd_Encaixe As Integer = 0
        Dim nValor_Encaixe As Integer = 0
        Dim nValor As Integer = 0

        Try
            If strChaveDemanda = pCodEmpresa & pNumeroMr.ToString + pSequenciaMr.ToString + pCodVeiculo + pCodEmpresa.ToString Then
                Exit Sub
            End If
            dtsTemp = clsContrato.fnConsultaMidiaDemandada(pCodEmpresa, pNumeroMr, pSequenciaMr, pCodVeiculo, pCompetencia)
            dtsDemandado = CriaDtsMidiaDemandada(dtsTemp)

            If dtsDemandado.Tables(0).Rows.Count <= 0 Then
                Exit Sub
            End If

            dgvDemandado.DataSource = dtsDemandado.Tables(0)
            btLastDay = LastDay(pCompetencia)

            With dgvDemandado
                .ReadOnly = True

                .Columns("VALOR_TOTAL").HeaderText = "Valor"
                .Columns("VALOR_TOTAL").Width = 100
                .Columns("VALOR_TOTAL").DefaultCellStyle.Format = "##,##0.00"
                .Columns("VALOR_TOTAL").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("VALOR_TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .Columns("Qtd_Total").HeaderText = "Qtd"
                .Columns("Qtd_Total").Width = 50
                .Columns("Qtd_Total").DefaultCellStyle.Format = "##,###"
                .Columns("Qtd_Total").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("Qtd_Total").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("Qtd_Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                .AllowUserToResizeColumns = False
                .AllowUserToAddRows = False
                .AllowUserToResizeRows = False
                .AllowUserToOrderColumns = False
                .RowHeadersVisible = True
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = False

                .Columns("Cod_Programa").HeaderText = "Programa"
                .Columns("Cod_Comercial").HeaderText = "Com."
                .Columns("Cod_Caracteristica").HeaderText = "C.V."

                .Columns("Cod_Programa").Width = 60
                .Columns("Cod_Comercial").Width = 30
                .Columns("Cod_Caracteristica").Width = 30

                .Columns("Cod_Comercial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Cod_Caracteristica").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersVisible = False

                For I As Integer = 1 To 31
                    '==========================================Configura as colunas 
                    strDia = I.ToString.PadLeft(2, "0")
                    strColunaDia = "Dia" & strDia
                    strColunaTipo = "Tipo" & strDia
                    .Columns(strColunaTipo).Visible = False
                    If I <= btLastDay Then
                        intDiaSemana = Weekday(FormatDateTime(I.ToString.PadLeft(2, "0") & "/" & pCompetencia.ToString.Substring(4, 2) & "/" & pCompetencia.ToString.Substring(0, 4), DateFormat.GeneralDate))
                        strDiaSemana = WeekdayName(intDiaSemana).ToUpper
                        .Columns(strColunaDia).HeaderText = " " & strDiaSemana.Substring(0, 1) & vbCrLf & strDia
                        .Columns(strColunaDia).Width = 24
                        .Columns(strColunaDia).Visible = True
                        .Columns(strColunaDia).SortMode = DataGridViewColumnSortMode.NotSortable
                    Else
                        .Columns(strColunaDia).Width = 0
                        .Columns(strColunaDia).Visible = False
                        strDiaSemana = ""
                    End If

                    If intDiaSemana = 1 Then
                        .EnableHeadersVisualStyles = False
                        .Columns(strColunaDia).HeaderCell.Style.ForeColor = Color.Red
                    End If
                    .Columns(strColunaDia).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Next

                '==========================================Remove zero e coloca cor de status falha /exibido/

                For r As Integer = 0 To .Rows.Count - 1
                    For c As Integer = 1 To 31
                        strDia = c.ToString.PadLeft(2, "0")
                        strColunaDia = "Dia" & strDia
                        strColunaTipo = "Tipo" & strDia

                        If Not IsDBNull(.Item(strColunaDia, r).Value) Then
                            If .Item(strColunaTipo, r).Value = 0 Then
                                .Item(strColunaDia, r).Style.BackColor = Color.Red
                                .Item(strColunaDia, r).Style.ForeColor = Color.White
                                .Item(strColunaDia, r).Style.SelectionBackColor = Color.Red
                                .Item(strColunaDia, r).Style.SelectionForeColor = Color.White
                            Else
                                .Item(strColunaDia, r).Style.ForeColor = Color.Blue
                                .Item(strColunaDia, r).Style.SelectionForeColor = Color.Blue
                            End If
                        End If
                    Next
                Next


            End With

            txtQtdTotD.Text = FormataNumero(Vernulo(dtsTemp.Tables(0).Compute("Sum(Qtd_Total)", Nothing), 0), 0)
            txtValTotD.Text = FormataNumero(Vernulo(dtsTemp.Tables(0).Compute("Sum(Valor_Total)", Nothing), 0), 2)

            txtQtdEncaixe.Text = FormataNumero(Vernulo(dtsTemp.Tables(0).Compute("Sum(Qtd_Total)", "Indica_Horario=1"), 0), 0)
            txtValorEncaixe.Text = FormataNumero(Vernulo(dtsTemp.Tables(0).Compute("Sum(Valor_Total)", "Indica_Horario=1"), 0), 2)
            txtQtdFalha.Text = FormataNumero(Vernulo(dtsTemp.Tables(0).Compute("Sum(Qtd_Total)", "Indica_Horario=0"), 0), 0)
            txtValorFalha.Text = FormataNumero(Vernulo(dtsTemp.Tables(0).Compute("Sum(Valor_Total)", "Indica_Horario=0"), 0), 2)


        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
            strChaveDemanda = pCodEmpresa & pNumeroMr.ToString + pSequenciaMr.ToString + pCodVeiculo + pCodEmpresa.ToString
        End Try
    End Sub


End Class



