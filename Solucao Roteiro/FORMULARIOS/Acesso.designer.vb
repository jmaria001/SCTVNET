<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAcesso
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        InitializeComponent()

	End Sub
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents txtSenha As System.Windows.Forms.TextBox
	Public WithEvents txtUsuario As System.Windows.Forms.TextBox
	Public WithEvents _lblUF_1 As System.Windows.Forms.Label
	Public WithEvents _lblUF_0 As System.Windows.Forms.Label
	Public WithEvents picAcesso As System.Windows.Forms.Panel
	Public WithEvents _lblCampos_8 As System.Windows.Forms.Label
	Public WithEvents Shape4 As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lblUF As Microsoft.VisualBasic.Compatibility.VB6.LabelArray

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcesso))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picAcesso = New System.Windows.Forms.Panel
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me._lblUF_1 = New System.Windows.Forms.Label
        Me._lblUF_0 = New System.Windows.Forms.Label
        Me._lblCampos_8 = New System.Windows.Forms.Label
        Me.Shape4 = New System.Windows.Forms.Label
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblUF = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdAlterarSenha = New System.Windows.Forms.Button
        Me.ucOkCancel = New WUC.ucButton
        Me.picAcesso.SuspendLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAcesso
        '
        Me.picAcesso.BackColor = System.Drawing.Color.White
        Me.picAcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAcesso.Controls.Add(Me.Picture1)
        Me.picAcesso.Controls.Add(Me.txtSenha)
        Me.picAcesso.Controls.Add(Me.txtUsuario)
        Me.picAcesso.Controls.Add(Me._lblUF_1)
        Me.picAcesso.Controls.Add(Me._lblUF_0)
        Me.picAcesso.Cursor = System.Windows.Forms.Cursors.Default
        Me.picAcesso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picAcesso.Location = New System.Drawing.Point(18, 29)
        Me.picAcesso.Name = "picAcesso"
        Me.picAcesso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picAcesso.Size = New System.Drawing.Size(306, 110)
        Me.picAcesso.TabIndex = 4
        Me.picAcesso.TabStop = True
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Info
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Enabled = False
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.Location = New System.Drawing.Point(12, 28)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(37, 53)
        Me.Picture1.TabIndex = 6
        Me.Picture1.TabStop = False
        '
        'txtSenha
        '
        Me.txtSenha.AcceptsReturn = True
        Me.txtSenha.BackColor = System.Drawing.SystemColors.Window
        Me.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSenha.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtSenha.Location = New System.Drawing.Point(109, 70)
        Me.txtSenha.MaxLength = 10
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSenha.Size = New System.Drawing.Size(182, 20)
        Me.txtSenha.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.AcceptsReturn = True
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsuario.Location = New System.Drawing.Point(108, 15)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUsuario.Size = New System.Drawing.Size(183, 20)
        Me.txtUsuario.TabIndex = 0
        '
        '_lblUF_1
        '
        Me._lblUF_1.AutoSize = True
        Me._lblUF_1.BackColor = System.Drawing.Color.Transparent
        Me._lblUF_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblUF_1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblUF.SetIndex(Me._lblUF_1, CType(1, Short))
        Me._lblUF_1.Location = New System.Drawing.Point(54, 73)
        Me._lblUF_1.Name = "_lblUF_1"
        Me._lblUF_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblUF_1.Size = New System.Drawing.Size(38, 13)
        Me._lblUF_1.TabIndex = 8
        Me._lblUF_1.Text = "Senha"
        '
        '_lblUF_0
        '
        Me._lblUF_0.AutoSize = True
        Me._lblUF_0.BackColor = System.Drawing.Color.Transparent
        Me._lblUF_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblUF_0.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblUF.SetIndex(Me._lblUF_0, CType(0, Short))
        Me._lblUF_0.Location = New System.Drawing.Point(54, 18)
        Me._lblUF_0.Name = "_lblUF_0"
        Me._lblUF_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblUF_0.Size = New System.Drawing.Size(43, 13)
        Me._lblUF_0.TabIndex = 7
        Me._lblUF_0.Text = "Usuário"
        '
        '_lblCampos_8
        '
        Me._lblCampos_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._lblCampos_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblCampos_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblCampos_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblCampos_8.ForeColor = System.Drawing.Color.White
        Me.lblCampos.SetIndex(Me._lblCampos_8, CType(8, Short))
        Me._lblCampos_8.Location = New System.Drawing.Point(18, 9)
        Me._lblCampos_8.Name = "_lblCampos_8"
        Me._lblCampos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblCampos_8.Size = New System.Drawing.Size(306, 21)
        Me._lblCampos_8.TabIndex = 5
        Me._lblCampos_8.Text = "Informe seu Login e Senha"
        '
        'Shape4
        '
        Me.Shape4.BackColor = System.Drawing.Color.Black
        Me.Shape4.Location = New System.Drawing.Point(24, 15)
        Me.Shape4.Name = "Shape4"
        Me.Shape4.Size = New System.Drawing.Size(304, 131)
        Me.Shape4.TabIndex = 11
        '
        'cmdAlterarSenha
        '
        Me.cmdAlterarSenha.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAlterarSenha.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAlterarSenha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlterarSenha.Location = New System.Drawing.Point(18, 149)
        Me.cmdAlterarSenha.Name = "cmdAlterarSenha"
        Me.cmdAlterarSenha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlterarSenha.Size = New System.Drawing.Size(79, 33)
        Me.cmdAlterarSenha.TabIndex = 15
        Me.cmdAlterarSenha.TabStop = False
        Me.cmdAlterarSenha.Text = "&Alterar Senha"
        Me.cmdAlterarSenha.UseVisualStyleBackColor = False
        '
        'ucOkCancel
        '
        Me.ucOkCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ucOkCancel.Location = New System.Drawing.Point(149, 149)
        Me.ucOkCancel.Name = "ucOkCancel"
        Me.ucOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.ucOkCancel.TabIndex = 16
        '
        'frmAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(339, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.ucOkCancel)
        Me.Controls.Add(Me.cmdAlterarSenha)
        Me.Controls.Add(Me.picAcesso)
        Me.Controls.Add(Me._lblCampos_8)
        Me.Controls.Add(Me.Shape4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(126, 93)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcesso"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso ao Sistema"
        Me.picAcesso.ResumeLayout(False)
        Me.picAcesso.PerformLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdAlterarSenha As System.Windows.Forms.Button
    Friend WithEvents ucOkCancel As WUC.ucButton
#End Region
End Class