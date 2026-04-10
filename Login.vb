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

    ' Handle Login Logic
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If db.ValidateLogin(txtUsername.Text, txtPassword.Text) Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Open the POS Form
                Dim mainForm As New frmpos()
                mainForm.Show()

                ' Hide the login form
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
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