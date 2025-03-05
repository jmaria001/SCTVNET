<%@ Page Language="C#" MasterPageFile="~/Help/MasterHelp.master" AutoEventWireup="true" CodeFile="helpaspxHorarioRealProgramacao.aspx.cs" Inherits="Help_Default" Title="Hor�rio Real da Programa��o" %>
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
             permite ao usu�rio informar o hor�rio real em que a programa��o iniciou e terminou
             em uma determinada data, fazendo com que desta forma, a fun��o de importar os hor�rios
             do Play List para o sistema seja mais precisa o poss�vel.
             <?xml namespace="" ns="urn:schemas-microsoft-com:office:office" prefix="o" ?><o:p></o:p></span></p>
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
                Para processarmos
                        esta rotina devemos preencher os seguintes campos:<o:p></o:p></span></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Ve�culo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do ve�culo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Data de Exibi��o</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � data<span style="mso-spacerun: yes">&nbsp;
                            </span>de exibi��o das veicula��es.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Exibir</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � clicar neste bot�o para o sistema processar
                            o filtro.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">Ap�s a confirma��o
                        o sistema mostrar� no grid abaixo as seguintes informa��es;<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">C�digo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � c�digo do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">T�tulo</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � descri��o do programa.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Inicio Previsto</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � hor�rio de inicio do programa cadastrado
                            na grade comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Final Previsto</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � hor�rio de t�rmino do programa cadastrado
                            na grade comercial.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Inicio Real</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � campo para o usu�rio informar o<span
                                style="mso-spacerun: yes">&nbsp; </span>hor�rio que realmente o programa teve
                            sua exibi��o iniciada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Final Real</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"><span style="font-size: 8pt"> </span>�
                            campo para o usu�rio informar o hor�rio que realmente o programa teve sua exibi��o
                            encerrada.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <span style="font-family: Arial; mso-bidi-font-family: 'Times New Roman'">O usu�rio
                        pode acertar cada programa individualmente ou todos a partir da primeira altera��o,
                        selecionando o item <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt">
                            �Ajustar Hor�rio dos Programas Subseq��ntes�</span>.</b><o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Replicar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � para o caso do usu�rio possuir mais
                            de um ve�culo, sendo o segundo um corte de sinal, ele utilizar� este bot�o para
                            replicar<span style="mso-spacerun: yes">&nbsp; </span>o procedimento para o outro
                            ve�culo.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Gravar</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � selecionar este bot�o para confirmar
                            as altera��es.<o:p></o:p></span></p>
                <p class="MsoNormal" style="margin: 0cm 0cm 0pt; text-align: justify">
                    <b style="mso-bidi-font-weight: normal"><span style="font-size: 8pt; font-family: Arial;
                        mso-bidi-font-family: 'Times New Roman'">Sair</span></b><span style="font-family: Arial;
                            mso-bidi-font-family: 'Times New Roman'"> � selecionar este bot�o para abortar o
                            processo ou para sair ap�s complet�-lo.<o:p></o:p></span></p>
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
                     <span style="color: #000000">� importante que esta fun��o seja processada </span>
                     <span style="font-size: 8pt"><b style="mso-bidi-font-weight: normal"><span style="color: #000000">
                         antes do</span></b><span style="color: #000000"> </span><b style="mso-bidi-font-weight: normal">
                             <span style="color: #000000">checking ou do usu�rio respons�vel fazer a importa��o dos
                                 dados do play list para o SCTV</span></b></span><span style="color: #000000">.<o:p></o:p></span></span></span></p>
         </td>
     </tr>
        <tr>
        </tr>
 </table>
</asp:Content>

