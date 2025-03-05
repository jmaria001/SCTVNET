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
        
    public class asmxRetornoPlayList : System.Web.Services.WebService 
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

     
        public asmxRetornoPlayList () 
        {
            InitializeComponent();
        }


        #region Component Designer generated code

        //Required by the Web Services Designer 
        private IContainer components = null;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

    #region CarregarLayout
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRetornoPlayList spuCarregarLayout (string strCod_Veiculo)
        {
            DTS.dtsRetornoPlayList dtsRetornoPlayList;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRetornoPlayList = new DTS.dtsRetornoPlayList();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Pr_Rsa_Layout_Retorno_PlayList_S", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.Fill(dtsRetornoPlayList,"dtbLayoutRetorno");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRetornoPlayList.spuCarregarParametro " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRetornoPlayList;
        }
        #endregion  
        #region CompararPlayList
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsRetornoPlayList spuCompararPlayList(string strCod_Veiculo,DateTime dtData_Exibicao,byte btIndicaAvulso,byte btIndicaArtistico)
        {
            DTS.dtsRetornoPlayList dtsRetornoPlayList;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsRetornoPlayList = new DTS.dtsRetornoPlayList();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("sp_Retorno_Play_List", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dtData_Exibicao);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Avulso", btIndicaAvulso);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Artistico", btIndicaArtistico);
                adp.Fill(dtsRetornoPlayList.dtbPlayListCompara);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxRetornoPlayList.CompararPlayList " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRetornoPlayList;
        }
         #endregion
    #region Atualizar
        [WebMethod, SoapHeader("spAuthenticationHeader")]

        public DTS.dtsRetornoPlayList spuAtualizar(DTS.dtsRetornoPlayList dtsRetornoPlayList)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.InsertCommand = Cnn.NewCommand("Pr_RSA_retorno_playlist_I", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.InsertCommand.Parameters.Add("@Par_Titulo_Fita", (SqlDbType.Char), 50, "Titulo_Fita");
                adp.InsertCommand.Parameters.Add("@Par_Data_Exibicao", (SqlDbType.DateTime), 12, "Data_Exibicao");
                adp.InsertCommand.Parameters.Add("@Par_Horario_Exibicao", (SqlDbType.Char), 8, "Horario_Exibicao");
                adp.InsertCommand.Parameters.Add("@Par_duracao", (SqlDbType.SmallInt), 6, "duracao");
                adp.Update(dtsRetornoPlayList.dtbRetorno_playlist);
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro dtsRetornoPlayList spuAtualizar" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsRetornoPlayList;
        }

    #endregion
    #region Limpar

    [WebMethod, SoapHeader("spAuthenticationHeader")]
    public void spuLimpar(string strCodVeiculo)
    {
        Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
        SqlCommand com = Cnn.NewCommand();
        try
        {
            Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

            com.CommandText = "Pr_RSA_retorno_playlist_D";
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = Cnn.spuConnection;
            com.Parameters.AddWithValue("@Par_Cod_Veiculo", strCodVeiculo);
            com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw new Exception("Erro asmxRetornoPlayLista.spuLimpar" + ex.Message.ToString());
        }
        finally
        {
            Cnn.spuClose();
        }
    }
     #endregion

    }		
}
