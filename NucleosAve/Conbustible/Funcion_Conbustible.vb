Imports System.Data.SqlClient
Public Class Funcion_Conbustible
    Dim comando As SqlCommand
    Dim conexioncita As String = My.Settings.Conexxx

    Public Function FN_InsertarConbustible(ByVal dts As ClassConbustible) As Boolean
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("SP_Insertar_Compra_Combustible")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexxo

        comando.Parameters.AddWithValue("@Fecha", dts.Con_fecha)
        comando.Parameters.AddWithValue("@litros", dts.Con_litros)
        comando.Parameters.AddWithValue("@precio", dts.Con_precio)
        comando.Parameters.AddWithValue("@total", dts.Con_total)
        comando.Parameters.AddWithValue("@tipo", dts.Con_tipo)

        If Compra_Conbustible.texturl_def.Text = "" Then
            comando.Parameters.AddWithValue("@comprobante", "Ningun Archivo Seleccionado")
        Else
            comando.Parameters.AddWithValue("@comprobante", dts.Con_comprobante)
        End If
        comando.Parameters.AddWithValue("@responsable", dts.Con_responsable)
        comando.Parameters.AddWithValue("@mpn", dts.Con_mpn)

        If comando.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FN_InsertarConbustible2(ByVal dts As ClassConbustible) As Boolean
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("SP_Insertar_Compra_Combustible2")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexxo

        comando.Parameters.AddWithValue("@codigo", dts.Con_codigo)
        comando.Parameters.AddWithValue("@trasporte", dts.Con_chofer)
        comando.Parameters.AddWithValue("@chofer", dts.Con_chofer)
        comando.Parameters.AddWithValue("@gasolinera", dts.Con_gasolinera)
        comando.Parameters.AddWithValue("@Fecha", dts.Con_fecha)
        comando.Parameters.AddWithValue("@litros", dts.Con_litros)
        comando.Parameters.AddWithValue("@precio", dts.Con_precio)
        comando.Parameters.AddWithValue("@total", dts.Con_total)
        comando.Parameters.AddWithValue("@tipo", dts.Con_tipo)
        comando.Parameters.AddWithValue("@categoria", "Pago Efectivo")

        If Compra_Conbustible.texturl_def.Text = "" Then
            comando.Parameters.AddWithValue("@comprobante", "Ningun Archivo Seleccionado")
        Else
            comando.Parameters.AddWithValue("@comprobante", dts.Con_comprobante)
        End If
        comando.Parameters.AddWithValue("@responsable", dts.Con_responsable)
        comando.Parameters.AddWithValue("@area", dts.Con_area)
        comando.Parameters.AddWithValue("@cantidad_cuenta", dts.Con_cantidad_cuenta)
        comando.Parameters.AddWithValue("@quien_porta_unidad", dts.Con_quien_porta_unidad)
        comando.Parameters.AddWithValue("@n_vale", dts.Con_numero_vale)
        comando.Parameters.AddWithValue("@mpn", dts.Con_mpn)

        If comando.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FN_Repartir_conbustible(ByVal dts As ClassConbustible) As Boolean
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("SP_Entregar_Combustible")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexxo

        comando.Parameters.AddWithValue("@codigo", dts.Con_codigo)
        comando.Parameters.AddWithValue("@fecha", dts.Con_fecha)
        comando.Parameters.AddWithValue("@trasporte", dts.Con_trasporte)
        comando.Parameters.AddWithValue("@area", dts.Con_area)
        comando.Parameters.AddWithValue("@litros_suministrados", dts.Con_litros)
        comando.Parameters.AddWithValue("@tipo", dts.Con_tipo)
        comando.Parameters.AddWithValue("@litros_actuales", dts.Con_cantidad_cuenta)
        comando.Parameters.AddWithValue("@entrego", dts.Con_entrego)
        comando.Parameters.AddWithValue("@quien_porta_unidad", dts.Con_quien_porta_unidad)
        comando.Parameters.AddWithValue("@mpn", dts.Con_mpn)
        comando.Parameters.AddWithValue("@responsable", dts.Con_responsable)
        If comando.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If
    End Function
End Class