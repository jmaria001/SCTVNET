<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControleFitaPatrocinio
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
        Me.fraFiltro = New System.Windows.Forms.GroupBox
        Me.btnPendencia = New System.Windows.Forms.Button
        Me.ucProgramaPatrocinado = New WUC.UcText
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.ucCodVeiculo = New WUC.UcText
        Me.ucCompetencia = New WUC.UcText
        Me.btnCancela = New System.Windows.Forms.Button
        Me.btnProximoNumero = New System.Windows.Forms.Button
        Me.btnContratos = New System.Windows.Forms.Button
        Me.btnOkCancel = New WUC.ucButton
        Me.gridFita = New SCTVNET.CustomGrid(Me.components)
        Me.fraFiltro.SuspendLayout()
        CType(Me.gridFita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraFiltro
        '
        Me.fraFiltro.Controls.Add(Me.btnPendencia)
        Me.fraFiltro.Controls.Add(Me.ucProgramaPatrocinado)
        Me.fraFiltro.Controls.Add(Me.btnCarregar)
        Me.fraFiltro.Controls.Add(Me.ucCodVeiculo)
        Me.fraFiltro.Controls.Add(Me.ucCompetencia)
        Me.fraFiltro.Location = New System.Drawing.Point(12, 12)
        Me.fraFiltro.Name = "fraFiltro"
        Me.fraFiltro.Size = New System.Drawing.Size(609, 130)
        Me.fraFiltro.TabIndex = 0
        Me.fraFiltro.TabStop = False
        '
        'btnPendencia
        '
        Me.btnPendencia.Location = New System.Drawing.Point(479, 17)
        Me.btnPendencia.Name = "btnPendencia"
        Me.btnPendencia.Size = New System.Drawing.Size(115, 51)
        Me.btnPendencia.TabIndex = 6
        Me.btnPendencia.TabStop = False
        Me.btnPendencia.Text = "Pendências de Numeração no Mês"
        Me.btnPendencia.UseVisualStyleBackColor = True
        '
        'ucProgramaPatrocinado
        '
        Me.ucProgramaPatrocinado.BackColor = System.Drawing.SystemColors.Control
        Me.ucProgramaPatrocinado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucProgramaPatrocinado.Caption = "Programa Patrocinado"
        Me.ucProgramaPatrocinado.DataTextValue = Nothing
        Me.ucProgramaPatrocinado.Location = New System.Drawing.Point(6, 56)
        Me.ucProgramaPatrocinado.MaxLength = 4
        Me.ucProgramaPatrocinado.Name = "ucProgramaPatrocinado"
        Me.ucProgramaPatrocinado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucProgramaPatrocinado.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucProgramaPatrocinado.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucProgramaPatrocinado.pDecimal = CType(0, Byte)
        Me.ucProgramaPatrocinado.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Patrocinado
        Me.ucProgramaPatrocinado.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucProgramaPatrocinado.showButton = True
        Me.ucProgramaPatrocinado.ShowDescricao = True
        Me.ucProgramaPatrocinado.Size = New System.Drawing.Size(415, 25)
        Me.ucProgramaPatrocinado.sqlQuery = "Execute PrNet_Programa_Patrocinado_S 0,''"
        Me.ucProgramaPatrocinado.TabIndex = 1
        Me.ucProgramaPatrocinado.TextBoxLeft = CType(0, Short)
        Me.ucProgramaPatrocinado.TextWidth = 0
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(479, 74)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(115, 45)
        Me.btnCarregar.TabIndex = 4
        Me.btnCarregar.TabStop = False
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'ucCodVeiculo
        '
        Me.ucCodVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucCodVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCodVeiculo.Caption = "Veiculo"
        Me.ucCodVeiculo.DataTextValue = Nothing
        Me.ucCodVeiculo.Location = New System.Drawing.Point(83, 93)
        Me.ucCodVeiculo.MaxLength = 3
        Me.ucCodVeiculo.Name = "ucCodVeiculo"
        Me.ucCodVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCodVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCodVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucCodVeiculo.pDecimal = CType(0, Byte)
        Me.ucCodVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucCodVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCodVeiculo.showButton = True
        Me.ucCodVeiculo.ShowDescricao = True
        Me.ucCodVeiculo.Size = New System.Drawing.Size(343, 25)
        Me.ucCodVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucCodVeiculo.TabIndex = 2
        Me.ucCodVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucCodVeiculo.TextWidth = 60
        '
        'ucCompetencia
        '
        Me.ucCompetencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucCompetencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCompetencia.Caption = "Competência"
        Me.ucCompetencia.DataTextValue = Nothing
        Me.ucCompetencia.Location = New System.Drawing.Point(51, 19)
        Me.ucCompetencia.MaxLength = 32767
        Me.ucCompetencia.Name = "ucCompetencia"
        Me.ucCompetencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCompetencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCompetencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucCompetencia.pDecimal = CType(0, Byte)
        Me.ucCompetencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCompetencia.pFormatoSaida = WUC.UcText.FormatoSaida.Mes_Ano
        Me.ucCompetencia.Size = New System.Drawing.Size(135, 25)
        Me.ucCompetencia.sqlQuery = Nothing
        Me.ucCompetencia.TabIndex = 0
        Me.ucCompetencia.TextBoxLeft = CType(0, Short)
        Me.ucCompetencia.TextWidth = 60
        '
        'btnCancela
        '
        Me.btnCancela.Location = New System.Drawing.Point(17, 442)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(97, 36)
        Me.btnCancela.TabIndex = 2
        Me.btnCancela.TabStop = False
        Me.btnCancela.Text = "Cancela"
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'btnProximoNumero
        '
        Me.btnProximoNumero.Location = New System.Drawing.Point(122, 442)
        Me.btnProximoNumero.Name = "btnProximoNumero"
        Me.btnProximoNumero.Size = New System.Drawing.Size(97, 36)
        Me.btnProximoNumero.TabIndex = 3
        Me.btnProximoNumero.TabStop = False
        Me.btnProximoNumero.Text = "Próximo Número"
        Me.btnProximoNumero.UseVisualStyleBackColor = True
        '
        'btnContratos
        '
        Me.btnContratos.Location = New System.Drawing.Point(227, 442)
        Me.btnContratos.Name = "btnContratos"
        Me.btnContratos.Size = New System.Drawing.Size(97, 36)
        Me.btnContratos.TabIndex = 4
        Me.btnContratos.TabStop = False
        Me.btnContratos.Text = "Ver Contratos"
        Me.btnContratos.UseVisualStyleBackColor = True
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.CancelaText = "Sair"
        Me.btnOkCancel.Location = New System.Drawing.Point(441, 439)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.OkText = "Salvar"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 5
        Me.btnOkCancel.TabStop = False
        '
        'gridFita
        '
        Me.gridFita.BackgroundColor = System.Drawing.Color.White
        Me.gridFita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridFita.Location = New System.Drawing.Point(18, 149)
        Me.gridFita.Name = "gridFita"
        Me.gridFita.Size = New System.Drawing.Size(603, 281)
        Me.gridFita.TabIndex = 1
        '
        'frmControleFitaPatrocinio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 495)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.btnContratos)
        Me.Controls.Add(Me.btnProximoNumero)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.gridFita)
        Me.Controls.Add(Me.fraFiltro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControleFitaPatrocinio"
        Me.Text = "frmControleFitaPatrocinio"
        Me.fraFiltro.ResumeLayout(False)
        CType(Me.gridFita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fraFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents ucCodVeiculo As WUC.UcText
    Friend WithEvents ucCompetencia As WUC.UcText
    Friend WithEvents ucProgramaPatrocinado As WUC.UcText
    Friend WithEvents gridFita As SCTVNET.CustomGrid
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnProximoNumero As System.Windows.Forms.Button
    Friend WithEvents btnContratos As System.Windows.Forms.Button
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents btnPendencia As System.Windows.Forms.Button
End Class
