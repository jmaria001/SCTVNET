<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrograma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrograma))
        Me.btnOpcoes = New System.Windows.Forms.ToolStrip
        Me.btnNovo = New System.Windows.Forms.ToolStripButton
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSair = New System.Windows.Forms.ToolStripButton
        Me.gridPrograma = New System.Windows.Forms.DataGridView
        Me.btnDesativar = New System.Windows.Forms.ToolStripButton
        Me.btnOpcoes.SuspendLayout()
        CType(Me.gridPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpcoes
        '
        Me.btnOpcoes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.btnOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnEditar, Me.btnDesativar, Me.btnExcluir, Me.ToolStripSeparator1, Me.btnSair})
        Me.btnOpcoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.btnOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.btnOpcoes.Name = "btnOpcoes"
        Me.btnOpcoes.Size = New System.Drawing.Size(799, 52)
        Me.btnOpcoes.TabIndex = 3
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
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
        'gridPrograma
        '
        Me.gridPrograma.BackgroundColor = System.Drawing.Color.White
        Me.gridPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPrograma.Location = New System.Drawing.Point(6, 55)
        Me.gridPrograma.Name = "gridPrograma"
        Me.gridPrograma.Size = New System.Drawing.Size(789, 487)
        Me.gridPrograma.TabIndex = 4
        '
        'btnDesativar
        '
        Me.btnDesativar.Image = Global.SCTVNET.My.Resources.Resources.cancelar2
        Me.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDesativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDesativar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(63, 49)
        Me.btnDesativar.Text = "  Desativar"
        Me.btnDesativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmPrograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 549)
        Me.Controls.Add(Me.gridPrograma)
        Me.Controls.Add(Me.btnOpcoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrograma"
        Me.Text = "Cadastro de Programas"
        Me.btnOpcoes.ResumeLayout(False)
        Me.btnOpcoes.PerformLayout()
        CType(Me.gridPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpcoes As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gridPrograma As System.Windows.Forms.DataGridView
    Friend WithEvents btnDesativar As System.Windows.Forms.ToolStripButton
End Class
