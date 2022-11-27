Imports System.ComponentModel.Design
Imports Newtonsoft.Json
Public Class Lecturas

    Dim clectura As New CLlecturas

    Dim activarCalcular As Boolean

    Private Sub Lecturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim r As New Globalization.CultureInfo("es-ES")

        r.NumberFormat.CurrencyGroupSeparator = "."
        r.NumberFormat.NumberDecimalSeparator = "."

        System.Threading.Thread.CurrentThread.CurrentCulture = r

        'Cargamos la lista de los usuarios
        cargarLista()



    End Sub



    Private Sub tb_buscarNombre_TextChanged(sender As Object, e As EventArgs) Handles tb_buscarNombre.TextChanged

        Dim cargarUsuario As DataSet = clectura.cargarLista

        Dim buscar As String = LCase(tb_buscarNombre.Text)
        If buscar IsNot "" Then
            Dim texto As String


            For i As Integer = 0 To cargarUsuario.Tables(0).Rows.Count - 1

                texto = LCase(cargarUsuario.Tables(0).Rows(i)(1) + " " + cargarUsuario.Tables(0).Rows(i)(2))

                If InStr(texto, buscar) = 1 Then

                    cb_listaNombres.SelectedValue = cargarUsuario.Tables(0).Rows(i)(0)

                End If
            Next

        End If


    End Sub



    Private Sub BTN_SELECCIONAR_NOMBRE_Click(sender As Object, e As EventArgs) Handles BTN_SELECCIONAR_NOMBRE.Click

        Dim id As Integer = cb_listaNombres.SelectedValue

        cargarUsuarios(id)

    End Sub

    Private Sub cb_tipoTarifa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_categoriaTarifa.SelectedIndexChanged

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        InsertarActualizar()


    End Sub



    Private Sub btn_seleccionarDocumento_Click(sender As Object, e As EventArgs) Handles btn_seleccionarDocumento.Click

        Dim id As Integer = cb_listaNombres.SelectedValue
        Dim nDocumento As Integer = cb_listaDocumentos.SelectedValue
        cargarDatos(id, nDocumento)
        lb_numeroDocumento.Text = "Numero Documento " + nDocumento.ToString

        activarCalcular = True

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    'Cargamos la lista de los datos 
    Private Sub cargarLista()

        Dim datos As DataSet = clectura.cargarLista

        cb_listaNombres.DataSource = Nothing

        cb_listaNombres.DataSource = datos.Tables(0)
        cb_listaNombres.DisplayMember = "CEDULA"
        cb_listaNombres.ValueMember = "ID_USER"


    End Sub

    'Cargar datos de los usuarios
    Private Sub cargarUsuarios(ByVal id As Integer)
        Dim datos() As String = clectura.cargarUsuario(id)

        If datos IsNot Nothing Then

            'nombre
            tb_nombre.Text = datos(0)
            'apellidos
            tb_apellidos.Text = datos(1)
            'cedula
            tb_cedula.Text = datos(2)
            'Id
            lb_id.Text = id

            cargarNdocumento(id)
        End If
    End Sub

    'cargar lista de documentos
    Private Sub cargarNdocumento(ByVal id As Integer)

        cb_listaDocumentos.DataSource = Nothing

        Dim datos As DataSet = clectura.cargarNumeroDocumento(id)
        cb_listaDocumentos.DataSource = datos.Tables(0)
        cb_listaDocumentos.DisplayMember = "N_DOCUMENTO"
        cb_listaDocumentos.ValueMember = "N_DOCUMENTO"


    End Sub

    'Cargar datos segun el numero de documento
    Private Sub cargarDatos(ByVal id As Integer, ByVal documento As Integer)

        Dim datos As Dictionary(Of String, Object) = clectura.cargarDatos(id, documento)

        If datos IsNot Nothing Then

            'Estado 
            If datos("cancela") Then
                lb_estado.Text = "Pendiente"
            Else
                lb_estado.Text = "Cancelado"
            End If

            'numero de medidor
            tb_medidor.Text = datos("Numero medidor")

            'mes de cobro
            tb_mesCobro.Text = datos("mes")

            'fecha
            dt_fecha.Value = datos("fecha")

            'lectura actual
            tb_lecturaActual.Text = datos("anterior")

            'nueva lectura
            tb_lecturaNueva.Text = datos("actual")

            'metros consumidos
            tb_metrosConsumidos.Text = datos("mt3")

            'cateregoria tarifa
            If datos("tarifa") = "Domipre" Then
                cb_categoriaTarifa.SelectedIndex = 0
            Else
                cb_categoriaTarifa.SelectedIndex = 1
            End If

            'tipo abonados
            cb_tipoAbonados.SelectedIndex = Math.Abs(datos("tipo abonados") - 1)

            'monto por mt3
            tb_montosMts3.Text = Format(datos("monto mt3"), "0.00")

            'tarifa base
            tb_tarifaBase.Text = Format(datos("tarifa base"), "0.00")

            'hidrantes
            tb_hidrantes.Text = Format(datos("hidrantes"), "0.00")

            'iva
            tb_iva.Text = Format(datos("iva"), "0.00")

            'cargos administrativos
            tb_cargosAdministrativos.Text = Format(datos("cargo administrativo"), "0.00")

            'corta de reconexion
            tb_cortaReconexion.Text = Format(datos("corta reconexion"), "0.00")

            'otros cargos
            tb_otrosCargos.Text = Format(datos("otros cargos"), "0.00")

            'nota de credito
            tb_notaCredito.Text = Format(datos("nota credito"), "0.00")

            'total
            tb_total.Text = Format(datos("total"), "0.00")

            'saldo arreglado
            tb_saldoArreglado.Text = Format(datos("saldo arreglado"), "0.00")

            'cargos por mora
            tb_mora.Text = Format(datos("mora"), "0.00")

            'tipo de sistema

            Select Case datos("sistema")
                Case "Bombeo y Mixto"
                    cb_tipoSistema.SelectedIndex = 0
                Case "Gravedad"
                    cb_tipoSistema.SelectedIndex = 1
                Case "Planta Potabilizadora"
                    cb_tipoSistema.SelectedIndex = 2
            End Select


            'total pantalla label 
            lb_pantallaTotal.Text = ""

        End If

    End Sub

    Private Sub cb_documento_CheckedChanged(sender As Object, e As EventArgs) Handles cb_documento.CheckedChanged

        If cb_documento.Checked = True Then

            If cb_listaDocumentos.Items.Count > 0 Then
                Dim numero_documento As Integer

                numero_documento = CStr(cb_listaDocumentos.Items.Count) + 1

                tb_NumeroDocumento.Text = numero_documento
            End If
        Else
            tb_NumeroDocumento.Clear()

        End If

    End Sub

    'Actualizar Documento

    'Actualizar datos de usuario
    Private Sub actualizarUsuario(ByVal id As Integer)

        If tb_nombre.Text IsNot "" And tb_apellidos.Text IsNot "" And tb_cedula.Text IsNot "" Then


            Dim datos As New Dictionary(Of String, Object)
            datos.Add("nombre", tb_nombre.Text)
            datos.Add("apellidos", tb_apellidos.Text)
            datos.Add("cedula", tb_cedula.Text)
            datos.Add("id", id)

            Dim bandera As Boolean = clectura.actualizarUsuario(datos)

            If bandera Then
                MessageBox.Show("Usuario Actualizado")
                cargarUsuarios(id)
            End If

        Else
            MessageBox.Show("No pueden haver campos vacios", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    'Actualizar Medidor
    Private Sub actualizarMedidor(ByVal id As Integer)

        If tb_metrosConsumidos.Text IsNot "" And tb_medidor.Text IsNot "" And tb_lecturaActual.Text IsNot "" And tb_lecturaNueva.Text IsNot "" Then

            Dim bandera As Boolean = clectura.actualizarMedidor(id, tb_medidor.Text, tb_lecturaActual.Text, tb_lecturaNueva.Text, tb_metrosConsumidos.Text)

            If bandera Then
                MessageBox.Show("Los datos del medidor, actualizados")
            End If

        Else
            MessageBox.Show("Los datos del medidor no pueden estar vacios", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    'Actualizar datos del mes de cobro
    Private Sub actualizarMesDeCobro(ByVal id As Integer, ByVal documento As Integer)

        Dim fecha As String = dt_fecha.Value.ToString("yyyy-MM-dd")
        Dim Mes As String = cargarMes(dt_fecha.Value.ToString("MM"))

        'Fecha Vence
        Dim fechaActual As Date
        Dim FechaVence As Date

        fechaActual = fecha
        FechaVence = DateAdd("d", 5, fechaActual)

        'Dia vencido
        Dim diaVencido As Integer = 0

        'Verdad o falso 
        Dim vencido As Boolean = False

        Dim actulizar As Boolean = clectura.actualizarMesCobro(Mes, fecha, FechaVence.ToString("yyyy-MM-dd"), id, documento, diaVencido, vencido)

        If actulizar Then
            MessageBox.Show("Mes de cobro actualizado")
        End If

    End Sub


    'Actualizar Datos de los documentos
    Private Sub actualizarDocumentos()

        Dim datos As New Dictionary(Of String, Object)


        'tarifa
        datos.Add("tarifa", cb_categoriaTarifa.Text)

        'tipo abonados
        Dim abonados As Integer = Val(cb_tipoAbonados.Text)
        datos.Add("tipo abonados", abonados)


        'monto mt3
        Dim montoMts3 As Double = Val(tb_montosMts3.Text)
        datos.Add("monto mts3", montoMts3)


        'tarifa base
        Dim tarifaBase As Double = Val(tb_tarifaBase.Text)
        datos.Add("tarifa base", tarifaBase)

        'hidrantes
        Dim hidrantes As Double = Val(tb_hidrantes.Text)
        datos.Add("hidrantes", hidrantes)

        'iva
        Dim iva As Decimal = Val(tb_iva.Text)
        datos.Add("iva", iva)

        'cargos administrativos
        Dim cargosAdministrativos As Double = Val(tb_cargosAdministrativos.Text)
        datos.Add("cargos administrativos", cargosAdministrativos)

        'corta de reconexion
        Dim cortaReconexion As Double = Val(tb_cortaReconexion.Text)
        datos.Add("corta reconexion", cortaReconexion)

        'otros cargos
        Dim otrosCargos As Double = Val(tb_otrosCargos.Text)
        datos.Add("otros cargos", otrosCargos)

        'nota de credito
        Dim notaCredito As Double = tb_notaCredito.Text
        datos.Add("nota credito", notaCredito)

        'total 
        Dim total As Double = Val(tb_total.Text)
        datos.Add("total", total)

        'saldo arreglado
        Dim saldoArreglado As Double = Val(tb_saldoArreglado.Text)
        datos.Add("saldo arreglado", saldoArreglado)

        'mora
        Dim mora As Double = Val(tb_mora.Text)
        datos.Add("mora", mora)

        'id 
        Dim id As Integer = Val(lb_id.Text)
        datos.Add("id", id)

        'documento
        Dim numeroDocumento As Integer = CStr(cb_listaDocumentos.Text)
        datos.Add("numero Documento", numeroDocumento)

        'topo de sistema
        datos.Add("tipo sistema", cb_tipoSistema.Text)

        Dim actuCargos As Boolean = clectura.actualizarCargos(datos)

        If actuCargos Then
            MessageBox.Show("Datos de los documentos actualizados")
        End If

    End Sub

    'Agregar Nuevos mes de cobro
    Private Sub insertarMesCobro()


        'mes
        Dim mes As String = cargarMes(dt_fecha.Value.ToString("MM"))

        'fecha
        Dim fecha As String = dt_fecha.Value.ToString("yyyy-MM-dd")

        'id
        Dim _id As Integer = CStr(lb_id.Text)

        'numero documento
        Dim documento As Integer = CStr(tb_NumeroDocumento.Text)

        'fecha vencido
        Dim fechaActual As Date = fecha
        Dim fechaVencido As Date = DateAdd("d", 5, fechaActual)

        'dia vencido
        Dim diaVencido As Integer = 0

        'vencido
        Dim vencido As Integer = 0

        Dim newDatos As New Dictionary(Of String, Object)

        newDatos.Add("mes", mes)
        newDatos.Add("fecha", fecha)
        newDatos.Add("id", _id)
        newDatos.Add("documento", documento)
        newDatos.Add("fecha vencimiento", fechaVencido.ToString("yyyy-MM-dd"))
        newDatos.Add("dia vencido", diaVencido)
        newDatos.Add("vencido", vencido)







        Dim insertar As Boolean = clectura.inserterMesCobro(newDatos)

        If insertar Then
            MessageBox.Show("Datos del mes de cobro insertado")
        End If

    End Sub

    'Insertar datos de los documentos
    Public Sub insertarDocumento()

        Dim datos As New Dictionary(Of String, Object)

        'tarifa base
        Dim tarifaBase As Decimal = Decimal.Parse(tb_tarifaBase.Text)
        datos.Add("tarifa base", tarifaBase)

        'monto mts3
        Dim montoMts3 As Decimal = Decimal.Parse(tb_montosMts3.Text)
        datos.Add("monto mts3", montoMts3)

        'otros cargos
        Dim otrosCargos As Decimal = Decimal.Parse(tb_otrosCargos.Text)
        datos.Add("otros cargos", otrosCargos)

        'Hidrantes
        Dim hidrantes As Decimal = Decimal.Parse(tb_hidrantes.Text)
        datos.Add("hidrantes", hidrantes)

        'mora
        Dim mora As Decimal = Decimal.Parse(tb_mora.Text)
        datos.Add("mora", mora)

        'Cargos administrativos
        Dim cargosAdministrativo As Decimal = Decimal.Parse(tb_cargosAdministrativos.Text)
        datos.Add("cargos administrativos", cargosAdministrativo)

        'corta de reconexion
        Dim cortaReconexion As Decimal = Decimal.Parse(tb_cortaReconexion.Text)
        datos.Add("corta reconexion", cortaReconexion)

        'iva
        Dim iva As Decimal = Decimal.Parse(tb_iva.Text)
        datos.Add("iva", iva)

        'nota credito
        Dim notaCredito As Decimal = Decimal.Parse(tb_notaCredito.Text)
        datos.Add("nota credito", notaCredito)

        'total
        Dim total As Decimal = Decimal.Parse(tb_total.Text)
        datos.Add("total", total)

        'saldo arreglado
        Dim saldoArreglado As Decimal = Decimal.Parse(tb_saldoArreglado.Text)
        datos.Add("saldo arreglado", saldoArreglado)

        'pagado en 
        datos.Add("pagado en", "null")

        'numero de documento
        Dim numeroDocumento As Integer = CStr(cb_listaDocumentos.Text)
        datos.Add("numero documento", numeroDocumento)

        'tarifa
        datos.Add("tarifa", cb_categoriaTarifa.Text)

        'cancela
        datos.Add("cancela", True)

        'id usuario
        Dim id As Integer = CStr(lb_id.Text)
        datos.Add("id", id)

        'tipo abonados 
        Dim tipoAbonado As Integer = CStr(cb_tipoAbonados.Text)
        datos.Add("tipo abonado", tipoAbonado)

        'sistema
        datos.Add("sistema", cb_tipoSistema.Text)

        Dim inserDatos As Boolean = clectura.insertarDatosDeLosCargos(datos)

        If inserDatos Then
            MessageBox.Show("Nuevo documento insertado '" & tb_NumeroDocumento.Text & "'")
        End If

    End Sub

    'Verificar si el check esta activo

    Private Sub InsertarActualizar()

        If cb_documento.Checked = True Then

            Dim resultado As DialogResult
            resultado = MessageBox.Show("Insetando a la base de datos un nuevo documento", "Insertanto documento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If resultado = DialogResult.Yes Then
                insertarMesCobro()
                insertarDocumento()

            End If

        Else

            Dim _id As Integer = CStr(lb_id.Text)
            Dim documento As Integer = CStr(cb_listaDocumentos.Text)
            cargarUsuarios(_id)

            actualizarUsuario(_id)
            actualizarMedidor(_id)
            actualizarMesDeCobro(_id, documento)
            actualizarDocumentos()

        End If

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

        If tb_lecturaActual.Text IsNot "" And tb_lecturaNueva.Text IsNot "" Then

            If activarCalcular = True Then

                Dim categoriaTarifa As String = cb_categoriaTarifa.Text
                Dim tipoAbonados As Integer = CStr(cb_tipoAbonados.Text)
                Dim tipoSistema As String = cb_tipoSistema.Text

                Dim calcularSistema As New CLcalcularSistema
                calcularSistema.CategoriaT = categoriaTarifa
                calcularSistema.TipoAbonado = tipoAbonados
                calcularSistema.TipoSistemas = tipoSistema

                Dim datos As New Dictionary(Of String, Object)

                Dim lecturaActual As Integer = CStr(tb_lecturaActual.Text)
                Dim lecturaNueva As Integer = CStr(tb_lecturaNueva.Text)
                Dim iva As Decimal = Decimal.Parse(tb_iva.Text)
                Dim cargosAdminis As Decimal = Decimal.Parse(tb_cargosAdministrativos.Text)
                Dim cortaReconexion As Decimal = Decimal.Parse(tb_cortaReconexion.Text)
                Dim otrosCargos As Decimal = Decimal.Parse(tb_otrosCargos.Text)
                Dim notaCredito As Decimal = Decimal.Parse(tb_notaCredito.Text)
                Dim cargoMora As Decimal = Decimal.Parse(tb_mora.Text)


                datos.Add("lectura actual", lecturaActual)
                datos.Add("lectura nueva", lecturaNueva)
                datos.Add("iva", iva)
                datos.Add("cargos administrativos", cargosAdminis)
                datos.Add("corta reconexion", cortaReconexion)
                datos.Add("otros cargos", otrosCargos)
                datos.Add("nota credito", notaCredito)
                datos.Add("cargos por mora", cargoMora)

                Dim newDatos As Dictionary(Of String, Object) = calcularSistema.Calcular(datos)

                tb_montosMts3.Text = Format(newDatos("monto mts3"), "0.00")
                tb_hidrantes.Text = Format(newDatos("hidrante"), "0.00")
                tb_total.Text = Format(newDatos("total"), "0.00")
                tb_metrosConsumidos.Text = Format(newDatos("metros"), "0.00")
                tb_tarifaBase.Text = Format(newDatos("tarifa base"))
            Else
                MessageBox.Show("No hay documento seleccionado")

            End If

        Else
            MessageBox.Show("No pueden haver campos vacios")

        End If

    End Sub

    Private Sub btn_buscarCodigo_Click(sender As Object, e As EventArgs) Handles btn_buscarCodigo.Click

        If tb_buscarCodigo.Text IsNot "" Then

            Dim codigo As String = tb_buscarCodigo.Text

            Dim newId As Integer = clectura.buscarCodigo(codigo)

            If newId <> -1 Then

                cargarUsuarios(newId)

            Else
                MessageBox.Show("No existe usuario con ese cogido")

            End If

        End If

    End Sub

    'Cargar el mes en cadena de texto 
    Public Function cargarMes(ByVal mes As Integer) As String

        Select Case mes
            Case 1
                Return "Enero"
            Case 2
                Return "Febrero"
            Case 3
                Return "Marzo"
            Case 4
                Return "Abril"
            Case 5
                Return "Mayo"
            Case 6
                Return "Junio"
            Case 7
                Return "Julio"
            Case 8
                Return "Agosto"
            Case 9
                Return "Septiembre"
            Case 10
                Return "Octubre"
            Case 11
                Return "Noviembre"
            Case 12
                Return "Diciembre"

            Case Else
                Return "null"
        End Select

    End Function

End Class