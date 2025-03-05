<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerceiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTerceiro))
        Me.gridTerceiro = New System.Windows.Forms.DataGridView
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnOpcoes = New System.Windows.Forms.ToolStrip
        Me.btnNovo = New System.Windows.Forms.ToolStripButton
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton
        Me.btnFiltrar = New System.Windows.Forms.ToolStripButton
        Me.btnProduto = New System.Windows.Forms.ToolStripButton
        Me.btnEMpresa = New System.Windows.Forms.ToolStripButton
        Me.btnSair = New System.Windows.Forms.ToolStripButton
        CType(Me.gridTerceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnOpcoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridTerceiro
        '
        Me.gridTerceiro.BackgroundColor = System.Drawing.Color.White
        Me.gridTerceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTerceiro.Location = New System.Drawing.Point(8, 55)
        Me.gridTerceiro.Name = "gridTerceiro"
        Me.gridTerceiro.Size = New System.Drawing.Size(903, 543)
        Me.gridTerceiro.TabIndex = 3
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'btnOpcoes
        '
        Me.btnOpcoes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.btnOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnEditar, Me.btnExcluir, Me.btnFiltrar, Me.btnProduto, Me.btnEMpresa, Me.ToolStripSeparator1, Me.btnSair})
        Me.btnOpcoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.btnOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.btnOpcoes.Name = "btnOpcoes"
        Me.btnOpcoes.Size = New System.Drawing.Size(916, 52)
        Me.btnOpcoes.TabIndex = 2
        Me.btnOpcoes.Text = "ToolStrip1"
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(54, 49)
        Me.btnNovo.Text = "   Novo   "
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.SCTVNET.My.Resources.Resources.Alterar1
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(57, 49)
        Me.btnEditar.Text = "   Editar   "
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.SCTVNET.My.Resources.Resources.Lixeira
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(60, 49)
        Me.btnExcluir.Text = "   Excluir   "
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.SCTVNET.My.Resources.Resources.Binocolo
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(57, 49)
        Me.btnFiltrar.Text = "   Filtrar   "
        Me.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnProduto
        '
        Me.btnProduto.Image = Global.SCTVNET.My.Resources.Resources.produto
        Me.btnProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnProduto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(72, 49)
        Me.btnProduto.Text = "   Produtos   "
        Me.btnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEMpresa
        '
        Me.btnEMpresa.Image = Global.SCTVNET.My.Resources.Resources.Empresas
        Me.btnEMpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEMpresa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEMpresa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEMpresa.Name = "btnEMpresa"
        Me.btnEMpresa.Size = New System.Drawing.Size(117, 49)
        Me.btnEMpresa.Text = "Desassociar Empresas"
        Me.btnEMpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEMpresa.Visible = False
        '
        'btnSair
        '
        Me.btnSair.Image = Global.SCTVNET.My.Resources.Resources.Sair
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(47, 49)
        Me.btnSair.Text = "   Sair   "
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmTerceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 601)
        Me.Controls.Add(Me.gridTerceiro)
        Me.Controls.Add(Me.btnOpcoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTerceiro"
        Me.Text = "Cadastro de Terceiros"
        CType(Me.gridTerceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnOpcoes.ResumeLayout(False)
        Me.btnOpcoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridTerceiro As System.Windows.Forms.DataGridView
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFiltrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProduto As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEMpresa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOpcoes As System.Windows.Forms.ToolStrip

End Class
