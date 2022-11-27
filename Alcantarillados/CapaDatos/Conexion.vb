
Imports System.Data.Sql

Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Conexion

    Public CadenaConexion As String = "Data Source=DESKTOP-HJICU76\SQLEXPRESS;Initial Catalog=DBAYA;Integrated Security=True"

    Public conn As New SqlConnection(CadenaConexion)

    Public Function newConexion() As Boolean

        Try
            conn.Open()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Sub CerrarConexion()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If

        Catch ex As Exception
            Console.WriteLine("Error al cerrar la conexion cerrada")
        End Try
    End Sub

End Class
