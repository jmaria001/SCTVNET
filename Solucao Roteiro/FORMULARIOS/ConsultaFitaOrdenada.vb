Option Strict Off
Option Explicit On
Friend Class frmConsultaFitaOrdenada
	Inherits System.Windows.Forms.Form
    Dim asmxFita_Ordenada As MSAClass.AsmxFita_Ordenada.asmxFita_Ordenada
    'Dim dtsFitaOrdenada As New MSAClass.AsmxFita_Ordenada.dtsFitaOrdenada
    Dim dtbFitaOrdenada As New DataTable()
	Dim MouseX As Short
	Dim MouseY As Short
	Private Sub CarregaGrid()
        On Error GoTo Erro
        Dim nForecolor As System.Drawing.Color
        Dim dtDataInicio As DateTime
        Dim dtDataFim As DateTime
        Dim nNumero_Mr As Long
        Dim nSequencia_Mr As Integer



        If dteDataInicio.Text <> "" Then
            dtDataInicio = dteDataInicio.Text
        Else
            dtDataInicio = DateTime.MinValue
        End If

        If UcText3.Text <> "" Then
            dtDataFim = DateTime.Parse(UcText3.Text)
        Else
            dtDataFim = DateTime.MinValue
        End If

        If txtContrato.Text.Trim = "" Then
            nNumero_Mr = -1
        Else
            nNumero_Mr = Long.Parse(txtContrato.Text)
        End If

        If txtSequencia.Text.Trim = "" Then
            nSequencia_Mr = -1
        Else
            nSequencia_Mr = Integer.Parse(txtSequencia.Text)
        End If

        Call ConfiguraGrid()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor



        'Me.dtsFitaOrdenada = Me.asmxFita_Ordenada.spuCarregar(ucVeiculo.Text.Trim, ucPrograma.Text.Trim, dtDataInicio, dtDataFim, txtFitaInicio.Text.Trim, txtFitaFim.Text.Trim, "", txtEmpresa.Text.Trim, nNumero_Mr, nSequencia_Mr)
        ' Me.dtsFitaOrdenada = Me.asmxFita_Ordenada.spuCarregar(ucVeiculo.Text.Trim, ucPrograma.Text.Trim, "2016-05-01", "2016-05-01", txtFitaInicio.Text.Trim, txtFitaFim.Text.Trim, "", txtEmpresa.Text.Trim, nNumero_Mr, nSequencia_Mr)
        Me.dtbFitaOrdenada = Me.asmxFita_Ordenada.spuCarregar(ucVeiculo.Text.Trim, ucPrograma.Text.Trim, dtDataInicio, dtDataFim, txtFitaInicio.Text.Trim, txtFitaFim.Text.Trim, "", txtEmpresa.Text.Trim, nNumero_Mr, nSequencia_Mr)
        nLin = 0
        With flxConsulta
            .Visible = False

            'For Each DRW As MSAClass.AsmxFita_Ordenada.dtsFitaOrdenada.dtbFita_OrdenadaRow In dtsFitaOrdenada.Tables(0).Select()
            For Each drw As DataRow In dtbFitaOrdenada.Rows
                Mensagem("Carregando...." & nLin)
                nLin = nLin + 1
                If nLin >= .Rows - 1 Then
                    .Rows = .Rows + 1
                End If


                .set_TextMatrix(nLin, 1, Vernulo(drw.Item("Numero_Fita"), ""))
                .set_TextMatrix(nLin, 2, Vernulo(drw.Item("Cod_Veiculo"), ""))
                .set_TextMatrix(nLin, 3, FormataData(drw.Item("Data_Exibicao").ToString))

                .set_TextMatrix(nLin, 4, Vernulo(drw.Item("Cod_Programa"), ""))

                If Vernulo(drw.Item("Cod_Comercial"), "") <> "" And Vernulo(drw.Item("Titulo"), "") <> "" Then
                    .set_TextMatrix(nLin, 5, Trim(drw.Item("Cod_Comercial") & " - " & FirstCaps(Vernulo(drw.Item("Titulo"), ""))))
                ElseIf Vernulo(drw.Item("Titulo"), "") <> "" Then
                    .set_TextMatrix(nLin, 5, FirstCaps(Vernulo(drw.Item("Titulo"), "")))
                End If

                .set_TextMatrix(nLin, 6, Vernulo(drw.Item("Duracao"), ""))
                .set_TextMatrix(nLin, 7, Vernulo(drw.Item("Breaks"), ""))
                .set_TextMatrix(nLin, 8, Vernulo(drw.Item("Posicao"), ""))
                If Vernulo(drw.Item("Cod_Empresa"), "") <> "" Then .set_TextMatrix(nLin, 10, drw.Item("Cod_Empresa"))

                If Vernulo(drw.Item("Numero_Mr"), 0) <> 0 Then
                    .set_TextMatrix(nLin, 11, Vernulo(drw.Item("Numero_Mr"), ""))
                Else
                    .set_TextMatrix(nLin, 11, "")
                End If

                If Vernulo(drw.Item("Sequencia_Mr"), 0) <> 0 Then
                    .set_TextMatrix(nLin, 12, Vernulo(drw.Item("Sequencia_Mr"), ""))
                Else
                    .set_TextMatrix(nLin, 12, "")
                End If
                If Vernulo(drw.Item("Cod_Cliente"), "") <> "" Then
                    .set_TextMatrix(nLin, 13, drw.Item("Cod_Cliente") & " - " & drw.Item("Nome_Cliente"))
                End If
                If Vernulo(drw.Item("Cod_Agencia"), "") <> "" Then
                    .set_TextMatrix(nLin, 14, Vernulo(drw.Item("Cod_Agencia") & " - ", "") & Vernulo(drw.Item("Nome_Agencia"), ""))
                End If

                .set_TextMatrix(nLin, 15, Vernulo(drw.Item("Total_Net"), 0))
                If Vernulo(drw.Item("Total_Local"), 0) <> 0 Then .set_TextMatrix(nLin, 16, Vernulo(drw.Item("Total_Local"), 0))
                If Vernulo(drw.Item("Total_Pe"), "") <> 0 Then .set_TextMatrix(nLin, 17, Vernulo(drw.Item("Total_Pe"), 0))

                Select Case drw.Item("Tipo")
                    Case 0
                        nForecolor = Color.Blue
                        .set_TextMatrix(nLin, 9, "Local")
                    Case 1
                        nForecolor = Color.Magenta
                        .set_TextMatrix(nLin, 9, "Net")

                    Case 3
                        nForecolor = Color.Red
                        .set_TextMatrix(nLin, 9, "P.E.")
                End Select



                .Row = nLin
                For nCont = 1 To .Cols - 1
                    .Col = nCont
                    .CellForeColor = nForecolor
                Next nCont

            Next
            .Visible = True
            .TopRow = 1
            .Row = 1
            .Col = 1
            .ColSel = .Cols - 1
            Call flxConsulta_RowColChange(flxConsulta, New System.EventArgs())
        End With

        If nLin = 0 Then
            Aviso("Nenhum Registro foi Selecionado")
            GoTo Saida
        End If
        picFiltro.Visible = False

