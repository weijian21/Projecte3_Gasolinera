<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.Button_Buy = New System.Windows.Forms.Button()
        Me.TextBox_Buy = New System.Windows.Forms.TextBox()
        Me.Label_gasol = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label_elePrice = New System.Windows.Forms.Label()
        Me.GASOLINERADataSet = New Projecte3_Gasolinera.GASOLINERADataSet()
        Me.Electric_chargingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Electric_chargingTableAdapter = New Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.Electric_chargingTableAdapter()
        Me.TableAdapterManager = New Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.TableAdapterManager()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.SalesTableAdapter()
        CType(Me.GASOLINERADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Electric_chargingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Buy
        '
        Me.Button_Buy.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button_Buy.Location = New System.Drawing.Point(186, 53)
        Me.Button_Buy.Name = "Button_Buy"
        Me.Button_Buy.Size = New System.Drawing.Size(251, 55)
        Me.Button_Buy.TabIndex = 28
        Me.Button_Buy.Text = "BUY"
        Me.Button_Buy.UseVisualStyleBackColor = True
        '
        'TextBox_Buy
        '
        Me.TextBox_Buy.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox_Buy.Location = New System.Drawing.Point(186, 13)
        Me.TextBox_Buy.Name = "TextBox_Buy"
        Me.TextBox_Buy.Size = New System.Drawing.Size(111, 26)
        Me.TextBox_Buy.TabIndex = 27
        '
        'Label_gasol
        '
        Me.Label_gasol.AutoSize = True
        Me.Label_gasol.Font = New System.Drawing.Font("宋体", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label_gasol.Location = New System.Drawing.Point(12, 9)
        Me.Label_gasol.Name = "Label_gasol"
        Me.Label_gasol.Size = New System.Drawing.Size(141, 30)
        Me.Label_gasol.TabIndex = 26
        Me.Label_gasol.Text = "ELECTRIC"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(17, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 55)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label_elePrice
        '
        Me.Label_elePrice.AutoSize = True
        Me.Label_elePrice.Font = New System.Drawing.Font("宋体", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label_elePrice.Location = New System.Drawing.Point(308, 13)
        Me.Label_elePrice.Name = "Label_elePrice"
        Me.Label_elePrice.Size = New System.Drawing.Size(124, 30)
        Me.Label_elePrice.TabIndex = 30
        Me.Label_elePrice.Text = "KW/H|€"
        '
        'GASOLINERADataSet
        '
        Me.GASOLINERADataSet.DataSetName = "GASOLINERADataSet"
        Me.GASOLINERADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Electric_chargingBindingSource
        '
        Me.Electric_chargingBindingSource.DataMember = "Electric_charging"
        Me.Electric_chargingBindingSource.DataSource = Me.GASOLINERADataSet
        '
        'Electric_chargingTableAdapter
        '
        Me.Electric_chargingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepositsTableAdapter = Nothing
        Me.TableAdapterManager.Electric_chargingTableAdapter = Me.Electric_chargingTableAdapter
        Me.TableAdapterManager.OutletTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Projecte3_Gasolinera.GASOLINERADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 121)
        Me.Controls.Add(Me.Label_elePrice)
        Me.Controls.Add(Me.Button_Buy)
        Me.Controls.Add(Me.TextBox_Buy)
        Me.Controls.Add(Me.Label_gasol)
        Me.Controls.Add(Me.Button2)
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.Text = "Compra"
        CType(Me.GASOLINERADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Electric_chargingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Buy As Button
    Friend WithEvents TextBox_Buy As TextBox
    Friend WithEvents Label_gasol As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label_elePrice As Label
    Friend WithEvents GASOLINERADataSet As GASOLINERADataSet
    Friend WithEvents Electric_chargingBindingSource As BindingSource
    Friend WithEvents Electric_chargingTableAdapter As GASOLINERADataSetTableAdapters.Electric_chargingTableAdapter
    Friend WithEvents TableAdapterManager As GASOLINERADataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As GASOLINERADataSetTableAdapters.SalesTableAdapter
End Class
