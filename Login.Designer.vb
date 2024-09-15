<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        LoginBtn = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(206, 79)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.PlaceholderText = "USERNAME"
        UsernameTextBox.Size = New Size(179, 23)
        UsernameTextBox.TabIndex = 0
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(206, 122)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PlaceholderText = "PASSWORD"
        PasswordTextBox.Size = New Size(179, 23)
        PasswordTextBox.TabIndex = 1
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Location = New Point(206, 170)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(179, 23)
        LoginBtn.TabIndex = 2
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(251, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 3
        Label1.Text = "Book Library"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 309)
        Controls.Add(Label1)
        Controls.Add(LoginBtn)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Label1 As Label
End Class
