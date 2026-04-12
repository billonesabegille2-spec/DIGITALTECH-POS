Imports System.Data.SQLite
Imports System.IO

Public Class frmpos
    Private totalAmount As Decimal = 0
    ' Initialize your database helper (ensure the filename matches your login/admin setup)
    Private db As New DatabaseHelper("foodhub.db")

    Private Sub frmpos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display Cashier Name from GlobalData
        If String.IsNullOrEmpty(GlobalData.CurrentUser) Then
            lblName.Text = "Cashier: Unknown"
        Else
            lblName.Text = "Cashier: " & GlobalData.CurrentUser
        End If

        ' Load products directly from the database
        RefreshDynamicMenu()
    End Sub

    ' --- DATABASE-DRIVEN MENU LOGIC ---
    Public Sub RefreshDynamicMenu()
        If flowmenu IsNot Nothing Then
            flowmenu.Controls.Clear()

            ' Get all products using the helper method from your DatabaseHelper
            Dim dt As DataTable = db.GetAllProducts()

            For Each row As DataRow In dt.Rows
                Dim btn As New Button()
                btn.Size = New Size(110, 110)

                ' Set text with Price from Database
                btn.Text = row("ItemName").ToString() & vbCrLf & "₱" & row("ItemPrice").ToString()
                btn.Tag = row("ItemPrice")

                ' Apply your theme colors
                btn.BackColor = Color.IndianRed
                btn.ForeColor = Color.White
                btn.TextAlign = ContentAlignment.BottomCenter

                ' Load Image from Database BLOB if it exists
                If Not IsDBNull(row("ItemImage")) Then
                    Dim imgData As Byte() = DirectCast(row("ItemImage"), Byte())
                    Using ms As New MemoryStream(imgData)
                        btn.BackgroundImage = Image.FromStream(ms)
                        btn.BackgroundImageLayout = ImageLayout.Zoom
                    End Using
                End If

                ' Add the click event
                AddHandler btn.Click, AddressOf DynamicItem_Click
                flowmenu.Controls.Add(btn)
            Next
        End If
    End Sub

    ' --- EVENT HANDLERS ---
    Private Sub DynamicItem_Click(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        ' Split by the Peso sign to get only the name
        Dim itemName As String = btn.Text.Split("₱")(0).Trim()
        Dim price As Decimal = CDec(btn.Tag)
        AddToCart(itemName, price)
    End Sub

    Private Sub AddToCart(itemName As String, price As Decimal)
        listboxItem.Items.Add(String.Format("{0} - ₱{1:N2}", itemName, price))
        totalAmount += price
        UpdateTotalDisplay()
    End Sub

    Private Sub UpdateTotalDisplay()
        lblTotal.Text = String.Format("Total: ₱{0:N2}", totalAmount)
    End Sub

    ' --- ACTION BUTTONS ---
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If listboxItem.Items.Count > 0 Then
            Dim paymentForm As New Total_Items()
            paymentForm.receivedTotal = Me.totalAmount

            ' Pass items to the listbox on the payment form
            For Each item In listboxItem.Items
                paymentForm.lstItems.Items.Add(item)
            Next

            ' Clear cart only if payment was confirmed (DialogResult.OK)
            If paymentForm.ShowDialog() = DialogResult.OK Then
                btnClear.PerformClick()
            End If
        Else
            MessageBox.Show("Cart is empty!", "Oops")
        End If
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btndot.Click
        Dim admin As New admin_menu()
        admin.ShowDialog()
        ' Immediately refresh the menu to show any new items added in Admin
        RefreshDynamicMenu()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listboxItem.Items.Clear()
        totalAmount = 0
        UpdateTotalDisplay()
    End Sub

    Private Sub flowmenu_Paint(sender As Object, e As PaintEventArgs) Handles flowmenu.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class