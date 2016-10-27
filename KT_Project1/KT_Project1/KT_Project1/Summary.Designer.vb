<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        Me.rtbSummary = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbSummary
        '
        Me.rtbSummary.Location = New System.Drawing.Point(28, 22)
        Me.rtbSummary.Name = "rtbSummary"
        Me.rtbSummary.Size = New System.Drawing.Size(236, 236)
        Me.rtbSummary.TabIndex = 0
        Me.rtbSummary.Text = ""
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 270)
        Me.Controls.Add(Me.rtbSummary)
        Me.Name = "Summary"
        Me.Text = "Summary"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbSummary As RichTextBox
End Class
