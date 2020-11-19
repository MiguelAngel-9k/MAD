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
End Class