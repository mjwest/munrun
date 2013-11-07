<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameAndSponsor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NameAndSponsor))
        Dim ListViewGroup13 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("African group", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup14 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Asian group", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup15 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Western European and Others group", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup16 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Latin American and Caribbean group", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup17 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Eastern European group", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup18 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Delegates you created", System.Windows.Forms.HorizontalAlignment.Left)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClearSponsors = New System.Windows.Forms.Button()
        Me.tbDocName = New System.Windows.Forms.TextBox()
        Me.btnDisplaySponsors = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvSponsors = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMakeSponsor = New System.Windows.Forms.Button()
        Me.btnMakeSeconder = New System.Windows.Forms.Button()
        Me.btnMakeProposer = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblForbidden = New System.Windows.Forms.Label()
        Me.panSponsorButton = New System.Windows.Forms.Panel()
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.panSponsorButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(410, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Clear all"
        '
        'btnClearSponsors
        '
        Me.btnClearSponsors.BackColor = System.Drawing.Color.White
        Me.btnClearSponsors.BackgroundImage = CType(resources.GetObject("btnClearSponsors.BackgroundImage"), System.Drawing.Image)
        Me.btnClearSponsors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearSponsors.Location = New System.Drawing.Point(372, 210)
        Me.btnClearSponsors.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClearSponsors.Name = "btnClearSponsors"
        Me.btnClearSponsors.Size = New System.Drawing.Size(36, 36)
        Me.btnClearSponsors.TabIndex = 71
        Me.btnClearSponsors.UseVisualStyleBackColor = False
        '
        'tbDocName
        '
        Me.tbDocName.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDocName.Location = New System.Drawing.Point(12, 29)
        Me.tbDocName.Name = "tbDocName"
        Me.tbDocName.Size = New System.Drawing.Size(513, 43)
        Me.tbDocName.TabIndex = 77
        '
        'btnDisplaySponsors
        '
        Me.btnDisplaySponsors.BackColor = System.Drawing.Color.White
        Me.btnDisplaySponsors.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplaySponsors.Image = CType(resources.GetObject("btnDisplaySponsors.Image"), System.Drawing.Image)
        Me.btnDisplaySponsors.Location = New System.Drawing.Point(3, 3)
        Me.btnDisplaySponsors.Name = "btnDisplaySponsors"
        Me.btnDisplaySponsors.Size = New System.Drawing.Size(48, 48)
        Me.btnDisplaySponsors.TabIndex = 78
        Me.btnDisplaySponsors.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(12, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(331, 17)
        Me.lblInstructions.TabIndex = 79
        Me.lblInstructions.Text = "Please enter a name to help you identify this document."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Add sponsors"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "(optional)"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.White
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(388, 75)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(137, 36)
        Me.btnOK.TabIndex = 82
        Me.btnOK.Text = "Use this name"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvSponsors)
        Me.GroupBox1.Controls.Add(Me.btnMakeSponsor)
        Me.GroupBox1.Controls.Add(Me.btnMakeSeconder)
        Me.GroupBox1.Controls.Add(Me.btnMakeProposer)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnClearSponsors)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 252)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sponsors"
        '
        'lvSponsors
        '
        Me.lvSponsors.CheckBoxes = True
        Me.lvSponsors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvSponsors.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup13.Header = "African group"
        ListViewGroup13.Name = "African"
        ListViewGroup14.Header = "Asian group"
        ListViewGroup14.Name = "Asian"
        ListViewGroup15.Header = "Western European and Others group"
        ListViewGroup15.Name = "WEOG"
        ListViewGroup16.Header = "Latin American and Caribbean group"
        ListViewGroup16.Name = "GRULAC"
        ListViewGroup17.Header = "Eastern European group"
        ListViewGroup17.Name = "Eastern European"
        ListViewGroup18.Header = "Delegates you created"
        ListViewGroup18.Name = "Custom"
        Me.lvSponsors.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup13, ListViewGroup14, ListViewGroup15, ListViewGroup16, ListViewGroup17, ListViewGroup18})
        Me.lvSponsors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvSponsors.Location = New System.Drawing.Point(66, 65)
        Me.lvSponsors.MultiSelect = False
        Me.lvSponsors.Name = "lvSponsors"
        Me.lvSponsors.ShowGroups = False
        Me.lvSponsors.Size = New System.Drawing.Size(300, 181)
        Me.lvSponsors.TabIndex = 87
        Me.lvSponsors.UseCompatibleStateImageBehavior = False
        Me.lvSponsors.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Click countries to select"
        Me.ColumnHeader1.Width = 275
        '
        'btnMakeSponsor
        '
        Me.btnMakeSponsor.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMakeSponsor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeSponsor.Location = New System.Drawing.Point(372, 147)
        Me.btnMakeSponsor.Name = "btnMakeSponsor"
        Me.btnMakeSponsor.Size = New System.Drawing.Size(76, 36)
        Me.btnMakeSponsor.TabIndex = 87
        Me.btnMakeSponsor.Text = "Sponsor"
        Me.btnMakeSponsor.UseVisualStyleBackColor = False
        '
        'btnMakeSeconder
        '
        Me.btnMakeSeconder.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnMakeSeconder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeSeconder.ForeColor = System.Drawing.Color.White
        Me.btnMakeSeconder.Location = New System.Drawing.Point(372, 105)
        Me.btnMakeSeconder.Name = "btnMakeSeconder"
        Me.btnMakeSeconder.Size = New System.Drawing.Size(76, 36)
        Me.btnMakeSeconder.TabIndex = 86
        Me.btnMakeSeconder.Text = "Seconder"
        Me.btnMakeSeconder.UseVisualStyleBackColor = False
        '
        'btnMakeProposer
        '
        Me.btnMakeProposer.BackColor = System.Drawing.Color.LimeGreen
        Me.btnMakeProposer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeProposer.ForeColor = System.Drawing.Color.White
        Me.btnMakeProposer.Location = New System.Drawing.Point(372, 63)
        Me.btnMakeProposer.Name = "btnMakeProposer"
        Me.btnMakeProposer.Size = New System.Drawing.Size(76, 36)
        Me.btnMakeProposer.TabIndex = 85
        Me.btnMakeProposer.Text = "Proposer"
        Me.btnMakeProposer.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(507, 34)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Tick one or more countries, then set which type of sponsor they are. You can have" & _
            " as " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "many as you like of each type."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblForbidden
        '
        Me.lblForbidden.AutoSize = True
        Me.lblForbidden.BackColor = System.Drawing.Color.OrangeRed
        Me.lblForbidden.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForbidden.ForeColor = System.Drawing.Color.White
        Me.lblForbidden.Location = New System.Drawing.Point(12, 75)
        Me.lblForbidden.Name = "lblForbidden"
        Me.lblForbidden.Size = New System.Drawing.Size(339, 22)
        Me.lblForbidden.TabIndex = 84
        Me.lblForbidden.Text = "Names cannot contain these characters: | \ / ? : *  < >"
        Me.lblForbidden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblForbidden.UseCompatibleTextRendering = True
        Me.lblForbidden.Visible = False
        '
        'panSponsorButton
        '
        Me.panSponsorButton.Controls.Add(Me.btnDisplaySponsors)
        Me.panSponsorButton.Controls.Add(Me.Label5)
        Me.panSponsorButton.Controls.Add(Me.Label7)
        Me.panSponsorButton.Location = New System.Drawing.Point(15, 106)
        Me.panSponsorButton.Name = "panSponsorButton"
        Me.panSponsorButton.Size = New System.Drawing.Size(157, 61)
        Me.panSponsorButton.TabIndex = 85
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(385, 114)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(108, 17)
        Me.lklCancel.TabIndex = 86
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel document"
        '
        'NameAndSponsor
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.lklCancel
        Me.ClientSize = New System.Drawing.Size(535, 426)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.panSponsorButton)
        Me.Controls.Add(Me.lblForbidden)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.tbDocName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NameAndSponsor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New document"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panSponsorButton.ResumeLayout(False)
        Me.panSponsorButton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClearSponsors As System.Windows.Forms.Button
    Friend WithEvents tbDocName As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplaySponsors As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblForbidden As System.Windows.Forms.Label
    Friend WithEvents btnMakeSponsor As System.Windows.Forms.Button
    Friend WithEvents btnMakeSeconder As System.Windows.Forms.Button
    Friend WithEvents btnMakeProposer As System.Windows.Forms.Button
    Friend WithEvents panSponsorButton As System.Windows.Forms.Panel
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents lvSponsors As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
