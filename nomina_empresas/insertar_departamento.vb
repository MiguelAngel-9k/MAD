Public Class insertar_departamento
    Private conn As conexionBD
    Public nuevoDepartamento As Departamento

    Private Sub insertar_departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New conexionBD

    End Sub
    Private Sub lblNoGerente_Click(sender As Object, e As EventArgs) Handles lblNoGerente.Click

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim exito As Boolean = False
        If txtNoEmpleadoGrnte.Text = "" Then

            If MessageBox.Show("No se agregara un gerente \n ¿Estas seguro?", "Gerente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                nuevoDepartamento = New Departamento(
                    txtRFEmpresa.Text,
                    Convert.ToDecimal(txtSueldoBase.Text),
                    txtNombreDpto.Text
                )
                exito = conn.insertar_departamento(nuevoDepartamento, False)
            End If
        Else
            nuevoDepartamento = New Departamento(
                   txtRFEmpresa.Text,
                   Convert.ToDecimal(txtSueldoBase.Text),
                   txtNombreDpto.Text,
                   Convert.ToDecimal(txtNoEmpleadoGrnte.Text)
               )
            exito = conn.insertar_departamento(nuevoDepartamento, True)
        End If

        If exito = True Then
            MessageBox.Show("Se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ventana_gerente_general.Enabled = True
            Me.Close()
        Else
            MessageBox.Show("No se guardo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class