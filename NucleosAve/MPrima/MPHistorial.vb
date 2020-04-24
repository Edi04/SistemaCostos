Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net
Imports System.Text.RegularExpressions

Public Class MPHistorial
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub MPHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBusqueda.Text = "-"
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

    Private Sub CFechas_CheckedChanged(sender As Object, e As EventArgs) Handles CFechas.CheckedChanged
        If CFechas.Checked = False Then
            CFechas.Text = "Fecha de Ingreso"
            TxtBusqueda.Text = "-"
        Else
            CFechas.Text = "Fecha de Registro"
            TxtBusqueda.Text = "-"
        End If
    End Sub

    Private Sub BBOC1_Click(sender As Object, e As EventArgs) Handles BBOC1.Click
        Dim Fech1 As String = DTF1.Value.ToString("yyyy-MM-dd")
        Dim Fech2 As String = DTF2.Value.ToString("yyyy-MM-dd")
        If CFechas.Checked = False Then
            Dim Consulta As String = "SELECT Id_MPrim, Proveedor, Num_Interno, Num_Externo, Calibre, Ancho, Peso, UMedida, Descripcion, Fecha_Llegada,
                                      Fecha_Registro, OCompra, CSeguimiento
                                      FROM TB_MateriaPrima
                                      WHERE Estado = 'Almacen MP' AND
                                            Fecha_Registro between '" & Fech1 & "' AND '" & Fech2 & "'"

            Dim cmd As New SqlCommand(Consulta, Conex)

            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()
                Da.Fill(Ds)

                DGHR.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        Else
            Dim Consulta As String = "SELECT Id_MPrim, Proveedor, Num_Interno, Num_Externo, Calibre, Ancho, Peso, UMedida, Descripcion, Fecha_Llegada,
                                      Fecha_Registro, OCompra, CSeguimiento
                                      FROM TB_MateriaPrima
                                      WHERE Estado = 'Almacen MP' AND
                                            Fecha_Llegada between '" & Fech1 & "' AND '" & Fech2 & "'"

            Dim cmd As New SqlCommand(Consulta, Conex)

            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()
                Da.Fill(Ds)

                DGHR.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If

        BInicio.Visible = True
        BExcel.Visible = True
    End Sub

    Private Sub BPMPr_Click(sender As Object, e As EventArgs) Handles BPMPr.Click
        MPInventario.Show()
        MPInventario.TxtOC.Text = TxtBusqueda.Text
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BInicio_Click(sender As Object, e As EventArgs) Handles BInicio.Click
        If PCorreo.Visible = False Then
            PCorreo.Visible = True
        ElseIf PCorreo.Visible = True Then
            PCorreo.Visible = False
        End If
    End Sub

    Private Sub BB1_Click(sender As Object, e As EventArgs) Handles BE1.Click
        If TxtEmail1.Visible = True And TxtEmail2.Visible = False Then
            TxtEmail2.Visible = True
            BMenos.Visible = True
        ElseIf TxtEmail2.Visible = True And TxtEmail3.Visible = False Then
            TxtEmail3.Visible = True
        End If
    End Sub

    Private Sub Menos_Click(sender As Object, e As EventArgs) Handles BMenos.Click
        If TxtEmail1.Visible = True And TxtEmail2.Visible = True And TxtEmail3.Visible = False Then
            TxtEmail2.Visible = False
            TxtEmail2.Text = ""
            BMenos.Visible = False
        ElseIf TxtEmail2.Visible = True And TxtEmail3.Visible = True Then
            TxtEmail3.Visible = False
            TxtEmail3.Text = ""
        End If
    End Sub

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
                "^([\w-]+\.)*?[\w-]+@nucleosave.com.mx") 'nucleosave.com.mx")
    End Function

    Private Sub BHist_Click(sender As Object, e As EventArgs) Handles BHist.Click
        If validar_Mail(LCase(TxtUser.Text)) = False Then
            MsgBox("Correo electronico de " & TxtUser.Text & " no valido")
        Else

            If TxtEmail1.Text <> "" And TxtEmail2.Text = "" And TxtEmail3.Text = "" Then
                If validar_Mail(LCase(TxtEmail1.Text)) = False Then
                    MsgBox("Correo electronico de " & TxtEmail1.Text & " no valido, Ejemplo usuario@nucleosave.com.mx")
                Else
                    Correo()
                End If
            End If

            If TxtEmail1.Text <> "" And TxtEmail2.Text <> "" And TxtEmail3.Text = "" Then
                If validar_Mail(LCase(TxtEmail1.Text)) = False Then
                    MsgBox("Correo electronico de " & TxtEmail1.Text & " no valido, Ejemplo usuario@nucleosave.com.mx")
                ElseIf validar_Mail(LCase(TxtEmail2.Text)) = False Then
                    MsgBox("Correo electronico de " & TxtEmail2.Text & " no valido, Ejemplo usuario@nucleosave.com.mx")
                Else
                    Correo()
                End If
            End If

            If TxtEmail1.Text <> "" And TxtEmail2.Text <> "" And TxtEmail3.Text <> "" Then
                If validar_Mail(LCase(TxtEmail1.Text)) = False Then
                    MsgBox("Correo electronico de " & TxtEmail1.Text & " no valido, Ejemplo usuario@nucleosave.com.mx")
                ElseIf validar_Mail(LCase(TxtEmail2.Text)) = False Then
                    MsgBox("Correo electronico de " & TxtEmail2.Text & " no valido, Ejemplo usuario@nucleosave.com.mx")
                ElseIf validar_Mail(LCase(TxtEmail3.Text)) = False Then
                    MsgBox("Correo electronico de " & TxtEmail3.Text & " no valido, Ejemplo usuario@nucleosave.com.mx")
                Else
                    Correo()
                End If
            End If
        End If
    End Sub

    Private Sub Correo()
        If MsgBox("Desea Enviar el Detalle de la " & CFechas.Text & ": " & DTF1.Value.ToString("yyyy-MM-dd") & " a " & DTF2.Value.ToString("yyyy-MM-dd"), vbYesNo) = vbYes Then
            Try
                Dim correo As New MailMessage
                Dim autenticar As New NetworkCredential
                Dim envio As New SmtpClient

                correo.Body = "<table border='1'>"
                correo.Body &= "<tr>
                                <th>Orden de Compra</th>
                                <th>Proveedor</th>
                                <th>N&uacute;mero de Rollo</th>
                                <th>N&uacute;mero de Rollo del Proveedor</th>
                                <th>Calibre</th>
                                <th>Ancho</th>
                                <th>Peso</th>
                                <th>Medida</th>
                                <th>Descripci&oacute;n</th>
                                <th>Fecha de Llegada</th>
                                <th>Fecha de Registro</th>
                            </tr>"

                For Each row As DataGridViewRow In DGHR.Rows
                    correo.Body &= "<tr>"
                    correo.Body &= "<td align=Center>" & row.Cells(11).Value & "</td>"
                    correo.Body &= "<td>" & row.Cells(1).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(2).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(3).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(4).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(5).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(6).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(7).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(8).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(9).Value & "</td>"
                    correo.Body &= "<td align=Center>" & row.Cells(10).Value & "</td>"
                    correo.Body &= "</tr>"
                Next
                correo.Body &= "</table>"


                correo.Subject = "Reporte de Materia Prima"
                correo.IsBodyHtml = True
                correo.To.Add(Trim(TxtEmail1.Text))
                If TxtEmail2.Text <> "" Then
                    correo.To.Add(Trim(TxtEmail2.Text))
                End If
                If TxtEmail3.Text <> "" Then
                    correo.To.Add(Trim(TxtEmail3.Text))
                End If

                correo.From = New MailAddress(Trim(TxtUser.Text), "Reporte de los Rollos con " & CFechas.Text & ": " & DTF1.Value.ToString("yyyy-MM-dd") & " a " & DTF2.Value.ToString("yyyy-MM-dd"))

                envio.Credentials = New NetworkCredential(Trim(TxtUser.Text), Trim(TxtPassword.Text))
                envio.Host = "mail.nucleosave.com.mx"
                envio.Port = 26
                envio.EnableSsl = True

                envio.Send(correo)

                MessageBox.Show("Correo Enviado exitosamente.", "Reporte de Rollos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TxtEmail1.Text = ""
                TxtEmail2.Text = ""
                TxtEmail3.Text = ""
                PCorreo.Visible = False
            Catch ex As Exception
                MessageBox.Show("Revise que el correo y contraseña de Inicio de Sesión sean correctas.
                      Revise que los correos de destino sean correctos", "Enviar de Detalle de la " & CFechas.Text & ": " & DTF1.Value.ToString("yyyy-MM-dd") & " a " & DTF2.Value.ToString("yyyy-MM-dd"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'Text
    Private Sub TxtUP_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        If TxtUser.Text <> "" Then
            BHist.Visible = True
            BHist.Enabled = True
        Else
            BHist.Visible = False
            BHist.Enabled = True
        End If
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = "" Then
        Else
            Dim Consulta As String = "SELECT Id_MPrim, Proveedor, Num_Interno, Num_Externo, Calibre, Ancho, Peso, UMedida, Descripcion, Fecha_Llegada,
		                                    Fecha_Registro, OCompra, CSeguimiento
                                      FROM TB_MateriaPrima
                                      WHERE Estado = 'Almacen MP' AND
                                            OCompra like '%'+@Busqueda+'%'"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))

            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()
                Da.Fill(Ds)

                DGHR.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
        BHist.Visible = False
    End Sub

    Public Function GridAExcel(ByVal DGV As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DGV.ColumnCount
            Dim NRow As Integer = DGV.RowCount
            'recorremos todas las filas, y por cada fila todas las columnas
            'y vamos escribiendo.

            exHoja.Cells.Item(1, 1) = "Proveedor"
            exHoja.Cells.Item(1, 2) = "Número de Rollo"
            exHoja.Cells.Item(1, 3) = "Número de Rollo del Proveedor"
            exHoja.Cells.Item(1, 4) = "Calibre"
            exHoja.Cells.Item(1, 5) = "Ancho"
            exHoja.Cells.Item(1, 6) = "Peso"
            exHoja.Cells.Item(1, 7) = "Medida"
            exHoja.Cells.Item(1, 8) = "Descripción"
            exHoja.Cells.Item(1, 9) = "Fecha de Llegada"
            exHoja.Cells.Item(1, 10) = "Fecha de Registro"
            exHoja.Cells.Item(1, 11) = "Orden de Compra"

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 1 To NCol - 2
                    exHoja.Cells.Item(Fila + 2, 1) = DGV.Rows(Fila).Cells(1).Value()
                    exHoja.Cells.Item(Fila + 2, 2) = DGV.Rows(Fila).Cells(2).Value()
                    exHoja.Cells.Item(Fila + 2, 3) = DGV.Rows(Fila).Cells(3).Value()
                    exHoja.Cells.Item(Fila + 2, 4) = DGV.Rows(Fila).Cells(4).Value()
                    exHoja.Cells.Item(Fila + 2, 5) = DGV.Rows(Fila).Cells(5).Value()
                    exHoja.Cells.Item(Fila + 2, 6) = DGV.Rows(Fila).Cells(6).Value()
                    exHoja.Cells.Item(Fila + 2, 7) = DGV.Rows(Fila).Cells(7).Value()
                    exHoja.Cells.Item(Fila + 2, 8) = DGV.Rows(Fila).Cells(8).Value()
                    exHoja.Cells.Item(Fila + 2, 9) = DGV.Rows(Fila).Cells(9).Value()
                    exHoja.Cells.Item(Fila + 2, 10) = DGV.Rows(Fila).Cells(10).Value()
                    exHoja.Cells.Item(Fila + 2, 11) = DGV.Rows(Fila).Cells(11).Value()
                Next
            Next

            'Titulo en negrita, Alineado 
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'para visualizar el libro
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False
        End Try
        Return True
    End Function

    Private Sub BExcel_Click(sender As Object, e As EventArgs) Handles BExcel.Click
        Call GridAExcel(DGHR)
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


