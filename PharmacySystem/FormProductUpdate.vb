Imports System.Data.SqlClient

Public Class FormProductUpdate
    Public brand As String
    Public classicfication As String
    Public type As String
    Public formulation As String
    Public generic As String
    Public id As String
    Public barcode As String
    Public reorder As String
    Public price As String
    Public qty As String

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub FormProductUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtBarcode.Focus()
    End Sub

    Private Sub btnRevert_Click(sender As Object, e As EventArgs) Handles btnRevert.Click
        txtBarcode.Text = barcode
        txtBrand.Text = brand
        txtType.Text = type
        txtFormulation.Text = formulation
        txtClassification.Text = classicfication
        txtGeneric.Text = generic
        txtReorder.Text = reorder
        txtQty.Text = qty
        txtPrice.Text = price
        txtBarcode.Focus()
    End Sub

    Private Sub txtBrand_TextChanged(sender As Object, e As EventArgs) Handles txtBrand.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblBrand where brand like @brand", conn)
        cm.Parameters.AddWithValue("@brand", txtBrand.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDBrand.Text = dr.Item(0).ToString Else lblIDBrand.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtClassification_TextChanged(sender As Object, e As EventArgs) Handles txtClassification.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblClassification where classification like @class", conn)
        cm.Parameters.AddWithValue("@class", txtClassification.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDClass.Text = dr.Item(0).ToString Else lblIDClass.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtFormulation_TextChanged(sender As Object, e As EventArgs) Handles txtFormulation.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblFormulation where formulation like @form", conn)
        cm.Parameters.AddWithValue("@form", txtFormulation.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDForm.Text = dr.Item(0).ToString Else lblIDForm.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtGeneric_TextChanged(sender As Object, e As EventArgs) Handles txtGeneric.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblGeneric where generic like @generic", conn)
        cm.Parameters.AddWithValue("@generic", txtGeneric.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDGeneric.Text = dr.Item(0).ToString Else lblIDGeneric.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        conn.Open()
        cm = New SqlCommand("select * from tblType where type like @type", conn)
        cm.Parameters.AddWithValue("@type", txtType.Text)
        dr = cm.ExecuteReader()
        dr.Read()
        If dr.HasRows Then lblIDType.Text = dr.Item(0).ToString Else lblIDType.Text = String.Empty
        cm = Nothing
        conn.Close()
        dr.Close()
    End Sub
End Class