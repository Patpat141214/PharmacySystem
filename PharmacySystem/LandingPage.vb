Public Class LandingPage


    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
		With FormCategoriesList
			.TopLevel = False
			Panel2.Controls.Add(FormCategoriesList)
			.Show()
		End With
	End Sub
End Class
