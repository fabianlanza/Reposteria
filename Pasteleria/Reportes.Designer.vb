<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbReporte = New System.Windows.Forms.ComboBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 236)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Crear PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbReporte
        '
        Me.cmbReporte.FormattingEnabled = True
        Me.cmbReporte.Items.AddRange(New Object() {"Mostrar Clientes", "Mostrar Pasteles", "Ventas Por Mes"})
        Me.cmbReporte.Location = New System.Drawing.Point(323, 171)
        Me.cmbReporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbReporte.Name = "cmbReporte"
        Me.cmbReporte.Size = New System.Drawing.Size(160, 24)
        Me.cmbReporte.TabIndex = 2
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(599, 521)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(168, 47)
        Me.btnRegresar.TabIndex = 3
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pasteleria.My.Resources.Resources.Ui_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(833, 619)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cmbReporte)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbReporte As ComboBox
    Friend WithEvents btnRegresar As Button
End Class
