Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

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

    Private Async Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Dim name As String = TextBoxName.Text
        Dim email As String = TextBoxEmail.Text
        Dim phone As String = TextBoxPhoneNum.Text
        Dim githubLink As String = TextBoxGithub.Text
        Dim stopwatchTimeStr As String = stopwatchTime.ToString("hh\:mm\:ss")

        Dim submission As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", githubLink},
            {"stopwatch_time", stopwatchTimeStr}
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                Else
                    MessageBox.Show("Submission failed.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
