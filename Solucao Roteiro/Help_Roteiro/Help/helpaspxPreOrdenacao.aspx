<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxPreOrdenacao.aspx.cs" Inherits="Help_Default" Title="Pr�_Ordena��o" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Esta fun��o
             permite que o sistema confeccione automaticamente a ordena��o do roteiro, cabendo
             ao usu�rio apenas �afinar� esta ordena��o, preenchendo os breaks que n�o foram totalmente
             ocupados ou posicionando melhor determinados comerciais.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
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
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                Para efetuar
                        a pr� ordena��o o usu�rio dever� escolher a data e o ve�culo a ser processado, podendo
                        ordenar todo o roteiro ou um programa espec�fico, pr� ordenar ou n�o os rotativos
                        e as vinhetas de abertura <span style="font-size: 8pt">(<b style="mso-bidi-font-weight: normal">VA</b>)</span>
                        e de encerramento <span style="font-size: 8pt">(<b style="mso-bidi-font-weight: normal">VE</b>)</span>.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">A pr� ordena��o
                        quando processada, ir� sobrepor qualquer ordena��o feita anteriormente pelo usu�rio
                        para o ve�culo/data/programa selecionados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        &nbsp;<o:p></o:p></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Regra para pr�-ordenac�o dos comerciais<o:p></o:p></span></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Os comercias s�o distribu�dos no roteiro em seus respectivos programas , alternando-se
                    os breaks at� que complete seus<span style="mso-spacerun: yes">&nbsp; </span>espa�os,
                    sem nunca estoura-los.</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Comerciais
                        concorrentes n�o s�o alocados no mesmo breaks e no caso de haver mais comerciais
                        concorrentes do que breaks dispon�veis, s�o mantidos desordenados e devem ser encaixados
                        manualmente.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os comerciais
                        rotativos s�o alocados aleatoriamente em qualquer programa que tenha pelo menos
                        um segundo coincidente com o hor�rio do rotativo na grade da programa��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">As vinhetas
                        de abertura s�o sempre alocadas nas primeira posi��es do Inter-Programa.
                        <o:p></o:p>
                    </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">As vinhetas
                        de encerramento s�o alocadas na primeira posi��o do programa subsequente. Caso o
                        programa seja o ultimo da grade di�ria, � alocado na ultima posi��o do ultimo break.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os comerciais
                        s�o pre-ordenados obedecendo a seguinte prioridade.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">1: Peso da veicula��o obtida na pol�tica de encaixe:<o:p></o:p></span></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Nos ve�culos
                        que n�o adotam esta pol�tica, este valor ser� zero em todas, n�o tendo nenhum efeito
                        na prioridade<span style="mso-spacerun: yes">&nbsp; </span>da ordena��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                        <b style="mso-bidi-font-weight: normal">2: Break Informado<o:p></o:p></b></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Todos os comercias
                        que foram digitados pela<span style="mso-spacerun: yes">&nbsp; </span><span style="mso-spacerun: yes">
                            &nbsp;</span>digita��o 2 ou digita��o 3 no formul�rio de mapa reserva e<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">foi informado
                        o numero do break.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">3: Posi��o Informada<o:p></o:p></span></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Todos os comercias
                        que foram digitados pela<span style="mso-spacerun: yes"> &nbsp; </span>digita��o
                        2 ou digita��o 3 no formul�rio de mapa reserva e,foi importado posi��o fixa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">4: Comerciais que geram receita
                            <o:p></o:p>
                        </span></span></b>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">5: N�o Rotativo
                            <o:p></o:p>
                        </span></span></b>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">6: Compensa��es<o:p></o:p></span></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-size: 8pt"><b style="mso-bidi-font-weight: normal"><span style="font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">7: Forma de Pagamento</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'">(Prioridade para esp�cie sobre permuta)<b
                                style="mso-bidi-font-weight: normal"><o:p></o:p></b></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">9: Ordem de Chegada<o:p></o:p></span></span></b></p>
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
                     <span style="font-size: 7.5pt">Os comerciais avulsos e as vinhetas art�sticas n�o ser�o
                         pr� ordenadas, ficando a cargo do usu�rio a ordena��o das mesmas.<o:p></o:p></span></span></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 7.5pt">
                     <span style="color: #000000">Os ajustes necess�rios para �afinar� a ordena��o dever�o
                         ser feitos na fun��o espec�fica de </span><span style="color: #000000"><b style="mso-bidi-font-weight: normal">
                             <span style="font-size: 8pt">�Ordena��o�</span>.</b><o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

