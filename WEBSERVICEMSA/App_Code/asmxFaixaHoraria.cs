using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;

namespace WebServiceMSA
{


    public class asmxFaixaHoraria : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        Conexao.NET.clsConexao Cnn;
        DTS.dtsFaixaHoraria dtsFaixaHoraria;
        public asmxFaixaHoraria()
        {
            
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsFaixaHoraria spuCarregar()
        {
            try
            {
                Cnn = new Conexao.NET.clsConexao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                dtsFaixaHoraria = new DTS.dtsFaixaHoraria();

                this.sprCarregar_FaixaHoraria(-1, Cnn.spuConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxFaixaHoraria.spuCarregar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsFaixaHoraria;
        }
        [WebMethod(MessageName = "spuCarregar_Codigo"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsFaixaHoraria spuCarregar(short intId_Faixa)
        {
            try
            {
                Cnn = new Conexao.NET.clsConexao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                dtsFaixaHoraria = new DTS.dtsFaixaHoraria();

                this.sprCarregar_FaixaHoraria(intId_Faixa, Cnn.spuConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxFaixaHoraria.spuCarregar_Codigo " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsFaixaHoraria;
        }
        private void sprCarregar_FaixaHoraria(short intId_Faixa, SqlConnection Cnn)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("prNet_Faixa_Horaria_S", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@intPid_Faixa", (intId_Faixa != -1 ? intId_Faixa.ToString() : null));
                adp.Fill(dtsFaixaHoraria.dtbFaixa_Horaria);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxFaixaHoraria.sprCarregar_FaixaHoraria " + ex.Message.ToString());
            }
        }
    }
}