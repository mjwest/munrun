<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NextSpeakerDisplay
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NextSpeakerDisplay))
        Me.lblMainSpeaker = New System.Windows.Forms.Label()
        Me.timerFade = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUpNext = New System.Windows.Forms.Label()
        Me.lblFollowingSpeaker = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMainSpeaker
        '
        Me.lblMainSpeaker.AutoSize = True
        Me.lblMainSpeaker.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainSpeaker.ForeColor = System.Drawing.Color.Gold
        Me.lblMainSpeaker.Location = New System.Drawing.Point(12, 56)
        Me.lblMainSpeaker.Name = "lblMainSpeaker"
        Me.lblMainSpeaker.Size = New System.Drawing.Size(807, 45)
        Me.lblMainSpeaker.TabIndex = 0
        Me.lblMainSpeaker.Text = "Democratic People's Republic of Korea, Against, 10 min"
        Me.lblMainSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerFade
        '
        Me.timerFade.Interval = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Speaking now:"
        '
        'lblUpNext
        '
        Me.lblUpNext.AutoSize = True
        Me.lblUpNext.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpNext.ForeColor = System.Drawing.Color.White
        Me.lblUpNext.Location = New System.Drawing.Point(14, 137)
        Me.lblUpNext.Name = "lblUpNext"
        Me.lblUpNext.Size = New System.Drawing.Size(103, 32)
        Me.lblUpNext.TabIndex = 2
        Me.lblUpNext.Text = "Up next:"
        '
        'lblFollowingSpeaker
        '
        Me.lblFollowingSpeaker.AutoSize = True
        Me.lblFollowingSpeaker.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFollowingSpeaker.ForeColor = System.Drawing.Color.White
        Me.lblFollowingSpeaker.Location = New System.Drawing.Point(14, 169)
        Me.lblFollowingSpeaker.Name = "lblFollowingSpeaker"
        Me.lblFollowingSpeaker.Size = New System.Drawing.Size(605, 32)
        Me.lblFollowingSpeaker.TabIndex = 3
        Me.lblFollowingSpeaker.Text = "Democratic People's Republic of Korea, Against, 10 min"
        '
        'NextSpeakerDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(845, 230)
        Me.Controls.Add(Me.lblFollowingSpeaker)
        Me.Controls.Add(Me.lblUpNext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMainSpeaker)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NextSpeakerDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NextSpeakerDisplay"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Green
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMainSpeaker As System.Windows.Forms.Label
    Friend WithEvents timerFade As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUpNext As System.Windows.Forms.Label
    Friend WithEvents lblFollowingSpeaker As System.Windows.Forms.Label
End Class
