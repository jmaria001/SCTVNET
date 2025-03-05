<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxComposicaoBreak.aspx.cs" Inherits="Help_Default" Title="Composição Break" %>
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
             permite a criação ou alteração dos breaks comerciais a serem demonstrados no Roteiro
             Técnico. Só é permitido a um usuário da Cabeça de Rede fazer a composição para os
             programas de Rede, cabendo ao usuário de uma Regional ou Afiliada, compor os breaks
             de seus programas locais.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
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
                        Para efetuarmos
                        a composição<span style="mso-spacerun: yes">&nbsp; </span>devemos preencher os seguintes
                        campos:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Veículo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar o código do veículo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar a data base do programa a ter
                            seus breaks compostos.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Programa</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar o código do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Executar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – clicar neste botão para trazer os dados
                            do filtro selecionado.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Na pasta programação
                        o sistema mostrará os dados do programa/data selecionado, para o usuário propagar
                        os dados para outras datas, ele deverá indicar os dias da semana que deseja alterar
                        e preencher corretamente o campo <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            “Propagar no Período”</span></b>.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para efetuarmos
                        a composição, devemos ir para a pasta específica e seguirmos os passos:<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Criar um novo Break</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – 1º ícone da barra de ferramentas, o
                            sistema abrirá uma janela com o numero do break, campo para informar a duração o<span
                                style="mso-spacerun: yes">&nbsp; </span>tipo de break. Os campos Título e Seqüência/Break
                            são de preenchimento opcional para os casos de programas que tenham muitos quadros
                            e os mesmos devam ser identificados no roteiro técnico.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para criar
                        um inter programa, é necessário gravar o numero do break como <b style="mso-bidi-font-weight: normal">
                            0 </b>(zero).<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Rodapé</span></b>
                    – para colocar alguma observação que deva sair no rodapé do break.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Cria uma faixa
                        dentro de um break</span></b> – para inserir as faixas Net e ou Local. Função
                    específica da Cabeça de Rede.</p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Altera</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt">r</span> –
                            permite alterar algum dado do<span style="mso-spacerun: yes">&nbsp; </span>break,
                            porém, o usuário deverá selecionar o tipo de break específico que deseja alterar.
                            É possível também inverter o posicionamento dos tipos de breaks, sem prejudicar
                            os comerciais já ordenados.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Excluir</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – permite a exclusão de um break total
                            ou de um intervalo deste break, bastando que o usuário selecione o que deseja excluir
                            e clique sobre o botão em forma de lixeira.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Rodapé do Inter Programa</span></b><span
                            style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"> – permite a
                            colocação de uma observação no rodapé do inter programa.
                            <o:p></o:p>
                        </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Gravar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – para confirmar todos os dados informados
                            e gravar o processo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Sair</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – para sair do processo após sua efetivação
                            ou abortá-lo antes de sua gravação.<o:p></o:p></span></p>
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
                     <span style="font-size: 7.5pt">Caso a emissora Cabeça de Rede exclua um ou mais breaks
                         de um programa, e estes breaks já possuam comerciais roteirizados, o sistema mostrará
                         uma mensagem de aviso quando o usuário de Filiada ou Afiliada entrar novamente na
                         função “Ordenação” da data alterada.<o:p></o:p></span></span></span></p>
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="color: #000000">
                     <span style="font-size: 7.5pt">Porém, por medida de segurança, a Cabeça de Rede deve
                         enviar um email de aviso para todas as Filiadas e Afiliadas.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

