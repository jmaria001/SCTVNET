Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmDadosAm
	Inherits System.Windows.Forms.Form
    Private DtsDadosAM As New MSAClass.AsmxAM.dtsDadosAM
    Private asmxAm As MSAClass.AsmxAM.asmxAM
    Private DtsAm As New MSAClass.AsmxAM.dtsAM
	Private Sub cmdRetornar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRetornar.Click
        Me.Dispose()
    End Sub

    Private Sub frmDadosAm_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        On Error GoTo erro
        If Trim(txtNumeroAM.Text) <> "" Then
            MostraDadosAM()
        End If
saida:
        Exit Sub
erro:
        Erro(Err.Number)
        Resume saida
    End Sub
    Private Sub ConfiguraGrid_DadosAM()
        With flxDados
            .Clear()
            .Visible = False
            .FixedRows = 2

            .FormatString = "^DE|^DE|^DE|^DE|^DE|>DE| |^PARA|^PARA|^PARA|^PARA|^PARA|^PARA|>PARA"
            .Rows = 20
            .Cols = 14
            .set_TextMatrix(1, 2, "Com.")
            .set_TextMatrix(1, 3, "Dur.")
            .set_TextMatrix(1, 0, "Data")
            .set_TextMatrix(1, 1, "Programa")
            .set_TextMatrix(1, 4, "Qual.")
            .set_TextMatrix(1, 5, "Valor")
            .set_TextMatrix(1, 6, " ")

            .set_TextMatrix(1, 9, "Com.")
            .set_TextMatrix(1, 10, "Dur.")
            .set_TextMatrix(1, 7, "Data")
            .set_TextMatrix(1, 8, "Programa")
            .set_TextMatrix(1, 11, "Qual.")
            .set_TextMatrix(1, 12, "Horario")
            .set_TextMatrix(1, 13, "Valor")

            .ScrollTrack = True

            .Row = 0
            .set_RowHeight(0, 300)
            For nCont = 0 To .Cols - 1
                .Col = nCont
                If .Col <> 6 Then
                    .CellFontSize = 10
                    .CellBackColor = .BackColorFixed
                    .CellForeColor = System.Drawing.Color.Blue
                End If
            Next

            .Row = 1
            .set_RowHeight(1, 300)
            For nCont = 0 To .Cols - 1
                .Col = nCont
                If .Col <> 6 Then
                    .CellFontSize = 8
                    .CellBackColor = .BackColorFixed
                    .CellForeColor = System.Drawing.Color.Black
                End If
            Next

            .set_ColWidth(0, 1000)
            .set_ColWidth(1, 1000)
            .set_ColWidth(2, 600)
            .set_ColWidth(3, 500)
            .set_ColWidth(4, 500)
            .set_ColWidth(5, 1355)
            .set_ColWidth(6, 195)

            .set_ColWidth(7, 1000)
            .set_ColWidth(8, 1000)
            .set_ColWidth(9, 600)
            .set_ColWidth(10, 500)
            .set_ColWidth(11, 500)
            .set_ColWidth(12, 750)
            .set_ColWidth(13, 1355)

            .MergeCells = MSFlexGridLib.MergeCellsSettings.flexMergeFree
            .set_MergeRow(0, True)
            .set_MergeCol(6, True)
            .set_TextMatrix(0, 6, " ")
            .Visible = True
        End With

    End Sub
	
	
	
	Private Sub MostraDadosAM()
		
		On Error GoTo Erro
		
		ConfiguraGrid_DadosAM()


        DtsDadosAM = AsmxAM.spuCarregarDadosAM(txtEmpresa.Text, txtNumeroAM.Text, Integer.Parse(txtContrato.Text), Byte.Parse(txtSequencia.Text))


        Dim nlinha As Short
        Dim nQtdfalhas As Short
        Dim nQtdSolucoes As Short
        Dim nValorFalhas As Decimal
        Dim nValorSolucoes As Decimal

        nlinha = 1

        With flxDados
            .Visible = False

            '===============Carregas as Falhas
            For Each drw As MSAClass.AsmxAM.dtsDadosAM.dtbAM_FalhasRow In DtsDadosAM.dtbAM_Falhas.Select("")
                nlinha = nlinha + 1
                If nlinha >= .Rows Then
                    .Rows = .Rows + 1
                End If


                .set_TextMatrix(nlinha, 0, drw.Data_Exibicao.ToString("dd/MM/yyyy"))
                .set_TextMatrix(nlinha, 1, drw.Cod_Programa.ToString)
                .set_TextMatrix(nlinha, 2, drw.Cod_Comercial.ToString)
                .set_TextMatrix(nlinha, 3, drw.Duracao.ToString())

                If Not drw.IsCod_QualidadeNull Then
                    .set_TextMatrix(nlinha, 4, drw.Cod_Qualidade)
                End If

                .set_TextMatrix(nlinha, 5, VB6.Format(Vernulo(drw.Valor,0), "#,##0.00"))

                nQtdfalhas = nQtdfalhas + 1
                nValorFalhas = nValorFalhas + drw.Valor
            Next

            '===============Carregas as Compensações

            nlinha = 1

            For Each drw As MSAClass.AsmxAM.dtsDadosAM.dtbAM_CompensacaoRow In DtsDadosAM.dtbAM_Compensacao.Select("")
                nlinha = nlinha + 1
                If nlinha >= .Rows Then
                    .Rows = .Rows + 1
                End If

                .set_TextMatrix(nlinha, 7, VB6.Format(drw.Data_Exibicao, "dd/mm/yyyy"))
                .set_TextMatrix(nlinha, 8, drw.Cod_Programa.ToString)
                .set_TextMatrix(nlinha, 9, drw.Cod_Comercial.ToString)
                .set_TextMatrix(nlinha, 10, drw.Duracao.ToString)

                If Not drw.IsCod_QualidadeNull Then
                    .set_TextMatrix(nlinha, 11, drw.Cod_Qualidade)
                End If

                If Not drw.IsHorario_ExibicaoNull Then
                    .set_TextMatrix(nlinha, 12, VB6.Format(drw.Horario_Exibicao, "hh:mm"))
                End If

                .set_TextMatrix(nlinha, 13, VB6.Format(drw.Valor, "#,##0.00"))


                nQtdSolucoes = nQtdSolucoes + 1
                nValorSolucoes = nValorSolucoes + Vernulo(drw.Valor, 0)

                .TopRow = 2
                .Visible = True
            Next
        End With

        If VB.Left(txtNumeroAM.Text, 2) = "AM" Then

            lblFatura.Visible = True
            lblCarta.Visible = True
        End If


        txtQtdCompensado.Text = CStr(nQtdSolucoes)
        txtQtdFalhas.Text = CStr(nQtdfalhas)
        txtTotalCompensado.Text = VB6.Format(nValorSolucoes, "#,##0.00")
        txtTotalFalhas.Text = VB6.Format(nValorFalhas, "#,##0.00")

        If nValorFalhas - nValorSolucoes < 0 Then
            txtDiferenca.Text = "( " & VB6.Format(nValorFalhas - nValorSolucoes, "#,##0.00") & " )"
            txtDiferenca.ForeColor = System.Drawing.Color.Red
        Else
            txtDiferenca.Text = VB6.Format(nValorFalhas - nValorSolucoes, "#,##0.00")
            txtDiferenca.ForeColor = System.Drawing.Color.Blue
        End If


        DtsAM = AsmxAM.spuCarregar(txtEmpresa.Text, Integer.Parse(txtContrato.Text), Integer.Parse(txtSequencia.Text), txtNumeroAM.Text)


        For Each drw As MSAClass.AsmxAM.dtsAM.dtbAMRow In DtsAm.dtbAM.Select("")


            If drw.Numero_Fatura <> 0 Then
                lblFatura.Text = "Considerada na Fatura " & drw.Numero_Fatura
            End If


            If drw.Numero_Carta <> 0 Then
                lblCarta.Text = "Considerada na Carta de Crédito " & drw.Numero_Carta
            End If



            txtSolucao.Text = drw.Solucao.Trim()



            If txtSolucao.Text <> "" Then
                If Not drw.Cod_Usuario.ToString = "" Then
                    txtUsuario.Text = drw.Cod_Usuario
                End If


                If Not drw.IsData_EncerramentoNull Then
                    txtDataEncerramento.Text = Format(drw.Data_Encerramento, "dd/MM/yyyy hh:mm:ss")
                End If
            End If

            txtVeiculo.Text = drw.Cod_Veiculo

            lblSolucao.ForeColor = Color.Blue

            Select Case txtSolucao.Text
                Case "C"
                    lblSolucao.Text = "Creditar"

                Case "D"
                    lblSolucao.Text = "Deduzir"

                Case "F"
                    lblSolucao.Text = "Faturar"

                Case "P"
                    lblSolucao.Text = "Ponderar"

                Case "S"
                    lblSolucao.Text = "Faturar Sem Crédito"

                Case Else
                    lblSolucao.ForeColor = Color.Red
                    lblSolucao.Text = "Pendente"

            End Select

        Next


Saida:
        flxDados.Visible = True
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmDadosAm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Top = VB6.TwipsToPixelsY(630)
        Me.Left = VB6.TwipsToPixelsX(180)
        Me.asmxAm = NewAM()
        ConfiguraGrid_DadosAM()
    End Sub

    Private Sub txtSolucao_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSolucao.TextChanged

    End Sub
End Class