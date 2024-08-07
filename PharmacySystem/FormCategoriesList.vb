Public Class FormCategoriesList
    Private Sub btnAddCat_Click(sender As Object, e As EventArgs) Handles btnAddCat.Click
        With FormCategoryEntry
            .ShowDialog()
        End With
    End Sub
End Class