<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxRetornoPlayList.aspx.cs" Inherits="Help_Default" Title="Retorno da Play List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Esta rotina
             permite que o SCTV importe o log gerado no software de exibi��o da emissora, bastando
             para isso, que haja um lay out pr� definido desta integra��o de arquivos.<?xml namespace=""
                 ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Opera��o</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                Para processarmos
                        esta rotina devemos preencher os seguintes campos:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar o c�digo do ve�culo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data de Exibi��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar a data do roteiro a ser integrado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Localiza��o do Arquivo de Log da Exibi��o</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> � caminho (diret�rio)
                            onde o SCTV dever� buscar a integra��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Mostrar Fitas Avulsas</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � se este campo estiver selecionado o
                            sistema ir� mostrar as fitas avulsas que est�o roteirizadas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Mostrar Fitas Art�sticas</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> � se este campo
                            estiver selecionado o sistema ir� mostrar as filtas art�sticas que est�o roteirizadas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Considerar Log�s no per�odo</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> � Data Inicio,
                            Data Fim, Hora Inicio e Hora Fim, estes campos vir�o preenchidos automaticamente
                            conforme a parametriza��o do roteiro, ou seja, da data e hor�rio que ele se inicia
                            at� a data e hor�rio que ele termina.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Estes campos
                        podem ser editados pelo usu�rio.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">OK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � bot�o que selecionado confirmar� a importa��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Cancela</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � bot�o que selecionado sai do processo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os campos
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Sistema Exibidor�</span></b>
                        e <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Abertura da
                            Emissora�</span></b>, demonstrar�o respectivamente qual o<span style="mso-spacerun: yes">&nbsp;
                            </span>play list a emissora utiliza e qual o hor�rio est� parametrizado como
                        inicio da programa��o di�ria.<o:p></o:p></span></p>
                <p class="MsoBodyText2" style="margin: 0cm 0cm 0pt">
                    &nbsp;</p>
                <p class="MsoBodyText2" style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt">Ap�s a execu��o dos filtros o sistema habilitar� uma nova
                        tela com tr�s pastas:</span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'"></span></b>&nbsp;</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    &nbsp;</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Previsto e Exibido</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � demonstra todos os comerciais ordenados
                            no roteiro t�cnico e se encontram no log da playlist.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Previsto e N�o Exibido</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � demonstra todos os comerciais ordenados
                            no roteiro t�cnico mas que n�o se encontram no log da<span style="mso-spacerun: yes">&nbsp;
                            </span>playlist.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">N�o Previsto e Exibido</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � demonstra todos os comerciais que se
                            encontram no log do playlist, por�m, n�o foram ordenados no roteiro t�cnico.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observa��es</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                 <span style="font-size: 7.5pt; color: #000000">Caso o playlist da emissora possua alguma
                     particularidade fora dos padr�es encontrados no mercado, ser� necess�rio contatar
                     o fornecedor do mesmo.</span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

