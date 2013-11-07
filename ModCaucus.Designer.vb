<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModCaucus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModCaucus))
        Me.rtbModCaucus = New System.Windows.Forms.RichTextBox()
        Me.tbMCCaucTime = New System.Windows.Forms.TextBox()
        Me.tbMCSpkrTime = New System.Windows.Forms.TextBox()
        Me.btnMCCaucStart = New System.Windows.Forms.Button()
        Me.btnMCCaucReset = New System.Windows.Forms.Button()
        Me.btnMCCaucStop = New System.Windows.Forms.Button()
        Me.btnMCSpkrStop = New System.Windows.Forms.Button()
        Me.btnMCSpkrReset = New System.Windows.Forms.Button()
        Me.btnMCSpkrStart = New System.Windows.Forms.Button()
        Me.nudMCTimerCauc = New System.Windows.Forms.NumericUpDown()
        Me.nudMCTimerSpkr = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimerCauc = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSpkr = New System.Windows.Forms.Timer(Me.components)
        Me.gbMCFullTime = New System.Windows.Forms.GroupBox()
        Me.gbMCSpeakerTime = New System.Windows.Forms.GroupBox()
        Me.dbMCTimeType = New System.Windows.Forms.ComboBox()
        Me.flowMC = New System.Windows.Forms.FlowLayoutPanel()
        Me.panMCTopic = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbModTextSize = New System.Windows.Forms.ToolStripButton()
        Me.tsbModClear = New System.Windows.Forms.ToolStripButton()
        CType(Me.nudMCTimerCauc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMCTimerSpkr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMCFullTime.SuspendLayout()
        Me.gbMCSpeakerTime.SuspendLayout()
        Me.flowMC.SuspendLayout()
        Me.panMCTopic.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbModCaucus
        '
        Me.rtbModCaucus.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbModCaucus.Location = New System.Drawing.Point(7, 28)
        Me.rtbModCaucus.Name = "rtbModCaucus"
        Me.rtbModCaucus.Size = New System.Drawing.Size(270, 189)
        Me.rtbModCaucus.TabIndex = 0
        Me.rtbModCaucus.Text = ""
        '
        'tbMCCaucTime
        '
        Me.tbMCCaucTime.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMCCaucTime.Location = New System.Drawing.Point(6, 30)
        Me.tbMCCaucTime.Name = "tbMCCaucTime"
        Me.tbMCCaucTime.ReadOnly = True
        Me.tbMCCaucTime.Size = New System.Drawing.Size(155, 86)
        Me.tbMCCaucTime.TabIndex = 3
        Me.tbMCCaucTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbMCSpkrTime
        '
        Me.tbMCSpkrTime.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMCSpkrTime.Location = New System.Drawing.Point(6, 30)
        Me.tbMCSpkrTime.Name = "tbMCSpkrTime"
        Me.tbMCSpkrTime.ReadOnly = True
        Me.tbMCSpkrTime.Size = New System.Drawing.Size(155, 86)
        Me.tbMCSpkrTime.TabIndex = 5
        Me.tbMCSpkrTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMCCaucStart
        '
        Me.btnMCCaucStart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMCCaucStart.Image = CType(resources.GetObject("btnMCCaucStart.Image"), System.Drawing.Image)
        Me.btnMCCaucStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMCCaucStart.Location = New System.Drawing.Point(172, 88)
        Me.btnMCCaucStart.Name = "btnMCCaucStart"
        Me.btnMCCaucStart.Size = New System.Drawing.Size(104, 27)
        Me.btnMCCaucStart.TabIndex = 6
        Me.btnMCCaucStart.Text = "Start"
        Me.btnMCCaucStart.UseVisualStyleBackColor = True
        '
        'btnMCCaucReset
        '
        Me.btnMCCaucReset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMCCaucReset.Image = CType(resources.GetObject("btnMCCaucReset.Image"), System.Drawing.Image)
        Me.btnMCCaucReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMCCaucReset.Location = New System.Drawing.Point(172, 60)
        Me.btnMCCaucReset.Name = "btnMCCaucReset"
        Me.btnMCCaucReset.Size = New System.Drawing.Size(103, 27)
        Me.btnMCCaucReset.TabIndex = 7
        Me.btnMCCaucReset.Text = "Set time"
        Me.btnMCCaucReset.UseVisualStyleBackColor = True
        '
        'btnMCCaucStop
        '
        Me.btnMCCaucStop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMCCaucStop.Image = CType(resources.GetObject("btnMCCaucStop.Image"), System.Drawing.Image)
        Me.btnMCCaucStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMCCaucStop.Location = New System.Drawing.Point(172, 88)
        Me.btnMCCaucStop.Name = "btnMCCaucStop"
        Me.btnMCCaucStop.Size = New System.Drawing.Size(103, 27)
        Me.btnMCCaucStop.TabIndex = 8
        Me.btnMCCaucStop.Text = "Pause"
        Me.btnMCCaucStop.UseVisualStyleBackColor = True
        '
        'btnMCSpkrStop
        '
        Me.btnMCSpkrStop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMCSpkrStop.Image = CType(resources.GetObject("btnMCSpkrStop.Image"), System.Drawing.Image)
        Me.btnMCSpkrStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMCSpkrStop.Location = New System.Drawing.Point(173, 88)
        Me.btnMCSpkrStop.Name = "btnMCSpkrStop"
        Me.btnMCSpkrStop.Size = New System.Drawing.Size(103, 27)
        Me.btnMCSpkrStop.TabIndex = 11
        Me.btnMCSpkrStop.Text = "Pause"
        Me.btnMCSpkrStop.UseVisualStyleBackColor = True
        '
        'btnMCSpkrReset
        '
        Me.btnMCSpkrReset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMCSpkrReset.Image = CType(resources.GetObject("btnMCSpkrReset.Image"), System.Drawing.Image)
        Me.btnMCSpkrReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMCSpkrReset.Location = New System.Drawing.Point(174, 60)
        Me.btnMCSpkrReset.Name = "btnMCSpkrReset"
        Me.btnMCSpkrReset.Size = New System.Drawing.Size(103, 27)
        Me.btnMCSpkrReset.TabIndex = 10
        Me.btnMCSpkrReset.Text = "Set time"
        Me.btnMCSpkrReset.UseVisualStyleBackColor = True
        '
        'btnMCSpkrStart
        '
        Me.btnMCSpkrStart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMCSpkrStart.Image = CType(resources.GetObject("btnMCSpkrStart.Image"), System.Drawing.Image)
        Me.btnMCSpkrStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMCSpkrStart.Location = New System.Drawing.Point(172, 89)
        Me.btnMCSpkrStart.Name = "btnMCSpkrStart"
        Me.btnMCSpkrStart.Size = New System.Drawing.Size(104, 27)
        Me.btnMCSpkrStart.TabIndex = 9
        Me.btnMCSpkrStart.Text = "Start"
        Me.btnMCSpkrStart.UseVisualStyleBackColor = True
        '
        'nudMCTimerCauc
        '
        Me.nudMCTimerCauc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMCTimerCauc.Location = New System.Drawing.Point(172, 30)
        Me.nudMCTimerCauc.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudMCTimerCauc.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMCTimerCauc.Name = "nudMCTimerCauc"
        Me.nudMCTimerCauc.Size = New System.Drawing.Size(48, 25)
        Me.nudMCTimerCauc.TabIndex = 13
        Me.nudMCTimerCauc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMCTimerCauc.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudMCTimerCauc.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudMCTimerSpkr
        '
        Me.nudMCTimerSpkr.Location = New System.Drawing.Point(172, 31)
        Me.nudMCTimerSpkr.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudMCTimerSpkr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMCTimerSpkr.Name = "nudMCTimerSpkr"
        Me.nudMCTimerSpkr.Size = New System.Drawing.Size(48, 25)
        Me.nudMCTimerSpkr.TabIndex = 14
        Me.nudMCTimerSpkr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMCTimerSpkr.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudMCTimerSpkr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(226, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "min"
        '
        'TimerCauc
        '
        Me.TimerCauc.Interval = 1000
        '
        'TimerSpkr
        '
        Me.TimerSpkr.Interval = 1000
        '
        'gbMCFullTime
        '
        Me.gbMCFullTime.Controls.Add(Me.Label4)
        Me.gbMCFullTime.Controls.Add(Me.nudMCTimerCauc)
        Me.gbMCFullTime.Controls.Add(Me.btnMCCaucReset)
        Me.gbMCFullTime.Controls.Add(Me.btnMCCaucStop)
        Me.gbMCFullTime.Controls.Add(Me.btnMCCaucStart)
        Me.gbMCFullTime.Controls.Add(Me.tbMCCaucTime)
        Me.gbMCFullTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMCFullTime.ForeColor = System.Drawing.Color.Black
        Me.gbMCFullTime.Location = New System.Drawing.Point(3, 233)
        Me.gbMCFullTime.Name = "gbMCFullTime"
        Me.gbMCFullTime.Size = New System.Drawing.Size(287, 130)
        Me.gbMCFullTime.TabIndex = 18
        Me.gbMCFullTime.TabStop = False
        Me.gbMCFullTime.Text = "Caucus time"
        '
        'gbMCSpeakerTime
        '
        Me.gbMCSpeakerTime.Controls.Add(Me.dbMCTimeType)
        Me.gbMCSpeakerTime.Controls.Add(Me.nudMCTimerSpkr)
        Me.gbMCSpeakerTime.Controls.Add(Me.btnMCSpkrReset)
        Me.gbMCSpeakerTime.Controls.Add(Me.btnMCSpkrStop)
        Me.gbMCSpeakerTime.Controls.Add(Me.btnMCSpkrStart)
        Me.gbMCSpeakerTime.Controls.Add(Me.tbMCSpkrTime)
        Me.gbMCSpeakerTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMCSpeakerTime.ForeColor = System.Drawing.Color.Black
        Me.gbMCSpeakerTime.Location = New System.Drawing.Point(3, 369)
        Me.gbMCSpeakerTime.Name = "gbMCSpeakerTime"
        Me.gbMCSpeakerTime.Size = New System.Drawing.Size(287, 130)
        Me.gbMCSpeakerTime.TabIndex = 19
        Me.gbMCSpeakerTime.TabStop = False
        Me.gbMCSpeakerTime.Text = "Speaker time"
        '
        'dbMCTimeType
        '
        Me.dbMCTimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dbMCTimeType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbMCTimeType.FormattingEnabled = True
        Me.dbMCTimeType.Items.AddRange(New Object() {"min", "sec"})
        Me.dbMCTimeType.Location = New System.Drawing.Point(226, 31)
        Me.dbMCTimeType.Name = "dbMCTimeType"
        Me.dbMCTimeType.Size = New System.Drawing.Size(49, 25)
        Me.dbMCTimeType.TabIndex = 17
        '
        'flowMC
        '
        Me.flowMC.Controls.Add(Me.panMCTopic)
        Me.flowMC.Controls.Add(Me.gbMCFullTime)
        Me.flowMC.Controls.Add(Me.gbMCSpeakerTime)
        Me.flowMC.Location = New System.Drawing.Point(0, 0)
        Me.flowMC.Name = "flowMC"
        Me.flowMC.Size = New System.Drawing.Size(290, 500)
        Me.flowMC.TabIndex = 20
        '
        'panMCTopic
        '
        Me.panMCTopic.Controls.Add(Me.ToolStrip1)
        Me.panMCTopic.Controls.Add(Me.rtbModCaucus)
        Me.panMCTopic.Location = New System.Drawing.Point(3, 3)
        Me.panMCTopic.Name = "panMCTopic"
        Me.panMCTopic.Size = New System.Drawing.Size(285, 224)
        Me.panMCTopic.TabIndex = 21
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbModTextSize, Me.tsbModClear})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(285, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel1.Text = "Caucus topic"
        '
        'tsbModTextSize
        '
        Me.tsbModTextSize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbModTextSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbModTextSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModTextSize.Name = "tsbModTextSize"
        Me.tsbModTextSize.Size = New System.Drawing.Size(53, 22)
        Me.tsbModTextSize.Text = "Text size"
        '
        'tsbModClear
        '
        Me.tsbModClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbModClear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbModClear.Image = CType(resources.GetObject("tsbModClear.Image"), System.Drawing.Image)
        Me.tsbModClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModClear.Name = "tsbModClear"
        Me.tsbModClear.Size = New System.Drawing.Size(82, 22)
        Me.tsbModClear.Text = "Clear topic"
        '
        'ModCaucus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 496)
        Me.Controls.Add(Me.flowMC)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 530)
        Me.MinimumSize = New System.Drawing.Size(300, 396)
        Me.Name = "ModCaucus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moderated caucus"
        Me.TopMost = True
        CType(Me.nudMCTimerCauc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMCTimerSpkr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMCFullTime.ResumeLayout(False)
        Me.gbMCFullTime.PerformLayout()
        Me.gbMCSpeakerTime.ResumeLayout(False)
        Me.gbMCSpeakerTime.PerformLayout()
        Me.flowMC.ResumeLayout(False)
        Me.panMCTopic.ResumeLayout(False)
        Me.panMCTopic.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbModCaucus As System.Windows.Forms.RichTextBox
    Friend WithEvents tbMCCaucTime As System.Windows.Forms.TextBox
    Friend WithEvents tbMCSpkrTime As System.Windows.Forms.TextBox
    Friend WithEvents btnMCCaucStart As System.Windows.Forms.Button
    Friend WithEvents btnMCCaucReset As System.Windows.Forms.Button
    Friend WithEvents btnMCCaucStop As System.Windows.Forms.Button
    Friend WithEvents btnMCSpkrStop As System.Windows.Forms.Button
    Friend WithEvents btnMCSpkrReset As System.Windows.Forms.Button
    Friend WithEvents btnMCSpkrStart As System.Windows.Forms.Button
    Friend WithEvents nudMCTimerCauc As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMCTimerSpkr As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TimerCauc As System.Windows.Forms.Timer
    Friend WithEvents TimerSpkr As System.Windows.Forms.Timer
    Friend WithEvents gbMCFullTime As System.Windows.Forms.GroupBox
    Friend WithEvents gbMCSpeakerTime As System.Windows.Forms.GroupBox
    Friend WithEvents flowMC As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panMCTopic As System.Windows.Forms.Panel
    Friend WithEvents dbMCTimeType As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbModTextSize As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbModClear As System.Windows.Forms.ToolStripButton
End Class
