Imports System.Windows.Forms

Public Class LoadList

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LoadList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbLoadSpkrs.Items.Clear()
        For Each i As Object In Munchkin.lbSaveSpkrNames.Items
            cbLoadSpkrs.Items.Add(i)
        Next
        cbLoadSpkrs.SelectedIndex = 0
    End Sub
End Class
