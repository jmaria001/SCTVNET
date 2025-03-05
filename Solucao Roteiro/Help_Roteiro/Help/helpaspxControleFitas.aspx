<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxControleFitas.aspx.cs" Inherits="Help_Default" Title="Controle de Fitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Nesta rotina
             daremos manuten��o na numera��o de fitas originadas de m�dia ou avulsas. Podendo
             cadastrar, alterar, desativar estas fitas.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                 prefix="o" ?><o:p></o:p></span></p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Opera��o</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt">
                    Para consultarmos as fitas cadastradas ou os comerciais pendentes de numera��o devemos
                    utilizar o �cone em forma de um bin�culo na barra de ferramentas e preencher os
                    filtros que se deseja consultar dentre as seguintes op��es:</span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Ve�culo</span></b>
                    � informar o c�digo do ve�culo.
                </p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Programa</span></b>
                    � informar o c�digo do programa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">In�cio</span></b>
                    � informar a data de in�cio para a consulta.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Fim</span></b>
                    � informar a data de t�rmino para a consulta.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Numero de Fita
                        De e At�</span></b> � para informar um intervalo de fitas espec�ficas que se
                    deseja consultar.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Mostrar Pendentes
                        de Numera��o</span></b> � para visualizar somente os comerciais cadastrados
                    atrav�s da inclus�o do mapa reserva que ainda n�o possuem numero de fita.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Mostrar Numeradas</span></b>
                    � para visualizar os comerciais que j� possuam numero de fitas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Mostrar Fitas Avulsas</span></b>
                    � para visualizar as fitas cadastradas como avulsas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Mostrar Fitas Art�sticas</span></b>
                    � para visualizar as fitas cadastradas como art�sticas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Status</span></b>
                    � possibilita a visualiza��o das fitas <b style="mso-bidi-font-weight: normal"><span
                        style="font-size: 8pt">�Desativadas / Devolvidas�</span></b> , <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">�Ativas�</span></b> ou ambas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Empresa / Contrato
                        / Seq��ncia</span></b> � informar os dados do contrato da fita a ser consultada.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Legenda</span></b>
                    � informar a legenda (c�digo) do comercial cadastrado no mapa reserva.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Tipo de Comercial</span></b>
                    � informar o tipo de comercial da veicula��o.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Ag�ncia</span></b>
                    � informar o c�digo da ag�ncia.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Cliente</span></b>
                    � informar o c�digo ou a raz�o social do cliente.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Produto</span></b>
                    � informar o nome do produto cadastrado.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    � necess�rio salientar que apenas os campos <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">�In�cio e Fim�</span> </b>e uma das op��es entre
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Mostrar Pendentes
                        de Numera��o�</span>,</b> <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            �Mostrar Numeradas�</span>,</b> <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                                �Mostrar Fitas Avulsas�</span>,</b> <b style="mso-bidi-font-weight: normal"><span
                                    style="font-size: 8pt">�Mostrar Fitas Art�sticas�</span></b> <b style="mso-bidi-font-weight: normal">
                                        <span style="mso-spacerun: yes">&nbsp;</span></b>s�o de preenchimento
                    obrigat�rio, sendo os demais campos opcionais para consultas mais espec�ficas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <o:p></o:p>
                    &nbsp;</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Na barra de ferramentas
                        temos as seguintes op��es:<o:p></o:p></span></b></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal">&nbsp;<o:p></o:p></b></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt"><b style="mso-bidi-font-weight: normal">Adicionar Fitas
                        Avulsas</b> <b style="mso-bidi-font-weight: normal">ou Art�sticas.</b></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    permite ao usu�rio inserir uma fita avulsa ou art�stica para ser exibida no Roteiro
                    T�cnico, tendo o mesmo que preencher os seguintes campos:</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Numero da Fita</span></b>
                    � informar o numero de fita de 4 caracteres.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Per�odo de Exibi��o</span>
                        � </b>informar o intervalo de datas em que esta fita ficar� dispon�vel para
                    exibi��o.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Quantidade</span></b>
                    � informar a quantidade de vezes que a fita dever� ser exibida, esta quantidade
                    serve apenas como base de informa��o ao usu�rio do roteiro, pois o sistema n�o ir�
                    impedir que seja exibido mais do que foi informado.,</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">T�tulo do Comercial</span></b>
                    � informar o t�tulo a ser exibido.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Dura��o</span></b>
                    � informar a dura��o do comercial em segundos.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Programa</span></b>
                    � informar o c�digo do programa para o caso de querer que a fita em quest�o seja
                    exibida <b style="mso-bidi-font-weight: normal">somente</b> neste programa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Tipo de Comercial</span></b>
                    � informar o c�digo do Tipo de Comercial.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Exibir somente
                        no Programa</span> � </b>campo para informar o c�digo de um programa espec�fico
                    para exibi��o desta fita avulsa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Exibir somente
                        Antes do Programa</span></b> � campo para informar o c�digo de um programa,
                    para que o sistema utilize como par�metro e somente demonstre esta fita avulsa para
                    os programas que ser�o exibidos antes deste.<b style="mso-bidi-font-weight: normal"><o:p></o:p></b></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Disponibilizar
                        nos Dias</span></b> � para especificar os dias em que se deseja que o comercial
                    avulso apare�a no Roteiro.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Ve�culos</span></b>
                    � informar o ve�culo para o qual valer� a fita.
                </p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Consideramos como fita avulsa, os comerciais tipo calhau que s�o utilizados para
                    preencher espa�os ociosos, ou algum comercial que entrou como urgente, sem ter passado
                    pela digita��o.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    E consideramos como fitas art�sticas as chamadas e vinhetas de programa��o local.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Numerar Fitas<o:p></o:p></span></b></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Para darmos numero de fita para um comercial, devemos, ap�s completado o<span style="mso-spacerun: yes">&nbsp;
                    </span>filtro, selecionar o comercial desejado e clicarmos no bot�o espec�fico <b
                        style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Numerar�</span></b>,
                    ou darmos um duplo clique sobre o campo <b style="mso-bidi-font-weight: normal"><span
                        style="font-size: 8pt">�N. Fita�</span></b>,<span style="mso-spacerun: yes">&nbsp; </span>
                    que o sistema abrir� uma nova janela demonstrando os dados do comercial selecionado,
                    cabendo ao usu�rio informar o n�mero de fita no campo espec�fico, caso o numero
                    escolhido esteja sendo utilizado para outro comercial ainda ativo, o sistema dar�
                    uma mensagem de alerta e demonstrar� no campo <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">�Comercial existente com o mesmo numero de fita�</span>,</b>
                    os dados da fita existente.
                </p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    O campo <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Localiza��o�</span></b>
                    serve apenas para o usu�rio informar o local onde se encontra registrado o comercial
                    a ser exibido.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    As op��es de pesquisa permite ao usu�rio consultar todas as fitas cadastradas para
                    o mesmo <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Cliente</span></b>,
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Ag�ncia</span></b>
                    e <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Produto</span></b>
                    do comercial que se est� querendo numerar.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    O �cone <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Alterar�</span></b>
                    da barra de ferramentas permite ao usu�rio registrar as seguinte informa��es:
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data Recep��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar a data de recep��o do material
                            na emissora.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data Transcri��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar a data que o material<span style="mso-spacerun: yes">&nbsp;
                            </span>foi transcrito (digitalizada).<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Dada Devolu��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � informar a data de devolu��o do material.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Localiza��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � permite informar ou alterar os dados
                            de localiza��o do material.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Observa��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � campo livre que permite ao usu�rio informar
                            qualquer observa��o referente ao material.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Exclui</span>r</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � permite limpar o campo numero de fita
                            do comercial selecionado, voltando ao status de pendente.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Desativar / Reativar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � permite a desativa��o da fita do comercial
                            selecionado, por�m mantendo o n�mero de fita associado a este comercial. Para reativar
                            a fita basta selecionar o comercial e clicar sobre o mesmo bot�o na barra de ferramentas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Visualizar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � demonstra uma janela que permite visualizar
                            os dados dos comerciais selecionados, podendo tamb�m, abrir esta janela atrav�s
                            de um duplo clique sobre qualquer campo do comercial a ser selecionado, com exce��o
                            do campo <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�N.Fita�</span></b>.
                            <o:p></o:p>
                        </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Relat�rio</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � esta op��o permite ao usu�rio gerar
                            um relat�rio de seu cadastro de numera��o de fitas, utilizando-se dos mesmos filtros
                            mencionados para a pesquisa, por�m, com a op��o se visualizar o relat�rio <b style="mso-bidi-font-weight: normal">
                                <span style="font-size: 8pt">�Resumido�</span></b> ou <b style="mso-bidi-font-weight: normal">
                                    <span style="font-size: 8pt">�Detalhado�</span>.<o:p></o:p></b></span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observa��es</td>
        </tr>
     <tr>
         <td class="td" style="font-size: 7.5pt">
             <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                 <span style="font-size: 7.5pt; color: #000000">O sistema n�o permitir� a desativa��o
                     e exclus�o de fitas que estejam roteirizadas a futuro.</span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

