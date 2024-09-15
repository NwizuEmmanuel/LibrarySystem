Public Class DBConnection
    Private Shared ReadOnly _connectionString = "Server=DESKTOP-S91C1UO\SQLEXPRESS;Database=Library;Trusted_Connection=True;"

    Private Shared _role = ""

    Public Shared Property Role As String
        Set(value As String)
            _role = value
        End Set
        Get
            Return _role
        End Get
    End Property

    Public Shared ReadOnly Property ConnectionString
        Get
            Return _connectionString
        End Get
    End Property
End Class
