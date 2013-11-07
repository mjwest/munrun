Imports System.Windows.Forms

Public Class ShowSponsors


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ShowSponsors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvProposer.SmallImageList = Munchkin.ilFlags
        lvSeconder.SmallImageList = Munchkin.ilFlags
        lvSponsors.SmallImageList = Munchkin.ilFlags
    End Sub

    Public Sub LoadSponsors(ByVal sponsors As SponsorSet)
        lvProposer.Clear()
        lvSeconder.Clear()
        lvSponsors.Clear()

        lvProposer.Columns.Add("", 275, HorizontalAlignment.Left)
        lvSeconder.Columns.Add("", 275, HorizontalAlignment.Left)
        lvSponsors.Columns.Add("", 275, HorizontalAlignment.Left)

        For Each proposer As ListViewItem In sponsors.proposerList
            lvProposer.Items.Add(proposer.Clone)
        Next

        For Each seconder As ListViewItem In sponsors.seconderList
            lvSeconder.Items.Add(seconder.Clone)
        Next

        For Each sponsor As ListViewItem In sponsors.sponsorList
            lvSponsors.Items.Add(sponsor.Clone)
        Next


    End Sub
End Class
