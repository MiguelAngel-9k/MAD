Public Class Puesto

    Public emprea As String
    Public sueldoEspecifico As Integer
    Public nivelSalarial As Integer
    Public Departamento As String
    Public nombrePuesto As String

    Public Sub New()
    End Sub

    Public Sub New(emprea As String, sueldoEspecifico As Integer, nivelSalarial As Integer, departamento As String, nombrePuesto As String)
        Me.emprea = emprea
        Me.sueldoEspecifico = sueldoEspecifico
        Me.nivelSalarial = nivelSalarial
        Me.Departamento = departamento
        Me.nombrePuesto = nombrePuesto
    End Sub
End Class
