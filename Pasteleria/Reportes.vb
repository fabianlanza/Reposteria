Imports iText.Layout
Imports iText.Kernel.Pdf
Imports iText.Layout.Element
Imports System.IO

Public Class Reportes
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadData(dgvHistorial, "Pastel")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim tempFolderPath As String = Path.GetTempPath()

            ' Combinar la ruta temporal con el nombre del archivo PDF
            Dim filePath As String = Path.Combine(tempFolderPath, "output.pdf")

            ' Crear un nuevo documento PDF en la carpeta temporal
            Using pdfDoc As New PdfDocument(New PdfWriter(filePath))
                ' Crear un documento
                Dim document As New Document(pdfDoc)

                ' Agregar contenido al PDF
                document.Add(New Paragraph("Hello World!"))

                ' Cerrar el documento
                document.Close()
            End Using

            ' Abrir el archivo PDF generado con el visor predeterminado
            Process.Start(filePath)

        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message)
        End Try
    End Sub

















End Class