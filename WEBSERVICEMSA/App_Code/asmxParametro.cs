using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;
using System.Data;

namespace WebServiceMSA
{
    /// <summary>
    /// Summary description for asmxParametro
    /// </summary>
    public class asmxParametro : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        private DTS.dtsParametro dtsParametro;
        private Conexao.NET.clsConexao Cnn;

        public asmxParametro()
        {
            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        #region spuCarregar
        [WebMethod(MessageName = "spuCarregar_Todos"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsParametro spuCarregar()
        {
            return spuCarregar(-1, "", "", "");
        }

        [WebMethod(MessageName = "spuCarregar"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsParametro spuCarregar(int intCod_Parametro)
        {
            return spuCarregar(intCod_Parametro, "", "", "");
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public DTS.dtsParametro spuCarregar_Empresa_Faturamento(int intCod_Parametro, string strCod_Empresa_Faturamento)
        {
            return spuCarregar(intCod_Parametro, strCod_Empresa_Faturamento, "", "");
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public DTS.dtsParametro spuCarregar_Empresa_Venda(int intCod_Parametro, string strCod_Empresa)
        {
            return spuCarregar(intCod_Parametro, "", strCod_Empresa, "");
        }

        [WebMethod(MessageName = "spuCarregar_Cod_Veiculo"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsParametro spuCarregar(int intCod_Parametro, string strCod_Veiculo)
        {
            return spuCarregar(intCod_Parametro, "", "", strCod_Veiculo);
        }

        [WebMethod(MessageName = "spuCarregar_Parametro"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsParametro spuCarregar(int intCod_Parametro, string strCod_Empresa_Faturamento, string strCod_Empresa, string strCod_Veiculo)
        {
            try
            {
                Cnn = new Conexao.NET.clsConexao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                dtsParametro = new DTS.dtsParametro();

                this.sprCarregar_Parametro(intCod_Parametro, Cnn.spuConnection);
                this.sprCarregar_Parametro_Valor(intCod_Parametro, strCod_Empresa_Faturamento, strCod_Empresa, strCod_Veiculo, Cnn.spuConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxParametro.sprCarregar" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsParametro;
        }

        #endregion

        #region sprCarregar_Parametro
        private void sprCarregar_Parametro(int intCod_Parametro, SqlConnection Cnn)
        {
            SqlDataAdapter adp;

            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("prNet_Parametro_S", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (intCod_Parametro > 0)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@intPCod_Parametro", intCod_Parametro);
                }
                else
                {
                    adp.SelectCommand.Parameters.AddWithValue("@intPCod_Parametro", DBNull.Value);
                }

                adp.Fill(dtsParametro.dtbParametro);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxParametro.sprCarregar_Parametro " + ex.Message.ToString());
            }
        }
        #endregion

        #region sprCarregar_Parametro_Valor
        private void sprCarregar_Parametro_Valor(int intCod_Parametro, string strCod_Empresa_Faturamento, string strCod_Empresa, string strCod_Veiculo, SqlConnection Cnn)
        {
            SqlDataAdapter adp;

            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("prNet_Parametro_Valor_S", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (intCod_Parametro > 0)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@intPCod_Parametro", intCod_Parametro);
                }
                else
                {
                    adp.SelectCommand.Parameters.AddWithValue("@intPCod_Parametro", DBNull.Value);
                }
                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Empresa_Faturamento", (strCod_Empresa_Faturamento.Trim().Length == 0 ? null : strCod_Empresa_Faturamento));
                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Empresa_Venda", (strCod_Empresa.Trim().Length == 0 ? null : strCod_Empresa));
                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Veiculo", (strCod_Veiculo.Trim().Length == 0 ? null : strCod_Veiculo));

                adp.Fill(dtsParametro.dtbParametro_Valor);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxParametro.sprCarregar_Parametro_Valor " + ex.Message.ToString());
            }
        }
        #endregion
        #region Valor Atualizar
        [WebMethod, SoapHeader("spAuthenticationHeader")]

        public DTS.dtsParametro spuAtualizar(DTS.dtsParametro dtsParametro)
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.InsertCommand = Cnn.NewCommand("prNet_Parametro_Valor_I", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Parameters.Add("@Par_Cod_Parametro", (SqlDbType.Int), 6, "Cod_Parametro");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa_Faturamento", (SqlDbType.Char), 3, "Cod_Empresa_Faturamento");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa_Venda", (SqlDbType.Char), 3, "Cod_Empresa_Venda");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Chave", (SqlDbType.Char), 50, "Cod_Chave");


                adp.UpdateCommand = Cnn.NewCommand("prNet_Parametro_Valor_U", Cnn.spuConnection);
                adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adp.UpdateCommand.Parameters.Add("@Par_Cod_Parametro", (SqlDbType.Int), 6, "Cod_Parametro");
                adp.UpdateCommand.Parameters.Add("@Par_Cod_Empresa_Faturamento", (SqlDbType.Char), 3, "Cod_Empresa_Faturamento");
                adp.UpdateCommand.Parameters.Add("@Par_Cod_Empresa_Venda", (SqlDbType.Char), 3, "Cod_Empresa_Venda");
                adp.UpdateCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.UpdateCommand.Parameters.Add("@Par_Cod_Chave", (SqlDbType.Char), 50, "Cod_Chave");
                adp.Update(dtsParametro.dtbParametro_Valor);

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro dtsparametro.spuAtualizar" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsParametro;
        }

        #endregion
    }

}