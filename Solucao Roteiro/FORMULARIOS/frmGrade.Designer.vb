<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrade
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
        Me.groupVeiculo = New System.Windows.Forms.GroupBox
        Me.gridVeiculo = New System.Windows.Forms.DataGridView
        Me.groupProgramacao = New System.Windows.Forms.GroupBox
        Me.btnPrograma = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboFaixaHoraria = New System.Windows.Forms.ComboBox
        Me.GroupPropagar = New System.Windows.Forms.GroupBox
        Me.chkSab = New System.Windows.Forms.CheckBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.chkSex = New System.Windows.Forms.CheckBox
        Me.chkQui = New System.Windows.Forms.CheckBox
        Me.chkQua = New System.Windows.Forms.CheckBox
        Me.chkTer = New System.Windows.Forms.CheckBox
        Me.chkSeg = New System.Windows.Forms.CheckBox
        Me.chkDom = New System.Windows.Forms.CheckBox
        Me.groupResumo = New System.Windows.Forms.GroupBox
        Me.gridCritica = New System.Windows.Forms.DataGridView
        Me.ucPropagarAte = New WUC.UcText
        Me.ucPropagarDE = New WUC.UcText
        Me.btnGrade = New WUC.ucButton
        Me.ucDisponibilidade = New WUC.UcText
        Me.ucHoraTermino = New WUC.UcText
        Me.ucHoraInicio = New WUC.UcText
        Me.ucPrograma = New WUC.UcText
        Me.groupVeiculo.SuspendLayout()
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupProgramacao.SuspendLayout()
        Me.GroupPropagar.SuspendLayout()
        Me.groupResumo.SuspendLayout()
        CType(Me.gridCritica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupVeiculo
        '
        Me.groupVeiculo.Controls.Add(Me.gridVeiculo)
        Me.groupVeiculo.Location = New System.Drawing.Point(13, 13)
        Me.groupVeiculo.Name = "groupVeiculo"
        Me.groupVeiculo.Size = New System.Drawing.Size(432, 283)
        Me.groupVeiculo.TabIndex = 0
        Me.groupVeiculo.TabStop = False
        Me.groupVeiculo.Text = "Veículos"
        '
        'gridVeiculo
        '
        Me.gridVeiculo.BackgroundColor = System.Drawing.Color.White
        Me.gridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVeiculo.Location = New System.Drawing.Point(6, 19)
        Me.gridVeiculo.Name = "gridVeiculo"
        Me.gridVeiculo.Size = New System.Drawing.Size(420, 258)
        Me.gridVeiculo.TabIndex = 1
        '
        'groupProgramacao
        '
        Me.groupProgramacao.Controls.Add(Me.btnPrograma)
        Me.groupProgramacao.Controls.Add(Me.Label1)
        Me.groupProgramacao.Controls.Add(Me.cboFaixaHoraria)
        Me.groupProgramacao.Controls.Add(Me.ucDisponibilidade)
        Me.groupProgramacao.Controls.Add(Me.ucHoraTermino)
        Me.groupProgramacao.Controls.Add(Me.ucHoraInicio)
        Me.groupProgramacao.Controls.Add(Me.ucPrograma)
        Me.groupProgramacao.Location = New System.Drawing.Point(467, 13)
        Me.groupProgramacao.Name = "groupProgramacao"
        Me.groupProgramacao.Size = New System.Drawing.Size(384, 146)
        Me.groupProgramacao.TabIndex = 1
        Me.groupProgramacao.TabStop = False
        Me.groupProgramacao.Text = "Programação"
        '
        'btnPrograma
        '
        Me.btnPrograma.BackgroundImage = Global.SCTVNET.My.Resources.Resources.Search
        Me.btnPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrograma.Location = New System.Drawing.Point(331, 19)
        Me.btnPrograma.Name = "btnPrograma"
        Me.btnPrograma.Size = New System.Drawing.Size(27, 24)
        Me.btnPrograma.TabIndex = 7
        Me.btnPrograma.TabStop = False
        Me.btnPrograma.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Faixa Horária"
        '
        'cboFaixaHoraria
        '
        Me.cboFaixaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFaixaHoraria.FormattingEnabled = True
        Me.cboFaixaHoraria.Location = New System.Drawing.Point(88, 83)
        Me.cboFaixaHoraria.Name = "cboFaixaHoraria"
        Me.cboFaixaHoraria.Size = New System.Drawing.Size(270, 21)
        Me.cboFaixaHoraria.TabIndex = 5
        '
        'GroupPropagar
        '
        Me.GroupPropagar.Controls.Add(Me.chkSab)
        Me.GroupPropagar.Controls.Add(Me.chkTodos)
        Me.GroupPropagar.Controls.Add(Me.chkSex)
        Me.GroupPropagar.Controls.Add(Me.chkQui)
        Me.GroupPropagar.Controls.Add(Me.chkQua)
        Me.GroupPropagar.Controls.Add(Me.chkTer)
        Me.GroupPropagar.Controls.Add(Me.chkSeg)
        Me.GroupPropagar.Controls.Add(Me.chkDom)
        Me.GroupPropagar.Controls.Add(Me.ucPropagarAte)
        Me.GroupPropagar.Controls.Add(Me.ucPropagarDE)
        Me.GroupPropagar.Location = New System.Drawing.Point(467, 175)
        Me.GroupPropagar.Name = "GroupPropagar"
        Me.GroupPropagar.Size = New System.Drawing.Size(384, 121)
        Me.GroupPropagar.TabIndex = 2
        Me.GroupPropagar.TabStop = False
        Me.GroupPropagar.Text = "Propagar"
        '
        'chkSab
        '
        Me.chkSab.AutoSize = True
        Me.chkSab.Location = New System.Drawing.Point(241, 59)
        Me.chkSab.Name = "chkSab"
        Me.chkSab.Size = New System.Drawing.Size(45, 17)
        Me.chkSab.TabIndex = 8
        Me.chkSab.Text = "Sab"
        Me.chkSab.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(241, 79)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 9
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'chkSex
        '
        Me.chkSex.AutoSize = True
        Me.chkSex.Location = New System.Drawing.Point(241, 39)
        Me.chkSex.Name = "chkSex"
        Me.chkSex.Size = New System.Drawing.Size(44, 17)
        Me.chkSex.TabIndex = 7
        Me.chkSex.Text = "Sex"
        Me.chkSex.UseVisualStyleBackColor = True
        '
        'chkQui
        '
        Me.chkQui.AutoSize = True
        Me.chkQui.Location = New System.Drawing.Point(241, 19)
        Me.chkQui.Name = "chkQui"
        Me.chkQui.Size = New System.Drawing.Size(42, 17)
        Me.chkQui.TabIndex = 6
        Me.chkQui.Text = "Qui"
        Me.chkQui.UseVisualStyleBackColor = True
        '
        'chkQua
        '
        Me.chkQua.AutoSize = True
        Me.chkQua.Location = New System.Drawing.Point(145, 79)
        Me.chkQua.Name = "chkQua"
        Me.chkQua.Size = New System.Drawing.Size(46, 17)
        Me.chkQua.TabIndex = 5
        Me.chkQua.Text = "Qua"
        Me.chkQua.UseVisualStyleBackColor = True
        '
        'chkTer
        '
        Me.chkTer.AutoSize = True
        Me.chkTer.Location = New System.Drawing.Point(145, 59)
        Me.chkTer.Name = "chkTer"
        Me.chkTer.Size = New System.Drawing.Size(42, 17)
        Me.chkTer.TabIndex = 4
        Me.chkTer.Text = "Ter"
        Me.chkTer.UseVisualStyleBackColor = True
        '
        'chkSeg
        '
        Me.chkSeg.AutoSize = True
        Me.chkSeg.Location = New System.Drawing.Point(145, 39)
        Me.chkSeg.Name = "chkSeg"
        Me.chkSeg.Size = New System.Drawing.Size(45, 17)
        Me.chkSeg.TabIndex = 3
        Me.chkSeg.Text = "Seg"
        Me.chkSeg.UseVisualStyleBackColor = True
        '
        'chkDom
        '
        Me.chkDom.AutoSize = True
        Me.chkDom.Location = New System.Drawing.Point(145, 19)
        Me.chkDom.Name = "chkDom"
        Me.chkDom.Size = New System.Drawing.Size(48, 17)
        Me.chkDom.TabIndex = 2
        Me.chkDom.Text = "Dom"
        Me.chkDom.UseVisualStyleBackColor = True
        '
        'groupResumo
        '
        Me.groupResumo.Controls.Add(Me.gridCritica)
        Me.groupResumo.Location = New System.Drawing.Point(13, 302)
        Me.groupResumo.Name = "groupResumo"
        Me.groupResumo.Size = New System.Drawing.Size(838, 230)
        Me.groupResumo.TabIndex = 4
        Me.groupResumo.TabStop = False
        Me.groupResumo.Text = "Ocorrências da Gravação"
        '
        'gridCritica
        '
        Me.gridCritica.BackgroundColor = System.Drawing.Color.White
        Me.gridCritica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCritica.Location = New System.Drawing.Point(6, 19)
        Me.gridCritica.Name = "gridCritica"
        Me.gridCritica.Size = New System.Drawing.Size(826, 205)
        Me.gridCritica.TabIndex = 1
        '
        'ucPropagarAte
        '
        Me.ucPropagarAte.BackColor = System.Drawing.SystemColors.Control
        Me.ucPropagarAte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPropagarAte.Caption = "Até"
        Me.ucPropagarAte.DataTextValue = Nothing
        Me.ucPropagarAte.Location = New System.Drawing.Point(16, 60)
        Me.ucPropagarAte.MaxLength = 10
        Me.ucPropagarAte.Name = "ucPropagarAte"
        Me.ucPropagarAte.Obrigatorio = True
        Me.ucPropagarAte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPropagarAte.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPropagarAte.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPropagarAte.pDecimal = CType(0, Byte)
        Me.ucPropagarAte.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucPropagarAte.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.ucPropagarAte.Size = New System.Drawing.Size(111, 25)
        Me.ucPropagarAte.TabIndex = 1
        Me.ucPropagarAte.TextBoxLeft = CType(0, Short)
        Me.ucPropagarAte.TextWidth = 0
        '
        'ucPropagarDE
        '
        Me.ucPropagarDE.BackColor = System.Drawing.SystemColors.Control
        Me.ucPropagarDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPropagarDE.Caption = "De"
        Me.ucPropagarDE.DataTextValue = Nothing
        Me.ucPropagarDE.Location = New System.Drawing.Point(16, 19)
        Me.ucPropagarDE.MaxLength = 10
        Me.ucPropagarDE.Name = "ucPropagarDE"
        Me.ucPropagarDE.Obrigatorio = True
        Me.ucPropagarDE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPropagarDE.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPropagarDE.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPropagarDE.pDecimal = CType(0, Byte)
        Me.ucPropagarDE.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucPropagarDE.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.ucPropagarDE.Size = New System.Drawing.Size(111, 25)
        Me.ucPropagarDE.TabIndex = 0
        Me.ucPropagarDE.TextBoxLeft = CType(0, Short)
        Me.ucPropagarDE.TextWidth = 0
        '
        'btnGrade
        '
        Me.btnGrade.BackColor = System.Drawing.SystemColors.Control
        Me.btnGrade.Location = New System.Drawing.Point(672, 538)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(179, 38)
        Me.btnGrade.TabIndex = 3
        '
        'ucDisponibilidade
        '
        Me.ucDisponibilidade.BackColor = System.Drawing.SystemColors.Control
        Me.ucDisponibilidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucDisponibilidade.Caption = "Disponibilidade Local"
        Me.ucDisponibilidade.DataTextValue = Nothing
        Me.ucDisponibilidade.Location = New System.Drawing.Point(6, 115)
        Me.ucDisponibilidade.MaxLength = 5
        Me.ucDisponibilidade.Name = "ucDisponibilidade"
        Me.ucDisponibilidade.Obrigatorio = True
        Me.ucDisponibilidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucDisponibilidade.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucDisponibilidade.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucDisponibilidade.pDecimal = CType(0, Byte)
        Me.ucDisponibilidade.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucDisponibilidade.pFormatoSaida = WUC.UcText.FormatoSaida.Numero
        Me.ucDisponibilidade.Size = New System.Drawing.Size(228, 25)
        Me.ucDisponibilidade.TabIndex = 6
        Me.ucDisponibilidade.TextBoxLeft = CType(0, Short)
        Me.ucDisponibilidade.TextWidth = 0
        '
        'ucHoraTermino
        '
        Me.ucHoraTermino.BackColor = System.Drawing.SystemColors.Control
        Me.ucHoraTermino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucHoraTermino.Caption = "Hora Término"
        Me.ucHoraTermino.DataTextValue = Nothing
        Me.ucHoraTermino.Location = New System.Drawing.Point(196, 49)
        Me.ucHoraTermino.MaxLength = 5
        Me.ucHoraTermino.Name = "ucHoraTermino"
        Me.ucHoraTermino.Obrigatorio = True
        Me.ucHoraTermino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucHoraTermino.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucHoraTermino.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucHoraTermino.pDecimal = CType(0, Byte)
        Me.ucHoraTermino.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucHoraTermino.pFormatoSaida = WUC.UcText.FormatoSaida.Hora
        Me.ucHoraTermino.Size = New System.Drawing.Size(162, 25)
        Me.ucHoraTermino.TabIndex = 3
        Me.ucHoraTermino.TextBoxLeft = CType(90, Short)
        Me.ucHoraTermino.TextWidth = 0
        '
        'ucHoraInicio
        '
        Me.ucHoraInicio.BackColor = System.Drawing.SystemColors.Control
        Me.ucHoraInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucHoraInicio.Caption = "Hora Inicio"
        Me.ucHoraInicio.DataTextValue = Nothing
        Me.ucHoraInicio.Location = New System.Drawing.Point(6, 51)
        Me.ucHoraInicio.MaxLength = 5
        Me.ucHoraInicio.Name = "ucHoraInicio"
        Me.ucHoraInicio.Obrigatorio = True
        Me.ucHoraInicio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucHoraInicio.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucHoraInicio.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucHoraInicio.pDecimal = CType(0, Byte)
        Me.ucHoraInicio.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.ucHoraInicio.pFormatoSaida = WUC.UcText.FormatoSaida.Hora
        Me.ucHoraInicio.Size = New System.Drawing.Size(143, 25)
        Me.ucHoraInicio.TabIndex = 2
        Me.ucHoraInicio.TextBoxLeft = CType(80, Short)
        Me.ucHoraInicio.TextWidth = 0
        '
        'ucPrograma
        '
        Me.ucPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.ucPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ucPrograma.Caption = "Programa"
        Me.ucPrograma.DataTextValue = Nothing
        Me.ucPrograma.Location = New System.Drawing.Point(6, 19)
        Me.ucPrograma.MaxLength = 4
        Me.ucPrograma.Name = "ucPrograma"
        Me.ucPrograma.Obrigatorio = True
        Me.ucPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ucPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.ucPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.ucPrograma.pDecimal = CType(0, Byte)
        Me.ucPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.ucPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.ucPrograma.showButton = True
        Me.ucPrograma.ShowDescricao = True
        Me.ucPrograma.Size = New System.Drawing.Size(352, 25)
        Me.ucPrograma.TabIndex = 1
        Me.ucPrograma.TextBoxLeft = CType(80, Short)
        Me.ucPrograma.TextWidth = 0
        '
        'frmGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 583)
        Me.Controls.Add(Me.groupResumo)
        Me.Controls.Add(Me.GroupPropagar)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.groupProgramacao)
        Me.Controls.Add(Me.groupVeiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmGrade"
        Me.Text = "Manutenção da Grade da Programação"
        Me.groupVeiculo.ResumeLayout(False)
        CType(Me.gridVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupProgramacao.ResumeLayout(False)
        Me.groupProgramacao.PerformLayout()
        Me.GroupPropagar.ResumeLayout(False)
        Me.GroupPropagar.PerformLayout()
        Me.groupResumo.ResumeLayout(False)
        CType(Me.gridCritica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupVeiculo As System.Windows.Forms.GroupBox
    Friend WithEvents gridVeiculo As System.Windows.Forms.DataGridView
    Friend WithEvents groupProgramacao As System.Windows.Forms.GroupBox
    Friend WithEvents ucHoraInicio As WUC.UcText
    Friend WithEvents ucPrograma As WUC.UcText
    Friend WithEvents ucDisponibilidade As WUC.UcText
    Friend WithEvents ucHoraTermino As WUC.UcText
    Friend WithEvents btnGrade As WUC.ucButton
    Friend WithEvents GroupPropagar As System.Windows.Forms.GroupBox
    Friend WithEvents chkSab As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents chkSex As System.Windows.Forms.CheckBox
    Friend WithEvents chkQui As System.Windows.Forms.CheckBox
    Friend WithEvents chkQua As System.Windows.Forms.CheckBox
    Friend WithEvents chkTer As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeg As System.Windows.Forms.CheckBox
    Friend WithEvents chkDom As System.Windows.Forms.CheckBox
    Friend WithEvents ucPropagarAte As WUC.UcText
    Friend WithEvents ucPropagarDE As WUC.UcText
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboFaixaHoraria As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrograma As System.Windows.Forms.Button
    Friend WithEvents groupResumo As System.Windows.Forms.GroupBox
    Friend WithEvents gridCritica As System.Windows.Forms.DataGridView
End Class
