Public Class view_profile


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form settings
        Me.Text = "Profile"
        Me.Size = New Size(800, 400)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' LEFT PANEL (RED)
        Dim panelLeft As New Panel()
        panelLeft.BackColor = Color.Firebrick
        panelLeft.Size = New Size(250, Me.Height)
        panelLeft.Location = New Point(0, 0)
        Me.Controls.Add(panelLeft)

        ' PROFILE IMAGE
        Dim picProfile As New PictureBox()
        picProfile.Size = New Size(120, 120)
        picProfile.Location = New Point(65, 40)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.Image = SystemIcons.Information.ToBitmap() ' placeholder image
        panelLeft.Controls.Add(picProfile)

        ' EDIT PROFILE BUTTON
        Dim btnEdit As New Button()
        btnEdit.Text = "EDIT PROFILE"
        btnEdit.Size = New Size(150, 35)
        btnEdit.Location = New Point(50, 180)
        panelLeft.Controls.Add(btnEdit)

        ' RIGHT PANEL (WHITE)
        Dim panelRight As New Panel()
        panelRight.BackColor = Color.White
        panelRight.Size = New Size(550, Me.Height)
        panelRight.Location = New Point(250, 0)
        Me.Controls.Add(panelRight)

        ' TITLE
        Dim lblTitle As New Label()
        lblTitle.Text = "View Profile"
        lblTitle.Font = New Font("Arial", 14, FontStyle.Bold)
        lblTitle.Location = New Point(20, 20)
        panelRight.Controls.Add(lblTitle)

        ' GO BACK LINK
        Dim lblBack As New Label()
        lblBack.Text = "Go Back"
        lblBack.ForeColor = Color.Red
        lblBack.Location = New Point(450, 20)
        panelRight.Controls.Add(lblBack)

        ' INFO BOX
        Dim grpBox As New GroupBox()
        grpBox.Size = New Size(300, 150)
        grpBox.Location = New Point(100, 80)
        panelRight.Controls.Add(grpBox)

        ' LABELS INSIDE BOX
        Dim lblGender As New Label()
        lblGender.Text = "Gender:"
        lblGender.Location = New Point(20, 30)

        Dim lblBirthday As New Label()
        lblBirthday.Text = "Birthday:"
        lblBirthday.Location = New Point(20, 60)

        Dim lblAge As New Label()
        lblAge.Text = "Age:"
        lblAge.Location = New Point(20, 90)

        grpBox.Controls.Add(lblGender)
        grpBox.Controls.Add(lblBirthday)
        grpBox.Controls.Add(lblAge)

        ' LOG OUT BUTTON
        Dim btnLogout As New Button()
        btnLogout.Text = "LOG OUT"
        btnLogout.BackColor = Color.Firebrick
        btnLogout.ForeColor = Color.White
        btnLogout.Size = New Size(100, 35)
        btnLogout.Location = New Point(350, 250)
        panelRight.Controls.Add(btnLogout)

    End Sub
End Class
   