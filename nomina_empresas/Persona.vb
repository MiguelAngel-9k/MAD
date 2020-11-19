Public Class Persona

    Inherits Domicillio

    Public CURP As String
    Public RFC As String
    Public Nombre As String
    Public Apellidos As String
    Public fechaNacim As Date

    Public Sub New(cURP As String, rFC As String, nombre As String, apellidos As String, fechaNacim As Date, _calle As String, _colonia As String, _municipio As String, _codigoPostal As String, _estado As String)
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

    Public Sub New()
    End Sub
End Class
