<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstAllWindows = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstAllWindows
        '
        Me.lstAllWindows.FormattingEnabled = True
        Me.lstAllWindows.Location = New System.Drawing.Point(10, 13)
        Me.lstAllWindows.Name = "lstAllWindows"
        Me.lstAllWindows.Size = New System.Drawing.Size(539, 238)
        Me.lstAllWindows.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 261)
        Me.Controls.Add(Me.lstAllWindows)
        Me.Name = "frmMain"
        Me.Text = "Windows"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstAllWindows As System.Windows.Forms.ListBox

End Class
