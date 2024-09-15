<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewStudent
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
        GroupBox1 = New GroupBox()
        AddNewStudentBtn = New Button()
        Panel3 = New Panel()
        CourseTextBox = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        LastnameTextBox = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        FirstnameTextBox = New TextBox()
        Label3 = New Label()
        MaleRadioBtn = New RadioButton()
        GroupBox2 = New GroupBox()
        FemaleRadioBtn = New RadioButton()
        OtherRadioBtn = New RadioButton()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(AddNewStudentBtn)
        GroupBox1.Controls.Add(Panel3)
        GroupBox1.Controls.Add(Panel2)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(411, 259)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "New Student"
        ' 
        ' AddNewStudentBtn
        ' 
        AddNewStudentBtn.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        AddNewStudentBtn.Location = New Point(285, 230)
        AddNewStudentBtn.Name = "AddNewStudentBtn"
        AddNewStudentBtn.Size = New Size(120, 23)
        AddNewStudentBtn.TabIndex = 7
        AddNewStudentBtn.Text = "Add Student"
        AddNewStudentBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(CourseTextBox)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(6, 118)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(396, 42)
        Panel3.TabIndex = 6
        ' 
        ' CourseTextBox
        ' 
        CourseTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CourseTextBox.Location = New Point(3, 16)
        CourseTextBox.Name = "CourseTextBox"
        CourseTextBox.Size = New Size(390, 23)
        CourseTextBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 0
        Label2.Text = "Course"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(LastnameTextBox)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(9, 70)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(393, 42)
        Panel2.TabIndex = 5
        ' 
        ' LastnameTextBox
        ' 
        LastnameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LastnameTextBox.Location = New Point(3, 16)
        LastnameTextBox.Name = "LastnameTextBox"
        LastnameTextBox.Size = New Size(387, 23)
        LastnameTextBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 0
        Label1.Text = "Lastname"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(FirstnameTextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(6, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(396, 42)
        Panel1.TabIndex = 4
        ' 
        ' FirstnameTextBox
        ' 
        FirstnameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FirstnameTextBox.Location = New Point(3, 16)
        FirstnameTextBox.Name = "FirstnameTextBox"
        FirstnameTextBox.Size = New Size(390, 23)
        FirstnameTextBox.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 0
        Label3.Text = "Firstname"
        ' 
        ' MaleRadioBtn
        ' 
        MaleRadioBtn.AutoSize = True
        MaleRadioBtn.Location = New Point(6, 22)
        MaleRadioBtn.Name = "MaleRadioBtn"
        MaleRadioBtn.Size = New Size(51, 19)
        MaleRadioBtn.TabIndex = 8
        MaleRadioBtn.TabStop = True
        MaleRadioBtn.Text = "Male"
        MaleRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(OtherRadioBtn)
        GroupBox2.Controls.Add(FemaleRadioBtn)
        GroupBox2.Controls.Add(MaleRadioBtn)
        GroupBox2.Location = New Point(6, 166)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(243, 55)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Sex"
        ' 
        ' FemaleRadioBtn
        ' 
        FemaleRadioBtn.AutoSize = True
        FemaleRadioBtn.Location = New Point(63, 22)
        FemaleRadioBtn.Name = "FemaleRadioBtn"
        FemaleRadioBtn.Size = New Size(63, 19)
        FemaleRadioBtn.TabIndex = 9
        FemaleRadioBtn.TabStop = True
        FemaleRadioBtn.Text = "Female"
        FemaleRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' OtherRadioBtn
        ' 
        OtherRadioBtn.AutoSize = True
        OtherRadioBtn.Location = New Point(132, 22)
        OtherRadioBtn.Name = "OtherRadioBtn"
        OtherRadioBtn.Size = New Size(55, 19)
        OtherRadioBtn.TabIndex = 10
        OtherRadioBtn.TabStop = True
        OtherRadioBtn.Text = "Other"
        OtherRadioBtn.UseVisualStyleBackColor = True
        ' 
        ' NewStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "NewStudent"
        Text = "NewStudent"
        GroupBox1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LastnameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddNewStudentBtn As Button
    Friend WithEvents MaleRadioBtn As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OtherRadioBtn As RadioButton
    Friend WithEvents FemaleRadioBtn As RadioButton
End Class
