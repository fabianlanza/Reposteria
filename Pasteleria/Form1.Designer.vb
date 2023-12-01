<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmpleado
        '
        Me.btnEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleado.Location = New System.Drawing.Point(508, 310)
        Me.btnEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(205, 60)
        Me.btnEmpleado.TabIndex = 8
        Me.btnEmpleado.Text = "Empleado"
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.Location = New System.Drawing.Point(152, 402)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(205, 62)
        Me.btnInventario.TabIndex = 9
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.Location = New System.Drawing.Point(508, 402)
        Me.btnReportes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(205, 62)
        Me.btnReportes.TabIndex = 10
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.Location = New System.Drawing.Point(152, 310)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(205, 60)
        Me.btnCliente.TabIndex = 11
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pasteleria.My.Resources.Resources.LogoPng
        Me.PictureBox1.Location = New System.Drawing.Point(256, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 267)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pasteleria.My.Resources.Resources.Ui
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(876, 578)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
