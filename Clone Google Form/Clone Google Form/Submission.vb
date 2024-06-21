Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As TimeSpan

    ' Constructor to initialize the properties
    Public Sub New(name As String, email As String, phoneNumber As String, gitHubLink As String, stopwatchTime As TimeSpan)
        Me.Name = name
        Me.Email = email
        Me.PhoneNumber = phoneNumber
        Me.GitHubLink = gitHubLink
        Me.StopwatchTime = stopwatchTime
    End Sub

    ' Default constructor
    Public Sub New()
    End Sub
End Class
