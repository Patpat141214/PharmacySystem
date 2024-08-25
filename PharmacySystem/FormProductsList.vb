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
End Class