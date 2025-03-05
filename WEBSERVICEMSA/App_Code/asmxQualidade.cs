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
	/// Summary description for asmxQualidade.
	/// </summary>
	public class asmxQualidade : System.Web.Services.WebService
    {
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }

		public asmxQualidade()
		{
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
        public DTS.dtsQualidade spuCarregar(string strCodQualidade)
		{
			DTS.dtsQualidade dtsQualidade;
			Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
			SqlDataAdapter adp = new SqlDataAdapter();
			try
			{
				dtsQualidade = new DTS.dtsQualidade();
				Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

				adp.SelectCommand = Cnn.NewCommand("prNet_Qualidade_S",Cnn.spuConnection);
				adp.SelectCommand.CommandType=CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@strQualidadeCodigo_P", (strCodQualidade.Length != 0 ? strCodQualidade : null));
				adp.Fill(dtsQualidade,"dtbQualidade");						
			
			}
			catch(Exception ex)
			{
				throw new Exception("Erro asmxQualidade.spuCarregar " + ex.Message.ToString());
			}
			finally
			{
				Cnn.spuClose();
			}
			return dtsQualidade;		
		}		

	}
}
