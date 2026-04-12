Imports System.IO
Imports System.Windows.Forms

Public Class admin_menu
    ' Points to the database helper
    Private db As New DatabaseHelper("foodhub.db")

    Private Sub admin_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load items from the database into the DataGridView immediately
        RefreshDataGrid()
    End Sub

    ' --- HELPER: REFRESH GRID FROM DB ---
    Private Sub RefreshDataGrid()
        DataGridView1.DataSource = db.GetAllProducts()
    End Sub

    ' --- IMAGE SELECTION ---
    Private Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        Dim openFD As New OpenFileDialog()
        openFD.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*jfif"

        If openFD.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFD.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    ' --- ADD ITEM ---
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' 1. DECLARE variables at the top so they are visible everywhere in this Sub
        Dim itemName As String = TextBox1.Text.Trim()
        Dim itemPrice As Decimal = 0
        Dim itemStock As Integer = 0

        ' 2. VALIDATION
        If itemName = "" Or TextBox2.Text.Trim() = "" Or TextBox3.Text.Trim() = "" Then
            MessageBox.Show("All fields (Name, Price, Stock) are required!", "Input Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please select an item image first.", "Image Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 3. PROCESSING
        Try
            ' Validate numeric formats
            If Not Decimal.TryParse(TextBox2.Text, itemPrice) Then
                MessageBox.Show("Invalid Price!", "Format Error")
                TextBox2.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(TextBox3.Text, itemStock) Then
                MessageBox.Show("Invalid Stock!", "Format Error")
                TextBox3.Focus()
                Exit Sub
            End If

            ' --- SAVE TO DATABASE ---
            Dim ms As New MemoryStream()
            ' Save as PNG to the memory stream to convert to bytes
            PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

            ' Call your helper
            db.AddProduct(itemName, itemPrice, itemStock, ms.ToArray())

            MessageBox.Show("Product added and saved to Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh the grid and clear fields
            RefreshDataGrid()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error")
        End Try
    End Sub

    ' --- DELETE ITEM ---
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Get the ItemID from the first column of the selected row
                Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("ItemID").Value)

                ' Delete from Database
                db.DeleteProduct(id)

                ' Refresh display
                RefreshDataGrid()
            End If
        Else
            MessageBox.Show("Please select a full row in the list to delete.", "Selection Required")
        End If
    End Sub

    ' --- HELPER SUBS ---
    Private Sub ClearFields()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        PictureBox1.Image = Nothing
    End Sub

    ' --- NAVIGATION & SYSTEM ---
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close() ' Closes Admin and goes back to Login
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
    End Sub

    ' Other placeholders...
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' We save automatically in AddItem now, but you can use this for "Update" later
        MessageBox.Show("Use 'Add Item' to save new products.", "Info")
    End Sub
End Class