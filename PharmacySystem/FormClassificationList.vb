Imports System.Data.SqlClient

Public Class FormClassificationList
    Private Sub btnAddCat_Click(sender As Object, e As EventArgs) Handles btnAddCat.Click
        With FormClassificationEntry
            .ShowDialog()
        End With
    End Sub

    Sub loadCategories()
        Dim i As Integer = 0
        gunaGridCategories.Rows.Clear()
        conn.Open()
        cm = New SqlCommand("Select * from tblClassification order by classification ASC", conn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            gunaGridCategories.Rows.Add(i, dr.Item("classid").ToString(), dr.Item("classification").ToString())
            gunaGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End While
        conn.Close()
        dr.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadCategories()
    End Sub

    Private Sub gunaGridCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gunaGridCategories.CellContentClick
        Dim colname As String = gunaGridCategories.Columns(e.ColumnIndex).Name
        Dim _id As String = gunaGridCategories.Rows(e.RowIndex).Cells(1).Value.ToString
        Dim _cat As String = gunaGridCategories.Rows(e.RowIndex).Cells(2).Value.ToString
        If colname = "Edit" Then
            With FormUpdateClassification
                .lblID.Text = _id
                .txtCat.Text = _cat
                .originalCategory = _cat
                .ShowDialog()
            End With
        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this classification?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("delete from tblClassification where classid = @id", conn)
                cm.Parameters.AddWithValue("@id", _id)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("classification successfully deleted!", vbInformation)
                loadCategories()
            End If
        End If
    End Sub

    Private Sub FormCategoriesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gunaGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub
End Class