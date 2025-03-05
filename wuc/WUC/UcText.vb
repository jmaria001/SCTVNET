Imports System.Exception
Imports System.Windows.Forms
Imports system.Drawing.Color
Imports System.ComponentModel
Imports WUC.clsDicionario
Public Class UcText
#Region "Declarações"

    Public Usuario As String = ""
    Public Senha As String = ""
    Public Cod_Empresa As String = ""
    Public Seq As Integer = Nothing
    Public Contrato As Integer = Nothing
    Public Duracao As Integer = Nothing
    Public Tipo_Comercial As String = Nothing
    Public Veiculo As String = ""
    Public DataInicio As Date = Nothing
    Public DataFim As Date = Nothing
    Public Cliente As String = ""
    Public PermiteNovoProduto As Boolean = False
    Public Competencia As Int32
    Dim bolEnabled As Boolean = True


    
    Dim strDicionario As clsDicionario.enuDicionario
    Dim bolEmPosicionamento As Boolean = False
    Dim bolShowCaption As Boolean = True
    Dim enuCaptionPosition As CaptionPosition = CaptionPosition.Left
    Dim strCaption As String = "Título"
    Dim enuFormatoSaida As FormatoSaida = FormatoSaida.Texto
    Dim btDecimal As Byte = 0
    Dim EnterColor As Color = Yellow
    Dim Leavecolor As Color = White
    Dim bolSomenteNumero As Boolean = False
    Dim bolEnterTab As Boolean = True
    Dim bolValido As Boolean = True
    Dim strMensagemErro As String = ""
    Dim intTextBoxLeft As Integer = 0
    Dim bolObrigatorio As Boolean = False
    Dim enuCaseFormato As CaseFormato = CaseFormato.Normal
    Dim bolShowButton As Boolean = False
    Dim intTxtWidth As Integer = 0
    Dim bolDescricao As Boolean = False
    Dim strDescricao As String = ""
    Dim strshowButton As String
    Dim dbldataDataNumberValue As Double
    Dim _IndicaMerchandising As Boolean = False
    Dim bolShowDialog As Boolean = False
    Dim strSqlQuery As String

    Public Event Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Enum CaseFormato
        Normal
        Maiúsculo
        Minúsculo
        Primeira_Maiscula
    End Enum
    Enum CaptionPosition
        Top
        Left
    End Enum
    Enum FormatoSaida
        Numero
        Texto
        CNPJ
        CPF
        CEP
        Data
        Mes_Ano
        Hora
        Hora_Completa
        Data_Extenso
    End Enum
