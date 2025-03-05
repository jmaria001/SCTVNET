<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRetorno_Play_List
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
    Public WithEvents chkArtistico As System.Windows.Forms.CheckBox
	Public WithEvents chkAvulso As System.Windows.Forms.CheckBox
    Public WithEvents txtCaminho As System.Windows.Forms.TextBox
	Public WithEvents cmdCaminho As System.Windows.Forms.Button
    Public WithEvents _Label2_0 As System.Windows.Forms.Label
	Public WithEvents _Label3_0 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents txtHoraFim As System.Windows.Forms.TextBox
    Public WithEvents _Label2_4 As System.Windows.Forms.Label
	Public WithEvents _Label2_3 As System.Windows.Forms.Label
    Public WithEvents _Label2_1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancela As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.ucVeiculo = New WUC.UcText
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHorarioEmissora = New System.Windows.Forms.TextBox
        Me.txtSistemaDigital = New System.Windows.Forms.TextBox
        Me.UcData = New WCL_SCTV.UC.UCData
        Me.chkArtistico = New System.Windows.Forms.CheckBox
        Me.chkAvulso = New System.Windows.Forms.CheckBox
        Me.txtCaminho = New System.Windows.Forms.TextBox
        Me.cmdCaminho = New System.Windows.Forms.Button
        Me._Label2_0 = New System.Windows.Forms.Label
        Me._Label3_0 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.UcDataFim = New WCL_SCTV.UC.UCData
        Me.UcDataInicio = New WCL_SCTV.UC.UCData
        Me.txtHoraFim = New System.Windows.Forms.TextBox
        Me.txtHoraInicio = New System.Windows.Forms.TextBox
        Me._Label2_4 = New System.Windows.Forms.Label
        Me._Label2_3 = New System.Windows.Forms.Label
        Me._Label2_2 = New System.Windows.Forms.Label
        Me._Label2_1 = New System.Windows.Forms.Label
        Me.cmdCancela = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.ucVeiculo)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Controls.Add(Me.txtHorarioEmissora)
        Me.Frame2.Controls.Add(Me.txtSistemaDigital)
        Me.Frame2.Controls.Add(Me.UcData)
        Me.Frame2.Controls.Add(Me.chkArtistico)
        Me.Frame2.Controls.Add(Me.chkAvulso)
        Me.Frame2.Controls.Add(Me.txtCaminho)
        Me.Frame2.Controls.Add(Me.cmdCaminho)
        Me.Frame2.Controls.Add(Me._Label2_0)
        Me.Frame2.Controls.Add(Me._Label3_0)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(6, 9)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(433, 204)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
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
        Me.ucVeiculo.Size = New System.Drawing.Size(410, 25)
        Me.ucVeiculo.sqlQuery = "Execute PrNet_Veiculo_L Null,''"
        Me.ucVeiculo.TabIndex = 0
        Me.ucVeiculo.TextBoxLeft = CType(0, Short)
        Me.ucVeiculo.TextWidth = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(292, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(112, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Abertura da Emissora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(159, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(86, 14)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Sistema Exibidor"
        '
        'txtHorarioEmissora
        '
        Me.txtHorarioEmissora.AcceptsReturn = True
        Me.txtHorarioEmissora.BackColor = System.Drawing.SystemColors.Window
        Me.txtHorarioEmissora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHorarioEmissora.Enabled = False
        Me.txtHorarioEmissora.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorarioEmissora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHorarioEmissora.Location = New System.Drawing.Point(295, 85)
        Me.txtHorarioEmissora.MaxLength = 0
        Me.txtHorarioEmissora.Name = "txtHorarioEmissora"
        Me.txtHorarioEmissora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHorarioEmissora.Size = New System.Drawing.Size(121, 20)
        Me.txtHorarioEmissora.TabIndex = 3
        '
        'txtSistemaDigital
        '
        Me.txtSistemaDigital.AcceptsReturn = True
        Me.txtSistemaDigital.BackColor = System.Drawing.SystemColors.Window
        Me.txtSistemaDigital.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSistemaDigital.Enabled = False
        Me.txtSistemaDigital.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSistemaDigital.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSistemaDigital.Location = New System.Drawing.Point(162, 85)
        Me.txtSistemaDigital.MaxLength = 0
        Me.txtSistemaDigital.Name = "txtSistemaDigital"
        Me.txtSistemaDigital.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSistemaDigital.Size = New System.Drawing.Size(121, 20)
        Me.txtSistemaDigital.TabIndex = 2
        '
        'UcData
        '
        Me.UcData.BackColor = System.Drawing.Color.Transparent
        Me.UcData.DateTime = New Date(CType(0, Long))
        Me.UcData.Formato = "dd/MM/yyyy ddd"
        Me.UcData.Hoje = False
        Me.UcData.Location = New System.Drawing.Point(10, 85)
        Me.UcData.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcData.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcData.Name = "UcData"
        Me.UcData.Permite_Futuro = True
        Me.UcData.Permite_Limpar = True
        Me.UcData.Permite_Passado = True
        Me.UcData.Preenchimento_Obrigatorio = False
        Me.UcData.Size = New System.Drawing.Size(146, 25)
        Me.UcData.TabIndex = 1
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
        Me.chkArtistico.Location = New System.Drawing.Point(169, 173)
        Me.chkArtistico.Name = "chkArtistico"
        Me.chkArtistico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkArtistico.Size = New System.Drawing.Size(138, 18)
        Me.chkArtistico.TabIndex = 7
        Me.chkArtistico.TabStop = False
        Me.chkArtistico.Text = "Mostrar Fitas Artisticas"
        Me.chkArtistico.UseVisualStyleBackColor = False
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
        Me.chkAvulso.Location = New System.Drawing.Point(10, 173)
        Me.chkAvulso.Name = "chkAvulso"
        Me.chkAvulso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAvulso.Size = New System.Drawing.Size(132, 18)
        Me.chkAvulso.TabIndex = 6
        Me.chkAvulso.TabStop = False
        Me.chkAvulso.Text = "Mostrar Fitas Avulsas"
        Me.chkAvulso.UseVisualStyleBackColor = False
        '
        'txtCaminho
        '
        Me.txtCaminho.AcceptsReturn = True
        Me.txtCaminho.BackColor = System.Drawing.SystemColors.Window
        Me.txtCaminho.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCaminho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaminho.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCaminho.Location = New System.Drawing.Point(12, 138)
        Me.txtCaminho.MaxLength = 0
        Me.txtCaminho.Name = "txtCaminho"
        Me.txtCaminho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCaminho.Size = New System.Drawing.Size(368, 20)
        Me.txtCaminho.TabIndex = 4
        '
        'cmdCaminho
        '
        Me.cmdCaminho.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCaminho.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCaminho.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCaminho.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCaminho.Location = New System.Drawing.Point(386, 138)
        Me.cmdCaminho.Name = "cmdCaminho"
        Me.cmdCaminho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCaminho.Size = New System.Drawing.Size(30, 21)
        Me.cmdCaminho.TabIndex = 5
        Me.cmdCaminho.TabStop = False
        Me.cmdCaminho.Text = "..."
        Me.cmdCaminho.UseVisualStyleBackColor = False
        '
        '_Label2_0
        '
        Me._Label2_0.AutoSize = True
        Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_0.Location = New System.Drawing.Point(9, 68)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(87, 14)
        Me._Label2_0.TabIndex = 1
        Me._Label2_0.Text = "Data de Exibição"
        '
        '_Label3_0
        '
        Me._Label3_0.AutoSize = True
        Me._Label3_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label3_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label3_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label3_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label3_0.Location = New System.Drawing.Point(9, 121)
        Me._Label3_0.Name = "_Label3_0"
        Me._Label3_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label3_0.Size = New System.Drawing.Size(215, 14)
        Me._Label3_0.TabIndex = 27
        Me._Label3_0.Text = "Localização do Arquivo de Log da Exibição"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.UcDataFim)
        Me.Frame1.Controls.Add(Me.UcDataInicio)
        Me.Frame1.Controls.Add(Me.txtHoraFim)
        Me.Frame1.Controls.Add(Me.txtHoraInicio)
        Me.Frame1.Controls.Add(Me._Label2_4)
        Me.Frame1.Controls.Add(Me._Label2_3)
        Me.Frame1.Controls.Add(Me._Label2_2)
        Me.Frame1.Controls.Add(Me._Label2_1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 236)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(433, 88)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Considerar Log´s no periodo"
        '
        'UcDataFim
        '
        Me.UcDataFim.BackColor = System.Drawing.Color.Transparent
        Me.UcDataFim.DateTime = New Date(CType(0, Long))
        Me.UcDataFim.Formato = "dd/MM/yyyy ddd"
        Me.UcDataFim.Hoje = False
        Me.UcDataFim.Location = New System.Drawing.Point(92, 50)
        Me.UcDataFim.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcDataFim.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcDataFim.Name = "UcDataFim"
        Me.UcDataFim.Permite_Futuro = True
        Me.UcDataFim.Permite_Limpar = True
        Me.UcDataFim.Permite_Passado = True
        Me.UcDataFim.Preenchimento_Obrigatorio = False
        Me.UcDataFim.Size = New System.Drawing.Size(153, 25)
        Me.UcDataFim.TabIndex = 1
        '
        'UcDataInicio
        '
        Me.UcDataInicio.BackColor = System.Drawing.Color.Transparent
        Me.UcDataInicio.DateTime = New Date(CType(0, Long))
        Me.UcDataInicio.Formato = "dd/MM/yyyy ddd"
        Me.UcDataInicio.Hoje = False
        Me.UcDataInicio.Location = New System.Drawing.Point(92, 19)
        Me.UcDataInicio.MaximumSize = New System.Drawing.Size(500, 25)
        Me.UcDataInicio.MinimumSize = New System.Drawing.Size(115, 25)
        Me.UcDataInicio.Name = "UcDataInicio"
        Me.UcDataInicio.Permite_Futuro = True
        Me.UcDataInicio.Permite_Limpar = True
        Me.UcDataInicio.Permite_Passado = True
        Me.UcDataInicio.Preenchimento_Obrigatorio = False
        Me.UcDataInicio.Size = New System.Drawing.Size(153, 25)
        Me.UcDataInicio.TabIndex = 0
        '
        'txtHoraFim
        '
        Me.txtHoraFim.AcceptsReturn = True
        Me.txtHoraFim.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoraFim.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoraFim.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraFim.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoraFim.Location = New System.Drawing.Point(335, 54)
        Me.txtHoraFim.MaxLength = 5
        Me.txtHoraFim.Name = "txtHoraFim"
        Me.txtHoraFim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoraFim.Size = New System.Drawing.Size(81, 20)
        Me.txtHoraFim.TabIndex = 3
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.AcceptsReturn = True
        Me.txtHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtHoraInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoraInicio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHoraInicio.Location = New System.Drawing.Point(335, 24)
        Me.txtHoraInicio.MaxLength = 5
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHoraInicio.Size = New System.Drawing.Size(81, 20)
        Me.txtHoraInicio.TabIndex = 2
        '
        '_Label2_4
        '
        Me._Label2_4.AutoSize = True
        Me._Label2_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_4.Location = New System.Drawing.Point(270, 58)
        Me._Label2_4.Name = "_Label2_4"
        Me._Label2_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_4.Size = New System.Drawing.Size(49, 14)
        Me._Label2_4.TabIndex = 21
        Me._Label2_4.Text = "Hora Fim"
        '
        '_Label2_3
        '
        Me._Label2_3.AutoSize = True
        Me._Label2_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_3.Location = New System.Drawing.Point(22, 57)
        Me._Label2_3.Name = "_Label2_3"
        Me._Label2_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_3.Size = New System.Drawing.Size(48, 14)
        Me._Label2_3.TabIndex = 19
        Me._Label2_3.Text = "Data Fim"
        '
        '_Label2_2
        '
        Me._Label2_2.AutoSize = True
        Me._Label2_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_2.Location = New System.Drawing.Point(270, 24)
        Me._Label2_2.Name = "_Label2_2"
        Me._Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_2.Size = New System.Drawing.Size(57, 14)
        Me._Label2_2.TabIndex = 18
        Me._Label2_2.Text = "Hora Inicio"
        '
        '_Label2_1
        '
        Me._Label2_1.AutoSize = True
        Me._Label2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label2_1.Location = New System.Drawing.Point(22, 24)
        Me._Label2_1.Name = "_Label2_1"
        Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_1.Size = New System.Drawing.Size(56, 14)
        Me._Label2_1.TabIndex = 16
        Me._Label2_1.Text = "Data Início"
        '
        'cmdCancela
        '
        Me.cmdCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancela.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancela.Location = New System.Drawing.Point(365, 330)
        Me.cmdCancela.Name = "cmdCancela"
        Me.cmdCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancela.Size = New System.Drawing.Size(75, 27)
        Me.cmdCancela.TabIndex = 12
        Me.cmdCancela.TabStop = False
        Me.cmdCancela.Text = "&Cancela"
        Me.cmdCancela.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(279, 330)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(75, 27)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'frmRetorno_Play_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(452, 367)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdCancela)
        Me.Controls.Add(Me.cmdOk)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(127, 133)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRetorno_Play_List"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Importação de Log do Play List"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents txtSistemaDigital As System.Windows.Forms.TextBox
    Public WithEvents txtHorarioEmissora As System.Windows.Forms.TextBox
    Friend WithEvents UcData As WCL_SCTV.UC.UCData
    Friend WithEvents UcDataFim As WCL_SCTV.UC.UCData
    Friend WithEvents UcDataInicio As WCL_SCTV.UC.UCData
    Public WithEvents _Label2_2 As System.Windows.Forms.Label
    Public WithEvents txtHoraInicio As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ucVeiculo As WUC.UcText
#End Region 
End Class