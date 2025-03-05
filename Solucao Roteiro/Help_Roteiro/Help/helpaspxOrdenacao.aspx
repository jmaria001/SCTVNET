<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxOrdenacao.aspx.cs" Inherits="Help_Default" Title="Ordena��o" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH1" Runat="Server">
 <table width="100%" style="height: 105px">
<tr>
            <td class="titulos" colspan="3">
                Defini��o</td>
        </tr>
        <tr>
 <td class="td" style="font-size: 7.5pt" >
     <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
         <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Esta rotina
             tem por objetivo permitir a confec��o do Roteiro T�cnico manualmente pelo usu�rio.<?xml
                 namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
</td>
        </tr>
    <tr>
            <td class="titulos">
                Opera��o</td>
        </tr>
        <tr>
            <td class="td" style="height: 26px">
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 12pt">
                        <span style="mso-spacerun: yes">&nbsp;</span><span style="font-size: 7.5pt">Para iniciarmos
                            o processo, � necess�rio informar o ve�culo e a data de exibi��o, clicando em seguida
                            no bot�o <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�OK�</span></b>.<o:p></o:p></span></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Ap�s este
                        filtro, o sistema demonstrar� todos os programas que possuem Composi��o de Break
                        para o <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">ve�culo/data</span></b>
                        informados. O usu�rio poder� optar para ordenar todos os programas do dia, os de
                        apenas uma ou mais faixa hor�ria ou apenas um programa espec�fico. Sendo que ao
                        habilitar um ou mais programas para ordena��o, estes ficar�o bloqueados para que
                        outro usu�rio tente, tamb�m, orden�-los ou compor seus breaks. Ap�s a escolha do(s)
                        programa(s), clicar em <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            �Carregar Roteiro�</span></b>.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os comerciais
                        a serem roteirizados estar�o dispostos nas seguintes pastas do lado direito da tela.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Comerciais</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � apresentar� todos os comerciais cadastrados
                            atrav�s de mapa reserva para o programa espec�fico, demonstrando o numero de fita,
                            o t�tulo e produto do comercial, a dura��o, c�digo (legenda) do comercial, os dados
                            do contrato e a identifica��o de qual Setor pertence o produto a ser exibido.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Rotativos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � apresentar� todos os comerciais cadastrados
                            atrav�s de mapa reserva para uma faixa rotativa cujo programa que se est� ordenando
                            fa�a parte. Demonstrando numero de fita, o t�tulo e produto do comercial, a dura��o,
                            c�digo (legenda) do comercial, os dados do contrato e a identifica��o de qual Setor
                            pertence o produto a ser exibido.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Avulsos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � apresentar� todos os comerciais avulsos
                            que se encaixem no programa, data e ve�culo a ser ordenado. Demonstrando o numero
                            de fita, o t�tulo do comercial, a dura��o e o saldo em rela��o da quantidade informada
                            no cadastramento deste avulso.
                            <o:p></o:p>
                        </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Art�sticos</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � apresentar� todas as vinhetas art�sticas
                            que se encaixem no programa, data e ve�culo a ser ordenado. Demonstrando o numero
                            de fita, o t�tulo do comercial, a dura��o e o saldo em rela��o da quantidade informada
                            no cadastramento deste art�stico.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Outros Programas</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � caso queira-se ordenar para o programa
                            determinado um comercial que fora cadastrado para outro programa, deve-se utilizar
                            esta fun��o. Por�m, somente aparecer� para serem ordenados aqueles comerciais que
                            ainda est�o dispon�veis para ordena��o no programa original.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Ser� demonstrado
                        o numero de fita, o t�tulo e produto do comercial, a dura��o, c�digo (legenda) do
                        comercial, os dados do contrato e a identifica��o de qual Setor pertence o produto
                        a ser exibido.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">&nbsp;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para processar
                        a ordena��o, o usu�rio dever� clicar sobre o comercial desejado e arrast�-lo para
                        break e posi��o que se deseja exibir. Desta forma, a confec��o do roteiro fica totalmente
                        por conta do usu�rio.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para facilitar
                        a visualiza��o do usu�rio quanto ao preenchimento dos breaks, ele pode comparar
                        as colunas <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Dur�</span></b>
                        que indica a dura��o total do break (local, Net) com a coluna <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">�Enc�</span></b> que demonstra a soma dos comerciais
                        ordenados.
                        <o:p></o:p>
                    </span>
                </p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Outra forma
                        de visualiza��o seria no canto direito baixo do formul�rio onde teremos o total
                        de Dura��o e Encaixe por break selecionado e o total por programa, que v�o se atualizando
                        a cada movimenta��o.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="mso-spacerun: yes">
                        &nbsp;</span>Conforme os breaks v�o sendo totalmente preenchidos, ao lado da denomina��o
                        do break (Art�stico, Net ou Local), � preenchido<span style="mso-spacerun: yes">&nbsp;
                        </span>com suas respectivas cores (Verde, Rosa ou Azul), caso o encaixe do break
                        seja estourado, a cor demonstrada � a Vermelha.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Na coluna
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Enc�</span> </b>
                        al�m de demonstrar o total (em segundos)<span style="mso-spacerun: yes">&nbsp; </span>
                        encaixado na linha do programa, mostra tamb�m, na linha do comercial a origem deste,
                        sendo <b style="mso-bidi-font-weight: normal">Co</b> para os da pasta Comerciais,
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Rt</span></b>
                        para os da pasta Rotativos, <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            Av</span></b> para os da pasta Avulsos,<span style="mso-spacerun: yes">&nbsp; </span>
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Ar</span></b>
                        para os da pasta Art�sticos e <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            Op</span></b> para os da pasta Outros Programas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Os comerciais
                        podem ser movimentados dentro do pr�prio break ou at� mesmo de um break para outro.
                        Para desistir da ordena��o de um comercial basta arrast�-lo novamente para sua pasta
                        de origem, para desistir de toda a ordena��o, deve-se clicar sobre o bot�o em forma
                        de <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�X�</span></b>
                        , contido na barra de ferramentas.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Para excluir
                        um comercial do roteiro e j� baixar um qualidade nele, deve-se arrast�-lo da <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">pasta de dispon�veis</span></b> para o �cone em
                        forma de <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">lixeira</span></b>
                        da barra de ferramentas. A qualidade associada para a veicula��o ser� a que estiver
                        cadastrada no par�metro <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            0028</span></b> dos Par�metros Gerais do Sistema.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">O bot�o <b
                        style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Usu�rios em Opera��o�</span></b>
                        serve para verificar os usu�rios que est�o acessando as fun��es de <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">
    Ordena��o</span></b> e <b style="mso-bidi-font-weight: normal">
                                <span style="font-size: 8pt">Composi��o de Breaks</span></b>.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">O bot�o <b
                        style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">�Consistir a Ordena��o�</span></b>
                        permite ao usu�rio verificar as inconsist�ncias existentes em todo o roteiro do
                        dia ou de apenas um programa selecionado, demonstrando a <b style="mso-bidi-font-weight: normal">
                            <span style="font-size: 8pt">Ocupa��o dos Intervalos</span></b>, <b style="mso-bidi-font-weight: normal">
                                <span style="font-size: 8pt">Choque de Concorrentes</span></b>, <b style="mso-bidi-font-weight: normal">
                                    <span style="font-size: 8pt">Fitas a Determinar</span></b> (sem n�meros),
                        <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">Restri��o de Hor�rios</span></b>
                        (vinculado � tabela de Produtos), <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            Comerciais n�o Ordenados</span></b> e o <b style="mso-bidi-font-weight: normal"><span
                                style="font-size: 8pt">Tempo dos Breaks</span></b>.<o:p></o:p></span></p>
                <p class="MsoBodyText" style="margin: 0cm 0cm 0pt">
                    Ap�s qualquer movimento dentro do Roteiro, para trocar de programa ou simplesmente
                    sair da ordena��o, o usu�rio dever� salvar as movimenta��es feitas para o programa,
                    utilizando para isso, o �cone em forma de disquete (Salvar Ordena��o).</p>
            </td>
        </tr>
        <tr>
            <td class="titulos" style="height: 22px">
                Observa��es</td>
        </tr>
     <tr>
         <td class="td" style="height: 22px">
             <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                 <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 7.5pt">
                     <span style="color: #000000">Por motivo de seguran�a e integridade nos dados do Roteiro,
                         a ordena��o deve ser efetuada por apenas um usu�rio por </span><span style="color: #000000">
                             <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">ve�culo/data/programa</span>.</b><o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

