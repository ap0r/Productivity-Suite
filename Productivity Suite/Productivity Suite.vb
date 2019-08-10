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
            Beep()

        End If

    End Sub
End Class
