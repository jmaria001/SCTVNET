<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmComposicao
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
	Public WithEvents chkAlteracao As System.Windows.Forms.CheckBox
	Public WithEvents txtBreak As System.Windows.Forms.TextBox
	Public WithEvents cmbTipo As System.Windows.Forms.ComboBox
	Public WithEvents txtDuracao As System.Windows.Forms.TextBox
	Public WithEvents txtSequencia As System.Windows.Forms.TextBox
	Public WithEvents txtTitulo As System.Windows.Forms.TextBox
	Public WithEvents txtRodape As System.Windows.Forms.TextBox
	Public WithEvents _Line1_1 As System.Windows.Forms.Label
	Public WithEvents _Line2_1 As System.Windows.Forms.Label
	Public WithEvents _Line2_0 As System.Windows.Forms.Label
	Public WithEvents Break As System.Windows.Forms.Label
	Public WithEvents _lbl4_1 As System.Windows.Forms.Label
	Public WithEvents _lbl4_0 As System.Windows.Forms.Label
	Public WithEvents _lbl1_2 As System.Windows.Forms.Label
	Public WithEvents _lbl1_1 As System.Windows.Forms.Label
	Public WithEvents _lbl1_0 As System.Windows.Forms.Label
	Public WithEvents _Line1_0 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents optAbaixo As System.Windows.Forms.RadioButton
	Public WithEvents optAcima As System.Windows.Forms.RadioButton
	Public WithEvents chkNovaFaixa As System.Windows.Forms.CheckBox
	Public WithEvents chkNovoBreak As System.Windows.Forms.CheckBox
	Public WithEvents cmdAplicar As System.Windows.Forms.Button
	Public WithEvents cmdSair As System.Windows.Forms.Button
	Public WithEvents Line1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Line2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lbl1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lbl4 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAlteracao = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtHorario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBreak = New System.Windows.Forms.TextBox
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.txtDuracao = New System.Windows.Forms.TextBox
        Me.txtSequencia = New System.Windows.Forms.TextBox
        Me.txtTitulo = New System.Windows.Forms.TextBox
        Me.txtRodape = New System.Windows.Forms.TextBox
        Me._Line1_1 = New System.Windows.Forms.Label
        Me._Line2_1 = New System.Windows.Forms.Label
        Me._Line2_0 = New System.Windows.Forms.Label
        Me.Break = New System.Windows.Forms.Label
        Me._lbl4_1 = New System.Windows.Forms.Label
        Me._lbl4_0 = New System.Windows.Forms.Label
        Me._lbl1_2 = New System.Windows.Forms.Label
        Me._lbl1_1 = New System.Windows.Forms.Label
        Me._lbl1_0 = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me.optAbaixo = New System.Windows.Forms.RadioButton
        Me.optAcima = New System.Windows.Forms.RadioButton
        Me.chkNovaFaixa = New System.Windows.Forms.CheckBox
        Me.chkNovoBreak = New System.Windows.Forms.CheckBox
        Me.cmdAplicar = New System.Windows.Forms.Button
        Me.cmdSair = New System.Windows.Forms.Button
        Me.Line1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Line2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lbl1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lbl4 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Frame1.SuspendLayout()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAlteracao
        '
        Me.chkAlteracao.BackColor = System.Drawing.SystemColors.Control
        Me.chkAlteracao.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAlteracao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlteracao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAlteracao.Location = New System.Drawing.Point(363, 236)
        Me.chkAlteracao.Name = "chkAlteracao"
        Me.chkAlteracao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAlteracao.Size = New System.Drawing.Size(79, 25)
        Me.chkAlteracao.TabIndex = 19
        Me.chkAlteracao.Text = "Alteracao"
        Me.chkAlteracao.UseVisualStyleBackColor = False
        Me.chkAlteracao.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtHorario)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.txtBreak)
        Me.Frame1.Controls.Add(Me.cmbTipo)
        Me.Frame1.Controls.Add(Me.txtDuracao)
        Me.Frame1.Controls.Add(Me.txtSequencia)
        Me.Frame1.Controls.Add(Me.txtTitulo)
        Me.Frame1.Controls.Add(Me.txtRodape)
        Me.Frame1.Controls.Add(Me._Line1_1)
        Me.Frame1.Controls.Add(Me._Line2_1)
        Me.Frame1.Controls.Add(Me._Line2_0)
        Me.Frame1.Controls.Add(Me.Break)
        Me.Frame1.Controls.Add(Me._lbl4_1)
        Me.Frame1.Controls.Add(Me._lbl4_0)
        Me.Frame1.Controls.Add(Me._lbl1_2)
        Me.Frame1.Controls.Add(Me._lbl1_1)
        Me.Frame1.Controls.Add(Me._lbl1_0)
        Me.Frame1.Controls.Add(Me._Line1_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(439, 220)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'txtHorario
        '
        Me.txtHorario.AcceptsReturn = True
        Me.txtHorario.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorario.Location = New System.Drawing.Point(190, 75)
        Me.txtHorario.MaxLength = 5
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorario.Size = New System.Drawing.Size(81, 22)
        Me.txtHorario.TabIndex = 6
        Me.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHorario.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(117, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Horário"
        Me.Label1.Visible = False
        '
        'txtBreak
        '
        Me.txtBreak.AcceptsReturn = True
        Me.txtBreak.BackColor = System.Drawing.SystemColors.Window
        Me.txtBreak.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBreak.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBreak.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBreak.Location = New System.Drawing.Point(12, 31)
        Me.txtBreak.MaxLength = 3
        Me.txtBreak.Name = "txtBreak"
        Me.txtBreak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBreak.Size = New System.Drawing.Size(82, 22)
        Me.txtBreak.TabIndex = 4
        Me.txtBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipo.Location = New System.Drawing.Point(297, 31)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTipo.Size = New System.Drawing.Size(123, 24)
        Me.cmbTipo.TabIndex = 7
        '
        'txtDuracao
        '
        Me.txtDuracao.AcceptsReturn = True
        Me.txtDuracao.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuracao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDuracao.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDuracao.Location = New System.Drawing.Point(155, 31)
        Me.txtDuracao.MaxLength = 5
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDuracao.Size = New System.Drawing.Size(81, 22)
        Me.txtDuracao.TabIndex = 5
        Me.txtDuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSequencia
        '
        Me.txtSequencia.AcceptsReturn = True
        Me.txtSequencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtSequencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSequencia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSequencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSequencia.Location = New System.Drawing.Point(349, 95)
        Me.txtSequencia.MaxLength = 3
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSequencia.Size = New System.Drawing.Size(57, 22)
        Me.txtSequencia.TabIndex = 12
        Me.txtSequencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitulo
        '
        Me.txtTitulo.AcceptsReturn = True
        Me.txtTitulo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitulo.Location = New System.Drawing.Point(12, 96)
        Me.txtTitulo.MaxLength = 30
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTitulo.Size = New System.Drawing.Size(318, 22)
        Me.txtTitulo.TabIndex = 10
        '
        'txtRodape
        '
        Me.txtRodape.AcceptsReturn = True
        Me.txtRodape.BackColor = System.Drawing.SystemColors.Window
        Me.txtRodape.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRodape.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRodape.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRodape.Location = New System.Drawing.Point(12, 156)
        Me.txtRodape.MaxLength = 60
        Me.txtRodape.Multiline = True
        Me.txtRodape.Name = "txtRodape"
        Me.txtRodape.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRodape.Size = New System.Drawing.Size(415, 54)
        Me.txtRodape.TabIndex = 16
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Line1.SetIndex(Me._Line1_1, CType(1, Short))
        Me._Line1_1.Location = New System.Drawing.Point(0, 132)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(438, 1)
        Me._Line1_1.TabIndex = 14
        Me._Line1_1.Visible = False
        '
        '_Line2_1
        '
        Me._Line2_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Line2.SetIndex(Me._Line2_1, CType(1, Short))
        Me._Line2_1.Location = New System.Drawing.Point(0, 134)
        Me._Line2_1.Name = "_Line2_1"
        Me._Line2_1.Size = New System.Drawing.Size(438, 1)
        Me._Line2_1.TabIndex = 7
        Me._Line2_1.Visible = False
        '
        '_Line2_0
        '
        Me._Line2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Line2.SetIndex(Me._Line2_0, CType(0, Short))
        Me._Line2_0.Location = New System.Drawing.Point(1, 68)
        Me._Line2_0.Name = "_Line2_0"
        Me._Line2_0.Size = New System.Drawing.Size(438, 1)
        Me._Line2_0.TabIndex = 8
        Me._Line2_0.Visible = False
        '
        'Break
        '
        Me.Break.AutoSize = True
        Me.Break.BackColor = System.Drawing.SystemColors.Control
        Me.Break.Cursor = System.Windows.Forms.Cursors.Default
        Me.Break.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Break.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Break.Location = New System.Drawing.Point(12, 12)
        Me.Break.Name = "Break"
        Me.Break.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Break.Size = New System.Drawing.Size(42, 16)
        Me.Break.TabIndex = 0
        Me.Break.Text = "Break"
        '
        '_lbl4_1
        '
        Me._lbl4_1.AutoSize = True
        Me._lbl4_1.BackColor = System.Drawing.SystemColors.Control
        Me._lbl4_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl4_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbl4_1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl4.SetIndex(Me._lbl4_1, CType(1, Short))
        Me._lbl4_1.Location = New System.Drawing.Point(298, 12)
        Me._lbl4_1.Name = "_lbl4_1"
        Me._lbl4_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl4_1.Size = New System.Drawing.Size(32, 16)
        Me._lbl4_1.TabIndex = 3
        Me._lbl4_1.Text = "Tipo"
        '
        '_lbl4_0
        '
        Me._lbl4_0.AutoSize = True
        Me._lbl4_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbl4_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl4_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbl4_0.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl4.SetIndex(Me._lbl4_0, CType(0, Short))
        Me._lbl4_0.Location = New System.Drawing.Point(155, 12)
        Me._lbl4_0.Name = "_lbl4_0"
        Me._lbl4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl4_0.Size = New System.Drawing.Size(56, 16)
        Me._lbl4_0.TabIndex = 1
        Me._lbl4_0.Text = "Duração"
        '
        '_lbl1_2
        '
        Me._lbl1_2.AutoSize = True
        Me._lbl1_2.BackColor = System.Drawing.SystemColors.Control
        Me._lbl1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl1_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbl1_2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl1.SetIndex(Me._lbl1_2, CType(2, Short))
        Me._lbl1_2.Location = New System.Drawing.Point(327, 76)
        Me._lbl1_2.Name = "_lbl1_2"
        Me._lbl1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl1_2.Size = New System.Drawing.Size(107, 16)
        Me._lbl1_2.TabIndex = 11
        Me._lbl1_2.Text = "Sequência/Break"
        '
        '_lbl1_1
        '
        Me._lbl1_1.AutoSize = True
        Me._lbl1_1.BackColor = System.Drawing.SystemColors.Control
        Me._lbl1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl1_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbl1_1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl1.SetIndex(Me._lbl1_1, CType(1, Short))
        Me._lbl1_1.Location = New System.Drawing.Point(12, 75)
        Me._lbl1_1.Name = "_lbl1_1"
        Me._lbl1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl1_1.Size = New System.Drawing.Size(39, 16)
        Me._lbl1_1.TabIndex = 9
        Me._lbl1_1.Text = "Titulo"
        '
        '_lbl1_0
        '
        Me._lbl1_0.AutoSize = True
        Me._lbl1_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbl1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl1_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbl1_0.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl1.SetIndex(Me._lbl1_0, CType(0, Short))
        Me._lbl1_0.Location = New System.Drawing.Point(12, 137)
        Me._lbl1_0.Name = "_lbl1_0"
        Me._lbl1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl1_0.Size = New System.Drawing.Size(52, 16)
        Me._lbl1_0.TabIndex = 15
        Me._lbl1_0.Text = "Rodapé"
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Line1.SetIndex(Me._Line1_0, CType(0, Short))
        Me._Line1_0.Location = New System.Drawing.Point(1, 67)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(438, 1)
        Me._Line1_0.TabIndex = 19
        Me._Line1_0.Visible = False
        '
        'optAbaixo
        '
        Me.optAbaixo.BackColor = System.Drawing.SystemColors.Control
        Me.optAbaixo.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAbaixo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAbaixo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAbaixo.Location = New System.Drawing.Point(6, 261)
        Me.optAbaixo.Name = "optAbaixo"
        Me.optAbaixo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAbaixo.Size = New System.Drawing.Size(211, 51)
        Me.optAbaixo.TabIndex = 2
        Me.optAbaixo.TabStop = True
        Me.optAbaixo.Text = "Criar Faixa Abaixo da Linha Posicionada"
        Me.optAbaixo.UseVisualStyleBackColor = False
        Me.optAbaixo.Visible = False
        '
        'optAcima
        '
        Me.optAcima.BackColor = System.Drawing.SystemColors.Control
        Me.optAcima.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAcima.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAcima.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAcima.Location = New System.Drawing.Point(6, 216)
        Me.optAcima.Name = "optAcima"
        Me.optAcima.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAcima.Size = New System.Drawing.Size(211, 52)
        Me.optAcima.TabIndex = 1
        Me.optAcima.TabStop = True
        Me.optAcima.Text = "Criar Faixa Acima da Linha Posicionada"
        Me.optAcima.UseVisualStyleBackColor = False
        Me.optAcima.Visible = False
        '
        'chkNovaFaixa
        '
        Me.chkNovaFaixa.BackColor = System.Drawing.SystemColors.Control
        Me.chkNovaFaixa.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNovaFaixa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNovaFaixa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNovaFaixa.Location = New System.Drawing.Point(223, 229)
        Me.chkNovaFaixa.Name = "chkNovaFaixa"
        Me.chkNovaFaixa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNovaFaixa.Size = New System.Drawing.Size(54, 39)
        Me.chkNovaFaixa.TabIndex = 3
        Me.chkNovaFaixa.Text = "Nova Faixa"
        Me.chkNovaFaixa.UseVisualStyleBackColor = False
        Me.chkNovaFaixa.Visible = False
        '
        'chkNovoBreak
        '
        Me.chkNovoBreak.BackColor = System.Drawing.SystemColors.Control
        Me.chkNovoBreak.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNovoBreak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNovoBreak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNovoBreak.Location = New System.Drawing.Point(292, 236)
        Me.chkNovoBreak.Name = "chkNovoBreak"
        Me.chkNovoBreak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNovoBreak.Size = New System.Drawing.Size(79, 25)
        Me.chkNovoBreak.TabIndex = 8
        Me.chkNovoBreak.Text = "Novo Break"
        Me.chkNovoBreak.UseVisualStyleBackColor = False
        Me.chkNovoBreak.Visible = False
        '
        'cmdAplicar
        '
        Me.cmdAplicar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAplicar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAplicar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAplicar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAplicar.Location = New System.Drawing.Point(276, 270)
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAplicar.Size = New System.Drawing.Size(81, 33)
        Me.cmdAplicar.TabIndex = 6
        Me.cmdAplicar.Text = "&Aplicar"
        Me.cmdAplicar.UseVisualStyleBackColor = False
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.CausesValidation = False
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(364, 270)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(81, 33)
        Me.cmdSair.TabIndex = 7
        Me.cmdSair.TabStop = False
        Me.cmdSair.Text = "Sai&r"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'frmComposicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(449, 312)
        Me.Controls.Add(Me.chkAlteracao)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.optAbaixo)
        Me.Controls.Add(Me.optAcima)
        Me.Controls.Add(Me.chkNovaFaixa)
        Me.Controls.Add(Me.chkNovoBreak)
        Me.Controls.Add(Me.cmdAplicar)
        Me.Controls.Add(Me.cmdSair)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(178, 199)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComposicao"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Composição do Break"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents txtHorario As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
#End Region 
End Class