Public Module GlobalData
    Public CurrentUser As String = ""
    ' This table will be shared across the whole app
    Public SharedItemsTable As New DataTable()

    Sub InitializeTable()
        If SharedItemsTable.Columns.Count = 0 Then
            SharedItemsTable.Columns.Add("Item Pic", GetType(Image))
            SharedItemsTable.Columns.Add("Name", GetType(String))
            SharedItemsTable.Columns.Add("Price", GetType(Decimal))
            SharedItemsTable.Columns.Add("Stock", GetType(Integer))
        End If
    End Sub
End Module