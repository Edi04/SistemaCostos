Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class ETickets
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub ETickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaActual()
        Nombres()

    End Sub


    'Botones
    Public Sub Impresion_Click(sender As Object, e As EventArgs) Handles Impresion.Click
        Dim PrintTxt As New PrintDocument()
        Try
            'Documentos
            PrintTxt.PrinterSettings.PrinterName = "EPSON TM-T20II Receipt"

            'Evento Print
            AddHandler PrintTxt.PrintPage, AddressOf Me.Datos
            PrintTxt.Print()
            Close()

        Catch ex As Exception
            MsgBox("ERROR al Imprimir" & vbCrLf & ex.Message)

            PrintTxt.PrinterSettings.PrinterName = "Microsoft Print to PDF"

            'Evento print
            AddHandler PrintTxt.PrintPage, AddressOf Me.Datos
            PrintTxt.Print()
            Close()

        End Try
    End Sub


    'Funciones
    '   Hora - Fecha
    Private Sub FechaActual()
        Dim D = DateTime.Now
        Dim FechaT As String = D

        Fecha.Text = FechaT

    End Sub

    Private Sub Datos(ByVal sender As System.Object, ByVal e As PrintPageEventArgs)
        Dim PT As New Font("Consolas", 10)

        'Impresión
        e.Graphics.DrawString(LTitulo.Text.Trim, New Font("Arial", 15, FontStyle.Bold), Brushes.Black, 20, 25)
        e.Graphics.DrawImage(PLogo.Image, 250, 1, 60, 60)
        e.Graphics.DrawString("Fecha:" & " " & Trim(Fecha.Text), New Font("Consolas", 10), Brushes.Black, 10, 60)
        e.Graphics.DrawString(LLinea.Text.Trim, New Font("Arial", 11), Brushes.Black, 0, 62)
        e.Graphics.DrawString("  ID" & "  " & "Producto" & "              " & "Cantidad", PT, Brushes.Black, 0, 85)
        e.Graphics.DrawString(LLinea1.Text.Trim, New Font("Arial", 11), Brushes.Black, 0, 87)

        For Each row As DataGridViewRow In Me.DatosDG.Rows
            Dim T As Integer = 100
            For filas As Integer = 0 To DatosDG.RowCount - 1
                T = T + 12
                For Columnas As Integer = 0 To DatosDG.ColumnCount - 1
                    Dim IES As New String(DatosDG.Item(0, filas).Value)
                    Dim IPS As New String(DatosDG.Item(1, filas).Value)
                    Dim ICS As New String(DatosDG.Item(2, filas).Value)
                    e.Graphics.DrawString(IES.PadLeft(5), New Font("Consolas", 8), Brushes.Black, 0, T)
                    e.Graphics.DrawString(IPS, New Font("Consolas", 8), Brushes.Black, 50, T)
                    e.Graphics.DrawString(ICS.PadLeft(10), New Font("Consolas", 8), Brushes.Black, 200, T)
                Next
            Next
        Next

        For Each row As DataGridViewRow In Me.DatosDG.Rows
            Dim T As Integer = DatosDG.Rows.Count
            T = T * 12

            e.Graphics.DrawString(LLinea2.Text.Trim, New Font("Arial", 11), Brushes.Black, 10, 130 + T)
            e.Graphics.DrawString(LResponsable.Text.Trim, New Font("Consolas", 10), Brushes.Black, 10, 150 + T)
            e.Graphics.DrawString(LUsuario.Text.Trim, New Font("Consolas", 10), Brushes.Black, 50, 160 + T)
            e.Graphics.DrawString(LTrabajado.Text.Trim, New Font("Consolas", 10), Brushes.Black, 10, 180 + T)
            e.Graphics.DrawString(LTrabajador.Text.Trim, New Font("Consolas", 10), Brushes.Black, 50, 192 + T)
        Next
    End Sub


    'Consultas
    Private Sub Nombres()
        Dim Consulta As String = "SELECT ( E.Nombre_Empleado+ ' ' + E.Ape_Paterno+' ' +  E.Ape_Materno) AS Nombre
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
        End If
        Da.Close()
        Conex.Close()
    End Sub

End Class