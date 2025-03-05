Public Class frmConsulta
    Dim strSql As String
    Dim strCodigo As String
    Dim strDescricao As String
    Dim ArrayCampo As New ArrayList
    Dim dtb As DataTable
    Dim bolOkClick As Boolean
    Public Property OkClick() As Boolean
        Get
            OkClick = bolOkClick
        End Get
        Set(ByVal value As Boolean)
            bolOkClick = value
        End Set
    End Property
    Public Property Source() As DataTable
        Get
            Source = dtb
        End Get
        Set(ByVal value As DataTable)
            dtb = value
        End Set
    End Property
    Public Property sqlQuery() As String
        Get
            sqlQuery = strSql
        End Get
        Set(ByVal value As String)
            strSql = value
            If Not String.IsNullOrEmpty(strSql) Then
                Dim cls As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
                Me.Source = cls.fnSqlExecute(strSql).Tables(0)
            End If
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Codigo = strCodigo
        End Get
        Set(ByVal value As String)
            strCodigo = value
        End Set
    End Property
    Public Property Descricao() As String
        Get
            Descricao = strDescricao
        End Get
        Set(ByVal value As String)
            strDescricao = value
        End Set
    End Property
    Private Sub frmConsulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            Me.CarregaGrid()
        Catch ex As Exception
            ShowErro(ex)
        Finally
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub gridConsulta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridConsulta.DoubleClick
        btnOkCancel_Ok_Click(Me, New EventArgs)
    End Sub
    Private Sub CarregaGrid()
        Try
            Dim cls As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
            Dim intAltura As Integer = 0
            Dim intLargura As Integer = 0
            With gridConsulta
                Me.Cursor = Cursors.WaitCursor
                .DataSource = Me.Source
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
                .AutoResizeRows()
                .RowHeadersVisible = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect

                '===================================Altura do Forma
                'With gridConsulta
                ' '==================================Configuracao Form
                ' For x As Integer = 0 To Math.Min(.Rows.Count - 1, 15)
                ' intAltura += .Rows(x).Height
                ' Next
                ' .Height = intAltura + 24
                ' Me.Height = .Top + .Height + 100
                'End With
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.CenterToScreen()
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strOperador As String = ""
        Dim strConteudo As String = ""
        Dim strQuery As String = ""
        Try
            Me.CarregaGrid()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub btnOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Try
            Me.OkClick = False
            Me.Codigo = ""
            Me.Descricao = ""
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Dispose()
        End Try
    End Sub
    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Dim Row As New DataGridViewRow
        Try
            Me.OkClick = True
            With gridConsulta
                Row = .CurrentRow
                Me.Codigo = gridConsulta.Item(0, Row.Index).Value
                Me.Descricao = gridConsulta.Item(1, Row.Index).Value
            End With
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Hide()
        End Try
    End Sub

End Class