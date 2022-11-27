
Imports Newtonsoft.Json
Imports System.Data.Sql
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CDsesion

    Inherits Conexion

    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    'verificamos si existen datos
    Public Function VerificarUsuario(ByVal correo As String, ByVal contra As String) As Dictionary(Of String, Object)
        Try
            newConexion()
            Dim consulta As String = "select * from TB_ADMIN
            where CORREO = '" & correo & "'
            AND CONTRA = '" & contra & "'"

            cmd = New SqlCommand(consulta, conn)

            dr = cmd.ExecuteReader

            If dr.Read Then

                Dim datos As New Dictionary(Of String, Object)
                datos.Add("id", dr.Item("ID_ADMIN"))
                datos.Add("nombre", dr.Item("NOMBRE"))
                datos.Add("apellidos", dr.Item("APELLIDOS"))
                datos.Add("cedula", dr.Item("CEDULA"))
                datos.Add("telefono 1", dr.Item("TELEFONO_1"))
                datos.Add("telefono 2", dr.Item("TELEFONO_2"))
                datos.Add("celular", dr.Item("CELULAR"))
                datos.Add("direccion", dr.Item("DIRECCION"))
                datos.Add("provincia", dr.Item("PROVINCIA"))
                datos.Add("canton", dr.Item("CANTON"))
                datos.Add("distrito", dr.Item("DISTRITO"))
                datos.Add("correo", dr.Item("CORREO"))
                datos.Add("contraseña", dr.Item("CONTRA"))
                datos.Add("status", dr.Item("STATU"))

                Return datos

            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            CerrarConexion()
        End Try
    End Function

    'Cambiar el status del administrador
    Public Function cambiarStatus(ByVal id As Integer, ByVal stado As Boolean) As Boolean

        Try
            newConexion()
            Dim numero As Integer
            If stado Then
                numero = 1
            Else
                numero = 0
            End If
            Dim consulta As String = "update TB_ADMIN set STATU = " & numero & " WHERE ID_ADMIN = " & id & " "

            cmd = New SqlCommand(consulta, conn)
            cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try

    End Function

    'Funcion para los usuarios sin contraseña 
    Public Function Registrar(codigo As String) As Dictionary(Of String, Object)

        Try

            newConexion()
            Dim consulta As String = "select * from tb_Codigo where codigo = '" & codigo & "'"

            cmd = New SqlCommand(consulta, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then

                Dim datos As New Dictionary(Of String, Object)
                datos.Add("id", dr.Item("id"))
                datos.Add("codigo", dr.Item("codigo"))
                datos.Add("estado", dr.Item("estado"))
                Return datos

            Else
                Return Nothing

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            CerrarConexion()
        End Try

    End Function

    'Funcion para actualizar el codigo si se cerro o sigue abierto
    Public Function CerrarSesion(valor As Boolean, codigo As String) As Integer

        Try
            newConexion()

            Dim consulta As String = "update tb_Codigo set estado = '" & valor & " ' where codigo = '" & codigo & "'"

            cmd = New SqlCommand(consulta, conn)

            cmd.ExecuteNonQuery()

            Return 1

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return 0

        Finally
            CerrarConexion()

        End Try

    End Function

End Class
