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

    Private Sub txtNoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoEmpleado.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros y sin espacios")
        End If
    End Sub

    Private Sub txtRFCEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFCEmpresa.KeyPress
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




End Class