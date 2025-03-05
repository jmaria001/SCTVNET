Imports Criptografia
Module modNewClass

    Public Function NewAM(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxAM.asmxAM
        Dim NewClass As New MSAClass.AsmxAM.asmxAM
        Dim Header As New MSAClass.AsmxAM.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewBaixaVeiculacao(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxBaixaVeiculacao.asmxBaixaVeiculacao
        Dim NewClass As New MSAClass.AsmxBaixaVeiculacao.asmxBaixaVeiculacao
        Dim Header As New MSAClass.AsmxBaixaVeiculacao.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewBreak(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxBreak.asmxBreak
        Dim NewClass As New MSAClass.AsmxBreak.asmxBreak
        Dim Header As New MSAClass.AsmxBreak.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewChecking(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxChecking.asmxChecking
        Dim NewClass As New MSAClass.AsmxChecking.asmxChecking
        Dim Header As New MSAClass.AsmxChecking.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewContato(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxContato.asmxContato
        Dim NewClass As New MSAClass.AsmxContato.asmxContato
        Dim Header As New MSAClass.AsmxContato.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewContrato(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.asmxContrato.asmxContrato
        Dim NewClass As New MSAClass.asmxContrato.asmxContrato
        Dim Header As New MSAClass.asmxContrato.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewControleFita(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxControleFita.asmxControleFita
        Dim NewClass As New MSAClass.AsmxControleFita.asmxControleFita
        Dim Header As New MSAClass.AsmxControleFita.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewEmpresa(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxEmpresa.asmxEmpresa
        Dim NewClass As New MSAClass.AsmxEmpresa.asmxEmpresa
        Dim Header As New MSAClass.AsmxEmpresa.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewFaixaHoraria(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxFaixaHoraria.asmxFaixaHoraria
        Dim NewClass As New MSAClass.AsmxFaixaHoraria.asmxFaixaHoraria
        Dim Header As New MSAClass.AsmxFaixaHoraria.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewFita_Ordenada(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxFita_Ordenada.asmxFita_Ordenada
        Dim NewClass As New MSAClass.AsmxFita_Ordenada.asmxFita_Ordenada
        Dim Header As New MSAClass.AsmxFita_Ordenada.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewGeneric(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.asmxGeneric.asmxGeneric
        Dim NewClass As New MSAClass.asmxGeneric.asmxGeneric
        Dim Header As New MSAClass.asmxGeneric.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewGrade(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxGrade.asmxGrade
        Dim NewClass As New MSAClass.AsmxGrade.asmxGrade
        Dim Header As New MSAClass.AsmxGrade.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewHistoricoMr(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.asmxHistoricoMr.asmxHistoricoMr
        Dim NewClass As New MSAClass.asmxHistoricoMr.asmxHistoricoMr
        Dim Header As New MSAClass.asmxHistoricoMr.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewMotivo(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxMotivo.asmxMotivo
        Dim NewClass As New MSAClass.AsmxMotivo.asmxMotivo
        Dim Header As New MSAClass.AsmxMotivo.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewNaturezaServico(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxNaturezaServico.asmxNaturezaServico
        Dim NewClass As New MSAClass.AsmxNaturezaServico.asmxNaturezaServico
        Dim Header As New MSAClass.AsmxNaturezaServico.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewNucleo(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxNucleo.asmxNucleo
        Dim NewClass As New MSAClass.AsmxNucleo.asmxNucleo
        Dim Header As New MSAClass.AsmxNucleo.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewParametro(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxParametro.asmxParametro
        Dim NewClass As New MSAClass.AsmxParametro.asmxParametro
        Dim Header As New MSAClass.AsmxParametro.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewParametro_Roteiro(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxParametro_Roteiro.asmxParametro_Roteiro
        Dim NewClass As New MSAClass.AsmxParametro_Roteiro.asmxParametro_Roteiro
        Dim Header As New MSAClass.AsmxParametro_Roteiro.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewPorta(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxPorta.asmxPorta
        Dim NewClass As New MSAClass.AsmxPorta.asmxPorta
        Dim Header As New MSAClass.AsmxPorta.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewProduto(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.asmxProduto.asmxProduto
        Dim NewClass As New MSAClass.asmxProduto.asmxProduto
        Dim Header As New MSAClass.asmxProduto.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewPrograma(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxPrograma.asmxPrograma
        Dim NewClass As New MSAClass.AsmxPrograma.asmxPrograma
        Dim Header As New MSAClass.AsmxPrograma.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewQualidade(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxQualidade.asmxQualidade
        Dim NewClass As New MSAClass.AsmxQualidade.asmxQualidade
        Dim Header As New MSAClass.AsmxQualidade.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRetornoPlayList(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxRetornoPlayList.asmxRetornoPlayList
        Dim NewClass As New MSAClass.AsmxRetornoPlayList.asmxRetornoPlayList
        Dim Header As New MSAClass.AsmxRetornoPlayList.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRoteiro(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.asmxRoteiro.asmxRoteiro
        Dim NewClass As New MSAClass.asmxRoteiro.asmxRoteiro
        Dim Header As New MSAClass.asmxRoteiro.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRoteiroLog(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxRoteiroLog.asmxRoteiroLog
        Dim NewClass As New MSAClass.AsmxRoteiroLog.asmxRoteiroLog
        Dim Header As New MSAClass.AsmxRoteiroLog.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRoteiro_Confirmacao(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxRoteiro_Confirmacao.asmxRoteiro_Confirmacao
        Dim NewClass As New MSAClass.AsmxRoteiro_Confirmacao.asmxRoteiro_Confirmacao
        Dim Header As New MSAClass.AsmxRoteiro_Confirmacao.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewRoteiro_Relatorios(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxRoteiro_Relatorios.asmxRoteiro_Relatorios
        Dim NewClass As New MSAClass.AsmxRoteiro_Relatorios.asmxRoteiro_Relatorios
        Dim Header As New MSAClass.AsmxRoteiro_Relatorios.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewTerceiro(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxTerceiro.asmxTerceiro
        Dim NewClass As New MSAClass.AsmxTerceiro.asmxTerceiro
        Dim Header As New MSAClass.AsmxTerceiro.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewTipoComercial(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxTipoComercial.asmxTipoComercial
        Dim NewClass As New MSAClass.AsmxTipoComercial.asmxTipoComercial
        Dim Header As New MSAClass.AsmxTipoComercial.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewTipoMidia(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxTipoMidia.asmxTipoMidia
        Dim NewClass As New MSAClass.AsmxTipoMidia.asmxTipoMidia
        Dim Header As New MSAClass.AsmxTipoMidia.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewUsuario(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.asmxUsuario.asmxUsuario
        Dim NewClass As New MSAClass.asmxUsuario.asmxUsuario
        Dim Header As New MSAClass.asmxUsuario.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function

    Public Function NewVeiculo(ByVal gsUsuario As String, ByVal gsSenha As String) As MSAClass.AsmxVeiculo.asmxVeiculo
        Dim NewClass As New MSAClass.AsmxVeiculo.asmxVeiculo
        Dim Header As New MSAClass.AsmxVeiculo.AuthSoapHd
        Header.strUserName = gsUsuario
        Header.strPassword = Funcoes.Criptografar(gsSenha)
        NewClass.AuthSoapHdValue = Header
        Return NewClass
    End Function
End Module


