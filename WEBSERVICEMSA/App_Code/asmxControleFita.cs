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
    public class asmxControleFita : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsControleFita Create()
        {
            DTS.dtsControleFita dtsControleFita = new DTS.dtsControleFita();
            return dtsControleFita;
        }
        public DTS.dtsDadosFita CreateDadosFita()
        {
            DTS.dtsDadosFita dtsDadosFita = new DTS.dtsDadosFita();
            return dtsDadosFita;

        }
        
        #region DadosComercial
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsDadosFita  spuDadosComercial(string strCod_Veiculo, DateTime dtData_Exibicao, string strCod_Programa,short shtChave_Acesso)
        {
            DTS.dtsDadosFita  dtsDadosFita ;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsDadosFita = new DTS.dtsDadosFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("Pr_RSA_Dados_Comercial", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue ("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue ("@Par_Data_Exibicao",dtData_Exibicao);
                adp.SelectCommand.Parameters.AddWithValue ("@Par_Cod_Programa", strCod_Programa);
                adp.SelectCommand.Parameters.AddWithValue ("@Par_Chave_Acesso",shtChave_Acesso );
                adp.Fill(dtsDadosFita,"dtbDadosFitaComercial");
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxDadosFita.spuDadosComercial" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsDadosFita;
        }
        #endregion
        #region DadosMaterial
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsDadosFita spuDadosMaterial(string strCod_Empresa, Int32 intNumero_Mr, short shtSequencia_Mr, string strCod_Comercial)
        {
            DTS.dtsDadosFita dtsDadosFita;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsDadosFita = new DTS.dtsDadosFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("Pr_RSA_Dados_Material", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", strCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", intNumero_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", shtSequencia_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_COd_Comercial", strCod_Comercial);
                adp.Fill(dtsDadosFita, "dtbDadosFitaComercial");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxDadosFita.spuDadosMaterial" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsDadosFita;
        }


        #endregion
        #region DadosAvulso
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsDadosFita spuDadosComercialAvulso(string strCod_Veiculo, int intId)
        {
            DTS.dtsDadosFita dtsDadosFita;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsDadosFita = new DTS.dtsDadosFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("Pr_RSA_Dados_Comercial_Avulso", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo:null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_id", intId );
                adp.Fill(dtsDadosFita, "dtbDadosFitaAvulso");
                            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxDadosFita.spuDadosComercialAvulso" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsDadosFita;
        }

        #endregion
        #region DadosArtistico
        [WebMethod, SoapHeader("spAuthenticationHeader")]
       
        public DTS.dtsDadosFita spuDadosComercialArtistico(string strCod_Veiculo, int intId)
        {
            DTS.dtsDadosFita dtsDadosFita;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsDadosFita = new DTS.dtsDadosFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("Pr_RSA_Dados_Comercial_Artistico", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                adp.SelectCommand.Parameters.AddWithValue("@Par_id", intId);
                adp.Fill(dtsDadosFita, "dtbDadosFitaArtistico");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxDadosFita.spuDadosComercialArtistico" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsDadosFita;
        }

        #endregion
        #region DadosNumeracao
        [WebMethod, SoapHeader("spAuthenticationHeader")]

        public DTS.dtsDadosFita spuDadosNumeracao(string strNumero_Fita, string strCod_Veiculo, string strCod_Usuario)
        {
            DTS.dtsDadosFita dtsDadosFita;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsDadosFita = new DTS.dtsDadosFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("Pr_Rsa_Dados_Numeracao", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Fita", strNumero_Fita);
                if (strCod_Veiculo != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Usuario_Sistema", strCod_Usuario);
                adp.Fill(dtsDadosFita.dtbDadosFitaNumeracao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxDadosFita.spuDadosNumeracao" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsDadosFita;
        }

        #endregion
        #region ConsultaFita
        [WebMethod, SoapHeader("spAuthenticationHeader")]

        public DTS.dtsControleFita spuControleFitaConsulta(string strCod_Veiculo,
                                                    string strCod_Programa,
                                                    DateTime dtDataInicio,
                                                    DateTime dtDataFim,
                                                    string strNumero_FitaInicio,
                                                    string strNumero_FitaFim,
                                                    string strCod_Empresa,
                                                    long lngContrato,
                                                    short shtSequencia,
                                                    string strLegenda,
                                                    string strCod_Tipo_Comercial,
                                                    string strAgencia,
                                                    string strCliente,
                                                    byte btIndicaNumerada,
                                                    byte btIndicaPendente,
                                                    byte btIndicaAtiva,
                                                    byte btIndicaDesativada,
                                                    byte btIndicaAvulso,
                                                    byte btIndicaArtistico,
                                                    byte btIndicaRelatorio,
                                                    string strUsuario,
                                                    string strProduto)
        {
            DTS.dtsControleFita dtsControleFita;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();

            try
            {
                dtsControleFita = new DTS.dtsControleFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Sp_Consulta_Fitas_Afiliadas", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (strCod_Veiculo != "") adp.SelectCommand.Parameters.AddWithValue("@Ppar_Veiculo", strCod_Veiculo);
                if (strCod_Programa != "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Programa", strCod_Programa);
                if (dtDataFim.Date != DateTime.MinValue) adp.SelectCommand.Parameters.AddWithValue("@pPar_Inicio", dtDataInicio);
                if (dtDataFim.Date != DateTime.MinValue) adp.SelectCommand.Parameters.AddWithValue("@pPar_Fim", dtDataFim);
                if (strNumero_FitaInicio != "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Numero_Fita_Inicio", strNumero_FitaInicio);
                if (strNumero_FitaFim != "") adp.SelectCommand.Parameters.AddWithValue("@Ppar_Numero_Fita_Fim", strNumero_FitaFim);
                if (strCod_Empresa != "") adp.SelectCommand.Parameters.AddWithValue("@Ppar_Empresa", strCod_Empresa);
                if (lngContrato > 0) adp.SelectCommand.Parameters.AddWithValue("@Ppar_Contrato", lngContrato);
                if (shtSequencia > 0) adp.SelectCommand.Parameters.AddWithValue("@Ppar_Sequencia", shtSequencia);
                if (strLegenda != "") adp.SelectCommand.Parameters.AddWithValue("@Ppar_Legenda", strLegenda);
                if (strCod_Tipo_Comercial != "") adp.SelectCommand.Parameters.AddWithValue("@Ppar_Tipo_Comercial", strCod_Tipo_Comercial);
                if (strAgencia != "") adp.SelectCommand.Parameters.AddWithValue("@Ppar_Agencia", strAgencia);
                if (strCliente != "") adp.SelectCommand.Parameters.AddWithValue("@Ppar_Cliente", strCliente);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Numerada", btIndicaNumerada);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Pendentes", btIndicaPendente);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Indica_Ativa", btIndicaAtiva);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Indica_Desativada", btIndicaDesativada);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Avulso", btIndicaAvulso);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Artistico", btIndicaArtistico);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Indica_Relatorio", btIndicaRelatorio);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Usuario_Sistema", strUsuario);
                if (strProduto != "") adp.SelectCommand.Parameters.AddWithValue("@Ppar_Produto", strProduto);

                adp.Fill(dtsControleFita, "dtbConsultaFita");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuControleFitaConsulta" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsControleFita;
        }

        #endregion
        #region Atualizar-Exclusao
        [WebMethod, SoapHeader("spAuthenticationHeader")]
		
            public DTS.dtsControleFita spuAtualizar(DTS.dtsControleFita dtsControleFita)
		{
			
			Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
			SqlDataAdapter adp = new SqlDataAdapter();
			try
			{
			    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.InsertCommand = Cnn.NewCommand("Pr_RSA_Controle_Fitas_D", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", (SqlDbType.Char), 3, "Cod_Empresa");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Mr", (SqlDbType.Int), 6, "Numero_Mr");
                adp.InsertCommand.Parameters.Add("@Par_Sequencia_Mr", (SqlDbType.SmallInt), 3, "Sequencia_Mr");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.SmallInt), 3, "Cod_Veiculo");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Comercial", (SqlDbType.Char),2, "Cod_Comercial");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.InsertCommand.Parameters.Add("@Par_Id_Fita", (SqlDbType.Int), 6, "Id_Chave");
                adp.InsertCommand.Parameters.Add("@Par_Origem", (SqlDbType.Char), 10, "Origem");
                adp.InsertCommand.Parameters.Add("@Par_Usuario", (SqlDbType.Char), 20, "Cod_Usuario");

                adp.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
                adp.Update(dtsControleFita.dtbFitaTemp_Exclusao );
				
			}
			catch(SqlException ex)
			{
                throw new Exception("Erro dtsControleFita.spuAtualizar " + ex.Message.ToString());
			}
			finally
			{
				Cnn.spuClose();
			}
		return dtsControleFita;		
		}
        #endregion
        #region Desativar
        [WebMethod, SoapHeader("spAuthenticationHeader")]

        public DTS.dtsControleFita spuDesativar(DTS.dtsControleFita dtsControleFita)
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.InsertCommand = Cnn.NewCommand("Pr_RSA_Controle_Fitas_U", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", (SqlDbType.Char), 3, "Cod_Empresa");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Mr", (SqlDbType.Int), 6, "Numero_Mr");
                adp.InsertCommand.Parameters.Add("@Par_Sequencia_Mr", (SqlDbType.SmallInt), 3, "Sequencia_Mr");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Comercial", (SqlDbType.Char), 2, "Cod_Comercial");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.InsertCommand.Parameters.Add("@Par_Id_Fita", (SqlDbType.Int), 6, "Id_Chave");
                adp.InsertCommand.Parameters.Add("@Par_Origem", (SqlDbType.Char), 10, "Origem");
                adp.InsertCommand.Parameters.Add("@Par_Usuario", (SqlDbType.Char), 20, "Cod_Usuario");

                adp.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
                adp.Update(dtsControleFita.dtbFitaTemp_Desativacao);

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro dtsControleFita.spuAtualizar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsControleFita;
        }
        #endregion
        #region FitaDisponivel
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public string spuFitaDisponivel( string strCod_Veiculo, 
                                        int intInicio,
                                        int intFim, 
                                        short shTipo ,
                                        string strCod_Usuario,
                                        short shIndica_Relatorio)
        {
          
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            //SqlDataAdapter adp = new SqlDataAdapter();
            SqlDataReader sqlR;
            SqlCommand sqlC;
            string funcao = "";
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                sqlC = Cnn.NewCommand("Sp_Ru_Fita_Disponivel", Cnn.spuConnection);
                sqlC.CommandType = CommandType.StoredProcedure;
                sqlC.Parameters.AddWithValue("@Par_Cod_Veiculo", (strCod_Veiculo.Length != 0 ? strCod_Veiculo : null));
                if (intInicio != -1)
                {
                    sqlC.Parameters.AddWithValue("@Par_Inicio", intInicio);
                }
                      
                if (intFim != -1)
                {
                    sqlC.Parameters.AddWithValue("@Par_Fim", intFim);
                }
                
                if (shTipo != -1 )
                {
                    sqlC.Parameters.AddWithValue("@Par_Tipo", shTipo);
                }
                
                sqlC.Parameters.AddWithValue("@Par_Cod_Usuario", (strCod_Usuario.Length != 0 ? strCod_Usuario: null));
                if (shIndica_Relatorio != -1)
                {
                    sqlC.Parameters.AddWithValue("@Par_Indica_Relatorio", shIndica_Relatorio);
                }
                

                sqlR = sqlC.ExecuteReader();
                sqlR.Read();

                if (sqlR.HasRows)
                {
                    funcao = sqlR.GetString(sqlR.GetOrdinal("Numero_Fita"));
                }
                sqlR.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro spuFitaDisponivel" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return (funcao);

        }
        #endregion
        #region spuAtualizar_DadosFitaArtistico

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuAtualizar_FitaArtistico(DTS.dtsDadosFita dtsDadosFita)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);




                adp.InsertCommand = Cnn.NewCommand("prNet_Depositorio_Artistico_Afiliadas_I", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Parameters.Add("@Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.InsertCommand.Parameters.Add("@Cod_Veiculo", (SqlDbType.Char), 3,  "Cod_Veiculo");
                //if (int.Parse("Cod_Red_Produto") != -1)
                //{
                    adp.InsertCommand.Parameters.Add("@Cod_Red_Produto", (SqlDbType.Int), 4, "Cod_Red_Produto");
                //}
                adp.InsertCommand.Parameters.Add("@Data_Inicio", (SqlDbType.DateTime), 19, "Data_Inicio");
                adp.InsertCommand.Parameters.Add("@Data_Final", (SqlDbType.DateTime), 19, "Data_Final");
                adp.InsertCommand.Parameters.Add("@Cod_Tipo_Comercial", (SqlDbType.Char), 2, "Cod_Tipo_Comercial");
                adp.InsertCommand.Parameters.Add("@Titulo_Comercial", (SqlDbType.Char), 30, "Titulo_Comercial");
                adp.InsertCommand.Parameters.Add("@Duracao", (SqlDbType.Decimal), 9, "Duracao");
                adp.InsertCommand.Parameters.Add("@Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
                adp.InsertCommand.Parameters.Add("@Qtde", (SqlDbType.SmallInt), 2, "Qtde");
                adp.InsertCommand.Parameters.Add("@Saldo", (SqlDbType.Int), 4, "Saldo");
                adp.InsertCommand.Parameters.Add("@Indica_Desativado", (SqlDbType.TinyInt), 1, "Indica_Desativado");
                adp.InsertCommand.Parameters.Add("@Observacao", (SqlDbType.NVarChar), 2000, "Observacao");
                adp.InsertCommand.Parameters.Add("@Indica_Dom", (SqlDbType.Bit), 1, "Indica_Dom");
                adp.InsertCommand.Parameters.Add("@Indica_Seg", (SqlDbType.Bit), 1, "Indica_Seg");
                adp.InsertCommand.Parameters.Add("@Indica_Ter", (SqlDbType.Bit), 1, "Indica_Ter");
                adp.InsertCommand.Parameters.Add("@Indica_Qua", (SqlDbType.Bit), 1, "Indica_Qua");
                adp.InsertCommand.Parameters.Add("@Indica_Qui", (SqlDbType.Bit), 1, "Indica_Qui");
                adp.InsertCommand.Parameters.Add("@Indica_Sex", (SqlDbType.Bit), 1, "Indica_Sex");
                adp.InsertCommand.Parameters.Add("@Indica_Sab", (SqlDbType.Bit), 1, "Indica_Sab");
                adp.InsertCommand.Parameters.Add("@Cod_Programa_Ar", (SqlDbType.Char), 4, ("Cod_Programa_Ar".Length != 0 ? "Cod_Programa_Ar" : null));


                adp.UpdateCommand = Cnn.NewCommand("prNet_Depositorio_Artistico_Afiliadas_U", Cnn.spuConnection);
                adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adp.UpdateCommand.Connection = Cnn.spuConnection;
                adp.UpdateCommand.Parameters.Add("@IdChave", (SqlDbType.Int), 4, "IdChave");
                adp.UpdateCommand.Parameters.Add("@Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.UpdateCommand.Parameters.Add("@Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                //if (int.Parse("Cod_Red_Produto") != -1)
                //{
                    adp.UpdateCommand.Parameters.Add("@Cod_Red_Produto", (SqlDbType.Int), 4, "Cod_Red_Produto");
                //}
                adp.UpdateCommand.Parameters.Add("@Data_Inicio", (SqlDbType.DateTime), 19, "Data_Inicio");
                adp.UpdateCommand.Parameters.Add("@Data_Final", (SqlDbType.DateTime), 19, "Data_Final");
                adp.UpdateCommand.Parameters.Add("@Cod_Tipo_Comercial", (SqlDbType.Char), 2, "Cod_Tipo_Comercial");
                adp.UpdateCommand.Parameters.Add("@Titulo_Comercial", (SqlDbType.Char), 30, "Titulo_Comercial");
                adp.UpdateCommand.Parameters.Add("@Duracao", (SqlDbType.Decimal), 9, "Duracao");
                adp.UpdateCommand.Parameters.Add("@Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
                adp.UpdateCommand.Parameters.Add("@Qtde", (SqlDbType.SmallInt), 2, "Qtde");
                adp.UpdateCommand.Parameters.Add("@Saldo", (SqlDbType.Int), 4, "Saldo");
                adp.UpdateCommand.Parameters.Add("@Indica_Desativado", (SqlDbType.TinyInt), 1, "Indica_Desativado");
                adp.UpdateCommand.Parameters.Add("@Observacao", (SqlDbType.NVarChar), 2000, "Observacao");
                adp.UpdateCommand.Parameters.Add("@Indica_Dom", (SqlDbType.Bit), 1, "Indica_Dom");
                adp.UpdateCommand.Parameters.Add("@Indica_Seg", (SqlDbType.Bit), 1, "Indica_Seg");
                adp.UpdateCommand.Parameters.Add("@Indica_Ter", (SqlDbType.Bit), 1, "Indica_Ter");
                adp.UpdateCommand.Parameters.Add("@Indica_Qua", (SqlDbType.Bit), 1, "Indica_Qua");
                adp.UpdateCommand.Parameters.Add("@Indica_Qui", (SqlDbType.Bit), 1, "Indica_Qui");
                adp.UpdateCommand.Parameters.Add("@Indica_Sex", (SqlDbType.Bit), 1, "Indica_Sex");
                adp.UpdateCommand.Parameters.Add("@Indica_Sab", (SqlDbType.Bit), 1, "Indica_Sab");
                adp.UpdateCommand.Parameters.Add("@Cod_Programa_Ar", (SqlDbType.Char), 4, ("Cod_Programa_Ar".Length != 0 ? "Cod_Programa_Ar" : null));


                adp.Update(dtsDadosFita.dtbDadosFitaArtistico);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuAtualizar_FitaArtistico " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }

        #endregion
        #region spuAtualizar_DadosFitaAvulso

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuAtualizar_FitaAvulso(DTS.dtsDadosFita dtsDadosFita)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.InsertCommand = Cnn.NewCommand("prNet_Depositorio_Avulso_Afiliadas_I", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Parameters.Add("@Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.InsertCommand.Parameters.Add("@Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                //if (int.Parse("Cod_Red_Produto") != -1)
                //{
                    adp.InsertCommand.Parameters.Add("@Cod_Red_Produto", (SqlDbType.Int), 4, "Cod_Red_Produto");
                //}

                adp.InsertCommand.Parameters.Add("@Data_Inicio", (SqlDbType.DateTime), 19, "Data_Inicio");
                adp.InsertCommand.Parameters.Add("@Data_Final", (SqlDbType.DateTime), 19, "Data_Final");
                adp.InsertCommand.Parameters.Add("@Cod_Tipo_Comercial", (SqlDbType.Char), 2, "Cod_Tipo_Comercial");
                adp.InsertCommand.Parameters.Add("@Titulo_Comercial", (SqlDbType.Char), 30, "Titulo_Comercial");
                adp.InsertCommand.Parameters.Add("@Duracao", (SqlDbType.Decimal), 9, "Duracao");
                adp.InsertCommand.Parameters.Add("@Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");
                adp.InsertCommand.Parameters.Add("@Qtde", (SqlDbType.SmallInt), 2, "Qtde");
                adp.InsertCommand.Parameters.Add("@Saldo", (SqlDbType.Int), 4, "Saldo");
                adp.InsertCommand.Parameters.Add("@Indica_Desativado", (SqlDbType.TinyInt), 1, "Indica_Desativado");
                adp.InsertCommand.Parameters.Add("@Observacao", (SqlDbType.NVarChar), 2000, "Observacao");
                adp.InsertCommand.Parameters.Add("@Indica_Dom", (SqlDbType.Bit), 1, "Indica_Dom");
                adp.InsertCommand.Parameters.Add("@Indica_Seg", (SqlDbType.Bit), 1, "Indica_Seg");
                adp.InsertCommand.Parameters.Add("@Indica_Ter", (SqlDbType.Bit), 1, "Indica_Ter");
                adp.InsertCommand.Parameters.Add("@Indica_Qua", (SqlDbType.Bit), 1, "Indica_Qua");
                adp.InsertCommand.Parameters.Add("@Indica_Qui", (SqlDbType.Bit), 1, "Indica_Qui");
                adp.InsertCommand.Parameters.Add("@Indica_Sex", (SqlDbType.Bit), 1, "Indica_Sex");
                adp.InsertCommand.Parameters.Add("@Indica_Sab", (SqlDbType.Bit), 1, "Indica_Sab");


                adp.UpdateCommand = Cnn.NewCommand("prNet_Depositorio_Avulso_Afiliadas_U", Cnn.spuConnection);
                adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adp.UpdateCommand.Connection = Cnn.spuConnection;
                adp.UpdateCommand.Parameters.Add("@IdChave", (SqlDbType.Int), 4, "IdChave");
                adp.UpdateCommand.Parameters.Add("@Numero_Fita", (SqlDbType.Char),10, "Numero_Fita");
                adp.UpdateCommand.Parameters.Add("@Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
              //  if (int.Parse("Cod_Red_Produto") != -1)
               // {
                    adp.UpdateCommand.Parameters.Add("@Cod_Red_Produto", (SqlDbType.Int), 4, "Cod_Red_Produto");
                //}

                adp.UpdateCommand.Parameters.Add("@Data_Inicio", (SqlDbType.DateTime), 19, "Data_Inicio");
                adp.UpdateCommand.Parameters.Add("@Data_Final", (SqlDbType.DateTime), 19, "Data_Final");
                adp.UpdateCommand.Parameters.Add("@Cod_Tipo_Comercial", (SqlDbType.Char), 2, "Cod_Tipo_Comercial");
                adp.UpdateCommand.Parameters.Add("@Titulo_Comercial", (SqlDbType.Char), 30,"Titulo_Comercial");
                adp.UpdateCommand.Parameters.Add("@Duracao", (SqlDbType.Decimal), 9, "Duracao");  
                adp.UpdateCommand.Parameters.Add("@Cod_Programa", (SqlDbType.Char), 4, "Cod_Programa");    
                adp.UpdateCommand.Parameters.Add("@Qtde", (SqlDbType.SmallInt), 2, "Qtde");
                adp.UpdateCommand.Parameters.Add("@Saldo", (SqlDbType.Int), 4, "Saldo");
                adp.UpdateCommand.Parameters.Add("@Indica_Desativado", (SqlDbType.TinyInt), 1, "Indica_Desativado");
                adp.UpdateCommand.Parameters.Add("@Observacao", (SqlDbType.NVarChar), 2000, "Observacao");
                adp.UpdateCommand.Parameters.Add("@Indica_Dom", (SqlDbType.Bit), 1, "Indica_Dom");
                adp.UpdateCommand.Parameters.Add("@Indica_Seg", (SqlDbType.Bit), 1, "Indica_Seg");
                adp.UpdateCommand.Parameters.Add("@Indica_Ter", (SqlDbType.Bit), 1, "Indica_Ter");
                adp.UpdateCommand.Parameters.Add("@Indica_Qua", (SqlDbType.Bit), 1, "Indica_Qua");
                adp.UpdateCommand.Parameters.Add("@Indica_Qui", (SqlDbType.Bit), 1, "Indica_Qui");
                adp.UpdateCommand.Parameters.Add("@Indica_Sex", (SqlDbType.Bit), 1, "Indica_Sex");
                adp.UpdateCommand.Parameters.Add("@Indica_Sab", (SqlDbType.Bit), 1, "Indica_Sab");
                adp.Update(dtsDadosFita.dtbDadosFitaAvulso);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuAtualizar_FitaAvulso " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }

        #endregion
        #region Numeracao
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuDeletarReserva(String pCodUsuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd ;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd = Cnn.NewCommand("Pr_Rsa_Controle_Fita_DeletarReserva", Cnn.spuConnection);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Connection = Cnn.spuConnection;
                Cmd.Parameters.AddWithValue("@Par_Cod_Usuario", pCodUsuario);
                Cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuDeletarReserva " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }


        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuNumerar(DTS.dtsControleFita dtsControleFita)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.InsertCommand = Cnn.NewCommand("Pr_Rsa_Controle_Fita_Numeracao", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Connection = Cnn.spuConnection;
                adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", (SqlDbType.Char), 4, "Cod_Empresa");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Mr", (SqlDbType.Int ), 6, "Numero_Mr");
                adp.InsertCommand.Parameters.Add("@Par_Sequencia_Mr", (SqlDbType.SmallInt), 2, "Sequencia_Mr");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Comercial", (SqlDbType.Char), 2, "Cod_Comercial");
                adp.InsertCommand.Parameters.Add("@Par_Cod_Veiculo", (SqlDbType.Char), 3, "Cod_Veiculo");
                adp.InsertCommand.Parameters.Add("@Par_Duracao", (SqlDbType.SmallInt ), 2, "Duracao");
                adp.InsertCommand.Parameters.Add("@Par_Numero_Fita", (SqlDbType.Char), 10, "Numero_Fita");
                adp.InsertCommand.Parameters.Add("@Par_Localizacao", (SqlDbType.Char), 50, "Localizacao");
                adp.InsertCommand.Parameters.Add("@Par_Usuario", (SqlDbType.Char), 30, "Cod_Usuario");
                adp.Update(dtsControleFita.dtbNumeracao);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuNumerar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        #endregion
        #region ConsultaMidia
        [WebMethod, SoapHeader("spAuthenticationHeader")]

        public DTS.dtsDadosFita  spuConsultaDadosMidia  (   string strCod_Empresa,
                                                            long lngContrato,
                                                            short shtSequencia,
                                                            string strLegenda ,
                                                            string strCod_Usuario
                                                        )
        {
            DTS.dtsDadosFita dtsDadosFita;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();

            try
            {
                dtsDadosFita = new DTS.dtsDadosFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Pr_Rsa_Controle_Fita_Consulta_Dados_Midia", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (strCod_Empresa != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", strCod_Empresa);
                if (lngContrato > 0) adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", lngContrato);
                if (shtSequencia > 0) adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", shtSequencia);
                if (strLegenda != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Comercial", strLegenda);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Usuario", strCod_Usuario);
                adp.Fill(dtsDadosFita,"dtbDadosMidia");            
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuConsultaDadosMidia" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsDadosFita;
        }
        #endregion
        #region Veiculos da Fita
        [WebMethod, SoapHeader("spAuthenticationHeader")]

        public DTS.dtsDadosFita spuCarregarVeiculosFita (string strCod_Empresa,
                                                            long lngContrato,
                                                            short shtSequencia,
                                                            string strLegenda,
                                                            string strCod_Usuario
                                                        )
        {
            DTS.dtsDadosFita dtsDadosFita;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();

            try
            {
                dtsDadosFita = new DTS.dtsDadosFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Pr_Rsa_Controle_Fita_Veiculos", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", strCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", lngContrato);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", shtSequencia);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Comercial", strLegenda);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Usuario", strCod_Usuario);
                adp.Fill(dtsDadosFita.dtbFitaVeiculo );
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuCarregarVeiculosFita" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsDadosFita;
        }
        #endregion
        #region Consulta Veiculos da Midia
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsDadosFita spuCarregarVeiculosMidia(       string strCod_Empresa,
                                                                long lngContrato,
                                                                short shtSequencia,
                                                                string strLegenda,
                                                                string strCod_Usuario
                                                        )
        {
            DTS.dtsDadosFita dtsDadosFita;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();

            try
            {
                dtsDadosFita = new DTS.dtsDadosFita();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("Pr_Rsa_Controle_Fita_Veiculos_Midia", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", strCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", lngContrato);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", shtSequencia);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Comercial", strLegenda);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Usuario", strCod_Usuario);
                adp.Fill(dtsDadosFita.dtbMidiaVeiculo);
            }
            catch (Exception ex)
            {
                    throw new Exception("Erro asmxControleFita.spuCarregarVeiculosMidia" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsDadosFita;
        }
        #endregion
        #region FitasPatrocinio
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable  spuCarregarFitaPatrocinio(string strCodVeiculo,
                                                          string strCodPrograma ,
                                                          long  lngCompetencia
                                                        )
        {
            DataSet dtsFitaPatrocinio  = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("Pr_Fita_Patrocinio_Select", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", strCodVeiculo );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", strCodPrograma );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Competencia", lngCompetencia );
                adp.Fill(dtsFitaPatrocinio);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuCarregarFitaPatrocinio" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(dtsFitaPatrocinio.Tables[0]);
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuGravarFitaPatrocinio(Int32 pCompetencia,String pCodVeiculo,String pCodPrograma, DataTable dtbNumeracaoFita, String  pCodUsuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            SqlDataReader sqlR;
            SqlCommand sqlC;
            string Id_Processo = "";
            try
            {
                //====================Obtem um Id 
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                sqlC = Cnn.NewCommand("select Convert(char(50),newid()) as coluna", Cnn.spuConnection);
                sqlR = sqlC.ExecuteReader();
                sqlR.Read();
                if (sqlR.HasRows)
                Id_Processo = sqlR.GetString(sqlR.GetOrdinal("coluna"));
                sqlR.Close();
                
                //====================Grava cada Linha do DataSet na Temporaria de Manutencao
                //Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd = Cnn.NewCommand("Pr_Fita_Patrocinio_Manutencao_Insert", Cnn.spuConnection);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Connection = Cnn.spuConnection;
                foreach (DataRow drw in dtbNumeracaoFita.Rows )
                {
                    if (drw["Cod_Tipo_Comercial"]  != DBNull.Value  &&
                        drw["Numero_Fita"]  != DBNull.Value  &&
                        drw["Dia_Inicio"]  != DBNull.Value  &&
                        drw["Dia_Fim"] != DBNull.Value   
                        )
                    {
                        Cmd.Parameters.Clear();
                        Cmd.Parameters.AddWithValue("@Par_Identificador", Id_Processo);
                        Cmd.Parameters.AddWithValue("@Par_Competencia", pCompetencia);
                        Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", pCodVeiculo);
                        Cmd.Parameters.AddWithValue("@Par_Cod_programa", pCodPrograma);
                        Cmd.Parameters.AddWithValue("@Par_Cod_Tipo_Comercial", drw["Cod_Tipo_Comercial"].ToString());
                        Cmd.Parameters.AddWithValue("@Par_Numero_Fita", drw["Numero_Fita"].ToString());
                        Cmd.Parameters.AddWithValue("@Par_Dia_Inicio", drw["Dia_Inicio"].ToString());
                        Cmd.Parameters.AddWithValue("@Par_Dia_Fim", drw["Dia_Fim"].ToString());
                        Cmd.Parameters.AddWithValue("@Par_Obs_Texto", drw["Obs_Texto"].ToString());
                        Cmd.Parameters.AddWithValue("@Par_Duracao_Cabeca", drw["Duracao_Cabeca"].ToString());
                        Cmd.ExecuteNonQuery();    
                        
                    }
                    
                }
                
                //====================Efetiva a Gravacao

                Cmd = Cnn.NewCommand("Pr_Fita_Patrocinio_Insert", Cnn.spuConnection);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Connection = Cnn.spuConnection;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Par_Identificador", Id_Processo );
                Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", pCodVeiculo );
                Cmd.Parameters.AddWithValue("@Par_Cod_Programa", pCodPrograma );
                Cmd.Parameters.AddWithValue("@Par_Competencia", pCompetencia );
                Cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuGravarFitaPatrocinio " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public String spuConsisteFitaPatrocinio(String pCodVeiculo,DateTime pDataInicio,DateTime pDataFim,String pCodPrograma,String pNumeroFita, String pCodTipoComercial)
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            SqlDataReader sqlR;
            String strRetorno = "";
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd = Cnn.NewCommand("Pr_Fita_Patrocinio_Consiste", Cnn.spuConnection);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", pCodVeiculo);
                Cmd.Parameters.AddWithValue("@Par_Data_Inicio", pDataInicio);
                Cmd.Parameters.AddWithValue("@Par_Data_Fim", pDataFim);
                Cmd.Parameters.AddWithValue("@Par_Cod_Programa", pCodPrograma);
                Cmd.Parameters.AddWithValue("@Par_Numero_Fita", pNumeroFita);
                Cmd.Parameters.AddWithValue("@Par_Cod_Tipo_Comercial", pCodTipoComercial);
                sqlR = Cmd.ExecuteReader();
                sqlR.Read();
                if (sqlR.HasRows)
                    strRetorno = sqlR.GetString(sqlR.GetOrdinal("Critica"));
                sqlR.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuConsisteFitaPatrocinio " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return strRetorno; 
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable spuConsultaFitaPatrocinio( Int32 lngCompetencia,
                                                    String strCodPrograma,
                                                    String StrCodVeiculo,
                                                    String strFitaInicial,
                                                    String strFitaFinal,
                                                    String strTipoComercial,
                                                    String strUsuario
                                                   )
        {
            DataSet dtsFitaPatrocinio = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("Pr_Fita_Patrocinio_Consulta", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Competencia", lngCompetencia);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", strCodPrograma );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", StrCodVeiculo );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Fita_Inicial", strFitaInicial );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Fita_Final", strFitaFinal );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Tipo_Comercial", strTipoComercial );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Usuario", strUsuario );
                adp.Fill(dtsFitaPatrocinio);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuConsultaFitaPatrocinio" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(dtsFitaPatrocinio.Tables[0]);
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuDesativarFitaPatrocinio(Int32 IdFita)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd = Cnn.NewCommand("Pr_Fita_Patrocinio_Desativar", Cnn.spuConnection);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Par_Id_Fita_Patrocinio", IdFita );
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuConsultaFitaPatrocinio" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuExcluirFitaPatrocinio(Int32 IdFita)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd = Cnn.NewCommand("Pr_Fita_Patrocinio_Excluir", Cnn.spuConnection);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Par_Id_Fita_Patrocinio", IdFita);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxControleFita.spuExcluirFitaPatrocinio" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        #endregion
    }
}
