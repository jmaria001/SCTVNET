<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxHorarioRealProgramacao.aspx.cs" Inherits="Help_Default" Title="Horário Real da Programação" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Definição</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Esta rotina
             permite ao usuário informar o horário real em que a programação iniciou e terminou
             em uma determinada data, fazendo com que desta forma, a função de importar os horários
             do Play List para o sistema seja mais precisa o possível.
             <?xml namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
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
                Para processarmos
                        esta rotina devemos preencher os seguintes campos:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Veículo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código do veículo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data de Exibição</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – data<span style="mso-spacerun: yes">&nbsp;
                            </span>de exibição das veiculações.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Exibir</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – clicar neste botão para o sistema processar
                            o filtro.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Após a confirmação
                        o sistema mostrará no grid abaixo as seguintes informações;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Código</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Título</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – descrição do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Inicio Previsto</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – horário de inicio do programa cadastrado
                            na grade comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Final Previsto</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – horário de término do programa cadastrado
                            na grade comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Inicio Real</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – campo para o usuário informar o<span
                                style="mso-spacerun: yes">&nbsp; </span>horário que realmente o programa teve
                            sua exibição iniciada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Final Real</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt"> </span>–
                            campo para o usuário informar o horário que realmente o programa teve sua exibição
                            encerrada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">O usuário
                        pode acertar cada programa individualmente ou todos a partir da primeira alteração,
                        selecionando o item <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            “Ajustar Horário dos Programas Subseqüêntes”</span>.</b><o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Replicar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – para o caso do usuário possuir mais
                            de um veículo, sendo o segundo um corte de sinal, ele utilizará este botão para
                            replicar<span style="mso-spacerun: yes">&nbsp; </span>o procedimento para o outro
                            veículo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Gravar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – selecionar este botão para confirmar
                            as alterações.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Sair</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – selecionar este botão para abortar o
                            processo ou para sair após completá-lo.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observações</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 7.5pt">
                     <span style="color: #000000">É importante que esta função seja processada </span>
                     <span style="font-size: 8pt"><b style="mso-bidi-font-weight: normal"><span style="color: #000000">
                         antes do</span></b><span style="color: #000000"> </span><b style="mso-bidi-font-weight: normal">
                             <span style="color: #000000">checking ou do usuário responsável fazer a importação dos
                                 dados do play list para o SCTV</span></b></span><span style="color: #000000">.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

