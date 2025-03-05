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
	/// Summary description for asmxPrograma.
	/// </summary>
	public class asmxPrograma : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        Conexao.NET.clsConexao Cnn;
        DTS.dtsPrograma dtsPrograma;
		public asmxPrograma()
		{
		}
        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public DTS.dtsPrograma spuCarregar()
        {
            return this.spuCarregar( false );
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean ExistePrograma(String pCodPrograma)
        {
            Cnn = new Conexao.NET.clsConexao();
            SqlDataReader Dtr;
            SqlCommand Cmd = Cnn.NewCommand();
            Boolean bolRetorno = true;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_Programa_L";
                Cmd.Parameters.AddWithValue("@Par_Cod_Programa",pCodPrograma);
                
                Dtr= Cmd.ExecuteReader();
                Dtr.Read();
                bolRetorno = Dtr.HasRows;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ExistePrograma " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return bolRetorno  ;
        }
        //[WebMethod, SoapHeader("spAuthenticationHeader")]
        //public Boolean Salvar(DataTable dtbPrograma)
        //{
        //    Conexao.NET.clsConexao Cnn;
        //    SqlDataAdapter Adp; 
        //    try
        //    {
        //        Cnn = new Conexao.NET.clsConexao();
        //        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
        //        Adp = new SqlDataAdapter();

        //        Adp.InsertCommand.CommandType = CommandType.StoredProcedure ;
        //        Adp.InsertCommand.CommandText = "PrNet_Programa_Insert";
        //        Adp.InsertCommand.Connection = Cnn.spuConnection ;
        //        adp.InsertCommand.Parameters.Add("@Par_Cod_Programa",SqlDbType.Char,4,"Cod_Programa");
        //        adp.InsertCommand.Parameters.Add("@Par_Versao",SqlDbType.Int,1,"Versao");
        //        adp.InsertCommand.Parameters.Add("@Par_Cod_Genero",SqlDbType.Char,4,"Cod_Genero");
        //        adp.InsertCommand.Parameters.Add("@Par_Validade_Inicial",SqlDbType.DateTime,"Validade_Inicial");
        //        adp.InsertCommand.Parameters.Add("@Par_Indica_Evento",SqlDbType.TinyInt,1,"Indica_Evento");
        //        adp.InsertCommand.Parameters.Add("@Par_Indica_Rotativo",SqlDbType.TinyInt,1,"Indica_Rotativo");
        //        adp.InsertCommand.Parameters.Add("@Par_Indica_Local",SqlDbType.TinyInt,1,"Indica_Local");
        //        adp.InsertCommand.Parameters.Add("@Par_Titulo",SqlDbType.Char,30,"Titulo");
        //        adp.InsertCommand.Parameters.Add("@Par_Sub_Titulo",SqlDbType.Char,30,"Sub_Titulo");
        //        adp.InsertCommand.Parameters.Add("@Par_Cod_Usuario",SqlDbType.Char,30,"Cod_Usuario");
        //        adp.InsertCommand.Parameters.Add("@Par_Indica_Ce_Exibido",SqlDbType.TinyInt,1,"Indica_Ce_Exibido");
        //        adp.InsertCommand.Parameters.Add("@Par_Indica_PSS",SqlDbType.TinyInt,1,"Indica_Pss");
        //        adp.InsertCommand.Parameters.Add("@Par_Cod_A_JOVE",SqlDbType.Char(4),"Cod_A_JOVE");
        //        adp.InsertCommand.Parameters.Add("@Par_Cod_N_JOVE",SqlDbType.SmallInt,1,"Cod_N_JOVE");
        //        adp.InsertCommand.Parameters.Add("@Par_Tipo_Programa",SqlDbType.TinyInt,"Tipo_Programa");
        //        adp.InsertCommand.Parameters.Add("@Par_Cod_Faturamento",SqlDbType.Char,16,"Cod_Faturamento");

        //        Adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
        //        Adp.UpdateCommand.CommandText = "PrNet_Programa_Update";
        //        Adp.UpdateCommand.Connection = Cnn.spuConnection;
        //        Adp.UpdateCommand.Parameters.Add("@Par_Cod_Programa", SqlDbType.Char, 4, "Cod_Programa");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Versao", SqlDbType.Int, 1, "Versao");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Cod_Genero", SqlDbType.Char, 4, "Cod_Genero");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Indica_Evento", SqlDbType.TinyInt, 1, "Indica_Evento");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Indica_Rotativo", SqlDbType.TinyInt, 1, "Indica_Rotativo");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Indica_Local", SqlDbType.TinyInt, 1, "Indica_Local");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Titulo", SqlDbType.Char, 30, "Titulo");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Sub_Titulo", SqlDbType.Char, 30, "Sub_Titulo");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Cod_Usuario", SqlDbType.Char, 30, "Cod_Usuario");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Indica_Ce_Exibido", SqlDbType.TinyInt, 1, "Indica_Ce_Exibido");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Indica_PSS", SqlDbType.TinyInt, 1, "Indica_Pss");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Cod_A_JOVE", SqlDbType.Char(4), "Cod_A_JOVE");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Cod_N_JOVE", SqlDbType.SmallInt, 1, "Cod_N_JOVE");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Tipo_Programa", SqlDbType.TinyInt, "Tipo_Programa");
        //        Adp.UpdateCommand.Parameters.Add("@Par_Cod_Faturamento", SqlDbType.Char, 16, "Cod_Faturamento");

        //        Adp.Update(dtbPrograma );
                
        //    }

        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro clsPrograma.Salvar" + ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        Cnn.spuClose();
        //    }
        //    return bolRetorno;
        //}

        [WebMethod(MessageName = "spuCarregar2"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsPrograma spuCarregar( Boolean bolCarregaProgramaVeiculo )
        {

            try
            {
                Cnn = new Conexao.NET.clsConexao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                dtsPrograma = new DTS.dtsPrograma();
                this.sprCarregar_Programa("", Cnn.spuConnection);

                if (bolCarregaProgramaVeiculo)
                {
                    this.sprCarregar_Programa_Veiculo("", "", Cnn.spuConnection);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxPrograma.SpuCarregar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsPrograma;
        }

        [WebMethod(MessageName = "spuCarregar_Programa"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsPrograma spuCarregar(string strCod_Programa)
        {
            return this.spuCarregar(strCod_Programa, false);
        }

        [WebMethod(MessageName = "spuCarregar_Programa2"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsPrograma spuCarregar(string strCod_Programa, Boolean bolCarregaProgramaVeiculo)
        {
            try
            {
                Cnn = new Conexao.NET.clsConexao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                dtsPrograma = new DTS.dtsPrograma();

                this.sprCarregar_Programa(strCod_Programa, Cnn.spuConnection);
                if (bolCarregaProgramaVeiculo)
                {
                    this.sprCarregar_Programa_Veiculo(strCod_Programa, "", Cnn.spuConnection);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxPrograma.spuCarregar_Programa " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsPrograma;
        }

        [WebMethod(MessageName = "spuCarregar_Programa_Veiculo"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsPrograma spuCarregar(string strCod_Programa, string strCod_Veiculo)
        {
            try
            {
                Cnn = new Conexao.NET.clsConexao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                dtsPrograma = new DTS.dtsPrograma();

               // this.sprCarregar_Programa(strCod_Programa, Cnn.spuConnection);
                this.sprCarregar_Programa_Veiculo(strCod_Programa, strCod_Veiculo, Cnn.spuConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxPrograma.spuCarregar_Programa_Veiculo " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsPrograma;
        }

        [WebMethod(MessageName = "spuCarregar_Programa_Veiculo_Data"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsPrograma spuCarregar(string strCod_Programa, string strCod_Veiculo, DateTime dteDataExibicao)
        {
            DTS.dtsPrograma dtsPrograma;
            Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsPrograma = new DTS.dtsPrograma();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);


                adp.SelectCommand = Cnn.NewCommand("prNet_Programa_Veiculo_Data_S", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                if (dteDataExibicao != DateTime.MinValue)
                {
                    adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dteDataExibicao);

                }
                adp.Fill(dtsPrograma.dtbPrograma_Veiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxPrograma.spuCarregar_Programa_Veiculo_Data " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsPrograma;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        private void sprCarregar_Programa(string strCod_Programa, SqlConnection Cnn)
		{
			SqlDataAdapter adp = new SqlDataAdapter();
            
            try
		    {
				adp.SelectCommand = new SqlCommand ("pr_Programa_S", Cnn);
				adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
				adp.Fill(dtsPrograma.dtbPrograma);	
			}
			catch (Exception ex)
			{
                throw new Exception("Erro asmxPrograma.sprCarregar_Programa " + ex.Message.ToString());
			}
             
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        private void sprCarregar_Programa_Veiculo(string strCod_Programa, string strCod_Veiculo, SqlConnection Cnn)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                adp.SelectCommand = new SqlCommand ("prNet_Programa_Veiculo_S", Cnn );
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Programa", (strCod_Programa.Length != 0 ? strCod_Programa : null));
                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Veiculo",  (strCod_Veiculo.Length  != 0 ? strCod_Veiculo  : null));
                adp.Fill(dtsPrograma.dtbPrograma_Veiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxPrograma.sprCarregar_Programa_Veiculo " + ex.Message.ToString());
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet spuProgramaUsuario(string pUsuario)
        {
            DataSet DTS = new DataSet();
            Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                
                adp.SelectCommand = Cnn.NewCommand("prNet_Programa_Veiculo_Usuario_S", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;

                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Usuario", pUsuario);
                adp.Fill(DTS);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxPrograma.spuProgramaUsuario " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDts(DTS);
        }

        [WebMethod(MessageName = "spuCarregar_Programa_Veiculo_IndicaNet"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsPrograma spuCarregar(string strCod_Veiculo, short shIndicaNet)
        {
            DTS.dtsPrograma dtsPrograma;
            Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsPrograma = new DTS.dtsPrograma();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);


                adp.SelectCommand = Cnn.NewCommand("prNet_Programa_Veiculo_IndicaNet_S", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;

                adp.SelectCommand.Parameters.AddWithValue("@strPCod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                adp.SelectCommand.Parameters.AddWithValue("@strPIndicaNet", shIndicaNet);
                adp.Fill(dtsPrograma.dtbPrograma);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxPrograma.spuCarregar_Programa_Veiculo_IndicaNet " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsPrograma;
        }
        

    }
}
