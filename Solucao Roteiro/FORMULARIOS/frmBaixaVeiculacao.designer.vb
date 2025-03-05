<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixaVeiculacao
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ucSiglaVeiculo = New WUC.UcText
        Me.txtSeq = New WUC.UcText
        Me.chkNaoQualidade = New System.Windows.Forms.CheckBox
        Me.txtChaveAcesso = New WUC.UcText
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.txtDuracao = New WUC.UcText
        Me.btnExibir = New System.Windows.Forms.Button
        Me.txtCodComercial = New WUC.UcText
        Me.txtContrato = New WUC.UcText
        Me.txtEmpresa = New WUC.UcText
        Me.TxtData = New WUC.UcText
        Me.txtPrograma = New WUC.UcText
        Me.txtVeiculo = New WUC.UcText
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnBaixar = New System.Windows.Forms.Button
        Me.lblCritica = New System.Windows.Forms.Label
        Me.dgvConsultaBaixa = New SCTVNET.CustomGrid(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvConsultaBaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucSiglaVeiculo)
        Me.GroupBox1.Controls.Add(Me.txtSeq)
        Me.GroupBox1.Controls.Add(Me.chkNaoQualidade)
        Me.GroupBox1.Controls.Add(Me.txtChaveAcesso)
        Me.GroupBox1.Controls.Add(Me.btnLimpar)
        Me.GroupBox1.Controls.Add(Me.txtDuracao)
        Me.GroupBox1.Controls.Add(Me.btnExibir)
        Me.GroupBox1.Controls.Add(Me.txtCodComercial)
        Me.GroupBox1.Controls.Add(Me.txtContrato)
        Me.GroupBox1.Controls.Add(Me.txtEmpresa)
        Me.GroupBox1.Controls.Add(Me.TxtData)
        Me.GroupBox1.Controls.Add(Me.txtPrograma)
        Me.GroupBox1.Controls.Add(Me.txtVeiculo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(956, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'ucSiglaVeiculo
        '
        Me.ucSiglaVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucSiglaVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucSiglaVeiculo.Caption = "Sigla"
        Me.ucSiglaVeiculo.DataTextValue = Nothing
        Me.ucSiglaVeiculo.Enabled = False
        Me.ucSiglaVeiculo.Location = New System.Drawing.Point(560, 19)
        Me.ucSiglaVeiculo.MaxLength = 10
        Me.ucSiglaVeiculo.Name = "ucSiglaVeiculo"
        Me.ucSiglaVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucSiglaVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucSiglaVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucSiglaVeiculo.pDecimal = CType(0, Byte)
        Me.ucSiglaVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucSiglaVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucSiglaVeiculo.Size = New System.Drawing.Size(69, 37)
        Me.ucSiglaVeiculo.TabIndex = 11
        Me.ucSiglaVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucSiglaVeiculo.TextWidth = 0
        '
        'txtSeq
        '
        Me.txtSeq.BackColor = System.Drawing.SystemColors.Control
        Me.txtSeq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSeq.Caption = "Seq."
        Me.txtSeq.DataTextValue = Nothing
        Me.txtSeq.Location = New System.Drawing.Point(514, 105)
        Me.txtSeq.MaxLength = 10
        Me.txtSeq.Name = "txtSeq"
        Me.txtSeq.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSeq.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtSeq.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtSeq.pDecimal = CType(0, Byte)
        Me.txtSeq.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtSeq.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtSeq.Size = New System.Drawing.Size(40, 37)
        Me.txtSeq.TabIndex = 6
        Me.txtSeq.TextBoxLeft = CType(0, Short)
        Me.txtSeq.TextWidth = 0
        '
        'chkNaoQualidade
        '
        Me.chkNaoQualidade.AutoSize = True
        Me.chkNaoQualidade.Location = New System.Drawing.Point(6, 148)
        Me.chkNaoQualidade.Name = "chkNaoQualidade"
        Me.chkNaoQualidade.Size = New System.Drawing.Size(218, 17)
        Me.chkNaoQualidade.TabIndex = 9
        Me.chkNaoQualidade.Text = "Não mostrar veiculações com qualidade."
        Me.chkNaoQualidade.UseVisualStyleBackColor = True
        '
        'txtChaveAcesso
        '
        Me.txtChaveAcesso.BackColor = System.Drawing.SystemColors.Control
        Me.txtChaveAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtChaveAcesso.Caption = "Chave de Acesso"
        Me.txtChaveAcesso.DataTextValue = Nothing
        Me.txtChaveAcesso.Location = New System.Drawing.Point(640, 62)
        Me.txtChaveAcesso.MaxLength = 10
        Me.txtChaveAcesso.Name = "txtChaveAcesso"
        Me.txtChaveAcesso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChaveAcesso.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtChaveAcesso.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtChaveAcesso.pDecimal = CType(0, Byte)
        Me.txtChaveAcesso.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtChaveAcesso.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtChaveAcesso.Size = New System.Drawing.Size(99, 37)
        Me.txtChaveAcesso.TabIndex = 3
        Me.txtChaveAcesso.TextBoxLeft = CType(0, Short)
        Me.txtChaveAcesso.TextWidth = 0
        '
        'btnLimpar
        '
        Me.btnLimpar.Enabled = False
        Me.btnLimpar.Location = New System.Drawing.Point(768, 105)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(91, 41)
        Me.btnLimpar.TabIndex = 10
        Me.btnLimpar.TabStop = False
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'txtDuracao
        '
        Me.txtDuracao.BackColor = System.Drawing.SystemColors.Control
        Me.txtDuracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtDuracao.Caption = "Duração"
        Me.txtDuracao.DataTextValue = Nothing
        Me.txtDuracao.Location = New System.Drawing.Point(640, 105)
        Me.txtDuracao.MaxLength = 10
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDuracao.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtDuracao.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtDuracao.pDecimal = CType(0, Byte)
        Me.txtDuracao.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtDuracao.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtDuracao.Size = New System.Drawing.Size(51, 37)
        Me.txtDuracao.TabIndex = 8
        Me.txtDuracao.TextBoxLeft = CType(0, Short)
        Me.txtDuracao.TextWidth = 0
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(768, 51)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(91, 41)
        Me.btnExibir.TabIndex = 9
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'txtCodComercial
        '
        Me.txtCodComercial.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCodComercial.Caption = "Cód.Comercial"
        Me.txtCodComercial.DataTextValue = Nothing
        Me.txtCodComercial.Location = New System.Drawing.Point(560, 105)
        Me.txtCodComercial.MaxLength = 10
        Me.txtCodComercial.Name = "txtCodComercial"
        Me.txtCodComercial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodComercial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCodComercial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtCodComercial.pDecimal = CType(0, Byte)
        Me.txtCodComercial.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtCodComercial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtCodComercial.Size = New System.Drawing.Size(75, 37)
        Me.txtCodComercial.TabIndex = 7
        Me.txtCodComercial.TextBoxLeft = CType(0, Short)
        Me.txtCodComercial.TextWidth = 0
        '
        'txtContrato
        '
        Me.txtContrato.BackColor = System.Drawing.SystemColors.Control
        Me.txtContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtContrato.Caption = "Contrato"
        Me.txtContrato.DataTextValue = Nothing
        Me.txtContrato.Location = New System.Drawing.Point(407, 105)
        Me.txtContrato.MaxLength = 10
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContrato.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtContrato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtContrato.pDecimal = CType(0, Byte)
        Me.txtContrato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtContrato.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtContrato.Size = New System.Drawing.Size(96, 37)
        Me.txtContrato.TabIndex = 5
        Me.txtContrato.TextBoxLeft = CType(0, Short)
        Me.txtContrato.TextWidth = 0
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmpresa.Caption = "Empresa"
        Me.txtEmpresa.DataTextValue = Nothing
        Me.txtEmpresa.Location = New System.Drawing.Point(6, 105)
        Me.txtEmpresa.MaxLength = 3
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEmpresa.pDecimal = CType(0, Byte)
        Me.txtEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.txtEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmpresa.showButton = True
        Me.txtEmpresa.ShowDescricao = True
        Me.txtEmpresa.Size = New System.Drawing.Size(390, 37)
        Me.txtEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.txtEmpresa.TabIndex = 4
        Me.txtEmpresa.TextBoxLeft = CType(0, Short)
        Me.txtEmpresa.TextWidth = 0
        '
        'TxtData
        '
        Me.TxtData.BackColor = System.Drawing.SystemColors.Control
        Me.TxtData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtData.Caption = "Data de Exibição"
        Me.TxtData.DataTextValue = Nothing
        Me.TxtData.Location = New System.Drawing.Point(640, 19)
        Me.TxtData.MaxLength = 10
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Obrigatorio = True
        Me.TxtData.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtData.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtData.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtData.pDecimal = CType(0, Byte)
        Me.TxtData.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtData.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.TxtData.Size = New System.Drawing.Size(99, 37)
        Me.TxtData.TabIndex = 1
        Me.TxtData.TextBoxLeft = CType(0, Short)
        Me.TxtData.TextWidth = 0
        '
        'txtPrograma
        '
        Me.txtPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.txtPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtPrograma.Caption = "Programa"
        Me.txtPrograma.DataTextValue = Nothing
        Me.txtPrograma.Location = New System.Drawing.Point(6, 62)
        Me.txtPrograma.MaxLength = 4
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtPrograma.pDecimal = CType(0, Byte)
        Me.txtPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Grade
        Me.txtPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtPrograma.showButton = True
        Me.txtPrograma.ShowDescricao = True
        Me.txtPrograma.Size = New System.Drawing.Size(548, 37)
        Me.txtPrograma.sqlQuery = "execute PrNet_Programa_Grade '','0001-01-01','0001-01-01',NULL"
        Me.txtPrograma.TabIndex = 2
        Me.txtPrograma.TextBoxLeft = CType(0, Short)
        Me.txtPrograma.TextWidth = 0
        '
        'txtVeiculo
        '
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.txtVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtVeiculo.Caption = "Veiculo"
        Me.txtVeiculo.DataTextValue = Nothing
        Me.txtVeiculo.Location = New System.Drawing.Point(6, 19)
        Me.txtVeiculo.MaxLength = 3
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Obrigatorio = True
        Me.txtVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtVeiculo.pDecimal = CType(0, Byte)
        Me.txtVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.txtVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtVeiculo.showButton = True
        Me.txtVeiculo.ShowDescricao = True
        Me.txtVeiculo.Size = New System.Drawing.Size(548, 37)
        Me.txtVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.txtVeiculo.TabIndex = 0
        Me.txtVeiculo.TextBoxLeft = CType(0, Short)
        Me.txtVeiculo.TextWidth = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(877, 510)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBaixar
        '
        Me.btnBaixar.Enabled = False
        Me.btnBaixar.Location = New System.Drawing.Point(780, 510)
        Me.btnBaixar.Name = "btnBaixar"
        Me.btnBaixar.Size = New System.Drawing.Size(91, 30)
        Me.btnBaixar.TabIndex = 4
        Me.btnBaixar.Text = "Baixar"
        Me.btnBaixar.UseVisualStyleBackColor = True
        '
        'lblCritica
        '
        Me.lblCritica.AutoSize = True
        Me.lblCritica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCritica.Location = New System.Drawing.Point(15, 467)
        Me.lblCritica.Name = "lblCritica"
        Me.lblCritica.Size = New System.Drawing.Size(0, 13)
        Me.lblCritica.TabIndex = 9
        '
        'dgvConsultaBaixa
        '
        Me.dgvConsultaBaixa.BackgroundColor = System.Drawing.Color.White
        Me.dgvConsultaBaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaBaixa.Location = New System.Drawing.Point(12, 192)
        Me.dgvConsultaBaixa.Name = "dgvConsultaBaixa"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsultaBaixa.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConsultaBaixa.Size = New System.Drawing.Size(956, 312)
        Me.dgvConsultaBaixa.TabIndex = 10
        '
        'frmBaixaVeiculacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(980, 552)
        Me.Controls.Add(Me.dgvConsultaBaixa)
        Me.Controls.Add(Me.lblCritica)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnBaixar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmBaixaVeiculacao"
        Me.Text = "Baixa de Veiculacões"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvConsultaBaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrograma As WUC.UcText
    Friend WithEvents txtVeiculo As WUC.UcText
    Friend WithEvents TxtData As WUC.UcText
    Friend WithEvents txtEmpresa As WUC.UcText
    Friend WithEvents txtContrato As WUC.UcText
    Friend WithEvents chkNaoQualidade As System.Windows.Forms.CheckBox
    Friend WithEvents txtChaveAcesso As WUC.UcText
    Friend WithEvents txtDuracao As WUC.UcText
    Friend WithEvents txtCodComercial As WUC.UcText
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBaixar As System.Windows.Forms.Button
    Friend WithEvents txtSeq As WUC.UcText
    Friend WithEvents lblCritica As System.Windows.Forms.Label
    Friend WithEvents dgvConsultaBaixa As SCTVNET.CustomGrid
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents ucSiglaVeiculo As WUC.UcText
End Class
