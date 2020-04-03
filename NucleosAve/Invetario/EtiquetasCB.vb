Imports System.Drawing.Printing
Imports System.Data.SqlClient

Public Class EtiquetasCB
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub EtiquetasCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataDB()
    End Sub

    'Botones
    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Close()
    End Sub

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    '   Imprimir
    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Try
            ' documento
            Dim PrintTxt As New PrintDocument()
            PrintTxt.PrinterSettings.PrinterName = "ZDesigner TLP 2844"
            ' evento print
            AddHandler PrintTxt.PrintPage, AddressOf Me.ImprimirBoleta
            PrintTxt.Print()
        Catch ex As Exception
            MsgBox("ERROR AL IMPRIMIR BARRA" & vbCrLf & ex.Message)
        End Try
    End Sub


    'TextBox
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarDatos()
    End Sub

    Private Sub DataCB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataCB.CellContentClick
        Dim Producto As String
        Dim DCodigo As String

        Dim row As DataGridViewRow = DataCB.Rows(e.RowIndex)

        Producto = row.Cells(2).Value
        NProducto.Text = Producto
        DCodigo = row.Cells(3).Value
        Codigo.DataToEncode = DCodigo

        Espera.Enabled = True
    End Sub


    'Consultas
    Private Sub DataDB()
        Dim Consulta As String = "SELECT Id_Producto, Clave_Producto, Nombre_Producto, Codigo_Barras
                                  FROM TB_Productos
                                  WHERE Estado = 'Activo' AND
                                        Codigo_Barras <> ''
                                  ORDER BY Codigo_Barras DESC"

        Dim cmd As New SqlCommand(Consulta, Conex)
        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet
        Try
            Conex.Open()

            Da.Fill(Ds)
            DataCB.DataSource = Ds.Tables(0)
            Da.Dispose()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conex.Close()
    End Sub

    '   Búsqueda
    Private Sub BuscarDatos()
        If TxtBusqueda.Text = "" Then
            DataDB()
        Else
            Dim SQL As String = "SELECT Id_Producto, Clave_Producto, Nombre_Producto, Codigo_Barras
                                  FROM TB_Productos
                                  WHERE Estado = 'Activo' AND
                                        (Clave_Producto LIKE '%' + @Busqueda + '%' OR
                                         Nombre_Producto LIKE '%' + @Busqueda + '%' OR
                                         Codigo_Barras LIKE '%' + @Busqueda + '%') AND
                                        Codigo_Barras <> ''
                                  ORDER BY Codigo_Barras DESC"

            Dim cmd As New SqlCommand(SQL, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet
            Try
                Conex.Open()

                Da.Fill(Ds)
                DataCB.DataSource = Ds.Tables(0)
                Da.Dispose()
            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Conex.Close()
        End If
    End Sub


    'Procedimiento de Impresión
    Private Sub ImprimirBoleta(ByVal sender As System.Object, ByVal e As PrintPageEventArgs)
        ' Letra
        Dim Producto As New Font("Arial", 9)

        Dim C As New Integer
        C = Len(NProducto.Text)
        Dim Cadena As String = NProducto.Text
        If C < 22 Then
            e.Graphics.DrawString(Me.NProducto.Text.Trim, Producto, Brushes.Black, 10, 10)
        ElseIf C < 44 Then
            e.Graphics.DrawString(Mid(Cadena, 1, 22), Producto, Brushes.Black, 10, 10)
            e.Graphics.DrawString(Mid(Cadena, 23, C), Producto, Brushes.Black, 10, 22)
        ElseIf C < 66 Then
            e.Graphics.DrawString(Mid(Cadena, 1, 22), Producto, Brushes.Black, 10, 10)
            e.Graphics.DrawString(Mid(Cadena, 23, 44), Producto, Brushes.Black, 10, 22)
            e.Graphics.DrawString(Mid(Cadena, 45, C), Producto, Brushes.Black, 10, 32)
        End If

        'Impresión
        e.Graphics.DrawImage(Codigo.BMPPicture, 17, 65, 171, 60)
    End Sub


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