Public Class Fullscreen
    Public currentTextSize As Integer = 30

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Fullscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        SetSize()
        ' Timer1.Interval = 10
        ' Timer1.Start()
    End Sub

    Private Sub SetSize()
        rtbFullscreen.Width = Me.Width
        rtbFullscreen.Height = Me.Height - 40
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'The following auto-scroll code works, but has a distracting fast caret moving around,
        ' and doesn't give enough time to text at the bottom (because it has to jump right up again)
        'With rtbFullscreen
        '    If .SelectionStart < .TextLength Then
        '        .SelectionStart += 1
        '    Else
        '        .SelectionStart = 0
        '    End If
        'End With
    End Sub

    Private Sub ChangeTextSize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallToolStripMenuItem.Click, MediumToolStripMenuItem.Click, LargeToolStripMenuItem.Click, HugeToolStripMenuItem.Click
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

        ApplyTextSize(rtbFullscreen)

    End Sub

    Private Sub ApplyTextSize(ByRef rtb As RichTextBox)
        For origSize As Integer = 1 To 140
            rtb.Rtf = rtb.Rtf.Replace("\fs" + origSize.ToString + " ", "\fs" + currentTextSize.ToString + " ")
        Next
    End Sub


    Private Sub tsbCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCopy.Click
        rtbFullscreen.SelectAll()
        rtbFullscreen.Copy()
    End Sub
End Class