Imports System.Data.SqlClient

Public Class FormGenericEntry
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub FormGenericEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtGeneric.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGeneric.Clear()
        txtGeneric.Focus()
    End Sub

    Private Sub btnSaveGeneric_Click(sender As Object, e As EventArgs) Handles btnSaveGeneric.Click
        Try
            If String.IsNullOrEmpty(txtGeneric.Text) Then
                MsgBox("Generic cannot be empty. Please enter a generic.", vbExclamation)
                txtGeneric.Focus()
                Exit Sub
            End If

            If (MsgBox("Are you sure want to save this generic?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                Dim cm As New SqlCommand("SELECT COUNT (*) FROM tblGeneric WHERE generic = @generic", conn)
                cm.Parameters.AddWithValue("@generic", txtGeneric.Text.Trim())
                Dim count As Integer = CInt(cm.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This generic is already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    conn.Close()
                    txtGeneric.Focus()
                    Return
                End If

                cm = New SqlCommand("insert into tblGeneric (generic) values (@generic)", conn)
                cm.Parameters.AddWithValue("@generic", txtGeneric.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Generic has been sucessfully saved", vbInformation)
                txtGeneric.Clear()
                txtGeneric.Focus()
                With FormGenericList
                    .loadGenericList()
                End With
            End If
            txtGeneric.Focus()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FormGenericEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub FormGenericEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSaveGeneric_Click(sender, e)
        End If
    End Sub
End Class