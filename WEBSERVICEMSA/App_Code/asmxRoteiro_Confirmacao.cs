using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;

namespace WebServiceMSA
{
    public class asmxRoteiro_Confirmacao : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        private Conexao.NET.clsConexao Cnn;
        private DTS.dtsRoteiro_Confirmacao dtsRoteiro_Confirmacao;

        public asmxRoteiro_Confirmacao()
        {
        }


        #region Carregar
            #region spuCarregar
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public DTS.dtsRoteiro_Confirmacao spuCarregar( string strCod_Usuario)
            {
                return( this.spuCarregar( strCod_Usuario, "") );
            }
            #endregion

            #region spuCarregar Veiculo
            [WebMethod(MessageName = "spuCarregar2"), SoapHeader("spAuthenticationHeader")]
            public DTS.dtsRoteiro_Confirmacao spuCarregar( string strCod_Usuario, string strCod_Veiculo)
            {
                try
                {
                    this.dtsRoteiro_Confirmacao = new WebServiceMSA.DTS.dtsRoteiro_Confirmacao();
                    this.Cnn= new Conexao.NET.clsConexao();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    this.sprCarregar(strCod_Usuario, strCod_Veiculo, Cnn.spuConnection);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxRoteiro_Confirmacao.spuCarregar </br>" + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
                return (this.dtsRoteiro_Confirmacao);
            }
            #endregion

            #region sprCarregar
            private void sprCarregar(string strCod_Usuario, string strCod_Veiculo, SqlConnection Cnn)
            {
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter();

                    adp.SelectCommand = new SqlCommand("prNet_Confirmacao_Roteiro_S", Cnn);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@strCod_Usuario_P", strCod_Usuario );
                    adp.SelectCommand.Parameters.AddWithValue("@strCod_Veiculo_P", (strCod_Veiculo.Trim().Length != 0 ? strCod_Veiculo : null));

                    adp.Fill(this.dtsRoteiro_Confirmacao.dtbRoteiro_Confirmacao);

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro asmxRoteiro_Confirmacao.sprCarregar </br>" + ex.Message.ToString());
                }
            }
            #endregion

        #endregion

        #region Atualizar
            #region spuAtualizar
            [WebMethod, SoapHeader("spAuthenticationHeader")]
            public void spuAtualizar(DTS.dtsRoteiro_Confirmacao dtsConfirmacao_Roteiro)
            {
                try
                {
                    Cnn = new Conexao.NET.clsConexao();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    SqlTransaction tran = (SqlTransaction)Cnn.spuConnection.BeginTransaction();
                    this.sprAtualizar(dtsConfirmacao_Roteiro, Cnn.spuConnection, tran);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    throw new Exception("asmxRoteiro_Confirmacao.spuAtualizar() " + ex.Message.ToString());
                }
                finally
                {
                    Cnn.spuClose();
                }
            }
            #endregion

            #region sprAtualizar
            private void sprAtualizar(DTS.dtsRoteiro_Confirmacao dtsConfirmacao_Roteiro, SqlConnection Cnn, SqlTransaction tran)
            {
                try
                {
                    SqlDataAdapter adp = new SqlDataAdapter();

                    adp.UpdateCommand = (new SqlCommand("prNet_Confirmacao_Roteiro_U"));
                    adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                    adp.UpdateCommand.Connection = Cnn;
                    adp.UpdateCommand.Transaction = tran;
                    adp.UpdateCommand.Parameters.Add("@strCod_Veiculo_P", SqlDbType.Char, 3, "Cod_Veiculo");
                    adp.UpdateCommand.Parameters.Add("@dteData_Confirmacao_Rede_P", SqlDbType.DateTime, 19, "Data_Confirmacao_Rede");
                    adp.UpdateCommand.Parameters.Add("@dteData_Confirmacao_Local_P", SqlDbType.DateTime, 19, "Data_Confirmacao_Local");
                    adp.UpdateCommand.Parameters.Add("@dteData_Cadastro_Rede_P", SqlDbType.DateTime, 19, "Data_Cadastro_Rede");
                    adp.UpdateCommand.Parameters.Add("@dteData_Cadastro_Local_P", SqlDbType.DateTime, 19, "Data_Cadastro_Local");
                    adp.UpdateCommand.Parameters.Add("@strCod_Usuario_Rede_P", SqlDbType.VarChar, 30, "Cod_Usuario_Rede");
                    adp.UpdateCommand.Parameters.Add("@strCod_Usuario_Local_P", SqlDbType.VarChar, 30, "Cod_Usuario_Local");

                    adp.Update(dtsConfirmacao_Roteiro.dtbRoteiro_Confirmacao);
                }
                catch (Exception ex)
                {
                    throw new Exception("asmxRoteiro_Confirmacao.sprAtualizar() " + ex.Message.ToString());
                }
            }
            #endregion
        #endregion
 
    }
}