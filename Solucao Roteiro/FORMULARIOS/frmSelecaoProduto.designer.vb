<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelecaoProduto
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
        Me.chkFiltroCliente = New System.Windows.Forms.CheckBox
        Me.txtSegmento = New WUC.UcText
        Me.txtSetor = New WUC.UcText
        Me.gridProduto = New System.Windows.Forms.DataGridView
        Me.bntOkCancel = New WUC.ucButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFiltroCliente)
        Me.GroupBox1.Controls.Add(Me.txtSegmento)
        Me.GroupBox1.Controls.Add(Me.txtSetor)
        Me.GroupBox1.Controls.Add(Me.gridProduto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 508)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'chkFiltroCliente
        '
        Me.chkFiltroCliente.AutoSize = True
        Me.chkFiltroCliente.Location = New System.Drawing.Point(22, 88)
        Me.chkFiltroCliente.Name = "chkFiltroCliente"
        Me.chkFiltroCliente.Size = New System.Drawing.Size(174, 17)
        Me.chkFiltroCliente.TabIndex = 2
        Me.chkFiltroCliente.Text = "Produtos associados ao Cliente"
        Me.chkFiltroCliente.UseVisualStyleBackColor = True
        '
        'txtSegmento
        '
        Me.txtSegmento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSegmento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSegmento.Caption = "Segmento"
        Me.txtSegmento.DataTextValue = Nothing
        Me.txtSegmento.Location = New System.Drawing.Point(15, 50)
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
        Me.txtSegmento.Size = New System.Drawing.Size(396, 25)
        Me.txtSegmento.sqlQuery = "Select Cod_Red_Produto as Codigo , Descricao as Descrição From Produto Where Nive" & _
            "l = 1"
        Me.txtSegmento.TabIndex = 1
        Me.txtSegmento.TextBoxLeft = CType(60, Short)
        Me.txtSegmento.TextWidth = 0
        Me.txtSegmento.Usuario = Nothing
        '
        'txtSetor
        '
        Me.txtSetor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSetor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSetor.Caption = "Setor"
        Me.txtSetor.DataTextValue = Nothing
        Me.txtSetor.Location = New System.Drawing.Point(15, 19)
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
        Me.txtSetor.Size = New System.Drawing.Size(396, 25)
        Me.txtSetor.sqlQuery = "Select Cod_Red_Produto as Codigo , Descricao as Descrição From Produto Where Nive" & _
            "l = 1"
        Me.txtSetor.TabIndex = 0
        Me.txtSetor.TextBoxLeft = CType(60, Short)
        Me.txtSetor.TextWidth = 0
        Me.txtSetor.Usuario = Nothing
        '
        'gridProduto
        '
        Me.gridProduto.BackgroundColor = System.Drawing.Color.White
        Me.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProduto.Location = New System.Drawing.Point(6, 111)
        Me.gridProduto.Name = "gridProduto"
        Me.gridProduto.Size = New System.Drawing.Size(419, 391)
        Me.gridProduto.TabIndex = 3
        '
        'bntOkCancel
        '
        Me.bntOkCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bntOkCancel.Location = New System.Drawing.Point(244, 527)
        Me.bntOkCancel.Name = "bntOkCancel"
        Me.bntOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.bntOkCancel.TabIndex = 1
        Me.bntOkCancel.TabStop = False
        '
        'frmSelecaoProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(455, 573)
        Me.Controls.Add(Me.bntOkCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelecaoProduto"
        Me.Text = "Seleção de Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gridProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiltroCliente As System.Windows.Forms.CheckBox
    Friend WithEvents txtSegmento As WUC.UcText
    Friend WithEvents txtSetor As WUC.UcText
    Friend WithEvents gridProduto As System.Windows.Forms.DataGridView
    Friend WithEvents bntOkCancel As WUC.ucButton
End Class
