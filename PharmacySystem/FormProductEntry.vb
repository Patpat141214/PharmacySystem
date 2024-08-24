Imports System.Data.SqlClient
Public Class FormProductEntry
    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click

    End Sub

    Sub loadBrand()
        conn.Open()
        cm = New SqlCommand("select * from tblBrand order by brand ASC", conn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cm)
        da.Fill(ds, "brand")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("brand").ToString)
        Next
        txtBrand.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBrand.AutoCompleteCustomSource = col
        txtBrand.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        conn.Close()
    End Sub
    Sub loadGeneric()
        conn.Open()
        cm = New SqlCommand("select * from tblGeneric order by generic ASC", conn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cm)
        da.Fill(ds, "generic")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("generic").ToString)
        Next
        txtGeneric.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtGeneric.AutoCompleteCustomSource = col
        txtGeneric.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        conn.Close()
    End Sub

    Sub loadClassification()
        conn.Open()
        cm = New SqlCommand("select * from tblClassification order by classification ASC", conn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cm)
        da.Fill(ds, "classification")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("classification").ToString)
        Next
        txtClassification.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtClassification.AutoCompleteCustomSource = col
        txtClassification.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        conn.Close()
    End Sub

    Sub loadType()
        conn.Open()
        cm = New SqlCommand("select * from tblType order by type ASC", conn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cm)
        da.Fill(ds, "type")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("type").ToString)
        Next
        txtType.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtType.AutoCompleteCustomSource = col
        txtType.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        conn.Close()
    End Sub

    Sub loadFormulation()
        conn.Open()
        cm = New SqlCommand("select * from tblFormulation order by formulation ASC", conn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cm)
        da.Fill(ds, "formulation")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("formulation").ToString)
        Next
        txtFormulation.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtFormulation.AutoCompleteCustomSource = col
        txtFormulation.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        conn.Close()
    End Sub

    Private Sub FormProductEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBrand()
        loadGeneric()
        loadClassification()
        loadType()
        loadFormulation()
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
End Class