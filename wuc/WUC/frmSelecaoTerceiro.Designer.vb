<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelecaoTerceiro
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
        Me.gridTerceiro = New System.Windows.Forms.DataGridView
        Me.groupFiltro = New System.Windows.Forms.GroupBox
        Me.btnProcurar = New System.Windows.Forms.Button
        Me.ucNomeFantasia = New WUC.UcText
        Me.ucRazaoSocial = New WUC.UcText
        Me.ucCGC = New WUC.UcText
        Me.ucCodigo = New WUC.UcText
        Me.bntOnCancel = New WUC.ucButton
        CType(Me.gridTerceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridTerceiro
        '
        Me.gridTerceiro.BackgroundColor = System.Drawing.Color.White
        Me.gridTerceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTerceiro.Location = New System.Drawing.Point(12, 100)
        Me.gridTerceiro.Name = "gridTerceiro"
        Me.gridTerceiro.Size = New System.Drawing.Size(786, 371)
        Me.gridTerceiro.TabIndex = 1
        '
        'groupFiltro
        '
        Me.groupFiltro.Controls.Add(Me.btnProcurar)
        Me.groupFiltro.Controls.Add(Me.ucNomeFantasia)
        Me.groupFiltro.Controls.Add(Me.ucRazaoSocial)
        Me.groupFiltro.Controls.Add(Me.ucCGC)
        Me.groupFiltro.Controls.Add(Me.ucCodigo)
        Me.groupFiltro.Location = New System.Drawing.Point(12, 12)
        Me.groupFiltro.Name = "groupFiltro"
        Me.groupFiltro.Size = New System.Drawing.Size(786, 82)
        Me.groupFiltro.TabIndex = 0
        Me.groupFiltro.TabStop = False
        Me.groupFiltro.Text = "Filtros"
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(679, 19)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(101, 56)
        Me.btnProcurar.TabIndex = 4
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'ucNomeFantasia
        '
        Me.ucNomeFantasia.BackColor = System.Drawing.SystemColors.Control
        Me.ucNomeFantasia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucNomeFantasia.Caption = "Nome de Fantasia"
        Me.ucNomeFantasia.DataTextValue = Nothing
        Me.ucNomeFantasia.Location = New System.Drawing.Point(333, 50)
        Me.ucNomeFantasia.MaxLength = 50
        Me.ucNomeFantasia.Name = "ucNomeFantasia"
        Me.ucNomeFantasia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucNomeFantasia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucNomeFantasia.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucNomeFantasia.pDecimal = CType(0, Byte)
        Me.ucNomeFantasia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucNomeFantasia.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucNomeFantasia.Size = New System.Drawing.Size(321, 25)
        Me.ucNomeFantasia.sqlQuery = Nothing
        Me.ucNomeFantasia.TabIndex = 3
        Me.ucNomeFantasia.TextBoxLeft = CType(100, Short)
        Me.ucNomeFantasia.TextWidth = 0
        '
        'ucRazaoSocial
        '
        Me.ucRazaoSocial.BackColor = System.Drawing.SystemColors.Control
        Me.ucRazaoSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucRazaoSocial.Caption = "Razao Social"
        Me.ucRazaoSocial.DataTextValue = Nothing
        Me.ucRazaoSocial.Location = New System.Drawing.Point(6, 50)
        Me.ucRazaoSocial.MaxLength = 50
        Me.ucRazaoSocial.Name = "ucRazaoSocial"
        Me.ucRazaoSocial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucRazaoSocial.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucRazaoSocial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucRazaoSocial.pDecimal = CType(0, Byte)
        Me.ucRazaoSocial.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucRazaoSocial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucRazaoSocial.Size = New System.Drawing.Size(321, 25)
        Me.ucRazaoSocial.sqlQuery = Nothing
        Me.ucRazaoSocial.TabIndex = 2
        Me.ucRazaoSocial.TextBoxLeft = CType(100, Short)
        Me.ucRazaoSocial.TextWidth = 0
        '
        'ucCGC
        '
        Me.ucCGC.BackColor = System.Drawing.SystemColors.Control
        Me.ucCGC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCGC.Caption = "CNPJ / CPF"
        Me.ucCGC.DataTextValue = Nothing
        Me.ucCGC.Location = New System.Drawing.Point(333, 19)
        Me.ucCGC.MaxLength = 15
        Me.ucCGC.Name = "ucCGC"
        Me.ucCGC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCGC.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCGC.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucCGC.pDecimal = CType(0, Byte)
        Me.ucCGC.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCGC.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCGC.Size = New System.Drawing.Size(321, 25)
        Me.ucCGC.sqlQuery = Nothing
        Me.ucCGC.TabIndex = 1
        Me.ucCGC.TextBoxLeft = CType(100, Short)
        Me.ucCGC.TextWidth = 0
        '
        'ucCodigo
        '
        Me.ucCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.ucCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCodigo.Caption = "Código"
        Me.ucCodigo.DataTextValue = Nothing
        Me.ucCodigo.Location = New System.Drawing.Point(6, 19)
        Me.ucCodigo.MaxLength = 6
        Me.ucCodigo.Name = "ucCodigo"
        Me.ucCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCodigo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCodigo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucCodigo.pDecimal = CType(0, Byte)
        Me.ucCodigo.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCodigo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucCodigo.Size = New System.Drawing.Size(321, 25)
        Me.ucCodigo.sqlQuery = Nothing
        Me.ucCodigo.TabIndex = 0
        Me.ucCodigo.TextBoxLeft = CType(100, Short)
        Me.ucCodigo.TextWidth = 0
        '
        'bntOnCancel
        '
        Me.bntOnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.bntOnCancel.Location = New System.Drawing.Point(619, 477)
        Me.bntOnCancel.Name = "bntOnCancel"
        Me.bntOnCancel.Size = New System.Drawing.Size(179, 38)
        Me.bntOnCancel.TabIndex = 5
        '
        'frmSelecaoTerceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 521)
        Me.Controls.Add(Me.groupFiltro)
        Me.Controls.Add(Me.bntOnCancel)
        Me.Controls.Add(Me.gridTerceiro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "frmSelecaoTerceiro"
        Me.Text = "Seleção de Terceiros"
        CType(Me.gridTerceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridTerceiro As System.Windows.Forms.DataGridView
    Friend WithEvents bntOnCancel As WUC.ucButton
    Friend WithEvents groupFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents ucNomeFantasia As WUC.UcText
    Friend WithEvents ucRazaoSocial As WUC.UcText
    Friend WithEvents ucCGC As WUC.UcText
    Friend WithEvents ucCodigo As WUC.UcText
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
End Class
