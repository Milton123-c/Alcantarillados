Imports Newtonsoft.Json

Public Class Form1
    Dim sesion As New CLsesion
    Dim administrador As New Administrador
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btn_cerrar(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click

        Dim contra As String = tb_contra.Text
        Dim correo As String = tb_correo.Text

        If contra IsNot "" And correo IsNot "" Then

            verificarAcceso(correo, contra)

        End If

    End Sub

    'verificar el acceso al sistema
    Private Sub verificarAcceso(ByVal correo As String, ByVal contra As String)

        If correo IsNot "" And contra IsNot "" Then

            Dim datos As New Dictionary(Of String, Object)

            datos = sesion.VerificarUsuario(correo, contra)

            If datos IsNot Nothing Then

                Dim stado As Boolean = sesion.cambiarStatus(datos("id"), True)

                datos = sesion.VerificarUsuario(correo, contra)

                MessageBox.Show("Bienvenido Administrador " & datos("nombre") & "", "Iniciando sesion")

                administrador.datos = datos
                administrador.Show()
                Me.Hide()

            Else

                MessageBox.Show("Lo sentimos el correo o contraseña, no estan registradas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_contra.Clear()

            End If

        End If

    End Sub

    Private Sub btn_codigo_Click(sender As Object, e As EventArgs) Handles btn_codigo.Click

        If tb_contra.Text IsNot "" Then

            Dim datos As New Dictionary(Of String, Object)

            datos = sesion.Registrar(tb_contra.Text)

            If datos IsNot Nothing Then

                Dim vuelta As Integer


                vuelta = sesion.CerrarSesion(True, tb_contra.Text)

                datos = sesion.Registrar(tb_contra.Text)

                Dim regist As New Registrar

                regist.Estado1 = datos("estado")
                regist.Codigo1 = tb_contra.Text
                regist.Show()
                Me.Hide()

            Else
                MessageBox.Show("El codigo no es valido", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_contra.Clear()

            End If

        End If

    End Sub
End Class
