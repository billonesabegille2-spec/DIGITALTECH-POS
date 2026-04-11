Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login
    ' Use the helper class you created
    Dim db As New DatabaseHelper("Login db")

    ' Toggle Password Visibility
    Private Sub ChkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Ensure your password textbox is named txtPassword
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' The main Login Logic
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUsername.Text
        Dim pass As String = txtPassword.Text

        ' Basic validation to ensure fields aren't empty
        If String.IsNullOrWhiteSpace(user) OrElse String.IsNullOrWhiteSpace(pass) Then
            MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate against SQLite database using your DatabaseHelper function
        If db.ValidateLogin(user, pass) Then
            ' Set the Global variable so other forms know who is logged in
            GlobalData.CurrentUser = user

            ' Check if the user is the Admin
            If user.ToLower() = "" Then
                MessageBox.Show("Welcome back, Admin!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Open the Admin Menu (Ensure the form name matches your project)
                Admin_Menu.Show()
            Else
                ' If not admin, open the POS form
                frmpos.Show()
            End If

            ' Hide the current login window
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Open Registration Form
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Opens the Register form as a pop-up
        Register_Form.ShowDialog()
    End Sub

End Class