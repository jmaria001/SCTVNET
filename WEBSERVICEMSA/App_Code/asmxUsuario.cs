using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;
using WebServiceMSA.DTS;
using System.Configuration;

namespace WebServiceMSA
{
    public class asmxUsuario : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxUsuario()
        {
        }

            
        public DTS.dtsUsuario Create()
        {
            DTS.dtsUsuario dtsUsuario = new dtsUsuario();
            return dtsUsuario; 
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public bool fnPermissao(string pUsuario, short pCod_Funcao)
        {
            bool returnValue;

            returnValue = false;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD;
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PrNet_Funcao_Carregar ";
                Cmd.Parameters.AddWithValue("@Par_Usuario", pUsuario);
                Cmd.Parameters.AddWithValue("@Par_Cod_Funcao", pCod_Funcao);
                RD = Cmd.ExecuteReader();
                RD.Read();
                returnValue = RD.HasRows;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }

            return returnValue;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnUsuario_Empresa(string pUsuario, string pCod_Empresa)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet dts = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand();
                adp.SelectCommand.Connection = Cnn.spuConnection;
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("Par_Cod_Usuario", pUsuario);
                if (string.IsNullOrEmpty(pCod_Empresa))
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", DBNull.Value);
                }
                else
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                }

                adp.SelectCommand.CommandText = "PrNet_Usuario_Empresa_Carregar";
                adp.Fill(dts);
                return Cnn.FnDts(dts); 
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public string fnValidaUsuario(string pUsuario, string pSenha)
        {
            string returnValue;
            returnValue = "";
            //SqlCommand Cmd = Cnn.NewCommand();
            
            SqlDataReader RD;
            
            
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PrNet_Usuario_Validar";
                Cmd.Parameters.AddWithValue("@Par_Usuario", pUsuario);
                Cmd.Parameters.AddWithValue("@Par_Senha", Cnn.deCriptografar( pSenha));
                RD = Cmd.ExecuteReader();
                RD.Read();
                if (!RD.IsDBNull(0))
                {
                    returnValue = RD[0].ToString();
                }
            }
            catch (Exception Ex)
            {
                returnValue = "Não foi possivel conectar com esse Login e Senha.Verifique!";
            }
            finally
            {
                Cnn.spuClose();
            }
            return returnValue; 
            
            
            
            
        }
        
        
        private bool fnAlterarSenhaSctv(string pUsuario, string pSenha)
        {
            bool returnValue;
            returnValue = false;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PrNet_Usuario_Alterar_Senha";
                Cmd.Parameters.AddWithValue("@Par_Usuario", pUsuario);
                Cmd.Parameters.AddWithValue("@Par_Senha", Cnn.deCriptografar(pSenha));
                Cmd.ExecuteNonQuery();
                returnValue = true;
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }
            return returnValue; 
        }
        

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public bool fnAlterarSenha(string pUsuario, string pSenha)
        {
            bool returnValue;
            returnValue = false;
            //Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            //SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                //Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                //Cmd.Connection = Cnn.spuConnection;
                //Cmd.CommandType = CommandType.StoredProcedure;
                //Cmd.CommandText = "Sp_Password";
                //Cmd.Parameters.AddWithValue("@Old", DBNull.Value );
                //Cmd.Parameters.AddWithValue("@New", pSenha);
                //Cmd.Parameters.AddWithValue("@LogiName", pUsuario );
               // Cmd.ExecuteNonQuery();

                if (fnAlterarSenhaSctv(pUsuario, pSenha))
                {
                    returnValue = true;
                }
                
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                //Cnn.spuClose();
            }
            return returnValue; 
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnFuncaoCarregar(object pUsuario)
        {

            DataSet DTS = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Usuario", pUsuario);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Funcao", DBNull.Value);
                AD.SelectCommand.CommandText = "PrNet_Funcao_Carregar";
                AD.Fill(DTS);
                return Cnn.FnDts(DTS); 
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }

        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public dtsUsuario spuCarregar(String strUsrName, String strUsrPassword)
        {
            dtsUsuario dtsUsuario;
            dtsUsuario.dtbUsuarioRow drwUsuario;

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            try
            {
                dtsUsuario = new dtsUsuario();

                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                Boolean bolCriptografia, bolUser;
                Boolean.TryParse(ConfigurationManager.AppSettings["crypt"].ToString(), out bolCriptografia);
                if (bolCriptografia)
                    bolUser = sprCarregar_UsuarioSenha(dtsUsuario.dtbUsuario, Cnn.spuConnection, strUsrName, strUsrPassword);
                else
                {
                    sprCarregar_Usuario(dtsUsuario.dtbUsuario, Cnn.spuConnection, strUsrName, strUsrPassword);
                    bolUser = true;
                }

                if (bolUser && dtsUsuario.dtbUsuario.Rows.Count == 1)
                {
                    drwUsuario = dtsUsuario.dtbUsuario[0];

                    sprCarregar_Usuario_Empresa(dtsUsuario.dtbUsuario_Empresa, Cnn.spuConnection, drwUsuario.ID_Usuario);
                    sprCarregar_Usuario_Veiculo(dtsUsuario.dtbUsuario_Veiculo, Cnn.spuConnection, drwUsuario.ID_Usuario);
                    sprCarregar_Usuario_MSAFuncao(dtsUsuario.dtbUsuario_MSAFuncao, Cnn.spuConnection, drwUsuario.ID_Usuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no asmxUsuario.spuCarregar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }

            return dtsUsuario; 
        }
        static private void sprCarregar_Usuario(dtsUsuario.dtbUsuarioDataTable dtbUsuario, SqlConnection Cnn, String strUsrName, String strUsrPassword)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand ("prNet_Usuario_S", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PUsuario", strUsrName);
                adp.SelectCommand.Parameters.AddWithValue("@PSenha", strUsrPassword);

                adp.Fill(dtbUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Exception:asmxUsuario.sprCarregar_Usuario\n" + ex.Message.ToString());
            }
        }
         private Boolean sprCarregar_UsuarioSenha(dtsUsuario.dtbUsuarioDataTable dtbUsuario, SqlConnection Cnn, String strUsrName, String strUsrPassword)
                {
                    SqlDataAdapter adp;
                    string strSenha = "";
                    try
                    {
                        adp = new SqlDataAdapter();
                        adp.SelectCommand = new SqlCommand ("prNet_UsuarioSenha_S", Cnn);
                        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adp.SelectCommand.Parameters.AddWithValue("@PUsuario", strUsrName);

                        adp.Fill(dtbUsuario);

                        // Valida Senha
                        DTS.dtsUsuario.dtbUsuarioRow drw = (dtsUsuario.dtbUsuarioRow)dtbUsuario.Rows[0];
                        if ( strSenha.Trim().ToUpper() != strUsrPassword.Trim().ToUpper() )
                        {
                            dtbUsuario.Rows.Clear();
                            return false; 
                        }
                        return true; 
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Exception:asmxUsuario.sprCarregar_Usuario\n" + ex.Message.ToString());
                    }
                }
        static private void sprCarregar_Usuario_MSAFuncao(dtsUsuario.dtbUsuario_MSAFuncaoDataTable dtbUsuario_MSAFuncao, SqlConnection Cnn, int ID_Usuario)
            {
                SqlDataAdapter adp;

                try
                {
                    adp = new SqlDataAdapter();

                    adp.SelectCommand = new SqlCommand("prNet_Usuario_MSAFuncao_S", Cnn);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@intPID_Usuario", ID_Usuario);

                    adp.Fill(dtbUsuario_MSAFuncao);
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception:asmxUsuario.sprCarregar_Usuario_MSAFuncao\n" + ex.Message.ToString());
                }
            }
        static private void sprCarregar_Usuario_Empresa(dtsUsuario.dtbUsuario_EmpresaDataTable dtbUsuario_Empresa, SqlConnection Cnn, int ID_Usuario)
            {
                SqlDataAdapter adp;

                try
                {
                    adp = new SqlDataAdapter();

                    adp.SelectCommand = new SqlCommand("prNet_Usuario_Empresa_S", Cnn);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@intPID_Usuario", ID_Usuario);

                    adp.Fill(dtbUsuario_Empresa);
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception:asmxUsuario.sprCarregar_Usuario_Empresa\n" + ex.Message.ToString());
                }
            }
        static private void sprCarregar_Usuario_Veiculo(dtsUsuario.dtbUsuario_VeiculoDataTable dtbUsuario_Veiculo, SqlConnection Cnn, int ID_Usuario)
            {
                SqlDataAdapter adp;

                try
                {
                    adp = new SqlDataAdapter();

                    adp.SelectCommand = new SqlCommand("prNet_Usuario_Veiculo_S", Cnn);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@intPID_Usuario", ID_Usuario);

                    adp.Fill(dtbUsuario_Veiculo);
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception:asmxUsuario.sprCarregar_Usuario_Veiculo\n" + ex.Message.ToString());
                }
            }
        }
    }

 
