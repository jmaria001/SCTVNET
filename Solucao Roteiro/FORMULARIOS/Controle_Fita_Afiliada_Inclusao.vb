Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmControle_Fita_Afiliada_Inclusao
	Inherits System.Windows.Forms.Form
	Dim sTipo_Fita As String
	Dim sTabela_Depositorio As String
    Dim nCont As Short
    Dim strCodVeiculo As String
    Dim asmxControleFita As MSAClass.AsmxControleFita.asmxControleFita = NewControleFita()
    Dim dtsDadosFita As New MSAClass.AsmxControleFita.dtsDadosFita
    Dim asmxVeiculo As MSAClass.AsmxVeiculo.asmxVeiculo = NewVeiculo()
    Dim asmxProduto As MSAClass.AsmxProduto.asmxProduto = NewProduto()
	
    Private Sub Carrega_Dados()



        On Error GoTo Erro
        If Not chkLoad.Checked Then GoTo saida

        Dim sTipoFita As String
        Me.Cursor = Cursors.WaitCursor

        asmxControleFita = NewControleFita()
        Dim drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaArtisticoRow
        Dim drw2 As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaAvulsoRow

        UcDataInicio.Text = ""
        UcDataFinal.Text = ""
        txtQtde.Text = ""
        txtDuracao.Text = ""
        txtTitulo_Comercial.Text = ""
        txtNumero_Fita.Text = ""


        With frmControleFita_Afiliada.flxFita
            strCodVeiculo = .get_TextMatrix(.Row, 14)
        End With

        If sTipo_Fita = "AR" Then

            Me.DtsDadosFita.dtbDadosFitaArtistico.Clear()
            Me.DtsDadosFita = AsmxControleFita.spuDadosComercialArtistico(strCodVeiculo, txtId_chave.Text)

            If Me.DtsDadosFita.dtbDadosFitaArtistico.Count = 0 Then
                GoTo Saida
            End If

            drw = Me.DtsDadosFita.dtbDadosFitaArtistico(0)
            UcDataInicio.DateTime = drw.Data_Inicio
            UcDataFinal.DateTime = drw.Data_Final
            txtQtde.Text = drw.Qtde
            txtDuracao.Text = drw.Duracao.ToString("##")
            txtTitulo_Comercial.Text = drw.Titulo_Comercial.Trim
            UcTipoComercial.Text = drw.Cod_Tipo_Comercial.Trim
            txtNumero_Fita.Text = drw.Numero_Fita.Trim
            If Not drw.IsCod_Red_ProdutoNull Then
                ucProduto.Text = drw.Cod_Red_Produto
            Else
                ucProduto.Text = ""
            End If

            If Not drw.IsCod_ProgramaNull Then
                ucPrograma.Text = drw.Cod_Programa.Trim
            Else
                ucPrograma.Text = ""
            End If
            If chkArtistico.Checked Then
                If Not drw.IsCod_Programa_ArNull Then
                    ucPrograma2.Text = drw.Cod_Programa_Ar
                End If
            Else
                ucPrograma2.Text = ""
            End If
            If Not drw.IsObservacaoNull Then
                txtObservacao.Text = drw.Observacao
            End If
            txtData_Inicio.Tag = drw.Data_Inicio
            txtData_Final.Tag = drw.Data_Final


            chkDomingo.Checked = Vernulo(drw.Indica_Dom, False)
            chkSegunda.Checked = Vernulo(drw.Indica_Seg, False)
            chkTerca.Checked = Vernulo(drw.Indica_Ter, False)
            chkQuarta.Checked = Vernulo(drw.Indica_Qua, False)
            chkQuinta.Checked = Vernulo(drw.Indica_Qui, False)
            chkSexta.Checked = Vernulo(drw.Indica_Sex, False)
            chkSabado.Checked = Vernulo(drw.Indica_Sab, False)

        ElseIf sTipo_Fita = "CO" Then

            Me.DtsDadosFita.dtbDadosFitaArtistico.Clear()
            Me.DtsDadosFita.Clear()

            Me.DtsDadosFita = AsmxControleFita.spuDadosComercialAvulso(strCodVeiculo, txtId_chave.Text)

            If Me.DtsDadosFita.dtbDadosFitaAvulso.Count = 0 Then
                GoTo Saida
            End If

            drw2 = Me.DtsDadosFita.dtbDadosFitaAvulso(0)

            UcDataInicio.DateTime = drw2.Data_Inicio
            UcDataFinal.DateTime = drw2.Data_Final
            txtQtde.Text = drw2.Qtde
            txtDuracao.Text = Integer.Parse(drw2.Duracao.ToString("##"))
            txtTitulo_Comercial.Text = drw2.Titulo_Comercial.Trim
            txtNumero_Fita.Text = drw2.Numero_Fita.Trim
            txtId_chave.Text = drw2.IdChave
            If Not drw2.IsCod_Red_ProdutoNull Then
                ucProduto.Text = drw2.Cod_Red_Produto
            Else
                ucProduto.Text = ""
            End If

            If Not drw2.IsCod_ProgramaNull Then
                ucPrograma.Text = drw2.Cod_Programa
            Else
                ucPrograma.Text = ""
            End If

            UcTipoComercial.Text = drw2.Cod_Tipo_Comercial
            If Not drw2.IsObservacaoNull Then
                txtObservacao.Text = drw2.Observacao
            End If
            txtData_Inicio.Tag = drw2.Data_Inicio
            txtData_Final.Tag = drw2.Data_Final


            For nCont = 0 To lstVeiculo.Items.Count - 1
                If VB6.Format(VB6.GetItemData(lstVeiculo, nCont), "000") = drw2.Cod_Veiculo Then
                    lstVeiculo.SetSelected(nCont, True)
                End If
            Next nCont
            For nCont = lstVeiculo.Items.Count - 1 To 0 Step -1
                If Not lstVeiculo.GetSelected(nCont) Then
                    lstVeiculo.Items.RemoveAt((nCont))
                End If
            Next nCont


            chkDomingo.Checked = Vernulo(drw2.Indica_Dom, False)
            chkSegunda.Checked = Vernulo(drw2.Indica_Seg, False)
            chkTerca.Checked = Vernulo(drw2.Indica_Ter, False)
            chkQuarta.Checked = Vernulo(drw2.Indica_Qua, False)
            chkQuinta.Checked = Vernulo(drw2.Indica_Qui, False)
            chkSexta.Checked = Vernulo(drw2.Indica_Sex, False)
            chkSabado.Checked = Vernulo(drw2.Indica_Sab, False)

        End If

