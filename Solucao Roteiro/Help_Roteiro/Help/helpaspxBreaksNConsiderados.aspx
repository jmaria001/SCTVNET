<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxBreaksNConsiderados.aspx.cs" Inherits="Help_Default" Title="Breaks Não Considerados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Definição</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
         Esta função permite que um usuário de filiada ou afiliada exclua de forma total
         ou parcial os breaks de um programa da Cabeça de Rede que não é exibido em sua emissora.</p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Operação</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt">
                    Para processarmos esta operação devemos proceder da seguinte forma:</span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Veículo</span></b>
                    – informar o código do veículo do usuário.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Data</span></b>
                    – informar a data base para pegar os dados do programa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Programa</span></b>
                    – informar o código do programa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Exibir</span></b>
                    – clicar neste botão para o sistema exibir os dados referentes ao filtro feito.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Após aparecer o resultado do filtro, o usuário deverá selecionar os breaks que deseja
                    excluir, informar o período e os dias da semana válidos para esta exclusão.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Caso a emissora em questão possua um outro veículo como corte de sinal, e deseja-se
                    também, excluir seus breaks, o usuário deverá selecionar o botão <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">“Replicar”</span></b>, que o sistema abrirá uma janela com os códigos de veículos válidos para a empresa do usuário.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Para confirmar o processo deve-se clicar em <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">“OK”</span></b> e para sair ou abortar o processo,
                    deve-se clicar em <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                        “Cancela”</span></b>.</p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observações</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="color: #000000">
                     <span style="font-size: 7.5pt">Para desconsiderar os breaks de um programa é necessário
                         que o mesmo não tenha nenhum comercial já roteirizado. Caso tenha, o usuário deverá
                         excluir este comercial do roteiro antes de utilizar esta função.<?xml namespace=""
                             ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><?xml namespace="" prefix="o" ?><o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

