Public Class FormMaintenance
    Private Sub MetroTabControl1_Click(sender As Object, e As EventArgs) Handles MetroTabControl1.Click
        If MetroTabControl1.SelectedIndex = 3 Then
            With FormClassificationList
                .TopLevel = False
                Panel5.Controls.Add(FormClassificationList)
                .loadCategories()
                .BringToFront()
                .Show()
            End With
        End If
    End Sub
End Class