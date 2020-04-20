Imports System.Data.SqlClient
Public Class Ventas
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generarcodigo()
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

    Private Sub BtnGuardarFac_Click(sender As Object, e As EventArgs) Handles BtnGuardarFac.Click
        If MessageBox.Show("Estas Seguro Que Quieres agregar nuevo registro", "Nueva Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Fuction_Ventas
                Dim logica As New ClassVentas

                logica.Vfactura = Me.TextBox_Factura.Text
                logica.Vtotal = Me.TextBox_total.Text
                logica.Vestatus = Me.TextBox_estatus.Text
                logica.Vfecha = Me.DateTimePicker_fecha.Text
                logica.Vfacturapdf = Me.Text_Url_Pdf.Text
                logica.Vcodigo = Me.TextBox_codigo_general.Text

                If funciones.FN_InsertarVenta(logica) Then
                    MsgBox("Datos Insertados Correctamente", MessageBoxIcon.Information)
                    Generarcodigo()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
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
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Facturas Ventas"
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

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        factura.Show()
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        limpiar()
        BtnGuardarFac.Enabled = True
        Generarcodigo()
        btn_modificar.Enabled = False
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Modificar Este Registro", "Modificacion Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Fuction_Ventas
                Dim logica As New ClassVentas

                logica.Vfactura = Me.TextBox_Factura.Text
                logica.Vtotal = Me.TextBox_total.Text
                logica.Vestatus = Me.TextBox_estatus.Text
                logica.Vfecha = Me.DateTimePicker_fecha.Text
                logica.Vfacturapdf = Me.Text_Url_Pdf.Text
                logica.Vcodigo = Me.TextBox_codigo_general.Text
                logica.Vid = Me.TextBox_id.Text

                If funciones.FN_ModificarVenta(logica) Then
                    MsgBox("Datos Modificados Correctamente", MessageBoxIcon.Information)
                    Generarcodigo()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_regis_Click(sender As Object, e As EventArgs) Handles btn_regis.Click
        Registros_Ventas.Show()
    End Sub

    Sub limpiar()
        TextBox_codigo_general.Clear()
        TextBox_Factura.Clear()
        TextBox_total.Clear()
        TextBox_estatus.Clear()
        Text_Url_Pdf.Clear()
        textpdf.Clear()
    End Sub

    Sub Generarcodigo()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_venta)from TB_Ventas", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        TextBox_codigo_general.Text = "VENT-" + Format(id + 1, "0000") + "/20"
    End Sub
End Class