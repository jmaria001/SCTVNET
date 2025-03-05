Public Class frmMRConsultaFiltro
    Public OkClick As Boolean = False
    Public Sub New()
        InitializeComponent()

        Me.Top = 20
        Me.Left = 40
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Try

            Dim sFlag As String
            frmMRConsulta.txtNegociacaoFiltro = txtNegociacao.Text.Trim
            frmMRConsulta.txtCompetenciaFiltroDe = TxtDatade.Text.Trim
            frmMRConsulta.txtCompetenciaFiltroAte = TxtDataAte.Text.Trim
            frmMRConsulta.txtAgenciaFiltro = txtAgencia.Text.Trim
            frmMRConsulta.txtClienteFiltro = txtCliente.Text.Trim
            frmMRConsulta.txtVeiculoFiltro = txtVeiculo.Text.Trim
            frmMRConsulta.txtContatoFiltro = txtContato.Text.Trim
            frmMRConsulta.txtNucleoFiltro = txtNucleo.Text.Trim
            frmMRConsulta.txtTipoMidiaFiltro = txtTipoMidia.Text.Trim
            frmMRConsulta.txtProdutoFiltro = txtProduto.Text.Trim
            frmMRConsulta.txtPiFiltro = txtNumeroPI.Text.Trim
            frmMRConsulta.txtDataInclusaoFiltro = txtDataInclusao.Text.Trim
            frmMRConsulta.txtEmpresaFiltro = txtEmpresa.Text.Trim
            frmMRConsulta.txtContratoFiltro = txtContrato.Text.Trim
            frmMRConsulta.txtSequenciaFiltro = txtSeq.Text.Trim
            frmMRConsulta.txtProgramaFiltro = txtPrograma.Text.Trim
            frmMRConsulta.txtTipoComercialFiltro = txtTipoComercial.Text.Trim
            frmMRConsulta.txtAbrangenciaFiltro = txtAbrangencia.Text.Trim

            frmMRConsulta.nAutorizadoFiltro = IIf(chkAutorizados.Checked, 1, 0)
            frmMRConsulta.nPendenteCe = IIf(chkPendentes.Checked, 1, 0)
            frmMRConsulta.nMostraProduto = IIf(chkMostraProduto.Checked, 1, 0)
            frmMRConsulta.nMostraVeiculo = IIf(chkMostraVeiculo.Checked, 1, 0)
            frmMRConsulta.nValoracaoNormalEventoFiltro = IIf(chkContratoEvento.Checked, 1, 0)
            frmMRConsulta.nRejeitadoFiltro = IIf(chkRejeitados.Checked, 1, 0)
            frmMRConsulta.nPendenteAutorizacao = IIf(chkAutorizacao.Checked, 1, 0)

            sFlag = ""
            sFlag = sFlag & frmMRConsulta.txtNegociacaoFiltro
            sFlag = sFlag & frmMRConsulta.txtCompetenciaFiltroDe
            sFlag = sFlag & frmMRConsulta.txtCompetenciaFiltroAte
            sFlag = sFlag & frmMRConsulta.txtAgenciaFiltro
            sFlag = sFlag & frmMRConsulta.txtClienteFiltro
            sFlag = sFlag & frmMRConsulta.txtContatoFiltro
            sFlag = sFlag & frmMRConsulta.txtNucleoFiltro
            sFlag = sFlag & frmMRConsulta.txtTipoMidiaFiltro
            sFlag = sFlag & frmMRConsulta.txtProdutoFiltro
            sFlag = sFlag & frmMRConsulta.txtDataInclusaoFiltro
            sFlag = sFlag & frmMRConsulta.txtEmpresaFiltro
            sFlag = sFlag & frmMRConsulta.txtContratoFiltro
            sFlag = sFlag & frmMRConsulta.txtSequenciaFiltro
            sFlag = sFlag & frmMRConsulta.txtVeiculoFiltro
            sFlag = sFlag & frmMRConsulta.txtPiFiltro
            sFlag = sFlag & frmMRConsulta.txtTipoComercialFiltro
            sFlag = sFlag & frmMRConsulta.txtAbrangenciaFiltro

            frmMRConsulta.sFlag = sFlag

            If chkAutorizacao.Checked = False And chkAutorizados.Checked = False And chkRejeitados.Checked = False Then
                MsgBox("PREENCHER UMA OPÇÃO DE AUTORIZAÇÃO", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If sFlag = "" Then
                MsgBox("PREENCHER UMA OPÇÃO DE FILTRO", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If TxtDatade.Text.Trim <> "" And TxtDataAte.Text.Trim = "" Then
                MsgBox("competência final deve ser preenchida", MsgBoxStyle.Critical)
                TxtDatade.Focus()
                Exit Sub
            ElseIf TxtDatade.Text.Trim = "" And TxtDataAte.Text.Trim <> "" Then
                MsgBox("competência inicial deve ser preenchida", MsgBoxStyle.Critical)
                TxtDatade.Focus()
                Exit Sub
            End If
            Me.OkClick = True
            Me.Hide()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmMRConsultaFiltro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.CenterToScreen()
        txtEmpresa.Usuario = gsUsuario
        txtVeiculo.Usuario = gsUsuario
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Try
            LimpaCampos(Me)
            chkAutorizacao.Checked = True
            chkRejeitados.Checked = True
            chkAutorizados.Checked = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.OkClick = False
        Me.Hide()
    End Sub

 
End Class