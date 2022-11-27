
Imports System.Data.Sql
Imports System.Runtime.InteropServices

Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CPUsuarios

    Inherits Conexion

    Private cmd As SqlCommand
    Private rd As SqlDataReader
    Private dp As SqlDataAdapter

    'declaramos las variables
    Private Id_ As Integer
    Private nombre As String
    Private apellidos As String
    Private cedula As String
    Private telefono1 As String
    Private telefono2 As String
    Private celular As String
    Private correo As String
    Private numeroCasa As String
    Private direccion As String
    Private colorCasa As String
    Private provincia As String
    Private canton As String
    Private distrito As String
    Private numeroMedidor As String
    Private domipre As Integer
    Private emprego As Integer
    Private anterior As Integer
    Private actual As Integer
    Private mt3 As Integer
    'Inicializamos el constructor
    Public Sub New(id As Integer, nom As String, apell As String, ced As String, telf1 As String, telf2 As String, celul As String, corr As String, numcasa As String, direc As String, colCasa As String, prov As String, cant As String, dist As String, numMedidor As String, domi As Integer, empre As Integer, act As Integer, anter As Integer, metros3 As Integer)
        Id_ = id
        nombre = nom
        apellidos = apell
        cedula = ced
        telefono1 = telf1
        telefono2 = telf2
        celular = celul
        correo = corr
        numeroCasa = numcasa
        direccion = direc
        colorCasa = colCasa
        provincia = prov
        canton = cant
        distrito = dist
        numeroMedidor = numMedidor
        domipre = domi
        emprego = empre
        anterior = anter
        actual = act
        mt3 = metros3


    End Sub

    Public Sub New()

    End Sub


    'Funcion para cargar la lista de los usuarios 
    Public Function cargarLista() As DataSet

        Try

            newConexion()

            Dim lista As New DataSet

            Dim cadena As String = "SELECT * FROM TB_USER"

            dp = New SqlDataAdapter(cadena, conn)

            dp.Fill(lista)

            Return lista


        Catch ex As Exception

            MessageBox.Show(ex.Message)


            Return Nothing

        Finally

            CerrarConexion()


        End Try

    End Function

    'Cargar los datos de los usuarios

    Public Function CargarUsuarios(id As Integer) As String()

        Try

            newConexion()

            Dim consulta As String = "SELECT * FROM TB_USER INNER JOIN TB_RESIDENCIA ON TB_USER.ID_USER = TB_RESIDENCIA.ID_USER INNER JOIN TB_MEDIDOR ON TB_USER.ID_USER = TB_MEDIDOR.ID_USER WHERE TB_USER.ID_USER = '" & id & "' "

            cmd = New SqlCommand(consulta, conn)

            rd = cmd.ExecuteReader

            If rd.Read Then

                Dim datos() As String = {rd.Item("ID_USER"), rd.Item("NOMBRE"), rd.Item("APELLIDOS"), rd.Item("CEDULA"), rd.Item("TELEFONO_1"), rd.Item("TELEFONO_2"), rd.Item("CELULAR"), rd.Item("CORREO"), rd.Item("NUMERO_CASA"), rd.Item("DIRECCION"), rd.Item("COLOR"), rd.Item("PROVINCIA"), rd.Item("CANTON"), rd.Item("DISTRITO"), rd.Item("DOMIPRE"), rd.Item("EMPREGO"), rd.Item("NUMERO_MEDIDOR"), rd.Item("ANTERIOR"), rd.Item("ACTUAL"), rd.Item("MT3")}

                Return datos

            Else
                Return Nothing
            End If

        Catch ex As Exception

            Return Nothing

        Finally

            CerrarConexion()

        End Try

    End Function

    'Cargamos todas las lista de los usaurios disponibles en la base de datos 
    Public Function cargarTodasLista() As DataSet
        Try
            newConexion()

            Dim cadena As String = "SELECT * FROM TB_USER"
            Dim listas As New DataSet
            dp = New SqlDataAdapter(cadena, conn)

            dp.Fill(listas)

            Return listas

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return Nothing

        Finally

            CerrarConexion()

        End Try
    End Function

    'Cargamos por numero de paja
    Public Function cargarPorPaja() As DataSet

        Try
            newConexion()

            Dim cadena As String = "SELECT * FROM TB_MEDIDOR"

            dp = New SqlDataAdapter(cadena, conn)

            Dim l As New DataSet

            dp.Fill(l)

            Return l

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Return Nothing

        Finally
            CerrarConexion()
        End Try

    End Function

    'Funcion para eliminar datos del usuario
    Public Function EliminarUsuario(Id As Integer) As Boolean

        Dim CadenaConexion As String = "Data Source=DESKTOP-HMLK946\SQLEXPRESS;Initial Catalog=DBAYA;Integrated Security=True"

        Dim elimi As New SqlConnection(CadenaConexion)

        Try

            elimi.Open()

            Dim ocmd As New SqlCommand
            ocmd.Connection = elimi
            ocmd.CommandType = CommandType.StoredProcedure
            ocmd.CommandText = "TB_ELIMINAR1"

            ocmd.Parameters.AddWithValue("@BANDERA", Id)

            If ocmd.ExecuteNonQuery Then
                MessageBox.Show("Usuario Eliminado")
                Return True

            Else
                Return False
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False

        Finally
            elimi.Close()

        End Try

    End Function

    'Funcion para actualizar los campos 
    Public Function actualizarDatos() As Boolean
        Dim conex As New SqlConnection(CadenaConexion)

        Try

            conex.Open()

            Dim ocmd As New SqlCommand
            ocmd.Connection = conex
            ocmd.CommandType = CommandType.StoredProcedure
            ocmd.CommandText = "TB_ACTUALIZAR1"

            ocmd.Parameters.AddWithValue("@ID", Id_)
            ocmd.Parameters.AddWithValue("@NOMBRE", nombre)
            ocmd.Parameters.AddWithValue("@APELLIDOS", apellidos)
            ocmd.Parameters.AddWithValue("@CEDULA", cedula)
            ocmd.Parameters.AddWithValue("@TELEFONO_1", telefono1)
            ocmd.Parameters.AddWithValue("@TELEFONO_2", telefono2)
            ocmd.Parameters.AddWithValue("@CELULAR", celular)
            ocmd.Parameters.AddWithValue("@CORREO", correo)
            ocmd.Parameters.AddWithValue("@DOMIPRE", domipre)
            ocmd.Parameters.AddWithValue("@EMPREGO", emprego)
            ocmd.Parameters.AddWithValue("@NUMERO_MEDIDOR", numeroMedidor)
            ocmd.Parameters.AddWithValue("@ANTERIOR", anterior)
            ocmd.Parameters.AddWithValue("@ACTUAL", actual)
            ocmd.Parameters.AddWithValue("@MT3", mt3)
            ocmd.Parameters.AddWithValue("@NUMERO_CASA", numeroCasa)
            ocmd.Parameters.AddWithValue("@DIRECCION", direccion)
            ocmd.Parameters.AddWithValue("@COLOR", colorCasa)
            ocmd.Parameters.AddWithValue("@PROVINCIA", provincia)
            ocmd.Parameters.AddWithValue("@CANTON", canton)
            ocmd.Parameters.AddWithValue("@DISTRITO", distrito)

            If ocmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            conex.Close()
        End Try

    End Function

    'Funcion para Registrar a un nuevo usuario o cliente 
    Public Function registrarUsuario() As Boolean
        Dim conex As New SqlConnection(CadenaConexion)

        Try

            conex.Open()

            Dim ocmd As New SqlCommand
            ocmd.Connection = conex
            ocmd.CommandType = CommandType.StoredProcedure
            ocmd.CommandText = "GUARDAR"

            ocmd.Parameters.AddWithValue("@INCREMENTO", 0)
            ocmd.Parameters.AddWithValue("@NOMBRE", nombre)
            ocmd.Parameters.AddWithValue("@APELLIDOS", apellidos)
            ocmd.Parameters.AddWithValue("@CEDULA", cedula)
            ocmd.Parameters.AddWithValue("@TELEFONO_1", telefono1)
            ocmd.Parameters.AddWithValue("@TELEFONO_2", telefono2)
            ocmd.Parameters.AddWithValue("@CELULAR", celular)
            ocmd.Parameters.AddWithValue("@CORREO", correo)

            ocmd.Parameters.AddWithValue("@DOMIPRE", domipre)
            ocmd.Parameters.AddWithValue("@EMPREGO", emprego)
            ocmd.Parameters.AddWithValue("@NUMERO_MEDIDOR", numeroMedidor)
            ocmd.Parameters.AddWithValue("@ANTERIOR", anterior)
            ocmd.Parameters.AddWithValue("@ACTUAL", actual)
            ocmd.Parameters.AddWithValue("@MT3", mt3)

            ocmd.Parameters.AddWithValue("@NUMERO_CASA", numeroCasa)
            ocmd.Parameters.AddWithValue("@DIRECCION", direccion)
            ocmd.Parameters.AddWithValue("@COLOR", colorCasa)
            ocmd.Parameters.AddWithValue("@PROVINCIA", provincia)
            ocmd.Parameters.AddWithValue("@CANTON", canton)
            ocmd.Parameters.AddWithValue("@DISTRITO", distrito)



            If ocmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            conex.Close()
        End Try




    End Function

End Class
