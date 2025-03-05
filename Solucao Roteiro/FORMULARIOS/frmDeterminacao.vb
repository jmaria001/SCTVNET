Public Class frmDeterminacao
    Dim sVeiculo, sDVeiculo As String
    Dim sAgencia As String
    Dim sCliente As String
    Public sEmpresa As String
    Public iContrato As Integer
    Public iSeq As Integer
    Dim sObservacao As String
    Dim dtbContrato As New DataTable
    Dim dtsComercial As DataSet = New DataSet
    Dim dtsDeterminado As DataSet = New DataSet
    Dim dtsVeiculo As DataSet = New DataSet
    Dim nRow_Comercial As Integer
    Dim clsContrato As MSAClass.AsmxContrato.asmxContrato = NewContrato()
    Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()

    Private Sub btnExibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExibir.Click

        Try

            Carrega_Geral()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Sub Carrega_Geral()
        Try
            dtsComercial = Nothing
            dtsDeterminado = Nothing
            dtsVeiculo = Nothing

            sAgencia = ""
            sCliente = ""

            btnOpcoes.Items("btnIncluir").Enabled = False

            If Trim(txtEmpresa.Text) = "" Then
                Aviso("Empresa não Pode Ficar em Branco.")
                txtEmpresa.Focus()
                Exit Sub
            End If

            If Trim(txtContrato.Text) = "" Then
                Aviso("Contrato não Pode Ficar em Branco.")
                txtContrato.Focus()
                Exit Sub
            End If

            If Trim(txtSeq.Text) = "" Then
                Aviso("Sequência não Pode Ficar em Branco.")
                txtSeq.Focus()
                Exit Sub
            End If

            If (Trim(TxtPeriodode.Text) = "" And Trim(TxtPeriodoAte.Text) <> "") Then
                Aviso("Data Inicial Deve ser Preenchida.")
                TxtPeriodode.Focus()
                Exit Sub
            End If

            '=======================Carrega Dados do Contrato
            dtbContrato.Clear()
            dtbContrato = clsContrato.fnDeterminacao_Dados_Contrato(txtEmpresa.Text, txtContrato.DataNumberValue, txtSeq.DataNumberValue).Tables(0)
            If dtbContrato.Rows.Count = 0 Then
                Aviso("Contrato Inválido")
                Exit Sub
            End If
            txtCliente.Text = dtbContrato.Rows(0).Item("Cod_Cliente")
            txtCliente.Descricao = dtbContrato.Rows(0).Item("Nome_Cliente")
            txtAgencia.Text = dtbContrato.Rows(0).Item("Cod_Agencia")
            txtAgencia.Descricao = dtbContrato.Rows(0).Item("Nome_Agencia")

            '==============Carrega_Grid_Comercial

            If Not Carrega_Grid_Comercial() Then
                Exit Sub
            End If
            '==============Carrega_Grid_Determinacao
            If Not Carrega_Grid_Determinado() Then
                Exit Sub
            End If

            If dtsDeterminado.Tables(0).Rows.Count = 0 Then
                Aviso("Nenhuma Veiculacao a determinar foi Encontrada para esse contrato")
            End If

            '=============================Verifica Quantidade de Veiculos
            txtVeiculo.Enabled = True
            dtsVeiculo = clsContrato.fnDeterminacao_Veiculo_Select(txtEmpresa.Text, txtContrato.DataNumberValue, txtSeq.DataNumberValue)
            If dtsVeiculo.Tables(0).Rows.Count > 0 Then
                txtVeiculo.Text = dtsVeiculo.Tables(0).Rows(0).Item("Cod_Veiculo")
                txtVeiculo.Descricao = dtsVeiculo.Tables(0).Rows(0).Item("Nome_Veiculo")
                If dtsVeiculo.Tables(0).Rows.Count = 1 Then ' só tem um veiculo
                    txtVeiculo.Enabled = False
                End If
            End If

            btnOpcoes.Items("btnIncluir").Enabled = True
            btnOpcoes.Items("btnSalvar").Enabled = True
            btnOpcoes.Items("btnLimpar").Enabled = True

            txtMensagem.Text = ""

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function Carrega_Grid_Comercial() As Boolean
        Carrega_Grid_Comercial = False
        Try

            dtsComercial = clsContrato.fnDeterminacao_Dados_Comercial(txtEmpresa.Text, txtContrato.DataNumberValue, txtSeq.DataNumberValue)
            Call EstiloGrid(dgvComercial, 1)
            With dgvComercial
                .DataSource = dtsComercial.Tables(0)

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
                .AllowDrop = True
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()

            End With
            Carrega_Grid_Comercial = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Function


    Private Function Carrega_Grid_Determinado() As Boolean
        Dim dtDataInicio As Date = Nothing
        Dim dtDataFim As Date = Nothing
        Carrega_Grid_Determinado = False
        Try
            dtsDeterminado = Nothing
            If TxtPeriodode.Text = "" Then
                dtDataInicio = DateTime.Parse("1900-01-01")
            Else
                dtDataInicio = DateTime.Parse(TxtPeriodode.Text)
            End If

            If TxtPeriodoAte.Text = "" Then
                dtDataFim = DateTime.Parse("2100-12-31")
            Else
                dtDataFim = DateTime.Parse(TxtPeriodoAte.Text)
            End If

            dtsDeterminado = clsContrato.fnDeterminacao_Select(txtEmpresa.Text, txtContrato.DataNumberValue, txtSeq.DataNumberValue, txtVeiculo.Text, dtDataInicio, dtDataFim)


            If dtsDeterminado.Tables(0).Rows.Count <= 0 Then
                Exit Function
            End If

            Call EstiloGrid(dgvDeterminacao, 1)

            With dgvDeterminacao

                .DataSource = dtsDeterminado.Tables(0)
                .AutoResizeColumns()
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""
                .Visible = True
                .AllowDrop = True
                .Columns("Data_Exibicao").Width = 60
                .Columns("Cod_Comercial").Width = 30
                .Columns("Cod_Comercial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Cod_Programa").Width = 40
                .Columns("Cod_Programa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Duracao").Width = 30
                .Columns("Duracao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Titulo_Comercial").Width = 190
                .Columns("Qtde").Width = 20
                .Columns("Qtde").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Nv1").Width = 20
                .Columns("Nv1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Nv2").Width = 20
                .Columns("Nv2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Nv3").Width = 20
                .Columns("Nv3").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Nv4").Width = 20
                .Columns("Nv4").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Nv5").Width = 20
                .Columns("Nv5").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Nv6").Width = 20
                .Columns("Nv6").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Nv7").Width = 20
                .Columns("Nv7").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Nv8").Width = 20
                .Columns("Nv8").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Total").Width = 35
                .Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Total_Novo").Width = 35
                .Columns("Total_Novo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Chave_Acesso").Visible = False
                .Columns("Cod_Tipo_Comercial").Visible = False
                .Columns("Cod_Qualidade").Visible = False
                .Columns("Documento_De").Visible = False
                .Columns("Documento_Para").Visible = False
                .Columns("Indica_Demanda").Visible = False
                .Columns("Indica_Am").Visible = False
                .Columns("Indica_Horario").Visible = False
                .Columns("Merchandising").Visible = False
                .Columns("Qtde_novo").Visible = False
                .Columns("Indica_Falha").Visible = False
                .Columns("Indica_Falha").Visible = False
                .Columns("Indica_Oriunda_AM").Visible = False

                .Columns("Data_Exibicao").HeaderText = "Data"
                .Columns("Cod_programa").HeaderText = "Prog."
                .Columns("Cod_Comercial").HeaderText = "Cod."
                .Columns("Titulo_Comercial").HeaderText = "Comercial"
                .Columns("Duracao").HeaderText = "Dur."
                .Columns("Qtde").HeaderText = "Qtd."
                .Columns("Nv1").HeaderText = ""
                .Columns("Nv2").HeaderText = ""
                .Columns("Nv3").HeaderText = ""
                .Columns("Nv4").HeaderText = ""
                .Columns("Nv5").HeaderText = ""
                .Columns("Nv6").HeaderText = ""
                .Columns("Nv7").HeaderText = ""
                .Columns("Nv8").HeaderText = ""
                .Columns("Total_Novo").HeaderText = "Total"
                .Columns("Data_Exibicao").DefaultCellStyle.Format = "dd/MM/yyyy"
                For x As Integer = 0 To .Columns.Count - 1
                    .Columns(x).SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                For Each rw As DataGridViewRow In .Rows
                    If Vernulo(.Item("Indica_Oriunda_Am", rw.Index).Value, 0) = 1 Then
                        rw.DefaultCellStyle.ForeColor = Color.Red
                    End If
                    If Vernulo(.Item("Indica_Falha", rw.Index).Value, 0) = 1 Then
                        rw.DefaultCellStyle.ForeColor = Color.Blue
                    End If
                Next


            End With
            
            Carrega_Grid_Determinado = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Cursor = Cursors.Default '
        End Try

    End Function


    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            With frmDeterminacaoConsulta
                .ShowDialog()
                If .DeterminarClick Then
                    txtEmpresa.Text = .Empresa
                    txtContrato.Text = .Contrato
                    txtSeq.Text = .Sequencia
                    btnExibir.PerformClick()
                    txtEmpresa.Focus()
                End If
                .Dispose()
            End With


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub frmDeterminacao_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 10
        Me.Left = 10
        btnOpcoes.Items("btnincluir").Enabled = False
        txtEmpresa.Usuario = gsUsuario
        txtVeiculo.Usuario = gsUsuario
        btnOpcoes.Items("btnConsultar").Enabled = True
    End Sub

    Public Sub dgvComercial_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvComercial.MouseDown
        Try
            With dgvComercial
                nRow_Comercial = .HitTest(e.X, e.Y).RowIndex
                If nRow_Comercial >= 0 Then

                    If .Item("Cod_Comercial", nRow_Comercial).Value <> "" And nRow_Comercial >= 0 Then
                        .DoDragDrop(dgvComercial.Item("cod_comercial", nRow_Comercial).Value, DragDropEffects.Copy)
                    End If
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try


    End Sub

    Private Sub dgvDeterminacao_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgvDeterminacao.DragDrop
        Try

            Dim nColuna As Integer
            Dim bSelecionou_Linha As Boolean

            With dgvDeterminacao

                Dim clientPoint As Point = .PointToClient(New Point(e.X, e.Y))
                Dim nRow_Determinacao As Integer = .HitTest(clientPoint.X, clientPoint.Y).RowIndex

                '.Visible = False
                bSelecionou_Linha = False

                ' Verifica se Qualidade Cancela a Demanda
                If isEmptyCell(.Item("Cod_Programa", nRow_Determinacao)) Then
                    Exit Sub
                End If

                'Verifica se são mesmos tipos de comercial
                If dgvComercial.Item("Cod_Tipo_Comercial", nRow_Comercial).Value <> .Item("Cod_Tipo_Comercial", nRow_Determinacao).Value Then
                    If chkMostraMensagem.Checked = True Then
                        MsgBox("Tipos de Comercial Diferentes." & Chr(13) & "Dia " & .Item("Data_Exibicao", nRow_Determinacao).Value & _
                              " / Programa " & .Item("cod_Programa", nRow_Determinacao).Value & " / Comercial " & .Item("Cod_Comercial", nRow_Determinacao).Value & ".")
                    End If
                    Exit Sub
                End If

                'Verifica se é o mesmo comercial
                If dgvComercial.Item("Cod_Comercial", nRow_Comercial).Value = .Item("Cod_Comercial", nRow_Determinacao).Value Then
                    If chkMostraMensagem.Checked = True Then
                        Aviso("Não é Possível Trocar pelo Mesmo Comercial. " & Chr(13) & "Dia " & .Item("Data_Exibicao", nRow_Determinacao).Value & _
                              " / Programa " & .Item("cod_Programa", nRow_Determinacao).Value & " / Comercial " & .Item("Cod_Comercial", nRow_Determinacao).Value & ".")
                    End If
                    Exit Sub
                End If

                'Verifica se existe espaço para a determinação
                If dgvComercial.Item("Merchandising", nRow_Comercial).Value = "1" Then
                    If Val(.Item("Qtde", nRow_Determinacao).Value) <= Val(.Item("Total_Novo", nRow_Determinacao).Value) Then
                        If chkMostraMensagem.Checked = True Then
                            Aviso("Qtd. Determinada Maior do que Qtd. Disponível." & Chr(13) & "Dia " & .Item("Data_Exibicao", nRow_Determinacao).Value & _
                            " / Programa " & .Item("cod_Programa", nRow_Determinacao).Value & " / Comercial " & .Item("Cod_Comercial", nRow_Determinacao).Value & ".")
                        End If
                        Exit Sub
                    End If
                ElseIf Val(.Item("Total", nRow_Determinacao).Value) < (Val(dgvComercial.Item("Duracao", nRow_Comercial).Value) + Val(.Item("Total_Novo", nRow_Determinacao).Value)) Then
                    If chkMostraMensagem.Checked = True Then
                        Aviso("Duração Maior do que o Disponível." & Chr(13) & "Dia " & .Item("Data_Exibicao", nRow_Determinacao).Value & _
                            " / Programa " & .Item("cod_Programa", nRow_Determinacao).Value & " / Comercial " & .Item("Cod_Comercial", nRow_Determinacao).Value & ".")
                        Exit Sub
                    Else
                        Exit Sub
                    End If

                    'Verifica se vem de am e duração é diferente
                    If Val(dgvComercial.Item("Duracao", nRow_Comercial).Value) <> Val(.Item("Total", nRow_Determinacao).Value) And Val(.Item("Indica_Am", nRow_Determinacao).Value) <> 0 Then
                        If chkMostraMensagem.Checked = True Then
                            Aviso("Veiculação oriunda de AM e durações diferentes." & Chr(13) & "Dia " & .Item("Data_Exibicao", nRow_Determinacao).Value & _
                            " / Programa " & .Item("cod_Programa", nRow_Determinacao).Value & " / Comercial " & .Item("Cod_Comercial", nRow_Determinacao).Value & ".")
                            Exit Sub
                        End If
                        Exit Sub
                    End If

                End If

                '=================================Substitui o Comercial
                For nColuna = 7 To 14
                    If .Item(nColuna, nRow_Determinacao).Value.trim = "" Then
                        .Item(nColuna, nRow_Determinacao).Value = dgvComercial.Item(0, nRow_Comercial).Value
                        Exit For
                    End If
                Next nColuna
                TotalizaSaldo()
                '=================Totaliza Saldo Fim
            End With

