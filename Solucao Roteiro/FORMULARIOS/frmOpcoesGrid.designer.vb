<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOpcoesGrid
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
    Public WithEvents txtColunaAtual As System.Windows.Forms.TextBox
	Public WithEvents txtLocalizar As System.Windows.Forms.TextBox
	Public WithEvents cboColuna As System.Windows.Forms.ComboBox
	Public WithEvents optLocalizarFiltrar As System.Windows.Forms.RadioButton
	Public WithEvents optApenasLocalizar As System.Windows.Forms.RadioButton
	Public WithEvents _cmdCancela_0 As System.Windows.Forms.Button
	Public WithEvents cmdOkLocalizar As System.Windows.Forms.Button
	Public WithEvents cboTipoBusca As System.Windows.Forms.ComboBox
	Public WithEvents _lblCampos_0 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_1 As System.Windows.Forms.Label
	Public WithEvents lblTituloColuna As System.Windows.Forms.Label
	Public WithEvents fraLocalizar As System.Windows.Forms.GroupBox
    Public WithEvents lstImpressaoColunas As System.Windows.Forms.CheckedListBox
    Public WithEvents cmdOk As System.Windows.Forms.Button
    Public WithEvents _cmdCancela_3 As System.Windows.Forms.Button
    Public WithEvents cmdConfigurarRelatorio As System.Windows.Forms.Button
    Public WithEvents cmdImpressora As System.Windows.Forms.Button
    Public WithEvents lblSelecao As System.Windows.Forms.Label
    Public WithEvents fraImpressao As System.Windows.Forms.GroupBox
    Public WithEvents cmdOkExportar As System.Windows.Forms.Button
    Public WithEvents _cmdCancela_2 As System.Windows.Forms.Button
    Public WithEvents cmdSalvar As System.Windows.Forms.Button
    Public WithEvents cboFormato As System.Windows.Forms.ComboBox
    Public WithEvents txtNomeArquivo As System.Windows.Forms.TextBox
    Public WithEvents _lblCampos_3 As System.Windows.Forms.Label
    Public WithEvents _lblCampos_2 As System.Windows.Forms.Label
    Public WithEvents fraExportar As System.Windows.Forms.GroupBox
    Public WithEvents optDescendente As System.Windows.Forms.RadioButton
    Public WithEvents optAscendente As System.Windows.Forms.RadioButton
    Public WithEvents lstClassificacao As System.Windows.Forms.ListBox
    Public WithEvents cmdOkClassificacao As System.Windows.Forms.Button
    Public WithEvents _cmdCancela_1 As System.Windows.Forms.Button
    Public WithEvents fraClassificacao As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancela As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcoesGrid))
        Me.txtColunaAtual = New System.Windows.Forms.TextBox
        Me.fraLocalizar = New System.Windows.Forms.GroupBox
        Me.txtLocalizar = New System.Windows.Forms.TextBox
        Me.cboColuna = New System.Windows.Forms.ComboBox
        Me.optLocalizarFiltrar = New System.Windows.Forms.RadioButton
        Me.optApenasLocalizar = New System.Windows.Forms.RadioButton
        Me._cmdCancela_0 = New System.Windows.Forms.Button
        Me.cmdOkLocalizar = New System.Windows.Forms.Button
        Me.cboTipoBusca = New System.Windows.Forms.ComboBox
        Me._lblCampos_0 = New System.Windows.Forms.Label
        Me._lblCampos_1 = New System.Windows.Forms.Label
        Me.lblTituloColuna = New System.Windows.Forms.Label
        Me.fraImpressao = New System.Windows.Forms.GroupBox
        Me.optVisualizar = New System.Windows.Forms.RadioButton
        Me.optImpressora = New System.Windows.Forms.RadioButton
        Me.chkImprimirData = New System.Windows.Forms.CheckBox
        Me.chkNumeroPagina = New System.Windows.Forms.CheckBox
        Me.lstImpressaoColunas = New System.Windows.Forms.CheckedListBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me._cmdCancela_3 = New System.Windows.Forms.Button
        Me.cmdConfigurarRelatorio = New System.Windows.Forms.Button
        Me.cmdImpressora = New System.Windows.Forms.Button
        Me.lblSelecao = New System.Windows.Forms.Label
        Me.fraExportar = New System.Windows.Forms.GroupBox
        Me.cmdOkExportar = New System.Windows.Forms.Button
        Me._cmdCancela_2 = New System.Windows.Forms.Button
        Me.cmdSalvar = New System.Windows.Forms.Button
        Me.cboFormato = New System.Windows.Forms.ComboBox
        Me.txtNomeArquivo = New System.Windows.Forms.TextBox
        Me._lblCampos_3 = New System.Windows.Forms.Label
        Me._lblCampos_2 = New System.Windows.Forms.Label
        Me.fraClassificacao = New System.Windows.Forms.GroupBox
        Me.optDescendente = New System.Windows.Forms.RadioButton
        Me.optAscendente = New System.Windows.Forms.RadioButton
        Me.lstClassificacao = New System.Windows.Forms.ListBox
        Me.cmdOkClassificacao = New System.Windows.Forms.Button
        Me._cmdCancela_1 = New System.Windows.Forms.Button
        Me.cmdCancela = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.chkLocalizar = New System.Windows.Forms.CheckBox
        Me.chkClassificar = New System.Windows.Forms.CheckBox
        Me.chkImprimir = New System.Windows.Forms.CheckBox
        Me.chkExportar = New System.Windows.Forms.CheckBox
        Me.printDoc = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog
        Me.fraLocalizar.SuspendLayout()
        Me.fraImpressao.SuspendLayout()
        Me.fraExportar.SuspendLayout()
        Me.fraClassificacao.SuspendLayout()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtColunaAtual
        '
        Me.txtColunaAtual.AcceptsReturn = True
        Me.txtColunaAtual.BackColor = System.Drawing.SystemColors.Window
        Me.txtColunaAtual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtColunaAtual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColunaAtual.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtColunaAtual.Location = New System.Drawing.Point(12, 104)
        Me.txtColunaAtual.MaxLength = 0
        Me.txtColunaAtual.Name = "txtColunaAtual"
        Me.txtColunaAtual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtColunaAtual.Size = New System.Drawing.Size(64, 20)
        Me.txtColunaAtual.TabIndex = 54
        Me.txtColunaAtual.Visible = False
        '
        'fraLocalizar
        '
        Me.fraLocalizar.BackColor = System.Drawing.SystemColors.Control
        Me.fraLocalizar.Controls.Add(Me.txtLocalizar)
        Me.fraLocalizar.Controls.Add(Me.cboColuna)
        Me.fraLocalizar.Controls.Add(Me.optLocalizarFiltrar)
        Me.fraLocalizar.Controls.Add(Me.optApenasLocalizar)
        Me.fraLocalizar.Controls.Add(Me._cmdCancela_0)
        Me.fraLocalizar.Controls.Add(Me.cmdOkLocalizar)
        Me.fraLocalizar.Controls.Add(Me.cboTipoBusca)
        Me.fraLocalizar.Controls.Add(Me._lblCampos_0)
        Me.fraLocalizar.Controls.Add(Me._lblCampos_1)
        Me.fraLocalizar.Controls.Add(Me.lblTituloColuna)
        Me.fraLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraLocalizar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraLocalizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraLocalizar.Location = New System.Drawing.Point(230, 352)
        Me.fraLocalizar.Name = "fraLocalizar"
        Me.fraLocalizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraLocalizar.Size = New System.Drawing.Size(204, 11)
        Me.fraLocalizar.TabIndex = 2
        Me.fraLocalizar.TabStop = False
        Me.fraLocalizar.Text = "Localizar"
        Me.fraLocalizar.Visible = False
        '
        'txtLocalizar
        '
        Me.txtLocalizar.AcceptsReturn = True
        Me.txtLocalizar.BackColor = System.Drawing.SystemColors.Window
        Me.txtLocalizar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocalizar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalizar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocalizar.Location = New System.Drawing.Point(117, 53)
        Me.txtLocalizar.MaxLength = 0
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLocalizar.Size = New System.Drawing.Size(241, 20)
        Me.txtLocalizar.TabIndex = 6
        '
        'cboColuna
        '
        Me.cboColuna.BackColor = System.Drawing.SystemColors.Window
        Me.cboColuna.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColuna.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColuna.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboColuna.Location = New System.Drawing.Point(117, 21)
        Me.cboColuna.Name = "cboColuna"
        Me.cboColuna.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboColuna.Size = New System.Drawing.Size(244, 22)
        Me.cboColuna.TabIndex = 5
        '
        'optLocalizarFiltrar
        '
        Me.optLocalizarFiltrar.AutoSize = True
        Me.optLocalizarFiltrar.BackColor = System.Drawing.SystemColors.Control
        Me.optLocalizarFiltrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.optLocalizarFiltrar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLocalizarFiltrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optLocalizarFiltrar.Location = New System.Drawing.Point(12, 168)
        Me.optLocalizarFiltrar.Name = "optLocalizarFiltrar"
        Me.optLocalizarFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optLocalizarFiltrar.Size = New System.Drawing.Size(108, 18)
        Me.optLocalizarFiltrar.TabIndex = 12
        Me.optLocalizarFiltrar.TabStop = True
        Me.optLocalizarFiltrar.Text = "Localizar e Filtrar"
        Me.optLocalizarFiltrar.UseVisualStyleBackColor = False
        '
        'optApenasLocalizar
        '
        Me.optApenasLocalizar.AutoSize = True
        Me.optApenasLocalizar.BackColor = System.Drawing.SystemColors.Control
        Me.optApenasLocalizar.Checked = True
        Me.optApenasLocalizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.optApenasLocalizar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optApenasLocalizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optApenasLocalizar.Location = New System.Drawing.Point(12, 144)
        Me.optApenasLocalizar.Name = "optApenasLocalizar"
        Me.optApenasLocalizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optApenasLocalizar.Size = New System.Drawing.Size(110, 18)
        Me.optApenasLocalizar.TabIndex = 10
        Me.optApenasLocalizar.TabStop = True
        Me.optApenasLocalizar.Text = "Apenas Localizar"
        Me.optApenasLocalizar.UseVisualStyleBackColor = False
        '
        '_cmdCancela_0
        '
        Me._cmdCancela_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_0, CType(0, Short))
        Me._cmdCancela_0.Location = New System.Drawing.Point(303, 153)
        Me._cmdCancela_0.Name = "_cmdCancela_0"
        Me._cmdCancela_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_0.Size = New System.Drawing.Size(58, 28)
        Me._cmdCancela_0.TabIndex = 1
        Me._cmdCancela_0.Text = "&Cancela"
        Me._cmdCancela_0.UseVisualStyleBackColor = False
        '
        'cmdOkLocalizar
        '
        Me.cmdOkLocalizar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOkLocalizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOkLocalizar.Enabled = False
        Me.cmdOkLocalizar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkLocalizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOkLocalizar.Location = New System.Drawing.Point(225, 153)
        Me.cmdOkLocalizar.Name = "cmdOkLocalizar"
        Me.cmdOkLocalizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOkLocalizar.Size = New System.Drawing.Size(58, 28)
        Me.cmdOkLocalizar.TabIndex = 0
        Me.cmdOkLocalizar.Text = "&Ok"
        Me.cmdOkLocalizar.UseVisualStyleBackColor = False
        '
        'cboTipoBusca
        '
        Me.cboTipoBusca.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoBusca.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoBusca.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoBusca.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTipoBusca.Items.AddRange(New Object() {"Inicio do Campo", "Qualquer Parte do Campo", "Campo Inteiro"})
        Me.cboTipoBusca.Location = New System.Drawing.Point(117, 81)
        Me.cboTipoBusca.Name = "cboTipoBusca"
        Me.cboTipoBusca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTipoBusca.Size = New System.Drawing.Size(244, 22)
        Me.cboTipoBusca.TabIndex = 8
        '
        '_lblCampos_0
        '
        Me._lblCampos_0.AutoSize = True
        Me._lblCampos_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCampos.SetIndex(Me._lblCampos_0, CType(0, Short))
        Me._lblCampos_0.Location = New System.Drawing.Point(12, 25)
        Me._lblCampos_0.Name = "_lblCampos_0"
        Me._lblCampos_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_0.Size = New System.Drawing.Size(100, 14)
        Me._lblCampos_0.TabIndex = 7
        Me._lblCampos_0.Text = "Procurar na Coluna"
        '
        '_lblCampos_1
        '
        Me._lblCampos_1.AutoSize = True
        Me._lblCampos_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCampos.SetIndex(Me._lblCampos_1, CType(1, Short))
        Me._lblCampos_1.Location = New System.Drawing.Point(12, 85)
        Me._lblCampos_1.Name = "_lblCampos_1"
        Me._lblCampos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_1.Size = New System.Drawing.Size(72, 14)
        Me._lblCampos_1.TabIndex = 4
        Me._lblCampos_1.Text = "Pesquisar em"
        '
        'lblTituloColuna
        '
        Me.lblTituloColuna.AutoSize = True
        Me.lblTituloColuna.BackColor = System.Drawing.SystemColors.Control
        Me.lblTituloColuna.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTituloColuna.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloColuna.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTituloColuna.Location = New System.Drawing.Point(12, 56)
        Me.lblTituloColuna.Name = "lblTituloColuna"
        Me.lblTituloColuna.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTituloColuna.Size = New System.Drawing.Size(76, 14)
        Me.lblTituloColuna.TabIndex = 3
        Me.lblTituloColuna.Text = "Pelo Conteudo"
        '
        'fraImpressao
        '
        Me.fraImpressao.BackColor = System.Drawing.SystemColors.Control
        Me.fraImpressao.Controls.Add(Me.optVisualizar)
        Me.fraImpressao.Controls.Add(Me.optImpressora)
        Me.fraImpressao.Controls.Add(Me.chkImprimirData)
        Me.fraImpressao.Controls.Add(Me.chkNumeroPagina)
        Me.fraImpressao.Controls.Add(Me.lstImpressaoColunas)
        Me.fraImpressao.Controls.Add(Me.cmdOk)
        Me.fraImpressao.Controls.Add(Me._cmdCancela_3)
        Me.fraImpressao.Controls.Add(Me.cmdConfigurarRelatorio)
        Me.fraImpressao.Controls.Add(Me.cmdImpressora)
        Me.fraImpressao.Controls.Add(Me.lblSelecao)
        Me.fraImpressao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraImpressao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraImpressao.Location = New System.Drawing.Point(10, 3)
        Me.fraImpressao.Name = "fraImpressao"
        Me.fraImpressao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraImpressao.Size = New System.Drawing.Size(430, 338)
        Me.fraImpressao.TabIndex = 31
        Me.fraImpressao.TabStop = False
        Me.fraImpressao.Text = "Imprimir"
        Me.fraImpressao.Visible = False
        '
        'optVisualizar
        '
        Me.optVisualizar.AutoSize = True
        Me.optVisualizar.Checked = True
        Me.optVisualizar.Location = New System.Drawing.Point(38, 228)
        Me.optVisualizar.Name = "optVisualizar"
        Me.optVisualizar.Size = New System.Drawing.Size(73, 18)
        Me.optVisualizar.TabIndex = 52
        Me.optVisualizar.TabStop = True
        Me.optVisualizar.Text = "Visualisar"
        Me.optVisualizar.UseVisualStyleBackColor = True
        '
        'optImpressora
        '
        Me.optImpressora.AutoSize = True
        Me.optImpressora.Location = New System.Drawing.Point(38, 195)
        Me.optImpressora.Name = "optImpressora"
        Me.optImpressora.Size = New System.Drawing.Size(61, 18)
        Me.optImpressora.TabIndex = 51
        Me.optImpressora.Text = "Imprimir"
        Me.optImpressora.UseVisualStyleBackColor = True
        '
        'chkImprimirData
        '
        Me.chkImprimirData.AutoSize = True
        Me.chkImprimirData.BackColor = System.Drawing.SystemColors.Control
        Me.chkImprimirData.Checked = True
        Me.chkImprimirData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImprimirData.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkImprimirData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImprimirData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkImprimirData.Location = New System.Drawing.Point(8, 316)
        Me.chkImprimirData.Name = "chkImprimirData"
        Me.chkImprimirData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkImprimirData.Size = New System.Drawing.Size(145, 18)
        Me.chkImprimirData.TabIndex = 50
        Me.chkImprimirData.Text = "Imprimir Data de Emissão"
        Me.chkImprimirData.UseVisualStyleBackColor = False
        '
        'chkNumeroPagina
        '
        Me.chkNumeroPagina.AutoSize = True
        Me.chkNumeroPagina.BackColor = System.Drawing.SystemColors.Control
        Me.chkNumeroPagina.Checked = True
        Me.chkNumeroPagina.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNumeroPagina.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNumeroPagina.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNumeroPagina.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNumeroPagina.Location = New System.Drawing.Point(8, 288)
        Me.chkNumeroPagina.Name = "chkNumeroPagina"
        Me.chkNumeroPagina.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNumeroPagina.Size = New System.Drawing.Size(152, 18)
        Me.chkNumeroPagina.TabIndex = 49
        Me.chkNumeroPagina.Text = "Imprimir Numero da Página"
        Me.chkNumeroPagina.UseVisualStyleBackColor = False
        '
        'lstImpressaoColunas
        '
        Me.lstImpressaoColunas.BackColor = System.Drawing.SystemColors.Window
        Me.lstImpressaoColunas.CheckOnClick = True
        Me.lstImpressaoColunas.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstImpressaoColunas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstImpressaoColunas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstImpressaoColunas.Location = New System.Drawing.Point(164, 30)
        Me.lstImpressaoColunas.Name = "lstImpressaoColunas"
        Me.lstImpressaoColunas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstImpressaoColunas.Size = New System.Drawing.Size(260, 259)
        Me.lstImpressaoColunas.TabIndex = 37
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(260, 300)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(79, 32)
        Me.cmdOk.TabIndex = 36
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        '_cmdCancela_3
        '
        Me._cmdCancela_3.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_3, CType(3, Short))
        Me._cmdCancela_3.Location = New System.Drawing.Point(345, 300)
        Me._cmdCancela_3.Name = "_cmdCancela_3"
        Me._cmdCancela_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_3.Size = New System.Drawing.Size(79, 32)
        Me._cmdCancela_3.TabIndex = 35
        Me._cmdCancela_3.Text = "&Cancela"
        Me._cmdCancela_3.UseVisualStyleBackColor = False
        '
        'cmdConfigurarRelatorio
        '
        Me.cmdConfigurarRelatorio.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConfigurarRelatorio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConfigurarRelatorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfigurarRelatorio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConfigurarRelatorio.Image = CType(resources.GetObject("cmdConfigurarRelatorio.Image"), System.Drawing.Image)
        Me.cmdConfigurarRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdConfigurarRelatorio.Location = New System.Drawing.Point(15, 115)
        Me.cmdConfigurarRelatorio.Name = "cmdConfigurarRelatorio"
        Me.cmdConfigurarRelatorio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConfigurarRelatorio.Size = New System.Drawing.Size(127, 60)
        Me.cmdConfigurarRelatorio.TabIndex = 34
        Me.cmdConfigurarRelatorio.Text = "Configurar Papel"
        Me.cmdConfigurarRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdConfigurarRelatorio.UseVisualStyleBackColor = False
        '
        'cmdImpressora
        '
        Me.cmdImpressora.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImpressora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdImpressora.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImpressora.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImpressora.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImpressora.Image = CType(resources.GetObject("cmdImpressora.Image"), System.Drawing.Image)
        Me.cmdImpressora.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdImpressora.Location = New System.Drawing.Point(15, 30)
        Me.cmdImpressora.Name = "cmdImpressora"
        Me.cmdImpressora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImpressora.Size = New System.Drawing.Size(127, 79)
        Me.cmdImpressora.TabIndex = 32
        Me.cmdImpressora.Text = "Configurar Impressora"
        Me.cmdImpressora.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdImpressora.UseVisualStyleBackColor = False
        '
        'lblSelecao
        '
        Me.lblSelecao.AutoSize = True
        Me.lblSelecao.BackColor = System.Drawing.SystemColors.Control
        Me.lblSelecao.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSelecao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelecao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSelecao.Location = New System.Drawing.Point(148, 12)
        Me.lblSelecao.Name = "lblSelecao"
        Me.lblSelecao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSelecao.Size = New System.Drawing.Size(100, 14)
        Me.lblSelecao.TabIndex = 38
        Me.lblSelecao.Text = "Selecionar Colunas"
        '
        'fraExportar
        '
        Me.fraExportar.BackColor = System.Drawing.SystemColors.Control
        Me.fraExportar.Controls.Add(Me.cmdOkExportar)
        Me.fraExportar.Controls.Add(Me._cmdCancela_2)
        Me.fraExportar.Controls.Add(Me.cmdSalvar)
        Me.fraExportar.Controls.Add(Me.cboFormato)
        Me.fraExportar.Controls.Add(Me.txtNomeArquivo)
        Me.fraExportar.Controls.Add(Me._lblCampos_3)
        Me.fraExportar.Controls.Add(Me._lblCampos_2)
        Me.fraExportar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraExportar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraExportar.Location = New System.Drawing.Point(231, 397)
        Me.fraExportar.Name = "fraExportar"
        Me.fraExportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraExportar.Size = New System.Drawing.Size(203, 17)
        Me.fraExportar.TabIndex = 22
        Me.fraExportar.TabStop = False
        Me.fraExportar.Text = "Exportar"
        Me.fraExportar.Visible = False
        '
        'cmdOkExportar
        '
        Me.cmdOkExportar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOkExportar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOkExportar.Enabled = False
        Me.cmdOkExportar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkExportar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOkExportar.Location = New System.Drawing.Point(198, 102)
        Me.cmdOkExportar.Name = "cmdOkExportar"
        Me.cmdOkExportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOkExportar.Size = New System.Drawing.Size(58, 28)
        Me.cmdOkExportar.TabIndex = 29
        Me.cmdOkExportar.Text = "&Ok"
        Me.cmdOkExportar.UseVisualStyleBackColor = False
        '
        '_cmdCancela_2
        '
        Me._cmdCancela_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_2, CType(2, Short))
        Me._cmdCancela_2.Location = New System.Drawing.Point(270, 102)
        Me._cmdCancela_2.Name = "_cmdCancela_2"
        Me._cmdCancela_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_2.Size = New System.Drawing.Size(58, 28)
        Me._cmdCancela_2.TabIndex = 28
        Me._cmdCancela_2.Text = "&Cancela"
        Me._cmdCancela_2.UseVisualStyleBackColor = False
        '
        'cmdSalvar
        '
        Me.cmdSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalvar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalvar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalvar.Location = New System.Drawing.Point(306, 33)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalvar.Size = New System.Drawing.Size(22, 19)
        Me.cmdSalvar.TabIndex = 27
        Me.cmdSalvar.Text = "..."
        Me.cmdSalvar.UseVisualStyleBackColor = False
        '
        'cboFormato
        '
        Me.cboFormato.BackColor = System.Drawing.SystemColors.Window
        Me.cboFormato.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormato.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboFormato.Items.AddRange(New Object() {"Arquivo Texto (.txt)", "Arquivo Delimitado (.Csv)"})
        Me.cboFormato.Location = New System.Drawing.Point(9, 72)
        Me.cboFormato.Name = "cboFormato"
        Me.cboFormato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboFormato.Size = New System.Drawing.Size(319, 22)
        Me.cboFormato.TabIndex = 26
        '
        'txtNomeArquivo
        '
        Me.txtNomeArquivo.AcceptsReturn = True
        Me.txtNomeArquivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomeArquivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomeArquivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeArquivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNomeArquivo.Location = New System.Drawing.Point(9, 33)
        Me.txtNomeArquivo.MaxLength = 0
        Me.txtNomeArquivo.Name = "txtNomeArquivo"
        Me.txtNomeArquivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNomeArquivo.Size = New System.Drawing.Size(292, 20)
        Me.txtNomeArquivo.TabIndex = 23
        '
        '_lblCampos_3
        '
        Me._lblCampos_3.AutoSize = True
        Me._lblCampos_3.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCampos.SetIndex(Me._lblCampos_3, CType(3, Short))
        Me._lblCampos_3.Location = New System.Drawing.Point(9, 57)
        Me._lblCampos_3.Name = "_lblCampos_3"
        Me._lblCampos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_3.Size = New System.Drawing.Size(95, 14)
        Me._lblCampos_3.TabIndex = 25
        Me._lblCampos_3.Text = "Salvar no Formato"
        Me._lblCampos_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblCampos_2
        '
        Me._lblCampos_2.AutoSize = True
        Me._lblCampos_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCampos.SetIndex(Me._lblCampos_2, CType(2, Short))
        Me._lblCampos_2.Location = New System.Drawing.Point(9, 18)
        Me._lblCampos_2.Name = "_lblCampos_2"
        Me._lblCampos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_2.Size = New System.Drawing.Size(112, 14)
        Me._lblCampos_2.TabIndex = 24
        Me._lblCampos_2.Text = "Enviar para o Arquivo"
        Me._lblCampos_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fraClassificacao
        '
        Me.fraClassificacao.BackColor = System.Drawing.SystemColors.Control
        Me.fraClassificacao.Controls.Add(Me.optDescendente)
        Me.fraClassificacao.Controls.Add(Me.optAscendente)
        Me.fraClassificacao.Controls.Add(Me.lstClassificacao)
        Me.fraClassificacao.Controls.Add(Me.cmdOkClassificacao)
        Me.fraClassificacao.Controls.Add(Me._cmdCancela_1)
        Me.fraClassificacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraClassificacao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraClassificacao.Location = New System.Drawing.Point(229, 371)
        Me.fraClassificacao.Name = "fraClassificacao"
        Me.fraClassificacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraClassificacao.Size = New System.Drawing.Size(204, 15)
        Me.fraClassificacao.TabIndex = 9
        Me.fraClassificacao.TabStop = False
        Me.fraClassificacao.Text = "Classificar pela Coluna"
        Me.fraClassificacao.Visible = False
        '
        'optDescendente
        '
        Me.optDescendente.BackColor = System.Drawing.SystemColors.Control
        Me.optDescendente.Cursor = System.Windows.Forms.Cursors.Default
        Me.optDescendente.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optDescendente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDescendente.Location = New System.Drawing.Point(237, 48)
        Me.optDescendente.Name = "optDescendente"
        Me.optDescendente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optDescendente.Size = New System.Drawing.Size(91, 16)
        Me.optDescendente.TabIndex = 16
        Me.optDescendente.TabStop = True
        Me.optDescendente.Text = "Descendente"
        Me.optDescendente.UseVisualStyleBackColor = False
        '
        'optAscendente
        '
        Me.optAscendente.BackColor = System.Drawing.SystemColors.Control
        Me.optAscendente.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAscendente.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAscendente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAscendente.Location = New System.Drawing.Point(237, 18)
        Me.optAscendente.Name = "optAscendente"
        Me.optAscendente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAscendente.Size = New System.Drawing.Size(91, 16)
        Me.optAscendente.TabIndex = 15
        Me.optAscendente.TabStop = True
        Me.optAscendente.Text = "Ascendente"
        Me.optAscendente.UseVisualStyleBackColor = False
        '
        'lstClassificacao
        '
        Me.lstClassificacao.BackColor = System.Drawing.SystemColors.Window
        Me.lstClassificacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstClassificacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstClassificacao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstClassificacao.ItemHeight = 14
        Me.lstClassificacao.Location = New System.Drawing.Point(15, 21)
        Me.lstClassificacao.Name = "lstClassificacao"
        Me.lstClassificacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstClassificacao.Size = New System.Drawing.Size(203, 158)
        Me.lstClassificacao.TabIndex = 14
        '
        'cmdOkClassificacao
        '
        Me.cmdOkClassificacao.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOkClassificacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOkClassificacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkClassificacao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOkClassificacao.Location = New System.Drawing.Point(240, 108)
        Me.cmdOkClassificacao.Name = "cmdOkClassificacao"
        Me.cmdOkClassificacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOkClassificacao.Size = New System.Drawing.Size(88, 28)
        Me.cmdOkClassificacao.TabIndex = 13
        Me.cmdOkClassificacao.Text = "&Ok"
        Me.cmdOkClassificacao.UseVisualStyleBackColor = False
        '
        '_cmdCancela_1
        '
        Me._cmdCancela_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_1, CType(1, Short))
        Me._cmdCancela_1.Location = New System.Drawing.Point(240, 153)
        Me._cmdCancela_1.Name = "_cmdCancela_1"
        Me._cmdCancela_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_1.Size = New System.Drawing.Size(88, 28)
        Me._cmdCancela_1.TabIndex = 11
        Me._cmdCancela_1.Text = "&Cancela"
        Me._cmdCancela_1.UseVisualStyleBackColor = False
        '
        'cmdCancela
        '
        '
        'chkLocalizar
        '
        Me.chkLocalizar.AutoSize = True
        Me.chkLocalizar.Location = New System.Drawing.Point(12, 78)
        Me.chkLocalizar.Name = "chkLocalizar"
        Me.chkLocalizar.Size = New System.Drawing.Size(105, 18)
        Me.chkLocalizar.TabIndex = 56
        Me.chkLocalizar.Text = "Opção Localizar"
        Me.chkLocalizar.UseVisualStyleBackColor = True
        Me.chkLocalizar.Visible = False
        '
        'chkClassificar
        '
        Me.chkClassificar.AutoSize = True
        Me.chkClassificar.Location = New System.Drawing.Point(12, 60)
        Me.chkClassificar.Name = "chkClassificar"
        Me.chkClassificar.Size = New System.Drawing.Size(112, 18)
        Me.chkClassificar.TabIndex = 57
        Me.chkClassificar.Text = "Opção Classificar"
        Me.chkClassificar.UseVisualStyleBackColor = True
        Me.chkClassificar.Visible = False
        '
        'chkImprimir
        '
        Me.chkImprimir.AutoSize = True
        Me.chkImprimir.Location = New System.Drawing.Point(12, 42)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(97, 18)
        Me.chkImprimir.TabIndex = 58
        Me.chkImprimir.Text = "Opção Imprimir"
        Me.chkImprimir.UseVisualStyleBackColor = True
        Me.chkImprimir.Visible = False
        '
        'chkExportar
        '
        Me.chkExportar.AutoSize = True
        Me.chkExportar.Location = New System.Drawing.Point(12, 24)
        Me.chkExportar.Name = "chkExportar"
        Me.chkExportar.Size = New System.Drawing.Size(102, 18)
        Me.chkExportar.TabIndex = 59
        Me.chkExportar.Text = "Opção Exportar"
        Me.chkExportar.UseVisualStyleBackColor = True
        Me.chkExportar.Visible = False
        '
        'printDoc
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'frmOpcoesGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(458, 353)
        Me.Controls.Add(Me.fraImpressao)
        Me.Controls.Add(Me.chkExportar)
        Me.Controls.Add(Me.chkImprimir)
        Me.Controls.Add(Me.chkClassificar)
        Me.Controls.Add(Me.chkLocalizar)
        Me.Controls.Add(Me.fraLocalizar)
        Me.Controls.Add(Me.fraExportar)
        Me.Controls.Add(Me.fraClassificacao)
        Me.Controls.Add(Me.txtColunaAtual)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(12, 8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcoesGrid"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.fraLocalizar.ResumeLayout(False)
        Me.fraLocalizar.PerformLayout()
        Me.fraImpressao.ResumeLayout(False)
        Me.fraImpressao.PerformLayout()
        Me.fraExportar.ResumeLayout(False)
        Me.fraExportar.PerformLayout()
        Me.fraClassificacao.ResumeLayout(False)
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkLocalizar As System.Windows.Forms.CheckBox
    Friend WithEvents chkClassificar As System.Windows.Forms.CheckBox
    Friend WithEvents chkImprimir As System.Windows.Forms.CheckBox
    Friend WithEvents chkExportar As System.Windows.Forms.CheckBox
    Friend WithEvents printDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog As System.Windows.Forms.PageSetupDialog
    Public WithEvents chkImprimirData As System.Windows.Forms.CheckBox
    Public WithEvents chkNumeroPagina As System.Windows.Forms.CheckBox
    Friend WithEvents optVisualizar As System.Windows.Forms.RadioButton
    Friend WithEvents optImpressora As System.Windows.Forms.RadioButton
#End Region
End Class