<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
    Inherits System.Windows.Forms.Form
    'UserControl overrides dispose to clean up the component list.
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
        Me.panelChangePass = New System.Windows.Forms.Panel()
        Me.lblGoBack = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.CheckBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.confirmpass = New System.Windows.Forms.TextBox()
        Me.currentpass = New System.Windows.Forms.TextBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.newpass = New System.Windows.Forms.TextBox()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblCurrentPass = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblChangePass = New System.Windows.Forms.Label()
        Me.panelChangePass.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelChangePass
        '
        Me.panelChangePass.BackColor = System.Drawing.Color.White
        Me.panelChangePass.Controls.Add(Me.lblGoBack)
        Me.panelChangePass.Controls.Add(Me.btnReset)
        Me.panelChangePass.Controls.Add(Me.CheckBoxShowPass)
        Me.panelChangePass.Controls.Add(Me.confirmpass)
        Me.panelChangePass.Controls.Add(Me.currentpass)
        Me.panelChangePass.Controls.Add(Me.lblConfirmPass)
        Me.panelChangePass.Controls.Add(Me.newpass)
        Me.panelChangePass.Controls.Add(Me.lblNewPass)
        Me.panelChangePass.Controls.Add(Me.lblCurrentPass)
        Me.panelChangePass.Controls.Add(Me.lblUsername)
        Me.panelChangePass.Controls.Add(Me.lblChangePass)
        Me.panelChangePass.Location = New System.Drawing.Point(18, 19)
        Me.panelChangePass.Name = "panelChangePass"
        Me.panelChangePass.Size = New System.Drawing.Size(351, 426)
        Me.panelChangePass.TabIndex = 0
        '
        'lblGoBack
        '
        Me.lblGoBack.AutoSize = True
        Me.lblGoBack.BackColor = System.Drawing.Color.Transparent
        Me.lblGoBack.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoBack.ForeColor = System.Drawing.Color.Firebrick
        Me.lblGoBack.Location = New System.Drawing.Point(252, 396)
        Me.lblGoBack.Name = "lblGoBack"
        Me.lblGoBack.Size = New System.Drawing.Size(54, 15)
        Me.lblGoBack.TabIndex = 12
        Me.lblGoBack.Text = "Go Back"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Firebrick
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(88, 346)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(175, 38)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'CheckBoxShowPass
        '
        Me.CheckBoxShowPass.AutoSize = True
        Me.CheckBoxShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxShowPass.Location = New System.Drawing.Point(221, 301)
        Me.CheckBoxShowPass.Name = "CheckBoxShowPass"
        Me.CheckBoxShowPass.Size = New System.Drawing.Size(115, 17)
        Me.CheckBoxShowPass.TabIndex = 10
        Me.CheckBoxShowPass.Text = "Show Password"
        Me.CheckBoxShowPass.UseVisualStyleBackColor = True
        '
        'confirmpass
        '
        Me.confirmpass.Location = New System.Drawing.Point(23, 257)
        Me.confirmpass.Multiline = True
        Me.confirmpass.Name = "confirmpass"
        Me.confirmpass.Size = New System.Drawing.Size(295, 38)
        Me.confirmpass.TabIndex = 8
        '
        'currentpass
        '
        Me.currentpass.Location = New System.Drawing.Point(23, 122)
        Me.currentpass.Multiline = True
        Me.currentpass.Name = "currentpass"
        Me.currentpass.Size = New System.Drawing.Size(295, 38)
        Me.currentpass.TabIndex = 7
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.Location = New System.Drawing.Point(20, 239)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(112, 15)
        Me.lblConfirmPass.TabIndex = 6
        Me.lblConfirmPass.Text = "Confirm Password:"
        '
        'newpass
        '
        Me.newpass.Location = New System.Drawing.Point(23, 184)
        Me.newpass.Multiline = True
        Me.newpass.Name = "newpass"
        Me.newpass.Size = New System.Drawing.Size(295, 38)
        Me.newpass.TabIndex = 5
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.Location = New System.Drawing.Point(12, 166)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(89, 15)
        Me.lblNewPass.TabIndex = 3
        Me.lblNewPass.Text = "New Password:"
        '
        'lblCurrentPass
        '
        Me.lblCurrentPass.AutoSize = True
        Me.lblCurrentPass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPass.Location = New System.Drawing.Point(12, 104)
        Me.lblCurrentPass.Name = "lblCurrentPass"
        Me.lblCurrentPass.Size = New System.Drawing.Size(111, 15)
        Me.lblCurrentPass.TabIndex = 2
        Me.lblCurrentPass.Text = "Current Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(12, 67)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(66, 15)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username:"
        '
        'lblChangePass
        '
        Me.lblChangePass.AutoSize = True
        Me.lblChangePass.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePass.Location = New System.Drawing.Point(21, 20)
        Me.lblChangePass.Name = "lblChangePass"
        Me.lblChangePass.Size = New System.Drawing.Size(223, 31)
        Me.lblChangePass.TabIndex = 0
        Me.lblChangePass.Text = "Change Password"
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(384, 465)
        Me.Controls.Add(Me.panelChangePass)
        Me.Name = "ChangePass"
        Me.panelChangePass.ResumeLayout(False)
        Me.panelChangePass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelChangePass As Panel
    Friend WithEvents lblNewPass As Label
    Friend WithEvents lblCurrentPass As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblChangePass As Label
    Friend WithEvents confirmpass As TextBox
    Friend WithEvents currentpass As TextBox
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents newpass As TextBox
    Friend WithEvents CheckBoxShowPass As CheckBox
    Friend WithEvents lblGoBack As Label
    Friend WithEvents btnReset As Button
End Class
