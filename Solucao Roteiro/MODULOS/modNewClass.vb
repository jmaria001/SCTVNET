Imports Criptografia
Module modNewClass
    Public Function NewAM() As MSAClass.AsmxAM.asmxAM
        Dim NewClass As New MSAClass.AsmxAM.asmxAM
        Dim Header As New MSAClass.AsmxAM.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewBaixaVeiculacao() As MSAClass.AsmxBaixaVeiculacao.asmxBaixaVeiculacao
        Dim NewClass As New MSAClass.AsmxBaixaVeiculacao.asmxBaixaVeiculacao
        Dim Header As New MSAClass.AsmxBaixaVeiculacao.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewBreak() As MSAClass.AsmxBreak.asmxBreak
        Dim NewClass As New MSAClass.AsmxBreak.asmxBreak
        Dim Header As New MSAClass.AsmxBreak.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewChecking() As MSAClass.AsmxChecking.asmxChecking
        Dim NewClass As New MSAClass.AsmxChecking.asmxChecking
        Dim Header As New MSAClass.AsmxChecking.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewContato() As MSAClass.AsmxContato.asmxContato
        Dim NewClass As New MSAClass.AsmxContato.asmxContato
        Dim Header As New MSAClass.AsmxContato.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewContrato() As MSAClass.asmxContrato.asmxContrato
        Dim NewClass As New MSAClass.asmxContrato.asmxContrato
        Dim Header As New MSAClass.asmxContrato.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewControleFita() As MSAClass.AsmxControleFita.asmxControleFita
        Dim NewClass As New MSAClass.AsmxControleFita.asmxControleFita
        Dim Header As New MSAClass.AsmxControleFita.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewEmpresa() As MSAClass.AsmxEmpresa.asmxEmpresa
        Dim NewClass As New MSAClass.AsmxEmpresa.asmxEmpresa
        Dim Header As New MSAClass.AsmxEmpresa.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewFaixaHoraria() As MSAClass.AsmxFaixaHoraria.asmxFaixaHoraria
        Dim NewClass As New MSAClass.AsmxFaixaHoraria.asmxFaixaHoraria
        Dim Header As New MSAClass.AsmxFaixaHoraria.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewFita_Ordenada() As MSAClass.AsmxFita_Ordenada.asmxFita_Ordenada
        Dim NewClass As New MSAClass.AsmxFita_Ordenada.asmxFita_Ordenada
        Dim Header As New MSAClass.AsmxFita_Ordenada.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewGeneric() As MSAClass.asmxGeneric.asmxGeneric
        Dim NewClass As New MSAClass.asmxGeneric.asmxGeneric
        Dim Header As New MSAClass.asmxGeneric.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewGrade() As MSAClass.AsmxGrade.asmxGrade
        Dim NewClass As New MSAClass.AsmxGrade.asmxGrade
        Dim Header As New MSAClass.AsmxGrade.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewHistoricoMr() As MSAClass.asmxHistoricoMr.asmxHistoricoMr
        Dim NewClass As New MSAClass.asmxHistoricoMr.asmxHistoricoMr
        Dim Header As New MSAClass.asmxHistoricoMr.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewMotivo() As MSAClass.AsmxMotivo.asmxMotivo
        Dim NewClass As New MSAClass.AsmxMotivo.asmxMotivo
        Dim Header As New MSAClass.AsmxMotivo.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewNaturezaServico() As MSAClass.AsmxNaturezaServico.asmxNaturezaServico
        Dim NewClass As New MSAClass.AsmxNaturezaServico.asmxNaturezaServico
        Dim Header As New MSAClass.AsmxNaturezaServico.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewNucleo() As MSAClass.AsmxNucleo.asmxNucleo
        Dim NewClass As New MSAClass.AsmxNucleo.asmxNucleo
        Dim Header As New MSAClass.AsmxNucleo.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewParametro() As MSAClass.AsmxParametro.asmxParametro
        Dim NewClass As New MSAClass.AsmxParametro.asmxParametro
        Dim Header As New MSAClass.AsmxParametro.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewParametro_Roteiro() As MSAClass.AsmxParametro_Roteiro.asmxParametro_Roteiro
        Dim NewClass As New MSAClass.AsmxParametro_Roteiro.asmxParametro_Roteiro
        Dim Header As New MSAClass.AsmxParametro_Roteiro.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewPorta() As MSAClass.AsmxPorta.asmxPorta
        Dim NewClass As New MSAClass.AsmxPorta.asmxPorta
        Dim Header As New MSAClass.AsmxPorta.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewProduto() As MSAClass.asmxProduto.asmxProduto
        Dim NewClass As New MSAClass.asmxProduto.asmxProduto
        Dim Header As New MSAClass.asmxProduto.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewPrograma() As MSAClass.AsmxPrograma.asmxPrograma
        Dim NewClass As New MSAClass.AsmxPrograma.asmxPrograma
        Dim Header As New MSAClass.AsmxPrograma.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewQualidade() As MSAClass.AsmxQualidade.asmxQualidade
        Dim NewClass As New MSAClass.AsmxQualidade.asmxQualidade
        Dim Header As New MSAClass.AsmxQualidade.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRetornoPlayList() As MSAClass.AsmxRetornoPlayList.asmxRetornoPlayList
        Dim NewClass As New MSAClass.AsmxRetornoPlayList.asmxRetornoPlayList
        Dim Header As New MSAClass.AsmxRetornoPlayList.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRoteiro() As MSAClass.asmxRoteiro.asmxRoteiro
        Dim NewClass As New MSAClass.asmxRoteiro.asmxRoteiro
        Dim Header As New MSAClass.asmxRoteiro.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRoteiroLog() As MSAClass.AsmxRoteiroLog.asmxRoteiroLog
        Dim NewClass As New MSAClass.AsmxRoteiroLog.asmxRoteiroLog
        Dim Header As New MSAClass.AsmxRoteiroLog.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRoteiro_Confirmacao() As MSAClass.AsmxRoteiro_Confirmacao.asmxRoteiro_Confirmacao
        Dim NewClass As New MSAClass.AsmxRoteiro_Confirmacao.asmxRoteiro_Confirmacao
        Dim Header As New MSAClass.AsmxRoteiro_Confirmacao.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRoteiro_Relatorios() As MSAClass.AsmxRoteiro_Relatorios.asmxRoteiro_Relatorios
        Dim NewClass As New MSAClass.AsmxRoteiro_Relatorios.asmxRoteiro_Relatorios
        Dim Header As New MSAClass.AsmxRoteiro_Relatorios.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewTerceiro() As MSAClass.AsmxTerceiro.asmxTerceiro
        Dim NewClass As New MSAClass.AsmxTerceiro.asmxTerceiro
        Dim Header As New MSAClass.AsmxTerceiro.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strpassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewTipoComercial() As MSAClass.AsmxTipoComercial.asmxTipoComercial
        Dim NewClass As New MSAClass.AsmxTipoComercial.asmxTipoComercial
        Dim Header As New MSAClass.AsmxTipoComercial.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewTipoMidia() As MSAClass.AsmxTipoMidia.asmxTipoMidia
        Dim NewClass As New MSAClass.AsmxTipoMidia.asmxTipoMidia
        Dim Header As New MSAClass.AsmxTipoMidia.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass

    End Function

    Public Function NewUsuario() As MSAClass.asmxUsuario.asmxUsuario
        Dim NewClass As New MSAClass.asmxUsuario.asmxUsuario
        Dim Header As New MSAClass.asmxUsuario.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewVeiculo() As MSAClass.AsmxVeiculo.asmxVeiculo
        Dim NewClass As New MSAClass.AsmxVeiculo.asmxVeiculo
        Dim Header As New MSAClass.AsmxVeiculo.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function
End Module
