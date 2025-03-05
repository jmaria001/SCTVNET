<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorio_Roteiro
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
        Me.chkNet = New System.Windows.Forms.CheckBox
        Me.chkCapa = New System.Windows.Forms.CheckBox
        Me.chkLinha = New System.Windows.Forms.CheckBox
        Me.cboLinhas = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ucPrograma1 = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.ucData = New WCL_SCTV.UC.UCData
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnOkCancel = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkNet
        '
        Me.chkNet.AutoSize = True
        Me.chkNet.Checked = True
        Me.chkNet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNet.Location = New System.Drawing.Point(219, 29)
        Me.chkNet.Name = "chkNet"
        Me.chkNet.Size = New System.Drawing.Size(128, 17)
        Me.chkNet.TabIndex = 5
        Me.chkNet.Text = "Listar Comercias NET"
        Me.chkNet.UseVisualStyleBackColor = True
        '
        'chkCapa
        '
        Me.chkCapa.AutoSize = True
        Me.chkCapa.Checked = True
        Me.chkCapa.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCapa.Location = New System.Drawing.Point(14, 29)
        Me.chkCapa.Name = "chkCapa"
        Me.chkCapa.Size = New System.Drawing.Size(142, 17)
        Me.chkCapa.TabIndex = 4
        Me.chkCapa.Text = "Imprime Capa do Roteiro"
        Me.chkCapa.UseVisualStyleBackColor = True
        '
        'chkLinha
        '
        Me.chkLinha.AutoSize = True
        Me.chkLinha.Location = New System.Drawing.Point(14, 61)
        Me.chkLinha.Name = "chkLinha"
        Me.chkLinha.Size = New System.Drawing.Size(246, 17)
        Me.chkLinha.TabIndex = 0
        Me.chkLinha.Text = "Imprimir espaço em branco entre os comerciais"
        Me.chkLinha.UseVisualStyleBackColor = True
        '
        'cboLinhas
        '
        Me.cboLinhas.FormattingEnabled = True
        Me.cboLinhas.Location = New System.Drawing.Point(14, 82)
        Me.cboLinhas.Name = "cboLinhas"
        Me.cboLinhas.Size = New System.Drawing.Size(270, 21)
        Me.cboLinhas.TabIndex = 9
        Me.cboLinhas.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucPrograma1)
        Me.GroupBox1.Controls.Add(Me.ucVeiculo)
        Me.GroupBox1.Controls.Add(Me.ucData)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'ucPrograma1
        '
        Me.ucPrograma1.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma1.Caption = "Programa"
        Me.ucPrograma1.DataTextValue = Nothing
        Me.ucPrograma1.Location = New System.Drawing.Point(14, 106)
        Me.ucPrograma1.MaxLength = 4
        Me.ucPrograma1.Name = "ucPrograma1"
        Me.ucPrograma1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma1.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma1.pDecimal = CType(0, Byte)
        Me.ucPrograma1.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma1.showButton = True
        Me.ucPrograma1.ShowDescricao = True
        Me.ucPrograma1.Size = New System.Drawing.Size(362, 25)
        Me.ucPrograma1.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma1.TabIndex = 2
        Me.ucPrograma1.TextBoxLeft = CType(0, Short)
        Me.ucPrograma1.TextWidth = 0
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(14, 19)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(362, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(60, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'ucData
        '
        Me.ucData.BackColor = System.Drawing.Color.Transparent
        Me.ucData.DateTime = New Date(CType(0, Long))
        Me.ucData.Formato = "dd/MM/yyyy "
        Me.ucData.Hoje = False
        Me.ucData.Location = New System.Drawing.Point(125, 59)
        Me.ucData.MaximumSize = New System.Drawing.Size(500, 23)
        Me.ucData.MinimumSize = New System.Drawing.Size(115, 23)
        Me.ucData.Name = "ucData"
        Me.ucData.Permite_Futuro = True
        Me.ucData.Permite_Limpar = True
        Me.ucData.Permite_Passado = True
        Me.ucData.Preenchimento_Obrigatorio = False
        Me.ucData.Size = New System.Drawing.Size(135, 23)
        Me.ucData.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data da Programação"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCapa)
        Me.GroupBox3.Controls.Add(Me.chkLinha)
        Me.GroupBox3.Controls.Add(Me.cboLinhas)
        Me.GroupBox3.Controls.Add(Me.chkNet)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(382, 119)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo do Relatório"
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(215, 328)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 14
        '
        'frmRelatorio_Roteiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 382)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelatorio_Roteiro"
        Me.ShowInTaskbar = False
        Me.Text = "Impressão do Roteiro de Programação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkNet As System.Windows.Forms.CheckBox
    Friend WithEvents chkCapa As System.Windows.Forms.CheckBox
    Friend WithEvents chkLinha As System.Windows.Forms.CheckBox
    Friend WithEvents cboLinhas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ucData As WCL_SCTV.UC.UCData
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents ucPrograma1 As WUC.UcText
    Friend WithEvents ucVeiculo As WUC.UcText
End Class
