<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcText
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.lblCaption = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtText = New System.Windows.Forms.TextBox
        Me.btnPesquisa = New System.Windows.Forms.Button
        Me.picStatus = New System.Windows.Forms.PictureBox
        Me.txtDescricao = New System.Windows.Forms.TextBox
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.CausesValidation = False
        Me.lblCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(33, 13)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Titulo"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtText
        '
        Me.txtText.BackColor = System.Drawing.Color.White
        Me.txtText.Location = New System.Drawing.Point(3, 17)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(92, 20)
        Me.txtText.TabIndex = 22
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Image = Global.WUC.My.Resources.Resources.Search
        Me.btnPesquisa.Location = New System.Drawing.Point(252, 14)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(27, 24)
        Me.btnPesquisa.TabIndex = 26
        Me.btnPesquisa.TabStop = False
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'picStatus
        '
        Me.picStatus.BackgroundImage = Global.WUC.My.Resources.Resources._Error
        Me.picStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picStatus.Location = New System.Drawing.Point(285, 16)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.Size = New System.Drawing.Size(22, 20)
        Me.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picStatus.TabIndex = 21
        Me.picStatus.TabStop = False
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.Location = New System.Drawing.Point(101, 17)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(144, 20)
        Me.txtDescricao.TabIndex = 27
        Me.txtDescricao.TabStop = False
        '
        'UcText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.btnPesquisa)
        Me.Controls.Add(Me.picStatus)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lblCaption)
        Me.Name = "UcText"
        Me.Size = New System.Drawing.Size(321, 43)
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents picStatus As System.Windows.Forms.PictureBox
    Friend WithEvents btnPesquisa As System.Windows.Forms.Button
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox

End Class
