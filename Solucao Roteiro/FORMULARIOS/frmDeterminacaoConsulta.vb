Public Class frmDeterminacaoConsulta
    Dim clsContrato As MSAClass.asmxContrato.asmxContrato
    Public DeterminarClick As Boolean = False
    Public Empresa As String = ""
    Public Contrato As Long = 0
    Public Sequencia As Short = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Hide()
    End Sub
    Private Sub btnExibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Try
            Dim dDataDe, dDataFim As Date
            Dim dtsSql As DataSet = Nothing
            If Trim(TxtPeriodode.Text) = "" Then
                MsgBox("Data Inicial não Pode Ficar em Branco.", MsgBoxStyle.Critical)
                TxtPeriodode.Focus()
                Exit Sub
            End If
            If Trim(TxtPeriodoAte.Text) = "" Then
                MsgBox("Data Final não Pode Ficar em Branco.", MsgBoxStyle.Critical)
                TxtPeriodoAte.Focus()
                Exit Sub
            End If
            dDataDe = DateTime.Parse(TxtPeriodode.Text)
            dDataFim = DateTime.Parse(TxtPeriodoAte.Text)
            dtsSql = clsContrato.fnDeterminacaoPendente(dDataDe, dDataFim, txtVeiculo.Text, gsUsuario)
            If dtsSql.Tables(0).Rows.Count <= 0 Then
                Aviso("Nenhum registro foi encontrato com esse filtro")
                Exit Try
            End If
            With dgvDetConsulta
                .DataSource = dtsSql.Tables(0)
                .AutoResizeColumns()
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = True
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""
                .Visible = True
                .AllowDrop = False
                .ReadOnly = True
                .RowHeadersVisible = False

                .Columns("Nome_Cliente").Visible = False
                .Columns("Nome_Agencia").Visible = False
                .Columns("Cod_Veiculo").HeaderText = "Veic."
                .Columns("Cod_Empresa").HeaderText = "Emp."
                .Columns("Numero_Mr").HeaderText = "Contrato"
                .Columns("Sequencia_Mr").HeaderText = "Seq"
                .Columns("Cod_Agencia").HeaderText = "Agencia"
                .Columns("Cod_Cliente").HeaderText = "Cliente"
                .Columns("Cod_Comercial").HeaderText = "Com."
                .Columns("Cod_Tipo_Comercial").HeaderText = "Tipo"
                .Columns("Duracao").HeaderText = "Dur."
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Public Sub New()
        InitializeComponent()

    End Sub


    Private Sub frmDeterminacaoConsulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        clsContrato = NewContrato()
    End Sub

    Private Sub btnDeterminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeterminar.Click
        Try
            With dgvDetConsulta
                If Not .CurrentRow Is Nothing Then
                    Me.DeterminarClick = True
                    Me.Empresa = .Item("Cod_Empresa", .CurrentRow.Index).Value
                    Me.Contrato = .Item("Numero_Mr", .CurrentRow.Index).Value
                    Me.Sequencia = .Item("Sequencia_Mr", .CurrentRow.Index).Value
                    Me.Hide()
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnOkCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Load

    End Sub
End Class