Imports System.IO

Public Class view_profile
    ' Database helper instance
    Private ReadOnly db As New DatabaseHelper("login.db")

    ' Load user data when the form opens
    Private Sub View_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserProfile()
    End Sub

    Private Sub LoadUserProfile()
        ' GlobalData.CurrentUser must be set during Login
        Dim dt As DataTable = db.GetUserDetails(GlobalData.CurrentUser)

        If dt.Rows.Count > 0 Then
            Dim row = dt.Rows(0)

            ' Display Data
            lblGender.Text = "Gender: " & row("Gender").ToString()

            Dim bday As Date
            If Date.TryParse(row("Birthdate").ToString(), bday) Then
                lblBirthday.Text = "Birthday: " & bday.ToString("MMMM dd, yyyy")

                ' Calculate Age
                Dim age As Integer = DateTime.Now.Year - bday.Year
                If DateTime.Now < bday.AddYears(age) Then age -= 1
                lblAge.Text = "Age: " & age.ToString()
            End If

            ' Load Profile Picture BLOB
            If Not IsDBNull(row("ProfilePic")) Then
                Dim imgData As Byte() = DirectCast(row("ProfilePic"), Byte())
                Using ms As New MemoryStream(imgData)
                    ' Using BackgroundImage as defined in your designer
                    PictureBox1.BackgroundImage = Image.FromStream(ms)
                    PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
                End Using
            End If
        End If
    End Sub

    ' --- Event Handlers ---

    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub LblGoBack_Click(sender As Object, e As EventArgs) Handles lblGoBack.Click
        Me.Close()
    End Sub

    ' Placeholder for Edit Profile logic
    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        ' Logic to open Edit_Profile form would go here
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
