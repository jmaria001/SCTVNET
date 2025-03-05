Public Class frmDeterminacaoComercial
    Private txtComercial_para As String
    Private bControlaLinhaBranco As Boolean = False
    Public dtsComercialDeterminar As New DataSet
    Public dtsComercialNovo As New DataSet
    Public OkClick As Boolean
    Public Empresa As String
    Public Contrato As Int32
    Public Sequencia As String
    Public Veiculo As String
    Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
    Dim clsContrato As MSAClass.AsmxContrato.asmxContrato = NewContrato()
    Dim dtsVeiculacao As DataSet = New DataSet
    
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub btnDeterminar_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeterminar.Cancel_Click
        Me.Close()
    End Sub

    Private Sub btnDeterminar_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeterminar.Ok_Click

        Dim strSql As String = ""
        Dim intDuracaoDeterminar As Integer = 0
        Dim intDuracaoNova As Integer = 0

        Dim strTipoComercial As String = ""
        Dim strTipoComercialNovo As String = ""
        Dim strCodComercial As String = ""
        Dim sQualidade As String
        Dim strCritica As String = ""


        Try
            Dim dtDataInicio As Date
            Dim dtDataFim As Date

            dgvDeterminar.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dtsComercialDeterminar.AcceptChanges()
            dgvNovo.EndEdit()
            dtsComercialNovo.AcceptChanges()

            '==============================Consistencias 

            If dtsComercialDeterminar.Tables(0).Select("Check = true").Length = 0 Then
                Aviso("Nenhum comercial a determinar foi selecionado")
                Exit Try
            End If

            If dtsComercialDeterminar.Tables(0).Select("Check = true").Length > 1 Then
                Aviso("Somente um comercial a determinar pode ser selecionado")
                Exit Try
            End If

            If dtsComercialNovo.Tables(0).Select("Check = true").Length = 0 Then
                Aviso("Nenhum comercial novo foi selecionado")
                Exit Try
            End If


            intDuracaoDeterminar = dtsComercialDeterminar.Tables(0).Compute("sum(duracao)", "check=true")

            'intDuracaoNova = dtsComercialNovo.Tables(0).Compute("sum(duracao)", "check=true")
            With dgvNovo
                For Each row As DataGridViewRow In .Rows
                    If Vernulo(.Item("Check", row.Index).Value, False) Then
                        intDuracaoNova += .Item("Duracao", row.Index).Value * .Item("Qtd", row.Index).Value
                    End If
                Next
            End With

            If intDuracaoNova <> intDuracaoDeterminar Then
                Aviso("Soma da duração dos novos comerciais deve ser igual a duracao do comercial a determinar")
                Exit Try
            End If


            For Each row As DataRow In dtsComercialDeterminar.Tables(0).Select("Check = true")
                strTipoComercial += row.Item("Cod_Tipo_Comercial")
                strCodComercial = row.Item("Cod_Comercial")
            Next

            Dim dtbTemp As DataTable = New DataTable
            dtbTemp.Columns.Add("Cod_Tipo_Comercial", GetType(System.String))

            For Each row As DataRow In dtsComercialNovo.Tables(0).Select("Check = true")
                dtbTemp.Rows.Add(row.Item("cod_tipo_comercial"))
            Next

            For Each row As DataRow In dtbTemp.DefaultView.ToTable(True, "Cod_Tipo_Comercial").Select
                strTipoComercialNovo += row.Item("Cod_Tipo_Comercial")
            Next

            If strTipoComercial <> strTipoComercialNovo Then
                Aviso("Tipos de Comercias a determinar e novo devem ser iguais")
                Exit Try
            End If

            If dtsComercialNovo.Tables(0).Select("Check = true and cod_comercial = '" & strCodComercial & "'").Length > 0 Then
                Aviso("O mesmo comercial não pode estar marcado nas duas listas")
                Exit Try
            End If



            '==============================Carrega Veiculacoes a ser determinadas  
            dtsVeiculacao = Nothing
            If TxtDatade.Text = "" Then
                dtDataInicio = DateTime.Parse("1900-01-01")
            Else
                dtDataInicio = DateTime.Parse(TxtDatade.Text)
            End If

            If txtDataAte.Text = "" Then
                dtDataFim = DateTime.Parse("2100-12-31")
            Else
                dtDataFim = DateTime.Parse(txtDataAte.Text)
            End If

            Me.Cursor = Cursors.WaitCursor

            '=============================Comerciais "de"
            strSql = "Cod_Comercial = '" & strCodComercial & "'"
            If txtPrograma.Text.Trim <> "" Then
                strSql += " and cod_programa = '" & txtPrograma.Text & "'"
            End If
            dtsVeiculacao = clsContrato.fnDeterminacao_Select(Me.Empresa, Me.Contrato, Me.Sequencia, Me.Veiculo, dtDataInicio, dtDataFim)
            If dtsVeiculacao.Tables(0).Select(strSql).Length = 0 Then
                'If dtsVeiculacao.Tables(0).Rows.Count = 0 Then
                Aviso("Nenhuma veiculação a determinar foi encontrada")
                Exit Try
            End If
            clsContrato.fnDeterminacao_Delete(Me.Empresa, Me.Contrato, Me.Sequencia, gsUsuario)
            For Each row As DataRow In dtsVeiculacao.Tables(0).Select("Cod_Comercial = '" & strCodComercial & "'")

                sQualidade = IIf(Vernulo(row.Item("Cod_Qualidade"), "") = "", "0", "1")
                clsContrato.fnDeterminacao_Insert(Me.Empresa, _
                                                  Me.Contrato, _
                                                  Me.Sequencia, _
                                                  Me.Veiculo, _
                                                  row.Item("Data_Exibicao"), _
                                                  row.Item("Cod_Programa"), _
                                                  row.Item("Chave_Acesso"), _
                                                  row.Item("Cod_Comercial"), _
                                                  1, _
                                                  0, _
                                                  gsUsuario, _
                                                  sQualidade)




                '=============================Comerciais "Para"
                For Each rowComercial As DataRow In dtsComercialNovo.Tables(0).Select("Check = true ")
                    For x As Integer = 1 To rowComercial.Item("qtd")
                        sQualidade = IIf(Vernulo(row.Item("Cod_Qualidade"), "") = "", "0", "1")
                        clsContrato.fnDeterminacao_Insert(Me.Empresa, _
                                                          Me.Contrato, _
                                                          Me.Sequencia, _
                                                          Me.Veiculo, _
                                                          row.Item("Data_Exibicao"), _
                                                          row.Item("Cod_Programa"), _
                                                          row.Item("Chave_Acesso"), _
                                                          rowComercial.Item("Cod_Comercial"), _
                                                          0, _
                                                          1, _
                                                          gsUsuario, _
                                                          sQualidade)
                    Next
                Next
            Next
            strCritica = clsContrato.fnDeterminacao_Comerciais(Me.Empresa, Me.Contrato, Me.Sequencia, gsUsuario)

            If strCritica <> "" Then
                Aviso("Erro ao Determinar Comerciais.")
                OkClick = True
                Me.Hide()
                Exit Sub
            End If
            Aviso("Determinação Concluída Com Sucesso.")
            OkClick = True
            Me.Hide()
            Exit Sub
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmDeterminacaoComercial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        dtsComercialDeterminar = Nothing
        dtsComercialNovo = Nothing
        Me.Dispose()
    End Sub

    Private Sub frmDeterminacaoComercial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            Me.CenterToParent()
            Me.ConfiguraGrid(dgvDeterminar, dtsComercialDeterminar)
            Me.ConfiguraGrid(dgvNovo, dtsComercialNovo)
            btnDeterminar.TabStop = False

        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub ConfiguraGrid(ByRef dgv As DataGridView, ByVal dts As DataSet)

        Dim dc As New DataGridViewTextBoxColumn

        Try


            With dts.Tables(0)
                .Columns.Add("Check", GetType(System.Boolean))
            End With

            With dgv
                .DataSource = dts.Tables(0)

                If dgv.Name = dgvNovo.Name Then
                    dts.Tables(0).Columns.Add("Qtd", GetType(System.Int16))
                    With dc
                        .Name = "Qtd"
                        .MaxInputLength = 2
                        .DataPropertyName = "Qtd"
                        .HeaderText = "Qtd"
                        .DisplayIndex = 0
                    End With

                    With dgv
                        dgv.Columns.Remove("qtd")
                        dgv.Columns.Add(dc)
                    End With
                    For Each row As DataRow In dts.Tables(0).Rows
                        row.Item("Qtd") = 1
                    Next
                End If

                .RowHeadersVisible = False
                .Columns("Check").HeaderText = ""
                .Columns("Check").DisplayIndex = 0

                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""
                .Columns("Merchandising").Visible = False
                .Columns("Indica_Titulo_Determinar").Visible = False
                .Columns("Nome_Produto").Visible = False
                .Columns("Numero_Fita").Visible = False
                .Columns("Cod_Comercial").HeaderText = "Cod."
                .Columns("Titulo_Comercial").HeaderText = "Titulo"
                .Columns("Duracao").HeaderText = "Dur."
                .Columns("Cod_Tipo_Comercial").HeaderText = "Tipo"


                .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
                .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()


                For x As Integer = 0 To .Columns.Count - 1
                    .Columns(x).ReadOnly = True
                Next
                .Columns("Check").ReadOnly = False
                If dgv.Name = dgvNovo.Name Then
                    .Columns("Qtd").ReadOnly = False
                    .Columns("Qtd").DisplayIndex = 5

                    .Columns("Qtd").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    'For x As Integer = 0 To .Rows.Count - 1
                    '.Item("Qtd", x).Value = 1
                    'Next
                End If

            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    
    Private Sub dgvNovo_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNovo.CellValidated
    End Sub

    
End Class