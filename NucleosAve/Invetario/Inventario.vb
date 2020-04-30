Imports System.Data.SqlClient

Public Class Inventario
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    'Tipo de Cambio con SAT
    Dim HSAT As WebBrowser 'Actual
    Dim MSAT As WebBrowser  'Modificado

    'ComboBoxs
    Dim UMedida As New SqlCommand
    Dim DTUMedida As DataTable
    Dim DAUMedida As New SqlDataAdapter

    Dim Marca As New SqlCommand
    Dim DTMarca As DataTable
    Dim DAMarca As New SqlDataAdapter

    Dim Area As New SqlCommand
    Dim DTArea As DataTable
    Dim DAArea As New SqlDataAdapter

    Dim Proceso As New SqlCommand
    Dim DTProceso As DataTable
    Dim DAProceso As New SqlDataAdapter

    Dim Categoria As New SqlCommand
    Dim DTCategoria As DataTable
    Dim DACategoria As New SqlDataAdapter

    Private WithEvents Trabajador As New System.ComponentModel.BackgroundWorker
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosGV()
        FechaActual()
        Consultas()
        Nombres()

        If TxtBusqueda.Text <> "" Then
            BuscarDatos()
        End If
    End Sub


    'Botones
    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        If Tickets.DatosDG.Item(0, 0).Value <> Nothing Then
            Close()
            Tickets.Impresion_Click(sender, e)
        Else
            Close()
            Tickets.Close()
        End If
    End Sub

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    '   Agregar Existencia
    Private Sub BAgregarExistencia_Click(sender As Object, e As EventArgs) Handles BAgregarExistencia.Click
        If Tickets.LCS.Text <> Nothing Then
            LCS.Text = Tickets.LCS.Text
        Else
            'Crear Código
            Dim Fecha = DateTime.Now.ToString("yy")
            Dim cmd As New SqlCommand("SELECT Id_S
                                       FROM TB_CodigS
                                       ORDER BY Id_S DESC", Conex)
            Dim strCodigo As String

            Conex.Open()
            strCodigo = cmd.ExecuteScalar
            Conex.Close()

            Dim Id As Integer = CType(strCodigo.Substring(0), Integer)

            LCS.Text = "CSA-" + Format(Id + 1, "0000") + "/" + Fecha 'Inventario
            Tickets.LCS.Text = "CSA-" + Format(Id + 1, "0000") + "/" + Fecha 'Tickets

            'Insertar Código
            If Tickets.LCS.Text <> Nothing Then
                Dim CodS As String = LCS.Text
                Dim Emple As String = LUsuario.Text

                Conex.Open()
                Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodS FROM TB_CodigS WHERE CodS = '" & CodS & "')
		                                    INSERT INTO TB_CodigS (CodS, Created)
                                                           VALUES ( '" & CodS & "', SYSDATETIME())"
                Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                COMANDO.ExecuteNonQuery()
                Conex.Close()
            End If
        End If

        '/////
        AgregarExistencias.Visible = True
        LErrEP.Visible = False
        Tickets.Show()
        DatosB()
    End Sub

    '   Calendario-Nueva Existencia
    Private Sub PCalendario_Click(sender As Object, e As EventArgs) Handles PCalendario.Click
        If DTTipoCambio.Visible = False Then
            DTTipoCambio.Visible = True
        Else
            If DTTipoCambio.Visible = True Then
                DTTipoCambio.Visible = False
            End If
        End If
    End Sub

    '   NExistencia
    Private Sub BGExistencia_Click(sender As Object, e As EventArgs) Handles BGExistencia.Click
        If TxtNExistencia.Text = Nothing Then
            MessageBox.Show("Ingresar Cantidad", "Advertencia", MessageBoxButtons.OK)
        Else
            If MsgBox("La cantidad a Ingresar es: " & TxtNExistencia.Text, vbYesNo) = vbYes Then
                Datos()
                CargaInfpRO()
            End If
        End If
    End Sub

    '   Modificar
    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        TxtCB.Text = ""
        AModif()
        BInvisiblesCRUD()
        AgregarExistencias.Visible = False
        BOrdenC.Visible = False
    End Sub

    '   Guardar Modificación
    Private Sub BGuardarMo_Click(sender As Object, e As EventArgs) Handles BGuardarMo.Click
        If (CMedida.SelectedValue = Nothing) Or (CMedida.SelectedValue = 7) Or (CMarca.SelectedValue = Nothing) Or
           (CCategoria.SelectedValue = Nothing) Or (CCategoria.SelectedValue = 7) Then
            MessageBox.Show("Seleccione los Datos", "Advertencia", MessageBoxButtons.OK)
        ElseIf CArea.SelectedValue = Nothing Then
            If MsgBox("Desea Modificar la Información del Producto " & TxtNombreP.Text, vbYesNo) = vbYes Then
                CArea.SelectedValue = 35
                Modifi()
                CargaInfpRO()
                BOrdenC.Visible = True
            End If

        ElseIf CProceso.SelectedValue = Nothing Then
            If MsgBox("Desea Modificar la Información del Producto " & TxtNombreP.Text, vbYesNo) = vbYes Then
                CProceso.SelectedValue = 49
                Modifi()
                CargaInfpRO()
                BOrdenC.Visible = True
            End If
        Else
            If MsgBox("Desea Modificar la Información del Producto " & TxtNombreP.Text, vbYesNo) = vbYes Then
                Modifi()
                BOrdenC.Visible = True
            End If
        End If
    End Sub

    '   Retorno
    Private Sub BRetorno_Click(sender As Object, e As EventArgs) Handles BRetorno.Click
        CargaInfpRO()
        BVisiblesCRUD()
        DModif()
        BOrdenC.Visible = True
    End Sub

    '   Eliminar
    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If MsgBox("Desea Eliminar el Producto " & TxtNombreP.Text, vbYesNo) = vbYes Then
            Eliminar()
            AgregarExistencias.Visible = False
        End If
    End Sub

    '   Detalles Productos
    Private Sub BMostrarHist_Click(sender As Object, e As EventArgs) Handles BMostrarHist.Click
        DetalleProductos.Producto.Text = Me.TxtNombreP.Text
        DetalleProductos.IDP.Text = Me.IDP.Text

        DetalleProductos.Show()
        Me.Hide()
    End Sub

    '   Nuevo Producto
    Private Sub BNuevoProducto_Click(sender As Object, e As EventArgs) Handles BNuevoProducto.Click
        NuevoProducto.Show()
        Me.Close()
    End Sub

    '   Código Barras
    Private Sub PCodigoBarras_Click(sender As Object, e As EventArgs) Handles PCodigoBarras.Click
        If (CMedida.SelectedValue = Nothing) Or (CMedida.SelectedValue = 7) Or (CMarca.SelectedValue = Nothing) Or
           (CCategoria.SelectedValue = Nothing) Or (CCategoria.SelectedValue = 7) Then
            MessageBox.Show("Seleccione los Datos", "Advertencia", MessageBoxButtons.OK)
        Else
            CodigoB()
        End If
    End Sub

    '   Orden Compra
    Private Sub BOrdenC_Click(sender As Object, e As EventArgs) Handles BOrdenC.Click
        Dim OrdenC As New ODC()
        OrdenC.Show()

        Close()
    End Sub

    '   Imagen
    Dim Picture As New OpenFileDialog()
    Private Sub BImagen_Click(sender As Object, e As EventArgs) Handles BImagen.Click
        Dim D = DateTime.Now.ToString("dd-MM-yyyy")

        Picture.Filter = "Archivo JPG|*.jpg"
        If Picture.ShowDialog() = DialogResult.OK Then
            Imagen.Image = Image.FromFile(Picture.FileName)
            NameImagen.Text = "\\ANTUA-PC\Servidor_de_Archivos\Imagenes\Inventario\" & D & "-" & IDP.Text & TxtNombreP.Text.Substring(0, 5) & ".JPG"
        End If
    End Sub


    'Combos
    Private Sub Ar(sender As Object, e As EventArgs) Handles CArea.TextChanged
        CProceso.SelectedValue = LP.Text
    End Sub


    'Selección de Datos
    '   Selección de un Dato en el DataGridView
    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick
        Dim FilaProducto As Integer
        Dim row As DataGridViewRow = DataView.Rows(e.RowIndex)

        FilaProducto = row.Cells(0).Value
        IDP.Text = FilaProducto

        DModif()
        BVisiblesCRUD()
        BOrdenC.Visible = True
        AgregarExistencias.Visible = False
        TxTUPza.ReadOnly = False

        If TxtTipoCambio.Text = "" Or TxtTipoCambio.Text = "Valor" Then
            HTC.Enabled = True
        End If

        IA.Text = "1"
        CargaInfpRO()
    End Sub


    'TextBox
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarDatos()
    End Sub

    Private Sub TxtCB_TextChanged(sender As Object, e As EventArgs) Handles TxtCB.TextChanged
        CodigoBarras.DataToEncode = TxtCB.Text
    End Sub

    Private Sub IDP_TextChanged(sender As Object, e As EventArgs) Handles IDP.TextChanged
        CargaInfpRO()
    End Sub


    'Procedimientos
    '   Llenar DataView
    Private Sub DatosGV()
        Dim Consulta As New SqlCommand("SP_BInventa", Conex)
        Dim Da As New SqlDataAdapter(Consulta)
        Dim Ds As New DataSet

        Consulta.CommandType = CommandType.StoredProcedure

        Try
            Conex.Open()
            Da.Fill(Ds)

            DataView.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub

    '   Mostrar Inf en TextBox
    Private Sub CargaInfpRO()
        Dim Consulta As New SqlCommand("SP_BPRODUCTO", Conex)
        Dim dr As SqlDataReader

        Consulta.CommandType = CommandType.StoredProcedure
        Consulta.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))

        Try
            Conex.Open()
            dr = Consulta.ExecuteReader

            Do While dr.Read
                TxtClaveP.Text = Trim(dr("Clave_Producto"))
                TxtNombreP.Text = Trim(dr("Nombre_Producto"))
                TxtDescripcion.Text = Trim(dr("Descripcion"))
                TxtExistencia.Text = Trim(dr("Existencia"))
                TxtMinimo.Text = Trim(dr("Minimo"))
                TxtMaximo.Text = Trim(dr("Maximo"))
                TxtMedida.Text = Trim(dr("Medida"))
                TxtMarca.Text = Trim(dr("Marca"))
                TxtCategoria.Text = Trim(dr("Categoria"))
                TxtArea.Text = Trim(dr("Area"))
                TxtProceso.Text = Trim(dr("Nombre_Proceso"))
                CodigoBarras.DataToEncode = Trim(dr("Codigo_Barras"))
                TxtPrecio.Text = Trim(dr("PU_Total"))
                Imagen.ImageLocation = Trim(dr("Imagen"))

                LM.Text = Trim(dr("Id_Medida"))
                LMa.Text = Trim(dr("Id_Marca"))
                LA.Text = Trim(dr("Id_Area"))
                LP.Text = Trim(dr("Id_Proceso"))
                LC.Text = Trim(dr("Id_Categoria"))
            Loop

            dr.Close()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub

    '   NExistencia
    Public Sub Datos()
        Dim DateE = DateTime.Now
        Dim GDatos As New SqlCommand("SP_GDEProductos", Conex)

        GDatos.CommandType = CommandType.StoredProcedure
        GDatos.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))
        GDatos.Parameters.AddWithValue("@Cantidad", Trim(TxtNExistencia.Text))
        GDatos.Parameters.AddWithValue("@Producto", Trim(TxtNombreP.Text))
        GDatos.Parameters.AddWithValue("@Precio_Unitario_PZA", Trim(TxTUPza.Text))
        GDatos.Parameters.AddWithValue("@Tipo_Cambio", Trim(TCambio.Text))
        GDatos.Parameters.AddWithValue("@PU_Corte_PZA", Trim(TxtUCPza.Text))
        GDatos.Parameters.AddWithValue("@PU_Total", Trim(TxtUTotal.Text))
        GDatos.Parameters.AddWithValue("@Precio_Total", Trim(TxtTotal.Text))
        GDatos.Parameters.AddWithValue("@Created", DateE)
        GDatos.Parameters.AddWithValue("@Orden_Compra", Trim(TxtOrdenCompra.Text))
        GDatos.Parameters.AddWithValue("@PUUSD", Trim(TxtUUSD.Text))
        GDatos.Parameters.AddWithValue("@FUSD", Trim(TxtFUSD.Text))
        GDatos.Parameters.AddWithValue("@TUSD", Trim(TxtTUSD.Text))
        GDatos.Parameters.AddWithValue("@Id_Empleado", Trim(LIDE.Text))
        GDatos.Parameters.AddWithValue("@Empleado", Trim(LUsuario.Text))

        If Tickets.LCS.Text <> Nothing Then
            GDatos.Parameters.AddWithValue("@CodiS", Trim(Tickets.LCS.Text))
        Else
            GDatos.Parameters.AddWithValue("@CodiS", Trim(LCS.Text))
        End If
        MR()
        Dim RData As SqlDataReader

        Try
            Conex.Open()
            RData = GDatos.ExecuteReader()
            AgregarExistencias.Visible = False
            Ticktss()

        Catch ex As Exception
            MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK)
        End Try
        Conex.Close()

        Conex.Open()
        Dim Prod As String = TxtNombreP.Text
        Dim CodS As String = LCS.Text
        Dim CanS As Double = CDec(TxtNExistencia.Text)
        Dim Pre As Double = TxtTotal.Text

        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanE, CanS, PrecioE, PrecioS, Created)
                                                             VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0, " & Pre & ",0, SYSDATETIME())"

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
    End Sub

    '   Modificación
    Private Sub Modifi()
        Dim DateE = DateTime.Now
        Dim GDatos As New SqlCommand("SP_ModifProdu", Conex)

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))
        GDatos.Parameters.AddWithValue("@Clave_Producto", UCase(Trim(TxtClaveP.Text)))
        GDatos.Parameters.AddWithValue("@Nombre_Producto", UCase(Trim(TxtNombreP.Text)))
        GDatos.Parameters.AddWithValue("@Descripcion", Trim(TxtDescripcion.Text))
        GDatos.Parameters.AddWithValue("@Medida", Trim(CMedida.SelectedValue))
        GDatos.Parameters.AddWithValue("@Marca", Trim(CMarca.SelectedValue))
        GDatos.Parameters.AddWithValue("@Minimo", Trim(TxtMinimo.Text))
        GDatos.Parameters.AddWithValue("@Maximo", Trim(TxtMaximo.Text))
        GDatos.Parameters.AddWithValue("@Categoria", Trim(CCategoria.SelectedValue))
        GDatos.Parameters.AddWithValue("@Area", Trim(CArea.SelectedValue))
        GDatos.Parameters.AddWithValue("@Proceso", Trim(CProceso.SelectedValue))
        GDatos.Parameters.AddWithValue("@CodigoB", Trim(CodigoBarras.DataToEncode))
        GDatos.Parameters.AddWithValue("@Imagen", Trim(NameImagen.Text))
        GDatos.Parameters.AddWithValue("@Updated", DateE)

        Dim RData As SqlDataReader

        Try
            Dim NI As String = (Picture.FileName)
            If NI <> "" Then
                System.IO.File.Copy(NI, NameImagen.Text)
            End If
            Conex.Open()
            RData = GDatos.ExecuteReader()

            DModif()
            BVisiblesCRUD()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Modificar Datos", MessageBoxButtons.OK)
        End Try

        Conex.Close()
        DatosGV()
        CargaInfpRO()
    End Sub

    '   Eliminar Datos
    Private Sub Eliminar()
        Dim DateE = DateTime.Now
        Dim EDatos As New SqlCommand("SP_DesactProducto", Conex)
        Dim RData As SqlDataReader

        EDatos.CommandType = CommandType.StoredProcedure

        EDatos.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))
        EDatos.Parameters.AddWithValue("@FechaEliminacion", DateE)

        Try
            Conex.Open()
            RData = EDatos.ExecuteReader()

            'Eliminar dato en DataView
            Dim loFila As DataGridViewRow = Me.DataView.CurrentRow()
            DataView.Rows.Remove(loFila)
            DataB()
            AgregarExistencias.Visible = False
            BInvisiblesCRUD()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Eliminar Registro", MessageBoxButtons.OK)
        End Try
        Conex.Close()
        BNuevoProducto.Visible = True
    End Sub


    'Consultas
    '   Búsqueda en DataView
    Private Sub BuscarDatos()
        If TxtBusqueda.Text = "" Then
            DatosGV()
        Else
            Dim Consulta As String = "SELECT P.Id_Producto, P.Clave_Producto, P.Nombre_Producto, P.Existencia
                                      FROM TB_Productos AS P
                                           INNER JOIN TB_Marcas AS Ma ON Ma.Id_Marca = P.Id_Marca
                                      WHERE (P.Clave_Producto LIKE '%'+@Busqueda+'%' OR
                                             P.Nombre_Producto LIKE '%'+@Busqueda+'%' OR
                                             Ma.Marca LIKE '%'+@Busqueda+'%' OR
                                             P.Codigo_Barras LIKE '%'+@Busqueda+'%') AND
                                             P.Estado = 'Activo'
                                        ORDER BY P.Nombre_Producto ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))

            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DataView.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub

    Private Sub Nombres()
        Dim Consulta As String = "SELECT ( E.Nombre_Empleado+ ' ' + E.Ape_Paterno+' ' +  E.Ape_Materno) AS Nombre, E.Id_Empleado
                                  FROM TB_Usuarios AS U
                                    INNER JOIN TB_Empleados AS E ON U.Id_Empleado = E.Id_Empleado
                                  WHERE  U.Id_Usuario = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", Trim(Index.L_ID.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            LUsuario.Text = Da.Item("Nombre").ToString()
            LIDE.Text = Da.Item("Id_Empleado").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub Consultas()
        'Combos
        With UMedida
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Medidas
                            WHERE Estado = 'Activo'
                            ORDER BY Medida ASC"
            .Connection = Conex
        End With

        DAUMedida.SelectCommand = UMedida
        DTUMedida = New DataTable
        DAUMedida.Fill(DTUMedida)
        With CMedida
            .DataSource = DTUMedida
            .DisplayMember = "Medida"
            .ValueMember = "Id_Medida"
        End With

        '/////////
        With Marca
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Marcas
                            WHERE Estado = 'Activo'
                            ORDER BY Marca ASC"
            .Connection = Conex
        End With

        DAMarca.SelectCommand = Marca
        DTMarca = New DataTable
        DAMarca.Fill(DTMarca)
        With CMarca
            .DataSource = DTMarca
            .DisplayMember = "Marca"
            .ValueMember = "Id_Marca"
        End With

        '////////
        With Area
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Areas
                            WHERE Estado = 'Activo'
                            ORDER BY Area ASC"
            .Connection = Conex
        End With

        DAArea.SelectCommand = Area
        DTArea = New DataTable
        DAArea.Fill(DTArea)
        With CArea
            .DataSource = DTArea
            .DisplayMember = "Area"
            .ValueMember = "Id_Area"
        End With

        '/////////////
        With Categoria
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Categorias
                            WHERE Estado = 'Activo'
                            ORDER BY Categoria ASC"
            .Connection = Conex
        End With

        DACategoria.SelectCommand = Categoria
        DTCategoria = New DataTable
        DACategoria.Fill(DTCategoria)
        With CCategoria
            .DataSource = DTCategoria
            .DisplayMember = "Categoria"
            .ValueMember = "Id_Categoria"
        End With

        '///////////
        With Proceso
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Procesos
                            WHERE Estado = 'Activo'
                            ORDER BY Nombre_Proceso ASC"
            .Connection = Conex
        End With

        DAProceso.SelectCommand = Proceso
        DTProceso = New DataTable
        DAProceso.Fill(DTProceso)
        With CProceso
            .DataSource = DTProceso
            .DisplayMember = "Nombre_Proceso"
            .ValueMember = "Id_Proceso"
        End With
    End Sub

    '   Insertar en Moviemiento Rastreo Alta
    Private Sub MR()
        Dim DateTime As Date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim CodS As String = LCS.Text
        Dim Emple As String = LUsuario.Text

        Conex.Open()
        Dim CONSULTA As String = "IF NOT EXISTS(SELECT CodiS FROM TB_MovimientoRastreo WHERE CodiS = '" & CodS & "')
                                        INSERT INTO TB_MovimientoRastreo (Tipo, Estado, Responsable, CodiS , Created)
                                                            VALUES ( 'Entrada', 'Entrada', '" & Emple & "', '" & CodS & "',SYSDATETIME() )"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
    End Sub


    ''Búsqueda en la Página del SAT para Tipo de Cambio
    '   Creación de Link para el SAT  - Fecha y Tipo de Cambio Actual
    Private Sub FechaActual()
        Dim D = DateTime.Now.ToString("dd")
        Dim M = DateTime.Now.ToString("MM")
        Dim Y = DateTime.Now.ToString("yyyy")

        Dim URLS As String = ("https://dof.gob.mx/indicadores_detalle.php?cod_tipo_indicador=158&&dfecha=" & D & "%2F" & M + "%2F" & Y & "&&hfecha=" & D & "%2F" & M & "%2F" & Y)

        HSAT = New WebBrowser()

        HSAT.ScriptErrorsSuppressed = True

        HURL.Text = URLS
        HSAT.Navigate(New Uri(URLS)) ' Carga la página web creando un nuevo documento HTML

        AddHandler HSAT.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf TipoCambioHoy)
    End Sub

    Private Sub TipoCambioHoy()
        If (HSAT.Document IsNot Nothing) Then ' En caso de que la página no halla cargado bien el documento
            Dim divs = HSAT.Document.Body.GetElementsByTagName("td") ' Obtiene todos los elementos <div> de la página web
            For Each div As HtmlElement In divs ' Recorre la lista de elementos <div>
                Dim className As String = div.GetAttribute("width") ' Obtiene el atributo [class] (nos servirá de filtro)

                If className = "52%" Then ' El texto con el que se compara es el que muestra el valor del dólar en pesos argentinos
                    TxtTipoCambio.Text = div.InnerText ' Se obtiene el valor del dólar y se cambia el punto por la coma
                End If
            Next
        End If
    End Sub

    '   Elegir el Tipo de Cambio
    Private Sub DTTipoCambio_ValueChanged(sender As Object, e As EventArgs) Handles DTTipoCambio.ValueChanged
        Dim D = DTTipoCambio.Value.ToString("dd")
        Dim M = DTTipoCambio.Value.ToString("MM")
        Dim Y = DTTipoCambio.Value.Year
        Dim URLT As String = ("https://dof.gob.mx/indicadores_detalle.php?cod_tipo_indicador=158&&dfecha=" & D & "%2F" & M + "%2F" & Y & "&&hfecha=" & D & "%2F" & M & "%2F" & Y)
        MSAT = New WebBrowser()

        MSAT.ScriptErrorsSuppressed = True

        MURL.Text = URLT
        MSAT.Navigate(New Uri(URLT)) ' Carga la página web creando un nuevo documento HTML
        AddHandler MSAT.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf TipoCambio)

        TC.Enabled = True
        IA.Text = "1"
        LErrEP.Visible = False
    End Sub

    Private Sub TipoCambio()
        If (MSAT.Document IsNot Nothing) Then ' En caso de que la página no halla cargado bien el documento
            Dim divs = MSAT.Document.Body.GetElementsByTagName("td") ' Obtiene todos los elementos <div> de la página web

            For Each div As HtmlElement In divs ' Recorre la lista de elementos <div>
                Dim className As String = div.GetAttribute("width") ' Obtiene el atributo [class] (nos servirá de filtro)

                If className = "52%" Then ' El texto con el que se compara es el que muestra el valor del dólar en pesos argentinos
                    TCambio.Text = div.InnerText ' Se obtiene el valor del dólar
                End If
            Next
        End If
    End Sub


    'Funciones
    Public Sub Ticktss()
        If CStr(Len(TxtNombreP.Text)) > 25 Then
            Dim NPr As String = TxtNombreP.Text
            Tickets.DatosDG.Rows.Add(IDP.Text.Trim(), NPr.Substring(0, 25), TxtNExistencia.Text.Trim())
        Else
            Tickets.DatosDG.Rows.Add(IDP.Text.Trim(), TxtNombreP.Text, TxtNExistencia.Text.Trim())
        End If
    End Sub

    Private Sub CodigoB()
        Dim Are As String = CArea.Text
        Dim Pro As String = CProceso.Text
        Dim Cat As String = CCategoria.Text
        Dim NPr As String = TxtNombreP.Text
        Dim Med As String = CMedida.Text

        If Are <> Nothing And Pro <> Nothing Then
            CodigoBarras.DataToEncode = UCase(Are.Substring(0, 2) & Pro.Substring(0, 2) & Cat.Substring(0, 2) & NPr.Substring(0, 2) & Med.Substring(0, 2))
        Else
            If Are = Nothing And Pro <> Nothing Then
                CodigoBarras.DataToEncode = UCase(Pro.Substring(0, 4) & Cat.Substring(0, 2) & NPr.Substring(0, 2) & Med.Substring(0, 2))
            Else
                If Are <> Nothing And Pro = Nothing Then
                    CodigoBarras.DataToEncode = UCase(Are.Substring(0, 4) & Cat.Substring(0, 2) & NPr.Substring(0, 2) & Med.Substring(0, 2))
                End If
            End If
        End If
    End Sub


    'Eventos
    Private Sub HTC_Tick(sender As Object, e As EventArgs) Handles HTC.Tick
        Dim Time As Integer = 1
        Time = Time - 1
        If Time = 0 And (TxtTipoCambio.Text = "" Or TxtTipoCambio.Text = "Valor") Then
            HTC.Enabled = False
            LAdvet.Visible = True
            TxtTipoCambio.ReadOnly = False
        End If
    End Sub

    Private Sub TC_Tick(sender As Object, e As EventArgs) Handles TC.Tick
        Dim Time As Integer = IA.Text

        IA.Text = Time - 1
        If Time = 0 And (TCambio.Text = "" Or TCambio.Text = "Valor") Then
            TC.Enabled = False
            LErrEP.Visible = True
            TCambio.ReadOnly = False
            DTTipoCambio.Visible = False
        Else
            If Time = 0 And TxtTUSD.Text = "" Then
                TxTUPza.Text = "0.00"
            Else
                If Time = 0 And TCambio.Text <> "" Then
                    Dim T As Decimal = (CDec(TxtTUSD.Text) * CDec(TCambio.Text))
                    T = Math.Round(T, 4)
                    TxTUPza.Text = T.ToString
                End If
            End If
        End If
    End Sub


    'Operaciones
    '   Precio a Dolares Hoy
    Private Sub PrecioDolares() Handles TxtPrecio.TextChanged
        Dim TE As Decimal
        Dim NE As Decimal

        If TxtPrecio.Text <> Nothing And TxtTipoCambio.Text <> Nothing Then
            TE = CDec(TxtPrecio.Text)
            NE = CDec(TxtTipoCambio.Text)
            Dim T As Decimal = CDec(TE / NE)
            T = Math.Round(T, 4)
            TxtUSD.Text = T.ToString
        End If

        If TxtTipoCambio.Text = Nothing And TxtPrecio.Text <> Nothing Then
            TxtUSD.Text = "0.00"
        End If
    End Sub

    Private Sub PDManual() Handles TxtTipoCambio.KeyUp
        If TxtTipoCambio.Text <> Nothing Then
            Dim T As Decimal = CDec(TxtPrecio.Text) / CDec(TxtTipoCambio.Text)
            T = Math.Round(T, 4)
            TxtUSD.Text = T.ToString
        Else
            TxtUSD.Text = "0.00"
        End If
    End Sub

    Private Sub MPDManual() Handles TCambio.KeyUp, TxtTUSD.TextChanged
        If TCambio.Text <> Nothing Then
            Dim T As Decimal = CDec(TxtTUSD.Text) * CDec(TCambio.Text)
            T = Math.Round(T, 4)
            TxTUPza.Text = T.ToString
        Else
            TxTUPza.Text = "0.00"
        End If

        If TxtTUSD.Text = Nothing Then
            TxTUPza.ReadOnly = False
        ElseIf TxtTUSD.Text = "0" Then
            TxTUPza.ReadOnly = False
        Else
            TxTUPza.ReadOnly = True
        End If
    End Sub

    '   O-NE
    Private Sub TotalUE() Handles TxtUUSD.TextChanged, TxtFUSD.TextChanged
        Dim TE As Decimal
        Dim TU As Decimal

        If TxtUUSD.Text <> Nothing Then
            TE = CDec(TxtUUSD.Text)
        End If

        If TxtFUSD.Text <> Nothing Then
            TU = CDec(TxtFUSD.Text)
        End If

        TxtTUSD.Text = CDec(TE + TU).ToString
    End Sub

    Private Sub UTotal(sender As Object, e As EventArgs) Handles TxTUPza.TextChanged, TxtUCPza.TextChanged
        Dim TE As Decimal = 0
        Dim NE As Decimal = 0

        If TxTUPza.Text <> Nothing Then
            TE = CDec(TxTUPza.Text)
        End If

        If TxtUCPza.Text <> Nothing Then
            NE = CDec(TxtUCPza.Text)
        End If
        TxtUTotal.Text = CDec(TE + NE).ToString
    End Sub

    Private Sub Total(sender As Object, e As EventArgs) Handles TxtNExistencia.TextChanged, TxtUTotal.TextChanged
        Dim TE As Decimal = 0
        Dim NE As Decimal = 0

        If TxtNExistencia.Text <> Nothing Then
            TE = CDec(TxtNExistencia.Text)
        End If

        If TxtUTotal.Text <> Nothing Then
            NE = CDec(TxtUTotal.Text)
        End If
        TxtTotal.Text = CDec(TE * NE).ToString
    End Sub

    Private Sub TotalExt() Handles TxtNExistencia.TextChanged
        Dim TE As Decimal = 0
        Dim NE As Decimal = CDec(TxtExistencia.Text)

        If TxtNExistencia.Text <> Nothing Then
            TE = CDec(TxtNExistencia.Text)
        End If

        LTExistencias.Text = CDec(TE + NE).ToString
    End Sub


    'Validaciones
    Private Sub TxTUPza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxTUPza.KeyPress
        NumerosyDecimal(TxTUPza, e)
    End Sub

    Private Sub TxtTipoCambio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTipoCambio.KeyPress
        NumerosyDecimal(TxtTipoCambio, e)
    End Sub

    Private Sub TxtMinimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMinimo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtMaximo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMaximo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNExistencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNExistencia.KeyPress
        NumerosyDecimal(TxtNExistencia, e)
    End Sub

    Private Sub TxtUUSD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUUSD.KeyPress
        NumerosyDecimal(TxtUUSD, e)
    End Sub

    Private Sub TxtFUSD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFUSD.KeyPress
        NumerosyDecimal(TxtFUSD, e)
    End Sub

    Private Sub TCambio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCambio.KeyPress
        NumerosyDecimal(TCambio, e)
    End Sub

    Private Sub TxtUCPzaPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUCPza.KeyPress
        NumerosyDecimal(TxtUCPza, e)
    End Sub

    '   Numeros y Punto Decimal
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'Vaciar Datos
    Public Sub DatosB()
        TxtNExistencia.Text = ""
        TxTUPza.Text = ""
        TCambio.Text = ""
        TxtUCPza.Text = ""
        TxtUTotal.Text = ""
        TxtTotal.Text = ""
        TxtOrdenCompra.Text = ""
        LTExistencias.Text = ""
        TxtUUSD.Text = ""
        TxtFUSD.Text = ""
        TxtTUSD.Text = ""
        DTTipoCambio.Visible = False
    End Sub

    Public Sub DataB()
        TxtClaveP.Text = ""
        TxtNombreP.Text = ""
        TxtDescripcion.Text = ""
        TxtExistencia.Text = ""
        TxtMinimo.Text = ""
        TxtMaximo.Text = ""
        TxtMedida.Text = ""
        TxtMarca.Text = ""
        TxtCategoria.Text = ""
        TxtArea.Text = ""
        TxtProceso.Text = ""
        CodigoBarras.DataToEncode = "1234567890"
        TxtPrecio.Text = ""
        Imagen.ImageLocation = ""
        TxtUSD.Text = ""

        BAgregarExistencia.Visible = False
        BModificar.Visible = False
        BEliminar.Visible = False
    End Sub


    'Mostrar Botones
    Private Sub BVisiblesCRUD()
        BNuevoProducto.Visible = True
        BMostrarHist.Visible = True
        BAgregarExistencia.Visible = True
        BModificar.Visible = True
        BEliminar.Visible = True
    End Sub

    Private Sub BInvisiblesCRUD()
        BNuevoProducto.Visible = False
        BMostrarHist.Visible = False
        BAgregarExistencia.Visible = False
        BModificar.Visible = False
        BEliminar.Visible = False
    End Sub

    Private Sub AModif()
        CMedida.Visible = True
        CMedida.SelectedValue = LM.Text
        CMarca.Visible = True
        CMarca.SelectedValue = LMa.Text
        TxtDescripcion.ReadOnly = False
        TxtMinimo.ReadOnly = False
        TxtMaximo.ReadOnly = False
        CArea.Visible = True
        CArea.SelectedValue = LA.Text
        CProceso.Visible = True
        CProceso.SelectedValue = LP.Text
        CCategoria.Visible = True
        CCategoria.SelectedValue = LC.Text

        TxtDescripcion.BackColor = Color.LightCoral
        TxtMinimo.BackColor = Color.LightCoral
        TxtMaximo.BackColor = Color.LightCoral

        BGuardarMo.Visible = True
        BRetorno.Visible = True
        BImagen.Visible = True

        If CodigoBarras.DataToEncode = Nothing Then
            TxtCB.Visible = True
            PCodigoBarras.Visible = True

            TxtNombreP.ReadOnly = False
            TxtNombreP.BackColor = Color.LightCoral
        End If

        If TxtClaveP.Text = Nothing Then
            TxtClaveP.ReadOnly = False
            TxtClaveP.BackColor = Color.LightCoral
        End If
    End Sub

    Private Sub DModif()
        TxtClaveP.ReadOnly = True
        TxtNombreP.ReadOnly = True
        CMedida.Visible = False
        CMarca.Visible = False
        TxtDescripcion.ReadOnly = True
        TxtMinimo.ReadOnly = True
        TxtMaximo.ReadOnly = True
        CArea.Visible = False
        CProceso.Visible = False
        CCategoria.Visible = False

        TxtClaveP.BackColor = Color.Gainsboro
        TxtNombreP.BackColor = Color.Gainsboro
        TxtDescripcion.BackColor = Color.Gainsboro
        TxtMinimo.BackColor = Color.Gainsboro
        TxtMaximo.BackColor = Color.Gainsboro

        BRetorno.Visible = False
        BGuardarMo.Visible = False
        BImagen.Visible = False
        PCodigoBarras.Visible = False
        TxtCB.Visible = False
    End Sub


    'Movimiento
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class
