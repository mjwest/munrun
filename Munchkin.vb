Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.InteropServices
Imports Word = Microsoft.Office.Interop.Word
Imports System.Net.Mail
Imports TwitterVB2




Public Class Munchkin
    Dim vc As Integer = 0 'used for voting confirmation button - vc = voteCounter
    Dim votes_for, votes_against, votes_abstain, votes_novote As Integer ' for counting vote totals
    Private desktopDir As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim loadDir As String = desktopDir
    Dim saveDir As String = desktopDir
    Dim loadComDir As String = desktopDir
    Dim loadFilter As Integer = 1
    Private voteInProgress As Boolean = False
    Dim nonNumberEntered As Boolean = False
    Dim vetoFlag As Boolean = False
    Public numberSubst As Integer = 9
    Dim lastVote As Integer
    Public allowSubst As Boolean = False
    Dim autosaveOn As Boolean = True
    Public docs As New List(Of ArrayList)
    Public amends As New List(Of Amendment)
    Public docAmends As New List(Of List(Of Integer))
    Public docSponsors As New List(Of SponsorSet)
    Public numdocs As Integer = 0
    Dim showingResolution As Boolean = False
    Dim backupCount As Integer = 0
    Dim activeRes As Integer = 0
    Public displaySize As Integer = 30
    Private customLibrary As New ArrayList
    Private customLibraryCounter As Integer = 0
    Private searchOffset As Integer = 0
    Public dropioPage As String = ""
    Public sponsorsList As String = ""
    Private numPublished As Integer = 0
    Public showWordWarning As Boolean = True
    Private suppressFlowShow As Boolean = False
    Public vetoPowers As New List(Of String)
    Public modCaucFont As Font = New Font("Segoe UI", 18)
    Public readTweetIds As New List(Of Long)
    Private tw As New TwitterVB2.TwitterAPI


    Private Sub Munrun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BackupTimer.Start()
        GeneralTimer.Start()

        Timer.SetTime(1, 0) 'on initial load not every activation

        SetCountryNames()

        tsbShowSponsors.Enabled = False
        tsbPublishOnline.Enabled = False
        panTickAllNone.Hide()

        dbVoteType.SelectedIndex = 0 'select default vote type

        panVotingButtons.Hide()
        ModCaucus.dbMCTimeType.SelectedIndex = 0 'mins

        lblLibraryDoc.Text = ""

        ActivityTab.TabPages.Remove(Testing)

        'artificial delay for splash screen
        'Me.Hide()
        'System.Threading.Thread.Sleep(2000) 'display splash
        'Me.Show()
        'Me.BringToFront()

    End Sub

    Private Sub SetCountryNames()
        For Each i As ListViewItem In lvAvailable.Items
            i.Name = i.Text
        Next
    End Sub

    Private Sub btnBeginVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeginVote.Click
        If lvVoting.Items.Count > 0 Then
            'initialise voting
            voteInProgress = True

            dbVoteType.Enabled = False
            btnCancelVote.Show()
            lblCancelVote.Show()
            btnBeginVote.Hide()
            lblBeginVote.Hide()
            btnVotePref.Hide()
            lblVotePref.Hide()

            rtbResults.Clear()
            tbVoteResult.Clear()
            vc = 0 'reset counter to first country

            tbCurrentCountry.Show()
            rbnFor.Show()
            rbnAgainst.Show()
            rbnAbstain.Show()
            cbRights.Show()
            btnConfirmVote.Show()
            btnUndoVote.Show()
            lblUndoVote.Show()

            panVotingButtons.Show()
            panVoteResults.Hide()

            tbCurrentCountry.Text = lvVoting.Items(0).Text

            votes_for = 0
            votes_against = 0
            votes_abstain = 0
            votes_novote = 0

            'committees tab unavailable
            PanelDelegates.Enabled = False

            'show voting equipment
            rbnAbstain.Checked = True
            tbProgFor.Text = "0"
            tbProgAga.Text = "0"
            tbProgAbsNV.Text = "0"

        Else
            MessageBox.Show("No delegates with voting rights in committee. Please add delegates before voting.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnUndoVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndoVote.Click
        'Need to remove visual indicators and subtract from counters
        Try
            rtbResults.Text = rtbResults.Text.Remove(rtbResults.Text.LastIndexOf("*"), rtbResults.Text.Length - rtbResults.Text.LastIndexOf("*"))
            vc -= 1
            tbCurrentCountry.Text = lvVoting.Items(vc).Text
            btnUndoVote.Enabled = False

            If lastVote = 1 Then 'it was for
                votes_for -= 1
                tbProgFor.Text = (CInt(tbProgFor.Text) - 1).ToString
            ElseIf lastVote = 2 Then 'it was against but not a veto
                votes_against -= 1
                tbProgAga.Text = (CInt(tbProgAga.Text) - 1).ToString
            ElseIf lastVote = 3 Then 'it was the first veto - note that veto only gets set once so it is OK to undo it
                votes_against -= 1
                tbProgAga.Text = (CInt(tbProgAga.Text) - 1).ToString
                vetoFlag = False
            ElseIf lastVote = 4 Then 'it was an abstention
                tbProgAbsNV.Text = (CInt(tbProgAbsNV.Text) - 1).ToString
                votes_abstain -= 1
            Else
                'Something is wrong
            End If
        Catch
            MessageBox.Show("There is no vote to undo.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnConfirmVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmVote.Click
        btnUndoVote.Enabled = True

        Dim count As Integer = lvVoting.Items.Count
        Dim totalfa, votes_required As Integer
        rtbResults.AppendText("* ")
        rtbResults.AppendText(lvVoting.Items(vc).Text)
        rtbResults.AppendText(" - ")
        ' examine radio buttons
        If rbnFor.Checked = True Then
            rtbResults.AppendText("For")
            votes_for += 1
            tbProgFor.Text = (CInt(tbProgFor.Text) + 1).ToString
            lastVote = 1
        ElseIf rbnAgainst.Checked = True Then
            rtbResults.AppendText("Against")
            votes_against += 1
            tbProgAga.Text = (CInt(tbProgAga.Text) + 1).ToString
            lastVote = 2
            If vetoFlag = False Then
                vetoFlag = (dbVoteType.SelectedIndex = 2 And vetoPowers.Contains(tbCurrentCountry.Text)) 'vote type set to include veto, and current country has veto power
                lastVote = 3
            End If
            'separate append text check since vetoFlag is only set once, but we want to display veto for anyone who does
            If dbVoteType.SelectedIndex = 2 And vetoPowers.Contains(tbCurrentCountry.Text) Then
                rtbResults.AppendText(" (Veto)")
            End If

        ElseIf rbnAbstain.Checked = True Then
            rtbResults.AppendText("Abstain")
            tbProgAbsNV.Text = (CInt(tbProgAbsNV.Text) + 1).ToString
            votes_abstain += 1
            lastVote = 4
        End If

        If cbRights.Checked Then
            rtbResults.AppendText(" with rights")
        End If

        If vc < (count - 1) Then 'count-1 is the index of the last term as count runs from 1, index runs from 0
            'move to next country
            vc += 1
            tbCurrentCountry.Text = lvVoting.Items(vc).Text 'update text box

        ElseIf vc = (count - 1) Then
            'vote finished
            PanelDelegates.Enabled = True
            tbCurrentCountry.Text = "Voting complete."

            btnBeginVote.Show()
            lblBeginVote.Show()
            btnCancelVote.Hide()
            lblCancelVote.Hide()
            btnVotePref.Show()
            lblVotePref.Show()

            tbCurrentCountry.Hide()
            rbnFor.Hide()
            rbnAgainst.Hide()
            rbnAbstain.Hide()
            cbRights.Hide()
            btnConfirmVote.Hide()
            btnUndoVote.Hide()
            lblUndoVote.Hide()

            panVoteResults.Show()

            totalfa = count - votes_novote - votes_abstain
            'calculate votes needed to pass the measure 
            If dbVoteType.SelectedIndex > 0 Then 'it's selected to be a substantive vote
                votes_required = numberSubst
            Else
                votes_required = Math.Ceiling((totalfa + 1) / 2) '(simple majority)
            End If

            'calculate and display results
            If votes_required > 0 Then
                If vetoFlag = False Then
                    If votes_for >= votes_required Then
                        tbVoteResult.Text = "Motion passes"
                        If votes_against = 0 Then
                            tbVoteResult.AppendText(" unanimously")
                        End If
                    ElseIf votes_for < votes_required Then
                        If votes_for = votes_against Then
                            tbVoteResult.Text = "Motion hangs" 'in future, may put in ability to select ROP and set what happens to a hung vote.
                        Else
                            tbVoteResult.Text = "Motion fails"
                            If votes_for = 0 Then
                                tbVoteResult.AppendText(" unanimously")
                            End If
                        End If
                    End If
                ElseIf vetoFlag = True Then
                    tbVoteResult.Text = "Motion fails by veto of permanent member"
                    vetoFlag = False
                End If
                tbVoteResult.AppendText(".")
            End If
            panVoteResults.Show()
            dbVoteType.Enabled = True
            btnViewResults.Show()
            SaveResults(Me, e)
        End If
        rtbResults.AppendText(Environment.NewLine)
        rtbResults.ScrollToCaret()
        cbRights.Checked = False 'reset
    End Sub
    Private Sub CancelVote(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelVote.Click

        rtbResults.Clear()
        vetoFlag = False
        tbVoteResult.Clear()
        panVotingButtons.Hide()
        panVoteResults.Hide()
        PanelDelegates.Enabled = True

        dbVoteType.Enabled = True
        btnVotePref.Enabled = True

        btnBeginVote.Show()
        lblBeginVote.Show()
        btnCancelVote.Hide()
        lblCancelVote.Hide()
        btnVotePref.Show()
        lblVotePref.Show()

    End Sub

    Private Sub btnAddCustomCountry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCustomCountry.Click
        AddCustomCountry.tbCustomCountry.Clear()
        AddCustomCountry.ShowDialog()
    End Sub

    Private Sub AddToListView(ByRef lv As ListView)
        For Each i As ListViewItem In lvAvailable.CheckedItems
            If Not (lvVoting.Items.ContainsKey(i.Name) Or lvNGO.Items.ContainsKey(i.Name) Or lvObserver.Items.ContainsKey(i.Name)) Then
                Dim k As New ListViewItem
                k = i.Clone()
                k.Name = i.Name
                lv.Items.Add(k)
            End If
            i.Checked = False
        Next
    End Sub

    Private Sub CountryButtons(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCountries.Click, btnAddObserver.Click, btnAddNGO.Click, btnRemoveCountries.Click
        If sender.Equals(btnAddCountries) Then
            AddToListView(lvVoting)
            'AddToListView(vetoSubst)

        ElseIf sender.Equals(btnAddNGO) Then
            AddToListView(lvNGO)

        ElseIf sender.Equals(btnAddObserver) Then
            AddToListView(lvObserver)

        ElseIf sender.Equals(btnRemoveCountries) Then
            If lvVoting.SelectedItems.Count > 0 Then
                For Each i As ListViewItem In lvVoting.SelectedItems
                    lvVoting.Items.Remove(i)
                Next
            ElseIf lvNGO.SelectedItems.Count > 0 Then
                For Each i As ListViewItem In lvNGO.SelectedItems
                    lvNGO.Items.Remove(i)
                Next
            ElseIf lvObserver.SelectedItems.Count > 0 Then
                For Each i As ListViewItem In lvObserver.SelectedItems
                    lvObserver.Items.Remove(i)
                Next
            End If

        End If

        UpdateStats()
    End Sub

    Private Sub UpdateStats()
        'non button-specific stats update:

        'total delegates
        Statistics.lbShowDelegates.Text = (lvVoting.Items.Count + lvObserver.Items.Count + lvNGO.Items.Count).ToString()

        'quorum
        Statistics.lbShowQuorum.Text = (Math.Ceiling((lvVoting.Items.Count + lvObserver.Items.Count + lvNGO.Items.Count) / 2)).ToString()

        'signatories
        If cbSelectCommittee.Text = "Security Council" Then
            Statistics.lbSignatoriesRes.Text = 3.ToString() 'AMUNC interpretation
            Statistics.lbSignatoriesResExp.Text = "(Security Council)"
        Else
            Statistics.lbSignatoriesRes.Text = (Math.Ceiling((lvVoting.Items.Count + lvObserver.Items.Count) / 4)).ToString() 'AMUNC interpretation
            Statistics.lbSignatoriesResExp.Text = "25% of eligible"
        End If

        Statistics.lbSignatoriesAmend.Text = (Math.Ceiling((lvVoting.Items.Count + lvObserver.Items.Count) / 10)).ToString() 'AMUNC interpretation

        'countries voting
        Statistics.lbShowVoting.Text = (lvVoting.Items.Count).ToString()
    End Sub

    Private Sub btnLibrarySelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLibrarySelect.Click
        LibrarySelect.tvLibrary.SelectedNode = LibrarySelect.tvLibrary.Nodes(0)
        If LibrarySelect.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblLibraryDoc.Text = LibrarySelect.tvLibrary.SelectedNode.Parent.Text + " > " + LibrarySelect.tvLibrary.SelectedNode.Text

            'don't show fullpath, just show parent
            RetrieveLibrary()
            rtbLibrary.Select()
            searchOffset = 0 'reset search
        End If
    End Sub

    Public Sub RetrieveLibrary()

        If LibrarySelect.tvLibrary.SelectedNode.Parent Is LibrarySelect.tvLibrary.Nodes("Custom") Then
            'custom, get from array
            rtbLibrary.Text = customLibrary(CInt(LibrarySelect.tvLibrary.SelectedNode.Name))
        Else
            'retrieve from resources
            Select Case LibrarySelect.tvLibrary.SelectedNode.Text
                Case "Sydney (SydMUN)"
                    rtbLibrary.Text = My.Resources.ROP_SydMUN
                Case "Sydney Schools' (SUSMUN)"
                    rtbLibrary.Text = My.Resources.ROP_SUSMUN
                Case "Asia-Pacific (AMUNC)"
                    rtbLibrary.Text = My.Resources.ROP_AMUNC
                Case "Harvard (WorldMUN)"
                    rtbLibrary.Text = My.Resources.ROP_WorldMUN
                Case "Oxford (OxIMUN)"
                    rtbLibrary.Text = My.Resources.ROP_Oxford
                Case "Cambridge (CUIMUN)"
                    rtbLibrary.Text = My.Resources.ROP_Cambridge
                Case "Charter of the United Nations"
                    rtbLibrary.Text = My.Resources.UN_Charter
                Case "Statute of the International Court of Justice"
                    rtbLibrary.Text = My.Resources.UN_StatuteICJ
                Case "Universal Declaration of Human Rights"
                    rtbLibrary.Text = My.Resources.UN_UnDecHR
                Case "Kyoto Protocol"
                    rtbLibrary.Text = My.Resources.IT_Kyoto
                Case "Convention I (Wounded and Sick in the Field)"
                    rtbLibrary.Text = My.Resources.IT_Geneva1
                Case "Convention II (Wounded and Sick at Sea)"
                    rtbLibrary.Text = My.Resources.IT_Geneva2
                Case "Convention III (Prisoners of War)"
                    rtbLibrary.Text = My.Resources.IT_Geneva3
                Case "Convention IV (Civilians in Wartime)"
                    rtbLibrary.Text = My.Resources.IT_Geneva4
                Case "Protocol I (Victims of International Conflict)"
                    rtbLibrary.Text = My.Resources.IT_GenevaI
                Case "Protocol II (Victims of Non-International Conflict)"
                    rtbLibrary.Text = My.Resources.IT_GenevaII
                Case "Protocol III (Distinctive Emblem)"
                    rtbLibrary.Text = My.Resources.IT_GenevaIII

            End Select

        End If
    End Sub

    Private Sub CheckNonNumber(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tstSpkTime.KeyDown
        ' Handle the KeyDown event to determine the type of character entered into the control.

        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a number from the top of the keyboard.
        ' Outside D0 to D9; or, from top of keyboard, but Shift pressed.
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 OrElse e.Shift = True Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub
    Private Sub HandleNonNumber(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tstSpkTime.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub
    Private Sub tsbModCaucusClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModCaucus.Show()
    End Sub
    Private Sub PrepareResults(ByVal target As RichTextBox)
        Dim currentTime As Date = TimeOfDay
        With target
            .AppendText("======================================")
            .AppendText(Environment.NewLine)
            .AppendText(cbSelectCommittee.Text)
            .AppendText(Environment.NewLine)
            .AppendText("Vote saved at " + TimeString + " on " + DateString)
            .AppendText(Environment.NewLine + Environment.NewLine)
            .AppendText(tbVoteResult.Text)
            .AppendText(Environment.NewLine)
            .AppendText("For: " + tbProgFor.Text + ", ")
            .AppendText("Against: " + tbProgAga.Text + ", ")
            .AppendText("Abstain: " + tbProgAbsNV.Text + ", ")
            .AppendText(Environment.NewLine + Environment.NewLine)
            .AppendText("Votes by country:")
            .AppendText(Environment.NewLine)
            .AppendText(rtbResults.Text)
            .AppendText(Environment.NewLine)
            .AppendText("======================================")
            .AppendText(Environment.NewLine)
        End With
    End Sub
    Private Sub SaveResults(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SavedVotes.Show()
        SavedVotes.Visible = False
        PrepareResults(SavedVotes.rtbSavedVotes)
        SavedVotes.Hide()
    End Sub
    Private Sub ViewResults(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewResults.Click
        SavedVotes.Show()
        SavedVotes.BringToFront()

    End Sub

    Private Sub LoadSpeakers()
        tscSpkr.Items.Clear()
        For Each i As ListViewItem In lvVoting.Items
            tscSpkr.Items.Add(i.Text)
        Next
        For Each i As ListViewItem In lvObserver.Items
            tscSpkr.Items.Add(i.Text)
        Next
        For Each i As ListViewItem In lvNGO.Items
            tscSpkr.Items.Add(i.Text)
        Next
        If tscSpkr.Items.Count > 0 Then
            tscSpkr.SelectedIndex = 0
            'if no-one is added, don't select anyone - if they try to add a speaker, the error is prevented below
        End If
    End Sub
    Private Sub ActivityTab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivityTab.SelectedIndexChanged
        Select Case ActivityTab.SelectedIndex
            Case 0 'committee
                If PanelDelegates.Enabled = False And voteInProgress = True Then
                    MessageBox.Show("The committee is locked during voting. Please finish or cancel the current vote.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Case 1 'speaking
                LoadSpeakers()
        End Select
    End Sub
    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFullDel.Click
        If lbSpeakers.SelectedItem <> Nothing Then
            lbSpeakers.Items.Remove(lbSpeakers.SelectedItem)
        End If
    End Sub
    Private Sub AddSpeaker(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFullFor.Click, tsbFullAga.Click, tsbFullNeut.Click
        If tscSpkr.SelectedItem <> Nothing And CInt(tstSpkTime.Text) > 0 Then
            Dim tmpItem As String = tscSpkr.SelectedItem.ToString

            Select Case sender.ToString
                Case tsbFullFor.ToString
                    tmpItem += ", For, "
                Case tsbFullAga.ToString
                    tmpItem += ", Against, "
                Case tsbFullNeut.ToString
                    tmpItem += ", "
            End Select

            tmpItem += tstSpkTime.Text.TrimStart("0") 'add time without leading zeroes

            If tsdMS.Text = "min" Then
                tmpItem += " min"
            ElseIf tsdMS.Text = "sec" Then
                tmpItem += " sec"
            End If

            lbSpeakers.Items.Add(tmpItem)
        End If

    End Sub
    Private Sub MoveSelectedUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFullUp.Click
        If lbSpeakers.SelectedItem <> Nothing Then
            Dim tmpItem As Object = lbSpeakers.SelectedItem
            Dim tmpInd As Integer = lbSpeakers.SelectedIndex
            If tmpInd > 0 Then 'item is not the first item so it can be moved up
                With lbSpeakers
                    .Items.Remove(lbSpeakers.SelectedItem)
                    .Items.Insert(tmpInd - 1, tmpItem)
                    .SetSelected(tmpInd - 1, True)
                End With
            End If
        End If
    End Sub
    Private Sub MoveSelectedDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFullDown.Click
        If lbSpeakers.SelectedItem <> Nothing Then
            Dim tmpItem As Object = lbSpeakers.SelectedItem
            Dim tmpInd As Integer = lbSpeakers.SelectedIndex
            If tmpInd < (lbSpeakers.Items.Count - 1) Then 'item is not the last item so it can be moved down
                With lbSpeakers
                    .Items.Remove(lbSpeakers.SelectedItem)
                    .Items.Insert(tmpInd + 1, tmpItem)
                    .SetSelected(tmpInd + 1, True)
                End With
            End If
        End If
    End Sub
    Private Sub ClearListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFullClear.Click
        lbSpeakers.Items.Clear()
    End Sub
    Private Sub tsbNextSpkr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNextSpkr.Click
        If lbSpeakers.Items.Count > 0 Then
            NextSpeakerDisplay.lblMainSpeaker.Text = lbSpeakers.Items(0).ToString 'speaker who's about to start
            Dim stringparts As Array = lbSpeakers.Items(0).ToString.Split(", ")
            Dim stringend As Array = stringparts(stringparts.Length - 1).ToString.Split(" ") 'split last part into the number and the the trailing min/sec label"
            Dim value As Integer = CInt(stringend(1))

            With Timer
                If stringend(2) = "min" Then
                    Timer.SetTime(value, 0) 'set value as minutes
                ElseIf stringend(2) = "sec" Then
                    If value > 59 Then 'move the excess into minutes
                        Dim s As Integer
                        Dim m As Integer = Math.DivRem(value, 60, s)
                        .SetTime(m, s) 'set value as seconds
                    Else
                        .SetTime(0, value) 'just use seconds
                    End If
                End If
            End With
            lbSpeakers.Items.RemoveAt(0) 'remove main speaker
            ShowTimer()
            With NextSpeakerDisplay
                If lbSpeakers.Items.Count > 0 Then
                    .lblFollowingSpeaker.Text = lbSpeakers.Items(0).ToString 'this is now the up-next speaker
                    .lblFollowingSpeaker.Show()
                    .lblUpNext.Show()
                Else
                    .lblUpNext.Hide()
                    .lblFollowingSpeaker.Hide()
                End If
                .Width = Math.Max(.lblMainSpeaker.Left + .lblMainSpeaker.Width, .lblFollowingSpeaker.Left + .lblFollowingSpeaker.Width) + 30
                .Show()
                .BringToFront()
            End With


        Else : MessageBox.Show("There are no countries in the speaking list.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub ListFontOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListFontOptionsToolStripMenuItem.Click
        Dim lfd As New FontDialog
        lfd.ShowColor = False
        lfd.ShowEffects = False
        lfd.Font = lbSpeakers.Font
        If lfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lbSpeakers.Font = lfd.Font
        End If
    End Sub
    Private Sub YieldToSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YieldToSelectedToolStripMenuItem.Click
        If lbSpeakers.SelectedItem <> Nothing Then
            If Timer.negative = True Then
                Timer.minutes = 0
                Timer.seconds = 0
                Timer.negative = False
            End If
            Dim stringparts As Array = lbSpeakers.SelectedItem.ToString.Split(", ")
            Dim stringend As Array = stringparts(stringparts.Length - 1).ToString.Split(" ") 'split last part into the number and the the trailing min/sec label"
            With Timer
                .btnCTStop_Click()
                If stringend(2) = "min" Then
                    .AddTime(CInt(stringend(1)), 0)
                ElseIf stringend(2) = "sec" Then
                    .AddTime(0, CInt(stringend(1)))
                End If
                .WriteTimer()
                .Show()
            End With
            lbSpeakers.Items.RemoveAt(lbSpeakers.SelectedIndex)
        End If
    End Sub
    Private Sub ChangeTimeOfSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeTimeOfSelectedToolStripMenuItem.Click
        If lbSpeakers.SelectedItem <> Nothing Then
            Dim i As Integer = lbSpeakers.SelectedIndex
            'store the name, speaker type and comma preceding the time
            Dim comma As Integer = lbSpeakers.Items(i).ToString.LastIndexOf(",") + 2
            Dim length As Integer = lbSpeakers.Items(i).ToString.Length
            Dim t As String = lbSpeakers.Items(i).ToString.Remove(comma, length - comma)

            Dim stringparts As Array = lbSpeakers.Items(i).ToString.Split(", ")
            Dim stringend As Array = stringparts(stringparts.Length - 1).ToString.Split(" ") 'split last part into the number and the the trailing min/sec label"

            ChangeTime.nudCT.Value = CInt(stringend(1)) 'set the time value in the NUD
            If stringend(2) = "min" Then
                ChangeTime.rbMinsCT.Checked = True
            ElseIf stringend(2) = "sec" Then
                ChangeTime.rbSecsCT.Checked = True
            End If

            If ChangeTime.ShowDialog() = Windows.Forms.DialogResult.OK Then
                t += ChangeTime.nudCT.Value.ToString 'insert time

                'insert min/sec label
                If ChangeTime.rbMinsCT.Checked = True Then
                    t += " min"
                ElseIf ChangeTime.rbSecsCT.Checked = True Then
                    t += " sec"
                End If

                lbSpeakers.Items.Insert(i, t)
                lbSpeakers.SelectedIndex = i
                lbSpeakers.Items.RemoveAt(i + 1)

            End If

        End If
    End Sub
    Private Sub SaveListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveListToolStripMenuItem.Click
        'get a name for the list from the user
        If SaveListName.ShowDialog = Windows.Forms.DialogResult.OK Then
            'check to see if name has been used
            Dim nameUsed As Boolean = False
            For Each j As Object In lbSaveSpkrNames.Items
                If SaveListName.tbSaveListName.Text = j Then
                    nameUsed = True
                End If
            Next
            If nameUsed = False Then
                'if name is unused, save list under that name
                lbSaveSpkrNames.Items.Add(SaveListName.tbSaveListName.Text)
                'title delimiter 
                lbSaveSpkrs.Items.Add("@" + SaveListName.tbSaveListName.Text)
                For Each i As Object In lbSpeakers.Items
                    lbSaveSpkrs.Items.Add(i)
                Next
                'end delimiter
                lbSaveSpkrs.Items.Add("%")
            ElseIf nameUsed = True Then
                If MessageBox.Show("The name you entered is already in use. Please enter a new name.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    're-call sub to select new name
                    SaveListToolStripMenuItem_Click(Me, e)
                End If
            End If
        End If
    End Sub
    Private Sub LoadListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadListToolStripMenuItem.Click
        If lbSaveSpkrs.Items.Count > 0 Then 'there are some saved lists
            'populate a listbox with contents of lbsavespkrnames
            If LoadList.ShowDialog = Windows.Forms.DialogResult.OK Then
                'remove old list
                lbSpeakers.Items.Clear()
                Dim list As String = "@" + LoadList.cbLoadSpkrs.SelectedItem.ToString
                'MessageBox.Show(list, "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                For Each i As Object In lbSaveSpkrs.Items
                    'find @ + selected name in lbsavespkrs
                    If i.ToString = list Then
                        Dim j As Integer = lbSaveSpkrs.Items.IndexOf(i) + 1
                        'copy following items back into lbspeakers until "%" is reached
                        While lbSaveSpkrs.Items(j) <> "%"
                            lbSpeakers.Items.Add(lbSaveSpkrs.Items(j))
                            j += 1
                        End While
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub Minutes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinutesToolStripMenuItem.Click
        MinutesToolStripMenuItem.Checked = True
        SecondsToolStripMenuItem.Checked = False
        tsdMS.Text = "min"
    End Sub
    Private Sub Seconds(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondsToolStripMenuItem.Click
        MinutesToolStripMenuItem.Checked = False
        SecondsToolStripMenuItem.Checked = True
        tsdMS.Text = "sec"
    End Sub

    Private Sub ShowTimer()
        Timer.Show()
        Timer.BringToFront()
    End Sub

    Private Sub lbSelectCommittee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateStats()
    End Sub

    Private Sub msgDirFontAll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmsiMsgDirAll.Click
        Dim rtb As RichTextBox
        If ActivityTab.SelectedIndex = 4 Then ' library tab
            rtb = rtbLibrary
            'ElseIf ActivityTab.SelectedIndex = 5 Then 'messages tab
            '    rtb = rtbMsgDir
        Else
            rtb = New RichTextBox
        End If

        Dim msgDirFont As New FontDialog
        msgDirFont.ShowColor = True
        msgDirFont.Font = rtb.Font
        msgDirFont.Color = rtb.ForeColor

        If msgDirFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtb.Font = msgDirFont.Font
            rtb.ForeColor = msgDirFont.Color
        End If
    End Sub
    Private Sub msgDirFontSel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmsiMsgDirSel.Click
        Dim rtb As RichTextBox
        If ActivityTab.SelectedIndex = 4 Then ' library tab
            rtb = rtbLibrary
            'ElseIf ActivityTab.SelectedIndex = 5 Then 'messages tab
            '    rtb = rtbMsgDir
        Else
            rtb = New RichTextBox
        End If

        Dim msgDirFont As New FontDialog
        msgDirFont.ShowColor = True
        msgDirFont.Font = rtb.SelectionFont
        msgDirFont.Color = rtb.SelectionColor

        If msgDirFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtb.SelectionFont = msgDirFont.Font
            rtb.SelectionColor = msgDirFont.Color
        End If
    End Sub
    Private Sub tsbAllFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msgDirFontAll(Me, e)
    End Sub
    Private Sub tsbSelFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msgDirFontSel(Me, e)
    End Sub
    Private Sub PositionStatementsAutofillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PositionStatementsAutofillToolStripMenuItem.Click
        If tscSpkr.Items.Count > 0 Then
            For Each i As Object In tscSpkr.Items
                tscSpkr.SelectedItem = i
                AddSpeaker(tsbFullNeut, e)
            Next
            tscSpkr.SelectedIndex = 0
        End If
    End Sub

    'load and save code

    Public Sub LoadCommitteeSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadSessionToolStripMenuItem.Click
        Dim lfd As New OpenFileDialog()
        lfd.InitialDirectory = loadComDir
        lfd.Filter = "Munrun saved session (*.mun)|*.mun|All files|*.*"
        lfd.FilterIndex = 1
        lfd.RestoreDirectory = False
        If lfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            If File.Exists(lfd.FileName) And lfd.FileName.EndsWith(".mun") Then
                loadComDir = lfd.FileName
                Try
                    'should add some code to preserve each thing before you try loading, to restore it if load fails
                    Using fs As New IO.FileStream(lfd.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                        Dim deserial As New BinaryFormatter

                        '*** VARIABLES
                        numberSubst = DirectCast(deserial.Deserialize(fs), Integer)
                        allowSubst = DirectCast(deserial.Deserialize(fs), Boolean)
                        autosaveOn = DirectCast(deserial.Deserialize(fs), Boolean)
                        showingResolution = DirectCast(deserial.Deserialize(fs), Boolean)
                        activeRes = DirectCast(deserial.Deserialize(fs), Integer)
                        displaySize = DirectCast(deserial.Deserialize(fs), Integer)
                        numdocs = DirectCast(deserial.Deserialize(fs), Integer)
                        customLibraryCounter = DirectCast(deserial.Deserialize(fs), Integer)
                        dropioPage = (DirectCast(deserial.Deserialize(fs), String))
                        numPublished = DirectCast(deserial.Deserialize(fs), Integer)
                        showWordWarning = DirectCast(deserial.Deserialize(fs), Boolean)

                        'array variables
                        docs = DirectCast(deserial.Deserialize(fs), List(Of ArrayList))
                        amends = DirectCast(deserial.Deserialize(fs), List(Of Amendment))
                        docAmends = DirectCast(deserial.Deserialize(fs), List(Of List(Of Integer)))
                        docSponsors = DirectCast(deserial.Deserialize(fs), List(Of SponsorSet))
                        customLibrary = DirectCast(deserial.Deserialize(fs), ArrayList)
                        vetoPowers = DirectCast(deserial.Deserialize(fs), List(Of String))

                        'Committee tab
                        cbSelectCommittee.Text = DirectCast(deserial.Deserialize(fs), String)
                        lvAvailable.Items.Clear()
                        lvAvailable.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(ListViewItem)))
                        lvVoting.Items.Clear()
                        lvVoting.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(ListViewItem)))
                        lvObserver.Items.Clear()
                        lvObserver.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(ListViewItem)))
                        lvNGO.Items.Clear()
                        lvNGO.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(ListViewItem)))
                        UpdateStats()

                        'Speaking tab
                        LoadSpeakers()
                        lbSpeakers.Items.Clear()
                        lbSpeakers.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(Object)))
                        tstSpkTime.Text = DirectCast(deserial.Deserialize(fs), String)
                        If DirectCast(deserial.Deserialize(fs), String) = "min" Then : Minutes(Me, e) 'unit set to minutes
                        Else : Seconds(Me, e)
                        End If
                        'The set of saved speaking lists is taken care of in holding tab

                        ''Documents tab

                        If numdocs > 0 Then
                            tsdViewDoc.DropDownItems.Clear()
                            tsdViewAmend.DropDownItems.Clear()
                            'tsdViewDoc.DropDownItems.AddRange(deserial.Deserialize(fs).ToArray(GetType(ToolStripMenuItem)))
                            'tsdViewAmend.DropDownItems.AddRange(deserial.Deserialize(fs).ToArray(GetType(ToolStripMenuItem)))

                            Dim menustore As List(Of List(Of String)) = DirectCast(deserial.Deserialize(fs), List(Of List(Of String)))
                            For Each item As List(Of String) In menustore
                                Dim newmenuitem As New ToolStripMenuItem
                                newmenuitem.Text = item(0)
                                newmenuitem.ImageKey = item(1)
                                newmenuitem.ImageIndex = item(2)
                                tsdViewDoc.DropDownItems.Add(newmenuitem)
                            Next

                            'Dim amendstore As List(Of String) = DirectCast(deserial.Deserialize(fs), List(Of String))
                            'For Each item As String In amendstore
                            '    tsdViewAmend.DropDownItems.Add(item)
                            'Next

                            ShowDocument(tsdViewDoc.DropDownItems(activeRes - 1).Text.Split("|"))
                        End If



                        'Voting tab
                        CancelVote(Me, e)
                        SavedVotes.rtbSavedVotes.Text = DirectCast(deserial.Deserialize(fs), String)
                        With Substantive
                            .nudSubst.Value = DirectCast(deserial.Deserialize(fs), Integer)
                            .cbSubst.Checked = DirectCast(deserial.Deserialize(fs), Boolean)
                            .clbVeto.Items.Clear()
                            .clbVeto.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(Object)))

                            Dim checkedidxs As List(Of Integer) = DirectCast(deserial.Deserialize(fs), List(Of Integer))
                            For Each checkedcountry As Integer In checkedidxs
                                .clbVeto.SetItemChecked(checkedcountry, True)
                            Next

                            ' ''Dim temp As New ListBox
                            'temp.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(Object)))
                            'For Each i As Object In temp.Items
                            '    .clbVeto.Items(.clbVeto.Items.IndexOf(i.ToString)).Checked = True
                            'Next

                        End With

                        'Library tab
                        lblLibraryDoc.Text = DirectCast(deserial.Deserialize(fs), String)
                        rtbLibrary.Text = DirectCast(deserial.Deserialize(fs), String)
                        LibrarySelect.tvLibrary.Nodes.Clear()
                        LibrarySelect.tvLibrary.Nodes.AddRange(deserial.Deserialize(fs).ToArray(GetType(TreeNode)))

                        'Holding tab


                        'Dim checkedveto As New ListView
                        'checkedveto.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(ListViewItem)))
                        'For Each i As ListViewItem In checkedveto.Items
                        '    vetoSubst.Items(vetoSubst.Items.IndexOf(i)).Checked = True
                        'Next
                        lbSaveSpkrs.Items.Clear()
                        lbSaveSpkrs.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(Object)))
                        lbSaveSpkrNames.Items.Clear()
                        lbSaveSpkrNames.Items.AddRange(deserial.Deserialize(fs).ToArray(GetType(Object)))
                        rtbPersistVoteStore.Text = DirectCast(deserial.Deserialize(fs), String)

                    End Using
                Catch 'serialexception as 
                    MessageBox.Show("Sorry, there was an error reading the file. Please select another file.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else : MessageBox.Show("The selected file is not a Munrun saved session. Please select another file.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub


    Public Sub SaveCommitteeSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSessionToolStripMenuItem.Click
        SaveSession(False)
    End Sub

    Private Sub SaveSession(ByVal quitAfter As Boolean)
        Dim sfd As New SaveFileDialog
        sfd.InitialDirectory = loadComDir
        sfd.Filter = "Munrun saved session (*.mun)|*.mun|All files|(*.*)"
        sfd.FilterIndex = 1
        sfd.RestoreDirectory = False
        If voteInProgress = False Or (voteInProgress = True AndAlso MessageBox.Show("There is a vote in progress; its status will not be saved. Do you want to go back and finish the vote before saving?", "Munrun", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                loadComDir = sfd.FileName
                WriteSave(sfd.FileName)
                If quitAfter Then
                    System.Windows.Forms.Application.Exit()
                End If
            End If
        End If


    End Sub

    Private Sub WriteSave(ByVal filename As String)
        Using fs As New FileStream(filename, IO.FileMode.Create)
            Dim bf As New BinaryFormatter

            '*** VARIABLES code

            bf.Serialize(fs, numberSubst)
            bf.Serialize(fs, allowSubst)
            bf.Serialize(fs, autosaveOn)
            bf.Serialize(fs, showingResolution)
            bf.Serialize(fs, activeRes)
            bf.Serialize(fs, displaySize)
            bf.Serialize(fs, numdocs)
            bf.Serialize(fs, customLibraryCounter)
            bf.Serialize(fs, dropioPage)
            bf.Serialize(fs, numPublished)
            bf.Serialize(fs, showWordWarning)

            'Public docs As New ArrayList
            'Public amends As New List(Of Amendment)
            'Public docAmends As New List(Of List(Of Integer))
            'Public docSponsors As New List(Of SponsorSet)

            bf.Serialize(fs, docs)
            bf.Serialize(fs, amends)
            bf.Serialize(fs, docAmends)
            bf.Serialize(fs, docSponsors)
            bf.Serialize(fs, customLibrary)
            bf.Serialize(fs, vetoPowers)

            'Dim listDocs(docs.Count - 1) As ArrayList
            'docs.CopyTo(listDocs)
            'bf.Serialize(fs, listDocs)
            'Dim listAmends(amends.Count - 1) As Amendment
            'amends.CopyTo(listAmends)
            'bf.Serialize(fs, listAmends)
            'Dim listDocAmends(docAmends.Count - 1) As List(Of Integer)
            'docAmends.CopyTo(listDocAmends)
            'bf.Serialize(fs, listDocAmends)
            'Dim listDocSponsors(docSponsors.Count - 1) As SponsorSet
            'docSponsors.CopyTo(listDocSponsors)
            'bf.Serialize(fs, listDocSponsors)
            'Dim customLib(customLibrary.Count - 1) As Object
            'customLibrary.CopyTo(customLib)
            'bf.Serialize(fs, customLib)
            'Dim listVeto(vetoPowers.Count - 1) As String
            'vetoPowers.CopyTo(listVeto)
            'bf.Serialize(fs, vetoPowers)

            '***DESIGNER code

            'Committee tab
            bf.Serialize(fs, cbSelectCommittee.Text)
            bf.Serialize(fs, New ArrayList(lvAvailable.Items))
            bf.Serialize(fs, New ArrayList(lvVoting.Items))
            bf.Serialize(fs, New ArrayList(lvObserver.Items))
            bf.Serialize(fs, New ArrayList(lvNGO.Items))

            'Dim voters(lvVoting.Items.Count - 1) As Object
            'lvVoting.Items.CopyTo(voters, 0)
            'bf.Serialize(fs, voters)
            'Dim observers(lvObserver.Items.Count - 1) As Object
            'lvObserver.Items.CopyTo(observers, 0)
            'bf.Serialize(fs, observers)
            'Dim ngo(lvNGO.Items.Count - 1) As Object
            'lvNGO.Items.CopyTo(ngo, 0)
            'bf.Serialize(fs, ngo)

            'Speaking tab
            bf.Serialize(fs, New ArrayList(lbSpeakers.Items))
            'Dim speaking(lbSpeakers.Items.Count - 1) As Object
            'lbSpeakers.Items.CopyTo(speaking, 0)
            'bf.Serialize(fs, speaking)
            'Dim spktime As String = tstSpkTime.Text
            bf.Serialize(fs, tstSpkTime.Text)
            'Dim spktimeunit As String = tsdMS.Text
            bf.Serialize(fs, tsdMS.Text)
            'The set of saved speaking lists is taken care of in holding tab

            'Documents tab
            If numdocs > 0 Then
                'bf.Serialize(fs, New ArrayList(tsdViewDoc.DropDownItems))
                Dim menustore As New List(Of List(Of String))
                For Each doc As ToolStripMenuItem In tsdViewDoc.DropDownItems
                    Dim tempitem As New List(Of String)
                    tempitem.Add(doc.Text)
                    tempitem.Add(doc.ImageKey)
                    tempitem.Add(doc.ImageIndex)
                    menustore.Add(tempitem)
                Next
                bf.Serialize(fs, menustore)

                'Dont need to save amend menu, displayed by showdocument
                ' bf.Serialize(fs, New ArrayList(tsdViewAmend.DropDownItems))
                'Dim amendstore As New List(Of String)
                'For Each amend As ToolStripMenuItem In tsdViewAmend.DropDownItems
                '    amendstore.Add(amend.Text)
                'Next
                'bf.Serialize(fs, amendstore)
            End If

            'Broken
            'Dim menudocs(tsdViewDoc.DropDownItems.Count - 1) As Object
            'tsdViewDoc.DropDownItems.CopyTo(menudocs, 0)
            'bf.Serialize(fs, menudocs)
            'Dim menuamends(tsdViewAmend.DropDownItems.Count - 1) As Object
            'tsdViewAmend.DropDownItems.CopyTo(menuamends, 0)
            'bf.Serialize(fs, menuamends)

            'two choices, either just save the active res and load it, or try to save each object and don't worry about reloading
            'will attempt first

            'Dim clauses(clbClauses.Items.Count - 1) As Object
            'clbClauses.Items.CopyTo(clauses, 0)
            'bf.Serialize(fs, clauses)
            'Dim checkedclauses(clbClauses.CheckedItems.Count - 1) As Object
            'clbClauses.CheckedItems.CopyTo(checkedclauses, 0)
            'bf.Serialize(fs, checkedclauses)
            'Dim doctitle As String = lblDocTitle.Text
            'bf.Serialize(fs, doctitle)
            'Dim flowChildren(flowRes.Controls.Count - 1) As Object
            'flowRes.Controls.CopyTo(flowChildren, 0)
            'bf.Serialize(fs, flowChildren)

            'Voting tab
            'Stored votes list
            bf.Serialize(fs, SavedVotes.rtbSavedVotes.Text)
            'Substantive votes dialog settings

            With Substantive
                Dim thresh As Integer = .nudSubst.Value
                bf.Serialize(fs, thresh)
                'bf.Serialize(fs, .nudSubst.Value)
                bf.Serialize(fs, .cbSubst.Checked)
                bf.Serialize(fs, New ArrayList(.clbVeto.Items))

                Dim checkedidxs As New List(Of Integer)
                For Each checkedcountry As Object In .clbVeto.CheckedItems
                    checkedidxs.Add(.clbVeto.Items.IndexOf(checkedcountry))
                Next
                bf.Serialize(fs, checkedidxs)


                'Dim subst(.clbVeto.Items.Count - 1) As Object
                '.clbVeto.Items.CopyTo(subst, 0)
                'bf.Serialize(fs, subst)
                'Dim checkedsubst(.clbVeto.CheckedItems.Count - 1) As Object
                '.clbVeto.CheckedItems.CopyTo(checkedsubst, 0)
                'bf.Serialize(fs, checkedsubst)

            End With

            'Library tab
            'Dim libraryname As String = 
            bf.Serialize(fs, lblLibraryDoc.Text)
            'Dim librarydoc As String = 
            bf.Serialize(fs, rtbLibrary.Text)
            'Dim librarynodes(LibrarySelect.tvLibrary.Nodes.Count - 1) As Object 'treeview nodes from selector dialog
            'LibrarySelect.tvLibrary.Nodes.CopyTo(librarynodes, 0)
            bf.Serialize(fs, New ArrayList(LibrarySelect.tvLibrary.Nodes))

            'Holding tab
            'Dim veto(vetoSubst.Items.Count - 1) As Object
            'vetoSubst.Items.CopyTo(veto, 0)
            'bf.Serialize(fs, New ArrayList(vetoSubst.Items))
            'Dim checkedveto(vetoSubst.CheckedItems.Count - 1) As Object
            'vetoSubst.CheckedItems.CopyTo(checkedveto, 0)
            'bf.Serialize(fs, New ArrayList(vetoSubst.CheckedItems))

            'Dim checkedidxs2 As New List(Of Integer)
            'For Each checkedcountry As Object In vetoSubst.CheckedItems
            '    checkedidxs2.Add(vetoSubst.Items.IndexOf(checkedcountry))
            'Next
            'bf.Serialize(fs, checkedidxs2)

            'Dim savespkrs(lbSaveSpkrs.Items.Count - 1) As Object
            'lbSaveSpkrs.Items.CopyTo(savespkrs, 0)
            bf.Serialize(fs, New ArrayList(lbSaveSpkrs.Items))
            'Dim savespkrnames(lbSaveSpkrNames.Items.Count - 1) As Object
            'lbSaveSpkrNames.Items.CopyTo(savespkrnames, 0)
            bf.Serialize(fs, New ArrayList(lbSaveSpkrNames.Items))
            'Dim persistvote As String = 
            bf.Serialize(fs, rtbPersistVoteStore.Text)

            fs.Close()
        End Using

    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnVotePref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Substantive.Show()
    End Sub

    Private Sub dbVoteType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbVoteType.SelectedIndexChanged
        If allowSubst = False And dbVoteType.SelectedIndex > 0 Then
            If MessageBox.Show("Please set up a special majority and veto before using this type of vote. Do you want to do this now?", "Munrun", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Substantive.ShowDialog()
            Else
                dbVoteType.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Munrun_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Select Case SaveClose.ShowDialog
                Case Windows.Forms.DialogResult.Yes
                    SaveSession(True)
                    e.Cancel = True
                Case Windows.Forms.DialogResult.No
                    e.Cancel = False
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If

    End Sub

    Private Sub tsbShowTimer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbShowTimer.Click
        ShowTimer()
    End Sub

    Private Sub tsbAutosave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAutosave.Click
        'Click = toggle autosave
        If autosaveOn = True Then
            autosaveOn = False
            tsbAutosave.Checked = False
            'tsbAutosave.Text = "Enable autosave" 'give option to enable again
            BackupTimer.Stop()
        Else
            autosaveOn = True
            tsbAutosave.Checked = True
            'tsbAutosave.Text = "Disable autosave" 'give option to turn off
            BackupTimer.Start()
        End If
    End Sub

    Private Sub BackupTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupTimer.Tick
        backupCount += 1
        If backupCount = 120 Then
            backupCount = 0
            ' MessageBox.Show(desktopDir + "\Munrun backup " + Today.Day.ToString + "-" + Today.Month.ToString + ".mun")
            WriteSave(desktopDir + "\Munrun backup " + Today.Day.ToString + "-" + Today.Month.ToString + ".mun")
        End If



    End Sub

    Private Sub MessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageToolStripMenuItem.Click
        Dim msg As New Message
        msg.Show()
        msg.BringToFront()
    End Sub

    Private Sub btnImportFromList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportFromList.Click
        If ImportFromList.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim i As Integer = 0
            Dim searchtxt As String = ImportFromList.tbImportList.Text
            Dim tmp As String = ""
            Dim testchar As Char = ""
            While i < searchtxt.Length
                testchar = searchtxt(i)
                If testchar <> vbLf Then
                    tmp = tmp + searchtxt(i)
                Else 'end of line, add to list box
                    AddDelegate(tmp)
                    tmp = ""
                End If
                i = i + 1
            End While
            'add last text which won't have a trailing line feed
            AddDelegate(tmp)
            UpdateStats()
        End If
    End Sub

    Private Sub AddDelegate(ByVal name As String)
        name = name.Trim(vbCr, vbLf)
        If name.Length > 0 Then

            If name.StartsWith("NGO") Then
                Dim delName As String = name.Remove(0, 4)
                If Not (lvNGO.Items.ContainsKey(delName)) Then 'it hasn't been added as an NGO
                    Dim k As New ListViewItem
                    If lvAvailable.Items.ContainsKey(delName) Then 'it exists with flag, so add that
                        k = lvAvailable.Items(delName).Clone()
                    Else
                        k.Text = delName
                        k.Group = lvAvailable.Groups("Custom")
                        k.ImageKey = "munrun-flag.png"
                    End If
                    k.Name = delName
                    lvNGO.Items.Add(k) 'add name minus NGO and space
                    'clean out of other places
                    If lvVoting.Items.ContainsKey(delName) Then lvVoting.Items.RemoveByKey(delName)
                    If lvObserver.Items.ContainsKey(delName) Then lvObserver.Items.RemoveByKey(delName)
                End If
            ElseIf name.StartsWith("OBS") Then
                Dim delName As String = name.Remove(0, 4)
                If Not (lvObserver.Items.ContainsKey(delName)) Then 'it hasn't been added as an observer
                    Dim k As New ListViewItem
                    If lvAvailable.Items.ContainsKey(delName) Then 'it exists with flag, so add that
                        k = lvAvailable.Items(delName).Clone()
                    Else
                        k.Text = delName
                        k.Group = lvAvailable.Groups("Custom")
                        k.ImageKey = "munrun-flag.png"
                    End If
                    k.Name = delName
                    lvObserver.Items.Add(k) 'add name minus OBS and space
                    'clean out of other places
                    If lvVoting.Items.ContainsKey(delName) Then lvVoting.Items.RemoveByKey(delName)
                    If lvNGO.Items.ContainsKey(delName) Then lvNGO.Items.RemoveByKey(delName)
                End If
            Else 'just a regular country
                If Not lvVoting.Items.ContainsKey(name) Then 'it hasn't been added as a voting member
                    Dim k As New ListViewItem

                    If lvAvailable.Items.ContainsKey(name) Then 'it exists with flag, so add that
                        k = lvAvailable.Items(name).Clone()
                    Else
                        k.Text = name
                        k.Group = lvAvailable.Groups("Custom")
                        k.ImageKey = "munrun-flag.png"
                    End If
                    k.Name = name
                    lvVoting.Items.Add(k) 'add name

                    'clean out of other places
                    If lvObserver.Items.ContainsKey(name) Then lvObserver.Items.RemoveByKey(name)
                    If lvNGO.Items.ContainsKey(name) Then lvNGO.Items.RemoveByKey(name)
                End If

            End If
        End If
    End Sub

    Private Sub btnSortVoting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortVoting.Click
        SortListView(lvVoting)
        SortListView(lvNGO)
        SortListView(lvObserver)
    End Sub

    Private Sub SortListView(ByRef lv As ListView)
        With lv
            .Sorting = SortOrder.Ascending
            .Sort()
            .Sorting = SortOrder.None
        End With
    End Sub

    Private Sub btnStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStats.Click
        UpdateStats()
        Statistics.ShowDialog()
    End Sub

    Private Sub tsbNewRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DraftResolutionToolStripMenuItem.Click
        NameAndSponsor.ResMode()
        If NameAndSponsor.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddDoc.Text = "New draft resolution: " + NameAndSponsor.tbDocName.Text
            AddDoc.tslName.Text = NameAndSponsor.tbDocName.Text
            AddDoc.sponsors = NameAndSponsor.mySponsors

            If NameAndSponsor.mySponsors.proposerList.Count > 0 Then
                Dim str As String = NameAndSponsor.mySponsors.proposerList(0).Text
                If lvVoting.Items.ContainsKey(str) Then
                    AddDoc.imgkey = lvVoting.Items(str).ImageKey
                    AddDoc.imgindex = lvVoting.Items(str).ImageIndex
                ElseIf lvObserver.Items.ContainsKey(str) Then
                    AddDoc.imgkey = lvObserver.Items(str).ImageKey
                    AddDoc.imgindex = lvObserver.Items(str).ImageIndex
                Else
                    AddDoc.imgkey = "" 'set to nothing
                    AddDoc.imgindex = Nothing
                End If
            Else 'also set to nothing if no sponsor is selected
                AddDoc.imgkey = "" 'set to nothing
                AddDoc.imgindex = Nothing
            End If

            If AddDoc.ShowDialog() = Windows.Forms.DialogResult.OK Then
                tsdViewDoc.ShowDropDown()
            End If
        End If
    End Sub

    Private Sub WorkingPaperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkingPaperToolStripMenuItem.Click
        NameAndSponsor.WPMode()
        If NameAndSponsor.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddWP.Text = "New working paper: " + NameAndSponsor.tbDocName.Text
            AddWP.tslNameWP.Text = NameAndSponsor.tbDocName.Text
            AddWP.sponsors = NameAndSponsor.mySponsors

            If NameAndSponsor.mySponsors.proposerList.Count > 0 Then
                Dim str As String = NameAndSponsor.mySponsors.proposerList(0).Text
                If lvVoting.Items.ContainsKey(str) Then
                    AddWP.imgkey = lvVoting.Items(str).ImageKey
                    AddWP.imgindex = lvVoting.Items(str).ImageIndex
                ElseIf lvObserver.Items.ContainsKey(str) Then
                    AddWP.imgkey = lvObserver.Items(str).ImageKey
                    AddWP.imgindex = lvObserver.Items(str).ImageIndex
                Else
                    AddWP.imgkey = "" 'set to nothing
                    AddWP.imgindex = Nothing
                End If
            Else 'also set to nothing if no sponsor is selected
                AddWP.imgkey = "" 'set to nothing
                AddWP.imgindex = Nothing
            End If

            If AddWP.ShowDialog() = Windows.Forms.DialogResult.OK Then
                tsdViewDoc.ShowDropDown()
            End If
        End If
    End Sub

    Private Sub NewAmend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNewAmend.Click
        NameAndSponsor.AmendMode()
        If NameAndSponsor.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Set names in title bar
            Amendments.tslAmendName.Text = NameAndSponsor.tbDocName.Text
            Amendments.tslDocName.Text = lblDocTitle.Text
            Amendments.currentAmendment = -1 'new, has no id
            Amendments.titleparts = (lblDocTitle.Text + " | " + activeRes.ToString + "| DR").Split("|")
            Amendments.resolutionReferred = activeRes
            Amendments.tsbPickClauses.Enabled = True
            flowRes.Enabled = False 'deactivate main editing window while amendment is open

            'Populate amendment clause picker 
            PickAmendClauses.lbAvailableClauses.Items.Clear()
            PickAmendClauses.clauseTexts.Clear()
            For i As Integer = 0 To clbClauses.Items.Count - 1
                Dim dispStr As String = (clbClauses.Items(i).ToString.Split(" "))(0) 'get everything before first space
                dispStr += " | " + CType(flowRes.Controls(2 * i + 1), RichTextBox).Text.Remove(Math.Min(70, CType(flowRes.Controls(2 * i + 1), RichTextBox).TextLength - 1)) + "..."
                PickAmendClauses.lbAvailableClauses.Items.Add(dispStr)
                PickAmendClauses.clauseTexts.Add(CType(flowRes.Controls(2 * i + 1), RichTextBox).Text)
            Next

            SetAmendmentTextSize()

            Amender.Show()
            'Amendments.Show()
        End If

    End Sub

    Private Sub SetAmendmentTextSize()

        'This code just sets to medium, which is usually more appropriate

        Amendments.SmallToolStripMenuItem.Checked = False
        Amendments.MediumToolStripMenuItem.Checked = True
        Amendments.LargeToolStripMenuItem.Checked = False
        Amendments.HugeToolStripMenuItem.Checked = False
        Amendments.currentTextSize = 30

        'Below code has it match whatever the DR setting is

        'Amendments.SmallToolStripMenuItem.Checked = False
        'Amendments.MediumToolStripMenuItem.Checked = False
        'Amendments.LargeToolStripMenuItem.Checked = False
        'Amendments.HugeToolStripMenuItem.Checked = False

        'If SmallToolStripMenuItem.Checked Then
        '    Amendments.SmallToolStripMenuItem.Checked = True
        '    Amendments.currentTextSize = 20
        'ElseIf MediumToolStripMenuItem.Checked Then
        '    Amendments.MediumToolStripMenuItem.Checked = True
        '    Amendments.currentTextSize = 30
        'ElseIf LargeToolStripMenuItem.Checked Then
        '    Amendments.LargeToolStripMenuItem.Checked = True
        '    Amendments.currentTextSize = 40
        'ElseIf HugeToolStripMenuItem.Checked Then
        '    Amendments.HugeToolStripMenuItem.Checked = True
        '    Amendments.currentTextSize = 60
        'End If
    End Sub

    Private Sub SearchLibrary() Handles tsbLibraryGo.Click
        If rtbLibrary.Text.Length > 0 Then
            'clear current selection
            rtbLibrary.SelectionLength = 0

            Dim foundIndex As Integer = 0
            Dim searchText As String = rtbLibrary.Text.ToLower
            Dim wordLength As Integer = tbLibrarySearch.Text.Length

            searchText = searchText.Remove(0, searchOffset)

            foundIndex = InStr(searchText, tbLibrarySearch.Text.ToLower)
            'MessageBox.Show(foundIndex)
            If foundIndex = 0 Then
                searchOffset = 0 'reset
                'MessageBox.Show("Text not found", "Munrun", MessageBoxButtons.OK)
            Else
                rtbLibrary.SelectionStart = foundIndex + searchOffset - 1
                rtbLibrary.SelectionLength = wordLength
                searchOffset = searchOffset + foundIndex + wordLength
            End If
        End If
    End Sub

    Private Sub tbLibrarySearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLibrarySearch.Click
        tbLibrarySearch.SelectAll()
    End Sub

    Private Sub tbLibrarySearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbLibrarySearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchOffset = 0
            SearchLibrary()
            rtbLibrary.Select()
        End If
    End Sub

    Private Sub rtbLibrary_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtbLibrary.KeyDown
        If e.KeyCode = Keys.F3 Then
            SearchLibrary()
        End If
    End Sub


    Private Sub ResizeTabs() Handles MyBase.Resize
        ActivityTab.Size = New Size(Me.Width - 16, Me.Height - 60)

        PanelDelegates.Size = New Size(Me.Width - 44, Me.Height - 150)
        lvAvailable.Height = Me.Height - 284
        lvVoting.Height = Me.Height - 400

        flowRes.SuspendLayout()
        Dim width As Integer
        If showingResolution Then
            width = Me.Width - 196
        Else
            width = Me.Width - 36
        End If
        flowRes.Size = New Size(width, Me.Height - 170)
        'also resize all clause textboxes
        For Each con As Control In flowRes.Controls
            If TypeOf con Is RichTextBox Then
                If showingResolution Then
                    con.Width = flowRes.Width - 110
                Else
                    con.Width = flowRes.Width - 24
                End If

            End If
        Next
        flowRes.ResumeLayout()

        lbSpeakers.Size = New Size(Me.Width - 34, Me.Height - 147)
        clbClauses.Height = Me.Height - 252
        rtbLibrary.Size = New Size(Me.Width - 34, Me.Height - 156)
    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
        If MessageBox.Show("Are you sure you want to clear the whole committee?", "Munrun", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            lvVoting.Items.Clear()
            lvNGO.Items.Clear()
            lvObserver.Items.Clear()
        End If
        UpdateStats()
    End Sub

    Public Sub ShowDocument(ByVal titleparts As Array)
        flowRes.Hide()
        flowRes.Controls.Clear()
        If titleparts(2).ToString.EndsWith("WP") Then

            'resize viewing area
            clbClauses.Hide()
            panTickAllNone.Hide()

            flowRes.Left = 6
            flowRes.Width = (Me.Width - 1024) + 828 + 160
            showingResolution = False

            'disable amendments
            tsbNewAmend.Enabled = False
            tsdViewAmend.Enabled = False
            SelectedTextToolStripMenuItem.Enabled = True

            'just display a big textbox in flowres with the text
            Dim rtb As New TextBox
            rtb.Font = New Font("Georgia", 12)
            rtb.Multiline = True
            rtb.AcceptsTab = True
            rtb.Size = New Size(flowRes.Width - 16, flowRes.Height - 16)
            flowRes.Controls.Add(rtb)
            'AddHandler rtb.TextChanged, AddressOf AddDoc.RemoveImages
            rtb.Text = CType(docs(CInt(titleparts(1)))(0), String) ' must set RTF after adding to flowres, or it won't maintain formatting 

        ElseIf titleparts(2).ToString.EndsWith("DR") Then

            'resize viewing area
            clbClauses.Show()
            panTickAllNone.Show()
            flowRes.Left = 166
            flowRes.Width = (Me.Width - 1024) + 828
            showingResolution = True

            'enable amendments and update list
            tsbNewAmend.Enabled = True
            tsdViewAmend.Enabled = True
            Amendments.RefreshAmendments(CInt(titleparts(1)))
            SelectedTextToolStripMenuItem.Enabled = False

            'import resolution
            clbClauses.Items.Clear()
            flowRes.Controls.Clear()

            Dim isClause As Boolean = True 'clauses 0,2,4,... are clauses; 1,3,5,... are labels
            Dim idO, idP, idN As Integer
            Dim arr As ArrayList = docs(CInt(titleparts(1)))
            Dim p As Integer = 0

            For Each str As String In arr

                If isClause Then
                    p += 1
                    'MessageBox.Show(str)
                    Dim rtb As New TextBox
                    rtb.Font = New Font("Georgia", 12)
                    rtb.Width = flowRes.Width - 120
                    rtb.Height = 90
                    rtb.ScrollBars = RichTextBoxScrollBars.None
                    rtb.Multiline = True
                    rtb.AcceptsTab = True
                    flowRes.Controls.Add(rtb)
                    'AddHandler rtb.ContentsResized, AddressOf BoxContentsResized
                    'AddHandler rtb.TextChanged, AddressOf AddDoc.RemoveImages
                    rtb.Text = str
                    'ApplyTextSize(rtb, displaySize)
                    If str.Length = 0 Then
                        rtb.Hide()
                        rtb.Enabled = False
                        rtb.Text = "This clause was deleted."
                    Else
                        'add buttons
                        Dim pan As New Panel
                        Dim btnDel As New Button
                        Dim btnGrow As New Button
                        Dim btnShrink As New Button

                        pan.Width = 30

                        pan.Height = 90

                        btnDel.Size = New Size(24, 24)
                        btnDel.Location = New Point(3, 3)
                        btnDel.BackgroundImage = My.Resources.delete
                        btnDel.BackgroundImageLayout = ImageLayout.Stretch
                        btnDel.BackColor = Color.White
                        btnDel.Anchor = AnchorStyles.Top + AnchorStyles.Right
                        pan.Controls.Add(btnDel)
                        'AddHandler btnDel.Click, AddressOf DeleteAddedClause

                        btnGrow.Size = New Size(24, 24)
                        btnGrow.Location = New Point(3, 30)
                        btnGrow.BackgroundImage = My.Resources.arrow_down_16x16
                        btnDel.BackgroundImageLayout = ImageLayout.Stretch
                        btnGrow.BackColor = Color.White
                        btnGrow.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
                        pan.Controls.Add(btnGrow)
                        'AddHandler btnGrow.Click, AddressOf GrowAddedClause

                        btnShrink.Size = New Size(24, 24)
                        btnShrink.Location = New Point(3, 60)
                        btnShrink.BackgroundImage = My.Resources.arrow_up_16x16
                        btnDel.BackgroundImageLayout = ImageLayout.Stretch
                        btnShrink.BackColor = Color.White
                        btnShrink.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
                        pan.Controls.Add(btnShrink)
                        'AddHandler btnShrink.Click, AddressOf ShrinkAddedClause

                        flowRes.Controls.Add(pan)


                    End If

                Else 'is a label
                    Select Case str
                        Case "Operative"
                            idO += 1
                            'next line gets first word from clause box
                            'relies on clause box already existing 
                            clbClauses.Items.Add("O" + idO.ToString + " | " + flowRes.Controls(2 * p - 1 - 1).Text.Split(" ")(0))
                            'clbClauses.Items.Add("O" + idO.ToString)
                            AddClauseLabel("O" + idO.ToString, p, True)
                        Case "Preamble"
                            idP += 1
                            clbClauses.Items.Add("P" + idP.ToString + " | " + flowRes.Controls(2 * p - 1 - 1).Text.Split(" ")(0))
                            'clbClauses.Items.Add("P" + idP.ToString)
                            AddClauseLabel("P" + idP.ToString, p, True)
                        Case "Notes"
                            idN += 1
                            clbClauses.Items.Add("N" + idN.ToString + " | " + flowRes.Controls(2 * p - 1 - 1).Text.Split(" ")(0))
                            AddClauseLabel("N" + idN.ToString, p, True)
                        Case "Deleted"
                            clbClauses.Items.Add("Deleted")
                            AddClauseLabel("", p, False)

                    End Select

                End If

                isClause = Not isClause 'invert for next string
            Next

            'tick all boxes
            For i As Integer = 0 To clbClauses.Items.Count - 1
                If Not clbClauses.Items(i).ToString = "Deleted" Then
                    clbClauses.SetItemChecked(i, True)
                End If
            Next
        End If

        flowRes.Show() 'hidden on load

        'Update title
        lblDocTitle.Text = titleparts(0).ToString '.Remove(titleparts(0).ToString.Length - 4, 4)
        lblDocTitle.Show()
        tsbShowSponsors.Enabled = True
        tsbPublishOnline.Enabled = True
        activeRes = CInt(titleparts(1))

    End Sub

    Private Sub AddClauseLabel(ByVal text As String, ByVal clauseIndex As Integer, ByVal visible As Boolean)
        Dim lbl As New Label
        lbl.Text = text
        lbl.Font = New Font("Verdana", 20)
        lbl.Height = 90
        lbl.Width = 80
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Visible = visible
        flowRes.Controls.Add(lbl)
        flowRes.Controls.SetChildIndex(lbl, 2 * clauseIndex - 2)
    End Sub


    Private Sub clbClauses_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbClauses.ItemCheck
        'event fires before check is changed. hence, if item is checked when event fires, we want it to disappear

        flowRes.Hide()
        If clbClauses.GetItemChecked(e.Index) = True Then
            flowRes.Controls.Item(2 * e.Index).Hide()
            flowRes.Controls.Item(2 * e.Index + 1).Hide()
        Else
            With flowRes.Controls.Item(2 * e.Index) 'label
                .Show()
                .Tag = 0
            End With
            With flowRes.Controls.Item(2 * e.Index + 1) 'clause
                .Show()
                .BackColor = Color.YellowGreen
                .Tag = 0
            End With
        End If

        If Not suppressFlowShow Then flowRes.Show()

    End Sub

    Private Sub tsdViewDoc_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsdViewDoc.DropDownItemClicked

        'set displayed one to bold and all others back to regular
        For Each item As System.Windows.Forms.ToolStripMenuItem In tsdViewDoc.DropDownItems
            item.Font = New Font(item.Font, FontStyle.Regular)
        Next
        e.ClickedItem.Font = New Font(e.ClickedItem.Font, FontStyle.Bold)

        'get resolution number from name
        Dim titleparts As Array = e.ClickedItem.Text.Split("|")

        'display clause boxes,  refresh amendments if DR, etc
        ShowDocument(titleparts)



    End Sub

    Private Sub tsbModCaucus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModCaucus.Click
        ModCaucus.Show()
    End Sub

    Private Sub btnVotePref_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVotePref.Click
        Substantive.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox.Show()
    End Sub


    Private Sub ApplyTextSize(ByRef rtb As RichTextBox, ByVal textSize As Integer)
        'MessageBox.Show(rtb.Rtf)
        For origSize As Integer = 1 To 140
            rtb.Rtf = rtb.Rtf.Replace("\fs" + origSize.ToString + " ", "\fs" + textSize.ToString + " ")
        Next
    End Sub

    Private Sub ChangeTextSizes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallToolStripMenuItem.Click, MediumToolStripMenuItem.Click, LargeToolStripMenuItem.Click, HugeToolStripMenuItem.Click

        If sender.Equals(SmallToolStripMenuItem) Then
            displaySize = 20
            SmallToolStripMenuItem.Checked = True
            MediumToolStripMenuItem.Checked = False
            LargeToolStripMenuItem.Checked = False
            HugeToolStripMenuItem.Checked = False
        ElseIf sender.Equals(MediumToolStripMenuItem) Then
            displaySize = 30
            SmallToolStripMenuItem.Checked = False
            MediumToolStripMenuItem.Checked = True
            LargeToolStripMenuItem.Checked = False
            HugeToolStripMenuItem.Checked = False
        ElseIf sender.Equals(LargeToolStripMenuItem) Then
            displaySize = 40
            SmallToolStripMenuItem.Checked = False
            MediumToolStripMenuItem.Checked = False
            LargeToolStripMenuItem.Checked = True
            HugeToolStripMenuItem.Checked = False
        ElseIf sender.Equals(HugeToolStripMenuItem) Then
            displaySize = 60
            SmallToolStripMenuItem.Checked = False
            MediumToolStripMenuItem.Checked = False
            LargeToolStripMenuItem.Checked = False
            HugeToolStripMenuItem.Checked = True
        End If

        flowRes.Hide()
        For Each con As Control In flowRes.Controls
            If TypeOf con Is RichTextBox Then 'if statement deleted for now, since they all are
                'CType(con, RichTextBox).ZoomFactor = 1.0
                ApplyTextSize(CType(con, RichTextBox), displaySize)
            End If
        Next
        flowRes.Show()
    End Sub

    Private Sub BoxContentsResized(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ContentsResizedEventArgs)
        CType(sender, RichTextBox).Height = e.NewRectangle.Height + 10
    End Sub

    Private Sub GeneralTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralTimer.Tick
        For Each con As Control In flowRes.Controls
            If con.BackColor = Color.YellowGreen Then
                con.Tag += 1
                If con.Tag = 5 Then
                    con.BackColor = Color.White
                End If
            End If
            'con.BackColor = Color.FromArgb(Math.Min(con.BackColor.R + 50, 255), 255, Math.Min(con.BackColor.B + 50, 255))
        Next
    End Sub

    Private Sub tsbCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCut.Click
        For Each con As Control In flowRes.Controls
            If con.Focused And TypeOf con Is RichTextBox Then
                CType(con, RichTextBox).Cut()
                Exit For 'don't need to search the rest
            End If
            'MessageBox.Show(con.Focused)
        Next
    End Sub

    Private Sub tsbCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCopy.Click
        For Each con As Control In flowRes.Controls
            If con.Focused And TypeOf con Is RichTextBox Then
                CType(con, RichTextBox).Copy()
                Exit For 'don't need to search the rest
            End If
            'MessageBox.Show(con.Focused)
        Next
    End Sub

    Private Sub tsbPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPaste.Click
        For Each con As Control In flowRes.Controls
            If con.Focused And TypeOf con Is RichTextBox Then
                CType(con, RichTextBox).Paste()
                Exit For 'don't need to search the rest
            End If
            'MessageBox.Show(con.Focused)
        Next
    End Sub


    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        For Each con As Control In flowRes.Controls
            If con.Focused And TypeOf con Is RichTextBox Then
                CType(con, RichTextBox).SelectAll()
                Exit For 'don't need to search the rest
            End If
            'MessageBox.Show(con.Focused)
        Next
    End Sub

    Private Sub tstSpkTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tstSpkTime.Click
        tstSpkTime.SelectAll()
    End Sub


    Private Sub lbSpeakers_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lbSpeakers.DragDrop
        'e.Effect = DragDropEffects.Move
    End Sub

    Private Sub tsbAddLibrary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAddLibrary.Click
        AddToLibrary.tbLibraryTitle.Clear()
        AddToLibrary.tbLibraryAdd.Clear()
        If AddToLibrary.ShowDialog = Windows.Forms.DialogResult.OK Then
            LibrarySelect.tvLibrary.Nodes("Custom").Nodes.Add(customLibraryCounter, AddToLibrary.tbLibraryTitle.Text)
            customLibrary.Insert(customLibraryCounter, AddToLibrary.tbLibraryAdd.Text)
            customLibraryCounter += 1
        End If
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        rtbLibrary.Copy()
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem1.Click
        rtbLibrary.SelectAll()
    End Sub

    Private Sub ChangeFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFontToolStripMenuItem.Click
        Dim fd As New FontDialog
        fd.Font = rtbLibrary.Font
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtbLibrary.Font = fd.Font
        End If
    End Sub

    Private Sub clbClauses_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbClauses.DoubleClick
        '        MessageBox.Show(clbClauses.SelectedItem.ToString)
        'give ability to rename what's shown in the clb. 
        'however, would have to persist this across the regeneration after amendments, meaning more data stored in Munrun.docs
    End Sub

    Private Sub tsbExportWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportWord.Click
        If activeRes = 0 Then 'nothing to upload
            MessageBox.Show("You must have an active document in order to export it.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Try
            Dim save As New SaveFileDialog()
            save.InitialDirectory = loadDir
            save.FilterIndex = 1 'needed?
            save.Filter = "Word document (*.docx)|*.docx*"
            save.RestoreDirectory = False

            If save.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                saveDir = save.FileName 'save user-selected dir and filter for next time

                Dim objWord As New Word.Application
                Dim objTempDoc As New Word.Document
                objWord.Visible = False
                'objTempDoc = objWord.NewDocument()

                'insert title
                Dim heading As Word.Paragraph
                heading = objTempDoc.Content.Paragraphs.Add
                heading.Range.Text = lblDocTitle.Text
                heading.Range.Font.Bold = True
                heading.Range.Font.Size = 24
                heading.Range.Font.Name = "Georgia"
                heading.Format.SpaceAfter = 18
                heading.Range.InsertParagraphAfter()

                'copy all clauses - works for WP (just one clause) and DR
                For Each clause As Control In flowRes.Controls
                    If TypeOf clause Is RichTextBox Then
                        Dim para As Word.Paragraph
                        para = objTempDoc.Content.Paragraphs.Add
                        Clipboard.SetText(CType(clause, RichTextBox).Rtf, TextDataFormat.Rtf)
                        para.Range.Paste()
                        para.Format.SpaceAfter = 10
                        para.Range.Font.Size = 10
                        para.Range.InsertParagraphAfter()
                    End If
                Next

                'save
                objTempDoc.SaveAs(CType(save.FileName, Object))

                Clipboard.Clear()
                objWord.Quit()
            End If
        Catch
            MessageBox.Show("Sorry, the export failed.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'alternate option: export to working paper so it's at least all in one box?
        End Try

    End Sub




    Private Sub tsbFullscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFullscreen.Click
        Fullscreen.tslFullscreenName.Text = lblDocTitle.Text
        Fullscreen.rtbFullscreen.ReadOnly = False
        CopyActiveDocToRTB(Fullscreen.rtbFullscreen)
        Fullscreen.rtbFullscreen.ReadOnly = True
        Fullscreen.Show()
    End Sub

    Public Sub CopyActiveDocToRTB(ByRef rtb As RichTextBox)
        rtb.Clear()
        For Each clause As Control In flowRes.Controls
            If TypeOf clause Is TextBox AndAlso CType(clause, TextBox).Text <> "This clause was deleted." Then
                CType(clause, TextBox).SelectAll()
                CType(clause, TextBox).Copy()
                'rtb.Select(rtb.TextLength, 0) 'go to end of rtb
                rtb.Paste()
                rtb.AppendText(Environment.NewLine + Environment.NewLine)
            ElseIf TypeOf clause Is Label AndAlso CType(clause, Label).Text.StartsWith("O") Then
                rtb.AppendText(CType(clause, Label).Text.Remove(0, 1) + ". ")
            End If
        Next
        rtb.Select(0, 0)
        rtb.ScrollToCaret()
    End Sub

    Private Sub lvAvailable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAvailable.SelectedIndexChanged
        For Each country As ListViewItem In lvAvailable.SelectedItems
            country.Checked = Not country.Checked
            'MessageBox.Show("Name: " + country.Name + " Text: " + country.Text)
        Next
    End Sub

    Private Sub cbShowRegions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowRegions.CheckedChanged
        lvAvailable.ShowGroups = cbShowRegions.Checked
    End Sub

    Private Sub ClearSelected(ByRef lv As ListView)
        If lv.SelectedItems.Count > 0 Then
            For Each si As ListViewItem In lv.SelectedItems
                si.Selected = False
            Next
        End If
    End Sub

    Private Sub lvVoting_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lvVoting.ItemDrag
        'Begins a drag-and-drop operation in the ListView control.
        lvVoting.DoDragDrop(lvVoting.SelectedItems, DragDropEffects.Move)
    End Sub

    Private Sub lvVoting_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvVoting.DragEnter
        Dim i As Integer
        For i = 0 To e.Data.GetFormats().Length - 1
            If e.Data.GetFormats()(i).Equals _
               ("System.Windows.Forms.ListView+SelectedListViewItemCollection") Then
                'The data from the drag source is moved to the target.
                e.Effect = DragDropEffects.Move
            End If
        Next
    End Sub

    Private Sub lvVoting_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvVoting.DragDrop
        If lvVoting.SelectedItems.Count = 0 Then Exit Sub

        'Returns the location of the mouse pointer in the ListView control.
        Dim p As Point = lvVoting.PointToClient(New Point(e.X, e.Y))

        'Obtain the item that is located at the specified location of the mouse pointer.
        ' dragItem is the lvi upon which the drop is made
        Dim dragToItem As ListViewItem = lvVoting.GetItemAt(p.X, p.Y)

        If dragToItem Is Nothing Then Exit Sub

        'Obtain the index of the item at the mouse pointer.
        ' dragIndes is the index of the lvi on which the items are dropped
        Dim dragIndex As Integer = dragToItem.Index
        Dim i As Integer

        ' create an array large enough to hold the selected (dragged) items
        Dim sel(lvVoting.SelectedItems.Count) As ListViewItem

        ' the following code moves the dragged selection to their new location.
        For i = 0 To lvVoting.SelectedItems.Count - 1
            sel(i) = lvVoting.SelectedItems.Item(i)
        Next

        For i = 0 To lvVoting.SelectedItems.Count - 1
            'Obtain the ListViewItem to be dragged to the target location.
            Dim dragItem As ListViewItem = sel(i)
            Dim itemIndex As Integer = dragIndex

            If itemIndex = dragItem.Index Then Exit Sub

            If dragItem.Index < itemIndex Then
                itemIndex = itemIndex + 1
            Else
                itemIndex = dragIndex + i
            End If

            'Insert the item in the specified location.
            Dim insertItem As ListViewItem = CType(dragItem.Clone, ListViewItem)
            lvVoting.Items.Insert(itemIndex, insertItem)
            'Removes the item from the initial location while
            'the item is moved to the new location.
            lvVoting.Items.Remove(dragItem)
        Next
    End Sub


    Private Sub TickAllClauses() Handles tsbTickAll.Click
        flowRes.Hide()
        suppressFlowShow = True
        For i As Integer = 0 To clbClauses.Items.Count - 1
            clbClauses.SetItemChecked(i, True)
        Next
        flowRes.Show()
        suppressFlowShow = False
    End Sub

    Private Sub TickNoClauses() Handles tsbTickNone.Click
        flowRes.Hide()
        suppressFlowShow = True
        For i As Integer = 0 To clbClauses.Items.Count - 1
            clbClauses.SetItemChecked(i, False)
        Next
        flowRes.Show()
        suppressFlowShow = False
    End Sub

    Private Sub TickSomeClauses(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbTickPreamble.Click, tsbTickOperative.Click, tsbTickNotes.Click
        Dim comparisonString As String = ""
        If sender.Equals(tsbTickPreamble) Then
            comparisonString = "P"
        ElseIf sender.Equals(tsbTickOperative) Then
            comparisonString = "O"
        ElseIf sender.Equals(tsbTickNotes) Then
            comparisonString = "N"
        End If

        flowRes.Hide()
        suppressFlowShow = True
        For i As Integer = 0 To clbClauses.Items.Count - 1
            If clbClauses.Items(i).ToString.StartsWith(comparisonString) Then
                clbClauses.SetItemChecked(i, True)
            Else
                clbClauses.SetItemChecked(i, False)
            End If
        Next
        flowRes.Show()
        suppressFlowShow = False
    End Sub




    Private Sub SortClauses() Handles tsbSortClauses.Click
        'get titleparts ready for end
        Dim title As String
        title = lblDocTitle.Text + " | " + activeRes.ToString + " | " + "DR"
        Dim titleparts As Array = title.Split("|")
        SortClauses(titleparts)
    End Sub

    Private Sub RefreshActiveDR()
        'get titleparts
        Dim title As String
        title = lblDocTitle.Text + " | " + activeRes.ToString + " | " + "DR"
        Dim titleparts As Array = title.Split("|")
        ShowDocument(titleparts)
    End Sub

    Public Sub SortClauses(ByVal titleparts As Array)

        'take current document
        'create 3 arrays: notes, preamble, operative
        'sort all clauses into those arrays
        'concatenate arrays back into one array and overwrite doc
        'refresh display
        Dim clausesPreamble As New ArrayList
        Dim clausesOperative As New ArrayList
        Dim clausesNotes As New ArrayList

        Dim activeDoc As ArrayList = docs(activeRes)
        'every even string is a clause (including 0 = first), followed by a label in the odd one
        Dim index As Integer = 0

        For Each docPart As String In activeDoc
            If index Mod 2 <> 0 Then 'odd number so label, work with this
                Select Case docPart
                    Case "Operative"
                        clausesOperative.Add(activeDoc(index - 1))
                        clausesOperative.Add(docPart)
                    Case "Preamble"
                        clausesPreamble.Add(activeDoc(index - 1))
                        clausesPreamble.Add(docPart)
                    Case "Notes"
                        clausesNotes.Add(activeDoc(index - 1))
                        clausesNotes.Add(docPart)
                    Case "Deleted"
                End Select
            End If
            index += 1
        Next

        Dim assembledDoc As New ArrayList
        assembledDoc.AddRange(clausesNotes)
        assembledDoc.AddRange(clausesPreamble)
        assembledDoc.AddRange(clausesOperative)

        activeDoc = assembledDoc
        docs(activeRes) = activeDoc

        ShowDocument(titleparts)
    End Sub

    Private Sub tsbClauseUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClauseUp.Click
        If clbClauses.SelectedItem <> Nothing AndAlso clbClauses.SelectedIndex > 0 Then
            Dim clauseIndex As Integer = clbClauses.SelectedIndex

            Dim activeDoc As ArrayList = docs(activeRes)
            Dim clauseToMove As String = activeDoc(2 * clauseIndex)
            Dim labelToMove As String = activeDoc(2 * clauseIndex + 1)

            'order of following steps is important, as the indices will changes with each operation

            'insert new clause
            activeDoc.Insert(2 * clauseIndex - 2, clauseToMove)
            activeDoc.Insert(2 * clauseIndex - 1, labelToMove) '-1 is +1 - 2

            'remove old clause
            activeDoc.RemoveAt(2 * clauseIndex + 3)
            activeDoc.RemoveAt(2 * clauseIndex + 2)

            'restore document
            docs(activeRes) = activeDoc

            'reload
            RefreshActiveDR()

            'restore selection
            clbClauses.SelectedIndex = clauseIndex - 1

        End If
    End Sub

    Private Sub tsbClauseDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClauseDown.Click
        If clbClauses.SelectedItem <> Nothing AndAlso clbClauses.SelectedIndex < clbClauses.Items.Count - 1 Then
            Dim clauseIndex As Integer = clbClauses.SelectedIndex

            Dim activeDoc As ArrayList = docs(activeRes)
            Dim clauseToMove As String = activeDoc(2 * clauseIndex)
            Dim labelToMove As String = activeDoc(2 * clauseIndex + 1)

            'order of following steps is important, as the indices will changes with each operation

            'remove old clause
            activeDoc.RemoveAt(2 * clauseIndex + 1)
            activeDoc.RemoveAt(2 * clauseIndex)


            'insert new clause
            activeDoc.Insert(2 * clauseIndex + 2, labelToMove) '+3 is +1 + 2
            activeDoc.Insert(2 * clauseIndex + 2, clauseToMove)


            'restore document
            docs(activeRes) = activeDoc

            'reload
            RefreshActiveDR()

            'restore selection
            clbClauses.SelectedIndex = clauseIndex + 1

        End If
    End Sub

    Private Sub btnSwitchClauseType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreambleToolStripMenuItem.Click, OperativeToolStripMenuItem.Click, NotesToolStripMenuItem.Click
        If clbClauses.SelectedItem <> Nothing Then
            Dim clauseIndex As Integer = clbClauses.SelectedIndex
            Dim activeDoc As ArrayList = docs(activeRes)
            Dim newLabel As String = "Notes"

            If sender.Equals(PreambleToolStripMenuItem) Then
                newLabel = "Preamble"
            ElseIf sender.Equals(OperativeToolStripMenuItem) Then
                newLabel = "Operative"
            End If

            activeDoc(2 * clauseIndex + 1) = newLabel
            docs(activeRes) = activeDoc

            'reload
            RefreshActiveDR()

        End If
    End Sub


    Private Sub tsdViewAmend_DropDownItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsdViewAmend.DropDownItemClicked
        If Amendments.Visible = True Then
            MessageBox.Show("There is already an amendment open. Please close it before loading a new one.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'MessageBox.Show(e.ClickedItem.Tag.ToString)
            Amendments.resolutionReferred = activeRes
            Amendments.tslDocName.Text = lblDocTitle.Text
            Amendments.titleparts = (lblDocTitle.Text + " | " + activeRes.ToString + "| DR").Split("|")
            Amendments.LoadAmendment(amends(CInt(e.ClickedItem.Tag)))
        End If
    End Sub

    Private Sub tsbShowSponsors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbShowSponsors.Click

        If activeRes > 0 Then 'something is selected
            'load active resolution's sponsors, and show dialog
            Dim sponsors As SponsorSet = docSponsors(activeRes - 1)
            If sponsors.proposerList.Count + sponsors.seconderList.Count + sponsors.sponsorList.Count = 0 Then
                'no sponsors, display message and quit
                MessageBox.Show("This document has no sponsors listed.", "Munrun", MessageBoxButtons.OK)
            Else
                ShowSponsors.LoadSponsors(sponsors)
                ShowSponsors.ShowDialog()
            End If

        End If

    End Sub

    Private Sub btnHideBlankHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideBlankHint.Click
        lblBlankHint.Hide()
        btnHideBlankHint.Hide()
    End Sub

    Private Sub cbSelectCommittee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSelectCommittee.SelectedIndexChanged
        If cbSelectCommittee.Text = "Security Council" Then
            MessageBox.Show("After you have added countries, don't forget to set up the Security Council's special majority and veto rules, in the Voting tab.", "Munrun", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        PanelDelegates.Focus()
    End Sub

    Private Sub SelectedTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedTextToolStripMenuItem.Click
        For Each con As Control In flowRes.Controls
            If con.Focused And TypeOf con Is RichTextBox Then
                Dim fontD As New FontDialog
                fontD.Font = CType(con, RichTextBox).SelectionFont
                If fontD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    CType(con, RichTextBox).SelectionFont = fontD.Font
                End If

                Exit For 'don't need to search the rest
            End If

        Next
    End Sub

   

    Private Sub AmendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Amender.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
    Private Sub pbGrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbGrow.Click

    End Sub
    Private Sub pbShrink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbShrink.Click

    End Sub

    Private Sub tbVoteResult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVoteResult.TextChanged

    End Sub

End Class


<Serializable()> Public Class Amendment
    Public amendId As Integer
    Public amendName As String
    Public textOrig As New List(Of String)
    Public textDesc As New List(Of String)
    Public textProp As New List(Of String)
    Public sponsors As SponsorSet
End Class

<Serializable()> Public Class SponsorSet
    Public proposerList As New List(Of ListViewItem)
    Public seconderList As New List(Of ListViewItem)
    Public sponsorList As New List(Of ListViewItem)

    Public Sub CopyTo(ByRef target As SponsorSet)
        For Each lvi As ListViewItem In Me.proposerList
            target.proposerList.Add(lvi.Clone)
        Next
        For Each lvi As ListViewItem In Me.seconderList
            target.seconderList.Add(lvi.Clone)
        Next
        For Each lvi As ListViewItem In Me.sponsorList
            target.sponsorList.Add(lvi.Clone)
        Next
    End Sub
End Class

<Serializable()> Public Class Document
    Public title As String
    Public sponsors As SponsorSet
    Public clauses As New List(Of Clause)
    Public amendments As New List(Of Amendment)
End Class

Public Class Clause
    Public content As String
    Public type As String       'preamble, operative, notes
End Class
