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


        If String.IsNullOrEmpty(fname) OrElse String.IsNullOrEmpty(lname) OrElse
           String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If password <> confirmPin Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


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

    Private Sub PictureUser_Click(sender As Object, e As EventArgs) Handles PictureUser.Click
    End Sub

    Private Sub Register_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create an OpenFileDialog to browse for images
        Using ofd As New OpenFileDialog()
            ' Set the title and filters so users only see image files
            ofd.Title = "Select Profile Image"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

            ' Check if the user clicked "OK" instead of "Cancel"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Load the selected image into the PictureBox
                    btnUpload.Image = Image.FromFile(ofd.FileName)

                    ' Set SizeMode to Zoom so the image fits nicely without stretching
                    PictureUser.SizeMode = PictureBoxSizeMode.Zoom

                    ' Optional: Store the file path in a variable if you need to save it to a database later
                    ' Dim selectedPath As String = ofd.FileName
                Catch ex As Exception
                    MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
End Class
