<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerceiroProduto
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
        Me.txtSegmento = New WUC.UcText
        Me.txtSetor = New WUC.UcText
        Me.gridProduto = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.gridAssociado = New System.Windows.Forms.DataGridView
        Me.btnAdiciona = New System.Windows.Forms.Button
        Me.btnExclui = New System.Windows.Forms.Button
        Me.btnAdicionarTodos = New System.Windows.Forms.Button
        Me.btnExcluirTodos = New System.Windows.Forms.Button
        Me.txtTerceiro = New WUC.UcText
        Me.bntOkCancel = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridAssociado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSegmento)
        Me.GroupBox1.Controls.Add(Me.txtSetor)
        Me.GroupBox1.Controls.Add(Me.gridProduto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 439)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecionar"
        '
        'txtSegmento
        '
        Me.txtSegmento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSegmento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSegmento.Caption = "Segmento"
        Me.txtSegmento.DataTextValue = Nothing
        Me.txtSegmento.Location = New System.Drawing.Point(9, 52)
        Me.txtSegmento.MaxLength = 6
        Me.txtSegmento.Name = "txtSegmento"
        Me.txtSegmento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegmento.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtSegmento.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtSegmento.pDecimal = CType(0, Byte)
        Me.txtSegmento.pDicionario = WUC.clsDicionario.enuDicionario.Segmento
        Me.txtSegmento.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtSegmento.showButton = True
        Me.txtSegmento.ShowDescricao = True
        Me.txtSegmento.Size = New System.Drawing.Size(414, 25)
        Me.txtSegmento.TabIndex = 2
        Me.txtSegmento.TextBoxLeft = CType(60, Short)
        Me.txtSegmento.TextWidth = 0
        '
        'txtSetor
        '
        Me.txtSetor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSetor.Caption = "Setor"
        Me.txtSetor.DataTextValue = Nothing
        Me.txtSetor.Location = New System.Drawing.Point(9, 21)
        Me.txtSetor.MaxLength = 6
        Me.txtSetor.Name = "txtSetor"
        Me.txtSetor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSetor.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtSetor.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtSetor.pDecimal = CType(0, Byte)
        Me.txtSetor.pDicionario = WUC.clsDicionario.enuDicionario.Setor
        Me.txtSetor.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtSetor.showButton = True
        Me.txtSetor.ShowDescricao = True
        Me.txtSetor.Size = New System.Drawing.Size(414, 25)
        Me.txtSetor.sqlQuery = "Execute PrNet_Produto_L null,1"
        Me.txtSetor.TabIndex = 1
        Me.txtSetor.TextBoxLeft = CType(60, Short)
        Me.txtSetor.TextWidth = 0
        '
        'gridProduto
        '
        Me.gridProduto.BackgroundColor = System.Drawing.Color.White
        Me.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProduto.Location = New System.Drawing.Point(9, 83)
        Me.gridProduto.Name = "gridProduto"
        Me.gridProduto.Size = New System.Drawing.Size(414, 350)
        Me.gridProduto.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gridAssociado)
        Me.GroupBox2.Location = New System.Drawing.Point(507, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 439)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Associados"
        '
        'gridAssociado
        '
        Me.gridAssociado.BackgroundColor = System.Drawing.Color.White
        Me.gridAssociado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAssociado.Location = New System.Drawing.Point(6, 19)
        Me.gridAssociado.Name = "gridAssociado"
        Me.gridAssociado.Size = New System.Drawing.Size(396, 414)
        Me.gridAssociado.TabIndex = 0
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Location = New System.Drawing.Point(441, 153)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(64, 30)
        Me.btnAdiciona.TabIndex = 3
        Me.btnAdiciona.TabStop = False
        Me.btnAdiciona.Text = ">"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'btnExclui
        '
        Me.btnExclui.Location = New System.Drawing.Point(441, 189)
        Me.btnExclui.Name = "btnExclui"
        Me.btnExclui.Size = New System.Drawing.Size(64, 30)
        Me.btnExclui.TabIndex = 4
        Me.btnExclui.TabStop = False
        Me.btnExclui.Text = "<"
        Me.btnExclui.UseVisualStyleBackColor = True
        '
        'btnAdicionarTodos
        '
        Me.btnAdicionarTodos.Location = New System.Drawing.Point(441, 225)
        Me.btnAdicionarTodos.Name = "btnAdicionarTodos"
        Me.btnAdicionarTodos.Size = New System.Drawing.Size(64, 30)
        Me.btnAdicionarTodos.TabIndex = 6
        Me.btnAdicionarTodos.TabStop = False
        Me.btnAdicionarTodos.Text = ">>"
        Me.btnAdicionarTodos.UseVisualStyleBackColor = True
        '
        'btnExcluirTodos
        '
        Me.btnExcluirTodos.Location = New System.Drawing.Point(441, 261)
        Me.btnExcluirTodos.Name = "btnExcluirTodos"
        Me.btnExcluirTodos.Size = New System.Drawing.Size(64, 30)
        Me.btnExcluirTodos.TabIndex = 7
        Me.btnExcluirTodos.TabStop = False
        Me.btnExcluirTodos.Text = "<<"
        Me.btnExcluirTodos.UseVisualStyleBackColor = True
        '
        'txtTerceiro
        '
        Me.txtTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTerceiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTerceiro.Caption = "Cliente"
        Me.txtTerceiro.DataTextValue = Nothing
        Me.txtTerceiro.Enabled = False
        Me.txtTerceiro.Location = New System.Drawing.Point(21, 12)
        Me.txtTerceiro.MaxLength = 32767
        Me.txtTerceiro.Name = "txtTerceiro"
        Me.txtTerceiro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTerceiro.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtTerceiro.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtTerceiro.pDecimal = CType(0, Byte)
        Me.txtTerceiro.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtTerceiro.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTerceiro.ShowDescricao = True
        Me.txtTerceiro.Size = New System.Drawing.Size(913, 25)
        Me.txtTerceiro.sqlQuery = Nothing
        Me.txtTerceiro.TabIndex = 0
        Me.txtTerceiro.TextBoxLeft = CType(0, Short)
        Me.txtTerceiro.TextWidth = 90
        '
        'bntOkCancel
        '
        Me.bntOkCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bntOkCancel.Location = New System.Drawing.Point(738, 483)
        Me.bntOkCancel.Name = "bntOkCancel"
        Me.bntOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.bntOkCancel.TabIndex = 5
        '
        'frmTerceiroProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(927, 526)
        Me.Controls.Add(Me.btnExcluirTodos)
        Me.Controls.Add(Me.btnAdicionarTodos)
        Me.Controls.Add(Me.txtTerceiro)
        Me.Controls.Add(Me.bntOkCancel)
        Me.Controls.Add(Me.btnExclui)
        Me.Controls.Add(Me.btnAdiciona)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTerceiroProduto"
        Me.Text = "Associação de Produtos ao Cliente"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridAssociado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridProduto As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gridAssociado As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdiciona As System.Windows.Forms.Button
    Friend WithEvents btnExclui As System.Windows.Forms.Button
    Friend WithEvents bntOkCancel As WUC.ucButton
    Friend WithEvents txtSegmento As WUC.UcText
    Friend WithEvents txtSetor As WUC.UcText
    Friend WithEvents txtTerceiro As WUC.UcText
    Friend WithEvents btnAdicionarTodos As System.Windows.Forms.Button
    Friend WithEvents btnExcluirTodos As System.Windows.Forms.Button
End Class
