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
    /// <summary>
    /// Summary description for asmxMacAddress
    /// </summary>
    public class asmxMacAddress : System.Web.Services.WebService
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

        public asmxMacAddress()
        {
        }

        Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
        DTS.dtsMacAddress MacAddress = new DTS.dtsMacAddress();
        SqlDataAdapter ADP = new SqlDataAdapter();

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsMacAddress spuCarregarPendentes(String pMac, int pFlag)
        { 
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                ADP.SelectCommand = (Cnn.NewCommand("prNet_MAC_Address_Select"));
                ADP.SelectCommand.CommandType = CommandType.StoredProcedure; 
                ADP.SelectCommand.Parameters.AddWithValue("@Par_Endereco_MAC", pMac);
                ADP.SelectCommand.Parameters.AddWithValue("@Par_Flag_Pendente", pFlag);
                ADP.SelectCommand.Connection = Cnn.spuConnection;
                ADP.Fill(MacAddress.dtbMAC_Address);  
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

            return MacAddress;
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsMacAddress spuCarregarTodos()
        {
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                ADP.SelectCommand = (Cnn.NewCommand("prNet_MAC_Address_Todos_Select"));
                ADP.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADP.SelectCommand.Connection = Cnn.spuConnection;
                ADP.Fill(MacAddress.dtbMAC_Address);
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

            return MacAddress;
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public int spuUpdateMacAddress(int Id_Interno, String User_Cadastro, int Flag_Pendente)
        {
            int row_value = 0;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_MAC_Address_Update";
                Cmd.Parameters.AddWithValue("@Par_Id_Interno", Id_Interno);
                Cmd.Parameters.AddWithValue("@Par_User_Cadastro", User_Cadastro);
                Cmd.Parameters.AddWithValue("@Par_Flag_Pendente", Flag_Pendente);

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
        public int spuDeleteMacAddress(int Id_Interno)
        {
            int row_value = 0;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_MAC_Address_Delete";
                Cmd.Parameters.AddWithValue("@Par_Id_Interno", Id_Interno);

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
    }
}
