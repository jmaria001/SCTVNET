<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmControle_Fita_Afiliada_Inclusao
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        InitializeComponent()

      
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtId_chave As System.Windows.Forms.TextBox
	Public WithEvents chkArtistico As System.Windows.Forms.CheckBox
	Public WithEvents chkAvulso As System.Windows.Forms.CheckBox
	Public WithEvents chkInclusao As System.Windows.Forms.CheckBox
	Public WithEvents chkAlteracao As System.Windows.Forms.CheckBox
	Public WithEvents cmdFechar As System.Windows.Forms.Button
	Public WithEvents txtObservacao As System.Windows.Forms.TextBox
	Public WithEvents lblObservacao As System.Windows.Forms.Label
	Public WithEvents pctObservacao As System.Windows.Forms.Panel
    Public WithEvents txtData_Inicio As System.Windows.Forms.TextBox
    Public WithEvents txtData_Final As System.Windows.Forms.TextBox
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'Public WithEvents chkDiaSemana As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmdPrograma As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents txtCod_Programa As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtTitulo_Programa As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControle_Fita_Afiliada_Inclusao))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdDisponivel = New System.Windows.Forms.Button
        Me.txtId_chave = New System.Windows.Forms.TextBox
        Me.chkArtistico = New System.Windows.Forms.CheckBox
        Me.chkAvulso = New System.Windows.Forms.CheckBox
        Me.chkInclusao = New System.Windows.Forms.CheckBox
        Me.chkAlteracao = New System.Windows.Forms.CheckBox
        Me.pctObservacao = New System.Windows.Forms.Panel
        Me.cmdFechar = New System.Windows.Forms.Button
        Me.txtObservacao = New System.Windows.Forms.TextBox
        Me.lblObservacao = New System.Windows.Forms.Label
        Me.Cod_Red_Produto = New System.Windows.Forms.DataGridViewColumn
        Me.Descricao = New System.Windows.Forms.DataGridViewColumn
        Me.txtData_Inicio = New System.Windows.Forms.TextBox
        Me.txtData_Final = New System.Windows.Forms.TextBox
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdPrograma = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.txtCod_Programa = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.txtTitulo_Programa = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.chkLoad = New System.Windows.Forms.CheckBox
        Me.fraDados = New System.Windows.Forms.GroupBox
        Me.UcTipoComercial = New WUC.UcText
        Me.ucPrograma = New WUC.UcText
        Me.ucPrograma2 = New WUC.UcText
        Me.ucProduto = New WUC.UcText
        Me.UcDataFinal = New WCL_SCTV.UC.UCData
        Me.UcDataInicio = New WCL_SCTV.UC.UCData
        Me.fraVeiculo = New System.Windows.Forms.GroupBox
        Me.lstVeiculo = New System.Windows.Forms.CheckedListBox
        Me.chkVeiculo = New System.Windows.Forms.CheckBox
        Me.fraDiaSemana = New System.Windows.Forms.GroupBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.chkSabado = New System.Windows.Forms.CheckBox
        Me.chkSexta = New System.Windows.Forms.CheckBox
        Me.chkQuinta = New System.Windows.Forms.CheckBox
        Me.chkTerca = New System.Windows.Forms.CheckBox
        Me.chkQuarta = New System.Windows.Forms.CheckBox
        Me.chkSegunda = New System.Windows.Forms.CheckBox
        Me.chkDomingo = New System.Windows.Forms.CheckBox
        Me.txtDuracao = New System.Windows.Forms.TextBox
        Me.txtTitulo_Comercial = New System.Windows.Forms.TextBox
        Me.txtQtde = New System.Windows.Forms.TextBox
        Me.txtNumero_Fita = New System.Windows.Forms.TextBox
        Me.imgObservacao = New System.Windows.Forms.PictureBox
        Me._Label1_7 = New System.Windows.Forms.Label
        Me._Label1_6 = New System.Windows.Forms.Label
        Me._Label1_8 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.cmdCancela = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.pctObservacao.SuspendLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCod_Programa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo_Programa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDados.SuspendLayout()
        Me.fraVeiculo.SuspendLayout()
        Me.fraDiaSemana.SuspendLayout()
        CType(Me.imgObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDisponivel
        '
        Me.cmdDisponivel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDisponivel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDisponivel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisponivel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDisponivel.Location = New System.Drawing.Point(90, 27)
        Me.cmdDisponivel.Name = "cmdDisponivel"
        Me.cmdDisponivel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDisponivel.Size = New System.Drawing.Size(22, 24)
        Me.cmdDisponivel.TabIndex = 2
        Me.cmdDisponivel.TabStop = False
        Me.cmdDisponivel.Text = "#"
        Me.ToolTip1.SetToolTip(Me.cmdDisponivel, "Achar N.disponível")
        Me.cmdDisponivel.UseVisualStyleBackColor = False
        '
        'txtId_chave
        '
        Me.txtId_chave.AcceptsReturn = True
        Me.txtId_chave.BackColor = System.Drawing.SystemColors.Window
        Me.txtId_chave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtId_chave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_chave.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtId_chave.Location = New System.Drawing.Point(465, 333)
        Me.txtId_chave.MaxLength = 0
        Me.txtId_chave.Name = "txtId_chave"
        Me.txtId_chave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtId_chave.Size = New System.Drawing.Size(85, 20)
        Me.txtId_chave.TabIndex = 45
        Me.txtId_chave.Visible = False
        '
        'chkArtistico
        '
        Me.chkArtistico.BackColor = System.Drawing.SystemColors.Control
        Me.chkArtistico.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkArtistico.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArtistico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkArtistico.Location = New System.Drawing.Point(543, 307)
        Me.chkArtistico.Name = "chkArtistico"
        Me.chkArtistico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkArtistico.Size = New System.Drawing.Size(83, 24)
        Me.chkArtistico.TabIndex = 44
        Me.chkArtistico.Text = "Artistico"
        Me.chkArtistico.UseVisualStyleBackColor = False
        Me.chkArtistico.Visible = False
        '
        'chkAvulso
        '
        Me.chkAvulso.BackColor = System.Drawing.SystemColors.Control
        Me.chkAvulso.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAvulso.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAvulso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAvulso.Location = New System.Drawing.Point(465, 307)
        Me.chkAvulso.Name = "chkAvulso"
        Me.chkAvulso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAvulso.Size = New System.Drawing.Size(67, 20)
        Me.chkAvulso.TabIndex = 43
        Me.chkAvulso.Text = "Avulso"
        Me.chkAvulso.UseVisualStyleBackColor = False
        Me.chkAvulso.Visible = False
        '
        'chkInclusao
        '
        Me.chkInclusao.BackColor = System.Drawing.SystemColors.Control
        Me.chkInclusao.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkInclusao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInclusao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkInclusao.Location = New System.Drawing.Point(541, 285)
        Me.chkInclusao.Name = "chkInclusao"
        Me.chkInclusao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkInclusao.Size = New System.Drawing.Size(85, 16)
        Me.chkInclusao.TabIndex = 42
        Me.chkInclusao.Text = "Inclusão"
        Me.chkInclusao.UseVisualStyleBackColor = False
        Me.chkInclusao.Visible = False
        '
        'chkAlteracao
        '
        Me.chkAlteracao.BackColor = System.Drawing.SystemColors.Control
        Me.chkAlteracao.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAlteracao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlteracao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAlteracao.Location = New System.Drawing.Point(465, 285)
        Me.chkAlteracao.Name = "chkAlteracao"
        Me.chkAlteracao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAlteracao.Size = New System.Drawing.Size(85, 16)
        Me.chkAlteracao.TabIndex = 41
        Me.chkAlteracao.Text = "Alteração"
        Me.chkAlteracao.UseVisualStyleBackColor = False
        Me.chkAlteracao.Visible = False
        '
        'pctObservacao
        '
        Me.pctObservacao.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pctObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctObservacao.Controls.Add(Me.cmdFechar)
        Me.pctObservacao.Controls.Add(Me.txtObservacao)
        Me.pctObservacao.Controls.Add(Me.lblObservacao)
        Me.pctObservacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctObservacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pctObservacao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.pctObservacao.Location = New System.Drawing.Point(444, 3)
        Me.pctObservacao.Name = "pctObservacao"
        Me.pctObservacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctObservacao.Size = New System.Drawing.Size(325, 229)
        Me.pctObservacao.TabIndex = 24
        Me.pctObservacao.TabStop = True
        Me.pctObservacao.Visible = False
        '
        'cmdFechar
        '
        Me.cmdFechar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFechar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFechar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFechar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFechar.Location = New System.Drawing.Point(248, 188)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFechar.Size = New System.Drawing.Size(71, 29)
        Me.cmdFechar.TabIndex = 23
        Me.cmdFechar.TabStop = False
        Me.cmdFechar.Text = "&Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = False
        '
        'txtObservacao
        '
        Me.txtObservacao.AcceptsReturn = True
        Me.txtObservacao.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObservacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtObservacao.Location = New System.Drawing.Point(4, 24)
        Me.txtObservacao.MaxLength = 0
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(313, 157)
        Me.txtObservacao.TabIndex = 22
        '
        'lblObservacao
        '
        Me.lblObservacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblObservacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblObservacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacao.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblObservacao.Location = New System.Drawing.Point(0, 0)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblObservacao.Size = New System.Drawing.Size(325, 17)
        Me.lblObservacao.TabIndex = 25
        Me.lblObservacao.Text = "Observações"
        Me.lblObservacao.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cod_Red_Produto
        '
        Me.Cod_Red_Produto.DataPropertyName = "Cod_Red_Produto"
        Me.Cod_Red_Produto.HeaderText = "Código"
        Me.Cod_Red_Produto.Name = "Cod_Red_Produto"
        '
        'Descricao
        '
        Me.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descricao.DataPropertyName = "Descricao"
        Me.Descricao.HeaderText = "Descrição"
        Me.Descricao.Name = "Descricao"
        '
        'txtData_Inicio
        '
        Me.txtData_Inicio.AcceptsReturn = True
        Me.txtData_Inicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtData_Inicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtData_Inicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData_Inicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtData_Inicio.Location = New System.Drawing.Point(613, 342)
        Me.txtData_Inicio.MaxLength = 10
        Me.txtData_Inicio.Name = "txtData_Inicio"
        Me.txtData_Inicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtData_Inicio.Size = New System.Drawing.Size(81, 20)
        Me.txtData_Inicio.TabIndex = 1
        Me.txtData_Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData_Inicio.Visible = False
        '
        'txtData_Final
        '
        Me.txtData_Final.AcceptsReturn = True
        Me.txtData_Final.BackColor = System.Drawing.SystemColors.Window
        Me.txtData_Final.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtData_Final.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData_Final.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtData_Final.Location = New System.Drawing.Point(727, 342)
        Me.txtData_Final.MaxLength = 10
        Me.txtData_Final.Name = "txtData_Final"
        Me.txtData_Final.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtData_Final.Size = New System.Drawing.Size(81, 20)
        Me.txtData_Final.TabIndex = 2
        Me.txtData_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData_Final.Visible = False
        '
        'chkLoad
        '
        Me.chkLoad.AutoSize = True
        Me.chkLoad.Location = New System.Drawing.Point(11, 455)
        Me.chkLoad.Name = "chkLoad"
        Me.chkLoad.Size = New System.Drawing.Size(50, 18)
        Me.chkLoad.TabIndex = 50
        Me.chkLoad.Text = "Load"
        Me.chkLoad.UseVisualStyleBackColor = True
        Me.chkLoad.Visible = False
        '
        'fraDados
        '
        Me.fraDados.BackColor = System.Drawing.SystemColors.Control
        Me.fraDados.Controls.Add(Me.UcTipoComercial)
        Me.fraDados.Controls.Add(Me.ucPrograma)
        Me.fraDados.Controls.Add(Me.ucPrograma2)
        Me.fraDados.Controls.Add(Me.ucProduto)
        Me.fraDados.Controls.Add(Me.UcDataFinal)
        Me.fraDados.Controls.Add(Me.UcDataInicio)
        Me.fraDados.Controls.Add(Me.cmdDisponivel)
        Me.fraDados.Controls.Add(Me.fraVeiculo)
        Me.fraDados.Controls.Add(Me.fraDiaSemana)
        Me.fraDados.Controls.Add(Me.txtDuracao)
        Me.fraDados.Controls.Add(Me.txtTitulo_Comercial)
        Me.fraDados.Controls.Add(Me.txtQtde)
        Me.fraDados.Controls.Add(Me.txtNumero_Fita)
        Me.fraDados.Controls.Add(Me.imgObservacao)
        Me.fraDados.Controls.Add(Me._Label1_7)
        Me.fraDados.Controls.Add(Me._Label1_6)
        Me.fraDados.Controls.Add(Me._Label1_8)
        Me.fraDados.Controls.Add(Me._Label1_3)
        Me.fraDados.Controls.Add(Me._Label1_2)
        Me.fraDados.Controls.Add(Me._Label1_0)
        Me.fraDados.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDados.Location = New System.Drawing.Point(7, 1)
        Me.fraDados.Name = "fraDados"
        Me.fraDados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDados.Size = New System.Drawing.Size(429, 444)
        Me.fraDados.TabIndex = 0
        Me.fraDados.TabStop = False
        '
        'UcTipoComercial
        '
        Me.UcTipoComercial.BackColor = System.Drawing.SystemColors.Control
        Me.UcTipoComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcTipoComercial.Caption = "Tipo do Comercial"
        Me.UcTipoComercial.DataTextValue = Nothing
        Me.UcTipoComercial.Location = New System.Drawing.Point(9, 98)
        Me.UcTipoComercial.MaxLength = 2
        Me.UcTipoComercial.Name = "UcTipoComercial"
        Me.UcTipoComercial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcTipoComercial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.UcTipoComercial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.UcTipoComercial.pDecimal = CType(0, Byte)
        Me.UcTipoComercial.pDicionario = WUC.clsDicionario.enuDicionario.Tipo_Comercial
        Me.UcTipoComercial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.UcTipoComercial.showButton = True
        Me.UcTipoComercial.ShowDescricao = True
        Me.UcTipoComercial.Size = New System.Drawing.Size(412, 37)
        Me.UcTipoComercial.sqlQuery = "Execute prNet_Tipo_Comercial_L"
        Me.UcTipoComercial.TabIndex = 9
        Me.UcTipoComercial.TextBoxLeft = CType(0, Short)
        Me.UcTipoComercial.TextWidth = 0
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(9, 141)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(412, 37)
        Me.ucPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma.TabIndex = 10
        Me.ucPrograma.TextBoxLeft = CType(0, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'ucPrograma2
        '
        Me.ucPrograma2.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma2.Caption = "Programa"
        Me.ucPrograma2.DataTextValue = Nothing
        Me.ucPrograma2.Location = New System.Drawing.Point(9, 184)
        Me.ucPrograma2.MaxLength = 4
        Me.ucPrograma2.Name = "ucPrograma2"
        Me.ucPrograma2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma2.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucPrograma2.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma2.pDecimal = CType(0, Byte)
        Me.ucPrograma2.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma2.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma2.showButton = True
        Me.ucPrograma2.ShowDescricao = True
        Me.ucPrograma2.Size = New System.Drawing.Size(412, 37)
        Me.ucPrograma2.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma2.TabIndex = 11
        Me.ucPrograma2.TextBoxLeft = CType(0, Short)
        Me.ucPrograma2.TextWidth = 0
        '
        'ucProduto
        '
        Me.ucProduto.BackColor = System.Drawing.SystemColors.Control
        Me.ucProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucProduto.Caption = "Produto"
        Me.ucProduto.DataTextValue = Nothing
        Me.ucProduto.Location = New System.Drawing.Point(9, 227)
        Me.ucProduto.MaxLength = 6
        Me.ucProduto.Name = "ucProduto"
        Me.ucProduto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucProduto.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucProduto.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucProduto.pDecimal = CType(0, Byte)
        Me.ucProduto.pDicionario = WUC.clsDicionario.enuDicionario.Produto
        Me.ucProduto.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucProduto.showButton = True
        Me.ucProduto.ShowDescricao = True
        Me.ucProduto.Size = New System.Drawing.Size(412, 37)
        Me.ucProduto.TabIndex = 12
        Me.ucProduto.TextBoxLeft = CType(0, Short)
        Me.ucProduto.TextWidth = 0
        '
        'UcDataFinal
        '
        Me.UcDataFinal.BackColor = System.Drawing.Color.Transparent
        Me.UcDataFinal.DateTime = New Date(CType(0, Long))
        Me.UcDataFinal.Formato = "dd/MM/yyyy "
        Me.UcDataFinal.Hoje = False
        Me.UcDataFinal.Location = New System.Drawing.Point(243, 24)
        Me.UcDataFinal.MaximumSize = New System.Drawing.Size(500, 27)
        Me.UcDataFinal.MinimumSize = New System.Drawing.Size(115, 27)
        Me.UcDataFinal.Name = "UcDataFinal"
        Me.UcDataFinal.Permite_Futuro = True
        Me.UcDataFinal.Permite_Limpar = True
        Me.UcDataFinal.Permite_Passado = True
        Me.UcDataFinal.Preenchimento_Obrigatorio = False
        Me.UcDataFinal.Size = New System.Drawing.Size(115, 27)
        Me.UcDataFinal.TabIndex = 5
        '
        'UcDataInicio
        '
        Me.UcDataInicio.BackColor = System.Drawing.Color.Transparent
        Me.UcDataInicio.DateTime = New Date(CType(0, Long))
        Me.UcDataInicio.Formato = "dd/MM/yyyy "
        Me.UcDataInicio.Hoje = False
        Me.UcDataInicio.Location = New System.Drawing.Point(118, 26)
        Me.UcDataInicio.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcDataInicio.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcDataInicio.Name = "UcDataInicio"
        Me.UcDataInicio.Permite_Futuro = True
        Me.UcDataInicio.Permite_Limpar = True
        Me.UcDataInicio.Permite_Passado = True
        Me.UcDataInicio.Preenchimento_Obrigatorio = False
        Me.UcDataInicio.Size = New System.Drawing.Size(115, 25)
        Me.UcDataInicio.TabIndex = 3
        '
        'fraVeiculo
        '
        Me.fraVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.fraVeiculo.Controls.Add(Me.lstVeiculo)
        Me.fraVeiculo.Controls.Add(Me.chkVeiculo)
        Me.fraVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraVeiculo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraVeiculo.Location = New System.Drawing.Point(150, 279)
        Me.fraVeiculo.Name = "fraVeiculo"
        Me.fraVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraVeiculo.Size = New System.Drawing.Size(271, 159)
        Me.fraVeiculo.TabIndex = 47
        Me.fraVeiculo.TabStop = False
        Me.fraVeiculo.Text = "Veículos"
        '
        'lstVeiculo
        '
        Me.lstVeiculo.CheckOnClick = True
        Me.lstVeiculo.FormattingEnabled = True
        Me.lstVeiculo.Location = New System.Drawing.Point(13, 19)
        Me.lstVeiculo.Name = "lstVeiculo"
        Me.lstVeiculo.Size = New System.Drawing.Size(248, 109)
        Me.lstVeiculo.TabIndex = 49
        '
        'chkVeiculo
        '
        Me.chkVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.chkVeiculo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVeiculo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkVeiculo.Location = New System.Drawing.Point(12, 129)
        Me.chkVeiculo.Name = "chkVeiculo"
        Me.chkVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkVeiculo.Size = New System.Drawing.Size(139, 24)
        Me.chkVeiculo.TabIndex = 48
        Me.chkVeiculo.Text = "Selecionar Todos"
        Me.chkVeiculo.UseVisualStyleBackColor = False
        '
        'fraDiaSemana
        '
        Me.fraDiaSemana.BackColor = System.Drawing.SystemColors.Control
        Me.fraDiaSemana.Controls.Add(Me.chkTodos)
        Me.fraDiaSemana.Controls.Add(Me.chkSabado)
        Me.fraDiaSemana.Controls.Add(Me.chkSexta)
        Me.fraDiaSemana.Controls.Add(Me.chkQuinta)
        Me.fraDiaSemana.Controls.Add(Me.chkTerca)
        Me.fraDiaSemana.Controls.Add(Me.chkQuarta)
        Me.fraDiaSemana.Controls.Add(Me.chkSegunda)
        Me.fraDiaSemana.Controls.Add(Me.chkDomingo)
        Me.fraDiaSemana.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDiaSemana.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDiaSemana.Location = New System.Drawing.Point(6, 279)
        Me.fraDiaSemana.Name = "fraDiaSemana"
        Me.fraDiaSemana.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDiaSemana.Size = New System.Drawing.Size(139, 159)
        Me.fraDiaSemana.TabIndex = 13
        Me.fraDiaSemana.TabStop = False
        Me.fraDiaSemana.Text = "Disponibilizar nos Dias"
        '
        'chkTodos
        '
        Me.chkTodos.BackColor = System.Drawing.SystemColors.Control
        Me.chkTodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTodos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTodos.Location = New System.Drawing.Point(63, 119)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTodos.Size = New System.Drawing.Size(70, 22)
        Me.chkTodos.TabIndex = 17
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = False
        '
        'chkSabado
        '
        Me.chkSabado.BackColor = System.Drawing.SystemColors.Control
        Me.chkSabado.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSabado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSabado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSabado.Location = New System.Drawing.Point(63, 89)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSabado.Size = New System.Drawing.Size(46, 22)
        Me.chkSabado.TabIndex = 16
        Me.chkSabado.Text = "Sab"
        Me.chkSabado.UseVisualStyleBackColor = False
        '
        'chkSexta
        '
        Me.chkSexta.BackColor = System.Drawing.SystemColors.Control
        Me.chkSexta.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSexta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSexta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSexta.Location = New System.Drawing.Point(63, 59)
        Me.chkSexta.Name = "chkSexta"
        Me.chkSexta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSexta.Size = New System.Drawing.Size(46, 22)
        Me.chkSexta.TabIndex = 15
        Me.chkSexta.Text = "Sex"
        Me.chkSexta.UseVisualStyleBackColor = False
        '
        'chkQuinta
        '
        Me.chkQuinta.BackColor = System.Drawing.SystemColors.Control
        Me.chkQuinta.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkQuinta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuinta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQuinta.Location = New System.Drawing.Point(63, 30)
        Me.chkQuinta.Name = "chkQuinta"
        Me.chkQuinta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkQuinta.Size = New System.Drawing.Size(46, 22)
        Me.chkQuinta.TabIndex = 14
        Me.chkQuinta.Text = "Qui"
        Me.chkQuinta.UseVisualStyleBackColor = False
        '
        'chkTerca
        '
        Me.chkTerca.BackColor = System.Drawing.SystemColors.Control
        Me.chkTerca.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTerca.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTerca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTerca.Location = New System.Drawing.Point(9, 89)
        Me.chkTerca.Name = "chkTerca"
        Me.chkTerca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTerca.Size = New System.Drawing.Size(46, 22)
        Me.chkTerca.TabIndex = 12
        Me.chkTerca.Text = "Ter"
        Me.chkTerca.UseVisualStyleBackColor = False
        '
        'chkQuarta
        '
        Me.chkQuarta.BackColor = System.Drawing.SystemColors.Control
        Me.chkQuarta.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkQuarta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkQuarta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkQuarta.Location = New System.Drawing.Point(9, 119)
        Me.chkQuarta.Name = "chkQuarta"
        Me.chkQuarta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkQuarta.Size = New System.Drawing.Size(46, 22)
        Me.chkQuarta.TabIndex = 13
        Me.chkQuarta.Text = "Qua"
        Me.chkQuarta.UseVisualStyleBackColor = False
        '
        'chkSegunda
        '
        Me.chkSegunda.BackColor = System.Drawing.SystemColors.Control
        Me.chkSegunda.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSegunda.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSegunda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSegunda.Location = New System.Drawing.Point(9, 59)
        Me.chkSegunda.Name = "chkSegunda"
        Me.chkSegunda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSegunda.Size = New System.Drawing.Size(46, 22)
        Me.chkSegunda.TabIndex = 11
        Me.chkSegunda.Text = "Seg"
        Me.chkSegunda.UseVisualStyleBackColor = False
        '
        'chkDomingo
        '
        Me.chkDomingo.BackColor = System.Drawing.SystemColors.Control
        Me.chkDomingo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDomingo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDomingo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDomingo.Location = New System.Drawing.Point(9, 30)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDomingo.Size = New System.Drawing.Size(48, 22)
        Me.chkDomingo.TabIndex = 10
        Me.chkDomingo.Text = "Dom"
        Me.chkDomingo.UseVisualStyleBackColor = False
        '
        'txtDuracao
        '
        Me.txtDuracao.AcceptsReturn = True
        Me.txtDuracao.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuracao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDuracao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDuracao.Location = New System.Drawing.Point(364, 72)
        Me.txtDuracao.MaxLength = 5
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDuracao.Size = New System.Drawing.Size(57, 20)
        Me.txtDuracao.TabIndex = 8
        Me.txtDuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTitulo_Comercial
        '
        Me.txtTitulo_Comercial.AcceptsReturn = True
        Me.txtTitulo_Comercial.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitulo_Comercial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitulo_Comercial.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo_Comercial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitulo_Comercial.Location = New System.Drawing.Point(8, 72)
        Me.txtTitulo_Comercial.MaxLength = 30
        Me.txtTitulo_Comercial.Name = "txtTitulo_Comercial"
        Me.txtTitulo_Comercial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTitulo_Comercial.Size = New System.Drawing.Size(307, 20)
        Me.txtTitulo_Comercial.TabIndex = 7
        '
        'txtQtde
        '
        Me.txtQtde.AcceptsReturn = True
        Me.txtQtde.BackColor = System.Drawing.SystemColors.Window
        Me.txtQtde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQtde.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtde.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtQtde.Location = New System.Drawing.Point(364, 28)
        Me.txtQtde.MaxLength = 4
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQtde.Size = New System.Drawing.Size(57, 20)
        Me.txtQtde.TabIndex = 6
        Me.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumero_Fita
        '
        Me.txtNumero_Fita.AcceptsReturn = True
        Me.txtNumero_Fita.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero_Fita.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumero_Fita.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Fita.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumero_Fita.Location = New System.Drawing.Point(9, 28)
        Me.txtNumero_Fita.MaxLength = 4
        Me.txtNumero_Fita.Name = "txtNumero_Fita"
        Me.txtNumero_Fita.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumero_Fita.Size = New System.Drawing.Size(78, 20)
        Me.txtNumero_Fita.TabIndex = 1
        Me.txtNumero_Fita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'imgObservacao
        '
        Me.imgObservacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgObservacao.Image = CType(resources.GetObject("imgObservacao.Image"), System.Drawing.Image)
        Me.imgObservacao.Location = New System.Drawing.Point(321, 66)
        Me.imgObservacao.Name = "imgObservacao"
        Me.imgObservacao.Size = New System.Drawing.Size(32, 32)
        Me.imgObservacao.TabIndex = 53
        Me.imgObservacao.TabStop = False
        '
        '_Label1_7
        '
        Me._Label1_7.AutoSize = True
        Me._Label1_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(364, 56)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_7.Size = New System.Drawing.Size(48, 14)
        Me._Label1_7.TabIndex = 32
        Me._Label1_7.Text = "Duração"
        '
        '_Label1_6
        '
        Me._Label1_6.AutoSize = True
        Me._Label1_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(8, 56)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(97, 14)
        Me._Label1_6.TabIndex = 31
        Me._Label1_6.Text = "Titulo do Comercial"
        '
        '_Label1_8
        '
        Me._Label1_8.AutoSize = True
        Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(364, 12)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_8.Size = New System.Drawing.Size(62, 14)
        Me._Label1_8.TabIndex = 30
        Me._Label1_8.Text = "Quantidade"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(219, 32)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(13, 14)
        Me._Label1_3.TabIndex = 4
        Me._Label1_3.Text = "a"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(117, 12)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(101, 14)
        Me._Label1_2.TabIndex = 11
        Me._Label1_2.Text = "Período de Exibição"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(8, 12)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(79, 14)
        Me._Label1_0.TabIndex = 16
        Me._Label1_0.Text = "Número da Fita"
        '
        'cmdCancela
        '
        Me.cmdCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancela.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.Location = New System.Drawing.Point(365, 451)
        Me.cmdCancela.Name = "cmdCancela"
        Me.cmdCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancela.Size = New System.Drawing.Size(71, 32)
        Me.cmdCancela.TabIndex = 49
        Me.cmdCancela.TabStop = False
        Me.cmdCancela.Text = "&Cancela"
        Me.cmdCancela.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(283, 451)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(71, 32)
        Me.cmdOk.TabIndex = 48
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'frmControle_Fita_Afiliada_Inclusao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(439, 485)
        Me.Controls.Add(Me.chkLoad)
        Me.Controls.Add(Me.fraDados)
        Me.Controls.Add(Me.cmdCancela)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtId_chave)
        Me.Controls.Add(Me.chkArtistico)
        Me.Controls.Add(Me.chkAvulso)
        Me.Controls.Add(Me.chkInclusao)
        Me.Controls.Add(Me.chkAlteracao)
        Me.Controls.Add(Me.txtData_Inicio)
        Me.Controls.Add(Me.pctObservacao)
        Me.Controls.Add(Me.txtData_Final)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(258, 177)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControle_Fita_Afiliada_Inclusao"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Fita Afiliada Inclusão"
        Me.pctObservacao.ResumeLayout(False)
        Me.pctObservacao.PerformLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCod_Programa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo_Programa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDados.ResumeLayout(False)
        Me.fraDados.PerformLayout()
        Me.fraVeiculo.ResumeLayout(False)
        Me.fraDiaSemana.ResumeLayout(False)
        CType(Me.imgObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cod_Red_Produto As System.Windows.Forms.DataGridViewColumn
    Friend WithEvents Descricao As System.Windows.Forms.DataGridViewColumn
    Friend WithEvents chkLoad As System.Windows.Forms.CheckBox
    Public WithEvents fraDados As System.Windows.Forms.GroupBox
    Friend WithEvents UcTipoComercial As WUC.UcText
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents ucPrograma2 As WUC.UcText
    Friend WithEvents ucProduto As WUC.UcText
    Friend WithEvents UcDataFinal As WCL_SCTV.UC.UCData
    Friend WithEvents UcDataInicio As WCL_SCTV.UC.UCData
    Public WithEvents cmdDisponivel As System.Windows.Forms.Button
    Public WithEvents fraVeiculo As System.Windows.Forms.GroupBox
    Friend WithEvents lstVeiculo As System.Windows.Forms.CheckedListBox
    Public WithEvents chkVeiculo As System.Windows.Forms.CheckBox
    Public WithEvents fraDiaSemana As System.Windows.Forms.GroupBox
    Public WithEvents chkTodos As System.Windows.Forms.CheckBox
    Public WithEvents chkSabado As System.Windows.Forms.CheckBox
    Public WithEvents chkSexta As System.Windows.Forms.CheckBox
    Public WithEvents chkQuinta As System.Windows.Forms.CheckBox
    Public WithEvents chkTerca As System.Windows.Forms.CheckBox
    Public WithEvents chkQuarta As System.Windows.Forms.CheckBox
    Public WithEvents chkSegunda As System.Windows.Forms.CheckBox
    Public WithEvents chkDomingo As System.Windows.Forms.CheckBox
    Public WithEvents txtDuracao As System.Windows.Forms.TextBox
    Public WithEvents txtTitulo_Comercial As System.Windows.Forms.TextBox
    Public WithEvents txtQtde As System.Windows.Forms.TextBox
    Public WithEvents txtNumero_Fita As System.Windows.Forms.TextBox
    Public WithEvents imgObservacao As System.Windows.Forms.PictureBox
    Public WithEvents _Label1_7 As System.Windows.Forms.Label
    Public WithEvents _Label1_6 As System.Windows.Forms.Label
    Public WithEvents _Label1_8 As System.Windows.Forms.Label
    Public WithEvents _Label1_3 As System.Windows.Forms.Label
    Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents cmdCancela As System.Windows.Forms.Button
    Public WithEvents cmdOk As System.Windows.Forms.Button
#End Region
End Class