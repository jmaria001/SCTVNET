<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRConsultaFiltro
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
        Me.grpFiltro = New System.Windows.Forms.GroupBox
        Me.chkContratoEvento = New System.Windows.Forms.CheckBox
        Me.chkPendentes = New System.Windows.Forms.CheckBox
        Me.txtDataInclusao = New WUC.UcText
        Me.txtNumeroPI = New WUC.UcText
        Me.txtAbrangencia = New WUC.UcText
        Me.txtTipoComercial = New WUC.UcText
        Me.txtPrograma = New WUC.UcText
        Me.txtProduto = New WUC.UcText
        Me.txtTipoMidia = New WUC.UcText
        Me.txtNucleo = New WUC.UcText
        Me.txtContato = New WUC.UcText
        Me.txtCliente = New WUC.UcText
        Me.txtAgencia = New WUC.UcText
        Me.txtVeiculo = New WUC.UcText
        Me.txtNegociacao = New WUC.UcText
        Me.TxtDataAte = New WUC.UcText
        Me.TxtDatade = New WUC.UcText
        Me.txtSeq = New WUC.UcText
        Me.txtContrato = New WUC.UcText
        Me.txtEmpresa = New WUC.UcText
        Me.grpVisualizacao = New System.Windows.Forms.GroupBox
        Me.chkMostraVeiculo = New System.Windows.Forms.CheckBox
        Me.chkMostraProduto = New System.Windows.Forms.CheckBox
        Me.grpAtualizacao = New System.Windows.Forms.GroupBox
        Me.chkAutorizados = New System.Windows.Forms.CheckBox
        Me.chkRejeitados = New System.Windows.Forms.CheckBox
        Me.chkAutorizacao = New System.Windows.Forms.CheckBox
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.grpFiltro.SuspendLayout()
        Me.grpVisualizacao.SuspendLayout()
        Me.grpAtualizacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.chkContratoEvento)
        Me.grpFiltro.Controls.Add(Me.chkPendentes)
        Me.grpFiltro.Controls.Add(Me.txtDataInclusao)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPI)
        Me.grpFiltro.Controls.Add(Me.txtAbrangencia)
        Me.grpFiltro.Controls.Add(Me.txtTipoComercial)
        Me.grpFiltro.Controls.Add(Me.txtPrograma)
        Me.grpFiltro.Controls.Add(Me.txtProduto)
        Me.grpFiltro.Controls.Add(Me.txtTipoMidia)
        Me.grpFiltro.Controls.Add(Me.txtNucleo)
        Me.grpFiltro.Controls.Add(Me.txtContato)
        Me.grpFiltro.Controls.Add(Me.txtCliente)
        Me.grpFiltro.Controls.Add(Me.txtAgencia)
        Me.grpFiltro.Controls.Add(Me.txtVeiculo)
        Me.grpFiltro.Controls.Add(Me.txtNegociacao)
        Me.grpFiltro.Controls.Add(Me.TxtDataAte)
        Me.grpFiltro.Controls.Add(Me.TxtDatade)
        Me.grpFiltro.Controls.Add(Me.txtSeq)
        Me.grpFiltro.Controls.Add(Me.txtContrato)
        Me.grpFiltro.Controls.Add(Me.txtEmpresa)
        Me.grpFiltro.Location = New System.Drawing.Point(7, 12)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(689, 381)
        Me.grpFiltro.TabIndex = 1
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Opções de Filtro"
        '
        'chkContratoEvento
        '
        Me.chkContratoEvento.AutoSize = True
        Me.chkContratoEvento.Location = New System.Drawing.Point(360, 358)
        Me.chkContratoEvento.Name = "chkContratoEvento"
        Me.chkContratoEvento.Size = New System.Drawing.Size(226, 17)
        Me.chkContratoEvento.TabIndex = 17
        Me.chkContratoEvento.Text = "Contratos Eventos Valorados como normal"
        Me.chkContratoEvento.UseVisualStyleBackColor = True
        '
        'chkPendentes
        '
        Me.chkPendentes.AutoSize = True
        Me.chkPendentes.Location = New System.Drawing.Point(13, 358)
        Me.chkPendentes.Name = "chkPendentes"
        Me.chkPendentes.Size = New System.Drawing.Size(158, 17)
        Me.chkPendentes.TabIndex = 16
        Me.chkPendentes.Text = "Pendentes de Comprovante"
        Me.chkPendentes.UseVisualStyleBackColor = True
        '
        'txtDataInclusao
        '
        Me.txtDataInclusao.BackColor = System.Drawing.SystemColors.Control
        Me.txtDataInclusao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtDataInclusao.Caption = "Data da Inclusão:"
        Me.txtDataInclusao.DataTextValue = Nothing
        Me.txtDataInclusao.Location = New System.Drawing.Point(493, 304)
        Me.txtDataInclusao.MaxLength = 10
        Me.txtDataInclusao.Name = "txtDataInclusao"
        Me.txtDataInclusao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDataInclusao.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtDataInclusao.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtDataInclusao.pDecimal = CType(0, Byte)
        Me.txtDataInclusao.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtDataInclusao.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.txtDataInclusao.Size = New System.Drawing.Size(129, 37)
        Me.txtDataInclusao.sqlQuery = Nothing
        Me.txtDataInclusao.TabIndex = 15
        Me.txtDataInclusao.TextBoxLeft = CType(0, Short)
        Me.txtDataInclusao.TextWidth = 0
        '
        'txtNumeroPI
        '
        Me.txtNumeroPI.BackColor = System.Drawing.SystemColors.Control
        Me.txtNumeroPI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNumeroPI.Caption = "Número do PI:"
        Me.txtNumeroPI.DataTextValue = Nothing
        Me.txtNumeroPI.Location = New System.Drawing.Point(360, 304)
        Me.txtNumeroPI.MaxLength = 32767
        Me.txtNumeroPI.Name = "txtNumeroPI"
        Me.txtNumeroPI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroPI.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNumeroPI.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtNumeroPI.pDecimal = CType(0, Byte)
        Me.txtNumeroPI.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNumeroPI.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtNumeroPI.Size = New System.Drawing.Size(129, 37)
        Me.txtNumeroPI.sqlQuery = Nothing
        Me.txtNumeroPI.TabIndex = 14
        Me.txtNumeroPI.TextBoxLeft = CType(0, Short)
        Me.txtNumeroPI.TextWidth = 0
        '
        'txtAbrangencia
        '
        Me.txtAbrangencia.BackColor = System.Drawing.SystemColors.Control
        Me.txtAbrangencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtAbrangencia.Caption = "Abrangência"
        Me.txtAbrangencia.DataTextValue = Nothing
        Me.txtAbrangencia.Location = New System.Drawing.Point(13, 304)
        Me.txtAbrangencia.MaxLength = 2
        Me.txtAbrangencia.Name = "txtAbrangencia"
        Me.txtAbrangencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAbrangencia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtAbrangencia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtAbrangencia.pDecimal = CType(0, Byte)
        Me.txtAbrangencia.pDicionario = WUC.clsDicionario.enuDicionario.Abrangencia
        Me.txtAbrangencia.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtAbrangencia.showButton = True
        Me.txtAbrangencia.ShowDescricao = True
        Me.txtAbrangencia.Size = New System.Drawing.Size(324, 37)
        Me.txtAbrangencia.sqlQuery = "execute PrNet_Abrangencia_L"
        Me.txtAbrangencia.TabIndex = 13
        Me.txtAbrangencia.TextBoxLeft = CType(0, Short)
        Me.txtAbrangencia.TextWidth = 0
        '
        'txtTipoComercial
        '
        Me.txtTipoComercial.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipoComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTipoComercial.Caption = "Tipo de Comercial:"
        Me.txtTipoComercial.DataTextValue = Nothing
        Me.txtTipoComercial.Location = New System.Drawing.Point(360, 261)
        Me.txtTipoComercial.MaxLength = 2
        Me.txtTipoComercial.Name = "txtTipoComercial"
        Me.txtTipoComercial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoComercial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTipoComercial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtTipoComercial.pDecimal = CType(0, Byte)
        Me.txtTipoComercial.pDicionario = WUC.clsDicionario.enuDicionario.Tipo_Comercial
        Me.txtTipoComercial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTipoComercial.showButton = True
        Me.txtTipoComercial.ShowDescricao = True
        Me.txtTipoComercial.Size = New System.Drawing.Size(321, 37)
        Me.txtTipoComercial.sqlQuery = "Execute prNet_Tipo_Comercial_L"
        Me.txtTipoComercial.TabIndex = 12
        Me.txtTipoComercial.TextBoxLeft = CType(0, Short)
        Me.txtTipoComercial.TextWidth = 0
        '
        'txtPrograma
        '
        Me.txtPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.txtPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtPrograma.Caption = "Programa"
        Me.txtPrograma.DataTextValue = Nothing
        Me.txtPrograma.Location = New System.Drawing.Point(13, 261)
        Me.txtPrograma.MaxLength = 4
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtPrograma.pDecimal = CType(0, Byte)
        Me.txtPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.txtPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtPrograma.showButton = True
        Me.txtPrograma.ShowDescricao = True
        Me.txtPrograma.Size = New System.Drawing.Size(324, 37)
        Me.txtPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.txtPrograma.TabIndex = 11
        Me.txtPrograma.TextBoxLeft = CType(0, Short)
        Me.txtPrograma.TextWidth = 0
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.SystemColors.Control
        Me.txtProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtProduto.Caption = "Produto"
        Me.txtProduto.DataTextValue = Nothing
        Me.txtProduto.Location = New System.Drawing.Point(360, 218)
        Me.txtProduto.MaxLength = 6
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProduto.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtProduto.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtProduto.pDecimal = CType(0, Byte)
        Me.txtProduto.pDicionario = WUC.clsDicionario.enuDicionario.Produto
        Me.txtProduto.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtProduto.showButton = True
        Me.txtProduto.ShowDescricao = True
        Me.txtProduto.Size = New System.Drawing.Size(321, 37)
        Me.txtProduto.sqlQuery = "False"
        Me.txtProduto.TabIndex = 10
        Me.txtProduto.TextBoxLeft = CType(0, Short)
        Me.txtProduto.TextWidth = 0
        '
        'txtTipoMidia
        '
        Me.txtTipoMidia.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipoMidia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTipoMidia.Caption = "Tipo de Mídia"
        Me.txtTipoMidia.DataTextValue = Nothing
        Me.txtTipoMidia.Location = New System.Drawing.Point(13, 218)
        Me.txtTipoMidia.MaxLength = 6
        Me.txtTipoMidia.Name = "txtTipoMidia"
        Me.txtTipoMidia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoMidia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTipoMidia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtTipoMidia.pDecimal = CType(0, Byte)
        Me.txtTipoMidia.pDicionario = WUC.clsDicionario.enuDicionario.Tipo_de_Midia
        Me.txtTipoMidia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTipoMidia.showButton = True
        Me.txtTipoMidia.ShowDescricao = True
        Me.txtTipoMidia.Size = New System.Drawing.Size(324, 37)
        Me.txtTipoMidia.sqlQuery = "Execute PrNet_Tipo_Midia_L"
        Me.txtTipoMidia.TabIndex = 15
        Me.txtTipoMidia.TextBoxLeft = CType(0, Short)
        Me.txtTipoMidia.TextWidth = 0
        '
        'txtNucleo
        '
        Me.txtNucleo.BackColor = System.Drawing.SystemColors.Control
        Me.txtNucleo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNucleo.Caption = "Nucleo"
        Me.txtNucleo.DataTextValue = Nothing
        Me.txtNucleo.Location = New System.Drawing.Point(360, 175)
        Me.txtNucleo.MaxLength = 6
        Me.txtNucleo.Name = "txtNucleo"
        Me.txtNucleo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNucleo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNucleo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtNucleo.pDecimal = CType(0, Byte)
        Me.txtNucleo.pDicionario = WUC.clsDicionario.enuDicionario.Nucleo
        Me.txtNucleo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNucleo.showButton = True
        Me.txtNucleo.ShowDescricao = True
        Me.txtNucleo.Size = New System.Drawing.Size(321, 37)
        Me.txtNucleo.sqlQuery = "Execute PrNet_Nucleo_L"
        Me.txtNucleo.TabIndex = 14
        Me.txtNucleo.TextBoxLeft = CType(0, Short)
        Me.txtNucleo.TextWidth = 0
        '
        'txtContato
        '
        Me.txtContato.BackColor = System.Drawing.SystemColors.Control
        Me.txtContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtContato.Caption = "Contato"
        Me.txtContato.DataTextValue = Nothing
        Me.txtContato.Location = New System.Drawing.Point(13, 175)
        Me.txtContato.MaxLength = 6
        Me.txtContato.Name = "txtContato"
        Me.txtContato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContato.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtContato.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtContato.pDecimal = CType(0, Byte)
        Me.txtContato.pDicionario = WUC.clsDicionario.enuDicionario.Contato
        Me.txtContato.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtContato.showButton = True
        Me.txtContato.ShowDescricao = True
        Me.txtContato.Size = New System.Drawing.Size(324, 37)
        Me.txtContato.sqlQuery = "Execute prNet_Contato_L Null,''"
        Me.txtContato.TabIndex = 9
        Me.txtContato.TextBoxLeft = CType(0, Short)
        Me.txtContato.TextWidth = 0
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Control
        Me.txtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCliente.Caption = "Cliente:"
        Me.txtCliente.DataTextValue = Nothing
        Me.txtCliente.Location = New System.Drawing.Point(360, 132)
        Me.txtCliente.MaxLength = 6
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCliente.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtCliente.pDecimal = CType(0, Byte)
        Me.txtCliente.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.txtCliente.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.showButton = True
        Me.txtCliente.ShowDescricao = True
        Me.txtCliente.Size = New System.Drawing.Size(321, 37)
        Me.txtCliente.sqlQuery = "Execute prNet_Terceiro_S Null, ''"
        Me.txtCliente.TabIndex = 8
        Me.txtCliente.TextBoxLeft = CType(0, Short)
        Me.txtCliente.TextWidth = 0
        '
        'txtAgencia
        '
        Me.txtAgencia.BackColor = System.Drawing.SystemColors.Control
        Me.txtAgencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtAgencia.Caption = "Agência:"
        Me.txtAgencia.DataTextValue = Nothing
        Me.txtAgencia.Location = New System.Drawing.Point(13, 132)
        Me.txtAgencia.MaxLength = 6
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAgencia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtAgencia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtAgencia.pDecimal = CType(0, Byte)
        Me.txtAgencia.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Codigo
        Me.txtAgencia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtAgencia.showButton = True
        Me.txtAgencia.ShowDescricao = True
        Me.txtAgencia.Size = New System.Drawing.Size(324, 37)
        Me.txtAgencia.sqlQuery = "Execute prNet_Terceiro_S Null, ''"
        Me.txtAgencia.TabIndex = 7
        Me.txtAgencia.TextBoxLeft = CType(0, Short)
        Me.txtAgencia.TextWidth = 0
        '
        'txtVeiculo
        '
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.txtVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtVeiculo.Caption = "Veiculo"
        Me.txtVeiculo.DataTextValue = Nothing
        Me.txtVeiculo.Location = New System.Drawing.Point(360, 89)
        Me.txtVeiculo.MaxLength = 3
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtVeiculo.pDecimal = CType(0, Byte)
        Me.txtVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.txtVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtVeiculo.showButton = True
        Me.txtVeiculo.ShowDescricao = True
        Me.txtVeiculo.Size = New System.Drawing.Size(321, 37)
        Me.txtVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.txtVeiculo.TabIndex = 6
        Me.txtVeiculo.TextBoxLeft = CType(0, Short)
        Me.txtVeiculo.TextWidth = 0
        '
        'txtNegociacao
        '
        Me.txtNegociacao.BackColor = System.Drawing.SystemColors.Control
        Me.txtNegociacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNegociacao.Caption = "Negociação"
        Me.txtNegociacao.DataTextValue = Nothing
        Me.txtNegociacao.Location = New System.Drawing.Point(586, 32)
        Me.txtNegociacao.MaxLength = 32767
        Me.txtNegociacao.Name = "txtNegociacao"
        Me.txtNegociacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNegociacao.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNegociacao.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtNegociacao.pDecimal = CType(0, Byte)
        Me.txtNegociacao.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNegociacao.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNegociacao.Size = New System.Drawing.Size(91, 37)
        Me.txtNegociacao.sqlQuery = Nothing
        Me.txtNegociacao.TabIndex = 4
        Me.txtNegociacao.TextBoxLeft = CType(0, Short)
        Me.txtNegociacao.TextWidth = 0
        '
        'TxtDataAte
        '
        Me.TxtDataAte.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDataAte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtDataAte.Caption = "Até:"
        Me.TxtDataAte.DataTextValue = Nothing
        Me.TxtDataAte.Location = New System.Drawing.Point(360, 32)
        Me.TxtDataAte.MaxLength = 10
        Me.TxtDataAte.Name = "TxtDataAte"
        Me.TxtDataAte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDataAte.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtDataAte.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtDataAte.pDecimal = CType(0, Byte)
        Me.TxtDataAte.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtDataAte.pFormatoSaida = WUC.UcText.FormatoSaida.Mes_Ano
        Me.TxtDataAte.Size = New System.Drawing.Size(93, 37)
        Me.TxtDataAte.sqlQuery = Nothing
        Me.TxtDataAte.TabIndex = 3
        Me.TxtDataAte.TextBoxLeft = CType(0, Short)
        Me.TxtDataAte.TextWidth = 0
        '
        'TxtDatade
        '
        Me.TxtDatade.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDatade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtDatade.Caption = "Competência de:"
        Me.TxtDatade.DataTextValue = Nothing
        Me.TxtDatade.Location = New System.Drawing.Point(261, 32)
        Me.TxtDatade.MaxLength = 10
        Me.TxtDatade.Name = "TxtDatade"
        Me.TxtDatade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDatade.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtDatade.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtDatade.pDecimal = CType(0, Byte)
        Me.TxtDatade.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtDatade.pFormatoSaida = WUC.UcText.FormatoSaida.Mes_Ano
        Me.TxtDatade.Size = New System.Drawing.Size(101, 37)
        Me.TxtDatade.sqlQuery = Nothing
        Me.TxtDatade.TabIndex = 2
        Me.TxtDatade.TextBoxLeft = CType(0, Short)
        Me.TxtDatade.TextWidth = 0
        '
        'txtSeq
        '
        Me.txtSeq.BackColor = System.Drawing.SystemColors.Control
        Me.txtSeq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSeq.Caption = "Seq.:"
        Me.txtSeq.DataTextValue = Nothing
        Me.txtSeq.Location = New System.Drawing.Point(110, 32)
        Me.txtSeq.MaxLength = 10
        Me.txtSeq.Name = "txtSeq"
        Me.txtSeq.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSeq.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtSeq.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtSeq.pDecimal = CType(0, Byte)
        Me.txtSeq.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtSeq.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtSeq.Size = New System.Drawing.Size(37, 37)
        Me.txtSeq.TabIndex = 1
        Me.txtSeq.TextBoxLeft = CType(0, Short)
        Me.txtSeq.TextWidth = 0
        '
        'txtContrato
        '
        Me.txtContrato.BackColor = System.Drawing.SystemColors.Control
        Me.txtContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtContrato.Caption = "Contrato:"
        Me.txtContrato.DataTextValue = Nothing
        Me.txtContrato.Location = New System.Drawing.Point(13, 32)
        Me.txtContrato.MaxLength = 10
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContrato.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtContrato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtContrato.pDecimal = CType(0, Byte)
        Me.txtContrato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtContrato.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtContrato.Size = New System.Drawing.Size(91, 37)
        Me.txtContrato.TabIndex = 0
        Me.txtContrato.TextBoxLeft = CType(0, Short)
        Me.txtContrato.TextWidth = 0
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmpresa.Caption = "Empresa:"
        Me.txtEmpresa.DataTextValue = Nothing
        Me.txtEmpresa.Location = New System.Drawing.Point(13, 89)
        Me.txtEmpresa.MaxLength = 3
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEmpresa.pDecimal = CType(0, Byte)
        Me.txtEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa_Filtro_Historico
        Me.txtEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmpresa.showButton = True
        Me.txtEmpresa.ShowDescricao = True
        Me.txtEmpresa.Size = New System.Drawing.Size(321, 37)
        Me.txtEmpresa.sqlQuery = "Execute PrNet_Empresa_Historico_Mr_L  Null,''"
        Me.txtEmpresa.TabIndex = 5
        Me.txtEmpresa.TextBoxLeft = CType(0, Short)
        Me.txtEmpresa.TextWidth = 0
        '
        'grpVisualizacao
        '
        Me.grpVisualizacao.Controls.Add(Me.chkMostraVeiculo)
        Me.grpVisualizacao.Controls.Add(Me.chkMostraProduto)
        Me.grpVisualizacao.Location = New System.Drawing.Point(7, 399)
        Me.grpVisualizacao.Name = "grpVisualizacao"
        Me.grpVisualizacao.Size = New System.Drawing.Size(168, 102)
        Me.grpVisualizacao.TabIndex = 2
        Me.grpVisualizacao.TabStop = False
        Me.grpVisualizacao.Text = "Opções de Visualização"
        '
        'chkMostraVeiculo
        '
        Me.chkMostraVeiculo.AutoSize = True
        Me.chkMostraVeiculo.Location = New System.Drawing.Point(13, 50)
        Me.chkMostraVeiculo.Name = "chkMostraVeiculo"
        Me.chkMostraVeiculo.Size = New System.Drawing.Size(106, 17)
        Me.chkMostraVeiculo.TabIndex = 19
        Me.chkMostraVeiculo.Text = "Mostrar Veículos"
        Me.chkMostraVeiculo.UseVisualStyleBackColor = True
        '
        'chkMostraProduto
        '
        Me.chkMostraProduto.AutoSize = True
        Me.chkMostraProduto.Location = New System.Drawing.Point(13, 27)
        Me.chkMostraProduto.Name = "chkMostraProduto"
        Me.chkMostraProduto.Size = New System.Drawing.Size(106, 17)
        Me.chkMostraProduto.TabIndex = 18
        Me.chkMostraProduto.Text = "Mostrar Produtos"
        Me.chkMostraProduto.UseVisualStyleBackColor = True
        '
        'grpAtualizacao
        '
        Me.grpAtualizacao.Controls.Add(Me.chkAutorizados)
        Me.grpAtualizacao.Controls.Add(Me.chkRejeitados)
        Me.grpAtualizacao.Controls.Add(Me.chkAutorizacao)
        Me.grpAtualizacao.Location = New System.Drawing.Point(192, 399)
        Me.grpAtualizacao.Name = "grpAtualizacao"
        Me.grpAtualizacao.Size = New System.Drawing.Size(202, 99)
        Me.grpAtualizacao.TabIndex = 3
        Me.grpAtualizacao.TabStop = False
        Me.grpAtualizacao.Text = "Opções de Atualização"
        '
        'chkAutorizados
        '
        Me.chkAutorizados.AutoSize = True
        Me.chkAutorizados.Checked = True
        Me.chkAutorizados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutorizados.Location = New System.Drawing.Point(17, 70)
        Me.chkAutorizados.Name = "chkAutorizados"
        Me.chkAutorizados.Size = New System.Drawing.Size(81, 17)
        Me.chkAutorizados.TabIndex = 2
        Me.chkAutorizados.Text = "Autorizados"
        Me.chkAutorizados.UseVisualStyleBackColor = True
        '
        'chkRejeitados
        '
        Me.chkRejeitados.AutoSize = True
        Me.chkRejeitados.Checked = True
        Me.chkRejeitados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRejeitados.Location = New System.Drawing.Point(17, 47)
        Me.chkRejeitados.Name = "chkRejeitados"
        Me.chkRejeitados.Size = New System.Drawing.Size(76, 17)
        Me.chkRejeitados.TabIndex = 1
        Me.chkRejeitados.Text = "Rejeitados"
        Me.chkRejeitados.UseVisualStyleBackColor = True
        '
        'chkAutorizacao
        '
        Me.chkAutorizacao.AutoSize = True
        Me.chkAutorizacao.Checked = True
        Me.chkAutorizacao.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutorizacao.Location = New System.Drawing.Point(17, 23)
        Me.chkAutorizacao.Name = "chkAutorizacao"
        Me.chkAutorizacao.Size = New System.Drawing.Size(151, 17)
        Me.chkAutorizacao.TabIndex = 0
        Me.chkAutorizacao.Text = "Pendentes de Autorização"
        Me.chkAutorizacao.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(591, 399)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(105, 31)
        Me.btnLimpar.TabIndex = 4
        Me.btnLimpar.Text = "Limpar Filtros"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(591, 433)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(103, 33)
        Me.btnFiltrar.TabIndex = 5
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(591, 469)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(105, 31)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmMRConsultaFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(706, 510)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.grpFiltro)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.grpAtualizacao)
        Me.Controls.Add(Me.grpVisualizacao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "frmMRConsultaFiltro"
        Me.Text = "Filtro"
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.grpVisualizacao.ResumeLayout(False)
        Me.grpVisualizacao.PerformLayout()
        Me.grpAtualizacao.ResumeLayout(False)
        Me.grpAtualizacao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtEmpresa As WUC.UcText
    Friend WithEvents grpFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents grpVisualizacao As System.Windows.Forms.GroupBox
    Friend WithEvents grpAtualizacao As System.Windows.Forms.GroupBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtSeq As WUC.UcText
    Friend WithEvents txtContrato As WUC.UcText
    Friend WithEvents txtVeiculo As WUC.UcText
    Friend WithEvents txtNegociacao As WUC.UcText
    Friend WithEvents TxtDataAte As WUC.UcText
    Friend WithEvents TxtDatade As WUC.UcText
    Friend WithEvents txtAgencia As WUC.UcText
    Friend WithEvents txtCliente As WUC.UcText
    Friend WithEvents txtNucleo As WUC.UcText
    Friend WithEvents txtContato As WUC.UcText
    Friend WithEvents txtTipoMidia As WUC.UcText
    Friend WithEvents txtAbrangencia As WUC.UcText
    Friend WithEvents txtTipoComercial As WUC.UcText
    Friend WithEvents txtPrograma As WUC.UcText
    Friend WithEvents txtProduto As WUC.UcText
    Friend WithEvents txtDataInclusao As WUC.UcText
    Friend WithEvents txtNumeroPI As WUC.UcText
    Friend WithEvents chkContratoEvento As System.Windows.Forms.CheckBox
    Friend WithEvents chkPendentes As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostraVeiculo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostraProduto As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutorizados As System.Windows.Forms.CheckBox
    Friend WithEvents chkRejeitados As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutorizacao As System.Windows.Forms.CheckBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
