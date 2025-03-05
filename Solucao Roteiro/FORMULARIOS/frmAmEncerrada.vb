Public Class frmAmEncerrada
    Dim clsAM As MSAClass.AsmxAM.asmxAM
    Dim dtbAmEncerrada As New DataTable

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

            frmAmFiltro.ShowDialog()
            If frmAmFiltro.OkClick Then
                clsAM = NewAM()
                gridAm.DataSource = Nothing
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
                dtbAmEncerrada = clsAM.AmEncerrada(sEmpresadoUsuario, _
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

                If dtbAmEncerrada.Rows.Count = 0 Then
                    Aviso("Nenhuma AM foi encontrada com esse filtro")
                    Exit Try
                End If
                Me.Cursor = Cursors.Default

                Call EstiloGrid(gridAm, 1)
                With gridAm
                    .DataSource = dtbAmEncerrada
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    .AutoResizeColumns()
                    .RowHeadersVisible = True

                    .Columns("Descricao").Visible = True
                    .Columns("Cod_Veiculo").Visible = True
                    .Columns("Cod_Agencia").Visible = True
                    .Columns("Cod_Cliente").Visible = True
                    .Columns("Cod_Empresa").Visible = True
                    .Columns("Numero_MR").Visible = True
                    .Columns("Sequencia_MR").Visible = True
                    .Columns("Numero_Docto").Visible = True
                    .Columns("Solucao").Visible = True
                    .Columns("Numero_Negociacao").Visible = True
                    .Columns("Cod_Nucleo").Visible = True
                    .Columns("Cod_Contato").Visible = True

                    .Columns("Descricao").HeaderText = "Produto"
                    .Columns("Cod_Veiculo").HeaderText = "Veículo"
                    .Columns("Cod_Agencia").HeaderText = "Agência"
                    .Columns("Cod_Cliente").HeaderText = "Cliente"
                    .Columns("Cod_Empresa").HeaderText = "Empresa"
                    .Columns("Numero_MR").HeaderText = "Contrato"
                    .Columns("Sequencia_MR").HeaderText = "Seq."
                    .Columns("Numero_Docto").HeaderText = "Documento"
                    .Columns("Numero_Docto").HeaderText = "Solução"
                    .Columns("Numero_Negociacao").HeaderText = "Negociação"
                    .Columns("Cod_Nucleo").HeaderText = "Núcleo"
                    .Columns("Cod_Contato").HeaderText = "Contato"

                    .Columns("Descricao").DisplayIndex = 0
                    .Columns("Cod_Veiculo").DisplayIndex = 1
                    .Columns("Cod_Agencia").DisplayIndex = 2
                    .Columns("Cod_Cliente").DisplayIndex = 3
                    .Columns("Cod_Empresa").DisplayIndex = 4
                    .Columns("Numero_MR").DisplayIndex = 5
                    .Columns("Sequencia_MR").DisplayIndex = 6
                    .Columns("Numero_Docto").DisplayIndex = 7
                    .Columns("Solucao").DisplayIndex = 8
                    .Columns("Numero_Negociacao").DisplayIndex = 9
                    .Columns("Cod_Nucleo").DisplayIndex = 10
                    .Columns("Cod_Contato").DisplayIndex = 11

                    .Columns("Cod_Red_Produto").Visible = False
                    .Columns("Cod_Caracteristica").Visible = False
                    .Columns("Data_Encerramento").Visible = False
                    .Columns("Cod_Usuario").Visible = False
                    .Columns("Indica_Grade").Visible = False
                    .Columns("Periodo_Campanha_Inicio").Visible = False
                    .Columns("Periodo_Campanha_Termino").Visible = False
                    .Columns("Numero_PI").Visible = False

                    lblTotalRegistros.Text = "Total de Am's Selecionadas: " & .Rows.Count

                End With
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub



    Private Sub frmAmEncerrada_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmAmFiltro.Dispose()
        Me.Dispose()
    End Sub

    Private Sub frmAmEncerrada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0
        Me.Show()
        btnFiltrar.PerformClick()
    End Sub

    Public Sub New()

        Me.MdiParent = mdiPrincipal
        InitializeComponent()

    End Sub

    Private Sub btnVerAM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerAM.Click
        Try
            With gridAm
                If Not .CurrentRow Is Nothing Then
                    If Vernulo(.Item("Numero_Docto", .CurrentRow.Index).Value, "") <> "" Then
                        Me.Cursor = Cursors.WaitCursor
                        frmDadosAm.txtEmpresa.Text = .Item("Cod_Empresa", .CurrentRow.Index).Value
                        frmDadosAm.txtContrato.Text = .Item("Numero_Mr", .CurrentRow.Index).Value
                        frmDadosAm.txtSequencia.Text = .Item("Sequencia_Mr", .CurrentRow.Index).Value
                        frmDadosAm.txtNumeroAM.Text = .Item("Numero_Docto", .CurrentRow.Index).Value
                        frmDadosAm.ShowDialog()
                        Me.Cursor = Cursors.Default
                    End If
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    
    Private Sub gridAm_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAm.DoubleClick
        btnVerAM.PerformClick()
    End Sub

    Private Sub btnReabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReabrir.Click
        Try
            With gridAm
                If Not .CurrentRow Is Nothing Then
                    If Aviso("Confirma a Reabertuda da " & .Item("Numero_Docto", .CurrentRow.Index).Value & " ?", vbQuestion + vbYesNo) Then
                        If clsAM.AmReabrir(.Item("Cod_Empresa", .CurrentRow.Index).Value, _
                                            .Item("Numero_Mr", .CurrentRow.Index).Value, _
                                            .Item("Sequencia_Mr", .CurrentRow.Index).Value, _
                                            .Item("Numero_Docto", .CurrentRow.Index).Value, _
                                            gsUsuario) Then
                            .Rows.Remove(.CurrentRow)
                            lblTotalRegistros.Text = "Total de Am's Selecionadas: " & .Rows.Count

                        End If

                    End If
                End If
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class