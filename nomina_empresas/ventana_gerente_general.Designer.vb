<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana_gerente_general
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarSoloGerenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarPuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtListaEmpresas = New System.Windows.Forms.DataGridView()
        Me.GerenteDeNominaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dtListaEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarEmpresaToolStripMenuItem, Me.InsertarDepartamentoToolStripMenuItem, Me.InsertarPuestoToolStripMenuItem, Me.InsertarEmpleadoToolStripMenuItem})
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'InsertarEmpresaToolStripMenuItem
        '
        Me.InsertarEmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenteDeNominaToolStripMenuItem})
        Me.InsertarEmpresaToolStripMenuItem.Name = "InsertarEmpresaToolStripMenuItem"
        Me.InsertarEmpresaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.InsertarEmpresaToolStripMenuItem.Text = "Insertar Empresa"
        '
        'InsertarDepartamentoToolStripMenuItem
        '
        Me.InsertarDepartamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarSoloGerenteToolStripMenuItem})
        Me.InsertarDepartamentoToolStripMenuItem.Name = "InsertarDepartamentoToolStripMenuItem"
        Me.InsertarDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.InsertarDepartamentoToolStripMenuItem.Text = "Insertar Departamento"
        '
        'InsertarSoloGerenteToolStripMenuItem
        '
        Me.InsertarSoloGerenteToolStripMenuItem.Name = "InsertarSoloGerenteToolStripMenuItem"
        Me.InsertarSoloGerenteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.InsertarSoloGerenteToolStripMenuItem.Text = "Insertar solo gerente"
        '
        'InsertarPuestoToolStripMenuItem
        '
        Me.InsertarPuestoToolStripMenuItem.Name = "InsertarPuestoToolStripMenuItem"
        Me.InsertarPuestoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.InsertarPuestoToolStripMenuItem.Text = "Insertar Puesto"
        '
        'InsertarEmpleadoToolStripMenuItem
        '
        Me.InsertarEmpleadoToolStripMenuItem.Name = "InsertarEmpleadoToolStripMenuItem"
        Me.InsertarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.InsertarEmpleadoToolStripMenuItem.Text = "Insertar Empleado"
        '
        'dtListaEmpresas
        '
        Me.dtListaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtListaEmpresas.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dtListaEmpresas.Location = New System.Drawing.Point(12, 103)
        Me.dtListaEmpresas.Name = "dtListaEmpresas"
        Me.dtListaEmpresas.Size = New System.Drawing.Size(756, 213)
        Me.dtListaEmpresas.TabIndex = 1
        '
        'GerenteDeNominaToolStripMenuItem
        '
        Me.GerenteDeNominaToolStripMenuItem.Name = "GerenteDeNominaToolStripMenuItem"
        Me.GerenteDeNominaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GerenteDeNominaToolStripMenuItem.Text = "Gerente de Nomina"
        '
        'ventana_gerente_general
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 433)
        Me.Controls.Add(Me.dtListaEmpresas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ventana_gerente_general"
        Me.Text = "ventana_gerente_general"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dtListaEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dtListaEmpresas As DataGridView
    Friend WithEvents InsertarDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarSoloGerenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarPuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenteDeNominaToolStripMenuItem As ToolStripMenuItem
End Class
