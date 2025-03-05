
using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using Conexao.NET;
using System.Data.SqlClient;
using System.Data;

namespace WebServiceMSA
{

public class asmxRoteiro_Relatorios : System.Web.Services.WebService
{
      private DTS.dtsRoteiro_Relatorios dtsRoteiro_Relatorios;
      private Conexao.NET.clsConexao Cnn;

      public AuthSoapHd spAuthenticationHeader;
      public class AuthSoapHd : SoapHeader
      {
          public string strUserName;
          public string strPassword;
          public string strKey;
      }


    public asmxRoteiro_Relatorios () 
    {
     }

    [WebMethod, SoapHeader("spAuthenticationHeader")]
    public DTS.dtsRoteiro_Relatorios spuCarregarChecking(string strCod_Veiculo,
                                            DateTime   dteData_Exibicao ,
                                            string strCod_Programa,
                                            string strCod_Qualidade,
                                            Byte byIndica_Falha,
                                            Byte byIndica_Encaixado,
                                            Byte byIndica_Ordenado,
                                            Byte byIndica_Nao_Ordenado,
                                            Byte byIndica_Canceladas)
    {

        try
        {
            Cnn = new clsConexao();
            Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

            dtsRoteiro_Relatorios = new WebServiceMSA.DTS.dtsRoteiro_Relatorios();

            this.sprGeraImpressaoChecking(Cnn,
                                          strCod_Veiculo,
                                          dteData_Exibicao ,
                                          strCod_Programa,
                                          strCod_Qualidade,
                                          byIndica_Falha,
                                          byIndica_Encaixado,
                                          byIndica_Ordenado,
                                          byIndica_Nao_Ordenado,
                                          byIndica_Canceladas);
    
            this.sprCarrega_DataTableChecking(Cnn.spuConnection,dtsRoteiro_Relatorios.dtbChecking);


        }
        catch(Exception ex)
       {
				throw new Exception ("Erro spuCarregarChecking " + ex.Message.ToString());
			}
			
        finally
			{
				Cnn.spuClose();
			}

            return dtsRoteiro_Relatorios;
 
    }

    private void sprGeraImpressaoChecking(Conexao.NET.clsConexao Cnn,
                                            string strCod_Veiculo,
                                            DateTime   dteData_Exibicao ,
                                            string strCod_Programa,
                                            string strCod_Qualidade,
                                            Byte byIndica_Falha,
                                            Byte byIndica_Encaixado,
                                            Byte byIndica_Ordenado,
                                            Byte byIndica_Nao_Ordenado,
                                            Byte byIndica_Canceladas)
    {
        try
        {

            SqlCommand c = Cnn.NewCommand("SP_R0033", Cnn.spuConnection);
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.AddWithValue("@Par_Cod_Veiculo",(strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
            if (dteData_Exibicao != DateTime.MinValue)
            {
                c.Parameters.AddWithValue("@Par_Data_Exibicao",dteData_Exibicao);
            }
            c.Parameters.AddWithValue("@Par_Cod_Programa",(strCod_Programa.Length != 0 ? strCod_Programa : null));
            c.Parameters.AddWithValue("@Par_Cod_Qualidade",(strCod_Qualidade.Length != 0 ? strCod_Qualidade : null));
            c.Parameters.AddWithValue("@Par_Indica_Falha",byIndica_Falha);
            c.Parameters.AddWithValue("@Par_Indica_Encaixado", byIndica_Encaixado);
            c.Parameters.AddWithValue("@Par_Indica_Ordenado", byIndica_Ordenado);
            c.Parameters.AddWithValue("@Par_Indica_Nao_Ordenado", byIndica_Nao_Ordenado);
            c.Parameters.AddWithValue("@Par_Indica_Canceladas", byIndica_Canceladas);

            c.ExecuteNonQuery();

        }
        catch(Exception ex)
        {
            throw new Exception ("Erro na sprGeraImpressaoChecking " + ex.Message.ToString());
        }
    }

    private void sprCarrega_DataTableChecking(SqlConnection Cnn,DTS.dtsRoteiro_Relatorios.dtbCheckingDataTable dtbChecking)
    {
        SqlDataAdapter adp = new SqlDataAdapter();

        try
        {

            adp.SelectCommand = new SqlCommand("Pr_RSA_R0033", Cnn);
            adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout;
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dtbChecking);

        }
        catch (Exception ex)
        {
            throw new Exception("Erro sprCarrega_DataTableChecking" + ex.Message.ToString());
        }
    }
    
  
 
}

}