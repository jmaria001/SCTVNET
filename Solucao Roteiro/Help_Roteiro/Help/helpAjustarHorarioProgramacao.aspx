<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpAjustarHorarioProgramacao.aspx.cs" Inherits="Help_Default" Title="Ajustar Hor�rios da Programa��o" %>
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
         Esta rotina permite ao usu�rio de afiliada que possua diferen�a de fuso hor�rio
         com a cabe�a de rede, ajustar o hor�rio da programa��o para sua hora local.</span></td>
        </tr>
    <tr>
            <td class="titulos">
                Opera��o</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                        Para efetuar
                        este processo � necess�rio preencher os seguintes campos:</span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                    </span></span>
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do ve�culo do usu�rio.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data de Exibi��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar uma data base para inicio da
                            altera��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Exibir</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � clicar neste bot�o para exibir os dados
                            do filtro selecionado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Ap�s o filtro
                        executado, o sistema demonstrar� no grid abaixo as seguintes informa��es;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">C�digo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do programa cadastrado na grade
                            comercial para a data informada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">T�tulo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � descri��o do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Hor�rio Inicio</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � hor�rio de inicio do programa registrado
                            na grade comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Hor�rio Fim</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � hor�rio de t�rmino do programa registrado
                            na grade comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para alterar
                        o hor�rio do programa, o usu�rio dever� selecion�-lo e clicar no bot�o <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">�Alterar Hor�rio�</span></b>, que o sistema abrir�
                        uma nova janela, onde o usu�rio dever� informar o novo hor�rio de <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">�Inicio e Fim�</span></b> da programa��o, informar
                        o per�odo a ser propagado e em quais dias da semana. Para o caso do usu�rio possuir
                        mais de um ve�culo, sendo o segundo um corte de sinal, o mesmo poder� utilizar o
                        bot�o <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Replicar�</span></b>
                        para selecionar este seu segundo ve�culo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">OK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � para confirmar a altera��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Cancela</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � para sair e abortar o processo.<o:p></o:p></span></p>
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
                     <span style="font-size: 7.5pt">Este ajuste � importante para que o sistema receba e
                         interprete corretamente o retorno do log da Playlist.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

