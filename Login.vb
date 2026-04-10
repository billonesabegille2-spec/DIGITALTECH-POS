

Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

End Sub

Friend WithEvents Label4 As Label

Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


    If txtUsername.Text = "" Or txtPassword.Text = "" Then
        MessageBox.Show("Please enter username and password", "Warning")
        Exit Sub
    End If

    If txtUsername.Text = "admin" And txtPassword.Text = "1234" Then

        MessageBox.Show("Login Successful!", "Success")


        Dim nextForm As New frmpos
        nextForm.Show()

        Me.Hide()

    Else
        MessageBox.Show("Invalid Username or Password", "Error")
    End If

End Sub

Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
    Dim registerForm As New Register_Form
    registerForm.Show()
    Me.Hide()
End Sub

Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
    If chkShowPassword.Checked Then
        txtPassword.UseSystemPasswordChar = False
    Else
        txtPassword.UseSystemPasswordChar = True
    End If
End Sub

Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

End Sub
End Class