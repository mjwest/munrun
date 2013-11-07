<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Amendments
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Amendments))
        Me.flowAmendOrig = New System.Windows.Forms.FlowLayoutPanel
        Me.flowAmendDesc = New System.Windows.Forms.FlowLayoutPanel
        Me.flowPropText = New System.Windows.Forms.FlowLayoutPanel
        Me.panelClauses = New System.Windows.Forms.Panel
        Me.panDesc = New System.Windows.Forms.Panel
        Me.lbAmend = New System.Windows.Forms.Label
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.tsbDescPaste = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SetFontSizeToolStripMenuItem = New System.Windows.Forms.ToolStripDropDownButton
        Me.SmallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.cmsMarkupText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOrig = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip
        Me.tslAmendName = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tslDocName = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbSaveAmendment = New System.Windows.Forms.ToolStripButton
        Me.FailToolStripMenuItem = New System.Windows.Forms.ToolStripButton
        Me.PassToolStripMenuItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.lbProp = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbPickClauses = New System.Windows.Forms.ToolStripButton
        Me.tsbAddClause = New System.Windows.Forms.ToolStripButton
        Me.lbOrig = New System.Windows.Forms.Label
        Me.panOrig = New System.Windows.Forms.Panel
        Me.panProp = New System.Windows.Forms.Panel
        Me.panelClauses.SuspendLayout()
        Me.panDesc.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.cmsMarkupText.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.panOrig.SuspendLayout()
        Me.panProp.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowAmendOrig
        '
        Me.flowAmendOrig.Location = New System.Drawing.Point(12, 4)
        Me.flowAmendOrig.Name = "flowAmendOrig"
        Me.flowAmendOrig.Size = New System.Drawing.Size(308, 100)
        Me.flowAmendOrig.TabIndex = 5
        '
        'flowAmendDesc
        '
        Me.flowAmendDesc.Location = New System.Drawing.Point(345, 4)
        Me.flowAmendDesc.Name = "flowAmendDesc"
        Me.flowAmendDesc.Size = New System.Drawing.Size(308, 100)
        Me.flowAmendDesc.TabIndex = 5
        '
        'flowPropText
        '
        Me.flowPropText.BackColor = System.Drawing.SystemColors.Control
        Me.flowPropText.Location = New System.Drawing.Point(676, 4)
        Me.flowPropText.Name = "flowPropText"
        Me.flowPropText.Size = New System.Drawing.Size(308, 100)
        Me.flowPropText.TabIndex = 5
        '
        'panelClauses
        '
        Me.panelClauses.AutoScroll = True
        Me.panelClauses.Controls.Add(Me.flowPropText)
        Me.panelClauses.Controls.Add(Me.flowAmendDesc)
        Me.panelClauses.Controls.Add(Me.flowAmendOrig)
        Me.panelClauses.Location = New System.Drawing.Point(9, 80)
        Me.panelClauses.Name = "panelClauses"
        Me.panelClauses.Size = New System.Drawing.Size(1006, 455)
        Me.panelClauses.TabIndex = 14
        '
        'panDesc
        '
        Me.panDesc.Controls.Add(Me.lbAmend)
        Me.panDesc.Controls.Add(Me.ToolStrip3)
        Me.panDesc.Location = New System.Drawing.Point(357, 28)
        Me.panDesc.Name = "panDesc"
        Me.panDesc.Size = New System.Drawing.Size(308, 50)
        Me.panDesc.TabIndex = 15
        '
        'lbAmend
        '
        Me.lbAmend.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbAmend.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAmend.ForeColor = System.Drawing.Color.White
        Me.lbAmend.Location = New System.Drawing.Point(0, 0)
        Me.lbAmend.Name = "lbAmend"
        Me.lbAmend.Size = New System.Drawing.Size(308, 25)
        Me.lbAmend.TabIndex = 18
        Me.lbAmend.Text = "Amendment changes"
        Me.lbAmend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDescPaste, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.SetFontSizeToolStripMenuItem, Me.ToolStripButton1})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(308, 25)
        Me.ToolStrip3.TabIndex = 7
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'tsbDescPaste
        '
        Me.tsbDescPaste.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbDescPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDescPaste.Image = CType(resources.GetObject("tsbDescPaste.Image"), System.Drawing.Image)
        Me.tsbDescPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDescPaste.Name = "tsbDescPaste"
        Me.tsbDescPaste.Size = New System.Drawing.Size(23, 22)
        Me.tsbDescPaste.Text = "&Paste"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "&Copy"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "C&ut"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'SetFontSizeToolStripMenuItem
        '
        Me.SetFontSizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SetFontSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmallToolStripMenuItem, Me.MediumToolStripMenuItem, Me.LargeToolStripMenuItem, Me.HugeToolStripMenuItem})
        Me.SetFontSizeToolStripMenuItem.Image = CType(resources.GetObject("SetFontSizeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetFontSizeToolStripMenuItem.Name = "SetFontSizeToolStripMenuItem"
        Me.SetFontSizeToolStripMenuItem.Size = New System.Drawing.Size(82, 22)
        Me.SetFontSizeToolStripMenuItem.Text = "Font size"
        '
        'SmallToolStripMenuItem
        '
        Me.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem"
        Me.SmallToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SmallToolStripMenuItem.Text = "Small"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Checked = True
        Me.MediumToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MediumToolStripMenuItem.Text = "Medium"
        Me.MediumToolStripMenuItem.ToolTipText = "Consider reducing the text size."
        '
        'LargeToolStripMenuItem
        '
        Me.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem"
        Me.LargeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LargeToolStripMenuItem.Text = "Large"
        '
        'HugeToolStripMenuItem
        '
        Me.HugeToolStripMenuItem.Name = "HugeToolStripMenuItem"
        Me.HugeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HugeToolStripMenuItem.Text = "Huge"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButton1.Text = "Instructions"
        Me.ToolStripButton1.Visible = False
        '
        'cmsMarkupText
        '
        Me.cmsMarkupText.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAdd, Me.cmsDelete, Me.cmsOrig, Me.ToolStripSeparator2, Me.CancelToolStripMenuItem})
        Me.cmsMarkupText.Name = "ContextMenuStrip1"
        Me.cmsMarkupText.Size = New System.Drawing.Size(136, 98)
        '
        'cmsAdd
        '
        Me.cmsAdd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsAdd.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cmsAdd.Image = CType(resources.GetObject("cmsAdd.Image"), System.Drawing.Image)
        Me.cmsAdd.Name = "cmsAdd"
        Me.cmsAdd.Size = New System.Drawing.Size(135, 22)
        Me.cmsAdd.Text = "Addition"
        '
        'cmsDelete
        '
        Me.cmsDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsDelete.ForeColor = System.Drawing.Color.OrangeRed
        Me.cmsDelete.Image = CType(resources.GetObject("cmsDelete.Image"), System.Drawing.Image)
        Me.cmsDelete.Name = "cmsDelete"
        Me.cmsDelete.Size = New System.Drawing.Size(135, 22)
        Me.cmsDelete.Text = "Deletion"
        '
        'cmsOrig
        '
        Me.cmsOrig.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsOrig.Image = CType(resources.GetObject("cmsOrig.Image"), System.Drawing.Image)
        Me.cmsOrig.Name = "cmsOrig"
        Me.cmsOrig.Size = New System.Drawing.Size(135, 22)
        Me.cmsOrig.Text = "Original"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(132, 6)
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslAmendName, Me.ToolStripLabel1, Me.tslDocName, Me.ToolStripSeparator1, Me.tsbSaveAmendment, Me.FailToolStripMenuItem, Me.PassToolStripMenuItem})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip4.Size = New System.Drawing.Size(1018, 25)
        Me.ToolStrip4.TabIndex = 22
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'tslAmendName
        '
        Me.tslAmendName.Name = "tslAmendName"
        Me.tslAmendName.Size = New System.Drawing.Size(107, 22)
        Me.tslAmendName.Text = "Amendment name"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripLabel1.Text = "to document: "
        '
        'tslDocName
        '
        Me.tslDocName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tslDocName.Name = "tslDocName"
        Me.tslDocName.Size = New System.Drawing.Size(96, 22)
        Me.tslDocName.Text = "Document name"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSaveAmendment
        '
        Me.tsbSaveAmendment.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSaveAmendment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbSaveAmendment.Image = CType(resources.GetObject("tsbSaveAmendment.Image"), System.Drawing.Image)
        Me.tsbSaveAmendment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSaveAmendment.Name = "tsbSaveAmendment"
        Me.tsbSaveAmendment.Size = New System.Drawing.Size(95, 22)
        Me.tsbSaveAmendment.Text = "Save for later"
        '
        'FailToolStripMenuItem
        '
        Me.FailToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FailToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FailToolStripMenuItem.Image = CType(resources.GetObject("FailToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FailToolStripMenuItem.Name = "FailToolStripMenuItem"
        Me.FailToolStripMenuItem.Size = New System.Drawing.Size(45, 22)
        Me.FailToolStripMenuItem.Text = "Fail"
        '
        'PassToolStripMenuItem
        '
        Me.PassToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PassToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassToolStripMenuItem.Image = CType(resources.GetObject("PassToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PassToolStripMenuItem.Name = "PassToolStripMenuItem"
        Me.PassToolStripMenuItem.Size = New System.Drawing.Size(50, 22)
        Me.PassToolStripMenuItem.Text = "Pass"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'lbProp
        '
        Me.lbProp.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbProp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProp.ForeColor = System.Drawing.Color.White
        Me.lbProp.Location = New System.Drawing.Point(1, 0)
        Me.lbProp.Name = "lbProp"
        Me.lbProp.Size = New System.Drawing.Size(308, 25)
        Me.lbProp.TabIndex = 18
        Me.lbProp.Text = "Resulting text"
        Me.lbProp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbPickClauses, Me.tsbAddClause})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(308, 25)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbPickClauses
        '
        Me.tsbPickClauses.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbPickClauses.Image = CType(resources.GetObject("tsbPickClauses.Image"), System.Drawing.Image)
        Me.tsbPickClauses.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPickClauses.Name = "tsbPickClauses"
        Me.tsbPickClauses.Size = New System.Drawing.Size(152, 22)
        Me.tsbPickClauses.Text = "Pick clauses to amend"
        '
        'tsbAddClause
        '
        Me.tsbAddClause.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbAddClause.Image = CType(resources.GetObject("tsbAddClause.Image"), System.Drawing.Image)
        Me.tsbAddClause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddClause.Name = "tsbAddClause"
        Me.tsbAddClause.Size = New System.Drawing.Size(122, 22)
        Me.tsbAddClause.Text = "Add a new clause"
        '
        'lbOrig
        '
        Me.lbOrig.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbOrig.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOrig.ForeColor = System.Drawing.Color.White
        Me.lbOrig.Location = New System.Drawing.Point(0, -1)
        Me.lbOrig.Name = "lbOrig"
        Me.lbOrig.Size = New System.Drawing.Size(308, 25)
        Me.lbOrig.TabIndex = 18
        Me.lbOrig.Text = "Original text"
        Me.lbOrig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panOrig
        '
        Me.panOrig.Controls.Add(Me.lbOrig)
        Me.panOrig.Controls.Add(Me.ToolStrip2)
        Me.panOrig.Location = New System.Drawing.Point(22, 28)
        Me.panOrig.Name = "panOrig"
        Me.panOrig.Size = New System.Drawing.Size(308, 50)
        Me.panOrig.TabIndex = 13
        '
        'panProp
        '
        Me.panProp.Controls.Add(Me.lbProp)
        Me.panProp.Location = New System.Drawing.Point(685, 28)
        Me.panProp.Name = "panProp"
        Me.panProp.Size = New System.Drawing.Size(308, 50)
        Me.panProp.TabIndex = 0
        '
        'Amendments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 543)
        Me.Controls.Add(Me.panProp)
        Me.Controls.Add(Me.ToolStrip4)
        Me.Controls.Add(Me.panDesc)
        Me.Controls.Add(Me.panelClauses)
        Me.Controls.Add(Me.panOrig)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "Amendments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amendment"
        Me.panelClauses.ResumeLayout(False)
        Me.panDesc.ResumeLayout(False)
        Me.panDesc.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.cmsMarkupText.ResumeLayout(False)
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.panOrig.ResumeLayout(False)
        Me.panOrig.PerformLayout()
        Me.panProp.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flowAmendOrig As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flowAmendDesc As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flowPropText As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panelClauses As System.Windows.Forms.Panel
    Friend WithEvents panDesc As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbDescPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsMarkupText As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOrig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbAmend As System.Windows.Forms.Label
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tslDocName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSaveAmendment As System.Windows.Forms.ToolStripButton
    Friend WithEvents SetFontSizeToolStripMenuItem As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SmallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HugeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FailToolStripMenuItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PassToolStripMenuItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslAmendName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbProp As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbPickClauses As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAddClause As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbOrig As System.Windows.Forms.Label
    Friend WithEvents panOrig As System.Windows.Forms.Panel
    Friend WithEvents panProp As System.Windows.Forms.Panel
End Class
