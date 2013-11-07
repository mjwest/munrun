Imports System.Windows.Forms

Public Class SaveListName

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If tbSaveListName.Text.Contains("@") Or tbSaveListName.Text.Contains("%") Then
            MessageBox.Show("The name of your list contains forbidden characters (@ %).", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SaveListName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbSaveListName.Select()
    End Sub
End Class
