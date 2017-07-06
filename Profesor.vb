Public Class Profesor
    Inherits Usuario

    Private rol As String = "Profesor"
    Private materias As String
    Private sueldo As Decimal
    Private limitePrestamo As Integer = 5



    Public Sub New(nombres As String, apellidos As String, cedula As String, edad As String, telefono As String, correo As String, materias As String, sueldo As Decimal)
        MyBase.New(nombres, apellidos, cedula, edad, telefono, correo)
        Me.Materias1 = materias
        Me.Sueldo1 = sueldo
    End Sub

    Public Property Rol1 As String
        Get
            Return rol
        End Get
        Set(value As String)
            rol = value
        End Set
    End Property

    Public Property Materias1 As String
        Get
            Return materias
        End Get
        Set(value As String)
            materias = value
        End Set
    End Property

    Public Property Sueldo1 As Decimal
        Get
            Return sueldo
        End Get
        Set(value As Decimal)
            sueldo = value
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
