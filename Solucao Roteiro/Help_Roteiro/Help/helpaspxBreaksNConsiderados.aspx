<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxBreaksNConsiderados.aspx.cs" Inherits="Help_Default" Title="Breaks N�o Considerados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
         Esta fun��o permite que um usu�rio de filiada ou afiliada exclua de forma total
         ou parcial os breaks de um programa da Cabe�a de Rede que n�o � exibido em sua emissora.</p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Opera��o</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt">
                    Para processarmos esta opera��o devemos proceder da seguinte forma:</span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Ve�culo</span></b>
                    � informar o c�digo do ve�culo do usu�rio.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Data</span></b>
                    � informar a data base para pegar os dados do programa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Programa</span></b>
                    � informar o c�digo do programa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Exibir</span></b>
                    � clicar neste bot�o para o sistema exibir os dados referentes ao filtro feito.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Ap�s aparecer o resultado do filtro, o usu�rio dever� selecionar os breaks que deseja
                    excluir, informar o per�odo e os dias da semana v�lidos para esta exclus�o.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Caso a emissora em quest�o possua um outro ve�culo como corte de sinal, e deseja-se
                    tamb�m, excluir seus breaks, o usu�rio dever� selecionar o bot�o <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">�Replicar�</span></b>, que o sistema abrir� uma janela com os c�digos de ve�culos v�lidos para a empresa do usu�rio.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Para confirmar o processo deve-se clicar em <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">�OK�</span></b> e para sair ou abortar o processo,
                    deve-se clicar em <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                        �Cancela�</span></b>.</p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observa��es</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="color: #000000">
                     <span style="font-size: 7.5pt">Para desconsiderar os breaks de um programa � necess�rio
                         que o mesmo n�o tenha nenhum comercial j� roteirizado. Caso tenha, o usu�rio dever�
                         excluir este comercial do roteiro antes de utilizar esta fun��o.<?xml namespace=""
                             ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><?xml namespace="" prefix="o" ?><o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

