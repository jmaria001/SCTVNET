Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmRetorno_Play_List
	Inherits System.Windows.Forms.Form
    Dim bErroProcessamento As Boolean
	Dim nRegistro As Short
	Dim aValidacaoPosicao() As Object
	Dim aValidacaoTamanho() As Object
    Dim aValidacaoConteudo() As Object
    Dim asmxRetornoPlayList As MSAClass.AsmxRetornoPlayList.asmxRetornoPlayList
    Dim dtsRetornoPlayList As New MSAClass.AsmxRetornoPlayList.dtsRetornoPlayList
    Dim asmxVeiculo As MSAClass.AsmxVeiculo.asmxVeiculo
    Dim dtsVeiculo As New MSAClass.AsmxVeiculo.dtsVeiculo


    Private Sub Leitura_Log_Layout(ByRef Par_Arquivo As String)
        On Error GoTo Erro
        Dim nBuf As Short
        Dim bValido As Boolean
        Dim sLinha As String = ""
        Dim sDuracao As String
        Dim sFormato As String = ""

        Dim sFita As String
        Dim sData As String
        Dim sHorario As String
        Dim sTitulo As String
        Dim nDuracao As Integer
        Dim nPosicaoData As Short
        Dim nTamanhoData As Short
        Dim nPosicaoHorario As Short
        Dim nTamanhoHorario As Short
        Dim nPosicaoFita As Short
        Dim ntamanhofita As Short
        Dim nPosicaoTitulo As Short
        Dim nTamanhoTitulo As Short
        Dim nPosicaoDuracao As Short
        Dim nTamanhoDuracao As Short
        Dim dtData As DateTime


        ReDim aValidacaoPosicao(0)
        ReDim aValidacaoTamanho(0)
        ReDim aValidacaoConteudo(0)

        Dim srFileReader As System.IO.StreamReader

        nRegistro = 0

        nBuf = FreeFile()
        '=====================================Le os Parametros do Layout
        Mensagem("Aguarde... Incluindo Dados da Integração (" & Par_Arquivo & ")")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.DtsRetornoPlayList = AsmxRetornoPlayList.spuCarregarLayout(ucveiculo.text)
        If DtsRetornoPlayList.dtbLayoutRetorno.Select().Length = 0 Then
            Aviso("Não existe Layout para o Veículo" & ucveiculo.text)
            bErroProcessamento = True
            GoTo Saida
        End If

        nRegistro = -1

        For Each drw As MSAClass.AsmxRetornoPlayList.dtsRetornoPlayList.dtbLayoutRetornoRow In dtsRetornoPlayList.dtbLayoutRetorno.Rows
            If drw.Indica_Validacao = 0 Then
                Select Case drw.Campo.Trim.ToUpper
                    Case "DATA"
                        nPosicaoData = drw.Posicao
                        nTamanhoData = drw.Tamanho
                    Case "HORARIO"
                        nPosicaoHorario = drw.Posicao
                        nTamanhoHorario = drw.Tamanho
                    Case "FITA"
                        nPosicaoFita = drw.Posicao
                        ntamanhofita = drw.Tamanho
                    Case "TITULO"
                        nPosicaoTitulo = drw.Posicao
                        nTamanhoTitulo = drw.Tamanho
                    Case "DURACAO"
                        nPosicaoDuracao = drw.Posicao
                        nTamanhoDuracao = drw.Tamanho
                    Case "FORMATO"
                        sFormato = drw.Conteudo.Trim
                End Select
            Else
                nRegistro = nRegistro + 1
                ReDim Preserve aValidacaoPosicao(nRegistro)
                ReDim Preserve aValidacaoTamanho(nRegistro)
                ReDim Preserve aValidacaoConteudo(nRegistro)
                aValidacaoPosicao(nRegistro) = drw.Posicao
                aValidacaoTamanho(nRegistro) = drw.Tamanho
                aValidacaoConteudo(nRegistro) = drw.Conteudo
            End If
        Next


        '=====================================Inicia leitura do arquivo texto
        nRegistro = 0

        'FileOpen(nBuf, Par_Arquivo, OpenMode.Input)

        srFileReader = System.IO.File.OpenText(Par_Arquivo)
        'Do Until EOF(nBuf)
        sLinha = srFileReader.ReadLine()
        Do Until sLinha Is Nothing


            'sLinha = LineInput(nBuf)


            bValido = True

            sData = ""
            sHorario = ""
            sFita = ""
            sTitulo = ""

            If nPosicaoData <> 0 Then sData = Mid(sLinha, nPosicaoData, nTamanhoData)
            If nPosicaoHorario <> 0 Then sHorario = Mid(sLinha, nPosicaoHorario, nTamanhoHorario)
            If nPosicaoFita <> 0 Then sFita = Mid(sLinha, nPosicaoFita, ntamanhofita)
            If nPosicaoTitulo <> 0 Then
                sTitulo = Mid(sLinha, nPosicaoTitulo, nTamanhoTitulo)
                sTitulo = Replace(sTitulo, "'", " ")
            End If

            If nPosicaoDuracao <> 0 Then
                sDuracao = VB6.Format(Mid(sLinha, nPosicaoDuracao, nTamanhoDuracao), "hh:mm:ss")
                nDuracao = Val(Mid(sDuracao, 1, 2)) * 3600
                nDuracao = nDuracao + Val(Mid(sDuracao, 4, 2)) * 60
                nDuracao = nDuracao + Val(Mid(sDuracao, 7, 2))
            End If

            sFita = UCase(Trim(sFita))

            Select Case UCase(sFormato)
                Case "DD/MM/YYYY"
                Case "MM/DD/YYYY"
                    sData = Replace(sData, "/", "")
                    sData = Mid(sData, 3, 2) & "/" & Mid(sData, 1, 2) & "/" & Mid(sData, 5, 4)
                Case "YYYY/MM/DD"
                    sData = Replace(sData, "/", "")
                    sData = Mid(sData, 7, 2) & "/" & Mid(sData, 5, 2) & "/" & Mid(sData, 1, 4)
                Case "DD/MM/YY"
                    sData = Replace(sData, "/", "")
                    sData = Mid(sData, 1, 2) & "/" & Mid(sData, 3, 2) & "/" & Mid(sData, 5, 2)
                Case "MM/DD/YY"
                    sData = Replace(sData, "/", "")
                    sData = Mid(sData, 3, 2) & "/" & Mid(sData, 1, 2) & "/" & Mid(sData, 5, 2)
                Case "YY/MM/DD"
                    sData = Replace(sData, "/", "")
                    sData = Mid(sData, 5, 2) & "/" & Mid(sData, 3, 2) & "/" & Mid(sData, 1, 2)
            End Select


            For nCont = 0 To UBound(aValidacaoPosicao)
                If aValidacaoPosicao(nCont) > 0 Then
                    If UCase(Trim(Mid(sLinha, aValidacaoPosicao(nCont), aValidacaoTamanho(nCont)))) <> UCase(Trim(aValidacaoConteudo(nCont))) Then
                        bValido = False
                    End If
                End If
            Next nCont


            If bValido Then
                dtData = DateTime.Parse(sData & " " & sHorario)
                If dtData < UcDataInicio.DateTime Then
                    bValido = False
                End If
            End If

            If bValido Then
                If dtData > UcDataFim.DateTime Then
                    bValido = False
                End If
            End If

            If bValido Then
                If VB.Left(Trim(sFita), 2) <> "CO" And VB.Left(Trim(sFita), 2) <> "AR" Then
                    For nCont = 1 To Len(sFita)
                        If Asc(Mid(sFita, nCont, 1)) < 48 Or Asc(Mid(sFita, nCont, 1)) > 57 Then
                            bValido = False
                            Exit For
                        End If
                    Next
                End If
            End If
            If Trim(sFita) = "" Then
                bValido = False
            End If


            If bValido Then
                nRegistro = nRegistro + 1
                If VB.Left(sFita, 2) <> "CO" And VB.Left(sFita, 2) <> "AR" Then
                    sFita = "CO" & StrZero(sFita, 4)
                End If
                Mensagem("Processando (" & Par_Arquivo & ") - Linhas: " & nRegistro)
                Me.dtsRetornoPlayList.dtbRetorno_playlist.AdddtbRetorno_playlistRow(ucVeiculo.Text, sFita, Replace(sTitulo, "'", " "), UcData.DateTime, sHorario, nDuracao)
            End If
            sLinha = srFileReader.ReadLine()
        Loop
        Me.asmxRetornoPlayList.spuAtualizar(dtsRetornoPlayList)

