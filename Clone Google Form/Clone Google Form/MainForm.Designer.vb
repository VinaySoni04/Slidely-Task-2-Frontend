<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnViewSubmissions.FlatAppearance.BorderSize = 5
        btnViewSubmissions.Location = New Point(249, 296)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(663, 120)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = SystemColors.GradientActiveCaption
        btnCreateNewSubmission.Location = New Point(249, 477)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(663, 119)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "Create New Submission (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(124, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(950, 88)
        Label1.TabIndex = 2
        Label1.Text = " Vinay Soni, Slidely Task 2 - Slidely Form App"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1185, 831)
        Controls.Add(Label1)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "MainForm"
        Text = "MainForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents Label1 As Label
End Class
