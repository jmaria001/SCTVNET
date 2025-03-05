<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprogramacaoprevista
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
        Me.GrpGeral = New System.Windows.Forms.GroupBox
        Me.txtPrograma = New System.Windows.Forms.Label
        Me.txtData = New System.Windows.Forms.Label
        Me.txtVeiculo = New System.Windows.Forms.Label
        Me.dgvConsultaPrevista = New System.Windows.Forms.DataGridView
        Me.lblPrograma = New System.Windows.Forms.Label
        Me.lblData = New System.Windows.Forms.Label
        Me.LblVeiculo = New System.Windows.Forms.Label
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.btnRetornar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.picAbsorve = New System.Windows.Forms.PictureBox
        Me.picNaoAbsorve = New System.Windows.Forms.PictureBox
        Me.picFalha = New System.Windows.Forms.PictureBox
        Me.lblAguardando = New System.Windows.Forms.Label
        Me.picAguardando = New System.Windows.Forms.PictureBox
        Me.txtAbsorveEspaco = New System.Windows.Forms.Label
        Me.txtNaoAbsorveEspaco = New System.Windows.Forms.Label
        Me.txtFalhas = New System.Windows.Forms.Label
        Me.txtAguardandoAprovacao = New System.Windows.Forms.Label
        Me.picGol = New System.Windows.Forms.PictureBox
        Me.lblGol = New System.Windows.Forms.Label
        Me.txtGol = New System.Windows.Forms.Label
        Me.GrpGeral.SuspendLayout()
        CType(Me.dgvConsultaPrevista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAbsorve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNaoAbsorve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFalha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAguardando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpGeral
        '
        Me.GrpGeral.Controls.Add(Me.txtPrograma)
        Me.GrpGeral.Controls.Add(Me.txtData)
        Me.GrpGeral.Controls.Add(Me.txtVeiculo)
        Me.GrpGeral.Controls.Add(Me.dgvConsultaPrevista)
        Me.GrpGeral.Controls.Add(Me.lblPrograma)
        Me.GrpGeral.Controls.Add(Me.lblData)
        Me.GrpGeral.Controls.Add(Me.LblVeiculo)
        Me.GrpGeral.Location = New System.Drawing.Point(12, 12)
        Me.GrpGeral.Name = "GrpGeral"
        Me.GrpGeral.Size = New System.Drawing.Size(916, 444)
        Me.GrpGeral.TabIndex = 0
        Me.GrpGeral.TabStop = False
        '
        'txtPrograma
        '
        Me.txtPrograma.BackColor = System.Drawing.Color.White
        Me.txtPrograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrograma.Location = New System.Drawing.Point(525, 13)
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.Size = New System.Drawing.Size(385, 20)
        Me.txtPrograma.TabIndex = 11
        Me.txtPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtData
        '
        Me.txtData.BackColor = System.Drawing.Color.White
        Me.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData.Location = New System.Drawing.Point(360, 13)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(101, 20)
        Me.txtData.TabIndex = 10
        Me.txtData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVeiculo
        '
        Me.txtVeiculo.BackColor = System.Drawing.Color.White
        Me.txtVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVeiculo.Location = New System.Drawing.Point(54, 13)
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Size = New System.Drawing.Size(266, 20)
        Me.txtVeiculo.TabIndex = 9
        Me.txtVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvConsultaPrevista
        '
        Me.dgvConsultaPrevista.BackgroundColor = System.Drawing.Color.White
        Me.dgvConsultaPrevista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaPrevista.Location = New System.Drawing.Point(9, 39)
        Me.dgvConsultaPrevista.Name = "dgvConsultaPrevista"
        Me.dgvConsultaPrevista.Size = New System.Drawing.Size(901, 391)
        Me.dgvConsultaPrevista.TabIndex = 8
        '
        'lblPrograma
        '
        Me.lblPrograma.AutoSize = True
        Me.lblPrograma.Location = New System.Drawing.Point(467, 16)
        Me.lblPrograma.Name = "lblPrograma"
        Me.lblPrograma.Size = New System.Drawing.Size(52, 13)
        Me.lblPrograma.TabIndex = 2
        Me.lblPrograma.Text = "Programa"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(324, 16)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "Data"
        '
        'LblVeiculo
        '
        Me.LblVeiculo.AutoSize = True
        Me.LblVeiculo.Location = New System.Drawing.Point(6, 16)
        Me.LblVeiculo.Name = "LblVeiculo"
        Me.LblVeiculo.Size = New System.Drawing.Size(42, 13)
        Me.LblVeiculo.TabIndex = 0
        Me.LblVeiculo.Text = "Veiculo"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(832, 480)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(71, 20)
        Me.txtTipo.TabIndex = 7
        Me.txtTipo.Visible = False
        '
        'btnRetornar
        '
        Me.btnRetornar.Location = New System.Drawing.Point(832, 506)
        Me.btnRetornar.Name = "btnRetornar"
        Me.btnRetornar.Size = New System.Drawing.Size(90, 34)
        Me.btnRetornar.TabIndex = 9
        Me.btnRetornar.Text = "Retornar"
        Me.btnRetornar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 469)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Comerciais que Absorvem Espaço."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Comerciais que Não Absorvem Espaço."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Falhas"
        '
        'picAbsorve
        '
        Me.picAbsorve.BackColor = System.Drawing.Color.Blue
        Me.picAbsorve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAbsorve.Location = New System.Drawing.Point(17, 469)
        Me.picAbsorve.Name = "picAbsorve"
        Me.picAbsorve.Size = New System.Drawing.Size(15, 13)
        Me.picAbsorve.TabIndex = 16
        Me.picAbsorve.TabStop = False
        '
        'picNaoAbsorve
        '
        Me.picNaoAbsorve.BackColor = System.Drawing.Color.Red
        Me.picNaoAbsorve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picNaoAbsorve.Location = New System.Drawing.Point(17, 491)
        Me.picNaoAbsorve.Name = "picNaoAbsorve"
        Me.picNaoAbsorve.Size = New System.Drawing.Size(15, 13)
        Me.picNaoAbsorve.TabIndex = 17
        Me.picNaoAbsorve.TabStop = False
        '
        'picFalha
        '
        Me.picFalha.BackColor = System.Drawing.Color.Black
        Me.picFalha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFalha.Location = New System.Drawing.Point(366, 466)
        Me.picFalha.Name = "picFalha"
        Me.picFalha.Size = New System.Drawing.Size(15, 13)
        Me.picFalha.TabIndex = 18
        Me.picFalha.TabStop = False
        '
        'lblAguardando
        '
        Me.lblAguardando.AutoSize = True
        Me.lblAguardando.Location = New System.Drawing.Point(392, 491)
        Me.lblAguardando.Name = "lblAguardando"
        Me.lblAguardando.Size = New System.Drawing.Size(239, 13)
        Me.lblAguardando.TabIndex = 12
        Me.lblAguardando.Text = "Aguardando Aprovação para Invasão de Espaço"
        Me.lblAguardando.Visible = False
        '
        'picAguardando
        '
        Me.picAguardando.BackColor = System.Drawing.Color.Fuchsia
        Me.picAguardando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAguardando.Location = New System.Drawing.Point(366, 491)
        Me.picAguardando.Name = "picAguardando"
        Me.picAguardando.Size = New System.Drawing.Size(15, 13)
        Me.picAguardando.TabIndex = 19
        Me.picAguardando.TabStop = False
        Me.picAguardando.Visible = False
        '
        'txtAbsorveEspaco
        '
        Me.txtAbsorveEspaco.BackColor = System.Drawing.Color.White
        Me.txtAbsorveEspaco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbsorveEspaco.Location = New System.Drawing.Point(285, 462)
        Me.txtAbsorveEspaco.Name = "txtAbsorveEspaco"
        Me.txtAbsorveEspaco.Size = New System.Drawing.Size(54, 20)
        Me.txtAbsorveEspaco.TabIndex = 23
        Me.txtAbsorveEspaco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNaoAbsorveEspaco
        '
        Me.txtNaoAbsorveEspaco.BackColor = System.Drawing.Color.White
        Me.txtNaoAbsorveEspaco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNaoAbsorveEspaco.Location = New System.Drawing.Point(285, 487)
        Me.txtNaoAbsorveEspaco.Name = "txtNaoAbsorveEspaco"
        Me.txtNaoAbsorveEspaco.Size = New System.Drawing.Size(54, 20)
        Me.txtNaoAbsorveEspaco.TabIndex = 24
        Me.txtNaoAbsorveEspaco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFalhas
        '
        Me.txtFalhas.BackColor = System.Drawing.Color.White
        Me.txtFalhas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFalhas.Location = New System.Drawing.Point(637, 462)
        Me.txtFalhas.Name = "txtFalhas"
        Me.txtFalhas.Size = New System.Drawing.Size(54, 20)
        Me.txtFalhas.TabIndex = 25
        Me.txtFalhas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAguardandoAprovacao
        '
        Me.txtAguardandoAprovacao.BackColor = System.Drawing.Color.White
        Me.txtAguardandoAprovacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAguardandoAprovacao.Location = New System.Drawing.Point(637, 487)
        Me.txtAguardandoAprovacao.Name = "txtAguardandoAprovacao"
        Me.txtAguardandoAprovacao.Size = New System.Drawing.Size(54, 20)
        Me.txtAguardandoAprovacao.TabIndex = 26
        Me.txtAguardandoAprovacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtAguardandoAprovacao.Visible = False
        '
        'picGol
        '
        Me.picGol.BackColor = System.Drawing.Color.Purple
        Me.picGol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGol.Location = New System.Drawing.Point(17, 513)
        Me.picGol.Name = "picGol"
        Me.picGol.Size = New System.Drawing.Size(15, 13)
        Me.picGol.TabIndex = 28
        Me.picGol.TabStop = False
        '
        'lblGol
        '
        Me.lblGol.AutoSize = True
        Me.lblGol.Location = New System.Drawing.Point(43, 513)
        Me.lblGol.Name = "lblGol"
        Me.lblGol.Size = New System.Drawing.Size(239, 13)
        Me.lblGol.TabIndex = 27
        Me.lblGol.Text = "GOL (Valor Referência = Valor Negociado  Bruto)"
        '
        'txtGol
        '
        Me.txtGol.BackColor = System.Drawing.Color.White
        Me.txtGol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGol.Location = New System.Drawing.Point(285, 512)
        Me.txtGol.Name = "txtGol"
        Me.txtGol.Size = New System.Drawing.Size(54, 20)
        Me.txtGol.TabIndex = 29
        Me.txtGol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmprogramacaoprevista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 548)
        Me.Controls.Add(Me.txtGol)
        Me.Controls.Add(Me.picGol)
        Me.Controls.Add(Me.lblGol)
        Me.Controls.Add(Me.txtAguardandoAprovacao)
        Me.Controls.Add(Me.txtFalhas)
        Me.Controls.Add(Me.txtNaoAbsorveEspaco)
        Me.Controls.Add(Me.txtAbsorveEspaco)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.picAguardando)
        Me.Controls.Add(Me.picFalha)
        Me.Controls.Add(Me.picNaoAbsorve)
        Me.Controls.Add(Me.picAbsorve)
        Me.Controls.Add(Me.lblAguardando)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRetornar)
        Me.Controls.Add(Me.GrpGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "frmprogramacaoprevista"
        Me.Text = "Dados das Veiculações"
        Me.GrpGeral.ResumeLayout(False)
        Me.GrpGeral.PerformLayout()
        CType(Me.dgvConsultaPrevista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAbsorve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNaoAbsorve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFalha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAguardando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpGeral As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrograma As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents LblVeiculo As System.Windows.Forms.Label
    Friend WithEvents btnRetornar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picAbsorve As System.Windows.Forms.PictureBox
    Friend WithEvents picNaoAbsorve As System.Windows.Forms.PictureBox
    Friend WithEvents picFalha As System.Windows.Forms.PictureBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblAguardando As System.Windows.Forms.Label
    Friend WithEvents picAguardando As System.Windows.Forms.PictureBox
    Friend WithEvents dgvConsultaPrevista As System.Windows.Forms.DataGridView
    Friend WithEvents txtVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtPrograma As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents txtAbsorveEspaco As System.Windows.Forms.Label
    Friend WithEvents txtNaoAbsorveEspaco As System.Windows.Forms.Label
    Friend WithEvents txtFalhas As System.Windows.Forms.Label
    Friend WithEvents txtAguardandoAprovacao As System.Windows.Forms.Label
    Friend WithEvents picGol As System.Windows.Forms.PictureBox
    Friend WithEvents lblGol As System.Windows.Forms.Label
    Friend WithEvents txtGol As System.Windows.Forms.Label
End Class
