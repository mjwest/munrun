<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeTime))
        Me.nudCT = New System.Windows.Forms.NumericUpDown()
        Me.rbSecsCT = New System.Windows.Forms.RadioButton()
        Me.rbMinsCT = New System.Windows.Forms.RadioButton()
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.OK_Button = New System.Windows.Forms.Button()
        CType(Me.nudCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudCT
        '
        Me.nudCT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCT.Location = New System.Drawing.Point(12, 7)
        Me.nudCT.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudCT.Name = "nudCT"
        Me.nudCT.Size = New System.Drawing.Size(93, 33)
        Me.nudCT.TabIndex = 2
        Me.nudCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbSecsCT
        '
        Me.rbSecsCT.AutoSize = True
        Me.rbSecsCT.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSecsCT.Location = New System.Drawing.Point(169, 11)
        Me.rbSecsCT.Name = "rbSecsCT"
        Me.rbSecsCT.Size = New System.Drawing.Size(48, 24)
        Me.rbSecsCT.TabIndex = 18
        Me.rbSecsCT.Text = "sec"
        Me.rbSecsCT.UseVisualStyleBackColor = True
        '
        'rbMinsCT
        '
        Me.rbMinsCT.AutoSize = True
        Me.rbMinsCT.Checked = True
        Me.rbMinsCT.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMinsCT.Location = New System.Drawing.Point(111, 11)
        Me.rbMinsCT.Name = "rbMinsCT"
        Me.rbMinsCT.Size = New System.Drawing.Size(52, 24)
        Me.rbMinsCT.TabIndex = 17
        Me.rbMinsCT.TabStop = True
        Me.rbMinsCT.Text = "min"
        Me.rbMinsCT.UseVisualStyleBackColor = True
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(150, 57)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(46, 17)
        Me.lklCancel.TabIndex = 20
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.Location = New System.Drawing.Point(12, 47)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(132, 36)
        Me.OK_Button.TabIndex = 19
        Me.OK_Button.Text = "Change time"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'ChangeTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 89)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.rbSecsCT)
        Me.Controls.Add(Me.rbMinsCT)
        Me.Controls.Add(Me.nudCT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeTime"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change time"
        CType(Me.nudCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudCT As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbSecsCT As System.Windows.Forms.RadioButton
    Friend WithEvents rbMinsCT As System.Windows.Forms.RadioButton
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents OK_Button As System.Windows.Forms.Button

End Class
