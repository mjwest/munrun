Public Class SavedVotes


    Private Sub SavedVotes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Munchkin.rtbPersistVoteStore.Text = rtbSavedVotes.Text
    End Sub

    Private Sub SavedVotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rtbSavedVotes.Text = Munchkin.rtbPersistVoteStore.Text
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MessageBox.Show("Are you sure you wish to clear the results?", "Munrun", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            rtbSavedVotes.Clear()
        End If
    End Sub

    Private Sub btnCopyResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyResults.Click
        Clipboard.SetDataObject(rtbSavedVotes.Text, True)
    End Sub

    Private Sub btnExpResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpResults.Click
        Dim sfd As New SaveFileDialog
        sfd.DefaultExt = "*.txt"
        sfd.Filter = "Plain text files|*.txt"

        If sfd.ShowDialog = Windows.Forms.DialogResult.OK And sfd.FileName.Length > 0 Then
            rtbSavedVotes.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub
End Class