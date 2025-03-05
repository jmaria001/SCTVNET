<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmFiltro
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
        Me.GroupFiltro = New System.Windows.Forms.GroupBox
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnAM = New WUC.ucButton
        Me.ucContato = New WUC.UcText
        Me.ucSequencia = New WUC.UcText
        Me.ucContrato = New WUC.UcText
        Me.ucEmpresa = New WUC.UcText
        Me.ucPrograma = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.ucAgencia = New WUC.UcText
        Me.ucCLiente = New WUC.UcText
        Me.ucNucleo = New WUC.UcText
        Me.ucCompetencia = New WUC.UcText
        Me.GroupFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupFiltro
        '
        Me.GroupFiltro.BackColor = System.Drawing.SystemColors.Control
        Me.GroupFiltro.Controls.Add(Me.ucContato)
        Me.GroupFiltro.Controls.Add(Me.ucSequencia)
        Me.GroupFiltro.Controls.Add(Me.ucContrato)
        Me.GroupFiltro.Controls.Add(Me.ucEmpresa)
        Me.GroupFiltro.Controls.Add(Me.ucPrograma)
        Me.GroupFiltro.Controls.Add(Me.ucVeiculo)
        Me.GroupFiltro.Controls.Add(Me.ucAgencia)
        Me.GroupFiltro.Controls.Add(Me.ucCLiente)
        Me.GroupFiltro.Controls.Add(Me.ucNucleo)
        Me.GroupFiltro.Controls.Add(Me.ucCompetencia)
        Me.GroupFiltro.Location = New System.Drawing.Point(12, 12)
        Me.GroupFiltro.Name = "GroupFiltro"
        Me.GroupFiltro.Size = New System.Drawing.Size(552, 336)
        Me.GroupFiltro.TabIndex = 0
        Me.GroupFiltro.TabStop = False
        Me.GroupFiltro.Text = "Filtros"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(12, 369)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(105, 31)
        Me.btnLimpar.TabIndex = 2
        Me.btnLimpar.TabStop = False
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnAM
        '
        Me.btnAM.BackColor = System.Drawing.SystemColors.Control
        Me.btnAM.Location = New System.Drawing.Point(388, 362)
        Me.btnAM.Name = "btnAM"
        Me.btnAM.Size = New System.Drawing.Size(179, 38)
        Me.btnAM.TabIndex = 1
        '
        'ucContato
        '
        Me.ucContato.BackColor = System.Drawing.SystemColors.Control
        Me.ucContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucContato.Caption = "Contato"
        Me.ucContato.DataTextValue = Nothing
        Me.ucContato.Location = New System.Drawing.Point(6, 87)
        Me.ucContato.MaxLength = 6
        Me.ucContato.Name = "ucContato"
        Me.ucContato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucContato.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucContato.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucContato.pDecimal = CType(0, Byte)
        Me.ucContato.pDicionario = WUC.clsDicionario.enuDicionario.Contato
        Me.ucContato.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucContato.showButton = True
        Me.ucContato.ShowDescricao = True
        Me.ucContato.Size = New System.Drawing.Size(534, 25)
        Me.ucContato.sqlQuery = "Execute prNet_Contato_L Null,''"
        Me.ucContato.TabIndex = 2
        Me.ucContato.TextBoxLeft = CType(60, Short)
        Me.ucContato.TextWidth = 90
        '
        'ucSequencia
        '
        Me.ucSequencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucSequencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucSequencia.Caption = "Sequencia"
        Me.ucSequencia.DataTextValue = Nothing
        Me.ucSequencia.Location = New System.Drawing.Point(203, 291)
        Me.ucSequencia.MaxLength = 2
        Me.ucSequencia.Name = "ucSequencia"
        Me.ucSequencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucSequencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucSequencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucSequencia.pDecimal = CType(0, Byte)
        Me.ucSequencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucSequencia.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucSequencia.Size = New System.Drawing.Size(113, 25)
        Me.ucSequencia.sqlQuery = Nothing
        Me.ucSequencia.TabIndex = 9
        Me.ucSequencia.TextBoxLeft = CType(0, Short)
        Me.ucSequencia.TextWidth = 0
        '
        'ucContrato
        '
        Me.ucContrato.BackColor = System.Drawing.SystemColors.Control
        Me.ucContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucContrato.Caption = "Contrato"
        Me.ucContrato.DataTextValue = Nothing
        Me.ucContrato.Location = New System.Drawing.Point(6, 291)
        Me.ucContrato.MaxLength = 32767
        Me.ucContrato.Name = "ucContrato"
        Me.ucContrato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucContrato.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucContrato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucContrato.pDecimal = CType(0, Byte)
        Me.ucContrato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucContrato.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucContrato.Size = New System.Drawing.Size(161, 25)
        Me.ucContrato.sqlQuery = Nothing
        Me.ucContrato.TabIndex = 8
        Me.ucContrato.TextBoxLeft = CType(60, Short)
        Me.ucContrato.TextWidth = 90
        '
        'ucEmpresa
        '
        Me.ucEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.ucEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucEmpresa.Caption = "Empresa"
        Me.ucEmpresa.DataTextValue = Nothing
        Me.ucEmpresa.Location = New System.Drawing.Point(6, 257)
        Me.ucEmpresa.MaxLength = 3
        Me.ucEmpresa.Name = "ucEmpresa"
        Me.ucEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucEmpresa.pDecimal = CType(0, Byte)
        Me.ucEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.ucEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucEmpresa.showButton = True
        Me.ucEmpresa.ShowDescricao = True
        Me.ucEmpresa.Size = New System.Drawing.Size(534, 25)
        Me.ucEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.ucEmpresa.TabIndex = 7
        Me.ucEmpresa.TextBoxLeft = CType(60, Short)
        Me.ucEmpresa.TextWidth = 90
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(6, 223)
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
        Me.ucPrograma.Size = New System.Drawing.Size(534, 25)
        Me.ucPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma.TabIndex = 6
        Me.ucPrograma.TextBoxLeft = CType(60, Short)
        Me.ucPrograma.TextWidth = 90
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(6, 189)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(534, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 5
        Me.ucVeiculo.TextBoxLeft = CType(60, Short)
        Me.ucVeiculo.TextWidth = 90
        '
        'ucAgencia
        '
        Me.ucAgencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucAgencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucAgencia.Caption = "Agência"
        Me.ucAgencia.DataTextValue = Nothing
        Me.ucAgencia.Location = New System.Drawing.Point(6, 155)
        Me.ucAgencia.MaxLength = 6
        Me.ucAgencia.Name = "ucAgencia"
        Me.ucAgencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucAgencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucAgencia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucAgencia.pDecimal = CType(0, Byte)
        Me.ucAgencia.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.ucAgencia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucAgencia.showButton = True
        Me.ucAgencia.ShowDescricao = True
        Me.ucAgencia.Size = New System.Drawing.Size(534, 25)
        Me.ucAgencia.TabIndex = 4
        Me.ucAgencia.TextBoxLeft = CType(60, Short)
        Me.ucAgencia.TextWidth = 90
        '
        'ucCLiente
        '
        Me.ucCLiente.BackColor = System.Drawing.SystemColors.Control
        Me.ucCLiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCLiente.Caption = "Cliente"
        Me.ucCLiente.DataTextValue = Nothing
        Me.ucCLiente.Location = New System.Drawing.Point(6, 121)
        Me.ucCLiente.MaxLength = 6
        Me.ucCLiente.Name = "ucCLiente"
        Me.ucCLiente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCLiente.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCLiente.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucCLiente.pDecimal = CType(0, Byte)
        Me.ucCLiente.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.ucCLiente.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCLiente.showButton = True
        Me.ucCLiente.ShowDescricao = True
        Me.ucCLiente.Size = New System.Drawing.Size(534, 25)
        Me.ucCLiente.TabIndex = 3
        Me.ucCLiente.TextBoxLeft = CType(60, Short)
        Me.ucCLiente.TextWidth = 90
        '
        'ucNucleo
        '
        Me.ucNucleo.BackColor = System.Drawing.SystemColors.Control
        Me.ucNucleo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucNucleo.Caption = "Nucleo"
        Me.ucNucleo.DataTextValue = Nothing
        Me.ucNucleo.Location = New System.Drawing.Point(6, 53)
        Me.ucNucleo.MaxLength = 6
        Me.ucNucleo.Name = "ucNucleo"
        Me.ucNucleo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucNucleo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucNucleo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucNucleo.pDecimal = CType(0, Byte)
        Me.ucNucleo.pDicionario = WUC.clsDicionario.enuDicionario.Nucleo
        Me.ucNucleo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucNucleo.showButton = True
        Me.ucNucleo.ShowDescricao = True
        Me.ucNucleo.Size = New System.Drawing.Size(534, 25)
        Me.ucNucleo.sqlQuery = "Execute PrNet_Nucleo_L"
        Me.ucNucleo.TabIndex = 1
        Me.ucNucleo.TextBoxLeft = CType(60, Short)
        Me.ucNucleo.TextWidth = 90
        '
        'ucCompetencia
        '
        Me.ucCompetencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucCompetencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCompetencia.Caption = "Mês/Ano"
        Me.ucCompetencia.DataTextValue = Nothing
        Me.ucCompetencia.Location = New System.Drawing.Point(6, 19)
        Me.ucCompetencia.MaxLength = 32767
        Me.ucCompetencia.Name = "ucCompetencia"
        Me.ucCompetencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCompetencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCompetencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucCompetencia.pDecimal = CType(0, Byte)
        Me.ucCompetencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCompetencia.pFormatoSaida = WUC.UcText.FormatoSaida.Mes_Ano
        Me.ucCompetencia.Size = New System.Drawing.Size(161, 25)
        Me.ucCompetencia.sqlQuery = Nothing
        Me.ucCompetencia.TabIndex = 0
        Me.ucCompetencia.TextBoxLeft = CType(60, Short)
        Me.ucCompetencia.TextWidth = 90
        '
        'frmAmFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(579, 430)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnAM)
        Me.Controls.Add(Me.GroupFiltro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAmFiltro"
        Me.Text = "Filtro de Am's"
        Me.GroupFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAM As WUC.ucButton
    Friend WithEvents GroupFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents ucSequencia As WUC.UcText
    Friend WithEvents ucContrato As WUC.UcText
    Friend WithEvents ucEmpresa As WUC.UcText
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents ucAgencia As WUC.UcText
    Friend WithEvents ucCLiente As WUC.UcText
    Friend WithEvents ucNucleo As WUC.UcText
    Friend WithEvents ucCompetencia As WUC.UcText
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents ucContato As WUC.UcText
End Class
