Imports System.Windows.Forms

Public Class WordWarning

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub WordWarning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbDontWarn.Checked = False 'by definition, it has to be false if it's being shown
    End Sub

    Private Sub cbShowWordWarning_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDontWarn.CheckedChanged
        Munchkin.showWordWarning = Not cbDontWarn.Checked
    End Sub
End Class
