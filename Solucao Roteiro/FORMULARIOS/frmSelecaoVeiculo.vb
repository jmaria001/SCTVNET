Public Class frmSelecaoVeiculo
    Public DtsVeiculo As DataSet
    Dim bolOkClick As Boolean
    Dim dtsMercado As DataSet
    Dim strVeiculosMarcado As String
    Public Property VeiculosMarcados() As String
        Get
            VeiculosMarcados = strVeiculosMarcado
        End Get
        Set(ByVal value As String)
            strVeiculosMarcado = value
        End Set
    End Property
    Public Property OkCLick() As Boolean
        Get
            OkCLick = bolOkClick
        End Get
        Set(ByVal value As Boolean)
            bolOkClick = value
        End Set
    End Property
    Private Sub frmSelecaoVeiculo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Dim clsContrato As MSAClass.asmxContrato.asmxContrato = NewContrato()
        Dim colCheck As New DataColumn
        Dim strVeiculo As String
        Me.CenterToParent()
        Dim Rw() As DataRow = Nothing
        Try
            DtsVeiculo = clsContrato.fnVeiculoUsuarioCarregar(gsUsuario)
            EstiloGrid(gridVeiculo, 2)
            colCheck.ColumnName = "Check"
            colCheck.DataType = GetType(System.Boolean)


            DtsVeiculo.Tables("Veiculo").Columns.Add(colCheck)
            colCheck.SetOrdinal(0)
            With gridVeiculo

                .DataSource = DtsVeiculo.Tables("Veiculo")
                .Columns("Check").HeaderText = ""
                .Columns("Check").Width = 40
                .Columns("Cod_Veiculo").HeaderText = "Código"
                .Columns("Cod_Veiculo").Width = 70
                .Columns("Nome_Veiculo").HeaderText = "Descrição"
                .Columns("Nome_Veiculo").Width = 500

                .Columns("Cod_Veiculo").ReadOnly = True
                .Columns("Nome_Veiculo").ReadOnly = True

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
                .AutoResizeRows()

                For x As Integer = 0 To Me.VeiculosMarcados.Length - 1 Step 3
                    strVeiculo = Me.VeiculosMarcados.Substring(x, 3)
                    Rw = DtsVeiculo.Tables("Veiculo").Select("Cod_Veiculo = '" & strVeiculo & "'")
                    If Rw.Length <> 0 Then
                        Rw(0).Item("check") = True
                    End If
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub bntMarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntMarcar.Click
        Try
            With gridVeiculo
                For Each row As DataGridViewRow In .Rows
                    .Item("Check", row.Index).Value = True
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnDesmarcar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesmarcar.Click
        Try
            With gridVeiculo
                For Each row As DataGridViewRow In .Rows
                    .Item("Check", row.Index).Value = False
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Try
            Me.OkCLick = False
            Me.Hide()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Try
            Me.OkCLick = True
            Me.Hide()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
End Class