<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxPreOrdenacao.aspx.cs" Inherits="Help_Default" Title="Pré_Ordenação" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Definição</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Esta função
             permite que o sistema confeccione automaticamente a ordenação do roteiro, cabendo
             ao usuário apenas “afinar” esta ordenação, preenchendo os breaks que não foram totalmente
             ocupados ou posicionando melhor determinados comerciais.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
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
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                Para efetuar
                        a pré ordenação o usuário deverá escolher a data e o veículo a ser processado, podendo
                        ordenar todo o roteiro ou um programa específico, pré ordenar ou não os rotativos
                        e as vinhetas de abertura <span style="font-size: 8pt">(<b style="mso-bidi-font-weight: normal">VA</b>)</span>
                        e de encerramento <span style="font-size: 8pt">(<b style="mso-bidi-font-weight: normal">VE</b>)</span>.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">A pré ordenação
                        quando processada, irá sobrepor qualquer ordenação feita anteriormente pelo usuário
                        para o veículo/data/programa selecionados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        &nbsp;<o:p></o:p></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Regra para pré-ordenacão dos comerciais<o:p></o:p></span></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Os comercias são distribuídos no roteiro em seus respectivos programas , alternando-se
                    os breaks até que complete seus<span style="mso-spacerun: yes">&nbsp; </span>espaços,
                    sem nunca estoura-los.</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Comerciais
                        concorrentes não são alocados no mesmo breaks e no caso de haver mais comerciais
                        concorrentes do que breaks disponíveis, são mantidos desordenados e devem ser encaixados
                        manualmente.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os comerciais
                        rotativos são alocados aleatoriamente em qualquer programa que tenha pelo menos
                        um segundo coincidente com o horário do rotativo na grade da programação.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">As vinhetas
                        de abertura são sempre alocadas nas primeira posições do Inter-Programa.
                        <o:p></o:p>
                    </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">As vinhetas
                        de encerramento são alocadas na primeira posição do programa subsequente. Caso o
                        programa seja o ultimo da grade diária, é alocado na ultima posição do ultimo break.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os comerciais
                        são pre-ordenados obedecendo a seguinte prioridade.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">1: Peso da veiculação obtida na política de encaixe:<o:p></o:p></span></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Nos veículos
                        que não adotam esta política, este valor será zero em todas, não tendo nenhum efeito
                        na prioridade<span style="mso-spacerun: yes">&nbsp; </span>da ordenação.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">
                        <b style="mso-bidi-font-weight: normal">2: Break Informado<o:p></o:p></b></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Todos os comercias
                        que foram digitados pela<span style="mso-spacerun: yes">&nbsp; </span><span style="mso-spacerun: yes">
                            &nbsp;</span>digitação 2 ou digitação 3 no formulário de mapa reserva e<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">foi informado
                        o numero do break.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">3: Posição Informada<o:p></o:p></span></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Todos os comercias
                        que foram digitados pela<span style="mso-spacerun: yes"> &nbsp; </span>digitação
                        2 ou digitação 3 no formulário de mapa reserva e,foi importado posição fixa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">4: Comerciais que geram receita
                            <o:p></o:p>
                        </span></span></b>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">5: Não Rotativo
                            <o:p></o:p>
                        </span></span></b>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">6: Compensações<o:p></o:p></span></span></b></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-size: 8pt"><b style="mso-bidi-font-weight: normal"><span style="font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">7: Forma de Pagamento</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'">(Prioridade para espécie sobre permuta)<b
                                style="mso-bidi-font-weight: normal"><o:p></o:p></b></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">9: Ordem de Chegada<o:p></o:p></span></span></b></p>
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
                     <span style="font-size: 7.5pt">Os comerciais avulsos e as vinhetas artísticas não serão
                         pré ordenadas, ficando a cargo do usuário a ordenação das mesmas.<o:p></o:p></span></span></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 7.5pt">
                     <span style="color: #000000">Os ajustes necessários para “afinar” a ordenação deverão
                         ser feitos na função específica de </span><span style="color: #000000"><b style="mso-bidi-font-weight: normal">
                             <span style="font-size: 8pt">“Ordenação”</span>.</b><o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

