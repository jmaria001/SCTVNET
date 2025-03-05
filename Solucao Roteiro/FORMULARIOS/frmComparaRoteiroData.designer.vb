<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmComparaRoteiroData
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
        Me.MDIParent = SCTVNET.mdiPrincipal
        SCTVNET.mdiPrincipal.Show()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdCancela As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents lstVeiculos As System.Windows.Forms.CheckedListBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents _Label3_0 As System.Windows.Forms.Label
	Public WithEvents Label3 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents cmdPrograma As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdCancela = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.lstVeiculos = New System.Windows.Forms.CheckedListBox
        Me._Label3_0 = New System.Windows.Forms.Label
        Me.Label3 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdPrograma = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.UcData = New WCL_SCTV.UC.UCData
        Me.ucPrograma = New WUC.UcText
        Me.Frame2.SuspendLayout()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancela
        '
        Me.cmdCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancela.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.Location = New System.Drawing.Point(312, 314)
        Me.cmdCancela.Name = "cmdCancela"
        Me.cmdCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancela.Size = New System.Drawing.Size(64, 28)
        Me.cmdCancela.TabIndex = 4
        Me.cmdCancela.TabStop = False
        Me.cmdCancela.Text = "&Cancela"
        Me.cmdCancela.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(237, 314)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(64, 28)
        Me.cmdOk.TabIndex = 3
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.lstVeiculos)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(6, 57)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(370, 199)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Veículos"
        '
        'lstVeiculos
        '
        Me.lstVeiculos.BackColor = System.Drawing.SystemColors.Window
        Me.lstVeiculos.CheckOnClick = True
        Me.lstVeiculos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstVeiculos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVeiculos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstVeiculos.Location = New System.Drawing.Point(9, 18)
        Me.lstVeiculos.Name = "lstVeiculos"
        Me.lstVeiculos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstVeiculos.Size = New System.Drawing.Size(352, 169)
        Me.lstVeiculos.TabIndex = 1
        '
        '_Label3_0
        '
        Me._Label3_0.AutoSize = True
        Me._Label3_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.SetIndex(Me._Label3_0, CType(0, Short))
        Me._Label3_0.Location = New System.Drawing.Point(3, 12)
        Me._Label3_0.Name = "_Label3_0"
        Me._Label3_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_0.Size = New System.Drawing.Size(29, 14)
        Me._Label3_0.TabIndex = 6
        Me._Label3_0.Text = "Data"
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy ddd"
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(6, 26)
        Me.UcData.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcData.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcData.Name = "UcData"
        Me.UcData.Permite_Futuro = True
        Me.UcData.Permite_Limpar = True
        Me.UcData.Permite_Passado = True
        Me.UcData.Preenchimento_Obrigatorio = False
        Me.UcData.Size = New System.Drawing.Size(127, 25)
        Me.UcData.TabIndex = 0
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(4, 272)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(363, 25)
        Me.ucPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma.TabIndex = 12
        Me.ucPrograma.TextBoxLeft = CType(0, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'frmComparaRoteiroData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(381, 344)
        Me.Controls.Add(Me.ucPrograma)
        Me.Controls.Add(Me.UcData)
        Me.Controls.Add(Me.cmdCancela)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me._Label3_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(355, 112)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComparaRoteiroData"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Consulta/Comparação de Roteiros"
        Me.Frame2.ResumeLayout(False)
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents ucPrograma As WUC.UcText
#End Region
End Class