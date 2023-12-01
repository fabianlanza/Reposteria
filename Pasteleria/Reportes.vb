Imports iText.Layout
Imports iText.Kernel.Pdf
Imports iText.Layout.Element
Imports System.IO
Imports System.Data.SqlClient


Public Class Reportes
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadData(dgvHistorial, "Pastel")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Query SQL para seleccionar datos de la tabla "cliente"
            Dim query As String = "SELECT * FROM Cliente"

            ' Obtener los datos de la base de datos utilizando la función LoadData de tu módulo 'Conexion'
            Dim data As String = GetDataFromDatabase(query)

            ' Obtener la ruta de la carpeta Descargas
            Dim downloadsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            downloadsPath = Path.Combine(downloadsPath, "Downloads")

            ' Ruta del archivo PDF
            Dim filePath As String = Path.Combine(downloadsPath, "clientes.pdf")

            ' Crear un nuevo documento PDF en la carpeta Descargas
            Using pdfDoc As New PdfDocument(New PdfWriter(filePath))
                ' Crear un documento
                Dim document As New Document(pdfDoc)

                ' Agregar los datos obtenidos de la base de datos al PDF como un párrafo
                document.Add(New Paragraph(data))

                ' Cerrar el documento
                document.Close()
            End Using

            ' Abrir el archivo PDF generado con el visor predeterminado
            Process.Start(filePath)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub





    Private Function GetDataFromDatabase(query As String) As String
        Dim data As String = ""

        Try
            ' Crear la conexión a la base de datos utilizando tu conexión existente
            Using connection As New SqlConnection(Conexion.connect.ConnectionString)
                ' Abrir la conexión
                connection.Open()

                ' Crear el comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Ejecutar el comando y obtener los datos
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Leer los datos y almacenarlos en la cadena 'data'
                        While reader.Read()
                            ' Supongamos que los datos están en columnas "Nombre" y "Apellido"
                            data &= "Nombre: " & reader("Nombre").ToString() & ", Email: " & reader("Email").ToString() & vbCrLf
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos de la base de datos: " & ex.Message)
        End Try

        Return data
    End Function











End Class