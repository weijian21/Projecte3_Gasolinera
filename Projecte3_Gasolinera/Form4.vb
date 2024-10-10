Imports System.Data.SqlClient
Public Class Form4
    Dim dataAdapter As SqlDataAdapter
    Dim table As DataTable
    Dim Admin_Id As String
    Dim hashcode_admin_password As Integer
    Dim dotest As Integer
    Private Sub TextBox_UserId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_UserId.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_UserId_TextChanged(sender As Object, e As EventArgs) Handles TextBox_UserId.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Password.TextChanged

    End Sub

    'Private Sub TextBox_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Password.KeyPress
    '    If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox_UserId.Text = ""
        TextBox_Password.Text = ""
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub AdminBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GASOLINERADataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GASOLINERADataSet.Admin' Puede moverla o quitarla según sea necesario.
        Me.AdminTableAdapter.Fill(Me.GASOLINERADataSet.Admin)
    End Sub
    Public ReadOnly Property TextBoxContent As String
        Get
            Return TextBox_UserId.Text
        End Get
    End Property
    Sub passwordTest()
        For Each r As DataRow In table.Rows
            dotest = r("admin_password")
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dataAdapter = New SqlDataAdapter("SELECT admin_password FROM Admin WHERE admin_id ='" & TextBox_UserId.Text & "'", connection)
        table = New DataTable
        dataAdapter.Fill(table)
        Call passwordTest()
        hashcode_admin_password = TextBox_Password.Text.GetHashCode()

        If dotest = hashcode_admin_password Then
            Me.Hide()
            Form6.Show()
            Form6.TextBoxContent = TextBox_UserId.Text
            TextBox_UserId.Text = ""
            TextBox_Password.Text = ""
        Else
            MessageBox.Show("Error sobre Usuari o Contrasenya", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox_UserId.Text = ""
            TextBox_Password.Text = ""
            Return
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        hashcode_admin_password = TextBox2.Text.GetHashCode()

        Me.AdminTableAdapter.InsertQueryAdmin(TextBox1.Text, hashcode_admin_password)
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

End Class