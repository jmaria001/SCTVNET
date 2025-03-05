<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRoteiroReplicacao
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
    Public WithEvents btnMarcar As System.Windows.Forms.Button
    Public WithEvents btnDesmarcar As System.Windows.Forms.Button
    Public WithEvents fraPrograma As System.Windows.Forms.GroupBox
    Public WithEvents cmdExibirPrograma As System.Windows.Forms.Button
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnMarcar = New System.Windows.Forms.Button
        Me.btnDesmarcar = New System.Windows.Forms.Button
        Me.fraPrograma = New System.Windows.Forms.GroupBox
        Me.gridPrograma = New System.Windows.Forms.DataGridView
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ucVeiculo_Destino = New WUC.UcText
        Me.ucVeiculo_Origem = New WUC.UcText
        Me.UcData_Exibicao = New WCL_SCTV.UC.UCData
        Me.cmdExibirPrograma = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOkCancel = New WUC.ucButton
        Me.fraPrograma.SuspendLayout()
        CType(Me.gridPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMarcar
        '
        Me.btnMarcar.BackColor = System.Drawing.SystemColors.Control
        Me.btnMarcar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMarcar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarcar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMarcar.Location = New System.Drawing.Point(6, 482)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMarcar.Size = New System.Drawing.Size(85, 35)
        Me.btnMarcar.TabIndex = 4
        Me.btnMarcar.TabStop = False
        Me.btnMarcar.Tag = "252"
        Me.btnMarcar.Text = "&Marcar Todos"
        Me.btnMarcar.UseVisualStyleBackColor = False
        '
        'btnDesmarcar
        '
        Me.btnDesmarcar.BackColor = System.Drawing.SystemColors.Control
        Me.btnDesmarcar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDesmarcar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesmarcar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDesmarcar.Location = New System.Drawing.Point(105, 482)
        Me.btnDesmarcar.Name = "btnDesmarcar"
        Me.btnDesmarcar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDesmarcar.Size = New System.Drawing.Size(103, 35)
        Me.btnDesmarcar.TabIndex = 5
        Me.btnDesmarcar.TabStop = False
        Me.btnDesmarcar.Tag = "32"
        Me.btnDesmarcar.Text = "&Desmarcar Todos"
        Me.btnDesmarcar.UseVisualStyleBackColor = False
        '
        'fraPrograma
        '
        Me.fraPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.fraPrograma.Controls.Add(Me.gridPrograma)
        Me.fraPrograma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraPrograma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraPrograma.Location = New System.Drawing.Point(6, 135)
        Me.fraPrograma.Name = "fraPrograma"
        Me.fraPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraPrograma.Size = New System.Drawing.Size(514, 341)
        Me.fraPrograma.TabIndex = 18
        Me.fraPrograma.TabStop = False
        Me.fraPrograma.Text = "Programas"
        '
        'gridPrograma
        '
        Me.gridPrograma.BackgroundColor = System.Drawing.Color.White
        Me.gridPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPrograma.Location = New System.Drawing.Point(12, 20)
        Me.gridPrograma.Name = "gridPrograma"
        Me.gridPrograma.Size = New System.Drawing.Size(496, 315)
        Me.gridPrograma.TabIndex = 0
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Controls.Add(Me.ucVeiculo_Destino)
        Me.Frame2.Controls.Add(Me.ucVeiculo_Origem)
        Me.Frame2.Controls.Add(Me.UcData_Exibicao)
        Me.Frame2.Controls.Add(Me.cmdExibirPrograma)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(6, 6)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(514, 123)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(399, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Origem"
        '
        'ucVeiculo_Destino
        '
        Me.ucVeiculo_Destino.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo_Destino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo_Destino.Caption = "Veiculo"
        Me.ucVeiculo_Destino.DataTextValue = Nothing
        Me.ucVeiculo_Destino.Location = New System.Drawing.Point(12, 50)
        Me.ucVeiculo_Destino.MaxLength = 3
        Me.ucVeiculo_Destino.Name = "ucVeiculo_Destino"
        Me.ucVeiculo_Destino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVeiculo_Destino.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucVeiculo_Destino.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVeiculo_Destino.pDecimal = CType(0, Byte)
        Me.ucVeiculo_Destino.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucVeiculo_Destino.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVeiculo_Destino.showButton = True
        Me.ucVeiculo_Destino.ShowDescricao = True
        Me.ucVeiculo_Destino.Size = New System.Drawing.Size(381, 25)
        Me.ucVeiculo_Destino.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo_Destino.TabIndex = 1
        Me.ucVeiculo_Destino.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo_Destino.TextWidth = 0
        '
        'ucVeiculo_Origem
        '
        Me.ucVeiculo_Origem.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo_Origem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo_Origem.Caption = "Veiculo"
        Me.ucVeiculo_Origem.DataTextValue = Nothing
        Me.ucVeiculo_Origem.Location = New System.Drawing.Point(12, 16)
        Me.ucVeiculo_Origem.MaxLength = 3
        Me.ucVeiculo_Origem.Name = "ucVeiculo_Origem"
        Me.ucVeiculo_Origem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVeiculo_Origem.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucVeiculo_Origem.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVeiculo_Origem.pDecimal = CType(0, Byte)
        Me.ucVeiculo_Origem.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucVeiculo_Origem.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVeiculo_Origem.showButton = True
        Me.ucVeiculo_Origem.ShowDescricao = True
        Me.ucVeiculo_Origem.Size = New System.Drawing.Size(381, 25)
        Me.ucVeiculo_Origem.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo_Origem.TabIndex = 0
        Me.ucVeiculo_Origem.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo_Origem.TextWidth = 0
        '
        'UcData_Exibicao
        '
        Me.UcData_Exibicao.BackColor = System.Drawing.Color.Transparent
        Me.UcData_Exibicao.DateTime = New Date(CType(0, Long))
        Me.UcData_Exibicao.Formato = "dd/MM/yyyy "
        Me.UcData_Exibicao.Hoje = False
        Me.UcData_Exibicao.Location = New System.Drawing.Point(99, 87)
        Me.UcData_Exibicao.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcData_Exibicao.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcData_Exibicao.Name = "UcData_Exibicao"
        Me.UcData_Exibicao.Permite_Futuro = True
        Me.UcData_Exibicao.Permite_Limpar = True
        Me.UcData_Exibicao.Permite_Passado = True
        Me.UcData_Exibicao.Preenchimento_Obrigatorio = False
        Me.UcData_Exibicao.Size = New System.Drawing.Size(135, 25)
        Me.UcData_Exibicao.TabIndex = 2
        '
        'cmdExibirPrograma
        '
        Me.cmdExibirPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExibirPrograma.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExibirPrograma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExibirPrograma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExibirPrograma.Location = New System.Drawing.Point(402, 75)
        Me.cmdExibirPrograma.Name = "cmdExibirPrograma"
        Me.cmdExibirPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExibirPrograma.Size = New System.Drawing.Size(106, 37)
        Me.cmdExibirPrograma.TabIndex = 3
        Me.cmdExibirPrograma.Text = "&Exibir Programas"
        Me.cmdExibirPrograma.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Data de Exibição "
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(335, 482)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 19
        '
        'frmRoteiroReplicacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(541, 529)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.btnDesmarcar)
        Me.Controls.Add(Me.fraPrograma)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(232, 86)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoteiroReplicacao"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "32"
        Me.Text = "Replicação do Roteiro"
        Me.fraPrograma.ResumeLayout(False)
        CType(Me.gridPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcData_Exibicao As WCL_SCTV.UC.UCData
    Friend WithEvents ucVeiculo_Origem As WUC.UcText
    Friend WithEvents ucVeiculo_Destino As WUC.UcText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents gridPrograma As System.Windows.Forms.DataGridView
#End Region
End Class