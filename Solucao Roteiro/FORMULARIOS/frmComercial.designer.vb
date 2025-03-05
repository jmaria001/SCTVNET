<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComercial
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
        Me.fraComercial = New System.Windows.Forms.GroupBox
        Me.chkDeterminar = New System.Windows.Forms.CheckBox
        Me.txtProduto = New WUC.UcText
        Me.txtTipoComercial = New WUC.UcText
        Me.txtDuracao = New WUC.UcText
        Me.txtTitulo = New WUC.UcText
        Me.txtCodigo = New WUC.UcText
        Me.btnComercial = New WUC.ucButton
        Me.fraComercial.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraComercial
        '
        Me.fraComercial.Controls.Add(Me.chkDeterminar)
        Me.fraComercial.Controls.Add(Me.txtProduto)
        Me.fraComercial.Controls.Add(Me.txtTipoComercial)
        Me.fraComercial.Controls.Add(Me.txtDuracao)
        Me.fraComercial.Controls.Add(Me.txtTitulo)
        Me.fraComercial.Controls.Add(Me.txtCodigo)
        Me.fraComercial.Location = New System.Drawing.Point(12, 12)
        Me.fraComercial.Name = "fraComercial"
        Me.fraComercial.Size = New System.Drawing.Size(444, 208)
        Me.fraComercial.TabIndex = 0
        Me.fraComercial.TabStop = False
        '
        'chkDeterminar
        '
        Me.chkDeterminar.AutoSize = True
        Me.chkDeterminar.Location = New System.Drawing.Point(6, 167)
        Me.chkDeterminar.Name = "chkDeterminar"
        Me.chkDeterminar.Size = New System.Drawing.Size(115, 17)
        Me.chkDeterminar.TabIndex = 6
        Me.chkDeterminar.Text = "Titulo a Determinar"
        Me.chkDeterminar.UseVisualStyleBackColor = True
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtProduto.Caption = "Produto"
        Me.txtProduto.DataTextValue = Nothing
        Me.txtProduto.Location = New System.Drawing.Point(6, 114)
        Me.txtProduto.MaxLength = 6
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Obrigatorio = True
        Me.txtProduto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProduto.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtProduto.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtProduto.pDecimal = CType(0, Byte)
        Me.txtProduto.pDicionario = WUC.clsDicionario.enuDicionario.Produto
        Me.txtProduto.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtProduto.showButton = True
        Me.txtProduto.ShowDescricao = True
        Me.txtProduto.Size = New System.Drawing.Size(416, 37)
        Me.txtProduto.TabIndex = 5
        Me.txtProduto.TextBoxLeft = CType(0, Short)
        Me.txtProduto.TextWidth = 0
        '
        'txtTipoComercial
        '
        Me.txtTipoComercial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipoComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTipoComercial.Caption = "Tipo do Comercial"
        Me.txtTipoComercial.DataTextValue = Nothing
        Me.txtTipoComercial.Location = New System.Drawing.Point(6, 60)
        Me.txtTipoComercial.MaxLength = 2
        Me.txtTipoComercial.Name = "txtTipoComercial"
        Me.txtTipoComercial.Obrigatorio = True
        Me.txtTipoComercial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoComercial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTipoComercial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtTipoComercial.pDecimal = CType(0, Byte)
        Me.txtTipoComercial.pDicionario = WUC.clsDicionario.enuDicionario.Tipo_Comercial
        Me.txtTipoComercial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTipoComercial.showButton = True
        Me.txtTipoComercial.ShowDescricao = True
        Me.txtTipoComercial.Size = New System.Drawing.Size(423, 37)
        Me.txtTipoComercial.sqlQuery = "Execute prNet_Tipo_Comercial_L"
        Me.txtTipoComercial.TabIndex = 4
        Me.txtTipoComercial.TextBoxLeft = CType(0, Short)
        Me.txtTipoComercial.TextWidth = 0
        '
        'txtDuracao
        '
        Me.txtDuracao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDuracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtDuracao.Caption = "Duração"
        Me.txtDuracao.DataTextValue = Nothing
        Me.txtDuracao.Location = New System.Drawing.Point(377, 17)
        Me.txtDuracao.MaxLength = 4
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.Obrigatorio = True
        Me.txtDuracao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDuracao.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtDuracao.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtDuracao.pDecimal = CType(0, Byte)
        Me.txtDuracao.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtDuracao.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtDuracao.Size = New System.Drawing.Size(52, 37)
        Me.txtDuracao.sqlQuery = Nothing
        Me.txtDuracao.TabIndex = 3
        Me.txtDuracao.TextBoxLeft = CType(0, Short)
        Me.txtDuracao.TextWidth = 0
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTitulo.DataTextValue = Nothing
        Me.txtTitulo.Location = New System.Drawing.Point(100, 17)
        Me.txtTitulo.MaxLength = 30
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Obrigatorio = True
        Me.txtTitulo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitulo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTitulo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtTitulo.pDecimal = CType(0, Byte)
        Me.txtTitulo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtTitulo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTitulo.Size = New System.Drawing.Size(257, 37)
        Me.txtTitulo.sqlQuery = Nothing
        Me.txtTitulo.TabIndex = 2
        Me.txtTitulo.TextBoxLeft = CType(0, Short)
        Me.txtTitulo.TextWidth = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCodigo.Caption = "Legenda"
        Me.txtCodigo.DataTextValue = Nothing
        Me.txtCodigo.Location = New System.Drawing.Point(6, 17)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Obrigatorio = True
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCodigo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtCodigo.pDecimal = CType(0, Byte)
        Me.txtCodigo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtCodigo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtCodigo.Size = New System.Drawing.Size(63, 37)
        Me.txtCodigo.sqlQuery = Nothing
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextBoxLeft = CType(0, Short)
        Me.txtCodigo.TextWidth = 0
        '
        'btnComercial
        '
        Me.btnComercial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnComercial.Location = New System.Drawing.Point(277, 226)
        Me.btnComercial.Name = "btnComercial"
        Me.btnComercial.Size = New System.Drawing.Size(179, 38)
        Me.btnComercial.TabIndex = 1
        '
        'frmComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(469, 269)
        Me.Controls.Add(Me.fraComercial)
        Me.Controls.Add(Me.btnComercial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComercial"
        Me.Text = "Cadastro de Comerciais"
        Me.fraComercial.ResumeLayout(False)
        Me.fraComercial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnComercial As WUC.ucButton
    Friend WithEvents fraComercial As System.Windows.Forms.GroupBox
    Friend WithEvents chkDeterminar As System.Windows.Forms.CheckBox
    Friend WithEvents txtProduto As WUC.UcText
    Friend WithEvents txtTipoComercial As WUC.UcText
    Friend WithEvents txtDuracao As WUC.UcText
    Friend WithEvents txtTitulo As WUC.UcText
    Friend WithEvents txtCodigo As WUC.UcText
End Class
