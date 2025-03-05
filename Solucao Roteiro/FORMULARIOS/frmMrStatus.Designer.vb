<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrStatus
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
        Me.GroupStatus = New System.Windows.Forms.GroupBox
        Me.lblQtdAms = New System.Windows.Forms.Label
        Me.lblQtdGravadas = New System.Windows.Forms.Label
        Me.lblNegociacao = New System.Windows.Forms.Label
        Me.lblSequencia = New System.Windows.Forms.Label
        Me.lblContrato = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnHistorico = New System.Windows.Forms.Button
        Me.btnVoltar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.GroupStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupStatus
        '
        Me.GroupStatus.Controls.Add(Me.lblQtdAms)
        Me.GroupStatus.Controls.Add(Me.lblQtdGravadas)
        Me.GroupStatus.Controls.Add(Me.lblNegociacao)
        Me.GroupStatus.Controls.Add(Me.lblSequencia)
        Me.GroupStatus.Controls.Add(Me.lblContrato)
        Me.GroupStatus.Controls.Add(Me.Label11)
        Me.GroupStatus.Controls.Add(Me.Label10)
        Me.GroupStatus.Controls.Add(Me.Label8)
        Me.GroupStatus.Controls.Add(Me.Label6)
        Me.GroupStatus.Controls.Add(Me.Label4)
        Me.GroupStatus.Controls.Add(Me.lblEmpresa)
        Me.GroupStatus.Controls.Add(Me.Label1)
        Me.GroupStatus.Location = New System.Drawing.Point(12, 12)
        Me.GroupStatus.Name = "GroupStatus"
        Me.GroupStatus.Size = New System.Drawing.Size(245, 196)
        Me.GroupStatus.TabIndex = 0
        Me.GroupStatus.TabStop = False
        '
        'lblQtdAms
        '
        Me.lblQtdAms.BackColor = System.Drawing.Color.White
        Me.lblQtdAms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQtdAms.Location = New System.Drawing.Point(140, 164)
        Me.lblQtdAms.Name = "lblQtdAms"
        Me.lblQtdAms.Size = New System.Drawing.Size(87, 18)
        Me.lblQtdAms.TabIndex = 26
        Me.lblQtdAms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQtdGravadas
        '
        Me.lblQtdGravadas.BackColor = System.Drawing.Color.White
        Me.lblQtdGravadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQtdGravadas.Location = New System.Drawing.Point(140, 136)
        Me.lblQtdGravadas.Name = "lblQtdGravadas"
        Me.lblQtdGravadas.Size = New System.Drawing.Size(87, 18)
        Me.lblQtdGravadas.TabIndex = 25
        Me.lblQtdGravadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNegociacao
        '
        Me.lblNegociacao.BackColor = System.Drawing.Color.White
        Me.lblNegociacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNegociacao.Location = New System.Drawing.Point(140, 108)
        Me.lblNegociacao.Name = "lblNegociacao"
        Me.lblNegociacao.Size = New System.Drawing.Size(87, 18)
        Me.lblNegociacao.TabIndex = 24
        Me.lblNegociacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSequencia
        '
        Me.lblSequencia.BackColor = System.Drawing.Color.White
        Me.lblSequencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSequencia.Location = New System.Drawing.Point(140, 80)
        Me.lblSequencia.Name = "lblSequencia"
        Me.lblSequencia.Size = New System.Drawing.Size(87, 18)
        Me.lblSequencia.TabIndex = 23
        Me.lblSequencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContrato
        '
        Me.lblContrato.BackColor = System.Drawing.Color.White
        Me.lblContrato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblContrato.Location = New System.Drawing.Point(140, 52)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(87, 18)
        Me.lblContrato.TabIndex = 22
        Me.lblContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Veiculações com AM´s"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Veiculações gravadas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Negociação"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Sequencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Contrato"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BackColor = System.Drawing.Color.White
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpresa.Location = New System.Drawing.Point(140, 24)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(87, 18)
        Me.lblEmpresa.TabIndex = 12
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Empresa"
        '
        'btnHistorico
        '
        Me.btnHistorico.Location = New System.Drawing.Point(264, 79)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(153, 34)
        Me.btnHistorico.TabIndex = 1
        Me.btnHistorico.Text = "Ver Histórico do MR"
        Me.btnHistorico.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(264, 127)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(153, 34)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar a Manutenção"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(264, 175)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(153, 34)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair do MR"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmMrStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnHistorico)
        Me.Controls.Add(Me.GroupStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMrStatus"
        Me.Text = "Status da Gravação do Contrato"
        Me.GroupStatus.ResumeLayout(False)
        Me.GroupStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupStatus As System.Windows.Forms.GroupBox
    Friend WithEvents lblQtdAms As System.Windows.Forms.Label
    Friend WithEvents lblQtdGravadas As System.Windows.Forms.Label
    Friend WithEvents lblNegociacao As System.Windows.Forms.Label
    Friend WithEvents lblSequencia As System.Windows.Forms.Label
    Friend WithEvents lblContrato As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHistorico As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
