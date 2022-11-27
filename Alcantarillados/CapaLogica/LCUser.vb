

Imports System.Security.Cryptography.X509Certificates

Public Class LCUser


    Dim dc As New CPUsuarios

    'Cargamos la lista de datos
    Public Function cargarLista() As DataSet

        Try

            Dim dc As New CPUsuarios

            Return dc.cargarLista()



        Catch ex As Exception

            Return Nothing

        End Try

    End Function

    'Cargamos los componentes del usuario
    Public Function cargarUsuario(id As Integer) As String()

        Try

            Dim dc As New CPUsuarios

            Return dc.CargarUsuarios(id)


        Catch ex As Exception

            Return Nothing

        End Try

    End Function

    'Cargamos todas las lista de los usuario en esta base de datos
    Public Function cargarTodasLista() As DataSet

        Return dc.cargarTodasLista


    End Function

    'Cargamos los datos del numero de paja
    Public Function cargarPorPaja() As DataSet

        Return dc.cargarPorPaja


    End Function


    'Funcion para eliminar datos
    Public Function EliminarUsuario(Id As Integer) As Boolean

        Return dc.EliminarUsuario(Id)

    End Function

    'Function para actulizar los datos
    Public Function actualizarDatos(id As Integer, nom As String, apell As String, ced As String, telf1 As String, telf2 As String, celul As String, corr As String, numcasa As String, direc As String, colCasa As String, prov As String, cant As String, dist As String, numMedidor As String, domi As Integer, empre As Integer, act As Integer, anter As Integer, metros3 As Integer) As Boolean

        Dim newDc As New CPUsuarios(id, nom, apell, ced, telf1, telf2, celul, corr, numcasa, direc, colCasa, prov, cant, dist, numMedidor, domi, empre, act, anter, metros3)

        Return newDc.actualizarDatos


    End Function

    'Funcion para insertar un nuevo usuario
    Public Function registrarUsuario(id As Integer, nom As String, apell As String, ced As String, telf1 As String, telf2 As String, celul As String, corr As String, numcasa As String, direc As String, colCasa As String, prov As String, cant As String, dist As String, numMedidor As String, domi As Integer, empre As Integer, act As Integer, anter As Integer, metros3 As Integer) As Boolean


        Dim newDc As New CPUsuarios(id, nom, apell, ced, telf1, telf2, celul, corr, numcasa, direc, colCasa, prov, cant, dist, numMedidor, domi, empre, act, anter, metros3)

        Return newDc.registrarUsuario


    End Function


End Class
