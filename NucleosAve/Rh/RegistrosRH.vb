Imports System.Data.SqlClient
Public Class RegistrosRH
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    Private Sub RegistrosRH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub MostrarRegRH()
        Try
            Dim Func As New FuncionRh
            tabla = Func.FnMostrarListadoRh
            If tabla.Rows.Count <> 0 Then
                DataGridView_registros_rh.DataSource = tabla
            Else
                DataGridView_registros_rh.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarRegRH()
    End Sub
    '---------------------------BOtonera---------------------------

    '-----------------------------Botonera minimizar y Cerrar-------------------------------
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

    Private Sub DataGridView_registros_rh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_registros_rh.CellContentClick

    End Sub
    '-------------------------------------------------------------
    '-----------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------
    Private Sub DataGridView_registros_rh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_registros_rh.CellClick
        Rh.limpiar()
        Rh.btn_modificar.Enabled = True
        Rh.btn_modificar.Enabled = True

        Rh.TextBox_id.Text = DataGridView_registros_rh.CurrentRow.Cells(0).Value
        Rh.ComboBox_verificado_calidad.Text = DataGridView_registros_rh.CurrentRow.Cells(1).Value
        Rh.TextBox_clave.Text = DataGridView_registros_rh.CurrentRow.Cells(2).Value
        Rh.TextBox_nombre.Text = DataGridView_registros_rh.CurrentRow.Cells(3).Value
        Rh.ComboBox_departamento.Text = DataGridView_registros_rh.CurrentRow.Cells(4).Value
        Rh.TextBox_puesto.Text = DataGridView_registros_rh.CurrentRow.Cells(5).Value
        Rh.ComboBox_proceso.Text = DataGridView_registros_rh.CurrentRow.Cells(6).Value
        Rh.TextBox_observaciones.Text = DataGridView_registros_rh.CurrentRow.Cells(7).Value
        Rh.DateTime_ingreso.Text = DataGridView_registros_rh.CurrentRow.Cells(8).Value
        Rh.TextBox_salario_diaro.Text = DataGridView_registros_rh.CurrentRow.Cells(9).Value
        Rh.TextBox_numseguro.Text = DataGridView_registros_rh.CurrentRow.Cells(10).Value
        Rh.TextBox_sueldo.Text = DataGridView_registros_rh.CurrentRow.Cells(11).Value
        Rh.TextBox_compensasion.Text = DataGridView_registros_rh.CurrentRow.Cells(12).Value
        Rh.TextBox_tiempo_extra.Text = DataGridView_registros_rh.CurrentRow.Cells(13).Value
        Rh.TextBox_aguinaldo.Text = DataGridView_registros_rh.CurrentRow.Cells(14).Value
        Rh.TextBox_vacaciones.Text = DataGridView_registros_rh.CurrentRow.Cells(15).Value
        Rh.TextBox_prima_vacacional.Text = DataGridView_registros_rh.CurrentRow.Cells(16).Value
        Rh.TextBox_ptu.Text = DataGridView_registros_rh.CurrentRow.Cells(17).Value
        Rh.TextBox_bono_productividad.Text = DataGridView_registros_rh.CurrentRow.Cells(18).Value
        Rh.TextBox_prima_dominical.Text = DataGridView_registros_rh.CurrentRow.Cells(19).Value
        Rh.TextBox_subcidio_incapaciodad.Text = DataGridView_registros_rh.CurrentRow.Cells(20).Value
        Rh.TextBox_sueldo_retroactivo.Text = DataGridView_registros_rh.CurrentRow.Cells(21).Value
        Rh.TextBox_prestamo_personal.Text = DataGridView_registros_rh.CurrentRow.Cells(22).Value
        Rh.TextBox_vacaciones_pagadas.Text = DataGridView_registros_rh.CurrentRow.Cells(23).Value
        Rh.TextBox_gratificacion_anual.Text = DataGridView_registros_rh.CurrentRow.Cells(24).Value
        Rh.TextBox_indemnizacion.Text = DataGridView_registros_rh.CurrentRow.Cells(25).Value
        Rh.TextBox_prima_antiguedad.Text = DataGridView_registros_rh.CurrentRow.Cells(26).Value
        Rh.TextBox_premio_puntualidad.Text = DataGridView_registros_rh.CurrentRow.Cells(27).Value
        Rh.TextBox_prestamo_personal_persepcion.Text = DataGridView_registros_rh.CurrentRow.Cells(28).Value
        Rh.TextBox_total_persepciones_sinprestamo.Text = DataGridView_registros_rh.CurrentRow.Cells(29).Value
        Rh.TextBox_dias.Text = DataGridView_registros_rh.CurrentRow.Cells(30).Value
        Rh.TextBox_sdi.Text = DataGridView_registros_rh.CurrentRow.Cells(31).Value
        Rh.TextBox_inc.Text = DataGridView_registros_rh.CurrentRow.Cells(32).Value
        Rh.TextBox_aus.Text = DataGridView_registros_rh.CurrentRow.Cells(33).Value
        Rh.TextBox_uma_diaria.Text = DataGridView_registros_rh.CurrentRow.Cells(34).Value
        Rh.TextBox_uma_mensual.Text = DataGridView_registros_rh.CurrentRow.Cells(35).Value
        Rh.TextBox_factor_mensual.Text = DataGridView_registros_rh.CurrentRow.Cells(36).Value
        Rh.TextBox_cuotapat.Text = DataGridView_registros_rh.CurrentRow.Cells(37).Value
        Rh.TextBox_cuota_diaria.Text = DataGridView_registros_rh.CurrentRow.Cells(38).Value
        Rh.TextBox_cf.Text = DataGridView_registros_rh.CurrentRow.Cells(39).Value
        Rh.TextBox_falso_verdadero.Text = DataGridView_registros_rh.CurrentRow.Cells(40).Value
        Rh.TextBox_exc_pat.Text = DataGridView_registros_rh.CurrentRow.Cells(41).Value
        Rh.TextBox_pd_pat.Text = DataGridView_registros_rh.CurrentRow.Cells(42).Value
        Rh.TextBox_gmp_pat.Text = DataGridView_registros_rh.CurrentRow.Cells(43).Value
        Rh.TextBox_rt.Text = DataGridView_registros_rh.CurrentRow.Cells(44).Value
        Rh.TextBox_iv_pat.Text = DataGridView_registros_rh.CurrentRow.Cells(45).Value
        Rh.TextBox_gps.Text = DataGridView_registros_rh.CurrentRow.Cells(46).Value
        Rh.TextBox_RETIRO.Text = DataGridView_registros_rh.CurrentRow.Cells(47).Value
        Rh.TextBox_VEJESPATRONAL.Text = DataGridView_registros_rh.CurrentRow.Cells(48).Value
        Rh.TextBox_APORTACION_PATRONAL.Text = DataGridView_registros_rh.CurrentRow.Cells(49).Value
        Rh.TextBox_TOTAL_cARGA_SOCIAL.Text = DataGridView_registros_rh.CurrentRow.Cells(50).Value
        Rh.TextBox_impuestos_nominas.Text = DataGridView_registros_rh.CurrentRow.Cells(51).Value
        Rh.TextBox_manodeObra.Text = DataGridView_registros_rh.CurrentRow.Cells(52).Value
        Rh.TextBox_horas_trabajadas_mes.Text = DataGridView_registros_rh.CurrentRow.Cells(53).Value
        Rh.TextBox_costoporhora.Text = DataGridView_registros_rh.CurrentRow.Cells(54).Value
        Rh.TextBox_costoxminuto.Text = DataGridView_registros_rh.CurrentRow.Cells(55).Value
    End Sub
End Class