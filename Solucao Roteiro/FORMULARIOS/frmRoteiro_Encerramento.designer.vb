<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoteiro_Encerramento
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkEncerramento = New System.Windows.Forms.CheckBox
        Me.chkOK = New System.Windows.Forms.CheckBox
        Me.btnOkCancel = New WUC.ucButton
        Me.ucVeiculo = New WUC.UcText
        Me.UcData = New WCL_SCTV.UC.UCData
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucVeiculo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.UcData)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkEncerramento
        '
        Me.chkEncerramento.AutoSize = True
        Me.chkEncerramento.Location = New System.Drawing.Point(21, 142)
        Me.chkEncerramento.Name = "chkEncerramento"
        Me.chkEncerramento.Size = New System.Drawing.Size(92, 17)
        Me.chkEncerramento.TabIndex = 7
        Me.chkEncerramento.Text = "Encerramento"
        Me.chkEncerramento.UseVisualStyleBackColor = True
        Me.chkEncerramento.Visible = False
        '
        'chkOK
        '
        Me.chkOK.AutoSize = True
        Me.chkOK.Location = New System.Drawing.Point(145, 142)
        Me.chkOK.Name = "chkOK"
        Me.chkOK.Size = New System.Drawing.Size(38, 17)
        Me.chkOK.TabIndex = 8
        Me.chkOK.Text = "ok"
        Me.chkOK.UseVisualStyleBackColor = True
        Me.chkOK.Visible = False
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(267, 129)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 9
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(11, 20)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(407, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'UcData
        '
        Me.UcData.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy "
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(54, 60)
        Me.UcData.MaximumSize = New System.Drawing.Size(500, 23)
        Me.UcData.MinimumSize = New System.Drawing.Size(115, 23)
        Me.UcData.Name = "UcData"
        Me.UcData.Permite_Futuro = True
        Me.UcData.Permite_Limpar = True
        Me.UcData.Permite_Passado = True
        Me.UcData.Preenchimento_Obrigatorio = False
        Me.UcData.Size = New System.Drawing.Size(135, 23)
        Me.UcData.TabIndex = 1
        '
        'frmRoteiro_Encerramento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 176)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.chkOK)
        Me.Controls.Add(Me.chkEncerramento)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoteiro_Encerramento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmRoteiro_Encerramento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEncerramento As System.Windows.Forms.CheckBox
    Friend WithEvents chkOK As System.Windows.Forms.CheckBox
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents btnOkCancel As WUC.ucButton
End Class
