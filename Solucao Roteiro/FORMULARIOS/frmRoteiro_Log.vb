Public Class frmRoteiro_Log
    Dim nLoop As Integer
    Dim asmxRoteiroLog As MSAClass.AsmxRoteiroLog.asmxRoteiroLog
    Dim dtsRoteiroLog As New MSAClass.AsmxRoteiroLog.dtsRoteiroLog
    Private Sub frmRoteiro_Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Call EstiloGrid(dgvLog, 1)
        asmxRoteiroLog = NewRoteiroLog()

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MdiParent = SCTVNET.mdiPrincipal
        SCTVNET.mdiPrincipal.Show()


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAtualizar.Click

        Dim nNumero_Mr As Integer
        Dim nSequencia_Mr As Integer
        Dim nData As Date
        Dim nBreak As Short
        Dim nOperacao As String


        Me.Cursor = Cursors.WaitCursor

        If txtContrato.Text = "" Then
            nNumero_Mr = -1
        Else
            nNumero_Mr = Integer.Parse(txtContrato.Text.Trim)
        End If

        If txtSequencia.Text = "" Then
            nSequencia_Mr = -1
        Else
            nSequencia_Mr = Integer.Parse(txtSequencia.Text.Trim)
        End If

        If UcData.Text = "" Then
            nData = DateTime.MinValue
        Else
            nData = UcData.Text
        End If

        If txtBreaks.Text = "" Then
            nBreak = -1
        Else
            nBreak = Short.Parse(txtBreaks.Text)
        End If

        If txtOperacao.Text = "" Then
            nOperacao = ""
        Else
            nOperacao = txtOperacao.Text.Trim
        End If



        Try
            dtsRoteiroLog = asmxRoteiroLog.spuCarregaLog(ucVeiculo.Text.Trim, _
                                                           nData, _
                                                           UcPrograma.text.Trim, _
                                                           txtCod_Comercial.Text, _
                                                           nBreak, _
                                                           txtFita.Text.Trim, _
                                                           ucEmpresa.Text.ToString.Trim, _
                                                           nNumero_Mr, _
                                                           nSequencia_Mr, _
                                                           "", _
                                                           nOperacao)



            If DtsRoteiroLog.dtbConsultaLog.Count > 0 Then
                Dim drw As MSAClass.AsmxRoteiroLog.dtsRoteiroLog.dtbConsultaLogRow
                drw = DtsRoteiroLog.dtbConsultaLog(0)
                If drw.Qtde_Linhas > 500 Then
                    MsgBox("Sua Consulta Retornou: " + drw.Qtde_Linhas + " Registros " + vbCrLf + _
                    "Somente as 500 Primeiras serão Mostradas" + vbCrLf + "Favor Refinar a Pesquisa", _
                    MsgBoxStyle.OkOnly, "Aviso")
                End If
                With dgvLog
                    EstiloGrid(dgvLog, 2)
                    .DataSource = dtsRoteiroLog.dtbConsultaLog
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
                    .Columns("Qtde_Linhas").Visible = False
                    .AutoResizeColumns()
                End With
            Else
                MsgBox("Nenhum Registro Encontrado", MsgBoxStyle.OkOnly, "Aviso")
                LimpaCampos()
                dgvLog.DataSource = dtsRoteiroLog.dtbRoteiroLog
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception

        End Try

    End Sub
    Private Sub LimpaCampos()

        UcData.Text = ""
        ucEmpresa.Text = ""
        ucPrograma.Text = ""
        ucVeiculo.Text = ""
        txtBreaks.Text = ""
        txtContrato.Text = ""
        txtSequencia.Text = ""
        txtFita.Text = ""
        txtOperacao.Text = ""
    End Sub

    Private Sub txtContrato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrato.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 32 And KeyAscii <> 8 Then
            KeyAscii = 0
        End If

        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFita.KeyPress
      
    End Sub

    Private Sub txtSequencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSequencia.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 32 And KeyAscii <> 8 Then
            KeyAscii = 0
        End If

        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBreaks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBreaks.KeyPress
       
    End Sub

    Private Sub txtCod_Comercial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod_Comercial.KeyPress
     
    End Sub

    Private Sub txtFita_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFita.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class