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
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 158)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Acceso de empleado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Location = New System.Drawing.Point(495, 252)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(157, 30)
        Me.btnInventario.TabIndex = 9
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.Location = New System.Drawing.Point(495, 351)
        Me.btnHistorial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(157, 30)
        Me.btnHistorial.TabIndex = 10
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(38, 158)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(157, 30)
        Me.btnCliente.TabIndex = 11
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 478)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnCliente As Button
End Class
