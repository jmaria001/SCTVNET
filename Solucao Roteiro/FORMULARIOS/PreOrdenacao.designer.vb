<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPreOrdenacao
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        InitializeComponent()
        Me.MdiParent = SCTVNET.mdiPrincipal

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
	Public WithEvents chkVinheta As System.Windows.Forms.CheckBox
	Public WithEvents chkRotativo As System.Windows.Forms.CheckBox
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents _optPrograma_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optPrograma_0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents optPrograma As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.chkVinheta = New System.Windows.Forms.CheckBox
        Me.chkRotativo = New System.Windows.Forms.CheckBox
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.ucPrograma = New WUC.UcText
        Me._optPrograma_1 = New System.Windows.Forms.RadioButton
        Me._optPrograma_0 = New System.Windows.Forms.RadioButton
        Me.optPrograma = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.dteData = New WCL_SCTV.UC.UCData
        Me.ucVeiculo = New WUC.UcText
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOkCancel = New WUC.ucButton
        Me.Frame5.SuspendLayout()
        Me.Frame4.SuspendLayout()
        CType(Me.optPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.chkVinheta)
        Me.Frame5.Controls.Add(Me.chkRotativo)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(6, 204)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(529, 46)
        Me.Frame5.TabIndex = 3
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Outros Parâmetros"
        '
        'chkVinheta
        '
        Me.chkVinheta.BackColor = System.Drawing.SystemColors.Control
        Me.chkVinheta.Checked = True
        Me.chkVinheta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVinheta.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkVinheta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVinheta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkVinheta.Location = New System.Drawing.Point(320, 17)
        Me.chkVinheta.Name = "chkVinheta"
        Me.chkVinheta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkVinheta.Size = New System.Drawing.Size(202, 22)
        Me.chkVinheta.TabIndex = 18
        Me.chkVinheta.Text = "Pré-Ordenar Vinhetas (VA e VE)"
        Me.chkVinheta.UseVisualStyleBackColor = False
        '
        'chkRotativo
        '
        Me.chkRotativo.BackColor = System.Drawing.SystemColors.Control
        Me.chkRotativo.Checked = True
        Me.chkRotativo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRotativo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRotativo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRotativo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRotativo.Location = New System.Drawing.Point(15, 21)
        Me.chkRotativo.Name = "chkRotativo"
        Me.chkRotativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRotativo.Size = New System.Drawing.Size(202, 18)
        Me.chkRotativo.TabIndex = 0
        Me.chkRotativo.Text = "Pré-Ordenar Comerciais Rotativos"
        Me.chkRotativo.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.ucPrograma)
        Me.Frame4.Controls.Add(Me._optPrograma_1)
        Me.Frame4.Controls.Add(Me._optPrograma_0)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(6, 98)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(529, 83)
        Me.Frame4.TabIndex = 2
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Parametros da Programação"
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(201, 8)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(321, 37)
        Me.ucPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma.TabIndex = 1
        Me.ucPrograma.TextBoxLeft = CType(0, Short)
        Me.ucPrograma.TextWidth = 0
        '
        '_optPrograma_1
        '
        Me._optPrograma_1.BackColor = System.Drawing.SystemColors.Control
        Me._optPrograma_1.Checked = True
        Me._optPrograma_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optPrograma_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optPrograma_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optPrograma.SetIndex(Me._optPrograma_1, CType(1, Short))
        Me._optPrograma_1.Location = New System.Drawing.Point(9, 61)
        Me._optPrograma_1.Name = "_optPrograma_1"
        Me._optPrograma_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optPrograma_1.Size = New System.Drawing.Size(196, 16)
        Me._optPrograma_1.TabIndex = 2
        Me._optPrograma_1.TabStop = True
        Me._optPrograma_1.Text = "Pre-Ordenar Todos os Programas"
        Me._optPrograma_1.UseVisualStyleBackColor = False
        '
        '_optPrograma_0
        '
        Me._optPrograma_0.BackColor = System.Drawing.SystemColors.Control
        Me._optPrograma_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optPrograma_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._optPrograma_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optPrograma.SetIndex(Me._optPrograma_0, CType(0, Short))
        Me._optPrograma_0.Location = New System.Drawing.Point(9, 29)
        Me._optPrograma_0.Name = "_optPrograma_0"
        Me._optPrograma_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optPrograma_0.Size = New System.Drawing.Size(196, 16)
        Me._optPrograma_0.TabIndex = 0
        Me._optPrograma_0.TabStop = True
        Me._optPrograma_0.Text = "Pré-Ordenar somente o Programa"
        Me._optPrograma_0.UseVisualStyleBackColor = False
        '
        'optPrograma
        '
        '
        'dteData
        '
        Me.dteData.BackColor = System.Drawing.Color.Transparent
        Me.dteData.DateTime = New Date(CType(0, Long))
        Me.dteData.Formato = "dd/MM/yyyy"
        Me.dteData.Hoje = False
        Me.dteData.Location = New System.Drawing.Point(66, 51)
        Me.dteData.MaximumSize = New System.Drawing.Size(500, 27)
        Me.dteData.MinimumSize = New System.Drawing.Size(115, 27)
        Me.dteData.Name = "dteData"
        Me.dteData.Permite_Futuro = True
        Me.dteData.Permite_Limpar = True
        Me.dteData.Permite_Passado = True
        Me.dteData.Preenchimento_Obrigatorio = False
        Me.dteData.Size = New System.Drawing.Size(135, 27)
        Me.dteData.TabIndex = 1
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(21, 13)
        Me.ucVeiculo.MaxLength = 3
        Me.ucVeiculo.Name = "ucVeiculo"
        Me.ucVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVeiculo.pDecimal = CType(0, Byte)
        Me.ucVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVeiculo.showButton = True
        Me.ucVeiculo.ShowDescricao = True
        Me.ucVeiculo.Size = New System.Drawing.Size(507, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Data"
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(349, 256)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 18
        '
        'frmPreOrdenacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(550, 305)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucVeiculo)
        Me.Controls.Add(Me.dteData)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreOrdenacao"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "Pré-Ordenação do Roteiro"
        Me.Frame5.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        CType(Me.optPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dteData As WCL_SCTV.UC.UCData
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents ucPrograma As WUC.UcText
#End Region
End Class