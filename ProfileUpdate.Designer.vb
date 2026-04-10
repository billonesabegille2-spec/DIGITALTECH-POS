<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileUpdate
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.PictureUser = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.CheckBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.labelItsQuick = New System.Windows.Forms.Label()
        Me.LabelLetsGet = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSeaShell = New System.Windows.Forms.Panel()
        Me.PanelRed = New System.Windows.Forms.Panel()
        Me.btnChangePass = New System.Windows.Forms.Button()
        CType(Me.PictureUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSeaShell.SuspendLayout()
        Me.PanelRed.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Snow
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(301, 339)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 33)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(130, 339)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 33)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Uighur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(415, 132)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(88, 31)
        Me.btnUpload.TabIndex = 18
        Me.btnUpload.Text = "Select Image"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'PictureUser
        '
        Me.PictureUser.BackColor = System.Drawing.Color.Transparent
        Me.PictureUser.BackgroundImage = Global.JHARED_CHLOIE_FOOD_HUB.My.Resources.Resources.istockphoto_2171382633_612x612
        Me.PictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureUser.Location = New System.Drawing.Point(395, 20)
        Me.PictureUser.Name = "PictureUser"
        Me.PictureUser.Size = New System.Drawing.Size(128, 97)
        Me.PictureUser.TabIndex = 17
        Me.PictureUser.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(20, 253)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 28)
        Me.DateTimePicker1.TabIndex = 16
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(15, 202)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 27)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender:"
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFemale.Location = New System.Drawing.Point(182, 200)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(71, 29)
        Me.RadioButtonFemale.TabIndex = 14
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMale.Location = New System.Drawing.Point(103, 200)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(59, 29)
        Me.RadioButtonMale.TabIndex = 13
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'CheckBoxShowPass
        '
        Me.CheckBoxShowPass.AutoSize = True
        Me.CheckBoxShowPass.Font = New System.Drawing.Font("Microsoft Uighur", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxShowPass.Location = New System.Drawing.Point(456, 253)
        Me.CheckBoxShowPass.Name = "CheckBoxShowPass"
        Me.CheckBoxShowPass.Size = New System.Drawing.Size(99, 26)
        Me.CheckBoxShowPass.TabIndex = 12
        Me.CheckBoxShowPass.Text = "Show Password"
        Me.CheckBoxShowPass.UseVisualStyleBackColor = True
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxPassword.Location = New System.Drawing.Point(395, 226)
        Me.txtboxPassword.Multiline = True
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(140, 30)
        Me.txtboxPassword.TabIndex = 10
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxUsername.Location = New System.Drawing.Point(395, 187)
        Me.txtboxUsername.Multiline = True
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(140, 31)
        Me.txtboxUsername.TabIndex = 9
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(301, 229)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(77, 27)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(296, 191)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(82, 27)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username:"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(115, 134)
        Me.txtLName.Multiline = True
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(164, 29)
        Me.txtLName.TabIndex = 5
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(115, 96)
        Me.txtMName.Multiline = True
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(164, 29)
        Me.txtMName.TabIndex = 4
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(115, 56)
        Me.txtFName.Multiline = True
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(164, 30)
        Me.txtFName.TabIndex = 3
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(15, 136)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(83, 27)
        Me.lblLName.TabIndex = 2
        Me.lblLName.Text = "Last Name:"
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMName.Location = New System.Drawing.Point(15, 98)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(102, 27)
        Me.lblMName.TabIndex = 1
        Me.lblMName.Text = "Middle Name:"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.ForeColor = System.Drawing.Color.Black
        Me.lblFName.Location = New System.Drawing.Point(15, 63)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(86, 27)
        Me.lblFName.TabIndex = 0
        Me.lblFName.Text = "First Name:"
        '
        'labelItsQuick
        '
        Me.labelItsQuick.AutoSize = True
        Me.labelItsQuick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItsQuick.ForeColor = System.Drawing.Color.White
        Me.labelItsQuick.Location = New System.Drawing.Point(37, 288)
        Me.labelItsQuick.Name = "labelItsQuick"
        Me.labelItsQuick.Size = New System.Drawing.Size(163, 20)
        Me.labelItsQuick.TabIndex = 2
        Me.labelItsQuick.Text = "It's quick and easy."
        '
        'LabelLetsGet
        '
        Me.LabelLetsGet.AutoSize = True
        Me.LabelLetsGet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLetsGet.ForeColor = System.Drawing.Color.White
        Me.LabelLetsGet.Location = New System.Drawing.Point(17, 259)
        Me.LabelLetsGet.Name = "LabelLetsGet"
        Me.LabelLetsGet.Size = New System.Drawing.Size(167, 20)
        Me.LabelLetsGet.TabIndex = 1
        Me.LabelLetsGet.Text = "Let's get you set up"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.JHARED_CHLOIE_FOOD_HUB.My.Resources.Resources.ChatGPT_Image_Mar_25__2026__10_15_03_PM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(17, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 158)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelSeaShell
        '
        Me.PanelSeaShell.BackColor = System.Drawing.Color.SeaShell
        Me.PanelSeaShell.Controls.Add(Me.btnChangePass)
        Me.PanelSeaShell.Controls.Add(Me.btnUpdate)
        Me.PanelSeaShell.Controls.Add(Me.btnCancel)
        Me.PanelSeaShell.Controls.Add(Me.btnUpload)
        Me.PanelSeaShell.Controls.Add(Me.PictureUser)
        Me.PanelSeaShell.Controls.Add(Me.DateTimePicker1)
        Me.PanelSeaShell.Controls.Add(Me.lblGender)
        Me.PanelSeaShell.Controls.Add(Me.RadioButtonFemale)
        Me.PanelSeaShell.Controls.Add(Me.RadioButtonMale)
        Me.PanelSeaShell.Controls.Add(Me.CheckBoxShowPass)
        Me.PanelSeaShell.Controls.Add(Me.txtboxPassword)
        Me.PanelSeaShell.Controls.Add(Me.txtboxUsername)
        Me.PanelSeaShell.Controls.Add(Me.lblPassword)
        Me.PanelSeaShell.Controls.Add(Me.lblUsername)
        Me.PanelSeaShell.Controls.Add(Me.txtLName)
        Me.PanelSeaShell.Controls.Add(Me.txtMName)
        Me.PanelSeaShell.Controls.Add(Me.txtFName)
        Me.PanelSeaShell.Controls.Add(Me.lblLName)
        Me.PanelSeaShell.Controls.Add(Me.lblMName)
        Me.PanelSeaShell.Controls.Add(Me.lblFName)
        Me.PanelSeaShell.Location = New System.Drawing.Point(223, 23)
        Me.PanelSeaShell.Name = "PanelSeaShell"
        Me.PanelSeaShell.Size = New System.Drawing.Size(574, 414)
        Me.PanelSeaShell.TabIndex = 3
        '
        'PanelRed
        '
        Me.PanelRed.BackColor = System.Drawing.Color.Firebrick
        Me.PanelRed.Controls.Add(Me.labelItsQuick)
        Me.PanelRed.Controls.Add(Me.LabelLetsGet)
        Me.PanelRed.Controls.Add(Me.PictureBox1)
        Me.PanelRed.Location = New System.Drawing.Point(4, -5)
        Me.PanelRed.Name = "PanelRed"
        Me.PanelRed.Size = New System.Drawing.Size(200, 460)
        Me.PanelRed.TabIndex = 2
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.Color.Firebrick
        Me.btnChangePass.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.ForeColor = System.Drawing.Color.White
        Me.btnChangePass.Location = New System.Drawing.Point(395, 273)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(148, 33)
        Me.btnChangePass.TabIndex = 21
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'ProfileUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelSeaShell)
        Me.Controls.Add(Me.PanelRed)
        Me.Name = "ProfileUpdate"
        Me.Text = "ProfileUpdate"
        CType(Me.PictureUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSeaShell.ResumeLayout(False)
        Me.PanelSeaShell.PerformLayout()
        Me.PanelRed.ResumeLayout(False)
        Me.PanelRed.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents PictureUser As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblGender As Label
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents CheckBoxShowPass As CheckBox
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents lblMName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents labelItsQuick As Label
    Friend WithEvents LabelLetsGet As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelSeaShell As Panel
    Friend WithEvents PanelRed As Panel
    Friend WithEvents btnChangePass As Button
End Class
