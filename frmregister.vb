Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class Register_Form
    ' Database helper pointing to your local SQLite file
    Private ReadOnly db As New DatabaseHelper("login.db")

    Public Sub New()
        InitializeComponent()
    End Sub

    ' --- HELPER: CONVERT IMAGE TO BYTES ---
    Private Function ImageToByteArray(img As Image) As Byte()
        If img Is Nothing Then Return Nothing
        Using ms As New System.IO.MemoryStream()
            ' Save as Png to handle transparency and quality
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    ' --- EVENT: UPLOAD IMAGE ---
    ' Renamed to BtnUpload (Capital B) to satisfy naming rules
    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Profile Image"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    PictureUser.Image = Image.FromFile(ofd.FileName)
                    PictureUser.SizeMode = PictureBoxSizeMode.Zoom
                Catch ex As Exception
                    MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub Register_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default settings
        txtboxPassword.UseSystemPasswordChar = True
        txtboxConfirmPIN.UseSystemPasswordChar = True
    End Sub

    ' --- EVENT: REGISTER BUTTON ---
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fname As String = txtFName.Text.Trim()
        Dim mname As String = txtMName.Text.Trim()
        Dim lname As String = txtLName.Text.Trim()
        Dim gender As String = If(RadioButtonMale.Checked, "Male", If(RadioButtonFemale.Checked, "Female", ""))
        Dim username As String = txtboxUsername.Text.Trim()
        Dim password As String = txtboxPassword.Text.Trim()
        Dim confirmPin As String = txtboxConfirmPIN.Text.Trim()
        Dim birthdate As Date = DateTimePicker1.Value

        ' 1. Validation
        If String.IsNullOrEmpty(fname) OrElse String.IsNullOrEmpty(lname) OrElse
           String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If password <> confirmPin Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 2. Convert image to byte array for the database
        Dim imgBytes As Byte() = ImageToByteArray(PictureUser.Image)

        ' 3. Call database with ALL 8 arguments (Fixes "Argument not specified" error)
        If db.RegisterUser(fname, mname, lname, gender, birthdate, username, password, imgBytes) Then
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Registration failed. Username may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' --- OTHER EVENTS ---
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass.CheckedChanged
        txtboxPassword.UseSystemPasswordChar = Not CheckBoxShowPass.Checked
        txtboxConfirmPIN.UseSystemPasswordChar = Not CheckBoxShowPass.Checked
    End Sub
End Class
