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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnCheckNumbers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(11, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(138, 22)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "Stephanie"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(11, 40)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(11, 88)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(138, 22)
        Me.txtValue.TabIndex = 2
        '
        'btnCheckNumbers
        '
        Me.btnCheckNumbers.Location = New System.Drawing.Point(11, 116)
        Me.btnCheckNumbers.Name = "btnCheckNumbers"
        Me.btnCheckNumbers.Size = New System.Drawing.Size(138, 23)
        Me.btnCheckNumbers.TabIndex = 3
        Me.btnCheckNumbers.Text = "Check Numbers"
        Me.btnCheckNumbers.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.btnCheckNumbers)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnCheckNumbers As Button
End Class
