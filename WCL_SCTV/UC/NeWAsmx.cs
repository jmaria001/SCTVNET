using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo
{
    public class Asmx
    {
        public Asmx()
        {
        }

        public MSAClass.AsmxVeiculo.asmxVeiculo NewVeiculo(string pUsuario, string pSenha) 
         {
            MSAClass.AsmxVeiculo.asmxVeiculo NewClass = new MSAClass.AsmxVeiculo.asmxVeiculo() ;
            MSAClass.AsmxVeiculo.AuthSoapHd Header = new MSAClass.AsmxVeiculo.AuthSoapHd();
            Header.strUserName = pUsuario ;
            Header.strPassword = pSenha;
            NewClass.AuthSoapHdValue = Header;
            return NewClass ;
         }
        public MSAClass.AsmxPrograma.asmxPrograma NewPrograma(string pUsuario, string pSenha)
        {
            MSAClass.AsmxPrograma.asmxPrograma NewClass = new MSAClass.AsmxPrograma.asmxPrograma(); 
            MSAClass.AsmxPrograma.AuthSoapHd Header = new MSAClass.AsmxPrograma.AuthSoapHd();
            Header.strUserName = pUsuario;
            Header.strPassword = pSenha;
            NewClass.AuthSoapHdValue = Header;
            return NewClass;
        }
    }
}

