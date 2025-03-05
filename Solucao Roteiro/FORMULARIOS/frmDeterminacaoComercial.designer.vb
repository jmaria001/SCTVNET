<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeterminacaoComercial
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDatade = New WUC.UcText
        Me.txtPrograma = New WUC.UcText
        Me.txtDataAte = New WUC.UcText
        Me.dgvDeterminar = New System.Windows.Forms.DataGridView
        Me.dgvNovo = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnDeterminar = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDeterminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDatade)
        Me.GroupBox1.Controls.Add(Me.txtPrograma)
        Me.GroupBox1.Controls.Add(Me.txtDataAte)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 77)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'TxtDatade
        '
        Me.TxtDatade.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDatade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtDatade.Caption = "Período - De:"
        Me.TxtDatade.DataTextValue = Nothing
        Me.TxtDatade.Location = New System.Drawing.Point(6, 19)
        Me.TxtDatade.MaxLength = 10
        Me.TxtDatade.Name = "TxtDatade"
        Me.TxtDatade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDatade.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtDatade.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtDatade.pDecimal = CType(0, Byte)
        Me.TxtDatade.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtDatade.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.TxtDatade.Size = New System.Drawing.Size(89, 37)
        Me.TxtDatade.sqlQuery = Nothing
        Me.TxtDatade.TabIndex = 11
        Me.TxtDatade.TextBoxLeft = CType(0, Short)
        Me.TxtDatade.TextWidth = 0
        '
        'txtPrograma
        '
        Me.txtPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.txtPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtPrograma.Caption = "Programa"
        Me.txtPrograma.DataTextValue = Nothing
        Me.txtPrograma.Location = New System.Drawing.Point(199, 19)
        Me.txtPrograma.MaxLength = 4
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtPrograma.pDecimal = CType(0, Byte)
        Me.txtPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.txtPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtPrograma.showButton = True
        Me.txtPrograma.ShowDescricao = True
        Me.txtPrograma.Size = New System.Drawing.Size(339, 37)
        Me.txtPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.txtPrograma.TabIndex = 13
        Me.txtPrograma.TextBoxLeft = CType(0, Short)
        Me.txtPrograma.TextWidth = 0
        '
        'txtDataAte
        '
        Me.txtDataAte.BackColor = System.Drawing.SystemColors.Control
        Me.txtDataAte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtDataAte.Caption = "Até:"
        Me.txtDataAte.DataTextValue = Nothing
        Me.txtDataAte.Location = New System.Drawing.Point(101, 19)
        Me.txtDataAte.MaxLength = 10
        Me.txtDataAte.Name = "txtDataAte"
        Me.txtDataAte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDataAte.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtDataAte.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtDataAte.pDecimal = CType(0, Byte)
        Me.txtDataAte.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtDataAte.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.txtDataAte.Size = New System.Drawing.Size(89, 37)
        Me.txtDataAte.sqlQuery = Nothing
        Me.txtDataAte.TabIndex = 12
        Me.txtDataAte.TextBoxLeft = CType(0, Short)
        Me.txtDataAte.TextWidth = 0
        '
        'dgvDeterminar
        '
        Me.dgvDeterminar.BackgroundColor = System.Drawing.Color.White
        Me.dgvDeterminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeterminar.Location = New System.Drawing.Point(12, 141)
        Me.dgvDeterminar.Name = "dgvDeterminar"
        Me.dgvDeterminar.Size = New System.Drawing.Size(538, 127)
        Me.dgvDeterminar.TabIndex = 18
        '
        'dgvNovo
        '
        Me.dgvNovo.BackgroundColor = System.Drawing.Color.White
        Me.dgvNovo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNovo.Location = New System.Drawing.Point(12, 310)
        Me.dgvNovo.Name = "dgvNovo"
        Me.dgvNovo.Size = New System.Drawing.Size(538, 127)
        Me.dgvNovo.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Selecione o comercial a ser determinado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Selecione o novo Comercial (um ou mais)"
        '
        'btnDeterminar
        '
        Me.btnDeterminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeterminar.Location = New System.Drawing.Point(371, 450)
        Me.btnDeterminar.Name = "btnDeterminar"
        Me.btnDeterminar.Size = New System.Drawing.Size(179, 38)
        Me.btnDeterminar.TabIndex = 20
        '
        'frmDeterminacaoComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 500)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeterminar)
        Me.Controls.Add(Me.dgvNovo)
        Me.Controls.Add(Me.dgvDeterminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDeterminacaoComercial"
        Me.Text = "Determinação para todos os Veículos:"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDeterminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNovo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDataAte As WUC.UcText
    Friend WithEvents TxtDatade As WUC.UcText
    Friend WithEvents txtPrograma As WUC.UcText
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDeterminar As System.Windows.Forms.DataGridView
    Friend WithEvents dgvNovo As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeterminar As WUC.ucButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
