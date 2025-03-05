using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;

namespace WebServiceMSA
{
    public class asmxGrade : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        Conexao.NET.clsConexao Cnn;
        DTS.dtsGrade dtsGrade;
        public asmxGrade()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsGrade Create()
        {
            DTS.dtsGrade dtsGrade = new DTS.dtsGrade();
            return dtsGrade;
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnFuncao_Consulta_Programacao_Prevista(string sCod_Veiculo, DateTime dData, string sCod_Programa, int iTipo_Dispo)
        {
            DataSet DTS = new DataSet();
            Cnn = new Conexao.NET.clsConexao();

            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", sCod_Veiculo);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dData);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", sCod_Programa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Grade", iTipo_Dispo);
                AD.SelectCommand.CommandText = "PRNET_Consulta_Programacao_Prevista";
                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
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
        public DataSet fnFuncao_Consulta_Programacao(string sCod_Veiculo, DateTime dData_Inicio, DateTime dData_Fim, string sCod_Programa, bool bchk1, bool bchk2, bool bchk3, bool bchk4, bool bchk5, bool bchk6, bool bchk7, bool bchk8, bool bchk9, bool bchk10)
        {

            DataSet DTS = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", sCod_Veiculo);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Inicio", dData_Inicio);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Fim", dData_Fim);
                if (sCod_Programa.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", sCod_Programa);
                }
                AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Saldo_Zerado", bchk1);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Saldo_Estourado", bchk2);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Saldo_Positivo", bchk3);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Sem_Disponibilidade", bchk4);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Invasao_Espaco", bchk5);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Desativado", bchk6);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Programa", bchk7);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Local", bchk8);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Net", bchk9);
                AD.SelectCommand.CommandText = "PRNET_Consulta_Programacao";
                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
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
        public DTS.dtsGrade spuCarregar_Grade(string strCod_Veiculo, DateTime dteData_Exibicao, string strCod_Programa)
        {
            try
            {
                Cnn = new Conexao.NET.clsConexao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                dtsGrade = new DTS.dtsGrade();

                this.sprCarregar_Grade(strCod_Veiculo, dteData_Exibicao, strCod_Programa, Cnn.spuConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxGrade.spuCarregar_Grade " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsGrade;
        }
        private void sprCarregar_Grade(string strCod_Veiculo, DateTime dteData_Exibicao, string strCod_Programa, SqlConnection Cnn)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("prNet_Grade_S", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                if (dteData_Exibicao != DateTime.MinValue)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@dtePData_Exibicao", dteData_Exibicao);
                }

                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.Fill(dtsGrade.dtbGrade);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxGrade.sprCarregar_Grade " + ex.Message.ToString());
            }
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuAtualizar_Grade(DTS.dtsGrade dtsGrade)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);



                adp.UpdateCommand = Cnn.NewCommand("prNet_Grade_U", Cnn.spuConnection);
                adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adp.UpdateCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.UpdateCommand.Parameters.Add("@Par_Data_Exibicao", (SqlDbType.DateTime), 19, "Data_Exibicao");
                adp.UpdateCommand.Parameters.Add("@Par_Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
                adp.UpdateCommand.Parameters.Add("@Par_Horario_Final_Real", (SqlDbType.DateTime), 19, "Horario_Final_Real");
                adp.UpdateCommand.Parameters.Add("@Par_Horario_Inicio_Real", (SqlDbType.DateTime), 19, "Horario_Inicio_Real");

                adp.Update(dtsGrade.dtbGrade);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxGrade.spuAtualizar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }



        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuSalva_Horario_Programacao(string strCod_Veiculo,
                                          DateTime dtData_Exibicao,
                                          string strCod_Programa,
                                          DateTime dtHorario_Inicial,
                                          DateTime dtHorario_Final,
                                          string strCod_Faixa)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand sqlC;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("PR_RSA_HORARIO_PROGRAMACAO_U", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                sqlC.Parameters.AddWithValue("@Par_Veiculo", strCod_Veiculo);
                if (dtData_Exibicao != DateTime.MinValue)
                {
                    sqlC.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                }

                sqlC.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                if (dtHorario_Final != DateTime.MinValue)
                {
                    sqlC.Parameters.AddWithValue("@Par_Horario_Inicial", dtHorario_Inicial);
                }
                if (dtHorario_Final != DateTime.MinValue)
                {
                    sqlC.Parameters.AddWithValue("@Par_Horario_Final", dtHorario_Final);
                }

                sqlC.Parameters.AddWithValue("@Par_Cod_Faixa", (strCod_Faixa.Length != 0 ? strCod_Faixa : null));



                sqlC.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxGrade.spuSalva_Horario_Programacao" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable SalvarGrade(   String      PVeiculo		,
                                        String      PCod_Programa	,
                                        DateTime    PData_Inicio  ,
                                        DateTime    pData_Fim		,
                                        String      PHora_Inicio	,
                                        String      pHora_Fim		,
                                        String      PDia_Semana		,
                                        String      pFaixa_Horaria	,
                                        int         pDispo_Net		,
                                        int         pDispo_Local	,
                                        int         PDispo_Rede		,
                                        int         PDispo_Total	,
                                        String      PCod_Usuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand sqlC;
            SqlDataAdapter Adp;
            DataSet Dts;

            try
            {
                Adp = new SqlDataAdapter();
                Dts = new DataSet();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("PrNet_Grade_M", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                                    

                sqlC.Parameters.AddWithValue("@Par_Veiculo", PVeiculo);
                sqlC.Parameters.AddWithValue("@Par_Cod_Programa",PCod_Programa);
                sqlC.Parameters.AddWithValue("@Par_Data_Inicio",PData_Inicio );
                sqlC.Parameters.AddWithValue("@Par_Data_Fim",pData_Fim );
                sqlC.Parameters.AddWithValue("@Par_Hora_Inicio",PHora_Inicio );
                sqlC.Parameters.AddWithValue("@Par_Hora_Fim",pHora_Fim );
                sqlC.Parameters.AddWithValue("@Par_Dia_Semana",PDia_Semana );
                sqlC.Parameters.AddWithValue("@Par_Faixa_Horaria",pFaixa_Horaria );
                sqlC.Parameters.AddWithValue("@Par_Dispo_Net",pDispo_Net );
                sqlC.Parameters.AddWithValue("@Par_Dispo_Local",pDispo_Local );
                sqlC.Parameters.AddWithValue("@Par_Dispo_Rede",PDispo_Rede );
                sqlC.Parameters.AddWithValue("@Par_Dispo_Total",PDispo_Total );
                sqlC.Parameters.AddWithValue("@Par_Cod_Usuario",PCod_Usuario);
                Adp.SelectCommand = sqlC;
                Adp.Fill(Dts);
                

            }
            catch (Exception ex)
            {
                throw new Exception("Erro SalvarGrade" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(Dts.Tables[0]);
        }
        
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable ExcluirGrade(  String      PVeiculo		,
                                        String      PCod_Programa	,
                                        DateTime    PData_Inicio    ,
                                        DateTime    pData_Fim		,
                                        String      pDia_Semana      ,
                                        Boolean     pAgagar_Roteiro , 
                                        Boolean     pApagar_Break   ,
                                        String      PCod_Usuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand sqlC;
            SqlDataAdapter Adp;
            DataSet Dts;

            try
            {
                Adp = new SqlDataAdapter();
                Dts = new DataSet();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("PrNet_Grade_Delete", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                                    

                sqlC.Parameters.AddWithValue("@Par_Veiculo", PVeiculo);
                sqlC.Parameters.AddWithValue("@Par_Cod_Programa",PCod_Programa);
                sqlC.Parameters.AddWithValue("@Par_Data_Inicio",PData_Inicio );
                sqlC.Parameters.AddWithValue("@Par_Data_Fim",pData_Fim );
                sqlC.Parameters.AddWithValue("@Par_Dia_Semana", pDia_Semana);
                sqlC.Parameters.AddWithValue("@Par_Apagar_Roteiro",pAgagar_Roteiro);
                sqlC.Parameters.AddWithValue("@Par_Apagar_Break",pApagar_Break );
                sqlC.Parameters.AddWithValue("@Par_Cod_Usuario",PCod_Usuario);
                Adp.SelectCommand = sqlC;
                Adp.Fill(Dts);
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(Dts.Tables[0]);
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable DesativarGrade(  String    pVeiculo		,
                                        String      pCod_Programa	,
                                        DateTime    pData_Inicio    ,
                                        DateTime    pData_Fim		,
                                        String      pDia_Semana      ,
                                        Byte        pOPeracao       , 
                                        String      PCod_Usuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand sqlC;
            SqlDataAdapter Adp;
            DataSet Dts;

            try
            {
                Adp = new SqlDataAdapter();
                Dts = new DataSet();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("PrNet_Grade_Desativar", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                                    

                sqlC.Parameters.AddWithValue("@Par_Veiculo", pVeiculo);
                sqlC.Parameters.AddWithValue("@Par_Cod_Programa",pCod_Programa);
                sqlC.Parameters.AddWithValue("@Par_Data_Inicio",pData_Inicio );
                sqlC.Parameters.AddWithValue("@Par_Data_Fim",pData_Fim );
                sqlC.Parameters.AddWithValue("@Par_Dia_Semana", pDia_Semana);
                sqlC.Parameters.AddWithValue("@Par_Operacao", pOPeracao);
                sqlC.Parameters.AddWithValue("@Par_Cod_Usuario",PCod_Usuario);
                Adp.SelectCommand = sqlC;
                Adp.Fill(Dts);
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(Dts.Tables[0]);
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet  fnGrade_Exibicao(string sCod_Veiculo, Int32 Competencia ,byte Ordenacao,byte Indica_Grade)
        {
            DataSet Grade = new DataSet();
            DataTable Exibicao = new DataTable() ;
            DataTable Dados = new DataTable(); 
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.CommandText = "PrNet_Grade_Exibicao";
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", sCod_Veiculo);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Competencia", Competencia );
                AD.SelectCommand.Parameters.AddWithValue("@Par_Ordenacao", Ordenacao );
                AD.Fill(Exibicao);
                Grade.Tables.Add(Exibicao);

                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.CommandText = "PrNet_Grade_Exibicao_Dados";
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", sCod_Veiculo);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Competencia", Competencia );
                AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Grade", Indica_Grade );
                AD.Fill(Dados);
                Grade.Tables.Add(Dados);
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDts(Grade )  ;
        }

    }

}