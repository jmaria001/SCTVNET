<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerceiro_Cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTerceiro_Cadastro))
        Me.tabControl = New System.Windows.Forms.TabControl
        Me.tabEndereco = New System.Windows.Forms.TabPage
        Me.txtPracaPagto = New WUC.UcText
        Me.txtEmail = New WUC.UcText
        Me.txtFax = New WUC.UcText
        Me.txtTelefone = New WUC.UcText
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtCep_2 = New WUC.UcText
        Me.txtUf_2 = New WUC.UcText
        Me.txtMunicipio_2 = New WUC.UcText
        Me.txtBairro_2 = New WUC.UcText
        Me.txtComplemento_2 = New WUC.UcText
        Me.txtNumero_2 = New WUC.UcText
        Me.txtEndereco_2 = New WUC.UcText
        Me.fraEndereco = New System.Windows.Forms.GroupBox
        Me.txtCep_1 = New WUC.UcText
        Me.txtUf_1 = New WUC.UcText
        Me.txtMunicipio_1 = New WUC.UcText
        Me.txtBairro_1 = New WUC.UcText
        Me.txtComplemento_1 = New WUC.UcText
        Me.txtNumero_1 = New WUC.UcText
        Me.txtEndereco_1 = New WUC.UcText
        Me.tabComplementar = New System.Windows.Forms.TabPage
        Me.chkIn480 = New System.Windows.Forms.CheckBox
        Me.chkMerchandising = New System.Windows.Forms.CheckBox
        Me.fraDadosBancario = New System.Windows.Forms.GroupBox
        Me.txtRepresentante = New WUC.UcText
        Me.txtGrupoCLiente = New WUC.UcText
        Me.txtBancoPreferencial = New WUC.UcText
        Me.fraContato2 = New System.Windows.Forms.GroupBox
        Me.txtTelefone4 = New WUC.UcText
        Me.txtEmail2 = New WUC.UcText
        Me.txtTelefone3 = New WUC.UcText
        Me.txtContato2 = New WUC.UcText
        Me.fraContato1 = New System.Windows.Forms.GroupBox
        Me.txtTelefone2 = New WUC.UcText
        Me.txtEmail1 = New WUC.UcText
        Me.txtTelefone1 = New WUC.UcText
        Me.txtNomeContato = New WUC.UcText
        Me.txtLimiteCredito = New WUC.UcText
        Me.txtSubConta = New WUC.UcText
        Me.txtSubContaCSC = New WUC.UcText
        Me.fraDados = New System.Windows.Forms.GroupBox
        Me.txtEmpresa = New WUC.UcText
        Me.txtRamoAtividade = New WUC.UcText
        Me.txtNomeFantasia = New WUC.UcText
        Me.txtIM = New WUC.UcText
        Me.txtIE = New WUC.UcText
        Me.txtFuncao = New WUC.UcText
        Me.cboCNPF = New System.Windows.Forms.ComboBox
        Me.txtCNPF = New WUC.UcText
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkClienteDireto = New System.Windows.Forms.CheckBox
        Me.chkEstrangeiro = New System.Windows.Forms.CheckBox
        Me.chkAfiliada = New System.Windows.Forms.CheckBox
        Me.chkRegional = New System.Windows.Forms.CheckBox
        Me.chkEmissora = New System.Windows.Forms.CheckBox
        Me.fraPorte = New System.Windows.Forms.GroupBox
        Me.optPequeno = New System.Windows.Forms.RadioButton
        Me.optMédio = New System.Windows.Forms.RadioButton
        Me.optGrande = New System.Windows.Forms.RadioButton
        Me.txtRazaoSocial = New WUC.UcText
        Me.txtCodTerceiro = New WUC.UcText
        Me.errTerceiro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BdNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton
        Me.lblCod_Empresa = New System.Windows.Forms.ToolStripLabel
        Me.lblRazao_Social = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton
        Me.btnDesativar = New System.Windows.Forms.ToolStripButton
        Me.lblStatus = New System.Windows.Forms.ToolStripLabel
        Me.bdSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnTerceiro = New WUC.ucButton
        Me.tabControl.SuspendLayout()
        Me.tabEndereco.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.fraEndereco.SuspendLayout()
        Me.tabComplementar.SuspendLayout()
        Me.fraDadosBancario.SuspendLayout()
        Me.fraContato2.SuspendLayout()
        Me.fraContato1.SuspendLayout()
        Me.fraDados.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.fraPorte.SuspendLayout()
        CType(Me.errTerceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BdNavigator.SuspendLayout()
        CType(Me.bdSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.Controls.Add(Me.tabEndereco)
        Me.tabControl.Controls.Add(Me.tabComplementar)
        Me.tabControl.Location = New System.Drawing.Point(11, 216)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(852, 312)
        Me.tabControl.TabIndex = 0
        Me.tabControl.TabStop = False
        '
        'tabEndereco
        '
        Me.tabEndereco.Controls.Add(Me.txtPracaPagto)
        Me.tabEndereco.Controls.Add(Me.txtEmail)
        Me.tabEndereco.Controls.Add(Me.txtFax)
        Me.tabEndereco.Controls.Add(Me.txtTelefone)
        Me.tabEndereco.Controls.Add(Me.GroupBox4)
        Me.tabEndereco.Controls.Add(Me.fraEndereco)
        Me.tabEndereco.Location = New System.Drawing.Point(4, 22)
        Me.tabEndereco.Name = "tabEndereco"
        Me.tabEndereco.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEndereco.Size = New System.Drawing.Size(844, 286)
        Me.tabEndereco.TabIndex = 0
        Me.tabEndereco.Text = "Endereço"
        Me.tabEndereco.UseVisualStyleBackColor = True
        '
        'txtPracaPagto
        '
        Me.txtPracaPagto.BackColor = System.Drawing.Color.Transparent
        Me.txtPracaPagto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtPracaPagto.Caption = "Praca de Pagamento"
        Me.txtPracaPagto.DataTextValue = Nothing
        Me.txtPracaPagto.Location = New System.Drawing.Point(612, 237)
        Me.txtPracaPagto.MaxLength = 30
        Me.txtPracaPagto.Name = "txtPracaPagto"
        Me.txtPracaPagto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPracaPagto.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtPracaPagto.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtPracaPagto.pDecimal = CType(0, Byte)
        Me.txtPracaPagto.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtPracaPagto.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtPracaPagto.Size = New System.Drawing.Size(216, 37)
        Me.txtPracaPagto.sqlQuery = Nothing
        Me.txtPracaPagto.TabIndex = 5
        Me.txtPracaPagto.TextBoxLeft = CType(0, Short)
        Me.txtPracaPagto.TextWidth = 0
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmail.Caption = "Email"
        Me.txtEmail.DataTextValue = Nothing
        Me.txtEmail.Location = New System.Drawing.Point(318, 237)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmail.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtEmail.pDecimal = CType(0, Byte)
        Me.txtEmail.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtEmail.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmail.Size = New System.Drawing.Size(281, 37)
        Me.txtEmail.sqlQuery = Nothing
        Me.txtEmail.TabIndex = 4
        Me.txtEmail.TextBoxLeft = CType(0, Short)
        Me.txtEmail.TextWidth = 0
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.Transparent
        Me.txtFax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtFax.Caption = "Fax"
        Me.txtFax.DataTextValue = Nothing
        Me.txtFax.Location = New System.Drawing.Point(162, 237)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Name = "txtFax"
        Me.txtFax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFax.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtFax.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtFax.pDecimal = CType(0, Byte)
        Me.txtFax.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtFax.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtFax.Size = New System.Drawing.Size(143, 37)
        Me.txtFax.sqlQuery = Nothing
        Me.txtFax.TabIndex = 3
        Me.txtFax.TextBoxLeft = CType(0, Short)
        Me.txtFax.TextWidth = 0
        '
        'txtTelefone
        '
        Me.txtTelefone.BackColor = System.Drawing.Color.Transparent
        Me.txtTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTelefone.Caption = "Telefone"
        Me.txtTelefone.DataTextValue = Nothing
        Me.txtTelefone.Location = New System.Drawing.Point(12, 237)
        Me.txtTelefone.MaxLength = 20
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefone.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTelefone.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtTelefone.pDecimal = CType(0, Byte)
        Me.txtTelefone.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtTelefone.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTelefone.Size = New System.Drawing.Size(137, 37)
        Me.txtTelefone.sqlQuery = Nothing
        Me.txtTelefone.TabIndex = 2
        Me.txtTelefone.TextBoxLeft = CType(0, Short)
        Me.txtTelefone.TextWidth = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.txtCep_2)
        Me.GroupBox4.Controls.Add(Me.txtUf_2)
        Me.GroupBox4.Controls.Add(Me.txtMunicipio_2)
        Me.GroupBox4.Controls.Add(Me.txtBairro_2)
        Me.GroupBox4.Controls.Add(Me.txtComplemento_2)
        Me.GroupBox4.Controls.Add(Me.txtNumero_2)
        Me.GroupBox4.Controls.Add(Me.txtEndereco_2)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 124)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(832, 107)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'txtCep_2
        '
        Me.txtCep_2.BackColor = System.Drawing.Color.Transparent
        Me.txtCep_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCep_2.Caption = "Cep"
        Me.txtCep_2.DataTextValue = Nothing
        Me.txtCep_2.Location = New System.Drawing.Point(707, 62)
        Me.txtCep_2.MaxLength = 9
        Me.txtCep_2.Name = "txtCep_2"
        Me.txtCep_2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCep_2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCep_2.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtCep_2.pDecimal = CType(0, Byte)
        Me.txtCep_2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtCep_2.pFormatoSaida = WUC.UcText.FormatoSaida.CEP
        Me.txtCep_2.Size = New System.Drawing.Size(115, 37)
        Me.txtCep_2.sqlQuery = Nothing
        Me.txtCep_2.TabIndex = 7
        Me.txtCep_2.TextBoxLeft = CType(0, Short)
        Me.txtCep_2.TextWidth = 0
        '
        'txtUf_2
        '
        Me.txtUf_2.BackColor = System.Drawing.Color.Transparent
        Me.txtUf_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtUf_2.Caption = "UF"
        Me.txtUf_2.DataTextValue = Nothing
        Me.txtUf_2.Location = New System.Drawing.Point(622, 62)
        Me.txtUf_2.MaxLength = 2
        Me.txtUf_2.Name = "txtUf_2"
        Me.txtUf_2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUf_2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtUf_2.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtUf_2.pDecimal = CType(0, Byte)
        Me.txtUf_2.pDicionario = WUC.clsDicionario.enuDicionario.UF_Codigo
        Me.txtUf_2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtUf_2.showButton = True
        Me.txtUf_2.Size = New System.Drawing.Size(77, 37)
        Me.txtUf_2.sqlQuery = "Execute  PrNet_UF_L"
        Me.txtUf_2.TabIndex = 5
        Me.txtUf_2.TextBoxLeft = CType(0, Short)
        Me.txtUf_2.TextWidth = 0
        '
        'txtMunicipio_2
        '
        Me.txtMunicipio_2.BackColor = System.Drawing.Color.Transparent
        Me.txtMunicipio_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtMunicipio_2.Caption = "Municipio"
        Me.txtMunicipio_2.DataTextValue = Nothing
        Me.txtMunicipio_2.Location = New System.Drawing.Point(295, 62)
        Me.txtMunicipio_2.MaxLength = 30
        Me.txtMunicipio_2.Name = "txtMunicipio_2"
        Me.txtMunicipio_2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMunicipio_2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtMunicipio_2.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtMunicipio_2.pDecimal = CType(0, Byte)
        Me.txtMunicipio_2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtMunicipio_2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtMunicipio_2.Size = New System.Drawing.Size(321, 37)
        Me.txtMunicipio_2.sqlQuery = Nothing
        Me.txtMunicipio_2.TabIndex = 4
        Me.txtMunicipio_2.TextBoxLeft = CType(0, Short)
        Me.txtMunicipio_2.TextWidth = 0
        '
        'txtBairro_2
        '
        Me.txtBairro_2.BackColor = System.Drawing.Color.Transparent
        Me.txtBairro_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtBairro_2.Caption = "Bairro"
        Me.txtBairro_2.DataTextValue = Nothing
        Me.txtBairro_2.Location = New System.Drawing.Point(6, 62)
        Me.txtBairro_2.MaxLength = 30
        Me.txtBairro_2.Name = "txtBairro_2"
        Me.txtBairro_2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBairro_2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtBairro_2.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtBairro_2.pDecimal = CType(0, Byte)
        Me.txtBairro_2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtBairro_2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtBairro_2.Size = New System.Drawing.Size(280, 37)
        Me.txtBairro_2.sqlQuery = Nothing
        Me.txtBairro_2.TabIndex = 3
        Me.txtBairro_2.TextBoxLeft = CType(0, Short)
        Me.txtBairro_2.TextWidth = 0
        '
        'txtComplemento_2
        '
        Me.txtComplemento_2.BackColor = System.Drawing.Color.Transparent
        Me.txtComplemento_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtComplemento_2.Caption = "Complemento"
        Me.txtComplemento_2.DataTextValue = Nothing
        Me.txtComplemento_2.Location = New System.Drawing.Point(491, 19)
        Me.txtComplemento_2.MaxLength = 30
        Me.txtComplemento_2.Name = "txtComplemento_2"
        Me.txtComplemento_2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComplemento_2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtComplemento_2.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtComplemento_2.pDecimal = CType(0, Byte)
        Me.txtComplemento_2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtComplemento_2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtComplemento_2.Size = New System.Drawing.Size(332, 37)
        Me.txtComplemento_2.sqlQuery = Nothing
        Me.txtComplemento_2.TabIndex = 2
        Me.txtComplemento_2.TextBoxLeft = CType(0, Short)
        Me.txtComplemento_2.TextWidth = 0
        '
        'txtNumero_2
        '
        Me.txtNumero_2.BackColor = System.Drawing.Color.Transparent
        Me.txtNumero_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNumero_2.Caption = "Numero"
        Me.txtNumero_2.DataTextValue = Nothing
        Me.txtNumero_2.Location = New System.Drawing.Point(433, 19)
        Me.txtNumero_2.MaxLength = 6
        Me.txtNumero_2.Name = "txtNumero_2"
        Me.txtNumero_2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero_2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNumero_2.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtNumero_2.pDecimal = CType(0, Byte)
        Me.txtNumero_2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNumero_2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNumero_2.Size = New System.Drawing.Size(47, 37)
        Me.txtNumero_2.sqlQuery = Nothing
        Me.txtNumero_2.TabIndex = 1
        Me.txtNumero_2.TextBoxLeft = CType(0, Short)
        Me.txtNumero_2.TextWidth = 0
        '
        'txtEndereco_2
        '
        Me.txtEndereco_2.BackColor = System.Drawing.Color.Transparent
        Me.txtEndereco_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEndereco_2.Caption = "Endereço Complementar"
        Me.txtEndereco_2.DataTextValue = Nothing
        Me.txtEndereco_2.Location = New System.Drawing.Point(6, 19)
        Me.txtEndereco_2.MaxLength = 40
        Me.txtEndereco_2.Name = "txtEndereco_2"
        Me.txtEndereco_2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEndereco_2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEndereco_2.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEndereco_2.pDecimal = CType(0, Byte)
        Me.txtEndereco_2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtEndereco_2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEndereco_2.Size = New System.Drawing.Size(421, 37)
        Me.txtEndereco_2.sqlQuery = Nothing
        Me.txtEndereco_2.TabIndex = 0
        Me.txtEndereco_2.TextBoxLeft = CType(0, Short)
        Me.txtEndereco_2.TextWidth = 0
        '
        'fraEndereco
        '
        Me.fraEndereco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fraEndereco.Controls.Add(Me.txtCep_1)
        Me.fraEndereco.Controls.Add(Me.txtUf_1)
        Me.fraEndereco.Controls.Add(Me.txtMunicipio_1)
        Me.fraEndereco.Controls.Add(Me.txtBairro_1)
        Me.fraEndereco.Controls.Add(Me.txtComplemento_1)
        Me.fraEndereco.Controls.Add(Me.txtNumero_1)
        Me.fraEndereco.Controls.Add(Me.txtEndereco_1)
        Me.fraEndereco.Location = New System.Drawing.Point(6, 6)
        Me.fraEndereco.Name = "fraEndereco"
        Me.fraEndereco.Size = New System.Drawing.Size(832, 112)
        Me.fraEndereco.TabIndex = 0
        Me.fraEndereco.TabStop = False
        '
        'txtCep_1
        '
        Me.txtCep_1.BackColor = System.Drawing.Color.Transparent
        Me.txtCep_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCep_1.Caption = "Cep"
        Me.txtCep_1.DataTextValue = Nothing
        Me.txtCep_1.Location = New System.Drawing.Point(707, 62)
        Me.txtCep_1.MaxLength = 9
        Me.txtCep_1.Name = "txtCep_1"
        Me.txtCep_1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCep_1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCep_1.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtCep_1.pDecimal = CType(0, Byte)
        Me.txtCep_1.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtCep_1.pFormatoSaida = WUC.UcText.FormatoSaida.CEP
        Me.txtCep_1.Size = New System.Drawing.Size(115, 37)
        Me.txtCep_1.sqlQuery = Nothing
        Me.txtCep_1.TabIndex = 6
        Me.txtCep_1.TextBoxLeft = CType(0, Short)
        Me.txtCep_1.TextWidth = 0
        '
        'txtUf_1
        '
        Me.txtUf_1.BackColor = System.Drawing.Color.Transparent
        Me.txtUf_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtUf_1.Caption = "UF"
        Me.txtUf_1.DataTextValue = Nothing
        Me.txtUf_1.Location = New System.Drawing.Point(622, 62)
        Me.txtUf_1.MaxLength = 2
        Me.txtUf_1.Name = "txtUf_1"
        Me.txtUf_1.Obrigatorio = True
        Me.txtUf_1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUf_1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtUf_1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtUf_1.pDecimal = CType(0, Byte)
        Me.txtUf_1.pDicionario = WUC.clsDicionario.enuDicionario.UF_Codigo
        Me.txtUf_1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtUf_1.showButton = True
        Me.txtUf_1.Size = New System.Drawing.Size(76, 37)
        Me.txtUf_1.sqlQuery = "Execute  PrNet_UF_L"
        Me.txtUf_1.TabIndex = 5
        Me.txtUf_1.TextBoxLeft = CType(0, Short)
        Me.txtUf_1.TextWidth = 0
        '
        'txtMunicipio_1
        '
        Me.txtMunicipio_1.BackColor = System.Drawing.Color.Transparent
        Me.txtMunicipio_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtMunicipio_1.Caption = "Municipio"
        Me.txtMunicipio_1.DataTextValue = Nothing
        Me.txtMunicipio_1.Location = New System.Drawing.Point(295, 62)
        Me.txtMunicipio_1.MaxLength = 30
        Me.txtMunicipio_1.Name = "txtMunicipio_1"
        Me.txtMunicipio_1.Obrigatorio = True
        Me.txtMunicipio_1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMunicipio_1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtMunicipio_1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtMunicipio_1.pDecimal = CType(0, Byte)
        Me.txtMunicipio_1.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtMunicipio_1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtMunicipio_1.Size = New System.Drawing.Size(321, 37)
        Me.txtMunicipio_1.sqlQuery = Nothing
        Me.txtMunicipio_1.TabIndex = 4
        Me.txtMunicipio_1.TextBoxLeft = CType(0, Short)
        Me.txtMunicipio_1.TextWidth = 0
        '
        'txtBairro_1
        '
        Me.txtBairro_1.BackColor = System.Drawing.Color.Transparent
        Me.txtBairro_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtBairro_1.Caption = "Bairro"
        Me.txtBairro_1.DataTextValue = Nothing
        Me.txtBairro_1.Location = New System.Drawing.Point(6, 62)
        Me.txtBairro_1.MaxLength = 30
        Me.txtBairro_1.Name = "txtBairro_1"
        Me.txtBairro_1.Obrigatorio = True
        Me.txtBairro_1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBairro_1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtBairro_1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtBairro_1.pDecimal = CType(0, Byte)
        Me.txtBairro_1.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtBairro_1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtBairro_1.Size = New System.Drawing.Size(280, 37)
        Me.txtBairro_1.sqlQuery = Nothing
        Me.txtBairro_1.TabIndex = 3
        Me.txtBairro_1.TextBoxLeft = CType(0, Short)
        Me.txtBairro_1.TextWidth = 0
        '
        'txtComplemento_1
        '
        Me.txtComplemento_1.BackColor = System.Drawing.Color.Transparent
        Me.txtComplemento_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtComplemento_1.Caption = "Complemento"
        Me.txtComplemento_1.DataTextValue = Nothing
        Me.txtComplemento_1.Location = New System.Drawing.Point(491, 19)
        Me.txtComplemento_1.MaxLength = 30
        Me.txtComplemento_1.Name = "txtComplemento_1"
        Me.txtComplemento_1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComplemento_1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtComplemento_1.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtComplemento_1.pDecimal = CType(0, Byte)
        Me.txtComplemento_1.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtComplemento_1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtComplemento_1.Size = New System.Drawing.Size(332, 37)
        Me.txtComplemento_1.sqlQuery = Nothing
        Me.txtComplemento_1.TabIndex = 2
        Me.txtComplemento_1.TextBoxLeft = CType(0, Short)
        Me.txtComplemento_1.TextWidth = 0
        '
        'txtNumero_1
        '
        Me.txtNumero_1.BackColor = System.Drawing.Color.Transparent
        Me.txtNumero_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNumero_1.Caption = "Numero"
        Me.txtNumero_1.DataTextValue = Nothing
        Me.txtNumero_1.Location = New System.Drawing.Point(433, 19)
        Me.txtNumero_1.MaxLength = 6
        Me.txtNumero_1.Name = "txtNumero_1"
        Me.txtNumero_1.Obrigatorio = True
        Me.txtNumero_1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero_1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNumero_1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtNumero_1.pDecimal = CType(0, Byte)
        Me.txtNumero_1.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNumero_1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNumero_1.Size = New System.Drawing.Size(47, 37)
        Me.txtNumero_1.sqlQuery = Nothing
        Me.txtNumero_1.TabIndex = 1
        Me.txtNumero_1.TextBoxLeft = CType(0, Short)
        Me.txtNumero_1.TextWidth = 0
        '
        'txtEndereco_1
        '
        Me.txtEndereco_1.BackColor = System.Drawing.Color.Transparent
        Me.txtEndereco_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEndereco_1.Caption = "Endereco Principal"
        Me.txtEndereco_1.DataTextValue = Nothing
        Me.txtEndereco_1.Location = New System.Drawing.Point(6, 19)
        Me.txtEndereco_1.MaxLength = 40
        Me.txtEndereco_1.Name = "txtEndereco_1"
        Me.txtEndereco_1.Obrigatorio = True
        Me.txtEndereco_1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEndereco_1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEndereco_1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEndereco_1.pDecimal = CType(0, Byte)
        Me.txtEndereco_1.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtEndereco_1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEndereco_1.Size = New System.Drawing.Size(421, 37)
        Me.txtEndereco_1.sqlQuery = Nothing
        Me.txtEndereco_1.TabIndex = 0
        Me.txtEndereco_1.TextBoxLeft = CType(0, Short)
        Me.txtEndereco_1.TextWidth = 0
        '
        'tabComplementar
        '
        Me.tabComplementar.Controls.Add(Me.chkIn480)
        Me.tabComplementar.Controls.Add(Me.chkMerchandising)
        Me.tabComplementar.Controls.Add(Me.fraDadosBancario)
        Me.tabComplementar.Controls.Add(Me.fraContato2)
        Me.tabComplementar.Controls.Add(Me.fraContato1)
        Me.tabComplementar.Controls.Add(Me.txtLimiteCredito)
        Me.tabComplementar.Controls.Add(Me.txtSubConta)
        Me.tabComplementar.Controls.Add(Me.txtSubContaCSC)
        Me.tabComplementar.Location = New System.Drawing.Point(4, 22)
        Me.tabComplementar.Name = "tabComplementar"
        Me.tabComplementar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabComplementar.Size = New System.Drawing.Size(844, 286)
        Me.tabComplementar.TabIndex = 1
        Me.tabComplementar.Text = "Dados Complementares"
        Me.tabComplementar.UseVisualStyleBackColor = True
        '
        'chkIn480
        '
        Me.chkIn480.AutoSize = True
        Me.chkIn480.Location = New System.Drawing.Point(596, 263)
        Me.chkIn480.Name = "chkIn480"
        Me.chkIn480.Size = New System.Drawing.Size(231, 17)
        Me.chkIn480.TabIndex = 7
        Me.chkIn480.Text = "Nota Fiscal - Ativar Instrução Nomativa 480"
        Me.chkIn480.UseVisualStyleBackColor = True
        '
        'chkMerchandising
        '
        Me.chkMerchandising.AutoSize = True
        Me.chkMerchandising.Location = New System.Drawing.Point(596, 240)
        Me.chkMerchandising.Name = "chkMerchandising"
        Me.chkMerchandising.Size = New System.Drawing.Size(166, 17)
        Me.chkMerchandising.TabIndex = 6
        Me.chkMerchandising.Text = "Veicular apenas Merchansing"
        Me.chkMerchandising.UseVisualStyleBackColor = True
        '
        'fraDadosBancario
        '
        Me.fraDadosBancario.Controls.Add(Me.txtRepresentante)
        Me.fraDadosBancario.Controls.Add(Me.txtGrupoCLiente)
        Me.fraDadosBancario.Controls.Add(Me.txtBancoPreferencial)
        Me.fraDadosBancario.Location = New System.Drawing.Point(596, 9)
        Me.fraDadosBancario.Name = "fraDadosBancario"
        Me.fraDadosBancario.Size = New System.Drawing.Size(196, 217)
        Me.fraDadosBancario.TabIndex = 5
        Me.fraDadosBancario.TabStop = False
        Me.fraDadosBancario.Text = "Dados Bancários"
        '
        'txtRepresentante
        '
        Me.txtRepresentante.BackColor = System.Drawing.Color.Transparent
        Me.txtRepresentante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtRepresentante.Caption = "Representante"
        Me.txtRepresentante.DataTextValue = Nothing
        Me.txtRepresentante.Location = New System.Drawing.Point(14, 109)
        Me.txtRepresentante.MaxLength = 4
        Me.txtRepresentante.Name = "txtRepresentante"
        Me.txtRepresentante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRepresentante.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtRepresentante.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtRepresentante.pDecimal = CType(0, Byte)
        Me.txtRepresentante.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtRepresentante.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtRepresentante.Size = New System.Drawing.Size(152, 37)
        Me.txtRepresentante.sqlQuery = Nothing
        Me.txtRepresentante.TabIndex = 2
        Me.txtRepresentante.TextBoxLeft = CType(0, Short)
        Me.txtRepresentante.TextWidth = 0
        '
        'txtGrupoCLiente
        '
        Me.txtGrupoCLiente.BackColor = System.Drawing.Color.Transparent
        Me.txtGrupoCLiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtGrupoCLiente.Caption = "Grupo Cliente"
        Me.txtGrupoCLiente.DataTextValue = Nothing
        Me.txtGrupoCLiente.Location = New System.Drawing.Point(14, 64)
        Me.txtGrupoCLiente.MaxLength = 4
        Me.txtGrupoCLiente.Name = "txtGrupoCLiente"
        Me.txtGrupoCLiente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGrupoCLiente.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtGrupoCLiente.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtGrupoCLiente.pDecimal = CType(0, Byte)
        Me.txtGrupoCLiente.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtGrupoCLiente.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtGrupoCLiente.Size = New System.Drawing.Size(152, 37)
        Me.txtGrupoCLiente.sqlQuery = Nothing
        Me.txtGrupoCLiente.TabIndex = 1
        Me.txtGrupoCLiente.TextBoxLeft = CType(0, Short)
        Me.txtGrupoCLiente.TextWidth = 0
        '
        'txtBancoPreferencial
        '
        Me.txtBancoPreferencial.BackColor = System.Drawing.Color.Transparent
        Me.txtBancoPreferencial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtBancoPreferencial.Caption = "Banco Preferencial"
        Me.txtBancoPreferencial.DataTextValue = Nothing
        Me.txtBancoPreferencial.Location = New System.Drawing.Point(14, 19)
        Me.txtBancoPreferencial.MaxLength = 20
        Me.txtBancoPreferencial.Name = "txtBancoPreferencial"
        Me.txtBancoPreferencial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBancoPreferencial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtBancoPreferencial.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtBancoPreferencial.pDecimal = CType(0, Byte)
        Me.txtBancoPreferencial.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtBancoPreferencial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtBancoPreferencial.Size = New System.Drawing.Size(152, 37)
        Me.txtBancoPreferencial.sqlQuery = Nothing
        Me.txtBancoPreferencial.TabIndex = 0
        Me.txtBancoPreferencial.TextBoxLeft = CType(0, Short)
        Me.txtBancoPreferencial.TextWidth = 0
        '
        'fraContato2
        '
        Me.fraContato2.Controls.Add(Me.txtTelefone4)
        Me.fraContato2.Controls.Add(Me.txtEmail2)
        Me.fraContato2.Controls.Add(Me.txtTelefone3)
        Me.fraContato2.Controls.Add(Me.txtContato2)
        Me.fraContato2.Location = New System.Drawing.Point(6, 119)
        Me.fraContato2.Name = "fraContato2"
        Me.fraContato2.Size = New System.Drawing.Size(526, 107)
        Me.fraContato2.TabIndex = 1
        Me.fraContato2.TabStop = False
        Me.fraContato2.Text = "Contato 2"
        '
        'txtTelefone4
        '
        Me.txtTelefone4.BackColor = System.Drawing.Color.Transparent
        Me.txtTelefone4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTelefone4.Caption = "Telefone"
        Me.txtTelefone4.DataTextValue = Nothing
        Me.txtTelefone4.Location = New System.Drawing.Point(359, 62)
        Me.txtTelefone4.MaxLength = 20
        Me.txtTelefone4.Name = "txtTelefone4"
        Me.txtTelefone4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefone4.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTelefone4.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtTelefone4.pDecimal = CType(0, Byte)
        Me.txtTelefone4.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtTelefone4.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTelefone4.Size = New System.Drawing.Size(152, 37)
        Me.txtTelefone4.sqlQuery = Nothing
        Me.txtTelefone4.TabIndex = 3
        Me.txtTelefone4.TextBoxLeft = CType(0, Short)
        Me.txtTelefone4.TextWidth = 0
        '
        'txtEmail2
        '
        Me.txtEmail2.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmail2.Caption = "Email"
        Me.txtEmail2.DataTextValue = Nothing
        Me.txtEmail2.Location = New System.Drawing.Point(7, 62)
        Me.txtEmail2.MaxLength = 40
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmail2.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtEmail2.pDecimal = CType(0, Byte)
        Me.txtEmail2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtEmail2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmail2.Size = New System.Drawing.Size(324, 37)
        Me.txtEmail2.sqlQuery = Nothing
        Me.txtEmail2.TabIndex = 2
        Me.txtEmail2.TextBoxLeft = CType(0, Short)
        Me.txtEmail2.TextWidth = 0
        '
        'txtTelefone3
        '
        Me.txtTelefone3.BackColor = System.Drawing.Color.Transparent
        Me.txtTelefone3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTelefone3.Caption = "Telefone"
        Me.txtTelefone3.DataTextValue = Nothing
        Me.txtTelefone3.Location = New System.Drawing.Point(359, 19)
        Me.txtTelefone3.MaxLength = 20
        Me.txtTelefone3.Name = "txtTelefone3"
        Me.txtTelefone3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefone3.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTelefone3.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtTelefone3.pDecimal = CType(0, Byte)
        Me.txtTelefone3.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtTelefone3.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTelefone3.Size = New System.Drawing.Size(152, 37)
        Me.txtTelefone3.sqlQuery = Nothing
        Me.txtTelefone3.TabIndex = 1
        Me.txtTelefone3.TextBoxLeft = CType(0, Short)
        Me.txtTelefone3.TextWidth = 0
        '
        'txtContato2
        '
        Me.txtContato2.BackColor = System.Drawing.Color.Transparent
        Me.txtContato2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtContato2.Caption = "Nome"
        Me.txtContato2.DataTextValue = Nothing
        Me.txtContato2.Location = New System.Drawing.Point(7, 19)
        Me.txtContato2.MaxLength = 40
        Me.txtContato2.Name = "txtContato2"
        Me.txtContato2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContato2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtContato2.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtContato2.pDecimal = CType(0, Byte)
        Me.txtContato2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtContato2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtContato2.Size = New System.Drawing.Size(324, 37)
        Me.txtContato2.sqlQuery = Nothing
        Me.txtContato2.TabIndex = 0
        Me.txtContato2.TextBoxLeft = CType(0, Short)
        Me.txtContato2.TextWidth = 0
        '
        'fraContato1
        '
        Me.fraContato1.Controls.Add(Me.txtTelefone2)
        Me.fraContato1.Controls.Add(Me.txtEmail1)
        Me.fraContato1.Controls.Add(Me.txtTelefone1)
        Me.fraContato1.Controls.Add(Me.txtNomeContato)
        Me.fraContato1.Location = New System.Drawing.Point(6, 6)
        Me.fraContato1.Name = "fraContato1"
        Me.fraContato1.Size = New System.Drawing.Size(526, 107)
        Me.fraContato1.TabIndex = 0
        Me.fraContato1.TabStop = False
        Me.fraContato1.Text = "Contato 1"
        '
        'txtTelefone2
        '
        Me.txtTelefone2.BackColor = System.Drawing.Color.Transparent
        Me.txtTelefone2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTelefone2.Caption = "Telefone"
        Me.txtTelefone2.DataTextValue = Nothing
        Me.txtTelefone2.Location = New System.Drawing.Point(359, 62)
        Me.txtTelefone2.MaxLength = 20
        Me.txtTelefone2.Name = "txtTelefone2"
        Me.txtTelefone2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefone2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTelefone2.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtTelefone2.pDecimal = CType(0, Byte)
        Me.txtTelefone2.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtTelefone2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTelefone2.Size = New System.Drawing.Size(152, 37)
        Me.txtTelefone2.sqlQuery = Nothing
        Me.txtTelefone2.TabIndex = 3
        Me.txtTelefone2.TextBoxLeft = CType(0, Short)
        Me.txtTelefone2.TextWidth = 0
        '
        'txtEmail1
        '
        Me.txtEmail1.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmail1.Caption = "Email"
        Me.txtEmail1.DataTextValue = Nothing
        Me.txtEmail1.Location = New System.Drawing.Point(7, 62)
        Me.txtEmail1.MaxLength = 40
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmail1.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtEmail1.pDecimal = CType(0, Byte)
        Me.txtEmail1.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtEmail1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmail1.Size = New System.Drawing.Size(324, 37)
        Me.txtEmail1.sqlQuery = Nothing
        Me.txtEmail1.TabIndex = 2
        Me.txtEmail1.TextBoxLeft = CType(0, Short)
        Me.txtEmail1.TextWidth = 0
        '
        'txtTelefone1
        '
        Me.txtTelefone1.BackColor = System.Drawing.Color.Transparent
        Me.txtTelefone1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTelefone1.Caption = "Telefone"
        Me.txtTelefone1.DataTextValue = Nothing
        Me.txtTelefone1.Location = New System.Drawing.Point(359, 19)
        Me.txtTelefone1.MaxLength = 20
        Me.txtTelefone1.Name = "txtTelefone1"
        Me.txtTelefone1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefone1.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTelefone1.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtTelefone1.pDecimal = CType(0, Byte)
        Me.txtTelefone1.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtTelefone1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTelefone1.Size = New System.Drawing.Size(152, 37)
        Me.txtTelefone1.sqlQuery = Nothing
        Me.txtTelefone1.TabIndex = 1
        Me.txtTelefone1.TextBoxLeft = CType(0, Short)
        Me.txtTelefone1.TextWidth = 0
        '
        'txtNomeContato
        '
        Me.txtNomeContato.BackColor = System.Drawing.Color.Transparent
        Me.txtNomeContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNomeContato.Caption = "Nome"
        Me.txtNomeContato.DataTextValue = Nothing
        Me.txtNomeContato.Location = New System.Drawing.Point(7, 19)
        Me.txtNomeContato.MaxLength = 40
        Me.txtNomeContato.Name = "txtNomeContato"
        Me.txtNomeContato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomeContato.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNomeContato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtNomeContato.pDecimal = CType(0, Byte)
        Me.txtNomeContato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNomeContato.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNomeContato.Size = New System.Drawing.Size(324, 37)
        Me.txtNomeContato.sqlQuery = Nothing
        Me.txtNomeContato.TabIndex = 0
        Me.txtNomeContato.TextBoxLeft = CType(0, Short)
        Me.txtNomeContato.TextWidth = 0
        '
        'txtLimiteCredito
        '
        Me.txtLimiteCredito.BackColor = System.Drawing.Color.Transparent
        Me.txtLimiteCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtLimiteCredito.Caption = "Limite de Crédito"
        Me.txtLimiteCredito.DataTextValue = Nothing
        Me.txtLimiteCredito.Location = New System.Drawing.Point(353, 243)
        Me.txtLimiteCredito.MaxLength = 20
        Me.txtLimiteCredito.Name = "txtLimiteCredito"
        Me.txtLimiteCredito.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLimiteCredito.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtLimiteCredito.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtLimiteCredito.pDecimal = CType(2, Byte)
        Me.txtLimiteCredito.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtLimiteCredito.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtLimiteCredito.Size = New System.Drawing.Size(152, 37)
        Me.txtLimiteCredito.sqlQuery = Nothing
        Me.txtLimiteCredito.TabIndex = 4
        Me.txtLimiteCredito.TextBoxLeft = CType(0, Short)
        Me.txtLimiteCredito.TextWidth = 0
        '
        'txtSubConta
        '
        Me.txtSubConta.BackColor = System.Drawing.Color.Transparent
        Me.txtSubConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSubConta.Caption = "Sub Conta"
        Me.txtSubConta.DataTextValue = Nothing
        Me.txtSubConta.Location = New System.Drawing.Point(176, 243)
        Me.txtSubConta.MaxLength = 20
        Me.txtSubConta.Name = "txtSubConta"
        Me.txtSubConta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubConta.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtSubConta.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtSubConta.pDecimal = CType(0, Byte)
        Me.txtSubConta.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtSubConta.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtSubConta.Size = New System.Drawing.Size(152, 37)
        Me.txtSubConta.sqlQuery = Nothing
        Me.txtSubConta.TabIndex = 3
        Me.txtSubConta.TextBoxLeft = CType(0, Short)
        Me.txtSubConta.TextWidth = 0
        '
        'txtSubContaCSC
        '
        Me.txtSubContaCSC.BackColor = System.Drawing.Color.Transparent
        Me.txtSubContaCSC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSubContaCSC.Caption = "Sub Conta CSC"
        Me.txtSubContaCSC.DataTextValue = Nothing
        Me.txtSubContaCSC.Location = New System.Drawing.Point(6, 243)
        Me.txtSubContaCSC.MaxLength = 20
        Me.txtSubContaCSC.Name = "txtSubContaCSC"
        Me.txtSubContaCSC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubContaCSC.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtSubContaCSC.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtSubContaCSC.pDecimal = CType(0, Byte)
        Me.txtSubContaCSC.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtSubContaCSC.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtSubContaCSC.Size = New System.Drawing.Size(152, 37)
        Me.txtSubContaCSC.sqlQuery = Nothing
        Me.txtSubContaCSC.TabIndex = 2
        Me.txtSubContaCSC.TextBoxLeft = CType(0, Short)
        Me.txtSubContaCSC.TextWidth = 0
        '
        'fraDados
        '
        Me.fraDados.BackColor = System.Drawing.SystemColors.Control
        Me.fraDados.Controls.Add(Me.txtEmpresa)
        Me.fraDados.Controls.Add(Me.txtRamoAtividade)
        Me.fraDados.Controls.Add(Me.txtNomeFantasia)
        Me.fraDados.Controls.Add(Me.txtIM)
        Me.fraDados.Controls.Add(Me.txtIE)
        Me.fraDados.Controls.Add(Me.txtFuncao)
        Me.fraDados.Controls.Add(Me.cboCNPF)
        Me.fraDados.Controls.Add(Me.txtCNPF)
        Me.fraDados.Controls.Add(Me.GroupBox2)
        Me.fraDados.Controls.Add(Me.fraPorte)
        Me.fraDados.Controls.Add(Me.txtRazaoSocial)
        Me.fraDados.Controls.Add(Me.txtCodTerceiro)
        Me.fraDados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fraDados.Location = New System.Drawing.Point(11, 12)
        Me.fraDados.Name = "fraDados"
        Me.fraDados.Size = New System.Drawing.Size(852, 198)
        Me.fraDados.TabIndex = 0
        Me.fraDados.TabStop = False
        Me.fraDados.Text = "Dados Cadastrais"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmpresa.Caption = "Empresa"
        Me.txtEmpresa.DataTextValue = Nothing
        Me.txtEmpresa.Location = New System.Drawing.Point(267, 147)
        Me.txtEmpresa.MaxLength = 3
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Obrigatorio = True
        Me.txtEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEmpresa.pDecimal = CType(0, Byte)
        Me.txtEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.txtEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmpresa.showButton = True
        Me.txtEmpresa.ShowDescricao = True
        Me.txtEmpresa.Size = New System.Drawing.Size(321, 37)
        Me.txtEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.txtEmpresa.TabIndex = 9
        Me.txtEmpresa.TextBoxLeft = CType(0, Short)
        Me.txtEmpresa.TextWidth = 0
        '
        'txtRamoAtividade
        '
        Me.txtRamoAtividade.BackColor = System.Drawing.SystemColors.Control
        Me.txtRamoAtividade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtRamoAtividade.Caption = "Ramo de Atividade"
        Me.txtRamoAtividade.DataTextValue = Nothing
        Me.txtRamoAtividade.Location = New System.Drawing.Point(267, 104)
        Me.txtRamoAtividade.MaxLength = 2
        Me.txtRamoAtividade.Name = "txtRamoAtividade"
        Me.txtRamoAtividade.Obrigatorio = True
        Me.txtRamoAtividade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRamoAtividade.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtRamoAtividade.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtRamoAtividade.pDecimal = CType(0, Byte)
        Me.txtRamoAtividade.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Ramo_Atividade
        Me.txtRamoAtividade.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtRamoAtividade.showButton = True
        Me.txtRamoAtividade.ShowDescricao = True
        Me.txtRamoAtividade.Size = New System.Drawing.Size(319, 37)
        Me.txtRamoAtividade.sqlQuery = "Execute prNet_Ramo_Atividade_L"
        Me.txtRamoAtividade.TabIndex = 7
        Me.txtRamoAtividade.TextBoxLeft = CType(0, Short)
        Me.txtRamoAtividade.TextWidth = 0
        '
        'txtNomeFantasia
        '
        Me.txtNomeFantasia.BackColor = System.Drawing.SystemColors.Control
        Me.txtNomeFantasia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtNomeFantasia.Caption = "Nome de Fantasia"
        Me.txtNomeFantasia.DataTextValue = Nothing
        Me.txtNomeFantasia.Location = New System.Drawing.Point(17, 104)
        Me.txtNomeFantasia.MaxLength = 50
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        Me.txtNomeFantasia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomeFantasia.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtNomeFantasia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtNomeFantasia.pDecimal = CType(0, Byte)
        Me.txtNomeFantasia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtNomeFantasia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtNomeFantasia.Size = New System.Drawing.Size(229, 37)
        Me.txtNomeFantasia.sqlQuery = Nothing
        Me.txtNomeFantasia.TabIndex = 6
        Me.txtNomeFantasia.TextBoxLeft = CType(0, Short)
        Me.txtNomeFantasia.TextWidth = 0
        '
        'txtIM
        '
        Me.txtIM.BackColor = System.Drawing.SystemColors.Control
        Me.txtIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtIM.Caption = "Inscrição Municipal"
        Me.txtIM.DataTextValue = Nothing
        Me.txtIM.Location = New System.Drawing.Point(437, 61)
        Me.txtIM.MaxLength = 15
        Me.txtIM.Name = "txtIM"
        Me.txtIM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIM.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtIM.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtIM.pDecimal = CType(0, Byte)
        Me.txtIM.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtIM.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtIM.Size = New System.Drawing.Size(149, 37)
        Me.txtIM.sqlQuery = Nothing
        Me.txtIM.TabIndex = 5
        Me.txtIM.TextBoxLeft = CType(0, Short)
        Me.txtIM.TextWidth = 0
        '
        'txtIE
        '
        Me.txtIE.BackColor = System.Drawing.SystemColors.Control
        Me.txtIE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtIE.Caption = "Inscrição Estadual"
        Me.txtIE.DataTextValue = Nothing
        Me.txtIE.Location = New System.Drawing.Point(267, 62)
        Me.txtIE.MaxLength = 15
        Me.txtIE.Name = "txtIE"
        Me.txtIE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIE.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtIE.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtIE.pDecimal = CType(0, Byte)
        Me.txtIE.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtIE.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtIE.Size = New System.Drawing.Size(149, 37)
        Me.txtIE.sqlQuery = Nothing
        Me.txtIE.TabIndex = 4
        Me.txtIE.TextBoxLeft = CType(0, Short)
        Me.txtIE.TextWidth = 0
        '
        'txtFuncao
        '
        Me.txtFuncao.BackColor = System.Drawing.SystemColors.Control
        Me.txtFuncao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtFuncao.Caption = "Função"
        Me.txtFuncao.DataTextValue = Nothing
        Me.txtFuncao.Location = New System.Drawing.Point(17, 147)
        Me.txtFuncao.MaxLength = 2
        Me.txtFuncao.Name = "txtFuncao"
        Me.txtFuncao.Obrigatorio = True
        Me.txtFuncao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFuncao.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtFuncao.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtFuncao.pDecimal = CType(0, Byte)
        Me.txtFuncao.pDicionario = WUC.clsDicionario.enuDicionario.Terceiro_Funcao
        Me.txtFuncao.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtFuncao.showButton = True
        Me.txtFuncao.ShowDescricao = True
        Me.txtFuncao.Size = New System.Drawing.Size(229, 37)
        Me.txtFuncao.sqlQuery = "Execute PrNet_terceiro_funcao_L"
        Me.txtFuncao.TabIndex = 8
        Me.txtFuncao.TextBoxLeft = CType(0, Short)
        Me.txtFuncao.TextWidth = 0
        '
        'cboCNPF
        '
        Me.cboCNPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCNPF.FormattingEnabled = True
        Me.cboCNPF.Items.AddRange(New Object() {"CNPJ", "CPF"})
        Me.cboCNPF.Location = New System.Drawing.Point(20, 83)
        Me.cboCNPF.Name = "cboCNPF"
        Me.cboCNPF.Size = New System.Drawing.Size(74, 21)
        Me.cboCNPF.TabIndex = 2
        '
        'txtCNPF
        '
        Me.txtCNPF.BackColor = System.Drawing.SystemColors.Control
        Me.txtCNPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCNPF.Caption = "CNPJ / CPF"
        Me.txtCNPF.DataTextValue = Nothing
        Me.txtCNPF.Location = New System.Drawing.Point(97, 61)
        Me.txtCNPF.MaxLength = 18
        Me.txtCNPF.Name = "txtCNPF"
        Me.txtCNPF.Obrigatorio = True
        Me.txtCNPF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCNPF.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCNPF.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtCNPF.pDecimal = CType(0, Byte)
        Me.txtCNPF.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtCNPF.pFormatoSaida = WUC.UcText.FormatoSaida.CNPJ
        Me.txtCNPF.Size = New System.Drawing.Size(149, 37)
        Me.txtCNPF.sqlQuery = Nothing
        Me.txtCNPF.TabIndex = 3
        Me.txtCNPF.TextBoxLeft = CType(0, Short)
        Me.txtCNPF.TextWidth = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkClienteDireto)
        Me.GroupBox2.Controls.Add(Me.chkEstrangeiro)
        Me.GroupBox2.Controls.Add(Me.chkAfiliada)
        Me.GroupBox2.Controls.Add(Me.chkRegional)
        Me.GroupBox2.Controls.Add(Me.chkEmissora)
        Me.GroupBox2.Location = New System.Drawing.Point(704, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 146)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'chkClienteDireto
        '
        Me.chkClienteDireto.AutoSize = True
        Me.chkClienteDireto.Location = New System.Drawing.Point(20, 120)
        Me.chkClienteDireto.Name = "chkClienteDireto"
        Me.chkClienteDireto.Size = New System.Drawing.Size(89, 17)
        Me.chkClienteDireto.TabIndex = 31
        Me.chkClienteDireto.TabStop = False
        Me.chkClienteDireto.Text = "Cliente Direto"
        Me.chkClienteDireto.UseVisualStyleBackColor = True
        '
        'chkEstrangeiro
        '
        Me.chkEstrangeiro.AutoSize = True
        Me.chkEstrangeiro.Location = New System.Drawing.Point(20, 95)
        Me.chkEstrangeiro.Name = "chkEstrangeiro"
        Me.chkEstrangeiro.Size = New System.Drawing.Size(79, 17)
        Me.chkEstrangeiro.TabIndex = 30
        Me.chkEstrangeiro.TabStop = False
        Me.chkEstrangeiro.Text = "Estrangeiro"
        Me.chkEstrangeiro.UseVisualStyleBackColor = True
        '
        'chkAfiliada
        '
        Me.chkAfiliada.AutoSize = True
        Me.chkAfiliada.Location = New System.Drawing.Point(20, 70)
        Me.chkAfiliada.Name = "chkAfiliada"
        Me.chkAfiliada.Size = New System.Drawing.Size(60, 17)
        Me.chkAfiliada.TabIndex = 29
        Me.chkAfiliada.TabStop = False
        Me.chkAfiliada.Text = "Afiliada"
        Me.chkAfiliada.UseVisualStyleBackColor = True
        '
        'chkRegional
        '
        Me.chkRegional.AutoSize = True
        Me.chkRegional.Location = New System.Drawing.Point(20, 45)
        Me.chkRegional.Name = "chkRegional"
        Me.chkRegional.Size = New System.Drawing.Size(68, 17)
        Me.chkRegional.TabIndex = 28
        Me.chkRegional.TabStop = False
        Me.chkRegional.Text = "Regional"
        Me.chkRegional.UseVisualStyleBackColor = True
        '
        'chkEmissora
        '
        Me.chkEmissora.AutoSize = True
        Me.chkEmissora.Location = New System.Drawing.Point(20, 20)
        Me.chkEmissora.Name = "chkEmissora"
        Me.chkEmissora.Size = New System.Drawing.Size(68, 17)
        Me.chkEmissora.TabIndex = 27
        Me.chkEmissora.TabStop = False
        Me.chkEmissora.Text = "Emissora"
        Me.chkEmissora.UseVisualStyleBackColor = True
        '
        'fraPorte
        '
        Me.fraPorte.Controls.Add(Me.optPequeno)
        Me.fraPorte.Controls.Add(Me.optMédio)
        Me.fraPorte.Controls.Add(Me.optGrande)
        Me.fraPorte.Location = New System.Drawing.Point(594, 38)
        Me.fraPorte.Name = "fraPorte"
        Me.fraPorte.Size = New System.Drawing.Size(99, 146)
        Me.fraPorte.TabIndex = 6
        Me.fraPorte.TabStop = False
        Me.fraPorte.Text = "Porte"
        '
        'optPequeno
        '
        Me.optPequeno.AutoSize = True
        Me.optPequeno.Location = New System.Drawing.Point(18, 119)
        Me.optPequeno.Name = "optPequeno"
        Me.optPequeno.Size = New System.Drawing.Size(68, 17)
        Me.optPequeno.TabIndex = 2
        Me.optPequeno.Text = "Pequeno"
        Me.optPequeno.UseVisualStyleBackColor = True
        '
        'optMédio
        '
        Me.optMédio.AutoSize = True
        Me.optMédio.Location = New System.Drawing.Point(18, 69)
        Me.optMédio.Name = "optMédio"
        Me.optMédio.Size = New System.Drawing.Size(54, 17)
        Me.optMédio.TabIndex = 26
        Me.optMédio.Text = "Médio"
        Me.optMédio.UseVisualStyleBackColor = True
        '
        'optGrande
        '
        Me.optGrande.AutoSize = True
        Me.optGrande.Location = New System.Drawing.Point(18, 19)
        Me.optGrande.Name = "optGrande"
        Me.optGrande.Size = New System.Drawing.Size(60, 17)
        Me.optGrande.TabIndex = 0
        Me.optGrande.Text = "Grande"
        Me.optGrande.UseVisualStyleBackColor = True
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.BackColor = System.Drawing.SystemColors.Control
        Me.txtRazaoSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtRazaoSocial.Caption = "Razão Social"
        Me.txtRazaoSocial.DataTextValue = Nothing
        Me.txtRazaoSocial.Location = New System.Drawing.Point(97, 19)
        Me.txtRazaoSocial.MaxLength = 50
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Obrigatorio = True
        Me.txtRazaoSocial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRazaoSocial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtRazaoSocial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtRazaoSocial.pDecimal = CType(0, Byte)
        Me.txtRazaoSocial.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtRazaoSocial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtRazaoSocial.Size = New System.Drawing.Size(491, 37)
        Me.txtRazaoSocial.sqlQuery = Nothing
        Me.txtRazaoSocial.TabIndex = 1
        Me.txtRazaoSocial.TextBoxLeft = CType(0, Short)
        Me.txtRazaoSocial.TextWidth = 0
        '
        'txtCodTerceiro
        '
        Me.txtCodTerceiro.BackColor = System.Drawing.SystemColors.Control
        Me.txtCodTerceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtCodTerceiro.Caption = "Código"
        Me.txtCodTerceiro.DataTextValue = Nothing
        Me.txtCodTerceiro.Location = New System.Drawing.Point(17, 19)
        Me.txtCodTerceiro.MaxLength = 6
        Me.txtCodTerceiro.Name = "txtCodTerceiro"
        Me.txtCodTerceiro.Obrigatorio = True
        Me.txtCodTerceiro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodTerceiro.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtCodTerceiro.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtCodTerceiro.pDecimal = CType(0, Byte)
        Me.txtCodTerceiro.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtCodTerceiro.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtCodTerceiro.Size = New System.Drawing.Size(74, 37)
        Me.txtCodTerceiro.sqlQuery = Nothing
        Me.txtCodTerceiro.TabIndex = 0
        Me.txtCodTerceiro.TextBoxLeft = CType(0, Short)
        Me.txtCodTerceiro.TextWidth = 0
        '
        'errTerceiro
        '
        Me.errTerceiro.ContainerControl = Me
        '
        'BdNavigator
        '
        Me.BdNavigator.AddNewItem = Nothing
        Me.BdNavigator.AllowMerge = False
        Me.BdNavigator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BdNavigator.AutoSize = False
        Me.BdNavigator.BackColor = System.Drawing.SystemColors.Control
        Me.BdNavigator.CountItem = Nothing
        Me.BdNavigator.DeleteItem = Nothing
        Me.BdNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.BdNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BdNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.lblCod_Empresa, Me.lblRazao_Social, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.btnDesativar, Me.lblStatus})
        Me.BdNavigator.Location = New System.Drawing.Point(12, 527)
        Me.BdNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BdNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BdNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BdNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BdNavigator.Name = "BdNavigator"
        Me.BdNavigator.PositionItem = Nothing
        Me.BdNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BdNavigator.ShowItemToolTips = False
        Me.BdNavigator.Size = New System.Drawing.Size(849, 25)
        Me.BdNavigator.TabIndex = 9
        Me.BdNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel1.Text = " Empresas"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'lblCod_Empresa
        '
        Me.lblCod_Empresa.AutoSize = False
        Me.lblCod_Empresa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblCod_Empresa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod_Empresa.Name = "lblCod_Empresa"
        Me.lblCod_Empresa.Size = New System.Drawing.Size(40, 22)
        Me.lblCod_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRazao_Social
        '
        Me.lblRazao_Social.AutoSize = False
        Me.lblRazao_Social.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblRazao_Social.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazao_Social.Name = "lblRazao_Social"
        Me.lblRazao_Social.Size = New System.Drawing.Size(250, 22)
        Me.lblRazao_Social.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'btnDesativar
        '
        Me.btnDesativar.AutoToolTip = False
        Me.btnDesativar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDesativar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDesativar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesativar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btnDesativar.Size = New System.Drawing.Size(66, 22)
        Me.btnDesativar.Text = "Desativar"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = False
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.lblStatus.Size = New System.Drawing.Size(255, 22)
        '
        'bdSource
        '
        '
        'btnTerceiro
        '
        Me.btnTerceiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTerceiro.BackColor = System.Drawing.SystemColors.Control
        Me.btnTerceiro.Location = New System.Drawing.Point(682, 555)
        Me.btnTerceiro.Name = "btnTerceiro"
        Me.btnTerceiro.Size = New System.Drawing.Size(179, 38)
        Me.btnTerceiro.TabIndex = 2
        Me.btnTerceiro.TabStop = False
        '
        'frmTerceiro_Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(870, 598)
        Me.Controls.Add(Me.BdNavigator)
        Me.Controls.Add(Me.fraDados)
        Me.Controls.Add(Me.btnTerceiro)
        Me.Controls.Add(Me.tabControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTerceiro_Cadastro"
        Me.Text = "Manutenção do Cadastro de Terceiros"
        Me.tabControl.ResumeLayout(False)
        Me.tabEndereco.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.fraEndereco.ResumeLayout(False)
        Me.tabComplementar.ResumeLayout(False)
        Me.tabComplementar.PerformLayout()
        Me.fraDadosBancario.ResumeLayout(False)
        Me.fraContato2.ResumeLayout(False)
        Me.fraContato1.ResumeLayout(False)
        Me.fraDados.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.fraPorte.ResumeLayout(False)
        Me.fraPorte.PerformLayout()
        CType(Me.errTerceiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BdNavigator.ResumeLayout(False)
        Me.BdNavigator.PerformLayout()
        CType(Me.bdSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabEndereco As System.Windows.Forms.TabPage
    Friend WithEvents tabComplementar As System.Windows.Forms.TabPage
    Friend WithEvents fraEndereco As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUf_2 As WUC.UcText
    Friend WithEvents txtMunicipio_2 As WUC.UcText
    Friend WithEvents txtBairro_2 As WUC.UcText
    Friend WithEvents txtComplemento_2 As WUC.UcText
    Friend WithEvents txtNumero_2 As WUC.UcText
    Friend WithEvents txtEndereco_2 As WUC.UcText
    Friend WithEvents txtUf_1 As WUC.UcText
    Friend WithEvents txtMunicipio_1 As WUC.UcText
    Friend WithEvents txtBairro_1 As WUC.UcText
    Friend WithEvents txtComplemento_1 As WUC.UcText
    Friend WithEvents txtNumero_1 As WUC.UcText
    Friend WithEvents txtEndereco_1 As WUC.UcText
    Friend WithEvents btnTerceiro As WUC.ucButton
    Friend WithEvents fraContato1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefone1 As WUC.UcText
    Friend WithEvents txtNomeContato As WUC.UcText
    Friend WithEvents fraDadosBancario As System.Windows.Forms.GroupBox
    Friend WithEvents txtBancoPreferencial As WUC.UcText
    Friend WithEvents fraContato2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefone4 As WUC.UcText
    Friend WithEvents txtEmail2 As WUC.UcText
    Friend WithEvents txtTelefone3 As WUC.UcText
    Friend WithEvents txtContato2 As WUC.UcText
    Friend WithEvents txtTelefone2 As WUC.UcText
    Friend WithEvents txtEmail1 As WUC.UcText
    Friend WithEvents txtRepresentante As WUC.UcText
    Friend WithEvents txtGrupoCLiente As WUC.UcText
    Friend WithEvents txtSubConta As WUC.UcText
    Friend WithEvents txtSubContaCSC As WUC.UcText
    Friend WithEvents txtLimiteCredito As WUC.UcText
    Friend WithEvents chkIn480 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMerchandising As System.Windows.Forms.CheckBox
    Friend WithEvents fraDados As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmpresa As WUC.UcText
    Friend WithEvents txtRamoAtividade As WUC.UcText
    Friend WithEvents txtNomeFantasia As WUC.UcText
    Friend WithEvents txtIM As WUC.UcText
    Friend WithEvents txtIE As WUC.UcText
    Friend WithEvents txtFuncao As WUC.UcText
    Friend WithEvents cboCNPF As System.Windows.Forms.ComboBox
    Friend WithEvents txtCNPF As WUC.UcText
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkClienteDireto As System.Windows.Forms.CheckBox
    Friend WithEvents chkEstrangeiro As System.Windows.Forms.CheckBox
    Friend WithEvents chkAfiliada As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegional As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmissora As System.Windows.Forms.CheckBox
    Friend WithEvents fraPorte As System.Windows.Forms.GroupBox
    Friend WithEvents optPequeno As System.Windows.Forms.RadioButton
    Friend WithEvents optMédio As System.Windows.Forms.RadioButton
    Friend WithEvents optGrande As System.Windows.Forms.RadioButton
    Friend WithEvents txtRazaoSocial As WUC.UcText
    Friend WithEvents txtCodTerceiro As WUC.UcText
    Friend WithEvents errTerceiro As System.Windows.Forms.ErrorProvider
    Friend WithEvents bdSource As System.Windows.Forms.BindingSource
    Friend WithEvents BdNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCod_Empresa As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblRazao_Social As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtEmail As WUC.UcText
    Friend WithEvents txtFax As WUC.UcText
    Friend WithEvents txtTelefone As WUC.UcText
    Friend WithEvents txtPracaPagto As WUC.UcText
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnDesativar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCep_1 As WUC.UcText
    Friend WithEvents txtCep_2 As WUC.UcText
End Class
