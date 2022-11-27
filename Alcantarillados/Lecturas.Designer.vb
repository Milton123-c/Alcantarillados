<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lecturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_listaDocumentos = New System.Windows.Forms.ComboBox()
        Me.btn_seleccionarDocumento = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btn_buscarCodigo = New System.Windows.Forms.Button()
        Me.tb_buscarCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_SELECCIONAR_NOMBRE = New System.Windows.Forms.Button()
        Me.cb_listaNombres = New System.Windows.Forms.ComboBox()
        Me.tb_buscarNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tb_apellidos = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tb_metrosConsumidos = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_lecturaNueva = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_lecturaActual = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_mesCobro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_medidor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_cedula = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lb_estado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.lb_numeroDocumento = New System.Windows.Forms.Label()
        Me.cb_documento = New System.Windows.Forms.CheckBox()
        Me.cb_tipoSistema = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cb_tipoAbonados = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cb_categoriaTarifa = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_mora = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lb_pantallaTotal = New System.Windows.Forms.Label()
        Me.tb_NumeroDocumento = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tb_saldoArreglado = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tb_notaCredito = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tb_iva = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tb_cortaReconexion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tb_cargosAdministrativos = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tb_hidrantes = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tb_montosMts3 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_otrosCargos = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tb_tarifaBase = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cb_listaDocumentos)
        Me.Panel1.Controls.Add(Me.btn_seleccionarDocumento)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.btn_buscarCodigo)
        Me.Panel1.Controls.Add(Me.tb_buscarCodigo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BTN_SELECCIONAR_NOMBRE)
        Me.Panel1.Controls.Add(Me.cb_listaNombres)
        Me.Panel1.Controls.Add(Me.tb_buscarNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 107)
        Me.Panel1.TabIndex = 0
        '
        'cb_listaDocumentos
        '
        Me.cb_listaDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_listaDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cb_listaDocumentos.FormattingEnabled = True
        Me.cb_listaDocumentos.Location = New System.Drawing.Point(647, 59)
        Me.cb_listaDocumentos.Name = "cb_listaDocumentos"
        Me.cb_listaDocumentos.Size = New System.Drawing.Size(149, 28)
        Me.cb_listaDocumentos.TabIndex = 49
        '
        'btn_seleccionarDocumento
        '
        Me.btn_seleccionarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_seleccionarDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_seleccionarDocumento.ForeColor = System.Drawing.Color.Chocolate
        Me.btn_seleccionarDocumento.Location = New System.Drawing.Point(800, 58)
        Me.btn_seleccionarDocumento.Name = "btn_seleccionarDocumento"
        Me.btn_seleccionarDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_seleccionarDocumento.Size = New System.Drawing.Size(118, 29)
        Me.btn_seleccionarDocumento.TabIndex = 48
        Me.btn_seleccionarDocumento.Text = "Seleccionar"
        Me.btn_seleccionarDocumento.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(425, 66)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(217, 20)
        Me.Label28.TabIndex = 46
        Me.Label28.Text = "Seleccionar N Documento"
        '
        'btn_buscarCodigo
        '
        Me.btn_buscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_buscarCodigo.ForeColor = System.Drawing.Color.Chocolate
        Me.btn_buscarCodigo.Location = New System.Drawing.Point(304, 62)
        Me.btn_buscarCodigo.Name = "btn_buscarCodigo"
        Me.btn_buscarCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_buscarCodigo.Size = New System.Drawing.Size(87, 25)
        Me.btn_buscarCodigo.TabIndex = 9
        Me.btn_buscarCodigo.Text = "Buscar"
        Me.btn_buscarCodigo.UseVisualStyleBackColor = True
        '
        'tb_buscarCodigo
        '
        Me.tb_buscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_buscarCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_buscarCodigo.Location = New System.Drawing.Point(206, 66)
        Me.tb_buscarCodigo.Name = "tb_buscarCodigo"
        Me.tb_buscarCodigo.Size = New System.Drawing.Size(75, 19)
        Me.tb_buscarCodigo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Buscar por codigo"
        '
        'BTN_SELECCIONAR_NOMBRE
        '
        Me.BTN_SELECCIONAR_NOMBRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_SELECCIONAR_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_SELECCIONAR_NOMBRE.ForeColor = System.Drawing.Color.Chocolate
        Me.BTN_SELECCIONAR_NOMBRE.Location = New System.Drawing.Point(589, 23)
        Me.BTN_SELECCIONAR_NOMBRE.Name = "BTN_SELECCIONAR_NOMBRE"
        Me.BTN_SELECCIONAR_NOMBRE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_SELECCIONAR_NOMBRE.Size = New System.Drawing.Size(87, 29)
        Me.BTN_SELECCIONAR_NOMBRE.TabIndex = 6
        Me.BTN_SELECCIONAR_NOMBRE.Text = "Seleccionar"
        Me.BTN_SELECCIONAR_NOMBRE.UseVisualStyleBackColor = True
        '
        'cb_listaNombres
        '
        Me.cb_listaNombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_listaNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cb_listaNombres.FormattingEnabled = True
        Me.cb_listaNombres.Location = New System.Drawing.Point(396, 24)
        Me.cb_listaNombres.Name = "cb_listaNombres"
        Me.cb_listaNombres.Size = New System.Drawing.Size(181, 28)
        Me.cb_listaNombres.TabIndex = 4
        '
        'tb_buscarNombre
        '
        Me.tb_buscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_buscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_buscarNombre.Location = New System.Drawing.Point(216, 25)
        Me.tb_buscarNombre.Name = "tb_buscarNombre"
        Me.tb_buscarNombre.Size = New System.Drawing.Size(175, 19)
        Me.tb_buscarNombre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar por nombre:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tb_apellidos)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.tb_metrosConsumidos)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.tb_lecturaNueva)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.tb_lecturaActual)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.dt_fecha)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.tb_mesCobro)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.tb_medidor)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.tb_cedula)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.tb_nombre)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lb_id)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lb_estado)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(392, 436)
        Me.Panel2.TabIndex = 1
        '
        'tb_apellidos
        '
        Me.tb_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_apellidos.Location = New System.Drawing.Point(113, 80)
        Me.tb_apellidos.Name = "tb_apellidos"
        Me.tb_apellidos.Size = New System.Drawing.Size(144, 19)
        Me.tb_apellidos.TabIndex = 29
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(21, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 24)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "Pellidos:"
        '
        'tb_metrosConsumidos
        '
        Me.tb_metrosConsumidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_metrosConsumidos.Enabled = False
        Me.tb_metrosConsumidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_metrosConsumidos.Location = New System.Drawing.Point(308, 340)
        Me.tb_metrosConsumidos.Name = "tb_metrosConsumidos"
        Me.tb_metrosConsumidos.Size = New System.Drawing.Size(75, 19)
        Me.tb_metrosConsumidos.TabIndex = 27
        Me.tb_metrosConsumidos.Text = "9"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(19, 337)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(283, 24)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Metros Cubicos Consumidos:"
        '
        'tb_lecturaNueva
        '
        Me.tb_lecturaNueva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_lecturaNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_lecturaNueva.Location = New System.Drawing.Point(170, 307)
        Me.tb_lecturaNueva.Name = "tb_lecturaNueva"
        Me.tb_lecturaNueva.Size = New System.Drawing.Size(75, 19)
        Me.tb_lecturaNueva.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(19, 304)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(151, 24)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Nueva Lectura:"
        '
        'tb_lecturaActual
        '
        Me.tb_lecturaActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_lecturaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_lecturaActual.Location = New System.Drawing.Point(170, 273)
        Me.tb_lecturaActual.Name = "tb_lecturaActual"
        Me.tb_lecturaActual.Size = New System.Drawing.Size(75, 19)
        Me.tb_lecturaActual.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(19, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Lectura Actual:"
        '
        'dt_fecha
        '
        Me.dt_fecha.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dt_fecha.Location = New System.Drawing.Point(86, 226)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(260, 26)
        Me.dt_fecha.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(19, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Fecha:"
        '
        'tb_mesCobro
        '
        Me.tb_mesCobro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_mesCobro.Enabled = False
        Me.tb_mesCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_mesCobro.Location = New System.Drawing.Point(170, 186)
        Me.tb_mesCobro.Name = "tb_mesCobro"
        Me.tb_mesCobro.Size = New System.Drawing.Size(117, 19)
        Me.tb_mesCobro.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(19, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 24)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Mes de cobro:"
        '
        'tb_medidor
        '
        Me.tb_medidor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_medidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_medidor.Location = New System.Drawing.Point(229, 147)
        Me.tb_medidor.Name = "tb_medidor"
        Me.tb_medidor.Size = New System.Drawing.Size(90, 19)
        Me.tb_medidor.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(19, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Numero de medidor:"
        '
        'tb_cedula
        '
        Me.tb_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_cedula.Location = New System.Drawing.Point(100, 107)
        Me.tb_cedula.Name = "tb_cedula"
        Me.tb_cedula.Size = New System.Drawing.Size(135, 19)
        Me.tb_cedula.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(19, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Cedula:"
        '
        'tb_nombre
        '
        Me.tb_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_nombre.Location = New System.Drawing.Point(113, 47)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(146, 19)
        Me.tb_nombre.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre:"
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lb_id.ForeColor = System.Drawing.SystemColors.Control
        Me.lb_id.Location = New System.Drawing.Point(272, 3)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(0, 22)
        Me.lb_id.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(225, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ID:"
        '
        'lb_estado
        '
        Me.lb_estado.AutoSize = True
        Me.lb_estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lb_estado.ForeColor = System.Drawing.SystemColors.Control
        Me.lb_estado.Location = New System.Drawing.Point(103, 4)
        Me.lb_estado.Name = "lb_estado"
        Me.lb_estado.Size = New System.Drawing.Size(100, 22)
        Me.lb_estado.TabIndex = 9
        Me.lb_estado.Text = "Pendiente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Estado:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_calcular)
        Me.Panel3.Controls.Add(Me.lb_numeroDocumento)
        Me.Panel3.Controls.Add(Me.cb_documento)
        Me.Panel3.Controls.Add(Me.cb_tipoSistema)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.cb_tipoAbonados)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.cb_categoriaTarifa)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.tb_mora)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btn_guardar)
        Me.Panel3.Controls.Add(Me.lb_pantallaTotal)
        Me.Panel3.Controls.Add(Me.tb_NumeroDocumento)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.tb_saldoArreglado)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.tb_total)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.tb_notaCredito)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.tb_iva)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.tb_cortaReconexion)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.tb_cargosAdministrativos)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.tb_hidrantes)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.tb_montosMts3)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.tb_otrosCargos)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.tb_tarifaBase)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(392, 107)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(606, 436)
        Me.Panel3.TabIndex = 2
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.Indigo
        Me.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_calcular.ForeColor = System.Drawing.Color.White
        Me.btn_calcular.Location = New System.Drawing.Point(362, 370)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_calcular.Size = New System.Drawing.Size(159, 27)
        Me.btn_calcular.TabIndex = 58
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'lb_numeroDocumento
        '
        Me.lb_numeroDocumento.AutoSize = True
        Me.lb_numeroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lb_numeroDocumento.ForeColor = System.Drawing.Color.Silver
        Me.lb_numeroDocumento.Location = New System.Drawing.Point(6, 0)
        Me.lb_numeroDocumento.Name = "lb_numeroDocumento"
        Me.lb_numeroDocumento.Size = New System.Drawing.Size(165, 18)
        Me.lb_numeroDocumento.TabIndex = 57
        Me.lb_numeroDocumento.Text = "Numero Documento:"
        '
        'cb_documento
        '
        Me.cb_documento.AutoSize = True
        Me.cb_documento.Location = New System.Drawing.Point(195, 293)
        Me.cb_documento.Name = "cb_documento"
        Me.cb_documento.Size = New System.Drawing.Size(15, 14)
        Me.cb_documento.TabIndex = 56
        Me.cb_documento.UseVisualStyleBackColor = True
        '
        'cb_tipoSistema
        '
        Me.cb_tipoSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_tipoSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cb_tipoSistema.FormattingEnabled = True
        Me.cb_tipoSistema.Items.AddRange(New Object() {"Bombeo y Mixto", "Gravedad", "Planta Potabilizadora"})
        Me.cb_tipoSistema.Location = New System.Drawing.Point(184, 327)
        Me.cb_tipoSistema.Name = "cb_tipoSistema"
        Me.cb_tipoSistema.Size = New System.Drawing.Size(208, 28)
        Me.cb_tipoSistema.TabIndex = 55
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(15, 331)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(163, 24)
        Me.Label29.TabIndex = 54
        Me.Label29.Text = "Tipo De Sistema"
        '
        'cb_tipoAbonados
        '
        Me.cb_tipoAbonados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cb_tipoAbonados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cb_tipoAbonados.FormattingEnabled = True
        Me.cb_tipoAbonados.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cb_tipoAbonados.Location = New System.Drawing.Point(527, 24)
        Me.cb_tipoAbonados.Name = "cb_tipoAbonados"
        Me.cb_tipoAbonados.Size = New System.Drawing.Size(77, 28)
        Me.cb_tipoAbonados.TabIndex = 53
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(335, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(186, 24)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "Tipo de abonados:"
        '
        'cb_categoriaTarifa
        '
        Me.cb_categoriaTarifa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cb_categoriaTarifa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cb_categoriaTarifa.FormattingEnabled = True
        Me.cb_categoriaTarifa.Items.AddRange(New Object() {"Domipre", "Emprego"})
        Me.cb_categoriaTarifa.Location = New System.Drawing.Point(195, 24)
        Me.cb_categoriaTarifa.Name = "cb_categoriaTarifa"
        Me.cb_categoriaTarifa.Size = New System.Drawing.Size(119, 28)
        Me.cb_categoriaTarifa.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 24)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Categoria de Tarifa:"
        '
        'tb_mora
        '
        Me.tb_mora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_mora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_mora.Location = New System.Drawing.Point(485, 291)
        Me.tb_mora.Name = "tb_mora"
        Me.tb_mora.Size = New System.Drawing.Size(75, 19)
        Me.tb_mora.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(306, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 24)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Cargos Por mora:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(158, 370)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_guardar.Size = New System.Drawing.Size(159, 27)
        Me.btn_guardar.TabIndex = 47
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'lb_pantallaTotal
        '
        Me.lb_pantallaTotal.AutoSize = True
        Me.lb_pantallaTotal.BackColor = System.Drawing.Color.Teal
        Me.lb_pantallaTotal.Font = New System.Drawing.Font("Times New Roman", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lb_pantallaTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.lb_pantallaTotal.Location = New System.Drawing.Point(15, 370)
        Me.lb_pantallaTotal.Name = "lb_pantallaTotal"
        Me.lb_pantallaTotal.Size = New System.Drawing.Size(92, 32)
        Me.lb_pantallaTotal.TabIndex = 46
        Me.lb_pantallaTotal.Text = "¢ 6850"
        '
        'tb_NumeroDocumento
        '
        Me.tb_NumeroDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.tb_NumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_NumeroDocumento.Enabled = False
        Me.tb_NumeroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_NumeroDocumento.Location = New System.Drawing.Point(219, 291)
        Me.tb_NumeroDocumento.Name = "tb_NumeroDocumento"
        Me.tb_NumeroDocumento.Size = New System.Drawing.Size(71, 19)
        Me.tb_NumeroDocumento.TabIndex = 45
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(6, 288)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(190, 24)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "Nuevo Documento:"
        '
        'tb_saldoArreglado
        '
        Me.tb_saldoArreglado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_saldoArreglado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_saldoArreglado.Location = New System.Drawing.Point(170, 261)
        Me.tb_saldoArreglado.Name = "tb_saldoArreglado"
        Me.tb_saldoArreglado.Size = New System.Drawing.Size(75, 19)
        Me.tb_saldoArreglado.TabIndex = 43
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(6, 258)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(167, 24)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "Saldo Arreglado:"
        '
        'tb_total
        '
        Me.tb_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_total.Enabled = False
        Me.tb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_total.Location = New System.Drawing.Point(310, 221)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.Size = New System.Drawing.Size(75, 19)
        Me.tb_total.TabIndex = 41
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(252, 218)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 24)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Total:"
        '
        'tb_notaCredito
        '
        Me.tb_notaCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_notaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_notaCredito.Location = New System.Drawing.Point(165, 221)
        Me.tb_notaCredito.Name = "tb_notaCredito"
        Me.tb_notaCredito.Size = New System.Drawing.Size(75, 19)
        Me.tb_notaCredito.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(6, 218)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(159, 24)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Nota de credito:"
        '
        'tb_iva
        '
        Me.tb_iva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_iva.Location = New System.Drawing.Point(275, 107)
        Me.tb_iva.Name = "tb_iva"
        Me.tb_iva.Size = New System.Drawing.Size(75, 19)
        Me.tb_iva.TabIndex = 37
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(215, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 24)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "I.V.A:"
        '
        'tb_cortaReconexion
        '
        Me.tb_cortaReconexion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cortaReconexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_cortaReconexion.Location = New System.Drawing.Point(210, 185)
        Me.tb_cortaReconexion.Name = "tb_cortaReconexion"
        Me.tb_cortaReconexion.Size = New System.Drawing.Size(75, 19)
        Me.tb_cortaReconexion.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(6, 183)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(207, 24)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Corta de reconexion:"
        '
        'tb_cargosAdministrativos
        '
        Me.tb_cargosAdministrativos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cargosAdministrativos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_cargosAdministrativos.Location = New System.Drawing.Point(232, 145)
        Me.tb_cargosAdministrativos.Name = "tb_cargosAdministrativos"
        Me.tb_cargosAdministrativos.Size = New System.Drawing.Size(75, 19)
        Me.tb_cargosAdministrativos.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(5, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(228, 24)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Cargos Administrativos:"
        '
        'tb_hidrantes
        '
        Me.tb_hidrantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_hidrantes.Enabled = False
        Me.tb_hidrantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_hidrantes.Location = New System.Drawing.Point(111, 107)
        Me.tb_hidrantes.Name = "tb_hidrantes"
        Me.tb_hidrantes.Size = New System.Drawing.Size(75, 19)
        Me.tb_hidrantes.TabIndex = 31
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(5, 104)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 24)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Hidrantes:"
        '
        'tb_montosMts3
        '
        Me.tb_montosMts3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_montosMts3.Enabled = False
        Me.tb_montosMts3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_montosMts3.Location = New System.Drawing.Point(170, 69)
        Me.tb_montosMts3.Name = "tb_montosMts3"
        Me.tb_montosMts3.Size = New System.Drawing.Size(75, 19)
        Me.tb_montosMts3.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(5, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(169, 24)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Montos Por MT3:"
        '
        'tb_otrosCargos
        '
        Me.tb_otrosCargos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_otrosCargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_otrosCargos.Location = New System.Drawing.Point(475, 184)
        Me.tb_otrosCargos.Name = "tb_otrosCargos"
        Me.tb_otrosCargos.Size = New System.Drawing.Size(75, 19)
        Me.tb_otrosCargos.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(335, 182)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 24)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Otros Cargos:"
        '
        'tb_tarifaBase
        '
        Me.tb_tarifaBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_tarifaBase.Enabled = False
        Me.tb_tarifaBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tb_tarifaBase.Location = New System.Drawing.Point(399, 69)
        Me.tb_tarifaBase.Name = "tb_tarifaBase"
        Me.tb_tarifaBase.Size = New System.Drawing.Size(75, 19)
        Me.tb_tarifaBase.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(273, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 24)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Tarifa Base:"
        '
        'Lecturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1011, 543)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lecturas"
        Me.Text = "Lectura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_buscarCodigo As Button
    Friend WithEvents tb_buscarCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_SELECCIONAR_NOMBRE As Button
    Friend WithEvents cb_listaNombres As ComboBox
    Friend WithEvents tb_buscarNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lb_estado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_metrosConsumidos As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tb_lecturaNueva As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_lecturaActual As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_mesCobro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_medidor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_cedula As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lb_id As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_guardar As Button
    Friend WithEvents lb_pantallaTotal As Label
    Friend WithEvents tb_NumeroDocumento As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents tb_saldoArreglado As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tb_total As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents tb_notaCredito As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tb_iva As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tb_cortaReconexion As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tb_cargosAdministrativos As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tb_hidrantes As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tb_montosMts3 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tb_otrosCargos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tb_tarifaBase As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tb_mora As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_categoriaTarifa As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_tipoAbonados As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents tb_apellidos As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents cb_listaDocumentos As ComboBox
    Friend WithEvents btn_seleccionarDocumento As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents cb_tipoSistema As ComboBox
    Friend WithEvents cb_documento As CheckBox
    Friend WithEvents lb_numeroDocumento As Label
    Friend WithEvents btn_calcular As Button
End Class
