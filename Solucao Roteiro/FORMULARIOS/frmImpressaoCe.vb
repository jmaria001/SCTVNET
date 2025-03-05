Public Class frmImpressaoCe
    Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric
    Dim clsChecking As MSAClass.asmxChecking.asmxChecking
    Dim dtsVeiculo As New DataSet
    Dim dtsCe As New DataSet
    Private Sub groupFiltro_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupFiltro.Enter

    End Sub

    Private Sub frmImpressaoCe_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmImpressaoCe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Top = 0
        Me.Left = 0
        Me.Cursor = Cursors.WaitCursor
        SetaUserControl(Me)
        Try
            clsGeneric = NewGeneric()
            clsChecking = NewChecking()
            dtsVeiculo = clsGeneric.fnSqlExecute("Execute PrNet_Veiculo_L null,'" & gsUsuario & "'")
            dtsVeiculo.Tables(0).Columns.Add("Check", GetType(System.Boolean))
            For Each row As DataRow In dtsVeiculo.Tables(0).Rows
                row.Item("Check") = False
            Next
            EstiloGrid(gridVeiculo, 2)
            With gridVeiculo
                .DataSource = dtsVeiculo.Tables(0)
                .Columns("Check").HeaderText = ""
                .Columns("Cod_Veiculo").HeaderText = "Veiculo"
                .Columns("Nome_Veiculo").HeaderText = "Nome"

                .Columns("Check").DisplayIndex = 0
                .Columns("Cod_Veiculo").DisplayIndex = 1
                .Columns("Nome_Veiculo").DisplayIndex = 2

                .Columns("Check").ReadOnly = False
                .Columns("Cod_Veiculo").ReadOnly = True
                .Columns("Nome_Veiculo").ReadOnly = True
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.MdiParent = mdiPrincipal
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ucImprimeCe_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Close()
    End Sub
    Private Sub Marcar(ByVal pFlag As Boolean)
        Try
            With gridVeiculo
                For Each Row As DataGridViewRow In .Rows
                    .Item("Check", Row.Index).Value = pFlag
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnDesmarcar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesmarcar.Click
        Marcar(False)
    End Sub

    Private Sub btnMarcar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        Marcar(True)
    End Sub

    Private Sub optContrato_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optContrato.CheckedChanged
        GroupContrato.Enabled = optContrato.Checked
        If Not optContrato.Checked Then
            ucEmpresa.Text = ""
            ucContrato.Text = ""
            ucSequencia.Text = ""
        End If
    End Sub

    Private Sub opdData_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles opdData.CheckedChanged
        GroupData.Enabled = opdData.Checked
        If Not opdData.Checked Then
            ucDataProcessamento.Text = ""
        End If
    End Sub

    Private Sub optNumeroComprovante_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optNumeroComprovante.CheckedChanged
        GroupComprovante.Enabled = optNumeroComprovante.Checked
        If Not optNumeroComprovante.Checked Then
            ucNumeroCeInicio.Text = ""
            ucNumeroCeFim.Text = ""
        End If
    End Sub

    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Dim dtProcessamento As Date = Date.MinValue
        Dim strVeiculo As String = ""
        Dim intResultado As Integer = 0
        Try
            '=======================================Consiste a tela 
            If ucEmpresaFaturamento.Text.Trim = "" Then
                Aviso("Campo empresa de Faturamento não pode ser branco")
                Exit Try
            End If

            With gridVeiculo
                For Each row As DataGridViewRow In .Rows
                    If .Item("Check", row.Index).Value Then
                        strVeiculo += .Item("Cod_Veiculo", row.Index).Value & ","
                    End If
                Next
            End With

            If opdData.Checked Then
                If ucDataProcessamento.Text.Trim = "" Then
                    Aviso("Data do Processamento deve ser preenchido ")
                    Exit Try
                Else
                    dtProcessamento = DateTime.Parse(ucDataProcessamento.Text)
                End If
            End If
            If optContrato.Checked And (ucEmpresa.Text.Trim = "" Or ucContrato.Text.Trim = "" Or ucSequencia.Text.Trim = "") Then
                Aviso("Empresa/Contrato/Sequencia  devem ser preenchidos nessa opção")
                Exit Try
            End If

            If optNumeroComprovante.Checked Then
                If ucNumeroCeInicio.Text.Trim = "" Then
                    Aviso("Numero Inicial do Comprovante deve ser preenchido nessa opção")
                    Exit Try
                Else
                    If ucNumeroCeFim.Text.Trim = "" Then ucNumeroCeFim = ucNumeroCeInicio
                End If
                If ucNumeroCeFim.DataNumberValue < ucNumeroCeInicio.DataNumberValue Then
                    Aviso("Numero Final do comprovante deve ser maior ou igual ao numero inicial")
                    Exit Try
                End If
            End If
            '=======================================Chama procedure de emissao 
            Me.Cursor = Cursors.WaitCursor
            intResultado = clsChecking.fnImprimeCe(ucEmpresaFaturamento.Text, ucNumeroCeInicio.DataNumberValue, ucNumeroCeFim.DataNumberValue, dtProcessamento, ucEmpresa.Text, ucContrato.DataNumberValue, ucSequencia.DataNumberValue, strVeiculo, gsUsuario)
            Me.Cursor = Cursors.Default
            If intResultado = 0 Then
                Aviso("Nenhum Registro foi Selecionado")
                Exit Try
            End If

            dtsCe = clsChecking.fnR0009(gsUsuario)

            '======================Mostra Crystal Report
            Dim rpt As New rptCe
            rpt.SetDataSource(dtsCe.Tables("R0009"))
            frmImpressao.crvImpressao.ReportSource = rpt
            frmImpressao.crvImpressao.DisplayGroupTree = False
            frmImpressao.crvImpressao.ShowGroupTreeButton = False
            frmImpressao.Text = "Comprovante de Exibição"
            frmImpressao.Show()
            frmImpressao.BringToFront()

            '============================
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
            'clsGeneric.fnSqlExecute("Execute Prnet_R0009_Delete '" & gsUsuario & "'")
        End Try
    End Sub


End Class