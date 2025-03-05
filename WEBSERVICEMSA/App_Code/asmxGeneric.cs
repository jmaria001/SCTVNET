using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Web.Services.Protocols;

namespace WebServiceMSA
{
    public class asmxGeneric : System.Web.Services.WebService
    {
        public string xUsuario;
        public string xPassword;
        public string xKey;

        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxGeneric()
        {
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean spuSelectMacAdress(String pMac, int pFlag)
        {
            bool rd_value = false;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD;
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_MAC_Address_Select";
                Cmd.Parameters.AddWithValue("@Par_Endereco_MAC", pMac);
                Cmd.Parameters.AddWithValue("@Par_Flag_Pendente", pFlag);
                RD = Cmd.ExecuteReader();
                RD.Read();

                if (RD.HasRows)
                {
                    rd_value = true;
                }
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }

            return rd_value;
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public int spuInsertEmail(string Email_Remetente, string Email_Destinatario, string Email_ComCopia, string Desc_Assunto, string Desc_CorpoEmail, int ID_Usuario)
        {
            int row_value = 0;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_Send_Email_Insert";
                Cmd.Parameters.AddWithValue("@Par_Email_Remetente", Email_Remetente);
                Cmd.Parameters.AddWithValue("@Par_Email_Destinatario", Email_Destinatario);
                Cmd.Parameters.AddWithValue("@Par_Email_ComCopia", Email_ComCopia);
                Cmd.Parameters.AddWithValue("@Par_Desc_Assunto", Desc_Assunto);
                Cmd.Parameters.AddWithValue("@Par_Desc_CorpoEmail", Desc_CorpoEmail);
                Cmd.Parameters.AddWithValue("@Par_ID_Usuario", ID_Usuario);

                row_value = Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                if (Cnn.spuConnection.State == ConnectionState.Open)
                {
                    Cnn.spuClose();
                }
            }

            return row_value;
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public int spuInsertMacAddress(String pMac, String pCPU, String pComputador, String pUser_Name, String pEmail_User, String pEmp_User, String pCidade, String pVeic_User, String pObs)
        {
            int row_value = 0;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_MAC_Address_Insert";
                Cmd.Parameters.AddWithValue("@Par_Endereco_MAC", pMac);
                Cmd.Parameters.AddWithValue("@Par_Identificador_CPU", pCPU);
                Cmd.Parameters.AddWithValue("@Par_Nome_Computador", pComputador);
                Cmd.Parameters.AddWithValue("@Par_Nome_Usuario", pUser_Name);
                Cmd.Parameters.AddWithValue("@Par_Email_Usuario", pEmail_User);
                Cmd.Parameters.AddWithValue("@Par_Empresa_Usuario", pEmp_User);
                Cmd.Parameters.AddWithValue("@Par_Cidade_Usuario", pCidade);
                Cmd.Parameters.AddWithValue("@Par_Veiculo_Usuario", pVeic_User);
                Cmd.Parameters.AddWithValue("@Par_Observacao", pObs);

                row_value = Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                if (Cnn.spuConnection.State == ConnectionState.Open)
                {
                    Cnn.spuClose();
                }
            }

            return row_value;
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public string Teste()
        {
            return spAuthenticationHeader.strUserName;

        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public string fnServerName()
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            return Cnn.ServerName();
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public string fnDataBaseName()
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            return Cnn.DataBaseName();
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public string fnParametrosGerais(string pCod_Empresa_Faturamento, string pCod_Empresa_Venda, string pCod_Veiculo, int pCod_Parametro)
        {
            string returnValue;
            returnValue = "";
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD;
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PrNet_Parametros_Gerais_Carregar ";
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa_Faturamento", pCod_Empresa_Faturamento);
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa_Venda", pCod_Empresa_Venda);
                Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", pCod_Veiculo);
                Cmd.Parameters.AddWithValue("@Par_Cod_Parametro", pCod_Parametro);
                RD = Cmd.ExecuteReader();
                RD.Read();

                if (! RD.IsDBNull(0))
                {
                    returnValue = RD["Cod_Chave"].ToString();
                }
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
        public DataSet fnSqlExecute(string pSqlCommand)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet DTS = new DataSet();
            SqlDataAdapter ADP = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                ADP.SelectCommand = Cnn.NewCommand();
                ADP.SelectCommand.Connection = Cnn.spuConnection;
                ADP.SelectCommand.CommandType = CommandType.Text;
                ADP.SelectCommand.CommandText = pSqlCommand;
                ADP.Fill(DTS);
                return Cnn.FnDts(DTS);
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message));
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable fnFiltroCarregar(string pTable)
        {
            DataSet DTS = new DataSet();
            string strFile = "";
            string strMensagem;
            try
            {
                strFile = ConfigurationManager.AppSettings["OS_PATH"].ToString();
                if (strFile.Substring(strFile.Length - 1, 1) != "")
                {
                    strFile += "";
                }
                strFile += "App_Data\\SearchConfig.xml";
                DTS.ReadXml(strFile);
                return DTS.Tables[pTable];
            }
            catch (Exception)
            {
                strMensagem = "Não foi possivel ler o arquivo XML de Configuração do Filtro" + "\r\n";
                strMensagem += "Comunique ao Administrador do Site" + "\r\n";
                strMensagem += "Parametro:WebConfig.OS_PATH";
                throw (new Exception(strMensagem));
            }
            finally
            {
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean fnSendEmail(string pFrom , string pTo, string pCC, string pSubject,string pBody)
        {
            string Server = "";
            string Porta = "";
            
            MailMessage Mail = new MailMessage();
            SmtpClient SMTP = new SmtpClient();
            try
            {

                //===================================Obtem os Parametros do Remetente
                
                if  (string.IsNullOrEmpty(pFrom))
                {
                    pFrom = getParametro("from");
                }
                //'===================================Obtem os Parametros do Destinatario

                if (string.IsNullOrEmpty(pTo))
                {
                    pTo = getParametro("to");
                }
                //'===================================Obtem os Parametros do subject
                if (string.IsNullOrEmpty(pSubject)) 
                {
                    pSubject = getParametro("subject");
                }
                
                //===================================Obtem os Parametros do Subject
                if (string.IsNullOrEmpty(pCC)) 
                {
                    pCC = getParametro("cc");
                }

                //'===================================Obtem os Parametros do SMTP Server
                Server = getParametro("SMTPSERVER");
                Porta = getParametro("SMTPPORTA");

                Mail.To.Add(new MailAddress (pTo));
                Mail.From = new MailAddress(pFrom);
                Mail.Subject = pSubject;
                Mail.Body = pBody;
                Mail.IsBodyHtml = true;
                Mail.Priority = MailPriority.Normal;
                SMTP.Host = Server;
                SMTP.Port = Convert.ToInt16(Porta);
                SMTP.Send(Mail);
                return true;
            }
            catch  (Exception ex)
            {
                throw new  Exception("Nao foi possivel Enviar Email para o Suporte " + "\n\r" + ex.Message);
            }
        }
        private string getParametro(string strParametro ) 
        {            
            if (ConfigurationManager.AppSettings[strParametro] == "")
            {
                return ConfigurationManager.AppSettings[strParametro];
            }
            else
            {
                return "";
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean fnSqlComando(string pSqlCommand ) 
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet DTS = new DataSet();
            SqlDataAdapter ADP = new SqlDataAdapter(); 
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                ADP.SelectCommand = Cnn.NewCommand();
                ADP.SelectCommand.Connection = Cnn.spuConnection; 
                ADP.SelectCommand.CommandType = CommandType.Text; 
                ADP.SelectCommand.CommandText = pSqlCommand;
                ADP.Fill(DTS);
                return true ;
            }
            catch (Exception Ex)
                {
                    throw new Exception(Ex.Message);
                 }

            finally 
            {
                Cnn.spuClose();
            }
        }
    }
}

