<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.btnEleminarCliente = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(12, 110)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersWidth = 51
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.Size = New System.Drawing.Size(584, 328)
        Me.dgvClientes.TabIndex = 0
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(624, 110)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(125, 28)
        Me.btnAgregarCliente.TabIndex = 1
        Me.btnAgregarCliente.Text = "Agregar cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'btnEleminarCliente
        '
        Me.btnEleminarCliente.Location = New System.Drawing.Point(624, 178)
        Me.btnEleminarCliente.Name = "btnEleminarCliente"
        Me.btnEleminarCliente.Size = New System.Drawing.Size(125, 28)
        Me.btnEleminarCliente.TabIndex = 2
        Me.btnEleminarCliente.Text = "Eliminar Cliente"
        Me.btnEleminarCliente.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(624, 317)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(79, 28)
        Me.btnRegresar.TabIndex = 3
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnEleminarCliente)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnEleminarCliente As Button
    Friend WithEvents btnRegresar As Button
End Class
