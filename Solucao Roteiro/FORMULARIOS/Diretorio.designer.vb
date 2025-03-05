<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDiretorio
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
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
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtDiretorio As System.Windows.Forms.TextBox
	Public WithEvents dirDiretorio As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
	Public WithEvents drvDiretorio As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.txtDiretorio = New System.Windows.Forms.TextBox
        Me.dirDiretorio = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.drvDiretorio = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(237, 243)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(64, 25)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(165, 243)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(64, 25)
        Me.cmdOk.TabIndex = 3
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'txtDiretorio
        '
        Me.txtDiretorio.AcceptsReturn = True
        Me.txtDiretorio.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiretorio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiretorio.Enabled = False
        Me.txtDiretorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiretorio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiretorio.Location = New System.Drawing.Point(6, 216)
        Me.txtDiretorio.MaxLength = 0
        Me.txtDiretorio.Name = "txtDiretorio"
        Me.txtDiretorio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiretorio.Size = New System.Drawing.Size(292, 22)
        Me.txtDiretorio.TabIndex = 2
        '
        'dirDiretorio
        '
        Me.dirDiretorio.BackColor = System.Drawing.SystemColors.Window
        Me.dirDiretorio.Cursor = System.Windows.Forms.Cursors.Default
        Me.dirDiretorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dirDiretorio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dirDiretorio.FormattingEnabled = True
        Me.dirDiretorio.IntegralHeight = False
        Me.dirDiretorio.Location = New System.Drawing.Point(3, 27)
        Me.dirDiretorio.Name = "dirDiretorio"
        Me.dirDiretorio.Size = New System.Drawing.Size(295, 186)
        Me.dirDiretorio.TabIndex = 1
        '
        'drvDiretorio
        '
        Me.drvDiretorio.BackColor = System.Drawing.SystemColors.Window
        Me.drvDiretorio.Cursor = System.Windows.Forms.Cursors.Default
        Me.drvDiretorio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drvDiretorio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.drvDiretorio.FormattingEnabled = True
        Me.drvDiretorio.Location = New System.Drawing.Point(3, 3)
        Me.drvDiretorio.Name = "drvDiretorio"
        Me.drvDiretorio.Size = New System.Drawing.Size(295, 21)
        Me.drvDiretorio.TabIndex = 0
        '
        'frmDiretorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(307, 273)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtDiretorio)
        Me.Controls.Add(Me.dirDiretorio)
        Me.Controls.Add(Me.drvDiretorio)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(198, 128)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDiretorio"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diretórios"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class