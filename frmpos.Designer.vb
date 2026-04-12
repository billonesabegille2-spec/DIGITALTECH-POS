<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmpos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flowmenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.listboxItem = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btndot = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.flowmenu)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 426)
        Me.Panel1.TabIndex = 0
        '
        'flowmenu
        '
        Me.flowmenu.AutoScroll = True
        Me.flowmenu.BackColor = System.Drawing.Color.Brown
        Me.flowmenu.Location = New System.Drawing.Point(10, 43)
        Me.flowmenu.Name = "flowmenu"
        Me.flowmenu.Size = New System.Drawing.Size(529, 371)
        Me.flowmenu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JHARED CHLOIE FOOD HUB"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.Controls.Add(Me.btnPlaceOrder)
        Me.Panel4.Controls.Add(Me.lblTotal)
        Me.Panel4.Controls.Add(Me.listboxItem)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Location = New System.Drawing.Point(578, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(196, 426)
        Me.Panel4.TabIndex = 1
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnPlaceOrder.Location = New System.Drawing.Point(31, 379)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(137, 35)
        Me.btnPlaceOrder.TabIndex = 3
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(17, 363)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(144, 13)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total                         ₱"
        '
        'listboxItem
        '
        Me.listboxItem.FormattingEnabled = True
        Me.listboxItem.Location = New System.Drawing.Point(6, 109)
        Me.listboxItem.Name = "listboxItem"
        Me.listboxItem.Size = New System.Drawing.Size(187, 251)
        Me.listboxItem.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Firebrick
        Me.Panel3.Controls.Add(Me.btndot)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Controls.Add(Me.PictureBox9)
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(190, 100)
        Me.Panel3.TabIndex = 0
        '
        'btndot
        '
        Me.btndot.BackColor = System.Drawing.Color.Firebrick
        Me.btndot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndot.ForeColor = System.Drawing.Color.White
        Me.btndot.Location = New System.Drawing.Point(152, 9)
        Me.btndot.Name = "btndot"
        Me.btndot.Size = New System.Drawing.Size(35, 34)
        Me.btndot.TabIndex = 4
        Me.btndot.Text = ". . ."
        Me.btndot.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(53, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Chloie "
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 2
        Me.PictureBox9.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.Font = New System.Drawing.Font("Sitka Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(62, 63)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 31)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmpos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JHARED_CHLOIE_FOOD_HUB.My.Resources.Resources._641696537_26125020667128207_8862701495628220866_n__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmpos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents listboxItem As ListBox
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents btndot As Button
    Friend WithEvents flowmenu As FlowLayoutPanel
End Class
