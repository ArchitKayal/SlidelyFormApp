Public Class CreateSubmissionForm

    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero
    Private Sub ButtonStopwatch_Click(sender As Object, e As EventArgs) Handles ButtonStopwatch.Click
        If stopwatchRunning Then
            Timer1.Stop()
            stopwatchRunning = False
        Else
            Timer1.Start()
            stopwatchRunning = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
        TextBoxStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub
End Class