Saida:
            Me.Cursor = Cursors.Default
            Exit Sub

Erro:
            If Err.Number <> 0 Then Erro(Err.Number)
            GoTo Saida
            Resume

    End Sub
    Private Function Consiste_Campos() As Boolean

        On Error GoTo Erro

        Consiste_Campos = True
        Dim bVeiculo As Boolean
        bVeiculo = False

        If Trim(txtNumero_Fita.Text) = "" Then
            Aviso("Número da Fita não Pode Ficar em Branco.")
            txtNumero_Fita.Focus()
            Consiste_Campos = False
            GoTo Saida
        End If

        If UcDataInicio.Text = "" Then
            Aviso("Data Inicial não Pode Ficar em Branco.")
            UcDataInicio.Focus()
            Consiste_Campos = False
            GoTo Saida
        End If

        If UcDataFinal.Text = "" Then
            Aviso("Data Final não Pode Ficar em Branco.")
            UcDataFinal.Focus()
            Consiste_Campos = False
            GoTo Saida
        End If

        If Trim(txtQtde.Text) = "" Or Trim(txtQtde.Text) = "0" Then
            Aviso("Quantidade Deve ser Maior que 0.")
            txtQtde.Focus()
            Consiste_Campos = False
            GoTo Saida
        End If


        If Trim(txtTitulo_Comercial.Text) = "" Then
            Aviso("Título não Pode Ficar em Branco.")
            txtTitulo_Comercial.Focus()
            Consiste_Campos = False
            GoTo Saida
        End If


        If Trim(txtDuracao.Text) = "" Or Trim(txtDuracao.Text) = "0" Then
            Aviso("Duração Deve ser Maior que 0.")
            txtDuracao.Focus()
            Consiste_Campos = False
            GoTo Saida
        End If


        If Trim(UcTipoComercial.Text) = "" Then
            Aviso("Tipo Comercial não Pode Ficar em Branco.")
            UcTipoComercial.Focus()
            Consiste_Campos = False
            GoTo Saida
        End If

        For nCont = 0 To lstVeiculo.Items.Count - 1
            If lstVeiculo.GetSelected(nCont) Then
                bVeiculo = True
                Exit For
            End If
        Next nCont

        If Not bVeiculo Then
            Aviso("Nenhum Veículo foi selecionado")
            Consiste_Campos = False
            GoTo Saida
        End If
