<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmacaoRoteiro
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
        Me.gridVeiculo = New System.Windows.Forms.DataGridView
        Me.ucDataLocal = New WUC.UcText
        Me.ucDataRede = New WUC.UcText
        Me.btnConfirmacao = New WUC.ucButton
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridVeiculo
        '
        Me.gridVeiculo.BackgroundColor = System.Drawing.Color.White
        Me.gridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVeiculo.Location = New System.Drawing.Point(13, 13)
        Me.gridVeiculo.Name = "gridVeiculo"
        Me.gridVeiculo.Size = New System.Drawing.Size(648, 379)
        Me.gridVeiculo.TabIndex = 3
        '
        'ucDataLocal
        '
        Me.ucDataLocal.BackColor = System.Drawing.SystemColors.Control
        Me.ucDataLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucDataLocal.Caption = "Data a ser Confirmado"
        Me.ucDataLocal.DataTextValue = Nothing
        Me.ucDataLocal.Location = New System.Drawing.Point(13, 418)
        Me.ucDataLocal.MaxLength = 10
        Me.ucDataLocal.Name = "ucDataLocal"
        Me.ucDataLocal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucDataLocal.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucDataLocal.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucDataLocal.pDecimal = CType(0, Byte)
        Me.ucDataLocal.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucDataLocal.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.ucDataLocal.Size = New System.Drawing.Size(207, 25)
        Me.ucDataLocal.sqlQuery = Nothing
        Me.ucDataLocal.TabIndex = 0
        Me.ucDataLocal.TextBoxLeft = CType(0, Short)
        Me.ucDataLocal.TextWidth = 0
        '
        'ucDataRede
        '
        Me.ucDataRede.BackColor = System.Drawing.SystemColors.Control
        Me.ucDataRede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucDataRede.Caption = "Confirmação Rede"
        Me.ucDataRede.DataTextValue = Nothing
        Me.ucDataRede.Location = New System.Drawing.Point(258, 400)
        Me.ucDataRede.MaxLength = 10
        Me.ucDataRede.Name = "ucDataRede"
        Me.ucDataRede.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucDataRede.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucDataRede.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucDataRede.pDecimal = CType(0, Byte)
        Me.ucDataRede.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucDataRede.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.ucDataRede.Size = New System.Drawing.Size(207, 25)
        Me.ucDataRede.sqlQuery = Nothing
        Me.ucDataRede.TabIndex = 1
        Me.ucDataRede.TextBoxLeft = CType(0, Short)
        Me.ucDataRede.TextWidth = 0
        Me.ucDataRede.Visible = False
        '
        'btnConfirmacao
        '
        Me.btnConfirmacao.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfirmacao.Location = New System.Drawing.Point(482, 418)
        Me.btnConfirmacao.Name = "btnConfirmacao"
        Me.btnConfirmacao.Size = New System.Drawing.Size(179, 38)
        Me.btnConfirmacao.TabIndex = 2
        '
        'frmConfirmacaoRoteiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 468)
        Me.Controls.Add(Me.btnConfirmacao)
        Me.Controls.Add(Me.ucDataRede)
        Me.Controls.Add(Me.ucDataLocal)
        Me.Controls.Add(Me.gridVeiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmConfirmacaoRoteiro"
        Me.Text = "Confirmação de Roteiro"
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridVeiculo As System.Windows.Forms.DataGridView
    Friend WithEvents ucDataLocal As WUC.UcText
    Friend WithEvents ucDataRede As WUC.UcText
    Friend WithEvents btnConfirmacao As WUC.ucButton


End Class
