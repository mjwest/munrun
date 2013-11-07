Public Class Substantive

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        With Munchkin.vetoPowers
            .Clear()
            For Each i As Object In clbVeto.Items
                If clbVeto.CheckedItems.Contains(i) Then
                    .Add(i.ToString)
                End If
            Next
        End With

        'Munchkin.vetoSubst.Items.Clear()
        'For Each i As Object In clbVeto.Items
        '    Munchkin.vetoSubst.Items.Add(i)
        '    If clbVeto.CheckedItems.Contains(i) Then

        '        Munchkin.vetoSubst.Items(Munchkin.vetoSubst.Items.IndexOfKey(i.ToString)).Checked = True
        '    End If
        'Next

        Munchkin.numberSubst = nudSubst.Value
        Munchkin.allowSubst = cbSubst.Checked
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        If cbSubst.Checked = False Then
            Munchkin.dbVoteType.SelectedIndex = 0 'reset
        End If
        Me.Close()
    End Sub

    Private Sub Substantive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        RefreshList()
        nudSubst.Value = Munchkin.numberSubst
        cbSubst.Checked = Munchkin.allowSubst
        ChangeAllowed()
    End Sub

    Private Sub RefreshList()
        clbVeto.Items.Clear()
        For Each i As ListViewItem In Munchkin.lvVoting.Items
            clbVeto.Items.Add(i.Text)
            If Munchkin.vetoPowers.Contains(i.Text) Then
                clbVeto.SetItemChecked(clbVeto.Items.IndexOf(i.Text), True)
            End If
            'If Munchkin.vetoSubst.CheckedItems.Contains(i) Then
            '    clbVeto.SetItemChecked(Munchkin.vetoSubst.Items.IndexOf(i), True)
            'End If
        Next
    End Sub

    Private Sub ChangeAllowed() Handles cbSubst.CheckedChanged
        If cbSubst.Checked = False Then
            clbVeto.Enabled = False
            nudSubst.Enabled = False
        Else
            clbVeto.Enabled = True
            nudSubst.Enabled = True
        End If
    End Sub

End Class