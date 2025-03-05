Option Strict Off
Option Explicit On
Friend Class frmRoteiroReplicacao
    Inherits System.Windows.Forms.Form
    Dim asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro = NewRoteiro()
    Dim dtsRoteiro As New MSAClass.AsmxRoteiro.dtsRoteiro

    Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Dispose()
    End Sub
	
	
	
	
	Private Sub cmdExibirPrograma_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExibirPrograma.Click
		Call CarregaGrid()
	End Sub
	
    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOkCancel.Ok_Click

        On Error GoTo Erro
        Dim binformouPrograma As Boolean
        Dim bTodos As Boolean
        gridPrograma.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dtsRoteiro.dtbRoteiro_Programa.AcceptChanges()

        If Trim(ucVeiculo_Origem.Text) = "" Then
            Aviso("Veículo origem não foi Informado")
            ucVeiculo_Origem.Focus()
            GoTo Saida
        End If

        If Trim(ucVeiculo_Destino.Text) = "" Then
            Aviso("Veículo destino não foi Informado")
            ucVeiculo_Destino.Focus()
            GoTo Saida
        End If

        If ucVeiculo_Origem.Text = ucVeiculo_Destino.Text Then
            Aviso("Veiculo Origem e Destino devem ser diferentes")
            GoTo saida
        End If

        If Trim(UcData_Exibicao.Text) = "" Then
            Aviso("Data não foi Informada")
            UcData_Exibicao.Focus()
            GoTo Saida
        End If

        bTodos = True
        binformouPrograma = False
        With gridPrograma
            For Each row As DataGridViewRow In .Rows
                If .Item("Check", row.Index).Value Then
                    binformouPrograma = True
                    Exit For
                End If
            Next
        End With

        If Not binformouPrograma Then
            Aviso("Nenhum Programa foi Selecionado")
            GoTo Saida
        End If
        bTodos = True
        With gridPrograma
            For Each row As DataGridViewRow In .Rows
                If Not .Item("Check", row.Index).Value Then
                    bTodos = False
                    Exit For
                End If
            Next
        End With

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Mensagem("Processando.....Aguarde")
        If bTodos Then
            asmxRoteiro.spuRoteiro_Replicacao(ucVeiculo_Origem.Text, ucVeiculo_Destino.Text, UcData_Exibicao.Text, "")
        Else
            With gridPrograma
                For Each row As DataGridViewRow In .Rows
                    If .Item("Check", row.Index).Value Then
                        asmxRoteiro.spuRoteiro_Replicacao(ucVeiculo_Origem.Text, ucVeiculo_Destino.Text, UcData_Exibicao.Text, .Item("Cod_Programa", row.Index).Value)
                    End If
                Next
            End With
        End If

        Mensagem("")
        Aviso("Fim do Processamento")

Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Mensagem("")

        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
    Private Sub frmRoteiroReplicacao_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{tab}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub CarregaGrid()
		On Error GoTo Erro

        If Trim(ucVeiculo_Origem.Text) = "" Then
            Aviso("Veículo origem não foi Informado")
            ucVeiculo_Origem.Focus()
            GoTo Saida
        End If

        If Trim(ucVeiculo_Destino.Text) = "" Then
            Aviso("Veículo destino não foi Informado")
            ucVeiculo_Destino.Focus()
            GoTo Saida
        End If

        If Trim(UcData_Exibicao.Text) = "" Or UcData_Exibicao.DateTime = Date.MinValue Then
            Aviso("Data não foi Informada")
            UcData_Exibicao.Focus()
            GoTo Saida
        End If



        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        dtsRoteiro = asmxRoteiro.spuCarregaRoteiro_Programa(ucVeiculo_Origem.Text, UcData_Exibicao.Text, "")

        dtsRoteiro.dtbRoteiro_Programa.Columns.Add("Check", GetType(System.Boolean))
        For Each row As DataRow In dtsRoteiro.dtbRoteiro_Programa.Rows
            row.Item("Check") = False
        Next
        gridPrograma.DataSource = dtsRoteiro.dtbRoteiro_Programa

        With gridPrograma

            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = False
            .Columns("Cod_Faixa").Visible = False
            .Columns("Horario").Visible = False
            .Columns("Indica_Ordenacao").Visible = False
            .Columns("Faixa_Horaria").Visible = False
            .Columns("Nome_Faixa_Horaria").Visible = False
            .Columns("Check").HeaderText = "Replicar?"

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()


            .ReadOnly = False
            For x As Integer = 0 To .Columns.Count - 1
                .Columns(x).ReadOnly = True
            Next x
            .Columns("Check").ReadOnly = False



        End With


Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	
    Private Sub frmRoteiroReplicacao_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0
        asmxRoteiro = NewRoteiro()

    End Sub
	
    Private Sub btnMarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        Try
            With gridPrograma
                For Each row As DataGridViewRow In .Rows
                    .Item("Check", row.Index).Value = True
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnDesmarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmarcar.Click
        Try
            With gridPrograma
                For Each row As DataGridViewRow In .Rows
                    .Item("Check", row.Index).Value = False
                Next
            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub


End Class