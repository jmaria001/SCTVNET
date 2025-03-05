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
public class asmxBreak : System.Web.Services.WebService
{
    public AuthSoapHd spAuthenticationHeader;
    public class AuthSoapHd : SoapHeader
    {
        public string strUserName;
        public string strPassword;
        public string strKey;
    }

    public asmxBreak()
    {

    }
    [WebMethod, SoapHeader("spAuthenticationHeader")]
    public DTS.dtsBreak Create()
    {
        DTS.dtsBreak dtsBreak = new DTS.dtsBreak();
        return dtsBreak;
        
    }


#region Carregar
[WebMethod, SoapHeader("spAuthenticationHeader")]
public DTS.dtsBreak spuCarregar_Mensagem_Exclusao_Break(string strCod_Veiculo, DateTime  dtData_Exibicao)
{
    DTS.dtsBreak dtsBreak;
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataAdapter adp = new SqlDataAdapter();
    try
    {
        dtsBreak = new DTS.dtsBreak();
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
        adp.SelectCommand = Cnn.NewCommand("PR_RSA_Break_Alerta_Exclusao_S", Cnn.spuConnection);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao );
        adp.Fill(dtsBreak, "dtbMensagem_Exclusao_Roteiro");
    }
    catch (Exception ex)
    {
        throw new Exception("Erro asmxBreak.spuCarregar_Mensagem_Exclusao_Break " + ex.Message.ToString());
    }
    finally
    {
        Cnn.spuClose();
    }
    return dtsBreak;
}


[WebMethod, SoapHeader("spAuthenticationHeader")]
public DTS.dtsBreak spuCarregar_Break(string strCod_Veiculo, DateTime dtData_Exibicao,string str_CodPrograma)
{
    DTS.dtsBreak dtsBreak;
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataAdapter adp = new SqlDataAdapter();
    try
    {
        dtsBreak = new DTS.dtsBreak();
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

        adp.SelectCommand = Cnn.NewCommand("PR_RSA_BREAK_S", Cnn.spuConnection);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.SelectCommand.Parameters.AddWithValue("@PAR_COD_VEICULO", strCod_Veiculo);
        adp.SelectCommand.Parameters.AddWithValue("@PAR_DATA_EXIBICAO", dtData_Exibicao);
        adp.SelectCommand.Parameters.AddWithValue("@PAR_COD_PROGRAMA", str_CodPrograma);
        adp.Fill(dtsBreak.dtbBreak);
    }
    catch (Exception ex)
    {
        throw new Exception("Erro asmxBreak.spuCarregar_Break " + ex.Message.ToString());
    }
    finally
    {
        Cnn.spuClose();
    }
    return dtsBreak;
}
#endregion 
#region Atualizar
[WebMethod, SoapHeader("spAuthenticationHeader")]
public void spuAtualizar_Mensagem_Exclusao_Break(DTS.dtsBreak dtsBreak)
{
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataAdapter adp = new SqlDataAdapter();
    try
    {
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
        adp.UpdateCommand.CommandTimeout = 0;
        adp.UpdateCommand = Cnn.NewCommand("PR_RSA_Break_Alerta_Exclusao_U", Cnn.spuConnection);
        adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
        adp.UpdateCommand.Connection = Cnn.spuConnection;
        adp.UpdateCommand.Parameters.Add("@Par_Id", SqlDbType.Int, 6, "id_Exclusao_Roteiro");
        adp.UpdateCommand.Parameters.Add("@Par_Indica_Desativado", SqlDbType.TinyInt, 1, "Indica_Desativado");
        adp.UpdateCommand.Parameters.Add("@Par_Data_Visto", SqlDbType.DateTime, 19, "Data_Visto");
        adp.UpdateCommand.Parameters.Add("@Par_Visto_Usuario", SqlDbType.Char, 30, "Visto_Usuario");
        adp.Update(dtsBreak.dtbMensagem_Exclusao_Roteiro);
    }
    catch (Exception ex)
    {
        throw new Exception("Erro asmxBreak.spuCarregar_Mensagem_Exclusao_Break " + ex.Message.ToString());
    }
    finally
    {
        Cnn.spuClose();
    }
    //return dtsBreak;
}

#endregion
#region Carregar Break Desconsiderado

[WebMethod, SoapHeader("spAuthenticationHeader")]
public DTS.dtsBreak spuCarregar_BreakDesconsiderado(string strCod_Veiculo, DateTime dtData_Exibicao,string strCod_Programa)
{
    DTS.dtsBreak dtsBreak;
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataAdapter adp = new SqlDataAdapter();
    try
    {
        dtsBreak = new DTS.dtsBreak();
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

        adp.SelectCommand = Cnn.NewCommand("Sp_Break_Desconsiderado", Cnn.spuConnection);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", strCod_Programa);
        adp.Fill(dtsBreak.dtbBreak_Desconsiderado);
    }
    catch (Exception ex)
    {
        throw new Exception("Erro asmxBreak.spuCarregar_BreakDesconsiderado " + ex.Message.ToString());
    }
    finally
    {
        Cnn.spuClose();
    }
    return dtsBreak;
}

