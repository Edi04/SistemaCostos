Imports System.Data.SqlClient

Public Class RegistroMP
    Public Function R(ByVal dts As CRegistroMP)
        Dim DateE = DateTime.Now

        Dim Conex As New SqlConnection(My.Settings.Conexxx)
        Dim GDatos1 As SqlCommand
        Try
            Conex.Open()

            GDatos1 = New SqlCommand("SP_GMateriaPrima")
            GDatos1.CommandType = CommandType.StoredProcedure
            GDatos1.Connection = Conex

            GDatos1.Parameters.AddWithValue("@Proveedor", dts.Proveedor_)
            GDatos1.Parameters.AddWithValue("@Num_Interno", dts.Num_RIn)
            GDatos1.Parameters.AddWithValue("@Num_Externo", dts.Num_REx)
            GDatos1.Parameters.AddWithValue("@Calibre", dts.Calibre_)
            GDatos1.Parameters.AddWithValue("@Ancho", dts.Ancho_)
            GDatos1.Parameters.AddWithValue("@Peso", dts.Peso_)
            GDatos1.Parameters.AddWithValue("@Descripcion", dts.Descripcion_)
            GDatos1.Parameters.AddWithValue("@FechaLlegada", dts.FechaLlegada)
            GDatos1.Parameters.AddWithValue("@FechaRegistro", dts.FechaRegistro)
            GDatos1.Parameters.AddWithValue("@CodiS", dts.LCS_)
            GDatos1.Parameters.AddWithValue("@Orden_Compra", dts.OCompra_)
            GDatos1.Parameters.AddWithValue("@Created", DateE)
            GDatos1.Parameters.AddWithValue("@Empleado", dts.Trabaj)
            GDatos1.Parameters.AddWithValue("@CE", dts.CE_)
            GDatos1.Parameters.AddWithValue("@IDOD", dts.IDDO_)
            GDatos1.Parameters.AddWithValue("@Pedimento", dts.Pedimento_)

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
