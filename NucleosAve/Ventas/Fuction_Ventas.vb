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
    Public Function FN_ModificarVenta(ByVal dts As ClassVentas) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_Ventas")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@factura", dts.Vfactura)
            comando.Parameters.AddWithValue("@total", dts.Vtotal)
            comando.Parameters.AddWithValue("@estatus", dts.Vestatus)
            comando.Parameters.AddWithValue("@fecha", dts.Vfecha)
            comando.Parameters.AddWithValue("@facturapdf", dts.Vfacturapdf)
            comando.Parameters.AddWithValue("@id", dts.Vid)

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

    '<------------------------Listado de Rh----------------------------->
    Public Function FnMostrarListadoventas() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_Mostrar_Ventas")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", Registros_Ventas.DateTime_Rango1.Value)
            comando.Parameters.AddWithValue("@rango2", Registros_Ventas.DateTimePicker_rago2.Value)
            If comando.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    '<.........................fIN lISTADO----------------------------------------->
    '--------------------------eLIMINACION-------------------------
    Public Function FN_EliminarVentas(ByVal dts As ClassVentas) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_EliminarVentas")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@id", dts.Vid)
            comando.Parameters.AddWithValue("@estado", "Inactivo")

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
