<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Cliente
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.txtPassw = New System.Windows.Forms.TextBox()
        Me.btnUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.btnInicioSesion)
        Me.Panel1.Controls.Add(Me.txtPassw)
        Me.Panel1.Controls.Add(Me.btnUsuario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(28, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 314)
        Me.Panel1.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(10, 35)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(113, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(71, 230)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(90, 24)
        Me.btnRegistrar.TabIndex = 5
        Me.btnRegistrar.Text = "Registrase"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.Location = New System.Drawing.Point(71, 188)
        Me.btnInicioSesion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(90, 24)
        Me.btnInicioSesion.TabIndex = 0
        Me.btnInicioSesion.Text = "Iniciar Sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = True
        '
        'txtPassw
        '
        Me.txtPassw.Location = New System.Drawing.Point(10, 88)
        Me.txtPassw.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassw.Name = "txtPassw"
        Me.txtPassw.Size = New System.Drawing.Size(113, 20)
        Me.txtPassw.TabIndex = 4
        '
        'btnUsuario
        '
        Me.btnUsuario.AutoSize = True
        Me.btnUsuario.Location = New System.Drawing.Point(8, 20)
        Me.btnUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(43, 13)
        Me.btnUsuario.TabIndex = 1
        Me.btnUsuario.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contraseña"
        '
        'IS_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 392)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "IS_Cliente"
        Me.Text = "IS_Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents txtPassw As TextBox
    Friend WithEvents btnUsuario As Label
    Friend WithEvents Label1 As Label
End Class
