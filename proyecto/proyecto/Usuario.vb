Public Class Usuario

    Private nombres As String
    Private apellidos As String
    Private cedula As String
    Private edad As String
    Private telefono As String
    Private correo As String

    Public Sub New(nombres As String, apellidos As String, cedula As String, edad As String, telefono As String, correo As String)
        Me.Nombres1 = nombres
        Me.Apellidos1 = apellidos
        Me.Cedula1 = cedula
        Me.Edad1 = edad
        Me.Telefono1 = telefono
        Me.Correo1 = correo
    End Sub

    Public Property Nombres1 As String
        Get
            Return nombres
        End Get
        Set(value As String)
            nombres = value
        End Set
    End Property

    Public Property Apellidos1 As String
        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set
    End Property

    Public Property Cedula1 As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set
    End Property

    Public Property Edad1 As String
        Get
            Return edad
        End Get
        Set(value As String)
            edad = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Correo1 As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property
End Class
