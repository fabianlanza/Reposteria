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
        LoadData(dgvEmpleado, "Empleado")
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Inicio, Me)
    End Sub

    Private Sub NuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvEmpleado, "Empleado")
    End Sub
End Class