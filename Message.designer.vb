<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Message))
        Me.rtbMsgChair = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SpeakingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteFromClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.sticky = New System.Windows.Forms.ToolStripButton()
        Me.tsbFont = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbMsgChair
        '
        Me.rtbMsgChair.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMsgChair.Location = New System.Drawing.Point(2, 28)
        Me.rtbMsgChair.Name = "rtbMsgChair"
        Me.rtbMsgChair.Size = New System.Drawing.Size(388, 180)
        Me.rtbMsgChair.TabIndex = 0
        Me.rtbMsgChair.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.sticky, Me.tsbFont})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(392, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeakingListToolStripMenuItem, Me.ActiveDocumentToolStripMenuItem, Me.PasteFromClipboardToolStripMenuItem})
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripButton2.Text = "Insert text"
        Me.ToolStripButton2.ToolTipText = "Insert text"
        '
        'SpeakingListToolStripMenuItem
        '
        Me.SpeakingListToolStripMenuItem.Name = "SpeakingListToolStripMenuItem"
        Me.SpeakingListToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SpeakingListToolStripMenuItem.Text = "Speaking list"
        '
        'ActiveDocumentToolStripMenuItem
        '
        Me.ActiveDocumentToolStripMenuItem.Name = "ActiveDocumentToolStripMenuItem"
        Me.ActiveDocumentToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ActiveDocumentToolStripMenuItem.Text = "Active document"
        '
        'PasteFromClipboardToolStripMenuItem
        '
        Me.PasteFromClipboardToolStripMenuItem.Name = "PasteFromClipboardToolStripMenuItem"
        Me.PasteFromClipboardToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.PasteFromClipboardToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteFromClipboardToolStripMenuItem.ShowShortcutKeys = False
        Me.PasteFromClipboardToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PasteFromClipboardToolStripMenuItem.Text = "Paste from clipboard"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton3.Text = "Clear text"
        '
        'sticky
        '
        Me.sticky.CheckOnClick = True
        Me.sticky.Image = CType(resources.GetObject("sticky.Image"), System.Drawing.Image)
        Me.sticky.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sticky.Name = "sticky"
        Me.sticky.Size = New System.Drawing.Size(85, 22)
        Me.sticky.Text = "Keep on top"
        '
        'tsbFont
        '
        Me.tsbFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFont.Name = "tsbFont"
        Me.tsbFont.Size = New System.Drawing.Size(54, 22)
        Me.tsbFont.Text = "Text size"
        '
        'Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 211)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.rtbMsgChair)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Message"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbMsgChair As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SpeakingListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteFromClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents sticky As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActiveDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
