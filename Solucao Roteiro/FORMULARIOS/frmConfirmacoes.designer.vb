<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConfirmacoes
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
	Public WithEvents cmdSair As System.Windows.Forms.Button
	Public WithEvents flxConfirmacoes As AxMSFlexGridLib.AxMSFlexGrid
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmacoes))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdSair = New System.Windows.Forms.Button
        Me.flxConfirmacoes = New AxMSFlexGridLib.AxMSFlexGrid
        CType(Me.flxConfirmacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(232, 270)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(83, 35)
        Me.cmdSair.TabIndex = 1
        Me.cmdSair.Text = "Sai&r"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'flxConfirmacoes
        '
        Me.flxConfirmacoes.Location = New System.Drawing.Point(12, 14)
        Me.flxConfirmacoes.Name = "flxConfirmacoes"
        Me.flxConfirmacoes.OcxState = CType(resources.GetObject("flxConfirmacoes.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxConfirmacoes.Size = New System.Drawing.Size(303, 253)
        Me.flxConfirmacoes.TabIndex = 0
        '
        'frmConfirmacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(333, 309)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.flxConfirmacoes)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfirmacoes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirma��es Existentes"
        CType(Me.flxConfirmacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class