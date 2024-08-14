Imports System.Data.SqlClient
Public Class FormBrandEntry
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBrand.Clear()
        txtBrand.Focus()
    End Sub

    Private Sub FormBrandEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtBrand.Focus()
    End Sub

    Private Sub btnSaveBrand_Click(sender As Object, e As EventArgs) Handles btnSaveBrand.Click
        Try
            If String.IsNullOrEmpty(txtBrand.Text) Then
                MsgBox("Brand cannot be empty. Please enter a brand.", vbExclamation)
                txtBrand.Focus()
                Exit Sub
            End If

            If (MsgBox("Are you sure want to save this brand?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                Dim cm As New SqlCommand("SELECT COUNT (*) FROM tblBrand WHERE brand = @brand", conn)
                cm.Parameters.AddWithValue("@brand", txtBrand.Text.Trim())
                Dim count As Integer = CInt(cm.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This brand is already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    conn.Close()
                    txtBrand.Focus()
                    Return
                End If

                cm = New SqlCommand("insert into tblBrand (brand) values (@brand)", conn)
                cm.Parameters.AddWithValue("@brand", txtBrand.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Brand has been sucessfully saved", vbInformation)
                txtBrand.Clear()
                txtBrand.Focus()
                With FormBrandList
                    .loadBrands()
                End With
            End If
            txtBrand.Focus()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Class