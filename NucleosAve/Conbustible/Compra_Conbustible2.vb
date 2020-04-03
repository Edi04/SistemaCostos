Imports System.Data.SqlClient
Public Class Compra_Conbustible2
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    Private Sub Compra_Conbustible2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generar_Codigo_Combustimble()
    End Sub
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
    '-----------------------------------------trmina botonera------------------------------
    '----------------------------------------------------------------------------------------------------------------------------------
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Agregar Mas Combustible", "Mas Combustible", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Conbustible
                Dim logica As New ClassConbustible

                logica.Con_codigo = Me.codigo_combus.Text
                logica.Con_trasporte = Me.TextBox_trasport.Text
                logica.Con_chofer = Me.TextBox_chofer.Text
                logica.Con_gasolinera = Me.TextBox_gasolinera.Text
                logica.Con_fecha = Me.DateTimeFecha.Value
                logica.Con_litros = Me.TextBox_Litros.Text
                logica.Con_precio = Me.TextBox_Precio.Text
                logica.Con_total = Me.TextBox_total.Text
                logica.Con_tipo = Me.ComboBox_Tipo.Text
                logica.Con_comprobante = Me.texturl_def.Text
                logica.Con_responsable = Me.TextBox_Responsable.Text

                logica.Con_area = Me.ComboBox_Area.Text
                logica.Con_cantidad_cuenta = Me.TextBox_cuanto_tiene.Text
                logica.Con_quien_porta_unidad = Me.TextBox_quienlotrae.Text
                logica.Con_numero_vale = Me.TextBox_numero_vale.Text
                logica.Con_mpn = Me.ComboBox_mpn.Text

                If funciones.FN_InsertarConbustible2(logica) Then
                    MsgBox("Combustible Agregado Correctamente", MessageBoxIcon.Information)
                    Generar_Codigo_Combustimble()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    '----------------------------------------------------------------------------------------------------------------------------------
    Public Sub SumarTotales() Handles TextBox_Precio.TextChanged, TextBox_Litros.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextBox_Precio.Text <> Nothing Then
            cu1 = CDec(TextBox_Precio.Text)
        End If

        If TextBox_Litros.Text <> Nothing Then
            cu2 = CDec(TextBox_Litros.Text)
        End If
        TextBox_total.Text = FormatCurrency(cu1 * cu2).ToString
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------
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
            MsgBox("Solo se puede ingresar numeros y punto", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub TextBox_Litros_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextBox_Litros.KeyPress
        NumerosyDecimal(TextBox_Litros, com)
    End Sub

    Private Sub TextBox_Precio_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextBox_Precio.KeyPress
        NumerosyDecimal(TextBox_Precio, com)
    End Sub

    Private Sub SumarTotales(sender As Object, e As EventArgs) Handles TextBox_Precio.TextChanged, TextBox_Litros.TextChanged

    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub btn_comprobante_Click(sender As Object, e As EventArgs) Handles btn_comprobante.Click
        Try
            Dim cancelado As Boolean = False
            Dim openFD As New OpenFileDialog()
            With openFD
                .Title = "Comprobante"
                .Filter = "Documento Digital (*.pdf)|*.pdf"
                .Multiselect = False
                '.InitialDirectory = My.Computer.FileSystem.CurrentDirectory //abrir en carpeta de ejecucion del programa
                .InitialDirectory = "c:\"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    texturl.Text = IO.Path.GetFileName(.FileName)
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Comprobantes_Combustible\Compras_Individuales"
                    Dim fichero As New System.IO.FileInfo(pathDefinitivo & "\" & texturl.Text)
                    texturl_def.Text = pathDefinitivo & "\" & texturl.Text
                    If fichero.Exists Then
                        If MessageBox.Show("El archivo seleccionado ya está incluido" & ControlChars.NewLine & "¿Desea sobreescribirlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            cancelado = True
                            texturl_def.Clear()
                        Else
                            System.IO.File.Delete(fichero.FullName)
                        End If
                    End If
                    If Not cancelado Then
                        System.IO.File.Copy(.FileName, fichero.FullName)
                        MsgBox("Archivo Almacenado Correctamente", MessageBoxIcon.Exclamation)
                    End If

                Else
                    texturl_def.Clear()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Warning)
        End Try
    End Sub



    '--------------------------------Generar codigo combustible-------------------------
    Sub Generar_Codigo_Combustimble()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_con)from TB_Combustible_Compra_Individual", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        codigo_combus.Text = "CombxT-" + Format(id + 1, "0000") + "/20"
    End Sub

    '-----------------------------------------------------------------------------------------

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        TextBox_trasport.Clear()
        TextBox_chofer.Clear()
        TextBox_gasolinera.Clear()
        TextBox_Litros.Clear()
        TextBox_Precio.Clear()
        TextBox_total.Clear()
        TextBox_Responsable.Clear()
        texturl.Clear()
        texturl_def.Clear()
        TextBox_cuanto_tiene.Clear()
        TextBox_quienlotrae.Clear()
        TextBox_numero_vale.Clear()
        Generar_Codigo_Combustimble()
    End Sub



    Private Sub btnComprobante_Click(sender As Object, e As EventArgs)
        Try
            Dim cancelado As Boolean = False
            Dim openFD As New OpenFileDialog()
            With openFD
                .Title = "Comprobante"
                .Filter = "Documento Digital (*.pdf)|*.pdf"
                .Multiselect = False
                '.InitialDirectory = My.Computer.FileSystem.CurrentDirectory //abrir en carpeta de ejecucion del programa
                .InitialDirectory = "c:\"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    texturl.Text = IO.Path.GetFileName(.FileName)
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Comprobantes_Combustible\Compras_Individuales"
                    Dim fichero As New System.IO.FileInfo(pathDefinitivo & "\" & texturl.Text)
                    texturl_def.Text = pathDefinitivo & "\" & texturl.Text
                    If fichero.Exists Then
                        If MessageBox.Show("El archivo seleccionado ya está incluido" & ControlChars.NewLine & "¿Desea sobreescribirlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            cancelado = True
                            texturl_def.Clear()
                        Else
                            System.IO.File.Delete(fichero.FullName)
                        End If
                    End If
                    If Not cancelado Then
                        System.IO.File.Copy(.FileName, fichero.FullName)
                        MsgBox("Archivo Almacenado Correctamente", MessageBoxIcon.Exclamation)
                    End If

                Else
                    texturl_def.Clear()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btn_buscar_v_Click(sender As Object, e As EventArgs)
        AltaTrasportes.Show()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        AltaTrasportes.Show()
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------

End Class