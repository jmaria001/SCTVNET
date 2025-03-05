Public Class frmReabreCe
    Dim clsContrato As MSAClass.AsmxContrato.asmxContrato
    Public Sub New()
        InitializeComponent()
        Me.MdiParent = mdiPrincipal
    End Sub

    Private Sub frmReabreCe_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frmReabreCe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        clsContrato = NewContrato()
        Me.CenterToScreen()

    End Sub

    Private Sub btnOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Close()
    End Sub

    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Dim strMensagem As String = ""
        Try
            '==========================================Consistencias 
            If ucEmpresa.Text.Trim = "" Then
                Aviso("Empresa não pode ser branco !")
                Exit Try
            End If
            If ucContrato.Text.Trim = "" Then
                Aviso(" Contrato não pode ser em Branco !")
            End If
            If ucSequencia.Text.Trim = "" Then
                Aviso(" Sequência não pode ser em Branco !")
                Exit Try
            End If
            If txtMotivo.Text.Trim = "" Then
                Aviso(" Motivo da Reabertura não pode ser em Branco !")
                Exit Try
            End If

            If Not clsContrato.fnExisteMr(ucEmpresa.Text, ucContrato.DataNumberValue, ucSequencia.DataNumberValue) Then
                Aviso("Contrato Inexistente")
                Exit Try
            End If

            '==========================================Executa reabre ce
            If Aviso("Deseja Realmente Reabrir os Comprovantes de Exibição para o Contrato Informado !", vbYesNo, vbQuestion) = False Then
                Exit Try
            End If
            strMensagem = clsContrato.fnReabreCE(ucEmpresa.Text, ucContrato.DataNumberValue, ucSequencia.DataNumberValue, ucVeiculo.Text, txtMotivo.Text).ToUpper.Trim
            Aviso(FirstCaps(strMensagem))
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

End Class