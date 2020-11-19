<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniciarSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtNoEmpleado = New System.Windows.Forms.TextBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.cbAcceso = New System.Windows.Forms.ComboBox()
        Me.btnInicarSesion = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblNoEmpleado = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.lblAcceso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(125, 49)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(68, 13)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Iniciar sesión"
        '
        'txtNoEmpleado
        '
        Me.txtNoEmpleado.Location = New System.Drawing.Point(143, 102)
        Me.txtNoEmpleado.Name = "txtNoEmpleado"
        Me.txtNoEmpleado.Size = New System.Drawing.Size(150, 20)
        Me.txtNoEmpleado.TabIndex = 1
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(143, 148)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenia.Size = New System.Drawing.Size(150, 20)
        Me.txtContrasenia.TabIndex = 2
        '
        'cbAcceso
        '
        Me.cbAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAcceso.FormattingEnabled = True
        Me.cbAcceso.Location = New System.Drawing.Point(143, 194)
        Me.cbAcceso.Name = "cbAcceso"
        Me.cbAcceso.Size = New System.Drawing.Size(150, 21)
        Me.cbAcceso.TabIndex = 3
        '
        'btnInicarSesion
        '
        Me.btnInicarSesion.Location = New System.Drawing.Point(43, 253)
        Me.btnInicarSesion.Name = "btnInicarSesion"
        Me.btnInicarSesion.Size = New System.Drawing.Size(75, 23)
        Me.btnInicarSesion.TabIndex = 4
        Me.btnInicarSesion.Text = "Aceptar"
        Me.btnInicarSesion.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(188, 253)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblNoEmpleado
        '
        Me.lblNoEmpleado.AutoSize = True
        Me.lblNoEmpleado.Location = New System.Drawing.Point(33, 109)
        Me.lblNoEmpleado.Name = "lblNoEmpleado"
        Me.lblNoEmpleado.Size = New System.Drawing.Size(93, 13)
        Me.lblNoEmpleado.TabIndex = 6
        Me.lblNoEmpleado.Text = "Número empleado"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(33, 155)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(61, 13)
        Me.lblContrasenia.TabIndex = 7
        Me.lblContrasenia.Text = "Contraseña"
        '
        'lblAcceso
        '
        Me.lblAcceso.AutoSize = True
        Me.lblAcceso.Location = New System.Drawing.Point(33, 202)
        Me.lblAcceso.Name = "lblAcceso"
        Me.lblAcceso.Size = New System.Drawing.Size(64, 13)
        Me.lblAcceso.TabIndex = 8
        Me.lblAcceso.Text = "Iniciar como"
        '
        'IniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(325, 303)
        Me.Controls.Add(Me.lblAcceso)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblNoEmpleado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnInicarSesion)
        Me.Controls.Add(Me.cbAcceso)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtNoEmpleado)
        Me.Controls.Add(Me.lblLogin)
        Me.Name = "IniciarSesion"
        Me.Text = "Iniciar Sesíon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents txtNoEmpleado As TextBox
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents cbAcceso As ComboBox
    Friend WithEvents btnInicarSesion As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblNoEmpleado As Label
    Friend WithEvents lblContrasenia As Label
    Friend WithEvents lblAcceso As Label
End Class
