Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Dim connectionString As String = "Server=DESKTOP-I90EIJK;Database=HotelDB;User Id=admin;Password=1234;"

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        Dim usuario As String = txtusuario.Text
        Dim contraseña As String = txtcontraseña.Text

        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Nombre_Usuario=admin AND Contrasena=1234"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", usuario)
                cmd.Parameters.AddWithValue("@password", contraseña)


                MessageBox.Show("Inicio de sesión exitoso")
                    ' Abre el formulario principal del sistema
                    Dim mainForm As New Menu_recepcion()
                    mainForm.Show()
                    Me.Hide()

            End Using
        End Using
    End Sub
End Class
