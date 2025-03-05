<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoteiro_Usuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoteiro_Usuario))
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.ucPrograma = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.chkPerfil = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.OptOperacao_2 = New System.Windows.Forms.RadioButton
        Me.optComposicao = New System.Windows.Forms.RadioButton
        Me.OptOrdenado = New System.Windows.Forms.RadioButton
        Me.PicOrdenacao = New System.Windows.Forms.PictureBox
        Me.picComposicao = New System.Windows.Forms.PictureBox
        Me._Label1_0 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbAmbos = New System.Windows.Forms.RadioButton
        Me.rdbComposicao = New System.Windows.Forms.RadioButton
        Me.rdbOrdenado = New System.Windows.Forms.RadioButton
        Me.dgvPorta = New System.Windows.Forms.DataGridView
        Me.cmdExcluir = New System.Windows.Forms.Button
        Me.cmdAtualizar = New System.Windows.Forms.Button
        Me.cmdSair = New System.Windows.Forms.Button
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.PicOrdenacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPorta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.ucPrograma)
        Me.Frame2.Controls.Add(Me.ucVeiculo)
        Me.Frame2.Controls.Add(Me.btnFiltrar)
        Me.Frame2.Controls.Add(Me.chkPerfil)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(134, 396)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(383, 112)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Filtros"
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(6, 48)
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
        Me.ucPrograma.Size = New System.Drawing.Size(359, 25)
        Me.ucPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.ucPrograma.TabIndex = 1
        Me.ucPrograma.TextBoxLeft = CType(60, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'ucVeiculo
        '
        Me.ucVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.ucVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucVeiculo.Caption = "Veiculo"
        Me.ucVeiculo.DataTextValue = Nothing
        Me.ucVeiculo.Location = New System.Drawing.Point(6, 19)
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
        Me.ucVeiculo.Size = New System.Drawing.Size(359, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(60, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(290, 79)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 20
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'chkPerfil
        '
        Me.chkPerfil.BackColor = System.Drawing.SystemColors.Control
        Me.chkPerfil.Checked = True
        Me.chkPerfil.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPerfil.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPerfil.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPerfil.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPerfil.Location = New System.Drawing.Point(12, 83)
        Me.chkPerfil.Name = "chkPerfil"
        Me.chkPerfil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPerfil.Size = New System.Drawing.Size(211, 16)
        Me.chkPerfil.TabIndex = 2
        Me.chkPerfil.Text = "Somente Veiculos do meu Perfil"
        Me.chkPerfil.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.OptOperacao_2)
        Me.Frame1.Controls.Add(Me.optComposicao)
        Me.Frame1.Controls.Add(Me.OptOrdenado)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(-195, 80)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(115, 112)
        Me.Frame1.TabIndex = 25
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Operação"
        '
        'OptOperacao_2
        '
        Me.OptOperacao_2.BackColor = System.Drawing.SystemColors.Control
        Me.OptOperacao_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptOperacao_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOperacao_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptOperacao_2.Location = New System.Drawing.Point(7, 69)
        Me.OptOperacao_2.Name = "OptOperacao_2"
        Me.OptOperacao_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptOperacao_2.Size = New System.Drawing.Size(97, 25)
        Me.OptOperacao_2.TabIndex = 11
        Me.OptOperacao_2.TabStop = True
        Me.OptOperacao_2.Text = "Ambos"
        Me.OptOperacao_2.UseVisualStyleBackColor = False
        '
        'optComposicao
        '
        Me.optComposicao.BackColor = System.Drawing.SystemColors.Control
        Me.optComposicao.Cursor = System.Windows.Forms.Cursors.Default
        Me.optComposicao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optComposicao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optComposicao.Location = New System.Drawing.Point(7, 48)
        Me.optComposicao.Name = "optComposicao"
        Me.optComposicao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optComposicao.Size = New System.Drawing.Size(102, 18)
        Me.optComposicao.TabIndex = 10
        Me.optComposicao.TabStop = True
        Me.optComposicao.Text = "Composição de Breaks"
        Me.optComposicao.UseVisualStyleBackColor = False
        '
        'OptOrdenado
        '
        Me.OptOrdenado.BackColor = System.Drawing.SystemColors.Control
        Me.OptOrdenado.Checked = True
        Me.OptOrdenado.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptOrdenado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOrdenado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptOrdenado.Location = New System.Drawing.Point(7, 24)
        Me.OptOrdenado.Name = "OptOrdenado"
        Me.OptOrdenado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptOrdenado.Size = New System.Drawing.Size(97, 17)
        Me.OptOrdenado.TabIndex = 9
        Me.OptOrdenado.TabStop = True
        Me.OptOrdenado.Text = "Ordenação"
        Me.OptOrdenado.UseVisualStyleBackColor = False
        '
        'PicOrdenacao
        '
        Me.PicOrdenacao.BackColor = System.Drawing.Color.Blue
        Me.PicOrdenacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicOrdenacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicOrdenacao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicOrdenacao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PicOrdenacao.Location = New System.Drawing.Point(523, 396)
        Me.PicOrdenacao.Name = "PicOrdenacao"
        Me.PicOrdenacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicOrdenacao.Size = New System.Drawing.Size(13, 13)
        Me.PicOrdenacao.TabIndex = 22
        Me.PicOrdenacao.TabStop = False
        '
        'picComposicao
        '
        Me.picComposicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picComposicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picComposicao.Cursor = System.Windows.Forms.Cursors.Default
        Me.picComposicao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picComposicao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picComposicao.Location = New System.Drawing.Point(523, 417)
        Me.picComposicao.Name = "picComposicao"
        Me.picComposicao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picComposicao.Size = New System.Drawing.Size(13, 13)
        Me.picComposicao.TabIndex = 21
        Me.picComposicao.TabStop = False
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(541, 395)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(144, 14)
        Me._Label1_0.TabIndex = 24
        Me._Label1_0.Text = "Usuários Ordenando Roteiro"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = True
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(541, 417)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(141, 14)
        Me._Label1_2.TabIndex = 23
        Me._Label1_2.Text = "Usuários Compondo Breaks"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.rdbAmbos)
        Me.GroupBox1.Controls.Add(Me.rdbComposicao)
        Me.GroupBox1.Controls.Add(Me.rdbOrdenado)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 395)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(115, 112)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operação"
        '
        'rdbAmbos
        '
        Me.rdbAmbos.BackColor = System.Drawing.SystemColors.Control
        Me.rdbAmbos.Checked = True
        Me.rdbAmbos.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdbAmbos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAmbos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdbAmbos.Location = New System.Drawing.Point(7, 69)
        Me.rdbAmbos.Name = "rdbAmbos"
        Me.rdbAmbos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdbAmbos.Size = New System.Drawing.Size(97, 25)
        Me.rdbAmbos.TabIndex = 11
        Me.rdbAmbos.TabStop = True
        Me.rdbAmbos.Text = "Ambos"
        Me.rdbAmbos.UseVisualStyleBackColor = False
        '
        'rdbComposicao
        '
        Me.rdbComposicao.BackColor = System.Drawing.SystemColors.Control
        Me.rdbComposicao.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdbComposicao.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbComposicao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdbComposicao.Location = New System.Drawing.Point(7, 48)
        Me.rdbComposicao.Name = "rdbComposicao"
        Me.rdbComposicao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdbComposicao.Size = New System.Drawing.Size(102, 18)
        Me.rdbComposicao.TabIndex = 10
        Me.rdbComposicao.Text = "Composição "
        Me.rdbComposicao.UseVisualStyleBackColor = False
        '
        'rdbOrdenado
        '
        Me.rdbOrdenado.BackColor = System.Drawing.SystemColors.Control
        Me.rdbOrdenado.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdbOrdenado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOrdenado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdbOrdenado.Location = New System.Drawing.Point(7, 24)
        Me.rdbOrdenado.Name = "rdbOrdenado"
        Me.rdbOrdenado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdbOrdenado.Size = New System.Drawing.Size(97, 17)
        Me.rdbOrdenado.TabIndex = 9
        Me.rdbOrdenado.Text = "Ordenação"
        Me.rdbOrdenado.UseVisualStyleBackColor = False
        '
        'dgvPorta
        '
        Me.dgvPorta.AllowUserToDeleteRows = False
        Me.dgvPorta.AllowUserToResizeColumns = False
        Me.dgvPorta.AllowUserToResizeRows = False
        Me.dgvPorta.BackgroundColor = System.Drawing.Color.White
        Me.dgvPorta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPorta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPorta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPorta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPorta.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPorta.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvPorta.Location = New System.Drawing.Point(3, 5)
        Me.dgvPorta.Name = "dgvPorta"
        Me.dgvPorta.RowHeadersWidth = 35
        Me.dgvPorta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPorta.Size = New System.Drawing.Size(729, 384)
        Me.dgvPorta.TabIndex = 0
        '
        'cmdExcluir
        '
        Me.cmdExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExcluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExcluir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExcluir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExcluir.Image = CType(resources.GetObject("cmdExcluir.Image"), System.Drawing.Image)
        Me.cmdExcluir.Location = New System.Drawing.Point(523, 440)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExcluir.Size = New System.Drawing.Size(86, 68)
        Me.cmdExcluir.TabIndex = 28
        Me.cmdExcluir.Text = "&Excluir o Usuário"
        Me.cmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExcluir.UseVisualStyleBackColor = False
        '
        'cmdAtualizar
        '
        Me.cmdAtualizar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAtualizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAtualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAtualizar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAtualizar.Location = New System.Drawing.Point(631, 440)
        Me.cmdAtualizar.Name = "cmdAtualizar"
        Me.cmdAtualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAtualizar.Size = New System.Drawing.Size(83, 29)
        Me.cmdAtualizar.TabIndex = 27
        Me.cmdAtualizar.Text = "&Atualizar"
        Me.cmdAtualizar.UseVisualStyleBackColor = False
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(631, 479)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(83, 29)
        Me.cmdSair.TabIndex = 20
        Me.cmdSair.Text = "Sai&r"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'frmRoteiro_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 511)
        Me.Controls.Add(Me.dgvPorta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.cmdAtualizar)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.PicOrdenacao)
        Me.Controls.Add(Me.picComposicao)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoteiro_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Usuários do Roteiro"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.PicOrdenacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPorta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents chkPerfil As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents OptOperacao_2 As System.Windows.Forms.RadioButton
    Public WithEvents optComposicao As System.Windows.Forms.RadioButton
    Public WithEvents OptOrdenado As System.Windows.Forms.RadioButton
    Public WithEvents PicOrdenacao As System.Windows.Forms.PictureBox
    Public WithEvents picComposicao As System.Windows.Forms.PictureBox
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents rdbAmbos As System.Windows.Forms.RadioButton
    Public WithEvents rdbComposicao As System.Windows.Forms.RadioButton
    Public WithEvents rdbOrdenado As System.Windows.Forms.RadioButton



    Friend WithEvents btnFiltrar As System.Windows.Forms.Button

    Private Sub frmRoteiro_Usuario_AutoSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AutoSizeChanged
    End Sub

    Private Sub _Label1_0_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _Label1_0.BackColorChanged
    End Sub
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents dgvPorta As System.Windows.Forms.DataGridView
    Public WithEvents cmdExcluir As System.Windows.Forms.Button
    Public WithEvents cmdAtualizar As System.Windows.Forms.Button
    Public WithEvents cmdSair As System.Windows.Forms.Button
End Class
