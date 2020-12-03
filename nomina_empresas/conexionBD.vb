'librerias necesarias para la conexion
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class conexionBD

    'variables para poder manipular los querys
    Private conexion As SqlConnection
    Private tabla As DataTable
    Private adaptador As SqlDataAdapter
    Private comandosql As SqlCommand

    Private Sub conectar()
        'Metodo para hacer la conexion a la basee de datos 
        conexion = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("SQL").ConnectionString)
    End Sub

    Private Sub desconectar()
        'Metodo para terminar la conexion (para cuando se deje de usar, no se debe mantener la conexion abierta)
        conexion.Close()
    End Sub

    Public Function obtener_conexion() As SqlConnection
        conectar()
        Return conexion
    End Function

    'Metodo para poder iniciar sesion
    'el tipo de acceso se difine como 0 = gerente general, 1 = gerente de nomina, 2 = Empleado
    Public Function iniciar_sesion(_noEmpleadoa As Integer, _contrasenia As String, acceso As Integer) As Boolean

        Dim login_gerente_general As String = "sp_login_gerente_general"
        Dim login_gerente_nomina As String = "sp_login_gerente_nomina"
        Dim login_empleado As String = "sp_login_empleado"

        Try
            'usamos el metodo conectar para conectarnos a la base de datos
            conectar()
            'instanciamos una variable de tipo command para usar el stored procedure de la base de datos
            'y cual es nuestra conexion
            Dim cmd As SqlCommand
            Select Case acceso
                Case 0
                    cmd = New SqlCommand(login_gerente_general, conexion)
                Case 1
                    cmd = New SqlCommand(login_gerente_nomina, conexion)
                Case 2
                    cmd = New SqlCommand(login_empleado, conexion)
            End Select

            'aclaramos que sera un stored procedure
            cmd.CommandType = CommandType.StoredProcedure

            'le damos valor a nuestra variable que requiere el stored procedure
            'declaramos e inicialisamos una variable que contedra la de sql, para eso 
            'especificamos que cual sera, que tipo sera y el tamaño
            Dim numeroEmpleado As SqlParameter = cmd.Parameters.Add("@noEmpleado", SqlDbType.Int, 8)
            'le damos el valor a la variable
            numeroEmpleado.Value = _noEmpleadoa

            'hacemos lo mismo con la contraseña
            Dim contrasenia As SqlParameter = cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar, 60)
            contrasenia.Value = _contrasenia

            'instanciamos una variable de tipo data adapter que obtiene lo que nos regrese el query
            adaptador = New SqlDataAdapter
            'establecemos que sera de tipo select y le damos el valor de nuestro camando 
            adaptador.SelectCommand = cmd
            'instanciamos otra variable de tipo DataTable que se llenara con los valores que regrese el adaptador
            tabla = New DataTable
            'aqui llenamos la tabla
            adaptador.Fill(tabla)

            'si tenemos un valor entonces encontro nuestro usuario y le damos acceso
            If tabla.Rows.Count > 0 Then
                MessageBox.Show("Bievenido", "Inicio de sesion exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'desconectamos a la base de datos
                desconectar()
                'retornamos verdadero para otorgar el acceso
                Return True
            Else
                'si no tiene un valor, no encontro a nuestro usuario y le negamos el acceso
                MessageBox.Show("Incorrecto", "Empleado no encotrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'desconectamos a la base de datos
                'retornamos falso para deengar el acceso
                desconectar()
                Return False
            End If


        Catch ex As SqlException
            'en dado caso que haya un error por parte de la base de datos deplegamos un mensaje
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'regresamos falso para evitar el acceso
            desconectar()
            Return False
        Finally
            desconectar()
        End Try
    End Function

    'metodo donde se obtienen los estados y se regresa un data table
    'ya cargado con la informacion
    Public Function cargar_estados() As DataTable
        Dim combo As ComboBox = New ComboBox()

        'hacemos uso del manejo de excepciones para probar el query
        Try
            'nos conectamos a la base de datos
            conectar()
            'instanciamos una variable para contener nuestra consulta
            Dim cmd As SqlCommand = New SqlCommand("sp_desplegar_estados", conexion)
            'establecemos que la consulta sera un procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure

            'instanciamos el adaptador para nuestros registros obtenidos de la tabla
            'de sql
            adaptador = New SqlDataAdapter()
            'como esperamos un resultado sera de tipo select
            adaptador.SelectCommand = cmd

            'instanciamos una variable de tipo data table para almacenar lo obtenido de
            'sql y almacenado en adaptador
            tabla = New DataTable()
            'llenamos la tabla
            adaptador.Fill(tabla)

            'desconectamos de la base de datos
            desconectar()
            'regresamos la tabla llena de de datos
            Return tabla

        Catch ex As SqlException
            'mostramos el mensaje en caso de error
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'nos desconectamos de la base de datos
            desconectar()
        End Try

        Return Nothing
    End Function

    Public Function cargar_empresas() As Panel
        'hacemos un try para probar el query sin que el porgrama se cierre en caso de un error
        'usamos el manejo de excepciones
        Try
            'hacemos la conexion a la base de datos
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("")
        Catch ex As Exception

        End Try
    End Function

    'metodo para insertar una nueva empresa en la base de datos
    Public Function insertar_empresa(nuevaEmpresa As Empresa) As Boolean
        Dim estado As Boolean = False
        Try
            'hacemos la conexion a la base de datos
            conectar()
            'instanciamos y almacenamos el query o consulta
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_empresa", conexion)
            'establecemos que sea de tipo procedimiento almacendado
            cmd.CommandType = CommandType.StoredProcedure

            'intanciamos una variable que se usara para ingresar datos al sql
            Dim razonSocial As SqlParameter = cmd.Parameters.Add("@razon_social", SqlDbType.VarChar, 20)
            'le damos su valor
            razonSocial.Value = nuevaEmpresa.razonSocial

            Dim calle As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 20)
            calle.Value = nuevaEmpresa.calle

            Dim colonia As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 20)
            colonia.Value = nuevaEmpresa.colonia

            Dim municipio As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 20)
            municipio.Value = nuevaEmpresa.municipio

            Dim codigoPostal As SqlParameter = cmd.Parameters.Add("@codigo_postal", SqlDbType.VarChar, 20)
            codigoPostal.Value = nuevaEmpresa.codigoPostal

            Dim estadoEmpresa As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 20)
            estadoEmpresa.Value = nuevaEmpresa.estado

            Dim registroPatronal As SqlParameter = cmd.Parameters.Add("@registro_patronal", SqlDbType.VarChar, 20)
            registroPatronal.Value = nuevaEmpresa.registroPatronal

            Dim rfc As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.VarChar, 20)
            rfc.Value = nuevaEmpresa.RFC

            Dim IOp As SqlParameter = cmd.Parameters.Add("@fecha_in_op", SqlDbType.Date, 5)
            IOp.Value = nuevaEmpresa.fechaInOperaciones

            conexion.Open()
            adaptador = New SqlDataAdapter()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            estado = True

        Catch ex As SqlException
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
        End Try

        Return estado
    End Function

    Public Function insertar_gerente_nomina_empresa(_noEmpleado As String, _RFCEmpresa As String)

        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_gerente_nomina", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim noEmpleado As SqlParameter = cmd.Parameters.Add("@gerente", SqlDbType.VarChar, 20)
            noEmpleado.Value = _noEmpleado

            Dim RFCEmpresa As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.VarChar, 20)
            RFCEmpresa.Value = _RFCEmpresa

            'abrimos la conexion para poder usar el query
            conexion.Open()
            'instanciamos el adaptador para interpretar la consulta
            adaptador = New SqlDataAdapter()
            'con el adaptador establecemos que sera de tipo insert por que
            'vamos a insertar datos a la tabla
            adaptador.InsertCommand = cmd
            'ejecutamos el query
            cmd.ExecuteNonQuery()

        Catch ex As SqlException
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'cerramos la conexion
            conexion.Close()
            desconectar()
        End Try

    End Function

    'metodo para ingresar el nuevo gerente al departamento
    Public Function insertar_gerente_departamento(_noEmpleado As Integer, _empresa As String, _nombreDpto As String)
        Try
            Dim cmd As SqlCommand = New SqlCommand("insertar_gerente_departamento", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim noEmpleado As SqlParameter = cmd.Parameters.Add("@noEmpleado", SqlDbType.Int, 8)
            noEmpleado.Value = _noEmpleado

            Dim empresa As SqlParameter = cmd.Parameters.Add("@empresa", SqlDbType.VarChar, 20)
            empresa.Value = _empresa

            Dim nombreDepto As SqlParameter = cmd.Parameters.Add("@departamento", SqlDbType.VarChar, 20)
            nombreDepto.Value = _nombreDpto

            conexion.Open()
            adaptador = New SqlDataAdapter()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
            desconectar()
        End Try

    End Function

    'metodo para obtener los departamentos
    Public Function cargar_departamentos() As DataTable
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_mostrar_departamentos", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            adaptador = New SqlDataAdapter()
            adaptador.SelectCommand = cmd
            tabla = New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function

    'metodo para insertar los departamentos
    'recibimos un Departamento
    Public Function insertar_departamento(depto As Departamento, modo As Boolean)
        Dim estado As Boolean = False
        'hacemos uso de expeciones
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_departamento", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim empresa As SqlParameter = cmd.Parameters.Add("@empresa", SqlDbType.VarChar, 20)
            empresa.Value = depto.empresa

            Dim sueldoBase As SqlParameter = cmd.Parameters.Add("@sueldoBase", SqlDbType.Int, 8)
            sueldoBase.Value = depto.sueldoBase

            Dim nombre As SqlParameter = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 20)
            nombre.Value = depto.nombre

            Dim opc As SqlParameter = cmd.Parameters.Add("@opc", SqlDbType.Char, 2)
            Dim gerente As SqlParameter = cmd.Parameters.Add("@gerente", SqlDbType.Int, 8)

            'como en el procedimiento almacenado se tiene la opcion de agregar
            'gerente, como parametro recivimos el modo done True se agrega gerente
            'False no se agrega el gerente
            If modo = True Then
                opc.Value = "SI"
                gerente.Value = depto.gerente
            Else
                opc.Value = "NO"
                gerente.Value = Nothing
            End If

            conexion.Open()
            adaptador = New SqlDataAdapter()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            estado = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
            conexion.Close()
        End Try

        Return estado
    End Function

    Public Function cargar_banco() As DataTable
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_mostrar_banco", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            adaptador = New SqlDataAdapter()
            adaptador.SelectCommand = cmd
            tabla = New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
            conexion.Close()
        End Try

        Return Nothing
    End Function

    Public Function cargar_puesto_departamento() As DataTable
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_mostrar_departamento_puesto", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            adaptador = New SqlDataAdapter()
            adaptador.SelectCommand = cmd
            tabla = New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
            conexion.Close()
        End Try
    End Function

    Public Function insertar_puesto(puesto As Puesto) As Boolean
        Dim estado As Boolean = False
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_puesto", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim empresa As SqlParameter = cmd.Parameters.Add("@empresa", SqlDbType.VarChar, 20)
            empresa.Value = puesto.emprea

            Dim suldoEsp As SqlParameter = cmd.Parameters.Add("@sueldo_esp", SqlDbType.Int, 8)
            suldoEsp.Value = puesto.sueldoEspecifico

            Dim Nsalarial As SqlParameter = cmd.Parameters.Add("@nivel_salarial", SqlDbType.Int, 8)
            Nsalarial.Value = puesto.nivelSalarial

            Dim depto As SqlParameter = cmd.Parameters.Add("@departamento", SqlDbType.VarChar, 20)
            depto.Value = puesto.Departamento

            Dim nombre As SqlParameter = cmd.Parameters.Add("@nombre_puesto", SqlDbType.VarChar, 20)
            nombre.Value = puesto.nombrePuesto

            conexion.Open()
            adaptador = New SqlDataAdapter()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            estado = True
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
            conexion.Close()
        End Try
        Return estado
    End Function

    Private Function insertar_persona(persona As Empleado) As Boolean
        Dim estado As Boolean = False
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_persona", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim CURP As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.VarChar, 20)
            CURP.Value = persona.CURP

            Dim RFC As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.VarChar, 20)
            RFC.Value = persona.RFC

            Dim nombre As SqlParameter = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 20)
            nombre.Value = persona.Nombre

            Dim apellido As SqlParameter = cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 20)
            apellido.Value = persona.Apellidos

            Dim fechaNacim As SqlParameter = cmd.Parameters.Add("@fechaNacim", SqlDbType.Date, 3)
            fechaNacim.Value = persona.fechaNacim

            Dim calle As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 20)
            calle.Value = persona.calle

            Dim colonia As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 20)
            colonia.Value = persona.colonia

            Dim municipio As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 20)
            municipio.Value = persona.municipio

            Dim codigoPostal As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.VarChar, 20)
            codigoPostal.Value = persona.codigoPostal

            Dim estadoDomicilio As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 20)
            estadoDomicilio.Value = persona.estado

            conexion.Open()
            adaptador = New SqlDataAdapter()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            estado = True

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
            conexion.Close()

        End Try

        Return estado
    End Function

    Public Function insertar_empleado(empleado As Empleado) As Boolean
        Dim estado As Boolean = False

        If Me.insertar_persona(empleado) = False Then
            MessageBox.Show("No se pudo agregar la informacion personal", "No se agrego", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_empleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim noCuenta As SqlParameter = cmd.Parameters.Add("@no_cuenta", SqlDbType.VarChar, 20)
            noCuenta.Value = empleado.noCuenta

            Dim salarioDiario As SqlParameter = cmd.Parameters.Add("@salario_diario", SqlDbType.Int, 8)
            salarioDiario.Value = 0

            Dim nss As SqlParameter = cmd.Parameters.Add("@NSS", SqlDbType.VarChar, 20)
            nss.Value = empleado.NSS

            Dim banco As SqlParameter = cmd.Parameters.Add("@banco", SqlDbType.VarChar, 20)
            banco.Value = empleado.banco

            Dim CURP As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.VarChar, 20)
            CURP.Value = empleado.CURP

            Dim departamento As SqlParameter = cmd.Parameters.Add("@departamento", SqlDbType.Int, 8)
            departamento.Value = empleado.departamento

            Dim puesto As SqlParameter = cmd.Parameters.Add("@puesto", SqlDbType.VarChar, 20)
            puesto.Value = empleado.puesto

            conexion.Open()
            adaptador = New SqlDataAdapter()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            estado = True
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            desconectar()
            conexion.Close()

        End Try
        Return estado
    End Function

    Public Function insertar_nomina(empleado As Integer, Fpago As String) As Boolean
        Dim estado As Boolean = False
        Try
            conectar()
            Dim cmd As SqlCommand = New SqlCommand("sp_insertar_nomina", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim noEmpleado As SqlParameter = cmd.Parameters.Add("@empleado", SqlDbType.Int, 8)
            noEmpleado.Value() = empleado

            Dim FrecuenciaPago As SqlParameter = cmd.Parameters.Add("@frecuencia_pago", SqlDbType.VarChar, 30)
            FrecuenciaPago.Value() = Fpago

            Dim gerenteGeneral As SqlParameter = cmd.Parameters.Add("@gerente_general", SqlDbType.Int, 8)
            gerenteGeneral.Value = 2

            conexion.Open()
            adaptador = New SqlDataAdapter()
            adaptador.InsertCommand = cmd
            cmd.ExecuteNonQuery()

            estado = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        End Try
    End Function
End Class
