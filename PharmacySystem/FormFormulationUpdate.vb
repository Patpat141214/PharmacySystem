Imports System.Data.SqlClient

Public Class FormFormulationUpdate
    Public _origFormulation As String
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub FormFormulationUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtFormulation.Focus()
    End Sub

    Private Sub btnRevert_Click(sender As Object, e As EventArgs) Handles btnRevert.Click
        txtFormulation.Text = _origFormulation
        txtFormulation.Focus()
    End Sub

    Private Sub btnUpdateFormulation_Click(sender As Object, e As EventArgs) Handles btnUpdateFormulation.Click
        Try
            If String.IsNullOrEmpty(txtFormulation.Text) Then
                MsgBox("Formulation cannot be empty. Please enter a Formulation.", vbExclamation)
                txtFormulation.Focus()
                Exit Sub
            End If
            If txtFormulation.Text = _origFormulation Then
                MsgBox("There are no changes!", vbExclamation)
                txtFormulation.Focus()
                Exit Sub
            End If
            If (MsgBox("Are you sure you want to update this formulation?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                cm = New SqlCommand("update tblFormulation set formulation = @form where formid = @id", conn)
                cm.Parameters.AddWithValue("@form", txtFormulation.Text)
                cm.Parameters.AddWithValue("@id", lblID.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Formulation successfully updated!", vbInformation)
                Me.Dispose()
                With FormFormulationList
                    .loadFormulationList()
                End With
            End If
            txtFormulation.Focus()

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FormFormulationUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub FormFormulationUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateFormulation_Click(sender, e)
        End If
    End Sub
End Class