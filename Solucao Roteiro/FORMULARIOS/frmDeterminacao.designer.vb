<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeterminacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim btnIncluir As System.Windows.Forms.ToolStripButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeterminacao))
        Me.grpFiltro = New System.Windows.Forms.GroupBox
        Me.btnExibir = New System.Windows.Forms.Button
        Me.txtCliente = New WUC.UcText
        Me.chkMostraMensagem = New System.Windows.Forms.CheckBox
        Me.txtAgencia = New WUC.UcText
        Me.txtVeiculo = New WUC.UcText
        Me.TxtPeriodoAte = New WUC.UcText
        Me.TxtPeriodode = New WUC.UcText
        Me.txtSeq = New WUC.UcText
        Me.txtContrato = New WUC.UcText
        Me.txtEmpresa = New WUC.UcText
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvComercial = New System.Windows.Forms.DataGridView
        Me.dgvDeterminacao = New System.Windows.Forms.DataGridView
        Me.bntDeterminarTodos = New System.Windows.Forms.Button
        Me.btnOpcoes = New System.Windows.Forms.ToolStrip
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton
        Me.btnLimpar = New System.Windows.Forms.ToolStripButton
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSair = New System.Windows.Forms.ToolStripButton
        Me.btnLimparCelula = New System.Windows.Forms.Button
        Me.picAbsorve = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMensagem = New System.Windows.Forms.TextBox
        btnIncluir = New System.Windows.Forms.ToolStripButton
        Me.grpFiltro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDeterminacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnOpcoes.SuspendLayout()
        CType(Me.picAbsorve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIncluir
        '
        btnIncluir.Enabled = False
        btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        btnIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        btnIncluir.Name = "btnIncluir"
        btnIncluir.Size = New System.Drawing.Size(89, 49)
        btnIncluir.Text = "Incluir Comercial"
        btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        AddHandler btnIncluir.Click, AddressOf Me.btnIncluir_Click
        '
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.btnExibir)
        Me.grpFiltro.Controls.Add(Me.txtCliente)
        Me.grpFiltro.Controls.Add(Me.chkMostraMensagem)
        Me.grpFiltro.Controls.Add(Me.txtAgencia)
        Me.grpFiltro.Controls.Add(Me.txtVeiculo)
        Me.grpFiltro.Controls.Add(Me.TxtPeriodoAte)
        Me.grpFiltro.Controls.Add(Me.TxtPeriodode)
        Me.grpFiltro.Controls.Add(Me.txtSeq)
        Me.grpFiltro.Controls.Add(Me.txtContrato)
        Me.grpFiltro.Controls.Add(Me.txtEmpresa)
        Me.grpFiltro.Location = New System.Drawing.Point(2, 55)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(367, 294)
        Me.grpFiltro.TabIndex = 2
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Dados do Contrato"
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(272, 259)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(83, 29)
        Me.btnExibir.TabIndex = 8
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Control
        Me.txtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCliente.Caption = "Cliente:"
        Me.txtCliente.DataTextValue = Nothing
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(6, 115)
        Me.txtCliente.MaxLength = 6
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCliente.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtCliente.pDecimal = CType(0, Byte)
        Me.txtCliente.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.txtCliente.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.showButton = True
        Me.txtCliente.ShowDescricao = True
        Me.txtCliente.Size = New System.Drawing.Size(346, 37)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.TextBoxLeft = CType(0, Short)
        Me.txtCliente.TextWidth = 0
        '
        'chkMostraMensagem
        '
        Me.chkMostraMensagem.AutoSize = True
        Me.chkMostraMensagem.Checked = True
        Me.chkMostraMensagem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostraMensagem.Location = New System.Drawing.Point(11, 265)
        Me.chkMostraMensagem.Name = "chkMostraMensagem"
        Me.chkMostraMensagem.Size = New System.Drawing.Size(165, 17)
        Me.chkMostraMensagem.TabIndex = 12
        Me.chkMostraMensagem.Text = "Mostrar Mensagem de Critíca"
        Me.chkMostraMensagem.UseVisualStyleBackColor = True
        '
        'txtAgencia
        '
        Me.txtAgencia.BackColor = System.Drawing.SystemColors.Control
        Me.txtAgencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtAgencia.Caption = "Agência:"
        Me.txtAgencia.DataTextValue = Nothing
        Me.txtAgencia.Enabled = False
        Me.txtAgencia.Location = New System.Drawing.Point(6, 158)
        Me.txtAgencia.MaxLength = 6
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAgencia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtAgencia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtAgencia.pDecimal = CType(0, Byte)
        Me.txtAgencia.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.txtAgencia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtAgencia.showButton = True
        Me.txtAgencia.ShowDescricao = True
        Me.txtAgencia.Size = New System.Drawing.Size(346, 37)
        Me.txtAgencia.TabIndex = 6
        Me.txtAgencia.TextBoxLeft = CType(0, Short)
        Me.txtAgencia.TextWidth = 0
        '
        'txtVeiculo
        '
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.txtVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtVeiculo.Caption = "Veiculo"
        Me.txtVeiculo.DataTextValue = Nothing
        Me.txtVeiculo.Location = New System.Drawing.Point(6, 201)
        Me.txtVeiculo.MaxLength = 3
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtVeiculo.pDecimal = CType(0, Byte)
        Me.txtVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.txtVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtVeiculo.showButton = True
        Me.txtVeiculo.ShowDescricao = True
        Me.txtVeiculo.Size = New System.Drawing.Size(346, 37)
        Me.txtVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.txtVeiculo.TabIndex = 7
        Me.txtVeiculo.TextBoxLeft = CType(0, Short)
        Me.txtVeiculo.TextWidth = 0
        '
        'TxtPeriodoAte
        '
        Me.TxtPeriodoAte.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPeriodoAte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtPeriodoAte.Caption = "Até:"
        Me.TxtPeriodoAte.DataTextValue = Nothing
        Me.TxtPeriodoAte.Location = New System.Drawing.Point(259, 72)
        Me.TxtPeriodoAte.MaxLength = 10
        Me.TxtPeriodoAte.Name = "TxtPeriodoAte"
        Me.TxtPeriodoAte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPeriodoAte.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtPeriodoAte.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtPeriodoAte.pDecimal = CType(0, Byte)
        Me.TxtPeriodoAte.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtPeriodoAte.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.TxtPeriodoAte.Size = New System.Drawing.Size(93, 37)
        Me.TxtPeriodoAte.sqlQuery = Nothing
        Me.TxtPeriodoAte.TabIndex = 4
        Me.TxtPeriodoAte.TextBoxLeft = CType(0, Short)
        Me.TxtPeriodoAte.TextWidth = 0
        '
        'TxtPeriodode
        '
        Me.TxtPeriodode.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPeriodode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtPeriodode.Caption = "Período - De:"
        Me.TxtPeriodode.DataTextValue = Nothing
        Me.TxtPeriodode.Location = New System.Drawing.Point(160, 72)
        Me.TxtPeriodode.MaxLength = 10
        Me.TxtPeriodode.Name = "TxtPeriodode"
        Me.TxtPeriodode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPeriodode.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtPeriodode.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtPeriodode.pDecimal = CType(0, Byte)
        Me.TxtPeriodode.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtPeriodode.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.TxtPeriodode.Size = New System.Drawing.Size(103, 37)
        Me.TxtPeriodode.sqlQuery = Nothing
        Me.TxtPeriodode.TabIndex = 3
        Me.TxtPeriodode.TextBoxLeft = CType(0, Short)
        Me.TxtPeriodode.TextWidth = 0
        '
        'txtSeq
        '
        Me.txtSeq.BackColor = System.Drawing.SystemColors.Control
        Me.txtSeq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSeq.Caption = "Seq.:"
        Me.txtSeq.DataTextValue = Nothing
        Me.txtSeq.Location = New System.Drawing.Point(103, 72)
        Me.txtSeq.MaxLength = 10
        Me.txtSeq.Name = "txtSeq"
        Me.txtSeq.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSeq.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtSeq.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtSeq.pDecimal = CType(0, Byte)
        Me.txtSeq.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtSeq.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtSeq.Size = New System.Drawing.Size(37, 37)
        Me.txtSeq.TabIndex = 2
        Me.txtSeq.TextBoxLeft = CType(0, Short)
        Me.txtSeq.TextWidth = 0
        '
        'txtContrato
        '
        Me.txtContrato.BackColor = System.Drawing.SystemColors.Control
        Me.txtContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtContrato.Caption = "Contrato:"
        Me.txtContrato.DataTextValue = Nothing
        Me.txtContrato.Location = New System.Drawing.Point(6, 72)
        Me.txtContrato.MaxLength = 10
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContrato.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtContrato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtContrato.pDecimal = CType(0, Byte)
        Me.txtContrato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtContrato.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtContrato.Size = New System.Drawing.Size(91, 37)
        Me.txtContrato.TabIndex = 1
        Me.txtContrato.TextBoxLeft = CType(0, Short)
        Me.txtContrato.TextWidth = 0
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmpresa.Caption = "Empresa:"
        Me.txtEmpresa.DataTextValue = Nothing
        Me.txtEmpresa.Location = New System.Drawing.Point(6, 18)
        Me.txtEmpresa.MaxLength = 3
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEmpresa.pDecimal = CType(0, Byte)
        Me.txtEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.txtEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmpresa.showButton = True
        Me.txtEmpresa.ShowDescricao = True
        Me.txtEmpresa.Size = New System.Drawing.Size(346, 37)
        Me.txtEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.txtEmpresa.TabIndex = 0
        Me.txtEmpresa.TextBoxLeft = CType(0, Short)
        Me.txtEmpresa.TextWidth = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvComercial)
        Me.GroupBox1.Location = New System.Drawing.Point(375, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 294)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Comercial"
        '
        'dgvComercial
        '
        Me.dgvComercial.AllowDrop = True
        Me.dgvComercial.BackgroundColor = System.Drawing.Color.White
        Me.dgvComercial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComercial.Location = New System.Drawing.Point(9, 21)
        Me.dgvComercial.Name = "dgvComercial"
        Me.dgvComercial.Size = New System.Drawing.Size(396, 261)
        Me.dgvComercial.TabIndex = 0
        '
        'dgvDeterminacao
        '
        Me.dgvDeterminacao.AllowDrop = True
        Me.dgvDeterminacao.BackgroundColor = System.Drawing.Color.White
        Me.dgvDeterminacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeterminacao.Location = New System.Drawing.Point(8, 355)
        Me.dgvDeterminacao.Name = "dgvDeterminacao"
        Me.dgvDeterminacao.Size = New System.Drawing.Size(778, 177)
        Me.dgvDeterminacao.TabIndex = 10
        '
        'bntDeterminarTodos
        '
        Me.bntDeterminarTodos.Location = New System.Drawing.Point(8, 538)
        Me.bntDeterminarTodos.Name = "bntDeterminarTodos"
        Me.bntDeterminarTodos.Size = New System.Drawing.Size(121, 28)
        Me.bntDeterminarTodos.TabIndex = 11
        Me.bntDeterminarTodos.Text = "Determinar Todos"
        Me.bntDeterminarTodos.UseVisualStyleBackColor = True
        '
        'btnOpcoes
        '
        Me.btnOpcoes.AllowDrop = True
        Me.btnOpcoes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.btnOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalvar, Me.btnLimpar, btnIncluir, Me.btnConsultar, Me.ToolStripSeparator1, Me.btnSair})
        Me.btnOpcoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.btnOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.btnOpcoes.Name = "btnOpcoes"
        Me.btnOpcoes.Size = New System.Drawing.Size(798, 52)
        Me.btnOpcoes.TabIndex = 14
        Me.btnOpcoes.Text = "ToolStrip1"
        '
        'btnSalvar
        '
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.Image = Global.SCTVNET.My.Resources.Resources.save
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(50, 49)
        Me.btnSalvar.Text = "   Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnLimpar
        '
        Me.btnLimpar.Enabled = False
        Me.btnLimpar.Image = Global.SCTVNET.My.Resources.Resources.cancelar2
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(48, 49)
        Me.btnLimpar.Text = "  Limpar"
        Me.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.SCTVNET.My.Resources.Resources.Binocolo
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(66, 49)
        Me.btnConsultar.Text = "   Consultar"
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'btnSair
        '
        Me.btnSair.Image = Global.SCTVNET.My.Resources.Resources.Sair
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(47, 49)
        Me.btnSair.Text = "   Sair   "
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnLimparCelula
        '
        Me.btnLimparCelula.Location = New System.Drawing.Point(657, 538)
        Me.btnLimparCelula.Name = "btnLimparCelula"
        Me.btnLimparCelula.Size = New System.Drawing.Size(129, 28)
        Me.btnLimparCelula.TabIndex = 15
        Me.btnLimparCelula.Text = "Limpar Determinacao"
        Me.btnLimparCelula.UseVisualStyleBackColor = True
        '
        'picAbsorve
        '
        Me.picAbsorve.BackColor = System.Drawing.Color.Blue
        Me.picAbsorve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAbsorve.Location = New System.Drawing.Point(414, 546)
        Me.picAbsorve.Name = "picAbsorve"
        Me.picAbsorve.Size = New System.Drawing.Size(15, 13)
        Me.picAbsorve.TabIndex = 18
        Me.picAbsorve.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(435, 546)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Falhas"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(489, 546)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 13)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(510, 546)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Veiculaões oriundas de AM"
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(135, 543)
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(256, 20)
        Me.txtMensagem.TabIndex = 13
        Me.txtMensagem.Visible = False
        '
        'frmDeterminacao
        '
        Me.ClientSize = New System.Drawing.Size(798, 570)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picAbsorve)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimparCelula)
        Me.Controls.Add(Me.btnOpcoes)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.bntDeterminarTodos)
        Me.Controls.Add(Me.dgvDeterminacao)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpFiltro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDeterminacao"
        Me.Text = "Determinação de Materiais"
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDeterminacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnOpcoes.ResumeLayout(False)
        Me.btnOpcoes.PerformLayout()
        CType(Me.picAbsorve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCliente As WUC.UcText
    Friend WithEvents txtAgencia As WUC.UcText
    Friend WithEvents txtVeiculo As WUC.UcText
    Friend WithEvents TxtPeriodoAte As WUC.UcText
    Friend WithEvents TxtPeriodode As WUC.UcText
    Friend WithEvents grpFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSeq As WUC.UcText
    Friend WithEvents txtContrato As WUC.UcText
    Friend WithEvents txtEmpresa As WUC.UcText
    Friend WithEvents dgvComercial As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDeterminacao As System.Windows.Forms.DataGridView
    Friend WithEvents bntDeterminarTodos As System.Windows.Forms.Button
    Friend WithEvents chkMostraMensagem As System.Windows.Forms.CheckBox
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents btnOpcoes As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLimpar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLimparCelula As System.Windows.Forms.Button
    Friend WithEvents picAbsorve As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
End Class
