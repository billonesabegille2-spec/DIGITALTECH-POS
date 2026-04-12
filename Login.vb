Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login

    Private db As New DatabaseHelper("login.db")


    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        ' Use the new GetUserRole function to verify credentials and get the role
        Dim role As String = db.GetUserRole(username, password)

        If Not String.IsNullOrEmpty(role) Then
            ' Save the username globally
            GlobalData.CurrentUser = username

            ' Route based on the Role stored in the Database
            If role = "Admin" Then
                Dim adminForm As New admin_menu()
                adminForm.Show()
            Else
                ' This handles "Staff" or any other non-admin role
                Dim posForm As New frmpos()
                posForm.Show()
            End If

            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub



    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register_Form.Show()
    End Sub

End Class