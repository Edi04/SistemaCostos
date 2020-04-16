Imports System.Data.SqlClient
Public Class Ventas
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnGuardarFac_Click(sender As Object, e As EventArgs) Handles BtnGuardarFac.Click
        If MessageBox.Show("Estas Seguro Que Quieres agregar nuevo registro", "Nueva Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Fuction_Ventas
                Dim logica As New ClassVentas

                logica.Vfactura = Me.TextBox_Factura.Text
                logica.Vtotal = Me.TextBox_total.Text
                logica.Vestatus = Me.TextBox_estatus.Text
                logica.Vfecha = Me.DateTimePicker_fecha.Value
                logica.Vfacturapdf = Me.Text_Url_Pdf.Text
                logica.Vcodigo = Me.TextBox_codigo_general.Text

                If funciones.FN_InsertarVenta(logica) Then
                    MsgBox("Datos Insertados Correctamente", MessageBoxIcon.Information)
                    ' limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class