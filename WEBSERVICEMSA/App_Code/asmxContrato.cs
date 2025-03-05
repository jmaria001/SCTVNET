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
    public class asmxContrato : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxContrato()
        {
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] public DataSet fnDefineDataset()
        {
            DTS.dtsContrato DTS = new DTS.dtsContrato();
            DTS.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema;
            return new DTS.dtsContrato(); 
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] public int fnNovoNumero()
        {
            int intRetorno = 0;

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD;
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "Sp_Numeracao ";
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", "000");
                Cmd.Parameters.AddWithValue("@Par_Tipo", "MR");
                Cmd.Parameters.AddWithValue("@Par_Numero", DBNull.Value);
                Cmd.Parameters.AddWithValue("@Par_Retorno", 1);
                RD = Cmd.ExecuteReader();
                RD.Read();
                int.TryParse(RD["Numero"].ToString(), out intRetorno);
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }
            return intRetorno; 
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] public DataSet fnCarregaGrade(DateTime pDataInicio, DateTime pDataFim, string pCodVeiculo)
        {
            DataSet returnValue;
            returnValue = null;
            int intAno;
            int intMes;
            int intCompetencia;
            DataSet Dts = new DataSet();
            try
            {
                SqlDataAdapter Adp = new SqlDataAdapter();
                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    Adp.SelectCommand = Cnn.NewCommand();
                    Adp.SelectCommand.Connection = Cnn.spuConnection;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "PrNet_Grade_Dia_Semana";
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Inicio", pDataInicio);
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Data_Fim", pDataFim);
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", pCodVeiculo);
                    Adp.Fill(Dts, "Grade_Semana");
                    returnValue = Dts;

                    intAno = pDataInicio.Year;
                    intMes = pDataFim.Month;
                    if (intAno < 100) //--- se tiver com dois digitos
                    {
                        intAno = 2000 + intAno;
                    }
                    int.TryParse(intAno.ToString().PadLeft(4, '0') + intMes.ToString().PadLeft(2, '0'), out intCompetencia);



                    Adp.SelectCommand = Cnn.NewCommand();
                    Adp.SelectCommand.Connection = Cnn.spuConnection;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "prNet_Grade_Competencia_Select";
                    Adp.SelectCommand.Parameters.AddWithValue("@par_Cod_Veiculo", pCodVeiculo);
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Competencia", intCompetencia);
                    Adp.Fill(Dts, "Grade_Competencia");
                    returnValue = Dts;
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
            catch (Exception)
            {
            }
            return returnValue; 
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] public DataSet fnVeiculoUsuarioCarregar(string pUsuario)
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
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Usuario", pUsuario);
                AD.SelectCommand.CommandText = "prNet_Veiculo_Usuario_Select";
                AD.Fill(DTS,"Veiculo");
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
        public bool fnConsisteCaracteristicaVeiculacao(string pCodigo)
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
                Cmd.CommandText = "Prnet_Carac_Veiculacao_L";
                Cmd.Parameters.AddWithValue("@Par_Codigo", pCodigo);
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
        [WebMethod, SoapHeader("spAuthenticationHeader")] public object fnCriaNegociacao(int pCompetencia, string pCod_Empresa, string pCod_Empresa_Faturamento, string pCod_Agencia, string pCod_Cliente, string pCod_Nucleo, string pCod_Contato, string pcod_Tipo_Midia, string pCod_Usuario)
        {
            object returnValue;
            returnValue = 0;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD;
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.CommandText = "prNet_Contrato_CriaNegociacao ";
                Cmd.Parameters.AddWithValue("@Par_Competencia", pCompetencia);
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa_Faturamento", pCod_Empresa_Faturamento);
                Cmd.Parameters.AddWithValue("@Par_Cod_Agencia", pCod_Agencia);
                Cmd.Parameters.AddWithValue("@Par_Cod_Cliente", pCod_Cliente);
                Cmd.Parameters.AddWithValue("@Par_Cod_Nucleo", pCod_Nucleo);
                Cmd.Parameters.AddWithValue("@Par_Cod_Contato", pCod_Contato);
                Cmd.Parameters.AddWithValue("@Par_Cod_Tipo_Midia", pcod_Tipo_Midia);
                Cmd.Parameters.AddWithValue("@Par_Cod_Usuario", pCod_Usuario);
                RD = Cmd.ExecuteReader();
                RD.Read();
                returnValue = RD["Numero_Negociacao"];

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
        public DataSet  FnSalvar(DataSet dtsContrato, DataSet dtsVeiculo, string pUsuario)
        {
            Boolean returnValue;
            returnValue = true;
            string strCod_Empresa = "";
            int intNumero_Mr = 0;
            short shortSequencia_Mr = 0;
            int intCompetencia = 0;
            string strMes = "";
            string strAno = "";
            DateTime dtCampanha;
            DataSet dtsStatus = new DataSet();
            DataTable dtbAntes = new DataTable();
            DataTable dtbDepois = new DataTable();
            try
            {

                //==========================Busca Dados do Contrato
                System.Data.DataRow Rw = dtsContrato.Tables["Contrato"].Rows[0];
                strCod_Empresa = Rw["Cod_Empresa"].ToString();
                int.TryParse(Rw["Numero_Mr"].ToString(), out intNumero_Mr);
                short.TryParse(Rw["Sequencia_Mr"].ToString(), out shortSequencia_Mr);
                DateTime.TryParse(Rw["Periodo_Campanha_Inicio"].ToString(), out dtCampanha);
                strAno = dtCampanha.Year.ToString().PadLeft(4, '0');
                strMes = dtCampanha.Month.ToString().PadLeft(2, '0');
                intCompetencia = Convert.ToInt32(strAno + strMes);

                //==========================Contagem de Veiculacoes antes da gravacao
                
                dtbAntes = fnContarVeiculacao(strCod_Empresa,intNumero_Mr,shortSequencia_Mr);

                //==========================inicio da gravacao 
                if (!fnSalvarContrato(dtsContrato.Tables["Contrato"]))
                {
                    returnValue = false;
                }

                if (!fnSalvarComercial(dtsContrato.Tables["COmercial"]))
                {
                    returnValue = false;
                }

                if (dtsVeiculo != null)
                {
                    if (!fnSalvarVeiculacao(dtsContrato, dtsVeiculo))
                    {
                        returnValue = false;
                    }
                }

                if (dtsVeiculo != null)
                {
                    if (!fnIem(strCod_Empresa,intNumero_Mr,shortSequencia_Mr,intCompetencia,dtsVeiculo))
                    {
                        returnValue = false;
                    }
                }

                if (dtsVeiculo != null)
                {
                    if (!fnIEV(strCod_Empresa,intNumero_Mr,shortSequencia_Mr,pUsuario,1))
                    {
                        returnValue = false;
                    }
                }

                //==========================Contagem de Veiculacoes apos  da gravacao

                dtbDepois  =  fnContarVeiculacao(strCod_Empresa, intNumero_Mr, shortSequencia_Mr);
                dtbAntes.TableName = "DtbAntes";
                dtbDepois.TableName = "DtbDepois";
                dtsStatus.Tables.Add(dtbAntes);
                dtsStatus.Tables.Add(dtbDepois);
                return dtsStatus;



            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message));
            }
            
        }
        private bool fnSalvarContrato(DataTable dtbContrato)
        {
            bool returnValue;

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            returnValue = true;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                if (dtbContrato.Rows.Count > 0)
                {
                    SqlDataAdapter Adp = new SqlDataAdapter();
                    Adp.InsertCommand = Cnn.NewCommand("prNet_Contrato_Insert");
                    Adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                    Adp.InsertCommand.Connection = Cnn.spuConnection;

                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");
                    Adp.InsertCommand.Parameters.Add("@Par_Numero_Mr", SqlDbType.Int, 4, "Numero_Mr");
                    Adp.InsertCommand.Parameters.Add("@Par_Numero_Negociacao", SqlDbType.Int, 9, "Numero_Negociacao");
                    Adp.InsertCommand.Parameters.Add("@Par_Sequencia_Mr", SqlDbType.SmallInt, 2, "Sequencia_Mr");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Programa", SqlDbType.Char, 4, "Cod_Programa");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa_Faturamento", SqlDbType.Char, 3, "Cod_Empresa_Faturamento");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Cancelamento", SqlDbType.Char, 3, "Cod_Cancelamento");
                    Adp.InsertCommand.Parameters.Add("@Par_Caracteristica_Contrato", SqlDbType.Char, 3, "Caracteristica_Contrato");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Contato", SqlDbType.Char, 5, "Cod_Contato");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Historico", SqlDbType.Char, 4, "Cod_Historico");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Nucleo", SqlDbType.Char, 7, "Cod_Nucleo");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Reserva", SqlDbType.Char, 5, "Cod_Reserva");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Midia_Especificada", SqlDbType.TinyInt, 1, "Indica_Midia_Especificada");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Tipo_Midia", SqlDbType.Char, 6, "Cod_Tipo_Midia");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Usuario", SqlDbType.Char, 30, "Cod_Usuario");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Cadastramento", SqlDbType.DateTime, 8, "Data_Cadastramento");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Cancelamento", SqlDbType.DateTime, 8, "Data_Cancelamento");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Recepcao_Reserva", SqlDbType.DateTime, 8, "Data_Recepcao_Reserva");
                    Adp.InsertCommand.Parameters.Add("@Par_Numero_PI", SqlDbType.VarChar, 20, "Numero_PI");
                    Adp.InsertCommand.Parameters.Add("@Par_Motivo_Cancelamento", SqlDbType.Char, 50, "Motivo_Cancelamento");
                    Adp.InsertCommand.Parameters.Add("@Par_Obs_Roteiro", SqlDbType.NVarChar, 1000, "Obs_Roteiro");
                    Adp.InsertCommand.Parameters.Add("@Par_Periodo_Campanha_Inicio", SqlDbType.DateTime, 8, "Periodo_Campanha_Inicio");
                    Adp.InsertCommand.Parameters.Add("@Par_Periodo_Campanha_Termino", SqlDbType.DateTime, 8, "Periodo_Campanha_Termino");
                    Adp.InsertCommand.Parameters.Add("@Par_Valor", SqlDbType.Decimal, 9, "Valor");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Exibido", SqlDbType.Decimal, 9, "Vlr_Exibido");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Grade", SqlDbType.TinyInt, 1, "Indica_Grade");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Faturado", SqlDbType.Decimal, 9, "Vlr_Faturado");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Realizado", SqlDbType.TinyInt, 1, "Indica_Realizado");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Ded_Emitido", SqlDbType.Decimal, 9, "Vlr_Ded_Emitido");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Comp_Emitido", SqlDbType.Decimal, 9, "Vlr_Comp_Emitido");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Autorizado", SqlDbType.Decimal, 9, "Vlr_Autorizado");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Deducao", SqlDbType.Decimal, 9, "Vlr_Deducao");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Compensacao", SqlDbType.Decimal, 9, "Vlr_Compensacao");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Diferenca", SqlDbType.Decimal, 9, "Vlr_Diferenca");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Cliente", SqlDbType.Char, 6, "Cod_Cliente");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Agencia", SqlDbType.Char, 6, "Cod_Agencia");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Tipo_Evento", SqlDbType.TinyInt, 1, "Indica_Tipo_Evento");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Por_Credito", SqlDbType.TinyInt, 1, "Indica_Por_Credito");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Informado", SqlDbType.Decimal, 9, "Vlr_Informado");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Info_Vlr", SqlDbType.DateTime, 8, "Data_Info_Vlr");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Usuario_Vlr", SqlDbType.Char, 30, "Cod_Usuario_Vlr");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Ded_Diferenca", SqlDbType.Decimal, 9, "Vlr_Ded_Diferenca");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Cred_Diferenca", SqlDbType.Decimal, 9, "Vlr_Cred_Diferenca");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Tabela", SqlDbType.Decimal, 9, "Vlr_Tabela");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Apoio", SqlDbType.TinyInt, 1, "Indica_Apoio");
                    Adp.InsertCommand.Parameters.Add("@Par_indica_autorizacao", SqlDbType.TinyInt, 1, "indica_autorizacao");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Negociado", SqlDbType.Decimal, 9, "Vlr_Negociado");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Bloqueio", SqlDbType.TinyInt, 1, "Indica_Bloqueio");
                    Adp.InsertCommand.Parameters.Add("@Par_vlr_Gerencial_bav", SqlDbType.Decimal, 9, "vlr_Gerencial_bav");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Correcao", SqlDbType.Decimal, 9, "Vlr_Correcao");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Valor_NET", SqlDbType.TinyInt, 1, "Indica_Valor_NET");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Repasse", SqlDbType.Decimal, 13, "Vlr_Repasse");
                    Adp.InsertCommand.Parameters.Add("@Par_Desconsidera_Patrocinio_Evento", SqlDbType.TinyInt, 1, "Desconsidera_Patrocinio_Evento");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Abatimento_Varejo", SqlDbType.Decimal, 13, "Vlr_Abatimento_Varejo");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Mercado", SqlDbType.Char, 5, "Cod_Mercado");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Ajuste_BAV", SqlDbType.SmallDateTime, 4, "Data_Ajuste_BAV");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Usuario_Ajuste_BAV", SqlDbType.Char, 20, "Cod_Usuario_Ajuste_BAV");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Evento", SqlDbType.Char, 4, "Cod_Evento");
                    Adp.InsertCommand.Parameters.Add("@Par_Vlr_Tabela_Exibido_Contrato", SqlDbType.Decimal, 9, "Vlr_Tabela_Exibido_Contrato");
                    Adp.InsertCommand.Parameters.Add("@Par_OBS_Contrato", SqlDbType.VarChar, 500, "OBS_Contrato");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Inclusao", SqlDbType.SmallDateTime, 4, "Data_Inclusao");

                    Adp.UpdateCommand = Cnn.NewCommand("prNet_Contrato_UPdate");
                    Adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                    Adp.UpdateCommand.Connection = Cnn.spuConnection;
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");
                    Adp.UpdateCommand.Parameters.Add("@Par_Numero_Mr", SqlDbType.Int, 4, "Numero_Mr");
                    Adp.UpdateCommand.Parameters.Add("@Par_Numero_Negociacao", SqlDbType.Int, 9, "Numero_Negociacao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Sequencia_Mr", SqlDbType.SmallInt, 2, "Sequencia_Mr");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Programa", SqlDbType.Char, 4, "Cod_Programa");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Empresa_Faturamento", SqlDbType.Char, 3, "Cod_Empresa_Faturamento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Cancelamento", SqlDbType.Char, 3, "Cod_Cancelamento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Caracteristica_Contrato", SqlDbType.Char, 3, "Caracteristica_Contrato");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Contato", SqlDbType.Char, 6, "Cod_Contato");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Historico", SqlDbType.Char, 4, "Cod_Historico");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Nucleo", SqlDbType.Char, 7, "Cod_Nucleo");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Reserva", SqlDbType.Char, 5, "Cod_Reserva");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Midia_Especificada", SqlDbType.TinyInt, 1, "Indica_Midia_Especificada");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Tipo_Midia", SqlDbType.Char, 6, "Cod_Tipo_Midia");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Usuario", SqlDbType.Char, 30, "Cod_Usuario");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Cadastramento", SqlDbType.DateTime, 8, "Data_Cadastramento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Cancelamento", SqlDbType.DateTime, 8, "Data_Cancelamento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Recepcao_Reserva", SqlDbType.DateTime, 8, "Data_Recepcao_Reserva");
                    Adp.UpdateCommand.Parameters.Add("@Par_Numero_PI", SqlDbType.VarChar, 20, "Numero_PI");
                    Adp.UpdateCommand.Parameters.Add("@Par_Motivo_Cancelamento", SqlDbType.Char, 50, "Motivo_Cancelamento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Obs_Roteiro", SqlDbType.NVarChar, 1000, "Obs_Roteiro");
                    Adp.UpdateCommand.Parameters.Add("@Par_Periodo_Campanha_Inicio", SqlDbType.DateTime, 8, "Periodo_Campanha_Inicio");
                    Adp.UpdateCommand.Parameters.Add("@Par_Periodo_Campanha_Termino", SqlDbType.DateTime, 8, "Periodo_Campanha_Termino");
                    Adp.UpdateCommand.Parameters.Add("@Par_Valor", SqlDbType.Decimal, 9, "Valor");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Exibido", SqlDbType.Decimal, 9, "Vlr_Exibido");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Grade", SqlDbType.TinyInt, 1, "Indica_Grade");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Faturado", SqlDbType.Decimal, 9, "Vlr_Faturado");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Realizado", SqlDbType.TinyInt, 1, "Indica_Realizado");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Ded_Emitido", SqlDbType.Decimal, 9, "Vlr_Ded_Emitido");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Comp_Emitido", SqlDbType.Decimal, 9, "Vlr_Comp_Emitido");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Autorizado", SqlDbType.Decimal, 9, "Vlr_Autorizado");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Deducao", SqlDbType.Decimal, 9, "Vlr_Deducao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Compensacao", SqlDbType.Decimal, 9, "Vlr_Compensacao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Diferenca", SqlDbType.Decimal, 9, "Vlr_Diferenca");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Cliente", SqlDbType.Char, 6, "Cod_Cliente");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Agencia", SqlDbType.Char, 6, "Cod_Agencia");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Tipo_Evento", SqlDbType.TinyInt, 1, "Indica_Tipo_Evento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Por_Credito", SqlDbType.TinyInt, 1, "Indica_Por_Credito");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Informado", SqlDbType.Decimal, 9, "Vlr_Informado");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Info_Vlr", SqlDbType.DateTime, 8, "Data_Info_Vlr");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Usuario_Vlr", SqlDbType.Char, 30, "Cod_Usuario_Vlr");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Ded_Diferenca", SqlDbType.Decimal, 9, "Vlr_Ded_Diferenca");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Cred_Diferenca", SqlDbType.Decimal, 9, "Vlr_Cred_Diferenca");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Tabela", SqlDbType.Decimal, 9, "Vlr_Tabela");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Apoio", SqlDbType.TinyInt, 1, "Indica_Apoio");
                    Adp.UpdateCommand.Parameters.Add("@Par_indica_autorizacao", SqlDbType.TinyInt, 1, "indica_autorizacao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Negociado", SqlDbType.Decimal, 9, "Vlr_Negociado");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Bloqueio", SqlDbType.TinyInt, 1, "Indica_Bloqueio");
                    Adp.UpdateCommand.Parameters.Add("@Par_vlr_Gerencial_bav", SqlDbType.Decimal, 9, "vlr_Gerencial_bav");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Correcao", SqlDbType.Decimal, 9, "Vlr_Correcao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Valor_NET", SqlDbType.TinyInt, 1, "Indica_Valor_NET");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Repasse", SqlDbType.Decimal, 13, "Vlr_Repasse");
                    Adp.UpdateCommand.Parameters.Add("@Par_Desconsidera_Patrocinio_Evento", SqlDbType.TinyInt, 1, "Desconsidera_Patrocinio_Evento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Abatimento_Varejo", SqlDbType.Decimal, 13, "Vlr_Abatimento_Varejo");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Mercado", SqlDbType.Char, 5, "Cod_Mercado");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Ajuste_BAV", SqlDbType.SmallDateTime, 4, "Data_Ajuste_BAV");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Usuario_Ajuste_BAV", SqlDbType.Char, 20, "Cod_Usuario_Ajuste_BAV");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Evento", SqlDbType.Char, 4, "Cod_Evento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Vlr_Tabela_Exibido_Contrato", SqlDbType.Decimal, 9, "Vlr_Tabela_Exibido_Contrato");
                    Adp.UpdateCommand.Parameters.Add("@Par_OBS_Contrato", SqlDbType.VarChar, 500, "OBS_Contrato");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Inclusao", SqlDbType.SmallDateTime, 4, "Data_Inclusao");

                    Adp.Update(dtbContrato);
                }
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message));
            }
            finally
            {
                Cnn.spuClose();
            }
            return returnValue; 
        }
        private bool fnSalvarComercial(DataTable dtbComercial)
        {
            bool returnValue;

            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            returnValue = true;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                if (dtbComercial.Rows.Count > 0)
                {
                    SqlDataAdapter Adp = new SqlDataAdapter();
                    Adp.InsertCommand = Cnn.NewCommand("prNet_Comercial_Insert");
                    Adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                    Adp.InsertCommand.Connection = Cnn.spuConnection;

                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Comercial", SqlDbType.Char, 2, "Cod_Comercial");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Material", SqlDbType.Char, 2, "Cod_Material");
                    Adp.InsertCommand.Parameters.Add("@Par_Numero_Mr", SqlDbType.Int, 4, "Numero_Mr");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Red_Produto", SqlDbType.Int, 4, "Cod_Red_Produto");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");
                    Adp.InsertCommand.Parameters.Add("@Par_Sequencia_Mr", SqlDbType.SmallInt, 2, "Sequencia_Mr");
                    Adp.InsertCommand.Parameters.Add("@Par_Cod_Tipo_Comercial", SqlDbType.Char, 2, "Cod_Tipo_Comercial");
                    Adp.InsertCommand.Parameters.Add("@Par_Duracao", SqlDbType.SmallInt, 2, "Duracao");
                    Adp.InsertCommand.Parameters.Add("@Par_Indica_Titulo_Determinar", SqlDbType.TinyInt, 1, "Indica_Titulo_Determinar");
                    Adp.InsertCommand.Parameters.Add("@Par_Nome_Produto", SqlDbType.Char, 30, "Nome_Produto");
                    Adp.InsertCommand.Parameters.Add("@Par_Numero_Fita", SqlDbType.Char, 10, "Numero_Fita");
                    Adp.InsertCommand.Parameters.Add("@Par_Titulo_Comercial", SqlDbType.Char, 30, "Titulo_Comercial");
                    Adp.InsertCommand.Parameters.Add("@Par_Matriz", SqlDbType.Char, 10, "Matriz");
                    Adp.InsertCommand.Parameters.Add("@Par_Posicao", SqlDbType.Char, 10, "Posicao");
                    Adp.InsertCommand.Parameters.Add("@Par_Data_Desativacao", SqlDbType.DateTime, 8, "Data_Desativacao");
                    Adp.InsertCommand.Parameters.Add("@Par_data_gravacao", SqlDbType.DateTime, 8, "data_gravacao");
                    Adp.InsertCommand.Parameters.Add("@Par_complemento", SqlDbType.VarChar, 400, "complemento");
                    Adp.InsertCommand.Parameters.Add("@Par_Inicio_Programacao", SqlDbType.DateTime, 8, "Inicio_Programacao");
                    Adp.InsertCommand.Parameters.Add("@Par_Fim_Programacao", SqlDbType.DateTime, 8, "Fim_Programacao");


                    Adp.UpdateCommand = Cnn.NewCommand("prNet_Comercial_UPdate");
                    Adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                    Adp.UpdateCommand.Connection = Cnn.spuConnection;

                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Comercial", SqlDbType.Char, 2, "Cod_Comercial");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Material", SqlDbType.Char, 2, "Cod_Material");
                    Adp.UpdateCommand.Parameters.Add("@Par_Numero_Mr", SqlDbType.Int, 4, "Numero_Mr");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Red_Produto", SqlDbType.Int, 4, "Cod_Red_Produto");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Empresa", SqlDbType.Char, 3, "Cod_Empresa");
                    Adp.UpdateCommand.Parameters.Add("@Par_Sequencia_Mr", SqlDbType.SmallInt, 2, "Sequencia_Mr");
                    Adp.UpdateCommand.Parameters.Add("@Par_Cod_Tipo_Comercial", SqlDbType.Char, 2, "Cod_Tipo_Comercial");
                    Adp.UpdateCommand.Parameters.Add("@Par_Duracao", SqlDbType.SmallInt, 2, "Duracao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Indica_Titulo_Determinar", SqlDbType.TinyInt, 1, "Indica_Titulo_Determinar");
                    Adp.UpdateCommand.Parameters.Add("@Par_Nome_Produto", SqlDbType.Char, 30, "Nome_Produto");
                    Adp.UpdateCommand.Parameters.Add("@Par_Numero_Fita", SqlDbType.Char, 10, "Numero_Fita");
                    Adp.UpdateCommand.Parameters.Add("@Par_Titulo_Comercial", SqlDbType.Char, 30, "Titulo_Comercial");
                    Adp.UpdateCommand.Parameters.Add("@Par_Matriz", SqlDbType.Char, 10, "Matriz");
                    Adp.UpdateCommand.Parameters.Add("@Par_Posicao", SqlDbType.Char, 10, "Posicao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Data_Desativacao", SqlDbType.DateTime, 8, "Data_Desativacao");
                    Adp.UpdateCommand.Parameters.Add("@Par_data_gravacao", SqlDbType.DateTime, 8, "data_gravacao");
                    Adp.UpdateCommand.Parameters.Add("@Par_complemento", SqlDbType.VarChar, 400, "complemento");
                    Adp.UpdateCommand.Parameters.Add("@Par_Inicio_Programacao", SqlDbType.DateTime, 8, "Inicio_Programacao");
                    Adp.UpdateCommand.Parameters.Add("@Par_Fim_Programacao", SqlDbType.DateTime, 8, "Fim_Programacao");
                    Adp.Update(dtbComercial);
                }
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message));
            }
            finally
            {
                Cnn.spuClose();
            }
            return returnValue; 
        }
        private bool fnSalvarVeiculacao(DataSet dtsContrato, DataSet dtsVeiculo)
        {
            bool returnValue;
            returnValue = true;
            string strCod_Usuario = null;
            string strCod_Empresa = null;
            int intNumero_Mr = 0;
            short shortSequencia_Mr = 0;
            byte btIndica_Grade = 0;
            int intCompetencia = 0;
            string strLinha_Veiculacao = "";
            string strVeiculo = null;
            string strMes = "";
            string strAno = "";
            DateTime dtCampanha;
            SqlCommand Cmd = null;
            


            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            try
            {
                
                
                if (dtsContrato.Tables["Veiculacao_Digitacao"].Rows.Count > 0)
                {
                    //==========================Busca Dados do Contrato
                    System.Data.DataRow with_1 = dtsContrato.Tables["Contrato"].Rows[0];
                    strCod_Empresa = with_1["Cod_Empresa"].ToString(); ;
                    strCod_Usuario = with_1["Cod_Usuario"].ToString();
                    btIndica_Grade = Convert.ToByte(with_1["Indica_Grade"]);
                    intNumero_Mr = Convert.ToInt32(with_1["Numero_Mr"]);
                    short.TryParse(with_1["Sequencia_Mr"].ToString(), out shortSequencia_Mr);

                    DateTime.TryParse(with_1["Periodo_Campanha_Inicio"].ToString(), out dtCampanha);
                    strAno = dtCampanha.Year.ToString().PadLeft(4, '0');
                    strMes = dtCampanha.Month.ToString().PadLeft(2, '0');
                    intCompetencia = Convert.ToInt32(strAno + strMes );

                    //==========================Monta String de Veiculos
                    strVeiculo = "";
                    foreach (DataRow drwVeiculo in dtsVeiculo.Tables[0].Rows)
                    {
                        strVeiculo += drwVeiculo["Cod_Veiculo"].ToString();
                    }
                    //==========================Monta String da Linha de Digitacao/Chama a Procedure
                    System.Data.DataTable with_2 = dtsContrato.Tables["Veiculacao_Digitacao"];

                    foreach (DataRow drwVeiculacao in with_2.Rows)
                    {
                        strLinha_Veiculacao = "";
                        for (int x = with_2.Columns.IndexOf("dia_01"); x <= with_2.Columns.IndexOf("dia_31"); x++)
                        {
                            strLinha_Veiculacao += drwVeiculacao[x].ToString().PadLeft(2, '0');
                        }

                        //=========================Executa a Procedure para cada Linha
                        Cmd = Cnn.NewCommand();
                        Cnn = new Conexao.NET.clsConexao();
                        Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Connection = Cnn.spuConnection;
                        Cmd.CommandText = "prNet_Veiculacao_Insert ";
                        Cmd.Parameters.AddWithValue("@Par_Cod_Usuario", strCod_Usuario);
                        Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", strCod_Empresa);
                        Cmd.Parameters.AddWithValue("@Par_Numero_Mr", intNumero_Mr);
                        Cmd.Parameters.AddWithValue("@Par_Sequencia_Mr", shortSequencia_Mr);
                        Cmd.Parameters.AddWithValue("@Par_Indica_Grade", btIndica_Grade);
                        Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", strVeiculo);
                        Cmd.Parameters.AddWithValue("@Par_Cod_Programa", drwVeiculacao["Cod_Programa"].ToString());
                        Cmd.Parameters.AddWithValue("@Par_Cod_Comercial", drwVeiculacao["Cod_Comercial"].ToString());
                        Cmd.Parameters.AddWithValue("@Par_Cod_Caracteristica", drwVeiculacao["Cod_Caracteristica"].ToString());
                        Cmd.Parameters.AddWithValue("@Par_Competencia", intCompetencia);
                        Cmd.Parameters.AddWithValue("@Par_Linha_Veiculacao", strLinha_Veiculacao);
                        Cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                returnValue = false;
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }
            return returnValue; 
        }
        private DataTable  fnContarVeiculacao(string pCodEmpresa, Int32 pNumero_Mr, short pSequenca_Mr)
        {
            DataTable dtbRetorno = new DataTable();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            try
            {
                    Cnn.spuOpen(spAuthenticationHeader.strUserName, spAuthenticationHeader.strPassword);
                    SqlDataAdapter Adp = new SqlDataAdapter();
                    Adp.SelectCommand = Cnn.NewCommand("PrNet_Conta_Veiculacao");
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.Connection = Cnn.spuConnection;
                    Adp.SelectCommand.CommandTimeout = 0;
                    Adp.SelectCommand.Parameters.AddWithValue ("@Par_Cod_Empresa",pCodEmpresa );
                    Adp.SelectCommand.Parameters.AddWithValue ("@Par_Numero_Mr", pNumero_Mr );
                    Adp.SelectCommand.Parameters.AddWithValue ("@Par_Sequencia_Mr", pSequenca_Mr) ;
                    Adp.Fill(dtbRetorno);

                
            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message));
            }
            finally
            {
                Cnn.spuClose();
            }
            return Cnn.FnDtb(dtbRetorno); 
        }


        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public bool fnIem(string pCodEmpresa, int pNumeroMr, short pSequenciaMr, int pCompetencia, DataSet dtsVeiculo)
        {
            bool returnValue;
            returnValue = true;
            SqlCommand Cmd = null;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            try
            {
                //==========================Busca Dados do Contrato
                foreach (DataRow drwVeiculo in dtsVeiculo.Tables[0].Rows)
                {
                    Cmd = Cnn.NewCommand();
                    Cnn = new Conexao.NET.clsConexao();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "SP_IEM";
                    Cmd.Connection = Cnn.spuConnection;
                    Cmd.Parameters.AddWithValue("@Competencia", pCompetencia);
                    Cmd.Parameters.AddWithValue("@Cod_Empresa", pCodEmpresa);
                    Cmd.Parameters.AddWithValue("@Numero_Mr", pNumeroMr);
                    Cmd.Parameters.AddWithValue("@Sequencia_Mr", pSequenciaMr);
                    Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", drwVeiculo["Cod_Veiculo"]);
                    Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                returnValue = false;
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }
            return returnValue; 
        }
        
        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public String fnReabreCE(string pCodEmpresa, int pNumeroMr, short pSequenciaMr, String pVeiculo, String pMotivo)
        {
            string returnValue = "";
            SqlCommand Cmd = null;
            SqlDataReader Dtr;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            try
            {
                    Cmd = Cnn.NewCommand();
                    Cnn = new Conexao.NET.clsConexao();
                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "sp_Reabre_Ce";
                    Cmd.Connection = Cnn.spuConnection;
                    Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCodEmpresa);
                    Cmd.Parameters.AddWithValue("@Par_Numero_Mr", pNumeroMr);
                    Cmd.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequenciaMr);
                    if(pVeiculo != "") 
                        Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", pVeiculo);
                    else
                        Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", DBNull.Value );

                    Cmd.Parameters.AddWithValue("@Par_Motivo_Reabertura", pMotivo);
                    Dtr = Cmd.ExecuteReader();
                    Dtr.Read() ;
                    //string.TryParse(Dtr["Mensagem"].ToString , out returnValue);
                    returnValue = Dtr["Mensagem"].ToString();
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
        


        [WebMethod, SoapHeader("spAuthenticationHeader")] public bool 
        fnIEV(string pCod_Empresa, int pNumero_Mr, short pSequenciaMr, string pCod_Usuario, short pMotivoAlteracao)
        {
            bool returnValue;
            returnValue = true;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();

            SqlCommand Cmd = null;
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                //==========================Busca Dados do Contrato
                Cmd = Cnn.NewCommand();
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_Iev_Insert";

                Cmd.Parameters.AddWithValue("@pCod_Empresa", pCod_Empresa);
                Cmd.Parameters.AddWithValue("@pNumero_Mr", pNumero_Mr);
                Cmd.Parameters.AddWithValue("@pSequencia_Mr", pSequenciaMr);
                Cmd.Parameters.AddWithValue("@pIndica_Valora", 0);
                Cmd.Parameters.AddWithValue("@Par_Cod_Usuario", pCod_Usuario);
                Cmd.Parameters.AddWithValue("@PCod_Motivo_Valoracao", pMotivoAlteracao);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                returnValue = false;
                throw (new Exception(ex.Message.ToString()));
            }
            finally
            {
                Cnn.spuClose();
            }
            return returnValue;
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public bool fnExisteMr(string pCodEmpresa, int pNumeroMr, short pSequenciaMr)
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
                Cmd.CommandType = CommandType.StoredProcedure  ;
                Cmd.CommandText = "prNet_Contrato_Select";
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCodEmpresa );
                Cmd.Parameters.AddWithValue("@Par_Numero_Mr", pNumeroMr);
                Cmd.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequenciaMr );
                RD = Cmd.ExecuteReader();
                RD.Read();
                if (RD.HasRows)
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
                Cnn.spuClose();
            }
            return returnValue; 
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public short fnUltimaSequencia(string pCodEmpresa, int pNumeroMr)
        {
            short returnValue;
            returnValue = 0;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader RD;
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PrNet_Contrato_Ultima_Sequencia";
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCodEmpresa);
                Cmd.Parameters.AddWithValue("@Par_Numero_Mr", pNumeroMr);
                RD = Cmd.ExecuteReader();
                RD.Read();
                if (RD.HasRows)
                {
                    if (!RD.IsDBNull(0))
                    {
                        short.TryParse(RD["Ultima_Sequencia"].ToString(), out returnValue);
                    }
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
        public DataSet fnCarregaContrato(string pCodEmpresa, int pNumeroMr, short pSequenciaMr)
        {
            DataSet returnValue;
            returnValue = null;
            DTS.dtsContrato DTS = new DTS.dtsContrato();
            try
            {
                SqlDataAdapter Adp = new SqlDataAdapter();

                Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
                try
                {

                    Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                    //=================================Carrega Contrato
                    Adp.SelectCommand = Cnn.NewCommand();
                    Adp.SelectCommand.Connection = Cnn.spuConnection;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "prNet_Contrato_Select";
                    Adp.SelectCommand.Parameters.AddWithValue ("@Par_Cod_Empresa",pCodEmpresa);
                    Adp.SelectCommand.Parameters.AddWithValue ("@Par_Numero_Mr",pNumeroMr);
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequenciaMr);
                    Adp.Fill(DTS, "Contrato");

                    //=================================Carrega Comercial
                   Adp.SelectCommand = Cnn.NewCommand();
                    Adp.SelectCommand.Connection = Cnn.spuConnection;
                    Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adp.SelectCommand.CommandText = "prNet_Comercial_Select";
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCodEmpresa);
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Numero_Mr", pNumeroMr);
                    Adp.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_Mr", pSequenciaMr);
                    Adp.Fill(DTS, "Comercial");
                    returnValue = DTS;
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
            catch (Exception ex)
            {
                throw (new Exception(ex.Message));
            }
            return returnValue; 
        }
        [WebMethod, SoapHeader("spAuthenticationHeader")] 
        public DataSet fnDeterminacao_Dados_Contrato (string pCod_Empresa, int pContrato, short pSeq)
        {

            DataSet dts = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                AD.SelectCommand.CommandText = "PrNet_Determinacao_Dados_Contrato";
                AD.Fill(dts);
                return Cnn.FnDts(dts); 
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
        public DataSet  fnDeterminacao_Dados_Comercial(string pCod_Empresa, int pContrato, short pSeq)
        {

            DataSet dts = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                AD.SelectCommand.CommandText = "PrNet_Determinacao_Dados_Comercial";
                AD.Fill(dts);
                return Cnn.FnDts(dts); 
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
        public DataSet fnDeterminacao_Select(string pCod_Empresa, int pContrato, short pSeq,string pCod_Veiculo,DateTime pDataInicio, DateTime pDataFim)
        {

            DataSet dts = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                if (string.IsNullOrEmpty(pCod_Veiculo ))
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", DBNull.Value);
                else
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", pCod_Veiculo);
                }
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Inicio", pDataInicio);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Fim", pDataFim );
                AD.SelectCommand.CommandText = "PrNet_Determinacao_Select";
                AD.Fill(dts);
                return Cnn.FnDts(dts);
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
        public DataSet fnDeterminacaoPendente(DateTime pDataInicio , DateTime  pDataFim ,string pCodVeiculo, string pUsuario)
        {

            DataSet dts = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.CommandText = "PrNet_Determinacao_Pendente";
                
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Inicio", pDataInicio );
                AD.SelectCommand.Parameters.AddWithValue("@Par_Data_Fim", pDataFim );

                if (string.IsNullOrEmpty(pCodVeiculo))
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", DBNull.Value );
                }
                else
                {
                    AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Veiculo", pCodVeiculo);
                }

                AD.SelectCommand.Parameters.AddWithValue("@Par_Usuario", pUsuario );
                                
                
                AD.Fill(dts);
                return Cnn.FnDts(dts);
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
         public DataSet fnDeterminacao_Veiculo_Select(string pCod_Empresa, int pContrato, short pSeq)
        {

            DataSet dts = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                AD.SelectCommand.CommandText = "PrNet_Determinacao_Veiculo_Select";
                AD.Fill(dts);
                return Cnn.FnDts(dts);
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
         public void  fnDeterminacao_Delete(string pCod_Empresa, int pContrato, short pSeq,String pUsuario )
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                Cmd.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                Cmd.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                Cmd.Parameters.AddWithValue("@Par_Usuario", pUsuario );
                Cmd.CommandText = "PrNet_Determinacao_Delete";
                Cmd.ExecuteNonQuery();
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
         public void  fnDeterminacao_Insert(    string pCod_Empresa, 
                                                int pContrato, 
                                                short pSeq,
                                                String pCodVeiculo,
                                                DateTime pDataExibicao,
                                                String pCodPrograma ,
                                                int pChaveAcesso,
                                                String pCodComercial,
                                                byte pIndicaBaixa,
                                                byte pIndicaInclusao ,
                                                String pUsuario,
                                                byte pIndicaBaixado)
                    
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                Cmd.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                Cmd.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                Cmd.Parameters.AddWithValue("@Par_Cod_Veiculo", pCodVeiculo );
                Cmd.Parameters.AddWithValue("@Par_Data_Exibicao", pDataExibicao);
                Cmd.Parameters.AddWithValue("@Par_Cod_Programa", pCodPrograma );
                Cmd.Parameters.AddWithValue("@Par_Chave_Acesso", pChaveAcesso );
                Cmd.Parameters.AddWithValue("@Par_Cod_Comercial", pCodComercial );
                Cmd.Parameters.AddWithValue("@Par_Indica_Baixa", pIndicaBaixa );
                Cmd.Parameters.AddWithValue("@Par_Indica_Inclusao", pIndicaInclusao );
                Cmd.Parameters.AddWithValue("@Par_Usuario",pUsuario);
                Cmd.Parameters.AddWithValue("@Par_Indica_Baixado", pIndicaBaixado );

                Cmd.CommandText = "PrNet_Determinacao_Insert";
                Cmd.ExecuteNonQuery();
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
        public String fnDeterminacao_Comerciais(string pCod_Empresa, int pContrato, short  pSeq, string pCod_Usuario)
        {

            DataSet dts = new DataSet();
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter AD = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                AD.SelectCommand = Cnn.NewCommand();
                AD.SelectCommand.Connection = Cnn.spuConnection;
                AD.SelectCommand.CommandType = CommandType.StoredProcedure;
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                AD.SelectCommand.Parameters.AddWithValue("@Par_Cod_Usuario", pCod_Usuario);
                AD.SelectCommand.CommandText = "sp_determinacao";
                AD.Fill(dts);

                fnIEV(pCod_Empresa, pContrato, pSeq, pCod_Usuario, 4);

                return Cnn.FnDtb(dts.Tables[0]).Rows[0]["Critica"].ToString();
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
        public Boolean fnExisteComercial(string pCod_Empresa, int pContrato, int pSeq, string pCod_Comercial)
        {
            int qtdRegistro = 0;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataReader Dtr; 
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_Comercial_Veiculacao";
                
                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                Cmd.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                Cmd.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                Cmd.Parameters.AddWithValue("@Par_Cod_Comercial", pCod_Comercial );

                Dtr = Cmd.ExecuteReader();
                Dtr.Read();

                int.TryParse(Dtr["Qtd"].ToString(), out qtdRegistro);

                return qtdRegistro > 0; 

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
        public Boolean fnExcluirComercial(string pCod_Empresa, int pContrato, int pSeq, string pCod_Comercial)
        {
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlCommand Cmd = Cnn.NewCommand();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
                Cmd.Connection = Cnn.spuConnection;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "prNet_Comercial_Delete";

                Cmd.Parameters.AddWithValue("@Par_Cod_Empresa", pCod_Empresa);
                Cmd.Parameters.AddWithValue("@Par_Numero_MR", pContrato);
                Cmd.Parameters.AddWithValue("@Par_Sequencia_MR", pSeq);
                Cmd.Parameters.AddWithValue("@Par_Cod_Comercial", pCod_Comercial);
                Cmd.ExecuteNonQuery();
                return true;
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
 