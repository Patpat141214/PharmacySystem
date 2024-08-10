Public Class FormUpdateCategory
    Public originalCategory As String
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub FormUpdateCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCat.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCat.Text = originalCategory
        txtCat.Focus()
    End Sub
End Class