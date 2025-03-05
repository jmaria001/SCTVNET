Public Class frmProdutoCadastro

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmProdutoCadastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        SetaUserControl(Me)
        ucSetor.sqlQuery = "EXECUTE PrNet_Produto_L  NULL,1"
        ucSegmento.sqlQuery = "EXECUTE PrNet_Produto_L  NULL,2"
    End Sub

    Private Sub ucSetor_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucSetor.Validated
        Try
            If ucSetor.Text.Trim = "" Then
                ucSegmento.sqlQuery = "EXECUTE PrNet_Produto_Root_L " & ucSetor.DataNumberValue
            Else
                ucSetor.sqlQuery = "EXECUTE PrNet_Produto_L  NULL,2"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduto.Load

    End Sub

    Private Sub ucSegmento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucSegmento.Load

    End Sub
End Class