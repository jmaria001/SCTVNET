Option Strict Off
Option Explicit On
Friend Class frmComparaRoteiroData
	Inherits System.Windows.Forms.Form
	
	Private Sub CarregaListVeiculos()
        On Error GoTo Erro
        lstVeiculos.ClearSelected()
        For Each drw As MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_VeiculoRow In mdiPrincipal.dtsUsuario.dtbUsuario_Veiculo.Rows
            lstVeiculos.Items.Add(drw.Cod_Veiculo & "-" & drw.Nome_Veiculo)
        Next
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Me.Dispose()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        On Error GoTo Erro
        Dim nVeiculo As Short
        Dim strVeiculo As String
        Dim nForm As Short
        Dim FormMostraRoteiro As frmComparaRoteiroV2 = Nothing
        Dim nAltura As Short
        Dim nTamanho As Short

        If UcData.Text.Trim = "" Then
            Aviso("Data deve ser Informada")
            GoTo Saida
        End If

        With lstVeiculos
            For nVeiculo = 0 To .Items.Count - 1
                If .GetItemChecked(nVeiculo) Then
                    nForm = nForm + 1
                End If
            Next
        End With

        If nForm = 0 Then
            Aviso("Nenhum Veiculo foi informado'")
            GoTo Saida
        End If

        If nForm < 3 Then
            nAltura = 9870
        Else
            nAltura = 5000
        End If

        If nForm = 1 Then
            nTamanho = 11790
        Else
            nTamanho = 7500
        End If


        nForm = 0
        strListaVeiculos = ""
        With lstVeiculos
            For nVeiculo = 0 To .Items.Count - 1
                If .GetItemChecked(nVeiculo) Then
                    strVeiculo = Mid(.Items.Item(nVeiculo), 1, 3)
                    Mensagem("Carregando Veiculo " & Trim(VB6.GetItemString(lstVeiculos, nVeiculo)))
                    nForm = nForm + 1
                    FormMostraRoteiro = New frmComparaRoteiroV2
                    FormMostraRoteiro.Text = Space(10) & strVeiculo & " (" & UcData.DateTime & ")"
                    FormMostraRoteiro.lblVeiculo.Text = .Items.Item(nVeiculo)
                    FormMostraRoteiro.txtVeiculo.Text = strVeiculo
                    FormMostraRoteiro.txtData.Text = UcData.DateTime.ToString
                    FormMostraRoteiro.txtPrograma.Text = ucPrograma.Text
                    FormMostraRoteiro.chkMostrarRoteiro.Checked = True
                    FormMostraRoteiro.Height = VB6.TwipsToPixelsY(nAltura)
                    Select Case nForm
                        Case 1
                            FormMostraRoteiro.Top = 0
                            FormMostraRoteiro.Left = 0
                        Case 2
                            FormMostraRoteiro.Top = 0
                            FormMostraRoteiro.Left = VB6.TwipsToPixelsX(7560)
                        Case 3
                            FormMostraRoteiro.Top = VB6.TwipsToPixelsY(5000)
                            FormMostraRoteiro.Left = 0
                        Case 4
                            FormMostraRoteiro.Top = VB6.TwipsToPixelsY(5000)
                            FormMostraRoteiro.Left = VB6.TwipsToPixelsX(7560)
                        Case Else
                    End Select
                    FormMostraRoteiro.Width = VB6.TwipsToPixelsX(nTamanho)
                    FormMostraRoteiro.Show()
                    strListaVeiculos = strListaVeiculos & strVeiculo
                End If
            Next nVeiculo
        End With

        Me.Dispose()

Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmComparaRoteiroData_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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

    Private Sub frmComparaRoteiroData_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Size = New System.Drawing.Size(387, 369)
        Me.Location = New System.Drawing.Point(20, 20)
        Call CarregaListVeiculos()
    End Sub
End Class