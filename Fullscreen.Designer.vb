<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fullscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fullscreen))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tslFullscreenName = New System.Windows.Forms.ToolStripLabel()
        Me.tsbCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetFontSizeToolStripMenuItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SmallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtbFullscreen = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClose, Me.ToolStripLabel2, Me.tslFullscreenName, Me.tsbCopy, Me.SetFontSizeToolStripMenuItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1024, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnClose
        '
        Me.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 22)
        Me.btnClose.Text = "Close"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel2.Text = "    "
        '
        'tslFullscreenName
        '
        Me.tslFullscreenName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslFullscreenName.Name = "tslFullscreenName"
        Me.tslFullscreenName.Size = New System.Drawing.Size(110, 22)
        Me.tslFullscreenName.Text = "Document name"
        '
        'tsbCopy
        '
        Me.tsbCopy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopy.Name = "tsbCopy"
        Me.tsbCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsbCopy.Size = New System.Drawing.Size(67, 25)
        Me.tsbCopy.Text = "Copy all"
        '
        'SetFontSizeToolStripMenuItem
        '
        Me.SetFontSizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SetFontSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmallToolStripMenuItem, Me.MediumToolStripMenuItem, Me.LargeToolStripMenuItem, Me.HugeToolStripMenuItem})
        Me.SetFontSizeToolStripMenuItem.Name = "SetFontSizeToolStripMenuItem"
        Me.SetFontSizeToolStripMenuItem.Size = New System.Drawing.Size(71, 22)
        Me.SetFontSizeToolStripMenuItem.Text = "Text size"
        '
        'SmallToolStripMenuItem
        '
        Me.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem"
        Me.SmallToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SmallToolStripMenuItem.Text = "Small"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Checked = True
        Me.MediumToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'LargeToolStripMenuItem
        '
        Me.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem"
        Me.LargeToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LargeToolStripMenuItem.Text = "Large"
        '
        'HugeToolStripMenuItem
        '
        Me.HugeToolStripMenuItem.Name = "HugeToolStripMenuItem"
        Me.HugeToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.HugeToolStripMenuItem.Text = "Huge"
        '
        'rtbFullscreen
        '
        Me.rtbFullscreen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbFullscreen.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbFullscreen.ForeColor = System.Drawing.Color.Black
        Me.rtbFullscreen.Location = New System.Drawing.Point(0, 28)
        Me.rtbFullscreen.Name = "rtbFullscreen"
        Me.rtbFullscreen.ReadOnly = True
        Me.rtbFullscreen.Size = New System.Drawing.Size(1024, 460)
        Me.rtbFullscreen.TabIndex = 1
        Me.rtbFullscreen.Text = ""
        '
        'Timer1
        '
        '
        'Fullscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 500)
        Me.Controls.Add(Me.rtbFullscreen)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fullscreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fullscreen"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents SetFontSizeToolStripMenuItem As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SmallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HugeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tslFullscreenName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents rtbFullscreen As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tsbCopy As System.Windows.Forms.ToolStripMenuItem
End Class
