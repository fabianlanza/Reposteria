Imports iText.Layout.Element
Imports System.Data.SqlClient

Public Class Ventas

    Dim detalleVenta As String = "DetalleVenta"
    Dim formManager As New FormManager()

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Try
        'OpenConnection()
        'Dim cmd As New SqlCommand($"DECLARE @Mes int = '1'; SELECT P.Tipo AS TipoPastel, SUM(DV.Cantidad) AS CantidadVendida From VentaPastel VP JOIN {detalleVenta} DV ON VP.IdVenta = DV.IdVenta JOIN Pastel P ON DV.IdPastel = P.IdPastel WHERE MONTH(VP.Fecha) = @Mes GROUP BY P.Tipo;", connect)
        'Dim da As New SqlDataAdapter()
        'da.SelectCommand = cmd
        'Dim dt As New DataTable()
        'da.Fill(dt)
        'dgvVentas.DataSource = dt
        'cmd.ExecuteNonQuery()

        'Catch ex As Exception
        'MessageBox.Show("Unable to load data: '" & ex.Message)
        'Finally
        'CloseConnection()
        'End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Inicio, Me)
    End Sub
End Class