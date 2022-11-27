Imports Newtonsoft.Json
Public Class Sistema

    Dim clsistema As New CLSistema
    Dim _id As Integer
    Dim numeroDocumento As Integer

    Dim CortaReconexion As String
    Dim arregloPago As String
    Dim notaCredito As String

    Dim categoriaTarifa As String
    Dim tipoSistema As String
    Dim tipoAbonado As Integer
    Dim cancelado As Boolean

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TBN_BUSCAR_Click(sender As Object, e As EventArgs) Handles TBN_BUSCAR.Click

        Dim llave As String = TB_LLAVE.Text
        If llave IsNot "" Then

            Dim id As Integer = clsistema.cargarIdPorllave(llave)

            If id = -1 Then
                MessageBox.Show("No existen datos con el numero de llave: " & llave & "")
            Else
                _id = id
                cargarListaDocumento(id)

            End If
        End If


    End Sub




    Private Sub BTN_PAGAR_Click(sender As Object, e As EventArgs) Handles BTN_PAGAR.Click

        If cancelado Then
            pagarDocumento(_id, numeroDocumento)
            cargarListaDocumento(_id)
            cargarDatos(_id, numeroDocumento)
        Else
            MessageBox.Show("El Pago del mes " & lb_mesCobroDetalles.Text & " esta cancelado")

        End If

    End Sub

    Private Sub BTN_FACTURAR_Click(sender As Object, e As EventArgs) Handles BTN_FACTURAR.Click

        If LB_ID.Text IsNot "" Then
            Dim datos As New Dictionary(Of String, String)
            datos.Add("Nombre", LB_NOMBRES.Text)
            datos.Add("Celular", lb_celularDetalles.Text)
            datos.Add("Cedula", lb_cedulaDetalle.Text)
            datos.Add("Fecha", lb_fechaDetalles.Text)
            datos.Add("Vence", lb_VenceDetalles.Text)
            datos.Add("NumeroMedidor", LB_MEDIDOR.Text)
            datos.Add("Barrio", LB_BARRIO.Text)
            datos.Add("Direccion", lb_direccionDetalles.Text)
            datos.Add("Anterior", lb_anteriorDetalles.Text)
            datos.Add("Actual", lb_actualDetalles.Text)
            datos.Add("Metros", lb_m3Detalles.Text)
            datos.Add("MesCobro", lb_mesCobroDetalles.Text)
            datos.Add("TarifaBase", lb_tarifaBaseDetalles.Text)
            datos.Add("MontoMetross", lb_montoM3Detalles.Text)
            datos.Add("OtrosCargos", lb_otrosCargosDetalles.Text)
            datos.Add("Hidrantes", LB_HIDRANTES.Text)
            datos.Add("Mora", lb_moraDetalles.Text)
            datos.Add("CargoAdmin", lb_cargosAdmiDetalles.Text)
            datos.Add("Arreglo", arregloPago)
            datos.Add("CortaReconexion", CortaReconexion)
            datos.Add("Iva", lb_ivaDetalles.Text)
            datos.Add("NotaCredito", notaCredito)
            datos.Add("SaldoArreglo", arregloPago)
            datos.Add("PagadoEn", lb_pagadoDetalles.Text)
            datos.Add("NumeroDocumento", cb_listaDocumentos.SelectedValue.ToString)
            datos.Add("Tarifa", lb_tarifaDetalles.Text)
            datos.Add("Total", lb_totalDetalles.Text)

            Dim reportes As New Reportes
            reportes.datos = datos
            reportes.Show()

        Else
            MessageBox.Show("Seleccione un documento")
        End If



    End Sub

    'cargarmos la lista de documento
    Private Sub cargarListaDocumento(ByVal id As String)
        Dim datos As DataSet = clsistema.cargarListaDocumento(id)

        If datos IsNot Nothing Then

            If datos.Tables(0).Rows.Count > 0 Then

                cb_listaDocumentos.DataSource = Nothing
                cb_listaDocumentos.DataSource = datos.Tables(0)
                cb_listaDocumentos.DisplayMember = "DOCUMENTO"
                cb_listaDocumentos.ValueMember = "N_DOCUMENTO"
            Else

                MessageBox.Show("No existen datos con el numero de llave: " & id & " ")

            End If

        End If

    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click

        If cb_listaDocumentos.Items.Count > 0 Then

            numeroDocumento = cb_listaDocumentos.SelectedValue

            cargarDatos(_id, numeroDocumento)




        End If

    End Sub

    Private Sub cargarDatos(ByVal id As Integer, ByVal numero_documento As Integer)

        Dim datos As New Dictionary(Of String, Object)
        datos = clsistema.cargarDatos(id, numero_documento)

        If datos IsNot Nothing Then

            'primera ventana 

            CortaReconexion = Format(datos("corta de reconexion"), "0.00")
            notaCredito = Format(datos("nota credito"), "0.00")
            arregloPago = Format(datos("saldo arreglado"), "0.00")

            categoriaTarifa = datos("tarifa")
            tipoSistema = datos("sistema")
            tipoAbonado = datos("tipo abonados")

            cancelado = datos("cancela")

            'estado
            If datos("cancela") Then
                LB_MENSAJE_PAGO.Text = "ESTA A PAGO"
            Else
                LB_MENSAJE_PAGO.Text = "FACTURA CANCELADA"
            End If

            'nombre y apellidos
            LB_NOMBRES.Text = "" & datos("nombre") & " " & datos("apellidos") & ""

            'id
            LB_ID.Text = id

            'cedula
            LB_CEDULA.Text = datos("cedula")

            'barrio
            LB_BARRIO.Text = datos("barrio")

            'medidor
            LB_MEDIDOR.Text = datos("numero medidor")

            'domipre o emprego
            If datos("tarifa") = "Domipre" Then
                LB_DOMIPRE.Text = "SI"
                LB_EMPREGO.Text = "NO"
            Else
                LB_DOMIPRE.Text = "NO"
                LB_EMPREGO.Text = "SI"
            End If

            'mes del cobro
            LB_MES_COBRO.Text = datos("mes")

            'lectura anterior
            LB_LECTURA_ANTERIOR.Text = datos("anterior")

            'lectura actual
            LB_LECTURA_ACTUAL.Text = datos("actual")

            'consumo
            LB_CONSUMO.Text = datos("metros")

            'tarifa base
            LB_TARIFA_BASE.Text = Format(datos("tarifa base"), "0.00")

            'otros cargos
            LB_OTROS_CARGOS.Text = Format(datos("otros cargos"), "0.00")

            'hidrantes
            LB_HIDRANTES.Text = Format(datos("hidrantes"), "0.00")

            'monto mts3
            LB_MONTO_MT3.Text = Format(datos("monto metros cubicos"), "0.00")

            'total
            LB_TOTAL.Text = Format(datos("total"), "0.00")

            '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&6

            'segunda ventana

            'nombre
            lb_nombreDetalles.Text = datos("nombre")

            'apellidos
            lb_apellidosDetalles.Text = datos("apellidos")

            'cedula
            lb_cedulaDetalle.Text = datos("cedula")

            'barrio
            lb_barrioDetalles.Text = datos("barrio")

            'numero medidor
            lb_medidorDetalles.Text = datos("numero medidor")

            'direccion
            lb_direccionDetalles.Text = datos("direccion")

            'celular
            lb_celularDetalles.Text = datos("celular")

            'fecha
            lb_fechaDetalles.Text = datos("fecha")

            'fecha vencida
            lb_VenceDetalles.Text = datos("fecha vencimiento")

            'lectura anterior
            lb_anteriorDetalles.Text = datos("anterior")

            'lectura actual
            lb_actualDetalles.Text = datos("actual")

            'metros cubicos 
            lb_m3Detalles.Text = datos("metros")

            'mes y el año
            Dim fecha As String = "" & datos("mes") & " " & Year(datos("fecha")) & ""
            lb_mesCobroDetalles.Text = fecha

            'tarifa base
            lb_tarifaBaseDetalles.Text = Format(datos("tarifa base"), "0.00")

            'monto mts3
            lb_montoM3Detalles.Text = Format(datos("monto metros cubicos"), "0.00")

            'otros cargos
            lb_otrosCargosDetalles.Text = Format(datos("otros cargos"), "0.00")

            'hidrantes
            lb_hidrantesDetalles.Text = Format(datos("hidrantes"), "0.00")

            'mora
            lb_moraDetalles.Text = Format(datos("mora"), "0.00")

            'cargos administrativos
            lb_cargosAdmiDetalles.Text = Format(datos("cargo administrativo"), "0.00")

            'iva 
            lb_ivaDetalles.Text = Format(datos("iva"), "0.00")

            'total
            lb_totalDetalles.Text = Format(datos("total"), "0.00")

            'pagado en
            lb_pagadoDetalles.Text = datos("pagado en")

            'tarifa
            lb_tarifaDetalles.Text = datos("tarifa")

            'cancelado o no cancelado
            If datos("cancela") Then
                lb_cancelaDetalles.Text = "Pendiente"
            Else
                lb_cancelaDetalles.Text = "Cancelado"
            End If

            'historia de consumo
            historiaConsumo(id)
            tablaCategoria()

        End If

    End Sub

    'historia de consumo
    Public Sub historiaConsumo(ByVal id As Integer)

        Dim datos As DataSet = clsistema.historiaConsumo(id)

        If datos IsNot Nothing Then

            lbx_historioDetalles.DataSource = Nothing
            lbx_historioDetalles.DataSource = datos.Tables(0)
            lbx_historioDetalles.DisplayMember = "MF"

        End If

    End Sub

    'categoria de la tarifa
    Private Sub tablaCategoria()

        Dim datos As New Dictionary(Of String, Object)
        datos = clsistema.cargarTarifa(tipoSistema, categoriaTarifa, tipoAbonado)

        If datos IsNot Nothing Then

            lbx_tablaConsumo.Items.Add(" 1 a 10 = " & datos("uno") & "")
            lbx_tablaConsumo.Items.Add(" 11 a 30 = " & datos("dos") & "")
            lbx_tablaConsumo.Items.Add(" 31 a 60 = " & datos("tres") & "")
            lbx_tablaConsumo.Items.Add(" Más de 61 = " & datos("cuatro") & "")


        End If

    End Sub

    'Funcion para pagar el documento
    Public Sub pagarDocumento(ByVal id As Integer, ByVal numero_documento As Integer)

        Dim resultado As DialogResult = MessageBox.Show("Realizando el pago del mes " & lb_mesCobroDetalles.Text & "", "Realizando pago!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resultado = DialogResult.Yes Then
            If cancelado Then
                Dim pagado As Boolean = clsistema.pagarDocumento(id, numero_documento, paga:="Banco")
                If pagado Then
                    MessageBox.Show("Mes " & lb_mesCobroDetalles.Text & " Pagado")
                Else
                    MessageBox.Show("Error al pagar el Mes del agua", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

End Class