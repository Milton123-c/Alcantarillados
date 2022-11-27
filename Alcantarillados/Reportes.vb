Imports CrystalDecisions.ReportAppServer
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices
Public Class Reportes
    Public datos As New Dictionary(Of String, String)


    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

        Try



            Dim parameter As New List(Of ReportParameter)
            parameter.Add(New ReportParameter("Nombre", datos("Nombre")))
            parameter.Add(New ReportParameter("Celular", datos("Celular")))
            parameter.Add(New ReportParameter("Fecha", datos("Fecha")))
            parameter.Add(New ReportParameter("Vence", datos("Vence")))
            parameter.Add(New ReportParameter("Cedula", datos("Cedula")))
            parameter.Add(New ReportParameter("NumeroMedidor", datos("NumeroMedidor")))
            parameter.Add(New ReportParameter("Barrio", datos("Barrio")))
            parameter.Add(New ReportParameter("Direccion", datos("Direccion")))
            parameter.Add(New ReportParameter("Anterior", datos("Anterior")))
            parameter.Add(New ReportParameter("Actual", datos("Actual")))
            parameter.Add(New ReportParameter("Metros", datos("Metros")))
            parameter.Add(New ReportParameter("MesCobro", datos("MesCobro")))
            parameter.Add(New ReportParameter("TarifaBase", datos("TarifaBase")))
            parameter.Add(New ReportParameter("MontoMetross", datos("MontoMetross")))
            parameter.Add(New ReportParameter("OtrosCargos", datos("OtrosCargos")))
            parameter.Add(New ReportParameter("Hidrantes", datos("Hidrantes")))
            parameter.Add(New ReportParameter("Mora", datos("Mora")))
            parameter.Add(New ReportParameter("CargoAdmin", datos("CargoAdmin")))
            parameter.Add(New ReportParameter("Arreglo", datos("Arreglo")))
            parameter.Add(New ReportParameter("CortaReconexion", datos("CortaReconexion")))
            parameter.Add(New ReportParameter("Iva", datos("Iva")))
            parameter.Add(New ReportParameter("NotaCredito", datos("NotaCredito")))
            parameter.Add(New ReportParameter("SaldoArreglo", datos("SaldoArreglo")))
            parameter.Add(New ReportParameter("PagadoEn", datos("PagadoEn")))
            parameter.Add(New ReportParameter("NumeroDocumento", datos("NumeroDocumento")))
            parameter.Add(New ReportParameter("Tarifa", datos("Tarifa")))
            parameter.Add(New ReportParameter("Total", datos("Total")))

            Me.ReportViewer1.LocalReport.SetParameters(parameter)
            Me.ReportViewer1.RefreshReport()


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class