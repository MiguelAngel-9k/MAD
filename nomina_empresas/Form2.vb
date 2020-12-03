Public Class Form2

    Private Sub gerente_nomina_por_empresa(sender As Object, e As EventArgs) Handles MyBase.Load
        'instanciamos una variable de la clase empresa para cargar nuestras empresas en el grid
        Dim cargarEmpreas As Empresa = New Empresa()
        cargarEmpreas.cargar_empresas(DataGridView1)
    End Sub


    Private Sub InsertarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarEmpleadoToolStripMenuItem.Click
        Me.Enabled = False
        insertar_empleado.ShowDialog()
    End Sub

    Private Sub InsertarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarDepartamentoToolStripMenuItem.Click
        Me.Enabled = False
        insertar_departamento.ShowDialog()
    End Sub
End Class