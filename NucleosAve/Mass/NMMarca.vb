Imports System.Data.SqlClient

Public Class NMMarca
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TxtMarca.Text = "" Then
            MessageBox.Show("Ingrese el Dato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Conex.Open()
                Dim M As String = TxtMarca.Text
                Dim CONSULTA As String = "INSERT INTO TB_Marcas
                                            (Marca, Estado)
                                        VALUES ('" & M & "', 'AMass' )"
                Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                COMANDO.ExecuteNonQuery()
                Conex.Close()
                Close()
            Catch ex As Exception
                MessageBox.Show("Error al Guardar", "ERROR", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
        MInventario.Show()
    End Sub
End Class