
Public Class frmRoteiro_Usuario
    Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
    Dim dtsPorta As DataSet = New DataSet
    Dim bolCarregar As Boolean = False

    Private Sub frmRoteiro_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        bolCarregar = True
        rdbAmbos.Checked = True
        Me.Carrega()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.MdiParent = SCTVNET.mdiPrincipal
    End Sub
    Private Sub Carrega()

        If Not bolCarregar Then Exit Sub
        On Error GoTo Erro
        Dim strSql As String = "Execute PrNet_Usuario_Roteiro_Select "
        Me.Cursor = Cursors.WaitCursor

        If ucVeiculo.Text.Trim <> "" Then
            strSql += "@Par_Cod_Veiculo = '" & ucVeiculo.Text & "',"
        Else
            strSql += "@Par_Cod_Veiculo = Null,"
        End If

        If ucPrograma.Text.Trim <> "" Then
            strSql += "@Par_Cod_Programa = '" & ucPrograma.Text & "',"
        Else
            strSql += "@Par_Cod_Programa = Null,"
        End If

        If chkPerfil.Checked Then
            strSql += "@Par_Veiculo_Perfil = 1" & ucPrograma.Text & ","
        Else
            strSql += "@Par_Veiculo_Perfil = 0" & ucPrograma.Text & ","
        End If

        Select Case True
            Case rdbOrdenado.Checked
                strSql += "@Par_Operacao = '1,3,4',"
            Case rdbComposicao.Checked
                strSql += "@Par_Operacao = '2',"
            Case Else
                strSql += "@Par_Operacao = '1,2,3,4',"


        End Select

        strSql += "@Par_Usuario	= '" & gsUsuario & "'"
        dtsPorta.Clear()
        dtsPorta = clsGeneric.fnSqlExecute(strSql)


        EstiloGrid(dgvPorta, 1)
        dgvPorta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgvPorta.DataSource = dtsPorta.Tables(0)
        dgvPorta.Columns("Data").DisplayIndex = 0
        dgvPorta.Columns("Cod_Veiculo").DisplayIndex = 1
        dgvPorta.Columns("Cod_Programa").DisplayIndex = 2
        dgvPorta.Columns("Titulo").DisplayIndex = 3
        dgvPorta.Columns("Usuario").DisplayIndex = 4
        dgvPorta.Columns("Operacao").DisplayIndex = 5

        dgvPorta.Columns("Funcao").Visible = False
        dgvPorta.Columns("Data").HeaderText = "Data"
        dgvPorta.Columns("Cod_Veiculo").HeaderText = "Veículo"
        dgvPorta.Columns("Cod_Programa").HeaderText = "Programa"
        dgvPorta.Columns("Titulo").HeaderText = "Título"
        dgvPorta.Columns("Usuario").HeaderText = "Usuário"
        dgvPorta.Columns("Operacao").HeaderText = "Operação"


        dgvPorta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPorta.AutoResizeColumns()


Saida:
        Me.Cursor = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)

        Resume Saida
        Resume
    End Sub

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        Me.Dispose()
    End Sub

    Private Sub rdbOrdenado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOrdenado.CheckedChanged
        Call Carrega()
    End Sub

    Private Sub rdbComposicao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbComposicao.CheckedChanged
        Call Carrega()
    End Sub

    Private Sub rdbAmbos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAmbos.CheckedChanged
        Call Carrega()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Call Carrega()
    End Sub

    Private Sub cmdAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtualizar.Click
        Try
            DtsPorta.Clear()
            Me.Carrega()

        Catch ex As Exception
            MsgBox("Erro Atualizar", MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Dim strSql As String = ""
        Try
            If dgvporta.SelectedRows.Count > 0 Then
                For Each drw As DataGridViewRow In dgvporta.SelectedRows
                    strSql = "Pr_RSA_Porta_D "
                    strSql += dgvporta.Item("Funcao", drw.Index).Value & ","
                    strSql += "'" & dgvporta.Item("Cod_Veiculo", drw.Index).Value & "',"
                    'strSql += "'" & String.Format(dgvPorta.Item("Data", drw.Index).Value, "yyyy-mm-dd") & "',"
                    'strSql += "'" & DateTime.Parse(dgvPorta.Item("Data", drw.Index).Value) & "',"
                    strSql += "'" & VB6.Format(dgvPorta.Item("Data", drw.Index).Value, "yyyy-mm-dd") & "',"
                    strSql += "'" & dgvPorta.Item("Cod_Programa", drw.Index).Value & "',"
                    strSql += "'" & dgvPorta.Item("Usuario", drw.Index).Value.ToString.Trim & "'"
                    clsGeneric.fnSqlExecute(strSql)
                Next

                cmdAtualizar.PerformClick()

            End If

        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub chkPerfil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPerfil.CheckedChanged
        Call Carrega()
    End Sub

    Private Sub dgvPorta_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvPorta.CellFormatting

        Try
            If dgvPorta.Rows(e.RowIndex).Cells("Funcao").Value <> 2 Then
                e.CellStyle.ForeColor = PicOrdenacao.BackColor
            Else
                e.CellStyle.ForeColor = picComposicao.BackColor
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class