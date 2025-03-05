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
	/// <summary>
	/// Summary description for asmxEmpresa.
	/// </summary>
	public class asmxEmpresa : System.Web.Services.WebService
	{
		public asmxEmpresa()
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
		public DTS.dtsEmpresa spuCarregar ( string strCod_Empresa )
		{
			DTS.dtsEmpresa dtsEmpresa;
            Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
			SqlDataAdapter adp = new SqlDataAdapter();
			
			try
			{
				dtsEmpresa = new DTS.dtsEmpresa();
				Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);
		
				adp.SelectCommand= Cnn.NewCommand("pr_Empresa_S",Cnn.spuConnection);
				adp.SelectCommand.CommandType=CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@PCod_Empresa", (strCod_Empresa.Length != 0 ? strCod_Empresa : null));
				
				adp.Fill(dtsEmpresa, "dtbEmpresa");

                // Cria uma coluna "Descricao" contendo o Código e a Razao Social concatenados
                foreach (DTS.dtsEmpresa.dtbEmpresaRow dtrEmpresa in dtsEmpresa.dtbEmpresa.Rows)
                {
                    dtrEmpresa.Descricao = dtrEmpresa.Cod_Empresa + " - " + dtrEmpresa.Razao_Social;
                }

                //for (int x = 0; x < dtsEmpresa.dtbEmpresa.Rows.Count ; x++)
                //{
                //    DTS.dtsEmpresa.dtbEmpresaRow dtrEmpresa = (DTS.dtsEmpresa.dtbEmpresaRow)dtsEmpresa.dtbEmpresa.Rows[x];
                //    dtrEmpresa.Descricao = dtrEmpresa.Cod_Empresa + " - " + dtrEmpresa.Razao_Social;
                //}
			}
			catch (Exception ex)
			{
				throw new Exception("Erro asmxEmpresa.spuCarregar " + ex.Message.ToString());
			}
			finally
			{
				Cnn.spuClose();
			}
			return Cnn.FnDtb(dtsEmpresa);			
		}
      
	}
}
