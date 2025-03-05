Public Class frmConfirmacaoRoteiro
    Dim clsChecking As New MSAClass.asmxChecking.asmxChecking
    Dim dtsVeiculo As DataSet = New DataSet

    Private Sub frmConfirmacaoRoteiro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmConfirmacaoRoteiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Top = 0
            Me.Left = 0
            clsChecking = NewChecking()
            dtsVeiculo = clsChecking.fnConfirmacaoRoteiroCarregar(gsUsuario)
            EstiloGrid(gridVeiculo, 2)
            With gridVeiculo
                .DataSource = dtsVeiculo.Tables(0)

                .Columns("Flag").HeaderText = ""
                .Columns("Cod_Veiculo").HeaderText = "Veículo"
                .Columns("Nome_Veiculo").HeaderText = "Nome"
                .Columns("Data_Confirmacao_Local").HeaderText = "Ultima Confirmação Local"
                .Columns("Data_Confirmacao_Rede").HeaderText = "Ultima Confirmação Rede"

                For x As Integer = 0 To .Columns.Count - 1
                    .Columns(x).ReadOnly = True
                Next
                .Columns("Flag").ReadOnly = False

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub btnConfirmacao_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmacao.Cancel_Click
        Me.Close()
    End Sub

    Private Sub btnConfirmacao_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfirmacao.Ok_Click
        Dim strVeiculos As String = ""
        Dim dtDataLocal As Date
        Dim dtDataRede As Date
        Try

            With gridVeiculo
                For Each row As DataGridViewRow In .Rows
                    If .Item("Flag", row.Index).Value Then
                        strVeiculos += .Item("Cod_Veiculo", row.Index).Value
                    End If
                Next
            End With

            If strVeiculos = "" Then
                Aviso("Nenhum Veículo foi Selecionado.")
                Exit Try
            End If

            If ucDataLocal.Text = "" And ucDataRede.Text = "" Then
                Aviso("Data de Confirmação da Rede ou Local deve ser informado.")
                Exit Try
            End If

            If Not Aviso("Deseja Confirmar o Roteiro com as Datas Selecionadas?") Then
                Exit Try
            End If

            If ucDataLocal.Text <> "" Then
                dtDataLocal = DateTime.Parse(ucDataLocal.Text)
            Else
                dtDataLocal = Nothing
            End If

            If ucDataRede.Text <> "" Then
                dtDataRede = DateTime.Parse(ucDataRede.Text)
            Else
                dtDataRede = Nothing
            End If

            If clsChecking.fnConfirmacaoRoteiro(strVeiculos, dtDataRede, dtDataLocal, gsUsuario) Then
                Aviso("Roteiro Confirmado com Sucesso")
            Else
                Aviso("Houve algum erro na confirmação.Verifique !")
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.MdiParent = mdiPrincipal
    End Sub
End Class

