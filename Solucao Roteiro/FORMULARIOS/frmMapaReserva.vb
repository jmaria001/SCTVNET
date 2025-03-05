Public Class frmMapaReserva
#Region "Declarações"
    Dim clsContrato As MSAClass.AsmxContrato.asmxContrato = NewContrato()
    Dim dtsContrato As DataSet
    Dim dtsVeiculo As DataSet
    Dim dtsGrade As DataSet
    Dim _Operacao As eNumOperacao
    Dim strVeiculos As String = ""
    Dim strVeiculoAtual As String = ""
    Dim strDataInicioAtual As String = ""
    Dim strDataFimAtual As String = ""
    Dim strProgramaAtual As String = ""
    Public Event ParametrosGradeChanged()
    Dim bolValidarObrigatorio As Boolean = False
    Dim dtsStatus As New DataSet()
    Dim strCaracteristicaAnterior As String
    Dim intAnoCampanhaMapa As Integer
    Dim intMesCampanhaMapa As Integer

    Public Enum eNumOperacao
        Incluir
        Editar
        Nova_Sequencia
    End Enum
#End Region
#Region "Propriedades Customizadas"
    Public Property Operacao() As eNumOperacao
        Get
            Operacao = _Operacao
        End Get
        Set(ByVal value As eNumOperacao)
            _Operacao = value
            Select Case _Operacao
                Case eNumOperacao.Editar
                    txtNumeroMr.Enabled = False
                    txtSequenciaMr.Enabled = False
                    tabContrato.Enabled = True
                    optNet.Enabled = False
                    btnSalvar.Enabled = True
                    btnEditar.Enabled = False
                    btnNovaSequencia.Enabled = False
                    bntNovo.Enabled = False
                    txtInicioCampanha.Focus()
                    txtTipoMidia.Enabled = False
                    txtEmpresa.Enabled = False
                    txtEmpresaFaturamento.Enabled = False
                Case eNumOperacao.Incluir
                    Me.PreparaNovoMapa()
                    txtNumeroMr.Text = clsContrato.fnNovoNumero()
                    txtSequenciaMr.Text = 1
                    txtNumeroMr.Enabled = False
                    txtSequenciaMr.Enabled = False
                    tabContrato.Enabled = True
                    optNet.Enabled = False
                    btnSalvar.Enabled = True
                    btnEditar.Enabled = False
                    btnNovaSequencia.Enabled = False
                    bntNovo.Enabled = False
                    txtInicioCampanha.Focus()
                    txtTipoMidia.Text = "NORMAL"
                    txtTipoMidia.Descricao = "Mídia Normal"
                    txtTipoMidia.Enabled = False
                Case eNumOperacao.Nova_Sequencia
                    txtTipoMidia.Enabled = False
                    txtNumeroMr.Enabled = False
                    txtSequenciaMr.Enabled = False
                    tabContrato.Enabled = True
                    optNet.Enabled = False
                    btnSalvar.Enabled = True
                    btnEditar.Enabled = False
                    btnNovaSequencia.Enabled = False
                    bntNovo.Enabled = False
                    txtInicioCampanha.Focus()
            End Select
        End Set
    End Property
