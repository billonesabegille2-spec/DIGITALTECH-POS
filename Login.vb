Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login

    Private db As New DatabaseHelper("login.db")


    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If


        If db.ValidateLogin(username, password) Then

            GlobalData.CurrentUser = username


            If username.ToLower() = "admin" Then

                Dim adminForm As New Admin_Menu()
                adminForm.Show()
            Else
                Dim posForm As New frmpos()
                posForm.Show()
            End If


            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim reg As New Admin_Menu()
        reg.ShowDialog()
    End Sub

End Class