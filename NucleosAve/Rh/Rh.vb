Imports System.Data.SqlClient
Public Class Rh
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx

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
    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub Rh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combo_empleado()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        RegistrosRH.Show()
    End Sub

    Private Sub BtnGuardarFac_Click(sender As Object, e As EventArgs) Handles BtnGuardarFac.Click
        If MessageBox.Show("Estas Seguro Que Quieres agregar nuevo registro", "Nuevo RH", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New FuncionRh
                Dim logica As New ClassRh

                logica.RH_verificado_calidad = Me.ComboBox_verificado_calidad.Text
                logica.RH_clave = Me.TextBox_clave.Text
                logica.RH_nombre_empleado = Me.TextBox_nombre.Text
                logica.RH_departamento = Me.ComboBox_departamento.Text
                logica.RH_puesto = Me.TextBox_puesto.Text
                logica.RH_proceso = Me.ComboBox_proceso.Text
                logica.RH_observaciones = Me.TextBox_observaciones.Text
                logica.RH_ingreso = Me.DateTime_ingreso.Value
                logica.RH_salario_diario = Me.TextBox_salario_diaro.Text
                logica.RH_n_seguro_social = Me.TextBox_numseguro.Text
                logica.RH_sueldo = Me.TextBox_sueldo.Text

                logica.RH_compensacion = Me.TextBox_compensasion.Text
                logica.RH_tiempo_extra = Me.TextBox_tiempo_extra.Text
                logica.RH_aguinaldo = Me.TextBox_aguinaldo.Text
                logica.RH_vacaciones = Me.TextBox_vacaciones.Text
                logica.RH_prima_vacacional = Me.TextBox_prima_vacacional.Text
                logica.RH_ptu = Me.TextBox_ptu.Text
                logica.RH_bono_productividad = Me.TextBox_bono_productividad.Text
                logica.RH_prima_dominical = Me.TextBox_prima_dominical.Text

                logica.RH_subsidio_incapacidad = Me.TextBox_subcidio_incapaciodad.Text
                logica.RH_sueldo_retroactivo = Me.TextBox_sueldo_retroactivo.Text
                logica.RH_prestamo_personal = Me.TextBox_prestamo_personal.Text

                logica.RH_vacaciones_pagadas = Me.TextBox_vacaciones_pagadas.Text
                logica.RH_gratificacion_anual = Me.TextBox_gratificacion_anual.Text
                logica.RH_indemnizacion = Me.TextBox_indemnizacion.Text
                logica.RH_prima_antiguedad = Me.TextBox_prima_antiguedad.Text
                logica.RH_premio_puntualidad = Me.TextBox_premio_puntualidad.Text
                logica.RH_prestamo_personal_percepcion = Me.TextBox_prestamo_personal_persepcion.Text
                logica.RH_total_percepciones_sin_prestamo = Me.TextBox_total_persepciones_sinprestamo.Text
                logica.RH_dias = Me.TextBox_dias.Text
                logica.RH_sdi = Me.TextBox_sdi.Text
                logica.RH_inc = Me.TextBox_inc.Text
                logica.RH_aus = Me.TextBox_aus.Text

                logica.RH_uma_diaria = Me.TextBox_uma_diaria.Text
                logica.RH_uma_mensual = Me.TextBox_uma_mensual.Text
                logica.RH_factor_mensual = Me.TextBox_factor_mensual.Text
                logica.RH_cuota_pat = Me.TextBox_cuotapat.Text
                logica.RH_cuota_diaria = Me.TextBox_cuota_diaria.Text
                logica.RH_cf = Me.TextBox_cf.Text
                logica.RH_verdadero_falso = Me.TextBox_falso_verdadero.Text
                logica.RH_exc_pat = Me.TextBox_exc_pat.Text
                logica.RH_pd_pat = Me.TextBox_pd_pat.Text
                logica.RH_gmp_pat = Me.TextBox_gmp_pat.Text
                logica.RH_rt = Me.TextBox_rt.Text

                logica.RH_iv_pat = Me.TextBox_iv_pat.Text
                logica.RH_gps = Me.TextBox_gps.Text
                logica.RH_retiro = Me.TextBox_RETIRO.Text
                logica.RH_cesantia_vejes = Me.TextBox_VEJESPATRONAL.Text
                logica.RH_aportacion_patronal = Me.TextBox_APORTACION_PATRONAL.Text
                logica.RH_total_carga_social = Me.TextBox_TOTAL_cARGA_SOCIAL.Text
                logica.RH_impuestos_nominas = Me.TextBox_impuestos_nominas.Text
                logica.RH_mano_de_obra = Me.TextBox_manodeObra.Text
                logica.RH_horas_trabajadas_mes = Me.TextBox_horas_trabajadas_mes.Text
                logica.RH_costoxhora = Me.TextBox_costoporhora.Text
                logica.RH_costoxminuto = Me.TextBox_costoxminuto.Text

                If funciones.FN_InsertarRh(logica) Then
                    MsgBox("Datos Insertados Correctamente", MessageBoxIcon.Information)
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MessageBox.Show("Estas Seguro Que Quieres MOdificar este Registro?", "Modificar RH", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New FuncionRh
                Dim logica As New ClassRh

                logica.RH_verificado_calidad = Me.ComboBox_verificado_calidad.Text
                logica.RH_clave = Me.TextBox_clave.Text
                logica.RH_nombre_empleado = Me.TextBox_nombre.Text
                logica.RH_departamento = Me.ComboBox_departamento.Text
                logica.RH_puesto = Me.TextBox_puesto.Text
                logica.RH_proceso = Me.ComboBox_proceso.Text
                logica.RH_observaciones = Me.TextBox_observaciones.Text
                logica.RH_ingreso = Me.DateTime_ingreso.Value
                logica.RH_salario_diario = Me.TextBox_salario_diaro.Text
                logica.RH_n_seguro_social = Me.TextBox_numseguro.Text
                logica.RH_sueldo = Me.TextBox_sueldo.Text

                logica.RH_compensacion = Me.TextBox_compensasion.Text
                logica.RH_tiempo_extra = Me.TextBox_tiempo_extra.Text
                logica.RH_aguinaldo = Me.TextBox_aguinaldo.Text
                logica.RH_vacaciones = Me.TextBox_vacaciones.Text
                logica.RH_prima_vacacional = Me.TextBox_prima_vacacional.Text
                logica.RH_ptu = Me.TextBox_ptu.Text
                logica.RH_bono_productividad = Me.TextBox_bono_productividad.Text
                logica.RH_prima_dominical = Me.TextBox_prima_dominical.Text

                logica.RH_subsidio_incapacidad = Me.TextBox_subcidio_incapaciodad.Text
                logica.RH_sueldo_retroactivo = Me.TextBox_sueldo_retroactivo.Text
                logica.RH_prestamo_personal = Me.TextBox_prestamo_personal.Text

                logica.RH_vacaciones_pagadas = Me.TextBox_vacaciones_pagadas.Text
                logica.RH_gratificacion_anual = Me.TextBox_gratificacion_anual.Text
                logica.RH_indemnizacion = Me.TextBox_indemnizacion.Text
                logica.RH_prima_antiguedad = Me.TextBox_prima_antiguedad.Text
                logica.RH_premio_puntualidad = Me.TextBox_premio_puntualidad.Text
                logica.RH_prestamo_personal_percepcion = Me.TextBox_prestamo_personal_persepcion.Text
                logica.RH_total_percepciones_sin_prestamo = Me.TextBox_total_persepciones_sinprestamo.Text
                logica.RH_dias = Me.TextBox_dias.Text
                logica.RH_sdi = Me.TextBox_sdi.Text
                logica.RH_inc = Me.TextBox_inc.Text
                logica.RH_aus = Me.TextBox_aus.Text

                logica.RH_uma_diaria = Me.TextBox_uma_diaria.Text
                logica.RH_uma_mensual = Me.TextBox_uma_mensual.Text
                logica.RH_factor_mensual = Me.TextBox_factor_mensual.Text
                logica.RH_cuota_pat = Me.TextBox_cuotapat.Text
                logica.RH_cuota_diaria = Me.TextBox_cuota_diaria.Text
                logica.RH_cf = Me.TextBox_cf.Text
                logica.RH_verdadero_falso = Me.TextBox_falso_verdadero.Text
                logica.RH_exc_pat = Me.TextBox_exc_pat.Text
                logica.RH_pd_pat = Me.TextBox_pd_pat.Text
                logica.RH_gmp_pat = Me.TextBox_gmp_pat.Text
                logica.RH_rt = Me.TextBox_rt.Text

                logica.RH_iv_pat = Me.TextBox_iv_pat.Text
                logica.RH_gps = Me.TextBox_gps.Text
                logica.RH_retiro = Me.TextBox_RETIRO.Text
                logica.RH_cesantia_vejes = Me.TextBox_VEJESPATRONAL.Text
                logica.RH_aportacion_patronal = Me.TextBox_APORTACION_PATRONAL.Text
                logica.RH_total_carga_social = Me.TextBox_TOTAL_cARGA_SOCIAL.Text
                logica.RH_impuestos_nominas = Me.TextBox_impuestos_nominas.Text
                logica.RH_mano_de_obra = Me.TextBox_manodeObra.Text
                logica.RH_horas_trabajadas_mes = Me.TextBox_horas_trabajadas_mes.Text
                logica.RH_costoxhora = Me.TextBox_costoporhora.Text
                logica.RH_costoxminuto = Me.TextBox_costoxminuto.Text
                logica.RH_id = Me.TextBox_id.Text


                If funciones.FN_MOdificarRh(logica) Then
                    MsgBox("Datos Insertados Correctamente", MessageBoxIcon.Information)
                    limpiar()
                    btn_modificar.Enabled = False
                    btn_modificar.Enabled = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        limpiar()
    End Sub

    Sub limpiar()
        TextBox_clave.Clear()

        TextBox_puesto.Clear()
        TextBox_observaciones.Clear()
        TextBox_salario_diaro.Clear()
        TextBox_numseguro.Clear()
        TextBox_sueldo.Clear()
        TextBox_compensasion.Clear()
        TextBox_tiempo_extra.Clear()
        TextBox_aguinaldo.Clear()
        TextBox_vacaciones.Clear()
        TextBox_prima_vacacional.Clear()
        TextBox_ptu.Clear()
        TextBox_bono_productividad.Clear()
        TextBox_prima_dominical.Clear()
        TextBox_subcidio_incapaciodad.Clear()
        TextBox_sueldo_retroactivo.Clear()
        TextBox_prestamo_personal.Clear()
        TextBox_vacaciones_pagadas.Clear()
        TextBox_gratificacion_anual.Clear()
        TextBox_indemnizacion.Clear()
        TextBox_prima_antiguedad.Clear()
        TextBox_premio_puntualidad.Clear()
        TextBox_prestamo_personal_persepcion.Clear()
        TextBox_total_persepciones_sinprestamo.Clear()
        TextBox_dias.Clear()
        TextBox_sdi.Clear()
        TextBox_inc.Clear()
        TextBox_aus.Clear()
        TextBox_uma_diaria.Clear()
        TextBox_uma_mensual.Clear()
        TextBox_factor_mensual.Clear()
        TextBox_cuotapat.Clear()
        TextBox_cuota_diaria.Clear()
        TextBox_cf.Clear()
        TextBox_falso_verdadero.Clear()
        TextBox_exc_pat.Clear()
        TextBox_pd_pat.Clear()
        TextBox_gmp_pat.Clear()
        TextBox_rt.Clear()
        TextBox_iv_pat.Clear()
        TextBox_gps.Clear()
        TextBox_RETIRO.Clear()
        TextBox_VEJESPATRONAL.Clear()
        TextBox_APORTACION_PATRONAL.Clear()
        TextBox_TOTAL_cARGA_SOCIAL.Clear()
        TextBox_impuestos_nominas.Clear()
        TextBox_manodeObra.Clear()
        TextBox_horas_trabajadas_mes.Clear()
        TextBox_costoporhora.Clear()
        TextBox_costoxminuto.Clear()
    End Sub

    Private Sub btn_agregar_empleado_Click(sender As Object, e As EventArgs) Handles btn_agregar_empleado.Click
        Alta_Empleados.Show()
    End Sub

    Sub combo_empleado() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select Id_Empleado,(Nombre_Empleado+' '+Ape_Paterno+' '+Ape_Materno)as Nombre from TB_Empleados order by Nombre_Empleado asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 1 --------------
        TextBox_nombre.DataSource = tabla
        TextBox_nombre.DisplayMember = "Nombre"
        TextBox_nombre.ValueMember = "Id_Empleado"
    End Sub



    Sub suma_total_percepciones() Handles TextBox_sueldo.TextChanged, TextBox_compensasion.TextChanged, TextBox_tiempo_extra.TextChanged, TextBox_aguinaldo.TextChanged, TextBox_vacaciones.TextChanged,
                TextBox_prima_vacacional.TextChanged, TextBox_ptu.TextChanged, TextBox_bono_productividad.TextChanged, TextBox_prima_dominical.TextChanged, TextBox_subcidio_incapaciodad.TextChanged,
                TextBox_sueldo_retroactivo.TextChanged, TextBox_prestamo_personal.TextChanged, TextBox_vacaciones_pagadas.TextChanged, TextBox_gratificacion_anual.TextChanged, TextBox_indemnizacion.TextChanged,
                TextBox_prima_antiguedad.TextChanged, TextBox_premio_puntualidad.TextChanged, TextBox_prestamo_personal_persepcion.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim cu5 As Decimal = 0
        Dim cu6 As Decimal = 0
        Dim cu7 As Decimal = 0
        Dim cu8 As Decimal = 0
        Dim cu9 As Decimal = 0
        Dim cu10 As Decimal = 0
        Dim cu11 As Decimal = 0
        Dim cu12 As Decimal = 0
        Dim cu13 As Decimal = 0
        Dim cu14 As Decimal = 0
        Dim cu15 As Decimal = 0
        Dim cu16 As Decimal = 0
        Dim cu17 As Decimal = 0
        Dim cu18 As Decimal = 0

        If TextBox_sueldo.Text <> Nothing Then
            cu1 = CDec(TextBox_sueldo.Text)
        End If
        If TextBox_compensasion.Text <> Nothing Then
            cu2 = CDec(TextBox_compensasion.Text)
        End If
        If TextBox_tiempo_extra.Text <> Nothing Then
            cu3 = CDec(TextBox_tiempo_extra.Text)
        End If
        If TextBox_aguinaldo.Text <> Nothing Then
            cu4 = CDec(TextBox_aguinaldo.Text)
        End If
        If TextBox_vacaciones.Text <> Nothing Then
            cu5 = CDec(TextBox_vacaciones.Text)
        End If
        If TextBox_prima_vacacional.Text <> Nothing Then
            cu6 = CDec(TextBox_prima_vacacional.Text)
        End If
        If TextBox_ptu.Text <> Nothing Then
            cu7 = CDec(TextBox_ptu.Text)
        End If
        If TextBox_bono_productividad.Text <> Nothing Then
            cu8 = CDec(TextBox_bono_productividad.Text)
        End If
        If TextBox_prima_dominical.Text <> Nothing Then
            cu9 = CDec(TextBox_prima_dominical.Text)
        End If
        If TextBox_subcidio_incapaciodad.Text <> Nothing Then
            cu10 = CDec(TextBox_subcidio_incapaciodad.Text)
        End If
        If TextBox_sueldo_retroactivo.Text <> Nothing Then
            cu11 = CDec(TextBox_sueldo_retroactivo.Text)
        End If
        If TextBox_prestamo_personal.Text <> Nothing Then
            cu12 = CDec(TextBox_prestamo_personal.Text)
        End If
        If TextBox_vacaciones_pagadas.Text <> Nothing Then
            cu13 = CDec(TextBox_vacaciones_pagadas.Text)
        End If
        If TextBox_gratificacion_anual.Text <> Nothing Then
            cu14 = CDec(TextBox_gratificacion_anual.Text)
        End If
        If TextBox_indemnizacion.Text <> Nothing Then
            cu15 = CDec(TextBox_indemnizacion.Text)
        End If
        If TextBox_prima_antiguedad.Text <> Nothing Then
            cu16 = CDec(TextBox_prima_antiguedad.Text)
        End If
        If TextBox_premio_puntualidad.Text <> Nothing Then
            cu17 = CDec(TextBox_premio_puntualidad.Text)
        End If
        If TextBox_prestamo_personal_persepcion.Text <> Nothing Then
            cu18 = CDec(TextBox_prestamo_personal_persepcion.Text)
        End If

        TextBox_total_persepciones_sinprestamo.Text = FormatCurrency(cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10 + cu11 + cu12 + cu13 + cu14 + cu15 + cu16 + cu17 + cu18)
    End Sub

    Sub operacion_cf() Handles TextBox_uma_diaria.TextChanged, TextBox_cuotapat.TextChanged, TextBox_dias.TextChanged, TextBox_inc.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0

        If TextBox_uma_diaria.Text <> Nothing Then
            cu1 = CDec(TextBox_uma_diaria.Text)
        End If
        If TextBox_cuotapat.Text <> Nothing Then
            cu2 = CDec(TextBox_cuotapat.Text)
        End If
        If TextBox_dias.Text <> Nothing Then
            cu3 = CDec(TextBox_dias.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu4 = CDec(TextBox_inc.Text)
        End If

        TextBox_cf.Text = FormatCurrency((cu1 * cu2) * (cu3 - cu4))
    End Sub

    Sub operacion_Factor_Mensual() Handles TextBox_uma_diaria.TextChanged, TextBox_factor_mensual.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextBox_uma_diaria.Text <> Nothing Then
            cu1 = CDec(TextBox_uma_diaria.Text)
        End If
        If TextBox_factor_mensual.Text <> Nothing Then
            cu2 = CDec(TextBox_factor_mensual.Text)
        End If

        TextBox_uma_mensual.Text = FormatCurrency((cu1 * cu2))
    End Sub

    Sub operacion_cuota_diaria() Handles TextBox_uma_diaria.TextChanged, TextBox_cuotapat.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextBox_uma_diaria.Text <> Nothing Then
            cu1 = CDec(TextBox_uma_diaria.Text)
        End If
        If TextBox_cuotapat.Text <> Nothing Then
            cu2 = CDec(TextBox_cuotapat.Text)
        End If

        TextBox_cuota_diaria.Text = FormatCurrency((cu1 * cu2))
    End Sub

    Sub operacion_falso_verdadero() Handles TextBox_uma_diaria.TextChanged, TextBox_sdi.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim suma As Decimal = 0

        If TextBox_uma_diaria.Text <> Nothing Then
            cu1 = CDec(TextBox_uma_diaria.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If

        suma = (cu1 * 3)
        If cu2 > suma Then
            TextBox_falso_verdadero.Text = "Verdadero"
            TextBox_falso_verdadero.BackColor = Color.GreenYellow
        Else
            TextBox_falso_verdadero.Text = "Falso"
            TextBox_falso_verdadero.BackColor = Color.Red
        End If
    End Sub

    Sub operacion_exc_pat() Handles TextBox_sdi.TextChanged, TextBox_dias.TextChanged, TextBox_inc.TextChanged, TextBox_uma_diaria.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_sdi.Text <> Nothing Then
            cu1 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_dias.Text <> Nothing Then
            cu2 = CDec(TextBox_dias.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If
        If TextBox_uma_diaria.Text <> Nothing Then
            cu4 = CDec(TextBox_uma_diaria.Text)
        End If

        suma = (cu4 * 3)
        porcentaje = 0.011

        TextBox_exc_pat.Text = (((cu1 - suma) * porcentaje) * (cu2 - cu3))
    End Sub

    Sub operacion_pd_pat() Handles TextBox_dias.TextChanged, TextBox_sdi.TextChanged, TextBox_inc.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_dias.Text <> Nothing Then
            cu1 = CDec(TextBox_dias.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If

        porcentaje = 0.007

        TextBox_pd_pat.Text = ((cu2 * porcentaje) * (cu1 - cu3))
    End Sub

    Sub operacion_GM_pat() Handles TextBox_dias.TextChanged, TextBox_sdi.TextChanged, TextBox_inc.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_dias.Text <> Nothing Then
            cu1 = CDec(TextBox_dias.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If

        porcentaje = 0.0105

        TextBox_gmp_pat.Text = ((cu2 * porcentaje) * (cu1 - cu3))
    End Sub

    Sub operacion_RT() Handles TextBox_dias.TextChanged, TextBox_sdi.TextChanged, TextBox_inc.TextChanged, TextBox_aus.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_dias.Text <> Nothing Then
            cu1 = CDec(TextBox_dias.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If
        If TextBox_aus.Text <> Nothing Then
            cu4 = CDec(TextBox_aus.Text)
        End If


        porcentaje = 0.0253404

        TextBox_rt.Text = ((cu2 * porcentaje) * (cu1 - cu3 - cu4))
    End Sub

    Sub operacion_IV() Handles TextBox_dias.TextChanged, TextBox_sdi.TextChanged, TextBox_inc.TextChanged, TextBox_aus.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_dias.Text <> Nothing Then
            cu1 = CDec(TextBox_dias.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If
        If TextBox_aus.Text <> Nothing Then
            cu4 = CDec(TextBox_aus.Text)
        End If


        porcentaje = 0.0175

        TextBox_iv_pat.Text = ((cu2 * porcentaje) * (cu1 - cu3 - cu4))
    End Sub

    Sub operacion_GPS() Handles TextBox_dias.TextChanged, TextBox_sdi.TextChanged, TextBox_inc.TextChanged, TextBox_aus.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_dias.Text <> Nothing Then
            cu1 = CDec(TextBox_dias.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If
        If TextBox_aus.Text <> Nothing Then
            cu4 = CDec(TextBox_aus.Text)
        End If


        porcentaje = 0.01

        TextBox_gps.Text = ((cu2 * porcentaje) * (cu1 - cu3 - cu4))
    End Sub

    Sub operacion_Retiro() Handles TextBox_dias.TextChanged, TextBox_sdi.TextChanged, TextBox_inc.TextChanged, TextBox_aus.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_dias.Text <> Nothing Then
            cu1 = CDec(TextBox_dias.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If
        If TextBox_aus.Text <> Nothing Then
            cu4 = CDec(TextBox_aus.Text)
        End If


        porcentaje = 0.02

        TextBox_RETIRO.Text = ((cu1 - cu3 - cu4) * cu2) * porcentaje
    End Sub

    Sub cesantia_vejes_patronal() Handles TextBox_dias.TextChanged, TextBox_sdi.TextChanged, TextBox_inc.TextChanged, TextBox_aus.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_dias.Text <> Nothing Then
            cu1 = CDec(TextBox_dias.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If
        If TextBox_aus.Text <> Nothing Then
            cu4 = CDec(TextBox_aus.Text)
        End If

        porcentaje = 0.0315

        TextBox_VEJESPATRONAL.Text = ((cu1 - cu3 - cu4) * cu2) * porcentaje
    End Sub

    Sub operacion_infonavit() Handles TextBox_dias.TextChanged, TextBox_sdi.TextChanged, TextBox_inc.TextChanged, TextBox_aus.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_dias.Text <> Nothing Then
            cu1 = CDec(TextBox_dias.Text)
        End If
        If TextBox_sdi.Text <> Nothing Then
            cu2 = CDec(TextBox_sdi.Text)
        End If
        If TextBox_inc.Text <> Nothing Then
            cu3 = CDec(TextBox_inc.Text)
        End If
        If TextBox_aus.Text <> Nothing Then
            cu4 = CDec(TextBox_aus.Text)
        End If

        porcentaje = 0.05

        TextBox_APORTACION_PATRONAL.Text = ((cu1 - cu3 - cu4) * cu2) * porcentaje
    End Sub

    Sub operacion_total_carga_social() Handles TextBox_cf.TextChanged, TextBox_exc_pat.TextChanged, TextBox_pd_pat.TextChanged, TextBox_gmp_pat.TextChanged, TextBox_rt.TextChanged,
      TextBox_iv_pat.TextChanged, TextBox_gps.TextChanged, TextBox_RETIRO.TextChanged, TextBox_VEJESPATRONAL.TextChanged, TextBox_APORTACION_PATRONAL.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim cu5 As Decimal = 0
        Dim cu6 As Decimal = 0
        Dim cu7 As Decimal = 0
        Dim cu8 As Decimal = 0
        Dim cu9 As Decimal = 0
        Dim cu10 As Decimal = 0

        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_cf.Text <> Nothing Then
            cu1 = CDec(TextBox_cf.Text)
        End If
        If TextBox_exc_pat.Text <> Nothing Then
            cu2 = CDec(TextBox_exc_pat.Text)
        End If
        If TextBox_pd_pat.Text <> Nothing Then
            cu3 = CDec(TextBox_pd_pat.Text)
        End If
        If TextBox_gmp_pat.Text <> Nothing Then
            cu4 = CDec(TextBox_gmp_pat.Text)
        End If
        If TextBox_rt.Text <> Nothing Then
            cu5 = CDec(TextBox_rt.Text)
        End If
        If TextBox_iv_pat.Text <> Nothing Then
            cu6 = CDec(TextBox_iv_pat.Text)
        End If
        If TextBox_gps.Text <> Nothing Then
            cu7 = CDec(TextBox_gps.Text)
        End If
        If TextBox_RETIRO.Text <> Nothing Then
            cu8 = CDec(TextBox_RETIRO.Text)
        End If
        If TextBox_APORTACION_PATRONAL.Text <> Nothing Then
            cu9 = CDec(TextBox_APORTACION_PATRONAL.Text)
        End If
        If TextBox_VEJESPATRONAL.Text <> Nothing Then
            cu10 = CDec(TextBox_VEJESPATRONAL.Text)
        End If

        TextBox_TOTAL_cARGA_SOCIAL.Text = (cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10)
    End Sub

    Sub operacion_impuestos_nominas() Handles TextBox_sueldo.TextChanged, TextBox_compensasion.TextChanged, TextBox_tiempo_extra.TextChanged, TextBox_aguinaldo.TextChanged, TextBox_vacaciones.TextChanged,
               TextBox_prima_vacacional.TextChanged, TextBox_ptu.TextChanged, TextBox_bono_productividad.TextChanged, TextBox_prima_dominical.TextChanged, TextBox_subcidio_incapaciodad.TextChanged,
               TextBox_sueldo_retroactivo.TextChanged, TextBox_prestamo_personal.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim cu5 As Decimal = 0
        Dim cu6 As Decimal = 0
        Dim cu7 As Decimal = 0
        Dim cu8 As Decimal = 0
        Dim cu9 As Decimal = 0
        Dim cu10 As Decimal = 0
        Dim cu11 As Decimal = 0
        Dim cu12 As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_sueldo.Text <> Nothing Then
            cu1 = CDec(TextBox_sueldo.Text)
        End If
        If TextBox_compensasion.Text <> Nothing Then
            cu2 = CDec(TextBox_compensasion.Text)
        End If
        If TextBox_tiempo_extra.Text <> Nothing Then
            cu3 = CDec(TextBox_tiempo_extra.Text)
        End If
        If TextBox_aguinaldo.Text <> Nothing Then
            cu4 = CDec(TextBox_aguinaldo.Text)
        End If
        If TextBox_vacaciones.Text <> Nothing Then
            cu5 = CDec(TextBox_vacaciones.Text)
        End If
        If TextBox_prima_vacacional.Text <> Nothing Then
            cu6 = CDec(TextBox_prima_vacacional.Text)
        End If
        If TextBox_ptu.Text <> Nothing Then
            cu7 = CDec(TextBox_ptu.Text)
        End If
        If TextBox_bono_productividad.Text <> Nothing Then
            cu8 = CDec(TextBox_bono_productividad.Text)
        End If
        If TextBox_prima_dominical.Text <> Nothing Then
            cu9 = CDec(TextBox_prima_dominical.Text)
        End If
        If TextBox_subcidio_incapaciodad.Text <> Nothing Then
            cu10 = CDec(TextBox_subcidio_incapaciodad.Text)
        End If
        If TextBox_sueldo_retroactivo.Text <> Nothing Then
            cu11 = CDec(TextBox_sueldo_retroactivo.Text)
        End If
        If TextBox_prestamo_personal.Text <> Nothing Then
            cu12 = CDec(TextBox_prestamo_personal.Text)
        End If

        porcentaje = 0.03
        TextBox_impuestos_nominas.Text = FormatCurrency((cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10 + cu11 + cu12) * porcentaje)
    End Sub

    Sub operacion_ManodeObra() Handles TextBox_TOTAL_cARGA_SOCIAL.TextChanged, TextBox_impuestos_nominas.TextChanged, TextBox_total_persepciones_sinprestamo.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0


        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_TOTAL_cARGA_SOCIAL.Text <> Nothing Then
            cu1 = CDec(TextBox_TOTAL_cARGA_SOCIAL.Text)
        End If
        If TextBox_impuestos_nominas.Text <> Nothing Then
            cu2 = CDec(TextBox_impuestos_nominas.Text)
        End If
        If TextBox_total_persepciones_sinprestamo.Text <> Nothing Then
            cu3 = CDec(TextBox_total_persepciones_sinprestamo.Text)
        End If

        TextBox_manodeObra.Text = (cu1 + cu2 + cu3)
    End Sub

    Sub operacion_costoporhora() Handles TextBox_manodeObra.TextChanged, TextBox_horas_trabajadas_mes.TextChanged

        Dim cu1 As Double
        Dim cu2 As Double
        Dim cu3 As Decimal = 0


        Dim suma As Decimal = 0
        Dim porcentaje As Decimal = 0

        If TextBox_manodeObra.Text <> Nothing Then
            cu1 = (TextBox_manodeObra.Text)
        End If
        If TextBox_horas_trabajadas_mes.Text <> Nothing Then
            cu2 = (TextBox_horas_trabajadas_mes.Text)
        End If

        If TextBox_manodeObra.Text <> "0" And TextBox_horas_trabajadas_mes.Text <> "0" Then
            TextBox_costoporhora.Text = (cu1 / cu2)
        Else

        End If
    End Sub
    Sub operacion_costoporminuto() Handles TextBox_costoporhora.TextChanged

        Dim cu1 As Double
        Dim cu2 As Decimal
        Dim cu3 As Decimal


        Dim numero As Double
        Dim porcentaje As Decimal = 0

        If TextBox_costoporhora.Text <> Nothing Then
            cu1 = (TextBox_costoporhora.Text)
        End If

        numero = 60

        TextBox_costoxminuto.Text = (cu1 / numero)


    End Sub
End Class