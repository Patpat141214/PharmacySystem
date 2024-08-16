Imports System.Data.SqlClient

Public Class FormBrandList
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnAddBrand_Click(sender As Object, e As EventArgs) Handles btnAddBrand.Click
        With FormBrandEntry
            .ShowDialog()
        End With
    End Sub

    Sub loadBrands()
        Dim i As Integer = 0
        gunaGridCategories.Rows.Clear()
        conn.Open()
        cm = New SqlCommand("Select * from tblBrand order by brand ASC", conn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            gunaGridCategories.Rows.Add(i, dr.Item("brandid").ToString(), dr.Item("brand").ToString())
            gunaGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End While
        conn.Close()
        dr.Close()
    End Sub

    Private Sub FormBrandList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gunaGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadBrands()
    End Sub

    Private Sub gunaGridCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gunaGridCategories.CellContentClick
        Dim colname As String = gunaGridCategories.Columns(e.ColumnIndex).Name
        Dim _id As String = gunaGridCategories.Rows(e.RowIndex).Cells(1).Value.ToString
        Dim _cat As String = gunaGridCategories.Rows(e.RowIndex).Cells(2).Value.ToString
        If colname = "Edit" Then
            With FormUpdateBrand
                .lblID.Text = _id
                .txtBrand.Text = _cat
                ._originalBrand = _cat
                .ShowDialog()
            End With
        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this brand?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("delete from tblBrand where brandid = @id", conn)
                cm.Parameters.AddWithValue("@id", _id)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Brand successfully deleted!", vbInformation)
                loadBrands()
            End If
        End If
    End Sub
End Class