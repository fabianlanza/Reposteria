Imports System.Data.SqlClient

Public Class NuevoUsuario

    Dim formManager As New FormManager

    Dim datos As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        datos = " '" & txtEmail.Text & "' , '" & txtUsuario.Text & "' , '" & txtNombre.Text & "' , '" & txtTelefono.Text & "', '" & txtDireccion.Text & "' , '" & txtPass.Text & "' "

        Try
            InsertIntoTable("Cliente", datos)
            MsgBox("Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            formManager.OpenForm(MenuCliente, Me)

        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try

    End Sub


End Class