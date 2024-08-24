Imports System.Data.SqlClient

Public Class FormTypeUpdate
    Public _origType As String
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtType.Text = _origType
        txtType.Focus()
    End Sub

    Private Sub FormTypeUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtType.Focus()
    End Sub

    Private Sub btnUpdateType_Click(sender As Object, e As EventArgs) Handles btnUpdateType.Click
        Try
            If String.IsNullOrEmpty(txtType.Text) Then
                MsgBox("Type cannot be empty. Please enter a type.", vbExclamation)
                txtType.Focus()
                Exit Sub
            End If
            If txtType.Text = _origType Then
                MsgBox("There are no changes!", vbExclamation)
                txtType.Focus()
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to update this type?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("update tblType set type = @type where typeid = @id", conn)
                cm.Parameters.AddWithValue("@type", txtType.Text)
                cm.Parameters.AddWithValue("@id", lblID.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Type successfully updated!", vbInformation)
                Me.Dispose()
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

    Private Sub FormTypeUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub FormTypeUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateType_Click(sender, e)
        End If
    End Sub
End Class