Public Class insertar_empleado
    Private conn As conexionBD
    Private Sub insertar_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New conexionBD()
        cbPuesto.DataSource = conn.cargar_puesto_departamento()
        cbPuesto.DisplayMember = "Puesto"
        cbPuesto.ValueMember = "Clave"
        cbBanco.DataSource = conn.cargar_banco()
        cbBanco.DisplayMember = "Banco"
        cbBanco.ValueMember = "Clave Banco"

    End Sub
    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    'obtener la clave del departamento al que pertenece el puesto
    Private Sub cbPuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPuesto.SelectedIndexChanged
        lblDepartamentoPuesto.Text = cbPuesto.SelectedValue.ToString()
    End Sub

    'metodo para guardar la informacion del nuevo empleado
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim nuevoEmpleado As Empleado

        If MessageBox.Show("Algunos datos no se podran editar después, ¿estas seguro?", "Agregar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'Dim persona As Persona = New Persona(
            '        txtCURP.Text,
            '        txtRFC.Text,
            '        txtNombre.Text,
            '        txtApellido.Text,
            '        dtpFechaNacim.Value.Date,
            '        txtCalle.Text,
            '        txtColonia.Text,
            '        txtMunicipio.Text,
            '        txtCodigoPostal.Text,
            '        cbEstado.Text
            '    )

            nuevoEmpleado = New Empleado(
                    txtCuenta.Text,
                    Convert.ToDecimal(lblDepartamentoPuesto.Text),
                    cbPuesto.Text,
                    cbBanco.Text,
                    txtNSS.Text,
                    txtNomina.Text,
                    txtCURP.Text,
                    txtRFC.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    dtpFechaNacim.Value.Date,
                    txtCalle.Text,
                    txtColonia.Text,
                    txtMunicipio.Text,
                    txtCodigoPostal.Text,
                    cbEstado.Text
                )

            If conn.insertar_empleado(nuevoEmpleado) = True Then
                MessageBox.Show("Se agrego correctamente", "Agregado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                MessageBox.Show("No se agrego correctamente", "No se agrego Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class