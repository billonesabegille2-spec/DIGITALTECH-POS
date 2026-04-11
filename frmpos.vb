Public Class frmpos
    ' Variable to keep track of the running total
    Private totalAmount As Decimal = 0

    ' This runs as soon as the POS form opens
    Private Sub frmpos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the name saved during the Login process
        If String.IsNullOrEmpty(GlobalData.CurrentUser) Then
            lblName.Text = "Cashier: Unknown"
        Else
            lblName.Text = "Cashier: " & GlobalData.CurrentUser
        End If
    End Sub

    ' Helper method to add items and update total
    Private Sub AddToCart(itemName As String, price As Decimal)
        ' Add to the ListBox with Peso formatting
        listboxItem.Items.Add(String.Format("{0} - ₱{1:N2}", itemName, price))

        ' Add to the total variable
        totalAmount += price

        ' Update the label
        UpdateTotalDisplay()
    End Sub

    Private Sub UpdateTotalDisplay()
        lblTotal.Text = String.Format("Total: ₱{0:N2}", totalAmount)
    End Sub

    ' --- CHICKEN ITEM BUTTONS ---
    Private Sub BTNWHOLE_Click(sender As Object, e As EventArgs) Handles BTNWHOLE.Click
        AddToCart("Whole Chicken", 230.0)
    End Sub

    Private Sub btnhalf_Click(sender As Object, e As EventArgs) Handles btnhalf.Click
        AddToCart("Half Chicken", 115.0)
    End Sub

    Private Sub btnhita_Click(sender As Object, e As EventArgs) Handles btnhita.Click
        AddToCart("Hita", 56.0)
    End Sub

    Private Sub btndrumstick_Click(sender As Object, e As EventArgs) Handles btndrumstick.Click
        AddToCart("Drumstick", 27.0)
    End Sub

    Private Sub btnneck_Click(sender As Object, e As EventArgs) Handles btnneck.Click
        AddToCart("Neck", 12.0)
    End Sub

    Private Sub btnwings_Click(sender As Object, e As EventArgs) Handles btnwings.Click
        AddToCart("Wings", 23.0)
    End Sub

    Private Sub btnpitso_Click(sender As Object, e As EventArgs) Handles btnpitso.Click
        AddToCart("Pitso", 36.0)
    End Sub

    Private Sub btnthigh_Click(sender As Object, e As EventArgs) Handles btnthigh.Click
        AddToCart("Thigh", 29.0)
    End Sub

    ' --- ACTION BUTTONS ---

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If listboxItem.Items.Count > 0 Then
            Dim summary As String = "Order Placed Successfully!" & vbCrLf &
                                  "Cashier: " & GlobalData.CurrentUser & vbCrLf &
                                  "Total: ₱" & totalAmount.ToString("N2")

            MessageBox.Show(summary, "JHARED CHLOIE FOOD HUB")
            btnClear.PerformClick() ' Reset the form for the next customer
        Else
            MessageBox.Show("Cart is empty!", "Oops")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listboxItem.Items.Clear()
        totalAmount = 0
        UpdateTotalDisplay()
    End Sub

    Private Sub btndot_Click(sender As Object, e As EventArgs) Handles btndot.Click

        view_profile.Show()
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

        lblName.Text = "Cashier: " & GlobalData.CurrentUser
    End Sub

    Private Sub listboxItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listboxItem.SelectedIndexChanged

    End Sub

End Class