#End Region
#Region "User Control Eventos"
    Public Event Text_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Private Sub UcText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Me.Parent.BackColor
    End Sub
    Public Sub New()
        MyBase.New()
        'Me.Usuario = pUsuario
        'Me.Senha = pSenha
        InitializeComponent()
        btnPesquisa.Image = My.Resources.Search
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub UserControl_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Try
            txtText.BackColor = EnterColor
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub
    Private Sub UserControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        txtText.BackColor = EnterColor
    End Sub
    Private Sub UserControl_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        txtText.BackColor = Leavecolor
        txtText.Text = txtText.Text.Trim
        Me.DataTextValue = ""
        If txtText.Text <> "" Then
            Call FormataSaida()
        End If
    End Sub
    Private Sub UserControl_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        txtText.BackColor = Leavecolor
    End Sub
    Private Sub UserControl_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            If Not bolEmPosicionamento Then
                Call PosicionaObjetos()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub
    Private Sub UserControl_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
        Try
            If Me.Text.Trim = "" Then
                Me.Descricao = ""
            End If

            '======================================================Consiste Obrigatorio
            If Me.Obrigatorio And Me.Text.Trim = "" Then
                Me.MensagemErro = "Campo de Preenchimento Obrigatório"
                Exit Sub
            End If
            '======================================================Consistencias pelo dicionario
            If Me.MensagemErro.Trim = "" And Me.Text.Trim <> "" Then
                Me.Validar()
            End If
            '======================================================Mostra Mensagem de Erro 
            If Me.MensagemErro <> "" Then
                picStatus.BackgroundImage = My.Resources._Error
                picStatus.Visible = True
                picStatus.BringToFront()
                Me.ShowDialog = True
            End If
            If Me.ShowDialog Then
                e.Cancel = True
                txtText.Select(0, txtText.Text.Length)
                bolValido = True
                MsgBox(Me.MensagemErro, MsgBoxStyle.Exclamation, "Atenção")
            End If
            If e.Cancel Then
                txtText.Text = ""
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        Finally
        End Try
    End Sub
    Private Sub UserControl_BackColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        Try
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "BotaoPesquisa Eventos"
    Private Sub btnPesquisa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPesquisa.Click
        Try
            Dim cls As New clsDicionario
            cls.ConfiguraDicionario(Me)
            frmConsulta.sqlQuery = Me.sqlQuery
            frmConsulta.UcObject = Me
            frmConsulta.Dicionario = Me.pDicionario
            

            If Me.pDicionario = enuDicionario.Produto Then
                frmSelecaoProduto.Usuario = Me.Usuario
                frmSelecaoProduto.Senha = Me.Senha
                frmSelecaoProduto.Senha = Me.Senha
                frmSelecaoProduto.txtSegmento.Usuario = Me.Usuario
                frmSelecaoProduto.txtSegmento.Senha = Me.Senha
                frmSelecaoProduto.txtSetor.Usuario = Me.Usuario
                frmSelecaoProduto.txtSetor.Senha = Me.Senha
                frmSelecaoProduto.Cod_Cliente = Me.Cliente
                frmSelecaoProduto.PermiteNovoProduto = Me.PermiteNovoProduto
                frmSelecaoProduto.ShowDialog()
                If frmSelecaoProduto.OkClick Then
                    txtText.Text = frmSelecaoProduto.CodigoProduto
                    txtDescricao.Text = frmSelecaoProduto.NomeProduto
                End If
                frmSelecaoProduto.Dispose()
                Exit Try
            End If

            If Me.pDicionario = enuDicionario.Terceiro_Codigo Then
                frmSelecaoTerceiro.Usuario = Me.Usuario
                frmSelecaoTerceiro.Senha = Me.Senha
                frmSelecaoTerceiro.ShowDialog()
                If frmSelecaoTerceiro.OkClick Then
                    txtText.Text = frmSelecaoTerceiro.Cod_Terceiro
                    txtDescricao.Text = frmSelecaoTerceiro.Razao_Social
                End If
                frmSelecaoTerceiro.Dispose()
                Exit Try
            End If


            If Me.sqlQuery <> "" Then
                frmConsulta.Usuario = Me.Usuario
                frmConsulta.Senha = Me.Senha
                frmConsulta.ShowDialog()
                If frmConsulta.Retorno_1 <> "" Then
                    txtText.Text = frmConsulta.Retorno_1
                    txtDescricao.Text = frmConsulta.Retorno_2
                    If txtText.Visible And txtText.Enabled Then
                        txtText.Focus()
                        SendKeys.Send(vbTab)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw (New Exception(ex.Message))
        Finally
            frmConsulta.Dispose()
        End Try
    End Sub
#End Region
#Region "txtText Eventos"

    Private Sub txtText_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtText.Enter
        Me.MensagemErro = ""
        picStatus.Visible = False
        Me.ShowDialog = False
        Select Case pFormatoSaida
            Case FormatoSaida.CEP
                txtText.Text = txtText.Text.Replace("-", "")
            Case FormatoSaida.CNPJ, FormatoSaida.CPF
                txtText.Text = txtText.Text.Replace("-", "")
                txtText.Text = txtText.Text.Replace(".", "")
                txtText.Text = txtText.Text.Replace("/", "")
            Case FormatoSaida.Data
                txtText.Text = txtText.Text.Replace("/", "")
            Case FormatoSaida.Data_Extenso
                txtText.MaxLength = 10
                txtText.TextAlign = HorizontalAlignment.Left
                bolSomenteNumero = True
            Case FormatoSaida.Hora
                txtText.Text = txtText.Text.Replace(":", "")
            Case FormatoSaida.Hora_Completa
                txtText.Text = txtText.Text.Replace(":", "")
            Case FormatoSaida.Numero
            Case FormatoSaida.Texto
            Case FormatoSaida.Mes_Ano
                txtText.Text = txtText.Text.Replace("/", "")
        End Select
    End Sub
    Private Sub txtText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtText.KeyPress
        Try
            picStatus.Visible = False
            Me.ShowDialog = False
            Me.MensagemErro = ""
            '====================================simula tecla Tab
            If e.KeyChar = ChrW(Keys.Enter) Then
                If bolEnterTab Then
                    SendKeys.Send("{TAB}")
                    e.Handled = True
                    Exit Sub
                End If
            End If
            If e.KeyChar = "'" Then
                e.Handled = True
            End If
            '====================================Verifica somente Numero
            If Not IsNumeric(e.KeyChar) And bolSomenteNumero And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
                e.Handled = True
            End If
            Select Case Me.pCaseformato
                Case CaseFormato.Maiúsculo
                    e.KeyChar = e.KeyChar.ToString.ToUpper
                Case CaseFormato.Minúsculo
                    e.KeyChar = e.KeyChar.ToString.ToLower
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "Propriedades Customizadas"
    <DisplayName("Dicionario"), Description("Confira o objeto conforme padrão do Dicionario"), _
        DefaultValue(""), _
        Category("Custom")> _
