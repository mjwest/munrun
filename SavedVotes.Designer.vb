<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavedVotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SavedVotes))
        Me.rtbSavedVotes = New System.Windows.Forms.RichTextBox()
        Me.btnCopyResults = New System.Windows.Forms.Button()
        Me.btnExpResults = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbSavedVotes
        '
        Me.rtbSavedVotes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSavedVotes.Location = New System.Drawing.Point(12, 12)
        Me.rtbSavedVotes.Name = "rtbSavedVotes"
        Me.rtbSavedVotes.Size = New System.Drawing.Size(418, 506)
        Me.rtbSavedVotes.TabIndex = 0
        Me.rtbSavedVotes.Text = ""
        '
        'btnCopyResults
        '
        Me.btnCopyResults.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyResults.Location = New System.Drawing.Point(153, 524)
        Me.btnCopyResults.Name = "btnCopyResults"
        Me.btnCopyResults.Size = New System.Drawing.Size(135, 27)
        Me.btnCopyResults.TabIndex = 59
        Me.btnCopyResults.Text = "Copy to clipboard"
        Me.btnCopyResults.UseVisualStyleBackColor = True
        '
        'btnExpResults
        '
        Me.btnExpResults.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpResults.Location = New System.Drawing.Point(294, 524)
        Me.btnExpResults.Name = "btnExpResults"
        Me.btnExpResults.Size = New System.Drawing.Size(135, 27)
        Me.btnExpResults.TabIndex = 60
        Me.btnExpResults.Text = "Export to text file"
        Me.btnExpResults.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(12, 524)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 27)
        Me.btnClear.TabIndex = 61
        Me.btnClear.Text = "Clear results"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'SavedVotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 556)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExpResults)
        Me.Controls.Add(Me.btnCopyResults)
        Me.Controls.Add(Me.rtbSavedVotes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SavedVotes"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Saved vote results"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbSavedVotes As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCopyResults As System.Windows.Forms.Button
    Friend WithEvents btnExpResults As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
