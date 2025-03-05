<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConsisteBreak
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
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
	Public WithEvents chkCritica As System.Windows.Forms.CheckBox
	Public WithEvents chkExcluir As System.Windows.Forms.CheckBox
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents chkExibir As System.Windows.Forms.CheckBox
	Public WithEvents txtData As System.Windows.Forms.TextBox
	Public WithEvents txtVeiculo As System.Windows.Forms.TextBox
	Public WithEvents txtPrograma As System.Windows.Forms.TextBox
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
    Public WithEvents flxConsistencia As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsisteBreak))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkCritica = New System.Windows.Forms.CheckBox
        Me.chkExcluir = New System.Windows.Forms.CheckBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.chkExibir = New System.Windows.Forms.CheckBox
        Me.txtData = New System.Windows.Forms.TextBox
        Me.txtVeiculo = New System.Windows.Forms.TextBox
        Me.txtPrograma = New System.Windows.Forms.TextBox
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.flxConsistencia = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flxConsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkCritica
        '
        Me.chkCritica.BackColor = System.Drawing.SystemColors.Control
        Me.chkCritica.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCritica.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCritica.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCritica.Location = New System.Drawing.Point(195, 261)
        Me.chkCritica.Name = "chkCritica"
        Me.chkCritica.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCritica.Size = New System.Drawing.Size(136, 16)
        Me.chkCritica.TabIndex = 10
        Me.chkCritica.Text = "Critica"
        Me.chkCritica.UseVisualStyleBackColor = False
        Me.chkCritica.Visible = False
        '
        'chkExcluir
        '
        Me.chkExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.chkExcluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkExcluir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExcluir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkExcluir.Location = New System.Drawing.Point(450, 297)
        Me.chkExcluir.Name = "chkExcluir"
        Me.chkExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkExcluir.Size = New System.Drawing.Size(136, 16)
        Me.chkExcluir.TabIndex = 9
        Me.chkExcluir.Text = "Excluir estas mensagens"
        Me.chkExcluir.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(498, 327)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(97, 31)
        Me.cmdOk.TabIndex = 8
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'chkExibir
        '
        Me.chkExibir.BackColor = System.Drawing.SystemColors.Control
        Me.chkExibir.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkExibir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExibir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkExibir.Location = New System.Drawing.Point(336, 264)
        Me.chkExibir.Name = "chkExibir"
        Me.chkExibir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkExibir.Size = New System.Drawing.Size(121, 16)
        Me.chkExibir.TabIndex = 7
        Me.chkExibir.Text = "Exibir"
        Me.chkExibir.UseVisualStyleBackColor = False
        Me.chkExibir.Visible = False
        '
        'txtData
        '
        Me.txtData.AcceptsReturn = True
        Me.txtData.BackColor = System.Drawing.SystemColors.Window
        Me.txtData.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtData.Location = New System.Drawing.Point(300, 57)
        Me.txtData.MaxLength = 0
        Me.txtData.Name = "txtData"
        Me.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtData.Size = New System.Drawing.Size(106, 20)
        Me.txtData.TabIndex = 6
        Me.txtData.Visible = False
        '
        'txtVeiculo
        '
        Me.txtVeiculo.AcceptsReturn = True
        Me.txtVeiculo.BackColor = System.Drawing.SystemColors.Window
        Me.txtVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVeiculo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeiculo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVeiculo.Location = New System.Drawing.Point(300, 33)
        Me.txtVeiculo.MaxLength = 0
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVeiculo.Size = New System.Drawing.Size(106, 20)
        Me.txtVeiculo.TabIndex = 5
        Me.txtVeiculo.Visible = False
        '
        'txtPrograma
        '
        Me.txtPrograma.AcceptsReturn = True
        Me.txtPrograma.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrograma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrograma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrograma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrograma.Location = New System.Drawing.Point(300, 84)
        Me.txtPrograma.MaxLength = 0
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrograma.Size = New System.Drawing.Size(106, 20)
        Me.txtPrograma.TabIndex = 4
        Me.txtPrograma.Visible = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.Location = New System.Drawing.Point(3, 291)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(37, 31)
        Me.Picture1.TabIndex = 1
        Me.Picture1.TabStop = False
        '
        'flxConsistencia
        '
        Me.flxConsistencia.Location = New System.Drawing.Point(3, 3)
        Me.flxConsistencia.Name = "flxConsistencia"
        Me.flxConsistencia.OcxState = CType(resources.GetObject("flxConsistencia.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxConsistencia.Size = New System.Drawing.Size(595, 284)
        Me.flxConsistencia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(42, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(278, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Atenção: Favor Conferir o Roteiro"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(479, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Os Breaks e Intervalos acima relacionados foram excluidos da Composiçao de Breaks" & _
            " após a ordenação do roteiro e os comerciais foram desordenados."
        '
        'frmConsisteBreak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(608, 365)
        Me.Controls.Add(Me.chkCritica)
        Me.Controls.Add(Me.chkExcluir)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.chkExibir)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtVeiculo)
        Me.Controls.Add(Me.txtPrograma)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.flxConsistencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(99, 166)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsisteBreak"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alerta de Alteraçao de Breaks em Roteiro Ordenado"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flxConsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
End Class