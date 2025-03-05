<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxListaDiariaChecking.aspx.cs" Inherits="Help_Default" Title="Listagem Diária de Checking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Definição</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
         <span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman'; mso-bidi-font-family: 'Times New Roman';
             mso-ansi-language: PT-BR; mso-fareast-language: PT-BR; mso-bidi-language: AR-SA">
         Esta rotina permite ao usuário listar um relatório com<span style="mso-spacerun: yes">&nbsp;
             </span>todos os comerciais cadastrados para uma data veículo.</span></p>
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
                Para processarmos esta consulta devemos preencher
                    os seguintes campos:<?xml namespace=""
                            ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Veículo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar o código do veiculo a ser consultado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar o código do programa a ser
                            consultado para o caso de consulta específica, caso nada seja informado neste campo,
                            o sistema mostrará todos
                            <o:p></o:p>
                        </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">os programas
                        para o veículo/data informados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Qualidade</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – esta opção permite ao usuário listar
                            somente as veiculações que possuam a qualidade indicada neste campo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar a data a ser consultada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Situação das Veiculações</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> – permite que
                            se liste somente as veiculações que possuam falhas, sem falhas ou ambas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Situação do Roteiro</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – permite que se liste somente as veiculações<span
                                style="mso-spacerun: yes">&nbsp; </span>que foram ordenadas no roteiro, as que
                            não foram ordenadas e ambas.<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-fareast-font-family: 'Times New Roman'; mso-bidi-font-family: 'Times New Roman';
                        mso-ansi-language: PT-BR; mso-fareast-language: PT-BR; mso-bidi-language: AR-SA">
                        Não imprimir veiculações canceladas</span></b><span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                            mso-bidi-font-family: 'Times New Roman'; mso-ansi-language: PT-BR; mso-fareast-language: PT-BR;
                            mso-bidi-language: AR-SA"> – com esta opção selecionada, o sistema não listará as
                            veiculações que possuam qualidade que <b style="mso-bidi-font-weight: normal">não indique
                                demanda</b>.</span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observações</td>
        </tr>
     <tr>
         <td class="td" style="font-size: 7.5pt; height: 14px;">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">O resultado
                     da consulta poderá ser impresso ou apenas visualizado em tela e mostrará os seguintes
                     dados.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                     <span style="font-size: 8pt">Progr</span>.</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – código do programa.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Título do Comercial</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – descrição do título do comercial para exibição.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Duração</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – tempo do comercial em segundos.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Tipo</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – código do tipo de comercial.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Produto</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – descrição do produto do comercial para exibição.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Contrato</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – dados do contrato ao qual pertence o comercial.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                     <span style="font-size: 8pt">CH</span>. <span style="font-size: 8pt">AC</span></span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – chave de acesso que é um identificador interno do sistema.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                     <span style="font-size: 8pt">BR</span>.</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – número do break que o comercial foi ordenado.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Pos</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – posição que o comercial ocupa dentro do break.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Qual</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – caso o comercial possua uma qualidade, neste campo mostrará o código desta qualidade.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                     <span style="font-size: 8pt">Hor</span>.</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – se a qualidade indica horário, aqui aparecerá o horário que o comercial foi exibido.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Doc DE</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – se a veiculação tem sua origem em uma AM ou CS, aqui será demonstrado o numero
                         de documento ao qual pertence.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Doc PARA</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – se a veiculação possui uma qualidade que indique AM ou CS, aqui será mostrado
                         o numero e a descrição deste do documento desta qualidade.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Roteiro</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         – mostrará o código do programa onde a veiculação foi ordenada dentro do Roteiro
                         Técnico.<o:p></o:p></span></p>
             <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                 No rodapé do relatório estará descriminado o filtro utilizado pelo usuário.</p>
         </td>
     </tr>

        <tr>
        </tr>
 </table>
</asp:Content>

