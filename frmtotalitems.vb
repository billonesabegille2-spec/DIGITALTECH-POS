Public Class Total_Items
    ' This variable will hold the amount sent from frmpos
    Public receivedTotal As Decimal = 0

    Private Sub Total_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update the label that shows the amount the customer needs to pay
        ' Formatting with ₱ and 2 decimal places
        lblPayment.Text = String.Format("₱{0:N2}", receivedTotal)

        ' If you want lblTotal to also show the amount, update it here:
        ' lblTotal.Text = "Total Due: ₱" & receivedTotal.ToString("N2")

        txtDisplay.Text = ""
    End Sub

    ' --- NUMBER PAD LOGIC ---
    Private Sub AddNumber(num As String)
        txtDisplay.Text &= num
    End Sub

    ' Simplified: One Sub handles all number buttons
    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click,
        btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btn00.Click

        Dim btn = DirectCast(sender, Button)
        AddNumber(btn.Text)
    End Sub

    ' Added Logic for the Dot button if you have one
    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Not txtDisplay.Text.Contains(".") Then
            If txtDisplay.Text = "" Then txtDisplay.Text = "0"
            AddNumber(".")
        End If
    End Sub

    ' --- ACTION BUTTONS ---

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Logic to remove the last character (Backspace) instead of clearing all
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim cashInput As Decimal = 0

        ' Try to parse the input from the textbox
        If Decimal.TryParse(txtDisplay.Text, cashInput) Then
            If cashInput >= receivedTotal Then
                Dim change As Decimal = cashInput - receivedTotal

                MessageBox.Show("Transaction Successful!" & vbCrLf &
                                "Total: ₱" & receivedTotal.ToString("N2") & vbCrLf &
                                "Cash: ₱" & cashInput.ToString("N2") & vbCrLf &
                                "Change: ₱" & change.ToString("N2"), "JHARED CHLOIE FOOD HUB")

                Me.DialogResult = DialogResult.OK ' Tells frmpos the payment was successful
                Me.Close()
            Else
                MessageBox.Show("Insufficient Cash! Customer still owes ₱" & (receivedTotal - cashInput).ToString("N2"),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please enter a valid cash amount.", "Input Error")
        End If
    End Sub

End Class