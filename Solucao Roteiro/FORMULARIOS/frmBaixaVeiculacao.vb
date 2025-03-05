Public Class frmBaixaVeiculacao
    Dim DTS As DataSet = Nothing
    Public ClickOk As Boolean
    Public pubProssegueBaixa As Boolean
    Public FormOrigem As String



    Public Sub btnExibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExibir.Click

        Dim CLS As MSAClass.AsmxChecking.asmxChecking = NewChecking()
        Dim clsUsuario As MSAClass.AsmxUsuario.asmxUsuario = NewUsuario()
        Dim nposition As Integer = 0
        Dim sContrato As String = ""
        Dim nFim1 As Integer = 0
        Dim NFim2 As Integer = 0
        lblCritica.Text = ""
        Try
            If Trim(txtVeiculo.Text) = "" Then
                MsgBox("Preencha o Veiculo !!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If Trim(TxtData.Text) = "" Then
                MsgBox("Preencha a Data !!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            'If Trim(txtPrograma.Text) = "" Then
            'MsgBox("Preencha o Programa !!", MsgBoxStyle.Critical)
            'Exit Sub
            'End If

            nposition = txtContrato.Text.IndexOf(".")
            If nposition > 1 Then
                nFim1 = nposition
                NFim2 = (txtContrato.Text.Length) - (nposition + 1)
                sContrato = txtContrato.Text.Substring(0, nFim1) + txtContrato.Text.Substring(nposition + 1, NFim2)
            Else
                sContrato = txtContrato.DataNumberValue
            End If

            dgvConsultaBaixa.DataSource = Nothing
            dgvConsultaBaixa.ReadOnly = True
            DTS = Nothing



            DTS = CLS.fnFuncao_Consulta_Veiculacao_Baixa(txtVeiculo.Text, FormatDateTime(TxtData.Text, DateFormat.ShortDate), txtPrograma.Text, Val(txtChaveAcesso.Text), txtEmpresa.Text, Val(sContrato), Val(txtSeq.Text), txtCodComercial.Text, Val(txtDuracao.Text), Not chkNaoQualidade.Checked)
            If DTS.Tables(0).Rows.Count = 0 Then
                If FormOrigem.ToUpper = "frmMRConsulta".ToUpper Then
                    MsgBox("Essa Veiculação não pode ser baixada!", MsgBoxStyle.Critical)
                    pubProssegueBaixa = False
                Else
                    MsgBox("Nenhuma Veiculação foi encontrada !", MsgBoxStyle.Critical)
                End If
                Exit Sub
            End If

            Call EstiloGrid(dgvConsultaBaixa, 1)
            btnBaixar.Enabled = True
            btnLimpar.Enabled = True

            With dgvConsultaBaixa
                .ReadOnly = False
                .EnableHeadersVisualStyles = False
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .AllowUserToOrderColumns = False
                .RowHeadersVisible = True

                .DefaultCellStyle.SelectionBackColor = Color.GreenYellow
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .AllowUserToResizeColumns = False
                .AllowUserToResizeRows = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataSource = DTS.Tables(0)
                '.RowHeadersVisible = False

                .Columns("Cod_Empresa_Faturamento").Visible = False

                .Columns("Cod_empresa").HeaderText = "Emp"
                .Columns("Cod_empresa").ReadOnly = True
                .Columns("Cod_empresa").Visible = False

                .Columns("Numero_Mr").HeaderText = "Contrato"
                .Columns("Numero_Mr").ReadOnly = True
                .Columns("Numero_Mr").Visible = False

                .Columns("Sequencia_Mr").HeaderText = "Seq"
                .Columns("Sequencia_Mr").ReadOnly = True
                .Columns("Sequencia_Mr").Visible = False

                .Columns("EmpContSeq").HeaderText = "Contrato"
                .Columns("EmpContSeq").ReadOnly = True
                '.Columns("EmpContSeq").Width = 80

                .Columns("Cod_Tipo_Midia").HeaderText = "T.Mídia"
                .Columns("Cod_Tipo_Midia").ReadOnly = True
                '.Columns("Cod_Tipo_Midia").Width = 60

                .Columns("Cod_Programa").HeaderText = "Programa"
                .Columns("Cod_Programa").ReadOnly = True
                '.Columns("Cod_Programa").Width = 55

                .Columns("Titulo").HeaderText = "Título"
                .Columns("Titulo").ReadOnly = True
                '.Columns("Titulo").Width = 300

                .Columns("Cod_Tipo_Comercial").HeaderText = "Tipo"
                .Columns("Cod_Tipo_Comercial").ReadOnly = True
                '.Columns("Cod_Tipo_Comercial").Width = 30


                .Columns("Duracao").HeaderText = "Dur."

                .Columns("Chave_Acesso").HeaderText = "Chave"
                .Columns("Chave_Acesso").ReadOnly = True
                '.Columns("Chave_Acesso").Width = 45

                .Columns("Duracao").ReadOnly = True
                .Columns("Duracao").Visible = True

                .Columns("Documento_De").HeaderText = "Docto.De"
                .Columns("Documento_De").ReadOnly = True
                '.Columns("Documento_De").Width = 70

                .Columns("Documento_Para").HeaderText = "Docto.Para"
                .Columns("Documento_Para").ReadOnly = True
                '.Columns("Documento_Para").Width = 70

                .Columns("Cod_Qualidade").HeaderText = "Qual."
                .Columns("Cod_Qualidade").ReadOnly = False
                '.Columns("Cod_Qualidade").Width = 40

                .Columns("Cod_Qualidade_Ant").Visible = False

                .Columns("Horario_Exibicao").Visible = False

                .Columns("Horario").HeaderText = "Horario"
                '.Columns("Horario").Width = 70

                .Columns("Horario_Exibicao_Ant").Visible = False

                .Columns("Critica").Visible = False

                .Columns("Indica_Net").HeaderText = "Net"
                .Columns("Indica_Net").ReadOnly = True
                '.Columns("Indica_Net").Width = 45

                .Columns("Indica_Net").HeaderText = "Net"
                .Columns("Indica_Net").ReadOnly = True

                '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None


                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                .AutoResizeColumns()

                .Columns("EmpContSeq").Width = 90
                .Columns("Cod_Tipo_Midia").Width = 80
                .Columns("Cod_Programa").Width = 55
                .Columns("Titulo").Width = 300
                .Columns("Cod_Tipo_Comercial").Width = 30
                .Columns("Duracao").Width = 40
                .Columns("Chave_Acesso").Width = 45
                .Columns("Documento_De").Width = 70
                .Columns("Documento_Para").Width = 70
                .Columns("Cod_Qualidade").Width = 40
                .Columns("Horario").Width = 70
                .Columns("Indica_Net").Width = 45



                .AutoResizeRows()

                .RowHeadersVisible = False
                .ColumnHeadersVisible = True
                .ScrollBars = ScrollBars.Both

                For Each row As DataGridViewRow In .Rows

                    If isEmptyCell(.Item("Cod_Qualidade", row.Index)) Then
                        .Item("Cod_Qualidade", row.Index).Value = ""
                        .Item("Cod_Qualidade_Ant", row.Index).Value = ""
                    End If
                    If isEmptyCell(.Item("Horario", row.Index)) Then
                        .Item("Horario", row.Index).Value = ""
                        .Item("Horario_Exibicao_Ant", row.Index).Value = ""
                    End If
                    If isEmptyCell(.Item("Critica", row.Index)) Then
                        .Item("Critica", row.Index).Value = 0
                    End If
                    If isEmptyCell(.Item("Indica_Net", row.Index)) Then
                        .Item("Indica_Net", row.Index).Value = ""
                    End If
                    If isEmptyCell(.Item("Documento_Para", row.Index)) Then
                        .Item("Documento_Para", row.Index).Value = ""
                    End If
                Next

                .Item("Cod_Qualidade", 0).Selected = True
                .Rows(0).Selected = True

            End With

        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            '==========================================================Tranforma em Maiscula
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = e.KeyChar.ToString.ToUpper
            End If
            '==========================================================tratamento da Hora
            If dgvConsultaBaixa.CurrentCell.ColumnIndex = 11 Then
                If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
                    e.KeyChar = ""
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dgvConsultaBaixa_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvConsultaBaixa.CellClick
    End Sub

    Private Sub dgvConsultaBaixa_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvConsultaBaixa.CellValidated
        Try
            With dgvConsultaBaixa
                If e.ColumnIndex = .Columns("Horario").Index Then
                    If .Item(e.ColumnIndex, e.RowIndex).FormattedValue.ToString.Trim <> "" Then
                        .Item(e.ColumnIndex, e.RowIndex).Value = formataHora(.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Trim)
                        .CommitEdit(New DataGridViewDataErrorContexts)
                    End If
                End If
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub dgvConsultaBaixa_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvConsultaBaixa.CellValidating
        Dim CLS As MSAClass.asmxChecking.asmxChecking = NewChecking()
        Try

            With dgvConsultaBaixa
                .CommitEdit(DataGridViewDataErrorContexts.Commit)

                Select Case e.ColumnIndex
                    Case .Columns("Cod_Qualidade").Index

                        If Vernulo(.CurrentCell.Value, "") <> "VEI" Then
                            .Item(.Columns("Horario").Index, .CurrentCell.RowIndex).Value = ""
                        End If

                        If Vernulo(.CurrentCell.Value, "") = "" Then
                            Exit Try
                        End If

                        If .Item(.Columns("Cod_Qualidade_Ant").Index, e.RowIndex).Value <> .CurrentCell.Value Then
                            If Not CLS.fnConsisteQualidadeBaixa(dgvConsultaBaixa.CurrentCell.EditedFormattedValue) Then
                                Aviso("Qualidade Invalida !!")
                                .Item(e.ColumnIndex, e.RowIndex).Value = ""
                                e.Cancel = True
                                Exit Try
                            End If
                        End If

                    Case .Columns("Horario").Index
                        If Vernulo(.CurrentCell.Value, "") <> "" Then
                            If Not isTime(dgvConsultaBaixa.CurrentCell.EditedFormattedValue) Then
                                Aviso("Horário Inválido")
                                .Item(e.ColumnIndex, e.RowIndex).Value = ""
                                e.Cancel = True
                                Exit Try
                            End If

                            If Vernulo(.Item("Cod_Qualidade", .CurrentRow.Index).Value, "") = "" Then
                                Aviso("Qualidade vazia não pode ter horário")
                                .Item(e.ColumnIndex, e.RowIndex).Value = ""
                                e.Cancel = True
                                Exit Try
                            End If
                        End If


                End Select

            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub


    Private Sub dgvConsultaBaixa_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvConsultaBaixa.EditingControlShowing
        'If dgvConsultaBaixa.CurrentCell.ColumnIndex = 9 Or dgvConsultaBaixa.CurrentCell.ColumnIndex = 11 Then
        If Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)
            If dgvConsultaBaixa.CurrentCell.ColumnIndex = dgvConsultaBaixa.Columns("Horario").Index Then
                tb.MaxLength = 5
            Else
                tb.MaxLength = 3
            End If
            '---inclui um tratamento de evento para o controle TextBox---
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            'End If
        End If
    End Sub

    Public Sub New()
        InitializeComponent()

        Me.MdiParent = mdiPrincipal

    End Sub

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        btnBaixar.Enabled = False
        btnLimpar.Enabled = False
        DTS = Nothing
        dgvConsultaBaixa.DataSource = DTS

    End Sub

    Private Sub btnBaixar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaixar.Click

        Try
            lblCritica.Text = ""
            Dim CLS As MSAClass.asmxChecking.asmxChecking = NewChecking()
            Dim clsUsuario As MSAClass.AsmxUsuario.asmxUsuario = NewUsuario()
            Dim nCont As Integer
            Dim bCritica As Boolean
            Dim aIem(3) As String
            Dim avalores As Object
            Dim nChave_Acesso As Integer = 0
            Dim nQtde_Parametros As Integer = 0
            Dim strHorario As String
            Dim strPrograma As String
            avalores = ""
            bCritica = False

            If MsgBox(UCase("Deseja baixar as veiculações?"), vbQuestion + vbYesNo) = vbNo Then
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor

            With dgvConsultaBaixa
                .EndEdit()

                For Each row As DataGridViewRow In .Rows

                    If Trim(.Item("Cod_empresa", row.Index).Value) = "" Then
                        GoTo Proximo
                    End If

                    If Vernulo(.Item("Cod_Qualidade", row.Index).Value, "") = Vernulo(.Item("Cod_Qualidade_Ant", row.Index).Value, "") And _
                            Vernulo(.Item("Horario", row.Index).Value, "") = Vernulo(.Item("Horario_Exibicao_Ant", row.Index).Value, "") Then
                        GoTo Proximo
                    End If

                    strPrograma = .Item("Cod_Programa", row.Index).Value.ToString()


                    If isEmptyCell(.Item("Cod_Qualidade", row.Index)) Then
                        .Item("Cod_Qualidade", row.Index).Value = ""
                    End If

                    If isEmptyCell(.Item("Horario", row.Index)) Then
                        .Item("Horario", row.Index).Value = ""
                        strHorario = "01/01/1999 00:00:00"
                    Else
                        strHorario = FormatDateTime(TxtData.Text + " " & .Item("Horario", row.Index).Value, DateFormat.GeneralDate)
                    End If

                    nChave_Acesso = 0
                    If Not isEmptyCell(.Item("Chave_Acesso", row.Index)) Then
                        If Val(.Item("Chave_Acesso", row.Index).Value) > 0 Then
                            nChave_Acesso = Val(.Item("Chave_Acesso", row.Index).Value)
                        End If
                    End If

                    'If chkNaoQualidade.Checked = True And .Item("Cod_Qualidade", row.Index).Value <> "" Then
                    'GoTo Proximo
                    ' End If

                    If .Item("Cod_Qualidade", row.Index).Value = "VEI" And Trim(.Item("Horario", row.Index).Value) = "" Then
                        .Rows(row.Index).ErrorText = " Critica: Essa qualidade exige horário"
                        bCritica = True

                        GoTo Proximo
                    End If

                    If .Item("Cod_Qualidade", row.Index).Value <> "VEI" And Vernulo(.Item("Horario", row.Index).Value, "") <> "" Then
                        .Rows(row.Index).ErrorText = " Critica: Essa qualidade não aceita horário"
                        bCritica = True

                        GoTo Proximo
                    End If


                    If Trim(.Item("Cod_Qualidade", row.Index).Value) = "" And Trim(.Item("Horario", row.Index).Value) <> "" Then
                        .Rows(row.Index).ErrorText = " Critica: Nao foi informada a Qualidade"
                        bCritica = True
                        GoTo Proximo
                    End If

                    If (.Item("Critica", row.Index).Value <> 0 And .Item("Critica", row.Index).Value <> 2 And _
                       .Item("Critica", row.Index).Value <> 3 And .Item("Critica", row.Index).Value <> 5) Then
                        '      .TextMatrix(nCont, 1) = Chr(251)
                        .Rows(row.Index).ErrorText = " Critica: Tipo de Critica Inválida."
                        bCritica = True
                        GoTo Proximo
                    End If

                    If Not CLS.fnConsisteQualidadeBaixa(.Item("Cod_Qualidade", row.Index).Value) And Trim(.Item("Cod_Qualidade", row.Index).Value) <> "" Then
                        .Rows(row.Index).ErrorText = " Critica: Qualidade Inválida."
                        bCritica = True
                        GoTo Proximo
                    End If

                    'Se não existia qualidade e não tem crítica
                    If Trim(dgvConsultaBaixa.Item("Cod_Qualidade", row.Index).Value) <> "" And Trim(dgvConsultaBaixa.Item("Cod_Qualidade_Ant", row.Index).Value) = "" And _
                       (dgvConsultaBaixa.Item("Critica", row.Index).Value = 0 Or dgvConsultaBaixa.Item("Critica", row.Index).Value = 2 Or _
                       dgvConsultaBaixa.Item("Critica", row.Index).Value = 5) Then



                        If Not VePermissao(70) Then
                            .Rows(row.Index).ErrorText = " Critica: Permissão Negada para seu usuário."
                            bCritica = True
                            GoTo Proximo
                        End If
                        nQtde_Parametros = 8
                        If Not CLS.fnFuncao_Baixa(FormatDateTime(TxtData.Text, DateFormat.ShortDate), txtVeiculo.Text, strPrograma, nChave_Acesso, .Item("Cod_Qualidade", row.Index).Value, .Item("Documento_Para", row.Index).Value, 0, FormatDateTime(strHorario, DateFormat.GeneralDate), gsUsuario, 0, FormatDateTime("01/01/01", DateFormat.ShortDate), 0, "", 0, nQtde_Parametros) Then
                            Aviso("Erro ao baixar comercial. Linha " & nCont & " da grid.")
                            .RowHeadersDefaultCellStyle.BackColor = Color.Red
                            bCritica = True
                            Exit Sub
                            '  GoTo Saida
                        End If
                        'Se existia qualidade anterior, é diferente da digitada e tem crítica de
                        'Docto Para ou não tem crítica ou se tem horário
                    ElseIf _
                            Trim(dgvConsultaBaixa.Item("Cod_Qualidade", row.Index).Value) <> "" And Trim(dgvConsultaBaixa.Item("Cod_Qualidade_Ant", row.Index).Value) <> "" _
                            And _
                            ( _
                                Trim(dgvConsultaBaixa.Item("Cod_Qualidade", row.Index).Value) <> Trim(dgvConsultaBaixa.Item("Cod_Qualidade_Ant", row.Index).Value) _
                            ) _
                            And _
                            ( _
                              dgvConsultaBaixa.Item("Critica", row.Index).Value = 0 _
                              Or dgvConsultaBaixa.Item("Critica", row.Index).Value = 2 _
                              Or dgvConsultaBaixa.Item("Critica", row.Index).Value = 3 _
                              Or dgvConsultaBaixa.Item("Critica", row.Index).Value = 5 _
                             ) _
                            Or _
                            ( _
                                (Trim(dgvConsultaBaixa.Item("Horario", row.Index).Value) <> "" _
                                And Trim(dgvConsultaBaixa.Item("Horario", row.Index).Value) <> Trim(dgvConsultaBaixa.Item("Horario_Exibicao_Ant", row.Index).Value) _
                             )) Then

                        If Not VePermissao(71) Then
                            .Rows(row.Index).ErrorText = " Critica: Qualidade diferente ou Critica de Para."
                            bCritica = True
                            GoTo Proximo
                        End If
                        If Not CLS.fnFuncao_Baixa_Alteracao(FormatDateTime(TxtData.Text, DateFormat.ShortDate), txtVeiculo.Text, strPrograma, nChave_Acesso, .Item("Cod_Qualidade", row.Index).Value, 0, FormatDateTime(strHorario, DateFormat.GeneralDate), gsUsuario, 0) Then
                            Aviso("erro ao baixar comercial. Linha " & nCont & " da grid.")
                            .Rows(row.Index).ErrorText = " Critica: Erro na Baixa do Comercial "
                            bCritica = True
                            Exit Sub
                        End If

                        'Se existia qualidade anterior, qualidade digitada é branca e sem crítica ou
                        'crítica numero 3 (am aberta)
                    ElseIf Trim(.Item("Cod_Qualidade", row.Index).Value) = "" And Trim(.Item("Cod_Qualidade_Ant", row.Index).Value) <> "" And _
                           (.Item("Critica", row.Index).Value = 0 Or .Item("Critica", row.Index).Value = 2 Or _
                           .Item("Critica", row.Index).Value = 3 Or .Item("Critica", row.Index).Value = 5) Then

                        If Not VePermissao(71) Then
                            .Rows(row.Index).ErrorText = " Critica: Permissão de Alteração da Baixa Negada para o perfil do usuaário."
                            bCritica = True
                            GoTo Proximo
                        End If
                        nQtde_Parametros = 6
                        If Not CLS.fnFuncao_Baixa_Exclusao(FormatDateTime(TxtData.Text, DateFormat.ShortDate), _
                                                                            txtVeiculo.Text, _
                                                                            strPrograma, _
                                                                            nChave_Acesso, _
                                                                            0, _
                                                                            FormatDateTime(TxtData.Text, DateFormat.GeneralDate), _
                                                                            gsUsuario, _
                                                                            0, _
                                                                            FormatDateTime("01/01/01", DateFormat.ShortDate) _
                                                                            , 0, _
                                                                            1, _
                                                                            0, _
                                                                            0, _
                                                                            nQtde_Parametros) Then
                            Aviso("erro ao baixar comercial. Linha " & nCont & " da grid.")
                            .Rows(row.Index).ErrorText = " Critica: Erro na Baixa do Comercial."
                            bCritica = True
                            Exit Sub
                            '   GoTo Saida
                        End If
                    End If
                    .Rows(row.Index).ErrorText = ""
Proximo:
                Next
            End With
            Me.Cursor = Cursors.Default
            lblCritica.Text = ""

            If Not bCritica Then
                Aviso("baixa concluída com sucesso.")
                lblCritica.Text = "Baixa Concluída com Sucesso !!"
                lblCritica.ForeColor = Color.Blue

                If IsFormLoad("frmMRConsulta") Then
                    frmMRConsulta.Carrega_Veiculacoes(txtEmpresa.Text, txtContrato.Text, txtSeq.Text, txtVeiculo.Text, True)
                    Me.Close()
                End If
            Else
                Aviso("Baixa concluída com críticas")
                lblCritica.Text = "Veiculações com sinal de erro não foram baixadas.Passe o mouse sobre o simbolo do erro para ver a descrição"
                lblCritica.ForeColor = Color.Red
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmBaixaVeiculacao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmBaixaVeiculacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        MsgBox(e.KeyCode, MsgBoxStyle.Critical)
    End Sub

    Private Sub frmBaixaVeiculacao_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 10
        Me.Left = 10
        txtEmpresa.Usuario = gsUsuario
        txtVeiculo.Usuario = gsUsuario
        pubProssegueBaixa = True
    End Sub

    Private Sub TxtData_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtData.Validated
        Try
            If TxtData.Text.Trim <> "" Then
                txtPrograma.DataInicio = DateTime.Parse(TxtData.Text)
                txtPrograma.DataFim = DateTime.Parse(TxtData.Text)
            Else
                txtPrograma.DataInicio = Nothing
                txtPrograma.DataFim = Nothing
            End If

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub txtVeiculo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVeiculo.Validated
        Try
            If txtVeiculo.Text.Trim() <> "" Then
                txtPrograma.Veiculo = txtVeiculo.Text
                Dim dtsVeiculo As MSAClass.asmxVeiculo.dtsVeiculo = New MSAClass.asmxVeiculo.dtsVeiculo()
                Dim asmxVeiculo As MSAClass.asmxVeiculo.asmxVeiculo = NewVeiculo()
                dtsVeiculo = asmxVeiculo.spuCarregar(txtVeiculo.Text)
                ucSiglaVeiculo.Text = dtsVeiculo.Tables(0).Rows(0).Item("Sigla_Veiculo")
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub dgvConsultaBaixa_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvConsultaBaixa.CellDoubleClick
        Try
            '==========================================================================Double click no cod programa
            Select Case e.ColumnIndex
                Case dgvConsultaBaixa.Columns("Cod_Qualidade").Index
                    frmConsulta.Source = Nothing
                    dgvConsultaBaixa.EndEdit()
                    frmConsulta.sqlQuery = " Execute Prnet_Qualidade_l"
                    frmConsulta.ShowDialog()
                    If frmConsulta.OkClick Then
                        dgvConsultaBaixa.Item("Cod_Qualidade", dgvConsultaBaixa.CurrentRow.Index).Value = frmConsulta.Codigo
                    End If
                    frmConsulta.Dispose()
            End Select
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub


End Class