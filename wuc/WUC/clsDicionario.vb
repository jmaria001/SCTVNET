Public Class clsDicionario
    Enum enuDicionario
        Nenhum
        Empresa
        Comercial
        Contato
        Caracteristica_Contrato
        Genero
        Produto
        Programa_Codigo
        Qualidade
        Nucleo
        Mercado
        Segmento
        Setor
        Terceiro_Codigo
        Terceiro_Funcao
        Terceiro_Ramo_Atividade
        Tipo_Comercial
        Tipo_de_Midia
        UF_Codigo
        Veiculo_Codigo
        Abrangencia
        Programa_Grade
        Empresa_Filtro_Historico
        Veiculo_Todos
        Programa_Patrocinado
    End Enum
    Public Sub ConfiguraDicionario(ByVal Uc As UcText)
        Try
            Select Case Uc.pDicionario
                Case enuDicionario.Genero
                    Uc.sqlQuery = "execute PrNet_Genero_L "
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.MaxLength = 4
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Gênero"

                Case enuDicionario.Programa_Grade
                    Uc.sqlQuery = "execute PrNet_Programa_Grade '" & Uc.Veiculo & "','" & Format(Uc.DataInicio, "yyyy-MM-dd") & "','" & Format(Uc.DataFim, "yyyy-MM-dd") & "',NULL"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.MaxLength = 4
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Programa"
                Case enuDicionario.Abrangencia
                    Uc.sqlQuery = "execute PrNet_Abrangencia_L"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Numero
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Abrangência"
                Case enuDicionario.Qualidade
                    Uc.MaxLength = 3
                    Uc.sqlQuery = "execute PrNet_Qualidade_L"
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Qualidade"

                Case enuDicionario.Comercial
                    Uc.MaxLength = 2
                    Uc.sqlQuery = " execute prNet_Comercial_L '" & Uc.Cod_Empresa & "'," & Uc.Contrato & "," & Uc.Seq
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Comercial"

                Case enuDicionario.Programa_Codigo
                    Uc.MaxLength = 4
                    Uc.sqlQuery = "Execute prNet_Programa_L"
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Programa"

                Case enuDicionario.Caracteristica_Contrato
                    Uc.MaxLength = 3
                    Uc.sqlQuery = "Execute prNet_Carac_Contrato_L"
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.Caption = "Característica do Contrato"

                Case enuDicionario.Mercado
                    Uc.MaxLength = 5
                    Uc.sqlQuery = "Execute prNet_Mercado_L"
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto

                Case enuDicionario.Tipo_Comercial
                    Uc.MaxLength = 2
                    Uc.sqlQuery = "Execute prNet_Tipo_Comercial_L"
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto

                Case enuDicionario.Terceiro_Codigo
                    Uc.MaxLength = 6
                    'Uc.sqlQuery = "Execute prNet_Terceiro_L Null, '" & Uc.Usuario & "'"
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto

                Case enuDicionario.Terceiro_Ramo_Atividade
                    Uc.MaxLength = 2
                    Uc.sqlQuery = "Execute prNet_Ramo_Atividade_L"
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Ramo de Atividade"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Numero

                Case enuDicionario.Empresa
                    Uc.MaxLength = 3
                    Uc.sqlQuery = "Execute PrNet_Empresa_L  Null,'" & Uc.Usuario & "'"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    'Uc.Caption = "Empresa"
                Case enuDicionario.Empresa_Filtro_Historico
                    Uc.MaxLength = 3
                    Uc.sqlQuery = "Execute PrNet_Empresa_Historico_Mr_L  Null,'" & Uc.Usuario & "'"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    'Uc.Caption = "Empresa"
                Case enuDicionario.Programa_Patrocinado
                    Uc.MaxLength = 4
                    Uc.sqlQuery = "Execute PrNet_Programa_Patrocinado_S " & Uc.Competencia & ",'" & Uc.Usuario & "'"
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Programa Patrocinado"

                Case enuDicionario.UF_Codigo
                    Uc.MaxLength = 2
                    Uc.sqlQuery = "Execute  PrNet_UF_L"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = False
                    Uc.showButton = True
                    Uc.Caption = "UF"

                Case enuDicionario.Terceiro_Funcao
                    Uc.MaxLength = 2
                    Uc.sqlQuery = "Execute PrNet_terceiro_funcao_L"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Numero
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.ShowDescricao = True
                    Uc.Caption = "Função"
                Case enuDicionario.Setor
                    Uc.sqlQuery = "Execute PrNet_Produto_L null,1"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Numero
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Setor"
                    Uc.MaxLength = 6
                Case enuDicionario.Segmento
                    'Uc.sqlQuery = "Execute PrNet_Produto_L null,2"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Numero
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Segmento"
                    Uc.MaxLength = 6
                Case enuDicionario.Produto
                    'Uc.sqlQuery = Uc.sqlQuery = " ExecutePrNet_Produto_L null,3"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Numero
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Produto"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Numero
                    Uc.MaxLength = 6
                Case enuDicionario.Contato
                    Uc.sqlQuery = "Execute prNet_Contato_L Null,'" & Uc.Usuario & "'"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Contato"
                    Uc.MaxLength = 6
                Case enuDicionario.Nucleo
                    Uc.sqlQuery = "Execute PrNet_Nucleo_L"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Nucleo"
                    Uc.MaxLength = 6
                Case enuDicionario.Tipo_de_Midia
                    Uc.sqlQuery = "Execute PrNet_Tipo_Midia_L"
                    Uc.pFormatoSaida = UcText.FormatoSaida.Texto
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Tipo de Mídia"
                    Uc.MaxLength = 6
                Case enuDicionario.Veiculo_Codigo
                    Uc.MaxLength = 3
                    Uc.sqlQuery = "Execute PrNet_Veiculo_L Null,'" & Uc.Usuario & "'"
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Veiculo"
                Case enuDicionario.Veiculo_Todos
                    Uc.MaxLength = 3
                    Uc.sqlQuery = "Execute PrNet_Veiculo_T "
                    Uc.pCaseformato = UcText.CaseFormato.Maiúsculo
                    Uc.ShowDescricao = True
                    Uc.showButton = True
                    Uc.Caption = "Veiculo"

            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub fnValidar(ByRef Uc As UcText)
        Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric(Uc.Usuario, Uc.Senha)

        Dim dts As New DataSet
        Dim strQuery As String = ""
        Try
            Select Case Uc.pDicionario
                Case enuDicionario.Abrangencia
                    Select Case Uc.Text
                        Case 0
                            Uc.Descricao = "Net"
                        Case 1
                            Uc.Descricao = "Rede"
                        Case 2
                            Uc.Descricao = "Local"
                        Case Else
                            Uc.MensagemErro = "Abrangência Inválida"
                            Uc.Descricao = ""
                    End Select
                Case enuDicionario.Programa_Grade
                    Uc.sqlQuery = "execute PrNet_Programa_Grade '" & Uc.Veiculo & "','" & Format(Uc.DataInicio, "yyyy-MM-dd") & "','" & Format(Uc.DataFim, "yyyy-MM-dd") & "','" & Uc.Text & "'"
                    
                    dts = clsGeneric.fnSqlExecute(Uc.sqlQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Programa não existe na Grade do Veículo ou está desativada"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Titulo")
                    End If

                Case enuDicionario.Genero
                    strQuery = "Execute prNet_Genero_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Gênero Inválida"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If


                Case enuDicionario.Qualidade
                    strQuery = "Execute prNet_Qualidade_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Qualidade Inválida"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If

                Case enuDicionario.Comercial
                    strQuery = " execute prNet_Comercial_L '" & Uc.Cod_Empresa & "'," & Uc.Contrato & "," & Uc.Seq & ",'" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Comercial Inválido"
                        Uc.Descricao = ""
                        Uc.Duracao = 0
                        Uc.Tipo_Comercial = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Titulo_Comercial")
                        Uc.Duracao = dts.Tables(0).Rows(0).Item("Duracao")
                        Uc.Tipo_Comercial = dts.Tables(0).Rows(0).Item("Cod_Tipo_Comercial")
                    End If
                Case enuDicionario.Programa_Codigo
                    strQuery = "Execute prNet_Programa_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Não existe Contrato(s) Patrocinado(s) para esse programa"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Titulo")
                    End If
                Case enuDicionario.Programa_Patrocinado
                    strQuery = "Execute PrNet_Programa_Patrocinado_S " & Uc.Competencia & ",'" & Uc.Usuario & "'" & ",'" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Programa Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Titulo")
                    End If


                Case enuDicionario.Caracteristica_Contrato
                    strQuery = "Execute prNet_Carac_Contrato_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Caracteristíca Inválida"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If

                Case enuDicionario.Mercado
                    strQuery = "Execute prNet_Mercado_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Mercado Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Nome")
                    End If
                Case enuDicionario.Tipo_Comercial
                    strQuery = "Execute prNet_Tipo_Comercial_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Tipo de Comercial não cadastrado ou está desativado"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                        Uc.IndicaMerchandising = dts.Tables(0).Rows(0).Item("Indica_Merchandising")
                    End If

                Case enuDicionario.Terceiro_Codigo
                    strQuery = "Execute prNet_Terceiro_L'" & Uc.Text & "','" & Uc.Usuario & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Código de Terceiro Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Razao_Social")
                    End If
                Case enuDicionario.Terceiro_Ramo_Atividade
                    strQuery = "Execute prNet_Ramo_Atividade_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Código de Categoria Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao_Categoria")
                    End If
                Case enuDicionario.Empresa
                    strQuery = "Execute prNet_Empresa_L '" & Uc.Text & "','" & Uc.Usuario & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Empresa inexistente ou não pertence ao Perfil do Usuário"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item(1)
                    End If
                Case enuDicionario.Empresa_Filtro_Historico
                    strQuery = "Execute PrNet_Empresa_Historico_Mr_L '" & Uc.Text & "','" & Uc.Usuario & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Empresa inexistente ou não pertence ao Perfil do Usuário"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item(1)
                    End If

                Case enuDicionario.UF_Codigo
                    strQuery = "Execute prNet_UF_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Código de UF  Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If
                Case enuDicionario.Terceiro_Funcao
                    strQuery = "Execute prNet_Terceiro_Funcao_L '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Código de Função de Terceiro  Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao_Funcao_Terceiro")
                    End If
                Case enuDicionario.Segmento
                    strQuery = "Execute prNet_Produto_L'" & Uc.DataNumberValue & "',2 "
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Código de Segmento Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If
                Case enuDicionario.Setor
                    strQuery = "Execute prNet_Produto_L'" & Uc.DataNumberValue & "',1 "
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Código de Setor Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If
                Case enuDicionario.Produto
                    strQuery = "Execute prNet_Produto_L'" & Uc.DataNumberValue & "',3 "
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Código de Produto Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If

                Case enuDicionario.Contato
                    strQuery = "Execute prNet_Contato_L'" & Uc.Text & "','" & Uc.Usuario & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Contato Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Nome")
                    End If
                Case enuDicionario.Nucleo
                    strQuery = "Execute prNet_Nucleo_L'" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Núcleo de Venda Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If
                Case enuDicionario.Tipo_de_Midia
                    strQuery = "Execute prNet_Tipo_Midia_L'" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Tipo de Mídia de Venda Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Descricao")
                    End If
                Case enuDicionario.Veiculo_Codigo
                    strQuery = "Execute PrNet_Veiculo_L '" & Uc.Text & "','" & Uc.Usuario & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Veiculo Inexistente ou não pertence ao Perfil do Usuário"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Nome_Veiculo")
                    End If
                Case enuDicionario.Veiculo_Todos
                    strQuery = "Execute PrNet_Veiculo_T '" & Uc.Text & "'"
                    dts = clsGeneric.fnSqlExecute(strQuery)
                    If dts.Tables(0).Rows.Count = 0 Then
                        Uc.MensagemErro = "Veiculo Inválido"
                        Uc.Descricao = ""
                    Else
                        Uc.Descricao = dts.Tables(0).Rows(0).Item("Nome_Veiculo")
                    End If


            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
