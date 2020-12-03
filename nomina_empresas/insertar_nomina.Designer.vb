<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertar_nomina
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
        Me.cbPago = New System.Windows.Forms.ComboBox()
        Me.lblNomina = New System.Windows.Forms.Label()
        Me.lblFrecuenciaPago = New System.Windows.Forms.Label()
        Me.lblNoEmpleado = New System.Windows.Forms.Label()
        Me.txtNoEmpleado = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbPago
        '
        Me.cbPago.FormattingEnabled = True
        Me.cbPago.Location = New System.Drawing.Point(154, 67)
        Me.cbPago.Name = "cbPago"
        Me.cbPago.Size = New System.Drawing.Size(121, 21)
        Me.cbPago.TabIndex = 0
        '
        'lblNomina
        '
        Me.lblNomina.AutoSize = True
        Me.lblNomina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomina.Location = New System.Drawing.Point(103, 35)
        Me.lblNomina.Name = "lblNomina"
        Me.lblNomina.Size = New System.Drawing.Size(96, 13)
        Me.lblNomina.TabIndex = 1
        Me.lblNomina.Text = "Insertar Nomina"
        '
        'lblFrecuenciaPago
        '
        Me.lblFrecuenciaPago.AutoSize = True
        Me.lblFrecuenciaPago.Location = New System.Drawing.Point(27, 75)
        Me.lblFrecuenciaPago.Name = "lblFrecuenciaPago"
        Me.lblFrecuenciaPago.Size = New System.Drawing.Size(102, 13)
        Me.lblFrecuenciaPago.TabIndex = 2
        Me.lblFrecuenciaPago.Text = "Frecuencia de pago"
        '
        'lblNoEmpleado
        '
        Me.lblNoEmpleado.AutoSize = True
        Me.lblNoEmpleado.Location = New System.Drawing.Point(27, 113)
        Me.lblNoEmpleado.Name = "lblNoEmpleado"
        Me.lblNoEmpleado.Size = New System.Drawing.Size(74, 13)
        Me.lblNoEmpleado.TabIndex = 3
        Me.lblNoEmpleado.Text = "No. Empleado"
        '
        'txtNoEmpleado
        '
        Me.txtNoEmpleado.Location = New System.Drawing.Point(154, 106)
        Me.txtNoEmpleado.Name = "txtNoEmpleado"
        Me.txtNoEmpleado.Size = New System.Drawing.Size(121, 20)
        Me.txtNoEmpleado.TabIndex = 4
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(136, 156)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblCancelar
        '
        Me.lblCancelar.Location = New System.Drawing.Point(230, 156)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Size = New System.Drawing.Size(75, 23)
        Me.lblCancelar.TabIndex = 6
        Me.lblCancelar.Text = "Cancelar"
        Me.lblCancelar.UseVisualStyleBackColor = True
        '
        'insertar_nomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 198)
        Me.Controls.Add(Me.lblCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtNoEmpleado)
        Me.Controls.Add(Me.lblNoEmpleado)
        Me.Controls.Add(Me.lblFrecuenciaPago)
        Me.Controls.Add(Me.lblNomina)
        Me.Controls.Add(Me.cbPago)
        Me.Name = "insertar_nomina"
        Me.Text = "insertar_nomina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPago As ComboBox
    Friend WithEvents lblNomina As Label
    Friend WithEvents lblFrecuenciaPago As Label
    Friend WithEvents lblNoEmpleado As Label
    Friend WithEvents txtNoEmpleado As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblCancelar As Button
End Class
