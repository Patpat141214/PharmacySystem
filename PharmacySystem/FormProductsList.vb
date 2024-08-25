Imports System.Data.SqlClient

Public Class FormProductsList
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        With FormProductEntry
            .ShowDialog()
        End With
    End Sub

    Private Sub FormProductsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gunaGridProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub

    Sub loadProducts()
        Try
            gunaGridProducts.Rows.Clear()
            Dim i As Integer = 0
            conn.Open()
            cm = New SqlCommand("select * from tblProduct as p inner join tblBrand as b on p.bid = b.brandid inner join tblClassification as c on p.cid = c.classid inner join tblFormulation as f on p.fid = f.formid inner join tblGeneric as g on p.gid = g.genericid inner join tblType as t on p.tid = t.typeid", conn)
            dr = cm.ExecuteReader
            While dr.Read()
                i = +1
                gunaGridProducts.Rows.Add(i, dr.Item("id"), dr.Item("barcode"), dr.Item("brand"), dr.Item("generic"), dr.Item("classification"), dr.Item("type"), dr.Item("formulation"), dr.Item("reorder"), dr.Item("qty"), dr.Item("price"))
                gunaGridProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            End While
            conn.Close()
            dr.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadProducts()
    End Sub

    Private Sub gunaGridProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gunaGridProducts.CellContentClick
        Dim colname As String = gunaGridProducts.Columns(e.ColumnIndex).Name
        Dim _id As String = gunaGridProducts.Rows(e.RowIndex).Cells(1).Value.ToString
        Dim _bar As String = gunaGridProducts.Rows(e.RowIndex).Cells(2).Value.ToString
        Dim _brand As String = gunaGridProducts.Rows(e.RowIndex).Cells(3).Value.ToString
        Dim _generic As String = gunaGridProducts.Rows(e.RowIndex).Cells(4).Value.ToString
        Dim _class As String = gunaGridProducts.Rows(e.RowIndex).Cells(5).Value.ToString
        Dim _type As String = gunaGridProducts.Rows(e.RowIndex).Cells(6).Value.ToString
        Dim _form As String = gunaGridProducts.Rows(e.RowIndex).Cells(7).Value.ToString
        Dim _reorder As String = gunaGridProducts.Rows(e.RowIndex).Cells(8).Value.ToString
        Dim _qty As String = gunaGridProducts.Rows(e.RowIndex).Cells(9).Value.ToString
        Dim _price As String = gunaGridProducts.Rows(e.RowIndex).Cells(10).Value.ToString
        If colname = "Edit" Then
            With FormProductUpdate
                .txtBarcode.Text = _bar
                .txtBrand.Text = _brand
                .txtGeneric.Text = _generic
                .txtClassification.Text = _class
                .txtType.Text = _type
                .txtFormulation.Text = _form
                .txtReorder.Text = _reorder
                .txtQty.Text = _qty
                .txtPrice.Text = _price
                .barcode = _bar
                .brand = _brand
                .generic = _generic
                .formulation = _form
                .type = _type
                .classicfication = _class
                .id = _id
                .reorder = _reorder
                .qty = _qty
                .price = _price
                .ShowDialog()
            End With
        ElseIf colname = "Delete" Then
            If (MsgBox("Are you sure you want to delete this product?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("delete from tblProduct where id = @id", conn)
                cm.Parameters.AddWithValue("@id", _id)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Product successfully deleted!", vbInformation)
                loadProducts()
            End If
        End If
    End Sub
End Class