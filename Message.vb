Imports System.Windows.Forms
Public Class Message

    Private Sub Message_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd, MyBase.SizeChanged
        rtbMsgChair.Width = Me.Width - 12
        rtbMsgChair.Height = Me.Height - 60
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFont.Click

        Dim msgchairFont As New FontDialog
        msgchairFont.ShowColor = True
        msgchairFont.Font = rtbMsgChair.Font
        msgchairFont.Color = rtbMsgChair.ForeColor

        If msgchairFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtbMsgChair.Font = msgchairFont.Font
            rtbMsgChair.ForeColor = msgchairFont.Color
        End If
    End Sub

    Private Sub Message_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        Me.Select()
    End Sub

    Private Sub PasteFromClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteFromClipboardToolStripMenuItem.Click
        rtbMsgChair.Paste()
    End Sub

    Private Sub SpeakingListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeakingListToolStripMenuItem.Click
        rtbMsgChair.Clear()
        For Each spkr As Object In Munchkin.lbSpeakers.Items
            rtbMsgChair.AppendText(spkr.ToString + Environment.NewLine)
        Next
    End Sub

    'todo pick a document to insert

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        rtbMsgChair.Clear()
    End Sub

    Private Sub sticky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sticky.Click
        If Me.TopMost = False Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub rtbMsgChair_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbMsgChair.TextChanged
        If rtbMsgChair.TextLength > 15 Then
            Me.Text = "Message - " + (rtbMsgChair.Text.Remove(14, rtbMsgChair.TextLength - 14)).Replace(vbLf, " ") + "..."
        Else
            Me.Text = "Message"
        End If
    End Sub

    Private Sub ActiveDocumentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveDocumentToolStripMenuItem.Click
        Munchkin.CopyActiveDocToRTB(rtbMsgChair)
    End Sub
End Class