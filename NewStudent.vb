Public Class NewStudent
    Private Sub AddNewStudentBtn_Click(sender As Object, e As EventArgs) Handles AddNewStudentBtn.Click
        Dim controller As New NewStudentController(firstname:=FirstnameTextBox.Text,
lastname:=LastnameTextBox.Text, course:=CourseTextBox.Text)
        If controller.AddNewStudent() Then
            MessageBox.Show($"{FirstnameTextBox.Text} add to students.")
        Else
            MessageBox.Show("Student not added.")
        End If
    End Sub
End Class