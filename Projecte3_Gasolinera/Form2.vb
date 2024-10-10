Imports System.Data.SqlClient
Public Class Form2
    Dim dataAdapter As SqlDataAdapter
    Dim table As DataTable
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_Outlet1.Click
        Module1.idOutlet = 1
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox_Outlet2.Click
        Module1.idOutlet = 2
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox_Outlet3.Click
        Module1.idOutlet = 3
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub PictureBox_Outlet4_Click(sender As Object, e As EventArgs) Handles PictureBox_Outlet4.Click
        Module1.idOutlet = 4
        Me.Close()
        Form5.Show()
    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If Module1.Outlet1 = "Active" Then
            PictureBox_Outlet1.BackColor = Color.Green
            PictureBox_Outlet1.Enabled = True
        ElseIf Module1.Outlet1 = "Desactive" Then
            PictureBox_Outlet1.BackColor = Color.Red
            PictureBox_Outlet1.Enabled = False
        End If
        If Module1.Outlet2 = "Active" Then
            PictureBox_Outlet2.BackColor = Color.Green
            PictureBox_Outlet2.Enabled = True
        ElseIf Module1.Outlet2 = "Desactive" Then
            PictureBox_Outlet2.BackColor = Color.Red
            PictureBox_Outlet2.Enabled = False
        End If
        If Module1.Outlet3 = "Active" Then
            PictureBox_Outlet3.BackColor = Color.Green
            PictureBox_Outlet3.Enabled = True
        ElseIf Module1.Outlet3 = "Desactive" Then
            PictureBox_Outlet3.BackColor = Color.Red
            PictureBox_Outlet3.Enabled = False
        End If
        If Module1.Outlet4 = "Active" Then
            PictureBox_Outlet4.BackColor = Color.Green
            PictureBox_Outlet4.Enabled = True
        ElseIf Module1.Outlet4 = "Desactive" Then
            PictureBox_Outlet4.BackColor = Color.Red
            PictureBox_Outlet4.Enabled = False
        End If
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
End Class