Imports System.Data.SqlClient
Public Class Form5
    Dim random As New Random()
    Dim userid As Integer = 0
    Dim dataAdapter As SqlDataAdapter
    Dim table As DataTable
    Private Sub TextBox_Buy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Buy.KeyPress
        If TextBox_Buy.Text.Length >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        TextBox_Buy.Enabled = True
        Button_Buy.Enabled = True
    End Sub

    Private Sub Button_Buy_Click(sender As Object, e As EventArgs) Handles Button_Buy.Click
        Dim CreditCard As Integer
        userid = random.Next(1, 100000)
        Module1.idOutlet = 4
        Module1.idFuel = "Electric Charging"
        Module1.PriceG4 = 2
        If TextBox_Buy.Text.Trim() = "" Then
            MessageBox.Show("Error：S'ha de ficar un valor per Kw/h ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox_Buy.Text = ""
            TextBox_Buy.Text = ""
            Return
        End If
        Module1.idCapacity = Val(TextBox_Buy.Text) * PriceG4
        Do
            Dim pinInput As String = InputBox("Introdueix el PIN de la targeta")
            If pinInput = "" Then
                MessageBox.Show("Error: Si us plau, introdueix un número vàlid per al PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox_Buy.Text = ""
                TextBox_Buy.Text = ""
                Return
            End If
            If Not Integer.TryParse(pinInput, CreditCard) Then
                MessageBox.Show("Error: Si us plau, introdueix un número vàlid per al PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                Me.Electric_chargingTableAdapter.InsertQueryElectric(userid, Today, (Val(TextBox_Buy.Text)))
                Me.SalesTableAdapter.InsertQuerySales(Module1.idOutlet, Today, Module1.idFuel, Module1.idCapacity)
                Exit Do
            End If
        Loop
        TextBox_Buy.Text = ""
        MessageBox.Show("Gracies per la seva visita!", "Gracies!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Electric_chargingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Electric_chargingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GASOLINERADataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Sales' Puede moverla o quitarla según sea necesario.
        Me.SalesTableAdapter.Fill(Me.GASOLINERADataSet.Sales)
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Electric_charging' Puede moverla o quitarla según sea necesario.
        Me.Electric_chargingTableAdapter.Fill(Me.GASOLINERADataSet.Electric_charging)
        dataAdapter = New SqlDataAdapter("SELECT price FROM Deposits WHERE deposits_id = 4", connection)
        table = New DataTable
        Label_elePrice.Text = Module1.PriceG4 & "€|Kw/h"

    End Sub
End Class