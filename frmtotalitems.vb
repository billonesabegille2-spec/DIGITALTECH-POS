Public Class Total_Items
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn7.Click

    End Sub

    Private Sub Total_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public Class Form1

        Dim quantity As Integer = 0

        Private txtQty As TextBox

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            Me.Text = "itemquantity"
            Me.Size = New Size(400, 350)
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.BackColor = Color.Firebrick

            ' MAIN PANEL (WHITE)
            Dim panelMain As New Panel()
            panelMain.BackColor = Color.White
            panelMain.Size = New Size(340, 260)
            panelMain.Location = New Point(20, 20)
            Me.Controls.Add(panelMain)

            ' TITLE
            Dim lblTitle As New Label()
            lblTitle.Text = "Item Quantity"
            lblTitle.Font = New Font("Arial", 12, FontStyle.Bold)
            lblTitle.Location = New Point(20, 15)
            panelMain.Controls.Add(lblTitle)

            ' TEXTBOX
            txtQty = New TextBox()
            txtQty.Size = New Size(140, 30)
            txtQty.Location = New Point(20, 50)
            txtQty.TextAlign = HorizontalAlignment.Center
            panelMain.Controls.Add(txtQty)

            ' MINUS BUTTON
            Dim btnMinus As New Button()
            btnMinus.Text = "-"
            btnMinus.Size = New Size(50, 30)
            btnMinus.Location = New Point(170, 50)
            AddHandler btnMinus.Click, AddressOf Minus_Click
            panelMain.Controls.Add(btnMinus)

            ' PLUS BUTTON
            Dim btnPlus As New Button()
            btnPlus.Text = "+"
            btnPlus.BackColor = Color.Firebrick
            btnPlus.ForeColor = Color.White
            btnPlus.Size = New Size(50, 30)
            btnPlus.Location = New Point(230, 50)
            AddHandler btnPlus.Click, AddressOf Plus_Click
            panelMain.Controls.Add(btnPlus)

            ' PRESET BUTTONS
            CreatePresetButton(panelMain, "2", 20, 100)
            CreatePresetButton(panelMain, "3", 180, 100)
            CreatePresetButton(panelMain, "5", 20, 140)
            CreatePresetButton(panelMain, "10", 180, 140)

            ' ENTER BUTTON
            Dim btnEnter As New Button()
            btnEnter.Text = "Enter Quantity"
            btnEnter.Size = New Size(180, 35)
            btnEnter.Location = New Point(80, 190)
            AddHandler btnEnter.Click, AddressOf Enter_Click
            panelMain.Controls.Add(btnEnter)

        End Sub

        ' ➕ PLUS
        Private Sub Plus_Click(sender As Object, e As EventArgs)
            quantity += 1
            txtQty.Text = quantity.ToString()
        End Sub

        ' ➖ MINUS
        Private Sub Minus_Click(sender As Object, e As EventArgs)
            If quantity > 0 Then
                quantity -= 1
            End If
            txtQty.Text = quantity.ToString()
        End Sub

        ' PRESET BUTTON CREATOR
        Private Sub CreatePresetButton(panel As Panel, text As String, x As Integer, y As Integer)
            Dim btn As New Button()
            btn.Text = text
            btn.Size = New Size(140, 30)
            btn.Location = New Point(x, y)
            btn.BackColor = Color.Firebrick
            btn.ForeColor = Color.White

            AddHandler btn.Click, Sub()
                                      quantity = Convert.ToInt32(text)
                                      txtQty.Text = quantity.ToString()
                                  End Sub

            panel.Controls.Add(btn)
        End Sub

        ' ENTER BUTTON ACTION
        Private Sub Enter_Click(sender As Object, e As EventArgs)
            MessageBox.Show("Quantity entered: " & txtQty.Text)
        End Sub

    End Class
    