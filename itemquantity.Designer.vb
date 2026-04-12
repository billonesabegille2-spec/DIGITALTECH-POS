Partial Class itemquantity
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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtQuantity.Location = New System.Drawing.Point(35, 103)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(184, 30)
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnMinus.Location = New System.Drawing.Point(237, 103)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(45, 32)
        Me.btnMinus.Text = "-"
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnPlus.Location = New System.Drawing.Point(303, 104)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(47, 31)
        Me.btnPlus.Text = "+"
        '
        'btn2, btn3, btn5, btn10 settings (omitted for brevity, matches your layout)
        '
        Me.btnEnter.Location = New System.Drawing.Point(115, 279)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(154, 39)
        Me.btnEnter.Text = "Enter Quantity"
        '
        'itemquantity
        '
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(412, 354)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.txtQuantity)
        Me.Name = "itemquantity"
        Me.Text = "Item Quantity"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn10 As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
End Class
