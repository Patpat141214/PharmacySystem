Imports System.Data.SqlClient
Module Module1
    Public conn As New SqlConnection
    Public cm As New SqlCommand
    Public dr As SqlDataReader

    Sub MyConnection()
        conn = New SqlConnection
        With conn
            .ConnectionString = "Data Source=WIN-OLQG14FG7DN\SQLEXPRESS;Initial Catalog=PHARMACY_SYSTEM;Integrated Security=True;Encrypt=False"
        End With
    End Sub

End Module
