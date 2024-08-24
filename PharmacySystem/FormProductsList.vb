Public Class FormProductsList
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        With FormProductEntry
            .ShowDialog()
        End With
    End Sub
End Class