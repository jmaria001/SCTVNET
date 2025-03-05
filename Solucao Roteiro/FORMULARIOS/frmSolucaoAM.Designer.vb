<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolucaoAM
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblFalhasValor = New System.Windows.Forms.Label
        Me.lblDiferencaValor = New System.Windows.Forms.Label
        Me.lblCompensacaoValor = New System.Windows.Forms.Label
        Me.lblFalhasQtd = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblDiferencaQtd = New System.Windows.Forms.Label
        Me.lblCompensacaoQTD = New System.Windows.Forms.Label
        Me.lblCompetencia = New System.Windows.Forms.Label
        Me.lblAM = New System.Windows.Forms.Label
        Me.lblVeiculo = New System.Windows.Forms.Label
        Me.lblContrato = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.groupSolucao = New System.Windows.Forms.GroupBox
        Me.optFaturar = New System.Windows.Forms.RadioButton
        Me.optCreditar = New System.Windows.Forms.RadioButton
        Me.optFaturarSemCredito = New System.Windows.Forms.RadioButton
        Me.optDeduzir = New System.Windows.Forms.RadioButton
        Me.optPonderar = New System.Windows.Forms.RadioButton
        Me.btnSolucao = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        Me.groupSolucao.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFalhasValor)
        Me.GroupBox1.Controls.Add(Me.lblDiferencaValor)
        Me.GroupBox1.Controls.Add(Me.lblCompensacaoValor)
        Me.GroupBox1.Controls.Add(Me.lblFalhasQtd)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lblDiferencaQtd)
        Me.GroupBox1.Controls.Add(Me.lblCompensacaoQTD)
        Me.GroupBox1.Controls.Add(Me.lblCompetencia)
        Me.GroupBox1.Controls.Add(Me.lblAM)
        Me.GroupBox1.Controls.Add(Me.lblVeiculo)
        Me.GroupBox1.Controls.Add(Me.lblContrato)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 237)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Documento"
        '
        'lblFalhasValor
        '
        Me.lblFalhasValor.BackColor = System.Drawing.Color.White
        Me.lblFalhasValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFalhasValor.Location = New System.Drawing.Point(181, 142)
        Me.lblFalhasValor.Name = "lblFalhasValor"
        Me.lblFalhasValor.Size = New System.Drawing.Size(96, 22)
        Me.lblFalhasValor.TabIndex = 40
        Me.lblFalhasValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiferencaValor
        '
        Me.lblDiferencaValor.BackColor = System.Drawing.Color.White
        Me.lblDiferencaValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiferencaValor.Location = New System.Drawing.Point(181, 200)
        Me.lblDiferencaValor.Name = "lblDiferencaValor"
        Me.lblDiferencaValor.Size = New System.Drawing.Size(96, 22)
        Me.lblDiferencaValor.TabIndex = 39
        Me.lblDiferencaValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompensacaoValor
        '
        Me.lblCompensacaoValor.BackColor = System.Drawing.Color.White
        Me.lblCompensacaoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompensacaoValor.Location = New System.Drawing.Point(181, 171)
        Me.lblCompensacaoValor.Name = "lblCompensacaoValor"
        Me.lblCompensacaoValor.Size = New System.Drawing.Size(96, 22)
        Me.lblCompensacaoValor.TabIndex = 38
        Me.lblCompensacaoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFalhasQtd
        '
        Me.lblFalhasQtd.BackColor = System.Drawing.Color.White
        Me.lblFalhasQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFalhasQtd.Location = New System.Drawing.Point(134, 143)
        Me.lblFalhasQtd.Name = "lblFalhasQtd"
        Me.lblFalhasQtd.Size = New System.Drawing.Size(41, 22)
        Me.lblFalhasQtd.TabIndex = 37
        Me.lblFalhasQtd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Falhas"
        '
        'lblDiferencaQtd
        '
        Me.lblDiferencaQtd.BackColor = System.Drawing.Color.White
        Me.lblDiferencaQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiferencaQtd.Location = New System.Drawing.Point(134, 200)
        Me.lblDiferencaQtd.Name = "lblDiferencaQtd"
        Me.lblDiferencaQtd.Size = New System.Drawing.Size(41, 22)
        Me.lblDiferencaQtd.TabIndex = 35
        Me.lblDiferencaQtd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompensacaoQTD
        '
        Me.lblCompensacaoQTD.BackColor = System.Drawing.Color.White
        Me.lblCompensacaoQTD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompensacaoQTD.Location = New System.Drawing.Point(134, 171)
        Me.lblCompensacaoQTD.Name = "lblCompensacaoQTD"
        Me.lblCompensacaoQTD.Size = New System.Drawing.Size(41, 22)
        Me.lblCompensacaoQTD.TabIndex = 34
        Me.lblCompensacaoQTD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompetencia
        '
        Me.lblCompetencia.BackColor = System.Drawing.Color.White
        Me.lblCompetencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompetencia.Location = New System.Drawing.Point(134, 113)
        Me.lblCompetencia.Name = "lblCompetencia"
        Me.lblCompetencia.Size = New System.Drawing.Size(143, 22)
        Me.lblCompetencia.TabIndex = 33
        Me.lblCompetencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAM
        '
        Me.lblAM.BackColor = System.Drawing.Color.White
        Me.lblAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAM.Location = New System.Drawing.Point(134, 84)
        Me.lblAM.Name = "lblAM"
        Me.lblAM.Size = New System.Drawing.Size(143, 22)
        Me.lblAM.TabIndex = 32
        Me.lblAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVeiculo
        '
        Me.lblVeiculo.BackColor = System.Drawing.Color.White
        Me.lblVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVeiculo.Location = New System.Drawing.Point(134, 55)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(143, 22)
        Me.lblVeiculo.TabIndex = 31
        Me.lblVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContrato
        '
        Me.lblContrato.BackColor = System.Drawing.Color.White
        Me.lblContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContrato.Location = New System.Drawing.Point(134, 26)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(143, 22)
        Me.lblContrato.TabIndex = 29
        Me.lblContrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Diferença"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Compensações"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Campanha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "AM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Veículo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Contrato"
        '
        'groupSolucao
        '
        Me.groupSolucao.Controls.Add(Me.optFaturar)
        Me.groupSolucao.Controls.Add(Me.optCreditar)
        Me.groupSolucao.Controls.Add(Me.optFaturarSemCredito)
        Me.groupSolucao.Controls.Add(Me.optDeduzir)
        Me.groupSolucao.Controls.Add(Me.optPonderar)
        Me.groupSolucao.Location = New System.Drawing.Point(335, 12)
        Me.groupSolucao.Name = "groupSolucao"
        Me.groupSolucao.Size = New System.Drawing.Size(214, 189)
        Me.groupSolucao.TabIndex = 21
        Me.groupSolucao.TabStop = False
        Me.groupSolucao.Text = "Solução"
        '
        'optFaturar
        '
        Me.optFaturar.AutoSize = True
        Me.optFaturar.Location = New System.Drawing.Point(34, 145)
        Me.optFaturar.Name = "optFaturar"
        Me.optFaturar.Size = New System.Drawing.Size(58, 17)
        Me.optFaturar.TabIndex = 4
        Me.optFaturar.TabStop = True
        Me.optFaturar.Text = "Faturar"
        Me.optFaturar.UseVisualStyleBackColor = True
        '
        'optCreditar
        '
        Me.optCreditar.AutoSize = True
        Me.optCreditar.Location = New System.Drawing.Point(34, 116)
        Me.optCreditar.Name = "optCreditar"
        Me.optCreditar.Size = New System.Drawing.Size(61, 17)
        Me.optCreditar.TabIndex = 3
        Me.optCreditar.TabStop = True
        Me.optCreditar.Text = "Creditar"
        Me.optCreditar.UseVisualStyleBackColor = True
        '
        'optFaturarSemCredito
        '
        Me.optFaturarSemCredito.AutoSize = True
        Me.optFaturarSemCredito.Location = New System.Drawing.Point(34, 87)
        Me.optFaturarSemCredito.Name = "optFaturarSemCredito"
        Me.optFaturarSemCredito.Size = New System.Drawing.Size(116, 17)
        Me.optFaturarSemCredito.TabIndex = 2
        Me.optFaturarSemCredito.TabStop = True
        Me.optFaturarSemCredito.Text = "Faturar sem Crédito"
        Me.optFaturarSemCredito.UseVisualStyleBackColor = True
        '
        'optDeduzir
        '
        Me.optDeduzir.AutoSize = True
        Me.optDeduzir.Location = New System.Drawing.Point(34, 58)
        Me.optDeduzir.Name = "optDeduzir"
        Me.optDeduzir.Size = New System.Drawing.Size(61, 17)
        Me.optDeduzir.TabIndex = 1
        Me.optDeduzir.TabStop = True
        Me.optDeduzir.Text = "Deduzir"
        Me.optDeduzir.UseVisualStyleBackColor = True
        '
        'optPonderar
        '
        Me.optPonderar.AutoSize = True
        Me.optPonderar.Location = New System.Drawing.Point(34, 29)
        Me.optPonderar.Name = "optPonderar"
        Me.optPonderar.Size = New System.Drawing.Size(68, 17)
        Me.optPonderar.TabIndex = 0
        Me.optPonderar.TabStop = True
        Me.optPonderar.Text = "Ponderar"
        Me.optPonderar.UseVisualStyleBackColor = True
        '
        'btnSolucao
        '
        Me.btnSolucao.BackColor = System.Drawing.SystemColors.Control
        Me.btnSolucao.Location = New System.Drawing.Point(370, 211)
        Me.btnSolucao.Name = "btnSolucao"
        Me.btnSolucao.Size = New System.Drawing.Size(179, 38)
        Me.btnSolucao.TabIndex = 22
        '
        'frmSolucaoAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 268)
        Me.Controls.Add(Me.btnSolucao)
        Me.Controls.Add(Me.groupSolucao)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmSolucaoAM"
        Me.Text = "Encerramento de AM´s"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupSolucao.ResumeLayout(False)
        Me.groupSolucao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDiferencaValor As System.Windows.Forms.Label
    Friend WithEvents lblCompensacaoValor As System.Windows.Forms.Label
    Friend WithEvents lblFalhasQtd As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblDiferencaQtd As System.Windows.Forms.Label
    Friend WithEvents lblCompensacaoQTD As System.Windows.Forms.Label
    Friend WithEvents lblCompetencia As System.Windows.Forms.Label
    Friend WithEvents lblAM As System.Windows.Forms.Label
    Friend WithEvents lblVeiculo As System.Windows.Forms.Label
    Friend WithEvents lblContrato As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents groupSolucao As System.Windows.Forms.GroupBox
    Friend WithEvents optFaturar As System.Windows.Forms.RadioButton
    Friend WithEvents optCreditar As System.Windows.Forms.RadioButton
    Friend WithEvents optFaturarSemCredito As System.Windows.Forms.RadioButton
    Friend WithEvents optDeduzir As System.Windows.Forms.RadioButton
    Friend WithEvents optPonderar As System.Windows.Forms.RadioButton
    Friend WithEvents btnSolucao As WUC.ucButton
    Friend WithEvents lblFalhasValor As System.Windows.Forms.Label
End Class
