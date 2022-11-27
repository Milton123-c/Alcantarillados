Public Class DatosAdministrador

    'llamamos la clase de la conexion
    Private conexion As New Conexion

    'Declaramos las variables para utilizarlas

    Private nombre, apellidos, cedula, telefono1, telefono2, celular, correo, direccion As String
    Private Contra As String

    'provincias y cantones

    Private lista_provincia() As String = {"ALAJUELA", "CARTAGO", "GUANACASTE", "HEREDIA", "LIMÓN", "PUNTARENAS", "SAN JOSÉ"}
    Private Lista_canton(,) As String = {{"ALAJUELA", "ATENAS", "GRECIA", "GUATUSO", "LOSCHILES", "NARANJO", "OROTINA", "PALMARES", "POAS", "RIO CUARTO", "SAN CARLOS", "SAN MATEO", "SAN RAMON", "SARCHI", "UPALA", "ZARCERO", "", "", "", ""},
        {"CARTAGO", "ALVARADO", "EL GUARCO", "JIMÉNEZ", "LA UNIÓN", "OREAMUNO", "PARAÍSO", "TURRIALBA", "", "", "", "", "", "", "", "", "", "", "", ""},
        {"LIBERIA", "ABANGARES", "BAGACES", "CAÑAS", "CARRILLO", "HOJANCHA", "LA CRUZ", "NANDAYURE", "NICOYA", "SANTA CRUZ", "TILARÁN", "", "", "", "", "", "", "", "", ""},
        {"HEREDIA", "BARVA", "BELÉN", "FLORES", "SAN ISIDRO", "SAN PABLO", "SAN RAFAEL", "SANTA BÁRBARA", "SANTO DOMINGO", "SARAPIQUÍ", "", "", "", "", "", "", "", "", "", ""},
        {"LIMÓN", "GUÁCIMO", "MATINA", "POCOCÍ", "SIQUIRRES", "TALAMANCA", "", "", "", "", "", "", "", "", "", "", "", "", "", ""},
        {"PUNTARENAS", "BUENOS AIRES", "CORREDORES", "COTO BRUS", "ESPERANZA", "GARABITO", "GOLFITO", "MONTES DE ORO", "MONTEVERDE", "OSA", "PARRITA", "PUERTO JIMÉNEZ", "QUEPOS", "", "", "", "", "", "", ""},
        {"SAN JOSE", "ACOSTA", "ALAJUELITA", "ASERRÍ", "CURRIDABAT", "DESAMPARADOS", "DOTA", "ESCAZÚ", "GOICOECHEA", "LEÓN CORTÉS", "MONTES DE OCA", "MORA", "MORAVIA", "PÉREZ ZELEDÓN", "PURISCAL", "SANTA ANA", "TARRAZÚ", "TIBÁS", "TURRUBARES", "VÁZQUEZ DE CORONADO"}}


    'Abilitar los cantones en el TB_CANTON
    Private canton_cb As Boolean = True


    'Variable para activar y desactivar el boton de actualizacion
    Private bandera As Integer = 1

    'Boton para ver la contraseña
    Private botonVer As Boolean = True



    'Comprabando datos vacios

    Private Function DatosVacios() As Boolean


        If TB_ID.Text = "" Or TB_NOMBRE.Text = "" Or TB_APELLIDOS.Text = "" Or TB_CEDULA.Text = "" Or TB_TELEFONO1.Text = "" Or TB_TELEFONO2.Text = "" Or TB_CELULAR.Text = "" Or TB_DIRECCION.Text = "" Or TB_PROVINCIA.Text = "" Or TB_CANTON.Text = "" Or TB_DISTRITO.Text = "" Or TB_CONTRA.Text = "" Or TB_CORREO.Text = "" Then

            Return False

        Else
            Return True


        End If

    End Function

    Private Sub BTN_ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR.Click

        Dim opcion As DialogResult

        Dim dc As New LCactualizarAdmin
        Dim resultado As Boolean
        Dim i As Integer = Val(TB_ID.Text)
        opcion = MessageBox.Show("Actualizando Datos", "Actualización de datos", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then

            If DatosVacios() = False Then
                MessageBox.Show("Los Campos no pueden estar vacios")

            Else

                resultado = dc.ActualizandoAdmin(TB_NOMBRE.Text, TB_APELLIDOS.Text, TB_CEDULA.Text, TB_TELEFONO1.Text, TB_TELEFONO2.Text, TB_CELULAR.Text, TB_CORREO.Text, TB_PROVINCIA.Text, TB_CANTON.Text, TB_DISTRITO.Text, Val(TB_ID.Text), TB_CONTRA.Text, TB_DIRECCION.Text)

                If resultado Then

                    MessageBox.Show("1 Dato Actualizado")
                    LimpiarComponentes()
                    CargarAdministradorActual(Val(i))
                    ListaDatos()


                Else
                    MessageBox.Show("Error al actualizar dato")
                End If

            End If

        End If

    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click

        Dim opcion As DialogResult

        Dim id_eliminar As Integer

        Dim errorEliminar As Boolean

        id_eliminar = Val(TB_ID.Text)

        Dim dc As New LCactualizarAdmin

        opcion = MessageBox.Show("Eliminando Administrador", "ELIMINAR", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then

            errorEliminar = dc.EliminarAdmin(id_eliminar)

            MessageBox.Show("Administrador Eliminado!!")

            If errorEliminar = False Then
                MessageBox.Show("Error al eliminar el administrador")
            End If

            ListaDatos()
            LimpiarComponentes()

            CargarAdministradorActual(0)

        End If


    End Sub

    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click

        If ActivarBoton(bandera, "Nuevo") Then

            TB_ID.Enabled = True
            BTN_GUARDAR.Enabled = True

            BTN_NUEVO.Enabled = False


            canton_cb = True

            Me.bandera = 2
        End If

    End Sub

    Private Sub BTN_GUARDAR_Click_1(sender As Object, e As EventArgs) Handles BTN_GUARDAR.Click

        Dim opcion As DialogResult

        opcion = MessageBox.Show("Agregando Nuevo Administrador a la base de datos", "Agregando Administrador!", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            If ActivarBoton(bandera, "Guardar") Then



                BTN_NUEVO.Enabled = True
                TB_ID.Enabled = False
                BTN_GUARDAR.Enabled = False

                Dim datos As New ActualizarAdmin

                Insertar()

                canton_cb = False

                LimpiarComponentes()
                ListaDatos()


                Me.bandera = 1
            End If

        Else
            BTN_NUEVO.Enabled = True
            TB_ID.Enabled = False
            BTN_GUARDAR.Enabled = False

            canton_cb = False
            Me.bandera = 1

        End If





    End Sub

    'Limpiar todos 

    Private Sub LimpiarComponentes()

        TB_ID.Clear()
        TB_NOMBRE.Clear()
        TB_APELLIDOS.Clear()
        TB_CEDULA.Clear()
        TB_TELEFONO1.Clear()
        TB_TELEFONO2.Clear()
        TB_CELULAR.Clear()
        TB_CORREO.Clear()
        TB_DIRECCION.Clear()
        TB_CONTRA.Clear()

        TB_DISTRITO.Clear()

    End Sub

    Private provincia, canton, distrito As String

    Private Sub TB_PROVINCIA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TB_PROVINCIA.SelectedIndexChanged
        Select Case TB_PROVINCIA.Text

            Case "ALAJUELA"

                Dim alajuela() As String = {Lista_canton(0, 0), Lista_canton(0, 1), Lista_canton(0, 2), Lista_canton(0, 3), Lista_canton(0, 4), Lista_canton(0, 5), Lista_canton(0, 6), Lista_canton(0, 7), Lista_canton(0, 8), Lista_canton(0, 9), Lista_canton(0, 10), Lista_canton(0, 11), Lista_canton(0, 12), Lista_canton(0, 13), Lista_canton(0, 14), Lista_canton(0, 15)}
                TB_CANTON.DataSource = alajuela
                TB_CANTON.SelectedIndex = 0

            Case "CARTAGO"
                Dim cartago() As String = {Lista_canton(1, 0), Lista_canton(1, 1), Lista_canton(1, 2), Lista_canton(1, 3), Lista_canton(1, 4), Lista_canton(1, 5), Lista_canton(1, 6), Lista_canton(1, 7)}
                TB_CANTON.DataSource = cartago
                TB_CANTON.SelectedIndex = 0

            Case "GUANACASTE"

                Dim guanacaste() As String = {Lista_canton(2, 0), Lista_canton(2, 1), Lista_canton(2, 2), Lista_canton(2, 3), Lista_canton(2, 4), Lista_canton(2, 5), Lista_canton(2, 6), Lista_canton(2, 7), Lista_canton(2, 8), Lista_canton(2, 9), Lista_canton(2, 10)}
                TB_CANTON.DataSource = guanacaste
                TB_CANTON.SelectedIndex = 0

            Case "HEREDIA"

                Dim heredia() As String = {Lista_canton(3, 0), Lista_canton(3, 1), Lista_canton(3, 2), Lista_canton(3, 3), Lista_canton(3, 4), Lista_canton(3, 5), Lista_canton(3, 6), Lista_canton(3, 7), Lista_canton(3, 8), Lista_canton(3, 9)}
                TB_CANTON.DataSource = heredia
                TB_CANTON.SelectedIndex = 0

            Case "LIMÓN"

                Dim limon() As String = {Lista_canton(4, 0), Lista_canton(4, 1), Lista_canton(4, 2), Lista_canton(4, 3), Lista_canton(4, 4), Lista_canton(4, 5)}
                TB_CANTON.DataSource = limon
                TB_CANTON.SelectedIndex = 0

            Case "PUNTARENAS"

                Dim puntarenas() As String = {Lista_canton(5, 0), Lista_canton(5, 1), Lista_canton(5, 2), Lista_canton(5, 3), Lista_canton(5, 4), Lista_canton(5, 5), Lista_canton(0, 6), Lista_canton(0, 7), Lista_canton(0, 8), Lista_canton(0, 9), Lista_canton(0, 10), Lista_canton(0, 11), Lista_canton(0, 12)}


                TB_CANTON.DataSource = puntarenas
                TB_CANTON.SelectedIndex = 0

            Case "SAN JOSÉ"

                Dim sanJose() As String = {Lista_canton(6, 0), Lista_canton(6, 1), Lista_canton(6, 2), Lista_canton(6, 3), Lista_canton(6, 4), Lista_canton(6, 5), Lista_canton(6, 6), Lista_canton(6, 7), Lista_canton(6, 8), Lista_canton(6, 9), Lista_canton(6, 10), Lista_canton(6, 11), Lista_canton(6, 12), Lista_canton(6, 13), Lista_canton(6, 14), Lista_canton(6, 15), Lista_canton(6, 16), Lista_canton(6, 17), Lista_canton(6, 18), Lista_canton(6, 19)}
                TB_CANTON.DataSource = sanJose
                TB_CANTON.SelectedIndex = 0

        End Select
    End Sub

    Private Sub BTN_VER_Click(sender As Object, e As EventArgs) Handles BTN_VER.Click

        Dim contrase As String = TB_CONTRA.Text

        If botonVer Then
            TB_CONTRA.PasswordChar = ""
            botonVer = False
        Else
            TB_CONTRA.PasswordChar = "*"
            botonVer = True
        End If

    End Sub



    Private Sub BTN_SELECCIONAR_Click(sender As Object, e As EventArgs) Handles BTN_SELECCIONAR.Click

        Dim id_admin As Integer

        id_admin = Val(CB_LISTA.SelectedValue)

        Dim opcion As DialogResult

        opcion = MessageBox.Show("Seleccionar Usuario", "ADMINISTRADOR", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            CargarAdministradorActual(id_admin)
        End If

    End Sub

    Private id As Integer

    'CARGAR CANTONES Y PROVINCIAS
    Private Sub cargarProvincias()
        TB_PROVINCIA.DataSource = lista_provincia

        Select Case TB_PROVINCIA.Text

            Case "ALAJUELA"

                Dim alajuela() As String = {Lista_canton(0, 0), Lista_canton(0, 1), Lista_canton(0, 2), Lista_canton(0, 3), Lista_canton(0, 4), Lista_canton(0, 5), Lista_canton(0, 6), Lista_canton(0, 7), Lista_canton(0, 8), Lista_canton(0, 9), Lista_canton(0, 10), Lista_canton(0, 11), Lista_canton(0, 12), Lista_canton(0, 13), Lista_canton(0, 14), Lista_canton(0, 15)}
                TB_CANTON.DataSource = alajuela
                TB_CANTON.SelectedIndex = 0

            Case "CARTAGO"
                Dim cartago() As String = {Lista_canton(1, 0), Lista_canton(1, 1), Lista_canton(1, 2), Lista_canton(1, 3), Lista_canton(1, 4), Lista_canton(1, 5), Lista_canton(1, 6), Lista_canton(1, 7)}
                TB_CANTON.DataSource = cartago
                TB_CANTON.SelectedIndex = 0

            Case "GUANACASTE"

                Dim guanacaste() As String = {Lista_canton(2, 0), Lista_canton(2, 1), Lista_canton(2, 2), Lista_canton(2, 3), Lista_canton(2, 4), Lista_canton(2, 5), Lista_canton(2, 6), Lista_canton(2, 7), Lista_canton(2, 8), Lista_canton(2, 9), Lista_canton(2, 10)}
                TB_CANTON.DataSource = guanacaste
                TB_CANTON.SelectedIndex = 0

            Case "HEREDIA"

                Dim heredia() As String = {Lista_canton(3, 0), Lista_canton(3, 1), Lista_canton(3, 2), Lista_canton(3, 3), Lista_canton(3, 4), Lista_canton(3, 5), Lista_canton(3, 6), Lista_canton(3, 7), Lista_canton(3, 8), Lista_canton(3, 9)}
                TB_CANTON.DataSource = heredia
                TB_CANTON.SelectedIndex = 0

            Case "LIMÓN"

                Dim limon() As String = {Lista_canton(4, 0), Lista_canton(4, 1), Lista_canton(4, 2), Lista_canton(4, 3), Lista_canton(4, 4), Lista_canton(4, 5)}
                TB_CANTON.DataSource = limon
                TB_CANTON.SelectedIndex = 0

            Case "PUNTARENAS"

                Dim puntarenas() As String = {Lista_canton(5, 0), Lista_canton(5, 1), Lista_canton(5, 2), Lista_canton(5, 3), Lista_canton(5, 4), Lista_canton(5, 5), Lista_canton(0, 6), Lista_canton(0, 7), Lista_canton(0, 8), Lista_canton(0, 9), Lista_canton(0, 10), Lista_canton(0, 11), Lista_canton(0, 12)}


                TB_CANTON.DataSource = puntarenas
                TB_CANTON.SelectedIndex = 0

            Case "SAN JOSÉ"

                Dim sanJose() As String = {Lista_canton(6, 0), Lista_canton(6, 1), Lista_canton(6, 2), Lista_canton(6, 3), Lista_canton(6, 4), Lista_canton(6, 5), Lista_canton(6, 6), Lista_canton(6, 7), Lista_canton(6, 8), Lista_canton(6, 9), Lista_canton(6, 10), Lista_canton(6, 11), Lista_canton(6, 12), Lista_canton(6, 13), Lista_canton(6, 14), Lista_canton(6, 15), Lista_canton(6, 16), Lista_canton(6, 17), Lista_canton(6, 18), Lista_canton(6, 19)}
                TB_CANTON.DataSource = sanJose
                TB_CANTON.SelectedIndex = 0

        End Select

    End Sub

    Private Sub DatosAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarProvincias()


        ListaDatos()
        CargarAdministradorActual(0)



    End Sub

    'insertar datos 
    Private Sub Insertar()

        Try
            Dim lc As New LCactualizarAdmin

            ObteniendoDatos()

            lc.InsertarAdministrador(nombre, apellidos, cedula, telefono1, telefono2, celular, correo, provincia, canton, distrito, id, Contra, direccion)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub



    'Obteniendo datos nuevos para una posible modificacion

    Private Sub ObteniendoDatos()

        id = Val(TB_ID.Text)
        nombre = TB_NOMBRE.Text
        apellidos = TB_APELLIDOS.Text
        cedula = TB_CEDULA.Text
        telefono1 = TB_TELEFONO1.Text
        telefono2 = TB_TELEFONO2.Text
        celular = TB_CELULAR.Text
        correo = TB_CORREO.Text
        direccion = TB_DIRECCION.Text
        Contra = TB_CONTRA.Text

        provincia = TB_PROVINCIA.Text
        canton = TB_CANTON.Text
        distrito = TB_DISTRITO.Text

    End Sub


    'Obteniendo lista de datos para llenar el combobox
    Private Sub ListaDatos()

        Try

            Dim dc As New LCactualizarAdmin

            Dim ds As New DataSet

            ds = dc.ListaAdministradores

            CB_LISTA.DataSource = ds.Tables(0)
            CB_LISTA.DisplayMember = "NOMBRE"
            CB_LISTA.ValueMember = "ID_ADMIN"


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Funcion para activar los botones de nuevo administrador
    Private Function ActivarBoton(ByVal valor As Integer, ByVal boton As String) As Boolean


        Select Case boton
            Case "Nuevo"

                If valor = 1 Then
                    Return True
                Else
                    Return False
                End If

            Case "Guardar"

                If valor = 2 Then
                    Return True

                Else
                    Return False
                End If

            Case Else

                Return False

        End Select



    End Function


    'Cargando los datos del administrador

    Private Sub CargarAdministradorActual(ByVal id As Integer)

        Dim dc As New LCactualizarAdmin()

        Dim datos() As String = dc.DatosAdminActual(id)

        If datos.Length <> 1 Then

            LimpiarComponentes()

            TB_ID.Text = datos(0)
            TB_NOMBRE.Text = datos(1)
            TB_APELLIDOS.Text = datos(2)
            TB_CEDULA.Text = datos(3)
            TB_TELEFONO1.Text = datos(4)
            TB_TELEFONO2.Text = datos(5)
            TB_CELULAR.Text = datos(6)
            TB_DIRECCION.Text = datos(7)


            TB_PROVINCIA.SelectedItem = datos(8).ToString


            TB_CANTON.DataSource = Nothing
            TB_CANTON.Items.Clear()


            TB_CANTON.Items.Add(datos(9))
            TB_CANTON.SelectedIndex = 0

            TB_DISTRITO.Text = datos(10)
            TB_CORREO.Text = datos(11)
            TB_CONTRA.Text = datos(12)

        Else
            MessageBox.Show("No Existen datos")
        End If


    End Sub



End Class