
Public Class frmUsuario_AlterarSenha
    Dim strUsuario As String
    Public Property prUsuario() As String
        Get
            prUsuario = strUsuario
        End Get
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property
    Private Sub cmdCancelarSenha_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelarSenha.Click
        Try
            picAcesso.Enabled = True
            txtSenha1.Text = ""
            txtSenha2.Text = ""
            Me.Dispose()
        Catch ex As Exception
            Throw New ExecutionEngineException(ex.Message)
        End Try
    End Sub
    Private Sub cmdOkSenha_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOkSenha.Click
        Dim aCampos(0) As Object
        Dim aValores(0) As Object
        Dim clsUsuario As MSAClass.AsmxUsuario.asmxUsuario = NewUsuario()
        Try
            If UCase(Trim(txtSenha1.Text)) <> UCase(Trim(txtSenha2.Text)) Then
                Aviso("Senhas não conferem.Entre novamente ")
                txtSenha1.Text = ""
                txtSenha2.Text = ""
                txtSenha1.Focus()
                Exit Sub
            End If
            If clsUsuario.fnAlterarSenha(Me.prUsuario, Criptografia.Funcoes.Criptografar(txtSenha1.Text)) Then
                Aviso("Sua solicitação foi gravada e no máximo em dois minutos sua nova senha será validada")
            Else
                Aviso("Houve erro durante a alteração da Senha. Comunique o Suporte Responsavel")
                Exit Sub
            End If
            cmdCancelarSenha.PerformClick()
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub frmUsuario_AlterarSenha_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSenha1.Focus()
    End Sub

    Private Sub frmUsuario_AlterarSenha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
    End Sub
End Class