Public Class CustomGrid
    Inherits DataGridView
    Public EnterToTab As Boolean

    <System.ComponentModel.DefaultValue(True)> _
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Try

            If keyData = Keys.Return Then
                With Me
                    'Me.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    Me.EndEdit()
                    If Not .CurrentCell Is Nothing Then
                        If .CurrentCell.RowIndex > 0 Then
                            If String.IsNullOrEmpty(.CurrentCell.FormattedValue) Then
                                .CurrentCell.Value = .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex - 1).Value
                                Me.CommitEdit(DataGridViewDataErrorContexts.Commit)
                            End If
                        End If
                    End If
                End With
            End If
            If (keyData = Keys.Return Or keyData = Keys.Tab) And EnterToTab Then
                keyData = Keys.Tab
            End If

            '========================Move proxima celula habilitada

            With Me
                Select Case keyData
                    Case Keys.Tab, Keys.Right
                        .CurrentCell = NextCell()
                        msg.WParam = Keys.None
                    Case Keys.Left
                        .CurrentCell = PreviousCell()
                        msg.WParam = Keys.None
                End Select
            End With
        Catch ex As Exception
            Exit Function
        End Try
        EnterToTab = True
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Return And EnterToTab Then
            keyData = Keys.Tab
        End If
        Return MyBase.ProcessDialogKey(keyData)
        EnterToTab = True
    End Function
    Private Function NextCell() As DataGridViewCell
        NextCell = Nothing
        With Me
            Try
                If .CurrentCell IsNot Nothing Then
                    Dim Col As Integer = 0
                    Dim Row As Integer = 0
                    Col = Me.CurrentCell.ColumnIndex + 1
                    Row = Me.CurrentCell.RowIndex
                    For R As Integer = Row To .Rows.Count - 1
                        If R > Row Then Col = 0
                        For C As Integer = Col To .Columns.Count - 1
                            If Not .Item(C, R).[ReadOnly] Then
                                If .Item(C, R).Visible Then
                                    NextCell = .Item(C, R)
                                    Exit Try
                                End If
                            End If
                        Next C
                    Next R
                End If
            Catch ex As Exception
                Exit Function
            End Try
        End With
    End Function
    Private Function PreviousCell() As DataGridViewCell
        PreviousCell = Nothing
        With Me
            Try
                If .CurrentCell IsNot Nothing Then
                    Dim Col As Integer = 0
                    Dim Row As Integer = 0
                    Col = Me.CurrentCell.ColumnIndex - 1
                    Row = Me.CurrentCell.RowIndex
                    For R As Integer = Row To 0 Step -1
                        If R < Row Then Col = .ColumnCount - 1
                        For C As Integer = Col To 0 Step -1
                            If Not .Item(C, R).[ReadOnly] Then
                                If .Item(C, R).Visible Then
                                    PreviousCell= .Item(C, R)
                                    Exit Try
                                End If
                            End If
                        Next C
                    Next R
                End If
            Catch ex As Exception
                Exit Function
            End Try
        End With
    End Function
End Class
