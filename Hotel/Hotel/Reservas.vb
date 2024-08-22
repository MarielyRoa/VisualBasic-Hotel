Imports System.Data.SqlClient

Public Class Reservas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Manejo de evento click para Label1
    End Sub

    Private Sub Reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos en el DataGridView al cargar el formulario
        CargarDatos()
    End Sub

    Structure Reserva
        Dim ID_Reserva As Integer
        Dim ID_Cliente As Integer
        Dim ID_Habitacion As Integer
        Dim Fecha_Entrada As Date
        Dim Fecha_Salida As Date
    End Structure

    ' Lista para almacenar las reservas
    Private ReservasList As New List(Of Reserva)
    Private Const connectionString As String = "Server=DESKTOP-I90EIJK;Database=Hotel;Integrated Security=True;"

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevaReserva As New Reserva

        nuevaReserva.ID_Reserva = Integer.Parse(txtID_Reserva.Text)
        nuevaReserva.ID_Cliente = Integer.Parse(txtID_Cliente.Text)
        nuevaReserva.ID_Habitacion = Integer.Parse(txtID_Habitacion.Text)
        nuevaReserva.Fecha_Entrada = DateTime.Parse(txtFecha_Entrada.Text)
        nuevaReserva.Fecha_Salida = DateTime.Parse(txtFecha_Salida.Text)

        ' Añadir la nueva reserva a la lista
        ReservasList.Add(nuevaReserva)

        Using connection As New SqlConnection(connectionString)
            ' Crear el comando de inserción
            Dim query As String = "INSERT INTO Reservas (ID_Reserva, ID_Cliente, ID_Habitacion, Fecha_Entrada, Fecha_Salida) VALUES (@ID_Reserva, @ID_Cliente, @ID_Habitacion, @Fecha_Entrada, @Fecha_Salida)"
            Using command As New SqlCommand(query, connection)
                ' Añadir parámetros
                command.Parameters.AddWithValue("@ID_Reserva", nuevaReserva.ID_Reserva)
                command.Parameters.AddWithValue("@ID_Cliente", nuevaReserva.ID_Cliente)
                command.Parameters.AddWithValue("@ID_Habitacion", nuevaReserva.ID_Habitacion)
                command.Parameters.AddWithValue("@Fecha_Entrada", nuevaReserva.Fecha_Entrada)
                command.Parameters.AddWithValue("@Fecha_Salida", nuevaReserva.Fecha_Salida)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Reserva agregada exitosamente.")
                    ' Volver a cargar los datos en el DataGridView
                    CargarDatos()
                Catch ex As Exception
                    MessageBox.Show("Error al agregar la reserva. Asegúrese de que todos los campos están correctos.")
                End Try
            End Using
        End Using

        ' Limpiar los campos de texto
        txtID_Reserva.Clear()
        txtID_Cliente.Clear()
        txtID_Habitacion.Clear()
        txtFecha_Entrada.Clear()
        txtFecha_Salida.Clear()
    End Sub

    Private Sub CargarDatos()
        Using connection As New SqlConnection(connectionString)
            ' Consulta SQL para seleccionar todos los datos de la tabla Reservas
            Dim query As String = "SELECT * FROM Reservas"
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
        ' Limpiar los campos de texto
        txtID_Reserva.Clear()
        txtID_Cliente.Clear()
        txtID_Habitacion.Clear()
        txtFecha_Entrada.Clear()
        txtFecha_Salida.Clear()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim recepcionForm As New Menu_recepcion()
        recepcionForm.Show()
        Me.Close()
    End Sub
End Class
