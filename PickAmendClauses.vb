Imports System.Windows.Forms

Public Class PickAmendClauses

    Public clauseTexts As New List(Of String)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmendClause.Click
        '  Amender.AddClausePanel(lbAvailableClauses.SelectedIndex)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub PickAmendClauses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'remove clauses that are already in amendment - might need to do this somewhere else
    End Sub

    Private Sub lbAvailableClauses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbAvailableClauses.SelectedIndexChanged
        Dim clauseText As String = clauseTexts(lbAvailableClauses.SelectedIndex)
        tbClauseTextPreview.Text = clauseText.Remove(clauseText.Length - 1, 1)
    End Sub
End Class
