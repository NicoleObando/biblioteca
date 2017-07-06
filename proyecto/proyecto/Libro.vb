Public Class Libro

    Private titulo As String
    Private autores As String
    Private descipcion As String
    Private categoria As String
    Private cantidad As String
    Private raiting As String
    Private id As Integer


    Public Sub New(id As Integer, titulo As String, autores As String, descipcion As String, categoria As String, cantidad As String, raiting As String)
        Me.Id1 = id
        Me.Titulo1 = titulo
        Me.Autores1 = autores
        Me.Descipcion1 = descipcion
        Me.Categoria1 = categoria
        Me.Cantidad1 = cantidad
        Me.Raiting1 = raiting


    End Sub

    Public Property Titulo1 As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property

    Public Property Autores1 As String
        Get
            Return autores
        End Get
        Set(value As String)
            autores = value
        End Set
    End Property

    Public Property Descipcion1 As String
        Get
            Return descipcion
        End Get
        Set(value As String)
            descipcion = value
        End Set
    End Property

    Public Property Categoria1 As String
        Get
            Return categoria
        End Get
        Set(value As String)
            categoria = value
        End Set
    End Property

    Public Property Cantidad1 As String
        Get
            Return cantidad
        End Get
        Set(value As String)
            cantidad = value
        End Set
    End Property

    Public Property Raiting1 As String
        Get
            Return raiting
        End Get
        Set(value As String)
            raiting = value
        End Set
    End Property

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property


    Public Sub imprimir()

        Console.WriteLine("Nombre: " & Titulo1 & vbCr &
                          "Autor: " & Autores1 & vbCr &
                          "Descripcion:" & Descipcion1 & vbCr &
                          "Categoria:" & Categoria1 & vbCr &
                          "Cantidad:" & Cantidad1 & vbCr &
                          "Raiting:" & Raiting1 & vbCr)



    End Sub


    Public Sub ReservarLibros(usuario As Usuario)
        Console.WriteLine("La Reserva del Libro fue hecha por:" & usuario.Nombres1 & usuario.Apellidos1
                           )



    End Sub

End Class



