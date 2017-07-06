Imports proyecto

Public Class Historial

    Private libro As Libro
    Private usuario As Usuario
    Private fecha As String
    Private estado As String

    Public Sub New(libro As Libro, usuario As Usuario, fecha As String, estado As String)
        Me.libro = libro
        Me.usuario = usuario
        Me.fecha = fecha
        Me.estado = estado
    End Sub

    Public Property Libro1 As Libro
        Get
            Return libro
        End Get
        Set(value As Libro)
            libro = value
        End Set
    End Property

    Public Property Usuario1 As Usuario
        Get
            Return usuario
        End Get
        Set(value As Usuario)
            usuario = value
        End Set
    End Property

    Public Property Fecha1 As String
        Get
            Return fecha
        End Get
        Set(value As String)
            fecha = value
        End Set
    End Property

    Public Property Estado1 As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property
End Class
