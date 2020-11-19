Public Class IniciarSesion
    Private Sub IniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'se carga el combobox de tipo de usuario
        cbAcceso.Items.Add("Gerente general")
        cbAcceso.Items.Add("Gerente de nomina")
        cbAcceso.Items.Add("Gerente de empleado")
    End Sub

    Private Sub btnInicarSesion_Click(sender As Object, e As EventArgs) Handles btnInicarSesion.Click
        'instanciamos una variable de tipo conexion
        Dim conn As conexionBD = New conexionBD()

        'evaluamos el tipo de acceso que se pide
        Select Case cbAcceso.SelectedIndex
            Case 0
                'llamamos al metodo de iniciar sesion como gerente general
                If conn.iniciar_sesion(Convert.ToDecimal(txtNoEmpleado.Text), txtContrasenia.Text, 0) = True Then
                    Me.Hide()
                    ventana_gerente_general.ShowDialog()
                End If
            Case 1
                'llamamos al metodo de iniciar sesion como gerente de nomina
                conn.iniciar_sesion(Convert.ToDecimal(txtNoEmpleado.Text), txtContrasenia.Text, 1)
            Case 2
                'llamamos al metodo de iniciar sesion como empleado
                conn.iniciar_sesion(Convert.ToDecimal(txtNoEmpleado.Text), txtContrasenia.Text, 2)
        End Select

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As DialogResult
        'preguntamos si desea cerrar el programa
        result = MessageBox.Show("La aplicacion se cerrara, ¿estas seguro?", "Cerrar aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'evaluamos el resultado
        If result = DialogResult.Yes Then
            Close()
        End If


    End Sub
End Class
