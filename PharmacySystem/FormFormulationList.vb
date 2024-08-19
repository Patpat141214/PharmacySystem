Imports System.Data.SqlClient
Public Class FormFormulationList
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Sub loadFormulationList()
        Dim i As Integer = 0
        gunaGridCategories.Rows.Clear()
        conn.Open()
        cm = New SqlCommand("Select * from tblFormulation order by formulation ASC", conn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            gunaGridCategories.Rows.Add(i, dr.Item("formid").ToString(), dr.Item("formulation").ToString())
            gunaGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End While
        conn.Close()
        dr.Close()
    End Sub

    Private Sub FormFormulationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gunaGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadFormulationList()
    End Sub

    Private Sub gunaGridCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gunaGridCategories.CellContentClick
        Dim colname As String = gunaGridCategories.Columns(e.ColumnIndex).Name
        Dim _id As String = gunaGridCategories.Rows(e.RowIndex).Cells(1).Value.ToString
        Dim _cat As String = gunaGridCategories.Rows(e.RowIndex).Cells(2).Value.ToString
        If colname = "Edit" Then
            With FormFormulationUpdate
                .lblID.Text = _id
                .txtFormulation.Text = _cat
                ._origFormulation = _cat
                .ShowDialog()
            End With
        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this formulation?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("delete from tblFormulation where formid = @id", conn)
                cm.Parameters.AddWithValue("@id", _id)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Formulation successfully deleted!", vbInformation)
                loadFormulationList()
            End If
        End If
    End Sub

    Private Sub btnAddFormulation_Click(sender As Object, e As EventArgs) Handles btnAddFormulation.Click
        With FormFormulationEntry
            .ShowDialog()
        End With
    End Sub
End Class