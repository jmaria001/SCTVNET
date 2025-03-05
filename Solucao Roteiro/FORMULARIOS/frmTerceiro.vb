Public Class frmTerceiro
    Dim bInclusao As Boolean
    Dim bAlteracao As Boolean
    Dim bExclusao As Boolean
    Dim bDesativacao As Boolean
    Dim bAssociacao As Boolean
    Dim dtsTerceiro As New DataSet
    Dim clsTerceiro As MSAClass.AsmxTerceiro.asmxTerceiro
    Public Sub New()
        Me.MdiParent = mdiPrincipal
        InitializeComponent()

    End Sub
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim strCodigo As String = ""
        Dim strRazaoSocial As String = ""
        Dim strNomeFantasia As String = ""
        Dim strMunicipio As String = ""
        Dim strCNPJ As String = ""
        Dim shortFuncao As Integer = 0
        Dim bolConsulta As Boolean
        Try
            With frmTerceiroFiltro
                .ShowDialog()
                bolConsulta = .OkClick
                strCodigo = .Codigo
                strRazaoSocial = .RazaoSocial
                strNomeFantasia = .NomeFantasia
                strMunicipio = .Municipio
                strCNPJ = .CNPJ
                shortFuncao = .Funcao
                .Dispose()
            End With
            If bolConsulta Then
                dtsTerceiro.Clear()
                dtsTerceiro = clsTerceiro.spuTerceiroFiltro(strCodigo, strRazaoSocial, strNomeFantasia, strCNPJ, strMunicipio, shortFuncao, gsUsuario)
                If dtsTerceiro.Tables(0).Rows.Count = 0 Then
                    Aviso("O filtro informado não retornou nenhum registro")
                End If
                Call CarregaGrid()
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaGrid()
        Dim strSql As String = ""
        Try
            '===========================================Carrega / Configura o Grid
            Call EstiloGrid(gridTerceiro, 1)
            With gridTerceiro
                .DataSource = dtsTerceiro.Tables(0)
                .Columns("Cod_Terceiro").HeaderText = "Código"
                .Columns("Razao_Social").HeaderText = "Razão Social"
                .Columns("Descricao_Funcao_Terceiro").HeaderText = "Função"
                .Columns("Cod_Empresa_Principal").HeaderText = "Emp.Principal"
                .Columns("Nome_Fantasia").HeaderText = "Nome de Fantasia"
                

                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = True
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .AutoResizeRows()



            End With
            If dtsTerceiro.Tables(0).Rows.Count >= 500 Then
                Aviso("Resultado maior que 500 linhas. Mostrando apenas 500, por favor refine sua pesquisa")
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub frmTerceiro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            me.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub frmTerceiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            Me.Top = 0
            Me.Left = 0
            Me.CenterToParent()
            clsTerceiro = NewTerceiro()
            bInclusao = VePermissao(148)
            bAlteracao = VePermissao(149)
            bExclusao = VePermissao(150)
            bDesativacao = VePermissao(151)
            bAssociacao = VePermissao(152)

            btnNovo.Enabled = bInclusao
            btnEditar.Enabled = bAlteracao
            btnExcluir.Enabled = bExclusao
            btnEMpresa.Enabled = bInclusao
            btnProduto.Enabled = bAssociacao

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            frmTerceiro_Cadastro.Operacao = frmTerceiro_Cadastro.eNumOperacao.Incluir
            frmTerceiro_Cadastro.CarregaDataSet("")
            frmTerceiro_Cadastro.ShowDialog()
            frmTerceiro_Cadastro.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim strCod_Terceiro As String
        Try
            If Not Me.gridTerceiro.CurrentRow Is Nothing Then
                strCod_Terceiro = Me.gridTerceiro.Item("Cod_Terceiro", gridTerceiro.CurrentRow.Index).Value
                If Not String.IsNullOrEmpty(strCod_Terceiro) Then
                    frmTerceiro_Cadastro.Operacao = frmTerceiro_Cadastro.eNumOperacao.Editar
                    frmTerceiro_Cadastro.CarregaDataSet(strCod_Terceiro)
                    frmTerceiro_Cadastro.ShowDialog()
                    frmTerceiro_Cadastro.Dispose()
                Else
                    Aviso("Nenhum Registro foi Selecionado para Edição")
                End If
            Else
                Aviso("Nenhum Registro foi Selecionado para Edição")
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnProduto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProduto.Click
        Dim strCod_Terceiro As String
        Try
            If Not Me.gridTerceiro.CurrentRow Is Nothing Then
                strCod_Terceiro = Me.gridTerceiro.Item("Cod_Terceiro", gridTerceiro.CurrentRow.Index).Value
                If Not String.IsNullOrEmpty(strCod_Terceiro) Then
                    frmTerceiroProduto.txtTerceiro.Text = strCod_Terceiro
                    frmTerceiroProduto.txtTerceiro.Descricao = Me.gridTerceiro.Item("Razao_Social", gridTerceiro.CurrentRow.Index).Value
                    frmTerceiroProduto.CarregaDataSetAssociados()
                    frmTerceiroProduto.ShowDialog()
                    frmTerceiroProduto.Dispose()
                Else
                    Aviso("Nenhum Registro foi Selecionado para Associação")
                End If
            Else
                Aviso("Nenhum Registro foi Selecionado para Associação")
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub gridTerceiro_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridTerceiro.CellDoubleClick
        Dim strCod_Terceiro As String
        Try
            strCod_Terceiro = Me.gridTerceiro.Item("Cod_Terceiro", gridTerceiro.CurrentRow.Index).Value
            If Not String.IsNullOrEmpty(strCod_Terceiro) Then
                frmTerceiro_Cadastro.Operacao = frmTerceiro_Cadastro.eNumOperacao.Consultar
                frmTerceiro_Cadastro.CarregaDataSet(strCod_Terceiro)
                frmTerceiro_Cadastro.ShowDialog()
                frmTerceiro_Cadastro.Dispose()
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim strCod_Terceiro As String
        Try
            If Not Me.gridTerceiro.CurrentRow Is Nothing Then
                strCod_Terceiro = Me.gridTerceiro.Item("Cod_Terceiro", gridTerceiro.CurrentRow.Index).Value
                If Not String.IsNullOrEmpty(strCod_Terceiro) Then
                    If Aviso("Confirma a Exclusão do Terceiro " & strCod_Terceiro & "?", MessageBoxButtons.YesNo) Then
                        Dim cls As MSAClass.AsmxTerceiro.asmxTerceiro = NewTerceiro()
                        If cls.fnTerceiroExcluir(strCod_Terceiro) Then

                            gridTerceiro.Rows.Remove(gridTerceiro.CurrentRow)
                            Aviso("Terceiro excluido com Sucesso")
                        Else
                            Aviso("Nao foi possivel excluir esse terceiro porque está sendo utilizado")
                        End If
                    End If
                Else
                    Aviso("Nenhum Registro foi Selecionado para Exclusão")
                End If
            Else
                Aviso("Nenhum Registro foi Selecionado para Exclusão")
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub gridTerceiro_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridTerceiro.CellContentClick

    End Sub
End Class