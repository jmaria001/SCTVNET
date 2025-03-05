Public Class frmComercial
    Dim bolOkClick As Boolean
    Dim ArrayRestrito As ArrayList
    Dim strCodigoCliente As String
    Public Caracteristica_Contrato As String
    Public Property OkClick() As Boolean
        Get
            OkClick = bolOkClick
        End Get
        Set(ByVal value As Boolean)
            bolOkClick = value
        End Set
    End Property
    Public Property CodigoCliente() As String
        Get
            CodigoCliente = strCodigoCliente
        End Get
        Set(ByVal value As String)
            strCodigoCliente = value
            txtProduto.Cliente = value
        End Set
    End Property
    Public Property CodigoRestrito() As ArrayList
        Get
            CodigoRestrito = ArrayRestrito
        End Get
        Set(ByVal value As ArrayList)
            ArrayRestrito = value
        End Set
    End Property

    Private Sub frmComercial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        txtProduto.PermiteNovoProduto = True
        Me.CenterToScreen()
    End Sub
    Private Sub btnComercial_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComercial.Cancel_Click
        Me.OkClick = False
        Me.Hide()
    End Sub
    Private Sub btnComercial_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComercial.Ok_Click
        Dim bolErro As Boolean = False
        Dim Cls As MSAClass.AsmxContrato.asmxContrato = NewContrato()
        Try
            '==================Consiste Campos Obrigatorios
            For Each obj As Object In fraComercial.Controls
                If TypeOf (obj) Is WUC.UcText Then
                    If obj.Obrigatorio And obj.Text.Trim = "" Then
                        obj.MensagemErro = "Campo de Preenchimento Obrigatório"
                        bolErro = True
                    End If
                End If
            Next
            '==================Consiste se Codigo é Restrito
            If Not Me.CodigoRestrito Is Nothing Then
                For x As Integer = 0 To Me.CodigoRestrito.Count - 1
                    If Not Me.CodigoRestrito.Item(x) Is Nothing Then
                        If txtCodigo.Text.Trim = Me.CodigoRestrito.Item(x).ToString.Trim Then
                            txtCodigo.MensagemErro = "Código ja existe para o Contrato"
                            bolErro = True
                        End If
                    End If
                Next
            End If
            '==================Consiste se Código é um produto do Nivel 3
            If Not bolErro Then
                bolOkClick = True
                Me.Hide()
            Else
                Aviso("Existem Campos Inconsistentes!" & vbCr & "Passe o Mouse sobre a marca  de erro para verificar")
            End If

        Catch ex As Exception
            ShowErro(ex)
        Finally
        End Try
    End Sub

    Private Sub txtTipoComercial_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoComercial.Enter
        txtTipoComercial.Tag = txtTipoComercial.Text
    End Sub

    'Private Sub btnProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduto.Click
    '    Try
    '        frmSelecaoProduto.Cod_Cliente = Me.CodigoCliente
    '        frmSelecaoProduto.ShowDialog()
    '        If frmSelecaoProduto.OkClick Then
    '            txtProduto.Text = frmSelecaoProduto.CodigoProduto
    '            txtProduto.Descricao = frmSelecaoProduto.NomeProduto
    '        End If
    '        frmSelecaoProduto.Dispose()
    '    Catch ex As Exception
    '        ShowErro(ex)
    '    End Try

    'End Sub

    Private Sub txtTipoComercial_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoComercial.Validating
        Try
            If txtTipoComercial.Text.Trim = "" Then
                Exit Try
            End If
            If txtTipoComercial.Tag = txtTipoComercial.Text Then
                Exit Try
            End If

            If Me.Caracteristica_Contrato = "MER" Then
                If Not txtTipoComercial.IndicaMerchandising Then
                    Aviso("Quando a Caracteristica de Contrato for Merchandising, somente tipo de comerciais que indiquem merchandising são permitidos")
                    e.Cancel = True

                End If
            Else
                If txtTipoComercial.IndicaMerchandising Then
                    Aviso("Esse tipo de Comercial somente é permitido quando caracteristica de contrato for Merchandising")
                    e.Cancel = True
                End If
            End If

        Catch ex As Exception
            ShowErro(ex)
        Finally
            If e.Cancel Then
                txtTipoComercial.Text = ""
                txtTipoComercial.Descricao = ""
                txtTipoComercial.IndicaMerchandising = False
            End If
        End Try
    End Sub
End Class