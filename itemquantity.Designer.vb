Public Class itemquantity

    ' Public property so your main POS form can read the value after this form closes
    Public Property SelectedQuantity As Integer = 1

    ' Form Load: Initialize the textbox
    Private Sub itemquantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQuantity.Text = "1"
        txtQuantity.Select() ' Focus on textbox for easy typing
    End Sub

    ' --- PLUS & MINUS LOGIC ---

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim currentVal As Integer = 0
        Integer.TryParse(txtQuantity.Text, currentVal)
        txtQuantity.Text = (currentVal + 1).ToString()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim currentVal As Integer = 0
        Integer.TryParse(txtQuantity.Text, currentVal)

        ' Ensure quantity doesn't drop below 1
        If currentVal > 1 Then
            txtQuantity.Text = (currentVal - 1).ToString()
        End If
    End Sub

    ' --- PRESET BUTTON LOGIC ---

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtQuantity.Text = "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtQuantity.Text = "3"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtQuantity.Text = "5"
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        txtQuantity.Text = "10"
    End Sub

    ' --- FINALIZATION ---

    ' Logic for the "Enter Quantity" button
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If Integer.TryParse(txtQuantity.Text, SelectedQuantity) AndAlso SelectedQuantity > 0 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please enter a valid number greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
        End If
    End Sub

    ' Restrict textbox to numbers only (prevents accidental typing of letters)
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents txtInput As TextBox
End Class