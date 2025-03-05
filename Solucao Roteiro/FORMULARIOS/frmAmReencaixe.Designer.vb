<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmReencaixe
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblContrato = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblSequencia = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblVeiculo = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblNumeroDocto = New System.Windows.Forms.Label
        Me.gridAm = New System.Windows.Forms.DataGridView
        Me.btnMarcar = New System.Windows.Forms.Button
        Me.btnDesmarcar = New System.Windows.Forms.Button
        Me.btnReencaixe = New WUC.ucButton
        Me.lblNomeVeiculo = New System.Windows.Forms.Label
        CType(Me.gridAm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Contrato"
        '
        'lblContrato
        '
        Me.lblContrato.BackColor = System.Drawing.Color.White
        Me.lblContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContrato.Location = New System.Drawing.Point(65, 27)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(86, 22)
        Me.lblContrato.TabIndex = 31
        Me.lblContrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Empresa"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BackColor = System.Drawing.Color.White
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(12, 27)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(45, 22)
        Me.lblEmpresa.TabIndex = 33
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(154, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Seq"
        '
        'lblSequencia
        '
        Me.lblSequencia.BackColor = System.Drawing.Color.White
        Me.lblSequencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSequencia.Location = New System.Drawing.Point(157, 27)
        Me.lblSequencia.Name = "lblSequencia"
        Me.lblSequencia.Size = New System.Drawing.Size(34, 22)
        Me.lblSequencia.TabIndex = 37
        Me.lblSequencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(194, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Veículo"
        '
        'lblVeiculo
        '
        Me.lblVeiculo.BackColor = System.Drawing.Color.White
        Me.lblVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVeiculo.Location = New System.Drawing.Point(197, 27)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(50, 22)
        Me.lblVeiculo.TabIndex = 39
        Me.lblVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(688, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Documento"
        '
        'lblNumeroDocto
        '
        Me.lblNumeroDocto.BackColor = System.Drawing.Color.White
        Me.lblNumeroDocto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroDocto.Location = New System.Drawing.Point(691, 27)
        Me.lblNumeroDocto.Name = "lblNumeroDocto"
        Me.lblNumeroDocto.Size = New System.Drawing.Size(98, 22)
        Me.lblNumeroDocto.TabIndex = 41
        Me.lblNumeroDocto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridAm
        '
        Me.gridAm.BackgroundColor = System.Drawing.Color.White
        Me.gridAm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAm.Location = New System.Drawing.Point(12, 52)
        Me.gridAm.Name = "gridAm"
        Me.gridAm.Size = New System.Drawing.Size(777, 410)
        Me.gridAm.TabIndex = 42
        '
        'btnMarcar
        '
        Me.btnMarcar.Location = New System.Drawing.Point(12, 475)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(101, 31)
        Me.btnMarcar.TabIndex = 44
        Me.btnMarcar.Text = "Marcar Todos"
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'btnDesmarcar
        '
        Me.btnDesmarcar.Location = New System.Drawing.Point(119, 475)
        Me.btnDesmarcar.Name = "btnDesmarcar"
        Me.btnDesmarcar.Size = New System.Drawing.Size(101, 31)
        Me.btnDesmarcar.TabIndex = 45
        Me.btnDesmarcar.Text = "Desmarcar Todos"
        Me.btnDesmarcar.UseVisualStyleBackColor = True
        '
        'btnReencaixe
        '
        Me.btnReencaixe.BackColor = System.Drawing.SystemColors.Control
        Me.btnReencaixe.Location = New System.Drawing.Point(610, 468)
        Me.btnReencaixe.Name = "btnReencaixe"
        Me.btnReencaixe.Size = New System.Drawing.Size(179, 38)
        Me.btnReencaixe.TabIndex = 43
        '
        'lblNomeVeiculo
        '
        Me.lblNomeVeiculo.BackColor = System.Drawing.Color.White
        Me.lblNomeVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNomeVeiculo.Location = New System.Drawing.Point(244, 27)
        Me.lblNomeVeiculo.Name = "lblNomeVeiculo"
        Me.lblNomeVeiculo.Size = New System.Drawing.Size(441, 22)
        Me.lblNomeVeiculo.TabIndex = 46
        Me.lblNomeVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAmReencaixe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 512)
        Me.Controls.Add(Me.lblNomeVeiculo)
        Me.Controls.Add(Me.btnDesmarcar)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.btnReencaixe)
        Me.Controls.Add(Me.gridAm)
        Me.Controls.Add(Me.lblNumeroDocto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSequencia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblContrato)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVeiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAmReencaixe"
        Me.Text = "Reencaixe de Falhas"
        CType(Me.gridAm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblContrato As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSequencia As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblVeiculo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDocto As System.Windows.Forms.Label
    Friend WithEvents gridAm As System.Windows.Forms.DataGridView
    Friend WithEvents btnReencaixe As WUC.ucButton
    Friend WithEvents btnMarcar As System.Windows.Forms.Button
    Friend WithEvents btnDesmarcar As System.Windows.Forms.Button
    Friend WithEvents lblNomeVeiculo As System.Windows.Forms.Label
End Class
