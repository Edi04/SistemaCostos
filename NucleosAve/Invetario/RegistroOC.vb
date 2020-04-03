Imports System.Data.SqlClient

Public Class RegistroOC

    Public Function R(ByVal dts As CRegistroOC)
        Dim DateE = DateTime.Now

        Dim Conex As New SqlConnection(My.Settings.Conexxx)
        Dim GDatos1 As SqlCommand
        Try
            Conex.Open()

            GDatos1 = New SqlCommand("SP_GDEProductos")
            GDatos1.CommandType = CommandType.StoredProcedure
            GDatos1.Connection = Conex

            GDatos1.Parameters.AddWithValue("@Id_Producto", dts.GID)
            GDatos1.Parameters.AddWithValue("@Cantidad", dts.GCEnt)
            GDatos1.Parameters.AddWithValue("@Producto", dts.GProducto)
            GDatos1.Parameters.AddWithValue("@Precio_Unitario_PZA", 0)
            GDatos1.Parameters.AddWithValue("@Tipo_Cambio", 0)
            GDatos1.Parameters.AddWithValue("@PU_Corte_PZA", 0)
            GDatos1.Parameters.AddWithValue("@PU_Total", 0)
            GDatos1.Parameters.AddWithValue("@Precio_Total", 0)
            GDatos1.Parameters.AddWithValue("@Created", DateE)
            GDatos1.Parameters.AddWithValue("@Orden_Compra", dts.GCOrdenT)
            GDatos1.Parameters.AddWithValue("@PUUSD", 0)
            GDatos1.Parameters.AddWithValue("@FUSD", 0)
            GDatos1.Parameters.AddWithValue("@TUSD", 0)
            GDatos1.Parameters.AddWithValue("@Id_Empleado", dts.GL_ID)
            GDatos1.Parameters.AddWithValue("@Empleado", dts.GLUsuario)
            GDatos1.Parameters.AddWithValue("@CodiS", dts.GCOrdenC)


            If GDatos1.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar", MessageBoxButtons.OK)
            Return False
        Finally
            Conex.Close()
        End Try
    End Function
End Class
