Imports System.Data.SqlClient
Public Class ServiciosMantenimiento
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    Private Sub ServiciosMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combo_tipo_servicio()
        combo_Prestador_servicio()
        combo_porqueServicio()
        GenerarCodigo()
    End Sub

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub


    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Sub GenerarCodigo()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_mantenimiento)from TB_Servicios_Mantenimiento_Trasportes", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        txtcodigo.Text = "Mante-" + Format(id + 1, "0000") + "/20"
    End Sub

    '                                        ...:::: Alta Trasportes :::...
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.
    '_______________________________________________________________________________________________________________________________________
    '                                         ...::: Alta :::...
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Agregar " + txtcodigo.Text, "Nuevo Mantenimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Controlador
                Dim logica As New ClassMantenimientos

                logica.T_orden_servicio = Me.txtcodigo.Text
                logica.T_Fecha_os = Me.Fecha_os.Value
                logica.T_trasportes = Me.T_trasportes.Text
                logica.T_Fecha_Solicitud = Me.T_Fecha_Solicitud.Value
                logica.T_Fecha_Aplicacion = Me.T_Fecha_Aplicacion.Value
                logica.T_Fecha_Entrega_Estimada = Me.T_Fecha_Entrega_Estimada.Value
                logica.T_Kilometraje_Actual = Me.T_Kilometraje_Actual.Text
                logica.T_Fecha_Kilometraje = Me.T_Fecha_Kilometraje.Value
                logica.T_Tipo_de_Servicio = Me.T_Tipo_de_Servicio.Text
                logica.T_Prestador_del_Servicio = Me.T_Prestador_del_Servicio.Text
                logica.T_Descripcion_Mantenimiento = Me.T_Descripcion_Mantenimiento.Text
                logica.T_Sobre_Servicio = Me.T_Sobre_Servicio.Text
                logica.T_Servicio_Extraordinario = Me.T_Servicio_Extraordinario.Text
                logica.T_Descripcion_ServicioEX = Me.T_Descripcion_ServicioEX.Text
                logica.T_Refacciones = Me.T_Refacciones.Text
                logica.T_Reviciones_Programadas = Me.T_Reviciones_Programadas.Text
                logica.T_Programadas_fecha_reviciones = Me.Programadas_fecha_reviciones.Text
                logica.T_Observaciones_Generales = Me.T_Observaciones_Generales.Text
                logica.T_ProximoServicio = Me.T_ProximoServicio.Value
                logica.T_Recomendaciones = Me.T_Recomendaciones.Text
                logica.T_Recibio_Recomendaciones = Me.T_Recibio_Recomendaciones.Text
                logica.T_Costo_Refacciones = Me.T_Costo_Refacciones.Text
                logica.T_Costo_servicio = Me.T_Costo_servicio.Text
                logica.T_costo_traslado = Me.T_costo_traslado.Text
                logica.T_costo_total = Me.T_costo_total.Text
                logica.T_Autorizo = Me.T_Autorizo.Text
                logica.T_realizo_servicio = Me.T_realizo_servicio.Text
                logica.T_Chofer = Me.T_Chofer.Text
                logica.T_comprobantes = Me.Text_Url_Pdf.Text
                If funciones.FN_InsertarMantenimientos(logica) Then
                    MsgBox("Servicio Agregado Correctamente", MessageBoxIcon.Information)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '---------------------------------------registro de tabla 1------------------------------------------------
            If (Textrefac1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac1.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 2------------------------------------------------
            If (Textrefac2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac2.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 3------------------------------------------------
            If (Textrefac3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac3.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 4------------------------------------------------
            If (Textrefac4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac4.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '---------------------------------------registro de tabla 5------------------------------------------------
            If (Textrefac5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac5.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 6------------------------------------------------
            If (Textrefac6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac6.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 6------------------------------------------------
            If (Textrefac7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac7.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 7------------------------------------------------
            If (Textrefac7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac7.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '---------------------------------------registro de tabla 8------------------------------------------------
            If (Textrefac8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac8.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 9------------------------------------------------
            If (Textrefac9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac9.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 10------------------------------------------------
            If (Textrefac10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_orden_servicio = Me.txtcodigo.Text
                    logica.T_producto = Me.Textrefac10.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text

                    If funciones.FN_InsertarRefacciones(logica) Then
                        'MsgBox("Refacciones Insertadas Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '----------------------------limpiar Cajas ---------------------------------

        End If

    End Sub
    '                              ...::: cOMBOS :::...
    Sub combo_tipo_servicio()
        Try
            Dim connection As New SqlConnection("Data Source=SISTEMAS-PC\;Initial Catalog=SISUT020;User ID=N_ave;Password=ave123")
            comando = New SqlCommand("select * from TB_ServiciosT", connection)
            adaptador = New SqlDataAdapter(comando)
            tabla = New DataTable()
            adaptador.Fill(tabla)
            T_Tipo_de_Servicio.DataSource = tabla
            T_Tipo_de_Servicio.DisplayMember = "Nombre"
            T_Tipo_de_Servicio.ValueMember = "id_servicio"

        Catch ex As Exception
            MsgBox("Ocurrio un error en combo Servicios1")
        End Try
    End Sub

    Sub combo_Prestador_servicio()
        Try
            Dim connection As New SqlConnection("Data Source=SISTEMAS-PC\;Initial Catalog=SISUT020;User ID=N_ave;Password=ave123")
            comando = New SqlCommand("select * from TB_Prestador_Servicios_Trasportes", connection)
            adaptador = New SqlDataAdapter(comando)
            tabla = New DataTable()
            adaptador.Fill(tabla)
            T_Prestador_del_Servicio.DataSource = tabla
            T_Prestador_del_Servicio.DisplayMember = "nombre"
            T_Prestador_del_Servicio.ValueMember = "id_Prestador_Servicio"

        Catch ex As Exception
            MsgBox("Ocurrio un error en combo Servicios2")
        End Try
    End Sub

    Sub combo_porqueServicio()
        Try
            Dim connection As New SqlConnection("Data Source=SISTEMAS-PC\;Initial Catalog=SISUT020;User ID=N_ave;Password=ave123")
            comando = New SqlCommand("select * from TB_Motivos_Servicio", connection)
            adaptador = New SqlDataAdapter(comando)
            tabla = New DataTable()
            adaptador.Fill(tabla)
            T_Sobre_Servicio.DataSource = tabla
            T_Sobre_Servicio.DisplayMember = "motivo"
            T_Sobre_Servicio.ValueMember = "id_motivo"

        Catch ex As Exception
            MsgBox("Ocurrio un error en combo Servicios3")
        End Try
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        AltaTrasportes.ShowDialog()
    End Sub

    Private Sub T_costo_total_TextChanged(sender As Object, e As EventArgs) Handles T_costo_total.TextChanged
        btn_guardar.Enabled = True
    End Sub

    Private Sub T_Servicio_Extraordinario_SelectedValueChanged(sender As Object, e As EventArgs) Handles T_Servicio_Extraordinario.SelectedValueChanged
        If T_Servicio_Extraordinario.Text = "NO" Then
            T_Descripcion_ServicioEX.Visible = False
            Label16.Visible = False
        Else
            T_Descripcion_ServicioEX.Visible = True
            Label16.Visible = True
        End If
    End Sub

    Private Sub btn_pdf_Click(sender As Object, e As EventArgs) Handles btn_pdf.Click
        Try
            Dim cancelado As Boolean = False
            Dim openFD As New OpenFileDialog()
            With openFD
                .Title = "Factura PDF"
                .Filter = "Documento Digital (*.pdf)|*.pdf"
                .Multiselect = False
                '.InitialDirectory = My.Computer.FileSystem.CurrentDirectory //abrir en carpeta de ejecucion del programa
                .InitialDirectory = "c:\"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    textpdf.Text = IO.Path.GetFileName(.FileName)
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Mantenimientos\PDF"
                    Dim fichero As New System.IO.FileInfo(pathDefinitivo & "\" & textpdf.Text)
                    Text_Url_Pdf.Text = pathDefinitivo & "\" & textpdf.Text
                    If fichero.Exists Then
                        If MessageBox.Show("El archivo seleccionado ya está incluido" & ControlChars.NewLine & "¿Desea sobreescribirlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            cancelado = True
                            Text_Url_Pdf.Clear()
                        Else
                            System.IO.File.Delete(fichero.FullName)
                        End If
                    End If
                    If Not cancelado Then
                        System.IO.File.Copy(.FileName, fichero.FullName)
                        MsgBox("Archivo Almacenado Correctamente", MessageBoxIcon.Exclamation)
                    End If

                Else
                    Text_Url_Pdf.Clear()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub T_Refacciones_SelectedValueChanged(sender As Object, e As EventArgs) Handles T_Refacciones.SelectedValueChanged
        If T_Refacciones.Text = "NO" Then
            Label28.Visible = False
            Label26.Visible = False
            N1.Visible = False
            N2.Visible = False
            N3.Visible = False
            N4.Visible = False
            N5.Visible = False
            N6.Visible = False
            N7.Visible = False
            N8.Visible = False
            N9.Visible = False
            N10.Visible = False
            Textrefac1.Visible = False
            Textrefac2.Visible = False
            Textrefac3.Visible = False
            Textrefac4.Visible = False
            Textrefac5.Visible = False
            Textrefac6.Visible = False
            Textrefac7.Visible = False
            Textrefac8.Visible = False
            Textrefac9.Visible = False
            Textrefac10.Visible = False
            Label25.Visible = False
            total_gastos_refacciones.Visible = False
            Label39.Visible = False
            TextProveedor.Visible = False
        Else
            Label28.Visible = True
            Label26.Visible = True
            N1.Visible = True
            N2.Visible = True
            N3.Visible = True
            N4.Visible = True
            N5.Visible = True
            N6.Visible = True
            N7.Visible = True
            N8.Visible = True
            N9.Visible = True
            N10.Visible = True
            Textrefac1.Visible = True
            Textrefac2.Visible = True
            Textrefac3.Visible = True
            Textrefac4.Visible = True
            Textrefac5.Visible = True
            Textrefac6.Visible = True
            Textrefac7.Visible = True
            Textrefac8.Visible = True
            Textrefac9.Visible = True
            Textrefac10.Visible = True
            Label25.Visible = True
            total_gastos_refacciones.Visible = True
            Label39.Visible = True
            TextProveedor.Visible = True
        End If
    End Sub
    '::::::::::::::::::::::::::::::::..............Validaciones................::::::::::::::::::::::::::::::::
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal com As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(com.KeyChar) Then
            com.Handled = False
        ElseIf Char.IsControl(com.KeyChar) Then
            com.Handled = False
        ElseIf com.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            com.Handled = True
        ElseIf com.KeyChar = "." Then
            com.Handled = False
        Else
            com.Handled = True
            MsgBox("Solo se puede ingresar numeros y punto", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub T_Costo_Refacciones_KeyPress(sender As Object, com As KeyPressEventArgs) Handles T_Costo_Refacciones.KeyPress
        NumerosyDecimal(T_Costo_Refacciones, com)
    End Sub
    Private Sub T_Costo_servicio_KeyPress(sender As Object, com As KeyPressEventArgs) Handles T_Costo_servicio.KeyPress
        NumerosyDecimal(T_Costo_servicio, com)
    End Sub
    Private Sub T_costo_traslado_KeyPress(sender As Object, com As KeyPressEventArgs) Handles T_costo_traslado.KeyPress
        NumerosyDecimal(T_costo_traslado, com)
    End Sub


    Private Sub T_costo_total_traslado_KeyPress(sender As Object, com As KeyPressEventArgs) Handles T_costo_total.KeyPress
        NumerosyDecimal(T_costo_total, com)
    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::::::::Fin Validaciones::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Sub MostrarRegMantenimientos()
        Try
            Dim Func As New Funcion_Controlador
            tabla = Func.FnMostrarMantenimientos
            If tabla.Rows.Count <> 0 Then
                Registros_Mantenimientos.DataSource = tabla
            Else
                Registros_Mantenimientos.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarRegMantenimientos()
    End Sub

    Private Sub total_gastos_refacciones_TextChanged(sender As Object, e As EventArgs) Handles total_gastos_refacciones.TextChanged

    End Sub


    Private Sub Registros_Mantenimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Registros_Mantenimientos.CellClick
        Btn_modificar.Enabled = True
        btn_guardar.Enabled = False

        T_trasportes.Clear()
        T_Kilometraje_Actual.Clear()
        T_Descripcion_Mantenimiento.Clear()
        T_Descripcion_ServicioEX.Clear()
        Textrefac1.Clear()
        Textrefac2.Clear()
        Textrefac3.Clear()
        Textrefac4.Clear()
        Textrefac5.Clear()
        Textrefac6.Clear()
        Textrefac7.Clear()
        Textrefac8.Clear()
        Textrefac9.Clear()
        Textrefac10.Clear()
        total_gastos_refacciones.Clear()
        TextProveedor.Clear()
        T_Observaciones_Generales.Clear()
        T_Recomendaciones.Clear()
        T_Recibio_Recomendaciones.Clear()
        T_Costo_Refacciones.Clear()
        T_Costo_servicio.Clear()
        T_costo_traslado.Clear()
        T_costo_total.Clear()
        T_Autorizo.Clear()
        T_realizo_servicio.Clear()
        T_Chofer.Clear()

        txtcodigo.Text = Registros_Mantenimientos.CurrentRow.Cells(0).Value
        T_trasportes.Text = Registros_Mantenimientos.CurrentRow.Cells(1).Value
        T_Tipo_de_Servicio.Text = Registros_Mantenimientos.CurrentRow.Cells(2).Value
        T_Prestador_del_Servicio.Text = Registros_Mantenimientos.CurrentRow.Cells(3).Value
        T_Descripcion_Mantenimiento.Text = Registros_Mantenimientos.CurrentRow.Cells(4).Value
        T_Sobre_Servicio.Text = Registros_Mantenimientos.CurrentRow.Cells(5).Value
        Fecha_os.Value = Registros_Mantenimientos.CurrentRow.Cells(6).Value
        T_Fecha_Solicitud.Value = Registros_Mantenimientos.CurrentRow.Cells(7).Value
        T_Fecha_Aplicacion.Value = Registros_Mantenimientos.CurrentRow.Cells(8).Value
        T_Fecha_Entrega_Estimada.Value = Registros_Mantenimientos.CurrentRow.Cells(9).Value
        T_Kilometraje_Actual.Text = Registros_Mantenimientos.CurrentRow.Cells(10).Value
        T_Fecha_Kilometraje.Text = Registros_Mantenimientos.CurrentRow.Cells(11).Value
        T_Servicio_Extraordinario.Text = Registros_Mantenimientos.CurrentRow.Cells(12).Value
        T_Descripcion_ServicioEX.Text = Registros_Mantenimientos.CurrentRow.Cells(13).Value
        T_Refacciones.Text = Registros_Mantenimientos.CurrentRow.Cells(14).Value
        T_Reviciones_Programadas.Text = Registros_Mantenimientos.CurrentRow.Cells(15).Value
        Programadas_fecha_reviciones.Value = Registros_Mantenimientos.CurrentRow.Cells(16).Value
        T_Observaciones_Generales.Text = Registros_Mantenimientos.CurrentRow.Cells(17).Value
        T_ProximoServicio.Value = Registros_Mantenimientos.CurrentRow.Cells(18).Value
        T_Recomendaciones.Text = Registros_Mantenimientos.CurrentRow.Cells(19).Value
        T_Recibio_Recomendaciones.Text = Registros_Mantenimientos.CurrentRow.Cells(20).Value
        T_Costo_Refacciones.Text = Registros_Mantenimientos.CurrentRow.Cells(21).Value
        total_gastos_refacciones.Text = Registros_Mantenimientos.CurrentRow.Cells(21).Value
        T_Costo_servicio.Text = Registros_Mantenimientos.CurrentRow.Cells(22).Value
        T_costo_traslado.Text = Registros_Mantenimientos.CurrentRow.Cells(23).Value
        T_costo_total.Text = Registros_Mantenimientos.CurrentRow.Cells(24).Value
        T_Autorizo.Text = Registros_Mantenimientos.CurrentRow.Cells(25).Value
        T_realizo_servicio.Text = Registros_Mantenimientos.CurrentRow.Cells(26).Value
        T_Chofer.Text = Registros_Mantenimientos.CurrentRow.Cells(27).Value
        Try
            If (Registros_Mantenimientos.CurrentRow.Cells(28).Value.ToString = Nothing) Then
                ' MsgBox("No hay nada")
            Else
                Registros_Mantenimientos.Text = Registros_Mantenimientos.CurrentRow.Cells(28).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::Consulta:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        Try
            Dim tabla As New DataTable
            Dim codigo As String
            codigo = Registros_Mantenimientos.CurrentRow.Cells(0).Value
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da As New SqlDataAdapter
            conexxo.Open()
            Dim comando As New SqlCommand("
            SELECT
              id_refaccion,
              codigo_mantenimiento,
              producto,
              nombre_proveedor
           FROM 
              TB_Refacciones_Trasporte
           WHERE 
              codigo_mantenimiento='" + codigo + "'", conexxo)
            da.SelectCommand = comando
            da.Fill(tabla)

            If (tabla.Rows.Count >= 1) Then
                'producto 1
                Text_Id_Factura1.Text = tabla.Rows(0)(0).ToString
                Textrefac1.Text = tabla.Rows(0)(2).ToString
                TextProveedor.Text = tabla.Rows(0)(3).ToString
            End If
            If (tabla.Rows.Count >= 2) Then
                'producto 2
                Text_Id_Factura2.Text = tabla.Rows(1)(0).ToString
                Textrefac2.Text = tabla.Rows(1)(2).ToString
            End If
            If (tabla.Rows.Count >= 3) Then
                'producto 3 
                Text_Id_Factura3.Text = tabla.Rows(2)(0).ToString
                Textrefac3.Text = tabla.Rows(2)(2).ToString
            End If
            If (tabla.Rows.Count >= 4) Then
                'producto 4 
                Text_Id_Factura4.Text = tabla.Rows(3)(0).ToString
                Textrefac4.Text = tabla.Rows(3)(2).ToString
            End If
            If (tabla.Rows.Count >= 5) Then
                'producto 5
                Text_Id_Factura5.Text = tabla.Rows(4)(0).ToString
                Textrefac5.Text = tabla.Rows(4)(2).ToString
            End If
            If (tabla.Rows.Count >= 6) Then
                'producto 6
                Text_Id_Factura6.Text = tabla.Rows(5)(0).ToString
                Textrefac6.Text = tabla.Rows(5)(2).ToString
            End If
            If (tabla.Rows.Count >= 7) Then
                'producto 7
                Text_Id_Factura7.Text = tabla.Rows(6)(0).ToString
                Textrefac7.Text = tabla.Rows(6)(2).ToString
            End If
            If (tabla.Rows.Count >= 8) Then
                'producto 8
                Text_Id_Factura8.Text = tabla.Rows(7)(0).ToString
                Textrefac8.Text = tabla.Rows(7)(2).ToString
            End If
            If (tabla.Rows.Count >= 9) Then
                'producto 9
                Text_Id_Factura9.Text = tabla.Rows(8)(0).ToString
                Textrefac9.Text = tabla.Rows(8)(2).ToString
            End If
            If (tabla.Rows.Count >= 10) Then
                'producto 10
                Text_Id_Factura6.Text = tabla.Rows(9)(0).ToString
                Textrefac6.Text = tabla.Rows(9)(2).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_modificar_Click(sender As Object, e As EventArgs) Handles Btn_modificar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Modificar " + txtcodigo.Text, "Modificar Mantenimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Controlador
                Dim logica As New ClassMantenimientos

                logica.T_orden_servicio = Me.txtcodigo.Text
                logica.T_Fecha_os = Me.Fecha_os.Value
                logica.T_trasportes = Me.T_trasportes.Text
                logica.T_Fecha_Solicitud = Me.T_Fecha_Solicitud.Value
                logica.T_Fecha_Aplicacion = Me.T_Fecha_Aplicacion.Value
                logica.T_Fecha_Entrega_Estimada = Me.T_Fecha_Entrega_Estimada.Value
                logica.T_Kilometraje_Actual = Me.T_Kilometraje_Actual.Text
                logica.T_Fecha_Kilometraje = Me.T_Fecha_Kilometraje.Value
                logica.T_Tipo_de_Servicio = Me.T_Tipo_de_Servicio.Text
                logica.T_Prestador_del_Servicio = Me.T_Prestador_del_Servicio.Text
                logica.T_Descripcion_Mantenimiento = Me.T_Descripcion_Mantenimiento.Text
                logica.T_Sobre_Servicio = Me.T_Sobre_Servicio.Text
                logica.T_Servicio_Extraordinario = Me.T_Servicio_Extraordinario.Text
                logica.T_Descripcion_ServicioEX = Me.T_Descripcion_ServicioEX.Text
                logica.T_Refacciones = Me.T_Refacciones.Text
                logica.T_Reviciones_Programadas = Me.T_Reviciones_Programadas.Text
                logica.T_Programadas_fecha_reviciones = Me.Programadas_fecha_reviciones.Text
                logica.T_Observaciones_Generales = Me.T_Observaciones_Generales.Text
                logica.T_ProximoServicio = Me.T_ProximoServicio.Value
                logica.T_Recomendaciones = Me.T_Recomendaciones.Text
                logica.T_Recibio_Recomendaciones = Me.T_Recibio_Recomendaciones.Text
                logica.T_Costo_Refacciones = Me.T_Costo_Refacciones.Text
                logica.T_Costo_servicio = Me.T_Costo_servicio.Text
                logica.T_costo_traslado = Me.T_costo_traslado.Text
                logica.T_costo_total = Me.T_costo_total.Text
                logica.T_Autorizo = Me.T_Autorizo.Text
                logica.T_realizo_servicio = Me.T_realizo_servicio.Text
                logica.T_Chofer = Me.T_Chofer.Text
                logica.T_comprobantes = Me.Text_Url_Pdf.Text
                If funciones.FN_ModificarMantenimientos(logica) Then
                    MsgBox("Servicio Modificado Correctamente", MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            '---------------------------------------registro de tabla 1------------------------------------------------
            If (Textrefac1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac1.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura1.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then
                        'MsgBox("Refaccion 1 ok", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 2------------------------------------------------
            If (Textrefac2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac2.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura2.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


            '---------------------------------------registro de tabla 3------------------------------------------------
            If (Textrefac3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac3.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura3.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


            '---------------------------------------registro de tabla 4------------------------------------------------
            If (Textrefac4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac4.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura4.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 5------------------------------------------------
            If (Textrefac5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac5.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura5.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 5------------------------------------------------
            If (Textrefac6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac6.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura6.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 5------------------------------------------------
            If (Textrefac7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac7.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura7.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 8------------------------------------------------
            If (Textrefac8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac8.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura8.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 9 ------------------------------------------------
            If (Textrefac9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac9.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura9.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 10------------------------------------------------
            If (Textrefac10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Controlador
                    Dim logica As New ClassMantenimientos

                    logica.T_producto = Me.Textrefac10.Text
                    logica.T_nombre_proveedor_refacciones = Me.TextProveedor.Text
                    logica.T_id_refac = Me.Text_Id_Factura10.Text


                    If funciones.FN_Modificar_Refacciones(logica) Then

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


        End If
    End Sub

    '-------------------------------- Ventanita Agregar------------------------

    Private Sub btn_ventanita_close_Click(sender As Object, e As EventArgs) Handles btn_ventanita_close.Click
        PanelP_Servicio.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelP_Servicio.Visible = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Estas Seguro Que Quieres Agregar " + TextBox_Nombre.Text, "Nuevo Proveedor de Servicio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Controlador
                Dim logica As New ClassTrasportes

                logica.Tnombre_prestador = Me.TextBox_Nombre.Text
                logica.Tdireccion_prestador = Me.TextBox_Direccion.Text
                logica.Ttelefono_prestador = Me.TextBox_Telefono.Text
                logica.Temail_prestador = Me.TextBox_Email.Text

                If funciones.FN_InsertarP_Servicio(logica) Then
                    MsgBox("Agregado Correctamente", MessageBoxIcon.Information)
                    combo_Prestador_servicio()
                    TextBox_Nombre.Clear()
                    TextBox_Direccion.Clear()
                    TextBox_Telefono.Clear()
                    TextBox_Email.Clear()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


    End Sub

End Class