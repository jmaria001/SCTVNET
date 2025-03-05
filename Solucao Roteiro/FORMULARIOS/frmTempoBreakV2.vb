Option Strict Off
Option Explicit On
Friend Class frmTempoBreakV2
	Inherits System.Windows.Forms.Form
	

	
	Private Sub chkNet_Click()
		
		
	End Sub
	
	'UPGRADE_WARNING: Event chkTipoIntervalo.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkTipoIntervalo_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTipoIntervalo.CheckStateChanged
		Dim Index As Short = chkTipoIntervalo.GetIndex(eventSender)
		Call MostraLinha()
	End Sub
	
	Private Sub cmdCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancela.Click
        Me.Dispose()
	End Sub
	
	
    Private Sub frmTempoBreakV2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SetaUserControl(Me)
        Me.Top = VB6.TwipsToPixelsY(2655)
        Me.Left = VB6.TwipsToPixelsX(3900)
        optOpcoes(2).Checked = True
    End Sub
	
	
	Private Sub MostraLinha()
		On Error GoTo Erro
		Dim nCont As Short
		Dim nAltura As Short
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		With flxTempoBreak
			.Visible = False
			
			For nCont = 1 To .Rows - 1
				nAltura = 240
				
				If chkTipoIntervalo(0).CheckState = System.Windows.Forms.CheckState.Unchecked And .get_TextMatrix(nCont, fColuna(flxTempoBreak, "TIPO INTERVALO")) = "1" Then
					nAltura = 0
				End If
				
				If chkTipoIntervalo(1).CheckState = System.Windows.Forms.CheckState.Unchecked And (.get_TextMatrix(nCont, fColuna(flxTempoBreak, "TIPO INTERVALO")) = "0" Or .get_TextMatrix(nCont, fColuna(flxTempoBreak, "TIPO INTERVALO")) = "3") Then
					nAltura = 0
				End If
				
				If chkTipoIntervalo(2).CheckState = System.Windows.Forms.CheckState.Unchecked And .get_TextMatrix(nCont, fColuna(flxTempoBreak, "TIPO INTERVALO")) = "2" Then
					nAltura = 0
				End If
				
				
				If optOpcoes(0).Checked And .get_TextMatrix(nCont, fColuna(flxTempoBreak, "status")) = Chr(252) Then
					nAltura = 0
				End If
				
				If optOpcoes(1).Checked And .get_TextMatrix(nCont, fColuna(flxTempoBreak, "status")) = Chr(251) Then
					nAltura = 0
				End If
				
				.set_RowHeight(nCont, nAltura)
				
			Next 
		End With
		
Saida: 
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		flxTempoBreak.Visible = True
		Exit Sub
		
Erro: 
		Erro(Err.Number)
		Resume Saida
		Resume 
		
		
	End Sub
	'UPGRADE_WARNING: Event optOpcoes.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optOpcoes_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOpcoes.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optOpcoes.GetIndex(eventSender)
			Call MostraLinha()
		End If
	End Sub

    Private Sub Frame2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class