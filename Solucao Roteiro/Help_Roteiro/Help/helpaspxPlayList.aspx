<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxPlayList.aspx.cs" Inherits="Help_Default" Title="Play List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Definição</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
         Esta rotina permite a configuração da integração entre o Roteiro Técnico no SCTV
         com o equipamento de exibição digital em uso pela emissora.</p>
     <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
         A parametrização deve ser feita uma única vez e, a partir desta, fazer as integrações
         diárias com o playlist da emissora.</p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Operação</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                Para procedermos a configuração da integração devemos clicar em <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">“Alterar Parâmetros”</span></b> e preenchermos
                    os seguintes campos:</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Sistema de Exibição
                        Digital</span></b> – informar dentro de uma lista dos mais usados, qual o exibidor
                    digital utilizado pela emissora. Caso a emissora utilize um diferente dos que estão
                    configurados, é necessário contatar a CARTV.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Diretório para
                        Integração</span></b> – informar qual o caminho (diretório) para gravar os dados
                    do roteiro.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Nome do arquivo
                        para integração</span></b> – campo opcional onde o usuário informará um nome
                    para o arquivo a ser integrado, caso não preencha com nada, o sistema criará um
                    arquivo com o nome composto pela sigla do veículo mais a data da programação.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Configuração do
                        N. de Fita</span></b> – o tamanho de fita padrão para o SCTV é de 6 caracteres,
                    porem, em algumas emissoras o padrão pode ser diferente. Este campo serve para indicar
                    o tamanho de fita a ser considerado na integração e em qual posição o sistema deverá
                    considerar para compor o numero.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Após a configuração, o usuário para proceder a integração deverá;</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Data da Programação</span></b>
                    – informar a data de roteiro a ser integrada com o playlist.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Período</span></b>
                    – campo para informar qual o período da programação que o usuário está integrando,
                    facilitando assim, as informações com o Master.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Começar e Terminar
                        no Programa</span></b> – estes campos devem ser preenchidos quando o usuário
                    desejar integrar o roteiro parcialmente.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Gerar Arquivos</span></b>
                    – clicar neste botão para a geração do arquivo de integração.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Sair</span></b>
                    – botão para sair do processo.</p>
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

