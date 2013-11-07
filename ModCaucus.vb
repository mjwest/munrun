Public Class ModCaucus
    Dim freshResetCauc, freshResetSpkr As Boolean
    Dim minutesCauc, secondsCauc, minutesSpkr, secondsSpkr As Integer

    Private Sub ModCaucus_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        'snap
        If Me.Width < 450 Then
            Me.Width = 300
            Me.Height = 530
        Else
            Me.Width = 600
            Me.Height = 396
        End If

        flowMC.Width = Me.Width - 5
        panMCTopic.Width = Me.Width - 15
        rtbModCaucus.Width = Me.Width - 30

    End Sub

    'Caucus timer code

    Private Sub TimerCauc_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCauc.Tick
        UpdateTimerCauc()
        WriteTimerCauc()
    End Sub

    Private Sub UpdateTimerCauc()
        If secondsCauc > 0 Then
            secondsCauc -= 1
        ElseIf secondsCauc = 0 And minutesCauc > 0 Then
            secondsCauc = 59
            If minutesCauc > 0 Then
                minutesCauc -= 1
            End If
        End If
    End Sub

    Private Sub WriteTimerCauc()
        If minutesCauc < 100 Then
            tbMCCaucTime.Text = minutesCauc.ToString + ":"
            If secondsCauc < 10 Then
                tbMCCaucTime.AppendText("0")
            End If
            tbMCCaucTime.AppendText(secondsCauc.ToString)
        Else
            tbMCCaucTime.Text = minutesCauc.ToString + "m"
        End If
    End Sub

    Private Sub btnMCCaucStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCCaucStart.Click
        If freshResetCauc = True Then
            btnMCCaucReset_Click(Me, e)
            freshResetCauc = False
        End If

        TimerCauc.Start()
        btnMCCaucStop.Show()
        btnMCCaucStop.Select()
        btnMCCaucStart.Hide()
    End Sub

    Private Sub btnMCCaucStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCCaucStop.Click
        TimerCauc.Stop()
        btnMCCaucStop.Hide()
        btnMCCaucStart.Show()
        btnMCCaucStart.Select()
    End Sub

    Private Sub btnMCCaucReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCCaucReset.Click
        minutesCauc = nudMCTimerCauc.Value
        secondsCauc = 0
        WriteTimerCauc()
    End Sub

    Private Sub nudMCTimerCauc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMCTimerCauc.ValueChanged
        freshResetCauc = True
    End Sub

    Private Sub ModCaucus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnMCSpkrStop.Hide()
        btnMCCaucStop.Hide()
        rtbModCaucus.Font = Munchkin.modCaucFont
        dbMCTimeType.SelectedIndex = 0
    End Sub

    'Speaker timer code
    Private Sub TimerSpkr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSpkr.Tick
        UpdateTimerSpkr()
        WriteTimerSpkr()
    End Sub

    Private Sub UpdateTimerSpkr()
        If secondsSpkr > 0 Then
            secondsSpkr -= 1
        ElseIf secondsSpkr = 0 And minutesSpkr > 0 Then
            secondsSpkr = 59
            If minutesSpkr > 0 Then
                minutesSpkr -= 1
            End If
        End If
    End Sub

    Private Sub WriteTimerSpkr()
        If minutesSpkr < 100 Then
            tbMCSpkrTime.Text = minutesSpkr.ToString + ":"
            If secondsSpkr < 10 Then
                tbMCSpkrTime.AppendText("0")
            End If
            tbMCSpkrTime.AppendText(secondsSpkr.ToString)
        Else
            tbMCSpkrTime.Text = minutesSpkr.ToString + "m"
        End If
    End Sub

    Private Sub btnMCSpkrStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCSpkrStart.Click
        If freshResetSpkr = True Then
            btnMCSpkrReset_Click(Me, e)
            freshResetSpkr = False
        End If

        TimerSpkr.Start()
        btnMCSpkrStop.Show()
        btnMCSpkrStop.Select()
        btnMCSpkrStart.Hide()
    End Sub

    Private Sub btnMCSpkrStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCSpkrStop.Click
        TimerSpkr.Stop()
        btnMCSpkrStop.Hide()
        btnMCSpkrStart.Show()
        btnMCSpkrStart.Select()
    End Sub

    Private Sub btnMCSpkrReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCSpkrReset.Click
        If dbMCTimeType.SelectedIndex = 0 Then 'minutes
            minutesSpkr = nudMCTimerSpkr.Value
            secondsSpkr = 0
        Else 'seconds
            minutesSpkr = Math.Floor(nudMCTimerSpkr.Value / 60)
            secondsSpkr = nudMCTimerSpkr.Value - minutesSpkr * 60
        End If
        WriteTimerSpkr()
    End Sub

    Private Sub nudMCTimerSpkr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMCTimerSpkr.ValueChanged
        freshResetSpkr = True
    End Sub

    Private Sub ModCaucus_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        Me.Select()
    End Sub

    Private Sub nudMCTimerCauc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMCTimerCauc.Click
        nudMCTimerCauc.Select(0, 3)
    End Sub

    Private Sub nudMCTimerSpkr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMCTimerSpkr.Click
        nudMCTimerSpkr.Select(0, 3)
    End Sub


    Private Sub tsbModClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModClear.Click
        rtbModCaucus.Clear()
    End Sub

    Private Sub tsbModTextSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModTextSize.Click
        Dim modcaucFont As New FontDialog
        modcaucFont.ShowColor = False
        modcaucFont.Font = rtbModCaucus.Font

        If modcaucFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtbModCaucus.Font = modcaucFont.Font
        End If
    End Sub

    Private Sub ModCaucus_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Munchkin.modCaucFont = rtbModCaucus.Font
    End Sub
End Class