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


    Private Sub txtRFEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFEmpresa.KeyPress
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

    Private Sub txtNoEmpleadoGrnte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoEmpleadoGrnte.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros y sin espacios")
        End If
    End Sub

    Private Sub txtNombreDpto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreDpto.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puede digitar letras y numeros")
        End If
    End Sub

    Private Sub txtSueldoBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSueldoBase.KeyPress

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


End Class