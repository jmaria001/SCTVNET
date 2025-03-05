<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmApresentacao
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        Me.MdiParent = mdiPrincipal

        InitializeComponent()
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
	Public WithEvents rtAviso As System.Windows.Forms.RichTextBox
	Public WithEvents picNovidade As System.Windows.Forms.PictureBox
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents picAviso As System.Windows.Forms.PictureBox
	Public WithEvents rtNovidades As System.Windows.Forms.RichTextBox
	Public WithEvents lblAviso As System.Windows.Forms.Label
	Public WithEvents lboNovidade As System.Windows.Forms.Label
	Public WithEvents fraMensagem As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApresentacao))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fraMensagem = New System.Windows.Forms.GroupBox
        Me.rtAviso = New System.Windows.Forms.RichTextBox
        Me.picNovidade = New System.Windows.Forms.PictureBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.picAviso = New System.Windows.Forms.PictureBox
        Me.rtNovidades = New System.Windows.Forms.RichTextBox
        Me.lblAviso = New System.Windows.Forms.Label
        Me.lboNovidade = New System.Windows.Forms.Label
        Me.fraMensagem.SuspendLayout()
        CType(Me.picNovidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraMensagem
        '
        Me.fraMensagem.BackColor = System.Drawing.SystemColors.Window
        Me.fraMensagem.Controls.Add(Me.rtAviso)
        Me.fraMensagem.Controls.Add(Me.picNovidade)
        Me.fraMensagem.Controls.Add(Me.picAviso)
        Me.fraMensagem.Controls.Add(Me.rtNovidades)
        Me.fraMensagem.Controls.Add(Me.lblAviso)
        Me.fraMensagem.Controls.Add(Me.lboNovidade)
        Me.fraMensagem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.fraMensagem.Location = New System.Drawing.Point(6, 3)
        Me.fraMensagem.Name = "fraMensagem"
        Me.fraMensagem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraMensagem.Size = New System.Drawing.Size(622, 480)
        Me.fraMensagem.TabIndex = 1
        Me.fraMensagem.TabStop = False
        '
        'rtAviso
        '
        Me.rtAviso.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rtAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtAviso.Location = New System.Drawing.Point(6, 51)
        Me.rtAviso.Name = "rtAviso"
        Me.rtAviso.ReadOnly = True
        Me.rtAviso.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtAviso.Size = New System.Drawing.Size(609, 189)
        Me.rtAviso.TabIndex = 6
        Me.rtAviso.Text = ""
        '
        'picNovidade
        '
        Me.picNovidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picNovidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.picNovidade.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picNovidade.Image = CType(resources.GetObject("picNovidade.Image"), System.Drawing.Image)
        Me.picNovidade.Location = New System.Drawing.Point(9, 246)
        Me.picNovidade.Name = "picNovidade"
        Me.picNovidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picNovidade.Size = New System.Drawing.Size(34, 31)
        Me.picNovidade.TabIndex = 3
        Me.picNovidade.TabStop = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.White
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(541, 489)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(87, 29)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'picAviso
        '
        Me.picAviso.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picAviso.Cursor = System.Windows.Forms.Cursors.Default
        Me.picAviso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picAviso.Image = CType(resources.GetObject("picAviso.Image"), System.Drawing.Image)
        Me.picAviso.Location = New System.Drawing.Point(12, 15)
        Me.picAviso.Name = "picAviso"
        Me.picAviso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picAviso.Size = New System.Drawing.Size(37, 27)
        Me.picAviso.TabIndex = 2
        Me.picAviso.TabStop = False
        '
        'rtNovidades
        '
        Me.rtNovidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rtNovidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtNovidades.Location = New System.Drawing.Point(6, 284)
        Me.rtNovidades.Name = "rtNovidades"
        Me.rtNovidades.ReadOnly = True
        Me.rtNovidades.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtNovidades.Size = New System.Drawing.Size(609, 190)
        Me.rtNovidades.TabIndex = 7
        Me.rtNovidades.Text = ""
        '
        'lblAviso
        '
        Me.lblAviso.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAviso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAviso.Location = New System.Drawing.Point(6, 12)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAviso.Size = New System.Drawing.Size(609, 36)
        Me.lblAviso.TabIndex = 5
        Me.lblAviso.Text = "Aviso Importante"
        Me.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lboNovidade
        '
        Me.lboNovidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lboNovidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lboNovidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lboNovidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboNovidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lboNovidade.Location = New System.Drawing.Point(6, 243)
        Me.lboNovidade.Name = "lboNovidade"
        Me.lboNovidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lboNovidade.Size = New System.Drawing.Size(609, 38)
        Me.lboNovidade.TabIndex = 4
        Me.lboNovidade.Text = "Novidades"
        Me.lboNovidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmApresentacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 521)
        Me.Controls.Add(Me.fraMensagem)
        Me.Controls.Add(Me.cmdOk)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(97, 114)
        Me.MinimizeBox = False
        Me.Name = "frmApresentacao"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.fraMensagem.ResumeLayout(False)
        CType(Me.picNovidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAviso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class