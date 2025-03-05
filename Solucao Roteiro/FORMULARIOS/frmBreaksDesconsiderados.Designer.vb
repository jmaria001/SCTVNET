<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmBreaksDesconsiderados
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
	Public WithEvents _cmdCriticaFechar_0 As System.Windows.Forms.Button
	Public WithEvents _cmdCriticaFechar_1 As System.Windows.Forms.Button
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents flxCritica As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents lblCritica As System.Windows.Forms.Label
	Public WithEvents _Label2_1 As System.Windows.Forms.Label
	Public WithEvents picCritica As System.Windows.Forms.Panel
	Public WithEvents lstVeiculo As System.Windows.Forms.CheckedListBox
	Public WithEvents _cmdSelecaoVeiculo_1 As System.Windows.Forms.Button
	Public WithEvents _cmdSelecaoVeiculo_0 As System.Windows.Forms.Button
	Public WithEvents lblSelecaoVeiculo As System.Windows.Forms.Label
	Public WithEvents picVeiculo As System.Windows.Forms.Panel
	Public WithEvents cmdReplicar As System.Windows.Forms.Button
	Public WithEvents picMarcado As System.Windows.Forms.PictureBox
	Public WithEvents picDesmarcado As System.Windows.Forms.PictureBox
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents _Frame2_0 As System.Windows.Forms.GroupBox
	Public WithEvents _chkDiaSemana_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiaSemana_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiaSemana_5 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiaSemana_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiaSemana_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiaSemana_6 As System.Windows.Forms.CheckBox
	Public WithEvents _chkDiaSemana_7 As System.Windows.Forms.CheckBox
	Public WithEvents _Frame2_1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancela As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents flxBreak As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents cmdExibir As System.Windows.Forms.Button
    Public WithEvents chkIndicanet As System.Windows.Forms.CheckBox
    Public WithEvents _lblCampos_18 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _Label2_0 As System.Windows.Forms.Label
	Public WithEvents Frame2 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents chkDiaSemana As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmdCriticaFechar As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents cmdSelecaoVeiculo As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBreaksDesconsiderados))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picCritica = New System.Windows.Forms.Panel
        Me._cmdCriticaFechar_0 = New System.Windows.Forms.Button
        Me._cmdCriticaFechar_1 = New System.Windows.Forms.Button
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.flxCritica = New AxMSFlexGridLib.AxMSFlexGrid
        Me.lblCritica = New System.Windows.Forms.Label
        Me._Label2_1 = New System.Windows.Forms.Label
        Me.picVeiculo = New System.Windows.Forms.Panel
        Me.lstVeiculo = New System.Windows.Forms.CheckedListBox
        Me._cmdSelecaoVeiculo_1 = New System.Windows.Forms.Button
        Me._cmdSelecaoVeiculo_0 = New System.Windows.Forms.Button
        Me.lblSelecaoVeiculo = New System.Windows.Forms.Label
        Me.cmdReplicar = New System.Windows.Forms.Button
        Me.picMarcado = New System.Windows.Forms.PictureBox
        Me.picDesmarcado = New System.Windows.Forms.PictureBox
        Me._Frame2_0 = New System.Windows.Forms.GroupBox
        Me.dtpFim = New WCL_SCTV.UC.UCData
        Me.dtpInicio = New WCL_SCTV.UC.UCData
        Me._Label1_0 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Frame2_1 = New System.Windows.Forms.GroupBox
        Me._chkDiaSemana_1 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_2 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_5 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_3 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_4 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_6 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_7 = New System.Windows.Forms.CheckBox
        Me.cmdCancela = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.flxBreak = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.ucPrograma1 = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.UcData = New WCL_SCTV.UC.UCData
        Me.cmdExibir = New System.Windows.Forms.Button
        Me.chkIndicanet = New System.Windows.Forms.CheckBox
        Me._lblCampos_18 = New System.Windows.Forms.Label
        Me._Label2_0 = New System.Windows.Forms.Label
        Me.Frame2 = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.chkDiaSemana = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.cmdCriticaFechar = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdSelecaoVeiculo = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.picCritica.SuspendLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxCritica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picVeiculo.SuspendLayout()
        CType(Me.picMarcado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesmarcado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._Frame2_0.SuspendLayout()
        Me._Frame2_1.SuspendLayout()
        CType(Me.flxBreak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDiaSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCriticaFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelecaoVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCritica
        '
        Me.picCritica.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.picCritica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCritica.Controls.Add(Me._cmdCriticaFechar_0)
        Me.picCritica.Controls.Add(Me._cmdCriticaFechar_1)
        Me.picCritica.Controls.Add(Me.Picture1)
        Me.picCritica.Controls.Add(Me.flxCritica)
        Me.picCritica.Controls.Add(Me.lblCritica)
        Me.picCritica.Controls.Add(Me._Label2_1)
        Me.picCritica.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCritica.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picCritica.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picCritica.Location = New System.Drawing.Point(3, 510)
        Me.picCritica.Name = "picCritica"
        Me.picCritica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picCritica.Size = New System.Drawing.Size(457, 55)
        Me.picCritica.TabIndex = 41
        Me.picCritica.TabStop = True
        Me.picCritica.Visible = False
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
        Me._cmdCriticaFechar_0.TabIndex = 45
        Me._cmdCriticaFechar_0.Text = "&Fechar"
        Me._cmdCriticaFechar_0.UseVisualStyleBackColor = False
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
        Me._cmdCriticaFechar_1.TabIndex = 44
        Me._cmdCriticaFechar_1.Text = "X"
        Me._cmdCriticaFechar_1.UseVisualStyleBackColor = False
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
        Me.Picture1.TabIndex = 42
        Me.Picture1.TabStop = False
        '
        'flxCritica
        '
        Me.flxCritica.Location = New System.Drawing.Point(9, 30)
        Me.flxCritica.Name = "flxCritica"
        Me.flxCritica.OcxState = CType(resources.GetObject("flxCritica.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxCritica.Size = New System.Drawing.Size(442, 193)
        Me.flxCritica.TabIndex = 43
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
        Me.lblCritica.TabIndex = 47
        Me.lblCritica.Text = "  Critica da gravação da Composição de Breaks"
        '
        '_Label2_1
        '
        Me._Label2_1.AutoSize = True
        Me._Label2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.SetIndex(Me._Label2_1, CType(1, Short))
        Me._Label2_1.Location = New System.Drawing.Point(39, 231)
        Me._Label2_1.Name = "_Label2_1"
        Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_1.Size = New System.Drawing.Size(243, 14)
        Me._Label2_1.TabIndex = 46
        Me._Label2_1.Text = "As datas relacionadas não foram gravadas "
        '
        'picVeiculo
        '
        Me.picVeiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVeiculo.Controls.Add(Me.lstVeiculo)
        Me.picVeiculo.Controls.Add(Me._cmdSelecaoVeiculo_1)
        Me.picVeiculo.Controls.Add(Me._cmdSelecaoVeiculo_0)
        Me.picVeiculo.Controls.Add(Me.lblSelecaoVeiculo)
        Me.picVeiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.picVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picVeiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picVeiculo.Location = New System.Drawing.Point(9, 565)
        Me.picVeiculo.Name = "picVeiculo"
        Me.picVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picVeiculo.Size = New System.Drawing.Size(472, 66)
        Me.picVeiculo.TabIndex = 34
        Me.picVeiculo.TabStop = True
        '
        'lstVeiculo
        '
        Me.lstVeiculo.BackColor = System.Drawing.Color.White
        Me.lstVeiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVeiculo.ForeColor = System.Drawing.Color.Black
        Me.lstVeiculo.Location = New System.Drawing.Point(6, 24)
        Me.lstVeiculo.Name = "lstVeiculo"
        Me.lstVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstVeiculo.Size = New System.Drawing.Size(451, 139)
        Me.lstVeiculo.TabIndex = 37
        '
        '_cmdSelecaoVeiculo_1
        '
        Me._cmdSelecaoVeiculo_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdSelecaoVeiculo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdSelecaoVeiculo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdSelecaoVeiculo_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelecaoVeiculo.SetIndex(Me._cmdSelecaoVeiculo_1, CType(1, Short))
        Me._cmdSelecaoVeiculo_1.Location = New System.Drawing.Point(444, 0)
        Me._cmdSelecaoVeiculo_1.Name = "_cmdSelecaoVeiculo_1"
        Me._cmdSelecaoVeiculo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdSelecaoVeiculo_1.Size = New System.Drawing.Size(19, 16)
        Me._cmdSelecaoVeiculo_1.TabIndex = 36
        Me._cmdSelecaoVeiculo_1.TabStop = False
        Me._cmdSelecaoVeiculo_1.Text = "X"
        Me._cmdSelecaoVeiculo_1.UseVisualStyleBackColor = False
        '
        '_cmdSelecaoVeiculo_0
        '
        Me._cmdSelecaoVeiculo_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdSelecaoVeiculo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdSelecaoVeiculo_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdSelecaoVeiculo_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelecaoVeiculo.SetIndex(Me._cmdSelecaoVeiculo_0, CType(0, Short))
        Me._cmdSelecaoVeiculo_0.Location = New System.Drawing.Point(387, 171)
        Me._cmdSelecaoVeiculo_0.Name = "_cmdSelecaoVeiculo_0"
        Me._cmdSelecaoVeiculo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdSelecaoVeiculo_0.Size = New System.Drawing.Size(70, 28)
        Me._cmdSelecaoVeiculo_0.TabIndex = 35
        Me._cmdSelecaoVeiculo_0.Text = "&Ok"
        Me._cmdSelecaoVeiculo_0.UseVisualStyleBackColor = False
        '
        'lblSelecaoVeiculo
        '
        Me.lblSelecaoVeiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSelecaoVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelecaoVeiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSelecaoVeiculo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelecaoVeiculo.ForeColor = System.Drawing.Color.White
        Me.lblSelecaoVeiculo.Location = New System.Drawing.Point(0, 0)
        Me.lblSelecaoVeiculo.Name = "lblSelecaoVeiculo"
        Me.lblSelecaoVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSelecaoVeiculo.Size = New System.Drawing.Size(464, 19)
        Me.lblSelecaoVeiculo.TabIndex = 39
        Me.lblSelecaoVeiculo.Text = "Selecione os Veiculos para  replicar a desconsideração de Breaks "
        '
        'cmdReplicar
        '
        Me.cmdReplicar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReplicar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReplicar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReplicar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReplicar.Location = New System.Drawing.Point(450, 394)
        Me.cmdReplicar.Name = "cmdReplicar"
        Me.cmdReplicar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReplicar.Size = New System.Drawing.Size(79, 31)
        Me.cmdReplicar.TabIndex = 7
        Me.cmdReplicar.TabStop = False
        Me.cmdReplicar.Text = "&Replicar"
        Me.cmdReplicar.UseVisualStyleBackColor = False
        '
        'picMarcado
        '
        Me.picMarcado.BackColor = System.Drawing.SystemColors.Window
        Me.picMarcado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMarcado.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMarcado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picMarcado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picMarcado.Image = CType(resources.GetObject("picMarcado.Image"), System.Drawing.Image)
        Me.picMarcado.Location = New System.Drawing.Point(81, 209)
        Me.picMarcado.Name = "picMarcado"
        Me.picMarcado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picMarcado.Size = New System.Drawing.Size(14, 13)
        Me.picMarcado.TabIndex = 33
        Me.picMarcado.TabStop = False
        Me.picMarcado.Visible = False
        '
        'picDesmarcado
        '
        Me.picDesmarcado.BackColor = System.Drawing.SystemColors.Window
        Me.picDesmarcado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDesmarcado.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDesmarcado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picDesmarcado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDesmarcado.Image = CType(resources.GetObject("picDesmarcado.Image"), System.Drawing.Image)
        Me.picDesmarcado.Location = New System.Drawing.Point(102, 209)
        Me.picDesmarcado.Name = "picDesmarcado"
        Me.picDesmarcado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picDesmarcado.Size = New System.Drawing.Size(14, 13)
        Me.picDesmarcado.TabIndex = 32
        Me.picDesmarcado.TabStop = False
        Me.picDesmarcado.Visible = False
        '
        '_Frame2_0
        '
        Me._Frame2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Frame2_0.Controls.Add(Me.dtpFim)
        Me._Frame2_0.Controls.Add(Me.dtpInicio)
        Me._Frame2_0.Controls.Add(Me._Label1_0)
        Me._Frame2_0.Controls.Add(Me._Label1_2)
        Me._Frame2_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.SetIndex(Me._Frame2_0, CType(0, Short))
        Me._Frame2_0.Location = New System.Drawing.Point(3, 394)
        Me._Frame2_0.Name = "_Frame2_0"
        Me._Frame2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_0.Size = New System.Drawing.Size(424, 49)
        Me._Frame2_0.TabIndex = 3
        Me._Frame2_0.TabStop = False
        Me._Frame2_0.Text = "Periodo a ser Desconsiderado"
        '
        'dtpFim
        '
        Me.dtpFim.BackColor = System.Drawing.Color.Transparent
        Me.dtpFim.DateTime = New Date(CType(0, Long))
        Me.dtpFim.Formato = "dd/MM/yyyy "
        Me.dtpFim.Hoje = False
        Me.dtpFim.Location = New System.Drawing.Point(262, 18)
        Me.dtpFim.MaximumSize = New System.Drawing.Size(500, 25)
        Me.dtpFim.MinimumSize = New System.Drawing.Size(115, 25)
        Me.dtpFim.Name = "dtpFim"
        Me.dtpFim.Permite_Futuro = True
        Me.dtpFim.Permite_Limpar = True
        Me.dtpFim.Permite_Passado = True
        Me.dtpFim.Preenchimento_Obrigatorio = False
        Me.dtpFim.Size = New System.Drawing.Size(143, 25)
        Me.dtpFim.TabIndex = 3
        '
        'dtpInicio
        '
        Me.dtpInicio.BackColor = System.Drawing.Color.Transparent
        Me.dtpInicio.DateTime = New Date(CType(0, Long))
        Me.dtpInicio.Formato = "dd/MM/yyyy "
        Me.dtpInicio.Hoje = False
        Me.dtpInicio.Location = New System.Drawing.Point(56, 18)
        Me.dtpInicio.MaximumSize = New System.Drawing.Size(500, 25)
        Me.dtpInicio.MinimumSize = New System.Drawing.Size(115, 25)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Permite_Futuro = True
        Me.dtpInicio.Permite_Limpar = True
        Me.dtpInicio.Permite_Passado = True
        Me.dtpInicio.Preenchimento_Obrigatorio = False
        Me.dtpInicio.Size = New System.Drawing.Size(143, 25)
        Me.dtpInicio.TabIndex = 1
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(19, 21)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(31, 14)
        Me._Label1_0.TabIndex = 0
        Me._Label1_0.Text = "Inicio"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(233, 21)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(23, 14)
        Me._Label1_2.TabIndex = 2
        Me._Label1_2.Text = "Fim"
        '
        '_Frame2_1
        '
        Me._Frame2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_1)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_2)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_5)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_3)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_4)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_6)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_7)
        Me._Frame2_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.SetIndex(Me._Frame2_1, CType(1, Short))
        Me._Frame2_1.Location = New System.Drawing.Point(3, 454)
        Me._Frame2_1.Name = "_Frame2_1"
        Me._Frame2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_1.Size = New System.Drawing.Size(424, 49)
        Me._Frame2_1.TabIndex = 4
        Me._Frame2_1.TabStop = False
        Me._Frame2_1.Text = "Nos dias da Semana"
        '
        '_chkDiaSemana_1
        '
        Me._chkDiaSemana_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDiaSemana.SetIndex(Me._chkDiaSemana_1, CType(1, Short))
        Me._chkDiaSemana_1.Location = New System.Drawing.Point(12, 18)
        Me._chkDiaSemana_1.Name = "_chkDiaSemana_1"
        Me._chkDiaSemana_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_1.Size = New System.Drawing.Size(49, 19)
        Me._chkDiaSemana_1.TabIndex = 0
        Me._chkDiaSemana_1.Text = "Dom"
        Me._chkDiaSemana_1.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_2
        '
        Me._chkDiaSemana_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDiaSemana.SetIndex(Me._chkDiaSemana_2, CType(2, Short))
        Me._chkDiaSemana_2.Location = New System.Drawing.Point(72, 16)
        Me._chkDiaSemana_2.Name = "_chkDiaSemana_2"
        Me._chkDiaSemana_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_2.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_2.TabIndex = 1
        Me._chkDiaSemana_2.Text = "Seg"
        Me._chkDiaSemana_2.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_5
        '
        Me._chkDiaSemana_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDiaSemana.SetIndex(Me._chkDiaSemana_5, CType(5, Short))
        Me._chkDiaSemana_5.Location = New System.Drawing.Point(252, 19)
        Me._chkDiaSemana_5.Name = "_chkDiaSemana_5"
        Me._chkDiaSemana_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_5.Size = New System.Drawing.Size(49, 19)
        Me._chkDiaSemana_5.TabIndex = 4
        Me._chkDiaSemana_5.Text = "Qui"
        Me._chkDiaSemana_5.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_3
        '
        Me._chkDiaSemana_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDiaSemana.SetIndex(Me._chkDiaSemana_3, CType(3, Short))
        Me._chkDiaSemana_3.Location = New System.Drawing.Point(132, 16)
        Me._chkDiaSemana_3.Name = "_chkDiaSemana_3"
        Me._chkDiaSemana_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_3.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_3.TabIndex = 2
        Me._chkDiaSemana_3.Text = "Ter"
        Me._chkDiaSemana_3.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_4
        '
        Me._chkDiaSemana_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDiaSemana.SetIndex(Me._chkDiaSemana_4, CType(4, Short))
        Me._chkDiaSemana_4.Location = New System.Drawing.Point(192, 19)
        Me._chkDiaSemana_4.Name = "_chkDiaSemana_4"
        Me._chkDiaSemana_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_4.Size = New System.Drawing.Size(49, 19)
        Me._chkDiaSemana_4.TabIndex = 3
        Me._chkDiaSemana_4.Text = "Qua"
        Me._chkDiaSemana_4.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_6
        '
        Me._chkDiaSemana_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDiaSemana.SetIndex(Me._chkDiaSemana_6, CType(6, Short))
        Me._chkDiaSemana_6.Location = New System.Drawing.Point(312, 18)
        Me._chkDiaSemana_6.Name = "_chkDiaSemana_6"
        Me._chkDiaSemana_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_6.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_6.TabIndex = 5
        Me._chkDiaSemana_6.Text = "Sex"
        Me._chkDiaSemana_6.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_7
        '
        Me._chkDiaSemana_7.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDiaSemana.SetIndex(Me._chkDiaSemana_7, CType(7, Short))
        Me._chkDiaSemana_7.Location = New System.Drawing.Point(372, 18)
        Me._chkDiaSemana_7.Name = "_chkDiaSemana_7"
        Me._chkDiaSemana_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_7.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_7.TabIndex = 6
        Me._chkDiaSemana_7.Text = "Sab"
        Me._chkDiaSemana_7.UseVisualStyleBackColor = False
        '
        'cmdCancela
        '
        Me.cmdCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancela.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.Location = New System.Drawing.Point(450, 472)
        Me.cmdCancela.Name = "cmdCancela"
        Me.cmdCancela.Size = New System.Drawing.Size(79, 34)
        Me.cmdCancela.TabIndex = 6
        Me.cmdCancela.TabStop = False
        Me.cmdCancela.Text = "&Cancela"
        Me.cmdCancela.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Enabled = False
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(450, 432)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(79, 34)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'flxBreak
        '
        Me.flxBreak.Location = New System.Drawing.Point(6, 203)
        Me.flxBreak.Name = "flxBreak"
        Me.flxBreak.OcxState = CType(resources.GetObject("flxBreak.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxBreak.Size = New System.Drawing.Size(523, 168)
        Me.flxBreak.TabIndex = 1
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.ucPrograma1)
        Me.Frame1.Controls.Add(Me.ucVeiculo)
        Me.Frame1.Controls.Add(Me.UcData)
        Me.Frame1.Controls.Add(Me.cmdExibir)
        Me.Frame1.Controls.Add(Me.chkIndicanet)
        Me.Frame1.Controls.Add(Me._lblCampos_18)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.Black
        Me.Frame1.Location = New System.Drawing.Point(6, 3)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(523, 173)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'ucPrograma1
        '
        Me.ucPrograma1.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma1.Caption = "Programa"
        Me.ucPrograma1.DataTextValue = Nothing
        Me.ucPrograma1.Location = New System.Drawing.Point(25, 95)
        Me.ucPrograma1.MaxLength = 4
        Me.ucPrograma1.Name = "ucPrograma1"
        Me.ucPrograma1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma1.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma1.pDecimal = CType(0, Byte)
        Me.ucPrograma1.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Grade
        Me.ucPrograma1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma1.showButton = True
        Me.ucPrograma1.ShowDescricao = True
        Me.ucPrograma1.Size = New System.Drawing.Size(417, 25)
        Me.ucPrograma1.sqlQuery = "execute PrNet_Programa_Grade '','0001-01-01','0001-01-01',NULL"
        Me.ucPrograma1.TabIndex = 2
        Me.ucPrograma1.TextBoxLeft = CType(60, Short)
        Me.ucPrograma1.TextWidth = 55
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(25, 19)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(417, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(60, Short)
        Me.ucVeiculo.TextWidth = 55
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy "
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(85, 57)
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
        'cmdExibir
        '
        Me.cmdExibir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExibir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExibir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExibir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExibir.Location = New System.Drawing.Point(448, 139)
        Me.cmdExibir.Name = "cmdExibir"
        Me.cmdExibir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExibir.Size = New System.Drawing.Size(61, 28)
        Me.cmdExibir.TabIndex = 3
        Me.cmdExibir.Text = "&Exibir"
        Me.cmdExibir.UseVisualStyleBackColor = False
        '
        'chkIndicanet
        '
        Me.chkIndicanet.BackColor = System.Drawing.SystemColors.Control
        Me.chkIndicanet.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkIndicanet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIndicanet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkIndicanet.Location = New System.Drawing.Point(398, 61)
        Me.chkIndicanet.Name = "chkIndicanet"
        Me.chkIndicanet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIndicanet.Size = New System.Drawing.Size(70, 16)
        Me.chkIndicanet.TabIndex = 0
        Me.chkIndicanet.Text = "Indica Net"
        Me.chkIndicanet.UseVisualStyleBackColor = False
        Me.chkIndicanet.Visible = False
        '
        '_lblCampos_18
        '
        Me._lblCampos_18.AutoSize = True
        Me._lblCampos_18.BackColor = System.Drawing.Color.Transparent
        Me._lblCampos_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_18.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblCampos.SetIndex(Me._lblCampos_18, CType(18, Short))
        Me._lblCampos_18.Location = New System.Drawing.Point(29, 61)
        Me._lblCampos_18.Name = "_lblCampos_18"
        Me._lblCampos_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_18.Size = New System.Drawing.Size(29, 14)
        Me._lblCampos_18.TabIndex = 23
        Me._lblCampos_18.Text = "Data"
        '
        '_Label2_0
        '
        Me._Label2_0.AutoSize = True
        Me._Label2_0.BackColor = System.Drawing.Color.Transparent
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.SetIndex(Me._Label2_0, CType(0, Short))
        Me._Label2_0.Location = New System.Drawing.Point(9, 374)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(269, 14)
        Me._Label2_0.TabIndex = 2
        Me._Label2_0.Text = "Selecione os Breaks a serem desconsiderados"
        '
        'cmdCriticaFechar
        '
        '
        'cmdSelecaoVeiculo
        '
        '
        'frmBreaksDesconsiderados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(558, 520)
        Me.Controls.Add(Me.picCritica)
        Me.Controls.Add(Me.picVeiculo)
        Me.Controls.Add(Me.cmdReplicar)
        Me.Controls.Add(Me.picMarcado)
        Me.Controls.Add(Me.picDesmarcado)
        Me.Controls.Add(Me._Frame2_0)
        Me.Controls.Add(Me._Frame2_1)
        Me.Controls.Add(Me.cmdCancela)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.flxBreak)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Label2_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(182, 37)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBreaksDesconsiderados"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Breaks Desconsiderados"
        Me.picCritica.ResumeLayout(False)
        Me.picCritica.PerformLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxCritica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picVeiculo.ResumeLayout(False)
        CType(Me.picMarcado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesmarcado, System.ComponentModel.ISupportInitialize).EndInit()
        Me._Frame2_0.ResumeLayout(False)
        Me._Frame2_0.PerformLayout()
        Me._Frame2_1.ResumeLayout(False)
        CType(Me.flxBreak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDiaSemana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCriticaFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelecaoVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents dtpFim As WCL_SCTV.UC.UCData
    Friend WithEvents dtpInicio As WCL_SCTV.UC.UCData
    Friend WithEvents ucPrograma1 As WUC.UcText
    Friend WithEvents ucVeiculo As WUC.UcText
#End Region
End Class