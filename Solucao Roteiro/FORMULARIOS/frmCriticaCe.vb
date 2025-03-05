Public Class frmCriticaCe

    Private Sub ucCritica_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucCritica.Cancel_Click
        Me.Close()
    End Sub

    Private Sub frmCriticaCe_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.MdiParent = mdiPrincipal
    End Sub

    Private Sub frmCriticaCe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0
        Try

            Me.Cursor = Cursors.WaitCursor
            Dim Cls As MSAClass.asmxChecking.asmxChecking = NewChecking()
            Dim Dts As DataSet = New DataSet
            Dts = Cls.fnCriticaCe(gsUsuario)

            EstiloGrid(gridCritica, 2)
            With gridCritica
                .DataSource = Dts.Tables(0)
                .ReadOnly = True
                .Columns("Cod_Empresa").HeaderText = "Empresa"
                .Columns("Numero_Mr").HeaderText = "Contrato"
                .Columns("Sequencia_Mr").HeaderText = "Seq."
                .Columns("Data_Processamento").HeaderText = "Processado em"


                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .AutoResizeColumns()
                .AutoResizeRows()
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub
End Class