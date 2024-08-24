Imports System.Data.SqlClient

Public Class FormGenericUpdate
    Public _origGeneric As String
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnRevert_Click(sender As Object, e As EventArgs) Handles btnRevert.Click
        txtGeneric.Text = _origGeneric
        txtGeneric.Focus()
    End Sub

    Private Sub btnUpdateGeneric_Click(sender As Object, e As EventArgs) Handles btnUpdateGeneric.Click
        Try
            If String.IsNullOrEmpty(txtGeneric.Text) Then
                MsgBox("Generic cannot be empty. Please enter a Generic.", vbExclamation)
                txtGeneric.Focus()
                Exit Sub
            End If
            If txtGeneric.Text = _origGeneric Then
                MsgBox("There are no changes!", vbExclamation)
                txtGeneric.Focus()
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to update this generic?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("update tblGeneric set generic = @generic where genericid = @id", conn)
                cm.Parameters.AddWithValue("@generic", txtGeneric.Text)
                cm.Parameters.AddWithValue("@id", lblID.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Generic successfully updated!", vbInformation)
                Me.Dispose()
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

    Private Sub FormGenericUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtGeneric.Focus()
    End Sub

    Private Sub FormGenericUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub FormGenericUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateGeneric_Click(sender, e)
        End If
    End Sub
End Class