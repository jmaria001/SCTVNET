<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.UcText1 = New WUC.UcText
        Me.SuspendLayout()
        '
        'UcText1
        '
        Me.UcText1.BackColor = System.Drawing.SystemColors.Control
        Me.UcText1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UcText1.Caption = "Código"
        Me.UcText1.DataNumberValue = 0
        Me.UcText1.DataTextValue = Nothing
        Me.UcText1.Location = New System.Drawing.Point(9, 18)
        Me.UcText1.MaxLength = 6
        Me.UcText1.Name = "UcText1"
        Me.UcText1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UcText1.pCaptionPosition = WUC.UcText.CaptionPosition.Left
        Me.UcText1.pCaseformato = WUC.UcText.CaseFormato.Maiúsculo
        Me.UcText1.pDecimal = CType(0, Byte)
        Me.UcText1.pDicionario = WUC.clsDicionario.enuDicionario.Empresa_Codigo
        Me.UcText1.pFormatoSaida = WUC.UcText.FormatoSaida.Texto
        Me.UcText1.showButton = True
        Me.UcText1.ShowDescricao = True
        Me.UcText1.ShowDialog = True
        Me.UcText1.ShowToolTip = True
        Me.UcText1.Size = New System.Drawing.Size(395, 25)
        Me.UcText1.sqlQuery = "Select Cod_Empresa,Razao_Social from Empresa"
        Me.UcText1.TabIndex = 0
        Me.UcText1.TextBoxLeft = CType(0, Short)
        Me.UcText1.TextWidth = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 266)
        Me.Controls.Add(Me.UcText1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcText1 As WUC.UcText
End Class
