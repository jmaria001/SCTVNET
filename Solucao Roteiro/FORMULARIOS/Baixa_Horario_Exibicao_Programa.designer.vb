<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmBaixa_Horario_Exibicao_Programa
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        InitializeComponent()

        Me.MDIParent = SCTVNET.mdiPrincipal
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
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdReplicar As System.Windows.Forms.Button
	Public WithEvents _cmdSelecaoVeiculo_0 As System.Windows.Forms.Button
	Public WithEvents _cmdSelecaoVeiculo_1 As System.Windows.Forms.Button
	Public WithEvents lstVeiculo As System.Windows.Forms.CheckedListBox
	Public WithEvents lblSelecaoVeiculo As System.Windows.Forms.Label
	Public WithEvents picVeiculo As System.Windows.Forms.Panel
	Public WithEvents txtHorarioEmissora As System.Windows.Forms.TextBox
	Public WithEvents chkAjustarInicio As System.Windows.Forms.CheckBox
	Public WithEvents txtDataTermino As System.Windows.Forms.TextBox
	Public WithEvents txtHoraTermino As System.Windows.Forms.TextBox
	Public WithEvents txtDataInicio As System.Windows.Forms.TextBox
	Public WithEvents txtHoraInicio As System.Windows.Forms.TextBox
	Public WithEvents _Label1_5 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents txtInicio_Real As System.Windows.Forms.TextBox
	Public WithEvents txtFinal_Real As System.Windows.Forms.TextBox
	Public WithEvents cmdSair As System.Windows.Forms.Button
	Public WithEvents cmdExibir As System.Windows.Forms.Button
	Public WithEvents txtNome_Veiculo As System.Windows.Forms.TextBox
	Public WithEvents cmdFiltroVeiculo As System.Windows.Forms.Button
	Public WithEvents txtVeiculo As System.Windows.Forms.TextBox
	Public WithEvents txtData_Exibicao As System.Windows.Forms.TextBox
	Public WithEvents cmdData As System.Windows.Forms.Button
    Public WithEvents _Label2_0 As System.Windows.Forms.Label
	Public WithEvents fraParametro As System.Windows.Forms.GroupBox
	Public WithEvents cmdGravar As System.Windows.Forms.Button
	Public WithEvents flxPrograma As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents cmdSelecaoVeiculo As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaixa_Horario_Exibicao_Programa))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdReplicar = New System.Windows.Forms.Button
        Me.picVeiculo = New System.Windows.Forms.Panel
        Me._cmdSelecaoVeiculo_0 = New System.Windows.Forms.Button
        Me._cmdSelecaoVeiculo_1 = New System.Windows.Forms.Button
        Me.lstVeiculo = New System.Windows.Forms.CheckedListBox
        Me.lblSelecaoVeiculo = New System.Windows.Forms.Label
        Me.txtHorarioEmissora = New System.Windows.Forms.TextBox
        Me.chkAjustarInicio = New System.Windows.Forms.CheckBox
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.txtDataTermino = New System.Windows.Forms.TextBox
        Me.txtHoraTermino = New System.Windows.Forms.TextBox
        Me.txtDataInicio = New System.Windows.Forms.TextBox
        Me.txtHoraInicio = New System.Windows.Forms.TextBox
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me.txtInicio_Real = New System.Windows.Forms.TextBox
        Me.txtFinal_Real = New System.Windows.Forms.TextBox
        Me.cmdSair = New System.Windows.Forms.Button
        Me.fraParametro = New System.Windows.Forms.GroupBox
        Me.ucVeiculo = New WUC.UcText
        Me.UcData = New WCL_SCTV.UC.UCData
        Me._Label2_0 = New System.Windows.Forms.Label
        Me.cmdExibir = New System.Windows.Forms.Button
        Me.txtNome_Veiculo = New System.Windows.Forms.TextBox
        Me.cmdFiltroVeiculo = New System.Windows.Forms.Button
        Me.txtVeiculo = New System.Windows.Forms.TextBox
        Me.txtData_Exibicao = New System.Windows.Forms.TextBox
        Me.cmdData = New System.Windows.Forms.Button
        Me.cmdGravar = New System.Windows.Forms.Button
        Me.flxPrograma = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdSelecaoVeiculo = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.picVeiculo.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.fraParametro.SuspendLayout()
        CType(Me.flxPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelecaoVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdReplicar
        '
        Me.cmdReplicar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReplicar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReplicar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReplicar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReplicar.Location = New System.Drawing.Point(270, 408)
        Me.cmdReplicar.Name = "cmdReplicar"
        Me.cmdReplicar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReplicar.Size = New System.Drawing.Size(85, 28)
        Me.cmdReplicar.TabIndex = 30
        Me.cmdReplicar.TabStop = False
        Me.cmdReplicar.Text = "&Replicar"
        Me.cmdReplicar.UseVisualStyleBackColor = False
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
        Me.picVeiculo.TabIndex = 25
        Me.picVeiculo.TabStop = True
        '
        '_cmdSelecaoVeiculo_0
        '
        Me._cmdSelecaoVeiculo_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdSelecaoVeiculo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdSelecaoVeiculo_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdSelecaoVeiculo_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelecaoVeiculo.SetIndex(Me._cmdSelecaoVeiculo_0, CType(0, Short))
        Me._cmdSelecaoVeiculo_0.Location = New System.Drawing.Point(387, 171)
        Me._cmdSelecaoVeiculo_0.Name = "_cmdSelecaoVeiculo_0"
        Me._cmdSelecaoVeiculo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdSelecaoVeiculo_0.Size = New System.Drawing.Size(70, 28)
        Me._cmdSelecaoVeiculo_0.TabIndex = 28
        Me._cmdSelecaoVeiculo_0.Text = "&Ok"
        Me._cmdSelecaoVeiculo_0.UseVisualStyleBackColor = False
        '
        '_cmdSelecaoVeiculo_1
        '
        Me._cmdSelecaoVeiculo_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdSelecaoVeiculo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdSelecaoVeiculo_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdSelecaoVeiculo_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelecaoVeiculo.SetIndex(Me._cmdSelecaoVeiculo_1, CType(1, Short))
        Me._cmdSelecaoVeiculo_1.Location = New System.Drawing.Point(444, 0)
        Me._cmdSelecaoVeiculo_1.Name = "_cmdSelecaoVeiculo_1"
        Me._cmdSelecaoVeiculo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdSelecaoVeiculo_1.Size = New System.Drawing.Size(19, 16)
        Me._cmdSelecaoVeiculo_1.TabIndex = 27
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
        Me.lstVeiculo.TabIndex = 26
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
        Me.lblSelecaoVeiculo.TabIndex = 29
        Me.lblSelecaoVeiculo.Text = "Selecione os Veiculos para  replicar os Horários da Programação"
        '
        'txtHorarioEmissora
        '
        Me.txtHorarioEmissora.AcceptsReturn = True
        Me.txtHorarioEmissora.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorarioEmissora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorarioEmissora.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorarioEmissora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorarioEmissora.Location = New System.Drawing.Point(474, 417)
        Me.txtHorarioEmissora.MaxLength = 5
        Me.txtHorarioEmissora.Name = "txtHorarioEmissora"
        Me.txtHorarioEmissora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorarioEmissora.Size = New System.Drawing.Size(55, 20)
        Me.txtHorarioEmissora.TabIndex = 24
        Me.txtHorarioEmissora.TabStop = False
        Me.txtHorarioEmissora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHorarioEmissora.Visible = False
        '
        'chkAjustarInicio
        '
        Me.chkAjustarInicio.BackColor = System.Drawing.SystemColors.Control
        Me.chkAjustarInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAjustarInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAjustarInicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAjustarInicio.Location = New System.Drawing.Point(267, 372)
        Me.chkAjustarInicio.Name = "chkAjustarInicio"
        Me.chkAjustarInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAjustarInicio.Size = New System.Drawing.Size(247, 19)
        Me.chkAjustarInicio.TabIndex = 23
        Me.chkAjustarInicio.Text = "Ajustar Horário dos Programas Subsequentes"
        Me.chkAjustarInicio.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtDataTermino)
        Me.Frame2.Controls.Add(Me.txtHoraTermino)
        Me.Frame2.Controls.Add(Me.txtDataInicio)
        Me.Frame2.Controls.Add(Me.txtHoraInicio)
        Me.Frame2.Controls.Add(Me._Label1_5)
        Me.Frame2.Controls.Add(Me._Label1_4)
        Me.Frame2.Controls.Add(Me._Label1_3)
        Me.Frame2.Controls.Add(Me._Label1_2)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(3, 366)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(259, 70)
        Me.Frame2.TabIndex = 14
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Periodo da Programação"
        '
        'txtDataTermino
        '
        Me.txtDataTermino.AcceptsReturn = True
        Me.txtDataTermino.BackColor = System.Drawing.SystemColors.Window
        Me.txtDataTermino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataTermino.Enabled = False
        Me.txtDataTermino.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataTermino.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDataTermino.Location = New System.Drawing.Point(75, 42)
        Me.txtDataTermino.MaxLength = 10
        Me.txtDataTermino.Name = "txtDataTermino"
        Me.txtDataTermino.ReadOnly = True
        Me.txtDataTermino.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDataTermino.Size = New System.Drawing.Size(73, 20)
        Me.txtDataTermino.TabIndex = 21
        Me.txtDataTermino.TabStop = False
        Me.txtDataTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHoraTermino
        '
        Me.txtHoraTermino.AcceptsReturn = True
        Me.txtHoraTermino.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoraTermino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoraTermino.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraTermino.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoraTermino.Location = New System.Drawing.Point(189, 42)
        Me.txtHoraTermino.MaxLength = 8
        Me.txtHoraTermino.Name = "txtHoraTermino"
        Me.txtHoraTermino.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoraTermino.Size = New System.Drawing.Size(55, 20)
        Me.txtHoraTermino.TabIndex = 16
        Me.txtHoraTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDataInicio
        '
        Me.txtDataInicio.AcceptsReturn = True
        Me.txtDataInicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtDataInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataInicio.Enabled = False
        Me.txtDataInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataInicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDataInicio.Location = New System.Drawing.Point(75, 18)
        Me.txtDataInicio.MaxLength = 10
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.ReadOnly = True
        Me.txtDataInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDataInicio.Size = New System.Drawing.Size(73, 20)
        Me.txtDataInicio.TabIndex = 18
        Me.txtDataInicio.TabStop = False
        Me.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.AcceptsReturn = True
        Me.txtHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoraInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoraInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoraInicio.Location = New System.Drawing.Point(189, 18)
        Me.txtHoraInicio.MaxLength = 8
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoraInicio.Size = New System.Drawing.Size(55, 20)
        Me.txtHoraInicio.TabIndex = 15
        Me.txtHoraInicio.TabStop = False
        Me.txtHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_Label1_5
        '
        Me._Label1_5.AutoSize = True
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_5, CType(5, Short))
        Me._Label1_5.Location = New System.Drawing.Point(156, 45)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(30, 14)
        Me._Label1_5.TabIndex = 22
        Me._Label1_5.Text = "Hora"
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = True
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(9, 45)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(70, 14)
        Me._Label1_4.TabIndex = 20
        Me._Label1_4.Text = "Data Término"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(156, 21)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(30, 14)
        Me._Label1_3.TabIndex = 19
        Me._Label1_3.Text = "Hora"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(9, 21)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(56, 14)
        Me._Label1_2.TabIndex = 17
        Me._Label1_2.Text = "Data Inicio"
        '
        'txtInicio_Real
        '
        Me.txtInicio_Real.AcceptsReturn = True
        Me.txtInicio_Real.BackColor = System.Drawing.Color.White
        Me.txtInicio_Real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInicio_Real.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInicio_Real.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio_Real.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInicio_Real.Location = New System.Drawing.Point(12, 333)
        Me.txtInicio_Real.MaxLength = 8
        Me.txtInicio_Real.Name = "txtInicio_Real"
        Me.txtInicio_Real.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInicio_Real.Size = New System.Drawing.Size(72, 20)
        Me.txtInicio_Real.TabIndex = 11
        Me.txtInicio_Real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInicio_Real.Visible = False
        '
        'txtFinal_Real
        '
        Me.txtFinal_Real.AcceptsReturn = True
        Me.txtFinal_Real.BackColor = System.Drawing.Color.White
        Me.txtFinal_Real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinal_Real.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFinal_Real.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinal_Real.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFinal_Real.Location = New System.Drawing.Point(90, 333)
        Me.txtFinal_Real.MaxLength = 8
        Me.txtFinal_Real.Name = "txtFinal_Real"
        Me.txtFinal_Real.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFinal_Real.Size = New System.Drawing.Size(63, 20)
        Me.txtFinal_Real.TabIndex = 12
        Me.txtFinal_Real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFinal_Real.Visible = False
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(591, 403)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(83, 32)
        Me.cmdSair.TabIndex = 10
        Me.cmdSair.TabStop = False
        Me.cmdSair.Text = "&Sair"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'fraParametro
        '
        Me.fraParametro.BackColor = System.Drawing.SystemColors.Control
        Me.fraParametro.Controls.Add(Me.ucVeiculo)
        Me.fraParametro.Controls.Add(Me.UcData)
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
        Me.ucVeiculo.Location = New System.Drawing.Point(9, 18)
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
        Me.ucVeiculo.TabIndex = 1
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy "
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(461, 18)
        Me.UcData.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcData.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcData.Name = "UcData"
        Me.UcData.Permite_Futuro = True
        Me.UcData.Permite_Limpar = True
        Me.UcData.Permite_Passado = True
        Me.UcData.Preenchimento_Obrigatorio = False
        Me.UcData.Size = New System.Drawing.Size(135, 25)
        Me.UcData.TabIndex = 2
        '
        '_Label2_0
        '
        Me._Label2_0.AutoSize = True
        Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_0, CType(0, Short))
        Me._Label2_0.Location = New System.Drawing.Point(368, 21)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(87, 14)
        Me._Label2_0.TabIndex = 8
        Me._Label2_0.Text = "Data de Exibição"
        '
        'cmdExibir
        '
        Me.cmdExibir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExibir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExibir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExibir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExibir.Location = New System.Drawing.Point(608, 12)
        Me.cmdExibir.Name = "cmdExibir"
        Me.cmdExibir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExibir.Size = New System.Drawing.Size(66, 32)
        Me.cmdExibir.TabIndex = 3
        Me.cmdExibir.Text = "Exibir"
        Me.cmdExibir.UseVisualStyleBackColor = False
        '
        'txtNome_Veiculo
        '
        Me.txtNome_Veiculo.AcceptsReturn = True
        Me.txtNome_Veiculo.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome_Veiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome_Veiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome_Veiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNome_Veiculo.Location = New System.Drawing.Point(767, 151)
        Me.txtNome_Veiculo.MaxLength = 0
        Me.txtNome_Veiculo.Name = "txtNome_Veiculo"
        Me.txtNome_Veiculo.ReadOnly = True
        Me.txtNome_Veiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNome_Veiculo.Size = New System.Drawing.Size(161, 20)
        Me.txtNome_Veiculo.TabIndex = 7
        Me.txtNome_Veiculo.TabStop = False
        '
        'cmdFiltroVeiculo
        '
        Me.cmdFiltroVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltroVeiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFiltroVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltroVeiculo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFiltroVeiculo.Location = New System.Drawing.Point(879, 331)
        Me.cmdFiltroVeiculo.Name = "cmdFiltroVeiculo"
        Me.cmdFiltroVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFiltroVeiculo.Size = New System.Drawing.Size(22, 22)
        Me.cmdFiltroVeiculo.TabIndex = 6
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
        Me.txtVeiculo.Location = New System.Drawing.Point(818, 286)
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
        Me.txtData_Exibicao.Location = New System.Drawing.Point(838, 192)
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
        Me.cmdData.Location = New System.Drawing.Point(882, 230)
        Me.cmdData.Name = "cmdData"
        Me.cmdData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdData.Size = New System.Drawing.Size(19, 21)
        Me.cmdData.TabIndex = 5
        Me.cmdData.TabStop = False
        Me.cmdData.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdData.UseVisualStyleBackColor = False
        '
        'cmdGravar
        '
        Me.cmdGravar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGravar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGravar.Enabled = False
        Me.cmdGravar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGravar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGravar.Location = New System.Drawing.Point(591, 364)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGravar.Size = New System.Drawing.Size(83, 32)
        Me.cmdGravar.TabIndex = 3
        Me.cmdGravar.TabStop = False
        Me.cmdGravar.Text = "&Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = False
        '
        'flxPrograma
        '
        Me.flxPrograma.Location = New System.Drawing.Point(6, 51)
        Me.flxPrograma.Name = "flxPrograma"
        Me.flxPrograma.OcxState = CType(resources.GetObject("flxPrograma.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxPrograma.Size = New System.Drawing.Size(668, 311)
        Me.flxPrograma.TabIndex = 13
        '
        'cmdSelecaoVeiculo
        '
        '
        'frmBaixa_Horario_Exibicao_Programa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(696, 443)
        Me.Controls.Add(Me.cmdReplicar)
        Me.Controls.Add(Me.cmdFiltroVeiculo)
        Me.Controls.Add(Me.cmdExibir)
        Me.Controls.Add(Me.txtNome_Veiculo)
        Me.Controls.Add(Me.txtVeiculo)
        Me.Controls.Add(Me.picVeiculo)
        Me.Controls.Add(Me.txtHorarioEmissora)
        Me.Controls.Add(Me.chkAjustarInicio)
        Me.Controls.Add(Me.txtData_Exibicao)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdData)
        Me.Controls.Add(Me.txtInicio_Real)
        Me.Controls.Add(Me.txtFinal_Real)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.fraParametro)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.flxPrograma)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(24, 69)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBaixa_Horario_Exibicao_Programa"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Baixa do Horário de Exibição de Programas"
        Me.picVeiculo.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.fraParametro.ResumeLayout(False)
        Me.fraParametro.PerformLayout()
        CType(Me.flxPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelecaoVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents ucVeiculo As WUC.UcText
#End Region
End Class