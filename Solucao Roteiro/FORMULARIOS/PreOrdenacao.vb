Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmPreOrdenacao
    Inherits System.Windows.Forms.Form
    Dim AsmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro
    Dim dtsRoteiro As New MSAClass.AsmxRoteiro.dtsRoteiro
    Dim AsmxRoteiroLog As MSAClass.AsmxRoteiroLog.asmxRoteiroLog
    Dim dtsRoteiroLog As New MSAClass.AsmxRoteiroLog.dtsRoteiroLog
    Private Sub CmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Dispose()
    End Sub

    Private Sub CmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOkCancel.Ok_Click
        On Error GoTo Erro

        Dim sMens As String
        Dim bTemRoteiro As Boolean
        Dim btRotativo As Byte = 0
        Dim btVinheta As Byte = 0


        '============================> Verifica se Informou a Data
        If Trim(dteData.Text) = "" Or dteData.DateTime = Date.MinValue Then
            Aviso("Data Não foi Informada")
            GoTo Saida
        End If

        '============================> Verifica se Informou a Veiculo
        If Trim(ucVeiculo.Text) = "" Then
            Aviso("Veículo não foi Informado")
            GoTo Saida
        End If
        '============================> Verifica se Informou o Programa
        If optPrograma(0).Checked Then
            If Trim(UcPrograma.text) = "" Then
                Aviso("Código do Programa não foi Informado")
                GoTo Saida
            End If
        End If



        If AsmxRoteiro.spuCheckEncerramento(ucVeiculo.Text, dteData.Text) Then




            Aviso("O Roteiro desta data já esta encerrado.Pré-Ordenação não permitida")
            GoTo Saida



        End If

        dtsRoteiro = AsmxRoteiro.spuCarregar_Roteiro(ucVeiculo.Text, dteData.Text, "", 0, 0)

        If DtsRoteiro.dtbRoteiro_Ordenado.Select("Indica_Titulo_Break <> 1 and Indica_Titulo_Intervalo <> 1").Length > 0 Then
            sMens = "Já existe roteiro ordenado para esta data." & vbCrLf
            sMens = sMens & "Caso prossiga, a ordenação desta data será excluida e pre-ordenada novamente." & vbCrLf
            sMens = sMens & "Deseja prosseguir ? "
            If MsgBox(sMens, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Atenção") = MsgBoxResult.No Then
                GoTo Saida
            End If
        End If



        sMens = "Veiculo:" & ucveiculo.text & "-"
        sMens = sMens & vbCrLf
        sMens = sMens & "Data:" & dteData.Text & vbCrLf
        If Trim(ucprograma.text) <> "" Then
            sMens = sMens & "Programa:" & ucprograma.text & vbCrLf
        End If
        sMens = sMens & "Confirma a Pre-Ordenação"
        If MsgBox(sMens, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Atenção") = MsgBoxResult.No Then
            GoTo Saida
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor


        Me.AdicionaLog(ucveiculo.text, dteData.Text, ucprograma.text, , , , , , , , , , "Início Pré Ordenação Roteiro", Me.Name)

        If chkRotativo.Checked Then
            btRotativo = 1
        End If

        If chkVinheta.Checked Then
            btVinheta = 1
        End If

        AsmxRoteiro.spuPreOrdenacao(ucVeiculo.Text, dteData.Text, ucprograma.text, btRotativo, btVinheta)

        Me.AdicionaLog(ucVeiculo.Text, dteData.Text, ucprograma.text, , , , , , , , , , "Fim Pré Ordenação Roteiro", Me.Name)
        AsmxRoteiroLog.spuGravar_Roteiro_Log(DtsRoteiroLog)

        Aviso("Fim da Pre-Ordenação")
        Me.Dispose()
Saida:

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    Private Sub frmPreOrdenacao_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        ucPrograma.Caption = ""
        AsmxRoteiro = NewRoteiro()
        AsmxRoteiroLog = NewRoteiroLog()
        On Error GoTo Erro
        Me.Top = 0
        Me.Left = 0

        Dim nVei As Short

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub


    Private Sub optPrograma_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optPrograma.CheckedChanged
        If eventSender.Checked Then
            Dim Index As Short = optPrograma.GetIndex(eventSender)

            If Index = 1 Then
                ucprograma.text = ""
                ucPrograma.Visible = False
            Else
                ucPrograma.Visible = True
            End If

        End If
    End Sub
    Public Sub AdicionaLog(Optional ByVal Par_Cod_Veiculo As String = "", _
                               Optional ByVal Par_Data_Exibicao As String = "", _
                               Optional ByVal Par_Cod_Programa As String = "", _
                               Optional ByVal Par_Cod_Comercial As String = "", _
                               Optional ByVal Par_Breaks As Short = 0, _
                               Optional ByVal Par_Tipo As Short = 0, _
                               Optional ByVal Par_Numero_Fita As String = "", _
                               Optional ByVal Par_Titulo As String = "", _
                               Optional ByVal Par_Cod_Empresa As String = "", _
                               Optional ByVal Par_Numero_MR As Integer = 0, _
                               Optional ByVal Par_sequencia_mr As Short = 0, _
                               Optional ByVal Par_Chave_Acesso As Short = 0, _
                               Optional ByVal Par_LogOPeracao As String = "", _
                               Optional ByVal Par_Formulario As String = "")

        On Error GoTo Erro

        DtsRoteiroLog.dtbRoteiroLog.AdddtbRoteiroLogRow(Par_Cod_Veiculo, _
                                                        Par_Data_Exibicao, _
                                                        Par_Cod_Programa, _
                                                        Par_Cod_Comercial, _
                                                        Par_Breaks, _
                                                        Par_Tipo, _
                                                        Par_Numero_Fita, _
                                                        Par_Titulo, _
                                                        Par_Cod_Empresa, _
                                                        Par_Numero_MR, _
                                                        Par_sequencia_mr, _
                                                        Par_Chave_Acesso, _
                                                        gsUsuario, _
                                                        Now, _
                                                        TimeOfDay.ToLongTimeString, _
                                                        Par_LogOPeracao, _
                                                        Me.Name _
                                                        )

Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

 

    Private Sub dteData_Value_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub UcVeiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class