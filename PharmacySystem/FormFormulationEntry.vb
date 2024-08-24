Imports System.Data.SqlClient
Imports System.Management

Public Class FormFormulationEntry
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub FormFormulationEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtFormulation.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFormulation.Clear()
        txtFormulation.Focus()
    End Sub

    Private Sub btnSaveFormulation_Click(sender As Object, e As EventArgs) Handles btnSaveFormulation.Click

        Try
            If String.IsNullOrEmpty(txtFormulation.Text) Then
                MsgBox("Formulation cannot be empty. Please enter a formulation.", vbExclamation)
                txtFormulation.Focus()
                Exit Sub
            End If

            If (MsgBox("Are you sure want to save this formulation?", vbYesNo + vbQuestion) = vbYes) Then
                conn.Open()
                Dim cm As New SqlCommand("SELECT COUNT (*) FROM tblFormulation WHERE formulation = @form", conn)
                cm.Parameters.AddWithValue("@form", txtFormulation.Text.Trim())
                Dim count As Integer = CInt(cm.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This formulation is already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    conn.Close()
                    txtFormulation.Focus()
                    Return
                End If
                cm = New SqlCommand("insert into tblFormulation (formulation) values (@form)", conn)
                cm.Parameters.AddWithValue("@form", txtFormulation.Text)
                cm.ExecuteNonQuery()
                conn.Close()
                MsgBox("Formulation has been sucessfully saved", vbInformation)
                txtFormulation.Clear()
                txtFormulation.Focus()
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

    Private Sub FormFormulationEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub FormFormulationEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSaveFormulation_Click(sender, e)
        End If
    End Sub
End Class