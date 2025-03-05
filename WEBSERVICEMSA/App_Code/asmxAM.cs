using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;
using System.Data;
namespace WebServiceMSA
{
    public class asmxAM : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        private DTS.dtsAM.dtbAM_PesquisaDataTable dtbAM_Pesquisa;
        private DTS.dtsAM dtsAM;
        private DTS.dtsDadosAM dtsDadosAM;
        private Conexao.NET.clsConexao Cnn;

        public asmxAM()
        {
        }
        [WebMethod(MessageName = "spuCarregar_1"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsAM.dtbAM_PesquisaDataTable spuPesquisar(Boolean bolIndica_Pendente, Boolean bolIndica_Solucionada, int intCompetencia, string strEmpresa)
        {
            return spuPesquisar(bolIndica_Pendente, bolIndica_Solucionada, intCompetencia, strEmpresa, -1, -1, "", "", "", "", "", -1);
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsAM.dtbAM_PesquisaDataTable spuPesquisar(Boolean bolIndica_Pendente,
                                    Boolean bolIndica_Solucionada,
                                    int intCompetencia,
                                    string strEmpresa,
                                    int intNumero_MR,
                                    short intSequencia_MR,
                                    string strNucleo,
                                    string strContato,
                                    string strCliente,
                                    string strAgencia,
                                    string strVeiculo,
                                    int intProduto)
        {
            try
            {
                this.dtbAM_Pesquisa = new WebServiceMSA.DTS.dtsAM.dtbAM_PesquisaDataTable();
                this.Cnn = new Conexao.NET.clsConexao();

                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                this.sprPesquisar(bolIndica_Pendente, bolIndica_Solucionada, intCompetencia, strEmpresa, intNumero_MR, intSequencia_MR, strNucleo, strContato, strCliente, strAgencia, strVeiculo, intProduto, Cnn.spuConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxAM.spuPesquisar \n" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return (this.dtbAM_Pesquisa);
        }
        
        private void sprPesquisar(Boolean bolIndica_Pendente,
                                    Boolean bolIndica_Solucionada,
                                    int intCompetencia,
                                    string strEmpresa,
                                    int intNumero_MR,
                                    short intSequencia_MR,
                                    string strNucleo,
                                    string strContato,
                                    string strCliente,
                                    string strAgencia,
                                    string strVeiculo,
                                    int intProduto,
                                    SqlConnection Cnn)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("prNet_AM_L", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PintIndica_Pendente_P", bolIndica_Pendente);
                adp.SelectCommand.Parameters.AddWithValue("@PintIndica_Solucionada_P", bolIndica_Solucionada);
                adp.SelectCommand.Parameters.AddWithValue("@PintCompetencia_P", intCompetencia);
                adp.SelectCommand.Parameters.AddWithValue("@PstrEmpresa_P", strEmpresa);

                if (intNumero_MR > 0)
                    adp.SelectCommand.Parameters.AddWithValue("@PintNumero_MR_P", intNumero_MR);
                else
                    adp.SelectCommand.Parameters.AddWithValue("@PintNumero_MR_P", DBNull.Value);

                if (intSequencia_MR > 0)
                    adp.SelectCommand.Parameters.AddWithValue("@PintSequencia_MR_P", intSequencia_MR);
                else
                    adp.SelectCommand.Parameters.AddWithValue("@PintSequencia_MR_P", DBNull.Value);

                adp.SelectCommand.Parameters.AddWithValue("@PstrNucleo_P", (strNucleo.Trim().Length == 0 ? null : strNucleo));
                adp.SelectCommand.Parameters.AddWithValue("@PstrContato_P", (strContato.Trim().Length == 0 ? null : strContato));
                adp.SelectCommand.Parameters.AddWithValue("@PstrCliente_P", (strCliente.Trim().Length == 0 ? null : strCliente));
                adp.SelectCommand.Parameters.AddWithValue("@PstrAgencia_P", (strAgencia.Trim().Length == 0 ? null : strAgencia));
                adp.SelectCommand.Parameters.AddWithValue("@PstrVeiculo_P", (strVeiculo.Trim().Length == 0 ? null : strVeiculo));

                if (intProduto > 0)
                    adp.SelectCommand.Parameters.AddWithValue("@PintProduto_P", intProduto);
                else
                    adp.SelectCommand.Parameters.AddWithValue("@PintProduto_P", DBNull.Value);


                adp.Fill(this.dtbAM_Pesquisa);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxAM.sprPesquisar \n" + ex.Message.ToString());
            }
        }



        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsAM spuCarregar(string strEmpresa,
                                        int intNumero_MR,
                                        short intSequencia_MR,
                                        string strNumero_Docto
                                    )
        {
            return this.spuCarregar(strEmpresa, intNumero_MR, intSequencia_MR, strNumero_Docto, "", "", -1);
        }


        [WebMethod(MessageName = "spuCarregar2"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsAM spuCarregar(string strEmpresa,
                                        int intNumero_MR,
                                        short intSequencia_MR,
                                        string strNumero_Docto,
                                        string strCod_Caracteristica,
                                        string strCod_Veiculo,
                                        int intCod_Produto
                                    )
        {
            try
            {
                this.dtsAM = new WebServiceMSA.DTS.dtsAM();
                this.Cnn = new Conexao.NET.clsConexao();

                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                this.sprCarregar(strEmpresa, intNumero_MR, intSequencia_MR, strNumero_Docto, strCod_Caracteristica, strCod_Veiculo, intCod_Produto, Cnn.spuConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxAM.spuCarregar \n" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return (this.dtsAM);
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        private void sprCarregar(string strEmpresa,
                                int intNumero_MR,
                                short intSequencia_MR,
                                string strNumero_Docto,
                                string strCod_Caracteristica,
                                string strCod_Veiculo,
                                int intCod_Produto,
                                SqlConnection Cnn
                                )
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("prNet_AM_S", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@strEmpresa_P", strEmpresa);
                adp.SelectCommand.Parameters.AddWithValue("@intNumero_MR_P", intNumero_MR);
                adp.SelectCommand.Parameters.AddWithValue("@intSequencia_MR_P", intSequencia_MR);
                adp.SelectCommand.Parameters.AddWithValue("@strNumero_Docto_P", strNumero_Docto);
                adp.SelectCommand.Parameters.AddWithValue("@strCod_Caracteristica_P", (strCod_Caracteristica.Trim().Length != 0 ? strCod_Caracteristica : null));
                adp.SelectCommand.Parameters.AddWithValue("@strCod_Veiculo_P", (strCod_Veiculo.Trim().Length != 0 ? strCod_Veiculo : null));
                adp.SelectCommand.Parameters.AddWithValue("@intCod_Red_Produto_P", (intCod_Produto != -1 ? intCod_Produto.ToString() : null));

                adp.Fill(this.dtsAM.dtbAM);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxAM.sprCarregar \n" + ex.Message.ToString());
            }
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsAM Create()
        {
            DTS.dtsAM dtsAm = new DTS.dtsAM();
            return dtsAm;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsDadosAM spuCarregarDadosAM(string strEmpresa,
                                                 string strAM,
                                                 int intContrato,
                                                 byte intSeqContrato
                                                 )
        {
            try
            {
                this.dtsDadosAM = new WebServiceMSA.DTS.dtsDadosAM();
                this.Cnn = new Conexao.NET.clsConexao();

                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);


                this.sprCarregarCompensacao(strEmpresa, strAM, intContrato, intSeqContrato, Cnn.spuConnection);
                this.sprCarregarFalha(strEmpresa, strAM, intContrato, intSeqContrato, Cnn.spuConnection);




            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxAM.spuCarregarDadosAM \n" + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return (this.dtsDadosAM);
        }
        private void sprCarregarCompensacao(string strEmpresa,
                                              string strAM,
                                              int intContrato,
                                              byte intSeqContrato,
                                              SqlConnection Cnn
                                        )
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("prNet_AM_Compensacao", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Empresa", strEmpresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_AM", strAM);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Contrato", intContrato);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", intSeqContrato);
                adp.Fill(this.dtsDadosAM.dtbAM_Compensacao);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxAM.sprCarregarCompensacao \n" + ex.Message.ToString());
            }
        }

        private void sprCarregarFalha(string strEmpresa,
                                  string strAM,
                                  int intContrato,
                                  byte intSeqContrato,
                                  SqlConnection Cnn
                                  )
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter();

                adp.SelectCommand = new SqlCommand("prNet_AM_Falhas", Cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Empresa", strEmpresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_AM", strAM);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Contrato", intContrato);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", intSeqContrato);
                adp.Fill(this.dtsDadosAM.dtbAM_Falhas);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxAM.sprCarregarFalha \n" + ex.Message.ToString());
            }
        }

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable CarregarCompetencia(string pCod_Empresa, long pNumero_Mr, short pSequencia_Mr, string pCod_Veiculo)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet dtsCompetencia = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("PrNet_Carrega_Competencia_AM", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pNumero_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia_Mr );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", pCod_Veiculo );
                adp.Fill(dtsCompetencia);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(dtsCompetencia.Tables[0]);
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet CarregarDadosMidia(string pCod_Empresa, long pNumero_Mr, short pSequencia_Mr, string pNumero_Am, string pCod_Veiculo, long pCompetencia)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet dtsAmMidia = new DataSet();
            DataTable dtbCompetencia = new DataTable();
            DataTable dtbMidia = new DataTable();
            DataTable dtbCompensacao = new DataTable();
            dtsAmMidia.Tables.Add(dtbCompetencia);
            dtsAmMidia.Tables.Add(dtbMidia);
            dtsAmMidia.Tables.Add(dtbCompensacao);
            SqlDataAdapter adp;
            try
            {
                //===============================Carregar Competencias
                Cnn = new Conexao.NET.clsConexao();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp = new SqlDataAdapter();
                adp.SelectCommand = Cnn.NewCommand("Sp_Am_Midia", Cnn.spuConnection);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pNumero_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pNumero_Mr);
                adp.Fill(dtsAmMidia.Tables["dtbCompetencia"]);
                Cnn.spuClose();
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDts(dtsAmMidia);
            
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable AmPendente(string p_EmpresadoUsuario,
                                    string p_Competencia,
                                    string p_Nucleo,
                                    string p_Contato,
                                    string p_Cliente,
                                    string p_Agencia,
                                    string p_Veiculo,
                                    long p_Produto,
                                    string p_Empresa,
                                    long p_Contrato,
                                    short p_Sequencia,
                                    Boolean p_Merchandising,
                                    string p_Cod_Programa_Merchandising,
                                    string p_Cod_Programa)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet dtsPendente = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter() ;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                
                adp.SelectCommand = Cnn.NewCommand("Sp_Am_Pendente", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
                if (p_EmpresadoUsuario != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Empresa_Usuario", p_EmpresadoUsuario);
                if (p_Competencia != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Competencia", p_Competencia);
                if (p_Nucleo!= "") adp.SelectCommand.Parameters.AddWithValue("@Par_Nucleo",p_Nucleo);
                if (p_Contato!= "") adp.SelectCommand.Parameters.AddWithValue("@Par_Contato",p_Contato);
                if (p_Cliente!= "") adp.SelectCommand.Parameters.AddWithValue("@Par_Cliente",p_Cliente);
                if (p_Agencia!= "") adp.SelectCommand.Parameters.AddWithValue("@Par_Agencia",p_Agencia);
                if (p_Veiculo!= "") adp.SelectCommand.Parameters.AddWithValue("@Par_Veiculo",p_Veiculo);
                if (p_Produto!= 0) adp.SelectCommand.Parameters.AddWithValue("@Par_Produto",p_Produto);
                if (p_Empresa!= "") adp.SelectCommand.Parameters.AddWithValue("@Par_Empresa",p_Empresa);
                if (p_Contrato!= 0) adp.SelectCommand.Parameters.AddWithValue("@Par_Contrato",p_Contrato);
                if (p_Sequencia!= 0) adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia",p_Sequencia);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Merchandising",p_Merchandising);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa_Merchandising",p_Cod_Programa_Merchandising);
                if (p_Cod_Programa!= "") adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa",p_Cod_Programa);
                adp.Fill(dtsPendente);

            }

            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(dtsPendente.Tables[0]) ;
            }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable AmEncerrada(string p_EmpresadoUsuario,
                                     string p_Competencia,
                                     string p_Nucleo,
                                     string p_Contato,
                                     string p_Cliente,
                                     string p_Agencia,
                                     string p_Veiculo,
                                     long p_Produto,
                                     string p_Empresa,
                                     long p_Contrato,
                                     short p_Sequencia,
                                     Boolean p_Merchandising,
                                     string p_Cod_Programa_Merchandising,
                                     string p_Cod_Programa )
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet dtsAmEncerrada = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter() ;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                
                adp.SelectCommand = Cnn.NewCommand("Sp_Am_Seleciona", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
                if (p_EmpresadoUsuario != "") adp.SelectCommand.Parameters.AddWithValue("@pPar_EmpresaUsuario", p_EmpresadoUsuario);
                if (p_Competencia != "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Competencia", p_Competencia);
                if (p_Nucleo!= "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Nucleo",p_Nucleo);
                if (p_Contato!= "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Contato",p_Contato);
                if (p_Cliente!= "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Cliente",p_Cliente);
                if (p_Agencia!= "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Agencia",p_Agencia);
                if (p_Veiculo!= "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Veiculo",p_Veiculo);
                if (p_Cod_Programa != "") adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", p_Cod_Programa);
                if (p_Produto!= 0) adp.SelectCommand.Parameters.AddWithValue("@pPar_Produto",p_Produto);
                if (p_Empresa!= "") adp.SelectCommand.Parameters.AddWithValue("@pPar_Empresa",p_Empresa);
                if (p_Contrato!= 0) adp.SelectCommand.Parameters.AddWithValue("@pPar_Contrato",p_Contrato);
                if (p_Sequencia!= 0) adp.SelectCommand.Parameters.AddWithValue("@pPar_Sequencia",p_Sequencia);
                adp.SelectCommand.Parameters.AddWithValue("@pPar_Merchandising",p_Merchandising);
                adp.SelectCommand.Parameters.AddWithValue("@Ppar_Programa_Usuario", p_Cod_Programa_Merchandising);

                adp.Fill(dtsAmEncerrada);

            }

            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(dtsAmEncerrada.Tables[0]);
            }

                [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean AmReabrir    (   string p_Cod_Empresa,
                                        string p_Numero_Mr,
                                        string p_Sequencia_Mr,
                                        string p_NumeroDocto,
                                        string p_Usuario)

        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();
            Boolean bolRetorno = true;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PrNet_Am_Reabrir";
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandTimeout = Cnn.spuConnection.ConnectionTimeout;
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", p_Cod_Empresa);
                Cmd.Parameters.AddWithValue("@Par_Numero_Mr", p_Numero_Mr);
                Cmd.Parameters.AddWithValue("@Par_Sequencia_Mr", p_Sequencia_Mr);
                Cmd.Parameters.AddWithValue("@Par_Numero_Docto", p_NumeroDocto);
                Cmd.Parameters.AddWithValue("@Par_Usuario", p_Usuario);
                Cmd.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                bolRetorno = false;
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return bolRetorno;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable VisualizarMidia(String pCod_Empresa, Int32 pNumero_Mr, short pSequencia_Mr, String pCod_Veiculo, String pDocumento_Para, Int32 pCompetencia)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet AmMidia = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("PrNet_Carrega_DadosMidia_AM", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pNumero_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", pCod_Veiculo );
                adp.SelectCommand.Parameters.AddWithValue("@Par_Competencia", pCompetencia);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Documento_Para", pDocumento_Para);
                adp.Fill(AmMidia);
                AmMidia = Cnn.FnDts(AmMidia);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return AmMidia.Tables[0];
            
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable CarregarResumoMotivo(String pCod_Empresa, 
                                                Int32 pNumero_Mr, 
                                                short pSequencia_Mr, 
                                                String pCod_Veiculo,  
                                                Int32 pCompetencia,
                                                String pDocumento_Para)
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet amMotivo = new  DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("PrNet_Carrega_ResumoMotivo_AM ", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pNumero_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", pCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Competencia", pCompetencia);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Documento_Para", pDocumento_Para);

                adp.Fill(amMotivo);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return amMotivo.Tables[0];
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable CarregarListaFalhas(String pCod_Empresa,
                                                Int32 pNumero_Mr,
                                                short pSequencia_Mr,
                                                String pDocumento_Para)
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet amListaFalha = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("prNet_AM_Falhas ", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Empresa", pCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Contrato", pNumero_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", pSequencia_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_AM", pDocumento_Para);  

                adp.Fill(amListaFalha);
                amListaFalha = Cnn.FnDts(amListaFalha);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return amListaFalha.Tables[0];
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable CarregarListaCompensacao(String pCod_Empresa,
                                                Int32 pNumero_Mr,
                                                short pSequencia_Mr,
                                                String pDocumento_De)
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet amListaCompensacao = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("prNet_AM_Compensacao ", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Empresa", pCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Contrato", pNumero_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", pSequencia_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_AM", pDocumento_De);

                adp.Fill(amListaCompensacao);
                amListaCompensacao = Cnn.FnDts(amListaCompensacao);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return amListaCompensacao.Tables[0];
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable CarregarSaldo(String pCod_Veiculo  ,
                                        String pCod_Programa ,
                                        String pCompetencia,
                                        byte pIndica_Grade
                                    )
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet amSaldo = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("PrNet_Am_Saldo_Dispo ", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", pCod_Veiculo);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Programa", pCod_Programa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Competencia", pCompetencia);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Indica_Grade", pIndica_Grade);


                adp.Fill(amSaldo);
                amSaldo = Cnn.FnDts(amSaldo);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return amSaldo.Tables[0];
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public String InserirCompensacao(String pCod_Usuario,
                                            String pCod_Empresa,
                                            int    pNumero_Mr   ,   
                                            short pSequencia_Mr    , 
                                            String pCod_Comercial   ,
                                            String pCod_Veiculo ,
                                            DateTime  pData_Exibicao	,
                                            String pCod_Programa,
                                            String pNumero_Docto,
                                            String pCod_Caracteristica	,
                                            Int16 pQuantidade)                                    
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            SqlDataReader Dtr;
            //pData_Exibicao = DateTime.SpecifyKind(pData_Exibicao, DateTimeKind.Unspecified);

            String strRetorno = "";
            try
            {

                Cmd = Cnn.NewCommand();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.CommandType = CommandType.StoredProcedure ;
                Cmd.CommandText = "prNet_Compensacao_Insert";
                Cmd.Connection = Cnn.spuConnection ;
                Cmd.Parameters.AddWithValue("@Par_Cod_Usuario",pCod_Usuario);
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa",pCod_Empresa);
                Cmd.Parameters.AddWithValue("@Par_Numero_Mr",pNumero_Mr);
                Cmd.Parameters.AddWithValue("@Par_Sequencia_Mr",pSequencia_Mr);
                Cmd.Parameters.AddWithValue("@Par_Cod_Comercial",pCod_Comercial);
                Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo",pCod_Veiculo);
                Cmd.Parameters.AddWithValue("@Par_Data_Exibicao",pData_Exibicao);
                Cmd.Parameters.AddWithValue("@Par_Cod_Programa",pCod_Programa);
                Cmd.Parameters.AddWithValue("@Par_Numero_Docto",pNumero_Docto);
                Cmd.Parameters.AddWithValue("@Par_Cod_Caracteristica",pCod_Caracteristica);
                Cmd.Parameters.AddWithValue("@Par_Quantidade", pQuantidade);
                Dtr = Cmd.ExecuteReader(); 
                Dtr.Read();
                strRetorno = Dtr["Critica"].ToString();
                
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return strRetorno;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public Boolean  Solucao   (           String pCod_Empresa,
                                            int pNumero_Mr,
                                            short pSequencia_Mr,
                                            String pNumero_Docto,
                                            String pSolucao,
                                            String pCodUsuario
                                )

        {
            Boolean bolRetorno;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            SqlDataReader Dtr;
            try
            {
                Cmd = Cnn.NewCommand();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PrNet_Am_Solucao";
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandTimeout = Cnn.spuConnection.ConnectionTimeout; 
                
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                Cmd.Parameters.AddWithValue("@Par_Numero_Mr", pNumero_Mr);
                Cmd.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia_Mr);
                Cmd.Parameters.AddWithValue("@Par_Numero_Docto", pNumero_Docto);
                Cmd.Parameters.AddWithValue("@Par_Solucao", pSolucao);
                Cmd.Parameters.AddWithValue("@Par_Cod_Usuario", pCodUsuario);
                Dtr = Cmd.ExecuteReader();
                Dtr.Read();
                Boolean.TryParse(Dtr[0].ToString(),out bolRetorno);

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return bolRetorno ;
            
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataTable CarregarListaFalhasReencaixe(String pCod_Empresa,
                                                        Int32 pNumero_Mr,
                                                        short pSequencia_Mr,
                                                        String pNumero_Docto,
                                                        String pCod_Veiculo)
        {

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            DataSet amReencaixe = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                adp.SelectCommand = Cnn.NewCommand("PrNet_Am_Reencaixe_L ", Cnn.spuConnection);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pNumero_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequencia_Mr);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Docto", pNumero_Docto);
                adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", pCod_Veiculo );
                adp.Fill(amReencaixe);
                amReencaixe = Cnn.FnDts(amReencaixe);
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return amReencaixe.Tables[0];
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void ReencaixeSalvar(DataTable dtbReencaixe, String pCod_usuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            try
            {

                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                foreach (DataRow Rw in dtbReencaixe.Rows )
                {
                    if   (Convert.ToBoolean(Rw["flag"]))
                    {
                        Cmd = Cnn.NewCommand();
                        Cmd.Connection = Cnn.spuConnection;
                        Cmd.CommandType = CommandType.StoredProcedure ;
                        Cmd.CommandText = "PrNet_Am_Reencaixe_Salvar";
                        Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo",Rw["Cod_Veiculo"]);
	                    Cmd.Parameters.AddWithValue("@Par_Data_Exibicao",Rw["Data_Exibicao"]);
	                    Cmd.Parameters.AddWithValue("@Par_Cod_Programa",Rw["Cod_Programa"]);
	                    Cmd.Parameters.AddWithValue("@Par_Chave_Acesso",Rw["Chave_Acesso"]);
                        Cmd.Parameters.AddWithValue("@Par_Cod_Usuario", pCod_usuario);
                        Cmd.ExecuteNonQuery();
                    }
                    
                }
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void ExcluirCompensacao(DataTable Dtb, String pCod_usuario)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd;
            
            try
            {

                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                foreach (DataRow Rw in Dtb.Rows)
                {
                     
                    if (Convert.ToBoolean(Rw["Check"]))
                    {
                        Cmd = Cnn.NewCommand();
                        Cmd.Connection = Cnn.spuConnection;
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.CommandText = "PrNet_AM_Exclusao_Compensacao";
                        Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", Rw["Cod_Veiculo"]);
                        Cmd.Parameters.AddWithValue("@Par_Data_Exibicao", Rw["Data_Exibicao"]);
                        Cmd.Parameters.AddWithValue("@Par_Cod_Programa", Rw["Cod_Programa"]);
                        Cmd.Parameters.AddWithValue("@Par_Chave_Acesso", Rw["Chave_Acesso"]);
                        Cmd.Parameters.AddWithValue("@Par_Cod_Usuario", pCod_usuario);
                        Cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
        }
    }
}