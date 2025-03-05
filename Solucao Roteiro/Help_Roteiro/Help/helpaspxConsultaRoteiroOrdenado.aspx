<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxConsultaRoteiroOrdenado.aspx.cs" Inherits="Help_Default" Title="Consulta do Roteiro Ordenado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Esta rotina
             permite que possamos consultar um roteiro j� ordenado e visualizarmos os poss�veis
             cortes ocorridos.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                 prefix="o" ?><o:p></o:p></span></p>
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
                Para processarmos
                        uma consulta devemos preencher os seguintes campos:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar o c�digo do ve�culo do roteiro
                            a ser pesquisado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar a data de roteiro a ser consultada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Exibir</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � clicar neste bot�o para confirmar o
                            filtro selecionado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                        O sistema mostrar� no grid as seguintes informa��es:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                    </span></b>&nbsp;</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    &nbsp;</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do programa com veicula��es roteirizadas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">BRK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � numero do break.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Encaixe</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � total de comerciais encaixados no break
                            (em minuto � e segundos �).<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Fita</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � numero da fita comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Com</span>.</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � legenda (c�digo) do comercial quando
                            o mesmo vier de mapa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">T�tulo do Comercial</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � t�tulo do comercial cadastrado pelo
                            usu�rio no mapa reserva ou nos deposit�rios Avulso e Art�stico.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Produto</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � nome do produto cadastrado junto com
                            o t�tulo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Dur</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'">. � dura��o do comercial em segundos.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Tipo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do Tipo de Comercial da veicula��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Empresa / Contrato e Seq</span>. � </span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">dados do contrato.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Origem</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do programa de origem do comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Break</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � identifica��o do break comercial.<b style="mso-bidi-font-weight: normal"><o:p></o:p></b></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Chave de Acesso</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo de controle interno do SCTV.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Hor. de Exibi��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> �<span style="mso-spacerun: yes">&nbsp; </span>
                            demonstrar� os hor�rios informados para a veicula��o pelo checking.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo Origem</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do ve�culo de origem da veicula��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Roteiros Encerrados</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � permite visualizar data e ve�culos com
                            roteiros j� encerrados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Usu�rios do Roteiro</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � permite visualizar usu�rios que estejam
                            acessando as rotinas de<span style="mso-spacerun: yes">&nbsp; </span>Roteiro T�cnico
                            ou de Composi��o de Breaks.<o:p></o:p></span></p>
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
                     <span style="font-size: 7.5pt">Caso um comercial tenha sido cortado ap�s o encerramento
                         do Roteiro, o mesmo aparecer� nesta tela com uma �tesoura� indicando este corte.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

