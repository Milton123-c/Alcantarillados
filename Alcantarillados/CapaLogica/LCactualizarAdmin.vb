Imports System.Data.OleDb
Imports System.Web

Public Class LCactualizarAdmin


    'Funcion para actualizar administrador

    Public Function ActualizandoAdmin(nom As String, ape As String, ced As String, tel1 As String, tel2 As String, cel As String, corr As String, prov As String, cant As String, dist As String, id_ As Integer, password As String, direc As String) As Boolean

        Dim dc As New ActualizarAdmin(nom, ape, ced, tel1, tel2, cel, corr, prov, cant, dist, id_, password, direc)

        If dc.ActualizandoAdmin(dc) = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function InsertarAdministrador(nom As String, ape As String, ced As String, tel1 As String, tel2 As String, cel As String, corr As String, prov As String, cant As String, dist As String, id_ As Integer, password As String, direc As String)


        Dim dc As New ActualizarAdmin(nom, ape, ced, tel1, tel2, cel, corr, prov, cant, dist, id_, password, direc)

        If dc.InsertarAdministrador(dc) = True Then

            Return True

        Else

            Return False


        End If


    End Function

    Public Function ListaAdministradores() As DataSet

        Dim dc As New ActualizarAdmin()

        Return dc.ListaAdministradores()

    End Function

    Public Function DatosAdminActual(id As Integer) As String()

        Try
            Dim dc As New ActualizarAdmin()


            Dim datos() As String = dc.DatosAdminActual(id)

            Return datos

        Catch ex As Exception

            Dim lista() As String = {""}

            Return lista

        End Try


    End Function


    'Llamando la funcion eliminar administrador

    Public Function EliminarAdmin(id As Integer) As Boolean

        Try

            Dim cd As New ActualizarAdmin

            cd.EliminarAdmin(id)

            Return True

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return False

        End Try

    End Function

End Class
