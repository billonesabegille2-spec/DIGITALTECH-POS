<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Total_Items
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.PanelPayment = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btn00 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.lstItems)
        Me.Panel1.Location = New System.Drawing.Point(33, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 392)
        Me.Panel1.TabIndex = 0
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(23, 15)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(268, 355)
        Me.lstItems.TabIndex = 0
        '
        'PanelPayment
        '
        Me.PanelPayment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelPayment.Controls.Add(Me.lblTotal)
        Me.PanelPayment.Controls.Add(Me.btnDelete)
        Me.PanelPayment.Controls.Add(Me.txtDisplay)
        Me.PanelPayment.Controls.Add(Me.btnPay)
        Me.PanelPayment.Controls.Add(Me.btn00)
        Me.PanelPayment.Controls.Add(Me.btn0)
        Me.PanelPayment.Controls.Add(Me.btnDot)
        Me.PanelPayment.Controls.Add(Me.btn3)
        Me.PanelPayment.Controls.Add(Me.btn2)
        Me.PanelPayment.Controls.Add(Me.btn1)
        Me.PanelPayment.Controls.Add(Me.btn6)
        Me.PanelPayment.Controls.Add(Me.btn5)
        Me.PanelPayment.Controls.Add(Me.btn4)
        Me.PanelPayment.Controls.Add(Me.btn9)
        Me.PanelPayment.Controls.Add(Me.btn8)
        Me.PanelPayment.Controls.Add(Me.btn7)
        Me.PanelPayment.Controls.Add(Me.lblPayment)
        Me.PanelPayment.Location = New System.Drawing.Point(425, 26)
        Me.PanelPayment.Name = "PanelPayment"
        Me.PanelPayment.Size = New System.Drawing.Size(316, 378)
        Me.PanelPayment.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(38, 53)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(32, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "0.00"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(200, 97)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 37)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(38, 97)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(156, 34)
        Me.txtDisplay.TabIndex = 14
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Firebrick
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(41, 309)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(234, 37)
        Me.btnPay.TabIndex = 13
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btn00
        '
        Me.btn00.Location = New System.Drawing.Point(200, 266)
        Me.btn00.Name = "btn00"
        Me.btn00.Size = New System.Drawing.Size(75, 37)
        Me.btn00.TabIndex = 12
        Me.btn00.Text = "00"
        Me.btn00.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(119, 266)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(75, 37)
        Me.btn0.TabIndex = 11
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(38, 266)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(75, 37)
        Me.btnDot.TabIndex = 10
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(200, 223)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 37)
        Me.btn3.TabIndex = 9
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(119, 223)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 37)
        Me.btn2.TabIndex = 8
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(38, 223)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 37)
        Me.btn1.TabIndex = 7
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(200, 180)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 37)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(119, 180)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 37)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(41, 180)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 37)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(200, 137)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(75, 37)
        Me.btn9.TabIndex = 3
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(119, 137)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 37)
        Me.btn8.TabIndex = 2
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(38, 137)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 37)
        Me.btn7.TabIndex = 1
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(12, 15)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(67, 16)
        Me.lblPayment.TabIndex = 0
        Me.lblPayment.Text = "Payment"
        '
        'Total_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelPayment)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Total_Items"
        Me.Text = "Total_Items"
        Me.Panel1.ResumeLayout(False)
        Me.PanelPayment.ResumeLayout(False)
        Me.PanelPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelPayment As Panel
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btn00 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents lstItems As ListBox
End Class
