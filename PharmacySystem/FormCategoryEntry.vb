Public Class FormCategoryEntry

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCat.Text = ""
        txtCat.Focus()
    End Sub

    Private Sub FormCategoryEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtCat.Focus()
    End Sub
End Class