<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistics))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbShowDelegates = New System.Windows.Forms.Label()
        Me.lbShowVoting = New System.Windows.Forms.Label()
        Me.lbShowQuorum = New System.Windows.Forms.Label()
        Me.lbSignatoriesRes = New System.Windows.Forms.Label()
        Me.lbSignatoriesAmend = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbSignatoriesResExp = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 17)
        Me.Label14.TabIndex = 72
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 21)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Total delegates"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(426, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 35)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbShowDelegates
        '
        Me.lbShowDelegates.AutoSize = True
        Me.lbShowDelegates.BackColor = System.Drawing.Color.Transparent
        Me.lbShowDelegates.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShowDelegates.ForeColor = System.Drawing.Color.Black
        Me.lbShowDelegates.Location = New System.Drawing.Point(167, 5)
        Me.lbShowDelegates.Name = "lbShowDelegates"
        Me.lbShowDelegates.Size = New System.Drawing.Size(25, 30)
        Me.lbShowDelegates.TabIndex = 79
        Me.lbShowDelegates.Text = "0"
        Me.lbShowDelegates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbShowVoting
        '
        Me.lbShowVoting.AutoSize = True
        Me.lbShowVoting.BackColor = System.Drawing.Color.Transparent
        Me.lbShowVoting.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShowVoting.ForeColor = System.Drawing.Color.Black
        Me.lbShowVoting.Location = New System.Drawing.Point(167, 50)
        Me.lbShowVoting.Name = "lbShowVoting"
        Me.lbShowVoting.Size = New System.Drawing.Size(25, 30)
        Me.lbShowVoting.TabIndex = 80
        Me.lbShowVoting.Text = "0"
        Me.lbShowVoting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbShowQuorum
        '
        Me.lbShowQuorum.AutoSize = True
        Me.lbShowQuorum.BackColor = System.Drawing.Color.Transparent
        Me.lbShowQuorum.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShowQuorum.ForeColor = System.Drawing.Color.Black
        Me.lbShowQuorum.Location = New System.Drawing.Point(167, 96)
        Me.lbShowQuorum.Name = "lbShowQuorum"
        Me.lbShowQuorum.Size = New System.Drawing.Size(25, 30)
        Me.lbShowQuorum.TabIndex = 81
        Me.lbShowQuorum.Text = "0"
        Me.lbShowQuorum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSignatoriesRes
        '
        Me.lbSignatoriesRes.AutoSize = True
        Me.lbSignatoriesRes.BackColor = System.Drawing.Color.Transparent
        Me.lbSignatoriesRes.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSignatoriesRes.ForeColor = System.Drawing.Color.Black
        Me.lbSignatoriesRes.Location = New System.Drawing.Point(342, 145)
        Me.lbSignatoriesRes.Name = "lbSignatoriesRes"
        Me.lbSignatoriesRes.Size = New System.Drawing.Size(25, 30)
        Me.lbSignatoriesRes.TabIndex = 82
        Me.lbSignatoriesRes.Text = "0"
        Me.lbSignatoriesRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSignatoriesAmend
        '
        Me.lbSignatoriesAmend.AutoSize = True
        Me.lbSignatoriesAmend.BackColor = System.Drawing.Color.Transparent
        Me.lbSignatoriesAmend.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSignatoriesAmend.ForeColor = System.Drawing.Color.Black
        Me.lbSignatoriesAmend.Location = New System.Drawing.Point(342, 190)
        Me.lbSignatoriesAmend.Name = "lbSignatoriesAmend"
        Me.lbSignatoriesAmend.Size = New System.Drawing.Size(25, 30)
        Me.lbSignatoriesAmend.TabIndex = 83
        Me.lbSignatoriesAmend.Text = "0"
        Me.lbSignatoriesAmend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 21)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Voting delegates"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Quorum"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 21)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Signatories needed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(189, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Draft resolution"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(189, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 21)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Amendment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 17)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Delegates in committee"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(217, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 17)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Delegates with voting rights"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(258, 17)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Delegates needed for debate; 50% of total"
        '
        'lbSignatoriesResExp
        '
        Me.lbSignatoriesResExp.AutoSize = True
        Me.lbSignatoriesResExp.Location = New System.Drawing.Point(391, 152)
        Me.lbSignatoriesResExp.Name = "lbSignatoriesResExp"
        Me.lbSignatoriesResExp.Size = New System.Drawing.Size(95, 17)
        Me.lbSignatoriesResExp.TabIndex = 92
        Me.lbSignatoriesResExp.Text = "25% of eligible"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(391, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 17)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "10% of eligible"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(6, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 34)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Only countries are eligible" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to become signatories"
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 278)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbSignatoriesResExp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbSignatoriesAmend)
        Me.Controls.Add(Me.lbSignatoriesRes)
        Me.Controls.Add(Me.lbShowQuorum)
        Me.Controls.Add(Me.lbShowVoting)
        Me.Controls.Add(Me.lbShowDelegates)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label17)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Statistics"
        Me.ShowInTaskbar = False
        Me.Text = "Committee statistics"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbShowDelegates As System.Windows.Forms.Label
    Friend WithEvents lbShowVoting As System.Windows.Forms.Label
    Friend WithEvents lbShowQuorum As System.Windows.Forms.Label
    Friend WithEvents lbSignatoriesRes As System.Windows.Forms.Label
    Friend WithEvents lbSignatoriesAmend As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbSignatoriesResExp As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
