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
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistorial
        '
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial.Location = New System.Drawing.Point(12, 235)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.RowHeadersWidth = 51
        Me.dgvHistorial.RowTemplate.Height = 24
        Me.dgvHistorial.Size = New System.Drawing.Size(809, 328)
        Me.dgvHistorial.TabIndex = 0
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 619)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Name = "Historial"
        Me.Text = "Historial"
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvHistorial As DataGridView
End Class
