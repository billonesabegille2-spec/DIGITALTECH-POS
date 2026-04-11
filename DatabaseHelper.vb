Imports System.Data.SQLite
Imports System.IO

Public Class DatabaseHelper
    Private ReadOnly connectionString As String

    Public Sub New(dbPath As String)

        Dim fullPath As String = Path.Combine(Application.StartupPath, dbPath)
        connectionString = $"Data Source={fullPath};Version=3;"
        EnsureDatabaseExists(fullPath)
    End Sub

    Private Sub EnsureDatabaseExists(fullPath As String)

        If Not File.Exists(fullPath) Then
            SQLiteConnection.CreateFile(fullPath)
        End If


        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim tableSql As String = "
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT,
                        MiddleName TEXT,
                        LastName TEXT,
                        Gender TEXT,
                        Birthdate TEXT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL
                    );"
            Using cmd As New SQLiteCommand(tableSql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function RegisterUser(fname As String, mname As String, lname As String,
                                     gender As String, birthdate As Date,
                                     username As String, password As String) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim sql As String = "INSERT INTO Users (FirstName, MiddleName, LastName, Gender, Birthdate, Username, Password) " &
                                        "VALUES (@f, @m, @l, @g, @b, @u, @p)"

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
        Catch ex As SQLiteException When ex.ErrorCode = 19
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidateLogin(username As String, password As String) As Boolean
        Try
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
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class