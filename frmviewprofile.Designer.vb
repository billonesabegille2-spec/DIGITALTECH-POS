<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class view_profile
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.lblViewProfile = New System.Windows.Forms.Label()
        Me.lblGoBack = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.btnEditProfile)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 503)
        Me.Panel1.TabIndex = 0
        '
        'btnEditProfile
        '
        Me.btnEditProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEditProfile.ForeColor = System.Drawing.Color.Firebrick
        Me.btnEditProfile.Location = New System.Drawing.Point(43, 426)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.Size = New System.Drawing.Size(121, 32)
        Me.btnEditProfile.TabIndex = 1
        Me.btnEditProfile.Text = "EDIT PROFILE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(43, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 90)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.lblAge)
        Me.Panel2.Controls.Add(Me.lblBirthday)
        Me.Panel2.Controls.Add(Me.lblGender)
        Me.Panel2.Location = New System.Drawing.Point(241, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(428, 343)
        Me.Panel2.TabIndex = 1
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(32, 163)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age:"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(32, 69)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(48, 13)
        Me.lblBirthday.TabIndex = 1
        Me.lblBirthday.Text = "Birthday:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(32, 31)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 2
        Me.lblGender.Text = "Gender:"
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.Firebrick
        Me.btnLog.ForeColor = System.Drawing.Color.White
        Me.btnLog.Location = New System.Drawing.Point(607, 445)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 32)
        Me.btnLog.TabIndex = 2
        Me.btnLog.Text = "LOG OUT"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'lblViewProfile
        '
        Me.lblViewProfile.Location = New System.Drawing.Point(219, 25)
        Me.lblViewProfile.Name = "lblViewProfile"
        Me.lblViewProfile.Size = New System.Drawing.Size(100, 23)
        Me.lblViewProfile.TabIndex = 1
        Me.lblViewProfile.Text = "View Profile"
        '
        'lblGoBack
        '
        Me.lblGoBack.ForeColor = System.Drawing.Color.Firebrick
        Me.lblGoBack.Location = New System.Drawing.Point(438, 27)
        Me.lblGoBack.Name = "lblGoBack"
        Me.lblGoBack.Size = New System.Drawing.Size(100, 23)
        Me.lblGoBack.TabIndex = 0
        Me.lblGoBack.Text = "Go Back"
        '
        'view_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 489)
        Me.Controls.Add(Me.lblGoBack)
        Me.Controls.Add(Me.lblViewProfile)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_profile"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAge As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents btnLog As Button
    Friend WithEvents lblViewProfile As Label
    Friend WithEvents lblGoBack As Label
End Class
