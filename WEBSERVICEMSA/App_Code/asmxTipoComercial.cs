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
	/// Summary description for asmxTipoComercial.
	/// </summary>
	public class asmxTipoComercial : System.Web.Services.WebService
    {        
        public AuthSoapHd spAuthenticationHeader;
        public class AuthSoapHd : SoapHeader
        {
            public string strUserName;
            public string strPassword;
            public string strKey;
        }


		public asmxTipoComercial()
		{
		}
        [WebMethod, SoapHeader("spAuthenticationHeader")]
        public DTS.dtsTipoComercial Create()
        {
            DTS.dtsTipoComercial dtsTipoComercial = new DTS.dtsTipoComercial();
            return dtsTipoComercial;
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
		public DTS.dtsTipoComercial spuCarregar ( string strCodTipoComercial )
		{
			DTS.dtsTipoComercial dtsTipoComercial;
			Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
			SqlDataAdapter adp = new SqlDataAdapter();
			try
			{
				dtsTipoComercial = new DTS.dtsTipoComercial();
				Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

                adp.SelectCommand = Cnn.NewCommand("prNet_Tipo_Comercial_S", Cnn.spuConnection);
				adp.SelectCommand.CommandType=CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Tipo_Comercial", (strCodTipoComercial.Length != 0 ? strCodTipoComercial : null));
				adp.Fill(dtsTipoComercial.dtbTipo_Comercial);
			}
			catch(Exception ex)
			{
				throw new Exception ("Erro asmxTipoComercial.spuCarregar " + ex.Message.ToString());
			}
			finally
			{
				Cnn.spuClose();
			}
			return dtsTipoComercial;		
		}		

	}
}
