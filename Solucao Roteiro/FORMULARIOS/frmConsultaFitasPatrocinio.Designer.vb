<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaFitasPatrocinio
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
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.ucTipoComercial = New WUC.UcText
        Me.ucFitaFinal = New WUC.UcText
        Me.ucFinaInicio = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.ucPrograma = New WUC.UcText
        Me.UcCompetencia = New WUC.UcText
        Me.gridFita = New System.Windows.Forms.DataGridView
        Me.btnDesativar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnOkCancel = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridFita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCarregar)
        Me.GroupBox1.Controls.Add(Me.ucTipoComercial)
        Me.GroupBox1.Controls.Add(Me.ucFitaFinal)
        Me.GroupBox1.Controls.Add(Me.ucFinaInicio)
        Me.GroupBox1.Controls.Add(Me.ucVeiculo)
        Me.GroupBox1.Controls.Add(Me.ucPrograma)
        Me.GroupBox1.Controls.Add(Me.UcCompetencia)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnCarregar
        '
        Me.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCarregar.Location = New System.Drawing.Point(648, 47)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(103, 56)
        Me.btnCarregar.TabIndex = 6
        Me.btnCarregar.TabStop = False
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'ucTipoComercial
        '
        Me.ucTipoComercial.BackColor = System.Drawing.SystemColors.Control
        Me.ucTipoComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucTipoComercial.Caption = "Tp de Comercial"
        Me.ucTipoComercial.DataTextValue = Nothing
        Me.ucTipoComercial.Location = New System.Drawing.Point(227, 78)
        Me.ucTipoComercial.MaxLength = 2
        Me.ucTipoComercial.Name = "ucTipoComercial"
        Me.ucTipoComercial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucTipoComercial.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucTipoComercial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucTipoComercial.pDecimal = CType(0, Byte)
        Me.ucTipoComercial.pDicionario = WUC.clsDicionario.enuDicionario.Tipo_Comercial
        Me.ucTipoComercial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucTipoComercial.showButton = True
        Me.ucTipoComercial.ShowDescricao = True
        Me.ucTipoComercial.Size = New System.Drawing.Size(381, 25)
        Me.ucTipoComercial.sqlQuery = "Execute prNet_Tipo_Comercial_L"
        Me.ucTipoComercial.TabIndex = 5
        Me.ucTipoComercial.TextBoxLeft = CType(90, Short)
        Me.ucTipoComercial.TextWidth = 0
        '
        'ucFitaFinal
        '
        Me.ucFitaFinal.BackColor = System.Drawing.SystemColors.Control
        Me.ucFitaFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucFitaFinal.Caption = "Fita Final"
        Me.ucFitaFinal.DataTextValue = Nothing
        Me.ucFitaFinal.Location = New System.Drawing.Point(8, 78)
        Me.ucFitaFinal.MaxLength = 32767
        Me.ucFitaFinal.Name = "ucFitaFinal"
        Me.ucFitaFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucFitaFinal.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucFitaFinal.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucFitaFinal.pDecimal = CType(0, Byte)
        Me.ucFitaFinal.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucFitaFinal.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucFitaFinal.Size = New System.Drawing.Size(153, 25)
        Me.ucFitaFinal.sqlQuery = Nothing
        Me.ucFitaFinal.TabIndex = 2
        Me.ucFitaFinal.TextBoxLeft = CType(70, Short)
        Me.ucFitaFinal.TextWidth = 0
        '
        'ucFinaInicio
        '
        Me.ucFinaInicio.BackColor = System.Drawing.SystemColors.Control
        Me.ucFinaInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucFinaInicio.Caption = "Fita Inicial"
        Me.ucFinaInicio.DataTextValue = Nothing
        Me.ucFinaInicio.Location = New System.Drawing.Point(8, 47)
        Me.ucFinaInicio.MaxLength = 32767
        Me.ucFinaInicio.Name = "ucFinaInicio"
        Me.ucFinaInicio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucFinaInicio.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucFinaInicio.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucFinaInicio.pDecimal = CType(0, Byte)
        Me.ucFinaInicio.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucFinaInicio.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucFinaInicio.Size = New System.Drawing.Size(153, 25)
        Me.ucFinaInicio.sqlQuery = Nothing
        Me.ucFinaInicio.TabIndex = 1
        Me.ucFinaInicio.TextBoxLeft = CType(70, Short)
        Me.ucFinaInicio.TextWidth = 0
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(227, 47)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(382, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 4
        Me.ucVeiculo.TextBoxLeft = CType(90, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(227, 19)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(382, 25)
        Me.ucPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma.TabIndex = 3
        Me.ucPrograma.TextBoxLeft = CType(90, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'UcCompetencia
        '
        Me.UcCompetencia.BackColor = System.Drawing.SystemColors.Control
        Me.UcCompetencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcCompetencia.Caption = "Competência"
        Me.UcCompetencia.DataTextValue = Nothing
        Me.UcCompetencia.Location = New System.Drawing.Point(8, 16)
        Me.UcCompetencia.MaxLength = 32767
        Me.UcCompetencia.Name = "UcCompetencia"
        Me.UcCompetencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcCompetencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.UcCompetencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.UcCompetencia.pDecimal = CType(0, Byte)
        Me.UcCompetencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.UcCompetencia.pFormatoSaida = WUC.UcText.FormatoSaida.Mes_Ano
        Me.UcCompetencia.Size = New System.Drawing.Size(153, 25)
        Me.UcCompetencia.sqlQuery = Nothing
        Me.UcCompetencia.TabIndex = 0
        Me.UcCompetencia.TextBoxLeft = CType(70, Short)
        Me.UcCompetencia.TextWidth = 0
        '
        'gridFita
        '
        Me.gridFita.BackgroundColor = System.Drawing.Color.White
        Me.gridFita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridFita.Location = New System.Drawing.Point(11, 132)
        Me.gridFita.Name = "gridFita"
        Me.gridFita.Size = New System.Drawing.Size(779, 398)
        Me.gridFita.TabIndex = 1
        '
        'btnDesativar
        '
        Me.btnDesativar.Location = New System.Drawing.Point(11, 536)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(95, 46)
        Me.btnDesativar.TabIndex = 2
        Me.btnDesativar.TabStop = False
        Me.btnDesativar.Text = "Desativar"
        Me.btnDesativar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(138, 536)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(95, 46)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.TabStop = False
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.BotaoOkEnable = False
        Me.btnOkCancel.BotaoOkVisible = False
        Me.btnOkCancel.Location = New System.Drawing.Point(704, 536)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(86, 38)
        Me.btnOkCancel.TabIndex = 4
        '
        'frmConsultaFitasPatrocinio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 594)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnDesativar)
        Me.Controls.Add(Me.gridFita)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaFitasPatrocinio"
        Me.Text = "frmConsultaFitasPatrocinio"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridFita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ucFinaInicio As WUC.UcText
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents UcCompetencia As WUC.UcText
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents ucTipoComercial As WUC.UcText
    Friend WithEvents ucFitaFinal As WUC.UcText
    Friend WithEvents gridFita As System.Windows.Forms.DataGridView
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnOkCancel As WUC.ucButton
End Class
