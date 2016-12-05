<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLinq
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optXElement = New System.Windows.Forms.RadioButton()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnLinq = New System.Windows.Forms.Button()
        Me.optRandom = New System.Windows.Forms.RadioButton()
        Me.optDistinctRandom = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optDistinctRandom)
        Me.GroupBox1.Controls.Add(Me.optRandom)
        Me.GroupBox1.Controls.Add(Me.optXElement)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'optXElement
        '
        Me.optXElement.AutoSize = True
        Me.optXElement.Checked = True
        Me.optXElement.Location = New System.Drawing.Point(22, 29)
        Me.optXElement.Name = "optXElement"
        Me.optXElement.Size = New System.Drawing.Size(70, 17)
        Me.optXElement.TabIndex = 0
        Me.optXElement.Text = "XElement"
        Me.optXElement.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(49, 183)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(884, 173)
        Me.lstResults.TabIndex = 1
        '
        'btnLinq
        '
        Me.btnLinq.Location = New System.Drawing.Point(470, 405)
        Me.btnLinq.Name = "btnLinq"
        Me.btnLinq.Size = New System.Drawing.Size(75, 23)
        Me.btnLinq.TabIndex = 2
        Me.btnLinq.Text = "LINQ"
        Me.btnLinq.UseVisualStyleBackColor = True
        '
        'optRandom
        '
        Me.optRandom.AutoSize = True
        Me.optRandom.Location = New System.Drawing.Point(22, 52)
        Me.optRandom.Name = "optRandom"
        Me.optRandom.Size = New System.Drawing.Size(65, 17)
        Me.optRandom.TabIndex = 0
        Me.optRandom.Text = "Random"
        Me.optRandom.UseVisualStyleBackColor = True
        '
        'optDistinctRandom
        '
        Me.optDistinctRandom.AutoSize = True
        Me.optDistinctRandom.Location = New System.Drawing.Point(22, 77)
        Me.optDistinctRandom.Name = "optDistinctRandom"
        Me.optDistinctRandom.Size = New System.Drawing.Size(104, 17)
        Me.optDistinctRandom.TabIndex = 0
        Me.optDistinctRandom.Text = "DIstinct Random"
        Me.optDistinctRandom.UseVisualStyleBackColor = True
        '
        'frmLinq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 526)
        Me.Controls.Add(Me.btnLinq)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLinq"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optXElement As RadioButton
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnLinq As Button
    Friend WithEvents optDistinctRandom As RadioButton
    Friend WithEvents optRandom As RadioButton
End Class
