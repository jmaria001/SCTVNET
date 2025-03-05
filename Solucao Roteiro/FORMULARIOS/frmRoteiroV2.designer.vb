<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRoteiroV2
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
	Public WithEvents _Picture1_0 As System.Windows.Forms.PictureBox
	Public WithEvents _cmdCancela_0 As System.Windows.Forms.Button
	Public WithEvents _cmdCancela_1 As System.Windows.Forms.Button
    Public WithEvents flxCorte As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents _Label3_1 As System.Windows.Forms.Label
    Public WithEvents lblCorte As System.Windows.Forms.Label
    Public WithEvents picCorte As System.Windows.Forms.Panel
    Public WithEvents _cmdStatusOk_0 As System.Windows.Forms.Button
    Public WithEvents _cmdStatusOk_1 As System.Windows.Forms.Button
    Public WithEvents flxStatus As axMSFlexGridLib.axMSFlexGrid
	Public WithEvents lblStatus As System.Windows.Forms.Label
	Public WithEvents picStatus As System.Windows.Forms.Panel
    Public WithEvents chkRecebeOrdenacao As System.Windows.Forms.CheckBox
    Public WithEvents frame1 As System.Windows.Forms.GroupBox
    Public WithEvents _flxDisponivel_6 As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents cmdDadosComercial As System.Windows.Forms.Button
    Public WithEvents cmdRefresh As System.Windows.Forms.Button
    Public WithEvents txtMensagem As System.Windows.Forms.TextBox
    Public WithEvents _flxDisponivel_4 As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents _flxDisponivel_1 As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents _flxDisponivel_5 As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents _flxDisponivel_2 As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents _flxDisponivel_3 As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents picDisponivel As System.Windows.Forms.Panel
    Public WithEvents cmdMarcarTodos As System.Windows.Forms.CheckBox
    Public WithEvents cmdCarregar As System.Windows.Forms.Button
    Public WithEvents cmdDadosComercialOrdenado As System.Windows.Forms.Button
    Public WithEvents _flxBreak_0 As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents treBreak As System.Windows.Forms.TreeView
    Public WithEvents _lblCampos_8 As System.Windows.Forms.Label
    Public WithEvents picBreak As System.Windows.Forms.Panel
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents tbSalvar As System.Windows.Forms.ToolStripButton
    Public WithEvents tbGuia As System.Windows.Forms.ToolStripButton
    Public WithEvents tbCancelar As System.Windows.Forms.ToolStripButton
    Public WithEvents tbExcluir As System.Windows.Forms.ToolStripButton
    Public WithEvents tbUsuario As System.Windows.Forms.ToolStripButton
    Public WithEvents tbConsistencia As System.Windows.Forms.ToolStripButton
    Public WithEvents tbSair As System.Windows.Forms.ToolStripButton
    Public WithEvents tbOpcoes As System.Windows.Forms.ToolStrip
    Public WithEvents _Label2_3 As System.Windows.Forms.Label
    Public WithEvents _Label2_2 As System.Windows.Forms.Label
    Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label3 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Picture1 As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents cmdCancela As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdStatusOk As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents flxBreak As AxMSFlexGridArray.AxMSFlexGridArray
    Public WithEvents flxDisponivel As AxMSFlexGridArray.AxMSFlexGridArray
    Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents picDragOK As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoteiroV2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdDadosComercial = New System.Windows.Forms.Button
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdDadosComercialOrdenado = New System.Windows.Forms.Button
        Me.picCorte = New System.Windows.Forms.Panel
        Me._Picture1_0 = New System.Windows.Forms.PictureBox
        Me._cmdCancela_0 = New System.Windows.Forms.Button
        Me._cmdCancela_1 = New System.Windows.Forms.Button
        Me.flxCorte = New AxMSFlexGridLib.AxMSFlexGrid
        Me._Label3_1 = New System.Windows.Forms.Label
        Me.lblCorte = New System.Windows.Forms.Label
        Me.picStatus = New System.Windows.Forms.Panel
        Me.picMensagem = New System.Windows.Forms.Panel
        Me.lblMensagem = New System.Windows.Forms.Label
        Me._cmdStatusOk_0 = New System.Windows.Forms.Button
        Me._cmdStatusOk_1 = New System.Windows.Forms.Button
        Me.flxStatus = New AxMSFlexGridLib.AxMSFlexGrid
        Me.lblStatus = New System.Windows.Forms.Label
        Me.frame1 = New System.Windows.Forms.GroupBox
        Me.chkSalvar = New System.Windows.Forms.CheckBox
        Me.chkConcorrencia = New System.Windows.Forms.CheckBox
        Me.txtTipoIntervalo = New System.Windows.Forms.TextBox
        Me.lblTamanhoColuna = New System.Windows.Forms.Label
        Me.chkRecebeOrdenacao = New System.Windows.Forms.CheckBox
        Me.picDisponivel = New System.Windows.Forms.Panel
        Me._flxDisponivel_6 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.txtMensagem = New System.Windows.Forms.TextBox
        Me._flxDisponivel_4 = New AxMSFlexGridLib.AxMSFlexGrid
        Me._flxDisponivel_1 = New AxMSFlexGridLib.AxMSFlexGrid
        Me._flxDisponivel_5 = New AxMSFlexGridLib.AxMSFlexGrid
        Me._flxDisponivel_2 = New AxMSFlexGridLib.AxMSFlexGrid
        Me._flxDisponivel_3 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.tabDisponiveis = New AxComctlLib.AxTabStrip
        Me.picBreak = New System.Windows.Forms.Panel
        Me.cmdMarcarTodos = New System.Windows.Forms.CheckBox
        Me.cmdCarregar = New System.Windows.Forms.Button
        Me._flxBreak_0 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.treBreak = New System.Windows.Forms.TreeView
        Me._lblCampos_8 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbOpcoes = New System.Windows.Forms.ToolStrip
        Me.tbSalvar = New System.Windows.Forms.ToolStripButton
        Me.tbGuia = New System.Windows.Forms.ToolStripButton
        Me.tbCancelar = New System.Windows.Forms.ToolStripButton
        Me.tbExcluir = New System.Windows.Forms.ToolStripButton
        Me.tbUsuario = New System.Windows.Forms.ToolStripButton
        Me.tbConsistencia = New System.Windows.Forms.ToolStripButton
        Me.tbSair = New System.Windows.Forms.ToolStripButton
        Me._Label2_3 = New System.Windows.Forms.Label
        Me._Label2_2 = New System.Windows.Forms.Label
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label3 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Picture1 = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.cmdCancela = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdStatusOk = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.flxBreak = New AxMSFlexGridArray.AxMSFlexGridArray(Me.components)
        Me.flxDisponivel = New AxMSFlexGridArray.AxMSFlexGridArray(Me.components)
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.picDragOK = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.fraProgramacao = New System.Windows.Forms.GroupBox
        Me.lblCoordenadas = New System.Windows.Forms.Label
        Me.ucVeiculo = New WUC.UcText
        Me.UcData = New WCL_SCTV.UC.UCData
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdOkProgramacao = New System.Windows.Forms.Button
        Me.picCorte.SuspendLayout()
        CType(Me._Picture1_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxCorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picStatus.SuspendLayout()
        Me.picMensagem.SuspendLayout()
        CType(Me.flxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frame1.SuspendLayout()
        Me.picDisponivel.SuspendLayout()
        CType(Me._flxDisponivel_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flxDisponivel_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flxDisponivel_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flxDisponivel_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flxDisponivel_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flxDisponivel_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDisponiveis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picBreak.SuspendLayout()
        CType(Me._flxBreak_0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOpcoes.SuspendLayout()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdStatusOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxBreak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxDisponivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDragOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraProgramacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDadosComercial
        '
        Me.cmdDadosComercial.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDadosComercial.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDadosComercial.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdDadosComercial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDadosComercial.Image = CType(resources.GetObject("cmdDadosComercial.Image"), System.Drawing.Image)
        Me.cmdDadosComercial.Location = New System.Drawing.Point(399, 0)
        Me.cmdDadosComercial.Name = "cmdDadosComercial"
        Me.cmdDadosComercial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDadosComercial.Size = New System.Drawing.Size(25, 20)
        Me.cmdDadosComercial.TabIndex = 17
        Me.cmdDadosComercial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdDadosComercial, "Ver Dados do Comercial")
        Me.cmdDadosComercial.UseVisualStyleBackColor = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRefresh.Location = New System.Drawing.Point(423, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRefresh.Size = New System.Drawing.Size(25, 20)
        Me.cmdRefresh.TabIndex = 16
        Me.cmdRefresh.Text = "ü"
        Me.ToolTip1.SetToolTip(Me.cmdRefresh, "Atualizar Pastas")
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'cmdDadosComercialOrdenado
        '
        Me.cmdDadosComercialOrdenado.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDadosComercialOrdenado.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDadosComercialOrdenado.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdDadosComercialOrdenado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDadosComercialOrdenado.Image = CType(resources.GetObject("cmdDadosComercialOrdenado.Image"), System.Drawing.Image)
        Me.cmdDadosComercialOrdenado.Location = New System.Drawing.Point(453, 0)
        Me.cmdDadosComercialOrdenado.Name = "cmdDadosComercialOrdenado"
        Me.cmdDadosComercialOrdenado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDadosComercialOrdenado.Size = New System.Drawing.Size(25, 20)
        Me.cmdDadosComercialOrdenado.TabIndex = 18
        Me.cmdDadosComercialOrdenado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdDadosComercialOrdenado, "Ver Dados do Comercial")
        Me.cmdDadosComercialOrdenado.UseVisualStyleBackColor = False
        Me.cmdDadosComercialOrdenado.Visible = False
        '
        'picCorte
        '
        Me.picCorte.BackColor = System.Drawing.SystemColors.Control
        Me.picCorte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCorte.Controls.Add(Me._Picture1_0)
        Me.picCorte.Controls.Add(Me._cmdCancela_0)
        Me.picCorte.Controls.Add(Me._cmdCancela_1)
        Me.picCorte.Controls.Add(Me.flxCorte)
        Me.picCorte.Controls.Add(Me._Label3_1)
        Me.picCorte.Controls.Add(Me.lblCorte)
        Me.picCorte.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCorte.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picCorte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picCorte.Location = New System.Drawing.Point(6, 480)
        Me.picCorte.Name = "picCorte"
        Me.picCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picCorte.Size = New System.Drawing.Size(129, 116)
        Me.picCorte.TabIndex = 31
        Me.picCorte.TabStop = True
        Me.picCorte.Tag = "0"
        Me.picCorte.Visible = False
        '
        '_Picture1_0
        '
        Me._Picture1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Picture1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Picture1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Picture1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Picture1_0.Image = CType(resources.GetObject("_Picture1_0.Image"), System.Drawing.Image)
        Me.Picture1.SetIndex(Me._Picture1_0, CType(0, Short))
        Me._Picture1_0.Location = New System.Drawing.Point(9, 237)
        Me._Picture1_0.Name = "_Picture1_0"
        Me._Picture1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Picture1_0.Size = New System.Drawing.Size(37, 37)
        Me._Picture1_0.TabIndex = 36
        Me._Picture1_0.TabStop = False
        '
        '_cmdCancela_0
        '
        Me._cmdCancela_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_0, CType(0, Short))
        Me._cmdCancela_0.Location = New System.Drawing.Point(423, 237)
        Me._cmdCancela_0.Name = "_cmdCancela_0"
        Me._cmdCancela_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_0.Size = New System.Drawing.Size(91, 34)
        Me._cmdCancela_0.TabIndex = 34
        Me._cmdCancela_0.TabStop = False
        Me._cmdCancela_0.Text = "&Cancela"
        Me._cmdCancela_0.UseVisualStyleBackColor = False
        '
        '_cmdCancela_1
        '
        Me._cmdCancela_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_1, CType(1, Short))
        Me._cmdCancela_1.Location = New System.Drawing.Point(504, 0)
        Me._cmdCancela_1.Name = "_cmdCancela_1"
        Me._cmdCancela_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_1.Size = New System.Drawing.Size(19, 19)
        Me._cmdCancela_1.TabIndex = 32
        Me._cmdCancela_1.TabStop = False
        Me._cmdCancela_1.Text = "X"
        Me._cmdCancela_1.UseVisualStyleBackColor = False
        '
        'flxCorte
        '
        Me.flxCorte.Location = New System.Drawing.Point(3, 21)
        Me.flxCorte.Name = "flxCorte"
        Me.flxCorte.OcxState = CType(resources.GetObject("flxCorte.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxCorte.Size = New System.Drawing.Size(507, 211)
        Me.flxCorte.TabIndex = 35
        '
        '_Label3_1
        '
        Me._Label3_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.SetIndex(Me._Label3_1, CType(1, Short))
        Me._Label3_1.Location = New System.Drawing.Point(48, 237)
        Me._Label3_1.Name = "_Label3_1"
        Me._Label3_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_1.Size = New System.Drawing.Size(312, 34)
        Me._Label3_1.TabIndex = 37
        Me._Label3_1.Text = "Os Comerciais acima listados foram cortados do Roteiro por Baixa da Veiculação"
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
        Me.lblCorte.Size = New System.Drawing.Size(527, 22)
        Me.lblCorte.TabIndex = 33
        Me.lblCorte.Text = "  Alerta de Comerciais Cortados do Roteiro"
        '
        'picStatus
        '
        Me.picStatus.BackColor = System.Drawing.SystemColors.Control
        Me.picStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStatus.Controls.Add(Me.picMensagem)
        Me.picStatus.Controls.Add(Me._cmdStatusOk_0)
        Me.picStatus.Controls.Add(Me._cmdStatusOk_1)
        Me.picStatus.Controls.Add(Me.flxStatus)
        Me.picStatus.Controls.Add(Me.lblStatus)
        Me.picStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.picStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picStatus.Location = New System.Drawing.Point(161, 480)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picStatus.Size = New System.Drawing.Size(178, 92)
        Me.picStatus.TabIndex = 41
        Me.picStatus.TabStop = True
        Me.picStatus.Tag = "0"
        Me.picStatus.Visible = False
        '
        'picMensagem
        '
        Me.picMensagem.BackColor = System.Drawing.SystemColors.Control
        Me.picMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMensagem.Controls.Add(Me.lblMensagem)
        Me.picMensagem.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMensagem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picMensagem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picMensagem.Location = New System.Drawing.Point(6, 240)
        Me.picMensagem.Name = "picMensagem"
        Me.picMensagem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picMensagem.Size = New System.Drawing.Size(436, 45)
        Me.picMensagem.TabIndex = 46
        Me.picMensagem.TabStop = True
        '
        'lblMensagem
        '
        Me.lblMensagem.BackColor = System.Drawing.SystemColors.Control
        Me.lblMensagem.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMensagem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.ForeColor = System.Drawing.Color.Red
        Me.lblMensagem.Location = New System.Drawing.Point(3, 3)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMensagem.Size = New System.Drawing.Size(419, 34)
        Me.lblMensagem.TabIndex = 56
        Me.lblMensagem.Text = "As linhas em vermelho indicam  problemas durante a gravação. Favor Corrigir e sal" & _
            "var novamente."
        '
        '_cmdStatusOk_0
        '
        Me._cmdStatusOk_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdStatusOk_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdStatusOk_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdStatusOk_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStatusOk.SetIndex(Me._cmdStatusOk_0, CType(0, Short))
        Me._cmdStatusOk_0.Location = New System.Drawing.Point(504, 0)
        Me._cmdStatusOk_0.Name = "_cmdStatusOk_0"
        Me._cmdStatusOk_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdStatusOk_0.Size = New System.Drawing.Size(19, 16)
        Me._cmdStatusOk_0.TabIndex = 43
        Me._cmdStatusOk_0.TabStop = False
        Me._cmdStatusOk_0.Text = "X"
        Me._cmdStatusOk_0.UseVisualStyleBackColor = False
        '
        '_cmdStatusOk_1
        '
        Me._cmdStatusOk_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdStatusOk_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdStatusOk_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdStatusOk_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStatusOk.SetIndex(Me._cmdStatusOk_1, CType(1, Short))
        Me._cmdStatusOk_1.Location = New System.Drawing.Point(452, 254)
        Me._cmdStatusOk_1.Name = "_cmdStatusOk_1"
        Me._cmdStatusOk_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdStatusOk_1.Size = New System.Drawing.Size(70, 31)
        Me._cmdStatusOk_1.TabIndex = 42
        Me._cmdStatusOk_1.TabStop = False
        Me._cmdStatusOk_1.Text = "&Ok"
        Me._cmdStatusOk_1.UseVisualStyleBackColor = False
        '
        'flxStatus
        '
        Me.flxStatus.Location = New System.Drawing.Point(6, 24)
        Me.flxStatus.Name = "flxStatus"
        Me.flxStatus.OcxState = CType(resources.GetObject("flxStatus.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxStatus.Size = New System.Drawing.Size(516, 217)
        Me.flxStatus.TabIndex = 44
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(530, 19)
        Me.lblStatus.TabIndex = 45
        Me.lblStatus.Text = "Status da Gravação"
        '
        'frame1
        '
        Me.frame1.BackColor = System.Drawing.SystemColors.Control
        Me.frame1.Controls.Add(Me.chkSalvar)
        Me.frame1.Controls.Add(Me.chkConcorrencia)
        Me.frame1.Controls.Add(Me.txtTipoIntervalo)
        Me.frame1.Controls.Add(Me.lblTamanhoColuna)
        Me.frame1.Controls.Add(Me.chkRecebeOrdenacao)
        Me.frame1.Enabled = False
        Me.frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frame1.Location = New System.Drawing.Point(6, 295)
        Me.frame1.Name = "frame1"
        Me.frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame1.Size = New System.Drawing.Size(242, 113)
        Me.frame1.TabIndex = 19
        Me.frame1.TabStop = False
        Me.frame1.Visible = False
        '
        'chkSalvar
        '
        Me.chkSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.chkSalvar.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSalvar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalvar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSalvar.Location = New System.Drawing.Point(12, 76)
        Me.chkSalvar.Name = "chkSalvar"
        Me.chkSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSalvar.Size = New System.Drawing.Size(176, 15)
        Me.chkSalvar.TabIndex = 66
        Me.chkSalvar.Text = "Salvar a Ordenacao"
        Me.chkSalvar.UseVisualStyleBackColor = False
        Me.chkSalvar.Visible = False
        '
        'chkConcorrencia
        '
        Me.chkConcorrencia.BackColor = System.Drawing.SystemColors.Control
        Me.chkConcorrencia.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkConcorrencia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConcorrencia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkConcorrencia.Location = New System.Drawing.Point(12, 55)
        Me.chkConcorrencia.Name = "chkConcorrencia"
        Me.chkConcorrencia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkConcorrencia.Size = New System.Drawing.Size(204, 22)
        Me.chkConcorrencia.TabIndex = 67
        Me.chkConcorrencia.Text = "Não Alertar Choque de Concorrência"
        Me.chkConcorrencia.UseVisualStyleBackColor = False
        Me.chkConcorrencia.Visible = False
        '
        'txtTipoIntervalo
        '
        Me.txtTipoIntervalo.AcceptsReturn = True
        Me.txtTipoIntervalo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoIntervalo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoIntervalo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoIntervalo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoIntervalo.Location = New System.Drawing.Point(-183, -1)
        Me.txtTipoIntervalo.MaxLength = 0
        Me.txtTipoIntervalo.Name = "txtTipoIntervalo"
        Me.txtTipoIntervalo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoIntervalo.Size = New System.Drawing.Size(75, 20)
        Me.txtTipoIntervalo.TabIndex = 68
        Me.txtTipoIntervalo.Visible = False
        '
        'lblTamanhoColuna
        '
        Me.lblTamanhoColuna.AutoSize = True
        Me.lblTamanhoColuna.Location = New System.Drawing.Point(9, 39)
        Me.lblTamanhoColuna.Name = "lblTamanhoColuna"
        Me.lblTamanhoColuna.Size = New System.Drawing.Size(146, 14)
        Me.lblTamanhoColuna.TabIndex = 62
        Me.lblTamanhoColuna.Text = "Label Tamanho Texto Coluna"
        Me.lblTamanhoColuna.Visible = False
        '
        'chkRecebeOrdenacao
        '
        Me.chkRecebeOrdenacao.BackColor = System.Drawing.SystemColors.Control
        Me.chkRecebeOrdenacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRecebeOrdenacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecebeOrdenacao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRecebeOrdenacao.Location = New System.Drawing.Point(12, 19)
        Me.chkRecebeOrdenacao.Name = "chkRecebeOrdenacao"
        Me.chkRecebeOrdenacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRecebeOrdenacao.Size = New System.Drawing.Size(154, 17)
        Me.chkRecebeOrdenacao.TabIndex = 28
        Me.chkRecebeOrdenacao.Text = "Recebe Ordenacao"
        Me.chkRecebeOrdenacao.UseVisualStyleBackColor = False
        '
        'picDisponivel
        '
        Me.picDisponivel.BackColor = System.Drawing.SystemColors.Control
        Me.picDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDisponivel.Controls.Add(Me.frame1)
        Me.picDisponivel.Controls.Add(Me._flxDisponivel_6)
        Me.picDisponivel.Controls.Add(Me.cmdDadosComercial)
        Me.picDisponivel.Controls.Add(Me.cmdRefresh)
        Me.picDisponivel.Controls.Add(Me.txtMensagem)
        Me.picDisponivel.Controls.Add(Me._flxDisponivel_4)
        Me.picDisponivel.Controls.Add(Me._flxDisponivel_1)
        Me.picDisponivel.Controls.Add(Me._flxDisponivel_5)
        Me.picDisponivel.Controls.Add(Me._flxDisponivel_2)
        Me.picDisponivel.Controls.Add(Me._flxDisponivel_3)
        Me.picDisponivel.Controls.Add(Me.tabDisponiveis)
        Me.picDisponivel.Cursor = System.Windows.Forms.Cursors.Default
        Me.picDisponivel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picDisponivel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picDisponivel.Location = New System.Drawing.Point(493, 47)
        Me.picDisponivel.Name = "picDisponivel"
        Me.picDisponivel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picDisponivel.Size = New System.Drawing.Size(473, 427)
        Me.picDisponivel.TabIndex = 4
        Me.picDisponivel.TabStop = True
        '
        '_flxDisponivel_6
        '
        Me.flxDisponivel.SetIndex(Me._flxDisponivel_6, CType(6, Short))
        Me._flxDisponivel_6.Location = New System.Drawing.Point(3, 228)
        Me._flxDisponivel_6.Name = "_flxDisponivel_6"
        Me._flxDisponivel_6.OcxState = CType(resources.GetObject("_flxDisponivel_6.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxDisponivel_6.Size = New System.Drawing.Size(421, 30)
        Me._flxDisponivel_6.TabIndex = 30
        Me._flxDisponivel_6.Visible = False
        '
        'txtMensagem
        '
        Me.txtMensagem.AcceptsReturn = True
        Me.txtMensagem.BackColor = System.Drawing.SystemColors.Info
        Me.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensagem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMensagem.Enabled = False
        Me.txtMensagem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensagem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMensagem.Location = New System.Drawing.Point(6, 264)
        Me.txtMensagem.MaxLength = 0
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMensagem.Size = New System.Drawing.Size(295, 25)
        Me.txtMensagem.TabIndex = 14
        Me.txtMensagem.Visible = False
        '
        '_flxDisponivel_4
        '
        Me.flxDisponivel.SetIndex(Me._flxDisponivel_4, CType(4, Short))
        Me._flxDisponivel_4.Location = New System.Drawing.Point(3, 150)
        Me._flxDisponivel_4.Name = "_flxDisponivel_4"
        Me._flxDisponivel_4.OcxState = CType(resources.GetObject("_flxDisponivel_4.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxDisponivel_4.Size = New System.Drawing.Size(421, 30)
        Me._flxDisponivel_4.TabIndex = 10
        Me._flxDisponivel_4.Visible = False
        '
        '_flxDisponivel_1
        '
        Me.flxDisponivel.SetIndex(Me._flxDisponivel_1, CType(1, Short))
        Me._flxDisponivel_1.Location = New System.Drawing.Point(3, 42)
        Me._flxDisponivel_1.Name = "_flxDisponivel_1"
        Me._flxDisponivel_1.OcxState = CType(resources.GetObject("_flxDisponivel_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxDisponivel_1.Size = New System.Drawing.Size(421, 30)
        Me._flxDisponivel_1.TabIndex = 6
        Me._flxDisponivel_1.Visible = False
        '
        '_flxDisponivel_5
        '
        Me.flxDisponivel.SetIndex(Me._flxDisponivel_5, CType(5, Short))
        Me._flxDisponivel_5.Location = New System.Drawing.Point(3, 191)
        Me._flxDisponivel_5.Name = "_flxDisponivel_5"
        Me._flxDisponivel_5.OcxState = CType(resources.GetObject("_flxDisponivel_5.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxDisponivel_5.Size = New System.Drawing.Size(421, 30)
        Me._flxDisponivel_5.TabIndex = 0
        Me._flxDisponivel_5.Visible = False
        '
        '_flxDisponivel_2
        '
        Me.flxDisponivel.SetIndex(Me._flxDisponivel_2, CType(2, Short))
        Me._flxDisponivel_2.Location = New System.Drawing.Point(3, 79)
        Me._flxDisponivel_2.Name = "_flxDisponivel_2"
        Me._flxDisponivel_2.OcxState = CType(resources.GetObject("_flxDisponivel_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxDisponivel_2.Size = New System.Drawing.Size(421, 30)
        Me._flxDisponivel_2.TabIndex = 8
        Me._flxDisponivel_2.Visible = False
        '
        '_flxDisponivel_3
        '
        Me.flxDisponivel.SetIndex(Me._flxDisponivel_3, CType(3, Short))
        Me._flxDisponivel_3.Location = New System.Drawing.Point(3, 115)
        Me._flxDisponivel_3.Name = "_flxDisponivel_3"
        Me._flxDisponivel_3.OcxState = CType(resources.GetObject("_flxDisponivel_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxDisponivel_3.Size = New System.Drawing.Size(421, 30)
        Me._flxDisponivel_3.TabIndex = 9
        Me._flxDisponivel_3.Visible = False
        '
        'tabDisponiveis
        '
        Me.tabDisponiveis.Location = New System.Drawing.Point(-2, 3)
        Me.tabDisponiveis.Name = "tabDisponiveis"
        Me.tabDisponiveis.OcxState = CType(resources.GetObject("tabDisponiveis.OcxState"), System.Windows.Forms.AxHost.State)
        Me.tabDisponiveis.Size = New System.Drawing.Size(472, 372)
        Me.tabDisponiveis.TabIndex = 31
        '
        'picBreak
        '
        Me.picBreak.BackColor = System.Drawing.SystemColors.Control
        Me.picBreak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBreak.Controls.Add(Me.cmdMarcarTodos)
        Me.picBreak.Controls.Add(Me.cmdCarregar)
        Me.picBreak.Controls.Add(Me.cmdDadosComercialOrdenado)
        Me.picBreak.Controls.Add(Me._flxBreak_0)
        Me.picBreak.Controls.Add(Me.treBreak)
        Me.picBreak.Controls.Add(Me._lblCampos_8)
        Me.picBreak.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBreak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picBreak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picBreak.Location = New System.Drawing.Point(3, 45)
        Me.picBreak.Name = "picBreak"
        Me.picBreak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picBreak.Size = New System.Drawing.Size(485, 427)
        Me.picBreak.TabIndex = 1
        Me.picBreak.TabStop = True
        '
        'cmdMarcarTodos
        '
        Me.cmdMarcarTodos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMarcarTodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMarcarTodos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMarcarTodos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMarcarTodos.Location = New System.Drawing.Point(9, 370)
        Me.cmdMarcarTodos.Name = "cmdMarcarTodos"
        Me.cmdMarcarTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMarcarTodos.Size = New System.Drawing.Size(93, 17)
        Me.cmdMarcarTodos.TabIndex = 57
        Me.cmdMarcarTodos.Text = "Marcar Todos"
        Me.cmdMarcarTodos.UseVisualStyleBackColor = False
        '
        'cmdCarregar
        '
        Me.cmdCarregar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCarregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCarregar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCarregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCarregar.Location = New System.Drawing.Point(9, 393)
        Me.cmdCarregar.Name = "cmdCarregar"
        Me.cmdCarregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCarregar.Size = New System.Drawing.Size(97, 28)
        Me.cmdCarregar.TabIndex = 56
        Me.cmdCarregar.Text = "Carregar Roteiro"
        Me.cmdCarregar.UseVisualStyleBackColor = False
        '
        '_flxBreak_0
        '
        Me.flxBreak.SetIndex(Me._flxBreak_0, CType(0, Short))
        Me._flxBreak_0.Location = New System.Drawing.Point(142, 21)
        Me._flxBreak_0.Name = "_flxBreak_0"
        Me._flxBreak_0.OcxState = CType(resources.GetObject("_flxBreak_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxBreak_0.Size = New System.Drawing.Size(340, 403)
        Me._flxBreak_0.TabIndex = 0
        '
        'treBreak
        '
        Me.treBreak.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treBreak.CheckBoxes = True
        Me.treBreak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treBreak.Indent = 27
        Me.treBreak.Location = New System.Drawing.Point(2, 24)
        Me.treBreak.Name = "treBreak"
        Me.treBreak.Size = New System.Drawing.Size(137, 342)
        Me.treBreak.TabIndex = 39
        '
        '_lblCampos_8
        '
        Me._lblCampos_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._lblCampos_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblCampos_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_8.ForeColor = System.Drawing.Color.White
        Me.lblCampos.SetIndex(Me._lblCampos_8, CType(8, Short))
        Me._lblCampos_8.Location = New System.Drawing.Point(0, 0)
        Me._lblCampos_8.Name = "_lblCampos_8"
        Me._lblCampos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_8.Size = New System.Drawing.Size(479, 21)
        Me._lblCampos_8.TabIndex = 3
        Me._lblCampos_8.Text = "Roteiro da Programação"
        Me._lblCampos_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        '
        'tbOpcoes
        '
        Me.tbOpcoes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tbOpcoes.ImageList = Me.ImageList1
        Me.tbOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbSalvar, Me.tbGuia, Me.tbCancelar, Me.tbExcluir, Me.tbUsuario, Me.tbConsistencia, Me.tbSair})
        Me.tbOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.tbOpcoes.Name = "tbOpcoes"
        Me.tbOpcoes.Size = New System.Drawing.Size(978, 42)
        Me.tbOpcoes.TabIndex = 0
        '
        'tbSalvar
        '
        Me.tbSalvar.AutoSize = False
        Me.tbSalvar.ImageIndex = 6
        Me.tbSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbSalvar.Name = "tbSalvar"
        Me.tbSalvar.Size = New System.Drawing.Size(40, 39)
        Me.tbSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbSalvar.ToolTipText = "Salvar a Ordenação"
        '
        'tbGuia
        '
        Me.tbGuia.AutoSize = False
        Me.tbGuia.ImageIndex = 11
        Me.tbGuia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbGuia.Name = "tbGuia"
        Me.tbGuia.Size = New System.Drawing.Size(40, 39)
        Me.tbGuia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbGuia.ToolTipText = "Ocultar Guia"
        '
        'tbCancelar
        '
        Me.tbCancelar.AutoSize = False
        Me.tbCancelar.ImageIndex = 0
        Me.tbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbCancelar.Name = "tbCancelar"
        Me.tbCancelar.Size = New System.Drawing.Size(40, 39)
        Me.tbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbCancelar.ToolTipText = "Cancelar a Ordenacao"
        '
        'tbExcluir
        '
        Me.tbExcluir.AutoSize = False
        Me.tbExcluir.ImageIndex = 3
        Me.tbExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbExcluir.Name = "tbExcluir"
        Me.tbExcluir.Size = New System.Drawing.Size(40, 39)
        Me.tbExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbExcluir.ToolTipText = "Excluir o Comercial com Baixa"
        '
        'tbUsuario
        '
        Me.tbUsuario.AutoSize = False
        Me.tbUsuario.ImageIndex = 9
        Me.tbUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(40, 39)
        Me.tbUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbUsuario.ToolTipText = "Usuários em Operação"
        '
        'tbConsistencia
        '
        Me.tbConsistencia.AutoSize = False
        Me.tbConsistencia.ImageIndex = 8
        Me.tbConsistencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbConsistencia.Name = "tbConsistencia"
        Me.tbConsistencia.Size = New System.Drawing.Size(40, 39)
        Me.tbConsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbConsistencia.ToolTipText = "Consistir a Ordenação"
        '
        'tbSair
        '
        Me.tbSair.AutoSize = False
        Me.tbSair.ImageIndex = 4
        Me.tbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tbSair.Name = "tbSair"
        Me.tbSair.Size = New System.Drawing.Size(40, 39)
        Me.tbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tbSair.ToolTipText = "Sair"
        '
        '_Label2_3
        '
        Me._Label2_3.AutoSize = True
        Me._Label2_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_3, CType(3, Short))
        Me._Label2_3.Location = New System.Drawing.Point(0, 0)
        Me._Label2_3.Name = "_Label2_3"
        Me._Label2_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_3.Size = New System.Drawing.Size(82, 14)
        Me._Label2_3.TabIndex = 48
        Me._Label2_3.Text = "Inicio Gravação"
        '
        '_Label2_2
        '
        Me._Label2_2.AutoSize = True
        Me._Label2_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_2, CType(2, Short))
        Me._Label2_2.Location = New System.Drawing.Point(0, 0)
        Me._Label2_2.Name = "_Label2_2"
        Me._Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_2.Size = New System.Drawing.Size(82, 14)
        Me._Label2_2.TabIndex = 47
        Me._Label2_2.Text = "Inicio Gravação"
        '
        'cmdCancela
        '
        '
        'cmdStatusOk
        '
        '
        'flxBreak
        '
        '
        'flxDisponivel
        '
        '
        'fraProgramacao
        '
        Me.fraProgramacao.BackColor = System.Drawing.SystemColors.Control
        Me.fraProgramacao.Controls.Add(Me.lblCoordenadas)
        Me.fraProgramacao.Controls.Add(Me.ucVeiculo)
        Me.fraProgramacao.Controls.Add(Me.UcData)
        Me.fraProgramacao.Controls.Add(Me.Label1)
        Me.fraProgramacao.Controls.Add(Me.cmdOkProgramacao)
        Me.fraProgramacao.Location = New System.Drawing.Point(290, -2)
        Me.fraProgramacao.Name = "fraProgramacao"
        Me.fraProgramacao.Size = New System.Drawing.Size(660, 43)
        Me.fraProgramacao.TabIndex = 56
        Me.fraProgramacao.TabStop = False
        '
        'lblCoordenadas
        '
        Me.lblCoordenadas.AutoSize = True
        Me.lblCoordenadas.Location = New System.Drawing.Point(338, 16)
        Me.lblCoordenadas.Name = "lblCoordenadas"
        Me.lblCoordenadas.Size = New System.Drawing.Size(39, 14)
        Me.lblCoordenadas.TabIndex = 57
        Me.lblCoordenadas.Text = "Label4"
        Me.lblCoordenadas.Visible = False
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(6, 12)
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
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy ddd"
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(448, 12)
        Me.UcData.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcData.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcData.Name = "UcData"
        Me.UcData.Permite_Futuro = True
        Me.UcData.Permite_Limpar = True
        Me.UcData.Permite_Passado = True
        Me.UcData.Preenchimento_Obrigatorio = False
        Me.UcData.Size = New System.Drawing.Size(145, 25)
        Me.UcData.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(413, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Data"
        '
        'cmdOkProgramacao
        '
        Me.cmdOkProgramacao.Location = New System.Drawing.Point(607, 12)
        Me.cmdOkProgramacao.Name = "cmdOkProgramacao"
        Me.cmdOkProgramacao.Size = New System.Drawing.Size(47, 25)
        Me.cmdOkProgramacao.TabIndex = 15
        Me.cmdOkProgramacao.Text = "&Ok"
        Me.cmdOkProgramacao.UseVisualStyleBackColor = True
        '
        'frmRoteiroV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(978, 503)
        Me.Controls.Add(Me.fraProgramacao)
        Me.Controls.Add(Me.picCorte)
        Me.Controls.Add(Me.picStatus)
        Me.Controls.Add(Me.picBreak)
        Me.Controls.Add(Me.tbOpcoes)
        Me.Controls.Add(Me._Label2_3)
        Me.Controls.Add(Me._Label2_2)
        Me.Controls.Add(Me.picDisponivel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(117, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoteiroV2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Ordenação do Roteiro (Diária)"
        Me.picCorte.ResumeLayout(False)
        CType(Me._Picture1_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxCorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picStatus.ResumeLayout(False)
        Me.picMensagem.ResumeLayout(False)
        CType(Me.flxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frame1.ResumeLayout(False)
        Me.frame1.PerformLayout()
        Me.picDisponivel.ResumeLayout(False)
        Me.picDisponivel.PerformLayout()
        CType(Me._flxDisponivel_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flxDisponivel_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flxDisponivel_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flxDisponivel_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flxDisponivel_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flxDisponivel_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDisponiveis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picBreak.ResumeLayout(False)
        CType(Me._flxBreak_0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOpcoes.ResumeLayout(False)
        Me.tbOpcoes.PerformLayout()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdStatusOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxBreak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxDisponivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDragOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraProgramacao.ResumeLayout(False)
        Me.fraProgramacao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fraProgramacao As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOkProgramacao As System.Windows.Forms.Button
    Public WithEvents picMensagem As System.Windows.Forms.Panel
    Public WithEvents lblMensagem As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents chkSalvar As System.Windows.Forms.CheckBox
    Public WithEvents chkConcorrencia As System.Windows.Forms.CheckBox
    Public WithEvents txtTipoIntervalo As System.Windows.Forms.TextBox
    Friend WithEvents lblTamanhoColuna As System.Windows.Forms.Label
    Public WithEvents tabDisponiveis As AxComctlLib.AxTabStrip
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents lblCoordenadas As System.Windows.Forms.Label
#End Region
End Class