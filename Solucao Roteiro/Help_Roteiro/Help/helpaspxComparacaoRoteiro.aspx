<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxComparacaoRoteiro.aspx.cs" Inherits="Help_Default" Title="Comparação do Roteiro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Definição</td>
        </tr>
        <tr>
 <td class="td" >
     <span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman'; mso-bidi-font-family: 'Times New Roman';
         mso-ansi-language: PT-BR; mso-fareast-language: PT-BR; mso-bidi-language: AR-SA">
         Esta rotina permite aos usuários que possuam mais de um veículo, comparar os roteiros
         destes veículos, checando desta forma, a sincronia entre estes roteiros, bem como,
         a ocupação dos espaços.</span>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Operação</td>
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
                            mso-bidi-font-family: 'Times New Roman'"> – informar a data a ser consultada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Veículos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – selecionar os veículos a serem comparados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – campo opcional para o caso de uma consulta
                            mais específica.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">OK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – clicar para processar a consulta.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Cancela</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – selecionar este botão para abortar a
                            consulta.<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Após o filtro confirmado, o sistema mostrará em grids distintos o roteiro técnico
                    de cada veículo com as seguintes informações:</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código e nome do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Break</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – numero do break para o programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Abrangência</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – Artística, Net e Local.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Comercial</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – descrição do título e produto da veiculação.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Duração</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – duração em segundos dos breaks por abrangência
                            e a duração do comercial cadastrado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Enc</span>.</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – soma da duração total encaixada por
                            break e identificação da origem do comercial.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observações</td>
        </tr>
     <tr>
         <td class="titulos" style="height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="color: #000000">
                     <span style="font-size: 7.5pt">O usuário poderá rolar cada grid individualmente ou ambos
                         utilizando-se das setas existentes no centro do formulário.<o:p></o:p></span></span></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 7.5pt">
                     <span style="color: #000000">Existe ainda um ícone em forma de </span><b style="mso-bidi-font-weight: normal">
                         <span style="font-size: 8pt; color: #000000">“Prancheta”</span></b><span style="color: #000000">
                             que ao ser selecionado, demonstra a </span><b style="mso-bidi-font-weight: normal"><span
                                 style="font-size: 8pt; color: #000000">“Consistência dos tempos alocados”</span></b><span
                                     style="color: #000000">, para cada veículo.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

