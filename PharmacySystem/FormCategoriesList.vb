Imports System.Data.SqlClient

Public Class FormCategoriesList
    Private Sub btnAddCat_Click(sender As Object, e As EventArgs) Handles btnAddCat.Click
        With FormCategoryEntry
            .ShowDialog()
        End With
    End Sub

    Sub loadCategories()
        Dim i As Integer = 0
        gunaGridCategories.Rows.Clear()
        conn.Open()
        cm = New SqlCommand("Select * from tblCategory", conn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            gunaGridCategories.Rows.Add(i, dr.Item("id").ToString(), dr.Item("category").ToString())
        End While
        conn.Close()
        dr.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadCategories()
    End Sub
End Class