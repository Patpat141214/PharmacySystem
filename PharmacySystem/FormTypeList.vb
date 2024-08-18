Imports System.Data.SqlClient

Public Class FormTypeList
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub FormTypeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gunaGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        With FormTypeEntry
            .ShowDialog()
        End With
    End Sub

    Sub loadTypeList()
        Dim i As Integer = 0
        gunaGridCategories.Rows.Clear()
        conn.Open()
        cm = New SqlCommand("Select * from tblType order by type ASC", conn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            gunaGridCategories.Rows.Add(i, dr.Item("typeid").ToString(), dr.Item("type").ToString())
            gunaGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End While
        conn.Close()
        dr.Close()
    End Sub

    Private Sub gunaGridCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gunaGridCategories.CellContentClick
        Dim colname As String = gunaGridCategories.Columns(e.ColumnIndex).Name
        Dim _id As String = gunaGridCategories.Rows(e.RowIndex).Cells(1).Value.ToString
        Dim _cat As String = gunaGridCategories.Rows(e.RowIndex).Cells(2).Value.ToString
        If colname = "Edit" Then
            With FormTypeUpdate
                .lblID.Text = _id
                .txtType.Text = _cat
                ._origType = _cat
                .ShowDialog()
            End With
        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this type?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("delete from tblType where typeid = @id", conn)
                cm.Parameters.AddWithValue("@id", _id)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Type successfully deleted!", vbInformation)
                loadTypeList()
            End If
        End If
    End Sub
End Class