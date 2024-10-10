Imports System.ComponentModel
Imports System.Threading
Imports System.Data.SqlClient
Public Class Form6
    Dim edit_time As Integer
    Dim dataAdapter As SqlDataAdapter
    Dim table As DataTable
    Dim user_id As String
    Dim hashcode_admin_password As Integer
    Dim Gasoil98 As Integer
    Dim Gasoil95 As Integer
    Dim GasoilBiodisel As Integer

    Private Sub AdminBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GASOLINERADataSet)

    End Sub
    Public Property TextBoxContent As String
        Get
            Return Label_AdminId.Text
        End Get
        Set(ByVal value As String)
            Label_AdminId.Text = value
        End Set
    End Property

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Electric_charging' Puede moverla o quitarla según sea necesario.
        Me.Electric_chargingTableAdapter.Fill(Me.GASOLINERADataSet.Electric_charging)
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id = 1", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call Fuel_Capacity1()
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id = 2", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call Fuel_Capacity2()
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id = 3", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call Fuel_Capacity3()

        If FuelCapacity1 <= 0 Then
            Me.DepositsTableAdapter.UpdateQueryFillup(1)
            FuelCapacity1 = 5000
        End If
        If FuelCapacity2 <= 0 Then
            Me.DepositsTableAdapter.UpdateQueryFillup(2)
            FuelCapacity2 = 5000
        End If
        If FuelCapacity3 <= 0 Then
            Me.DepositsTableAdapter.UpdateQueryFillup(3)
            FuelCapacity3 = 5000
        End If
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Outlet' Puede moverla o quitarla según sea necesario.
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Sales' Puede moverla o quitarla según sea necesario.
        Me.SalesTableAdapter.Fill(Me.GASOLINERADataSet.Sales)
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Deposits' Puede moverla o quitarla según sea necesario.
        Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Admin' Puede moverla o quitarla según sea necesario.
        Me.AdminTableAdapter.Fill(Me.GASOLINERADataSet.Admin)

        If FuelCapacity1 = 5000 Then
            Button_fillupG98.Enabled = False
        End If
        If FuelCapacity2 = 5000 Then
            Button_fillupG95.Enabled = False
        End If
        If FuelCapacity3 = 5000 Then
            Button_fillupBio.Enabled = False
        End If


        If Module1.Outlet1 = "Active" Then
            PictureBox_Outlet1.BackColor = Color.Green
        ElseIf Module1.Outlet1 = "Desactive" Then
            PictureBox_Outlet1.BackColor = Color.Red
        End If
        If Module1.Outlet2 = "Active" Then
            PictureBox_Outlet2.BackColor = Color.Green
        ElseIf Module1.Outlet2 = "Desactive" Then
            PictureBox_Outlet2.BackColor = Color.Red
        End If
        If Module1.Outlet3 = "Active" Then
            PictureBox_Outlet3.BackColor = Color.Green
        ElseIf Module1.Outlet3 = "Desactive" Then
            PictureBox_Outlet3.BackColor = Color.Red
        End If
        If Module1.Outlet4 = "Active" Then
            PictureBox_Outlet4.BackColor = Color.Green
        ElseIf Module1.Outlet4 = "Desactive" Then
            PictureBox_Outlet4.BackColor = Color.Red
        End If

        ProgressBar_G98.Value = FuelCapacity1
        ProgressBar_G95.Value = FuelCapacity2
        ProgressBar_Bio.Value = FuelCapacity3


        Button_confirmprice1.Enabled = False
        Button_confirmprice2.Enabled = False
        Button_confirmprice3.Enabled = False
        Button_confirmprice4.Enabled = False
        TextBox_price1.Enabled = False
        TextBox_price2.Enabled = False
        TextBox_price3.Enabled = False
        TextBox_price4.Enabled = False

    End Sub

    Private Sub Button_editprice1_Click(sender As Object, e As EventArgs) Handles Button_editprice1.Click
        If TextBox_price1.Enabled Then
            TextBox_price1.Text = ""
            TextBox_price1.Enabled = False
            Button_confirmprice1.Enabled = False
        Else
            TextBox_price1.Enabled = True
            Button_confirmprice1.Enabled = True
        End If
    End Sub

    Private Sub Button_editprice2_Click(sender As Object, e As EventArgs) Handles Button_editprice2.Click
        If TextBox_price2.Enabled Then
            TextBox_price2.Text = ""
            TextBox_price2.Enabled = False
            Button_confirmprice2.Enabled = False
        Else
            TextBox_price2.Enabled = True
            Button_confirmprice2.Enabled = True
        End If
    End Sub

    Private Sub Button_editprice3_Click(sender As Object, e As EventArgs) Handles Button_editprice3.Click
        If TextBox_price3.Enabled Then
            TextBox_price3.Text = ""
            TextBox_price3.Enabled = False
            Button_confirmprice3.Enabled = False
        Else
            TextBox_price3.Enabled = True
            Button_confirmprice3.Enabled = True
        End If
    End Sub

    Private Sub Button_editprice4_Click(sender As Object, e As EventArgs) Handles Button_editprice4.Click
        If TextBox_price4.Enabled Then
            TextBox_price4.Text = ""
            TextBox_price4.Enabled = False
            Button_confirmprice4.Enabled = False
        Else
            TextBox_price4.Enabled = True
            Button_confirmprice4.Enabled = True
        End If
    End Sub

    Private Sub Button_confirmprice1_Click(sender As Object, e As EventArgs) Handles Button_confirmprice1.Click
        Try
            Me.DepositsTableAdapter.UpdateQueryDepositsPrice(TextBox_price1.Text, 1)
            Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
            TextBox_price1.Text = ""
            Button_confirmprice1.Enabled = False
            TextBox_price1.Enabled = False
            MessageBox.Show("Preu Cambiat Correctament", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_fillupG98_Click(sender As Object, e As EventArgs) Handles Button_fillupG98.Click
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id = 1", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Me.DepositsTableAdapter.UpdateQueryFillup(1)
        Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
        FuelCapacity1 = 5000
        ProgressBar_G98.Value = FuelCapacity1
        Button_fillupG98.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Sub FillUpTest()
        For Each r As DataRow In table.Rows

        Next
    End Sub

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button_confirmprice2_Click(sender As Object, e As EventArgs) Handles Button_confirmprice2.Click
        Try
            Me.DepositsTableAdapter.UpdateQueryDepositsPrice(TextBox_price2.Text, 2)
            Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
            TextBox_price2.Text = ""
            Button_confirmprice2.Enabled = False
            TextBox_price2.Enabled = False
            MessageBox.Show("Preu Cambiat Correctament", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_confirmprice3_Click(sender As Object, e As EventArgs) Handles Button_confirmprice3.Click
        Try
            Me.DepositsTableAdapter.UpdateQueryDepositsPrice(TextBox_price3.Text, 3)
            Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
            TextBox_price3.Text = ""
            Button_confirmprice3.Enabled = False
            TextBox_price3.Enabled = False
            MessageBox.Show("Preu Cambiat Correctament", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_confirmprice4_Click(sender As Object, e As EventArgs) Handles Button_confirmprice4.Click
        Try
            Me.DepositsTableAdapter.UpdateQueryDepositsPrice(TextBox_price4.Text, 4)
            Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
            TextBox_price4.Text = ""
            Button_confirmprice4.Enabled = False
            TextBox_price4.Enabled = False
            MessageBox.Show("Preu Cambiat Correctament", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_Signin_Click(sender As Object, e As EventArgs) Handles Button_Singin.Click
        Try
            hashcode_admin_password = TextBox_adminpassword.Text.GetHashCode()
            Me.AdminTableAdapter.InsertQueryAdmin(TextBox_adminId.Text, hashcode_admin_password)
            Me.AdminTableAdapter.Fill(Me.GASOLINERADataSet.Admin)
            TextBox_adminId.Text = ""
            TextBox_adminpassword.Text = ""
        Catch ex As Exception
            MsgBox("Error!")
            TextBox_password1.Text = ""
            TextBox_password2.Text = ""
        End Try
    End Sub

    Private Sub Button_fillupG95_Click(sender As Object, e As EventArgs) Handles Button_fillupG95.Click
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id = 2", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Me.DepositsTableAdapter.UpdateQueryFillup(2)
        Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
        FuelCapacity2 = 5000
        ProgressBar_G95.Value = FuelCapacity2
        Button_fillupG95.Enabled = False
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub Button_fillupBio_Click(sender As Object, e As EventArgs) Handles Button_fillupBio.Click
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id = 3", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Me.DepositsTableAdapter.UpdateQueryFillup(3)
        Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
        FuelCapacity3 = 5000
        ProgressBar_Bio.Value = FuelCapacity3
        Button_fillupBio.Enabled = False
        BackgroundWorker3.RunWorkerAsync()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button_passwordchange.Click
        dataAdapter = New SqlDataAdapter("SELECT admin_password FROM Admin WHERE admin_id =" & Label_AdminId.Text, connection)
        table = New DataTable
        If TextBox_password1.Text = TextBox_password2.Text Then
            hashcode_admin_password = TextBox_password2.Text.GetHashCode
            Me.AdminTableAdapter.UpdateQueryAdminpasswordchange(hashcode_admin_password, Label_AdminId.Text)
            Me.AdminTableAdapter.Fill(Me.GASOLINERADataSet.Admin)
            TextBox_password1.Text = ""
            TextBox_password2.Text = ""
        Else
            MsgBox("Les contrasenyes no son iguals")
            TextBox_password1.Text = ""
            TextBox_password2.Text = ""
        End If
    End Sub

    Private Sub Button_Outlet1_A_Click(sender As Object, e As EventArgs) Handles Button_Outlet1_A.Click
        Module1.Outlet1 = True
        PictureBox_Outlet1.BackColor = Color.Green
        Me.OutletTableAdapter.UpdateQueryOutletActive("Active", 1)
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
    End Sub

    Private Sub Button_Outlet2_Y_Click(sender As Object, e As EventArgs) Handles Button_Outlet2_Y.Click
        Module1.Outlet2 = True
        PictureBox_Outlet2.BackColor = Color.Green
        Me.OutletTableAdapter.UpdateQueryOutletActive("Active", 2)
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
    End Sub

    Private Sub Button_Outlet3_Y_Click(sender As Object, e As EventArgs) Handles Button_Outlet3_Y.Click
        Module1.Outlet3 = True
        PictureBox_Outlet3.BackColor = Color.Green
        Me.OutletTableAdapter.UpdateQueryOutletActive("Active", 3)
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
    End Sub

    Private Sub Button_Outlet4_Y_Click(sender As Object, e As EventArgs) Handles Button_Outlet4_Y.Click
        Module1.Outlet4 = True
        PictureBox_Outlet4.BackColor = Color.Green
        Me.OutletTableAdapter.UpdateQueryOutletActive("Active", 4)
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
    End Sub

    Private Sub Button_Outlet1_S_Click(sender As Object, e As EventArgs) Handles Button_Outlet1_S.Click
        Module1.Outlet1 = False
        PictureBox_Outlet1.BackColor = Color.Red
        Me.OutletTableAdapter.UpdateQueryOutletActive("Desactive", 1)
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
    End Sub

    Private Sub Button_Outlet2_N_Click(sender As Object, e As EventArgs) Handles Button_Outlet2_N.Click
        Module1.Outlet2 = False
        PictureBox_Outlet2.BackColor = Color.Red
        Me.OutletTableAdapter.UpdateQueryOutletActive("Desactive", 2)
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
    End Sub

    Private Sub Button_Outlet3_N_Click(sender As Object, e As EventArgs) Handles Button_Outlet3_N.Click
        Module1.Outlet3 = False
        PictureBox_Outlet3.BackColor = Color.Red
        Me.OutletTableAdapter.UpdateQueryOutletActive("Desactive", 3)
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
    End Sub

    Private Sub Button_Outlet4_N_Click(sender As Object, e As EventArgs) Handles Button_Outlet4_N.Click
        Module1.Outlet4 = False
        PictureBox_Outlet4.BackColor = Color.Red
        Me.OutletTableAdapter.UpdateQueryOutletActive("Desactive", 4)
        Me.OutletTableAdapter.Fill(Me.GASOLINERADataSet.Outlet)
    End Sub

    Private Sub Button_DateCheck_Click(sender As Object, e As EventArgs) Handles Button_DateCheck.Click
        Me.SalesTableAdapter.FillBySalesDateCheck(Me.GASOLINERADataSet.Sales, DateTimePicker_SaleDate.Text)
    End Sub


    Private Sub TextBox_adminId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_adminId.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Sub Fuel_Capacity1()
        For Each r As DataRow In table.Rows
            Module1.FuelCapacity1 = r("fuel_capacity")
        Next
    End Sub
    Sub Fuel_Capacity2()
        For Each r As DataRow In table.Rows
            Module1.FuelCapacity2 = r("fuel_capacity")
        Next
    End Sub
    Sub Fuel_Capacity3()
        For Each r As DataRow In table.Rows
            Module1.FuelCapacity3 = r("fuel_capacity")
        Next
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i As Integer = FuelCapacity1 To ProgressBar_G98.Maximum
            Thread.Sleep(500)
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar_G98.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Gasoil98 Llenado Correctamente", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        For i As Integer = FuelCapacity2 To ProgressBar_G95.Maximum
            Thread.Sleep(500)
        Next
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        ProgressBar_G95.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        MessageBox.Show("Gasoil95 Llenado Correctamente", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        For i As Integer = FuelCapacity3 To ProgressBar_Bio.Maximum
            Thread.Sleep(500)
        Next
    End Sub

    Private Sub BackgroundWorker3_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker3.ProgressChanged
        ProgressBar_G95.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        MessageBox.Show("Biodisel Llenado Correctamente", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Electric_chargingTableAdapter.FillByElectricChargingDate(Me.GASOLINERADataSet.Electric_charging, DateTimePicker_SaleDate.Text)
    End Sub
End Class