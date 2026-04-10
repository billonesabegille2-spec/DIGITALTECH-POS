<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcomeform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lbljharedchloiefoodhub = New System.Windows.Forms.Label()
        Me.btnGetStarted = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(257, 99)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(280, 73)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome"
        '
        'lbljharedchloiefoodhub
        '
        Me.lbljharedchloiefoodhub.AutoSize = True
        Me.lbljharedchloiefoodhub.BackColor = System.Drawing.Color.Transparent
        Me.lbljharedchloiefoodhub.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljharedchloiefoodhub.Location = New System.Drawing.Point(32, 206)
        Me.lbljharedchloiefoodhub.Name = "lbljharedchloiefoodhub"
        Me.lbljharedchloiefoodhub.Size = New System.Drawing.Size(743, 73)
        Me.lbljharedchloiefoodhub.TabIndex = 1
        Me.lbljharedchloiefoodhub.Text = "Jhared Choloie Food Hub"
        '
        'btnGetStarted
        '
        Me.btnGetStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetStarted.Location = New System.Drawing.Point(321, 370)
        Me.btnGetStarted.Name = "btnGetStarted"
        Me.btnGetStarted.Size = New System.Drawing.Size(120, 40)
        Me.btnGetStarted.TabIndex = 2
        Me.btnGetStarted.Text = "Get Started"
        Me.btnGetStarted.UseVisualStyleBackColor = True
        '
        'welcomeform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JHARED_CHLOIE_FOOD_HUB.My.Resources.Resources._657055756_1999733117585968_760099159505506197_n__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGetStarted)
        Me.Controls.Add(Me.lbljharedchloiefoodhub)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "welcomeform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lbljharedchloiefoodhub As Label
    Friend WithEvents btnGetStarted As Button

    Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click

    End Sub
End Class
