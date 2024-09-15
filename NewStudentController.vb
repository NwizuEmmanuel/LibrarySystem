Imports System.Data.SqlClient

Public Class NewStudentController
    Private ReadOnly _firstname As String
    Private ReadOnly _lastname As String
    Private ReadOnly _course As String

    Public Sub New(ByVal firstname As String, ByVal lastname As String, ByVal course As String)
        _firstname = firstname
        _lastname = lastname
        _course = course
    End Sub

    Public Function AddNewStudent() As Boolean
        Dim query = "INSERT INTO [dbo].[Students] (Firstname, Lastname, Course) VALUES (@firstname, @lastname, @course)"
        Using conn As New SqlConnection(DBConnection.ConnectionString)
            Try
                conn.Open()
                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@firstname", _firstname)
                    command.Parameters.AddWithValue("@lastname", _lastname)
                    command.Parameters.AddWithValue("@course", _course)
                    command.ExecuteNonQuery()
                End Using
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function
End Class
