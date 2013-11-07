<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrarySelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibrarySelect))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sydney (SydMUN)")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sydney Schools' (SUSMUN)")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asia-Pacific (AMUNC)")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Harvard (WorldMUN)")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cambridge (CUIMUN)")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Oxford (OxIMUN)")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rules of Procedure", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Charter of the United Nations")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Statute of the International Court of Justice")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Universal Declaration of Human Rights")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("United Nations", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convention I (Wounded and Sick in the Field)")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convention II (Wounded and Sick at Sea)")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convention III (Prisoners of War)")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Convention IV (Civilians in Wartime)")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Protocol I (Victims of International Conflict)")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Protocol II (Victims of Non-International Conflict)")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Protocol III (Distinctive Emblem)")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Geneva Conventions", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kyoto Protocol")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Treaties", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Your documents")
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.tvLibrary = New System.Windows.Forms.TreeView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.Location = New System.Drawing.Point(305, 351)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(146, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Show document"
        Me.OK_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'tvLibrary
        '
        Me.tvLibrary.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvLibrary.Location = New System.Drawing.Point(15, 30)
        Me.tvLibrary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tvLibrary.Name = "tvLibrary"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Sydney (SydMUN)"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Sydney Schools' (SUSMUN)"
        TreeNode3.Name = "Node3"
        TreeNode3.Text = "Asia-Pacific (AMUNC)"
        TreeNode4.Name = "Node4"
        TreeNode4.Text = "Harvard (WorldMUN)"
        TreeNode5.Name = "Node6"
        TreeNode5.Text = "Cambridge (CUIMUN)"
        TreeNode6.Name = "Node5"
        TreeNode6.Text = "Oxford (OxIMUN)"
        TreeNode7.Checked = True
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "Rules of Procedure"
        TreeNode8.Name = "Node8"
        TreeNode8.Text = "Charter of the United Nations"
        TreeNode9.Name = "Node11"
        TreeNode9.Text = "Statute of the International Court of Justice"
        TreeNode10.Name = "Node13"
        TreeNode10.Text = "Universal Declaration of Human Rights"
        TreeNode11.Name = "Node7"
        TreeNode11.Text = "United Nations"
        TreeNode12.Name = "Node0"
        TreeNode12.Text = "Convention I (Wounded and Sick in the Field)"
        TreeNode13.Name = "Node1"
        TreeNode13.Text = "Convention II (Wounded and Sick at Sea)"
        TreeNode14.Name = "Node2"
        TreeNode14.Text = "Convention III (Prisoners of War)"
        TreeNode15.Name = "Node3"
        TreeNode15.Text = "Convention IV (Civilians in Wartime)"
        TreeNode16.Name = "Node4"
        TreeNode16.Text = "Protocol I (Victims of International Conflict)"
        TreeNode17.Name = "Node5"
        TreeNode17.Text = "Protocol II (Victims of Non-International Conflict)"
        TreeNode18.Name = "Node6"
        TreeNode18.Text = "Protocol III (Distinctive Emblem)"
        TreeNode19.Name = "Node24"
        TreeNode19.Text = "Geneva Conventions"
        TreeNode20.Name = "Node25"
        TreeNode20.Text = "Kyoto Protocol"
        TreeNode21.Name = "Node22"
        TreeNode21.Text = "Treaties"
        TreeNode22.Name = "Custom"
        TreeNode22.Text = "Your documents"
        Me.tvLibrary.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode11, TreeNode21, TreeNode22})
        Me.tvLibrary.PathSeparator = " > "
        Me.tvLibrary.Size = New System.Drawing.Size(488, 311)
        Me.tvLibrary.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 17)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Select a document to display:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(457, 359)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(46, 17)
        Me.lklCancel.TabIndex = 88
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel"
        '
        'LibrarySelect
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 396)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tvLibrary)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LibrarySelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select library document"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents tvLibrary As System.Windows.Forms.TreeView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel

End Class
