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

            ' Existing Users Table logic...
            Dim userSql As String = "
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT, MiddleName TEXT, LastName TEXT,
                    Gender TEXT, Birthdate TEXT, Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL, ProfilePic BLOB, Role TEXT NOT NULL
                );"

            ' NEW: Items Table for POS Products
            Dim itemSql As String = "
                CREATE TABLE IF NOT EXISTS Items (
                    ItemID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ItemName TEXT NOT NULL,
                    ItemPrice DECIMAL NOT NULL,
                    ItemStock INTEGER NOT NULL,
                    ItemImage BLOB
                );"

            Using cmd As New SQLiteCommand(userSql & itemSql, conn)
                cmd.ExecuteNonQuery()
            End Using

            ' (Keep your existing Admin Seeding logic here...)
        End Using
    End Sub

    ' --- NEW PRODUCT METHODS ---

    ' Save item to database
    Public Sub AddProduct(name As String, price As Decimal, stock As Integer, img As Byte())
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO Items (ItemName, ItemPrice, ItemStock, ItemImage) VALUES (@n, @p, @s, @i)"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@n", name)
                cmd.Parameters.AddWithValue("@p", price)
                cmd.Parameters.AddWithValue("@s", stock)
                cmd.Parameters.AddWithValue("@i", If(img, DirectCast(DBNull.Value, Object)))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Get all products for the DataGridView or POS
    Public Function GetAllProducts() As DataTable
        Dim dt As New DataTable()
        Using conn As New SQLiteConnection(connectionString)
            Dim sql As String = "SELECT * FROM Items"
            Using adapter As New SQLiteDataAdapter(sql, conn)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ' Delete product
    Public Sub DeleteProduct(id As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim sql As String = "DELETE FROM Items WHERE ItemID = @id"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    ' Add these inside your DatabaseHelper class if they are missing
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
    ' This method saves a new user to the database
    Public Function RegisterUser(fname As String, mname As String, lname As String,
                                 gender As String, birthdate As Date,
                                 username As String, password As String,
                                 userImage As Byte()) As Boolean
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                ' We set the Role to 'Staff' by default for new registrations
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
                    ' Handle null image
                    cmd.Parameters.AddWithValue("@img", If(userImage IsNot Nothing, DirectCast(userImage, Object), DBNull.Value))

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As SQLiteException When ex.ErrorCode = 19 ' 19 is the code for Unique Constraint (Username exists)
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class