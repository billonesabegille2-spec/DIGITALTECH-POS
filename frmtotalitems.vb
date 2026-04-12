Public Class Total_Items
    ' This variable will hold the amount sent from frmpos
    Public receivedTotal As Decimal = 0

    Private Sub Total_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the total received from the POS form
        ' Assuming lblPayment is the one showing "0.00" in your image
        lblPayment.Text = receivedTotal.ToString("N2")
        txtDisplay.Text = ""
    End Sub

    ' --- NUMBER PAD LOGIC ---
    Private Sub AddNumber(num As String)
        txtDisplay.Text &= num
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click,
        btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btn00.Click

        ' Dynamic way to handle all buttons at once
        Dim btn = DirectCast(sender, Button)
        AddNumber(btn.Text)
    End Sub

    ' --- ACTION BUTTONS ---

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        txtDisplay.Clear() ' Clears the whole input
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim cashInput As Decimal = 0

        If Decimal.TryParse(txtDisplay.Text, cashInput) Then
            If cashInput >= receivedTotal Then
                Dim change As Decimal = cashInput - receivedTotal

                MessageBox.Show("Transaction Successful!" & vbCrLf &
                                "Total: ₱" & receivedTotal.ToString("N2") & vbCrLf &
                                "Cash: ₱" & cashInput.ToString("N2") & vbCrLf &
                                "Change: ₱" & change.ToString("N2"), "JHARED CHLOIE FOOD HUB")

                Me.Close() ' Close payment form and return to POS
            Else
                MessageBox.Show("Insufficient Cash!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please enter cash amount.", "Input Error")
        End If
    End Sub
End Class