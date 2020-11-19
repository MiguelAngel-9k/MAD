Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Departamento
    Public empresa As String
    Public sueldoBase As Integer
    Public nombre As String
    Public gerente As Integer

    Public Sub New()
    End Sub

    Public Sub New(empresa As String, sueldoBase As String, nombre As String, gerente As Integer)
        Me.empresa = empresa
        Me.sueldoBase = sueldoBase
        Me.nombre = nombre
        Me.gerente = gerente
    End Sub

    Public Sub New(empresa As String, sueldoBase As Integer, nombre As String)
        Me.empresa = empresa
        Me.sueldoBase = sueldoBase
        Me.nombre = nombre
    End Sub
End Class