Saida:
        flxConsulta.Visible = True
        Mensagem("")
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume

    End Sub

    Private Sub ConfiguraGrid()

        On Error GoTo Erro


        With flxConsulta
            .Clear()
            .Rows = 25
            .RowHeightMin = 300
            .ScrollTrack = True
            .AllowBigSelection = False
            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .FormatString = "|N.Fita|Veiculo|Data|Programa|Comercial|Dur.|Break|Posicao|Tipo|Emp|Contrato|Seq.|Cliente|Agencia|Total Net|Total Local|Total Pe"

            .set_ColWidth(0, 330)
            .set_ColWidth(1, 750)
            .set_ColWidth(2, 645)
            .set_ColWidth(3, 1080)
            .set_ColWidth(4, 975)
            .set_ColWidth(5, 2895)
            .set_ColWidth(6, 525)
            .set_ColWidth(7, 540)
            .set_ColWidth(8, 660)
            .set_ColWidth(9, 900)
            .set_ColWidth(10, 405)
            .set_ColWidth(11, 975)
            .set_ColWidth(12, 390)
            .set_ColWidth(13, 0)
            .set_ColWidth(14, 0)
            .set_ColWidth(15, 0)
            .set_ColWidth(16, 0)
            .set_ColWidth(17, 0)


        End With



Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub cmdFiltro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFiltro.Click
        picFiltro.Visible = True
        picFiltro.BringToFront()
        ucVeiculo.Focus()
    End Sub

    Private Sub cmdFiltroLimpar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFiltroLimpar.Click
        txtFitaInicio.Text = ""
        txtFitaFim.Text = ""
        ucVeiculo.Text = ""
        ucPrograma.Text = ""
        UcText3.Text = ""
        dteDataInicio.Text = ""

    End Sub
	
    Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub
	
    Private Sub flxConsulta_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_MouseDownEvent) Handles flxConsulta.MouseDownEvent
        On Error GoTo Erro
        With flxConsulta
            If eventArgs.button = 2 And .MouseRow = 0 Then
                FlexOpcoes = flxConsulta
                .Col = .MouseCol
                frmOpcoesGrid.Text = Me.Text
                frmOpcoesGrid.txtColunaAtual.Text = .MouseCol.ToString
                mdiPrincipal.mnuOpcoesGrid.Show(Windows.Forms.Cursor.Position)

            End If
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub flxConsulta_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxConsulta.RowColChange
		On Error GoTo Erro

        With flxConsulta
            If Not .Visible Then GoTo Saida
            .ForeColorSel = .CellForeColor
        End With
		
		
		
