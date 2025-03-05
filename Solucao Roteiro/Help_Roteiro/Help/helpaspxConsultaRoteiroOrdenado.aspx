<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxConsultaRoteiroOrdenado.aspx.cs" Inherits="Help_Default" Title="Consulta do Roteiro Ordenado" %>
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
             permite que possamos consultar um roteiro já ordenado e visualizarmos os possíveis
             cortes ocorridos.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                 prefix="o" ?><o:p></o:p></span></p>
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
                        uma consulta devemos preencher os seguintes campos:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Veículo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar o código do veículo do roteiro
                            a ser pesquisado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar a data de roteiro a ser consultada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Exibir</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – clicar neste botão para confirmar o
                            filtro selecionado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                        O sistema mostrará no grid as seguintes informações:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                    </span></b>&nbsp;</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    &nbsp;</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código do programa com veiculações roteirizadas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">BRK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – numero do break.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Encaixe</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – total de comerciais encaixados no break
                            (em minuto ‘ e segundos “).<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Fita</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – numero da fita comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Com</span>.</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – legenda (código) do comercial quando
                            o mesmo vier de mapa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Título do Comercial</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – título do comercial cadastrado pelo
                            usuário no mapa reserva ou nos depositórios Avulso e Artístico.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Produto</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – nome do produto cadastrado junto com
                            o título.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Dur</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'">. – duração do comercial em segundos.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Tipo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código do Tipo de Comercial da veiculação.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Empresa / Contrato e Seq</span>. – </span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">dados do contrato.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Origem</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código do programa de origem do comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Break</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – identificação do break comercial.<b style="mso-bidi-font-weight: normal"><o:p></o:p></b></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Chave de Acesso</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código de controle interno do SCTV.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Hor. de Exibição</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> –<span style="mso-spacerun: yes">&nbsp; </span>
                            demonstrará os horários informados para a veiculação pelo checking.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Veículo Origem</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – código do veículo de origem da veiculação.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Roteiros Encerrados</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – permite visualizar data e veículos com
                            roteiros já encerrados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Usuários do Roteiro</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – permite visualizar usuários que estejam
                            acessando as rotinas de<span style="mso-spacerun: yes">&nbsp; </span>Roteiro Técnico
                            ou de Composição de Breaks.<o:p></o:p></span></p>
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
                     <span style="font-size: 7.5pt">Caso um comercial tenha sido cortado após o encerramento
                         do Roteiro, o mesmo aparecerá nesta tela com uma “tesoura” indicando este corte.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

