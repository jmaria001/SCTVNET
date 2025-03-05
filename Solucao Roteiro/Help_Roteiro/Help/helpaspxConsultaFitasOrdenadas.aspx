<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxConsultaFitasOrdenadas.aspx.cs" Inherits="Help_Default" Title="Consulta de Fitas Ordenadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="width: 668px" >
     <span style="font-size: 12pt; font-family: Arial; mso-fareast-font-family: 'Times New Roman';
         mso-bidi-font-family: 'Times New Roman'; mso-ansi-language: PT-BR; mso-fareast-language: PT-BR;
         mso-bidi-language: AR-SA"><span style="font-size: 7.5pt">Esta rotina permite consultar
             em quais datas, programas, breaks uma fita foi roteirizada.</span> </span>
</td>
        </tr>
    <tr>
            <td class="titulos" style="width: 668px">
                Opera��o</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt; width: 668px;">
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                        Os filtros a serem preenchidos s�o:<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                            prefix="o" ?><o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do ve�culo que se deseja consultar.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar o c�digo do programa para o
                            caso de consultas mais espec�ficas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Per�odo De At�</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar o per�odo a ser consultado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Numero de Fita De At�</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar um intervalo de fitas para
                            a consulta. Caso deseja-se consultar apenas uma fita, deve-se informar o numero
                            desta nos dois campos.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Empresa / Contrato / Seq��ncia</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> � para o caso
                            de consultar fitas de um contrato espec�fico, informar aqui os dados deste contrato.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">OK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � bot�o para confirmar a consulta.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Sair</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � bot�o para sair da consulta.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Ap�s o filtro
                        feito, o sistema demonstrar� em uma nova tela as seguintes informa��es;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">N. Fita</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � numero da fita encontrada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do ve�culo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � data de exibi��o da fita.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do programa em que a fita foi
                            exibida.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Comercial</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � t�tulo do comercial vinculado � fita.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Dura��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> �<span style="mso-spacerun: yes">&nbsp; </span>
                            tempo do comercial em segundos.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Break</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � break em que foi exibida a fita.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Posi��</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">o</span> �
                            posi��o dentro do break em que foi exibida a fita.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Tipo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � abrang�ncia do comercial, se Local ou Net.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Emp</span>.</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo da empresa de venda do contrato.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Contrato</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � numero do contrato.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Seq</span>.</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � seq��ncia do contrato.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Cliente</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo e raz�o social do cliente da
                            fita selecionada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ag�ncia</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo e raz�o social da agencia da
                            fita selecionada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Totais Net / Local</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � totalizador de onde a fita foi roteirizada
                            por abrang�ncia.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px; width: 668px;">
                Observa��es</td>
        </tr>
     <tr>
         <td class="td" style="width: 668px; height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="color: #000000">
                     <span style="font-size: 7.5pt">Como um numero de fita pode ser utilizado v�rias vezes
                         para comerciais diferentes em per�odos diferentes, � necess�rio informar corretamente
                         o per�odo a ser consultado.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

