<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClauseMatch
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClauseMatch))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rtbOutdated = New System.Windows.Forms.RichTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnDecideOption = New System.Windows.Forms.Button
        Me.rbKeep = New System.Windows.Forms.RadioButton
        Me.rbDiscard = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnDiscardClause = New System.Windows.Forms.Button
        Me.panelDiscardClause = New System.Windows.Forms.Panel
        Me.cbNewOrig = New System.Windows.Forms.ComboBox
        Me.btnAcceptUpdate = New System.Windows.Forms.Button
        Me.rtbNewOrig = New System.Windows.Forms.RichTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.panelMarkUpdate = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.rtbNewAmend = New System.Windows.Forms.RichTextBox
        Me.cmsMarkupText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsOrig = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDiscardClause.SuspendLayout()
        Me.panelMarkUpdate.SuspendLayout()
        Me.cmsMarkupText.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This amendment seems to refer to an outdated clause." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(625, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "This can happen if you changed or deleted the clause since you last saved the ame" & _
            "ndment. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can manually update the amendment, or just remove this clause and " & _
            "keep the rest of the amendment."
        '
        'rtbOutdated
        '
        Me.rtbOutdated.BackColor = System.Drawing.Color.Gainsboro
        Me.rtbOutdated.Location = New System.Drawing.Point(12, 122)
        Me.rtbOutdated.Name = "rtbOutdated"
        Me.rtbOutdated.ReadOnly = True
        Me.rtbOutdated.Size = New System.Drawing.Size(220, 330)
        Me.rtbOutdated.TabIndex = 4
        Me.rtbOutdated.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Outdated part of amendment"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnDecideOption
        '
        Me.btnDecideOption.BackColor = System.Drawing.Color.White
        Me.btnDecideOption.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecideOption.Image = CType(resources.GetObject("btnDecideOption.Image"), System.Drawing.Image)
        Me.btnDecideOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDecideOption.Location = New System.Drawing.Point(480, 104)
        Me.btnDecideOption.Name = "btnDecideOption"
        Me.btnDecideOption.Size = New System.Drawing.Size(135, 37)
        Me.btnDecideOption.TabIndex = 16
        Me.btnDecideOption.Text = "Help me decide"
        Me.btnDecideOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDecideOption.UseVisualStyleBackColor = False
        '
        'rbKeep
        '
        Me.rbKeep.AutoSize = True
        Me.rbKeep.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbKeep.Location = New System.Drawing.Point(242, 95)
        Me.rbKeep.Name = "rbKeep"
        Me.rbKeep.Size = New System.Drawing.Size(212, 21)
        Me.rbKeep.TabIndex = 17
        Me.rbKeep.TabStop = True
        Me.rbKeep.Text = "Keep this clause and update it"
        Me.rbKeep.UseVisualStyleBackColor = True
        '
        'rbDiscard
        '
        Me.rbDiscard.AutoSize = True
        Me.rbDiscard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDiscard.Location = New System.Drawing.Point(242, 122)
        Me.rbDiscard.Name = "rbDiscard"
        Me.rbDiscard.Size = New System.Drawing.Size(141, 21)
        Me.rbDiscard.TabIndex = 19
        Me.rbDiscard.TabStop = True
        Me.rbDiscard.Text = "Discard this clause"
        Me.rbDiscard.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 51)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "The amendment won't mention this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clause any more. This doesn't delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "anything " & _
            "from the draft resolution."
        '
        'btnDiscardClause
        '
        Me.btnDiscardClause.BackColor = System.Drawing.Color.White
        Me.btnDiscardClause.Image = CType(resources.GetObject("btnDiscardClause.Image"), System.Drawing.Image)
        Me.btnDiscardClause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscardClause.Location = New System.Drawing.Point(45, 6)
        Me.btnDiscardClause.Name = "btnDiscardClause"
        Me.btnDiscardClause.Size = New System.Drawing.Size(163, 52)
        Me.btnDiscardClause.TabIndex = 2
        Me.btnDiscardClause.Text = "Discard this clause" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from amendment"
        Me.btnDiscardClause.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDiscardClause.UseVisualStyleBackColor = False
        '
        'panelDiscardClause
        '
        Me.panelDiscardClause.Controls.Add(Me.btnDiscardClause)
        Me.panelDiscardClause.Controls.Add(Me.Label8)
        Me.panelDiscardClause.Location = New System.Drawing.Point(243, 164)
        Me.panelDiscardClause.Name = "panelDiscardClause"
        Me.panelDiscardClause.Size = New System.Drawing.Size(252, 136)
        Me.panelDiscardClause.TabIndex = 20
        '
        'cbNewOrig
        '
        Me.cbNewOrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNewOrig.FormattingEnabled = True
        Me.cbNewOrig.Location = New System.Drawing.Point(6, 28)
        Me.cbNewOrig.Name = "cbNewOrig"
        Me.cbNewOrig.Size = New System.Drawing.Size(231, 25)
        Me.cbNewOrig.TabIndex = 9
        '
        'btnAcceptUpdate
        '
        Me.btnAcceptUpdate.BackColor = System.Drawing.Color.White
        Me.btnAcceptUpdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptUpdate.Image = CType(resources.GetObject("btnAcceptUpdate.Image"), System.Drawing.Image)
        Me.btnAcceptUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcceptUpdate.Location = New System.Drawing.Point(460, 307)
        Me.btnAcceptUpdate.Name = "btnAcceptUpdate"
        Me.btnAcceptUpdate.Size = New System.Drawing.Size(172, 37)
        Me.btnAcceptUpdate.TabIndex = 6
        Me.btnAcceptUpdate.Text = "Update amendment"
        Me.btnAcceptUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcceptUpdate.UseVisualStyleBackColor = False
        '
        'rtbNewOrig
        '
        Me.rtbNewOrig.BackColor = System.Drawing.Color.Gainsboro
        Me.rtbNewOrig.Location = New System.Drawing.Point(6, 59)
        Me.rtbNewOrig.Name = "rtbNewOrig"
        Me.rtbNewOrig.ReadOnly = True
        Me.rtbNewOrig.Size = New System.Drawing.Size(300, 230)
        Me.rtbNewOrig.TabIndex = 5
        Me.rtbNewOrig.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Choose which clause it refers to"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Update amendment description"
        '
        'panelMarkUpdate
        '
        Me.panelMarkUpdate.Controls.Add(Me.Label5)
        Me.panelMarkUpdate.Controls.Add(Me.rtbNewAmend)
        Me.panelMarkUpdate.Controls.Add(Me.Label3)
        Me.panelMarkUpdate.Controls.Add(Me.Label6)
        Me.panelMarkUpdate.Controls.Add(Me.rtbNewOrig)
        Me.panelMarkUpdate.Controls.Add(Me.btnAcceptUpdate)
        Me.panelMarkUpdate.Controls.Add(Me.cbNewOrig)
        Me.panelMarkUpdate.Location = New System.Drawing.Point(245, 164)
        Me.panelMarkUpdate.Name = "panelMarkUpdate"
        Me.panelMarkUpdate.Size = New System.Drawing.Size(635, 347)
        Me.panelMarkUpdate.TabIndex = 18
        Me.panelMarkUpdate.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(297, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Highlight and type, just like a normal amendment."
        '
        'rtbNewAmend
        '
        Me.rtbNewAmend.Location = New System.Drawing.Point(332, 59)
        Me.rtbNewAmend.Name = "rtbNewAmend"
        Me.rtbNewAmend.Size = New System.Drawing.Size(300, 230)
        Me.rtbNewAmend.TabIndex = 14
        Me.rtbNewAmend.Text = ""
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
        'ClauseMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 523)
        Me.Controls.Add(Me.rbDiscard)
        Me.Controls.Add(Me.panelMarkUpdate)
        Me.Controls.Add(Me.btnDecideOption)
        Me.Controls.Add(Me.rbKeep)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rtbOutdated)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelDiscardClause)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ClauseMatch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Match clause"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDiscardClause.ResumeLayout(False)
        Me.panelDiscardClause.PerformLayout()
        Me.panelMarkUpdate.ResumeLayout(False)
        Me.panelMarkUpdate.PerformLayout()
        Me.cmsMarkupText.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtbOutdated As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDecideOption As System.Windows.Forms.Button
    Friend WithEvents rbKeep As System.Windows.Forms.RadioButton
    Friend WithEvents rbDiscard As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDiscardClause As System.Windows.Forms.Button
    Friend WithEvents panelDiscardClause As System.Windows.Forms.Panel
    Friend WithEvents cbNewOrig As System.Windows.Forms.ComboBox
    Friend WithEvents btnAcceptUpdate As System.Windows.Forms.Button
    Friend WithEvents rtbNewOrig As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelMarkUpdate As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rtbNewAmend As System.Windows.Forms.RichTextBox
    Friend WithEvents cmsMarkupText As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsOrig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
