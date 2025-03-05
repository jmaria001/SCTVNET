Public Class frmRoteiro_Encerramento

    Private Sub frmRoteiro_Encerramento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Top = 100
        Me.Left = 300
        frmRoteiroConsistencia.asmxRoteiro = NewRoteiro()
        frmRoteiroConsistencia.asmxVeiculo = NewVeiculo()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.MdiParent = SCTVNET.mdiPrincipal


    End Sub

    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        On Error GoTo Erro

        Me.Cursor = Cursors.WaitCursor
        Dim sMensagem As String
        Dim intPorta As Integer

        If ucVeiculo.Text = "" Then
            Aviso("Veículo deve ser informado")
            GoTo Saida
        End If

        If UcData.Ano < 1000 Then
            Aviso("Data Inválida")
            GoTo Saida
        End If

        If chkEncerramento.Checked = True Then

            If ExisteRoteiro(ucVeiculo.Text, UcData.Text, "", -1, -1) = False Then
                Aviso("Não existe Roteiro Ordenado para este Veículo / Data ")
                GoTo Saida
            End If

            If ExisteRoteiroEncerrado(ucVeiculo.Text, UcData.Text) = True Then
                Aviso("Roteiro já foi Encerrado")
                GoTo Saida
            End If

            Dim asmxPorta As MSAClass.AsmxPorta.asmxPorta = NewPorta()
            Dim DtsPorta As New MSAClass.AsmxPorta.dtsPorta
            DtsPorta.Clear()
            intPorta = FPorta(asmxPorta, DtsPorta, 1, ucVeiculo.Text, UcData.Text, "")
            asmxPorta.spuAtualizar(DtsPorta)

            Select Case intPorta
                Case 1, 2
                    Aviso("Existe(m) Usuário(s) Ordenando esta Programação.")
                    GoTo Saida
            End Select
        End If

        Me.Hide()
        frmRoteiroConsistencia.chkIniciar.Checked = True
        frmRoteiroConsistencia.txtVeiculo.Text = ucVeiculo.Text
        frmRoteiroConsistencia.txtData.Text = UcData.Text
        frmRoteiroConsistencia.chkRoteiroGravado.Checked = True
        frmRoteiroConsistencia.cmdEncerramento.Visible = True
        frmRoteiroConsistencia.ShowDialog()



        chkOK.Checked = True
        Me.Dispose()
        Me.Cursor = Cursors.Default

Saida:
        Me.Cursor = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
    End Sub
End Class