Public Class Factura

    Private _nombre As String
    Private _apellidos As String
    Private _cedula As String
    Private _barrio As String
    Private _numeroMedidor As String
    Private _direccion As String
    Private _celular As String
    Private _fecha As String
    Private _vence As String
    Private _anterior As String
    Private _actual As String
    Private _metrosCubicos As String
    Private _tarifaBase As String
    Private _montoCubicos As String
    Private _otrosCargos As String
    Private _hidrantes As String
    Private _mora As String
    Private _cargosAdministrativos As String
    Private _iva As String
    Private _pagadoEn As String
    Private _tarifa As String
    Private _cancela As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property Barrio As String
        Get
            Return _barrio
        End Get
        Set(value As String)
            _barrio = value
        End Set
    End Property

    Public Property NumeroMedidor As String
        Get
            Return _numeroMedidor
        End Get
        Set(value As String)
            _numeroMedidor = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Celular As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property Vence As String
        Get
            Return _vence
        End Get
        Set(value As String)
            _vence = value
        End Set
    End Property

    Public Property Anterior As String
        Get
            Return _anterior
        End Get
        Set(value As String)
            _anterior = value
        End Set
    End Property

    Public Property Actual As String
        Get
            Return _actual
        End Get
        Set(value As String)
            _actual = value
        End Set
    End Property

    Public Property MetrosCubicos As String
        Get
            Return _metrosCubicos
        End Get
        Set(value As String)
            _metrosCubicos = value
        End Set
    End Property

    Public Property TarifaBase As String
        Get
            Return _tarifaBase
        End Get
        Set(value As String)
            _tarifaBase = value
        End Set
    End Property

    Public Property MontoCubicos As String
        Get
            Return _montoCubicos
        End Get
        Set(value As String)
            _montoCubicos = value
        End Set
    End Property

    Public Property OtrosCargos As String
        Get
            Return _otrosCargos
        End Get
        Set(value As String)
            _otrosCargos = value
        End Set
    End Property

    Public Property Hidrantes As String
        Get
            Return _hidrantes
        End Get
        Set(value As String)
            _hidrantes = value
        End Set
    End Property

    Public Property Mora As String
        Get
            Return _mora
        End Get
        Set(value As String)
            _mora = value
        End Set
    End Property

    Public Property CargosAdministrativos As String
        Get
            Return _cargosAdministrativos
        End Get
        Set(value As String)
            _cargosAdministrativos = value
        End Set
    End Property

    Public Property Iva As String
        Get
            Return _iva
        End Get
        Set(value As String)
            _iva = value
        End Set
    End Property

    Public Property PagadoEn As String
        Get
            Return _pagadoEn
        End Get
        Set(value As String)
            _pagadoEn = value
        End Set
    End Property

    Public Property Tarifa As String
        Get
            Return _tarifa
        End Get
        Set(value As String)
            _tarifa = value
        End Set
    End Property

    Public Property Cancela As String
        Get
            Return _cancela
        End Get
        Set(value As String)
            _cancela = value
        End Set
    End Property

    Public Function Datos() As Dictionary(Of String, Object)

        Datos.Add("Nombre", Nombre)
        Datos.Add("Apellidos", Apellidos)
        Datos.Add("Cedula", Cedula)

        Return Datos

    End Function

End Class
