Imports Newtonsoft.Json
Imports System.Data.Sql
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CDcalcularSistema

    Inherits Conexion

    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    'obtenemos la tarifa 
    Public Function Tarifa(ByVal tipoSistema As String, ByVal categoriaTarifa As String, ByVal tipoAbonado As Integer) As Dictionary(Of String, Object)

        Try
            newConexion()
            Dim consulta As String = "select tarifaUno as bloqueUno, tarifaDos as bloqueDos,
            tarifaTres as bloqueTres, tarifaCuatro as bloqueCuatro  from tb_tarifa
            where tipoSistema = '" & tipoSistema & "' and categoriaTarifa = '" & categoriaTarifa & "' and id_abonados = " & tipoAbonado & ""

            cmd = New SqlCommand(consulta, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then

                Dim datos As New Dictionary(Of String, Object)
                datos.Add("bloqueUno", dr.Item("bloqueUno"))
                datos.Add("bloqueDos", dr.Item("bloqueDos"))
                datos.Add("bloqueTres", dr.Item("bloqueTres"))
                datos.Add("bloqueCuatro", dr.Item("bloqueCuatro"))

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

    'obtener los servicio hidrantes

    Public Function servicioHidrante(ByVal idAbonados As Integer) As Dictionary(Of String, Object)


        Try
            newConexion()
            Dim consulta As String = "select tarifaMedida, tarifaFija from tb_servicioHidrantes 
            where id_abonados = " & idAbonados & ""

            cmd = New SqlCommand(consulta, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then

                Dim datos As New Dictionary(Of String, Object)
                datos.Add("tarifaMedida", dr.Item("tarifaMedida"))
                datos.Add("tarifaFija", dr.Item("tarifaFija"))


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

    'obtener las categoria tarifa
    Public Function categoriaTarifa(ByVal tarifa As String, ByVal sistema As String, ByVal abonados As Integer) As Dictionary(Of String, Object)
        Try
            newConexion()

            Dim consulta As String = "select servicioFijo, cargoFijo from tb_categoriaTarifa
            where tarifa = '" & tarifa & "' and
            sistema = '" & sistema & "' 
            and id_abonados = " & abonados & ""

            cmd = New SqlCommand(consulta, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then
                Dim datos As New Dictionary(Of String, Object)
                datos.Add("servicio fijo", dr.Item("servicioFijo"))
                datos.Add("cargo fijo", dr.Item("cargoFijo"))

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

End Class
