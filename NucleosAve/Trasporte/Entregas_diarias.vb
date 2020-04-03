Imports System.Data.SqlClient
Public Class Entregas_diarias
    'coneccion de Bd y direcctivas para poder conectar y poder ejecutar consultas
    '----Directivas-->
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    Private Sub Entregas_diarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    '--------------------zzzzz BOTON gregar cajas de texto.----------------------

    Sub MostrareNTREGAS()
        Try
            Dim Func As New Funcion_Controlador
            tabla = Func.FnMostrarEntregas
            If tabla.Rows.Count <> 0 Then
                DataGridView_entregas.DataSource = tabla
            Else
                DataGridView_entregas.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DateTime_hoy_ValueChanged(sender As Object, e As EventArgs) Handles DateTime_hoy.ValueChanged
        MostrareNTREGAS()
    End Sub

    Private Sub DataGridView_entregas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_entregas.CellClick
        '-codigo para fletes y entregas
        Fletes_y_Entregas.TextBox_Ot.Text = DataGridView_entregas.CurrentRow.Cells(1).Value
    End Sub

    Private Sub DataGridView_entregas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_entregas.CellDoubleClick
        Panel_detalles.Visible = True
        TextBox_nprog.Text = DataGridView_entregas.CurrentRow.Cells(0).Value
        TextBox_ot.Text = DataGridView_entregas.CurrentRow.Cells(1).Value
        TextBox_cliente.Text = DataGridView_entregas.CurrentRow.Cells(2).Value
        DateTimePicker_fecha2.Text = DataGridView_entregas.CurrentRow.Cells(3).Value
        DateTimePicker_fecha.Text = DataGridView_entregas.CurrentRow.Cells(4).Value
        TextBox_cantidad.Text = DataGridView_entregas.CurrentRow.Cells(5).Value
        TextBox_orden_compra.Text = DataGridView_entregas.CurrentRow.Cells(6).Value
        TextBox_precio.Text = DataGridView_entregas.CurrentRow.Cells(7).Value
        TextBox_moneda.Text = DataGridView_entregas.CurrentRow.Cells(8).Value
        TextBox_kilogramo.Text = DataGridView_entregas.CurrentRow.Cells(9).Value
        TextBox_clave.Text = DataGridView_entregas.CurrentRow.Cells(10).Value
        TextBox_descripcion.Text = DataGridView_entregas.CurrentRow.Cells(11).Value
        TextBox_calibre.Text = DataGridView_entregas.CurrentRow.Cells(12).Value
        TextBox_observaciones.Text = DataGridView_entregas.CurrentRow.Cells(13).Value
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel_detalles.Visible = False
    End Sub
End Class