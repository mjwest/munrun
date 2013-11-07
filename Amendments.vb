Public Class Amendments
    Public currentTextSize As Integer = 30
    Public resolutionReferred As Integer = 0
    Dim amendSelected As Boolean
    Dim nonNumberEntered As Boolean = False
    Dim activeClauses As New ArrayList
    Dim boxHeight As Integer = 32 'only used for newclause panel, since the others autoresize
    Public titleparts As Array
    Private programClose As Boolean = False
    Private spacerHeight As Integer = 8
    Public currentAmendment As Integer = -1 'new, has no id
    Public clauseMatchIdHolder As Integer = -1
    Public clauseDescHolder As String = ""
    Public clauseOrigHolder As String = ""
    Public clausePropHolder As String = ""


    Private Sub progClose()
        programClose = True 'mark as being closed by program so that it doesn't give check prompt
        Me.Close()
    End Sub

    Private Sub Amendment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Amendment_SizeChanged(Me, e)
        programClose = False
    End Sub

    Private Sub Amendment_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If programClose = False Then 'check intention
            'maybe replace this check with a custom form like with the main window, once amendment saving is implemented
            If MessageBox.Show("Are you sure you want to close this amendment? No changes will be made to the draft resolution.", "Munrun", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                'close
                Munchkin.flowRes.Enabled = True
                e.Cancel = False
            Else
                'don't close
                e.Cancel = True
            End If
        Else
            'don't intervene, just close
            Munchkin.flowRes.Enabled = True
        End If
    End Sub

    'Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
    '    'If amendSelected = True Then
    '    '    rtbAmendEdit.Paste()
    '    'Else
    '    '    rtbAmendOrig.Paste()
    '    'End If
    '    Dim temp As New RichTextBox
    '    Dim id As IDataObject = Clipboard.GetDataObject
    '    If id.GetDataPresent(DataFormats.Text) Then
    '        temp.Paste()
    '        temp.Font = rtbAmendEdit.SelectionFont
    '        temp.SelectAll()
    '        temp.Copy()
    '        rtbAmendEdit.Paste()
    '    End If
    'End Sub

    'Private Sub tsbPickClauses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPickClauses.Click
    '    If PickAmendClauses.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        'remove un-ticked clauses

    '        flowAmendOrig.Hide()
    '        flowAmendDesc.Hide()
    '        flowPropText.Hide()

    '        With PickAmendClauses.clbClausePicker
    '            For Each clause As Object In .Items
    '                If Not .CheckedItems.Contains(clause) And activeClauses.Contains(.Items.IndexOf(clause)) Then
    '                    'MessageBox.Show("Removing " + .Items.IndexOf(clause).ToString)
    '                    activeClauses.Remove(.Items.IndexOf(clause))

    '                    'need to know which boxes they are, as this is not the same as their index in the clb picker
    '                    'might need to institute a lookup table that holds index whenever a clause is added
    '                    'update: currently the tag is working well but will need to update it when renumbering etc occurs

    '                    'remove boxes
    '                    For Each con As Control In flowAmendDesc.Controls
    '                        If TypeOf con Is RichTextBox AndAlso con.Tag <> Nothing AndAlso con.Tag.ToString = .Items.IndexOf(clause).ToString Then
    '                            flowAmendDesc.Height -= (con.Height + spacerHeight) 'shrink by box + spacer
    '                            flowAmendDesc.Controls.RemoveAt(flowAmendDesc.Controls.IndexOf(con) + 1) 'remove following spacer
    '                            flowAmendDesc.Controls.Remove(con) 'remove box
    '                        End If
    '                    Next

    '                    For Each con As Control In flowAmendOrig.Controls
    '                        If TypeOf con Is RichTextBox AndAlso con.Tag.ToString = .Items.IndexOf(clause).ToString Then
    '                            flowAmendOrig.Height -= (con.Height + spacerHeight) 'shrink by box + spacer
    '                            flowAmendOrig.Controls.RemoveAt(flowAmendOrig.Controls.IndexOf(con) + 1) 'remove following spacer
    '                            flowAmendOrig.Controls.Remove(con) 'remove box
    '                        End If
    '                    Next

    '                    For Each con As Control In flowPropText.Controls
    '                        If TypeOf con Is RichTextBox AndAlso con.Tag <> Nothing AndAlso con.Tag.ToString = .Items.IndexOf(clause).ToString Then
    '                            flowPropText.Height -= (con.Height + spacerHeight) 'shrink by box + spacer
    '                            flowPropText.Controls.RemoveAt(flowPropText.Controls.IndexOf(con) + 1) 'remove following spacer
    '                            flowPropText.Controls.Remove(con) 'remove box

    '                        End If
    '                    Next
    '                End If
    '            Next
    '        End With

    '        'add ticked clauses
    '        For Each i As Integer In PickAmendClauses.clbClausePicker.CheckedIndices  'checkedindices index does refer to main index
    '            'add if not already available
    '            If Not activeClauses.Contains(i) Then
    '                activeClauses.Add(i)

    '                Dim rtbOrig As New RichTextBox
    '                rtbOrig.Height = boxHeight
    '                rtbOrig.Width = flowAmendOrig.Width - 4
    '                rtbOrig.Multiline = True
    '                rtbOrig.ReadOnly = True
    '                flowAmendOrig.Height += boxHeight
    '                rtbOrig.Tag = i.ToString
    '                rtbOrig.BackColor = Color.Gainsboro
    '                flowAmendOrig.Controls.Add(rtbOrig)

    '                Dim rtbChanges As New RichTextBox
    '                rtbChanges.Height = boxHeight
    '                rtbChanges.Width = flowAmendDesc.Width - 4
    '                rtbChanges.Multiline = True
    '                rtbChanges.AutoWordSelection = False
    '                flowAmendDesc.Height += boxHeight
    '                rtbChanges.Tag = i
    '                flowAmendDesc.Controls.Add(rtbChanges)

    '                Dim rtbProposed As New RichTextBox
    '                rtbProposed.Height = boxHeight
    '                rtbProposed.Width = flowPropText.Width - 4
    '                rtbProposed.Multiline = True
    '                rtbProposed.ReadOnly = True
    '                flowPropText.Height += boxHeight
    '                rtbProposed.Tag = i
    '                rtbProposed.BackColor = Color.Gainsboro
    '                flowPropText.Controls.Add(rtbProposed)

    '                AddSpacers()

    '                'after creating all boxes, add resize handlers and then text
    '                'if done piecewise, first one will attempt to resize others that haven't been created yet
    '                rtbOrig.Rtf = CType(Munchkin.flowRes.Controls(2 * i + 1), RichTextBox).Rtf
    '                ApplyTextSize(rtbOrig)

    '                AddHandler rtbChanges.ContentsResized, AddressOf BoxContentsResized
    '                AddHandler rtbChanges.SelectionChanged, AddressOf TriggerShowContext
    '                AddHandler rtbChanges.KeyUp, AddressOf UpdateOnDelete
    '                rtbChanges.Rtf = CType(Munchkin.flowRes.Controls(2 * i + 1), RichTextBox).Rtf
    '                ApplyTextSize(rtbChanges)

    '                'AddHandler rtbProposed.ContentsResized, AddressOf BoxContentsResized
    '                rtbProposed.Rtf = CType(Munchkin.flowRes.Controls(2 * i + 1), RichTextBox).Rtf
    '                ApplyTextSize(rtbProposed)

    '                AddHandler rtbChanges.TextChanged, AddressOf AlwaysUpdateText


    '            End If 'activeclauses check
    '        Next 'checked clause 

    '        flowAmendOrig.Show()
    '        flowAmendDesc.Show()
    '        flowPropText.Show()

    '    End If 'pickclauses.dialogresult = ok
    'End Sub

    Private Sub AddSpacers()
        AddSpacerOrig()
        AddSpacerDesc()
        AddSpacerProp()
    End Sub

    Private Sub AddSpacerOrig()
        Dim spacerOrig As New Panel
        spacerOrig.Width = 100
        spacerOrig.Height = spacerHeight
        flowAmendOrig.Controls.Add(spacerOrig)
        flowAmendOrig.Height += spacerHeight
    End Sub

    Private Sub AddSpacerDesc()
        Dim spacerAmend As New Panel
        spacerAmend.Width = 100
        spacerAmend.Height = spacerHeight
        flowAmendDesc.Controls.Add(spacerAmend)
        flowAmendDesc.Height += spacerHeight
    End Sub

    Private Sub AddSpacerProp()
        Dim spacerProp As New Panel
        spacerProp.Width = 100
        spacerProp.Height = spacerHeight
        flowPropText.Controls.Add(spacerProp)
        flowPropText.Height += spacerHeight
    End Sub

    Private Sub TriggerShowContext(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CType(sender, RichTextBox).SelectionLength > 0 Then
            AddHandler (CType(sender, RichTextBox)).MouseUp, AddressOf ShowContext
        End If
    End Sub

    Private Sub ShowContext(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmsMarkupText.Show(Cursor.Position)
        RemoveHandler (CType(sender, RichTextBox)).MouseUp, AddressOf ShowContext
    End Sub

    Private Sub MarkText(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click, cmsDelete.Click, cmsOrig.Click
        For Each con As Control In flowAmendDesc.Controls
            If con.Focused AndAlso TypeOf con Is RichTextBox Then
                Dim rtb As RichTextBox = CType(con, RichTextBox)
                If rtb.SelectionLength > 0 Then 'something is selected
                    Dim str As String = rtb.SelectedRtf
                    '   MessageBox.Show(str)
                    If Not str.Contains("\colortbl") Then
                        str = str.Insert(str.IndexOf("}}") + 2, Environment.NewLine + "{\colortbl;\red255\green0\blue0;\red0\green112\blue192;}")
                    Else
                        Dim startTbl As Integer = str.IndexOf("\colortbl")
                        Dim endTbl As Integer = str.IndexOf("}", startTbl)
                        str = str.Remove(startTbl, endTbl - startTbl)
                        str = str.Insert(startTbl, "\colortbl ;\red255\green0\blue0;\red0\green112\blue192;")
                    End If
                    'MessageBox.Show(str)

                    'now \cf1 = red, \cf2 = blue, \cf0 = return to black.
                    '\strike = strikethrough, \strike0 = cancel. \ul = underline, \ulnone = cancel.

                    'delete old formatting
                    str = str.Replace("\cf1", "")
                    str = str.Replace("\cf2", "")
                    str = str.Replace("\cf0", "")
                    str = str.Replace("\strike0", "")
                    str = str.Replace("\strike", "")
                    str = str.Replace("\ulnone", "")
                    str = str.Replace("\ul", "")

                    'insert new tag: before the fs and at the very end before final closing }
                    If sender.Equals(cmsAdd) Then
                        'Clipboard.SetText(Clipboard.GetText + "Before" + str)
                        str = str.Insert(str.IndexOf("\pard"), "\cf2\ul") 'blue underline for addtion
                        'Clipboard.SetText(Clipboard.GetText + "First add" + str)
                        str = str.Insert(str.Length - 3, "\cf0\ulnone")
                        'Clipboard.SetText(Clipboard.GetText + "Second add" + str)
                        'direct insertion doesn't work: could be past end of target box
                        'CType(flowPropText.Controls(rtbIndex), RichTextBox).Text = CType(flowPropText.Controls(rtbIndex), RichTextBox).Text.Insert(rtb.SelectionStart, rtb.SelectedText)
                    ElseIf sender.Equals(cmsDelete) Then
                        'Clipboard.SetText(Clipboard.GetText + "Before" + str)
                        str = str.Insert(str.IndexOf("\pard"), "\cf1\strike") 'red strikethrough for deletion
                        'Clipboard.SetText(Clipboard.GetText + "First del add" + str)
                        str = str.Insert(str.Length - 3, "\cf0\strike0")
                        'Clipboard.SetText(Clipboard.GetText + "Second del add" + str)
                    ElseIf sender.Equals(cmsOrig) Then
                        'don't need to do anything else as stripping out all the formatting above is sufficient

                    End If
                    ' MessageBox.Show(str, "str after formatting")

                    rtb.SelectedRtf = str

                    'MessageBox.Show(rtb.Rtf, "rtb.rtf before pass")
                    'set proposed text
                    CType(flowPropText.Controls(rtb.Parent.Controls.IndexOf(rtb)), RichTextBox).Rtf = GenerateProposedText(rtb.Rtf)

                    If CType(flowPropText.Controls(rtb.Parent.Controls.IndexOf(rtb)), RichTextBox).TextLength = 0 Then
                        CType(flowPropText.Controls(rtb.Parent.Controls.IndexOf(rtb)), RichTextBox).BackColor = Color.Coral
                    Else
                        CType(flowPropText.Controls(rtb.Parent.Controls.IndexOf(rtb)), RichTextBox).BackColor = Color.Gainsboro
                    End If

                    'Clipboard.SetText(rtb.SelectedRtf)

                    Exit For 'don't need to search the rest
                End If
            End If
        Next
    End Sub

    Public Function GenerateProposedText(ByVal origrtf As String)

        'markup is rtf of the amendment description textbox
        'want to generate a new rtf which subtracts all red underlined text
        'and strips out blue tags without deleting the text between them
        Dim finalrtf As String = origrtf
        'markers don't use \cf tags as colour can change
        Dim markerDelStart As String = "\strike" 'marker for deletion
        Dim markerDelEnd As String = "\strike0" 'marker to end deletion
        Dim markerAddStart As String = "\ul" 'marker to start addition
        Dim markerAddEnd As String = "\ulnone" 'marker to end addition


        'MessageBox.Show(finalrtf, "finalrtf before delremoval")
        Dim loopBreaker As Integer = 0
        While finalrtf.Contains(markerDelStart) And loopBreaker < 10
            'process to remove deleted text

            'find first instance of start marker
            'find first instance of end marker
            'delete everything in between the two markers, and the markers themselves
            'try again

            Dim delStart As Integer = InStr(finalrtf, markerDelStart) - 5 '-3 is for the preceding \cf1 or similar
            Dim delEnd As Integer = InStr(finalrtf, markerDelEnd) + markerDelEnd.Length - 1


            If delEnd > delStart Then
                Dim checkItalics As String = finalrtf.Remove(delEnd)
                checkItalics = checkItalics.Remove(0, delStart)
                If checkItalics.Contains("\i0") Then 'contains an end italics tag
                    finalrtf = finalrtf.Insert(delEnd, "\i0") 'add after so that it is still there after deletion
                End If
                finalrtf = finalrtf.Remove(delStart, delEnd - delStart)
            End If

            ' MessageBox.Show(finalrtf, "finalrtf after removal")


            'Dim delStart As Integer = InStr(finalrtf, markerDelStart)
            'Dim remainder As String = finalrtf.Remove(0, delStart + markerDelStart.Length) 'rest of string after end of start marker
            ''MessageBox.Show(remainder, "remainder")
            'Dim delEnd As Integer = InStr(remainder, markerDelEnd) + markerDelEnd.Length + (delStart + markerDelStart.Length) 'must adjust for removed text
            'finalrtf = finalrtf.Remove(delStart, delEnd - delStart)
            '' MessageBox.Show(finalrtf, "finalrtf after removal")
            loopBreaker += 1
        End While
        ' MessageBox.Show(finalrtf, "finalrtf after delremoval")

        'process to remove blue formatting, keeping text
        'adds an extra space on either side of blue text, maybe work out how to remove this
        'MessageBox.Show(finalrtf, "finalrtf before ul rem")
        finalrtf = finalrtf.Replace(markerAddEnd, "") 'must do this first since \ulnone contains \ul
        finalrtf = finalrtf.Replace(markerAddStart, "")
        'MessageBox.Show(finalrtf, "finalrtf after ul rem")


        finalrtf = MakeTextBlack(finalrtf)
        'MessageBox.Show(finalrtf, "finalrtf after blue rem")

        Return finalrtf
    End Function

    Private Function MakeTextBlack(ByVal rtf As String)
        rtf = rtf.Replace("\cf1", "")
        rtf = rtf.Replace("\cf2", "")
        rtf = rtf.Replace("\cf0", "") 'not needed? cf0 is black
        Return rtf
    End Function


    Private Sub BoxContentsResized(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ContentsResizedEventArgs)
        If CType(sender, Control).Parent IsNot Nothing Then
            Dim i As Integer = CType(sender, Control).Parent.Controls.IndexOf(CType(sender, Control))
            Dim h As Integer = Math.Min(e.NewRectangle.Height + 6, panelClauses.Height) 'necessary to restrict height otherwise you can't type at the top without it jumping to the bottom
            Dim hDiff As Integer = h - CType(sender, Control).Height

            'MessageBox.Show(flowAmendOrig.Controls(i).Name.ToString)

            flowAmendOrig.Controls(i).Height = h
            flowAmendDesc.Controls(i).Height = h
            flowPropText.Controls(i).Height = h

            flowAmendOrig.Height += hDiff
            flowAmendDesc.Height += hDiff
            flowPropText.Height += hDiff

            'try to keep up with control, scrolls to spacer below
            If flowAmendDesc.Height > panelClauses.Height Then
                panelClauses.ScrollControlIntoView(flowAmendDesc.Controls(i + 1))
                'CType(flowAmendDesc.Controls(i), RichTextBox).ScrollToCaret()
            End If
        End If


    End Sub

    Private Sub AddClause(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAddClause.Click

        Dim panNewClause As New Panel
        panNewClause.Height = boxHeight
        panNewClause.Width = flowAmendOrig.Width - 4
        panNewClause.BackColor = Color.Gainsboro

        Dim btnNewClauseDiscard As New LinkLabel
        btnNewClauseDiscard.Text = "Cancel"
        btnNewClauseDiscard.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNewClauseDiscard.LinkColor = Color.Red
        btnNewClauseDiscard.Location = New Point(panNewClause.Width - 50, 4)
        panNewClause.Controls.Add(btnNewClauseDiscard)

        Dim rbNewClausePreamble As New RadioButton
        rbNewClausePreamble.Text = "Preamble"
        rbNewClausePreamble.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        rbNewClausePreamble.Location = New Point(2, 2)
        rbNewClausePreamble.AutoSize = True
        panNewClause.Controls.Add(rbNewClausePreamble)

        Dim rbNewClauseOperative As New RadioButton
        rbNewClauseOperative.Text = "Operative"
        rbNewClauseOperative.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        rbNewClauseOperative.Location = New Point(rbNewClausePreamble.Width + 1, 2)
        rbNewClauseOperative.AutoSize = True
        rbNewClauseOperative.Checked = True
        panNewClause.Controls.Add(rbNewClauseOperative)

        Dim rbNewClauseNotes As New RadioButton
        rbNewClauseNotes.Text = "Notes"
        rbNewClauseNotes.Location = New Point(rbNewClausePreamble.Width + rbNewClauseOperative.Width, 2)
        panNewClause.Controls.Add(rbNewClauseNotes)

        flowAmendOrig.Height += boxHeight
        flowAmendOrig.Controls.Add(panNewClause)

        Dim rtbChanges As New RichTextBox
        rtbChanges.Height = boxHeight
        rtbChanges.Width = flowAmendDesc.Width - 4
        rtbChanges.Multiline = True
        rtbChanges.ForeColor = Color.FromArgb(0, 112, 192)
        rtbChanges.Font = New Font("Georgia", currentTextSize, FontStyle.Underline)
        rtbChanges.Text = "Text of new clause"
        rtbChanges.AutoWordSelection = False
        flowAmendDesc.Height += boxHeight
        flowAmendDesc.Controls.Add(rtbChanges)
        ApplyTextSize(rtbChanges)

        Dim rtbProposed As New RichTextBox
        rtbProposed.Height = boxHeight
        rtbProposed.Width = flowPropText.Width - 4
        rtbProposed.Multiline = True
        rtbProposed.ReadOnly = True
        rtbProposed.Tag = "999"
        rtbProposed.Font = New Font("Georgia", currentTextSize, FontStyle.Regular)
        rtbProposed.Text = "Text of new clause"
        flowPropText.Height += boxHeight
        flowPropText.Controls.Add(rtbProposed)
        ApplyTextSize(rtbProposed)

        AddSpacers()

        'after creating all boxes, add resize handlers and then text
        'if done piecewise, first one will attempt to resize others that haven't been created yet
        AddHandler btnNewClauseDiscard.Click, AddressOf DiscardNewClause
        AddHandler rtbChanges.ContentsResized, AddressOf BoxContentsResized
        AddHandler rtbChanges.TextChanged, AddressOf AlwaysUpdateText
        'AddHandler rtbChanges.SelectionChanged, AddressOf TriggerShowContext 'don't need to mark as delete for a new clause
        AddHandler rtbProposed.ContentsResized, AddressOf BoxContentsResized
        AddHandler rtbChanges.Click, AddressOf SelectFirstTime
        AddHandler rtbChanges.KeyUp, AddressOf UpdateOnDelete
    End Sub
    Private Sub UpdateOnDelete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
        '    'updated Proposed textbox when text is changed in clause box
        '    Dim i As Integer = CType(sender, Control).Parent.Controls.IndexOf(CType(sender, Control))

        '    '*** DEBUG: this is insufficient for clauses being amended, not added, as GenerateProposed is bypassed, which will reinsert 
        '    ' strikethrough text.

        '    CType(flowPropText.Controls(i), RichTextBox).Text = CType(sender, RichTextBox).Text
        'End If

    End Sub

    Private Sub SelectFirstTime(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CType(sender, RichTextBox).SelectAll()
        RemoveHandler CType(sender, RichTextBox).Click, AddressOf SelectFirstTime
    End Sub
    Private Sub AlwaysUpdateText(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rtb As RichTextBox = CType(sender, RichTextBox)

        'constantly updated Proposed textbox when text is changed in new clause box
        Dim i As Integer = rtb.Parent.Controls.IndexOf(rtb)

        If rtb.TextLength = 0 Then
            CType(flowPropText.Controls(i), RichTextBox).Text = " "
        Else
            'AddDoc.RemoveImages(sender, e)
            CType(flowPropText.Controls(rtb.Parent.Controls.IndexOf(rtb)), RichTextBox).Rtf = GenerateProposedText(rtb.Rtf)

            'for new clause
            'CType(flowPropText.Controls(i), RichTextBox).Text = CType(sender, RichTextBox).Text
        End If
        'keep resizing it to make sure resize actually takes effect
        'ApplyTextSize(CType(sender, RichTextBox))
        'ApplyTextSize(CType(flowPropText.Controls(i), RichTextBox))
    End Sub

    Private Sub DiscardNewClause(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Are you sure you want to discard this new clause?", "Munrun", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then

            'get index of panel to be removed
            Dim i As Integer = flowAmendOrig.Controls.IndexOf(CType(sender, Control).Parent)

            'remove spacers first, or the index will change
            flowAmendOrig.Controls.RemoveAt(i + 1)
            flowAmendDesc.Controls.RemoveAt(i + 1)
            flowPropText.Controls.RemoveAt(i + 1)

            'get size to shrink flows by: height of the amenddesc rtb for this clause + spacer
            Dim shrinkSize As Integer = flowAmendDesc.Controls(i).Height + 8

            'remove boxes
            flowAmendOrig.Controls.RemoveAt(i)
            flowAmendDesc.Controls.RemoveAt(i)
            flowPropText.Controls.RemoveAt(i)

            'shrink flows
            flowAmendOrig.Height -= shrinkSize
            flowAmendDesc.Height -= shrinkSize
            flowPropText.Height -= shrinkSize


        End If
    End Sub

    Private Sub tsbDescPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDescPaste.Click
        'paste text only, not formatting, maybe using clipboard.gettext instead of rtb.paste
        For Each con As Control In flowAmendDesc.Controls
            If con.Focused And TypeOf con Is RichTextBox Then
                CType(con, RichTextBox).Rtf.Insert(CType(con, RichTextBox).SelectionStart, Clipboard.GetData(System.Windows.Forms.DataFormats.Rtf))

                'rtb.Paste(System.Windows.Forms.DataFormats.GetFormat(Text))
                'rtb.Text = rtb.Text.Insert(rtb.SelectionStart, Clipboard.GetText())
            End If
        Next

    End Sub

    Private Sub ChangeTextSizes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallToolStripMenuItem.Click, MediumToolStripMenuItem.Click, LargeToolStripMenuItem.Click, HugeToolStripMenuItem.Click
        If sender.Equals(SmallToolStripMenuItem) Then
            currentTextSize = 20
            SmallToolStripMenuItem.Checked = True
            MediumToolStripMenuItem.Checked = False
            LargeToolStripMenuItem.Checked = False
            HugeToolStripMenuItem.Checked = False
        ElseIf sender.Equals(MediumToolStripMenuItem) Then
            currentTextSize = 30
            SmallToolStripMenuItem.Checked = False
            MediumToolStripMenuItem.Checked = True
            LargeToolStripMenuItem.Checked = False
            HugeToolStripMenuItem.Checked = False
        ElseIf sender.Equals(LargeToolStripMenuItem) Then
            currentTextSize = 40
            SmallToolStripMenuItem.Checked = False
            MediumToolStripMenuItem.Checked = False
            LargeToolStripMenuItem.Checked = True
            HugeToolStripMenuItem.Checked = False
        ElseIf sender.Equals(HugeToolStripMenuItem) Then
            currentTextSize = 60
            SmallToolStripMenuItem.Checked = False
            MediumToolStripMenuItem.Checked = False
            LargeToolStripMenuItem.Checked = False
            HugeToolStripMenuItem.Checked = True
        End If

        Me.Cursor = Cursors.WaitCursor
        HideAllFlows()
        ResizeFlowBox(flowAmendOrig)
        ResizeFlowBox(flowAmendDesc)
        ResizeFlowBox(flowPropText)
        ShowAllFlows()
        Me.Cursor = Cursors.Default

        'also need to resize text everywhere else.

    End Sub

    Private Sub HideAllFlows()
        flowAmendOrig.Hide()
        flowAmendDesc.Hide()
        flowPropText.Hide()
        Me.Refresh()
    End Sub

    Private Sub ShowAllFlows()
        flowAmendOrig.Show()
        flowAmendDesc.Show()
        flowPropText.Show()
        Me.Refresh()
    End Sub

    Private Sub ResizeFlowBox(ByRef flow As FlowLayoutPanel)
        'flow.Hide()
        'Me.Refresh()
        For Each con As Control In flow.Controls
            If TypeOf con Is RichTextBox Then
                ApplyTextSize(CType(con, RichTextBox))
            End If
        Next
        ' flow.Show()
    End Sub

    Private Sub ApplyTextSize(ByRef rtb As RichTextBox)
        For origSize As Integer = 1 To 140
            rtb.Rtf = rtb.Rtf.Replace("\fs" + origSize.ToString + " ", "\fs" + currentTextSize.ToString + " ")
        Next
    End Sub


    Private Sub PassAmendment(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassToolStripMenuItem.Click
        Dim idClause As Integer = 0

        If MessageBox.Show("Please confirm that you want to PASS the amendment.", "Munrun", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            Munchkin.flowRes.Enabled = True
            Dim doc As ArrayList = Munchkin.docs(resolutionReferred)
            For Each con As Control In flowPropText.Controls
                If TypeOf con Is RichTextBox Then
                    idClause = CInt(con.Tag)
                    'update text in docs array, textbox, clbClause and clbClausePicker

                    If idClause = 999 Then 'it's a new clause
                        'possibly need to insert rather than add to end; give ability to pick where
                        'MessageBox.Show("Passing new clause")
                        doc.Add(CType(con, RichTextBox).Rtf) 'add new text to end
                        Dim panelIndex As Integer = flowPropText.Controls.IndexOf(con)
                        Dim clauseType As String = "Operative" 'default
                        For Each panelCon As Control In flowAmendOrig.Controls(panelIndex).Controls 'all controls in the new clause panel for this clause
                            If TypeOf panelCon Is RadioButton AndAlso CType(panelCon, RadioButton).Checked = True Then
                                clauseType = CType(panelCon, RadioButton).Text
                            End If
                        Next
                        doc.Add(clauseType) 'add label text
                    Else 'it's an amended clause
                        'MessageBox.Show("Passing clause with id: " + idClause.ToString)
                        If CType(con, RichTextBox).TextLength = 0 Then 'clause has been struck totally
                            'mark it as deleted
                            doc(2 * idClause) = ""
                            doc(2 * idClause + 1) = "Deleted" 'set label to be deleted
                        Else 'just update text
                            doc(2 * idClause) = CType(con, RichTextBox).Rtf
                        End If
                    End If
                End If
            Next
            If currentAmendment >= 0 Then 'it's not a new one and has been saved before
                Munchkin.docAmends(resolutionReferred - 1).Remove(currentAmendment) 'remove from doc's list so it doesn't get displayed in dropdown; don't delete from amends or indices will change
            End If
            Munchkin.docs(resolutionReferred) = doc 'store back in
            Munchkin.SortClauses(titleparts) 'will also display it and refresh amendments, it has a call to showdocument
            progClose()
        End If

    End Sub

    Private Sub FailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FailToolStripMenuItem.Click

        If MessageBox.Show("Please confirm that you want to FAIL the amendment.", "Munrun", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            flowAmendDesc.Controls.Clear()
            flowAmendOrig.Controls.Clear()
            flowPropText.Controls.Clear()

            If currentAmendment >= 0 Then 'it's not a new one and has been saved before
                Munchkin.docAmends(resolutionReferred - 1).Remove(currentAmendment) 'remove from doc's list so it doesn't get displayed in dropdown; don't delete from amends or indices will change
                RefreshAmendments(resolutionReferred)
            End If
            progClose()
        End If
    End Sub

    Private Sub Panel2_MClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelClauses.Click
        panelClauses.Focus()
    End Sub

    Private Sub SaveAmendment() Handles tsbSaveAmendment.Click
        Dim amend As New Amendment

        'store name
        amend.amendName = tslAmendName.Text

        'give index and associate with document
        amend.amendId = Munchkin.amends.Count 'grows automatically; zero-based
        Munchkin.docAmends(resolutionReferred - 1).Add(amend.amendId)

        ' store flow text contents
        For Each con As Control In flowAmendOrig.Controls
            If TypeOf con Is RichTextBox Then
                amend.textOrig.Add(CType(con, RichTextBox).Rtf)
            ElseIf TypeOf con Is Panel Then
                For Each panelCon As Control In CType(con, Panel).Controls
                    If TypeOf panelCon Is RadioButton AndAlso CType(panelCon, RadioButton).Checked = True Then
                        amend.textOrig.Add("**New|" + panelCon.Text)
                    End If
                Next
            End If
        Next

        For Each con As Control In flowAmendDesc.Controls
            If TypeOf con Is RichTextBox Then
                amend.textDesc.Add(CType(con, RichTextBox).Rtf)
            End If
        Next

        For Each con As Control In flowPropText.Controls
            If TypeOf con Is RichTextBox Then
                amend.textProp.Add(CType(con, RichTextBox).Rtf)
            End If
        Next

        'add to central list
        Munchkin.amends.Add(amend)

        'if saved before, remove old one from list, but not from central list
        If currentAmendment >= 0 Then 'it's not a new one and has been saved before
            Munchkin.docAmends(resolutionReferred - 1).Remove(currentAmendment) 'remove from doc's list so it doesn't get displayed in dropdown; don't delete from amends or indices will change
        End If

        'refresh amendment dropdown
        RefreshAmendments(resolutionReferred)

        'close form
        progClose()
    End Sub

    Public Sub RefreshAmendments(ByVal resolutionId As Integer)
        With Munchkin
            .tsdViewAmend.DropDownItems.Clear()
            For Each amendId As Integer In .docAmends(resolutionId - 1) '-1 is because array is zero-based, but first resolution is numbered 1
                'add dropdown item with correct text, then set its tag to the amendId
                .tsdViewAmend.DropDownItems.Add(.amends(amendId).amendName)
                .tsdViewAmend.DropDownItems(.tsdViewAmend.DropDownItems.Count - 1).Tag = amendId
            Next
        End With
    End Sub

    Public Sub LoadAmendment(ByVal amend As Amendment)
        tsbPickClauses.Enabled = False
        currentAmendment = amend.amendId
        tslAmendName.Text = amend.amendName

        flowAmendOrig.Hide()
        flowAmendDesc.Hide()
        flowPropText.Hide()

        For i As Integer = 0 To amend.textOrig.Count - 1
            If amend.textOrig(i).StartsWith("**New") Then 'it's a new clause, generate panel instead

                Dim panNewClause As New Panel
                panNewClause.Height = boxHeight
                panNewClause.Width = flowAmendOrig.Width - 4
                panNewClause.BackColor = Color.Gainsboro

                Dim btnNewClauseDiscard As New LinkLabel
                btnNewClauseDiscard.Text = "Cancel"
                btnNewClauseDiscard.Font = New Font("Segoe UI", 10, FontStyle.Regular)
                btnNewClauseDiscard.Location = New Point(panNewClause.Width - 50, 4)
                panNewClause.Controls.Add(btnNewClauseDiscard)

                Dim rbNewClausePreamble As New RadioButton
                rbNewClausePreamble.Text = "Preamble"
                rbNewClausePreamble.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                rbNewClausePreamble.Location = New Point(2, 2)
                rbNewClausePreamble.AutoSize = True
                If amend.textOrig(i).EndsWith("Preamble") Then
                    rbNewClausePreamble.Checked = True
                End If
                panNewClause.Controls.Add(rbNewClausePreamble)

                Dim rbNewClauseOperative As New RadioButton
                rbNewClauseOperative.Text = "Operative"
                rbNewClauseOperative.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                rbNewClauseOperative.Location = New Point(rbNewClausePreamble.Width + 1, 2)
                rbNewClauseOperative.AutoSize = True
                If amend.textOrig(i).EndsWith("Operative") Then
                    rbNewClauseOperative.Checked = True
                End If
                panNewClause.Controls.Add(rbNewClauseOperative)

                Dim rbNewClauseNotes As New RadioButton
                rbNewClauseNotes.Text = "Notes"
                rbNewClauseNotes.Location = New Point(rbNewClausePreamble.Width + rbNewClauseOperative.Width, 2)
                If amend.textOrig(i).EndsWith("Notes") Then
                    rbNewClauseNotes.Checked = True
                End If
                panNewClause.Controls.Add(rbNewClauseNotes)

                flowAmendOrig.Height += boxHeight
                flowAmendOrig.Controls.Add(panNewClause)

                Dim rtbChanges As New RichTextBox
                rtbChanges.Height = boxHeight
                rtbChanges.Width = flowAmendDesc.Width - 4
                rtbChanges.Multiline = True
                rtbChanges.AutoWordSelection = False
                flowAmendDesc.Height += boxHeight
                flowAmendDesc.Controls.Add(rtbChanges)
                'ApplyTextSize(rtbChanges)

                Dim rtbProposed As New RichTextBox
                rtbProposed.Height = boxHeight
                rtbProposed.Width = flowPropText.Width - 4
                rtbProposed.Multiline = True
                rtbProposed.ReadOnly = True
                rtbProposed.Tag = "999"
                rtbProposed.BackColor = Color.Gainsboro
                flowPropText.Height += boxHeight
                flowPropText.Controls.Add(rtbProposed)
                'ApplyTextSize(rtbProposed)

                AddSpacers()

                'after creating all boxes, add resize handlers and then text
                'if done piecewise, first one will attempt to resize others that haven't been created yet
                AddHandler btnNewClauseDiscard.Click, AddressOf DiscardNewClause
                AddHandler rtbChanges.ContentsResized, AddressOf BoxContentsResized
                AddHandler rtbChanges.TextChanged, AddressOf AlwaysUpdateText
                AddHandler rtbProposed.ContentsResized, AddressOf BoxContentsResized
                AddHandler rtbChanges.Click, AddressOf SelectFirstTime
                AddHandler rtbChanges.KeyUp, AddressOf UpdateOnDelete

                rtbChanges.Rtf = amend.textDesc(i)
                'ApplyTextSize(rtbChanges)
                rtbProposed.Rtf = amend.textProp(i)
                'ApplyTextSize(rtbProposed)

            Else 'orig clause, just make text boxes

                'attempt to match to current document
                Dim matchTag As Integer = MatchText(amend.textOrig(i), amend.textDesc(i))
                If matchTag = -1 Then 'discard clause from amendment
                    'work out not displaying the amendment screen if you discard them all

                Else 'clause matches or was reassigned

                    Dim rtbOrig As New RichTextBox
                    rtbOrig.Height = boxHeight
                    rtbOrig.Width = flowAmendOrig.Width - 4
                    rtbOrig.Multiline = True
                    rtbOrig.ReadOnly = True
                    flowAmendOrig.Height += boxHeight

                    rtbOrig.Tag = matchTag.ToString
                    rtbOrig.BackColor = Color.Gainsboro
                    flowAmendOrig.Controls.Add(rtbOrig)

                    Dim rtbChanges As New RichTextBox
                    rtbChanges.Height = boxHeight
                    rtbChanges.Width = flowAmendDesc.Width - 4
                    rtbChanges.Multiline = True
                    rtbChanges.AutoWordSelection = False
                    flowAmendDesc.Height += boxHeight
                    rtbChanges.Tag = matchTag.ToString
                    flowAmendDesc.Controls.Add(rtbChanges)

                    Dim rtbProposed As New RichTextBox
                    rtbProposed.Height = boxHeight
                    rtbProposed.Width = flowPropText.Width - 4
                    rtbProposed.Multiline = True
                    rtbProposed.ReadOnly = True
                    flowPropText.Height += boxHeight
                    rtbProposed.Tag = matchTag.ToString
                    rtbProposed.BackColor = Color.Gainsboro
                    flowPropText.Controls.Add(rtbProposed)

                    AddSpacers()


                    rtbOrig.Rtf = clauseOrigHolder
                    ApplyTextSize(rtbOrig)

                    AddHandler rtbChanges.ContentsResized, AddressOf BoxContentsResized
                    AddHandler rtbChanges.SelectionChanged, AddressOf TriggerShowContext
                    AddHandler rtbChanges.KeyUp, AddressOf UpdateOnDelete
                    rtbChanges.Rtf = clauseDescHolder
                    'ApplyTextSize(rtbChanges)

                    rtbProposed.Rtf = clausePropHolder
                    'ApplyTextSize(rtbProposed)

                    AddHandler rtbChanges.TextChanged, AddressOf AlwaysUpdateText

                End If
            End If

        Next

        flowAmendOrig.Show()
        flowAmendDesc.Show()
        flowPropText.Show()

        Me.Show()
    End Sub

    Private Function MatchText(ByVal origRtf As String, ByVal descRtf As String)
        Dim tagResult As Integer = -1
        Dim doc As ArrayList = Munchkin.docs(resolutionReferred)

        Dim rtb1, rtb2 As New RichTextBox
        For clauseIndex As Integer = 0 To doc.Count - 1
            'check to see if it matches
            'copy to rtbs to avoid caring about formatting
            If doc(clauseIndex).ToString.StartsWith("{\rtf") Then 'go on, as it's RTF
                rtb1.Rtf = origRtf
                rtb2.Rtf = doc(clauseIndex)

                'test without spaces
                If rtb1.Text.Replace(" ", String.Empty) = rtb2.Text.Replace(" ", String.Empty) Then
                    'If RemoveTextSize(origRtf) = RemoveTextSize(doc(clauseIndex)) Then
                    'declare match
                    tagResult = clauseIndex / 2 'the tag is supposed to match with the pickclauses, because it gets reinserted at 2*tag
                    clauseOrigHolder = origRtf
                    clauseDescHolder = descRtf
                    clausePropHolder = GenerateProposedText(descRtf) 'should be equivalent to amend.textProp(i)
                    Return tagResult
                End If
            End If
        Next

        'if it makes it to here, there's still no match, display clausematch to give them the option of what to do
        ClauseMatch.SetAmendConsidered(descRtf)

        If ClauseMatch.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tagResult = clauseMatchIdHolder 'stored here by clausematch before it closes
        Else
            tagResult = -1 'discarded
        End If

        'rtf (clauseorigholder and clausedescholder) will be set in clausematch

        Return tagResult
    End Function

    Private Function RemoveTextSize(ByVal rtf As String)
        'remove mention of text size, to enable comparison on contents
        Dim correctedRtf As String = rtf
        For origSize As Integer = 1 To 140
            correctedRtf = correctedRtf.Replace("\fs" + origSize.ToString + " ", " ")
        Next

        Return correctedRtf
    End Function

    Private Sub ChangeSize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        panelClauses.Size = New Size(Me.Width - 18, Me.Height - 115)
        Dim flowWidth As Integer = (panelClauses.Width - 82) / 3

        flowAmendOrig.Width = flowWidth
        panOrig.Width = flowWidth
        lbOrig.Width = flowWidth
        flowAmendOrig.Location = New Point(0, flowAmendOrig.Location.Y)

        flowAmendDesc.Location = New Point(flowWidth + 37, flowAmendDesc.Location.Y)
        flowAmendDesc.Width = flowWidth
        panDesc.Width = flowWidth
        lbAmend.Width = flowWidth
        panDesc.Location = New Point(flowWidth + 37, panDesc.Location.Y)

        flowPropText.Location = New Point(flowWidth * 2 + 60, flowPropText.Location.Y)
        flowPropText.Width = flowWidth
        panProp.Width = flowWidth
        panProp.Location = New Point(flowWidth * 2 + 60, panProp.Location.Y)
        lbProp.Width = flowWidth


        ResizeAllBoxes(flowAmendOrig)
        ResizeAllBoxes(flowAmendDesc)
        ResizeAllBoxes(flowPropText)
    End Sub

    Private Sub ResizeAllBoxes(ByVal parentFlow As FlowLayoutPanel)
        For Each con As Control In parentFlow.Controls
            If TypeOf con Is RichTextBox Then
                con.Width = parentFlow.Width - 4
                'CType(con, RichTextBox).AppendText(" ") 'add a space to fire the ContentsResized handler, reducing the height
            End If
        Next
    End Sub
End Class