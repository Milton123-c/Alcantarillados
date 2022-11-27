Imports System.CodeDom
Imports Newtonsoft.Json
Public Class CLSistema

    Dim sistema As New CDSistema
    'Cargamos el id del usuario por medio del numero de medidor
    Public Function cargarIdPorllave(ByVal numero_medidor As String) As Integer
        Return sistema.cargarIdPorllave(numero_medidor)
    End Function

    'cargamos los numeros de documentos y las fechas del mes y si esta vencido
    Public Function cargarListaDocumento(ByVal id As Integer) As DataSet
        Return sistema.cargarListaDocumento(id)
    End Function


    'Cargar los datos
    Public Function cargarDatos(ByVal id As Integer, ByVal numero_documento As String) As Dictionary(Of String, Object)
        Return sistema.cargarDatos(id, numero_documento)
    End Function

    'Cargar las tarifas
    Public Function cargarTarifa(ByVal tipoSistema As String, ByVal categoriaTarifa As String, ByVal abonados As Integer) As Dictionary(Of String, Object)
        Return sistema.cargarTarifa(tipoSistema, categoriaTarifa, abonados)
    End Function

    'Historia de consumo
    Public Function historiaConsumo(ByVal id As Integer) As DataSet
        Return sistema.historiaConsumo(id)
    End Function

    'Pagar documento 
    Public Function pagarDocumento(ByVal id As Integer, ByVal numero_documento As Integer, ByVal paga As String) As Boolean
        Return sistema.pagarDocumento(id, numero_documento, paga)
    End Function

End Class
