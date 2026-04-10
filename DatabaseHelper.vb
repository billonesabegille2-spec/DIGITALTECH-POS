Imports System.Data.SQLite

Public Class DatabaseHelper
    Private ReadOnly connectionString As String

    Public Sub New(dbPath As String)
        connectionString = $"Data Source={dbPath};Version=3;"
        EnsureDatabaseExists(dbPath)
    End Sub

    Private Sub EnsureDatabaseExists(dbPath As String)
        If Not IO.File.Exists(dbPath) Then
            SQLiteConnection.CreateFile(dbPath)
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim sql As String = "
                    CREATE TABLE Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        MiddleName TEXT,
                        LastName TEXT NOT NULL,
                        Gender TEXT,
                        Birthdate TEXT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL
                    )"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

    Public Function RegisterUser(fname As String, mname As String, lname As String,
                                 gender As String, birthdate As Date,
                                 username As String, password As String) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim sql As String = "
                    INSERT INTO Users (FirstName, MiddleName, LastName, Gender, Birthdate, Username, Password)
                    VALUES (@f, @m, @l, @g, @b, @u, @p)"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@f", fname)
                    cmd.Parameters.AddWithValue("@m", mname)
                    cmd.Parameters.AddWithValue("@l", lname)
                    cmd.Parameters.AddWithValue("@g", gender)
                    cmd.Parameters.AddWithValue("@b", birthdate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ValidateLogin(username As String, password As String) As Boolean
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim sql As String = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@p", password)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
End Class
