Public Class frmpos
    ' Variable to keep track of the running total
    Private totalAmount As Decimal = 0

    ' Helper method to avoid repeating code for every button
    Private Sub AddToCart(itemName As String, price As Decimal)
        ' Add item to the ListBox: "Item Name - ₱0.00"
        listboxItem.Items.Add(String.Format("{0} - ₱{1:N2}", itemName, price))

        ' Update the total variable
        totalAmount += price

        ' Update the total label automatically
        UpdateTotalDisplay()
    End Sub

    Private Sub UpdateTotalDisplay()
        lblTotal.Text = String.Format("Total: ₱{0:N2}", totalAmount)
    End Sub

    ' --- PRODUCT BUTTONS ---

    Private Sub BTNWHOLE_Click(sender As Object, e As EventArgs) Handles BTNWHOLE.Click
        AddToCart("Whole Chicken", 250.0)
    End Sub

    Private Sub btnhalf_Click(sender As Object, e As EventArgs) Handles btnhalf.Click
        AddToCart("Half Chicken", 130.0)
    End Sub

    Private Sub btnhita_Click(sender As Object, e As EventArgs) Handles btnhita.Click
        AddToCart("Hita", 85.0)
    End Sub

    Private Sub btndrumstick_Click(sender As Object, e As EventArgs) Handles btndrumstick.Click
        AddToCart("Drumstick", 75.0)
    End Sub

    Private Sub btnneck_Click(sender As Object, e As EventArgs) Handles btnneck.Click
        AddToCart("Neck", 25.0)
    End Sub

    Private Sub btnwings_Click(sender As Object, e As EventArgs) Handles btnwings.Click
        AddToCart("Wings", 60.0)
    End Sub

    Private Sub btnpitso_Click(sender As Object, e As EventArgs) Handles btnpitso.Click
        AddToCart("Pitso", 90.0)
    End Sub

    Private Sub btnthigh_Click(sender As Object, e As EventArgs) Handles btnthigh.Click
        AddToCart("Thigh", 80.0)
    End Sub

    ' --- CONTROL BUTTONS ---

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If listboxItem.Items.Count > 0 Then
            MessageBox.Show("Order Placed Successfully!" & vbCrLf & "Total Amount: ₱" & totalAmount.ToString("N2"), "Checkout")
            btnClear.PerformClick() ' Clear after successful order
        Else
            MessageBox.Show("Your cart is empty!", "Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listboxItem.Items.Clear()
        totalAmount = 0
        UpdateTotalDisplay()
    End Sub

    Private Sub btndot_Click(sender As Object, e As EventArgs) Handles btndot.Click
        ' Shows the profile view form
        view_profile.Show()
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click
        ' Example: Initialize with a name if not already set
        'lblName.Text = "Active Cashier: Admin"
    End Sub

    ' --- EMPTY HANDLERS (Optional logic) ---

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click
        ' Usually just displays the total, no action needed on click unless you want to show a breakdown
    End Sub

    Private Sub listboxItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxItem.SelectedIndexChanged
        ' You could add code here to remove a specific item if it's double-clicked
    End Sub

End Class