Public Property pDicionario() As clsDicionario.enuDicionario
        Get
            pDicionario = strDicionario
        End Get
        Set(ByVal value As clsDicionario.enuDicionario)
            Me.sqlQuery = ""
            strDicionario = value
            Dim cls As New clsDicionario
            cls.ConfiguraDicionario(Me)
        End Set
    End Property
    <DefaultValue(False), Category("Custom"), Browsable(False)> _
    Public Property IndicaMerchandising() As Boolean
        Get
            IndicaMerchandising = _IndicaMerchandising
        End Get
        Set(ByVal value As Boolean)
            _IndicaMerchandising = value
        End Set
    End Property
    <Category("Custom"), Browsable(True)> _
    Public Property TextBoxLeft() As Int16
        Get
            TextBoxLeft = intTextBoxLeft
        End Get
        Set(ByVal value As Int16)
            intTextBoxLeft = value
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("Mostrar Título"), _
    Description("Indica se o título do texto será exibido ou não"), _
    DefaultValue(True), _
    Category("Custom")> _
    Public Property ShowCaption() As Boolean
        Get
            ShowCaption = bolShowCaption
        End Get
        Set(ByVal value As Boolean)
            bolShowCaption = value
            lblCaption.Visible = value
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("Título"), _
    Description("Determina o titulo da caixa de texto"), _
    DefaultValue("Título"), _
    Category("Custom")> _
    Public Property Caption() As String
        Get
            Caption = strCaption
        End Get
        Set(ByVal value As String)
            strCaption = value
            lblCaption.Text = value
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("Posição do Título"), _
    Description("Determina se titulo da caixa de texto será apresentado acima ou a esquerda do texto"), _
    DefaultValue(CaptionPosition.Left), _
    Category("Custom")> _
    Public Property pCaptionPosition() As CaptionPosition
        Get
            pCaptionPosition = enuCaptionPosition

        End Get
        Set(ByVal value As CaptionPosition)
            enuCaptionPosition = value
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("Formatação"), _
    Description("Determina a formatação de apresentação do texto"), _
    DefaultValue(FormatoSaida.Texto), _
    Category("Custom")> _
    Public Property pFormatoSaida() As FormatoSaida
        Get
            pFormatoSaida = enuFormatoSaida
        End Get
        Set(ByVal value As FormatoSaida)
            enuFormatoSaida = value
            Select Case pFormatoSaida
                Case FormatoSaida.CEP
                    txtText.MaxLength = 9
                    txtText.TextAlign = HorizontalAlignment.Left
                    bolSomenteNumero = True
                Case FormatoSaida.CNPJ
                    txtText.MaxLength = 18
                    txtText.TextAlign = HorizontalAlignment.Left
                    bolSomenteNumero = True
                Case FormatoSaida.CPF
                    txtText.MaxLength = 14
                    txtText.TextAlign = HorizontalAlignment.Left
                    bolSomenteNumero = True
                Case FormatoSaida.Data
                    txtText.MaxLength = 10
                    txtText.TextAlign = HorizontalAlignment.Left
                    bolSomenteNumero = True
                Case FormatoSaida.Data_Extenso
                    txtText.MaxLength = 10
                    txtText.TextAlign = HorizontalAlignment.Left
                    bolSomenteNumero = True
                Case FormatoSaida.Hora
                    txtText.MaxLength = 5
                    txtText.TextAlign = HorizontalAlignment.Left
                    bolSomenteNumero = True
                Case FormatoSaida.Hora_Completa
                    txtText.MaxLength = 8
                    txtText.TextAlign = HorizontalAlignment.Left
                    bolSomenteNumero = True
                Case FormatoSaida.Numero
                    txtText.TextAlign = HorizontalAlignment.Right
                    bolSomenteNumero = True
                Case FormatoSaida.Texto
                    txtText.TextAlign = HorizontalAlignment.Left
                    bolSomenteNumero = False
                Case FormatoSaida.Mes_Ano

                    bolSomenteNumero = True
            End Select

        End Set
    End Property
    <DisplayName("Número de Casas Decimais"), _
    Description("Determina o Número de Casas Decimais para Números"), _
    DefaultValue(0), _
    Category("Custom")> _
    Public Property pDecimal() As Byte
        Get
            pDecimal = btDecimal
        End Get
        Set(ByVal value As Byte)
            btDecimal = value
        End Set
    End Property
    <DisplayName("Preenchimento Obrigatório"), _
    Description("Indica se o campo é de preenchimento Obrigatório"), _
    DefaultValue(False), _
    Category("Custom")> _
    Public Property Obrigatorio() As Boolean
        Get
            Obrigatorio = bolObrigatorio
        End Get
        Set(ByVal value As Boolean)
            bolObrigatorio = value
            Call PosicionaObjetos()
        End Set
    End Property

    <DisplayName("Formato do Texto"), _
    Description("Determina o Formato do Texto"), _
    DefaultValue(CaseFormato.Normal), _
    Category("Custom")> _
    Public Property pCaseformato() As CaseFormato
        Get
            pCaseformato = enuCaseFormato
        End Get
        Set(ByVal value As CaseFormato)
            enuCaseFormato = value
        End Set
    End Property
    <DisplayName("Botão de Pesquisa"), _
    Description("Determina se o Botão de Pesquisa estará ativo ou não"), _
    DefaultValue(False), _
    Category("Custom")> _
    Public Property showButton() As Boolean
        Get
            showButton = bolShowButton
        End Get
        Set(ByVal value As Boolean)
            bolShowButton = value
            'btnPesquisa.Visible = value
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("Mostra Descrição"), _
    Description("Indica se será mostrado um texto complementar com a descrição do campo"), _
    DefaultValue(False), _
    Category("Custom")> _
    Public Property ShowDescricao() As Boolean
        Get
            ShowDescricao = bolDescricao
        End Get
        Set(ByVal value As Boolean)
            bolDescricao = value
            'txtDescricao.Visible = False
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("TextWidth"), _
    Description("Determina se o Botão de Pesquisa estará ativo ou não"), _
    DefaultValue(False), _
    Category("Custom")> _
    Public Property TextWidth() As Integer
        Get
            TextWidth = intTxtWidth
        End Get
        Set(ByVal value As Integer)
            intTxtWidth = value
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("Descrição"), _
    Description("Atribui Valor ao Campo Descrição do Controle"), _
    DefaultValue(""), _
    Category("Custom")> _
    Public Property Descricao() As String
        Get
            Descricao = strDescricao
        End Get
        Set(ByVal value As String)
            strDescricao = value
            txtDescricao.Text = value
        End Set
    End Property
    <DisplayName("DataTextValue"), _
    Description("Obtem o Texto do Controle"), _
    DefaultValue(""), _
    Browsable(False), _
    Category("Custom")> _
    Public Property DataTextValue() As String
        Get
            DataTextValue = strshowButton
        End Get
        Set(ByVal value As String)
            strshowButton = value
        End Set
    End Property
    <DisplayName("DataNumberValue"), _
    Description("Obtem o Valor Numero/Decimal do Controle"), _
    DefaultValue(""), _
    Browsable(False), _
    Category("Custom")> _
    Public ReadOnly Property DataNumberValue() As Double
        Get
            If Me.txtText.Text.Trim <> "" Then
                If IsNumeric(Me.txtText.Text) Then
                    Return Double.Parse((txtText.Text.Replace(".", "").Replace(",", "")) / (10 ^ pDecimal))
                Else
                    Return 0
                End If
            Else
                Return 0
            End If

        End Get
    End Property
    <Browsable(True), Category("Custom")> _
    Public Property PasswordChar() As Char
        Get
            Return txtText.PasswordChar
        End Get
        Set(ByVal value As Char)
            txtText.PasswordChar = value
        End Set
    End Property
    <Browsable(True), Category("Custom"), DefaultValue(0)> _
    Public Property MaxLength() As Integer
        Get
            Return txtText.MaxLength
        End Get
        Set(ByVal value As Integer)
            txtText.MaxLength = value
        End Set
    End Property
    <Browsable(False), Category("Custom"), DefaultValue(False)> _
    Public Property ShowDialog() As Boolean
        Get
            ShowDialog = bolShowDialog
        End Get
        Set(ByVal value As Boolean)
            bolShowDialog = value
        End Set
    End Property
    <Browsable(False), Category("Custom"), DefaultValue("")> _
    Public Property sqlQuery() As String
        Get
            sqlQuery = strSqlQuery
        End Get
        Set(ByVal value As String)
            strSqlQuery = value
        End Set
    End Property
    <Browsable(False), Category("Custom"), DefaultValue("")> _
    Public Property MensagemErro() As String
        Get
            MensagemErro = strMensagemErro
        End Get
        Set(ByVal value As String)
            strMensagemErro = value
            Me.ToolTip1.SetToolTip(Me.picStatus, strMensagemErro)
            If strMensagemErro.Trim <> "" Then
                picStatus.Visible = True
                picStatus.BringToFront()
            Else
                picStatus.Visible = False
            End If
        End Set
    End Property
