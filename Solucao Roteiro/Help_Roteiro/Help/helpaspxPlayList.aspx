<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxPlayList.aspx.cs" Inherits="Help_Default" Title="Play List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
         Esta rotina permite a configura��o da integra��o entre o Roteiro T�cnico no SCTV
         com o equipamento de exibi��o digital em uso pela emissora.</p>
     <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
         A parametriza��o deve ser feita uma �nica vez e, a partir desta, fazer as integra��es
         di�rias com o playlist da emissora.</p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Opera��o</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                Para procedermos a configura��o da integra��o devemos clicar em <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">�Alterar Par�metros�</span></b> e preenchermos
                    os seguintes campos:</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Sistema de Exibi��o
                        Digital</span></b> � informar dentro de uma lista dos mais usados, qual o exibidor
                    digital utilizado pela emissora. Caso a emissora utilize um diferente dos que est�o
                    configurados, � necess�rio contatar a CARTV.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Diret�rio para
                        Integra��o</span></b> � informar qual o caminho (diret�rio) para gravar os dados
                    do roteiro.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Nome do arquivo
                        para integra��o</span></b> � campo opcional onde o usu�rio informar� um nome
                    para o arquivo a ser integrado, caso n�o preencha com nada, o sistema criar� um
                    arquivo com o nome composto pela sigla do ve�culo mais a data da programa��o.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Configura��o do
                        N. de Fita</span></b> � o tamanho de fita padr�o para o SCTV � de 6 caracteres,
                    porem, em algumas emissoras o padr�o pode ser diferente. Este campo serve para indicar
                    o tamanho de fita a ser considerado na integra��o e em qual posi��o o sistema dever�
                    considerar para compor o numero.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Ap�s a configura��o, o usu�rio para proceder a integra��o dever�;</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Data da Programa��o</span></b>
                    � informar a data de roteiro a ser integrada com o playlist.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Per�odo</span></b>
                    � campo para informar qual o per�odo da programa��o que o usu�rio est� integrando,
                    facilitando assim, as informa��es com o Master.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Come�ar e Terminar
                        no Programa</span></b> � estes campos devem ser preenchidos quando o usu�rio
                    desejar integrar o roteiro parcialmente.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Gerar Arquivos</span></b>
                    � clicar neste bot�o para a gera��o do arquivo de integra��o.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Sair</span></b>
                    � bot�o para sair do processo.</p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observa��es</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                 <span style="font-size: 7.5pt; color: #000000">Caso o playlist da emissora possua alguma
                     particularidade fora dos padr�es encontrados no mercado, ser� necess�rio contatar
                     o fornecedor do mesmo.</span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

