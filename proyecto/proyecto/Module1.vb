Imports System.Xml

'con un menu crear objetos de tipo profesor, estudiante de pregrado, posgrado
'constructor vacio para cada usuario


'investigar el tipo obj Date 
Module Module1




    Dim path As String = "..\..\XMLdatos.xml"
    Dim pathw As String = "..\..\Historial.xml"

    Dim libro As Libro
    Dim listLibros As ArrayList = LeerDom(path)

    Public op As Integer
    Sub Main()

        Console.ReadLine()


        Dim historiasArray As New ArrayList
        Dim usuariosPregrado As ArrayList
        Dim usuariosPosgrado As ArrayList
        Dim usuariosProfesores As ArrayList
        Dim posicionPregrado As Integer = 0
        Dim posicionPosgrado As Integer = 0
        Dim posicionProfesores As Integer = 0



        'saveXML(path, listLibros)
        Console.ReadLine()



        While 1
            Console.Clear()

            Console.WriteLine("0.Registrar")

            Console.WriteLine("1.Buscar	Libros")

            Console.WriteLine("2.Reservar libro")

            Console.WriteLine("3.Regresar libro")

            Console.WriteLine("4. Imprimir	historial	del	libro")

            Console.WriteLine("5. Salir")




            op = Console.ReadLine

            Select Case op
                Case 0 ''REGISTRO
                    Console.WriteLine("Ingrese el tipo de usuario (1.Pregrado,2.Posgrado,3.Profesor):")
                    Dim tUsuario As Integer = Console.ReadLine()

                    'Private nombres As String
                    'Private apellidos As String
                    'Private cedula As String
                    'Private edad As String
                    'Private telefono As String
                    'Private correo As String
                    'Private matricula As String








                    If (tUsuario = 1) Then
                        ''ATRIBUTOS DE CLASE

                        Console.WriteLine("Ingrese su nombre:")
                        Dim nameUsuario As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su apellido:")
                        Dim apellidoUsuario As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su cedula")
                        Dim cedulaUsuario As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su edad:")
                        Dim edadUsuario As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su telefono:")
                        Dim telefonoUsuario As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su correo:")
                        Dim correoUsuario As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su matricula:")
                        Dim matriculaUsuario As String = Console.ReadLine()

                        usuariosPregrado.Add(New EstudiantePregrado(nameUsuario, apellidoUsuario, cedulaUsuario, edadUsuario, telefonoUsuario, correoUsuario, matriculaUsuario))

                        Dim xmlDoc As New XmlDocument()
                        Dim temp = xmlDoc.CreateElement("HistorialUsuario")
                        temp.SetAttribute("new", "Usuario")

                        xmlDoc.AppendChild(temp)
                        Dim countTag = xmlDoc.CreateElement("Nombre")
                        Dim countText = xmlDoc.CreateTextNode(nameUsuario
                                                          )
                        countTag.AppendChild(countText)
                        temp.AppendChild(countTag)
                        xmlDoc.Save(pathw)

                        Dim countTag2 = xmlDoc.CreateElement("Apellido")
                        Dim countText2 = xmlDoc.CreateTextNode(apellidoUsuario)

                        countTag2.AppendChild(countText2)
                        temp.AppendChild(countTag2)
                        xmlDoc.Save(pathw)




                    ElseIf (tUsuario = 2) Then
                        Console.WriteLine("Ingrese su nombre:")
                        Dim nameUsuarioPos As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su apellido:")
                        Dim apellidoUsuarioPos As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su cedula")
                        Dim cedulaUsuarioPos As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su edad:")
                        Dim edadUsuarioPos As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su telefono:")
                        Dim telefonoUsuarioPos As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su correo:")
                        Dim correoUsuarioPos As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su matricula:")
                        Dim matriculaUsuarioPos As String = Console.ReadLine()



                        usuariosPosgrado.Add(New EstudiantePosgrado(nameUsuarioPos, apellidoUsuarioPos, cedulaUsuarioPos, edadUsuarioPos, telefonoUsuarioPos, correoUsuarioPos, matriculaUsuarioPos))


                    ElseIf (tUsuario = 3) Then
                        Console.WriteLine("Ingrese su nombre:")
                        Dim nameUsuarioPro As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su apellido:")
                        Dim apellidoUsuarioPro As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su cedula")
                        Dim cedulaUsuarioPro As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su edad:")
                        Dim edadUsuarioPro As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su telefono:")
                        Dim telefonoUsuarioPro As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su Correo:")
                        Dim correoUsuarioPro As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su materia")
                        Dim materiaUsuarioPro As String = Console.ReadLine()
                        Console.WriteLine("Ingrese su sueldo:")
                        Dim sueldoUsuarioPro As Decimal = Console.ReadLine()

                        usuariosProfesores.Add(New Profesor(nameUsuarioPro, apellidoUsuarioPro, cedulaUsuarioPro, edadUsuarioPro, telefonoUsuarioPro, correoUsuarioPro, materiaUsuarioPro, sueldoUsuarioPro))



                    End If

                Case 1
                    Console.WriteLine("Ingrese el nombre del libro:")
                    Dim n As String = Console.ReadLine()
                    BuscarLibro(n)


                Case 2
                    Console.WriteLine("Ingrese el tipo de usuario (1.Pregrado,2.Posgrado,3.Profesor):")
                    Dim tUsuario As Integer = Console.ReadLine()
                    Console.WriteLine("Ingrese el nombre del Usuario:")
                    Dim nUsuario As String = Console.ReadLine()
                    Console.WriteLine("Ingrese el nombre del libro:")
                    Dim nLibro As String = Console.ReadLine()

                    Select Case tUsuario
                        Case 1
                            For Each user As EstudiantePregrado In usuariosPregrado
                                If (user.Nombres1 = nUsuario) Then
                                    If (user.LimitePrestamo1 < 1) Then
                                        Console.WriteLine("Ya no puede alquilar más libros")
                                    Else
                                        Dim libro As Libro
                                        libro = BuscarLibro(nLibro)
                                        historiasArray.Add(New Historial(libro, user, "03/07/17", "Reservado"))

                                    End If
                                End If
                            Next

                        Case 2
                        Case 3

                    End Select



                    'Dim historiaTemp As New Historial(listLibros.Item(n), Usuario, "//")



                Case 3

                Case 4
                    LeerDom(path)

                Case 5



            End Select
        End While


    End Sub

    Private Function LeerDom(path As String) As ArrayList

        Dim listLibros As New ArrayList()
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(path)

        Dim node As XmlElement = xmlDoc.GetElementById("001")

        Console.WriteLine("prriri")


        Dim libros As XmlNodeList = xmlDoc.GetElementsByTagName("book")
        For Each libro As XmlNode In libros

            Dim tempList As XmlNodeList = libro.ChildNodes
            Dim temp As Integer = libro.Attributes("id").Value
            Dim temp1 As String = tempList.Item(0).InnerXml
            Dim temp2 As String = tempList.Item(1).InnerXml
            Dim temp3 As String = tempList.Item(2).InnerXml
            Dim temp4 As String = tempList.Item(3).InnerXml
            Dim temp5 As String = tempList.Item(4).InnerXml
            Dim temp6 As String = tempList.Item(5).InnerXml
            Dim tempLibro As New Libro(Integer.Parse(temp), temp1, temp2, temp3, temp4, temp5, temp6)

            listLibros.Add(tempLibro)
        Next



        ''      For Each nodo As Libro In listLibros
        ''   Console.WriteLine(nodo.Autores1)
        ''    Next
        Return listLibros


    End Function


    Private Sub addHistorial(path As Object)

        Dim doc As New XmlDocument()
        'Creo una variable  como un documento nuevo xd
        doc.Load(path) 'a esa variable le eenvio la ruta de mi xml para poder add information
        Dim book As XmlNode = doc.GetElementsByTagName("animal").Item(0) ' OJo el catalog se debe llamara segun tu xml el que es tipo body

        'AQUI GUARDO LA COSAS QUE HAGO XD

    End Sub

    Public Function BuscarLibro(n As String)
        Dim book As Libro
        For Each book In listLibros
            If (book.Titulo1 = n) Then
                book.imprimir()

            Else
                Console.WriteLine("El libro no esta disponible")
            End If

        Next
    End Function


    'Private Sub saveXML(path As String, listLibros As ArrayList)
    '    Dim xmlDoc As New XmlDocument()
    '    Dim temp = xmlDoc.CreateElement("bokk")
    '    temp.SetAttribute("pais", "ECUADOR")
    '    temp.SetAttribute("id", 1)


    '    xmlDoc.AppendChild(temp)
    '    Dim c As Integer = 0
    '    For Each nodo As Ciudad In listEc
    '        If (nodo.Pais1 = "Ecuador") Then
    '            Dim ciu = xmlDoc.CreateElement("ciudadNombre")
    '            Dim nomCiu = xmlDoc.CreateTextNode(nodo.Nombre1)
    '            ciu.AppendChild(nomCiu)
    '            temp.AppendChild(ciu)
    '            c += 1
    '        End If
    '    Next

    '    Dim countTag = xmlDoc.CreateElement("Cantidad")
    '    Dim textCount = xmlDoc.CreateTextNode(c)
    '    countTag.AppendChild(textCount)
    '    temp.AppendChild(countTag)





    'xmlDoc.Save(pathW)

    'End Sub


End Module
