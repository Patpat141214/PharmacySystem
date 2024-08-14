Imports System.Data.SqlClient

Public Class FormUpdateBrand
    Public _originalBrand As String
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBrand.Text = _originalBrand
        txtBrand.Focus()
    End Sub

    Private Sub btnUpdateBrand_Click(sender As Object, e As EventArgs) Handles btnUpdateBrand.Click
        Try
            If String.IsNullOrEmpty(txtBrand.Text) Then
                MsgBox("Brand cannot be empty. Please enter a Brand.", vbExclamation)
                txtBrand.Focus()
                Exit Sub
            End If
            If txtBrand.Text = _originalBrand Then
                MsgBox("There are no changes!", vbExclamation)
                txtBrand.Focus()
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to update this Brand?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("update tblBrand set brand = @brand where brandid = @id", conn)
                cm.Parameters.AddWithValue("@brand", txtBrand.Text)
                cm.Parameters.AddWithValue("@id", lblID.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Brand successfully updated!", vbInformation)
                Me.Dispose()
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

    Private Sub FormUpdateBrand_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtBrand.Focus()
    End Sub
End Class