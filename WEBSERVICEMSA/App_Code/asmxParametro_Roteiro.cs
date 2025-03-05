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
    public class asmxParametro_Roteiro : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxParametro_Roteiro()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsParametro_Roteiro Create()
        {
            DTS.dtsParametro_Roteiro dtsParametro_Roteiro = new DTS.dtsParametro_Roteiro();
            return dtsParametro_Roteiro;
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsParametro_Roteiro spuCarregar(string strCod_Veiculo)
        {
            DTS.dtsParametro_Roteiro dtsParametro_Roteiro;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsParametro_Roteiro = new DTS.dtsParametro_Roteiro();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("pr_Rsa_Parametro_Roteiro_S", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                adp.Fill(dtsParametro_Roteiro, "dtbParametro_Roteiro");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxParametro_Roteiro.spuCarregar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsParametro_Roteiro;
        }
    }
}
