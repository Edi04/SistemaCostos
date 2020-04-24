Public Class ReporteOrd
    Private Sub ReporteOrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        Dim codigoord As String
        codigoord = Textbuscar.Text
        'TODO: esta línea de código carga datos en la tabla 'reporteOrdC.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.reporteOrdC.DataTable1, codigoord)
        'TODO: esta línea de código carga datos en la tabla 'traerproductos.TB_Ordenes_Detalle' Puede moverla o quitarla según sea necesario.
        Me.TB_Ordenes_DetalleTableAdapter.Fill(Me.traerproductos.TB_Ordenes_Detalle, codigoord)
        Me.ReportViewer1.RefreshReport()
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
    '---------------------------------termina coidigo para poder mover formulario------------------------------

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        RegistrosOrdCom.Show()
    End Sub


    Private Sub btnCerrarPrograma_Click(sender As Object, e As EventArgs) Handles btnCerrarPrograma.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("Esta Seguro Que ¿Desea salir?", vbYesNo, MessageBoxIcon.Warning)
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub
End Class