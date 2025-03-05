Public Class frmTerceiroMotivoCancelamento
    Dim bolOkClik As Boolean = False
    Public Property OkClick() As Boolean
        Get
            OkClick = bolOkClik
        End Get
        Set(ByVal value As Boolean)
            bolOkClik = value
        End Set
    End Property
    Private Sub frmTerceiroMotivoCancelamento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
    End Sub

    Private Sub btnOkCancel_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        txtMotivoCancelamento.Text = ""
        Me.OkClick = False
        Me.Hide()
    End Sub

    Private Sub btnOkCancel_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Me.OkClick = True
        Me.Hide()
    End Sub
End Class