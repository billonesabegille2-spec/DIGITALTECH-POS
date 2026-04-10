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
        ' Replace "admin" with your actual database/logic check
        If txtUsername.Text <> "" AndAlso txtPassword.Text <> "" Then

            ' STEP 1: Save the username to the Global Variable
            GlobalData.CurrentUser = txtUsername.Text

            ' STEP 2: Open the POS form
            frmpos.Show()

            ' STEP 3: Hide the login form
            Me.Hide()
        Else
            MessageBox.Show("Please enter valid credentials.")
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