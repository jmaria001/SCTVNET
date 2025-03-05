<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDadosAm
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()

        InitializeComponent()
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
	Public WithEvents txtVeiculo As System.Windows.Forms.TextBox
	Public WithEvents txtEmpresa As System.Windows.Forms.TextBox
	Public WithEvents txtContrato As System.Windows.Forms.TextBox
	Public WithEvents txtSequencia As System.Windows.Forms.TextBox
	Public WithEvents txtNumeroAM As System.Windows.Forms.TextBox
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtTotalCompensado As System.Windows.Forms.TextBox
	Public WithEvents txtQtdFalhas As System.Windows.Forms.TextBox
	Public WithEvents txtQtdCompensado As System.Windows.Forms.TextBox
	Public WithEvents txtDiferenca As System.Windows.Forms.TextBox
	Public WithEvents txtTotalFalhas As System.Windows.Forms.TextBox
	Public WithEvents _lblTexto_13 As System.Windows.Forms.Label
	Public WithEvents _lblTexto_11 As System.Windows.Forms.Label
	Public WithEvents _lblTexto_12 As System.Windows.Forms.Label
	Public WithEvents _Frame2_0 As System.Windows.Forms.GroupBox
	Public WithEvents txtDataEncerramento As System.Windows.Forms.TextBox
	Public WithEvents txtUsuario As System.Windows.Forms.TextBox
	Public WithEvents _lblTexto_15 As System.Windows.Forms.Label
	Public WithEvents _lblTexto_14 As System.Windows.Forms.Label
	Public WithEvents _Frame2_2 As System.Windows.Forms.GroupBox
    Public WithEvents lblSolucao As System.Windows.Forms.Label
    Public WithEvents _Frame2_1 As System.Windows.Forms.GroupBox
    Public WithEvents txtSolucao As System.Windows.Forms.TextBox
    Public WithEvents cmdRetornar As System.Windows.Forms.Button
    Public WithEvents flxDados As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents lblCarta As System.Windows.Forms.Label
    Public WithEvents lblFatura As System.Windows.Forms.Label
    Public WithEvents Frame2 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents lblTexto As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDadosAm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtVeiculo = New System.Windows.Forms.TextBox
        Me.txtEmpresa = New System.Windows.Forms.TextBox
        Me.txtContrato = New System.Windows.Forms.TextBox
        Me.txtSequencia = New System.Windows.Forms.TextBox
        Me.txtNumeroAM = New System.Windows.Forms.TextBox
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me._Frame2_0 = New System.Windows.Forms.GroupBox
        Me.txtTotalCompensado = New System.Windows.Forms.TextBox
        Me.txtQtdFalhas = New System.Windows.Forms.TextBox
        Me.txtQtdCompensado = New System.Windows.Forms.TextBox
        Me.txtDiferenca = New System.Windows.Forms.TextBox
        Me.txtTotalFalhas = New System.Windows.Forms.TextBox
        Me._lblTexto_13 = New System.Windows.Forms.Label
        Me._lblTexto_11 = New System.Windows.Forms.Label
        Me._lblTexto_12 = New System.Windows.Forms.Label
        Me._Frame2_2 = New System.Windows.Forms.GroupBox
        Me.txtDataEncerramento = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me._lblTexto_15 = New System.Windows.Forms.Label
        Me._lblTexto_14 = New System.Windows.Forms.Label
        Me._Frame2_1 = New System.Windows.Forms.GroupBox
        Me.lblSolucao = New System.Windows.Forms.Label
        Me.txtSolucao = New System.Windows.Forms.TextBox
        Me.cmdRetornar = New System.Windows.Forms.Button
        Me.flxDados = New AxMSFlexGridLib.AxMSFlexGrid
        Me.lblCarta = New System.Windows.Forms.Label
        Me.lblFatura = New System.Windows.Forms.Label
        Me.Frame2 = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblTexto = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Frame1.SuspendLayout()
        Me._Frame2_0.SuspendLayout()
        Me._Frame2_2.SuspendLayout()
        Me._Frame2_1.SuspendLayout()
        CType(Me.flxDados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtVeiculo)
        Me.Frame1.Controls.Add(Me.txtEmpresa)
        Me.Frame1.Controls.Add(Me.txtContrato)
        Me.Frame1.Controls.Add(Me.txtSequencia)
        Me.Frame1.Controls.Add(Me.txtNumeroAM)
        Me.Frame1.Controls.Add(Me._Label1_4)
        Me.Frame1.Controls.Add(Me._Label1_3)
        Me.Frame1.Controls.Add(Me._Label1_2)
        Me.Frame1.Controls.Add(Me._Label1_1)
        Me.Frame1.Controls.Add(Me._Label1_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 436)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(661, 37)
        Me.Frame1.TabIndex = 25
        Me.Frame1.TabStop = False
        '
        'txtVeiculo
        '
        Me.txtVeiculo.AcceptsReturn = True
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Window
        Me.txtVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVeiculo.Location = New System.Drawing.Point(585, 13)
        Me.txtVeiculo.MaxLength = 0
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.ReadOnly = True
        Me.txtVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVeiculo.Size = New System.Drawing.Size(70, 20)
        Me.txtVeiculo.TabIndex = 34
        Me.txtVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmpresa
        '
        Me.txtEmpresa.AcceptsReturn = True
        Me.txtEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpresa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmpresa.Location = New System.Drawing.Point(60, 13)
        Me.txtEmpresa.MaxLength = 0
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.ReadOnly = True
        Me.txtEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmpresa.Size = New System.Drawing.Size(40, 20)
        Me.txtEmpresa.TabIndex = 29
        Me.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtContrato
        '
        Me.txtContrato.AcceptsReturn = True
        Me.txtContrato.BackColor = System.Drawing.SystemColors.Window
        Me.txtContrato.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContrato.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrato.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContrato.Location = New System.Drawing.Point(186, 13)
        Me.txtContrato.MaxLength = 0
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.ReadOnly = True
        Me.txtContrato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContrato.Size = New System.Drawing.Size(70, 20)
        Me.txtContrato.TabIndex = 28
        Me.txtContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSequencia
        '
        Me.txtSequencia.AcceptsReturn = True
        Me.txtSequencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtSequencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSequencia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSequencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSequencia.Location = New System.Drawing.Point(325, 13)
        Me.txtSequencia.MaxLength = 0
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.ReadOnly = True
        Me.txtSequencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSequencia.Size = New System.Drawing.Size(31, 20)
        Me.txtSequencia.TabIndex = 27
        Me.txtSequencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumeroAM
        '
        Me.txtNumeroAM.AcceptsReturn = True
        Me.txtNumeroAM.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumeroAM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumeroAM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroAM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumeroAM.Location = New System.Drawing.Point(451, 13)
        Me.txtNumeroAM.MaxLength = 0
        Me.txtNumeroAM.Name = "txtNumeroAM"
        Me.txtNumeroAM.ReadOnly = True
        Me.txtNumeroAM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumeroAM.Size = New System.Drawing.Size(70, 20)
        Me.txtNumeroAM.TabIndex = 26
        Me.txtNumeroAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(546, 16)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(43, 14)
        Me._Label1_4.TabIndex = 35
        Me._Label1_4.Text = "Veiculo"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(390, 16)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(61, 14)
        Me._Label1_3.TabIndex = 33
        Me._Label1_3.Text = "Documento"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(270, 16)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(58, 14)
        Me._Label1_2.TabIndex = 32
        Me._Label1_2.Text = "Sequencia"
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = True
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(141, 16)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(48, 14)
        Me._Label1_1.TabIndex = 31
        Me._Label1_1.Text = "Contrato"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(12, 16)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(49, 14)
        Me._Label1_0.TabIndex = 30
        Me._Label1_0.Text = "Empresa"
        '
        '_Frame2_0
        '
        Me._Frame2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Frame2_0.Controls.Add(Me.txtTotalCompensado)
        Me._Frame2_0.Controls.Add(Me.txtQtdFalhas)
        Me._Frame2_0.Controls.Add(Me.txtQtdCompensado)
        Me._Frame2_0.Controls.Add(Me.txtDiferenca)
        Me._Frame2_0.Controls.Add(Me.txtTotalFalhas)
        Me._Frame2_0.Controls.Add(Me._lblTexto_13)
        Me._Frame2_0.Controls.Add(Me._lblTexto_11)
        Me._Frame2_0.Controls.Add(Me._lblTexto_12)
        Me._Frame2_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.SetIndex(Me._Frame2_0, CType(0, Short))
        Me._Frame2_0.Location = New System.Drawing.Point(509, 349)
        Me._Frame2_0.Name = "_Frame2_0"
        Me._Frame2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_0.Size = New System.Drawing.Size(244, 85)
        Me._Frame2_0.TabIndex = 15
        Me._Frame2_0.TabStop = False
        Me._Frame2_0.Text = "Totais"
        '
        'txtTotalCompensado
        '
        Me.txtTotalCompensado.AcceptsReturn = True
        Me.txtTotalCompensado.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalCompensado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalCompensado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompensado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalCompensado.Location = New System.Drawing.Point(132, 36)
        Me.txtTotalCompensado.MaxLength = 0
        Me.txtTotalCompensado.Name = "txtTotalCompensado"
        Me.txtTotalCompensado.ReadOnly = True
        Me.txtTotalCompensado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalCompensado.Size = New System.Drawing.Size(103, 20)
        Me.txtTotalCompensado.TabIndex = 20
        Me.txtTotalCompensado.TabStop = False
        Me.txtTotalCompensado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQtdFalhas
        '
        Me.txtQtdFalhas.AcceptsReturn = True
        Me.txtQtdFalhas.BackColor = System.Drawing.SystemColors.Window
        Me.txtQtdFalhas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQtdFalhas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdFalhas.ForeColor = System.Drawing.Color.Red
        Me.txtQtdFalhas.Location = New System.Drawing.Point(90, 12)
        Me.txtQtdFalhas.MaxLength = 0
        Me.txtQtdFalhas.Name = "txtQtdFalhas"
        Me.txtQtdFalhas.ReadOnly = True
        Me.txtQtdFalhas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQtdFalhas.Size = New System.Drawing.Size(31, 20)
        Me.txtQtdFalhas.TabIndex = 19
        Me.txtQtdFalhas.TabStop = False
        Me.txtQtdFalhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQtdCompensado
        '
        Me.txtQtdCompensado.AcceptsReturn = True
        Me.txtQtdCompensado.BackColor = System.Drawing.SystemColors.Window
        Me.txtQtdCompensado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQtdCompensado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdCompensado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdCompensado.Location = New System.Drawing.Point(90, 36)
        Me.txtQtdCompensado.MaxLength = 0
        Me.txtQtdCompensado.Name = "txtQtdCompensado"
        Me.txtQtdCompensado.ReadOnly = True
        Me.txtQtdCompensado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQtdCompensado.Size = New System.Drawing.Size(31, 20)
        Me.txtQtdCompensado.TabIndex = 18
        Me.txtQtdCompensado.TabStop = False
        Me.txtQtdCompensado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferenca
        '
        Me.txtDiferenca.AcceptsReturn = True
        Me.txtDiferenca.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiferenca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiferenca.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDiferenca.Location = New System.Drawing.Point(90, 60)
        Me.txtDiferenca.MaxLength = 0
        Me.txtDiferenca.Name = "txtDiferenca"
        Me.txtDiferenca.ReadOnly = True
        Me.txtDiferenca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiferenca.Size = New System.Drawing.Size(145, 20)
        Me.txtDiferenca.TabIndex = 17
        Me.txtDiferenca.TabStop = False
        Me.txtDiferenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalFalhas
        '
        Me.txtTotalFalhas.AcceptsReturn = True
        Me.txtTotalFalhas.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalFalhas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalFalhas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFalhas.ForeColor = System.Drawing.Color.Red
        Me.txtTotalFalhas.Location = New System.Drawing.Point(132, 12)
        Me.txtTotalFalhas.MaxLength = 0
        Me.txtTotalFalhas.Name = "txtTotalFalhas"
        Me.txtTotalFalhas.ReadOnly = True
        Me.txtTotalFalhas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalFalhas.Size = New System.Drawing.Size(103, 20)
        Me.txtTotalFalhas.TabIndex = 16
        Me.txtTotalFalhas.TabStop = False
        Me.txtTotalFalhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lblTexto_13
        '
        Me._lblTexto_13.AutoSize = True
        Me._lblTexto_13.BackColor = System.Drawing.SystemColors.Control
        Me._lblTexto_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblTexto_13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblTexto_13.ForeColor = System.Drawing.Color.Black
        Me.lblTexto.SetIndex(Me._lblTexto_13, CType(13, Short))
        Me._lblTexto_13.Location = New System.Drawing.Point(9, 63)
        Me._lblTexto_13.Name = "_lblTexto_13"
        Me._lblTexto_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblTexto_13.Size = New System.Drawing.Size(54, 14)
        Me._lblTexto_13.TabIndex = 23
        Me._lblTexto_13.Text = "Diferença"
        '
        '_lblTexto_11
        '
        Me._lblTexto_11.AutoSize = True
        Me._lblTexto_11.BackColor = System.Drawing.SystemColors.Control
        Me._lblTexto_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblTexto_11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblTexto_11.ForeColor = System.Drawing.Color.Black
        Me.lblTexto.SetIndex(Me._lblTexto_11, CType(11, Short))
        Me._lblTexto_11.Location = New System.Drawing.Point(9, 15)
        Me._lblTexto_11.Name = "_lblTexto_11"
        Me._lblTexto_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblTexto_11.Size = New System.Drawing.Size(39, 14)
        Me._lblTexto_11.TabIndex = 22
        Me._lblTexto_11.Text = "Falhas"
        '
        '_lblTexto_12
        '
        Me._lblTexto_12.BackColor = System.Drawing.SystemColors.Control
        Me._lblTexto_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblTexto_12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblTexto_12.ForeColor = System.Drawing.Color.Black
        Me.lblTexto.SetIndex(Me._lblTexto_12, CType(12, Short))
        Me._lblTexto_12.Location = New System.Drawing.Point(9, 39)
        Me._lblTexto_12.Name = "_lblTexto_12"
        Me._lblTexto_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblTexto_12.Size = New System.Drawing.Size(77, 13)
        Me._lblTexto_12.TabIndex = 21
        Me._lblTexto_12.Text = "Compesação"
        '
        '_Frame2_2
        '
        Me._Frame2_2.BackColor = System.Drawing.SystemColors.Control
        Me._Frame2_2.Controls.Add(Me.txtDataEncerramento)
        Me._Frame2_2.Controls.Add(Me.txtUsuario)
        Me._Frame2_2.Controls.Add(Me._lblTexto_15)
        Me._Frame2_2.Controls.Add(Me._lblTexto_14)
        Me._Frame2_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.SetIndex(Me._Frame2_2, CType(2, Short))
        Me._Frame2_2.Location = New System.Drawing.Point(278, 349)
        Me._Frame2_2.Name = "_Frame2_2"
        Me._Frame2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_2.Size = New System.Drawing.Size(223, 85)
        Me._Frame2_2.TabIndex = 10
        Me._Frame2_2.TabStop = False
        Me._Frame2_2.Text = "Encerramento"
        '
        'txtDataEncerramento
        '
        Me.txtDataEncerramento.AcceptsReturn = True
        Me.txtDataEncerramento.BackColor = System.Drawing.SystemColors.Window
        Me.txtDataEncerramento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataEncerramento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataEncerramento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDataEncerramento.Location = New System.Drawing.Point(63, 21)
        Me.txtDataEncerramento.MaxLength = 0
        Me.txtDataEncerramento.Name = "txtDataEncerramento"
        Me.txtDataEncerramento.ReadOnly = True
        Me.txtDataEncerramento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDataEncerramento.Size = New System.Drawing.Size(139, 20)
        Me.txtDataEncerramento.TabIndex = 12
        '
        'txtUsuario
        '
        Me.txtUsuario.AcceptsReturn = True
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.Location = New System.Drawing.Point(63, 51)
        Me.txtUsuario.MaxLength = 0
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUsuario.Size = New System.Drawing.Size(139, 20)
        Me.txtUsuario.TabIndex = 11
        Me.txtUsuario.TabStop = False
        '
        '_lblTexto_15
        '
        Me._lblTexto_15.AutoSize = True
        Me._lblTexto_15.BackColor = System.Drawing.SystemColors.Control
        Me._lblTexto_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblTexto_15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblTexto_15.ForeColor = System.Drawing.Color.Black
        Me.lblTexto.SetIndex(Me._lblTexto_15, CType(15, Short))
        Me._lblTexto_15.Location = New System.Drawing.Point(18, 54)
        Me._lblTexto_15.Name = "_lblTexto_15"
        Me._lblTexto_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblTexto_15.Size = New System.Drawing.Size(44, 14)
        Me._lblTexto_15.TabIndex = 14
        Me._lblTexto_15.Text = "Usuário"
        '
        '_lblTexto_14
        '
        Me._lblTexto_14.AutoSize = True
        Me._lblTexto_14.BackColor = System.Drawing.SystemColors.Control
        Me._lblTexto_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblTexto_14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblTexto_14.ForeColor = System.Drawing.Color.Black
        Me.lblTexto.SetIndex(Me._lblTexto_14, CType(14, Short))
        Me._lblTexto_14.Location = New System.Drawing.Point(18, 24)
        Me._lblTexto_14.Name = "_lblTexto_14"
        Me._lblTexto_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblTexto_14.Size = New System.Drawing.Size(29, 14)
        Me._lblTexto_14.TabIndex = 13
        Me._lblTexto_14.Text = "Data"
        '
        '_Frame2_1
        '
        Me._Frame2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Frame2_1.Controls.Add(Me.lblSolucao)
        Me._Frame2_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.SetIndex(Me._Frame2_1, CType(1, Short))
        Me._Frame2_1.Location = New System.Drawing.Point(6, 349)
        Me._Frame2_1.Name = "_Frame2_1"
        Me._Frame2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_1.Size = New System.Drawing.Size(265, 85)
        Me._Frame2_1.TabIndex = 2
        Me._Frame2_1.TabStop = False
        Me._Frame2_1.Text = "Soluçao"
        '
        'lblSolucao
        '
        Me.lblSolucao.AutoSize = True
        Me.lblSolucao.BackColor = System.Drawing.SystemColors.Control
        Me.lblSolucao.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSolucao.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolucao.ForeColor = System.Drawing.Color.Red
        Me.lblSolucao.Location = New System.Drawing.Point(66, 28)
        Me.lblSolucao.Name = "lblSolucao"
        Me.lblSolucao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSolucao.Size = New System.Drawing.Size(120, 28)
        Me.lblSolucao.TabIndex = 9
        Me.lblSolucao.Text = "Pendente"
        '
        'txtSolucao
        '
        Me.txtSolucao.AcceptsReturn = True
        Me.txtSolucao.BackColor = System.Drawing.SystemColors.Window
        Me.txtSolucao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSolucao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolucao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSolucao.Location = New System.Drawing.Point(591, 479)
        Me.txtSolucao.MaxLength = 0
        Me.txtSolucao.Name = "txtSolucao"
        Me.txtSolucao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSolucao.Size = New System.Drawing.Size(70, 20)
        Me.txtSolucao.TabIndex = 1
        Me.txtSolucao.Visible = False
        '
        'cmdRetornar
        '
        Me.cmdRetornar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRetornar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRetornar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRetornar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRetornar.Location = New System.Drawing.Point(680, 439)
        Me.cmdRetornar.Name = "cmdRetornar"
        Me.cmdRetornar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRetornar.Size = New System.Drawing.Size(73, 31)
        Me.cmdRetornar.TabIndex = 0
        Me.cmdRetornar.Text = "&Retornar"
        Me.cmdRetornar.UseVisualStyleBackColor = False
        '
        'flxDados
        '
        Me.flxDados.Location = New System.Drawing.Point(6, 12)
        Me.flxDados.Name = "flxDados"
        Me.flxDados.OcxState = CType(resources.GetObject("flxDados.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxDados.Size = New System.Drawing.Size(747, 310)
        Me.flxDados.TabIndex = 24
        '
        'lblCarta
        '
        Me.lblCarta.AutoSize = True
        Me.lblCarta.BackColor = System.Drawing.SystemColors.Control
        Me.lblCarta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCarta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCarta.Location = New System.Drawing.Point(511, 329)
        Me.lblCarta.Name = "lblCarta"
        Me.lblCarta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCarta.Size = New System.Drawing.Size(227, 16)
        Me.lblCarta.TabIndex = 37
        Me.lblCarta.Text = "Não Considerada em Carta de Crédito"
        Me.lblCarta.Visible = False
        '
        'lblFatura
        '
        Me.lblFatura.AutoSize = True
        Me.lblFatura.BackColor = System.Drawing.SystemColors.Control
        Me.lblFatura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFatura.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFatura.Location = New System.Drawing.Point(12, 327)
        Me.lblFatura.Name = "lblFatura"
        Me.lblFatura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFatura.Size = New System.Drawing.Size(170, 16)
        Me.lblFatura.TabIndex = 36
        Me.lblFatura.Text = "Não Considerada em Fatura"
        Me.lblFatura.Visible = False
        '
        'frmDadosAm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(771, 539)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me._Frame2_0)
        Me.Controls.Add(Me._Frame2_2)
        Me.Controls.Add(Me._Frame2_1)
        Me.Controls.Add(Me.txtSolucao)
        Me.Controls.Add(Me.cmdRetornar)
        Me.Controls.Add(Me.flxDados)
        Me.Controls.Add(Me.lblCarta)
        Me.Controls.Add(Me.lblFatura)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(20, 47)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDadosAm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Dados do Documento"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me._Frame2_0.ResumeLayout(False)
        Me._Frame2_0.PerformLayout()
        Me._Frame2_2.ResumeLayout(False)
        Me._Frame2_2.PerformLayout()
        Me._Frame2_1.ResumeLayout(False)
        Me._Frame2_1.PerformLayout()
        CType(Me.flxDados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTexto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
End Class