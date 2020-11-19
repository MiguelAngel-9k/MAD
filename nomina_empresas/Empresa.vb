
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Empresa
    'heredamos la clase domicilio
    'por que emprea debe tener un domicilio
    Inherits Domicillio

    Public razonSocial As String
    'sera una clase solo para los domicilios
    'Public Domicilio_fiscal As Domicilio
    Public registroPatronal As String
    Public RFC As String
    Public fechaInOperaciones As Date
    Public telefono As String
    Public correo As String
    Public paginaWeb As String
    'sera una clase de tipo empleado
    'Public gerenteNomina As Empleado

    Public Sub New(razonSocial As String, registroPatronal As String, rFC As String, fechaInOperaciones As Date,
                   _calle As String, _colonia As String, _municipio As String, _codigoPostal As String, _estado As String)
        Me.razonSocial = razonSocial
        Me.registroPatronal = registroPatronal
        Me.RFC = rFC
        Me.fechaInOperaciones = fechaInOperaciones
        Me.calle = _calle
        Me.colonia = _colonia
        Me.municipio = _municipio
        Me.codigoPostal = _codigoPostal
        Me.estado = _estado
    End Sub

    Public Sub New()
    End Sub

    'talvez se pueda hacer un metodo solo par mostrar las empresas
    Public Function cargar_empresas(gridEmpresas As DataGridView)
        'hacemos la conexion a la base de datos
        Dim conexion As conexionBD = New conexionBD()
        'obtenemos la conexion y la alojamos en la variable conn
        Dim conn As SqlConnection = conexion.obtener_conexion()
        'instanciamos la variable cmd para almacenar nuestro procedimiento almacenado
        'hacemos un try de para probar el query y en caso de error el programa no se cierre
        Try
            Dim cmd As SqlCommand = New SqlCommand("sp_mostrar_empresas", conn)
            'establecemos que nuestro comando sera de tipo procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure

            'instanciamos una variable de tipo adaptador para poder establecer cual es la accion
            Dim adaptador As SqlDataAdapter = New SqlDataAdapter()
            'como es de tipo select, recibiremos los valores de nuestra tabla de sql
            adaptador.SelectCommand = cmd

            'instanciamos una variabl de tipo DataTable para almacenar nuestros datos de la tabla
            'en sql
            Dim tabla As DataTable = New DataTable()
            'aqui llenamos la tabla
            adaptador.Fill(tabla)

            'como recivimos una variable de tipo DataGridView
            'esta es una tabla que llenaremos con los registros que
            'obtenemos del sql
            gridEmpresas.DataSource = tabla

            'desconetamos la base de datos
            conn.Close()

            'regresamos el grid
            Return gridEmpresas


        Catch ex As SqlException
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Finally
            conn.Close()
        End Try
    End Function

    'Public Function insertar_empresa()

    'End Function
End Class
