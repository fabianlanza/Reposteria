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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(381, 252)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 49)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Empleado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.Location = New System.Drawing.Point(114, 327)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(154, 50)
        Me.btnInventario.TabIndex = 9
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.Location = New System.Drawing.Point(381, 327)
        Me.btnHistorial.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(154, 50)
        Me.btnHistorial.TabIndex = 10
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.Location = New System.Drawing.Point(114, 252)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(154, 49)
        Me.btnCliente.TabIndex = 11
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pasteleria.My.Resources.Resources.LogoPng
        Me.PictureBox1.Location = New System.Drawing.Point(30, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 470)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
