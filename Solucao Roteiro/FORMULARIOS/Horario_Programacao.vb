Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmHorarioProgramacao
    Inherits System.Windows.Forms.Form
    Dim asmxGrade As MSAClass.AsmxGrade.asmxGrade
    Dim dtsGrade As New MSAClass.AsmxGrade.dtsGrade

    Dim bValidaLinha As Boolean
    Dim MouseX, MouseY As Short
    Dim aVeiculos() As String
    Dim bErroProcessamento As Boolean
    Private Sub Grava(ByRef Par_Veiculo As String)

        On Error GoTo Erro
        Dim aColunas(2) As Object
        Dim aValores(2) As Object
        Dim nRow As Short
        Dim sPrograma As String
        Dim dData As String


        sPrograma = flxPrograma.get_TextMatrix(flxPrograma.Row, 0)

        aColunas(0) = "Horario_Inicial"
        aColunas(1) = "Horario_Final"
        aColunas(2) = "Cod_Faixa"

        dData = txtDataInicio.Text

        Do While VB6.Format(dData, "yyyy/mm/dd") <= VB6.Format(txtDataFim.Text, "yyyy/mm/dd")

            If chkDiaSemana(Weekday(CDate(dData))).CheckState = 1 Then
                Mensagem("Veiculo:" & Par_Veiculo & "  Dia:" & dData)
                AsmxGrade.spuSalva_Horario_Programacao(Par_Veiculo, _
                                                        UcData.Text, _
                                                        sPrograma, _
                                                        DateTime.Parse(dData & " " & txtHoraInicio.Text), _
                                                        DateTime.Parse(dData & " " & txtHoraFim.Text), _
                                                        txtHoraInicio.Text)

            End If
            dData = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, 1, CDate(dData)))
        Loop


Saida:

        Exit Sub
Erro:
        bErroProcessamento = True
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Sub Monta_Grade()

        On Error GoTo Erro
        With flxPrograma
            .Visible = False
            .Clear()
            .FormatString = "<Codigo|<Título|^Horário Inicio|^Horário Fim|Ordem"
            .set_ColWidth(0, 960)
            .set_ColWidth(1, 5490)
            .set_ColWidth(2, 1155)
            .set_ColWidth(3, 1125)
            .set_ColWidth(4, 0)


            .ScrollTrack = True
            .Rows = 20
            .AllowBigSelection = False
            .RowHeightMin = 285
            .Row = 1
            .Col = 0

            .Visible = True
            flxPrograma_RowColChange(flxPrograma, New System.EventArgs())


        End With



