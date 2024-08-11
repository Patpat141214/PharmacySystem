Imports System.Data.SqlClient

Public Class FormUpdateCategory
    Public originalCategory As String
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCat.Text = originalCategory
        txtCat.Focus()
    End Sub

    Private Sub btnUpdateCat_Click(sender As Object, e As EventArgs) Handles btnUpdateCat.Click
        Try
            If String.IsNullOrEmpty(txtCat.Text) Then
                MsgBox("Category cannot be empty. Please enter a category.", vbExclamation)
                txtCat.Focus()
                Exit Sub
            End If
            If txtCat.Text = originalCategory Then
                MsgBox("There are no changes!", vbExclamation)
                txtCat.Focus()
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to update this category?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("update tblCategory set category = @cat where id = @id", conn)
                cm.Parameters.AddWithValue("@cat", txtCat.Text)
                cm.Parameters.AddWithValue("@id", lblID.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Category successfully updated!", vbInformation)
                Me.Dispose()
                With FormCategoriesList
                    .loadCategories()
                End With
            End If

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FormUpdateCategory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtCat.Focus()
    End Sub
End Class