Imports System.Data.SqlClient
Public Class Form3
    Dim Price As Double
    Dim dataAdapter As SqlDataAdapter
    Dim table As DataTable
    Dim capacity As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox_Buy.Text = ""
        TextBox_Buy.Text = ""
        TextBox_Buy.Enabled = False
        Button_Buy.Enabled = False
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id =" & Module1.idDeposit, connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call DepositTest()
        Dim Gpercent As Double = (capacity / 5000) * 100
        If Gpercent <= 10 Then
            Me.DepositsTableAdapter.DepositsGFullUpdateQuery(Module1.idDeposit)
        End If
        Module1.idDeposit = 1
        Module1.idFuel = "Gasolina 98"
        Price = Module1.PriceG1
        TextBox_Buy.Enabled = True
        Button_Buy.Enabled = True
        Label_price.Text = Module1.PriceG1 & "€/L"
        Label_gasol.Text = "GASOLINA 98"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id =" & Module1.idDeposit, connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call DepositTest()
        Dim Gpercent As Double = (capacity / 5000) * 100
        If Gpercent <= 10 Then
            Me.DepositsTableAdapter.DepositsGFullUpdateQuery(Module1.idDeposit)
        End If
        Module1.idDeposit = 2
        Module1.idFuel = "Gasolina 95"
        Price = Module1.PriceG2
        TextBox_Buy.Enabled = True
        Button_Buy.Enabled = True
        Label_price.Text = Module1.PriceG2 & "€/L"
        Label_gasol.Text = "GASOLINA 95"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dataAdapter = New SqlDataAdapter("SELECT fuel_capacity FROM Deposits WHERE deposits_id =" & Module1.idDeposit, connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call DepositTest()
        Dim Gpercent As Double = (capacity / 5000) * 100
        If Gpercent <= 10 Then
            Me.DepositsTableAdapter.DepositsGFullUpdateQuery(Module1.idDeposit)
        End If
        Module1.idDeposit = 3
        Module1.idFuel = "Biodiesel"
        TextBox_Buy.Enabled = True
        Button_Buy.Enabled = True
        Price = Module1.PriceG3
        Label_price.Text = Module1.PriceG3 & "€/L"
        Label_gasol.Text = "BIODIESEL"
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Buy.KeyPress
        If TextBox_Buy.Text.Length >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Deposits' Puede moverla o quitarla según sea necesario.
        Me.DepositsTableAdapter.Fill(Me.GASOLINERADataSet.Deposits)
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Sales' Puede moverla o quitarla según sea necesario.
        Me.SalesTableAdapter.Fill(Me.GASOLINERADataSet.Sales)
        TextBox_Buy.Enabled = False
        Button_Buy.Enabled = False
    End Sub

    Private Sub Button_Buy_Click(sender As Object, e As EventArgs) Handles Button_Buy.Click
        If TextBox_Buy.Text >= 5000 Then
            MessageBox.Show("Error：No hi ha suficient Gasoil per comprar, perdoneu per les molesties", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox_Buy.Text = ""
            Return
        End If
        Dim CreditCard As Integer
        If TextBox_Buy.Text.Trim() = "" Then
            MessageBox.Show("Error：S'ha de ficar un valor per Litre ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Module1.idCapacity = Val(TextBox_Buy.Text) * Price
        Do
            Dim pinInput As String = InputBox("Introdueix el PIN de la targeta")
            If pinInput = "" Then
                MessageBox.Show("Error: Si us plau, introdueix un número vàlid per al PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox_Buy.Text = ""
                Return
            End If

            If Not Integer.TryParse(pinInput, CreditCard) Then
                MessageBox.Show("Error: Si us plau, introdueix un número vàlid per al PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox_Buy.Text = ""
                Return
            Else
                Me.SalesTableAdapter.InsertQuerySales(Module1.idOutlet, Today, Module1.idFuel, Module1.idCapacity)
                Me.DepositsTableAdapter.UpdateQueryDeposits(Val(TextBox_Buy.Text), Module1.idDeposit)
                Exit Do
            End If
        Loop

        TextBox_Buy.Text = ""
        Button_Buy.Enabled = False
        TextBox_Buy.Enabled = False
        MessageBox.Show("Gracies per la seva visita!", "Gracies!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GASOLINERADataSet)
    End Sub
    Sub DepositTest()
        For Each r As DataRow In table.Rows
            capacity = r("fuel_capacity")
        Next
    End Sub
End Class