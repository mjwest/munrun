<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveClose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveClose))
        Me.btnSaveBeforeQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnCancelQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaveBeforeQuit
        '
        Me.btnSaveBeforeQuit.BackColor = System.Drawing.Color.White
        Me.btnSaveBeforeQuit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBeforeQuit.Image = CType(resources.GetObject("btnSaveBeforeQuit.Image"), System.Drawing.Image)
        Me.btnSaveBeforeQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveBeforeQuit.Location = New System.Drawing.Point(12, 44)
        Me.btnSaveBeforeQuit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveBeforeQuit.Name = "btnSaveBeforeQuit"
        Me.btnSaveBeforeQuit.Size = New System.Drawing.Size(98, 40)
        Me.btnSaveBeforeQuit.TabIndex = 1
        Me.btnSaveBeforeQuit.Text = "Save first"
        Me.btnSaveBeforeQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveBeforeQuit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Do you want to save your Munrun session before quitting?"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.White
        Me.btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), System.Drawing.Image)
        Me.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuit.Location = New System.Drawing.Point(116, 43)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(156, 40)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit without saving "
        Me.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnCancelQuit
        '
        Me.btnCancelQuit.BackColor = System.Drawing.Color.White
        Me.btnCancelQuit.Image = CType(resources.GetObject("btnCancelQuit.Image"), System.Drawing.Image)
        Me.btnCancelQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelQuit.Location = New System.Drawing.Point(278, 44)
        Me.btnCancelQuit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelQuit.Name = "btnCancelQuit"
        Me.btnCancelQuit.Size = New System.Drawing.Size(97, 40)
        Me.btnCancelQuit.TabIndex = 5
        Me.btnCancelQuit.Text = "Don't quit"
        Me.btnCancelQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelQuit.UseVisualStyleBackColor = False
        '
        'SaveClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 96)
        Me.Controls.Add(Me.btnCancelQuit)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveBeforeQuit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaveClose"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Munrun"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveBeforeQuit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnCancelQuit As System.Windows.Forms.Button

End Class
