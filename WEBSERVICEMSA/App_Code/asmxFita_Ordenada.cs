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
    public class asmxFita_Ordenada : System.Web.Services.WebService
    {
        public asmxFita_Ordenada()
        {
        }

        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }
        
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        //public DTS.dtsFitaOrdenada spuCarregar(string strCod_Veiculo, string strCod_Programa, DateTime dtData_Inicio, DateTime dtData_Fim, string strFita_Inicio, string strFita_Fim, string strEmpresa_Usuario, string strCod_Empresa, long lngNumero_Mr, short shtSequencia_Mr)
        public DataTable  spuCarregar(string strCod_Veiculo, string strCod_Programa, DateTime dtData_Inicio, DateTime dtData_Fim, string strFita_Inicio, string strFita_Fim, string strEmpresa_Usuario, string strCod_Empresa, long lngNumero_Mr, short shtSequencia_Mr)
        {
            //DTS.dtsFitaOrdenada dtsFitaOrdenada;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dtbRetorno =  new DataTable("dtbRetorno");
            try
            {
                //dtsFitaOrdenada = new DTS.dtsFitaOrdenada();
             
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                
                       
                adp.SelectCommand = Cnn.NewCommand("Sp_Ru_Fita_Ordenada", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                if (dtData_Inicio != DateTime.MinValue)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Inicio", dtData_Inicio);
                }
                if (dtData_Fim != DateTime.MinValue)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Fim", dtData_Fim);
                }

                adp.SelectCommand.Parameters.AddWithValue("@Par_Fita_Inicio", (strFita_Inicio.Length != 0 ? strFita_Inicio : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Fita_Fim", (strFita_Fim.Length != 0 ? strFita_Fim : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Empresa_Usuario", (strEmpresa_Usuario .Length != 0 ? strEmpresa_Usuario: null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", (strCod_Empresa.Trim().Length  != 0 ? strCod_Empresa : null));
                if (lngNumero_Mr != -1)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", lngNumero_Mr);
                }

                if (shtSequencia_Mr != -1)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", shtSequencia_Mr);
                }

                adp.Fill(dtbRetorno);
                
        
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxFita_Ordenada.spuCarregar" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtbRetorno;
            
        }

    }
}