#endregion
#region Grava Break Desconsiderado

[WebMethod, SoapHeader("spAuthenticationHeader")]
public DTS.dtsBreak spuGravar_BreakDesconsiderado(  string strCod_Veiculo, 
                                                    DateTime dtData_Exibicao,
                                                    string strCod_Programa, 
                                                    string strDiaSemana,
                                                    string strBreak,
                                                    DateTime dtDataInicio,
                                                    DateTime dtDataFim )
{
    DTS.dtsBreak dtsBreak;
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataAdapter adp = new SqlDataAdapter();
    try
    {
        dtsBreak = new DTS.dtsBreak();
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
        adp.SelectCommand = Cnn.NewCommand("Sp_Roteiro_Afiliadas_Grava_Break_Desconsiderado", Cnn.spuConnection);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", strCod_Programa);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Dia_Semana", strDiaSemana);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Break", strBreak);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Inicio", dtDataInicio);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Final", dtDataFim);
        adp.Fill(dtsBreak.dtbCritica_BreakDesconsiderado);
    }
    catch (Exception ex)
    {
        throw new Exception("Erro asmxBreak.spuGravar_BreakDesconsiderado " + ex.Message.ToString());
    }
    finally
    {
        Cnn.spuClose();
    }
    return dtsBreak;
}
#endregion
#region GravarBreakTemp
[WebMethod, SoapHeader("spAuthenticationHeader")]
public void spuGravar_Break_Temp(ref DTS.dtsBreak dtsBreak)
{
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataAdapter adp = new SqlDataAdapter();
    try
    {
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
        adp.InsertCommand = Cnn.NewCommand("PR_RSA_Break_I", Cnn.spuConnection);
        adp.InsertCommand.CommandType = CommandType.StoredProcedure;
        adp.InsertCommand.Connection = Cnn.spuConnection;
        adp.InsertCommand.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
        adp.InsertCommand.Parameters.Add("@Par_Id_Processo", (SqlDbType.Char), 50, "Id_Processo");
        adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
        adp.InsertCommand.Parameters.Add("@Par_Data_Exibicao", (SqlDbType.DateTime), 18, "Data_Exibicao");
        adp.InsertCommand.Parameters.Add("@Par_Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
        adp.InsertCommand.Parameters.Add("@Par_Breaks", (SqlDbType.TinyInt), 2, "Breaks");
        adp.InsertCommand.Parameters.Add("@Par_Sequencia_Faixa", (SqlDbType.TinyInt),2, "Sequencia_Faixa");
        adp.InsertCommand.Parameters.Add("@Par_Duracao", (SqlDbType.SmallInt), 4, "Duracao");
        adp.InsertCommand.Parameters.Add("@Par_Hora_Inicio", (SqlDbType.NVarChar), 30, "Hora_Inicio");  
        adp.InsertCommand.Parameters.Add("@Par_Tipo_Break", (SqlDbType.TinyInt), 2, "Tipo_Break");
        adp.InsertCommand.Parameters.Add("@Par_Titulo_BreaK", (SqlDbType.Char), 30, "Titulo_BreaK");
        adp.InsertCommand.Parameters.Add("@Par_Sequencia_Break", (SqlDbType.Int), 4, "Sequencia_Break");
        adp.InsertCommand.Parameters.Add("@Par_Observacao", (SqlDbType.Char), 60, "Observacao");
        adp.InsertCommand.Parameters.Add("@Par_Sequencia", (SqlDbType.TinyInt), 2, "Sequencia");
        adp.InsertCommand.Parameters.Add("@Par_Rodape_Inter", (SqlDbType.Char), 60, "Rodape_Inter");
        adp.InsertCommand.Parameters.Add("@Par_Data_Inicio", (SqlDbType.DateTime), 18, "Data_Inicio");
        adp.InsertCommand.Parameters.Add("@Par_Data_Final", (SqlDbType.DateTime), 18, "Data_Final");
        adp.InsertCommand.Parameters.Add("@Par_Grava_Rodape", (SqlDbType.TinyInt), 2, "Grava_Rodape");


        adp.Update(dtsBreak.dtbTBRSA_BREAK);


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
#endregion
#region Salvar
[WebMethod, SoapHeader("spAuthenticationHeader")]
public DTS.dtsBreak spuSalvar_Break(string strCod_Veiculo,
                                    DateTime dteData_Exibicao,
                                    string strCod_Programa, 
                                    string strDia_Semana,
                                    string strRodape_Inter,
                                    DateTime dteData_Inicio,
                                    DateTime dteData_Final,
                                    Byte byGrava_Rodape,    
                                    string strId_Processo)
{
    DTS.dtsBreak dtsBreak;
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataAdapter adp = new SqlDataAdapter();
    try
    {
        dtsBreak = new DTS.dtsBreak();
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
        adp.SelectCommand = Cnn.NewCommand("PR_RSA_Composicao_Break", Cnn.spuConnection);
        adp.SelectCommand.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
       
        if (dteData_Exibicao.Date != DateTime.MinValue)
        {
            adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dteData_Exibicao);
        }
       
        adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa",( strCod_Programa.Length != 0 ? strCod_Programa : null));
        adp.SelectCommand.Parameters.AddWithValue("@Par_Dia_Semana", (strDia_Semana.Length != 0 ? strDia_Semana : null));
        adp.SelectCommand.Parameters.AddWithValue("@Par_Rodape_Inter", (strRodape_Inter.Length != 0 ? strRodape_Inter : null));
        if (dteData_Inicio.Date != DateTime.MinValue)
        {
             adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Inicio", dteData_Inicio);
        }
       
        if (dteData_Final.Date != DateTime.MinValue)
        {
             adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Final", dteData_Final);
        }
        
        adp.SelectCommand.Parameters.AddWithValue("@Par_Grava_Rodape", byGrava_Rodape);
        adp.SelectCommand.Parameters.AddWithValue("@Par_Id_Processo", strId_Processo);
        

        adp.Fill(dtsBreak.dtbCritica_Break);
    }
    catch (Exception ex)
    {
        throw new Exception("Erro asmxBreak.spuSalvar_Break();" + ex.Message.ToString());
    }
    finally
    {
        Cnn.spuClose();
    }
    return dtsBreak;
}
#endregion
#region ExisteRoteiro
[WebMethod, SoapHeader("spAuthenticationHeader")]
public Boolean spuExisteRoteiro(string strCod_Veiculo,
                            DateTime dtData_Exibicao,
                            string strCod_Programa,
                            Byte byBreaks,
                            Byte bySequencia_Faixa)
{
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataReader sqlR;
    SqlCommand sqlC;    
    Boolean ExisteRoteiro ;
    try
    {
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
        sqlC = Cnn.NewCommand("PR_RSA_BREAK_EXISTEROTEIRO", Cnn.spuConnection);
        sqlC.CommandType = CommandType.StoredProcedure;
        sqlC.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
        if (dtData_Exibicao.Date != DateTime.MinValue)
        {
            sqlC.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
        }
       
        sqlC.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
        if (byBreaks.ToString().Length != 0)
        {
            sqlC.Parameters.AddWithValue("@Par_Breaks", byBreaks);
        }
        if (bySequencia_Faixa.ToString().Length != 0)
        {
            sqlC.Parameters.AddWithValue("@Par_Sequencia_Faixa", bySequencia_Faixa);
        }
  
        sqlR = sqlC.ExecuteReader();

        sqlR.Read() ;
        if (sqlR.HasRows)
        {
            ExisteRoteiro = true;
        }
        else
        {
            ExisteRoteiro = false;
        }
        sqlR.Close();


    }
    catch (Exception ex)
    {
        throw new Exception("Erro asmxRoteiro.spuExisteRoteiro" + ex.Message.ToString());
    }
    finally
    {
        Cnn.spuClose();
    }
    return (ExisteRoteiro);
}
#endregion
#region UltimaDataComposta
[WebMethod, SoapHeader("spAuthenticationHeader")]
public DateTime spuUltimaDataComposta(string strCod_Veiculo,
                                      string strCod_Programa
                                        )
{
    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
    SqlDataReader sqlR;
    SqlCommand sqlC;
    DateTime  UltimaData;
    try
    {
        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
        sqlC = Cnn.NewCommand("PR_RSA_UltimaDataComposta", Cnn.spuConnection);
        sqlC.CommandType = CommandType.StoredProcedure;
        sqlC.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
         sqlC.Parameters.AddWithValue("@Par_Cod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
   
        sqlR = sqlC.ExecuteReader();

        sqlR.Read();
        UltimaData = sqlR.GetDateTime(0);
     
        sqlR.Close();


    }
    catch (Exception ex)
    {
        throw new Exception("Erro asmxRoteiro.spuUltimaDataComposta" + ex.Message.ToString());
    }
    finally
    {
        Cnn.spuClose();
    }
    return (UltimaData);
}
#endregion

}
}
