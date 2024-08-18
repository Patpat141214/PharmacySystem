Imports System.Data.SqlClient

Public Class FormTypeEntry
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtType.Clear()
        txtType.Focus()
    End Sub

    Private Sub FormTypeEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtType.Focus()
    End Sub

    Private Sub btnSaveType_Click(sender As Object, e As EventArgs) Handles btnSaveType.Click

        Try
            If String.IsNullOrEmpty(txtType.Text) Then
                MsgBox("Type cannot be empty. Please enter a type.", vbExclamation)
                txtType.Focus()
                Exit Sub
            End If

            If (MsgBox("Are you sure want to save this type?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                Dim cm As New SqlCommand("SELECT COUNT (*) FROM tblType WHERE type = @type", conn)
                cm.Parameters.AddWithValue("@type", txtType.Text.Trim())
                Dim count As Integer = CInt(cm.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This type is already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    conn.Close()
                    txtType.Focus()
                    Return
                End If
                cm = New SqlCommand("insert into tblType (type) values (@type)", conn)
                cm.Parameters.AddWithValue("@type", txtType.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Type has been sucessfully saved", vbInformation)
                txtType.Clear()
                txtType.Focus()
                With FormTypeList
                    .loadTypeList()
                End With
            End If
            txtType.Focus()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class