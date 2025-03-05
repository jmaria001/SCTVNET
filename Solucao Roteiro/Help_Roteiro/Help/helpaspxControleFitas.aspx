<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxControleFitas.aspx.cs" Inherits="Help_Default" Title="Controle de Fitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Definição</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Nesta rotina
             daremos manutenção na numeração de fitas originadas de mídia ou avulsas. Podendo
             cadastrar, alterar, desativar estas fitas.<?xml namespace="" ns="urn:schemas-microsoft-com:office:office"
                 prefix="o" ?><o:p></o:p></span></p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Operação</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px; font-size: 7.5pt;">
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt">
                    Para consultarmos as fitas cadastradas ou os comerciais pendentes de numeração devemos
                    utilizar o ícone em forma de um binóculo na barra de ferramentas e preencher os
                    filtros que se deseja consultar dentre as seguintes opções:</span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Veículo</span></b>
                    – informar o código do veículo.
                </p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Programa</span></b>
                    – informar o código do programa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Início</span></b>
                    – informar a data de início para a consulta.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Fim</span></b>
                    – informar a data de término para a consulta.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Numero de Fita
                        De e Até</span></b> – para informar um intervalo de fitas específicas que se
                    deseja consultar.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Mostrar Pendentes
                        de Numeração</span></b> – para visualizar somente os comerciais cadastrados
                    através da inclusão do mapa reserva que ainda não possuem numero de fita.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Mostrar Numeradas</span></b>
                    – para visualizar os comerciais que já possuam numero de fitas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Mostrar Fitas Avulsas</span></b>
                    – para visualizar as fitas cadastradas como avulsas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Mostrar Fitas Artísticas</span></b>
                    – para visualizar as fitas cadastradas como artísticas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Status</span></b>
                    – possibilita a visualização das fitas <b style="mso-bidi-font-weight: normal"><span
                        style="font-size: 8pt">“Desativadas / Devolvidas”</span></b> , <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">“Ativas”</span></b> ou ambas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Empresa / Contrato
                        / Seqüência</span></b> – informar os dados do contrato da fita a ser consultada.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Legenda</span></b>
                    – informar a legenda (código) do comercial cadastrado no mapa reserva.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Tipo de Comercial</span></b>
                    – informar o tipo de comercial da veiculação.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Agência</span></b>
                    – informar o código da agência.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Cliente</span></b>
                    – informar o código ou a razão social do cliente.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Produto</span></b>
                    – informar o nome do produto cadastrado.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    É necessário salientar que apenas os campos <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">“Início e Fim”</span> </b>e uma das opções entre
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Mostrar Pendentes
                        de Numeração”</span>,</b> <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            “Mostrar Numeradas”</span>,</b> <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                                “Mostrar Fitas Avulsas”</span>,</b> <b style="mso-bidi-font-weight: normal"><span
                                    style="font-size: 8pt">“Mostrar Fitas Artísticas”</span></b> <b style="mso-bidi-font-weight: normal">
                                        <span style="mso-spacerun: yes">&nbsp;</span></b>são de preenchimento
                    obrigatório, sendo os demais campos opcionais para consultas mais específicas.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <o:p></o:p>
                    &nbsp;</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Na barra de ferramentas
                        temos as seguintes opções:<o:p></o:p></span></b></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal">&nbsp;<o:p></o:p></b></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <span style="font-size: 8pt"><b style="mso-bidi-font-weight: normal">Adicionar Fitas
                        Avulsas</b> <b style="mso-bidi-font-weight: normal">ou Artísticas.</b></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    permite ao usuário inserir uma fita avulsa ou artística para ser exibida no Roteiro
                    Técnico, tendo o mesmo que preencher os seguintes campos:</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Numero da Fita</span></b>
                    – informar o numero de fita de 4 caracteres.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Período de Exibição</span>
                        – </b>informar o intervalo de datas em que esta fita ficará disponível para
                    exibição.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Quantidade</span></b>
                    – informar a quantidade de vezes que a fita deverá ser exibida, esta quantidade
                    serve apenas como base de informação ao usuário do roteiro, pois o sistema não irá
                    impedir que seja exibido mais do que foi informado.,</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Título do Comercial</span></b>
                    – informar o título a ser exibido.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Duração</span></b>
                    – informar a duração do comercial em segundos.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Programa</span></b>
                    – informar o código do programa para o caso de querer que a fita em questão seja
                    exibida <b style="mso-bidi-font-weight: normal">somente</b> neste programa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Tipo de Comercial</span></b>
                    – informar o código do Tipo de Comercial.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Exibir somente
                        no Programa</span> – </b>campo para informar o código de um programa específico
                    para exibição desta fita avulsa.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Exibir somente
                        Antes do Programa</span></b> – campo para informar o código de um programa,
                    para que o sistema utilize como parâmetro e somente demonstre esta fita avulsa para
                    os programas que serão exibidos antes deste.<b style="mso-bidi-font-weight: normal"><o:p></o:p></b></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Disponibilizar
                        nos Dias</span></b> – para especificar os dias em que se deseja que o comercial
                    avulso apareça no Roteiro.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Veículos</span></b>
                    – informar o veículo para o qual valerá a fita.
                </p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Consideramos como fita avulsa, os comerciais tipo calhau que são utilizados para
                    preencher espaços ociosos, ou algum comercial que entrou como urgente, sem ter passado
                    pela digitação.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    E consideramos como fitas artísticas as chamadas e vinhetas de programação local.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Numerar Fitas<o:p></o:p></span></b></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    &nbsp;<o:p></o:p></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Para darmos numero de fita para um comercial, devemos, após completado o<span style="mso-spacerun: yes">&nbsp;
                    </span>filtro, selecionar o comercial desejado e clicarmos no botão específico <b
                        style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Numerar”</span></b>,
                    ou darmos um duplo clique sobre o campo <b style="mso-bidi-font-weight: normal"><span
                        style="font-size: 8pt">“N. Fita”</span></b>,<span style="mso-spacerun: yes">&nbsp; </span>
                    que o sistema abrirá uma nova janela demonstrando os dados do comercial selecionado,
                    cabendo ao usuário informar o número de fita no campo específico, caso o numero
                    escolhido esteja sendo utilizado para outro comercial ainda ativo, o sistema dará
                    uma mensagem de alerta e demonstrará no campo <b style="mso-bidi-font-weight: normal">
                        <span style="font-size: 8pt">“Comercial existente com o mesmo numero de fita”</span>,</b>
                    os dados da fita existente.
                </p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    O campo <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Localização”</span></b>
                    serve apenas para o usuário informar o local onde se encontra registrado o comercial
                    a ser exibido.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    As opções de pesquisa permite ao usuário consultar todas as fitas cadastradas para
                    o mesmo <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Cliente</span></b>,
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Agência</span></b>
                    e <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Produto</span></b>
                    do comercial que se está querendo numerar.</p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    O ícone <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Alterar”</span></b>
                    da barra de ferramentas permite ao usuário registrar as seguinte informações:
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data Recepção</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar a data de recepção do material
                            na emissora.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data Transcrição</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar a data que o material<span style="mso-spacerun: yes">&nbsp;
                            </span>foi transcrito (digitalizada).<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Dada Devolução</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – informar a data de devolução do material.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Localização</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – permite informar ou alterar os dados
                            de localização do material.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Observação</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – campo livre que permite ao usuário informar
                            qualquer observação referente ao material.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">
                        <span style="font-size: 8pt">Exclui</span>r</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – permite limpar o campo numero de fita
                            do comercial selecionado, voltando ao status de pendente.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Desativar / Reativar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – permite a desativação da fita do comercial
                            selecionado, porém mantendo o número de fita associado a este comercial. Para reativar
                            a fita basta selecionar o comercial e clicar sobre o mesmo botão na barra de ferramentas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Visualizar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – demonstra uma janela que permite visualizar
                            os dados dos comerciais selecionados, podendo também, abrir esta janela através
                            de um duplo clique sobre qualquer campo do comercial a ser selecionado, com exceção
                            do campo <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“N.Fita”</span></b>.
                            <o:p></o:p>
                        </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Relatório</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – esta opção permite ao usuário gerar
                            um relatório de seu cadastro de numeração de fitas, utilizando-se dos mesmos filtros
                            mencionados para a pesquisa, porém, com a opção se visualizar o relatório <b style="mso-bidi-font-weight: normal">
                                <span style="font-size: 8pt">“Resumido”</span></b> ou <b style="mso-bidi-font-weight: normal">
                                    <span style="font-size: 8pt">“Detalhado”</span>.<o:p></o:p></b></span></p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observações</td>
        </tr>
     <tr>
         <td class="td" style="font-size: 7.5pt">
             <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                 <span style="font-size: 7.5pt; color: #000000">O sistema não permitirá a desativação
                     e exclusão de fitas que estejam roteirizadas a futuro.</span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

