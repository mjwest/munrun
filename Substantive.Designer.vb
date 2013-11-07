<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Substantive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Substantive))
        Me.nudSubst = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clbVeto = New System.Windows.Forms.CheckedListBox()
        Me.cbSubst = New System.Windows.Forms.CheckBox()
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.OK_Button = New System.Windows.Forms.Button()
        CType(Me.nudSubst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudSubst
        '
        Me.nudSubst.Location = New System.Drawing.Point(260, 42)
        Me.nudSubst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudSubst.Name = "nudSubst"
        Me.nudSubst.Size = New System.Drawing.Size(52, 25)
        Me.nudSubst.TabIndex = 0
        Me.nudSubst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSubst.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = """For"" votes required for motion to pass:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Countries with veto power:"
        '
        'clbVeto
        '
        Me.clbVeto.CheckOnClick = True
        Me.clbVeto.FormattingEnabled = True
        Me.clbVeto.Location = New System.Drawing.Point(18, 95)
        Me.clbVeto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.clbVeto.Name = "clbVeto"
        Me.clbVeto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clbVeto.Size = New System.Drawing.Size(298, 144)
        Me.clbVeto.Sorted = True
        Me.clbVeto.TabIndex = 3
        '
        'cbSubst
        '
        Me.cbSubst.AutoSize = True
        Me.cbSubst.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubst.Location = New System.Drawing.Point(12, 13)
        Me.cbSubst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSubst.Name = "cbSubst"
        Me.cbSubst.Size = New System.Drawing.Size(145, 21)
        Me.cbSubst.TabIndex = 8
        Me.cbSubst.Text = "Allow special votes"
        Me.cbSubst.UseVisualStyleBackColor = True
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(270, 258)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(46, 17)
        Me.lklCancel.TabIndex = 10
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.Location = New System.Drawing.Point(144, 248)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(120, 36)
        Me.OK_Button.TabIndex = 9
        Me.OK_Button.Text = "Set options"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Substantive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 292)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.cbSubst)
        Me.Controls.Add(Me.clbVeto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudSubst)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Substantive"
        Me.ShowInTaskbar = False
        Me.Text = "Special voting options"
        Me.TopMost = True
        CType(Me.nudSubst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudSubst As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clbVeto As System.Windows.Forms.CheckedListBox
    Friend WithEvents cbSubst As System.Windows.Forms.CheckBox
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
End Class
