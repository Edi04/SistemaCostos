Imports System.Data.SqlClient
Public Class NMarca
    'Conexión
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim GDatos As New SqlCommand("SP_NMarca", Conex)
        Dim DateA = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure
        GDatos.Parameters.AddWithValue("@Marca", Trim(TxtMarca.Text))

        Dim RData As SqlDataReader
        NuevoProducto.Close()

        Try
            Conex.Open()
            RData = GDatos.ExecuteReader()

            NuevoProducto.Show()
            NuevoProducto.CBArea.SelectedValue = CInt(LArea.Text)
            NuevoProducto.CBProceso.SelectedValue = CInt(LProceso.Text)
            NuevoProducto.CBCategoria.SelectedValue = CInt(LCategoria.Text)
            NuevoProducto.TxtClaveP.Text = LClaveP.Text
            NuevoProducto.TxtNombreP.Text = LNombre.Text
            NuevoProducto.CBUMedida.SelectedValue = CInt(LMedida.Text)
            Close()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
        NuevoProducto.Show()
    End Sub
End Class