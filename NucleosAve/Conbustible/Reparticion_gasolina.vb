Imports System.Data.SqlClient
Public Class Reparticion_gasolina
    '----Directivas-->
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
    Private Sub Reparticion_gasolina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gasolina_premium_actual()
        gasolina_magna_actual()
        diesel_actual()
        GenerarCodigo()
    End Sub

    Sub gasolina_premium_actual()
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("SELECT (convert(varchar(50),litros)) +' '+ 'Lts' FROM TB_Conbustible_Stock WHERE tipo='Gasolina' and mpn='Premium'", conexxo)
        ejecutar = comando.ExecuteReader()
        ejecutar.Read()
        TextBox_litros_stock.Text = ejecutar(0)
        conexxo.Close()
    End Sub

    Sub gasolina_magna_actual()
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("SELECT (convert(varchar(50),litros)) +' '+ 'Lts' FROM TB_Conbustible_Stock WHERE tipo='Gasolina' and  mpn='Magna'", conexxo)
        ejecutar = comando.ExecuteReader()
        ejecutar.Read()
        TextBox_gasolina2.Text = ejecutar(0)
        conexxo.Close()
    End Sub

    Sub diesel_actual()
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("SELECT (convert(varchar(50),litros)) +' '+ 'Lts' FROM TB_Conbustible_Stock WHERE tipo='Diesel' and  mpn='Normal'", conexxo)
        ejecutar = comando.ExecuteReader()
        ejecutar.Read()
        TextBox_diesel.Text = ejecutar(0)
        conexxo.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If MessageBox.Show("El combustible sera descontado del Stock", "Recargar Combustible", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Conbustible
                Dim logica As New ClassConbustible

                logica.Con_codigo = Me.codigooo.Text
                logica.Con_fecha = Me.DateTimePicker_Fecha.Text
                logica.Con_trasporte = Me.TextBox_trasporte.Text
                logica.Con_area = Me.ComboBox_Area.Text
                logica.Con_litros = Me.TextBox_litros_dados.Text
                logica.Con_tipo = Me.ComboBox_Tipo.Text
                logica.Con_cantidad_cuenta = Me.TextBox_cuanto_tiene.Text
                logica.Con_entrego = Me.TextBox_entrego.Text
                logica.Con_quien_porta_unidad = Me.TextBox_quien_porta_unidad.Text
                logica.Con_mpn = Me.ComboBox_mpn.Text
                logica.Con_responsable = Me.TextBox_Responsable.Text


                If funciones.FN_Repartir_conbustible(logica) Then
                    MsgBox("Combustible Entregado Correctamente", MessageBoxIcon.Information)
                    'Generar_Codigo_Combustimble() aqui recargaremos el conbustible stock
                    gasolina_premium_actual()
                    gasolina_magna_actual()
                    diesel_actual()
                    GenerarCodigo()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        TextBox_trasporte.Clear()
        TextBox_litros_dados.Clear()
        TextBox_cuanto_tiene.Clear()
        TextBox_entrego.Clear()
        TextBox_quien_porta_unidad.Clear()
    End Sub

    Sub GenerarCodigo()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_reparticion)from TB_Entrega_Combustible", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        codigooo.Text = "Repart-" + Format(id + 1, "0000") + "/20"
    End Sub

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
    Private Sub TextBox_litros_dados_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextBox_litros_dados.KeyPress
        NumerosyDecimal(TextBox_litros_dados, com)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AltaTrasportes.Show()
    End Sub

    Private Sub TextBox_cuanto_tiene_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextBox_cuanto_tiene.KeyPress
        NumerosyDecimal(TextBox_cuanto_tiene, com)
    End Sub





End Class