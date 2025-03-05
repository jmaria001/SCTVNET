Public Class frmProdutoCadastro
    Public Usuario As String = ""
    Public Senha As String = ""
    Public Cliente As String = ""
    Public OkClick As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmProdutoCadastro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    End Sub

    Private Sub frmProdutoCadastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        ucSetor.sqlQuery = "EXECUTE PrNet_Produto_L  NULL,1"
        ucSegmento.sqlQuery = "EXECUTE PrNet_Produto_L  NULL,2"
        ucSetor.Usuario = Me.Usuario
        ucSegmento.Usuario = Me.Usuario
        ucSetor.Senha = Me.Senha
        ucSegmento.Senha = Me.Senha
    End Sub

    Private Sub ucSetor_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucSetor.Enter
        ucSetor.Tag = ucSetor.Text
    End Sub



    Private Sub ucSetor_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucSetor.Validated
        Try
            If ucSetor.Text <> ucSetor.Tag Then
                ucSegmento.Text = ""
                ucSegmento.Descricao = ""
            End If
            If ucSetor.Text.Trim <> "" Then
                ucSegmento.sqlQuery = "EXECUTE PrNet_Produto_Root_L " & ucSetor.DataNumberValue
            Else
                ucSetor.sqlQuery = "EXECUTE PrNet_Produto_L  NULL,2"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnProduto_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProduto.Cancel_Click
        Me.Hide()
    End Sub
    Private Sub btnProduto_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProduto.Ok_Click
        Dim clsProduto As MSAClass.AsmxProduto.asmxProduto = NewProduto(Me.Usuario, Me.Senha)
        Try
            If ucSetor.Text.Trim = "" Or ucSegmento.Text.Trim = "" Or ucProduto.Text.Trim = "" Then
                MsgBox("Setor, Segmento e Produto devem ser preenchidos")
                Exit Try
            End If
            If clsProduto.IncluirProduto(ucSetor.Text, ucSegmento.Text, ucProduto.Text, ucHorario.Text, Me.Cliente) Then

                Me.OkClick = True
                Me.Hide()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


End Class