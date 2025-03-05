<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTempoBreakV2
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
	Public WithEvents _chkTipoIntervalo_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkTipoIntervalo_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkTipoIntervalo_0 As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _optOpcoes_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcoes_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcoes_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancela As System.Windows.Forms.Button
	Public WithEvents flxTempoBreak As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents chkTipoIntervalo As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents optOpcoes As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTempoBreakV2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me._chkTipoIntervalo_2 = New System.Windows.Forms.CheckBox
        Me._chkTipoIntervalo_1 = New System.Windows.Forms.CheckBox
        Me._chkTipoIntervalo_0 = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._optOpcoes_2 = New System.Windows.Forms.RadioButton
        Me._optOpcoes_1 = New System.Windows.Forms.RadioButton
        Me._optOpcoes_0 = New System.Windows.Forms.RadioButton
        Me.cmdCancela = New System.Windows.Forms.Button
        Me.flxTempoBreak = New AxMSFlexGridLib.AxMSFlexGrid
        Me.chkTipoIntervalo = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.optOpcoes = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.flxTempoBreak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTipoIntervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optOpcoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me._chkTipoIntervalo_2)
        Me.Frame2.Controls.Add(Me._chkTipoIntervalo_1)
        Me.Frame2.Controls.Add(Me._chkTipoIntervalo_0)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(243, 306)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(163, 100)
        Me.Frame2.TabIndex = 6
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Visualizar"
        '
        '_chkTipoIntervalo_2
        '
        Me._chkTipoIntervalo_2.AutoSize = True
        Me._chkTipoIntervalo_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkTipoIntervalo_2.Checked = True
        Me._chkTipoIntervalo_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkTipoIntervalo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkTipoIntervalo_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkTipoIntervalo_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTipoIntervalo.SetIndex(Me._chkTipoIntervalo_2, CType(2, Short))
        Me._chkTipoIntervalo_2.Location = New System.Drawing.Point(18, 75)
        Me._chkTipoIntervalo_2.Name = "_chkTipoIntervalo_2"
        Me._chkTipoIntervalo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkTipoIntervalo_2.Size = New System.Drawing.Size(110, 18)
        Me._chkTipoIntervalo_2.TabIndex = 9
        Me._chkTipoIntervalo_2.Text = "Intervalo Artistico"
        Me._chkTipoIntervalo_2.UseVisualStyleBackColor = False
        '
        '_chkTipoIntervalo_1
        '
        Me._chkTipoIntervalo_1.AutoSize = True
        Me._chkTipoIntervalo_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkTipoIntervalo_1.Checked = True
        Me._chkTipoIntervalo_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkTipoIntervalo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkTipoIntervalo_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkTipoIntervalo_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTipoIntervalo.SetIndex(Me._chkTipoIntervalo_1, CType(1, Short))
        Me._chkTipoIntervalo_1.Location = New System.Drawing.Point(18, 48)
        Me._chkTipoIntervalo_1.Name = "_chkTipoIntervalo_1"
        Me._chkTipoIntervalo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkTipoIntervalo_1.Size = New System.Drawing.Size(117, 18)
        Me._chkTipoIntervalo_1.TabIndex = 8
        Me._chkTipoIntervalo_1.Text = "Intervalo Local/P.E."
        Me._chkTipoIntervalo_1.UseVisualStyleBackColor = False
        '
        '_chkTipoIntervalo_0
        '
        Me._chkTipoIntervalo_0.AutoSize = True
        Me._chkTipoIntervalo_0.BackColor = System.Drawing.SystemColors.Control
        Me._chkTipoIntervalo_0.Checked = True
        Me._chkTipoIntervalo_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkTipoIntervalo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkTipoIntervalo_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkTipoIntervalo_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTipoIntervalo.SetIndex(Me._chkTipoIntervalo_0, CType(0, Short))
        Me._chkTipoIntervalo_0.Location = New System.Drawing.Point(18, 24)
        Me._chkTipoIntervalo_0.Name = "_chkTipoIntervalo_0"
        Me._chkTipoIntervalo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkTipoIntervalo_0.Size = New System.Drawing.Size(86, 18)
        Me._chkTipoIntervalo_0.TabIndex = 7
        Me._chkTipoIntervalo_0.Text = "Intervalo Net"
        Me._chkTipoIntervalo_0.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.AutoSize = True
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._optOpcoes_2)
        Me.Frame1.Controls.Add(Me._optOpcoes_1)
        Me.Frame1.Controls.Add(Me._optOpcoes_0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(3, 306)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(232, 112)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Opções"
        '
        '_optOpcoes_2
        '
        Me._optOpcoes_2.AutoSize = True
        Me._optOpcoes_2.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcoes_2.Checked = True
        Me._optOpcoes_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcoes_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optOpcoes_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcoes.SetIndex(Me._optOpcoes_2, CType(2, Short))
        Me._optOpcoes_2.Location = New System.Drawing.Point(15, 75)
        Me._optOpcoes_2.Name = "_optOpcoes_2"
        Me._optOpcoes_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcoes_2.Size = New System.Drawing.Size(97, 18)
        Me._optOpcoes_2.TabIndex = 5
        Me._optOpcoes_2.TabStop = True
        Me._optOpcoes_2.Text = "Mostrar ambos"
        Me._optOpcoes_2.UseVisualStyleBackColor = False
        '
        '_optOpcoes_1
        '
        Me._optOpcoes_1.AutoSize = True
        Me._optOpcoes_1.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcoes_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcoes_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optOpcoes_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcoes.SetIndex(Me._optOpcoes_1, CType(1, Short))
        Me._optOpcoes_1.Location = New System.Drawing.Point(15, 51)
        Me._optOpcoes_1.Name = "_optOpcoes_1"
        Me._optOpcoes_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcoes_1.Size = New System.Drawing.Size(188, 18)
        Me._optOpcoes_1.TabIndex = 4
        Me._optOpcoes_1.TabStop = True
        Me._optOpcoes_1.Text = "Mostrar Somente não divergentes"
        Me._optOpcoes_1.UseVisualStyleBackColor = False
        '
        '_optOpcoes_0
        '
        Me._optOpcoes_0.AutoSize = True
        Me._optOpcoes_0.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcoes_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcoes_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optOpcoes_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcoes.SetIndex(Me._optOpcoes_0, CType(0, Short))
        Me._optOpcoes_0.Location = New System.Drawing.Point(15, 27)
        Me._optOpcoes_0.Name = "_optOpcoes_0"
        Me._optOpcoes_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcoes_0.Size = New System.Drawing.Size(168, 18)
        Me._optOpcoes_0.TabIndex = 3
        Me._optOpcoes_0.TabStop = True
        Me._optOpcoes_0.Text = "Mostrar Somente Divergentes"
        Me._optOpcoes_0.UseVisualStyleBackColor = False
        '
        'cmdCancela
        '
        Me.cmdCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancela.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.Location = New System.Drawing.Point(420, 372)
        Me.cmdCancela.Name = "cmdCancela"
        Me.cmdCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancela.Size = New System.Drawing.Size(64, 31)
        Me.cmdCancela.TabIndex = 1
        Me.cmdCancela.Text = "Fechar"
        Me.cmdCancela.UseVisualStyleBackColor = False
        '
        'flxTempoBreak
        '
        Me.flxTempoBreak.Location = New System.Drawing.Point(3, 6)
        Me.flxTempoBreak.Name = "flxTempoBreak"
        Me.flxTempoBreak.OcxState = CType(resources.GetObject("flxTempoBreak.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxTempoBreak.Size = New System.Drawing.Size(478, 294)
        Me.flxTempoBreak.TabIndex = 0
        '
        'chkTipoIntervalo
        '
        '
        'optOpcoes
        '
        '
        'frmTempoBreakV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(487, 417)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancela)
        Me.Controls.Add(Me.flxTempoBreak)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(368, 303)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTempoBreakV2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consistencia dos Tempos dos Breaks"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.flxTempoBreak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTipoIntervalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optOpcoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class