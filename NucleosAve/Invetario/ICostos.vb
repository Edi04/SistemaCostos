Imports System.Data.SqlClient

Public Class ICostos
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub ICostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
    '        If TxtBusqueda.Text = "" Then
    '        Else
    '            Dim Consulta As String = "SELECT Id_MPrim, Proveedor, Num_Interno, Num_Externo, Calibre, Ancho, Peso, UMedida, Descripcion, Fecha_Llegada,
    '		                                    Fecha_Registro, OCompra, CSeguimiento
    '                                      FROM TB_MateriaPrima
    '                                      WHERE Estado = 'Almacen MP' AND
    '                                            OCompra like '%'+@Busqueda+'%'"

    '            Dim cmd As New SqlCommand(Consulta, Conex)
    '            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))

    '            Dim Da As New SqlDataAdapter(cmd)
    '            Dim Ds As New DataSet

    '            Try
    '                Conex.Open()
    '                Da.Fill(Ds)

    '                DGHR.DataSource = Ds.Tables(0)
    '                Da.Dispose()

    '            Catch ex As Exception
    '                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End Try

    '            Conex.Close()
    '        End If
    '    End Sub
End Class

'SELECT P.Id_Producto, P.Nombre_Producto,P.Clave_Producto,P.Existencia ,P.Minimo, P.Maximo ,ED.Cantidad, ED.Precio_Unitario_PZA, ED.Tipo_Cambio, ED.PU_Corte_PZA, ED.PU_Total, ED.Precio_Total, 
'		ED.PUUSD, ED.FUSD, ED.TUSD, oc.purchase_order
'  FROM TB_EDetalleProductos AS ED
'  INNER JOIN TB_Ordenes_Compra AS OC ON OC.codigo = ED.Orden_Compra
'  INNER JOIN [TB_Productos] AS P ON P.Id_Producto = ED.Id_Producto
