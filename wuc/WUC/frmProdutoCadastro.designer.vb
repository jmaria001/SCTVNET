<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutoCadastro
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
        Me.ucProduto = New WUC.UcText
        Me.ucHorario = New WUC.UcText
        Me.ucSegmento = New WUC.UcText
        Me.ucSetor = New WUC.UcText
        Me.btnProduto = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucProduto)
        Me.GroupBox1.Controls.Add(Me.ucHorario)
        Me.GroupBox1.Controls.Add(Me.ucSegmento)
        Me.GroupBox1.Controls.Add(Me.ucSetor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ucProduto
        '
        Me.ucProduto.BackColor = System.Drawing.SystemColors.Control
        Me.ucProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucProduto.Caption = "Produto"
        Me.ucProduto.DataTextValue = Nothing
        Me.ucProduto.Location = New System.Drawing.Point(19, 115)
        Me.ucProduto.MaxLength = 40
        Me.ucProduto.Name = "ucProduto"
        Me.ucProduto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucProduto.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucProduto.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucProduto.pDecimal = CType(0, Byte)
        Me.ucProduto.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucProduto.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucProduto.Size = New System.Drawing.Size(371, 25)
        Me.ucProduto.sqlQuery = Nothing
        Me.ucProduto.TabIndex = 2
        Me.ucProduto.TextBoxLeft = CType(60, Short)
        Me.ucProduto.TextWidth = 0
        '
        'ucHorario
        '
        Me.ucHorario.BackColor = System.Drawing.SystemColors.Control
        Me.ucHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucHorario.Caption = "Exibir após"
        Me.ucHorario.DataTextValue = Nothing
        Me.ucHorario.Location = New System.Drawing.Point(19, 158)
        Me.ucHorario.MaxLength = 5
        Me.ucHorario.Name = "ucHorario"
        Me.ucHorario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucHorario.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucHorario.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucHorario.pDecimal = CType(0, Byte)
        Me.ucHorario.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucHorario.pFormatoSaida = WUC.UcText.FormatoSaida.Hora
        Me.ucHorario.Size = New System.Drawing.Size(140, 25)
        Me.ucHorario.sqlQuery = Nothing
        Me.ucHorario.TabIndex = 3
        Me.ucHorario.TextBoxLeft = CType(60, Short)
        Me.ucHorario.TextWidth = 0
        '
        'ucSegmento
        '
        Me.ucSegmento.BackColor = System.Drawing.SystemColors.Control
        Me.ucSegmento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucSegmento.Caption = "Segmento"
        Me.ucSegmento.DataTextValue = Nothing
        Me.ucSegmento.Location = New System.Drawing.Point(19, 72)
        Me.ucSegmento.MaxLength = 6
        Me.ucSegmento.Name = "ucSegmento"
        Me.ucSegmento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucSegmento.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucSegmento.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucSegmento.pDecimal = CType(0, Byte)
        Me.ucSegmento.pDicionario = WUC.clsDicionario.enuDicionario.Segmento
        Me.ucSegmento.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucSegmento.showButton = True
        Me.ucSegmento.ShowDescricao = True
        Me.ucSegmento.Size = New System.Drawing.Size(371, 25)
        Me.ucSegmento.TabIndex = 1
        Me.ucSegmento.TextBoxLeft = CType(60, Short)
        Me.ucSegmento.TextWidth = 0
        '
        'ucSetor
        '
        Me.ucSetor.BackColor = System.Drawing.SystemColors.Control
        Me.ucSetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucSetor.Caption = "Setor"
        Me.ucSetor.DataTextValue = Nothing
        Me.ucSetor.Location = New System.Drawing.Point(19, 29)
        Me.ucSetor.MaxLength = 6
        Me.ucSetor.Name = "ucSetor"
        Me.ucSetor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucSetor.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucSetor.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucSetor.pDecimal = CType(0, Byte)
        Me.ucSetor.pDicionario = WUC.clsDicionario.enuDicionario.Setor
        Me.ucSetor.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucSetor.showButton = True
        Me.ucSetor.ShowDescricao = True
        Me.ucSetor.Size = New System.Drawing.Size(371, 25)
        Me.ucSetor.sqlQuery = "Execute PrNet_Produto_L null,1"
        Me.ucSetor.TabIndex = 0
        Me.ucSetor.TextBoxLeft = CType(60, Short)
        Me.ucSetor.TextWidth = 0
        '
        'btnProduto
        '
        Me.btnProduto.BackColor = System.Drawing.SystemColors.Control
        Me.btnProduto.Location = New System.Drawing.Point(248, 231)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(179, 38)
        Me.btnProduto.TabIndex = 1
        '
        'frmProdutoCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 282)
        Me.Controls.Add(Me.btnProduto)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdutoCadastro"
        Me.Text = "Cadastro de Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ucSegmento As WUC.UcText
    Friend WithEvents ucSetor As WUC.UcText
    Friend WithEvents btnProduto As WUC.ucButton
    Friend WithEvents ucProduto As WUC.UcText
    Friend WithEvents ucHorario As WUC.UcText
End Class
