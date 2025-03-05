﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:2.0.50727.5485
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace MSAClass.AsmxFita_Ordenada {
    using System.Xml.Serialization;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Diagnostics;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="asmxFita_OrdenadaSoap", Namespace="http://tempuri.org/")]
    public partial class asmxFita_Ordenada : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private AuthSoapHd authSoapHdValueField;
        
        private System.Threading.SendOrPostCallback spuCarregarOperationCompleted;
        
        /// <remarks/>
        public asmxFita_Ordenada() {
            string urlSetting = System.Configuration.ConfigurationManager.AppSettings["url_AsmxFita_Ordenada"];
            if ((urlSetting != null)) {
                this.Url = urlSetting;
            }
            else {
                this.Url = "http://localhost/WebServiceMSA/AsmxFita_Ordenada.asmx";
            }
        }
        
        public AuthSoapHd AuthSoapHdValue {
            get {
                return this.authSoapHdValueField;
            }
            set {
                this.authSoapHdValueField = value;
            }
        }
        
        /// <remarks/>
        public event spuCarregarCompletedEventHandler spuCarregarCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthSoapHdValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/spuCarregar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable spuCarregar(string strCod_Veiculo, string strCod_Programa, System.DateTime dtData_Inicio, System.DateTime dtData_Fim, string strFita_Inicio, string strFita_Fim, string strEmpresa_Usuario, string strCod_Empresa, long lngNumero_Mr, short shtSequencia_Mr) {
            object[] results = this.Invoke("spuCarregar", new object[] {
                        strCod_Veiculo,
                        strCod_Programa,
                        dtData_Inicio,
                        dtData_Fim,
                        strFita_Inicio,
                        strFita_Fim,
                        strEmpresa_Usuario,
                        strCod_Empresa,
                        lngNumero_Mr,
                        shtSequencia_Mr});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginspuCarregar(string strCod_Veiculo, string strCod_Programa, System.DateTime dtData_Inicio, System.DateTime dtData_Fim, string strFita_Inicio, string strFita_Fim, string strEmpresa_Usuario, string strCod_Empresa, long lngNumero_Mr, short shtSequencia_Mr, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("spuCarregar", new object[] {
                        strCod_Veiculo,
                        strCod_Programa,
                        dtData_Inicio,
                        dtData_Fim,
                        strFita_Inicio,
                        strFita_Fim,
                        strEmpresa_Usuario,
                        strCod_Empresa,
                        lngNumero_Mr,
                        shtSequencia_Mr}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataTable EndspuCarregar(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void spuCarregarAsync(string strCod_Veiculo, string strCod_Programa, System.DateTime dtData_Inicio, System.DateTime dtData_Fim, string strFita_Inicio, string strFita_Fim, string strEmpresa_Usuario, string strCod_Empresa, long lngNumero_Mr, short shtSequencia_Mr) {
            this.spuCarregarAsync(strCod_Veiculo, strCod_Programa, dtData_Inicio, dtData_Fim, strFita_Inicio, strFita_Fim, strEmpresa_Usuario, strCod_Empresa, lngNumero_Mr, shtSequencia_Mr, null);
        }
        
        /// <remarks/>
        public void spuCarregarAsync(string strCod_Veiculo, string strCod_Programa, System.DateTime dtData_Inicio, System.DateTime dtData_Fim, string strFita_Inicio, string strFita_Fim, string strEmpresa_Usuario, string strCod_Empresa, long lngNumero_Mr, short shtSequencia_Mr, object userState) {
            if ((this.spuCarregarOperationCompleted == null)) {
                this.spuCarregarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnspuCarregarOperationCompleted);
            }
            this.InvokeAsync("spuCarregar", new object[] {
                        strCod_Veiculo,
                        strCod_Programa,
                        dtData_Inicio,
                        dtData_Fim,
                        strFita_Inicio,
                        strFita_Fim,
                        strEmpresa_Usuario,
                        strCod_Empresa,
                        lngNumero_Mr,
                        shtSequencia_Mr}, this.spuCarregarOperationCompleted, userState);
        }
        
        private void OnspuCarregarOperationCompleted(object arg) {
            if ((this.spuCarregarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.spuCarregarCompleted(this, new spuCarregarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class AuthSoapHd : System.Web.Services.Protocols.SoapHeader {
        
        private string strUserNameField;
        
        private string strPasswordField;
        
        private string strKeyField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string strUserName {
            get {
                return this.strUserNameField;
            }
            set {
                this.strUserNameField = value;
            }
        }
        
        /// <remarks/>
        public string strPassword {
            get {
                return this.strPasswordField;
            }
            set {
                this.strPasswordField = value;
            }
        }
        
        /// <remarks/>
        public string strKey {
            get {
                return this.strKeyField;
            }
            set {
                this.strKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void spuCarregarCompletedEventHandler(object sender, spuCarregarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class spuCarregarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal spuCarregarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
}
