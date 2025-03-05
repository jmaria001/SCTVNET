Public Class frmImpressao

    Private Sub frmReport_Roteiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
    End Sub

    Public Sub New()
        InitializeComponent()
        ' Me.MdiParent = mdiPrincipal

    End Sub

    Private Sub crvImpressao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvImpressao.Load

    End Sub
End Class