Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class MainForm
    'Private Function LoadSubmissions() As List(Of Submission)
    ' This function should load the submissions from the backend or a file.
    ' For now, let's return a dummy list for demonstration purposes.
    'Return New List(Of Submission) From {
    '  New Submission("John Doe", "john@example.com", "123-456-7890", "https://github.com/johndoe", TimeSpan.FromMinutes(10)),
    '   New Submission("Jane Smith", "jane@example.com", "987-654-3210", "https://github.com/janesmith", TimeSpan.FromMinutes(20))
    '}
    'End Function

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        'Dim submissions As List(Of Submission) = LoadSubmissions()
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.ShowDialog()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.ShowDialog()
    End Sub
End Class
