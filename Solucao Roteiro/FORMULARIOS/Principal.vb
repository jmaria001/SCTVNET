Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic

Friend Class mdiPrincipal
    Inherits System.Windows.Forms.Form
    Public asmxParametro As MSAClass.AsmxParametro.asmxParametro = NewParametro()
    Public dtsUsuario As New MSAClass.AsmxUsuario.dtsUsuario
    Public dtsParametro As New MSAClass.AsmxParametro.dtsParametro

   
    Private Sub mdiPrincipal_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
        Try
            'Me.BackgroundImage = Global.SCTVNET.My.Resources.Resources.SCTV
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
                lblVersao.Text = "Versao:" & System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
            Else
                lblVersao.Text = ""
            End If

            Me.Text = Me.Text & Space(20) & clsGeneric.fnServerName() & "/" & clsGeneric.fnDataBaseName
            frmAcesso.ShowDialog()
            frmAcesso.BringToFront()
            If Not frmAcesso.OkClik Then
                End
            Else
                frmAcesso.Dispose()
            End If
            frmApresentacao.Show()
            If Not frmApresentacao.bolMostraMensagem Then
                frmApresentacao.Close()
            End If
        Catch ex As Exception
            ShowErro(ex)
            End
        End Try
    End Sub
    Private Sub mdiPrincipal_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        For Each x As Form In Me.MdiChildren
            x.Dispose()
        Next
        End
    End Sub


    Public Sub mnuAjustarHorario_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        frmHorarioProgramacao.Show()
        frmHorarioProgramacao.BringToFront()

    End Sub

    Public Sub mnuBaixa_Horario_Programa_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuBaixa_Horario_Programa.Click
        frmBaixa_Horario_Exibicao_Programa.Show()
        frmBaixa_Horario_Exibicao_Programa.BringToFront()
    End Sub

    Public Sub mnuBreaksNaoConsiderados_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuBreaksNaoConsiderados.Click
        frmBreaksDesconsiderados.Show()
        frmBreaksDesconsiderados.BringToFront()
    End Sub

    Public Sub mnuCascata_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCascata.Click

        LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub


    Public Sub mnuComparacaoV2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuComparacaoV2.Click
        frmComparaRoteiroData.Show()
        frmComparaRoteiroData.BringToFront()
    End Sub

    Public Sub mnuComposicaoBreak_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuComposicaoBreak.Click
        frmComposicaoBreaks.Show()
        frmComposicaoBreaks.BringToFront()
    End Sub


    Public Sub mnuConsultaFitas_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuConsultaFitas.Click
        frmConsultaFitaOrdenada.Show()
        frmConsultaFitaOrdenada.BringToFront()
    End Sub

    Public Sub mnuEncerramentoRoteiro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEncerramentoRoteiro.Click
        frmRoteiro_Encerramento.chkEncerramento.Checked = True
        frmRoteiro_Encerramento.Text = "Encerramento do Roteiro"
        frmRoteiro_Encerramento.Show()
        frmRoteiro_Encerramento.BringToFront()
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Public Sub mnuExibicaoDigital_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExibicaoDigital.Click
        frmIntegraPlayList_Afiliada.Show()
        frmIntegraPlayList_Afiliada.BringToFront()
    End Sub



    Public Sub mnuHorizontal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHorizontal.Click
        LayoutMdi(System.Windows.Forms.ScrollBars.Horizontal)
    End Sub

    Public Sub mnuLayoutRetorno_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        '  frmLayoutRetorno.Show
    End Sub

    Public Sub mnuListaTranscricao_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Select Case sTipoAcesso
            Case "C"
                'frmListaTranscricao_Sbt.Show
            Case "F"
                'frmListaTranscricao_Regional.Show
            Case Else
                'frmListaTranscricao_Regional.Show
        End Select

    End Sub


    Public Sub mnuLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLog.Click
        frmRoteiro_Log.Show()
        frmRoteiro_Log.BringToFront()
    End Sub

    Public Sub mnuParametroRoteiro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'frmParametro_Roteiro.Show
        'frmParametro_Roteiro.ZOrder
    End Sub



    Public Sub mnuPreOrdenacao_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPreOrdenacao.Click
        frmPreOrdenacao.Show()
        frmPreOrdenacao.BringToFront()
    End Sub


    Public Sub mnuProgramação_Consulta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'frmGradeConsulta.Show
    End Sub

    Public Sub mnuRelatorio_Roteiro_tecnico_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRelatorio_Roteiro_tecnico.Click

        frmRelatorio_Roteiro.Show()
        frmRelatorio_Roteiro.BringToFront()

    End Sub

    Public Sub mnuRelatorioChecking_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRelatorioChecking.Click
        frmRelatorio_Checking.Show()
        frmRelatorio_Checking.BringToFront()
    End Sub

    Public Sub mnuReplicarRoteiro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuReplicarRoteiro.Click
        frmRoteiroReplicacao.Show()
        frmRoteiroReplicacao.BringToFront()
    End Sub

    Public Sub mnuRetorno_PlayList_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRetorno_PlayList.Click
        frmRetorno_Play_List.Show()
        frmRetorno_Play_List.BringToFront()
    End Sub

    Public Sub mnuRetornoRoteiroLocal_Click_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'frmRetornoRoteiroLocal.Show
    End Sub

    Public Sub mnuRoteiro_Consulta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        frmRoteiro_Consulta.Show()
        frmRoteiro_Consulta.BringToFront()
    End Sub


    Public Sub mnuRoteiro_ordenacao_Diaria_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRoteiro_ordenacao.Click
        Try
            frmRoteiroV2.Show()
            frmRoteiroV2.BringToFront()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub mnuRoteiroEncerrado_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        '    glFechaFormulário = False
        '   If stipoAcesso = "C" Then
        '      Load frmConsultaEncerramento
        '      If glFechaFormulário Then
        '         Unload frmConsultaEncerramento
        '      Else
        '         frmConsultaEncerramento.Show
        '      End If
        '   Else
        '      Aviso "Rotina disponível somente para usuários de  S.P"
        '   End If
        '
    End Sub

    Public Sub mnuRoteiroOrdenado_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRoteiroOrdenado.Click
        frmConsultaOrdenado.Show()
        frmConsultaOrdenado.BringToFront()
    End Sub

    Public Sub mnuSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnusair.Click
        End
    End Sub

    Public Sub mnusair2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnusair2.Click
        End
    End Sub

    Public Sub mnuUsuarioRoteiro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuUsuarioRoteiro.Click
        frmRoteiro_Usuario.Show()
        frmRoteiro_Usuario.BringToFront()
    End Sub

    Public Sub mnuVertical_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuVertical.Click
        LayoutMdi(System.Windows.Forms.ScrollBars.Vertical)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MainMenu1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuPrincipal.ItemClicked
    End Sub

    Private Sub mnuControleFita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuControleFita.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        frmControleFita_Afiliada.Show()
        frmControleFita_Afiliada.BringToFront()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub mnuLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLocalizar.Click
        frmOpcoesGrid.chkLocalizar.Checked = True
    End Sub

    Private Sub mnuClassificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClassificar.Click
        frmOpcoesGrid.chkClassificar.Checked = True
        mnuClassificar.Enabled = True
        mnuImprimir.Enabled = True
        mnuLocalizar.Enabled = True
        Exportar.Enabled = True


    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        frmOpcoesGrid.chkExportar.Checked = True
        mnuClassificar.Enabled = True
        mnuImprimir.Enabled = True
        mnuLocalizar.Enabled = True
        Exportar.Enabled = True

    End Sub

    Private Sub mnuImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImprimir.Click
        frmOpcoesGrid.chkImprimir.Checked = True
        mnuClassificar.Enabled = True
        mnuImprimir.Enabled = True
        mnuLocalizar.Enabled = True
        Exportar.Enabled = True

    End Sub

    Private Sub mnuCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCancela.Click
        frmOpcoesGrid.Dispose()
        mnuClassificar.Enabled = True
        mnuImprimir.Enabled = True
        mnuLocalizar.Enabled = True
        Exportar.Enabled = True
    End Sub

    Private Sub mdiPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Aviso("Confirma o encerramento do sistema ?", vbYesNo, vbQuestion, "Módulo Roteiro") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub HelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAjuda.Click
        System.Diagnostics.Process.Start("iexplore.exe", "http://LOCALHOST//help_roteiro")
    End Sub
    Public Sub HabilitaMenus(ByVal pName As String)
        Try
            For mnu As Integer = 0 To mnuPrincipal.Items.Count - 1
                If TypeOf (mnuPrincipal.Items(mnu)) Is ToolStripMenuItem Then
                    If fnHabilitaItem(mnuPrincipal.Items(mnu), pName) Then
                        Exit Sub
                    End If
                End If

            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Function fnHabilitaItem(ByVal pItem As ToolStripMenuItem, ByVal Pname As String) As Boolean  ' Recursive Function
        Try
            fnHabilitaItem = False
            If pItem.Name.ToUpper = Pname.ToUpper Then
                pItem.Visible = True
                fnHabilitaItem = True
                Exit Function
            End If

            For mnu As Integer = 0 To pItem.DropDownItems.Count - 1
                If TypeOf (pItem.DropDownItems(mnu)) Is ToolStripMenuItem Then
                    If fnHabilitaItem(pItem.DropDownItems(mnu), Pname) Then
                        Exit Function
                    End If
                End If
            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function

    Private Sub mnuSupervisão_Terceiros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSupervisão_Terceiros.Click
        frmTerceiro.Show()
        frmTerceiro.BringToFront()
    End Sub

    Private Sub mnuProgramação_Consulta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProgramação_Consulta.Click
        frmConsultaGrade.Show()
        frmConfirmacoes.BringToFront()
    End Sub

    Private Sub mnuMr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMr.Click
        frmMapaReserva.Show()
        frmMapaReserva.BringToFront()
    End Sub

    Private Sub mnuBaixa_Veiculacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBaixa_Veiculacao.Click
        frmBaixaVeiculacao.Show()
        frmBaixaVeiculacao.FormOrigem = frmBaixaVeiculacao.Name
        frmBaixaVeiculacao.BringToFront()
    End Sub

    Private Sub mnuBaixa_Roteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBaixaRoteiro.Show()
        frmBaixaRoteiro.BringToFront()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHistoricoContrato.Click
        frmMRConsulta.Show()
        frmMRConsulta.BringToFront()
        frmMRConsulta.Consulta_Ativa()
    End Sub

    Private Sub mnuDeterminação_Comerciais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeterminação_Comerciais.Click
        frmDeterminacao.Show()
        frmDeterminacao.BringToFront()
    End Sub

    Private Sub mnuCompensação_AM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompensação_AM.Click
        frmAM.Show()
        frmAM.BringToFront()
    End Sub

    Private Sub mnuProgramação_ProgramaçãoPrevista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProgramação_ProgramaçãoPrevista2.Click
        frmGrade.Show()
        frmGrade.BringToFront()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBaixa_Horario_Exibicao_Programa.Show()
        frmBaixa_Horario_Exibicao_Programa.BringToFront()
    End Sub


    Private Sub mnuAmEncerrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAmEncerrada.Click
        frmAmEncerrada.Show()
        frmAmEncerrada.BringToFront()
    End Sub

    Private Sub mnuProgramação_ProgramaçãoPrevista_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProgramação_ProgramaçãoPrevista.Click
        frmGradeExibicao.Show()
        frmGradeExibicao.BringToFront()
    End Sub

    Private Sub mnuProgramação_Programas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmPrograma.Show()
        'frmPrograma.BringToFront()
    End Sub

    Private Sub mnuProgramação_Programas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' frmPrograma.Show()
        ' frmPrograma.BringToFront()
    End Sub

    Private Sub mnuRoteiro_Confirmacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRoteiro_Confirmacao.Click
        frmConfirmacaoRoteiro.Show()
        frmConfirmacaoRoteiro.BringToFront()
    End Sub


    Private Sub mnu_CriticaCe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_CriticaCe.Click
        frmCriticaCe.Show()
        frmCriticaCe.BringToFront()
    End Sub

    Private Sub mnu_ImprimeCe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ImprimeCe.Click
        frmImpressaoCe.Show()
        frmImpressaoCe.BringToFront()
    End Sub

    Private Sub mnuReabre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReabre.Click
        frmReabreCe.Show()
        frmReabreCe.BringToFront()
    End Sub

    Private Sub mnuBaixa_Contrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBaixaContrato.Show()
        frmBaixaContrato.BringToFront()
    End Sub

    Private Sub mnuControleFitaPatrocinio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuControleFitaPatrocinio.Click
        frmControleFitaPatrocinio.Show()
        frmControleFitaPatrocinio.BringToFront()
    End Sub

    Private Sub mnuConsultaFitaPatrocinio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultaFitaPatrocinio.Click
        frmConsultaFitasPatrocinio.Show()
        frmConsultaFitasPatrocinio.BringToFront()
    End Sub
End Class
