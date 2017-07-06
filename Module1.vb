Imports System.Xml

'con un menu crear objetos de tipo profesor, estudiante de pregrado, posgrado
'constructor vacio para cada usuario


'investigar el tipo obj Date 
Module Module1




    Dim path As String = "..\..\XMLdatos.xml"
    Dim pathw As String = "..\..\Historial.xml"

    Dim libro As Libro
    Dim listLibros As New List(Of Libro)

    Public op As Integer
    Sub Main()

        listLibros = LeerDom(path)
        Console.WriteLine(listLibros.Item(0))

        'For Each libro As Libro In listLibros
        '    Console.WriteLine(libro.Autores1
        '                      )

        'Next


        Console.ReadLine()


        Dim historiasArray As New ArrayList
        Dim usuariosPregrado As New ArrayList
        Dim usuariosPosgrado As New ArrayList
        Dim usuariosProfesores As New ArrayList
        Dim posicionPregrado As Integer = 0
        Dim posicionPosgrado As Integer = 0
        Dim posicionProfesores As Integer = 0

        usuariosPregrado.Add(New EstudiantePregrado("Fernando", "Torres", "0987634456", "20", "0394848484", "ftorres@espol.edu.ec", "0949848"))
        usuariosPosgrado.Add(New EstudiantePosgrado("Carlos", "Alvarado", "0987656456", "23", "03945677", "calvarado@espol.edu.ec", "09498454"))
        usuariosProfesores.Add(New Profesor("Carlos", "Alvarado", "0987656456", "23", "03945677", "calvarado@espol.edu.ec", "Java", 600))




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

                        'Dim xmlDoc As New XmlDocument()
                        'Dim temp = xmlDoc.CreateElement("HistorialUsuario")
                        'temp.SetAttribute("new", "Usuario")

                        'xmlDoc.AppendChild(temp)
                        'Dim countTag = xmlDoc.CreateElement("Nombre")
                        'Dim countText = xmlDoc.CreateTextNode(nameUsuario
                        '                                  )
                        'countTag.AppendChild(countText)
                        'temp.AppendChild(countTag)
                        'xmlDoc.Save(pathw)

                        'Dim countTag2 = xmlDoc.CreateElement("Apellido")
                        'Dim countText2 = xmlDoc.CreateTextNode(apellidoUsuario)

                        'countTag2.AppendChild(countText2)
                        'temp.AppendChild(countTag2)
                        'xmlDoc.Save(pathw)




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

                    Dim opcion As Integer
                    Console.WriteLine("Buscar libro 1)Nombre 2)Autor 3)Categoria")
                    opcion = Console.ReadLine()
                    Select Case opcion
                        Case 1
                            Console.WriteLine("Ingrese el nombre del libro:")
                            Dim n As String = Console.ReadLine()
                            BuscarLibro(n)
                            Console.WriteLine("Libro: " & libro.Titulo1)
                            Console.WriteLine("Autor: " & libro.Autores1)
                            Console.WriteLine("Raiting: " & libro.Raiting1)
                            Console.ReadLine()
                        Case 2
                            Console.WriteLine("Ingrese el nombre del autor del libro:")
                            Dim a As String = Console.ReadLine()
                            BuscarLibroPorAutor(a)
                            Console.WriteLine("Autor: " & libro.Autores1)
                            Console.WriteLine("Raiting: " & libro.Raiting1)
                            Console.ReadLine()
                        Case 3
                            Console.WriteLine("Ingrese el nombre del autor del libro:")
                            Dim c As String = Console.ReadLine()
                            BuscarLibroPorCategoria(c)


                            ''completar


                            Console.WriteLine("Autor: " & libro.Autores1)
                            Console.WriteLine("Raiting: " & libro.Raiting1)
                            Console.ReadLine()
                    End Select

                Case 2
                            Console.WriteLine("Ingrese el tipo de usuario (1.Pregrado,2.Posgrado,3.Profesor):")
                            Dim tUsuario As Integer = Console.ReadLine()
                            Console.WriteLine("Ingrese el nombre del Usuario:")
                            Dim nUsuario As String = Console.ReadLine()
                            Console.WriteLine("Ingrese el nombre del libro:")
                            Dim nLibro As String = Console.ReadLine()

                            Select Case tUsuario
                                Case 1 ''PREGRADO
                                    For Each user As EstudiantePregrado In usuariosPregrado
                                        If (user.Nombres1 = nUsuario) Then
                                            If (user.LimitePrestamo1 < 1) Then
                                                Console.WriteLine("Ya no puede alquilar más libros")
                                            Else

                                                BuscarLibro(nLibro)
                                                historiasArray.Add(New Historial(libro, user, New Date(), "Reservado"))


                                                libro.Cantidad1 -= 1
                                                guardarXML()

                                            End If
                                        End If
                                    Next


                                    For Each historia As Historial In historiasArray
                                        Console.WriteLine(historia.Estado1)

                                    Next
                                    Console.ReadLine()



                            ''GUARDAR XML
                        Case 2 ''posgrado

                            For Each user As EstudiantePosgrado In usuariosPosgrado
                                If (user.Nombres1 = nUsuario) Then
                                    If (user.LimitePrestamo1 < 1) Then
                                        Console.WriteLine("Ya no puede alquilar más libros")
                                    Else

                                        BuscarLibro(nLibro)
                                        historiasArray.Add(New Historial(libro, user, New Date(), "Reservado"))


                                        libro.Cantidad1 -= 1
                                        guardarXML()

                                    End If
                                End If
                            Next


                            For Each historia As Historial In historiasArray
                                Console.WriteLine(historia.Estado1)

                            Next
                            Console.ReadLine()



                        Case 3 ''profesor

                            For Each user As Profesor In usuariosProfesores
                                If (user.Nombres1 = nUsuario) Then
                                    If (user.LimitePrestamo1 < 1) Then
                                        Console.WriteLine("Ya no puede alquilar más libros")
                                    Else

                                        BuscarLibro(nLibro)
                                        historiasArray.Add(New Historial(libro, user, New Date(), "Reservado"))


                                        libro.Cantidad1 -= 1
                                        guardarXML()

                                    End If
                                End If
                            Next


                            For Each historia As Historial In historiasArray
                                        Console.WriteLine(historia.Estado1)

                                    Next
                                    Console.ReadLine()
                            End Select



                    'Dim historiaTemp As New Historial(listLibros.Item(n), Usuario, "//")



                        Case 3  ''Devolver el libro

                            Console.WriteLine("Ingrese el tipo de usuario (1.Pregrado,2.Posgrado,3.Profesor):")
                            Dim tUsuario As Integer = Console.ReadLine()
                            Console.WriteLine("Ingrese el nombre del Usuario:")
                            Dim nUsuario As String = Console.ReadLine()
                            Console.WriteLine("Ingrese el nombre del libro:")
                            Dim nLibro As String = Console.ReadLine()

                            For Each historia As Historial In historiasArray

                                If (nUsuario = historia.Usuario1.Nombres1) Then
                                    historia.FechaDevolucion1 = New Date()

                                    If Not (historia.FechaPrestamo1.Date.AddDays(15) <= New Date()) Then

                                        Console.WriteLine("Tiene una multa por entregar atrasado")
                                        historia.Libro1.Cantidad1 += 1

                                        guardarXML()


                                    End If
                                    Console.WriteLine("Ha devuelto el libro" & libro.Titulo1)
                                End If
                            Next


                        Case 4
                            Dim xmlDoc As New XmlDocument()

                            For Each historia As Historial In historiasArray

                                Console.WriteLine(historia.Libro1)
                                Console.ReadLine()

                            Next
                            ''LLENAR HISTORIA EN EL XML 
                            For Each historia As Historial In historiasArray

                                Dim temp = xmlDoc.CreateElement("NuevaHistoria")
                                temp.SetAttribute("id", "001")


                                xmlDoc.AppendChild(temp)
                                Dim countTag = xmlDoc.CreateElement("Titulo")
                                Dim countText = xmlDoc.CreateTextNode(historia.Libro1.Titulo1)
                                countTag.AppendChild(countText)
                                temp.AppendChild(countTag)
                        xmlDoc.Save(pathw)


                        xmlDoc.AppendChild(temp)
                        Dim countTag4 = xmlDoc.CreateElement("Autores")
                        Dim countText4 = xmlDoc.CreateTextNode(historia.Libro1.Autores1)
                        countTag4.AppendChild(countText4)
                        temp.AppendChild(countTag4)
                        xmlDoc.Save(pathw)


                        xmlDoc.AppendChild(temp)
                        Dim countTag5 = xmlDoc.CreateElement("Cantidad")
                        Dim countText5 = xmlDoc.CreateTextNode(historia.Libro1.Cantidad1)
                        countTag5.AppendChild(countText5)
                        temp.AppendChild(countTag5)
                        xmlDoc.Save(pathw)



                        xmlDoc.AppendChild(temp)
                        Dim countTag6 = xmlDoc.CreateElement("Categoria")
                        Dim countText6 = xmlDoc.CreateTextNode(historia.Libro1.Categoria1)
                        countTag6.AppendChild(countText6)
                        temp.AppendChild(countTag6)
                        xmlDoc.Save(pathw)


                        xmlDoc.AppendChild(temp)
                        Dim countTag7 = xmlDoc.CreateElement("Raiting")
                        Dim countText7 = xmlDoc.CreateTextNode(historia.Libro1.Raiting1)
                        countTag7.AppendChild(countText7)
                        temp.AppendChild(countTag7)
                        xmlDoc.Save(pathw)






                        Dim countTag2 = xmlDoc.CreateElement("Nombre")
                        Dim countText2 = xmlDoc.CreateTextNode(historia.Usuario1.Nombres1)
                                countTag2.AppendChild(countText2)
                                temp.AppendChild(countTag2)
                        xmlDoc.Save(pathw)



                        Dim countTag8 = xmlDoc.CreateElement("Apellido")
                        Dim countText8 = xmlDoc.CreateTextNode(historia.Usuario1.Apellidos1)
                        countTag8.AppendChild(countText8)
                        temp.AppendChild(countTag8)
                        xmlDoc.Save(pathw)



                        Dim countTag9 = xmlDoc.CreateElement("Cedula")
                        Dim countText9 = xmlDoc.CreateTextNode(historia.Usuario1.Cedula1)
                        countTag9.AppendChild(countText9)
                        temp.AppendChild(countTag9)
                        xmlDoc.Save(pathw)


                        Dim countTag10 = xmlDoc.CreateElement("Correo")
                        Dim countText10 = xmlDoc.CreateTextNode(historia.Usuario1.Correo1)
                        countTag10.AppendChild(countText10)
                        temp.AppendChild(countTag10)
                        xmlDoc.Save(pathw)


                        Dim countTag11 = xmlDoc.CreateElement("Edad")
                        Dim countText11 = xmlDoc.CreateTextNode(historia.Usuario1.Edad1)
                        countTag11.AppendChild(countText11)
                        temp.AppendChild(countTag11)
                        xmlDoc.Save(pathw)

                    Next




                        Case 5



                    End Select
        End While


    End Sub

    Private Sub guardarXML()

        'Dim arbol As New XmlDocument
        'Dim nodo As XmlNode

        'nodo = arbol.CreateElement("Sites")

        'arbol.AppendChild(nodo)


        'For Each libro In listLibros
        '    'Arr es un array con los elementos a poner en el xml
        '    nodo = arbol.CreateElement("value")
        '    nodo.InnerText = a.ToString
        '    arbol.DocumentElement.AppendChild(nodo)
        'Next

        'arbol.Save(Application.StartupPath & "\Fichero.xml")




        Dim xmlDocument As New XmlDocument()
        Dim temp = xmlDocument.CreateElement("catalog")
        xmlDocument.AppendChild(temp)

        For Each libro As Libro In listLibros


            ''CONTADOR PARA EL ID

            Dim bookTag = xmlDocument.CreateElement("book")
            bookTag.SetAttribute("id", "001")


            Dim titleTag = xmlDocument.CreateElement("title")
            Dim authorTag = xmlDocument.CreateElement("author")
            Dim descripcionTag = xmlDocument.CreateElement("descripcion")
            Dim categoria = xmlDocument.CreateElement("categoria")
            Dim cantidad = xmlDocument.CreateElement("cantidad")
            Dim raitingTag = xmlDocument.CreateElement("raiting")

            bookTag.AppendChild(titleTag)
            bookTag.AppendChild(authorTag)
            bookTag.AppendChild(descripcionTag)
            bookTag.AppendChild(categoria)
            bookTag.AppendChild(cantidad)
            bookTag.AppendChild(raitingTag)


            Dim titleText = xmlDocument.CreateTextNode(libro.Titulo1)
            titleTag.AppendChild(titleText)
            Dim authorText = xmlDocument.CreateTextNode(libro.Autores1)
            authorTag.AppendChild(authorText)
            Dim descriptionText = xmlDocument.CreateTextNode(libro.Descipcion1)
            descripcionTag.AppendChild(descriptionText)
            Dim catText = xmlDocument.CreateTextNode(libro.Categoria1)
            categoria.AppendChild(catText)
            Dim cantText = xmlDocument.CreateTextNode(libro.Cantidad1)
            cantidad.AppendChild(cantText)
            Dim raitingText = xmlDocument.CreateTextNode(libro.Raiting1)
            raitingTag.AppendChild(raitingText)

            temp.AppendChild(bookTag)


        Next
        xmlDocument.Save(path)


    End Sub

    Private Function LeerDom(path As String) As List(Of Libro)

        Dim listLibros As New List(Of Libro)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(path)

        Dim node As XmlElement = xmlDoc.GetElementById("001")



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
    'Private Sub agregarHistorial(path As String, pathW As String)

    '    Dim xmlDoc As New XmlDocument()
    '    xmlDoc.Load(path)
    '    Dim collection As XmlNode = xmlDoc.GetElementsByTagName("MASCOTAS").Item(0)
    '    For i = 1 To 1
    '        collection.AppendChild(CrearMascota(xmlDoc))
    '    Next
    '    xmlDoc.Save(pathW)





    'End Sub


    Public Function BuscarLibro(n As String)

        Dim encontrado As Boolean = False

        For Each libro In listLibros

            If (libro.Titulo1 = n) Then
                encontrado = True
                Exit For
            End If

        Next
        Return libro
    End Function


    Public Function BuscarLibroPorAutor(n As String)

        Dim encontrado As Boolean = False

        For Each libro In listLibros

            If (libro.Autores1 = n) Then
                encontrado = True
                Exit For
            End If

        Next
        Return libro
    End Function

    Public Function BuscarLibroPorCategoria(n As String)

        Dim encontrado As Boolean = False

        For Each libro In listLibros

            If (libro.Categoria1 = n) Then
                encontrado = True
                Exit For
            End If

        Next
        Return libro
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
