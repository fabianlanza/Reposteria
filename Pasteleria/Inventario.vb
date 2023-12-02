Imports System.Data.SqlClient

Public Class Inventario
    Dim formManager As FormManager = New FormManager
    Dim datos As String

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvInventario, "Pastel")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If (txtTipoPastel.Text = String.Empty Or txtCosto.Text = String.Empty Or txtCantidad.Text = String.Empty) Then
            MessageBox.Show("Los espacios no pueden estar en blanco")
        Else
            Dim dataTable As DataTable = DirectCast(dgvInventario.DataSource, DataTable)

            Dim duplicateRows As DataRow() = dataTable.Select("Tipo = '" & txtTipoPastel.Text & "' OR Costo = '" & txtCosto.Text & "' OR Cantidad = '" & txtCantidad.Text & "' ")

            If duplicateRows.Length > 0 Then
                MessageBox.Show("Ya existe un dato ingresado")
            Else
                datos = " '" & txtTipoPastel.Text & "' , '" & txtCosto.Text & "' , '" & txtCantidad.Text & "' "

                Try
                    InsertIntoTable("Pastel", datos)
                    MsgBox("Datos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error inserting data: " & ex.Message)
                End Try

                LoadData(dgvInventario, "Pastel")
                Limpiar()
            End If
        End If
    End Sub




    Private Sub Limpiar()
        txtTipoPastel.Text = ""
        txtCosto.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If dgvInventario.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvInventario.SelectedCells(0).RowIndex
            Dim pastelId As String = dgvInventario.Rows(selectedRowIndex).Cells("IdPastel").Value.ToString()

            ' Borra al empleado seleccionado usando the ID
            DeleteFromTable("Pastel", "IdPastel", pastelId)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
        MsgBox("Registro Eliminado correctamente")
        LoadData(dgvInventario, "Pastel")
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Inicio, Me)
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellContentClick
        If e.RowIndex >= 0 Then
            Dim pastelId As String = dgvInventario.Rows(e.RowIndex).Cells("IdPastel").Value.ToString()


            ' Elimina al TipoPastel Usando la Funcion DelteFrom Table
            DeleteFromTable("Pastel", "IdPastel", pastelId)
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim id As Integer = Convert.ToInt32(dgvInventario.SelectedCells(0).Value)


        Dim query As String = "UPDATE Pastel SET Tipo = @Tipo, Costo = @Costo, Cantidad = @Cantidad WHERE IdPastel = @IdPastel"

        Using cmd As New SqlCommand(query, connect)

            cmd.Parameters.AddWithValue("@Tipo", txtTipoPastel.Text)
            cmd.Parameters.AddWithValue("@Costo", txtCosto.Text)
            cmd.Parameters.AddWithValue("@Cantidad", txtCantidad.Text)
            cmd.Parameters.AddWithValue("@IdPastel", id)

            Try
                OpenConnection()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro actualizado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End Using
        LoadData(dgvInventario, "Pastel")
    End Sub

    Private Sub dgvInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellClick
        'get table column values to textboxes
        Dim index As Integer
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvInventario.Rows(index)

        txtTipoPastel.Text = selectedRow.Cells(1).Value.ToString
        txtCosto.Text = selectedRow.Cells(2).Value.ToString
        txtCantidad.Text = selectedRow.Cells(3).Value.ToString

    End Sub
End Class