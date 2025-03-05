<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmHorarioProgramacao
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
    Public WithEvents cmdReplicar As System.Windows.Forms.Button
    Public WithEvents _chkDiaSemana_7 As System.Windows.Forms.CheckBox
    Public WithEvents _chkDiaSemana_6 As System.Windows.Forms.CheckBox
    Public WithEvents _chkDiaSemana_4 As System.Windows.Forms.CheckBox
    Public WithEvents _chkDiaSemana_3 As System.Windows.Forms.CheckBox
    Public WithEvents _chkDiaSemana_5 As System.Windows.Forms.CheckBox
    Public WithEvents _chkDiaSemana_2 As System.Windows.Forms.CheckBox
    Public WithEvents _chkDiaSemana_1 As System.Windows.Forms.CheckBox
    Public WithEvents _Frame2_1 As System.Windows.Forms.GroupBox
    Public WithEvents txtDataFim As System.Windows.Forms.TextBox
    Public WithEvents txtDataInicio As System.Windows.Forms.TextBox
    Public WithEvents _Label3_2 As System.Windows.Forms.Label
    Public WithEvents _Label3_3 As System.Windows.Forms.Label
    Public WithEvents fraPeriodo As System.Windows.Forms.GroupBox
    Public WithEvents txtHoraInicio As System.Windows.Forms.TextBox
    Public WithEvents txtHoraFim As System.Windows.Forms.TextBox
    Public WithEvents _Label3_5 As System.Windows.Forms.Label
    Public WithEvents _Label3_4 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdOkParametro As System.Windows.Forms.Button
    Public WithEvents _cmdCancela_0 As System.Windows.Forms.Button
    Public WithEvents _cmdCancela_1 As System.Windows.Forms.Button
    Public WithEvents lblParametro As System.Windows.Forms.Label
    Public WithEvents picParametro As System.Windows.Forms.Panel
    Public WithEvents cmdAlterar As System.Windows.Forms.Button
    Public WithEvents _cmdSelecaoVeiculo_0 As System.Windows.Forms.Button
    Public WithEvents _cmdSelecaoVeiculo_1 As System.Windows.Forms.Button
    Public WithEvents lstVeiculo As System.Windows.Forms.CheckedListBox
    Public WithEvents lblSelecaoVeiculo As System.Windows.Forms.Label
    Public WithEvents picVeiculo As System.Windows.Forms.Panel
    Public WithEvents cmdSair As System.Windows.Forms.Button
    Public WithEvents cmdExibir As System.Windows.Forms.Button
    Public WithEvents txtNome_Veiculo As System.Windows.Forms.TextBox
    Public WithEvents cmdFiltroVeiculo As System.Windows.Forms.Button
    Public WithEvents txtVeiculo As System.Windows.Forms.TextBox
    Public WithEvents txtData_Exibicao As System.Windows.Forms.TextBox
    Public WithEvents cmdData As System.Windows.Forms.Button
    Public WithEvents _Label2_0 As System.Windows.Forms.Label
    Public WithEvents fraParametro As System.Windows.Forms.GroupBox
    Public WithEvents flxPrograma As AxMSFlexGridLib.AxMSFlexGrid
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorarioProgramacao))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picParametro = New System.Windows.Forms.Panel
        Me.cmdReplicar = New System.Windows.Forms.Button
        Me._Frame2_1 = New System.Windows.Forms.GroupBox
        Me._chkDiaSemana_7 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_6 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_4 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_3 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_5 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_2 = New System.Windows.Forms.CheckBox
        Me._chkDiaSemana_1 = New System.Windows.Forms.CheckBox
        Me.fraPeriodo = New System.Windows.Forms.GroupBox
        Me.txtDataFim = New System.Windows.Forms.TextBox
        Me.txtDataInicio = New System.Windows.Forms.TextBox
        Me._Label3_2 = New System.Windows.Forms.Label
        Me._Label3_3 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtHoraInicio = New System.Windows.Forms.TextBox
        Me.txtHoraFim = New System.Windows.Forms.TextBox
        Me._Label3_5 = New System.Windows.Forms.Label
        Me._Label3_4 = New System.Windows.Forms.Label
        Me.cmdOkParametro = New System.Windows.Forms.Button
        Me._cmdCancela_0 = New System.Windows.Forms.Button
        Me._cmdCancela_1 = New System.Windows.Forms.Button
        Me.lblParametro = New System.Windows.Forms.Label
        Me.cmdAlterar = New System.Windows.Forms.Button
        Me.picVeiculo = New System.Windows.Forms.Panel
        Me._cmdSelecaoVeiculo_0 = New System.Windows.Forms.Button
        Me._cmdSelecaoVeiculo_1 = New System.Windows.Forms.Button
        Me.lstVeiculo = New System.Windows.Forms.CheckedListBox
        Me.lblSelecaoVeiculo = New System.Windows.Forms.Label
        Me.cmdSair = New System.Windows.Forms.Button
        Me.fraParametro = New System.Windows.Forms.GroupBox
        Me.ucVeiculo = New WUC.UcText
        Me.UcData = New WCL_SCTV.UC.UCData
        Me.cmdExibir = New System.Windows.Forms.Button
        Me._Label2_0 = New System.Windows.Forms.Label
        Me.txtNome_Veiculo = New System.Windows.Forms.TextBox
        Me.cmdFiltroVeiculo = New System.Windows.Forms.Button
        Me.txtVeiculo = New System.Windows.Forms.TextBox
        Me.txtData_Exibicao = New System.Windows.Forms.TextBox
        Me.cmdData = New System.Windows.Forms.Button
        Me.flxPrograma = New AxMSFlexGridLib.AxMSFlexGrid
        Me.cmdSelecaoVeiculo = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdCancela = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.chkDiaSemana = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.Label3 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Frame2 = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.picParametro.SuspendLayout()
        Me._Frame2_1.SuspendLayout()
        Me.fraPeriodo.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.picVeiculo.SuspendLayout()
        Me.fraParametro.SuspendLayout()
        CType(Me.flxPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelecaoVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDiaSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picParametro
        '
        Me.picParametro.BackColor = System.Drawing.SystemColors.Control
        Me.picParametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParametro.Controls.Add(Me.cmdReplicar)
        Me.picParametro.Controls.Add(Me._Frame2_1)
        Me.picParametro.Controls.Add(Me.fraPeriodo)
        Me.picParametro.Controls.Add(Me.Frame1)
        Me.picParametro.Controls.Add(Me.cmdOkParametro)
        Me.picParametro.Controls.Add(Me._cmdCancela_0)
        Me.picParametro.Controls.Add(Me._cmdCancela_1)
        Me.picParametro.Controls.Add(Me.lblParametro)
        Me.picParametro.Cursor = System.Windows.Forms.Cursors.Default
        Me.picParametro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picParametro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picParametro.Location = New System.Drawing.Point(51, 69)
        Me.picParametro.Name = "picParametro"
        Me.picParametro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picParametro.Size = New System.Drawing.Size(442, 206)
        Me.picParametro.TabIndex = 17
        Me.picParametro.TabStop = True
        Me.picParametro.Visible = False
        '
        'cmdReplicar
        '
        Me.cmdReplicar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReplicar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReplicar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReplicar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReplicar.Location = New System.Drawing.Point(9, 165)
        Me.cmdReplicar.Name = "cmdReplicar"
        Me.cmdReplicar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReplicar.Size = New System.Drawing.Size(85, 28)
        Me.cmdReplicar.TabIndex = 40
        Me.cmdReplicar.TabStop = False
        Me.cmdReplicar.Text = "&Replicar"
        Me.cmdReplicar.UseVisualStyleBackColor = False
        '
        '_Frame2_1
        '
        Me._Frame2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_7)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_6)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_4)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_3)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_5)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_2)
        Me._Frame2_1.Controls.Add(Me._chkDiaSemana_1)
        Me._Frame2_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Frame2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame2_1.Location = New System.Drawing.Point(9, 105)
        Me._Frame2_1.Name = "_Frame2_1"
        Me._Frame2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_1.Size = New System.Drawing.Size(421, 49)
        Me._Frame2_1.TabIndex = 39
        Me._Frame2_1.TabStop = False
        Me._Frame2_1.Text = "Nos dias da Semana"
        '
        '_chkDiaSemana_7
        '
        Me._chkDiaSemana_7.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDiaSemana_7.Location = New System.Drawing.Point(369, 21)
        Me._chkDiaSemana_7.Name = "_chkDiaSemana_7"
        Me._chkDiaSemana_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_7.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_7.TabIndex = 32
        Me._chkDiaSemana_7.Text = "Sab"
        Me._chkDiaSemana_7.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_6
        '
        Me._chkDiaSemana_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDiaSemana_6.Location = New System.Drawing.Point(312, 21)
        Me._chkDiaSemana_6.Name = "_chkDiaSemana_6"
        Me._chkDiaSemana_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_6.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_6.TabIndex = 31
        Me._chkDiaSemana_6.Text = "Sex"
        Me._chkDiaSemana_6.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_4
        '
        Me._chkDiaSemana_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDiaSemana_4.Location = New System.Drawing.Point(192, 21)
        Me._chkDiaSemana_4.Name = "_chkDiaSemana_4"
        Me._chkDiaSemana_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_4.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_4.TabIndex = 29
        Me._chkDiaSemana_4.Text = "Qua"
        Me._chkDiaSemana_4.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_3
        '
        Me._chkDiaSemana_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDiaSemana_3.Location = New System.Drawing.Point(132, 21)
        Me._chkDiaSemana_3.Name = "_chkDiaSemana_3"
        Me._chkDiaSemana_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_3.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_3.TabIndex = 28
        Me._chkDiaSemana_3.Text = "Ter"
        Me._chkDiaSemana_3.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_5
        '
        Me._chkDiaSemana_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDiaSemana_5.Location = New System.Drawing.Point(252, 21)
        Me._chkDiaSemana_5.Name = "_chkDiaSemana_5"
        Me._chkDiaSemana_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_5.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_5.TabIndex = 30
        Me._chkDiaSemana_5.Text = "Qui"
        Me._chkDiaSemana_5.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_2
        '
        Me._chkDiaSemana_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDiaSemana_2.Location = New System.Drawing.Point(72, 21)
        Me._chkDiaSemana_2.Name = "_chkDiaSemana_2"
        Me._chkDiaSemana_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_2.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_2.TabIndex = 27
        Me._chkDiaSemana_2.Text = "Seg"
        Me._chkDiaSemana_2.UseVisualStyleBackColor = False
        '
        '_chkDiaSemana_1
        '
        Me._chkDiaSemana_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkDiaSemana_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDiaSemana_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDiaSemana_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDiaSemana_1.Location = New System.Drawing.Point(12, 21)
        Me._chkDiaSemana_1.Name = "_chkDiaSemana_1"
        Me._chkDiaSemana_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDiaSemana_1.Size = New System.Drawing.Size(49, 22)
        Me._chkDiaSemana_1.TabIndex = 26
        Me._chkDiaSemana_1.Text = "Dom"
        Me._chkDiaSemana_1.UseVisualStyleBackColor = False
        '
        'fraPeriodo
        '
        Me.fraPeriodo.BackColor = System.Drawing.SystemColors.Control
        Me.fraPeriodo.Controls.Add(Me.txtDataFim)
        Me.fraPeriodo.Controls.Add(Me.txtDataInicio)
        Me.fraPeriodo.Controls.Add(Me._Label3_2)
        Me.fraPeriodo.Controls.Add(Me._Label3_3)
        Me.fraPeriodo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraPeriodo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraPeriodo.Location = New System.Drawing.Point(228, 27)
        Me.fraPeriodo.Name = "fraPeriodo"
        Me.fraPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraPeriodo.Size = New System.Drawing.Size(202, 70)
        Me.fraPeriodo.TabIndex = 35
        Me.fraPeriodo.TabStop = False
        Me.fraPeriodo.Text = "Propagar no Periodo"
        '
        'txtDataFim
        '
        Me.txtDataFim.AcceptsReturn = True
        Me.txtDataFim.BackColor = System.Drawing.SystemColors.Window
        Me.txtDataFim.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataFim.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataFim.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDataFim.Location = New System.Drawing.Point(72, 45)
        Me.txtDataFim.MaxLength = 0
        Me.txtDataFim.Name = "txtDataFim"
        Me.txtDataFim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDataFim.Size = New System.Drawing.Size(94, 20)
        Me.txtDataFim.TabIndex = 25
        '
        'txtDataInicio
        '
        Me.txtDataInicio.AcceptsReturn = True
        Me.txtDataInicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtDataInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataInicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDataInicio.Location = New System.Drawing.Point(72, 18)
        Me.txtDataInicio.MaxLength = 0
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDataInicio.Size = New System.Drawing.Size(94, 20)
        Me.txtDataInicio.TabIndex = 24
        '
        '_Label3_2
        '
        Me._Label3_2.AutoSize = True
        Me._Label3_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_2.Location = New System.Drawing.Point(42, 48)
        Me._Label3_2.Name = "_Label3_2"
        Me._Label3_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_2.Size = New System.Drawing.Size(24, 14)
        Me._Label3_2.TabIndex = 38
        Me._Label3_2.Text = "Até"
        '
        '_Label3_3
        '
        Me._Label3_3.AutoSize = True
        Me._Label3_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_3.Location = New System.Drawing.Point(42, 21)
        Me._Label3_3.Name = "_Label3_3"
        Me._Label3_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_3.Size = New System.Drawing.Size(20, 14)
        Me._Label3_3.TabIndex = 37
        Me._Label3_3.Text = "De"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtHoraInicio)
        Me.Frame1.Controls.Add(Me.txtHoraFim)
        Me.Frame1.Controls.Add(Me._Label3_5)
        Me.Frame1.Controls.Add(Me._Label3_4)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(9, 27)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(202, 70)
        Me.Frame1.TabIndex = 20
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Horário da Programacao"
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.AcceptsReturn = True
        Me.txtHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoraInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoraInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoraInicio.Location = New System.Drawing.Point(84, 18)
        Me.txtHoraInicio.MaxLength = 0
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoraInicio.Size = New System.Drawing.Size(79, 20)
        Me.txtHoraInicio.TabIndex = 21
        '
        'txtHoraFim
        '
        Me.txtHoraFim.AcceptsReturn = True
        Me.txtHoraFim.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoraFim.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoraFim.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraFim.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoraFim.Location = New System.Drawing.Point(84, 45)
        Me.txtHoraFim.MaxLength = 0
        Me.txtHoraFim.Name = "txtHoraFim"
        Me.txtHoraFim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoraFim.Size = New System.Drawing.Size(79, 20)
        Me.txtHoraFim.TabIndex = 23
        '
        '_Label3_5
        '
        Me._Label3_5.AutoSize = True
        Me._Label3_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_5.Location = New System.Drawing.Point(42, 21)
        Me._Label3_5.Name = "_Label3_5"
        Me._Label3_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_5.Size = New System.Drawing.Size(31, 14)
        Me._Label3_5.TabIndex = 33
        Me._Label3_5.Text = "Inicio"
        '
        '_Label3_4
        '
        Me._Label3_4.AutoSize = True
        Me._Label3_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_4.Location = New System.Drawing.Point(42, 48)
        Me._Label3_4.Name = "_Label3_4"
        Me._Label3_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_4.Size = New System.Drawing.Size(23, 14)
        Me._Label3_4.TabIndex = 22
        Me._Label3_4.Text = "Fim"
        '
        'cmdOkParametro
        '
        Me.cmdOkParametro.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOkParametro.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOkParametro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkParametro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOkParametro.Location = New System.Drawing.Point(255, 165)
        Me.cmdOkParametro.Name = "cmdOkParametro"
        Me.cmdOkParametro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOkParametro.Size = New System.Drawing.Size(73, 28)
        Me.cmdOkParametro.TabIndex = 34
        Me.cmdOkParametro.Text = "&Ok"
        Me.cmdOkParametro.UseVisualStyleBackColor = False
        '
        '_cmdCancela_0
        '
        Me._cmdCancela_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdCancela_0.Location = New System.Drawing.Point(354, 165)
        Me._cmdCancela_0.Name = "_cmdCancela_0"
        Me._cmdCancela_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_0.Size = New System.Drawing.Size(73, 28)
        Me._cmdCancela_0.TabIndex = 36
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
        Me._cmdCancela_1.Location = New System.Drawing.Point(420, 0)
        Me._cmdCancela_1.Name = "_cmdCancela_1"
        Me._cmdCancela_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_1.Size = New System.Drawing.Size(19, 16)
        Me._cmdCancela_1.TabIndex = 18
        Me._cmdCancela_1.TabStop = False
        Me._cmdCancela_1.Text = "X"
        Me._cmdCancela_1.UseVisualStyleBackColor = False
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
        Me.lblParametro.TabIndex = 0
        Me.lblParametro.Text = "  Horario da Programação"
        '
        'cmdAlterar
        '
        Me.cmdAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAlterar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlterar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlterar.Location = New System.Drawing.Point(402, 369)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlterar.Size = New System.Drawing.Size(91, 28)
        Me.cmdAlterar.TabIndex = 16
        Me.cmdAlterar.Text = "&Alterar Horario"
        Me.cmdAlterar.UseVisualStyleBackColor = False
        '
        'picVeiculo
        '
        Me.picVeiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVeiculo.Controls.Add(Me._cmdSelecaoVeiculo_0)
        Me.picVeiculo.Controls.Add(Me._cmdSelecaoVeiculo_1)
        Me.picVeiculo.Controls.Add(Me.lstVeiculo)
        Me.picVeiculo.Controls.Add(Me.lblSelecaoVeiculo)
        Me.picVeiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.picVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picVeiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picVeiculo.Location = New System.Drawing.Point(3, 444)
        Me.picVeiculo.Name = "picVeiculo"
        Me.picVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picVeiculo.Size = New System.Drawing.Size(472, 60)
        Me.picVeiculo.TabIndex = 11
        Me.picVeiculo.TabStop = True
        '
        '_cmdSelecaoVeiculo_0
        '
        Me._cmdSelecaoVeiculo_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdSelecaoVeiculo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdSelecaoVeiculo_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdSelecaoVeiculo_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdSelecaoVeiculo_0.Location = New System.Drawing.Point(387, 171)
        Me._cmdSelecaoVeiculo_0.Name = "_cmdSelecaoVeiculo_0"
        Me._cmdSelecaoVeiculo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdSelecaoVeiculo_0.Size = New System.Drawing.Size(70, 28)
        Me._cmdSelecaoVeiculo_0.TabIndex = 14
        Me._cmdSelecaoVeiculo_0.Text = "&Ok"
        Me._cmdSelecaoVeiculo_0.UseVisualStyleBackColor = False
        '
        '_cmdSelecaoVeiculo_1
        '
        Me._cmdSelecaoVeiculo_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdSelecaoVeiculo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdSelecaoVeiculo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdSelecaoVeiculo_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdSelecaoVeiculo_1.Location = New System.Drawing.Point(444, 0)
        Me._cmdSelecaoVeiculo_1.Name = "_cmdSelecaoVeiculo_1"
        Me._cmdSelecaoVeiculo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdSelecaoVeiculo_1.Size = New System.Drawing.Size(19, 16)
        Me._cmdSelecaoVeiculo_1.TabIndex = 13
        Me._cmdSelecaoVeiculo_1.TabStop = False
        Me._cmdSelecaoVeiculo_1.Text = "X"
        Me._cmdSelecaoVeiculo_1.UseVisualStyleBackColor = False
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
        Me.lstVeiculo.TabIndex = 12
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
        Me.lblSelecaoVeiculo.TabIndex = 15
        Me.lblSelecaoVeiculo.Text = "Selecione os Veiculos para  replicar os Horários da Programação"
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(522, 369)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(91, 28)
        Me.cmdSair.TabIndex = 9
        Me.cmdSair.TabStop = False
        Me.cmdSair.Text = "&Sair"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'fraParametro
        '
        Me.fraParametro.BackColor = System.Drawing.SystemColors.Control
        Me.fraParametro.Controls.Add(Me.ucVeiculo)
        Me.fraParametro.Controls.Add(Me.UcData)
        Me.fraParametro.Controls.Add(Me.cmdExibir)
        Me.fraParametro.Controls.Add(Me._Label2_0)
        Me.fraParametro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraParametro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraParametro.Location = New System.Drawing.Point(6, 0)
        Me.fraParametro.Name = "fraParametro"
        Me.fraParametro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraParametro.Size = New System.Drawing.Size(604, 52)
        Me.fraParametro.TabIndex = 0
        Me.fraParametro.TabStop = False
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(10, 3)
        Me.ucVeiculo.MaxLength = 3
        Me.ucVeiculo.Name = "ucVeiculo"
        Me.ucVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVeiculo.pDecimal = CType(0, Byte)
        Me.ucVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVeiculo.showButton = True
        Me.ucVeiculo.ShowDescricao = True
        Me.ucVeiculo.Size = New System.Drawing.Size(368, 37)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy "
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(384, 21)
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
        Me.cmdExibir.Location = New System.Drawing.Point(525, 18)
        Me.cmdExibir.Name = "cmdExibir"
        Me.cmdExibir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExibir.Size = New System.Drawing.Size(66, 26)
        Me.cmdExibir.TabIndex = 4
        Me.cmdExibir.Text = "&Exibir"
        Me.cmdExibir.UseVisualStyleBackColor = False
        '
        '_Label2_0
        '
        Me._Label2_0.AutoSize = True
        Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_0.Location = New System.Drawing.Point(381, 8)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(87, 14)
        Me._Label2_0.TabIndex = 2
        Me._Label2_0.Text = "Data de Exibição"
        '
        'txtNome_Veiculo
        '
        Me.txtNome_Veiculo.AcceptsReturn = True
        Me.txtNome_Veiculo.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome_Veiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome_Veiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome_Veiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNome_Veiculo.Location = New System.Drawing.Point(673, 275)
        Me.txtNome_Veiculo.MaxLength = 0
        Me.txtNome_Veiculo.Name = "txtNome_Veiculo"
        Me.txtNome_Veiculo.ReadOnly = True
        Me.txtNome_Veiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNome_Veiculo.Size = New System.Drawing.Size(110, 20)
        Me.txtNome_Veiculo.TabIndex = 6
        Me.txtNome_Veiculo.TabStop = False
        '
        'cmdFiltroVeiculo
        '
        Me.cmdFiltroVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltroVeiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFiltroVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltroVeiculo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFiltroVeiculo.Image = CType(resources.GetObject("cmdFiltroVeiculo.Image"), System.Drawing.Image)
        Me.cmdFiltroVeiculo.Location = New System.Drawing.Point(705, 175)
        Me.cmdFiltroVeiculo.Name = "cmdFiltroVeiculo"
        Me.cmdFiltroVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFiltroVeiculo.Size = New System.Drawing.Size(22, 22)
        Me.cmdFiltroVeiculo.TabIndex = 5
        Me.cmdFiltroVeiculo.TabStop = False
        Me.cmdFiltroVeiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFiltroVeiculo.UseVisualStyleBackColor = False
        '
        'txtVeiculo
        '
        Me.txtVeiculo.AcceptsReturn = True
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Window
        Me.txtVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVeiculo.Location = New System.Drawing.Point(705, 205)
        Me.txtVeiculo.MaxLength = 3
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVeiculo.Size = New System.Drawing.Size(54, 20)
        Me.txtVeiculo.TabIndex = 0
        Me.txtVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtData_Exibicao
        '
        Me.txtData_Exibicao.AcceptsReturn = True
        Me.txtData_Exibicao.BackColor = System.Drawing.SystemColors.Window
        Me.txtData_Exibicao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtData_Exibicao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData_Exibicao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtData_Exibicao.Location = New System.Drawing.Point(705, 145)
        Me.txtData_Exibicao.MaxLength = 10
        Me.txtData_Exibicao.Name = "txtData_Exibicao"
        Me.txtData_Exibicao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtData_Exibicao.Size = New System.Drawing.Size(78, 20)
        Me.txtData_Exibicao.TabIndex = 1
        Me.txtData_Exibicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdData
        '
        Me.cmdData.BackColor = System.Drawing.SystemColors.Control
        Me.cmdData.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdData.Image = CType(resources.GetObject("cmdData.Image"), System.Drawing.Image)
        Me.cmdData.Location = New System.Drawing.Point(695, 114)
        Me.cmdData.Name = "cmdData"
        Me.cmdData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdData.Size = New System.Drawing.Size(19, 21)
        Me.cmdData.TabIndex = 4
        Me.cmdData.TabStop = False
        Me.cmdData.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdData.UseVisualStyleBackColor = False
        '
        'flxPrograma
        '
        Me.flxPrograma.Location = New System.Drawing.Point(6, 51)
        Me.flxPrograma.Name = "flxPrograma"
        Me.flxPrograma.OcxState = CType(resources.GetObject("flxPrograma.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxPrograma.Size = New System.Drawing.Size(605, 311)
        Me.flxPrograma.TabIndex = 10
        '
        'cmdSelecaoVeiculo
        '
        '
        'cmdCancela
        '
        '
        'frmHorarioProgramacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(631, 406)
        Me.Controls.Add(Me.picParametro)
        Me.Controls.Add(Me.txtNome_Veiculo)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.txtVeiculo)
        Me.Controls.Add(Me.cmdFiltroVeiculo)
        Me.Controls.Add(Me.picVeiculo)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.txtData_Exibicao)
        Me.Controls.Add(Me.fraParametro)
        Me.Controls.Add(Me.cmdData)
        Me.Controls.Add(Me.flxPrograma)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(99, 108)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHorarioProgramacao"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Horários da Programação"
        Me.picParametro.ResumeLayout(False)
        Me._Frame2_1.ResumeLayout(False)
        Me.fraPeriodo.ResumeLayout(False)
        Me.fraPeriodo.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.picVeiculo.ResumeLayout(False)
        Me.fraParametro.ResumeLayout(False)
        Me.fraParametro.PerformLayout()
        CType(Me.flxPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelecaoVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDiaSemana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Public WithEvents cmdSelecaoVeiculo As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdCancela As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents chkDiaSemana As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
    Public WithEvents Label3 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Frame2 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    Friend WithEvents ucVeiculo As WUC.UcText
#End Region
End Class