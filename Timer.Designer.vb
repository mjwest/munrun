<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Timer))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmsTimerNames = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SpeakerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaucusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LunchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudSecs = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudMins = New System.Windows.Forms.NumericUpDown()
        Me.btnCaucTimeReset = New System.Windows.Forms.Button()
        Me.btnCTStop = New System.Windows.Forms.Button()
        Me.btnCaucTimeStart = New System.Windows.Forms.Button()
        Me.tbCaucTime = New System.Windows.Forms.TextBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.linkCancel = New System.Windows.Forms.LinkLabel()
        Me.cmsTimerNames.SuspendLayout()
        CType(Me.nudSecs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cmsTimerNames
        '
        Me.cmsTimerNames.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeakerToolStripMenuItem, Me.CaucusToolStripMenuItem, Me.ReadingToolStripMenuItem, Me.LunchToolStripMenuItem})
        Me.cmsTimerNames.Name = "cmsTimerNames"
        Me.cmsTimerNames.Size = New System.Drawing.Size(126, 92)
        '
        'SpeakerToolStripMenuItem
        '
        Me.SpeakerToolStripMenuItem.Name = "SpeakerToolStripMenuItem"
        Me.SpeakerToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SpeakerToolStripMenuItem.Text = "Speaker"
        '
        'CaucusToolStripMenuItem
        '
        Me.CaucusToolStripMenuItem.Name = "CaucusToolStripMenuItem"
        Me.CaucusToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CaucusToolStripMenuItem.Text = "Caucus"
        '
        'ReadingToolStripMenuItem
        '
        Me.ReadingToolStripMenuItem.Name = "ReadingToolStripMenuItem"
        Me.ReadingToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ReadingToolStripMenuItem.Text = "Reading"
        '
        'LunchToolStripMenuItem
        '
        Me.LunchToolStripMenuItem.Name = "LunchToolStripMenuItem"
        Me.LunchToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.LunchToolStripMenuItem.Text = "Lunch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "sec"
        '
        'nudSecs
        '
        Me.nudSecs.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSecs.Location = New System.Drawing.Point(81, 13)
        Me.nudSecs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudSecs.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSecs.Name = "nudSecs"
        Me.nudSecs.Size = New System.Drawing.Size(60, 54)
        Me.nudSecs.TabIndex = 22
        Me.nudSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "min"
        '
        'nudMins
        '
        Me.nudMins.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMins.Location = New System.Drawing.Point(12, 13)
        Me.nudMins.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudMins.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudMins.Name = "nudMins"
        Me.nudMins.Size = New System.Drawing.Size(60, 54)
        Me.nudMins.TabIndex = 20
        Me.nudMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMins.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCaucTimeReset
        '
        Me.btnCaucTimeReset.Location = New System.Drawing.Point(110, 88)
        Me.btnCaucTimeReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCaucTimeReset.Name = "btnCaucTimeReset"
        Me.btnCaucTimeReset.Size = New System.Drawing.Size(72, 30)
        Me.btnCaucTimeReset.TabIndex = 17
        Me.btnCaucTimeReset.Text = "Reset"
        Me.btnCaucTimeReset.UseVisualStyleBackColor = True
        '
        'btnCTStop
        '
        Me.btnCTStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCTStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCTStop.Location = New System.Drawing.Point(12, 88)
        Me.btnCTStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCTStop.Name = "btnCTStop"
        Me.btnCTStop.Size = New System.Drawing.Size(80, 30)
        Me.btnCTStop.TabIndex = 18
        Me.btnCTStop.Text = "Stop"
        Me.btnCTStop.UseVisualStyleBackColor = True
        '
        'btnCaucTimeStart
        '
        Me.btnCaucTimeStart.Location = New System.Drawing.Point(12, 88)
        Me.btnCaucTimeStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCaucTimeStart.Name = "btnCaucTimeStart"
        Me.btnCaucTimeStart.Size = New System.Drawing.Size(80, 30)
        Me.btnCaucTimeStart.TabIndex = 16
        Me.btnCaucTimeStart.Text = "Start"
        Me.btnCaucTimeStart.UseVisualStyleBackColor = True
        '
        'tbCaucTime
        '
        Me.tbCaucTime.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCaucTime.Location = New System.Drawing.Point(12, 9)
        Me.tbCaucTime.Name = "tbCaucTime"
        Me.tbCaucTime.Size = New System.Drawing.Size(170, 71)
        Me.tbCaucTime.TabIndex = 24
        Me.tbCaucTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSet
        '
        Me.btnSet.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.Location = New System.Drawing.Point(147, 13)
        Me.btnSet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(80, 32)
        Me.btnSet.TabIndex = 25
        Me.btnSet.Text = "Set time"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'linkCancel
        '
        Me.linkCancel.AutoSize = True
        Me.linkCancel.LinkColor = System.Drawing.Color.Red
        Me.linkCancel.Location = New System.Drawing.Point(171, 50)
        Me.linkCancel.Name = "linkCancel"
        Me.linkCancel.Size = New System.Drawing.Size(56, 17)
        Me.linkCancel.TabIndex = 27
        Me.linkCancel.TabStop = True
        Me.linkCancel.Text = "Go back"
        '
        'Timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 123)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.linkCancel)
        Me.Controls.Add(Me.tbCaucTime)
        Me.Controls.Add(Me.nudSecs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudMins)
        Me.Controls.Add(Me.btnCaucTimeReset)
        Me.Controls.Add(Me.btnCaucTimeStart)
        Me.Controls.Add(Me.btnCTStop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Timer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer"
        Me.TopMost = True
        Me.cmsTimerNames.ResumeLayout(False)
        CType(Me.nudSecs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmsTimerNames As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CaucusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LunchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeakerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudSecs As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudMins As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCaucTimeReset As System.Windows.Forms.Button
    Friend WithEvents btnCTStop As System.Windows.Forms.Button
    Friend WithEvents btnCaucTimeStart As System.Windows.Forms.Button
    Friend WithEvents tbCaucTime As System.Windows.Forms.TextBox
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents linkCancel As System.Windows.Forms.LinkLabel
End Class
