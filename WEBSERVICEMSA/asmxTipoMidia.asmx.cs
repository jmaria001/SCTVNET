using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WebServiceMSA
{
	public class asmxTipoMidia : System.Web.Services.WebService
	{
		public asmxTipoMidia()
		{
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
		public DTS.dtsTipoMidia spuCarregar ( string strCodTipoMidia )
		{
			DTS.dtsTipoMidia dtsTipoMidia;
			Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
			SqlDataAdapter adp = new SqlDataAdapter();
			try
			{
				dtsTipoMidia = new DTS.dtsTipoMidia();
				Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

				adp.SelectCommand = Cnn.NewCommand("prNet_Tipo_Midia_S",Cnn.spuConnection);
				adp.SelectCommand.CommandType=CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Tipo_Midia", (strCodTipoMidia.Length != 0 ? strCodTipoMidia : null));
				adp.Fill(dtsTipoMidia,"dtbTipoMidia");
			
			}
			catch(Exception ex)
			{
				throw new Exception("Erro asmxTipoMidai.spuCarregar " + ex.Message.ToString());
			}
			finally
			{
				Cnn.spuClose();
			}
			return Cnn.FnDtb(dtsTipoMidia);
		}
	}
}
