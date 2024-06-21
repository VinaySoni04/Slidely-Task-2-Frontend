Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit_Click(Nothing, Nothing)
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SubmitFormAsync()
    End Sub

    Private Async Sub SubmitFormAsync()
        Try
            Dim submission As New Submission()
            submission.Name = txtName.Text
            submission.Email = txtEmail.Text
            submission.PhoneNumber = txtNumber.Text
            submission.GitHubLink = txtLink.Text

            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                    ResetForm()
                Else
                    MessageBox.Show("Failed to submit the form.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetForm()
        txtName.Clear()
        txtEmail.Clear()
        txtNumber.Clear()
        txtLink.Clear()
        stopwatch.Reset()
    End Sub

End Class
