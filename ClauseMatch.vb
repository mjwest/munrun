Public Class ClauseMatch

    Public Sub SetAmendConsidered(ByVal rtfOutdated As String)
        rtbOutdated.Clear()
        rtbOutdated.Rtf = rtfOutdated

        'reset visibility and contents
        panelDiscardClause.Hide()
        panelMarkUpdate.Hide()
        rbKeep.Checked = False
        rbDiscard.Checked = False
        btnAcceptUpdate.Enabled = False
        rtbNewAmend.Clear()
        rtbNewOrig.Clear()

        cbNewOrig.Items.Clear()
        For Each clauseDesc As Object In Munchkin.clbClauses.Items
            cbNewOrig.Items.Add(clauseDesc.ToString)
        Next
    End Sub

    Private Sub SwapPanels() Handles rbKeep.CheckedChanged, rbDiscard.CheckedChanged
        If rbKeep.Checked Then 'show keeping markup panel
            panelDiscardClause.Hide()
            panelMarkUpdate.Show()
            rtbNewAmend.Clear()
            rtbNewOrig.Clear()
        ElseIf rbDiscard.Checked Then 'show discard button
            panelDiscardClause.Show()
            panelMarkUpdate.Hide()
        Else 'hide both
            panelDiscardClause.Hide()
            panelMarkUpdate.Hide()
        End If
    End Sub

    Private Sub TriggerShowContext(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbNewAmend.SelectionChanged
        If CType(sender, RichTextBox).SelectionLength > 0 Then
            AddHandler (CType(sender, RichTextBox)).MouseUp, AddressOf ShowContext
        End If
    End Sub

    Private Sub ShowContext(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmsMarkupText.Show(Cursor.Position)
        RemoveHandler (CType(sender, RichTextBox)).MouseUp, AddressOf ShowContext
    End Sub

    Private Sub cbNewOrig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNewOrig.SelectedIndexChanged
        If cbNewOrig.SelectedIndex <> Nothing Then
            rtbNewOrig.Rtf = CType(Munchkin.flowRes.Controls(2 * cbNewOrig.SelectedIndex + 1), RichTextBox).Rtf
            rtbNewAmend.Rtf = CType(Munchkin.flowRes.Controls(2 * cbNewOrig.SelectedIndex + 1), RichTextBox).Rtf
            btnAcceptUpdate.Enabled = True
        End If

        'probably need a check on what happens if you swap the clause it refers to after you start marking up the amendment
    End Sub

    Private Sub btnDiscardClause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiscardClause.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AcceptUpdate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptUpdate.Click

        Amendments.clauseMatchIdHolder = cbNewOrig.SelectedIndex
        Amendments.clauseDescHolder = rtbNewAmend.Rtf
        Amendments.clauseOrigHolder = rtbNewOrig.Rtf
        Amendments.clausePropHolder = Amendments.GenerateProposedText(rtbNewAmend.Rtf)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub MarkText(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click, cmsDelete.Click, cmsOrig.Click

        If rtbNewAmend.SelectionLength > 0 Then 'something is selected
            Dim str As String = rtbNewAmend.SelectedRtf
            If Not str.Contains("\colortbl") Then
                str = str.Insert(str.IndexOf("}}") + 2, Environment.NewLine + "{\colortbl;\red255\green0\blue0;\red0\green112\blue192;}")
            Else
                Dim startTbl As Integer = str.IndexOf("\colortbl")
                Dim endTbl As Integer = str.IndexOf("}", startTbl)
                str = str.Remove(startTbl, endTbl - startTbl)
                str = str.Insert(startTbl, "\colortbl ;\red255\green0\blue0;\red0\green112\blue192;")
            End If

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
                str = str.Insert(str.IndexOf("\pard"), "\cf2\ul") 'blue underline for addtion
                str = str.Insert(str.Length - 3, "\cf0\ulnone")
            ElseIf sender.Equals(cmsDelete) Then
                str = str.Insert(str.IndexOf("\pard"), "\cf1\strike") 'red strikethrough for deletion
                str = str.Insert(str.Length - 3, "\cf0\strike0")
            ElseIf sender.Equals(cmsOrig) Then
                'don't need to do anything else as stripping out all the formatting above is sufficient

            End If

            'set rtf back
            rtbNewAmend.SelectedRtf = str
        End If
    End Sub

    Private Sub btnDecideOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecideOption.Click
        MessageBox.Show("If the clause this amendment used to refer to has since been deleted or drastically modified, so that this part of the amendment isn't relevant any more, discard it. If the clause still exists and this amendment is changing a different part of it, keep it, and update it so that you can incorporate this amendment's changes to the new clause text.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class