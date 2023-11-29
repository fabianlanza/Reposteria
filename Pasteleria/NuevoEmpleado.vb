﻿Imports System.Data.SqlClient

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
        Limpiar() 'Limpiando los contenedores
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Inicio, Me)
        Limpiar()
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

            ' Dim selectedRow = dgvEmpleado.Rows(e.RowIndex)
            'txtNombre.Text = selectedRow.Cells("Nombre").Value.ToString()
            ' txtEmail.Text = selectedRow.Cells("Email").Value.ToString()
            'txtTelefono.Text = selectedRow.Cells("Tel").Value.ToString()


            ' Elimina al Empleado Usando la Funcion DelteFrom Table
            DeleteFromTable("Empleado", "IdEmpleado", employeeId)
        End If
    End Sub



    'Para limpiar los TextBoxs
    Private Sub Limpiar()
        txtNombre.Text = ""
        txtEmail.Text = ""
        txtTelefono.Text = ""
    End Sub






    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        ' Dim newValue1 As String = txtNombre.Text
        ' Dim newValue2 As String = txtEmail.Text
        ' Dim newValue3 As String = txtTelefono.Text


        ' Dim selectedRowIndex As Integer = dgvEmpleado.SelectedCells(0).RowIndex
        ' Dim employeeId As String = dgvEmpleado.Rows(selectedRowIndex).Cells("IdEmpleado").Value.ToString()


        ' ModificarDatos("Empleado", newValue1, newValue2, newValue3, employeeId)

        ' MsgBox("Registro Modificado correctamente")
        '  LoadData(dgvEmpleado, "Empleado")
    End Sub

End Class