Imports System
Imports System.Windows.Forms
Imports System.Drawing

Partial Public Class Login
    ' Initialize the database helper
    Private db As New DatabaseHelper("login.db")

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Basic Event Handlers (Can be left empty if not used)
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Logic to show/hide password
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If db.ValidateLogin(txtUsername.Text, txtPassword.Text) Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' ToDo: Add code to open your Main Form here
            Else
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' FIX: Your RegisterUser function requires 7 arguments. 
            ' We are passing placeholder values for fname, mname, lname, gender, and birthdate 
            ' to satisfy the function requirements.

            Dim registrationSuccess As Boolean = db.RegisterUser(
                "New",              ' fname
                "User",             ' mname
                "Name",             ' lname
                "Not Specified",    ' gender
                DateTime.Now,       ' birthdate
                txtUsername.Text,   ' username
                txtPassword.Text    ' password
            )

            If registrationSuccess Then
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Registration failed. Username may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Registration Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization logic when form opens
    End Sub
End Class