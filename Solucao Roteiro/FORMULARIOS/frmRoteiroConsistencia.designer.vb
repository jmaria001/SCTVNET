<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRoteiroConsistencia
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Me.MdiParent = Roteiro.mdiPrincipal
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
        Me.MdiParent = mdiPrincipal
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtForm As System.Windows.Forms.TextBox
	Public WithEvents chkOrdenacao As System.Windows.Forms.CheckBox
	Public WithEvents chkRoteiroGravado As System.Windows.Forms.CheckBox
	Public WithEvents txtHorarioPrograma As System.Windows.Forms.TextBox
	Public WithEvents txtInicioProgramacao As System.Windows.Forms.TextBox
	Public WithEvents txtPrograma As System.Windows.Forms.TextBox
	Public WithEvents txtData As System.Windows.Forms.TextBox
	Public WithEvents txtVeiculo As System.Windows.Forms.TextBox
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Public WithEvents ImageList2 As AxComctlLib.AxImageList
    Public WithEvents _Label1_4 As System.Windows.Forms.Label
    Public WithEvents _Label1_3 As System.Windows.Forms.Label
    Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents _Data_1 As System.Windows.Forms.Label
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents flxNaoOrdenados As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents _fraConsistencia_5 As System.Windows.Forms.GroupBox
    Public WithEvents cmdEncerramento As System.Windows.Forms.Button
    Public WithEvents cmdSair As System.Windows.Forms.Button
    Public WithEvents flxRestricao As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents _fraConsistencia_4 As System.Windows.Forms.GroupBox
    Public WithEvents flxConcorrencia As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents _fraConsistencia_2 As System.Windows.Forms.GroupBox
    Public WithEvents flxFitaPendente As axMSFlexGridLib.axMSFlexGrid
    Public WithEvents _fraConsistencia_3 As System.Windows.Forms.GroupBox
    Public WithEvents flxOcupacao As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents _fraConsistencia_1 As System.Windows.Forms.GroupBox
    Public WithEvents Data As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents cmdCancelaFechamento As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents fraConsistencia As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoteiroConsistencia))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtForm = New System.Windows.Forms.TextBox
        Me.chkOrdenacao = New System.Windows.Forms.CheckBox
        Me.chkRoteiroGravado = New System.Windows.Forms.CheckBox
        Me.txtHorarioPrograma = New System.Windows.Forms.TextBox
        Me.txtInicioProgramacao = New System.Windows.Forms.TextBox
        Me.txtPrograma = New System.Windows.Forms.TextBox
        Me.txtData = New System.Windows.Forms.TextBox
        Me.txtVeiculo = New System.Windows.Forms.TextBox
        Me._Label1_1 = New System.Windows.Forms.Label
        Me.ImageList2 = New AxComctlLib.AxImageList
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Data_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me._fraConsistencia_5 = New System.Windows.Forms.GroupBox
        Me.flxNaoOrdenados = New AxMSFlexGridLib.AxMSFlexGrid
        Me.cmdEncerramento = New System.Windows.Forms.Button
        Me.cmdSair = New System.Windows.Forms.Button
        Me._fraConsistencia_4 = New System.Windows.Forms.GroupBox
        Me.flxRestricao = New AxMSFlexGridLib.AxMSFlexGrid
        Me._fraConsistencia_2 = New System.Windows.Forms.GroupBox
        Me.flxConcorrencia = New AxMSFlexGridLib.AxMSFlexGrid
        Me._fraConsistencia_3 = New System.Windows.Forms.GroupBox
        Me.flxFitaPendente = New AxMSFlexGridLib.AxMSFlexGrid
        Me._fraConsistencia_1 = New System.Windows.Forms.GroupBox
        Me.flxOcupacao = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Data = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdCancelaFechamento = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.fraConsistencia = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.chkIniciar = New System.Windows.Forms.CheckBox
        Me.tabConsistencia = New AxComctlLib.AxTabStrip
        Me.lblParametro = New System.Windows.Forms.Label
        Me._cmdCancelaFechamento_0 = New System.Windows.Forms.Button
        Me.cmdOkFechamento = New System.Windows.Forms.Button
        Me.picEncerramento = New System.Windows.Forms.Panel
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.chkComercial = New System.Windows.Forms.CheckBox
        Me.chkArtistico = New System.Windows.Forms.CheckBox
        Me.chkMostrarNet = New System.Windows.Forms.CheckBox
        Me.chkMostrarLocal = New System.Windows.Forms.CheckBox
        Me.chkMostrarArtistico = New System.Windows.Forms.CheckBox
        Me.chkMostrarInter = New System.Windows.Forms.CheckBox
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._fraConsistencia_5.SuspendLayout()
        CType(Me.flxNaoOrdenados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._fraConsistencia_4.SuspendLayout()
        CType(Me.flxRestricao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._fraConsistencia_2.SuspendLayout()
        CType(Me.flxConcorrencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._fraConsistencia_3.SuspendLayout()
        CType(Me.flxFitaPendente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._fraConsistencia_1.SuspendLayout()
        CType(Me.flxOcupacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancelaFechamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fraConsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabConsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picEncerramento.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtForm)
        Me.Frame1.Controls.Add(Me.chkOrdenacao)
        Me.Frame1.Controls.Add(Me.chkRoteiroGravado)
        Me.Frame1.Controls.Add(Me.txtHorarioPrograma)
        Me.Frame1.Controls.Add(Me.txtInicioProgramacao)
        Me.Frame1.Controls.Add(Me.txtPrograma)
        Me.Frame1.Controls.Add(Me.txtData)
        Me.Frame1.Controls.Add(Me.txtVeiculo)
        Me.Frame1.Controls.Add(Me._Label1_1)
        Me.Frame1.Controls.Add(Me.ImageList2)
        Me.Frame1.Controls.Add(Me._Label1_4)
        Me.Frame1.Controls.Add(Me._Label1_3)
        Me.Frame1.Controls.Add(Me._Label1_2)
        Me.Frame1.Controls.Add(Me._Data_1)
        Me.Frame1.Controls.Add(Me._Label1_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(60, 39)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(415, 181)
        Me.Frame1.TabIndex = 9
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Parametros"
        Me.Frame1.Visible = False
        '
        'txtForm
        '
        Me.txtForm.AcceptsReturn = True
        Me.txtForm.BackColor = System.Drawing.SystemColors.Window
        Me.txtForm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtForm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtForm.Location = New System.Drawing.Point(105, 153)
        Me.txtForm.MaxLength = 0
        Me.txtForm.Name = "txtForm"
        Me.txtForm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtForm.Size = New System.Drawing.Size(94, 20)
        Me.txtForm.TabIndex = 34
        '
        'chkOrdenacao
        '
        Me.chkOrdenacao.BackColor = System.Drawing.SystemColors.Control
        Me.chkOrdenacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOrdenacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrdenacao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOrdenacao.Location = New System.Drawing.Point(219, 78)
        Me.chkOrdenacao.Name = "chkOrdenacao"
        Me.chkOrdenacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOrdenacao.Size = New System.Drawing.Size(172, 19)
        Me.chkOrdenacao.TabIndex = 21
        Me.chkOrdenacao.Text = "Carregar da Tela de Ordenacao"
        Me.chkOrdenacao.UseVisualStyleBackColor = False
        '
        'chkRoteiroGravado
        '
        Me.chkRoteiroGravado.BackColor = System.Drawing.SystemColors.Control
        Me.chkRoteiroGravado.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRoteiroGravado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRoteiroGravado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRoteiroGravado.Location = New System.Drawing.Point(219, 96)
        Me.chkRoteiroGravado.Name = "chkRoteiroGravado"
        Me.chkRoteiroGravado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRoteiroGravado.Size = New System.Drawing.Size(184, 19)
        Me.chkRoteiroGravado.TabIndex = 20
        Me.chkRoteiroGravado.Text = "Carregar do Roteiro Gravado"
        Me.chkRoteiroGravado.UseVisualStyleBackColor = False
        '
        'txtHorarioPrograma
        '
        Me.txtHorarioPrograma.AcceptsReturn = True
        Me.txtHorarioPrograma.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorarioPrograma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorarioPrograma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorarioPrograma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorarioPrograma.Location = New System.Drawing.Point(105, 126)
        Me.txtHorarioPrograma.MaxLength = 0
        Me.txtHorarioPrograma.Name = "txtHorarioPrograma"
        Me.txtHorarioPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorarioPrograma.Size = New System.Drawing.Size(94, 20)
        Me.txtHorarioPrograma.TabIndex = 18
        '
        'txtInicioProgramacao
        '
        Me.txtInicioProgramacao.AcceptsReturn = True
        Me.txtInicioProgramacao.BackColor = System.Drawing.SystemColors.Window
        Me.txtInicioProgramacao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInicioProgramacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioProgramacao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInicioProgramacao.Location = New System.Drawing.Point(105, 100)
        Me.txtInicioProgramacao.MaxLength = 0
        Me.txtInicioProgramacao.Name = "txtInicioProgramacao"
        Me.txtInicioProgramacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInicioProgramacao.Size = New System.Drawing.Size(94, 20)
        Me.txtInicioProgramacao.TabIndex = 16
        '
        'txtPrograma
        '
        Me.txtPrograma.AcceptsReturn = True
        Me.txtPrograma.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrograma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrograma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrograma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrograma.Location = New System.Drawing.Point(105, 74)
        Me.txtPrograma.MaxLength = 0
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrograma.Size = New System.Drawing.Size(94, 20)
        Me.txtPrograma.TabIndex = 14
        '
        'txtData
        '
        Me.txtData.AcceptsReturn = True
        Me.txtData.BackColor = System.Drawing.SystemColors.Window
        Me.txtData.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtData.Location = New System.Drawing.Point(105, 48)
        Me.txtData.MaxLength = 0
        Me.txtData.Name = "txtData"
        Me.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtData.Size = New System.Drawing.Size(94, 20)
        Me.txtData.TabIndex = 12
        '
        'txtVeiculo
        '
        Me.txtVeiculo.AcceptsReturn = True
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Window
        Me.txtVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVeiculo.Location = New System.Drawing.Point(105, 21)
        Me.txtVeiculo.MaxLength = 0
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVeiculo.Size = New System.Drawing.Size(94, 20)
        Me.txtVeiculo.TabIndex = 10
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = True
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(12, 156)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(57, 14)
        Me._Label1_1.TabIndex = 35
        Me._Label1_1.Text = "Formulário"
        '
        'ImageList2
        '
        Me.ImageList2.Enabled = True
        Me.ImageList2.Location = New System.Drawing.Point(261, 27)
        Me.ImageList2.Name = "ImageList2"
        Me.ImageList2.OcxState = CType(resources.GetObject("ImageList2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImageList2.Size = New System.Drawing.Size(38, 38)
        Me.ImageList2.TabIndex = 36
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(9, 129)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(91, 14)
        Me._Label1_4.TabIndex = 19
        Me._Label1_4.Text = "Horario Programa"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(9, 103)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(98, 14)
        Me._Label1_3.TabIndex = 17
        Me._Label1_3.Text = "Inicio Programacao"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(9, 76)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(53, 14)
        Me._Label1_2.TabIndex = 15
        Me._Label1_2.Text = "Programa"
        '
        '_Data_1
        '
        Me._Data_1.AutoSize = True
        Me._Data_1.BackColor = System.Drawing.SystemColors.Control
        Me._Data_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Data_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Data_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Data.SetIndex(Me._Data_1, CType(1, Short))
        Me._Data_1.Location = New System.Drawing.Point(9, 50)
        Me._Data_1.Name = "_Data_1"
        Me._Data_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Data_1.Size = New System.Drawing.Size(29, 14)
        Me._Data_1.TabIndex = 13
        Me._Data_1.Text = "Data"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(9, 24)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(43, 14)
        Me._Label1_0.TabIndex = 11
        Me._Label1_0.Text = "Veiculo"
        '
        '_fraConsistencia_5
        '
        Me._fraConsistencia_5.BackColor = System.Drawing.SystemColors.Control
        Me._fraConsistencia_5.Controls.Add(Me.flxNaoOrdenados)
        Me._fraConsistencia_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fraConsistencia_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraConsistencia.SetIndex(Me._fraConsistencia_5, CType(5, Short))
        Me._fraConsistencia_5.Location = New System.Drawing.Point(357, 246)
        Me._fraConsistencia_5.Name = "_fraConsistencia_5"
        Me._fraConsistencia_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fraConsistencia_5.Size = New System.Drawing.Size(184, 52)
        Me._fraConsistencia_5.TabIndex = 24
        Me._fraConsistencia_5.TabStop = False
        Me._fraConsistencia_5.Text = "Comerciais não Ordenados"
        '
        'flxNaoOrdenados
        '
        Me.flxNaoOrdenados.Location = New System.Drawing.Point(6, 15)
        Me.flxNaoOrdenados.Name = "flxNaoOrdenados"
        Me.flxNaoOrdenados.OcxState = CType(resources.GetObject("flxNaoOrdenados.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxNaoOrdenados.Size = New System.Drawing.Size(505, 346)
        Me.flxNaoOrdenados.TabIndex = 25
        '
        'cmdEncerramento
        '
        Me.cmdEncerramento.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEncerramento.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEncerramento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEncerramento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEncerramento.Location = New System.Drawing.Point(6, 411)
        Me.cmdEncerramento.Name = "cmdEncerramento"
        Me.cmdEncerramento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEncerramento.Size = New System.Drawing.Size(142, 28)
        Me.cmdEncerramento.TabIndex = 23
        Me.cmdEncerramento.Text = "&Encerrar o Roteiro"
        Me.cmdEncerramento.UseVisualStyleBackColor = False
        Me.cmdEncerramento.Visible = False
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(651, 415)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(70, 28)
        Me.cmdSair.TabIndex = 22
        Me.cmdSair.Text = "&Sair"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        '_fraConsistencia_4
        '
        Me._fraConsistencia_4.BackColor = System.Drawing.SystemColors.Control
        Me._fraConsistencia_4.Controls.Add(Me.flxRestricao)
        Me._fraConsistencia_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fraConsistencia_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraConsistencia.SetIndex(Me._fraConsistencia_4, CType(4, Short))
        Me._fraConsistencia_4.Location = New System.Drawing.Point(192, 330)
        Me._fraConsistencia_4.Name = "_fraConsistencia_4"
        Me._fraConsistencia_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fraConsistencia_4.Size = New System.Drawing.Size(154, 52)
        Me._fraConsistencia_4.TabIndex = 7
        Me._fraConsistencia_4.TabStop = False
        Me._fraConsistencia_4.Text = "Restricao de Horario"
        '
        'flxRestricao
        '
        Me.flxRestricao.Location = New System.Drawing.Point(6, 15)
        Me.flxRestricao.Name = "flxRestricao"
        Me.flxRestricao.OcxState = CType(resources.GetObject("flxRestricao.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxRestricao.Size = New System.Drawing.Size(505, 346)
        Me.flxRestricao.TabIndex = 8
        '
        '_fraConsistencia_2
        '
        Me._fraConsistencia_2.BackColor = System.Drawing.SystemColors.Control
        Me._fraConsistencia_2.Controls.Add(Me.flxConcorrencia)
        Me._fraConsistencia_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fraConsistencia_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraConsistencia.SetIndex(Me._fraConsistencia_2, CType(2, Short))
        Me._fraConsistencia_2.Location = New System.Drawing.Point(192, 240)
        Me._fraConsistencia_2.Name = "_fraConsistencia_2"
        Me._fraConsistencia_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fraConsistencia_2.Size = New System.Drawing.Size(154, 52)
        Me._fraConsistencia_2.TabIndex = 5
        Me._fraConsistencia_2.TabStop = False
        Me._fraConsistencia_2.Text = "Choque de Concorrencia"
        '
        'flxConcorrencia
        '
        Me.flxConcorrencia.Location = New System.Drawing.Point(6, 15)
        Me.flxConcorrencia.Name = "flxConcorrencia"
        Me.flxConcorrencia.OcxState = CType(resources.GetObject("flxConcorrencia.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxConcorrencia.Size = New System.Drawing.Size(505, 346)
        Me.flxConcorrencia.TabIndex = 6
        '
        '_fraConsistencia_3
        '
        Me._fraConsistencia_3.BackColor = System.Drawing.SystemColors.Control
        Me._fraConsistencia_3.Controls.Add(Me.flxFitaPendente)
        Me._fraConsistencia_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fraConsistencia_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraConsistencia.SetIndex(Me._fraConsistencia_3, CType(3, Short))
        Me._fraConsistencia_3.Location = New System.Drawing.Point(30, 324)
        Me._fraConsistencia_3.Name = "_fraConsistencia_3"
        Me._fraConsistencia_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fraConsistencia_3.Size = New System.Drawing.Size(154, 52)
        Me._fraConsistencia_3.TabIndex = 3
        Me._fraConsistencia_3.TabStop = False
        Me._fraConsistencia_3.Text = "Fitas a Determinar"
        '
        'flxFitaPendente
        '
        Me.flxFitaPendente.Location = New System.Drawing.Point(6, 15)
        Me.flxFitaPendente.Name = "flxFitaPendente"
        Me.flxFitaPendente.OcxState = CType(resources.GetObject("flxFitaPendente.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxFitaPendente.Size = New System.Drawing.Size(505, 346)
        Me.flxFitaPendente.TabIndex = 4
        '
        '_fraConsistencia_1
        '
        Me._fraConsistencia_1.BackColor = System.Drawing.SystemColors.Control
        Me._fraConsistencia_1.Controls.Add(Me.flxOcupacao)
        Me._fraConsistencia_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fraConsistencia_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraConsistencia.SetIndex(Me._fraConsistencia_1, CType(1, Short))
        Me._fraConsistencia_1.Location = New System.Drawing.Point(27, 234)
        Me._fraConsistencia_1.Name = "_fraConsistencia_1"
        Me._fraConsistencia_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fraConsistencia_1.Size = New System.Drawing.Size(154, 67)
        Me._fraConsistencia_1.TabIndex = 0
        Me._fraConsistencia_1.TabStop = False
        Me._fraConsistencia_1.Text = "Ocupacao dos Espacos"
        '
        'flxOcupacao
        '
        Me.flxOcupacao.Location = New System.Drawing.Point(6, 12)
        Me.flxOcupacao.Name = "flxOcupacao"
        Me.flxOcupacao.OcxState = CType(resources.GetObject("flxOcupacao.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxOcupacao.Size = New System.Drawing.Size(505, 346)
        Me.flxOcupacao.TabIndex = 1
        '
        'cmdCancelaFechamento
        '
        '
        'chkIniciar
        '
        Me.chkIniciar.AutoSize = True
        Me.chkIniciar.Location = New System.Drawing.Point(635, 368)
        Me.chkIniciar.Name = "chkIniciar"
        Me.chkIniciar.Size = New System.Drawing.Size(54, 18)
        Me.chkIniciar.TabIndex = 28
        Me.chkIniciar.Text = "Iniciar"
        Me.chkIniciar.UseVisualStyleBackColor = True
        Me.chkIniciar.Visible = False
        '
        'tabConsistencia
        '
        Me.tabConsistencia.Location = New System.Drawing.Point(6, 9)
        Me.tabConsistencia.Name = "tabConsistencia"
        Me.tabConsistencia.OcxState = CType(resources.GetObject("tabConsistencia.OcxState"), System.Windows.Forms.AxHost.State)
        Me.tabConsistencia.Size = New System.Drawing.Size(715, 397)
        Me.tabConsistencia.TabIndex = 2
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
        Me.lblParametro.Size = New System.Drawing.Size(512, 19)
        Me.lblParametro.TabIndex = 31
        Me.lblParametro.Text = "  Encerramento do Roteiro"
        '
        '_cmdCancelaFechamento_0
        '
        Me._cmdCancelaFechamento_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancelaFechamento_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancelaFechamento_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancelaFechamento_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdCancelaFechamento_0.Location = New System.Drawing.Point(153, 126)
        Me._cmdCancelaFechamento_0.Name = "_cmdCancelaFechamento_0"
        Me._cmdCancelaFechamento_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancelaFechamento_0.Size = New System.Drawing.Size(73, 25)
        Me._cmdCancelaFechamento_0.TabIndex = 28
        Me._cmdCancelaFechamento_0.TabStop = False
        Me._cmdCancelaFechamento_0.Text = "&Cancela"
        Me._cmdCancelaFechamento_0.UseVisualStyleBackColor = False
        '
        'cmdOkFechamento
        '
        Me.cmdOkFechamento.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOkFechamento.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOkFechamento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkFechamento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOkFechamento.Location = New System.Drawing.Point(57, 126)
        Me.cmdOkFechamento.Name = "cmdOkFechamento"
        Me.cmdOkFechamento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOkFechamento.Size = New System.Drawing.Size(73, 25)
        Me.cmdOkFechamento.TabIndex = 29
        Me.cmdOkFechamento.Text = "&Ok"
        Me.cmdOkFechamento.UseVisualStyleBackColor = False
        '
        'picEncerramento
        '
        Me.picEncerramento.BackColor = System.Drawing.SystemColors.Control
        Me.picEncerramento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEncerramento.Controls.Add(Me.Frame3)
        Me.picEncerramento.Controls.Add(Me.cmdOkFechamento)
        Me.picEncerramento.Controls.Add(Me._cmdCancelaFechamento_0)
        Me.picEncerramento.Controls.Add(Me.lblParametro)
        Me.picEncerramento.Cursor = System.Windows.Forms.Cursors.Default
        Me.picEncerramento.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picEncerramento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picEncerramento.Location = New System.Drawing.Point(12, 234)
        Me.picEncerramento.Name = "picEncerramento"
        Me.picEncerramento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picEncerramento.Size = New System.Drawing.Size(247, 161)
        Me.picEncerramento.TabIndex = 27
        Me.picEncerramento.TabStop = True
        Me.picEncerramento.Visible = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.chkComercial)
        Me.Frame3.Controls.Add(Me.chkArtistico)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(9, 21)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(223, 95)
        Me.Frame3.TabIndex = 30
        Me.Frame3.TabStop = False
        '
        'chkComercial
        '
        Me.chkComercial.BackColor = System.Drawing.SystemColors.Control
        Me.chkComercial.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkComercial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComercial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkComercial.Location = New System.Drawing.Point(21, 60)
        Me.chkComercial.Name = "chkComercial"
        Me.chkComercial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkComercial.Size = New System.Drawing.Size(178, 16)
        Me.chkComercial.TabIndex = 33
        Me.chkComercial.Text = "Encerramento Comercial"
        Me.chkComercial.UseVisualStyleBackColor = False
        '
        'chkArtistico
        '
        Me.chkArtistico.BackColor = System.Drawing.SystemColors.Control
        Me.chkArtistico.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkArtistico.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArtistico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkArtistico.Location = New System.Drawing.Point(21, 24)
        Me.chkArtistico.Name = "chkArtistico"
        Me.chkArtistico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkArtistico.Size = New System.Drawing.Size(178, 16)
        Me.chkArtistico.TabIndex = 32
        Me.chkArtistico.Text = "Encerramento Artistico"
        Me.chkArtistico.UseVisualStyleBackColor = False
        '
        'chkMostrarNet
        '
        Me.chkMostrarNet.AutoSize = True
        Me.chkMostrarNet.Checked = True
        Me.chkMostrarNet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarNet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarNet.ForeColor = System.Drawing.Color.Fuchsia
        Me.chkMostrarNet.Location = New System.Drawing.Point(175, 421)
        Me.chkMostrarNet.Name = "chkMostrarNet"
        Me.chkMostrarNet.Size = New System.Drawing.Size(46, 18)
        Me.chkMostrarNet.TabIndex = 29
        Me.chkMostrarNet.Text = "NET"
        Me.chkMostrarNet.UseVisualStyleBackColor = True
        '
        'chkMostrarLocal
        '
        Me.chkMostrarLocal.AutoSize = True
        Me.chkMostrarLocal.Checked = True
        Me.chkMostrarLocal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarLocal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarLocal.ForeColor = System.Drawing.Color.Blue
        Me.chkMostrarLocal.Location = New System.Drawing.Point(227, 421)
        Me.chkMostrarLocal.Name = "chkMostrarLocal"
        Me.chkMostrarLocal.Size = New System.Drawing.Size(55, 18)
        Me.chkMostrarLocal.TabIndex = 30
        Me.chkMostrarLocal.Text = "Local"
        Me.chkMostrarLocal.UseVisualStyleBackColor = True
        '
        'chkMostrarArtistico
        '
        Me.chkMostrarArtistico.AutoSize = True
        Me.chkMostrarArtistico.Checked = True
        Me.chkMostrarArtistico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarArtistico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarArtistico.ForeColor = System.Drawing.Color.Green
        Me.chkMostrarArtistico.Location = New System.Drawing.Point(288, 421)
        Me.chkMostrarArtistico.Name = "chkMostrarArtistico"
        Me.chkMostrarArtistico.Size = New System.Drawing.Size(73, 18)
        Me.chkMostrarArtistico.TabIndex = 31
        Me.chkMostrarArtistico.Text = "Artístico"
        Me.chkMostrarArtistico.UseVisualStyleBackColor = True
        '
        'chkMostrarInter
        '
        Me.chkMostrarInter.AutoSize = True
        Me.chkMostrarInter.Checked = True
        Me.chkMostrarInter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarInter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostrarInter.Location = New System.Drawing.Point(367, 421)
        Me.chkMostrarInter.Name = "chkMostrarInter"
        Me.chkMostrarInter.Size = New System.Drawing.Size(109, 18)
        Me.chkMostrarInter.TabIndex = 32
        Me.chkMostrarInter.Text = "Inter Programa"
        Me.chkMostrarInter.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAtualizar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAtualizar.Location = New System.Drawing.Point(503, 415)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAtualizar.Size = New System.Drawing.Size(142, 28)
        Me.btnAtualizar.TabIndex = 33
        Me.btnAtualizar.Text = "Atualizar Consulta"
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'frmRoteiroConsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(724, 455)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.chkMostrarInter)
        Me.Controls.Add(Me.chkMostrarArtistico)
        Me.Controls.Add(Me.chkMostrarLocal)
        Me.Controls.Add(Me.chkMostrarNet)
        Me.Controls.Add(Me.chkIniciar)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.picEncerramento)
        Me.Controls.Add(Me._fraConsistencia_5)
        Me.Controls.Add(Me.cmdEncerramento)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me._fraConsistencia_4)
        Me.Controls.Add(Me._fraConsistencia_2)
        Me.Controls.Add(Me._fraConsistencia_3)
        Me.Controls.Add(Me._fraConsistencia_1)
        Me.Controls.Add(Me.tabConsistencia)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(256, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoteiroConsistencia"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consistencia do Roteiro"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me._fraConsistencia_5.ResumeLayout(False)
        CType(Me.flxNaoOrdenados, System.ComponentModel.ISupportInitialize).EndInit()
        Me._fraConsistencia_4.ResumeLayout(False)
        CType(Me.flxRestricao, System.ComponentModel.ISupportInitialize).EndInit()
        Me._fraConsistencia_2.ResumeLayout(False)
        CType(Me.flxConcorrencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me._fraConsistencia_3.ResumeLayout(False)
        CType(Me.flxFitaPendente, System.ComponentModel.ISupportInitialize).EndInit()
        Me._fraConsistencia_1.ResumeLayout(False)
        CType(Me.flxOcupacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancelaFechamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fraConsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabConsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picEncerramento.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkIniciar As System.Windows.Forms.CheckBox
    Public WithEvents tabConsistencia As AxComctlLib.AxTabStrip
    Public WithEvents lblParametro As System.Windows.Forms.Label
    Public WithEvents _cmdCancelaFechamento_0 As System.Windows.Forms.Button
    Public WithEvents cmdOkFechamento As System.Windows.Forms.Button
    Public WithEvents picEncerramento As System.Windows.Forms.Panel
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents chkComercial As System.Windows.Forms.CheckBox
    Public WithEvents chkArtistico As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostrarNet As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostrarLocal As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostrarArtistico As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostrarInter As System.Windows.Forms.CheckBox
    Public WithEvents btnAtualizar As System.Windows.Forms.Button
#End Region
End Class