<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerceiroEmpresa
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
        Me.gridEmpresa = New System.Windows.Forms.DataGridView
        Me.bnnOkCancel = New WUC.ucButton
        Me.btnMarcar = New System.Windows.Forms.Button
        Me.bntDesMarcar = New System.Windows.Forms.Button
        CType(Me.gridEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridEmpresa
        '
        Me.gridEmpresa.BackgroundColor = System.Drawing.Color.White
        Me.gridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEmpresa.Location = New System.Drawing.Point(-1, 0)
        Me.gridEmpresa.Name = "gridEmpresa"
        Me.gridEmpresa.Size = New System.Drawing.Size(498, 433)
        Me.gridEmpresa.TabIndex = 0
        '
        'bnnOkCancel
        '
        Me.bnnOkCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnnOkCancel.BackColor = System.Drawing.SystemColors.Control
        Me.bnnOkCancel.Location = New System.Drawing.Point(297, 439)
        Me.bnnOkCancel.Name = "bnnOkCancel"
        Me.bnnOkCancel.Size = New System.Drawing.Size(179, 38)
        Me.bnnOkCancel.TabIndex = 1
        '
        'btnMarcar
        '
        Me.btnMarcar.Location = New System.Drawing.Point(12, 439)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(91, 38)
        Me.btnMarcar.TabIndex = 2
        Me.btnMarcar.TabStop = False
        Me.btnMarcar.Text = "Marcar Todas"
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'bntDesMarcar
        '
        Me.bntDesMarcar.Location = New System.Drawing.Point(109, 439)
        Me.bntDesMarcar.Name = "bntDesMarcar"
        Me.bntDesMarcar.Size = New System.Drawing.Size(95, 38)
        Me.bntDesMarcar.TabIndex = 3
        Me.bntDesMarcar.TabStop = False
        Me.bntDesMarcar.Text = "Desmarcar Todas"
        Me.bntDesMarcar.UseVisualStyleBackColor = True
        '
        'frmTerceiroEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 489)
        Me.Controls.Add(Me.bntDesMarcar)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.bnnOkCancel)
        Me.Controls.Add(Me.gridEmpresa)
        Me.Name = "frmTerceiroEmpresa"
        Me.Text = "Validar Para as Empresas"
        CType(Me.gridEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridEmpresa As System.Windows.Forms.DataGridView
    Friend WithEvents bnnOkCancel As WUC.ucButton
    Friend WithEvents btnMarcar As System.Windows.Forms.Button
    Friend WithEvents bntDesMarcar As System.Windows.Forms.Button
End Class
