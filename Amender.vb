Public Class Amender

    Private Sub Amender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        splitAmender.Panel1Collapsed = True
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each panel As Control In flowClauses.Controls
            For Each con As Control In panel.Controls
                If TypeOf con Is TextBox And con.Focused Then
                    CType(con, TextBox).Paste()
                End If
            Next
        Next
    End Sub

    Private Sub splitAmender_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles splitAmender.SplitterMoved
        tbDescription.Height = splitAmender.SplitterDistance - 50
    End Sub

    Private Sub tsbAmendExisting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PickAmendClauses.ShowDialog()
    End Sub

    Private Sub AddNewClause(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nc As New AddedClause
        nc.SetParent(flowClauses)
        nc.InitAddedClause()
    End Sub

    Private Sub Amender_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        splitAmender.Size = New Size(Me.Width - 8, Me.Height - 59)
        If splitAmender.Panel1Collapsed = True Then 'description not visible
            flowClauses.Size = New Size(Me.Width - 20, splitAmender.Height - 8)
        Else
            flowClauses.Size = New Size(Me.Width - 20, splitAmender.Height - splitAmender.SplitterDistance - 13)
        End If
        tbDescription.Width = Me.Width - 21

        'resize clause panels
        For Each pan As Control In flowClauses.Controls
            If TypeOf pan Is Panel Then
                pan.Width = flowClauses.Width - 30
                Dim adjustedWidth As Integer = (pan.Width - 130) / 2
                For Each con As Control In pan.Controls
                    If TypeOf con Is TextBox Then
                        Select Case con.Tag
                            Case "new"
                                con.Width = pan.Width - 124
                            Case "current"
                                con.Width = adjustedWidth
                            Case "edited"
                                con.Width = adjustedWidth
                                con.Left = 92 + adjustedWidth + 6
                        End Select
                    End If
                Next
            End If
        Next

    End Sub

    Private Class AddedClause
        Public pan As New Panel
        Private tb As New TextBox
        Private lbl As New Label
        Private rbPre As New RadioButton
        Private rbOp As New RadioButton
        Private rbNotes As New RadioButton
        Private btnDel As New Button
        Private btnGrow As New Button
        Private btnShrink As New Button
        Private flowParent As FlowLayoutPanel

        Private firstClick As Boolean = True

        Public Sub SetParent(ByRef flowParent As FlowLayoutPanel)
            Me.flowParent = flowParent
        End Sub

        Public Sub InitAddedClause()
            pan.Size = New Size(950, 120)
            pan.BackColor = Color.White

            tb.Size = New Size(826, 111)
            tb.Location = New Point(92, 3)
            tb.Multiline = True
            tb.Font = New Font("Georgia", 14)
            tb.Tag = "new"
            tb.Text = "Click to enter text of new clause"
            tb.ForeColor = Color.DimGray
            AddHandler tb.Click, AddressOf ClearFirstText
            pan.Controls.Add(tb)

            lbl.Location = New Point(4, 3)
            lbl.Font = New Font("Segoe UI", 24)
            lbl.Text = "New"
            lbl.AutoSize = True
            pan.Controls.Add(lbl)

            rbPre.Location = New Point(7, 49)
            rbPre.Text = "Preamble"
            pan.Controls.Add(rbPre)

            rbOp.Location = New Point(7, 71)
            rbOp.Text = "Operative"
            rbOp.Checked = True
            pan.Controls.Add(rbOp)

            rbNotes.Location = New Point(7, 93)
            rbNotes.Text = "Notes"
            pan.Controls.Add(rbNotes)

            btnDel.Size = New Size(24, 24)
            btnDel.Location = New Point(922, 3)
            btnDel.BackgroundImage = My.Resources.delete
            btnDel.BackgroundImageLayout = ImageLayout.Stretch
            btnDel.BackColor = Color.White
            btnDel.Anchor = AnchorStyles.Top + AnchorStyles.Right
            pan.Controls.Add(btnDel)
            AddHandler btnDel.Click, AddressOf DeleteAddedClause

            btnGrow.Size = New Size(24, 24)
            btnGrow.Location = New Point(922, 90)
            btnGrow.BackgroundImage = My.Resources.arrow_down_16x16
            btnDel.BackgroundImageLayout = ImageLayout.Stretch
            btnGrow.BackColor = Color.White
            btnGrow.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
            pan.Controls.Add(btnGrow)
            AddHandler btnGrow.Click, AddressOf GrowAddedClause

            btnShrink.Size = New Size(24, 24)
            btnShrink.Location = New Point(922, 70)
            btnShrink.BackgroundImage = My.Resources.arrow_up_16x16
            btnDel.BackgroundImageLayout = ImageLayout.Stretch
            btnShrink.BackColor = Color.White
            btnShrink.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
            pan.Controls.Add(btnShrink)
            AddHandler btnShrink.Click, AddressOf ShrinkAddedClause

            flowParent.Controls.Add(pan)
        End Sub

        Private Sub ClearFirstText()
            If firstClick = True Then
                tb.Clear()
                tb.ForeColor = Color.Black
                firstClick = False
            End If
        End Sub

        Private Sub GrowAddedClause()
            pan.Height += 30
            tb.Height += 30
        End Sub

        Private Sub ShrinkAddedClause()
            pan.Height -= 30
            tb.Height -= 30
        End Sub

        Private Sub DeleteAddedClause()
            If MessageBox.Show("Are you sure you want to remove this clause?", "Munrun", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                flowParent.Controls.Remove(pan)
            End If
        End Sub

    End Class

    Private Sub tsbAmendExisting_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAmendExisting.Click

    End Sub
End Class

