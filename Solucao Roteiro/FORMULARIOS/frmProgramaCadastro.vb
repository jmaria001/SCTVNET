Public Class frmProgramaCadastro

    Enum enuOperacao
        Incluir
        Desativar
        Editar
        Excluir
    End Enum
    Dim dtsVeiculo As New DataSet
    Public dtbPrograma As DataTable
    Dim clsGeneric As New MSAClass.Generic.asmxGeneric
    Dim clsPrograma As New MSAClass.Programa.asmxPrograma
    Public Operacao As enuOperacao
    Public OkClick As Boolean
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub frmProgramaCadastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Try
            Me.CenterToScreen()

            dtsVeiculo = clsGeneric.fnSqlExecute("prNet_Veiculo_Usuario_Select '" & gsUsuario & "'")
            EstiloGrid(gridVeiculo, 2)
            Select Case Me.Operacao
                Case enuOperacao.Incluir
                    ucVersao.Text = "1"
                Case enuOperacao.Editar
                    ucVersao.Text = Integer.Parse(Vernulo(dtbPrograma.Rows(0).Item("Versao"), "0")) + 1

            End Select

            With dtsVeiculo.Tables(0)
                .Columns.Add("Check", GetType(System.Boolean))
            End With
            With gridVeiculo
                gridVeiculo.DataSource = dtsVeiculo.Tables(0)
                .Columns("Cod_Veiculo").HeaderText = "Código"
                .Columns("Nome_Veiculo").HeaderText = "Veiculo"
                .Columns("Check").HeaderText = ""
                .Columns("Check").DisplayIndex = 0
                .Columns("Cod_Veiculo").DisplayIndex = 1
                .Columns("Nome_Veiculo").DisplayIndex = 2

                .Columns("Check").ReadOnly = False
                .Columns("Cod_Veiculo").ReadOnly = True
                .Columns("Nome_Veiculo").ReadOnly = True

                .Columns("Check").Width = 30
                .Columns("Cod_Veiculo").Width = 50
                .Columns("Nome_Veiculo").Width = 400

                .RowsDefaultCellStyle.SelectionBackColor = .RowsDefaultCellStyle.BackColor
                .RowsDefaultCellStyle.ForeColor = .RowsDefaultCellStyle.ForeColor

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()



            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnOkCancel_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Close()
    End Sub

    Private Sub btnOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        Dim bolConsistencia As Boolean = True
        Try
            '=================Consiste Obrigatorio
            If Not ConsisteObrigatorio(Me) Then
                bolConsistencia = False
            End If
            '==================Consiste Codigo do Programa
            If clsPrograma.ExistePrograma(ucCodigo.Text) Then
                ucCodigo.MensagemErro = "Já existe programa utilizando esse código"
                bolConsistencia = False
            End If

            If Not bolConsistencia Then
                Exit Try
            End If

            Me.AtualizaDataTable()
            If Not clsPrograma.Salvar(dtbPrograma) Then
                Exit Try
            End If
            Me.OkClick = True

        Catch ex As Exception

        End Try
    End Sub
    Private Function ConsisteObrigatorio(ByVal pControl As Control) As Boolean
        Dim ctrTxt As New WUC.UcText
        ConsisteObrigatorio = True
        Try
            For Each Ctr As Control In pControl.Controls
                If TypeOf (Ctr) Is WUC.UcText Then
                    ctrTxt = Ctr
                    If ctrTxt.Obrigatorio And ctrTxt.Text.Trim = "" Then
                        ctrTxt.MensagemErro = "Campo de Preenchimento Obrigatório"
                        ConsisteObrigatorio = False
                    End If
                End If
                If Ctr.HasChildren Then
                    Call ConsisteObrigatorio(Ctr)
                End If
            Next
        Catch ex As Exception
            ShowErro(ex)
            ConsisteObrigatorio = False
        End Try
    End Function

    Private Sub frmProgramaCadastro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub AtualizaDataTable()
        Dim Row As DataRow = Nothing
        Try
            Select Case Me.Operacao
                Case enuOperacao.Incluir
                    Row = dtbPrograma.NewRow
                Case enuOperacao.Editar
                    Row = dtbPrograma.Rows(0)
            End Select
            Row.Item("Cod_Programa") = ucCodigo.Text
            Row.Item("Versao") = ucVersao.Text
            Row.Item("Cod_Genero") = ucGenero.Text
            Row.Item("Data_Desativacao") = DBNull.Value
            Row.Item("Validade_Inicial") = ucData.Text
            Row.Item("Indica_Desativado") = 0
            Row.Item("Indica_Evento") = chkEvento.Checked
            Row.Item("Indica_Rotativo") = chkRotativo.Checked
            Row.Item("Indica_Local") = 1
            Row.Item("Titulo") = ucTitulo.Text
            Row.Item("Sub_Titulo") = ucSubTitulo.Text
            Row.Item("Data_Cadastramento") = Now
            Row.Item("Cod_Usuario") = gsUsuario
            Row.Item("Indica_Ce_Exibido") = 1
            Row.Item("Indica_PSS") = 0
            Row.Item("Cod_A_JOVE") = ucJoveAlfa.Text
            Row.Item("Cod_N_JOVE") = ucJoveNumerico.Text
            Row.Item("Tipo_Programa") = DBNull.Value
            Row.Item("Cod_Faturamento") = DBNull.Value

            If Me.Operacao = enuOperacao.Incluir Then
                dtbPrograma.Rows.Add(Row)
            End If
            dtbPrograma.AcceptChanges()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

End Class