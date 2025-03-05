Public Class frmSolucaoAM
    Public Cod_Empresa As String
    Public NumeroMr As Int32
    Public SequenciaMr As Short
    Public Numero_Docto As String
    Public Solucionado As Boolean = False

    Private Sub btnSolucao_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSolucao.Ok_Click
        Dim strSolucao As String = ""
        Dim cls As MSAClass.AsmxAM.asmxAM = NewAM()
        Try
            Select Case True
                Case optPonderar.Checked
                    strSolucao = "P"
                Case optDeduzir.Checked
                    strSolucao = "D"
                Case optCreditar.Checked
                    strSolucao = "C"
                Case optFaturar.Checked
                    strSolucao = "F"
                Case optFaturarSemCredito.Checked
                    strSolucao = "S"
            End Select
            If strSolucao.Trim = "" Then
                Aviso("Nenhum Solução foi Informada")
            End If
            Solucionado = cls.Solucao(Cod_Empresa, NumeroMr, SequenciaMr, Numero_Docto, strSolucao, gsUsuario)
            Me.Hide()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnSolucao_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolucao.Cancel_Click
        Me.Hide()
    End Sub

    Private Sub frmSolucaoAM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
    End Sub
End Class
