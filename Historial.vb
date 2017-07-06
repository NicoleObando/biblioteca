Imports proyecto

Public Class Historial

    Private libro As Libro
    Private usuario As Usuario
    Private fechaPrestamo As Date
    Private fechaDevolucion As Date
    Private estado As String = "en stock"

    Public Sub New(libro As Libro, usuario As Usuario, fechaPrestamo As Date, estado As String)
        Me.libro = libro
        Me.usuario = usuario
        Me.fechaPrestamo = fechaPrestamo
        Me.estado = estado
    End Sub

    Public Property FechaPrestamo1 As Date
        Get
            Return fechaPrestamo
        End Get
        Set(value As Date)
            fechaPrestamo = value
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

    Public Property Usuario1 As Usuario
        Get
            Return usuario
        End Get
        Set(value As Usuario)
            usuario = value
        End Set
    End Property

    Public Property Libro1 As Libro
        Get
            Return libro
        End Get
        Set(value As Libro)
            libro = value
        End Set
    End Property

    Public Property FechaDevolucion1 As Date
        Get
            Return fechaDevolucion
        End Get
        Set(value As Date)
            fechaDevolucion = value
        End Set
    End Property
End Class