Saida:
        FileClose(nBuf)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")
        Exit Sub
Erro:
        bErroProcessamento = True
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	

    Private Sub cmdCaminho_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCaminho.Click
        mdiPrincipal.OpenPrincipal.ShowDialog 
        If Trim(txtCaminho.Text) = "" Then
            txtCaminho.Text = mdiPrincipal.OpenPrincipal.FileName
        Else
            txtCaminho.Text = Trim(txtCaminho.Text) & ";" & mdiPrincipal.OpenPrincipal.FileName
        End If

    End Sub

    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Me.Dispose()
    End Sub

    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click

        On Error GoTo Erro
        Dim aArquivos() As String
        Dim nArq As Short
        Dim sTemp As String
        Dim nProcura As Short
        '----------------------------------Consiste Veiculo
        If ucveiculo.text.Trim = "" Then
            Aviso("Veículo não foi informado")
            UcVeiculo.Focus()
            GoTo Saida
        End If
        '----------------------------------Consiste Data
        If UcData.Text.Trim = "" Or UcData.DateTime = Date.MinValue Then
            Aviso("Data de exibição inválida")
            UcData.Focus()
            GoTo Saida
        End If
        '----------------------------------Consiste Diretorio
        If txtCaminho.Text.Trim = "" Then
            txtCaminho.Focus()
            Aviso("Caminho do arquivo não pode ficar em branco.")
            GoTo Saida
        End If
        '----------------------------------Consiste Periodo do Log
        If UcDataInicio.DateTime > UcDataFim.DateTime Then
            Aviso("Data/Hora  Inicio não pode ser maior que Data/Hora Fim")
            GoTo Saida
        End If

        '----------------------------------Carrega Arquivos Solicitados na Matriz
        sTemp = Trim(txtCaminho.Text)
        If VB.Right(sTemp, 1) <> ";" Then
            sTemp = sTemp & ";"
        End If

        nArq = -1
        ReDim aArquivos(0)
        Do
            nCont = InStr(sTemp, ";")
            If nCont = 0 Then Exit Do
            For nProcura = 0 To UBound(aArquivos)
                If aArquivos(nProcura) = VB.Left(sTemp, nCont - 1) Then
                    Aviso("O arquivo [" & aArquivos(nProcura) & "] foi selecionado mais de uma vez.")
                    GoTo Saida
                End If
            Next nProcura
            nArq = nArq + 1
            ReDim Preserve aArquivos(nArq)
            aArquivos(nArq) = VB.Left(sTemp, nCont - 1)
            sTemp = Mid(sTemp, nCont + 1)
        Loop

        '--------------------Apaga dados anteriores
        Me.AsmxRetornoPlayList.spuLimpar(ucveiculo.text)
        '-------------------------------> Leitura do Log  para cada arquivo selecionado
        For nArq = 0 To UBound(aArquivos)
            bErroProcessamento = False
            Me.Leitura_Log_Layout(aArquivos(nArq))
            If bErroProcessamento Then
                Aviso("Houve erro no Processamento")
                GoTo Saida
            End If
        Next nArq

        If nRegistro = 0 Then
            Aviso("Nenhum registro foi selecionado do(s) Arquivo(s) de Log.")
            GoTo Saida
        End If
        '------------------------------> Processa o Formulario de Baixa automatica

        frmBaixaAutomatica.txtVeiculo.Text = ucveiculo.text
        frmBaixaAutomatica.txtData_Exibicao.Text = UcData.Text
        frmBaixaAutomatica.Text = "Retorno da Exibiçao Digital ( Veiculo:" & ucveiculo.text & " Data: " & ucveiculo.text & ")"
        frmBaixaAutomatica.chkArtistico.Checked = chkArtistico.Checked
        frmBaixaAutomatica.chkAvulso.Checked = chkAvulso.Checked
        frmBaixaAutomatica.chkCarregar.Checked = True
        frmBaixaAutomatica.Show()

        '------------------Apaga arquivo de Retorno da Play-List
        Me.AsmxRetornoPlayList.spuLimpar(ucveiculo.text)

