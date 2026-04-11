Partial Public Class Register_Form
    Private ReadOnly db As New DatabaseHelper("login.db")

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fname As String = txtFName.Text.Trim()
        Dim mname As String = txtMName.Text.Trim()
        Dim lname As String = txtLName.Text.Trim()
        Dim gender As String = If(RadioButtonMale.Checked, "Male", If(RadioButtonFemale.Checked, "Female", ""))
        Dim username As String = txtboxUsername.Text.Trim()
        Dim password As String = txtboxPassword.Text.Trim()
        Dim confirmPin As String = txtboxConfirmPIN.Text.Trim()
        Dim birthdate As Date = DateTimePicker1.Value

        ' Validation
        If String.IsNullOrEmpty(fname) OrElse String.IsNullOrEmpty(lname) OrElse
           String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If password <> confirmPin Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Save to database
        If db.RegisterUser(fname, mname, lname, gender, birthdate, username, password) Then
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Registration failed. Username may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass.CheckedChanged
        txtboxPassword.UseSystemPasswordChar = Not CheckBoxShowPass.Checked
        txtboxConfirmPIN.UseSystemPasswordChar = Not CheckBoxShowPass.Checked

    End Sub
End Class
