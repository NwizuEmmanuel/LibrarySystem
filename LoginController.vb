Imports System.Data.SqlClient

Public Class LoginController
    Private _username As String
    Private _password As String

    Public Sub New(ByVal username As String, ByVal password As String)
        _username = username
        _password = password
    End Sub

    Public Property Username()
        Set(value)
            _username = value
        End Set
        Get
            Return _username
        End Get
    End Property

    Public Property Password()
        Set(value)
            _password = value
        End Set
        Get
            Return _password
        End Get
    End Property

    Public Function Login()
        Using connection As New SqlConnection(DBConnection.ConnectionString)
            Dim query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password"
            connection.Open()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", Username)
                command.Parameters.AddWithValue("@password", Password)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        DBConnection.Role = reader.GetString("Role")
                    End While
                    Return reader.HasRows()
                End Using
            End Using
        End Using
    End Function
End Class
