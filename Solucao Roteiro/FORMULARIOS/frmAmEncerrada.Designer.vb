<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmEncerrada
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
        Me.gridAm = New System.Windows.Forms.DataGridView
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.btnVerAM = New System.Windows.Forms.Button
        Me.btnReabrir = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.lblTotalRegistros = New System.Windows.Forms.Label
        CType(Me.gridAm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridAm
        '
        Me.gridAm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gridAm.BackgroundColor = System.Drawing.Color.White
        Me.gridAm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAm.Location = New System.Drawing.Point(5, 3)
        Me.gridAm.Name = "gridAm"
        Me.gridAm.Size = New System.Drawing.Size(951, 490)
        Me.gridAm.TabIndex = 2
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(5, 499)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(95, 36)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.TabStop = False
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'btnVerAM
        '
        Me.btnVerAM.Location = New System.Drawing.Point(106, 499)
        Me.btnVerAM.Name = "btnVerAM"
        Me.btnVerAM.Size = New System.Drawing.Size(95, 36)
        Me.btnVerAM.TabIndex = 9
        Me.btnVerAM.TabStop = False
        Me.btnVerAM.Text = "Ver Am"
        Me.btnVerAM.UseVisualStyleBackColor = True
        '
        'btnReabrir
        '
        Me.btnReabrir.Location = New System.Drawing.Point(207, 499)
        Me.btnReabrir.Name = "btnReabrir"
        Me.btnReabrir.Size = New System.Drawing.Size(95, 36)
        Me.btnReabrir.TabIndex = 10
        Me.btnReabrir.TabStop = False
        Me.btnReabrir.Text = "Reabrir AM"
        Me.btnReabrir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(861, 499)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(95, 36)
        Me.btnSair.TabIndex = 12
        Me.btnSair.TabStop = False
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalRegistros.Location = New System.Drawing.Point(632, 505)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(223, 28)
        Me.lblTotalRegistros.TabIndex = 13
        Me.lblTotalRegistros.Text = "Total Selecionado: 0"
        Me.lblTotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAmEncerrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 542)
        Me.Controls.Add(Me.lblTotalRegistros)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnReabrir)
        Me.Controls.Add(Me.btnVerAM)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.gridAm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAmEncerrada"
        Me.Text = "Am´s Encerradas"
        CType(Me.gridAm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridAm As System.Windows.Forms.DataGridView
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnVerAM As System.Windows.Forms.Button
    Friend WithEvents btnReabrir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents lblTotalRegistros As System.Windows.Forms.Label
End Class
