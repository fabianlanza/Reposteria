Public Class Inicio

    Dim formManager As FormManager = New FormManager

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs)
        'depending on user type (employee or client) show corresponding form 
        'employee: register & manages cakes
        'client: purchase cake/s

        'Test
        formManager.OpenForm(NuevoEmpleado, Me)

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)
        formManager.OpenForm(NuevoUsuario, Me)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
