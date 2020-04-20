Imports System.Data.SqlClient
Public Class RegistrosReportes
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '-----------------------------Botonera minimizar y Cerrar-------------------------------
    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub
    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
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
    '--------------------------------------------------------------------------------------------------------------------------------------
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<s
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarRegReports()
    End Sub

    Private Sub RegistrosReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combo_empleado()
    End Sub
    Sub combo_empleado() 'combo para mostrar los empleados
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select Id_Empleado,(Nombre_Empleado+' '+Ape_Paterno+' '+Ape_Materno)as Nombre from TB_Empleados order by Nombre_Empleado asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 1 --------------
        ComboBox_empleado.DataSource = tabla
        ComboBox_empleado.DisplayMember = "Nombre"
        ComboBox_empleado.ValueMember = "Id_Empleado"
    End Sub

    Private Sub DataGridView_reportes_atencion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_reportes_atencion.CellClick
        Reportes_Empleado.limpiar()
        Reportes_Empleado.btn_modificar.Enabled = True
        Reportes_Empleado.BtnGuardar.Enabled = False
        Reportes_Empleado.TextBox_id.Text = DataGridView_reportes_atencion.CurrentRow.Cells(0).Value
        Reportes_Empleado.ComboBox_empleado.Text = DataGridView_reportes_atencion.CurrentRow.Cells(1).Value
        Reportes_Empleado.TextBox_quien_Reporta.Text = DataGridView_reportes_atencion.CurrentRow.Cells(2).Value
        Reportes_Empleado.DateTimePicker_fecha.Text = DataGridView_reportes_atencion.CurrentRow.Cells(3).Value
        Reportes_Empleado.TextBox_motivo.Text = DataGridView_reportes_atencion.CurrentRow.Cells(4).Value
        Reportes_Empleado.TextBox_descripcion.Text = DataGridView_reportes_atencion.CurrentRow.Cells(5).Value

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If MessageBox.Show("¿ Estas Seguro Que Quieres Eliminar este registro ? ", "Eliminar Reporte", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New FuncionRh
                Dim logica As New ClassReportesEmpleados

                logica.RE_id = Reportes_Empleado.TextBox_id.Text

                If funciones.FN_EliminarReporte(logica) Then
                    MsgBox("Registro Eliminado Correctamente!!!", MessageBoxIcon.Information)
                    MostrarRegReports()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Sub MostrarRegReports()
        Try
            Dim Func As New FuncionRh
            tabla = Func.FnMostrarReportes
            If tabla.Rows.Count <> 0 Then
                DataGridView_reportes_atencion.DataSource = tabla
            Else
                DataGridView_reportes_atencion.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class