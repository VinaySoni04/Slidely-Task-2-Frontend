<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        lblTime = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtNumber = New TextBox()
        txtLink = New TextBox()
        txtTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(194, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(817, 50)
        Label1.TabIndex = 0
        Label1.Text = "Vinay Soni, Slidely Task 2 - View Submissions "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(183, 148)
        lblName.Name = "lblName"
        lblName.Size = New Size(91, 38)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(183, 220)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(83, 38)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumber.Location = New Point(183, 282)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(206, 38)
        lblNumber.TabIndex = 3
        lblNumber.Text = "Phone Number"
        ' 
        ' lblLink
        ' 
        lblLink.AutoSize = True
        lblLink.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLink.Location = New Point(183, 353)
        lblLink.Name = "lblLink"
        lblLink.Size = New Size(162, 114)
        lblLink.TabIndex = 4
        lblLink.Text = "GitHub Link" & vbCrLf & "For task 2" & vbCrLf & vbCrLf
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(183, 452)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(144, 76)
        lblTime.TabIndex = 5
        lblTime.Text = "Stopwatch" & vbCrLf & "Time" & vbCrLf
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(438, 148)
        txtName.Name = "txtName"
        txtName.Size = New Size(569, 45)
        txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(438, 220)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(569, 45)
        txtEmail.TabIndex = 7
        ' 
        ' txtNumber
        ' 
        txtNumber.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNumber.Location = New Point(438, 286)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(569, 45)
        txtNumber.TabIndex = 8
        ' 
        ' txtLink
        ' 
        txtLink.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLink.Location = New Point(438, 357)
        txtLink.Multiline = True
        txtLink.Name = "txtLink"
        txtLink.Size = New Size(569, 61)
        txtLink.TabIndex = 9
        ' 
        ' txtTime
        ' 
        txtTime.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTime.Location = New Point(438, 452)
        txtTime.Multiline = True
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(569, 61)
        txtTime.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnPrevious.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(112, 599)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(442, 81)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "Previous (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.GradientActiveCaption
        btnNext.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(624, 599)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(405, 81)
        btnNext.TabIndex = 12
        btnNext.Text = "Next ( CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1180, 742)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtTime)
        Controls.Add(txtLink)
        Controls.Add(txtNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblTime)
        Controls.Add(lblLink)
        Controls.Add(lblNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblLink As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtLink As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
