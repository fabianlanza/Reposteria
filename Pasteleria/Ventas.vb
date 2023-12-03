Imports System.Data.SqlClient

Public Class Ventas

    Dim formManager As New FormManager

    Dim connectionString As String = "Data Source=LAPTOP-S8ASBQKS;Initial Catalog=SistemaPasteleria;Integrated Security=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVentasPastelData()
        LoadTipoPastel()
        LoadClientes()
        LoadEmpleados()
    End Sub

    Private Sub LoadTipoPastel()
        cmbPastel.Items.Clear() ' Clear existing items before populating
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT DISTINCT Tipo FROM Pastel"
            Using cmd As New SqlCommand(query, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbPastel.Items.Add(reader("Tipo").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadClientes()
        cmbNombreCliente.Items.Clear()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT IdCliente, Nombre FROM Cliente"
            Using cmd As New SqlCommand(query, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbNombreCliente.Items.Add(New KeyValuePair(Of Integer, String)(CInt(reader("IdCliente")), reader("Nombre").ToString()))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadEmpleados()
        cmbIdEmpleado.Items.Clear()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT IdEmpleado, Nombre FROM Empleado"
            Using cmd As New SqlCommand(query, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbIdEmpleado.Items.Add(New KeyValuePair(Of Integer, String)(CInt(reader("IdEmpleado")), reader("Nombre").ToString()))
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim tipoPastel As String = cmbPastel.Text
            Dim clienteId As Integer = DirectCast(cmbNombreCliente.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim empleadoId As Integer = DirectCast(cmbIdEmpleado.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim cantidad As Integer

            If Integer.TryParse(txtCantidad.Text, cantidad) AndAlso cantidad > 0 Then
                Dim total As Decimal = GetTotalCost(tipoPastel, cantidad)

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO VentaPastel (IdCliente, IdEmpleado, Fecha, Total) VALUES (@IdCliente, @IdEmpleado, @Fecha, @Total)"
                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@IdCliente", clienteId)
                        cmd.Parameters.AddWithValue("@IdEmpleado", empleadoId)
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now)
                        cmd.Parameters.AddWithValue("@Total", total)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Data inserted into VentaPastel table.")
                LoadVentasPastelData() ' Refresh the DataGridView after insertion
                LoadClientes() ' Refresh the Cliente combo box
                LoadEmpleados() ' Refresh the Empleado combo box

                ' Clear input fields
                txtCantidad.Clear()
                txtTotal.Clear()
                cmbPastel.SelectedIndex = -1
                cmbNombreCliente.SelectedIndex = -1
                cmbIdEmpleado.SelectedIndex = -1
            Else
                MessageBox.Show("Please enter a valid quantity.")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadVentasPastelData()
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT VentaPastel.IdVenta, VentaPastel.IdCliente, Cliente.Nombre AS ClienteNombre, VentaPastel.IdEmpleado, VentaPastel.Fecha, VentaPastel.total, Pastel.IdPastel, Pastel.Tipo AS TipoPastel FROM VentaPastel INNER JOIN Cliente ON VentaPastel.IdCliente = Cliente.IdCliente LEFT JOIN DetalleVenta ON VentaPastel.IdDetalleVenta = DetalleVenta.IdDetalleVenta LEFT JOIN Pastel ON DetalleVenta.IdPastel = Pastel.IdPastel"

            Using cmd As New SqlCommand(query, connection)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    dgvVentas.DataSource = dataTable
                End Using
            End Using
        End Using
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        UpdateTotal()
    End Sub


    Private Sub UpdateTotal()
        ' Calculate and update the 'Total' TextBox
        If Decimal.TryParse(txtCantidad.Text, Nothing) Then
            Dim cantidad As Decimal = Decimal.Parse(txtCantidad.Text)
            Dim tipoPastel As String = cmbPastel.Text
            Dim total As Decimal = GetTotalCost(tipoPastel, cantidad)
            txtTotal.Text = total.ToString("C") ' Format as currency or adjust as needed
        Else
            txtTotal.Text = String.Empty ' Clear the 'Total' TextBox if 'Cantidad' is not a valid decimal
        End If
    End Sub

    Private Function GetTotalCost(tipoPastel As String, cantidad As Decimal) As Decimal
        ' Calculate the total cost based on Pastel.Costo and DetalleVenta.Cantidad
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Costo FROM Pastel WHERE Tipo = @Tipo"
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Tipo", tipoPastel)
                Dim costo As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                Return costo * cantidad
            End Using
        End Using
    End Function

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FormManager.OpenForm(Inicio, Me)
    End Sub
End Class