Saida:
            dgvDeterminacao.Visible = True
            Exit Sub

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub TotalizaSaldo()

        Dim intSoma As Integer = 0
        Dim strCodComercial As String = ""
        Dim intTotal As Integer = 0
        Dim intQtd As Integer = 0

        Try
            With dgvDeterminacao
                For Each Row As DataGridViewRow In .Rows
                    intQtd = 0
                    intTotal = 0

                    For nColuna As Integer = .Columns("NV1").Index To .Columns("NV8").Index
                        intSoma = 0
                        If .Item(nColuna, Row.Index).Value.trim <> "" Then
                            For row_comercial As Integer = 0 To dgvComercial.Rows.Count - 1
                                If dgvComercial.Item("Cod_Comercial", row_comercial).Value.ToString.Trim = .Item(nColuna, Row.Index).Value.trim Then
                                    intSoma = Integer.Parse(dgvComercial.Item("Duracao", row_comercial).Value)
                                    Exit For
                                End If
                            Next
                            If dgvComercial.Item("Merchandising", nRow_Comercial).Value = "1" Then
                                '.Item("Total_Novo", Row.Index).Value = Val(.Item("Total_Novo", Row.Index).Value) + 1
                                '.Item("Qtde_Novo", Row.Index).Value = Val(.Item("Total_Novo", Row.Index).Value) + 1
                                intTotal += 1
                                intQtd += 1

                            Else
                                intTotal += intSoma
                                intQtd += 1
                                '.Item("Total_novo", Row.Index).Value = Val(.Item("Total_novo", Row.Index).Value) + dgvComercial.Item("Duracao", nRow_Comercial).Value
                                '.Item("Qtde_Novo", Row.Index).Value = Val(.Item("Total_novo", Row.Index).Value) + 1
                            End If
                        End If
                    Next nColuna
                    .Item("Total_novo", Row.Index).Value = intTOtal
                    .Item("Qtde_Novo", Row.Index).Value = intQtd
                Next

            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            '========================Carrega Lista de Comerciais ja existentes
            Do '---Para continuar na inclusao ate usuario sair 
                Dim Restrito As New ArrayList
                Dim sExecute As String
                Dim nDeterminar As Integer
                With dgvComercial
                    For Each row As DataGridViewRow In dgvComercial.Rows '
                        Restrito.Add((.Item("Cod_Comercial", row.Index).Value))
                    Next
                End With
                frmComercial.CodigoRestrito = Restrito
                frmComercial.CodigoCliente = txtCliente.Text
                frmComercial.Caracteristica_Contrato = dtbContrato.Rows(0).Item("Caracteristica_Contrato")

                frmComercial.ShowDialog()
                If frmComercial.OkClick Then
                    With frmComercial
                        nDeterminar = .chkDeterminar.Checked

                        sExecute = "Execute prNet_Comercial_Insert "
                        sExecute += " @Par_Cod_Comercial            = '" & .txtCodigo.Text & "', "
                        sExecute += " @Par_Cod_Material             = Null ,"
                        sExecute += " @Par_Numero_Mr                = " & txtContrato.Text & ", "
                        sExecute += " @Par_Cod_Red_Produto          = " & .txtProduto.DataNumberValue & ", "
                        sExecute += " @Par_Cod_Empresa              = '" & txtEmpresa.Text & "', "
                        sExecute += " @Par_Sequencia_Mr             = " & txtSeq.Text & ", "
                        sExecute += " @Par_Cod_Tipo_Comercial       = '" & .txtTipoComercial.Text & "', "
                        sExecute += " @Par_Duracao                  = " & .txtDuracao.Text & ", "
                        sExecute += " @Par_Indica_Titulo_Determinar = " & nDeterminar & ", "
                        sExecute += " @Par_Nome_Produto             = '" & .txtProduto.Descricao & "', "
                        sExecute += " @Par_Numero_Fita              = Null ,"
                        sExecute += " @Par_Titulo_Comercial         = '" & .txtTitulo.Text & "', "
                        sExecute += " @Par_Matriz                   = Null ,"
                        sExecute += " @Par_Posicao                  = Null ,"
                        sExecute += " @Par_Data_Desativacao         = Null ,"
                        sExecute += " @Par_data_gravacao            = Null ,"
                        sExecute += " @Par_complemento              = Null ,"
                        sExecute += " @Par_Inicio_Programacao       = Null ,"
                        sExecute += " @Par_Fim_Programacao          = Null "
                        clsGeneric.fnSqlComando(sExecute)
                    End With
                    dgvComercial.AutoResizeRows()
                    Carrega_Grid_Comercial()
                    frmComercial.Dispose()
                Else
                    frmComercial.Dispose()
