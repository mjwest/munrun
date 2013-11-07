Imports System.Windows.Forms

Public Class LibrarySelect

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub tvLibrary_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvLibrary.AfterSelect
        If tvLibrary.SelectedNode.Level = 0 Or tvLibrary.SelectedNode.Text = "Geneva Conventions" Then
            OK_Button.Enabled = False
        Else
            OK_Button.Enabled = True
        End If
    End Sub

    'Private Sub tvLibrary_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvLibrary.NodeMouseDoubleClick
    '    If tvLibrary.SelectedNode.Level > 0 And Not tvLibrary.SelectedNode.Text = "Geneva Conventions" Then
    '        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    '        Me.Close()
    '    End If
    'End Sub

End Class
