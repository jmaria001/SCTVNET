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
    public class asmxRoteiro : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxRoteiro()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] public DTS.dtsRoteiro Create()
        {
            DTS.dtsRoteiro dtsRoteiro = new  DTS.dtsRoteiro();
            return dtsRoteiro;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuAtualizaRoteiro_Fechamento(DTS.dtsRoteiro dtsRoteiro)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.InsertCommand = Cnn.NewCommand("PR_RSA_Roteiro_Fechamento_I", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Connection = Cnn.spuConnection;
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.InsertCommand.Parameters.Add("@Par_Data_Exibicao", (SqlDbType.DateTime), 19, "Data");
                adp.InsertCommand.Parameters.Add("@Par_Indica_Fechamento_Artistico", (SqlDbType.TinyInt), 1, "Indica_Fechamento_Artistico");
                adp.InsertCommand.Parameters.Add("@Indica_Fechamento_Comercial", (SqlDbType.TinyInt), 1, "Indica_Fechamento_Comercial");


                adp.UpdateCommand = Cnn.NewCommand("PR_RSA_Roteiro_Fechamento_U", Cnn.spuConnection);
                adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adp.UpdateCommand.Connection = Cnn.spuConnection;
                adp.UpdateCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.UpdateCommand.Parameters.Add("@Par_Data_Exibicao", (SqlDbType.DateTime), 19, "Data");
                adp.UpdateCommand.Parameters.Add("@Par_Indica_Fechamento_Artistico", (SqlDbType.TinyInt), 1, "Indica_Fechamento_Artistico");
                adp.UpdateCommand.Parameters.Add("@Indica_Fechamento_Comercial", (SqlDbType.TinyInt), 1, "Indica_Fechamento_Comercial");


                adp.Update(dtsRoteiro.dtbRoteiro_Fechamento);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuAtualizaRoteiro_Fechamento " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro spuCarregaRoteiro_Fechamento(string strCod_Veiculo, DateTime dtData_Exibicao)
        {
            DTS.dtsRoteiro dtsRoteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro = new DTS.dtsRoteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("PR_RSA_Roteiro_Fechamento_S", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                if (dtData_Exibicao != DateTime.MinValue)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                }


                adp.Fill(dtsRoteiro.dtbRoteiro_Fechamento);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuCarregaRoteiro_Fechamento" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro spuCarregar_Guia(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa)
        {
            DTS.dtsRoteiro dtsRoteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro = new DTS.dtsRoteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Pr_Rsa_Roteiro_Guia_S", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.Fill(dtsRoteiro, "dtsRoteiro_Guia"); 
            }
            catch (Exception ex) 
            {
                throw new Exception("Erro asmxRoteiro.spuCarregar_Guia " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro spuCarregar_Roteiro(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa, byte btIndica_Relatorio, byte btIndica_Ordenacao)
        {
            DTS.dtsRoteiro dtsRoteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro = new DTS.dtsRoteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("pr_RSA_Carrega_Roteiro", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Indica_Relatorio", btIndica_Relatorio);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Ordenacao", btIndica_Ordenacao); 
                adp.Fill(dtsRoteiro, "dtbRoteiro_Ordenado");
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuCarregar_Roteiro " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro spuCarregar_Comerciais(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa)
       {
            DTS.dtsRoteiro dtsRoteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro = new DTS.dtsRoteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("PR_RSA_Carrega_Comerciais", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.Fill(dtsRoteiro, "dtbRoteiro_Comerciais");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuCarregar_Comerciais" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro spuCarregar_Rotativo(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa, byte btTipo_Chamada)
        {
            DTS.dtsRoteiro dtsRoteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro = new DTS.dtsRoteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("PR_RSA_Carrega_Rotativo", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Tipo_Chamada", btTipo_Chamada);
                adp.Fill(dtsRoteiro, "dtbRoteiro_Rotativo");
            }
            catch (Exception ex)
            { 
                throw new Exception("Erro asmxRoteiro.spuCarregar_Rotativo " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro spuCarregar_Depositorio(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa, byte btTipo)
        {
            DTS.dtsRoteiro dtsRoteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro = new DTS.dtsRoteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("PR_RSA_Carrega_Depositorio", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Tipo", btTipo);
                adp.Fill(dtsRoteiro, "dtbRoteiro_Depositorio");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuCarregar_Depositorio" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro_Consulta_Veiculacao spuCarregar_ConsultaVeiculacao(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa, string strCod_Qualidade, short btNet, short btBaixado, short btOrdenado)
        {
            DTS.dtsRoteiro_Consulta_Veiculacao dtsRoteiro_Consulta_Veiculacao;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro_Consulta_Veiculacao = new DTS.dtsRoteiro_Consulta_Veiculacao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Sp_Consulta_Veiculacao_Roteiro", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", DateTime.Parse(dtData_Exibicao.ToShortDateString()));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Qualidade", (strCod_Qualidade.Length != 0 ? strCod_Qualidade : null));
                if (btNet != -1)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Net", btNet);
                }

                if (btBaixado != -1)
                {
                adp.SelectCommand.Parameters.AddWithValue("@Par_Baixado", btBaixado);
                }
                if (btOrdenado != -1)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Ordenado", btOrdenado);
                }
               adp.Fill(dtsRoteiro_Consulta_Veiculacao, "dtbRoteiro_Consulta_Veiculacao");
         }

            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuCarregar_ConsultaVeiculacao" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro_Consulta_Veiculacao;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuGravar_Roteiro_Temp(ref DTS.dtsRoteiro dtsRoteiro)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
              {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.InsertCommand = Cnn.NewCommand("PR_RSA_Roteiro_I", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Connection = Cnn.spuConnection;
                adp.InsertCommand.Parameters.Add("@Par_Id_Processo", (SqlDbType.Char ), 50, "Id_Processo");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.InsertCommand.Parameters.Add("@Par_Data_Exibicao", (SqlDbType.DateTime), 18, "Data_Exibicao");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
                adp.InsertCommand.Parameters.Add("@Par_Breaks", (SqlDbType.SmallInt), 4, "Breaks");
                adp.InsertCommand.Parameters.Add("@Par_Sequencia_Faixa", (SqlDbType.TinyInt), 4, "Sequencia_Faixa");
                adp.InsertCommand.Parameters.Add("@Par_Sequencia_Intervalo", (SqlDbType.SmallInt), 4, "Sequencia_Intervalo");
                adp.InsertCommand.Parameters.Add("@Par_Tipo_Break", (SqlDbType.TinyInt), 4, "Tipo_Break");
                adp.InsertCommand.Parameters.Add("@Par_IDChave", (SqlDbType.Int), 4, "IDChave");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.InsertCommand.Parameters.Add("@Par_Chave_Acesso", (SqlDbType.SmallInt), 4, "Chave_Acesso");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", (SqlDbType.Char), 3, "Cod_Empresa");
                adp.InsertCommand.Parameters.Add("@Par_Numero_MR", (SqlDbType.Int), 10, "Numero_MR");
                adp.InsertCommand.Parameters.Add("@Par_Sequencia_MR", (SqlDbType.SmallInt), 4, "Sequencia_MR");
                adp.InsertCommand.Parameters.Add("@Par_Duracao", (SqlDbType.Int), 4, "Duracao");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Comercial", (SqlDbType.Char), 2, "Cod_Comercial");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Programa_Origem", (SqlDbType.Char), 4, "Cod_Programa_Origem");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo_Origem", (SqlDbType.Char), 3, "Cod_Veiculo_Origem");
                adp.InsertCommand.Parameters.Add("@Par_Origem", (SqlDbType.TinyInt), 2, "Origem");
                adp.InsertCommand.Parameters.Add("@Par_Versao", (SqlDbType.TinyInt), 2, "Versao");
                adp.InsertCommand.Parameters.Add("@Par_Indica_Espaco_Artistico", (SqlDbType.Bit ), 1, "Indica_Espaco_Artistico");
                               
                adp.Update(dtsRoteiro.dtbTbRSA_Roteiro);


            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuGravar_Roteiro_Temp" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }



        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] public string spuGetId() 
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlDataReader sqlR;
            SqlCommand sqlC;
            string  Id_Processo = "";
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("select Convert(char(50),newid()) as coluna", Cnn.spuConnection);
                sqlR = sqlC.ExecuteReader();
                sqlR.Read();
                if (sqlR.HasRows)
                {
                    Id_Processo = sqlR.GetString(sqlR.GetOrdinal("coluna"));
                }
                sqlR.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuGetId" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return(Id_Processo) ;

        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro spuSalvar_Roteiro(string strId_Processo, string strCod_Usuario)  
        {
            DTS.dtsRoteiro dtsRoteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro = new DTS.dtsRoteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("pr_RSA_Controle_Salva", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Id_Processo", strId_Processo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Usuario", strCod_Usuario);

                adp.Fill(dtsRoteiro, "dtbRoteiro_Critica");
             }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuSalvar_Roteiro();" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro ;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean spuCheckEncerramento(string strCod_Veiculo, DateTime dtData_Exibicao)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader sqlR;
            SqlCommand sqlC;
            Boolean  indica_encerrado = false ;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("PR_RSA_Check_Encerramento", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                sqlC.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                sqlC.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                sqlR = sqlC.ExecuteReader();
                sqlR.Read();
                if (sqlR.HasRows)
                {
                    indica_encerrado  = sqlR.GetBoolean(sqlR.GetOrdinal("Indica_Encerrado"));
                }
                sqlR.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuCheckEncerramento" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return (indica_encerrado);
           }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuReabrirRoteiro(string strCod_Veiculo, DateTime dtData_Exibicao)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            //SqlDataReader sqlR;
            SqlCommand sqlC;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("PR_RSA_Roteiro_Reabrir", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                sqlC.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                sqlC.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                sqlC.ExecuteNonQuery(); 
                //sqlR = sqlC.ExecuteReader();
                //sqlR.Read();
                //if (sqlR.HasRows)
                //{
                 //   indica_encerrado = sqlR.GetBoolean(sqlR.GetOrdinal("Indica_Encerrado"));
                //}
                //sqlR.Close();
              }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuReabrirRoteiro" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
       }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuPreOrdenacao(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa, byte btIndica_Rotativo, byte btIndica_Vinheta)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            //SqlDataReader sqlR;
            SqlCommand sqlC;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("SP_RU_Pre_Ordenacao", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                sqlC.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                sqlC.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                if (strCod_Programa.Length > 0)
                {
                    sqlC.Parameters.AddWithValue("@Par_Cod_Programa", strCod_Programa);
                }
                                sqlC.Parameters.AddWithValue("@Par_Indica_Rotativo", btIndica_Rotativo);
                sqlC.Parameters.AddWithValue("@Par_Indica_Vinheta", btIndica_Vinheta);




                sqlC.ExecuteNonQuery();
                
                //sqlR = sqlC.ExecuteReader();
                //sqlR.Read();
                //if (sqlR.HasRows)
                //{
                //   indica_encerrado = sqlR.GetBoolean(sqlR.GetOrdinal("Indica_Encerrado"));
                //}
                //sqlR.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuReabrirRoteiro" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiro spuCarregaRoteiro_Programa(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa)
        {
            DTS.dtsRoteiro dtsRoteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiro = new DTS.dtsRoteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Sp_Roteiro_Afiliadas_Programa", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                if (dtData_Exibicao != DateTime.MinValue)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                }
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));

                adp.Fill(dtsRoteiro.dtbRoteiro_Programa);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuCarregaRoteiro_Programa" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiro;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuRoteiro_Replicacao(string strCod_Veiculo_Origem, string strCod_Veiculo_Destino, DateTime dtData_Exibicao, string strCod_Programa)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand sqlC;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("Sp_Roteiro_Afiliadas_Replicacao", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                sqlC.Parameters.AddWithValue("@Par_Veiculo_Origem", strCod_Veiculo_Origem);
                sqlC.Parameters.AddWithValue("@Par_Veiculo_Destino", strCod_Veiculo_Destino);
                sqlC.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);   
                sqlC.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa:null));


                sqlC.ExecuteNonQuery();

                      }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuRoteiro_Replicacao" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean  spuBaixaRoteiroOrdenado(string pVeiculo, DateTime  pData, string pPrograma,string pLinhaBreak, string pLinhaHorarioBreak, string pLinhaPrograma, string pLinhaChaveAcesso,string pLinhaHorarioVeiculacao)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand sqlC;
            Boolean bolRetorno = true;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("Sp_Baixa_BreaK", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                sqlC.Parameters.AddWithValue("@Par_Cod_Veiculo",pVeiculo);
                sqlC.Parameters.AddWithValue("@Par_Data_Exibicao",pData );
                sqlC.Parameters.AddWithValue("@Par_Cod_Programa",pPrograma);
                sqlC.Parameters.AddWithValue("@Par_Break",pLinhaBreak );
                sqlC.Parameters.AddWithValue("@Par_Horario",pLinhaHorarioBreak );
                sqlC.Parameters.AddWithValue("@Par_Programa_Veiculacao",pLinhaPrograma );
                sqlC.Parameters.AddWithValue("@Par_Chave_Acesso",pLinhaChaveAcesso );
                sqlC.Parameters.AddWithValue("@Par_Horario_Veiculacao", pLinhaHorarioVeiculacao);
                sqlC.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                bolRetorno = false;
                throw new Exception("Erro asmxRoteiro.spuRoteiro_Replicacao" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return bolRetorno;
        }
           
    }
}
