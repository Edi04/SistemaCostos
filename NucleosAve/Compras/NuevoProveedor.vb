Public Class NuevoProveedor
    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub NuevoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProve_Click(sender As Object, e As EventArgs) Handles btnProve.Click
        Try
            Dim funciones As New Funcion_Registros
            Dim logica As New ClassProveedores
            logica.pro_nombre = Me.textNombre.Text
            logica.pro_direccion = Me.textDireccion.Text
            logica.pro_telefono = Me.textTelefono.Text
            If funciones.FN_InsertarProvedor(logica) Then
                MsgBox("Proveedor Agregado Correctamente", MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        OrdCompra.combo_provee()

    End Sub


End Class