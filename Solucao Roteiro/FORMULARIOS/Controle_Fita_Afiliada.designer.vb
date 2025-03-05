<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmControleFita_Afiliada
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
    Public WithEvents cmdDesmarcarTodos As System.Windows.Forms.Button
    Public WithEvents cmdMarcarTodos As System.Windows.Forms.Button
    Public WithEvents picDesativado As System.Windows.Forms.PictureBox
    Public WithEvents txtLinha1 As System.Windows.Forms.TextBox
    Public WithEvents txtLinha2 As System.Windows.Forms.TextBox
    Public WithEvents txtTotalFitas As System.Windows.Forms.TextBox
    Public WithEvents _optClassificacao_0 As System.Windows.Forms.RadioButton
    Public WithEvents _optClassificacao_1 As System.Windows.Forms.RadioButton
    Public WithEvents fraClassificacao As System.Windows.Forms.GroupBox
    Public WithEvents chkAtivas As System.Windows.Forms.CheckBox
    Public WithEvents chkFiltroDesativadas As System.Windows.Forms.CheckBox
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents cboOpcoes As System.Windows.Forms.ComboBox
    Public WithEvents txtProduto As System.Windows.Forms.TextBox
    Public WithEvents _lblCampos_10 As System.Windows.Forms.Label
    Public WithEvents _lblCampos_9 As System.Windows.Forms.Label
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents _optRelatorio_1 As System.Windows.Forms.RadioButton
    Public WithEvents _optRelatorio_0 As System.Windows.Forms.RadioButton
    Public WithEvents fraRelatorio As System.Windows.Forms.GroupBox
    Public WithEvents chkTela As System.Windows.Forms.CheckBox
    Public WithEvents chkRelatorio As System.Windows.Forms.CheckBox
    Public WithEvents _cmdFiltroFechar_1 As System.Windows.Forms.Button
    Public WithEvents _cmdFiltroFechar_0 As System.Windows.Forms.Button
    Public WithEvents cmdFiltroExecutar As System.Windows.Forms.Button
    Public WithEvents cmdFiltroLimpar As System.Windows.Forms.Button
    Public WithEvents _lblCampos_42 As System.Windows.Forms.Label
    Public WithEvents _lblCampos_7 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtFiltroSequencia As System.Windows.Forms.TextBox
    Public WithEvents txtFiltroContrato As System.Windows.Forms.TextBox
    Public WithEvents txtFiltroLegenda As System.Windows.Forms.TextBox
    Public WithEvents _lblCampos_3 As System.Windows.Forms.Label
    Public WithEvents _lblCampos_4 As System.Windows.Forms.Label
    Public WithEvents _lblCampos_2 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents chkFiltroMidia As System.Windows.Forms.CheckBox
    Public WithEvents txtFiltroNumeroFitaInicio As System.Windows.Forms.TextBox
    Public WithEvents chkFiltroPendentes As System.Windows.Forms.CheckBox
    Public WithEvents chkFiltroAvulsas As System.Windows.Forms.CheckBox
    Public WithEvents chkFiltroArtisticas As System.Windows.Forms.CheckBox
    Public WithEvents txtFiltroNumeroFitaFim As System.Windows.Forms.TextBox
    Public WithEvents _lblCampos_12 As System.Windows.Forms.Label
    Public WithEvents lblFiltroNumeroFitaFim As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents lblFiltro As System.Windows.Forms.Label
    Public WithEvents picFiltro As System.Windows.Forms.Panel
    Public WithEvents flxFita As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents lblTotal As System.Windows.Forms.Label
    Public WithEvents cmdFiltroFechar As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents optClassificacao As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Public WithEvents optRelatorio As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControleFita_Afiliada))
        Me.cmdDesmarcarTodos = New System.Windows.Forms.Button
        Me.cmdMarcarTodos = New System.Windows.Forms.Button
        Me.picDesativado = New System.Windows.Forms.PictureBox
        Me.txtLinha1 = New System.Windows.Forms.TextBox
        Me.txtLinha2 = New System.Windows.Forms.TextBox
        Me.txtTotalFitas = New System.Windows.Forms.TextBox
        Me.picFiltro = New System.Windows.Forms.Panel
        Me.fraClassificacao = New System.Windows.Forms.GroupBox
        Me._optClassificacao_0 = New System.Windows.Forms.RadioButton
        Me._optClassificacao_1 = New System.Windows.Forms.RadioButton
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.chkAtivas = New System.Windows.Forms.CheckBox
        Me.chkFiltroDesativadas = New System.Windows.Forms.CheckBox
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.cboOpcoes = New System.Windows.Forms.ComboBox
        Me.txtProduto = New System.Windows.Forms.TextBox
        Me._lblCampos_10 = New System.Windows.Forms.Label
        Me._lblCampos_9 = New System.Windows.Forms.Label
        Me.fraRelatorio = New System.Windows.Forms.GroupBox
        Me._optRelatorio_1 = New System.Windows.Forms.RadioButton
        Me._optRelatorio_0 = New System.Windows.Forms.RadioButton
        Me.chkTela = New System.Windows.Forms.CheckBox
        Me.chkRelatorio = New System.Windows.Forms.CheckBox
        Me._cmdFiltroFechar_1 = New System.Windows.Forms.Button
        Me._cmdFiltroFechar_0 = New System.Windows.Forms.Button
        Me.cmdFiltroExecutar = New System.Windows.Forms.Button
        Me.cmdFiltroLimpar = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.ucPrograma = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.ucDataFim = New WCL_SCTV.UC.UCData
        Me.ucDataInicio = New WCL_SCTV.UC.UCData
        Me._lblCampos_42 = New System.Windows.Forms.Label
        Me._lblCampos_7 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.ucCliente = New WUC.UcText
        Me.ucAgencia = New WUC.UcText
        Me.ucTipoComercial = New WUC.UcText
        Me.ucEmpresa = New WUC.UcText
        Me.txtFiltroSequencia = New System.Windows.Forms.TextBox
        Me.txtFiltroContrato = New System.Windows.Forms.TextBox
        Me.txtFiltroLegenda = New System.Windows.Forms.TextBox
        Me._lblCampos_3 = New System.Windows.Forms.Label
        Me._lblCampos_4 = New System.Windows.Forms.Label
        Me._lblCampos_2 = New System.Windows.Forms.Label
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.chkFiltroMidia = New System.Windows.Forms.CheckBox
        Me.txtFiltroNumeroFitaInicio = New System.Windows.Forms.TextBox
        Me.chkFiltroPendentes = New System.Windows.Forms.CheckBox
        Me.chkFiltroAvulsas = New System.Windows.Forms.CheckBox
        Me.chkFiltroArtisticas = New System.Windows.Forms.CheckBox
        Me.txtFiltroNumeroFitaFim = New System.Windows.Forms.TextBox
        Me._lblCampos_12 = New System.Windows.Forms.Label
        Me.lblFiltroNumeroFitaFim = New System.Windows.Forms.Label
        Me.lblFiltro = New System.Windows.Forms.Label
        Me.flxFita = New AxMSFlexGridLib.AxMSFlexGrid
        Me.lblTotal = New System.Windows.Forms.Label
        Me.cmdFiltroFechar = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.optClassificacao = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.optRelatorio = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.tbOpcoes = New System.Windows.Forms.ToolStrip
        Me._tbOpções_Button1 = New System.Windows.Forms.ToolStripButton
        Me.tbFiltrar = New System.Windows.Forms.ToolStripButton
        Me._tbOpções_Button3 = New System.Windows.Forms.ToolStripDropDownButton
        Me._tbOpções_Button3_ButtonMenu1 = New System.Windows.Forms.ToolStripMenuItem
        Me._tbOpções_Button3_ButtonMenu2 = New System.Windows.Forms.ToolStripMenuItem
        Me.tbNovo = New System.Windows.Forms.ToolStripDropDownButton
        Me.tbAvulso = New System.Windows.Forms.ToolStripMenuItem
        Me.tbArtistico = New System.Windows.Forms.ToolStripMenuItem
        Me.tbAlterar = New System.Windows.Forms.ToolStripButton
        Me.tbExcluir = New System.Windows.Forms.ToolStripButton
        Me.tbDesativar = New System.Windows.Forms.ToolStripButton
        Me.tbNumerar = New System.Windows.Forms.ToolStripButton
        Me.tbDados = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tbSair = New System.Windows.Forms.ToolStripButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.picDesativado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picFiltro.SuspendLayout()
        Me.fraClassificacao.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.fraRelatorio.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.flxFita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFiltroFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optClassificacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOpcoes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDesmarcarTodos
        '
        Me.cmdDesmarcarTodos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDesmarcarTodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDesmarcarTodos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDesmarcarTodos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDesmarcarTodos.Location = New System.Drawing.Point(136, 509)
        Me.cmdDesmarcarTodos.Name = "cmdDesmarcarTodos"
        Me.cmdDesmarcarTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDesmarcarTodos.Size = New System.Drawing.Size(139, 33)
        Me.cmdDesmarcarTodos.TabIndex = 0
        Me.cmdDesmarcarTodos.Text = "&Desmarcar Todos"
        Me.cmdDesmarcarTodos.UseVisualStyleBackColor = False
        '
        'cmdMarcarTodos
        '
        Me.cmdMarcarTodos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMarcarTodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMarcarTodos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMarcarTodos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMarcarTodos.Location = New System.Drawing.Point(9, 509)
        Me.cmdMarcarTodos.Name = "cmdMarcarTodos"
        Me.cmdMarcarTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMarcarTodos.Size = New System.Drawing.Size(121, 33)
        Me.cmdMarcarTodos.TabIndex = 0
        Me.cmdMarcarTodos.Text = "&Marcar Todos"
        Me.cmdMarcarTodos.UseVisualStyleBackColor = False
        '
        'picDesativado
        '
        Me.picDesativado.BackColor = System.Drawing.SystemColors.Control
        Me.picDesativado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDesativado.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDesativado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picDesativado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picDesativado.Location = New System.Drawing.Point(521, 525)
        Me.picDesativado.Name = "picDesativado"
        Me.picDesativado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picDesativado.Size = New System.Drawing.Size(19, 16)
        Me.picDesativado.TabIndex = 54
        Me.picDesativado.TabStop = False
        Me.picDesativado.Visible = False
        '
        'txtLinha1
        '
        Me.txtLinha1.AcceptsReturn = True
        Me.txtLinha1.BackColor = System.Drawing.SystemColors.Window
        Me.txtLinha1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLinha1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinha1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLinha1.Location = New System.Drawing.Point(602, 528)
        Me.txtLinha1.MaxLength = 0
        Me.txtLinha1.Name = "txtLinha1"
        Me.txtLinha1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLinha1.Size = New System.Drawing.Size(34, 20)
        Me.txtLinha1.TabIndex = 0
        Me.txtLinha1.Text = "1"
        Me.txtLinha1.Visible = False
        '
        'txtLinha2
        '
        Me.txtLinha2.AcceptsReturn = True
        Me.txtLinha2.BackColor = System.Drawing.SystemColors.Window
        Me.txtLinha2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLinha2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinha2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLinha2.Location = New System.Drawing.Point(642, 528)
        Me.txtLinha2.MaxLength = 0
        Me.txtLinha2.Name = "txtLinha2"
        Me.txtLinha2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLinha2.Size = New System.Drawing.Size(34, 20)
        Me.txtLinha2.TabIndex = 0
        Me.txtLinha2.Text = "1"
        Me.txtLinha2.Visible = False
        '
        'txtTotalFitas
        '
        Me.txtTotalFitas.AcceptsReturn = True
        Me.txtTotalFitas.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalFitas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalFitas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFitas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalFitas.Location = New System.Drawing.Point(861, 522)
        Me.txtTotalFitas.MaxLength = 0
        Me.txtTotalFitas.Name = "txtTotalFitas"
        Me.txtTotalFitas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalFitas.Size = New System.Drawing.Size(74, 20)
        Me.txtTotalFitas.TabIndex = 0
        Me.txtTotalFitas.Text = "Text1"
        '
        'picFiltro
        '
        Me.picFiltro.BackColor = System.Drawing.SystemColors.Control
        Me.picFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFiltro.Controls.Add(Me.fraClassificacao)
        Me.picFiltro.Controls.Add(Me.Frame5)
        Me.picFiltro.Controls.Add(Me.Frame4)
        Me.picFiltro.Controls.Add(Me.fraRelatorio)
        Me.picFiltro.Controls.Add(Me.chkTela)
        Me.picFiltro.Controls.Add(Me.chkRelatorio)
        Me.picFiltro.Controls.Add(Me._cmdFiltroFechar_1)
        Me.picFiltro.Controls.Add(Me._cmdFiltroFechar_0)
        Me.picFiltro.Controls.Add(Me.cmdFiltroExecutar)
        Me.picFiltro.Controls.Add(Me.cmdFiltroLimpar)
        Me.picFiltro.Controls.Add(Me.Frame1)
        Me.picFiltro.Controls.Add(Me.Frame2)
        Me.picFiltro.Controls.Add(Me.Frame3)
        Me.picFiltro.Controls.Add(Me.lblFiltro)
        Me.picFiltro.Cursor = System.Windows.Forms.Cursors.Default
        Me.picFiltro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picFiltro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picFiltro.Location = New System.Drawing.Point(82, 68)
        Me.picFiltro.Name = "picFiltro"
        Me.picFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picFiltro.Size = New System.Drawing.Size(791, 407)
        Me.picFiltro.TabIndex = 0
        Me.picFiltro.TabStop = True
        '
        'fraClassificacao
        '
        Me.fraClassificacao.BackColor = System.Drawing.SystemColors.Control
        Me.fraClassificacao.Controls.Add(Me._optClassificacao_0)
        Me.fraClassificacao.Controls.Add(Me._optClassificacao_1)
        Me.fraClassificacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraClassificacao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraClassificacao.Location = New System.Drawing.Point(411, 331)
        Me.fraClassificacao.Name = "fraClassificacao"
        Me.fraClassificacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraClassificacao.Size = New System.Drawing.Size(117, 60)
        Me.fraClassificacao.TabIndex = 0
        Me.fraClassificacao.TabStop = False
        Me.fraClassificacao.Text = "Classificação"
        '
        '_optClassificacao_0
        '
        Me._optClassificacao_0.AutoSize = True
        Me._optClassificacao_0.BackColor = System.Drawing.SystemColors.Control
        Me._optClassificacao_0.Checked = True
        Me._optClassificacao_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optClassificacao_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optClassificacao_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optClassificacao.SetIndex(Me._optClassificacao_0, CType(0, Short))
        Me._optClassificacao_0.Location = New System.Drawing.Point(12, 17)
        Me._optClassificacao_0.Name = "_optClassificacao_0"
        Me._optClassificacao_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optClassificacao_0.Size = New System.Drawing.Size(42, 18)
        Me._optClassificacao_0.TabIndex = 27
        Me._optClassificacao_0.TabStop = True
        Me._optClassificacao_0.Text = "Fita"
        Me._optClassificacao_0.UseVisualStyleBackColor = False
        '
        '_optClassificacao_1
        '
        Me._optClassificacao_1.AutoSize = True
        Me._optClassificacao_1.BackColor = System.Drawing.SystemColors.Control
        Me._optClassificacao_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optClassificacao_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optClassificacao_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optClassificacao.SetIndex(Me._optClassificacao_1, CType(1, Short))
        Me._optClassificacao_1.Location = New System.Drawing.Point(12, 36)
        Me._optClassificacao_1.Name = "_optClassificacao_1"
        Me._optClassificacao_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optClassificacao_1.Size = New System.Drawing.Size(50, 18)
        Me._optClassificacao_1.TabIndex = 28
        Me._optClassificacao_1.TabStop = True
        Me._optClassificacao_1.Text = "Título"
        Me._optClassificacao_1.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.chkAtivas)
        Me.Frame5.Controls.Add(Me.chkFiltroDesativadas)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(15, 283)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(217, 108)
        Me.Frame5.TabIndex = 2
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Status"
        '
        'chkAtivas
        '
        Me.chkAtivas.BackColor = System.Drawing.SystemColors.Control
        Me.chkAtivas.Checked = True
        Me.chkAtivas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAtivas.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAtivas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAtivas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAtivas.Location = New System.Drawing.Point(12, 68)
        Me.chkAtivas.Name = "chkAtivas"
        Me.chkAtivas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAtivas.Size = New System.Drawing.Size(191, 15)
        Me.chkAtivas.TabIndex = 1
        Me.chkAtivas.Text = "Ativas"
        Me.chkAtivas.UseVisualStyleBackColor = False
        '
        'chkFiltroDesativadas
        '
        Me.chkFiltroDesativadas.BackColor = System.Drawing.SystemColors.Control
        Me.chkFiltroDesativadas.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFiltroDesativadas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltroDesativadas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFiltroDesativadas.Location = New System.Drawing.Point(12, 23)
        Me.chkFiltroDesativadas.Name = "chkFiltroDesativadas"
        Me.chkFiltroDesativadas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFiltroDesativadas.Size = New System.Drawing.Size(191, 15)
        Me.chkFiltroDesativadas.TabIndex = 0
        Me.chkFiltroDesativadas.Text = "Desativadas/Devolvidas"
        Me.chkFiltroDesativadas.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cboOpcoes)
        Me.Frame4.Controls.Add(Me.txtProduto)
        Me.Frame4.Controls.Add(Me._lblCampos_10)
        Me.Frame4.Controls.Add(Me._lblCampos_9)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(411, 252)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(362, 73)
        Me.Frame4.TabIndex = 4
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Produto"
        '
        'cboOpcoes
        '
        Me.cboOpcoes.BackColor = System.Drawing.SystemColors.Window
        Me.cboOpcoes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpcoes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpcoes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboOpcoes.Items.AddRange(New Object() {"Qualquer Parte do Campo", "Inicio do Campo", "Fim do Campo", "Campo Inteiro"})
        Me.cboOpcoes.Location = New System.Drawing.Point(57, 42)
        Me.cboOpcoes.Name = "cboOpcoes"
        Me.cboOpcoes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboOpcoes.Size = New System.Drawing.Size(275, 22)
        Me.cboOpcoes.TabIndex = 1
        '
        'txtProduto
        '
        Me.txtProduto.AcceptsReturn = True
        Me.txtProduto.BackColor = System.Drawing.SystemColors.Window
        Me.txtProduto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProduto.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProduto.Location = New System.Drawing.Point(56, 18)
        Me.txtProduto.MaxLength = 30
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProduto.Size = New System.Drawing.Size(277, 20)
        Me.txtProduto.TabIndex = 0
        '
        '_lblCampos_10
        '
        Me._lblCampos_10.AutoSize = True
        Me._lblCampos_10.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_10.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_10, CType(10, Short))
        Me._lblCampos_10.Location = New System.Drawing.Point(6, 46)
        Me._lblCampos_10.Name = "_lblCampos_10"
        Me._lblCampos_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_10.Size = New System.Drawing.Size(45, 14)
        Me._lblCampos_10.TabIndex = 0
        Me._lblCampos_10.Text = "Opções"
        '
        '_lblCampos_9
        '
        Me._lblCampos_9.AutoSize = True
        Me._lblCampos_9.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_9.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_9, CType(9, Short))
        Me._lblCampos_9.Location = New System.Drawing.Point(12, 21)
        Me._lblCampos_9.Name = "_lblCampos_9"
        Me._lblCampos_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_9.Size = New System.Drawing.Size(34, 14)
        Me._lblCampos_9.TabIndex = 0
        Me._lblCampos_9.Text = "Nome"
        '
        'fraRelatorio
        '
        Me.fraRelatorio.BackColor = System.Drawing.SystemColors.Control
        Me.fraRelatorio.Controls.Add(Me._optRelatorio_1)
        Me.fraRelatorio.Controls.Add(Me._optRelatorio_0)
        Me.fraRelatorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraRelatorio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraRelatorio.Location = New System.Drawing.Point(243, 308)
        Me.fraRelatorio.Name = "fraRelatorio"
        Me.fraRelatorio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraRelatorio.Size = New System.Drawing.Size(153, 83)
        Me.fraRelatorio.TabIndex = 0
        Me.fraRelatorio.TabStop = False
        Me.fraRelatorio.Text = "Tipo de Relatório"
        '
        '_optRelatorio_1
        '
        Me._optRelatorio_1.AutoSize = True
        Me._optRelatorio_1.BackColor = System.Drawing.SystemColors.Control
        Me._optRelatorio_1.Checked = True
        Me._optRelatorio_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optRelatorio_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optRelatorio_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optRelatorio.SetIndex(Me._optRelatorio_1, CType(1, Short))
        Me._optRelatorio_1.Location = New System.Drawing.Point(8, 45)
        Me._optRelatorio_1.Name = "_optRelatorio_1"
        Me._optRelatorio_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optRelatorio_1.Size = New System.Drawing.Size(73, 18)
        Me._optRelatorio_1.TabIndex = 25
        Me._optRelatorio_1.TabStop = True
        Me._optRelatorio_1.Text = "Detalhado"
        Me._optRelatorio_1.UseVisualStyleBackColor = False
        '
        '_optRelatorio_0
        '
        Me._optRelatorio_0.AutoSize = True
        Me._optRelatorio_0.BackColor = System.Drawing.SystemColors.Control
        Me._optRelatorio_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optRelatorio_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optRelatorio_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optRelatorio.SetIndex(Me._optRelatorio_0, CType(0, Short))
        Me._optRelatorio_0.Location = New System.Drawing.Point(6, 21)
        Me._optRelatorio_0.Name = "_optRelatorio_0"
        Me._optRelatorio_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optRelatorio_0.Size = New System.Drawing.Size(72, 18)
        Me._optRelatorio_0.TabIndex = 24
        Me._optRelatorio_0.TabStop = True
        Me._optRelatorio_0.Text = "Resumido"
        Me._optRelatorio_0.UseVisualStyleBackColor = False
        '
        'chkTela
        '
        Me.chkTela.BackColor = System.Drawing.SystemColors.Control
        Me.chkTela.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTela.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTela.Location = New System.Drawing.Point(311, 283)
        Me.chkTela.Name = "chkTela"
        Me.chkTela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTela.Size = New System.Drawing.Size(85, 19)
        Me.chkTela.TabIndex = 23
        Me.chkTela.Text = "Tela"
        Me.chkTela.UseVisualStyleBackColor = False
        Me.chkTela.Visible = False
        '
        'chkRelatorio
        '
        Me.chkRelatorio.BackColor = System.Drawing.SystemColors.Control
        Me.chkRelatorio.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRelatorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRelatorio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRelatorio.Location = New System.Drawing.Point(243, 283)
        Me.chkRelatorio.Name = "chkRelatorio"
        Me.chkRelatorio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRelatorio.Size = New System.Drawing.Size(85, 19)
        Me.chkRelatorio.TabIndex = 22
        Me.chkRelatorio.Text = "Relatório"
        Me.chkRelatorio.UseVisualStyleBackColor = False
        Me.chkRelatorio.Visible = False
        '
        '_cmdFiltroFechar_1
        '
        Me._cmdFiltroFechar_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdFiltroFechar_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdFiltroFechar_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdFiltroFechar_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFiltroFechar.SetIndex(Me._cmdFiltroFechar_1, CType(1, Short))
        Me._cmdFiltroFechar_1.Location = New System.Drawing.Point(763, -1)
        Me._cmdFiltroFechar_1.Name = "_cmdFiltroFechar_1"
        Me._cmdFiltroFechar_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdFiltroFechar_1.Size = New System.Drawing.Size(22, 21)
        Me._cmdFiltroFechar_1.TabIndex = 0
        Me._cmdFiltroFechar_1.Text = "X"
        Me._cmdFiltroFechar_1.UseVisualStyleBackColor = False
        '
        '_cmdFiltroFechar_0
        '
        Me._cmdFiltroFechar_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdFiltroFechar_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdFiltroFechar_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdFiltroFechar_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFiltroFechar.SetIndex(Me._cmdFiltroFechar_0, CType(0, Short))
        Me._cmdFiltroFechar_0.Location = New System.Drawing.Point(709, 351)
        Me._cmdFiltroFechar_0.Name = "_cmdFiltroFechar_0"
        Me._cmdFiltroFechar_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdFiltroFechar_0.Size = New System.Drawing.Size(76, 39)
        Me._cmdFiltroFechar_0.TabIndex = 31
        Me._cmdFiltroFechar_0.Text = "&Fechar"
        Me._cmdFiltroFechar_0.UseVisualStyleBackColor = False
        '
        'cmdFiltroExecutar
        '
        Me.cmdFiltroExecutar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltroExecutar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFiltroExecutar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltroExecutar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFiltroExecutar.Location = New System.Drawing.Point(633, 351)
        Me.cmdFiltroExecutar.Name = "cmdFiltroExecutar"
        Me.cmdFiltroExecutar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFiltroExecutar.Size = New System.Drawing.Size(70, 39)
        Me.cmdFiltroExecutar.TabIndex = 30
        Me.cmdFiltroExecutar.Text = "&Ok"
        Me.cmdFiltroExecutar.UseVisualStyleBackColor = False
        '
        'cmdFiltroLimpar
        '
        Me.cmdFiltroLimpar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltroLimpar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFiltroLimpar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltroLimpar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFiltroLimpar.Location = New System.Drawing.Point(536, 351)
        Me.cmdFiltroLimpar.Name = "cmdFiltroLimpar"
        Me.cmdFiltroLimpar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFiltroLimpar.Size = New System.Drawing.Size(91, 39)
        Me.cmdFiltroLimpar.TabIndex = 29
        Me.cmdFiltroLimpar.Text = "&Limpar Opções"
        Me.cmdFiltroLimpar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.ucPrograma)
        Me.Frame1.Controls.Add(Me.ucVeiculo)
        Me.Frame1.Controls.Add(Me.ucDataFim)
        Me.Frame1.Controls.Add(Me.ucDataInicio)
        Me.Frame1.Controls.Add(Me._lblCampos_42)
        Me.Frame1.Controls.Add(Me._lblCampos_7)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 28)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(380, 120)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Programação"
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(6, 80)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Grade
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(364, 25)
        Me.ucPrograma.sqlQuery = "execute PrNet_Programa_Grade '','0001-01-01','0001-01-01',NULL"
        Me.ucPrograma.TabIndex = 4
        Me.ucPrograma.TextBoxLeft = CType(0, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(11, 18)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(359, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 1
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'ucDataFim
        '
        Me.ucDataFim.BackColor = System.Drawing.Color.Transparent
        Me.ucDataFim.DateTime = New Date(CType(0, Long))
        Me.ucDataFim.Formato = "dd/MM/yyyy ddd"
        Me.ucDataFim.Hoje = False
        Me.ucDataFim.Location = New System.Drawing.Point(235, 49)
        Me.ucDataFim.MaximumSize = New System.Drawing.Size(500, 25)
        Me.ucDataFim.MinimumSize = New System.Drawing.Size(115, 25)
        Me.ucDataFim.Name = "ucDataFim"
        Me.ucDataFim.Permite_Futuro = True
        Me.ucDataFim.Permite_Limpar = True
        Me.ucDataFim.Permite_Passado = True
        Me.ucDataFim.Preenchimento_Obrigatorio = False
        Me.ucDataFim.Size = New System.Drawing.Size(135, 25)
        Me.ucDataFim.TabIndex = 3
        '
        'ucDataInicio
        '
        Me.ucDataInicio.BackColor = System.Drawing.Color.Transparent
        Me.ucDataInicio.DateTime = New Date(CType(0, Long))
        Me.ucDataInicio.Formato = "dd/MM/yyyy ddd"
        Me.ucDataInicio.Hoje = False
        Me.ucDataInicio.Location = New System.Drawing.Point(60, 49)
        Me.ucDataInicio.MaximumSize = New System.Drawing.Size(500, 25)
        Me.ucDataInicio.MinimumSize = New System.Drawing.Size(115, 25)
        Me.ucDataInicio.Name = "ucDataInicio"
        Me.ucDataInicio.Permite_Futuro = True
        Me.ucDataInicio.Permite_Limpar = True
        Me.ucDataInicio.Permite_Passado = True
        Me.ucDataInicio.Preenchimento_Obrigatorio = False
        Me.ucDataInicio.Size = New System.Drawing.Size(136, 25)
        Me.ucDataInicio.TabIndex = 2
        '
        '_lblCampos_42
        '
        Me._lblCampos_42.AutoSize = True
        Me._lblCampos_42.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_42.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_42, CType(42, Short))
        Me._lblCampos_42.Location = New System.Drawing.Point(11, 54)
        Me._lblCampos_42.Name = "_lblCampos_42"
        Me._lblCampos_42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_42.Size = New System.Drawing.Size(31, 14)
        Me._lblCampos_42.TabIndex = 0
        Me._lblCampos_42.Text = "Início"
        '
        '_lblCampos_7
        '
        Me._lblCampos_7.AutoSize = True
        Me._lblCampos_7.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_7.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_7, CType(7, Short))
        Me._lblCampos_7.Location = New System.Drawing.Point(202, 54)
        Me._lblCampos_7.Name = "_lblCampos_7"
        Me._lblCampos_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_7.Size = New System.Drawing.Size(23, 14)
        Me._lblCampos_7.TabIndex = 0
        Me._lblCampos_7.Text = "Fim"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.ucCliente)
        Me.Frame2.Controls.Add(Me.ucAgencia)
        Me.Frame2.Controls.Add(Me.ucTipoComercial)
        Me.Frame2.Controls.Add(Me.ucEmpresa)
        Me.Frame2.Controls.Add(Me.txtFiltroSequencia)
        Me.Frame2.Controls.Add(Me.txtFiltroContrato)
        Me.Frame2.Controls.Add(Me.txtFiltroLegenda)
        Me.Frame2.Controls.Add(Me._lblCampos_3)
        Me.Frame2.Controls.Add(Me._lblCampos_4)
        Me.Frame2.Controls.Add(Me._lblCampos_2)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(402, 28)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(383, 212)
        Me.Frame2.TabIndex = 3
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Outros Filtros"
        '
        'ucCliente
        '
        Me.ucCliente.BackColor = System.Drawing.SystemColors.Control
        Me.ucCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCliente.Caption = "Cliente"
        Me.ucCliente.DataTextValue = Nothing
        Me.ucCliente.Location = New System.Drawing.Point(13, 167)
        Me.ucCliente.MaxLength = 6
        Me.ucCliente.Name = "ucCliente"
        Me.ucCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCliente.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCliente.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucCliente.pDecimal = CType(0, Byte)
        Me.ucCliente.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.ucCliente.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCliente.showButton = True
        Me.ucCliente.ShowDescricao = True
        Me.ucCliente.Size = New System.Drawing.Size(361, 25)
        Me.ucCliente.TabIndex = 6
        Me.ucCliente.TextBoxLeft = CType(0, Short)
        Me.ucCliente.TextWidth = 0
        '
        'ucAgencia
        '
        Me.ucAgencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucAgencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucAgencia.Caption = "Agência"
        Me.ucAgencia.DataTextValue = Nothing
        Me.ucAgencia.Location = New System.Drawing.Point(9, 129)
        Me.ucAgencia.MaxLength = 6
        Me.ucAgencia.Name = "ucAgencia"
        Me.ucAgencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucAgencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucAgencia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucAgencia.pDecimal = CType(0, Byte)
        Me.ucAgencia.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.ucAgencia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucAgencia.showButton = True
        Me.ucAgencia.ShowDescricao = True
        Me.ucAgencia.Size = New System.Drawing.Size(361, 25)
        Me.ucAgencia.TabIndex = 5
        Me.ucAgencia.TextBoxLeft = CType(0, Short)
        Me.ucAgencia.TextWidth = 0
        '
        'ucTipoComercial
        '
        Me.ucTipoComercial.BackColor = System.Drawing.SystemColors.Control
        Me.ucTipoComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucTipoComercial.Caption = "Tp Comercial"
        Me.ucTipoComercial.DataTextValue = Nothing
        Me.ucTipoComercial.Location = New System.Drawing.Point(6, 91)
        Me.ucTipoComercial.MaxLength = 2
        Me.ucTipoComercial.Name = "ucTipoComercial"
        Me.ucTipoComercial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucTipoComercial.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucTipoComercial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucTipoComercial.pDecimal = CType(0, Byte)
        Me.ucTipoComercial.pDicionario = WUC.clsDicionario.enuDicionario.Tipo_Comercial
        Me.ucTipoComercial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucTipoComercial.showButton = True
        Me.ucTipoComercial.ShowDescricao = True
        Me.ucTipoComercial.Size = New System.Drawing.Size(361, 25)
        Me.ucTipoComercial.sqlQuery = "Execute prNet_Tipo_Comercial_L"
        Me.ucTipoComercial.TabIndex = 4
        Me.ucTipoComercial.TextBoxLeft = CType(0, Short)
        Me.ucTipoComercial.TextWidth = 0
        '
        'ucEmpresa
        '
        Me.ucEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.ucEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucEmpresa.Caption = "Empresa"
        Me.ucEmpresa.DataTextValue = Nothing
        Me.ucEmpresa.Location = New System.Drawing.Point(13, 20)
        Me.ucEmpresa.MaxLength = 3
        Me.ucEmpresa.Name = "ucEmpresa"
        Me.ucEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucEmpresa.pDecimal = CType(0, Byte)
        Me.ucEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.ucEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucEmpresa.showButton = True
        Me.ucEmpresa.ShowDescricao = True
        Me.ucEmpresa.Size = New System.Drawing.Size(361, 25)
        Me.ucEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.ucEmpresa.TabIndex = 0
        Me.ucEmpresa.TextBoxLeft = CType(0, Short)
        Me.ucEmpresa.TextWidth = 0
        '
        'txtFiltroSequencia
        '
        Me.txtFiltroSequencia.AcceptsReturn = True
        Me.txtFiltroSequencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtFiltroSequencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFiltroSequencia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroSequencia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFiltroSequencia.Location = New System.Drawing.Point(197, 60)
        Me.txtFiltroSequencia.MaxLength = 0
        Me.txtFiltroSequencia.Name = "txtFiltroSequencia"
        Me.txtFiltroSequencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFiltroSequencia.Size = New System.Drawing.Size(33, 20)
        Me.txtFiltroSequencia.TabIndex = 2
        Me.txtFiltroSequencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFiltroContrato
        '
        Me.txtFiltroContrato.AcceptsReturn = True
        Me.txtFiltroContrato.BackColor = System.Drawing.SystemColors.Window
        Me.txtFiltroContrato.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFiltroContrato.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroContrato.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFiltroContrato.Location = New System.Drawing.Point(69, 60)
        Me.txtFiltroContrato.MaxLength = 0
        Me.txtFiltroContrato.Name = "txtFiltroContrato"
        Me.txtFiltroContrato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFiltroContrato.Size = New System.Drawing.Size(87, 20)
        Me.txtFiltroContrato.TabIndex = 1
        Me.txtFiltroContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFiltroLegenda
        '
        Me.txtFiltroLegenda.AcceptsReturn = True
        Me.txtFiltroLegenda.BackColor = System.Drawing.SystemColors.Window
        Me.txtFiltroLegenda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFiltroLegenda.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroLegenda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFiltroLegenda.Location = New System.Drawing.Point(326, 60)
        Me.txtFiltroLegenda.MaxLength = 2
        Me.txtFiltroLegenda.Name = "txtFiltroLegenda"
        Me.txtFiltroLegenda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFiltroLegenda.Size = New System.Drawing.Size(48, 20)
        Me.txtFiltroLegenda.TabIndex = 3
        Me.txtFiltroLegenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lblCampos_3
        '
        Me._lblCampos_3.AutoSize = True
        Me._lblCampos_3.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_3.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_3, CType(3, Short))
        Me._lblCampos_3.Location = New System.Drawing.Point(162, 63)
        Me._lblCampos_3.Name = "_lblCampos_3"
        Me._lblCampos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_3.Size = New System.Drawing.Size(29, 14)
        Me._lblCampos_3.TabIndex = 0
        Me._lblCampos_3.Text = "Seq."
        '
        '_lblCampos_4
        '
        Me._lblCampos_4.AutoSize = True
        Me._lblCampos_4.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_4.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_4, CType(4, Short))
        Me._lblCampos_4.Location = New System.Drawing.Point(276, 63)
        Me._lblCampos_4.Name = "_lblCampos_4"
        Me._lblCampos_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_4.Size = New System.Drawing.Size(49, 14)
        Me._lblCampos_4.TabIndex = 0
        Me._lblCampos_4.Text = "Legenda"
        '
        '_lblCampos_2
        '
        Me._lblCampos_2.AutoSize = True
        Me._lblCampos_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_2.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_2, CType(2, Short))
        Me._lblCampos_2.Location = New System.Drawing.Point(15, 63)
        Me._lblCampos_2.Name = "_lblCampos_2"
        Me._lblCampos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_2.Size = New System.Drawing.Size(48, 14)
        Me._lblCampos_2.TabIndex = 0
        Me._lblCampos_2.Text = "Contrato"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.chkFiltroMidia)
        Me.Frame3.Controls.Add(Me.txtFiltroNumeroFitaInicio)
        Me.Frame3.Controls.Add(Me.chkFiltroPendentes)
        Me.Frame3.Controls.Add(Me.chkFiltroAvulsas)
        Me.Frame3.Controls.Add(Me.chkFiltroArtisticas)
        Me.Frame3.Controls.Add(Me.txtFiltroNumeroFitaFim)
        Me.Frame3.Controls.Add(Me._lblCampos_12)
        Me.Frame3.Controls.Add(Me.lblFiltroNumeroFitaFim)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(15, 154)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(381, 123)
        Me.Frame3.TabIndex = 1
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Material"
        '
        'chkFiltroMidia
        '
        Me.chkFiltroMidia.BackColor = System.Drawing.SystemColors.Control
        Me.chkFiltroMidia.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFiltroMidia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltroMidia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFiltroMidia.Location = New System.Drawing.Point(12, 90)
        Me.chkFiltroMidia.Name = "chkFiltroMidia"
        Me.chkFiltroMidia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFiltroMidia.Size = New System.Drawing.Size(191, 15)
        Me.chkFiltroMidia.TabIndex = 3
        Me.chkFiltroMidia.Text = "Mostrar Numeradas"
        Me.chkFiltroMidia.UseVisualStyleBackColor = False
        '
        'txtFiltroNumeroFitaInicio
        '
        Me.txtFiltroNumeroFitaInicio.AcceptsReturn = True
        Me.txtFiltroNumeroFitaInicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtFiltroNumeroFitaInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFiltroNumeroFitaInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroNumeroFitaInicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFiltroNumeroFitaInicio.Location = New System.Drawing.Point(104, 17)
        Me.txtFiltroNumeroFitaInicio.MaxLength = 6
        Me.txtFiltroNumeroFitaInicio.Name = "txtFiltroNumeroFitaInicio"
        Me.txtFiltroNumeroFitaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFiltroNumeroFitaInicio.Size = New System.Drawing.Size(93, 20)
        Me.txtFiltroNumeroFitaInicio.TabIndex = 0
        Me.txtFiltroNumeroFitaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkFiltroPendentes
        '
        Me.chkFiltroPendentes.BackColor = System.Drawing.SystemColors.Control
        Me.chkFiltroPendentes.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFiltroPendentes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltroPendentes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFiltroPendentes.Location = New System.Drawing.Point(12, 71)
        Me.chkFiltroPendentes.Name = "chkFiltroPendentes"
        Me.chkFiltroPendentes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFiltroPendentes.Size = New System.Drawing.Size(191, 15)
        Me.chkFiltroPendentes.TabIndex = 2
        Me.chkFiltroPendentes.Text = "Mostrar Pendentes de Numeração"
        Me.chkFiltroPendentes.UseVisualStyleBackColor = False
        '
        'chkFiltroAvulsas
        '
        Me.chkFiltroAvulsas.BackColor = System.Drawing.SystemColors.Control
        Me.chkFiltroAvulsas.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFiltroAvulsas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltroAvulsas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFiltroAvulsas.Location = New System.Drawing.Point(212, 71)
        Me.chkFiltroAvulsas.Name = "chkFiltroAvulsas"
        Me.chkFiltroAvulsas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFiltroAvulsas.Size = New System.Drawing.Size(159, 15)
        Me.chkFiltroAvulsas.TabIndex = 4
        Me.chkFiltroAvulsas.Text = "Mostrar Fitas Avulsas"
        Me.chkFiltroAvulsas.UseVisualStyleBackColor = False
        '
        'chkFiltroArtisticas
        '
        Me.chkFiltroArtisticas.BackColor = System.Drawing.SystemColors.Control
        Me.chkFiltroArtisticas.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFiltroArtisticas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltroArtisticas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFiltroArtisticas.Location = New System.Drawing.Point(212, 90)
        Me.chkFiltroArtisticas.Name = "chkFiltroArtisticas"
        Me.chkFiltroArtisticas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFiltroArtisticas.Size = New System.Drawing.Size(159, 15)
        Me.chkFiltroArtisticas.TabIndex = 5
        Me.chkFiltroArtisticas.Text = "Mostrar Fitas Artisticas"
        Me.chkFiltroArtisticas.UseVisualStyleBackColor = False
        '
        'txtFiltroNumeroFitaFim
        '
        Me.txtFiltroNumeroFitaFim.AcceptsReturn = True
        Me.txtFiltroNumeroFitaFim.BackColor = System.Drawing.SystemColors.Window
        Me.txtFiltroNumeroFitaFim.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFiltroNumeroFitaFim.Enabled = False
        Me.txtFiltroNumeroFitaFim.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroNumeroFitaFim.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFiltroNumeroFitaFim.Location = New System.Drawing.Point(272, 17)
        Me.txtFiltroNumeroFitaFim.MaxLength = 10
        Me.txtFiltroNumeroFitaFim.Name = "txtFiltroNumeroFitaFim"
        Me.txtFiltroNumeroFitaFim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFiltroNumeroFitaFim.Size = New System.Drawing.Size(93, 20)
        Me.txtFiltroNumeroFitaFim.TabIndex = 1
        Me.txtFiltroNumeroFitaFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lblCampos_12
        '
        Me._lblCampos_12.AutoSize = True
        Me._lblCampos_12.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_12.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_12, CType(12, Short))
        Me._lblCampos_12.Location = New System.Drawing.Point(10, 20)
        Me._lblCampos_12.Name = "_lblCampos_12"
        Me._lblCampos_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_12.Size = New System.Drawing.Size(82, 14)
        Me._lblCampos_12.TabIndex = 0
        Me._lblCampos_12.Text = "Número Fita de:"
        '
        'lblFiltroNumeroFitaFim
        '
        Me.lblFiltroNumeroFitaFim.AutoSize = True
        Me.lblFiltroNumeroFitaFim.BackColor = System.Drawing.SystemColors.Control
        Me.lblFiltroNumeroFitaFim.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFiltroNumeroFitaFim.Enabled = False
        Me.lblFiltroNumeroFitaFim.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroNumeroFitaFim.ForeColor = System.Drawing.Color.Black
        Me.lblFiltroNumeroFitaFim.Location = New System.Drawing.Point(241, 20)
        Me.lblFiltroNumeroFitaFim.Name = "lblFiltroNumeroFitaFim"
        Me.lblFiltroNumeroFitaFim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFiltroNumeroFitaFim.Size = New System.Drawing.Size(25, 14)
        Me.lblFiltroNumeroFitaFim.TabIndex = 0
        Me.lblFiltroNumeroFitaFim.Text = "até:"
        '
        'lblFiltro
        '
        Me.lblFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiltro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.ForeColor = System.Drawing.Color.White
        Me.lblFiltro.Location = New System.Drawing.Point(-1, 0)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFiltro.Size = New System.Drawing.Size(863, 23)
        Me.lblFiltro.TabIndex = 0
        Me.lblFiltro.Text = "  Opções de Filtro"
        '
        'flxFita
        '
        Me.flxFita.Location = New System.Drawing.Point(12, 68)
        Me.flxFita.Name = "flxFita"
        Me.flxFita.OcxState = CType(resources.GetObject("flxFita.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxFita.Size = New System.Drawing.Size(923, 435)
        Me.flxFita.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(711, 528)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(139, 14)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total de Fitas Selecionadas"
        '
        'cmdFiltroFechar
        '
        '
        'tbOpcoes
        '
        Me.tbOpcoes.CanOverflow = False
        Me.tbOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._tbOpções_Button1, Me.tbFiltrar, Me._tbOpções_Button3, Me.tbNovo, Me.tbAlterar, Me.tbExcluir, Me.tbDesativar, Me.tbNumerar, Me.tbDados, Me.ToolStripSeparator7, Me.tbSair})
        Me.tbOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.tbOpcoes.Name = "tbOpcoes"
        Me.tbOpcoes.Size = New System.Drawing.Size(947, 63)
        Me.tbOpcoes.TabIndex = 0
        '
        '_tbOpções_Button1
        '
        Me._tbOpções_Button1.AutoSize = False
        Me._tbOpções_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._tbOpções_Button1.Name = "_tbOpções_Button1"
        Me._tbOpções_Button1.Size = New System.Drawing.Size(0, 39)
        Me._tbOpções_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._tbOpções_Button1.ToolTipText = "Filtrar"
        '
        'tbFiltrar
        '
        Me.tbFiltrar.AutoSize = False
        Me.tbFiltrar.BackColor = System.Drawing.SystemColors.Control
        Me.tbFiltrar.Image = Global.SCTVNET.My.Resources.Resources.Binocolo
        Me.tbFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbFiltrar.Name = "tbFiltrar"
        Me.tbFiltrar.Size = New System.Drawing.Size(60, 60)
        Me.tbFiltrar.Text = "Filtrar"
        Me.tbFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbFiltrar.ToolTipText = "Permite filtrar as Fitas para consulta"
        '
        '_tbOpções_Button3
        '
        Me._tbOpções_Button3.AutoSize = False
        Me._tbOpções_Button3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._tbOpções_Button3_ButtonMenu1, Me._tbOpções_Button3_ButtonMenu2})
        Me._tbOpções_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._tbOpções_Button3.Name = "_tbOpções_Button3"
        Me._tbOpções_Button3.Size = New System.Drawing.Size(0, 39)
        Me._tbOpções_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._tbOpções_Button3.ToolTipText = "Novo"
        '
        '_tbOpções_Button3_ButtonMenu1
        '
        Me._tbOpções_Button3_ButtonMenu1.Name = "_tbOpções_Button3_ButtonMenu1"
        Me._tbOpções_Button3_ButtonMenu1.Size = New System.Drawing.Size(124, 22)
        Me._tbOpções_Button3_ButtonMenu1.Text = "Avulso"
        '
        '_tbOpções_Button3_ButtonMenu2
        '
        Me._tbOpções_Button3_ButtonMenu2.Name = "_tbOpções_Button3_ButtonMenu2"
        Me._tbOpções_Button3_ButtonMenu2.Size = New System.Drawing.Size(124, 22)
        Me._tbOpções_Button3_ButtonMenu2.Text = "Artístico"
        '
        'tbNovo
        '
        Me.tbNovo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbAvulso, Me.tbArtistico})
        Me.tbNovo.Image = Global.SCTVNET.My.Resources.Resources.Novo
        Me.tbNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbNovo.Name = "tbNovo"
        Me.tbNovo.Size = New System.Drawing.Size(45, 60)
        Me.tbNovo.Text = "Novo"
        Me.tbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbNovo.ToolTipText = "Adicionar fitas Artisticas ou Avulsas"
        '
        'tbAvulso
        '
        Me.tbAvulso.Name = "tbAvulso"
        Me.tbAvulso.Size = New System.Drawing.Size(124, 22)
        Me.tbAvulso.Text = "Avulso"
        '
        'tbArtistico
        '
        Me.tbArtistico.Name = "tbArtistico"
        Me.tbArtistico.Size = New System.Drawing.Size(124, 22)
        Me.tbArtistico.Text = "Artistico"
        '
        'tbAlterar
        '
        Me.tbAlterar.AutoSize = False
        Me.tbAlterar.Image = CType(resources.GetObject("tbAlterar.Image"), System.Drawing.Image)
        Me.tbAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbAlterar.Name = "tbAlterar"
        Me.tbAlterar.Size = New System.Drawing.Size(60, 60)
        Me.tbAlterar.Text = "Alterar"
        Me.tbAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbAlterar.ToolTipText = "Alterar dados da fita"
        '
        'tbExcluir
        '
        Me.tbExcluir.AutoSize = False
        Me.tbExcluir.Image = Global.SCTVNET.My.Resources.Resources.Lixeira
        Me.tbExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tbExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbExcluir.Name = "tbExcluir"
        Me.tbExcluir.Size = New System.Drawing.Size(60, 60)
        Me.tbExcluir.Text = "Excluir"
        Me.tbExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbExcluir.ToolTipText = "Excluir fitas marcadas"
        '
        'tbDesativar
        '
        Me.tbDesativar.AutoSize = False
        Me.tbDesativar.Image = Global.SCTVNET.My.Resources.Resources.cancelar2
        Me.tbDesativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbDesativar.Name = "tbDesativar"
        Me.tbDesativar.Size = New System.Drawing.Size(60, 60)
        Me.tbDesativar.Text = "Desativar"
        Me.tbDesativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbDesativar.ToolTipText = "Ativar/Desativar Fitas"
        '
        'tbNumerar
        '
        Me.tbNumerar.AutoSize = False
        Me.tbNumerar.Image = Global.SCTVNET.My.Resources.Resources.NUMERACAO_FITA
        Me.tbNumerar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbNumerar.Name = "tbNumerar"
        Me.tbNumerar.Size = New System.Drawing.Size(60, 60)
        Me.tbNumerar.Text = "Numerar"
        Me.tbNumerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbNumerar.ToolTipText = "Numerar Fitas de Mídias"
        '
        'tbDados
        '
        Me.tbDados.AutoSize = False
        Me.tbDados.Image = Global.SCTVNET.My.Resources.Resources.LUPA2
        Me.tbDados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbDados.Name = "tbDados"
        Me.tbDados.Size = New System.Drawing.Size(60, 60)
        Me.tbDados.Text = "Dados"
        Me.tbDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbDados.ToolTipText = "Dados complementares da fita"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 63)
        '
        'tbSair
        '
        Me.tbSair.AutoSize = False
        Me.tbSair.Image = Global.SCTVNET.My.Resources.Resources.Sair
        Me.tbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbSair.Name = "tbSair"
        Me.tbSair.Size = New System.Drawing.Size(60, 60)
        Me.tbSair.Text = "Sair"
        Me.tbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbSair.ToolTipText = "Sair"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PictureBox1.Location = New System.Drawing.Point(416, 528)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureBox1.Size = New System.Drawing.Size(14, 13)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PictureBox2.Location = New System.Drawing.Point(449, 529)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureBox2.Size = New System.Drawing.Size(14, 13)
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'frmControleFita_Afiliada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(947, 558)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picFiltro)
        Me.Controls.Add(Me.tbOpcoes)
        Me.Controls.Add(Me.cmdDesmarcarTodos)
        Me.Controls.Add(Me.cmdMarcarTodos)
        Me.Controls.Add(Me.picDesativado)
        Me.Controls.Add(Me.txtLinha1)
        Me.Controls.Add(Me.txtLinha2)
        Me.Controls.Add(Me.txtTotalFitas)
        Me.Controls.Add(Me.flxFita)
        Me.Controls.Add(Me.lblTotal)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(57, 140)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControleFita_Afiliada"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Controle de Fitas"
        CType(Me.picDesativado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picFiltro.ResumeLayout(False)
        Me.fraClassificacao.ResumeLayout(False)
        Me.fraClassificacao.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.fraRelatorio.ResumeLayout(False)
        Me.fraRelatorio.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.flxFita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFiltroFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optClassificacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optRelatorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOpcoes.ResumeLayout(False)
        Me.tbOpcoes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucDataFim As WCL_SCTV.UC.UCData
    Friend WithEvents ucDataInicio As WCL_SCTV.UC.UCData
    Public WithEvents tbOpcoes As System.Windows.Forms.ToolStrip
    Public WithEvents _tbOpções_Button3 As System.Windows.Forms.ToolStripDropDownButton
    Public WithEvents _tbOpções_Button3_ButtonMenu1 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents _tbOpções_Button3_ButtonMenu2 As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents tbAlterar As System.Windows.Forms.ToolStripButton
    Public WithEvents tbExcluir As System.Windows.Forms.ToolStripButton
    Public WithEvents tbDesativar As System.Windows.Forms.ToolStripButton
    Public WithEvents tbNumerar As System.Windows.Forms.ToolStripButton
    Public WithEvents tbDados As System.Windows.Forms.ToolStripButton
    Public WithEvents tbSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbNovo As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tbAvulso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbArtistico As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents tbFiltrar As System.Windows.Forms.ToolStripButton
    Public WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents _tbOpções_Button1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents ucEmpresa As WUC.UcText
    Friend WithEvents ucCliente As WUC.UcText
    Friend WithEvents ucAgencia As WUC.UcText
    Friend WithEvents ucTipoComercial As WUC.UcText
#End Region
End Class