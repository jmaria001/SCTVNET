<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixaRoteiro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDesmarcar = New System.Windows.Forms.Button
        Me.btnMarcar = New System.Windows.Forms.Button
        Me.dgvBaixaRoteiro = New System.Windows.Forms.DataGridView
        Me.grp1 = New System.Windows.Forms.GroupBox
        Me.bnnOkCancel = New WUC.ucButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.chkDomingo = New System.Windows.Forms.CheckBox
        Me.chkQuarta = New System.Windows.Forms.CheckBox
        Me.chkTerca = New System.Windows.Forms.CheckBox
        Me.chkSexta = New System.Windows.Forms.CheckBox
        Me.chkSabado = New System.Windows.Forms.CheckBox
        Me.chkSegunda = New System.Windows.Forms.CheckBox
        Me.chkQuinta = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtDataAte = New WUC.UcText
        Me.TxtDatade = New WUC.UcText
        Me.txtQualidade = New WUC.UcText
        Me.txtTipoComercial = New WUC.UcText
        Me.txtPrograma = New WUC.UcText
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBaixaRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDesmarcar)
        Me.GroupBox1.Controls.Add(Me.btnMarcar)
        Me.GroupBox1.Controls.Add(Me.dgvBaixaRoteiro)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 427)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veículos"
        '
        'btnDesmarcar
        '
        Me.btnDesmarcar.Location = New System.Drawing.Point(180, 391)
        Me.btnDesmarcar.Name = "btnDesmarcar"
        Me.btnDesmarcar.Size = New System.Drawing.Size(168, 30)
        Me.btnDesmarcar.TabIndex = 2
        Me.btnDesmarcar.Text = "Desmarcar Todos"
        Me.btnDesmarcar.UseVisualStyleBackColor = True
        '
        'btnMarcar
        '
        Me.btnMarcar.Location = New System.Drawing.Point(9, 391)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(168, 30)
        Me.btnMarcar.TabIndex = 1
        Me.btnMarcar.Text = "Marcar Todos"
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'dgvBaixaRoteiro
        '
        Me.dgvBaixaRoteiro.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBaixaRoteiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaixaRoteiro.Location = New System.Drawing.Point(9, 19)
        Me.dgvBaixaRoteiro.Name = "dgvBaixaRoteiro"
        Me.dgvBaixaRoteiro.Size = New System.Drawing.Size(434, 366)
        Me.dgvBaixaRoteiro.TabIndex = 0
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.bnnOkCancel)
        Me.grp1.Controls.Add(Me.GroupBox4)
        Me.grp1.Controls.Add(Me.GroupBox3)
        Me.grp1.Controls.Add(Me.txtQualidade)
        Me.grp1.Controls.Add(Me.txtTipoComercial)
        Me.grp1.Controls.Add(Me.txtPrograma)
        Me.grp1.Location = New System.Drawing.Point(467, 12)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(347, 427)
        Me.grp1.TabIndex = 1
        Me.grp1.TabStop = False
        Me.grp1.Text = " Baixa\Filtro para Baixa"
        '
        'bnnOkCancel
        '
        Me.bnnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.bnnOkCancel.Location = New System.Drawing.Point(148, 383)
        Me.bnnOkCancel.Name = "bnnOkCancel"
        Me.bnnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.bnnOkCancel.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkTodos)
        Me.GroupBox4.Controls.Add(Me.chkDomingo)
        Me.GroupBox4.Controls.Add(Me.chkQuarta)
        Me.GroupBox4.Controls.Add(Me.chkTerca)
        Me.GroupBox4.Controls.Add(Me.chkSexta)
        Me.GroupBox4.Controls.Add(Me.chkSabado)
        Me.GroupBox4.Controls.Add(Me.chkSegunda)
        Me.GroupBox4.Controls.Add(Me.chkQuinta)
        Me.GroupBox4.Location = New System.Drawing.Point(148, 178)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(173, 134)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dias da Semana "
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(89, 95)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 13
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = True
        Me.chkDomingo.Location = New System.Drawing.Point(15, 23)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(68, 17)
        Me.chkDomingo.TabIndex = 6
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = True
        '
        'chkQuarta
        '
        Me.chkQuarta.AutoSize = True
        Me.chkQuarta.Location = New System.Drawing.Point(89, 46)
        Me.chkQuarta.Name = "chkQuarta"
        Me.chkQuarta.Size = New System.Drawing.Size(58, 17)
        Me.chkQuarta.TabIndex = 7
        Me.chkQuarta.Text = "Quarta"
        Me.chkQuarta.UseVisualStyleBackColor = True
        '
        'chkTerca
        '
        Me.chkTerca.AutoSize = True
        Me.chkTerca.Location = New System.Drawing.Point(15, 46)
        Me.chkTerca.Name = "chkTerca"
        Me.chkTerca.Size = New System.Drawing.Size(54, 17)
        Me.chkTerca.TabIndex = 12
        Me.chkTerca.Text = "Terça"
        Me.chkTerca.UseVisualStyleBackColor = True
        '
        'chkSexta
        '
        Me.chkSexta.AutoSize = True
        Me.chkSexta.Location = New System.Drawing.Point(89, 72)
        Me.chkSexta.Name = "chkSexta"
        Me.chkSexta.Size = New System.Drawing.Size(53, 17)
        Me.chkSexta.TabIndex = 8
        Me.chkSexta.Text = "Sexta"
        Me.chkSexta.UseVisualStyleBackColor = True
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = True
        Me.chkSabado.Location = New System.Drawing.Point(15, 95)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 17)
        Me.chkSabado.TabIndex = 11
        Me.chkSabado.Text = "Sabado"
        Me.chkSabado.UseVisualStyleBackColor = True
        '
        'chkSegunda
        '
        Me.chkSegunda.AutoSize = True
        Me.chkSegunda.Location = New System.Drawing.Point(89, 23)
        Me.chkSegunda.Name = "chkSegunda"
        Me.chkSegunda.Size = New System.Drawing.Size(69, 17)
        Me.chkSegunda.TabIndex = 9
        Me.chkSegunda.Text = "Segunda"
        Me.chkSegunda.UseVisualStyleBackColor = True
        '
        'chkQuinta
        '
        Me.chkQuinta.AutoSize = True
        Me.chkQuinta.Location = New System.Drawing.Point(15, 72)
        Me.chkQuinta.Name = "chkQuinta"
        Me.chkQuinta.Size = New System.Drawing.Size(57, 17)
        Me.chkQuinta.TabIndex = 10
        Me.chkQuinta.Text = "Quinta"
        Me.chkQuinta.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtDataAte)
        Me.GroupBox3.Controls.Add(Me.TxtDatade)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 134)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Periodo "
        '
        'TxtDataAte
        '
        Me.TxtDataAte.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDataAte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtDataAte.Caption = "Até:"
        Me.TxtDataAte.DataTextValue = Nothing
        Me.TxtDataAte.Location = New System.Drawing.Point(6, 67)
        Me.TxtDataAte.MaxLength = 10
        Me.TxtDataAte.Name = "TxtDataAte"
        Me.TxtDataAte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDataAte.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtDataAte.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtDataAte.pDecimal = CType(0, Byte)
        Me.TxtDataAte.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtDataAte.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.TxtDataAte.Size = New System.Drawing.Size(93, 37)
        Me.TxtDataAte.sqlQuery = Nothing
        Me.TxtDataAte.TabIndex = 4
        Me.TxtDataAte.TextBoxLeft = CType(0, Short)
        Me.TxtDataAte.TextWidth = 0
        '
        'TxtDatade
        '
        Me.TxtDatade.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDatade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TxtDatade.Caption = "De:"
        Me.TxtDatade.DataTextValue = Nothing
        Me.TxtDatade.Location = New System.Drawing.Point(6, 18)
        Me.TxtDatade.MaxLength = 10
        Me.TxtDatade.Name = "TxtDatade"
        Me.TxtDatade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDatade.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.TxtDatade.pCaseformato = WUC.UcText.CaseFormato.Normal
        Me.TxtDatade.pDecimal = CType(0, Byte)
        Me.TxtDatade.pDicionario = WUC.clsDicionario.enuDicionario.Nenhum
        Me.TxtDatade.pFormatoSaida = WUC.UcText.FormatoSaida.Data
        Me.TxtDatade.Size = New System.Drawing.Size(93, 37)
        Me.TxtDatade.sqlQuery = Nothing
        Me.TxtDatade.TabIndex = 3
        Me.TxtDatade.TextBoxLeft = CType(0, Short)
        Me.TxtDatade.TextWidth = 0
        '
        'txtQualidade
        '
        Me.txtQualidade.BackColor = System.Drawing.SystemColors.Control
        Me.txtQualidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtQualidade.Caption = "Qualidade"
        Me.txtQualidade.DataTextValue = Nothing
        Me.txtQualidade.Location = New System.Drawing.Point(6, 116)
        Me.txtQualidade.MaxLength = 3
        Me.txtQualidade.Name = "txtQualidade"
        Me.txtQualidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQualidade.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtQualidade.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtQualidade.pDecimal = CType(0, Byte)
        Me.txtQualidade.pDicionario = WUC.clsDicionario.enuDicionario.Qualidade
        Me.txtQualidade.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtQualidade.showButton = True
        Me.txtQualidade.ShowDescricao = True
        Me.txtQualidade.Size = New System.Drawing.Size(321, 37)
        Me.txtQualidade.sqlQuery = "execute PrNet_Qualidade_L"
        Me.txtQualidade.TabIndex = 2
        Me.txtQualidade.TextBoxLeft = CType(0, Short)
        Me.txtQualidade.TextWidth = 0
        '
        'txtTipoComercial
        '
        Me.txtTipoComercial.BackColor = System.Drawing.SystemColors.Control
        Me.txtTipoComercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtTipoComercial.Caption = "Tipo de Comercial"
        Me.txtTipoComercial.DataTextValue = Nothing
        Me.txtTipoComercial.Location = New System.Drawing.Point(6, 73)
        Me.txtTipoComercial.MaxLength = 2
        Me.txtTipoComercial.Name = "txtTipoComercial"
        Me.txtTipoComercial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoComercial.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtTipoComercial.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtTipoComercial.pDecimal = CType(0, Byte)
        Me.txtTipoComercial.pDicionario = WUC.clsDicionario.enuDicionario.Tipo_Comercial
        Me.txtTipoComercial.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtTipoComercial.showButton = True
        Me.txtTipoComercial.ShowDescricao = True
        Me.txtTipoComercial.Size = New System.Drawing.Size(321, 37)
        Me.txtTipoComercial.sqlQuery = "Execute prNet_Tipo_Comercial_L"
        Me.txtTipoComercial.TabIndex = 1
        Me.txtTipoComercial.TextBoxLeft = CType(0, Short)
        Me.txtTipoComercial.TextWidth = 0
        '
        'txtPrograma
        '
        Me.txtPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.txtPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtPrograma.Caption = "Programa"
        Me.txtPrograma.DataTextValue = Nothing
        Me.txtPrograma.Location = New System.Drawing.Point(6, 30)
        Me.txtPrograma.MaxLength = 4
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrograma.pCaptionPosition = WUC.UcText.CaptionPosition.Top
        Me.txtPrograma.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.txtPrograma.pDecimal = CType(0, Byte)
        Me.txtPrograma.pDicionario = WUC.clsDicionario.enuDicionario.Programa_Codigo
        Me.txtPrograma.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.txtPrograma.showButton = True
        Me.txtPrograma.ShowDescricao = True
        Me.txtPrograma.Size = New System.Drawing.Size(321, 37)
        Me.txtPrograma.sqlQuery = "Execute prNet_Programa_L"
        Me.txtPrograma.TabIndex = 0
        Me.txtPrograma.TextBoxLeft = CType(0, Short)
        Me.txtPrograma.TextWidth = 0
        '
        'frmBaixaRoteiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(826, 459)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBaixaRoteiro"
        Me.Text = "Baixa por Roteiro"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvBaixaRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBaixaRoteiro As System.Windows.Forms.DataGridView
    Friend WithEvents btnDesmarcar As System.Windows.Forms.Button
    Friend WithEvents btnMarcar As System.Windows.Forms.Button
    Friend WithEvents txtPrograma As WUC.UcText
    Friend WithEvents txtQualidade As WUC.UcText
    Friend WithEvents txtTipoComercial As WUC.UcText
    Friend WithEvents TxtDataAte As WUC.UcText
    Friend WithEvents TxtDatade As WUC.UcText
    Friend WithEvents chkQuarta As System.Windows.Forms.CheckBox
    Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents chkTerca As System.Windows.Forms.CheckBox
    Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
    Friend WithEvents chkQuinta As System.Windows.Forms.CheckBox
    Friend WithEvents chkSegunda As System.Windows.Forms.CheckBox
    Friend WithEvents chkSexta As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bnnOkCancel As WUC.ucButton
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
End Class
