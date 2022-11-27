Imports Newtonsoft.Json
Public Class CLlecturas


    Dim lectura As New CPlecturas

    'Buscar por codigo
    Public Function buscarCodigo(ByVal codigo As String) As Integer
        Return lectura.buscarCodigo(codigo)
    End Function

    'Cargar la lista de los usuarios
    Public Function cargarLista() As DataSet
        Return lectura.cargarLista()
    End Function

    'Cargar datos de los usuarios
    Function cargarUsuario(ByVal id As Integer) As String()
        Return lectura.cargarUsuario(id)
    End Function


    'Cargar la lista de los documentos 
    Function cargarNumeroDocumento(ByVal id As Integer) As DataSet
        Return lectura.cargarNumeroDocumento(id)
    End Function

    'Cargar los datos que hacen falta
    Public Function cargarDatos(ByVal id As Integer, ByVal nDocumento As Integer) As Dictionary(Of String, Object)
        Return lectura.cargarDatos(id, nDocumento)
    End Function

    'Actualizar datos de los usuarios
    Public Function actualizarUsuario(ByVal datos As Dictionary(Of String, Object)) As Boolean
        Return lectura.actualizarUsuario(datos)
    End Function

    'Actualizar datos del medidor
    Public Function actualizarMedidor(ByVal id As Integer, ByVal numeroMedidor As String, ByVal anterior As Integer, ByVal actual As Integer, ByVal mt3 As Integer) As Boolean
        Return lectura.actualizarMedidor(id, numeroMedidor, anterior, actual, mt3)
    End Function

    'Actualizar datos del mes de cobro
    Public Function actualizarMesCobro(ByVal mes As String, ByVal fecha As String, fechaVence As String, ByVal id As Integer, nDocumento As Integer, diaVencido As Integer, vencido As Boolean) As Boolean
        Return lectura.actualizarMesCobro(mes, fecha, fechaVence, id, nDocumento, diaVencido, vencido)
    End Function

    'Actualizar datos de los cargos 
    Public Function actualizarCargos(ByVal datos As Dictionary(Of String, Object)) As Boolean
        Return lectura.actualizarCargos(datos)
    End Function

    'insertar datos del mes de cobro
    Public Function inserterMesCobro(ByVal datos As Dictionary(Of String, Object)) As Boolean
        Return lectura.inserterMesCobro(datos)
    End Function

    'Insertar datos de los cargos
    Public Function insertarDatosDeLosCargos(ByVal datos As Dictionary(Of String, Object)) As Boolean
        Return lectura.insertarDatosDeLosCargos(datos)
    End Function



End Class
