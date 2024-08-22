Imports System.Data.SqlClient
Imports Hotel.HotelDataSetTableAdapters


Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HotelDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.HotelDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'HotelDBDataSet.Reservas' Puede moverla o quitarla según sea necesario.
        CargarDatos()
    End Sub

    Structure Cliente
        Dim ID_cliente As Integer
        Dim Nombre As String
        Dim Apellido As String
        Dim Telefono As String
        Dim email As String
    End Structure

    ' Lista para almacenar los clientes
    Private Clientes As New List(Of Cliente)

    ' Método para el botón Agregar/Nuevo
    Private Const connectionString As String = "Server=DESKTOP-I90EIJK;Database=Hotel;Integrated Security=True;"

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Crear una nueva instancia de Cliente
        Dim nuevoCliente As New Cliente

        nuevoCliente.ID_cliente = Integer.Parse(txtID_cliente.Text)
        nuevoCliente.Nombre = txtnombre.Text
        nuevoCliente.Apellido = txtapellido.Text
        nuevoCliente.Telefono = txttelefono.Text
        nuevoCliente.email = txtemail.Text

        Using connection As New SqlConnection(connectionString)
            ' Crear el comando de inserción
            Dim query As String = "INSERT INTO Clientes (ID_Cliente, Nombre, Apellido, Telefono, Email) VALUES (@ID_Cliente, @Nombre, @Apellido, @Telefono, @Email)"
            Using command As New SqlCommand(query, connection)
                ' Añadir parámetros
                command.Parameters.AddWithValue("@ID_Cliente", nuevoCliente.ID_cliente)
                command.Parameters.AddWithValue("@Nombre", nuevoCliente.Nombre)
                command.Parameters.AddWithValue("@Apellido", nuevoCliente.Apellido)
                command.Parameters.AddWithValue("@Telefono", nuevoCliente.Telefono)
                command.Parameters.AddWithValue("@Email", nuevoCliente.email)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cliente agregado exitosamente.")
                    ' Volver a cargar los datos en el DataGridView
                    CargarDatos()
                Catch ex As Exception
                    MessageBox.Show("Error al agregar el cliente. Asegúrese de que todos los campos están correctos.")
                End Try
            End Using
        End Using

        ' Limpiar los campos de texto
        txtID_cliente.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txttelefono.Clear()
        txtemail.Clear()
    End Sub

    Private Sub CargarDatos()
        Using connection As New SqlConnection(connectionString)
            ' Consulta SQL para seleccionar todos los datos de la tabla Clientes
            Dim query As String = "SELECT * FROM Clientes"
            Using cmd As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim recepcionForm As New Menu_recepcion()
        recepcionForm.Show()
        Me.Close()
    End Sub
End Class
