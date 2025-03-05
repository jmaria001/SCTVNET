<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConsultaFitaOrdenada
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
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmdFiltroLimpar As System.Windows.Forms.Button
    Public WithEvents _cmdCancela_1 As System.Windows.Forms.Button
	Public WithEvents lblFiltro As System.Windows.Forms.Label
	Public WithEvents picFiltro As System.Windows.Forms.Panel
	Public WithEvents cmdSair As System.Windows.Forms.Button
	Public WithEvents cmdFiltro As System.Windows.Forms.Button
    Public WithEvents flxConsulta As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents cmdCancela As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lblCampos As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaFitaOrdenada))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picFiltro = New System.Windows.Forms.Panel
        Me.UcButton1 = New WUC.ucButton
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.txtSequencia = New WUC.UcText
        Me.txtContrato = New WUC.UcText
        Me.txtEmpresa = New WUC.UcText
        Me.txtFitaFim = New WUC.UcText
        Me.txtFitaInicio = New WUC.UcText
        Me.ucPrograma = New WUC.UcText
        Me.UcText3 = New WUC.UcText
        Me.dteDataInicio = New WUC.UcText
        Me.ucVeiculo = New WUC.UcText
        Me.cmdFiltroLimpar = New System.Windows.Forms.Button
        Me._cmdCancela_1 = New System.Windows.Forms.Button
        Me.lblFiltro = New System.Windows.Forms.Label
        Me.cmdSair = New System.Windows.Forms.Button
        Me.cmdFiltro = New System.Windows.Forms.Button
        Me.flxConsulta = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.cmdCancela = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.lblCampos = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.picFiltro.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.flxConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFiltro
        '
        Me.picFiltro.BackColor = System.Drawing.SystemColors.Control
        Me.picFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFiltro.Controls.Add(Me.UcButton1)
        Me.picFiltro.Controls.Add(Me.Frame3)
        Me.picFiltro.Controls.Add(Me.cmdFiltroLimpar)
        Me.picFiltro.Controls.Add(Me._cmdCancela_1)
        Me.picFiltro.Controls.Add(Me.lblFiltro)
        Me.picFiltro.Cursor = System.Windows.Forms.Cursors.Default
        Me.picFiltro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picFiltro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picFiltro.Location = New System.Drawing.Point(147, 32)
        Me.picFiltro.Name = "picFiltro"
        Me.picFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picFiltro.Size = New System.Drawing.Size(469, 324)
        Me.picFiltro.TabIndex = 29
        Me.picFiltro.TabStop = True
        '
        'UcButton1
        '
        Me.UcButton1.BackColor = System.Drawing.SystemColors.Control
        Me.UcButton1.Location = New System.Drawing.Point(278, 264)
        Me.UcButton1.Name = "UcButton1"
        Me.UcButton1.Size = New System.Drawing.Size(179, 38)
        Me.UcButton1.TabIndex = 4
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.txtSequencia)
        Me.Frame3.Controls.Add(Me.txtContrato)
        Me.Frame3.Controls.Add(Me.txtEmpresa)
        Me.Frame3.Controls.Add(Me.txtFitaFim)
        Me.Frame3.Controls.Add(Me.txtFitaInicio)
        Me.Frame3.Controls.Add(Me.ucPrograma)
        Me.Frame3.Controls.Add(Me.UcText3)
        Me.Frame3.Controls.Add(Me.dteDataInicio)
        Me.Frame3.Controls.Add(Me.ucVeiculo)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(9, 21)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(448, 230)
        Me.Frame3.TabIndex = 2
        Me.Frame3.TabStop = False
        '
        'txtSequencia
        '
        Me.txtSequencia.BackColor = System.Drawing.SystemColors.Control
        Me.txtSequencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtSequencia.Caption = "Sequencia"
        Me.txtSequencia.DataTextValue = Nothing
        Me.txtSequencia.Location = New System.Drawing.Point(306, 188)
        Me.txtSequencia.MaxLength = 32767
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSequencia.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtSequencia.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtSequencia.pDecimal = CType(0, Byte)
        Me.txtSequencia.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtSequencia.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.txtSequencia.Size = New System.Drawing.Size(121, 25)
        Me.txtSequencia.sqlQuery = Nothing
        Me.txtSequencia.TabIndex = 8
        Me.txtSequencia.TextBoxLeft = CType(0, Short)
        Me.txtSequencia.TextWidth = 0
        '
        'txtContrato
        '
        Me.txtContrato.BackColor = System.Drawing.SystemColors.Control
        Me.txtContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtContrato.Caption = "Contrato"
        Me.txtContrato.DataTextValue = Nothing
        Me.txtContrato.Location = New System.Drawing.Point(20, 184)
        Me.txtContrato.MaxLength = 32767
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContrato.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtContrato.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtContrato.pDecimal = CType(0, Byte)
        Me.txtContrato.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtContrato.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtContrato.Size = New System.Drawing.Size(221, 25)
        Me.txtContrato.sqlQuery = Nothing
        Me.txtContrato.TabIndex = 7
        Me.txtContrato.TextBoxLeft = CType(110, Short)
        Me.txtContrato.TextWidth = 0
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmpresa.Caption = "Empresa"
        Me.txtEmpresa.DataTextValue = Nothing
        Me.txtEmpresa.Location = New System.Drawing.Point(20, 151)
        Me.txtEmpresa.MaxLength = 3
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpresa.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtEmpresa.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtEmpresa.pDecimal = CType(0, Byte)
        Me.txtEmpresa.pDicionario = WUC.clsDicionario.enuDicionario.Empresa
        Me.txtEmpresa.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtEmpresa.showButton = True
        Me.txtEmpresa.ShowDescricao = True
        Me.txtEmpresa.Size = New System.Drawing.Size(407, 25)
        Me.txtEmpresa.sqlQuery = "Execute PrNet_Empresa_L  Null,''"
        Me.txtEmpresa.TabIndex = 6
        Me.txtEmpresa.TextBoxLeft = CType(110, Short)
        Me.txtEmpresa.TextWidth = 0
        '
        'txtFitaFim
        '
        Me.txtFitaFim.BackColor = System.Drawing.SystemColors.Control
        Me.txtFitaFim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtFitaFim.Caption = "Até"
        Me.txtFitaFim.DataTextValue = Nothing
        Me.txtFitaFim.Location = New System.Drawing.Point(291, 118)
        Me.txtFitaFim.MaxLength = 32767
        Me.txtFitaFim.Name = "txtFitaFim"
        Me.txtFitaFim.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFitaFim.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtFitaFim.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtFitaFim.pDecimal = CType(0, Byte)
        Me.txtFitaFim.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtFitaFim.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtFitaFim.Size = New System.Drawing.Size(136, 25)
        Me.txtFitaFim.sqlQuery = Nothing
        Me.txtFitaFim.TabIndex = 5
        Me.txtFitaFim.TextBoxLeft = CType(0, Short)
        Me.txtFitaFim.TextWidth = 0
        '
        'txtFitaInicio
        '
        Me.txtFitaInicio.BackColor = System.Drawing.SystemColors.Control
        Me.txtFitaInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtFitaInicio.Caption = "Número de Fita   De"
        Me.txtFitaInicio.DataTextValue = Nothing
        Me.txtFitaInicio.Location = New System.Drawing.Point(20, 118)
        Me.txtFitaInicio.MaxLength = 32767
        Me.txtFitaInicio.Name = "txtFitaInicio"
        Me.txtFitaInicio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFitaInicio.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.txtFitaInicio.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtFitaInicio.pDecimal = CType(0, Byte)
        Me.txtFitaInicio.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtFitaInicio.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtFitaInicio.Size = New System.Drawing.Size(212, 25)
        Me.txtFitaInicio.sqlQuery = Nothing
        Me.txtFitaInicio.TabIndex = 4
        Me.txtFitaInicio.TextBoxLeft = CType(110, Short)
        Me.txtFitaInicio.TextWidth = 0
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(20, 85)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Grade
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(407, 25)
        Me.ucPrograma.sqlQuery = "execute PrNet_Programa_Grade '','0001-01-01','0001-01-01',NULL"
        Me.ucPrograma.TabIndex = 3
        Me.ucPrograma.TextBoxLeft = CType(110, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'UcText3
        '
        Me.UcText3.BackColor = System.Drawing.SystemColors.Control
        Me.UcText3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcText3.Caption = "Até"
        Me.UcText3.DataTextValue = Nothing
        Me.UcText3.Location = New System.Drawing.Point(276, 50)
        Me.UcText3.MaxLength = 10
        Me.UcText3.Name = "UcText3"
        Me.UcText3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcText3.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.UcText3.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.UcText3.pDecimal = CType(0, Byte)
        Me.UcText3.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.UcText3.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.UcText3.Size = New System.Drawing.Size(151, 25)
        Me.UcText3.sqlQuery = Nothing
        Me.UcText3.TabIndex = 2
        Me.UcText3.TextBoxLeft = CType(0, Short)
        Me.UcText3.TextWidth = 0
        '
        'dteDataInicio
        '
        Me.dteDataInicio.BackColor = System.Drawing.SystemColors.Control
        Me.dteDataInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.dteDataInicio.Caption = "Período   De"
        Me.dteDataInicio.DataTextValue = Nothing
        Me.dteDataInicio.Location = New System.Drawing.Point(20, 52)
        Me.dteDataInicio.MaxLength = 10
        Me.dteDataInicio.Name = "dteDataInicio"
        Me.dteDataInicio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dteDataInicio.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.dteDataInicio.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.dteDataInicio.pDecimal = CType(0, Byte)
        Me.dteDataInicio.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.dteDataInicio.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.dteDataInicio.Size = New System.Drawing.Size(230, 25)
        Me.dteDataInicio.sqlQuery = Nothing
        Me.dteDataInicio.TabIndex = 1
        Me.dteDataInicio.TextBoxLeft = CType(110, Short)
        Me.dteDataInicio.TextWidth = 0
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
        Me.ucVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucVeiculo.pDecimal = CType(0, Byte)
        Me.ucVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Codigo
        Me.ucVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucVeiculo.showButton = True
        Me.ucVeiculo.ShowDescricao = True
        Me.ucVeiculo.Size = New System.Drawing.Size(407, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(110, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'cmdFiltroLimpar
        '
        Me.cmdFiltroLimpar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltroLimpar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFiltroLimpar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltroLimpar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFiltroLimpar.Location = New System.Drawing.Point(9, 264)
        Me.cmdFiltroLimpar.Name = "cmdFiltroLimpar"
        Me.cmdFiltroLimpar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFiltroLimpar.Size = New System.Drawing.Size(91, 38)
        Me.cmdFiltroLimpar.TabIndex = 3
        Me.cmdFiltroLimpar.TabStop = False
        Me.cmdFiltroLimpar.Text = "&Limpar Opções"
        Me.cmdFiltroLimpar.UseVisualStyleBackColor = False
        '
        '_cmdCancela_1
        '
        Me._cmdCancela_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdCancela_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdCancela_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cmdCancela_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.SetIndex(Me._cmdCancela_1, CType(1, Short))
        Me._cmdCancela_1.Location = New System.Drawing.Point(444, 0)
        Me._cmdCancela_1.Name = "_cmdCancela_1"
        Me._cmdCancela_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdCancela_1.Size = New System.Drawing.Size(19, 19)
        Me._cmdCancela_1.TabIndex = 30
        Me._cmdCancela_1.TabStop = False
        Me._cmdCancela_1.Text = "X"
        Me._cmdCancela_1.UseVisualStyleBackColor = False
        '
        'lblFiltro
        '
        Me.lblFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiltro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.ForeColor = System.Drawing.Color.White
        Me.lblFiltro.Location = New System.Drawing.Point(0, 0)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFiltro.Size = New System.Drawing.Size(530, 19)
        Me.lblFiltro.TabIndex = 0
        Me.lblFiltro.Text = "  Opções de Filtro"
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Location = New System.Drawing.Point(673, 419)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(85, 39)
        Me.cmdSair.TabIndex = 28
        Me.cmdSair.TabStop = False
        Me.cmdSair.Text = "&Sair"
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'cmdFiltro
        '
        Me.cmdFiltro.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFiltro.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFiltro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFiltro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFiltro.Location = New System.Drawing.Point(571, 419)
        Me.cmdFiltro.Name = "cmdFiltro"
        Me.cmdFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFiltro.Size = New System.Drawing.Size(85, 39)
        Me.cmdFiltro.TabIndex = 27
        Me.cmdFiltro.TabStop = False
        Me.cmdFiltro.Text = "&Filtrar"
        Me.cmdFiltro.UseVisualStyleBackColor = False
        '
        'flxConsulta
        '
        Me.flxConsulta.Location = New System.Drawing.Point(6, 8)
        Me.flxConsulta.Name = "flxConsulta"
        Me.flxConsulta.OcxState = CType(resources.GetObject("flxConsulta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.flxConsulta.Size = New System.Drawing.Size(760, 367)
        Me.flxConsulta.TabIndex = 0
        '
        'frmConsultaFitaOrdenada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(773, 468)
        Me.Controls.Add(Me.picFiltro)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdFiltro)
        Me.Controls.Add(Me.flxConsulta)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaFitaOrdenada"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consulta de Fitas Ordenadas"
        Me.picFiltro.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.flxConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents UcText3 As WUC.UcText
    Friend WithEvents dteDataInicio As WUC.UcText
    Friend WithEvents ucVeiculo As WUC.UcText
    Friend WithEvents txtFitaInicio As WUC.UcText
    Friend WithEvents txtSequencia As WUC.UcText
    Friend WithEvents txtContrato As WUC.UcText
    Friend WithEvents txtEmpresa As WUC.UcText
    Friend WithEvents txtFitaFim As WUC.UcText
    Friend WithEvents UcButton1 As WUC.ucButton
    Friend WithEvents AsmxFita_Ordenada1 As MSAClass.AsmxFita_Ordenada.asmxFita_Ordenada
#End Region
End Class