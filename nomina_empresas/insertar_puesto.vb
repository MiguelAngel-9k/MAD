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

    Private Sub txtPuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPuesto.KeyPress
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

    Private Sub txtSueldoEsp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSueldoEsp.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ChrW(46) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede digitar numeros y punto decimal, sin espacios")
        End If
    End Sub

    Private Sub txtNSalarial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNSalarial.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros y sin espacios")
        End If
    End Sub




End Class