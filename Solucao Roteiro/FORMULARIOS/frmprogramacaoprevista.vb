Public Class frmprogramacaoprevista
    Dim sQualidade_Invasao As String
    Dim bQualidade_Invasao As Boolean
    Dim bConsulta As String
    Dim bolMostraDiferenciado As Boolean
    Dim sCod_qualidade As String = Nothing
    Public CodVeiculo As String = Nothing
    Public DataExibicao As String = Nothing
    Public CodPrograma As String = Nothing
    Public NomePrograma As String = Nothing
    Public Indica_Grade As Byte = Nothing
    Public NomeVeiculo As String
    Dim bolOcultaCOluna As Boolean



    Private Sub btnRetornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetornar.Click
        Me.Dispose()
    End Sub

    Private Sub frmprogramacaoprevista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            Me.CenterToScreen()
            Dim bConsulta_Desconto As Boolean
            Dim lTotal_Falhas As Integer = 0
            Dim lTotal_Absorve As Integer = 0
            Dim lTotal_Nao_Absorve As Integer = 0
            Dim lTotal_Aguardando As Integer = 0
            Dim iTotal_Gol As Integer = 0
            Dim bolMostraValor As Boolean
            Dim DTS As DataSet
            Dim clsGrade As MSAClass.AsmxGrade.asmxGrade = NewGrade()
            Dim clsGeneric As MSAClass.asmxGeneric.asmxGeneric = NewGeneric()
            Dim clsUsuario As MSAClass.asmxUsuario.asmxUsuario = NewUsuario()

            sQualidade_Invasao = clsGeneric.fnParametrosGerais("", "", Me.CodVeiculo, 112)

            bolMostraValor = False
            If bUsuario_Net Or InStr(sEmpresadoUsuario, "999") > 0 Then
                bolMostraValor = True
            Else
                For Each DrEmpresa As DataRow In dtsEmpresaUsuario.Tables(0).Rows
                    bolMostraValor = UCase(Vernulo(fParametro(261, DrEmpresa.Item("Cod_Empresa"), , ), "NÃO")) = "SIM"
                    If Not bolMostraValor Then
                        bolMostraValor = UCase(Vernulo(fParametro(261, , DrEmpresa.Item("Cod_Empresa"), ), "NÃO")) = "SIM"
                    End If
                    If bolMostraValor Then
                        Exit For
                    End If
                Next
            End If

            txtPrograma.Text = Me.CodPrograma & "-" & Me.NomePrograma
            txtData.Text = FormataData(Me.DataExibicao)
            txtTipo.Text = Me.Indica_Grade
            txtVeiculo.Text = Me.CodVeiculo & " / " & Me.NomeVeiculo

            bolMostraDiferenciado = UCase(Vernulo(fParametro(260, , , Me.CodVeiculo), "NÃO")) = "SIM"
            DTS = Nothing

            DTS = clsGrade.fnFuncao_Consulta_Programacao_Prevista(Me.CodVeiculo, Me.DataExibicao, Me.CodPrograma, Me.Indica_Grade)
            If DTS.Tables(0).Rows.Count = 0 Then
                'Aviso("Nenhuma veiculacação foi encontrada")
                'Me.Close()
                Exit Try
            End If

            Call EstiloGrid(dgvConsultaPrevista, 2)

            bolOcultaCOluna = True
            For Each drVeiculacao As DataRow In DTS.Tables(0).Rows()
                If drVeiculacao.Item("Indica_Grade_Desc").ToString().ToUpper() = "REDE" Then
                    If Not bolMostraValor Then
                        drVeiculacao.Item("Valor_Tabela") = 0
                        drVeiculacao.Item("Desconto") = 0
                        drVeiculacao.Item("Valor") = 0
                    Else
                        bolOcultaCOluna = False
                    End If
                Else
                    bolOcultaCOluna = False
                End If
            Next

            With dgvConsultaPrevista
                DTS.Tables(0).Columns.Add("Status", GetType(String))
                .DataSource = DTS.Tables(0)
                .SelectionMode = DataGridViewSelectionMode.CellSelect
                .ReadOnly = True
                '=============================================Colunas Visiveis 
                .Columns("Status").Visible = True
                .Columns("Indica_Grade_desc").Visible = True
                .Columns("Cod_Empresa").Visible = True
                .Columns("Cod_Nucleo").Visible = True
                .Columns("Cod_Cliente").Visible = True
                .Columns("Cod_Agencia").Visible = True
                .Columns("Forma_Pagamento").Visible = True
                .Columns("Merchandising").Visible = True
                .Columns("Cod_Programa").Visible = True
                .Columns("Cod_Tipo_Midia").Visible = True
                .Columns("Duracao").Visible = True
                .Columns("Cod_Caracteristica").Visible = True
                .Columns("Cod_Qualidade").Visible = True
                .Columns("Compensacao").Visible = True
                .Columns("Descricao").Visible = True
                .Columns("Numero_MR").Visible = True
                .Columns("Sequencia_MR").Visible = True
                .Columns("Indica_Absorcao").Visible = True
                .Columns("Indica_Estouro").Visible = True
                .Columns("Data_Cadastramento").Visible = True
                .Columns("Chave_Acesso").Visible = True
                .Columns("Valor_Tabela").Visible = Not bolOcultaCOluna
                .Columns("Valor").Visible = Not bolOcultaCOluna
                .Columns("Desconto").Visible = Not bolOcultaCOluna
                '=============================================Colunas ocultas
                .Columns("Indica_Grade").Visible = False
                .Columns("Cod_Veiculo").Visible = False
                .Columns("Documento_DE").Visible = False
                .Columns("Indica_Absorcao_desc").Visible = False
                .Columns("Indica_Falha").Visible = False
                .Columns("Id_Parametro").Visible = False
                .Columns("Descricao_Parametro").Visible = False
                .Columns("Prioridade").Visible = False
                .Columns("Nome_Cliente").Visible = False
                .Columns("Nome_Agencia").Visible = False
                .Columns("Invasao_Local").Visible = False
                '=============================================Cabecalho das colunas 
                .Columns("Status").HeaderText = "Status"
                .Columns("Indica_Grade_desc").HeaderText = "Tipo"
                .Columns("Cod_Empresa").HeaderText = "Emp"
                .Columns("Cod_Nucleo").HeaderText = "Núcleo"
                .Columns("Cod_Cliente").HeaderText = "Cliente"
                .Columns("Cod_Agencia").HeaderText = "Agência"
                .Columns("Forma_Pagamento").HeaderText = "F.Pagto"
                .Columns("Merchandising").HeaderText = "Merch"
                .Columns("Cod_Programa").HeaderText = "Programa Patr."
                .Columns("Cod_Tipo_Midia").HeaderText = "Tipo de Mídia"
                .Columns("Duracao").HeaderText = "Dur"
                .Columns("Cod_Caracteristica").HeaderText = "C.Veic."
                .Columns("Cod_Qualidade").HeaderText = "Qual."
                .Columns("Compensacao").HeaderText = "Comp."
                .Columns("Descricao").HeaderText = "Produto"
                .Columns("Numero_MR").HeaderText = "Contrato"
                .Columns("Sequencia_MR").HeaderText = "Seq."
                .Columns("Indica_Absorcao").HeaderText = "Abs"
                .Columns("Indica_Estouro").HeaderText = "TQP"
                .Columns("Data_Cadastramento").HeaderText = "Data Cadastramento"
                .Columns("Chave_Acesso").HeaderText = "Ch.Acesso"
                .Columns("Valor_Tabela").HeaderText = "Valor Tabela"
                .Columns("Valor").HeaderText = "Valor Negociado"
                .Columns("Desconto").HeaderText = "Desconto"
                '=============================================Ordem das Colunas 
                .Columns("Status").DisplayIndex = 0
                .Columns("Indica_Grade_desc").DisplayIndex = 1
                .Columns("Cod_Empresa").DisplayIndex = 2
                .Columns("Cod_Nucleo").DisplayIndex = 3
                .Columns("Cod_Cliente").DisplayIndex = 4
                .Columns("Cod_Agencia").DisplayIndex = 5
                .Columns("Forma_Pagamento").DisplayIndex = 6
                .Columns("Merchandising").DisplayIndex = 7
                .Columns("Cod_Programa").DisplayIndex = 8
                .Columns("Cod_Tipo_Midia").DisplayIndex = 9
                .Columns("Duracao").DisplayIndex = 10
                .Columns("Cod_Caracteristica").DisplayIndex = 11
                .Columns("Cod_Qualidade").DisplayIndex = 12
                .Columns("Compensacao").DisplayIndex = 13
                .Columns("Descricao").DisplayIndex = 14
                .Columns("Numero_MR").DisplayIndex = 15
                .Columns("Sequencia_MR").DisplayIndex = 16
                .Columns("Indica_Absorcao").DisplayIndex = 17
                .Columns("Indica_Estouro").DisplayIndex = 18
                .Columns("Data_Cadastramento").DisplayIndex = 19
                .Columns("Chave_Acesso").DisplayIndex = 20
                .Columns("Valor_Tabela").DisplayIndex = 21
                .Columns("Valor").DisplayIndex = 22
                .Columns("Desconto").DisplayIndex = 23

                .Columns("valor").DefaultCellStyle.Format = "c"
                .Columns("Valor_Tabela").DefaultCellStyle.Format = "c"
                .Columns("Desconto").DefaultCellStyle.Format = "n6"

                .Columns("Data_Cadastramento").DefaultCellStyle.Format = "dd/MM/yyyy"

                '=============Esconde os Valores caso o usuario nao possa visualizar


                '=============Verifica se o usuario pode ver o desconto
                If Not bConsulta_Desconto Then
                    .Columns("Desconto").Visible = False
                End If

                For Each row As DataGridViewRow In .Rows
                    If isEmptyCell(.Item("Cod_Qualidade", row.Index)) Then
                        sCod_qualidade = ""
                    Else
                        sCod_qualidade = .Item("Cod_Qualidade", row.Index).Value
                    End If
                    If sCod_qualidade = sQualidade_Invasao And bQualidade_Invasao Then
                        lTotal_Aguardando = lTotal_Aguardando + .Item("Duracao", row.Index).Value
                        row.DefaultCellStyle.ForeColor = picAguardando.BackColor
                        row.DefaultCellStyle.SelectionForeColor = picAguardando.BackColor
                    Else
                        Select Case True
                            Case .Item("Indica_Falha", row.Index).Value.ToString.ToUpper = "SIM"
                                row.DefaultCellStyle.ForeColor = picFalha.BackColor
                                row.DefaultCellStyle.SelectionForeColor = picFalha.BackColor
                                lTotal_Falhas = lTotal_Falhas + .Item("Duracao", row.Index).Value
                            Case .Item("Indica_Absorcao", row.Index).Value.ToString.ToUpper = "SIM"
                                lTotal_Absorve = lTotal_Absorve + .Item("Duracao", row.Index).Value
                                If .Item("Indica_Diferenciado", row.Index).Value.ToString = "1" And bolMostraDiferenciado Then
                                    iTotal_Gol = iTotal_Gol + .Item("Duracao", row.Index).Value
                                    row.DefaultCellStyle.ForeColor = picGol.BackColor
                                    row.DefaultCellStyle.SelectionForeColor = picGol.BackColor
                                Else
                                    row.DefaultCellStyle.ForeColor = picAbsorve.BackColor
                                    row.DefaultCellStyle.SelectionForeColor = picAbsorve.BackColor
                                End If
                            Case Else
                                row.DefaultCellStyle.ForeColor = picNaoAbsorve.BackColor
                                row.DefaultCellStyle.SelectionForeColor = picNaoAbsorve.BackColor
                                lTotal_Nao_Absorve = lTotal_Nao_Absorve + .Item("Duracao", row.Index).Value
                        End Select
                    End If
                    If bConsulta_Desconto Then
                        If Not isEmptyCell(.Item("Valor_tabela", row.Index)) And Not isEmptyCell(.Item("Valor", row.Index)) Then
                            If .Item("Valor_tabela", row.Index).Value <> 0 And .Item("Valor", row.Index).Value <> 0 Then
                                .Item("Desconto", row.Index).Value = (1 - (.Item("Valor", row.Index).Value / .Item("Valor_tabela", row.Index).Value)) * 100
                            End If
                        End If
                    End If
                    row.DefaultCellStyle.SelectionBackColor = Color.White
                    .Item("Status", row.Index).Style.BackColor = row.DefaultCellStyle.ForeColor
                    .Item("Status", row.Index).Style.SelectionBackColor = row.DefaultCellStyle.ForeColor
                Next
                .Sort(.Columns("Cod_Programa"), System.ComponentModel.ListSortDirection.Ascending)
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .AutoResizeColumns()
                .AutoResizeRows()

            End With
            txtAbsorveEspaco.Text = lTotal_Absorve
            txtNaoAbsorveEspaco.Text = lTotal_Nao_Absorve
            txtFalhas.Text = lTotal_Falhas
            txtAguardandoAprovacao.Text = lTotal_Aguardando
            txtGol.Text = iTotal_Gol

            picGol.Visible = bolMostraDiferenciado
            lblGol.Visible = bolMostraDiferenciado
            txtGol.Visible = bolMostraDiferenciado







        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub MostraStatus()
        With dgvConsultaPrevista
            For Each row As DataGridViewRow In .Rows
                If isEmptyCell(.Item("Cod_Qualidade", row.Index)) Then
                    sCod_qualidade = ""
                Else
                    sCod_qualidade = .Item("Cod_Qualidade", row.Index).Value
                End If
                If sCod_qualidade = sQualidade_Invasao And bQualidade_Invasao Then
                    row.DefaultCellStyle.ForeColor = picAguardando.BackColor
                    row.DefaultCellStyle.SelectionForeColor = picAguardando.BackColor
                Else
                    Select Case True
                        Case .Item("Indica_Falha", row.Index).Value.ToString.ToUpper = "SIM"
                            row.DefaultCellStyle.ForeColor = picFalha.BackColor
                            row.DefaultCellStyle.SelectionForeColor = picFalha.BackColor
                        Case .Item("Indica_Absorcao", row.Index).Value.ToString.ToUpper = "SIM"
                            If .Item("Indica_Diferenciado", row.Index).Value.ToString = "1" And bolMostraDiferenciado Then
                                row.DefaultCellStyle.ForeColor = picGol.BackColor
                                row.DefaultCellStyle.SelectionForeColor = picGol.BackColor
                            Else
                                row.DefaultCellStyle.ForeColor = picAbsorve.BackColor
                                row.DefaultCellStyle.SelectionForeColor = picAbsorve.BackColor
                            End If
                        Case Else
                            row.DefaultCellStyle.ForeColor = picNaoAbsorve.BackColor
                            row.DefaultCellStyle.SelectionForeColor = picNaoAbsorve.BackColor
                    End Select
                End If
                row.DefaultCellStyle.SelectionBackColor = Color.White
                .Item("Status", row.Index).Style.BackColor = row.DefaultCellStyle.ForeColor
                .Item("Status", row.Index).Style.SelectionBackColor = row.DefaultCellStyle.ForeColor
            Next
        End With
    End Sub
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub dgvConsultaPrevista_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvConsultaPrevista.Sorted
        Call MostraStatus()
    End Sub
End Class

