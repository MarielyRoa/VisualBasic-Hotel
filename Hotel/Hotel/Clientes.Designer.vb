<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID_cliente = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HotelDataSet = New Hotel.HotelDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Hotel.HotelDataSetTableAdapters.ClientesTableAdapter()
        Me.IDClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Buscar"
        '
        'txtID_cliente
        '
        Me.txtID_cliente.Location = New System.Drawing.Point(142, 48)
        Me.txtID_cliente.Name = "txtID_cliente"
        Me.txtID_cliente.Size = New System.Drawing.Size(142, 22)
        Me.txtID_cliente.TabIndex = 6
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(142, 85)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(142, 22)
        Me.txtnombre.TabIndex = 7
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(142, 117)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(142, 22)
        Me.txtapellido.TabIndex = 8
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(142, 151)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(142, 22)
        Me.txttelefono.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(142, 180)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(142, 22)
        Me.txtemail.TabIndex = 10
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(441, 29)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(166, 22)
        Me.TextBox6.TabIndex = 11
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(32, 371)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 38)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(647, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 31)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(169, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 38)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(291, 371)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 38)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(398, 371)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 38)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDClienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(320, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(677, 257)
        Me.DataGridView1.TabIndex = 17
        '
        'HotelDataSet
        '
        Me.HotelDataSet.DataSetName = "HotelDataSet"
        Me.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.HotelDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'IDClienteDataGridViewTextBoxColumn
        '
        Me.IDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente"
        Me.IDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente"
        Me.IDClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDClienteDataGridViewTextBoxColumn.Name = "IDClienteDataGridViewTextBoxColumn"
        Me.IDClienteDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.Width = 125
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtID_cliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID_cliente As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HotelDataSet As HotelDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As HotelDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents IDClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
