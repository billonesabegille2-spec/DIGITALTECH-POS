Imports System.IO

Partial Public Class ChangePass
    ' Use the same database name as your Login form (login.db)
    Private db As New DatabaseHelper("login.db")

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mask passwords on start
        currentpass.PasswordChar = "●"c
        newpass.PasswordChar = "●"c
        confirmpass.PasswordChar = "●"c
    End Sub

    ' This is your SAVE/UPDATE logic (currently handled by btnReset)
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' 1. Retrieve the username saved during Login
        Dim loggedInUser As String = GlobalData.CurrentUser

        ' 2. Validation
        If String.IsNullOrEmpty(loggedInUser) Then
            MessageBox.Show("User session not found. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(currentpass.Text) OrElse String.IsNullOrWhiteSpace(newpass.Text) Then
            MessageBox.Show("Please fill in all fields.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newpass.Text <> confirmpass.Text Then
            MessageBox.Show("New passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 3. Attempt to update the database via DatabaseHelper
        Dim isSuccess As Boolean = db.UpdatePassword(loggedInUser, currentpass.Text, newpass.Text)

        If isSuccess Then
            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset UI
            currentpass.Clear()
            newpass.Clear()
            confirmpass.Clear()
            Me.Visible = False ' Hide the control after success
        Else
            ' This fails if the "Current Password" typed doesn't match the DB
            MessageBox.Show("The current password you entered is incorrect.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub CheckBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass.CheckedChanged
        Dim maskChar As Char = If(CheckBoxShowPass.Checked, ControlChars.NullChar, "●"c)
        currentpass.PasswordChar = maskChar
        newpass.PasswordChar = maskChar
        confirmpass.PasswordChar = maskChar
    End Sub

    Private Sub lblGoBack_Click(sender As Object, e As EventArgs) Handles lblGoBack.Click
        Me.Visible = False
    End Sub
End Class