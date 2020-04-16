Imports System.Data.SqlClient
Public Class Fuction_Ventas
    Dim comando As SqlCommand
    Dim conexioncita As String = My.Settings.Conexxx

    Public Function FN_InsertarVenta(ByVal dts As ClassVentas) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Ventas")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@factura", dts.Vfactura)
            comando.Parameters.AddWithValue("@total", dts.Vtotal)
            comando.Parameters.AddWithValue("@estatus", dts.Vestatus)
            comando.Parameters.AddWithValue("@fecha", dts.Vfecha)
            comando.Parameters.AddWithValue("@facturapdf", dts.Vfacturapdf)
            comando.Parameters.AddWithValue("@estado", "Activo")
            comando.Parameters.AddWithValue("@codigo", dts.Vcodigo)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
End Class
