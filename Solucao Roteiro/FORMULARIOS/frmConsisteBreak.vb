Option Strict Off
Option Explicit On
Friend Class frmConsisteBreak
    Inherits System.Windows.Forms.Form
    Dim asmxBreak As MSAClass.AsmxBreak.asmxBreak = NewBreak()
    Dim dtsBreak As New MSAClass.AsmxBreak.dtsBreak

    Private Sub MostraDados()
        On Error GoTo Erro

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Me.dtsBreak = Me.asmxBreak.spuCarregar_Mensagem_Exclusao_Break(txtVeiculo.Text, DateTime.Parse(txtData.Text))

        With flxConsistencia

            .Clear()
            .FormatString = "<Veiculo|<Data|<Programa|<Break|<Intervalo|<Data Exclusão|<Excluido Por|ID"
            .AllowUserResizing = MSFlexGridLib.AllowUserResizeSettings.flexResizeColumns
            .FixedCols = 0
            .RowHeightMin = 315

            .set_ColWidth(0, 690)
            .set_ColWidth(1, 1065)
            .set_ColWidth(2, 795)
            .set_ColWidth(3, 555)
            .set_ColWidth(4, 2055)
            .set_ColWidth(5, 1920)
            .set_ColWidth(6, 1485)
            .set_ColWidth(7, 0)

            For Each DRW As MSAClass.AsmxBreak.dtsBreak.dtbMensagem_Exclusao_RoteiroRow In Me.dtsBreak.dtbMensagem_Exclusao_Roteiro.Select()
                .set_TextMatrix(.Rows - 1, 0, DRW.Cod_Veiculo)
                .set_TextMatrix(.Rows - 1, 1, DRW.Data_Exibicao)
                .set_TextMatrix(.Rows - 1, 2, DRW.Cod_Programa)
                .set_TextMatrix(.Rows - 1, 2, DRW.Breaks)
                If DRW.Breaks = 0 Then
                    .set_TextMatrix(.Rows - 1, 4, "Inter Programa")
                Else
                    .set_TextMatrix(.Rows - 1, 4, DRW.Descricao)
                End If
                .set_TextMatrix(.Rows - 1, 5, DRW.Data_Exclusao.ToString("dd/mm/yyyy hh:mm:ss"))
                .set_TextMatrix(.Rows - 1, 6, DRW.Usuario_Exclusao)
                .set_TextMatrix(.Rows - 1, 7, DRW.ID_Exclusao_Roteiro)
                .Rows = .Rows + 1
                chkCritica.Checked = True

            Next

            If .Rows < 14 Then .Rows = 14
            flxConsistencia_RowColChange(flxConsistencia, New System.EventArgs())

        End With
Saida:
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Exit Sub

Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub

    'UPGRADE_WARNING: Event chkExibir.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkExibir_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkExibir.CheckStateChanged
        Call MostraDados()
    End Sub


    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        On Error GoTo Erro
        Dim nRow As Short
        Dim aCampos(3) As Object
        Dim aValores(3) As Object

        If chkExcluir.Checked = False Then
            GoTo Saida
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        For Each drw As MSAClass.AsmxBreak.dtsBreak.dtbMensagem_Exclusao_RoteiroRow In dtsBreak.dtbMensagem_Exclusao_Roteiro.Rows
            drw.indica_desativado = 1
            drw.Data_Visto = DateTime.Today
            drw.Visto_Usuario = gsUsuario
        Next

        Me.AsmxBreak.spuAtualizar_Mensagem_Exclusao_Break(DtsBreak)
        Me.Hide()
Saida:
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
	
	Private Sub flxConsistencia_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flxConsistencia.RowColChange
		With flxConsistencia
			If .Row > 0 Then
				.Col = 0
				.ColSel = .Cols - 1
			End If
			
		End With
	End Sub
	
    Private Sub frmConsisteBreak_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Top = 0
        Me.Left = 0


    End Sub
End Class