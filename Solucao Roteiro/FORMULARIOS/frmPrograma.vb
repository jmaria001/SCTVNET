Public Class frmPrograma
    Private clsPrograma As New MSAClass.Programa.asmxPrograma
    Dim dtsPrograma As New DataSet

    Private Sub frmPrograma_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmPrograma_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0
        Try
            Me.Carregar()
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub New()
        Me.MdiParent = mdiPrincipal
        InitializeComponent()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnOpcoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcoes.Click
        frmProgramaCadastro.ShowDialog()
        frmProgramaCadastro.BringToFront()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            With frmProgramaCadastro
                .Operacao = frmProgramaCadastro.enuOperacao.Incluir
                .Show()

            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub Carregar()
        Try

            Call EstiloGrid(gridPrograma, 1)
            Me.Cursor = Cursors.WaitCursor

            dtsPrograma = clsPrograma.spuProgramaUsuario(gsUsuario)


            With gridPrograma
                .DataSource = dtsPrograma.Tables(0)
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoResizeColumns()
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""

                .Columns("Cod_Programa").HeaderText = "Código"
                .Columns("Titulo").HeaderText = "Título"
                .Columns("Cod_Genero").HeaderText = "Gênero"
                .Columns("Data_Desativacao").HeaderText = "Dt Desativação"
                .Columns("Indica_Desativado").HeaderText = "Desativado"
                .Columns("Indica_Evento").HeaderText = "Evento"
                .Columns("asIndica_Rotativo").HeaderText = "Rotativo"
                .Columns("Indica_Local").HeaderText = "Local"
                .Columns("Data_Cadastramento").HeaderText = "Dt Cadastro"
                .Columns("Cod_Usuario").HeaderText = "Usuário"

                .Columns("Cod_Usuario").Visible = False

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()

            End With

        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class