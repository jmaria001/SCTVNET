<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelecaoVeiculo
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
        Me.gridVeiculo = New System.Windows.Forms.DataGridView
        Me.bntMarcar = New System.Windows.Forms.Button
        Me.btnDesmarcar = New System.Windows.Forms.Button
        Me.btnOkCancel = New WUC.ucButton
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridVeiculo
        '
        Me.gridVeiculo.BackgroundColor = System.Drawing.Color.White
        Me.gridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVeiculo.Location = New System.Drawing.Point(3, 2)
        Me.gridVeiculo.Name = "gridVeiculo"
        Me.gridVeiculo.Size = New System.Drawing.Size(422, 464)
        Me.gridVeiculo.TabIndex = 3
        '
        'bntMarcar
        '
        Me.bntMarcar.Location = New System.Drawing.Point(3, 475)
        Me.bntMarcar.Name = "bntMarcar"
        Me.bntMarcar.Size = New System.Drawing.Size(105, 32)
        Me.bntMarcar.TabIndex = 5
        Me.bntMarcar.TabStop = False
        Me.bntMarcar.Text = "Marcar Todos"
        Me.bntMarcar.UseVisualStyleBackColor = True
        '
        'btnDesmarcar
        '
        Me.btnDesmarcar.Location = New System.Drawing.Point(115, 475)
        Me.btnDesmarcar.Name = "btnDesmarcar"
        Me.btnDesmarcar.Size = New System.Drawing.Size(105, 32)
        Me.btnDesmarcar.TabIndex = 6
        Me.btnDesmarcar.TabStop = False
        Me.btnDesmarcar.Text = "Desmarcar Todos"
        Me.btnDesmarcar.UseVisualStyleBackColor = True
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(238, 472)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 2
        Me.btnOkCancel.TabStop = False
        '
        'frmSelecaoVeiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 514)
        Me.Controls.Add(Me.btnDesmarcar)
        Me.Controls.Add(Me.bntMarcar)
        Me.Controls.Add(Me.gridVeiculo)
        Me.Controls.Add(Me.btnOkCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelecaoVeiculo"
        Me.Text = "Seleção de Veiculos"
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridVeiculo As System.Windows.Forms.DataGridView
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents bntMarcar As System.Windows.Forms.Button
    Friend WithEvents btnDesmarcar As System.Windows.Forms.Button
End Class
