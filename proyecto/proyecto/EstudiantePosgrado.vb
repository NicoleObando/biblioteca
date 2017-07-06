Public Class EstudiantePosgrado
    Inherits Usuario
    Private matricula As String
    Private rol As String = "Estudiante Posgrado"
    Private limitePrestamo As Integer = 3



    Public Sub New(nombres As String, apellidos As String, cedula As String, edad As String, telefono As String, correo As String, matricula As String)
        MyBase.New(nombres, apellidos, cedula, edad, telefono, correo)
        Me.Matricula1 = matricula
    End Sub

    Public Property Matricula1 As String
        Get
            Return matricula
        End Get
        Set(value As String)
            matricula = value
        End Set
    End Property

    Public Property Rol1 As String
        Get
            Return rol
        End Get
        Set(value As String)
            rol = value
        End Set
    End Property

    Public Property LimitePrestamo1 As Integer
        Get
            Return limitePrestamo
        End Get
        Set(value As Integer)
            limitePrestamo = value
        End Set
    End Property
End Class
