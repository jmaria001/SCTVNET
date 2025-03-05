<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmIntegraPlayList_Afiliada
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
	Public WithEvents picMarcado As System.Windows.Forms.PictureBox
	Public WithEvents picDesmarcado As System.Windows.Forms.PictureBox
	Public WithEvents cmdAlterarParametro As System.Windows.Forms.Button
	Public WithEvents _cmdCancela_1 As System.Windows.Forms.Button
	Public WithEvents _cmdCancela_0 As System.Windows.Forms.Button
	Public WithEvents cmdOkParametro As System.Windows.Forms.Button
	Public WithEvents txtFitaTamanho As System.Windows.Forms.TextBox
	Public WithEvents txtFitaPosicao As System.Windows.Forms.TextBox
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents txtArquivo As System.Windows.Forms.TextBox
	Public WithEvents cmdDiretorio As System.Windows.Forms.Button
	Public WithEvents txtDiretorio As System.Windows.Forms.TextBox
	Public WithEvents cboSistemaExibicao As System.Windows.Forms.ComboBox
	Public WithEvents _lblCampos_2 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_1 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_0 As System.Windows.Forms.Label
	Public WithEvents lblExemplo As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_6 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_42 As System.Windows.Forms.Label
	Public WithEvents _lblCampos_8 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents lblParametro As System.Windows.Forms.Label
	Public WithEvents picParametro As System.Windows.Forms.Panel
    Public WithEvents flxVeiculo As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents fraOpcoes As System.Windows.Forms.GroupBox
	Public WithEvents cmdGerarArquivo As System.Windows.Forms.Button
	Public WithEvents cmdSair As System.Windows.Forms.Button
	Public WithEvents lblDiretorio As System.Windows.Forms.Label
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents cmdCancela As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntegraPlayList_Afiliada))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picMarcado = New System.Windows.Forms.PictureBox
        Me.picDesmarcado = New System.Windows.Forms.PictureBox
        Me.cmdAlterarParametro = New System.Windows.Forms.Button
        Me.picParametro = New System.Windows.Forms.Panel
        Me._cmdCancela_1 = New System.Windows.Forms.Button
        Me._cmdCancela_0 = New System.Windows.Forms.Button
        Me.cmdOkParametro = New System.Windows.Forms.Button
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.txtFitaTamanho = New System.Windows.Forms.TextBox
        Me.txtFitaPosicao = New System.Windows.Forms.TextBox
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.txtArquivo = New System.Windows.Forms.TextBox
        Me.cmdDiretorio = New System.Windows.Forms.Button
        Me.txtDiretorio = New System.Windows.Forms.TextBox
        Me.cboSistemaExibicao = New System.Windows.Forms.ComboBox
        Me._lblCampos_2 = New System.Windows.Forms.Label
        Me._lblCampos_1 = New System.Windows.Forms.Label
        Me._lblCampos_0 = New System.Windows.Forms.Label
        Me.lblExemplo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me._lblCampos_6 = New System.Windows.Forms.Label
        Me._lblCampos_42 = New System.Windows.Forms.Label
        Me._lblCampos_8 = New System.Windows.Forms.Label
        Me.lblParametro = New System.Windows.Forms.Label
        Me.fraOpcoes = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ucPrograma2 = New WUC.UcText
        Me.ucPrograma1 = New WUC.UcText
        Me.UcData = New WCL_SCTV.UC.UCData
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.flxVeiculo = New AxMSFlexGridLib.AxMSFlexGrid
        Me._lblCampos_9 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.cmdGerarArquivo = New System.Windows.Forms.Button
        Me.cmdSair = New System.Windows.Forms.Button
        Me.lblDiretorio = New System.Windows.Forms.Label
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdCancela = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        CType(Me.picMarcado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesmarcado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picParametro.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraOpcoes.SuspendLayout()
        CType(Me.flxVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMarcado
        '
        Me.picMarcado.BackColor = System.Drawing.SystemColors.Window
        Me.picMarcado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMarcado.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMarcado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picMarcado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picMarcado.Image = CType(resources.GetObject("picMarcado.Image"), System.Drawing.Image)
        Me.picMarcado.Location = New System.Drawing.Point(205, 362)
        Me.picMarcado.Name = "picMarcado"
        Me.picMarcado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picMarcado.Size = New System.Drawing.Size(14, 13)
        Me.picMarcado.TabIndex = 44
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
        Me.picDesmarcado.Location = New System.Drawing.Point(226, 362)
        Me.picDesmarcado.Name = "picDesmarcado"
        Me.picDesmarcado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picDesmarcado.Size = New System.Drawing.Size(14, 13)
        Me.picDesmarcado.TabIndex = 43
        Me.picDesmarcado.TabStop = False
        Me.picDesmarcado.Visible = False
        '
        'cmdAlterarParametro
        '
        Me.cmdAlterarParametro.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAlterarParametro.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAlterarParametro.Enabled = False
        Me.cmdAlterarParametro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlterarParametro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlterarParametro.Location = New System.Drawing.Point(12, 354)
        Me.cmdAlterarParametro.Name = "cmdAlterarParametro"
        Me.cmdAlterarParametro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlterarParametro.Size = New System.Drawing.Size(116, 37)
        Me.cmdAlterarParametro.TabIndex = 42
        Me.cmdAlterarParametro.Text = "&Alterar Parametros"
        Me.cmdAlterarParametro.UseVisualStyleBackColor = False
        '
        'picParametro
        '
        Me.picParametro.BackColor = System.Drawing.SystemColors.Control
        Me.picParametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParametro.Controls.Add(Me._cmdCancela_1)
        Me.picParametro.Controls.Add(Me._cmdCancela_0)
        Me.picParametro.Controls.Add(Me.cmdOkParametro)
        Me.picParametro.Controls.Add(Me.Frame3)
        Me.picParametro.Controls.Add(Me.lblParametro)
        Me.picParametro.Cursor = System.Windows.Forms.Cursors.Default
        Me.picParametro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picParametro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picParametro.Location = New System.Drawing.Point(89, 20)
        Me.picParametro.Name = "picParametro"
        Me.picParametro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picParametro.Size = New System.Drawing.Size(469, 199)
        Me.picParametro.TabIndex = 24
        Me.picParametro.TabStop = True
        Me.picParametro.Visible = False
        '
        '_cmdCancela_1
        '
        Me._cmdCancela_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_1, CType(1, Short))
        Me._cmdCancela_1.Location = New System.Drawing.Point(444, 0)
        Me._cmdCancela_1.Name = "_cmdCancela_1"
        Me._cmdCancela_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_1.Size = New System.Drawing.Size(19, 16)
        Me._cmdCancela_1.TabIndex = 31
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
        Me._cmdCancela_0.Location = New System.Drawing.Point(381, 242)
        Me._cmdCancela_0.Name = "_cmdCancela_0"
        Me._cmdCancela_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_0.Size = New System.Drawing.Size(73, 25)
        Me._cmdCancela_0.TabIndex = 30
        Me._cmdCancela_0.TabStop = False
        Me._cmdCancela_0.Text = "&Cancela"
        Me._cmdCancela_0.UseVisualStyleBackColor = False
        '
        'cmdOkParametro
        '
        Me.cmdOkParametro.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOkParametro.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOkParametro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkParametro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOkParametro.Location = New System.Drawing.Point(285, 242)
        Me.cmdOkParametro.Name = "cmdOkParametro"
        Me.cmdOkParametro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOkParametro.Size = New System.Drawing.Size(73, 25)
        Me.cmdOkParametro.TabIndex = 29
        Me.cmdOkParametro.Text = "&Ok"
        Me.cmdOkParametro.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Controls.Add(Me.txtFitaTamanho)
        Me.Frame3.Controls.Add(Me.txtFitaPosicao)
        Me.Frame3.Controls.Add(Me.Picture1)
        Me.Frame3.Controls.Add(Me.txtArquivo)
        Me.Frame3.Controls.Add(Me.cmdDiretorio)
        Me.Frame3.Controls.Add(Me.txtDiretorio)
        Me.Frame3.Controls.Add(Me.cboSistemaExibicao)
        Me.Frame3.Controls.Add(Me._lblCampos_2)
        Me.Frame3.Controls.Add(Me._lblCampos_1)
        Me.Frame3.Controls.Add(Me._lblCampos_0)
        Me.Frame3.Controls.Add(Me.lblExemplo)
        Me.Frame3.Controls.Add(Me._lblCampos_6)
        Me.Frame3.Controls.Add(Me._lblCampos_42)
        Me.Frame3.Controls.Add(Me._lblCampos_8)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(9, 24)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(448, 201)
        Me.Frame3.TabIndex = 25
        Me.Frame3.TabStop = False
        '
        'txtFitaTamanho
        '
        Me.txtFitaTamanho.AcceptsReturn = True
        Me.txtFitaTamanho.BackColor = System.Drawing.SystemColors.Window
        Me.txtFitaTamanho.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFitaTamanho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFitaTamanho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFitaTamanho.Location = New System.Drawing.Point(374, 96)
        Me.txtFitaTamanho.MaxLength = 0
        Me.txtFitaTamanho.Name = "txtFitaTamanho"
        Me.txtFitaTamanho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFitaTamanho.Size = New System.Drawing.Size(64, 20)
        Me.txtFitaTamanho.TabIndex = 38
        '
        'txtFitaPosicao
        '
        Me.txtFitaPosicao.AcceptsReturn = True
        Me.txtFitaPosicao.BackColor = System.Drawing.SystemColors.Window
        Me.txtFitaPosicao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFitaPosicao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFitaPosicao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFitaPosicao.Location = New System.Drawing.Point(188, 96)
        Me.txtFitaPosicao.MaxLength = 0
        Me.txtFitaPosicao.Name = "txtFitaPosicao"
        Me.txtFitaPosicao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFitaPosicao.Size = New System.Drawing.Size(64, 20)
        Me.txtFitaPosicao.TabIndex = 37
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.Location = New System.Drawing.Point(15, 129)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(37, 37)
        Me.Picture1.TabIndex = 41
        Me.Picture1.TabStop = False
        '
        'txtArquivo
        '
        Me.txtArquivo.AcceptsReturn = True
        Me.txtArquivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtArquivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtArquivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtArquivo.Location = New System.Drawing.Point(189, 66)
        Me.txtArquivo.MaxLength = 0
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtArquivo.Size = New System.Drawing.Size(250, 20)
        Me.txtArquivo.TabIndex = 36
        '
        'cmdDiretorio
        '
        Me.cmdDiretorio.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDiretorio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDiretorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiretorio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDiretorio.Location = New System.Drawing.Point(423, 39)
        Me.cmdDiretorio.Name = "cmdDiretorio"
        Me.cmdDiretorio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDiretorio.Size = New System.Drawing.Size(19, 22)
        Me.cmdDiretorio.TabIndex = 35
        Me.cmdDiretorio.TabStop = False
        Me.cmdDiretorio.Text = "..."
        Me.cmdDiretorio.UseVisualStyleBackColor = False
        '
        'txtDiretorio
        '
        Me.txtDiretorio.AcceptsReturn = True
        Me.txtDiretorio.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiretorio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiretorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiretorio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiretorio.Location = New System.Drawing.Point(189, 39)
        Me.txtDiretorio.MaxLength = 0
        Me.txtDiretorio.Name = "txtDiretorio"
        Me.txtDiretorio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiretorio.Size = New System.Drawing.Size(232, 20)
        Me.txtDiretorio.TabIndex = 34
        '
        'cboSistemaExibicao
        '
        Me.cboSistemaExibicao.BackColor = System.Drawing.SystemColors.Window
        Me.cboSistemaExibicao.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSistemaExibicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSistemaExibicao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSistemaExibicao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSistemaExibicao.Location = New System.Drawing.Point(189, 12)
        Me.cboSistemaExibicao.Name = "cboSistemaExibicao"
        Me.cboSistemaExibicao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSistemaExibicao.Size = New System.Drawing.Size(253, 22)
        Me.cboSistemaExibicao.TabIndex = 33
        '
        '_lblCampos_2
        '
        Me._lblCampos_2.AutoSize = True
        Me._lblCampos_2.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_2.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_2, CType(2, Short))
        Me._lblCampos_2.Location = New System.Drawing.Point(327, 102)
        Me._lblCampos_2.Name = "_lblCampos_2"
        Me._lblCampos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_2.Size = New System.Drawing.Size(51, 14)
        Me._lblCampos_2.TabIndex = 51
        Me._lblCampos_2.Text = "Tamanho"
        '
        '_lblCampos_1
        '
        Me._lblCampos_1.AutoSize = True
        Me._lblCampos_1.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_1.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_1, CType(1, Short))
        Me._lblCampos_1.Location = New System.Drawing.Point(144, 99)
        Me._lblCampos_1.Name = "_lblCampos_1"
        Me._lblCampos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_1.Size = New System.Drawing.Size(45, 14)
        Me._lblCampos_1.TabIndex = 50
        Me._lblCampos_1.Text = "Posicao"
        '
        '_lblCampos_0
        '
        Me._lblCampos_0.AutoSize = True
        Me._lblCampos_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_0.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_0, CType(0, Short))
        Me._lblCampos_0.Location = New System.Drawing.Point(10, 99)
        Me._lblCampos_0.Name = "_lblCampos_0"
        Me._lblCampos_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_0.Size = New System.Drawing.Size(117, 14)
        Me._lblCampos_0.TabIndex = 49
        Me._lblCampos_0.Text = "Configuracao de N.Fita"
        '
        'lblExemplo
        '
        Me.lblExemplo.AutoSize = True
        Me.lblExemplo.BackColor = System.Drawing.SystemColors.Control
        Me.lblExemplo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblExemplo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExemplo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblExemplo.Location = New System.Drawing.Point(54, 175)
        Me.lblExemplo.Name = "lblExemplo"
        Me.lblExemplo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblExemplo.Size = New System.Drawing.Size(96, 14)
        Me.lblExemplo.TabIndex = 40
        Me.lblExemplo.Text = "Ex: SP151101.TXT"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(54, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(384, 45)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "O nome do arquivo é opcional e quando não informado, o sistema cria o arquivo com" & _
            " o nome composto pela sigla do veiculo mais a data da Programação."
        '
        '_lblCampos_6
        '
        Me._lblCampos_6.AutoSize = True
        Me._lblCampos_6.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_6.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_6, CType(6, Short))
        Me._lblCampos_6.Location = New System.Drawing.Point(10, 17)
        Me._lblCampos_6.Name = "_lblCampos_6"
        Me._lblCampos_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_6.Size = New System.Drawing.Size(134, 14)
        Me._lblCampos_6.TabIndex = 28
        Me._lblCampos_6.Text = "Sistema de Exibicao Digital"
        '
        '_lblCampos_42
        '
        Me._lblCampos_42.AutoSize = True
        Me._lblCampos_42.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_42.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_42.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_42, CType(42, Short))
        Me._lblCampos_42.Location = New System.Drawing.Point(10, 72)
        Me._lblCampos_42.Name = "_lblCampos_42"
        Me._lblCampos_42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_42.Size = New System.Drawing.Size(172, 14)
        Me._lblCampos_42.TabIndex = 27
        Me._lblCampos_42.Text = "Nome do Arquivo para Integracao "
        '
        '_lblCampos_8
        '
        Me._lblCampos_8.AutoSize = True
        Me._lblCampos_8.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_8.ForeColor = System.Drawing.Color.Black
        Me.lblCampos.SetIndex(Me._lblCampos_8, CType(8, Short))
        Me._lblCampos_8.Location = New System.Drawing.Point(10, 45)
        Me._lblCampos_8.Name = "_lblCampos_8"
        Me._lblCampos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_8.Size = New System.Drawing.Size(126, 14)
        Me._lblCampos_8.TabIndex = 26
        Me._lblCampos_8.Text = "Diretorio para Integração"
        '
        'lblParametro
        '
        Me.lblParametro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblParametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParametro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblParametro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParametro.ForeColor = System.Drawing.Color.White
        Me.lblParametro.Location = New System.Drawing.Point(0, 0)
        Me.lblParametro.Name = "lblParametro"
        Me.lblParametro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblParametro.Size = New System.Drawing.Size(530, 19)
        Me.lblParametro.TabIndex = 32
        Me.lblParametro.Text = "  Parametros para Integração"
        '
        'fraOpcoes
        '
        Me.fraOpcoes.BackColor = System.Drawing.SystemColors.Control
        Me.fraOpcoes.Controls.Add(Me.Label4)
        Me.fraOpcoes.Controls.Add(Me.Label2)
        Me.fraOpcoes.Controls.Add(Me.ucPrograma2)
        Me.fraOpcoes.Controls.Add(Me.ucPrograma1)
        Me.fraOpcoes.Controls.Add(Me.UcData)
        Me.fraOpcoes.Controls.Add(Me.cboPeriodo)
        Me.fraOpcoes.Controls.Add(Me.flxVeiculo)
        Me.fraOpcoes.Controls.Add(Me._lblCampos_9)
        Me.fraOpcoes.Controls.Add(Me._Label1_0)
        Me.fraOpcoes.Controls.Add(Me.picParametro)
        Me.fraOpcoes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraOpcoes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraOpcoes.Location = New System.Drawing.Point(4, 6)
        Me.fraOpcoes.Name = "fraOpcoes"
        Me.fraOpcoes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraOpcoes.Size = New System.Drawing.Size(577, 339)
        Me.fraOpcoes.TabIndex = 6
        Me.fraOpcoes.TabStop = False
        Me.fraOpcoes.Text = "Veículos"
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Terminar no"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Iniciar no"
        '
        'ucPrograma2
        '
        Me.ucPrograma2.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma2.Caption = "Programa"
        Me.ucPrograma2.DataTextValue = Nothing
        Me.ucPrograma2.Location = New System.Drawing.Point(75, 267)
        Me.ucPrograma2.MaxLength = 4
        Me.ucPrograma2.Name = "ucPrograma2"
        Me.ucPrograma2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma2.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma2.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma2.pDecimal = CType(0, Byte)
        Me.ucPrograma2.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma2.showButton = True
        Me.ucPrograma2.ShowDescricao = True
        Me.ucPrograma2.Size = New System.Drawing.Size(483, 25)
        Me.ucPrograma2.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma2.TabIndex = 56
        Me.ucPrograma2.TextBoxLeft = CType(60, Short)
        Me.ucPrograma2.TextWidth = 0
        '
        'ucPrograma1
        '
        Me.ucPrograma1.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma1.Caption = "Programa"
        Me.ucPrograma1.DataTextValue = Nothing
        Me.ucPrograma1.Location = New System.Drawing.Point(63, 225)
        Me.ucPrograma1.MaxLength = 4
        Me.ucPrograma1.Name = "ucPrograma1"
        Me.ucPrograma1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma1.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma1.pDecimal = CType(0, Byte)
        Me.ucPrograma1.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma1.showButton = True
        Me.ucPrograma1.ShowDescricao = True
        Me.ucPrograma1.Size = New System.Drawing.Size(495, 25)
        Me.ucPrograma1.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma1.TabIndex = 55
        Me.ucPrograma1.TextBoxLeft = CType(70, Short)
        Me.ucPrograma1.TextWidth = 0
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy ddd"
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(133, 183)
        Me.UcData.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcData.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcData.Name = "UcData"
        Me.UcData.Permite_Futuro = True
        Me.UcData.Permite_Limpar = True
        Me.UcData.Permite_Passado = True
        Me.UcData.Preenchimento_Obrigatorio = False
        Me.UcData.Size = New System.Drawing.Size(135, 25)
        Me.UcData.TabIndex = 54
        '
        'cboPeriodo
        '
        Me.cboPeriodo.BackColor = System.Drawing.SystemColors.Window
        Me.cboPeriodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPeriodo.Items.AddRange(New Object() {"Dia Inteiro", "Manha", "Tarde", "Noite"})
        Me.cboPeriodo.Location = New System.Drawing.Point(400, 181)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPeriodo.Size = New System.Drawing.Size(138, 22)
        Me.cboPeriodo.TabIndex = 52
        Me.cboPeriodo.Visible = False
        '
        'flxVeiculo
        '
        Me.flxVeiculo.Location = New System.Drawing.Point(15, 15)
        Me.flxVeiculo.Name = "flxVeiculo"
        Me.flxVeiculo.OcxState = CType(resources.GetObject("flxVeiculo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxVeiculo.Size = New System.Drawing.Size(559, 151)
        Me.flxVeiculo.TabIndex = 0
        '
        '_lblCampos_9
        '
        Me._lblCampos_9.AutoSize = True
        Me._lblCampos_9.BackColor = System.Drawing.SystemColors.Control
        Me._lblCampos_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblCampos_9.Location = New System.Drawing.Point(351, 183)
        Me._lblCampos_9.Name = "_lblCampos_9"
        Me._lblCampos_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_9.Size = New System.Drawing.Size(43, 14)
        Me._lblCampos_9.TabIndex = 53
        Me._lblCampos_9.Text = "Periodo"
        Me._lblCampos_9.Visible = False
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(13, 186)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(114, 13)
        Me._Label1_0.TabIndex = 22
        Me._Label1_0.Text = "Data da Programação"
        '
        'cmdGerarArquivo
        '
        Me.cmdGerarArquivo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGerarArquivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGerarArquivo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGerarArquivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGerarArquivo.Location = New System.Drawing.Point(394, 351)
        Me.cmdGerarArquivo.Name = "cmdGerarArquivo"
        Me.cmdGerarArquivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGerarArquivo.Size = New System.Drawing.Size(109, 37)
        Me.cmdGerarArquivo.TabIndex = 4
        Me.cmdGerarArquivo.Text = "&Gerar Arquivos"
        Me.cmdGerarArquivo.UseVisualStyleBackColor = False
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(509, 351)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(76, 37)
        Me.cmdSair.TabIndex = 5
        Me.cmdSair.TabStop = False
        Me.cmdSair.Text = "Sai&r"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'lblDiretorio
        '
        Me.lblDiretorio.AutoSize = True
        Me.lblDiretorio.BackColor = System.Drawing.SystemColors.Control
        Me.lblDiretorio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDiretorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiretorio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDiretorio.Location = New System.Drawing.Point(9, 206)
        Me.lblDiretorio.Name = "lblDiretorio"
        Me.lblDiretorio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiretorio.Size = New System.Drawing.Size(0, 14)
        Me.lblDiretorio.TabIndex = 21
        '
        'cmdCancela
        '
        '
        'frmIntegraPlayList_Afiliada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(596, 408)
        Me.Controls.Add(Me.picMarcado)
        Me.Controls.Add(Me.picDesmarcado)
        Me.Controls.Add(Me.cmdAlterarParametro)
        Me.Controls.Add(Me.cmdGerarArquivo)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.lblDiretorio)
        Me.Controls.Add(Me.fraOpcoes)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(194, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIntegraPlayList_Afiliada"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Integração com Exibicão Digital"
        CType(Me.picMarcado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesmarcado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picParametro.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraOpcoes.ResumeLayout(False)
        Me.fraOpcoes.PerformLayout()
        CType(Me.flxVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents ucPrograma1 As WUC.UcText
    Friend WithEvents ucPrograma2 As WUC.UcText
    Public WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Public WithEvents _lblCampos_9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
#End Region
End Class