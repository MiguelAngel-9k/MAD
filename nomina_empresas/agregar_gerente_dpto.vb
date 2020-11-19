Public Class agregar_gerente_dpto
    Dim conn As conexionBD

    Private Sub agregar_gerente_dpto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New conexionBD()
        cbDepartamento.DataSource = conn.cargar_departamentos()
        cbDepartamento.DisplayMember = "Departamento"
        cbDepartamento.ValueMember = "Empresa"

    End Sub

    'metodo que se llama cuando se cambia de index o seleccion 
    'el combobox de departamento
    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        lblEmpresa.Text = cbDepartamento.SelectedValue.ToString()
    End Sub

    'metodo para guardar al nuevo gerente
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conn.insertar_gerente_departamento(
                Convert.ToDecimal(txtNoGerente.Text),
                lblEmpresa.Text,
                cbDepartamento.Text
            )
        ventana_gerente_general.Enabled = True
        Me.Close()
    End Sub
End Class