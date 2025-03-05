<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpressaoCe
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
        Me.optContrato = New System.Windows.Forms.RadioButton
        Me.optNumeroComprovante = New System.Windows.Forms.RadioButton
        Me.opdData = New System.Windows.Forms.RadioButton
        Me.GroupData = New System.Windows.Forms.GroupBox
        Me.ucDataProcessamento = New WUC.UcText
        Me.GroupComprovante = New System.Windows.Forms.GroupBox
        Me.ucNumeroCeFim = New WUC.UcText
        Me.ucNumeroCeInicio = New WUC.UcText
        Me.GroupContrato = New System.Windows.Forms.GroupBox
        Me.ucSequencia = New WUC.UcText
        Me.ucContrato = New WUC.UcText
        Me.ucEmpresa = New WUC.UcText
        Me.optPendente = New System.Windows.Forms.RadioButton
        Me.groupVeiculo = New System.Windows.Forms.GroupBox
        Me.gridVeiculo = New System.Windows.Forms.DataGridView
        Me.btnMarcar = New System.Windows.Forms.Button
        Me.btnDesmarcar = New System.Windows.Forms.Button
        Me.btnOkCancel = New WUC.ucButton
        Me.ucEmpresaFaturamento = New WUC.UcText
        Me.groupFiltro.SuspendLayout()
        Me.GroupData.SuspendLayout()
        Me.GroupComprovante.SuspendLayout()
        Me.GroupContrato.SuspendLayout()
        Me.groupVeiculo.SuspendLayout()
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupFiltro
        '
        Me.groupFiltro.Controls.Add(Me.optContrato)
        Me.groupFiltro.Controls.Add(Me.optNumeroComprovante)
        Me.groupFiltro.Controls.Add(Me.opdData)
        Me.groupFiltro.Controls.Add(Me.GroupData)
        Me.groupFiltro.Controls.Add(Me.GroupComprovante)
        Me.groupFiltro.Controls.Add(Me.GroupContrato)
        Me.groupFiltro.Controls.Add(Me.optPendente)
        Me.groupFiltro.Location = New System.Drawing.Point(498, 53)
        Me.groupFiltro.Name = "groupFiltro"
        Me.groupFiltro.Size = New System.Drawing.Size(288, 419)
        Me.groupFiltro.TabIndex = 2
        Me.groupFiltro.TabStop = False
        Me.groupFiltro.Text = "Filtros"
        '
        'optContrato
        '
        Me.optContrato.AutoSize = True
        Me.optContrato.Location = New System.Drawing.Point(24, 264)
        Me.optContrato.Name = "optContrato"
        Me.optContrato.Size = New System.Drawing.Size(84, 17)
        Me.optContrato.TabIndex = 11
        Me.optContrato.TabStop = True
        Me.optContrato.Text = "Por Contrato"
        Me.optContrato.UseVisualStyleBackColor = True
        '
        'optNumeroComprovante
        '
        Me.optNumeroComprovante.AutoSize = True
        Me.optNumeroComprovante.Location = New System.Drawing.Point(24, 175)
        Me.optNumeroComprovante.Name = "optNumeroComprovante"
        Me.optNumeroComprovante.Size = New System.Drawing.Size(162, 17)
        Me.optNumeroComprovante.TabIndex = 10
        Me.optNumeroComprovante.TabStop = True
        Me.optNumeroComprovante.Text = "Por Numero do Comprovante"
        Me.optNumeroComprovante.UseVisualStyleBackColor = True
        '
        'opdData
        '
        Me.opdData.AutoSize = True
        Me.opdData.Location = New System.Drawing.Point(24, 78)
        Me.opdData.Name = "opdData"
        Me.opdData.Size = New System.Drawing.Size(158, 17)
        Me.opdData.TabIndex = 9
        Me.opdData.TabStop = True
        Me.opdData.Text = "Por Data de Processamento"
        Me.opdData.UseVisualStyleBackColor = True
        '
        'GroupData
        '
        Me.GroupData.Controls.Add(Me.ucDataProcessamento)
        Me.GroupData.Enabled = False
        Me.GroupData.Location = New System.Drawing.Point(24, 92)
        Me.GroupData.Name = "GroupData"
        Me.GroupData.Size = New System.Drawing.Size(240, 67)
        Me.GroupData.TabIndex = 8
        Me.GroupData.TabStop = False
        '
        'ucDataProcessamento
        '
        Me.ucDataProcessamento.BackColor = System.Drawing.SystemColors.Control
        Me.ucDataProcessamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucDataProcessamento.Caption = "Data"
        Me.ucDataProcessamento.DataTextValue = Nothing
        Me.ucDataProcessamento.Location = New System.Drawing.Point(36, 19)
        Me.ucDataProcessamento.MaxLength = 10
        Me.ucDataProcessamento.Name = "ucDataProcessamento"
        Me.ucDataProcessamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucDataProcessamento.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucDataProcessamento.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucDataProcessamento.pDecimal = CType(0, Byte)
        Me.ucDataProcessamento.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucDataProcessamento.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.ucDataProcessamento.Size = New System.Drawing.Size(168, 25)
        Me.ucDataProcessamento.sqlQuery = Nothing
        Me.ucDataProcessamento.TabIndex = 3
        Me.ucDataProcessamento.TextBoxLeft = CType(0, Short)
        Me.ucDataProcessamento.TextWidth = 0
        '
        'GroupComprovante
        '
        Me.GroupComprovante.Controls.Add(Me.ucNumeroCeFim)
        Me.GroupComprovante.Controls.Add(Me.ucNumeroCeInicio)
        Me.GroupComprovante.Enabled = False
        Me.GroupComprovante.Location = New System.Drawing.Point(24, 189)
        Me.GroupComprovante.Name = "GroupComprovante"
        Me.GroupComprovante.Size = New System.Drawing.Size(240, 60)
        Me.GroupComprovante.TabIndex = 7
        Me.GroupComprovante.TabStop = False
        '
        'ucNumeroCeFim
        '
        Me.ucNumeroCeFim.BackColor = System.Drawing.SystemColors.Control
        Me.ucNumeroCeFim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucNumeroCeFim.Caption = "Até"
        Me.ucNumeroCeFim.DataTextValue = Nothing
        Me.ucNumeroCeFim.Location = New System.Drawing.Point(125, 19)
        Me.ucNumeroCeFim.MaxLength = 32767
        Me.ucNumeroCeFim.Name = "ucNumeroCeFim"
        Me.ucNumeroCeFim.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucNumeroCeFim.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucNumeroCeFim.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucNumeroCeFim.pDecimal = CType(0, Byte)
        Me.ucNumeroCeFim.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucNumeroCeFim.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucNumeroCeFim.Size = New System.Drawing.Size(92, 25)
        Me.ucNumeroCeFim.sqlQuery = Nothing
        Me.ucNumeroCeFim.TabIndex = 7
        Me.ucNumeroCeFim.TextBoxLeft = CType(0, Short)
        Me.ucNumeroCeFim.TextWidth = 0
        '
        'ucNumeroCeInicio
        '
        Me.ucNumeroCeInicio.BackColor = System.Drawing.SystemColors.Control
        Me.ucNumeroCeInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucNumeroCeInicio.Caption = "De"
        Me.ucNumeroCeInicio.DataTextValue = Nothing
        Me.ucNumeroCeInicio.Location = New System.Drawing.Point(14, 19)
        Me.ucNumeroCeInicio.MaxLength = 32767
        Me.ucNumeroCeInicio.Name = "ucNumeroCeInicio"
        Me.ucNumeroCeInicio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucNumeroCeInicio.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucNumeroCeInicio.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucNumeroCeInicio.pDecimal = CType(0, Byte)
        Me.ucNumeroCeInicio.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucNumeroCeInicio.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucNumeroCeInicio.Size = New System.Drawing.Size(92, 25)
        Me.ucNumeroCeInicio.sqlQuery = Nothing
        Me.ucNumeroCeInicio.TabIndex = 6
        Me.ucNumeroCeInicio.TextBoxLeft = CType(0, Short)
        Me.ucNumeroCeInicio.TextWidth = 0
        '
        'GroupContrato
        '
        Me.GroupContrato.Controls.Add(Me.ucSequencia)
        Me.GroupContrato.Controls.Add(Me.ucContrato)
        Me.GroupContrato.Controls.Add(Me.ucEmpresa)
        Me.GroupContrato.Enabled = False
        Me.GroupContrato.Location = New System.Drawing.Point(24, 278)
        Me.GroupContrato.Name = "GroupContrato"
        Me.GroupContrato.Size = New System.Drawing.Size(240, 125)
        Me.GroupContrato.TabIndex = 6
        Me.GroupContrato.TabStop = False
        '
        'ucSequencia
        '
        Me.ucSequencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucSequencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucSequencia.Caption = "Sequencia"
        Me.ucSequencia.DataTextValue = Nothing
        Me.ucSequencia.Location = New System.Drawing.Point(36, 81)
        Me.ucSequencia.MaxLength = 32767
        Me.ucSequencia.Name = "ucSequencia"
        Me.ucSequencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucSequencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucSequencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucSequencia.pDecimal = CType(0, Byte)
        Me.ucSequencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucSequencia.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucSequencia.Size = New System.Drawing.Size(158, 25)
        Me.ucSequencia.sqlQuery = Nothing
        Me.ucSequencia.TabIndex = 12
        Me.ucSequencia.TextBoxLeft = CType(60, Short)
        Me.ucSequencia.TextWidth = 0
        '
        'ucContrato
        '
        Me.ucContrato.BackColor = System.Drawing.SystemColors.Control
        Me.ucContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucContrato.Caption = "Contrato"
        Me.ucContrato.DataTextValue = Nothing
        Me.ucContrato.Location = New System.Drawing.Point(36, 50)
        Me.ucContrato.MaxLength = 32767
        Me.ucContrato.Name = "ucContrato"
        Me.ucContrato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucContrato.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucContrato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucContrato.pDecimal = CType(0, Byte)
        Me.ucContrato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucContrato.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucContrato.Size = New System.Drawing.Size(158, 25)
        Me.ucContrato.sqlQuery = Nothing
        Me.ucContrato.TabIndex = 11
        Me.ucContrato.TextBoxLeft = CType(60, Short)
        Me.ucContrato.TextWidth = 0
        '
        'ucEmpresa
        '
        Me.ucEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.ucEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucEmpresa.Caption = "Empresa"
        Me.ucEmpresa.DataTextValue = Nothing
        Me.ucEmpresa.Location = New System.Drawing.Point(36, 19)
        Me.ucEmpresa.MaxLength = 32767
        Me.ucEmpresa.Name = "ucEmpresa"
        Me.ucEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucEmpresa.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucEmpresa.pDecimal = CType(0, Byte)
        Me.ucEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucEmpresa.Size = New System.Drawing.Size(158, 25)
        Me.ucEmpresa.sqlQuery = Nothing
        Me.ucEmpresa.TabIndex = 10
        Me.ucEmpresa.TextBoxLeft = CType(60, Short)
        Me.ucEmpresa.TextWidth = 0
        '
        'optPendente
        '
        Me.optPendente.AutoSize = True
        Me.optPendente.Location = New System.Drawing.Point(24, 30)
        Me.optPendente.Name = "optPendente"
        Me.optPendente.Size = New System.Drawing.Size(142, 17)
        Me.optPendente.TabIndex = 0
        Me.optPendente.TabStop = True
        Me.optPendente.Text = "Pendentes de Impressão"
        Me.optPendente.UseVisualStyleBackColor = True
        '
        'groupVeiculo
        '
        Me.groupVeiculo.Controls.Add(Me.gridVeiculo)
        Me.groupVeiculo.Location = New System.Drawing.Point(12, 53)
        Me.groupVeiculo.Name = "groupVeiculo"
        Me.groupVeiculo.Size = New System.Drawing.Size(480, 419)
        Me.groupVeiculo.TabIndex = 3
        Me.groupVeiculo.TabStop = False
        Me.groupVeiculo.Text = "Veiculo"
        '
        'gridVeiculo
        '
        Me.gridVeiculo.BackgroundColor = System.Drawing.Color.White
        Me.gridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVeiculo.Location = New System.Drawing.Point(6, 19)
        Me.gridVeiculo.Name = "gridVeiculo"
        Me.gridVeiculo.Size = New System.Drawing.Size(468, 389)
        Me.gridVeiculo.TabIndex = 2
        '
        'btnMarcar
        '
        Me.btnMarcar.Location = New System.Drawing.Point(12, 482)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(117, 32)
        Me.btnMarcar.TabIndex = 5
        Me.btnMarcar.Text = "Marcar Todos"
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'btnDesmarcar
        '
        Me.btnDesmarcar.Location = New System.Drawing.Point(153, 482)
        Me.btnDesmarcar.Name = "btnDesmarcar"
        Me.btnDesmarcar.Size = New System.Drawing.Size(119, 33)
        Me.btnDesmarcar.TabIndex = 6
        Me.btnDesmarcar.Text = "Desmarcar Todos"
        Me.btnDesmarcar.UseVisualStyleBackColor = True
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(607, 482)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 4
        '
        'ucEmpresaFaturamento
        '
        Me.ucEmpresaFaturamento.BackColor = System.Drawing.SystemColors.Control
        Me.ucEmpresaFaturamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucEmpresaFaturamento.Caption = "Empresa de Faturamento"
        Me.ucEmpresaFaturamento.DataTextValue = Nothing
        Me.ucEmpresaFaturamento.Location = New System.Drawing.Point(20, 12)
        Me.ucEmpresaFaturamento.MaxLength = 3
        Me.ucEmpresaFaturamento.Name = "ucEmpresaFaturamento"
        Me.ucEmpresaFaturamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucEmpresaFaturamento.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucEmpresaFaturamento.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucEmpresaFaturamento.pDecimal = CType(0, Byte)
        Me.ucEmpresaFaturamento.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.ucEmpresaFaturamento.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucEmpresaFaturamento.showButton = True
        Me.ucEmpresaFaturamento.ShowDescricao = True
        Me.ucEmpresaFaturamento.Size = New System.Drawing.Size(766, 25)
        Me.ucEmpresaFaturamento.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.ucEmpresaFaturamento.TabIndex = 0
        Me.ucEmpresaFaturamento.TextBoxLeft = CType(0, Short)
        Me.ucEmpresaFaturamento.TextWidth = 60
        '
        'frmImpressaoCe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 526)
        Me.Controls.Add(Me.btnDesmarcar)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.groupVeiculo)
        Me.Controls.Add(Me.groupFiltro)
        Me.Controls.Add(Me.ucEmpresaFaturamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmImpressaoCe"
        Me.Text = "Relatório de Comprovante de Exibição"
        Me.groupFiltro.ResumeLayout(False)
        Me.groupFiltro.PerformLayout()
        Me.GroupData.ResumeLayout(False)
        Me.GroupComprovante.ResumeLayout(False)
        Me.GroupContrato.ResumeLayout(False)
        Me.groupVeiculo.ResumeLayout(False)
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucEmpresaFaturamento As WUC.UcText
    Friend WithEvents groupFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents groupVeiculo As System.Windows.Forms.GroupBox
    Friend WithEvents gridVeiculo As System.Windows.Forms.DataGridView
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents optPendente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupComprovante As System.Windows.Forms.GroupBox
    Friend WithEvents ucNumeroCeFim As WUC.UcText
    Friend WithEvents ucNumeroCeInicio As WUC.UcText
    Friend WithEvents GroupContrato As System.Windows.Forms.GroupBox
    Friend WithEvents ucSequencia As WUC.UcText
    Friend WithEvents ucContrato As WUC.UcText
    Friend WithEvents ucEmpresa As WUC.UcText
    Friend WithEvents GroupData As System.Windows.Forms.GroupBox
    Friend WithEvents ucDataProcessamento As WUC.UcText
    Friend WithEvents opdData As System.Windows.Forms.RadioButton
    Friend WithEvents optContrato As System.Windows.Forms.RadioButton
    Friend WithEvents optNumeroComprovante As System.Windows.Forms.RadioButton
    Friend WithEvents btnMarcar As System.Windows.Forms.Button
    Friend WithEvents btnDesmarcar As System.Windows.Forms.Button
End Class
