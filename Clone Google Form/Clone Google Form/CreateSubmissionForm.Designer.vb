<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Label1 = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblNumber = New Label()
        lblLink = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtNumber = New TextBox()
        txtLink = New TextBox()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(906, 50)
        Label1.TabIndex = 0
        Label1.Text = "Vinay Soni, Slidely Task 2 - Create New Submission"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(200, 174)
        lblName.Name = "lblName"
        lblName.Size = New Size(91, 38)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(200, 252)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(83, 38)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumber.Location = New Point(200, 335)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(206, 38)
        lblNumber.TabIndex = 3
        lblNumber.Text = "Phone Number"
        ' 
        ' lblLink
        ' 
        lblLink.AutoSize = True
        lblLink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLink.Location = New Point(200, 403)
        lblLink.Name = "lblLink"
        lblLink.Size = New Size(162, 76)
        lblLink.TabIndex = 4
        lblLink.Text = "GitHub Link" & vbCrLf & "For task 2" & vbCrLf
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnToggleStopwatch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToggleStopwatch.Location = New Point(200, 540)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(443, 59)
        btnToggleStopwatch.TabIndex = 5
        btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.GradientActiveCaption
        btnSubmit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(120, 649)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(935, 95)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(430, 171)
        txtName.Name = "txtName"
        txtName.Size = New Size(605, 45)
        txtName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(430, 249)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(605, 45)
        txtEmail.TabIndex = 8
        ' 
        ' txtNumber
        ' 
        txtNumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNumber.Location = New Point(430, 332)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(605, 45)
        txtNumber.TabIndex = 9
        ' 
        ' txtLink
        ' 
        txtLink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLink.Location = New Point(430, 403)
        txtLink.Multiline = True
        txtLink.Name = "txtLink"
        txtLink.Size = New Size(605, 61)
        txtLink.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(698, 547)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(303, 45)
        TextBox1.TabIndex = 11
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1181, 820)
        Controls.Add(TextBox1)
        Controls.Add(txtLink)
        Controls.Add(txtNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblLink)
        Controls.Add(lblNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblLink As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtLink As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
