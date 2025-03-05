<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerceiroFiltro
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
        Me.groupFiltro = New System.Windows.Forms.GroupBox
        Me.ucFuncao = New WUC.UcText
        Me.ucMunicipio = New WUC.UcText
        Me.ucCNPJ = New WUC.UcText
        Me.ucNomeFantasia = New WUC.UcText
        Me.ucRazaoSocial = New WUC.UcText
        Me.ucCodigo = New WUC.UcText
        Me.btnFIltro = New WUC.ucButton
        Me.groupFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupFiltro
        '
        Me.groupFiltro.Controls.Add(Me.ucFuncao)
        Me.groupFiltro.Controls.Add(Me.ucMunicipio)
        Me.groupFiltro.Controls.Add(Me.ucCNPJ)
        Me.groupFiltro.Controls.Add(Me.ucNomeFantasia)
        Me.groupFiltro.Controls.Add(Me.ucRazaoSocial)
        Me.groupFiltro.Controls.Add(Me.ucCodigo)
        Me.groupFiltro.Location = New System.Drawing.Point(12, 12)
        Me.groupFiltro.Name = "groupFiltro"
        Me.groupFiltro.Size = New System.Drawing.Size(475, 240)
        Me.groupFiltro.TabIndex = 0
        Me.groupFiltro.TabStop = False
        '
        'ucFuncao
        '
        Me.ucFuncao.BackColor = System.Drawing.SystemColors.Control
        Me.ucFuncao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucFuncao.Caption = "Função"
        Me.ucFuncao.DataTextValue = Nothing
        Me.ucFuncao.Location = New System.Drawing.Point(13, 169)
        Me.ucFuncao.MaxLength = 2
        Me.ucFuncao.Name = "ucFuncao"
        Me.ucFuncao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucFuncao.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucFuncao.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucFuncao.pDecimal = CType(0, Byte)
        Me.ucFuncao.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Funcao
        Me.ucFuncao.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucFuncao.showButton = True
        Me.ucFuncao.ShowDescricao = True
        Me.ucFuncao.Size = New System.Drawing.Size(446, 37)
        Me.ucFuncao.sqlQuery = "Execute PrNet_terceiro_funcao_L"
        Me.ucFuncao.TabIndex = 5
        Me.ucFuncao.TextBoxLeft = CType(0, Short)
        Me.ucFuncao.TextWidth = 0
        '
        'ucMunicipio
        '
        Me.ucMunicipio.BackColor = System.Drawing.SystemColors.Control
        Me.ucMunicipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucMunicipio.Caption = "Municípo"
        Me.ucMunicipio.DataTextValue = Nothing
        Me.ucMunicipio.Location = New System.Drawing.Point(241, 119)
        Me.ucMunicipio.MaxLength = 50
        Me.ucMunicipio.Name = "ucMunicipio"
        Me.ucMunicipio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucMunicipio.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucMunicipio.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucMunicipio.pDecimal = CType(0, Byte)
        Me.ucMunicipio.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucMunicipio.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucMunicipio.Size = New System.Drawing.Size(218, 37)
        Me.ucMunicipio.sqlQuery = Nothing
        Me.ucMunicipio.TabIndex = 4
        Me.ucMunicipio.TextBoxLeft = CType(0, Short)
        Me.ucMunicipio.TextWidth = 0
        '
        'ucCNPJ
        '
        Me.ucCNPJ.BackColor = System.Drawing.SystemColors.Control
        Me.ucCNPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCNPJ.Caption = "CNPJ / CPF"
        Me.ucCNPJ.DataTextValue = Nothing
        Me.ucCNPJ.Location = New System.Drawing.Point(13, 119)
        Me.ucCNPJ.MaxLength = 15
        Me.ucCNPJ.Name = "ucCNPJ"
        Me.ucCNPJ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCNPJ.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucCNPJ.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucCNPJ.pDecimal = CType(0, Byte)
        Me.ucCNPJ.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCNPJ.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCNPJ.Size = New System.Drawing.Size(213, 37)
        Me.ucCNPJ.sqlQuery = Nothing
        Me.ucCNPJ.TabIndex = 3
        Me.ucCNPJ.TextBoxLeft = CType(0, Short)
        Me.ucCNPJ.TextWidth = 0
        '
        'ucNomeFantasia
        '
        Me.ucNomeFantasia.BackColor = System.Drawing.SystemColors.Control
        Me.ucNomeFantasia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucNomeFantasia.Caption = "Nome da Fantasia"
        Me.ucNomeFantasia.DataTextValue = Nothing
        Me.ucNomeFantasia.Location = New System.Drawing.Point(114, 19)
        Me.ucNomeFantasia.MaxLength = 50
        Me.ucNomeFantasia.Name = "ucNomeFantasia"
        Me.ucNomeFantasia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucNomeFantasia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucNomeFantasia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucNomeFantasia.pDecimal = CType(0, Byte)
        Me.ucNomeFantasia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucNomeFantasia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucNomeFantasia.Size = New System.Drawing.Size(345, 37)
        Me.ucNomeFantasia.sqlQuery = Nothing
        Me.ucNomeFantasia.TabIndex = 1
        Me.ucNomeFantasia.TextBoxLeft = CType(0, Short)
        Me.ucNomeFantasia.TextWidth = 0
        '
        'ucRazaoSocial
        '
        Me.ucRazaoSocial.BackColor = System.Drawing.SystemColors.Control
        Me.ucRazaoSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucRazaoSocial.Caption = "Razão Social"
        Me.ucRazaoSocial.DataTextValue = Nothing
        Me.ucRazaoSocial.Location = New System.Drawing.Point(13, 69)
        Me.ucRazaoSocial.MaxLength = 32767
        Me.ucRazaoSocial.Name = "ucRazaoSocial"
        Me.ucRazaoSocial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucRazaoSocial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucRazaoSocial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucRazaoSocial.pDecimal = CType(0, Byte)
        Me.ucRazaoSocial.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucRazaoSocial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucRazaoSocial.Size = New System.Drawing.Size(446, 37)
        Me.ucRazaoSocial.sqlQuery = Nothing
        Me.ucRazaoSocial.TabIndex = 2
        Me.ucRazaoSocial.TextBoxLeft = CType(0, Short)
        Me.ucRazaoSocial.TextWidth = 0
        '
        'ucCodigo
        '
        Me.ucCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.ucCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCodigo.Caption = "Código"
        Me.ucCodigo.DataTextValue = Nothing
        Me.ucCodigo.Location = New System.Drawing.Point(13, 19)
        Me.ucCodigo.MaxLength = 32767
        Me.ucCodigo.Name = "ucCodigo"
        Me.ucCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCodigo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucCodigo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucCodigo.pDecimal = CType(0, Byte)
        Me.ucCodigo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCodigo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCodigo.Size = New System.Drawing.Size(78, 37)
        Me.ucCodigo.sqlQuery = Nothing
        Me.ucCodigo.TabIndex = 0
        Me.ucCodigo.TextBoxLeft = CType(0, Short)
        Me.ucCodigo.TextWidth = 0
        '
        'btnFIltro
        '
        Me.btnFIltro.BackColor = System.Drawing.SystemColors.Control
        Me.btnFIltro.Location = New System.Drawing.Point(308, 273)
        Me.btnFIltro.Name = "btnFIltro"
        Me.btnFIltro.Size = New System.Drawing.Size(179, 38)
        Me.btnFIltro.TabIndex = 7
        Me.btnFIltro.TabStop = False
        '
        'frmTerceiroFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 323)
        Me.Controls.Add(Me.btnFIltro)
        Me.Controls.Add(Me.groupFiltro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmTerceiroFiltro"
        Me.Text = "Filtro da Consulta de Terceiros"
        Me.groupFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents ucFuncao As WUC.UcText
    Friend WithEvents ucMunicipio As WUC.UcText
    Friend WithEvents ucCNPJ As WUC.UcText
    Friend WithEvents ucNomeFantasia As WUC.UcText
    Friend WithEvents ucRazaoSocial As WUC.UcText
    Friend WithEvents ucCodigo As WUC.UcText
    Friend WithEvents btnFIltro As WUC.ucButton
End Class
