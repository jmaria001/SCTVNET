Public Class frmAmReencaixe
    Dim dtbReencaixe As DataTable
    Public ClickOk As Boolean = False

    Public Sub CarregarFalhas()
        Dim clsAm As MSAClass.AsmxAM.asmxAM = NewAM()
        Try
            dtbReencaixe = clsAm.CarregarListaFalhasReencaixe(lblEmpresa.Text, Integer.Parse(lblContrato.Text), Short.Parse(lblSequencia.Text), lblNumeroDocto.Text, lblVeiculo.Text)
            With gridAm
                EstiloGrid(gridAm, 1)
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = False
                .DataSource = dtbReencaixe
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoResizeColumns()
                .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
                .RowHeadersVisible = False
                .Columns("Cod_Veiculo").Visible = False
                .Columns("Flag").HeaderText = ""
                .Columns("Data_Exibicao").HeaderText = "Data Exib."
                .Columns("Cod_Programa").HeaderText = "Programa"
                .Columns("Cod_Comercial").HeaderText = "Com"
                .Columns("Titulo_Comercial").HeaderText = "Titulo"
                .Columns("Duracao").HeaderText = "Dur."
                .Columns("Cod_Qualidade").HeaderText = "Qual."
                .Columns("Motivo_Falha").HeaderText = "Motivo da Falha"
                .Columns("Valor").HeaderText = "Valor"
                .Columns("Chave_Acesso").HeaderText = "Ch.Aces."
                .Columns("Valor").DefaultCellStyle.Format = "N2"
                .Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                For x As Integer = 1 To .Columns.Count - 1
                    .Columns(x).ReadOnly = True
                Next
            End With


        Catch ex As Exception
            ShowErro(ex)
        End Try


    End Sub

    Private Sub frmAmReencaixe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
    End Sub

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub btnReencaixe_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReencaixe.Cancel_Click
        Me.Hide()
    End Sub

    Private Sub btnMarcar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        Try
            With gridAm
                For x As Integer = 0 To .Rows.Count - 1
                    .Item("Flag", x).Value = True
                Next
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnDesmarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmarcar.Click
        Try
            With gridAm
                For x As Integer = 0 To .Rows.Count - 1
                    .Item("Flag", x).Value = False
                Next
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnReencaixe_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReencaixe.Ok_Click
        Dim bolSelecionou As Boolean
        Dim clsAm As MSAClass.AsmxAM.asmxAM = NewAM()
        Try
            With gridAm
                For Each rw As DataGridViewRow In .Rows
                    If .Item("Flag", rw.Index).Value Then
                        bolSelecionou = True
                        Exit For
                    End If
                Next
                If Not bolSelecionou Then
                    Aviso("Nenhum falha foi selecionada para reencaixar")
                    Exit Sub
                End If
            End With
            clsAm.ReencaixeSalvar(dtbReencaixe, gsUsuario)
            ClickOk = True
            Me.Hide()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
End Class