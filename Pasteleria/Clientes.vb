Public Class Clientes

    Dim formManager As FormManager = New FormManager

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvClientes, "Cliente")
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click

    End Sub

    Private Sub btnEleminarCliente_Click(sender As Object, e As EventArgs) Handles btnEleminarCliente.Click
        'Idea: Elimiar cliente por medio de la seleccion del ID del cliente(IdCliente) usando la funcion DeleteFromTable 
        Dim ID As Integer
        InputBox("Ingrese el ID del cliente a elimnar", "Eliminar cliente", ID)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Inicio, Me)
    End Sub
End Class