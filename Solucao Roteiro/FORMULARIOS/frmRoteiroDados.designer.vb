<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRoteiroDados
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
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
	Public WithEvents chkAlterarNumero As System.Windows.Forms.CheckBox
	Public WithEvents chkOk As System.Windows.Forms.CheckBox
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents chkMidia As System.Windows.Forms.CheckBox
	Public WithEvents chkAvulso As System.Windows.Forms.CheckBox
	Public WithEvents chkArtistico As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdFechar As System.Windows.Forms.Button
	Public WithEvents txtCodigoComercial As System.Windows.Forms.TextBox
	Public WithEvents txtSequencia As System.Windows.Forms.TextBox
	Public WithEvents txtContrato As System.Windows.Forms.TextBox
	Public WithEvents txtEmpresa As System.Windows.Forms.TextBox
	Public WithEvents txtDuracao As System.Windows.Forms.TextBox
	Public WithEvents txtTitulo As System.Windows.Forms.TextBox
	Public WithEvents txtNumeroFita As System.Windows.Forms.TextBox
	Public WithEvents txtTipoComercial As System.Windows.Forms.TextBox
	Public WithEvents txtProduto As System.Windows.Forms.TextBox
	Public WithEvents txtAgencia As System.Windows.Forms.TextBox
	Public WithEvents txtCliente As System.Windows.Forms.TextBox
	Public WithEvents txtObservacao As System.Windows.Forms.TextBox
	Public WithEvents txtFormaPagamento As System.Windows.Forms.TextBox
	Public WithEvents txtPatrocinio As System.Windows.Forms.TextBox
	Public WithEvents txtCompensacao As System.Windows.Forms.TextBox
	Public WithEvents _Label4_8 As System.Windows.Forms.Label
	Public WithEvents _Label4_7 As System.Windows.Forms.Label
	Public WithEvents _Label4_1 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents imgObservacao As System.Windows.Forms.PictureBox
	Public WithEvents _Label4_6 As System.Windows.Forms.Label
	Public WithEvents _Label4_5 As System.Windows.Forms.Label
	Public WithEvents _Label4_4 As System.Windows.Forms.Label
	Public WithEvents _Label4_3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents _Label4_0 As System.Windows.Forms.Label
	Public WithEvents _Label4_2 As System.Windows.Forms.Label
	Public WithEvents _fratab_1 As System.Windows.Forms.GroupBox
	Public WithEvents txtChaveAcesso As System.Windows.Forms.TextBox
	Public WithEvents txtVeiculo As System.Windows.Forms.TextBox
	Public WithEvents txtData As System.Windows.Forms.TextBox
	Public WithEvents txtPrograma As System.Windows.Forms.TextBox
	Public WithEvents Label4 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents fratab As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoteiroDados))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAlterarNumero = New System.Windows.Forms.CheckBox
        Me.chkOk = New System.Windows.Forms.CheckBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.chkMidia = New System.Windows.Forms.CheckBox
        Me.chkAvulso = New System.Windows.Forms.CheckBox
        Me.chkArtistico = New System.Windows.Forms.CheckBox
        Me.cmdFechar = New System.Windows.Forms.Button
        Me._fratab_1 = New System.Windows.Forms.GroupBox
        Me.txtIdFita = New System.Windows.Forms.TextBox
        Me.txtCodigoComercial = New System.Windows.Forms.TextBox
        Me.txtSequencia = New System.Windows.Forms.TextBox
        Me.txtContrato = New System.Windows.Forms.TextBox
        Me.txtEmpresa = New System.Windows.Forms.TextBox
        Me.txtDuracao = New System.Windows.Forms.TextBox
        Me.txtTitulo = New System.Windows.Forms.TextBox
        Me.txtNumeroFita = New System.Windows.Forms.TextBox
        Me.txtTipoComercial = New System.Windows.Forms.TextBox
        Me.txtProduto = New System.Windows.Forms.TextBox
        Me.txtAgencia = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtObservacao = New System.Windows.Forms.TextBox
        Me.txtFormaPagamento = New System.Windows.Forms.TextBox
        Me.txtPatrocinio = New System.Windows.Forms.TextBox
        Me.txtCompensacao = New System.Windows.Forms.TextBox
        Me._Label4_8 = New System.Windows.Forms.Label
        Me._Label4_7 = New System.Windows.Forms.Label
        Me._Label4_1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.imgObservacao = New System.Windows.Forms.PictureBox
        Me._Label4_6 = New System.Windows.Forms.Label
        Me._Label4_5 = New System.Windows.Forms.Label
        Me._Label4_4 = New System.Windows.Forms.Label
        Me._Label4_3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me._Label4_0 = New System.Windows.Forms.Label
        Me._Label4_2 = New System.Windows.Forms.Label
        Me.txtChaveAcesso = New System.Windows.Forms.TextBox
        Me.txtVeiculo = New System.Windows.Forms.TextBox
        Me.txtData = New System.Windows.Forms.TextBox
        Me.txtPrograma = New System.Windows.Forms.TextBox
        Me.Label4 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.fratab = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Frame1.SuspendLayout()
        Me._fratab_1.SuspendLayout()
        CType(Me.imgObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fratab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAlterarNumero
        '
        Me.chkAlterarNumero.BackColor = System.Drawing.SystemColors.Control
        Me.chkAlterarNumero.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAlterarNumero.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlterarNumero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAlterarNumero.Location = New System.Drawing.Point(153, 273)
        Me.chkAlterarNumero.Name = "chkAlterarNumero"
        Me.chkAlterarNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAlterarNumero.Size = New System.Drawing.Size(202, 22)
        Me.chkAlterarNumero.TabIndex = 40
        Me.chkAlterarNumero.Text = "Alterar numero de Fita"
        Me.chkAlterarNumero.UseVisualStyleBackColor = False
        Me.chkAlterarNumero.Visible = False
        '
        'chkOk
        '
        Me.chkOk.BackColor = System.Drawing.SystemColors.Control
        Me.chkOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOk.Location = New System.Drawing.Point(267, 346)
        Me.chkOk.Name = "chkOk"
        Me.chkOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOk.Size = New System.Drawing.Size(13, 22)
        Me.chkOk.TabIndex = 39
        Me.chkOk.Text = "Check1"
        Me.chkOk.UseVisualStyleBackColor = False
        Me.chkOk.Visible = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Enabled = False
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(291, 339)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(72, 33)
        Me.cmdOk.TabIndex = 22
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkMidia)
        Me.Frame1.Controls.Add(Me.chkAvulso)
        Me.Frame1.Controls.Add(Me.chkArtistico)
        Me.Frame1.Enabled = False
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 333)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(247, 37)
        Me.Frame1.TabIndex = 30
        Me.Frame1.TabStop = False
        '
        'chkMidia
        '
        Me.chkMidia.BackColor = System.Drawing.SystemColors.Control
        Me.chkMidia.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMidia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMidia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMidia.Location = New System.Drawing.Point(12, 12)
        Me.chkMidia.Name = "chkMidia"
        Me.chkMidia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMidia.Size = New System.Drawing.Size(58, 20)
        Me.chkMidia.TabIndex = 33
        Me.chkMidia.Text = "Mídia"
        Me.chkMidia.UseVisualStyleBackColor = False
        '
        'chkAvulso
        '
        Me.chkAvulso.BackColor = System.Drawing.SystemColors.Control
        Me.chkAvulso.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAvulso.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAvulso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAvulso.Location = New System.Drawing.Point(87, 12)
        Me.chkAvulso.Name = "chkAvulso"
        Me.chkAvulso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAvulso.Size = New System.Drawing.Size(82, 20)
        Me.chkAvulso.TabIndex = 32
        Me.chkAvulso.Text = "Avulso"
        Me.chkAvulso.UseVisualStyleBackColor = False
        '
        'chkArtistico
        '
        Me.chkArtistico.BackColor = System.Drawing.SystemColors.Control
        Me.chkArtistico.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkArtistico.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArtistico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkArtistico.Location = New System.Drawing.Point(163, 12)
        Me.chkArtistico.Name = "chkArtistico"
        Me.chkArtistico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkArtistico.Size = New System.Drawing.Size(68, 20)
        Me.chkArtistico.TabIndex = 31
        Me.chkArtistico.Text = "Artistico"
        Me.chkArtistico.UseVisualStyleBackColor = False
        '
        'cmdFechar
        '
        Me.cmdFechar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFechar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFechar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFechar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFechar.Location = New System.Drawing.Point(375, 339)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFechar.Size = New System.Drawing.Size(72, 33)
        Me.cmdFechar.TabIndex = 24
        Me.cmdFechar.Text = "&Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = False
        '
        '_fratab_1
        '
        Me._fratab_1.BackColor = System.Drawing.SystemColors.Control
        Me._fratab_1.Controls.Add(Me.txtIdFita)
        Me._fratab_1.Controls.Add(Me.txtCodigoComercial)
        Me._fratab_1.Controls.Add(Me.txtSequencia)
        Me._fratab_1.Controls.Add(Me.txtContrato)
        Me._fratab_1.Controls.Add(Me.txtEmpresa)
        Me._fratab_1.Controls.Add(Me.txtDuracao)
        Me._fratab_1.Controls.Add(Me.txtTitulo)
        Me._fratab_1.Controls.Add(Me.txtNumeroFita)
        Me._fratab_1.Controls.Add(Me.txtTipoComercial)
        Me._fratab_1.Controls.Add(Me.txtProduto)
        Me._fratab_1.Controls.Add(Me.txtAgencia)
        Me._fratab_1.Controls.Add(Me.txtCliente)
        Me._fratab_1.Controls.Add(Me.txtObservacao)
        Me._fratab_1.Controls.Add(Me.txtFormaPagamento)
        Me._fratab_1.Controls.Add(Me.txtPatrocinio)
        Me._fratab_1.Controls.Add(Me.txtCompensacao)
        Me._fratab_1.Controls.Add(Me._Label4_8)
        Me._fratab_1.Controls.Add(Me._Label4_7)
        Me._fratab_1.Controls.Add(Me._Label4_1)
        Me._fratab_1.Controls.Add(Me.Label5)
        Me._fratab_1.Controls.Add(Me.imgObservacao)
        Me._fratab_1.Controls.Add(Me._Label4_6)
        Me._fratab_1.Controls.Add(Me._Label4_5)
        Me._fratab_1.Controls.Add(Me._Label4_4)
        Me._fratab_1.Controls.Add(Me._Label4_3)
        Me._fratab_1.Controls.Add(Me.Label1)
        Me._fratab_1.Controls.Add(Me.Label2)
        Me._fratab_1.Controls.Add(Me.Label3)
        Me._fratab_1.Controls.Add(Me._Label4_0)
        Me._fratab_1.Controls.Add(Me._Label4_2)
        Me._fratab_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fratab_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fratab.SetIndex(Me._fratab_1, CType(1, Short))
        Me._fratab_1.Location = New System.Drawing.Point(12, 6)
        Me._fratab_1.Name = "_fratab_1"
        Me._fratab_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fratab_1.Size = New System.Drawing.Size(433, 322)
        Me._fratab_1.TabIndex = 4
        Me._fratab_1.TabStop = False
        '
        'txtIdFita
        '
        Me.txtIdFita.AcceptsReturn = True
        Me.txtIdFita.BackColor = System.Drawing.Color.White
        Me.txtIdFita.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdFita.Enabled = False
        Me.txtIdFita.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdFita.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdFita.Location = New System.Drawing.Point(65, 269)
        Me.txtIdFita.MaxLength = 0
        Me.txtIdFita.Name = "txtIdFita"
        Me.txtIdFita.ReadOnly = True
        Me.txtIdFita.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIdFita.Size = New System.Drawing.Size(70, 20)
        Me.txtIdFita.TabIndex = 40
        Me.txtIdFita.TabStop = False
        Me.txtIdFita.Visible = False
        '
        'txtCodigoComercial
        '
        Me.txtCodigoComercial.AcceptsReturn = True
        Me.txtCodigoComercial.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoComercial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoComercial.Enabled = False
        Me.txtCodigoComercial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoComercial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigoComercial.Location = New System.Drawing.Point(129, 91)
        Me.txtCodigoComercial.MaxLength = 0
        Me.txtCodigoComercial.Name = "txtCodigoComercial"
        Me.txtCodigoComercial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigoComercial.Size = New System.Drawing.Size(30, 20)
        Me.txtCodigoComercial.TabIndex = 38
        '
        'txtSequencia
        '
        Me.txtSequencia.AcceptsReturn = True
        Me.txtSequencia.BackColor = System.Drawing.Color.White
        Me.txtSequencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSequencia.Enabled = False
        Me.txtSequencia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSequencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSequencia.Location = New System.Drawing.Point(386, 165)
        Me.txtSequencia.MaxLength = 0
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.ReadOnly = True
        Me.txtSequencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSequencia.Size = New System.Drawing.Size(33, 20)
        Me.txtSequencia.TabIndex = 36
        Me.txtSequencia.TabStop = False
        '
        'txtContrato
        '
        Me.txtContrato.AcceptsReturn = True
        Me.txtContrato.BackColor = System.Drawing.Color.White
        Me.txtContrato.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContrato.Enabled = False
        Me.txtContrato.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrato.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContrato.Location = New System.Drawing.Point(231, 165)
        Me.txtContrato.MaxLength = 0
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.ReadOnly = True
        Me.txtContrato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContrato.Size = New System.Drawing.Size(78, 20)
        Me.txtContrato.TabIndex = 34
        Me.txtContrato.TabStop = False
        '
        'txtEmpresa
        '
        Me.txtEmpresa.AcceptsReturn = True
        Me.txtEmpresa.BackColor = System.Drawing.Color.White
        Me.txtEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpresa.Enabled = False
        Me.txtEmpresa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmpresa.Location = New System.Drawing.Point(128, 165)
        Me.txtEmpresa.MaxLength = 0
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.ReadOnly = True
        Me.txtEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmpresa.Size = New System.Drawing.Size(45, 20)
        Me.txtEmpresa.TabIndex = 29
        Me.txtEmpresa.TabStop = False
        '
        'txtDuracao
        '
        Me.txtDuracao.AcceptsReturn = True
        Me.txtDuracao.BackColor = System.Drawing.Color.White
        Me.txtDuracao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDuracao.Enabled = False
        Me.txtDuracao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDuracao.Location = New System.Drawing.Point(372, 116)
        Me.txtDuracao.MaxLength = 0
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.ReadOnly = True
        Me.txtDuracao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDuracao.Size = New System.Drawing.Size(46, 20)
        Me.txtDuracao.TabIndex = 27
        '
        'txtTitulo
        '
        Me.txtTitulo.AcceptsReturn = True
        Me.txtTitulo.BackColor = System.Drawing.Color.White
        Me.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitulo.Location = New System.Drawing.Point(159, 91)
        Me.txtTitulo.MaxLength = 0
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTitulo.Size = New System.Drawing.Size(258, 20)
        Me.txtTitulo.TabIndex = 25
        Me.txtTitulo.TabStop = False
        '
        'txtNumeroFita
        '
        Me.txtNumeroFita.AcceptsReturn = True
        Me.txtNumeroFita.BackColor = System.Drawing.Color.White
        Me.txtNumeroFita.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumeroFita.Enabled = False
        Me.txtNumeroFita.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroFita.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumeroFita.Location = New System.Drawing.Point(129, 140)
        Me.txtNumeroFita.MaxLength = 0
        Me.txtNumeroFita.Name = "txtNumeroFita"
        Me.txtNumeroFita.ReadOnly = True
        Me.txtNumeroFita.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumeroFita.Size = New System.Drawing.Size(291, 20)
        Me.txtNumeroFita.TabIndex = 13
        Me.txtNumeroFita.TabStop = False
        '
        'txtTipoComercial
        '
        Me.txtTipoComercial.AcceptsReturn = True
        Me.txtTipoComercial.BackColor = System.Drawing.Color.White
        Me.txtTipoComercial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoComercial.Enabled = False
        Me.txtTipoComercial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoComercial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoComercial.Location = New System.Drawing.Point(128, 116)
        Me.txtTipoComercial.MaxLength = 0
        Me.txtTipoComercial.Name = "txtTipoComercial"
        Me.txtTipoComercial.ReadOnly = True
        Me.txtTipoComercial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoComercial.Size = New System.Drawing.Size(216, 20)
        Me.txtTipoComercial.TabIndex = 12
        Me.txtTipoComercial.TabStop = False
        '
        'txtProduto
        '
        Me.txtProduto.AcceptsReturn = True
        Me.txtProduto.BackColor = System.Drawing.Color.White
        Me.txtProduto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProduto.Enabled = False
        Me.txtProduto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProduto.Location = New System.Drawing.Point(128, 67)
        Me.txtProduto.MaxLength = 0
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProduto.Size = New System.Drawing.Size(291, 20)
        Me.txtProduto.TabIndex = 11
        Me.txtProduto.TabStop = False
        '
        'txtAgencia
        '
        Me.txtAgencia.AcceptsReturn = True
        Me.txtAgencia.BackColor = System.Drawing.Color.White
        Me.txtAgencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAgencia.Enabled = False
        Me.txtAgencia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAgencia.Location = New System.Drawing.Point(128, 42)
        Me.txtAgencia.MaxLength = 0
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.ReadOnly = True
        Me.txtAgencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAgencia.Size = New System.Drawing.Size(291, 20)
        Me.txtAgencia.TabIndex = 10
        Me.txtAgencia.TabStop = False
        '
        'txtCliente
        '
        Me.txtCliente.AcceptsReturn = True
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCliente.Location = New System.Drawing.Point(128, 17)
        Me.txtCliente.MaxLength = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.Size = New System.Drawing.Size(291, 20)
        Me.txtCliente.TabIndex = 9
        Me.txtCliente.TabStop = False
        '
        'txtObservacao
        '
        Me.txtObservacao.AcceptsReturn = True
        Me.txtObservacao.BackColor = System.Drawing.Color.White
        Me.txtObservacao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObservacao.Enabled = False
        Me.txtObservacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacao.ForeColor = System.Drawing.Color.Blue
        Me.txtObservacao.Location = New System.Drawing.Point(42, 246)
        Me.txtObservacao.MaxLength = 0
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ReadOnly = True
        Me.txtObservacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(376, 68)
        Me.txtObservacao.TabIndex = 8
        '
        'txtFormaPagamento
        '
        Me.txtFormaPagamento.AcceptsReturn = True
        Me.txtFormaPagamento.BackColor = System.Drawing.Color.White
        Me.txtFormaPagamento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFormaPagamento.Enabled = False
        Me.txtFormaPagamento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaPagamento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFormaPagamento.Location = New System.Drawing.Point(129, 190)
        Me.txtFormaPagamento.MaxLength = 0
        Me.txtFormaPagamento.Name = "txtFormaPagamento"
        Me.txtFormaPagamento.ReadOnly = True
        Me.txtFormaPagamento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFormaPagamento.Size = New System.Drawing.Size(288, 20)
        Me.txtFormaPagamento.TabIndex = 7
        Me.txtFormaPagamento.TabStop = False
        '
        'txtPatrocinio
        '
        Me.txtPatrocinio.AcceptsReturn = True
        Me.txtPatrocinio.BackColor = System.Drawing.Color.White
        Me.txtPatrocinio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPatrocinio.Enabled = False
        Me.txtPatrocinio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatrocinio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPatrocinio.Location = New System.Drawing.Point(129, 213)
        Me.txtPatrocinio.MaxLength = 0
        Me.txtPatrocinio.Name = "txtPatrocinio"
        Me.txtPatrocinio.ReadOnly = True
        Me.txtPatrocinio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPatrocinio.Size = New System.Drawing.Size(70, 20)
        Me.txtPatrocinio.TabIndex = 6
        Me.txtPatrocinio.TabStop = False
        '
        'txtCompensacao
        '
        Me.txtCompensacao.AcceptsReturn = True
        Me.txtCompensacao.BackColor = System.Drawing.Color.White
        Me.txtCompensacao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompensacao.Enabled = False
        Me.txtCompensacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompensacao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompensacao.Location = New System.Drawing.Point(347, 213)
        Me.txtCompensacao.MaxLength = 0
        Me.txtCompensacao.Name = "txtCompensacao"
        Me.txtCompensacao.ReadOnly = True
        Me.txtCompensacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompensacao.Size = New System.Drawing.Size(70, 20)
        Me.txtCompensacao.TabIndex = 5
        Me.txtCompensacao.TabStop = False
        '
        '_Label4_8
        '
        Me._Label4_8.AutoSize = True
        Me._Label4_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_8, CType(8, Short))
        Me._Label4_8.Location = New System.Drawing.Point(327, 168)
        Me._Label4_8.Name = "_Label4_8"
        Me._Label4_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_8.Size = New System.Drawing.Size(58, 14)
        Me._Label4_8.TabIndex = 37
        Me._Label4_8.Text = "Sequencia"
        '
        '_Label4_7
        '
        Me._Label4_7.AutoSize = True
        Me._Label4_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_7, CType(7, Short))
        Me._Label4_7.Location = New System.Drawing.Point(183, 168)
        Me._Label4_7.Name = "_Label4_7"
        Me._Label4_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_7.Size = New System.Drawing.Size(48, 14)
        Me._Label4_7.TabIndex = 35
        Me._Label4_7.Text = "Contrato"
        '
        '_Label4_1
        '
        Me._Label4_1.AutoSize = True
        Me._Label4_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_1, CType(1, Short))
        Me._Label4_1.Location = New System.Drawing.Point(348, 119)
        Me._Label4_1.Name = "_Label4_1"
        Me._Label4_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_1.Size = New System.Drawing.Size(27, 14)
        Me._Label4_1.TabIndex = 28
        Me._Label4_1.Text = "Dur."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(9, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(35, 14)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Titulo "
        '
        'imgObservacao
        '
        Me.imgObservacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgObservacao.Image = CType(resources.GetObject("imgObservacao.Image"), System.Drawing.Image)
        Me.imgObservacao.Location = New System.Drawing.Point(5, 246)
        Me.imgObservacao.Name = "imgObservacao"
        Me.imgObservacao.Size = New System.Drawing.Size(32, 32)
        Me.imgObservacao.TabIndex = 39
        Me.imgObservacao.TabStop = False
        '
        '_Label4_6
        '
        Me._Label4_6.AutoSize = True
        Me._Label4_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_6, CType(6, Short))
        Me._Label4_6.Location = New System.Drawing.Point(274, 216)
        Me._Label4_6.Name = "_Label4_6"
        Me._Label4_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_6.Size = New System.Drawing.Size(76, 14)
        Me._Label4_6.TabIndex = 23
        Me._Label4_6.Text = "Compensação"
        '
        '_Label4_5
        '
        Me._Label4_5.AutoSize = True
        Me._Label4_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_5, CType(5, Short))
        Me._Label4_5.Location = New System.Drawing.Point(9, 216)
        Me._Label4_5.Name = "_Label4_5"
        Me._Label4_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_5.Size = New System.Drawing.Size(54, 14)
        Me._Label4_5.TabIndex = 21
        Me._Label4_5.Text = "Patrocínio"
        '
        '_Label4_4
        '
        Me._Label4_4.AutoSize = True
        Me._Label4_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_4, CType(4, Short))
        Me._Label4_4.Location = New System.Drawing.Point(9, 193)
        Me._Label4_4.Name = "_Label4_4"
        Me._Label4_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_4.Size = New System.Drawing.Size(108, 14)
        Me._Label4_4.TabIndex = 20
        Me._Label4_4.Text = "Forma de Pagamento"
        '
        '_Label4_3
        '
        Me._Label4_3.AutoSize = True
        Me._Label4_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_3, CType(3, Short))
        Me._Label4_3.Location = New System.Drawing.Point(9, 168)
        Me._Label4_3.Name = "_Label4_3"
        Me._Label4_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_3.Size = New System.Drawing.Size(49, 14)
        Me._Label4_3.TabIndex = 19
        Me._Label4_3.Text = "Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(9, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(47, 14)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Agencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(9, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Produto"
        '
        '_Label4_0
        '
        Me._Label4_0.AutoSize = True
        Me._Label4_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_0.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_0, CType(0, Short))
        Me._Label4_0.Location = New System.Drawing.Point(9, 119)
        Me._Label4_0.Name = "_Label4_0"
        Me._Label4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_0.Size = New System.Drawing.Size(92, 14)
        Me._Label4_0.TabIndex = 15
        Me._Label4_0.Text = "Tipo de Comercial"
        '
        '_Label4_2
        '
        Me._Label4_2.AutoSize = True
        Me._Label4_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label4_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label4_2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.SetIndex(Me._Label4_2, CType(2, Short))
        Me._Label4_2.Location = New System.Drawing.Point(9, 143)
        Me._Label4_2.Name = "_Label4_2"
        Me._Label4_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_2.Size = New System.Drawing.Size(79, 14)
        Me._Label4_2.TabIndex = 14
        Me._Label4_2.Text = "Número da Fita"
        '
        'txtChaveAcesso
        '
        Me.txtChaveAcesso.AcceptsReturn = True
        Me.txtChaveAcesso.BackColor = System.Drawing.SystemColors.Window
        Me.txtChaveAcesso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChaveAcesso.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveAcesso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChaveAcesso.Location = New System.Drawing.Point(192, 387)
        Me.txtChaveAcesso.MaxLength = 0
        Me.txtChaveAcesso.Name = "txtChaveAcesso"
        Me.txtChaveAcesso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChaveAcesso.Size = New System.Drawing.Size(37, 20)
        Me.txtChaveAcesso.TabIndex = 3
        Me.txtChaveAcesso.Visible = False
        '
        'txtVeiculo
        '
        Me.txtVeiculo.AcceptsReturn = True
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Window
        Me.txtVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVeiculo.Location = New System.Drawing.Point(14, 386)
        Me.txtVeiculo.MaxLength = 0
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVeiculo.Size = New System.Drawing.Size(37, 20)
        Me.txtVeiculo.TabIndex = 2
        Me.txtVeiculo.Visible = False
        '
        'txtData
        '
        Me.txtData.AcceptsReturn = True
        Me.txtData.BackColor = System.Drawing.SystemColors.Window
        Me.txtData.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtData.Location = New System.Drawing.Point(56, 386)
        Me.txtData.MaxLength = 0
        Me.txtData.Name = "txtData"
        Me.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtData.Size = New System.Drawing.Size(67, 20)
        Me.txtData.TabIndex = 1
        Me.txtData.Visible = False
        '
        'txtPrograma
        '
        Me.txtPrograma.AcceptsReturn = True
        Me.txtPrograma.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrograma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrograma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrograma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrograma.Location = New System.Drawing.Point(135, 390)
        Me.txtPrograma.MaxLength = 0
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrograma.Size = New System.Drawing.Size(37, 20)
        Me.txtPrograma.TabIndex = 0
        Me.txtPrograma.Visible = False
        '
        'frmRoteiroDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(453, 380)
        Me.Controls.Add(Me.chkAlterarNumero)
        Me.Controls.Add(Me.chkOk)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me._fratab_1)
        Me.Controls.Add(Me.txtChaveAcesso)
        Me.Controls.Add(Me.txtVeiculo)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtPrograma)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(54, 88)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoteiroDados"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Dados do Comercial"
        Me.Frame1.ResumeLayout(False)
        Me._fratab_1.ResumeLayout(False)
        Me._fratab_1.PerformLayout()
        CType(Me.imgObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fratab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtIdFita As System.Windows.Forms.TextBox
#End Region
End Class