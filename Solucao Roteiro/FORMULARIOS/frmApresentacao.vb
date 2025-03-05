Option Strict Off
Option Explicit On
Friend Class frmApresentacao
	Inherits System.Windows.Forms.Form
    Dim clsGeneric As MSAClass.asmxGeneric.asmxGeneric = NewGeneric()
    Dim dtbMural As DataSet
    Public bolMostraMensagem As Boolean
    Private Sub CarregaMensagem()
        On Error GoTo Erro
        Dim nAviso As Short
        Dim nNovidade As Short
        Dim nTotal As Short
        Dim rtfAviso As String
        Dim rtfNovidade As String
        Dim strComando As String = ""
        strComando = "Execute sp_Mural_Apresentacao '" & gsUsuario & "'"
        dtbMural = clsGeneric.fnSqlExecute(strComando)
        nTotal = -1

        If dtbMural.Tables(0).Rows.Count = 0 Then
            bolMostraMensagem = False
            Exit Sub
        End If
        bolMostraMensagem = True
        For Each adors As DataRow In dtbMural.Tables(0).Rows
            nTotal = nTotal + 1


            If adors("Quadro") = 0 Then
                nAviso = nAviso + 1
                If nAviso = 1 Then
                    rtAviso.SelectedRtf = adors("Mensagem")
                Else
                    rtAviso.SelectionStart = Len(rtAviso.Rtf)
                    rtAviso.SelectedRtf = adors("Mensagem") & vbCrLf
                End If
            End If

            If adors("Quadro") = 1 Then
                nNovidade = nNovidade + 1
                If nNovidade = 1 Then
                    rtNovidades.SelectedRtf = adors("Mensagem")
                Else
                    rtNovidades.SelectionStart = Len(rtNovidades.Rtf)
                    rtNovidades.SelectedRtf = adors("Mensagem") & vbCrLf
                End If
            End If
        Next

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        On Error GoTo Erro
        Dim strComando As String

        For Each Drw As DataRow In dtbMural.Tables(0).Rows
            strComando = "Execute Sp_Mural_Baixa " & Drw("Id_Mensagem")
            clsGeneric.fnSqlComando(strComando)
        Next
        Me.Dispose()
Saida:
        Exit Sub
Erro:
        Me.Dispose()
    End Sub

    Private Sub frmApresentacao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmApresentacao_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Width = 643
        Me.Height = 557
        Me.Top = 50
        Me.Left = 200
        Me.CenterToParent()
        Call CarregaMensagem()
    End Sub

    
End Class