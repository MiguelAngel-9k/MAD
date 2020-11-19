<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertar_empresa
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
        Me.panelDomicilioEmpresa = New System.Windows.Forms.Panel()
        Me.lblDomicilioEmpresa = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtCalleEmpresa = New System.Windows.Forms.TextBox()
        Me.txtColoniaEmpresa = New System.Windows.Forms.TextBox()
        Me.lblColoniaEmpresa = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.txtCodigoPostalEmpresa = New System.Windows.Forms.TextBox()
        Me.lblCodigoPostalEmprea = New System.Windows.Forms.Label()
        Me.cbEstadoEmpresa = New System.Windows.Forms.ComboBox()
        Me.lblEstadoEmpresa = New System.Windows.Forms.Label()
        Me.panelInformacionEmrpesa = New System.Windows.Forms.Panel()
        Me.lblDatosEmpresa = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRegistroPatronal = New System.Windows.Forms.TextBox()
        Me.lblRegistroPatronal = New System.Windows.Forms.Label()
        Me.txtRFCEmpresa = New System.Windows.Forms.TextBox()
        Me.lblRFCEmpresa = New System.Windows.Forms.Label()
        Me.lblInicioOp = New System.Windows.Forms.Label()
        Me.dtpInicioOP = New System.Windows.Forms.DateTimePicker()
        Me.lblRegistrarEmpresa = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.panelDomicilioEmpresa.SuspendLayout()
        Me.panelInformacionEmrpesa.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelDomicilioEmpresa
        '
        Me.panelDomicilioEmpresa.Controls.Add(Me.lblEstadoEmpresa)
        Me.panelDomicilioEmpresa.Controls.Add(Me.cbEstadoEmpresa)
        Me.panelDomicilioEmpresa.Controls.Add(Me.txtCodigoPostalEmpresa)
        Me.panelDomicilioEmpresa.Controls.Add(Me.lblCodigoPostalEmprea)
        Me.panelDomicilioEmpresa.Controls.Add(Me.txtMunicipio)
        Me.panelDomicilioEmpresa.Controls.Add(Me.lblMunicipio)
        Me.panelDomicilioEmpresa.Controls.Add(Me.txtColoniaEmpresa)
        Me.panelDomicilioEmpresa.Controls.Add(Me.lblColoniaEmpresa)
        Me.panelDomicilioEmpresa.Controls.Add(Me.txtCalleEmpresa)
        Me.panelDomicilioEmpresa.Controls.Add(Me.lblCalle)
        Me.panelDomicilioEmpresa.Controls.Add(Me.lblDomicilioEmpresa)
        Me.panelDomicilioEmpresa.Location = New System.Drawing.Point(12, 64)
        Me.panelDomicilioEmpresa.Name = "panelDomicilioEmpresa"
        Me.panelDomicilioEmpresa.Size = New System.Drawing.Size(346, 231)
        Me.panelDomicilioEmpresa.TabIndex = 0
        '
        'lblDomicilioEmpresa
        '
        Me.lblDomicilioEmpresa.AutoSize = True
        Me.lblDomicilioEmpresa.Location = New System.Drawing.Point(102, 16)
        Me.lblDomicilioEmpresa.Name = "lblDomicilioEmpresa"
        Me.lblDomicilioEmpresa.Size = New System.Drawing.Size(108, 13)
        Me.lblDomicilioEmpresa.TabIndex = 0
        Me.lblDomicilioEmpresa.Text = "Domicilio de Emrpesa"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(39, 71)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 1
        Me.lblCalle.Text = "Calle"
        '
        'txtCalleEmpresa
        '
        Me.txtCalleEmpresa.Location = New System.Drawing.Point(137, 64)
        Me.txtCalleEmpresa.Name = "txtCalleEmpresa"
        Me.txtCalleEmpresa.Size = New System.Drawing.Size(176, 20)
        Me.txtCalleEmpresa.TabIndex = 2
        '
        'txtColoniaEmpresa
        '
        Me.txtColoniaEmpresa.Location = New System.Drawing.Point(137, 90)
        Me.txtColoniaEmpresa.Name = "txtColoniaEmpresa"
        Me.txtColoniaEmpresa.Size = New System.Drawing.Size(176, 20)
        Me.txtColoniaEmpresa.TabIndex = 4
        '
        'lblColoniaEmpresa
        '
        Me.lblColoniaEmpresa.AutoSize = True
        Me.lblColoniaEmpresa.Location = New System.Drawing.Point(39, 97)
        Me.lblColoniaEmpresa.Name = "lblColoniaEmpresa"
        Me.lblColoniaEmpresa.Size = New System.Drawing.Size(42, 13)
        Me.lblColoniaEmpresa.TabIndex = 3
        Me.lblColoniaEmpresa.Text = "Colonia"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(137, 116)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(176, 20)
        Me.txtMunicipio.TabIndex = 6
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(39, 123)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(52, 13)
        Me.lblMunicipio.TabIndex = 5
        Me.lblMunicipio.Text = "Municipio"
        '
        'txtCodigoPostalEmpresa
        '
        Me.txtCodigoPostalEmpresa.Location = New System.Drawing.Point(137, 142)
        Me.txtCodigoPostalEmpresa.Name = "txtCodigoPostalEmpresa"
        Me.txtCodigoPostalEmpresa.Size = New System.Drawing.Size(176, 20)
        Me.txtCodigoPostalEmpresa.TabIndex = 8
        '
        'lblCodigoPostalEmprea
        '
        Me.lblCodigoPostalEmprea.AutoSize = True
        Me.lblCodigoPostalEmprea.Location = New System.Drawing.Point(39, 149)
        Me.lblCodigoPostalEmprea.Name = "lblCodigoPostalEmprea"
        Me.lblCodigoPostalEmprea.Size = New System.Drawing.Size(72, 13)
        Me.lblCodigoPostalEmprea.TabIndex = 7
        Me.lblCodigoPostalEmprea.Text = "Codigo Postal"
        '
        'cbEstadoEmpresa
        '
        Me.cbEstadoEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoEmpresa.FormattingEnabled = True
        Me.cbEstadoEmpresa.Location = New System.Drawing.Point(137, 168)
        Me.cbEstadoEmpresa.Name = "cbEstadoEmpresa"
        Me.cbEstadoEmpresa.Size = New System.Drawing.Size(176, 21)
        Me.cbEstadoEmpresa.TabIndex = 9
        '
        'lblEstadoEmpresa
        '
        Me.lblEstadoEmpresa.AutoSize = True
        Me.lblEstadoEmpresa.Location = New System.Drawing.Point(39, 176)
        Me.lblEstadoEmpresa.Name = "lblEstadoEmpresa"
        Me.lblEstadoEmpresa.Size = New System.Drawing.Size(40, 13)
        Me.lblEstadoEmpresa.TabIndex = 10
        Me.lblEstadoEmpresa.Text = "Estado"
        '
        'panelInformacionEmrpesa
        '
        Me.panelInformacionEmrpesa.Controls.Add(Me.dtpInicioOP)
        Me.panelInformacionEmrpesa.Controls.Add(Me.lblInicioOp)
        Me.panelInformacionEmrpesa.Controls.Add(Me.txtRFCEmpresa)
        Me.panelInformacionEmrpesa.Controls.Add(Me.lblRFCEmpresa)
        Me.panelInformacionEmrpesa.Controls.Add(Me.txtRegistroPatronal)
        Me.panelInformacionEmrpesa.Controls.Add(Me.lblRegistroPatronal)
        Me.panelInformacionEmrpesa.Controls.Add(Me.txtRazonSocial)
        Me.panelInformacionEmrpesa.Controls.Add(Me.lblRazonSocial)
        Me.panelInformacionEmrpesa.Controls.Add(Me.lblDatosEmpresa)
        Me.panelInformacionEmrpesa.Location = New System.Drawing.Point(364, 64)
        Me.panelInformacionEmrpesa.Name = "panelInformacionEmrpesa"
        Me.panelInformacionEmrpesa.Size = New System.Drawing.Size(389, 231)
        Me.panelInformacionEmrpesa.TabIndex = 1
        '
        'lblDatosEmpresa
        '
        Me.lblDatosEmpresa.AutoSize = True
        Me.lblDatosEmpresa.Location = New System.Drawing.Point(159, 16)
        Me.lblDatosEmpresa.Name = "lblDatosEmpresa"
        Me.lblDatosEmpresa.Size = New System.Drawing.Size(106, 13)
        Me.lblDatosEmpresa.TabIndex = 0
        Me.lblDatosEmpresa.Text = "Informacion Empresa"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(30, 71)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(70, 13)
        Me.lblRazonSocial.TabIndex = 1
        Me.lblRazonSocial.Text = "Razon Social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(151, 68)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(176, 20)
        Me.txtRazonSocial.TabIndex = 2
        '
        'txtRegistroPatronal
        '
        Me.txtRegistroPatronal.Location = New System.Drawing.Point(151, 94)
        Me.txtRegistroPatronal.Name = "txtRegistroPatronal"
        Me.txtRegistroPatronal.Size = New System.Drawing.Size(176, 20)
        Me.txtRegistroPatronal.TabIndex = 4
        '
        'lblRegistroPatronal
        '
        Me.lblRegistroPatronal.AutoSize = True
        Me.lblRegistroPatronal.Location = New System.Drawing.Point(30, 97)
        Me.lblRegistroPatronal.Name = "lblRegistroPatronal"
        Me.lblRegistroPatronal.Size = New System.Drawing.Size(88, 13)
        Me.lblRegistroPatronal.TabIndex = 3
        Me.lblRegistroPatronal.Text = "Registro Patronal"
        '
        'txtRFCEmpresa
        '
        Me.txtRFCEmpresa.Location = New System.Drawing.Point(151, 120)
        Me.txtRFCEmpresa.Name = "txtRFCEmpresa"
        Me.txtRFCEmpresa.Size = New System.Drawing.Size(176, 20)
        Me.txtRFCEmpresa.TabIndex = 6
        '
        'lblRFCEmpresa
        '
        Me.lblRFCEmpresa.AutoSize = True
        Me.lblRFCEmpresa.Location = New System.Drawing.Point(30, 123)
        Me.lblRFCEmpresa.Name = "lblRFCEmpresa"
        Me.lblRFCEmpresa.Size = New System.Drawing.Size(28, 13)
        Me.lblRFCEmpresa.TabIndex = 5
        Me.lblRFCEmpresa.Text = "RFC"
        '
        'lblInicioOp
        '
        Me.lblInicioOp.AutoSize = True
        Me.lblInicioOp.Location = New System.Drawing.Point(30, 149)
        Me.lblInicioOp.Name = "lblInicioOp"
        Me.lblInicioOp.Size = New System.Drawing.Size(110, 13)
        Me.lblInicioOp.TabIndex = 7
        Me.lblInicioOp.Text = "Inicio de Operaciones"
        '
        'dtpInicioOP
        '
        Me.dtpInicioOP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioOP.Location = New System.Drawing.Point(151, 149)
        Me.dtpInicioOP.Name = "dtpInicioOP"
        Me.dtpInicioOP.Size = New System.Drawing.Size(176, 20)
        Me.dtpInicioOP.TabIndex = 8
        '
        'lblRegistrarEmpresa
        '
        Me.lblRegistrarEmpresa.AutoSize = True
        Me.lblRegistrarEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrarEmpresa.Location = New System.Drawing.Point(277, 25)
        Me.lblRegistrarEmpresa.Name = "lblRegistrarEmpresa"
        Me.lblRegistrarEmpresa.Size = New System.Drawing.Size(172, 13)
        Me.lblRegistrarEmpresa.TabIndex = 2
        Me.lblRegistrarEmpresa.Text = "Registrar Una Emprea Nueva"
        Me.lblRegistrarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(515, 310)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Guardar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(616, 310)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'insertar_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 345)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblRegistrarEmpresa)
        Me.Controls.Add(Me.panelInformacionEmrpesa)
        Me.Controls.Add(Me.panelDomicilioEmpresa)
        Me.Name = "insertar_empresa"
        Me.Text = "Registro de empresa"
        Me.panelDomicilioEmpresa.ResumeLayout(False)
        Me.panelDomicilioEmpresa.PerformLayout()
        Me.panelInformacionEmrpesa.ResumeLayout(False)
        Me.panelInformacionEmrpesa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelDomicilioEmpresa As Panel
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblDomicilioEmpresa As Label
    Friend WithEvents lblEstadoEmpresa As Label
    Friend WithEvents cbEstadoEmpresa As ComboBox
    Friend WithEvents txtCodigoPostalEmpresa As TextBox
    Friend WithEvents lblCodigoPostalEmprea As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents txtColoniaEmpresa As TextBox
    Friend WithEvents lblColoniaEmpresa As Label
    Friend WithEvents txtCalleEmpresa As TextBox
    Friend WithEvents panelInformacionEmrpesa As Panel
    Friend WithEvents lblDatosEmpresa As Label
    Friend WithEvents dtpInicioOP As DateTimePicker
    Friend WithEvents lblInicioOp As Label
    Friend WithEvents txtRFCEmpresa As TextBox
    Friend WithEvents lblRFCEmpresa As Label
    Friend WithEvents txtRegistroPatronal As TextBox
    Friend WithEvents lblRegistroPatronal As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblRegistrarEmpresa As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
