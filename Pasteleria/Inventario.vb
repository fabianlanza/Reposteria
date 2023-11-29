Public Class Inventario
    Dim formManager As FormManager = New FormManager
    Dim datos As String

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvInventario, "Pastel")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        datos = " '" & txtTipoPastel.Text & "' , '" & txtCosto.Text & "' , '" & txtCantidad.Text & "' "

        Try
            InsertIntoTable("Pastel", datos)
            MsgBox("Datos agregados!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try

        LoadData(dgvInventario, "Pastel")
        Limpiar()
    End Sub



    Private Sub Limpiar()
        txtTipoPastel.Text = ""
        txtCosto.Text = ""
        txtCantidad.Text = ""

    End Sub

End Class