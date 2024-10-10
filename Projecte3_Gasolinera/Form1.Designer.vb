<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Client = New System.Windows.Forms.Button()
        Me.Button_Admin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(61, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GASOLINERA"
        '
        'Button_Client
        '
        Me.Button_Client.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Client.Location = New System.Drawing.Point(78, 214)
        Me.Button_Client.Name = "Button_Client"
        Me.Button_Client.Size = New System.Drawing.Size(136, 55)
        Me.Button_Client.TabIndex = 1
        Me.Button_Client.Text = "CLIENT"
        Me.Button_Client.UseVisualStyleBackColor = True
        '
        'Button_Admin
        '
        Me.Button_Admin.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Admin.Location = New System.Drawing.Point(78, 114)
        Me.Button_Admin.Name = "Button_Admin"
        Me.Button_Admin.Size = New System.Drawing.Size(136, 55)
        Me.Button_Admin.TabIndex = 2
        Me.Button_Admin.Text = "ADMIN"
        Me.Button_Admin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 370)
        Me.Controls.Add(Me.Button_Admin)
        Me.Controls.Add(Me.Button_Client)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Gasolinera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Client As Button
    Friend WithEvents Button_Admin As Button
End Class
