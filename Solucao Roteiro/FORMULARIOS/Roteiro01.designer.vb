<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRoteiro_Consulta
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
	Public WithEvents cmdExibir As System.Windows.Forms.Button
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents txtDescricaoQualidade As System.Windows.Forms.TextBox
	Public WithEvents txtProgramaTitulo As System.Windows.Forms.TextBox
	Public WithEvents txtVeiculoNome As System.Windows.Forms.TextBox
	Public WithEvents optSim As System.Windows.Forms.RadioButton
	Public WithEvents optnao As System.Windows.Forms.RadioButton
	Public WithEvents optTodos As System.Windows.Forms.RadioButton
	Public WithEvents Frame4 As System.Windows.Forms.Panel
	Public WithEvents chkNOrdenados As System.Windows.Forms.CheckBox
	Public WithEvents chkOrdenados As System.Windows.Forms.CheckBox
	Public WithEvents chkNBaixados As System.Windows.Forms.CheckBox
	Public WithEvents chkBaixados As System.Windows.Forms.CheckBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents flxConfirmacao As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents _lblCampos_2 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblNet As System.Windows.Forms.Label
	Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoteiro_Consulta))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdExibir = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.txtDescricaoQualidade = New System.Windows.Forms.TextBox
        Me.txtProgramaTitulo = New System.Windows.Forms.TextBox
        Me.txtVeiculoNome = New System.Windows.Forms.TextBox
        Me.Frame4 = New System.Windows.Forms.Panel
        Me.optSim = New System.Windows.Forms.RadioButton
        Me.optnao = New System.Windows.Forms.RadioButton
        Me.optTodos = New System.Windows.Forms.RadioButton
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.chkNOrdenados = New System.Windows.Forms.CheckBox
        Me.chkOrdenados = New System.Windows.Forms.CheckBox
        Me.chkNBaixados = New System.Windows.Forms.CheckBox
        Me.chkBaixados = New System.Windows.Forms.CheckBox
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.flxConfirmacao = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.ucVeiculo = New WUC.UcText
        Me.dteData = New WCL_SCTV.UC.UCData
        Me._lblCampos_2 = New System.Windows.Forms.Label
        Me.lblNet = New System.Windows.Forms.Label
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.ucPrograma = New WUC.UcText
        Me.ucQualidade = New WUC.UcText
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.flxConfirmacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExibir
        '
        Me.cmdExibir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExibir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExibir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExibir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExibir.Location = New System.Drawing.Point(573, 499)
        Me.cmdExibir.Name = "cmdExibir"
        Me.cmdExibir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExibir.Size = New System.Drawing.Size(70, 31)
        Me.cmdExibir.TabIndex = 28
        Me.cmdExibir.Text = "&Exibir"
        Me.cmdExibir.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(672, 499)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(70, 31)
        Me.cmdCancelar.TabIndex = 27
        Me.cmdCancelar.Text = "&Sair"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'txtDescricaoQualidade
        '
        Me.txtDescricaoQualidade.AcceptsReturn = True
        Me.txtDescricaoQualidade.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescricaoQualidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescricaoQualidade.Enabled = False
        Me.txtDescricaoQualidade.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoQualidade.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescricaoQualidade.Location = New System.Drawing.Point(546, 545)
        Me.txtDescricaoQualidade.MaxLength = 0
        Me.txtDescricaoQualidade.Name = "txtDescricaoQualidade"
        Me.txtDescricaoQualidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescricaoQualidade.Size = New System.Drawing.Size(104, 22)
        Me.txtDescricaoQualidade.TabIndex = 22
        Me.txtDescricaoQualidade.Visible = False
        '
        'txtProgramaTitulo
        '
        Me.txtProgramaTitulo.AcceptsReturn = True
        Me.txtProgramaTitulo.BackColor = System.Drawing.SystemColors.Window
        Me.txtProgramaTitulo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProgramaTitulo.Enabled = False
        Me.txtProgramaTitulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgramaTitulo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProgramaTitulo.Location = New System.Drawing.Point(429, 575)
        Me.txtProgramaTitulo.MaxLength = 0
        Me.txtProgramaTitulo.Name = "txtProgramaTitulo"
        Me.txtProgramaTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProgramaTitulo.Size = New System.Drawing.Size(116, 22)
        Me.txtProgramaTitulo.TabIndex = 21
        Me.txtProgramaTitulo.Visible = False
        '
        'txtVeiculoNome
        '
        Me.txtVeiculoNome.AcceptsReturn = True
        Me.txtVeiculoNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtVeiculoNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVeiculoNome.Enabled = False
        Me.txtVeiculoNome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeiculoNome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVeiculoNome.Location = New System.Drawing.Point(432, 545)
        Me.txtVeiculoNome.MaxLength = 0
        Me.txtVeiculoNome.Name = "txtVeiculoNome"
        Me.txtVeiculoNome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVeiculoNome.Size = New System.Drawing.Size(113, 22)
        Me.txtVeiculoNome.TabIndex = 20
        Me.txtVeiculoNome.Visible = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.optSim)
        Me.Frame4.Controls.Add(Me.optnao)
        Me.Frame4.Controls.Add(Me.optTodos)
        Me.Frame4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(93, 554)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(231, 28)
        Me.Frame4.TabIndex = 15
        Me.Frame4.Visible = False
        '
        'optSim
        '
        Me.optSim.BackColor = System.Drawing.SystemColors.Control
        Me.optSim.Cursor = System.Windows.Forms.Cursors.Default
        Me.optSim.Enabled = False
        Me.optSim.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSim.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optSim.Location = New System.Drawing.Point(3, 11)
        Me.optSim.Name = "optSim"
        Me.optSim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optSim.Size = New System.Drawing.Size(80, 16)
        Me.optSim.TabIndex = 18
        Me.optSim.TabStop = True
        Me.optSim.Text = "Sim"
        Me.optSim.UseVisualStyleBackColor = False
        '
        'optnao
        '
        Me.optnao.BackColor = System.Drawing.SystemColors.Control
        Me.optnao.Cursor = System.Windows.Forms.Cursors.Default
        Me.optnao.Enabled = False
        Me.optnao.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optnao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optnao.Location = New System.Drawing.Point(83, 11)
        Me.optnao.Name = "optnao"
        Me.optnao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optnao.Size = New System.Drawing.Size(80, 16)
        Me.optnao.TabIndex = 17
        Me.optnao.TabStop = True
        Me.optnao.Text = "Não"
        Me.optnao.UseVisualStyleBackColor = False
        '
        'optTodos
        '
        Me.optTodos.BackColor = System.Drawing.SystemColors.Control
        Me.optTodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.optTodos.Enabled = False
        Me.optTodos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTodos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optTodos.Location = New System.Drawing.Point(163, 11)
        Me.optTodos.Name = "optTodos"
        Me.optTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optTodos.Size = New System.Drawing.Size(80, 16)
        Me.optTodos.TabIndex = 16
        Me.optTodos.TabStop = True
        Me.optTodos.Text = "Todos"
        Me.optTodos.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.chkNOrdenados)
        Me.Frame3.Controls.Add(Me.chkOrdenados)
        Me.Frame3.Controls.Add(Me.chkNBaixados)
        Me.Frame3.Controls.Add(Me.chkBaixados)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame3.Location = New System.Drawing.Point(6, 91)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(738, 46)
        Me.Frame3.TabIndex = 9
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Situação da Veiculação"
        '
        'chkNOrdenados
        '
        Me.chkNOrdenados.BackColor = System.Drawing.SystemColors.Control
        Me.chkNOrdenados.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNOrdenados.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNOrdenados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNOrdenados.Location = New System.Drawing.Point(211, 18)
        Me.chkNOrdenados.Name = "chkNOrdenados"
        Me.chkNOrdenados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNOrdenados.Size = New System.Drawing.Size(104, 19)
        Me.chkNOrdenados.TabIndex = 13
        Me.chkNOrdenados.Text = "Não Ordenados"
        Me.chkNOrdenados.UseVisualStyleBackColor = False
        '
        'chkOrdenados
        '
        Me.chkOrdenados.BackColor = System.Drawing.SystemColors.Control
        Me.chkOrdenados.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOrdenados.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrdenados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOrdenados.Location = New System.Drawing.Point(50, 18)
        Me.chkOrdenados.Name = "chkOrdenados"
        Me.chkOrdenados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOrdenados.Size = New System.Drawing.Size(98, 18)
        Me.chkOrdenados.TabIndex = 12
        Me.chkOrdenados.Text = "Ordenados"
        Me.chkOrdenados.UseVisualStyleBackColor = False
        '
        'chkNBaixados
        '
        Me.chkNBaixados.BackColor = System.Drawing.SystemColors.Control
        Me.chkNBaixados.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNBaixados.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNBaixados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNBaixados.Location = New System.Drawing.Point(590, 20)
        Me.chkNBaixados.Name = "chkNBaixados"
        Me.chkNBaixados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNBaixados.Size = New System.Drawing.Size(125, 16)
        Me.chkNBaixados.TabIndex = 11
        Me.chkNBaixados.Text = "Não Baixados"
        Me.chkNBaixados.UseVisualStyleBackColor = False
        '
        'chkBaixados
        '
        Me.chkBaixados.BackColor = System.Drawing.SystemColors.Control
        Me.chkBaixados.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBaixados.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBaixados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBaixados.Location = New System.Drawing.Point(447, 18)
        Me.chkBaixados.Name = "chkBaixados"
        Me.chkBaixados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBaixados.Size = New System.Drawing.Size(125, 20)
        Me.chkBaixados.TabIndex = 10
        Me.chkBaixados.Text = "Baixados"
        Me.chkBaixados.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.flxConfirmacao)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(6, 128)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(738, 365)
        Me.Frame2.TabIndex = 7
        Me.Frame2.TabStop = False
        '
        'flxConfirmacao
        '
        Me.flxConfirmacao.Location = New System.Drawing.Point(10, 15)
        Me.flxConfirmacao.Name = "flxConfirmacao"
        Me.flxConfirmacao.OcxState = CType(resources.GetObject("flxConfirmacao.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxConfirmacao.Size = New System.Drawing.Size(721, 334)
        Me.flxConfirmacao.TabIndex = 8
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.ucQualidade)
        Me.Frame1.Controls.Add(Me.ucPrograma)
        Me.Frame1.Controls.Add(Me.ucVeiculo)
        Me.Frame1.Controls.Add(Me.dteData)
        Me.Frame1.Controls.Add(Me._lblCampos_2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Frame1.Location = New System.Drawing.Point(6, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(736, 73)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Dados da Programação"
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(15, 10)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(321, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 30
        Me.ucVeiculo.TextBoxLeft = CType(60, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'dteData
        '
        Me.dteData.BackColor = System.Drawing.Color.Transparent
        Me.dteData.DateTime = New Date(CType(0, Long))
        Me.dteData.Formato = "dd/MM/yyyy ddd"
        Me.dteData.Hoje = False
        Me.dteData.Location = New System.Drawing.Point(467, 41)
        Me.dteData.MaximumSize = New System.Drawing.Size(500, 25)
        Me.dteData.MinimumSize = New System.Drawing.Size(115, 25)
        Me.dteData.Name = "dteData"
        Me.dteData.Permite_Futuro = True
        Me.dteData.Permite_Limpar = True
        Me.dteData.Permite_Passado = True
        Me.dteData.Preenchimento_Obrigatorio = False
        Me.dteData.Size = New System.Drawing.Size(135, 25)
        Me.dteData.TabIndex = 29
        '
        '_lblCampos_2
        '
        Me._lblCampos_2.AutoSize = True
        Me._lblCampos_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblCampos.SetIndex(Me._lblCampos_2, CType(2, Short))
        Me._lblCampos_2.Location = New System.Drawing.Point(410, 46)
        Me._lblCampos_2.Name = "_lblCampos_2"
        Me._lblCampos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_2.Size = New System.Drawing.Size(29, 14)
        Me._lblCampos_2.TabIndex = 6
        Me._lblCampos_2.Text = "Data"
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.SystemColors.Control
        Me.lblNet.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNet.Enabled = False
        Me.lblNet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblNet.Location = New System.Drawing.Point(15, 562)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNet.Size = New System.Drawing.Size(77, 16)
        Me.lblNet.TabIndex = 19
        Me.lblNet.Text = "Net ? "
        Me.lblNet.Visible = False
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(410, 10)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(321, 25)
        Me.ucPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma.TabIndex = 31
        Me.ucPrograma.TextBoxLeft = CType(0, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'ucQualidade
        '
        Me.ucQualidade.BackColor = System.Drawing.SystemColors.Control
        Me.ucQualidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucQualidade.Caption = "Qualidade"
        Me.ucQualidade.DataTextValue = Nothing
        Me.ucQualidade.Location = New System.Drawing.Point(15, 41)
        Me.ucQualidade.MaxLength = 3
        Me.ucQualidade.Name = "ucQualidade"
        Me.ucQualidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucQualidade.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucQualidade.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucQualidade.pDecimal = CType(0, Byte)
        Me.ucQualidade.pDicionario = WUC.clsDicionario.enuDicionario.Qualidade
        Me.ucQualidade.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucQualidade.showButton = True
        Me.ucQualidade.ShowDescricao = True
        Me.ucQualidade.Size = New System.Drawing.Size(321, 25)
        Me.ucQualidade.sqlQuery = "execute PrNet_Qualidade_L"
        Me.ucQualidade.TabIndex = 32
        Me.ucQualidade.TextBoxLeft = CType(60, Short)
        Me.ucQualidade.TextWidth = 0
        '
        'frmRoteiro_Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(754, 537)
        Me.Controls.Add(Me.cmdExibir)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtDescricaoQualidade)
        Me.Controls.Add(Me.txtProgramaTitulo)
        Me.Controls.Add(Me.txtVeiculoNome)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lblNet)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoteiro_Consulta"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "Consulta de Veiculações"
        Me.Frame4.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        CType(Me.flxConfirmacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dteData As WCL_SCTV.UC.UCData
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents ucQualidade As WUC.UcText
#End Region 
End Class