Imports System.DirectoryServices.ActiveDirectory
Imports System.Runtime.Serialization.Formatters
Imports System.Drawing.Color
Imports Newtonsoft.Json
Public Class Administrador

    Public datos As New Dictionary(Of String, Object)

    Private Sub Label24_Click(sender As Object, e As EventArgs)



    End Sub



    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormIjo(New Sistema)

        'PONEMOS EL COLOR DE INICIO COMO PRINCIPAL
        Me.BANDERA = 1
        If Me.BANDERA = 1 Then
            BTN_Inicio.BackColor = Color.FromArgb(0, 32, 200)

        End If

        If datos("status") Then
            Dim admini As String = " " & datos("nombre") & " " & datos("apellidos") & ""
            lb_amin.Text = admini
            lb_activo.BackColor = Color.Turquoise
        Else
            lb_activo.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim sistema As New Sistema
        Me.Hide()
        sistema.Show()

    End Sub

    Private Sub BTN_Cerrar_Click(sender As Object, e As EventArgs) Handles BTN_Cerrar.Click

        Dim sesion As New CLsesion
        MessageBox.Show("Cerrando sesion")
        sesion.cambiarStatus(datos("id"), False)

        Dim login As New Form1
        login.Show()
        Me.Close()
    End Sub

    Private Sub BTN_Maximizar_Click(sender As Object, e As EventArgs) Handles BTN_Maximizar.Click



    End Sub

    Private Sub BTN_Restaurar_Click(sender As Object, e As EventArgs) Handles BTN_Restaurar.Click

    End Sub

    Private Sub BTN_Minimizar_Click(sender As Object, e As EventArgs) Handles BTN_Minimizar.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim sesion As New CLsesion
        MessageBox.Show("Cerrando sesion")
        sesion.cambiarStatus(datos("id"), False)
        Dim login As New Form1
        login.Show()
        Me.Close()
    End Sub


    Private Sub AbrirFormIjo(formIjo As Object)

        If Me.PanelContenedor.Controls.Count > 0 Then

            Me.PanelContenedor.Controls.RemoveAt(0)

        End If

        Dim fh As Form = TryCast(formIjo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()



    End Sub

    Private Sub BTN_Inicio_Click(sender As Object, e As EventArgs) Handles BTN_Inicio.Click
        AbrirFormIjo(New Sistema)

        'LOGICA PARA MOSTRAR EL COLOR DE SELECCION
        Me.BANDERA = 1
        If Me.BANDERA = 1 Then
            BTN_Inicio.BackColor = Color.FromArgb(0, 32, 200)

            'COLOCAMOS EL COLOR NORMAL DE LOS OTROS BOTONES

            BTN_Usario.BackColor = Color.FromArgb(26, 32, 40)
            BTN_NuevasLecturas.BackColor = Color.FromArgb(26, 32, 40)
            BTN_Administrador.BackColor = Color.FromArgb(26, 32, 40)

        End If


    End Sub

    Private Sub BarraTitulo_Paint(sender As Object, e As PaintEventArgs) Handles BarraTitulo.Paint

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Dim sesion As New CLsesion
        MessageBox.Show("Cerrando sesion")
        sesion.cambiarStatus(datos("id"), False)

        Dim login As New Form1
        login.Show()
        Me.Close()
    End Sub

    Private Sub BtnResturar_Click(sender As Object, e As EventArgs) Handles BtnResturar.Click
        Me.WindowState = FormWindowState.Normal
        BtnResturar.Visible = False
        BtnMaximizar.Visible = True
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        BtnMaximizar.Visible = False
        BtnResturar.Visible = True
    End Sub



    Private Sub BtnMinimizar_Click_1(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BTN_Usario_Click(sender As Object, e As EventArgs) Handles BTN_Usario.Click
        AbrirFormIjo(New Usuario)

        'LOGICA PARA EL CAMBIO DE COLOR DE LOS BOTONES DE MENU DE NAVEGACION
        Me.BANDERA = 2
        If Me.BANDERA = 2 Then

            BTN_Usario.BackColor = Color.FromArgb(0, 32, 200)

            'COLOCAMOS EL COLOR NORMAL DE LOS OTROS BOTONES

            BTN_Inicio.BackColor = Color.FromArgb(26, 32, 40)
            BTN_NuevasLecturas.BackColor = Color.FromArgb(26, 32, 40)
            BTN_Administrador.BackColor = Color.FromArgb(26, 32, 40)
        End If
    End Sub

    Private Sub BTN_NuevasLecturas_Click(sender As Object, e As EventArgs) Handles BTN_NuevasLecturas.Click

        AbrirFormIjo(New Lecturas)

        'LOGICA PARA EL CAMBIO DE COLOR DE LOS BOTONES DE MENU DE NAVEGACION
        Me.BANDERA = 3
        If Me.BANDERA = 3 Then

            BTN_NuevasLecturas.BackColor = Color.FromArgb(0, 32, 200)

            'COLOCAMOS EL COLOR NORMAL DE LOS OTROS BOTONES

            BTN_Inicio.BackColor = Color.FromArgb(26, 32, 40)
            BTN_Usario.BackColor = Color.FromArgb(26, 32, 40)
            BTN_Administrador.BackColor = Color.FromArgb(26, 32, 40)
        End If

    End Sub


    'INICIANDO CODIGOS DE PROGRAMACION DEL PROGRAMA 

    'ETAPA PRINCIPAL COLORES DE SELECCION DEL MENU DE NAVEGACION

    'DECLARACION DE VARIABLES PARA EL USO DEL MENU DE NAVEGACION
    Private BANDERA As Integer = 1

    Private Sub BTN_Administrador_Click(sender As Object, e As EventArgs) Handles BTN_Administrador.Click
        AbrirFormIjo(New DatosAdministrador)

        'LOGICA PARA EL CAMBIO DE COLOR DE LOS BOTONES DE MENU DE NAVEGACION
        Me.BANDERA = 4
        If Me.BANDERA = 4 Then

            BTN_Administrador.BackColor = Color.FromArgb(0, 32, 200)

            'COLOCAMOS EL COLOR NORMAL DE LOS OTROS BOTONES

            BTN_Inicio.BackColor = Color.FromArgb(26, 32, 40)
            BTN_NuevasLecturas.BackColor = Color.FromArgb(26, 32, 40)
            BTN_Usario.BackColor = Color.FromArgb(26, 32, 40)
        End If
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub



    'INICIO VALOR 1
    'USUARIO VALOR 2
    'NUEVA LECTURA VALOR 3
    'ADMINISTRADOR VALOR 4

    'COLOR DE FONDO 0; 32; 200


End Class