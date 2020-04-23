Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

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
        If CFechas.Checked = True Then
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

        BHist.Visible = True
    End Sub

    Private Sub BPMPr_Click(sender As Object, e As EventArgs) Handles BPMPr.Click
        MPInventario.Show()
        MPInventario.TxtOC.Text = TxtBusqueda.Text
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BHist_Click(sender As Object, e As EventArgs) Handles BHist.Click
        If MsgBox("Desea Enviar el Detalle de la " & CFechas.Text & ": " & DTF1.Value.ToString("yyyy-MM-dd") & " a " & DTF2.Value.ToString("yyyy-MM-dd"), vbYesNo) = vbYes Then
            Dim Fecha = DateTime.Now.ToString("dd-MM-yyy")
            Dim smtp As New System.Net.Mail.SmtpClient
            Dim correo As New System.Net.Mail.MailMessage




            With smtp
                .Port = 26
                .Host = "mail.nucleosave.com.mx"
                .Credentials = New System.Net.NetworkCredential("Sistemas01@nucleosave.com.mx", "Sistemas01")
                .EnableSsl = False
            End With
            With correo
                .From = New System.Net.Mail.MailAddress("Sistemas01@nucleosave.com.mx")
                .To.Add("Sistemas01@nucleosave.com.mx")
                .Subject = "Detalle de Rollos con la " & CFechas.Text & ": " & DTF1.Value.ToString("yyyy-MM-dd") & " a " & DTF2.Value.ToString("yyyy-MM-dd")
                .Body = "<p align='right'>Detalle de Rollos con " & CFechas.Text & ": " & DTF1.Value.ToString("yyyy-MM-dd") & " a " & DTF2.Value.ToString("yyyy-MM-dd") & "</p><br />" &
                            "Detalle de Rollos" & "<br />" &
                                "<center>
                                    <table  border= " & 1 & " >
                                        <tr ALIGN=CENTER>
                                            <th> Orden de Compra </th>
                                            <th> Proveedor </th>
                                            <th> Núm. de Rollo Interno </th>
                                            <th> Núm. de Rollo Externo </th>
                                            <th> Calibre </th>
                                            <th> Ancho </th>
                                            <th> Peso </th>
                                            <th> Medida </th>
                                            <th> Descripción </th>
                                            <th> Fecha de Llegada </th>
                                            <th> Fecha de Registro </th>
                                        </tr> 
                                        <tr ALIGN=CENTER>"


                'For i As Integer = 0 To DGHR.ColumnCount - 1
                '           &"<th>" & DGHR.Columns(i).Name & "</th>"
                '   Next
                '      "</tr>"
                '        For Each row As DataGridViewRow In DGHR.Rows
                '        "<tr>"      'Defineuna nueva fila
                '           "<td>" & row.Cells(0).Value & "</td>".
                '            "<td>" & row.Cells(1).Value & "</td>"
                '           "<td>" & row.Cells(2).Value & "</td>"
                '          "</tr>" 

                '         "</table>"

                .IsBodyHtml = True
                .Priority = System.Net.Mail.MailPriority.Normal
            End With

            Try
                smtp.Send(correo)
                MessageBox.Show("Su mensaje de correo ha sido enviado.",
                                "Correo enviado",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message,
                                "Error al enviar correo",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    'Text
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