#End Region
#Region "Eventos do GridVeiculacao"
    Private Sub gridVeiculacao_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridVeiculacao.CellEndEdit
        Try
            gridveiculacao.Rows(e.RowIndex).ErrorText = ""
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub gridVeiculacao_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridVeiculacao.CellEnter
        Try
            With gridVeiculacao
                If Not gridVeiculacao.Columns("Cod_Programa") Is Nothing Then
                    If e.ColumnIndex = gridVeiculacao.Columns("Cod_Programa").Index Then
                        If Not IsDBNull(.Item("Cod_Programa", .CurrentRow.Index).Value) Then
                            strProgramaAtual = .Item("Cod_Programa", .CurrentRow.Index).EditedFormattedValue
                        Else
                            strProgramaAtual = ""
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Private Sub gridVeiculacao_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridVeiculacao.CellValidated
        Try
            With gridVeiculacao
                .CommitEdit(New DataGridViewDataErrorContexts)
                If .CausesValidation Then
                    Select Case e.ColumnIndex
                        Case .Columns("Cod_Programa").Index
                            'If strProgramaAtual <> .Item("Cod_Programa", e.RowIndex).EditedFormattedValue Then
                            Call HabilitaGrade(.Item("Cod_Programa", e.RowIndex).EditedFormattedValue)
                            'End If
                            If String.IsNullOrEmpty(.CurrentCell.EditedFormattedValue) Then
                                Call DesabilitaGrade()
                            End If
                        Case .Columns("dia_01").Index To .Columns("dia_31").Index
                            Call TotalizaLinha()
                    End Select
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub gridVeiculacao_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles gridVeiculacao.CellValidating
        Try
            With gridVeiculacao
                If Not IsDBNull(.CurrentCell.EditedFormattedValue) And Not String.IsNullOrEmpty(.CurrentCell.EditedFormattedValue) Then
                    Select Case e.ColumnIndex
                        Case .Columns("Cod_Caracteristica").Index
                            If Not String.IsNullOrEmpty(.CurrentCell.EditedFormattedValue.ToString.Trim) Then
                                If Not clsContrato.fnConsisteCaracteristicaVeiculacao(.CurrentCell.EditedFormattedValue) Then
                                    Aviso("Código de Caracteristica Inválido")
                                    gridVeiculacao.EnterToTab = False
                                    .Rows(e.RowIndex).ErrorText = "Código de Caracteristica Inválido"
                                    e.Cancel = True
                                End If
                            End If
                        Case .Columns("Cod_Comercial").Index
                            If Not String.IsNullOrEmpty(.CurrentCell.EditedFormattedValue.ToString.Trim) Then
                                If dtsContrato.Tables("Comercial").Select("Cod_Comercial = '" & .CurrentCell.EditedFormattedValue & "'").Length = 0 Then
                                    Aviso("Código de Comercial Inválido")
                                    .Rows(e.RowIndex).ErrorText = "Código de Comercial Inválido"
                                    e.Cancel = True
                                    .CurrentCell.Value = ""
                                End If
                            End If

                        Case .Columns("Cod_Programa").Index
                            If Not String.IsNullOrEmpty(.CurrentCell.EditedFormattedValue.ToString.Trim) Then
                                If Not dtsGrade Is Nothing Then
                                    If dtsGrade.Tables("Grade_Competencia").Select("Cod_Programa= '" & .CurrentCell.EditedFormattedValue & "'").Length = 0 Then
                                        Aviso("Código de Programa não existe na grade no periodo da Campanha")
                                        .Rows(e.RowIndex).ErrorText = "Código de Programa não existe na grade no periodo da Campanha"
                                        e.Cancel = True
                                    End If
                                Else
                                    .Rows(e.RowIndex).ErrorText = "Grade ainda Foi Selecionada.Preencha o periodo da campanha e escolha pelo menos um veículo"
                                    Aviso(.Rows(e.RowIndex).ErrorText())
                                    e.Cancel = True
                                End If
                            Else
                                Call DesabilitaGrade()
                            End If
                    End Select
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            If e.Cancel Then
                gridVeiculacao.CurrentCell.Value = ""
                gridVeiculacao.EndEdit()
            End If
        End Try
    End Sub
    Private Sub gridVeiculacao_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gridVeiculacao.EditingControlShowing
        Dim txtbox As TextBox = CType(e.Control, TextBox)
        AddHandler txtbox.KeyPress, AddressOf Grid_Veiculacao_CellKeyPress
    End Sub
    Private Sub Grid_Veiculacao_CellKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            e.KeyChar = e.KeyChar.ToString.ToUpper
            With gridVeiculacao
                Select Case gridVeiculacao.CurrentCell.ColumnIndex
                    Case .Columns("Cod_programa").Index
                    Case .Columns("Cod_Comercial").Index
                    Case .Columns("Cod_Caracteristica").Index
                    Case .Columns("dia_01").Index To .Columns("dia_31").Index
                        If Not IsNumeric(e.KeyChar) Then
                            e.KeyChar = Nothing
                        End If
                End Select
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub Grid_Veiculacao_CellKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        '    Try
        '        MsgBox(e.KeyCode)
        '    Catch ex As Exception
        '        ShowErro(ex)
        '    End Try
    End Sub
    Private Sub gridVeiculacao_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles gridVeiculacao.RowsAdded
        Call DesabilitaGrade()
    End Sub
    Private Sub gridVeiculacao_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridVeiculacao.CellDoubleClick
        Try
            '==========================================================================Double click no cod programa
            Select Case e.ColumnIndex
                Case gridVeiculacao.Columns("Cod_Programa").Index
                    If Not dtsGrade Is Nothing Then
                        gridVeiculacao.EndEdit()
                        frmSelecaoPrograma.Source = dtsGrade
                        frmSelecaoPrograma.ShowDialog()
                        If frmSelecaoPrograma.OkClick Then
                            gridVeiculacao.Item("Cod_Programa", gridveiculacao.CurrentRow.Index).Value = frmSelecaoPrograma.CodigoPrograma
                        End If
                        frmSelecaoPrograma.Dispose()
                    End If
                Case gridveiculacao.Columns("Cod_Comercial").Index
                    If dtsContrato.Tables("Comercial").Rows.Count > 0 Then
                        Dim dtb As New DataTable
                        Dim NewRow As DataRow = Nothing
                        dtb.Columns.Add("Código", GetType(String))
                        dtb.Columns.Add("Título", GetType(String))
                        dtb.Columns.Add("Duração", GetType(String))

                        For Each Rw As DataRow In dtsContrato.Tables("Comercial").Rows
                            NewRow = dtb.NewRow
                            NewRow.Item("Código") = Rw.Item("Cod_Comercial")
                            NewRow.Item("Título") = Rw.Item("Titulo_Comercial")
                            NewRow.Item("Duração") = Rw.Item("Duracao")
                            dtb.Rows.Add(NewRow)
                        Next
                        gridveiculacao.EndEdit()
                        frmConsulta.Source = dtb
                        frmConsulta.sqlQuery = Nothing
                        frmConsulta.ShowDialog()
                        If frmConsulta.OkClick Then
                            gridveiculacao.Item("Cod_Comercial", gridveiculacao.CurrentRow.Index).Value = frmConsulta.Codigo
                        End If
                        frmConsulta.Dispose()
                    End If
                Case gridveiculacao.Columns("Cod_Caracteristica").Index
                    frmConsulta.Source = Nothing
                    gridveiculacao.EndEdit()
                    frmConsulta.sqlQuery = "Execute Prnet_Carac_Veiculacao_L"
                    frmConsulta.ShowDialog()
                    If frmConsulta.OkClick Then
                        gridveiculacao.Item("Cod_Caracteristica", gridveiculacao.CurrentRow.Index).Value = frmConsulta.Codigo
                    End If
                    frmConsulta.Dispose()
            End Select
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Function AtualizaContrato() As Boolean
        AtualizaContrato = True
        Dim strquery As String = ""
        Dim drw() As DataRow = Nothing
        Dim NewRow As DataRow
        Dim bolAdicionaRow As Boolean = False

        strquery = "Numero_Mr = " & txtNumeroMr.DataNumberValue
        strquery += " And Sequencia_Mr = " & txtSequenciaMr.DataNumberValue
        Try

            drw = dtsContrato.Tables("Contrato").Select(strquery)
            If drw.Length = 0 Then
                NewRow = dtsContrato.Tables("contrato").NewRow
                bolAdicionaRow = True

            Else
                NewRow = drw(0)
            End If
            NewRow("Cod_Empresa") = txtEmpresa.Text
            NewRow("Numero_Mr") = txtNumeroMr.DataNumberValue
            NewRow("Numero_Negociacao") = txtNegociacao.Text
            NewRow("Sequencia_Mr") = txtSequenciaMr.DataNumberValue
            NewRow("Cod_Programa") = DBNull.Value
            NewRow("Cod_Empresa_Faturamento") = txtEmpresaFaturamento.Text
            NewRow("Cod_Cancelamento") = DBNull.Value
            NewRow("Caracteristica_Contrato") = txtCaracteristica.Text
            NewRow("Cod_Contato") = txtContato.Text
            NewRow("Cod_Historico") = 1
            NewRow("Cod_Nucleo") = txtNucleo.Text
            NewRow("Cod_Reserva") = DBNull.Value
            NewRow("Indica_Midia_Especificada") = 1
            NewRow("Cod_Tipo_Midia") = txtTipoMidia.Text
            NewRow("Cod_Usuario") = gsUsuario
            NewRow("Data_Cadastramento") = Now
            NewRow("Data_Cancelamento") = DBNull.Value
            NewRow("Data_Recepcao_Reserva") = DateTime.Parse(txtDataRecepcao.Text)
            NewRow("Numero_PI") = txtNumeroPi.Text
            NewRow("Motivo_Cancelamento") = DBNull.Value
            NewRow("Obs_Roteiro") = txtObservacao.Text
            NewRow("Periodo_Campanha_Inicio") = DateTime.Parse(txtInicioCampanha.Text)
            NewRow("Periodo_Campanha_Termino") = DateTime.Parse(txtFimCampanha.Text)
            Select Case True
                Case optNet.Checked
                    NewRow("Indica_Grade") = 0
                Case optRede.Checked
                    NewRow("Indica_Grade") = 1
                Case optLocal.Checked
                    NewRow("Indica_Grade") = 2
            End Select
            NewRow("Vlr_Faturado") = 0
            NewRow("Indica_Realizado") = 0
            NewRow("Vlr_Ded_Emitido") = 0
            NewRow("Vlr_Comp_Emitido") = 0
            NewRow("Vlr_Autorizado") = 0
            NewRow("Vlr_Deducao") = 0
            NewRow("Vlr_Compensacao") = 0
            NewRow("Vlr_Diferenca") = 0
            NewRow("Cod_Cliente") = txtCliente.Text
            NewRow("Cod_Agencia") = txtAgencia.Text
            NewRow("Indica_Tipo_Evento") = DBNull.Value
            NewRow("Indica_Por_Credito") = 0
            NewRow("Vlr_Informado") = 0
            NewRow("Data_Info_Vlr") = DBNull.Value
            NewRow("Cod_Usuario_Vlr") = DBNull.Value
            NewRow("Vlr_Ded_Diferenca") = 0
            NewRow("Vlr_Cred_Diferenca") = 0
            NewRow("Vlr_Tabela") = 0
            NewRow("Indica_Apoio") = 0
            NewRow("indica_autorizacao") = DBNull.Value
            NewRow("Vlr_Negociado") = 0
            NewRow("Indica_Bloqueio") = DBNull.Value
            NewRow("vlr_Gerencial_bav") = 0
            NewRow("Vlr_Correcao") = 0
            NewRow("Indica_Valor_NET") = DBNull.Value
            NewRow("Vlr_Repasse") = 0
            NewRow("Desconsidera_Patrocinio_Evento") = DBNull.Value
            NewRow("Vlr_Abatimento_Varejo") = 0
            NewRow("Cod_Mercado") = DBNull.Value
            NewRow("Data_Ajuste_BAV") = DBNull.Value
            NewRow("Cod_Usuario_Ajuste_BAV") = DBNull.Value
            NewRow("Cod_Evento") = DBNull.Value
            NewRow("Vlr_Tabela_Exibido_Contrato") = 0
            NewRow("OBS_Contrato") = DBNull.Value
            NewRow("Data_Inclusao") = DBNull.Value
            If bolAdicionaRow Then
                dtsContrato.Tables("contrato").Rows.Add(NewRow)
            End If
        Catch ex As Exception
            AtualizaContrato = False
            ShowErro(ex)
        End Try
    End Function
