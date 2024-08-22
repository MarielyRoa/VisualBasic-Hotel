<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID_Reserva = New System.Windows.Forms.TextBox()
        Me.txtFecha_Salida = New System.Windows.Forms.TextBox()
        Me.txtID_Cliente = New System.Windows.Forms.TextBox()
        Me.txtID_Habitacion = New System.Windows.Forms.TextBox()
        Me.txtFecha_Entrada = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDReservaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDHabitacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDBDataSet = New Hotel.HotelDBDataSet()
        Me.ReservasTableAdapter = New Hotel.HotelDBDataSetTableAdapters.ReservasTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_Reserva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID_Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID_Habitacion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha_Entrada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha_Salida"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Buscar"
        '
        'txtID_Reserva
        '
        Me.txtID_Reserva.Location = New System.Drawing.Point(171, 68)
        Me.txtID_Reserva.Name = "txtID_Reserva"
        Me.txtID_Reserva.Size = New System.Drawing.Size(100, 22)
        Me.txtID_Reserva.TabIndex = 6
        '
        'txtFecha_Salida
        '
        Me.txtFecha_Salida.Location = New System.Drawing.Point(171, 232)
        Me.txtFecha_Salida.Name = "txtFecha_Salida"
        Me.txtFecha_Salida.Size = New System.Drawing.Size(100, 22)
        Me.txtFecha_Salida.TabIndex = 7
        '
        'txtID_Cliente
        '
        Me.txtID_Cliente.Location = New System.Drawing.Point(171, 108)
        Me.txtID_Cliente.Name = "txtID_Cliente"
        Me.txtID_Cliente.Size = New System.Drawing.Size(100, 22)
        Me.txtID_Cliente.TabIndex = 8
        '
        'txtID_Habitacion
        '
        Me.txtID_Habitacion.Location = New System.Drawing.Point(171, 152)
        Me.txtID_Habitacion.Name = "txtID_Habitacion"
        Me.txtID_Habitacion.Size = New System.Drawing.Size(100, 22)
        Me.txtID_Habitacion.TabIndex = 9
        '
        'txtFecha_Entrada
        '
        Me.txtFecha_Entrada.Location = New System.Drawing.Point(171, 192)
        Me.txtFecha_Entrada.Name = "txtFecha_Entrada"
        Me.txtFecha_Entrada.Size = New System.Drawing.Size(100, 22)
        Me.txtFecha_Entrada.TabIndex = 10
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(153, 336)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(143, 22)
        Me.TextBox6.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDReservaDataGridViewTextBoxColumn, Me.IDClienteDataGridViewTextBoxColumn, Me.IDHabitacionDataGridViewTextBoxColumn, Me.FechaEntradaDataGridViewTextBoxColumn, Me.FechaSalidaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(314, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(663, 241)
        Me.DataGridView1.TabIndex = 12
        '
        'IDReservaDataGridViewTextBoxColumn
        '
        Me.IDReservaDataGridViewTextBoxColumn.DataPropertyName = "ID_Reserva"
        Me.IDReservaDataGridViewTextBoxColumn.HeaderText = "ID_Reserva"
        Me.IDReservaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDReservaDataGridViewTextBoxColumn.Name = "IDReservaDataGridViewTextBoxColumn"
        Me.IDReservaDataGridViewTextBoxColumn.Width = 125
        '
        'IDClienteDataGridViewTextBoxColumn
        '
        Me.IDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente"
        Me.IDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente"
        Me.IDClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDClienteDataGridViewTextBoxColumn.Name = "IDClienteDataGridViewTextBoxColumn"
        Me.IDClienteDataGridViewTextBoxColumn.Width = 125
        '
        'IDHabitacionDataGridViewTextBoxColumn
        '
        Me.IDHabitacionDataGridViewTextBoxColumn.DataPropertyName = "ID_Habitacion"
        Me.IDHabitacionDataGridViewTextBoxColumn.HeaderText = "ID_Habitacion"
        Me.IDHabitacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDHabitacionDataGridViewTextBoxColumn.Name = "IDHabitacionDataGridViewTextBoxColumn"
        Me.IDHabitacionDataGridViewTextBoxColumn.Width = 125
        '
        'FechaEntradaDataGridViewTextBoxColumn
        '
        Me.FechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Entrada"
        Me.FechaEntradaDataGridViewTextBoxColumn.HeaderText = "Fecha_Entrada"
        Me.FechaEntradaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaEntradaDataGridViewTextBoxColumn.Name = "FechaEntradaDataGridViewTextBoxColumn"
        Me.FechaEntradaDataGridViewTextBoxColumn.Width = 125
        '
        'FechaSalidaDataGridViewTextBoxColumn
        '
        Me.FechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Salida"
        Me.FechaSalidaDataGridViewTextBoxColumn.HeaderText = "Fecha_Salida"
        Me.FechaSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaSalidaDataGridViewTextBoxColumn.Name = "FechaSalidaDataGridViewTextBoxColumn"
        Me.FechaSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'ReservasBindingSource
        '
        Me.ReservasBindingSource.DataMember = "Reservas"
        Me.ReservasBindingSource.DataSource = Me.HotelDBDataSet
        '
        'HotelDBDataSet
        '
        Me.HotelDBDataSet.DataSetName = "HotelDBDataSet"
        Me.HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservasTableAdapter
        '
        Me.ReservasTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Lucida Calligraphy", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(548, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 43)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Reservas"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsalir.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(794, 356)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(93, 38)
        Me.btnsalir.TabIndex = 24
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(687, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 38)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(565, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 38)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(428, 356)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 38)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(110, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 30)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(989, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.txtFecha_Entrada)
        Me.Controls.Add(Me.txtID_Habitacion)
        Me.Controls.Add(Me.txtID_Cliente)
        Me.Controls.Add(Me.txtFecha_Salida)
        Me.Controls.Add(Me.txtID_Reserva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reservas"
        Me.Text = "Reservas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID_Reserva As TextBox
    Friend WithEvents txtFecha_Salida As TextBox
    Friend WithEvents txtID_Cliente As TextBox
    Friend WithEvents txtID_Habitacion As TextBox
    Friend WithEvents txtFecha_Entrada As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HotelDBDataSet As HotelDBDataSet
    Friend WithEvents ReservasBindingSource As BindingSource
    Friend WithEvents ReservasTableAdapter As HotelDBDataSetTableAdapters.ReservasTableAdapter
    Friend WithEvents IDReservaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDHabitacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Button2 As Button
End Class
