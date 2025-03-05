<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerceiroMotivoCancelamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMotivoCancelamento = New System.Windows.Forms.TextBox
        Me.btnOkCancel = New WUC.ucButton
        Me.SuspendLayout()
        '
        'txtMotivoCancelamento
        '
        Me.txtMotivoCancelamento.Location = New System.Drawing.Point(12, 12)
        Me.txtMotivoCancelamento.Multiline = True
        Me.txtMotivoCancelamento.Name = "txtMotivoCancelamento"
        Me.txtMotivoCancelamento.Size = New System.Drawing.Size(456, 196)
        Me.txtMotivoCancelamento.TabIndex = 0
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(289, 214)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 1
        '
        'frmTerceiroMotivoCancelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 255)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.txtMotivoCancelamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTerceiroMotivoCancelamento"
        Me.Text = "Motivo do Cancelamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMotivoCancelamento As System.Windows.Forms.TextBox
    Friend WithEvents btnOkCancel As WUC.ucButton
End Class
