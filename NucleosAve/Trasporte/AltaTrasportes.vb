Imports System.Data.SqlClient
Public Class AltaTrasportes
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

    Private Sub AltaTrasportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MostrarTrasportes.TB_Trasportes' Puede moverla o quitarla según sea necesario.
        Me.TB_TrasportesTableAdapter.Fill(Me.MostrarTrasportes.TB_Trasportes)
        combo_Marca()
        GenerarCodigo()
        MostrarRegTodos()
    End Sub

    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub


    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Sub combo_Marca() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_MTrasportes", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 6 --------------
        ComboMarca.DataSource = tabla
        ComboMarca.DisplayMember = "marca"
        ComboMarca.ValueMember = "Id"
    End Sub
    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Sub GenerarCodigo()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_trasporte)from TB_Trasportes", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        codigotrasport.Text = "Trasport-" + Format(id + 1, "0000") + "/20"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::------------Alta Trasportes--------::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Private Sub BtnGuardarFac_Click(sender As Object, e As EventArgs) Handles BtnGuardarFac.Click
        If MessageBox.Show("Estas Seguro Que Quieres Agregar " + TextModelo.Text, "Nuevo Trasporte", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Controlador
                Dim logica As New ClassTrasportes

                logica.T_marca = Me.ComboMarca.Text
                logica.T_modelo = Me.TextModelo.Text
                logica.T_tipo = Me.TextTipo.Text
                logica.T_Ano = Me.TextAno.Text
                logica.T_n_serie = Me.TextNserie.Text
                logica.T_placas = Me.TextPlacas.Text
                logica.T_n_seguro = Me.TextNseguro.Text
                logica.T_vigencia = Me.DateTimePicker1.Value
                logica.T_codigo = Me.codigotrasport.Text
                '---------------------------------------------------
                logica.T_cargaKg = Me.txtCargaKG.Text
                logica.T_Tasa_Depreciacion = Me.Textdepreciacion.Text
                logica.T_Fecha_Adqui = Me.DateTimePicker2.Value
                logica.T_MO_de_Inversio = Me.TextMoInversion.Text
                logica.T_PN_Deducible = Me.TextPnDeducible.Text
                logica.T_MO_MaxDed = Me.TextMoMaxDed.Text
                logica.T_M_D_Acumulada = Me.TextMdAcumu.Text
                logica.T_M_C_de_uso_C_Dep = Me.TextM_CDEp.Text
                logica.T_D_Acumulada = Me.TextDAcumulada.Text
                logica.T_Monto_Actual_Del_Activo = Me.TextMAACtivo.Text
                logica.T_oc = Me.TextOC.Text
                logica.Tfactura_trasporte = Me.Text_Url_Pdf.Text
                logica.Tfactura_trasporte2 = Me.Text_Url_Xml.Text


                If funciones.FN_InsertarTrasporte(logica) Then
                    MsgBox("Camion Agregado Correctamente", MessageBoxIcon.Information)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '----------------------------limpiar Cajas ---------------------------------
            'TextPurchase.Clear()

        End If

        TextModelo.Clear()
        TextTipo.Clear()
        TextAno.Clear()
        TextNserie.Clear()
        TextPlacas.Clear()
        TextNseguro.Clear()
        '---------------------------------------------------
        txtCargaKG.Clear()
        Textdepreciacion.Clear()
        TextMoInversion.Clear()
        TextPnDeducible.Clear()
        TextMoMaxDed.Clear()
        TextMdAcumu.Clear()
        TextM_CDEp.Clear()
        TextDAcumulada.Clear()
        TextMAACtivo.Clear()
        TextOC.Clear()
        GenerarCodigo()
        MostrarRegTodos()

        Text_Url_Pdf.Clear()
        Text_Url_Xml.Clear()
    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::------------ FIn Alta Trasportes--------:::::::::::::::::::::::::::::::::::::::::::::::::::::

    '::::::::::::::::::::::::::::::::::::::::----------------------Validaciones Alta Trasportes----------------::::::::::::::::::::::::::::::::::::::::::::::::::::
    '<<<-----------------------Funcion Usada por las validaciones <<<<<<<<<<<<<<<<<<<<<<<<<
    'Funcion para que solo permite el ingreso de caracteres tipo numerico
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

    Private Sub Textdepreciacion_KeyPress(sender As Object, com As KeyPressEventArgs) Handles Textdepreciacion.KeyPress
        NumerosyDecimal(Textdepreciacion, com)
    End Sub
    Private Sub TextMoInversion_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextMoInversion.KeyPress
        NumerosyDecimal(TextMoInversion, com)
    End Sub
    Private Sub TextPnDeducible_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextPnDeducible.KeyPress
        NumerosyDecimal(TextPnDeducible, com)
    End Sub
    Private Sub TextMoMaxDed_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextMoMaxDed.KeyPress
        NumerosyDecimal(TextMoMaxDed, com)
    End Sub
    Private Sub TextMdAcumu_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextMdAcumu.KeyPress
        NumerosyDecimal(TextMdAcumu, com)
    End Sub
    Private Sub TextM_CDEp_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextM_CDEp.KeyPress
        NumerosyDecimal(TextM_CDEp, com)
    End Sub
    Private Sub TextDAcumulada_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextDAcumulada.KeyPress
        NumerosyDecimal(TextDAcumulada, com)
    End Sub
    Private Sub TextMAACtivo_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextMAACtivo.KeyPress
        NumerosyDecimal(TextMAACtivo, com)
    End Sub



    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    '____________::::::::::::::::::::Cargar Registors Data Grid________________::::::::::::::::::::::::::::::::


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarRegOrdC()
    End Sub

    Sub MostrarRegOrdC()
        Try
            Dim Func As New Funcion_Controlador
            tabla = Func.FnMostrarTrasportes
            If tabla.Rows.Count <> 0 Then
                DataGridViewtrasport.DataSource = tabla
            Else
                DataGridViewtrasport.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Todos_Click(sender As Object, e As EventArgs) Handles btn_Todos.Click
        MostrarRegTodos()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Sub MostrarRegTodos()
        Try
            Dim Func As New Funcion_Controlador
            tabla = Func.FnMostrarTrasportesTodos
            If tabla.Rows.Count <> 0 Then
                DataGridViewtrasport.DataSource = tabla
            Else
                DataGridViewtrasport.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        'RegistrosOrdCom.ShowDialog()
        facturasRegis.ShowDialog()
    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Private Sub DataGridViewtrasport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewtrasport.CellClick
        Try
            TextModelo.Clear()
            TextTipo.Clear()
            TextAno.Clear()
            TextNserie.Clear()
            TextPlacas.Clear()
            TextNseguro.Clear()
            '---------------------------------------------------
            txtCargaKG.Clear()
            Textdepreciacion.Clear()
            TextMoInversion.Clear()
            TextPnDeducible.Clear()
            TextMoMaxDed.Clear()
            TextMdAcumu.Clear()
            TextM_CDEp.Clear()
            TextDAcumulada.Clear()
            TextMAACtivo.Clear()
            TextOC.Clear()
            '------codigo para mantenimientosd
            ServiciosMantenimiento.T_trasportes.Text = DataGridViewtrasport.CurrentRow.Cells(0).Value
            '----------------------------------codigo para fletes entregas
            Fletes_y_Entregas.TextBox_vehiculo.Text = DataGridViewtrasport.CurrentRow.Cells(0).Value
            '------------------------------------------------
            Reparticion_gasolina.TextBox_trasporte.Text = DataGridViewtrasport.CurrentRow.Cells(0).Value
            Compra_Conbustible2.TextBox_trasport.Text = DataGridViewtrasport.CurrentRow.Cells(0).Value
            '------------------------------------------------
            codigotrasport.Text = DataGridViewtrasport.CurrentRow.Cells(0).Value
            ComboMarca.Text = DataGridViewtrasport.CurrentRow.Cells(1).Value
            TextModelo.Text = DataGridViewtrasport.CurrentRow.Cells(2).Value
            TextNserie.Text = DataGridViewtrasport.CurrentRow.Cells(3).Value
            TextTipo.Text = DataGridViewtrasport.CurrentRow.Cells(4).Value
            TextAno.Text = DataGridViewtrasport.CurrentRow.Cells(5).Value
            TextPlacas.Text = DataGridViewtrasport.CurrentRow.Cells(6).Value
            TextNseguro.Text = DataGridViewtrasport.CurrentRow.Cells(7).Value
            DateTimePicker1.Text = DataGridViewtrasport.CurrentRow.Cells(8).Value
            txtCargaKG.Text = DataGridViewtrasport.CurrentRow.Cells(9).Value
            Textdepreciacion.Text = DataGridViewtrasport.CurrentRow.Cells(10).Value
            DateTimePicker2.Text = DataGridViewtrasport.CurrentRow.Cells(11).Value
            TextMoInversion.Text = DataGridViewtrasport.CurrentRow.Cells(12).Value
            TextPnDeducible.Text = DataGridViewtrasport.CurrentRow.Cells(13).Value
            TextMoMaxDed.Text = DataGridViewtrasport.CurrentRow.Cells(14).Value
            TextMdAcumu.Text = DataGridViewtrasport.CurrentRow.Cells(15).Value
            TextM_CDEp.Text = DataGridViewtrasport.CurrentRow.Cells(16).Value
            TextDAcumulada.Text = DataGridViewtrasport.CurrentRow.Cells(17).Value
            TextMAACtivo.Text = DataGridViewtrasport.CurrentRow.Cells(18).Value
            TextOC.Text = DataGridViewtrasport.CurrentRow.Cells(20).Value
            Text_Url_Pdf.Text = DataGridViewtrasport.CurrentRow.Cells(21).Value
            Text_Url_Xml.Text = DataGridViewtrasport.CurrentRow.Cells(22).Value
            BtnGuardarFac.Visible = False
            btn_modificar.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Modificar " + TextModelo.Text, "Modificar Trasporte", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Controlador
                Dim logica As New ClassTrasportes

                logica.T_marca = Me.ComboMarca.Text
                logica.T_modelo = Me.TextModelo.Text
                logica.T_tipo = Me.TextTipo.Text
                logica.T_Ano = Me.TextAno.Text
                logica.T_n_serie = Me.TextNserie.Text
                logica.T_placas = Me.TextPlacas.Text
                logica.T_n_seguro = Me.TextNseguro.Text
                logica.T_vigencia = Me.DateTimePicker1.Value
                logica.T_codigo = Me.codigotrasport.Text
                '---------------------------------------------------
                logica.T_cargaKg = Me.txtCargaKG.Text
                logica.T_Tasa_Depreciacion = Me.Textdepreciacion.Text
                logica.T_Fecha_Adqui = Me.DateTimePicker2.Value
                logica.T_MO_de_Inversio = Me.TextMoInversion.Text
                logica.T_PN_Deducible = Me.TextPnDeducible.Text
                logica.T_MO_MaxDed = Me.TextMoMaxDed.Text
                logica.T_M_D_Acumulada = Me.TextMdAcumu.Text
                logica.T_M_C_de_uso_C_Dep = Me.TextM_CDEp.Text
                logica.T_D_Acumulada = Me.TextDAcumulada.Text
                logica.T_Monto_Actual_Del_Activo = Me.TextMAACtivo.Text
                logica.T_oc = Me.TextOC.Text
                logica.Tfactura_trasporte = Me.Text_Url_Pdf.Text
                logica.Tfactura_trasporte2 = Me.Text_Url_Xml.Text



                If funciones.FN_ModificarTrasporte(logica) Then
                    MsgBox("Camion Modificado Correctamente", MessageBoxIcon.Information)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '----------------------------limpiar Cajas ---------------------------------
            'TextPurchase.Clear()

        End If

        TextModelo.Clear()
        TextTipo.Clear()
        TextAno.Clear()
        TextNserie.Clear()
        TextPlacas.Clear()
        TextNseguro.Clear()
        '---------------------------------------------------
        txtCargaKG.Clear()
        Textdepreciacion.Clear()
        TextMoInversion.Clear()
        TextPnDeducible.Clear()
        TextMoMaxDed.Clear()
        TextMdAcumu.Clear()
        TextM_CDEp.Clear()
        TextDAcumulada.Clear()
        TextMAACtivo.Clear()
        TextOC.Clear()
        GenerarCodigo()
        MostrarRegTodos()
    End Sub




    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        btn_modificar.Visible = False
        BtnGuardarFac.Visible = True
        TextModelo.Clear()
        TextTipo.Clear()
        TextAno.Clear()
        TextNserie.Clear()
        TextPlacas.Clear()
        TextNseguro.Clear()
        '---------------------------------------------------
        txtCargaKG.Clear()
        Textdepreciacion.Clear()
        TextMoInversion.Clear()
        TextPnDeducible.Clear()
        TextMoMaxDed.Clear()
        TextMdAcumu.Clear()
        TextM_CDEp.Clear()
        TextDAcumulada.Clear()
        TextMAACtivo.Clear()
        TextOC.Clear()
        GenerarCodigo()
        MostrarRegTodos()
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
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Facturas_Trasportes\PDF"
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

    Private Sub btn_xml_Click(sender As Object, e As EventArgs) Handles btn_xml.Click
        Try
            Dim cancelado As Boolean = False
            Dim openFD As New OpenFileDialog()
            With openFD
                .Title = "Factura XML"
                .Filter = "Factura Digital (*.xml)|*.xml"
                .Multiselect = False
                '.InitialDirectory = My.Computer.FileSystem.CurrentDirectory //abrir en carpeta de ejecucion del programa
                .InitialDirectory = "c:\"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    text_xml.Text = IO.Path.GetFileName(.FileName)
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Facturas_Trasportes\XML"
                    Dim fichero As New System.IO.FileInfo(pathDefinitivo & "\" & text_xml.Text)
                    Text_Url_Xml.Text = pathDefinitivo & "\" & text_xml.Text
                    If fichero.Exists Then
                        If MessageBox.Show("El archivo seleccionado ya está incluido" & ControlChars.NewLine & "¿Desea sobreescribirlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            cancelado = True
                            Text_Url_Xml.Clear()
                        Else
                            System.IO.File.Delete(fichero.FullName)
                        End If
                    End If
                    If Not cancelado Then
                        System.IO.File.Copy(.FileName, fichero.FullName)
                        MsgBox("Archivo Almacenado Correctamente", MessageBoxIcon.Exclamation)
                    End If
                Else
                    Text_Url_Xml.Clear()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PanelP_Servicio.Visible = False
    End Sub
    Private Sub Btn_nueva_marca_Click(sender As Object, e As EventArgs) Handles Btn_nueva_marca.Click
        PanelP_Servicio.Visible = True
    End Sub


    Private Sub Btn_guardarmarca_Click(sender As Object, e As EventArgs) Handles Btn_guardarmarca.Click
        If MessageBox.Show("Estas Seguro Que Quieres Agregar " + TextBox_marca.Text, "Nueva Marca", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Controlador
                Dim logica As New ClassTrasportes

                logica.Tmarca_nueva = Me.TextBox_marca.Text

                If funciones.FN_Insertar_NMarca(logica) Then
                    MsgBox("Agregado Correctamente", MessageBoxIcon.Information)
                    combo_Marca()
                    TextBox_marca.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class