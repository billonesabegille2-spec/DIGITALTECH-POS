<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Menu
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
        Me.panelUp = New System.Windows.Forms.Panel()
        Me.PanelDown = New System.Windows.Forms.Panel()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lbljhared = New System.Windows.Forms.Label()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblMainMenu)
        Me.Panel1.Controls.Add(Me.lbljhared)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 455)
        Me.Panel1.TabIndex = 0
        '
        'panelUp
        '
        Me.panelUp.BackColor = System.Drawing.Color.Snow
        Me.panelUp.Location = New System.Drawing.Point(238, 27)
        Me.panelUp.Name = "panelUp"
        Me.panelUp.Size = New System.Drawing.Size(503, 197)
        Me.panelUp.TabIndex = 1
        '
        'PanelDown
        '
        Me.PanelDown.BackColor = System.Drawing.Color.Snow
        Me.PanelDown.Location = New System.Drawing.Point(238, 230)
        Me.PanelDown.Name = "PanelDown"
        Me.PanelDown.Size = New System.Drawing.Size(503, 192)
        Me.PanelDown.TabIndex = 2
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(222, 8)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(61, 13)
        Me.lblAdmin.TabIndex = 3
        Me.lblAdmin.Text = "Hi, Admin"
        '
        'lbljhared
        '
        Me.lbljhared.AutoSize = True
        Me.lbljhared.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljhared.Location = New System.Drawing.Point(13, 20)
        Me.lbljhared.Name = "lbljhared"
        Me.lbljhared.Size = New System.Drawing.Size(190, 15)
        Me.lbljhared.TabIndex = 0
        Me.lbljhared.Text = "JHARED CHLOIE FOOD HUB"
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.Location = New System.Drawing.Point(13, 50)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(79, 15)
        Me.lblMainMenu.TabIndex = 1
        Me.lblMainMenu.Text = "Main Menu"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Admin_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.PanelDown)
        Me.Controls.Add(Me.panelUp)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Menu"
        Me.Text = "Admin_Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelUp As Panel
    Friend WithEvents PanelDown As Panel
    Friend WithEvents lblAdmin As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents lbljhared As Label
End Class
