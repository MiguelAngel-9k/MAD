Public Class insertar_gerente_nomina
    Private conn As conexionBD

    Private Sub insertar_gerente_nomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conn = New conexionBD()
        conn.insertar_gerente_nomina_empresa(txtNoEmpleado.Text, txtRFCEmpresa.Text)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ventana_gerente_general.Enabled = True
        Me.Close()
    End Sub

End Class