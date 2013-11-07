Imports System.Windows.Forms

Public Class ImportFromList

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        tbImportList.Paste()
    End Sub

    Private Sub tsbImportInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImportInstructions.Click
        tbImportList.AppendText("Australia" + Environment.NewLine)
        tbImportList.AppendText("China" + Environment.NewLine)
        tbImportList.AppendText("Denmark" + Environment.NewLine)
        tbImportList.AppendText("NGO Amnesty International" + Environment.NewLine)
        tbImportList.AppendText("Nigeria" + Environment.NewLine)
        tbImportList.AppendText("OBS Sudan" + Environment.NewLine)
    End Sub

    Private Sub tsbInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbInstructions.Click
        Dim nl As String = Environment.NewLine
        MessageBox.Show("- Enter one delegate per line." + nl + _
                        "- Paste from a spreadsheet column for quick input." + nl + _
                        "- Use prefix NGO for non-government organisations." + nl + _
                        "- Use prefix OBS for observer states." + nl + _
                        "- Prefixes should be separated from the delegate's name by a space." + nl + _
                        "- Click 'Show example input' to see the correct format.", _
                        "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tsbClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClear.Click
        tbImportList.Clear()
    End Sub
End Class
