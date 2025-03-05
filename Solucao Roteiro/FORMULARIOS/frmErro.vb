Public Class frmErro
    Dim _ex As Exception

    Public Property Excepction() As Exception
        Get
            Excepction = _ex
        End Get
        Set(ByVal value As Exception)
            _ex = value
        End Set
    End Property

    Private Sub btnErro_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnErro.Ok_Click
        'Dim strBody As String
        'Dim cls As New MSAClass.GENERIC.asmxGeneric
        Try
            'If chkMail.Checked Then
            'strBody = "Descrição do Erro" & vbCr & vbCr
            'strBody += Me.Excepction.ToString
            'If Not cls.fnSendEmail("", "", "", "", strBody) Then

            'End If
        Catch ex As Exception
            Aviso(ex.Message.ToString)
        End Try
        Me.Dispose()
    End Sub

    Private Sub frmErro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
        txtErro.BorderStyle = BorderStyle.FixedSingle
        'txtErro.BackColor = Me.BackColor
    End Sub

    Private Sub btnErro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErro.Load
        'Throw New Exception(Me.Excepction.Message)
    End Sub
End Class