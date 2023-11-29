Imports System.Data.SqlClient
Public Class Clientes

    Dim formManager As FormManager = New FormManager
    Dim datos As String


    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvClientes, "Cliente")
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click

        datos = " '" & txtNombre.Text & "' , '" & txtEmail.Text & "' , '" & txtTelefono.Text & "' , '" & txtDomicilio.Text & "' "

        Try
            InsertIntoTable("Cliente", datos)
            MsgBox("Datos agregados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try
        LoadData(dgvClientes, "Cliente") 'refresca El data grid para ver los nuevos empleados
        Limpiar() 'Limpiando los contenedores


    End Sub




    Private Sub btnEleminarCliente_Click(sender As Object, e As EventArgs) Handles btnEleminarCliente.Click

        If dgvClientes.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvClientes.SelectedCells(0).RowIndex
            Dim clienteId As String = dgvClientes.Rows(selectedRowIndex).Cells("IdCliente").Value.ToString()

            ' Borra al empleado seleccionado usando the ID
            DeleteFromTable("Cliente", "IdCliente", clienteId)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
        MsgBox("Registro Eliminado correctamente")
        LoadData(dgvClientes, "Cliente")


    End Sub




    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Inicio, Me)
    End Sub





    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        If e.RowIndex >= 0 Then
            Dim clienteId As String = dgvClientes.Rows(e.RowIndex).Cells("IdCliente").Value.ToString()


            ' Elimina al Empleado Usando la Funcion DelteFrom Table
            DeleteFromTable("Cliente", "IdCliente", clienteId)
        End If
    End Sub





    Private Sub Limpiar()
        txtNombre.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
        txtDomicilio.Text = ""
    End Sub


End Class