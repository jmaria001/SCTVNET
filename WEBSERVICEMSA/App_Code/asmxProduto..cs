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
	public class asmxProduto : System.Web.Services.WebService
	{
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

		public asmxProduto()
		{
		}

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean IncluirProduto(Int32 IntSetor , Int32 intSegmento, String strDescricao , string strHorario,string pCliente )
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand() ;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection ;
                Cmd.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_Produto_Insert";

                Cmd.Parameters.AddWithValue("@Par_Setor", IntSetor);
                Cmd.Parameters.AddWithValue("@Par_Segmento", intSegmento );
                Cmd.Parameters.AddWithValue("@Par_Descricao", strDescricao );
                Cmd.Parameters.AddWithValue("@Par_Horario", strHorario );
                Cmd.Parameters.AddWithValue("@Par_Cliente", pCliente );
                Cmd.ExecuteNonQuery();
               return true; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message );
            }
            finally
            {
                Cnn.spuClose();
            }
        }


    }
}
