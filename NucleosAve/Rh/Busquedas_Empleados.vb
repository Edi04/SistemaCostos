Imports System.Data.SqlClient
Public Class Busquedas_Empleados
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx

    '---------------------------BOtonera---------------------------
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
    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarRegEmpleados()
    End Sub

    Sub MostrarRegEmpleados()
        Try
            Dim Func As New FuncionRh
            tabla = Func.FnMostrarListadoEmpleados
            If tabla.Rows.Count <> 0 Then
                DataGridView_empleados.DataSource = tabla
            Else
                DataGridView_empleados.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Busquedas_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Eliminar este registro ", "Eliminar Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New FuncionRh
                Dim logica As New ClassEmpleados

                logica.RH_id_empleado = Alta_Empleados.TextBox_id.Text

                If funciones.FN_EliminarEmpleado(logica) Then
                    MsgBox("Empleado Eliminado Correctamente", MessageBoxIcon.Information)
                    MostrarRegEmpleados()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView_empleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_empleados.CellClick
        Alta_Empleados.limpiar()
        Alta_Empleados.BtnGuardar_Empleado.Enabled = False
        Alta_Empleados.btn_modificar.Enabled = True

        Alta_Empleados.TextBox_id.Text = DataGridView_empleados.CurrentRow.Cells(0).Value
        Alta_Empleados.TextBox_numero_nomina.Text = DataGridView_empleados.CurrentRow.Cells(1).Value
        Alta_Empleados.TextBox_nombre_empleado.Text = DataGridView_empleados.CurrentRow.Cells(2).Value
        Alta_Empleados.TextBox_apellido.Text = DataGridView_empleados.CurrentRow.Cells(3).Value
        Alta_Empleados.TextBox_apellido_materno.Text = DataGridView_empleados.CurrentRow.Cells(4).Value
        Alta_Empleados.TextBox_nss.Text = DataGridView_empleados.CurrentRow.Cells(5).Value
        Alta_Empleados.TextBox_rfc.Text = DataGridView_empleados.CurrentRow.Cells(6).Value
        Alta_Empleados.TextBox_nacionalidad.Text = DataGridView_empleados.CurrentRow.Cells(7).Value
        Alta_Empleados.TextBox_area.Text = DataGridView_empleados.CurrentRow.Cells(8).Value
        Alta_Empleados.TextBox_estudios.Text = DataGridView_empleados.CurrentRow.Cells(9).Value
        Alta_Empleados.TextBox_correo.Text = DataGridView_empleados.CurrentRow.Cells(10).Value
        Alta_Empleados.TextBox_telefono.Text = DataGridView_empleados.CurrentRow.Cells(11).Value
        Alta_Empleados.TextBox_telefono2.Text = DataGridView_empleados.CurrentRow.Cells(12).Value
        Alta_Empleados.TextBox_direccionE.Text = DataGridView_empleados.CurrentRow.Cells(13).Value

        Alta_Empleados.TextBox_perfil.Text = DataGridView_empleados.CurrentRow.Cells(14).Value
        Alta_Empleados.TextBox_alergias_enfermedades.Text = DataGridView_empleados.CurrentRow.Cells(15).Value
        Alta_Empleados.DateTime_fecha_nacimiento.Text = DataGridView_empleados.CurrentRow.Cells(16).Value
        Alta_Empleados.TextBox_edad.Text = DataGridView_empleados.CurrentRow.Cells(17).Value
        Alta_Empleados.TextBox_estado_civil.Text = DataGridView_empleados.CurrentRow.Cells(18).Value
        Alta_Empleados.TextBox_nombre_familiar.Text = DataGridView_empleados.CurrentRow.Cells(19).Value
        Alta_Empleados.TextBox_telefono_familiar.Text = DataGridView_empleados.CurrentRow.Cells(20).Value
        Alta_Empleados.TextBox_direccionFam.Text = DataGridView_empleados.CurrentRow.Cells(21).Value
        Alta_Empleados.Text_Url_img.Text = DataGridView_empleados.CurrentRow.Cells(22).Value
        Alta_Empleados.DateTime_fecha_ingreso.Text = DataGridView_empleados.CurrentRow.Cells(23).Value

    End Sub

End Class