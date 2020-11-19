<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertar_puesto
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
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblSueldoEsp = New System.Windows.Forms.Label()
        Me.lblnivelSalarial = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblPuesto = New System.Windows.Forms.Label()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.txtSueldoEsp = New System.Windows.Forms.TextBox()
        Me.txtNSalarial = New System.Windows.Forms.TextBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblRFCEmpresa = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(22, 165)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.lblEmpresa.TabIndex = 0
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblSueldoEsp
        '
        Me.lblSueldoEsp.AutoSize = True
        Me.lblSueldoEsp.Location = New System.Drawing.Point(22, 83)
        Me.lblSueldoEsp.Name = "lblSueldoEsp"
        Me.lblSueldoEsp.Size = New System.Drawing.Size(91, 13)
        Me.lblSueldoEsp.TabIndex = 1
        Me.lblSueldoEsp.Text = "Sueldo especifico"
        '
        'lblnivelSalarial
        '
        Me.lblnivelSalarial.AutoSize = True
        Me.lblnivelSalarial.Location = New System.Drawing.Point(22, 109)
        Me.lblnivelSalarial.Name = "lblnivelSalarial"
        Me.lblnivelSalarial.Size = New System.Drawing.Size(68, 13)
        Me.lblnivelSalarial.TabIndex = 2
        Me.lblnivelSalarial.Text = "Nivel Salarial"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(22, 136)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 3
        Me.lblDepartamento.Text = "Departamento"
        '
        'lblPuesto
        '
        Me.lblPuesto.AutoSize = True
        Me.lblPuesto.Location = New System.Drawing.Point(22, 57)
        Me.lblPuesto.Name = "lblPuesto"
        Me.lblPuesto.Size = New System.Drawing.Size(80, 13)
        Me.lblPuesto.TabIndex = 4
        Me.lblPuesto.Text = "Nombre Puesto"
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(144, 50)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(164, 20)
        Me.txtPuesto.TabIndex = 5
        '
        'txtSueldoEsp
        '
        Me.txtSueldoEsp.Location = New System.Drawing.Point(144, 76)
        Me.txtSueldoEsp.Name = "txtSueldoEsp"
        Me.txtSueldoEsp.Size = New System.Drawing.Size(164, 20)
        Me.txtSueldoEsp.TabIndex = 6
        '
        'txtNSalarial
        '
        Me.txtNSalarial.Location = New System.Drawing.Point(144, 102)
        Me.txtNSalarial.Name = "txtNSalarial"
        Me.txtNSalarial.Size = New System.Drawing.Size(164, 20)
        Me.txtNSalarial.TabIndex = 7
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(144, 128)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(164, 21)
        Me.cbDepartamento.TabIndex = 8
        '
        'lblRFCEmpresa
        '
        Me.lblRFCEmpresa.AutoSize = True
        Me.lblRFCEmpresa.Location = New System.Drawing.Point(141, 165)
        Me.lblRFCEmpresa.Name = "lblRFCEmpresa"
        Me.lblRFCEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.lblRFCEmpresa.TabIndex = 9
        Me.lblRFCEmpresa.Text = "Empresa"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(155, 225)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(252, 225)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'insertar_puesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 260)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblRFCEmpresa)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.txtNSalarial)
        Me.Controls.Add(Me.txtSueldoEsp)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.lblPuesto)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.lblnivelSalarial)
        Me.Controls.Add(Me.lblSueldoEsp)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Name = "insertar_puesto"
        Me.Text = "insertar_puesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmpresa As Label
    Friend WithEvents lblSueldoEsp As Label
    Friend WithEvents lblnivelSalarial As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblPuesto As Label
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents txtSueldoEsp As TextBox
    Friend WithEvents txtNSalarial As TextBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents lblRFCEmpresa As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
