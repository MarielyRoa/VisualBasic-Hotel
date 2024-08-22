Imports System.Data.SqlClient

Public Class Menu_recepcion
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click


        MessageBox.Show("Bienvenido")
        ' Abre el formulario principal del sistema
        Dim mainForm As New Clientes()
        Clientes.Show()
        Me.Hide()


    End Sub

    Private Sub HabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabitacionesToolStripMenuItem.Click
        MessageBox.Show("Bienvenido")
        ' Abre el formulario principal del sistema
        Dim mainForm As New Habitaciones()
        Habitaciones.Show()
        Me.Hide()
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click
        MessageBox.Show("Bienvenido")
        ' Abre el formulario principal del sistema
        Dim mainForm As New Reservas()
        Reservas.Show()
        Me.Hide()
    End Sub
End Class