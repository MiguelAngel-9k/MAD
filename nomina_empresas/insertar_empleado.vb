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


    Private Sub txtCodigoPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros y sin espacios")
        End If
    End Sub

    Private Sub txtNSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNSS.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros y sin espacios")
        End If
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros y sin espacios")
        End If
    End Sub

    Private Sub txtCURP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCURP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf e.KeyChar = ChrW(8) Then 'BACKSPACE
            e.Handled = False

        ElseIf e.KeyChar >= ChrW(65) And e.KeyChar < ChrW(90) Then
            e.Handled = False
        ElseIf e.KeyChar >= ChrW(97) And e.KeyChar < ChrW(122) Then
            e.Handled = True
            MsgBox("Solo puede digitar letras mayusculas")
        Else
            e.Handled = True
            MsgBox("Solo puede digitar letras mayusculas, numeros y sin espacios")
        End If
    End Sub

    Private Sub txtRFC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFC.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf e.KeyChar = ChrW(8) Then 'BACKSPACE
            e.Handled = False

        ElseIf e.KeyChar >= ChrW(65) And e.KeyChar < ChrW(90) Then
            e.Handled = False
        ElseIf e.KeyChar >= ChrW(97) And e.KeyChar < ChrW(122) Then
            e.Handled = True
            MsgBox("Solo puede digitar letras mayusculas")
        Else
            e.Handled = True
            MsgBox("Solo puede digitar letras, numeros y sin espacios")


        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede digitar letras")

        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede digitar letras")
        End If
    End Sub

    Private Sub txtCalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCalle.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ChrW(46) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede digitar letras, numeros y puntos decimales")
        End If
    End Sub

    Private Sub txtMunicipio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMunicipio.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ChrW(46) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede digitar letras, numeros y puntos decimales")
        End If
    End Sub

    Private Sub txtColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColonia.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ChrW(46) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede digitar letras, numeros y puntos decimales")
        End If
    End Sub

End Class