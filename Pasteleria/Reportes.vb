Imports iText.Layout
Imports iText.Kernel.Pdf
Imports iText.Layout.Element
Imports System.IO
Imports System.Data.SqlClient
Imports iText.IO.Image
Imports iText.Layout.Properties

Public Class Reportes
    Dim formManager As New FormManager()

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadData(dgvHistorial, "Pastel")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sentencia As String = ""
        Dim Header As String = ""


        ' Aquí establecemos la consulta SQL según la opción seleccionada en el ComboBox
        If cmbReporte.SelectedItem.ToString() = "Mostrar Clientes" Then
            sentencia = "SELECT * FROM Cliente"
            Header = "Mostrar Clientes" 'Cambiar titulo y sentencias por las que usaremos
        ElseIf cmbReporte.SelectedItem.ToString() = "Mostrar Pasteles" Then
            sentencia = "SELECT Tipo, Cantidad FROM Pastel WHERE Cantidad > 0;"
            Header = "Mostrar Pasteles"
        End If

        Try
            ' Obtener la ruta de la imagen relativa al directorio actual
            Dim imagePath As String = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Img", "Logo.jpg")

            ' Mostrar la ruta de la imagen para verificar
            'MessageBox.Show("Ruta de la imagen: " & imagePath)
            'MessageBox.Show("Directorio de trabajo: " & Application.StartupPath)

            ' Query SQL para seleccionar todos los datos de la tabla "Clientes"
            Dim query As String = sentencia ' Cambiar aquí por la tabla y columnas deseadas

            ' Obtener los datos de la base de datos utilizando la función GetDataFromDatabase con la consulta específica
            Dim data As String = GetDataFromDatabase(sentencia)

            ' Obtener la ruta de la carpeta Descargas
            Dim downloadsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            downloadsPath = Path.Combine(downloadsPath, "Downloads")

            ' Ruta del archivo PDF
            Dim filePath As String = Path.Combine(downloadsPath, "Reporte.pdf")

            ' Crear un nuevo documento PDF en la carpeta Descargas
            Using pdfDoc As New PdfDocument(New PdfWriter(filePath))

                Dim document As New Document(pdfDoc)

                ' Cargar la imagen desde la ruta especificada
                Dim image As New iText.Layout.Element.Image(ImageDataFactory.Create(imagePath))

                ' Ajustar tamaño de la imagen si es necesario
                image.SetWidth(100) ' Ajustar el ancho de la imagen según tus necesidades
                image.SetHeight(100) ' Ajustar la altura de la imagen según tus necesidades
                image.SetHorizontalAlignment(HorizontalAlignment.CENTER)
                ' Agregar la imagen al PDF
                document.Add(image)

                'titulo
                Dim titulo As New Paragraph(Header)
                titulo.SetFontSize(24)
                titulo.SetTextAlignment(TextAlignment.CENTER)
                document.Add(titulo)


                'Fecha
                Dim fechaActual As String = DateTime.Now.ToString("dd/MM/yyyy")
                Dim fechaTexto As New Paragraph("Fecha: " & fechaActual)
                fechaTexto.SetFontSize(12) ' Tamaño del texto de la fecha
                fechaTexto.SetTextAlignment(TextAlignment.RIGHT)
                ' Agregamos la fecha al documento
                document.Add(fechaTexto)




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

                ' Crea el comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Ejecuta el comando y obtener los datos
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Lee los datos y almacenarlos en la cadena 'data'
                        While reader.Read()
                            ' Verifica la consulta y construye la cadena 'data' según los campos específicos
                            If query.Contains("Cliente") Then
                                ' Si la consulta es para clientes, muestra los datos de Nombre y Email
                                data &= "Nombre De Cliente: " & reader("Nombre").ToString() & ", Email: " & reader("Email").ToString() & vbCrLf
                            ElseIf query.Contains("Pastel") Then
                                ' Si la consulta es para pasteles, muestra los datos de Tipo y Cantidad
                                data &= "Tipo: " & reader("Tipo").ToString() & ", Cantidad: " & reader("Cantidad").ToString() & vbCrLf
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos de la base de datos: " & ex.Message)
        End Try

        Return data
    End Function

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        formManager.OpenForm(Inicio, Me)
    End Sub
End Class