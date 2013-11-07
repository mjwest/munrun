<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddToLibrary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddToLibrary))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLibraryTitle = New System.Windows.Forms.TextBox()
        Me.tbLibraryAdd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsbPaste = New System.Windows.Forms.Button()
        Me.lklCancel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Image = CType(resources.GetObject("OK_Button.Image"), System.Drawing.Image)
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(299, 318)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(131, 36)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Add to library"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title"
        '
        'tbLibraryTitle
        '
        Me.tbLibraryTitle.Location = New System.Drawing.Point(53, 6)
        Me.tbLibraryTitle.MaxLength = 50
        Me.tbLibraryTitle.Name = "tbLibraryTitle"
        Me.tbLibraryTitle.Size = New System.Drawing.Size(429, 25)
        Me.tbLibraryTitle.TabIndex = 2
        '
        'tbLibraryAdd
        '
        Me.tbLibraryAdd.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLibraryAdd.Location = New System.Drawing.Point(12, 63)
        Me.tbLibraryAdd.Multiline = True
        Me.tbLibraryAdd.Name = "tbLibraryAdd"
        Me.tbLibraryAdd.Size = New System.Drawing.Size(470, 249)
        Me.tbLibraryAdd.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Text"
        '
        'tsbPaste
        '
        Me.tsbPaste.BackColor = System.Drawing.Color.White
        Me.tsbPaste.Image = CType(resources.GetObject("tsbPaste.Image"), System.Drawing.Image)
        Me.tsbPaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsbPaste.Location = New System.Drawing.Point(12, 318)
        Me.tsbPaste.Name = "tsbPaste"
        Me.tsbPaste.Size = New System.Drawing.Size(169, 36)
        Me.tsbPaste.TabIndex = 5
        Me.tsbPaste.Text = "Paste from clipboard"
        Me.tsbPaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsbPaste.UseVisualStyleBackColor = False
        '
        'lklCancel
        '
        Me.lklCancel.AutoSize = True
        Me.lklCancel.LinkColor = System.Drawing.Color.Red
        Me.lklCancel.Location = New System.Drawing.Point(436, 328)
        Me.lklCancel.Name = "lklCancel"
        Me.lklCancel.Size = New System.Drawing.Size(46, 17)
        Me.lklCancel.TabIndex = 6
        Me.lklCancel.TabStop = True
        Me.lklCancel.Text = "Cancel"
        '
        'AddToLibrary
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.lklCancel
        Me.ClientSize = New System.Drawing.Size(494, 363)
        Me.Controls.Add(Me.lklCancel)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.tsbPaste)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbLibraryAdd)
        Me.Controls.Add(Me.tbLibraryTitle)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddToLibrary"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add to library"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbLibraryTitle As System.Windows.Forms.TextBox
    Friend WithEvents tbLibraryAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tsbPaste As System.Windows.Forms.Button
    Friend WithEvents lklCancel As System.Windows.Forms.LinkLabel

End Class
