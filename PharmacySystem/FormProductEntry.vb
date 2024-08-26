Imports System.Data.SqlClient
Public Class FormProductEntry
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()

    End Sub

    Sub ClearAll()
        txtBarcode.Clear()
        txtBrand.Text = Nothing
        txtReorder.Clear()
        txtQty.Clear()
        txtFormulation.Text = Nothing
        txtType.Text = Nothing
        txtGeneric.Text = Nothing
        txtClassification.Text = Nothing
        txtPrice.Clear()
        txtBarcode.Focus()
    End Sub
    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
        Try

            If String.IsNullOrWhiteSpace(txtBarcode.Text) Or String.IsNullOrWhiteSpace(txtBrand.Text) Or String.IsNullOrWhiteSpace(txtClassification.Text) Or String.IsNullOrWhiteSpace(txtType.Text) Or
                String.IsNullOrWhiteSpace(txtFormulation.Text) Or String.IsNullOrWhiteSpace(txtGeneric.Text) Or String.IsNullOrWhiteSpace(txtReorder.Text) Or String.IsNullOrWhiteSpace(txtPrice.Text) Or
               String.IsNullOrWhiteSpace(txtQty.Text) Then
                MsgBox("Required Empty Field!", vbExclamation)
                txtBarcode.Focus()
                Return
            End If

            If (MsgBox("Do you want to save this product?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                Dim cm As New SqlCommand("SELECT COUNT (*) FROM tblProduct WHERE barcode = @bar", conn)
                cm.Parameters.AddWithValue("@bar", txtBarcode.Text.Trim())
                Dim count As Integer = CInt(cm.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Duplication Entry!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    conn.Close()
                    txtBrand.Focus()
                    Return
                End If
                cm = New SqlCommand("insert into tblProduct(barcode, bid, gid, cid, tid, fid, reorder, qty, price)values(@barcode, @bid, @gid, @cid, @tid, @fid, @reorder, @qty, @price)", conn)
                cm.Parameters.AddWithValue("@barcode", txtBarcode.Text)
                cm.Parameters.AddWithValue("@bid", CInt(lblIDBrand.Text))
                cm.Parameters.AddWithValue("@gid", CInt(lblIDGeneric.Text))
                cm.Parameters.AddWithValue("@cid", CInt(lblIDClass.Text))
                cm.Parameters.AddWithValue("@tid", CInt(lblIDType.Text))
                cm.Parameters.AddWithValue("@fid", CInt(lblIDForm.Text))
                cm.Parameters.AddWithValue("@reorder", CInt(txtReorder.Text))
                cm.Parameters.AddWithValue("@qty", CInt(txtQty.Text))
                cm.Parameters.AddWithValue("@price", CDec(txtPrice.Text))
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Product Successfully Saved!", vbInformation)
                ClearAll()
                With FormProductsList
                    .loadProducts()
                End With
            End If
            txtBarcode.Focus()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub loadBrand()
        txtBrand.Items.Clear()
        conn.Open()
        cm = New SqlCommand("select * from tblBrand order by brand ASC", conn)
        dr = cm.ExecuteReader()
        While (dr.Read())
            txtBrand.Items.Add(dr("brand").ToString())
        End While
        dr.Close()
        conn.Close()
    End Sub
    Sub loadGeneric()
        txtGeneric.Items.Clear()
        conn.Open()
        cm = New SqlCommand("select * from tblGeneric order by generic ASC", conn)
        dr = cm.ExecuteReader()
        While (dr.Read())
            txtGeneric.Items.Add(dr("generic").ToString())
        End While
        dr.Close()
        conn.Close()
    End Sub

    Sub loadClassification()
        txtClassification.Items.Clear()
        conn.Open()
        cm = New SqlCommand("select * from tblClassification order by classification ASC", conn)
        dr = cm.ExecuteReader()
        While (dr.Read())
            txtClassification.Items.Add(dr("classification").ToString())
        End While
        dr.Close()
        conn.Close()
    End Sub

    Sub loadType()
        txtType.Items.Clear()
        conn.Open()
        cm = New SqlCommand("select * from tblType order by type ASC", conn)
        dr = cm.ExecuteReader()
        While (dr.Read())
            txtType.Items.Add(dr("type").ToString())
        End While
        dr.Close()
        conn.Close()
    End Sub

    Sub loadFormulation()
        txtFormulation.Items.Clear()
        conn.Open()
        cm = New SqlCommand("select * from tblFormulation order by formulation ASC", conn)
        dr = cm.ExecuteReader()
        While (dr.Read())
            txtFormulation.Items.Add(dr("formulation").ToString())
        End While
        dr.Close()
        conn.Close()
    End Sub

    Private Sub FormProductEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBrand()
        loadGeneric()
        loadClassification()
        loadType()
        loadFormulation()
    End Sub

    Private Sub FormProductEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtBarcode.Focus()
    End Sub

    Private Sub txtBrand_TextChanged(sender As Object, e As EventArgs) Handles txtBrand.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblBrand where brand like @brand", conn)
        cm.Parameters.AddWithValue("@brand", txtBrand.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDBrand.Text = dr.Item(0).ToString Else lblIDBrand.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtGeneric_TextChanged(sender As Object, e As EventArgs) Handles txtGeneric.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblGeneric where generic like @generic", conn)
        cm.Parameters.AddWithValue("@generic", txtGeneric.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDGeneric.Text = dr.Item(0).ToString Else lblIDGeneric.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtClassification_TextChanged(sender As Object, e As EventArgs) Handles txtClassification.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblClassification where classification like @class", conn)
        cm.Parameters.AddWithValue("@class", txtClassification.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDClass.Text = dr.Item(0).ToString Else lblIDClass.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblType where type like @type", conn)
        cm.Parameters.AddWithValue("@type", txtType.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDType.Text = dr.Item(0).ToString Else lblIDType.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtFormulation_TextChanged(sender As Object, e As EventArgs) Handles txtFormulation.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblFormulation where formulation like @form", conn)
        cm.Parameters.AddWithValue("@form", txtFormulation.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDForm.Text = dr.Item(0).ToString Else lblIDForm.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtReorder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReorder.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBrand.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtClassification_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClassification.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtFormulation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFormulation.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtGeneric_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGeneric.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtType.KeyPress
        e.Handled = True
    End Sub
End Class