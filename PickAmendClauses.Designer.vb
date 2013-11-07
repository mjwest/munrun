<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickAmendClauses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PickAmendClauses))
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.btnAmendClause = New System.Windows.Forms.Button()
        Me.lbAvailableClauses = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbClauseTextPreview = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(435, 359)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(46, 17)
        Me.lklCancel.TabIndex = 8
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel"
        '
        'btnAmendClause
        '
        Me.btnAmendClause.BackColor = System.Drawing.Color.White
        Me.btnAmendClause.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmendClause.Image = CType(resources.GetObject("btnAmendClause.Image"), System.Drawing.Image)
        Me.btnAmendClause.Location = New System.Drawing.Point(213, 349)
        Me.btnAmendClause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAmendClause.Name = "btnAmendClause"
        Me.btnAmendClause.Size = New System.Drawing.Size(216, 36)
        Me.btnAmendClause.TabIndex = 7
        Me.btnAmendClause.Text = "Add clause to amendment"
        Me.btnAmendClause.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAmendClause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAmendClause.UseVisualStyleBackColor = False
        '
        'lbAvailableClauses
        '
        Me.lbAvailableClauses.FormattingEnabled = True
        Me.lbAvailableClauses.ItemHeight = 17
        Me.lbAvailableClauses.Location = New System.Drawing.Point(12, 29)
        Me.lbAvailableClauses.Name = "lbAvailableClauses"
        Me.lbAvailableClauses.Size = New System.Drawing.Size(195, 310)
        Me.lbAvailableClauses.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Choose a clause to amend."
        '
        'tbClauseTextPreview
        '
        Me.tbClauseTextPreview.Location = New System.Drawing.Point(213, 29)
        Me.tbClauseTextPreview.Multiline = True
        Me.tbClauseTextPreview.Name = "tbClauseTextPreview"
        Me.tbClauseTextPreview.ReadOnly = True
        Me.tbClauseTextPreview.Size = New System.Drawing.Size(268, 310)
        Me.tbClauseTextPreview.TabIndex = 11
        '
        'PickAmendClauses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 394)
        Me.Controls.Add(Me.tbClauseTextPreview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbAvailableClauses)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.btnAmendClause)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PickAmendClauses"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Amend existing clause"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAmendClause As System.Windows.Forms.Button
    Friend WithEvents lbAvailableClauses As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbClauseTextPreview As System.Windows.Forms.TextBox

End Class
