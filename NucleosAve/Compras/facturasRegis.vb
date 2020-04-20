Imports System.Data.SqlClient
Public Class facturasRegis
    'coneccion de Bd y direcctivas para poder conectar y poder ejecutar consultas
    '----Directivas-->
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    '<--directivas termino-->
    Private Sub facturasRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub MostrarRegOrdC()
        Try
            Dim Func As New Funcion_Registros
            tabla = Func.FnMostrarFacturas
            If tabla.Rows.Count <> 0 Then
                DataGridFacturas.DataSource = tabla
            Else
                DataGridFacturas.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        MostrarRegOrdC()
    End Sub


    Private Sub DataGridFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridFacturas.CellClick
        Ventas.TextBox_Factura.Text = DataGridFacturas.CurrentRow.Cells(0).Value
        Dim tabla As New DataTable
        Dim seleccionado As String
        seleccionado = DataGridFacturas.CurrentRow.Cells(0).Value
        AltaTrasportes.TextOC.Text = seleccionado
        id_fac.Text = seleccionado
        Pedimentos.ComboFactura.Text = seleccionado
        Dim codigo As String
        codigo = id_fac.Text

        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("SP_Eliminar_Facturas")
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexxo


        comando.Parameters.AddWithValue("@codigo", codigo)
        comando.Parameters.AddWithValue("@estado", "Inactivo")

        comando.ExecuteNonQuery()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MessageBox.Show("Estas Seguro Que Quieres Eliminar La " + id_fac.Text, "Eliminar Factura", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            Try
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassRegistrosFacturas

                logica.Fcodigo = Me.id_fac.Text

                If funciones.FN_EliminarFactura(logica) Then
                    MsgBox("Datos Eliminados Correctamente", MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '-----------------------------------------trmina botonera------------------------------
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    '---------------------------------coidigo para poder mover formulario------------------------------
    Private Sub Inicio_Od_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
    Private Sub Inicio_Od_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        factura.Show()
    End Sub


    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
End Class