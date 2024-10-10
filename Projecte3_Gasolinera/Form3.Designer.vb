<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label_gasol = New System.Windows.Forms.Label()
        Me.TextBox_Buy = New System.Windows.Forms.TextBox()
        Me.Button_Buy = New System.Windows.Forms.Button()
        Me.Label_price = New System.Windows.Forms.Label()
        Me.GASOLINERADataSet = New Projecte3_Gasolinera.GASOLINERADataSet()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.SalesTableAdapter()
        Me.TableAdapterManager = New Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.TableAdapterManager()
        Me.DepositsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepositsTableAdapter = New Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.DepositsTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GASOLINERADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepositsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(22, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 55)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(306, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 55)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "BIODIESEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(164, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 55)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "GASOLINA 95"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(22, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 55)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "GASOLINA 98"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label_gasol
        '
        Me.Label_gasol.AutoSize = True
        Me.Label_gasol.Font = New System.Drawing.Font("宋体", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label_gasol.Location = New System.Drawing.Point(17, 89)
        Me.Label_gasol.Name = "Label_gasol"
        Me.Label_gasol.Size = New System.Drawing.Size(125, 30)
        Me.Label_gasol.TabIndex = 20
        Me.Label_gasol.Text = "SELECT:"
        '
        'TextBox_Buy
        '
        Me.TextBox_Buy.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox_Buy.Location = New System.Drawing.Point(204, 93)
        Me.TextBox_Buy.Name = "TextBox_Buy"
        Me.TextBox_Buy.Size = New System.Drawing.Size(96, 26)
        Me.TextBox_Buy.TabIndex = 21
        '
        'Button_Buy
        '
        Me.Button_Buy.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Buy.Location = New System.Drawing.Point(190, 133)
        Me.Button_Buy.Name = "Button_Buy"
        Me.Button_Buy.Size = New System.Drawing.Size(251, 55)
        Me.Button_Buy.TabIndex = 24
        Me.Button_Buy.Text = "BUY"
        Me.Button_Buy.UseVisualStyleBackColor = True
        '
        'Label_price
        '
        Me.Label_price.AutoSize = True
        Me.Label_price.Font = New System.Drawing.Font("宋体", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label_price.Location = New System.Drawing.Point(306, 89)
        Me.Label_price.Name = "Label_price"
        Me.Label_price.Size = New System.Drawing.Size(29, 30)
        Me.Label_price.TabIndex = 25
        Me.Label_price.Text = "L"
        '
        'GASOLINERADataSet
        '
        Me.GASOLINERADataSet.DataSetName = "GASOLINERADataSet"
        Me.GASOLINERADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.GASOLINERADataSet
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepositsTableAdapter = Nothing
        Me.TableAdapterManager.Electric_chargingTableAdapter = Nothing
        Me.TableAdapterManager.OutletTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DepositsBindingSource
        '
        Me.DepositsBindingSource.DataMember = "Deposits"
        Me.DepositsBindingSource.DataSource = Me.GASOLINERADataSet
        '
        'DepositsTableAdapter
        '
        Me.DepositsTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "deposits_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "deposits_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fuel_type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fuel_type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fuel_capacity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fuel_capacity"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 198)
        Me.Controls.Add(Me.Label_price)
        Me.Controls.Add(Me.Button_Buy)
        Me.Controls.Add(Me.TextBox_Buy)
        Me.Controls.Add(Me.Label_gasol)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Compra"
        CType(Me.GASOLINERADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepositsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label_gasol As Label
    Friend WithEvents TextBox_Buy As TextBox
    Friend WithEvents Button_Buy As Button
    Friend WithEvents Label_price As Label
    Friend WithEvents GASOLINERADataSet As GASOLINERADataSet
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As GASOLINERADataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TableAdapterManager As GASOLINERADataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepositsBindingSource As BindingSource
    Friend WithEvents DepositsTableAdapter As GASOLINERADataSetTableAdapters.DepositsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
