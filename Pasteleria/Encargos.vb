Imports System.Data.SqlClient

Public Class Encargos
    Dim formManager As New FormManager

    Dim connect As String = "Data Source=LAPTOP-S8ASBQKS;Initial Catalog=SistemaPasteleria;Integrated Security=True"


    Private Sub Encargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadPastelEncargo()
            LoadEmpleados()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar datos: {ex.Message}")
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If cmbEmpleado.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtTipoPastel.Text) AndAlso Integer.TryParse(txtCantidad.Text, Nothing) Then
                Dim empleadoItem As KeyValuePair(Of Integer, String) = DirectCast(cmbEmpleado.SelectedItem, KeyValuePair(Of Integer, String))
                Dim idEmpleado As Integer = empleadoItem.Key
                Dim tipo As String = txtTipoPastel.Text
                Dim cantidad As Integer = Convert.ToInt32(txtCantidad.Text)

                Using connection As New SqlConnection(connect)
                    connection.Open()

                    ' INSERT INTO PastelEncargo
                    Dim insertPastelEncargoQuery As String = "INSERT INTO PastelEncargo (IdEmpleado, Tipo, Cantidad) VALUES (@IdEmpleado, @Tipo, @Cantidad)"

                    Using cmd As New SqlCommand(insertPastelEncargoQuery, connection)
                        cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                        cmd.Parameters.AddWithValue("@Tipo", tipo)
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Datos agregados!")
                    LoadPastelEncargo()
                End Using
            Else
                MessageBox.Show("Error: Los espacios no pueden estar vacíos.")
            End If
        Catch ex As SqlException
            MessageBox.Show($"Error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub




    'Empleado combobox
    Private Sub LoadEmpleados()
        cmbEmpleado.Items.Clear()
        Using connection As New SqlConnection(connect)
            connection.Open()
            Dim query As String = "SELECT IdEmpleado, Nombre FROM Empleado"
            Using cmd As New SqlCommand(query, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbEmpleado.Items.Add(New KeyValuePair(Of Integer, String)(CInt(reader("IdEmpleado")), reader("Nombre").ToString()))
                    End While
                End Using
            End Using
        End Using
    End Sub

    'PastelEncargo table
    Private Sub LoadPastelEncargo()
        Using connection As New SqlConnection(connect)
            connection.Open()

            Dim query As String = "SELECT PastelEncargo.IdPastelEncargo, PastelEncargo.IdEmpleado, PastelEncargo.Tipo AS PastelTipo, PastelEncargo.Cantidad FROM PastelEncargo INNER JOIN Empleado ON PastelEncargo.IdEmpleado = Empleado.IdEmpleado"

            Using cmd As New SqlCommand(query, connection)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    dgvEncargos.DataSource = dataTable
                End Using
            End Using
        End Using
    End Sub


End Class