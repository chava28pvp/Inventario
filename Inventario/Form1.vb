Imports System.Data.SqlClient
Public Class Form1
    Public Sub limpiar()
        txtNombre.Clear()
        txtId.Clear()
        txtCantidad.Clear()
        txtPrecio.Clear()
        dtpCompra.Value = DateTime.Now
        txtId.Focus()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        limpiar()
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles mnuAgregar.Click

        Dim Agregar As New LibreriaInventario.Inventarios
        With Agregar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Cantidad = txtCantidad.Text
            .Precio = txtPrecio.Text
            .Compra = dtpCompra.Value
        End With
        If Agregar.SocAlta Then
        End If
        limpiar()


    End Sub
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles mnuEliminar.Click

        Dim Baja As New LibreriaInventario.Inventarios
        With Baja
            .Id = txtId.Text
        End With
        If Baja.SocBaja Then
        End If
        limpiar()


    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles mnuModificar.Click

        Dim Update As New LibreriaInventario.Inventarios
        With Update
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Cantidad = txtCantidad.value
            .Precio = txtPrecio.Text
            .Compra = dtpCompra.Value
        End With
        If Update.SocUpdate Then
        End If
        limpiar()

    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles mnuConsultar.Click

        Dim cnx As New SqlConnection("Server=LAPTOP-N5DD8MTE\SQLEXPRESS02; database=Inventario; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.socConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Nombre1, Cantidad1, Precio1, Compra1 As String
        cmd.Parameters.Add(New SqlParameter("@Id", txtId.Text))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            Nombre1 = leer(1).ToString
            Cantidad1 = leer(2).ToString
            Precio1 = leer(3).ToString
            Compra1 = leer(4).ToString
            txtNombre.Text = Nombre1
            txtCantidad.Text = Cantidad1
            txtPrecio.Text = Precio1
            dtpCompra.Value = Compra1
            cnx.Close()
        End If
        cnx.Close()

    End Sub
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


