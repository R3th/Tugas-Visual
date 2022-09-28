<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnForNextLoop = New System.Windows.Forms.Button()
        Me.btnDOloop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(0, 34)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(331, 484)
        Me.lstData.TabIndex = 0
        '
        'btnForNextLoop
        '
        Me.btnForNextLoop.Location = New System.Drawing.Point(351, 34)
        Me.btnForNextLoop.Name = "btnForNextLoop"
        Me.btnForNextLoop.Size = New System.Drawing.Size(138, 23)
        Me.btnForNextLoop.TabIndex = 1
        Me.btnForNextLoop.Text = "For NextLoop"
        Me.btnForNextLoop.UseVisualStyleBackColor = True
        '
        'btnDOloop
        '
        Me.btnDOloop.Location = New System.Drawing.Point(375, 119)
        Me.btnDOloop.Name = "btnDOloop"
        Me.btnDOloop.Size = New System.Drawing.Size(75, 23)
        Me.btnDOloop.TabIndex = 2
        Me.btnDOloop.Text = "DO loop"
        Me.btnDOloop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 510)
        Me.Controls.Add(Me.btnDOloop)
        Me.Controls.Add(Me.btnForNextLoop)
        Me.Controls.Add(Me.lstData)
        Me.Name = "Form1"
        Me.Text = "Never gonna give you up"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents btnForNextLoop As Button
    Friend WithEvents btnDOloop As Button
End Class
