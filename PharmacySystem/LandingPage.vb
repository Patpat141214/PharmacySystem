Public Class LandingPage


    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
		With FormMaintenance
			.TopLevel = False
			Panel2.Controls.Add(FormMaintenance)
			.BringToFront()
			.MetroTabControl1.SelectedIndex = 0
			.Show()
		End With
	End Sub

	Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles Me.Load
		MyConnection()

	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		Application.Exit()
	End Sub
End Class
