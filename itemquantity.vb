Public Class itemquantity
    Inherits System.Windows.Forms.Form

    Private Sub itemquantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Your code here
    End Sub

    Private Sub InitializeComponent()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(35, 103)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(184, 30)
        Me.txtQuantity.TabIndex = 0
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(237, 103)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(45, 32)
        Me.btnMinus.TabIndex = 1
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(303, 104)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(47, 31)
        Me.btnPlus.TabIndex = 2
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(93, 158)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 38)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(207, 158)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 38)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(93, 219)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 38)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(207, 219)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(75, 38)
        Me.btn10.TabIndex = 6
        Me.btn10.Text = "10"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(93, 290)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(154, 39)
        Me.txtInput.TabIndex = 7
        Me.txtInput.Text = "Enter Quantity"
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'itemquantity
        '
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(412, 354)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.txtQuantity)
        Me.Font = New System.Drawing.Font("Microsoft Uighur", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "itemquantity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
