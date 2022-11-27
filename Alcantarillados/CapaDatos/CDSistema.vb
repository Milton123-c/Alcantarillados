Imports System.Reflection.Metadata.Ecma335
Imports Newtonsoft.Json
Imports System.Data.Sql
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class CDSistema

    Inherits Conexion

    'datos que se usaran
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dp As SqlDataAdapter


    'Cargamos el id del usuario por medio del numero de medidor
    Public Function cargarIdPorllave(ByVal numero_medidor As String) As Integer
        Try
            newConexion()
            Dim consulta As String = "select ID_USER from TB_MEDIDOR where NUMERO_MEDIDOR = '" & numero_medidor & "'"
            cmd = New SqlCommand(consulta, conn)

            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim id As Integer = CStr(dr.Item("ID_USER"))

                Return id
            Else
                Return -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        Finally
            CerrarConexion()
        End Try
    End Function

    'cargamos los numeros de documentos y las fechas del mes y si esta vencido
    Public Function cargarListaDocumento(ByVal id As Integer) As DataSet
        Try
            newConexion()
            Dim consulta As String = "SELECT CONCAT(TB_CARGOS.N_DOCUMENTO,' - ', MES,'- Estado : ' , 

                CASE CANCELA
                 WHEN	1 then 'Pendiente'
                 when 0 then 'Cancelado'
                 END
                ) AS DOCUMENTO, TB_CARGOS.N_DOCUMENTO FROM TB_USER
                INNER JOIN TB_CARGOS ON TB_USER.ID_USER = TB_CARGOS.ID_USER
                INNER JOIN TB_MES_COBRO ON TB_USER.ID_USER = TB_MES_COBRO.ID_USER
                WHERE TB_USER.ID_USER = " & id & ""

            dp = New SqlDataAdapter(consulta, conn)

            Dim datos As New DataSet
            dp.Fill(datos)

            Return datos

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing

        Finally
            CerrarConexion()
        End Try
    End Function

    'Cargar los datos
    Public Function cargarDatos(ByVal id As Integer, ByVal numero_documento As String) As Dictionary(Of String, Object)

        Try
            newConexion()
            Dim consulta As String = "select NOMBRE, APELLIDOS, CEDULA, CELULAR,
            NUMERO_MEDIDOR, ANTERIOR, ACTUAL, MT3,
            NUMERO_CASA, DIRECCION, COLOR, PROVINCIA, CANTON, DISTRITO, BARRIO,
            MES, FECHA, TB_CARGOS.N_DOCUMENTO, FECHA_VENCE, DIA_VENCIDO, VENCIDO,
            TARIFA_BASE, MONTO_M3, OTROS_CARGOS, HIDRANTES, MORA, CARGO_ADMINISTRATIVO, CORTA_RECONEXION, IVA, NOTA_CREDITO, TOTAL,
            SALDO_ARREGLO, PAGADO_EN, TARIFA, CANCELA, TIPO_ABONADOS, SISTEMA
            from TB_USER
            inner join TB_CARGOS on TB_USER.ID_USER = TB_CARGOS.ID_USER
            inner join TB_MEDIDOR on TB_USER.ID_USER = TB_MEDIDOR.ID_USER
            inner join TB_MES_COBRO on TB_USER.ID_USER = TB_MES_COBRO.ID_USER
            inner join TB_RESIDENCIA ON TB_USER.ID_USER = TB_RESIDENCIA.ID_USER
            WHERE TB_USER.ID_USER = " & id & " AND TB_CARGOS.N_DOCUMENTO = " & numero_documento & ""

            cmd = New SqlCommand(consulta, conn)
            dr = cmd.ExecuteReader

            If dr.Read Then

                Dim datos As New Dictionary(Of String, Object)

                datos.Add("nombre", dr.Item("NOMBRE"))
                datos.Add("apellidos", dr.Item("APELLIDOS"))
                datos.Add("cedula", dr.Item("CEDULA"))
                datos.Add("celular", dr.Item("CELULAR"))

                datos.Add("numero medidor", dr.Item("NUMERO_MEDIDOR"))
                datos.Add("anterior", dr.Item("ANTERIOR"))
                datos.Add("actual", dr.Item("ACTUAL"))
                datos.Add("metros", dr.Item("MT3"))

                datos.Add("numero casa", dr.Item("NUMERO_CASA"))
                datos.Add("direccion", dr.Item("DIRECCION"))
                datos.Add("color", dr.Item("COLOR"))
                datos.Add("provincia", dr.Item("PROVINCIA"))
                datos.Add("canton", dr.Item("CANTON"))
                datos.Add("distrito", dr.Item("DISTRITO"))
                datos.Add("barrio", dr.Item("BARRIO"))

                datos.Add("mes", dr.Item("MES"))
                datos.Add("fecha", dr.Item("FECHA"))
                datos.Add("numero documento", dr.Item("N_DOCUMENTO"))
                datos.Add("fecha vencimiento", dr.Item("FECHA_VENCE"))
                datos.Add("dia vencido", dr.Item("DIA_VENCIDO"))
                datos.Add("vencido", dr.Item("VENCIDO"))

                datos.Add("tarifa base", dr.Item("TARIFA_BASE"))
                datos.Add("monto metros cubicos", dr.Item("MONTO_M3"))
                datos.Add("otros cargos", dr.Item("OTROS_CARGOS"))
                datos.Add("hidrantes", dr.Item("HIDRANTES"))
                datos.Add("mora", dr.Item("MORA"))
                datos.Add("cargo administrativo", dr.Item("CARGO_ADMINISTRATIVO"))
                datos.Add("corta de reconexion", dr.Item("CORTA_RECONEXION"))
                datos.Add("iva", dr.Item("IVA"))
                datos.Add("nota credito", dr.Item("NOTA_CREDITO"))
                datos.Add("total", dr.Item("TOTAL"))
                datos.Add("saldo arreglado", dr.Item("SALDO_ARREGLO"))
                datos.Add("pagado en", dr.Item("PAGADO_EN"))
                datos.Add("tarifa", dr.Item("TARIFA"))
                datos.Add("cancela", dr.Item("CANCELA"))
                datos.Add("tipo abonados", dr.Item("TIPO_ABONADOS"))
                datos.Add("sistema", dr.Item("SISTEMA"))

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

    'Cargar las tarifas
    Public Function cargarTarifa(ByVal tipoSistema As String, ByVal categoriaTarifa As String, ByVal abonados As Integer) As Dictionary(Of String, Object)

        Try
            newConexion()

            Dim consulta As String = "select * from tb_Tarifa
            where tipoSistema = '" & tipoSistema & "' and categoriaTarifa = '" & categoriaTarifa & "' and id_abonados = " & abonados & ""

            cmd = New SqlCommand(consulta, conn)

            dr = cmd.ExecuteReader

            If dr.Read Then

                Dim datos As New Dictionary(Of String, Object)

                datos.Add("uno", dr.Item("tarifaUno"))
                datos.Add("dos", dr.Item("tarifaDos"))
                datos.Add("tres", dr.Item("tarifaTres"))
                datos.Add("cuatro", dr.Item("tarifaCuatro"))

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

    'Historia de consumo
    Public Function historiaConsumo(ByVal id As Integer) As DataSet
        Try
            newConexion()
            Dim consulta As String = "select CONCAT(MES, ' -  ' ,Year(FECHA)) AS MF from TB_MES_COBRO WHERE ID_USER = " & id & ""

            dp = New SqlDataAdapter(consulta, conn)

            Dim datos As New DataSet

            dp.Fill(datos)

            Return datos

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing

        Finally
            CerrarConexion()

        End Try
    End Function

    'Pagar documento 
    Public Function pagarDocumento(ByVal id As Integer, ByVal numero_documento As Integer, ByVal paga As String) As Boolean
        Try
            newConexion()

            Dim pagar As String = "update TB_CARGOS set CANCELA = 0, PAGADO_EN = '" & paga & "'
            WHERE ID_USER = " & id & " AND N_DOCUMENTO = " & numero_documento & ""

            cmd = New SqlCommand(pagar, conn)

            cmd.ExecuteNonQuery()

            Return True


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CerrarConexion()
        End Try
    End Function
End Class
