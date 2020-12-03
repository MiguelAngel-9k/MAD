Public Class insertar_nomina
    Private Sub insertar_nomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPago.Items.Add("Semanal")
        cbPago.Items.Add("Quincenal")
        cbPago.Items.Add("Mensual")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim conn As conexionBD = New conexionBD()

        Dim Fpago As String = cbPago.Text()
        Dim empleado As Integer = Integer.Parse(txtNoEmpleado.Text())

        If (conn.insertar_nomina(empleado, Fpago) = True) Then
            MessageBox.Show("Se inserto la nomina", "La nomina se inserto correctamente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("No se inserto la nomina", "La no nomina se inserto correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        ventana_gerente_general.Enabled = True
        Me.Close()

    End Sub

    Private Sub insertar_nomina_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ventana_gerente_general.Enabled = True
    End Sub
End Class