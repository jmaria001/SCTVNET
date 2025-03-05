Public Class frmTerceiroProduto
    Dim dtsProduto As New DataSet
    Dim dtsAssociado As New DataSet
    Dim intSegmentoAtual As Int32 = 0
    Dim intSetorAtual As Int32 = 0
    Public Sub CarregaDataSetAssociados()
        Dim clsTerceiro As MSAClass.AsmxTerceiro.asmxTerceiro = NewTerceiro()
        Dim NewCol As DataGridColumnStyle = Nothing

        Try
            EstiloGrid(gridAssociado, 2)
            With gridAssociado
                dtsAssociado = clsTerceiro.fnCarregarTerceiroProduto(txtTerceiro.Text)
                .DataSource = dtsAssociado.Tables(0)
                .Columns("Cod_Red_Produto").HeaderText = "Codigo"
                .Columns("Descricao").HeaderText = "Descricao"
                .Columns("Cod_Terceiro").Visible = False
                .Columns("Cod_Red_Produto").Width = 100
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .AutoResizeRows()
                '.ColumnHeadersVisible = False
                .ReadOnly = True
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub txtSetor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSetor.Validated
        Try
            If txtSetor.DataNumberValue <> 0 Then
                If txtSetor.DataNumberValue <> intSetorAtual Then
                    txtSegmento.Text = ""
                    txtSegmento.Descricao = ""
                    txtSegmento.sqlQuery = "PrNet_Produto_Root_L " & txtSetor.DataNumberValue
                    dtsProduto.Clear()
                    gridProduto.Refresh()
                End If
            Else
                txtSegmento.sqlQuery = ""
                txtSegmento.Text = ""
                txtSegmento.Descricao = ""
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub txtSegmento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSegmento.Validated
        Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
        Dim strQuery As String = ""
        Try
            If txtSegmento.DataNumberValue <> 0 Then
                If txtSegmento.DataNumberValue <> intSegmentoAtual Then
                    strQuery = "Execute Prnet_Produto_Root_L " & txtSegmento.DataNumberValue
                    intSegmentoAtual = txtSegmento.DataNumberValue
                    Me.Cursor = Cursors.WaitCursor
                    With gridProduto
                        dtsProduto.Clear()
                        intSegmentoAtual = txtSegmento.DataNumberValue
                        dtsProduto = clsGeneric.fnSqlExecute(strQuery)
                        .DataSource = dtsProduto.Tables(0)
                        .Refresh()
                    End With
                End If
            Else
                dtsProduto.Clear()
                gridProduto.Refresh()
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub frmTerceiroProduto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
        EstiloGrid(gridProduto, 2)
        With gridProduto
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            .ReadOnly = True
            '.ColumnHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoResizeRows()
        End With


    End Sub
    Private Sub bntOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntOkCancel.Cancel_Click
        Me.Dispose()
    End Sub
    Private Sub btnAdiciona_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdiciona.Click
        Dim rwNewRow As DataRow = Nothing
        Try
            If Not gridProduto.CurrentRow Is Nothing Then
                rwNewRow = dtsAssociado.Tables(0).NewRow
                rwNewRow.Item("Cod_Red_Produto") = gridProduto.Item("Codigo", gridProduto.CurrentRow.Index).Value
                rwNewRow.Item("Descricao") = gridProduto.Item("Descricao", gridProduto.CurrentRow.Index).Value
                rwNewRow.Item("Cod_Terceiro") = txtTerceiro.Text
                dtsAssociado.Tables(0).Rows.Add(rwNewRow)
                gridAssociado.AutoResizeRows()
                gridProduto.Rows.Remove(gridProduto.CurrentRow)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnExclui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExclui.Click
        Dim rwNewRow As DataRow = Nothing
        Try
            If Not gridAssociado.CurrentRow Is Nothing Then
                rwNewRow = dtsProduto.Tables(0).NewRow
                rwNewRow.Item("Codigo") = gridAssociado.Item("Cod_Red_Produto", gridAssociado.CurrentRow.Index).Value()
                rwNewRow.Item("Descricao") = gridAssociado.Item("Descricao", gridAssociado.CurrentRow.Index).Value
                dtsProduto.Tables(0).Rows.Add(rwNewRow)
                gridProduto.AutoResizeRows()
                gridAssociado.Rows.Remove(gridAssociado.CurrentRow)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub



    Private Sub gridProduto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridProduto.DoubleClick
        Try
            btnAdiciona.PerformClick()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub gridAssociado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAssociado.DoubleClick
        Try
            btnExclui.PerformClick()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnAdicionarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarTodos.Click
        Try
            While gridProduto.Rows.Count > 0
                gridProduto.CurrentCell = gridProduto.Item(0, 0)
                btnAdiciona.PerformClick()
            End While
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnExcluirTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirTodos.Click
        Try
            While gridAssociado.Rows.Count > 0
                gridAssociado.CurrentCell = gridAssociado.Item(0, 0)
                btnExclui.PerformClick()
            End While
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub bntOkCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntOkCancel.Click

    End Sub
    Private Sub bntOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntOkCancel.Ok_Click
        Try
            Dim clsterceiro As MSAClass.AsmxTerceiro.asmxTerceiro = NewTerceiro()
            Me.Cursor = Cursors.WaitCursor
            If clsterceiro.fnAtualizarTerceiroProduto(dtsAssociado) Then
                Aviso("Dados Gravados com Sucesso")
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Public Sub New()
        InitializeComponent()


    End Sub
End Class