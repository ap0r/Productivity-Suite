Public Class Form1
    'declarations & value initialization
    Dim SecondsElapsed As Integer = 0
    Dim SecondsToNextAction As Integer = 360 '6 minutes default
    'flags
    Dim muted As Boolean = False
    'create list of sound files
    Dim SoundFilePaths() As String = IO.Directory.GetFiles(Application.StartupPath + "\resources\sounds")

    'load tasks
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load tasks
        TodoRichTextBox.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\user data\ToDo.txt")
        InProgressRichTextBox.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\user data\InProgress.txt")
        DoneRichTextBox.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\user data\Done.txt")
        DailiesRichTextBox.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\user data\Dailies.txt")
    End Sub

    Private Sub ActionTimer_Tick(sender As Object, e As EventArgs) Handles ActionTimer.Tick
        'update values
        SecondsElapsed = SecondsElapsed + 1

        'update labels
        'IntervalLabel.Text = "Interval: " & Str(SecondsToNextAction / 60) & " minutes"

        SecondsToNextActionLabel.Text = "Seconds to next action: " & Str(SecondsToNextAction - SecondsElapsed)

        'alert logic
        If SecondsElapsed >= SecondsToNextAction And muted = False Then
            'reset seconds elapsed
            SecondsElapsed = 0
            Alert()



        End If

    End Sub
    Private Sub Alert()
        Dim alertpath As String
        'random alert, choose a random sound
        alertpath = SoundFilePaths(CInt(Math.Floor(Rnd() * SoundFilePaths.Count)))

        'play chosen sound
        My.Computer.Audio.Play(alertpath, AudioPlayMode.Background)

    End Sub

    'Update Action Timer values via the trackbar.
    Private Sub IntervalTrackBar_Scroll(sender As Object, e As EventArgs) Handles IntervalTrackBar.Scroll
        SecondsToNextAction = IntervalTrackBar.Value * 60
        IntervalLabel.Text = "Interval: " & IntervalTrackBar.Value.ToString & " minutes"
        ActionsPerHourLabel.Text = "Actions per hour: " & Math.Round((3600 / SecondsToNextAction), 2)

    End Sub


    'Make lists persistent. Save on change.
    Private Sub TodoRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles TodoRichTextBox.TextChanged
        My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\user data\ToDo.txt"), TodoRichTextBox.Text, False)
    End Sub

    Private Sub InProgressRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles InProgressRichTextBox.TextChanged
        My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\user data\InProgress.txt"), InProgressRichTextBox.Text, False)
    End Sub

    Private Sub DoneRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles DoneRichTextBox.TextChanged
        My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\user data\Done.txt"), DoneRichTextBox.Text, False)
    End Sub

    Private Sub DailiesRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles DailiesRichTextBox.TextChanged
        My.Computer.FileSystem.WriteAllText((Application.StartupPath & "\user data\Dailies.txt"), DailiesRichTextBox.Text, False)
    End Sub

    'This code handles moving stuff in between ToDo, InProgress, and Done lists

    'ToDo->InProgress
    Private Sub TodoRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TodoRichTextBox.MouseDoubleClick

        'get line
        Dim LineNumber As Integer
        Dim Line As String
        LineNumber = TodoRichTextBox.GetLineFromCharIndex(TodoRichTextBox.SelectionStart)

        'This if/end if is to prevent overflow bug if the user double clicks outside the text area
        If LineNumber <= TodoRichTextBox.Lines.Count Then
            Line = TodoRichTextBox.Lines(LineNumber)

            'move line
            TodoRichTextBox.SelectionStart = TodoRichTextBox.GetFirstCharIndexFromLine(LineNumber)
            TodoRichTextBox.SelectionLength = TodoRichTextBox.Lines(LineNumber).Length + 1
            TodoRichTextBox.SelectedText = ""

            InProgressRichTextBox.Text = Line & vbNewLine & InProgressRichTextBox.Text

        End If
    End Sub
    'InProgress->Done
    Private Sub InProgressRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles InProgressRichTextBox.MouseDoubleClick
        'get line
        Dim LineNumber As Integer
        Dim Line As String
        LineNumber = InProgressRichTextBox.GetLineFromCharIndex(InProgressRichTextBox.SelectionStart)
        Line = InProgressRichTextBox.Lines(LineNumber)

        'move line
        InProgressRichTextBox.SelectionStart = InProgressRichTextBox.GetFirstCharIndexFromLine(LineNumber)
        InProgressRichTextBox.SelectionLength = InProgressRichTextBox.Lines(LineNumber).Length + 1
        InProgressRichTextBox.SelectedText = ""

        DoneRichTextBox.Text = Line & vbNewLine & DoneRichTextBox.Text
    End Sub


    'mute button and mute flag logic
    Private Sub MuteButton_Click(sender As Object, e As EventArgs) Handles MuteButton.Click
        'invert the muted flag
        muted = Not muted
        If muted = True Then
            MuteButton.Text = "Unmute"
        Else
            MuteButton.Text = "Mute"
        End If
    End Sub

    Private Sub AudioTestButton_Click(sender As Object, e As EventArgs) Handles AudioTestButton.Click
        Alert()
    End Sub
End Class
