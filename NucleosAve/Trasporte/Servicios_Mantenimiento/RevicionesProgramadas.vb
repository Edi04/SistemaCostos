Imports System.Data.SqlClient
Public Class RevicionesProgramadas
    'coneccion de Bd y direcctivas para poder conectar y poder ejecutar consultas
    '----Directivas-->
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    '<--directivas termino-->
    Private Sub RevicionesProgramadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Sub MostrarReg()
        Try
            Dim Func As New Funcion_Controlador
            tabla = Func.FnMostrar_RevicionesP
            If tabla.Rows.Count <> 0 Then
                DataGridView_Reviciones.DataSource = tabla
            Else
                DataGridView_Reviciones.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        MostrarReg()
    End Sub

    Private Sub DataGridView_Reviciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Reviciones.CellContentClick
        TextBox_Realizado.Text = DataGridView_Reviciones.CurrentRow.Cells(8).Value
    End Sub

    Private Sub Btn_Realizada_Click(sender As Object, e As EventArgs) Handles Btn_Realizada.Click
        Dim funciones As New Funcion_Controlador
        Dim logica As New ClassMantenimientos

        logica.T_estado_revision = Me.TextBox_Realizado.Text

        If funciones.FN_InsertarEstado_(logica) Then
            MsgBox("Gracias Por Mantener el trasporte en Buen estado", MessageBoxIcon.Information)
            MostrarReg()
        End If

    End Sub
End Class