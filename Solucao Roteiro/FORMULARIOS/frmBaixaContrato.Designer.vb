<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixaContrato
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
        Me.ucPeriodoCampanha = New WUC.UcText
        Me.ucCliente = New WUC.UcText
        Me.ucAgencia = New WUC.UcText
        Me.ucSequencia = New WUC.UcText
        Me.ucContrato = New WUC.UcText
        Me.ucEmpresa = New WUC.UcText
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.optCancelamento = New System.Windows.Forms.RadioButton
        Me.optBaixa = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtMotivoBaixa = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ucDataAte = New WCL_SCTV.UC.UCData
        Me.ucDataDe = New WCL_SCTV.UC.UCData
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnDesmarcar = New System.Windows.Forms.Button
        Me.btnMarcar = New System.Windows.Forms.Button
        Me.tabFiltro = New System.Windows.Forms.TabControl
        Me.tabVeiculo = New System.Windows.Forms.TabPage
        Me.gridVeiculo = New System.Windows.Forms.DataGridView
        Me.tabPrograma = New System.Windows.Forms.TabPage
        Me.gridPrograma = New System.Windows.Forms.DataGridView
        Me.tabComercial = New System.Windows.Forms.TabPage
        Me.gridComercial = New System.Windows.Forms.DataGridView
        Me.ucOkCancel = New WUC.ucButton
        Me.grpQualidade = New System.Windows.Forms.GroupBox
        Me.ucQualidade = New WUC.UcText
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.chkDomingo = New System.Windows.Forms.CheckBox
        Me.chkQuarta = New System.Windows.Forms.CheckBox
        Me.chkTerca = New System.Windows.Forms.CheckBox
        Me.chkSexta = New System.Windows.Forms.CheckBox
        Me.chkSabado = New System.Windows.Forms.CheckBox
        Me.chkSegunda = New System.Windows.Forms.CheckBox
        Me.chkQuinta = New System.Windows.Forms.CheckBox
        Me.chkExcluirAm = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabFiltro.SuspendLayout()
        Me.tabVeiculo.SuspendLayout()
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrograma.SuspendLayout()
        CType(Me.gridPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabComercial.SuspendLayout()
        CType(Me.gridComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQualidade.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucPeriodoCampanha)
        Me.GroupBox1.Controls.Add(Me.ucCliente)
        Me.GroupBox1.Controls.Add(Me.ucAgencia)
        Me.GroupBox1.Controls.Add(Me.ucSequencia)
        Me.GroupBox1.Controls.Add(Me.ucContrato)
        Me.GroupBox1.Controls.Add(Me.ucEmpresa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'ucPeriodoCampanha
        '
        Me.ucPeriodoCampanha.BackColor = System.Drawing.SystemColors.Control
        Me.ucPeriodoCampanha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPeriodoCampanha.Caption = "Período da Campanha"
        Me.ucPeriodoCampanha.DataTextValue = Nothing
        Me.ucPeriodoCampanha.Enabled = False
        Me.ucPeriodoCampanha.Location = New System.Drawing.Point(6, 62)
        Me.ucPeriodoCampanha.MaxLength = 3
        Me.ucPeriodoCampanha.Name = "ucPeriodoCampanha"
        Me.ucPeriodoCampanha.Obrigatorio = True
        Me.ucPeriodoCampanha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPeriodoCampanha.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucPeriodoCampanha.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucPeriodoCampanha.pDecimal = CType(0, Byte)
        Me.ucPeriodoCampanha.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucPeriodoCampanha.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPeriodoCampanha.Size = New System.Drawing.Size(208, 37)
        Me.ucPeriodoCampanha.sqlQuery = Nothing
        Me.ucPeriodoCampanha.TabIndex = 3
        Me.ucPeriodoCampanha.TextBoxLeft = CType(0, Short)
        Me.ucPeriodoCampanha.TextWidth = 0
        '
        'ucCliente
        '
        Me.ucCliente.BackColor = System.Drawing.SystemColors.Control
        Me.ucCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCliente.Caption = "Cliente"
        Me.ucCliente.DataTextValue = Nothing
        Me.ucCliente.Enabled = False
        Me.ucCliente.Location = New System.Drawing.Point(250, 62)
        Me.ucCliente.MaxLength = 32767
        Me.ucCliente.Name = "ucCliente"
        Me.ucCliente.Obrigatorio = True
        Me.ucCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCliente.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucCliente.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucCliente.pDecimal = CType(0, Byte)
        Me.ucCliente.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCliente.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCliente.Size = New System.Drawing.Size(429, 37)
        Me.ucCliente.sqlQuery = Nothing
        Me.ucCliente.TabIndex = 0
        Me.ucCliente.TextBoxLeft = CType(0, Short)
        Me.ucCliente.TextWidth = 0
        '
        'ucAgencia
        '
        Me.ucAgencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucAgencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucAgencia.Caption = "Agência"
        Me.ucAgencia.DataTextValue = Nothing
        Me.ucAgencia.Enabled = False
        Me.ucAgencia.Location = New System.Drawing.Point(250, 19)
        Me.ucAgencia.MaxLength = 32767
        Me.ucAgencia.Name = "ucAgencia"
        Me.ucAgencia.Obrigatorio = True
        Me.ucAgencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucAgencia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucAgencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucAgencia.pDecimal = CType(0, Byte)
        Me.ucAgencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucAgencia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucAgencia.Size = New System.Drawing.Size(429, 37)
        Me.ucAgencia.sqlQuery = Nothing
        Me.ucAgencia.TabIndex = 5
        Me.ucAgencia.TextBoxLeft = CType(0, Short)
        Me.ucAgencia.TextWidth = 0
        '
        'ucSequencia
        '
        Me.ucSequencia.BackColor = System.Drawing.SystemColors.Control
        Me.ucSequencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucSequencia.Caption = "Sequencia"
        Me.ucSequencia.DataTextValue = Nothing
        Me.ucSequencia.Location = New System.Drawing.Point(156, 19)
        Me.ucSequencia.MaxLength = 32767
        Me.ucSequencia.Name = "ucSequencia"
        Me.ucSequencia.Obrigatorio = True
        Me.ucSequencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucSequencia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucSequencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucSequencia.pDecimal = CType(0, Byte)
        Me.ucSequencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucSequencia.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucSequencia.Size = New System.Drawing.Size(58, 37)
        Me.ucSequencia.sqlQuery = Nothing
        Me.ucSequencia.TabIndex = 2
        Me.ucSequencia.TextBoxLeft = CType(0, Short)
        Me.ucSequencia.TextWidth = 0
        '
        'ucContrato
        '
        Me.ucContrato.BackColor = System.Drawing.SystemColors.Control
        Me.ucContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucContrato.Caption = "Contrato"
        Me.ucContrato.DataTextValue = Nothing
        Me.ucContrato.Location = New System.Drawing.Point(72, 19)
        Me.ucContrato.MaxLength = 32767
        Me.ucContrato.Name = "ucContrato"
        Me.ucContrato.Obrigatorio = True
        Me.ucContrato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucContrato.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucContrato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucContrato.pDecimal = CType(0, Byte)
        Me.ucContrato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucContrato.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucContrato.Size = New System.Drawing.Size(68, 37)
        Me.ucContrato.sqlQuery = Nothing
        Me.ucContrato.TabIndex = 1
        Me.ucContrato.TextBoxLeft = CType(0, Short)
        Me.ucContrato.TextWidth = 0
        '
        'ucEmpresa
        '
        Me.ucEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.ucEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucEmpresa.Caption = "Empresa"
        Me.ucEmpresa.DataTextValue = Nothing
        Me.ucEmpresa.Location = New System.Drawing.Point(6, 19)
        Me.ucEmpresa.MaxLength = 3
        Me.ucEmpresa.Name = "ucEmpresa"
        Me.ucEmpresa.Obrigatorio = True
        Me.ucEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucEmpresa.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucEmpresa.pDecimal = CType(0, Byte)
        Me.ucEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucEmpresa.Size = New System.Drawing.Size(60, 37)
        Me.ucEmpresa.sqlQuery = Nothing
        Me.ucEmpresa.TabIndex = 0
        Me.ucEmpresa.TextBoxLeft = CType(0, Short)
        Me.ucEmpresa.TextWidth = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optCancelamento)
        Me.GroupBox3.Controls.Add(Me.optBaixa)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(266, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operação"
        '
        'optCancelamento
        '
        Me.optCancelamento.AutoSize = True
        Me.optCancelamento.Location = New System.Drawing.Point(25, 65)
        Me.optCancelamento.Name = "optCancelamento"
        Me.optCancelamento.Size = New System.Drawing.Size(93, 17)
        Me.optCancelamento.TabIndex = 1
        Me.optCancelamento.TabStop = True
        Me.optCancelamento.Text = "Cancelamento"
        Me.optCancelamento.UseVisualStyleBackColor = True
        '
        'optBaixa
        '
        Me.optBaixa.AutoSize = True
        Me.optBaixa.Location = New System.Drawing.Point(25, 30)
        Me.optBaixa.Name = "optBaixa"
        Me.optBaixa.Size = New System.Drawing.Size(117, 17)
        Me.optBaixa.TabIndex = 0
        Me.optBaixa.TabStop = True
        Me.optBaixa.Text = "Baixa de Qualidade"
        Me.optBaixa.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMotivoBaixa)
        Me.GroupBox2.Location = New System.Drawing.Point(284, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Motivo da Baixa"
        '
        'txtMotivoBaixa
        '
        Me.txtMotivoBaixa.Location = New System.Drawing.Point(6, 19)
        Me.txtMotivoBaixa.MaxLength = 50
        Me.txtMotivoBaixa.Multiline = True
        Me.txtMotivoBaixa.Name = "txtMotivoBaixa"
        Me.txtMotivoBaixa.Size = New System.Drawing.Size(401, 70)
        Me.txtMotivoBaixa.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.ucDataAte)
        Me.GroupBox5.Controls.Add(Me.ucDataDe)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 245)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(266, 80)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Período a ser baixado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Até"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A partir de"
        '
        'ucDataAte
        '
        Me.ucDataAte.BackColor = System.Drawing.Color.Transparent
        Me.ucDataAte.DateTime = New Date(CType(0, Long))
        Me.ucDataAte.Formato = "dd/MM/yyyy ddd"
        Me.ucDataAte.Hoje = False
        Me.ucDataAte.Location = New System.Drawing.Point(72, 52)
        Me.ucDataAte.MaximumSize = New System.Drawing.Size(500, 23)
        Me.ucDataAte.MinimumSize = New System.Drawing.Size(115, 23)
        Me.ucDataAte.Name = "ucDataAte"
        Me.ucDataAte.Permite_Futuro = True
        Me.ucDataAte.Permite_Limpar = True
        Me.ucDataAte.Permite_Passado = True
        Me.ucDataAte.Preenchimento_Obrigatorio = False
        Me.ucDataAte.Size = New System.Drawing.Size(188, 23)
        Me.ucDataAte.TabIndex = 2
        '
        'ucDataDe
        '
        Me.ucDataDe.BackColor = System.Drawing.Color.Transparent
        Me.ucDataDe.DateTime = New Date(CType(0, Long))
        Me.ucDataDe.Formato = "dd/MM/yyyy ddd"
        Me.ucDataDe.Hoje = False
        Me.ucDataDe.Location = New System.Drawing.Point(72, 23)
        Me.ucDataDe.MaximumSize = New System.Drawing.Size(500, 23)
        Me.ucDataDe.MinimumSize = New System.Drawing.Size(115, 23)
        Me.ucDataDe.Name = "ucDataDe"
        Me.ucDataDe.Permite_Futuro = True
        Me.ucDataDe.Permite_Limpar = True
        Me.ucDataDe.Permite_Passado = True
        Me.ucDataDe.Preenchimento_Obrigatorio = False
        Me.ucDataDe.Size = New System.Drawing.Size(188, 23)
        Me.ucDataDe.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnDesmarcar)
        Me.GroupBox4.Controls.Add(Me.btnMarcar)
        Me.GroupBox4.Controls.Add(Me.tabFiltro)
        Me.GroupBox4.Location = New System.Drawing.Point(284, 245)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(413, 332)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtro de Veiculaçoes"
        '
        'btnDesmarcar
        '
        Me.btnDesmarcar.Location = New System.Drawing.Point(136, 299)
        Me.btnDesmarcar.Name = "btnDesmarcar"
        Me.btnDesmarcar.Size = New System.Drawing.Size(112, 23)
        Me.btnDesmarcar.TabIndex = 2
        Me.btnDesmarcar.Text = "Desmarcar Todos"
        Me.btnDesmarcar.UseVisualStyleBackColor = True
        '
        'btnMarcar
        '
        Me.btnMarcar.Location = New System.Drawing.Point(6, 299)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(112, 23)
        Me.btnMarcar.TabIndex = 1
        Me.btnMarcar.Text = "Marcar Todos"
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'tabFiltro
        '
        Me.tabFiltro.Controls.Add(Me.tabVeiculo)
        Me.tabFiltro.Controls.Add(Me.tabPrograma)
        Me.tabFiltro.Controls.Add(Me.tabComercial)
        Me.tabFiltro.Location = New System.Drawing.Point(6, 19)
        Me.tabFiltro.Name = "tabFiltro"
        Me.tabFiltro.SelectedIndex = 0
        Me.tabFiltro.Size = New System.Drawing.Size(401, 277)
        Me.tabFiltro.TabIndex = 0
        '
        'tabVeiculo
        '
        Me.tabVeiculo.Controls.Add(Me.gridVeiculo)
        Me.tabVeiculo.Location = New System.Drawing.Point(4, 22)
        Me.tabVeiculo.Name = "tabVeiculo"
        Me.tabVeiculo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVeiculo.Size = New System.Drawing.Size(393, 251)
        Me.tabVeiculo.TabIndex = 0
        Me.tabVeiculo.Text = "Veículos"
        Me.tabVeiculo.UseVisualStyleBackColor = True
        '
        'gridVeiculo
        '
        Me.gridVeiculo.BackgroundColor = System.Drawing.Color.White
        Me.gridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVeiculo.Location = New System.Drawing.Point(7, 7)
        Me.gridVeiculo.Name = "gridVeiculo"
        Me.gridVeiculo.Size = New System.Drawing.Size(380, 236)
        Me.gridVeiculo.TabIndex = 0
        '
        'tabPrograma
        '
        Me.tabPrograma.Controls.Add(Me.gridPrograma)
        Me.tabPrograma.Location = New System.Drawing.Point(4, 22)
        Me.tabPrograma.Name = "tabPrograma"
        Me.tabPrograma.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrograma.Size = New System.Drawing.Size(393, 251)
        Me.tabPrograma.TabIndex = 1
        Me.tabPrograma.Text = "Programas"
        Me.tabPrograma.UseVisualStyleBackColor = True
        '
        'gridPrograma
        '
        Me.gridPrograma.BackgroundColor = System.Drawing.Color.White
        Me.gridPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPrograma.Location = New System.Drawing.Point(7, 7)
        Me.gridPrograma.Name = "gridPrograma"
        Me.gridPrograma.Size = New System.Drawing.Size(390, 236)
        Me.gridPrograma.TabIndex = 1
        '
        'tabComercial
        '
        Me.tabComercial.Controls.Add(Me.gridComercial)
        Me.tabComercial.Location = New System.Drawing.Point(4, 22)
        Me.tabComercial.Name = "tabComercial"
        Me.tabComercial.Size = New System.Drawing.Size(393, 251)
        Me.tabComercial.TabIndex = 2
        Me.tabComercial.Text = "Comerciais"
        Me.tabComercial.UseVisualStyleBackColor = True
        '
        'gridComercial
        '
        Me.gridComercial.BackgroundColor = System.Drawing.Color.White
        Me.gridComercial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridComercial.Location = New System.Drawing.Point(7, 7)
        Me.gridComercial.Name = "gridComercial"
        Me.gridComercial.Size = New System.Drawing.Size(390, 236)
        Me.gridComercial.TabIndex = 1
        '
        'ucOkCancel
        '
        Me.ucOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ucOkCancel.Location = New System.Drawing.Point(12, 535)
        Me.ucOkCancel.Name = "ucOkCancel"
        Me.ucOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.ucOkCancel.TabIndex = 12
        '
        'grpQualidade
        '
        Me.grpQualidade.Controls.Add(Me.ucQualidade)
        Me.grpQualidade.Location = New System.Drawing.Point(12, 431)
        Me.grpQualidade.Name = "grpQualidade"
        Me.grpQualidade.Size = New System.Drawing.Size(266, 58)
        Me.grpQualidade.TabIndex = 4
        Me.grpQualidade.TabStop = False
        Me.grpQualidade.Text = "Qualidade"
        '
        'ucQualidade
        '
        Me.ucQualidade.BackColor = System.Drawing.SystemColors.Control
        Me.ucQualidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucQualidade.Caption = "Qualidade"
        Me.ucQualidade.DataTextValue = Nothing
        Me.ucQualidade.Location = New System.Drawing.Point(6, 19)
        Me.ucQualidade.MaxLength = 3
        Me.ucQualidade.Name = "ucQualidade"
        Me.ucQualidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucQualidade.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucQualidade.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucQualidade.pDecimal = CType(0, Byte)
        Me.ucQualidade.pDicionario = WUC.clsDicionario.enuDicionario.Qualidade
        Me.ucQualidade.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucQualidade.showButton = True
        Me.ucQualidade.ShowDescricao = True
        Me.ucQualidade.Size = New System.Drawing.Size(254, 25)
        Me.ucQualidade.sqlQuery = "execute PrNet_Qualidade_L"
        Me.ucQualidade.TabIndex = 0
        Me.ucQualidade.TextBoxLeft = CType(0, Short)
        Me.ucQualidade.TextWidth = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkTodos)
        Me.GroupBox7.Controls.Add(Me.chkDomingo)
        Me.GroupBox7.Controls.Add(Me.chkQuarta)
        Me.GroupBox7.Controls.Add(Me.chkTerca)
        Me.GroupBox7.Controls.Add(Me.chkSexta)
        Me.GroupBox7.Controls.Add(Me.chkSabado)
        Me.GroupBox7.Controls.Add(Me.chkSegunda)
        Me.GroupBox7.Controls.Add(Me.chkQuinta)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 331)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(266, 94)
        Me.GroupBox7.TabIndex = 15
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Dias da Semana "
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(164, 69)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 7
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = True
        Me.chkDomingo.Location = New System.Drawing.Point(15, 23)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(68, 17)
        Me.chkDomingo.TabIndex = 0
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = True
        '
        'chkQuarta
        '
        Me.chkQuarta.AutoSize = True
        Me.chkQuarta.Location = New System.Drawing.Point(15, 46)
        Me.chkQuarta.Name = "chkQuarta"
        Me.chkQuarta.Size = New System.Drawing.Size(58, 17)
        Me.chkQuarta.TabIndex = 3
        Me.chkQuarta.Text = "Quarta"
        Me.chkQuarta.UseVisualStyleBackColor = True
        '
        'chkTerca
        '
        Me.chkTerca.AutoSize = True
        Me.chkTerca.Location = New System.Drawing.Point(164, 23)
        Me.chkTerca.Name = "chkTerca"
        Me.chkTerca.Size = New System.Drawing.Size(54, 17)
        Me.chkTerca.TabIndex = 2
        Me.chkTerca.Text = "Terça"
        Me.chkTerca.UseVisualStyleBackColor = True
        '
        'chkSexta
        '
        Me.chkSexta.AutoSize = True
        Me.chkSexta.Location = New System.Drawing.Point(164, 46)
        Me.chkSexta.Name = "chkSexta"
        Me.chkSexta.Size = New System.Drawing.Size(53, 17)
        Me.chkSexta.TabIndex = 5
        Me.chkSexta.Text = "Sexta"
        Me.chkSexta.UseVisualStyleBackColor = True
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = True
        Me.chkSabado.Location = New System.Drawing.Point(15, 69)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 17)
        Me.chkSabado.TabIndex = 6
        Me.chkSabado.Text = "Sabado"
        Me.chkSabado.UseVisualStyleBackColor = True
        '
        'chkSegunda
        '
        Me.chkSegunda.AutoSize = True
        Me.chkSegunda.Location = New System.Drawing.Point(89, 23)
        Me.chkSegunda.Name = "chkSegunda"
        Me.chkSegunda.Size = New System.Drawing.Size(69, 17)
        Me.chkSegunda.TabIndex = 1
        Me.chkSegunda.Text = "Segunda"
        Me.chkSegunda.UseVisualStyleBackColor = True
        '
        'chkQuinta
        '
        Me.chkQuinta.AutoSize = True
        Me.chkQuinta.Location = New System.Drawing.Point(89, 46)
        Me.chkQuinta.Name = "chkQuinta"
        Me.chkQuinta.Size = New System.Drawing.Size(57, 17)
        Me.chkQuinta.TabIndex = 4
        Me.chkQuinta.Text = "Quinta"
        Me.chkQuinta.UseVisualStyleBackColor = True
        '
        'chkExcluirAm
        '
        Me.chkExcluirAm.Location = New System.Drawing.Point(12, 495)
        Me.chkExcluirAm.Name = "chkExcluirAm"
        Me.chkExcluirAm.Size = New System.Drawing.Size(220, 34)
        Me.chkExcluirAm.TabIndex = 16
        Me.chkExcluirAm.Text = "Excluir Automáticamente Am´s em Aberto para o Contrato"
        Me.chkExcluirAm.UseVisualStyleBackColor = True
        '
        'frmBaixaContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 602)
        Me.Controls.Add(Me.chkExcluirAm)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.grpQualidade)
        Me.Controls.Add(Me.ucOkCancel)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBaixaContrato"
        Me.Text = "Baixa por Contrato"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.tabFiltro.ResumeLayout(False)
        Me.tabVeiculo.ResumeLayout(False)
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrograma.ResumeLayout(False)
        CType(Me.gridPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabComercial.ResumeLayout(False)
        CType(Me.gridComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQualidade.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ucSequencia As WUC.UcText
    Friend WithEvents ucContrato As WUC.UcText
    Friend WithEvents ucEmpresa As WUC.UcText
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ucPeriodoCampanha As WUC.UcText
    Friend WithEvents ucCliente As WUC.UcText
    Friend WithEvents ucAgencia As WUC.UcText
    Friend WithEvents optCancelamento As System.Windows.Forms.RadioButton
    Friend WithEvents optBaixa As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMotivoBaixa As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ucDataAte As WCL_SCTV.UC.UCData
    Friend WithEvents ucDataDe As WCL_SCTV.UC.UCData
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tabFiltro As System.Windows.Forms.TabControl
    Friend WithEvents tabVeiculo As System.Windows.Forms.TabPage
    Friend WithEvents tabPrograma As System.Windows.Forms.TabPage
    Friend WithEvents tabComercial As System.Windows.Forms.TabPage
    Friend WithEvents btnDesmarcar As System.Windows.Forms.Button
    Friend WithEvents btnMarcar As System.Windows.Forms.Button
    Friend WithEvents gridVeiculo As System.Windows.Forms.DataGridView
    Friend WithEvents gridPrograma As System.Windows.Forms.DataGridView
    Friend WithEvents gridComercial As System.Windows.Forms.DataGridView
    Friend WithEvents ucOkCancel As WUC.ucButton
    Friend WithEvents grpQualidade As System.Windows.Forms.GroupBox
    Friend WithEvents ucQualidade As WUC.UcText
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuarta As System.Windows.Forms.CheckBox
    Friend WithEvents chkTerca As System.Windows.Forms.CheckBox
    Friend WithEvents chkSexta As System.Windows.Forms.CheckBox
    Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
    Friend WithEvents chkSegunda As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuinta As System.Windows.Forms.CheckBox
    Friend WithEvents chkExcluirAm As System.Windows.Forms.CheckBox
End Class
