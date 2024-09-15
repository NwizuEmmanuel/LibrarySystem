Public Class Login
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim controller As New LoginController(UsernameTextBox.Text, PasswordTextBox.Text)
        If controller.Login() Then
            Me.Hide()
            Library.Show()
        Else
            MessageBox.Show("USER NOT FOUND")
        End If
    End Sub
End Class