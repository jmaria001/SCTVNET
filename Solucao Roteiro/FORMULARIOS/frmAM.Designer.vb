<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAM
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAM))
        Me.tabAM = New System.Windows.Forms.TabControl
        Me.tabPendente = New System.Windows.Forms.TabPage
        Me.gridAm = New System.Windows.Forms.DataGridView
        Me.tabMidia = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblQtdTotal = New System.Windows.Forms.Label
        Me.lblQtdFalhaOutra = New System.Windows.Forms.Label
        Me.lblQtdFalhaAm = New System.Windows.Forms.Label
        Me.lblQtdEncaixado = New System.Windows.Forms.Label
        Me.lblValorTotal = New System.Windows.Forms.Label
        Me.lblValorFalhaOutra = New System.Windows.Forms.Label
        Me.lblValorFalhaAm = New System.Windows.Forms.Label
        Me.lblValorEncaixado = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblFalhasOutras = New System.Windows.Forms.Label
        Me.lblFahasAM = New System.Windows.Forms.Label
        Me.lblEncaixados = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblCompetencia = New System.Windows.Forms.Label
        Me.cboCompetencia = New System.Windows.Forms.ComboBox
        Me.gridResumoMotivo = New System.Windows.Forms.DataGridView
        Me.gridMidia = New System.Windows.Forms.DataGridView
        Me.tabCompensar = New System.Windows.Forms.TabPage
        Me.groupResumoDiferenca = New System.Windows.Forms.GroupBox
        Me.lblValorDiferenca = New System.Windows.Forms.Label
        Me.lblValorCompensacao = New System.Windows.Forms.Label
        Me.lblValorFalha = New System.Windows.Forms.Label
        Me.lblQtdDiferenca = New System.Windows.Forms.Label
        Me.lblQtdCompensacao = New System.Windows.Forms.Label
        Me.lblQtdFalha = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupCompensar = New System.Windows.Forms.GroupBox
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnCompensar = New System.Windows.Forms.Button
        Me.ucQtd = New WUC.UcText
        Me.ucComercial = New WUC.UcText
        Me.ucDia = New WUC.UcText
        Me.ucPrograma = New WUC.UcText
        Me.ucCompetencia = New WUC.UcText
        Me.groupSaldo = New System.Windows.Forms.GroupBox
        Me.gridSaldo = New System.Windows.Forms.DataGridView
        Me.groupCompensacao = New System.Windows.Forms.GroupBox
        Me.gridCompensacao = New System.Windows.Forms.DataGridView
        Me.btnSaldo = New System.Windows.Forms.Button
        Me.grpListaFalhas = New System.Windows.Forms.GroupBox
        Me.gridListaFalhas = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSolucao = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnFiltrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnReencaixar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.brnSair = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.bdnAM = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.lblAM = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.bdsAM = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabAM.SuspendLayout()
        Me.tabPendente.SuspendLayout()
        CType(Me.gridAm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMidia.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridResumoMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMidia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCompensar.SuspendLayout()
        Me.groupResumoDiferenca.SuspendLayout()
        Me.GroupCompensar.SuspendLayout()
        Me.groupSaldo.SuspendLayout()
        CType(Me.gridSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupCompensacao.SuspendLayout()
        CType(Me.gridCompensacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpListaFalhas.SuspendLayout()
        CType(Me.gridListaFalhas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.bdnAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnAM.SuspendLayout()
        CType(Me.bdsAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabAM
        '
        Me.tabAM.Controls.Add(Me.tabPendente)
        Me.tabAM.Controls.Add(Me.tabMidia)
        Me.tabAM.Controls.Add(Me.tabCompensar)
        Me.tabAM.Location = New System.Drawing.Point(12, 58)
        Me.tabAM.Name = "tabAM"
        Me.tabAM.SelectedIndex = 0
        Me.tabAM.Size = New System.Drawing.Size(965, 485)
        Me.tabAM.TabIndex = 0
        '
        'tabPendente
        '
        Me.tabPendente.Controls.Add(Me.gridAm)
        Me.tabPendente.Location = New System.Drawing.Point(4, 22)
        Me.tabPendente.Name = "tabPendente"
        Me.tabPendente.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPendente.Size = New System.Drawing.Size(957, 459)
        Me.tabPendente.TabIndex = 0
        Me.tabPendente.Text = "Am's Pendentes"
        Me.tabPendente.UseVisualStyleBackColor = True
        '
        'gridAm
        '
        Me.gridAm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridAm.BackgroundColor = System.Drawing.Color.White
        Me.gridAm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAm.Location = New System.Drawing.Point(7, 6)
        Me.gridAm.Name = "gridAm"
        Me.gridAm.Size = New System.Drawing.Size(944, 446)
        Me.gridAm.TabIndex = 1
        '
        'tabMidia
        '
        Me.tabMidia.Controls.Add(Me.GroupBox1)
        Me.tabMidia.Controls.Add(Me.lblCompetencia)
        Me.tabMidia.Controls.Add(Me.cboCompetencia)
        Me.tabMidia.Controls.Add(Me.gridResumoMotivo)
        Me.tabMidia.Controls.Add(Me.gridMidia)
        Me.tabMidia.Location = New System.Drawing.Point(4, 22)
        Me.tabMidia.Name = "tabMidia"
        Me.tabMidia.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMidia.Size = New System.Drawing.Size(957, 459)
        Me.tabMidia.TabIndex = 1
        Me.tabMidia.Text = "Visualização da Mídia"
        Me.tabMidia.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblFalhasOutras)
        Me.GroupBox1.Controls.Add(Me.lblFahasAM)
        Me.GroupBox1.Controls.Add(Me.lblEncaixados)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(643, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 155)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumo da Mídia"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblQtdTotal)
        Me.GroupBox2.Controls.Add(Me.lblQtdFalhaOutra)
        Me.GroupBox2.Controls.Add(Me.lblQtdFalhaAm)
        Me.GroupBox2.Controls.Add(Me.lblQtdEncaixado)
        Me.GroupBox2.Controls.Add(Me.lblValorTotal)
        Me.GroupBox2.Controls.Add(Me.lblValorFalhaOutra)
        Me.GroupBox2.Controls.Add(Me.lblValorFalhaAm)
        Me.GroupBox2.Controls.Add(Me.lblValorEncaixado)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 155)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resumo da Mídia"
        '
        'lblQtdTotal
        '
        Me.lblQtdTotal.BackColor = System.Drawing.Color.White
        Me.lblQtdTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtdTotal.Location = New System.Drawing.Point(134, 113)
        Me.lblQtdTotal.Name = "lblQtdTotal"
        Me.lblQtdTotal.Size = New System.Drawing.Size(42, 20)
        Me.lblQtdTotal.TabIndex = 11
        Me.lblQtdTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQtdFalhaOutra
        '
        Me.lblQtdFalhaOutra.BackColor = System.Drawing.Color.White
        Me.lblQtdFalhaOutra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtdFalhaOutra.Location = New System.Drawing.Point(134, 85)
        Me.lblQtdFalhaOutra.Name = "lblQtdFalhaOutra"
        Me.lblQtdFalhaOutra.Size = New System.Drawing.Size(42, 20)
        Me.lblQtdFalhaOutra.TabIndex = 10
        Me.lblQtdFalhaOutra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQtdFalhaAm
        '
        Me.lblQtdFalhaAm.BackColor = System.Drawing.Color.White
        Me.lblQtdFalhaAm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtdFalhaAm.Location = New System.Drawing.Point(134, 57)
        Me.lblQtdFalhaAm.Name = "lblQtdFalhaAm"
        Me.lblQtdFalhaAm.Size = New System.Drawing.Size(42, 20)
        Me.lblQtdFalhaAm.TabIndex = 9
        Me.lblQtdFalhaAm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQtdEncaixado
        '
        Me.lblQtdEncaixado.BackColor = System.Drawing.Color.White
        Me.lblQtdEncaixado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtdEncaixado.Location = New System.Drawing.Point(134, 29)
        Me.lblQtdEncaixado.Name = "lblQtdEncaixado"
        Me.lblQtdEncaixado.Size = New System.Drawing.Size(42, 20)
        Me.lblQtdEncaixado.TabIndex = 8
        Me.lblQtdEncaixado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValorTotal
        '
        Me.lblValorTotal.BackColor = System.Drawing.Color.White
        Me.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValorTotal.Location = New System.Drawing.Point(182, 113)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(120, 20)
        Me.lblValorTotal.TabIndex = 7
        Me.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValorFalhaOutra
        '
        Me.lblValorFalhaOutra.BackColor = System.Drawing.Color.White
        Me.lblValorFalhaOutra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValorFalhaOutra.Location = New System.Drawing.Point(182, 85)
        Me.lblValorFalhaOutra.Name = "lblValorFalhaOutra"
        Me.lblValorFalhaOutra.Size = New System.Drawing.Size(120, 20)
        Me.lblValorFalhaOutra.TabIndex = 6
        Me.lblValorFalhaOutra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValorFalhaAm
        '
        Me.lblValorFalhaAm.BackColor = System.Drawing.Color.White
        Me.lblValorFalhaAm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValorFalhaAm.Location = New System.Drawing.Point(182, 57)
        Me.lblValorFalhaAm.Name = "lblValorFalhaAm"
        Me.lblValorFalhaAm.Size = New System.Drawing.Size(120, 20)
        Me.lblValorFalhaAm.TabIndex = 5
        Me.lblValorFalhaAm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValorEncaixado
        '
        Me.lblValorEncaixado.BackColor = System.Drawing.Color.White
        Me.lblValorEncaixado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValorEncaixado.Location = New System.Drawing.Point(182, 29)
        Me.lblValorEncaixado.Name = "lblValorEncaixado"
        Me.lblValorEncaixado.Size = New System.Drawing.Size(120, 20)
        Me.lblValorEncaixado.TabIndex = 4
        Me.lblValorEncaixado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(25, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Outras Falhas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(25, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Falhas dessa AM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Encaixados"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(153, 100)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 20)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFalhasOutras
        '
        Me.lblFalhasOutras.BackColor = System.Drawing.Color.White
        Me.lblFalhasOutras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFalhasOutras.Location = New System.Drawing.Point(153, 72)
        Me.lblFalhasOutras.Name = "lblFalhasOutras"
        Me.lblFalhasOutras.Size = New System.Drawing.Size(120, 20)
        Me.lblFalhasOutras.TabIndex = 6
        Me.lblFalhasOutras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFahasAM
        '
        Me.lblFahasAM.BackColor = System.Drawing.Color.White
        Me.lblFahasAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFahasAM.Location = New System.Drawing.Point(153, 44)
        Me.lblFahasAM.Name = "lblFahasAM"
        Me.lblFahasAM.Size = New System.Drawing.Size(120, 20)
        Me.lblFahasAM.TabIndex = 5
        Me.lblFahasAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEncaixados
        '
        Me.lblEncaixados.BackColor = System.Drawing.Color.White
        Me.lblEncaixados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncaixados.Location = New System.Drawing.Point(153, 16)
        Me.lblEncaixados.Name = "lblEncaixados"
        Me.lblEncaixados.Size = New System.Drawing.Size(120, 20)
        Me.lblEncaixados.TabIndex = 4
        Me.lblEncaixados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Total"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(25, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Outras Falhas"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(25, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Falhas dessa AM"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(25, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Encaixados"
        '
        'lblCompetencia
        '
        Me.lblCompetencia.AutoSize = True
        Me.lblCompetencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompetencia.Location = New System.Drawing.Point(6, 13)
        Me.lblCompetencia.Name = "lblCompetencia"
        Me.lblCompetencia.Size = New System.Drawing.Size(150, 13)
        Me.lblCompetencia.TabIndex = 5
        Me.lblCompetencia.Text = "Competência de Exibição"
        '
        'cboCompetencia
        '
        Me.cboCompetencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompetencia.FormattingEnabled = True
        Me.cboCompetencia.Location = New System.Drawing.Point(162, 10)
        Me.cboCompetencia.Name = "cboCompetencia"
        Me.cboCompetencia.Size = New System.Drawing.Size(134, 21)
        Me.cboCompetencia.TabIndex = 4
        '
        'gridResumoMotivo
        '
        Me.gridResumoMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridResumoMotivo.BackgroundColor = System.Drawing.Color.White
        Me.gridResumoMotivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridResumoMotivo.Location = New System.Drawing.Point(6, 298)
        Me.gridResumoMotivo.Name = "gridResumoMotivo"
        Me.gridResumoMotivo.Size = New System.Drawing.Size(631, 155)
        Me.gridResumoMotivo.TabIndex = 2
        '
        'gridMidia
        '
        Me.gridMidia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridMidia.BackgroundColor = System.Drawing.Color.White
        Me.gridMidia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridMidia.Location = New System.Drawing.Point(7, 40)
        Me.gridMidia.Name = "gridMidia"
        Me.gridMidia.Size = New System.Drawing.Size(944, 252)
        Me.gridMidia.TabIndex = 1
        '
        'tabCompensar
        '
        Me.tabCompensar.Controls.Add(Me.groupResumoDiferenca)
        Me.tabCompensar.Controls.Add(Me.GroupCompensar)
        Me.tabCompensar.Controls.Add(Me.groupSaldo)
        Me.tabCompensar.Controls.Add(Me.groupCompensacao)
        Me.tabCompensar.Controls.Add(Me.grpListaFalhas)
        Me.tabCompensar.Location = New System.Drawing.Point(4, 22)
        Me.tabCompensar.Name = "tabCompensar"
        Me.tabCompensar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompensar.Size = New System.Drawing.Size(957, 459)
        Me.tabCompensar.TabIndex = 2
        Me.tabCompensar.Text = "Compensar"
        Me.tabCompensar.UseVisualStyleBackColor = True
        '
        'groupResumoDiferenca
        '
        Me.groupResumoDiferenca.Controls.Add(Me.lblValorDiferenca)
        Me.groupResumoDiferenca.Controls.Add(Me.lblValorCompensacao)
        Me.groupResumoDiferenca.Controls.Add(Me.lblValorFalha)
        Me.groupResumoDiferenca.Controls.Add(Me.lblQtdDiferenca)
        Me.groupResumoDiferenca.Controls.Add(Me.lblQtdCompensacao)
        Me.groupResumoDiferenca.Controls.Add(Me.lblQtdFalha)
        Me.groupResumoDiferenca.Controls.Add(Me.Label3)
        Me.groupResumoDiferenca.Controls.Add(Me.Label2)
        Me.groupResumoDiferenca.Controls.Add(Me.Label1)
        Me.groupResumoDiferenca.Location = New System.Drawing.Point(401, 347)
        Me.groupResumoDiferenca.Name = "groupResumoDiferenca"
        Me.groupResumoDiferenca.Size = New System.Drawing.Size(535, 96)
        Me.groupResumoDiferenca.TabIndex = 4
        Me.groupResumoDiferenca.TabStop = False
        Me.groupResumoDiferenca.Text = "Resumo"
        '
        'lblValorDiferenca
        '
        Me.lblValorDiferenca.BackColor = System.Drawing.Color.White
        Me.lblValorDiferenca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValorDiferenca.Location = New System.Drawing.Point(274, 65)
        Me.lblValorDiferenca.Name = "lblValorDiferenca"
        Me.lblValorDiferenca.Size = New System.Drawing.Size(148, 19)
        Me.lblValorDiferenca.TabIndex = 10
        Me.lblValorDiferenca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValorCompensacao
        '
        Me.lblValorCompensacao.BackColor = System.Drawing.Color.White
        Me.lblValorCompensacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValorCompensacao.Location = New System.Drawing.Point(274, 40)
        Me.lblValorCompensacao.Name = "lblValorCompensacao"
        Me.lblValorCompensacao.Size = New System.Drawing.Size(148, 19)
        Me.lblValorCompensacao.TabIndex = 9
        Me.lblValorCompensacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValorFalha
        '
        Me.lblValorFalha.BackColor = System.Drawing.Color.White
        Me.lblValorFalha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValorFalha.Location = New System.Drawing.Point(274, 15)
        Me.lblValorFalha.Name = "lblValorFalha"
        Me.lblValorFalha.Size = New System.Drawing.Size(148, 19)
        Me.lblValorFalha.TabIndex = 8
        Me.lblValorFalha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQtdDiferenca
        '
        Me.lblQtdDiferenca.BackColor = System.Drawing.Color.White
        Me.lblQtdDiferenca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtdDiferenca.Location = New System.Drawing.Point(211, 66)
        Me.lblQtdDiferenca.Name = "lblQtdDiferenca"
        Me.lblQtdDiferenca.Size = New System.Drawing.Size(47, 18)
        Me.lblQtdDiferenca.TabIndex = 7
        Me.lblQtdDiferenca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQtdCompensacao
        '
        Me.lblQtdCompensacao.BackColor = System.Drawing.Color.White
        Me.lblQtdCompensacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtdCompensacao.Location = New System.Drawing.Point(211, 41)
        Me.lblQtdCompensacao.Name = "lblQtdCompensacao"
        Me.lblQtdCompensacao.Size = New System.Drawing.Size(47, 18)
        Me.lblQtdCompensacao.TabIndex = 6
        Me.lblQtdCompensacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQtdFalha
        '
        Me.lblQtdFalha.BackColor = System.Drawing.Color.White
        Me.lblQtdFalha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtdFalha.Location = New System.Drawing.Point(211, 16)
        Me.lblQtdFalha.Name = "lblQtdFalha"
        Me.lblQtdFalha.Size = New System.Drawing.Size(47, 18)
        Me.lblQtdFalha.TabIndex = 5
        Me.lblQtdFalha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diferença"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Compensações"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Falhas"
        '
        'GroupCompensar
        '
        Me.GroupCompensar.Controls.Add(Me.btnExcluir)
        Me.GroupCompensar.Controls.Add(Me.btnLimpar)
        Me.GroupCompensar.Controls.Add(Me.btnCompensar)
        Me.GroupCompensar.Controls.Add(Me.ucQtd)
        Me.GroupCompensar.Controls.Add(Me.ucComercial)
        Me.GroupCompensar.Controls.Add(Me.ucDia)
        Me.GroupCompensar.Controls.Add(Me.ucPrograma)
        Me.GroupCompensar.Controls.Add(Me.ucCompetencia)
        Me.GroupCompensar.Location = New System.Drawing.Point(401, 199)
        Me.GroupCompensar.Name = "GroupCompensar"
        Me.GroupCompensar.Size = New System.Drawing.Size(535, 142)
        Me.GroupCompensar.TabIndex = 3
        Me.GroupCompensar.TabStop = False
        Me.GroupCompensar.Text = "Compensar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(13, 102)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(195, 29)
        Me.btnExcluir.TabIndex = 8
        Me.btnExcluir.TabStop = False
        Me.btnExcluir.Text = "Excluir Compensação Selecionadas"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(443, 107)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(85, 29)
        Me.btnLimpar.TabIndex = 7
        Me.btnLimpar.TabStop = False
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnCompensar
        '
        Me.btnCompensar.Location = New System.Drawing.Point(352, 107)
        Me.btnCompensar.Name = "btnCompensar"
        Me.btnCompensar.Size = New System.Drawing.Size(85, 29)
        Me.btnCompensar.TabIndex = 6
        Me.btnCompensar.TabStop = False
        Me.btnCompensar.Text = "Compensar"
        Me.btnCompensar.UseVisualStyleBackColor = True
        '
        'ucQtd
        '
        Me.ucQtd.BackColor = System.Drawing.Color.Transparent
        Me.ucQtd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucQtd.Caption = "Qtd"
        Me.ucQtd.DataTextValue = Nothing
        Me.ucQtd.Location = New System.Drawing.Point(461, 71)
        Me.ucQtd.MaxLength = 2
        Me.ucQtd.Name = "ucQtd"
        Me.ucQtd.Obrigatorio = True
        Me.ucQtd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucQtd.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucQtd.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucQtd.pDecimal = CType(0, Byte)
        Me.ucQtd.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucQtd.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucQtd.Size = New System.Drawing.Size(67, 25)
        Me.ucQtd.sqlQuery = Nothing
        Me.ucQtd.TabIndex = 5
        Me.ucQtd.TextBoxLeft = CType(0, Short)
        Me.ucQtd.TextWidth = 0
        '
        'ucComercial
        '
        Me.ucComercial.BackColor = System.Drawing.Color.Transparent
        Me.ucComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucComercial.Caption = "Comercial"
        Me.ucComercial.DataTextValue = Nothing
        Me.ucComercial.Location = New System.Drawing.Point(113, 71)
        Me.ucComercial.MaxLength = 2
        Me.ucComercial.Name = "ucComercial"
        Me.ucComercial.Obrigatorio = True
        Me.ucComercial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucComercial.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucComercial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucComercial.pDecimal = CType(0, Byte)
        Me.ucComercial.pDicionario = WUC.clsDicionario.enuDicionario.Comercial
        Me.ucComercial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucComercial.showButton = True
        Me.ucComercial.ShowDescricao = True
        Me.ucComercial.Size = New System.Drawing.Size(342, 25)
        Me.ucComercial.sqlQuery = " execute prNet_Comercial_L '',0,0"
        Me.ucComercial.TabIndex = 4
        Me.ucComercial.TextBoxLeft = CType(0, Short)
        Me.ucComercial.TextWidth = 0
        '
        'ucDia
        '
        Me.ucDia.BackColor = System.Drawing.Color.Transparent
        Me.ucDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucDia.Caption = "Dia"
        Me.ucDia.DataTextValue = Nothing
        Me.ucDia.Location = New System.Drawing.Point(15, 71)
        Me.ucDia.MaxLength = 2
        Me.ucDia.Name = "ucDia"
        Me.ucDia.Obrigatorio = True
        Me.ucDia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucDia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucDia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucDia.pDecimal = CType(0, Byte)
        Me.ucDia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucDia.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucDia.Size = New System.Drawing.Size(83, 25)
        Me.ucDia.sqlQuery = Nothing
        Me.ucDia.TabIndex = 3
        Me.ucDia.TextBoxLeft = CType(0, Short)
        Me.ucDia.TextWidth = 0
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.Color.Transparent
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(161, 31)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.Obrigatorio = True
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Grade
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(364, 25)
        Me.ucPrograma.sqlQuery = "execute PrNet_Programa_Grade '','0001-01-01','0001-01-01',NULL"
        Me.ucPrograma.TabIndex = 1
        Me.ucPrograma.TextBoxLeft = CType(0, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'ucCompetencia
        '
        Me.ucCompetencia.BackColor = System.Drawing.Color.Transparent
        Me.ucCompetencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucCompetencia.Caption = "Competência"
        Me.ucCompetencia.DataTextValue = Nothing
        Me.ucCompetencia.Location = New System.Drawing.Point(15, 31)
        Me.ucCompetencia.MaxLength = 32767
        Me.ucCompetencia.Name = "ucCompetencia"
        Me.ucCompetencia.Obrigatorio = True
        Me.ucCompetencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucCompetencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucCompetencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucCompetencia.pDecimal = CType(0, Byte)
        Me.ucCompetencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucCompetencia.pFormatoSaida = WUC.UcText.FormatoSaida.Mes_Ano
        Me.ucCompetencia.Size = New System.Drawing.Size(140, 25)
        Me.ucCompetencia.sqlQuery = Nothing
        Me.ucCompetencia.TabIndex = 0
        Me.ucCompetencia.TextBoxLeft = CType(0, Short)
        Me.ucCompetencia.TextWidth = 0
        '
        'groupSaldo
        '
        Me.groupSaldo.Controls.Add(Me.gridSaldo)
        Me.groupSaldo.Location = New System.Drawing.Point(6, 199)
        Me.groupSaldo.Name = "groupSaldo"
        Me.groupSaldo.Size = New System.Drawing.Size(389, 244)
        Me.groupSaldo.TabIndex = 2
        Me.groupSaldo.TabStop = False
        Me.groupSaldo.Text = "Saldos Disponíveis"
        '
        'gridSaldo
        '
        Me.gridSaldo.BackgroundColor = System.Drawing.Color.White
        Me.gridSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSaldo.Location = New System.Drawing.Point(12, 19)
        Me.gridSaldo.Name = "gridSaldo"
        Me.gridSaldo.Size = New System.Drawing.Size(371, 218)
        Me.gridSaldo.TabIndex = 0
        '
        'groupCompensacao
        '
        Me.groupCompensacao.Controls.Add(Me.gridCompensacao)
        Me.groupCompensacao.Controls.Add(Me.btnSaldo)
        Me.groupCompensacao.Location = New System.Drawing.Point(401, 7)
        Me.groupCompensacao.Name = "groupCompensacao"
        Me.groupCompensacao.Size = New System.Drawing.Size(535, 186)
        Me.groupCompensacao.TabIndex = 1
        Me.groupCompensacao.TabStop = False
        Me.groupCompensacao.Text = "Compensações"
        '
        'gridCompensacao
        '
        Me.gridCompensacao.BackgroundColor = System.Drawing.Color.White
        Me.gridCompensacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCompensacao.Location = New System.Drawing.Point(6, 19)
        Me.gridCompensacao.Name = "gridCompensacao"
        Me.gridCompensacao.Size = New System.Drawing.Size(519, 158)
        Me.gridCompensacao.TabIndex = 0
        '
        'btnSaldo
        '
        Me.btnSaldo.Location = New System.Drawing.Point(484, 0)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(66, 27)
        Me.btnSaldo.TabIndex = 2
        Me.btnSaldo.TabStop = False
        Me.btnSaldo.Text = "Ver saldo"
        Me.btnSaldo.UseVisualStyleBackColor = True
        Me.btnSaldo.Visible = False
        '
        'grpListaFalhas
        '
        Me.grpListaFalhas.Controls.Add(Me.gridListaFalhas)
        Me.grpListaFalhas.Location = New System.Drawing.Point(6, 7)
        Me.grpListaFalhas.Name = "grpListaFalhas"
        Me.grpListaFalhas.Size = New System.Drawing.Size(389, 186)
        Me.grpListaFalhas.TabIndex = 0
        Me.grpListaFalhas.TabStop = False
        Me.grpListaFalhas.Text = "Falhas da AM"
        '
        'gridListaFalhas
        '
        Me.gridListaFalhas.BackgroundColor = System.Drawing.Color.White
        Me.gridListaFalhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridListaFalhas.Location = New System.Drawing.Point(6, 19)
        Me.gridListaFalhas.Name = "gridListaFalhas"
        Me.gridListaFalhas.Size = New System.Drawing.Size(377, 158)
        Me.gridListaFalhas.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSolucao, Me.ToolStripSeparator4, Me.btnFiltrar, Me.ToolStripSeparator2, Me.btnReencaixar, Me.ToolStripSeparator3, Me.brnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(982, 52)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSolucao
        '
        Me.btnSolucao.Image = Global.SCTVNET.My.Resources.Resources.save
        Me.btnSolucao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSolucao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSolucao.Name = "btnSolucao"
        Me.btnSolucao.Size = New System.Drawing.Size(52, 49)
        Me.btnSolucao.Text = "Encerrar"
        Me.btnSolucao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 52)
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.SCTVNET.My.Resources.Resources.Binocolo
        Me.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(63, 49)
        Me.btnFiltrar.Text = "    Filtrar    "
        Me.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'btnReencaixar
        '
        Me.btnReencaixar.Image = Global.SCTVNET.My.Resources.Resources.Reencaixar
        Me.btnReencaixar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReencaixar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReencaixar.Name = "btnReencaixar"
        Me.btnReencaixar.Size = New System.Drawing.Size(99, 49)
        Me.btnReencaixar.Text = "Reencaixar Falhas"
        Me.btnReencaixar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'brnSair
        '
        Me.brnSair.Image = Global.SCTVNET.My.Resources.Resources.Sair1
        Me.brnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.brnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.brnSair.Name = "brnSair"
        Me.brnSair.Size = New System.Drawing.Size(53, 49)
        Me.brnSair.Text = "    Sair    "
        Me.brnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(122, 22)
        Me.BindingNavigatorCountItem.Text = ": Total Selecionadas {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'bdnAM
        '
        Me.bdnAM.AddNewItem = Nothing
        Me.bdnAM.BackColor = System.Drawing.Color.Transparent
        Me.bdnAM.CountItem = Me.BindingNavigatorCountItem
        Me.bdnAM.CountItemFormat = ": Total Selecionadas {0}"
        Me.bdnAM.DeleteItem = Nothing
        Me.bdnAM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bdnAM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.lblAM, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.bdnAM.Location = New System.Drawing.Point(0, 546)
        Me.bdnAM.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bdnAM.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bdnAM.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bdnAM.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bdnAM.Name = "bdnAM"
        Me.bdnAM.PositionItem = Nothing
        Me.bdnAM.Size = New System.Drawing.Size(982, 25)
        Me.bdnAM.TabIndex = 0
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'lblAM
        '
        Me.lblAM.Name = "lblAM"
        Me.lblAM.Size = New System.Drawing.Size(81, 22)
        Me.lblAM.Text = "Am selecionada"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bdsAM
        '
        '
        'frmAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 571)
        Me.Controls.Add(Me.bdnAM)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tabAM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAM"
        Me.Text = "Administração de AM´s"
        Me.tabAM.ResumeLayout(False)
        Me.tabPendente.ResumeLayout(False)
        CType(Me.gridAm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMidia.ResumeLayout(False)
        Me.tabMidia.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridResumoMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMidia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCompensar.ResumeLayout(False)
        Me.groupResumoDiferenca.ResumeLayout(False)
        Me.groupResumoDiferenca.PerformLayout()
        Me.GroupCompensar.ResumeLayout(False)
        Me.groupSaldo.ResumeLayout(False)
        CType(Me.gridSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupCompensacao.ResumeLayout(False)
        CType(Me.gridCompensacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpListaFalhas.ResumeLayout(False)
        CType(Me.gridListaFalhas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.bdnAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnAM.ResumeLayout(False)
        Me.bdnAM.PerformLayout()
        CType(Me.bdsAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabAM As System.Windows.Forms.TabControl
    Friend WithEvents tabPendente As System.Windows.Forms.TabPage
    Friend WithEvents tabMidia As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFiltrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents brnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReencaixar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabCompensar As System.Windows.Forms.TabPage
    Friend WithEvents gridAm As System.Windows.Forms.DataGridView
    Friend WithEvents gridMidia As System.Windows.Forms.DataGridView
    Friend WithEvents btnSolucao As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bdnAM As System.Windows.Forms.BindingNavigator
    Friend WithEvents lblAM As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bdsAM As System.Windows.Forms.BindingSource
    Friend WithEvents lblCompetencia As System.Windows.Forms.Label
    Friend WithEvents cboCompetencia As System.Windows.Forms.ComboBox
    Friend WithEvents gridResumoMotivo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblFalhasOutras As System.Windows.Forms.Label
    Friend WithEvents lblFahasAM As System.Windows.Forms.Label
    Friend WithEvents lblEncaixados As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents groupCompensacao As System.Windows.Forms.GroupBox
    Friend WithEvents gridCompensacao As System.Windows.Forms.DataGridView
    Friend WithEvents grpListaFalhas As System.Windows.Forms.GroupBox
    Friend WithEvents gridListaFalhas As System.Windows.Forms.DataGridView
    Friend WithEvents groupSaldo As System.Windows.Forms.GroupBox
    Friend WithEvents gridSaldo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupCompensar As System.Windows.Forms.GroupBox
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents ucCompetencia As WUC.UcText
    Friend WithEvents ucComercial As WUC.UcText
    Friend WithEvents ucDia As WUC.UcText
    Friend WithEvents ucQtd As WUC.UcText
    Friend WithEvents btnCompensar As System.Windows.Forms.Button
    Friend WithEvents btnSaldo As System.Windows.Forms.Button
    Friend WithEvents groupResumoDiferenca As System.Windows.Forms.GroupBox
    Friend WithEvents lblValorDiferenca As System.Windows.Forms.Label
    Friend WithEvents lblValorCompensacao As System.Windows.Forms.Label
    Friend WithEvents lblValorFalha As System.Windows.Forms.Label
    Friend WithEvents lblQtdDiferenca As System.Windows.Forms.Label
    Friend WithEvents lblQtdCompensacao As System.Windows.Forms.Label
    Friend WithEvents lblQtdFalha As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblQtdTotal As System.Windows.Forms.Label
    Friend WithEvents lblQtdFalhaOutra As System.Windows.Forms.Label
    Friend WithEvents lblQtdFalhaAm As System.Windows.Forms.Label
    Friend WithEvents lblQtdEncaixado As System.Windows.Forms.Label
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents lblValorFalhaOutra As System.Windows.Forms.Label
    Friend WithEvents lblValorFalhaAm As System.Windows.Forms.Label
    Friend WithEvents lblValorEncaixado As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
