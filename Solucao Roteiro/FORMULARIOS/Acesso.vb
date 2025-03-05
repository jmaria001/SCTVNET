Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System
Imports System.Management
Friend Class frmAcesso

    Inherits System.Windows.Forms.Form
    Public OkClik As Boolean
    ' declaração de variaveis private
    Private idUsuario As Integer
    Private nomeUsuario As String
    Private emailUsuario As String
    Private emailDestino As String
    Private emailDestinoCC As String
    Private emailSubject As String
    Private emailCorpo As String
    Private cidadeUsuario As String
    Private emissoraUsuario As String
    Private veiculoUsuario As String
    Private Observacao As String
    Private blnFlagPendente As Boolean
    Private Sub cmdAlterarSenha_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAlterarSenha.Click
        gsUsuario = txtUsuario.Text
        gsSenha = txtSenha.Text
        Dim CLS As MSAClass.asmxUsuario.asmxUsuario = NewUsuario()
        Dim clsParametro As MSAClass.AsmxParametro.asmxParametro = NewParametro()
        Dim strMensagem As String
        Try
            Me.Cursor = Cursors.WaitCursor '
            '===========================Consiste o Usuario 
            strMensagem = CLS.fnValidaUsuario(txtUsuario.Text, Criptografia.Funcoes.Criptografar(txtSenha.Text))
            If strMensagem <> "" Then
                Aviso(strMensagem)
                Exit Sub
            End If
            frmUsuario_AlterarSenha.prUsuario = txtUsuario.Text
            frmUsuario_AlterarSenha.ShowDialog()
        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ucOkCancel.Cancel_Click
        Me.Hide()
    End Sub


    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ucOkCancel.Ok_Click
        gsUsuario = txtUsuario.Text
        gsSenha = txtSenha.Text

        Dim strMensagem As String
        Dim intFlag As Integer
        Dim blnFlagAtivo As Boolean

        Dim clsUsuario As MSAClass.asmxUsuario.asmxUsuario = NewUsuario()
        Dim clsParametro As MSAClass.AsmxParametro.asmxParametro = NewParametro()
        Dim DT As New DataSet
        Dim clsGeneric As MSAClass.AsmxGeneric.asmxGeneric = NewGeneric()
        If txtUsuario.Text.Trim = "" Then
            Aviso("Usuário não foi Informado")
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            '===========================Consiste o Usuario 
            strMensagem = clsUsuario.fnValidaUsuario(txtUsuario.Text, Criptografia.Funcoes.Criptografar(txtSenha.Text))
            If strMensagem <> "" Then
                Aviso(strMensagem)
                txtUsuario.Focus()
                Exit Sub
            End If
            'If gsUsuario.ToUpper() <> "ADMIN".ToUpper() Then
            '====================== Valida MAC Address =====================
            blnFlagPendente = False
            intFlag = 0
            blnFlagAtivo = clsGeneric.spuSelectMacAdress(MACAddress, intFlag)
            If Not blnFlagAtivo Then
                intFlag = 1
                blnFlagPendente = clsGeneric.spuSelectMacAdress(MACAddress, intFlag)

                If Not blnFlagPendente Then
                    If MsgBox("Este Computador não está autorizado a utilizar o SCTVNET!" & Chr(13) & "Deseja solicitar autorização ao setor Gestão de Sistemas e Projetos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                        GoTo Saida
                    Else
                        ' enviar emai
                        Dim int As Integer
                        int = Envia_Email()
                        If int <> 0 Then
                            MsgBox("Solicitação de acesso foi enviada com sucesso." & vbCrLf & "Favor aguardar a aprovação", MsgBoxStyle.Information)
                        End If
                        GoTo Saida
                    End If
                Else
                    If MsgBox("Autorização de acesso pendente de aprovação!" & Chr(13) & "Deseja comunicar o setor ''Gestão de Sistemas e Projetos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                        GoTo Saida
                    Else
                        Dim int As Integer
                        int = Envia_Email()
                        If int <> 0 Then
                            MsgBox("Email enviado com sucesso!", MsgBoxStyle.Information)
                        End If
                        GoTo Saida
                    End If
                End If
            End If
            'End If
            '===========================Habiliar as Funcoes do Usuario
            mdiPrincipal.lblUsuario.Text = gsUsuario
            mdiPrincipal.lblUsuario.Visible = True
            DT = clsUsuario.fnFuncaoCarregar(gsUsuario)
            For Each RW As DataRow In DT.Tables(0).Rows
                If Not IsDBNull(RW("Objeto_Name")) Then
                    If RW("Objeto_Name").ToString.Trim <> "" Then
                        Call mdiPrincipal.HabilitaMenus(RW("Objeto_Name").ToString.Trim)
                    End If
                End If
            Next
            '==========================> Verifica a Empresa do Usuario
            dtsEmpresaUsuario.Clear()
            dtsEmpresaUsuario = clsUsuario.fnUsuario_Empresa(gsUsuario, Nothing)
            If dtsEmpresaUsuario.Tables(0).Rows.Count = 0 Then
                Aviso("Nenhum Empresa esta associada ao Usuário.Favor Solicitar ao Administrador do Sistema")
                txtUsuario.Text = ""
                txtSenha.Text = ""
                txtUsuario.Focus()
                Exit Sub
            End If
            '=============Limpa porta do usuario caso ficou preso
            Dim asmxPorta As MSAClass.AsmxPorta.asmxPorta = NewPorta()
            asmxPorta.spuLimpar(1, gsUsuario)
            asmxPorta.spuLimpar(2, gsUsuario)
            asmxPorta.spuLimpar(3, gsUsuario)

            '==========================> Acha o Codigo da Empresa Net 
            gsEmpresa_Net = clsGeneric.fnParametrosGerais("", "", "", 63)
            If gsEmpresa_Net.Trim = "" Then
                Aviso("Parametro Código da Empresa Net deve ser configurado antes de usar o Sistema")
                Exit Sub
            End If

            mdiPrincipal.dtsUsuario = clsUsuario.spuCarregar(txtUsuario.Text, txtSenha.Text)
            mdiPrincipal.dtsParametro = clsParametro.spuCarregar()

            strVeiculodoUsuario = ""
            For Each drw As MSAClass.asmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow In mdiPrincipal.dtsUsuario.dtbUsuario_Veiculo.Select()
                strVeiculodoUsuario = strVeiculodoUsuario & "'" & drw.Cod_Veiculo + "',"
            Next
            strVeiculodoUsuario = strVeiculodoUsuario.Substring(0, Len(strVeiculodoUsuario) - 1)
            sEmpresadoUsuario = fnEmpresadoUsuario(gsUsuario)
            OkClik = True
            Me.Hide()


        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

Saida:
    End Sub
    Private Function Envia_Email() As Boolean
        Dim clsGeneric As MSAClass.asmxGeneric.asmxGeneric = NewGeneric()
        Dim clsUsuario As MSAClass.asmxUsuario.asmxUsuario = NewUsuario()
        Dim dtsUser As New DataSet
        Dim retorno As Integer
        Dim item As Integer

        emailUsuario = ""
        Observacao = "MAC Address sujeito à liberação na base de dados."
        dtsUser = clsUsuario.spuCarregar(gsUsuario, gsSenha)
        For item = 0 To dtsUser.Tables.Count - 1
            If dtsUser.Tables(item).TableName = "dtbUsuario_MSAFuncao" Or dtsUser.Tables(item).TableName = "dtbUsuario_Programa" Then Continue For
            For Each dtRow As DataRow In dtsUser.Tables(item).Rows
                Select Case dtsUser.Tables(item).TableName
                    Case "dtbUsuario"
                        If Not IsDBNull(dtRow("ID_Usuario")) Then
                            nomeUsuario = Vernulo(dtRow("Nome").ToString().Trim(), "")
                            emailUsuario = Vernulo(dtRow("EMail").ToString().Trim(), "")
                            idUsuario = dtRow("ID_Usuario")
                            Exit For
                        End If
                    Case "dtbUsuario_Empresa"
                        emissoraUsuario = Vernulo(dtRow("Descricao").ToString().Trim(), "")
                        cidadeUsuario = Vernulo(dtRow("Cidade").ToString().Trim(), "")
                        Exit For
                    Case "dtbUsuario_Veiculo"
                        veiculoUsuario = Vernulo(dtRow("Cod_Veiculo") & "-" & dtRow("Nome_Veiculo").ToString().Trim(), "")
                        Exit For
                End Select
            Next
        Next

        emailDestino = clsGeneric.fnParametrosGerais(String.Empty, String.Empty, String.Empty, 253)
        emailDestinoCC = clsGeneric.fnParametrosGerais(String.Empty, String.Empty, String.Empty, 254)
        If emailUsuario = "" Then ' email remetente default
            emailUsuario = clsGeneric.fnParametrosGerais(String.Empty, String.Empty, String.Empty, 255)
        End If

        If Not blnFlagPendente Then
            emailSubject = "MAC Address não cadastrado na Base de Dados"
        Else
            emailSubject = "MAC Address pendente de liberação na Base de Dados"
        End If

        emailCorpo = MontaCorpoEmail()

        ' insert na tabela SendEmail
        retorno = clsGeneric.spuInsertEmail(emailUsuario, emailDestino, emailDestinoCC, emailSubject, emailCorpo, idUsuario)

        ' insert na tabela MAC_Address
        If Not blnFlagPendente Then
            retorno = clsGeneric.spuInsertMacAddress(MACAddress, CPUIdentificador, NomeComputador, nomeUsuario, emailUsuario, emissoraUsuario, cidadeUsuario, veiculoUsuario, Observacao)
        End If

        Return retorno

    End Function
    Private Function MontaCorpoEmail() As String
        Dim corpoEmail As String

        corpoEmail = "<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.01 Transitional//EN"" ""http://www.w3c.org/TR/1999/REC-html401-19991224/loose.dtd"">" & _
                     "<HTML><HEAD><TITLE>MAC Address</TITLE>" & _
                     "<META http-equiv=Content-Type content=""text/html; charset=windows-1252"">" & _
                     "<META content=""MSHTML 6.00.2800.1649"" name=GENERATOR></HEAD>" & _
                     "<BODY><P><B><SMALL><TABLE cellSpacing=0 cellPadding=0 border=0><TBODY>" & _
                     "<TR><TD WIDTH=""24%"">MAC Address </TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & MACAddress & "</TD></TR>" & _
                     "<TR><TD WIDTH=""24%"">CPU da Estação do Usuario </TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & CPUIdentificador & "</TD></TR>" & _
                     "<TR><TD WIDTH=""24%"">Nome da Estação do Usuario </TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & NomeComputador & "</TD></TR>" & _
                     "<TR><TD WIDTH=""24%"">Nome do Usuario</TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & nomeUsuario & "</TD></TR>" & _
                     "<TR><TD WIDTH=""24%"">Email do Usuario</TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & emailUsuario & "</TD></TR>" & _
                     "<TR><TD WIDTH=""24%"">Empresa do Usuario&nbsp;</TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & emissoraUsuario & "</TD></TR>" & _
                     "<TR><TD WIDTH=""24%"">Cidade do Usuario </TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & cidadeUsuario & "</TD></TR>" & _
                     "<TR><TD WIDTH=""24%"">Veiculo do Usuario</TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & veiculoUsuario & "</TD></TR>" & _
                     "<TR><TD WIDTH=""24%"">Observações</TD><TD WIDTH=""1%"">:</TD><TD WIDTH=""65%"">&nbsp;" & Observacao & "</TD></TR>" & _
                     "</TBODY></TABLE></SMALL></B></P>"

        Return corpoEmail

    End Function
    Private Sub frmAcesso_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtUsuario.Focus()
    End Sub

    Private Sub frmAcesso_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{TAB}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub frmAcesso_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'Me.GetMacAdress() 
        MACAddress = GetMACAddress()
        CPUIdentificador = GetCPUId()
        NomeComputador = GetNomeComputador()

        SetaUserControl(Me)
        Me.CenterToParent()
        OkClik = False
        SetaUserControl(Me)
        Try
            '==============================Desabilita todos os menus 
            For mnu As Integer = 0 To mdiPrincipal.mnuPrincipal.Items.Count - 1
                If TypeOf (mdiPrincipal.mnuPrincipal.Items(mnu)) Is ToolStripMenuItem Then
                    mdiPrincipal.mnuPrincipal.Items(mnu).Visible = False
                    Call DesabilitaSubItens(mdiPrincipal.mnuPrincipal.Items(mnu))
                End If
            Next
            '==============================Habilita os que estarao sempres disponiveis
            mdiPrincipal.mnuJanelas.Visible = True
            mdiPrincipal.mnusair.Visible = True
            mdiPrincipal.mnusair2.Visible = True
            txtUsuario.Focus()
        Catch ex As Exception
            ShowErro(ex)
        End Try
        Exit Sub
    End Sub
    Private Sub DesabilitaSubItens(ByVal pSubItem As ToolStripMenuItem) ' Recursive Sub
        Try
            pSubItem.Visible = False
            For x As Integer = 0 To pSubItem.DropDownItems.Count - 1
                If TypeOf (pSubItem.DropDownItems.Item(x)) Is ToolStripMenuItem Then
                    Call DesabilitaSubItens(pSubItem.DropDownItems.Item(x))
                End If
            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Private Sub txtSenha_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSenha.Enter
    End Sub
    Private Sub txtUsuario_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUsuario.Enter
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub GetMacAdress() '--- so teste
        For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            MessageBox.Show(String.Format("The MAC address of {0} is{1}{2}", nic.Description, Environment.NewLine, nic.GetPhysicalAddress()))
        Next
    End Sub

    Private Sub ucOkCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucOkCancel.Load

    End Sub
End Class
