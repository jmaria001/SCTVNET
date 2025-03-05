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
    public class asmxChecking : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxChecking()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean  fnFuncao_Baixa_Alteracao(   DateTime dData_Exibicao ,
                                                    string  sCod_Veiculo ,
                                                    string sCod_Programa ,
                                                    int nChave_Acesso ,
                                                    string sQualidade ,
                                                    int nIndica_Convidado ,
                                                    DateTime dHorario ,
                                                    string sUsuario ,
                                                    int nParametro_usuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd =  Cnn.NewCommand();
            try
            {
                
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection; 
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "Sp_Baixa_Alteracao ";
                Cmd.Parameters.AddWithValue("@Data_Exibicao", dData_Exibicao);
                Cmd.Parameters.AddWithValue("@Cod_Veiculo", sCod_Veiculo);
                if (  sCod_Programa != "" )
                {
                    Cmd.Parameters.AddWithValue("@Cod_Programa", sCod_Programa);
                }
                Cmd.Parameters.AddWithValue("@Chave_Acesso", nChave_Acesso);
                Cmd.Parameters.AddWithValue("@Cod_Qualidade_Nova", sQualidade);
                Cmd.Parameters.AddWithValue("@Indica_Convidado", nIndica_Convidado);
                if (dHorario.Year > 1999)
                {
                    Cmd.Parameters.AddWithValue("@Data_Limite", dHorario);
                    
                }
                else
                {
                    Cmd.Parameters.AddWithValue("@Data_Limite", DBNull.Value );
                }
                Cmd.Parameters.AddWithValue("@Cod_Usuario", sUsuario);
                Cmd.Parameters.AddWithValue("@Horario_Fim", dHorario);

                Cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally 
            {
                Cnn.spuClose();
            }
            
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public int fnBaixaRoteiro(      string pCodVeiculo      ,
                                        DateTime pDataInicio    ,
                                        DateTime pDataFim       ,
                                        String   pCodPrograma  ,
                                        String   pTipoComercial ,
                                        String   pQualidade     ,
                                        String   pDiaSemana     ,
                                        String   pUsuario       
                                        )
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd =  Cnn.NewCommand();
            SqlDataReader Dtr ;
            int qtdRegistro = 0 ;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection; 
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PrNet_Baixa_Roteiro";

                Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", pCodVeiculo  );
                Cmd.Parameters.AddWithValue("@Par_Data_Inicio", pDataInicio );
                Cmd.Parameters.AddWithValue("@Par_Data_Fim", pDataFim );
                Cmd.Parameters.AddWithValue("@Par_Programa", pCodPrograma );
                Cmd.Parameters.AddWithValue("@Par_Tipo_Comercial", pTipoComercial );
                Cmd.Parameters.AddWithValue("@Par_Cod_Qualidade", pQualidade );
                Cmd.Parameters.AddWithValue("@Par_Dia_Semana", pDiaSemana);
                Cmd.Parameters.AddWithValue("@Par_Usuario", pUsuario);
                
                Dtr  = Cmd.ExecuteReader();
                Dtr.Read();
                int.TryParse(Dtr[0].ToString(), out qtdRegistro);
                return qtdRegistro;
            }
            catch(Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally 
            {
                Cnn.spuClose();
            }
            
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean  fnFuncao_Baixa(     DateTime    dData_Exibicao ,
                                            string      sCod_Veiculo ,
                                            string      sCod_Programa ,
                                            int         nChave_Acesso ,
                                            string      sCod_Qualidade ,
                                            string      sDocumento_Para ,
                                            int         nIndica_Convidado ,
                                            DateTime    dHorario ,
                                            string      sUsuario ,
                                            int         nIndica_Merchandising ,
                                            DateTime    dHorario_Fim, 
                                            int         nDuracao_Real ,
                                            string      sObservacao ,
                                            int         nIndica_IEM ,
                                            int         nQtde_Parametros ) 
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD; 
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "Sp_Baixa";
                Cmd.Parameters.AddWithValue("@Data_Exibicao", dData_Exibicao);
                Cmd.Parameters.AddWithValue("@Cod_Veiculo", sCod_Veiculo);
                Cmd.Parameters.AddWithValue("@Cod_Programa", sCod_Programa);
                Cmd.Parameters.AddWithValue("@Chave_Acesso", nChave_Acesso);
                Cmd.Parameters.AddWithValue("@Cod_Qualidade", sCod_Qualidade);
                Cmd.Parameters.AddWithValue("@Documento_Para", sDocumento_Para);
                Cmd.Parameters.AddWithValue("@Indica_Convidado", nIndica_Convidado);
                if (dHorario.Year > 1999)
                {
                    Cmd.Parameters.AddWithValue("@Data_Limite", dHorario);

                }
                else
                {
                    Cmd.Parameters.AddWithValue("@Data_Limite", DBNull.Value);
                }

                Cmd.Parameters.AddWithValue("@Cod_Usuario", sUsuario);
                if  (nQtde_Parametros > 8)
                {
                    Cmd.Parameters.AddWithValue("@Indica_Merchandising", nIndica_Merchandising);
                }
                if  (nQtde_Parametros > 9)
                {
                    Cmd.Parameters.AddWithValue("@Horario_Fim", dHorario_Fim);
                }
                if  (nQtde_Parametros > 10 ) 
                {
                    Cmd.Parameters.AddWithValue("@Duracao_Real", nDuracao_Real);
                }
                
                Cmd.Parameters.AddWithValue("@Observacao", sObservacao);
                if  (nQtde_Parametros > 12 ) 
                {
                    Cmd.Parameters.AddWithValue("@Indica_IEM", nIndica_IEM);
                }
                RD = Cmd.ExecuteReader();
                RD.Read();
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
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean  fnConsisteQualidadeBaixa(string sBaixa )
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD;
            SqlCommand Cmd = Cnn.NewCommand();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection ;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_Qualidade_S";
                Cmd.Parameters.AddWithValue("@strQualidadeCodigo_P", sBaixa);
                RD = Cmd.ExecuteReader();
                RD.Read();
                if (RD.HasRows )
                    return true;
                else
                    return false ;
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

        [WebMethod, SoapHeader("spAuthenticationHeader")]            
        public Boolean fnFuncao_Baixa_Exclusao(DateTime dData_Exibicao , 
                                               string sCod_Veiculo , 
                                               string sCod_Programa ,                                               
                                                int nChave_Acesso , 
                                               int nIndica_Convidado , 
                                               DateTime  dHorario ,
                                               string sUsuario ,
                                               int nIndica_Merchandising ,
                                               DateTime dHorario_Fim ,
                                               int nDuracao_Real ,
                                               int nIndica_Iem ,
                                               int nIndica_Reencaixe ,
                                               int nIndica_Aguardar_Aprovacao ,
                                               int nQtde_Parametros )
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD;
            SqlCommand  Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);   
                Cmd.Connection = Cnn.spuConnection ;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "SP_BAIXA_EXCLUSAO";
                Cmd.Parameters.AddWithValue("@Data_Exibicao", dData_Exibicao);
                Cmd.Parameters.AddWithValue("@Cod_Veiculo", sCod_Veiculo);
                Cmd.Parameters.AddWithValue("@Cod_Programa", sCod_Programa);
                Cmd.Parameters.AddWithValue("@Chave_Acesso", nChave_Acesso);
                Cmd.Parameters.AddWithValue("@Indica_Convidado", nIndica_Convidado);
                if (dHorario.Year > 1999)
                {
                    Cmd.Parameters.AddWithValue("@Data_Limite", dHorario);

                }
                else
                {
                    Cmd.Parameters.AddWithValue("@Data_Limite", DBNull.Value);
                }

                Cmd.Parameters.AddWithValue("@Cod_Usuario", sUsuario);
                if (nQtde_Parametros > 6 ) 
                {
                    Cmd.Parameters.AddWithValue("@Indica_Merchandising", nIndica_Merchandising);
                }

                if (nQtde_Parametros > 7)
                {
                    Cmd.Parameters.AddWithValue("@Horario_Fim", dHorario_Fim);
                }
                
                if (nQtde_Parametros > 8 )
                {
                    Cmd.Parameters.AddWithValue("@Duracao_Real", nDuracao_Real);
                }
                
                if (nQtde_Parametros > 9) 
                {
                    Cmd.Parameters.AddWithValue("@Indica_Iem", nIndica_Iem);
                }
                if (nQtde_Parametros > 10 )
                {
                    Cmd.Parameters.AddWithValue("@Indica_Reencaixe", nIndica_Reencaixe);
                }
                if (nQtde_Parametros > 11 ) 
                {
                    Cmd.Parameters.AddWithValue("@Indica_Aguardar_Aprovacao", nIndica_Aguardar_Aprovacao);
                }

                RD = Cmd.ExecuteReader();
                RD.Read();
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
    

        [WebMethod, SoapHeader("spAuthenticationHeader")]            
        public DataSet  fnFuncao_Consulta_Veiculacao_Baixa(string sCod_Veiculo ,
                                                     DateTime dData_Exibicao ,
                                                     string sCod_Programa ,
                                                     int nChave_Acesso ,
                                                     string sCod_Empresa ,
                                                     int nNumero_Nr ,
                                                     int nSequencia_Nr ,
                                                     string sCod_Comercial ,
                                                     int nDuracao ,
                                                     Boolean bolBaixadas) 
        {
                                                         

            DataSet  DTS =  new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new  SqlDataAdapter() ;

            try 
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", sCod_Veiculo);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Exibicao", dData_Exibicao);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", sCod_Programa);
                if (nChave_Acesso != 0 )
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Chave_Acesso", nChave_Acesso);
                }

                if ( sCod_Empresa != "" )
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", sCod_Empresa);
                }
                
                if (nNumero_Nr != 0 )
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", nNumero_Nr);
                }

                if (nSequencia_Nr != 0 )
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", nSequencia_Nr);
                }

                if (sCod_Comercial != "" )
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Comercial", sCod_Comercial);
                }

                if (nDuracao != 0 )
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Duracao", nDuracao);
                }

                AD.SelectCommand.Parameters.AddWithValue("@Par_Mostrar_Baixadas", bolBaixadas );

                AD.SelectCommand.CommandText = "PRNET_Consulta_Veiculacao_Baixa";
                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
            }

            catch  (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Cnn.spuClose();
            }
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]            
        public DataSet  fnConfirmacaoRoteiroCarregar(string pUsuario) 
        {
            DataSet  DTS =  new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new  SqlDataAdapter() ;

            try 
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Usuario", pUsuario );
                AD.SelectCommand.CommandText = "PrNet_Confirmacao_Roteiro_Select";
                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
            }

            catch  (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Cnn.spuClose();
            }
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean fnConfirmacaoRoteiro(string pVeiculo,DateTime pDataRede, DateTime pDataLocal, string pUsuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            Boolean  bolRetorno = false;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                Cmd = Cnn.NewCommand();
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure ;
                Cmd.CommandText = "PrNet_Confirmacao_Roteiro";
                Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo",pVeiculo);
                if (pDataRede.Date != DateTime.MinValue)
                {
                    Cmd.Parameters.AddWithValue("@Par_Data_Rede", pDataRede);
                }
                if (pDataLocal.Date != DateTime.MinValue)
                {
                    Cmd.Parameters.AddWithValue("@Par_Data_Local   ", pDataLocal);
                }
                Cmd.Parameters.AddWithValue("@Par_Usuario", pUsuario);
                Cmd.ExecuteNonQuery();
                bolRetorno = true;
            }

            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Cnn.spuClose();
            }
            return bolRetorno; 
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]            
        public DataSet  fnCriticaCe(string pUsuario) 
        {
            DataSet  DTS =  new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new  SqlDataAdapter() ;

            try 
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Usuario", pUsuario );
                AD.SelectCommand.CommandText = "PrNet_Critica_Ce";
                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
            }

            catch  (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Cnn.spuClose();
            }
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]            
        public int fnImprimeCe(    string pEmpressFaturamento  ,
                                        int pNumeroInicio           ,
                                        int pNumeroFim              ,
                                        DateTime pDataProcessamento ,
                                        string pCodEmpresa          ,
                                        int     pNumeroMr           ,
                                        short pSequenciaMr          ,
                                        string pVeiculo             ,
                                        string pUsuario             ) 
                      
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader Dtr;
            SqlCommand Cmd;
            int qtdRegistro = 0;
            try 
            {
                
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd = Cnn.NewCommand();
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "Sp_R0009";
                Cmd.Parameters.AddWithValue("@pPar_Cod_Empresa_Faturamento", pEmpressFaturamento);
                if (pNumeroInicio != 0) Cmd.Parameters.AddWithValue("@pPar_Numero_De", pNumeroInicio);
                if (pNumeroFim != 0) Cmd.Parameters.AddWithValue("@pPar_Numero_Para", pNumeroFim);
                if (pDataProcessamento != DateTime.MinValue) Cmd.Parameters.AddWithValue("@pPar_Dt_Processamento", pDataProcessamento);
                if (pCodEmpresa != "") Cmd.Parameters.AddWithValue("@pPar_Cod_Empresa", pCodEmpresa);
                if (pNumeroMr != 0) Cmd.Parameters.AddWithValue("@pPar_Numero_Mr", pNumeroMr);
                if (pSequenciaMr != 0) Cmd.Parameters.AddWithValue("@pPar_Sequencia_Mr", pSequenciaMr);
                if (pVeiculo != "") Cmd.Parameters.AddWithValue("@pPar_Veiculos", pVeiculo);
                Cmd.Parameters.AddWithValue("@pPar_CompNegociacao", DBNull.Value);
                Cmd.Parameters.AddWithValue("@pPar_Negociacao_char", DBNull.Value);
                Cmd.Parameters.AddWithValue("@Ppar_Agencia", DBNull.Value);
                Cmd.Parameters.AddWithValue("@Ppar_Cliente", DBNull.Value);
                Cmd.Parameters.AddWithValue("@Ppar_Tipo_Midia", DBNull.Value);
                Cmd.Parameters.AddWithValue("@pPar_Indica_Contador", 0);
                Cmd.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
                Dtr = Cmd.ExecuteReader(); 
                Dtr.Read();
                int.TryParse(Dtr[0].ToString(), out qtdRegistro);
                
            }

            catch  (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Cnn.spuClose();
            }
            return qtdRegistro;
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]            
        public DataSet  fnR0009(string pUsuario) 
                      
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter Adp = new SqlDataAdapter();
            DataSet dtsCe = new DataSet();
            DataTable R0009 = new DataTable("R0009");
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Adp.SelectCommand = Cnn.NewCommand();
                Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adp.SelectCommand.CommandText = "Prnet_R0009_Select";
                Adp.SelectCommand.Connection = Cnn.spuConnection;
                Adp.SelectCommand.Parameters.AddWithValue("@Par_Usuario", pUsuario );
                Adp.SelectCommand.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
                //Adp.Fill(dtsCe.R0009);
                Adp.Fill(R0009);
                dtsCe.Tables.Add(R0009);
                
            }

            catch  (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDts(dtsCe);
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnBaixaContradoDadosContrato(string pCodEmpresa,Int32 pContrato,int pSequencia)
        {
            DataSet DTS = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.CommandText = "prNet_Baixa_Contrato_Select";
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCodEmpresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pContrato );
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia);

                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
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
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnBaixaContratoVeiculo(string pCodEmpresa, Int32 pContrato, int pSequencia)
        {
            DataSet DTS = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.CommandText = "prNet_Baixa_Contrato_Veiculo_Select";
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCodEmpresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pContrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia);

                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
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

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnBaixaContratoPrograma(string pCodEmpresa, Int32 pContrato, int pSequencia)
        {
            DataSet DTS = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.CommandText = "prNet_Baixa_Contrato_Programa_Select";
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCodEmpresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pContrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia);

                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
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
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnBaixaContratoComercial(string pCodEmpresa, Int32 pContrato, int pSequencia)
        {
            DataSet DTS = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.CommandText = "prNet_Baixa_Contrato_Comercial_Select";
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCodEmpresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pContrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia);

                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
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
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnBaixaContratoExecutar  (   String      Par_Cod_Empresa		        ,
	                                                Int32       Par_Numero_Mr			    ,
                                                    Int16       Par_Sequencia_Mr		    ,
                                                    DateTime    Par_Data_Inicial		    ,
                                                    DateTime    Par_Data_Final		        ,
                                                    String      Par_Cod_Qualidade			,
                                                    String      Par_Cod_Veiculo			    ,
                                                    String      Par_Cod_Programa		    ,
                                                    String      Par_Cod_Comercial		    ,
                                                    String      Par_Dia_Semana			    ,
                                                    DateTime    Par_Data_Help			    ,
                                                    String      Par_Cod_Usuario		        ,
                                                    Boolean     Par_Indica_Cancelamento	    ,
                                                    Boolean     Par_Indica_Cancelar_Am		,
                                                    String      Par_Motivo_Cancelamento	

                                                )
        {
            DataSet DTS = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();

            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.CommandText = "prNet_Baixa_Contrato";

                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa",Par_Cod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr",Par_Numero_Mr);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr",Par_Sequencia_Mr);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Inicial",Par_Data_Inicial) ;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Final",Par_Data_Final );
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Qualidade",Par_Cod_Qualidade);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo",Par_Cod_Veiculo);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa",Par_Cod_Programa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Comercial",Par_Cod_Comercial) ;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Dia_Semana",Par_Dia_Semana );
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Help", Par_Data_Help);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Usuario",Par_Cod_Usuario);
                if (Par_Indica_Cancelamento )
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Cancelamento", 1);    
                }
                else
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Cancelamento", 0);    
                }
                if (Par_Indica_Cancelar_Am )
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Cancelar_Am", 1);
                }
                else
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Indica_Cancelar_Am", 0);
                }
                AD.SelectCommand.Parameters.AddWithValue("@Par_Motivo_Cancelamento",Par_Motivo_Cancelamento);

                AD.Fill(DTS);
                return Cnn.FnDts(DTS);
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
