<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Me.gridConsulta = New System.Windows.Forms.DataGridView
        Me.btnOkCancel = New WUC.ucButton
        CType(Me.gridConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridConsulta
        '
        Me.gridConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridConsulta.BackgroundColor = System.Drawing.Color.White
        Me.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridConsulta.Location = New System.Drawing.Point(6, 2)
        Me.gridConsulta.Name = "gridConsulta"
        Me.gridConsulta.Size = New System.Drawing.Size(414, 448)
        Me.gridConsulta.TabIndex = 4
        '
        'btnOkCancel
        '
        Me.btnOkCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOkCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOkCancel.Location = New System.Drawing.Point(232, 466)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 6
        Me.btnOkCancel.TabStop = False
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(423, 506)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.gridConsulta)
        Me.Name = "frmConsulta"
        Me.Text = "Consulta"
        CType(Me.gridConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents btnOkCancel As WUC.ucButton
End Class
