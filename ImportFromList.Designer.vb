<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportFromList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportFromList))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbInstructions = New System.Windows.Forms.ToolStripButton()
        Me.tsbImportInstructions = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tsbClear = New System.Windows.Forms.ToolStripButton()
        Me.tbImportList = New System.Windows.Forms.TextBox()
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInstructions, Me.tsbImportInstructions, Me.PasteToolStripButton, Me.tsbClear})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(394, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbInstructions
        '
        Me.tsbInstructions.Image = CType(resources.GetObject("tsbInstructions.Image"), System.Drawing.Image)
        Me.tsbInstructions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbInstructions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInstructions.Name = "tsbInstructions"
        Me.tsbInstructions.Size = New System.Drawing.Size(76, 22)
        Me.tsbInstructions.Text = "Instructions"
        '
        'tsbImportInstructions
        '
        Me.tsbImportInstructions.Image = CType(resources.GetObject("tsbImportInstructions.Image"), System.Drawing.Image)
        Me.tsbImportInstructions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbImportInstructions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImportInstructions.Name = "tsbImportInstructions"
        Me.tsbImportInstructions.Size = New System.Drawing.Size(115, 22)
        Me.tsbImportInstructions.Text = "Show example input"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(70, 22)
        Me.PasteToolStripButton.Text = "Paste list"
        '
        'tsbClear
        '
        Me.tsbClear.Image = CType(resources.GetObject("tsbClear.Image"), System.Drawing.Image)
        Me.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClear.Name = "tsbClear"
        Me.tsbClear.Size = New System.Drawing.Size(52, 22)
        Me.tsbClear.Text = "Clear"
        '
        'tbImportList
        '
        Me.tbImportList.Location = New System.Drawing.Point(12, 28)
        Me.tbImportList.Multiline = True
        Me.tbImportList.Name = "tbImportList"
        Me.tbImportList.Size = New System.Drawing.Size(370, 321)
        Me.tbImportList.TabIndex = 5
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(333, 363)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(46, 17)
        Me.lklCancel.TabIndex = 26
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCreate.BackColor = System.Drawing.Color.White
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.Location = New System.Drawing.Point(170, 353)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(157, 36)
        Me.btnCreate.TabIndex = 25
        Me.btnCreate.Text = "Add to committee"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'ImportFromList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 393)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.tbImportList)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportFromList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import committee from list"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbImportList As System.Windows.Forms.TextBox
    Friend WithEvents tsbImportInstructions As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbInstructions As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents btnCreate As System.Windows.Forms.Button

End Class
