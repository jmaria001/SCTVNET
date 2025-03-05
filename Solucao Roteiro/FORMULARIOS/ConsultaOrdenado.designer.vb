<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConsultaOrdenado
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        InitializeComponent()


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
    Public WithEvents cmdExibir As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Picture2 As System.Windows.Forms.PictureBox
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents cmdSair As System.Windows.Forms.Button
	Public WithEvents flxConsulta As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaOrdenado))
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.ucVeiculo = New WUC.UcText
        Me.UcData = New WCL_SCTV.UC.UCData
        Me.cmdExibir = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdSair = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.flxConsulta = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Picture2 = New System.Windows.Forms.PictureBox
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.gridBreak = New System.Windows.Forms.DataGridView
        Me.imgDesativado = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdSalvarBaixa = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        CType(Me.flxConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBreak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDesativado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.ucVeiculo)
        Me.Frame1.Controls.Add(Me.UcData)
        Me.Frame1.Controls.Add(Me.cmdExibir)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(9, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(976, 73)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(21, 19)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(485, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy "
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(589, 18)
        Me.UcData.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcData.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcData.Name = "UcData"
        Me.UcData.Permite_Futuro = True
        Me.UcData.Permite_Limpar = True
        Me.UcData.Permite_Passado = True
        Me.UcData.Preenchimento_Obrigatorio = False
        Me.UcData.Size = New System.Drawing.Size(135, 25)
        Me.UcData.TabIndex = 2
        '
        'cmdExibir
        '
        Me.cmdExibir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExibir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExibir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExibir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExibir.Location = New System.Drawing.Point(824, 18)
        Me.cmdExibir.Name = "cmdExibir"
        Me.cmdExibir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExibir.Size = New System.Drawing.Size(81, 31)
        Me.cmdExibir.TabIndex = 3
        Me.cmdExibir.Text = "&Exibir"
        Me.cmdExibir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(548, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data"
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(878, 563)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(107, 42)
        Me.cmdSair.TabIndex = 3
        Me.cmdSair.Text = "Sai&r"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(808, 574)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Local"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(705, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Net"
        '
        'flxConsulta
        '
        Me.flxConsulta.Location = New System.Drawing.Point(283, 79)
        Me.flxConsulta.Name = "flxConsulta"
        Me.flxConsulta.OcxState = CType(resources.GetObject("flxConsulta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxConsulta.Size = New System.Drawing.Size(702, 477)
        Me.flxConsulta.TabIndex = 2
        '
        'Picture2
        '
        Me.Picture2.BackColor = System.Drawing.Color.Blue
        Me.Picture2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture2.Location = New System.Drawing.Point(784, 574)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(18, 17)
        Me.Picture2.TabIndex = 10
        Me.Picture2.TabStop = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(681, 575)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(18, 16)
        Me.Picture1.TabIndex = 9
        Me.Picture1.TabStop = False
        '
        'gridBreak
        '
        Me.gridBreak.BackgroundColor = System.Drawing.Color.White
        Me.gridBreak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBreak.Location = New System.Drawing.Point(9, 79)
        Me.gridBreak.Name = "gridBreak"
        Me.gridBreak.Size = New System.Drawing.Size(268, 477)
        Me.gridBreak.TabIndex = 11
        '
        'imgDesativado
        '
        Me.imgDesativado.BackColor = System.Drawing.SystemColors.Control
        Me.imgDesativado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgDesativado.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgDesativado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgDesativado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.imgDesativado.Image = CType(resources.GetObject("imgDesativado.Image"), System.Drawing.Image)
        Me.imgDesativado.Location = New System.Drawing.Point(469, 512)
        Me.imgDesativado.Name = "imgDesativado"
        Me.imgDesativado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.imgDesativado.Size = New System.Drawing.Size(25, 24)
        Me.imgDesativado.TabIndex = 22
        Me.imgDesativado.TabStop = False
        Me.imgDesativado.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 562)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 42)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Propagar Horario às Veiculaçoes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSalvarBaixa
        '
        Me.cmdSalvarBaixa.Location = New System.Drawing.Point(223, 562)
        Me.cmdSalvarBaixa.Name = "cmdSalvarBaixa"
        Me.cmdSalvarBaixa.Size = New System.Drawing.Size(195, 42)
        Me.cmdSalvarBaixa.TabIndex = 24
        Me.cmdSalvarBaixa.Text = "Salvar Baixa de Horários"
        Me.cmdSalvarBaixa.UseVisualStyleBackColor = True
        '
        'frmConsultaOrdenado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(997, 616)
        Me.Controls.Add(Me.cmdSalvarBaixa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imgDesativado)
        Me.Controls.Add(Me.gridBreak)
        Me.Controls.Add(Me.flxConsulta)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Picture2)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(161, 154)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaOrdenado"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consulta de Roteiro Ordenado"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.flxConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBreak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDesativado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents gridBreak As System.Windows.Forms.DataGridView
    Public WithEvents imgDesativado As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdSalvarBaixa As System.Windows.Forms.Button
#End Region
End Class