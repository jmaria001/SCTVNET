<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmBaixaAutomatica
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
        InitializeComponent()
        Me.MdiParent = SCTVNET.mdiPrincipal

    End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtHorario As System.Windows.Forms.TextBox
	Public WithEvents txtQualidade As System.Windows.Forms.TextBox
	Public WithEvents _flxRetorno_1 As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _fraPasta_1 As System.Windows.Forms.GroupBox
    Public WithEvents chkBaixar As System.Windows.Forms.CheckBox
	Public WithEvents chkCarregar As System.Windows.Forms.CheckBox
    Public WithEvents cmdCancela As System.Windows.Forms.Button
	Public WithEvents cmdBaixar As System.Windows.Forms.Button
	Public WithEvents _flxRetorno_2 As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _fraPasta_2 As System.Windows.Forms.GroupBox
	Public WithEvents _flxRetorno_0 As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents _fraPasta_0 As System.Windows.Forms.GroupBox
    Public WithEvents flxRetorno As AxMSFlexGridArray.AxMSFlexGridArray
	Public WithEvents fraPasta As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.7
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaixaAutomatica))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._fraPasta_1 = New System.Windows.Forms.GroupBox
        Me.txtHorario = New System.Windows.Forms.TextBox
        Me.txtQualidade = New System.Windows.Forms.TextBox
        Me._flxRetorno_1 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.chkBaixar = New System.Windows.Forms.CheckBox
        Me.chkCarregar = New System.Windows.Forms.CheckBox
        Me.cmdCancela = New System.Windows.Forms.Button
        Me.cmdBaixar = New System.Windows.Forms.Button
        Me._fraPasta_2 = New System.Windows.Forms.GroupBox
        Me._flxRetorno_2 = New AxMSFlexGridLib.AxMSFlexGrid
        Me._fraPasta_0 = New System.Windows.Forms.GroupBox
        Me._flxRetorno_0 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.flxRetorno = New AxMSFlexGridArray.AxMSFlexGridArray(Me.components)
        Me.fraPasta = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.chkAvulso = New System.Windows.Forms.CheckBox
        Me.chkArtistico = New System.Windows.Forms.CheckBox
        Me.txtVeiculo = New System.Windows.Forms.TextBox
        Me.txtData_Exibicao = New WCL_SCTV.UC.UCData
        Me.optPasta1 = New System.Windows.Forms.RadioButton
        Me.optPasta2 = New System.Windows.Forms.RadioButton
        Me.optPasta3 = New System.Windows.Forms.RadioButton
        Me._fraPasta_1.SuspendLayout()
        CType(Me._flxRetorno_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._fraPasta_2.SuspendLayout()
        CType(Me._flxRetorno_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._fraPasta_0.SuspendLayout()
        CType(Me._flxRetorno_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fraPasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_fraPasta_1
        '
        Me._fraPasta_1.BackColor = System.Drawing.SystemColors.Control
        Me._fraPasta_1.Controls.Add(Me.txtHorario)
        Me._fraPasta_1.Controls.Add(Me.txtQualidade)
        Me._fraPasta_1.Controls.Add(Me._flxRetorno_1)
        Me._fraPasta_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fraPasta_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraPasta.SetIndex(Me._fraPasta_1, CType(1, Short))
        Me._fraPasta_1.Location = New System.Drawing.Point(18, 120)
        Me._fraPasta_1.Name = "_fraPasta_1"
        Me._fraPasta_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fraPasta_1.Size = New System.Drawing.Size(725, 58)
        Me._fraPasta_1.TabIndex = 3
        Me._fraPasta_1.TabStop = False
        Me._fraPasta_1.Text = "Previsto e Não Exibido"
        '
        'txtHorario
        '
        Me.txtHorario.AcceptsReturn = True
        Me.txtHorario.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorario.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorario.Location = New System.Drawing.Point(72, 396)
        Me.txtHorario.MaxLength = 8
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorario.Size = New System.Drawing.Size(57, 20)
        Me.txtHorario.TabIndex = 21
        Me.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHorario.Visible = False
        '
        'txtQualidade
        '
        Me.txtQualidade.AcceptsReturn = True
        Me.txtQualidade.BackColor = System.Drawing.SystemColors.Window
        Me.txtQualidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQualidade.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQualidade.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtQualidade.Location = New System.Drawing.Point(12, 396)
        Me.txtQualidade.MaxLength = 3
        Me.txtQualidade.Name = "txtQualidade"
        Me.txtQualidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQualidade.Size = New System.Drawing.Size(57, 20)
        Me.txtQualidade.TabIndex = 20
        Me.txtQualidade.Visible = False
        '
        '_flxRetorno_1
        '
        Me._flxRetorno_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._flxRetorno_1.Location = New System.Drawing.Point(9, 15)
        Me._flxRetorno_1.Name = "_flxRetorno_1"
        Me._flxRetorno_1.OcxState = CType(resources.GetObject("_flxRetorno_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxRetorno_1.Size = New System.Drawing.Size(707, 36)
        Me._flxRetorno_1.TabIndex = 4
        '
        'chkBaixar
        '
        Me.chkBaixar.AutoSize = True
        Me.chkBaixar.BackColor = System.Drawing.SystemColors.Control
        Me.chkBaixar.Checked = True
        Me.chkBaixar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBaixar.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBaixar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBaixar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBaixar.Location = New System.Drawing.Point(682, 3)
        Me.chkBaixar.Name = "chkBaixar"
        Me.chkBaixar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBaixar.Size = New System.Drawing.Size(57, 18)
        Me.chkBaixar.TabIndex = 11
        Me.chkBaixar.Text = "Baixar"
        Me.chkBaixar.UseVisualStyleBackColor = False
        Me.chkBaixar.Visible = False
        '
        'chkCarregar
        '
        Me.chkCarregar.AutoSize = True
        Me.chkCarregar.BackColor = System.Drawing.SystemColors.Control
        Me.chkCarregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCarregar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCarregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCarregar.Location = New System.Drawing.Point(592, 3)
        Me.chkCarregar.Name = "chkCarregar"
        Me.chkCarregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCarregar.Size = New System.Drawing.Size(69, 18)
        Me.chkCarregar.TabIndex = 10
        Me.chkCarregar.Text = "Carregar"
        Me.chkCarregar.UseVisualStyleBackColor = False
        Me.chkCarregar.Visible = False
        '
        'cmdCancela
        '
        Me.cmdCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancela.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.Location = New System.Drawing.Point(672, 441)
        Me.cmdCancela.Name = "cmdCancela"
        Me.cmdCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancela.Size = New System.Drawing.Size(67, 26)
        Me.cmdCancela.TabIndex = 8
        Me.cmdCancela.TabStop = False
        Me.cmdCancela.Text = "&Sair"
        Me.cmdCancela.UseVisualStyleBackColor = False
        '
        'cmdBaixar
        '
        Me.cmdBaixar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBaixar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBaixar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBaixar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBaixar.Location = New System.Drawing.Point(9, 441)
        Me.cmdBaixar.Name = "cmdBaixar"
        Me.cmdBaixar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBaixar.Size = New System.Drawing.Size(148, 26)
        Me.cmdBaixar.TabIndex = 7
        Me.cmdBaixar.TabStop = False
        Me.cmdBaixar.Text = "&Salvar Baixa de Horarios"
        Me.cmdBaixar.UseVisualStyleBackColor = False
        '
        '_fraPasta_2
        '
        Me._fraPasta_2.BackColor = System.Drawing.SystemColors.Control
        Me._fraPasta_2.Controls.Add(Me._flxRetorno_2)
        Me._fraPasta_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fraPasta_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraPasta.SetIndex(Me._fraPasta_2, CType(2, Short))
        Me._fraPasta_2.Location = New System.Drawing.Point(18, 217)
        Me._fraPasta_2.Name = "_fraPasta_2"
        Me._fraPasta_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fraPasta_2.Size = New System.Drawing.Size(725, 58)
        Me._fraPasta_2.TabIndex = 5
        Me._fraPasta_2.TabStop = False
        Me._fraPasta_2.Text = "Não Previsto e Exibido"
        '
        '_flxRetorno_2
        '
        Me._flxRetorno_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._flxRetorno_2.Location = New System.Drawing.Point(9, 15)
        Me._flxRetorno_2.Name = "_flxRetorno_2"
        Me._flxRetorno_2.OcxState = CType(resources.GetObject("_flxRetorno_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxRetorno_2.Size = New System.Drawing.Size(707, 36)
        Me._flxRetorno_2.TabIndex = 6
        '
        '_fraPasta_0
        '
        Me._fraPasta_0.BackColor = System.Drawing.SystemColors.Control
        Me._fraPasta_0.Controls.Add(Me._flxRetorno_0)
        Me._fraPasta_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._fraPasta_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraPasta.SetIndex(Me._fraPasta_0, CType(0, Short))
        Me._fraPasta_0.Location = New System.Drawing.Point(18, 42)
        Me._fraPasta_0.Name = "_fraPasta_0"
        Me._fraPasta_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._fraPasta_0.Size = New System.Drawing.Size(725, 58)
        Me._fraPasta_0.TabIndex = 1
        Me._fraPasta_0.TabStop = False
        Me._fraPasta_0.Text = "Previsto e Exibido"
        '
        '_flxRetorno_0
        '
        Me._flxRetorno_0.AccessibleName = ""
        Me._flxRetorno_0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._flxRetorno_0.Location = New System.Drawing.Point(9, 15)
        Me._flxRetorno_0.Name = "_flxRetorno_0"
        Me._flxRetorno_0.OcxState = CType(resources.GetObject("_flxRetorno_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._flxRetorno_0.Size = New System.Drawing.Size(707, 36)
        Me._flxRetorno_0.TabIndex = 2
        '
        'flxRetorno
        '
        '
        'chkAvulso
        '
        Me.chkAvulso.AutoSize = True
        Me.chkAvulso.BackColor = System.Drawing.SystemColors.Control
        Me.chkAvulso.Checked = True
        Me.chkAvulso.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAvulso.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAvulso.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAvulso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAvulso.Location = New System.Drawing.Point(385, 446)
        Me.chkAvulso.Name = "chkAvulso"
        Me.chkAvulso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAvulso.Size = New System.Drawing.Size(132, 18)
        Me.chkAvulso.TabIndex = 26
        Me.chkAvulso.Text = "Mostrar Fitas Avulsas"
        Me.chkAvulso.UseVisualStyleBackColor = False
        Me.chkAvulso.Visible = False
        '
        'chkArtistico
        '
        Me.chkArtistico.AutoSize = True
        Me.chkArtistico.BackColor = System.Drawing.SystemColors.Control
        Me.chkArtistico.Checked = True
        Me.chkArtistico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkArtistico.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkArtistico.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArtistico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkArtistico.Location = New System.Drawing.Point(523, 446)
        Me.chkArtistico.Name = "chkArtistico"
        Me.chkArtistico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkArtistico.Size = New System.Drawing.Size(138, 18)
        Me.chkArtistico.TabIndex = 25
        Me.chkArtistico.Text = "Mostrar Fitas Artisticas"
        Me.chkArtistico.UseVisualStyleBackColor = False
        Me.chkArtistico.Visible = False
        '
        'txtVeiculo
        '
        Me.txtVeiculo.Location = New System.Drawing.Point(177, 443)
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Size = New System.Drawing.Size(61, 20)
        Me.txtVeiculo.TabIndex = 27
        Me.txtVeiculo.Visible = False
        '
        'txtData_Exibicao
        '
        Me.txtData_Exibicao.BackColor = System.Drawing.Color.Transparent
        Me.txtData_Exibicao.DateTime = New Date(CType(0, Long))
        Me.txtData_Exibicao.Formato = "dd/MM/yyyy ddd"
        Me.txtData_Exibicao.Hoje = False
        Me.txtData_Exibicao.Location = New System.Drawing.Point(244, 443)
        Me.txtData_Exibicao.MaximumSize = New System.Drawing.Size(500, 25)
        Me.txtData_Exibicao.MinimumSize = New System.Drawing.Size(115, 25)
        Me.txtData_Exibicao.Name = "txtData_Exibicao"
        Me.txtData_Exibicao.Permite_Futuro = True
        Me.txtData_Exibicao.Permite_Limpar = True
        Me.txtData_Exibicao.Permite_Passado = True
        Me.txtData_Exibicao.Preenchimento_Obrigatorio = False
        Me.txtData_Exibicao.Size = New System.Drawing.Size(135, 25)
        Me.txtData_Exibicao.TabIndex = 28
        Me.txtData_Exibicao.Visible = False
        '
        'optPasta1
        '
        Me.optPasta1.AutoSize = True
        Me.optPasta1.Location = New System.Drawing.Point(18, 12)
        Me.optPasta1.Name = "optPasta1"
        Me.optPasta1.Size = New System.Drawing.Size(110, 18)
        Me.optPasta1.TabIndex = 29
        Me.optPasta1.TabStop = True
        Me.optPasta1.Text = "Previsto e exibido"
        Me.optPasta1.UseVisualStyleBackColor = True
        '
        'optPasta2
        '
        Me.optPasta2.AutoSize = True
        Me.optPasta2.Location = New System.Drawing.Point(143, 12)
        Me.optPasta2.Name = "optPasta2"
        Me.optPasta2.Size = New System.Drawing.Size(131, 18)
        Me.optPasta2.TabIndex = 30
        Me.optPasta2.TabStop = True
        Me.optPasta2.Text = "Previsto e não exibido"
        Me.optPasta2.UseVisualStyleBackColor = True
        '
        'optPasta3
        '
        Me.optPasta3.AutoSize = True
        Me.optPasta3.Location = New System.Drawing.Point(296, 12)
        Me.optPasta3.Name = "optPasta3"
        Me.optPasta3.Size = New System.Drawing.Size(132, 18)
        Me.optPasta3.TabIndex = 31
        Me.optPasta3.TabStop = True
        Me.optPasta3.Text = "Não previsto e exibido"
        Me.optPasta3.UseVisualStyleBackColor = True
        '
        'frmBaixaAutomatica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(756, 473)
        Me.Controls.Add(Me.optPasta3)
        Me.Controls.Add(Me.optPasta2)
        Me.Controls.Add(Me.optPasta1)
        Me.Controls.Add(Me.txtData_Exibicao)
        Me.Controls.Add(Me.txtVeiculo)
        Me.Controls.Add(Me.chkAvulso)
        Me.Controls.Add(Me.chkArtistico)
        Me.Controls.Add(Me._fraPasta_1)
        Me.Controls.Add(Me.chkBaixar)
        Me.Controls.Add(Me.chkCarregar)
        Me.Controls.Add(Me.cmdCancela)
        Me.Controls.Add(Me.cmdBaixar)
        Me.Controls.Add(Me._fraPasta_2)
        Me.Controls.Add(Me._fraPasta_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(30, 65)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBaixaAutomatica"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Retorno da Exibição Digital"
        Me._fraPasta_1.ResumeLayout(False)
        Me._fraPasta_1.PerformLayout()
        CType(Me._flxRetorno_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._fraPasta_2.ResumeLayout(False)
        CType(Me._flxRetorno_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me._fraPasta_0.ResumeLayout(False)
        CType(Me._flxRetorno_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fraPasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents chkAvulso As System.Windows.Forms.CheckBox
    Public WithEvents chkArtistico As System.Windows.Forms.CheckBox
    Friend WithEvents txtVeiculo As System.Windows.Forms.TextBox
    Friend WithEvents txtData_Exibicao As WCL_SCTV.UC.UCData
    Friend WithEvents optPasta1 As System.Windows.Forms.RadioButton
    Friend WithEvents optPasta2 As System.Windows.Forms.RadioButton
    Friend WithEvents optPasta3 As System.Windows.Forms.RadioButton
#End Region

    Private Sub _flxRetorno_0_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles _flxRetorno_0.ClickEvent
    End Sub
End Class