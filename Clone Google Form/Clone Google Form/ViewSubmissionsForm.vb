Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As New List(Of Submission)()
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissionsAsync()
    End Sub

    Private Async Function LoadSubmissionsAsync() As Task
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/readAll")
                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                    If submissions.Count > 0 Then
                        ShowSubmission(currentIndex)
                        btnNext.Enabled = True
                        btnPrevious.Enabled = True
                    Else
                        MessageBox.Show("No submissions available.")
                        btnNext.Enabled = False
                        btnPrevious.Enabled = False
                    End If
                Else
                    MessageBox.Show("Failed to load submissions.")
                    btnNext.Enabled = False
                    btnPrevious.Enabled = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            btnNext.Enabled = False
            btnPrevious.Enabled = False
        End Try
    End Function

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub ShowSubmission(index As Integer)
        Dim submission As Submission = submissions(index)
        txtName.Text = submission.Name
        txtName.ReadOnly = True
        txtEmail.Text = submission.Email
        txtEmail.ReadOnly = True
        txtNumber.Text = submission.PhoneNumber
        txtNumber.ReadOnly = True
        txtLink.Text = submission.GitHubLink
        txtLink.ReadOnly = True
    End Sub
End Class