Saida:
        Exit Function

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Function
    Sub Limpa_Dados()
        On Error GoTo Erro
        ucPrograma.Text = ""
        ucPrograma2.Text = ""
        strCodVeiculo = ""
        UcTipoComercial.Text = ""
        lstVeiculo.ClearSelected()


        UcDataFinal.Text = ""
        txtData_Final.Text = ""
        txtData_Final.Tag = ""

        UcDataInicio.Text = ""

        txtData_Inicio.Tag = ""
        txtData_Inicio.Text = ""

        txtDuracao.Text = ""
        txtNumero_Fita.Text = ""
        txtObservacao.Text = ""

        txtQtde.Text = ""
        txtTitulo_Comercial.Text = ""
        UcTipoComercial.Text = ""
        txtNumero_Fita.Focus()

        chkDomingo.Checked = False
        chkSegunda.Checked = False
        chkTerca.Checked = False
        chkQuarta.Checked = False
        chkQuinta.Checked = False
        chkSexta.Checked = False
        chkSabado.Checked = False

saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume saida
        Resume
    End Sub
    Private Sub chkAlteracao_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAlteracao.CheckStateChanged
        If chkAlteracao.Checked Then
            Call Carrega_Dados()
        End If
        txtNumero_Fita.Enabled = False
        fraVeiculo.Enabled = False
        cmdDisponivel.Visible = False
        If chkArtistico.Checked Then
            ucPrograma2.Enabled = True
        Else
            ucPrograma2.Enabled = False
        End If
    End Sub
    Private Sub chkArtistico_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkArtistico.CheckStateChanged
        If chkArtistico.Checked Then
            sTipo_Fita = "AR"
        End If
    End Sub
    Private Sub chkAvulso_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAvulso.CheckStateChanged
        If chkAvulso.Checked Then
            sTipo_Fita = "CO"
            ucPrograma2.Enabled = False
        End If

    End Sub
    Private Sub chkTodos_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTodos.CheckStateChanged
        On Error GoTo Erro
        chkDomingo.Checked = chkTodos.Checked
        chkSegunda.Checked = chkTodos.Checked
        chkTerca.Checked = chkTodos.Checked
        chkQuarta.Checked = chkTodos.Checked
        chkQuinta.Checked = chkTodos.Checked
        chkSexta.Checked = chkTodos.Checked
        chkSabado.Checked = chkTodos.Checked

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Private Sub chkVeiculo_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkVeiculo.CheckedChanged
        On Error GoTo Erro
        Dim nLoop As Short
        With lstVeiculo
            For nLoop = 0 To .Items.Count - 1
                .SetItemChecked(nLoop, chkVeiculo.Checked)
            Next nLoop

        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub
    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Call Limpa_Dados()
        Me.Dispose()


    End Sub
    Private Sub cmdDisponivel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDisponivel.Click
        On Error GoTo Erro
        Dim aParam(3) As Object
        Dim aTipos(3) As Object
        Dim sVeiculo As String = ""
        Dim strRetorno As String = ""
        Dim stipo As Short

        Me.Cursor = Cursors.WaitCursor

        For nCont = 0 To lstVeiculo.Items.Count - 1
        Next



        'For Each xx As CheckedListBox.CheckedItemCollection In lstVeiculo.CheckedItems
        For Each xx As String In lstVeiculo.CheckedItems()
            sVeiculo = sVeiculo & xx.Substring(0, 3)
        Next


        If sVeiculo = "" Then
            Aviso("Para utilizar numeração automática, primeiro selecione um veiculo")
            GoTo Saida
        End If

        If Len(sVeiculo) > 3 Then
            Aviso("Numeração automática somente é permitida quando selecionado apenas um veiculo")
            GoTo Saida
        End If


        stipo = IIf(chkAvulso.Checked, 0, 1)

        strRetorno = AsmxControleFita.spuFitaDisponivel(sVeiculo, _
                                                        1, _
                                                        9999, _
                                                        stipo, _
                                                        gsUsuario, _
                                                        -1)




        If strRetorno = "" Then
            Aviso("Nenhum número disponivel foi encontrado")
            GoTo Saida
        End If


        txtNumero_Fita.Text = strRetorno
        Me.Cursor = Cursors.Default

