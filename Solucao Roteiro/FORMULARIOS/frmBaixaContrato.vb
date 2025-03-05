Public Class frmBaixaContrato
    Dim clsChecking As MSAClass.asmxChecking.asmxChecking = NewChecking()
    Dim strEmpresa As String
    Dim intContrato As Int32
    Dim intSequencia As Int16
    Dim dtsContrato As DataSet
    Dim dtsVeiculo As DataSet
    Dim dtsPrograma As DataSet
    Dim dtsComercial As DataSet
    Dim strCodQualidadeCan As String
    Dim strNomeQualidadeCan As String

    Private Sub frmBaixaContrato_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub


    Private Sub frmBaixaContrato_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        strEmpresa = ""
        intContrato = 0
        intSequencia = 0
        Me.Top = 0
        Me.Left = 0

        strCodQualidadeCan = fParametro(2)
        optBaixa.Checked = True


    End Sub

    Public Sub New()
        Me.MdiParent = mdiPrincipal
        InitializeComponent()
    End Sub
    Private Sub CarregaDadosContrato()
        Try

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub ValidaContrato()

        Dim DrwContrato As DataRow

        Try
            If ucEmpresa.Text = "" Or ucContrato.DataNumberValue = 0 Or ucSequencia.DataNumberValue = 0 Then
                ucPeriodoCampanha.Text = ""
                ucAgencia.Text = ""
                ucCliente.Text = ""
                Exit Try
            End If

            If strEmpresa <> ucEmpresa.Text Or intContrato <> ucContrato.DataNumberValue Or intSequencia <> ucSequencia.DataNumberValue Then
                ucPeriodoCampanha.Text = ""
                ucAgencia.Text = ""
                ucCliente.Text = ""
                gridVeiculo.DataSource = Nothing
                gridPrograma.DataSource = Nothing
                gridComercial.DataSource = Nothing

                dtsContrato = clsChecking.fnBaixaContradoDadosContrato(ucEmpresa.Text, ucContrato.DataNumberValue, ucSequencia.DataNumberValue)
                If dtsContrato.Tables(0).Rows.Count = 0 Then
                    Aviso("Empresa/Contrato/Sequencia Invalído")
                    ucEmpresa.Text = ""
                    ucContrato.Text = ""
                    ucSequencia.Text = ""
                    gridVeiculo.DataSource = Nothing
                    gridPrograma.DataSource = Nothing
                    gridComercial.DataSource = Nothing
                    ucEmpresa.Focus()
                Else
                    DrwContrato = dtsContrato.Tables(0).Rows(0)
                    ucPeriodoCampanha.Text = FormataData(DrwContrato.Item("Periodo_Campanha_Inicio").ToString()) & " a " & FormataData(DrwContrato.Item("Periodo_Campanha_Termino").ToString())
                    ucAgencia.Text = DrwContrato.Item("Cod_Agencia").ToString() & " - " & DrwContrato.Item("Nome_Agencia").ToString()
                    ucCliente.Text = DrwContrato.Item("Cod_Cliente").ToString() & " - " & DrwContrato.Item("Nome_Cliente").ToString()
                    Me.CarregaGridVeiculo()
                    Me.CarregaGridPrograma()
                    Me.CarregaGridComercial()
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
            strEmpresa = ucEmpresa.Text
            intContrato = ucContrato.DataNumberValue
            intSequencia = ucSequencia.DataNumberValue
        End Try
    End Sub


    Private Sub ucEmpresa_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ucEmpresa.Validating
        ValidaContrato()
    End Sub


    Private Sub ucContrato_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ucContrato.Validating
        ValidaContrato()
    End Sub


    Private Sub ucSequencia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ucSequencia.Validating
        ValidaContrato()
    End Sub
    Private Sub CarregaGridVeiculo()
        Try
            dtsVeiculo = clsChecking.fnBaixaContratoVeiculo(ucEmpresa.Text, ucContrato.DataNumberValue, ucSequencia.DataNumberValue)
            With gridVeiculo
                '.ReadOnly = True
                .AllowUserToResizeRows = False
                .AllowUserToAddRows = False
                .DataSource = dtsVeiculo.Tables(0)
                .RowHeadersVisible = False
                .Columns(.Columns("CheckVeiculo").Index).HeaderText = ""
                .Columns(.Columns("CheckVeiculo").Index).Width = 25
                .Columns(.Columns("CheckVeiculo").Index).ReadOnly = False

                .Columns(.Columns("Cod_Veiculo").Index).HeaderText = "Veículo"
                .Columns(.Columns("Cod_Veiculo").Index).Width = 50
                .Columns(.Columns("Cod_Veiculo").Index).ReadOnly = True

                .Columns(.Columns("Nome_Veiculo").Index).HeaderText = "Veículo"
                .Columns(.Columns("Nome_Veiculo").Index).Width = 275
                .Columns(.Columns("Nome_Veiculo").Index).ReadOnly = True



            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Private Sub CarregaGridPrograma()
        Try
            dtsPrograma = clsChecking.fnBaixaContratoPrograma(ucEmpresa.Text, ucContrato.DataNumberValue, ucSequencia.DataNumberValue)
            With gridPrograma
                .AllowUserToResizeRows = False
                .AllowUserToAddRows = False
                .DataSource = dtsPrograma.Tables(0)
                .RowHeadersVisible = False
                .Columns(.Columns("CheckPrograma").Index).HeaderText = ""
                .Columns(.Columns("CheckPrograma").Index).Width = 40
                .Columns(.Columns("CheckPrograma").Index).ReadOnly = False

                .Columns(.Columns("Cod_Programa").Index).HeaderText = "Programa"
                .Columns(.Columns("Cod_Programa").Index).Width = 50
                .Columns(.Columns("Cod_Programa").Index).ReadOnly = True

                .Columns(.Columns("Titulo").Index).HeaderText = "Titulo"
                .Columns(.Columns("Titulo").Index).Width = 260
                .Columns(.Columns("Titulo").Index).ReadOnly = True



            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Private Sub CarregaGridComercial()
        Try
            dtsComercial = clsChecking.fnBaixaContratoComercial(ucEmpresa.Text, ucContrato.DataNumberValue, ucSequencia.DataNumberValue)
            With gridComercial
                .AllowUserToResizeRows = False
                .AllowUserToAddRows = False
                .DataSource = dtsComercial.Tables(0)
                .RowHeadersVisible = False
                .Columns(.Columns("CheckComercial").Index).HeaderText = ""
                .Columns(.Columns("CheckComercial").Index).Width = 40
                .Columns(.Columns("CheckComercial").Index).ReadOnly = False

                .Columns(.Columns("Cod_Comercial").Index).HeaderText = "Legenda"
                .Columns(.Columns("Cod_Comercial").Index).Width = 55
                .Columns(.Columns("Cod_Comercial").Index).ReadOnly = True

                .Columns(.Columns("Titulo_Comercial").Index).HeaderText = "Titulo"
                .Columns(.Columns("Titulo_Comercial").Index).Width = 220
                .Columns(.Columns("Titulo_Comercial").Index).ReadOnly = True

                .Columns(.Columns("Duracao").Index).HeaderText = "Duração"
                .Columns(.Columns("Duracao").Index).Width = 50
                .Columns(.Columns("Duracao").Index).ReadOnly = True
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub

    Private Sub btnMarcar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        Try
            Select Case tabFiltro.SelectedIndex
                Case 0
                    For Each Row As DataGridViewRow In gridVeiculo.Rows
                        gridVeiculo.Item("CheckVeiculo", Row.Index).Value = True
                        gridVeiculo.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    Next
                Case 1
                    For Each Row As DataGridViewRow In gridPrograma.Rows
                        gridPrograma.Item("CheckPrograma", Row.Index).Value = True
                        gridPrograma.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    Next
                Case 2
                    For Each Row As DataGridViewRow In gridComercial.Rows
                        gridComercial.Item("CheckComercial", Row.Index).Value = True
                        gridComercial.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    Next

            End Select




        Catch ex As Exception

            ShowErro(ex)
        End Try
    End Sub

    Private Sub chkTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.Click
        Try
            chkDomingo.Checked = chkTodos.Checked
            chkSegunda.Checked = chkTodos.Checked
            chkTerca.Checked = chkTodos.Checked
            chkQuarta.Checked = chkTodos.Checked
            chkQuinta.Checked = chkTodos.Checked
            chkSexta.Checked = chkTodos.Checked
            chkSabado.Checked = chkTodos.Checked

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub


    Private Sub optCancelamento_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optCancelamento.CheckedChanged
        grpQualidade.Enabled = Not optCancelamento.Checked
        If optCancelamento.Checked Then
            ucQualidade.Text = strCodQualidadeCan
            ucQualidade.Descricao = "CANCELAMENTO DE CONTRATO"
        Else
            ucQualidade.Text = ""
            ucQualidade.Descricao = ""
        End If
        chkExcluirAm.Visible = optCancelamento.Checked
    End Sub

    Private Sub BaixaContrato()

        Dim sDia_Semana As String



        Dim strVeiculo As String = ""
        Dim strPrograma As String = ""
        Dim strComercial As String = ""
        Dim strMensagem As String
        Dim dtsRetorno As DataSet
        Dim dtDataDe As DateTime
        Dim dtDataAte As DateTime
        Try


            '=================================Consiste Data 

            If ucDataDe.DateTime = DateTime.MinValue Then
                'Aviso("Data In não pode ser vazia!")
                'Exit Try
                dtDataDe = DateTime.Parse("1900-01-01")
            End If
            If ucDataAte.DateTime = DateTime.MinValue Then
                'Aviso("Data In não pode ser vazia!")
                'Exit Try
                dtDataAte = DateTime.Parse("2100-12-31")
            End If


            '=================================Consiste Empresa 
            If ucEmpresa.Text.Trim = "" Then
                Aviso("Empresa do Contrato não pode ser vazio!")
                Exit Try
            End If

            '=================================Consiste Contrato 
            If ucContrato.Text.Trim = "" Then
                Aviso("Número do Contrato não pode ser vazio!")
                Exit Try
            End If

            '=================================Consiste Sequencia 
            If ucSequencia.Text.Trim = "" Then
                Aviso("Sequência do Contrato não pode ser vazio!")
                Exit Try
            End If

            '=================================Consiste Qualidade 
            If ucQualidade.Text.Trim = "" Then
                Aviso("Qualidade não pode ser vazio!")
                Exit Try
            End If

            If ucQualidade.Text.Trim.ToUpper = "VEI" Then
                Aviso("A qualidade [VEI] exige horário de exibição e nao pode ser utilizada nessa operação")
                Exit Try
            End If

            '=================================Consiste Dia da Semana 
            sDia_Semana = ","
            If chkDomingo.Checked Then sDia_Semana = sDia_Semana & "1,"
            If chkSegunda.Checked Then sDia_Semana = sDia_Semana & "2,"
            If chkTerca.Checked Then sDia_Semana = sDia_Semana & "3,"
            If chkQuarta.Checked Then sDia_Semana = sDia_Semana & "4,"
            If chkQuinta.Checked Then sDia_Semana = sDia_Semana & "5,"
            If chkSexta.Checked Then sDia_Semana = sDia_Semana & "6,"
            If chkSabado.Checked Then sDia_Semana = sDia_Semana & "7,"

            If sDia_Semana = "," Then
                Aviso("não foi selecionado nenhum dia da semana !")
                Exit Try
            End If

            '=================================Consiste Veiculos 
            strVeiculo = ""
            For Each Drw As DataGridViewRow In gridVeiculo.Rows
                If Drw.Cells("CheckVeiculo").Value = True Then
                    strVeiculo = strVeiculo & Drw.Cells("Cod_Veiculo").Value.ToString() & ","
                End If
            Next

            If strVeiculo = "" Then
                Aviso("Nenhum Veiculo foi Selecionado !")
                Exit Try
            End If

            '=================================Consiste Programas 
            strPrograma = ""
            For Each Drw As DataGridViewRow In gridPrograma.Rows
                If Drw.Cells("CheckPrograma").Value = True Then
                    strPrograma = strPrograma & Drw.Cells("Cod_Programa").Value.ToString() & ","
                End If
            Next

            If strPrograma = "" Then
                Aviso("Nenhum Programa foi Selecionado !")
                Exit Try
            End If

            '=================================Consiste Comercial 

            strComercial = ""
            For Each Drw As DataGridViewRow In gridComercial.Rows
                If Drw.Cells("CheckComercial").Value = True Then
                    strComercial = strComercial & Drw.Cells("Cod_Comercial").Value.ToString() & ","
                End If
            Next

            If strComercial = "" Then
                Aviso("Nenhum Comercial foi Selecionado !")
                Exit Try
            End If

            Me.Cursor = Cursors.WaitCursor
            Mensagem("Aguarde... Selecionando Veículos.")

            '=================================Consiste se esta faturado 
            If optCancelamento.Checked Then
                If dtsContrato.Tables(0).Rows(0).Item("Vlr_Faturado") > 0 Then
                    Aviso("Contrato Já Faturado. Cancelamento não Permitido")
                    Exit Try
                End If
            End If


            '=================================Executa Processo da Baixa 
            dtDataDe = ucDataDe.DateTime
            dtDataAte = ucDataAte.DateTime

            dtsRetorno = clsChecking.fnBaixaContratoExecutar(ucEmpresa.Text, _
                                                                ucContrato.DataNumberValue, _
                                                                ucSequencia.DataNumberValue, _
                                                                dtDataDe, _
                                                                dtDataAte, _
                                                                ucQualidade.Text, _
                                                                strVeiculo, _
                                                                strPrograma, _
                                                                strComercial, _
                                                                sDia_Semana, _
                                                                Now, _
                                                                gsUsuario, _
                                                                optCancelamento.Checked, _
                                                                chkExcluirAm.Checked, _
                                                                txtMotivoBaixa.Text)

            strMensagem = "Foram Baixadas " & dtsRetorno.Tables(0).Rows(0).Item("Qtd_Baixa").ToString() & vbCrLf
            strMensagem += "Foram Rejeitadas " & dtsRetorno.Tables(0).Rows(0).Item("Qtd_Rejeitado").ToString() & vbCrLf
            Aviso(strMensagem)
            dtsRetorno = Nothing

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default


        End Try

    End Sub

    Private Sub ucOkCancel_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucOkCancel.Cancel_Click
        Me.Close()
    End Sub


    Private Sub ucOkCancel_Ok_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucOkCancel.Ok_Click
        Me.BaixaContrato()
    End Sub

    Private Sub optBaixa_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optBaixa.CheckedChanged
        If optBaixa.Checked Then
            chkExcluirAm.Checked = False
            chkExcluirAm.Visible = False
        End If

    End Sub
End Class