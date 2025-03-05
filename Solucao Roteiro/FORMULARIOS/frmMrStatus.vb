Public Class frmMrStatus


    Private Sub lblSequencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSequencia.Click

    End Sub

    Private Sub frmMrStatus_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmMrStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
        frmMapaReserva.Dispose()
        frmMapaReserva.Show()
    End Sub

    Private Sub btnHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistorico.Click
        Try
            frmMRConsulta.nContrato = lblContrato.Text
            frmMRConsulta.nSequencia = lblSequencia.Text
            frmMRConsulta.LoadFromManutencao = True
            frmMRConsulta.Consulta_Ativa()
            frmMRConsulta.Show()
            frmMapaReserva.Dispose()
            Me.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        frmMapaReserva.Dispose()
        Me.Close()
    End Sub
End Class