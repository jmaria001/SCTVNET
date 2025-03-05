using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using WebServiceMSA.DTS;

/// <summary>
/// Summary description for asmxMotivo
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class asmxMotivo : System.Web.Services.WebService {
    public AuthSoapHd spAuthenticationHeader;
    public class AuthSoapHd : SoapHeader
    {
        public string strUserName;
        public string strPassword;
        public string strKey;
    }

    public asmxMotivo () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod, SoapHeader("spAuthenticationHeader")]
    public dtsMotivo spuCarregarMotivo_Falha()
    {
        dtsMotivo dtsMotivo;
        Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
        SqlDataAdapter adp = new SqlDataAdapter();
        try
        {
            dtsMotivo = new dtsMotivo();
            Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

            adp.SelectCommand = Cnn.NewCommand("prNet_Motivo_Falha_S", Cnn.spuConnection);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dtsMotivo.dtbMotivoFalha);
        }
        catch (Exception ex)
        {
            throw new Exception("\n\nasmxMotivo.spuCarregarMotivo_Falha\n\n" + ex.Message.ToString());
        }
        finally
        {
            Cnn.spuClose();
        }
        return dtsMotivo ;
    }

    [WebMethod, SoapHeader("spAuthenticationHeader")]
    public dtsMotivo spuCarregarMotivo_Alteracao()
    {
        dtsMotivo dtsMotivo;
        Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
        SqlDataAdapter adp = new SqlDataAdapter();
        try
        {
            dtsMotivo = new dtsMotivo();
            Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

            adp.SelectCommand = Cnn.NewCommand("prNet_Motivo_Alteracao_S", Cnn.spuConnection);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dtsMotivo.dtbMotivoAlteracao);
        }
        catch (Exception ex)
        {
            throw new Exception("\n\nasmxMotivo.spuCarregarMotivo_Alteracao\n\n" + ex.Message.ToString());
        }
        finally
        {
            Cnn.spuClose();
        }
        return dtsMotivo;
    }

    [WebMethod, SoapHeader("spAuthenticationHeader")]
    public dtsMotivo spuCarregarMotivo_Cancelamento()
    {
        dtsMotivo dtsMotivo;
        Conexao.NET.clsConexao Cnn = new Conexao.NET.clsConexao();
        SqlDataAdapter adp = new SqlDataAdapter();
        try
        {
            dtsMotivo = new dtsMotivo();
            Cnn.spuOpen(spAuthenticationHeader.strUserName,spAuthenticationHeader.strPassword);

            adp.SelectCommand = Cnn.NewCommand("prNet_Motivo_Cancelamento_S", Cnn.spuConnection);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dtsMotivo.dtbMotivoCancelamento);
        }
        catch (Exception ex)
        {
            throw new Exception("\n\nasmxMotivo.spuCarregarMotivo_Cancelamento\n\n" + ex.Message.ToString());
        }
        finally
        {
            Cnn.spuClose();
        }
        return dtsMotivo;
    }
}

