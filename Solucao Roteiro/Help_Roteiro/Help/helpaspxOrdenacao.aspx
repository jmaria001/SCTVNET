<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxOrdenacao.aspx.cs" Inherits="Help_Default" Title="Ordenação" %>
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
             tem por objetivo permitir a confecção do Roteiro Técnico manualmente pelo usuário.<?xml
                 namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Operação</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px">
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 12pt">
                        <span style="mso-spacerun: yes">&nbsp;</span><span style="font-size: 7.5pt">Para iniciarmos
                            o processo, é necessário informar o veículo e a data de exibição, clicando em seguida
                            no botão <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“OK”</span></b>.<o:p></o:p></span></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Após este
                        filtro, o sistema demonstrará todos os programas que possuem Composição de Break
                        para o <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">veículo/data</span></b>
                        informados. O usuário poderá optar para ordenar todos os programas do dia, os de
                        apenas uma ou mais faixa horária ou apenas um programa específico. Sendo que ao
                        habilitar um ou mais programas para ordenação, estes ficarão bloqueados para que
                        outro usuário tente, também, ordená-los ou compor seus breaks. Após a escolha do(s)
                        programa(s), clicar em <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            “Carregar Roteiro”</span></b>.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os comerciais
                        a serem roteirizados estarão dispostos nas seguintes pastas do lado direito da tela.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Comerciais</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – apresentará todos os comerciais cadastrados
                            através de mapa reserva para o programa específico, demonstrando o numero de fita,
                            o título e produto do comercial, a duração, código (legenda) do comercial, os dados
                            do contrato e a identificação de qual Setor pertence o produto a ser exibido.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Rotativos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – apresentará todos os comerciais cadastrados
                            através de mapa reserva para uma faixa rotativa cujo programa que se está ordenando
                            faça parte. Demonstrando numero de fita, o título e produto do comercial, a duração,
                            código (legenda) do comercial, os dados do contrato e a identificação de qual Setor
                            pertence o produto a ser exibido.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Avulsos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – apresentará todos os comerciais avulsos
                            que se encaixem no programa, data e veículo a ser ordenado. Demonstrando o numero
                            de fita, o título do comercial, a duração e o saldo em relação da quantidade informada
                            no cadastramento deste avulso.
                            <o:p></o:p>
                        </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Artísticos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – apresentará todas as vinhetas artísticas
                            que se encaixem no programa, data e veículo a ser ordenado. Demonstrando o numero
                            de fita, o título do comercial, a duração e o saldo em relação da quantidade informada
                            no cadastramento deste artístico.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Outros Programas</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> – caso queira-se ordenar para o programa
                            determinado um comercial que fora cadastrado para outro programa, deve-se utilizar
                            esta função. Porém, somente aparecerá para serem ordenados aqueles comerciais que
                            ainda estão disponíveis para ordenação no programa original.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Será demonstrado
                        o numero de fita, o título e produto do comercial, a duração, código (legenda) do
                        comercial, os dados do contrato e a identificação de qual Setor pertence o produto
                        a ser exibido.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para processar
                        a ordenação, o usuário deverá clicar sobre o comercial desejado e arrastá-lo para
                        break e posição que se deseja exibir. Desta forma, a confecção do roteiro fica totalmente
                        por conta do usuário.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para facilitar
                        a visualização do usuário quanto ao preenchimento dos breaks, ele pode comparar
                        as colunas <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Dur”</span></b>
                        que indica a duração total do break (local, Net) com a coluna <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">“Enc”</span></b> que demonstra a soma dos comerciais
                        ordenados.
                        <o:p></o:p>
                    </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Outra forma
                        de visualização seria no canto direito baixo do formulário onde teremos o total
                        de Duração e Encaixe por break selecionado e o total por programa, que vão se atualizando
                        a cada movimentação.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="mso-spacerun: yes">
                        &nbsp;</span>Conforme os breaks vão sendo totalmente preenchidos, ao lado da denominação
                        do break (Artístico, Net ou Local), é preenchido<span style="mso-spacerun: yes">&nbsp;
                        </span>com suas respectivas cores (Verde, Rosa ou Azul), caso o encaixe do break
                        seja estourado, a cor demonstrada é a Vermelha.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Na coluna
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Enc”</span> </b>
                        além de demonstrar o total (em segundos)<span style="mso-spacerun: yes">&nbsp; </span>
                        encaixado na linha do programa, mostra também, na linha do comercial a origem deste,
                        sendo <b style="mso-bidi-font-weight: normal">Co</b> para os da pasta Comerciais,
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Rt</span></b>
                        para os da pasta Rotativos, <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            Av</span></b> para os da pasta Avulsos,<span style="mso-spacerun: yes">&nbsp; </span>
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Ar</span></b>
                        para os da pasta Artísticos e <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            Op</span></b> para os da pasta Outros Programas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os comerciais
                        podem ser movimentados dentro do próprio break ou até mesmo de um break para outro.
                        Para desistir da ordenação de um comercial basta arrastá-lo novamente para sua pasta
                        de origem, para desistir de toda a ordenação, deve-se clicar sobre o botão em forma
                        de <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“X”</span></b>
                        , contido na barra de ferramentas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para excluir
                        um comercial do roteiro e já baixar um qualidade nele, deve-se arrastá-lo da <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">pasta de disponíveis</span></b> para o ícone em
                        forma de <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">lixeira</span></b>
                        da barra de ferramentas. A qualidade associada para a veiculação será a que estiver
                        cadastrada no parâmetro <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            0028</span></b> dos Parâmetros Gerais do Sistema.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">O botão <b
                        style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Usuários em Operação”</span></b>
                        serve para verificar os usuários que estão acessando as funções de <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">
    Ordenação</span></b> e <b style="mso-bidi-font-weight: normal">
                                <span style="font-size: 8pt">Composição de Breaks</span></b>.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">O botão <b
                        style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">“Consistir a Ordenação”</span></b>
                        permite ao usuário verificar as inconsistências existentes em todo o roteiro do
                        dia ou de apenas um programa selecionado, demonstrando a <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">Ocupação dos Intervalos</span></b>, <b style="mso-bidi-font-weight: normal">
                                <span style="font-size: 8pt">Choque de Concorrentes</span></b>, <b style="mso-bidi-font-weight: normal">
                                    <span style="font-size: 8pt">Fitas a Determinar</span></b> (sem números),
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Restrição de Horários</span></b>
                        (vinculado à tabela de Produtos), <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            Comerciais não Ordenados</span></b> e o <b style="mso-bidi-font-weight: normal"><span
                                style="font-size: 8pt">Tempo dos Breaks</span></b>.<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Após qualquer movimento dentro do Roteiro, para trocar de programa ou simplesmente
                    sair da ordenação, o usuário deverá salvar as movimentações feitas para o programa,
                    utilizando para isso, o ícone em forma de disquete (Salvar Ordenação).</p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observações</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 7.5pt">
                     <span style="color: #000000">Por motivo de segurança e integridade nos dados do Roteiro,
                         a ordenação deve ser efetuada por apenas um usuário por </span><span style="color: #000000">
                             <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">veículo/data/programa</span>.</b><o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

