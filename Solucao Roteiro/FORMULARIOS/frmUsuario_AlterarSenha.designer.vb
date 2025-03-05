<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario_AlterarSenha
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picAcesso = New System.Windows.Forms.Panel
        Me.txtSenha1 = New System.Windows.Forms.TextBox
        Me.txtSenha2 = New System.Windows.Forms.TextBox
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.cmdCancelarSenha = New System.Windows.Forms.Button
        Me.cmdOkSenha = New System.Windows.Forms.Button
        Me.picAcesso.SuspendLayout()
        Me.SuspendLayout()
        '
        'picAcesso
        '
        Me.picAcesso.BackColor = System.Drawing.Color.White
        Me.picAcesso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAcesso.Controls.Add(Me.txtSenha1)
        Me.picAcesso.Controls.Add(Me.txtSenha2)
        Me.picAcesso.Controls.Add(Me._Label1_1)
        Me.picAcesso.Controls.Add(Me._Label1_0)
        Me.picAcesso.Cursor = System.Windows.Forms.Cursors.Default
        Me.picAcesso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picAcesso.Location = New System.Drawing.Point(2, 3)
        Me.picAcesso.Name = "picAcesso"
        Me.picAcesso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picAcesso.Size = New System.Drawing.Size(306, 103)
        Me.picAcesso.TabIndex = 12
        Me.picAcesso.TabStop = True
        '
        'txtSenha1
        '
        Me.txtSenha1.AcceptsReturn = True
        Me.txtSenha1.BackColor = System.Drawing.SystemColors.Window
        Me.txtSenha1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSenha1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtSenha1.Location = New System.Drawing.Point(91, 17)
        Me.txtSenha1.MaxLength = 10
        Me.txtSenha1.Name = "txtSenha1"
        Me.txtSenha1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSenha1.Size = New System.Drawing.Size(199, 20)
        Me.txtSenha1.TabIndex = 0
        '
        'txtSenha2
        '
        Me.txtSenha2.AcceptsReturn = True
        Me.txtSenha2.BackColor = System.Drawing.SystemColors.Window
        Me.txtSenha2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSenha2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtSenha2.Location = New System.Drawing.Point(91, 57)
        Me.txtSenha2.MaxLength = 10
        Me.txtSenha2.Name = "txtSenha2"
        Me.txtSenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSenha2.Size = New System.Drawing.Size(199, 20)
        Me.txtSenha2.TabIndex = 1
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = True
        Me._Label1_1.BackColor = System.Drawing.Color.White
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.Highlight
        Me._Label1_1.Location = New System.Drawing.Point(4, 63)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(81, 13)
        Me._Label1_1.TabIndex = 18
        Me._Label1_1.Text = "Repita a Senha"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.Color.White
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.Highlight
        Me._Label1_0.Location = New System.Drawing.Point(4, 18)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(67, 13)
        Me._Label1_0.TabIndex = 17
        Me._Label1_0.Text = "Nova Senha"
        '
        'cmdCancelarSenha
        '
        Me.cmdCancelarSenha.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelarSenha.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelarSenha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelarSenha.Location = New System.Drawing.Point(239, 112)
        Me.cmdCancelarSenha.Name = "cmdCancelarSenha"
        Me.cmdCancelarSenha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelarSenha.Size = New System.Drawing.Size(69, 34)
        Me.cmdCancelarSenha.TabIndex = 3
        Me.cmdCancelarSenha.TabStop = False
        Me.cmdCancelarSenha.Text = "&Cancela"
        Me.cmdCancelarSenha.UseVisualStyleBackColor = False
        '
        'cmdOkSenha
        '
        Me.cmdOkSenha.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOkSenha.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOkSenha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOkSenha.Location = New System.Drawing.Point(151, 112)
        Me.cmdOkSenha.Name = "cmdOkSenha"
        Me.cmdOkSenha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOkSenha.Size = New System.Drawing.Size(69, 34)
        Me.cmdOkSenha.TabIndex = 2
        Me.cmdOkSenha.Text = "&Ok"
        Me.cmdOkSenha.UseVisualStyleBackColor = False
        '
        'frmUsuario_AlterarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 160)
        Me.Controls.Add(Me.cmdCancelarSenha)
        Me.Controls.Add(Me.cmdOkSenha)
        Me.Controls.Add(Me.picAcesso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUsuario_AlterarSenha"
        Me.Text = "Alteração da Senha"
        Me.picAcesso.ResumeLayout(False)
        Me.picAcesso.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents picAcesso As System.Windows.Forms.Panel
    Public WithEvents txtSenha1 As System.Windows.Forms.TextBox
    Public WithEvents txtSenha2 As System.Windows.Forms.TextBox
    Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents cmdCancelarSenha As System.Windows.Forms.Button
    Public WithEvents cmdOkSenha As System.Windows.Forms.Button
End Class
