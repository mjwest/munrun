<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDoc))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.flow = New System.Windows.Forms.FlowLayoutPanel()
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.rtbImportText = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbProvideText = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImportFromWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbProcess = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tslName = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(773, 488)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(184, 36)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Create draft resolution"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'flow
        '
        Me.flow.AutoScroll = True
        Me.flow.Location = New System.Drawing.Point(319, 12)
        Me.flow.Name = "flow"
        Me.flow.Size = New System.Drawing.Size(690, 470)
        Me.flow.TabIndex = 17
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(963, 498)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(46, 17)
        Me.lklCancel.TabIndex = 23
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel"
        '
        'rtbImportText
        '
        Me.rtbImportText.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbImportText.Location = New System.Drawing.Point(12, 50)
        Me.rtbImportText.Multiline = True
        Me.rtbImportText.Name = "rtbImportText"
        Me.rtbImportText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rtbImportText.Size = New System.Drawing.Size(301, 432)
        Me.rtbImportText.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 32)
        Me.Panel1.TabIndex = 25
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbProvideText, Me.tsbProcess, Me.ToolStripLabel2, Me.tslName})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(301, 25)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbProvideText
        '
        Me.tsbProvideText.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportFromWordToolStripMenuItem, Me.PasteToolStripButton})
        Me.tsbProvideText.Image = CType(resources.GetObject("tsbProvideText.Image"), System.Drawing.Image)
        Me.tsbProvideText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProvideText.Name = "tsbProvideText"
        Me.tsbProvideText.Size = New System.Drawing.Size(106, 22)
        Me.tsbProvideText.Text = "Provide text"
        '
        'ImportFromWordToolStripMenuItem
        '
        Me.ImportFromWordToolStripMenuItem.Name = "ImportFromWordToolStripMenuItem"
        Me.ImportFromWordToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ImportFromWordToolStripMenuItem.Text = "Import Word document"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(222, 22)
        Me.PasteToolStripButton.Text = "Paste from clipboard"
        '
        'tsbProcess
        '
        Me.tsbProcess.Image = CType(resources.GetObject("tsbProcess.Image"), System.Drawing.Image)
        Me.tsbProcess.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProcess.Name = "tsbProcess"
        Me.tsbProcess.Size = New System.Drawing.Size(149, 22)
        Me.tsbProcess.Text = " Process into clauses"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel2.Text = "    "
        '
        'tslName
        '
        Me.tslName.Name = "tslName"
        Me.tslName.Size = New System.Drawing.Size(26, 17)
        Me.tslName.Text = "nm"
        Me.tslName.Visible = False
        '
        'AddDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.lklCancel
        Me.ClientSize = New System.Drawing.Size(1018, 528)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rtbImportText)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.flow)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddDoc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New draft resolution"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents flow As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents rtbImportText As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbProvideText As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImportFromWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbProcess As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tslName As System.Windows.Forms.ToolStripLabel

End Class
