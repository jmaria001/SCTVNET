Public Class frmSelecaoMapa
    Dim bolOkClick As Boolean
    Dim strCodEmpresa As String
    Dim intNumeroMr As Int32
    Dim shtSequenciaMr As Short
    Dim _enuOperacao As enuOperacao
    Enum enuOperacao
        Nova_Sequencia
        Editar
    End Enum
    Public Property Operacao() As enuOperacao
        Get
            Operacao = _enuOperacao
        End Get
        Set(ByVal value As enuOperacao)
            _enuOperacao = value
            Select Case Operacao
                Case enuOperacao.Nova_Sequencia
                    txtSequenciaMr.Visible = False
                Case enuOperacao.Editar
                    txtSequenciaMr.Visible = True
            End Select
        End Set
    End Property
    Public Property OkCLik() As Boolean
        Get
            OkCLik = bolOkClick
        End Get
        Set(ByVal value As Boolean)
            bolOkClick = value
        End Set
    End Property
    Public Property CodEmpresa() As String
        Get
            CodEmpresa = strCodEmpresa
        End Get
        Set(ByVal value As String)
            strCodEmpresa = value
        End Set
    End Property
    Public Property Numero_Mr() As Int32
        Get
            Numero_Mr = intNumeroMr
        End Get
        Set(ByVal value As Int32)
            intNumeroMr = value
        End Set
    End Property
    Public Property Sequencia_Mr() As Short
        Get
            Sequencia_Mr = shtSequenciaMr
        End Get
        Set(ByVal value As Short)
            shtSequenciaMr = value
        End Set
    End Property
    Private Sub btnOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.OkCLik = False
        Me.CodEmpresa = Nothing
        Me.Numero_Mr = Nothing
        Me.Sequencia_Mr = Nothing
        Me.Hide()
    End Sub
    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Try
            Dim clsContrato As MSAClass.AsmxContrato.asmxContrato = NewContrato()
            Select Case Me.Operacao
                Case enuOperacao.Editar
                    If txtCodEmpresa.Text.Trim = "" Or txtNumeroMr.Text.Trim = "" Or txtSequenciaMr.Text.Trim = "" Then
                        Aviso("Todos os campos devem ser preenchidos")
                    End If
                    Me.CodEmpresa = txtCodEmpresa.Text
                    Me.Numero_Mr = txtNumeroMr.DataNumberValue
                    Me.Sequencia_Mr = txtSequenciaMr.DataNumberValue
                    If Not clsContrato.fnExisteMr(Me.CodEmpresa, Me.Numero_Mr, Me.Sequencia_Mr) Then
                        Aviso("Contrato Inexistente")
                        Exit Try
                    End If
                Case enuOperacao.Nova_Sequencia
                    If txtCodEmpresa.Text.Trim = "" Or txtNumeroMr.Text.Trim = "" Then
                        Aviso("Todos os campos devem ser preenchidos")
                    End If
                    Me.CodEmpresa = txtCodEmpresa.Text
                    Me.Numero_Mr = txtNumeroMr.DataNumberValue
                    txtSequenciaMr.Text = clsContrato.fnUltimaSequencia(Me.CodEmpresa, Me.Numero_Mr)
                    Me.Sequencia_Mr = txtSequenciaMr.DataNumberValue
                    txtSequenciaMr.Text = clsContrato.fnUltimaSequencia(txtCodEmpresa.Text, txtNumeroMr.Text)
                    If Me.txtSequenciaMr.Text.Trim = "0" Then
                        Aviso("Contrato Inexistente")
                        Exit Try
                    End If
            End Select
            Me.OkCLik = True
            Me.Hide()
        Catch ex As Exception

            ShowErro(ex)
        End Try
    End Sub

    Private Sub frmSelecaoMapa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
        txtCodEmpresa.Usuario = gsUsuario
    End Sub

    
    Private Sub btnOkCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Load

    End Sub
End Class