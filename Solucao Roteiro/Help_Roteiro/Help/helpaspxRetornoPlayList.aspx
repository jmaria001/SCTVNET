<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxRetornoPlayList.aspx.cs" Inherits="Help_Default" Title="Retorno da Play List" %>
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
             permite que o SCTV importe o log gerado no software de exibição da emissora, bastando
             para isso, que haja um lay out pré definido desta integração de arquivos.<?xml namespace=""
                 ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
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
                            mso-bidi-font-family: 'Times New Roman'"> – informar o código do veículo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data de Exibição</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar a data do roteiro a ser integrado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Localização do Arquivo de Log da Exibição</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> – caminho (diretório)
                            onde o SCTV deverá buscar a integração.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Mostrar Fitas Avulsas</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – se este campo estiver selecionado o
                            sistema irá mostrar as fitas avulsas que estão roteirizadas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Mostrar Fitas Artísticas</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> – se este campo
                            estiver selecionado o sistema irá mostrar as filtas artísticas que estão roteirizadas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Considerar Log´s no período</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> – Data Inicio,
                            Data Fim, Hora Inicio e Hora Fim, estes campos virão preenchidos automaticamente
                            conforme a parametrização do roteiro, ou seja, da data e horário que ele se inicia
                            até a data e horário que ele termina.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Estes campos
                        podem ser editados pelo usuário.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">OK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – botão que selecionado confirmará a importação.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Cancela</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – botão que selecionado sai do processo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os campos
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Sistema Exibidor”</span></b>
                        e <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Abertura da
                            Emissora”</span></b>, demonstrarão respectivamente qual o<span style="mso-spacerun: yes">&nbsp;
                            </span>play list a emissora utiliza e qual o horário está parametrizado como
                        inicio da programação diária.<o:p></o:p></span></p>
                <p class="MsoBodyText2" style="margin: 0cm 0cm 0pt">
                    &nbsp;</p>
                <p class="MsoBodyText2" style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt">Após a execução dos filtros o sistema habilitará uma nova
                        tela com três pastas:</span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'"></span></b>&nbsp;</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    &nbsp;</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Previsto e Exibido</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – demonstra todos os comerciais ordenados
                            no roteiro técnico e se encontram no log da playlist.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Previsto e Não Exibido</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – demonstra todos os comerciais ordenados
                            no roteiro técnico mas que não se encontram no log da<span style="mso-spacerun: yes">&nbsp;
                            </span>playlist.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Não Previsto e Exibido</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – demonstra todos os comerciais que se
                            encontram no log do playlist, porém, não foram ordenados no roteiro técnico.<o:p></o:p></span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observações</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                 <span style="font-size: 7.5pt; color: #000000">Caso o playlist da emissora possua alguma
                     particularidade fora dos padrões encontrados no mercado, será necessário contatar
                     o fornecedor do mesmo.</span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

