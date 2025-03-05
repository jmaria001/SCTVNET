<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeterminacaoConsulta
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
        Me.txtVeiculo = New WUC.UcText
        Me.TxtPeriodoAte = New WUC.UcText
        Me.TxtPeriodode = New WUC.UcText
        Me.dgvDetConsulta = New System.Windows.Forms.DataGridView
        Me.btnOkCancel = New WUC.ucButton
        Me.btnDeterminar = New System.Windows.Forms.Button
        CType(Me.dgvDetConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtVeiculo
        '
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.txtVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtVeiculo.Caption = "Veiculo"
        Me.txtVeiculo.DataTextValue = Nothing
        Me.txtVeiculo.Location = New System.Drawing.Point(12, 12)
        Me.txtVeiculo.MaxLength = 3
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtVeiculo.pDecimal = CType(0, Byte)
        Me.txtVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.txtVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtVeiculo.showButton = True
        Me.txtVeiculo.ShowDescricao = True
        Me.txtVeiculo.Size = New System.Drawing.Size(387, 37)
        Me.txtVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.txtVeiculo.TabIndex = 0
        Me.txtVeiculo.TextBoxLeft = CType(0, Short)
        Me.txtVeiculo.TextWidth = 0
        '
        'TxtPeriodoAte
        '
        Me.TxtPeriodoAte.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPeriodoAte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtPeriodoAte.Caption = "Até:"
        Me.TxtPeriodoAte.DataTextValue = Nothing
        Me.TxtPeriodoAte.Location = New System.Drawing.Point(518, 12)
        Me.TxtPeriodoAte.MaxLength = 10
        Me.TxtPeriodoAte.Name = "TxtPeriodoAte"
        Me.TxtPeriodoAte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPeriodoAte.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtPeriodoAte.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtPeriodoAte.pDecimal = CType(0, Byte)
        Me.TxtPeriodoAte.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtPeriodoAte.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.TxtPeriodoAte.Size = New System.Drawing.Size(93, 37)
        Me.TxtPeriodoAte.sqlQuery = Nothing
        Me.TxtPeriodoAte.TabIndex = 2
        Me.TxtPeriodoAte.TextBoxLeft = CType(0, Short)
        Me.TxtPeriodoAte.TextWidth = 0
        '
        'TxtPeriodode
        '
        Me.TxtPeriodode.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPeriodode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtPeriodode.Caption = "Período - De:"
        Me.TxtPeriodode.DataTextValue = Nothing
        Me.TxtPeriodode.Location = New System.Drawing.Point(410, 12)
        Me.TxtPeriodode.MaxLength = 10
        Me.TxtPeriodode.Name = "TxtPeriodode"
        Me.TxtPeriodode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPeriodode.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtPeriodode.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtPeriodode.pDecimal = CType(0, Byte)
        Me.TxtPeriodode.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtPeriodode.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.TxtPeriodode.Size = New System.Drawing.Size(93, 37)
        Me.TxtPeriodode.sqlQuery = Nothing
        Me.TxtPeriodode.TabIndex = 1
        Me.TxtPeriodode.TextBoxLeft = CType(0, Short)
        Me.TxtPeriodode.TextWidth = 0
        '
        'dgvDetConsulta
        '
        Me.dgvDetConsulta.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetConsulta.Location = New System.Drawing.Point(12, 55)
        Me.dgvDetConsulta.Name = "dgvDetConsulta"
        Me.dgvDetConsulta.Size = New System.Drawing.Size(599, 351)
        Me.dgvDetConsulta.TabIndex = 3
        '
        'btnOkCancel
        '
        Me.btnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkCancel.Location = New System.Drawing.Point(429, 412)
        Me.btnOkCancel.Name = "btnOkCancel"
        Me.btnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.btnOkCancel.TabIndex = 5
        '
        'btnDeterminar
        '
        Me.btnDeterminar.Location = New System.Drawing.Point(12, 412)
        Me.btnDeterminar.Name = "btnDeterminar"
        Me.btnDeterminar.Size = New System.Drawing.Size(130, 32)
        Me.btnDeterminar.TabIndex = 4
        Me.btnDeterminar.Text = "Determinar "
        Me.btnDeterminar.UseVisualStyleBackColor = True
        '
        'frmDeterminacaoConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 455)
        Me.Controls.Add(Me.btnDeterminar)
        Me.Controls.Add(Me.btnOkCancel)
        Me.Controls.Add(Me.dgvDetConsulta)
        Me.Controls.Add(Me.txtVeiculo)
        Me.Controls.Add(Me.TxtPeriodoAte)
        Me.Controls.Add(Me.TxtPeriodode)
        Me.Name = "frmDeterminacaoConsulta"
        Me.Text = "Contratos com Comerciais a Determinar"
        CType(Me.dgvDetConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtVeiculo As WUC.UcText
    Friend WithEvents TxtPeriodoAte As WUC.UcText
    Friend WithEvents TxtPeriodode As WUC.UcText
    Friend WithEvents dgvDetConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents btnOkCancel As WUC.ucButton
    Friend WithEvents btnDeterminar As System.Windows.Forms.Button
End Class
