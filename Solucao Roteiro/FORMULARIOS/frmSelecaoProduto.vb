Public Class frmSelecaoProduto
    Dim clsGeneric As New MSAClass.GENERIC.asmxGeneric
    Dim dtsProduto As New DataSet
    Dim intSegmentoAtual As Int32
    Dim strCodCliente As String
    Dim intCod_Produto As Int32
    Dim strNomeProduto As String
    Dim bolClickOk As Boolean
    
    Public Property Cod_Cliente() As String
        Get
            Cod_Cliente = strCodCliente
        End Get
        Set(ByVal value As String)
            strCodCliente = value
            If strCodCliente IsNot Nothing Then
                If strCodCliente.Trim <> "" Then
                    chkFiltroCliente.Text = "Produtos Associados ao Cliente " & strCodCliente
                    chkFiltroCliente.Enabled = True
                Else
                    chkFiltroCliente.Enabled = False
                    chkFiltroCliente.Checked = False
                End If
            End If
        End Set
    End Property
    Public Property CodigoProduto() As Int32
        Get
            CodigoProduto = intCod_Produto
        End Get
        Set(ByVal value As Int32)
            intCod_Produto = value
        End Set
    End Property
    Public Property NomeProduto() As String
        Get
            NomeProduto = strNomeProduto
        End Get
        Set(ByVal value As String)
            strNomeProduto = value
        End Set
    End Property
    Public Property OkClick() As Boolean
        Get
            OkClick = bolClickOk
        End Get
        Set(ByVal value As Boolean)
            bolClickOk = value
        End Set
    End Property
    Private Sub txtSetor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSetor.Validated
        Try
            If txtSetor.DataNumberValue <> 0 Then
                txtSegmento.Text = ""
                txtSegmento.Descricao = ""
                txtSegmento.sqlQuery = "Select Cod_Red_Produto as Codigo , Descricao as Descrição From Produto Where Cod_Root = " & txtSetor.DataNumberValue
                dtsProduto.Clear()
                gridProduto.Refresh()
                chkFiltroCliente.Checked = False
            Else
                txtSegmento.sqlQuery = ""
                txtSegmento.Text = ""
                txtSegmento.Descricao = ""
                chkFiltroCliente.Checked = False
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub frmSelecaoProduto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        EstiloGrid(gridProduto, 2)
        With gridProduto
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub txtSegmento_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSegmento.TabIndexChanged

    End Sub
    Private Sub txtSegmento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSegmento.Validated
        Dim strQuery As String = ""
        Try
            If txtSegmento.DataNumberValue <> 0 Then
                If txtSegmento.DataNumberValue <> intSegmentoAtual Then
                    strQuery = "Select Cod_Red_Produto as Código , Descricao as Descrição From Produto Where Cod_Root = " & txtSegmento.DataNumberValue
                    intSegmentoAtual = txtSegmento.DataNumberValue
                    Me.Cursor = Cursors.WaitCursor
                    With gridProduto
                        dtsProduto.Clear()
                        intSegmentoAtual = txtSegmento.DataNumberValue
                        dtsProduto = clsGeneric.fnSqlExecute(strQuery)
                        .DataSource = dtsProduto.Tables(0)
                        .AutoResizeColumns()
                        .Refresh()
                    End With
                    chkFiltroCliente.Checked = False
                End If
            Else
                chkFiltroCliente.Checked = False
                dtsProduto.Clear()
                gridProduto.Refresh()
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub chkFiltroCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFiltroCliente.Click
        Dim strQuery As String = ""
        Try
            If chkFiltroCliente.Checked Then
                strQuery = " Select P.Cod_Red_Produto as Código , "
                strQuery += " P.Descricao as Descrição "
                strQuery += " From 	Produto  P,"
                strQuery += " Composicao_cliente_produto C"
                strQuery += " Where	C.Cod_Terceiro  =  '" & ME.Cod_Cliente & "'" 
                strQuery += " And	p.cod_Red_produto =  C.cod_Red_produto"
                strQuery += " And	P.Nivel = 3"

                Me.Cursor = Cursors.WaitCursor
                With gridProduto
                    dtsProduto.Clear()
                    intSegMentoatual = txtSegmento.DataNumberValue
                    dtsProduto = clsGeneric.fnSqlExecute(strQuery)
                    .DataSource = dtsProduto.Tables(0)
                    .AutoResizeColumns()
                    .Refresh()
                    .ReadOnly = True
                End With
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

    Private Sub bntOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntOkCancel.Cancel_Click
        Me.OkClick = False
    End Sub

    Private Sub bntOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntOkCancel.Ok_Click
        Try
            With gridProduto
                Me.CodigoProduto = .Item("Código", .CurrentRow.Index).Value
                Me.NomeProduto = .Item("Descrição", .CurrentRow.Index).Value
                Me.OkClick = True
                Me.Hide()
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub gridProduto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridProduto.DoubleClick
        Call bntOkCancel_Ok_Click(New Object, New EventArgs)
    End Sub
End Class