Imports Newtonsoft.Json
Public Class CLsesion

    Dim sesion As New CDsesion

    'verificamos si existen datos
    Public Function VerificarUsuario(ByVal correo As String, ByVal contra As String) As Dictionary(Of String, Object)
        Return sesion.VerificarUsuario(correo, contra)
    End Function

    'Cambiar el status del administrador
    Public Function cambiarStatus(ByVal id As Integer, ByVal stado As Boolean) As Boolean
        Return sesion.cambiarStatus(id, stado)
    End Function

    'Funcion para los usuarios sin contraseña 
    Public Function Registrar(codigo As String) As Dictionary(Of String, Object)
        Return sesion.Registrar(codigo)
    End Function

    'Funcion para actualizar el codigo si se cerro o sigue abierto
    Public Function CerrarSesion(valor As Boolean, codigo As String) As Integer
        Return sesion.CerrarSesion(valor, codigo)
    End Function

End Class