Saida:
        Mensagem("")
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub

Erro:
        Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub




    Private Function Calcula_Duracao(ByRef Duracao As String) As Short

        On Error GoTo Erro

        Dim nDuracao As Integer

        nDuracao = 0

        nDuracao = Val(CStr(CDbl(VB.Left(Duracao, 2)) * 60))

        'nDuracao = nDuracao + Val(Mid(Duracao, 4, 2) * 60)

        nDuracao = nDuracao + Val(VB.Right(Duracao, 2))

        Calcula_Duracao = nDuracao

Saida:
        Exit Function

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Function

    Private Sub frmRetorno_Play_List_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{TAB}")
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub



    Private Sub frmRetorno_Play_List_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.asmxRetornoPlayList = NewRetornoPlayList()
        Me.asmxVeiculo = NewVeiculo()
        Me.Size = New System.Drawing.Size(458, 392)
        Me.CenterToParent()
    End Sub

    Private Sub txtCaminho_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCaminho.Enter
        seleciona_no_foco(txtCaminho)
    End Sub


    Private Sub UcData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcData.Load
    End Sub

    Private Sub UcData_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcData.Validated

        On Error GoTo Erro
        If Not IsDate(UcData.DateTime) Then
            Aviso("data inválida. Digite novamente.")
            GoTo Saida
        End If
        UcDataInicio.DateTime = UcData.DateTime
        UcDataFim.DateTime = DateAdd(DateInterval.Day, 1, UcDataInicio.DateTime)
        txtHoraInicio.Text = txtHorarioEmissora.Text
        txtHoraFim.Text = formataHora(VB.Left(AddTime("M", -1, txtHoraInicio.Text), 5))
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
    End Sub

    Private Sub UcVeiculo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucVeiculo.Validated
        On Error GoTo Erro
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        txtHorarioEmissora.Text = ""
        If ucVeiculo.Text = "" Then
            GoTo Saida
        End If
        ucVeiculo.Text = StrZero(ucVeiculo.Text, 3)
        Me.dtsVeiculo = Me.asmxVeiculo.spuCarregar(ucVeiculo.Text)
        If Me.dtsVeiculo.dtbVeiculo.Select().Length = 0 Then
            GoTo saida
        End If
        txtHorarioEmissora.Text = Me.dtsVeiculo.dtbVeiculo(0).Hora_Inicio_Programacao
        txtSistemaDigital.Text = fParametro(68, , , ucVeiculo.Text)

        If txtSistemaDigital.Text = "" Then
            Aviso("Sistema de Exibição Digital nao parametrizado para este veiculo. (Parametro 68)")
            ucVeiculo.Focus()
            GoTo Saida
        End If

Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub txtHoraInicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHoraInicio.Validated
        On Error GoTo Erro
        Dim Cancel As Boolean

        txtHoraInicio.Text = txtHoraInicio.Text.Trim
        If txtHoraInicio.Text = "" Then
            GoTo Saida
        End If


        If Not isTime(txtHoraInicio.Text) Then
            Aviso("Horario Inválido")
            txtHoraInicio.Text = ""
            Cancel = True
            GoTo Saida
        End If

        txtHoraInicio.Text = formataHora(txtHoraInicio.Text)
        txtHoraFim.Text = formataHora(VB.Left(AddTime("M", -1, txtHoraInicio.Text), 5))


Saida:
        If Cancel Then
            txtHoraInicio.Focus()
        End If
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub txtHoraFim_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHoraFim.Validated
        On Error GoTo Erro
        Dim Cancel As Boolean = False
        txtHoraFim.Text = txtHoraFim.Text.Trim
        If txtHoraFim.Text = "" Then
            GoTo Saida
        End If

        If Not isTime(txtHoraFim.Text) Then
            Aviso("Horario Inválido")
            txtHoraFim.Text = ""
            Cancel = True
            GoTo Saida
        End If




        txtHoraFim.Text = formataHora(txtHoraFim.Text.Trim)

Saida:
        If Cancel Then
            txtHoraFim.Focus()
        End If
        Exit Sub
Erro:
        Erro(Err.Number)
        Cancel = True
        Resume Saida
        Resume
    End Sub

  
  
End Class