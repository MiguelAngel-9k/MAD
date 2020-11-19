<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertar_gerente_nomina
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
        Me.lblGerenteNomina = New System.Windows.Forms.Label()
        Me.lblRFCEmpresa = New System.Windows.Forms.Label()
        Me.txtNoEmpleado = New System.Windows.Forms.TextBox()
        Me.txtRFCEmpresa = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGerenteNomina
        '
        Me.lblGerenteNomina.AutoSize = True
        Me.lblGerenteNomina.Location = New System.Drawing.Point(11, 44)
        Me.lblGerenteNomina.Name = "lblGerenteNomina"
        Me.lblGerenteNomina.Size = New System.Drawing.Size(71, 13)
        Me.lblGerenteNomina.TabIndex = 0
        Me.lblGerenteNomina.Text = "No Empleado"
        '
        'lblRFCEmpresa
        '
        Me.lblRFCEmpresa.AutoSize = True
        Me.lblRFCEmpresa.Location = New System.Drawing.Point(11, 86)
        Me.lblRFCEmpresa.Name = "lblRFCEmpresa"
        Me.lblRFCEmpresa.Size = New System.Drawing.Size(72, 13)
        Me.lblRFCEmpresa.TabIndex = 1
        Me.lblRFCEmpresa.Text = "RFC Empresa"
        '
        'txtNoEmpleado
        '
        Me.txtNoEmpleado.Location = New System.Drawing.Point(108, 37)
        Me.txtNoEmpleado.Name = "txtNoEmpleado"
        Me.txtNoEmpleado.Size = New System.Drawing.Size(158, 20)
        Me.txtNoEmpleado.TabIndex = 2
        '
        'txtRFCEmpresa
        '
        Me.txtRFCEmpresa.Location = New System.Drawing.Point(108, 79)
        Me.txtRFCEmpresa.Name = "txtRFCEmpresa"
        Me.txtRFCEmpresa.Size = New System.Drawing.Size(158, 20)
        Me.txtRFCEmpresa.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(153, 130)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(248, 130)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'insertar_gerente_nomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 165)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtRFCEmpresa)
        Me.Controls.Add(Me.txtNoEmpleado)
        Me.Controls.Add(Me.lblRFCEmpresa)
        Me.Controls.Add(Me.lblGerenteNomina)
        Me.Name = "insertar_gerente_nomina"
        Me.Text = "Nuevo Gerente de nomina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGerenteNomina As Label
    Friend WithEvents lblRFCEmpresa As Label
    Friend WithEvents txtNoEmpleado As TextBox
    Friend WithEvents txtRFCEmpresa As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
