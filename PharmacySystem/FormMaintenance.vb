﻿Public Class FormMaintenance
    Private Sub MetroTabControl1_Click(sender As Object, e As EventArgs) Handles MetroTabControl1.Click
        If MetroTabControl1.SelectedIndex = 3 Then
            With FormClassificationList
                .TopLevel = False
                Panel5.Controls.Add(FormClassificationList)
                .loadCategories()
                .BringToFront()
                .Show()
            End With

        ElseIf MetroTabControl1.SelectedIndex = 0 Then
            With FormBrandList
                .TopLevel = False
                Panel2.Controls.Add(FormBrandList)
                .loadBrands()
                .BringToFront()
                .Show()
            End With
        ElseIf MetroTabControl1.SelectedIndex = 1 Then
            With FormGenericList
                .TopLevel = False
                Panel3.Controls.Add(FormGenericList)
                .loadGenericList()
                .BringToFront()
                .Show()
            End With
        ElseIf MetroTabControl1.SelectedIndex = 4 Then
            With FormTypeList
                .TopLevel = False
                Panel6.Controls.Add(FormTypeList)
                .loadTypeList()
                .BringToFront()
                .Show()
            End With
        ElseIf MetroTabControl1.SelectedIndex = 2 Then
            With FormFormulationList
                .TopLevel = False
                Panel4.Controls.Add(FormFormulationList)
                .BringToFront()
                .loadFormulationList()
                .Show()
            End With

        End If
    End Sub

    Private Sub FormMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedIndex = 0
        With FormBrandList
            .TopLevel = False
            Panel2.Controls.Add(FormBrandList)
            .loadBrands()
            .BringToFront()
            .Show()
        End With
    End Sub
End Class