Public Class insertar_empresa

    Private conn As conexionBD

    Private Sub insertar_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'instanciamos la conexion 
        conn = New conexionBD()
        'usamos el metodo cargar_estados que regresa un DataTable
        Dim dataTable As DataTable = conn.cargar_estados()
        'obtenemos la tabla llena de datos y llenamos el combobox
        cbEstadoEmpresa.DataSource = dataTable
        'indicamos que columna vamos a desplegar
        cbEstadoEmpresa.DisplayMember = "Estado"
        'indicamos cual sera el valor del la seleccion
        cbEstadoEmpresa.ValueMember = "Clave estado"
        'instanciamos a una empresa que se llenara despues
    End Sub

    'boton guardar información de la empresa nueva
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim registro As Boolean = False
        'preguntamos su quiere guardar toda la información
        'y obtenemos el resultado en result
        Dim result As DialogResult = MessageBox.Show("¿Estas seguro? algunos datos ya no podran modificarse después", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'evaluamos el resultado
        If result = DialogResult.Yes Then

            Dim nuevaEmpresa = New Empresa(
                    txtRazonSocial.Text,
                    txtRegistroPatronal.Text,
                    txtRFCEmpresa.Text,
                    dtpInicioOP.Value.Date,
                    txtCalleEmpresa.Text,
                    txtColoniaEmpresa.Text,
                    txtMunicipio.Text,
                    txtCodigoPostalEmpresa.Text,
                    cbEstadoEmpresa.Text
                )
            'revisamos si se registro correctamente o hubo un error
            registro = conn.insertar_empresa(nuevaEmpresa)
        End If

        If registro = True Then
            result = MessageBox.Show("¿Quieres agregar gerente de nomina a la empresa? \n Debe tener el numero de empleado del nuevo gerente y el RFC de la empresa", "Agregar gerente de nomina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Else
            MessageBox.Show("No se pudo guardar la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If result = DialogResult.Yes Then
            Me.Enabled = False
            insertar_gerente_nomina.Show()
        End If

    End Sub

    'boton cancelar
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'preguntamos si esta seguro de salir de esta pantalla
        Dim result As DialogResult = MessageBox.Show("¿Estas seguro? no se guardara la informacion proporcionada", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'evaluamos la respuesta
        If result = DialogResult.Yes Then
            'salimos de la ventana para inserar empresa
            ventana_gerente_general.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub txtCalleEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCalleEmpresa.KeyPress
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

    Private Sub txtColoniaEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColoniaEmpresa.KeyPress
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

    Private Sub txtCodigoPostalEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostalEmpresa.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros y sin espacios")
        End If
    End Sub

    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
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

    Private Sub txtRegistroPatronal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegistroPatronal.KeyPress
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
            MsgBox("Solo puede digitar letras mayusculas, numeros y sin espacios")


        End If
    End Sub



End Class