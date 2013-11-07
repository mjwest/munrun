Public Class NextSpeakerDisplay
    Private counter As Integer = 0

    Private Sub timerFade_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerFade.Tick
        If counter < 200 Then
            counter += 1
        Else
            Me.Opacity -= 0.05
            Me.Refresh()
            If Me.Opacity = 0 Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub NextSpeakerDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timerFade.Start()
        Me.Opacity = 0.99
        counter = 0
    End Sub
End Class