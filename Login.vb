Imports System.Windows.Forms

Partial Public Class Login
    ' Initialize the database helper pointing to your local file
    Private db As New DatabaseHelper("login.db")

    Public Sub New()
        InitializeComponent()

    End Sub

    ' Toggle password visibility
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' 1. Check if fields are empty
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        ' 2. Validate against the database using your DatabaseHelper
        If db.ValidateLogin(username, password) Then

            ' Save username to global variable
            GlobalData.CurrentUser = username

            ' 3. Check if the user is the Admin
            If username.ToLower() = "admin" Then
                ' If it's the admin, go to Admin Menu
                Admin_Menu.Show()
                MessageBox.Show("Welcome, Admin!", "Login Successful")
            Else
                ' If it's a regular user, go to POS
                frmpos.Show()
            End If

            ' Hide the login form
            Me.Hide()
        Else
            ' Login failed
            MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Handle Navigation to Registration Form
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            ' Create and show the registration form
            Dim registerForm As New Register_Form()

            ' Use ShowDialog if you want to force the user to finish registration 
            ' before returning to login. Use .Show() if they can use both.
            registerForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Could not open registration form: " & ex.Message)
        End Try
    End Sub
End Class