Imports System.Data.SqlClient
Public Class Registros_Ventas
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    Private Sub Registros_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<-Botonera close<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub
    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub Inicio_Od_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
    Private Sub Inicio_Od_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<-Botonera close terminar<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    Sub MostrarRegRH()
        Try
            Dim Func As New Fuction_Ventas
            tabla = Func.FnMostrarListadoventas
            If tabla.Rows.Count <> 0 Then
                DataGridView_registros.DataSource = tabla
            Else
                DataGridView_registros.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView_registros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_registros.CellClick
        Ventas.BtnGuardarFac.Enabled = False
        Ventas.btn_modificar.Enabled = True
        Ventas.TextBox_id.Text = DataGridView_registros.CurrentRow.Cells(0).Value
        Ventas.TextBox_codigo_general.Text = DataGridView_registros.CurrentRow.Cells(1).Value
        Ventas.TextBox_Factura.Text = DataGridView_registros.CurrentRow.Cells(2).Value
        Ventas.TextBox_total.Text = DataGridView_registros.CurrentRow.Cells(3).Value
        Ventas.TextBox_estatus.Text = DataGridView_registros.CurrentRow.Cells(4).Value
        Ventas.DateTimePicker_fecha.Value = DataGridView_registros.CurrentRow.Cells(5).Value
        Ventas.Text_Url_Pdf.Text = DataGridView_registros.CurrentRow.Cells(6).Value

    End Sub

    Private Sub btn_trash_Click(sender As Object, e As EventArgs) Handles btn_trash.Click
        If MessageBox.Show("Estas Seguro Que Quieres Eliminar " + Ventas.TextBox_id.Text, "Eliminar Pedimentos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Fuction_Ventas
                Dim logica As New ClassVentas

                logica.Vid = Ventas.TextBox_id.Text

                If funciones.FN_EliminarVentas(logica) Then
                    MsgBox("Venta Eliminada Correctamente", MessageBoxIcon.Information)
                    MostrarRegRH()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarRegRH()
    End Sub


End Class