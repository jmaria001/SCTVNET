using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;
using System.Data;


namespace WebServiceMSA
{
    public class asmxBaixaVeiculacao : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        private Conexao.NET.clsConexao Cnn;
        private DTS.dtsBaixaVeiculacao dtsBaixaVeiculacao;

        public asmxBaixaVeiculacao()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsBaixaVeiculacao Create()
        {
            DTS.dtsBaixaVeiculacao  dtsBaixaVeiculacao = new DTS.dtsBaixaVeiculacao() ;
            return dtsBaixaVeiculacao;
        }



        #region Carregar
            #region Carregar Criticas ()
            [WebMethod(MessageName = "spuCarregar_Critica"), SoapHeader("spAuthenticationHeader")]
            public DTS.dtsBaixaVeiculacao spuCarregar()
            {
                this.dtsBaixaVeiculacao = new WebServiceMSA.DTS.dtsBaixaVeiculacao();
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    this.sprCarregar_Critica(-1, Cnn.spuConnection);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxBaixaVeiculacao.spuCarregar\n" + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
                return (this.dtsBaixaVeiculacao);
            }
            #endregion

            #region Carregar por Id (id_Baixa)
            [WebMethod(MessageName = "spuCarregar_Id"), SoapHeader("spAuthenticationHeader")]
            public DTS.dtsBaixaVeiculacao spuCarregar(int intId_Baixa)
            {
                this.dtsBaixaVeiculacao = new WebServiceMSA.DTS.dtsBaixaVeiculacao();
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    this.sprCarregar_LOG(intId_Baixa, Cnn.spuConnection);

                    foreach (WebServiceMSA.DTS.dtsBaixaVeiculacao.dtbBaixa_LogRow drw in this.dtsBaixaVeiculacao.dtbBaixa_Log.Rows)
                    {
                        this.sprCarregar_Critica(drw.Id_Critica, Cnn.spuConnection);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxBaixaVeiculacao.spuCarregar_Id\n" + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
                return (this.dtsBaixaVeiculacao);
            }
            #endregion

            #region Carregar por Veiculacao ( Veículo, Data, Programa )
            [WebMethod(MessageName = "spuCarregar_Veiculacao1"), SoapHeader("spAuthenticationHeader")]
            public DTS.dtsBaixaVeiculacao spuCarregar(String strCod_Veiculo, DateTime dteData_Exibicao, String strCod_Programa)
            {
                return spuCarregar(strCod_Veiculo, dteData_Exibicao, strCod_Programa, -1);
            }
            #endregion

            #region Carregar por Veiculacao ( Veículo, Data, Programa, Chave_Acesso )
            [WebMethod(MessageName = "spuCarregar_Veiculacao2"), SoapHeader("spAuthenticationHeader")]
            public DTS.dtsBaixaVeiculacao spuCarregar(String strCod_Veiculo, DateTime dteData_Exibicao, String strCod_Programa, int intChave_Acesso)
            {
                this.dtsBaixaVeiculacao = new WebServiceMSA.DTS.dtsBaixaVeiculacao();
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    this.sprCarregar_LOG_Veiculacao(strCod_Veiculo, dteData_Exibicao, strCod_Programa, intChave_Acesso, Cnn.spuConnection);
                    this.sprCarregar_Critica(-1, Cnn.spuConnection);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxBaixaVeiculacao.spuCarregar\n" + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
                return (this.dtsBaixaVeiculacao);
            }
            #endregion

            #region sprCarregar_LOG_Veiculacao
            private void sprCarregar_LOG_Veiculacao(String strCod_Veiculo, DateTime dteData_Exibicao, String strCod_Programa, int intChave_Acesso, SqlConnection Cnn)
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                try
                {
                    adp.SelectCommand = new SqlCommand("prNet_Baixa_LOG_Veiculacao_S", Cnn);
                    adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@strPCod_Veiculo", strCod_Veiculo);
                    adp.SelectCommand.Parameters.AddWithValue("@dtePData_Exibicao", dteData_Exibicao);
                    adp.SelectCommand.Parameters.AddWithValue("@strPCod_Programa", strCod_Programa);
                    if (intChave_Acesso > 0)
                        adp.SelectCommand.Parameters.AddWithValue("@intPChave_Acesso", intChave_Acesso);
                    else
                        adp.SelectCommand.Parameters.AddWithValue("@intPChave_Acesso", DBNull.Value );

                    adp.Fill(this.dtsBaixaVeiculacao.dtbBaixa_Log);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxBaixaVeiculacao.sprCarregar_LOG_Veiculacao\n" + ex.Message.ToString());
                }
                finally
                {
                    adp.Dispose();
                }
            }
            #endregion

