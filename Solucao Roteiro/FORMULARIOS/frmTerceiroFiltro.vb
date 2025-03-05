Public Class frmTerceiroFiltro
    Public Codigo As String = ""
    Public RazaoSocial As String = ""
    Public NomeFantasia As String = ""
    Public CNPJ As String = ""
    Public Municipio As String = ""
    Public Funcao As Short = 0
    Public OkClick As Boolean = False

    Private Sub frmTerceiroFiltro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
    End Sub

    Private Sub btnFIltro_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFIltro.Cancel_Click
        Me.Hide()
    End Sub

    Private Sub btnFIltro_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFIltro.Ok_Click

        Dim bolValido As Boolean
        Try
            For Each obj As Object In Me.groupFiltro.Controls
                If TypeOf (obj) Is WUC.UcText Then
                    If obj.text.ToString.Trim <> "" Then
                        bolValido = True
                        Exit For
                    End If
                End If
            Next

            If Not bolValido Then
                Aviso("Nenhum Filtro foi Informado")
            End If

            Me.Codigo = ucCodigo.Text
            Me.RazaoSocial = ucRazaoSocial.Text
            Me.NomeFantasia = ucNomeFantasia.Text
            Me.Municipio = ucMunicipio.Text
            Me.CNPJ = ucCNPJ.Text
            Me.Funcao = ucFuncao.DataNumberValue
            Me.OkClick = True
            Me.Hide()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.CenterToScreen()

    End Sub

    Private Sub btnFIltro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFIltro.Load

    End Sub
End Class