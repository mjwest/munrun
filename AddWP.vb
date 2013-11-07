Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Word = Microsoft.Office.Interop.Word
Imports System.Text.RegularExpressions

Public Class AddWP

    Dim loadDir As String = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)
    Dim loadFilter As Integer = 1
    Public imgkey As String = "" 'image key of proposer's flag, if applicable
    Public imgindex As Integer = Nothing
    Public sponsors As New SponsorSet


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKCreateWP.Click
        Dim rtfStr As String = rtbWP.Rtf
        

        With Munchkin
            .numdocs += 1
            .docAmends.Add(New List(Of Integer)) 'this is clunky. There is no reason for WP to have amendments. However, the indices need to align so WP has to add one too, it will stay empty.
            Dim sponsorsCopy As New SponsorSet
            sponsors.CopyTo(sponsorsCopy)
            .docSponsors.Add(sponsorsCopy) 'add sponsors

            tslNameWP.Text.Replace("|", "-") 'separating character
            If imgkey = "" And imgindex = Nothing Then
                .tsdViewDoc.DropDownItems.Add(tslNameWP.Text + " | " + .numdocs.ToString + " | WP") 'don't use flag
            ElseIf imgkey <> "" Then
                .tsdViewDoc.DropDownItems.Add(tslNameWP.Text + " | " + .numdocs.ToString + " | WP", .ilFlags.Images(imgkey)) 'include flag
            ElseIf imgindex <> Nothing Then
                .tsdViewDoc.DropDownItems.Add(tslNameWP.Text + " | " + .numdocs.ToString + " | WP", .ilFlags.Images(imgindex)) 'include flag
            End If

            .docs.Add(Nothing)
            Dim container As New ArrayList
            container.Add(rtbWP.Rtf)
            .docs.Insert(.numdocs, container)
        End With

        rtbWP.Clear()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PasteFromClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        rtbWP.Paste()
    End Sub

    Private Sub ImportFromWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportWordMenu.Click
        Try
            Dim loadFileDialog As New OpenFileDialog()
            Dim objWord As New Word.Application
            Dim objTempDoc As New Word.Document
            Dim iData As IDataObject

            loadFileDialog.InitialDirectory = loadDir
            loadFileDialog.FilterIndex = loadFilter
            'loadFileDialog.Filter = "Word document (*.doc)|*.doc|Word 2007 document (*.docx)|*.docx"
            loadFileDialog.Filter = "Word document (*.doc, *.docx)|*.doc*"
            '|Rich text format(*.rtf)|*.rtf <- Doesn't handle RTF at present, but RTB can import RTF natively 
            'so maybe have to do an IF etc. to make it do both to handle documents produced on Mac etc.
            loadFileDialog.RestoreDirectory = False

            If loadFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                loadDir = loadFileDialog.FileName 'save user-selected dir and filter for next time
                loadFilter = loadFileDialog.FilterIndex
                objWord.Visible = False
                objTempDoc = objWord.Documents.Open(CType(loadFileDialog.FileName, Object), 1, 1, 0)
                objTempDoc.Content.Copy()
                'copy whole document: allows copying of numbered lists, but will crash if it's a huge document.
                'the alternative is to copy a word or a paragraph at a time, but this breaks numbered lists.
                'considering that this should only be used to import fairly short resolutions, not 40-page documents
                'with pictures, it should be OK.
                iData = Clipboard.GetDataObject
                If iData.GetDataPresent(DataFormats.Text) Then
                    rtbWP.Clear()
                    rtbWP.Paste()
                End If
                Clipboard.Clear()
            End If
            objWord.Quit()
        Catch
            MessageBox.Show("Sorry, the import failed. Try opening the document in Word, copying its text and pasting it in here.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub RemoveImages(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbWP.TextChanged
        rtbWP.Rtf = removeRtfObjects(rtbWP.Rtf)
    End Sub

    Public Function removeRtfObjects(ByVal rtf As String) As String
        'removing {\pict or {\object groups
        Dim pattern As String = "\{\\pict|\{\\object"
        Dim m As Match = Regex.Match(rtf, pattern)
        Do While m.Success
            Dim count As Integer = 1
            For i As Integer = m.Index + 2 To rtf.Length
                If rtf(i) = "{"c Then 'start group
                    count += 1
                ElseIf rtf(i) = "}"c Then 'end group
                    count -= 1
                End If
                If count = 0 Then 'found end of pict/object group
                    rtf = rtf.Remove(m.Index, i - m.Index + 1)
                    Exit For
                End If
            Next
            m = Regex.Match(rtf, pattern) 'go again
        Loop
        Return rtf
    End Function

End Class
