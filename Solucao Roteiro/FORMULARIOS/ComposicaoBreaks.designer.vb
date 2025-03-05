<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmComposicaoBreaks
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        InitializeComponent()
        Me.MdiParent = SCTVNET.mdiPrincipal

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
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents flxCritica As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _cmdCriticaFechar_1 As System.Windows.Forms.Button
	Public WithEvents _cmdCriticaFechar_0 As System.Windows.Forms.Button
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblCritica As System.Windows.Forms.Label
	Public WithEvents picCritica As System.Windows.Forms.Panel
	Public WithEvents cboFaixaHoraria As System.Windows.Forms.ComboBox
	Public WithEvents txtInicio As System.Windows.Forms.TextBox
	Public WithEvents txtTermino As System.Windows.Forms.TextBox
	Public WithEvents txtDispoTotal As System.Windows.Forms.TextBox
	Public WithEvents txtDispoNet As System.Windows.Forms.TextBox
	Public WithEvents txtPctNet As System.Windows.Forms.TextBox
	Public WithEvents txtPctTotal As System.Windows.Forms.TextBox
	Public WithEvents _chkDiasSemana_0 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiasSemana_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiasSemana_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiasSemana_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiasSemana_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiasSemana_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiasSemana_6 As System.Windows.Forms.CheckBox
	Public WithEvents fraExibicao As System.Windows.Forms.GroupBox
	Public WithEvents cmdUltimaData As System.Windows.Forms.Button
    Public WithEvents Line3 As System.Windows.Forms.Label
	Public WithEvents lblUltimaData As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Line2 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_9 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_10 As System.Windows.Forms.Label
	Public WithEvents fraPropagar As System.Windows.Forms.GroupBox
	Public WithEvents txtPctLocal As System.Windows.Forms.TextBox
	Public WithEvents txtDispoLocal As System.Windows.Forms.TextBox
	Public WithEvents _lblCampos_4 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_5 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_6 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_2 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_3 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_7 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_0 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_1 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_8 As System.Windows.Forms.Label
	Public WithEvents fraProgramacao As System.Windows.Forms.GroupBox
    Public WithEvents tabOpcoes As AxComctlLib.AxToolbar
	Public WithEvents chkMarcarTodos As System.Windows.Forms.CheckBox
	Public WithEvents picDesmarcado As System.Windows.Forms.PictureBox
	Public WithEvents picMarcado As System.Windows.Forms.PictureBox
	Public WithEvents cmdSobe As System.Windows.Forms.Button
	Public WithEvents cmdDesce As System.Windows.Forms.Button
	Public WithEvents txtRodapeInter As System.Windows.Forms.TextBox
	Public WithEvents _cmdfechar_1 As System.Windows.Forms.Button
	Public WithEvents _cmdfechar_0 As System.Windows.Forms.Button
	Public WithEvents lblRodape As System.Windows.Forms.Label
	Public WithEvents picRodape As System.Windows.Forms.Panel
	Public WithEvents flxComposicao As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents imgTools As AxComctlLib.AxImageList
	Public WithEvents fraBreaks As System.Windows.Forms.GroupBox
    Public WithEvents tabComposicao As AxComctlLib.AxTabStrip
	Public WithEvents chkIndicanet As System.Windows.Forms.CheckBox
    Public WithEvents cmdUsuario As System.Windows.Forms.Button
	Public WithEvents cmdExecutar As System.Windows.Forms.Button
    Public WithEvents _lblCampos_18 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents chkDiasSemana As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmdCriticaFechar As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents cmdfechar As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComposicaoBreaks))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdUltimaData = New System.Windows.Forms.Button
        Me.cmdUsuario = New System.Windows.Forms.Button
        Me.cmdExecutar = New System.Windows.Forms.Button
        Me.cmdSobe = New System.Windows.Forms.Button
        Me.cmdDesce = New System.Windows.Forms.Button
        Me.picCritica = New System.Windows.Forms.Panel
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.flxCritica = New AxMSFlexGridLib.AxMSFlexGrid
        Me._cmdCriticaFechar_1 = New System.Windows.Forms.Button
        Me._cmdCriticaFechar_0 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCritica = New System.Windows.Forms.Label
        Me.fraProgramacao = New System.Windows.Forms.GroupBox
        Me.cboFaixaHoraria = New System.Windows.Forms.ComboBox
        Me.txtInicio = New System.Windows.Forms.TextBox
        Me.txtTermino = New System.Windows.Forms.TextBox
        Me.txtDispoTotal = New System.Windows.Forms.TextBox
        Me.txtDispoNet = New System.Windows.Forms.TextBox
        Me.txtPctNet = New System.Windows.Forms.TextBox
        Me.txtPctTotal = New System.Windows.Forms.TextBox
        Me.fraExibicao = New System.Windows.Forms.GroupBox
        Me._chkDiasSemana_0 = New System.Windows.Forms.CheckBox
        Me._chkDiasSemana_1 = New System.Windows.Forms.CheckBox
        Me._chkDiasSemana_2 = New System.Windows.Forms.CheckBox
        Me._chkDiasSemana_3 = New System.Windows.Forms.CheckBox
        Me._chkDiasSemana_4 = New System.Windows.Forms.CheckBox
        Me._chkDiasSemana_5 = New System.Windows.Forms.CheckBox
        Me._chkDiasSemana_6 = New System.Windows.Forms.CheckBox
        Me.fraPropagar = New System.Windows.Forms.GroupBox
        Me.UcDataAte = New WCL_SCTV.UC.UCData
        Me.UcDatade = New WCL_SCTV.UC.UCData
        Me.Line3 = New System.Windows.Forms.Label
        Me.lblUltimaData = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Line2 = New System.Windows.Forms.Label
        Me._lblCampos_9 = New System.Windows.Forms.Label
        Me._lblCampos_10 = New System.Windows.Forms.Label
        Me.txtPctLocal = New System.Windows.Forms.TextBox
        Me.txtDispoLocal = New System.Windows.Forms.TextBox
        Me._lblCampos_4 = New System.Windows.Forms.Label
        Me._lblCampos_5 = New System.Windows.Forms.Label
        Me._lblCampos_6 = New System.Windows.Forms.Label
        Me._lblCampos_2 = New System.Windows.Forms.Label
        Me._lblCampos_3 = New System.Windows.Forms.Label
        Me._lblCampos_7 = New System.Windows.Forms.Label
        Me._lblCampos_0 = New System.Windows.Forms.Label
        Me._lblCampos_1 = New System.Windows.Forms.Label
        Me._lblCampos_8 = New System.Windows.Forms.Label
        Me.fraBreaks = New System.Windows.Forms.GroupBox
        Me.tabOpcoes = New AxComctlLib.AxToolbar
        Me.chkMarcarTodos = New System.Windows.Forms.CheckBox
        Me.picDesmarcado = New System.Windows.Forms.PictureBox
        Me.picMarcado = New System.Windows.Forms.PictureBox
        Me.picRodape = New System.Windows.Forms.Panel
        Me.txtRodapeInter = New System.Windows.Forms.TextBox
        Me._cmdfechar_1 = New System.Windows.Forms.Button
        Me._cmdfechar_0 = New System.Windows.Forms.Button
        Me.lblRodape = New System.Windows.Forms.Label
        Me.flxComposicao = New AxMSFlexGridLib.AxMSFlexGrid
        Me.imgTools = New AxComctlLib.AxImageList
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.ucPrograma = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.UcData = New WCL_SCTV.UC.UCData
        Me._lblCampos_18 = New System.Windows.Forms.Label
        Me.chkIndicanet = New System.Windows.Forms.CheckBox
        Me.chkDiasSemana = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.cmdCriticaFechar = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdfechar = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.picBreaks = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblDispoTotal = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblComposiçãoTotal = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblComposicaoLocal = New System.Windows.Forms.Label
        Me.lblComposicaoNet = New System.Windows.Forms.Label
        Me.lblDispoLocal = New System.Windows.Forms.Label
        Me.lblDispoNet = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabComposicao = New AxComctlLib.AxTabStrip
        Me.btnOkCancel = New WUC.ucButton
        Me.picCritica.SuspendLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxCritica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraProgramacao.SuspendLayout()
        Me.fraExibicao.SuspendLayout()
        Me.fraPropagar.SuspendLayout()
        Me.fraBreaks.SuspendLayout()
        CType(Me.tabOpcoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesmarcado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMarcado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picRodape.SuspendLayout()
        CType(Me.flxComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.chkDiasSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCriticaFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBreaks.SuspendLayout()
        CType(Me.tabComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUltimaData
        '
        Me.cmdUltimaData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUltimaData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUltimaData.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUltimaData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUltimaData.Location = New System.Drawing.Point(113, 83)
        Me.cmdUltimaData.Name = "cmdUltimaData"
        Me.cmdUltimaData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUltimaData.Size = New System.Drawing.Size(25, 21)
        Me.cmdUltimaData.TabIndex = 74
        Me.cmdUltimaData.Text = "Ç"
        Me.cmdUltimaData.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdUltimaData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.cmdUltimaData, "Enviar Ultima Data Composta Para o Campo Até")
        Me.cmdUltimaData.UseVisualStyleBackColor = False
        '
        'cmdUsuario
        '
        Me.cmdUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUsuario.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUsuario.Location = New System.Drawing.Point(578, 32)
        Me.cmdUsuario.Name = "cmdUsuario"
        Me.cmdUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUsuario.Size = New System.Drawing.Size(85, 34)
        Me.cmdUsuario.TabIndex = 77
        Me.cmdUsuario.Text = "&Ver Usuários "
        Me.ToolTip1.SetToolTip(Me.cmdUsuario, "Consulta todos os Usuários Ativos na Composição de Breaks")
        Me.cmdUsuario.UseVisualStyleBackColor = False
        '
        'cmdExecutar
        '
        Me.cmdExecutar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExecutar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExecutar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExecutar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExecutar.Location = New System.Drawing.Point(479, 32)
        Me.cmdExecutar.Name = "cmdExecutar"
        Me.cmdExecutar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExecutar.Size = New System.Drawing.Size(85, 34)
        Me.cmdExecutar.TabIndex = 3
        Me.cmdExecutar.Text = "&Carregar"
        Me.ToolTip1.SetToolTip(Me.cmdExecutar, "Executa a Consulta")
        Me.cmdExecutar.UseVisualStyleBackColor = False
        '
        'cmdSobe
        '
        Me.cmdSobe.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSobe.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSobe.Enabled = False
        Me.cmdSobe.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSobe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSobe.Image = CType(resources.GetObject("cmdSobe.Image"), System.Drawing.Image)
        Me.cmdSobe.Location = New System.Drawing.Point(480, 18)
        Me.cmdSobe.Name = "cmdSobe"
        Me.cmdSobe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSobe.Size = New System.Drawing.Size(37, 33)
        Me.cmdSobe.TabIndex = 84
        Me.cmdSobe.TabStop = False
        Me.cmdSobe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdSobe, "Move o Intervalo uma posição acima")
        Me.cmdSobe.UseVisualStyleBackColor = False
        '
        'cmdDesce
        '
        Me.cmdDesce.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDesce.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDesce.Enabled = False
        Me.cmdDesce.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDesce.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDesce.Image = CType(resources.GetObject("cmdDesce.Image"), System.Drawing.Image)
        Me.cmdDesce.Location = New System.Drawing.Point(519, 18)
        Me.cmdDesce.Name = "cmdDesce"
        Me.cmdDesce.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDesce.Size = New System.Drawing.Size(37, 33)
        Me.cmdDesce.TabIndex = 83
        Me.cmdDesce.TabStop = False
        Me.cmdDesce.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdDesce, "Move o Intervalo uma posição abaixo")
        Me.cmdDesce.UseVisualStyleBackColor = False
        '
        'picCritica
        '
        Me.picCritica.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.picCritica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCritica.Controls.Add(Me.Picture1)
        Me.picCritica.Controls.Add(Me.flxCritica)
        Me.picCritica.Controls.Add(Me._cmdCriticaFechar_1)
        Me.picCritica.Controls.Add(Me._cmdCriticaFechar_0)
        Me.picCritica.Controls.Add(Me.Label2)
        Me.picCritica.Controls.Add(Me.lblCritica)
        Me.picCritica.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCritica.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picCritica.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picCritica.Location = New System.Drawing.Point(120, 352)
        Me.picCritica.Name = "picCritica"
        Me.picCritica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picCritica.Size = New System.Drawing.Size(457, 37)
        Me.picCritica.TabIndex = 76
        Me.picCritica.TabStop = True
        Me.picCritica.Visible = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.Location = New System.Drawing.Point(6, 225)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(32, 32)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picture1.TabIndex = 82
        Me.Picture1.TabStop = False
        '
        'flxCritica
        '
        Me.flxCritica.Location = New System.Drawing.Point(9, 30)
        Me.flxCritica.Name = "flxCritica"
        Me.flxCritica.OcxState = CType(resources.GetObject("flxCritica.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxCritica.Size = New System.Drawing.Size(442, 193)
        Me.flxCritica.TabIndex = 79
        '
        '_cmdCriticaFechar_1
        '
        Me._cmdCriticaFechar_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCriticaFechar_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCriticaFechar_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCriticaFechar_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCriticaFechar.SetIndex(Me._cmdCriticaFechar_1, CType(1, Short))
        Me._cmdCriticaFechar_1.Location = New System.Drawing.Point(440, 1)
        Me._cmdCriticaFechar_1.Name = "_cmdCriticaFechar_1"
        Me._cmdCriticaFechar_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCriticaFechar_1.Size = New System.Drawing.Size(16, 14)
        Me._cmdCriticaFechar_1.TabIndex = 78
        Me._cmdCriticaFechar_1.Text = "X"
        Me._cmdCriticaFechar_1.UseVisualStyleBackColor = False
        '
        '_cmdCriticaFechar_0
        '
        Me._cmdCriticaFechar_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCriticaFechar_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCriticaFechar_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCriticaFechar_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCriticaFechar.SetIndex(Me._cmdCriticaFechar_0, CType(0, Short))
        Me._cmdCriticaFechar_0.Location = New System.Drawing.Point(385, 228)
        Me._cmdCriticaFechar_0.Name = "_cmdCriticaFechar_0"
        Me._cmdCriticaFechar_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCriticaFechar_0.Size = New System.Drawing.Size(64, 22)
        Me._cmdCriticaFechar_0.TabIndex = 77
        Me._cmdCriticaFechar_0.Text = "&Fechar"
        Me._cmdCriticaFechar_0.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(39, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(243, 14)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "As datas relacionadas não foram gravadas "
        '
        'lblCritica
        '
        Me.lblCritica.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCritica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCritica.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCritica.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCritica.ForeColor = System.Drawing.Color.White
        Me.lblCritica.Location = New System.Drawing.Point(0, 0)
        Me.lblCritica.Name = "lblCritica"
        Me.lblCritica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCritica.Size = New System.Drawing.Size(530, 19)
        Me.lblCritica.TabIndex = 80
        Me.lblCritica.Text = "  Critica da gravação da Composição de Breaks"
        '
        'fraProgramacao
        '
        Me.fraProgramacao.BackColor = System.Drawing.SystemColors.Control
        Me.fraProgramacao.Controls.Add(Me.cboFaixaHoraria)
        Me.fraProgramacao.Controls.Add(Me.txtInicio)
        Me.fraProgramacao.Controls.Add(Me.txtTermino)
        Me.fraProgramacao.Controls.Add(Me.txtDispoTotal)
        Me.fraProgramacao.Controls.Add(Me.txtDispoNet)
        Me.fraProgramacao.Controls.Add(Me.txtPctNet)
        Me.fraProgramacao.Controls.Add(Me.txtPctTotal)
        Me.fraProgramacao.Controls.Add(Me.fraExibicao)
        Me.fraProgramacao.Controls.Add(Me.fraPropagar)
        Me.fraProgramacao.Controls.Add(Me.txtPctLocal)
        Me.fraProgramacao.Controls.Add(Me.txtDispoLocal)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_4)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_5)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_6)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_2)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_3)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_7)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_0)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_1)
        Me.fraProgramacao.Controls.Add(Me._lblCampos_8)
        Me.fraProgramacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraProgramacao.ForeColor = System.Drawing.SystemColors.Highlight
        Me.fraProgramacao.Location = New System.Drawing.Point(11, 140)
        Me.fraProgramacao.Name = "fraProgramacao"
        Me.fraProgramacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraProgramacao.Size = New System.Drawing.Size(662, 308)
        Me.fraProgramacao.TabIndex = 18
        Me.fraProgramacao.TabStop = False
        Me.fraProgramacao.Text = "fraProgramacao"
        '
        'cboFaixaHoraria
        '
        Me.cboFaixaHoraria.BackColor = System.Drawing.SystemColors.Window
        Me.cboFaixaHoraria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboFaixaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboFaixaHoraria.Enabled = False
        Me.cboFaixaHoraria.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFaixaHoraria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFaixaHoraria.Location = New System.Drawing.Point(112, 69)
        Me.cboFaixaHoraria.Name = "cboFaixaHoraria"
        Me.cboFaixaHoraria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboFaixaHoraria.Size = New System.Drawing.Size(134, 21)
        Me.cboFaixaHoraria.TabIndex = 21
        '
        'txtInicio
        '
        Me.txtInicio.AcceptsReturn = True
        Me.txtInicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInicio.Enabled = False
        Me.txtInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio.ForeColor = System.Drawing.Color.Black
        Me.txtInicio.Location = New System.Drawing.Point(112, 20)
        Me.txtInicio.MaxLength = 5
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInicio.Size = New System.Drawing.Size(67, 20)
        Me.txtInicio.TabIndex = 5
        Me.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTermino
        '
        Me.txtTermino.AcceptsReturn = True
        Me.txtTermino.BackColor = System.Drawing.SystemColors.Window
        Me.txtTermino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTermino.Enabled = False
        Me.txtTermino.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTermino.ForeColor = System.Drawing.Color.Black
        Me.txtTermino.Location = New System.Drawing.Point(112, 45)
        Me.txtTermino.MaxLength = 5
        Me.txtTermino.Name = "txtTermino"
        Me.txtTermino.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTermino.Size = New System.Drawing.Size(67, 20)
        Me.txtTermino.TabIndex = 6
        Me.txtTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDispoTotal
        '
        Me.txtDispoTotal.AcceptsReturn = True
        Me.txtDispoTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtDispoTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDispoTotal.Enabled = False
        Me.txtDispoTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispoTotal.ForeColor = System.Drawing.Color.Black
        Me.txtDispoTotal.Location = New System.Drawing.Point(420, 21)
        Me.txtDispoTotal.MaxLength = 4
        Me.txtDispoTotal.Name = "txtDispoTotal"
        Me.txtDispoTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDispoTotal.Size = New System.Drawing.Size(53, 20)
        Me.txtDispoTotal.TabIndex = 8
        Me.txtDispoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDispoNet
        '
        Me.txtDispoNet.AcceptsReturn = True
        Me.txtDispoNet.BackColor = System.Drawing.SystemColors.Window
        Me.txtDispoNet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDispoNet.Enabled = False
        Me.txtDispoNet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispoNet.ForeColor = System.Drawing.Color.Black
        Me.txtDispoNet.Location = New System.Drawing.Point(420, 45)
        Me.txtDispoNet.MaxLength = 4
        Me.txtDispoNet.Name = "txtDispoNet"
        Me.txtDispoNet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDispoNet.Size = New System.Drawing.Size(53, 20)
        Me.txtDispoNet.TabIndex = 9
        Me.txtDispoNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPctNet
        '
        Me.txtPctNet.AcceptsReturn = True
        Me.txtPctNet.BackColor = System.Drawing.SystemColors.Window
        Me.txtPctNet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPctNet.Enabled = False
        Me.txtPctNet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPctNet.ForeColor = System.Drawing.Color.Black
        Me.txtPctNet.Location = New System.Drawing.Point(581, 45)
        Me.txtPctNet.MaxLength = 5
        Me.txtPctNet.Name = "txtPctNet"
        Me.txtPctNet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPctNet.Size = New System.Drawing.Size(45, 20)
        Me.txtPctNet.TabIndex = 12
        Me.txtPctNet.TabStop = False
        Me.txtPctNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPctTotal
        '
        Me.txtPctTotal.AcceptsReturn = True
        Me.txtPctTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtPctTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPctTotal.Enabled = False
        Me.txtPctTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPctTotal.ForeColor = System.Drawing.Color.Black
        Me.txtPctTotal.Location = New System.Drawing.Point(581, 21)
        Me.txtPctTotal.MaxLength = 5
        Me.txtPctTotal.Name = "txtPctTotal"
        Me.txtPctTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPctTotal.Size = New System.Drawing.Size(45, 20)
        Me.txtPctTotal.TabIndex = 11
        Me.txtPctTotal.TabStop = False
        Me.txtPctTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fraExibicao
        '
        Me.fraExibicao.BackColor = System.Drawing.SystemColors.Control
        Me.fraExibicao.Controls.Add(Me._chkDiasSemana_0)
        Me.fraExibicao.Controls.Add(Me._chkDiasSemana_1)
        Me.fraExibicao.Controls.Add(Me._chkDiasSemana_2)
        Me.fraExibicao.Controls.Add(Me._chkDiasSemana_3)
        Me.fraExibicao.Controls.Add(Me._chkDiasSemana_4)
        Me.fraExibicao.Controls.Add(Me._chkDiasSemana_5)
        Me.fraExibicao.Controls.Add(Me._chkDiasSemana_6)
        Me.fraExibicao.Enabled = False
        Me.fraExibicao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraExibicao.ForeColor = System.Drawing.Color.Black
        Me.fraExibicao.Location = New System.Drawing.Point(26, 102)
        Me.fraExibicao.Name = "fraExibicao"
        Me.fraExibicao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraExibicao.Size = New System.Drawing.Size(219, 169)
        Me.fraExibicao.TabIndex = 39
        Me.fraExibicao.TabStop = False
        Me.fraExibicao.Text = "Dias para  Exibição"
        '
        '_chkDiasSemana_0
        '
        Me._chkDiasSemana_0.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiasSemana_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiasSemana_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiasSemana_0.ForeColor = System.Drawing.Color.Black
        Me.chkDiasSemana.SetIndex(Me._chkDiasSemana_0, CType(0, Short))
        Me._chkDiasSemana_0.Location = New System.Drawing.Point(22, 20)
        Me._chkDiasSemana_0.Name = "_chkDiasSemana_0"
        Me._chkDiasSemana_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiasSemana_0.Size = New System.Drawing.Size(99, 19)
        Me._chkDiasSemana_0.TabIndex = 30
        Me._chkDiasSemana_0.Text = "Domingo"
        Me._chkDiasSemana_0.UseVisualStyleBackColor = False
        '
        '_chkDiasSemana_1
        '
        Me._chkDiasSemana_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiasSemana_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiasSemana_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiasSemana_1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.chkDiasSemana.SetIndex(Me._chkDiasSemana_1, CType(1, Short))
        Me._chkDiasSemana_1.Location = New System.Drawing.Point(22, 40)
        Me._chkDiasSemana_1.Name = "_chkDiasSemana_1"
        Me._chkDiasSemana_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiasSemana_1.Size = New System.Drawing.Size(99, 20)
        Me._chkDiasSemana_1.TabIndex = 31
        Me._chkDiasSemana_1.Text = "Segunda"
        Me._chkDiasSemana_1.UseVisualStyleBackColor = False
        '
        '_chkDiasSemana_2
        '
        Me._chkDiasSemana_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiasSemana_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiasSemana_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiasSemana_2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.chkDiasSemana.SetIndex(Me._chkDiasSemana_2, CType(2, Short))
        Me._chkDiasSemana_2.Location = New System.Drawing.Point(22, 60)
        Me._chkDiasSemana_2.Name = "_chkDiasSemana_2"
        Me._chkDiasSemana_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiasSemana_2.Size = New System.Drawing.Size(99, 20)
        Me._chkDiasSemana_2.TabIndex = 32
        Me._chkDiasSemana_2.Text = "Terça"
        Me._chkDiasSemana_2.UseVisualStyleBackColor = False
        '
        '_chkDiasSemana_3
        '
        Me._chkDiasSemana_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiasSemana_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiasSemana_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiasSemana_3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.chkDiasSemana.SetIndex(Me._chkDiasSemana_3, CType(3, Short))
        Me._chkDiasSemana_3.Location = New System.Drawing.Point(22, 80)
        Me._chkDiasSemana_3.Name = "_chkDiasSemana_3"
        Me._chkDiasSemana_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiasSemana_3.Size = New System.Drawing.Size(99, 20)
        Me._chkDiasSemana_3.TabIndex = 33
        Me._chkDiasSemana_3.Text = "Quarta"
        Me._chkDiasSemana_3.UseVisualStyleBackColor = False
        '
        '_chkDiasSemana_4
        '
        Me._chkDiasSemana_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiasSemana_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiasSemana_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiasSemana_4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.chkDiasSemana.SetIndex(Me._chkDiasSemana_4, CType(4, Short))
        Me._chkDiasSemana_4.Location = New System.Drawing.Point(22, 100)
        Me._chkDiasSemana_4.Name = "_chkDiasSemana_4"
        Me._chkDiasSemana_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiasSemana_4.Size = New System.Drawing.Size(99, 19)
        Me._chkDiasSemana_4.TabIndex = 40
        Me._chkDiasSemana_4.Text = "Quinta"
        Me._chkDiasSemana_4.UseVisualStyleBackColor = False
        '
        '_chkDiasSemana_5
        '
        Me._chkDiasSemana_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiasSemana_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiasSemana_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiasSemana_5.ForeColor = System.Drawing.SystemColors.MenuText
        Me.chkDiasSemana.SetIndex(Me._chkDiasSemana_5, CType(5, Short))
        Me._chkDiasSemana_5.Location = New System.Drawing.Point(22, 120)
        Me._chkDiasSemana_5.Name = "_chkDiasSemana_5"
        Me._chkDiasSemana_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiasSemana_5.Size = New System.Drawing.Size(99, 21)
        Me._chkDiasSemana_5.TabIndex = 34
        Me._chkDiasSemana_5.Text = "Sexta"
        Me._chkDiasSemana_5.UseVisualStyleBackColor = False
        '
        '_chkDiasSemana_6
        '
        Me._chkDiasSemana_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiasSemana_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiasSemana_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiasSemana_6.ForeColor = System.Drawing.SystemColors.MenuText
        Me.chkDiasSemana.SetIndex(Me._chkDiasSemana_6, CType(6, Short))
        Me._chkDiasSemana_6.Location = New System.Drawing.Point(22, 142)
        Me._chkDiasSemana_6.Name = "_chkDiasSemana_6"
        Me._chkDiasSemana_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiasSemana_6.Size = New System.Drawing.Size(99, 20)
        Me._chkDiasSemana_6.TabIndex = 35
        Me._chkDiasSemana_6.Text = "Sábado"
        Me._chkDiasSemana_6.UseVisualStyleBackColor = False
        '
        'fraPropagar
        '
        Me.fraPropagar.BackColor = System.Drawing.SystemColors.Control
        Me.fraPropagar.Controls.Add(Me.cmdUltimaData)
        Me.fraPropagar.Controls.Add(Me.UcDataAte)
        Me.fraPropagar.Controls.Add(Me.UcDatade)
        Me.fraPropagar.Controls.Add(Me.Line3)
        Me.fraPropagar.Controls.Add(Me.lblUltimaData)
        Me.fraPropagar.Controls.Add(Me.Label8)
        Me.fraPropagar.Controls.Add(Me.Line2)
        Me.fraPropagar.Controls.Add(Me._lblCampos_9)
        Me.fraPropagar.Controls.Add(Me._lblCampos_10)
        Me.fraPropagar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraPropagar.ForeColor = System.Drawing.Color.Black
        Me.fraPropagar.Location = New System.Drawing.Point(295, 102)
        Me.fraPropagar.Name = "fraPropagar"
        Me.fraPropagar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraPropagar.Size = New System.Drawing.Size(334, 118)
        Me.fraPropagar.TabIndex = 36
        Me.fraPropagar.TabStop = False
        Me.fraPropagar.Text = "Propagar no Período"
        '
        'UcDataAte
        '
        Me.UcDataAte.BackColor = System.Drawing.Color.Transparent
        Me.UcDataAte.DateTime = New Date(CType(0, Long))
        Me.UcDataAte.Formato = "dd/MM/yyyy"
        Me.UcDataAte.Hoje = False
        Me.UcDataAte.Location = New System.Drawing.Point(45, 55)
        Me.UcDataAte.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcDataAte.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcDataAte.Name = "UcDataAte"
        Me.UcDataAte.Permite_Futuro = True
        Me.UcDataAte.Permite_Limpar = True
        Me.UcDataAte.Permite_Passado = True
        Me.UcDataAte.Preenchimento_Obrigatorio = False
        Me.UcDataAte.Size = New System.Drawing.Size(115, 25)
        Me.UcDataAte.TabIndex = 92
        '
        'UcDatade
        '
        Me.UcDatade.BackColor = System.Drawing.Color.Transparent
        Me.UcDatade.DateTime = New Date(CType(0, Long))
        Me.UcDatade.Formato = "dd/MM/yyyy "
        Me.UcDatade.Hoje = False
        Me.UcDatade.Location = New System.Drawing.Point(45, 23)
        Me.UcDatade.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcDatade.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcDatade.Name = "UcDatade"
        Me.UcDatade.Permite_Futuro = True
        Me.UcDatade.Permite_Limpar = True
        Me.UcDatade.Permite_Passado = True
        Me.UcDatade.Preenchimento_Obrigatorio = False
        Me.UcDatade.Size = New System.Drawing.Size(115, 25)
        Me.UcDatade.TabIndex = 91
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Gainsboro
        Me.Line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Line3.Location = New System.Drawing.Point(165, 8)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(2, 110)
        Me.Line3.TabIndex = 2
        '
        'lblUltimaData
        '
        Me.lblUltimaData.BackColor = System.Drawing.Color.White
        Me.lblUltimaData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUltimaData.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUltimaData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUltimaData.Location = New System.Drawing.Point(209, 59)
        Me.lblUltimaData.Name = "lblUltimaData"
        Me.lblUltimaData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUltimaData.Size = New System.Drawing.Size(80, 19)
        Me.lblUltimaData.TabIndex = 73
        Me.lblUltimaData.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(180, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(133, 15)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Última Data Composta"
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Line2.Location = New System.Drawing.Point(166, 8)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(1, 92)
        Me.Line2.TabIndex = 76
        '
        '_lblCampos_9
        '
        Me._lblCampos_9.AutoSize = True
        Me._lblCampos_9.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_9.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblCampos.SetIndex(Me._lblCampos_9, CType(9, Short))
        Me._lblCampos_9.Location = New System.Drawing.Point(19, 59)
        Me._lblCampos_9.Name = "_lblCampos_9"
        Me._lblCampos_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_9.Size = New System.Drawing.Size(24, 15)
        Me._lblCampos_9.TabIndex = 38
        Me._lblCampos_9.Text = "Até"
        '
        '_lblCampos_10
        '
        Me._lblCampos_10.AutoSize = True
        Me._lblCampos_10.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_10.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblCampos.SetIndex(Me._lblCampos_10, CType(10, Short))
        Me._lblCampos_10.Location = New System.Drawing.Point(20, 29)
        Me._lblCampos_10.Name = "_lblCampos_10"
        Me._lblCampos_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_10.Size = New System.Drawing.Size(23, 15)
        Me._lblCampos_10.TabIndex = 37
        Me._lblCampos_10.Text = "De"
        '
        'txtPctLocal
        '
        Me.txtPctLocal.AcceptsReturn = True
        Me.txtPctLocal.BackColor = System.Drawing.SystemColors.Window
        Me.txtPctLocal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPctLocal.Enabled = False
        Me.txtPctLocal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPctLocal.ForeColor = System.Drawing.Color.Black
        Me.txtPctLocal.Location = New System.Drawing.Point(581, 69)
        Me.txtPctLocal.MaxLength = 5
        Me.txtPctLocal.Name = "txtPctLocal"
        Me.txtPctLocal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPctLocal.Size = New System.Drawing.Size(45, 20)
        Me.txtPctLocal.TabIndex = 13
        Me.txtPctLocal.TabStop = False
        Me.txtPctLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDispoLocal
        '
        Me.txtDispoLocal.AcceptsReturn = True
        Me.txtDispoLocal.BackColor = System.Drawing.SystemColors.Window
        Me.txtDispoLocal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDispoLocal.Enabled = False
        Me.txtDispoLocal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispoLocal.ForeColor = System.Drawing.Color.Black
        Me.txtDispoLocal.Location = New System.Drawing.Point(420, 69)
        Me.txtDispoLocal.MaxLength = 4
        Me.txtDispoLocal.Name = "txtDispoLocal"
        Me.txtDispoLocal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDispoLocal.Size = New System.Drawing.Size(53, 20)
        Me.txtDispoLocal.TabIndex = 10
        Me.txtDispoLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lblCampos_4
        '
        Me._lblCampos_4.AutoSize = True
        Me._lblCampos_4.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblCampos.SetIndex(Me._lblCampos_4, CType(4, Short))
        Me._lblCampos_4.Location = New System.Drawing.Point(32, 72)
        Me._lblCampos_4.Name = "_lblCampos_4"
        Me._lblCampos_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_4.Size = New System.Drawing.Size(71, 14)
        Me._lblCampos_4.TabIndex = 88
        Me._lblCampos_4.Text = "Faixa Horária"
        '
        '_lblCampos_5
        '
        Me._lblCampos_5.AutoSize = True
        Me._lblCampos_5.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_5.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_5, CType(5, Short))
        Me._lblCampos_5.Location = New System.Drawing.Point(32, 24)
        Me._lblCampos_5.Name = "_lblCampos_5"
        Me._lblCampos_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_5.Size = New System.Drawing.Size(57, 14)
        Me._lblCampos_5.TabIndex = 48
        Me._lblCampos_5.Text = "Hora Inicio"
        '
        '_lblCampos_6
        '
        Me._lblCampos_6.AutoSize = True
        Me._lblCampos_6.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_6.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_6, CType(6, Short))
        Me._lblCampos_6.Location = New System.Drawing.Point(32, 48)
        Me._lblCampos_6.Name = "_lblCampos_6"
        Me._lblCampos_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_6.Size = New System.Drawing.Size(71, 14)
        Me._lblCampos_6.TabIndex = 47
        Me._lblCampos_6.Text = "Hora Término"
        '
        '_lblCampos_2
        '
        Me._lblCampos_2.AutoSize = True
        Me._lblCampos_2.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_2.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_2, CType(2, Short))
        Me._lblCampos_2.Location = New System.Drawing.Point(300, 48)
        Me._lblCampos_2.Name = "_lblCampos_2"
        Me._lblCampos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_2.Size = New System.Drawing.Size(97, 14)
        Me._lblCampos_2.TabIndex = 46
        Me._lblCampos_2.Text = "Disponibilidade Net"
        '
        '_lblCampos_3
        '
        Me._lblCampos_3.AutoSize = True
        Me._lblCampos_3.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_3.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_3, CType(3, Short))
        Me._lblCampos_3.Location = New System.Drawing.Point(300, 72)
        Me._lblCampos_3.Name = "_lblCampos_3"
        Me._lblCampos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_3.Size = New System.Drawing.Size(107, 14)
        Me._lblCampos_3.TabIndex = 45
        Me._lblCampos_3.Text = "Disponibilidade Local"
        '
        '_lblCampos_7
        '
        Me._lblCampos_7.AutoSize = True
        Me._lblCampos_7.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_7.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_7, CType(7, Short))
        Me._lblCampos_7.Location = New System.Drawing.Point(300, 24)
        Me._lblCampos_7.Name = "_lblCampos_7"
        Me._lblCampos_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_7.Size = New System.Drawing.Size(104, 14)
        Me._lblCampos_7.TabIndex = 44
        Me._lblCampos_7.Text = "Disponibilidade Total"
        '
        '_lblCampos_0
        '
        Me._lblCampos_0.AutoSize = True
        Me._lblCampos_0.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_0.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_0, CType(0, Short))
        Me._lblCampos_0.Location = New System.Drawing.Point(561, 23)
        Me._lblCampos_0.Name = "_lblCampos_0"
        Me._lblCampos_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_0.Size = New System.Drawing.Size(17, 14)
        Me._lblCampos_0.TabIndex = 43
        Me._lblCampos_0.Text = "%"
        '
        '_lblCampos_1
        '
        Me._lblCampos_1.AutoSize = True
        Me._lblCampos_1.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_1.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_1, CType(1, Short))
        Me._lblCampos_1.Location = New System.Drawing.Point(561, 47)
        Me._lblCampos_1.Name = "_lblCampos_1"
        Me._lblCampos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_1.Size = New System.Drawing.Size(17, 14)
        Me._lblCampos_1.TabIndex = 42
        Me._lblCampos_1.Text = "%"
        '
        '_lblCampos_8
        '
        Me._lblCampos_8.AutoSize = True
        Me._lblCampos_8.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_8.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_8, CType(8, Short))
        Me._lblCampos_8.Location = New System.Drawing.Point(561, 71)
        Me._lblCampos_8.Name = "_lblCampos_8"
        Me._lblCampos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_8.Size = New System.Drawing.Size(17, 14)
        Me._lblCampos_8.TabIndex = 41
        Me._lblCampos_8.Text = "%"
        '
        'fraBreaks
        '
        Me.fraBreaks.BackColor = System.Drawing.SystemColors.Control
        Me.fraBreaks.Controls.Add(Me.tabOpcoes)
        Me.fraBreaks.Controls.Add(Me.chkMarcarTodos)
        Me.fraBreaks.Controls.Add(Me.picDesmarcado)
        Me.fraBreaks.Controls.Add(Me.picMarcado)
        Me.fraBreaks.Controls.Add(Me.cmdSobe)
        Me.fraBreaks.Controls.Add(Me.cmdDesce)
        Me.fraBreaks.Controls.Add(Me.picRodape)
        Me.fraBreaks.Controls.Add(Me.flxComposicao)
        Me.fraBreaks.Controls.Add(Me.imgTools)
        Me.fraBreaks.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraBreaks.ForeColor = System.Drawing.SystemColors.Highlight
        Me.fraBreaks.Location = New System.Drawing.Point(12, 128)
        Me.fraBreaks.Name = "fraBreaks"
        Me.fraBreaks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraBreaks.Size = New System.Drawing.Size(661, 142)
        Me.fraBreaks.TabIndex = 49
        Me.fraBreaks.TabStop = False
        Me.fraBreaks.Text = "frabreaks"
        '
        'tabOpcoes
        '
        Me.tabOpcoes.Location = New System.Drawing.Point(9, 14)
        Me.tabOpcoes.Name = "tabOpcoes"
        Me.tabOpcoes.OcxState = CType(resources.GetObject("tabOpcoes.OcxState"), System.Windows.Forms.AxHost.State)
        Me.tabOpcoes.Size = New System.Drawing.Size(202, 56)
        Me.tabOpcoes.TabIndex = 50
        '
        'chkMarcarTodos
        '
        Me.chkMarcarTodos.BackColor = System.Drawing.SystemColors.Control
        Me.chkMarcarTodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMarcarTodos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarcarTodos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMarcarTodos.Location = New System.Drawing.Point(18, 63)
        Me.chkMarcarTodos.Name = "chkMarcarTodos"
        Me.chkMarcarTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMarcarTodos.Size = New System.Drawing.Size(16, 13)
        Me.chkMarcarTodos.TabIndex = 87
        Me.chkMarcarTodos.UseVisualStyleBackColor = False
        '
        'picDesmarcado
        '
        Me.picDesmarcado.BackColor = System.Drawing.SystemColors.Window
        Me.picDesmarcado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDesmarcado.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDesmarcado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picDesmarcado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDesmarcado.Image = CType(resources.GetObject("picDesmarcado.Image"), System.Drawing.Image)
        Me.picDesmarcado.Location = New System.Drawing.Point(603, 12)
        Me.picDesmarcado.Name = "picDesmarcado"
        Me.picDesmarcado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picDesmarcado.Size = New System.Drawing.Size(14, 13)
        Me.picDesmarcado.TabIndex = 86
        Me.picDesmarcado.TabStop = False
        Me.picDesmarcado.Visible = False
        '
        'picMarcado
        '
        Me.picMarcado.BackColor = System.Drawing.SystemColors.Window
        Me.picMarcado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMarcado.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMarcado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picMarcado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picMarcado.Image = CType(resources.GetObject("picMarcado.Image"), System.Drawing.Image)
        Me.picMarcado.Location = New System.Drawing.Point(628, 12)
        Me.picMarcado.Name = "picMarcado"
        Me.picMarcado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picMarcado.Size = New System.Drawing.Size(14, 13)
        Me.picMarcado.TabIndex = 85
        Me.picMarcado.TabStop = False
        Me.picMarcado.Visible = False
        '
        'picRodape
        '
        Me.picRodape.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.picRodape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRodape.Controls.Add(Me.txtRodapeInter)
        Me.picRodape.Controls.Add(Me._cmdfechar_1)
        Me.picRodape.Controls.Add(Me._cmdfechar_0)
        Me.picRodape.Controls.Add(Me.lblRodape)
        Me.picRodape.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRodape.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picRodape.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picRodape.Location = New System.Drawing.Point(117, 78)
        Me.picRodape.Name = "picRodape"
        Me.picRodape.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picRodape.Size = New System.Drawing.Size(397, 118)
        Me.picRodape.TabIndex = 52
        Me.picRodape.TabStop = True
        Me.picRodape.Visible = False
        '
        'txtRodapeInter
        '
        Me.txtRodapeInter.AcceptsReturn = True
        Me.txtRodapeInter.BackColor = System.Drawing.SystemColors.Window
        Me.txtRodapeInter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRodapeInter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRodapeInter.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRodapeInter.Location = New System.Drawing.Point(7, 28)
        Me.txtRodapeInter.MaxLength = 60
        Me.txtRodapeInter.Multiline = True
        Me.txtRodapeInter.Name = "txtRodapeInter"
        Me.txtRodapeInter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRodapeInter.Size = New System.Drawing.Size(379, 51)
        Me.txtRodapeInter.TabIndex = 56
        '
        '_cmdfechar_1
        '
        Me._cmdfechar_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdfechar_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdfechar_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdfechar_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdfechar.SetIndex(Me._cmdfechar_1, CType(1, Short))
        Me._cmdfechar_1.Location = New System.Drawing.Point(322, 86)
        Me._cmdfechar_1.Name = "_cmdfechar_1"
        Me._cmdfechar_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdfechar_1.Size = New System.Drawing.Size(64, 22)
        Me._cmdfechar_1.TabIndex = 54
        Me._cmdfechar_1.Text = "&Fechar"
        Me._cmdfechar_1.UseVisualStyleBackColor = False
        '
        '_cmdfechar_0
        '
        Me._cmdfechar_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdfechar_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdfechar_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdfechar_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdfechar.SetIndex(Me._cmdfechar_0, CType(0, Short))
        Me._cmdfechar_0.Location = New System.Drawing.Point(377, 1)
        Me._cmdfechar_0.Name = "_cmdfechar_0"
        Me._cmdfechar_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdfechar_0.Size = New System.Drawing.Size(16, 14)
        Me._cmdfechar_0.TabIndex = 53
        Me._cmdfechar_0.Text = "X"
        Me._cmdfechar_0.UseVisualStyleBackColor = False
        '
        'lblRodape
        '
        Me.lblRodape.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblRodape.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRodape.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRodape.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblRodape.Location = New System.Drawing.Point(0, -1)
        Me.lblRodape.Name = "lblRodape"
        Me.lblRodape.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRodape.Size = New System.Drawing.Size(395, 21)
        Me.lblRodape.TabIndex = 55
        Me.lblRodape.Text = " Rodapé do Inter Programa"
        '
        'flxComposicao
        '
        Me.flxComposicao.Location = New System.Drawing.Point(5, 57)
        Me.flxComposicao.Name = "flxComposicao"
        Me.flxComposicao.OcxState = CType(resources.GetObject("flxComposicao.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxComposicao.Size = New System.Drawing.Size(650, 215)
        Me.flxComposicao.TabIndex = 51
        '
        'imgTools
        '
        Me.imgTools.Enabled = True
        Me.imgTools.Location = New System.Drawing.Point(399, 15)
        Me.imgTools.Name = "imgTools"
        Me.imgTools.OcxState = CType(resources.GetObject("imgTools.OcxState"), System.Windows.Forms.AxHost.State)
        Me.imgTools.Size = New System.Drawing.Size(38, 38)
        Me.imgTools.TabIndex = 88
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.ucPrograma)
        Me.Frame1.Controls.Add(Me.ucVeiculo)
        Me.Frame1.Controls.Add(Me.UcData)
        Me.Frame1.Controls.Add(Me.cmdUsuario)
        Me.Frame1.Controls.Add(Me.cmdExecutar)
        Me.Frame1.Controls.Add(Me._lblCampos_18)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.Black
        Me.Frame1.Location = New System.Drawing.Point(8, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(673, 97)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(20, 66)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Grade
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(445, 25)
        Me.ucPrograma.sqlQuery = "execute PrNet_Programa_Grade '','0001-01-01','0001-01-01',NULL"
        Me.ucPrograma.TabIndex = 2
        Me.ucPrograma.TextBoxLeft = CType(60, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(22, 14)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(445, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(60, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy "
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(80, 41)
        Me.UcData.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcData.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcData.Name = "UcData"
        Me.UcData.Permite_Futuro = True
        Me.UcData.Permite_Limpar = True
        Me.UcData.Permite_Passado = True
        Me.UcData.Preenchimento_Obrigatorio = False
        Me.UcData.Size = New System.Drawing.Size(135, 25)
        Me.UcData.TabIndex = 1
        '
        '_lblCampos_18
        '
        Me._lblCampos_18.AutoSize = True
        Me._lblCampos_18.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_18.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblCampos.SetIndex(Me._lblCampos_18, CType(18, Short))
        Me._lblCampos_18.Location = New System.Drawing.Point(24, 42)
        Me._lblCampos_18.Name = "_lblCampos_18"
        Me._lblCampos_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_18.Size = New System.Drawing.Size(29, 14)
        Me._lblCampos_18.TabIndex = 1
        Me._lblCampos_18.Text = "Data"
        '
        'chkIndicanet
        '
        Me.chkIndicanet.BackColor = System.Drawing.SystemColors.Control
        Me.chkIndicanet.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkIndicanet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIndicanet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkIndicanet.Location = New System.Drawing.Point(401, 103)
        Me.chkIndicanet.Name = "chkIndicanet"
        Me.chkIndicanet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIndicanet.Size = New System.Drawing.Size(154, 16)
        Me.chkIndicanet.TabIndex = 75
        Me.chkIndicanet.Text = "Indica Net"
        Me.chkIndicanet.UseVisualStyleBackColor = False
        Me.chkIndicanet.Visible = False
        '
        'cmdCriticaFechar
        '
        '
        'picBreaks
        '
        Me.picBreaks.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picBreaks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBreaks.Controls.Add(Me.Label11)
        Me.picBreaks.Controls.Add(Me.lblDispoTotal)
        Me.picBreaks.Controls.Add(Me.Label9)
        Me.picBreaks.Controls.Add(Me.lblComposiçãoTotal)
        Me.picBreaks.Controls.Add(Me.Label7)
        Me.picBreaks.Controls.Add(Me.Label6)
        Me.picBreaks.Controls.Add(Me.Label5)
        Me.picBreaks.Controls.Add(Me.lblComposicaoLocal)
        Me.picBreaks.Controls.Add(Me.lblComposicaoNet)
        Me.picBreaks.Controls.Add(Me.lblDispoLocal)
        Me.picBreaks.Controls.Add(Me.lblDispoNet)
        Me.picBreaks.Controls.Add(Me.Label4)
        Me.picBreaks.Controls.Add(Me.Label3)
        Me.picBreaks.Controls.Add(Me.Label1)
        Me.picBreaks.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBreaks.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picBreaks.ForeColor = System.Drawing.Color.White
        Me.picBreaks.Location = New System.Drawing.Point(6, 454)
        Me.picBreaks.Name = "picBreaks"
        Me.picBreaks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picBreaks.Size = New System.Drawing.Size(402, 54)
        Me.picBreaks.TabIndex = 91
        Me.picBreaks.TabStop = True
        Me.picBreaks.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(132, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Total "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDispoTotal
        '
        Me.lblDispoTotal.BackColor = System.Drawing.SystemColors.Window
        Me.lblDispoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDispoTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDispoTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispoTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDispoTotal.Location = New System.Drawing.Point(132, 32)
        Me.lblDispoTotal.Name = "lblDispoTotal"
        Me.lblDispoTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDispoTotal.Size = New System.Drawing.Size(67, 17)
        Me.lblDispoTotal.TabIndex = 70
        Me.lblDispoTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(332, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Total "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblComposiçãoTotal
        '
        Me.lblComposiçãoTotal.BackColor = System.Drawing.SystemColors.Window
        Me.lblComposiçãoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComposiçãoTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComposiçãoTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComposiçãoTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblComposiçãoTotal.Location = New System.Drawing.Point(332, 32)
        Me.lblComposiçãoTotal.Name = "lblComposiçãoTotal"
        Me.lblComposiçãoTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComposiçãoTotal.Size = New System.Drawing.Size(67, 17)
        Me.lblComposiçãoTotal.TabIndex = 68
        Me.lblComposiçãoTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(266, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Local "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(200, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(199, 17)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Composição"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(200, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Net "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblComposicaoLocal
        '
        Me.lblComposicaoLocal.BackColor = System.Drawing.SystemColors.Window
        Me.lblComposicaoLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComposicaoLocal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComposicaoLocal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComposicaoLocal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblComposicaoLocal.Location = New System.Drawing.Point(266, 32)
        Me.lblComposicaoLocal.Name = "lblComposicaoLocal"
        Me.lblComposicaoLocal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComposicaoLocal.Size = New System.Drawing.Size(67, 17)
        Me.lblComposicaoLocal.TabIndex = 64
        Me.lblComposicaoLocal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblComposicaoNet
        '
        Me.lblComposicaoNet.BackColor = System.Drawing.SystemColors.Window
        Me.lblComposicaoNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComposicaoNet.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComposicaoNet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComposicaoNet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblComposicaoNet.Location = New System.Drawing.Point(200, 32)
        Me.lblComposicaoNet.Name = "lblComposicaoNet"
        Me.lblComposicaoNet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComposicaoNet.Size = New System.Drawing.Size(67, 17)
        Me.lblComposicaoNet.TabIndex = 63
        Me.lblComposicaoNet.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDispoLocal
        '
        Me.lblDispoLocal.BackColor = System.Drawing.SystemColors.Window
        Me.lblDispoLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDispoLocal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDispoLocal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispoLocal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDispoLocal.Location = New System.Drawing.Point(66, 32)
        Me.lblDispoLocal.Name = "lblDispoLocal"
        Me.lblDispoLocal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDispoLocal.Size = New System.Drawing.Size(67, 17)
        Me.lblDispoLocal.TabIndex = 62
        Me.lblDispoLocal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDispoNet
        '
        Me.lblDispoNet.BackColor = System.Drawing.SystemColors.Window
        Me.lblDispoNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDispoNet.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDispoNet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispoNet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDispoNet.Location = New System.Drawing.Point(0, 32)
        Me.lblDispoNet.Name = "lblDispoNet"
        Me.lblDispoNet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDispoNet.Size = New System.Drawing.Size(67, 17)
        Me.lblDispoNet.TabIndex = 61
        Me.lblDispoNet.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(66, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Local "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(200, 17)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Disponibilidade"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(0, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Net "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tabComposicao
        '
        Me.tabComposicao.Location = New System.Drawing.Point(8, 108)
        Me.tabComposicao.Name = "tabComposicao"
        Me.tabComposicao.OcxState = CType(resources.GetObject("tabComposicao.OcxState"), System.Windows.Forms.AxHost.State)
        Me.tabComposicao.Size = New System.Drawing.Size(673, 329)
        Me.tabComposicao.TabIndex = 78
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.CancelaText = "Sair"
        Me.btnOkCancel.Location = New System.Drawing.Point(499, 454)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.OkText = "Gravar"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 90
        '
        'frmComposicaoBreaks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(690, 531)
        Me.Controls.Add(Me.picBreaks)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.chkIndicanet)
        Me.Controls.Add(Me.picCritica)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.tabComposicao)
        Me.Controls.Add(Me.fraProgramacao)
        Me.Controls.Add(Me.fraBreaks)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(246, 99)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComposicaoBreaks"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Composição dos Breaks"
        Me.picCritica.ResumeLayout(False)
        Me.picCritica.PerformLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxCritica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraProgramacao.ResumeLayout(False)
        Me.fraProgramacao.PerformLayout()
        Me.fraExibicao.ResumeLayout(False)
        Me.fraPropagar.ResumeLayout(False)
        Me.fraPropagar.PerformLayout()
        Me.fraBreaks.ResumeLayout(False)
        CType(Me.tabOpcoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesmarcado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMarcado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picRodape.ResumeLayout(False)
        Me.picRodape.PerformLayout()
        CType(Me.flxComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.chkDiasSemana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCriticaFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdfechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBreaks.ResumeLayout(False)
        CType(Me.tabComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents UcDatade As WCL_SCTV.UC.UCData
    Friend WithEvents UcDataAte As WCL_SCTV.UC.UCData
    Friend WithEvents btnOkCancel As WUC.ucButton
    Public WithEvents picBreaks As System.Windows.Forms.Panel
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents lblDispoTotal As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents lblComposiçãoTotal As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents lblComposicaoLocal As System.Windows.Forms.Label
    Public WithEvents lblComposicaoNet As System.Windows.Forms.Label
    Public WithEvents lblDispoLocal As System.Windows.Forms.Label
    Public WithEvents lblDispoNet As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents ucVeiculo As WUC.UcText
#End Region
End Class