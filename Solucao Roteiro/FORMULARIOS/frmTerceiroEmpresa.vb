Public Class frmTerceiroEmpresa
    Dim bolOkClik As Boolean
    Public Property OkClick() As Boolean
        Get
            OkClick = bolOkClik
        End Get
        Set(ByVal value As Boolean)
            bolOkClik = value
        End Set
    End Property
    Private Sub frmTerceiroEmpresa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Dim dtv As DataView = New DataView
        Try

            Me.CenterToScreen()
            Call CarregaGrid()
            Me.OkClick = False
            '============================Marca as empresas que já estão ativadas para o cliente
            With frmTerceiro_Cadastro
                'For Each bindRow As DataRow In .bdSource.DataSource.Rows
                'For Each gridRow As DataGridViewRow In gridEmpresa.Rows
                'If gridEmpresa.Item("Cod_Empresa", gridRow.Index).Value = bindRow.Item("Cod_Empresa").ToString Then
                'gridEmpresa.Item("Check", gridRow.Index).Value = True
                'Exit For
                'End If
                'Next
                'Next
            End With


        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub CarregaGrid()
        Dim clsUsuario As MSAClass.AsmxUsuario.asmxUsuario = NewUsuario()
        Dim dtsEmpresa As New DataSet
        dtsEmpresa = clsUsuario.fnUsuario_Empresa(gsUsuario, "")
        Dim Dtc As DataColumn
        Dtc = New DataColumn("Check", System.Type.GetType("System.Boolean"))
        Try
            Me.Cursor = Cursors.WaitCursor
            Call EstiloGrid(gridEmpresa, 2)
            With gridEmpresa
                .DataSource = dtsEmpresa.Tables(0)
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoResizeColumns()
                dtsEmpresa.Tables(0).Columns.Add(Dtc)
                gridEmpresa.Columns(1).HeaderText = "Código"
                gridEmpresa.Columns(2).HeaderText = "Razão Social"

                gridEmpresa.Columns("Check").HeaderText = ""
                gridEmpresa.Columns("Check").DisplayIndex = 0
                gridEmpresa.Columns("Cod_Empresa").DisplayIndex = 1
                gridEmpresa.Columns("Razao_Social").DisplayIndex = 2

                gridEmpresa.Columns("Cod_Empresa").ReadOnly = True
                gridEmpresa.Columns("Razao_Social").ReadOnly = True
                gridEmpresa.DataSource = dtsEmpresa.Tables(0)

                For Each row As DataGridViewRow In gridEmpresa.Rows
                    .Item("check", row.Index).Value = False
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub bnnOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bnnOkCancel.Cancel_Click
        Me.Dispose()
    End Sub
    Private Sub bnnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bnnOkCancel.Ok_Click
        Me.OkClick = True
        Me.Hide()
    End Sub
    Private Sub bnnOkCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnnOkCancel.Load
        Me.OkClick = False
        Me.Hide()
    End Sub
    Private Sub bntMarcar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            For Each Row As DataGridViewRow In gridEmpresa.Rows
                gridEmpresa.Item("Check", Row.Index).Value = True
            Next
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub bntdesMarcar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntDesMarcar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            For Each Row As DataGridViewRow In gridEmpresa.Rows
                gridEmpresa.Item("Check", Row.Index).Value = False
            Next
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class