<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxListaDiariaChecking.aspx.cs" Inherits="Help_Default" Title="Listagem Di�ria de Checking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
         <span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman'; mso-bidi-font-family: 'Times New Roman';
             mso-ansi-language: PT-BR; mso-fareast-language: PT-BR; mso-bidi-language: AR-SA">
         Esta rotina permite ao usu�rio listar um relat�rio com<span style="mso-spacerun: yes">&nbsp;
             </span>todos os comerciais cadastrados para uma data ve�culo.</span></p>
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
                Para processarmos esta consulta devemos preencher
                    os seguintes campos:<?xml namespace=""
                            ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar o c�digo do veiculo a ser consultado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar o c�digo do programa a ser
                            consultado para o caso de consulta espec�fica, caso nada seja informado neste campo,
                            o sistema mostrar� todos
                            <o:p></o:p>
                        </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">os programas
                        para o ve�culo/data informados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Qualidade</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � esta op��o permite ao usu�rio listar
                            somente as veicula��es que possuam a qualidade indicada neste campo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar a data a ser consultada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Situa��o das Veicula��es</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> � permite que
                            se liste somente as veicula��es que possuam falhas, sem falhas ou ambas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Situa��o do Roteiro</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � permite que se liste somente as veicula��es<span
                                style="mso-spacerun: yes">&nbsp; </span>que foram ordenadas no roteiro, as que
                            n�o foram ordenadas e ambas.<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-fareast-font-family: 'Times New Roman'; mso-bidi-font-family: 'Times New Roman';
                        mso-ansi-language: PT-BR; mso-fareast-language: PT-BR; mso-bidi-language: AR-SA">
                        N�o imprimir veicula��es canceladas</span></b><span style="font-family: Arial; mso-fareast-font-family: 'Times New Roman';
                            mso-bidi-font-family: 'Times New Roman'; mso-ansi-language: PT-BR; mso-fareast-language: PT-BR;
                            mso-bidi-language: AR-SA"> � com esta op��o selecionada, o sistema n�o listar� as
                            veicula��es que possuam qualidade que <b style="mso-bidi-font-weight: normal">n�o indique
                                demanda</b>.</span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observa��es</td>
        </tr>
     <tr>
         <td class="td" style="font-size: 7.5pt; height: 14px;">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">O resultado
                     da consulta poder� ser impresso ou apenas visualizado em tela e mostrar� os seguintes
                     dados.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                     <span style="font-size: 8pt">Progr</span>.</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � c�digo do programa.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     T�tulo do Comercial</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � descri��o do t�tulo do comercial para exibi��o.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Dura��o</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � tempo do comercial em segundos.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Tipo</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � c�digo do tipo de comercial.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Produto</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � descri��o do produto do comercial para exibi��o.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Contrato</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � dados do contrato ao qual pertence o comercial.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                     <span style="font-size: 8pt">CH</span>. <span style="font-size: 8pt">AC</span></span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � chave de acesso que � um identificador interno do sistema.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                     <span style="font-size: 8pt">BR</span>.</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � n�mero do break que o comercial foi ordenado.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Pos</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � posi��o que o comercial ocupa dentro do break.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Qual</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � caso o comercial possua uma qualidade, neste campo mostrar� o c�digo desta qualidade.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                     <span style="font-size: 8pt">Hor</span>.</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � se a qualidade indica hor�rio, aqui aparecer� o hor�rio que o comercial foi exibido.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Doc DE</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � se a veicula��o tem sua origem em uma AM ou CS, aqui ser� demonstrado o numero
                         de documento ao qual pertence.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Doc PARA</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � se a veicula��o possui uma qualidade que indique AM ou CS, aqui ser� mostrado
                         o numero e a descri��o deste do documento desta qualidade.<o:p></o:p></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'; font-size: 8pt;">
                     Roteiro</span></b><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                         � mostrar� o c�digo do programa onde a veicula��o foi ordenada dentro do Roteiro
                         T�cnico.<o:p></o:p></span></p>
             <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                 No rodap� do relat�rio estar� descriminado o filtro utilizado pelo usu�rio.</p>
         </td>
     </tr>

        <tr>
        </tr>
 </table>
</asp:Content>