Saida: 
		Exit Sub
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
    End Sub

    Private Sub frmConsultaFitaOrdenada_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

	Private Sub frmConsultaFitaOrdenada_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			System.Windows.Forms.SendKeys.Send("{tab}")
		Else
			KeyAscii = Asc(UCase(Chr(KeyAscii)))
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
    Private Sub frmConsultaFitaOrdenada_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Location = New System.Drawing.Point(15, 15)
        asmxFita_Ordenada = NewFita_Ordenada()
        Call ConfiguraGrid()
    End Sub
	
	
	Private Sub lblFiltro_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblFiltro.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		MouseX = X
		MouseY = Y
	End Sub
	
	Private Sub lblFiltro_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblFiltro.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		On Error GoTo Erro
		Dim VariacaoX As Single
		Dim VariacaoY As Single
		Dim MaxTop As Short
		Dim MaxLeft As Short
		
		With picFiltro
			If Button = 1 Then
				MaxTop = VB6.PixelsToTwipsY(Me.Height) - 700
				MaxLeft = (VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width)) - VB6.PixelsToTwipsX(.Width)
				VariacaoY = Y - MouseY
				VariacaoX = X - MouseX
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

    Private Sub txtContrato_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 32 And KeyAscii <> 8 Then
            KeyAscii = 0
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
    Private Sub txtEmpresa_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 32 And KeyAscii <> 8 Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	
    Private Sub txtFitaFim_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        seleciona_no_foco(Me.ActiveControl)
    End Sub
	
	
    Private Sub txtFitaInicio_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        seleciona_no_foco(Me.ActiveControl)
    End Sub

    Private Sub txtSequencia_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii < 48 Or KeyAscii > 57) And KeyAscii <> 32 And KeyAscii <> 8 Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub flxConsulta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flxConsulta.Enter

    End Sub

    Private Sub frmConsultaFitaOrdenada_MaximizedBoundsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub

    Private Sub picFiltro_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picFiltro.Paint

    End Sub

    Private Sub txtSequencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dteDataInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UcButton1_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcButton1.Cancel_Click
        picFiltro.Visible = False
    End Sub

    Private Sub UcButton1_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcButton1.Ok_Click

        Try

        

            ucVeiculo.Text = Trim(ucVeiculo.Text)
            ucPrograma.Text = Trim(ucPrograma.Text)
            dteDataInicio.Text = Trim(dteDataInicio.Text)
            UcText3.Text = Trim(UcText3.Text)
            txtFitaInicio.Text = Trim(txtFitaInicio.Text)
            txtFitaFim.Text = Trim(txtFitaFim.Text)
            If txtFitaInicio.Text <> "" And txtFitaFim.Text = "" Then
                txtFitaFim.Text = txtFitaInicio.Text
            End If

            If ucVeiculo.Text = "" Then
                Aviso("Código do veiculo deve ser informado")
                Exit Try
            End If

            Call CarregaGrid()
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

 
End Class