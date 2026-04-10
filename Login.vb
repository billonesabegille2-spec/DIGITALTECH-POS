Partial Public Class Login
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged

    End Sub

    Private db As DatabaseHelper = New DatabaseHelper("login.db")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If db.ValidateLogin(txtUsername.Text, txtPassword.Text) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Navigate to main form here
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If db.RegisterUser(txtUsername.Text, txtPassword.Text) Then
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Registration failed. Username may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class