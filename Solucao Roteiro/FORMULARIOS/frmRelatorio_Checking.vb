Public Class frmRelatorio_Checking
    Dim asmxRoteiro_Relatorios As MSAClass.AsmxRoteiro_Relatorios.asmxRoteiro_Relatorios
    Dim dtsRoteiro_Relatorios As New MSAClass.AsmxRoteiro_Relatorios.dtsRoteiro_Relatorios

    Private Sub frmRelatorio_Checking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        asmxRoteiro_Relatorios = NewRoteiro_Relatorios()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.MdiParent = SCTVNET.mdiPrincipal


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub chkVeiculacaoambos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVeiculacaoambos.CheckedChanged

        If chkVeiculacaoambos.Checked = True Then
            chkFalhas.Checked = True
            chkEncaixados.Checked = True
            chkFalhas.Enabled = False
            chkEncaixados.Enabled = False
        Else
            chkFalhas.Checked = False
            chkEncaixados.Checked = False
            chkFalhas.Enabled = True
            chkEncaixados.Enabled = True
        End If

    End Sub

    Private Sub chkRoteiroAmbos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRoteiroAmbos.CheckedChanged
        If chkRoteiroAmbos.Checked = True Then
            chkOrdenado.Checked = True
            chkNaoOrdenado.Checked = True
            chkOrdenado.Enabled = False
            chkNaoOrdenado.Enabled = False
        Else
            chkOrdenado.Checked = False
            chkNaoOrdenado.Checked = False
            chkOrdenado.Enabled = True
            chkNaoOrdenado.Enabled = True
        End If
    End Sub

    Private Sub UcButton1_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcButton1.Cancel_Click
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcButton1.Ok_Click
        On Error GoTo Erro




        Dim falha As Byte
        Dim encaixado As Byte
        Dim ordenado As Byte
        Dim naoord As Byte
        Dim cancelado As Byte



        If ucVeiculo.Text = "" Then
            MsgBox("Campo Veiculo é Obrigatório! ", MsgBoxStyle.OkOnly, "Aviso")
            ucVeiculo.Focus()
            Exit Sub
        End If

        If ucData.Ano < 1000 Then
            MsgBox("Campo Data é Obrigatório! ", MsgBoxStyle.OkOnly, "Aviso")
            ucData.Focus()
            Exit Sub
        End If


        If chkFalhas.Checked = True Then
            falha = 1
        Else
            falha = 0
        End If
        If chkEncaixados.Checked = True Then
            encaixado = 1
        Else
            encaixado = 0
        End If
        If chkOrdenado.Checked = True Then
            ordenado = 1
        Else
            ordenado = 0
        End If
        If chkNaoOrdenado.Checked = True Then
            naoord = 1
        Else
            naoord = 0
        End If
        If chkCanceladas.Checked = True Then
            cancelado = 1
        Else
            cancelado = 0
        End If

        Me.Cursor = Cursors.WaitCursor
        dtsRoteiro_Relatorios = asmxRoteiro_Relatorios.spuCarregarChecking(ucVeiculo.Text, _
                                                                                    ucData.DateTime, _
                                                                                    ucPrograma.Text, _
                                                                                    ucQualidade.Text, _
                                                                                    falha, _
                                                                                    encaixado, _
                                                                                    ordenado, _
                                                                                    naoord, _
                                                                                    cancelado)
        Dim rpt As New rptChecking

        If dtsRoteiro_Relatorios.dtbChecking.Count > 0 Then
            rpt.SetDataSource(dtsRoteiro_Relatorios.Tables(0))

            rpt.SetParameterValue("Filtro_Veiculo", "Veiculo: " & ucVeiculo.Descricao)
            rpt.SetParameterValue("Filtro_Data", "Data: " & ucData.Text)
            rpt.SetParameterValue("Filtro_Programa", "Programa: " & IIf(ucPrograma.Text = "", "Todos", ucPrograma.Descricao))
            rpt.SetParameterValue("Filtro_Qualidade", "Qualidade: " & IIf(ucQualidade.Text = "", "Todas", ucQualidade.Descricao))
            rpt.SetParameterValue("Filtro_Falhas", IIf(chkFalhas.Checked = True, "Falhas: Sim", "Falhas: Não"))
            rpt.SetParameterValue("Filtro_Encaixados", IIf(chkEncaixados.Checked = True, "Encaixados: Sim", "Encaixados: Não"))
            rpt.SetParameterValue("Filtro_Ordenado", IIf(chkOrdenado.Checked = True, "Ordenado: Sim", "Ordenado: Não"))
            rpt.SetParameterValue("Filtro_Nao_Ordenado", IIf(chkNaoOrdenado.Checked = True, "Não Ordenado: Sim", "Não Ordenado: Não"))



            frmImpressao.crvImpressao.ReportSource = rpt
            frmImpressao.crvImpressao.DisplayGroupTree = False
            frmImpressao.crvImpressao.ShowGroupTreeButton = False
            frmImpressao.Text = "Roteiro de Checking "
            frmImpressao.Show()
        Else
            MsgBox("Nenhum Registro Encontrado! ", MsgBoxStyle.OkOnly)
            Me.Cursor = Cursors.Default

            Exit Sub
        End If



        Me.Cursor = Cursors.Default

Saida:
        Me.Cursor = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub ucData_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ucData.Validating

    End Sub

    Private Sub UcButton1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcButton1.Load

    End Sub
End Class