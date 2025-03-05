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
    public class asmxVeiculo : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxVeiculo()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsVeiculo Create()
        {
            return new DTS.dtsVeiculo();
        }

        [WebMethod(MessageName = "spuCarregarTudo"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsVeiculo spuCarregar()
        {
            return spuCarregar("");
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsVeiculo spuCarregar(string strCod_Veiculo)
        {
            DTS.dtsVeiculo dtsVeiculo;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsVeiculo = new DTS.dtsVeiculo();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("prNet_Veiculo_S", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@strCod_Veiculo_P", (strCod_Veiculo.Trim().Length != 0 ? strCod_Veiculo : null));

                adp.Fill(dtsVeiculo.dtbVeiculo);
                //foreach (DTS.dtsVeiculo.dtbVeiculoRow drwVeiculo in dtsVeiculo.dtbVeiculo.Rows)
                //{
                //    drwVeiculo.Descricao = drwVeiculo.Cod_Veiculo + " - " + drwVeiculo.Nome_Veiculo;
                //}

            }
            catch (Exception ex)
            {
                throw new Exception("Erro no asmxVeiculo.spuCarregar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }

            return dtsVeiculo;
        }
    }
}

