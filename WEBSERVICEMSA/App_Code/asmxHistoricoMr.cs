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

    public class asmxHistoricoMr : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxHistoricoMr()
        {
        }

        

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DataSet fnHC(string pDesc_EmpresaUsuario, int nCompetencia_de, int nCompetencia_ate, string sCod_Empresa, int nMr_Contrato, int nSeq, string sCod_veiculo, string sNumero_Negociacao, string sNucleo, string sContato, string sCliente, string sAgencia, int nProduto, string sNumero_PI, string sTipo_Midia, string sData_Cadastramento, int nAutorizado, int nPendente_Ce, int nMostra_Produto, int nMostra_Veiculo, string sUsuario, int nValoracao_Normal_Evento, string sCod_Programa, int nRejeitado, int nPendente_Autorizacao, string sTipo_Comercial, int nAbrangencia)
        {
            DataSet DTS = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            DateTime dDataInclusao;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Ppar_EmpresaUsuario", pDesc_EmpresaUsuario);
                if (nCompetencia_de != 0 && nCompetencia_ate != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Competencia_Inicial", nCompetencia_de);
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Competencia_Final", nCompetencia_ate);
                }
                if (sCod_Empresa.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Empresa", sCod_Empresa);
                }
                if (nMr_Contrato != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Contrato", nMr_Contrato);
                }
                if (nSeq != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Sequencia", nSeq);
                }
                if (sCod_veiculo.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Veiculo", sCod_veiculo);
                }
                if (sNumero_Negociacao.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Numero_Negociacao_Char", sNumero_Negociacao);
                }
                if (sNucleo.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Nucleo", sNucleo);
                }
                if (sContato.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Contato", sContato);
                }
                if (sCliente.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Cliente", sCliente);
                }
                if (sAgencia.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Agencia", sAgencia);
                }
                if (nProduto != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Produto", nProduto);
                }
                if (sNumero_PI.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Numero_PI", sNumero_PI);
                }
                if (sTipo_Midia != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Tipo_Midia", sTipo_Midia);
                }

                if (sData_Cadastramento.Trim() != "")
                {
                    DateTime.TryParse(sData_Cadastramento, out dDataInclusao);

                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Data_Cadastramento", dDataInclusao);
                }
                if (nAutorizado != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Autorizados", nAutorizado);
                }
                if (nPendente_Ce != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Pendente_Ce", nPendente_Ce);
                }
                if (nMostra_Produto != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Mostra_Produto", nMostra_Produto);
                }
                if (nMostra_Veiculo != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Mostra_Veiculo", nMostra_Veiculo);
                }
                if (sUsuario.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Usuario_Sistema", sUsuario);
                }
                AD.SelectCommand.Parameters.AddWithValue("@Ppar_Valoracao_Normal_Evento", nValoracao_Normal_Evento);
                if (sCod_Programa.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Ppar_Cod_Programa", sCod_Programa);
                }
                if (nRejeitado != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@PPar_Rejeitado", nRejeitado);
                }
                if (nPendente_Autorizacao != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@PPar_Pendente_Autorizacao", nPendente_Autorizacao);
                }
                if (sTipo_Comercial.Trim() != "")
                {
                    AD.SelectCommand.Parameters.AddWithValue("@PPar_Tipo_Comercial", sTipo_Comercial);
                }
                if (nAbrangencia != 0)
                {
                    AD.SelectCommand.Parameters.AddWithValue("@PPar_Abrangencia", nAbrangencia);
                }
                AD.SelectCommand.Parameters.AddWithValue("@Ppar_Indica_Top_N", 1);
                AD.SelectCommand.CommandText = "Sp_Historico_Contratos";
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
        public DataSet fnHistoricoDadosContratos(string sCod_Empresa, int nMr_Contrato, int nSeq)
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
                AD.SelectCommand.Parameters.AddWithValue("@par_Empresa", sCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Contrato", nMr_Contrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", nSeq);
                AD.SelectCommand.CommandText = "Sp_Historico_Dados_Contrato";
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
        public DataSet fnHistoricoComerciais(string sCod_Empresa, int nMr_Contrato, int nSeq)
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
                AD.SelectCommand.Parameters.AddWithValue("@par_Empresa", sCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Contrato", nMr_Contrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", nSeq);
                AD.SelectCommand.CommandText = "Sp_Historico_Comerciais";
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
        public DataSet fnConsultaMidiaDemandada(string sCod_Empresa, int nMr_Contrato, int nSeq, string sCod_Veiculo, string sCompetencia)
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
                AD.SelectCommand.Parameters.AddWithValue("@par_Empresa", sCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Contrato", nMr_Contrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", nSeq);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Veiculo", sCod_Veiculo);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Competencia", sCompetencia);

                AD.SelectCommand.CommandText = "PRNET_Consulta_Midia_Demandada";
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
        public DataSet fnConsultaMidiaRealizavel(string sCod_Empresa, int nMr_Contrato, int nSeq, string sCod_Veiculo, string sCompetencia)
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
                AD.SelectCommand.Parameters.AddWithValue("@par_Empresa", sCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Contrato", nMr_Contrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", nSeq);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Veiculo", sCod_Veiculo);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Competencia", sCompetencia);

                AD.SelectCommand.CommandText = "PRNET_Consulta_Midia_Realizavel";
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
        public DataSet fnHistoricoVeiculo(string sCod_Empresa, int nMr_Contrato, int nSeq)
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
                AD.SelectCommand.Parameters.AddWithValue("@par_Empresa", sCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Contrato", nMr_Contrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", nSeq);
                AD.SelectCommand.CommandText = "sp_historico_Veiculos";
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
        public DataSet fnHistoricoCompetenciaMidia(string sCod_Empresa, int nMr_Contrato, int nSeq)
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
                AD.SelectCommand.Parameters.AddWithValue("@par_Empresa", sCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Contrato", nMr_Contrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", nSeq);
                AD.SelectCommand.CommandText = "sp_historico_Veiculos";
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
        public DataSet fnHistoricoVeiculacoes(string sCod_Empresa, int nMr_Contrato, int nSeq, string sCod_Veiculo)
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
                AD.SelectCommand.Parameters.AddWithValue("@par_Empresa", sCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Contrato", nMr_Contrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia", nSeq);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Veiculo", sCod_Veiculo);
                AD.SelectCommand.CommandText = "sp_historico_Veiculacoes";
                AD.Fill(DTS);

                //'Cmd.Parameters.AddWithValue("@Par_Senha", Cnn.deCriptografar( pSenha));
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


    }
}
