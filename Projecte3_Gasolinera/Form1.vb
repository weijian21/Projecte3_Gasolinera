Imports System.Data.SqlClient
Public Class Form1
    Dim dataAdapter As SqlDataAdapter
    Dim table As DataTable
    Private Sub Button_Client_Click(sender As Object, e As EventArgs) Handles Button_Client.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button_Admin_Click(sender As Object, e As EventArgs) Handles Button_Admin.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataAdapter = New SqlDataAdapter("SELECT price FROM Deposits WHERE deposits_id = 1", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call price1()
        dataAdapter = New SqlDataAdapter("SELECT price FROM Deposits WHERE deposits_id = 2", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call price2()
        dataAdapter = New SqlDataAdapter("SELECT price FROM Deposits WHERE deposits_id = 3", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call price3()
        dataAdapter = New SqlDataAdapter("SELECT price FROM Deposits WHERE deposits_id = 4", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call price4()
        dataAdapter = New SqlDataAdapter("SELECT Outlet_Active FROM Outlet WHERE Outlet_id = 1", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call OutletS1()
        dataAdapter = New SqlDataAdapter("SELECT Outlet_Active FROM Outlet WHERE Outlet_id = 2", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call OutletS2()
        dataAdapter = New SqlDataAdapter("SELECT Outlet_Active FROM Outlet WHERE Outlet_id = 3", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call OutletS3()
        dataAdapter = New SqlDataAdapter("SELECT Outlet_Active FROM Outlet WHERE Outlet_id = 4", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call OutletS4()
    End Sub
    Sub price1()
        For Each r As DataRow In table.Rows
            Module1.PriceG1 = r("price")
        Next
    End Sub
    Sub price2()
        For Each r As DataRow In table.Rows
            Module1.PriceG2 = r("price")
        Next
    End Sub
    Sub price3()
        For Each r As DataRow In table.Rows
            Module1.PriceG3 = r("price")
        Next
    End Sub
    Sub price4()
        For Each r As DataRow In table.Rows
            Module1.PriceG4 = r("price")
        Next
    End Sub
    Sub OutletS1()
        For Each r As DataRow In table.Rows
            Module1.Outlet1 = r("Outlet_Active")
        Next
    End Sub
    Sub OutletS2()
        For Each r As DataRow In table.Rows
            Module1.Outlet2 = r("Outlet_Active")
        Next
    End Sub
    Sub OutletS3()
        For Each r As DataRow In table.Rows
            Module1.Outlet3 = r("Outlet_Active")
        Next
    End Sub
    Sub OutletS4()
        For Each r As DataRow In table.Rows
            Module1.Outlet4 = r("Outlet_Active")
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub
End Class
