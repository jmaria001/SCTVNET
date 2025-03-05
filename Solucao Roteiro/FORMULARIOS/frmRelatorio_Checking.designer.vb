<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorio_Checking
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
        Me.ucData = New WCL_SCTV.UC.UCData
        Me.ucQualidade = New WUC.UcText
        Me.ucPrograma = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkVeiculacaoambos = New System.Windows.Forms.CheckBox
        Me.chkEncaixados = New System.Windows.Forms.CheckBox
        Me.chkFalhas = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkRoteiroAmbos = New System.Windows.Forms.CheckBox
        Me.chkNaoOrdenado = New System.Windows.Forms.CheckBox
        Me.chkOrdenado = New System.Windows.Forms.CheckBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.UcButton1 = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucData)
        Me.GroupBox1.Controls.Add(Me.ucQualidade)
        Me.GroupBox1.Controls.Add(Me.ucPrograma)
        Me.GroupBox1.Controls.Add(Me.ucVeiculo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'ucData
        '
        Me.ucData.BackColor = System.Drawing.Color.Transparent
        Me.ucData.DateTime = New Date(CType(0, Long))
        Me.ucData.Formato = "dd/MM/yyyy ddd"
        Me.ucData.Hoje = False
        Me.ucData.Location = New System.Drawing.Point(76, 154)
        Me.ucData.MaximumSize = New System.Drawing.Size(500, 23)
        Me.ucData.MinimumSize = New System.Drawing.Size(115, 23)
        Me.ucData.Name = "ucData"
        Me.ucData.Permite_Futuro = True
        Me.ucData.Permite_Limpar = True
        Me.ucData.Permite_Passado = True
        Me.ucData.Preenchimento_Obrigatorio = False
        Me.ucData.Size = New System.Drawing.Size(153, 23)
        Me.ucData.TabIndex = 10
        '
        'ucQualidade
        '
        Me.ucQualidade.BackColor = System.Drawing.SystemColors.Control
        Me.ucQualidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucQualidade.Caption = "Qualidade"
        Me.ucQualidade.DataTextValue = Nothing
        Me.ucQualidade.Location = New System.Drawing.Point(20, 109)
        Me.ucQualidade.MaxLength = 3
        Me.ucQualidade.Name = "ucQualidade"
        Me.ucQualidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucQualidade.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucQualidade.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucQualidade.pDecimal = CType(0, Byte)
        Me.ucQualidade.pDicionario = WUC.clsDicionario.enuDicionario.Qualidade
        Me.ucQualidade.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucQualidade.showButton = True
        Me.ucQualidade.ShowDescricao = True
        Me.ucQualidade.Size = New System.Drawing.Size(424, 25)
        Me.ucQualidade.sqlQuery = "execute PrNet_Qualidade_L"
        Me.ucQualidade.TabIndex = 3
        Me.ucQualidade.TextBoxLeft = CType(60, Short)
        Me.ucQualidade.TextWidth = 0
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(20, 64)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(424, 25)
        Me.ucPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma.TabIndex = 2
        Me.ucPrograma.TextBoxLeft = CType(60, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(20, 19)
        Me.ucVeiculo.MaxLength = 3
        Me.ucVeiculo.Name = "ucVeiculo"
        Me.ucVeiculo.Obrigatorio = True
        Me.ucVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVeiculo.pDecimal = CType(0, Byte)
        Me.ucVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVeiculo.showButton = True
        Me.ucVeiculo.ShowDescricao = True
        Me.ucVeiculo.Size = New System.Drawing.Size(424, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 1
        Me.ucVeiculo.TextBoxLeft = CType(60, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkVeiculacaoambos)
        Me.GroupBox2.Controls.Add(Me.chkEncaixados)
        Me.GroupBox2.Controls.Add(Me.chkFalhas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 88)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Situação das Veiculações"
        '
        'chkVeiculacaoambos
        '
        Me.chkVeiculacaoambos.AutoSize = True
        Me.chkVeiculacaoambos.Location = New System.Drawing.Point(9, 65)
        Me.chkVeiculacaoambos.Name = "chkVeiculacaoambos"
        Me.chkVeiculacaoambos.Size = New System.Drawing.Size(58, 17)
        Me.chkVeiculacaoambos.TabIndex = 2
        Me.chkVeiculacaoambos.Text = "Ambos"
        Me.chkVeiculacaoambos.UseVisualStyleBackColor = True
        '
        'chkEncaixados
        '
        Me.chkEncaixados.AutoSize = True
        Me.chkEncaixados.Location = New System.Drawing.Point(9, 42)
        Me.chkEncaixados.Name = "chkEncaixados"
        Me.chkEncaixados.Size = New System.Drawing.Size(178, 17)
        Me.chkEncaixados.TabIndex = 1
        Me.chkEncaixados.Text = "Imprimir Veiculacões sem Falhas"
        Me.chkEncaixados.UseVisualStyleBackColor = True
        '
        'chkFalhas
        '
        Me.chkFalhas.AutoSize = True
        Me.chkFalhas.Location = New System.Drawing.Point(9, 19)
        Me.chkFalhas.Name = "chkFalhas"
        Me.chkFalhas.Size = New System.Drawing.Size(179, 17)
        Me.chkFalhas.TabIndex = 0
        Me.chkFalhas.Text = "Imprimir Veiculações com Falhas"
        Me.chkFalhas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkRoteiroAmbos)
        Me.GroupBox3.Controls.Add(Me.chkNaoOrdenado)
        Me.GroupBox3.Controls.Add(Me.chkOrdenado)
        Me.GroupBox3.Location = New System.Drawing.Point(235, 249)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 88)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Situação do Roteiro"
        '
        'chkRoteiroAmbos
        '
        Me.chkRoteiroAmbos.AutoSize = True
        Me.chkRoteiroAmbos.Location = New System.Drawing.Point(13, 65)
        Me.chkRoteiroAmbos.Name = "chkRoteiroAmbos"
        Me.chkRoteiroAmbos.Size = New System.Drawing.Size(58, 17)
        Me.chkRoteiroAmbos.TabIndex = 2
        Me.chkRoteiroAmbos.Text = "Ambos"
        Me.chkRoteiroAmbos.UseVisualStyleBackColor = True
        '
        'chkNaoOrdenado
        '
        Me.chkNaoOrdenado.AutoSize = True
        Me.chkNaoOrdenado.Location = New System.Drawing.Point(13, 42)
        Me.chkNaoOrdenado.Name = "chkNaoOrdenado"
        Me.chkNaoOrdenado.Size = New System.Drawing.Size(196, 17)
        Me.chkNaoOrdenado.TabIndex = 1
        Me.chkNaoOrdenado.Text = "Imprimir Veiculacões não ordenadas"
        Me.chkNaoOrdenado.UseVisualStyleBackColor = True
        '
        'chkOrdenado
        '
        Me.chkOrdenado.AutoSize = True
        Me.chkOrdenado.Location = New System.Drawing.Point(13, 19)
        Me.chkOrdenado.Name = "chkOrdenado"
        Me.chkOrdenado.Size = New System.Drawing.Size(178, 17)
        Me.chkOrdenado.TabIndex = 0
        Me.chkOrdenado.Text = "Imprimir Veiculações ordenadas "
        Me.chkOrdenado.UseVisualStyleBackColor = True
        '
        'chkCanceladas
        '
        Me.chkCanceladas.AutoSize = True
        Me.chkCanceladas.Location = New System.Drawing.Point(12, 353)
        Me.chkCanceladas.Name = "chkCanceladas"
        Me.chkCanceladas.Size = New System.Drawing.Size(204, 17)
        Me.chkCanceladas.TabIndex = 3
        Me.chkCanceladas.Text = "Nâo Imprimir Veiculacões Canceladas"
        Me.chkCanceladas.UseVisualStyleBackColor = True
        '
        'UcButton1
        '
        Me.UcButton1.BackColor = System.Drawing.SystemColors.Control
        Me.UcButton1.Location = New System.Drawing.Point(307, 343)
        Me.UcButton1.Name = "UcButton1"
        Me.UcButton1.Size = New System.Drawing.Size(179, 38)
        Me.UcButton1.TabIndex = 4
        '
        'frmRelatorio_Checking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 384)
        Me.Controls.Add(Me.UcButton1)
        Me.Controls.Add(Me.chkCanceladas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelatorio_Checking"
        Me.Text = "Listagem Diária de Cheching"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkVeiculacaoambos As System.Windows.Forms.CheckBox
    Friend WithEvents chkEncaixados As System.Windows.Forms.CheckBox
    Friend WithEvents chkFalhas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRoteiroAmbos As System.Windows.Forms.CheckBox
    Friend WithEvents chkNaoOrdenado As System.Windows.Forms.CheckBox
    Friend WithEvents chkOrdenado As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents ucData As WCL_SCTV.UC.UCData
    Friend WithEvents ucQualidade As WUC.UcText
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UcButton1 As WUC.ucButton
End Class