            #region sprCarregar_LOG
            private void sprCarregar_LOG(int intId_Baixa, SqlConnection Cnn)
            {
                SqlDataAdapter adp = new SqlDataAdapter();

                try
                {
                    adp.SelectCommand = new SqlCommand("prNet_Baixa_LOG_S", Cnn);
                    adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@intPId_Baixa", intId_Baixa);

                    adp.Fill(this.dtsBaixaVeiculacao.dtbBaixa_Log);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxBaixaVeiculacao.sprCarregar_LOG\n" + ex.Message.ToString());
                }
                finally
                {
                    adp.Dispose();
                }
            }
            #endregion

            #region sprCarregar_Critica
            private void sprCarregar_Critica(int intId_Critica, SqlConnection Cnn)
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                try
                {
                    adp.SelectCommand = new SqlCommand("prNet_Baixa_Critica_S", Cnn);
                    adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    if (intId_Critica > 0)
                        adp.SelectCommand.Parameters.AddWithValue("@intPId_Critica", intId_Critica) ;
                    else
                        adp.SelectCommand.Parameters.AddWithValue("@intPId_Critica", DBNull.Value);

                    adp.Fill(this.dtsBaixaVeiculacao.dtbBaixa_Critica);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxBaixaVeiculacao.sprCarregar_Critica\n" + ex.Message.ToString());
                }
                finally
                {
                    adp.Dispose();
                }
            }
            #endregion
        #endregion

        #region Atualizar
            #region spuAtualizar
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public void spuAtualizar(ref DTS.dtsBaixaVeiculacao dtsBaixaVeic)
            {
                
                try
                {
                    Cnn = new Conexao.NET.clsConexao();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                    
                    this.sprAtualizar(ref dtsBaixaVeic, Cnn.spuConnection);

                }
                catch (Exception ex)
                {
                    throw new Exception("asmxBaixaVeiculacao.spuAtualizar) " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
            }
            #endregion

            #region sprAtualizar
            private void sprAtualizar(ref DTS.dtsBaixaVeiculacao dtsBaixaVeic, SqlConnection Cnn )
            {
                SqlDataAdapter adp;
                try
                {
                    adp = new SqlDataAdapter();

                    adp.InsertCommand = (new SqlCommand("prNet_Baixa_I"));
                    adp.InsertCommand.CommandTimeout = Cnn.ConnectionTimeout;
                    adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adp.InsertCommand.Connection = Cnn;
                    adp.InsertCommand.Parameters.Add("@strP_Cod_Veiculo", SqlDbType.Char, 03, "Cod_Veiculo");
                    adp.InsertCommand.Parameters.Add("@dteP_Data_Exibicao", SqlDbType.DateTime, 01, "Data_Exibicao");
                    adp.InsertCommand.Parameters.Add("@strP_Cod_Programa", SqlDbType.Char, 04, "Cod_Programa");
                    adp.InsertCommand.Parameters.Add("@intP_Chave_Acesso", SqlDbType.SmallInt, 1, "Chave_Acesso");
                    adp.InsertCommand.Parameters.Add("@strP_Cod_Qualidade", SqlDbType.Char, 03, "Cod_Qualidade");
                    adp.InsertCommand.Parameters.Add("@dteP_Horario_Exibicao", SqlDbType.DateTime, 01, "Horario_Exibicao");
                    adp.InsertCommand.Parameters.Add("@intP_Id_Usuario", SqlDbType.Int, 1, "Id_Usuario");
                    adp.InsertCommand.Parameters.Add("@dteP_Data_Baixa", SqlDbType.DateTime, 01, "Data_Baixa");

                    adp.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord; // atualiza linha do datatable com o retorno da procedure

                    adp.Update(dtsBaixaVeic.dtbBaixa);
                }
                catch (Exception ex)
                {
                    throw new Exception("asmxBaixaVeiculacao.sprAtualizar() " + ex.Message.ToString());
                }
            }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable spuPropagaBaixaPatrocinio(String StrCodVeiculo ,
                                                    DateTime dtDataExibicao,
                                                    String strCodPrograma,
                                                    Int32 intChaveAcesso
                                                   )
        {
            DataSet dtsRetorno = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("PR_Fita_Patrocinio_Veiculacao_Consulta", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", DBNull.Value );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", DBNull.Value);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", DBNull.Value);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Comercial", DBNull.Value);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", StrCodVeiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtDataExibicao );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", strCodPrograma);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Chave_Acesso", intChaveAcesso );
                adp.Fill(dtsRetorno);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuPropagaBaixaPatrocinio" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(dtsRetorno.Tables[0]);
        }

            #endregion
        #endregion
 
    }

}