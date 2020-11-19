Public Class ventana_gerente_general

    'esta es el primer metodo que se llama cuando la ventana se muestra
    Private Sub ventana_gerente_general_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'instanciamos una variable de la clase empresa para cargar nuestras empresas en el grid
        Dim cargarEmpreas As Empresa = New Empresa()
        cargarEmpreas.cargar_empresas(dtListaEmpresas)
    End Sub

    'este metodo se llama cuando damos click el boton "Insertar Empresa del menu"
    Private Sub InsertarEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarEmpresaToolStripMenuItem.Click
        Me.Enabled = False
        insertar_empresa.ShowDialog()
    End Sub

    'metodo donde insertamos el departamento
    Private Sub InsertarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarDepartamentoToolStripMenuItem.Click
        Me.Enabled = False
        insertar_departamento.ShowDialog()
    End Sub

    'metodo para insertar un solo gerente de departamento
    Private Sub InsertarSoloGerenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarSoloGerenteToolStripMenuItem.Click
        Me.Enabled = False
        agregar_gerente_dpto.ShowDialog()
    End Sub

    'metodo para insertar un puesto
    Private Sub InsertarPuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarPuestoToolStripMenuItem.Click
        Me.Enabled = False
        insertar_puesto.ShowDialog()
    End Sub

    Private Sub InsertarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarEmpleadoToolStripMenuItem.Click
        Me.Enabled = False
        insertar_empleado.ShowDialog()
    End Sub

    Private Sub GerenteDeNominaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenteDeNominaToolStripMenuItem.Click
        Me.Enabled = False
        insertar_gerente_nomina.Show()
    End Sub
End Class