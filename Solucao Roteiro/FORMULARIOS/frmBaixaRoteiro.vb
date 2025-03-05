Public Class frmBaixaRoteiro
    Public Sub New()
        Try
            Me.MdiParent = mdiPrincipal
            InitializeComponent()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub CarregaGrid()
        Dim strSql As String = ""
        Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
        Dim dtsTerceiro As New DataSet

        Try
            Me.Cursor = Cursors.WaitCursor
            '=========================================== Monta a Query
            strSql = " Execute prNet_Veiculo_Usuario_Select '" & gsUsuario & "'"

            '=========================================== Carrega / Configura o Grid
            dtsTerceiro = clsGeneric.fnSqlExecute(strSql)
            dtsTerceiro.Tables(0).Columns.Add("Check", GetType(System.Boolean))

            For Each ROW As DataRow In dtsTerceiro.Tables(0).Rows
                ROW.Item("Check") = False
            Next


            With dgvBaixaRoteiro
                .DataSource = dtsTerceiro.Tables(0)
                .Columns("Cod_Veiculo").HeaderText = "Código"
                .Columns("Nome_Veiculo").HeaderText = "Nome"
                .Columns("Check").HeaderText = ""

                .Columns("Check").DisplayIndex = 0
                .Columns("Cod_Veiculo").DisplayIndex = 1
                .Columns("Nome_Veiculo").DisplayIndex = 2

                
                .RowHeadersVisible = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""
                .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                .AutoResizeColumns()

            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmBaixaRoteiro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmBaixaRoteiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 10
        Me.Left = 10
        Call CarregaGrid()
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnnOkCancel.Ok_Click

        Dim bSeleciona As Boolean
        Dim clsChecking As MSAClass.asmxChecking.asmxChecking = NewChecking()
        Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
        Dim DtsSql As New DataSet
        Dim dDataDe, dDataFim As Date
        Dim strDiaSemana As String = ""
        Dim strVeiculo As String = ""
        Dim clsContrato As MSAClass.asmxContrato.asmxContrato = NewContrato()
        Dim intQtdBaixados As Integer = 0
        Try
            'Consiste os dados
            With dgvBaixaRoteiro
                For Each row As DataGridViewRow In .Rows
                    If .Item("Check", row.Index).Value <> 0 Then
                        strVeiculo += .Item("Cod_Veiculo", row.Index).Value

                    End If
                Next
            End With

            If strVeiculo = "" Then
                MsgBox("Nenhum Veículo foi Selecionado !", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If txtPrograma.Text.Trim = "" Then
                MsgBox("Programa não pode ser vazio!", MsgBoxStyle.Critical)
                txtPrograma.Focus()
                Exit Sub
            End If

            If txtQualidade.Text.Trim = "" Then
                MsgBox("Qualidade não pode ser vazio!", MsgBoxStyle.Critical)
                txtQualidade.Focus()
                Exit Sub
            End If

            If Trim(TxtDatade.Text.Trim) = "" Then
                Aviso("Data Inicial não pode ser vazio!", MsgBoxStyle.Critical)
                TxtDatade.Focus()
                Exit Sub
            End If

            bSeleciona = False
            strDiaSemana += IIf(chkDomingo.Checked, "S", "N")
            strDiaSemana += IIf(chkSegunda.Checked, "S", "N")
            strDiaSemana += IIf(chkTerca.Checked, "S", "N")
            strDiaSemana += IIf(chkQuarta.Checked, "S", "N")
            strDiaSemana += IIf(chkQuinta.Checked, "S", "N")
            strDiaSemana += IIf(chkSexta.Checked, "S", "N")
            strDiaSemana += IIf(chkSabado.Checked, "S", "N")

            If strDiaSemana = "NNNNNNN" Then
                MsgBox("Não foi selecionado nenhum dia da semana !", MsgBoxStyle.Critical)
                chkDomingo.Focus()
                Exit Sub
            End If

            dDataDe = DateTime.Parse(TxtDatade.Text)
            dDataFim = DateTime.Parse(TxtDataAte.Text)
            Me.Cursor = Cursors.WaitCursor
            intQtdBaixados = clsChecking.fnBaixaRoteiro(strVeiculo, dDataDe, dDataFim, txtPrograma.Text, txtTipoComercial.Text, txtQualidade.Text, strDiaSemana, gsUsuario)
            Me.Cursor = Cursors.Default
            If intQtdBaixados > 0 Then
                Aviso("Foram Baixadas " & intQtdBaixados & "  Veiculações !")
                txtPrograma.Text = ""
                txtPrograma.Descricao = ""
                txtTipoComercial.Text = ""
                txtTipoComercial.Descricao = ""
                txtQualidade.Text = ""
                txtQualidade.Descricao = ""
                TxtDatade.Text = ""
                TxtDataAte.Text = ""
                chkDomingo.Checked = False
                chkSegunda.Checked = False
                chkTerca.Checked = False
                chkQuarta.Checked = False
                chkQuinta.Checked = False
                chkSexta.Checked = False
                chkSabado.Checked = False
                chkTodos.Checked = False
            Else
                Aviso("Nenhuma Veiculação foi Encontrada para ser baixada")
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnDesmarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmarcar.Click
        With dgvBaixaRoteiro
            For Each row As DataGridViewRow In .Rows
                .Item("check", row.Index).Value = False
            Next
        End With
    End Sub
    Private Sub chkTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.Click
        Try
            chkDomingo.Checked = chkTodos.Checked
            chkSegunda.Checked = chkTodos.Checked
            chkTerca.Checked = chkTodos.Checked
            chkQuarta.Checked = chkTodos.Checked
            chkQuinta.Checked = chkTodos.Checked
            chkSexta.Checked = chkTodos.Checked
            chkSabado.Checked = chkTodos.Checked

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnMarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        With dgvBaixaRoteiro
            For Each row As DataGridViewRow In .Rows
                .Item("check", row.Index).Value = True
            Next
        End With
    End Sub
    Private Sub bnnOkCancel_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnnOkCancel.Cancel_Click
        Me.Close()
    End Sub

    Private Sub txtQualidade_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtQualidade.Validating
        Try
            If txtQualidade.Text.Trim.ToUpper = "VEI" Then
                Aviso("Qualidade com indicador de Horário não é permitido nessa operação")
                txtQualidade.Text = ""
                e.Cancel = True
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
End Class