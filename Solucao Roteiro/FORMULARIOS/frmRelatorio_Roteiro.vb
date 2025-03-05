Public Class frmRelatorio_Roteiro

    Dim asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro
    Dim dtsRoteiro As New MSAClass.AsmxRoteiro.dtsRoteiro


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub chkLinha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLinha.CheckedChanged
        cboLinhas.Visible = chkLinha.Checked = True
        If chkLinha.Checked = False Then
            cboLinhas.Items.Clear()
        Else
            cboLinhas.Items.Add("1 Linha")
            cboLinhas.Items.Add("2 Linhas")
            cboLinhas.Items.Add("3 Linhas")
        End If

    End Sub

    Private Sub btnOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Ok_Click
        On Error GoTo Erro


        If ucVeiculo.Text = "" Then
            Aviso("Campo Veiculo é Obrigatório! ", MsgBoxStyle.OkOnly, "Aviso")
            GoTo saida
        End If

        If ucData.Text.Trim = "" Or ucData.DateTime = Date.MinValue Then
            Aviso("Campo data é obrigatório")
            GoTo Saida
        End If
        Me.Cursor = Cursors.WaitCursor
        dtsRoteiro = asmxRoteiro.spuCarregar_Roteiro(ucVeiculo.Text, ucData.Text, ucPrograma1.Text, 1, 0)
        Dim rpt As New rptRoteiro

        If dtsRoteiro.dtbRoteiro_Ordenado.Count > 0 Then
            If chkNet.Checked = False Then
                Dim dvwRoteiro_Ordenado As DataView
                dvwRoteiro_Ordenado = dtsRoteiro.dtbRoteiro_Ordenado.DefaultView
                dvwRoteiro_Ordenado.RowFilter = "Isnull(Tipo_Intervalo,0) <> 1 and Tipo_Break <> 1"
            End If

            rpt.SetDataSource(dtsRoteiro.dtbRoteiro_Ordenado.DefaultView)
            rpt.SetParameterValue("Indica_Capa", chkCapa.Checked)
            rpt.SetParameterValue("linhas_vazias", cboLinhas.SelectedIndex + 1)
            frmImpressao.crvImpressao.ReportSource = rpt
            frmImpressao.crvImpressao.DisplayGroupTree = False
            frmImpressao.crvImpressao.ShowGroupTreeButton = False
            frmImpressao.Text = "Roteiro de Programação "
            frmImpressao.Show()
        Else
            MsgBox("Nenhum Registro Encontrado! ", MsgBoxStyle.OkOnly)
            GoTo Saida
        End If


        Me.Cursor = Cursors.Default
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmRelatorio_Roteiro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRelatorio_Roteiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.asmxRoteiro = NewRoteiro()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.MdiParent = SCTVNET.mdiPrincipal


    End Sub

  
    Private Sub btnOkCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Load

    End Sub
End Class