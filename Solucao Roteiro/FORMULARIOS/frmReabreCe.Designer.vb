<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReabreCe
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
        Me.txtMotivo = New System.Windows.Forms.TextBox
        Me.ucVeiculo = New WUC.UcText
        Me.ucSequencia = New WUC.UcText
        Me.ucContrato = New WUC.UcText
        Me.ucEmpresa = New WUC.UcText
        Me.btnOkCancel = New WUC.ucButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMotivo)
        Me.GroupBox1.Controls.Add(Me.ucVeiculo)
        Me.GroupBox1.Controls.Add(Me.ucSequencia)
        Me.GroupBox1.Controls.Add(Me.ucContrato)
        Me.GroupBox1.Controls.Add(Me.ucEmpresa)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 267)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Comprovante"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(7, 130)
        Me.txtMotivo.MaxLength = 2000
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(386, 131)
        Me.txtMotivo.TabIndex = 0
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(6, 82)
        Me.ucVeiculo.MaxLength = 3
        Me.ucVeiculo.Name = "ucVeiculo"
        Me.ucVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVeiculo.pDecimal = CType(0, Byte)
        Me.ucVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVeiculo.showButton = True
        Me.ucVeiculo.ShowDescricao = True
        Me.ucVeiculo.Size = New System.Drawing.Size(387, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 4
        Me.ucVeiculo.TextBoxLeft = CType(50, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'ucSequencia
        '
        Me.ucSequencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucSequencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucSequencia.Caption = "Sequencia"
        Me.ucSequencia.DataTextValue = Nothing
        Me.ucSequencia.Location = New System.Drawing.Point(157, 51)
        Me.ucSequencia.MaxLength = 2
        Me.ucSequencia.Name = "ucSequencia"
        Me.ucSequencia.Obrigatorio = True
        Me.ucSequencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucSequencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucSequencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucSequencia.pDecimal = CType(0, Byte)
        Me.ucSequencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucSequencia.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucSequencia.Size = New System.Drawing.Size(109, 25)
        Me.ucSequencia.sqlQuery = Nothing
        Me.ucSequencia.TabIndex = 3
        Me.ucSequencia.TextBoxLeft = CType(0, Short)
        Me.ucSequencia.TextWidth = 0
        '
        'ucContrato
        '
        Me.ucContrato.BackColor = System.Drawing.SystemColors.Control
        Me.ucContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucContrato.Caption = "Contrato"
        Me.ucContrato.DataTextValue = Nothing
        Me.ucContrato.Location = New System.Drawing.Point(6, 51)
        Me.ucContrato.MaxLength = 10
        Me.ucContrato.Name = "ucContrato"
        Me.ucContrato.Obrigatorio = True
        Me.ucContrato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucContrato.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucContrato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucContrato.pDecimal = CType(0, Byte)
        Me.ucContrato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucContrato.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucContrato.Size = New System.Drawing.Size(145, 25)
        Me.ucContrato.sqlQuery = Nothing
        Me.ucContrato.TabIndex = 2
        Me.ucContrato.TextBoxLeft = CType(50, Short)
        Me.ucContrato.TextWidth = 0
        '
        'ucEmpresa
        '
        Me.ucEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.ucEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucEmpresa.Caption = "Empresa"
        Me.ucEmpresa.DataTextValue = Nothing
        Me.ucEmpresa.Location = New System.Drawing.Point(6, 19)
        Me.ucEmpresa.MaxLength = 3
        Me.ucEmpresa.Name = "ucEmpresa"
        Me.ucEmpresa.Obrigatorio = True
        Me.ucEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucEmpresa.pDecimal = CType(0, Byte)
        Me.ucEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.ucEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucEmpresa.showButton = True
        Me.ucEmpresa.ShowDescricao = True
        Me.ucEmpresa.Size = New System.Drawing.Size(387, 25)
        Me.ucEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.ucEmpresa.TabIndex = 1
        Me.ucEmpresa.TextBoxLeft = CType(50, Short)
        Me.ucEmpresa.TextWidth = 0
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(233, 299)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 1
        Me.btnOkCancel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Motivo da Reabertura"
        '
        'frmReabreCe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 345)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReabreCe"
        Me.Text = "Reabertura de Comprovante de Exibição"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents ucSequencia As WUC.UcText
    Friend WithEvents ucContrato As WUC.UcText
    Friend WithEvents ucEmpresa As WUC.UcText
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
