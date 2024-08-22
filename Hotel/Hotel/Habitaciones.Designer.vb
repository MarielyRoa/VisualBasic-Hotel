<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Habitaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Habitaciones))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID_Habitacion = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDHabitacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDBDataSet = New Hotel.HotelDBDataSet()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_Habitacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Buscar Habitacion"
        '
        'txtID_Habitacion
        '
        Me.txtID_Habitacion.Location = New System.Drawing.Point(209, 62)
        Me.txtID_Habitacion.Name = "txtID_Habitacion"
        Me.txtID_Habitacion.Size = New System.Drawing.Size(149, 22)
        Me.txtID_Habitacion.TabIndex = 6
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(209, 116)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(149, 22)
        Me.txtTipo.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(209, 159)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(149, 22)
        Me.txtPrecio.TabIndex = 9
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(209, 335)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(149, 22)
        Me.TextBox6.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDHabitacionDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HabitacionesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(528, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(459, 263)
        Me.DataGridView1.TabIndex = 12
        '
        'IDHabitacionDataGridViewTextBoxColumn
        '
        Me.IDHabitacionDataGridViewTextBoxColumn.DataPropertyName = "ID_Habitacion"
        Me.IDHabitacionDataGridViewTextBoxColumn.HeaderText = "ID_Habitacion"
        Me.IDHabitacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDHabitacionDataGridViewTextBoxColumn.Name = "IDHabitacionDataGridViewTextBoxColumn"
        Me.IDHabitacionDataGridViewTextBoxColumn.Width = 125
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.Width = 125
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource.DataSource = Me.HotelDBDataSet
        '
        'HotelDBDataSet
        '
        Me.HotelDBDataSet.DataSetName = "HotelDBDataSet"
        Me.HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(402, 235)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 38)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(295, 235)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 38)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(173, 235)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 38)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(36, 235)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 38)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(362, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 47)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Habitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1027, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtID_Habitacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Habitaciones"
        Me.Text = "Habitaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID_Habitacion As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HotelDBDataSet As HotelDBDataSet
    Friend WithEvents HabitacionesBindingSource As BindingSource
    Friend WithEvents IDHabitacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Button2 As Button
End Class