Saida:
        Dim cls As MSAClass.AsmxControleFita.asmxControleFita = NewControleFita()
        cls.spuDeletarReserva(gsUsuario)
        Me.Cursor = Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Private Sub CmdFechar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFechar.Click

        pctObservacao.Visible = False
        cmdCancela.Enabled = True
        cmdOk.Enabled = True
        fraDados.BringToFront()
        fraDados.Enabled = True

    End Sub
    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click

        On Error GoTo Erro

        Dim aColunas() As String
        Dim aValores() As String
        Dim sPrograma_Ar As String = ""
        Dim sProduto As Integer
        Dim sProduto_Descricao As String = ""
        Dim sTipo_Comercial As String = ""
        Dim sTipo_Comercial_Descricao As String = ""
        Dim Indica_Dom As Byte
        Dim Indica_Seg As Byte
        Dim Indica_Ter As Byte
        Dim Indica_Qua As Byte
        Dim Indica_Qui As Byte
        Dim Indica_Sex As Byte
        Dim Indica_Sab As Byte
        Dim i As Integer

        If Not Consiste_Campos() Then
            GoTo Saida
        End If

        If chkInclusao.CheckState = 1 Then

            'If Not Consiste_Fita() Then
            '    GoTo Saida
            'End If

            If sTipo_Fita = "AR" Then

                If ucPrograma2.Text = "" Then
                    sPrograma_Ar = ""
                Else

                    sPrograma_Ar = ucPrograma2.Text
                End If

                If ucProduto.Text = "" Then
                    sProduto = -1
                    sProduto_Descricao = ""
                Else
                    sProduto = Integer.Parse(ucProduto.DataNumberValue)
                    sProduto_Descricao = ucProduto.Descricao
                End If

                If UcTipoComercial.Text = "" Then
                    sTipo_Comercial = ""
                    sTipo_Comercial_Descricao = ""
                Else
                    sTipo_Comercial = UcTipoComercial.Text
                    sTipo_Comercial_Descricao = UcTipoComercial.Descricao
                End If
                Me.DtsDadosFita.Clear()

                'For i = 0 To lstVeiculo.SelectedItems.Count - 1
                For Each xx As String In lstVeiculo.CheckedItems()

                    Me.DtsDadosFita.dtbDadosFitaArtistico.AdddtbDadosFitaArtisticoRow(txtTitulo_Comercial.Text, _
                                                                                    txtDuracao.Text, _
                                                                                    sTipo_Comercial, _
                                                                                    txtNumero_Fita.Text, _
                                                                                    txtObservacao.Text, _
                                                                                    UcDataInicio.DateTime, _
                                                                                    UcDataFinal.DateTime, _
                                                                                    txtQtde.Text, _
                                                                                    ucPrograma.Text, _
                                                                                    sPrograma_Ar, _
                                                                                    Byte.Parse(CStr(chkdomingo.CheckState)), _
                                                                                    Byte.Parse(CStr(chksegunda.CheckState)), _
                                                                                    Byte.Parse(CStr(chkterca.CheckState)), _
                                                                                    Byte.Parse(CStr(chkquarta.CheckState)), _
                                                                                    Byte.Parse(CStr(chkquinta.CheckState)), _
                                                                                    Byte.Parse(CStr(chksexta.CheckState)), _
                                                                                    Byte.Parse(CStr(chksabado.CheckState)), _
                                                                                    sProduto, _
                                                                                    sProduto_Descricao, _
                                                                                    sTipo_Comercial_Descricao, _
                                                                                    xx.Substring(0, 3), _
                                                                                    -1, _
                                                                                    txtQtde.Text, _
                                                                                    0)



                Next

                AsmxControleFita.spuAtualizar_FitaArtistico(Me.DtsDadosFita)

                Aviso("Fita Incluida com Sucesso.")

                Call Limpa_Dados()
            End If

            If sTipo_Fita = "CO" Then


                If ucPrograma2.Text = "" Then
                    sPrograma_Ar = ""
                Else

                    sPrograma_Ar = ucPrograma2.Text
                End If

                If ucProduto.Text = "" Then
                    sProduto = -1
                    sProduto_Descricao = ""
                Else
                    sProduto = Integer.Parse(ucProduto.DataNumberValue)
                    sProduto_Descricao = ucProduto.Descricao
                End If

                If UcTipoComercial.Text = "" Then
                    sTipo_Comercial = ""
                    sTipo_Comercial_Descricao = ""
                Else
                    sTipo_Comercial = UcTipoComercial.Text
                    sTipo_Comercial_Descricao = UcTipoComercial.Descricao
                End If

                Me.DtsDadosFita.Clear()

                'For i = 0 To lstVeiculo.SelectedItems.Count - 1
                For Each xx As String In lstVeiculo.CheckedItems()
                    Me.DtsDadosFita.dtbDadosFitaAvulso.AdddtbDadosFitaAvulsoRow(txtTitulo_Comercial.Text.Trim, _
                                                                                    Decimal.Parse(txtDuracao.Text), _
                                                                                    sTipo_Comercial.Trim, _
                                                                                    txtNumero_Fita.Text, _
                                                                                    txtObservacao.Text, _
                                                                                    UcDataInicio.DateTime, _
                                                                                    UcDataFinal.DateTime, _
                                                                                    txtQtde.Text, _
                                                                                    ucPrograma.Text, _
                                                                                    Byte.Parse(CStr(chkdomingo.CheckState)), _
                                                                                    Byte.Parse(CStr(chksegunda.CheckState)), _
                                                                                    Byte.Parse(CStr(chkterca.CheckState)), _
                                                                                    Byte.Parse(CStr(chkquarta.CheckState)), _
                                                                                    Byte.Parse(CStr(chkquinta.CheckState)), _
                                                                                    Byte.Parse(CStr(chksexta.CheckState)), _
                                                                                    Byte.Parse(CStr(chksabado.CheckState)), _
                                                                                    sProduto, _
                                                                                    sProduto_Descricao, _
                                                                                    sTipo_Comercial_Descricao, _
                                                                                    xx.Substring(0, 3), _
                                                                                    -1, _
                                                                                    txtQtde.Text, _
                                                                                    0)

                Next



                AsmxControleFita.spuAtualizar_FitaAvulso(Me.DtsDadosFita)
                Aviso("Fita Incluída com Sucesso.")

                Call Limpa_Dados()
            End If





        ElseIf chkAlteracao.CheckState = 1 Then

            If sTipo_Fita = "AR" Then
                Dim drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaArtisticoRow

                drw = Me.DtsDadosFita.dtbDadosFitaArtistico(0)
                'If Not Consiste_Fita() Then
                '    GoTo Saida
                'End If


                If ucProduto.Text = "" Then
                    sProduto = -1
                    sProduto_Descricao = ""
                Else
                    sProduto = Integer.Parse(ucProduto.DataNumberValue)
                    sProduto_Descricao = ucProduto.Descricao
                End If

                drw.Data_Inicio = UcDataInicio.DateTime
                drw.Data_Final = UcDataFinal.DateTime
                drw.Cod_Tipo_Comercial = UcTipoComercial.Text
                drw.Descricao_Tipo_Comercial = UcTipoComercial.Descricao
                drw.Titulo_Comercial = txtTitulo_Comercial.Text
                drw.Duracao = txtDuracao.Text
                drw.Cod_Programa = ucPrograma.Text
                drw.Qtde = Integer.Parse(txtQtde.Text)
                drw.Cod_Red_Produto = Integer.Parse(sProduto)
                drw.Descricao_Produto = sProduto_Descricao
                drw.Saldo = Integer.Parse(txtQtde.Text)
                drw.Indica_Desativado = 0


                For nCont = 0 To lstVeiculo.Items.Count - 1

                    If lstVeiculo.GetSelected(nCont) Then
                        drw.Cod_Veiculo = lstVeiculo.Items.Item(nCont).ToString.Substring(0, 3)
                        Exit For
                    End If
                Next nCont
                Indica_Dom = CStr(chkDomingo.CheckState)
                Indica_Seg = CStr(chkSegunda.CheckState)
                Indica_Ter = CStr(chkTerca.CheckState)
                Indica_Qua = CStr(chkQuarta.CheckState)
                Indica_Qui = CStr(chkQuinta.CheckState)
                Indica_Sex = CStr(chkSexta.CheckState)
                Indica_Sab = CStr(chkSabado.CheckState)

                drw.Indica_Dom = Indica_Dom
                drw.Indica_Seg = Indica_Ter
                drw.Indica_Ter = Indica_Ter
                drw.Indica_Qua = Indica_Qua
                drw.Indica_Qui = Indica_Qui
                drw.Indica_Sex = Indica_Sex
                drw.Indica_Sab = Indica_Sab

                drw.Observacao = txtObservacao.Text
                drw.Cod_Programa_Ar = ucPrograma2.Text

                AsmxControleFita.spuAtualizar_FitaArtistico(Me.DtsDadosFita)

                Aviso("Fita Alterada com Sucesso.")

                Call Limpa_Dados()

            End If

            If sTipo_Fita = "CO" Then
                Dim drw As MSAClass.AsmxControleFita.dtsDadosFita.dtbDadosFitaAvulsoRow

                drw = Me.DtsDadosFita.dtbDadosFitaAvulso(0)
                'If Not Consiste_Fita() Then
                '    GoTo Saida
                'End If


                If ucProduto.Text = "" Then
                    sProduto = -1
                    sProduto_Descricao = ""
                Else
                    sProduto = Integer.Parse(ucProduto.Text)
                    sProduto_Descricao = ucProduto.Descricao
                End If

                drw.Data_Inicio = UcDataInicio.DateTime
                drw.Data_Final = UcDataFinal.DateTime
                drw.Cod_Tipo_Comercial = UcTipoComercial.Text
                drw.Descricao_Tipo_Comercial = UcTipoComercial.Descricao
                drw.Titulo_Comercial = txtTitulo_Comercial.Text
                drw.Duracao = txtDuracao.Text
                drw.Cod_Programa = ucPrograma.Text
                drw.Qtde = Integer.Parse(txtQtde.Text)
                drw.Cod_Red_Produto = Integer.Parse(sProduto)
                drw.Descricao_Produto = sProduto_Descricao
                drw.Saldo = Integer.Parse(txtQtde.Text)
                drw.Indica_Desativado = 0
                drw.IdChave = txtId_chave.Text
                For nCont = 0 To lstVeiculo.Items.Count - 1
                    If lstVeiculo.GetSelected(nCont) Then
                        drw.Cod_Veiculo = lstVeiculo.Items.Item(nCont).ToString.Substring(0, 3)
                        Exit For
                    End If
                Next nCont
                drw.Observacao = txtObservacao.Text
                Indica_Dom = CStr(chkDomingo.CheckState)
                Indica_Seg = CStr(chkSegunda.CheckState)
                Indica_Ter = CStr(chkTerca.CheckState)
                Indica_Qua = CStr(chkQuarta.CheckState)
                Indica_Qui = CStr(chkQuinta.CheckState)
                Indica_Sex = CStr(chkSexta.CheckState)
                Indica_Sab = CStr(chkSabado.CheckState)

                drw.Indica_Dom = Indica_Dom
                drw.Indica_Seg = Indica_Ter
                drw.Indica_Ter = Indica_Ter
                drw.Indica_Qua = Indica_Qua
                drw.Indica_Qui = Indica_Qui
                drw.Indica_Sex = Indica_Sex
                drw.Indica_Sab = Indica_Sab

                AsmxControleFita.spuAtualizar_FitaAvulso(Me.DtsDadosFita)

                Aviso("Fita Alterada com Sucesso.")

                Call Limpa_Dados()

            End If

        End If

        Me.Dispose()