Saida:
        flxPrograma.Visible = True
        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub
    Private Sub cmdAlterar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAlterar.Click
        With flxPrograma
            txtHoraInicio.Text = .get_TextMatrix(.Row, 2)
            txtHoraFim.Text = .get_TextMatrix(.Row, 3)
            txtDataInicio.Text = UcData.Text
            txtDataFim.Text = UcData.Text
            picParametro.Visible = True
            txtHoraInicio.Focus()
        End With
    End Sub
    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Dim Index As Short = cmdCancela.GetIndex(eventSender)
        txtHoraInicio.Text = ""
        txtHoraFim.Text = ""
        txtDataInicio.Text = ""
        txtDataFim.Text = ""
        For nCont = 1 To chkDiaSemana.Count
            chkDiaSemana(nCont).CheckState = System.Windows.Forms.CheckState.Unchecked
        Next nCont
        picParametro.Visible = False
    End Sub
    Private Sub cmdExibir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExibir.Click



        Dim nCont As Short
        Dim nHorarioEmissora As Short
        Dim nHorarioprograma As Short
        Dim sHorarioPrograma As String
        Try


            If Trim(ucVeiculo.Text) = "" Then
                Aviso("Veículo não pode ficar em branco.")
                ucVeiculo.Focus()
                Exit Try
            End If

            'If Not isData(ucData.text) Then
            'Aviso("Data Inválida. Digite novamente.")
            'UcData.Focus()
            'GoTo Saida
            'End If

            Call Monta_Grade()

            Dim drwHoraria As MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow()
            drwHoraria = mdiPrincipal.dtsUsuario.dtbUsuario_Veiculo.Select("Cod_Veiculo = " & ucVeiculo.Text)

            If Not drwHoraria(0).IsHora_Inicio_ProgramacaoNull Then
                nHorarioEmissora = Val(CStr(CDbl(VB.Left(drwHoraria(0).Hora_Inicio_Programacao, 2)) * 60)) + Val(VB.Right(drwHoraria(0).Hora_Inicio_Programacao, 2))
            Else
                nHorarioEmissora = 0
            End If

            Me.Cursor = Cursors.WaitCursor

            dtsGrade = asmxGrade.spuCarregar_Grade(ucVeiculo.Text, UcData.Text, "")

            nCont = 0

            With flxPrograma
                .Rows = 1
                .Visible = False

                For Each drw As MSAClass.AsmxGrade.dtsGrade.dtbGradeRow In dtsGrade.dtbGrade.Rows
                    nCont = nCont + 1
                    If .Rows <= nCont Then
                        .Rows = .Rows + 1
                    End If

                    .set_TextMatrix(nCont, 0, drw.Cod_Programa)
                    .set_TextMatrix(nCont, 1, FirstCaps(drw.Titulo.Trim))
                    .set_TextMatrix(nCont, 2, formataHora(drw.Horario_Inicial.ToShortTimeString))
                    .set_TextMatrix(nCont, 3, formataHora(drw.Horario_Final.ToShortTimeString))
                    sHorarioPrograma = formataHora(drw.Horario_Inicial.ToShortTimeString)

                    nHorarioprograma = (Val(VB.Left(sHorarioPrograma, 2)) * 60) + Val(VB.Right(sHorarioPrograma, 2))

                    If nHorarioprograma < nHorarioEmissora Then
                        nHorarioprograma = 1440 + nHorarioprograma
                    End If
                    .set_TextMatrix(nCont, 4, StrZero(nHorarioprograma, 6))
                Next


                .Col = 4
                .Sort = MSFlexGridLib.SortSettings.flexSortGenericAscending

                If .Rows < 20 Then
                    .Rows = 20
                End If

                .Visible = True
                .Row = 1
                flxPrograma_RowColChange(flxPrograma, New System.EventArgs())

            End With


        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default

        End Try

    End Sub


    Private Sub cmdOkParametro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOkParametro.Click


        On Error GoTo Erro
        Dim bInformouSemana As Boolean

        Dim sData, sMensagem, sHorarioAnterior As String
        Dim nRow1, nVei As Short

        If ucVeiculo.Text = "" Then
            Aviso("Veículo não foi Informado")
            GoTo Saida
        End If

        If Trim(txtHoraInicio.Text) = "" Then
            Aviso("Horario Inicial não foi Informado")
            txtHoraInicio.Focus()
            GoTo Saida
        End If

        If Trim(txtHoraFim.Text) = "" Then
            Aviso("Horario Final não foi Informado")
            txtHoraFim.Focus()
            GoTo Saida
        End If

        If Trim(txtDataInicio.Text) = "" Then
            Aviso("Início do Periodo não foi Informado")
            txtDataInicio.Focus()
            GoTo Saida
        End If

        If Trim(txtDataFim.Text) = "" Then
            Aviso("Fim do Periodo não foi Informado")
            txtDataFim.Focus()
            GoTo Saida
        End If

        bInformouSemana = False
        For nCont = 1 To chkDiaSemana.Count
            If chkDiaSemana(nCont).CheckState = 1 Then
                bInformouSemana = True
                Exit For
            End If
        Next nCont

        If Not bInformouSemana Then
            Aviso("Nenhum dia de Semana foi Informado")
            GoTo Saida
        End If

        Me.Cursor = Cursors.WaitCursor

        bErroProcessamento = False
        Call Grava(ucVeiculo.Text)
        If bErroProcessamento Then GoTo Saida

        For nVei = 0 To lstVeiculo.Items.Count - 1
            If lstVeiculo.GetItemChecked(nVei) Then
                Call Grava(aVeiculos(nVei))
                If bErroProcessamento Then GoTo Saida
            End If
        Next nVei


        Me.Cursor = Cursors.Default

        Mensagem("")


        Aviso("Horário gravado com sucesso.")

        Call Monta_Grade()
        cmdExibir_Click(cmdExibir, New System.EventArgs())
        Call cmdCancela_Click(cmdCancela.Item(0), New System.EventArgs())


Saida:
        Exit Sub
Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub

    Private Sub cmdReplicar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReplicar.Click

        picVeiculo.Visible = True
        picVeiculo.BringToFront()

    End Sub

    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Dispose()
    End Sub

    Private Sub cmdSelecaoVeiculo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelecaoVeiculo.Click
        Dim Index As Short = cmdSelecaoVeiculo.GetIndex(eventSender)
        picVeiculo.Visible = False
    End Sub

    Private Sub flxPrograma_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxPrograma.RowColChange
        On Error GoTo Erro
        With flxPrograma
            If Not .Visible Then
                GoTo Saida
            End If

            cmdAlterar.Enabled = .get_TextMatrix(.Row, 0) <> ""
            .Col = 0
            .ColSel = .Cols - 1

        End With
