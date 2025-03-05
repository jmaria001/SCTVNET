Option Strict Off
Option Explicit On
Friend Class frmDiretorio
	Inherits System.Windows.Forms.Form
	
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		txtDiretorio.Text = ""
		cmdOk_Click(cmdOk, New System.EventArgs())
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Me.Hide()
	End Sub
	
	
	Private Sub dirDiretorio_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dirDiretorio.Change
		txtDiretorio.Text = dirDiretorio.Path
	End Sub
	
	Private Sub dirDiretorio_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dirDiretorio.SelectedIndexChanged
		txtDiretorio.Text = dirDiretorio.DirList(dirDiretorio.DirListIndex)
	End Sub
	
    Private Sub drvDiretorio_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles drvDiretorio.SelectedIndexChanged
        On Error GoTo erro
        dirDiretorio.Path = drvDiretorio.Drive
saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume saida
    End Sub
	
	
	'UPGRADE_WARNING: Form event frmDiretorio.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmDiretorio_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		dirDiretorio.Focus()
	End Sub

    Private Sub frmDiretorio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
    End Sub
End Class