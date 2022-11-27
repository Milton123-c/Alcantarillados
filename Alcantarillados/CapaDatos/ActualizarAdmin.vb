
Imports System.Data.Sql
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class ActualizarAdmin


    Inherits Conexion

    Private nombre, apellidos, cedula, telefono1, telefono2, celular, correo As String

    Private direccion As String

    Private provincia, canton, distrito As String

    Private contra As String

    Private id As Integer

    Private cm As SqlCommand
    Private rd As SqlDataReader


    Public Sub New(nom As String, ape As String, ced As String, tel1 As String, tel2 As String, cel As String, corr As String, prov As String, cant As String, dist As String, id_ As Integer, password As String, direc As String)

        nombre = nom
        apellidos = ape
        cedula = ced
        telefono1 = tel1
        telefono2 = tel2
        celular = cel
        correo = corr
        provincia = prov
        canton = cant
        distrito = dist
        contra = password
        direccion = direc
        id = id_

    End Sub

    Public Sub New()

    End Sub

    Public Property Id_Administrador As Integer

        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set

    End Property

    Public Property Nombre_Administrador As String

        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set

    End Property

    Public Property Apellidos_Administrador As String

        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set

    End Property

    Public Property Cedula_Administrador As String

        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set

    End Property

    Public Property Telefono1_Administrador As String

        Get
            Return telefono1
        End Get
        Set(value As String)
        End Set

    End Property

    Public Property Telefono2_Administrador As String
        Get
            Return telefono2
        End Get
        Set(value As String)
            telefono2 = value
        End Set

    End Property

    Public Property Celular_Administrador As String

        Get
            Return celular
        End Get
        Set(value As String)
            celular = value
        End Set

    End Property

    Public Property Correo_Administrador As String

        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set

    End Property

    Public Property Provincia_Administrador As String

        Get
            Return provincia
        End Get
        Set(value As String)
            provincia = value
        End Set

    End Property

    Public Property Canton_Administrador As String

        Get
            Return canton

        End Get
        Set(value As String)
            canton = value
        End Set

    End Property

    Public Property Distrito_Administrador As String

        Get
            Return distrito
        End Get
        Set(value As String)
            distrito = value
        End Set

    End Property

    Public Property Contra_Administrador As String

        Get
            Return contra

        End Get
        Set(value As String)
            contra = value
        End Set

    End Property

    Public Property Direccion_Administrador As String

        Get
            Return direccion

        End Get
        Set(value As String)
            direccion = value
        End Set

    End Property

    Public Function ContarId() As Integer
        Try


            newConexion()
            Dim cadena As String

            cadena = "SELECT COUNT(*) FROM TB_ADMIN"

            cm = New SqlCommand(cadena, conn)

            rd = cm.ExecuteReader



            If rd.Read Then

                Dim fila As Integer

                Dim numero As String

                numero = rd(0).ToString

                fila = Val(numero)

                Return fila

            Else

                Return 0

            End If
            rd.Close()


        Catch ex As Exception

            Return 0

        Finally

            CerrarConexion()



        End Try
    End Function
    Public Function InsertarAdministrador(dc As ActualizarAdmin) As Boolean

        Try
            Dim bandera As Integer
            bandera = ContarId() + 1


            newConexion()


            Dim cadenaQuery As String

            cadenaQuery = "INSERT INTO TB_ADMIN(ID_ADMIN, NOMBRE, APELLIDOS, CEDULA, TELEFONO_1, TELEFONO_2, CELULAR, DIRECCION, PROVINCIA, CANTON, DISTRITO,CORREO, CONTRA)
	VALUES( '" & bandera & " ', '" & dc.nombre & "', '" & dc.apellidos & "', '" & dc.cedula & "', '" & dc.telefono1 & "', '" & dc.telefono2 & "', '" & dc.celular & "', '" & dc.direccion & "', '" & dc.provincia & "', '" & dc.canton & "', '" & dc.distrito & "', '" & dc.correo & "', '" & dc.contra & "')"

            cm = New SqlCommand(cadenaQuery, conn)

            If cm.ExecuteNonQuery Then

                MessageBox.Show("Administrador insertado")
                Return True

            Else
                Return False

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False

        Finally

            CerrarConexion()


        End Try

    End Function

    'Lista de administradores

    Public Function ListaAdministradores() As DataSet

        Try

            newConexion()

            Dim cadena As String = "SELECT ID_ADMIN, NOMBRE, APELLIDOS, CEDULA FROM TB_ADMIN"

            Dim ds As New DataSet

            Dim consult As New SqlDataAdapter(cadena, conn)


            consult.Fill(ds)



            Return ds

        Catch ex As Exception

            MessageBox.Show(ex.Message)

            Return Nothing

        Finally

            CerrarConexion()


        End Try


    End Function

    'Cargar Datos Del Administrador

    Public Function DatosAdminActual(ID As Integer) As String()

        Try

            newConexion()

            Dim cadena As String = "SELECT * FROM TB_ADMIN WHERE ID_ADMIN = '" & ID & "' "

            cm = New SqlCommand(cadena, conn)

            rd = cm.ExecuteReader

            If rd.Read Then

                Dim coleccion() As String = {rd.Item("ID_ADMIN"), rd.Item("NOMBRE"), rd.Item("APELLIDOS"), rd.Item("CEDULA"), rd.Item("TELEFONO_1"), rd.Item("TELEFONO_2"), rd.Item("CELULAR"), rd.Item("DIRECCION"), rd.Item("PROVINCIA"), rd.Item("CANTON"), rd.Item("DISTRITO"), rd.Item("CORREO"), rd.Item("CONTRA")}

                Return coleccion

            Else
                Dim lista() As String = {""}

                Return lista

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Dim lista() As String = {""}
            Return lista

        Finally

            CerrarConexion()

        End Try


    End Function

    'Eliminar Administrador
    Public Function EliminarAdmin(id_admin As Integer) As Boolean

        Try

            newConexion()

            Dim consulta As String = "DELETE FROM TB_ADMIN WHERE ID_ADMIN = '" & id_admin & "' "

            cm = New SqlCommand(consulta, conn)

            If cm.ExecuteNonQuery Then

                Return True

            Else
                Return False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally

            CerrarConexion()


        End Try


    End Function

    'Funcion para actualizar datos de los administradores
    Public Function ActualizandoAdmin(dc As ActualizarAdmin) As Boolean

        Try
            newConexion()

            Dim consulta As String = "UPDATE TB_ADMIN SET NOMBRE = '" & dc.nombre & "', APELLIDOS = '" & dc.apellidos & "', CEDULA = '" & dc.cedula & "' , TELEFONO_1 = '" & dc.telefono1 & "', TELEFONO_2 = '" & dc.telefono2 & "' , CELULAR = '" & dc.celular & "' , DIRECCION = '" & dc.direccion & "' , PROVINCIA = '" & dc.provincia & "' , CANTON = '" & dc.canton & "' , DISTRITO = '" & dc.distrito & "' , CORREO = '" & dc.correo & "', CONTRA = '" & dc.contra & "' WHERE ID_ADMIN = '" & dc.id & "' "

            cm = New SqlCommand(consulta, conn)


            If cm.ExecuteNonQuery Then

                Return True
            Else
                Return False
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False

        Finally

            CerrarConexion()


        End Try


    End Function

End Class
