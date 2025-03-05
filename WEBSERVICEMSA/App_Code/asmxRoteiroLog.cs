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
    public class asmxRoteiroLog : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxRoteiroLog()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiroLog Create()
        {
            DTS.dtsRoteiroLog DtsRoteiroLog = new DTS.dtsRoteiroLog();
            return DtsRoteiroLog;
        }

        
#region GgravarLog
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuGravar_Roteiro_Log(ref DTS.dtsRoteiroLog dtsRoteiroLog)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.InsertCommand = Cnn.NewCommand("PR_RSA_RoteiroLog_I", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Connection = Cnn.spuConnection;
                //adp.InsertCommand.Parameters.Add("@Par_Codigo", (SqlDbType.Integer), 4, "Codigo");
                //adp.InsertCommand.Parameters.Add("@Par_Codigo", (SqlDbType.Int), 4, "Codigo");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.InsertCommand.Parameters.Add("@Par_Data_Exibicao", (SqlDbType.DateTime), 8, "Data_Exibicao");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Comercial", (SqlDbType.Char), 2, "Cod_Comercial");
                adp.InsertCommand.Parameters.Add("@Par_Breaks", (SqlDbType.TinyInt), 1, "Breaks");
                adp.InsertCommand.Parameters.Add("@Par_Tipo", (SqlDbType.TinyInt), 1, "Tipo");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.InsertCommand.Parameters.Add("@Par_Titulo_Comercial", (SqlDbType.NVarChar), 400, "Titulo_Comercial");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", (SqlDbType.Char), 3, "Cod_Empresa");
                adp.InsertCommand.Parameters.Add("@Par_Numero_MR", (SqlDbType.Int), 4, "Numero_MR");
                adp.InsertCommand.Parameters.Add("@Par_Sequencia_MR", (SqlDbType.SmallInt), 2, "Sequencia_MR");
                adp.InsertCommand.Parameters.Add("@Par_Chave_Acesso", (SqlDbType.SmallInt), 2, "Chave_Acesso");
                adp.InsertCommand.Parameters.Add("@Par_Usuario", (SqlDbType.Char), 30, "Usuario");
                adp.InsertCommand.Parameters.Add("@Par_Data", (SqlDbType.DateTime), 8, "Data");
                adp.InsertCommand.Parameters.Add("@Par_Hora", (SqlDbType.Char), 10, "Hora");
                adp.InsertCommand.Parameters.Add("@Par_Operacao", (SqlDbType.NVarChar), 400, "Operacao");
                adp.InsertCommand.Parameters.Add("@Par_Programa", (SqlDbType.NVarChar), 200, "Programa");
                adp.Update(dtsRoteiroLog.dtbRoteiroLog);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiro.spuGravar_Roteiro_Log" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            
        }
#endregion
#region CarregaLog
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRoteiroLog spuCarregaLog( string   strCod_Veiculo ,
	                            DateTime dteData_Exibicao ,
	                            string   strCod_Programa,
	                            string   strCod_Comercial,
	                            short    shBreaks,
	                            string   strNumero_Fita ,
	                            string   strCod_Empresa ,
	                            int      intNumero_MR ,
	                            int      intSequencia_MR,
	                            string   strUsuario ,
	                            string   strOperacao)
        {
             DTS.dtsRoteiroLog dtsRoteiroLog;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRoteiroLog = new DTS.dtsRoteiroLog();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Pr_RSA_Carrega_RoteiroLog", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                if (dteData_Exibicao != DateTime.MinValue)
                {
                     adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dteData_Exibicao);
                }
                
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Comercial", (strCod_Comercial.Length != 0 ? strCod_Comercial : null));
                if (shBreaks != -1)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Breaks", shBreaks);
                }
               
                adp.SelectCommand.Parameters.AddWithValue("@Par_NrFita", (strNumero_Fita.Length != 0 ? strNumero_Fita : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", (strCod_Empresa.Length != 0 ? strCod_Empresa : null));
                if (intNumero_MR != -1)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_MR", intNumero_MR);
                }
                if (intSequencia_MR != -1)
                { 
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_MR", intSequencia_MR);
                }
                adp.SelectCommand.Parameters.AddWithValue("@Par_Usuario", (strUsuario.Length != 0 ? strUsuario : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Operacao", (strOperacao.Length != 0 ? strOperacao : null));

                adp.Fill(dtsRoteiroLog.dtbConsultaLog);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRoteiroLog.spuCarregaLog" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRoteiroLog;	
         }



        #endregion
 
    }
}

 