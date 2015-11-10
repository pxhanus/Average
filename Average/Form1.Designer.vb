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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 34)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(85, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number: "
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(99, 31)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(59, 20)
        Me.txtNum.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(164, 22)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(66, 36)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Average"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAns
        '
        Me.lblAns.Location = New System.Drawing.Point(12, 74)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(218, 40)
        Me.lblAns.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 123)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblAns As Label
End Class
