Public Class Empleado
    Inherits Persona

    'clase departamento
    'clase para puesto
    Public noCuenta As String
    Public departamento As Integer
    Public puesto As String
    Public banco As String
    Public NSS As String
    Public nomina As String

    Public Sub New()
    End Sub

    Public Sub New(noCuenta As String, departamento As Integer, puesto As String, banco As String, nSS As String, nomina As String, cURP As String, rFC As String, nombre As String, apellidos As String, fechaNacim As Date, _calle As String, _colonia As String, _municipio As String, _codigoPostal As String, _estado As String)
        Me.noCuenta = noCuenta
        Me.departamento = departamento
        Me.puesto = puesto
        Me.banco = banco
        Me.NSS = nSS
        Me.nomina = nomina
        Me.CURP = cURP
        Me.RFC = rFC
        Me.Nombre = nombre
        Me.Apellidos = apellidos
        Me.fechaNacim = fechaNacim
        Me.calle = _calle
        Me.colonia = _colonia
        Me.municipio = _municipio
        Me.codigoPostal = _codigoPostal
        Me.estado = _estado
    End Sub
End Class
