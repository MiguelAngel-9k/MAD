<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_gerente_dpto
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
        Me.lblNoGerente = New System.Windows.Forms.Label()
        Me.txtNoGerente = New System.Windows.Forms.TextBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNoGerente
        '
        Me.lblNoGerente.AutoSize = True
        Me.lblNoGerente.Location = New System.Drawing.Point(12, 43)
        Me.lblNoGerente.Name = "lblNoGerente"
        Me.lblNoGerente.Size = New System.Drawing.Size(71, 13)
        Me.lblNoGerente.TabIndex = 0
        Me.lblNoGerente.Text = "No Empleado"
        '
        'txtNoGerente
        '
        Me.txtNoGerente.Location = New System.Drawing.Point(112, 36)
        Me.txtNoGerente.Name = "txtNoGerente"
        Me.txtNoGerente.Size = New System.Drawing.Size(176, 20)
        Me.txtNoGerente.TabIndex = 1
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(12, 87)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 2
        Me.lblDepartamento.Text = "Departamento"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(112, 78)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(176, 21)
        Me.cbDepartamento.TabIndex = 3
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(12, 124)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.lblEmpresa.TabIndex = 5
        Me.lblEmpresa.Text = "Empresa"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(119, 124)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Empresa de pertenencia"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(196, 189)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'agregar_gerente_dpto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 224)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.txtNoGerente)
        Me.Controls.Add(Me.lblNoGerente)
        Me.Name = "agregar_gerente_dpto"
        Me.Text = "agregar_gerente_dpto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNoGerente As Label
    Friend WithEvents txtNoGerente As TextBox
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btnAceptar As Button
End Class
