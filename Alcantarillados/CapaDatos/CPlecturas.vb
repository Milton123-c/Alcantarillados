Imports System.ComponentModel.Design
Imports System.Data.Sql
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class CPlecturas

    Inherits Conexion

    Dim cmd As SqlCommand
    Dim rd As SqlDataReader
    Dim dp As SqlDataAdapter

    'Cargar la lista de los usuarios
    Public Function cargarLista() As DataSet

        Try
            newConexion()
            Dim consulta As String = "SELECT * FROM TB_USER"

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

    'Buscar por codigo
    Public Function buscarCodigo(ByVal codigo As String) As Integer
        Try
            newConexion()
            Dim consulta As String = "SELECT ID_USER FROM TB_MEDIDOR WHERE NUMERO_MEDIDOR = '" & codigo & "'"
            cmd = New SqlCommand(consulta, conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                Dim id As Integer = rd.Item("ID_USER")
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

    'Cargar datos de los usuarios
    Function cargarUsuario(ByVal id As Integer) As String()
        Try
            newConexion()
            Dim consulta As String = "SELECT NOMBRE, APELLIDOS, CEDULA FROM TB_USER WHERE ID_USER = '" & id & "'"

            cmd = New SqlCommand(consulta, conn)

            rd = cmd.ExecuteReader
            If rd.Read Then
                Dim datos() As String = {rd.Item("NOMBRE"), rd.Item("APELLIDOS"), rd.Item("CEDULA")}
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

    'Cargar la lista de los documentos 
    Function cargarNumeroDocumento(ByVal id As Integer) As DataSet

        Try
            newConexion()
            Dim consulta As String = "SELECT N_DOCUMENTO FROM TB_CARGOS WHERE ID_USER = '" & id & "'"

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

    'Cargar los datos que hacen falta
    Public Function cargarDatos(ByVal id As Integer, ByVal nDocumento As Integer) As Dictionary(Of String, Object)

        Try
            newConexion()
            Dim consulta As String = "SELECT CANCELA, MES, FECHA, ANTERIOR, ACTUAL, MT3, TARIFA, TIPO_ABONADOS, MONTO_M3,
TARIFA_BASE, HIDRANTES, IVA, CARGO_ADMINISTRATIVO,
CORTA_RECONEXION, OTROS_CARGOS, NOTA_CREDITO, TOTAL, SALDO_ARREGLO, MORA, SISTEMA, NUMERO_MEDIDOR FROM TB_CARGOS
INNER JOIN TB_MES_COBRO ON TB_CARGOS.ID_USER = TB_CARGOS.ID_USER
INNER JOIN TB_MEDIDOR ON TB_CARGOS.ID_USER = TB_MEDIDOR.ID_USER
WHERE TB_CARGOS.ID_USER = '" & id & "' AND TB_CARGOS.N_DOCUMENTO = '" & nDocumento & "'"

            cmd = New SqlCommand(consulta, conn)

            rd = cmd.ExecuteReader

            If rd.Read Then
                Dim datos As New Dictionary(Of String, Object)

                datos.Add("cancela", rd.Item("CANCELA"))
                datos.Add("mes", rd.Item("MES"))
                datos.Add("fecha", rd.Item("FECHA"))
                datos.Add("anterior", rd.Item("ANTERIOR"))
                datos.Add("actual", rd.Item("ACTUAL"))
                datos.Add("mt3", rd.Item("MT3"))
                datos.Add("tarifa", rd.Item("TARIFA"))
                datos.Add("tipo abonados", rd.Item("TIPO_ABONADOS"))
                datos.Add("monto mt3", rd.Item("MONTO_M3"))
                datos.Add("tarifa base", rd.Item("TARIFA_BASE"))
                datos.Add("hidrantes", rd.Item("HIDRANTES"))
                datos.Add("iva", rd.Item("IVA"))
                datos.Add("cargo administrativo", rd.Item("CARGO_ADMINISTRATIVO"))
                datos.Add("corta reconexion", rd.Item("CORTA_RECONEXION"))
                datos.Add("otros cargos", rd.Item("OTROS_CARGOS"))
                datos.Add("nota credito", rd.Item("NOTA_CREDITO"))
                datos.Add("total", rd.Item("TOTAL"))
                datos.Add("saldo arreglado", rd.Item("SALDO_ARREGLO"))
                datos.Add("mora", rd.Item("MORA"))
                datos.Add("sistema", rd.Item("SISTEMA"))
                datos.Add("Numero medidor", rd.Item("NUMERO_MEDIDOR"))

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


    'Actualizar datos de los usuarios
    Public Function actualizarUsuario(ByVal datos As Dictionary(Of String, Object)) As Boolean
        Try
            newConexion()
            Dim consulta As String = "UPDATE TB_USER SET 
            NOMBRE = '" & datos("nombre") & "', APELLIDOS = '" & datos("apellidos") & "',
            CEDULA = '" & datos("cedula") & "' WHERE ID_USER = '" & datos("id") & "'"

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

    'Actualizar datos del medidor
    Public Function actualizarMedidor(ByVal id As Integer, ByVal numeroMedidor As String, ByVal anterior As Integer, ByVal actual As Integer, ByVal mt3 As Integer) As Boolean
        Try
            newConexion()
            Dim consulta As String = "UPDATE TB_MEDIDOR SET 
            NUMERO_MEDIDOR = '" & numeroMedidor & "', ANTERIOR = '" & anterior & "', ACTUAL = '" & actual & "',
            MT3 = '" & mt3 & "'
            WHERE ID_USER = '" & id & "'"

            cmd = New SqlCommand(consulta, conn)
            cmd.ExecuteReader()

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False

        Finally
            CerrarConexion()
        End Try
    End Function


    'Actualizar datos del mes de cobro
    Public Function actualizarMesCobro(ByVal mes As String, ByVal fecha As String, fechaVence As String, ByVal id As Integer, nDocumento As Integer, diaVencido As Integer, vencido As Boolean) As Boolean
        Try
            newConexion()
            Dim consulta As String = "UPDATE TB_MES_COBRO SET MES = '" & mes & "', FECHA = '" & fecha & "', 
            FECHA_VENCE = '" & fechaVence & "', DIA_VENCIDO = '" & diaVencido & "',
            VENCIDO = '" & vencido & "' WHERE ID_USER = '" & id & "' AND N_DOCUMENTO = '" & nDocumento & "'"

            cmd = New SqlCommand(consulta, conn)

            cmd.ExecuteReader()

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False

        Finally
            CerrarConexion()
        End Try
    End Function

    'Actualizar datos de los cargos 
    Public Function actualizarCargos(ByVal datos As Dictionary(Of String, Object)) As Boolean

        Try
            newConexion()

            Dim consulta As String = "UPDATE TB_CARGOS SET TARIFA = '" & datos("tarifa") & "', TIPO_ABONADOS =  '" & datos("tipo abonados") & "',
            MONTO_M3 =  '" & datos("monto mts3") & "', TARIFA_BASE =  '" & datos("tarifa base") & "',
            HIDRANTES =  '" & datos("hidrantes") & "', 
            IVA =  '" & datos("iva") & "', 
            CARGO_ADMINISTRATIVO =  '" & datos("cargos administrativos") & "', CORTA_RECONEXION =  '" & datos("corta reconexion") & "', 
            OTROS_CARGOS =  '" & datos("otros cargos") & "', NOTA_CREDITO =  '" & datos("nota credito") & "',
            TOTAL =  '" & datos("total") & "', SALDO_ARREGLO =  '" & datos("saldo arreglado") & "',
            MORA =  '" & datos("mora") & "', SISTEMA = '" & datos("tipo sistema") & "' 
            WHERE ID_USER =  '" & datos("id") & "' AND N_DOCUMENTO =  '" & datos("numero Documento") & "'"

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

    'Insertar nuevos documentos 

    'insertar datos del mes de cobro
    Public Function inserterMesCobro(ByVal datos As Dictionary(Of String, Object)) As Boolean
        Try
            newConexion()

            Dim consulta As String = "insert into TB_MES_COBRO(ID_COBRO, MES, FECHA, ID_USER, N_DOCUMENTO, FECHA_VENCE, DIA_VENCIDO, VENCIDO)
            VALUES((SELECT MAX(ID_COBRO) FROM TB_MES_COBRO) + 1,
            '" & datos("mes") & "', 
            '" & datos("fecha") & "',
            " & datos("id") & ",
            " & datos("documento") & ",
            '" & datos("fecha vencimiento") & "',
             " & datos("dia vencido") & ",
             " & datos("vencido") & " )
            "

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

    'Insertar datos de los cargos
    Public Function insertarDatosDeLosCargos(ByVal datos As Dictionary(Of String, Object)) As Boolean
        Try
            newConexion()

            Dim consulta As String = "insert into TB_CARGOS(ID_CARGOS, TARIFA_BASE, MONTO_M3, OTROS_CARGOS,
            HIDRANTES, MORA, CARGO_ADMINISTRATIVO,
            CORTA_RECONEXION, IVA, NOTA_CREDITO, TOTAL, SALDO_ARREGLO, PAGADO_EN, N_DOCUMENTO, TARIFA,
            CANCELA, ID_USER, TIPO_ABONADOS, SISTEMA)
            VALUES(
            (SELECT MAX(ID_CARGOS) FROM TB_CARGOS) + 1, '" & datos("tarifa base") & "', '" & datos("monto mts3") & "', 
            '" & datos("otros cargos") & "',
            '" & datos("hidrantes") & "', '" & datos("mora") & "' ,'" & datos("cargos administrativos") & "', 
            '" & datos("corta reconexion") & "', '" & datos("iva") & "',
            '" & datos("nota credito") & "', '" & datos("total") & "', '" & datos("saldo arreglado") & "',
            '" & datos("pagado en") & "' ,(select max(N_DOCUMENTO) FROM TB_CARGOS WHERE ID_USER = '" & datos("id") & "') + 1, '" & datos("tarifa") & "',
            '" & datos("cancela") & "', '" & datos("id") & "', '" & datos("tipo abonado") & "', '" & datos("sistema") & "')"

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
End Class

