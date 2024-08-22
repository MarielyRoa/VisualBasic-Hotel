Imports System.Data.SqlClient
Imports Hotel.HotelDataSetTableAdapters


Public Class Habitaciones
    Private Sub Habitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'HotelDBDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
        CargarDatos()
    End Sub

    Structure Habitaciones
        Dim ID_Habitacion As Integer
        Dim Tipo As String
        Dim Precio As String

    End Structure

    ' Lista para almacenar los clientes
    Private Habitacion As New List(Of Habitaciones)
    Private Const connectionString As String = "Server=DESKTOP-I90EIJK;Database=Hotel;Integrated Security=True;"

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevahabitacion As New Habitaciones

        nuevahabitacion.ID_Habitacion = Integer.Parse(txtID_Habitacion.Text)
        nuevahabitacion.Tipo = txtTipo.Text
        nuevahabitacion.Precio = txtPrecio.Text


        ' Añadir el nuevo cliente a la lista
        Habitacion.Add(nuevahabitacion)

        Using connection As New SqlConnection(connectionString)
            ' Crear el comando de inserción
            Dim query As String = "INSERT INTO Habitaciones (ID_Habitacion, Tipo, Precio) VALUES (@ID_Habitacion, @Tipo, @Precio)"
            Using command As New SqlCommand(query, connection)
                ' Añadir parámetros
                command.Parameters.AddWithValue("@ID_Habitacion", Integer.Parse(txtID_Habitacion.Text))
                command.Parameters.AddWithValue("@Tipo", txtTipo.Text)
                command.Parameters.AddWithValue("@Precio", txtPrecio.Text)


                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Registrado.")
                Catch ex As Exception
                    MessageBox.Show("Error.")
                End Try
            End Using
        End Using

    End Sub

    Private Sub CargarDatos()
        Using connection As New SqlConnection(connectionString)
            ' Consulta SQL para seleccionar todos los datos de la tabla Clientes
            Dim query As String = "SELECT * FROM Habitaciones"
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtID_Habitacion.Text = ""
        txtTipo.Text = ""
        txtPrecio.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim recepcionForm As New Menu_recepcion()
        recepcionForm.Show()
        Me.Close()
    End Sub
End Class