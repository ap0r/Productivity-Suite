Public Class Form1
    'declarations & value initialization
    Dim SecondsElapsed As Integer = 0
    Dim SecondsToNextAction As Integer = 360 '6 minutes default

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TodoRichTextBox.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\user data\ToDo.txt")
        InProgressRichTextBox.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\user data\InProgress.txt")
        DoneRichTextBox.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\user data\Done.txt")
    End Sub

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


    'save on changes
    Private Sub TodoRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles TodoRichTextBox.TextChanged
        My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\user data\ToDo.txt"), TodoRichTextBox.Text, False)
    End Sub

    Private Sub InProgressRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles InProgressRichTextBox.TextChanged
        My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\user data\InProgress.txt"), InProgressRichTextBox.Text, False)
    End Sub

    Private Sub DoneRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles DoneRichTextBox.TextChanged
        My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\user data\Done.txt"), DoneRichTextBox.Text, False)
    End Sub
End Class
