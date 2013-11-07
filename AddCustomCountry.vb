Imports System.Windows.Forms

Public Class AddCustomCountry

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If (tbCustomCountry.Text <> "") Then
            If tbCustomCountry.Text.Contains(",") Or tbCustomCountry.Text.Contains("@") Or tbCustomCountry.Text.Contains("%") Then
                MessageBox.Show("The name of your custom delegate contains forbidden characters (, @ %).", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Munchkin.lvAvailable.Items.ContainsKey(tbCustomCountry.Text) Then
                MessageBox.Show("This delegate already exists.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim newDelegate As New ListViewItem
                newDelegate.Name = tbCustomCountry.Text
                newDelegate.Text = tbCustomCountry.Text
                newDelegate.Group = Munchkin.lvAvailable.Groups("Custom")
                newDelegate.ImageKey = "munrun-flag.png"
                Munchkin.lvAvailable.Items.Add(newDelegate)
                newDelegate.Selected = True
                newDelegate.EnsureVisible()


                'With Munchkin.lvAvailable

                '    .Items.Add(tbCustomCountry.Text)
                '    .SelectedItems.Clear()
                '    '  .Items(.Items.IndexOfKey(tbCustomCountry.Text)).Selected = True
                'End With
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.Close()
    End Sub

    Private Sub AddCustomCountry_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        tbCustomCountry.Select()
    End Sub
End Class
