using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Conexao.NET
{
    public class clsConexao
    {
        public string deCriptografar(string pSenha)
        {
            string strRetorno = "";
            int bt1, bt2, bt3;
            string strTemp;
            for (int i = 0; i < 60; i += 6)
            {
                strTemp = pSenha.Substring(i, 6);
                bt1 = Convert.ToInt16(strTemp.Substring(0, 1) + strTemp.Substring(3, 1) + strTemp.Substring(5, 1));
                bt2 = Convert.ToInt16(strTemp.Substring(1, 1) + strTemp.Substring(4, 1) + strTemp.Substring(2, 1));
                bt3 = bt2 - bt1;
                strRetorno += (char)bt3;
            }
            return strRetorno;
        }
        public DataSet FnDts(DataSet dtInput)
        {
            foreach (DataTable tb in dtInput.Tables)
            {
                foreach (DataColumn dc in tb.Columns)
                {
                    if ((dc.DataType == typeof(DateTime)) || (dc.DataType == typeof(DateTime?)))
                    dc.DateTimeMode = DataSetDateTime.Unspecified;
                }
            }
            return dtInput; 
        }

        public DataTable FnDtb(DataTable dtInput)
        {

            foreach (DataColumn dc in dtInput.Columns)
                {
                    if ((dc.DataType == typeof(DateTime)) || (dc.DataType == typeof(DateTime?)))
                        dc.DateTimeMode = DataSetDateTime.Unspecified;
                }
            
            return dtInput;
        }


        private SqlConnection oConnection;

        public clsConexao()
        {
            oConnection = new SqlConnection();
        }
        public String ServerName()
        {
             return (ConfigurationManager.AppSettings["Server"]); 
            
        }
        public String DataBaseName()
        {
            return (ConfigurationManager.AppSettings["Database"]);
        }

        public SqlConnection spuConnection
        {
            get { return (oConnection); }
        }

        #region Open

        

        public void spuOpen(string pUsuario, string pSenha)
        {
            try
            {
                //String Conexao
                oConnection.ConnectionString = "Persist Security Info=False;";
                if (ConfigurationManager.AppSettings["TCPIP"] == "true")
                    //---Conexao TCPIP 
                    oConnection.ConnectionString += "Network Library=dbmssocn;";
                else
                    //---Conexao NAME PIPES
                    oConnection.ConnectionString += "Network Library=dbnmpntw;";

                //---Nome Aplicacao
                if (ConfigurationManager.AppSettings["ApplicationName"] != "")
                {
                    oConnection.ConnectionString += "Application Name=";
                    oConnection.ConnectionString += ConfigurationManager.AppSettings["ApplicationName"];
                    oConnection.ConnectionString += ";";
                }
                //---Nome Servidor SQL
                if (ConfigurationManager.AppSettings["Computer"] != "")
                {
                    oConnection.ConnectionString += "Workstation ID=";
                    oConnection.ConnectionString += ConfigurationManager.AppSettings["Computer"];
                    oConnection.ConnectionString += ";";
                }
                //---Nome da Instancia SQL
                oConnection.ConnectionString += "Data Source=";
                oConnection.ConnectionString += ConfigurationManager.AppSettings["Server"];
                oConnection.ConnectionString += ";";

                //---Nome do Banco de Dados
                if (ConfigurationManager.AppSettings["Database"] != "")
                {
                    oConnection.ConnectionString += "Initial Catalog=";
                    oConnection.ConnectionString += ConfigurationManager.AppSettings["Database"];
                    oConnection.ConnectionString += ";";
                }
                //---User e Password
                if (pSenha.Trim() != "")
                {
                    
                    oConnection.ConnectionString += "User ID=" + pUsuario + ";pwd=" + deCriptografar(pSenha )+ ";";
                    //oConnection.ConnectionString += "User ID=" + "sa" + ";pwd=" + "junho" + ";";
                }
                else
                {
                    //oConnection.ConnectionString += "User ID=" + pUsuario + ";pwd=" + deCriptografar(pSenha) + ";";
                    oConnection.ConnectionString += "User ID=" + ""+ ";pwd=" +  "" + ";";
                }

                //---Timeout
                if (ConfigurationManager.AppSettings["Timeout"] != "")
                {
                    oConnection.ConnectionString += "Connect Timeout=";
                    oConnection.ConnectionString += ConfigurationManager.AppSettings["ConnectionTimeout"];
                    oConnection.ConnectionString += ";";
                }
                if (ConfigurationManager.AppSettings["Pooling"] != "")
                {
                    oConnection.ConnectionString += "Pooling=";
                    oConnection.ConnectionString += ConfigurationManager.AppSettings["Pooling"];
                    oConnection.ConnectionString += ";";
                }

                if (ConfigurationManager.AppSettings["MaxPoolSize"] != "")
                {
                    oConnection.ConnectionString += "Max Pool Size =";
                    oConnection.ConnectionString += ConfigurationManager.AppSettings["MaxPoolSize"];
                    oConnection.ConnectionString += ";";
                }
                oConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("spiopen" + ex.Message);
            }
        }

        #endregion

        #region Close

        public void spuClose()
        {
            try
            {
                if (oConnection.State == ConnectionState.Open)
                {
                    oConnection.Close();
                    oConnection.Dispose();
                    oConnection = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Conexao.clsConexao.spuClose()\n" + ex.Message);
            }
        }

        public SqlCommand NewCommand()
        {
            SqlCommand Comand = new SqlCommand();
            try
            {
                
                Comand.CommandTimeout = int.Parse(ConfigurationManager.AppSettings["CommandTimeout"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Conexao.clsConexao.NewCommand()\n" + ex.Message);
            }
            return  Comand;
        }
        public SqlCommand NewCommand(string strCommandText,SqlConnection CnnConexao)
        {

            SqlCommand Comand = new SqlCommand();
            try
            {
                Comand.CommandText = strCommandText;
                Comand.Connection = CnnConexao;
                Comand.CommandTimeout = int.Parse(ConfigurationManager.AppSettings["CommandTimeout"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Conexao.clsConexao.NewCommand()\n" + ex.Message);
            }
            return Comand;
        }        
        public SqlCommand NewCommand( string strCommandText)
        {
            SqlCommand Comand = new SqlCommand();
            try
            {
                Comand.CommandText = strCommandText;
                Comand.CommandTimeout = int.Parse(ConfigurationManager.AppSettings["CommandTimeout"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Conexao.clsConexao.NewCommand()\n" + ex.Message);
            }
            return Comand;
        }        
        #endregion

        #region Transação


        #endregion
    }
}
