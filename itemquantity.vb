Public Class itemquantity
    Public Property SelectedQuantity As Integer = 1

    Private Sub itemquantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQuantity.Text = "1"
        txtQuantity.Select()
    End Sub



    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If Integer.TryParse(txtQuantity.Text, SelectedQuantity) AndAlso SelectedQuantity > 0 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class
