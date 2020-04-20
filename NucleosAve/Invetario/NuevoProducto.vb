Imports System.Data.SqlClient

Public Class NuevoProducto
    'Conexión
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

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

    Dim Categoria As New SqlCommand
    Dim DTCategoria As DataTable
    Dim DACategoria As New SqlDataAdapter

    Dim Proceso As New SqlCommand
    Dim DTProceso As DataTable
    Dim DAProceso As New SqlDataAdapter

    Private Sub NuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        With CBUMedida
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
        With CBArea
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
        With CBCategoria
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
        With CBProceso
            .DataSource = DTProceso
            .DisplayMember = "Nombre_Proceso"
            .ValueMember = "Id_Proceso"
        End With
    End Sub


    'Botones
    '   Guardar
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (CBUMedida.SelectedValue = Nothing) Or (CBUMedida.SelectedValue = 7) Or (CMarca.SelectedValue = Nothing) Or
           (CBCategoria.SelectedValue = Nothing) Or (CBCategoria.SelectedValue = 7) Or TxtNombreP.Text = "" Then
            MessageBox.Show("Seleccione y/o Ingrese los Datos", "Advertencia", MessageBoxButtons.OK)
        ElseIf CBArea.SelectedValue = Nothing Then
            CBArea.SelectedValue = 35
            Datos()

        ElseIf CBProceso.SelectedValue = Nothing Then
            CBProceso.SelectedValue = 49
            Datos()

        Else
            Datos()
        End If
    End Sub

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
        Inventario.Show()
    End Sub

    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
        Inventario.Show()
    End Sub

    '   Imagen
    Dim Picture As New OpenFileDialog()
    Private Sub BImagen_Click(sender As Object, e As EventArgs) Handles BImagen.Click
        Dim D = DateTime.Now.ToString("dd-MM-yyyy")
        Picture.Filter = "Archivo JPG|*.jpg"
        If Picture.ShowDialog() = DialogResult.OK Then
            Imagen.Image = Image.FromFile(Picture.FileName)
            NameImagen.Text = "\\ANTUA-PC\Servidor_de_Archivos\Imagenes\Inventario\" & D & "-" & TxtNombreP.Text.Substring(0, 5) & ".JPG"
        End If
    End Sub

    '   Código de Barras
    Private Sub PCodigoBarras_Click(sender As Object, e As EventArgs) Handles PCodigoBarras.Click
        If (CBUMedida.SelectedValue = Nothing) Or (CBUMedida.SelectedValue = 7) Or (CMarca.SelectedValue = Nothing) Or
            (CBCategoria.SelectedValue = Nothing) Or (CBCategoria.SelectedValue = 7) Then
            MessageBox.Show("Seleccione los Datos", "Advertencia", MessageBoxButtons.OK)
        Else
            CodigoB()
        End If
    End Sub

    Private Sub BNMarca_Click(sender As Object, e As EventArgs) Handles BNMarca.Click
        NMarca.Show()
        NMarca.LArea.Text = CBArea.SelectedValue
        NMarca.LProceso.Text = CBProceso.SelectedValue
        NMarca.LCategoria.Text = CBCategoria.SelectedValue
        NMarca.LClaveP.Text = TxtClaveP.Text
        NMarca.LNombre.Text = TxtNombreP.Text
        NMarca.LMedida.Text = CBUMedida.SelectedValue
    End Sub


    'Procedimientos
    '   Guardar
    Public Sub Datos()
        Dim GDatos As New SqlCommand("SP_GNuevo_Producto", Conex)
        Dim DateA = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Clave_Producto", UCase(Trim(TxtClaveP.Text)))
        GDatos.Parameters.AddWithValue("@Nombre_Producto", UCase(Trim(TxtNombreP.Text)))
        GDatos.Parameters.AddWithValue("@Descripcion", Trim(TxtDescripcion.Text))
        GDatos.Parameters.AddWithValue("@Minimo", Trim(TxtMinimo.Text))
        GDatos.Parameters.AddWithValue("@Maximo ", Trim(TxtMaximo.Text))
        GDatos.Parameters.AddWithValue("@Id_Medida", Trim(CBUMedida.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Marca", Trim(CMarca.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Categoria", Trim(CBCategoria.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Area", Trim(CBArea.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Proceso", Trim(CBProceso.SelectedValue))
        GDatos.Parameters.AddWithValue("@Codigo_Barras", Trim(Barcode1.DataToEncode))
        GDatos.Parameters.AddWithValue("@Imagen", Trim(NameImagen.Text))
        GDatos.Parameters.AddWithValue("@Created", DateA)

        Dim RData As SqlDataReader
        Try
            Conex.Open()
            Inventario.TxtBusqueda.Text = TxtNombreP.Text

            If NameImagen.Text = "" Then
            Else
                Dim NI As String = (Picture.FileName)
                System.IO.File.Copy(NI, NameImagen.Text)
            End If

            RData = GDatos.ExecuteReader()
            Me.Close()
            Inventario.Show()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub


    'Fuciones - Operaciones
    Private Sub CodigoB()
        Dim Are As String = CBArea.Text
        Dim Pro As String = CBProceso.Text
        Dim Cat As String = CBCategoria.Text
        Dim NPr As String = TxtNombreP.Text
        Dim Med As String = CBUMedida.Text

        If Are <> Nothing And Pro <> Nothing Then
            Barcode1.DataToEncode = UCase(Are.Substring(0, 2) & Pro.Substring(0, 2) & Cat.Substring(0, 2) & NPr.Substring(0, 2) & Med.Substring(0, 2))
        Else
            If Are = Nothing And Pro <> Nothing Then
                Barcode1.DataToEncode = UCase(Pro.Substring(0, 4) & Cat.Substring(0, 2) & NPr.Substring(0, 2) & Med.Substring(0, 2))
            Else
                If Are <> Nothing And Pro = Nothing Then
                    Barcode1.DataToEncode = UCase(Are.Substring(0, 4) & Cat.Substring(0, 2) & NPr.Substring(0, 2) & Med.Substring(0, 2))
                End If
            End If
        End If
    End Sub


    'Validaciones
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

    Private Sub TxtCB_TextChanged(sender As Object, e As EventArgs) Handles TxtCB.TextChanged
        Barcode1.DataToEncode = TxtCB.Text
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