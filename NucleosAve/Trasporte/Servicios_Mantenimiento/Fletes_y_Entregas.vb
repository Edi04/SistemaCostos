Imports System.Data.SqlClient
Public Class Fletes_y_Entregas
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
    Private Sub Fletes_y_Entregas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarCodigo()
    End Sub

    Private Sub Codigo_Click(sender As Object, e As EventArgs) Handles Codigo.Click

    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Agregar " + Codigo.Text, "Fletes y Entregas", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            Dim funciones As New Funcion_Controlador
            Dim logica As New ClassFletesYEntregas

            logica.FE_codigo = Me.Codigo.Text
            logica.FE_vehiculo = Me.TextBox_vehiculo.Text
            logica.FE_salida = Me.DateTime_salida.Value
            logica.FE_regreso = Me.DateTime_regreso.Value
            logica.FE_km_recorridos = Me.TextBox_kmRecorridos.Text
            logica.FE_dias_viaje = Me.TextBox_dia_viaje.Text
            logica.FE_mantenimiento_promedio = Me.TextBox_mantenimiento_promedio.Text
            logica.FE_depresiacion = Me.TextBox_depreciacion.Text
            logica.FE_ot = Me.TextBox_Ot.Text
            logica.FE_chofer = Me.TextBox_chofer.Text
            logica.FE_sueldo = Me.TextBox_sueldo.Text
            logica.FE_costo_diesel = Me.TextBox_costo_diesel.Text
            logica.FE_litros = Me.TextBox_litros.Text
            logica.FE_total_diesel = Me.TextBox_total_diesel.Text
            logica.FE_casetas = Me.TextBox_casetas.Text
            logica.FE_fumigacion = Me.TextBox_fumigacion.Text
            logica.FE_gastos_varios = Me.TextBox_gastosvarios.Text
            logica.FE_comidas = Me.TextBox_comidas.Text
            logica.FE_varios = Me.TextBox_comidas.Text
            logica.FE_sueldo2 = Me.TextBox_sueldo2.Text
            logica.FE_mantenimiento = Me.TextBox_mantenimiento.Text
            logica.FE_depresiacion2 = Me.TextBox_depreciacion2.Text
            logica.FE_total_gastos_variable_mas_fijos = Me.TextBox_total_gastos_variable_mas_fijos.Text
            logica.FE_porcentaje = Me.TextBox_porcentaje.Text
            logica.FE_Utilidad_diaria = Me.TextBox_utilidad_diaria.Text

            logica.FE_total_a_pagar = Me.TextBox_total_a_pagar.Text
            logica.FE_retencion_aplicada = Me.TextBox_retencion_aplicada.Text
            logica.FE_iva_aplicado = Me.TextBox_iva_aplicado.Text
            logica.FE_costo_servicion = Me.TextBox_costo_servicion.Text


            If funciones.FN_Insertar_flete_entregas(logica) Then
                MsgBox("Insertado Correctamente", MessageBoxIcon.Information)
                GenerarCodigo()
            End If

        End If
    End Sub

    Public Sub Suma_Sueldo() Handles TextBox_sueldo.TextChanged, TextBox_dia_viaje.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim resultado As Double = 0

        If TextBox_sueldo.Text <> Nothing Then
            cu1 = (TextBox_sueldo.Text)
        End If

        If TextBox_dia_viaje.Text <> Nothing Then
            cu2 = (TextBox_dia_viaje.Text)
        End If
        TextBox_sueldo2.Text = FormatCurrency((cu1 * cu2), 4)

    End Sub

    Public Sub Suma_mantenimiento() Handles TextBox_mantenimiento_promedio.TextChanged, TextBox_dia_viaje.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim resultado As Double = 0

        If TextBox_mantenimiento_promedio.Text <> Nothing Then
            cu1 = (TextBox_mantenimiento_promedio.Text)
        End If

        If TextBox_dia_viaje.Text <> Nothing Then
            cu2 = (TextBox_dia_viaje.Text)
        End If
        TextBox_mantenimiento.Text = FormatCurrency((cu1 * cu2), 4)

    End Sub

    Public Sub Suma_depreciacion() Handles TextBox_depreciacion.TextChanged, TextBox_dia_viaje.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim resultado As Double = 0

        If TextBox_depreciacion.Text <> Nothing Then
            cu1 = (TextBox_depreciacion.Text)
        End If

        If TextBox_dia_viaje.Text <> Nothing Then
            cu2 = (TextBox_dia_viaje.Text)
        End If
        TextBox_depreciacion2.Text = FormatCurrency((cu1 * cu2), 4)

    End Sub

    Public Sub Total_gasto_variable() Handles TextBox_total_diesel.TextChanged, TextBox_casetas.TextChanged, TextBox_fumigacion.TextChanged,
        TextBox_gastosvarios.TextChanged, TextBox_comidas.TextChanged, TextBox_varios.TextChanged,
        TextBox_sueldo2.TextChanged, TextBox_mantenimiento.TextChanged, TextBox_depreciacion2.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0

        If TextBox_total_diesel.Text <> Nothing Then
            cu1 = (TextBox_total_diesel.Text)
        End If

        If TextBox_casetas.Text <> Nothing Then
            cu2 = (TextBox_casetas.Text)
        End If

        If TextBox_fumigacion.Text <> Nothing Then
            cu3 = (TextBox_fumigacion.Text)
        End If

        If TextBox_gastosvarios.Text <> Nothing Then
            cu4 = (TextBox_gastosvarios.Text)
        End If

        If TextBox_comidas.Text <> Nothing Then
            cu5 = (TextBox_comidas.Text)
        End If

        If TextBox_varios.Text <> Nothing Then
            cu6 = (TextBox_varios.Text)
        End If

        If TextBox_sueldo2.Text <> Nothing Then
            cu7 = (TextBox_sueldo2.Text)
        End If

        If TextBox_mantenimiento.Text <> Nothing Then
            cu8 = (TextBox_mantenimiento.Text)
        End If

        If TextBox_depreciacion2.Text <> Nothing Then
            cu9 = (TextBox_depreciacion2.Text)
        End If
        TextBox_total_gastos_variable_mas_fijos.Text = FormatCurrency((cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9), 4)

    End Sub


    Public Sub Utilidad_facturado_gastos() Handles TextBox_costo_servicion.TextChanged, TextBox_total_gastos_variable_mas_fijos.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0


        If TextBox_costo_servicion.Text <> Nothing Then
            cu1 = (TextBox_costo_servicion.Text)
        End If

        If TextBox_total_gastos_variable_mas_fijos.Text <> Nothing Then
            cu2 = (TextBox_total_gastos_variable_mas_fijos.Text)
        End If


        TextBox_utilidad_entre_facturado_gastos.Text = FormatCurrency((cu1 - cu2), 4)

    End Sub

    Public Sub total_porcentaje() Handles TextBox_costo_servicion.TextChanged, TextBox_total_gastos_variable_mas_fijos.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0


        If TextBox_costo_servicion.Text <> Nothing Then
            cu1 = (TextBox_costo_servicion.Text)
        End If

        If TextBox_total_gastos_variable_mas_fijos.Text <> Nothing Then
            cu2 = (TextBox_total_gastos_variable_mas_fijos.Text)
        End If


        TextBox_porcentaje.Text = FormatCurrency(((cu1 / cu2) - 1), 4)

    End Sub

    Public Sub total_utilidad_diaria() Handles TextBox_dia_viaje.TextChanged, TextBox_utilidad_entre_facturado_gastos.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0


        If TextBox_utilidad_entre_facturado_gastos.Text <> Nothing Then
            cu1 = (TextBox_utilidad_entre_facturado_gastos.Text)
        End If

        If TextBox_dia_viaje.Text <> Nothing Then
            cu2 = (TextBox_dia_viaje.Text)
        End If


        TextBox_utilidad_diaria.Text = FormatCurrency((cu1 / cu2), 4)

    End Sub

    Private Sub btn_buscar_vehiculo_Click(sender As Object, e As EventArgs) Handles btn_buscar_vehiculo.Click
        AltaTrasportes.Show()
    End Sub

    Private Sub btn_ot_Click(sender As Object, e As EventArgs) Handles btn_ot.Click
        Entregas_diarias.Show()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()
    End Sub

    Sub GenerarCodigo()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_flete_entrega)from TB_Fletes_Entregas", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        Codigo.Text = "FE-" + Format(id + 1, "0000") + "/20"
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        registros_fletes_y_entregas.Show()
    End Sub

    Sub limpiar()
        GenerarCodigo()
        TextBox_vehiculo.Clear()
        TextBox_kmRecorridos.Clear()
        TextBox_dia_viaje.Clear()
        TextBox_mantenimiento_promedio.Clear()
        TextBox_depreciacion.Clear()
        TextBox_Ot.Clear()
        TextBox_chofer.Clear()
        TextBox_sueldo.Clear()
        TextBox_costo_diesel.Clear()
        TextBox_litros.Clear()
        TextBox_total_diesel.Clear()
        TextBox_casetas.Clear()
        TextBox_fumigacion.Clear()
        TextBox_gastosvarios.Clear()
        TextBox_comidas.Clear()
        TextBox_comidas.Clear()
        TextBox_sueldo2.Clear()
        TextBox_mantenimiento.Clear()
        TextBox_depreciacion2.Clear()
        TextBox_total_gastos_variable_mas_fijos.Clear()
        TextBox_porcentaje.Clear()
        TextBox_utilidad_diaria.Clear()

        TextBox_total_a_pagar.Clear()
        TextBox_retencion_aplicada.Clear()
        TextBox_iva_aplicado.Clear()
        TextBox_costo_servicion.Clear()
    End Sub
End Class