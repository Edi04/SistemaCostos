Imports System.Data.SqlClient
Public Class Reportes_Empleado
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
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private Sub Reportes_Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btn_Registros_Click(sender As Object, e As EventArgs) Handles btn_Registros.Click
        RegistrosReportes.Show()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If MessageBox.Show("Estas Seguro Que Quieres agregar nuevo registro", "Nuevo Reporte", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New FuncionRh
                Dim logica As New ClassReportesEmpleados

                logica.RE_empleado = Me.ComboBox_empleado.Text
                logica.RE_quien_reporta = Me.TextBox_quien_Reporta.Text
                logica.RE_fecha = Me.DateTimePicker_fecha.Text
                logica.RE_motivo = Me.TextBox_motivo.Text
                logica.RE_descripcion = Me.TextBox_descripcion.Text

                If funciones.FN_InsertarReportes(logica) Then
                    MsgBox("Datos Insertados Correctamente", MessageBoxIcon.Information)
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        limpiar()
        btn_modificar.Enabled = False
        BtnGuardar.Enabled = True
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MessageBox.Show("¿Estas Seguro Que Quieres modificar este registro?", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New FuncionRh
                Dim logica As New ClassReportesEmpleados

                logica.RE_empleado = Me.ComboBox_empleado.Text
                logica.RE_quien_reporta = Me.TextBox_quien_Reporta.Text
                logica.RE_fecha = Me.DateTimePicker_fecha.Text
                logica.RE_motivo = Me.TextBox_motivo.Text
                logica.RE_descripcion = Me.TextBox_descripcion.Text
                logica.RE_id = Me.TextBox_id.Text

                If funciones.FN_InsertarReportes(logica) Then
                    MsgBox("Datos Modificados Correctamente", MessageBoxIcon.Information)
                    btn_modificar.Enabled = False
                    BtnGuardar.Enabled = True
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Sub limpiar()
        TextBox_quien_Reporta.Clear()
        TextBox_motivo.Clear()
        TextBox_descripcion.Clear()
        TextBox_id.Clear()
    End Sub


End Class