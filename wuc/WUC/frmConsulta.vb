Public Class frmConsulta
    Dim strSql As String
    Dim strRetorno_1 As String = ""
    Dim strRetorno_2 As String = ""
    Dim cls As New clsDicionario
    Dim enuDicionario As clsDicionario.enuDicionario
    Dim ArrayCampo As New ArrayList
    Public UcObject As UcText
    Public Usuario As String = ""
    Public Senha As String = ""

    Public Property Dicionario() As clsDicionario.enuDicionario
        Get
            Dicionario = enuDicionario
        End Get
        Set(ByVal value As clsDicionario.enuDicionario)
            enuDicionario = value
        End Set
    End Property
    Public Property sqlQuery() As String
        Get
            sqlQuery = strSql
        End Get
        Set(ByVal value As String)
            strSql = value
        End Set
    End Property
    Public Property Retorno_1() As String
        Get
            Retorno_1 = strRetorno_1
        End Get
        Set(ByVal value As String)
            strRetorno_1 = value
        End Set
    End Property
    Public Property Retorno_2() As String
        Get
            Retorno_2 = strRetorno_2
        End Get
        Set(ByVal value As String)
            strRetorno_2 = value
        End Set
    End Property

    Private Sub frmConsulta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    End Sub

    Private Sub frmConsulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.CenterToScreen()
            Me.CarregaGrid()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
        End Try
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Row As New DataGridViewRow
        Try
            With gridConsulta
                Row = .CurrentRow
                Me.Retorno_1 = gridConsulta.Item(0, Row.Index).Value
                Me.Retorno_2 = gridConsulta.Item(1, Row.Index).Value
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Hide()
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Retorno_1 = ""
            Me.Retorno_2 = ""
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Dispose()
        End Try
    End Sub
    Private Sub gridConsulta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridConsulta.DoubleClick
        btnOk.PerformClick()
    End Sub
    Private Sub CarregaGrid()
        Try
            Dim cls As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric(Me.Usuario, Me.Senha)

            Dim dts As New DataSet

            Dim intAltura As Integer = 0
            Dim intLargura As Integer = 0
            Me.CenterToScreen()
            '-----Consistencias Gerais
            If Me.Dicionario = clsDicionario.enuDicionario.Programa_Grade Then
                If String.IsNullOrEmpty(Me.UcObject.Veiculo) Or Me.UcObject.DataInicio.Year = 1 Or Me.UcObject.DataFim.Year = 1 Then
                    Me.UcObject.MensagemErro = "Veículo e Período devem ser Informados para consultar programas da Grade"
                    Me.UcObject.ShowErro()
                    Me.UcObject.MensagemErro = ""
                    Me.Retorno_1 = ""
                    Me.Retorno_2 = ""
                    Me.Dispose()
                    Exit Try
                End If
            End If
            If Me.Dicionario = clsDicionario.enuDicionario.Programa_Patrocinado Then
                If Me.UcObject.Competencia = 0 Then
                    Me.UcObject.MensagemErro = "Competência deve informada antes de selecionar o programa"
                    Me.UcObject.ShowErro()
                    Me.UcObject.MensagemErro = ""
                    Me.Retorno_1 = ""
                    Me.Retorno_2 = ""
                    Me.Dispose()
                    Exit Try

                End If
            End If

            dts = cls.fnSqlExecute(Me.sqlQuery)

            With gridConsulta
                Me.Cursor = Cursors.WaitCursor
                .DataSource = dts.Tables(0)
                .RowHeadersVisible = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

                '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                .AutoResizeColumns()
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
                .AutoResizeRows()


                '===================================Altura do Forma
                With gridConsulta
                    '==================================Configuracao Form
                    For x As Integer = 0 To Math.Min(.Rows.Count - 1, 15)
                        intAltura += .Rows(x).Height
                    Next
                    .Height = intAltura + 24
                    Me.Height = .Top + .Height + 100
                End With
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
End Class