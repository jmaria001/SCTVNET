using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.Services.Protocols;

namespace WebServiceMSA
{
	public class asmxTerceiro : System.Web.Services.WebService
	{
        private DTS.dtsTerceiro dtsTerceiro;
        private Conexao.NET.clsConexao Cnn;
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxTerceiro()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsTerceiro Create()
        {
            DTS.dtsTerceiro dtsTerceiro = new DTS.dtsTerceiro();
            return dtsTerceiro;
        }

            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public string fnConsisteCodigo(string pCodigo) // Retorna Mensagem do Erro
            {
                string returnValue;
                returnValue = "";
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                SqlDataReader RD;
                SqlCommand Cmd = Cnn.NewCommand();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    Cmd.Connection = Cnn.spuConnection;
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "PrNet_Terceiro_Codigo_Select";
                    Cmd.Parameters.AddWithValue("@Par_Cod_Terceiro", pCodigo);
                    RD = Cmd.ExecuteReader();
                    RD.Read();
                    if (RD.HasRows)
                    {
                        returnValue = "Código do Terceiro já Existe no Cadastro";
                    }
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message.ToString()));
                }
                finally
                {
                    Cnn.spuClose();
                }
                return returnValue;
            }
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public string fnConsisteCNPJ(String pCNPJ, String pCodigo, String pOperacao) // Retorna Mensagem do Erro
            {
                string returnValue;
                returnValue = "";
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                SqlDataReader RD;
                SqlCommand Cmd = Cnn.NewCommand();
                try
                {
                    if ( pCNPJ.Trim() != "")
                    {

                        //==================================Tira formatacao
                        pOperacao = pOperacao.ToUpper();
                        pCNPJ = pCNPJ.Replace("/", "");
                        pCNPJ = pCNPJ.Replace(".", "");
                        pCNPJ = pCNPJ.Replace("-", "");
                        //======revome zeros a esquerda
                        for (int i = 0; i <= pCNPJ.Length; i++)
                        {
                            if (pCNPJ.Substring(i, 1) != "0")
                            {
                                pCNPJ = pCNPJ.Substring(i);
                                break;
                            }
                        }

                        //======Consiste

                        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                        Cmd.Connection = Cnn.spuConnection;
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.CommandText = "PrNet_Terceiro_CGC_Select";
                        Cmd.Parameters.AddWithValue("@Par_CGC", pCNPJ);
                        Cmd.Parameters.AddWithValue("@Par_Tipo_Pesquisa", 1); 
                        RD = Cmd.ExecuteReader();
                        RD.Read();
                        if (RD.HasRows)
                        {
                            if (pOperacao == "INCLUIR" || (pOperacao == "EDITAR" && pCodigo.Trim() != RD["Cod_Terceiro"].ToString().Trim()))
                            {
                                returnValue = "CNPJ/CPF ja existe no Cadastro para o Terceiro " + RD["Cod_Terceiro"];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message.ToString()));
                }
                finally
                {
                    Cnn.spuClose();
                }
                return returnValue;

            }
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public DataSet FnTerceiro_Carregar(string pCod_Terceiro)
            {
                DataSet Dts = new DataSet();
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);   
                    this.FnCarregarTerceiroPrincipal(Dts, pCod_Terceiro, Cnn.spuConnection );
                    this.FnCarregarTerceiroEmpresa(Dts, pCod_Terceiro, Cnn.spuConnection );
                    this.FnCarregarTerceiroEndereco(Dts, pCod_Terceiro, Cnn.spuConnection );
                    this.FnCarregarTerceiroComplementar(Dts, pCod_Terceiro, Cnn.spuConnection );
                    return Cnn.FnDts(Dts);
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message.ToString()));
                }
                finally
                {
                    Cnn.spuClose();
                }
            }
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public DataSet fnCarregarTerceiroProduto(string pCod_Terceiro)
            {
                SqlDataAdapter Adp = new SqlDataAdapter();
                DataSet Dts = new DataSet();
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    Adp.SelectCommand = Cnn.NewCommand();
                    Adp.SelectCommand.Connection = Cnn.spuConnection ;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "PrNet_Terceiro_Produto_Carregar";
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Terceiro", pCod_Terceiro);
                    Adp.Fill(Dts, "Terceiro_Produto");
                    return Cnn.FnDts(Dts); ;
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message.ToString()));
                }
                finally
                {
                    Cnn.spuClose();
                }
            }
            private void FnCarregarTerceiroPrincipal(DataSet pDts, string pCod_Terceiro, SqlConnection pCnn)
            {
                SqlDataAdapter Adp = new SqlDataAdapter();
                try
                {
                    Adp.SelectCommand = new SqlCommand();
                    Adp.SelectCommand.Connection = pCnn;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "PrNet_Terceiro_Carregar";
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Terceiro", pCod_Terceiro);
                    Adp.Fill(pDts, "Terceiro");
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message.ToString()));
                }
                finally
                {
                }
            }
            private void FnCarregarTerceiroEndereco(DataSet pDts, string pCod_Terceiro, SqlConnection pCnn)
            {
                SqlDataAdapter Adp = new SqlDataAdapter();
                try
                {
                    //Adp.SelectCommand = Cnn.NewCommand();
                    Adp.SelectCommand = new SqlCommand();
                    Adp.SelectCommand.CommandTimeout = pCnn.ConnectionTimeout;
                    Adp.SelectCommand.Connection = pCnn;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "PrNet_Terceiro_Endereco_Select";
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Terceiro",pCod_Terceiro);
                    Adp.Fill(pDts, "Terceiro_Endereco");
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message.ToString()));
                }
                finally
                {
                }
            }
            private void FnCarregarTerceiroComplementar(DataSet pDts, string pCod_Terceiro, SqlConnection pCnn)
            {
                SqlDataAdapter Adp = new SqlDataAdapter();
                try
                {
                    //Adp.SelectCommand = Cnn.NewCommand();

                    Adp.SelectCommand = new SqlCommand();
                    Adp.SelectCommand.CommandTimeout = pCnn.ConnectionTimeout;
                    Adp.SelectCommand.Connection = pCnn;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "PrNet_Terceiro_Complementar_Select";
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Terceiro",pCod_Terceiro);
                    Adp.Fill(pDts, "Terceiro_Complementar");
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message.ToString()));
                }
                finally
                {
                }
            }
            private void FnCarregarTerceiroCredito(DataSet pDts, SqlConnection pCnn)
            {
            }
            private void FnCarregarTerceiroEmpresa(DataSet pDts, string pCod_Terceiro, SqlConnection pCnn)
            {
                SqlDataAdapter Adp = new SqlDataAdapter();
                try
                {
                    Adp.SelectCommand = new SqlCommand();
                    Adp.SelectCommand.CommandTimeout = pCnn.ConnectionTimeout;
                    Adp.SelectCommand.Connection = pCnn;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "PrNet_Terceiro_Empresa_Select";
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Terceiro", pCod_Terceiro);
                    Adp.Fill(pDts, "Terceiro_Empresa");
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message));
                }
            }
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public bool FnAtualizar(DataSet dtsTerceiro)
            {
                bool returnValue;
                returnValue = true;
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    if (!fnAtualizarTerceiro(dtsTerceiro, Cnn.spuConnection ))
                    {
                        returnValue = false;
                    }
                    else if (!fnAtualizarTerceiroEndereco (dtsTerceiro, Cnn.spuConnection))
                    {
                        returnValue = false;
                    }
                    else if (!fnAtualizarTerceiroComplementar (dtsTerceiro, Cnn.spuConnection))
                    {
                        returnValue = false;
                    }

                    return returnValue;
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message));
                }
            }
            private bool fnAtualizarTerceiro(DataSet dtsTerceiro, SqlConnection Cnn) ///comecando 
            {
                bool returnValue;

                returnValue = true;
                try
                {
                    SqlDataAdapter Adp = new SqlDataAdapter();
                    Adp.InsertCommand = new SqlCommand("prNet_Terceiro_Insert");
                    Adp.InsertCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    Adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                    Adp.InsertCommand.Connection = Cnn;

                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.InsertCommand.Parameters.Add("@Par_Razao_Social", SqlDbType.Char, 50, "Razao_Social");
                    Adp.InsertCommand.Parameters.Add("@Par_Nome_Fantasia", SqlDbType.Char, 50, "Nome_Fantasia");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Funcao", SqlDbType.Int, 2, "Funcao");
                    Adp.InsertCommand.Parameters.Add("@Par_cgc", SqlDbType.Char, 18, "CGC");
                    Adp.InsertCommand.Parameters.Add("@Par_Inscricao_Estadual", SqlDbType.Char, 15, "Inscricao_Estadual");
                    Adp.InsertCommand.Parameters.Add("@Par_Inscricao_Municipal", SqlDbType.Char, 15, "Inscricao_Municipal");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa_Principal", SqlDbType.Char, 3, "Cod_Empresa_Principal");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Categoria", SqlDbType.Int, 2, "Cod_Categoria");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Cic_Cgc", SqlDbType.Int, 1, "Indica_Cic_Cgc");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_TV", SqlDbType.TinyInt, 1, "Indica_TV");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Afiliada", SqlDbType.TinyInt, 1, "Indica_Afiliada");
                    Adp.InsertCommand.Parameters.Add("@Par_indica_regional", SqlDbType.TinyInt, 1, "indica_regional");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Estrangeiro", SqlDbType.TinyInt, 1, "Indica_Estrangeiro");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_IntegracaoIq", SqlDbType.TinyInt, 1, "Indica_IntegracaoIq");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Porte", SqlDbType.TinyInt, 1, "Indica_Porte");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Direto", SqlDbType.TinyInt, 1, "Indica_Direto");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Desativado", SqlDbType.TinyInt, 1, "Indica_Desativado");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Cadastramento", SqlDbType.DateTime, 19, "Data_Cadastramento");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Alteracao", SqlDbType.DateTime, 19, "Data_Alteracao");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Desativacao", SqlDbType.DateTime, 19, "Data_Desativacao");

                    Adp.UpdateCommand = new SqlCommand("prNet_Terceiro_UPdate");
                    Adp.UpdateCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    Adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                    Adp.UpdateCommand.Connection = Cnn;

                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.UpdateCommand.Parameters.Add("@Par_Razao_Social", SqlDbType.Char, 50, "Razao_Social");
                    Adp.UpdateCommand.Parameters.Add("@Par_Nome_Fantasia", SqlDbType.Char, 50, "Nome_Fantasia");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Funcao", SqlDbType.Int, 2, "Funcao");
                    Adp.UpdateCommand.Parameters.Add("@Par_CGC", SqlDbType.Char, 18, "CGC");
                    Adp.UpdateCommand.Parameters.Add("@Par_Inscricao_Estadual", SqlDbType.Char, 15, "Inscricao_Estadual");
                    Adp.UpdateCommand.Parameters.Add("@Par_Inscricao_Municipal", SqlDbType.Char, 15, "Inscricao_Municipal");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Empresa_Principal", SqlDbType.Char, 3, "Cod_Empresa_Principal");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Categoria", SqlDbType.Int, 2, "Cod_Categoria");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Cic_Cgc", SqlDbType.Int, 1, "Indica_Cic_Cgc");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_TV", SqlDbType.TinyInt, 1, "Indica_TV");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Afiliada", SqlDbType.TinyInt, 1, "Indica_Afiliada");
                    Adp.UpdateCommand.Parameters.Add("@Par_indica_regional", SqlDbType.TinyInt, 1, "indica_regional");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Estrangeiro", SqlDbType.TinyInt, 1, "Indica_Estrangeiro");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_IntegracaoIq", SqlDbType.TinyInt, 1, "Indica_IntegracaoIq");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Porte", SqlDbType.TinyInt, 1, "Indica_Porte");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Direto", SqlDbType.TinyInt, 1, "Indica_Direto");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Desativado", SqlDbType.TinyInt, 1, "Indica_Desativado");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Cadastramento", SqlDbType.DateTime, 19, "Data_Cadastramento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Alteracao", SqlDbType.DateTime, 19, "Data_Alteracao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Desativacao", SqlDbType.DateTime, 19, "Data_Desativacao");
                    
                    Adp.Update(dtsTerceiro.Tables["terceiro"]);

                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message));
                }
                return returnValue;
            }
            private bool fnAtualizarTerceiroEndereco(DataSet dtsTerceiro, SqlConnection Cnn)
            {
                bool returnValue;
                returnValue = true;
                try
                {
                    SqlDataAdapter Adp = new SqlDataAdapter();
                    Adp.InsertCommand = new SqlCommand("prNet_Terceiro_Endereco_Insert");
                    Adp.InsertCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    Adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                    Adp.InsertCommand.Connection = Cnn;

                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");
                    Adp.InsertCommand.Parameters.Add("@Par_Endereco1", SqlDbType.Char, 40, "Endereco1");
                    Adp.InsertCommand.Parameters.Add("@Par_Numero1", SqlDbType.Char, 10, "Numero1");
                    Adp.InsertCommand.Parameters.Add("@Par_Complemento1", SqlDbType.Char, 30, "Complemento1");
                    Adp.InsertCommand.Parameters.Add("@Par_Bairro1", SqlDbType.Char, 30, "Bairro1");
                    Adp.InsertCommand.Parameters.Add("@Par_Municipio1", SqlDbType.Char, 30, "Municipio1");
                    Adp.InsertCommand.Parameters.Add("@Par_Uf1", SqlDbType.Char, 2, "Uf1");
                    Adp.InsertCommand.Parameters.Add("@Par_Cep1", SqlDbType.Char, 9, "Cep1");
                    Adp.InsertCommand.Parameters.Add("@Par_Endereco2", SqlDbType.Char, 40, "Endereco2");
                    Adp.InsertCommand.Parameters.Add("@Par_Numero2", SqlDbType.Char, 10, "Numero2");
                    Adp.InsertCommand.Parameters.Add("@Par_Complemento2", SqlDbType.Char, 30, "Complemento2");
                    Adp.InsertCommand.Parameters.Add("@Par_Bairro2", SqlDbType.Char, 30, "Bairro2");
                    Adp.InsertCommand.Parameters.Add("@Par_Municipio2", SqlDbType.Char, 30, "Municipio2");
                    Adp.InsertCommand.Parameters.Add("@Par_Uf2", SqlDbType.Char, 2, "Uf2");
                    Adp.InsertCommand.Parameters.Add("@Par_Cep2", SqlDbType.Char, 9, "Cep2");
                    Adp.InsertCommand.Parameters.Add("@Par_Telefone", SqlDbType.Char, 20, "Telefone");
                    Adp.InsertCommand.Parameters.Add("@Par_Fax", SqlDbType.Char, 20, "Fax");
                    Adp.InsertCommand.Parameters.Add("@Par_Email", SqlDbType.Char, 40, "Email");
                    Adp.InsertCommand.Parameters.Add("@Par_Praca_Pgto", SqlDbType.Char, 30, "Praca_Pgto");

                    Adp.UpdateCommand = new SqlCommand("prNet_Terceiro_Endereco_Update");
                    Adp.UpdateCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    Adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                    Adp.UpdateCommand.Connection = Cnn;

                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");
                    Adp.UpdateCommand.Parameters.Add("@Par_Endereco1", SqlDbType.Char, 40, "Endereco1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Numero1", SqlDbType.Char, 10, "Numero1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Complemento1", SqlDbType.Char, 30, "Complemento1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Bairro1", SqlDbType.Char, 30, "Bairro1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Municipio1", SqlDbType.Char, 30, "Municipio1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Uf1", SqlDbType.Char, 2, "Uf1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cep1", SqlDbType.Char, 9, "Cep1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Endereco2", SqlDbType.Char, 40, "Endereco2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Numero2", SqlDbType.Char, 10, "Numero2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Complemento2", SqlDbType.Char, 30, "Complemento2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Bairro2", SqlDbType.Char, 30, "Bairro2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Municipio2", SqlDbType.Char, 30, "Municipio2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Uf2", SqlDbType.Char, 2, "Uf2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cep2", SqlDbType.Char, 9, "Cep2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Telefone", SqlDbType.Char, 20, "Telefone");
                    Adp.UpdateCommand.Parameters.Add("@Par_Fax", SqlDbType.Char, 20, "Fax");
                    Adp.UpdateCommand.Parameters.Add("@Par_Email", SqlDbType.Char, 40, "Email");
                    Adp.UpdateCommand.Parameters.Add("@Par_Praca_Pgto", SqlDbType.Char, 30, "Praca_Pgto");

                    Adp.DeleteCommand = new SqlCommand("prNet_Terceiro_Endereco_Delete");
                    Adp.DeleteCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    Adp.DeleteCommand.CommandType = CommandType.StoredProcedure;
                    Adp.DeleteCommand.Connection = Cnn;
                    Adp.DeleteCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.DeleteCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");

                    Adp.Update(dtsTerceiro.Tables["Terceiro_Endereco"]);
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message));
                }
                return returnValue;
            }
            private bool fnAtualizarTerceiroComplementar(DataSet dtsTerceiro, SqlConnection Cnn)
            {
                bool returnValue;
                returnValue = true;
                try
                {

                    SqlDataAdapter Adp = new SqlDataAdapter();

                    Adp.InsertCommand = new SqlCommand("prNet_Terceiro_Complementar_Insert");
                    Adp.InsertCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    Adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                    Adp.InsertCommand.Connection = Cnn;
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");
                    Adp.InsertCommand.Parameters.Add("@Par_Nome_Contato", SqlDbType.Char, 40, "Nome_Contato");
                    Adp.InsertCommand.Parameters.Add("@Par_Email_Contato", SqlDbType.Char, 40, "Email_Contato");
                    Adp.InsertCommand.Parameters.Add("@Par_Telefone_Contato_1", SqlDbType.Char, 20, "Telefone_Contato_1");
                    Adp.InsertCommand.Parameters.Add("@Par_Telefone_Contato_2", SqlDbType.Char, 20, "Telefone_Contato_2");
                    Adp.InsertCommand.Parameters.Add("@Par_Nome_Contato_Compl", SqlDbType.Char, 40, "Nome_Contato_Compl");
                    Adp.InsertCommand.Parameters.Add("@Par_Email_Contato_Compl", SqlDbType.Char, 40, "Email_Contato_Compl");
                    Adp.InsertCommand.Parameters.Add("@Par_Telefone_Contato_Compl_1", SqlDbType.Char, 20, "Telefone_Contato_Compl_1");
                    Adp.InsertCommand.Parameters.Add("@Par_Telefone_Contato_Compl_2", SqlDbType.Char, 20, "Telefone_Contato_Compl_2");
                    Adp.InsertCommand.Parameters.Add("@Par_Conta_Contabil", SqlDbType.Int, 4, "Conta_Contabil");
                    Adp.InsertCommand.Parameters.Add("@Par_Sub_Conta", SqlDbType.Int, 4, "Sub_Conta");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Inclusao", SqlDbType.DateTime, 8, "Data_Inclusao");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Alteracao", SqlDbType.DateTime, 8, "Data_Alteracao");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Desativacao", SqlDbType.DateTime, 8, "Data_Desativacao");
                    Adp.InsertCommand.Parameters.Add("@Par_indica_desativado", SqlDbType.TinyInt, 1, "indica_desativado");
                    Adp.InsertCommand.Parameters.Add("@Par_Motivo_Desativacao", SqlDbType.Char, 500, "Motivo_Desativacao");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Integracao", SqlDbType.TinyInt, 1, "Indica_Integracao");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_IntegracaoIq", SqlDbType.TinyInt, 1, "Indica_IntegracaoIq");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Merchandising", SqlDbType.TinyInt, 1, "Indica_Merchandising");
                    Adp.InsertCommand.Parameters.Add("@Par_Grupo_Cliente", SqlDbType.SmallInt, 2, "Grupo_Cliente");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Representante", SqlDbType.Int, 4, "Cod_Representante");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Banco", SqlDbType.Char, 3, "Cod_Banco");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Grupo_Cliente", SqlDbType.SmallInt, 2, "Cod_Grupo_Cliente");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Integracao_Executada", SqlDbType.TinyInt, 1, "Indica_Integracao_Executada");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Integracao_Executada_Contato", SqlDbType.TinyInt, 1, "Indica_Integracao_Executada_Contato");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_IN480", SqlDbType.Bit, 1, "Indica_IN480");
                    Adp.InsertCommand.Parameters.Add("@Par_Bco_Agencia", SqlDbType.Char, 4, "Bco_Agencia");
                    Adp.InsertCommand.Parameters.Add("@Par_Bco_Agencia_DV", SqlDbType.Char, 2, "Bco_Agencia_DV");
                    Adp.InsertCommand.Parameters.Add("@Par_Bco_Conta_Corrente", SqlDbType.Char, 25, "Bco_Conta_Corrente");
                    Adp.InsertCommand.Parameters.Add("@Par_Bco_Conta_Corrente_DV", SqlDbType.Char, 2, "Bco_Conta_Corrente_DV");
                    Adp.InsertCommand.Parameters.Add("@Par_Conta_Contabil_Passivo", SqlDbType.Int, 4, "Conta_Contabil_Passivo");
                    Adp.InsertCommand.Parameters.Add("@Par_Conta_Contabil_Adiantamento", SqlDbType.Int, 4, "Conta_Contabil_Adiantamento");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_ERP_Integra", SqlDbType.TinyInt, 1, "Indica_ERP_Integra");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Foi_Integrado", SqlDbType.TinyInt, 1, "Indica_Foi_Integrado");

                    Adp.UpdateCommand = new SqlCommand("prNet_Terceiro_Complementar_Update");
                    Adp.UpdateCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    Adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                    Adp.UpdateCommand.Connection = Cnn;
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");
                    Adp.UpdateCommand.Parameters.Add("@Par_Nome_Contato", SqlDbType.Char, 40, "Nome_Contato");
                    Adp.UpdateCommand.Parameters.Add("@Par_Email_Contato", SqlDbType.Char, 40, "Email_Contato");
                    Adp.UpdateCommand.Parameters.Add("@Par_Telefone_Contato_1", SqlDbType.Char, 20, "Telefone_Contato_1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Telefone_Contato_2", SqlDbType.Char, 20, "Telefone_Contato_2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Nome_Contato_Compl", SqlDbType.Char, 40, "Nome_Contato_Compl");
                    Adp.UpdateCommand.Parameters.Add("@Par_Email_Contato_Compl", SqlDbType.Char, 40, "Email_Contato_Compl");
                    Adp.UpdateCommand.Parameters.Add("@Par_Telefone_Contato_Compl_1", SqlDbType.Char, 20, "Telefone_Contato_Compl_1");
                    Adp.UpdateCommand.Parameters.Add("@Par_Telefone_Contato_Compl_2", SqlDbType.Char, 20, "Telefone_Contato_Compl_2");
                    Adp.UpdateCommand.Parameters.Add("@Par_Conta_Contabil", SqlDbType.Int, 4, "Conta_Contabil");
                    Adp.UpdateCommand.Parameters.Add("@Par_Sub_Conta", SqlDbType.Int, 4, "Sub_Conta");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Inclusao", SqlDbType.DateTime, 8, "Data_Inclusao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Alteracao", SqlDbType.DateTime, 8, "Data_Alteracao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Desativacao", SqlDbType.DateTime, 8, "Data_Desativacao");
                    Adp.UpdateCommand.Parameters.Add("@Par_indica_desativado", SqlDbType.TinyInt, 1, "indica_desativado");
                    Adp.UpdateCommand.Parameters.Add("@Par_Motivo_Desativacao", SqlDbType.Char, 500, "Motivo_Desativacao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Integracao", SqlDbType.TinyInt, 1, "Indica_Integracao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_IntegracaoIq", SqlDbType.TinyInt, 1, "Indica_IntegracaoIq");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Merchandising", SqlDbType.TinyInt, 1, "Indica_Merchandising");
                    Adp.UpdateCommand.Parameters.Add("@Par_Grupo_Cliente", SqlDbType.SmallInt, 2, "Grupo_Cliente");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Representante", SqlDbType.Int, 4, "Cod_Representante");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Banco", SqlDbType.Char, 3, "Cod_Banco");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Grupo_Cliente", SqlDbType.SmallInt, 2, "Cod_Grupo_Cliente");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Integracao_Executada", SqlDbType.TinyInt, 1, "Indica_Integracao_Executada");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Integracao_Executada_Contato", SqlDbType.TinyInt, 1, "Indica_Integracao_Executada_Contato");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_IN480", SqlDbType.Bit, 1, "Indica_IN480");
                    Adp.UpdateCommand.Parameters.Add("@Par_Bco_Agencia", SqlDbType.Char, 4, "Bco_Agencia");
                    Adp.UpdateCommand.Parameters.Add("@Par_Bco_Agencia_DV", SqlDbType.Char, 2, "Bco_Agencia_DV");
                    Adp.UpdateCommand.Parameters.Add("@Par_Bco_Conta_Corrente", SqlDbType.Char, 25, "Bco_Conta_Corrente");
                    Adp.UpdateCommand.Parameters.Add("@Par_Bco_Conta_Corrente_DV", SqlDbType.Char, 2, "Bco_Conta_Corrente_DV");
                    Adp.UpdateCommand.Parameters.Add("@Par_Conta_Contabil_Passivo", SqlDbType.Int, 4, "Conta_Contabil_Passivo");
                    Adp.UpdateCommand.Parameters.Add("@Par_Conta_Contabil_Adiantamento", SqlDbType.Int, 4, "Conta_Contabil_Adiantamento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_ERP_Integra", SqlDbType.TinyInt, 1, "Indica_ERP_Integra");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Foi_Integrado", SqlDbType.TinyInt, 1, "Indica_Foi_Integrado");

                    Adp.DeleteCommand = new SqlCommand("prNet_Terceiro_Complementar_Delete");
                    Adp.DeleteCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    Adp.DeleteCommand.CommandType = CommandType.StoredProcedure;
                    Adp.DeleteCommand.Connection = Cnn;
                    Adp.DeleteCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.DeleteCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");

                    Adp.Update(dtsTerceiro.Tables["Terceiro_Complementar"]);

                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message));
                }
                return returnValue;
            }
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public bool fnAtualizarTerceiroProduto(DataSet dtsTerceiroProduto)
            {
                bool returnValue;
                returnValue = true;
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    SqlDataAdapter Adp = new SqlDataAdapter();
                    Adp.InsertCommand = Cnn.NewCommand("PrNet_Terceiro_Produto_Insert");
                    Adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                    Adp.InsertCommand.Connection = Cnn.spuConnection;

                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Red_Produto", SqlDbType.Int, 4, "Cod_Red_Produto");

                    Adp.DeleteCommand = Cnn.NewCommand("PrNet_Terceiro_Produto_Delete");
                    Adp.DeleteCommand.CommandType = CommandType.StoredProcedure;
                    Adp.DeleteCommand.Connection = Cnn.spuConnection;
                    Adp.DeleteCommand.Parameters.Add("@Par_Cod_Terceiro", SqlDbType.Char, 6, "Cod_Terceiro");
                    Adp.DeleteCommand.Parameters.Add("@Par_Cod_Red_Produto", SqlDbType.Int, 4, "Cod_Red_Produto");


                    Adp.Update(dtsTerceiroProduto.Tables["Terceiro_Produto"]);
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message));
                }
                return returnValue;
            }
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public void fnDesativarTerceiro(string pCod_Terceiro, string pCod_Empresa, string pMotivoCancelamento, byte pOperacao)
            {
                
                
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                SqlCommand cmd = Cnn.NewCommand();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                    cmd = Cnn.NewCommand("PrNet_Terceiro_Desativar");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = Cnn.spuConnection ;
                    cmd.Parameters.AddWithValue("@Par_Cod_Terceiro", pCod_Terceiro);
                    cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                    cmd.Parameters.AddWithValue("@Par_Motivo_Desativacao", pMotivoCancelamento);
                    cmd.Parameters.AddWithValue("@Par_Operacao", pOperacao);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw (new Exception(ex.Message));
                }
            }

            [WebMethod, SoapHeader("spAuthenticationHeader")]
                    public Boolean fnTerceiroExcluir(string pCodigoTerceiro )
            {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
               
            SqlDataReader RD ;
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "sp_Deleta_Terceiro ";
                Cmd.Parameters.AddWithValue("@Par_Cod_Terceiro", pCodigoTerceiro);
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", DBNull.Value);
                Cmd.Parameters.AddWithValue("@Par_Indica_Delecao", 1);
                RD = Cmd.ExecuteReader();

                RD.Read();
                if (RD["Indica_Erro"].ToString() == "0")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Cnn.spuClose();
           }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public DTS.dtsTerceiro spuCarregar(string strCod_Terceiro)
        {
            try
            {
                Cnn = new Conexao.NET.clsConexao();

                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                dtsTerceiro = new DTS.dtsTerceiro();

                this.sprCarregar_Terceiro(strCod_Terceiro, Cnn.spuConnection);
                this.sprCarregar_Terceiro_Complementar(strCod_Terceiro, Cnn.spuConnection);
                this.sprCarregar_Terceiro_Endereco(strCod_Terceiro, Cnn.spuConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxTerceiro.spuCarregar_Codigo " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsTerceiro;
        }

        private void sprCarregar_Terceiro(string strCod_Terceiro, SqlConnection Cnn)
        {
            SqlDataAdapter adp;

            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("pr_Terceiro_L", Cnn);
                adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout;
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Terceiro", strCod_Terceiro);

                adp.Fill(dtsTerceiro.dtbTerceiro);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxTerceiro.spuCarregar_Terceiro " + ex.Message.ToString());
            }
        }
        private void sprCarregar_Terceiro_Endereco(string strCod_Terceiro, SqlConnection Cnn)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("pr_Terceiro_Endereco_L", Cnn);
                adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout;
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Terceiro", strCod_Terceiro);

                adp.Fill(dtsTerceiro.dtbTerceiro_Endereco);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxTerceiro.spuCarregar_Terceiro_Endereco " + ex.Message.ToString());
            }
        }


        // Carrega os Dados Complementares de um Terceiro Específico e preenche uma tabela do dataset
        private void sprCarregar_Terceiro_Complementar(string strCod_Terceiro, SqlConnection Cnn)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("pr_Terceiro_Complementar_S", Cnn);
                adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout;
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Terceiro", strCod_Terceiro);

                adp.Fill(dtsTerceiro.dtbTerceiro_Complementar);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxTerceiro.sprCarregar_Terceiro_Complementar " + ex.Message.ToString());
            }
        }
            [WebMethod, SoapHeader("spAuthenticationHeader")] 
            public DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable spuPesquisar_Codigo(string strCod_Terceiro)
            {
                SqlDataAdapter adp;
                try
                {
                    adp = new SqlDataAdapter();
                    Cnn = new Conexao.NET.clsConexao();

                    DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable dtbTerceiro_Pesquisa;
                    dtbTerceiro_Pesquisa = new WebServiceMSA.DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                    adp.SelectCommand = Cnn.NewCommand("pr_Terceiro_Codigo_S", Cnn.spuConnection);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@PCod_Terceiro", strCod_Terceiro);

                    adp.Fill(dtbTerceiro_Pesquisa);
                    return dtbTerceiro_Pesquisa;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxTerceiro.spuPesquisar_Codigo " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
            }



            [WebMethod(MessageName = "spuPesquisar_Codigo_Empresa"), SoapHeader("spAuthenticationHeader")]  
            public DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable spuPesquisar_Codigo(string strCod_Terceiro, string strEmpresas)
            {
                SqlDataAdapter adp;

                try
                {
                    Cnn = new Conexao.NET.clsConexao();
                    adp = new SqlDataAdapter();

                    DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable dtbTerceiro_Pesquisa;
                    dtbTerceiro_Pesquisa = new WebServiceMSA.DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                    adp.SelectCommand = Cnn.NewCommand("prNet_Terceiro_Empresa_S", Cnn.spuConnection);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@strEmpresas_P", strEmpresas);
                    adp.SelectCommand.Parameters.AddWithValue("@strCod_Terceiro_P", (strCod_Terceiro.ToString().Length == 0 ? null : strCod_Terceiro));

                    adp.Fill(dtbTerceiro_Pesquisa);
                    return dtbTerceiro_Pesquisa;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxTerceiro.spuPesquisar_Codigo_Empresa " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
            }
            


            
            [WebMethod, SoapHeader("spAuthenticationHeader")] 
            public DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable spuPesquisar_Razao_Social(string strRazao_Social)
            {
                return spuPesquisar_Razao_Social(strRazao_Social, -1);
            }
            

            
            [WebMethod(MessageName = "spuPesquisar_Razao_Social_Empresa"), SoapHeader("spAuthenticationHeader")]  
            public DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable spuPesquisar_Razao_Social(string strRazao_Social, string strEmpresas)
            {
                SqlDataAdapter adp;
                try
                {
                    Cnn = new Conexao.NET.clsConexao();
                    adp = new SqlDataAdapter();

                    DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable dtbTerceiro_Pesquisa;
                    dtbTerceiro_Pesquisa = new WebServiceMSA.DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                    adp.SelectCommand = Cnn.NewCommand("prNet_Terceiro_Empresa_Razao_S", Cnn.spuConnection);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@strEmpresas_P", strEmpresas);
                    adp.SelectCommand.Parameters.AddWithValue("@strRazaoSocial_P", strRazao_Social);

                    adp.Fill(dtbTerceiro_Pesquisa);
                    return dtbTerceiro_Pesquisa;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxTerceiro.spuPesquisar_Razao_Social_Empresa " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
            }



            [WebMethod(MessageName = "spuPesquisar_Razao_Social_Funcao"), SoapHeader("spAuthenticationHeader")] 
            public DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable spuPesquisar_Razao_Social(string strRazao_Social, short intCod_Funcao)
            {
                SqlDataAdapter adp;

                try
                {
                    adp = new SqlDataAdapter();
                    Cnn = new Conexao.NET.clsConexao();

                    DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable dtbTerceiro_Pesquisa;
                    dtbTerceiro_Pesquisa = new WebServiceMSA.DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                    adp.SelectCommand = Cnn.NewCommand("pr_Terceiro_Razao_Social_S", Cnn.spuConnection);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@PRazao_Social", strRazao_Social);
                    adp.SelectCommand.Parameters.AddWithValue("@PCod_Funcao", (intCod_Funcao != -1 ? intCod_Funcao.ToString() : null));

                    adp.Fill(dtbTerceiro_Pesquisa);
                    return dtbTerceiro_Pesquisa;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxTerceiro.spuPesquisar_Razao_Social " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
            }
            


            
            [WebMethod, SoapHeader("spAuthenticationHeader")]  
            public DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable spuPesquisar_CNPJ(string strCPF_CNPJ)
            {
                SqlDataAdapter adp;

                try
                {
                    Cnn = new Conexao.NET.clsConexao();
                    adp = new SqlDataAdapter();

                    DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable dtbTerceiro_Pesquisa;
                    dtbTerceiro_Pesquisa = new WebServiceMSA.DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                    adp.SelectCommand = Cnn.NewCommand("pr_Terceiro_CNPJ_S", Cnn.spuConnection);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@PCPF_CNPJ", strCPF_CNPJ);

                    adp.Fill(dtbTerceiro_Pesquisa);
                    return dtbTerceiro_Pesquisa;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxTerceiro.spuPesquisar_CNPJ " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
            }



            [WebMethod(MessageName = "spuPesquisar_CNPJ_Empresa"), SoapHeader("spAuthenticationHeader")]  
            public DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable spuPesquisar_CNPJ(string strCPF_CNPJ, string strEmpresas)
            {
                SqlDataAdapter adp;
                try
                {
                    Cnn = new Conexao.NET.clsConexao();
                    adp = new SqlDataAdapter();

                    DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable dtbTerceiro_Pesquisa;
                    dtbTerceiro_Pesquisa = new WebServiceMSA.DTS.dtsTerceiro.dtbTerceiro_PesquisaDataTable();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                    adp.SelectCommand = Cnn.NewCommand("prNet_Terceiro_Empresa_CNPJ_S", Cnn.spuConnection);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@strEmpresas_P", strEmpresas);
                    adp.SelectCommand.Parameters.AddWithValue("@strCNPJ_P", strCPF_CNPJ);

                    adp.Fill(dtbTerceiro_Pesquisa);
                    return dtbTerceiro_Pesquisa;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxTerceiro.spuPesquisar_CNPJ_Empresa " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
            }

            [WebMethod ,SoapHeader("spAuthenticationHeader")]  
            public DataSet  spuTerceiroFiltro(  String pCodigo          , 
                                                String pRazaoSocial     ,
                                                String pNomeNomeFantasia,
                                                String pCNPJ            ,
                                                String pMunicipio       ,
                                                int pFuncao          ,
                                                String pUsuario)
            {
                SqlDataAdapter adp = new SqlDataAdapter();;
                DataSet Dts  = new DataSet();
                try
                {
                    Cnn = new Conexao.NET.clsConexao();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    adp.SelectCommand = Cnn.NewCommand("PrNet_Terceiro_Filtro", Cnn.spuConnection);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;

                    if (pCodigo != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Terceiro", pCodigo );
                    if (pRazaoSocial  != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Razao_Social", pRazaoSocial );
                    if (pNomeNomeFantasia != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Nome_Fantasia", pNomeNomeFantasia );
                    if (pCNPJ != "") adp.SelectCommand.Parameters.AddWithValue("@Par_CGC", pCNPJ );
                    if (pMunicipio!= "") adp.SelectCommand.Parameters.AddWithValue("@Par_Municipio", pMunicipio );
                    if (pFuncao != 0) adp.SelectCommand.Parameters.AddWithValue("@Par_Funcao", pFuncao );
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Usuario", pUsuario );
                    adp.Fill(Dts );
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxTerceiro.spuPesquisar_CNPJ_Empresa " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
                return Cnn.FnDts(Dts);
            }
    }
}
