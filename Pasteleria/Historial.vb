Imports iText.Layout
Imports iText.Kernel.Pdf
Imports iText.Layout.Element

Public Class Historial
    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(dgvHistorial, "Pastel")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Specify the folder path where you want to save the PDF
        Dim folderPath As String = "E:\Github\Reposteria\Pasteleria\pdf\" ' Update this with your desired folder path

        ' Specify the file name for the PDF
        Dim fileName As String = "output.pdf"

        ' Combine the folder path and file name to create the full file path
        Dim filePath As String = System.IO.Path.Combine(folderPath, fileName)

        ' Create a new PDF document
        Using pdfDoc As New PdfDocument(New PdfWriter(filePath))
            ' Create a document
            Dim document As New Document(pdfDoc)

            ' Add content to the PDF
            document.Add(New Paragraph("Hello, iText 7 in VB.NET!"))

            ' Close the document
            document.Close()
        End Using

        ' Open the generated PDF file using the default viewer
        Process.Start(filePath)
    End Sub









End Class