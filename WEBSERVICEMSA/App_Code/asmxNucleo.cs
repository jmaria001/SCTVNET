using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;

namespace WebServiceMSA
{
	/// <summary>
	/// Summary description for asmxNucleo.
	/// </summary>
	public class asmxNucleo : System.Web.Services.WebService
	{
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

		public asmxNucleo()
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
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		#region "spuCarregar"

        //--Carrego tudo quando não for passado nenhum parametro
        [WebMethod(MessageName = "spuCarregarTudo"), SoapHeader("spAuthenticationHeader")]
        public DTS.dtsNucleo spuCarregar()
        {
            return this.spuCarregar("");
        }
                      

		[WebMethod, SoapHeader("spAuthenticationHeader")]
		public DTS.dtsNucleo spuCarregar ( string strCodNucleo )
		{
			DTS.dtsNucleo dtsNucleo;
			Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
			SqlDataAdapter adp = new SqlDataAdapter();
			try
			{
				dtsNucleo = new DTS.dtsNucleo();
				Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

				adp.SelectCommand = Cnn.NewCommand("prNet_Nucleo_S",Cnn.spuConnection);
				adp.SelectCommand.CommandType=CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Nucleo", (strCodNucleo.Length != 0 ? strCodNucleo : null));

				adp.Fill(dtsNucleo,"dtbNucleo");
			
			}
			catch(Exception ex)
			{
				throw new Exception ("Erro asmxNucleo.spuCarregar " + ex.Message.ToString());
			}
			finally
			{
				Cnn.spuClose();
			}
			return dtsNucleo ;
		}
		#endregion
        
		#region "spuAtualizar"
		
		[WebMethod, SoapHeader("spAuthenticationHeader")]
		public void spuAtualizar( DTS.dtsNucleo dtsNucleo )
		{
			Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
			SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.InsertCommand = Cnn.NewCommand("prNet_Nucleo_I", Cnn.spuConnection);
                adp.InsertCommand.CommandType = CommandType.StoredProcedure;
                adp.InsertCommand.Parameters.Add("@Cod_Nucleo_P", (SqlDbType.VarChar), 7, "Cod_Nucleo");
                adp.InsertCommand.Parameters.Add("@Cod_Empresa_P", (SqlDbType.VarChar), 3, "Cod_Empresa");
                adp.InsertCommand.Parameters.Add("@Cod_Centro_Custo_P", (SqlDbType.VarChar), 4, "Cod_Centro_Custo");
                adp.InsertCommand.Parameters.Add("@Descricao_P", (SqlDbType.VarChar), 30, "Descricao");
                adp.InsertCommand.Parameters.Add("@Cod_Empresa_Faturamento_P", (SqlDbType.VarChar), 3, "Cod_Empresa_Faturamento");

                adp.UpdateCommand = Cnn.NewCommand("prNet_Nucleo_U", Cnn.spuConnection);
                adp.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adp.UpdateCommand.Parameters.Add("@Cod_Nucleo_P", (SqlDbType.VarChar), 7, "Cod_Nucleo");
                adp.UpdateCommand.Parameters.Add("@Cod_Empresa_P", (SqlDbType.VarChar), 3, "Cod_Empresa");
                adp.UpdateCommand.Parameters.Add("@Cod_Centro_Custo_P", (SqlDbType.VarChar), 4, "Cod_Centro_Custo");
                adp.UpdateCommand.Parameters.Add("@Descricao_P", (SqlDbType.VarChar), 30, "Descricao");
                adp.UpdateCommand.Parameters.Add("@Cod_Empresa_Faturamento_P", (SqlDbType.VarChar), 3, "Cod_Empresa_Faturamento");

                adp.DeleteCommand = Cnn.NewCommand("prNet_Nucleo_D", Cnn.spuConnection);
                adp.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adp.DeleteCommand.Parameters.Add("@Cod_Nucleo_P", (SqlDbType.VarChar), 7, "Cod_Nucleo");

                adp.Update(dtsNucleo, dtsNucleo.dtbNucleo.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception("Erro asmxNucleo.spuAtualizar " + ex.Message.ToString());
            }
			finally
			{
				Cnn.spuClose();
			}
		}
		#endregion
	}
}
