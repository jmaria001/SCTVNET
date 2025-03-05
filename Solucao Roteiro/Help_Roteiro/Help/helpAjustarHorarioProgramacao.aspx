<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpAjustarHorarioProgramacao.aspx.cs" Inherits="Help_Default" Title="Ajustar Horários da Programação" %>
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
         Esta rotina permite ao usuário de afiliada que possua diferença de fuso horário
         com a cabeça de rede, ajustar o horário da programação para sua hora local.</span></td>
        </tr>
    <tr>
            <td class="titulos">
                Operação</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                        Para efetuar
                        este processo é necessário preencher os seguintes campos:</span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                    </span></span>
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Veículo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código do veículo do usuário.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data de Exibição</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar uma data base para inicio da
                            alteração.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Exibir</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – clicar neste botão para exibir os dados
                            do filtro selecionado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Após o filtro
                        executado, o sistema demonstrará no grid abaixo as seguintes informações;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Código</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código do programa cadastrado na grade
                            comercial para a data informada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Título</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – descrição do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Horário Inicio</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – horário de inicio do programa registrado
                            na grade comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Horário Fim</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – horário de término do programa registrado
                            na grade comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para alterar
                        o horário do programa, o usuário deverá selecioná-lo e clicar no botão <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">“Alterar Horário”</span></b>, que o sistema abrirá
                        uma nova janela, onde o usuário deverá informar o novo horário de <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">“Inicio e Fim”</span></b> da programação, informar
                        o período a ser propagado e em quais dias da semana. Para o caso do usuário possuir
                        mais de um veículo, sendo o segundo um corte de sinal, o mesmo poderá utilizar o
                        botão <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Replicar”</span></b>
                        para selecionar este seu segundo veículo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">OK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – para confirmar a alteração.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Cancela</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – para sair e abortar o processo.<o:p></o:p></span></p>
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
                     <span style="font-size: 7.5pt">Este ajuste é importante para que o sistema receba e
                         interprete corretamente o retorno do log da Playlist.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

