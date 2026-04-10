Imports System.Windows.Forms
Imports System.Drawing

Public Class Form2
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub BtnGetStarted_Click(sender As Object, e As EventArgs) Handles BtnGetStarted.Click
        Try

            Dim frmWelcome As New Login()
            frmWelcome.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Friend WithEvents BtnGetStarted As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnGetStarted = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblJCFH = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnGetStarted
        '
        Me.BtnGetStarted.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGetStarted.Location = New System.Drawing.Point(281, 299)
        Me.BtnGetStarted.Name = "BtnGetStarted"
        Me.BtnGetStarted.Size = New System.Drawing.Size(120, 40)
        Me.BtnGetStarted.TabIndex = 0
        Me.BtnGetStarted.Text = "Get Started"
        Me.BtnGetStarted.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Uighur", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(246, 72)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(213, 75)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome"
        '
        'lblJCFH
        '
        Me.lblJCFH.AutoSize = True
        Me.lblJCFH.BackColor = System.Drawing.Color.Transparent
        Me.lblJCFH.Font = New System.Drawing.Font("Microsoft Uighur", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJCFH.Location = New System.Drawing.Point(100, 157)
        Me.lblJCFH.Name = "lblJCFH"
        Me.lblJCFH.Size = New System.Drawing.Size(497, 75)
        Me.lblJCFH.TabIndex = 2
        Me.lblJCFH.Text = "Jhared Chloie Food Hub"
        '
        'Form2
        '
        Me.BackgroundImage = Global.JHARED_CHLOIE_FOOD_HUB.My.Resources.Resources._657055756_1999733117585968_760099159505506197_n__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 379)
        Me.Controls.Add(Me.lblJCFH)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.BtnGetStarted)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JHARED CHLOIE FOOD HUB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblJCFH As Label

End Class