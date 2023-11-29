Public Class Inventario
    Dim formManager As FormManager = New FormManager
    Dim datos As String

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvInventario, "Pastel")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        datos = " '" & txtTipoPastel.Text & "' , '" & txtCosto.Text & "' , '" & txtCantidad.Text & "' "

        Try
            InsertIntoTable("Pastel", datos)
            MsgBox("Datos agregados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try

        LoadData(dgvInventario, "Pastel")
        Limpiar()
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


            ' Elimina al Empleado Usando la Funcion DelteFrom Table
            DeleteFromTable("Pastel", "IdPastel", pastelId)
        End If
    End Sub



End Class