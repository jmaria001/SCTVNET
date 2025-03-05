<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaGrade
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
        Me.grpFiltro = New System.Windows.Forms.GroupBox
        Me.btnSair = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtDatainicial = New WUC.UcText
        Me.TxtPrograma = New WUC.UcText
        Me.txtDataFinal = New WUC.UcText
        Me.TxtVeiculo = New WUC.UcText
        Me.dgConsulta_Programa = New System.Windows.Forms.DataGridView
        Me.grpOpcoes = New System.Windows.Forms.GroupBox
        Me.chkInvasao = New System.Windows.Forms.CheckBox
        Me.chkProgramaDesativado = New System.Windows.Forms.CheckBox
        Me.chkSaldoEstourado = New System.Windows.Forms.CheckBox
        Me.chkSaldoPositivo = New System.Windows.Forms.CheckBox
        Me.chkSaldoZerado = New System.Windows.Forms.CheckBox
        Me.grpTipo = New System.Windows.Forms.GroupBox
        Me.ChkNet = New System.Windows.Forms.CheckBox
        Me.chkLocal = New System.Windows.Forms.CheckBox
        Me.ChkRede = New System.Windows.Forms.CheckBox
        Me.lblEstourado = New System.Windows.Forms.Label
        Me.lblDisponivel = New System.Windows.Forms.Label
        Me.lblInvadida = New System.Windows.Forms.Label
        Me.picEstourado = New System.Windows.Forms.PictureBox
        Me.picDisponivel = New System.Windows.Forms.PictureBox
        Me.picZerado = New System.Windows.Forms.PictureBox
        Me.picInvadido = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpFiltro.SuspendLayout()
        CType(Me.dgConsulta_Programa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpcoes.SuspendLayout()
        Me.grpTipo.SuspendLayout()
        CType(Me.picEstourado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisponivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picZerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvadido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.btnSair)
        Me.grpFiltro.Controls.Add(Me.Button1)
        Me.grpFiltro.Controls.Add(Me.txtDatainicial)
        Me.grpFiltro.Controls.Add(Me.TxtPrograma)
        Me.grpFiltro.Controls.Add(Me.txtDataFinal)
        Me.grpFiltro.Controls.Add(Me.TxtVeiculo)
        Me.grpFiltro.Location = New System.Drawing.Point(12, 12)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(973, 109)
        Me.grpFiltro.TabIndex = 6
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Programaçâo"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(860, 37)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(82, 42)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(731, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDatainicial
        '
        Me.txtDatainicial.BackColor = System.Drawing.SystemColors.Control
        Me.txtDatainicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtDatainicial.Caption = "Data Inicial"
        Me.txtDatainicial.DataTextValue = Nothing
        Me.txtDatainicial.Location = New System.Drawing.Point(9, 19)
        Me.txtDatainicial.MaxLength = 10
        Me.txtDatainicial.Name = "txtDatainicial"
        Me.txtDatainicial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDatainicial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtDatainicial.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtDatainicial.pDecimal = CType(0, Byte)
        Me.txtDatainicial.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtDatainicial.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.txtDatainicial.Size = New System.Drawing.Size(89, 37)
        Me.txtDatainicial.sqlQuery = Nothing
        Me.txtDatainicial.TabIndex = 0
        Me.txtDatainicial.TextBoxLeft = CType(0, Short)
        Me.txtDatainicial.TextWidth = 0
        '
        'TxtPrograma
        '
        Me.TxtPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtPrograma.Caption = "Programa"
        Me.TxtPrograma.DataTextValue = Nothing
        Me.TxtPrograma.Location = New System.Drawing.Point(199, 62)
        Me.TxtPrograma.MaxLength = 4
        Me.TxtPrograma.Name = "TxtPrograma"
        Me.TxtPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.TxtPrograma.pDecimal = CType(0, Byte)
        Me.TxtPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.TxtPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.TxtPrograma.showButton = True
        Me.TxtPrograma.ShowDescricao = True
        Me.TxtPrograma.Size = New System.Drawing.Size(413, 37)
        Me.TxtPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.TxtPrograma.TabIndex = 4
        Me.TxtPrograma.TextBoxLeft = CType(0, Short)
        Me.TxtPrograma.TextWidth = 0
        '
        'txtDataFinal
        '
        Me.txtDataFinal.BackColor = System.Drawing.SystemColors.Control
        Me.txtDataFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtDataFinal.Caption = "Data Final"
        Me.txtDataFinal.DataTextValue = Nothing
        Me.txtDataFinal.Location = New System.Drawing.Point(104, 19)
        Me.txtDataFinal.MaxLength = 10
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDataFinal.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtDataFinal.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.txtDataFinal.pDecimal = CType(0, Byte)
        Me.txtDataFinal.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.txtDataFinal.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.txtDataFinal.Size = New System.Drawing.Size(89, 37)
        Me.txtDataFinal.sqlQuery = Nothing
        Me.txtDataFinal.TabIndex = 1
        Me.txtDataFinal.TextBoxLeft = CType(0, Short)
        Me.txtDataFinal.TextWidth = 0
        '
        'TxtVeiculo
        '
        Me.TxtVeiculo.BackColor = System.Drawing.SystemColors.Control
        Me.TxtVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtVeiculo.Caption = "Veiculo"
        Me.TxtVeiculo.DataTextValue = Nothing
        Me.TxtVeiculo.Location = New System.Drawing.Point(199, 19)
        Me.TxtVeiculo.MaxLength = 3
        Me.TxtVeiculo.Name = "TxtVeiculo"
        Me.TxtVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtVeiculo.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtVeiculo.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.TxtVeiculo.pDecimal = CType(0, Byte)
        Me.TxtVeiculo.pDicionario = WUC.clsDicionario.enuDicionario.Veiculo_Todos
        Me.TxtVeiculo.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.TxtVeiculo.showButton = True
        Me.TxtVeiculo.ShowDescricao = True
        Me.TxtVeiculo.Size = New System.Drawing.Size(413, 37)
        Me.TxtVeiculo.sqlQuery = "Execute PrNet_Veiculo_T "
        Me.TxtVeiculo.TabIndex = 3
        Me.TxtVeiculo.TextBoxLeft = CType(0, Short)
        Me.TxtVeiculo.TextWidth = 0
        '
        'dgConsulta_Programa
        '
        Me.dgConsulta_Programa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgConsulta_Programa.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgConsulta_Programa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsulta_Programa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgConsulta_Programa.Location = New System.Drawing.Point(13, 165)
        Me.dgConsulta_Programa.Name = "dgConsulta_Programa"
        Me.dgConsulta_Programa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsulta_Programa.Size = New System.Drawing.Size(972, 350)
        Me.dgConsulta_Programa.TabIndex = 7
        '
        'grpOpcoes
        '
        Me.grpOpcoes.Controls.Add(Me.chkInvasao)
        Me.grpOpcoes.Controls.Add(Me.chkProgramaDesativado)
        Me.grpOpcoes.Controls.Add(Me.chkSaldoEstourado)
        Me.grpOpcoes.Controls.Add(Me.chkSaldoPositivo)
        Me.grpOpcoes.Controls.Add(Me.chkSaldoZerado)
        Me.grpOpcoes.Location = New System.Drawing.Point(13, 521)
        Me.grpOpcoes.Name = "grpOpcoes"
        Me.grpOpcoes.Size = New System.Drawing.Size(507, 84)
        Me.grpOpcoes.TabIndex = 8
        Me.grpOpcoes.TabStop = False
        Me.grpOpcoes.Text = "Opçôes"
        '
        'chkInvasao
        '
        Me.chkInvasao.AutoSize = True
        Me.chkInvasao.Location = New System.Drawing.Point(15, 62)
        Me.chkInvasao.Name = "chkInvasao"
        Me.chkInvasao.Size = New System.Drawing.Size(368, 17)
        Me.chkInvasao.TabIndex = 5
        Me.chkInvasao.Text = "Mostra somente Programas com invasão de espaço (Aprovados ou Não)"
        Me.chkInvasao.UseVisualStyleBackColor = True
        '
        'chkProgramaDesativado
        '
        Me.chkProgramaDesativado.AutoSize = True
        Me.chkProgramaDesativado.Checked = True
        Me.chkProgramaDesativado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProgramaDesativado.Location = New System.Drawing.Point(243, 42)
        Me.chkProgramaDesativado.Name = "chkProgramaDesativado"
        Me.chkProgramaDesativado.Size = New System.Drawing.Size(179, 17)
        Me.chkProgramaDesativado.TabIndex = 4
        Me.chkProgramaDesativado.Text = "Mostrar Programas Desativados."
        Me.chkProgramaDesativado.UseVisualStyleBackColor = True
        '
        'chkSaldoEstourado
        '
        Me.chkSaldoEstourado.AutoSize = True
        Me.chkSaldoEstourado.Checked = True
        Me.chkSaldoEstourado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaldoEstourado.Location = New System.Drawing.Point(243, 19)
        Me.chkSaldoEstourado.Name = "chkSaldoEstourado"
        Me.chkSaldoEstourado.Size = New System.Drawing.Size(216, 17)
        Me.chkSaldoEstourado.TabIndex = 3
        Me.chkSaldoEstourado.Text = "Mostrar Programa com Saldo Estourado."
        Me.chkSaldoEstourado.UseVisualStyleBackColor = True
        '
        'chkSaldoPositivo
        '
        Me.chkSaldoPositivo.AutoSize = True
        Me.chkSaldoPositivo.Checked = True
        Me.chkSaldoPositivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaldoPositivo.Location = New System.Drawing.Point(15, 42)
        Me.chkSaldoPositivo.Name = "chkSaldoPositivo"
        Me.chkSaldoPositivo.Size = New System.Drawing.Size(205, 17)
        Me.chkSaldoPositivo.TabIndex = 1
        Me.chkSaldoPositivo.Text = "Mostrar Programa com Saldo Positivo."
        Me.chkSaldoPositivo.UseVisualStyleBackColor = True
        '
        'chkSaldoZerado
        '
        Me.chkSaldoZerado.AutoSize = True
        Me.chkSaldoZerado.Checked = True
        Me.chkSaldoZerado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSaldoZerado.Location = New System.Drawing.Point(15, 19)
        Me.chkSaldoZerado.Name = "chkSaldoZerado"
        Me.chkSaldoZerado.Size = New System.Drawing.Size(202, 17)
        Me.chkSaldoZerado.TabIndex = 0
        Me.chkSaldoZerado.Text = "Mostrar Programa com Saldo Zerado."
        Me.chkSaldoZerado.UseVisualStyleBackColor = True
        '
        'grpTipo
        '
        Me.grpTipo.Controls.Add(Me.ChkNet)
        Me.grpTipo.Controls.Add(Me.chkLocal)
        Me.grpTipo.Controls.Add(Me.ChkRede)
        Me.grpTipo.Location = New System.Drawing.Point(542, 521)
        Me.grpTipo.Name = "grpTipo"
        Me.grpTipo.Size = New System.Drawing.Size(145, 84)
        Me.grpTipo.TabIndex = 9
        Me.grpTipo.TabStop = False
        Me.grpTipo.Text = "Tipos da Dispo "
        '
        'ChkNet
        '
        Me.ChkNet.AutoSize = True
        Me.ChkNet.Location = New System.Drawing.Point(15, 61)
        Me.ChkNet.Name = "ChkNet"
        Me.ChkNet.Size = New System.Drawing.Size(43, 17)
        Me.ChkNet.TabIndex = 2
        Me.ChkNet.Text = "Net"
        Me.ChkNet.UseVisualStyleBackColor = True
        '
        'chkLocal
        '
        Me.chkLocal.AutoSize = True
        Me.chkLocal.Checked = True
        Me.chkLocal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLocal.Location = New System.Drawing.Point(15, 40)
        Me.chkLocal.Name = "chkLocal"
        Me.chkLocal.Size = New System.Drawing.Size(52, 17)
        Me.chkLocal.TabIndex = 1
        Me.chkLocal.Text = "Local"
        Me.chkLocal.UseVisualStyleBackColor = True
        '
        'ChkRede
        '
        Me.ChkRede.AutoSize = True
        Me.ChkRede.Location = New System.Drawing.Point(15, 19)
        Me.ChkRede.Name = "ChkRede"
        Me.ChkRede.Size = New System.Drawing.Size(52, 17)
        Me.ChkRede.TabIndex = 0
        Me.ChkRede.Text = "Rede"
        Me.ChkRede.UseVisualStyleBackColor = True
        '
        'lblEstourado
        '
        Me.lblEstourado.AutoSize = True
        Me.lblEstourado.Location = New System.Drawing.Point(795, 521)
        Me.lblEstourado.Name = "lblEstourado"
        Me.lblEstourado.Size = New System.Drawing.Size(85, 13)
        Me.lblEstourado.TabIndex = 10
        Me.lblEstourado.Text = "Saldo Estourado"
        '
        'lblDisponivel
        '
        Me.lblDisponivel.AutoSize = True
        Me.lblDisponivel.Location = New System.Drawing.Point(795, 542)
        Me.lblDisponivel.Name = "lblDisponivel"
        Me.lblDisponivel.Size = New System.Drawing.Size(74, 13)
        Me.lblDisponivel.TabIndex = 11
        Me.lblDisponivel.Text = "Saldo Positivo"
        '
        'lblInvadida
        '
        Me.lblInvadida.AutoSize = True
        Me.lblInvadida.Location = New System.Drawing.Point(795, 563)
        Me.lblInvadida.Name = "lblInvadida"
        Me.lblInvadida.Size = New System.Drawing.Size(71, 13)
        Me.lblInvadida.TabIndex = 12
        Me.lblInvadida.Text = "Saldo Zerado"
        '
        'picEstourado
        '
        Me.picEstourado.BackColor = System.Drawing.Color.Red
        Me.picEstourado.Location = New System.Drawing.Point(777, 521)
        Me.picEstourado.Name = "picEstourado"
        Me.picEstourado.Size = New System.Drawing.Size(15, 13)
        Me.picEstourado.TabIndex = 13
        Me.picEstourado.TabStop = False
        '
        'picDisponivel
        '
        Me.picDisponivel.BackColor = System.Drawing.Color.Green
        Me.picDisponivel.Location = New System.Drawing.Point(777, 542)
        Me.picDisponivel.Name = "picDisponivel"
        Me.picDisponivel.Size = New System.Drawing.Size(15, 13)
        Me.picDisponivel.TabIndex = 14
        Me.picDisponivel.TabStop = False
        '
        'picZerado
        '
        Me.picZerado.BackColor = System.Drawing.Color.Blue
        Me.picZerado.Location = New System.Drawing.Point(777, 563)
        Me.picZerado.Name = "picZerado"
        Me.picZerado.Size = New System.Drawing.Size(15, 13)
        Me.picZerado.TabIndex = 15
        Me.picZerado.TabStop = False
        '
        'picInvadido
        '
        Me.picInvadido.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picInvadido.Location = New System.Drawing.Point(777, 587)
        Me.picInvadido.Name = "picInvadido"
        Me.picInvadido.Size = New System.Drawing.Size(15, 13)
        Me.picInvadido.TabIndex = 19
        Me.picInvadido.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(795, 587)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Espaço Invadido"
        '
        'frmConsultaGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(996, 612)
        Me.Controls.Add(Me.picInvadido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picZerado)
        Me.Controls.Add(Me.picDisponivel)
        Me.Controls.Add(Me.picEstourado)
        Me.Controls.Add(Me.lblInvadida)
        Me.Controls.Add(Me.lblDisponivel)
        Me.Controls.Add(Me.lblEstourado)
        Me.Controls.Add(Me.grpTipo)
        Me.Controls.Add(Me.grpOpcoes)
        Me.Controls.Add(Me.dgConsulta_Programa)
        Me.Controls.Add(Me.grpFiltro)
        Me.Name = "frmConsultaGrade"
        Me.Text = "Consulta da Programação Prevista"
        Me.grpFiltro.ResumeLayout(False)
        CType(Me.dgConsulta_Programa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpcoes.ResumeLayout(False)
        Me.grpOpcoes.PerformLayout()
        Me.grpTipo.ResumeLayout(False)
        Me.grpTipo.PerformLayout()
        CType(Me.picEstourado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisponivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picZerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvadido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDatainicial As WUC.UcText
    Friend WithEvents txtDataFinal As WUC.UcText
    Friend WithEvents TxtPrograma As WUC.UcText
    Friend WithEvents TxtVeiculo As WUC.UcText
    Friend WithEvents grpFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents grpOpcoes As System.Windows.Forms.GroupBox
    Friend WithEvents chkSaldoPositivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaldoZerado As System.Windows.Forms.CheckBox
    Friend WithEvents chkProgramaDesativado As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaldoEstourado As System.Windows.Forms.CheckBox
    Friend WithEvents grpTipo As System.Windows.Forms.GroupBox
    Friend WithEvents ChkNet As System.Windows.Forms.CheckBox
    Friend WithEvents chkLocal As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRede As System.Windows.Forms.CheckBox
    Friend WithEvents lblEstourado As System.Windows.Forms.Label
    Friend WithEvents lblDisponivel As System.Windows.Forms.Label
    Friend WithEvents lblInvadida As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents picEstourado As System.Windows.Forms.PictureBox
    Friend WithEvents picDisponivel As System.Windows.Forms.PictureBox
    Friend WithEvents picZerado As System.Windows.Forms.PictureBox
    Friend WithEvents dgConsulta_Programa As System.Windows.Forms.DataGridView
    Friend WithEvents picInvadido As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkInvasao As System.Windows.Forms.CheckBox
End Class
