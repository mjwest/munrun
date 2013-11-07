Imports System.Windows.Forms

Public Class SaveClose

    Private Sub btnSaveBeforeQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBeforeQuit.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub btnCancelQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelQuit.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
