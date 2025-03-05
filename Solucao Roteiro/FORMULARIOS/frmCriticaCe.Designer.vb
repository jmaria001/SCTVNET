<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCriticaCe
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
        Me.gridCritica = New System.Windows.Forms.DataGridView
        Me.ucCritica = New WUC.ucButton
        CType(Me.gridCritica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridCritica
        '
        Me.gridCritica.BackgroundColor = System.Drawing.Color.White
        Me.gridCritica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCritica.Location = New System.Drawing.Point(13, 13)
        Me.gridCritica.Name = "gridCritica"
        Me.gridCritica.Size = New System.Drawing.Size(889, 484)
        Me.gridCritica.TabIndex = 0
        '
        'ucCritica
        '
        Me.ucCritica.BackColor = System.Drawing.SystemColors.Control
        Me.ucCritica.BotaoOkVisible = False
        Me.ucCritica.CancelaText = "Sair"
        Me.ucCritica.Location = New System.Drawing.Point(816, 503)
        Me.ucCritica.Name = "ucCritica"
        Me.ucCritica.Size = New System.Drawing.Size(86, 38)
        Me.ucCritica.TabIndex = 1
        '
        'frmCriticaCe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 547)
        Me.Controls.Add(Me.ucCritica)
        Me.Controls.Add(Me.gridCritica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCriticaCe"
        Me.Text = "Críticas na Emissão de Comprovante de Exibição"
        CType(Me.gridCritica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridCritica As System.Windows.Forms.DataGridView
    Friend WithEvents ucCritica As WUC.ucButton
End Class
