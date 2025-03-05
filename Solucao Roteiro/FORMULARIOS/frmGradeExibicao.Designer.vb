<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeExibicao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGradeExibicao))
        Me.gridGrade = New System.Windows.Forms.DataGridView
        Me.btnExibir = New System.Windows.Forms.Button
        Me.groupAnalisar = New System.Windows.Forms.GroupBox
        Me.optLocal = New System.Windows.Forms.RadioButton
        Me.optRede = New System.Windows.Forms.RadioButton
        Me.optNet = New System.Windows.Forms.RadioButton
        Me.groupClassificar = New System.Windows.Forms.GroupBox
        Me.optSequencia = New System.Windows.Forms.RadioButton
        Me.optCodigo = New System.Windows.Forms.RadioButton
        Me.groupDados = New System.Windows.Forms.GroupBox
        Me.UcFaixaHoraria = New WUC.UcText
        Me.ucHoraFim = New WUC.UcText
        Me.ucData = New WUC.UcText
        Me.chkRotativo = New System.Windows.Forms.CheckBox
        Me.ucHora = New WUC.UcText
        Me.ucTitulo = New WUC.UcText
        Me.ucCodigo = New WUC.UcText
        Me.GroupDispo = New System.Windows.Forms.GroupBox
        Me.gridDispo = New System.Windows.Forms.DataGridView
        Me.groupStatus = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.picDesativado = New System.Windows.Forms.PictureBox
        Me.picPositivo = New System.Windows.Forms.PictureBox
        Me.picZerado = New System.Windows.Forms.PictureBox
        Me.picEstourado = New System.Windows.Forms.PictureBox
        Me.btnOpcoes = New System.Windows.Forms.ToolStrip
        Me.btnNovo = New System.Windows.Forms.ToolStripButton
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton
        Me.btnDesativar = New System.Windows.Forms.ToolStripButton
        Me.btnReativar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSair = New System.Windows.Forms.ToolStripButton
        Me.grupFiltro = New System.Windows.Forms.GroupBox
        Me.ucCompetencia = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        CType(Me.gridGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupAnalisar.SuspendLayout()
        Me.groupClassificar.SuspendLayout()
        Me.groupDados.SuspendLayout()
        Me.GroupDispo.SuspendLayout()
        CType(Me.gridDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupStatus.SuspendLayout()
        CType(Me.picDesativado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picZerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEstourado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnOpcoes.SuspendLayout()
        Me.grupFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridGrade
        '
        Me.gridGrade.BackgroundColor = System.Drawing.Color.White
        Me.gridGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridGrade.Location = New System.Drawing.Point(0, 116)
        Me.gridGrade.Name = "gridGrade"
        Me.gridGrade.Size = New System.Drawing.Size(977, 322)
        Me.gridGrade.TabIndex = 0
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(879, 64)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(98, 42)
        Me.btnExibir.TabIndex = 3
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'groupAnalisar
        '
        Me.groupAnalisar.Controls.Add(Me.optLocal)
        Me.groupAnalisar.Controls.Add(Me.optRede)
        Me.groupAnalisar.Controls.Add(Me.optNet)
        Me.groupAnalisar.Location = New System.Drawing.Point(468, 55)
        Me.groupAnalisar.Name = "groupAnalisar"
        Me.groupAnalisar.Size = New System.Drawing.Size(178, 55)
        Me.groupAnalisar.TabIndex = 4
        Me.groupAnalisar.TabStop = False
        Me.groupAnalisar.Text = "Mostrar Status da Dispo"
        '
        'optLocal
        '
        Me.optLocal.AutoSize = True
        Me.optLocal.Checked = True
        Me.optLocal.Location = New System.Drawing.Point(112, 25)
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
        Me.optRede.Location = New System.Drawing.Point(55, 25)
        Me.optRede.Name = "optRede"
        Me.optRede.Size = New System.Drawing.Size(51, 17)
        Me.optRede.TabIndex = 1
        Me.optRede.Text = "Rede"
        Me.optRede.UseVisualStyleBackColor = True
        '
        'optNet
        '
        Me.optNet.AutoSize = True
        Me.optNet.Location = New System.Drawing.Point(7, 25)
        Me.optNet.Name = "optNet"
        Me.optNet.Size = New System.Drawing.Size(42, 17)
        Me.optNet.TabIndex = 0
        Me.optNet.Text = "Net"
        Me.optNet.UseVisualStyleBackColor = True
        '
        'groupClassificar
        '
        Me.groupClassificar.Controls.Add(Me.optSequencia)
        Me.groupClassificar.Controls.Add(Me.optCodigo)
        Me.groupClassificar.Location = New System.Drawing.Point(652, 55)
        Me.groupClassificar.Name = "groupClassificar"
        Me.groupClassificar.Size = New System.Drawing.Size(200, 55)
        Me.groupClassificar.TabIndex = 5
        Me.groupClassificar.TabStop = False
        Me.groupClassificar.Text = "Classificar Linha por"
        '
        'optSequencia
        '
        Me.optSequencia.AutoSize = True
        Me.optSequencia.Checked = True
        Me.optSequencia.Location = New System.Drawing.Point(73, 25)
        Me.optSequencia.Name = "optSequencia"
        Me.optSequencia.Size = New System.Drawing.Size(119, 17)
        Me.optSequencia.TabIndex = 2
        Me.optSequencia.TabStop = True
        Me.optSequencia.Text = "Sequencia Exibição"
        Me.optSequencia.UseVisualStyleBackColor = True
        '
        'optCodigo
        '
        Me.optCodigo.AutoSize = True
        Me.optCodigo.Location = New System.Drawing.Point(6, 25)
        Me.optCodigo.Name = "optCodigo"
        Me.optCodigo.Size = New System.Drawing.Size(61, 17)
        Me.optCodigo.TabIndex = 1
        Me.optCodigo.Text = "Codigo "
        Me.optCodigo.UseVisualStyleBackColor = True
        '
        'groupDados
        '
        Me.groupDados.Controls.Add(Me.UcFaixaHoraria)
        Me.groupDados.Controls.Add(Me.ucHoraFim)
        Me.groupDados.Controls.Add(Me.ucData)
        Me.groupDados.Controls.Add(Me.chkRotativo)
        Me.groupDados.Controls.Add(Me.ucHora)
        Me.groupDados.Controls.Add(Me.ucTitulo)
        Me.groupDados.Controls.Add(Me.ucCodigo)
        Me.groupDados.Enabled = False
        Me.groupDados.Location = New System.Drawing.Point(3, 444)
        Me.groupDados.Name = "groupDados"
        Me.groupDados.Size = New System.Drawing.Size(372, 140)
        Me.groupDados.TabIndex = 6
        Me.groupDados.TabStop = False
        Me.groupDados.Text = "Dados do Programa"
        '
        'UcFaixaHoraria
        '
        Me.UcFaixaHoraria.BackColor = System.Drawing.SystemColors.Control
        Me.UcFaixaHoraria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcFaixaHoraria.Caption = "Faixa Horária"
        Me.UcFaixaHoraria.DataTextValue = Nothing
        Me.UcFaixaHoraria.Location = New System.Drawing.Point(10, 110)
        Me.UcFaixaHoraria.MaxLength = 32767
        Me.UcFaixaHoraria.Name = "UcFaixaHoraria"
        Me.UcFaixaHoraria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcFaixaHoraria.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.UcFaixaHoraria.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.UcFaixaHoraria.pDecimal = CType(0, Byte)
        Me.UcFaixaHoraria.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.UcFaixaHoraria.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.UcFaixaHoraria.Size = New System.Drawing.Size(258, 25)
        Me.UcFaixaHoraria.sqlQuery = Nothing
        Me.UcFaixaHoraria.TabIndex = 9
        Me.UcFaixaHoraria.TextBoxLeft = CType(80, Short)
        Me.UcFaixaHoraria.TextWidth = 0
        '
        'ucHoraFim
        '
        Me.ucHoraFim.BackColor = System.Drawing.SystemColors.Control
        Me.ucHoraFim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucHoraFim.Caption = "Hora Término"
        Me.ucHoraFim.DataTextValue = Nothing
        Me.ucHoraFim.Location = New System.Drawing.Point(194, 80)
        Me.ucHoraFim.MaxLength = 32767
        Me.ucHoraFim.Name = "ucHoraFim"
        Me.ucHoraFim.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucHoraFim.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucHoraFim.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucHoraFim.pDecimal = CType(0, Byte)
        Me.ucHoraFim.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucHoraFim.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucHoraFim.Size = New System.Drawing.Size(172, 25)
        Me.ucHoraFim.sqlQuery = Nothing
        Me.ucHoraFim.TabIndex = 8
        Me.ucHoraFim.TextBoxLeft = CType(70, Short)
        Me.ucHoraFim.TextWidth = 0
        '
        'ucData
        '
        Me.ucData.BackColor = System.Drawing.SystemColors.Control
        Me.ucData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucData.Caption = "Data Exibição"
        Me.ucData.DataTextValue = Nothing
        Me.ucData.Location = New System.Drawing.Point(194, 20)
        Me.ucData.MaxLength = 32767
        Me.ucData.Name = "ucData"
        Me.ucData.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucData.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucData.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucData.pDecimal = CType(0, Byte)
        Me.ucData.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucData.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucData.Size = New System.Drawing.Size(172, 25)
        Me.ucData.sqlQuery = Nothing
        Me.ucData.TabIndex = 7
        Me.ucData.TextBoxLeft = CType(75, Short)
        Me.ucData.TextWidth = 0
        '
        'chkRotativo
        '
        Me.chkRotativo.AutoSize = True
        Me.chkRotativo.Location = New System.Drawing.Point(300, 111)
        Me.chkRotativo.Name = "chkRotativo"
        Me.chkRotativo.Size = New System.Drawing.Size(66, 17)
        Me.chkRotativo.TabIndex = 6
        Me.chkRotativo.Text = "Rotativo"
        Me.chkRotativo.UseVisualStyleBackColor = True
        '
        'ucHora
        '
        Me.ucHora.BackColor = System.Drawing.SystemColors.Control
        Me.ucHora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucHora.Caption = "Hora Início"
        Me.ucHora.DataTextValue = Nothing
        Me.ucHora.Location = New System.Drawing.Point(7, 80)
        Me.ucHora.MaxLength = 32767
        Me.ucHora.Name = "ucHora"
        Me.ucHora.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucHora.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucHora.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucHora.pDecimal = CType(0, Byte)
        Me.ucHora.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucHora.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucHora.Size = New System.Drawing.Size(172, 25)
        Me.ucHora.sqlQuery = Nothing
        Me.ucHora.TabIndex = 2
        Me.ucHora.TextBoxLeft = CType(80, Short)
        Me.ucHora.TextWidth = 0
        '
        'ucTitulo
        '
        Me.ucTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.ucTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucTitulo.DataTextValue = Nothing
        Me.ucTitulo.Location = New System.Drawing.Point(7, 50)
        Me.ucTitulo.MaxLength = 32767
        Me.ucTitulo.Name = "ucTitulo"
        Me.ucTitulo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucTitulo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucTitulo.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucTitulo.pDecimal = CType(0, Byte)
        Me.ucTitulo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucTitulo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucTitulo.Size = New System.Drawing.Size(359, 25)
        Me.ucTitulo.sqlQuery = Nothing
        Me.ucTitulo.TabIndex = 1
        Me.ucTitulo.TextBoxLeft = CType(80, Short)
        Me.ucTitulo.TextWidth = 0
        '
        'ucCodigo
        '
        Me.ucCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.ucCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCodigo.Caption = "Código"
        Me.ucCodigo.DataTextValue = Nothing
        Me.ucCodigo.Location = New System.Drawing.Point(7, 20)
        Me.ucCodigo.MaxLength = 32767
        Me.ucCodigo.Name = "ucCodigo"
        Me.ucCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCodigo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCodigo.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucCodigo.pDecimal = CType(0, Byte)
        Me.ucCodigo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCodigo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCodigo.Size = New System.Drawing.Size(172, 25)
        Me.ucCodigo.sqlQuery = Nothing
        Me.ucCodigo.TabIndex = 0
        Me.ucCodigo.TextBoxLeft = CType(80, Short)
        Me.ucCodigo.TextWidth = 0
        '
        'GroupDispo
        '
        Me.GroupDispo.Controls.Add(Me.gridDispo)
        Me.GroupDispo.Location = New System.Drawing.Point(381, 444)
        Me.GroupDispo.Name = "GroupDispo"
        Me.GroupDispo.Size = New System.Drawing.Size(358, 140)
        Me.GroupDispo.TabIndex = 8
        Me.GroupDispo.TabStop = False
        Me.GroupDispo.Text = "Disponibilidade"
        '
        'gridDispo
        '
        Me.gridDispo.BackgroundColor = System.Drawing.Color.White
        Me.gridDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDispo.Location = New System.Drawing.Point(6, 18)
        Me.gridDispo.Name = "gridDispo"
        Me.gridDispo.Size = New System.Drawing.Size(346, 115)
        Me.gridDispo.TabIndex = 0
        '
        'groupStatus
        '
        Me.groupStatus.Controls.Add(Me.Label4)
        Me.groupStatus.Controls.Add(Me.Label3)
        Me.groupStatus.Controls.Add(Me.Label2)
        Me.groupStatus.Controls.Add(Me.Label1)
        Me.groupStatus.Controls.Add(Me.picDesativado)
        Me.groupStatus.Controls.Add(Me.picPositivo)
        Me.groupStatus.Controls.Add(Me.picZerado)
        Me.groupStatus.Controls.Add(Me.picEstourado)
        Me.groupStatus.Location = New System.Drawing.Point(759, 444)
        Me.groupStatus.Name = "groupStatus"
        Me.groupStatus.Size = New System.Drawing.Size(218, 140)
        Me.groupStatus.TabIndex = 7
        Me.groupStatus.TabStop = False
        Me.groupStatus.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Desativado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Saldo Positivo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Saldo Zerado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Saldo Estourado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picDesativado
        '
        Me.picDesativado.BackColor = System.Drawing.Color.Gray
        Me.picDesativado.Location = New System.Drawing.Point(7, 110)
        Me.picDesativado.Name = "picDesativado"
        Me.picDesativado.Size = New System.Drawing.Size(15, 13)
        Me.picDesativado.TabIndex = 3
        Me.picDesativado.TabStop = False
        '
        'picPositivo
        '
        Me.picPositivo.BackColor = System.Drawing.Color.Green
        Me.picPositivo.Location = New System.Drawing.Point(7, 80)
        Me.picPositivo.Name = "picPositivo"
        Me.picPositivo.Size = New System.Drawing.Size(15, 13)
        Me.picPositivo.TabIndex = 2
        Me.picPositivo.TabStop = False
        '
        'picZerado
        '
        Me.picZerado.BackColor = System.Drawing.Color.Blue
        Me.picZerado.Location = New System.Drawing.Point(7, 50)
        Me.picZerado.Name = "picZerado"
        Me.picZerado.Size = New System.Drawing.Size(15, 13)
        Me.picZerado.TabIndex = 1
        Me.picZerado.TabStop = False
        '
        'picEstourado
        '
        Me.picEstourado.BackColor = System.Drawing.Color.Red
        Me.picEstourado.Location = New System.Drawing.Point(7, 20)
        Me.picEstourado.Name = "picEstourado"
        Me.picEstourado.Size = New System.Drawing.Size(15, 13)
        Me.picEstourado.TabIndex = 0
        Me.picEstourado.TabStop = False
        '
        'btnOpcoes
        '
        Me.btnOpcoes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.btnOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnEditar, Me.btnExcluir, Me.btnDesativar, Me.btnReativar, Me.ToolStripSeparator1, Me.btnSair})
        Me.btnOpcoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.btnOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.btnOpcoes.Name = "btnOpcoes"
        Me.btnOpcoes.Size = New System.Drawing.Size(978, 52)
        Me.btnOpcoes.TabIndex = 9
        Me.btnOpcoes.Text = "ToolStrip1"
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(54, 49)
        Me.btnNovo.Text = "   Novo   "
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.SCTVNET.My.Resources.Resources.Alterar1
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(57, 49)
        Me.btnEditar.Text = "   Editar   "
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.SCTVNET.My.Resources.Resources.Lixeira
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(60, 49)
        Me.btnExcluir.Text = "   Excluir   "
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnDesativar
        '
        Me.btnDesativar.Image = Global.SCTVNET.My.Resources.Resources.cancelar2
        Me.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDesativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDesativar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(69, 49)
        Me.btnDesativar.Text = "  Desativar  "
        Me.btnDesativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnReativar
        '
        Me.btnReativar.Image = Global.SCTVNET.My.Resources.Resources.OK
        Me.btnReativar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReativar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReativar.Name = "btnReativar"
        Me.btnReativar.Size = New System.Drawing.Size(64, 49)
        Me.btnReativar.Text = "  Reativar  "
        Me.btnReativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'grupFiltro
        '
        Me.grupFiltro.Controls.Add(Me.ucCompetencia)
        Me.grupFiltro.Controls.Add(Me.ucVeiculo)
        Me.grupFiltro.Location = New System.Drawing.Point(3, 55)
        Me.grupFiltro.Name = "grupFiltro"
        Me.grupFiltro.Size = New System.Drawing.Size(459, 55)
        Me.grupFiltro.TabIndex = 1
        Me.grupFiltro.TabStop = False
        Me.grupFiltro.Text = "Filtro"
        '
        'ucCompetencia
        '
        Me.ucCompetencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucCompetencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCompetencia.Caption = "Competência"
        Me.ucCompetencia.DataTextValue = Nothing
        Me.ucCompetencia.Location = New System.Drawing.Point(306, 18)
        Me.ucCompetencia.MaxLength = 32767
        Me.ucCompetencia.Name = "ucCompetencia"
        Me.ucCompetencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCompetencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCompetencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucCompetencia.pDecimal = CType(0, Byte)
        Me.ucCompetencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCompetencia.pFormatoSaida = WUC.UcText.FormatoSaida.Mes_Ano
        Me.ucCompetencia.Size = New System.Drawing.Size(142, 25)
        Me.ucCompetencia.sqlQuery = Nothing
        Me.ucCompetencia.TabIndex = 1
        Me.ucCompetencia.TextBoxLeft = CType(0, Short)
        Me.ucCompetencia.TextWidth = 0
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(10, 20)
        Me.ucVeiculo.MaxLength = 3
        Me.ucVeiculo.Name = "ucVeiculo"
        Me.ucVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVeiculo.pDecimal = CType(0, Byte)
        Me.ucVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVeiculo.showButton = True
        Me.ucVeiculo.ShowDescricao = True
        Me.ucVeiculo.Size = New System.Drawing.Size(280, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'frmGradeExibicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 596)
        Me.Controls.Add(Me.btnOpcoes)
        Me.Controls.Add(Me.GroupDispo)
        Me.Controls.Add(Me.groupStatus)
        Me.Controls.Add(Me.groupDados)
        Me.Controls.Add(Me.groupClassificar)
        Me.Controls.Add(Me.groupAnalisar)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.grupFiltro)
        Me.Controls.Add(Me.gridGrade)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmGradeExibicao"
        Me.Text = "Consulta da Grade da Programação"
        CType(Me.gridGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupAnalisar.ResumeLayout(False)
        Me.groupAnalisar.PerformLayout()
        Me.groupClassificar.ResumeLayout(False)
        Me.groupClassificar.PerformLayout()
        Me.groupDados.ResumeLayout(False)
        Me.groupDados.PerformLayout()
        Me.GroupDispo.ResumeLayout(False)
        CType(Me.gridDispo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupStatus.ResumeLayout(False)
        Me.groupStatus.PerformLayout()
        CType(Me.picDesativado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPositivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picZerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEstourado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnOpcoes.ResumeLayout(False)
        Me.btnOpcoes.PerformLayout()
        Me.grupFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridGrade As System.Windows.Forms.DataGridView
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents groupAnalisar As System.Windows.Forms.GroupBox
    Friend WithEvents optLocal As System.Windows.Forms.RadioButton
    Friend WithEvents optRede As System.Windows.Forms.RadioButton
    Friend WithEvents optNet As System.Windows.Forms.RadioButton
    Friend WithEvents groupClassificar As System.Windows.Forms.GroupBox
    Friend WithEvents optSequencia As System.Windows.Forms.RadioButton
    Friend WithEvents optCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents groupDados As System.Windows.Forms.GroupBox
    Friend WithEvents ucHora As WUC.UcText
    Friend WithEvents ucTitulo As WUC.UcText
    Friend WithEvents ucCodigo As WUC.UcText
    Friend WithEvents chkRotativo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupDispo As System.Windows.Forms.GroupBox
    Friend WithEvents gridDispo As System.Windows.Forms.DataGridView
    Friend WithEvents ucData As WUC.UcText
    Friend WithEvents groupStatus As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picDesativado As System.Windows.Forms.PictureBox
    Friend WithEvents picPositivo As System.Windows.Forms.PictureBox
    Friend WithEvents picZerado As System.Windows.Forms.PictureBox
    Friend WithEvents picEstourado As System.Windows.Forms.PictureBox
    Friend WithEvents ucHoraFim As WUC.UcText
    Friend WithEvents btnOpcoes As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDesativar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReativar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grupFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents ucCompetencia As WUC.UcText
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents UcFaixaHoraria As WUC.UcText
End Class
