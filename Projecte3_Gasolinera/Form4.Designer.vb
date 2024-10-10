<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_UserId = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GASOLINERADataSet = New Projecte3_Gasolinera.GASOLINERADataSet()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.AdminTableAdapter()
        Me.TableAdapterManager = New Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.TableAdapterManager()
        CType(Me.GASOLINERADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMIN LOG IN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PASSWORD"
        '
        'TextBox_UserId
        '
        Me.TextBox_UserId.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox_UserId.Location = New System.Drawing.Point(173, 57)
        Me.TextBox_UserId.Name = "TextBox_UserId"
        Me.TextBox_UserId.Size = New System.Drawing.Size(178, 26)
        Me.TextBox_UserId.TabIndex = 22
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox_Password.Location = New System.Drawing.Point(173, 100)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Password.Size = New System.Drawing.Size(178, 26)
        Me.TextBox_Password.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(215, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 55)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "LOG IN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(17, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 55)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(398, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 55)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "SIGN IN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(373, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 26)
        Me.TextBox1.TabIndex = 27
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(373, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 26)
        Me.TextBox2.TabIndex = 28
        '
        'GASOLINERADataSet
        '
        Me.GASOLINERADataSet.DataSetName = "GASOLINERADataSet"
        Me.GASOLINERADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.GASOLINERADataSet
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepositsTableAdapter = Nothing
        Me.TableAdapterManager.Electric_chargingTableAdapter = Nothing
        Me.TableAdapterManager.OutletTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 222)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.TextBox_UserId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.Text = "Admin"
        CType(Me.GASOLINERADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_UserId As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GASOLINERADataSet As GASOLINERADataSet
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As GASOLINERADataSetTableAdapters.AdminTableAdapter
    Friend WithEvents TableAdapterManager As GASOLINERADataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
