<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramaCadastro
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
        Me.GroupVeiculo = New System.Windows.Forms.GroupBox
        Me.gridVeiculo = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ucJoveNumerico = New WUC.UcText
        Me.ucJoveAlfa = New WUC.UcText
        Me.chkRotativo = New System.Windows.Forms.CheckBox
        Me.chkEvento = New System.Windows.Forms.CheckBox
        Me.ucData = New WUC.UcText
        Me.ucGenero = New WUC.UcText
        Me.ucSubTitulo = New WUC.UcText
        Me.ucTitulo = New WUC.UcText
        Me.ucCodigo = New WUC.UcText
        Me.btnOkCancel = New WUC.ucButton
        Me.ucVersao = New WUC.UcText
        Me.GroupVeiculo.SuspendLayout()
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupVeiculo
        '
        Me.GroupVeiculo.Controls.Add(Me.gridVeiculo)
        Me.GroupVeiculo.Location = New System.Drawing.Point(3, 300)
        Me.GroupVeiculo.Name = "GroupVeiculo"
        Me.GroupVeiculo.Size = New System.Drawing.Size(530, 155)
        Me.GroupVeiculo.TabIndex = 1
        Me.GroupVeiculo.TabStop = False
        Me.GroupVeiculo.Text = "Validar para os Veículos"
        '
        'gridVeiculo
        '
        Me.gridVeiculo.BackgroundColor = System.Drawing.Color.White
        Me.gridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVeiculo.Location = New System.Drawing.Point(7, 20)
        Me.gridVeiculo.Name = "gridVeiculo"
        Me.gridVeiculo.Size = New System.Drawing.Size(525, 129)
        Me.gridVeiculo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucVersao)
        Me.GroupBox1.Controls.Add(Me.ucJoveNumerico)
        Me.GroupBox1.Controls.Add(Me.ucJoveAlfa)
        Me.GroupBox1.Controls.Add(Me.chkRotativo)
        Me.GroupBox1.Controls.Add(Me.chkEvento)
        Me.GroupBox1.Controls.Add(Me.ucData)
        Me.GroupBox1.Controls.Add(Me.ucGenero)
        Me.GroupBox1.Controls.Add(Me.ucSubTitulo)
        Me.GroupBox1.Controls.Add(Me.ucTitulo)
        Me.GroupBox1.Controls.Add(Me.ucCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Programa"
        '
        'ucJoveNumerico
        '
        Me.ucJoveNumerico.BackColor = System.Drawing.SystemColors.Control
        Me.ucJoveNumerico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucJoveNumerico.Caption = "Código Jove Numérico"
        Me.ucJoveNumerico.DataTextValue = Nothing
        Me.ucJoveNumerico.Location = New System.Drawing.Point(9, 236)
        Me.ucJoveNumerico.MaxLength = 10
        Me.ucJoveNumerico.Name = "ucJoveNumerico"
        Me.ucJoveNumerico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucJoveNumerico.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucJoveNumerico.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucJoveNumerico.pDecimal = CType(0, Byte)
        Me.ucJoveNumerico.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucJoveNumerico.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.ucJoveNumerico.Size = New System.Drawing.Size(272, 25)
        Me.ucJoveNumerico.sqlQuery = Nothing
        Me.ucJoveNumerico.TabIndex = 6
        Me.ucJoveNumerico.TextBoxLeft = CType(140, Short)
        Me.ucJoveNumerico.TextWidth = 0
        '
        'ucJoveAlfa
        '
        Me.ucJoveAlfa.BackColor = System.Drawing.SystemColors.Control
        Me.ucJoveAlfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucJoveAlfa.Caption = "Código Jove Alfa-Numérico"
        Me.ucJoveAlfa.DataTextValue = Nothing
        Me.ucJoveAlfa.Location = New System.Drawing.Point(9, 205)
        Me.ucJoveAlfa.MaxLength = 10
        Me.ucJoveAlfa.Name = "ucJoveAlfa"
        Me.ucJoveAlfa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucJoveAlfa.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucJoveAlfa.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucJoveAlfa.pDecimal = CType(0, Byte)
        Me.ucJoveAlfa.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucJoveAlfa.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.ucJoveAlfa.Size = New System.Drawing.Size(272, 25)
        Me.ucJoveAlfa.sqlQuery = Nothing
        Me.ucJoveAlfa.TabIndex = 5
        Me.ucJoveAlfa.TextBoxLeft = CType(140, Short)
        Me.ucJoveAlfa.TextWidth = 0
        '
        'chkRotativo
        '
        Me.chkRotativo.AutoSize = True
        Me.chkRotativo.Location = New System.Drawing.Point(417, 246)
        Me.chkRotativo.Name = "chkRotativo"
        Me.chkRotativo.Size = New System.Drawing.Size(66, 17)
        Me.chkRotativo.TabIndex = 8
        Me.chkRotativo.Text = "Rotativo"
        Me.chkRotativo.UseVisualStyleBackColor = True
        '
        'chkEvento
        '
        Me.chkEvento.AutoSize = True
        Me.chkEvento.Location = New System.Drawing.Point(417, 205)
        Me.chkEvento.Name = "chkEvento"
        Me.chkEvento.Size = New System.Drawing.Size(60, 17)
        Me.chkEvento.TabIndex = 7
        Me.chkEvento.Text = "Evento"
        Me.chkEvento.UseVisualStyleBackColor = True
        '
        'ucData
        '
        Me.ucData.BackColor = System.Drawing.SystemColors.Control
        Me.ucData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucData.Caption = "Válido a partir de"
        Me.ucData.DataTextValue = Nothing
        Me.ucData.Location = New System.Drawing.Point(9, 164)
        Me.ucData.MaxLength = 10
        Me.ucData.Name = "ucData"
        Me.ucData.Obrigatorio = True
        Me.ucData.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucData.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucData.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucData.pDecimal = CType(0, Byte)
        Me.ucData.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucData.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.ucData.Size = New System.Drawing.Size(272, 25)
        Me.ucData.sqlQuery = Nothing
        Me.ucData.TabIndex = 4
        Me.ucData.TextBoxLeft = CType(0, Short)
        Me.ucData.TextWidth = 0
        '
        'ucGenero
        '
        Me.ucGenero.BackColor = System.Drawing.SystemColors.Control
        Me.ucGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucGenero.Caption = "Gênero"
        Me.ucGenero.DataTextValue = Nothing
        Me.ucGenero.Location = New System.Drawing.Point(9, 122)
        Me.ucGenero.MaxLength = 4
        Me.ucGenero.Name = "ucGenero"
        Me.ucGenero.Obrigatorio = True
        Me.ucGenero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucGenero.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucGenero.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucGenero.pDecimal = CType(0, Byte)
        Me.ucGenero.pDicionario = WUC.clsDicionario.enuDicionario.Genero
        Me.ucGenero.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucGenero.showButton = True
        Me.ucGenero.ShowDescricao = True
        Me.ucGenero.Size = New System.Drawing.Size(468, 25)
        Me.ucGenero.sqlQuery = "execute PrNet_Genero_L '"
        Me.ucGenero.TabIndex = 3
        Me.ucGenero.TextBoxLeft = CType(60, Short)
        Me.ucGenero.TextWidth = 0
        '
        'ucSubTitulo
        '
        Me.ucSubTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.ucSubTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucSubTitulo.Caption = "Sub Título"
        Me.ucSubTitulo.DataTextValue = Nothing
        Me.ucSubTitulo.Location = New System.Drawing.Point(9, 81)
        Me.ucSubTitulo.MaxLength = 30
        Me.ucSubTitulo.Name = "ucSubTitulo"
        Me.ucSubTitulo.Obrigatorio = True
        Me.ucSubTitulo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucSubTitulo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucSubTitulo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucSubTitulo.pDecimal = CType(0, Byte)
        Me.ucSubTitulo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucSubTitulo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucSubTitulo.Size = New System.Drawing.Size(468, 25)
        Me.ucSubTitulo.sqlQuery = Nothing
        Me.ucSubTitulo.TabIndex = 2
        Me.ucSubTitulo.TextBoxLeft = CType(60, Short)
        Me.ucSubTitulo.TextWidth = 0
        '
        'ucTitulo
        '
        Me.ucTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.ucTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucTitulo.DataTextValue = Nothing
        Me.ucTitulo.Location = New System.Drawing.Point(9, 50)
        Me.ucTitulo.MaxLength = 30
        Me.ucTitulo.Name = "ucTitulo"
        Me.ucTitulo.Obrigatorio = True
        Me.ucTitulo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucTitulo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucTitulo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucTitulo.pDecimal = CType(0, Byte)
        Me.ucTitulo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucTitulo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucTitulo.Size = New System.Drawing.Size(468, 25)
        Me.ucTitulo.sqlQuery = Nothing
        Me.ucTitulo.TabIndex = 1
        Me.ucTitulo.TextBoxLeft = CType(60, Short)
        Me.ucTitulo.TextWidth = 0
        '
        'ucCodigo
        '
        Me.ucCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.ucCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCodigo.Caption = "Código"
        Me.ucCodigo.DataTextValue = Nothing
        Me.ucCodigo.Location = New System.Drawing.Point(9, 19)
        Me.ucCodigo.MaxLength = 4
        Me.ucCodigo.Name = "ucCodigo"
        Me.ucCodigo.Obrigatorio = True
        Me.ucCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCodigo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCodigo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucCodigo.pDecimal = CType(0, Byte)
        Me.ucCodigo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCodigo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCodigo.Size = New System.Drawing.Size(125, 25)
        Me.ucCodigo.sqlQuery = Nothing
        Me.ucCodigo.TabIndex = 0
        Me.ucCodigo.TextBoxLeft = CType(60, Short)
        Me.ucCodigo.TextWidth = 0
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(354, 461)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 2
        '
        'ucVersao
        '
        Me.ucVersao.BackColor = System.Drawing.SystemColors.Control
        Me.ucVersao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVersao.Caption = "Versão"
        Me.ucVersao.DataTextValue = Nothing
        Me.ucVersao.Location = New System.Drawing.Point(352, 19)
        Me.ucVersao.MaxLength = 4
        Me.ucVersao.Name = "ucVersao"
        Me.ucVersao.Obrigatorio = True
        Me.ucVersao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVersao.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucVersao.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVersao.pDecimal = CType(0, Byte)
        Me.ucVersao.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucVersao.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVersao.Size = New System.Drawing.Size(125, 25)
        Me.ucVersao.sqlQuery = Nothing
        Me.ucVersao.TabIndex = 9
        Me.ucVersao.TextBoxLeft = CType(60, Short)
        Me.ucVersao.TextWidth = 0
        '
        'frmProgramaCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 505)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupVeiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProgramaCadastro"
        Me.Text = "Cadastro de Programas"
        Me.GroupVeiculo.ResumeLayout(False)
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupVeiculo As System.Windows.Forms.GroupBox
    Friend WithEvents gridVeiculo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ucJoveNumerico As WUC.UcText
    Friend WithEvents ucJoveAlfa As WUC.UcText
    Friend WithEvents chkRotativo As System.Windows.Forms.CheckBox
    Friend WithEvents chkEvento As System.Windows.Forms.CheckBox
    Friend WithEvents ucData As WUC.UcText
    Friend WithEvents ucGenero As WUC.UcText
    Friend WithEvents ucSubTitulo As WUC.UcText
    Friend WithEvents ucTitulo As WUC.UcText
    Friend WithEvents ucCodigo As WUC.UcText
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents ucVersao As WUC.UcText
End Class
