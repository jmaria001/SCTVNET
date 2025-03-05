Option Strict Off
Option Explicit On
Friend Class frmConfirmacoes
    Inherits System.Windows.Forms.Form
    Dim asmxRoteiro As MSAClass.AsmxRoteiro.asmxRoteiro
    Dim dtsRoteiro As MSAClass.AsmxRoteiro.dtsRoteiro

	Private Sub cmdSair_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSair.Click
        Me.Dispose()
	End Sub
	
	Private Sub frmConfirmacoes_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Cursor = Cursors.WaitCursor()
        asmxRoteiro = NewRoteiro()

        With flxConfirmacoes

            .ScrollBars = MSFlexGridLib.ScrollBarsSettings.flexScrollBarVertical
            .FormatString = "^Data|^Veiculo|^Artístico|^Comercial"
            .Rows = 23
            .Row = 0

            For nCont = 0 To .Cols - 1
                .Col = nCont
                .CellForeColor = System.Drawing.Color.Blue
                .CellFontSize = 10
            Next
            .set_ColWidth(0, 1200)
            .set_ColWidth(1, 1000)
            .set_ColWidth(2, 1000)
            .set_ColWidth(3, 1000)

            nLin = 1

            DtsRoteiro = AsmxRoteiro.spuCarregaRoteiro_Fechamento("", DateTime.MinValue)

            For Each drw As MSAClass.AsmxRoteiro.dtsRoteiro.dtbRoteiro_FechamentoRow In dtsRoteiro.dtbRoteiro_Fechamento.Rows
                If nLin >= .Rows Then
                    .Rows = .Rows + 1
                End If
                .set_TextMatrix(nLin, 0, drw.Data)
                .set_TextMatrix(nLin, 1, drw.Cod_Veiculo)
                .set_TextMatrix(nLin, 2, IIf(drw.Indica_Fechamento_Artistico = 1, "Sim", "Não"))
                .set_TextMatrix(nLin, 3, IIf(drw.Indica_Fechamento_Comercial = 1, "Sim", "Não"))

                nLin = nLin + 1
            Next

        End With
        Me.Cursor = Cursors.Default
Saida: 

		
	End Sub
End Class