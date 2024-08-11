Imports System.Data.SqlClient

Public Class FormCategoryEntry

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCat.Clear()
        txtCat.Focus()
    End Sub

    Private Sub FormCategoryEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtCat.Focus()
    End Sub

    Private Sub btnSaveCat_Click(sender As Object, e As EventArgs) Handles btnSaveCat.Click
        Try
            If String.IsNullOrEmpty(txtCat.Text) Then
                MsgBox("Category cannot be empty. Please enter a category.", vbExclamation)
                txtCat.Focus()
                Exit Sub
            End If

            If (MsgBox("Are you sure want to save this category?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                Dim cm As New SqlCommand("SELECT COUNT (*) FROM tblCategory WHERE category = @cat", conn)
                cm.Parameters.AddWithValue("@cat", txtCat.Text.Trim())
                Dim count As Integer = CInt(cm.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This Category is already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    conn.Close()
                    txtCat.Focus()
                    Return
                End If

                cm = New SqlCommand("insert into tblCategory (category) values (@category)", conn)
                cm.Parameters.AddWithValue("@category", txtCat.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Record has been sucessfully saved", vbInformation)
                txtCat.Clear()
                txtCat.Focus()
                With FormCategoriesList
                    .loadCategories()
                End With
            End If
            txtCat.Focus()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Class