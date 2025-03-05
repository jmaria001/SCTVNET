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
    /// Summary description for asmxContato.
    /// </summary>
    /// 
 
 
    public class asmxContato : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

        public asmxContato()
        {
            //CODEGEN: This call is required by the ASP.NET Web Services Designer
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

        #region "spuCarregar"

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsContato spuCarregar(string strCodContato)
        {
            return this.spuCarregar(strCodContato, null);

        }

        [WebMethod(MessageName = "spuCarregar_ContatoEmpresa"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsContato spuCarregar(string strCodContato, string strCodEmpresa)
        {
            DTS.dtsContato dtsContato;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                dtsContato = new DTS.dtsContato();
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);



                this.sprCarregar_Contato(strCodContato, dtsContato.dtbContato, Cnn.spuConnection);
                this.sprCarregar_EmpresaContato(strCodContato, dtsContato.dtbContato_Empresa, Cnn.spuConnection);

                if (strCodEmpresa != null && strCodEmpresa.Trim().Length > 0)
                {
                    foreach (DTS.dtsContato.dtbContatoRow drwContato in dtsContato.dtbContato.Rows)
                    {
                        Boolean blnExisteEmpresa = false;

                        foreach (DTS.dtsContato.dtbContato_EmpresaRow drwEmpresa in dtsContato.dtbContato_Empresa.Select("Cod_Contato = '" + drwContato.Cod_Contato + "'"))
                        {
                            if (strCodEmpresa.IndexOf(drwEmpresa.Cod_Empresa) > -1)
                            {
                                blnExisteEmpresa = true;
                                break;
                            }
                        }

                        if (!blnExisteEmpresa)
                        {
                            drwContato.Delete();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxContato.spuCarregar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }
            return dtsContato;
        }

        private void sprCarregar_Contato(string strCod_Contato, DTS.dtsContato.dtbContatoDataTable dtbContato, SqlConnection Cnn)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                adp.SelectCommand = new SqlCommand("pr_Contato_S", Cnn);
                adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout; 
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Contato", (strCod_Contato.Length != 0 ? strCod_Contato : null));
                adp.Fill(dtbContato);
                // return Cnn.FnDtb(dtbContato;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxContato.sprCarregar_Contato " + ex.Message.ToString());
            }
        }

        private void sprCarregar_EmpresaContato(string strCod_Contato, DTS.dtsContato.dtbContato_EmpresaDataTable dtbContato_Empresa, SqlConnection Cnn)
        {
            SqlDataAdapter adp = new SqlDataAdapter();

            try
            {
                adp.SelectCommand = new SqlCommand("pr_Empresa_Contato_S", Cnn);
                adp.SelectCommand.CommandTimeout = Cnn.ConnectionTimeout ;
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Contato", (strCod_Contato.Length != 0 ? strCod_Contato : null));

                adp.Fill(dtbContato_Empresa);
                // return Cnn.FnDtb(dtbContato_Empresa;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxContato.sprCarregar_EmpresaContato " + ex.Message.ToString());
            }
        }
        #endregion



        #region "spuAtualizar"

        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public void spuAtualizar(DTS.dtsContato dtsContato, string cod_Contato)
        {
            //DTS.dtsContato dtsContato;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
            //SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn = new Conexao.NET.clsConexao();

                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                this.spuAtualizar_Contato(dtsContato.dtbContato, Cnn.spuConnection);
                //if (dtsContato.dtbContato.Rows == 1)
                this.spuAtualizar_Contato_Empresa(dtsContato.dtbContato_Empresa, Cnn.spuConnection, cod_Contato);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxContato.spuAtualizar " + ex.Message.ToString());
            }
            finally
            {
                Cnn.spuClose();
            }


        }

        private void spuAtualizar_Contato(DTS.dtsContato.dtbContatoDataTable dtbContato, SqlConnection Cnn)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                adp.UpdateCommand = new SqlCommand("pr_Contato_U", Cnn);
                adp.UpdateCommand.CommandTimeout = Cnn.ConnectionTimeout;
                adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adp.UpdateCommand.Parameters.Add("@Cod_Contato_P", (SqlDbType.VarChar), 5, "Cod_Contato");
                adp.UpdateCommand.Parameters.Add("@Nome_P", (SqlDbType.VarChar), 30, "Nome");
                adp.UpdateCommand.Parameters.Add("@CGC_P", (SqlDbType.VarChar), 18, "CGC");
                adp.UpdateCommand.Parameters.Add("@Indica_Cic_Cgc_P", (SqlDbType.Int), 4, "Indica_Cic_Cgc");
                adp.UpdateCommand.Parameters.Add("@Cod_Representante_P", (SqlDbType.Int), 4, "Cod_Representante");
                adp.UpdateCommand.Parameters.Add("@Cod_Usuario_Inclusao_P", (SqlDbType.VarChar), 30, "Cod_Usuario_Inclusao");
                // adp.UpdateCommand.Parameters.Add("@Data_Inclusao_P", (SqlDbType.DateTime), 8, "Data_Inclusao");
                adp.UpdateCommand.Parameters.Add("@Data_Desativacao_P", (SqlDbType.DateTime), 19, "Data_Desativacao");
                adp.UpdateCommand.Parameters.Add("@Cod_Usuario_Desativacao_P", (SqlDbType.VarChar), 30, ("Cod_Usuario_Desativacao".ToString() == "" ? "Cod_Usuario_Desativacao" : null));
                adp.UpdateCommand.Parameters.Add("@Email_Notificacao", (SqlDbType.VarChar), 200, "Email_Notificacao");


                adp.InsertCommand = new SqlCommand("pr_Contato_I", Cnn);
                adp.InsertCommand.CommandTimeout = Cnn.ConnectionTimeout;
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Parameters.Add("@Cod_Contato_P", (SqlDbType.VarChar), 5, "Cod_Contato");
                adp.InsertCommand.Parameters.Add("@Nome_P", (SqlDbType.VarChar), 30, "Nome");
                adp.InsertCommand.Parameters.Add("@CGC_P", (SqlDbType.VarChar), 18, "CGC");
                adp.InsertCommand.Parameters.Add("@Indica_Cic_Cgc_P", (SqlDbType.Int), 4, "Indica_Cic_Cgc");
                adp.InsertCommand.Parameters.Add("@Cod_Representante_P", (SqlDbType.Int), 4, "Cod_Representante");
                adp.InsertCommand.Parameters.Add("@Cod_Usuario_Inclusao_P", (SqlDbType.VarChar), 30, "Cod_Usuario_Inclusao");
                // adp.InsertCommand.Parameters.Add("@Data_Inclusao_P", (SqlDbType.DateTime), 8, "Data_Inclusao");
                // adp.InsertCommand.Parameters.Add("@Data_Desativacao_P", (SqlDbType.DateTime), 8, "Data_Desativacao");
                adp.InsertCommand.Parameters.Add("@Cod_Usuario_Desativacao_P", (SqlDbType.VarChar), 30, "Cod_Usuario_Desativacao");
                adp.InsertCommand.Parameters.Add("@Email_Notificacao", (SqlDbType.VarChar), 200, "Email_Notificacao");

                adp.DeleteCommand = new SqlCommand("pr_Contato_D", Cnn);
                adp.DeleteCommand.CommandTimeout = Cnn.ConnectionTimeout;
                adp.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adp.DeleteCommand.Parameters.Add("@Cod_Contato_P", (SqlDbType.VarChar), 5, "Cod_Contato");

                adp.Update(dtbContato);

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message.ToString());
            }


        }

        private void spuAtualizar_Contato_Empresa(DTS.dtsContato.dtbContato_EmpresaDataTable dtbContato_Empresa, SqlConnection Cnn, string cod_Contato)
        {


            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();

                adp.UpdateCommand = new SqlCommand("pr_Contato_Empresa_U", Cnn);
                adp.UpdateCommand.CommandTimeout = Cnn.ConnectionTimeout;
                adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adp.UpdateCommand.Parameters.Add("@Cod_Empresa", (SqlDbType.VarChar), 5, "Cod_Empresa");
                adp.UpdateCommand.Parameters.AddWithValue("@Cod_Contato", (cod_Contato.Length != 0 ? cod_Contato : null));
                adp.UpdateCommand.Parameters.Add("@Indica_Associado", (SqlDbType.Bit), 1, "Indica_Associado");

                adp.DeleteCommand = new SqlCommand("pr_Contato_Empresa_D", Cnn);
                adp.DeleteCommand.CommandTimeout = Cnn.ConnectionTimeout;
                adp.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adp.DeleteCommand.Parameters.Add("@Cod_Contato_P", (SqlDbType.VarChar), 5, (cod_Contato.Length != 0 ? cod_Contato : null));

                adp.Update(dtbContato_Empresa);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na asmcontato.spuAtualizar_Contato_Empresa" + ex.Message.ToString());
            }

        }

        #endregion


    }
}
