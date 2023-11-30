Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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

    'Mostrar los datos dentro de un DataGridView en TextBoxes
    'Error when selecting column name
    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick

        Dim index As Integer
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvClientes.Rows(index)

        txtNombre.Text = selectedRow.Cells(1).Value.ToString
        txtEmail.Text = selectedRow.Cells(2).Value.ToString
        txtTelefono.Text = selectedRow.Cells(3).Value.ToString
        txtDomicilio.Text = selectedRow.Cells(4).Value.ToString

    End Sub



    'ERROR
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim query As String = $"UPDATE Cliente SET  Nombre = {txtNombre.Text}, Email = {txtEmail.Text}, Tel = {txtTelefono.Text}, Domicilio = {txtDomicilio.Text}"

        UpdateTable(query)
        'Dim column As String = "Nombre" & "Email" & "Tel" & "Domicilio"
        'Dim selectedRowIndex As Integer
        'If dgvClientes.SelectedCells.Count > 0 Then
        'selectedRowIndex = dgvClientes.SelectedCells(0).RowIndex
        'End If


    End Sub
End Class