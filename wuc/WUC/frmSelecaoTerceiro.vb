Public Class frmSelecaoTerceiro
    'Dim clsGeneric As New MSAClass.AsmxGeneric
    Dim dtsTerceiro As New DataSet
    Public OkClick As Boolean
    Public Cod_Terceiro As String = Nothing
    Public Razao_Social As String = Nothing
    Public Usuario As String = ""
    Public Senha As String = ""

    Private Sub frmSelecaoTerceiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Try
            With gridTerceiro
                .ReadOnly = True
                .BackgroundColor = Color.White
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToResizeRows = False
                .RowHeadersVisible = False
                .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                .RowHeadersDefaultCellStyle.NullValue = ""
                .RowsDefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
                .BackgroundColor = Color.White
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .AutoResizeColumns()
                .AutoResizeRows()
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub bntOnCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bntOnCancel.Cancel_Click
        Me.OkClick = False
        Me.Hide()

    End Sub

    Private Sub bntOnCancel_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntOnCancel.Ok_Click
        Try
            With gridTerceiro
                If Not .CurrentCell Is Nothing Then
                    Me.Cod_Terceiro = .Item("Cod_Terceiro", .CurrentRow.Index).Value
                    Me.Razao_Social = .Item("Razao_Social", .CurrentRow.Index).Value
                End If
            End With
            Me.OkClick = True
            Me.Hide()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnProcurar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcurar.Click
        Dim strQuery As String = ""
        Dim strSql As String = ""
        'Dim Cls As MSAClass.asmxGeneric.asmxGeneric = NewGeneric(Me.Usuario, Me.Senha)
        Dim Cls As MSAClass.AsmxTerceiro.asmxTerceiro = NewTerceiro(Me.Usuario, Me.Senha)

        Try
            ''strQuery = ""
            'If ucCodigo.Text.Trim <> "" Then
            '    strQuery += " And T.Cod_Terceiro Like '%" & ucCodigo.Text.Trim & "%'"
            'End If
            'If ucRazaoSocial.Text.Trim <> "" Then
            '    strQuery += " And T.Razao_Social Like '%" & ucRazaoSocial.Text.Trim & "%'"
            'End If
            'If ucCGC.Text.Trim <> "" Then
            '    strQuery += " And T.CGC Like  '%" & ucCGC.Text.Trim & "%'"
            'End If
            'If ucNomeFantasia.Text.Trim <> "" Then
            '    strQuery += " And T.Nome_Fantasia Like '%" & ucNomeFantasia.Text.Trim & "%'"
            'End If

            'If strQuery = "" Then
            '    MsgBox("Nenhum filtro foi informado", MsgBoxStyle.OkOnly)
            '    Exit Try
            'End If

            'strSql = "  Select   Distinct top 500 T.Cod_Terceiro,T.Razao_Social,T.Nome_Fantasia,T.CGC "
            'strSql += " From    Terceiro T, Terceiro_Complementar C ,Usuario_Empresa U"
            'strSql += " Where   C.Cod_Terceiro = T.Cod_Terceiro "
            'strSql += " And     U.Cod_Usuario = '" & Me.Usuario & "'"
            'strSql += " and charindex(C.Cod_Empresa,U.Cod_Empresa) > 0 "
            'strSql += strQuery


            'dtsTerceiro = Cls.fnSqlExecute(strSql)
            'dtsTerceiro = Cls.spuTerceiroFiltro(ucCodigo.Text,ucRazaoSocial.Text,ucNomeFantasia.Text,ucCGC.Text

            dtsTerceiro = Cls.spuTerceiroFiltro(ucCodigo.Text, ucRazaoSocial.Text, ucNomeFantasia.Text, ucCGC.Text, "", 0, Me.Usuario)
            gridTerceiro.DataSource = dtsTerceiro.Tables(0)
            gridTerceiro.AutoResizeColumns()

            If dtsTerceiro.Tables(0).Rows.Count = 500 Then
                MsgBox("Consulta retornou muitos registros e somente os 500 primeiros foram mostrados. Favor refinar o filtro", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub bntOnCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntOnCancel.Load

    End Sub


    Private Sub gridTerceiro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridTerceiro.DoubleClick
        Call bntOnCancel_Ok_Click(New Object, New EventArgs)
    End Sub
End Class