<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxUsuariosRoteiro.aspx.cs" Inherits="Help_Default" Title="Usuários do Roteiro" %>
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
             permite consultar quais usuários estão utilizando o Roteiro ou a Composição de Breaks.,
             permitindo ainda, a exclusão deste usuário, caso o mesmo esteja travando alguma
             operação.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
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
                        As opções
                        de filtros são:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Veículo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar o código do veículo a ser consultado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar o código do programa a ser
                            consultado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Somente Veículos do meu Perfil</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> – se estiver
                            selecionada, esta função demonstrará somente os veículos que pertençam ao perfil
                            do usuário.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os filtros
                        são de preenchimento opcional.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">No campo <b
                        style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Operação”</span></b>
                        permite que possamos escolher o que desejamos visualizar, se usuários utilizando
                        a <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Ordenação”</span></b>
                        a <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Composição de
                            Breaks”</span></b> ou <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                                “Ambos”</span>.</b><o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                Para excluir
                        o usuário, devemos selecioná-lo e clicar no botão correspondente <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">“Excluir o Usuário”</span>.</b><o:p></o:p></span></p>
                <h2 style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt">Fitas</span></h2>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observações</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="color: #000000">
                     <span style="font-size: 7.5pt">A opção de excluir usuários serve para os casos de mais
                         de um usuário interagir com o roteiro.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

