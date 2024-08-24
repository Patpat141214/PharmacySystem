Imports System.Data.SqlClient

Public Class FormClassificationEntry

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
                MsgBox("Classification cannot be empty. Please enter a Classification.", vbExclamation)
                txtCat.Focus()
                Exit Sub
            End If

            If (MsgBox("Are you sure want to save this classification?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                Dim cm As New SqlCommand("SELECT COUNT (*) FROM tblClassification WHERE classification = @cat", conn)
                cm.Parameters.AddWithValue("@cat", txtCat.Text.Trim())
                Dim count As Integer = CInt(cm.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This classification is already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    conn.Close()
                    txtCat.Focus()
                    Return
                End If

                cm = New SqlCommand("insert into tblClassification (classification) values (@category)", conn)
                cm.Parameters.AddWithValue("@category", txtCat.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("classification has been sucessfully saved", vbInformation)
                txtCat.Clear()
                txtCat.Focus()
                With FormClassificationList
                    .loadCategories()
                End With
            End If
            txtCat.Focus()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FormClassificationEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub FormClassificationEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSaveCat_Click(sender, e)
        End If
    End Sub
End Class