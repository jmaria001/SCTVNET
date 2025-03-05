Public Class frmSelecaoProduto
    Dim clsGeneric As New MSAClass.AsmxGeneric.asmxGeneric
    Dim dtsProduto As New DataSet
    Dim intSegmentoAtual As Int32
    Dim strCodCliente As String
    Dim intCod_Produto As Int32
    Dim strNomeProduto As String
    Dim bolClickOk As Boolean
    Public Usuario As String = ""
    Public Senha As String = ""
    Public PermiteNovoProduto As Boolean
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
                txtSegmento.sqlQuery = "PrNet_Produto_Root_L " & txtSetor.DataNumberValue
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
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmSelecaoProduto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        txtSegmento.Usuario = Me.Usuario
        txtSegmento.Senha = Me.Senha
        btnCriarProduto.Visible = Me.PermiteNovoProduto

        clsGeneric = NewGeneric(Me.Usuario, Me.Senha)

        With gridProduto
            .ReadOnly = True
            .BackgroundColor = Color.White
            .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
            .RowHeadersDefaultCellStyle.NullValue = ""
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .BackgroundColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub txtSegmento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSegmento.Validated
        Call Carregar()
    End Sub
    Private Sub chkFiltroCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFiltroCliente.Click
        Carregar()
    End Sub

    Private Sub bntOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntOkCancel.Cancel_Click
        Me.OkClick = False
        Me.Hide()
    End Sub

    Private Sub bntOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntOkCancel.Ok_Click
        Try
            With gridProduto
                If Not .CurrentCell Is Nothing Then
                    Me.CodigoProduto = .Item("Codigo", .CurrentRow.Index).Value
                    Me.NomeProduto = .Item("Descricao", .CurrentRow.Index).Value
                    Me.OkClick = True
                    Me.Hide()
                End If
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub

    Private Sub gridProduto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridProduto.DoubleClick
        Call bntOkCancel_Ok_Click(New Object, New EventArgs)
    End Sub

    Private Sub btnCriarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriarProduto.Click
        frmProdutoCadastro.Usuario = Me.Usuario
        frmProdutoCadastro.Senha = Me.Senha
        frmProdutoCadastro.Cliente = Me.strCodCliente
        If Me.txtSetor.Text.Trim <> "" Then
            frmProdutoCadastro.ucSetor.Text = txtSetor.Text
            frmProdutoCadastro.ucSetor.Descricao = txtSetor.Descricao

            frmProdutoCadastro.ucSegmento.Text = txtSegmento.Text
            frmProdutoCadastro.ucSegmento.Descricao = txtSegmento.Descricao

        End If
        frmProdutoCadastro.ShowDialog()
        If frmProdutoCadastro.OkClick Then
            bntAtualizar.PerformClick()
        End If
        frmProdutoCadastro.Dispose()


    End Sub
    Private Sub Carregar()
        Dim strQuery As String
        strQuery = ""
        Try
            With gridProduto
                dtsProduto.Clear()

                If chkFiltroCliente.Checked Then
                    strQuery = " PrNet_Terceiro_Produto_L  '" & Me.Cod_Cliente & "'"
                Else
                    If txtSegmento.Text.Trim <> "" Then
                        strQuery = "Execute PrNet_Produto_Root_L  " & txtSegmento.DataNumberValue
                    End If
                End If

                If strQuery <> "" Then
                    dtsProduto = clsGeneric.fnSqlExecute(strQuery)
                    .DataSource = dtsProduto.Tables(0)
                    .AutoResizeColumns()
                    .Refresh()
                    .ReadOnly = True
                End If
            End With

        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try

    End Sub

    Private Sub bntAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntAtualizar.Click
        Carregar()
    End Sub

    
End Class