Public Class Registrar

    Private codigo As String
    Private estado As Boolean

    Public Property Estado1 As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property

    Public Property Codigo1 As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property



    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show(estado)
        MessageBox.Show(codigo)

        If Estado1 = True Then
            LB_ESTADO.BackColor = Color.Cyan
        Else
            LB_ESTADO.BackColor = Color.Red
        End If

        AbrirFormIjo(New DatosAdministrador)



    End Sub

    'Funcion para abri los formulario
    Public Sub AbrirFormIjo(formIjo As Object)

        If Me.Panel1.Controls.Count > 0 Then
            Me.Panel1.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(formIjo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill

        Me.Panel1.Controls.Add(fh)
        Me.Panel1.Tag = fh
        fh.Show()

    End Sub

    Public Sub cerrarVentana(sender As Object, e As EventArgs) Handles Me.Closing

        MessageBox.Show("Regresando al inicio de sesion")
        Dim cerrarSesi As New CLsesion

        Dim cerrar As Integer = cerrarSesi.CerrarSesion(False, codigo)

        If cerrar = 1 Then
            MessageBox.Show("Cerrando Sesion")
        End If

        Dim sesion As New Form1
        sesion.Show()

        Me.Hide()

    End Sub



End Class