
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports System.Math
Public Class CLcalcularSistema
    'alcantarillados
    Dim sistema As New CLSistema
    Dim datosSistema As New CDcalcularSistema

    'Ocupamos desde la base de datos
    Dim categoriaTarifa As String
    Dim tipoAbonados As Integer
    Dim tipoSistema As String

    Public Property CategoriaT As String
        Get
            Return categoriaTarifa
        End Get
        Set(value As String)
            categoriaTarifa = value
        End Set
    End Property

    Public Property TipoAbonado As Integer
        Get
            Return tipoAbonados
        End Get
        Set(value As Integer)
            tipoAbonados = value
        End Set
    End Property

    Public Property TipoSistemas As String
        Get
            Return tipoSistema
        End Get
        Set(value As String)
            tipoSistema = value
        End Set
    End Property

    'listo con los tipo de categoria consultamos los precios
    Public Function Calcular(ByVal datos As Dictionary(Of String, Object)) As Dictionary(Of String, Object)


        Dim categori_tarifa As Dictionary(Of String, Object)
        Dim servicio_hidrantes As Dictionary(Of String, Object)
        Dim tarifa As Dictionary(Of String, Object)

        categori_tarifa = datosSistema.categoriaTarifa(CategoriaT, TipoSistemas, TipoAbonado)
        servicio_hidrantes = datosSistema.servicioHidrante(TipoAbonado)
        tarifa = datosSistema.Tarifa(tipoSistema, CategoriaT, TipoAbonado)

        Dim newDatos As New Dictionary(Of String, Object)

        Dim totalConsumo As Decimal
        Dim resta As Integer
        Dim metros As Integer
        Dim alto As Boolean = False
        Dim bandera As Integer = 1
        metros = metrosConsumidos(datos("lectura actual"), datos("lectura nueva"))

        While alto <> True

            If bandera = 1 Then

                If metros <= 10 Then

                    totalConsumo = tarifa("bloqueUno") * metros

                    alto = True

                Else

                    totalConsumo = tarifa("bloqueUno") * 10
                    bandera = 2

                End If

            ElseIf bandera = 2 Then

                If metros <= 30 Then

                    resta = Math.Abs(metros - 10)
                    totalConsumo += tarifa("bloqueDos") * resta

                    alto = True

                Else

                    totalConsumo += tarifa("bloqueDos") * 20
                    bandera = 3

                End If

            ElseIf bandera = 3 Then

                If metros <= 60 Then

                    resta = Math.Abs(metros - 30)
                    totalConsumo += tarifa("bloqueTres") * resta
                    alto = True

                Else

                    totalConsumo += tarifa("bloqueTres") * 30
                    bandera = 3

                End If

            ElseIf bandera = 4 Then

                If metros > 60 Then

                    resta = Math.Abs(metros - 60)

                    totalConsumo = tarifa("bloqueCuatro") * resta

                    alto = True

                End If

            End If

        End While

        alto = False
        bandera = 1
        'calculamos los hidrantes
        Dim consumoHidrante As Decimal

        consumoHidrante = metros * servicio_hidrantes("tarifaMedida")

        'Calculamos el total de todos los datos
        Dim total As Decimal

        Dim totalIva As Decimal

        total += datos("cargos administrativos")
        total += datos("corta reconexion")
        total += datos("otros cargos")
        total += datos("nota credito")
        total += datos("cargos por mora")
        total += categori_tarifa("cargo fijo")
        total += consumoHidrante
        total += totalConsumo

        totalIva = total * datos("iva")
        total += totalIva


        newDatos.Add("monto mts3", totalConsumo)
        newDatos.Add("hidrante", consumoHidrante)
        newDatos.Add("total", total)
        newDatos.Add("metros", metros)
        newDatos.Add("tarifa base", categori_tarifa("cargo fijo"))

        Return newDatos

    End Function

    'calcular metros consumidos
    Public Function metrosConsumidos(actual As Integer, nueva As Integer) As Integer

        Dim metros As Integer

        metros = Math.Abs(actual - nueva)

        Return metros

    End Function

End Class
