<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxComparacaoRoteiro.aspx.cs" Inherits="Help_Default" Title="Compara��o do Roteiro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" >
     <span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman'; mso-bidi-font-family: 'Times New Roman';
         mso-ansi-language: PT-BR; mso-fareast-language: PT-BR; mso-bidi-language: AR-SA">
         Esta rotina permite aos usu�rios que possuam mais de um ve�culo, comparar os roteiros
         destes ve�culos, checando desta forma, a sincronia entre estes roteiros, bem como,
         a ocupa��o dos espa�os.</span>
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
                Para utilizarmos
                        esta rotina devemos informar:<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                            prefix="o" ?><?xml namespace="" prefix="o" ?><o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar a data a ser consultada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � selecionar os ve�culos a serem comparados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � campo opcional para o caso de uma consulta
                            mais espec�fica.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">OK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � clicar para processar a consulta.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Cancela</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � selecionar este bot�o para abortar a
                            consulta.<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Ap�s o filtro confirmado, o sistema mostrar� em grids distintos o roteiro t�cnico
                    de cada ve�culo com as seguintes informa��es:</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo e nome do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Break</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � numero do break para o programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Abrang�ncia</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � Art�stica, Net e Local.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Comercial</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � descri��o do t�tulo e produto da veicula��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Dura��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � dura��o em segundos dos breaks por abrang�ncia
                            e a dura��o do comercial cadastrado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Enc</span>.</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � soma da dura��o total encaixada por
                            break e identifica��o da origem do comercial.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observa��es</td>
        </tr>
     <tr>
         <td class="titulos" style="height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="color: #000000">
                     <span style="font-size: 7.5pt">O usu�rio poder� rolar cada grid individualmente ou ambos
                         utilizando-se das setas existentes no centro do formul�rio.<o:p></o:p></span></span></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 7.5pt">
                     <span style="color: #000000">Existe ainda um �cone em forma de </span><b style="mso-bidi-font-weight: normal">
                         <span style="font-size: 8pt; color: #000000">�Prancheta�</span></b><span style="color: #000000">
                             que ao ser selecionado, demonstra a </span><b style="mso-bidi-font-weight: normal"><span
                                 style="font-size: 8pt; color: #000000">�Consist�ncia dos tempos alocados�</span></b><span
                                     style="color: #000000">, para cada ve�culo.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

