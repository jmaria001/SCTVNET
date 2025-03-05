Public Class frmAM
    Dim dtbFiltro As DataTable
    Dim dtsAM As DataSet
    Dim dbtCompetencia As DataTable
    Dim dtbMidia As DataTable
    Dim dtbMotivoFalha As DataTable
    Dim clsAM As MSAClass.AsmxAM.asmxAM
    Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
    Dim intContratoAtual As Int32
    Dim shtSequenciaAtual As Short
    Dim strDocumentoAtual As String
    Dim strVeiculoAtual As String
    Dim intCompetenciaAtual As Int32
    Dim dtbListaFalhas As DataTable
    Dim dtbCompensacao As DataTable
    Dim dtbSaldo As DataTable
    Dim bolShowFiltro As Boolean = True
    Dim strProgramaSaldoAtual As String = ""
    Dim strCompetenciaSaldoAtual As Int32 = 0

    Private Sub frmAM_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        frmAmFiltro.Dispose()
        frmAmReencaixe.Dispose()
        frmSolucaoAM.Dispose()
    End Sub
    Private Sub frmAM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim strCompetencia As String = ""
        Dim strNucleo As String = ""
        Dim strContato As String = ""
        Dim strCliente As String = ""
        Dim strAgencia As String = ""
        Dim strVeiculo As String = ""
        Dim lngProduto As Long = 0
        Dim strEmpresa As String = ""
        Dim lngContrato As Long = 0
        Dim bolMerchandising As Boolean
        Dim shtSequencia As Short = 0
        Dim strCod_Programa_Merchandising As String = ""
        Dim StrCod_Programa As String = ""

        Try
            If bolShowFiltro Then
                frmAmFiltro.ShowDialog()
            End If
            If frmAmFiltro.OkClick Then
                clsAM = NewAM()
                dtbFiltro = New DataTable
                dtsAM = New DataSet
                dbtCompetencia = New DataTable
                dtbMidia = New DataTable
                dtbMotivoFalha = New DataTable
                dtbListaFalhas = New DataTable
                dtbCompensacao = New DataTable
                dtbSaldo = New DataTable

                gridAm.DataSource = Nothing
                gridCompensacao.DataSource = Nothing
                gridListaFalhas.DataSource = Nothing
                gridMidia.DataSource = Nothing
                gridResumoMotivo.DataSource = Nothing
                gridSaldo.DataSource = Nothing

                intContratoAtual = 0
                shtSequenciaAtual = 0
                strDocumentoAtual = ""
                strVeiculoAtual = ""
                intCompetenciaAtual = 0

                LimpaCampos(GroupCompensar)
                lblQtdFalha.Text = ""
                lblQtdCompensacao.Text = ""
                lblQtdDiferenca.Text = ""
                lblValorFalha.Text = ""
                lblValorCompensacao.Text = ""
                lblValorDiferenca.Text = ""
                lblValorEncaixado.Text = ""
                lblValorFalhaAm.Text = ""
                lblValorFalhaOutra.Text = ""
                lblValorTotal.Text = ""


                If frmAmFiltro.ucCompetencia.Text <> "" Then
                    strCompetencia = frmAmFiltro.ucCompetencia.Text.Substring(3, 4) & frmAmFiltro.ucCompetencia.Text.Substring(0, 2)
                End If


                Me.Cursor = Cursors.WaitCursor
                strNucleo = frmAmFiltro.ucNucleo.Text.Trim
                strContato = frmAmFiltro.ucContato.Text.Trim
                strCliente = frmAmFiltro.ucCLiente.Text.Trim
                strAgencia = frmAmFiltro.ucAgencia.Text.Trim
                strVeiculo = frmAmFiltro.ucVeiculo.Text.Trim
                lngProduto = 0 ' frmAmFiltro.ucProduto.DataNumberValue
                strEmpresa = frmAmFiltro.ucEmpresa.Text.Trim
                lngContrato = frmAmFiltro.ucContrato.DataNumberValue
                shtSequencia = frmAmFiltro.ucSequencia.DataNumberValue
                bolMerchandising = False
                strCod_Programa_Merchandising = ""
                StrCod_Programa = frmAmFiltro.ucPrograma.Text.Trim
                dtbFiltro = clsAM.AmPendente(sEmpresadoUsuario, _
                                                strCompetencia, _
                                                strNucleo, _
                                                strContato, _
                                                strCliente, _
                                                strAgencia, _
                                                strVeiculo, _
                                                lngProduto, _
                                                strEmpresa, _
                                                lngContrato, _
                                                shtSequencia, _
                                                bolMerchandising, _
                                                strCod_Programa_Merchandising, _
                                                StrCod_Programa)

                If dtbFiltro.Rows.Count = 0 Then
                    Aviso("Nenhuma AM foi encontrada com esse filtro")
                    Exit Try
                End If
                Me.Cursor = Cursors.Default

                Call EstiloGrid(gridAm, 1)
                With gridAm

                    bdsAM.DataSource = dtbFiltro
                    bdnAM.BindingSource = bdsAM
                    .DataSource = bdsAM
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    .AutoResizeColumns()
                    .RowHeadersVisible = True
                    .Columns("Cod_Agencia").DisplayIndex = 0
                    .Columns("Cod_Cliente").DisplayIndex = 1
                    .Columns("Descricao").DisplayIndex = 2
                    .Columns("Cod_Veiculo").DisplayIndex = 3
                    .Columns("Cod_Veiculo").DisplayIndex = 4
                    .Columns("Periodo_Campanha").DisplayIndex = 5
                    .Columns("Cod_Empresa").DisplayIndex = 7
                    .Columns("Numero_Mr").DisplayIndex = 8
                    .Columns("Sequencia_Mr").DisplayIndex = 9
                    .Columns("Numero_PI").DisplayIndex = 10
                    .Columns("Numero_Docto").DisplayIndex = 11
                    .Columns("Cod_Tipo_Midia").DisplayIndex = 12

                    .Columns("Cod_Agencia").HeaderText = "Agência"
                    .Columns("Cod_Cliente").HeaderText = "Cliente"
                    .Columns("Descricao").HeaderText = "Produto"
                    .Columns("Cod_Veiculo").HeaderText = "Veiculo"
                    .Columns("Periodo_Campanha").HeaderText = "Período da Campanha"
                    .Columns("Cod_Empresa").HeaderText = "Empresa"
                    .Columns("Numero_Mr").HeaderText = "Contrato"
                    .Columns("Sequencia_Mr").HeaderText = "Seq."
                    .Columns("Numero_PI").HeaderText = "Numero Pi"
                    .Columns("Numero_Docto").HeaderText = "AM"
                    .Columns("Cod_Tipo_Midia").HeaderText = "Tp Mídia"

                    .Columns("Cod_Red_Produto").Visible = False
                    .Columns("Cod_Caracteristica").Visible = False
                    .Columns("Cod_Usuario_Liberacao").Visible = False
                    .Columns("Data_Liberacao").Visible = False
                    .Columns("Indica_Grade").Visible = False
                    .Columns("Nom_Agencia").Visible = False
                    .Columns("Nom_Cliente").Visible = False
                    .Columns("Periodo_Campanha_Inicio").Visible = False
                    .Columns("Periodo_Campanha_Termino").Visible = False
                    .Columns("Numero_Negociacao").Visible = False
                    .Columns("Fatura_Antecipada").Visible = False
                    .Columns("Nome_Veiculo").Visible = False
                    .Columns("Indica_Desencaixe").Visible = False
                End With
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
            bolShowFiltro = True
        End Try



    End Sub


    Public Sub New()
        Me.MdiParent = mdiPrincipal
        InitializeComponent()

    End Sub

    Private Sub bdsAM_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdsAM.CurrentChanged
        Dim strDisplay As String = ""
        Dim strQueryComercial As String
        Dim dtsComercial As DataSet = New DataSet
        Try
            With bdsAM
                If .Current Is Nothing Then
                    Exit Try
                End If
                strDisplay += "Contrato:"
                strDisplay += .Current("Cod_Empresa") + "-"
                strDisplay += .Current("Numero_MR").ToString + "-"
                strDisplay += .Current("Sequencia_MR").ToString + "      "
                strDisplay += "AM::" + .Current("Numero_Docto") + "     "
                strDisplay += "Veiculo::" + .Current("COd_Veiculo") + "     "
                lblAM.Text = strDisplay

                ucPrograma.Veiculo = .Current("COd_Veiculo")
                ucComercial.Cod_Empresa = .Current("Cod_Empresa")
                ucComercial.Contrato = .Current("Numero_MR")
                ucComercial.Seq = .Current("Sequencia_MR")


                Me.CarregaComboCompetencia()
                Me.CarregaListaFalhas()
                Me.CarregaGridCompensacao()
                Me.MostraResumoTotais()
                Me.gridSaldo.DataSource = Nothing
                dtbSaldo.Clear()
                LimpaCampos(GroupCompensar)




                '======================Guarda o ultimo para nao carregar se repetir
                intContratoAtual = .Current("Numero_MR")
                shtSequenciaAtual = .Current("Sequencia_MR")
                strDocumentoAtual = .Current("Numero_Docto")
                strVeiculoAtual = .Current("COd_Veiculo")

                '======================Seta objetos necessarios
                ucComercial.Cod_Empresa = .Current("Cod_Empresa")
                ucComercial.Contrato = .Current("Numero_Mr")
                ucComercial.Seq = .Current("Sequencia_Mr")

                '================Se tiver apenas um comercial, preenche o campo 
                dtsComercial = New DataSet
                strQueryComercial = " execute prNet_Comercial_L '" & ucComercial.Cod_Empresa & "'," & ucComercial.Contrato.ToString & "," & ucComercial.Seq.ToString
                dtsComercial = clsGeneric.fnSqlExecute(strQueryComercial)

                If dtsComercial.Tables(0).Rows.Count = 1 Then
                    ucComercial.Text = dtsComercial.Tables(0).Rows(0).Item("Cod_Comercial")
                    ucComercial.Descricao = dtsComercial.Tables(0).Rows(0).Item("Titulo_Comercial")

                End If

            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub cboCompetencia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCompetencia.SelectedIndexChanged
        Me.CarregaGridMidia()
        Me.CarregaGridResumoMotivo()
    End Sub

    Private Sub CarregaGridMidia()
        Dim intCompetencia As Int32 = 0
        Dim strData As String = ""
        Dim btDiaSemana As Byte = 0
        Dim btStatus As Byte = 0
        Dim decEncaixados As Decimal = 0
        Dim decFalhasAm As Decimal = 0
        Dim decFalhasOutras As Decimal = 0

        Dim IntQtdEncaixados As Integer = 0
        Dim IntQtdFalhasAm As Integer = 0
        Dim IntQtdFalhasOutras As Integer = 0


        Try
            intCompetencia = fnCompetenciaExtensoToNumero(cboCompetencia.SelectedItem)
            dtbMidia.Clear()
            gridMidia.DataSource = Nothing

            With bdsAM
                If intContratoAtual <> .Current("Numero_Mr") _
                    Or shtSequenciaAtual <> .Current("Sequencia_Mr") _
                    Or strVeiculoAtual <> .Current("Cod_Veiculo") _
                    Or intCompetenciaAtual <> intCompetencia Then
                    dtbMidia = clsAM.VisualizarMidia(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_Mr"), .Current("Cod_Veiculo"), .Current("Numero_Docto"), intCompetencia)
                    With gridMidia

                        .DataSource = dtbMidia
                        .ReadOnly = True
                        .AllowUserToAddRows = False
                        .AllowUserToResizeColumns = False
                        .RowHeadersVisible = False
                        .EnableHeadersVisualStyles = False
                        .AllowUserToResizeRows = False
                        .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
                        .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor

                        .Columns("Falha_da_AM").Visible = False
                        .Columns("Falha_Outra_AM").Visible = False


                        .Columns("Cod_Caracteristica").HeaderText = "CV"
                        .Columns("Cod_Comercial").HeaderText = "Com"
                        .Columns("Cod_Programa").HeaderText = "Programa"
                        .Columns("Total_Qtd").HeaderText = "Total Qtd"
                        .Columns("Total_Valor").HeaderText = "Total Valor"

                        .Columns("Total_Qtd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns("Total_Valor").DefaultCellStyle.Format = "N2"
                        .Columns("Total_Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                        .Columns("Cod_programa").Width = 60
                        .Columns("Cod_Caracteristica").Width = 30
                        .Columns("Cod_Comercial").Width = 27


                        For x As Byte = .Columns("01").Index To .Columns("31").Index
                            .Columns(x).Width = 25
                            .Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            If Byte.Parse(.Columns(x).HeaderText) <= LastDay(intCompetencia) Then
                                strData = .Columns(x).HeaderText & "/" & intCompetencia.ToString.Substring(4, 2) & "/" & intCompetencia.ToString.Substring(0, 4)
                                btDiaSemana = Weekday(FormatDateTime(strData, DateFormat.GeneralDate))
                                .Columns(x).HeaderText = " " & WeekdayName(btDiaSemana).ToUpper.Substring(0, 1) & vbCrLf & .Columns(x).HeaderText
                            Else
                                .Columns(x).Visible = False
                            End If
                            If btDiaSemana = 1 Then
                                .Columns(x).HeaderCell.Style.ForeColor = Color.Red
                            End If
                        Next

                        '=====================Acha o status da linha 
                        For x As Integer = 0 To .Rows.Count - 1
                            If .Item("Falha_da_AM", x).Value = 1 Then
                                btStatus = 2
                                decFalhasAm += .Item(.Columns("Total_Valor").Index, x).Value
                                IntQtdFalhasAm += .Item(.Columns("Total_QTD").Index, x).Value

                            ElseIf .Item("Falha_Outra_AM", x).Value = 1 Then
                                btStatus = 3
                                decFalhasOutras += .Item(.Columns("Total_Valor").Index, x).Value
                                IntQtdFalhasOutras += .Item(.Columns("Total_QTD").Index, x).Value
                            Else
                                btStatus = 1
                                decEncaixados += .Item(.Columns("Total_Valor").Index, x).Value
                                IntQtdEncaixados += .Item(.Columns("Total_QTD").Index, x).Value
                            End If
                            '=====================COr do status 
                            Select Case btStatus
                                Case 2
                                    For y As Integer = .Columns("01").Index To .Columns("31").Index
                                        If Not isEmptyCell(.Item(y, x)) Then
                                            .Item(y, x).Style.BackColor = Color.Red
                                            .Item(y, x).Style.ForeColor = Color.White
                                            .Item(y, x).Style.SelectionBackColor = Color.Red
                                            .Item(y, x).Style.SelectionForeColor = Color.White
                                        End If
                                    Next

                                Case 3
                                    For y As Integer = .Columns("01").Index To .Columns("31").Index
                                        If Not isEmptyCell(.Item(y, x)) Then
                                            .Item(y, x).Style.BackColor = Color.Blue
                                            .Item(y, x).Style.ForeColor = Color.White
                                            .Item(y, x).Style.SelectionBackColor = Color.Blue
                                            .Item(y, x).Style.SelectionForeColor = Color.White
                                        End If
                                    Next
                            End Select
                        Next
                        For x As Integer = 0 To .Columns.Count - 1
                            .Columns(x).SortMode = DataGridViewColumnSortMode.NotSortable
                        Next
                        .Refresh()
                    End With
                    '=====================Mostra totas 
                    lblValorEncaixado.Text = Format(decEncaixados, "0,00.00")
                    lblValorFalhaAm.Text = Format(decFalhasAm, "0,00.00")
                    lblValorFalhaOutra.Text = Format(decFalhasOutras, "0,00.00")
                    lblValorTotal.Text = Format(decEncaixados + decFalhasAm + decFalhasOutras, "0,00.00")

                    lblQtdEncaixado.Text = IntQtdEncaixados
                    lblQtdFalhaAm.Text = IntQtdFalhasAm
                    lblQtdFalhaOutra.Text = IntQtdFalhasOutras
                    lblQtdTotal.Text = IntQtdEncaixados + IntQtdFalhasAm + IntQtdFalhasOutras



                End If
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub CarregaComboCompetencia()
        Try
            With bdsAM
                If Not .Current Is Nothing Then
                    If intContratoAtual <> .Current("Numero_Mr") _
                    Or shtSequenciaAtual <> .Current("Sequencia_Mr") _
                    Or strVeiculoAtual <> .Current("Cod_Veiculo") Then
                        cboCompetencia.Items.Clear()
                        dbtCompetencia = clsAM.CarregarCompetencia(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_Mr"), .Current("Cod_Veiculo"))
                        For Each row As DataRow In dbtCompetencia.Rows
                            cboCompetencia.Items.Add(fnCompetenciaNumeroToExtenso(row.Item("Competencia")))
                        Next
                        If cboCompetencia.Items.Count > 0 Then
                            cboCompetencia.SelectedIndex = 0
                        End If

                    End If
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaGridResumoMotivo()
        Dim intCompetencia As Int32 = 0
        Try
            intCompetencia = fnCompetenciaExtensoToNumero(cboCompetencia.SelectedItem)
            dtbMotivoFalha.Clear()
            gridResumoMotivo.DataSource = Nothing
            EstiloGrid(gridResumoMotivo, 1)
            With bdsAM
                With bdsAM
                    If intContratoAtual <> .Current("Numero_Mr") _
                    Or shtSequenciaAtual <> .Current("Sequencia_Mr") _
                    Or strVeiculoAtual <> .Current("Cod_Veiculo") _
                    Or intCompetenciaAtual <> intCompetencia Then
                        dtbMotivoFalha = clsAM.CarregarResumoMotivo(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_Mr"), .Current("Cod_Veiculo"), intCompetencia, .Current("Numero_Docto"))


                        With gridResumoMotivo
                            .DataSource = dtbMotivoFalha
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .AutoResizeColumns()
                            .AutoResizeRows()
                            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
                            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
                            '.Columns("Cod_Qualidade").HeaderText = "Qualidade"
                            .Columns("Descricao").HeaderText = "Motivo"
                            .Columns("Total_Valor").HeaderText = "Valor"
                            .Columns("Total_Qtd").HeaderText = "Qtd"
                            .Columns("Total_Valor").DefaultCellStyle.Format = "N2"
                            .Columns("Total_Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            .Columns("Total_Qtd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                        End With
                    End If
                End With

            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub CarregaListaFalhas()
        Dim intCompetencia As Int32 = 0
        Try
            intCompetencia = fnCompetenciaExtensoToNumero(cboCompetencia.SelectedItem)


            With bdsAM
                With bdsAM
                    If intContratoAtual <> .Current("Numero_Mr") _
                    Or shtSequenciaAtual <> .Current("Sequencia_Mr") _
                    Or strVeiculoAtual <> .Current("Cod_Veiculo") _
                    Or strDocumentoAtual <> .Current("Numero_Docto") Then
                        dtbListaFalhas.Clear()
                        gridListaFalhas.DataSource = Nothing
                        dtbListaFalhas = clsAM.CarregarListaFalhas(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_Mr"), .Current("Numero_Docto"))


                        With gridListaFalhas
                            EstiloGrid(gridListaFalhas, 1)
                            .ReadOnly = True
                            .RowHeadersVisible = False
                            .DataSource = dtbListaFalhas
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                            .AutoResizeColumns()
                            .AutoResizeRows()
                            .AllowUserToResizeRows = False
                            .AllowUserToAddRows = False

                            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
                            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
                            .Columns("Horario_Exibicao").Visible = False
                            .Columns("Indica_Demanda").Visible = False
                            .Columns("Data_Exibicao").HeaderText = "Data Exibição"
                            .Columns("Cod_Comercial").HeaderText = "Com"
                            .Columns("Duracao").HeaderText = "Dur"
                            .Columns("Cod_Qualidade").HeaderText = "Qual."
                            .Columns("Cod_Programa").HeaderText = "Prog"
                            .Columns("Valor").DefaultCellStyle.Format = "N2"

                            .Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            .Columns("Data_Exibicao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            .Columns("Data_Exibicao").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                            .Columns("Data_Exibicao").DefaultCellStyle.Format = "dd/MM/yyyy"

                           
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                            .AutoResizeColumns()


                        End With
                    End If
                End With

            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaGridCompensacao(Optional ByVal bolAtualizar As Boolean = False)
        Dim intCompetencia As Int32 = 0

        Try
            intCompetencia = fnCompetenciaExtensoToNumero(cboCompetencia.SelectedItem)
            With bdsAM

                If intContratoAtual <> .Current("Numero_Mr") _
                Or shtSequenciaAtual <> .Current("Sequencia_Mr") _
                Or strVeiculoAtual <> .Current("Cod_Veiculo") _
                Or strDocumentoAtual <> .Current("Numero_Docto") _
                Or bolAtualizar Then
                    dtbCompensacao.Clear()
                    gridCompensacao.DataSource = Nothing
                    dtbCompensacao = clsAM.CarregarListaCompensacao(.Current("Cod_Empresa"), .Current("Numero_Mr"), .Current("Sequencia_Mr"), .Current("Numero_Docto"))

                    With gridCompensacao
                        .Columns.Clear()
                        EstiloGrid(gridCompensacao, 1)
                        dtbCompensacao.Columns.Add("Check", GetType(System.Boolean))
                        For Each rw As DataRow In dtbCompensacao.Rows
                            rw.Item("Check") = False
                            dtbCompensacao.AcceptChanges()
                        Next
                        .ReadOnly = False
                        .RowHeadersVisible = False
                        .DataSource = dtbCompensacao
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                        .AutoResizeColumns()
                        .AutoResizeRows()
                        .AllowUserToResizeRows = False
                        .AllowUserToAddRows = False

                        .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
                        .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
                        .Columns("Horario_Exibicao").Visible = False
                        .Columns("Cod_Veiculo").Visible = False

                        .Columns("Chave_Acesso").Visible = False
                        .Columns("Indica_Demanda").Visible = False
                        .Columns("Data_Exibicao").HeaderText = "Data Exibição"
                        .Columns("Cod_Comercial").HeaderText = "Com"
                        .Columns("Duracao").HeaderText = "Dur"
                        .Columns("Cod_Qualidade").HeaderText = "Qual."
                        .Columns("Cod_Programa").HeaderText = "Prog"
                        .Columns("Valor").DefaultCellStyle.Format = "N2"
                        .Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns("Data_Exibicao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("Data_Exibicao").DefaultCellStyle.Format = "dd/MM/yyyy"
                        .Columns("Check").DisplayIndex = 0
                        .Columns("Check").HeaderText = ""


                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                        .Columns("Check").Width = 30
                        .Columns("Data_Exibicao").Width = 150
                        .Columns("Cod_Comercial").Width = 40
                        .Columns("Duracao").Width = 50
                        .Columns("Cod_Qualidade").Width = 60
                        .Columns("Cod_Programa").Width = 60
                        .Columns("Valor").Width = 100




                        For X As Integer = 0 To .Columns.Count - 1
                            If .Columns(X).Name.ToUpper = "CHECK" Then
                                .Columns(X).ReadOnly = False
                            Else
                                .Columns(X).ReadOnly = True
                            End If
                        Next
                    End With

                End If
            End With


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub ucDia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ucDia.Validating
        Dim strData As String
        Try
            If ucDia.Text.Trim <> "" Then
                ucDia.Text = ucDia.Text.PadLeft(2, "0")
                strData = ucDia.Text & "/" & ucCompetencia.Text
                If Not isData(strData) Then
                    Aviso("Data Inválida")
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnCompensar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCompensar.Click
        Dim bolErro As Boolean = False
        Dim dtExibicao As Date
        Dim strCritica As String = ""
        Try
            '========================Campos Obrigatorias
            For Each obj As Object In GroupCompensar.Controls
                If TypeOf obj Is WUC.UcText Then
                    If obj.obrigatorio And obj.Text.Trim = "" Then
                        obj.MensagemErro = "Campo de preenchimento obrigatório"
                        bolErro = True
                    End If
                End If
            Next
            If bolErro Then
                Aviso("Houve erro no preenchimento da Compensação. Passe ou Mouse sobre o simbolo do erro para visualizar")
                Exit Try
            End If






            '========================Insere a Compensação
            dtExibicao = DateTime.Parse(ucDia.Text.ToString.Trim.PadLeft(2, "0") & "/" & ucCompetencia.Text)


            With bdsAM
                strCritica = clsAM.InserirCompensacao(gsUsuario, _
                                                        .Current("Cod_Empresa"), _
                                                        .Current("Numero_Mr"), _
                                                        .Current("Sequencia_Mr"), _
                                                        ucComercial.Text, _
                                                        .Current("Cod_Veiculo"), _
                                                        dtExibicao, _
                                                        ucPrograma.Text, _
                                                        .Current("Numero_Docto"), _
                                                        .Current("Cod_Caracteristica"), _
                                                        ucQtd.DataNumberValue)

                If strCritica <> "" Then
                    Aviso(strCritica)
                    Exit Try
                End If

                Call CarregaGridCompensacao(True)
                '========================Recarrega dados 
                btnSaldo.PerformClick()
                Call MostraResumoTotais()
                ucDia.Text = ""
                'btnLimpar.PerformClick()



            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub MostraResumoTotais()
        Dim sumFalhas As Object
        Dim sumComp As Object
        Try
            lblQtdFalha.Text = dtbListaFalhas.Rows.Count.ToString
            lblQtdCompensacao.Text = dtbCompensacao.Rows.Count()
            lblQtdDiferenca.Text = (Integer.Parse(lblQtdFalha.Text) - Integer.Parse(lblQtdCompensacao.Text)).ToString


            sumFalhas = dtbListaFalhas.Compute("Sum(Valor)", "1=1")
            sumComp = dtbCompensacao.Compute("Sum(Valor)", "1=1")

            sumFalhas = Vernulo(sumFalhas, 0)
            sumComp = Vernulo(sumComp, 0)

            lblValorFalha.Text = ""
            lblValorCompensacao.Text = ""
            lblValorDiferenca.Text = ""

            

            lblValorFalha.Text = Format(sumFalhas, "0,00.00")
            lblValorCompensacao.Text = Format(sumComp, "0,00.00")
            lblValorDiferenca.Text = Format(sumFalhas - sumComp, "0,00.00")

            If sumComp > sumFalhas Then
                lblValorDiferenca.ForeColor = Color.Red
                lblValorDiferenca.Text = "(" & lblValorDiferenca.Text & ")"
            Else
                lblValorDiferenca.ForeColor = Color.Black
            End If


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnSaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldo.Click

        Dim intCompetencia As Int32 = 0

        Try



            If ucCompetencia.Text.Trim = "" Or ucPrograma.Text = "" Then
                Aviso("Para ver o saldo é necessário informar a competencia e o programa")
                Exit Try
            End If
            Call CarregaSaldo()
            'intCompetencia = fnCompetenciaStringtoInt(ucCompetencia.Text)
            'If intCompetencia = intCompetenciaAtual And ucPrograma.Text = strProgramaSaldoAtual Then
            '    Exit Try
            'End If

            'With bdsAM
            '    dtbSaldo.Clear()
            '    gridSaldo.DataSource = Nothing
            '    dtbSaldo = clsAM.CarregarSaldo(.Current("Cod_Veiculo"), ucPrograma.Text, intCompetencia, .Current("Indica_Grade"))

            '    If dtbSaldo.Rows.Count = 0 Then
            '        Aviso("Não existe grade disponivel para o mes " & ucCompetencia.Text & ", Veiculo " & .Current("Cod_Veiculo") & ", Programa " & ucPrograma.Text)

            '    End If

            '    With gridSaldo
            '        EstiloGrid(gridSaldo, 1)
            '        .ReadOnly = True
            '        .RowHeadersVisible = False
            '        .DataSource = dtbSaldo

            '        .Columns("Cod_Programa").HeaderText = "Programa"
            '        .Columns("Data_Exibicao").HeaderText = "Data"


            '        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            '        .AutoResizeColumns()
            '        .AutoResizeRows()
            '        .AllowUserToResizeRows = False
            '        .AllowUserToAddRows = False

            '        For Each Rw As DataGridViewRow In .Rows
            '            If .Item("Saldo", Rw.Index).Value <= 0 Then
            '                Rw.DefaultCellStyle.BackColor = Color.Red
            '                Rw.DefaultCellStyle.ForeColor = Color.White
            '            Else
            '                Rw.DefaultCellStyle.BackColor = Color.LightGreen
            '                Rw.DefaultCellStyle.ForeColor = Color.Black
            '            End If
            '        Next
            '    End With
            'End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            ' intCompetenciaAtual = intCompetencia
            'strProgramaSaldoAtual = ucPrograma.Text
        End Try
    End Sub

    Private Sub brnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnSair.Click
        Me.Close()
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        LimpaCampos(GroupCompensar)
        dtbSaldo.Clear()
    End Sub


    Private Sub gridSaldo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridSaldo.CellDoubleClick
        Try
            With gridSaldo
                ucDia.Text = DatePart(DateInterval.Day, .Item("Data_exibicao", e.RowIndex).Value)
                If ucQtd.Text = "" Then
                    ucQtd.Text = 1
                End If

                If ucComercial.Text <> "" And ucCompetencia.Text <> "" And ucPrograma.Text <> "" Then
                    btnCompensar.PerformClick()
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub



    Private Sub btnSolucao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolucao.Click
        Dim intCompetencia As Int32
        Try
            If bdsAM.Current Is Nothing Then
                Exit Sub
            End If
            With frmSolucaoAM
                .Cod_Empresa = bdsAM.Current("Cod_empresa")
                .NumeroMr = bdsAM.Current("Numero_Mr")
                .SequenciaMr = bdsAM.Current("Sequencia_MR")
                .Numero_Docto = bdsAM.Current("Numero_Docto")
                .lblContrato.Text = bdsAM.Current("Cod_Empresa") & "-" & bdsAM.Current("Numero_Mr").ToString & "-" & bdsAM.Current("Sequencia_Mr").ToString
                .lblVeiculo.Text = bdsAM.Current("Cod_Veiculo")
                intCompetencia = fnDataToCompetenciaInt(bdsAM.Current("Periodo_Campanha_Inicio"))
                .lblCompetencia.Text = fnCompetenciaNumeroToExtenso(intCompetencia)
                .lblFalhasQtd.Text = lblQtdFalha.Text
                .lblFalhasValor.Text = lblValorFalha.Text
                .lblCompensacaoQTD.Text = lblQtdCompensacao.Text
                .lblCompensacaoValor.Text = lblValorCompensacao.Text
                .lblDiferencaQtd.Text = lblQtdDiferenca.Text
                .lblDiferencaValor.Text = lblValorDiferenca.Text
                .lblAM.Text = bdsAM.Current("Numero_Docto")
                .lblDiferencaValor.ForeColor = lblValorDiferenca.ForeColor
                LimpaCampos(frmSolucaoAM.groupSolucao)
                If Integer.Parse(lblQtdCompensacao.Text) = 0 Then
                    .optPonderar.Enabled = False
                    .optFaturar.Enabled = False
                Else
                    .optFaturarSemCredito.Enabled = False
                End If
                .ShowDialog()

                If .Solucionado Then
                    dtbListaFalhas.Clear()
                    dtbMidia.Clear()
                    dtbMotivoFalha.Clear()
                    dtbCompensacao.Clear()
                    dtbSaldo.Clear()
                    LimpaCampos(GroupCompensar)
                    LimpaCampos(groupResumoDiferenca)
                    LimpaCampos(groupCompensacao)
                    btnLimpar.PerformClick()
                    lblQtdFalha.Text = ""
                    lblQtdCompensacao.Text = ""
                    lblQtdDiferenca.Text = ""
                    lblValorFalha.Text = ""
                    lblValorCompensacao.Text = ""
                    lblValorDiferenca.Text = ""
                    lblValorEncaixado.Text = ""
                    lblValorFalhaAm.Text = ""
                    lblValorFalhaOutra.Text = ""
                    lblValorTotal.Text = ""
                    lblqtdEncaixado.Text = ""
                    lblqtdFalhaAm.Text = ""
                    lblQtdFalhaOutra.Text = ""
                    lblQtdTotal.Text = ""

                    bdsAM.RemoveCurrent()

                End If
            End With
            If bdsAM.Count = 0 Then
            End If
            frmSolucaoAM.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

  
    Private Sub btnReencaixar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReencaixar.Click
        Try
            If bdsAM.Current Is Nothing Then
                Exit Try
            End If
            If Integer.Parse(lblQtdCompensacao.Text) > 0 Then
                Aviso("Não é permitido reencaixar falhas quando já tem compensação")
                Exit Try
            End If
            With frmAmReencaixe
                .lblEmpresa.Text = bdsAM.Current("Cod_Empresa")
                .lblContrato.Text = bdsAM.Current("Numero_MR")
                .lblSequencia.Text = bdsAM.Current("Sequencia_Mr")
                .lblVeiculo.Text = bdsAM.Current("Cod_Veiculo")
                .lblNomeVeiculo.Text = bdsAM.Current("Nome_Veiculo")
                .lblNumeroDocto.Text = bdsAM.Current("Numero_Docto")
                .CarregarFalhas()
                .ShowDialog()
                If .ClickOk Then
                    bolShowFiltro = False
                    btnFiltrar.PerformClick()
                End If
                .Dispose()
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim bolSelecionou As Boolean = True
        Dim bolOperacao As Boolean = False

        Try
            dtbCompensacao.AcceptChanges()
            gridCompensacao.EndEdit()
            For Each Rw As DataRow In dtbCompensacao.Rows
                If Not IsDBNull(Rw.Item("Check")) Then
                    If Rw.Item("Check") Then
                        bolSelecionou = True
                        Exit For
                    End If
                End If
            Next
            If Not bolSelecionou Then
                Aviso("Nenhuma Compensação foi selecionada para Excluir")
                Exit Sub
            End If
            clsAM.ExcluirCompensacao(dtbCompensacao, gsUsuario)
            Call CarregaGridCompensacao(True)
            Call MostraResumoTotais()
            btnLimpar.PerformClick()

        Catch ex As Exception
            ShowErro(ex)
        Finally

        End Try
    End Sub

    Private Sub ucCompetencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucCompetencia.Enter
    End Sub


    Private Sub ucCompetencia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucCompetencia.Validated
        Try
            If ucCompetencia.Text.Trim <> "" Then
                ucPrograma.DataInicio = PrimeiroDiadoMes(fnCompetenciaStringtoInt(ucCompetencia.Text), Nothing).ToString
                ucPrograma.DataFim = UltimoDiadoMes(fnCompetenciaStringtoInt(ucCompetencia.Text), Nothing).ToString
            Else
                ucPrograma.DataInicio = Nothing
                ucPrograma.DataFim = Nothing
            End If
            Me.CarregaSaldo()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub ucPrograma_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucPrograma.Validated
        Me.CarregaSaldo()
    End Sub
    Private Sub CarregaSaldo()

        Dim intCompetencia As Int32 = 0

        Try
            If ucCompetencia.Text.Trim = "" Or ucPrograma.Text.Trim = "" Then
                Exit Try
            End If
            intCompetencia = fnCompetenciaStringtoInt(ucCompetencia.Text)
            If intCompetencia = intCompetenciaAtual And ucPrograma.Text = strProgramaSaldoAtual Then
                Exit Try
            End If

            With bdsAM
                dtbSaldo.Clear()
                gridSaldo.DataSource = Nothing
                dtbSaldo = clsAM.CarregarSaldo(.Current("Cod_Veiculo"), ucPrograma.Text, intCompetencia, .Current("Indica_Grade"))

                If dtbSaldo.Rows.Count = 0 Then
                    Aviso("Não existe grade disponivel para o mes " & ucCompetencia.Text & ", Veiculo " & .Current("Cod_Veiculo") & ", Programa " & ucPrograma.Text)

                End If

                With gridSaldo
                    EstiloGrid(gridSaldo, 1)
                    .ReadOnly = True
                    .RowHeadersVisible = False
                    .DataSource = dtbSaldo

                    .Columns("Cod_Programa").HeaderText = "Programa"
                    .Columns("Data_Exibicao").HeaderText = "Data"
                    .Columns("Data_Exibicao").DefaultCellStyle.Format = "dd/MM/yyyy"


                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    .AutoResizeColumns()
                    .AutoResizeRows()
                    .AllowUserToResizeRows = False
                    .AllowUserToAddRows = False

                    For Each Rw As DataGridViewRow In .Rows
                        If .Item("Saldo", Rw.Index).Value <= 0 Then
                            Rw.DefaultCellStyle.BackColor = Color.Red
                            Rw.DefaultCellStyle.ForeColor = Color.White
                        Else
                            Rw.DefaultCellStyle.BackColor = Color.LightGreen
                            Rw.DefaultCellStyle.ForeColor = Color.Black
                        End If
                    Next
                End With
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            intCompetenciaAtual = intCompetencia
            strProgramaSaldoAtual = ucPrograma.Text
        End Try

    End Sub
End Class

