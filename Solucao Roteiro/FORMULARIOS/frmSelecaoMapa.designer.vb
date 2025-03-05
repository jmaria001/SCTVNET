<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelecaoMapa
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
        Me.txtSequenciaMr = New WUC.UcText
        Me.txtNumeroMr = New WUC.UcText
        Me.txtCodEmpresa = New WUC.UcText
        Me.btnOkCancel = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSequenciaMr)
        Me.GroupBox1.Controls.Add(Me.txtNumeroMr)
        Me.GroupBox1.Controls.Add(Me.txtCodEmpresa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtSequenciaMr
        '
        Me.txtSequenciaMr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSequenciaMr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSequenciaMr.Caption = "Sequencia MR"
        Me.txtSequenciaMr.DataTextValue = Nothing
        Me.txtSequenciaMr.Location = New System.Drawing.Point(308, 70)
        Me.txtSequenciaMr.MaxLength = 2
        Me.txtSequenciaMr.Name = "txtSequenciaMr"
        Me.txtSequenciaMr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSequenciaMr.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtSequenciaMr.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtSequenciaMr.pDecimal = CType(0, Byte)
        Me.txtSequenciaMr.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtSequenciaMr.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtSequenciaMr.Size = New System.Drawing.Size(133, 25)
        Me.txtSequenciaMr.sqlQuery = Nothing
        Me.txtSequenciaMr.TabIndex = 2
        Me.txtSequenciaMr.TextBoxLeft = CType(80, Short)
        Me.txtSequenciaMr.TextWidth = 0
        '
        'txtNumeroMr
        '
        Me.txtNumeroMr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroMr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNumeroMr.Caption = "Numero MR"
        Me.txtNumeroMr.DataTextValue = Nothing
        Me.txtNumeroMr.Location = New System.Drawing.Point(22, 70)
        Me.txtNumeroMr.MaxLength = 10
        Me.txtNumeroMr.Name = "txtNumeroMr"
        Me.txtNumeroMr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroMr.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtNumeroMr.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtNumeroMr.pDecimal = CType(0, Byte)
        Me.txtNumeroMr.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNumeroMr.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNumeroMr.Size = New System.Drawing.Size(216, 25)
        Me.txtNumeroMr.sqlQuery = Nothing
        Me.txtNumeroMr.TabIndex = 1
        Me.txtNumeroMr.TextBoxLeft = CType(80, Short)
        Me.txtNumeroMr.TextWidth = 0
        '
        'txtCodEmpresa
        '
        Me.txtCodEmpresa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCodEmpresa.Caption = "Empresa "
        Me.txtCodEmpresa.DataTextValue = Nothing
        Me.txtCodEmpresa.Location = New System.Drawing.Point(22, 19)
        Me.txtCodEmpresa.MaxLength = 3
        Me.txtCodEmpresa.Name = "txtCodEmpresa"
        Me.txtCodEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtCodEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtCodEmpresa.pDecimal = CType(0, Byte)
        Me.txtCodEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.txtCodEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtCodEmpresa.showButton = True
        Me.txtCodEmpresa.ShowDescricao = True
        Me.txtCodEmpresa.Size = New System.Drawing.Size(419, 25)
        Me.txtCodEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.txtCodEmpresa.TabIndex = 0
        Me.txtCodEmpresa.TextBoxLeft = CType(80, Short)
        Me.txtCodEmpresa.TextWidth = 0
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOkCancel.Location = New System.Drawing.Point(286, 146)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 1
        '
        'frmSelecaoMapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(473, 194)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOkCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelecaoMapa"
        Me.Text = "Seleção de Mapa Reserva"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSequenciaMr As WUC.UcText
    Friend WithEvents txtNumeroMr As WUC.UcText
    Friend WithEvents txtCodEmpresa As WUC.UcText
End Class
