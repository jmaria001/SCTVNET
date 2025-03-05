<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmComparaRoteiroV2
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
        Me.MDIParent = SCTVNET.mdiPrincipal
        SCTVNET.mdiPrincipal.Show()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents _cmdCancela_1 As System.Windows.Forms.Button
	Public WithEvents _cmdCancela_0 As System.Windows.Forms.Button
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents flxCorte As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents lblCorte As System.Windows.Forms.Label
	Public WithEvents _Label3_1 As System.Windows.Forms.Label
	Public WithEvents picCorte As System.Windows.Forms.Panel
	Public WithEvents lblVeiculo As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents treBreak As System.Windows.Forms.TreeView
	Public WithEvents txtPrograma As System.Windows.Forms.TextBox
	Public WithEvents chkMostrarRoteiro As System.Windows.Forms.CheckBox
	Public WithEvents txtVeiculo As System.Windows.Forms.TextBox
	Public WithEvents txtData As System.Windows.Forms.TextBox
	Public WithEvents frame1 As System.Windows.Forms.GroupBox
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents tbConsistencia As System.Windows.Forms.ToolStripButton
    Public WithEvents tbGuia As System.Windows.Forms.ToolStripButton
    Public WithEvents tbAtualizar As System.Windows.Forms.ToolStripButton
    Public WithEvents tbData As System.Windows.Forms.ToolStripButton
    Public WithEvents _tbOpcoes_Button6 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tbPrevious As System.Windows.Forms.ToolStripButton
    Public WithEvents tbNext As System.Windows.Forms.ToolStripButton
    Public WithEvents tbFirst As System.Windows.Forms.ToolStripButton
    Public WithEvents tbLast As System.Windows.Forms.ToolStripButton
    Public WithEvents _tbOpcoes_Button11 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tbSair As System.Windows.Forms.ToolStripButton
    Public WithEvents tbOpcoes As System.Windows.Forms.ToolStrip
    Public WithEvents Label3 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents cmdCancela As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComparaRoteiroV2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picCorte = New System.Windows.Forms.Panel
        Me._cmdCancela_1 = New System.Windows.Forms.Button
        Me._cmdCancela_0 = New System.Windows.Forms.Button
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.flxCorte = New AxMSFlexGridLib.AxMSFlexGrid
        Me.lblCorte = New System.Windows.Forms.Label
        Me._Label3_1 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.lblVeiculo = New System.Windows.Forms.Label
        Me.treBreak = New System.Windows.Forms.TreeView
        Me.frame1 = New System.Windows.Forms.GroupBox
        Me.txtPrograma = New System.Windows.Forms.TextBox
        Me.chkMostrarRoteiro = New System.Windows.Forms.CheckBox
        Me.txtVeiculo = New System.Windows.Forms.TextBox
        Me.txtData = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbOpcoes = New System.Windows.Forms.ToolStrip
        Me.tbConsistencia = New System.Windows.Forms.ToolStripButton
        Me.tbGuia = New System.Windows.Forms.ToolStripButton
        Me.tbAtualizar = New System.Windows.Forms.ToolStripButton
        Me.tbData = New System.Windows.Forms.ToolStripButton
        Me._tbOpcoes_Button6 = New System.Windows.Forms.ToolStripSeparator
        Me.tbPrevious = New System.Windows.Forms.ToolStripButton
        Me.tbNext = New System.Windows.Forms.ToolStripButton
        Me.tbFirst = New System.Windows.Forms.ToolStripButton
        Me.tbLast = New System.Windows.Forms.ToolStripButton
        Me._tbOpcoes_Button11 = New System.Windows.Forms.ToolStripSeparator
        Me.tbSair = New System.Windows.Forms.ToolStripButton
        Me.Label3 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdCancela = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.flxBreak = New AxMSFlexGridLib.AxMSFlexGrid
        Me.picCorte.SuspendLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxCorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.frame1.SuspendLayout()
        Me.tbOpcoes.SuspendLayout()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxBreak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCorte
        '
        Me.picCorte.BackColor = System.Drawing.SystemColors.Control
        Me.picCorte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCorte.Controls.Add(Me._cmdCancela_1)
        Me.picCorte.Controls.Add(Me._cmdCancela_0)
        Me.picCorte.Controls.Add(Me.Picture1)
        Me.picCorte.Controls.Add(Me.flxCorte)
        Me.picCorte.Controls.Add(Me.lblCorte)
        Me.picCorte.Controls.Add(Me._Label3_1)
        Me.picCorte.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCorte.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picCorte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picCorte.Location = New System.Drawing.Point(44, 151)
        Me.picCorte.Name = "picCorte"
        Me.picCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picCorte.Size = New System.Drawing.Size(64, 71)
        Me.picCorte.TabIndex = 5
        Me.picCorte.TabStop = True
        Me.picCorte.Visible = False
        '
        '_cmdCancela_1
        '
        Me._cmdCancela_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_1, CType(1, Short))
        Me._cmdCancela_1.Location = New System.Drawing.Point(414, 0)
        Me._cmdCancela_1.Name = "_cmdCancela_1"
        Me._cmdCancela_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_1.Size = New System.Drawing.Size(19, 16)
        Me._cmdCancela_1.TabIndex = 8
        Me._cmdCancela_1.TabStop = False
        Me._cmdCancela_1.Text = "X"
        Me._cmdCancela_1.UseVisualStyleBackColor = False
        '
        '_cmdCancela_0
        '
        Me._cmdCancela_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_0, CType(0, Short))
        Me._cmdCancela_0.Location = New System.Drawing.Point(342, 156)
        Me._cmdCancela_0.Name = "_cmdCancela_0"
        Me._cmdCancela_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_0.Size = New System.Drawing.Size(85, 28)
        Me._cmdCancela_0.TabIndex = 7
        Me._cmdCancela_0.TabStop = False
        Me._cmdCancela_0.Text = "&Cancela"
        Me._cmdCancela_0.UseVisualStyleBackColor = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.Location = New System.Drawing.Point(9, 162)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(37, 37)
        Me.Picture1.TabIndex = 6
        Me.Picture1.TabStop = False
        '
        'flxCorte
        '
        Me.flxCorte.Location = New System.Drawing.Point(3, 21)
        Me.flxCorte.Name = "flxCorte"
        Me.flxCorte.OcxState = CType(resources.GetObject("flxCorte.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxCorte.Size = New System.Drawing.Size(428, 133)
        Me.flxCorte.TabIndex = 9
        '
        'lblCorte
        '
        Me.lblCorte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCorte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCorte.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCorte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorte.ForeColor = System.Drawing.Color.White
        Me.lblCorte.Location = New System.Drawing.Point(0, 0)
        Me.lblCorte.Name = "lblCorte"
        Me.lblCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorte.Size = New System.Drawing.Size(434, 19)
        Me.lblCorte.TabIndex = 11
        Me.lblCorte.Text = "  Alerta de Comerciais Cortados do Roteiro"
        '
        '_Label3_1
        '
        Me._Label3_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.SetIndex(Me._Label3_1, CType(1, Short))
        Me._Label3_1.Location = New System.Drawing.Point(48, 162)
        Me._Label3_1.Name = "_Label3_1"
        Me._Label3_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_1.Size = New System.Drawing.Size(220, 34)
        Me._Label3_1.TabIndex = 10
        Me._Label3_1.Text = "Os Comerciais acima listados foram cortados do Roteiro por Baixa da Veiculação"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.lblVeiculo)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(132, 240)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(343, 40)
        Me.Frame2.TabIndex = 14
        Me.Frame2.TabStop = False
        Me.Frame2.Visible = False
        '
        'lblVeiculo
        '
        Me.lblVeiculo.AutoSize = True
        Me.lblVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.lblVeiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVeiculo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeiculo.ForeColor = System.Drawing.Color.Blue
        Me.lblVeiculo.Location = New System.Drawing.Point(84, 15)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVeiculo.Size = New System.Drawing.Size(126, 16)
        Me.lblVeiculo.TabIndex = 15
        Me.lblVeiculo.Text = "Nome da Emissora"
        Me.lblVeiculo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'treBreak
        '
        Me.treBreak.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.treBreak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treBreak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treBreak.Indent = 16
        Me.treBreak.Location = New System.Drawing.Point(6, 45)
        Me.treBreak.Name = "treBreak"
        Me.treBreak.Size = New System.Drawing.Size(115, 361)
        Me.treBreak.TabIndex = 13
        '
        'frame1
        '
        Me.frame1.BackColor = System.Drawing.SystemColors.Control
        Me.frame1.Controls.Add(Me.txtPrograma)
        Me.frame1.Controls.Add(Me.chkMostrarRoteiro)
        Me.frame1.Controls.Add(Me.txtVeiculo)
        Me.frame1.Controls.Add(Me.txtData)
        Me.frame1.Enabled = False
        Me.frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frame1.Location = New System.Drawing.Point(207, 84)
        Me.frame1.Name = "frame1"
        Me.frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame1.Size = New System.Drawing.Size(244, 61)
        Me.frame1.TabIndex = 2
        Me.frame1.TabStop = False
        Me.frame1.Visible = False
        '
        'txtPrograma
        '
        Me.txtPrograma.AcceptsReturn = True
        Me.txtPrograma.BackColor = System.Drawing.Color.White
        Me.txtPrograma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrograma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrograma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPrograma.Location = New System.Drawing.Point(153, 15)
        Me.txtPrograma.MaxLength = 0
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrograma.Size = New System.Drawing.Size(85, 20)
        Me.txtPrograma.TabIndex = 16
        '
        'chkMostrarRoteiro
        '
        Me.chkMostrarRoteiro.BackColor = System.Drawing.SystemColors.Control
        Me.chkMostrarRoteiro.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMostrarRoteiro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarRoteiro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMostrarRoteiro.Location = New System.Drawing.Point(9, 39)
        Me.chkMostrarRoteiro.Name = "chkMostrarRoteiro"
        Me.chkMostrarRoteiro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMostrarRoteiro.Size = New System.Drawing.Size(70, 16)
        Me.chkMostrarRoteiro.TabIndex = 12
        Me.chkMostrarRoteiro.Text = "Mostrar"
        Me.chkMostrarRoteiro.UseVisualStyleBackColor = False
        '
        'txtVeiculo
        '
        Me.txtVeiculo.AcceptsReturn = True
        Me.txtVeiculo.BackColor = System.Drawing.Color.White
        Me.txtVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVeiculo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeiculo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtVeiculo.Location = New System.Drawing.Point(9, 15)
        Me.txtVeiculo.MaxLength = 0
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVeiculo.Size = New System.Drawing.Size(46, 20)
        Me.txtVeiculo.TabIndex = 4
        '
        'txtData
        '
        Me.txtData.AcceptsReturn = True
        Me.txtData.BackColor = System.Drawing.Color.White
        Me.txtData.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtData.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtData.Location = New System.Drawing.Point(63, 15)
        Me.txtData.MaxLength = 0
        Me.txtData.Name = "txtData"
        Me.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtData.Size = New System.Drawing.Size(85, 20)
        Me.txtData.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        '
        'tbOpcoes
        '
        Me.tbOpcoes.ImageList = Me.ImageList1
        Me.tbOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbConsistencia, Me.tbGuia, Me.tbAtualizar, Me.tbData, Me._tbOpcoes_Button6, Me.tbPrevious, Me.tbNext, Me.tbFirst, Me.tbLast, Me._tbOpcoes_Button11, Me.tbSair})
        Me.tbOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.tbOpcoes.Name = "tbOpcoes"
        Me.tbOpcoes.Size = New System.Drawing.Size(488, 42)
        Me.tbOpcoes.TabIndex = 0
        '
        'tbConsistencia
        '
        Me.tbConsistencia.AutoSize = False
        Me.tbConsistencia.ImageIndex = 3
        Me.tbConsistencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbConsistencia.Name = "tbConsistencia"
        Me.tbConsistencia.Size = New System.Drawing.Size(40, 39)
        Me.tbConsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbConsistencia.ToolTipText = "Comparar ocupação dos Intervalos"
        '
        'tbGuia
        '
        Me.tbGuia.AutoSize = False
        Me.tbGuia.ImageIndex = 5
        Me.tbGuia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbGuia.Name = "tbGuia"
        Me.tbGuia.Size = New System.Drawing.Size(40, 39)
        Me.tbGuia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbGuia.ToolTipText = "Mostrar/Ocultar Guia deste roteiro"
        '
        'tbAtualizar
        '
        Me.tbAtualizar.AutoSize = False
        Me.tbAtualizar.ImageIndex = 2
        Me.tbAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbAtualizar.Name = "tbAtualizar"
        Me.tbAtualizar.Size = New System.Drawing.Size(40, 39)
        Me.tbAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbAtualizar.ToolTipText = "Atualizar Dados deste roteiro"
        '
        'tbData
        '
        Me.tbData.AutoSize = False
        Me.tbData.ImageIndex = 12
        Me.tbData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbData.Name = "tbData"
        Me.tbData.Size = New System.Drawing.Size(40, 39)
        Me.tbData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbData.ToolTipText = "Selecionar novos roteiros"
        '
        '_tbOpcoes_Button6
        '
        Me._tbOpcoes_Button6.AutoSize = False
        Me._tbOpcoes_Button6.Name = "_tbOpcoes_Button6"
        Me._tbOpcoes_Button6.Size = New System.Drawing.Size(0, 39)
        '
        'tbPrevious
        '
        Me.tbPrevious.AutoSize = False
        Me.tbPrevious.ImageIndex = 10
        Me.tbPrevious.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbPrevious.Name = "tbPrevious"
        Me.tbPrevious.Size = New System.Drawing.Size(40, 39)
        Me.tbPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbPrevious.ToolTipText = "Rolar Simultaneamente para cima"
        '
        'tbNext
        '
        Me.tbNext.AutoSize = False
        Me.tbNext.ImageIndex = 9
        Me.tbNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbNext.Name = "tbNext"
        Me.tbNext.Size = New System.Drawing.Size(40, 39)
        Me.tbNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbNext.ToolTipText = "Rolar Simultaneamente para Baixo"
        '
        'tbFirst
        '
        Me.tbFirst.AutoSize = False
        Me.tbFirst.ImageIndex = 8
        Me.tbFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbFirst.Name = "tbFirst"
        Me.tbFirst.Size = New System.Drawing.Size(40, 39)
        Me.tbFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbFirst.ToolTipText = "Mover todos para a primeira linha"
        '
        'tbLast
        '
        Me.tbLast.AutoSize = False
        Me.tbLast.ImageIndex = 7
        Me.tbLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbLast.Name = "tbLast"
        Me.tbLast.Size = New System.Drawing.Size(40, 39)
        Me.tbLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbLast.ToolTipText = "Mover todos para a ultima linha"
        '
        '_tbOpcoes_Button11
        '
        Me._tbOpcoes_Button11.AutoSize = False
        Me._tbOpcoes_Button11.Name = "_tbOpcoes_Button11"
        Me._tbOpcoes_Button11.Size = New System.Drawing.Size(0, 39)
        '
        'tbSair
        '
        Me.tbSair.AutoSize = False
        Me.tbSair.ImageIndex = 0
        Me.tbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbSair.Name = "tbSair"
        Me.tbSair.Size = New System.Drawing.Size(40, 39)
        Me.tbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbSair.ToolTipText = "Fechar todos os roteirosa"
        '
        'cmdCancela
        '
        '
        'flxBreak
        '
        Me.flxBreak.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flxBreak.Location = New System.Drawing.Point(125, 43)
        Me.flxBreak.Name = "flxBreak"
        Me.flxBreak.OcxState = CType(resources.GetObject("flxBreak.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxBreak.Size = New System.Drawing.Size(356, 363)
        Me.flxBreak.TabIndex = 1
        '
        'frmComparaRoteiroV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(488, 413)
        Me.Controls.Add(Me.picCorte)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.treBreak)
        Me.Controls.Add(Me.frame1)
        Me.Controls.Add(Me.tbOpcoes)
        Me.Controls.Add(Me.flxBreak)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(266, 121)
        Me.MaximizeBox = False
        Me.Name = "frmComparaRoteiroV2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Consulta do Roteiro"
        Me.picCorte.ResumeLayout(False)
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxCorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.frame1.ResumeLayout(False)
        Me.frame1.PerformLayout()
        Me.tbOpcoes.ResumeLayout(False)
        Me.tbOpcoes.PerformLayout()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxBreak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents flxBreak As AxMSFlexGridLib.AxMSFlexGrid
#End Region 
End Class