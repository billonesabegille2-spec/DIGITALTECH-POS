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
            ' 1. Added "Role" column to distinguish Admin from Staff
            Dim tableSql As String = "
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT,
                        MiddleName TEXT,
                        LastName TEXT,
                        Gender TEXT,
                        Birthdate TEXT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        ProfilePic BLOB,
                        Role TEXT NOT NULL
                    );"
            Using cmd As New SQLiteCommand(tableSql, conn)
                cmd.ExecuteNonQuery()
            End Using

            ' 2. Seed Default Admin Account if it doesn't exist
            Dim checkAdminSql As String = "SELECT COUNT(*) FROM Users WHERE Username = 'admin'"
            Using cmdCheck As New SQLiteCommand(checkAdminSql, conn)
                If Convert.ToInt32(cmdCheck.ExecuteScalar()) = 0 Then
                    Dim seedSql As String = "INSERT INTO Users (FirstName, LastName, Username, Password, Role) 
                                            VALUES ('System', 'Admin', 'admin', 'admin123', 'Admin')"
                    Using cmdSeed As New SQLiteCommand(seedSql, conn)
                        cmdSeed.ExecuteNonQuery()
                    End Using
                End If
            End Using
        End Using
    End Sub

    ' Updated to include Role (defaulting to Staff)
    Public Function RegisterUser(fname As String, mname As String, lname As String,
                                     gender As String, birthdate As Date,
                                     username As String, password As String,
                                     userImage As Byte()) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                ' 3. Modified SQL to include Role as 'Staff' automatically
                Dim sql As String = "INSERT INTO Users (FirstName, MiddleName, LastName, Gender, Birthdate, Username, Password, ProfilePic, Role) " &
                                        "VALUES (@f, @m, @l, @g, @b, @u, @p, @img, 'Staff')"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@f", fname)
                    cmd.Parameters.AddWithValue("@m", mname)
                    cmd.Parameters.AddWithValue("@l", lname)
                    cmd.Parameters.AddWithValue("@g", gender)
                    cmd.Parameters.AddWithValue("@b", birthdate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    cmd.Parameters.AddWithValue("@img", If(userImage, DirectCast(DBNull.Value, Object)))

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As SQLiteException When ex.ErrorCode = 19 ' Unique constraint (Username)
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ' Updated to return the Role so your app knows who logged in
    Public Function GetUserRole(username As String, password As String) As String
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Dim sql As String = "SELECT Role FROM Users WHERE Username=@u AND Password=@p"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    Dim result = cmd.ExecuteScalar()
                    Return If(result IsNot Nothing, result.ToString(), "")
                End Using
            End Using
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function GetUserDetails(username As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim sql As String = "SELECT FirstName, LastName, Gender, Birthdate, ProfilePic FROM Users WHERE Username = @u"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", username)
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function
End Class