55:                 Exit Do
                End If
            Loop
            frmComercial.Dispose()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub AtualizaComercialDeterminado(ByVal pCodigo As String, _
                          ByVal pCodProduto As Int32, _
                          ByVal pTipoComercial As String, _
                          ByVal pDescricaoTipoComercial As String, _
                          ByVal pDuracao As Int32, _
                          ByVal pDeterminar As Boolean, _
                          ByVal pNomeProduto As String, _
                          ByVal pTituloComercial As String)


        Dim RwComercial() As DataRow = Nothing
        Dim rwNewRow As DataRow = Nothing
        Dim bolAdicionaRow As Boolean = False
        Try
            RwComercial = dtsComercial.Tables(0).Select("Cod_Comercial = '" & pCodigo & "'")
            If RwComercial.Length > 0 Then
                rwNewRow = RwComercial(0)
            Else
                rwNewRow = dtsComercial.Tables(0).NewRow
                bolAdicionaRow = True
            End If

            rwNewRow("Cod_Comercial") = pCodigo
            rwNewRow("Titulo_Comercial") = pTituloComercial
            rwNewRow("Duracao") = pDuracao
            rwNewRow("Cod_Tipo_Comercial") = pTipoComercial
            rwNewRow("Numero_Fita") = DBNull.Value
            rwNewRow("Nome_Produto") = pNomeProduto
            rwNewRow("Indica_Titulo_Determinar") = pDeterminar

            rwNewRow("Cod_Red_Produto") = pCodProduto
            rwNewRow("Cod_Empresa") = txtEmpresa.Text
            rwNewRow("Cod_Material") = DBNull.Value
            rwNewRow("Cod_Tipo_Comercial") = pTipoComercial
            rwNewRow("Descricao_Tipo_Comercial") = pDescricaoTipoComercial
            rwNewRow("complemento") = DBNull.Value
            rwNewRow("Data_Desativacao") = DBNull.Value
            rwNewRow("data_gravacao") = DBNull.Value
            rwNewRow("Fim_Programacao") = DBNull.Value
            rwNewRow("Indica_Titulo_Determinar") = pDeterminar
            rwNewRow("Inicio_Programacao") = DBNull.Value
            rwNewRow("Matriz") = DBNull.Value
            rwNewRow("Nome_Produto") = pNomeProduto
            rwNewRow("Numero_Fita") = DBNull.Value
            '  rwNewRow("Numero_Mr") = txtNumeroMr.DataNumberValue
            rwNewRow("Posicao") = DBNull.Value
            '  rwNewRow("Sequencia_Mr") = txtSequenciaMr.DataNumberValue
            rwNewRow("Titulo_Comercial") = pTituloComercial
            If bolAdicionaRow Then
                dtsComercial.Tables("Comercial").Rows.Add(rwNewRow)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Dim nResponde As MsgBoxResult
        Try
            nResponde = MsgBox("Deseja Cancelar os Movimentos realizados?", MsgBoxStyle.YesNo)
            If nResponde = MsgBoxResult.No Then
                Exit Sub
            End If
            Carrega_Geral()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Salva_Determinacao()


        Dim nLinha As Integer
        Dim bDeterminar As Boolean
        Dim nIndice_Chave As Integer
        Dim dData_Exibicao As Date
        Dim sCod_Comercial As String
        Dim sQualidade As String
        Dim nQtd_Comercial As Integer = 0
        Dim nInicio, nFim As Integer
        Dim nValor_Total As Integer
        Dim nControla_Coluna As Integer
        Dim strResultado As String = ""

        Try

            txtMensagem.Text = "Aguarde... Determinando Comerciais do Veículo " & Trim(txtVeiculo.Text) & "..."
            clsContrato.fnDeterminacao_Delete(txtEmpresa.Text, txtContrato.DataNumberValue, txtSeq.DataNumberValue, gsUsuario)

            bDeterminar = False
            With dgvDeterminacao
                Dim nColuna As Integer
                For Each row As DataGridViewRow In .Rows
                    If .Item("Total_Novo", row.Index).Value <> 0 Then
                        bDeterminar = True
                        If .Item("Total", row.Index).Value <> .Item("Total_Novo", row.Index).Value Then
                            For nColuna = 7 To 14
                                For Each row2 As DataGridViewRow In dgvComercial.Rows
                                    If Trim(.Item(nColuna, row.Index).Value) = Trim(dgvComercial.Item("Cod_Comercial", row2.Index).Value) Then
                                        If Val(.Item("Duracao", row.Index).Value) <> Val(dgvComercial.Item("Duracao", row2.Index).Value) Then
                                            MsgBox("Duração de Comerciais Divergentes." & Chr(13) & "Dia " & .Item("Data_Exibicao", row.Index).Value & _
                                            " / Programa " & .Item("Cod_Programa", row.Index).Value & " / Comercial " & .Item("Cod_Comercial", row.Index).Value, MsgBoxStyle.Critical)
                                            GoTo Saida
                                        End If
                                    End If
                                Next
                            Next
                        End If
                    End If
                Next
                If Not bDeterminar Then
                    MsgBox("Não Existem Comerciais à Serem Determinados.", MsgBoxStyle.Critical)
                    GoTo Saida
                End If
                For Each row As DataGridViewRow In .Rows

                    ' Verifica se Qualidade Cancela a Demanda
                    If isEmptyCell(.Item("Total_Novo", row.Index)) Then
                        GoTo Proximo
                    ElseIf Val(.Item("Total_Novo", row.Index).Value) = 0 Then
                        GoTo Proximo
                    ElseIf .Rows(row.Index).Visible = False Then
                        GoTo Proximo
                    End If

                    nValor_Total = .Item("Total", row.Index).Value
                    nQtd_Comercial = .Item("Qtde", row.Index).Value
                    If nQtd_Comercial = 1 Then
                        nInicio = row.Index
                        nFim = row.Index
                    Else
                        nInicio = row.Index - (nQtd_Comercial - 1)
                        nFim = row.Index
                    End If

                    'Faz o contador pela quantidade d5e comerciais
                    nIndice_Chave = 0
                    nControla_Coluna = 7
                    For nLinha = nInicio To nFim
                        If nLinha = nInicio Then
                            nIndice_Chave = .Item("Chave_acesso", nLinha).Value
                        End If
                        If Trim(.Item(nControla_Coluna, row.Index).Value) = "" Then Exit For
                        sCod_Comercial = .Item("Cod_Comercial", nLinha).Value.ToString.Trim
                        sQualidade = IIf(Vernulo(.Item("Cod_Qualidade", nLinha).Value, "") = "", "0", "1")
                        dData_Exibicao = FormatDateTime(.Item("Data_Exibicao", nLinha).Value, DateFormat.GeneralDate)

                        clsContrato.fnDeterminacao_Insert(txtEmpresa.Text, _
                                                            txtContrato.DataNumberValue, _
                                                            txtSeq.DataNumberValue, _
                                                            txtVeiculo.Text, _
                                                            dData_Exibicao, _
                                                            .Item("Cod_Programa", nLinha).Value, _
                                                            .Item("Chave_Acesso", nLinha).Value, _
                                                            sCod_Comercial, _
                                                            1, _
                                                            0, _
                                                            gsUsuario, _
                                                            sQualidade)

                        nControla_Coluna += 1
                        If nControla_Coluna > 14 Then
                            Exit For
                        End If
                    Next nLinha

                    'Inclui os comerciais que estão entrando
                    For nColuna = 7 To 14
                        If Trim(.Item(nColuna, row.Index).Value) = "" Then Exit For

                        dData_Exibicao = FormatDateTime(.Item("Data_Exibicao", row.Index).Value, DateFormat.GeneralDate)
                        sQualidade = IIf(Vernulo(.Item("Cod_Qualidade", row.Index).Value, "") = "", "0", "1")
                        sCod_Comercial = .Item(nColuna, row.Index).Value.ToString.Trim
                        clsContrato.fnDeterminacao_Insert(txtEmpresa.Text, _
                                                            txtContrato.DataNumberValue, _
                                                            txtSeq.DataNumberValue, _
                                                            txtVeiculo.Text, _
                                                            dData_Exibicao, _
                                                            .Item("Cod_Programa", row.Index).Value, _
                                                            nIndice_Chave, _
                                                            sCod_Comercial, _
                                                            0, _
                                                            1, _
                                                            gsUsuario, _
                                                            sQualidade)
                    Next nColuna
