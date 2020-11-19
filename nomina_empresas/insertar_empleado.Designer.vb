<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertar_empleado
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
        Me.panelInfoEmpleado = New System.Windows.Forms.Panel()
        Me.dtpFechaNacim = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacim = New System.Windows.Forms.Label()
        Me.lblInformacion = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCURP = New System.Windows.Forms.TextBox()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblCURP = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNSS = New System.Windows.Forms.TextBox()
        Me.txtNomina = New System.Windows.Forms.TextBox()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.lblDepartamentoPuesto = New System.Windows.Forms.Label()
        Me.cbPuesto = New System.Windows.Forms.ComboBox()
        Me.lblNomina = New System.Windows.Forms.Label()
        Me.lblNSS = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblPuesto = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtNOcuenta = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.panelInfoEmpleado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelInfoEmpleado
        '
        Me.panelInfoEmpleado.Controls.Add(Me.dtpFechaNacim)
        Me.panelInfoEmpleado.Controls.Add(Me.lblFechaNacim)
        Me.panelInfoEmpleado.Controls.Add(Me.lblInformacion)
        Me.panelInfoEmpleado.Controls.Add(Me.lblDomicilio)
        Me.panelInfoEmpleado.Controls.Add(Me.cbEstado)
        Me.panelInfoEmpleado.Controls.Add(Me.txtCodigoPostal)
        Me.panelInfoEmpleado.Controls.Add(Me.txtMunicipio)
        Me.panelInfoEmpleado.Controls.Add(Me.txtColonia)
        Me.panelInfoEmpleado.Controls.Add(Me.txtCalle)
        Me.panelInfoEmpleado.Controls.Add(Me.txtRFC)
        Me.panelInfoEmpleado.Controls.Add(Me.txtNombre)
        Me.panelInfoEmpleado.Controls.Add(Me.txtApellido)
        Me.panelInfoEmpleado.Controls.Add(Me.txtCURP)
        Me.panelInfoEmpleado.Controls.Add(Me.lblColonia)
        Me.panelInfoEmpleado.Controls.Add(Me.lblMunicipio)
        Me.panelInfoEmpleado.Controls.Add(Me.lblCodigoPostal)
        Me.panelInfoEmpleado.Controls.Add(Me.lblEstado)
        Me.panelInfoEmpleado.Controls.Add(Me.lblRFC)
        Me.panelInfoEmpleado.Controls.Add(Me.lblNombre)
        Me.panelInfoEmpleado.Controls.Add(Me.lblApellido)
        Me.panelInfoEmpleado.Controls.Add(Me.lblCalle)
        Me.panelInfoEmpleado.Controls.Add(Me.lblCURP)
        Me.panelInfoEmpleado.Location = New System.Drawing.Point(12, 56)
        Me.panelInfoEmpleado.Name = "panelInfoEmpleado"
        Me.panelInfoEmpleado.Size = New System.Drawing.Size(586, 196)
        Me.panelInfoEmpleado.TabIndex = 0
        '
        'dtpFechaNacim
        '
        Me.dtpFechaNacim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacim.Location = New System.Drawing.Point(120, 161)
        Me.dtpFechaNacim.Name = "dtpFechaNacim"
        Me.dtpFechaNacim.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaNacim.TabIndex = 25
        '
        'lblFechaNacim
        '
        Me.lblFechaNacim.AutoSize = True
        Me.lblFechaNacim.Location = New System.Drawing.Point(23, 167)
        Me.lblFechaNacim.Name = "lblFechaNacim"
        Me.lblFechaNacim.Size = New System.Drawing.Size(91, 13)
        Me.lblFechaNacim.TabIndex = 24
        Me.lblFechaNacim.Text = "Fecha nacimiento"
        '
        'lblInformacion
        '
        Me.lblInformacion.AutoSize = True
        Me.lblInformacion.Location = New System.Drawing.Point(82, 19)
        Me.lblInformacion.Name = "lblInformacion"
        Me.lblInformacion.Size = New System.Drawing.Size(106, 13)
        Me.lblInformacion.TabIndex = 23
        Me.lblInformacion.Text = "Informacion Personal"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Location = New System.Drawing.Point(405, 19)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.lblDomicilio.TabIndex = 22
        Me.lblDomicilio.Text = "Domicilio"
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(383, 159)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(124, 21)
        Me.cbEstado.TabIndex = 21
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(383, 133)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(124, 20)
        Me.txtCodigoPostal.TabIndex = 20
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(383, 107)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(124, 20)
        Me.txtMunicipio.TabIndex = 19
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(383, 82)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(124, 20)
        Me.txtColonia.TabIndex = 18
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(383, 56)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(124, 20)
        Me.txtCalle.TabIndex = 17
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(108, 82)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(124, 20)
        Me.txtRFC.TabIndex = 16
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(108, 108)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(124, 20)
        Me.txtNombre.TabIndex = 15
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(108, 134)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(124, 20)
        Me.txtApellido.TabIndex = 14
        '
        'txtCURP
        '
        Me.txtCURP.Location = New System.Drawing.Point(108, 56)
        Me.txtCURP.Name = "txtCURP"
        Me.txtCURP.Size = New System.Drawing.Size(124, 20)
        Me.txtCURP.TabIndex = 13
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(300, 89)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(42, 13)
        Me.lblColonia.TabIndex = 12
        Me.lblColonia.Text = "Colonia"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(300, 107)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(52, 13)
        Me.lblMunicipio.TabIndex = 11
        Me.lblMunicipio.Text = "Municipio"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(300, 134)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(72, 13)
        Me.lblCodigoPostal.TabIndex = 10
        Me.lblCodigoPostal.Text = "Codigo Postal"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(300, 167)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 9
        Me.lblEstado.Text = "Estado"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(23, 89)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(28, 13)
        Me.lblRFC.TabIndex = 6
        Me.lblRFC.Text = "RFC"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(23, 115)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(23, 141)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(300, 63)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 3
        Me.lblCalle.Text = "Calle"
        '
        'lblCURP
        '
        Me.lblCURP.AutoSize = True
        Me.lblCURP.Location = New System.Drawing.Point(23, 63)
        Me.lblCURP.Name = "lblCURP"
        Me.lblCURP.Size = New System.Drawing.Size(37, 13)
        Me.lblCURP.TabIndex = 1
        Me.lblCURP.Text = "CURP"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCuenta)
        Me.Panel1.Controls.Add(Me.txtNOcuenta)
        Me.Panel1.Controls.Add(Me.txtNSS)
        Me.Panel1.Controls.Add(Me.txtNomina)
        Me.Panel1.Controls.Add(Me.cbBanco)
        Me.Panel1.Controls.Add(Me.lblDepartamentoPuesto)
        Me.Panel1.Controls.Add(Me.cbPuesto)
        Me.Panel1.Controls.Add(Me.lblNomina)
        Me.Panel1.Controls.Add(Me.lblNSS)
        Me.Panel1.Controls.Add(Me.lblBanco)
        Me.Panel1.Controls.Add(Me.lblDepartamento)
        Me.Panel1.Controls.Add(Me.lblPuesto)
        Me.Panel1.Location = New System.Drawing.Point(12, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 151)
        Me.Panel1.TabIndex = 1
        '
        'txtNSS
        '
        Me.txtNSS.Location = New System.Drawing.Point(383, 55)
        Me.txtNSS.Name = "txtNSS"
        Me.txtNSS.Size = New System.Drawing.Size(124, 20)
        Me.txtNSS.TabIndex = 25
        '
        'txtNomina
        '
        Me.txtNomina.Location = New System.Drawing.Point(383, 21)
        Me.txtNomina.Name = "txtNomina"
        Me.txtNomina.Size = New System.Drawing.Size(124, 20)
        Me.txtNomina.TabIndex = 24
        '
        'cbBanco
        '
        Me.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(108, 88)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(124, 21)
        Me.cbBanco.TabIndex = 7
        '
        'lblDepartamentoPuesto
        '
        Me.lblDepartamentoPuesto.AutoSize = True
        Me.lblDepartamentoPuesto.Location = New System.Drawing.Point(105, 62)
        Me.lblDepartamentoPuesto.Name = "lblDepartamentoPuesto"
        Me.lblDepartamentoPuesto.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamentoPuesto.TabIndex = 6
        Me.lblDepartamentoPuesto.Text = "Departamento"
        '
        'cbPuesto
        '
        Me.cbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPuesto.FormattingEnabled = True
        Me.cbPuesto.Location = New System.Drawing.Point(108, 20)
        Me.cbPuesto.Name = "cbPuesto"
        Me.cbPuesto.Size = New System.Drawing.Size(124, 21)
        Me.cbPuesto.TabIndex = 5
        '
        'lblNomina
        '
        Me.lblNomina.AutoSize = True
        Me.lblNomina.Location = New System.Drawing.Point(299, 28)
        Me.lblNomina.Name = "lblNomina"
        Me.lblNomina.Size = New System.Drawing.Size(43, 13)
        Me.lblNomina.TabIndex = 4
        Me.lblNomina.Text = "Nomina"
        '
        'lblNSS
        '
        Me.lblNSS.AutoSize = True
        Me.lblNSS.Location = New System.Drawing.Point(301, 62)
        Me.lblNSS.Name = "lblNSS"
        Me.lblNSS.Size = New System.Drawing.Size(29, 13)
        Me.lblNSS.TabIndex = 3
        Me.lblNSS.Text = "NSS"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(22, 96)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(38, 13)
        Me.lblBanco.TabIndex = 2
        Me.lblBanco.Text = "Banco"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(23, 62)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 1
        Me.lblDepartamento.Text = "Departamento"
        '
        'lblPuesto
        '
        Me.lblPuesto.AutoSize = True
        Me.lblPuesto.Location = New System.Drawing.Point(23, 28)
        Me.lblPuesto.Name = "lblPuesto"
        Me.lblPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblPuesto.TabIndex = 0
        Me.lblPuesto.Text = "Puesto"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(353, 445)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(463, 445)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 27
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtNOcuenta
        '
        Me.txtNOcuenta.AutoSize = True
        Me.txtNOcuenta.Location = New System.Drawing.Point(299, 96)
        Me.txtNOcuenta.Name = "txtNOcuenta"
        Me.txtNOcuenta.Size = New System.Drawing.Size(61, 13)
        Me.txtNOcuenta.TabIndex = 26
        Me.txtNOcuenta.Text = "No. Cuenta"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(383, 89)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(124, 20)
        Me.txtCuenta.TabIndex = 27
        '
        'insertar_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 480)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelInfoEmpleado)
        Me.Name = "insertar_empleado"
        Me.Text = "insertar_empleado"
        Me.panelInfoEmpleado.ResumeLayout(False)
        Me.panelInfoEmpleado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelInfoEmpleado As Panel
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCURP As TextBox
    Friend WithEvents lblColonia As Label
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents lblCodigoPostal As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblRFC As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblCURP As Label
    Friend WithEvents lblInformacion As Label
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents txtCodigoPostal As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPuesto As Label
    Friend WithEvents txtNSS As TextBox
    Friend WithEvents txtNomina As TextBox
    Friend WithEvents cbBanco As ComboBox
    Friend WithEvents lblDepartamentoPuesto As Label
    Friend WithEvents cbPuesto As ComboBox
    Friend WithEvents lblNomina As Label
    Friend WithEvents lblNSS As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dtpFechaNacim As DateTimePicker
    Friend WithEvents lblFechaNacim As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents txtNOcuenta As Label
End Class
