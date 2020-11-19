Public Class insertar_puesto
    Private conn As conexionBD

    Private Sub insertar_puesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New conexionBD()
        cbDepartamento.DataSource = conn.cargar_departamentos()

        cbDepartamento.DisplayMember = "Departamento"
        cbDepartamento.ValueMember = "Empresa"

    End Sub

    'metodo para mostrar la empresa del departamento
    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        lblRFCEmpresa.Text = cbDepartamento.SelectedValue.ToString()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim nuevoPuesto As Puesto = New Puesto(
                                    lblRFCEmpresa.Text,
                                    txtSueldoEsp.Text,
                                    txtNSalarial.Text,
                                    cbDepartamento.Text,
                                    txtPuesto.Text
                                )
        If conn.insertar_puesto(nuevoPuesto) = True Then
            MessageBox.Show("Se agrego el puesto con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Close()
            ventana_gerente_general.Enabled = True
        End If
    End Sub
End Class