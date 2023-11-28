Public Class NuevoEmpleado

    Dim formManager As New FormManager()

    Dim datos As String
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        datos = " '" & txtNombre.Text & "' , '" & txtEmail.Text & "' , '" & txtTelefono.Text & "' "

        Try
            InsertIntoTable("Empleado", datos)
            MsgBox("Datos agregados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try
        LoadData(dgvEmpleado, "Empleado") 'refresca El data grid para ver los nuevos empleados
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Inicio, Me)
    End Sub

    Private Sub NuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvEmpleado, "Empleado")
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If dgvEmpleado.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvEmpleado.SelectedCells(0).RowIndex
            Dim employeeId As String = dgvEmpleado.Rows(selectedRowIndex).Cells("IdEmpleado").Value.ToString()

            ' Borra al empleado seleccionado usando the ID
            DeleteFromTable("Empleado", "IdEmpleado", employeeId)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
        MsgBox("Registro Eliminado correctamente")
        LoadData(dgvEmpleado, "Empleado")
    End Sub

    Private Sub dgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellContentClick
        If e.RowIndex >= 0 Then
            Dim employeeId As String = dgvEmpleado.Rows(e.RowIndex).Cells("IdEmpleado").Value.ToString()

            ' Elimina al Empleado Usando la Funcion DelteFrom Table
            DeleteFromTable("Empleado", "IdEmpleado", employeeId)
        End If
    End Sub


End Class