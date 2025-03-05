Public Class frmAmFiltro
    Public OkClick As Boolean = False
    Private Sub frmAmFiltro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        LimpaCampos(Me)
    End Sub

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub btnAM_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAM.Cancel_Click
        OkClick = False
        Me.Hide()
    End Sub

    Private Sub btnAM_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAM.Ok_Click
        OkClick = True
        Me.Hide()
    End Sub
End Class