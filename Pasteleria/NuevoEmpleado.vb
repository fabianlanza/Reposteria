Public Class NuevoEmpleado

    Dim formManager As New FormManager()

    Dim datos As String
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        datos = " '" & txtEmail.Text & "' , '" & txtNombre.Text & "' , '" & txtTelefono.Text & "' , '" & txtPass.Text & "'"

        Try
            InsertIntoTable("EmployeeData", datos)
            MsgBox("Datos agregados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Login, Me)
    End Sub
End Class