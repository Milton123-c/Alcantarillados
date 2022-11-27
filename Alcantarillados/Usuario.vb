Imports FxResources.System

Public Class Usuario

    'Declaramos las variables que vamos a utilizar
    Private nombre, apellidos, cedula, telefono1, telefono2, celular, correo As String

    Private buscarNombre, buscarCedula, buscarPaja As String

    Private listaNombres As String
    Private lecturaConstante As Integer
    'Mantenemos la toda la lista de los usuario en un data set

    Dim todasLista As New DataSet
    Dim listaPorpaja As New DataSet

    Dim Dusuario As New LCUser

    Private NumeroCasa, direccion, colorCasa, provincia, canton, distrito As String

    Private Sub CB_PROVINCIA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PROVINCIA.SelectedIndexChanged
        cargarCantones()
    End Sub

    Private Sub Usuario_load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLista()
        cargarProvincia()
        cargarCantones()
        DomipreEmprego()
        cargarTodasLista()
        cargarListaPorPaja()



    End Sub

    'Cargamos las listas de paja
    Private Sub cargarListaPorPaja()

        listaPorpaja = Dusuario.cargarPorPaja


    End Sub

    'cargamos todas las listas 
    Private Sub loadDatos()
        Dim dc As New LCUser

        todasLista = dc.cargarTodasLista


    End Sub

    Private Sub TB_BUSCAR_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TB_BUSCAR_NOMBRE.TextChanged

        Dim consulta As String = LCase(TB_BUSCAR_NOMBRE.Text)


        If consulta <> "" Then


            If todasLista IsNot Nothing Then


                For index As Integer = 0 To todasLista.Tables(0).Rows.Count - 1

                    Dim texto As String = LCase(todasLista.Tables(0).Rows(index)(1))

                    If texto.IndexOf(consulta) > -1 Then

                        CB_LISTA_BUSCAR.SelectedValue = todasLista.Tables(0).Rows(index)(0)

                    End If

                Next

            End If

        End If

    End Sub

    Private Id As Integer

    Private Sub BTN_BUSCAR_PAJA_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR_PAJA.Click

        Dim paja As String = TB_BUSCAR_PAJA.Text

        CargarPorPaja(paja)

    End Sub

    Private Sub CargarPorPaja(ByVal NP As String)

        Dim datos As New DataSet

        datos = Dusuario.cargarPorPaja
        Dim mensaje As Boolean

        If NP <> "" Then

            If datos IsNot Nothing Then

                For index As Integer = 0 To datos.Tables(0).Rows.Count - 1

                    Dim N_paja As String = datos.Tables(0).Rows(index)(3)

                    If NP = N_paja Then

                        Dim id As Integer = datos.Tables(0).Rows(index)(7)
                        Cargar(id)

                        mensaje = False
                        Exit For
                    Else

                        mensaje = True
                    End If

                Next

                If mensaje Then
                    MessageBox.Show("El numero de paja, no Existe")
                End If

            End If

        End If


    End Sub

    Private Sub Cargar(ByVal id As Integer)

        Dim datos() As String = Dusuario.cargarUsuario(id)

        If datos IsNot Nothing Then

            TB_NOMBRE.Text = datos(1)
            TB_APELLIDOS.Text = datos(2)
            TB_CEDULA.Text = datos(3)
            TB_TELEFONO1.Text = datos(4)
            TB_TELEFONO2.Text = datos(5)
            TB_CELULAR.Text = datos(6)
            TB_CORREO.Text = datos(7)
            TB_ID.Text = datos(0)
            TB_NUMEROCASA.Text = datos(8)
            TB_DIRECCION.Text = datos(9)
            TB_COLORCASA.Text = datos(10)
            TB_DISTRITO.Text = datos(13)
            TB_NUMEROMEDIDOR.Text = datos(16)

            TB_LECTURAACTUAL.Text = datos(18)

            lecturaConstante = CStr(datos(18))

            TB_LECTURAANTERIOR.Text = datos(17)

            Dim lecturasMetrosCubiscos As Integer = metrosCubicos(datos(17), datos(18))
            TB_METROSCUBICOS.Text = lecturasMetrosCubiscos


            Dim valueDomipre As Boolean = datos(14)
            Dim valueEmprego As Boolean = datos(15)



            If valueDomipre = False Then
                CB_DOMIPRE.SelectedItem = "NO"

            ElseIf valueDomipre = True Then
                CB_DOMIPRE.SelectedItem = "SI"

            End If

            If valueEmprego = False Then
                CB_EMPREGO.SelectedItem = "NO"

            ElseIf valueEmprego = True Then
                CB_EMPREGO.SelectedItem = "SI"
            End If

            Dim valueProvincia As String = datos(11)
            Dim valueCanton As String = datos(12)

            CB_PROVINCIA.SelectedItem = valueProvincia
            CB_CANTON.SelectedItem = valueCanton

        Else
            MessageBox.Show("No hay datos")

        End If


    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click

        Dim identificador As Integer

        If TB_ID.Text IsNot "" Then

            If IsNumeric(TB_ID.Text) Then

                identificador = Val(TB_ID.Text)

                Dim mensaje As DialogResult

                mensaje = MessageBox.Show("Eliminando Usuario '" & TB_NOMBRE.Text & "'", "ELIMINANDO USUARIO", MessageBoxButtons.YesNo)


                If mensaje = DialogResult.Yes Then
                    Dim ban As Boolean

                    ban = Dusuario.EliminarUsuario(identificador)
                    cargarLista()
                    limpiarComponentes()

                    If ban = False Then
                        MessageBox.Show("Usuario no eliminado")
                    End If
                End If


            End If

        End If

    End Sub

    Private Sub BTN_BUSCAR_CEDULA_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR_CEDULA.Click

        Dim buscar As String = TB_BUSCAR_CEDULA.Text

        If buscar <> "" Then

            For index As Integer = 0 To todasLista.Tables(0).Rows.Count - 1

                Dim cdl As String = todasLista.Tables(0).Rows(index)(3)

                If buscar = cdl Then

                    Dim identificador As Integer = todasLista.Tables(0).Rows(index)(0)

                    Dim dc As New LCUser

                    Dim datos() As String = dc.cargarUsuario(identificador)

                    If datos IsNot Nothing Then

                        TB_NOMBRE.Text = datos(1)
                        TB_APELLIDOS.Text = datos(2)
                        TB_CEDULA.Text = datos(3)
                        TB_TELEFONO1.Text = datos(4)
                        TB_TELEFONO2.Text = datos(5)
                        TB_CELULAR.Text = datos(6)
                        TB_CORREO.Text = datos(7)
                        TB_ID.Text = datos(0)
                        TB_NUMEROCASA.Text = datos(8)
                        TB_DIRECCION.Text = datos(9)
                        TB_COLORCASA.Text = datos(10)
                        TB_DISTRITO.Text = datos(13)
                        TB_NUMEROMEDIDOR.Text = datos(16)

                        TB_LECTURAACTUAL.Text = datos(18)
                        TB_LECTURAANTERIOR.Text = datos(17)
                        TB_METROSCUBICOS.Text = datos(19)


                        Dim valueDomipre As Boolean = datos(14)
                        Dim valueEmprego As Boolean = datos(15)



                        If valueDomipre = False Then
                            CB_DOMIPRE.SelectedItem = "NO"

                        ElseIf valueDomipre = True Then
                            CB_DOMIPRE.SelectedItem = "SI"

                        End If

                        If valueEmprego = False Then
                            CB_EMPREGO.SelectedItem = "NO"

                        ElseIf valueEmprego = True Then
                            CB_EMPREGO.SelectedItem = "SI"
                        End If

                        Dim valueProvincia As String = datos(11)
                        Dim valueCanton As String = datos(12)

                        CB_PROVINCIA.SelectedItem = valueProvincia
                        CB_CANTON.SelectedItem = valueCanton

                    Else
                        MessageBox.Show("No hay datos")

                    End If



                End If

            Next

        End If


    End Sub

    Private Sub BTN_RECARGAR_Click(sender As Object, e As EventArgs) Handles BTN_RECARGAR.Click
        cargarLista()

    End Sub

    Private numeroMedidor, domipre, emprego As String



    Private Sub TB_LECTURAACTUAL_TextChanged(sender As Object, e As EventArgs) Handles TB_LECTURAACTUAL.TextChanged

        Dim LecturaActual As Integer = Val(TB_LECTURAACTUAL.Text)

        Dim LecturaAnterior As Integer = lecturaConstante

        Dim total As Integer = metrosCubicos(LecturaAnterior, LecturaActual)
        TB_LECTURAANTERIOR.Text = LecturaAnterior
        TB_METROSCUBICOS.Text = total
    End Sub



    Private lista_provincia() As String = {"ALAJUELA", "CARTAGO", "GUANACASTE", "HEREDIA", "LIMÓN", "PUNTARENAS", "SAN JOSÉ"}
    Private Lista_canton(,) As String = {{"ALAJUELA", "ATENAS", "GRECIA", "GUATUSO", "LOSCHILES", "NARANJO", "OROTINA", "PALMARES", "POAS", "RIO CUARTO", "SAN CARLOS", "SAN MATEO", "SAN RAMON", "SARCHI", "UPALA", "ZARCERO", "", "", "", ""},
        {"CARTAGO", "ALVARADO", "EL GUARCO", "JIMÉNEZ", "LA UNIÓN", "OREAMUNO", "PARAÍSO", "TURRIALBA", "", "", "", "", "", "", "", "", "", "", "", ""},
        {"LIBERIA", "ABANGARES", "BAGACES", "CAÑAS", "CARRILLO", "HOJANCHA", "LA CRUZ", "NANDAYURE", "NICOYA", "SANTA CRUZ", "TILARÁN", "", "", "", "", "", "", "", "", ""},
        {"HEREDIA", "BARVA", "BELÉN", "FLORES", "SAN ISIDRO", "SAN PABLO", "SAN RAFAEL", "SANTA BÁRBARA", "SANTO DOMINGO", "SARAPIQUÍ", "", "", "", "", "", "", "", "", "", ""},
        {"LIMÓN", "GUÁCIMO", "MATINA", "POCOCÍ", "SIQUIRRES", "TALAMANCA", "", "", "", "", "", "", "", "", "", "", "", "", "", ""},
        {"PUNTARENAS", "BUENOS AIRES", "CORREDORES", "COTO BRUS", "ESPERANZA", "GARABITO", "GOLFITO", "MONTES DE ORO", "MONTEVERDE", "OSA", "PARRITA", "PUERTO JIMÉNEZ", "QUEPOS", "", "", "", "", "", "", ""},
        {"SAN JOSE", "ACOSTA", "ALAJUELITA", "ASERRÍ", "CURRIDABAT", "DESAMPARADOS", "DOTA", "ESCAZÚ", "GOICOECHEA", "LEÓN CORTÉS", "MONTES DE OCA", "MORA", "MORAVIA", "PÉREZ ZELEDÓN", "PURISCAL", "SANTA ANA", "TARRAZÚ", "TIBÁS", "TURRUBARES", "VÁZQUEZ DE CORONADO"}}





    'CARGMOS LA PROVINCIA Y LOS CANTONES
    Private Sub cargarProvincia()

        CB_PROVINCIA.DataSource = lista_provincia

    End Sub

    'cargar los cantones 
    Private Sub cargarCantones()

        Dim bandera As String = CB_PROVINCIA.Text

        Select Case bandera

            Case "ALAJUELA"

                Dim alajuela() As String = {Lista_canton(0, 0), Lista_canton(0, 1), Lista_canton(0, 2), Lista_canton(0, 3), Lista_canton(0, 4), Lista_canton(0, 5), Lista_canton(0, 6), Lista_canton(0, 7), Lista_canton(0, 8), Lista_canton(0, 9), Lista_canton(0, 10), Lista_canton(0, 11), Lista_canton(0, 12), Lista_canton(0, 13), Lista_canton(0, 14), Lista_canton(0, 15)}
                CB_CANTON.DataSource = alajuela
                CB_CANTON.SelectedIndex = 0

            Case "CARTAGO"
                Dim cartago() As String = {Lista_canton(1, 0), Lista_canton(1, 1), Lista_canton(1, 2), Lista_canton(1, 3), Lista_canton(1, 4), Lista_canton(1, 5), Lista_canton(1, 6), Lista_canton(1, 7)}
                CB_CANTON.DataSource = cartago
                CB_CANTON.SelectedIndex = 0

            Case "GUANACASTE"

                Dim guanacaste() As String = {Lista_canton(2, 0), Lista_canton(2, 1), Lista_canton(2, 2), Lista_canton(2, 3), Lista_canton(2, 4), Lista_canton(2, 5), Lista_canton(2, 6), Lista_canton(2, 7), Lista_canton(2, 8), Lista_canton(2, 9), Lista_canton(2, 10)}
                CB_CANTON.DataSource = guanacaste
                CB_CANTON.SelectedIndex = 0

            Case "HEREDIA"

                Dim heredia() As String = {Lista_canton(3, 0), Lista_canton(3, 1), Lista_canton(3, 2), Lista_canton(3, 3), Lista_canton(3, 4), Lista_canton(3, 5), Lista_canton(3, 6), Lista_canton(3, 7), Lista_canton(3, 8), Lista_canton(3, 9)}
                CB_CANTON.DataSource = heredia
                CB_CANTON.SelectedIndex = 0

            Case "LIMÓN"

                Dim limon() As String = {Lista_canton(4, 0), Lista_canton(4, 1), Lista_canton(4, 2), Lista_canton(4, 3), Lista_canton(4, 4), Lista_canton(4, 5)}
                CB_CANTON.DataSource = limon
                CB_CANTON.SelectedIndex = 0

            Case "PUNTARENAS"

                Dim puntarenas() As String = {Lista_canton(5, 0), Lista_canton(5, 1), Lista_canton(5, 2), Lista_canton(5, 3), Lista_canton(5, 4), Lista_canton(5, 5), Lista_canton(0, 6), Lista_canton(0, 7), Lista_canton(0, 8), Lista_canton(0, 9), Lista_canton(0, 10), Lista_canton(0, 11), Lista_canton(0, 12)}


                CB_CANTON.DataSource = puntarenas
                CB_CANTON.SelectedIndex = 0

            Case "SAN JOSÉ"

                Dim sanJose() As String = {Lista_canton(6, 0), Lista_canton(6, 1), Lista_canton(6, 2), Lista_canton(6, 3), Lista_canton(6, 4), Lista_canton(6, 5), Lista_canton(6, 6), Lista_canton(6, 7), Lista_canton(6, 8), Lista_canton(6, 9), Lista_canton(6, 10), Lista_canton(6, 11), Lista_canton(6, 12), Lista_canton(6, 13), Lista_canton(6, 14), Lista_canton(6, 15), Lista_canton(6, 16), Lista_canton(6, 17), Lista_canton(6, 18), Lista_canton(6, 19)}
                CB_CANTON.DataSource = sanJose
                CB_CANTON.SelectedIndex = 0

        End Select

    End Sub

    'cargar lista de los domipre y emprego
    Private Sub DomipreEmprego()

        Dim domipre() As String = {"SI", "NO"}
        Dim emprego() As String = {"SI", "NO"}

        CB_DOMIPRE.DataSource = domipre
        CB_EMPREGO.DataSource = emprego


    End Sub

    'fUNCION PARA LLENAR LOS DATOS EN LAS VARIABLES
    Private Sub CargarVariables()

        nombre = TB_NOMBRE.Text
        apellidos = TB_APELLIDOS.Text
        cedula = TB_CEDULA.Text
        telefono1 = TB_TELEFONO1.Text
        telefono2 = TB_TELEFONO2.Text
        celular = TB_CELULAR.Text
        correo = TB_CORREO.Text

        Id = Val(TB_ID.Text)

        NumeroCasa = TB_NUMEROCASA.Text
        direccion = TB_DIRECCION.Text
        colorCasa = TB_COLORCASA.Text

        provincia = CB_PROVINCIA.Text
        canton = CB_CANTON.Text
        distrito = TB_DISTRITO.Text

        numeroMedidor = TB_NUMEROMEDIDOR.Text
        domipre = CB_DOMIPRE.Text
        emprego = CB_EMPREGO.Text

    End Sub

    'Validar si los datos estan vacios
    Private Function validarVacios() As Boolean

        If TB_NOMBRE.Text = "" Or TB_APELLIDOS.Text = "" Or TB_CEDULA.Text = "" Or TB_TELEFONO1.Text = "" Or TB_TELEFONO2.Text = "" Or TB_CELULAR.Text = "" Or TB_CORREO.Text = "" Or TB_ID.Text = "" Or TB_NUMEROCASA.Text = "" Or TB_DIRECCION.Text = "" Or TB_COLORCASA.Text = "" Or CB_PROVINCIA.Text = "" Or CB_CANTON.Text = "" Or TB_DISTRITO.Text = "" Or TB_NUMEROMEDIDOR.Text = "" Or CB_DOMIPRE.Text = "" Or CB_EMPREGO.Text = "" Or TB_LECTURAACTUAL.Text = "" Or TB_LECTURAANTERIOR.Text = "" Or TB_METROSCUBICOS.Text = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub BTN_ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR.Click
        ActualizarCampos()

    End Sub

    'Cargar lista de usuarios disponibles en la base de datos 
    Private Sub cargarLista()

        Dim lista As New DataSet

        Dim dc As New LCUser

        lista = dc.cargarLista

        If lista IsNot Nothing Then

            If lista.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No existen datos!")
                CB_LISTA_BUSCAR.DataSource = Nothing

                CB_LISTA_BUSCAR.Items.Clear()

            Else

                CB_LISTA_BUSCAR.DataSource = lista.Tables(0)
                CB_LISTA_BUSCAR.DisplayMember = "CEDULA"
                CB_LISTA_BUSCAR.ValueMember = "ID_USER"

            End If

        Else
            MessageBox.Show("Error en la vase de datos")
        End If


    End Sub

    Private Sub BTN_SELECCIONAR_NOMBRE_Click(sender As Object, e As EventArgs) Handles BTN_SELECCIONAR_NOMBRE.Click

        Dim identificador As Integer

        identificador = Val(CB_LISTA_BUSCAR.SelectedValue)

        If CB_LISTA_BUSCAR.Text <> "" Then
            Dim dc As New LCUser
            MessageBox.Show(identificador)
            Dim datos() As String = dc.cargarUsuario(identificador)

            If datos IsNot Nothing Then

                TB_NOMBRE.Text = datos(1)
                TB_APELLIDOS.Text = datos(2)
                TB_CEDULA.Text = datos(3)
                TB_TELEFONO1.Text = datos(4)
                TB_TELEFONO2.Text = datos(5)
                TB_CELULAR.Text = datos(6)
                TB_CORREO.Text = datos(7)
                TB_ID.Text = datos(0)
                TB_NUMEROCASA.Text = datos(8)
                TB_DIRECCION.Text = datos(9)
                TB_COLORCASA.Text = datos(10)
                TB_DISTRITO.Text = datos(13)
                TB_NUMEROMEDIDOR.Text = datos(16)

                TB_LECTURAACTUAL.Text = datos(18)
                lecturaConstante = CStr(datos(18))
                TB_LECTURAANTERIOR.Text = datos(17)
                TB_METROSCUBICOS.Text = datos(19)


                Dim valueDomipre As Boolean = datos(14)
                Dim valueEmprego As Boolean = datos(15)



                If valueDomipre = False Then
                    CB_DOMIPRE.SelectedItem = "NO"

                ElseIf valueDomipre = True Then
                    CB_DOMIPRE.SelectedItem = "SI"

                End If

                If valueEmprego = False Then
                    CB_EMPREGO.SelectedItem = "NO"

                ElseIf valueEmprego = True Then
                    CB_EMPREGO.SelectedItem = "SI"
                End If

                Dim valueProvincia As String = datos(11)
                Dim valueCanton As String = datos(12)

                CB_PROVINCIA.SelectedItem = valueProvincia
                CB_CANTON.SelectedItem = valueCanton

            Else
                MessageBox.Show("No hay datos")

            End If

        Else

            MessageBox.Show("No existen datos")

        End If




    End Sub


    'Cargamos todas las lista de los usuario guardados en la base de datos 

    Private Sub cargarTodasLista()

        Dim dc As New LCUser

        todasLista = dc.cargarTodasLista



    End Sub

    'limpidador de componenetes
    Private Sub limpiarComponentes()


        TB_NOMBRE.Clear()
        TB_APELLIDOS.Clear()
        TB_CEDULA.Clear()
        TB_TELEFONO1.Clear()
        TB_TELEFONO2.Clear()
        TB_CELULAR.Clear()
        TB_CORREO.Clear()
        TB_ID.Clear()
        TB_NUMEROCASA.Clear()
        TB_DIRECCION.Clear()
        TB_COLORCASA.Clear()
        TB_DISTRITO.Clear()
        TB_NUMEROMEDIDOR.Clear()

        TB_LECTURAACTUAL.Clear()
        TB_LECTURAANTERIOR.Clear()
        TB_METROSCUBICOS.Clear()

    End Sub



    'Metodo para actualizar los campos 
    Private Sub ActualizarCampos()

        If validarVacios() = False Then


            Dim domiP As Integer
            Dim empre As Integer

            If CB_DOMIPRE.Text = "SI" Then
                domiP = 1
            Else
                domiP = 0

            End If

            If CB_EMPREGO.Text = "SI" Then
                empre = 1
            Else
                empre = 0
            End If
            Dim lecturaMantener As Integer = CStr(TB_LECTURAACTUAL.Text)

            Dim metrosCubicosConsumidos As Integer = metrosCubicos(Val(TB_LECTURAANTERIOR.Text), Val(TB_LECTURAACTUAL.Text))

            Dim LecturaAnteriorCambiar As Integer = lecturaMantener



            Dim band As Boolean = Dusuario.actualizarDatos(Val(TB_ID.Text), TB_NOMBRE.Text, TB_APELLIDOS.Text, TB_CEDULA.Text, TB_TELEFONO1.Text, TB_TELEFONO2.Text, TB_CELULAR.Text, TB_CORREO.Text, TB_NUMEROCASA.Text, TB_DIRECCION.Text, TB_COLORCASA.Text, CB_PROVINCIA.Text, CB_CANTON.Text, TB_DISTRITO.Text, TB_NUMEROMEDIDOR.Text, domiP, empre, Val(TB_LECTURAACTUAL.Text), Val(TB_LECTURAANTERIOR.Text), metrosCubicosConsumidos)

            If band Then
                MessageBox.Show("Usuario Actualizado")
                cargarLista()
                limpiarComponentes()
                Cargar(Val(TB_ID.Text))

            Else
                MessageBox.Show("Error inesperado, usuario no actualizado ")
            End If

        End If

    End Sub

    'Funcion para calcular los metros cubicos consumidos de antes y ahora
    Private Function metrosCubicos(ByVal anterior As Integer, ByVal actual As Integer) As Integer

        Dim total As Integer


        If anterior = 0 And actual = 0 Then
            Return 0

        Else

            total = Math.Abs(anterior - actual)

            Return total
        End If

    End Function

    'registrar nuevo usuario
    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        If TB_LECTURAACTUAL.Text = "" Then
            TB_LECTURAACTUAL.Text = "0"

        End If

        If TB_LECTURAANTERIOR.Text = "" Then
            TB_LECTURAANTERIOR.Text = "0"
        End If


        TB_ID.Text = "0"
        registrarUsuario()

    End Sub

    'lIMPIAR COMPONENTES
    Private Sub BTN_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIAR.Click



        limpiarComponentes()

    End Sub

    'Funcion para registrar a un nuevo usuario
    Private Sub registrarUsuario()


        If validarVacios() = False Then

            Dim mensajeValidar As DialogResult

            mensajeValidar = MessageBox.Show("Registrando nuevo usuario", "Registro de usuario", MessageBoxButtons.YesNo)

            If mensajeValidar = DialogResult.Yes Then

                Dim nNombre As String = TB_NOMBRE.Text
                Dim nApellidos As String = TB_APELLIDOS.Text
                Dim nCedula As String = TB_CEDULA.Text
                Dim nTelefono1 As String = TB_TELEFONO1.Text
                Dim nTelefono2 As String = TB_TELEFONO2.Text
                Dim nCelular As String = TB_CELULAR.Text
                Dim nCorreo As String = TB_CORREO.Text

                Dim nDomipre As Integer
                Dim nEmprego As Integer
                Dim nNumeroMedidor As String = TB_NUMEROMEDIDOR.Text
                Dim nAnterior As Integer = Val(TB_LECTURAANTERIOR.Text)
                Dim nActual As Integer = Val(TB_LECTURAACTUAL.Text)
                Dim nMetrosCubicos As Integer = Val(TB_METROSCUBICOS.Text)

                Dim NnumeroCasa As String = TB_NUMEROCASA.Text
                Dim nDireccion As String = TB_DIRECCION.Text
                Dim nColor As String = TB_COLORCASA.Text

                Dim nProvincia As String = CB_PROVINCIA.Text
                Dim nCanton As String = CB_CANTON.Text
                Dim nDistrito As String = TB_DISTRITO.Text

                If CB_DOMIPRE.Text = "SI" Then
                    nDomipre = 1
                Else
                    nDomipre = 0
                End If

                If CB_EMPREGO.Text = "SI" Then
                    nEmprego = 1
                Else
                    nEmprego = 0
                End If

                Dim Resultado As Boolean

                Resultado = Dusuario.registrarUsuario(0, nNombre, nApellidos, nCedula, nTelefono1, nTelefono2, nCelular, nCorreo, NnumeroCasa, nDireccion, nColor, nProvincia, nCanton, nDistrito, nNumeroMedidor, nDomipre, nEmprego, nActual, nAnterior, nMetrosCubicos)

                If Resultado Then
                    MessageBox.Show("Nuevo Usuario Registrado")
                    cargarLista()

                Else
                    MessageBox.Show("Error al registrar el usuario!!")
                End If

            End If

        Else
            MessageBox.Show("No pueden haber campos vacios ", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class