<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxReplicacaoRoteiro.aspx.cs" Inherits="Help_Default" Title="Replica��o do Roteiro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Atrav�s da
             rotina de <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Par�metros
                 do Roteiro</span></b> definimos quando e como o roteiro deve ser replicado de
             um ve�culo para outro. Por�m, ap�s a primeira replica��o, o sistema n�o mais replicar�
             automaticamente os dados de roteiro, evitando, desta forma, que se descaracterize
             totalmente os poss�veis acertos feitos para o ve�culo que recebe tal replica��o.
             <?xml namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?>
             <?xml namespace="" prefix="o" ?>
             <o:p></o:p></span></p>
</td>
        </tr>
    <tr>
            <td class="titulos" style="height: 22px">
                Opera��o</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Caso o usu�rio
                        venha a desejar uma nova replica��o do ve�culo origem para o destino, ser� necess�rio
                        tratar nesta fun��o, procedendo da seguinte forma.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo origem</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar o c�digo do ve�culo que ter�
                            seus dados de roteiro replicados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo Destino</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar o c�digo do ve�culo que receber�
                            estes dados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data de Exibi��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar a data que se quer replicar.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Exibir Programas</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � clicar neste bot�o para visualizar todos
                            os programas que possuem dados a serem replicados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Marcar Todos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � bot�o para selecionar todos os programas
                            do grid.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Desmarcar Todos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � bot�o para cancelar a sele��o feita.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">OK</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � bot�o para confirmar a replica��o, deve
                            ser selecionado ap�s o usu�rio marcar os programas que deseja replicar.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Cancela</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � bot�o para sair do processo ap�s sua
                            confirma��o ou para abortar o mesmo.<o:p></o:p></span></p>
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
                     <span style="font-size: 7.5pt">Ap�s a replica��o dos dados do Roteiro, o usu�rio pode,
                         se desejar, alterar manualmente o Roteiro destino, bastando para isso, utilizar
                         a fun��o de <span style="font-size: 8pt">�Ordena��o�</span>.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