Saida:
        Exit Sub
Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume
    End Sub


    'UPGRADE_WARNING: Form event frmHorarioProgramacao.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmHorarioProgramacao_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        flxPrograma_RowColChange(flxPrograma, New System.EventArgs())
    End Sub

    Private Sub frmHorarioProgramacao_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{tab}")
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub CarregaVeiculosDoUsuario()

        On Error GoTo Erro
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        For Each drw As MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow In mdiPrincipal.dtsUsuario.dtbUsuario_Veiculo.Rows
            lstVeiculo.Items.Add(drw.Cod_Veiculo & "-" & drw.Nome_Veiculo)
            ReDim Preserve aVeiculos(lstVeiculo.Items.Count - 1)
            aVeiculos(lstVeiculo.Items.Count - 1) = drw.Cod_Veiculo
        Next


Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida


    End Sub



    Private Sub frmHorarioProgramacao_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        On Error GoTo Erro
        Me.Top = 0
        Me.Left = 0

        With picVeiculo
            .Top = VB6.TwipsToPixelsY(1020)
            .Left = VB6.TwipsToPixelsX(675)
            .Width = VB6.TwipsToPixelsX(6990)
            .Height = VB6.TwipsToPixelsY(3060)
            .Visible = False
        End With
        ReDim aVeiculos(0)

        asmxGrade = NewGrade()

        Call CarregaVeiculosDoUsuario()
        Call Monta_Grade()



Saida:

        Exit Sub

Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

    End Sub

    Private Sub lblParametro_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblParametro.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = x
        MouseY = y
    End Sub


    Private Sub lblParametro_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblParametro.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        On Error GoTo Erro
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        Dim MaxTop As Short
        Dim MaxLeft As Short

        With picParametro
            If Button = 1 Then
                MaxTop = VB6.PixelsToTwipsY(Me.Height) - 700
                MaxLeft = (VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width)) - VB6.PixelsToTwipsX(.Width)
                VariacaoY = y - MouseY
                VariacaoX = x - MouseX
                If VB6.PixelsToTwipsY(.Top) + VariacaoY > 0 And VB6.PixelsToTwipsY(.Top) + VariacaoY < MaxTop Then
                    .Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + VariacaoY)
                End If
                If VB6.PixelsToTwipsX(.Left) + VariacaoX > 0 And VB6.PixelsToTwipsX(.Left) + VariacaoX < MaxLeft Then
                    .Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + VariacaoX)
                End If
            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida

    End Sub


    Private Sub lblSelecaoVeiculo_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblSelecaoVeiculo.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        MouseX = x
        MouseY = y
    End Sub

    Private Sub lblSelecaoVeiculo_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblSelecaoVeiculo.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        On Error GoTo Erro
        Dim VariacaoX As Single
        Dim VariacaoY As Single
        Dim MaxTop As Short
        Dim MaxLeft As Short

        With picVeiculo
            If Button = 1 Then
                MaxTop = VB6.PixelsToTwipsY(Me.Height) - 700
                MaxLeft = (VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width)) - VB6.PixelsToTwipsX(.Width)
                VariacaoY = y - MouseY
                VariacaoX = x - MouseX
                If VB6.PixelsToTwipsY(.Top) + VariacaoY > 0 And VB6.PixelsToTwipsY(.Top) + VariacaoY < MaxTop Then
                    .Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + VariacaoY)
                End If
                If VB6.PixelsToTwipsX(.Left) + VariacaoX > 0 And VB6.PixelsToTwipsX(.Left) + VariacaoX < MaxLeft Then
                    .Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(.Left) + VariacaoX)
                End If
            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida


    End Sub


 


    Private Sub txtDataInicio_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDataInicio.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        If Trim(txtDataInicio.Text) = "" Then GoTo Saida
        If Not isData(formataData(txtDataInicio.Text)) Then
            Aviso("data inválida. digite novamente.")
            seleciona_no_foco(txtDataInicio)
            Cancel = True
            GoTo Saida
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object formataData(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtDataInicio.Text = formataData(txtDataInicio.Text)
Saida:
        GoTo EventExitSub
Erro:
        If Err.Number <> 0 Then Erro(Err.Number)
        GoTo Saida
        Resume

EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub


   

    Private Sub txtHoraInicio_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHoraInicio.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        txtHoraInicio.Text = Trim(txtHoraInicio.Text)
        If txtHoraInicio.Text = "" Then
            GoTo Saida
        End If

        If Not isTime(txtHoraInicio.Text) Then
            Aviso("Horário Inválido")
            Cancel = True
            GoTo Saida
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object formataHora(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtHoraInicio.Text = formataHora(txtHoraInicio.Text)

Saida:
        bValidaLinha = Not Cancel
        If Cancel Then
            txtHoraInicio.Text = ""
        End If
        GoTo EventExitSub

Erro:
        Cancel = True
        Erro(Err.Number)
        GoTo Saida
        Resume
EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub




    Private Sub txtHoraFim_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtHoraFim.Validating
        Dim Cancel As Boolean = eventArgs.Cancel

        On Error GoTo Erro

        txtHoraFim.Text = Trim(txtHoraFim.Text)
        If txtHoraFim.Text = "" Then
            GoTo Saida
        End If

        If Not isTime(txtHoraFim.Text) Then
            Aviso("Horário Inválido")
            Cancel = True
            GoTo Saida
        End If

        txtHoraFim.Text = formataHora(txtHoraFim.Text)

Saida:
        bValidaLinha = Not Cancel
        If Cancel Then
            txtHoraFim.Text = ""
        End If
        GoTo EventExitSub

Erro:
        Cancel = True
        Erro(Err.Number)
        GoTo Saida
        Resume

EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub


   
End Class