<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErro))
        Me.btnErro = New WUC.ucButton
        Me.chkMail = New System.Windows.Forms.CheckBox
        Me.txtErro = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnErro
        '
        Me.btnErro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnErro.BackColor = System.Drawing.SystemColors.Control
        Me.btnErro.BotaoCancelVisible = False
        Me.btnErro.Location = New System.Drawing.Point(320, 152)
        Me.btnErro.Name = "btnErro"
        Me.btnErro.Size = New System.Drawing.Size(86, 38)
        Me.btnErro.TabIndex = 1
        '
        'chkMail
        '
        Me.chkMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkMail.AutoSize = True
        Me.chkMail.Checked = True
        Me.chkMail.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMail.Location = New System.Drawing.Point(51, 167)
        Me.chkMail.Name = "chkMail"
        Me.chkMail.Size = New System.Drawing.Size(169, 17)
        Me.chkMail.TabIndex = 2
        Me.chkMail.Text = "Notificar o Suporte do Sistema"
        Me.chkMail.UseVisualStyleBackColor = True
        Me.chkMail.Visible = False
        '
        'txtErro
        '
        Me.txtErro.Location = New System.Drawing.Point(12, 12)
        Me.txtErro.Multiline = True
        Me.txtErro.Name = "txtErro"
        Me.txtErro.ReadOnly = True
        Me.txtErro.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtErro.Size = New System.Drawing.Size(385, 134)
        Me.txtErro.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SCTVNET.My.Resources.Resources.ERRO
        Me.PictureBox1.Location = New System.Drawing.Point(12, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmErro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(409, 196)
        Me.Controls.Add(Me.txtErro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkMail)
        Me.Controls.Add(Me.btnErro)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmErro"
        Me.Text = "Falha na Execução do Sistema"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnErro As WUC.ucButton
    Friend WithEvents chkMail As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtErro As System.Windows.Forms.TextBox
End Class
