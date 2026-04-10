<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.lblViewProfile = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.btnEditProfile)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 421)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.lblAge)
        Me.Panel2.Controls.Add(Me.lblBirthday)
        Me.Panel2.Controls.Add(Me.lblGender)
        Me.Panel2.Location = New System.Drawing.Point(241, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 150)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.JHARED_CHLOIE_FOOD_HUB.My.Resources.Resources.istockphoto_2171382633_612x6121
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(43, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 90)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(32, 31)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(58, 15)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Gender:"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.Location = New System.Drawing.Point(32, 69)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(63, 15)
        Me.lblBirthday.TabIndex = 1
        Me.lblBirthday.Text = "Birthday:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(32, 104)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(35, 15)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        '
        'btnEditProfile
        '
        Me.btnEditProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProfile.ForeColor = System.Drawing.Color.Firebrick
        Me.btnEditProfile.Location = New System.Drawing.Point(43, 246)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.Size = New System.Drawing.Size(121, 32)
        Me.btnEditProfile.TabIndex = 1
        Me.btnEditProfile.Text = "EDIT PROFILE"
        Me.btnEditProfile.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.Firebrick
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.White
        Me.btnLog.Location = New System.Drawing.Point(403, 256)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 32)
        Me.btnLog.TabIndex = 2
        Me.btnLog.Text = "LOG OUT"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'lblViewProfile
        '
        Me.lblViewProfile.AutoSize = True
        Me.lblViewProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewProfile.Location = New System.Drawing.Point(219, 25)
        Me.lblViewProfile.Name = "lblViewProfile"
        Me.lblViewProfile.Size = New System.Drawing.Size(89, 16)
        Me.lblViewProfile.TabIndex = 3
        Me.lblViewProfile.Text = "View Profile"
        '
        'view_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.lblViewProfile)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_profile"
        Me.Text = "view_profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