#End Region
#Region "Propriedade Ocultas "
    <Browsable(False)> _
      Overrides Property BackgroundImage() As System.Drawing.Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set(ByVal value As System.Drawing.Image)
            MyBase.BackgroundImage = value
        End Set
    End Property
    <Browsable(False)> _
    Public Overrides Property BackgroundImageLayout() As System.Windows.Forms.ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(ByVal value As System.Windows.Forms.ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property
#End Region
#Region "Overrides"
    <Browsable(True), Category("Custom"), DefaultValue("")> _
    Overrides Property Text() As String
        Get
            Return txtText.Text
        End Get
        Set(ByVal value As String)
            txtText.Text = value
        End Set
    End Property
#End Region
#Region "Subs"
    Public Sub ShowConsulta()
        frmConsulta.sqlQuery = Me.sqlQuery
        frmConsulta.Usuario = Me.Usuario
        frmConsulta.Senha = Me.Senha
        frmConsulta.ShowDialog()
        frmConsulta.Close()
    End Sub
    Public Sub ShowErro()
        MsgBox(Me.MensagemErro, MsgBoxStyle.OkOnly, "Alerta")
        picStatus.BackgroundImage = My.Resources._Error
        Me.ToolTip1.SetToolTip(Me.picStatus, strMensagemErro)
        picStatus.Visible = True
        picStatus.BringToFront()
        Me.Text = ""

    End Sub
    Private Sub PosicionaObjetos()
        Try
            bolEmPosicionamento = True
            If Me.Width <= lblCaption.Width Then
                Me.Width = lblCaption.Width
            End If

            lblCaption.Visible = Me.ShowCaption
            btnPesquisa.Visible = Me.showButton
            txtDescricao.Visible = Me.ShowDescricao

            '======Configura Top e Left do Titulo e Text Principal
            Select Case True
                Case bolShowCaption And pCaptionPosition = CaptionPosition.Top
                    lblCaption.Top = 2
                    lblCaption.Left = 1
                    txtText.Top = lblCaption.Top + lblCaption.Height + 2
                    txtText.Left = 3
                    Me.Height = lblCaption.Top + lblCaption.Height + txtText.Height + 2
                Case bolShowCaption And pCaptionPosition = CaptionPosition.Left
                    lblCaption.Top = 5
                    lblCaption.Left = 1
                    txtText.Top = 3
                    If Me.TextBoxLeft = 0 Then
                        txtText.Left = lblCaption.Left + lblCaption.Width + 3
                    Else
                        txtText.Left = TextBoxLeft
                    End If
                    Me.Height = txtText.Top + txtText.Height + 2
                Case Else
                    Me.Height = txtText.Top + txtText.Height + 2
            End Select

            '======Configura Tamanho do Text Principal 
            If Me.TextWidth = 0 Then
                Select Case True
                    Case showButton And ShowDescricao
                        txtText.Width = ((Me.Width / 2) - btnPesquisa.Width - 1) * 0.4
                    Case showButton
                        txtText.Width = Me.Width - txtText.Left - btnPesquisa.Width - 1
                    Case ShowDescricao
                        txtText.Width = ((Me.Width - 1) / 2) * 0.4
                    Case Else
                        txtText.Width = Me.Width - txtText.Left - 1
                End Select
            Else
                txtText.Width = Me.TextWidth
            End If
            '=============Posiciona objetos
            Select Case True
                Case showButton And ShowDescricao
                    txtDescricao.Left = txtText.Left + txtText.Width + 1
                    txtDescricao.Width = Me.Width - txtDescricao.Left - btnPesquisa.Width - 1
                    btnPesquisa.Left = txtDescricao.Left + txtDescricao.Width + 1
                Case showButton
                    btnPesquisa.Left = txtText.Left + txtText.Width + 1
                Case ShowDescricao
                    txtDescricao.Left = txtText.Left + txtText.Width + 1
                    txtDescricao.Width = Me.Width - txtDescricao.Left - picStatus.Width
                    picStatus.Left = txtDescricao.Left + txtDescricao.Width
                Case Else
                    'picStatus.Left = txtText.Left + txtText.Width
            End Select

            btnPesquisa.Top = txtText.Top - 3
            picStatus.Top = txtText.Top

            picStatus.Left = (txtText.Left + txtText.Width - picStatus.Width) - 1
            'picStatus.Left = (txtText.Left + txtText.Width) + 2
            picStatus.Height = txtText.Height - 4
            picStatus.Top = txtText.Top + 2
            txtText.SendToBack()

            picStatus.BackColor = txtText.BackColor
            picStatus.Visible = False
            txtDescricao.Top = txtText.Top
            bolEmPosicionamento = False

        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
            bolEmPosicionamento = False
        End Try
    End Sub
    Private Sub FormataSaida()
        Try
            bolValido = True
            If txtText.Text.Trim = "" Then
                Exit Sub
            End If
            txtText.Text = txtText.Text.Trim
            Select Case Me.pFormatoSaida
                Case FormatoSaida.CEP
                    txtText.Text = txtText.Text.Replace("-", "")
                    txtText.Text = txtText.Text.PadLeft(8, "0")
                    Me.DataTextValue = txtText.Text

                    txtText.Text = txtText.Text.Substring(0, 5) & "-" & txtText.Text.Substring(5, 3)
                Case FormatoSaida.CNPJ
                    txtText.Text = txtText.Text.Replace("-", "")
                    txtText.Text = txtText.Text.Replace("/", "")
                    txtText.Text = txtText.Text.Replace(".", "")
                    txtText.Text = txtText.Text.PadLeft(14, "0")
                    If Not IsCNPJorCPF(txtText.Text) Then
                        Me.MensagemErro = "CNPJ ou CPF Inválido"
                        Me.ShowDialog = True
                    End If
                    Me.DataTextValue = txtText.Text

                    txtText.Text = txtText.Text.Substring(0, 2) & "." & _
                    txtText.Text.Substring(2, 3) & "." & _
                    txtText.Text.Substring(5, 3) & "/" & _
                    txtText.Text.Substring(8, 4) & "-" & _
                    txtText.Text.Substring(12, 2)
                Case FormatoSaida.CPF
                    txtText.Text = txtText.Text.Replace(".", "")
                    txtText.Text = txtText.Text.PadLeft(11, "0")
                    Me.DataTextValue = txtText.Text
                    If Not IsCNPJorCPF(txtText.Text) Then
                        Me.MensagemErro = "CNPJ ou CPF Inválido"
                        Me.ShowDialog = True
                    End If

                    txtText.Text = txtText.Text.Substring(0, 3) & "." & _
                    txtText.Text.Substring(3, 3) & "." & _
                    txtText.Text.Substring(6, 3) & "." & _
                    txtText.Text.Substring(9, 2)
                
                Case FormatoSaida.Data
                    If Not isData(txtText.Text) Then
                        Me.MensagemErro = "Data Inválida"
                        Me.ShowDialog = True
                    Else
                        txtText.Text = FormataData(txtText.Text)
                        Me.DataTextValue = Format(CDate(txtText.Text), "yyyy/MM/dd")
                    End If
                Case FormatoSaida.Data_Extenso
                    If Not isData(txtText.Text) Then
                        Me.MensagemErro = "Data Inválida"
                        Me.ShowDialog = True
                    Else
                        txtText.Text = FormatDateTime(txtText.Text, DateFormat.LongDate)
                        Me.DataTextValue = Format(txtText.Text, "yyyy/mm/dd")

                    End If
                Case FormatoSaida.Hora
                    If Not Istime(txtText.Text) Then
                        Me.MensagemErro = "Horário Inválido"
                        Me.ShowDialog = True
                    Else
                        txtText.Text = FormataHora(txtText.Text)
                        Me.DataTextValue = txtText.Text

                    End If
                Case FormatoSaida.Hora_Completa
                    If Not Istime(txtText.Text) Then
                        Me.MensagemErro = "Horário Inválido"
                        Me.ShowDialog = True
                    Else
                        txtText.Text = FormatDateTime(txtText.Text, DateFormat.LongTime)
                        Me.DataTextValue = txtText.Text

                    End If
                Case FormatoSaida.Numero
                    txtText.Text = FormataNumero(txtText.Text)
                    Me.DataTextValue = txtText.Text

                Case FormatoSaida.Texto
                    Me.DataTextValue = txtText.Text

                Case FormatoSaida.Mes_Ano
                    txtText.Text = FormataMesAno(txtText.Text)
                    Me.DataTextValue = txtText.Text
                    If Not bolValido Then
                        Me.MensagemErro = "Competência Inválida"
                    End If

            End Select

            Select Case pCaseformato
                Case CaseFormato.Maiúsculo
                    txtText.Text = txtText.Text.ToUpper
                Case CaseFormato.Minúsculo
                    txtText.Text = txtText.Text.ToLower
                Case CaseFormato.Normal
                Case CaseFormato.Primeira_Maiscula
                    txtText.Text = FirstCaps(txtText.Text)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString.ToString)
        End Try
    End Sub
    Public Function isData(ByVal pData As String) As Boolean
        Dim sData As String
        isData = True
        If pData Is Nothing Then
            Exit Function
        End If
        If pData.Trim = "" Then
            Exit Function
        End If
        Dim sDia As String = "", sMes As String = "", sAno As String = ""
        Try
            '=========================Tira as Barras
            sData = pData.Replace("/", "") & Space(4)
            sDia = sData.Substring(0, 2)
            sMes = sData.Substring(2, 2)
            sAno = sData.Substring(4, 4)
            If Val(sAno) < 1000 Then
                sAno = 2000 + Val(sAno).ToString
            End If
            sData = sDia & "/" & sMes & "/" & sAno
            sData = FormatDateTime(sData, DateFormat.ShortDate)

        Catch ex As Exception
            isData = False
        End Try
    End Function
    Public Function IsCNPJorCPF(ByVal sCgc As String)
        Dim sNumeroCgc As String
        Dim sDigitoCgc As String
        Dim nSomaDigito As Integer
        Dim nContDigito As Integer
        Dim nBase As Integer
        Dim nResto As Integer
        sCgc = Trim(sCgc)
        If Len(sCgc) < 8 Then
            IsCNPJorCPF = False
            Exit Function
        End If


        sDigitoCgc = sCgc.Substring(sCgc.Length - 2, 2)
        sNumeroCgc = sCgc.Substring(0, sCgc.Length - 2)

        Do Until Len(sNumeroCgc) = Len(sCgc)
            nBase = 2
            nSomaDigito = 0
            For nContDigito = sNumeroCgc.Length To 1 Step -1
                nSomaDigito = nSomaDigito + (Val(Mid(sNumeroCgc, nContDigito, 1))) * nBase
                If Len(sCgc) = 14 Then
                    nBase = IIf(nBase = 9, 2, nBase + 1)
                Else
                    nBase = nBase + 1
                End If
            Next nContDigito
            nResto = 11 - (nSomaDigito Mod 11)

            nResto = IIf(nResto > 9, 0, nResto)
            sNumeroCgc = sNumeroCgc & Trim(str(nResto))
        Loop
        If sNumeroCgc.Substring(sNumeroCgc.Length - 2, 2) = sDigitoCgc Then
            IsCNPJorCPF = True
        Else
            IsCNPJorCPF = False
        End If
    End Function
    Public Function IsCNPJorCPFxxx(ByVal sCGC As String) As Boolean
        Dim sNumeroCgc As String
        Dim sDigitoCgc As String
        Dim nSomaDigito As Integer
        Dim nContDigito As Integer
        Dim nBase As Integer
        Dim nResto As Integer
        Try
            sCGC = Trim(sCGC)
            If Len(sCGC) < 8 Then
                IsCNPJorCPFxxx = False
                Exit Function
            End If
            sDigitoCgc = StrRight(sCGC, 2)
            sNumeroCgc = StrLeft(sCGC, Len(sCGC) - 2)

            Do Until Len(sNumeroCgc) = Len(sCGC)
                nBase = 2
                nSomaDigito = 0
                For nContDigito = Len(sNumeroCgc) To 1 Step -1
                    nSomaDigito = nSomaDigito + (Val(Mid(sNumeroCgc, nContDigito, 1))) * nBase
                    If Len(sCGC) = 14 Then
                        nBase = IIf(nBase = 9, 2, nBase + 1)
                    Else
                        nBase = nBase + 1
                    End If
                Next nContDigito
                nResto = 11 - (nSomaDigito Mod 11)

                nResto = IIf(nResto > 9, 0, nResto)
                sNumeroCgc = sNumeroCgc & Trim(Str(nResto))
            Loop
            If StrRight(sNumeroCgc, 2) = sDigitoCgc Then
                IsCNPJorCPFxxx = True
            Else
                IsCNPJorCPFxxx = False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Private Function Istime(ByVal strTime As String) As Boolean
        Dim strtimeSeparador As String = Globalization.CultureInfo.CurrentCulture.DateTimeFormat.TimeSeparator
        Try
            strTime = strTime.Trim
            Dim strHora As String
            Dim strMinuto As String
            Dim strSegundo As String
            Istime = True
            strTime = strTime.Replace(strtimeSeparador, "")
            strTime = strTime.Trim
            strTime = strTime.Replace(" ", "")
            Select Case strTime.Length
                Case 1, 2
                    strHora = Val(strTime).ToString
                    strMinuto = 0
                    strSegundo = 0
                Case Else
                    strTime = strTime.PadRight(6, "0")
                    strHora = strTime.Substring(0, 2)
                    strMinuto = strTime.Substring(2, 2)
                    strSegundo = strTime.Substring(4, 2)
            End Select
            Select Case True
                Case Val(strHora) > 23 And Val(strMinuto) > 59
                    Istime = False
                Case Val(strHora) > 24 Or Val(strMinuto) > 59 Or Val(strSegundo) > 59
                    Istime = False
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Function
    Public Function StrLeft(ByVal str As String, ByVal index As Integer) As String
        StrLeft = str.Substring(0, index)
    End Function
    Public Function StrRight(ByVal str As String, ByVal index As Integer) As String
        StrRight = str.Substring(str.Length - index)
    End Function
    Private Function FormataNumero(ByVal strNumero As String) As String
        Dim dbNumber As Double = 0
        Try
            dbNumber = CDbl(strNumero)
            dbNumber = dbNumber / (10 ^ pDecimal)
            FormataNumero = String.Format("{0:N" & Me.pDecimal & "}", dbNumber)
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Function
    Private Function FormataMesAno(ByVal strTexto As String) As String
        FormataMesAno = ""
        Try
            Dim strMes As String = ""
            Dim strAno As String = ""
            Select Case strTexto.Length
                Case Is < 4
                    bolValido = False
                Case 4
                    strMes = strTexto.Substring(0, 2)
                    strAno = "20" & strTexto.Substring(2, 2)
                Case 5
                    strMes = strTexto.Substring(0, 2)
                    strAno = "2" & strTexto.Substring(2, 3)
                Case 6
                    strMes = strTexto.Substring(0, 2)
                    strAno = strTexto.Substring(2, 4)
                Case Is > 4
                    bolValido = False
            End Select
            If Val(strMes) > 12 Then
                bolValido = False
            End If

            If bolValido Then
                FormataMesAno = strMes & "/" & strAno
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Function
    Function FirstCaps(ByVal cText)
        Dim strChar As String, lFirst As Boolean
        Dim cRetVal As String
        Dim nCont As Int16
        FirstCaps = cText
        Try
            lFirst = True
            cRetVal = ""

            For nCont = 1 To Len(cText)
                strChar = Mid(cText, nCont, 1)

                If lFirst Then
                    cRetVal = cRetVal + UCase(strChar)
                    lFirst = False
                Else
                    cRetVal = cRetVal + LCase(strChar)
                End If

                If strChar = " " Then
                    lFirst = True
                End If
            Next

            cRetVal = Replace(cRetVal, " Sr ", " SR ")
            cRetVal = Replace(cRetVal, " Pl ", " PL ")
            cRetVal = Replace(cRetVal, " Jr ", " JR ")

            cRetVal = Replace(cRetVal, " Ii ", " II ")
            cRetVal = Replace(cRetVal, " Iii ", " III ")

            cRetVal = Replace(cRetVal, " S/a ", " S/A ")

            cRetVal = Replace(cRetVal, " E ", " e ")
            cRetVal = Replace(cRetVal, " O ", " o ")
            cRetVal = Replace(cRetVal, " A ", " a ")
            cRetVal = Replace(cRetVal, " De ", " de ")
            cRetVal = Replace(cRetVal, " Da ", " da ")
            cRetVal = Replace(cRetVal, " Do ", " do ")
            cRetVal = Replace(cRetVal, " Das ", " das ")
            cRetVal = Replace(cRetVal, " Dos ", " dos ")
            FirstCaps = cRetVal
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    Public Function FormataData(ByVal pData As String) As String
        Dim sData As String
        FormataData = ""
        If pData.Trim = "" Then
            Exit Function
        End If
        Dim sDia As String = "", sMes As String = "", sAno As String = ""
        Try
            '=========================Tira as Barras
            sData = pData.Replace("/", "") & Space(4)
            sDia = sData.Substring(0, 2)
            sMes = sData.Substring(2, 2)
            sAno = sData.Substring(4, 4)
            If Val(sAno) < 1000 Then
                sAno = 2000 + Val(sAno).ToString
            End If
            sData = sDia & "/" & sMes & "/" & sAno
            'sData = FormatDateTime(sData, DateFormat.ShortDate)
            Return sData
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function formataHora(ByVal pHora As String) As String
        Dim btHora As Byte
        Dim btMinuto As Byte
        formataHora = String.Empty
        Try
            pHora = pHora.Replace(":", "")
            pHora = pHora.PadLeft(4, "0")
            btHora = pHora.Substring(0, 2)
            btMinuto = pHora.Substring(2, 2)
            formataHora = btHora.ToString.PadLeft(2, "0") + ":" + btMinuto.ToString.PadLeft(2, "0")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub Validar()
        Try
            Dim cls As clsDicionario = New clsDicionario
            If Me.pDicionario <> enuDicionario.Nenhum Then
                Call cls.fnValidar(Me)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#Region "Eventos Customizados"
    Private Sub txtText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtText.TextChanged
        RaiseEvent Text_Changed(sender, e)
        If txtText.Text.ToString.Trim = "" Then
            Me.Descricao = ""
        End If
        If txtText.Text <> "" Then
            picStatus.Visible = False
        End If
    End Sub

#End Region

    Private Sub btnPesquisa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPesquisa.GotFocus

    End Sub
End Class
