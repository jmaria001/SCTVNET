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
	/// Summary description for asmxNaturezaServico.
	/// </summary>
	public class asmxNaturezaServico : System.Web.Services.WebService
	{
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

		public asmxNaturezaServico()
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
	
		[WebMethod, SoapHeader("spAuthenticationHeader")]
		public DTS.dtsNaturezaServico spuCarregar ( string strCodEmpresa, string strCodNatureza )
		{
			DTS.dtsNaturezaServico dtsNaturezaServico;
			Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
			SqlDataAdapter adp = new SqlDataAdapter();
			try
			{
				dtsNaturezaServico = new DTS.dtsNaturezaServico();
				Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("pr_Natureza_Servico_S", Cnn.spuConnection);
				adp.SelectCommand.CommandType=CommandType.StoredProcedure;
				adp.SelectCommand.Parameters.AddWithValue("@PCod_Empresa",(strCodEmpresa.Length != 0 ? strCodEmpresa:null));
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Natureza", (strCodNatureza.Length != 0 ? strCodNatureza : null));
				adp.Fill(dtsNaturezaServico,"dtbNaturezaServico");

			}
			catch(Exception ex)
			{
				throw new Exception ("Erro asmxNaturezaServico.spuCarregar " + ex.Message.ToString());
			}
			finally
			{
				Cnn.spuClose();
			}
            return dtsNaturezaServico;
		}
	}
}
