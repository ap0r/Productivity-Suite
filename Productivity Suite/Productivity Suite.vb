Public Class Form1
    'declarations & value initialization
    Dim SecondsElapsed As Integer = 0
    Dim SecondsToNextAction As Integer = 360 '6 minutes default
    Private Sub ActionTimer_Tick(sender As Object, e As EventArgs) Handles ActionTimer.Tick
        'update values
        SecondsElapsed = SecondsElapsed + 1

        'update labels
        'IntervalLabel.Text = "Interval: " & Str(SecondsToNextAction / 60) & " minutes"

        SecondsToNextActionLabel.Text = "Seconds to next action: " & Str(SecondsToNextAction - SecondsElapsed)

        'alert logic
        If SecondsElapsed >= SecondsToNextAction Then
            'reset seconds elapsed
            SecondsElapsed = 0
            'alert
            alert()

        End If

    End Sub
    Private Sub alert()
        Beep()
    End Sub

    Private Sub IntervalTrackBar_Scroll(sender As Object, e As EventArgs) Handles IntervalTrackBar.Scroll
        SecondsToNextAction = IntervalTrackBar.Value * 60
        IntervalLabel.Text = "Interval: " & IntervalTrackBar.Value.ToString & " minutes"
        ActionsPerHourLabel.Text = "Actions per hour: " & Math.Round((3600 / SecondsToNextAction), 2)

    End Sub
End Class
