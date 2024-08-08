Public Class LandingPage


    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
		With FormCategoriesList
			.TopLevel = False
			Panel2.Controls.Add(FormCategoriesList)
			.BringToFront()
			.loadCategories()
			.Show()
		End With
	End Sub

	Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles Me.Load
		MyConnection()

	End Sub
End Class
