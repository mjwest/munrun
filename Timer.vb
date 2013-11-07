Public Class Timer
    Public minutes, seconds As Integer
    Public negative As Boolean = False
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UpdateTimer()
        WriteTimer()
    End Sub

    Private Sub UpdateTimer()
        If negative = False Then

            If minutes > 0 Then
                If seconds > 0 Then
                    seconds -= 1
                ElseIf seconds = 0 Then
                    seconds = 59
                    minutes -= 1
                End If
            ElseIf minutes = 0 Then
                If seconds > 0 Then
                    seconds -= 1
                ElseIf seconds = 0 Then
                    negative = True
                End If
            End If

        ElseIf negative = True Then

            If seconds < 59 Then
                seconds += 1
            ElseIf seconds = 59 Then
                seconds = 0
                minutes += 1
            End If

        End If
    End Sub

    Public Sub WriteTimer()
        'tbCaucTime.Hide()
        tbCaucTime.Clear()

        If negative = True Then
            If minutes < 10 Then
                tbCaucTime.AppendText("+")
            End If
            tbCaucTime.ForeColor = Color.OrangeRed
        Else
            tbCaucTime.ForeColor = Color.Black
        End If

        If minutes < 100 Then
            tbCaucTime.AppendText(minutes.ToString + ":")
            If seconds < 10 Then
                tbCaucTime.AppendText("0")
            End If
            tbCaucTime.AppendText(seconds.ToString)
        Else
            tbCaucTime.AppendText(minutes.ToString + "m")
        End If
        'tbCaucTime.Show()
    End Sub
    Private Sub Timer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        ' SwitchToSetMode()
        ' linkCancel.Hide() 'hide the first time
        SetTime(1, 0)
        SwitchToRunMode()
    End Sub



    Public Sub btnCaucTimeStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaucTimeStart.Click
        Timer1.Start()
        btnCTStop.Show()
        btnCTStop.Select()
        btnCaucTimeStart.Hide()
    End Sub

    Public Sub btnCTStop_Click() Handles btnCTStop.Click
        Timer1.Stop()
        btnCTStop.Hide()
        btnCaucTimeStart.Show()
        btnCaucTimeStart.Select()
    End Sub

    Public Sub btnCaucTimeReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaucTimeReset.Click
        btnCTStop_Click()
        minutes = nudMins.Value
        seconds = nudSecs.Value
        negative = False
        WriteTimer()
    End Sub

    Private Sub Timer_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        Me.Select()
    End Sub

    Public Sub AddTime(ByVal mins As Integer, ByVal secs As Integer)
        If negative = False Then
            seconds += secs
            minutes += mins
            If seconds > 59 Then
                minutes += Math.Floor(seconds / 60)
                seconds -= Math.Floor(seconds / 60) * 60
            End If
            UpdateNuds()
        End If
    End Sub

    Private Sub nudMins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMins.Click, nudMins.GotFocus
        nudMins.Select(0, 3)
    End Sub

    Private Sub nudSecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSecs.Click, nudSecs.GotFocus
        nudSecs.Select(0, 2)
    End Sub

    Private Sub ClickSet(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        SetTime(nudMins.Value, nudSecs.Value)
    End Sub

    Public Sub SetTime(ByVal mins As Integer, ByVal secs As Integer)
        btnCTStop_Click()
        minutes = mins
        seconds = secs
        negative = False
        UpdateNuds()
        WriteTimer()
        SwitchToRunMode()
    End Sub

    Private Sub UpdateNuds()
        'sync NUDs with values
        'only matters when the time is coming in from nextspkr or yield
        nudMins.Value = minutes
        nudSecs.Value = seconds
    End Sub

    Private Sub ClickOnTimer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCaucTime.Click
        SwitchToSetMode()
    End Sub

    Private Sub SwitchToRunMode()
        btnSet.Hide()
        tbCaucTime.Show()
        Me.Width = 200
        Me.Height = 150
        btnCaucTimeStart.Show()
        btnCaucTimeReset.Show()
        Label1.Hide()
        Label2.Hide()
        linkCancel.Hide()
    End Sub

    Private Sub SwitchToSetMode()
        btnCTStop.Hide()
        tbCaucTime.Hide()
        btnCaucTimeStart.Hide()
        btnCaucTimeReset.Hide()
        linkCancel.Show()
        Me.Width = 240
        Me.Height = 120
        nudMins.Select(0, 3)
        Label1.Show()
        Label2.Show()
        btnSet.Show()

    End Sub

    Private Sub linkCancel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCancel.LinkClicked
        SwitchToRunMode()
    End Sub
End Class