Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Word = Microsoft.Office.Interop.Word

Public Class AddDoc

    Dim loadDir As String = "C:\"
    Dim loadFilter As Integer = 1
    Public imgkey As String = "" 'image key of proposer's flag, if applicable
    Public imgindex As Integer = Nothing
    Public sponsors As New SponsorSet
    Private HasImage As New List(Of Boolean)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        With Munchkin
            .numdocs = .numdocs + 1

            .docAmends.Add(New List(Of Integer))
            Dim sponsorsCopy As New SponsorSet
            sponsors.CopyTo(sponsorsCopy)
            .docSponsors.Add(sponsorsCopy) 'add sponsors

            tslName.Text.Replace("|", "-") ' | is the separating character
            If imgkey = "" And imgindex = Nothing Then
                .tsdViewDoc.DropDownItems.Add(tslName.Text + " | " + .numdocs.ToString + " | DR") 'don't use flag
            ElseIf imgkey <> "" Then
                .tsdViewDoc.DropDownItems.Add(tslName.Text + " | " + .numdocs.ToString + " | DR", .ilFlags.Images(imgkey)) 'include flag
            ElseIf imgindex <> Nothing Then
                .tsdViewDoc.DropDownItems.Add(tslName.Text + " | " + .numdocs.ToString + " | DR", .ilFlags.Images(imgindex)) 'include flag
            End If


            .docs.Add(Nothing)
            Dim doc As New ArrayList
            'doc.Add(tstDRName.Text)
            For Each pan As Control In flow.Controls
                For Each con As Control In pan.Controls
                    If TypeOf con Is TextBox Then 'it's a textbox, add it as a clause
                        doc.Add(CType(con, TextBox).Text)
                    ElseIf con.Name.StartsWith("tblRadio") Then
                        For Each conRb As Control In con.Controls
                            If TypeOf conRb Is RadioButton AndAlso CType(conRb, RadioButton).Checked Then 'use AndAlso for short-circuit
                                doc.Add(CType(conRb, RadioButton).Text)
                            End If
                        Next
                    End If
                Next
            Next
            .docs.Insert(.numdocs, doc)
        End With


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lklCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PasteText(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        rtbImportText.Paste()
    End Sub

    Private Sub ProcessText(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbProcess.Click


        'proceed if flow is empty or user authorises overwriting
        If flow.Controls.Count = 0 Or (flow.Controls.Count > 0 AndAlso MessageBox.Show("There are already clauses processed. Do you want to overwrite them?", "Munrun", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK) Then
            flow.Hide()

            'replace flow with new clauses
            flow.Controls.Clear()
            Dim pos1 As Integer
            Dim pos2 As Integer
            Dim txt As String = rtbImportText.Text
            pos1 = 1
            Dim id As Integer = 0
            While pos1 < rtbImportText.Text.Length

                pos2 = InStr(pos1, txt, vbLf)
                If pos2 = 0 Then
                    pos2 = Len(txt)
                End If
                rtbImportText.SelectionStart = pos1 - 1
                rtbImportText.SelectionLength = pos2 - pos1
                pos1 = pos2 + 1
                If (rtbImportText.SelectionLength > 0) Then
                    MakeClausePanel(id, rtbImportText.SelectedText, False, 0)
                    id = id + 1 'id is 0-based, matches flow.getChildIndex, see renumberAll for updates
                End If

            End While

            Clipboard.Clear()
            tsbProcess.Enabled = False
            OK_Button.Enabled = True

            flow.Show()
        End If

    End Sub

    Private Sub MakeClausePanel(ByVal id As Integer, ByVal clauseText As String, ByVal needReorder As Boolean, ByVal idReorder As Integer)

        Dim pan As New FlowLayoutPanel
        pan.Width = flow.Width - 30
        'pan.Width = 1000
        pan.Height = 100
        flow.Controls.Add(pan)
        If needReorder Then
            flow.Controls.SetChildIndex(pan, idReorder)
        End If
        pan.Name = "pan:" + id.ToString

        Dim rtb As New TextBox
        rtb.Multiline = True
        rtb.AcceptsTab = True
        rtb.Width = 300
        rtb.Height = 100
        rtb.Font = New Font("Georgia", 12)
        rtb.ScrollBars = ScrollBars.Vertical

        pan.Controls.Add(rtb)
        rtb.Text = clauseText
        rtb.Name = "rtb:" + id.ToString


        Dim tbl As New TableLayoutPanel
        tbl.RowCount = 3
        tbl.ColumnCount = 1
        tbl.Size = New Size(100, 100)
        tbl.BackColor = Color.LightGray
        pan.Controls.Add(tbl)
        tbl.Name = "tblRadio"

        Dim rbPre As New RadioButton
        rbPre.Text = "Preamble"
        rbPre.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        rbPre.Width = 95
        tbl.Controls.Add(rbPre)

        Dim rbOp As New RadioButton
        rbOp.Text = "Operative"
        rbOp.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        rbOp.Width = 95
        tbl.Controls.Add(rbOp)

        Dim rbInfo As New RadioButton
        rbInfo.Text = "Notes"
        rbInfo.Width = 95
        tbl.Controls.Add(rbInfo)

        If Char.IsDigit(rtb.Text(0)) Then
            rbOp.Checked = True
            'having a text=text call removes any formatting in the line, but perhaps that's not terrible
            rtb.Text = rtb.Text.TrimStart("0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "0"c)
            rtb.Text = rtb.Text.TrimStart("."c, ","c, ":"c)
            rtb.Text = rtb.Text.TrimStart(" "c, vbTab)
        Else
            rbPre.Checked = True
        End If




        Dim tblBtns As New TableLayoutPanel
        tblBtns.RowCount = 2
        tblBtns.ColumnCount = 4
        'tblBtns.BackColor = Color.LightGray
        tblBtns.Size = New Size(240, 100)

        pan.Controls.Add(tblBtns)
        'tblBtns.Name = "tblBtns:" + id.ToString

        Dim btnMergeUp As New Button
        'btnMergeUp.Text = "Merge up"
        btnMergeUp.BackgroundImage = My.Resources.merge_up
        btnMergeUp.BackColor = Color.White
        btnMergeUp.BackgroundImageLayout = ImageLayout.Center
        btnMergeUp.Width = 32
        btnMergeUp.Height = 32
        tblBtns.Controls.Add(btnMergeUp)
        'btnMergeUp.Name = "btnMergeUp:" + id.ToString
        AddHandler btnMergeUp.Click, AddressOf MergeUp

        Dim lblMergeUp As New Label
        lblMergeUp.Text = "Merge up"
        lblMergeUp.Width = 80
        lblMergeUp.Height = 32
        lblMergeUp.TextAlign = ContentAlignment.MiddleLeft
        tblBtns.Controls.Add(lblMergeUp)

        Dim btnDelete As New Button
        btnDelete.BackColor = Color.White
        btnDelete.BackgroundImage = My.Resources.delete
        btnDelete.BackgroundImageLayout = ImageLayout.Center
        'btnDelete.Text = "Delete"
        btnDelete.Width = 32
        btnDelete.Height = 32
        tblBtns.Controls.Add(btnDelete)
        'btnDelete.Name = "btnDelete:" + id.ToString
        AddHandler btnDelete.Click, AddressOf DeletePanel

        Dim lblDelete As New Label
        lblDelete.Text = "Delete"
        lblDelete.Width = 45
        lblDelete.Height = 32
        lblDelete.TextAlign = ContentAlignment.MiddleLeft
        tblBtns.Controls.Add(lblDelete)

        Dim btnMergeDown As New Button
        'btnMergeDown.Text = "Merge down"
        btnMergeDown.BackColor = Color.White
        btnMergeDown.BackgroundImage = My.Resources.merge_down
        btnMergeDown.BackgroundImageLayout = ImageLayout.Center
        btnMergeDown.Width = 32
        btnMergeDown.Height = 32
        tblBtns.Controls.Add(btnMergeDown)
        'btnMergeDown.Name = "btnMergeDown:" + id.ToString
        AddHandler btnMergeDown.Click, AddressOf MergeDown

        Dim lblMergeDown As New Label
        lblMergeDown.Text = "Merge down"
        lblMergeDown.Width = 85
        lblMergeDown.Height = 32
        lblMergeDown.TextAlign = ContentAlignment.MiddleLeft

        tblBtns.Controls.Add(lblMergeDown)

        Dim btnSplitClause As New Button
        'btnMergeDown.Text = "Split clause"
        btnSplitClause.BackColor = Color.White
        btnSplitClause.BackgroundImage = My.Resources.split
        btnSplitClause.BackgroundImageLayout = ImageLayout.Center
        btnSplitClause.Width = 32
        btnSplitClause.Height = 32
        tblBtns.Controls.Add(btnSplitClause)
        'btnSplitClause.Name = "btnSplitClause:" + id.ToString
        AddHandler btnSplitClause.Click, AddressOf SplitClause

        Dim lblSplit As New Label
        lblSplit.Text = "Split"
        lblSplit.Width = 45
        lblSplit.Height = 32
        lblSplit.TextAlign = ContentAlignment.MiddleLeft
        tblBtns.Controls.Add(lblSplit)


    End Sub

    Private Sub ShowControlName(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(CType(sender, Button).Name)
    End Sub

    Private Sub MergeUp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim id As Integer = (CType(sender, Button).Parent.Parent.Name.Split(":"))(1)
        'MessageBox.Show(id)
        If id > 0 Then
            For Each con As Control In CType(sender, Control).Parent.Parent.Controls 'all controls in panel
                If TypeOf con Is TextBox Then 'it's the textbox on this panel
                    For Each conTarget As Control In flow.Controls(flow.Controls.IndexOf(CType(sender, Control).Parent.Parent) - 1).Controls 'all controls in preceding panel
                        If TypeOf conTarget Is TextBox Then

                            CType(conTarget, TextBox).AppendText(vbCrLf)
                            CType(con, TextBox).SelectAll()
                            CType(conTarget, TextBox).SelectionStart = CType(conTarget, TextBox).Text.Length
                            CType(conTarget, TextBox).SelectionLength = 0
                            CType(conTarget, TextBox).SelectedText = CType(con, TextBox).SelectedText

                        End If
                    Next
                End If
            Next
            DeletePanelAction(sender)
        End If
        RenumberAll()
    End Sub

    Private Sub MergeDown(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim id As Integer = (CType(sender, Button).Parent.Parent.Name.Split(":"))(1) 'get id from panel
        'MessageBox.Show(id)
        If id < flow.Controls.Count - 1 Then 'second last or earlier
            For Each con As Control In CType(sender, Control).Parent.Parent.Controls 'all controls in panel
                If TypeOf con Is TextBox Then 'it's the textbox on this panel
                    For Each conTarget As Control In flow.Controls(flow.Controls.IndexOf(CType(sender, Control).Parent.Parent) + 1).Controls 'all controls in preceding panel
                        If TypeOf conTarget Is TextBox Then

                            CType(con, TextBox).AppendText(vbCrLf)
                            CType(con, TextBox).SelectAll()
                            CType(conTarget, TextBox).SelectionStart = 0
                            CType(conTarget, TextBox).SelectionLength = 0
                            CType(conTarget, TextBox).SelectedText = CType(con, TextBox).SelectedText

                        End If
                    Next
                End If
            Next
            DeletePanelAction(sender)
        End If
        RenumberAll()
    End Sub

    Private Sub DeletePanel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'this is for delete button only, gets user confirmation before proceeding
        If MessageBox.Show("Are you sure you want to delete this clause?", "Munrun", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            DeletePanelAction(sender)
        End If
    End Sub

    Private Sub DeletePanelAction(ByVal sender As System.Object)
        'delete the panel from the flow
        flow.Controls.Remove(CType(sender, Control).Parent.Parent)
        RenumberAll()
    End Sub

    Private Sub RenumberAll()
        For Each con As Control In flow.Controls
            If con.Name.StartsWith("pan") Then
                con.Name = "pan:" + flow.Controls.GetChildIndex(con).ToString
            End If
            'also renumber tables and buttons if needed later
        Next
    End Sub

    Private Sub SplitClause(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim id As Integer = (CType(sender, Button).Parent.Parent.Name.Split(":"))(1) 'get id from panel
        For Each con As Control In CType(sender, Control).Parent.Parent.Controls 'all controls in panel
            If TypeOf con Is TextBox Then 'it's the textbox on this panel
                If CType(con, TextBox).SelectedText.Length > 0 Then
                    MakeClausePanel(0, CType(con, TextBox).SelectedText, True, id + 1)
                    CType(con, TextBox).SelectedText = ""
                End If
            End If
        Next
        RenumberAll()
    End Sub


    Private Sub ResetForNextTime()
        flow.Controls.Clear()
        rtbImportText.Clear()
        OK_Button.Enabled = False
        tsbProvideText.Enabled = True
        tsbProcess.Enabled = False
    End Sub

    Private Sub AddDoc_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'allow to exit, clear all boxes for next DR
        ResetForNextTime()
    End Sub

    Private Sub AddDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ResetForNextTime() 'reset on first time to get buttons in right state
    End Sub

    Private Sub ImportFromWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportFromWordToolStripMenuItem.Click
        Try
            Dim loadFileDialog As New OpenFileDialog()
            Dim objWord As New Word.Application
            Dim objTempDoc As New Word.Document
            Dim iData As IDataObject

            loadFileDialog.InitialDirectory = loadDir
            loadFileDialog.FilterIndex = loadFilter
            loadFileDialog.Filter = "Word document (*.doc, *.docx)|*.doc*|Rich text format (*.rtf)|*.rtf"
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
                    rtbImportText.Clear()
                    rtbImportText.Paste()
                End If
                Clipboard.Clear()
            End If
            objWord.Quit()
        Catch
            MessageBox.Show("Sorry, the import failed. Try opening the document in Word, copying its text and pasting it in here.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub rtbImportText_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbImportText.TextChanged
        If rtbImportText.TextLength > 0 Then
            tsbProcess.Enabled = True
        Else
            tsbProcess.Enabled = False
        End If
    End Sub
End Class