Saida:

        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        Resume Saida
        Resume
        Resume

    End Sub
    Private Sub frmControle_Fita_Afiliada_Inclusao_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lstVeiculo.Visible = True
        lstVeiculo.BringToFront()
    End Sub
    Private Sub frmControle_Fita_Afiliada_Inclusao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        chkLoad.Checked = False
        'Me.Dispose(True)
        Me.Limpa_Dados()
    End Sub
    Private Sub frmControle_Fita_Afiliada_Inclusao_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{TAB}")
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub frmControle_Fita_Afiliada_Inclusao_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub
    Private Sub frmControle_Fita_Afiliada_Inclusao_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        On Error GoTo erro
        SetaUserControl(Me)

        ucPrograma.Caption = "Exibir somente no programa"
        ucPrograma2.Caption = "Exibir somente antes do programa"


        asmxControleFita = NewControleFita()
        asmxVeiculo = NewVeiculo()
        asmxProduto = NewProduto()

        Me.Cursor = Cursors.WaitCursor
        Call CarregaListVeiculo()



        If chkAlteracao.Checked Then

            With frmControleFita_Afiliada.flxFita
                strCodVeiculo = .get_TextMatrix(.Row, 14)
            End With

            For i As Integer = 0 To lstVeiculo.Items.Count - 1
                If lstVeiculo.Items.Item(i).ToString.Substring(0, 3) = strCodVeiculo Then
                    lstVeiculo.SetItemChecked(i, True)
                    lstVeiculo.SetSelected(i, True)
                    Exit For
                End If
            Next
        End If


        Me.Top = 0
        Me.Left = 0
        chkLoad.Checked = True
        If chkArtistico.Checked Then Call chkArtistico_CheckStateChanged(Me, New EventArgs)
        If chkAvulso.Checked Then Call chkArtistico_CheckStateChanged(Me, New EventArgs)
        If chkAlteracao.Checked Then Call chkAlteracao_CheckStateChanged(Me, New EventArgs)
        If chkInclusao.Checked Then Call chkInclusao_CheckedChanged(Me, New EventArgs)

