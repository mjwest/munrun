Public Class NameAndSponsor
    Public mySponsors As New SponsorSet

    Private Sub NameAndSponsor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvSponsors.SmallImageList = Munchkin.ilFlags
        ResetLists()
        tbDocName.Clear()
        tbDocName.Select()
        Me.Height = 192
        panSponsorButton.Show()
        btnOK.Enabled = False
    End Sub

    Public Sub ResetLists()
        'clear current states
        mySponsors.proposerList.Clear()
        mySponsors.seconderList.Clear()
        mySponsors.sponsorList.Clear()

        lvSponsors.Clear()
        lvSponsors.Columns.Add("", 275, HorizontalAlignment.Left) 'add columns back

        'collect all countries - NGOs not allowed to sponsor drafts
        For Each i As ListViewItem In Munchkin.lvVoting.Items
            Dim k As New ListViewItem
            k = i.Clone()
            k.Name = i.Name
            k.Checked = False
            lvSponsors.Items.Add(k)
        Next
        For Each i As ListViewItem In Munchkin.lvObserver.Items
            Dim k As New ListViewItem
            k = i.Clone()
            k.Name = i.Name
            k.Checked = False
            lvSponsors.Items.Add(k)
        Next
        'lvSponsors.ShowGroups = False
        'lvSponsors.View = View.List
        '  lvSponsors.RedrawItems(0, lvSponsors.Items.Count - 1, False)
    End Sub

    Public Sub AmendMode()
        Me.Text = "New amendment"
        lblInstructions.Text = "Please enter a name to help you identify this amendment."
        lklCancel.Text = "Cancel amendment"
        panSponsorButton.Enabled = False
    End Sub

    Public Sub ResMode()
        Me.Text = "New draft resolution"
        lblInstructions.Text = "Please enter a name to help you identify this draft resolution."
        lklCancel.Text = "Cancel document"
        panSponsorButton.Enabled = True
    End Sub

    Public Sub WPMode()
        Me.Text = "New working paper"
        lblInstructions.Text = "Please enter a name to help you identify this working paper."
        lklCancel.Text = "Cancel document"
        panSponsorButton.Enabled = True
    End Sub

    Private Sub ClickOK() Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()




        'Dim sponsors As String = ""
        'If proposers.Count > 0 Then
        '    sponsors += "Proposer: " + proposers.SelectedItem.ToString

        '    If cbSeconder.SelectedItem <> Nothing Or lbSponsors.Items.Count > 0 Then
        '        'add separator
        '        sponsors += " | "
        '    End If
        'End If
        'If cbSeconder.SelectedItem <> Nothing Then
        '    sponsors += "Seconder: " + cbSeconder.SelectedItem.ToString
        '    If lbSponsors.Items.Count > 0 Then
        '        'add separator
        '        sponsors += " | "
        '    End If
        'End If
        'If lbSponsors.Items.Count > 0 Then
        '    sponsors += "Sponsors: "
        '    For Each sponsor As Object In lbSponsors.Items
        '        sponsors += sponsor.ToString
        '        If lbSponsors.Items.IndexOf(sponsor) < lbSponsors.Items.Count - 1 Then
        '            sponsors += ", "
        '        End If
        '    Next
        'End If
        'If sponsors.Length > 100 Then 'have to truncate
        '    sponsors = sponsors.Remove(100, sponsors.Length - 100)
        '    sponsors += "..."

        'End If

        'MessageBox.Show(sponsors.Length)
        'Munchkin.sponsorsList = sponsors
    End Sub

    Private Sub btnDisplaySponsors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplaySponsors.Click
        'show sponsor area
        Me.Height = 453
        panSponsorButton.Hide()
    End Sub

    Private Sub btnClearSponsors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSponsors.Click
        'Reset lists to move everyone back to original spots
        ResetLists()
    End Sub

    Private Sub tbDocName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDocName.TextChanged
        If tbDocName.TextLength > 0 And Not ContainsForbiddenCharacters(tbDocName.Text) Then
            lblForbidden.Hide()
            btnOK.Enabled = True
        Else
            btnOK.Enabled = False
            If ContainsForbiddenCharacters(tbDocName.Text) Then
                lblForbidden.Show()
            End If
        End If
    End Sub

    Private Function ContainsForbiddenCharacters(ByVal str As String)
        Dim forbidden As New List(Of String)
        forbidden.Add(":")
        forbidden.Add("\")
        forbidden.Add("/")
        forbidden.Add("|")
        forbidden.Add("<")
        forbidden.Add(">")
        forbidden.Add("?")
        forbidden.Add("*")
        ' TODO: add " as forbidden character (need to escape it somehow)

        Dim forbiddenFound As Boolean = False
        For Each character As String In forbidden
            If str.Contains(character) Then
                forbiddenFound = True
                Exit For
            End If
        Next

        Return forbiddenFound

    End Function


    Private Sub tbDocName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbDocName.KeyDown
        If e.KeyCode = Keys.Enter And btnOK.Enabled = True Then
            'proceed as if OK button was clicked
            ClickOK()
        End If
    End Sub

    Private Sub NameAndSponsor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Height = 453
    End Sub

    Private Sub btnMakeProposer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeProposer.Click
        For Each country As ListViewItem In lvSponsors.CheckedItems

            country.BackColor = Color.LimeGreen
            country.ForeColor = Color.White
            country.Checked = False

            mySponsors.proposerList.Add(country.Clone())

            'remove as seconder or sponsor
            RemoveFromOtherList(mySponsors.seconderList, country.Text)
            RemoveFromOtherList(mySponsors.sponsorList, country.Text)


        Next
    End Sub

    Private Sub btnMakeSeconder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeSeconder.Click
        For Each country As ListViewItem In lvSponsors.CheckedItems

            country.BackColor = Color.RoyalBlue
            country.ForeColor = Color.White
            country.Checked = False

            mySponsors.seconderList.Add(country.Clone())

            'remove as proposer or sponsor
            RemoveFromOtherList(mySponsors.proposerList, country.Text)
            RemoveFromOtherList(mySponsors.sponsorList, country.Text)
        Next
    End Sub

    Private Sub btnMakeSponsor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeSponsor.Click
        For Each country As ListViewItem In lvSponsors.CheckedItems

            country.BackColor = Color.Gainsboro
            country.ForeColor = Color.Black
            country.Checked = False

            mySponsors.sponsorList.Add(country.Clone())

            'remove as proposer or seconder
            RemoveFromOtherList(mySponsors.proposerList, country.Text)
            RemoveFromOtherList(mySponsors.seconderList, country.Text)

        Next
    End Sub

    Private Sub RemoveFromOtherList(ByRef listToCheck As List(Of ListViewItem), ByVal country As String)
        Dim alreadyExists As Integer = ListContainsKey(listToCheck, country)
        If alreadyExists > -1 Then
            listToCheck.RemoveAt(alreadyExists)
        End If
    End Sub

    Private Function ListContainsKey(ByRef listItems As List(Of ListViewItem), ByVal key As String)
        Dim index As Integer = -1
        For Each i As ListViewItem In listItems
            If i.Text = key Then
                index = listItems.IndexOf(i)
                Exit For
            End If
        Next

        Return index
    End Function

    Private Sub lvSponsors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvSponsors.SelectedIndexChanged
        For Each i As ListViewItem In lvSponsors.SelectedItems
            i.Checked = Not i.Checked
        Next
    End Sub

    Private Sub lklCancel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklCancel.LinkClicked
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class