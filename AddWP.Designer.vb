<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddWP))
        Me.tsWP = New System.Windows.Forms.ToolStrip()
        Me.tsbProvideText = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImportWordMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tslNameWP = New System.Windows.Forms.ToolStripLabel()
        Me.rtbWP = New System.Windows.Forms.RichTextBox()
        Me.btnOKCreateWP = New System.Windows.Forms.Button()
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.tsWP.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsWP
        '
        Me.tsWP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsWP.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsWP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbProvideText, Me.ToolStripLabel1, Me.tslNameWP})
        Me.tsWP.Location = New System.Drawing.Point(0, 0)
        Me.tsWP.Name = "tsWP"
        Me.tsWP.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsWP.Size = New System.Drawing.Size(1018, 25)
        Me.tsWP.TabIndex = 23
        Me.tsWP.Text = "ToolStrip1"
        '
        'tsbProvideText
        '
        Me.tsbProvideText.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportWordMenu, Me.PasteToolStripButton})
        Me.tsbProvideText.Image = CType(resources.GetObject("tsbProvideText.Image"), System.Drawing.Image)
        Me.tsbProvideText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProvideText.Name = "tsbProvideText"
        Me.tsbProvideText.Size = New System.Drawing.Size(110, 22)
        Me.tsbProvideText.Text = " Provide text"
        '
        'ImportWordMenu
        '
        Me.ImportWordMenu.Name = "ImportWordMenu"
        Me.ImportWordMenu.Size = New System.Drawing.Size(222, 22)
        Me.ImportWordMenu.Text = "Import Word document"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(222, 22)
        Me.PasteToolStripButton.Text = "Paste from clipboard"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel1.Text = "    "
        '
        'tslNameWP
        '
        Me.tslNameWP.Name = "tslNameWP"
        Me.tslNameWP.Size = New System.Drawing.Size(97, 22)
        Me.tslNameWP.Text = "Name (Hidden)"
        Me.tslNameWP.Visible = False
        '
        'rtbWP
        '
        Me.rtbWP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbWP.Location = New System.Drawing.Point(12, 28)
        Me.rtbWP.Name = "rtbWP"
        Me.rtbWP.Size = New System.Drawing.Size(994, 454)
        Me.rtbWP.TabIndex = 24
        Me.rtbWP.Text = ""
        '
        'btnOKCreateWP
        '
        Me.btnOKCreateWP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOKCreateWP.BackColor = System.Drawing.Color.White
        Me.btnOKCreateWP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKCreateWP.Image = CType(resources.GetObject("btnOKCreateWP.Image"), System.Drawing.Image)
        Me.btnOKCreateWP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOKCreateWP.Location = New System.Drawing.Point(776, 489)
        Me.btnOKCreateWP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOKCreateWP.Name = "btnOKCreateWP"
        Me.btnOKCreateWP.Size = New System.Drawing.Size(178, 36)
        Me.btnOKCreateWP.TabIndex = 25
        Me.btnOKCreateWP.Text = "Create working paper"
        Me.btnOKCreateWP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOKCreateWP.UseVisualStyleBackColor = False
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(960, 499)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(46, 17)
        Me.lklCancel.TabIndex = 26
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel"
        '
        'AddWP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.lklCancel
        Me.ClientSize = New System.Drawing.Size(1018, 528)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.btnOKCreateWP)
        Me.Controls.Add(Me.rtbWP)
        Me.Controls.Add(Me.tsWP)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddWP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New working paper"
        Me.TopMost = True
        Me.tsWP.ResumeLayout(False)
        Me.tsWP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsWP As System.Windows.Forms.ToolStrip
    Friend WithEvents rtbWP As System.Windows.Forms.RichTextBox
    Friend WithEvents tsbProvideText As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImportWordMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnOKCreateWP As System.Windows.Forms.Button
    Friend WithEvents tslNameWP As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel

End Class