saida:
        Me.Cursor = Cursors.Default
        Exit Sub
erro:
        Erro(Err.Number)
        Resume saida

    End Sub
    Private Sub CarregaListVeiculo()
        On Error GoTo Erro

        'lstVeiculo.DataSource = mdiPrincipal.DtsUsuario.dtbUsuario_Veiculo
        With lstVeiculo
            .Items.Clear()
            For Each drw As MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow In mdiPrincipal.DtsUsuario.dtbUsuario_Veiculo.Rows
                .Items.Add(drw.Descricao)
            Next

        End With
Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Private Sub imgObservacao_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles pctObservacao.DoubleClick

        pctObservacao.BringToFront()
        pctObservacao.Left = VB6.TwipsToPixelsX(860)
        pctObservacao.Top = VB6.TwipsToPixelsY(740)
        cmdCancela.Enabled = False
        cmdOk.Enabled = False
        pctObservacao.Visible = True
        fraDados.Enabled = False

    End Sub
    Private Sub txtDuracao_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDuracao.Enter
        seleciona_no_foco(txtDuracao)
    End Sub
    Private Sub txtDuracao_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDuracao.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 And KeyAscii <> 44 Then KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtNumero_Fita_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNumero_Fita.Enter
        seleciona_no_foco(txtNumero_Fita)
    End Sub
    Private Sub txtNumero_Fita_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero_Fita.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 Then KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtNumero_Fita_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtNumero_Fita.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro
        If txtNumero_Fita.Text = "" Then GoTo EventExitSub
        If txtNumero_Fita.Text.Length < 2 Then txtNumero_Fita.Text = StrZero(txtNumero_Fita.Text, 2)
        If txtNumero_Fita.Text.ToString.Substring(0, 2) = "CO" Or _
             txtNumero_Fita.Text.ToString.Substring(0, 2) = "AR" Then GoTo EventExitSub
        If sTipo_Fita = "CO" Then
            txtNumero_Fita.Text = "CO" & VB6.Format(txtNumero_Fita.Text, "0000")
        ElseIf sTipo_Fita = "AR" Then
            txtNumero_Fita.Text = "AR" & VB6.Format(txtNumero_Fita.Text, "0000")
        End If
Saida:

        GoTo EventExitSub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume
EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub
    Private Sub txtQtde_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQtde.Enter
        seleciona_no_foco(txtQtde)
    End Sub
    Private Sub txtQtde_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 8 Then KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub frmControle_Fita_Afiliada_Inclusao_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.CenterToParent()
    End Sub
    Private Sub chkInclusao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInclusao.CheckedChanged
        txtNumero_Fita.Enabled = True
        'cmdDisponivel.Visible = True
        Call Limpa_Dados()
        If chkArtistico.Checked Then
            ucPrograma2.Enabled = True
        Else
            ucPrograma2.Enabled = False
        End If

    End Sub
    Private Sub chkLoad_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLoad.CheckedChanged
    End Sub

End Class