#End Region
#Region "Privates Subs e Functions"
    Private Sub Cancelar()
        Dim frmMrNew As Form = New frmMapaReserva
        Me.Dispose()
        frmMrNew.Show()
    End Sub
    Private Sub ConsisteObrigatorio(ByVal pControl As Control)
        Dim ctrTxt As New WUC.UcText
        Try
            For Each Ctr As Control In pControl.Controls
                If TypeOf (Ctr) Is WUC.UcText Then
                    ctrTxt = Ctr
                    If ctrTxt.Obrigatorio And ctrTxt.Text.Trim = "" Then
                        ctrTxt.MensagemErro = "Campo de Preenchimento Obrigatório"
                        bolValidarObrigatorio = False
                    End If
                End If
                If Ctr.HasChildren Then
                    Call ConsisteObrigatorio(Ctr)
                End If
            Next
        Catch ex As Exception
            ShowErro(ex)
            bolValidarObrigatorio = False
        End Try
    End Sub
    Private Sub PreparaNovoMapa()
        Try
            Call LimpaCampos(Me)
            lblVeiculo.Text = ""
            dtsContrato.Clear()
            intAnoCampanhaMapa = 0
            intAnoCampanhaMapa = 0
            strVeiculos = ""
            strVeiculoAtual = ""
            strDataInicioAtual = ""
            strDataFimAtual = ""
            strProgramaAtual = ""


            If dtsEmpresaUsuario.Tables(0).Rows.Count = 1 Then
                txtEmpresa.Text = dtsEmpresaUsuario.Tables(0).Rows(0).Item("Cod_Empresa")
                txtEmpresa.Descricao = dtsEmpresaUsuario.Tables(0).Rows(0).Item("Razao_Social")
                txtEmpresaFaturamento.Text = dtsEmpresaUsuario.Tables(0).Rows(0).Item("Cod_Empresa")
                txtEmpresaFaturamento.Descricao = dtsEmpresaUsuario.Tables(0).Rows(0).Item("Razao_Social")
                txtEmpresa.Enabled = False
                txtEmpresaFaturamento.Enabled = False
                Call txtEmpresaFaturamento_Validated(New Object, New System.EventArgs)

            Else
                txtEmpresa.Enabled = True
                txtEmpresaFaturamento.Enabled = True
            End If


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub AtualizaComercial(ByVal pCodigo As String, _
                              ByVal pCodProduto As Int32, _
                              ByVal pTipoComercial As String, _
                              ByVal pDescricaoTipoComercial As String, _
                              ByVal pDuracao As Int32, _
                              ByVal pDeterminar As Boolean, _
                              ByVal pNomeProduto As String, _
                              ByVal pTituloComercial As String, _
                                ByVal pIndica_Merchandising As Boolean)


        Dim RwComercial() As DataRow = Nothing
        Dim rwNewRow As DataRow = Nothing
        Dim bolAdicionaRow As Boolean = False
        Try
            RwComercial = dtsContrato.Tables("Comercial").Select("Cod_Comercial = '" & pCodigo & "'")
            If RwComercial.Length > 0 Then
                rwNewRow = RwComercial(0)
            Else
                rwNewRow = dtsContrato.Tables("Comercial").NewRow
                bolAdicionaRow = True
            End If


            rwNewRow("Cod_Comercial") = pCodigo
            rwNewRow("Cod_Empresa") = txtEmpresa.Text
            rwNewRow("Cod_Material") = DBNull.Value
            rwNewRow("Cod_Red_Produto") = pCodProduto
            rwNewRow("Cod_Tipo_Comercial") = pTipoComercial
            rwNewRow("Descricao_Tipo_Comercial") = pDescricaoTipoComercial
            rwNewRow("complemento") = DBNull.Value
            rwNewRow("Data_Desativacao") = DBNull.Value
            rwNewRow("data_gravacao") = DBNull.Value
            rwNewRow("Duracao") = pDuracao
            rwNewRow("Fim_Programacao") = DBNull.Value
            rwNewRow("Indica_Titulo_Determinar") = IIf(pDeterminar, 1, 0)
            rwNewRow("Determinar") = pDeterminar
            rwNewRow("Inicio_Programacao") = DBNull.Value
            rwNewRow("Matriz") = DBNull.Value
            rwNewRow("Nome_Produto") = pNomeProduto.Trim
            rwNewRow("Numero_Fita") = DBNull.Value
            rwNewRow("Numero_Mr") = txtNumeroMr.DataNumberValue
            rwNewRow("Posicao") = DBNull.Value
            rwNewRow("Sequencia_Mr") = txtSequenciaMr.DataNumberValue
            rwNewRow("Titulo_Comercial") = pTituloComercial
            rwNewRow("Indica_Merchandising") = pIndica_Merchandising
            If bolAdicionaRow Then
                dtsContrato.Tables("Comercial").Rows.Add(rwNewRow)
            End If


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaGrade()
        Dim Dtb As New DataTable
        Dim dtDataInicio As Date = Nothing
        Dim dtDataFim As Date = Nothing
        Try
            If Not String.IsNullOrEmpty(strDataInicioAtual) And Not String.IsNullOrEmpty(strDataFimAtual) And Not String.IsNullOrEmpty(strVeiculoAtual) Then
                dtDataInicio = FormatDateTime(strDataInicioAtual, DateFormat.GeneralDate)
                dtDataFim = FormatDateTime(strDataFimAtual, DateFormat.GeneralDate)
                dtsGrade = Nothing
                dtsGrade = clsContrato.fnCarregaGrade(dtDataInicio, dtDataFim, strVeiculoAtual)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub HabilitaGrade(ByVal pCod_Programa As String)
        Dim strColunaGrade As String = ""
        Dim strColunaVeiculacao As String = ""
        Dim Rw() As DataRow
        Dim btPrimeiroDia As Byte = 1
        Dim btUltimo As Byte = 31

        Try
            If txtInicioCampanha.Text.Trim <> "" Then
                btPrimeiroDia = Byte.Parse(txtInicioCampanha.Text.Substring(0, 2))
            End If
            If txtFimCampanha.Text.Trim <> "" Then
                btUltimo = Byte.Parse(txtFimCampanha.Text.Substring(0, 2))
            End If
            If Not dtsGrade Is Nothing Then
                With gridVeiculacao
                    Rw = dtsGrade.Tables("Grade_Competencia").Select("Cod_Programa = '" & pCod_Programa & "'")
                    If Rw.Length > 0 Then
                        For x As Integer = 1 To 31
                            strColunaVeiculacao = "Dia_" & x.ToString.PadLeft(2, "0")
                            strColunaGrade = x.ToString.PadLeft(2, "0")
                            If Rw(0).Item(strColunaGrade) = True And x >= btPrimeiroDia And x <= btUltimo Then
                                .Item(strColunaVeiculacao, .CurrentRow.Index).ReadOnly = False
                                .Item(strColunaVeiculacao, .CurrentRow.Index).Style.BackColor = Color.White
                            Else
                                .Item(strColunaVeiculacao, .CurrentRow.Index).ReadOnly = True
                                .Item(strColunaVeiculacao, .CurrentRow.Index).Style.BackColor = Color.Beige
                                .Item(strColunaVeiculacao, .CurrentRow.Index).Value = DBNull.Value
                            End If
                        Next
                    End If
                End With
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Private Sub DesabilitaGrade()
        Dim strColunaVeiculacao As String = ""
        Try
            With gridVeiculacao
                If Not .CurrentRow Is Nothing Then
                    For x As Integer = 1 To 31
                        strColunaVeiculacao = "Dia_" & x.ToString.PadLeft(2, "0")
                        .Item(strColunaVeiculacao, .CurrentRow.Index).ReadOnly = True
                        .Item(strColunaVeiculacao, .CurrentRow.Index).Style.BackColor = Color.Beige
                        .Item(strColunaVeiculacao, .CurrentRow.Index).Value = DBNull.Value
                    Next
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Function fnConsistePeriodo_Campanha() As String
        Dim dtInicio As DateTime
        Dim dtFim As DateTime



        fnConsistePeriodo_Campanha = ""
        Try

            If txtInicioCampanha.Text.Trim <> "" And txtFimCampanha.Text.Trim <> "" Then
                dtInicio = DateTime.Parse(FormataData(txtInicioCampanha.Text))
                dtFim = DateTime.Parse(FormataData(txtFimCampanha.Text))

                If dtInicio > dtFim Then
                    fnConsistePeriodo_Campanha = "Início da Campanha deve ser menor ou igual ao Fim da Campanha"
                End If
                If dtFim.Year <> dtInicio.Year Or dtFim.Month <> dtInicio.Month Then
                    fnConsistePeriodo_Campanha = "Início e Fim da Campanha devem ser do mesmo Mes/Ano"
                End If


            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Private Sub MoveDataSetToForm(ByVal dts As DataSet)
        Dim btIndicaGrade As Byte
        Try
            With dts.Tables("Contrato").Rows(0)
                txtEmpresa.Text = .Item("Cod_Empresa")
                txtNumeroMr.Text = .Item("Numero_Mr")
                txtSequenciaMr.Text = .Item("Sequencia_Mr")
                txtNegociacao.Text = .Item("Numero_Negociacao")
                txtEmpresaFaturamento.Text = .Item("Cod_Empresa_Faturamento")
                txtCaracteristica.Text = .Item("Caracteristica_Contrato")
                txtContato.Text = .Item("Cod_Contato")
                txtNucleo.Text = .Item("Cod_Nucleo")
                txtTipoMidia.Text = .Item("Cod_Tipo_Midia")
                txtDataRecepcao.Text = Format(.Item("Data_Recepcao_Reserva"), "dd/MM/yyyy")
                txtNumeroPi.Text = Vernulo(.Item("Numero_PI"), "")
                txtObservacao.Text = Vernulo(.Item("Obs_Roteiro"), "")
                txtInicioCampanha.Text = Format(.Item("Periodo_Campanha_Inicio"), "dd/MM/yyyy")
                txtFimCampanha.Text = Format(.Item("Periodo_Campanha_Termino"), "dd/MM/yyyy")
                btIndicaGrade = .Item("Indica_Grade")
                Select Case btIndicaGrade
                    Case 0
                        optNet.Checked = True
                    Case 1
                        optRede.Checked = True
                    Case 2
                        optLocal.Checked = True
                End Select
                txtCliente.Text = .Item("Cod_Cliente")
                txtAgencia.Text = .Item("Cod_Agencia")
                intAnoCampanhaMapa = DateTime.Parse(.Item("Periodo_Campanha_Inicio")).Year
                intMesCampanhaMapa = DateTime.Parse(.Item("Periodo_Campanha_Inicio")).Month


            End With
            txtNucleo.Validar()
            txtAgencia.Validar()
            txtTipoMidia.Validar()
            txtCaracteristica.Validar()
            txtCliente.Validar()
            txtContato.Validar()
            txtEmpresa.Validar()
            txtEmpresaFaturamento.Validar()
            strDataInicioAtual = txtInicioCampanha.Text
            strDataFimAtual = txtFimCampanha.Text

            Call ConfiguraGridVeiculacao()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaDataSetComercial(ByVal pDataset As DataSet)
        Dim rowContrato As DataRow = Nothing
        Try
            '==========================Adicionando Comercial
            Dim RowComercial As DataRow = Nothing
            For Each rw As DataRow In pDataset.Tables("Comercial").Rows
                RowComercial = dtsContrato.Tables("Comercial").NewRow
                For x As Integer = 0 To pDataset.Tables("Comercial").Columns.Count - 1

                    RowComercial.Item(x) = rw.Item(x)
                Next
                dtsContrato.Tables("Comercial").Rows.Add(RowComercial)
            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
