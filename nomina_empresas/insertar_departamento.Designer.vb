<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertar_departamento
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
        Me.lblRFCEmpresa = New System.Windows.Forms.Label()
        Me.lblSueldoBase = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNoGerente = New System.Windows.Forms.Label()
        Me.txtRFEmpresa = New System.Windows.Forms.TextBox()
        Me.txtSueldoBase = New System.Windows.Forms.TextBox()
        Me.txtNombreDpto = New System.Windows.Forms.TextBox()
        Me.txtNoEmpleadoGrnte = New System.Windows.Forms.TextBox()
        Me.lblAgregarDpto = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRFCEmpresa
        '
        Me.lblRFCEmpresa.AutoSize = True
        Me.lblRFCEmpresa.Location = New System.Drawing.Point(26, 102)
        Me.lblRFCEmpresa.Name = "lblRFCEmpresa"
        Me.lblRFCEmpresa.Size = New System.Drawing.Size(97, 13)
        Me.lblRFCEmpresa.TabIndex = 0
        Me.lblRFCEmpresa.Text = "RFC de la empresa"
        '
        'lblSueldoBase
        '
        Me.lblSueldoBase.AutoSize = True
        Me.lblSueldoBase.Location = New System.Drawing.Point(26, 128)
        Me.lblSueldoBase.Name = "lblSueldoBase"
        Me.lblSueldoBase.Size = New System.Drawing.Size(67, 13)
        Me.lblSueldoBase.TabIndex = 1
        Me.lblSueldoBase.Text = "Sueldo Base"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(26, 154)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblNoGerente
        '
        Me.lblNoGerente.AutoSize = True
        Me.lblNoGerente.Location = New System.Drawing.Point(26, 180)
        Me.lblNoGerente.Name = "lblNoGerente"
        Me.lblNoGerente.Size = New System.Drawing.Size(130, 13)
        Me.lblNoGerente.TabIndex = 3
        Me.lblNoGerente.Text = "No. Empleado del gerente"
        '
        'txtRFEmpresa
        '
        Me.txtRFEmpresa.Location = New System.Drawing.Point(162, 95)
        Me.txtRFEmpresa.Name = "txtRFEmpresa"
        Me.txtRFEmpresa.Size = New System.Drawing.Size(180, 20)
        Me.txtRFEmpresa.TabIndex = 4
        '
        'txtSueldoBase
        '
        Me.txtSueldoBase.Location = New System.Drawing.Point(162, 121)
        Me.txtSueldoBase.Name = "txtSueldoBase"
        Me.txtSueldoBase.Size = New System.Drawing.Size(120, 20)
        Me.txtSueldoBase.TabIndex = 5
        '
        'txtNombreDpto
        '
        Me.txtNombreDpto.Location = New System.Drawing.Point(162, 147)
        Me.txtNombreDpto.Name = "txtNombreDpto"
        Me.txtNombreDpto.Size = New System.Drawing.Size(180, 20)
        Me.txtNombreDpto.TabIndex = 6
        '
        'txtNoEmpleadoGrnte
        '
        Me.txtNoEmpleadoGrnte.Location = New System.Drawing.Point(162, 173)
        Me.txtNoEmpleadoGrnte.Name = "txtNoEmpleadoGrnte"
        Me.txtNoEmpleadoGrnte.Size = New System.Drawing.Size(180, 20)
        Me.txtNoEmpleadoGrnte.TabIndex = 7
        '
        'lblAgregarDpto
        '
        Me.lblAgregarDpto.AutoSize = True
        Me.lblAgregarDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarDpto.Location = New System.Drawing.Point(103, 36)
        Me.lblAgregarDpto.Name = "lblAgregarDpto"
        Me.lblAgregarDpto.Size = New System.Drawing.Size(134, 13)
        Me.lblAgregarDpto.TabIndex = 8
        Me.lblAgregarDpto.Text = "Agregar Departamento"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(177, 228)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(267, 228)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'insertar_departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 275)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblAgregarDpto)
        Me.Controls.Add(Me.txtNoEmpleadoGrnte)
        Me.Controls.Add(Me.txtNombreDpto)
        Me.Controls.Add(Me.txtSueldoBase)
        Me.Controls.Add(Me.txtRFEmpresa)
        Me.Controls.Add(Me.lblNoGerente)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblSueldoBase)
        Me.Controls.Add(Me.lblRFCEmpresa)
        Me.Name = "insertar_departamento"
        Me.Text = "insertar_departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRFCEmpresa As Label
    Friend WithEvents lblSueldoBase As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNoGerente As Label
    Friend WithEvents txtRFEmpresa As TextBox
    Friend WithEvents txtSueldoBase As TextBox
    Friend WithEvents txtNombreDpto As TextBox
    Friend WithEvents txtNoEmpleadoGrnte As TextBox
    Friend WithEvents lblAgregarDpto As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
