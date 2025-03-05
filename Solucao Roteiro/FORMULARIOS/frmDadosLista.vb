Public Class frmDadosLista
    Private _QueryDataSource As String = ""
    Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
    Dim dtDados As DataSet = New DataSet()
    Public Property QueryDataSource() As String
        Get
            QueryDataSource = _QueryDataSource
        End Get
        Set(ByVal value As String)
            _QueryDataSource = value
            dtDados = clsGeneric.fnSqlExecute(_QueryDataSource)
            gridDados.DataSource = dtDados.Tables(0)


        End Set
    End Property
    Private Sub frmDadosLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        frmDadosLista_Resize(New Object, New System.EventArgs)
    End Sub

    Private Sub frmDadosLista_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With gridDados
            .Width = Me.Width - 20
            .Height = Me.Height - 50
            .Top = 5
            .Left = 5
        End With
    End Sub
End Class