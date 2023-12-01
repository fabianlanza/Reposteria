<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Historial
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
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistorial
        '
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial.Location = New System.Drawing.Point(7, 108)
        Me.dgvHistorial.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.RowHeadersWidth = 51
        Me.dgvHistorial.RowTemplate.Height = 24
        Me.dgvHistorial.Size = New System.Drawing.Size(607, 266)
        Me.dgvHistorial.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Crear PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 503)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Historial"
        Me.Text = "Historial"
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents Button1 As Button
End Class