Proximo:
                Next

                strResultado = clsContrato.fnDeterminacao_Comerciais(txtEmpresa.Text, txtContrato.Text, txtSeq.Text, gsUsuario)
                If String.IsNullOrEmpty(strResultado) Then
                    Aviso("Determinação Concluída Com Sucesso.")
                    Carrega_Geral()
                    txtMensagem.Text = ""
                Else
                    Aviso(strResultado)
                End If
            End With
Saida:
            txtMensagem.Text = ""
            dgvDeterminacao.Visible = True
            Exit Sub

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try
            If Trim(txtEmpresa.Text) = "" Then
                Aviso("Empresa não Pode Ficar em Branco.")
                Exit Sub
            End If

            If Trim(txtContrato.Text) = "" Then
                Aviso("Contrato não Pode Ficar em Branco.")
                Exit Sub
            End If

            If Trim(txtSeq.Text) = "" Then
                Aviso("Sequência não Pode Ficar em Branco.")
                txtSeq.Focus()
                Exit Sub
            End If

            If txtVeiculo.Text.Trim = "" Then
                Aviso("Veiculo não Pode Ficar em Branco.")
            End If

            Salva_Determinacao()
            Exit Sub
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Button1_AutoSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnDeterminarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntDeterminarTodos.Click
        Try
            sEmpresa = txtEmpresa.Text
            iContrato = Val(txtContrato.Text)
            iSeq = Val(txtSeq.Text)
            If sEmpresa.Trim = "" Or iContrato = 0 Or iSeq = 0 Or txtVeiculo.Text.Trim = "" Then
                Aviso("Empresa/Contrato/Sequencia devem ser preenchidos")
                Exit Try
            End If

            With frmDeterminacaoComercial
                .Empresa = txtEmpresa.Text
                .Contrato = txtContrato.DataNumberValue
                .Sequencia = txtSeq.DataNumberValue
                .Veiculo = txtVeiculo.Text
                .dtsComercialDeterminar = Me.dtsComercial.Copy
                .dtsComercialNovo = Me.dtsComercial.Copy
                .ShowDialog()
                If .OkClick Then
                    btnExibir.PerformClick()
                    .Dispose()
                End If
                .Dispose()
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub


    Private Sub dgvDeterminacao_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgvDeterminacao.DragOver
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub txtContrato_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContrato.Validated
        txtVeiculo.Text = ""
        txtVeiculo.Descricao = ""
        txtAgencia.Text = ""
        txtAgencia.Descricao = ""
        txtCliente.Text = ""
        txtCliente.Descricao = ""
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Dispose()
    End Sub

    Public Sub New()
        Me.MdiParent = mdiPrincipal
        InitializeComponent()

    End Sub

    Private Sub btnLimparCelula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparCelula.Click
        Dim bSelecionado As Boolean = True
        Try

            With dgvDeterminacao
                For Each cell As DataGridViewCell In .SelectedCells
                    If cell.ColumnIndex >= .Columns("Nv1").Index And cell.ColumnIndex <= .Columns("Nv8").Index Then
                        cell.Value = DBNull.Value
                        bSelecionado = True
                    End If
                Next

                If Not bSelecionado Then
                    Aviso("Nenhuma Determinação está selecionada para limpar")
                    Exit Try
                End If

                Me.TotalizaSaldo()

            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
End Class
