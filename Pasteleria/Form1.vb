Public Class Inicio

    Dim formManager As FormManager = New FormManager

    'Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs)
    'formManager.OpenForm(NuevoEmpleado, Me)
    'NuevoEmpleado.Show()
    'Me.Hide()

    'End Sub

    'Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)
    ' formManager.OpenForm(NuevoUsuario, Me)
    ' NuevoUsuario.Show()
    'Me.Hide()
    ' End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        formManager.OpenForm(Clientes, Me)
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        formManager.OpenForm(NuevoEmpleado, Me)
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        formManager.OpenForm(Inventario, Me)
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        formManager.OpenForm(Reportes, Me)
    End Sub


    'change button color when hover over it
    Private Sub btnCliente_MouseHover(sender As Object, e As EventArgs) Handles btnCliente.MouseHover
        btnCliente.BackColor = Color.LightCoral
        btnCliente.ForeColor = Color.White
    End Sub

    Private Sub btnCliente_MouseLeave(sender As Object, e As EventArgs) Handles btnCliente.MouseLeave
        btnCliente.BackColor = Color.White
        btnCliente.ForeColor = Color.Black
    End Sub


End Class
