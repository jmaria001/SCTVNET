<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMapaReserva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMapaReserva))
        Me.btnOpcoes = New System.Windows.Forms.ToolStrip
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton
        Me.bntNovo = New System.Windows.Forms.ToolStripButton
        Me.btnNovaSequencia = New System.Windows.Forms.ToolStripButton
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSair = New System.Windows.Forms.ToolStripButton
        Me.tabVeiculacao = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotalGeral = New System.Windows.Forms.Label
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.lblVeiculo = New System.Windows.Forms.Label
        Me.btnRepetir = New System.Windows.Forms.Button
        Me.btnVeiculo = New System.Windows.Forms.Button
        Me.gridVeiculacao = New SCTVNET.CustomGrid(Me.components)
        Me.tabDados = New System.Windows.Forms.TabPage
        Me.txtNegociacao = New WUC.UcText
        Me.txtInicioCampanha = New WUC.UcText
        Me.txtCaracteristica = New WUC.UcText
        Me.txtEmpresaFaturamento = New WUC.UcText
        Me.fraAbrangencia = New System.Windows.Forms.GroupBox
        Me.optLocal = New System.Windows.Forms.RadioButton
        Me.optRede = New System.Windows.Forms.RadioButton
        Me.optNet = New System.Windows.Forms.RadioButton
        Me.txtContato = New WUC.UcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtObservacao = New System.Windows.Forms.TextBox
        Me.txtFimCampanha = New WUC.UcText
        Me.txtEmpresa = New WUC.UcText
        Me.txtTipoMidia = New WUC.UcText
        Me.txtNucleo = New WUC.UcText
        Me.txtAgencia = New WUC.UcText
        Me.txtCliente = New WUC.UcText
        Me.txtDataRecepcao = New WUC.UcText
        Me.txtNumeroPi = New WUC.UcText
        Me.txtSequenciaMr = New WUC.UcText
        Me.txtNumeroMr = New WUC.UcText
        Me.tabContrato = New System.Windows.Forms.TabControl
        Me.tabComercial = New System.Windows.Forms.TabPage
        Me.btnComercialExcluir = New System.Windows.Forms.Button
        Me.btnComercialAdicionar = New System.Windows.Forms.Button
        Me.gridComercial = New System.Windows.Forms.DataGridView
        Me.btnComercialEditar = New System.Windows.Forms.Button
        Me.errMr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblErro = New System.Windows.Forms.Label
        Me.btnOpcoes.SuspendLayout()
        Me.tabVeiculacao.SuspendLayout()
        CType(Me.gridVeiculacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.fraAbrangencia.SuspendLayout()
        Me.tabContrato.SuspendLayout()
        Me.tabComercial.SuspendLayout()
        CType(Me.gridComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errMr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpcoes
        '
        Me.btnOpcoes.BackColor = System.Drawing.SystemColors.Control
        Me.btnOpcoes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.btnOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalvar, Me.bntNovo, Me.btnNovaSequencia, Me.btnEditar, Me.btnCancelar, Me.ToolStripSeparator1, Me.btnSair})
        Me.btnOpcoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.btnOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.btnOpcoes.Name = "btnOpcoes"
        Me.btnOpcoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.btnOpcoes.Size = New System.Drawing.Size(1010, 52)
        Me.btnOpcoes.TabIndex = 6
        Me.btnOpcoes.Text = "ToolStrip1"
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(65, 49)
        Me.btnSalvar.Text = "    Salvar    "
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bntNovo
        '
        Me.bntNovo.Image = CType(resources.GetObject("bntNovo.Image"), System.Drawing.Image)
        Me.bntNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntNovo.Name = "bntNovo"
        Me.bntNovo.Size = New System.Drawing.Size(65, 49)
        Me.bntNovo.Text = "Novo Mapa"
        Me.bntNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnNovaSequencia
        '
        Me.btnNovaSequencia.Image = CType(resources.GetObject("btnNovaSequencia.Image"), System.Drawing.Image)
        Me.btnNovaSequencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovaSequencia.Name = "btnNovaSequencia"
        Me.btnNovaSequencia.Size = New System.Drawing.Size(88, 49)
        Me.btnNovaSequencia.Text = "Nova Sequencia"
        Me.btnNovaSequencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(57, 49)
        Me.btnEditar.Text = "   Editar   "
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(59, 49)
        Me.btnCancelar.Text = " Cancelar "
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(47, 49)
        Me.btnSair.Text = "   Sair   "
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tabVeiculacao
        '
        Me.tabVeiculacao.Controls.Add(Me.Label2)
        Me.tabVeiculacao.Controls.Add(Me.lblTotalGeral)
        Me.tabVeiculacao.Controls.Add(Me.btnLimpar)
        Me.tabVeiculacao.Controls.Add(Me.lblVeiculo)
        Me.tabVeiculacao.Controls.Add(Me.btnRepetir)
        Me.tabVeiculacao.Controls.Add(Me.btnVeiculo)
        Me.tabVeiculacao.Controls.Add(Me.gridVeiculacao)
        Me.tabVeiculacao.Location = New System.Drawing.Point(4, 22)
        Me.tabVeiculacao.Name = "tabVeiculacao"
        Me.tabVeiculacao.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVeiculacao.Size = New System.Drawing.Size(991, 451)
        Me.tabVeiculacao.TabIndex = 2
        Me.tabVeiculacao.Text = "Veiculação"
        Me.tabVeiculacao.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(864, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Total Geral"
        '
        'lblTotalGeral
        '
        Me.lblTotalGeral.BackColor = System.Drawing.Color.White
        Me.lblTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalGeral.Location = New System.Drawing.Point(929, 400)
        Me.lblTotalGeral.Name = "lblTotalGeral"
        Me.lblTotalGeral.Size = New System.Drawing.Size(56, 23)
        Me.lblTotalGeral.TabIndex = 16
        Me.lblTotalGeral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(126, 400)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(114, 33)
        Me.btnLimpar.TabIndex = 15
        Me.btnLimpar.TabStop = False
        Me.btnLimpar.Text = "&Limpar Linha"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'lblVeiculo
        '
        Me.lblVeiculo.BackColor = System.Drawing.Color.White
        Me.lblVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVeiculo.ForeColor = System.Drawing.Color.Blue
        Me.lblVeiculo.Location = New System.Drawing.Point(366, 403)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(223, 27)
        Me.lblVeiculo.TabIndex = 14
        Me.lblVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRepetir
        '
        Me.btnRepetir.Location = New System.Drawing.Point(6, 400)
        Me.btnRepetir.Name = "btnRepetir"
        Me.btnRepetir.Size = New System.Drawing.Size(114, 33)
        Me.btnRepetir.TabIndex = 12
        Me.btnRepetir.TabStop = False
        Me.btnRepetir.Text = "&Repetir no Período"
        Me.btnRepetir.UseVisualStyleBackColor = True
        '
        'btnVeiculo
        '
        Me.btnVeiculo.Location = New System.Drawing.Point(246, 400)
        Me.btnVeiculo.Name = "btnVeiculo"
        Me.btnVeiculo.Size = New System.Drawing.Size(114, 33)
        Me.btnVeiculo.TabIndex = 11
        Me.btnVeiculo.TabStop = False
        Me.btnVeiculo.Text = "&Selecionar Veiculos"
        Me.btnVeiculo.UseVisualStyleBackColor = True
        '
        'gridVeiculacao
        '
        Me.gridVeiculacao.BackgroundColor = System.Drawing.Color.White
        Me.gridVeiculacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVeiculacao.Location = New System.Drawing.Point(6, 3)
        Me.gridVeiculacao.Name = "gridVeiculacao"
        Me.gridVeiculacao.Size = New System.Drawing.Size(979, 379)
        Me.gridVeiculacao.TabIndex = 13
        '
        'tabDados
        '
        Me.tabDados.BackColor = System.Drawing.SystemColors.Control
        Me.tabDados.Controls.Add(Me.txtNegociacao)
        Me.tabDados.Controls.Add(Me.txtInicioCampanha)
        Me.tabDados.Controls.Add(Me.txtCaracteristica)
        Me.tabDados.Controls.Add(Me.txtEmpresaFaturamento)
        Me.tabDados.Controls.Add(Me.fraAbrangencia)
        Me.tabDados.Controls.Add(Me.txtContato)
        Me.tabDados.Controls.Add(Me.Label3)
        Me.tabDados.Controls.Add(Me.txtObservacao)
        Me.tabDados.Controls.Add(Me.txtFimCampanha)
        Me.tabDados.Controls.Add(Me.txtEmpresa)
        Me.tabDados.Controls.Add(Me.txtTipoMidia)
        Me.tabDados.Controls.Add(Me.txtNucleo)
        Me.tabDados.Controls.Add(Me.txtAgencia)
        Me.tabDados.Controls.Add(Me.txtCliente)
        Me.tabDados.Controls.Add(Me.txtDataRecepcao)
        Me.tabDados.Controls.Add(Me.txtNumeroPi)
        Me.tabDados.Controls.Add(Me.txtSequenciaMr)
        Me.tabDados.Controls.Add(Me.txtNumeroMr)
        Me.tabDados.Location = New System.Drawing.Point(4, 22)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDados.Size = New System.Drawing.Size(991, 451)
        Me.tabDados.TabIndex = 0
        Me.tabDados.Text = "Dados do Contratos"
        '
        'txtNegociacao
        '
        Me.txtNegociacao.BackColor = System.Drawing.SystemColors.Control
        Me.txtNegociacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNegociacao.Caption = "Numero Negociação"
        Me.txtNegociacao.DataTextValue = Nothing
        Me.txtNegociacao.Location = New System.Drawing.Point(835, 131)
        Me.txtNegociacao.MaxLength = 32767
        Me.txtNegociacao.Name = "txtNegociacao"
        Me.txtNegociacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNegociacao.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNegociacao.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtNegociacao.pDecimal = CType(0, Byte)
        Me.txtNegociacao.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNegociacao.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtNegociacao.Size = New System.Drawing.Size(105, 37)
        Me.txtNegociacao.sqlQuery = Nothing
        Me.txtNegociacao.TabIndex = 16
        Me.txtNegociacao.TextBoxLeft = CType(0, Short)
        Me.txtNegociacao.TextWidth = 0
        Me.txtNegociacao.Visible = False
        '
        'txtInicioCampanha
        '
        Me.txtInicioCampanha.BackColor = System.Drawing.SystemColors.Control
        Me.txtInicioCampanha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtInicioCampanha.Caption = "Ínicio da Campanha"
        Me.txtInicioCampanha.DataTextValue = Nothing
        Me.txtInicioCampanha.Location = New System.Drawing.Point(254, 17)
        Me.txtInicioCampanha.MaxLength = 10
        Me.txtInicioCampanha.Name = "txtInicioCampanha"
        Me.txtInicioCampanha.Obrigatorio = True
        Me.txtInicioCampanha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInicioCampanha.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtInicioCampanha.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtInicioCampanha.pDecimal = CType(0, Byte)
        Me.txtInicioCampanha.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtInicioCampanha.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.txtInicioCampanha.Size = New System.Drawing.Size(105, 37)
        Me.txtInicioCampanha.sqlQuery = Nothing
        Me.txtInicioCampanha.TabIndex = 2
        Me.txtInicioCampanha.TextBoxLeft = CType(0, Short)
        Me.txtInicioCampanha.TextWidth = 0
        '
        'txtCaracteristica
        '
        Me.txtCaracteristica.BackColor = System.Drawing.SystemColors.Control
        Me.txtCaracteristica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCaracteristica.Caption = "Característica do Contrato"
        Me.txtCaracteristica.DataTextValue = Nothing
        Me.txtCaracteristica.Location = New System.Drawing.Point(431, 131)
        Me.txtCaracteristica.MaxLength = 3
        Me.txtCaracteristica.Name = "txtCaracteristica"
        Me.txtCaracteristica.Obrigatorio = True
        Me.txtCaracteristica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCaracteristica.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCaracteristica.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtCaracteristica.pDecimal = CType(0, Byte)
        Me.txtCaracteristica.pDicionario = WUC.clsDicionario.enuDicionario.Caracteristica_Contrato
        Me.txtCaracteristica.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtCaracteristica.showButton = True
        Me.txtCaracteristica.ShowDescricao = True
        Me.txtCaracteristica.Size = New System.Drawing.Size(378, 37)
        Me.txtCaracteristica.sqlQuery = "Execute prNet_Carac_Contrato_L"
        Me.txtCaracteristica.TabIndex = 9
        Me.txtCaracteristica.TextBoxLeft = CType(0, Short)
        Me.txtCaracteristica.TextWidth = 70
        '
        'txtEmpresaFaturamento
        '
        Me.txtEmpresaFaturamento.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmpresaFaturamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmpresaFaturamento.Caption = "Empresa de Faturamento"
        Me.txtEmpresaFaturamento.DataTextValue = Nothing
        Me.txtEmpresaFaturamento.Location = New System.Drawing.Point(431, 74)
        Me.txtEmpresaFaturamento.MaxLength = 3
        Me.txtEmpresaFaturamento.Name = "txtEmpresaFaturamento"
        Me.txtEmpresaFaturamento.Obrigatorio = True
        Me.txtEmpresaFaturamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpresaFaturamento.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmpresaFaturamento.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEmpresaFaturamento.pDecimal = CType(0, Byte)
        Me.txtEmpresaFaturamento.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.txtEmpresaFaturamento.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmpresaFaturamento.showButton = True
        Me.txtEmpresaFaturamento.ShowDescricao = True
        Me.txtEmpresaFaturamento.Size = New System.Drawing.Size(378, 37)
        Me.txtEmpresaFaturamento.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.txtEmpresaFaturamento.TabIndex = 7
        Me.txtEmpresaFaturamento.TextBoxLeft = CType(0, Short)
        Me.txtEmpresaFaturamento.TextWidth = 70
        '
        'fraAbrangencia
        '
        Me.fraAbrangencia.Controls.Add(Me.optLocal)
        Me.fraAbrangencia.Controls.Add(Me.optRede)
        Me.fraAbrangencia.Controls.Add(Me.optNet)
        Me.fraAbrangencia.Location = New System.Drawing.Point(832, 17)
        Me.fraAbrangencia.Name = "fraAbrangencia"
        Me.fraAbrangencia.Size = New System.Drawing.Size(107, 99)
        Me.fraAbrangencia.TabIndex = 15
        Me.fraAbrangencia.TabStop = False
        Me.fraAbrangencia.Text = "Abrangência"
        '
        'optLocal
        '
        Me.optLocal.AutoSize = True
        Me.optLocal.Enabled = False
        Me.optLocal.Location = New System.Drawing.Point(19, 67)
        Me.optLocal.Name = "optLocal"
        Me.optLocal.Size = New System.Drawing.Size(51, 17)
        Me.optLocal.TabIndex = 2
        Me.optLocal.TabStop = True
        Me.optLocal.Text = "Local"
        Me.optLocal.UseVisualStyleBackColor = True
        '
        'optRede
        '
        Me.optRede.AutoSize = True
        Me.optRede.Enabled = False
        Me.optRede.Location = New System.Drawing.Point(19, 43)
        Me.optRede.Name = "optRede"
        Me.optRede.Size = New System.Drawing.Size(51, 17)
        Me.optRede.TabIndex = 1
        Me.optRede.TabStop = True
        Me.optRede.Text = "Rede"
        Me.optRede.UseVisualStyleBackColor = True
        '
        'optNet
        '
        Me.optNet.AutoSize = True
        Me.optNet.Enabled = False
        Me.optNet.Location = New System.Drawing.Point(19, 20)
        Me.optNet.Name = "optNet"
        Me.optNet.Size = New System.Drawing.Size(42, 17)
        Me.optNet.TabIndex = 0
        Me.optNet.TabStop = True
        Me.optNet.Text = "Net"
        Me.optNet.UseVisualStyleBackColor = True
        '
        'txtContato
        '
        Me.txtContato.BackColor = System.Drawing.SystemColors.Control
        Me.txtContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtContato.Caption = "Contato"
        Me.txtContato.DataTextValue = Nothing
        Me.txtContato.Location = New System.Drawing.Point(431, 245)
        Me.txtContato.MaxLength = 6
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Obrigatorio = True
        Me.txtContato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContato.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtContato.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtContato.pDecimal = CType(0, Byte)
        Me.txtContato.pDicionario = WUC.clsDicionario.enuDicionario.Contato
        Me.txtContato.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtContato.showButton = True
        Me.txtContato.ShowDescricao = True
        Me.txtContato.Size = New System.Drawing.Size(378, 37)
        Me.txtContato.sqlQuery = "Execute prNet_Contato_L Null,'"
        Me.txtContato.TabIndex = 13
        Me.txtContato.TextBoxLeft = CType(0, Short)
        Me.txtContato.TextWidth = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Observação para Roteiro"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(16, 313)
        Me.txtObservacao.MaxLength = 1000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(793, 132)
        Me.txtObservacao.TabIndex = 14
        '
        'txtFimCampanha
        '
        Me.txtFimCampanha.BackColor = System.Drawing.SystemColors.Control
        Me.txtFimCampanha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtFimCampanha.Caption = "Fim da Campanha"
        Me.txtFimCampanha.DataTextValue = Nothing
        Me.txtFimCampanha.Location = New System.Drawing.Point(394, 17)
        Me.txtFimCampanha.MaxLength = 10
        Me.txtFimCampanha.Name = "txtFimCampanha"
        Me.txtFimCampanha.Obrigatorio = True
        Me.txtFimCampanha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFimCampanha.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtFimCampanha.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtFimCampanha.pDecimal = CType(0, Byte)
        Me.txtFimCampanha.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtFimCampanha.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.txtFimCampanha.Size = New System.Drawing.Size(105, 37)
        Me.txtFimCampanha.sqlQuery = Nothing
        Me.txtFimCampanha.TabIndex = 3
        Me.txtFimCampanha.TextBoxLeft = CType(0, Short)
        Me.txtFimCampanha.TextWidth = 0
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmpresa.Caption = "Empresa de Venda"
        Me.txtEmpresa.DataTextValue = Nothing
        Me.txtEmpresa.Location = New System.Drawing.Point(17, 74)
        Me.txtEmpresa.MaxLength = 3
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Obrigatorio = True
        Me.txtEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEmpresa.pDecimal = CType(0, Byte)
        Me.txtEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.txtEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmpresa.showButton = True
        Me.txtEmpresa.ShowDescricao = True
        Me.txtEmpresa.Size = New System.Drawing.Size(378, 37)
        Me.txtEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.txtEmpresa.TabIndex = 6
        Me.txtEmpresa.TextBoxLeft = CType(0, Short)
        Me.txtEmpresa.TextWidth = 70
        '
        'txtTipoMidia
        '
        Me.txtTipoMidia.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipoMidia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTipoMidia.Caption = "Tipo de Mídia"
        Me.txtTipoMidia.DataTextValue = Nothing
        Me.txtTipoMidia.Location = New System.Drawing.Point(17, 131)
        Me.txtTipoMidia.MaxLength = 6
        Me.txtTipoMidia.Name = "txtTipoMidia"
        Me.txtTipoMidia.Obrigatorio = True
        Me.txtTipoMidia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoMidia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTipoMidia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtTipoMidia.pDecimal = CType(0, Byte)
        Me.txtTipoMidia.pDicionario = WUC.clsDicionario.enuDicionario.Tipo_de_Midia
        Me.txtTipoMidia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTipoMidia.showButton = True
        Me.txtTipoMidia.ShowDescricao = True
        Me.txtTipoMidia.Size = New System.Drawing.Size(378, 37)
        Me.txtTipoMidia.sqlQuery = "Execute PrNet_Tipo_Midia_L"
        Me.txtTipoMidia.TabIndex = 8
        Me.txtTipoMidia.TextBoxLeft = CType(0, Short)
        Me.txtTipoMidia.TextWidth = 70
        '
        'txtNucleo
        '
        Me.txtNucleo.BackColor = System.Drawing.SystemColors.Control
        Me.txtNucleo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNucleo.Caption = "Nucleo"
        Me.txtNucleo.DataTextValue = Nothing
        Me.txtNucleo.Location = New System.Drawing.Point(17, 245)
        Me.txtNucleo.MaxLength = 6
        Me.txtNucleo.Name = "txtNucleo"
        Me.txtNucleo.Obrigatorio = True
        Me.txtNucleo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNucleo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNucleo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtNucleo.pDecimal = CType(0, Byte)
        Me.txtNucleo.pDicionario = WUC.clsDicionario.enuDicionario.Nucleo
        Me.txtNucleo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNucleo.showButton = True
        Me.txtNucleo.ShowDescricao = True
        Me.txtNucleo.Size = New System.Drawing.Size(378, 37)
        Me.txtNucleo.sqlQuery = "Execute PrNet_Nucleo_L"
        Me.txtNucleo.TabIndex = 12
        Me.txtNucleo.TextBoxLeft = CType(0, Short)
        Me.txtNucleo.TextWidth = 70
        '
        'txtAgencia
        '
        Me.txtAgencia.BackColor = System.Drawing.SystemColors.Control
        Me.txtAgencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtAgencia.Caption = "Agência"
        Me.txtAgencia.DataTextValue = Nothing
        Me.txtAgencia.Location = New System.Drawing.Point(16, 188)
        Me.txtAgencia.MaxLength = 6
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Obrigatorio = True
        Me.txtAgencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAgencia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtAgencia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtAgencia.pDecimal = CType(0, Byte)
        Me.txtAgencia.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.txtAgencia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtAgencia.showButton = True
        Me.txtAgencia.ShowDescricao = True
        Me.txtAgencia.Size = New System.Drawing.Size(379, 37)
        Me.txtAgencia.sqlQuery = "Execute prNet_Terceiro_S Null, ''"
        Me.txtAgencia.TabIndex = 10
        Me.txtAgencia.TextBoxLeft = CType(0, Short)
        Me.txtAgencia.TextWidth = 70
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Control
        Me.txtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCliente.Caption = "Cliente"
        Me.txtCliente.DataTextValue = Nothing
        Me.txtCliente.Location = New System.Drawing.Point(431, 188)
        Me.txtCliente.MaxLength = 6
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Obrigatorio = True
        Me.txtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCliente.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtCliente.pDecimal = CType(0, Byte)
        Me.txtCliente.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.txtCliente.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtCliente.showButton = True
        Me.txtCliente.ShowDescricao = True
        Me.txtCliente.Size = New System.Drawing.Size(378, 37)
        Me.txtCliente.sqlQuery = "Execute prNet_Terceiro_S Null, ''"
        Me.txtCliente.TabIndex = 11
        Me.txtCliente.TextBoxLeft = CType(0, Short)
        Me.txtCliente.TextWidth = 70
        '
        'txtDataRecepcao
        '
        Me.txtDataRecepcao.BackColor = System.Drawing.SystemColors.Control
        Me.txtDataRecepcao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtDataRecepcao.Caption = "Data de Recepção"
        Me.txtDataRecepcao.DataTextValue = Nothing
        Me.txtDataRecepcao.Location = New System.Drawing.Point(534, 17)
        Me.txtDataRecepcao.MaxLength = 10
        Me.txtDataRecepcao.Name = "txtDataRecepcao"
        Me.txtDataRecepcao.Obrigatorio = True
        Me.txtDataRecepcao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDataRecepcao.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtDataRecepcao.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtDataRecepcao.pDecimal = CType(0, Byte)
        Me.txtDataRecepcao.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtDataRecepcao.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.txtDataRecepcao.Size = New System.Drawing.Size(105, 37)
        Me.txtDataRecepcao.sqlQuery = Nothing
        Me.txtDataRecepcao.TabIndex = 4
        Me.txtDataRecepcao.TextBoxLeft = CType(0, Short)
        Me.txtDataRecepcao.TextWidth = 0
        '
        'txtNumeroPi
        '
        Me.txtNumeroPi.BackColor = System.Drawing.SystemColors.Control
        Me.txtNumeroPi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNumeroPi.Caption = "Número do PI"
        Me.txtNumeroPi.DataTextValue = Nothing
        Me.txtNumeroPi.Location = New System.Drawing.Point(674, 17)
        Me.txtNumeroPi.MaxLength = 20
        Me.txtNumeroPi.Name = "txtNumeroPi"
        Me.txtNumeroPi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroPi.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNumeroPi.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtNumeroPi.pDecimal = CType(0, Byte)
        Me.txtNumeroPi.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNumeroPi.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNumeroPi.Size = New System.Drawing.Size(135, 37)
        Me.txtNumeroPi.sqlQuery = Nothing
        Me.txtNumeroPi.TabIndex = 5
        Me.txtNumeroPi.TextBoxLeft = CType(0, Short)
        Me.txtNumeroPi.TextWidth = 0
        '
        'txtSequenciaMr
        '
        Me.txtSequenciaMr.BackColor = System.Drawing.SystemColors.Control
        Me.txtSequenciaMr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSequenciaMr.Caption = "Sequencia"
        Me.txtSequenciaMr.DataTextValue = Nothing
        Me.txtSequenciaMr.Location = New System.Drawing.Point(153, 17)
        Me.txtSequenciaMr.MaxLength = 32767
        Me.txtSequenciaMr.Name = "txtSequenciaMr"
        Me.txtSequenciaMr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSequenciaMr.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtSequenciaMr.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtSequenciaMr.pDecimal = CType(0, Byte)
        Me.txtSequenciaMr.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtSequenciaMr.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtSequenciaMr.Size = New System.Drawing.Size(66, 37)
        Me.txtSequenciaMr.sqlQuery = Nothing
        Me.txtSequenciaMr.TabIndex = 1
        Me.txtSequenciaMr.TextBoxLeft = CType(0, Short)
        Me.txtSequenciaMr.TextWidth = 0
        '
        'txtNumeroMr
        '
        Me.txtNumeroMr.BackColor = System.Drawing.SystemColors.Control
        Me.txtNumeroMr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNumeroMr.Caption = "Numero MR"
        Me.txtNumeroMr.DataTextValue = Nothing
        Me.txtNumeroMr.Location = New System.Drawing.Point(14, 17)
        Me.txtNumeroMr.MaxLength = 32767
        Me.txtNumeroMr.Name = "txtNumeroMr"
        Me.txtNumeroMr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroMr.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNumeroMr.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtNumeroMr.pDecimal = CType(0, Byte)
        Me.txtNumeroMr.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNumeroMr.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtNumeroMr.Size = New System.Drawing.Size(104, 37)
        Me.txtNumeroMr.sqlQuery = Nothing
        Me.txtNumeroMr.TabIndex = 0
        Me.txtNumeroMr.TextBoxLeft = CType(0, Short)
        Me.txtNumeroMr.TextWidth = 0
        '
        'tabContrato
        '
        Me.tabContrato.Controls.Add(Me.tabDados)
        Me.tabContrato.Controls.Add(Me.tabComercial)
        Me.tabContrato.Controls.Add(Me.tabVeiculacao)
        Me.tabContrato.Location = New System.Drawing.Point(0, 55)
        Me.tabContrato.Name = "tabContrato"
        Me.tabContrato.SelectedIndex = 0
        Me.tabContrato.Size = New System.Drawing.Size(999, 477)
        Me.tabContrato.TabIndex = 0
        '
        'tabComercial
        '
        Me.tabComercial.Controls.Add(Me.btnComercialExcluir)
        Me.tabComercial.Controls.Add(Me.btnComercialAdicionar)
        Me.tabComercial.Controls.Add(Me.gridComercial)
        Me.tabComercial.Controls.Add(Me.btnComercialEditar)
        Me.tabComercial.Location = New System.Drawing.Point(4, 22)
        Me.tabComercial.Name = "tabComercial"
        Me.tabComercial.Padding = New System.Windows.Forms.Padding(3)
        Me.tabComercial.Size = New System.Drawing.Size(991, 451)
        Me.tabComercial.TabIndex = 1
        Me.tabComercial.Text = "Comercial"
        Me.tabComercial.UseVisualStyleBackColor = True
        '
        'btnComercialExcluir
        '
        Me.btnComercialExcluir.Location = New System.Drawing.Point(890, 398)
        Me.btnComercialExcluir.Name = "btnComercialExcluir"
        Me.btnComercialExcluir.Size = New System.Drawing.Size(89, 32)
        Me.btnComercialExcluir.TabIndex = 16
        Me.btnComercialExcluir.Text = "Excluir"
        Me.btnComercialExcluir.UseVisualStyleBackColor = True
        '
        'btnComercialAdicionar
        '
        Me.btnComercialAdicionar.BackColor = System.Drawing.Color.Transparent
        Me.btnComercialAdicionar.Location = New System.Drawing.Point(676, 398)
        Me.btnComercialAdicionar.Name = "btnComercialAdicionar"
        Me.btnComercialAdicionar.Size = New System.Drawing.Size(89, 32)
        Me.btnComercialAdicionar.TabIndex = 15
        Me.btnComercialAdicionar.Text = "Adicionar"
        Me.btnComercialAdicionar.UseVisualStyleBackColor = False
        '
        'gridComercial
        '
        Me.gridComercial.BackgroundColor = System.Drawing.Color.White
        Me.gridComercial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridComercial.Location = New System.Drawing.Point(6, 6)
        Me.gridComercial.Name = "gridComercial"
        Me.gridComercial.Size = New System.Drawing.Size(973, 386)
        Me.gridComercial.TabIndex = 14
        '
        'btnComercialEditar
        '
        Me.btnComercialEditar.Location = New System.Drawing.Point(783, 398)
        Me.btnComercialEditar.Name = "btnComercialEditar"
        Me.btnComercialEditar.Size = New System.Drawing.Size(89, 32)
        Me.btnComercialEditar.TabIndex = 12
        Me.btnComercialEditar.Text = "Editar"
        Me.btnComercialEditar.UseVisualStyleBackColor = True
        '
        'errMr
        '
        Me.errMr.ContainerControl = Me
        '
        'lblErro
        '
        Me.lblErro.AutoSize = True
        Me.lblErro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErro.ForeColor = System.Drawing.Color.Red
        Me.lblErro.Location = New System.Drawing.Point(734, 19)
        Me.lblErro.Name = "lblErro"
        Me.lblErro.Size = New System.Drawing.Size(43, 13)
        Me.lblErro.TabIndex = 7
        Me.lblErro.Text = "Critica"
        Me.lblErro.Visible = False
        '
        'frmMapaReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1010, 555)
        Me.Controls.Add(Me.lblErro)
        Me.Controls.Add(Me.btnOpcoes)
        Me.Controls.Add(Me.tabContrato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMapaReserva"
        Me.Text = "Manutenção do Mapa Reserva"
        Me.btnOpcoes.ResumeLayout(False)
        Me.btnOpcoes.PerformLayout()
        Me.tabVeiculacao.ResumeLayout(False)
        Me.tabVeiculacao.PerformLayout()
        CType(Me.gridVeiculacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.tabDados.PerformLayout()
        Me.fraAbrangencia.ResumeLayout(False)
        Me.fraAbrangencia.PerformLayout()
        Me.tabContrato.ResumeLayout(False)
        Me.tabComercial.ResumeLayout(False)
        CType(Me.gridComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errMr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpcoes As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents bntNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabVeiculacao As System.Windows.Forms.TabPage
    Friend WithEvents tabDados As System.Windows.Forms.TabPage
    Friend WithEvents txtInicioCampanha As WUC.UcText
    Friend WithEvents txtCaracteristica As WUC.UcText
    Friend WithEvents txtEmpresaFaturamento As WUC.UcText
    Friend WithEvents fraAbrangencia As System.Windows.Forms.GroupBox
    Friend WithEvents optLocal As System.Windows.Forms.RadioButton
    Friend WithEvents optRede As System.Windows.Forms.RadioButton
    Friend WithEvents optNet As System.Windows.Forms.RadioButton
    Friend WithEvents txtContato As WUC.UcText
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As System.Windows.Forms.TextBox
    Friend WithEvents txtFimCampanha As WUC.UcText
    Friend WithEvents txtEmpresa As WUC.UcText
    Friend WithEvents txtTipoMidia As WUC.UcText
    Friend WithEvents txtNucleo As WUC.UcText
    Friend WithEvents txtAgencia As WUC.UcText
    Friend WithEvents txtCliente As WUC.UcText
    Friend WithEvents txtDataRecepcao As WUC.UcText
    Friend WithEvents txtNumeroPi As WUC.UcText
    Friend WithEvents txtSequenciaMr As WUC.UcText
    Friend WithEvents txtNumeroMr As WUC.UcText
    Friend WithEvents tabContrato As System.Windows.Forms.TabControl
    'Friend WithEvents gridVeiculacao As SCTVNET.CustomGrid
    Friend WithEvents btnVeiculo As System.Windows.Forms.Button
    Friend WithEvents tabComercial As System.Windows.Forms.TabPage
    Friend WithEvents btnComercialExcluir As System.Windows.Forms.Button
    Friend WithEvents btnComercialAdicionar As System.Windows.Forms.Button
    Friend WithEvents gridComercial As System.Windows.Forms.DataGridView
    Friend WithEvents btnComercialEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovaSequencia As System.Windows.Forms.ToolStripButton
    Friend WithEvents errMr As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtNegociacao As WUC.UcText
    Friend WithEvents btnRepetir As System.Windows.Forms.Button
    Friend WithEvents gridVeiculacao As SCTVNET.CustomGrid
    Friend WithEvents lblVeiculo As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalGeral As System.Windows.Forms.Label
    Friend WithEvents lblErro As System.Windows.Forms.Label
End Class
