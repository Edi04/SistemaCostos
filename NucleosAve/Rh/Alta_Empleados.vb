Imports System.Data.SqlClient
Public Class Alta_Empleados
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    Private Sub Alta_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------
    Private Sub BtnGuardar_Empleado_Click(sender As Object, e As EventArgs) Handles BtnGuardar_Empleado.Click
        If MessageBox.Show("Estas Seguro Que Quieres agregar nuevo registro", "Nuevo Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New FuncionRh
                Dim logica As New ClassEmpleados

                logica.RH_Numero_Nomina = Me.TextBox_numero_nomina.Text
                logica.RH_Nombre_Empleado = Me.TextBox_nombre_empleado.Text
                logica.RH_Ape_Paterno = Me.TextBox_apellido.Text
                logica.RH_Ape_Materno = Me.TextBox_apellido_materno.Text
                logica.RH_NSS = Me.TextBox_nss.Text
                logica.RH_RFC = Me.TextBox_rfc.Text
                logica.RH_NAcionalidad = Me.TextBox_nacionalidad.Text
                logica.RH_Area = Me.TextBox_area.Text
                logica.RH_Estudios = Me.TextBox_estudios.Text
                logica.RH_correo = Me.TextBox_correo.Text
                logica.RH_telefono = Me.TextBox_telefono.Text
                logica.RH_telefono2 = Me.TextBox_telefono2.Text
                logica.RH_direccion = Me.TextBox_direccionE.Text
                logica.RH_perfil = Me.TextBox_perfil.Text
                logica.RH_alergis = Me.TextBox_alergias_enfermedades.Text
                logica.RH_fecha_nacimiento = Me.DateTime_fecha_nacimiento.Text
                logica.RH_edad = Me.TextBox_edad.Text
                logica.RH_estado_civil = Me.TextBox_estado_civil.Text
                logica.RH_NOmbre_Familiar = Me.TextBox_nombre_familiar.Text
                logica.RH_telefono_fam = Me.TextBox_telefono_familiar.Text
                logica.RH_direccion_fam = Me.TextBox_direccionFam.Text
                logica.RH_fotografia = Me.Text_Url_img.Text
                logica.RH_fecha_ingreso = Me.DateTime_fecha_ingreso.Text

                If funciones.FN_InsertarEmpleados(logica) Then
                    MsgBox("Datos Insertados Correctamente", MessageBoxIcon.Information)
                    Rh.combo_empleado()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        limpiar()
    End Sub

    Private Sub btn_buscar_empleados_Click(sender As Object, e As EventArgs) Handles btn_buscar_empleados.Click
        Busquedas_Empleados.Show()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Modificar este registro", "Modificar Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New FuncionRh
                Dim logica As New ClassEmpleados

                logica.RH_Numero_Nomina = Me.TextBox_numero_nomina.Text
                logica.RH_Nombre_Empleado = Me.TextBox_nombre_empleado.Text
                logica.RH_Ape_Paterno = Me.TextBox_apellido.Text
                logica.RH_Ape_Materno = Me.TextBox_apellido_materno.Text
                logica.RH_NSS = Me.TextBox_nss.Text
                logica.RH_RFC = Me.TextBox_rfc.Text
                logica.RH_NAcionalidad = Me.TextBox_nacionalidad.Text
                logica.RH_Area = Me.TextBox_area.Text
                logica.RH_Estudios = Me.TextBox_estudios.Text
                logica.RH_correo = Me.TextBox_correo.Text
                logica.RH_telefono = Me.TextBox_telefono.Text
                logica.RH_telefono2 = Me.TextBox_telefono2.Text
                logica.RH_direccion = Me.TextBox_direccionE.Text
                logica.RH_perfil = Me.TextBox_perfil.Text
                logica.RH_alergis = Me.TextBox_alergias_enfermedades.Text
                logica.RH_fecha_nacimiento = Me.DateTime_fecha_nacimiento.Text
                logica.RH_edad = Me.TextBox_edad.Text
                logica.RH_estado_civil = Me.TextBox_estado_civil.Text
                logica.RH_NOmbre_Familiar = Me.TextBox_nombre_familiar.Text
                logica.RH_telefono_fam = Me.TextBox_telefono_familiar.Text
                logica.RH_direccion_fam = Me.TextBox_direccionFam.Text
                logica.RH_fotografia = Me.Text_Url_img.Text
                logica.RH_fecha_ingreso = Me.DateTime_fecha_ingreso.Text
                logica.RH_id_empleado = Me.TextBox_id.Text

                If funciones.FN_MOdificarEmpleados(logica) Then
                    MsgBox("Datos Modificados Correctamente", MessageBoxIcon.Information)
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_foto_Click(sender As Object, e As EventArgs) Handles btn_foto.Click
        Try
            Dim cancelado As Boolean = False
            Dim openFD As New OpenFileDialog()
            With openFD
                .Title = "Fotografia del Empleado"
                .Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
                .Multiselect = False
                '.InitialDirectory = My.Computer.FileSystem.CurrentDirectory //abrir en carpeta de ejecucion del programa
                .InitialDirectory = "c:\"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    text_img.Text = IO.Path.GetFileName(.FileName)
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Fotos_Empleados"
                    Dim fichero As New System.IO.FileInfo(pathDefinitivo & "\" & text_img.Text)
                    Text_Url_img.Text = pathDefinitivo & "\" & text_img.Text
                    If fichero.Exists Then
                        If MessageBox.Show("El archivo seleccionado ya está incluido" & ControlChars.NewLine & "¿Desea sobreescribirlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            cancelado = True
                            Text_Url_img.Clear()
                        Else
                            System.IO.File.Delete(fichero.FullName)
                        End If
                    End If
                    If Not cancelado Then
                        System.IO.File.Copy(.FileName, fichero.FullName)
                        MsgBox("Archivo Almacenado Correctamente", MessageBoxIcon.Exclamation)
                    End If

                Else

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Warning)
        End Try
    End Sub

    Sub limpiar()
        TextBox_numero_nomina.Clear()
        TextBox_nombre_empleado.Clear()
        TextBox_apellido.Clear()
        TextBox_apellido_materno.Clear()
        TextBox_nss.Clear()
        TextBox_rfc.Clear()
        TextBox_nacionalidad.Clear()
        TextBox_area.Clear()
        TextBox_estudios.Clear()
        TextBox_correo.Clear()
        TextBox_telefono.Clear()
        TextBox_telefono2.Clear()
        TextBox_direccionE.Clear()
        TextBox_perfil.Clear()
        TextBox_alergias_enfermedades.Clear()
        TextBox_edad.Clear()
        TextBox_estado_civil.Clear()
        Text_Url_img.Clear()
        text_img.Clear()
        TextBox_nombre_familiar.Clear()
        TextBox_telefono_familiar.Clear()
        TextBox_direccionFam.Clear()
        BtnGuardar_Empleado.Enabled = True
        btn_modificar.Enabled = False
    End Sub
End Class