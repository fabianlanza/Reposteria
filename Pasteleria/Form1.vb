Public Class Inicio

    Dim formManager As FormManager = New FormManager

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs)
        formManager.OpenForm(NuevoEmpleado, Me)
        NuevoEmpleado.Show()
        Me.Hide()

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)
        formManager.OpenForm(NuevoUsuario, Me)
        NuevoUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formManager.OpenForm(NuevoEmpleado, Me)
    End Sub
End Class
