Imports System.Data.SqlClient

Public Class Ventas

    Dim connectionString As String = "Data Source=LAPTOP-S8ASBQKS;Initial Catalog=SistemaPasteleria;Integrated Security=True"
    Dim connection As SqlConnection


    Dim datos As String

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the SqlConnection
        connection = New SqlConnection(connectionString)

        ' Load data into DataGridView
        DataLoad()
    End Sub

    Private Sub DataLoad()
        Try
            ' Open the connection
            connection.Open()

            ' SQL query with JOIN clauses to combine data from different tables
            Dim query As String = "SELECT Pastel.IdPastel, Pastel.Cantidad, Cliente.IdCliente, Cliente.Nombre, VentaPastel.total " &
                                  "FROM Pastel " &
                                  "INNER JOIN DetalleVenta ON Pastel.IdPastel = DetalleVenta.IdPastel " &
                                  "INNER JOIN VentaPastel ON DetalleVenta.IdVenta = VentaPastel.IdVenta " &
                                  "INNER JOIN Cliente ON VentaPastel.IdCliente = Cliente.IdCliente"

            ' Create a SqlDataAdapter to execute the query
            Dim adapter As New SqlDataAdapter(query, connection)

            ' Create a DataTable to store the result
            Dim dataTable As New DataTable()

            ' Fill the DataTable with the result of the query
            adapter.Fill(dataTable)

            ' Bind the DataTable to the DataGridView
            dgvVentas.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If (txtTipoPastel.Text = String.Empty Or txtCantidad.Text = String.Empty Or txtIdCliente.Text = String.Empty Or txtNombreCliente.Text = String.Empty Or txtTotal.Text = String.Empty) Then
            MessageBox.Show("Los espacios no pueden estar en blanco")
        Else
            ' Check if the record already exists in the Cliente table
            Dim clienteExists As Boolean = CheckClienteExists(txtIdCliente.Text)

            If clienteExists Then
                MessageBox.Show("Ya existe un cliente con el mismo IdCliente")
            Else
                Dim datos As String = " '" & txtTipoPastel.Text & "' , '" & txtCantidad.Text & "' , '" & txtIdCliente.Text & "' , '" & txtNombreCliente.Text & "', '" & txtTotal.Text & "' "

                Try
                    InsertIntoTable("VentaPastel", datos)
                    MsgBox("Datos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error inserting data: " & ex.Message)
                End Try

                DataLoad() ' Assuming you want to reload data into the DataGridView, update accordingly
                Limpiar()
            End If
        End If
    End Sub

    Private Function CheckClienteExists(idCliente As String) As Boolean
        ' Check if a record with the given IdCliente already exists in the Cliente table
        Dim query As String = "SELECT COUNT(*) FROM Cliente WHERE IdCliente = '" & idCliente & "'"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)

        Try
            connection.Open()
            Dim count As Integer = CInt(command.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show("Error checking Cliente existence: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function



    Private Sub Limpiar()
        txtTipoPastel.Text = ""
        txtCantidad.Text = ""
        txtIdCliente.Text = ""
        txtNombreCliente.Text = ""
        txtTotal.Text = ""
    End Sub

End Class