#End Region
#Region "Eventos Gerais"
    Public Sub New()
        Me.MdiParent = mdiPrincipal
        InitializeComponent()

    End Sub


    Private Sub frmMapaReserva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            SetaUserControl(Me)
            Me.Top = 0
            Me.Left = 0
            dtsContrato = clsContrato.fnDefineDataset
            gridComercial.DataSource = dtsContrato.Tables("Comercial")
            gridVeiculacao.DataSource = dtsContrato.Tables("Veiculacao_Digitacao")
            lblErro.Text = ""
            txtEmpresa.Usuario = gsUsuario
            txtEmpresaFaturamento.Usuario = gsUsuario
            txtCliente.Usuario = gsUsuario
            txtAgencia.Usuario = gsUsuario
            txtContato.Usuario = gsUsuario


            btnSalvar.Enabled = False
            Me.ConfiguraGridComercial()
            Me.ConfiguraGridVeiculacao()
            tabContrato.Enabled = False


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub ConfiguraGridVeiculacao()
        Dim strDia As String
        Dim strColuna As String
        Dim strCompetencia As String = ""
        Dim intCompetencia As Integer = 0
        Dim intDiaSemana As Integer = 0
        Dim strDiaSemana As String = ""
        Dim strDataLinha As String = ""
        Dim btUltimoDiadoMes As Byte
        Dim btDiaInicioCampanha As Byte = 0
        Dim btDiaTerminoCampanha As Byte = 0
        Dim dc As New DataGridViewTextBoxColumn

        Try
            If txtInicioCampanha.Text.Trim <> "" And txtFimCampanha.Text.Trim <> "" Then
                strCompetencia = DataToMesAno(FormatDateTime(txtInicioCampanha.Text))
                intCompetencia = Int32.Parse(strCompetencia.Substring(3, 4) & strCompetencia.Substring(0, 2))
                btDiaInicioCampanha = Byte.Parse(txtInicioCampanha.Text.Substring(0, 2))
                btDiaTerminoCampanha = Byte.Parse(txtFimCampanha.Text.Substring(0, 2))
            Else
                strCompetencia = DataToMesAno(Now)
                intCompetencia = Int32.Parse(strCompetencia.Substring(3, 4) & strCompetencia.Substring(0, 2))
                btDiaInicioCampanha = 1
                btDiaTerminoCampanha = LastDay(intCompetencia)
            End If
            btUltimoDiadoMes = LastDay(intCompetencia)
            '=============================Remove colunas para criar novamente customizadas

            With gridVeiculacao
                .CausesValidation = False
                .Columns.Remove("Cod_Programa")
                .Columns.Remove("Cod_Comercial")
                .Columns.Remove("Cod_Caracteristica")
                For i As Integer = 1 To 31
                    strDia = i.ToString.PadLeft(2, "0")
                    strColuna = "Dia_" & strDia
                    .Columns.Remove(strColuna)
                Next
            End With
            '=============================Recria as colunas 
            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Cod_Programa"
                .MaxInputLength = 4
                .DataPropertyName = "Cod_Programa"
                .HeaderText = "Programa"
                gridVeiculacao.Columns.Add(dc)
            End With

            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Cod_Caracteristica"
                .MaxInputLength = 2
                .DataPropertyName = "Cod_Caracteristica"
                .HeaderText = "C.V"
                gridVeiculacao.Columns.Add(dc)
            End With


            dc = New DataGridViewTextBoxColumn
            With dc
                .Name = "Cod_Comercial"
                .MaxInputLength = 2
                .DataPropertyName = "Cod_Comercial"
                .HeaderText = "Comercial"
                gridVeiculacao.Columns.Add(dc)
            End With


            For i As Integer = 1 To 31
                dc = New DataGridViewTextBoxColumn
                With dc
                    strDia = i.ToString.PadLeft(2, "0")
                    strColuna = "Dia_" & strDia
                    .Name = strColuna
                    .MaxInputLength = 2
                    .DataPropertyName = strColuna
                    gridVeiculacao.Columns.Add(dc)
                End With
            Next


            With gridVeiculacao
                .EnableHeadersVisualStyles = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .AllowUserToOrderColumns = False
                .RowHeadersVisible = True
                .DefaultCellStyle.SelectionBackColor = Color.Yellow
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AllowUserToAddRows = True
                .AllowUserToResizeColumns = False
                .AllowUserToOrderColumns = False

                .AllowUserToResizeRows = False
                .Columns("Cod_Veiculo").Visible = False
                .Columns("Cod_Empresa").Visible = False
                .Columns("Numero_Mr").Visible = False
                .Columns("Sequencia_Mr").Visible = False
                .SelectionMode = DataGridViewSelectionMode.CellSelect


                .Columns("Cod_Programa").HeaderText = "Progr."
                .Columns("Cod_Comercial").HeaderText = "Com."
                .Columns("Cod_Caracteristica").HeaderText = "C.V."
                .Columns("Total").HeaderText = "Total"

                .Columns("Cod_Programa").Width = 50
                .Columns("Cod_Comercial").Width = 30
                .Columns("Cod_Caracteristica").Width = 30
                .Columns("Total").Width = 35

                .Columns("Cod_Programa").DisplayIndex = 0
                .Columns("Cod_Caracteristica").DisplayIndex = 1
                .Columns("Cod_Comercial").DisplayIndex = 2
                .Columns("Total").DisplayIndex = 34
                .Columns("Total").ReadOnly = True



                .RowHeadersWidth = 40

                For I As Integer = 1 To 31
                    strDia = I.ToString.PadLeft(2, "0")
                    strColuna = "Dia_" & strDia
                    .Columns(strColuna).DisplayIndex = 2 + I
                    strDataLinha = strDia & "/" & strCompetencia
                    If I <= btUltimoDiadoMes Then
                        intDiaSemana = Weekday(FormatDateTime(I.ToString.PadLeft(2, "0") & "/" & strCompetencia, DateFormat.GeneralDate))
                        strDiaSemana = WeekdayName(intDiaSemana).ToUpper
                        .Columns(strColuna).HeaderText = " " & strDiaSemana.Substring(0, 1) & vbCrLf & strDia
                    Else
                        strDiaSemana = ""
                        .Columns(strColuna).HeaderText = ""
                    End If
                    .Columns(strColuna).Visible = True
                    .Columns(strColuna).Width = 25
                    If intDiaSemana = 1 Then
                        .Columns(strColuna).HeaderCell.Style.ForeColor = Color.Red
                    End If
                    .Columns(I).SortMode = DataGridViewColumnSortMode.NotSortable

                Next
                .CausesValidation = True
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub ConfiguraGridComercial()
        EstiloGrid(gridComercial, 2)
        Try
            With gridComercial
                .ReadOnly = True
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .RowHeadersVisible = False
                .Columns("Cod_Comercial").HeaderText = "Legenda"
                .Columns("Cod_Tipo_Comercial").HeaderText = "Tipo"
                .Columns("Descricao_Tipo_Comercial").HeaderText = "Tipo de Comercial"
                .Columns("Duracao").HeaderText = "Duração"
                .Columns("Determinar").HeaderText = "A Determinar"
                .Columns("Nome_Produto").HeaderText = "Produto"
                .Columns("Titulo_Comercial").HeaderText = "Título"
                .Columns("Indica_Merchandising").HeaderText = "Merchandising"

                .Columns("Cod_Comercial").Visible = True
                .Columns("Cod_Empresa").Visible = False
                .Columns("Cod_Material").Visible = False
                .Columns("Cod_Red_Produto").Visible = False
                .Columns("Cod_Tipo_Comercial").Visible = False
                .Columns("Descricao_Tipo_Comercial").Visible = True
                .Columns("complemento").Visible = False
                .Columns("Data_Desativacao").Visible = False
                .Columns("data_gravacao").Visible = False
                .Columns("Duracao").Visible = True
                .Columns("Fim_Programacao").Visible = False
                .Columns("Inicio_Programacao").Visible = False
                .Columns("Matriz").Visible = False
                .Columns("Nome_Produto").Visible = True
                .Columns("Numero_Fita").Visible = False
                .Columns("Numero_Mr").Visible = False
                .Columns("Posicao").Visible = False
                .Columns("Sequencia_Mr").Visible = False
                .Columns("Titulo_Comercial").Visible = True
                .Columns("Indica_Merchandising").Visible = False
                .Columns("Indica_Titulo_Determinar").Visible = False
                .Columns("Determinar").Visible = True


                .Columns("Cod_Comercial").DisplayIndex = 0
                .Columns("Titulo_Comercial").DisplayIndex = 1
                .Columns("Duracao").DisplayIndex = 2
                .Columns("Descricao_Tipo_Comercial").DisplayIndex = 3
                .Columns("Nome_Produto").DisplayIndex = 4
                '.Columns("Determinar").DisplayIndex = 10

                .Columns("Cod_Comercial").Width = 60
                .Columns("Titulo_Comercial").Width = 290
                .Columns("Duracao").Width = 60
                .Columns("Descricao_Tipo_Comercial").Width = 180
                .Columns("Nome_Produto").Width = 230
                .AutoResizeRows()

            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try



    End Sub
    Private Sub bntNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntNovo.Click
        Try
            Me.Operacao = eNumOperacao.Incluir
            Call AdicionaLinhaVeiculacao()


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Dispose()
    End Sub
    Private Sub btnVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeiculo.Click
        Dim bolSelecionou As Boolean = False
        Try


            dtsVeiculo = clsContrato.fnVeiculoUsuarioCarregar(gsUsuario)
            dtsVeiculo.Tables(0).Columns.Add("Check", GetType(Boolean))
            If dtsVeiculo.Tables(0).Rows.Count = 1 Then
                dtsVeiculo.Tables(0).Rows(0).Item("Check") = True
                bolSelecionou = True
                btnVeiculo.Enabled = False
            Else
                btnVeiculo.Enabled = True
                frmSelecaoVeiculo.VeiculosMarcados = strVeiculos
                frmSelecaoVeiculo.ShowDialog()
                If frmSelecaoVeiculo.OkCLick Then
                    dtsVeiculo = frmSelecaoVeiculo.DtsVeiculo
                    bolSelecionou = True
                End If
                frmSelecaoVeiculo.Dispose()
            End If

            If bolSelecionou Then

                strVeiculos = ""
                lblVeiculo.Text = ""
                For Each row As DataRow In dtsVeiculo.Tables(0).Rows
                    If Not IsDBNull(row.Item("CHECK")) Then
                        If row.Item("CHECK") Then
                            strVeiculos += row.Item("Cod_Veiculo")
                            lblVeiculo.Text += row.Item("Cod_Veiculo") & ","
                        Else
                            row.Delete()
                        End If
                    Else
                        row.Delete()
                    End If
                Next
                dtsVeiculo.Tables(0).AcceptChanges()
                If strVeiculos <> strVeiculoAtual Then
                    strVeiculoAtual = strVeiculos
                    RaiseEvent ParametrosGradeChanged()
                End If
            End If

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnComercialAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComercialAdicionar.Click
        Try
            '========================Carrega Lista de Comerciais ja existentes
            If txtCaracteristica.Text.Trim = "" Then
                Aviso("A Característica do Contrato deve ser Informada antes de digitar comerciais")
                Exit Sub
            End If
            Do '---Para continuar na inclusao ate usuario sair 
                Dim Restrito As New ArrayList
                With gridComercial
                    For Each row As DataGridViewRow In gridComercial.Rows '
                        Restrito.Add((.Item("Cod_Comercial", row.Index).Value))
                    Next
                End With
                frmComercial.Caracteristica_Contrato = Me.txtCaracteristica.Text
                frmComercial.CodigoRestrito = Restrito
                frmComercial.CodigoCliente = txtCliente.Text
                frmComercial.ShowDialog()
                If frmComercial.OkClick Then
                    With frmComercial
                        Me.AtualizaComercial(.txtCodigo.Text, _
                                             .txtProduto.Text, _
                                             .txtTipoComercial.Text, _
                                             .txtTipoComercial.Descricao, _
                                             .txtDuracao.DataNumberValue, _
                                             .chkDeterminar.Checked, _
                                             .txtProduto.Descricao, _
                                            .txtTitulo.Text, _
                                             .txtTipoComercial.IndicaMerchandising)
                    End With
                    gridComercial.AutoResizeRows()
                    frmComercial.Dispose()
                Else
                    frmComercial.Dispose()
                    Exit Do
                End If
            Loop
            frmComercial.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnComercialEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComercialEditar.Click
        Try
            If Not gridComercial.CurrentRow Is Nothing Then
                With gridComercial
                    frmComercial.Caracteristica_Contrato = Me.txtCaracteristica.Text
                    frmComercial.txtCodigo.Text = .Item("Cod_Comercial", .CurrentRow.Index).Value
                    frmComercial.txtTitulo.Text = .Item("Titulo_Comercial", .CurrentRow.Index).Value
                    frmComercial.txtDuracao.Text = .Item("Duracao", .CurrentRow.Index).Value
                    frmComercial.txtTipoComercial.Text = .Item("Cod_Tipo_Comercial", .CurrentRow.Index).Value
                    frmComercial.txtTipoComercial.Descricao = .Item("Descricao_Tipo_Comercial", .CurrentRow.Index).Value
                    frmComercial.txtProduto.Text = .Item("Cod_Red_Produto", .CurrentRow.Index).Value
                    frmComercial.txtProduto.Descricao = .Item("Nome_Produto", .CurrentRow.Index).Value
                    frmComercial.chkDeterminar.Checked = .Item("Indica_Titulo_Determinar", .CurrentRow.Index).Value

                End With
                Dim Restrito As New ArrayList
                With gridComercial
                    For Each row As DataGridViewRow In gridComercial.Rows '
                        Restrito.Add((.Item("Cod_Comercial", row.Index).Value))
                    Next
                End With

                frmComercial.txtCodigo.Enabled = False
                frmComercial.Caracteristica_Contrato = Me.txtCaracteristica.Text
                frmComercial.CodigoCliente = txtCliente.Text

                frmComercial.ShowDialog()
                If frmComercial.OkClick Then
                    With frmComercial
                        Me.AtualizaComercial(.txtCodigo.Text, _
                                             .txtProduto.Text, _
                                             .txtTipoComercial.Text, _
                                             .txtTipoComercial.Descricao, _
                                             .txtDuracao.DataNumberValue, _
                                             .chkDeterminar.Checked, _
                                             .txtProduto.Descricao, _
                                             .txtTitulo.Text, _
                                             .txtTipoComercial.IndicaMerchandising)

                    End With
                End If
                frmComercial.Dispose()
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Private Sub btnComercialExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComercialExcluir.Click

        Try
            With gridComercial
                If .CurrentRow Is Nothing Then
                    Aviso("Nenhum comercial está selecionado para exclusão")
                    Exit Try
                End If

                If Not Aviso("Confirma a Exclusão do Comercial Legenda (" & .Item("Cod_Comercial", .CurrentRow.Index).Value & ") ?", vbYesNo, vbQuestion) Then
                    Exit Try
                End If

                If clsContrato.fnExisteComercial(txtEmpresa.Text, txtNumeroMr.DataNumberValue, txtSequenciaMr.DataNumberValue, .Item("Cod_Comercial", .CurrentRow.Index).Value) Then
                    Aviso("Comercial está sendo utilizado em veiculações e exclusão não é permitida")
                    Exit Try
                End If

                If Not clsContrato.fnExcluirComercial(txtEmpresa.Text, txtNumeroMr.DataNumberValue, txtSequenciaMr.DataNumberValue, .Item("Cod_Comercial", .CurrentRow.Index).Value) Then
                    Exit Try
                End If

                .Rows.Remove(.CurrentRow)
                dtsContrato.Tables("Comercial").AcceptChanges()


            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub frmMapaReserva_ParametrosGradeChanged() Handles Me.ParametrosGradeChanged
        Call CarregaGrade()
    End Sub
    Private Sub txtInicioCampanha_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInicioCampanha.Validated
        Try
            If txtInicioCampanha.Text <> strDataInicioAtual Then
                strDataInicioAtual = txtInicioCampanha.Text

                Call ConfiguraGridVeiculacao()
                RaiseEvent ParametrosGradeChanged()
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub txtFimCampanha_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFimCampanha.Validated
        Try
            If txtFimCampanha.Text <> strDataFimAtual Then
                strDataFimAtual = txtFimCampanha.Text
                RaiseEvent ParametrosGradeChanged()
                Call ConfiguraGridVeiculacao()
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub txtEmpresaFaturamento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmpresaFaturamento.Validated
        Try
            If txtEmpresaFaturamento.Text <> gsEmpresa_Net Then
                optNet.Enabled = False
                optRede.Enabled = False
                optLocal.Enabled = True
                optNet.Checked = False
                optRede.Checked = False
                optLocal.Checked = True
            Else
                optNet.Enabled = True
                optRede.Enabled = True
                optLocal.Enabled = True
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub txtFimCampanha_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFimCampanha.Validating
        Try
            If txtFimCampanha.MensagemErro = "" Then
                txtFimCampanha.MensagemErro = fnConsistePeriodo_Campanha()
                If txtFimCampanha.MensagemErro <> "" Then
                    e.Cancel = True
                    txtFimCampanha.ShowErro()
                    txtFimCampanha.Text = ""
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub txtInicioCampanha_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtInicioCampanha.Validating
        Try
            If Me.Operacao = eNumOperacao.Editar And txtInicioCampanha.Text.Trim <> "" Then
                If strDataInicioAtual <> txtInicioCampanha.Text Then
                    If DateTime.Parse(txtInicioCampanha.Text).Year <> intAnoCampanhaMapa Or _
                        DateTime.Parse(txtInicioCampanha.Text).Month <> intMesCampanhaMapa Then
                        If dtsContrato.Tables("Contrato").Rows(0).Item("QtdVeiculacao") > 0 Then
                            Aviso("Contrato possui Veiculações e não é permitido alterar o Mes/Ano da Campanha")
                            e.Cancel = True
                            Exit Try
                        End If
                    End If
                End If
            End If
            If txtInicioCampanha.MensagemErro = "" Then
                txtInicioCampanha.MensagemErro = fnConsistePeriodo_Campanha()
                If txtInicioCampanha.MensagemErro <> "" Then
                    e.Cancel = True
                    txtFimCampanha.Text = ""
                    txtInicioCampanha.ShowErro()
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim bolVeiculacao As Boolean = False
        Dim bolDigitouComercial As Boolean = True
        Dim strPergunta As String = ""
        Dim bolDigitouVeiculacao As Boolean = True
        Dim strMensagem As String = ""
        Dim bolConsistencia As Boolean = False
        Dim strErro As String = ""



        Try

            gridVeiculacao.CommitEdit(DataGridViewDataErrorContexts.ClipboardContent)
            errMr.SetError(lblErro, Nothing)
            lblErro.Visible = False
            bolConsistencia = True

            '================================Consiste Campos Obrigatorios 
            bolValidarObrigatorio = True
            Call ConsisteObrigatorio(Me)
            If Not bolValidarObrigatorio Then
                bolConsistencia = False
                strErro += "Campos obrigatórios não foram preenchidos em dados do contrato." + vbCrLf
            End If
            '================================Consiste tipo de Comercial
            For Each drw As DataRow In dtsContrato.Tables("Comercial").Rows
                If (drw("Indica_Merchandising") And txtCaracteristica.Text.ToUpper <> "MER") Or _
                   (Not drw("Indica_Merchandising") And txtCaracteristica.Text.ToUpper = "MER") Then
                    bolConsistencia = False
                    'Aviso("Existe um ou mais tipo de Comercial imcompativel com a caracteristica do Contrato! Verifique")
                    strErro += "Existe um ou mais tipo de Comercial imcompativel com a caracteristica do Contrato." + vbCrLf
                    Exit Try
                End If
            Next
            '================================Consiste Abrangencia
            If Not optLocal.Checked And Not optRede.Checked And Not optNet.Checked Then
                errMr.SetError(fraAbrangencia, "Preencher uma das Opções de Abrangência")
                strErro += "Nenhuma abrangência foi informada." + vbCrLf
                bolConsistencia = False

            End If


            '================================Consiste se digitou comercial e veiculacoes 
            If Me.Operacao <> eNumOperacao.Editar Then
                If dtsContrato.Tables("Comercial").Rows.Count = 0 Then
                    bolDigitouComercial = False
                End If
                'If dtsContrato.Tables("Veiculacao_Digitacao").Rows.Count = 0 Then
                'If Integer.Parse(lblTotalGeral.Text) = 0 Then
                If lblTotalGeral.Text.Trim = "" Or lblTotalGeral.Text.Trim = "0" Then
                    bolDigitouVeiculacao = False
                End If
                Select Case True
                    Case Not bolDigitouComercial And Not bolDigitouVeiculacao
                        strPergunta = "Nenhum comercial e veiculação foi digitado.Confirma a gravação somente dos dados do Contrato ?"
                    Case Not bolDigitouVeiculacao
                        strPergunta = "Nenhum Veiculação foi digitada.Confirma a gravação somente dos Dados do Contrato e Comercial ?"
                End Select
                If strPergunta <> "" Then
                    If Not Aviso(strPergunta, vbYesNo, vbQuestion) Then
                        Exit Try
                    End If
                End If
            End If
            '============================Consiste Linhas de Digitacao
            With gridVeiculacao
                For Each rw As DataGridViewRow In gridVeiculacao.Rows
                    For x As Integer = .Columns.IndexOf(.Columns("Dia_01")) To .Columns.IndexOf(.Columns("Dia_31"))
                        bolVeiculacao = False
                        If Not isEmptyCell(.Item(x, rw.Index)) Then
                            bolVeiculacao = True
                            Exit For
                        End If
                    Next
                    If bolVeiculacao And (isEmptyCell(.Item("Cod_Programa", rw.Index)) Or _
                                        isEmptyCell(.Item("Cod_Comercial", rw.Index)) Or _
                                        isEmptyCell(.Item("Cod_Caracteristica", rw.Index))) Then
                        bolConsistencia = False
                        errMr.SetError(tabDados, "Erro em dados do Comercial")
                        'Aviso("Digitação Linha " & (rw.Index + 1).ToString & ":Programa,Comercial ou Caracteristica da Veiculação não foi digitado")
                        strErro += "Digitação Linha " & (rw.Index + 1).ToString & ":Programa,Comercial ou Caracteristica da Veiculação não foi digitado." + vbCrLf
                        'Exit Try
                    End If
                Next
            End With

            If Not bolConsistencia Then

                Exit Try
            End If
            Me.Cursor = Cursors.WaitCursor

            '================================Cria uma Negociacao para o contrato
            If txtNegociacao.Text.Trim = "" Then
                txtNegociacao.Text = clsContrato.fnCriaNegociacao(DataToCompentencia(txtInicioCampanha.Text), _
                                                                    txtEmpresa.Text, _
                                                                    txtEmpresaFaturamento.Text, _
                                                                    txtAgencia.Text, _
                                                                    txtCliente.Text, _
                                                                    txtNucleo.Text, _
                                                                    txtContato.Text, _
                                                                    txtTipoMidia.Text, _
                                                                    gsUsuario)
            End If
            If Not AtualizaContrato() Then
                Exit Try
            End If

            If txtNegociacao.Text.Trim = "" Then
                Me.Cursor = Cursors.Default
                Aviso("Erro na Criação da Negociação. Verifique e Informe o Suporte")
                Exit Try
            End If

            '===================================Executa Salvar
            dtsStatus = Nothing

            dtsStatus = clsContrato.FnSalvar(dtsContrato, dtsVeiculo, gsUsuario)
            If dtsStatus Is Nothing Then
                Me.Cursor = Cursors.Default
                Aviso("Houve erro durante a operação.Verifique se os dados foram gravados corretamente")
                Exit Try
            End If

            'strMensagem = "Operação concluida com sucesso" & vbCrLf
            'strMensagem += "Contrato : " & txtEmpresa.Text & "/"
            'strMensagem += txtNumeroMr.DataNumberValue.ToString() & "/"
            'strMensagem += txtSequenciaMr.DataNumberValue.ToString & vbCrLf
            'strMensagem += "Negociação : " & txtNegociacao.Text

            Me.Cursor = Cursors.Default
            Me.MostraStatus()
            'Aviso(strMensagem)
            'Select Case Me.Operacao
            '   Case eNumOperacao.Incluir
            'Me.Cancelar()
            '     Case eNumOperacao.Editar
            'Me.Cancelar()
            '   Case eNumOperacao.Nova_Sequencia
            'Me.Cancelar()
            'End Select
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
            If Not bolConsistencia Then
                'lblErro.Visible = True
                'lblErro.Text = "Crítica   "
                'errMr.SetError(lblErro, strErro)
                'Aviso("Existem Campos Inconsistentes!" & vbCr & "Passe o Mouse sobre a marca  de erro para verificar")
                Aviso(strErro)
            End If
        End Try
    End Sub
    Private Sub btnOpcoes_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles btnOpcoes.ItemClicked

    End Sub
    Private Sub optLocal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optLocal.Click
        errMr.SetError(fraAbrangencia, Nothing)
    End Sub
    Private Sub optNet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optNet.Click
        errMr.SetError(fraAbrangencia, Nothing)
    End Sub
    Private Sub optRede_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optRede.Click
        errMr.SetError(fraAbrangencia, Nothing)
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Cancelar()
    End Sub
    Private Sub btnNovaSequencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovaSequencia.Click
        Dim dtsTemp As DataSet = dtsContrato
        Try
            frmSelecaoMapa.Operacao = frmSelecaoMapa.enuOperacao.Nova_Sequencia
            frmSelecaoMapa.ShowDialog()
            If frmSelecaoMapa.OkCLik Then
                Me.Operacao = eNumOperacao.Nova_Sequencia

                dtsTemp = clsContrato.fnCarregaContrato(frmSelecaoMapa.CodEmpresa, frmSelecaoMapa.Numero_Mr, frmSelecaoMapa.Sequencia_Mr)
                dtsTemp.Tables("Contrato").Rows(0).Item("Sequencia_Mr") = dtsTemp.Tables("Contrato").Rows(0).Item("Sequencia_Mr") + 1

                For Each rw As DataRow In dtsTemp.Tables("Comercial").Rows
                    rw.Item("Sequencia_Mr") = rw.Item("Sequencia_Mr") + 1
                Next

                Call MoveDataSetToForm(dtsTemp)
                Call CarregaDataSetComercial(dtsTemp)
                Call AdicionaLinhaVeiculacao()
                txtCliente.Enabled = False
                txtAgencia.Enabled = False
                txtEmpresa.Enabled = False
                txtEmpresaFaturamento.Enabled = False

            End If
            frmSelecaoMapa.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnRepetir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepetir.Click
        Dim intColInicio As Byte
        Dim intQtd As Byte
        Try
            With gridVeiculacao
                If .CurrentRow IsNot Nothing Then
                    For x As Integer = .Columns.IndexOf(.Columns("Dia_31")) To .Columns.IndexOf(.Columns("Dia_01")) Step -1
                        If Not isEmptyCell(.Item(x, .CurrentRow.Index)) Then
                            intColInicio = x + 1
                            intQtd = .Item(x, .CurrentRow.Index).Value
                            Exit For
                        End If
                    Next
                    If intColInicio = 0 Then intColInicio = .Columns.IndexOf(.Columns("Dia_01"))
                    If intQtd = 0 Then intQtd = 1
                    For x As Integer = intColInicio To .Columns.IndexOf(.Columns("Dia_31"))
                        If Not .Item(x, .CurrentRow.Index).ReadOnly Then
                            .Item(x, .CurrentRow.Index).Value = intQtd
                        End If
                    Next
                    .CommitEdit(New DataGridViewDataErrorContexts)
                    .CurrentCell = .Item("Cod_Programa", .CurrentCell.RowIndex + 1)
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnEditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Try
            frmSelecaoMapa.Operacao = frmSelecaoMapa.enuOperacao.Editar
            frmSelecaoMapa.ShowDialog()
            If frmSelecaoMapa.OkCLik Then
                Me.Operacao = eNumOperacao.Editar
                dtsContrato = clsContrato.fnCarregaContrato(frmSelecaoMapa.CodEmpresa, frmSelecaoMapa.Numero_Mr, frmSelecaoMapa.Sequencia_Mr)
                If Not String.IsNullOrEmpty(dtsContrato.Tables("Contrato").Rows(0).Item("Data_Cancelamento").ToString) Then
                    Aviso("Esse Contrato está cancelado e não pode ser editado")
                    Me.Cancelar()
                    Exit Try
                End If
                Call MoveDataSetToForm(dtsContrato)


                gridComercial.DataSource = dtsContrato.Tables("Comercial")
                Call AdicionaLinhaVeiculacao()
                gridVeiculacao.DataSource = dtsContrato.Tables("Veiculacao_Digitacao")
            End If
            frmSelecaoMapa.Dispose()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub AdicionaLinhaVeiculacao()
        Dim NewRow As DataRow
        Try

            With dtsContrato.Tables("Veiculacao_Digitacao")
                For x As Integer = 0 To 100
                    NewRow = .NewRow()
                    NewRow.Item("Cod_Empresa") = DBNull.Value
                    NewRow.Item("Numero_Mr") = DBNull.Value
                    NewRow.Item("Sequencia_Mr") = DBNull.Value
                    NewRow.Item("Cod_Veiculo") = DBNull.Value
                    NewRow.Item("Cod_Programa") = DBNull.Value
                    NewRow.Item("Cod_Comercial") = DBNull.Value
                    NewRow.Item("Cod_Caracteristica") = DBNull.Value
                    NewRow.Item("dia_01") = DBNull.Value
                    NewRow.Item("dia_02") = DBNull.Value
                    NewRow.Item("dia_03") = DBNull.Value
                    NewRow.Item("dia_04") = DBNull.Value
                    NewRow.Item("dia_05") = DBNull.Value
                    NewRow.Item("dia_06") = DBNull.Value
                    NewRow.Item("dia_07") = DBNull.Value
                    NewRow.Item("dia_08") = DBNull.Value
                    NewRow.Item("dia_09") = DBNull.Value
                    NewRow.Item("dia_10") = DBNull.Value
                    NewRow.Item("dia_11") = DBNull.Value
                    NewRow.Item("dia_12") = DBNull.Value
                    NewRow.Item("dia_13") = DBNull.Value
                    NewRow.Item("dia_14") = DBNull.Value
                    NewRow.Item("dia_15") = DBNull.Value
                    NewRow.Item("dia_16") = DBNull.Value
                    NewRow.Item("dia_17") = DBNull.Value
                    NewRow.Item("dia_18") = DBNull.Value
                    NewRow.Item("dia_19") = DBNull.Value
                    NewRow.Item("dia_20") = DBNull.Value
                    NewRow.Item("dia_21") = DBNull.Value
                    NewRow.Item("dia_22") = DBNull.Value
                    NewRow.Item("dia_23") = DBNull.Value
                    NewRow.Item("dia_24") = DBNull.Value
                    NewRow.Item("dia_25") = DBNull.Value
                    NewRow.Item("dia_26") = DBNull.Value
                    NewRow.Item("dia_27") = DBNull.Value
                    NewRow.Item("dia_28") = DBNull.Value
                    NewRow.Item("dia_29") = DBNull.Value
                    NewRow.Item("dia_30") = DBNull.Value
                    NewRow.Item("dia_31") = DBNull.Value
                    .Rows.Add(NewRow)
                Next x
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub txtDataRecepcao_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDataRecepcao.Validating
        Try
            If txtDataRecepcao.Text.Trim <> "" Then
                If Format(DateTime.Parse(txtDataRecepcao.Text), "yyyy-MM-dd") > Format(Date.Parse(Now), "yyyy-MM-dd") Then
                    Aviso("Data não pode ser maior que hoje")
                    e.Cancel = True
                    txtDataRecepcao.Text = ""
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub tabContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabContrato.Click
        Try
            If tabContrato.SelectedTab Is tabVeiculacao Then
                If lblVeiculo.Text.Trim = "" Then
                    btnVeiculo.PerformClick()
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Try
            With gridVeiculacao
                If Not .CurrentCell Is Nothing Then
                    For x As Integer = 0 To .Columns.Count - 1
                        .Item(x, .CurrentRow.Index).Value = DBNull.Value
                    Next
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub TotalizaLinha()
        Dim intTotalLinha As Integer = 0
        Dim intTotalGeral As Integer = 0
        Try
            With gridVeiculacao
                For Each row As DataGridViewRow In .Rows
                    intTotalLinha = 0
                    For col As Integer = .Columns("dia_01").Index To .Columns("dia_31").Index
                        If Not isEmptyCell(.Item(col, row.Index)) Then
                            intTotalLinha += Integer.Parse(.Item(col, row.Index).Value)
                        End If
                    Next

                    intTotalGeral += intTotalLinha
                    If intTotalLinha > 0 Then
                        .Item("Total", row.Index).Value = intTotalLinha
                    Else
                        .Item("Total", row.Index).Value = DBNull.Value
                    End If

                Next
            End With
            lblTotalGeral.Text = intTotalGeral
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub MostraStatus()
        Dim qtdAntes As Integer, qtdDepois As Integer
        Dim AmAntes As Integer, AmDepois As Integer
        Try
            frmMrStatus.lblEmpresa.Text = txtEmpresa.Text
            frmMrStatus.lblContrato.Text = txtNumeroMr.Text
            frmMrStatus.lblNegociacao.Text = txtNegociacao.Text
            frmMrStatus.lblSequencia.Text = txtSequenciaMr.Text

            If dtsStatus.Tables("DtbAntes").Rows.Count > 0 Then
                qtdAntes = dtsStatus.Tables("DtbAntes").Rows(0)("Normal")
                AmAntes = dtsStatus.Tables("DtbAntes").Rows(0)("Am")
            Else
                qtdAntes = 0
                AmAntes = 0
            End If

            If dtsStatus.Tables("dtbDepois").Rows.Count > 0 Then
                qtdDepois = dtsStatus.Tables("DtbDepois").Rows(0)("Normal")
                AmDepois = dtsStatus.Tables("DtbDepois").Rows(0)("Am")
            Else
                qtdDepois = 0
                AmDepois = 0
            End If

            frmMrStatus.lblQtdGravadas.Text = qtdDepois - qtdAntes
            frmMrStatus.lblQtdAms.Text = AmDepois - AmAntes
            frmMrStatus.ShowDialog()
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub txtCaracteristica_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCaracteristica.Enter
        strCaracteristicaAnterior = txtCaracteristica.Text
    End Sub

    Private Sub txtCaracteristica_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCaracteristica.Validating
        Try
            Select Case True
                Case txtCaracteristica.Text = "MER"
                    If strCaracteristicaAnterior <> "MER" Then
                        If Me.Operacao = eNumOperacao.Editar Then
                            Aviso("Não é permitido trocar a Caracteristica de [" & strCaracteristicaAnterior & "] Para [MER]")
                            txtCaracteristica.Text = strCaracteristicaAnterior
                            Exit Try
                        Else
                            If Aviso("Trocar a Caracteristica de [" & strCaracteristicaAnterior & "] Para [MER] excluirá os comerciais já digitados, Confirma ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question, "Atenção") Then
                                dtsContrato.Tables("Comercial").Clear()
                            Else
                                txtCaracteristica.Text = strCaracteristicaAnterior
                            End If
                        End If
                    End If
                Case txtCaracteristica.Text <> "MER"
                    If Me.Operacao = eNumOperacao.Editar Then
                        Aviso("Não é permitido trocar a Caracteristica de [MER] Para [" & txtCaracteristica.Text & "]")
                        txtCaracteristica.Text = strCaracteristicaAnterior
                        Exit Try

                    Else
                        If strCaracteristicaAnterior = "MER" Then
                            If Aviso("Trocar a Caracteristica de [MER] Para [" & txtCaracteristica.Text & "] excluirá os comerciais já digitados, Confirma ?", MsgBoxStyle.YesNo, MsgBoxStyle.Question, "Atenção") Then
                                dtsContrato.Tables("Comercial").Clear()

                            Else
                                txtCaracteristica.Text = strCaracteristicaAnterior
                            End If
                        End If
                    End If

            End Select
        Catch ex As Exception

        End Try
    End Sub

    
End Class