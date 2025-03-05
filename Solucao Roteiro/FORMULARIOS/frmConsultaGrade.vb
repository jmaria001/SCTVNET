Public Class frmConsultaGrade

    Private Sub Button1_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.BindingContextChanged

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DTS As New DataSet
        Dim CLS As MSAClass.AsmxGrade.asmxGrade = NewGrade()
        Try
            If Trim(TxtVeiculo.Text) = "" Then
                MsgBox("Preencha o Veiculo !!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If Trim(txtDatainicial.Text) = "" Then
                MsgBox("Preencha a Data Inicial !!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If Trim(txtDataFinal.Text) = "" Then
                MsgBox("Preencha a Data Final !!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If FormatDateTime(txtDatainicial.Text, DateFormat.ShortDate) > FormatDateTime(txtDataFinal.Text, DateFormat.ShortDate) Then
                MsgBox("Data Final nao pode ser maior que a Data Inicial !!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            DTS = CLS.fnFuncao_Consulta_Programacao(TxtVeiculo.Text, FormatDateTime(txtDatainicial.Text, DateFormat.ShortDate), FormatDateTime(txtDataFinal.Text, DateFormat.ShortDate), TxtPrograma.Text, chkSaldoZerado.CheckState, chkSaldoEstourado.CheckState, chkSaldoPositivo.CheckState, 1, chkInvasao.CheckState, chkProgramaDesativado.CheckState, ChkRede.CheckState, chkLocal.CheckState, ChkNet.CheckState, 0)
            Call EstiloGrid(dgConsulta_Programa, 1)
            With dgConsulta_Programa
                DTS.Tables(0).Columns.Add("status", GetType(String))
                .DataSource = DTS.Tables(0)
                .Columns("Status").DisplayIndex = 0
                .Columns("Status").HeaderText = "Status"
                .Columns("Cod_Programa").HeaderText = "Programa"
                .Columns("Data_Exibicao").HeaderText = "Data"
                .Columns("Titulo").HeaderText = "Titulo"
                .Columns("Horario_Inicial").HeaderText = "H.Inicio"
                .Columns("Horario_Final").HeaderText = "H.Final"
                .Columns("Dispo").HeaderText = "Dispo"
                .Columns("Absorvido").HeaderText = "Absorv."
                .Columns("Saldo").HeaderText = "Saldo"
                .Columns("Reservado").HeaderText = "Reserva"
                .Columns("Invasao").HeaderText = "Invadido"
                .Columns("Indica_Grade").Visible = False
                .Columns("Indica_Grade_desc").HeaderText = "Tipo Dispo"
                .Columns("Aguardando_Aprovacao").HeaderText = "Ag.Aprovaçâo"
                .Columns("Aguardando_Aprovacao").Visible = False

                .Columns("Status").Width = 40
                .Columns("Cod_Programa").Width = 60
                .Columns("Data_Exibicao").Width = 70
                .Columns("Titulo").Width = 200
                .Columns("Horario_Inicial").Width = 50
                .Columns("Horario_Final").Width = 50
                .Columns("Dispo").Width = 70
                .Columns("Absorvido").Width = 70
                .Columns("Saldo").Width = 70
                .Columns("Reservado").Width = 70
                .Columns("Invasao").Width = 70
                .Columns("Indica_Grade").Width = 70
                .Columns("Indica_Grade_desc").Width = 70
                .Columns("Aguardando_Aprovacao").Width = 70


                .Columns("Data_Exibicao").DefaultCellStyle.Format = "dd/MM/yyyy"
                
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .AutoResizeRows()
            End With

            Call MostraStatus()


        Catch ex As Exception
            ShowErro(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Public Sub MostraStatus()
        Try
            With dgConsulta_Programa
                For Each row As DataGridViewRow In .Rows
                    Select Case True
                        Case Integer.Parse(.Item("Invasao", row.Index).Value) > 0
                            row.DefaultCellStyle.ForeColor = picInvadido.BackColor

                        Case Integer.Parse(.Item("Saldo", row.Index).Value) < 0
                            row.DefaultCellStyle.ForeColor = picEstourado.BackColor

                        Case Integer.Parse(.Item("Saldo", row.Index).Value) = 0
                            row.DefaultCellStyle.ForeColor = picZerado.BackColor

                        Case Integer.Parse(.Item("Saldo", row.Index).Value) > 0
                            row.DefaultCellStyle.ForeColor = picDisponivel.BackColor

                        Case Integer.Parse(Vernulo(.Item("Aguardando_Aprovacao", row.Index).Value, 0)) > 0
                            '  row.DefaultCellStyle.ForeColor = picAguardando.BackColor
                        Case Else
                            row.DefaultCellStyle.ForeColor = Color.Black

                    End Select
                    If Vernulo(.Item("Aguardando_Aprovacao", row.Index).Value, 0) > 0 Then
                        ' row.DefaultCellStyle.ForeColor = picAguardando.BackColor
                    End If
                    row.DefaultCellStyle.SelectionBackColor = Color.White 'row.DefaultCellStyle.BackColor
                    row.DefaultCellStyle.SelectionForeColor = row.DefaultCellStyle.ForeColor
                    .Item("Status", row.Index).Style.BackColor = row.DefaultCellStyle.ForeColor
                    .Item("Status", row.Index).Style.SelectionBackColor = .Item("Status", row.Index).Style.BackColor
                Next
            End With

        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Dispose()
    End Sub



    Private Sub dgConsulta_Programa_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgConsulta_Programa.CellPainting
        'e.g. Vertically merge the same cells of the fourth column   
        'If e.ColumnIndex < 5 AndAlso e.RowIndex <> -1 Then
        '    Using gridBrush As Brush = New SolidBrush(Me.dgConsulta_Programa.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

        '        Using gridLinePen As Pen = New Pen(gridBrush)
        '            ' Clear cell   
        '            e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

        '            ' Draw line (bottom border and right border of current cell)   
        '            'If next row cell has different content, only draw bottom border line of current cell   
        '            If e.RowIndex < dgConsulta_Programa.Rows.Count - 2 AndAlso dgConsulta_Programa.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
        '                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
        '            End If

        '            ' Draw right border line of current cell   
        '            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

        '            ' draw/fill content in current cell, and fill only one cell of multiple same cells   
        '            If Not e.Value Is Nothing Then
        '                If e.RowIndex > 0 AndAlso dgConsulta_Programa.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
        '                Else
        '                    e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
        '                End If
        '            End If

        '            e.Handled = True
        '        End Using
        '    End Using
        'End If

    End Sub
    Public Sub New()
        InitializeComponent()
        Me.MdiParent = mdiPrincipal

    End Sub

    Private Sub frmConsultaGrade_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0
        TxtVeiculo.Usuario = gsUsuario

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub dgConsulta_Programa_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgConsulta_Programa.DoubleClick
        Try

            If InStr(strVeiculodoUsuario, TxtVeiculo.Text) = 0 Then
                Aviso("Detalhamento do Encaixe desse Veículo não está disponivel")
                Exit Try
            End If
            If Not dgConsulta_Programa.CurrentRow Is Nothing Then
                With frmprogramacaoprevista
                    .CodVeiculo = TxtVeiculo.Text


                    .CodPrograma = dgConsulta_Programa.Item("Cod_Programa", dgConsulta_Programa.CurrentRow.Index).Value
                    .DataExibicao = dgConsulta_Programa.Item("Data_Exibicao", dgConsulta_Programa.CurrentRow.Index).Value
                    .Indica_Grade = dgConsulta_Programa.Item("Indica_Grade", dgConsulta_Programa.CurrentRow.Index).Value
                    .NomePrograma = dgConsulta_Programa.Item("Titulo", dgConsulta_Programa.CurrentRow.Index).Value
                    .NomeVeiculo = TxtVeiculo.Descricao
                End With
                frmprogramacaoprevista.ShowDialog()
                frmprogramacaoprevista.Dispose()
            End If
        Catch ex As Exception
            ShowErro(ex)
        Finally
        End Try
    End Sub

    

    Private Sub dgConsulta_Programa_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgConsulta_Programa.Sorted
        Call MostraStatus()
    End Sub


End Class