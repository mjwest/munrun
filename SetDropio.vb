Imports System.Windows.Forms

Public Class SetDropio

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'do some validation for characters?
        Munchkin.dropioPage = tbDropio.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SetDropio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbDropio.Text = Munchkin.dropioPage
        tbDropio.Select()
        OK_Button.Enabled = False
    End Sub

    Private Sub tbDropio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDropio.Click
        tbDropio.SelectAll()
    End Sub

    Private Sub tbDropio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDropio.TextChanged
        Dim txt As String = tbDropio.Text
        If tbDropio.TextLength < 7 Or txt.Contains("!") Or txt.Contains(" ") Or txt.Contains("?") Or txt.Contains("|") Or txt.Contains("@") Or txt.Contains(".") Or txt.Contains("^") Or txt.Contains("*") Or txt.Contains(",") Then
            OK_Button.Enabled = False
        Else
            OK_Button.Enabled = True
        End If
    End Sub
End Class
