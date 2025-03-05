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

    public class asmxPorta : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        
       // DTS.dtsPorta dtsPorta = new DTS.dtsPorta();
        public asmxPorta()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsPorta Create() 
        {
            DTS.dtsPorta dtsPorta = new DTS.dtsPorta();
            return dtsPorta; 
        }

                #region Carregar
                [WebMethod, SoapHeader("spAuthenticationHeader")]
                public DTS.dtsPorta spuCarregar(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa)
                {
                    DTS.dtsPorta dtsPorta;
                    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    try
                    {
                        dtsPorta = new DTS.dtsPorta();
                        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                        adp.SelectCommand = Cnn.NewCommand("PR_RSA_Porta_S", Cnn.spuConnection);
                        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                        if (dtData_Exibicao != DateTime.MinValue)
                        {
                            adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                        }
                        if (strCod_Programa.Length != 0)
                        {
                            adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", strCod_Programa);
                        }
                        adp.Fill(dtsPorta, "dtbPorta");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro asmxPorta.spuCarregar" + ex.Message.ToString());
                    }
                    finally
                    {
                        Cnn.spuClose();
                    }
                    return dtsPorta;
                }
                #endregion
        
                #region Atualizar
                [WebMethod, SoapHeader("spAuthenticationHeader")]
                public void spuAtualizar(ref DTS.dtsPorta dtsPorta)
                {
                    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    try
                    {
                        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                        adp.InsertCommand = Cnn.NewCommand("PR_RSA_Porta_I", Cnn.spuConnection);
                        adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                        adp.InsertCommand.Connection = Cnn.spuConnection;
                        adp.InsertCommand.Parameters.Add("@Par_Funcao", (SqlDbType.SmallInt), 6, "funcao");
                        adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                        adp.InsertCommand.Parameters.Add("@Par_Data", (SqlDbType.DateTime), 19, "Data");
                        adp.InsertCommand.Parameters.Add("@Par_Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
                        adp.InsertCommand.Parameters.Add("@Par_Cod_Usuario", (SqlDbType.Char), 30, "Usuario");

                        adp.DeleteCommand = Cnn.NewCommand("Pr_RSA_Porta_D", Cnn.spuConnection);
                        adp.DeleteCommand.CommandType = CommandType.StoredProcedure;
                        adp.DeleteCommand.Connection = Cnn.spuConnection;
                        adp.DeleteCommand.Parameters.Add("@Par_Funcao", (SqlDbType.SmallInt), 6, "funcao");
                        adp.DeleteCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                        adp.DeleteCommand.Parameters.Add("@Par_Data", (SqlDbType.DateTime), 19, "Data");
                        adp.DeleteCommand.Parameters.Add("@Par_Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
                        adp.DeleteCommand.Parameters.Add("@Par_Cod_Usuario", (SqlDbType.Char), 30, "Usuario");
     

                        adp.Update(dtsPorta.dtbPorta);


                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro asmxPorta.spuAtualizar" + ex.Message.ToString());
                    }
                    finally
                    {
                        Cnn.spuClose();
                    }



                }
        #endregion
                #region Limpar

                [WebMethod, SoapHeader("spAuthenticationHeader")]
                public void spuLimpar(int intFuncao, String strUsuario)
                {
                    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                    SqlCommand com = Cnn.NewCommand();
                    try
                    {
                        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                        com.CommandText = "Pr_RSA_Porta_Limpar";
                        com.CommandType = CommandType.StoredProcedure;
                        com.Connection = Cnn.spuConnection;
                        com.Parameters.AddWithValue("@Par_Funcao", intFuncao);
                        com.Parameters.AddWithValue("@Par_Usuario", strUsuario);

                        com.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro asmxPorta.spuAtualizar" + ex.Message.ToString());
                    }
                    finally
                    {
                        Cnn.spuClose();
                    }
                }
        #endregion
                #region Consiste
                [WebMethod, SoapHeader("spAuthenticationHeader")]
                public int spuConsistir(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa)
                {
                    DTS.dtsPorta dtsPorta;
                    Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                    //SqlDataAdapter adp = new SqlDataAdapter();
                    SqlDataReader sqlR;
                    SqlCommand sqlC;
                    int funcao = 0;
                    try
                    {

                        dtsPorta = new DTS.dtsPorta();
                        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                        sqlC = Cnn.NewCommand("PR_RSA_Porta_S", Cnn.spuConnection);
                        sqlC.CommandType = CommandType.StoredProcedure;
                        sqlC.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                        sqlC.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                        sqlC.Parameters.AddWithValue("@Par_Cod_Programa", strCod_Programa);

                        sqlR = sqlC.ExecuteReader();
                        sqlR.Read();

                        if (sqlR.HasRows)
                        {
                            funcao = sqlR.GetInt16(sqlR.GetOrdinal("funcao"));
                        }
                        sqlR.Close();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro asmxPorta.spuCarregar" + ex.Message.ToString());
                    }
                    finally
                    {
                        Cnn.spuClose();
                    }
                    return (funcao);

                }
        #endregion

    }
}
