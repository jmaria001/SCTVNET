Public Class frmSelecaoPrograma
    Dim strCodigoPrograma As String
    Dim bolokClik As Boolean
    Dim dtsGrade As DataSet = Nothing
    Public Property Source() As DataSet
        Get
            Source = dtsGrade
        End Get
        Set(ByVal value As DataSet)
            dtsGrade = value
        End Set
    End Property
    Public Property OkClick() As Boolean
        Get
            OkClick = bolokClik
        End Get
        Set(ByVal value As Boolean)
            bolokClik = value
        End Set
    End Property
    Public Property CodigoPrograma() As String
        Get
            CodigoPrograma = strCodigoPrograma
        End Get
        Set(ByVal value As String)
            strCodigoPrograma = value
        End Set
    End Property
    Private Sub btnOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Try
            Me.OkClick = False
            Me.CodigoPrograma = Nothing
            Me.Hide()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Try
            Me.OkClick = True
            Me.CodigoPrograma = gridPrograma.Item("Cod_Programa", gridPrograma.CurrentRow.Index).Value
            Me.Hide()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub frmSelecaoPrograma_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            Me.CenterToParent()
            EstiloGrid(gridPrograma, 2)
            With gridPrograma
                .ReadOnly = True
                .DataSource = Me.Source.Tables(0)
                .Columns("cod_programa").HeaderText = "Código"
                .Columns("Titulo").HeaderText = "Título"
                .Columns("Horario_Exibicao").HeaderText = "Horário"

                .Columns("cod_programa").Width = 70
                .Columns("Titulo").Width = "200"
                .Columns("Horario_Exibicao").Width = 70
                .Columns("Seg").Width = 40
                .Columns("Ter").Width = 40
                .Columns("Qua").Width = 40
                .Columns("Qui").Width = 40
                .Columns("Sex").Width = 40
                .Columns("Sab").Width = 40
                .Columns("Dom").Width = 40

                .Columns("cod_programa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Titulo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("Horario_Exibicao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Seg").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Ter").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Qua").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Qui").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Sex").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Sab").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Dom").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("Titulo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumn(.Columns("Titulo").Index)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub gridPrograma_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridPrograma.CellDoubleClick
        btnOkCancel_Ok_Click(btnOkCancel, New EventArgs)
    End Sub
    Private Sub gridPrograma_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridPrograma.CellValueChanged
        If e.ColumnIndex > 2 And e.RowIndex > 0 Then
            If gridPrograma.Item(e.ColumnIndex, e.RowIndex).Value = 0 Then
                gridPrograma.Item(e.ColumnIndex, e.RowIndex).Value = 9
            End If
        End If

    End Sub
End Class