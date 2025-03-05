<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpressao
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
        Me.crvImpressao = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvImpressao
        '
        Me.crvImpressao.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.crvImpressao.ActiveViewIndex = -1
        Me.crvImpressao.AutoSize = True
        Me.crvImpressao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvImpressao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvImpressao.Location = New System.Drawing.Point(0, 0)
        Me.crvImpressao.Name = "crvImpressao"
        Me.crvImpressao.SelectionFormula = ""
        Me.crvImpressao.ShowCloseButton = False
        Me.crvImpressao.ShowExportButton = False
        Me.crvImpressao.ShowGotoPageButton = False
        Me.crvImpressao.ShowGroupTreeButton = False
        Me.crvImpressao.ShowRefreshButton = False
        Me.crvImpressao.ShowTextSearchButton = False
        Me.crvImpressao.Size = New System.Drawing.Size(527, 550)
        Me.crvImpressao.TabIndex = 0
        Me.crvImpressao.ViewTimeSelectionFormula = ""
        '
        'frmImpressao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(527, 550)
        Me.Controls.Add(Me.crvImpressao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpressao"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvImpressao As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
