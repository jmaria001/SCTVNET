Imports System.Exception
Imports System.Windows.Forms
Imports system.Drawing.Color
Imports System.ComponentModel
Imports WUC.clsDicionario
Public Class ucButton
#Region "Declaracoes"

    Dim bolOkVisible As Boolean = True
    Dim bolCancelVisible As Boolean = True
    Dim bolOkEnable As Boolean = True
    Dim bolCancelEnable As Boolean = True
    Dim strOkText As String = "Ok"
    Dim strCancelText As String = "Cancela"
    Dim bolOk
    Public Event Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
#End Region
#Region "UcButton Eventos"
    Private Sub ucBotaoOkCancel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Call PosicionaObjetos()
    End Sub
    Private Sub ucBotaoOkCancel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackColor = Me.Parent.BackColor
    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        RaiseEvent Cancel_Click(sender, e)
    End Sub
    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        RaiseEvent Ok_Click(sender, e)
    End Sub
#End Region
#Region "ProPriedades Customizadas"
    <DisplayName("BotaoOkVisible"), Description(""), DefaultValue(True), Category("Custom")> _
  Public Property BotaoOkVisible() As Boolean
        Get
            BotaoOkVisible = bolOkVisible
        End Get
        Set(ByVal value As Boolean)
            bolOkVisible = value
            btnOk.Visible = value
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("BotaoCancelVisible"), Description(""), DefaultValue(True), Category("Custom")> _
    Public Property BotaoCancelVisible() As Boolean
        Get
            BotaoCancelVisible = bolCancelVisible
        End Get
        Set(ByVal value As Boolean)
            bolCancelVisible = value
            btnCancel.Visible = value
            Call PosicionaObjetos()
        End Set
    End Property
    <DisplayName("OkText"), Description(""), DefaultValue("Ok"), Category("Custom")> _
    Public Property OkText() As String
        Get
            OkText = strOkText
        End Get
        Set(ByVal value As String)
            If value.Trim <> "" Then
                strOkText = value
            Else
                strOkText = "Ok"
            End If
            btnOk.Text = value
        End Set

    End Property
    <DisplayName("CancelaText"), Description(""), DefaultValue("Cancela"), Category("Custom")> _
    Public Property CancelaText() As String
        Get
            CancelaText = strCancelText
        End Get
        Set(ByVal value As String)
            If value.Trim <> "" Then
                strCancelText = value
            Else
                strCancelText = "Ok"
            End If
            btnCancel.Text = value
        End Set
    End Property
    <DisplayName("BotaoCancelEnable"), Description(""), DefaultValue(True), Category("Custom")> _
    Public Property BotaoCancelEnable() As Boolean
        Get
            BotaoCancelEnable = bolCancelEnable
        End Get
        Set(ByVal value As Boolean)
            bolCancelEnable = value
            btnCancel.Enabled = bolCancelEnable
        End Set
    End Property
    <DisplayName("BotaoOkEnable"), Description(""), DefaultValue(True), Category("Custom")> _
    Public Property BotaoOkEnable() As Boolean
        Get
            BotaoOkEnable = bolOkEnable
        End Get
        Set(ByVal value As Boolean)
            bolOkEnable = value
            btnOk.Enabled = bolOkEnable
        End Set
    End Property
#End Region
#Region "Subs"
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Call PosicionaObjetos()
    End Sub
    Private Sub PosicionaObjetos()
        Try
            btnOk.Visible = Me.BotaoOkVisible
            btnCancel.Visible = Me.BotaoCancelVisible
            Me.Height = btnOk.Top + btnOk.Height + btnOk.Top
            Select Case True
                Case Me.BotaoOkVisible And Me.BotaoCancelVisible
                    btnOk.Left = 0
                    btnCancel.Left = btnOk.Left + btnOk.Width + 7
                    Me.Width = btnCancel.Left + btnCancel.Width
                Case Me.BotaoOkVisible
                    btnOk.Left = 0
                    Me.Width = btnOk.Left + btnOk.Width
                Case Me.BotaoCancelVisible
                    btnCancel.Left = 0
                    Me.Width = btnCancel.Left + btnCancel.Width
                Case Else
                    Me.Width = btnCancel.Left + btnCancel.Width
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub
#End Region


End Class
