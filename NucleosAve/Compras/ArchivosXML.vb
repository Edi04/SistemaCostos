Public Class ArchivosXML
    Private Sub ArchivosXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ':::Capturador de errores Try
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim Total = My.Computer.FileSystem.GetFiles("\\ANTUA-PC\Servidor_de_Archivos\Documentos\XML", FileIO.SearchOption.SearchAllSubDirectories, "*.xml")
            LblTotal.Text = "N# Facturas XML: " + CStr(Total.Count)

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles("\\ANTUA-PC\Servidor_de_Archivos\Documentos\XML", FileIO.SearchOption.SearchAllSubDirectories, "*.xml")
                'ListBox1.Items.Add(Path.GetFileName(archivos)) solo te da el nombre
                ListBox1.Items.Add(archivos)

            Next

        Catch ex As Exception
            MsgBox("No se realizó la operación por: " & ex.Message)
        End Try
    End Sub


    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        directoriotxt.Text = ListBox1.SelectedItem.ToString()
    End Sub

    Private Sub descargarxml_Click(sender As Object, e As EventArgs) Handles descargarxml.Click
        Try
            Dim direccion As String
            direccion = directoriotxt.Text
            My.Computer.FileSystem.CopyFile(direccion, "C:\Archivos\XML\Facturas.xml", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

            MsgBox("Descarga Exitosa", MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Warning)
        End Try

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
End Class